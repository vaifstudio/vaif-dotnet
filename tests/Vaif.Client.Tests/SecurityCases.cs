using System.Net;
using System.Net.WebSockets;
using System.Text;

namespace Vaif.Client.Tests;

// These cases also run in the package-free conformance host when NuGet is offline.
public static partial class SecurityCases
{
    public static IReadOnlyDictionary<string, Func<Task>> All { get; } = new Dictionary<string, Func<Task>>
    {
        [nameof(Sockets_handlers_disable_redirects_and_cookies)] = Sockets_handlers_disable_redirects_and_cookies,
        [nameof(Timeouts_are_per_request_and_assets_are_unbounded)] = Timeouts_are_per_request_and_assets_are_unbounded,
        [nameof(Authenticated_auth_routes_refresh_once)] = Authenticated_auth_routes_refresh_once,
        [nameof(Dot_path_values_never_reach_transport)] = Dot_path_values_never_reach_transport,
        [nameof(Signed_url_query_never_appears_in_errors)] = Signed_url_query_never_appears_in_errors,
        [nameof(Missing_vault_entry_allows_first_signin)] = Missing_vault_entry_allows_first_signin,
        [nameof(Canceled_session_save_preserves_caller_cancellation)] = Canceled_session_save_preserves_caller_cancellation,
        [nameof(Unexpected_response_shapes_use_sdk_errors)] = Unexpected_response_shapes_use_sdk_errors,
        [nameof(Rejected_subscribe_keeps_connection_usable)] = Rejected_subscribe_keeps_connection_usable,
        [nameof(Realtime_drains_events_before_remote_close)] = Realtime_drains_events_before_remote_close,
        [nameof(Local_realtime_close_has_stable_error)] = Local_realtime_close_has_stable_error,
        [nameof(Public_arguments_follow_dotnet_conventions)] = Public_arguments_follow_dotnet_conventions,
        [nameof(Persistent_sessions_are_scoped_by_origin_and_project)] = Persistent_sessions_are_scoped_by_origin_and_project,
        [nameof(Signout_in_progress_blocks_refresh_completion)] = Signout_in_progress_blocks_refresh_completion,
        [nameof(Event_stream_read_errors_use_sdk_type)] = Event_stream_read_errors_use_sdk_type,
        [nameof(Redirects_never_forward_api_credentials)] = Redirects_never_forward_api_credentials,
        [nameof(Function_text_response_is_returned_as_content)] = Function_text_response_is_returned_as_content,
        [nameof(Realtime_urls_fail_closed)] = Realtime_urls_fail_closed,
        [nameof(Signout_uses_refresh_and_reports_storage_failure)] = Signout_uses_refresh_and_reports_storage_failure,
        [nameof(Refresh_cannot_restore_signed_out_session)] = Refresh_cannot_restore_signed_out_session,
        [nameof(Refresh_cannot_overwrite_replacement_session)] = Refresh_cannot_overwrite_replacement_session,
        [nameof(Failed_save_invalidates_older_storage)] = Failed_save_invalidates_older_storage,
        [nameof(Signed_urls_are_validated_before_return)] = Signed_urls_are_validated_before_return,
        [nameof(Function_401_is_content_and_auth_401_is_refreshed_once)] = Function_401_is_content_and_auth_401_is_refreshed_once,
        [nameof(Realtime_failures_use_sdk_errors)] = Realtime_failures_use_sdk_errors,
        [nameof(Retry_uses_only_the_rotated_session)] = Retry_uses_only_the_rotated_session,
        [nameof(Retry_rejects_another_users_session)] = Retry_rejects_another_users_session,
        [nameof(Retry_rejects_a_signed_out_session)] = Retry_rejects_a_signed_out_session,
        [nameof(Retry_rejects_a_refresh_challenge_without_a_bearer)] = Retry_rejects_a_refresh_challenge_without_a_bearer,
    };
    private const string SessionJson = "{\"accessToken\":\"new\",\"refreshToken\":\"new-refresh\"}";
    private static VaifClient Make(AsyncHandler handler, ITokenStorage? store = null, string url = "https://api.test") =>
        new(new VaifClientOptions { BaseUrl = new Uri(url), ProjectId = "p", ApiKey = "key", TokenStorage = store }, handler);
    private static TaskCompletionSource<bool> Signal() => new(TaskCreationOptions.RunContinuationsAsynchronously);
    private static Task<HttpResponseMessage> Json(string body = "{}", HttpStatusCode status = HttpStatusCode.OK) =>
        Task.FromResult(new HttpResponseMessage(status) { Content = new StringContent(body, Encoding.UTF8, "application/json") });

