// README examples, compiled by CI. Requires a disposable project to execute.
using Vaif.Client;

using var client = new VaifClient(new VaifClientOptions
{
    ProjectId = "your-project-id",
    ApiKey = "vk_pub_your_publishable_key"
});
using var cancel = new CancellationTokenSource(TimeSpan.FromSeconds(30));
var auth = await client.Auth.SignInAsync("player@example.com", "password",
    cancellationToken: cancel.Token);
if (auth.MfaRequired)
    auth = await client.Auth.Mfa.VerifyAsync(auth.ChallengeToken!, "123456", cancel.Token);
var page = await client.From("notes").Select("id", "body")
    .Eq("owner_id", auth.User.GetProperty("id").GetString()!)
    .Order("body").Range(0, 19).ListAsync(cancel.Token);

await client.Auth.SignUpAsync("player@example.com", "password", cancellationToken: cancel.Token);
var user = await client.Auth.GetUserAsync(cancel.Token);
await client.Auth.RequestPasswordResetAsync("player@example.com", cancellationToken: cancel.Token);
await client.Auth.ConfirmPasswordResetAsync("reset-token", "new-password", cancel.Token);
await client.Auth.RefreshAsync(cancel.Token);
await client.Auth.SignOutAsync(cancel.Token);

var oauth = await client.Auth.StartOAuthAsync("google", "myapp://callback", cancel.Token);
// Open oauth.Url in the OS browser. Receive code and state from the callback.
var callback = new Uri("myapp://callback?code=returned-code&state=" + Uri.EscapeDataString(oauth.State));
var callbackValues = callback.Query.TrimStart('?').Split('&')
    .Select(pair => pair.Split(new[] { '=' }, 2))
    .ToDictionary(pair => pair[0], pair => Uri.UnescapeDataString(pair[1]));
var signedIn = await client.Auth.CompleteOAuthAsync(callbackValues["code"], callbackValues["state"], cancel.Token);

var notes = client.From("notes");
var rows = await notes.Select("id", "body").Filter("body", "ilike", VaifJson.Parse("\"hello%\""))
    .Order("body").Limit(20).ListAsync(cancel.Token);
var inserted = await notes.InsertAsync(VaifJson.Parse("{\"body\":\"Hello\"}"), cancel.Token);
var id = inserted.GetProperty("data").GetProperty("id").GetString()!;
await notes.UpdateAsync(id, VaifJson.Object(("body", "Updated")), cancel.Token);
await notes.UpsertAsync(VaifJson.Object(("id", id), ("body", "Saved")), new[] { "id" }, cancel.Token);
var count = await notes.Eq("body", "Saved").CountAsync(cancel.Token);
await notes.DeleteAsync(id, cancel.Token);

using var input = File.OpenRead("avatar.png");
await client.Storage.UploadAsync("avatars/me.png", input, input.Length,
    "image/png", cancellationToken: cancel.Token);
var bytes = await client.Storage.DownloadAsync("avatars/me.png", cancellationToken: cancel.Token);
var shareUrl = await client.Storage.CreateSignedUrlAsync("avatars/me.png", cancellationToken: cancel.Token);
var files = await client.Storage.ListAsync(prefix: "avatars/", cancellationToken: cancel.Token);
await client.Storage.DeleteAsync("avatars/me.png", cancellationToken: cancel.Token);

var result = await client.Functions.InvokeAsync("hello_world",
    VaifJson.Object(("name", "A")), cancel.Token);
var status = result.GetProperty("status").GetInt32();
var data = result.GetProperty("data");

await using var realtime = client.CreateRealtimeClient();
await realtime.ConnectAsync(cancel.Token);
await realtime.SubscribeTableAsync("notes", cancel.Token);
var change = await realtime.ReceiveAsync(cancel.Token);
await realtime.UnsubscribeAsync("table:notes", cancel.Token);

try
{
    await client.From("notes").ListAsync(cancel.Token);
}
catch (VaifException error)
{
    Console.WriteLine($"{error.Code} ({error.StatusCode}), request {error.RequestId}");
}
catch (OperationCanceledException) when (cancel.IsCancellationRequested)
{
    // The caller canceled this operation.
}

using var response = await client.Operations.GetProjectsByProjectIdAsync(
    new OperationRequest { Path = new Dictionary<string, string> { ["projectId"] = "p" } }, cancel.Token);
var project = response.Json;
