# VAIF Studio .NET SDK

<!-- BEGIN GENERATED SDK STATUS: notice:csharp -->
> `Vaif.Client` 1.0.0 is the version in this repository, has not been tagged yet and is not on NuGet yet. The hosted API (`https://api.vaif.studio`) and console are not available yet.
<!-- END GENERATED SDK STATUS: notice:csharp -->

`Vaif.Client` provides asynchronous access to VAIF Studio app-user
authentication, database queries, file storage, functions, and realtime database
changes. Generated methods on `client.Operations` cover the API's other
operations, including the VAIF Verament routes under `/ai/copilot`. There is no
dedicated Verament client in this SDK. Namespace: `Vaif.Client`.

Source: https://github.com/vaifstudio/vaif-dotnet. The installation command
works once the package is on NuGet. The examples below describe the client API
and require a running API deployment to execute.

## Requirements

- .NET 8, or a host implementing .NET Standard 2.1.
- .NET SDK 8 to build this repository.
- Unity 2021.2 or later for native players using .NET Standard 2.1.
- A VAIF Studio project ID and publishable API key for app-user operations.

The SDK uses System.Text.Json with source-generated metadata. Open-schema
payloads use JsonElement and Utf8JsonWriter. There is no runtime code generation,
reflection serialization fallback, or Newtonsoft.Json dependency. Keep the host
runtime and resolved NuGet dependencies updated.

## Installation

After publication:

```sh
dotnet add package Vaif.Client --version 1.0.0
```

### Unity

Unity 2021.2 introduced .NET Standard 2.1 support; Unity 2021.1 is outside this
package's target floor. Select .NET Standard 2.1 under API Compatibility Level.
Import the built `lib/netstandard2.1/Vaif.Client.dll`, rather than this
repository's C# 12 source.

Use your team's NuGet-to-Unity importer, or restore Vaif.Client in a temporary
netstandard2.1 project and copy the resolved runtime assemblies into
`Assets/Plugins/VAIF/`. The package requires System.Text.Json 8.0.5 or later;
use its .NET Standard assets and their runtime dependencies. Avoid duplicate
assemblies supplied by Unity. Do not import .NET 8 assemblies, reference
assemblies, or Roslyn analyzers. NuGet does not install packages into Unity
directly; no importer is bundled.

Copy [unity/link.xml](unity/link.xml) into `Assets/VAIF/link.xml` for IL2CPP
stripping. It conservatively preserves the SDK and JSON metadata. Build and test
an IL2CPP player with stripping enabled before distributing an application.
Compiling netstandard2.1 and running it on .NET 8 do not validate a Unity player.
WebGL requires browser-specific HTTP/WebSocket transports and is not supported
by the supplied native transports.

The `unity/` directory is distribution metadata. It is not a complete UPM
package until compiled assemblies and dependency licenses are added to a release.

## Quick start

```csharp
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
```

All network methods accept CancellationToken. Use one client per app-user
session. In Unity, use the main thread when updating game objects after awaiting;
the SDK uses ConfigureAwait(false) internally. Cancel requests on scene unload.

## Auth

With ProjectId set, auth calls use `/projects/{projectId}/auth`:

```csharp
await client.Auth.SignUpAsync("player@example.com", "password", cancellationToken: cancel.Token);
var user = await client.Auth.GetUserAsync(cancel.Token);
await client.Auth.RequestPasswordResetAsync("player@example.com", cancellationToken: cancel.Token);
await client.Auth.ConfirmPasswordResetAsync("reset-token", "new-password", cancel.Token);
await client.Auth.RefreshAsync(cancel.Token);
await client.Auth.SignOutAsync(cancel.Token);
```

Platform-account signup and password reset belong in the console. Those methods
throw VaifConsoleOnlyException with Code `CONSOLE_ONLY` before sending a request
when ProjectId is absent. This guard also applies to generated operations.

MFA methods are `Auth.Mfa.EnrollStartAsync`, `EnrollConfirmAsync`, `VerifyAsync`,
`DisableAsync`, and `RegenerateCodesAsync`. A challenge response does not replace
the current session; successful verification does.

OAuth uses PKCE S256 and a one-use state, kept in memory for ten minutes:

```csharp
var oauth = await client.Auth.StartOAuthAsync("google", "myapp://callback", cancel.Token);
// Open oauth.Url in the OS browser. Receive code and state from the callback.
var callback = new Uri("myapp://callback?code=returned-code&state=" + Uri.EscapeDataString(oauth.State));
var callbackValues = callback.Query.TrimStart('?').Split('&')
    .Select(pair => pair.Split(new[] { '=' }, 2))
    .ToDictionary(pair => pair[0], pair => Uri.UnescapeDataString(pair[1]));
var signedIn = await client.Auth.CompleteOAuthAsync(callbackValues["code"], callbackValues["state"], cancel.Token);
```

Use the same client for the callback. The callback URI above illustrates parsing;
your application must supply the callback received from its registered handler.
Never put tokens or the PKCE verifier in logs or URLs you share.

