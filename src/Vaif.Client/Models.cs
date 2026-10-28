using System.Text.Json;
using System.Text.Json.Serialization;

namespace Vaif.Client;

/// <summary>Configures the API endpoint, project, credentials, and session storage for a client.</summary>
public sealed class VaifClientOptions
{
    /// <summary>Gets or sets the API base URL. HTTPS is required; HTTP is accepted only for localhost, 127.0.0.1 and ::1.</summary>
    public Uri BaseUrl { get; set; } = new Uri("https://api.vaif.studio");
    /// <summary>Gets or sets the API request send and response-header timeout. Defaults to 100 seconds; signed asset transfers use caller cancellation only.</summary>
    public TimeSpan RequestTimeout { get; set; } = TimeSpan.FromSeconds(100);
    /// <summary>Gets or sets the API key sent to the API. Use a publishable key in distributed applications.</summary>
    public string? ApiKey { get; set; }
    /// <summary>Gets or sets the project ID used for app-user authentication and data requests.</summary>
    public string? ProjectId { get; set; }
    /// <summary>Gets or sets the bucket name or ID used when a storage request omits its bucket.</summary>
    public string DefaultBucket { get; set; } = "default";
    /// <summary>Gets or sets custom session storage. Set either this property or TokenVault. When neither is set, sessions stay in memory.</summary>
    public ITokenStorage? TokenStorage { get; set; }
    /// <summary>Gets or sets a secure vault for persistent sessions scoped to the API origin and project.</summary>
    public ITokenVault? TokenVault { get; set; }
}

/// <summary>One client represents one app user's session. Implement with the OS secure store.</summary>
public interface ITokenStorage
{
    /// <summary>Reads the current session, or returns null when no session is stored.</summary>
    Task<TokenSession?> GetAsync(CancellationToken cancellationToken = default);
    /// <summary>Replaces the stored session with the supplied credentials.</summary>
    Task SetAsync(TokenSession session, CancellationToken cancellationToken = default);
    /// <summary>Removes the stored session and its credentials.</summary>
    Task ClearAsync(CancellationToken cancellationToken = default);
}

/// <summary>Stores a single session in memory and returns copies to prevent external mutation.</summary>
public sealed class MemoryTokenStorage : ITokenStorage
{
    private TokenSession? _session;
    /// <summary>Reads the current session, or returns null when no session is stored.</summary>
    public Task<TokenSession?> GetAsync(CancellationToken cancellationToken = default)
    { cancellationToken.ThrowIfCancellationRequested(); return Task.FromResult(_session?.Copy()); }
    /// <summary>Replaces the stored session with the supplied credentials.</summary>
    public Task SetAsync(TokenSession session, CancellationToken cancellationToken = default)
    { cancellationToken.ThrowIfCancellationRequested(); _session = session.Copy(); return Task.CompletedTask; }
    /// <summary>Removes the stored session and its credentials.</summary>
    public Task ClearAsync(CancellationToken cancellationToken = default)
    { cancellationToken.ThrowIfCancellationRequested(); _session = null; return Task.CompletedTask; }
}

/// <summary>Contains the credentials and optional expiration time for one app-user session.</summary>
public sealed class TokenSession
{
    /// <summary>Gets or sets the access token used to authenticate API requests.</summary>
    public string AccessToken { get; set; } = "";
    /// <summary>Gets or sets the refresh credential, or null when the server did not issue one.</summary>
    public string? RefreshToken { get; set; }
    /// <summary>Gets or sets the access token expiration time, when provided by the server.</summary>
    public DateTimeOffset? ExpiresAt { get; set; }
    internal TokenSession Copy() => new TokenSession { AccessToken = AccessToken, RefreshToken = RefreshToken, ExpiresAt = ExpiresAt };
}

/// <summary>Contains an authentication response, including either session credentials or an MFA challenge.</summary>
public sealed class AuthResult
{
    /// <summary>Gets or sets the success flag supplied by the server.</summary>
    public bool Ok { get; set; }
    /// <summary>Gets or sets the access token used to authenticate API requests.</summary>
    public string? AccessToken { get; set; }
    /// <summary>Gets or sets the legacy access token alias. Completed sign-in normalizes it to AccessToken.</summary>
    public string? Token { get; set; }
    /// <summary>Gets or sets the refresh credential, or null when the server did not issue one.</summary>
    public string? RefreshToken { get; set; }
    /// <summary>Gets or sets the access token lifetime in seconds, when provided by the server.</summary>
    public int? ExpiresIn { get; set; }
    /// <summary>Gets or sets the access token expiration time, when provided by the server.</summary>
    public DateTimeOffset? ExpiresAt { get; set; }
    /// <summary>Gets or sets whether an MFA challenge must be verified before saving a session.</summary>
    public bool MfaRequired { get; set; }
    /// <summary>Gets or sets the temporary challenge token used for MFA verification.</summary>
    public string? ChallengeToken { get; set; }
    /// <summary>Gets or sets the user data supplied by the server.</summary>
    public JsonElement User { get; set; }
}

/// <summary>Contains the authorization URL and PKCE state for a pending OAuth sign-in.</summary>
public sealed class OAuthSignIn
{
    /// <summary>Gets the provider authorization URL to open in the application browser.</summary>
    public string Url { get; }
    /// <summary>Gets the cryptographic state value that must be returned unchanged when completing sign-in.</summary>
    public string State { get; }
    /// <summary>Gets the PKCE verifier. Treat this value as a secret; the auth client retains it for token exchange.</summary>
    public string CodeVerifier { get; }
    internal OAuthSignIn(string url, string state, string verifier) { Url = url; State = state; CodeVerifier = verifier; }
}

/// <summary>Reports an API, session, or transport failure with a stable code and optional server details.</summary>
public class VaifException : Exception
{
    /// <summary>Gets the error code supplied by the server or SDK.</summary>
    public string Code { get; }
    /// <summary>Gets the HTTP status code, or null when no HTTP response is available. Realtime close errors carry the WebSocket close status.</summary>
    public int? StatusCode { get; }
    /// <summary>Gets the server request identifier, when available.</summary>
    public string? RequestId { get; }
    /// <summary>Gets additional error details returned by the server, when available.</summary>
    public JsonElement? Details { get; }
    /// <summary>Creates an SDK exception with a message, code, and optional response metadata.</summary>
    public VaifException(string message, string code = "UNKNOWN", int? statusCode = null, string? requestId = null, JsonElement? details = null) : base(message)
    { Code = code; StatusCode = statusCode; RequestId = requestId; Details = details; }
}

/// <summary>Indicates that platform account creation or password reset must be completed in the console.</summary>
public sealed class VaifConsoleOnlyException : VaifException
{
    /// <summary>Creates an exception with the CONSOLE_ONLY code and console account instructions.</summary>
    public VaifConsoleOnlyException() : base("Create or reset a VAIF Studio account in the console at https://vaif.studio. App-user auth requires ProjectId.", "CONSOLE_ONLY") { }
}

[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
[JsonSerializable(typeof(AuthResult))]
[JsonSerializable(typeof(TokenSession))]
internal partial class VaifJsonContext : JsonSerializerContext { }
