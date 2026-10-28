using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Vaif.Client;

/// <summary>Implement with the platform credential vault. Values contain refresh credentials.</summary>
public interface ITokenVault
{
    /// <summary>Reads a secret by key, or returns null when the key does not exist.</summary>
    Task<string?> ReadAsync(string key, CancellationToken cancellationToken = default);
    /// <summary>Replaces the secret at the supplied key. Implement with the platform secure credential store.</summary>
    Task WriteAsync(string key, string value, CancellationToken cancellationToken = default);
    /// <summary>Removes the secret at the supplied key. Return normally when the key does not exist; throw only when an existing secret could not be removed.</summary>
    Task DeleteAsync(string key, CancellationToken cancellationToken = default);
}

/// <summary>Persists a session in a caller-provided secure vault, scoped to API origin and project.</summary>
public sealed class SecureTokenStorage : ITokenStorage
{
    private readonly ITokenVault _vault;
    /// <summary>Gets the vault key derived from the normalized API origin and project ID.</summary>
    public string Key { get; }
    /// <summary>Creates persistent session storage using the supplied secure vault and API scope.</summary>
    public SecureTokenStorage(ITokenVault vault, Uri apiUrl, string? projectId)
    { _vault = vault ?? throw new ArgumentNullException(nameof(vault)); Key = CreateKey(apiUrl, projectId); }
    /// <summary>Creates a deterministic vault key scoped to the API origin, including its port, and project ID.</summary>
    public static string CreateKey(Uri apiUrl, string? projectId)
    {
        VaifClient.ValidateUrl(apiUrl);
        var scope = VaifJson.Object(("origin", apiUrl.GetLeftPart(UriPartial.Authority).ToLowerInvariant()), ("projectId", projectId)).GetRawText();
        using var sha = SHA256.Create();
        return "vaif.session." + BitConverter.ToString(sha.ComputeHash(Encoding.UTF8.GetBytes(scope))).Replace("-", "").ToLowerInvariant();
    }
    /// <summary>Reads and deserializes the session from the scoped vault entry, or returns null when absent.</summary>
    public async Task<TokenSession?> GetAsync(CancellationToken cancellationToken = default)
    {
        var value = await _vault.ReadAsync(Key, cancellationToken).ConfigureAwait(false);
        return value == null ? null : JsonSerializer.Deserialize(value, VaifJsonContext.Default.TokenSession);
    }
    /// <summary>Serializes and saves the session in the scoped secure vault entry.</summary>
    public Task SetAsync(TokenSession session, CancellationToken cancellationToken = default) =>
        _vault.WriteAsync(Key, JsonSerializer.Serialize(session, VaifJsonContext.Default.TokenSession), cancellationToken);
    /// <summary>Deletes the scoped session entry from the secure vault.</summary>
    public Task ClearAsync(CancellationToken cancellationToken = default) => _vault.DeleteAsync(Key, cancellationToken);
}

