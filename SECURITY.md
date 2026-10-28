# Security policy

Report vulnerabilities privately, through the "Report a vulnerability" form on
this repository's Security tab (GitHub private vulnerability reporting) or by
email to security@vaif.studio. Do not open a public issue or pull request for a
vulnerability. Include the package version, .NET or
Unity version, operating system, impact, and a minimal reproduction. Remove
API keys, access tokens, refresh tokens, and personal data from all material.
Test only projects and accounts you own.

Version 1.0.0 has not been tagged or published. After the first release, security
fixes will be provided in the latest 1.x release; earlier minor and patch releases
will not be maintained separately. Report suspected vulnerabilities in any
version. See [CHANGELOG.md](CHANGELOG.md) for release changes.

The default session store is in memory. Persistent credentials require an
application-provided secure vault. Do not store refresh tokens in PlayerPrefs,
source control, logs, or unencrypted configuration files. Use publishable keys
in distributed applications; keep service-role credentials on trusted servers.

We acknowledge a report within 2 business days and send an initial assessment
within 5 business days. We then investigate affected versions and coordinate
disclosure with the reporter. Good-faith reports following this policy are welcome.

Source and issues: https://github.com/vaifstudio/vaif-dotnet.
