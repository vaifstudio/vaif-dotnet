using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Vaif.Client;

/// <summary>Async VAIF API client. Injected handlers remain owned by the caller.</summary>
public sealed class VaifClient : IDisposable
{
    internal Uri BaseUrl { get; }
    internal string? ApiKey { get; }
    internal string? ProjectId { get; }
    private readonly HttpClient _http;
    private readonly HttpClient _assets;
    private readonly TimeSpan _requestTimeout;
    internal SessionStorage Sessions { get; }
    /// <summary>Gets the session store with guarded replacement, refresh, and sign-out operations.</summary>
    public ITokenStorage Tokens => Sessions;
    /// <summary>Gets app-user authentication and session operations.</summary>
    public AuthClient Auth { get; }
    /// <summary>Gets file storage and signed URL operations.</summary>
    public StorageClient Storage { get; }
    /// <summary>Gets function invocation operations.</summary>
    public FunctionsClient Functions { get; }
    /// <summary>Gets the generated API operations and their descriptors.</summary>
    public Operations Operations { get; }

    /// <summary>Creates a client. Standard HTTP handlers have redirects and cookies disabled; injected handlers remain owned by the caller.</summary>
    public VaifClient(VaifClientOptions options, HttpMessageHandler? httpHandler = null, HttpMessageHandler? assetHttpHandler = null)
    {
        if (options == null) throw new ArgumentNullException(nameof(options));
        ValidateUrl(options.BaseUrl);
        if (!string.IsNullOrEmpty(options.BaseUrl.Query) || !string.IsNullOrEmpty(options.BaseUrl.Fragment)) throw new ArgumentException("BaseUrl must not contain a query or fragment.");
        BaseUrl = new Uri(options.BaseUrl.AbsoluteUri.TrimEnd('/') + "/"); ApiKey = options.ApiKey; ProjectId = options.ProjectId;
        if (options.TokenStorage != null && options.TokenVault != null) throw new ArgumentException("Choose TokenStorage or TokenVault.");
        Sessions = new SessionStorage(options.TokenStorage ?? (options.TokenVault != null ? new SecureTokenStorage(options.TokenVault, BaseUrl, ProjectId) : new MemoryTokenStorage()));
        if (options.RequestTimeout != Timeout.InfiniteTimeSpan && (options.RequestTimeout <= TimeSpan.Zero || options.RequestTimeout.TotalMilliseconds > int.MaxValue))
            throw new ArgumentOutOfRangeException(nameof(options.RequestTimeout));
        _requestTimeout = options.RequestTimeout;
        _http = NewHttpClient(httpHandler); _assets = NewHttpClient(assetHttpHandler);
        Auth = new AuthClient(this); Storage = new StorageClient(this, options.DefaultBucket); Functions = new FunctionsClient(this); Operations = new Operations(this);
    }
    private static HttpClient NewHttpClient(HttpMessageHandler? handler)
    {
        if (handler == null) return new HttpClient(new HttpClientHandler { AllowAutoRedirect = false, UseCookies = false }) { Timeout = Timeout.InfiniteTimeSpan };
        var current = handler;
        while (current is DelegatingHandler delegating && delegating.InnerHandler != null) current = delegating.InnerHandler;
        if (current is HttpClientHandler standard)
        {
            if (standard.AllowAutoRedirect) standard.AllowAutoRedirect = false;
            if (standard.UseCookies) standard.UseCookies = false;
        }
        else
        {
            // Hosts can supply SocketsHttpHandler or WinHttpHandler even when
            // loading the .NET Standard asset. Configure their public switches
            // without requiring a runtime-specific type in that assembly.
            foreach (var name in new[] { "AllowAutoRedirect", "UseCookies" })
            {
                var property = current.GetType().GetProperty(name, typeof(bool));
                if (property?.CanRead == true && property.CanWrite && (bool)property.GetValue(current)!) property.SetValue(current, false);
            }
        }
        return new HttpClient(handler, disposeHandler: false) { Timeout = Timeout.InfiniteTimeSpan };
    }
    internal static string Segment(string value) => string.IsNullOrEmpty(value) || value == "." || value == ".."
        ? throw new ArgumentException("Invalid path segment.", nameof(value)) : Uri.EscapeDataString(value);
    internal static void ValidateUrl(Uri uri)
    {
        if (!uri.IsAbsoluteUri || !string.IsNullOrEmpty(uri.UserInfo) || (uri.Scheme != "https" && !(uri.Scheme == "http" && (uri.Host == "localhost" || uri.Host == "127.0.0.1" || uri.Host == "[::1]" || uri.Host == "::1"))))
            throw new VaifException("Use HTTPS, or HTTP on localhost, 127.0.0.1 or ::1, without URL credentials.", "INVALID_URL");
    }
    internal string RequireProject() => !string.IsNullOrWhiteSpace(ProjectId) ? Segment(ProjectId!) : throw new VaifException("Set ProjectId for this method.", "PROJECT_ID_REQUIRED");
    /// <summary>Creates an immutable query for a table in the configured project.</summary>
    public TableQuery From(string table) => new TableQuery(this, table);
    /// <summary>Creates a realtime connection owned by the caller. Dispose it independently of this client.</summary>
    public RealtimeClient CreateRealtimeClient() => new RealtimeClient(this);

