using System.Collections.Concurrent;
using System.Net;
using System.Net.WebSockets;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace Vaif.Client.Tests;

public static partial class SecurityCases
{
    public static Task Sockets_handlers_disable_redirects_and_cookies()
    {
        using var api = new SocketsHttpHandler { AllowAutoRedirect = true, UseCookies = true };
        using var assets = new SocketsHttpHandler { AllowAutoRedirect = true, UseCookies = true };
        using var client = new VaifClient(new VaifClientOptions(), api, assets);
        ContractAssert.False(api.AllowAutoRedirect); ContractAssert.False(api.UseCookies);
        ContractAssert.False(assets.AllowAutoRedirect); ContractAssert.False(assets.UseCookies);
        return Task.CompletedTask;
    }

    public static async Task Timeouts_are_per_request_and_assets_are_unbounded()
    {
        using var handler = new CancelableHandler(async (_, ct) => { await Task.Delay(Timeout.Infinite, ct); return await Json(); });
        using var client = new VaifClient(new VaifClientOptions { ProjectId = "p", RequestTimeout = TimeSpan.FromMilliseconds(50) }, handler);
        ContractAssert.Equal(Timeout.InfiniteTimeSpan, AssetClient(client).Timeout);
        ContractAssert.Equal("TIMEOUT", (await ContractAssert.ThrowsAsync<VaifException>(() => client.From("notes").ListAsync())).Code);
        using var canceled = new CancellationTokenSource(); canceled.Cancel();
        await ContractAssert.ThrowsAnyAsync<OperationCanceledException>(() => client.From("notes").ListAsync(canceled.Token));
        // A stalled upload obeys caller cancellation, with no hidden transfer deadline.
        using var transferCancel = new CancellationTokenSource();
        using var assetHandler = new CancelableHandler(async (_, ct) => { transferCancel.Cancel(); await Task.Delay(Timeout.Infinite, ct); return await Json(); });
        using var uploadClient = new VaifClient(new VaifClientOptions(), new AsyncHandler(_ => Json("{\"url\":\"https://files.test/o\"}")), assetHandler);
        ContractAssert.Equal(Timeout.InfiniteTimeSpan, AssetClient(uploadClient).Timeout);
        using var input = new MemoryStream(new byte[] { 1 });
        await ContractAssert.ThrowsAnyAsync<OperationCanceledException>(() => uploadClient.Storage.UploadAsync("o", input, 1, cancellationToken: transferCancel.Token));
    }

    private static HttpClient AssetClient(VaifClient client) =>
        (HttpClient)typeof(VaifClient).GetField("_assets", BindingFlags.Instance | BindingFlags.NonPublic)!.GetValue(client)!;

    public static async Task Authenticated_auth_routes_refresh_once()
    {
        int refreshes = 0; var bearers = new List<string?>();
        using var client = Make(new AsyncHandler(async request =>
        {
            if (request.RequestUri!.AbsolutePath == "/projects/p/auth/refresh") { refreshes++; return await Json(SessionJson); }
            ContractAssert.Equal("/projects/p/auth/me", request.RequestUri.AbsolutePath);
            bearers.Add(request.Headers.Authorization?.ToString());
            return bearers.Count == 1 ? await Json("{\"code\":\"TOKEN_EXPIRED\"}", HttpStatusCode.Unauthorized) : await Json("{\"user\":{\"id\":\"user-1\"}}");
        }));
        await client.Tokens.SetAsync(new TokenSession { AccessToken = "old", RefreshToken = "old-refresh" });
        ContractAssert.Equal("user-1", (await client.Auth.GetUserAsync()).GetProperty("id").GetString());
        ContractAssert.Equal(1, refreshes); ContractAssert.Equal(2, bearers.Count);
        ContractAssert.Equal("Bearer old", bearers[0]); ContractAssert.Equal("Bearer new", bearers[1]);
    }

    public static async Task Dot_path_values_never_reach_transport()
    {
        int calls = 0;
        using var handler = new AsyncHandler(_ => { calls++; return Json(); });
        foreach (var value in new[] { ".", ".." })
        {
            using var client = Make(handler);
            await ContractAssert.ThrowsAsync<ArgumentException>(() => client.Operations.DeleteFunctionsByFunctionIdScheduleAsync(new OperationRequest { Path = new Dictionary<string, string> { ["functionId"] = value } }));
            await ContractAssert.ThrowsAsync<ArgumentException>(() => client.From("notes").DeleteAsync(value));
            await ContractAssert.ThrowsAsync<ArgumentException>(() => client.Functions.InvokeAsync(value));
            await ContractAssert.ThrowsAsync<ArgumentException>(() => client.From(value).ListAsync());
            await ContractAssert.ThrowsAsync<ArgumentException>(() => client.Auth.StartOAuthAsync(value, "myapp://callback"));
            await ContractAssert.ThrowsAsync<ArgumentException>(() => client.Storage.ListAsync(value));
            using var project = new VaifClient(new VaifClientOptions { ProjectId = value }, handler);
            await ContractAssert.ThrowsAsync<ArgumentException>(() => project.Auth.SignUpAsync("a", "b"));
        }
        ContractAssert.Equal(0, calls);
    }

