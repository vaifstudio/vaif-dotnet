using System.Text.Json;
namespace Vaif.Client;

/// <summary>Supplies path values, query values, headers, and a body for a generated operation.</summary>
public sealed class OperationRequest
{
    /// <summary>Gets or sets unescaped path parameter values. The SDK escapes values before substitution.</summary>
    public IDictionary<string, string>? Path { get; set; }
    /// <summary>Gets or sets query parameter values. The SDK encodes values before sending the request.</summary>
    public IDictionary<string, string>? Query { get; set; }
    /// <summary>Gets or sets the JSON body for operations that accept JSON.</summary>
    public JsonElement? Body { get; set; }
    /// <summary>Text/binary content; ownership transfers to the request.</summary>
    public HttpContent? Content { get; set; }
    /// <summary>Gets or sets additional request headers. Treat custom header values as trusted application input.</summary>
    public IDictionary<string, string>? Headers { get; set; }
}

/// <summary>Describes the route and request requirements of a generated API operation.</summary>
public sealed class OperationDescriptor
{
    /// <summary>Gets the generated operation name.</summary>
    public string Name { get; }
    /// <summary>Gets the HTTP method used by the operation.</summary>
    public string Method { get; }
    /// <summary>Gets the route template, including named path parameters in braces.</summary>
    public string Path { get; }
    /// <summary>Gets the response transport: json, binary, or sse.</summary>
    public string Transport { get; }
    /// <summary>Gets the request body kind, or null when the operation accepts no body.</summary>
    public string? BodyKind { get; }
    /// <summary>Gets whether the API contract requires a request body.</summary>
    public bool BodyRequired { get; }
    /// <summary>Gets the names of required query parameters.</summary>
    public IReadOnlyList<string> RequiredQuery { get; }
    internal OperationDescriptor(string name, string method, string path, string transport, string? bodyKind, bool bodyRequired, string[] requiredQuery)
    { Name = name; Method = method; Path = path; Transport = transport; BodyKind = bodyKind; BodyRequired = bodyRequired; RequiredQuery = Array.AsReadOnly(requiredQuery); }
}

/// <summary>Dispose every response. Json is populated for JSON; Response is open for SSE/binary.</summary>
public sealed class OperationResponse : IDisposable
{
    /// <summary>Gets the parsed JSON response, or null for binary and event-stream responses.</summary>
    public JsonElement? Json { get; }
    /// <summary>Gets the HTTP response. Dispose this wrapper after consuming the response or stream.</summary>
    public HttpResponseMessage Response { get; }
    internal OperationResponse(HttpResponseMessage response, JsonElement? json) { Response = response; Json = json; }
    /// <summary>Disposes the HTTP response and its content stream.</summary>
    public void Dispose() => Response.Dispose();
}

/// <summary>Calls API operations generated from the shared OpenAPI contract.</summary>
public sealed partial class Operations
{
    private readonly VaifClient _client;
    internal Operations(VaifClient client) { _client = client; }
    /// <summary>Validates and sends a described operation. Dispose the returned response, including JSON responses.</summary>
    public async Task<OperationResponse> CallAsync(OperationDescriptor operation, OperationRequest? request = null, CancellationToken cancellationToken = default)
    {
        request = request ?? new OperationRequest();
        var path = operation.Path;
        VaifClient.GuardConsoleOnly(operation.Method, path);
        foreach (System.Text.RegularExpressions.Match match in System.Text.RegularExpressions.Regex.Matches(path, "\\{([^}]+)\\}"))
        {
            var name = match.Groups[1].Value;
            if (request.Path == null || !request.Path.TryGetValue(name, out var value) || string.IsNullOrEmpty(value)) throw new ArgumentException("Missing path parameter: " + name);
            path = path.Replace("{" + name + "}", VaifClient.Segment(value));
        }
        foreach (var name in operation.RequiredQuery) if (request.Query == null || !request.Query.ContainsKey(name)) throw new ArgumentException("Missing query parameter: " + name);
        if (operation.BodyRequired && !request.Body.HasValue && request.Content == null) throw new ArgumentException("A request body is required.");
        if (operation.BodyKind == "json" && request.Content != null) throw new ArgumentException("JSON operations take Body, not Content.");
        if (operation.BodyKind != "json" && request.Body.HasValue) throw new ArgumentException("This operation does not accept a JSON body.");
        if (operation.BodyKind == null && request.Content != null) throw new ArgumentException("This operation does not accept content.");
        if (request.Query != null) path += VaifJson.Query(request.Query.Select(p => new KeyValuePair<string, string?>(p.Key, p.Value)));
        var response = await _client.SendAsync(operation.Method, path, request.Body, cancellationToken, headers: request.Headers, content: request.Content).ConfigureAwait(false);
        try { if (operation.Transport != "json") await ResponseStream.ProtectAsync(response, cancellationToken).ConfigureAwait(false);
            return new OperationResponse(response, operation.Transport == "json" ? await VaifClient.ReadJsonAsync(response, cancellationToken).ConfigureAwait(false) : (JsonElement?)null); }
        catch { response.Dispose(); throw; }
    }
}
