// GENERATED FILE — do not edit by hand.
// Source: VAIF OpenAPI contract sha256:615e77b7a0789543; 775 operations generated, 168 not generated.
// Maintainers regenerate this file from the API contract. See CONTRIBUTING.md.
#nullable enable
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
namespace Vaif.Client;

public sealed partial class Operations
{
    /// <summary>Gets the descriptors for all generated API operations.</summary>
    public static IReadOnlyList<OperationDescriptor> All { get; } = System.Array.AsReadOnly(new OperationDescriptor[]
    {
        new OperationDescriptor("DeleteAiCopilotSessionBySessionId", "DELETE", "/ai/copilot/session/{sessionId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteAlertRulesByRuleId", "DELETE", "/alert-rules/{ruleId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteAuthMeLinkedAccountsByProvider", "DELETE", "/auth/me/linked-accounts/{provider}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteAuthSessionsById", "DELETE", "/auth/sessions/{id}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteBillingOrgByOrgIdAddonsByAddonId", "DELETE", "/billing/org/{orgId}/addons/{addonId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteBillingOrgByOrgIdContactsByContactId", "DELETE", "/billing/org/{orgId}/contacts/{contactId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteBillingOrgByOrgIdUsageAlertsByAlertId", "DELETE", "/billing/org/{orgId}/usage-alerts/{alertId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteBucketsByBucketId", "DELETE", "/buckets/{bucketId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteBucketsByBucketIdFiles", "DELETE", "/buckets/{bucketId}/files", "json", null, false, new string[] { "key" }),
        new OperationDescriptor("DeleteDatabaseExtensionsProjectByProjectIdByExtensionId", "DELETE", "/database/extensions/project/{projectId}/{extensionId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteDatabaseWrappersProjectByProjectIdByWrapperId", "DELETE", "/database/wrappers/project/{projectId}/{wrapperId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteFunctionsByFunctionId", "DELETE", "/functions/{functionId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteFunctionsByFunctionIdSchedule", "DELETE", "/functions/{functionId}/schedule", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteFunctionsSecretsBySecretId", "DELETE", "/functions/secrets/{secretId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteFunctionsTriggersByTriggerId", "DELETE", "/functions/triggers/{triggerId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteGeneratedByTableBulk", "DELETE", "/generated/{table}/bulk", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteGeneratedByTableById", "DELETE", "/generated/{table}/{id}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteIntegrationsSubscriptionsById", "DELETE", "/integrations/subscriptions/{id}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteMcpConnectionsById", "DELETE", "/mcp/connections/{id}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteMongodbByCollectionIndexesByIndexName", "DELETE", "/mongodb/{collection}/indexes/{indexName}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteMongodbCollectionsByName", "DELETE", "/mongodb/collections/{name}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteOauthOrgByOrgIdProviderByProvider", "DELETE", "/oauth/org/{orgId}/provider/{provider}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteOrgsByOrgIdInvitesByInviteId", "DELETE", "/orgs/{orgId}/invites/{inviteId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteOrgsByOrgIdLeaveRequestsMine", "DELETE", "/orgs/{orgId}/leave-requests/mine", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteOrgsByOrgIdMembersByUserId", "DELETE", "/orgs/{orgId}/members/{userId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteOrgsByOrgIdTransfersById", "DELETE", "/orgs/{orgId}/transfers/{id}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteProjectsByProjectId", "DELETE", "/projects/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteProjectsByProjectIdAuthOauthAppsByProvider", "DELETE", "/projects/{projectId}/auth/oauth-apps/{provider}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteProjectsByProjectIdAuthSessions", "DELETE", "/projects/{projectId}/auth/sessions", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteProjectsByProjectIdAuthSessionsById", "DELETE", "/projects/{projectId}/auth/sessions/{id}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteProjectsByProjectIdBranchesByBranchName", "DELETE", "/projects/{projectId}/branches/{branchName}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteProjectsByProjectIdDatabaseDedicated", "DELETE", "/projects/{projectId}/database/dedicated", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteProjectsByProjectIdEnvVarsByEnvVarId", "DELETE", "/projects/{projectId}/env-vars/{envVarId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteProjectsByProjectIdEnvironmentsByEnvId", "DELETE", "/projects/{projectId}/environments/{envId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteProjectsByProjectIdEnvironmentsByEnvIdDomainsByDomainId", "DELETE", "/projects/{projectId}/environments/{envId}/domains/{domainId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteProjectsByProjectIdGithubDisconnect", "DELETE", "/projects/{projectId}/github/disconnect", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteProjectsByProjectIdInfrastructureByInstanceId", "DELETE", "/projects/{projectId}/infrastructure/{instanceId}", "json", "json", false, new string[] {  }),
        new OperationDescriptor("DeleteProjectsByProjectIdMembersByUserId", "DELETE", "/projects/{projectId}/members/{userId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteProjectsByProjectIdUsersByUserId", "DELETE", "/projects/{projectId}/users/{userId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteProjectsByProjectIdUsersByUserIdSessionsBySessionId", "DELETE", "/projects/{projectId}/users/{userId}/sessions/{sessionId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteRlsPoliciesByPolicyId", "DELETE", "/rls/policies/{policyId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteSchemaEngineSnippetsByProjectIdBySnippetId", "DELETE", "/schema-engine/snippets/{projectId}/{snippetId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteServicesByServiceId", "DELETE", "/services/{serviceId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteServicesByServiceIdDomainsByDomainId", "DELETE", "/services/{serviceId}/domains/{domainId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteServicesByServiceIdGitConnect", "DELETE", "/services/{serviceId}/git/connect", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteSsoOrgByOrgIdConnectionsByConnectionId", "DELETE", "/sso/org/{orgId}/connections/{connectionId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteSsoOrgByOrgIdConnectionsByConnectionIdCertificatesByCertId", "DELETE", "/sso/org/{orgId}/connections/{connectionId}/certificates/{certId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteSsoOrgByOrgIdConnectionsByConnectionIdIdentitiesByUserId", "DELETE", "/sso/org/{orgId}/connections/{connectionId}/identities/{userId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteSsoOrgByOrgIdConnectionsByConnectionIdScimTokensByTokenId", "DELETE", "/sso/org/{orgId}/connections/{connectionId}/scim/tokens/{tokenId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteSsoOrgByOrgIdOutsideMembersAllowByAllowId", "DELETE", "/sso/org/{orgId}/outside-members/allow/{allowId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteSsoOrgByOrgIdSecurityContact", "DELETE", "/sso/org/{orgId}/security-contact", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteStorageBucketsByBucketIdPoliciesByPolicyId", "DELETE", "/storage/buckets/{bucketId}/policies/{policyId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteTemplatesById", "DELETE", "/templates/{id}", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteV1DataByProjectIdByTableBulk", "DELETE", "/v1/data/{projectId}/{table}/bulk", "json", null, false, new string[] {  }),
        new OperationDescriptor("DeleteV1DataByProjectIdByTableById", "DELETE", "/v1/data/{projectId}/{table}/{id}", "json", null, false, new string[] {  }),
        new OperationDescriptor("Get", "GET", "/", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetActivationOrgByOrgId", "GET", "/activation/org/{orgId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiCopilotAutocomplete", "GET", "/ai/copilot/autocomplete", "json", null, false, new string[] { "projectId" }),
        new OperationDescriptor("GetAiCopilotContextSummaryByProjectId", "GET", "/ai/copilot/context-summary/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiCopilotCreditStatusByProjectId", "GET", "/ai/copilot/credit-status/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiCopilotDeployByDeployId", "GET", "/ai/copilot/deploy/{deployId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiCopilotDeployHistoryByProjectId", "GET", "/ai/copilot/deploy/history/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiCopilotExecutionByExecutionId", "GET", "/ai/copilot/execution/{executionId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiCopilotExecutionsBySessionId", "GET", "/ai/copilot/executions/{sessionId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiCopilotGitBranchesBySessionId", "GET", "/ai/copilot/git/branches/{sessionId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiCopilotGitFilesBySessionId", "GET", "/ai/copilot/git/files/{sessionId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiCopilotGitLogBySessionId", "GET", "/ai/copilot/git/log/{sessionId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiCopilotGitStatusBySessionId", "GET", "/ai/copilot/git/status/{sessionId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiCopilotJobByJobId", "GET", "/ai/copilot/job/{jobId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiCopilotManifestByManifestId", "GET", "/ai/copilot/manifest/{manifestId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiCopilotMetricsByProjectId", "GET", "/ai/copilot/metrics/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiCopilotMetricsOrgByOrgId", "GET", "/ai/copilot/metrics/org/{orgId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiCopilotModelsByProjectId", "GET", "/ai/copilot/models/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiCopilotSessionBySessionId", "GET", "/ai/copilot/session/{sessionId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiCopilotSessionBySessionIdEditorFiles", "GET", "/ai/copilot/session/{sessionId}/editor-files", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiCopilotSessionBySessionIdWorkspaceExport", "GET", "/ai/copilot/session/{sessionId}/workspace/export", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiCopilotSessionBySessionIdWorkspaceStatus", "GET", "/ai/copilot/session/{sessionId}/workspace/status", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiCopilotSessionBySessionIdWorkspaceTypes", "GET", "/ai/copilot/session/{sessionId}/workspace/types", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiCopilotSessionsByProjectId", "GET", "/ai/copilot/sessions/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiCopilotUsageByProjectId", "GET", "/ai/copilot/usage/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiCopilotUsageOrgByOrgId", "GET", "/ai/copilot/usage-org/{orgId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiCopilotVersionByVersionId", "GET", "/ai/copilot/version/{versionId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiCopilotVersionByVersionIdDiffByCompareVersionId", "GET", "/ai/copilot/version/{versionId}/diff/{compareVersionId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiCopilotVersionsBySessionId", "GET", "/ai/copilot/versions/{sessionId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiUsageOrgByOrgIdBreakdown", "GET", "/ai-usage/org/{orgId}/breakdown", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiUsageOrgByOrgIdExhaustionEvents", "GET", "/ai-usage/org/{orgId}/exhaustion-events", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiUsageOrgByOrgIdHistory", "GET", "/ai-usage/org/{orgId}/history", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiUsageOrgByOrgIdRecent", "GET", "/ai-usage/org/{orgId}/recent", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiUsageOrgByOrgIdRollups", "GET", "/ai-usage/org/{orgId}/rollups", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiUsageOrgByOrgIdSummary", "GET", "/ai-usage/org/{orgId}/summary", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAiUsageOrgByOrgIdVerament", "GET", "/ai-usage/org/{orgId}/verament", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAlertRulesProjectByProjectId", "GET", "/alert-rules/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAnnouncements", "GET", "/announcements", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAuditOrgByOrgId", "GET", "/audit/org/{orgId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAuditProjectByProjectId", "GET", "/audit/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAuthMe", "GET", "/auth/me", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAuthMeAdmin", "GET", "/auth/me/admin", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAuthMeContext", "GET", "/auth/me/context", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAuthMeLinkedAccounts", "GET", "/auth/me/linked-accounts", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAuthMfaStatus", "GET", "/auth/mfa/status", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAuthOauthProviders", "GET", "/auth/oauth/providers", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAuthSession", "GET", "/auth/session", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAuthSessions", "GET", "/auth/sessions", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetAuthTenantSession", "GET", "/auth/tenant/session", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingAddonsCatalog", "GET", "/billing/addons/catalog", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingCheckoutVerifyBySessionId", "GET", "/billing/checkout/verify/{sessionId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingCreditsPackages", "GET", "/billing/credits/packages", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingCreditsRates", "GET", "/billing/credits/rates", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingFoundersWall", "GET", "/billing/founders/wall", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingOrgByOrgIdAddons", "GET", "/billing/org/{orgId}/addons", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingOrgByOrgIdCardCheck", "GET", "/billing/org/{orgId}/card-check", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingOrgByOrgIdContacts", "GET", "/billing/org/{orgId}/contacts", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingOrgByOrgIdCostBreakdown", "GET", "/billing/org/{orgId}/cost-breakdown", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingOrgByOrgIdCreditsAutoTopup", "GET", "/billing/org/{orgId}/credits/auto-topup", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingOrgByOrgIdCreditsTransactions", "GET", "/billing/org/{orgId}/credits/transactions", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingOrgByOrgIdFounder", "GET", "/billing/org/{orgId}/founder", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingOrgByOrgIdHosting", "GET", "/billing/org/{orgId}/hosting", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingOrgByOrgIdInfrastructure", "GET", "/billing/org/{orgId}/infrastructure", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingOrgByOrgIdInvoices", "GET", "/billing/org/{orgId}/invoices", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingOrgByOrgIdOverages", "GET", "/billing/org/{orgId}/overages", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingOrgByOrgIdOveragesHistory", "GET", "/billing/org/{orgId}/overages/history", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingOrgByOrgIdSubscription", "GET", "/billing/org/{orgId}/subscription", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingOrgByOrgIdSummary", "GET", "/billing/org/{orgId}/summary", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingOrgByOrgIdTaxInfo", "GET", "/billing/org/{orgId}/tax-info", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingOrgByOrgIdUsage", "GET", "/billing/org/{orgId}/usage", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingOrgByOrgIdUsageAlerts", "GET", "/billing/org/{orgId}/usage-alerts", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingOrgByOrgIdUsageAlertsConfigured", "GET", "/billing/org/{orgId}/usage-alerts/configured", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingOrgByOrgIdUsageAlertsHistory", "GET", "/billing/org/{orgId}/usage-alerts/history", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingOrgByOrgIdUsageHistory", "GET", "/billing/org/{orgId}/usage/history", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingOrgByOrgIdUsageRealtime", "GET", "/billing/org/{orgId}/usage/realtime", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBillingPlans", "GET", "/billing/plans", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBootstrap", "GET", "/bootstrap", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBucketsByBucketId", "GET", "/buckets/{bucketId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBucketsByBucketIdFiles", "GET", "/buckets/{bucketId}/files", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetBucketsProjectByProjectId", "GET", "/buckets/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetCmsCareers", "GET", "/cms/careers", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetCmsFaqsByPageSlug", "GET", "/cms/faqs/{pageSlug}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetCmsPagesBySlug", "GET", "/cms/pages/{slug}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetCmsPartners", "GET", "/cms/partners", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetCmsTeam", "GET", "/cms/team", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetCmsTestimonials", "GET", "/cms/testimonials", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetCreditsOrgByOrgId", "GET", "/credits/org/{orgId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetCreditsOrgByOrgIdBalance", "GET", "/credits/org/{orgId}/balance", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetDatabaseConnectorByProjectIdTables", "GET", "/database/connector/{projectId}/tables", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetDatabaseExtensionsAvailable", "GET", "/database/extensions/available", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetDatabaseExtensionsProjectByProjectId", "GET", "/database/extensions/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetDatabaseTiers", "GET", "/database/tiers", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetDatabaseWrappersAvailable", "GET", "/database/wrappers/available", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetDatabaseWrappersProjectByProjectId", "GET", "/database/wrappers/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetDeploymentsByDeploymentId", "GET", "/deployments/{deploymentId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetDeploymentsByDeploymentIdSteps", "GET", "/deployments/{deploymentId}/steps", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetDeploymentsProjectByProjectId", "GET", "/deployments/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetDeploymentsProjectByProjectIdStats", "GET", "/deployments/project/{projectId}/stats", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetDeploymentsTokensProjectByProjectId", "GET", "/deployments/tokens/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetDocsAiSearch", "GET", "/docs/ai-search", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetDocsApiEndpoints", "GET", "/docs/api-endpoints", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetDocsApiEndpointsById", "GET", "/docs/api-endpoints/{id}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetDocsCategories", "GET", "/docs/categories", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetDocsChangelog", "GET", "/docs/changelog", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetDocsChangelogById", "GET", "/docs/changelog/{id}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetDocsExamples", "GET", "/docs/examples", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetDocsExamplesBySlug", "GET", "/docs/examples/{slug}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetDocsProjectByProjectIdQuickstart", "GET", "/docs/project/{projectId}/quickstart", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetDocsSdks", "GET", "/docs/sdks", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetDocsSdksByPlatform", "GET", "/docs/sdks/{platform}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetDocsSdksBySdkIdExamples", "GET", "/docs/sdks/{sdkId}/examples", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetDocsSearch", "GET", "/docs/search", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetDocsV2Pages", "GET", "/docs/v2/pages", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetDocsV2PagesBySlug", "GET", "/docs/v2/pages/{slug}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetEarlyByNumber", "GET", "/early/{number}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetEarlyWall", "GET", "/early/wall", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetEnterpriseOrgByOrgIdContract", "GET", "/enterprise/org/{orgId}/contract", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetEnterpriseOrgByOrgIdInvoices", "GET", "/enterprise/org/{orgId}/invoices", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetEnterpriseOrgByOrgIdOnboarding", "GET", "/enterprise/org/{orgId}/onboarding", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetEnterpriseOrgByOrgIdSpend", "GET", "/enterprise/org/{orgId}/spend", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetEnterpriseOrgByOrgIdUsage", "GET", "/enterprise/org/{orgId}/usage", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetEnterpriseOrgByOrgIdUsageHistory", "GET", "/enterprise/org/{orgId}/usage/history", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetEnterpriseOrgByOrgIdUsageProjects", "GET", "/enterprise/org/{orgId}/usage/projects", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetEnterprisePricing", "GET", "/enterprise/pricing", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetEnterpriseQuotesByQuoteId", "GET", "/enterprise/quotes/{quoteId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetEntitlementsOrgByOrgId", "GET", "/entitlements/org/{orgId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetFunctionsByFunctionId", "GET", "/functions/{functionId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetFunctionsByFunctionIdDeployStatus", "GET", "/functions/{functionId}/deploy-status", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetFunctionsByFunctionIdInvocations", "GET", "/functions/{functionId}/invocations", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetFunctionsByFunctionIdLogs", "GET", "/functions/{functionId}/logs", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetFunctionsByFunctionIdMetrics", "GET", "/functions/{functionId}/metrics", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetFunctionsByFunctionIdSchedule", "GET", "/functions/{functionId}/schedule", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetFunctionsByFunctionIdTriggers", "GET", "/functions/{functionId}/triggers", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetFunctionsInvocations", "GET", "/functions/invocations", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetFunctionsInvocationsFunctionByFunctionId", "GET", "/functions/invocations/function/{functionId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetFunctionsProjectByProjectId", "GET", "/functions/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetFunctionsProjectByProjectIdNameByFunctionName", "GET", "/functions/project/{projectId}/name/{functionName}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetFunctionsProjectByProjectIdSummary", "GET", "/functions/project/{projectId}/summary", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetFunctionsSchedulePreview", "GET", "/functions/schedule/preview", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetFunctionsSecretsProjectByProjectId", "GET", "/functions/secrets/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetGeneratedByTable", "GET", "/generated/{table}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetGeneratedByTableAggregate", "GET", "/generated/{table}/aggregate", "json", null, false, new string[] { "fn" }),
        new OperationDescriptor("GetGeneratedByTableById", "GET", "/generated/{table}/{id}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetGeneratedByTableSearch", "GET", "/generated/{table}/search", "json", null, false, new string[] { "q" }),
        new OperationDescriptor("GetGithubOauthAuthorize", "GET", "/github/oauth/authorize", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetIncidentsProjectByProjectId", "GET", "/incidents/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetInfrastructureSizes", "GET", "/infrastructure/sizes", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetIntegrationsAnalyticsProjectByProjectIdEvents", "GET", "/integrations/analytics/project/{projectId}/events", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetIntegrationsAnalyticsProjectByProjectIdStats", "GET", "/integrations/analytics/project/{projectId}/stats", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetIntegrationsDeliveriesEventByEventId", "GET", "/integrations/deliveries/event/{eventId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetIntegrationsDeliveriesProjectByProjectId", "GET", "/integrations/deliveries/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetIntegrationsDeliveriesProjectByProjectIdSummary", "GET", "/integrations/deliveries/project/{projectId}/summary", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetIntegrationsDeliveriesSubscriptionBySubscriptionId", "GET", "/integrations/deliveries/subscription/{subscriptionId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetIntegrationsDlqProjectByProjectId", "GET", "/integrations/dlq/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetIntegrationsEvents", "GET", "/integrations/events", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetIntegrationsSubscriptionsProjectByProjectId", "GET", "/integrations/subscriptions/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetJobsDlqProjectByProjectId", "GET", "/jobs/dlq/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetJobsWebhooksDeliveryByDeliveryId", "GET", "/jobs/webhooks/delivery/{deliveryId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetJobsWebhooksProjectByProjectId", "GET", "/jobs/webhooks/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetLogsProjectByProjectId", "GET", "/logs/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetLogsProjectByProjectIdFeed", "GET", "/logs/project/{projectId}/feed", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetMaintenance", "GET", "/maintenance", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetMcpConnections", "GET", "/mcp/connections", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetMcpOauthRequestsByRequestId", "GET", "/mcp/oauth/requests/{requestId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetMcpSession", "GET", "/mcp/session", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetMeBadges", "GET", "/me/badges", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetMeCreator", "GET", "/me/creator", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetMetricsOrgByOrgId", "GET", "/metrics/org/{orgId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetMetricsProjectByProjectId", "GET", "/metrics/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetMetricsProjectByProjectIdOverview", "GET", "/metrics/project/{projectId}/overview", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetMetricsProjectByProjectIdReport", "GET", "/metrics/project/{projectId}/report", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetMongodbByCollectionEstimatedCount", "GET", "/mongodb/{collection}/estimatedCount", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetMongodbByCollectionFindByIdById", "GET", "/mongodb/{collection}/findById/{id}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetMongodbByCollectionIndexes", "GET", "/mongodb/{collection}/indexes", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetMongodbCollections", "GET", "/mongodb/collections", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOauthOrgByOrgId", "GET", "/oauth/org/{orgId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOauthOrgByOrgIdProviderByProviderAuthorize", "GET", "/oauth/org/{orgId}/provider/{provider}/authorize", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOnboardingOrgByOrgId", "GET", "/onboarding/org/{orgId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOpenapiProjectByProjectId", "GET", "/openapi/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOpenapiYaml", "GET", "/openapi.yaml", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOrgs", "GET", "/orgs", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOrgsByOrgIdAccessMatrix", "GET", "/orgs/{orgId}/access-matrix", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOrgsByOrgIdBlueprintDefaults", "GET", "/orgs/{orgId}/blueprint-defaults", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOrgsByOrgIdChangeRequests", "GET", "/orgs/{orgId}/change-requests", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOrgsByOrgIdDataRegion", "GET", "/orgs/{orgId}/data-region", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOrgsByOrgIdIdentitySummary", "GET", "/orgs/{orgId}/identity/summary", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOrgsByOrgIdInvites", "GET", "/orgs/{orgId}/invites", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOrgsByOrgIdLeaveRequests", "GET", "/orgs/{orgId}/leave-requests", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOrgsByOrgIdLeaveRequestsMine", "GET", "/orgs/{orgId}/leave-requests/mine", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOrgsByOrgIdManagedDomains", "GET", "/orgs/{orgId}/managed-domains", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOrgsByOrgIdManagedSummary", "GET", "/orgs/{orgId}/managed-summary", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOrgsByOrgIdMembers", "GET", "/orgs/{orgId}/members", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOrgsByOrgIdMembership", "GET", "/orgs/{orgId}/membership", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOrgsByOrgIdProfile", "GET", "/orgs/{orgId}/profile", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOrgsByOrgIdRoles", "GET", "/orgs/{orgId}/roles", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOrgsByOrgIdSecurity", "GET", "/orgs/{orgId}/security", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOrgsByOrgIdSecurityPosture", "GET", "/orgs/{orgId}/security/posture", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOrgsByOrgIdSupportSlaReport", "GET", "/orgs/{orgId}/support/sla-report", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOrgsByOrgIdSupportSummary", "GET", "/orgs/{orgId}/support/summary", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOrgsByOrgIdSupportTerms", "GET", "/orgs/{orgId}/support/terms", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOrgsByOrgIdSupportTickets", "GET", "/orgs/{orgId}/support/tickets", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOrgsByOrgIdSupportTicketsByNumber", "GET", "/orgs/{orgId}/support/tickets/{number}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOrgsByOrgIdTransfers", "GET", "/orgs/{orgId}/transfers", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOrgsInvitesLookup", "GET", "/orgs/invites/lookup", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetOrgsTransfersPreview", "GET", "/orgs/transfers/preview", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetPlansByPlanId", "GET", "/plans/{planId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetPlansOrgByOrgId", "GET", "/plans/org/{orgId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetPricingAiFeatures", "GET", "/pricing/ai-features", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetPricingCompare", "GET", "/pricing/compare", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetPricingEnterprise", "GET", "/pricing/enterprise", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetPricingPlans", "GET", "/pricing/plans", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetPricingPlansByPlan", "GET", "/pricing/plans/{plan}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjects", "GET", "/projects", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByIdInsights", "GET", "/projects/{id}/insights", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectId", "GET", "/projects/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdApiKeys", "GET", "/projects/{projectId}/api-keys", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdAuthActivity", "GET", "/projects/{projectId}/auth/activity", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdAuthMe", "GET", "/projects/{projectId}/auth/me", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdAuthOauthApps", "GET", "/projects/{projectId}/auth/oauth-apps", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdAuthOauthProviders", "GET", "/projects/{projectId}/auth/oauth/providers", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdAuthSessions", "GET", "/projects/{projectId}/auth/sessions", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdAuthSettings", "GET", "/projects/{projectId}/auth/settings", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdBranches", "GET", "/projects/{projectId}/branches", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdBranchesByBranchNameUrl", "GET", "/projects/{projectId}/branches/{branchName}/url", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdDatabaseDedicated", "GET", "/projects/{projectId}/database/dedicated", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdDatabaseDedicatedConnection", "GET", "/projects/{projectId}/database/dedicated/connection", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdDatabaseDedicatedStatus", "GET", "/projects/{projectId}/database/dedicated/status", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdDeletionPreview", "GET", "/projects/{projectId}/deletion-preview", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdEnvVars", "GET", "/projects/{projectId}/env-vars", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdEnvironments", "GET", "/projects/{projectId}/environments", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdEnvironmentsByEnvIdDomainStatus", "GET", "/projects/{projectId}/environments/{envId}/domain-status", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdEnvironmentsByEnvIdDomainVerification", "GET", "/projects/{projectId}/environments/{envId}/domain-verification", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdEnvironmentsByEnvIdDomains", "GET", "/projects/{projectId}/environments/{envId}/domains", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdEnvironmentsPromotionOrder", "GET", "/projects/{projectId}/environments/promotion-order", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdFrontend", "GET", "/projects/{projectId}/frontend", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdGettingStarted", "GET", "/projects/{projectId}/getting-started", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdGithubBranches", "GET", "/projects/{projectId}/github/branches", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdGithubRepos", "GET", "/projects/{projectId}/github/repos", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdGithubStatus", "GET", "/projects/{projectId}/github/status", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdGithubTrackedRepos", "GET", "/projects/{projectId}/github/tracked-repos", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdInfrastructure", "GET", "/projects/{projectId}/infrastructure", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdInfrastructureByInstanceIdMetrics", "GET", "/projects/{projectId}/infrastructure/{instanceId}/metrics", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdInfrastructureByInstanceIdReplicas", "GET", "/projects/{projectId}/infrastructure/{instanceId}/replicas", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdInfrastructureByInstanceIdUpgradeOptions", "GET", "/projects/{projectId}/infrastructure/{instanceId}/upgrade-options", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdInfrastructureMigrationProgress", "GET", "/projects/{projectId}/infrastructure/migration/progress", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdInfrastructureMigrationStatus", "GET", "/projects/{projectId}/infrastructure/migration-status", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdInfrastructureRestores", "GET", "/projects/{projectId}/infrastructure/restores", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdMembers", "GET", "/projects/{projectId}/members", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdPromotions", "GET", "/projects/{projectId}/promotions", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdPromotionsDiff", "GET", "/projects/{projectId}/promotions/diff", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdRegion", "GET", "/projects/{projectId}/region", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdSecurityAdvisor", "GET", "/projects/{projectId}/security/advisor", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdSettings", "GET", "/projects/{projectId}/settings", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdSettingsAddons", "GET", "/projects/{projectId}/settings/addons", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdSettingsApi", "GET", "/projects/{projectId}/settings/api", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdSettingsCompute", "GET", "/projects/{projectId}/settings/compute", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdSettingsJwt", "GET", "/projects/{projectId}/settings/jwt", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdStorageSettings", "GET", "/projects/{projectId}/storage/settings", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdUsers", "GET", "/projects/{projectId}/users", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdUsersByUserId", "GET", "/projects/{projectId}/users/{userId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdUsersByUserIdSessions", "GET", "/projects/{projectId}/users/{userId}/sessions", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsByProjectIdUsersStats", "GET", "/projects/{projectId}/users/stats", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetProjectsSlugAvailable", "GET", "/projects/slug-available", "json", null, false, new string[] { "orgId", "slug" }),
        new OperationDescriptor("GetQuickstartProjectByProjectId", "GET", "/quickstart/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetQuickstartProjectByProjectIdJson", "GET", "/quickstart/project/{projectId}/json", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetRealtimeConnectionsProjectByProjectId", "GET", "/realtime/connections/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetRealtimeEventsProjectByProjectId", "GET", "/realtime/events/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetRealtimeStatsProjectByProjectId", "GET", "/realtime/stats/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetRealtimeStatusProjectByProjectId", "GET", "/realtime/status/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetRealtimeSubscriptionsProjectByProjectId", "GET", "/realtime/subscriptions/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetRefundsById", "GET", "/refunds/{id}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetRefundsOrgByOrgId", "GET", "/refunds/org/{orgId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetRegions", "GET", "/regions", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetRegionsAll", "GET", "/regions/all", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetRegionsByKey", "GET", "/regions/{key}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetRegionsByKeyMetrics", "GET", "/regions/{key}/metrics", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetRegionsHealth", "GET", "/regions/health", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetRlsPoliciesByProjectId", "GET", "/rls/policies/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetSchemaEngineByProjectIdChanges", "GET", "/schema-engine/{projectId}/changes", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetSchemaEngineEditorSessionsByProjectIdCapabilities", "GET", "/schema-engine/editor-sessions/{projectId}/capabilities", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetSchemaEngineIntrospectByProjectId", "GET", "/schema-engine/introspect/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetSchemaEngineMigrationsByProjectIdByMigrationIdDiff", "GET", "/schema-engine/migrations/{projectId}/{migrationId}/diff", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetSchemaEngineMigrationsProjectByProjectId", "GET", "/schema-engine/migrations/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetSchemaEngineSnapshotsProjectByProjectId", "GET", "/schema-engine/snapshots/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetSchemaEngineSnippetsByProjectId", "GET", "/schema-engine/snippets/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetSchemasProjectByProjectId", "GET", "/schemas/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetSecurityAuditByProjectId", "GET", "/security/audit/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetSecurityOverviewByProjectId", "GET", "/security/overview/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetSecurityVariablesProjectByProjectId", "GET", "/security/variables/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetServicesByServiceId", "GET", "/services/{serviceId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetServicesByServiceIdDeploymentsByDeploymentIdBuildLogs", "GET", "/services/{serviceId}/deployments/{deploymentId}/build-logs", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetServicesByServiceIdDeploymentsByDeploymentIdStatus", "GET", "/services/{serviceId}/deployments/{deploymentId}/status", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetServicesByServiceIdDomains", "GET", "/services/{serviceId}/domains", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetServicesByServiceIdGitConnect", "GET", "/services/{serviceId}/git/connect", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetServicesByServiceIdLogs", "GET", "/services/{serviceId}/logs", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetServicesByServiceIdStatus", "GET", "/services/{serviceId}/status", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetServicesProjectByProjectId", "GET", "/services/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetServicesProjectByProjectIdSummary", "GET", "/services/project/{projectId}/summary", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetSsoMePausedAccess", "GET", "/sso/me/paused-access", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetSsoOrgByOrgId", "GET", "/sso/org/{orgId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetSsoOrgByOrgIdConnectionsByConnectionIdBreakGlass", "GET", "/sso/org/{orgId}/connections/{connectionId}/break-glass", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetSsoOrgByOrgIdConnectionsByConnectionIdCertificates", "GET", "/sso/org/{orgId}/connections/{connectionId}/certificates", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetSsoOrgByOrgIdConnectionsByConnectionIdGroupMappings", "GET", "/sso/org/{orgId}/connections/{connectionId}/group-mappings", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetSsoOrgByOrgIdConnectionsByConnectionIdRequire", "GET", "/sso/org/{orgId}/connections/{connectionId}/require", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetSsoOrgByOrgIdConnectionsByConnectionIdScimReconciliation", "GET", "/sso/org/{orgId}/connections/{connectionId}/scim/reconciliation", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetSsoOrgByOrgIdConnectionsByConnectionIdScimTokens", "GET", "/sso/org/{orgId}/connections/{connectionId}/scim/tokens", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetSsoOrgByOrgIdOutsideMembers", "GET", "/sso/org/{orgId}/outside-members", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetSsoOrgByOrgIdOutsideMembersBlocked", "GET", "/sso/org/{orgId}/outside-members/blocked", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetSsoOrgByOrgIdSecurityContact", "GET", "/sso/org/{orgId}/security-contact", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetStatus", "GET", "/status", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetStatusAtom", "GET", "/status/atom", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetStatusIncidents", "GET", "/status/incidents", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetStatusRss", "GET", "/status/rss", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetStatusSubscribersCount", "GET", "/status/subscribers/count", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetStatusUnsubscribeByToken", "GET", "/status/unsubscribe/{token}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetStatusUptimeByComponentId", "GET", "/status/uptime/{componentId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetStorageBuckets", "GET", "/storage/buckets", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetStorageBucketsByBucketIdPolicies", "GET", "/storage/buckets/{bucketId}/policies", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetStorageDownload", "GET", "/storage/download", "binary", null, false, new string[] { "key" }),
        new OperationDescriptor("GetStorageFilesByBucketIdMetadata", "GET", "/storage/files/{bucketId}/metadata", "json", null, false, new string[] { "key" }),
        new OperationDescriptor("GetStorageMultipartListPending", "GET", "/storage/multipart/list-pending", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetStorageUsageProjectByProjectId", "GET", "/storage/usage/project/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetTemplates", "GET", "/templates", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetTemplatesBySlug", "GET", "/templates/{slug}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetTemplatesInstalls", "GET", "/templates/installs", "json", null, false, new string[] { "projectId" }),
        new OperationDescriptor("GetTenantBranding", "GET", "/tenant/branding", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetUsersMe", "GET", "/users/me", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetUsersMePreferences", "GET", "/users/me/preferences", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetV1DataByProjectIdByTable", "GET", "/v1/data/{projectId}/{table}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetV1DataByProjectIdByTableAggregate", "GET", "/v1/data/{projectId}/{table}/aggregate", "json", null, false, new string[] { "fn" }),
        new OperationDescriptor("GetV1DataByProjectIdByTableById", "GET", "/v1/data/{projectId}/{table}/{id}", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetV1DataByProjectIdByTableSearch", "GET", "/v1/data/{projectId}/{table}/search", "json", null, false, new string[] { "q" }),
        new OperationDescriptor("GetV1Health", "GET", "/v1/health", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetV1Project", "GET", "/v1/project", "json", null, false, new string[] {  }),
        new OperationDescriptor("GetWellKnownOauthAuthorizationServer", "GET", "/.well-known/oauth-authorization-server", "json", null, false, new string[] {  }),
        new OperationDescriptor("PatchAiCopilotSessionBySessionId", "PATCH", "/ai/copilot/session/{sessionId}", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchAuthMe", "PATCH", "/auth/me", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchBillingOrgByOrgIdAddonsByAddonId", "PATCH", "/billing/org/{orgId}/addons/{addonId}", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PatchBillingOrgByOrgIdContactsByContactId", "PATCH", "/billing/org/{orgId}/contacts/{contactId}", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchBillingOrgByOrgIdUsageAlertsByAlertId", "PATCH", "/billing/org/{orgId}/usage-alerts/{alertId}", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchDatabaseWrappersProjectByProjectIdByWrapperId", "PATCH", "/database/wrappers/project/{projectId}/{wrapperId}", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchEnterpriseOrgByOrgIdOnboarding", "PATCH", "/enterprise/org/{orgId}/onboarding", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchFunctionsByFunctionId", "PATCH", "/functions/{functionId}", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchFunctionsTriggersByTriggerId", "PATCH", "/functions/triggers/{triggerId}", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchGeneratedByTableBulk", "PATCH", "/generated/{table}/bulk", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchGeneratedByTableById", "PATCH", "/generated/{table}/{id}", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchIntegrationsSubscriptionsById", "PATCH", "/integrations/subscriptions/{id}", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchOauthOrgByOrgIdProviderByProvider", "PATCH", "/oauth/org/{orgId}/provider/{provider}", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchOrgsByOrgId", "PATCH", "/orgs/{orgId}", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchOrgsByOrgIdBlueprintDefaults", "PATCH", "/orgs/{orgId}/blueprint-defaults", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchOrgsByOrgIdDataRegion", "PATCH", "/orgs/{orgId}/data-region", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchOrgsByOrgIdMembersByUserIdRole", "PATCH", "/orgs/{orgId}/members/{userId}/role", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchOrgsByOrgIdMembersRoles", "PATCH", "/orgs/{orgId}/members/roles", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchOrgsByOrgIdProfile", "PATCH", "/orgs/{orgId}/profile", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PatchOrgsByOrgIdSecurity", "PATCH", "/orgs/{orgId}/security", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchProjectsByProjectId", "PATCH", "/projects/{projectId}", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchProjectsByProjectIdApiKeysByKeyId", "PATCH", "/projects/{projectId}/api-keys/{keyId}", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchProjectsByProjectIdAuthSettings", "PATCH", "/projects/{projectId}/auth/settings", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchProjectsByProjectIdEnvVarsByEnvVarId", "PATCH", "/projects/{projectId}/env-vars/{envVarId}", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PatchProjectsByProjectIdEnvironmentsByEnvId", "PATCH", "/projects/{projectId}/environments/{envId}", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PatchProjectsByProjectIdSettingsAddons", "PATCH", "/projects/{projectId}/settings/addons", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PatchProjectsByProjectIdSettingsApi", "PATCH", "/projects/{projectId}/settings/api", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PatchProjectsByProjectIdSettingsCompute", "PATCH", "/projects/{projectId}/settings/compute", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PatchProjectsByProjectIdSettingsJwt", "PATCH", "/projects/{projectId}/settings/jwt", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PatchProjectsByProjectIdStorageSettings", "PATCH", "/projects/{projectId}/storage/settings", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchProjectsByProjectIdUsersByUserId", "PATCH", "/projects/{projectId}/users/{userId}", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchRegionsByKey", "PATCH", "/regions/{key}", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PatchRlsPoliciesByPolicyId", "PATCH", "/rls/policies/{policyId}", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PatchSchemaEngineSnippetsByProjectIdBySnippetId", "PATCH", "/schema-engine/snippets/{projectId}/{snippetId}", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchServicesByServiceIdHostname", "PATCH", "/services/{serviceId}/hostname", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchServicesByServiceIdRuntimeClass", "PATCH", "/services/{serviceId}/runtime-class", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchSsoOrgByOrgIdConnectionsByConnectionId", "PATCH", "/sso/org/{orgId}/connections/{connectionId}", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PatchStorageFilesByBucketIdMetadata", "PATCH", "/storage/files/{bucketId}/metadata", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PatchUsersMe", "PATCH", "/users/me", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PatchUsersMePreferences", "PATCH", "/users/me/preferences", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PatchV1DataByProjectIdByTableBulk", "PATCH", "/v1/data/{projectId}/{table}/bulk", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PatchV1DataByProjectIdByTableById", "PATCH", "/v1/data/{projectId}/{table}/{id}", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAiCopilotAlertRuleSuggestion", "POST", "/ai/copilot/alert-rule-suggestion", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAiCopilotAlertRuleSuggestionEstimate", "POST", "/ai/copilot/alert-rule-suggestion/estimate", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAiCopilotChat", "POST", "/ai/copilot/chat", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAiCopilotChatStream", "POST", "/ai/copilot/chat/stream", "sse", null, false, new string[] {  }),
        new OperationDescriptor("PostAiCopilotExecute", "POST", "/ai/copilot/execute", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAiCopilotExecutionByExecutionIdPause", "POST", "/ai/copilot/execution/{executionId}/pause", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostAiCopilotExecutionByExecutionIdResume", "POST", "/ai/copilot/execution/{executionId}/resume", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAiCopilotExecutionByExecutionIdRollback", "POST", "/ai/copilot/execution/{executionId}/rollback", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAiCopilotExportByVersionId", "POST", "/ai/copilot/export/{versionId}", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostAiCopilotExportGithub", "POST", "/ai/copilot/export/github", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostAiCopilotFeedback", "POST", "/ai/copilot/feedback", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAiCopilotGenerationByManifestIdCancel", "POST", "/ai/copilot/generation/{manifestId}/cancel", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostAiCopilotGitBranch", "POST", "/ai/copilot/git/branch", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostAiCopilotGitClone", "POST", "/ai/copilot/git/clone", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostAiCopilotGitCommit", "POST", "/ai/copilot/git/commit", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostAiCopilotGitInit", "POST", "/ai/copilot/git/init", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostAiCopilotGitPull", "POST", "/ai/copilot/git/pull", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostAiCopilotGitPush", "POST", "/ai/copilot/git/push", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostAiCopilotGitWrite", "POST", "/ai/copilot/git/write", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostAiCopilotJob", "POST", "/ai/copilot/job", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAiCopilotJobByJobIdCancel", "POST", "/ai/copilot/job/{jobId}/cancel", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostAiCopilotJobByJobIdRetry", "POST", "/ai/copilot/job/{jobId}/retry", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostAiCopilotManifestByManifestIdPause", "POST", "/ai/copilot/manifest/{manifestId}/pause", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostAiCopilotMemoriesByMemoryIdPromote", "POST", "/ai/copilot/memories/{memoryId}/promote", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostAiCopilotRateByMessageId", "POST", "/ai/copilot/rate/{messageId}", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAiCopilotSessionBySessionIdArtifactBody", "POST", "/ai/copilot/session/{sessionId}/artifact-body", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAiCopilotSessionBySessionIdBrainstormStop", "POST", "/ai/copilot/session/{sessionId}/brainstorm/stop", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostAiCopilotSessionBySessionIdWorkspaceEnv", "POST", "/ai/copilot/session/{sessionId}/workspace/env", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostAiCopilotSessionBySessionIdWorkspaceFix", "POST", "/ai/copilot/session/{sessionId}/workspace/fix", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAiCopilotSessionBySessionIdWorkspaceHeartbeat", "POST", "/ai/copilot/session/{sessionId}/workspace/heartbeat", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostAiCopilotSessionBySessionIdWorkspaceInstall", "POST", "/ai/copilot/session/{sessionId}/workspace/install", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostAiCopilotSessionBySessionIdWorkspacePrepare", "POST", "/ai/copilot/session/{sessionId}/workspace/prepare", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAiCopilotSessionBySessionIdWorkspaceRelease", "POST", "/ai/copilot/session/{sessionId}/workspace/release", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostAiCopilotSessionBySessionIdWorkspaceRepairsApply", "POST", "/ai/copilot/session/{sessionId}/workspace/repairs/apply", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostAiCopilotSessionBySessionIdWorkspaceRestore", "POST", "/ai/copilot/session/{sessionId}/workspace/restore", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAiCopilotSessionBySessionIdWorkspaceRun", "POST", "/ai/copilot/session/{sessionId}/workspace/run", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostAiCopilotSessionBySessionIdWorkspaceStop", "POST", "/ai/copilot/session/{sessionId}/workspace/stop", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostAiCopilotSessions", "POST", "/ai/copilot/sessions", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAiCopilotTableFilters", "POST", "/ai/copilot/table-filters", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAiCopilotTableFiltersEstimate", "POST", "/ai/copilot/table-filters/estimate", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAiCopilotTrainingConsentBySessionId", "POST", "/ai/copilot/training-consent/{sessionId}", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAlertRulesProjectByProjectId", "POST", "/alert-rules/project/{projectId}", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostAuthAccountSetup", "POST", "/auth/account-setup", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostAuthAccountSetupCheck", "POST", "/auth/account-setup/check", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostAuthCliAuthorize", "POST", "/auth/cli/authorize", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostAuthCliCallback", "POST", "/auth/cli/callback", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAuthCliDeny", "POST", "/auth/cli/deny", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAuthCliLogin", "POST", "/auth/cli/login", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAuthCliRequestsCheck", "POST", "/auth/cli/requests/check", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAuthCliToken", "POST", "/auth/cli/token", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAuthForgotPassword", "POST", "/auth/forgot-password", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAuthLogin", "POST", "/auth/login", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAuthLogout", "POST", "/auth/logout", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostAuthLogoutAll", "POST", "/auth/logout-all", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostAuthMeLinkedAccountsByProviderStart", "POST", "/auth/me/linked-accounts/{provider}/start", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostAuthMfaDisable", "POST", "/auth/mfa/disable", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostAuthMfaEnrollConfirm", "POST", "/auth/mfa/enroll-confirm", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostAuthMfaEnrollStart", "POST", "/auth/mfa/enroll-start", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostAuthMfaRegenerateCodes", "POST", "/auth/mfa/regenerate-codes", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostAuthMfaVerify", "POST", "/auth/mfa/verify", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostAuthReauthenticate", "POST", "/auth/reauthenticate", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAuthRefresh", "POST", "/auth/refresh", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostAuthResetPassword", "POST", "/auth/reset-password", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAuthResetPasswordCheck", "POST", "/auth/reset-password/check", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAuthSessionDevice", "POST", "/auth/session/device", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAuthSessionToken", "POST", "/auth/session/token", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostAuthSignup", "POST", "/auth/signup", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAuthSsoRestart", "POST", "/auth/sso/restart", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostAuthTenantHandoff", "POST", "/auth/tenant/handoff", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAuthTenantLogin", "POST", "/auth/tenant/login", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAuthTenantLogout", "POST", "/auth/tenant/logout", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostAuthTenantMfaVerify", "POST", "/auth/tenant/mfa/verify", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAuthTenantRefresh", "POST", "/auth/tenant/refresh", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostAuthTenantSsoStart", "POST", "/auth/tenant/sso/start", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAuthVerifyEmailConfirm", "POST", "/auth/verify-email/confirm", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAuthVerifyEmailResend", "POST", "/auth/verify-email/resend", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostAuthVerifyEmailSend", "POST", "/auth/verify-email/send", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostBillingCheckout", "POST", "/billing/checkout", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostBillingEnterpriseInquiry", "POST", "/billing/enterprise/inquiry", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostBillingHostingCheckout", "POST", "/billing/hosting/checkout", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostBillingOrgByOrgIdAddons", "POST", "/billing/org/{orgId}/addons", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostBillingOrgByOrgIdAddonsByAddonIdPreview", "POST", "/billing/org/{orgId}/addons/{addonId}/preview", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostBillingOrgByOrgIdAddonsPreview", "POST", "/billing/org/{orgId}/addons/preview", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostBillingOrgByOrgIdCancel", "POST", "/billing/org/{orgId}/cancel", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostBillingOrgByOrgIdCardCheckConfirm", "POST", "/billing/org/{orgId}/card-check/confirm", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostBillingOrgByOrgIdCardCheckSession", "POST", "/billing/org/{orgId}/card-check/session", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostBillingOrgByOrgIdChangePlan", "POST", "/billing/org/{orgId}/change-plan", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostBillingOrgByOrgIdChangePlanPreview", "POST", "/billing/org/{orgId}/change-plan/preview", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostBillingOrgByOrgIdContacts", "POST", "/billing/org/{orgId}/contacts", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostBillingOrgByOrgIdCreditsPurchase", "POST", "/billing/org/{orgId}/credits/purchase", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostBillingOrgByOrgIdPause", "POST", "/billing/org/{orgId}/pause", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostBillingOrgByOrgIdPortal", "POST", "/billing/org/{orgId}/portal", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostBillingOrgByOrgIdReactivate", "POST", "/billing/org/{orgId}/reactivate", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostBillingOrgByOrgIdResume", "POST", "/billing/org/{orgId}/resume", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostBillingOrgByOrgIdUsageAlerts", "POST", "/billing/org/{orgId}/usage-alerts", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostBillingPromoCodesValidate", "POST", "/billing/promo-codes/validate", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostBillingRedeemPromo", "POST", "/billing/redeem-promo", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostBillingWebhook", "POST", "/billing/webhook", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostBucketsByBucketIdSignedUrl", "POST", "/buckets/{bucketId}/signed-url", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostBucketsByBucketIdUpload", "POST", "/buckets/{bucketId}/upload", "json", "binary", true, new string[] { "key" }),
        new OperationDescriptor("PostBucketsByBucketIdUploadUrl", "POST", "/buckets/{bucketId}/upload-url", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostContact", "POST", "/contact", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostDatabaseConnectorByProjectIdQuery", "POST", "/database/connector/{projectId}/query", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostDatabaseConnectorByProjectIdTest", "POST", "/database/connector/{projectId}/test", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostDatabaseExtensionsProjectByProjectIdInstall", "POST", "/database/extensions/project/{projectId}/install", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostDatabaseWrappersProjectByProjectIdInstall", "POST", "/database/wrappers/project/{projectId}/install", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostDeploymentsByDeploymentIdRollback", "POST", "/deployments/{deploymentId}/rollback", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostDeploymentsPromote", "POST", "/deployments/promote", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostDeploymentsTokens", "POST", "/deployments/tokens", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostDeploymentsTokensByTokenIdRevoke", "POST", "/deployments/tokens/{tokenId}/revoke", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostDeploymentsTrigger", "POST", "/deployments/trigger", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostDocsFeedback", "POST", "/docs/feedback", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostDocsSearchClick", "POST", "/docs/search-click", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostEnterpriseInquire", "POST", "/enterprise/inquire", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostEnterpriseQuotesByQuoteIdAccept", "POST", "/enterprise/quotes/{quoteId}/accept", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostEntitlementsOrgByOrgIdCheck", "POST", "/entitlements/org/{orgId}/check", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostFunctions", "POST", "/functions", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostFunctionsByFunctionIdOrNameInvoke", "POST", "/functions/{functionIdOrName}/invoke", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostFunctionsByFunctionIdTriggers", "POST", "/functions/{functionId}/triggers", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostFunctionsSecrets", "POST", "/functions/secrets", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostGeneratedByTable", "POST", "/generated/{table}", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostGeneratedByTableBulk", "POST", "/generated/{table}/bulk", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostGeneratedByTableQuery", "POST", "/generated/{table}/query", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostIncidents", "POST", "/incidents", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostIncidentsBulk", "POST", "/incidents/bulk", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostIncidentsByIncidentIdAck", "POST", "/incidents/{incidentId}/ack", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostIncidentsByIncidentIdResolve", "POST", "/incidents/{incidentId}/resolve", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostInfrastructurePollStatus", "POST", "/infrastructure/poll-status", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostIntegrationsDeliveriesByDeliveryIdRetry", "POST", "/integrations/deliveries/{deliveryId}/retry", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostIntegrationsSubscriptions", "POST", "/integrations/subscriptions", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostIntegrationsSubscriptionsByIdTest", "POST", "/integrations/subscriptions/{id}/test", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostMcpAudit", "POST", "/mcp/audit", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostMcpOauthRegister", "POST", "/mcp/oauth/register", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostMcpOauthRequestsByRequestIdApprove", "POST", "/mcp/oauth/requests/{requestId}/approve", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostMcpOauthRequestsByRequestIdDeny", "POST", "/mcp/oauth/requests/{requestId}/deny", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostMcpOauthRevoke", "POST", "/mcp/oauth/revoke", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostMcpOauthToken", "POST", "/mcp/oauth/token", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostMeEarlyWelcomeSeen", "POST", "/me/early/welcome-seen", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostMongodbByCollectionAggregate", "POST", "/mongodb/{collection}/aggregate", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostMongodbByCollectionAggregateCursor", "POST", "/mongodb/{collection}/aggregate/cursor", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostMongodbByCollectionBulkWrite", "POST", "/mongodb/{collection}/bulkWrite", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostMongodbByCollectionCount", "POST", "/mongodb/{collection}/count", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostMongodbByCollectionCursorByCursorIdClose", "POST", "/mongodb/{collection}/cursor/{cursorId}/close", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostMongodbByCollectionCursorByCursorIdNext", "POST", "/mongodb/{collection}/cursor/{cursorId}/next", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostMongodbByCollectionDeleteMany", "POST", "/mongodb/{collection}/deleteMany", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostMongodbByCollectionDeleteOne", "POST", "/mongodb/{collection}/deleteOne", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostMongodbByCollectionDistinct", "POST", "/mongodb/{collection}/distinct", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostMongodbByCollectionFind", "POST", "/mongodb/{collection}/find", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostMongodbByCollectionFindCursor", "POST", "/mongodb/{collection}/find/cursor", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostMongodbByCollectionFindOne", "POST", "/mongodb/{collection}/findOne", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostMongodbByCollectionFindOneAndDelete", "POST", "/mongodb/{collection}/findOneAndDelete", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostMongodbByCollectionFindOneAndReplace", "POST", "/mongodb/{collection}/findOneAndReplace", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostMongodbByCollectionFindOneAndUpdate", "POST", "/mongodb/{collection}/findOneAndUpdate", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostMongodbByCollectionIndexes", "POST", "/mongodb/{collection}/indexes", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostMongodbByCollectionInsertMany", "POST", "/mongodb/{collection}/insertMany", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostMongodbByCollectionInsertOne", "POST", "/mongodb/{collection}/insertOne", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostMongodbByCollectionReplaceOne", "POST", "/mongodb/{collection}/replaceOne", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostMongodbByCollectionUpdateMany", "POST", "/mongodb/{collection}/updateMany", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostMongodbByCollectionUpdateOne", "POST", "/mongodb/{collection}/updateOne", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostMongodbCollections", "POST", "/mongodb/collections", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostMongodbCollectionsByNameRename", "POST", "/mongodb/collections/{name}/rename", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostMongodbCommand", "POST", "/mongodb/command", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostOauthCallback", "POST", "/oauth/callback", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostOauthOrgByOrgIdConfigure", "POST", "/oauth/org/{orgId}/configure", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostOauthOrgByOrgIdProviderByProviderRefresh", "POST", "/oauth/org/{orgId}/provider/{provider}/refresh", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostOnboardingOrgByOrgIdAutoSetup", "POST", "/onboarding/org/{orgId}/auto-setup", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostOnboardingOrgByOrgIdCompleteStep", "POST", "/onboarding/org/{orgId}/complete-step", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostOrgs", "POST", "/orgs", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostOrgsByOrgIdChangeRequests", "POST", "/orgs/{orgId}/change-requests", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostOrgsByOrgIdInvitesByInviteIdResend", "POST", "/orgs/{orgId}/invites/{inviteId}/resend", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostOrgsByOrgIdLeaveRequests", "POST", "/orgs/{orgId}/leave-requests", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostOrgsByOrgIdLeaveRequestsByRequestIdApprove", "POST", "/orgs/{orgId}/leave-requests/{requestId}/approve", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostOrgsByOrgIdLeaveRequestsByRequestIdDecline", "POST", "/orgs/{orgId}/leave-requests/{requestId}/decline", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostOrgsByOrgIdMembersInvite", "POST", "/orgs/{orgId}/members/invite", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostOrgsByOrgIdSupportTickets", "POST", "/orgs/{orgId}/support/tickets", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostOrgsByOrgIdSupportTicketsByNumberMessages", "POST", "/orgs/{orgId}/support/tickets/{number}/messages", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostOrgsByOrgIdSupportTicketsByNumberReopen", "POST", "/orgs/{orgId}/support/tickets/{number}/reopen", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostOrgsByOrgIdSupportTicketsByNumberResolve", "POST", "/orgs/{orgId}/support/tickets/{number}/resolve", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostOrgsByOrgIdTransfer", "POST", "/orgs/{orgId}/transfer", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostOrgsByOrgIdTransfersByIdResend", "POST", "/orgs/{orgId}/transfers/{id}/resend", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostOrgsFirst", "POST", "/orgs/first", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostOrgsInvitesAccept", "POST", "/orgs/invites/accept", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostOrgsInvitesDecline", "POST", "/orgs/invites/decline", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostOrgsTransfersAccept", "POST", "/orgs/transfers/accept", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostOrgsTransfersDecline", "POST", "/orgs/transfers/decline", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostPlansApply", "POST", "/plans/apply", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostPlansSave", "POST", "/plans/save", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostProjects", "POST", "/projects", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdApiKeys", "POST", "/projects/{projectId}/api-keys", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdApiKeysByKeyIdReveal", "POST", "/projects/{projectId}/api-keys/{keyId}/reveal", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdApiKeysByKeyIdRevoke", "POST", "/projects/{projectId}/api-keys/{keyId}/revoke", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdApiKeysByKeyIdRotate", "POST", "/projects/{projectId}/api-keys/{keyId}/rotate", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdApiKeysSplit", "POST", "/projects/{projectId}/api-keys/split", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdAuthForgotPassword", "POST", "/projects/{projectId}/auth/forgot-password", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdAuthLogin", "POST", "/projects/{projectId}/auth/login", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdAuthLogout", "POST", "/projects/{projectId}/auth/logout", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdAuthMagicSend", "POST", "/projects/{projectId}/auth/magic/send", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdAuthMfaDisable", "POST", "/projects/{projectId}/auth/mfa/disable", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdAuthMfaEnrollConfirm", "POST", "/projects/{projectId}/auth/mfa/enroll-confirm", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdAuthMfaEnrollStart", "POST", "/projects/{projectId}/auth/mfa/enroll-start", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdAuthMfaRegenerateCodes", "POST", "/projects/{projectId}/auth/mfa/regenerate-codes", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdAuthMfaVerify", "POST", "/projects/{projectId}/auth/mfa/verify", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdAuthOauthByProviderStart", "POST", "/projects/{projectId}/auth/oauth/{provider}/start", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdAuthOauthToken", "POST", "/projects/{projectId}/auth/oauth/token", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdAuthRefresh", "POST", "/projects/{projectId}/auth/refresh", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdAuthResetPassword", "POST", "/projects/{projectId}/auth/reset-password", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdAuthSignup", "POST", "/projects/{projectId}/auth/signup", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdAuthSyncUsers", "POST", "/projects/{projectId}/auth/sync-users", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdAuthVerifyEmailConfirm", "POST", "/projects/{projectId}/auth/verify-email/confirm", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdAuthVerifyEmailSend", "POST", "/projects/{projectId}/auth/verify-email/send", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdBranches", "POST", "/projects/{projectId}/branches", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdDatabaseDedicated", "POST", "/projects/{projectId}/database/dedicated", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdDatabaseDedicatedRestart", "POST", "/projects/{projectId}/database/dedicated/restart", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdDbReset", "POST", "/projects/{projectId}/db/reset", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdEnvVars", "POST", "/projects/{projectId}/env-vars", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdEnvironments", "POST", "/projects/{projectId}/environments", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdEnvironmentsBackfillUrls", "POST", "/projects/{projectId}/environments/backfill-urls", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdEnvironmentsBootstrap", "POST", "/projects/{projectId}/environments/bootstrap", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdEnvironmentsByEnvIdDomainsByDomainIdVerify", "POST", "/projects/{projectId}/environments/{envId}/domains/{domainId}/verify", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdEnvironmentsByEnvIdProvisionSsl", "POST", "/projects/{projectId}/environments/{envId}/provision-ssl", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdEnvironmentsByEnvIdVerifyCname", "POST", "/projects/{projectId}/environments/{envId}/verify-cname", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdEnvironmentsByEnvIdVerifyDomain", "POST", "/projects/{projectId}/environments/{envId}/verify-domain", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdGithubBranch", "POST", "/projects/{projectId}/github/branch", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdGithubConnect", "POST", "/projects/{projectId}/github/connect", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdGithubPull", "POST", "/projects/{projectId}/github/pull", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdGithubPush", "POST", "/projects/{projectId}/github/push", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdInfrastructureByInstanceIdMigrateNow", "POST", "/projects/{projectId}/infrastructure/{instanceId}/migrate-now", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdInfrastructureByInstanceIdReplica", "POST", "/projects/{projectId}/infrastructure/{instanceId}/replica", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdInfrastructureByInstanceIdReplicaPreview", "POST", "/projects/{projectId}/infrastructure/{instanceId}/replica-preview", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdInfrastructureByInstanceIdResize", "POST", "/projects/{projectId}/infrastructure/{instanceId}/resize", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdInfrastructureByInstanceIdResizeCustom", "POST", "/projects/{projectId}/infrastructure/{instanceId}/resize-custom", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdInfrastructureByInstanceIdStart", "POST", "/projects/{projectId}/infrastructure/{instanceId}/start", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdInfrastructureByInstanceIdStop", "POST", "/projects/{projectId}/infrastructure/{instanceId}/stop", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdInfrastructureByInstanceIdSwitch", "POST", "/projects/{projectId}/infrastructure/{instanceId}/switch", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdInfrastructureIncludedRetry", "POST", "/projects/{projectId}/infrastructure/included/retry", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdInfrastructureMigrationRetry", "POST", "/projects/{projectId}/infrastructure/migration/retry", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdInfrastructureMigrationRollback", "POST", "/projects/{projectId}/infrastructure/migration/rollback", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdInfrastructureProvision", "POST", "/projects/{projectId}/infrastructure/provision", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdInfrastructureProvisionCustom", "POST", "/projects/{projectId}/infrastructure/provision-custom", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdInfrastructureProvisionPreview", "POST", "/projects/{projectId}/infrastructure/provision-preview", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdInfrastructureRestoresPreview", "POST", "/projects/{projectId}/infrastructure/restores/preview", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdMembers", "POST", "/projects/{projectId}/members", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdPromotions", "POST", "/projects/{projectId}/promotions", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdRegion", "POST", "/projects/{projectId}/region", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdSettingsJwtRotate", "POST", "/projects/{projectId}/settings/jwt/rotate", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdUsers", "POST", "/projects/{projectId}/users", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdUsersByUserIdBan", "POST", "/projects/{projectId}/users/{userId}/ban", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdUsersByUserIdSendMagicLink", "POST", "/projects/{projectId}/users/{userId}/send-magic-link", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdUsersByUserIdSessionsRevokeAll", "POST", "/projects/{projectId}/users/{userId}/sessions/revoke-all", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostProjectsByProjectIdUsersByUserIdUnban", "POST", "/projects/{projectId}/users/{userId}/unban", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostRealtimeConsoleToken", "POST", "/realtime/console-token", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostRealtimeEnableAll", "POST", "/realtime/enable-all", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostRealtimeInstall", "POST", "/realtime/install", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostRealtimeToken", "POST", "/realtime/token", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostRealtimeUninstall", "POST", "/realtime/uninstall", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostRegions", "POST", "/regions", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostRegionsHealthCheck", "POST", "/regions/health/check", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostRlsPoliciesByPolicyIdToggle", "POST", "/rls/policies/{policyId}/toggle", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostRlsPoliciesByProjectId", "POST", "/rls/policies/{projectId}", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostSchemaEngineAnalyzeByProjectId", "POST", "/schema-engine/analyze/{projectId}", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostSchemaEngineApply", "POST", "/schema-engine/apply", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostSchemaEngineEditorSessionsByProjectId", "POST", "/schema-engine/editor-sessions/{projectId}", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostSchemaEngineEditorSessionsByProjectIdClose", "POST", "/schema-engine/editor-sessions/{projectId}/close", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostSchemaEngineMigrationsByProjectIdByMigrationIdRollback", "POST", "/schema-engine/migrations/{projectId}/{migrationId}/rollback", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostSchemaEnginePreview", "POST", "/schema-engine/preview", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostSchemaEnginePushByProjectId", "POST", "/schema-engine/push/{projectId}", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostSchemaEngineQueryByProjectId", "POST", "/schema-engine/query/{projectId}", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostSchemaEngineSnippetsByProjectId", "POST", "/schema-engine/snippets/{projectId}", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostSchemas", "POST", "/schemas", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostServices", "POST", "/services", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostServicesByServiceIdDeploy", "POST", "/services/{serviceId}/deploy", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostServicesByServiceIdDomains", "POST", "/services/{serviceId}/domains", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostServicesByServiceIdDomainsByDomainIdVerify", "POST", "/services/{serviceId}/domains/{domainId}/verify", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostServicesByServiceIdGitConnect", "POST", "/services/{serviceId}/git/connect", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostServicesByServiceIdPromote", "POST", "/services/{serviceId}/promote", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostServicesByServiceIdRollback", "POST", "/services/{serviceId}/rollback", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostServicesByServiceIdStop", "POST", "/services/{serviceId}/stop", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostSsoOrgByOrgIdConfigure", "POST", "/sso/org/{orgId}/configure", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostSsoOrgByOrgIdConnectionsByConnectionIdCertificates", "POST", "/sso/org/{orgId}/connections/{connectionId}/certificates", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostSsoOrgByOrgIdConnectionsByConnectionIdCertificatesByCertIdPromote", "POST", "/sso/org/{orgId}/connections/{connectionId}/certificates/{certId}/promote", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostSsoOrgByOrgIdConnectionsByConnectionIdDisable", "POST", "/sso/org/{orgId}/connections/{connectionId}/disable", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostSsoOrgByOrgIdConnectionsByConnectionIdEnable", "POST", "/sso/org/{orgId}/connections/{connectionId}/enable", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostSsoOrgByOrgIdConnectionsByConnectionIdMetadataImport", "POST", "/sso/org/{orgId}/connections/{connectionId}/metadata/import", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostSsoOrgByOrgIdConnectionsByConnectionIdReleaseAccount", "POST", "/sso/org/{orgId}/connections/{connectionId}/release-account", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostSsoOrgByOrgIdConnectionsByConnectionIdScimTokens", "POST", "/sso/org/{orgId}/connections/{connectionId}/scim/tokens", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostSsoOrgByOrgIdConnectionsByConnectionIdTest", "POST", "/sso/org/{orgId}/connections/{connectionId}/test", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostSsoOrgByOrgIdConnectionsByConnectionIdVerifyDomain", "POST", "/sso/org/{orgId}/connections/{connectionId}/verify-domain", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostSsoOrgByOrgIdOutsideMembersBlockedByUserIdRestore", "POST", "/sso/org/{orgId}/outside-members/blocked/{userId}/restore", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostStatusSubscribe", "POST", "/status/subscribe", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostStorageBuckets", "POST", "/storage/buckets", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostStorageBucketsByBucketIdPolicies", "POST", "/storage/buckets/{bucketId}/policies", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostStorageBucketsByBucketIdPoliciesByPolicyIdToggle", "POST", "/storage/buckets/{bucketId}/policies/{policyId}/toggle", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostStorageBucketsByBucketIdPoliciesSimulate", "POST", "/storage/buckets/{bucketId}/policies/simulate", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostStorageDownloadUrl", "POST", "/storage/download-url", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostStorageFilesCopy", "POST", "/storage/files/copy", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostStorageFilesDeleteBatch", "POST", "/storage/files/delete-batch", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostStorageFilesMove", "POST", "/storage/files/move", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostStorageMultipartByUploadIdAbort", "POST", "/storage/multipart/{uploadId}/abort", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostStorageMultipartByUploadIdComplete", "POST", "/storage/multipart/{uploadId}/complete", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostStorageMultipartByUploadIdPartUrl", "POST", "/storage/multipart/{uploadId}/part-url", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostStorageMultipartCreate", "POST", "/storage/multipart/create", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostStorageMultipartResume", "POST", "/storage/multipart/resume", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostStorageUpload", "POST", "/storage/upload", "json", null, false, new string[] { "key" }),
        new OperationDescriptor("PostStorageUploadBase64", "POST", "/storage/upload-base64", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostStorageUploadFromUrl", "POST", "/storage/upload-from-url", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostStorageUploadUrl", "POST", "/storage/upload-url", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostTemplates", "POST", "/templates", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostTemplatesCreateProject", "POST", "/templates/create-project", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostTemplatesFromProject", "POST", "/templates/from-project", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostTemplatesFromProjectPreview", "POST", "/templates/from-project/preview", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostTemplatesInstallApply", "POST", "/templates/install/apply", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostTemplatesInstallByInstallIdRollback", "POST", "/templates/install/{installId}/rollback", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostTemplatesInstallPreview", "POST", "/templates/install/preview", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostUsersMeChangePassword", "POST", "/users/me/change-password", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PostUsersMeRequestAccountDelete", "POST", "/users/me/request-account-delete", "json", null, false, new string[] {  }),
        new OperationDescriptor("PostV1DataByProjectIdByTable", "POST", "/v1/data/{projectId}/{table}", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostV1DataByProjectIdByTableBulk", "POST", "/v1/data/{projectId}/{table}/bulk", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostV1DataByProjectIdByTableQuery", "POST", "/v1/data/{projectId}/{table}/query", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PostWebhooksGithub", "POST", "/webhooks/github", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PutAiCopilotSessionBySessionIdEditorFiles", "PUT", "/ai/copilot/session/{sessionId}/editor-files", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PutAlertRulesByRuleId", "PUT", "/alert-rules/{ruleId}", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PutBillingOrgByOrgIdCreditsAutoTopup", "PUT", "/billing/org/{orgId}/credits/auto-topup", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PutBillingOrgByOrgIdFounderWall", "PUT", "/billing/org/{orgId}/founder/wall", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PutBillingOrgByOrgIdTaxInfo", "PUT", "/billing/org/{orgId}/tax-info", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PutBucketsByBucketId", "PUT", "/buckets/{bucketId}", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PutFunctionsByFunctionIdSchedule", "PUT", "/functions/{functionId}/schedule", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PutFunctionsByFunctionIdSource", "PUT", "/functions/{functionId}/source", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PutFunctionsSecretsBySecretId", "PUT", "/functions/secrets/{secretId}", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PutMeConsoleLook", "PUT", "/me/console-look", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PutMeEarlyWall", "PUT", "/me/early/wall", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PutProjectsByProjectIdAuthOauthAppsByProvider", "PUT", "/projects/{projectId}/auth/oauth-apps/{provider}", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PutProjectsByProjectIdEnvironmentsPromotionOrder", "PUT", "/projects/{projectId}/environments/promotion-order", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PutProjectsByProjectIdFrontend", "PUT", "/projects/{projectId}/frontend", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PutProjectsByProjectIdGettingStartedHidden", "PUT", "/projects/{projectId}/getting-started/hidden", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PutProjectsByProjectIdMembers", "PUT", "/projects/{projectId}/members", "json", "json", true, new string[] {  }),
        new OperationDescriptor("PutProjectsByProjectIdMembersByUserId", "PUT", "/projects/{projectId}/members/{userId}", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PutSsoOrgByOrgIdConnectionsByConnectionIdBreakGlass", "PUT", "/sso/org/{orgId}/connections/{connectionId}/break-glass", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PutSsoOrgByOrgIdConnectionsByConnectionIdGroupMappings", "PUT", "/sso/org/{orgId}/connections/{connectionId}/group-mappings", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PutSsoOrgByOrgIdConnectionsByConnectionIdRequire", "PUT", "/sso/org/{orgId}/connections/{connectionId}/require", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PutSsoOrgByOrgIdOutsideMembersAllow", "PUT", "/sso/org/{orgId}/outside-members/allow", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PutSsoOrgByOrgIdOutsideMembersPolicy", "PUT", "/sso/org/{orgId}/outside-members/policy", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PutSsoOrgByOrgIdSecurityContact", "PUT", "/sso/org/{orgId}/security-contact", "json", "json", false, new string[] {  }),
        new OperationDescriptor("PutStorageBucketsByBucketIdPoliciesByPolicyId", "PUT", "/storage/buckets/{bucketId}/policies/{policyId}", "json", "json", false, new string[] {  }),
    });

    /// <summary>Gets omitted routes and their reasons, including platform staff operations and unsupported success contracts.</summary>
    public static IReadOnlyList<string> Ungenerated { get; } = System.Array.AsReadOnly(new string[]
    {
        "GET /admin/admins: platform staff only",
        "POST /admin/admins: platform staff only",
        "DELETE /admin/admins/{id}: platform staff only",
        "PUT /admin/admins/{id}: platform staff only",
        "GET /admin/ai-workspace/overview: platform staff only",
        "GET /admin/ai-workspace/sessions: platform staff only",
        "DELETE /admin/ai-workspace/sessions/{sessionId}: platform staff only",
        "GET /admin/ai-workspace/sessions/{sessionId}: platform staff only",
        "GET /admin/ai/backends: platform staff only",
        "DELETE /admin/ai/backends/{backendId}: platform staff only",
        "GET /admin/ai/backends/{backendId}: platform staff only",
        "GET /admin/ai/context-snapshots: platform staff only",
        "DELETE /admin/ai/context-snapshots/{snapshotId}: platform staff only",
        "POST /admin/ai/context-snapshots/{snapshotId}/invalidate: platform staff only",
        "GET /admin/ai/models: platform staff only",
        "POST /admin/ai/models: platform staff only",
        "DELETE /admin/ai/models/{modelId}: platform staff only",
        "GET /admin/ai/models/{modelId}: platform staff only",
        "PATCH /admin/ai/models/{modelId}: platform staff only",
        "POST /admin/ai/models/{modelId}/toggle: platform staff only",
        "GET /admin/ai/prompt-templates: platform staff only",
        "POST /admin/ai/prompt-templates: platform staff only",
        "DELETE /admin/ai/prompt-templates/{templateId}: platform staff only",
        "PATCH /admin/ai/prompt-templates/{templateId}: platform staff only",
        "GET /admin/ai/workspace/sessions: platform staff only",
        "DELETE /admin/ai/workspace/sessions/{sessionId}: platform staff only",
        "GET /admin/ai/workspace/sessions/{sessionId}: platform staff only",
        "GET /admin/copilot/classification-feedback: platform staff only",
        "GET /admin/copilot/memories: platform staff only",
        "DELETE /admin/copilot/memories/{memoryId}: platform staff only",
        "GET /admin/copilot/memories/{memoryId}: platform staff only",
        "PATCH /admin/copilot/memories/{memoryId}: platform staff only",
        "POST /admin/copilot/memories/cleanup: platform staff only",
        "GET /admin/copilot/memories/stats: platform staff only",
        "GET /admin/copilot/overview: platform staff only",
        "GET /admin/copilot/sessions: platform staff only",
        "DELETE /admin/copilot/sessions/{sessionId}: platform staff only",
        "GET /admin/copilot/sessions/{sessionId}: platform staff only",
        "GET /admin/copilot/training-data/export: platform staff only",
        "GET /admin/copilot/training-data/stats: platform staff only",
        "GET /admin/dlq: platform staff only",
        "DELETE /admin/dlq/{messageId}: platform staff only",
        "POST /admin/dlq/{messageId}/retry: platform staff only",
        "GET /admin/enterprise/contracts/{contractId}/billing-schedule: platform staff only",
        "GET /admin/enterprise/contracts/{contractId}/invoices: platform staff only",
        "GET /admin/enterprise/contracts/{contractId}/support-terms: platform staff only",
        "PUT /admin/enterprise/contracts/{contractId}/support-terms: platform staff only",
        "PATCH /admin/enterprise/contracts/{id}/commitment: platform staff only",
        "PATCH /admin/enterprise/inquiries/{inquiryId}: platform staff only",
        "POST /admin/enterprise/invoice-runs: platform staff only",
        "GET /admin/enterprise/orgs/{orgId}/account: platform staff only",
        "POST /admin/enterprise/orgs/{orgId}/tenant/welcome: platform staff only",
        "DELETE /admin/errors: platform staff only",
        "GET /admin/errors: platform staff only",
        "DELETE /admin/errors/{errorId}: platform staff only",
        "GET /admin/errors/{errorId}: platform staff only",
        "PUT /admin/errors/{errorId}/resolve: platform staff only",
        "GET /admin/errors/stats: platform staff only",
        "GET /admin/health/components: platform staff only",
        "PATCH /admin/health/components/{componentName}: platform staff only",
        "GET /admin/hosting/services: platform staff only",
        "DELETE /admin/hosting/services/{id}: platform staff only",
        "GET /admin/hosting/services/{id}: platform staff only",
        "POST /admin/hosting/services/{id}/deploy: platform staff only",
        "GET /admin/hosting/services/{id}/logs: platform staff only",
        "POST /admin/hosting/services/{id}/rollback: platform staff only",
        "POST /admin/hosting/services/{id}/stop: platform staff only",
        "POST /admin/hosting/services/{id}/suspend: platform staff only",
        "POST /admin/hosting/services/{id}/unsuspend: platform staff only",
        "GET /admin/incidents: platform staff only",
        "POST /admin/incidents: platform staff only",
        "DELETE /admin/incidents/{incidentId}: platform staff only",
        "POST /admin/incidents/{incidentId}/ack: platform staff only",
        "POST /admin/incidents/{incidentId}/resolve: platform staff only",
        "POST /admin/incidents/bulk: platform staff only",
        "GET /admin/organizations: platform staff only",
        "GET /admin/organizations/{orgId}: platform staff only",
        "PATCH /admin/organizations/{orgId}: platform staff only",
        "DELETE /admin/organizations/{orgId}/members/{userId}: platform staff only",
        "POST /admin/organizations/{orgId}/transfer: platform staff only",
        "POST /admin/organizations/{orgId}/transfers/{id}/resend: platform staff only",
        "GET /admin/overview: platform staff only",
        "GET /admin/projects: platform staff only",
        "GET /admin/projects/{projectId}: platform staff only",
        "PATCH /admin/projects/{projectId}: platform staff only",
        "GET /admin/queues: platform staff only",
        "GET /admin/rbac/users: platform staff only",
        "POST /admin/rbac/users: platform staff only",
        "DELETE /admin/rbac/users/{userId}/roles/{roleId}: platform staff only",
        "GET /admin/regions: platform staff only",
        "PATCH /admin/regions/{regionKey}: platform staff only",
        "GET /admin/resources/project/{projectId}: platform staff only",
        "POST /admin/resources/project/{projectId}/db: platform staff only",
        "GET /admin/roles: platform staff only",
        "GET /admin/settings: platform staff only",
        "PUT /admin/settings/{key}: platform staff only",
        "GET /admin/support/orgs/{orgId}/tickets/{number}: platform staff only",
        "PATCH /admin/support/orgs/{orgId}/tickets/{number}: platform staff only",
        "POST /admin/support/orgs/{orgId}/tickets/{number}/messages: platform staff only",
        "GET /admin/support/sla-report: platform staff only",
        "GET /admin/support/tickets: platform staff only",
        "GET /admin/system/info: platform staff only",
        "GET /admin/users: platform staff only",
        "GET /admin/users/{userId}: platform staff only",
        "PATCH /admin/users/{userId}/admin: platform staff only",
        "PATCH /admin/users/{userId}/status: platform staff only",
        "POST /ai/copilot/deploy: no typed 2xx application/json response in the spec",
        "POST /ai/copilot/deploy/{deployId}/rollback: no typed 2xx application/json response in the spec",
        "POST /ai/copilot/editor/chat: no typed 2xx application/json response in the spec",
        "POST /ai/copilot/export/docker: no typed 2xx application/json response in the spec",
        "POST /ai/copilot/export/terraform/aws: no typed 2xx application/json response in the spec",
        "POST /ai/copilot/export/terraform/gcp: no typed 2xx application/json response in the spec",
        "POST /ai/copilot/export/zip: no typed 2xx application/json response in the spec",
        "POST /ai/copilot/generation/resume: no typed 2xx application/json response in the spec",
        "GET /ai/copilot/job/{jobId}/events: no typed 2xx application/json response in the spec",
        "POST /ai/copilot/session/{sessionId}/workspace/approve-scripts: no typed 2xx application/json response in the spec",
        "POST /ai/copilot/session/{sessionId}/workspace/preview/{target}/open: no typed 2xx application/json response in the spec",
        "POST /ai/copilot/session/{sessionId}/workspace/preview/reset: no typed 2xx application/json response in the spec",
        "GET /ai/copilot/stats: platform staff only",
        "POST /auth/impersonate/exchange: platform staff only",
        "POST /auth/impersonate/token: platform staff only",
        "GET /auth/oauth/{provider}: no typed 2xx application/json response in the spec",
        "GET /auth/oauth/{provider}/callback: no typed 2xx application/json response in the spec",
        "POST /auth/saml/acs/{id}: no typed 2xx application/json response in the spec",
        "POST /auth/sso/callback: no typed 2xx application/json response in the spec",
        "POST /auth/sso/start: no typed 2xx application/json response in the spec",
        "GET /billing/org/{orgId}/invoices/{invoiceId}/pdf: no typed 2xx application/json response in the spec",
        "POST /blueprint/frontend-beta: no typed 2xx application/json response in the spec",
        "POST /docs/ai-answer: no typed 2xx application/json response in the spec",
        "POST /docs/api-endpoints: platform staff only",
        "DELETE /docs/api-endpoints/{id}: platform staff only",
        "PATCH /docs/api-endpoints/{id}: platform staff only",
        "POST /docs/changelog: platform staff only",
        "DELETE /docs/changelog/{id}: platform staff only",
        "PATCH /docs/changelog/{id}: platform staff only",
        "POST /docs/examples: platform staff only",
        "DELETE /docs/examples/{id}: platform staff only",
        "PATCH /docs/examples/{id}: platform staff only",
        "POST /docs/sdk-examples: platform staff only",
        "DELETE /docs/sdk-examples/{id}: platform staff only",
        "POST /docs/sdks: platform staff only",
        "DELETE /docs/sdks/{id}: platform staff only",
        "PATCH /docs/sdks/{id}: platform staff only",
        "POST /docs/v2/pages: platform staff only",
        "DELETE /docs/v2/pages/{id}: platform staff only",
        "PATCH /docs/v2/pages/{id}: platform staff only",
        "POST /enterprise/contracts: platform staff only",
        "POST /enterprise/contracts/{contractId}/invoice: platform staff only",
        "POST /enterprise/invoices/{invoiceId}/paid: platform staff only",
        "POST /enterprise/invoices/{invoiceId}/send: platform staff only",
        "GET /enterprise/subdomain/{subdomain}: no typed 2xx application/json response in the spec",
        "GET /flags: platform staff only",
        "POST /flags: platform staff only",
        "DELETE /flags/{key}: platform staff only",
        "PUT /flags/{key}: platform staff only",
        "GET /github/oauth/callback: no typed 2xx application/json response in the spec",
        "GET /logs/project/{projectId}/stream: no typed 2xx application/json response in the spec",
        "GET /mcp/oauth/authorize: no typed 2xx application/json response in the spec",
        "GET /openapi.json: no typed 2xx application/json response in the spec",
        "GET /openapi/full: no typed 2xx application/json response in the spec",
        "GET /projects/{projectId}/auth/magic/consume: no typed 2xx application/json response in the spec",
        "GET /projects/{projectId}/auth/oauth/{provider}/callback: no typed 2xx application/json response in the spec",
        "POST /projects/{projectId}/environments/{envId}/domains: no typed 2xx application/json response in the spec",
        "POST /projects/{projectId}/infrastructure/restores: no typed 2xx application/json response in the spec",
        "POST /projects/{projectId}/terminal/exec: no typed 2xx application/json response in the spec",
        "GET /projects/{projectId}/terminal/sessions: no typed 2xx application/json response in the spec",
        "GET /saml/{id}/metadata: no typed 2xx application/json response in the spec",
        "POST /services/{serviceId}/start: no typed 2xx application/json response in the spec",
    });

    /// <summary>Gets method and route templates restricted to platform staff. These operations are refused before I/O.</summary>
    public static IReadOnlyList<string> StaffOnlyRoutes { get; } = System.Array.AsReadOnly(new string[]
    {
        "GET /admin/admins",
        "POST /admin/admins",
        "DELETE /admin/admins/{id}",
        "PUT /admin/admins/{id}",
        "GET /admin/ai-workspace/overview",
        "GET /admin/ai-workspace/sessions",
        "DELETE /admin/ai-workspace/sessions/{sessionId}",
        "GET /admin/ai-workspace/sessions/{sessionId}",
        "GET /admin/ai/backends",
        "DELETE /admin/ai/backends/{backendId}",
        "GET /admin/ai/backends/{backendId}",
        "GET /admin/ai/context-snapshots",
        "DELETE /admin/ai/context-snapshots/{snapshotId}",
        "POST /admin/ai/context-snapshots/{snapshotId}/invalidate",
        "GET /admin/ai/models",
        "POST /admin/ai/models",
        "DELETE /admin/ai/models/{modelId}",
        "GET /admin/ai/models/{modelId}",
        "PATCH /admin/ai/models/{modelId}",
        "POST /admin/ai/models/{modelId}/toggle",
        "GET /admin/ai/prompt-templates",
        "POST /admin/ai/prompt-templates",
        "DELETE /admin/ai/prompt-templates/{templateId}",
        "PATCH /admin/ai/prompt-templates/{templateId}",
        "GET /admin/ai/workspace/sessions",
        "DELETE /admin/ai/workspace/sessions/{sessionId}",
        "GET /admin/ai/workspace/sessions/{sessionId}",
        "GET /admin/copilot/classification-feedback",
        "GET /admin/copilot/memories",
        "DELETE /admin/copilot/memories/{memoryId}",
        "GET /admin/copilot/memories/{memoryId}",
        "PATCH /admin/copilot/memories/{memoryId}",
        "POST /admin/copilot/memories/cleanup",
        "GET /admin/copilot/memories/stats",
        "GET /admin/copilot/overview",
        "GET /admin/copilot/sessions",
        "DELETE /admin/copilot/sessions/{sessionId}",
        "GET /admin/copilot/sessions/{sessionId}",
        "GET /admin/copilot/training-data/export",
        "GET /admin/copilot/training-data/stats",
        "GET /admin/dlq",
        "DELETE /admin/dlq/{messageId}",
        "POST /admin/dlq/{messageId}/retry",
        "GET /admin/enterprise/contracts/{contractId}/billing-schedule",
        "GET /admin/enterprise/contracts/{contractId}/invoices",
        "GET /admin/enterprise/contracts/{contractId}/support-terms",
        "PUT /admin/enterprise/contracts/{contractId}/support-terms",
        "PATCH /admin/enterprise/contracts/{id}/commitment",
        "PATCH /admin/enterprise/inquiries/{inquiryId}",
        "POST /admin/enterprise/invoice-runs",
        "GET /admin/enterprise/orgs/{orgId}/account",
        "POST /admin/enterprise/orgs/{orgId}/tenant/welcome",
        "DELETE /admin/errors",
        "GET /admin/errors",
        "DELETE /admin/errors/{errorId}",
        "GET /admin/errors/{errorId}",
        "PUT /admin/errors/{errorId}/resolve",
        "GET /admin/errors/stats",
        "GET /admin/health/components",
        "PATCH /admin/health/components/{componentName}",
        "GET /admin/hosting/services",
        "DELETE /admin/hosting/services/{id}",
        "GET /admin/hosting/services/{id}",
        "POST /admin/hosting/services/{id}/deploy",
        "GET /admin/hosting/services/{id}/logs",
        "POST /admin/hosting/services/{id}/rollback",
        "POST /admin/hosting/services/{id}/stop",
        "POST /admin/hosting/services/{id}/suspend",
        "POST /admin/hosting/services/{id}/unsuspend",
        "GET /admin/incidents",
        "POST /admin/incidents",
        "DELETE /admin/incidents/{incidentId}",
        "POST /admin/incidents/{incidentId}/ack",
        "POST /admin/incidents/{incidentId}/resolve",
        "POST /admin/incidents/bulk",
        "GET /admin/organizations",
        "GET /admin/organizations/{orgId}",
        "PATCH /admin/organizations/{orgId}",
        "DELETE /admin/organizations/{orgId}/members/{userId}",
        "POST /admin/organizations/{orgId}/transfer",
        "POST /admin/organizations/{orgId}/transfers/{id}/resend",
        "GET /admin/overview",
        "GET /admin/projects",
        "GET /admin/projects/{projectId}",
        "PATCH /admin/projects/{projectId}",
        "GET /admin/queues",
        "GET /admin/rbac/users",
        "POST /admin/rbac/users",
        "DELETE /admin/rbac/users/{userId}/roles/{roleId}",
        "GET /admin/regions",
        "PATCH /admin/regions/{regionKey}",
        "GET /admin/resources/project/{projectId}",
        "POST /admin/resources/project/{projectId}/db",
        "GET /admin/roles",
        "GET /admin/settings",
        "PUT /admin/settings/{key}",
        "GET /admin/support/orgs/{orgId}/tickets/{number}",
        "PATCH /admin/support/orgs/{orgId}/tickets/{number}",
        "POST /admin/support/orgs/{orgId}/tickets/{number}/messages",
        "GET /admin/support/sla-report",
        "GET /admin/support/tickets",
        "GET /admin/system/info",
        "GET /admin/users",
        "GET /admin/users/{userId}",
        "PATCH /admin/users/{userId}/admin",
        "PATCH /admin/users/{userId}/status",
        "GET /ai/copilot/stats",
        "POST /auth/impersonate/exchange",
        "POST /auth/impersonate/token",
        "POST /docs/api-endpoints",
        "DELETE /docs/api-endpoints/{id}",
        "PATCH /docs/api-endpoints/{id}",
        "POST /docs/changelog",
        "DELETE /docs/changelog/{id}",
        "PATCH /docs/changelog/{id}",
        "POST /docs/examples",
        "DELETE /docs/examples/{id}",
        "PATCH /docs/examples/{id}",
        "POST /docs/sdk-examples",
        "DELETE /docs/sdk-examples/{id}",
        "POST /docs/sdks",
        "DELETE /docs/sdks/{id}",
        "PATCH /docs/sdks/{id}",
        "POST /docs/v2/pages",
        "DELETE /docs/v2/pages/{id}",
        "PATCH /docs/v2/pages/{id}",
        "POST /enterprise/contracts",
        "POST /enterprise/contracts/{contractId}/invoice",
        "POST /enterprise/invoices/{invoiceId}/paid",
        "POST /enterprise/invoices/{invoiceId}/send",
        "GET /flags",
        "POST /flags",
        "DELETE /flags/{key}",
        "PUT /flags/{key}",
    });

    /// <summary>Sends a DELETE request to <c>/ai/copilot/session/{sessionId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteAiCopilotSessionBySessionIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[0], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/alert-rules/{ruleId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteAlertRulesByRuleIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[1], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/auth/me/linked-accounts/{provider}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteAuthMeLinkedAccountsByProviderAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[2], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/auth/sessions/{id}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteAuthSessionsByIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[3], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/billing/org/{orgId}/addons/{addonId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteBillingOrgByOrgIdAddonsByAddonIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[4], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/billing/org/{orgId}/contacts/{contactId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteBillingOrgByOrgIdContactsByContactIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[5], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/billing/org/{orgId}/usage-alerts/{alertId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteBillingOrgByOrgIdUsageAlertsByAlertIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[6], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/buckets/{bucketId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteBucketsByBucketIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[7], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/buckets/{bucketId}/files</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteBucketsByBucketIdFilesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[8], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/database/extensions/project/{projectId}/{extensionId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteDatabaseExtensionsProjectByProjectIdByExtensionIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[9], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/database/wrappers/project/{projectId}/{wrapperId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteDatabaseWrappersProjectByProjectIdByWrapperIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[10], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/functions/{functionId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteFunctionsByFunctionIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[11], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/functions/{functionId}/schedule</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteFunctionsByFunctionIdScheduleAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[12], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/functions/secrets/{secretId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteFunctionsSecretsBySecretIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[13], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/functions/triggers/{triggerId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteFunctionsTriggersByTriggerIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[14], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/generated/{table}/bulk</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteGeneratedByTableBulkAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[15], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/generated/{table}/{id}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteGeneratedByTableByIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[16], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/integrations/subscriptions/{id}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteIntegrationsSubscriptionsByIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[17], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/mcp/connections/{id}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteMcpConnectionsByIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[18], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/mongodb/{collection}/indexes/{indexName}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteMongodbByCollectionIndexesByIndexNameAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[19], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/mongodb/collections/{name}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteMongodbCollectionsByNameAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[20], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/oauth/org/{orgId}/provider/{provider}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteOauthOrgByOrgIdProviderByProviderAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[21], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/orgs/{orgId}/invites/{inviteId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteOrgsByOrgIdInvitesByInviteIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[22], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/orgs/{orgId}/leave-requests/mine</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteOrgsByOrgIdLeaveRequestsMineAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[23], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/orgs/{orgId}/members/{userId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteOrgsByOrgIdMembersByUserIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[24], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/orgs/{orgId}/transfers/{id}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteOrgsByOrgIdTransfersByIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[25], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/projects/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteProjectsByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[26], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/projects/{projectId}/auth/oauth-apps/{provider}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteProjectsByProjectIdAuthOauthAppsByProviderAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[27], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/projects/{projectId}/auth/sessions</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteProjectsByProjectIdAuthSessionsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[28], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/projects/{projectId}/auth/sessions/{id}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteProjectsByProjectIdAuthSessionsByIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[29], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/projects/{projectId}/branches/{branchName}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteProjectsByProjectIdBranchesByBranchNameAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[30], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/projects/{projectId}/database/dedicated</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteProjectsByProjectIdDatabaseDedicatedAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[31], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/projects/{projectId}/env-vars/{envVarId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteProjectsByProjectIdEnvVarsByEnvVarIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[32], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/projects/{projectId}/environments/{envId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteProjectsByProjectIdEnvironmentsByEnvIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[33], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/projects/{projectId}/environments/{envId}/domains/{domainId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteProjectsByProjectIdEnvironmentsByEnvIdDomainsByDomainIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[34], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/projects/{projectId}/github/disconnect</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteProjectsByProjectIdGithubDisconnectAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[35], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/projects/{projectId}/infrastructure/{instanceId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteProjectsByProjectIdInfrastructureByInstanceIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[36], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/projects/{projectId}/members/{userId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteProjectsByProjectIdMembersByUserIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[37], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/projects/{projectId}/users/{userId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteProjectsByProjectIdUsersByUserIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[38], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/projects/{projectId}/users/{userId}/sessions/{sessionId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteProjectsByProjectIdUsersByUserIdSessionsBySessionIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[39], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/rls/policies/{policyId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteRlsPoliciesByPolicyIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[40], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/schema-engine/snippets/{projectId}/{snippetId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteSchemaEngineSnippetsByProjectIdBySnippetIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[41], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/services/{serviceId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteServicesByServiceIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[42], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/services/{serviceId}/domains/{domainId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteServicesByServiceIdDomainsByDomainIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[43], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/services/{serviceId}/git/connect</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteServicesByServiceIdGitConnectAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[44], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/sso/org/{orgId}/connections/{connectionId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteSsoOrgByOrgIdConnectionsByConnectionIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[45], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/sso/org/{orgId}/connections/{connectionId}/certificates/{certId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteSsoOrgByOrgIdConnectionsByConnectionIdCertificatesByCertIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[46], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/sso/org/{orgId}/connections/{connectionId}/identities/{userId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteSsoOrgByOrgIdConnectionsByConnectionIdIdentitiesByUserIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[47], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/sso/org/{orgId}/connections/{connectionId}/scim/tokens/{tokenId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteSsoOrgByOrgIdConnectionsByConnectionIdScimTokensByTokenIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[48], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/sso/org/{orgId}/outside-members/allow/{allowId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteSsoOrgByOrgIdOutsideMembersAllowByAllowIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[49], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/sso/org/{orgId}/security-contact</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteSsoOrgByOrgIdSecurityContactAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[50], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/storage/buckets/{bucketId}/policies/{policyId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteStorageBucketsByBucketIdPoliciesByPolicyIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[51], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/templates/{id}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteTemplatesByIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[52], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/v1/data/{projectId}/{table}/bulk</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteV1DataByProjectIdByTableBulkAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[53], request, cancellationToken);

    /// <summary>Sends a DELETE request to <c>/v1/data/{projectId}/{table}/{id}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> DeleteV1DataByProjectIdByTableByIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[54], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[55], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/activation/org/{orgId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetActivationOrgByOrgIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[56], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/autocomplete</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotAutocompleteAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[57], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/context-summary/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotContextSummaryByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[58], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/credit-status/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotCreditStatusByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[59], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/deploy/{deployId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotDeployByDeployIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[60], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/deploy/history/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotDeployHistoryByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[61], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/execution/{executionId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotExecutionByExecutionIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[62], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/executions/{sessionId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotExecutionsBySessionIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[63], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/git/branches/{sessionId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotGitBranchesBySessionIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[64], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/git/files/{sessionId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotGitFilesBySessionIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[65], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/git/log/{sessionId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotGitLogBySessionIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[66], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/git/status/{sessionId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotGitStatusBySessionIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[67], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/job/{jobId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotJobByJobIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[68], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/manifest/{manifestId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotManifestByManifestIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[69], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/metrics/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotMetricsByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[70], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/metrics/org/{orgId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotMetricsOrgByOrgIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[71], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/models/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotModelsByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[72], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/session/{sessionId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotSessionBySessionIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[73], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/session/{sessionId}/editor-files</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotSessionBySessionIdEditorFilesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[74], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/session/{sessionId}/workspace/export</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotSessionBySessionIdWorkspaceExportAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[75], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/session/{sessionId}/workspace/status</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotSessionBySessionIdWorkspaceStatusAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[76], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/session/{sessionId}/workspace/types</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotSessionBySessionIdWorkspaceTypesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[77], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/sessions/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotSessionsByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[78], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/usage/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotUsageByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[79], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/usage-org/{orgId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotUsageOrgByOrgIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[80], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/version/{versionId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotVersionByVersionIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[81], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/version/{versionId}/diff/{compareVersionId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotVersionByVersionIdDiffByCompareVersionIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[82], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai/copilot/versions/{sessionId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiCopilotVersionsBySessionIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[83], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai-usage/org/{orgId}/breakdown</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiUsageOrgByOrgIdBreakdownAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[84], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai-usage/org/{orgId}/exhaustion-events</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiUsageOrgByOrgIdExhaustionEventsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[85], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai-usage/org/{orgId}/history</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiUsageOrgByOrgIdHistoryAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[86], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai-usage/org/{orgId}/recent</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiUsageOrgByOrgIdRecentAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[87], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai-usage/org/{orgId}/rollups</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiUsageOrgByOrgIdRollupsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[88], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai-usage/org/{orgId}/summary</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiUsageOrgByOrgIdSummaryAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[89], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/ai-usage/org/{orgId}/verament</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAiUsageOrgByOrgIdVeramentAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[90], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/alert-rules/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAlertRulesProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[91], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/announcements</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAnnouncementsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[92], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/audit/org/{orgId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAuditOrgByOrgIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[93], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/audit/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAuditProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[94], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/auth/me</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAuthMeAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[95], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/auth/me/admin</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAuthMeAdminAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[96], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/auth/me/context</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAuthMeContextAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[97], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/auth/me/linked-accounts</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAuthMeLinkedAccountsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[98], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/auth/mfa/status</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAuthMfaStatusAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[99], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/auth/oauth/providers</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAuthOauthProvidersAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[100], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/auth/session</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAuthSessionAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[101], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/auth/sessions</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAuthSessionsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[102], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/auth/tenant/session</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetAuthTenantSessionAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[103], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/addons/catalog</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingAddonsCatalogAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[104], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/checkout/verify/{sessionId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingCheckoutVerifyBySessionIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[105], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/credits/packages</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingCreditsPackagesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[106], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/credits/rates</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingCreditsRatesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[107], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/founders/wall</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingFoundersWallAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[108], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/org/{orgId}/addons</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingOrgByOrgIdAddonsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[109], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/org/{orgId}/card-check</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingOrgByOrgIdCardCheckAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[110], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/org/{orgId}/contacts</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingOrgByOrgIdContactsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[111], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/org/{orgId}/cost-breakdown</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingOrgByOrgIdCostBreakdownAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[112], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/org/{orgId}/credits/auto-topup</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingOrgByOrgIdCreditsAutoTopupAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[113], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/org/{orgId}/credits/transactions</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingOrgByOrgIdCreditsTransactionsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[114], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/org/{orgId}/founder</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingOrgByOrgIdFounderAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[115], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/org/{orgId}/hosting</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingOrgByOrgIdHostingAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[116], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/org/{orgId}/infrastructure</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingOrgByOrgIdInfrastructureAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[117], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/org/{orgId}/invoices</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingOrgByOrgIdInvoicesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[118], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/org/{orgId}/overages</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingOrgByOrgIdOveragesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[119], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/org/{orgId}/overages/history</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingOrgByOrgIdOveragesHistoryAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[120], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/org/{orgId}/subscription</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingOrgByOrgIdSubscriptionAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[121], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/org/{orgId}/summary</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingOrgByOrgIdSummaryAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[122], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/org/{orgId}/tax-info</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingOrgByOrgIdTaxInfoAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[123], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/org/{orgId}/usage</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingOrgByOrgIdUsageAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[124], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/org/{orgId}/usage-alerts</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingOrgByOrgIdUsageAlertsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[125], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/org/{orgId}/usage-alerts/configured</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingOrgByOrgIdUsageAlertsConfiguredAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[126], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/org/{orgId}/usage-alerts/history</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingOrgByOrgIdUsageAlertsHistoryAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[127], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/org/{orgId}/usage/history</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingOrgByOrgIdUsageHistoryAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[128], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/org/{orgId}/usage/realtime</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingOrgByOrgIdUsageRealtimeAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[129], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/billing/plans</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBillingPlansAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[130], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/bootstrap</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBootstrapAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[131], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/buckets/{bucketId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBucketsByBucketIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[132], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/buckets/{bucketId}/files</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBucketsByBucketIdFilesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[133], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/buckets/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetBucketsProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[134], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/cms/careers</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetCmsCareersAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[135], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/cms/faqs/{pageSlug}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetCmsFaqsByPageSlugAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[136], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/cms/pages/{slug}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetCmsPagesBySlugAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[137], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/cms/partners</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetCmsPartnersAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[138], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/cms/team</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetCmsTeamAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[139], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/cms/testimonials</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetCmsTestimonialsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[140], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/credits/org/{orgId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetCreditsOrgByOrgIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[141], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/credits/org/{orgId}/balance</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetCreditsOrgByOrgIdBalanceAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[142], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/database/connector/{projectId}/tables</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetDatabaseConnectorByProjectIdTablesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[143], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/database/extensions/available</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetDatabaseExtensionsAvailableAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[144], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/database/extensions/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetDatabaseExtensionsProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[145], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/database/tiers</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetDatabaseTiersAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[146], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/database/wrappers/available</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetDatabaseWrappersAvailableAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[147], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/database/wrappers/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetDatabaseWrappersProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[148], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/deployments/{deploymentId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetDeploymentsByDeploymentIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[149], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/deployments/{deploymentId}/steps</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetDeploymentsByDeploymentIdStepsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[150], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/deployments/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetDeploymentsProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[151], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/deployments/project/{projectId}/stats</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetDeploymentsProjectByProjectIdStatsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[152], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/deployments/tokens/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetDeploymentsTokensProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[153], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/docs/ai-search</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetDocsAiSearchAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[154], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/docs/api-endpoints</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetDocsApiEndpointsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[155], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/docs/api-endpoints/{id}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetDocsApiEndpointsByIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[156], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/docs/categories</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetDocsCategoriesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[157], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/docs/changelog</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetDocsChangelogAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[158], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/docs/changelog/{id}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetDocsChangelogByIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[159], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/docs/examples</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetDocsExamplesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[160], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/docs/examples/{slug}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetDocsExamplesBySlugAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[161], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/docs/project/{projectId}/quickstart</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetDocsProjectByProjectIdQuickstartAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[162], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/docs/sdks</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetDocsSdksAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[163], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/docs/sdks/{platform}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetDocsSdksByPlatformAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[164], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/docs/sdks/{sdkId}/examples</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetDocsSdksBySdkIdExamplesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[165], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/docs/search</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetDocsSearchAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[166], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/docs/v2/pages</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetDocsV2PagesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[167], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/docs/v2/pages/{slug}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetDocsV2PagesBySlugAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[168], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/early/{number}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetEarlyByNumberAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[169], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/early/wall</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetEarlyWallAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[170], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/enterprise/org/{orgId}/contract</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetEnterpriseOrgByOrgIdContractAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[171], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/enterprise/org/{orgId}/invoices</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetEnterpriseOrgByOrgIdInvoicesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[172], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/enterprise/org/{orgId}/onboarding</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetEnterpriseOrgByOrgIdOnboardingAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[173], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/enterprise/org/{orgId}/spend</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetEnterpriseOrgByOrgIdSpendAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[174], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/enterprise/org/{orgId}/usage</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetEnterpriseOrgByOrgIdUsageAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[175], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/enterprise/org/{orgId}/usage/history</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetEnterpriseOrgByOrgIdUsageHistoryAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[176], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/enterprise/org/{orgId}/usage/projects</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetEnterpriseOrgByOrgIdUsageProjectsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[177], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/enterprise/pricing</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetEnterprisePricingAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[178], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/enterprise/quotes/{quoteId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetEnterpriseQuotesByQuoteIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[179], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/entitlements/org/{orgId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetEntitlementsOrgByOrgIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[180], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/functions/{functionId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetFunctionsByFunctionIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[181], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/functions/{functionId}/deploy-status</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetFunctionsByFunctionIdDeployStatusAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[182], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/functions/{functionId}/invocations</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetFunctionsByFunctionIdInvocationsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[183], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/functions/{functionId}/logs</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetFunctionsByFunctionIdLogsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[184], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/functions/{functionId}/metrics</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetFunctionsByFunctionIdMetricsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[185], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/functions/{functionId}/schedule</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetFunctionsByFunctionIdScheduleAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[186], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/functions/{functionId}/triggers</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetFunctionsByFunctionIdTriggersAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[187], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/functions/invocations</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetFunctionsInvocationsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[188], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/functions/invocations/function/{functionId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetFunctionsInvocationsFunctionByFunctionIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[189], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/functions/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetFunctionsProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[190], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/functions/project/{projectId}/name/{functionName}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetFunctionsProjectByProjectIdNameByFunctionNameAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[191], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/functions/project/{projectId}/summary</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetFunctionsProjectByProjectIdSummaryAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[192], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/functions/schedule/preview</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetFunctionsSchedulePreviewAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[193], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/functions/secrets/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetFunctionsSecretsProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[194], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/generated/{table}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetGeneratedByTableAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[195], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/generated/{table}/aggregate</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetGeneratedByTableAggregateAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[196], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/generated/{table}/{id}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetGeneratedByTableByIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[197], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/generated/{table}/search</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetGeneratedByTableSearchAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[198], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/github/oauth/authorize</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetGithubOauthAuthorizeAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[199], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/incidents/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetIncidentsProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[200], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/infrastructure/sizes</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetInfrastructureSizesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[201], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/integrations/analytics/project/{projectId}/events</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetIntegrationsAnalyticsProjectByProjectIdEventsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[202], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/integrations/analytics/project/{projectId}/stats</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetIntegrationsAnalyticsProjectByProjectIdStatsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[203], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/integrations/deliveries/event/{eventId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetIntegrationsDeliveriesEventByEventIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[204], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/integrations/deliveries/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetIntegrationsDeliveriesProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[205], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/integrations/deliveries/project/{projectId}/summary</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetIntegrationsDeliveriesProjectByProjectIdSummaryAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[206], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/integrations/deliveries/subscription/{subscriptionId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetIntegrationsDeliveriesSubscriptionBySubscriptionIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[207], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/integrations/dlq/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetIntegrationsDlqProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[208], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/integrations/events</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetIntegrationsEventsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[209], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/integrations/subscriptions/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetIntegrationsSubscriptionsProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[210], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/jobs/dlq/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetJobsDlqProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[211], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/jobs/webhooks/delivery/{deliveryId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetJobsWebhooksDeliveryByDeliveryIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[212], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/jobs/webhooks/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetJobsWebhooksProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[213], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/logs/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetLogsProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[214], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/logs/project/{projectId}/feed</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetLogsProjectByProjectIdFeedAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[215], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/maintenance</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetMaintenanceAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[216], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/mcp/connections</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetMcpConnectionsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[217], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/mcp/oauth/requests/{requestId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetMcpOauthRequestsByRequestIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[218], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/mcp/session</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetMcpSessionAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[219], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/me/badges</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetMeBadgesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[220], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/me/creator</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetMeCreatorAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[221], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/metrics/org/{orgId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetMetricsOrgByOrgIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[222], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/metrics/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetMetricsProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[223], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/metrics/project/{projectId}/overview</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetMetricsProjectByProjectIdOverviewAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[224], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/metrics/project/{projectId}/report</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetMetricsProjectByProjectIdReportAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[225], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/mongodb/{collection}/estimatedCount</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetMongodbByCollectionEstimatedCountAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[226], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/mongodb/{collection}/findById/{id}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetMongodbByCollectionFindByIdByIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[227], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/mongodb/{collection}/indexes</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetMongodbByCollectionIndexesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[228], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/mongodb/collections</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetMongodbCollectionsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[229], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/oauth/org/{orgId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOauthOrgByOrgIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[230], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/oauth/org/{orgId}/provider/{provider}/authorize</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOauthOrgByOrgIdProviderByProviderAuthorizeAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[231], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/onboarding/org/{orgId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOnboardingOrgByOrgIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[232], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/openapi/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOpenapiProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[233], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/openapi.yaml</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOpenapiYamlAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[234], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/orgs</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOrgsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[235], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/orgs/{orgId}/access-matrix</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOrgsByOrgIdAccessMatrixAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[236], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/orgs/{orgId}/blueprint-defaults</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOrgsByOrgIdBlueprintDefaultsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[237], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/orgs/{orgId}/change-requests</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOrgsByOrgIdChangeRequestsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[238], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/orgs/{orgId}/data-region</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOrgsByOrgIdDataRegionAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[239], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/orgs/{orgId}/identity/summary</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOrgsByOrgIdIdentitySummaryAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[240], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/orgs/{orgId}/invites</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOrgsByOrgIdInvitesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[241], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/orgs/{orgId}/leave-requests</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOrgsByOrgIdLeaveRequestsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[242], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/orgs/{orgId}/leave-requests/mine</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOrgsByOrgIdLeaveRequestsMineAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[243], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/orgs/{orgId}/managed-domains</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOrgsByOrgIdManagedDomainsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[244], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/orgs/{orgId}/managed-summary</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOrgsByOrgIdManagedSummaryAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[245], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/orgs/{orgId}/members</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOrgsByOrgIdMembersAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[246], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/orgs/{orgId}/membership</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOrgsByOrgIdMembershipAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[247], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/orgs/{orgId}/profile</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOrgsByOrgIdProfileAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[248], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/orgs/{orgId}/roles</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOrgsByOrgIdRolesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[249], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/orgs/{orgId}/security</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOrgsByOrgIdSecurityAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[250], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/orgs/{orgId}/security/posture</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOrgsByOrgIdSecurityPostureAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[251], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/orgs/{orgId}/support/sla-report</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOrgsByOrgIdSupportSlaReportAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[252], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/orgs/{orgId}/support/summary</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOrgsByOrgIdSupportSummaryAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[253], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/orgs/{orgId}/support/terms</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOrgsByOrgIdSupportTermsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[254], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/orgs/{orgId}/support/tickets</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOrgsByOrgIdSupportTicketsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[255], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/orgs/{orgId}/support/tickets/{number}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOrgsByOrgIdSupportTicketsByNumberAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[256], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/orgs/{orgId}/transfers</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOrgsByOrgIdTransfersAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[257], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/orgs/invites/lookup</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOrgsInvitesLookupAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[258], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/orgs/transfers/preview</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetOrgsTransfersPreviewAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[259], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/plans/{planId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetPlansByPlanIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[260], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/plans/org/{orgId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetPlansOrgByOrgIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[261], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/pricing/ai-features</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetPricingAiFeaturesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[262], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/pricing/compare</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetPricingCompareAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[263], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/pricing/enterprise</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetPricingEnterpriseAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[264], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/pricing/plans</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetPricingPlansAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[265], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/pricing/plans/{plan}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetPricingPlansByPlanAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[266], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[267], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{id}/insights</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByIdInsightsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[268], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[269], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/api-keys</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdApiKeysAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[270], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/auth/activity</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdAuthActivityAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[271], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/auth/me</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdAuthMeAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[272], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/auth/oauth-apps</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdAuthOauthAppsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[273], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/auth/oauth/providers</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdAuthOauthProvidersAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[274], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/auth/sessions</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdAuthSessionsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[275], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/auth/settings</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdAuthSettingsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[276], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/branches</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdBranchesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[277], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/branches/{branchName}/url</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdBranchesByBranchNameUrlAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[278], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/database/dedicated</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdDatabaseDedicatedAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[279], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/database/dedicated/connection</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdDatabaseDedicatedConnectionAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[280], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/database/dedicated/status</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdDatabaseDedicatedStatusAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[281], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/deletion-preview</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdDeletionPreviewAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[282], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/env-vars</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdEnvVarsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[283], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/environments</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdEnvironmentsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[284], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/environments/{envId}/domain-status</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdEnvironmentsByEnvIdDomainStatusAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[285], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/environments/{envId}/domain-verification</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdEnvironmentsByEnvIdDomainVerificationAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[286], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/environments/{envId}/domains</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdEnvironmentsByEnvIdDomainsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[287], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/environments/promotion-order</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdEnvironmentsPromotionOrderAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[288], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/frontend</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdFrontendAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[289], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/getting-started</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdGettingStartedAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[290], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/github/branches</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdGithubBranchesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[291], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/github/repos</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdGithubReposAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[292], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/github/status</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdGithubStatusAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[293], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/github/tracked-repos</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdGithubTrackedReposAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[294], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/infrastructure</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdInfrastructureAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[295], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/infrastructure/{instanceId}/metrics</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdInfrastructureByInstanceIdMetricsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[296], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/infrastructure/{instanceId}/replicas</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdInfrastructureByInstanceIdReplicasAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[297], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/infrastructure/{instanceId}/upgrade-options</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdInfrastructureByInstanceIdUpgradeOptionsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[298], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/infrastructure/migration/progress</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdInfrastructureMigrationProgressAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[299], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/infrastructure/migration-status</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdInfrastructureMigrationStatusAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[300], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/infrastructure/restores</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdInfrastructureRestoresAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[301], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/members</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdMembersAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[302], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/promotions</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdPromotionsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[303], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/promotions/diff</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdPromotionsDiffAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[304], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/region</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdRegionAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[305], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/security/advisor</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdSecurityAdvisorAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[306], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/settings</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdSettingsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[307], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/settings/addons</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdSettingsAddonsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[308], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/settings/api</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdSettingsApiAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[309], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/settings/compute</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdSettingsComputeAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[310], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/settings/jwt</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdSettingsJwtAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[311], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/storage/settings</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdStorageSettingsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[312], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/users</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdUsersAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[313], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/users/{userId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdUsersByUserIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[314], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/users/{userId}/sessions</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdUsersByUserIdSessionsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[315], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/{projectId}/users/stats</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsByProjectIdUsersStatsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[316], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/projects/slug-available</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetProjectsSlugAvailableAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[317], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/quickstart/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetQuickstartProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[318], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/quickstart/project/{projectId}/json</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetQuickstartProjectByProjectIdJsonAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[319], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/realtime/connections/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetRealtimeConnectionsProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[320], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/realtime/events/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetRealtimeEventsProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[321], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/realtime/stats/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetRealtimeStatsProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[322], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/realtime/status/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetRealtimeStatusProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[323], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/realtime/subscriptions/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetRealtimeSubscriptionsProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[324], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/refunds/{id}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetRefundsByIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[325], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/refunds/org/{orgId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetRefundsOrgByOrgIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[326], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/regions</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetRegionsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[327], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/regions/all</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetRegionsAllAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[328], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/regions/{key}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetRegionsByKeyAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[329], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/regions/{key}/metrics</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetRegionsByKeyMetricsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[330], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/regions/health</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetRegionsHealthAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[331], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/rls/policies/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetRlsPoliciesByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[332], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/schema-engine/{projectId}/changes</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetSchemaEngineByProjectIdChangesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[333], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/schema-engine/editor-sessions/{projectId}/capabilities</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetSchemaEngineEditorSessionsByProjectIdCapabilitiesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[334], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/schema-engine/introspect/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetSchemaEngineIntrospectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[335], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/schema-engine/migrations/{projectId}/{migrationId}/diff</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetSchemaEngineMigrationsByProjectIdByMigrationIdDiffAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[336], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/schema-engine/migrations/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetSchemaEngineMigrationsProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[337], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/schema-engine/snapshots/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetSchemaEngineSnapshotsProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[338], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/schema-engine/snippets/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetSchemaEngineSnippetsByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[339], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/schemas/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetSchemasProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[340], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/security/audit/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetSecurityAuditByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[341], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/security/overview/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetSecurityOverviewByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[342], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/security/variables/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetSecurityVariablesProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[343], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/services/{serviceId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetServicesByServiceIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[344], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/services/{serviceId}/deployments/{deploymentId}/build-logs</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetServicesByServiceIdDeploymentsByDeploymentIdBuildLogsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[345], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/services/{serviceId}/deployments/{deploymentId}/status</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetServicesByServiceIdDeploymentsByDeploymentIdStatusAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[346], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/services/{serviceId}/domains</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetServicesByServiceIdDomainsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[347], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/services/{serviceId}/git/connect</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetServicesByServiceIdGitConnectAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[348], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/services/{serviceId}/logs</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetServicesByServiceIdLogsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[349], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/services/{serviceId}/status</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetServicesByServiceIdStatusAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[350], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/services/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetServicesProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[351], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/services/project/{projectId}/summary</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetServicesProjectByProjectIdSummaryAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[352], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/sso/me/paused-access</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetSsoMePausedAccessAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[353], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/sso/org/{orgId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetSsoOrgByOrgIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[354], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/sso/org/{orgId}/connections/{connectionId}/break-glass</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetSsoOrgByOrgIdConnectionsByConnectionIdBreakGlassAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[355], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/sso/org/{orgId}/connections/{connectionId}/certificates</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetSsoOrgByOrgIdConnectionsByConnectionIdCertificatesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[356], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/sso/org/{orgId}/connections/{connectionId}/group-mappings</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetSsoOrgByOrgIdConnectionsByConnectionIdGroupMappingsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[357], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/sso/org/{orgId}/connections/{connectionId}/require</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetSsoOrgByOrgIdConnectionsByConnectionIdRequireAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[358], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/sso/org/{orgId}/connections/{connectionId}/scim/reconciliation</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetSsoOrgByOrgIdConnectionsByConnectionIdScimReconciliationAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[359], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/sso/org/{orgId}/connections/{connectionId}/scim/tokens</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetSsoOrgByOrgIdConnectionsByConnectionIdScimTokensAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[360], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/sso/org/{orgId}/outside-members</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetSsoOrgByOrgIdOutsideMembersAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[361], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/sso/org/{orgId}/outside-members/blocked</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetSsoOrgByOrgIdOutsideMembersBlockedAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[362], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/sso/org/{orgId}/security-contact</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetSsoOrgByOrgIdSecurityContactAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[363], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/status</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetStatusAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[364], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/status/atom</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetStatusAtomAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[365], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/status/incidents</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetStatusIncidentsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[366], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/status/rss</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetStatusRssAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[367], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/status/subscribers/count</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetStatusSubscribersCountAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[368], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/status/unsubscribe/{token}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetStatusUnsubscribeByTokenAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[369], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/status/uptime/{componentId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetStatusUptimeByComponentIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[370], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/storage/buckets</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetStorageBucketsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[371], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/storage/buckets/{bucketId}/policies</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetStorageBucketsByBucketIdPoliciesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[372], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/storage/download</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetStorageDownloadAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[373], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/storage/files/{bucketId}/metadata</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetStorageFilesByBucketIdMetadataAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[374], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/storage/multipart/list-pending</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetStorageMultipartListPendingAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[375], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/storage/usage/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetStorageUsageProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[376], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/templates</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetTemplatesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[377], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/templates/{slug}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetTemplatesBySlugAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[378], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/templates/installs</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetTemplatesInstallsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[379], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/tenant/branding</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetTenantBrandingAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[380], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/users/me</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetUsersMeAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[381], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/users/me/preferences</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetUsersMePreferencesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[382], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/v1/data/{projectId}/{table}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetV1DataByProjectIdByTableAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[383], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/v1/data/{projectId}/{table}/aggregate</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetV1DataByProjectIdByTableAggregateAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[384], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/v1/data/{projectId}/{table}/{id}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetV1DataByProjectIdByTableByIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[385], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/v1/data/{projectId}/{table}/search</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetV1DataByProjectIdByTableSearchAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[386], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/v1/health</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetV1HealthAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[387], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/v1/project</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetV1ProjectAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[388], request, cancellationToken);

    /// <summary>Sends a GET request to <c>/.well-known/oauth-authorization-server</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> GetWellKnownOauthAuthorizationServerAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[389], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/ai/copilot/session/{sessionId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchAiCopilotSessionBySessionIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[390], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/auth/me</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchAuthMeAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[391], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/billing/org/{orgId}/addons/{addonId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchBillingOrgByOrgIdAddonsByAddonIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[392], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/billing/org/{orgId}/contacts/{contactId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchBillingOrgByOrgIdContactsByContactIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[393], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/billing/org/{orgId}/usage-alerts/{alertId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchBillingOrgByOrgIdUsageAlertsByAlertIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[394], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/database/wrappers/project/{projectId}/{wrapperId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchDatabaseWrappersProjectByProjectIdByWrapperIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[395], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/enterprise/org/{orgId}/onboarding</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchEnterpriseOrgByOrgIdOnboardingAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[396], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/functions/{functionId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchFunctionsByFunctionIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[397], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/functions/triggers/{triggerId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchFunctionsTriggersByTriggerIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[398], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/generated/{table}/bulk</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchGeneratedByTableBulkAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[399], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/generated/{table}/{id}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchGeneratedByTableByIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[400], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/integrations/subscriptions/{id}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchIntegrationsSubscriptionsByIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[401], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/oauth/org/{orgId}/provider/{provider}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchOauthOrgByOrgIdProviderByProviderAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[402], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/orgs/{orgId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchOrgsByOrgIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[403], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/orgs/{orgId}/blueprint-defaults</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchOrgsByOrgIdBlueprintDefaultsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[404], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/orgs/{orgId}/data-region</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchOrgsByOrgIdDataRegionAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[405], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/orgs/{orgId}/members/{userId}/role</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchOrgsByOrgIdMembersByUserIdRoleAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[406], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/orgs/{orgId}/members/roles</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchOrgsByOrgIdMembersRolesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[407], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/orgs/{orgId}/profile</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchOrgsByOrgIdProfileAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[408], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/orgs/{orgId}/security</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchOrgsByOrgIdSecurityAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[409], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/projects/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchProjectsByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[410], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/projects/{projectId}/api-keys/{keyId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchProjectsByProjectIdApiKeysByKeyIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[411], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/projects/{projectId}/auth/settings</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchProjectsByProjectIdAuthSettingsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[412], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/projects/{projectId}/env-vars/{envVarId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchProjectsByProjectIdEnvVarsByEnvVarIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[413], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/projects/{projectId}/environments/{envId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchProjectsByProjectIdEnvironmentsByEnvIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[414], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/projects/{projectId}/settings/addons</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchProjectsByProjectIdSettingsAddonsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[415], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/projects/{projectId}/settings/api</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchProjectsByProjectIdSettingsApiAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[416], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/projects/{projectId}/settings/compute</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchProjectsByProjectIdSettingsComputeAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[417], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/projects/{projectId}/settings/jwt</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchProjectsByProjectIdSettingsJwtAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[418], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/projects/{projectId}/storage/settings</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchProjectsByProjectIdStorageSettingsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[419], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/projects/{projectId}/users/{userId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchProjectsByProjectIdUsersByUserIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[420], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/regions/{key}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchRegionsByKeyAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[421], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/rls/policies/{policyId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchRlsPoliciesByPolicyIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[422], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/schema-engine/snippets/{projectId}/{snippetId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchSchemaEngineSnippetsByProjectIdBySnippetIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[423], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/services/{serviceId}/hostname</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchServicesByServiceIdHostnameAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[424], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/services/{serviceId}/runtime-class</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchServicesByServiceIdRuntimeClassAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[425], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/sso/org/{orgId}/connections/{connectionId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchSsoOrgByOrgIdConnectionsByConnectionIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[426], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/storage/files/{bucketId}/metadata</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchStorageFilesByBucketIdMetadataAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[427], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/users/me</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchUsersMeAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[428], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/users/me/preferences</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchUsersMePreferencesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[429], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/v1/data/{projectId}/{table}/bulk</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchV1DataByProjectIdByTableBulkAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[430], request, cancellationToken);

    /// <summary>Sends a PATCH request to <c>/v1/data/{projectId}/{table}/{id}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PatchV1DataByProjectIdByTableByIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[431], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/alert-rule-suggestion</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotAlertRuleSuggestionAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[432], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/alert-rule-suggestion/estimate</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotAlertRuleSuggestionEstimateAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[433], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/chat</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotChatAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[434], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/chat/stream</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotChatStreamAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[435], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/execute</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotExecuteAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[436], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/execution/{executionId}/pause</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotExecutionByExecutionIdPauseAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[437], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/execution/{executionId}/resume</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotExecutionByExecutionIdResumeAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[438], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/execution/{executionId}/rollback</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotExecutionByExecutionIdRollbackAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[439], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/export/{versionId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotExportByVersionIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[440], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/export/github</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotExportGithubAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[441], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/feedback</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotFeedbackAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[442], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/generation/{manifestId}/cancel</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotGenerationByManifestIdCancelAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[443], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/git/branch</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotGitBranchAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[444], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/git/clone</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotGitCloneAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[445], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/git/commit</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotGitCommitAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[446], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/git/init</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotGitInitAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[447], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/git/pull</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotGitPullAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[448], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/git/push</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotGitPushAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[449], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/git/write</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotGitWriteAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[450], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/job</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotJobAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[451], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/job/{jobId}/cancel</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotJobByJobIdCancelAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[452], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/job/{jobId}/retry</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotJobByJobIdRetryAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[453], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/manifest/{manifestId}/pause</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotManifestByManifestIdPauseAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[454], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/memories/{memoryId}/promote</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotMemoriesByMemoryIdPromoteAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[455], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/rate/{messageId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotRateByMessageIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[456], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/session/{sessionId}/artifact-body</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotSessionBySessionIdArtifactBodyAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[457], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/session/{sessionId}/brainstorm/stop</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotSessionBySessionIdBrainstormStopAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[458], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/session/{sessionId}/workspace/env</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotSessionBySessionIdWorkspaceEnvAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[459], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/session/{sessionId}/workspace/fix</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotSessionBySessionIdWorkspaceFixAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[460], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/session/{sessionId}/workspace/heartbeat</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotSessionBySessionIdWorkspaceHeartbeatAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[461], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/session/{sessionId}/workspace/install</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotSessionBySessionIdWorkspaceInstallAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[462], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/session/{sessionId}/workspace/prepare</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotSessionBySessionIdWorkspacePrepareAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[463], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/session/{sessionId}/workspace/release</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotSessionBySessionIdWorkspaceReleaseAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[464], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/session/{sessionId}/workspace/repairs/apply</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotSessionBySessionIdWorkspaceRepairsApplyAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[465], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/session/{sessionId}/workspace/restore</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotSessionBySessionIdWorkspaceRestoreAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[466], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/session/{sessionId}/workspace/run</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotSessionBySessionIdWorkspaceRunAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[467], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/session/{sessionId}/workspace/stop</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotSessionBySessionIdWorkspaceStopAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[468], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/sessions</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotSessionsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[469], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/table-filters</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotTableFiltersAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[470], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/table-filters/estimate</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotTableFiltersEstimateAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[471], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/ai/copilot/training-consent/{sessionId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAiCopilotTrainingConsentBySessionIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[472], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/alert-rules/project/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAlertRulesProjectByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[473], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/account-setup</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthAccountSetupAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[474], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/account-setup/check</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthAccountSetupCheckAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[475], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/cli/authorize</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthCliAuthorizeAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[476], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/cli/callback</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthCliCallbackAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[477], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/cli/deny</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthCliDenyAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[478], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/cli/login</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthCliLoginAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[479], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/cli/requests/check</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthCliRequestsCheckAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[480], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/cli/token</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthCliTokenAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[481], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/forgot-password</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthForgotPasswordAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[482], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/login</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthLoginAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[483], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/logout</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthLogoutAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[484], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/logout-all</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthLogoutAllAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[485], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/me/linked-accounts/{provider}/start</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthMeLinkedAccountsByProviderStartAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[486], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/mfa/disable</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthMfaDisableAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[487], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/mfa/enroll-confirm</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthMfaEnrollConfirmAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[488], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/mfa/enroll-start</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthMfaEnrollStartAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[489], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/mfa/regenerate-codes</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthMfaRegenerateCodesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[490], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/mfa/verify</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthMfaVerifyAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[491], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/reauthenticate</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthReauthenticateAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[492], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/refresh</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthRefreshAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[493], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/reset-password</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthResetPasswordAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[494], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/reset-password/check</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthResetPasswordCheckAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[495], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/session/device</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthSessionDeviceAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[496], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/session/token</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthSessionTokenAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[497], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/signup</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthSignupAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[498], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/sso/restart</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthSsoRestartAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[499], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/tenant/handoff</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthTenantHandoffAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[500], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/tenant/login</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthTenantLoginAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[501], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/tenant/logout</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthTenantLogoutAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[502], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/tenant/mfa/verify</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthTenantMfaVerifyAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[503], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/tenant/refresh</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthTenantRefreshAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[504], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/tenant/sso/start</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthTenantSsoStartAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[505], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/verify-email/confirm</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthVerifyEmailConfirmAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[506], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/verify-email/resend</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthVerifyEmailResendAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[507], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/auth/verify-email/send</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostAuthVerifyEmailSendAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[508], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/billing/checkout</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostBillingCheckoutAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[509], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/billing/enterprise/inquiry</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostBillingEnterpriseInquiryAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[510], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/billing/hosting/checkout</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostBillingHostingCheckoutAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[511], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/billing/org/{orgId}/addons</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostBillingOrgByOrgIdAddonsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[512], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/billing/org/{orgId}/addons/{addonId}/preview</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostBillingOrgByOrgIdAddonsByAddonIdPreviewAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[513], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/billing/org/{orgId}/addons/preview</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostBillingOrgByOrgIdAddonsPreviewAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[514], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/billing/org/{orgId}/cancel</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostBillingOrgByOrgIdCancelAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[515], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/billing/org/{orgId}/card-check/confirm</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostBillingOrgByOrgIdCardCheckConfirmAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[516], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/billing/org/{orgId}/card-check/session</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostBillingOrgByOrgIdCardCheckSessionAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[517], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/billing/org/{orgId}/change-plan</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostBillingOrgByOrgIdChangePlanAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[518], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/billing/org/{orgId}/change-plan/preview</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostBillingOrgByOrgIdChangePlanPreviewAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[519], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/billing/org/{orgId}/contacts</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostBillingOrgByOrgIdContactsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[520], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/billing/org/{orgId}/credits/purchase</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostBillingOrgByOrgIdCreditsPurchaseAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[521], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/billing/org/{orgId}/pause</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostBillingOrgByOrgIdPauseAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[522], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/billing/org/{orgId}/portal</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostBillingOrgByOrgIdPortalAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[523], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/billing/org/{orgId}/reactivate</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostBillingOrgByOrgIdReactivateAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[524], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/billing/org/{orgId}/resume</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostBillingOrgByOrgIdResumeAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[525], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/billing/org/{orgId}/usage-alerts</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostBillingOrgByOrgIdUsageAlertsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[526], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/billing/promo-codes/validate</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostBillingPromoCodesValidateAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[527], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/billing/redeem-promo</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostBillingRedeemPromoAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[528], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/billing/webhook</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostBillingWebhookAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[529], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/buckets/{bucketId}/signed-url</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostBucketsByBucketIdSignedUrlAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[530], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/buckets/{bucketId}/upload</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostBucketsByBucketIdUploadAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[531], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/buckets/{bucketId}/upload-url</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostBucketsByBucketIdUploadUrlAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[532], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/contact</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostContactAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[533], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/database/connector/{projectId}/query</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostDatabaseConnectorByProjectIdQueryAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[534], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/database/connector/{projectId}/test</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostDatabaseConnectorByProjectIdTestAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[535], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/database/extensions/project/{projectId}/install</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostDatabaseExtensionsProjectByProjectIdInstallAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[536], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/database/wrappers/project/{projectId}/install</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostDatabaseWrappersProjectByProjectIdInstallAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[537], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/deployments/{deploymentId}/rollback</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostDeploymentsByDeploymentIdRollbackAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[538], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/deployments/promote</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostDeploymentsPromoteAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[539], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/deployments/tokens</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostDeploymentsTokensAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[540], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/deployments/tokens/{tokenId}/revoke</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostDeploymentsTokensByTokenIdRevokeAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[541], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/deployments/trigger</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostDeploymentsTriggerAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[542], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/docs/feedback</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostDocsFeedbackAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[543], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/docs/search-click</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostDocsSearchClickAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[544], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/enterprise/inquire</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostEnterpriseInquireAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[545], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/enterprise/quotes/{quoteId}/accept</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostEnterpriseQuotesByQuoteIdAcceptAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[546], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/entitlements/org/{orgId}/check</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostEntitlementsOrgByOrgIdCheckAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[547], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/functions</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostFunctionsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[548], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/functions/{functionIdOrName}/invoke</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostFunctionsByFunctionIdOrNameInvokeAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[549], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/functions/{functionId}/triggers</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostFunctionsByFunctionIdTriggersAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[550], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/functions/secrets</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostFunctionsSecretsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[551], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/generated/{table}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostGeneratedByTableAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[552], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/generated/{table}/bulk</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostGeneratedByTableBulkAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[553], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/generated/{table}/query</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostGeneratedByTableQueryAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[554], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/incidents</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostIncidentsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[555], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/incidents/bulk</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostIncidentsBulkAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[556], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/incidents/{incidentId}/ack</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostIncidentsByIncidentIdAckAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[557], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/incidents/{incidentId}/resolve</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostIncidentsByIncidentIdResolveAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[558], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/infrastructure/poll-status</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostInfrastructurePollStatusAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[559], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/integrations/deliveries/{deliveryId}/retry</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostIntegrationsDeliveriesByDeliveryIdRetryAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[560], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/integrations/subscriptions</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostIntegrationsSubscriptionsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[561], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/integrations/subscriptions/{id}/test</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostIntegrationsSubscriptionsByIdTestAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[562], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mcp/audit</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMcpAuditAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[563], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mcp/oauth/register</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMcpOauthRegisterAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[564], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mcp/oauth/requests/{requestId}/approve</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMcpOauthRequestsByRequestIdApproveAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[565], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mcp/oauth/requests/{requestId}/deny</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMcpOauthRequestsByRequestIdDenyAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[566], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mcp/oauth/revoke</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMcpOauthRevokeAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[567], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mcp/oauth/token</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMcpOauthTokenAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[568], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/me/early/welcome-seen</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMeEarlyWelcomeSeenAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[569], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mongodb/{collection}/aggregate</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMongodbByCollectionAggregateAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[570], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mongodb/{collection}/aggregate/cursor</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMongodbByCollectionAggregateCursorAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[571], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mongodb/{collection}/bulkWrite</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMongodbByCollectionBulkWriteAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[572], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mongodb/{collection}/count</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMongodbByCollectionCountAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[573], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mongodb/{collection}/cursor/{cursorId}/close</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMongodbByCollectionCursorByCursorIdCloseAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[574], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mongodb/{collection}/cursor/{cursorId}/next</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMongodbByCollectionCursorByCursorIdNextAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[575], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mongodb/{collection}/deleteMany</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMongodbByCollectionDeleteManyAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[576], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mongodb/{collection}/deleteOne</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMongodbByCollectionDeleteOneAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[577], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mongodb/{collection}/distinct</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMongodbByCollectionDistinctAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[578], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mongodb/{collection}/find</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMongodbByCollectionFindAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[579], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mongodb/{collection}/find/cursor</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMongodbByCollectionFindCursorAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[580], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mongodb/{collection}/findOne</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMongodbByCollectionFindOneAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[581], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mongodb/{collection}/findOneAndDelete</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMongodbByCollectionFindOneAndDeleteAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[582], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mongodb/{collection}/findOneAndReplace</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMongodbByCollectionFindOneAndReplaceAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[583], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mongodb/{collection}/findOneAndUpdate</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMongodbByCollectionFindOneAndUpdateAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[584], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mongodb/{collection}/indexes</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMongodbByCollectionIndexesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[585], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mongodb/{collection}/insertMany</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMongodbByCollectionInsertManyAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[586], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mongodb/{collection}/insertOne</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMongodbByCollectionInsertOneAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[587], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mongodb/{collection}/replaceOne</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMongodbByCollectionReplaceOneAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[588], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mongodb/{collection}/updateMany</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMongodbByCollectionUpdateManyAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[589], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mongodb/{collection}/updateOne</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMongodbByCollectionUpdateOneAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[590], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mongodb/collections</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMongodbCollectionsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[591], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mongodb/collections/{name}/rename</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMongodbCollectionsByNameRenameAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[592], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/mongodb/command</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostMongodbCommandAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[593], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/oauth/callback</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostOauthCallbackAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[594], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/oauth/org/{orgId}/configure</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostOauthOrgByOrgIdConfigureAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[595], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/oauth/org/{orgId}/provider/{provider}/refresh</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostOauthOrgByOrgIdProviderByProviderRefreshAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[596], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/onboarding/org/{orgId}/auto-setup</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostOnboardingOrgByOrgIdAutoSetupAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[597], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/onboarding/org/{orgId}/complete-step</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostOnboardingOrgByOrgIdCompleteStepAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[598], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/orgs</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostOrgsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[599], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/orgs/{orgId}/change-requests</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostOrgsByOrgIdChangeRequestsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[600], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/orgs/{orgId}/invites/{inviteId}/resend</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostOrgsByOrgIdInvitesByInviteIdResendAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[601], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/orgs/{orgId}/leave-requests</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostOrgsByOrgIdLeaveRequestsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[602], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/orgs/{orgId}/leave-requests/{requestId}/approve</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostOrgsByOrgIdLeaveRequestsByRequestIdApproveAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[603], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/orgs/{orgId}/leave-requests/{requestId}/decline</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostOrgsByOrgIdLeaveRequestsByRequestIdDeclineAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[604], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/orgs/{orgId}/members/invite</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostOrgsByOrgIdMembersInviteAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[605], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/orgs/{orgId}/support/tickets</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostOrgsByOrgIdSupportTicketsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[606], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/orgs/{orgId}/support/tickets/{number}/messages</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostOrgsByOrgIdSupportTicketsByNumberMessagesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[607], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/orgs/{orgId}/support/tickets/{number}/reopen</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostOrgsByOrgIdSupportTicketsByNumberReopenAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[608], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/orgs/{orgId}/support/tickets/{number}/resolve</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostOrgsByOrgIdSupportTicketsByNumberResolveAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[609], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/orgs/{orgId}/transfer</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostOrgsByOrgIdTransferAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[610], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/orgs/{orgId}/transfers/{id}/resend</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostOrgsByOrgIdTransfersByIdResendAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[611], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/orgs/first</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostOrgsFirstAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[612], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/orgs/invites/accept</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostOrgsInvitesAcceptAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[613], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/orgs/invites/decline</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostOrgsInvitesDeclineAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[614], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/orgs/transfers/accept</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostOrgsTransfersAcceptAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[615], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/orgs/transfers/decline</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostOrgsTransfersDeclineAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[616], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/plans/apply</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostPlansApplyAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[617], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/plans/save</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostPlansSaveAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[618], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[619], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/api-keys</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdApiKeysAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[620], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/api-keys/{keyId}/reveal</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdApiKeysByKeyIdRevealAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[621], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/api-keys/{keyId}/revoke</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdApiKeysByKeyIdRevokeAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[622], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/api-keys/{keyId}/rotate</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdApiKeysByKeyIdRotateAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[623], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/api-keys/split</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdApiKeysSplitAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[624], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/auth/forgot-password</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdAuthForgotPasswordAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[625], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/auth/login</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdAuthLoginAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[626], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/auth/logout</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdAuthLogoutAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[627], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/auth/magic/send</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdAuthMagicSendAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[628], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/auth/mfa/disable</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdAuthMfaDisableAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[629], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/auth/mfa/enroll-confirm</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdAuthMfaEnrollConfirmAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[630], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/auth/mfa/enroll-start</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdAuthMfaEnrollStartAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[631], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/auth/mfa/regenerate-codes</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdAuthMfaRegenerateCodesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[632], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/auth/mfa/verify</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdAuthMfaVerifyAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[633], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/auth/oauth/{provider}/start</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdAuthOauthByProviderStartAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[634], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/auth/oauth/token</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdAuthOauthTokenAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[635], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/auth/refresh</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdAuthRefreshAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[636], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/auth/reset-password</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdAuthResetPasswordAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[637], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/auth/signup</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdAuthSignupAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[638], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/auth/sync-users</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdAuthSyncUsersAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[639], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/auth/verify-email/confirm</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdAuthVerifyEmailConfirmAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[640], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/auth/verify-email/send</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdAuthVerifyEmailSendAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[641], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/branches</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdBranchesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[642], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/database/dedicated</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdDatabaseDedicatedAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[643], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/database/dedicated/restart</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdDatabaseDedicatedRestartAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[644], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/db/reset</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdDbResetAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[645], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/env-vars</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdEnvVarsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[646], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/environments</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdEnvironmentsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[647], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/environments/backfill-urls</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdEnvironmentsBackfillUrlsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[648], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/environments/bootstrap</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdEnvironmentsBootstrapAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[649], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/environments/{envId}/domains/{domainId}/verify</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdEnvironmentsByEnvIdDomainsByDomainIdVerifyAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[650], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/environments/{envId}/provision-ssl</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdEnvironmentsByEnvIdProvisionSslAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[651], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/environments/{envId}/verify-cname</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdEnvironmentsByEnvIdVerifyCnameAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[652], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/environments/{envId}/verify-domain</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdEnvironmentsByEnvIdVerifyDomainAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[653], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/github/branch</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdGithubBranchAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[654], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/github/connect</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdGithubConnectAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[655], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/github/pull</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdGithubPullAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[656], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/github/push</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdGithubPushAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[657], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/infrastructure/{instanceId}/migrate-now</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdInfrastructureByInstanceIdMigrateNowAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[658], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/infrastructure/{instanceId}/replica</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdInfrastructureByInstanceIdReplicaAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[659], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/infrastructure/{instanceId}/replica-preview</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdInfrastructureByInstanceIdReplicaPreviewAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[660], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/infrastructure/{instanceId}/resize</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdInfrastructureByInstanceIdResizeAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[661], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/infrastructure/{instanceId}/resize-custom</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdInfrastructureByInstanceIdResizeCustomAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[662], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/infrastructure/{instanceId}/start</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdInfrastructureByInstanceIdStartAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[663], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/infrastructure/{instanceId}/stop</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdInfrastructureByInstanceIdStopAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[664], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/infrastructure/{instanceId}/switch</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdInfrastructureByInstanceIdSwitchAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[665], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/infrastructure/included/retry</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdInfrastructureIncludedRetryAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[666], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/infrastructure/migration/retry</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdInfrastructureMigrationRetryAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[667], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/infrastructure/migration/rollback</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdInfrastructureMigrationRollbackAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[668], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/infrastructure/provision</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdInfrastructureProvisionAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[669], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/infrastructure/provision-custom</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdInfrastructureProvisionCustomAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[670], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/infrastructure/provision-preview</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdInfrastructureProvisionPreviewAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[671], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/infrastructure/restores/preview</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdInfrastructureRestoresPreviewAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[672], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/members</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdMembersAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[673], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/promotions</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdPromotionsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[674], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/region</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdRegionAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[675], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/settings/jwt/rotate</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdSettingsJwtRotateAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[676], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/users</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdUsersAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[677], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/users/{userId}/ban</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdUsersByUserIdBanAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[678], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/users/{userId}/send-magic-link</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdUsersByUserIdSendMagicLinkAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[679], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/users/{userId}/sessions/revoke-all</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdUsersByUserIdSessionsRevokeAllAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[680], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/projects/{projectId}/users/{userId}/unban</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostProjectsByProjectIdUsersByUserIdUnbanAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[681], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/realtime/console-token</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostRealtimeConsoleTokenAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[682], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/realtime/enable-all</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostRealtimeEnableAllAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[683], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/realtime/install</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostRealtimeInstallAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[684], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/realtime/token</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostRealtimeTokenAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[685], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/realtime/uninstall</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostRealtimeUninstallAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[686], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/regions</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostRegionsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[687], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/regions/health/check</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostRegionsHealthCheckAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[688], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/rls/policies/{policyId}/toggle</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostRlsPoliciesByPolicyIdToggleAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[689], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/rls/policies/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostRlsPoliciesByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[690], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/schema-engine/analyze/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostSchemaEngineAnalyzeByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[691], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/schema-engine/apply</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostSchemaEngineApplyAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[692], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/schema-engine/editor-sessions/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostSchemaEngineEditorSessionsByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[693], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/schema-engine/editor-sessions/{projectId}/close</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostSchemaEngineEditorSessionsByProjectIdCloseAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[694], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/schema-engine/migrations/{projectId}/{migrationId}/rollback</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostSchemaEngineMigrationsByProjectIdByMigrationIdRollbackAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[695], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/schema-engine/preview</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostSchemaEnginePreviewAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[696], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/schema-engine/push/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostSchemaEnginePushByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[697], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/schema-engine/query/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostSchemaEngineQueryByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[698], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/schema-engine/snippets/{projectId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostSchemaEngineSnippetsByProjectIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[699], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/schemas</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostSchemasAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[700], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/services</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostServicesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[701], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/services/{serviceId}/deploy</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostServicesByServiceIdDeployAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[702], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/services/{serviceId}/domains</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostServicesByServiceIdDomainsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[703], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/services/{serviceId}/domains/{domainId}/verify</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostServicesByServiceIdDomainsByDomainIdVerifyAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[704], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/services/{serviceId}/git/connect</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostServicesByServiceIdGitConnectAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[705], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/services/{serviceId}/promote</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostServicesByServiceIdPromoteAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[706], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/services/{serviceId}/rollback</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostServicesByServiceIdRollbackAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[707], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/services/{serviceId}/stop</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostServicesByServiceIdStopAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[708], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/sso/org/{orgId}/configure</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostSsoOrgByOrgIdConfigureAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[709], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/sso/org/{orgId}/connections/{connectionId}/certificates</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostSsoOrgByOrgIdConnectionsByConnectionIdCertificatesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[710], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/sso/org/{orgId}/connections/{connectionId}/certificates/{certId}/promote</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostSsoOrgByOrgIdConnectionsByConnectionIdCertificatesByCertIdPromoteAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[711], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/sso/org/{orgId}/connections/{connectionId}/disable</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostSsoOrgByOrgIdConnectionsByConnectionIdDisableAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[712], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/sso/org/{orgId}/connections/{connectionId}/enable</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostSsoOrgByOrgIdConnectionsByConnectionIdEnableAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[713], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/sso/org/{orgId}/connections/{connectionId}/metadata/import</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostSsoOrgByOrgIdConnectionsByConnectionIdMetadataImportAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[714], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/sso/org/{orgId}/connections/{connectionId}/release-account</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostSsoOrgByOrgIdConnectionsByConnectionIdReleaseAccountAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[715], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/sso/org/{orgId}/connections/{connectionId}/scim/tokens</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostSsoOrgByOrgIdConnectionsByConnectionIdScimTokensAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[716], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/sso/org/{orgId}/connections/{connectionId}/test</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostSsoOrgByOrgIdConnectionsByConnectionIdTestAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[717], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/sso/org/{orgId}/connections/{connectionId}/verify-domain</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostSsoOrgByOrgIdConnectionsByConnectionIdVerifyDomainAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[718], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/sso/org/{orgId}/outside-members/blocked/{userId}/restore</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostSsoOrgByOrgIdOutsideMembersBlockedByUserIdRestoreAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[719], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/status/subscribe</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostStatusSubscribeAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[720], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/storage/buckets</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostStorageBucketsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[721], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/storage/buckets/{bucketId}/policies</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostStorageBucketsByBucketIdPoliciesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[722], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/storage/buckets/{bucketId}/policies/{policyId}/toggle</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostStorageBucketsByBucketIdPoliciesByPolicyIdToggleAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[723], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/storage/buckets/{bucketId}/policies/simulate</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostStorageBucketsByBucketIdPoliciesSimulateAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[724], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/storage/download-url</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostStorageDownloadUrlAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[725], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/storage/files/copy</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostStorageFilesCopyAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[726], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/storage/files/delete-batch</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostStorageFilesDeleteBatchAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[727], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/storage/files/move</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostStorageFilesMoveAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[728], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/storage/multipart/{uploadId}/abort</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostStorageMultipartByUploadIdAbortAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[729], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/storage/multipart/{uploadId}/complete</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostStorageMultipartByUploadIdCompleteAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[730], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/storage/multipart/{uploadId}/part-url</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostStorageMultipartByUploadIdPartUrlAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[731], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/storage/multipart/create</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostStorageMultipartCreateAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[732], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/storage/multipart/resume</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostStorageMultipartResumeAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[733], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/storage/upload</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostStorageUploadAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[734], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/storage/upload-base64</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostStorageUploadBase64Async(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[735], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/storage/upload-from-url</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostStorageUploadFromUrlAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[736], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/storage/upload-url</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostStorageUploadUrlAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[737], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/templates</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostTemplatesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[738], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/templates/create-project</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostTemplatesCreateProjectAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[739], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/templates/from-project</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostTemplatesFromProjectAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[740], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/templates/from-project/preview</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostTemplatesFromProjectPreviewAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[741], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/templates/install/apply</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostTemplatesInstallApplyAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[742], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/templates/install/{installId}/rollback</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostTemplatesInstallByInstallIdRollbackAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[743], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/templates/install/preview</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostTemplatesInstallPreviewAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[744], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/users/me/change-password</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostUsersMeChangePasswordAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[745], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/users/me/request-account-delete</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostUsersMeRequestAccountDeleteAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[746], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/v1/data/{projectId}/{table}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostV1DataByProjectIdByTableAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[747], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/v1/data/{projectId}/{table}/bulk</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostV1DataByProjectIdByTableBulkAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[748], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/v1/data/{projectId}/{table}/query</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostV1DataByProjectIdByTableQueryAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[749], request, cancellationToken);

    /// <summary>Sends a POST request to <c>/webhooks/github</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PostWebhooksGithubAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[750], request, cancellationToken);

    /// <summary>Sends a PUT request to <c>/ai/copilot/session/{sessionId}/editor-files</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PutAiCopilotSessionBySessionIdEditorFilesAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[751], request, cancellationToken);

    /// <summary>Sends a PUT request to <c>/alert-rules/{ruleId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PutAlertRulesByRuleIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[752], request, cancellationToken);

    /// <summary>Sends a PUT request to <c>/billing/org/{orgId}/credits/auto-topup</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PutBillingOrgByOrgIdCreditsAutoTopupAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[753], request, cancellationToken);

    /// <summary>Sends a PUT request to <c>/billing/org/{orgId}/founder/wall</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PutBillingOrgByOrgIdFounderWallAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[754], request, cancellationToken);

    /// <summary>Sends a PUT request to <c>/billing/org/{orgId}/tax-info</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PutBillingOrgByOrgIdTaxInfoAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[755], request, cancellationToken);

    /// <summary>Sends a PUT request to <c>/buckets/{bucketId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PutBucketsByBucketIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[756], request, cancellationToken);

    /// <summary>Sends a PUT request to <c>/functions/{functionId}/schedule</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PutFunctionsByFunctionIdScheduleAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[757], request, cancellationToken);

    /// <summary>Sends a PUT request to <c>/functions/{functionId}/source</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PutFunctionsByFunctionIdSourceAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[758], request, cancellationToken);

    /// <summary>Sends a PUT request to <c>/functions/secrets/{secretId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PutFunctionsSecretsBySecretIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[759], request, cancellationToken);

    /// <summary>Sends a PUT request to <c>/me/console-look</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PutMeConsoleLookAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[760], request, cancellationToken);

    /// <summary>Sends a PUT request to <c>/me/early/wall</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PutMeEarlyWallAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[761], request, cancellationToken);

    /// <summary>Sends a PUT request to <c>/projects/{projectId}/auth/oauth-apps/{provider}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PutProjectsByProjectIdAuthOauthAppsByProviderAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[762], request, cancellationToken);

    /// <summary>Sends a PUT request to <c>/projects/{projectId}/environments/promotion-order</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PutProjectsByProjectIdEnvironmentsPromotionOrderAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[763], request, cancellationToken);

    /// <summary>Sends a PUT request to <c>/projects/{projectId}/frontend</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PutProjectsByProjectIdFrontendAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[764], request, cancellationToken);

    /// <summary>Sends a PUT request to <c>/projects/{projectId}/getting-started/hidden</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PutProjectsByProjectIdGettingStartedHiddenAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[765], request, cancellationToken);

    /// <summary>Sends a PUT request to <c>/projects/{projectId}/members</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PutProjectsByProjectIdMembersAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[766], request, cancellationToken);

    /// <summary>Sends a PUT request to <c>/projects/{projectId}/members/{userId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PutProjectsByProjectIdMembersByUserIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[767], request, cancellationToken);

    /// <summary>Sends a PUT request to <c>/sso/org/{orgId}/connections/{connectionId}/break-glass</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PutSsoOrgByOrgIdConnectionsByConnectionIdBreakGlassAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[768], request, cancellationToken);

    /// <summary>Sends a PUT request to <c>/sso/org/{orgId}/connections/{connectionId}/group-mappings</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PutSsoOrgByOrgIdConnectionsByConnectionIdGroupMappingsAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[769], request, cancellationToken);

    /// <summary>Sends a PUT request to <c>/sso/org/{orgId}/connections/{connectionId}/require</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PutSsoOrgByOrgIdConnectionsByConnectionIdRequireAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[770], request, cancellationToken);

    /// <summary>Sends a PUT request to <c>/sso/org/{orgId}/outside-members/allow</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PutSsoOrgByOrgIdOutsideMembersAllowAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[771], request, cancellationToken);

    /// <summary>Sends a PUT request to <c>/sso/org/{orgId}/outside-members/policy</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PutSsoOrgByOrgIdOutsideMembersPolicyAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[772], request, cancellationToken);

    /// <summary>Sends a PUT request to <c>/sso/org/{orgId}/security-contact</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PutSsoOrgByOrgIdSecurityContactAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[773], request, cancellationToken);

    /// <summary>Sends a PUT request to <c>/storage/buckets/{bucketId}/policies/{policyId}</c>. Dispose the returned response.</summary>
    /// <param name="request">Path values, query values, headers, and optional request body.</param>
    /// <param name="cancellationToken">Cancels the request and response read.</param>
    /// <returns>The response owned by the caller, with parsed JSON when applicable.</returns>
    public Task<OperationResponse> PutStorageBucketsByBucketIdPoliciesByPolicyIdAsync(OperationRequest? request = null, CancellationToken cancellationToken = default) =>
        CallAsync(All[774], request, cancellationToken);
}
