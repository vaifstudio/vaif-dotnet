using System.Collections.Concurrent;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Vaif.Client;

/// <summary>Authenticates app users, manages their sessions, and starts OAuth and MFA flows.</summary>
public sealed class AuthClient
{
    private readonly VaifClient _client;
    private readonly ConcurrentDictionary<string, (string Verifier, DateTimeOffset Created)> _pending = new();
    private readonly SemaphoreSlim _refreshLock = new(1, 1);
    private long _lastSourceRevision = -1;
    private long _lastSavedRevision = -1;
    private AuthResult? _lastRefresh;
    private string Prefix => _client.ProjectId == null ? "/auth" : "/projects/" + _client.RequireProject() + "/auth";
    private IDictionary<string, string>? RefreshHeaders => _client.ProjectId == null ? null : new Dictionary<string, string> { ["X-Vaif-Refresh-Mode"] = "body" };
    /// <summary>Gets the MFA enrollment, verification, and recovery-code operations.</summary>
    public MfaClient Mfa { get; }
    internal AuthClient(VaifClient client) { _client = client; Mfa = new MfaClient(this); }

    /// <summary>Creates an app user and saves a completed session. Requires ProjectId; platform signup is console-only.</summary>
    public Task<AuthResult> SignUpAsync(string email, string password, JsonElement? options = null, CancellationToken cancellationToken = default)
    {
        if (_client.ProjectId == null) throw new VaifConsoleOnlyException();
        return IssueAsync(Prefix + "/signup", Merge(options, ("email", email), ("password", password)), cancellationToken);
    }
    /// <summary>Signs in with email and password, optionally supplies an MFA code, and saves a completed session.</summary>
    public Task<AuthResult> SignInAsync(string email, string password, string? mfaCode = null, CancellationToken cancellationToken = default) =>
        IssueAsync(Prefix + "/login", VaifJson.Object(("email", email), ("password", password), ("mfaCode", mfaCode)), cancellationToken);
    /// <summary>Revokes the session using its refresh credential and clears storage after success. Storage failures are reported to the caller.</summary>
    public async Task SignOutAsync(CancellationToken cancellationToken = default)
    {
        var snapshot = await _client.Sessions.BeginSignOutAsync(cancellationToken).ConfigureAwait(false);
        try
        {
            var tokens = snapshot.Session;
            var headers = TokenHeaders(tokens?.RefreshToken);
            if (string.IsNullOrEmpty(tokens?.RefreshToken) && !string.IsNullOrEmpty(tokens?.AccessToken)) headers["Authorization"] = "Bearer " + tokens!.AccessToken;
            // Logout accepts the refresh credential even when access has expired.
            await _client.JsonAsync("POST", Prefix + "/logout", VaifJson.Object(("refreshToken", tokens?.RefreshToken)), cancellationToken, authenticated: false, headers: headers).ConfigureAwait(false);
            await _client.Sessions.ClearIfCurrentAsync(snapshot.Revision, CancellationToken.None).ConfigureAwait(false);
        }
        finally { await _client.Sessions.EndSignOutAsync(snapshot.Revision).ConfigureAwait(false); }
    }
    /// <summary>Rotates the current session credentials. Rejects completion if sign-out or a replacement session changed the session.</summary>
    public async Task<AuthResult> RefreshAsync(CancellationToken cancellationToken = default)
    {
        var snapshot = await _client.Sessions.SnapshotAsync(cancellationToken).ConfigureAwait(false);
        return await RefreshSnapshotAsync(snapshot.Session, snapshot.Revision, cancellationToken).ConfigureAwait(false);
    }
    internal async Task<AuthResult> RefreshSnapshotAsync(TokenSession? session, long revision, CancellationToken ct)
    {
        await _refreshLock.WaitAsync(ct).ConfigureAwait(false);
        try
        {
            var current = await _client.Sessions.SnapshotAsync(ct).ConfigureAwait(false);
            if (_lastSourceRevision == revision && _lastSavedRevision == current.Revision && _lastRefresh != null) return _lastRefresh;
            if (current.Revision != revision) throw new VaifException("The session changed before refresh.", "SESSION_CHANGED");
            if (string.IsNullOrEmpty(session?.RefreshToken)) throw new VaifException("No refresh token in the token store.", "REFRESH_TOKEN_REQUIRED");
            var result = await IssueAsync(Prefix + "/refresh", VaifJson.Object(("refreshToken", session!.RefreshToken)), ct, TokenHeaders(session.RefreshToken), revision).ConfigureAwait(false);
            _lastSourceRevision = revision;
            _lastSavedRevision = revision + 1;
            _lastRefresh = result;
            return result;
        }
        finally { _refreshLock.Release(); }
    }
    private IDictionary<string, string> TokenHeaders(string? token)
    {
        var headers = RefreshHeaders ?? new Dictionary<string, string>();
        if (token != null) headers["Cookie"] = (_client.ProjectId == null ? "refresh_token=" : "project_refresh_token=") + Uri.EscapeDataString(token);
        return headers;
    }
    /// <summary>Returns the current authenticated user from the API.</summary>
    public async Task<JsonElement> GetUserAsync(CancellationToken cancellationToken = default)
    {
        var result = await _client.JsonAsync("GET", Prefix + "/me", null, cancellationToken).ConfigureAwait(false);
        return VaifJson.Required(result, "user", JsonValueKind.Object).Clone();
    }
    /// <summary>Requests a password reset for an app user. Platform password reset is console-only.</summary>
    public Task<JsonElement> RequestPasswordResetAsync(string email, string? redirectUrl = null, CancellationToken cancellationToken = default)
    {
        if (_client.ProjectId == null) throw new VaifConsoleOnlyException();
        return _client.JsonAsync("POST", Prefix + "/forgot-password", VaifJson.Object(("email", email), ("redirectUrl", redirectUrl)), cancellationToken, false);
    }
    /// <summary>Resets an app user password using a reset token. Platform password reset is console-only.</summary>
    public Task<JsonElement> ConfirmPasswordResetAsync(string token, string password, CancellationToken cancellationToken = default)
    {
        if (_client.ProjectId == null) throw new VaifConsoleOnlyException();
        return _client.JsonAsync("POST", Prefix + "/reset-password", VaifJson.Object(("token", token), ("password", password)), cancellationToken, false);
    }
    /// <summary>Starts OAuth sign-in with a cryptographic state and PKCE S256 challenge. Pending state expires after ten minutes.</summary>
    public async Task<OAuthSignIn> StartOAuthAsync(string provider, string redirectUrl, CancellationToken cancellationToken = default)
    {
        var prefix = "/projects/" + _client.RequireProject() + "/auth";
        if (!Uri.TryCreate(redirectUrl, UriKind.Absolute, out _)) throw new ArgumentException("An absolute registered redirect URL is required.", nameof(redirectUrl));
        foreach (var item in _pending) if (DateTimeOffset.UtcNow - item.Value.Created > TimeSpan.FromMinutes(10)) _pending.TryRemove(item.Key, out _);
        var verifier = RandomUrlSafe(); var state = RandomUrlSafe();
        string challenge; using (var sha = SHA256.Create()) challenge = Base64Url(sha.ComputeHash(Encoding.ASCII.GetBytes(verifier)));
        var result = await _client.JsonAsync("POST", prefix + "/oauth/" + VaifClient.Segment(provider) + "/start", VaifJson.Object(("redirectUrl", redirectUrl), ("codeChallenge", challenge), ("codeChallengeMethod", "S256"), ("state", state)), cancellationToken, false).ConfigureAwait(false);
        var url = VaifJson.Required(result, "url", JsonValueKind.String).GetString();
        if (string.IsNullOrEmpty(url) || !Uri.TryCreate(url, UriKind.Absolute, out _)) throw VaifJson.InvalidResponse();
        _pending[state] = (verifier, DateTimeOffset.UtcNow);
        return new OAuthSignIn(url!, state, verifier);
    }
    /// <summary>Exchanges an OAuth code using a pending PKCE verifier and saves the session. State can be redeemed only once.</summary>
    public Task<AuthResult> CompleteOAuthAsync(string code, string state, CancellationToken cancellationToken = default)
    {
        var prefix = "/projects/" + _client.RequireProject() + "/auth";
        if (string.IsNullOrEmpty(state) || !_pending.TryRemove(state, out var pending) || DateTimeOffset.UtcNow - pending.Created > TimeSpan.FromMinutes(10))
            throw new VaifException("Unknown, expired or already redeemed OAuth state. Start sign-in again.", "OAUTH_STATE_MISMATCH");
        return IssueAsync(prefix + "/oauth/token", VaifJson.Object(("code", code), ("codeVerifier", pending.Verifier)), cancellationToken);
    }
    private static string RandomUrlSafe() { var bytes = new byte[32]; using (var rng = RandomNumberGenerator.Create()) rng.GetBytes(bytes); return Base64Url(bytes); }
    private static string Base64Url(byte[] bytes) => Convert.ToBase64String(bytes).TrimEnd('=').Replace('+', '-').Replace('/', '_');
    internal async Task<AuthResult> IssueAsync(string path, JsonElement body, CancellationToken ct, IDictionary<string, string>? headers = null, long? expectedRevision = null)
    {
        using var response = await _client.SendAsync("POST", path, body, ct, false, headers ?? RefreshHeaders).ConfigureAwait(false);
        var json = await VaifClient.ReadJsonAsync(response, ct).ConfigureAwait(false);
        AuthResult result;
        try { result = JsonSerializer.Deserialize(json.GetRawText(), VaifJsonContext.Default.AuthResult) ?? throw VaifJson.InvalidResponse(); }
        catch (JsonException) { throw VaifJson.InvalidResponse(); }
        if (result.MfaRequired) return result;
        result.AccessToken = result.AccessToken ?? result.Token;
        result.Token = result.AccessToken;
        if (response.Headers.TryGetValues("Set-Cookie", out var cookies))
        {
            var name = _client.ProjectId == null ? "refresh_token=" : "project_refresh_token=";
            foreach (var cookie in cookies)
            {
                var pair = cookie.Split(';')[0].Trim();
                if (pair.StartsWith(name, StringComparison.Ordinal)) result.RefreshToken = Uri.UnescapeDataString(pair.Substring(name.Length));
            }
        }
        if (string.IsNullOrEmpty(result.AccessToken)) throw new VaifException("Auth response has no access token.", "INVALID_RESPONSE");
        result.ExpiresAt = result.ExpiresAt ?? (result.ExpiresIn.HasValue ? DateTimeOffset.UtcNow.AddSeconds(result.ExpiresIn.Value) : (DateTimeOffset?)null);
        var session = new TokenSession { AccessToken = result.AccessToken!, RefreshToken = result.RefreshToken, ExpiresAt = result.ExpiresAt };
        if (expectedRevision.HasValue) await _client.Sessions.CompareAndSetAsync(session, expectedRevision.Value, ct).ConfigureAwait(false);
        else await _client.Tokens.SetAsync(session, ct).ConfigureAwait(false);
        return result;
    }
    private static JsonElement Merge(JsonElement? options, params (string Name, object? Value)[] fields) => VaifJson.Write(writer =>
    {
        var data = VaifJson.Object(fields); writer.WriteStartObject();
        if (options.HasValue)
        {
            if (options.Value.ValueKind != JsonValueKind.Object) throw new ArgumentException("Expected JSON object options.");
            foreach (var item in options.Value.EnumerateObject()) if (!fields.Any(f => f.Name == item.Name)) item.WriteTo(writer);
        }
        foreach (var item in data.EnumerateObject()) item.WriteTo(writer); writer.WriteEndObject();
    });

