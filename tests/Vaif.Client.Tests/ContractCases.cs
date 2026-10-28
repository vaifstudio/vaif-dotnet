using System.Net;
using System.Text;
using System.Text.Json;

namespace Vaif.Client.Tests;

public sealed class RecordingHandler : HttpMessageHandler
{
    public List<(string Method, string Url, string Body, Dictionary<string, string> Headers)> Calls { get; } = new();
    public Func<HttpRequestMessage, string> Reply { get; set; } = _ => "{}";
    public HttpStatusCode Status { get; set; } = HttpStatusCode.OK;
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken ct)
    {
        ct.ThrowIfCancellationRequested();
        Calls.Add((request.Method.Method, request.RequestUri!.AbsoluteUri, request.Content is null ? "" : await request.Content.ReadAsStringAsync(ct), request.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value))));
        return new HttpResponseMessage(Status) { Content = new StringContent(Reply(request), Encoding.UTF8, "application/json") };
    }
}

public sealed class ContractCases
{
    public static IReadOnlyList<string> Names { get; } = new[] { "Console_only_signup_and_reset_never_send_requests", "Project_login_persists_tokens_and_refresh_rotates_in_body_mode", "Mfa_challenge_preserves_existing_session_until_verified", "Query_encodes_filters_order_range_and_does_not_mutate_parent", "Writes_use_real_upsert_bulk_and_aggregate_contracts", "Upload_requires_exact_size_and_asset_transfers_never_carry_credentials", "Storage_names_resolve_to_bucket_ids_for_list_and_delete", "Function_invoke_and_errors_preserve_server_details", "Cancellation_prevents_transport_and_signout_keeps_tokens_on_failure", "OAuth_uses_S256_and_rejects_unknown_or_replayed_state", "Generated_operations_validate_path_body_and_escape_values" };
    public static Task RunAsync(string name)
    {
        var cases = new ContractCases();
        return name switch
        {
            "Console_only_signup_and_reset_never_send_requests" => cases.Console_only_signup_and_reset_never_send_requests(),
            "Project_login_persists_tokens_and_refresh_rotates_in_body_mode" => cases.Project_login_persists_tokens_and_refresh_rotates_in_body_mode(),
            "Mfa_challenge_preserves_existing_session_until_verified" => cases.Mfa_challenge_preserves_existing_session_until_verified(),
            "Query_encodes_filters_order_range_and_does_not_mutate_parent" => cases.Query_encodes_filters_order_range_and_does_not_mutate_parent(),
            "Writes_use_real_upsert_bulk_and_aggregate_contracts" => cases.Writes_use_real_upsert_bulk_and_aggregate_contracts(),
            "Upload_requires_exact_size_and_asset_transfers_never_carry_credentials" => cases.Upload_requires_exact_size_and_asset_transfers_never_carry_credentials(),
            "Storage_names_resolve_to_bucket_ids_for_list_and_delete" => cases.Storage_names_resolve_to_bucket_ids_for_list_and_delete(),
            "Function_invoke_and_errors_preserve_server_details" => cases.Function_invoke_and_errors_preserve_server_details(),
            "Cancellation_prevents_transport_and_signout_keeps_tokens_on_failure" => cases.Cancellation_prevents_transport_and_signout_keeps_tokens_on_failure(),
            "OAuth_uses_S256_and_rejects_unknown_or_replayed_state" => cases.OAuth_uses_S256_and_rejects_unknown_or_replayed_state(),
            "Generated_operations_validate_path_body_and_escape_values" => cases.Generated_operations_validate_path_body_and_escape_values(),
            _ => throw new ArgumentException("Unknown contract case.")
        };
    }
    private static JsonElement J(string json) => JsonDocument.Parse(json).RootElement.Clone();
    private static VaifClient Client(RecordingHandler h, string? project = "p /1", HttpMessageHandler? assets = null) => new(new VaifClientOptions { BaseUrl = new Uri("https://api.test"), ApiKey = "vk_pub_test", ProjectId = project }, h, assets);

    public async Task Console_only_signup_and_reset_never_send_requests()
    {
        var h = new RecordingHandler(); using var c = Client(h, null);
        ContractAssert.Equal("CONSOLE_ONLY", (await ContractAssert.ThrowsAsync<VaifConsoleOnlyException>(() => c.Auth.SignUpAsync("a", "b"))).Code);
        ContractAssert.Equal("CONSOLE_ONLY", (await ContractAssert.ThrowsAsync<VaifConsoleOnlyException>(() => c.Auth.RequestPasswordResetAsync("a"))).Code);
        ContractAssert.Equal("CONSOLE_ONLY", (await ContractAssert.ThrowsAsync<VaifConsoleOnlyException>(() => c.Auth.ConfirmPasswordResetAsync("a", "b"))).Code);
        ContractAssert.Equal("CONSOLE_ONLY", (await ContractAssert.ThrowsAsync<VaifConsoleOnlyException>(() => c.Operations.PostAuthSignupAsync(new OperationRequest { Body = J("{}") }))).Code);
        ContractAssert.Empty(h.Calls);
    }

