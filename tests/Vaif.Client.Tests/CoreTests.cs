using Xunit;
namespace Vaif.Client.Tests;

public sealed class CoreTests
{
    [Fact]
    public void Loads_the_requested_sdk_assembly()
    {
        var target = System.Reflection.CustomAttributeExtensions.GetCustomAttribute<System.Runtime.Versioning.TargetFrameworkAttribute>(typeof(VaifClient).Assembly)!.FrameworkName;
#if SDK_NETSTANDARD
        Assert.Equal(".NETStandard,Version=v2.1", target);
#else
        Assert.Equal(".NETCoreApp,Version=v8.0", target);
#endif
    }

    public static IEnumerable<object[]> SecurityNames => SecurityCases.All.Keys.Select(name => new object[] { name });
    [Theory]
    [MemberData(nameof(SecurityNames))]
    public Task Security_contracts(string name) => SecurityCases.All[name]();

    [Theory]
    [InlineData("Console_only_signup_and_reset_never_send_requests")]
    [InlineData("Project_login_persists_tokens_and_refresh_rotates_in_body_mode")]
    [InlineData("Mfa_challenge_preserves_existing_session_until_verified")]
    [InlineData("Query_encodes_filters_order_range_and_does_not_mutate_parent")]
    [InlineData("Writes_use_real_upsert_bulk_and_aggregate_contracts")]
    [InlineData("Upload_requires_exact_size_and_asset_transfers_never_carry_credentials")]
    [InlineData("Storage_names_resolve_to_bucket_ids_for_list_and_delete")]
    [InlineData("Function_invoke_and_errors_preserve_server_details")]
    [InlineData("Cancellation_prevents_transport_and_signout_keeps_tokens_on_failure")]
    [InlineData("OAuth_uses_S256_and_rejects_unknown_or_replayed_state")]
    [InlineData("Generated_operations_validate_path_body_and_escape_values")]
    public Task Sdk_contracts(string name) => ContractCases.RunAsync(name);
}

public sealed class PublicApiConventionTests
{
    [Fact]
    public void Public_async_methods_use_the_Async_suffix_and_take_cancellation_last()
    {
        var violations = new List<string>();
        foreach (var type in typeof(VaifClient).Assembly.GetExportedTypes())
        foreach (var method in type.GetMethods(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.DeclaredOnly))
        {
            if (method.IsSpecialName) continue;
            var parameters = method.GetParameters();
            bool awaitable = typeof(Task).IsAssignableFrom(method.ReturnType) || method.ReturnType == typeof(ValueTask);
            if (awaitable != method.Name.EndsWith("Async", StringComparison.Ordinal)) violations.Add(type.Name + "." + method.Name + ": suffix");
            if (!awaitable || method.Name == "DisposeAsync") continue;
            int token = Array.FindIndex(parameters, p => p.ParameterType == typeof(CancellationToken));
            bool paramsOverload = parameters.Length > 0 && parameters[^1].IsDefined(typeof(ParamArrayAttribute), false);
            if (token == -1 && !paramsOverload) violations.Add(type.Name + "." + method.Name + ": no CancellationToken");
            if (token != -1 && token != parameters.Length - 1) violations.Add(type.Name + "." + method.Name + ": CancellationToken not last");
        }
        Assert.Equal(new string[0], violations.ToArray());
    }
}