    public static async Task Signed_url_query_never_appears_in_errors()
    {
        foreach (int scenario in new[] { 0, 1, 2 })
        {
            string url = scenario == 2 ? "http://files.test/o?sig=sig-literal" : "https://files.test/o?X-Amz-Signature=sig-literal";
            using var api = new AsyncHandler(_ => Json(VaifJson.Object(("url", url)).GetRawText()));
            using var asset = new AsyncHandler(_ => scenario == 1 ? throw new HttpRequestException("failed https://files.test/o?X-Amz-Signature=sig-literal") : Json("", HttpStatusCode.Forbidden));
            using var client = new VaifClient(new VaifClientOptions(), api, asset);
            var error = await ContractAssert.ThrowsAsync<VaifException>(() => client.Storage.DownloadAsync("o"));
            ContractAssert.Equal(scenario == 2 ? "INVALID_URL" : "STORAGE_TRANSFER_ERROR", error.Code);
            ContractAssert.DoesNotContain("sig-literal", error.ToString()); ContractAssert.DoesNotContain("Signature", error.ToString());
        }
    }

    public static async Task Missing_vault_entry_allows_first_signin()
    {
        var vault = new MissingEntryVault();
        using var client = new VaifClient(new VaifClientOptions { ProjectId = "p", TokenVault = vault }, new AsyncHandler(_ => Json(SessionJson)));
        await client.Auth.SignInAsync("a", "b");
        ContractAssert.Equal(1, vault.MissingDeletes);
        ContractAssert.Equal("new", (await client.Tokens.GetAsync())!.AccessToken);
    }

    public static async Task Canceled_session_save_preserves_caller_cancellation()
    {
        using var cancel = new CancellationTokenSource(); var store = new CancelingStore(cancel);
        using var client = Make(new AsyncHandler(_ => Json(SessionJson)), store);
        await ContractAssert.ThrowsAnyAsync<OperationCanceledException>(() => client.Auth.SignInAsync("a", "b", cancellationToken: cancel.Token));
        ContractAssert.Null(store.Session); ContractAssert.Equal(2, store.Clears);
        ContractAssert.Null(await client.Tokens.GetAsync());
    }

    public static async Task Unexpected_response_shapes_use_sdk_errors()
    {
        foreach (var body in new[] { "{}", "[]", "{\"user\":null,\"url\":12,\"buckets\":{},\"data\":{}}", "{\"user\":12,\"url\":null,\"buckets\":[{\"name\":\"default\",\"id\":null}],\"data\":[{\"value\":\"bad\"}]}" })
        {
            using var client = Make(new AsyncHandler(_ => Json(body)));
            foreach (var call in new Func<Task>[] { () => client.Auth.GetUserAsync(), () => client.Auth.StartOAuthAsync("google", "myapp://callback"), () => client.Storage.ListAsync(), () => client.From("notes").CountAsync() })
                ContractAssert.Equal("INVALID_RESPONSE", (await ContractAssert.ThrowsAsync<VaifException>(call)).Code);
        }
    }

    public static async Task Rejected_subscribe_keeps_connection_usable()
    {
        using var client = Make(new AsyncHandler(_ => Json()));
        using var socket = new QueueSocket(); using var realtime = new RealtimeClient(client, socket);
        await realtime.ConnectAsync();
        ContractAssert.Equal("InvalidChannel", (await ContractAssert.ThrowsAsync<VaifException>(() => realtime.SubscribeAsync("table:missing"))).Code);
        var ack = await realtime.SubscribeAsync("table:other");
        ContractAssert.Equal("{\"type\":\"subscribed\",\"channel\":\"table:other\"}", ack.GetRawText());
        ContractAssert.Equal("{\"type\":\"change\",\"channel\":\"table:other\",\"id\":\"event-1\"}", (await realtime.ReceiveAsync()).GetRawText());
    }

    public static async Task Realtime_drains_events_before_remote_close()
    {
        using var client = Make(new AsyncHandler(_ => Json()));
        using var socket = new QueueSocket(); using var realtime = new RealtimeClient(client, socket);
        await realtime.ConnectAsync(); await realtime.SubscribeAsync("table:other");
        socket.Enqueue(null); await socket.Closed.Task.WaitAsync(TimeSpan.FromSeconds(3));
        ContractAssert.Equal("event-1", (await realtime.ReceiveAsync()).GetProperty("id").GetString());
        ContractAssert.Equal("REALTIME_CLOSED", (await ContractAssert.ThrowsAsync<VaifException>(() => realtime.ReceiveAsync())).Code);
    }

