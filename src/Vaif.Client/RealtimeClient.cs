using System.Collections.Concurrent;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;

namespace Vaif.Client;

/// <summary>Optional WebSocket adapter for hosts with their own transport. The client owns it.</summary>
public interface IRealtimeTransport : IDisposable
{
    /// <summary>Connects to the supplied WebSocket endpoint using caller cancellation.</summary>
    Task ConnectAsync(Uri uri, CancellationToken cancellationToken);
    /// <summary>Sends the supplied UTF-8 data as a complete WebSocket text message.</summary>
    Task SendAsync(ArraySegment<byte> data, CancellationToken cancellationToken);
    /// <summary>Receives the next WebSocket frame into the supplied buffer.</summary>
    Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken);
    /// <summary>Sends a normal WebSocket close frame using caller cancellation.</summary>
    Task CloseOutputAsync(CancellationToken cancellationToken);
}

/// <summary>Adapts the platform ClientWebSocket to the realtime transport interface.</summary>
public sealed class ClientWebSocketTransport : IRealtimeTransport
{
    private readonly ClientWebSocket _socket = new();
    /// <summary>Connects to the supplied WebSocket endpoint using caller cancellation.</summary>
    public Task ConnectAsync(Uri uri, CancellationToken cancellationToken) => _socket.ConnectAsync(uri, cancellationToken);
    /// <summary>Sends the supplied UTF-8 data as a complete WebSocket text message.</summary>
    public Task SendAsync(ArraySegment<byte> data, CancellationToken cancellationToken) => _socket.SendAsync(data, WebSocketMessageType.Text, true, cancellationToken);
    /// <summary>Receives the next WebSocket frame into the supplied buffer.</summary>
    public Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken) => _socket.ReceiveAsync(buffer, cancellationToken);
    /// <summary>Sends a normal WebSocket close frame using caller cancellation.</summary>
    public Task CloseOutputAsync(CancellationToken cancellationToken) => _socket.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, "Client closed", cancellationToken);
    /// <summary>Disposes the WebSocket and its connection resources.</summary>
    public void Dispose() => _socket.Dispose();
}

