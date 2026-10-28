using System.Net.Http.Headers;
using System.Text.Json;

namespace Vaif.Client;

/// <summary>Manages files and signed URLs using separate asset requests without API credentials.</summary>
public sealed class StorageClient
{
    private readonly VaifClient _client;
    private readonly string _defaultBucket;
    internal StorageClient(VaifClient client, string defaultBucket) { _client = client; _defaultBucket = defaultBucket; }
    private static void ValidateSize(long sizeBytes)
    { if (sizeBytes < 1 || sizeBytes > 5L * 1024 * 1024 * 1024) throw new ArgumentOutOfRangeException(nameof(sizeBytes), "Upload size must be 1 byte to 5 GiB."); }
    /// <summary>Requests and validates a signed upload URL for a declared size of 1 byte through 5 GiB.</summary>
    public async Task<JsonElement> GetUploadUrlAsync(string key, long sizeBytes, string contentType = "application/octet-stream", string? bucket = null, CancellationToken cancellationToken = default)
    {
        ValidateSize(sizeBytes);
        return ValidateSigned(await _client.JsonAsync("POST", "/storage/upload-url", VaifJson.Object(("key", key), ("bucket", bucket ?? _defaultBucket), ("sizeBytes", sizeBytes), ("contentType", contentType)), cancellationToken).ConfigureAwait(false));
    }
    /// <summary>Requests and validates a signed download URL with the requested lifetime in seconds.</summary>
    public async Task<JsonElement> GetDownloadUrlAsync(string key, string? bucket = null, int expiresIn = 3600, CancellationToken cancellationToken = default) =>
        ValidateSigned(await _client.JsonAsync("POST", "/storage/download-url", VaifJson.Object(("key", key), ("bucket", bucket ?? _defaultBucket), ("expiresIn", expiresIn)), cancellationToken).ConfigureAwait(false));
    private static JsonElement ValidateSigned(JsonElement result)
    {
        if (!Uri.TryCreate(VaifJson.String(result, "url"), UriKind.Absolute, out var uri)) throw new VaifException("The API returned an invalid storage URL.", "INVALID_URL");
        VaifClient.ValidateUrl(uri); return result;
    }
    /// <summary>Returns a validated signed download URL with the requested lifetime in seconds.</summary>
    public async Task<string> CreateSignedUrlAsync(string key, string? bucket = null, int expiresIn = 3600, CancellationToken cancellationToken = default) =>
        (await GetDownloadUrlAsync(key, bucket, expiresIn, cancellationToken).ConfigureAwait(false)).GetProperty("url").GetString()!;
    /// <summary>Caller owns the input stream. Seekable streams must have exactly sizeBytes remaining.</summary>
    public async Task UploadAsync(string key, Stream data, long sizeBytes, string contentType = "application/octet-stream", string? bucket = null, CancellationToken cancellationToken = default)
    {
        ValidateSize(sizeBytes); if (data == null) throw new ArgumentNullException(nameof(data));
        if (!data.CanRead) throw new ArgumentException("A readable stream is required.", nameof(data));
        if (data.CanSeek && data.Length - data.Position != sizeBytes) throw new ArgumentException("sizeBytes must equal the stream's remaining bytes.", nameof(sizeBytes));
        var signed = await GetUploadUrlAsync(key, sizeBytes, contentType, bucket, cancellationToken).ConfigureAwait(false);
        using var request = new HttpRequestMessage(HttpMethod.Put, signed.GetProperty("url").GetString());
        request.Content = new SizedStreamContent(data, sizeBytes, cancellationToken); request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse(contentType);
        request.Content.Headers.ContentLength = sizeBytes;
        using var response = await _client.AssetAsync(request, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>Downloads a file into memory without forwarding API credentials to the asset host.</summary>
    public async Task<byte[]> DownloadAsync(string key, string? bucket = null, CancellationToken cancellationToken = default)
    {
        using var response = await OpenDownloadAsync(key, bucket, cancellationToken).ConfigureAwait(false);
        return await VaifClient.ReadBytesAsync(response, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>Caller disposes the response; stream large downloads instead of buffering.</summary>
    public async Task<HttpResponseMessage> OpenDownloadAsync(string key, string? bucket = null, CancellationToken cancellationToken = default)
    {
        var signed = await GetDownloadUrlAsync(key, bucket, cancellationToken: cancellationToken).ConfigureAwait(false);
        using var request = new HttpRequestMessage(HttpMethod.Get, signed.GetProperty("url").GetString());
        return await _client.AssetAsync(request, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>Lists files with an optional prefix and continuation cursor. Resolves bucket names to IDs.</summary>
    public async Task<JsonElement> ListAsync(string? bucket = null, string? prefix = null, int limit = 100, string? cursor = null, CancellationToken cancellationToken = default)
    {
        if (limit < 1 || limit > 1000) throw new ArgumentOutOfRangeException(nameof(limit));
        var id = await ResolveBucketAsync(bucket ?? _defaultBucket, cancellationToken).ConfigureAwait(false);
        return await _client.JsonAsync("GET", "/buckets/" + VaifClient.Segment(id) + "/files" + VaifJson.Query(new Dictionary<string, string?> { ["prefix"] = prefix, ["maxKeys"] = VaifJson.Number(limit), ["continuationToken"] = cursor }), null, cancellationToken).ConfigureAwait(false);
    }
    /// <summary>Deletes a file by key after resolving its bucket name or ID.</summary>
    public async Task DeleteAsync(string key, string? bucket = null, CancellationToken cancellationToken = default)
    {
        var id = await ResolveBucketAsync(bucket ?? _defaultBucket, cancellationToken).ConfigureAwait(false);
        await _client.JsonAsync("DELETE", "/buckets/" + VaifClient.Segment(id) + "/files" + VaifJson.Query(new Dictionary<string, string?> { ["key"] = key }), null, cancellationToken).ConfigureAwait(false);
    }
    private async Task<string> ResolveBucketAsync(string bucket, CancellationToken ct)
    {
        VaifClient.Segment(bucket);
        if (Guid.TryParse(bucket, out _)) return bucket;
        var result = await _client.JsonAsync("GET", "/storage/buckets" + VaifJson.Query(new Dictionary<string, string?> { ["projectId"] = _client.ProjectId ?? throw new VaifException("Bucket names need ProjectId; alternatively pass a bucket UUID.", "PROJECT_ID_REQUIRED") }), null, ct).ConfigureAwait(false);
        foreach (var item in VaifJson.Required(result, "buckets", JsonValueKind.Array).EnumerateArray())
        {
            var id = VaifJson.Required(item, "id", JsonValueKind.String).GetString();
            if (string.IsNullOrEmpty(id)) throw VaifJson.InvalidResponse();
            if (VaifJson.String(item, "name") == bucket || id == bucket) return id!;
        }
        throw new VaifException("Bucket not found: " + bucket, "NOT_FOUND", 404);
    }
    // Does not own the caller's stream, and bounds non-seekable uploads to their declared size.
    private sealed class SizedStreamContent : HttpContent
    {
        private readonly Stream _input; private readonly long _length; private readonly CancellationToken _cancellationToken;
        internal SizedStreamContent(Stream input, long length, CancellationToken cancellationToken) { _input = input; _length = length; _cancellationToken = cancellationToken; }
        protected override bool TryComputeLength(out long length) { length = _length; return true; }
        protected override Task SerializeToStreamAsync(Stream stream, System.Net.TransportContext? context) => CopyAsync(stream, _cancellationToken);
#if NET8_0_OR_GREATER
        protected override Task SerializeToStreamAsync(Stream stream, System.Net.TransportContext? context, CancellationToken cancellationToken) => CopyAsync(stream, cancellationToken);
#endif
        private async Task CopyAsync(Stream destination, CancellationToken ct)
        {
            var buffer = new byte[81920]; long left = _length;
            while (left > 0)
            {
                int read = await _input.ReadAsync(buffer, 0, (int)Math.Min(buffer.Length, left), ct).ConfigureAwait(false);
                if (read == 0) throw new IOException("Upload stream ended before sizeBytes.");
                await destination.WriteAsync(buffer, 0, read, ct).ConfigureAwait(false); left -= read;
            }
        }
    }
}
