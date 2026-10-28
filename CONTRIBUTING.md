# Contributing

Report bugs and propose features at
https://github.com/vaifstudio/vaif-dotnet/issues. Include the SDK version, .NET or
Unity version, operating system, expected behavior, and a minimal reproduction.
Remove credentials and personal data. Report vulnerabilities privately as
described in [SECURITY.md](SECURITY.md).

Generated API files are maintained from the VAIF OpenAPI contract. Describe API
contract changes in the issue or pull request so the contract can be updated and
the affected files regenerated. Avoid manual edits to generated files; their
headers identify the source contract hash.

Use .NET SDK 8 and Python 3 for the dependency scan and its xUnit guard test. From this directory:

```sh
python3 scripts/check-readme.py
dotnet restore Vaif.Client.sln --configfile NuGet.Config
dotnet build Vaif.Client.sln -c Release --no-restore
dotnet test tests/Vaif.Client.Tests -c Release -p:SdkTargetFramework=net8.0 --no-restore
dotnet test tests/Vaif.Client.Tests -c Release -p:SdkTargetFramework=netstandard2.1 --no-restore
python3 -m unittest discover -s scripts -p 'test_*.py'
python3 scripts/check-dependencies.py
```

.NET Standard is a library specification, not an executable runtime. The second
test command runs the same xUnit suite on .NET 8 against the netstandard2.1 assembly.
Unity IL2CPP player testing is a separate release check.

Keep changes focused and add a regression test for behavior changes. Async
network APIs must accept CancellationToken. Avoid runtime code generation and
reflection serialization so both target assemblies can be validated with IL2CPP.
README examples are compiled in `examples/ReadmeExamples` by CI. Document every
public type and member in XML; CS1591 is a build error for both SDK targets.

Contributions follow [CODE_OF_CONDUCT.md](CODE_OF_CONDUCT.md) and are licensed
under the repository's [MIT license](LICENSE).