    /// <summary>Enrolls and verifies TOTP MFA and manages recovery codes for the current auth scope.</summary>
    public sealed class MfaClient
    {
        private readonly AuthClient _auth;
        internal MfaClient(AuthClient auth) { _auth = auth; }
        private Task<JsonElement> Call(string suffix, JsonElement? body, CancellationToken ct) => _auth._client.JsonAsync("POST", _auth.Prefix + "/mfa/" + suffix, body, ct);
        /// <summary>Starts TOTP enrollment and returns the enrollment secret and token supplied by the server.</summary>
        public Task<JsonElement> EnrollStartAsync(CancellationToken cancellationToken = default) => Call("enroll-start", null, cancellationToken);
        /// <summary>Confirms enrollment with an enrollment token and current TOTP code.</summary>
        public Task<JsonElement> EnrollConfirmAsync(string enrollToken, string code, CancellationToken cancellationToken = default) => Call("enroll-confirm", VaifJson.Object(("enrollToken", enrollToken), ("code", code)), cancellationToken);
        /// <summary>Verifies an MFA challenge with a TOTP or recovery code and saves the completed session.</summary>
        public Task<AuthResult> VerifyAsync(string challengeToken, string code, CancellationToken cancellationToken = default) => _auth.IssueAsync(_auth.Prefix + "/mfa/verify", VaifJson.Object(("challengeToken", challengeToken), ("code", code)), cancellationToken);
        /// <summary>Disables MFA after verifying the supplied code.</summary>
        public Task<JsonElement> DisableAsync(string code, CancellationToken cancellationToken = default) => Call("disable", VaifJson.Object(("code", code)), cancellationToken);
        /// <summary>Replaces the recovery codes after verifying the supplied code.</summary>
        public Task<JsonElement> RegenerateCodesAsync(string code, CancellationToken cancellationToken = default) => Call("regenerate-codes", VaifJson.Object(("code", code)), cancellationToken);
    }
}
