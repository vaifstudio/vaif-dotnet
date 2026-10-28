using System.Text.Json;

namespace Vaif.Client;

/// <summary>Immutable query; list supports rich filters, bulk writes/count require equality.</summary>
public sealed class TableQuery
{
    private readonly VaifClient _client;
    private readonly string _path;
    private readonly List<(string Field, string Operator, JsonElement Value)> _filters = new();
    private readonly List<(string Field, bool Ascending)> _order = new();
    private string[] _select = Array.Empty<string>();
    private int? _limit, _offset;
    internal TableQuery(VaifClient client, string table)
    {
        if (string.IsNullOrWhiteSpace(table)) throw new ArgumentException("Table is required.", nameof(table));
        _client = client; _path = "/v1/data/" + client.RequireProject() + "/" + VaifClient.Segment(table);
    }
    private TableQuery(TableQuery original)
    {
        _client = original._client; _path = original._path; _filters.AddRange(original._filters); _order.AddRange(original._order);
        _select = original._select; _limit = original._limit; _offset = original._offset;
    }
    /// <summary>Returns a new query selecting the supplied columns.</summary>
    public TableQuery Select(params string[] columns) { var q = new TableQuery(this); q._select = (string[])columns.Clone(); return q; }
    /// <summary>Returns a new query with a comparison filter. Supports eq, neq, gt, gte, lt, lte, in, like, and ilike.</summary>
    public TableQuery Filter(string field, string @operator, JsonElement value)
    {
        if (!new[] { "eq", "neq", "gt", "gte", "lt", "lte", "in", "like", "ilike" }.Contains(@operator)) throw new ArgumentException("Unsupported filter operator.", nameof(@operator));
        var q = new TableQuery(this); q._filters.Add((field, @operator, value.Clone())); return q;
    }
    /// <summary>Returns a new query with an equality filter for the supplied field and value.</summary>
    public TableQuery Eq(string field, string value) => Filter(field, "eq", VaifJson.Object(("value", value)).GetProperty("value"));
    /// <summary>Returns a new query with an equality filter for the supplied field and value.</summary>
    public TableQuery Eq(string field, JsonElement value) => Filter(field, "eq", value);
    /// <summary>Returns a new query with an additional sort field and direction.</summary>
    public TableQuery Order(string field, bool ascending = true) { var q = new TableQuery(this); q._order.Add((field, ascending)); return q; }
    /// <summary>Returns a new query with a nonnegative maximum row count.</summary>
    public TableQuery Limit(int limit) { if (limit < 0) throw new ArgumentOutOfRangeException(nameof(limit)); var q = new TableQuery(this); q._limit = limit; return q; }
    /// <summary>Returns a new query with an inclusive, zero-based row range.</summary>
    public TableQuery Range(int from, int to)
    { if (from < 0 || to < from) throw new ArgumentOutOfRangeException(nameof(from)); var q = Limit(checked(to - from + 1)); q._offset = from; return q; }
    private string Query()
    {
        var p = new Dictionary<string, string?>();
        if (_select.Length > 0) p["select"] = string.Join(",", _select);
        if (_limit.HasValue) p["limit"] = VaifJson.Number(_limit.Value);
        if (_offset.HasValue) p["offset"] = VaifJson.Number(_offset.Value);
        if (_order.Count > 0) { p["orderBy"] = string.Join(",", _order.Select(o => o.Field)); p["orderDir"] = string.Join(",", _order.Select(o => o.Ascending ? "asc" : "desc")); }
        if (_filters.Count > 0) p["where"] = VaifJson.Write(w => { w.WriteStartArray(); foreach (var f in _filters) VaifJson.Object(("field", f.Field), ("operator", f.Operator), ("value", f.Value)).WriteTo(w); w.WriteEndArray(); }).GetRawText();
        return VaifJson.Query(p);
    }
    /// <summary>Returns the API response for rows matching this query, including selection, order, and range.</summary>
    public Task<JsonElement> ListAsync(CancellationToken cancellationToken = default) => _client.JsonAsync("GET", _path + Query(), null, cancellationToken);
    /// <summary>Returns the API response for a row ID with this query applied.</summary>
    public Task<JsonElement> GetAsync(string id, CancellationToken cancellationToken = default) => _client.JsonAsync("GET", _path + "/" + VaifClient.Segment(id) + Query(), null, cancellationToken);
    /// <summary>Inserts one JSON object and returns the API response.</summary>
    public Task<JsonElement> InsertAsync(JsonElement data, CancellationToken cancellationToken = default) => _client.JsonAsync("POST", _path, RequireObject(data), cancellationToken);
    /// <summary>Inserts a JSON array of rows through the bulk endpoint and returns the API response.</summary>
    public Task<JsonElement> InsertManyAsync(JsonElement rows, CancellationToken cancellationToken = default)
    { if (rows.ValueKind != JsonValueKind.Array) throw new ArgumentException("Expected a JSON array."); return _client.JsonAsync("POST", _path + "/bulk", rows, cancellationToken); }
    /// <summary>Updates one row by ID with the supplied JSON object and returns the API response.</summary>
    public Task<JsonElement> UpdateAsync(string id, JsonElement data, CancellationToken cancellationToken = default) => _client.JsonAsync("PATCH", _path + "/" + VaifClient.Segment(id), RequireObject(data), cancellationToken);
    /// <summary>Deletes one row by ID and returns the API response.</summary>
    public Task<JsonElement> DeleteAsync(string id, CancellationToken cancellationToken = default) => _client.JsonAsync("DELETE", _path + "/" + VaifClient.Segment(id), null, cancellationToken);
    /// <summary>Inserts or updates one JSON object using the supplied conflict columns and returns the API response.</summary>
    public Task<JsonElement> UpsertAsync(JsonElement data, params string[] conflictColumns) => UpsertAsync(data, conflictColumns, default);
    /// <summary>Inserts or updates one JSON object using the supplied conflict columns and returns the API response.</summary>
    public Task<JsonElement> UpsertAsync(JsonElement data, string[] conflictColumns, CancellationToken cancellationToken)
    {
        RequireObject(data); if (conflictColumns.Length == 0) throw new ArgumentException("Specify conflict columns.", nameof(conflictColumns));
        var body = VaifJson.Write(w => { w.WriteStartObject(); foreach (var p in data.EnumerateObject()) if (p.Name != "_upsert" && p.Name != "_conflict_columns") p.WriteTo(w); w.WriteBoolean("_upsert", true); w.WritePropertyName("_conflict_columns"); w.WriteStartArray(); foreach (var column in conflictColumns) w.WriteStringValue(column); w.WriteEndArray(); w.WriteEndObject(); });
        return _client.JsonAsync("POST", _path, body, cancellationToken);
    }
    private Dictionary<string, string?> EqualityFilters()
    {
        var values = new Dictionary<string, string?>();
        foreach (var f in _filters)
        {
            if (f.Operator != "eq" || f.Value.ValueKind == JsonValueKind.Null || f.Value.ValueKind == JsonValueKind.Array || f.Value.ValueKind == JsonValueKind.Object)
                throw new ArgumentException("Bulk writes and count only support non-null scalar equality filters.");
            if (values.ContainsKey(f.Field)) throw new ArgumentException("Duplicate equality filters cannot be flattened safely.");
            values[f.Field] = VaifJson.Scalar(f.Value);
        }
        return values;
    }
    /// <summary>Updates rows matching this query with a JSON object. Only non-null scalar equality filters are supported.</summary>
    public Task<JsonElement> UpdateManyAsync(JsonElement data, CancellationToken cancellationToken = default)
    {
        RequireObject(data); var filters = EqualityFilters();
        return _client.JsonAsync("PATCH", _path + "/bulk", VaifJson.Object(("data", data), ("filter", VaifJson.Write(w => { w.WriteStartObject(); foreach (var f in filters) w.WriteString(f.Key, f.Value); w.WriteEndObject(); }))), cancellationToken);
    }
    /// <summary>Deletes rows matching this query. Only non-null scalar equality filters are supported.</summary>
    public Task<JsonElement> DeleteManyAsync(CancellationToken cancellationToken = default) => _client.JsonAsync("DELETE", _path + "/bulk" + VaifJson.Query(EqualityFilters().ToDictionary(p => "filter[" + p.Key + "]", p => p.Value)), null, cancellationToken);
    /// <summary>Counts matching rows through the aggregate endpoint. Only non-null scalar equality filters are supported.</summary>
    public async Task<long> CountAsync(CancellationToken cancellationToken = default)
    {
        var p = EqualityFilters().ToDictionary(f => "filter[" + f.Key + "]", f => f.Value); p["fn"] = "count";
        var result = await _client.JsonAsync("GET", _path + "/aggregate" + VaifJson.Query(p), null, cancellationToken).ConfigureAwait(false);
        var rows = VaifJson.Required(result, "data", JsonValueKind.Array);
        if (rows.GetArrayLength() == 0) return 0;
        var value = VaifJson.Required(rows[0], "value", JsonValueKind.Number);
        if (!value.TryGetInt64(out var count)) throw VaifJson.InvalidResponse();
        return count;
    }
    private static JsonElement RequireObject(JsonElement data) => data.ValueKind == JsonValueKind.Object ? data : throw new ArgumentException("Expected a JSON object.");
}
