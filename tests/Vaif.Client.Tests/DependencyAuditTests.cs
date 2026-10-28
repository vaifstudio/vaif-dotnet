using System.Diagnostics;
using Xunit;
using Xunit.Abstractions;

namespace Vaif.Client.Tests;

public sealed class DependencyAuditTests
{
    private readonly ITestOutputHelper _output;
    public DependencyAuditTests(ITestOutputHelper output) => _output = output;

    [Fact]
    public async Task Dependency_audit_fails_closed_including_when_vulnerable_package_listing_exits_zero()
    {
        var start = new ProcessStartInfo("python3")
        {
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false
        };
        foreach (var argument in new[] { "-m", "unittest", "discover", "-s", Path.Combine(AppContext.BaseDirectory, "audit"), "-p", "test_*.py", "-v" })
            start.ArgumentList.Add(argument);
        using var process = Process.Start(start) ?? throw new InvalidOperationException("Could not start the dependency audit guard tests. Python 3 is required.");
        var stdout = process.StandardOutput.ReadToEndAsync();
        var stderr = process.StandardError.ReadToEndAsync();
        try { await process.WaitForExitAsync().WaitAsync(TimeSpan.FromSeconds(30)); }
        catch { process.Kill(entireProcessTree: true); throw; }
        var output = await stdout + await stderr;
        _output.WriteLine(output);
        Assert.True(process.ExitCode == 0, output);
        Assert.Contains("test_main_rejects_vulnerabilities_even_when_dotnet_exits_zero", output);
        Assert.Contains("OK", output);
    }
}