    public async Task Project_login_persists_tokens_and_refresh_rotates_in_body_mode()
    {
        var h = new RecordingHandler { Reply = _ => "{\"accessToken\":\"access\",\"refreshToken\":\"refresh\",\"expiresIn\":900,\"user\":{\"id\":\"u\"}}" };
        using var c = Client(h); var result = await c.Auth.SignInAsync("a", "b");
        ContractAssert.Equal("access", result.AccessToken);
        await c.Auth.RefreshAsync(); await c.Auth.GetUserAsync();
        ContractAssert.EndsWith("/projects/p%20%2F1/auth/login", h.Calls[0].Url);
        ContractAssert.Equal("body", h.Calls[0].Headers["X-Vaif-Refresh-Mode"]);
        ContractAssert.Equal("refresh", J(h.Calls[1].Body).GetProperty("refreshToken").GetString());
        ContractAssert.Equal("Bearer access", h.Calls[2].Headers["Authorization"]);
        await c.Auth.SignOutAsync(); ContractAssert.Null(await c.Tokens.GetAsync());
    }

    public async Task Mfa_challenge_preserves_existing_session_until_verified()
    {
        var h = new RecordingHandler { Reply = _ => "{\"mfaRequired\":true,\"challengeToken\":\"challenge\"}" }; using var c = Client(h);
        await c.Tokens.SetAsync(new TokenSession { AccessToken = "old", RefreshToken = "old-refresh" });
        ContractAssert.True((await c.Auth.SignInAsync("a", "b")).MfaRequired);
        ContractAssert.Equal("old", (await c.Tokens.GetAsync())!.AccessToken);
        h.Reply = _ => "{\"accessToken\":\"new\",\"refreshToken\":\"new-refresh\"}";
        await c.Auth.Mfa.VerifyAsync("challenge", "123456");
        ContractAssert.False(h.Calls.Last().Headers.ContainsKey("Authorization"));
        ContractAssert.Equal("new", (await c.Tokens.GetAsync())!.AccessToken);
    }

    public async Task Query_encodes_filters_order_range_and_does_not_mutate_parent()
    {
        var h = new RecordingHandler { Reply = _ => "{\"data\":[],\"count\":0}" }; using var c = Client(h);
        var table = c.From("notes");
        await table.Select("id", "body").Eq("owner_id", "u").Filter("body", "ilike", J("\"a%\"")).Order("body").Order("id", false).Range(2, 4).ListAsync();
        var url = Uri.UnescapeDataString(h.Calls[0].Url);
        ContractAssert.Contains("/v1/data/p /1/notes?", url); ContractAssert.Contains("orderBy=body,id", url); ContractAssert.Contains("orderDir=asc,desc", url);
        ContractAssert.Contains("limit=3", url); ContractAssert.Contains("offset=2", url); ContractAssert.Contains("\"operator\":\"ilike\"", url);
        await table.ListAsync(); ContractAssert.DoesNotContain("limit=", h.Calls[1].Url);
    }

    public async Task Writes_use_real_upsert_bulk_and_aggregate_contracts()
    {
        var h = new RecordingHandler { Reply = _ => "{\"data\":[{\"value\":7}]}" }; using var c = Client(h); var t = c.From("notes");
        await t.InsertAsync(J("{\"body\":\"a\"}"));
        await t.UpsertAsync(J("{\"body\":\"b\"}"), "body");
        ContractAssert.True(J(h.Calls[1].Body).GetProperty("_upsert").GetBoolean());
        await t.UpdateAsync("id /1", J("{\"body\":\"c\"}")); ContractAssert.EndsWith("/notes/id%20%2F1", h.Calls[2].Url);
        await t.Eq("body", "c").UpdateManyAsync(J("{\"body\":\"d\"}")); ContractAssert.Equal("c", J(h.Calls[3].Body).GetProperty("filter").GetProperty("body").GetString());
        ContractAssert.Equal(7, await t.Eq("body", "c").CountAsync());
        await t.Eq("body", "c").DeleteManyAsync(); ContractAssert.Contains("filter%5Bbody%5D=c", h.Calls[5].Url); ContractAssert.Equal("", h.Calls[5].Body);
        await t.DeleteAsync("id"); ContractAssert.Equal("DELETE", h.Calls.Last().Method);
        var before = h.Calls.Count;
        await ContractAssert.ThrowsAsync<ArgumentException>(() => t.Filter("n", "gt", J("2")).DeleteManyAsync());
        await ContractAssert.ThrowsAsync<ArgumentException>(() => t.Filter("n", "gt", J("2")).CountAsync()); ContractAssert.Equal(before, h.Calls.Count);
    }

