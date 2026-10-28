# Unity distribution template

Import the compiled netstandard2.1 assembly and its resolved runtime dependencies
as described in [the installation guide](../README.md#unity). Copy `link.xml`
into the application's Assets directory when importing DLLs manually.

This directory contains metadata and stripping configuration. It contains no
runtime DLLs. A Package Manager git install is available only when a release tag
contains the compiled assemblies and their dependency licenses in `Runtime/`.
The source repository alone is not an installable Unity package.

The repository is https://github.com/vaifstudio/vaif-dotnet.