/// <summary>One connection, one event consumer. Connect waits for welcome; subscribe waits for acknowledgment.
/// Reconnect explicitly by creating a new client after a close. Native WebSocket ping/pong is handled by ClientWebSocket.</summary>
public sealed class RealtimeClient : IDisposable, IAsyncDisposable
{
    private readonly VaifClient _client;
    private readonly IRealtimeTransport _socket;
    private readonly CancellationTokenSource _lifetime = new();
    private readonly SemaphoreSlim _send = new(1, 1);
    private readonly SemaphoreSlim _available = new(0);
    private readonly ConcurrentQueue<JsonElement> _events = new();
    private readonly ConcurrentDictionary<string, TaskCompletionSource<JsonElement>> _waiters = new();
    private Task? _pump;
    private Exception? _terminal;
    private int _started;
    private int _disposed;
    private volatile bool _ready;
    /// <summary>Creates a realtime connection that owns the supplied transport, or a default ClientWebSocket transport.</summary>
    public RealtimeClient(VaifClient client, IRealtimeTransport? transport = null)
    { _client = client ?? throw new ArgumentNullException(nameof(client)); _socket = transport ?? new ClientWebSocketTransport(); }
    /// <summary>Connects, sends current credentials, and waits for welcome. Create a new client to reconnect after closing.</summary>
    public async Task ConnectAsync(CancellationToken cancellationToken = default)
    {
        if (Interlocked.Exchange(ref _started, 1) != 0) throw new InvalidOperationException("Create a new realtime client to reconnect.");
        using var timeout = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, _lifetime.Token); timeout.CancelAfter(TimeSpan.FromSeconds(15));
        try
        {
            var uri = new UriBuilder(_client.BaseUrl) { Scheme = _client.BaseUrl.Scheme == "https" ? "wss" : "ws", Path = _client.BaseUrl.AbsolutePath.TrimEnd('/') + "/realtime/ws", Query = "", Fragment = "" };
            await _socket.ConnectAsync(uri.Uri, timeout.Token).ConfigureAwait(false);
            var token = await _client.Tokens.GetAsync(timeout.Token).ConfigureAwait(false);
            await SendAsync(VaifJson.Object(("type", "auth"), ("apiKey", _client.ApiKey), ("accessToken", token?.AccessToken)), timeout.Token).ConfigureAwait(false);
            // Presence messages may precede welcome on an authenticated connection.
            while (true)
            {
                var message = await ReadMessageAsync(timeout.Token).ConfigureAwait(false); ThrowIfError(message);
                if (VaifJson.String(message, "type") == "welcome") break;
            }
            _ready = true; _pump = PumpAsync();
        }
        catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested) { Dispose(); throw; }
        catch (Exception ex) { Dispose(); throw TransportError(ex); }
    }
    /// <summary>Subscribes to a channel and returns its server acknowledgment.</summary>
    public Task<JsonElement> SubscribeAsync(string channel, CancellationToken cancellationToken = default) => RequestAsync("subscribe", "subscribed:" + channel, VaifJson.Object(("type", "subscribe"), ("channel", channel)), cancellationToken);
    /// <summary>Subscribes to changes for a validated table identifier and returns the server acknowledgment.</summary>
    public Task<JsonElement> SubscribeTableAsync(string table, CancellationToken cancellationToken = default)
    {
        if (!System.Text.RegularExpressions.Regex.IsMatch(table, "^[A-Za-z_][A-Za-z0-9_]*$")) throw new ArgumentException("Expected a table identifier.", nameof(table));
        return SubscribeAsync("table:" + table, cancellationToken);
    }
    /// <summary>Unsubscribes from a channel and returns its server acknowledgment.</summary>
    public Task<JsonElement> UnsubscribeAsync(string channel, CancellationToken cancellationToken = default) => RequestAsync("unsubscribe", "unsubscribed:" + channel, VaifJson.Object(("type", "unsubscribe"), ("channel", channel)), cancellationToken);
    /// <summary>Sends the current stored credentials to the connection and waits for acknowledgment. Does not rotate tokens.</summary>
    public async Task<JsonElement> RefreshAuthAsync(CancellationToken cancellationToken = default)
    {
        var tokens = await _client.Tokens.GetAsync(cancellationToken).ConfigureAwait(false);
        return await RequestAsync("auth_refresh", "auth_refreshed:", VaifJson.Object(("type", "auth_refresh"), ("apiKey", _client.ApiKey), ("accessToken", tokens?.AccessToken)), cancellationToken).ConfigureAwait(false);
    }
    private async Task<JsonElement> RequestAsync(string type, string key, JsonElement body, CancellationToken ct)
    {
        if (!_ready) throw new InvalidOperationException("ConnectAsync must complete first.");
        if (_terminal != null) throw _terminal;
        var tcs = new TaskCompletionSource<JsonElement>(TaskCreationOptions.RunContinuationsAsynchronously);
        if (!_waiters.TryAdd(key, tcs)) throw new InvalidOperationException("An identical realtime request is in progress: " + type);
        using var timeout = CancellationTokenSource.CreateLinkedTokenSource(ct, _lifetime.Token); timeout.CancelAfter(TimeSpan.FromSeconds(15));
        using var registration = timeout.Token.Register(() => tcs.TrySetCanceled());
        try
        {
            if (_terminal != null) throw _terminal;
            await SendAsync(body, timeout.Token).ConfigureAwait(false); return await tcs.Task.ConfigureAwait(false);
        }
        catch (OperationCanceledException) when (!ct.IsCancellationRequested)
        {
            if (_lifetime.IsCancellationRequested) throw _terminal ?? ClosedError();
            throw new VaifException("Realtime acknowledgment timed out.", "REALTIME_TIMEOUT");
        }
        finally { _waiters.TryRemove(key, out _); }
    }
    /// <summary>Waits for the next queued event. Use one event consumer per connection.</summary>
    public async Task<JsonElement> ReceiveAsync(CancellationToken cancellationToken = default)
    {
        if (!_ready) throw new InvalidOperationException("ConnectAsync must complete first.");
        using var linked = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, _lifetime.Token);
        while (true)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (_events.TryDequeue(out var message)) { _available.Wait(0); return message; }
            if (_terminal != null) throw _terminal;
            try { await _available.WaitAsync(linked.Token).ConfigureAwait(false); }
            catch (OperationCanceledException) when (!cancellationToken.IsCancellationRequested) { throw _terminal ?? ClosedError(); }
        }
    }
    private async Task SendAsync(JsonElement message, CancellationToken ct)
    {
        await _send.WaitAsync(ct).ConfigureAwait(false);
        try { await _socket.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(message.GetRawText())), ct).ConfigureAwait(false); }
        catch (OperationCanceledException) when (ct.IsCancellationRequested) { throw; }
        catch (Exception ex) { throw TransportError(ex); }
        finally { _send.Release(); }
    }
    private async Task<JsonElement> ReadMessageAsync(CancellationToken ct)
    {
        var buffer = new byte[8192]; using var output = new MemoryStream(); WebSocketReceiveResult frame;
        do
        {
            frame = await _socket.ReceiveAsync(new ArraySegment<byte>(buffer), ct).ConfigureAwait(false);
            if (frame.MessageType == WebSocketMessageType.Close) throw new VaifException("Realtime closed: " + frame.CloseStatusDescription, "REALTIME_CLOSED", (int?)frame.CloseStatus);
            if (frame.MessageType != WebSocketMessageType.Text) throw new VaifException("Expected a realtime text frame.", "REALTIME_PROTOCOL_ERROR");
            if (output.Length + frame.Count > 1024 * 1024) throw new VaifException("Realtime frame exceeds 1 MiB.", "REALTIME_MESSAGE_TOO_LARGE");
            output.Write(buffer, 0, frame.Count);
        } while (!frame.EndOfMessage);
        using var doc = JsonDocument.Parse(output.ToArray()); return doc.RootElement.Clone();
    }
    private async Task PumpAsync()
    {
        try
        {
            while (!_lifetime.IsCancellationRequested)
            {
                var message = await ReadMessageAsync(_lifetime.Token).ConfigureAwait(false);
                var type = VaifJson.String(message, "type"); var channel = VaifJson.String(message, "channel") ?? "";
                if (type == "error")
                {
                    if (message.TryGetProperty("closeCode", out var closeCode) && closeCode.ValueKind != JsonValueKind.Null) ThrowIfError(message);
                    var error = MessageError(message);
                    bool matched = false;
                    if (channel.Length != 0)
                        foreach (var prefix in new[] { "subscribed:", "unsubscribed:" })
                            if (_waiters.TryGetValue(prefix + channel, out var pending)) { pending.TrySetException(error); matched = true; }
                    if (!matched) Enqueue(message);
                    continue;
                }
                if (_waiters.TryGetValue(type + ":" + channel, out var waiter)) waiter.TrySetResult(message);
                else
                {
                    Enqueue(message);
                }
            }
        }
        catch (Exception ex)
        {
            SetTerminal(TransportError(ex));
            _socket.Dispose();
        }
    }
    private void Enqueue(JsonElement message)
    {
        if (_events.Count >= 1024) throw new VaifException("Realtime consumer fell behind. Reconnect and reload data.", "REALTIME_BACKPRESSURE");
        _events.Enqueue(message); _available.Release();
    }
    private static VaifException ClosedError() => new("Realtime connection closed.", "REALTIME_CLOSED");
    private void SetTerminal(Exception error)
    {
        var terminal = Interlocked.CompareExchange(ref _terminal, error, null) ?? error;
        foreach (var waiter in _waiters.Values) waiter.TrySetException(terminal);
        _available.Release();
    }
    private static VaifException MessageError(JsonElement message) => new(VaifJson.String(message, "message") ?? "Realtime error.", VaifJson.String(message, "code") ?? VaifJson.String(message, "error") ?? "REALTIME_ERROR");
    private static VaifException TransportError(Exception ex) => ex as VaifException ?? new VaifException("Realtime transport or protocol failed. Reconnect and reload data.", "REALTIME_TRANSPORT_ERROR");
    private static void ThrowIfError(JsonElement message)
    {
        if (VaifJson.String(message, "type") == "error") throw MessageError(message);
    }
    /// <summary>Sends a close frame when connected, then disposes the transport and waits for the receive loop to finish.</summary>
    public async Task CloseAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            bool sendClose = _ready && _terminal == null && !_lifetime.IsCancellationRequested;
            SetTerminal(ClosedError());
            if (sendClose)
            {
                await _send.WaitAsync(cancellationToken).ConfigureAwait(false);
                try { await _socket.CloseOutputAsync(cancellationToken).ConfigureAwait(false); }
                catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested) { throw; }
                catch (Exception ex) { throw TransportError(ex); }
                finally { _send.Release(); }
            }
        }
        finally { Dispose(); if (_pump != null) await _pump.ConfigureAwait(false); }
    }
    /// <summary>Cancels pending work and disposes the owned transport without waiting for the close handshake.</summary>
    public void Dispose() { if (Interlocked.Exchange(ref _disposed, 1) != 0) return; SetTerminal(ClosedError()); _lifetime.Cancel(); _socket.Dispose(); }
    /// <summary>Closes and disposes the connection, waiting for its receive loop to finish.</summary>
    public async ValueTask DisposeAsync() => await CloseAsync().ConfigureAwait(false);
}