    public async Task Upload_requires_exact_size_and_asset_transfers_never_carry_credentials()
    {
        var api = new RecordingHandler { Reply = _ => "{\"url\":\"https://files.test/signed\"}" };
        var asset = new RecordingHandler { Reply = _ => "hello" }; using var c = Client(api, assets: asset);
        await c.Tokens.SetAsync(new TokenSession { AccessToken = "secret" });
        await ContractAssert.ThrowsAsync<ArgumentOutOfRangeException>(() => c.Storage.GetUploadUrlAsync("a", 0));
        await ContractAssert.ThrowsAsync<ArgumentException>(() => c.Storage.UploadAsync("a", new MemoryStream(new byte[3]), 2));
        ContractAssert.Empty(api.Calls);
        await c.Storage.UploadAsync("a", new MemoryStream(Encoding.UTF8.GetBytes("hello")), 5, "text/plain");
        ContractAssert.Equal(5, J(api.Calls[0].Body).GetProperty("sizeBytes").GetInt32());
        ContractAssert.Equal("hello", asset.Calls[0].Body); ContractAssert.Empty(asset.Calls[0].Headers);
        ContractAssert.Equal("hello", Encoding.UTF8.GetString(await c.Storage.DownloadAsync("a")));
    }

    public async Task Storage_names_resolve_to_bucket_ids_for_list_and_delete()
    {
        var h = new RecordingHandler { Reply = r => r.RequestUri!.AbsolutePath == "/storage/buckets" ? "{\"buckets\":[{\"id\":\"bucket-id\",\"name\":\"default\"}]}" : "{\"files\":[],\"isTruncated\":true,\"nextToken\":\"next\"}" }; using var c = Client(h);
        await c.Storage.ListAsync(prefix: "a/", limit: 3, cursor: "cur"); await c.Storage.DeleteAsync("a/b");
        ContractAssert.Contains("/buckets/bucket-id/files?prefix=a%2F&maxKeys=3&continuationToken=cur", h.Calls[1].Url);
        ContractAssert.EndsWith("/buckets/bucket-id/files?key=a%2Fb", h.Calls.Last().Url);
    }

    public async Task Function_invoke_and_errors_preserve_server_details()
    {
        var h = new RecordingHandler { Reply = _ => "{\"data\":{\"ok\":true},\"status\":200}" }; using var c = Client(h);
        await c.Functions.InvokeAsync("hello/world", J("{\"body\":{\"name\":\"A\"}}")); ContractAssert.EndsWith("/functions/hello%2Fworld/invoke", h.Calls[0].Url);
        h.Status = HttpStatusCode.Unauthorized; h.Reply = _ => "{\"code\":\"TOKEN_INVALID\",\"message\":\"Invalid\",\"requestId\":\"req-1\"}";
        var error = await ContractAssert.ThrowsAsync<VaifException>(() => c.From("notes").ListAsync()); ContractAssert.Equal("TOKEN_INVALID", error.Code); ContractAssert.Equal(401, error.StatusCode); ContractAssert.Equal("req-1", error.RequestId);
    }

    public async Task Cancellation_prevents_transport_and_signout_keeps_tokens_on_failure()
    {
        var h = new RecordingHandler { Status = HttpStatusCode.ServiceUnavailable }; using var c = Client(h);
        await c.Tokens.SetAsync(new TokenSession { AccessToken = "a", RefreshToken = "r" });
        using var cancel = new CancellationTokenSource(); cancel.Cancel();
        await ContractAssert.ThrowsAnyAsync<OperationCanceledException>(() => c.From("notes").ListAsync(cancel.Token)); ContractAssert.Empty(h.Calls);
        await ContractAssert.ThrowsAsync<VaifException>(() => c.Auth.SignOutAsync()); ContractAssert.NotNull(await c.Tokens.GetAsync());
    }

    public async Task OAuth_uses_S256_and_rejects_unknown_or_replayed_state()
    {
        var h = new RecordingHandler { Reply = _ => "{\"url\":\"https://provider.test/consent\"}" }; using var c = Client(h);
        var start = await c.Auth.StartOAuthAsync("google", "myapp://callback");
        var body = J(h.Calls[0].Body); ContractAssert.Equal("S256", body.GetProperty("codeChallengeMethod").GetString());
        ContractAssert.InRange(start.CodeVerifier.Length, 43, 128); ContractAssert.Equal(43, body.GetProperty("codeChallenge").GetString()!.Length);
        await ContractAssert.ThrowsAsync<VaifException>(() => c.Auth.CompleteOAuthAsync("code", "wrong")); ContractAssert.Single(h.Calls);
        h.Reply = _ => "{\"accessToken\":\"a\",\"refreshToken\":\"r\"}";
        await c.Auth.CompleteOAuthAsync("code", start.State);
        ContractAssert.Equal(start.CodeVerifier, J(h.Calls[1].Body).GetProperty("codeVerifier").GetString());
        await ContractAssert.ThrowsAsync<VaifException>(() => c.Auth.CompleteOAuthAsync("code", start.State));
    }

    public async Task Generated_operations_validate_path_body_and_escape_values()
    {
        var h = new RecordingHandler(); using var c = Client(h);
        await ContractAssert.ThrowsAsync<ArgumentException>(() => c.Operations.GetProjectsByProjectIdAsync());
        await c.Operations.GetProjectsByProjectIdAsync(new OperationRequest { Path = new Dictionary<string,string> { ["projectId"] = "p/1" } });
        ContractAssert.EndsWith("/projects/p%2F1", h.Calls.Single().Url);
    }
}
