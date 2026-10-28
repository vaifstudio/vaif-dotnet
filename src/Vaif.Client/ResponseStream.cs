namespace Vaif.Client;

// Wrap the stream itself: errors can occur after HTTP response headers succeeded.
internal sealed class ResponseStream : Stream
{
    private readonly Stream _inner;
    private readonly HttpContent _content;
    private ResponseStream(Stream inner, HttpContent content) { _inner = inner; _content = content; }
    internal static async Task ProtectAsync(HttpResponseMessage response, CancellationToken ct)
    {
        var content = response.Content;
        try
        {
            var stream = await content.ReadAsStreamAsync().ConfigureAwait(false);
            ct.ThrowIfCancellationRequested();
            var replacement = new StreamContent(new ResponseStream(stream, content));
            foreach (var header in content.Headers) replacement.Headers.TryAddWithoutValidation(header.Key, header.Value);
            response.Content = replacement;
        }
        catch (OperationCanceledException) when (ct.IsCancellationRequested) { throw; }
        catch { throw Error(); }
    }
    private static VaifException Error() => new("The response stream failed.", "STREAM_ERROR");
    public override int Read(byte[] buffer, int offset, int count)
    { try { return _inner.Read(buffer, offset, count); } catch { throw Error(); } }
    public override async Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
    {
        try { return await _inner.ReadAsync(buffer, offset, count, cancellationToken).ConfigureAwait(false); }
        catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested) { throw; }
        catch { throw Error(); }
    }
    public override async ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default)
    {
        try { return await _inner.ReadAsync(buffer, cancellationToken).ConfigureAwait(false); }
        catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested) { throw; }
        catch { throw Error(); }
    }
    public override bool CanRead => _inner.CanRead;
    public override bool CanSeek => false;
    public override bool CanWrite => false;
    public override long Length => throw new NotSupportedException();
    public override long Position { get => throw new NotSupportedException(); set => throw new NotSupportedException(); }
    public override long Seek(long offset, SeekOrigin origin) => throw new NotSupportedException();
    public override void SetLength(long value) => throw new NotSupportedException();
    public override void Write(byte[] buffer, int offset, int count) => throw new NotSupportedException();
    public override void Flush() { }
    protected override void Dispose(bool disposing) { if (disposing) { _inner.Dispose(); _content.Dispose(); } base.Dispose(disposing); }
}