The default token store is in memory. Set TokenVault to an ITokenVault backed by
the platform credential vault to persist sessions. The SDK's SecureTokenStorage
keys values by API origin (scheme, host, port) and project ID. TokenStorage accepts
an alternative ITokenStorage with async GetAsync, SetAsync, and ClearAsync methods;
that implementation owns its storage isolation. Do not mutate its underlying
store outside the client while requests are in progress.

Sign-out sends the refresh credential to revoke the session even if access has
expired. It clears persistent credentials after server success, throws
`SESSION_STORAGE_ERROR` if clearing fails, and invalidates pending refreshes.
Failed saves remove older credentials before attempting a replacement. If a
store cannot remove credentials, the client refuses to reuse it until repaired.
Use a store whose ClearAsync reliably removes persisted values; no SDK can erase
credentials from a vault that refuses deletion. ClearAsync and vault DeleteAsync
must return normally when the entry is already absent.

A refresh commits only if the session revision it started with still matches.
Concurrent refreshes share the rotated result. Authentication-layer
401 `TOKEN_INVALID` or `TOKEN_EXPIRED` responses trigger one refresh and one
retry when a refresh credential is available. The retry uses only the session
produced by that refresh; a cleared or replaced session stops the retry with
`SESSION_CHANGED`. Requests that issue credentials (sign-in, refresh, sign-out,
OAuth and MFA verification) and stream uploads are not replayed automatically.
Authenticated user, MFA management, and session requests can refresh and retry.
Other errors are not retried.

## Data

Queries are immutable. Range endpoints are inclusive.

```csharp
var notes = client.From("notes");
var rows = await notes.Select("id", "body").Filter("body", "ilike", VaifJson.Parse("\"hello%\""))
    .Order("body").Limit(20).ListAsync(cancel.Token);
var inserted = await notes.InsertAsync(VaifJson.Parse("{\"body\":\"Hello\"}"), cancel.Token);
var id = inserted.GetProperty("data").GetProperty("id").GetString()!;
await notes.UpdateAsync(id, VaifJson.Object(("body", "Updated")), cancel.Token);
await notes.UpsertAsync(VaifJson.Object(("id", id), ("body", "Saved")), new[] { "id" }, cancel.Token);
var count = await notes.Eq("body", "Saved").CountAsync(cancel.Token);
await notes.DeleteAsync(id, cancel.Token);
```

Filter operators: eq, neq, gt, gte, lt, lte, in, like, ilike. Values are JsonElement.
InsertManyAsync accepts an array. UpdateManyAsync, DeleteManyAsync, and CountAsync
support non-null scalar equality filters only; unsupported filters throw locally.
Bulk writes without filters address the whole table as permitted by the API.

## Storage

```csharp
using var input = File.OpenRead("avatar.png");
await client.Storage.UploadAsync("avatars/me.png", input, input.Length,
    "image/png", cancellationToken: cancel.Token);
var bytes = await client.Storage.DownloadAsync("avatars/me.png", cancellationToken: cancel.Token);
var shareUrl = await client.Storage.CreateSignedUrlAsync("avatars/me.png", cancellationToken: cancel.Token);
var files = await client.Storage.ListAsync(prefix: "avatars/", cancellationToken: cancel.Token);
await client.Storage.DeleteAsync("avatars/me.png", cancellationToken: cancel.Token);
```

Uploads require sizeBytes from 1 byte to 5 GiB. Seekable streams must have exactly
that many bytes remaining; non-seekable streams are bounded by the declared size.
The caller owns the input stream. OpenDownloadAsync returns an open response for
streaming; dispose it after reading. ListAsync returns the API's files, folders,
nextToken, and isTruncated fields. List/delete resolve bucket names to IDs;
pass a bucket UUID directly to avoid name lookup.

Upload and signed URLs are validated before return and use a separate transport
without API credentials. HTTPS is required except HTTP to localhost, 127.0.0.1,
or ::1. Redirects are refused. Signed asset transfers have no SDK timeout;
use a CancellationTokenSource with the deadline appropriate for the file size.
The API request to obtain the signed URL uses RequestTimeout.

## Functions

```csharp
var result = await client.Functions.InvokeAsync("hello_world",
    VaifJson.Object(("name", "A")), cancel.Token);
var status = result.GetProperty("status").GetInt32();
var data = result.GetProperty("data");
```

Input is the API payload. To send an HTTP invocation envelope, include method
and path along with body, headers, or query as the API requires. The SDK returns
status, data, requestId, and durationMs. A completed function's own HTTP status,
including 401, is returned as content and never triggers token refresh.
Authentication errors before a run throw VaifException.

## Realtime

```csharp
await using var realtime = client.CreateRealtimeClient();
await realtime.ConnectAsync(cancel.Token);
await realtime.SubscribeTableAsync("notes", cancel.Token);
var change = await realtime.ReceiveAsync(cancel.Token);
await realtime.UnsubscribeAsync("table:notes", cancel.Token);
```

