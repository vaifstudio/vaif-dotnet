using System.Reflection;
using System.Text.RegularExpressions;
using Xunit;

namespace Vaif.Client.Tests;

public sealed class GeneratedOperationTests
{
    [Fact]
    public async Task Generated_staff_list_is_enforced_before_io()
    {
        var handler = new RecordingHandler();
        using var client = new VaifClient(new VaifClientOptions(), handler);
        var constructor = typeof(OperationDescriptor).GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic).Single();
        foreach (var route in Operations.StaffOnlyRoutes)
        {
            var parts = route.Split(' ', 2);
            var descriptor = (OperationDescriptor)constructor.Invoke(new object?[] { "StaffProbe", parts[0], parts[1], "json", null, false, Array.Empty<string>() });
            var request = new OperationRequest { Path = Regex.Matches(parts[1], "\\{([^}]+)\\}").Cast<Match>().ToDictionary(m => m.Groups[1].Value, _ => "p") };
            Assert.Equal("STAFF_ONLY", (await Assert.ThrowsAsync<VaifException>(() => client.Operations.CallAsync(descriptor, request))).Code);
        }
        Assert.Empty(handler.Calls);
    }

    [Fact]
    public async Task No_public_generated_method_calls_a_platform_staff_route()
    {
        var staff = Operations.StaffOnlyRoutes.ToHashSet(StringComparer.Ordinal);
        var handler = new RecordingHandler();
        using var client = new VaifClient(new VaifClientOptions { BaseUrl = new Uri("https://api.test"), ProjectId = "p" }, handler);
        var methods = typeof(Operations).GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly)
            .Where(m => m.Name != nameof(Operations.CallAsync)).ToDictionary(m => m.Name);
        Assert.Equal(775, Operations.All.Count);
        Assert.Equal(168, Operations.Ungenerated.Count);
        Assert.Equal(134, staff.Count);
        Assert.Equal(134, Operations.Ungenerated.Count(route => route.EndsWith(": platform staff only", StringComparison.Ordinal)));
        Assert.Contains("POST /admin/admins: platform staff only", Operations.Ungenerated);
        Assert.Null(typeof(Operations).GetMethod("PostFlagsAsync"));
        Assert.Null(typeof(Operations).GetMethod("PostEnterpriseInvoicesByInvoiceIdPaidAsync"));
        Assert.Equal(Operations.All.Count, methods.Count);
        foreach (var operation in Operations.All)
        {
            Assert.DoesNotContain(operation.Method + " " + operation.Path, staff);
            var request = new OperationRequest
            {
                Path = Regex.Matches(operation.Path, "\\{([^}]+)\\}").Cast<Match>().ToDictionary(m => m.Groups[1].Value, _ => "p"),
                Query = operation.RequiredQuery.ToDictionary(k => k, _ => "value"),
                Body = operation.BodyKind == "json" ? VaifJson.Parse("{}") : null,
                Content = operation.BodyKind is "binary" or "text" ? new StringContent("test") : null
            };
            try
            {
                using var response = await (Task<OperationResponse>)methods[operation.Name + "Async"].Invoke(client.Operations, new object[] { request, CancellationToken.None })!;
            }
            catch (VaifConsoleOnlyException) { } // Platform signup/reset are blocked locally.
        }
        Assert.NotEmpty(handler.Calls);

        var omittedStaff = Operations.Ungenerated.Where(route => route.Contains(": platform staff only", StringComparison.Ordinal)).ToArray();
        Assert.NotEmpty(omittedStaff);
        Assert.All(omittedStaff, route => Assert.Contains(route.Substring(0, route.IndexOf(": ", StringComparison.Ordinal)), staff));
        Assert.All(Operations.Ungenerated.Where(route => route.Contains("retired", StringComparison.Ordinal)),
            route => Assert.EndsWith(": retired; the API answers 410", route));
    }
}