    public static async Task Realtime_urls_fail_closed()
    {
        foreach (var pair in new[] { ("HTTPS://api.test", "wss"), ("http://localhost:3010", "ws"), ("http://127.0.0.1", "ws"), ("http://[::1]", "ws") })
        {
            using var c = Make(new AsyncHandler(_ => Json()), url: pair.Item1);
            using var socket = new TestSocket(); using var rt = new RealtimeClient(c, socket);
            await rt.ConnectAsync(); ContractAssert.Equal(pair.Item2, socket.Uri!.Scheme);
        }
        foreach (var url in new[] { "http://example.com", "http://127.0.0.2", "http://localtest.localhost", "ftp://localhost", "https://user:pass@api.test" })
        {
            await ContractAssert.ThrowsAsync<VaifException>(() => { using var c = Make(new AsyncHandler(_ => Json()), url: url); return Task.CompletedTask; });
        }
    }
    public static async Task Signout_uses_refresh_and_reports_storage_failure()
    {
        var store = new FailingStore { Session = new TokenSession { AccessToken = "expired", RefreshToken = "refresh", ExpiresAt = DateTimeOffset.UtcNow.AddHours(-1) }, FailClear = true };
        var revoked = false;
        using var c = Make(new AsyncHandler(async r =>
        {
            ContractAssert.EndsWith("/auth/logout", r.RequestUri!.AbsolutePath);
            ContractAssert.Equal("refresh", VaifJson.Parse(await r.Content!.ReadAsStringAsync()).GetProperty("refreshToken").GetString());
            ContractAssert.False(r.Headers.Contains("Authorization")); revoked = true; return await Json();
        }), store);
        ContractAssert.Equal("SESSION_STORAGE_ERROR", (await ContractAssert.ThrowsAsync<VaifException>(() => c.Auth.SignOutAsync())).Code);
        ContractAssert.True(revoked);
        await ContractAssert.ThrowsAsync<VaifException>(() => c.Tokens.GetAsync());
    }
    public static async Task Refresh_cannot_restore_signed_out_session() => await RefreshRace(false);
    public static async Task Refresh_cannot_overwrite_replacement_session() => await RefreshRace(true);
    private static async Task RefreshRace(bool replacement)
    {
        var entered = Signal(); var release = Signal();
        using var c = Make(new AsyncHandler(async r =>
        {
            if (r.RequestUri!.AbsolutePath.EndsWith("/refresh"))
            {
                entered.SetResult(true); await release.Task;
                return await Json("{\"accessToken\":\"refreshed\",\"refreshToken\":\"refreshed-r\"}");
            }
            return await Json("{\"accessToken\":\"replacement\",\"refreshToken\":\"replacement-r\"}");
        }));
        await c.Tokens.SetAsync(new TokenSession { AccessToken = "old", RefreshToken = "old-refresh" });
        var refresh = c.Auth.RefreshAsync(); await entered.Task.WaitAsync(TimeSpan.FromSeconds(3));
        if (replacement) await c.Auth.SignInAsync("other", "password"); else await c.Auth.SignOutAsync();
        release.SetResult(true);
        ContractAssert.Equal("SESSION_CHANGED", (await ContractAssert.ThrowsAsync<VaifException>(() => refresh)).Code);
        var stored = await c.Tokens.GetAsync();
        if (replacement)
        {
            ContractAssert.Equal("replacement", stored!.AccessToken);
            ContractAssert.Equal("replacement-r", stored.RefreshToken);
        }
        else ContractAssert.Null(stored);
    }
    public static async Task Failed_save_invalidates_older_storage()
    {
        var store = new FailingStore { Session = new TokenSession { AccessToken = "older", RefreshToken = "older-refresh" }, FailSet = true };
        using var c = Make(new AsyncHandler(_ => Json(SessionJson)), store);
        ContractAssert.Equal("SESSION_STORAGE_ERROR", (await ContractAssert.ThrowsAsync<VaifException>(() => c.Auth.SignInAsync("a", "b"))).Code);
        ContractAssert.Null(store.Session);
        ContractAssert.Null(await c.Tokens.GetAsync());
    }
    public static async Task Retry_uses_only_the_rotated_session()
    {
        var bearers = new List<string?>(); int refreshes = 0;
        using var client = Make(new AsyncHandler(async request =>
        {
            if (request.RequestUri!.AbsolutePath.EndsWith("/refresh"))
            {
                refreshes++;
                ContractAssert.Equal("old-refresh", VaifJson.Parse(await request.Content!.ReadAsStringAsync()).GetProperty("refreshToken").GetString());
                return await Json(SessionJson);
            }
            bearers.Add(request.Headers.Authorization?.ToString());
            return bearers.Count == 1 ? await Json("{\"code\":\"TOKEN_EXPIRED\"}", HttpStatusCode.Unauthorized) : await Json();
        }));
        await client.Tokens.SetAsync(new TokenSession { AccessToken = "old", RefreshToken = "old-refresh" });
        await client.From("notes").ListAsync();
        ContractAssert.Equal(1, refreshes);
        ContractAssert.Equal(2, bearers.Count);
        ContractAssert.Equal("Bearer old", bearers[0]);
        ContractAssert.Equal("Bearer new", bearers[1]);
    }
    public static Task Retry_rejects_another_users_session() => RetrySessionChange(replace: true);
    public static Task Retry_rejects_a_signed_out_session() => RetrySessionChange(replace: false);
    private static async Task RetrySessionChange(bool replace)
    {
        // Change the session after reading the 401, or after saving the refresh
        // response but before taking the retry snapshot. No timing sleeps are needed.
        foreach (bool afterRefresh in new[] { false, true })
        {
            VaifClient? client = null; int calls = 0, refreshes = 0;
            void ChangeSession()
            {
                if (replace) client!.Tokens.SetAsync(new TokenSession { AccessToken = "other-user", RefreshToken = "other-refresh" }).GetAwaiter().GetResult();
                else client!.Auth.SignOutAsync().GetAwaiter().GetResult();
            }
            using var handler = new AsyncHandler(async request =>
            {
                var path = request.RequestUri!.AbsolutePath;
                if (path.EndsWith("/logout")) return await Json();
                if (path.EndsWith("/refresh"))
                {
                    refreshes++;
                    return new HttpResponseMessage(HttpStatusCode.OK) { Content = afterRefresh ? new OnDisposeContent(SessionJson, ChangeSession) : new StringContent(SessionJson) };
                }
                calls++;
                ContractAssert.Equal("Bearer old", request.Headers.Authorization?.ToString());
                return new HttpResponseMessage(HttpStatusCode.Unauthorized)
                {
                    Content = afterRefresh ? new StringContent("{\"code\":\"TOKEN_EXPIRED\"}") : new OnDisposeContent("{\"code\":\"TOKEN_EXPIRED\"}", ChangeSession)
                };
            });
            using (client = Make(handler))
            {
                await client.Tokens.SetAsync(new TokenSession { AccessToken = "old", RefreshToken = "old-refresh" });
                ContractAssert.Equal("SESSION_CHANGED", (await ContractAssert.ThrowsAsync<VaifException>(() => client.From("notes").ListAsync())).Code);
                ContractAssert.Equal(1, calls);
                ContractAssert.Equal(afterRefresh ? 1 : 0, refreshes);
                var stored = await client.Tokens.GetAsync();
                if (replace) ContractAssert.Equal("other-user", stored!.AccessToken); else ContractAssert.Null(stored);
            }
        }
    }
    public static async Task Retry_rejects_a_refresh_challenge_without_a_bearer()
    {
        VaifClient? client = null; int calls = 0;
        using var handler = new AsyncHandler(async request =>
        {
            if (request.RequestUri!.AbsolutePath.EndsWith("/refresh"))
                return new HttpResponseMessage(HttpStatusCode.OK) { Content = new OnDisposeContent("{\"mfaRequired\":true,\"challengeToken\":\"challenge\"}", () => client!.Tokens.ClearAsync().GetAwaiter().GetResult()) };
            calls++;
            return calls == 1 ? await Json("{\"code\":\"TOKEN_EXPIRED\"}", HttpStatusCode.Unauthorized) : await Json();
        });
        using (client = Make(handler))
        {
            await client.Tokens.SetAsync(new TokenSession { AccessToken = "old", RefreshToken = "old-refresh" });
            ContractAssert.Equal("SESSION_CHANGED", (await ContractAssert.ThrowsAsync<VaifException>(() => client.From("notes").ListAsync())).Code);
            ContractAssert.Equal(1, calls);
            ContractAssert.Null(await client.Tokens.GetAsync());
        }
    }
    private sealed class OnDisposeContent : StringContent
    {
        private Action? _action;
        internal OnDisposeContent(string json, Action action) : base(json, Encoding.UTF8, "application/json") => _action = action;
        protected override void Dispose(bool disposing)
        {
            var action = _action; _action = null;
            base.Dispose(disposing);
            if (disposing) action?.Invoke();
        }
    }
    public static async Task Signed_urls_are_validated_before_return()
    {
        foreach (var url in new[] { "http://files.test/a", "ftp://localhost/a", "http://127.0.0.2/a", "https://user:pass@files.test/a", "//files.test/a", "relative" })
        {
            using var c = Make(new AsyncHandler(_ => Json(VaifJson.Object(("url", url)).GetRawText())));
            await ContractAssert.ThrowsAsync<VaifException>(() => c.Storage.GetUploadUrlAsync("a", 1));
            await ContractAssert.ThrowsAsync<VaifException>(() => c.Storage.CreateSignedUrlAsync("a"));
        }
    }
    public static async Task Function_401_is_content_and_auth_401_is_refreshed_once()
    {
        int calls = 0, refreshes = 0; bool own = true;
        using var c = Make(new AsyncHandler(async r =>
        {
            if (r.RequestUri!.AbsolutePath.EndsWith("/refresh")) { refreshes++; return await Json(SessionJson); }
            calls++;
            if (own || calls == 2)
            {
                var response = await Json("{\"code\":\"TOKEN_INVALID\",\"message\":\"function body\"}", HttpStatusCode.Unauthorized);
                if (own) response.Headers.Add("X-Vaif-Run-Id", "run-1");
                return response;
            }
            return await Json("{\"ok\":true}");
        }));
        await c.Tokens.SetAsync(new TokenSession { AccessToken = "old", RefreshToken = "r" });
        var result = await c.Functions.InvokeAsync("hello");
        ContractAssert.Equal(401, result.GetProperty("status").GetInt32());
        ContractAssert.Equal("TOKEN_INVALID", result.GetProperty("data").GetProperty("code").GetString());
        ContractAssert.Equal(0, refreshes); ContractAssert.Equal(1, calls);
        own = false;
        await c.Functions.InvokeAsync("hello"); ContractAssert.Equal(1, refreshes); ContractAssert.Equal(3, calls);
    }
    public static async Task Realtime_failures_use_sdk_errors()
    {
        using var c = Make(new AsyncHandler(_ => Json()));
        using (var rt = new RealtimeClient(c, new TestSocket { FailConnect = true }))
            ContractAssert.Equal("REALTIME_TRANSPORT_ERROR", (await ContractAssert.ThrowsAsync<VaifException>(() => rt.ConnectAsync())).Code);
        using (var rt = new RealtimeClient(c, new TestSocket { FailReceive = true }))
        {
            await rt.ConnectAsync();
            ContractAssert.Equal("REALTIME_TRANSPORT_ERROR", (await ContractAssert.ThrowsAsync<VaifException>(() => rt.ReceiveAsync())).Code);
        }
    }
    public static async Task Function_text_response_is_returned_as_content()
    {
        using var client = Make(new AsyncHandler(_ =>
        {
            var response = new HttpResponseMessage(HttpStatusCode.Unauthorized) { Content = new StringContent("Please sign in", Encoding.UTF8, "text/plain") };
            response.Headers.Add("X-Vaif-Run-Id", "text-run");
            return Task.FromResult(response);
        }));
        var result = await client.Functions.InvokeAsync("text");
        ContractAssert.Equal(401, result.GetProperty("status").GetInt32());
        ContractAssert.Equal("Please sign in", result.GetProperty("data").GetString());
    }
    public static async Task Redirects_never_forward_api_credentials()
    {
        using var standard = new HttpClientHandler { AllowAutoRedirect = true, UseCookies = true };
        using (var c = new VaifClient(new VaifClientOptions(), standard))
        {
            ContractAssert.False(standard.AllowAutoRedirect);
            ContractAssert.False(standard.UseCookies);
        }
        var calls = 0;
        using var client = Make(new AsyncHandler(r =>
        {
            calls++; ContractAssert.Equal("api.test", r.RequestUri!.Host);
            ContractAssert.Equal("Bearer secret", r.Headers.Authorization!.ToString());
            ContractAssert.Equal("key", r.Headers.GetValues("x-vaif-key").Single());
            var response = new HttpResponseMessage(HttpStatusCode.TemporaryRedirect) { Content = new StringContent("{}") };
            response.Headers.Location = new Uri("https://untrusted.test/collect");
            return Task.FromResult(response);
        }));
        await client.Tokens.SetAsync(new TokenSession { AccessToken = "secret", RefreshToken = "refresh" });
        var error = await ContractAssert.ThrowsAsync<VaifException>(() => client.From("notes").ListAsync());
        ContractAssert.Equal("REDIRECT_REFUSED", error.Code);
        ContractAssert.Equal(307, error.StatusCode);
        ContractAssert.Equal(1, calls);
    }
    public static async Task Persistent_sessions_are_scoped_by_origin_and_project()
    {
        var vault = new TestVault();
        VaifClient Client(string url, string project) => new(new VaifClientOptions { BaseUrl = new Uri(url), ProjectId = project, TokenVault = vault }, new AsyncHandler(_ => Json()));
        using var first = Client("HTTPS://api.test", "p");
        using var equivalent = Client("https://API.test:443/path", "p");
        using var otherHost = Client("https://other.test", "p");
        using var otherPort = Client("https://api.test:8443", "p");
        using var otherProject = Client("https://api.test", "other");
        await first.Tokens.SetAsync(new TokenSession { AccessToken = "a", RefreshToken = "r" });
        ContractAssert.Equal("a", (await equivalent.Tokens.GetAsync())!.AccessToken);
        ContractAssert.Null(await otherHost.Tokens.GetAsync());
        ContractAssert.Null(await otherPort.Tokens.GetAsync());
        ContractAssert.Null(await otherProject.Tokens.GetAsync());
    }
    public static async Task Signout_in_progress_blocks_refresh_completion()
    {
        var entered = Signal(); var release = Signal();
        using var c = Make(new AsyncHandler(async r =>
        {
            if (r.RequestUri!.AbsolutePath.EndsWith("/logout")) { entered.SetResult(true); await release.Task; }
            return await Json(SessionJson);
        }));
        await c.Tokens.SetAsync(new TokenSession { AccessToken = "old", RefreshToken = "r" });
        var logout = c.Auth.SignOutAsync(); await entered.Task.WaitAsync(TimeSpan.FromSeconds(3));
        Exception? error = null;
        try { await c.Auth.RefreshAsync(); } catch (Exception ex) { error = ex; }
        release.SetResult(true); await logout;
        ContractAssert.True(error is VaifException);
        ContractAssert.Null(await c.Tokens.GetAsync());
    }
    public static async Task Event_stream_read_errors_use_sdk_type()
    {
        using var c = Make(new AsyncHandler(_ => Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK) { Content = new StreamContent(new BrokenStream()) })));
        var operation = Operations.All.First(o => o.Transport == "sse");
        var path = System.Text.RegularExpressions.Regex.Matches(operation.Path, "\\{([^}]+)\\}").Cast<System.Text.RegularExpressions.Match>().ToDictionary(m => m.Groups[1].Value, _ => "p");
        using var response = await c.Operations.CallAsync(operation, new OperationRequest { Path = path, Query = operation.RequiredQuery.ToDictionary(k => k, _ => "x"), Body = operation.BodyKind == "json" ? VaifJson.Parse("{}") : null });
        using var stream = await response.Response.Content.ReadAsStreamAsync();
        ContractAssert.Equal("STREAM_ERROR", (await ContractAssert.ThrowsAsync<VaifException>(() => stream.ReadAsync(new byte[8], 0, 8))).Code);
    }
    internal sealed class BrokenStream : MemoryStream
    {
        public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken ct) => throw new IOException("stream disconnected");
    }
    internal sealed class TestVault : ITokenVault
    {
        private readonly Dictionary<string, string> _values = new();
        public Task<string?> ReadAsync(string key, CancellationToken cancellationToken = default) => Task.FromResult(_values.TryGetValue(key, out var value) ? value : null);
        public Task WriteAsync(string key, string value, CancellationToken cancellationToken = default) { _values[key] = value; return Task.CompletedTask; }
        public Task DeleteAsync(string key, CancellationToken cancellationToken = default) { _values.Remove(key); return Task.CompletedTask; }
    }
    internal sealed class AsyncHandler : HttpMessageHandler
    {
        private readonly Func<HttpRequestMessage, Task<HttpResponseMessage>> _send;
        internal AsyncHandler(Func<HttpRequestMessage, Task<HttpResponseMessage>> send) => _send = send;
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) => _send(request);
    }
    internal sealed class FailingStore : ITokenStorage
    {
        internal TokenSession? Session;
        internal bool FailSet, FailClear;
        public Task<TokenSession?> GetAsync(CancellationToken cancellationToken = default) => Task.FromResult(Session);
        public Task SetAsync(TokenSession session, CancellationToken cancellationToken = default) { if (FailSet) throw new IOException("save failed"); Session = session; return Task.CompletedTask; }
        public Task ClearAsync(CancellationToken cancellationToken = default) { if (FailClear) throw new IOException("clear failed"); Session = null; return Task.CompletedTask; }
    }
    internal sealed class TestSocket : IRealtimeTransport
    {
        internal Uri? Uri;
        internal bool FailConnect, FailReceive;
        private int _receives;
        public Task ConnectAsync(Uri uri, CancellationToken cancellationToken) { Uri = uri; if (FailConnect) throw new WebSocketException("offline"); return Task.CompletedTask; }
        public Task SendAsync(ArraySegment<byte> data, CancellationToken cancellationToken) => Task.CompletedTask;
        public async Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken)
        {
            if (Interlocked.Increment(ref _receives) == 1)
            {
                var bytes = Encoding.UTF8.GetBytes("{\"type\":\"welcome\"}"); Array.Copy(bytes, 0, buffer.Array!, buffer.Offset, bytes.Length);
                return new WebSocketReceiveResult(bytes.Length, WebSocketMessageType.Text, true);
            }
            if (FailReceive) throw new WebSocketException("disconnected");
            await Task.Delay(Timeout.Infinite, cancellationToken); throw new OperationCanceledException(cancellationToken);
        }
        public Task CloseOutputAsync(CancellationToken cancellationToken) => Task.CompletedTask;
        public void Dispose() { }
    }
}