// Serializes all session mutations, including calls through client.Tokens. A revision
// protects refresh completion even when a replacement contains identical token values.
internal sealed class SessionStorage : ITokenStorage
{
    private readonly ITokenStorage _storage;
    private readonly SemaphoreSlim _gate = new(1, 1);
    private long _revision;
    private bool _quarantined;
    private bool _signingOut;
    internal SessionStorage(ITokenStorage storage) => _storage = storage;
    internal async Task<(TokenSession? Session, long Revision)> SnapshotAsync(CancellationToken ct)
    {
        await _gate.WaitAsync(ct).ConfigureAwait(false);
        try
        {
            if (_quarantined) throw StorageError();
            if (_signingOut) throw new VaifException("Sign-out is in progress.", "SESSION_CHANGED");
            try { return ((await _storage.GetAsync(ct).ConfigureAwait(false))?.Copy(), _revision); }
            catch (OperationCanceledException) when (ct.IsCancellationRequested) { throw; }
            catch (VaifException) { throw; }
            catch { throw StorageError(); }
        }
        finally { _gate.Release(); }
    }
    /// <summary>Reads a copy of the current session from the configured store.</summary>
    public async Task<TokenSession?> GetAsync(CancellationToken cancellationToken = default) => (await SnapshotAsync(cancellationToken).ConfigureAwait(false)).Session;
    /// <summary>Replaces the stored session, removing the previous credential first.</summary>
    public Task SetAsync(TokenSession session, CancellationToken cancellationToken = default) => ReplaceAsync(session, null, cancellationToken);
    internal Task CompareAndSetAsync(TokenSession session, long revision, CancellationToken ct) => ReplaceAsync(session, revision, ct);
    private async Task ReplaceAsync(TokenSession session, long? expected, CancellationToken ct)
    {
        await _gate.WaitAsync(ct).ConfigureAwait(false);
        try
        {
            if (expected.HasValue && (expected.Value != _revision || _quarantined)) throw new VaifException("The session changed while authentication was in progress.", "SESSION_CHANGED");
            _revision++;
            _signingOut = false;
            _quarantined = true;
            try
            {
                // Remove the previous credential before attempting a write. A failed
                // replacement must never leave the previous account restorable.
                await _storage.ClearAsync(CancellationToken.None).ConfigureAwait(false);
                await _storage.SetAsync(session.Copy(), ct).ConfigureAwait(false);
                _quarantined = false;
            }
            catch (OperationCanceledException) when (ct.IsCancellationRequested)
            {
                try { await _storage.ClearAsync(CancellationToken.None).ConfigureAwait(false); _quarantined = false; }
                catch { _quarantined = true; }
                throw;
            }
            catch
            {
                // A store may partially write before throwing. Attempt removal again.
                try { await _storage.ClearAsync(CancellationToken.None).ConfigureAwait(false); _quarantined = false; }
                catch { _quarantined = true; }
                throw StorageError();
            }
        }
        finally { _gate.Release(); }
    }
    /// <summary>Removes the stored session and invalidates pending refreshes.</summary>
    public async Task ClearAsync(CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();
        await _gate.WaitAsync(cancellationToken).ConfigureAwait(false);
        try
        {
            _revision++; _signingOut = false; _quarantined = true;
            try { await _storage.ClearAsync(CancellationToken.None).ConfigureAwait(false); _quarantined = false; }
            catch { throw StorageError(); }
        }
        finally { _gate.Release(); }
    }
    internal async Task<(TokenSession? Session, long Revision)> BeginSignOutAsync(CancellationToken ct)
    {
        await _gate.WaitAsync(ct).ConfigureAwait(false);
        try
        {
            if (_quarantined) throw StorageError();
            TokenSession? session;
            try { session = (await _storage.GetAsync(ct).ConfigureAwait(false))?.Copy(); }
            catch (OperationCanceledException) when (ct.IsCancellationRequested) { throw; }
            catch { throw StorageError(); }
            _revision++; _signingOut = true;
            return (session, _revision);
        }
        finally { _gate.Release(); }
    }
    internal async Task EndSignOutAsync(long revision)
    {
        await _gate.WaitAsync().ConfigureAwait(false);
        try { if (revision == _revision) _signingOut = false; }
        finally { _gate.Release(); }
    }
    internal async Task ClearIfCurrentAsync(long revision, CancellationToken ct)
    {
        await _gate.WaitAsync(ct).ConfigureAwait(false);
        try
        {
            if (revision != _revision) return;
            _revision++; _signingOut = false; _quarantined = true;
            try { await _storage.ClearAsync(CancellationToken.None).ConfigureAwait(false); _quarantined = false; }
            catch { throw StorageError(); }
        }
        finally { _gate.Release(); }
    }
    private static VaifException StorageError() => new("The session store failed. Repair or clear persistent credentials before reusing this session.", "SESSION_STORAGE_ERROR");
}