    public static async Task Local_realtime_close_has_stable_error()
    {
        foreach (bool dispose in new[] { false, true })
        {
            using var client = Make(new AsyncHandler(_ => Json()));
            using var socket = new QueueSocket(); using var realtime = new RealtimeClient(client, socket);
            await realtime.ConnectAsync(); var receive = realtime.ReceiveAsync(); var subscribe = realtime.SubscribeAsync("table:pending");
            if (dispose) realtime.Dispose(); else await realtime.CloseAsync();
            ContractAssert.Equal("REALTIME_CLOSED", (await ContractAssert.ThrowsAsync<VaifException>(() => receive)).Code);
            ContractAssert.Equal("REALTIME_CLOSED", (await ContractAssert.ThrowsAsync<VaifException>(() => subscribe)).Code);
            ContractAssert.Equal("REALTIME_CLOSED", (await ContractAssert.ThrowsAsync<VaifException>(() => realtime.SubscribeAsync("table:other"))).Code);
        }
    }

    public static async Task Public_arguments_follow_dotnet_conventions()
    {
        // CreateSignedUrlAsync takes (key, bucket, expiresIn) in the same order as GetDownloadUrlAsync.
        string? sent = null;
        using var client = Make(new AsyncHandler(async request =>
        {
            sent = await request.Content!.ReadAsStringAsync();
            return await Json("{\"url\":\"https://files.test/o\"}");
        }));
        ContractAssert.Equal("https://files.test/o", await client.Storage.CreateSignedUrlAsync("o", "avatars", 60));
        ContractAssert.Equal("{\"key\":\"o\",\"bucket\":\"avatars\",\"expiresIn\":60}", sent);
        ContractAssert.Equal("client", (await ContractAssert.ThrowsAsync<ArgumentNullException>(() => Task.FromResult(new RealtimeClient(null!)))).ParamName);
    }

    private sealed class CancelableHandler : HttpMessageHandler
    {
        private readonly Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> _send;
        internal CancelableHandler(Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> send) => _send = send;
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) => _send(request, cancellationToken);
    }
    private sealed class MissingEntryVault : ITokenVault
    {
        private string? _value; internal int MissingDeletes;
        public Task<string?> ReadAsync(string key, CancellationToken cancellationToken = default) => Task.FromResult(_value);
        public Task WriteAsync(string key, string value, CancellationToken cancellationToken = default) { _value = value; return Task.CompletedTask; }
        public Task DeleteAsync(string key, CancellationToken cancellationToken = default) { if (_value == null) MissingDeletes++; _value = null; return Task.CompletedTask; }
    }
    private sealed class CancelingStore : ITokenStorage
    {
        private readonly CancellationTokenSource _cancel; internal TokenSession? Session; internal int Clears;
        internal CancelingStore(CancellationTokenSource cancel) => _cancel = cancel;
        public Task<TokenSession?> GetAsync(CancellationToken cancellationToken = default) => Task.FromResult(Session);
        public Task SetAsync(TokenSession session, CancellationToken cancellationToken = default) { Session = session; _cancel.Cancel(); cancellationToken.ThrowIfCancellationRequested(); return Task.CompletedTask; }
        public Task ClearAsync(CancellationToken cancellationToken = default) { Session = null; Clears++; return Task.CompletedTask; }
    }
    private sealed class QueueSocket : IRealtimeTransport
    {
        private readonly ConcurrentQueue<string?> _messages = new(); private readonly SemaphoreSlim _ready = new(0);
        internal TaskCompletionSource<bool> Closed = Signal();
        internal QueueSocket() => Enqueue("{\"type\":\"welcome\"}");
        internal void Enqueue(string? message) { _messages.Enqueue(message); _ready.Release(); }
        public Task ConnectAsync(Uri uri, CancellationToken cancellationToken) => Task.CompletedTask;
        public Task SendAsync(ArraySegment<byte> data, CancellationToken cancellationToken)
        {
            var message = VaifJson.Parse(Encoding.UTF8.GetString(data.Array!, data.Offset, data.Count));
            if (message.GetProperty("type").GetString() == "subscribe")
            {
                var channel = message.GetProperty("channel").GetString();
                if (channel == "table:missing") Enqueue("{\"type\":\"error\",\"error\":\"InvalidChannel\",\"channel\":\"table:missing\"}");
                else if (channel == "table:other") { Enqueue("{\"type\":\"subscribed\",\"channel\":\"table:other\"}"); Enqueue("{\"type\":\"change\",\"channel\":\"table:other\",\"id\":\"event-1\"}"); }
            }
            return Task.CompletedTask;
        }
        public async Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken)
        {
            await _ready.WaitAsync(cancellationToken); _messages.TryDequeue(out var message);
            if (message == null) return new WebSocketReceiveResult(0, WebSocketMessageType.Close, true, WebSocketCloseStatus.NormalClosure, "server closed");
            var bytes = Encoding.UTF8.GetBytes(message); Array.Copy(bytes, 0, buffer.Array!, buffer.Offset, bytes.Length);
            return new WebSocketReceiveResult(bytes.Length, WebSocketMessageType.Text, true);
        }
        public Task CloseOutputAsync(CancellationToken cancellationToken) => Task.CompletedTask;
        public void Dispose() => Closed.TrySetResult(true);
    }
}
