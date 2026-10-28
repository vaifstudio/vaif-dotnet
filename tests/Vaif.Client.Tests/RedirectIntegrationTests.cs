using System.Net;
using System.Net.Sockets;
using System.Text;
using Xunit;

namespace Vaif.Client.Tests;

public sealed class RedirectIntegrationTests
{
    [Fact]
    public async Task Cross_origin_redirect_cannot_forward_credentials_or_replace_session()
    {
        using var cancel = new CancellationTokenSource(TimeSpan.FromSeconds(5));
        using var origin = new TcpListener(IPAddress.Loopback, 0);
        using var target = new TcpListener(IPAddress.Loopback, 0);
        origin.Start(); target.Start();
        int sourcePort = ((IPEndPoint)origin.LocalEndpoint).Port;
        int targetPort = ((IPEndPoint)target.LocalEndpoint).Port;
        int received = 0;
        var source = ServeAsync(origin, $"HTTP/1.1 307 Temporary Redirect\r\nLocation: http://localhost:{targetPort}/collect\r\nContent-Length: 0\r\nConnection: close\r\n\r\n", cancel.Token);
        var destination = Task.Run(async () =>
        {
            try
            {
                using var connection = await target.AcceptTcpClientAsync(cancel.Token);
                Interlocked.Increment(ref received);
                using var stream = connection.GetStream();
                await ReadHeadersAsync(stream, cancel.Token);
                const string body = "{\"accessToken\":\"attacker\",\"refreshToken\":\"attacker-r\"}";
                await stream.WriteAsync(Encoding.ASCII.GetBytes($"HTTP/1.1 200 OK\r\nContent-Type: application/json\r\nContent-Length: {body.Length}\r\nConnection: close\r\n\r\n{body}"), cancel.Token);
            }
            catch (OperationCanceledException) when (cancel.IsCancellationRequested) { }
        });
        try
        {
            using var handler = new SocketsHttpHandler { AllowAutoRedirect = true, UseCookies = true, UseProxy = false };
            using var client = new VaifClient(new VaifClientOptions { BaseUrl = new Uri($"http://127.0.0.1:{sourcePort}"), ProjectId = "p", ApiKey = "vk_pub_secret" }, handler);
            await client.Tokens.SetAsync(new TokenSession { AccessToken = "old", RefreshToken = "refresh-secret" });
            var error = await Assert.ThrowsAsync<VaifException>(() => client.Auth.RefreshAsync(cancel.Token));
            Assert.Equal("REDIRECT_REFUSED", error.Code); Assert.Equal(307, error.StatusCode);
            await source;
            Assert.Equal(0, received); Assert.False(target.Pending());
            var stored = await client.Tokens.GetAsync();
            Assert.Equal("old", stored!.AccessToken); Assert.Equal("refresh-secret", stored.RefreshToken);
        }
        finally { cancel.Cancel(); await destination; }
    }

    private static async Task ServeAsync(TcpListener listener, string response, CancellationToken ct)
    {
        using var connection = await listener.AcceptTcpClientAsync(ct);
        using var stream = connection.GetStream(); await ReadHeadersAsync(stream, ct);
        await stream.WriteAsync(Encoding.ASCII.GetBytes(response), ct);
    }
    private static async Task ReadHeadersAsync(NetworkStream stream, CancellationToken ct)
    {
        var bytes = new byte[1]; string tail = "";
        while (tail != "\r\n\r\n")
        {
            if (await stream.ReadAsync(bytes, ct) == 0) throw new IOException("HTTP headers ended early.");
            tail = (tail + (char)bytes[0]); if (tail.Length > 4) tail = tail.Substring(tail.Length - 4);
        }
    }
}
