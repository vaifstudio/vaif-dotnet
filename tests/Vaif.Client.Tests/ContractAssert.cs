namespace Vaif.Client.Tests;

// Package-free assertions let the identical contract cases run in the conformance
// host when NuGet is offline. xUnit remains the normal discovery/reporting runner.
internal static class ContractAssert
{
    internal static void Equal<T>(T expected, T actual) { if (!EqualityComparer<T>.Default.Equals(expected, actual)) throw new InvalidOperationException($"Expected {expected}, got {actual}."); }
    internal static void True(bool value) { if (!value) throw new InvalidOperationException("Expected true."); }
    internal static void False(bool value) => True(!value);
    internal static void Null(object? value) { if (value != null) throw new InvalidOperationException("Expected null."); }
    internal static void NotNull(object? value) { if (value == null) throw new InvalidOperationException("Expected non-null."); }
    internal static void Empty<T>(IEnumerable<T> value) { if (value.Any()) throw new InvalidOperationException("Expected empty."); }
    internal static void Single<T>(IEnumerable<T> value) => Equal(1, value.Count());
    internal static void Contains(string value, string actual) => True(actual.Contains(value, StringComparison.Ordinal));
    internal static void DoesNotContain(string value, string actual) => False(actual.Contains(value, StringComparison.Ordinal));
    internal static void EndsWith(string value, string actual) => True(actual.EndsWith(value, StringComparison.Ordinal));
    internal static void InRange(int value, int from, int to) => True(value >= from && value <= to);
    internal static async Task<T> ThrowsAsync<T>(Func<Task> action) where T : Exception
    {
        try { await action(); } catch (T ex) when (ex.GetType() == typeof(T)) { return ex; }
        throw new InvalidOperationException("Expected " + typeof(T).Name + ".");
    }
    internal static async Task<T> ThrowsAnyAsync<T>(Func<Task> action) where T : Exception
    {
        try { await action(); } catch (T ex) { return ex; }
        throw new InvalidOperationException("Expected " + typeof(T).Name + ".");
    }
}
