using System.Text.Json;
namespace Vaif.Client;

/// <summary>Invokes deployed functions and preserves their response status, content, and run metadata.</summary>
public sealed class FunctionsClient
{
    private readonly VaifClient _client;
    internal FunctionsClient(VaifClient client) { _client = client; }
    /// <summary>Returns status, data, and run metadata. A function's own HTTP errors are content.</summary>
    public async Task<JsonElement> InvokeAsync(string functionIdOrName, JsonElement? input = null, CancellationToken cancellationToken = default)
    {
        using var response = await _client.SendAsync("POST", "/functions/" + VaifClient.Segment(functionIdOrName) + "/invoke", input ?? VaifJson.Parse("{}"), cancellationToken).ConfigureAwait(false);
        var mediaType = response.Content.Headers.ContentType?.MediaType;
        JsonElement data;
        if (mediaType == null || mediaType.Equals("application/json", StringComparison.OrdinalIgnoreCase) || mediaType.EndsWith("+json", StringComparison.OrdinalIgnoreCase))
            data = await VaifClient.ReadJsonAsync(response, cancellationToken).ConfigureAwait(false);
        else
            data = VaifJson.Object(("value", System.Text.Encoding.UTF8.GetString(await VaifClient.ReadBytesAsync(response, cancellationToken).ConfigureAwait(false)))).GetProperty("value").Clone();
        return VaifJson.Object(("status", (int)response.StatusCode), ("data", data),
            ("requestId", response.Headers.TryGetValues("X-Vaif-Run-Id", out var ids) ? ids.FirstOrDefault() : null),
            ("durationMs", response.Headers.TryGetValues("X-Vaif-Run-Duration-Ms", out var durations) && long.TryParse(durations.FirstOrDefault(), System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.InvariantCulture, out var duration) ? (object)duration : null));
    }
}