    internal static void GuardConsoleOnly(string method, string path)
    {
        if (method == "POST" && (path == "/auth/signup" || path == "/auth/forgot-password" || path == "/auth/reset-password")) throw new VaifConsoleOnlyException();
    }
    internal async Task<HttpResponseMessage> SendAsync(string method, string path, JsonElement? body, CancellationToken ct, bool authenticated = true, IDictionary<string, string>? headers = null, HttpContent? content = null)
    {
        ct.ThrowIfCancellationRequested();
        if (!path.StartsWith("/", StringComparison.Ordinal) || path.StartsWith("//", StringComparison.Ordinal) || path.Contains("#")) throw new ArgumentException("Expected an API path.", nameof(path));
        var uri = new Uri(BaseUrl.AbsoluteUri.TrimEnd('/') + path);
        var basePath = BaseUrl.AbsolutePath.TrimEnd('/');
        if (!uri.AbsolutePath.StartsWith(basePath + "/", StringComparison.Ordinal)) throw new ArgumentException("Expected an API path.", nameof(path));
        var canonicalPath = uri.AbsolutePath.Substring(basePath.Length);
        GuardConsoleOnly(method, canonicalPath);
        GuardStaffOnly(method, canonicalPath);
        if (body.HasValue && content != null) throw new ArgumentException("Supply JSON Body or Content, not both.");
        var snapshot = authenticated ? await Sessions.SnapshotAsync(ct).ConfigureAwait(false) : default;
        for (int attempt = 0; ; attempt++)
        {
            using var request = new HttpRequestMessage(new HttpMethod(method), uri);
            request.Content = content ?? (body.HasValue ? new StringContent(body.Value.GetRawText(), Encoding.UTF8, "application/json") : null);
            if (headers != null) foreach (var header in headers)
            {
                if (!request.Headers.TryAddWithoutValidation(header.Key, header.Value))
                {
                    if (request.Content == null || !request.Content.Headers.TryAddWithoutValidation(header.Key, header.Value)) throw new ArgumentException("Unsupported request header: " + header.Key);
                }
            }
            if (ApiKey != null) { request.Headers.Remove("x-vaif-key"); request.Headers.Add("x-vaif-key", ApiKey); }
            if (!string.IsNullOrEmpty(snapshot.Session?.AccessToken)) request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", snapshot.Session!.AccessToken);
            request.Headers.TryAddWithoutValidation("Accept-Versions", "v1");
            using var deadline = CancellationTokenSource.CreateLinkedTokenSource(ct);
            deadline.CancelAfter(_requestTimeout);
            HttpResponseMessage response;
            try { response = await _http.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, deadline.Token).ConfigureAwait(false); }
            catch (OperationCanceledException) when (ct.IsCancellationRequested) { throw; }
            catch (OperationCanceledException) { throw new VaifException("The request timed out.", "TIMEOUT"); }
            catch (Exception) { throw new VaifException("The API transport failed.", "TRANSPORT_ERROR"); }
            RefuseRedirect(request, response);
            // The API always stamps a completed function run; its status and body
            // are customer content, even when they imitate TOKEN_INVALID.
            if (response.IsSuccessStatusCode || (IsFunctionInvoke(path) && response.Headers.Contains("X-Vaif-Run-Id"))) return response;
            try
            {
                using (response) { await ThrowApiErrorAsync(response, ct).ConfigureAwait(false); }
            }
            catch (VaifException ex) when (attempt == 0 && authenticated && content == null &&
                ex.StatusCode == 401 &&
                (ex.Code == "TOKEN_EXPIRED" || ex.Code == "TOKEN_INVALID") &&
                !string.IsNullOrEmpty(snapshot.Session?.RefreshToken) && !(headers?.Keys.Any(k => k.Equals("Authorization", StringComparison.OrdinalIgnoreCase)) ?? false))
            {
                var refreshed = await Auth.RefreshSnapshotAsync(snapshot.Session, snapshot.Revision, ct).ConfigureAwait(false);
                var current = await Sessions.SnapshotAsync(ct).ConfigureAwait(false);
                if (current.Revision != snapshot.Revision + 1 || string.IsNullOrEmpty(current.Session?.AccessToken) ||
                    current.Session!.AccessToken != refreshed.AccessToken)
                    throw new VaifException("The session changed before the request could be retried.", "SESSION_CHANGED");
                snapshot = current;
            }
        }
    }
    private static bool IsFunctionInvoke(string path) => path.StartsWith("/functions/", StringComparison.Ordinal) && path.Split('?')[0].EndsWith("/invoke", StringComparison.Ordinal);
    internal async Task<JsonElement> JsonAsync(string method, string path, JsonElement? body, CancellationToken ct, bool authenticated = true, IDictionary<string, string>? headers = null)
    {
        using var response = await SendAsync(method, path, body, ct, authenticated, headers).ConfigureAwait(false);
        return await ReadJsonAsync(response, ct).ConfigureAwait(false);
    }
    internal static async Task<byte[]> ReadBytesAsync(HttpResponseMessage response, CancellationToken ct)
    {
        try
        {
            using var input = await response.Content.ReadAsStreamAsync().ConfigureAwait(false);
            using var output = new MemoryStream(); await input.CopyToAsync(output, 81920, ct).ConfigureAwait(false); return output.ToArray();
        }
        catch (OperationCanceledException) when (ct.IsCancellationRequested) { throw; }
        catch (VaifException) { throw; }
        catch { throw new VaifException("The response stream failed.", "STREAM_ERROR"); }
    }
    internal static async Task<JsonElement> ReadJsonAsync(HttpResponseMessage response, CancellationToken ct)
    {
        var bytes = await ReadBytesAsync(response, ct).ConfigureAwait(false);
        if (bytes.Length == 0) return VaifJson.Parse("null");
        try { using var doc = JsonDocument.Parse(bytes); return doc.RootElement.Clone(); }
        catch (JsonException) { throw new VaifException("The API returned invalid JSON.", "INVALID_RESPONSE", (int)response.StatusCode); }
    }
    private static async Task ThrowApiErrorAsync(HttpResponseMessage response, CancellationToken ct)
    {
        JsonElement data = default;
        try { data = await ReadJsonAsync(response, ct).ConfigureAwait(false); } catch (VaifException ex) when (ex.Code == "INVALID_RESPONSE") { }
        var message = VaifJson.String(data, "message") ?? VaifJson.String(data, "error") ?? $"VAIF request failed ({(int)response.StatusCode}).";
        var requestId = VaifJson.String(data, "requestId");
        if (requestId == null && response.Headers.TryGetValues("x-request-id", out var ids)) requestId = ids.FirstOrDefault();
        throw new VaifException(message, VaifJson.String(data, "code") ?? VaifJson.String(data, "error") ?? "HTTP_ERROR", (int)response.StatusCode, requestId, data.ValueKind == JsonValueKind.Object && data.TryGetProperty("details", out var d) ? d.Clone() : (JsonElement?)null);
    }
    internal async Task<HttpResponseMessage> AssetAsync(HttpRequestMessage request, CancellationToken ct)
    {
        ValidateUrl(request.RequestUri!);
        HttpResponseMessage response;
        try { response = await _assets.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, ct).ConfigureAwait(false); }
        catch (OperationCanceledException) when (ct.IsCancellationRequested) { throw; }
        catch (OperationCanceledException) { throw new VaifException("The request timed out.", "TIMEOUT"); }
        catch { throw new VaifException("The storage transport failed.", "STORAGE_TRANSFER_ERROR"); }
        RefuseRedirect(request, response);
        if (!response.IsSuccessStatusCode) { using (response) { throw new VaifException("Signed storage transfer failed.", "STORAGE_TRANSFER_ERROR", (int)response.StatusCode); } }
        await ResponseStream.ProtectAsync(response, ct).ConfigureAwait(false);
        return response;
    }
    private static void RefuseRedirect(HttpRequestMessage request, HttpResponseMessage response)
    {
        var actual = response.RequestMessage?.RequestUri;
        var expected = request.RequestUri!;
        if (((int)response.StatusCode >= 300 && (int)response.StatusCode < 400) ||
            (actual != null && (actual.Scheme != expected.Scheme || actual.Authority != expected.Authority)))
        {
            int status = (int)response.StatusCode; response.Dispose();
            throw new VaifException("HTTP redirects are refused.", "REDIRECT_REFUSED", status);
        }
    }
    private static void GuardStaffOnly(string method, string path)
    {
        var segments = path.TrimEnd('/').Split('/');
        foreach (var route in Operations.StaffOnlyRoutes)
        {
            int space = route.IndexOf(' ');
            if (route.Substring(0, space) != method) continue;
            var template = route.Substring(space + 1).TrimEnd('/').Split('/');
            if (template.Length != segments.Length) continue;
            bool matches = true;
            for (int i = 0; i < template.Length; i++)
                if (!(template[i].StartsWith("{", StringComparison.Ordinal) && template[i].EndsWith("}", StringComparison.Ordinal)) && template[i] != segments[i]) { matches = false; break; }
            if (matches) throw new VaifException("This operation requires platform staff access.", "STAFF_ONLY");
        }
    }
    /// <summary>Disposes the client HTTP resources while leaving injected handlers owned by the caller.</summary>
    public void Dispose() { _http.Dispose(); _assets.Dispose(); }
}