ClientWebSocket sends credentials in the first auth frame, waits for welcome,
and waits for subscription acknowledgments. RefreshAuthAsync updates an open
connection after an HTTP token refresh. Native WebSocket ping/pong is handled by
ClientWebSocket. The receive queue holds at most 1,024 events and messages at
most 1 MiB; overflow surfaces an error so the app can reload data.

A rejected channel subscription fails that operation while the connection stays
open. Nonfatal error frames without a matching request are delivered by
ReceiveAsync. Queued events remain readable after closure; subsequent reads
throw `REALTIME_CLOSED` after a normal local close.

Create a new realtime client to reconnect after failure. Automatic reconnect,
presence/broadcast helpers, and WebGL socket implementations are not provided.
IRealtimeTransport allows a host-specific adapter. Realtime URLs map HTTPS to
WSS and literal-localhost HTTP to WS; credentials are never put in the URL.

## Error handling

```csharp
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
```

VaifException exposes Code, StatusCode, RequestId, and optional Details.
Transport errors and realtime/stream failures use this type. Caller cancellation
remains OperationCanceledException. Invalid method arguments throw standard
argument exceptions. Do not log request payloads or tokens when handling errors.

## Configuration

VaifClientOptions accepts BaseUrl (default `https://api.vaif.studio`), ApiKey,
ProjectId, DefaultBucket, RequestTimeout, TokenStorage, and TokenVault. Choose TokenStorage or
TokenVault, not both. BaseUrl must use HTTPS or HTTP on literal localhost.
RequestTimeout defaults to 100 seconds for each API send, including request-body
upload and response headers. Each refresh or retry has its own deadline. Set
Timeout.InfiniteTimeSpan to disable it. The timeout does not bound response-body
streaming or signed asset transfers; supply caller cancellation for those.
SDK deadlines throw VaifException with Code `TIMEOUT`; caller cancellation
remains OperationCanceledException.

The constructor optionally accepts API and asset HttpMessageHandlers. The caller
owns injected handlers; the SDK owns its HttpClients. Standard HTTP handlers have
redirects and cookies disabled before use. Custom handlers are trusted transport
implementations: they must not redirect, add credentials to signed transfers, or
log secrets. Do not reuse a standard handler that has already sent a request.
Redirect responses use Code `REDIRECT_REFUSED`. A response-origin check also
rejects a custom transport response associated with a different origin; custom
transports must prevent forwarding before sending anything.

For dependency injection, scope VaifClient to one app-user session and dispose
it when that scope ends. The constructor accepts handlers, rather than an
IHttpClientFactory or externally created HttpClient. No DI integration package
is provided. Sharing a single client across different users shares their session.

Generated methods call routes with supported JSON, binary, or event-stream
response contracts. There are 775 generated operations and 168 exclusions:
134 operations marked "platform staff only" and 34 routes without a typed
success response. Operations.Ungenerated lists each omitted route with its
reason. Operations.StaffOnlyRoutes is the generated list used by the runtime
guard; calls to staff operations fail with `STAFF_ONLY` before I/O.

```csharp
using var response = await client.Operations.GetProjectsByProjectIdAsync(
    new OperationRequest { Path = new Dictionary<string, string> { ["projectId"] = "p" } }, cancel.Token);
var project = response.Json;
```

Required path/query values and body presence are validated locally. Path values
that are empty, ".", or ".." are rejected before transport. Responses
use JsonElement; field schemas remain server-validated. For binary and SSE
operations, read Response.Content and dispose the OperationResponse afterward.
Stream read failures are wrapped in VaifException. Supply source-generated JSON
type metadata explicitly if mapping application POCOs; the SDK has no reflection
serializer fallback.

## Versioning and support policy

The package follows semantic versioning.
Breaking public API changes require a major release. Minor releases add compatible
functionality; patch releases contain compatible fixes. After the first release,
the latest 1.x release will receive fixes; earlier minor and patch releases will
not be maintained separately. See [CHANGELOG.md](CHANGELOG.md).

Report reproducible SDK problems at
https://github.com/vaifstudio/vaif-dotnet/issues. Include the SDK version and
runtime/Unity target. Unity native IL2CPP player validation and live API
conformance are release checks separate from the .NET test suite.

Public types and members include XML documentation for IDE help. Builds generate
`Vaif.Client.xml` for both targets and fail on undocumented public APIs (CS1591).
Release packages include SourceLink metadata and symbols from the standalone
repository commit, with deterministic builds.

## Security

Report vulnerabilities privately to security@vaif.studio. See
[SECURITY.md](SECURITY.md). Use publishable keys in distributed apps and secure
platform storage for refresh credentials. CI checks all resolved NuGet
dependencies with `dotnet list package --vulnerable --include-transitive` and
fails for known vulnerabilities or unavailable audit data.

## License

MIT. Copyright (c) 2026 VAIF Studio LLC. See [LICENSE](LICENSE).
