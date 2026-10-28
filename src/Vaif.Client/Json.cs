using System.Globalization;
using System.Text.Json;

namespace Vaif.Client;

/// <summary>Reflection-free helpers for open-schema request data.</summary>
public static class VaifJson
{
    /// <summary>Parses JSON and returns an element independent of the temporary document lifetime.</summary>
    public static JsonElement Parse(string json) { using var doc = JsonDocument.Parse(json); return doc.RootElement.Clone(); }
    /// <summary>Creates a JSON object from named scalar or JsonElement values without reflection serialization.</summary>
    public static JsonElement Object(params (string Name, object? Value)[] values) => Write(writer =>
    {
        writer.WriteStartObject();
        foreach (var item in values) { writer.WritePropertyName(item.Name); WriteValue(writer, item.Value); }
        writer.WriteEndObject();
    });
    internal static JsonElement Write(Action<Utf8JsonWriter> write)
    {
        using var stream = new MemoryStream();
        using (var writer = new Utf8JsonWriter(stream)) { write(writer); writer.Flush(); }
        using var doc = JsonDocument.Parse(stream.ToArray()); return doc.RootElement.Clone();
    }
    private static void WriteValue(Utf8JsonWriter writer, object? value)
    {
        switch (value)
        {
            case null: writer.WriteNullValue(); break;
            case JsonElement element: element.WriteTo(writer); break;
            case string text: writer.WriteStringValue(text); break;
            case bool boolean: writer.WriteBooleanValue(boolean); break;
            case int number: writer.WriteNumberValue(number); break;
            case long number: writer.WriteNumberValue(number); break;
            case double number: writer.WriteNumberValue(number); break;
            case decimal number: writer.WriteNumberValue(number); break;
            case IEnumerable<string> strings:
                writer.WriteStartArray(); foreach (var item in strings) writer.WriteStringValue(item); writer.WriteEndArray(); break;
            default: throw new ArgumentException("Use JsonElement or a JSON scalar; arbitrary objects are not serialized through reflection.", nameof(value));
        }
    }
    internal static VaifException InvalidResponse() => new("The API returned an unexpected response.", "INVALID_RESPONSE");
    internal static JsonElement Required(JsonElement element, string key, JsonValueKind kind)
    {
        if (element.ValueKind != JsonValueKind.Object || !element.TryGetProperty(key, out var value) || value.ValueKind != kind) throw InvalidResponse();
        return value;
    }
    internal static string? String(JsonElement element, string key) => element.ValueKind == JsonValueKind.Object && element.TryGetProperty(key, out var v) && v.ValueKind == JsonValueKind.String ? v.GetString() : null;
    internal static string Scalar(JsonElement value) => value.ValueKind == JsonValueKind.String ? value.GetString()! : value.GetRawText();
    internal static string Number(long value) => value.ToString(CultureInfo.InvariantCulture);
    internal static string Query(IEnumerable<KeyValuePair<string, string?>> items)
    {
        var entries = items.Where(p => p.Value != null).Select(p => Uri.EscapeDataString(p.Key) + "=" + Uri.EscapeDataString(p.Value!));
        var query = string.Join("&", entries); return query.Length == 0 ? "" : "?" + query;
    }
}
