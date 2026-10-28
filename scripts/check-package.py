#!/usr/bin/env python3
"""Verify a package and SourceLink metadata against this repository's clean HEAD."""
import json
from pathlib import Path
import subprocess
import sys
import xml.etree.ElementTree as ET
import zipfile

ROOT = Path(__file__).resolve().parents[1]
REPOSITORY = "https://github.com/vaifstudio/vaif-dotnet"
COPYRIGHT = "Copyright (c) 2026 VAIF Studio LLC"
# The lowest System.Text.Json release with no published advisory (8.0.4 and
# earlier: GHSA-8g4q-xg66-9fp4). NuGet resolves this floor or a later version.
DEPENDENCIES = {"net8.0": set(), ".NETStandard2.1": {("System.Text.Json", "8.0.5")}}


def validate_package(path, head):
    with zipfile.ZipFile(path) as package:
        metadata = ET.fromstring(package.read("Vaif.Client.nuspec"))
        # NuGet emits a default namespace. Normalize it before inspecting metadata.
        for element in metadata.iter():
            element.tag = element.tag.split("}")[-1]
        repository = metadata.find("metadata/repository")
        if repository is None or repository.get("url") != REPOSITORY or repository.get("type") != "git":
            raise ValueError("Package repository must be vaifstudio/vaif-dotnet")
        if repository.get("commit") != head:
            raise ValueError("Package commit does not equal the standalone repository HEAD")
        if metadata.findtext("metadata/id") != "Vaif.Client" or metadata.findtext("metadata/version") != "1.0.0":
            raise ValueError("Unexpected package ID or version")
        if metadata.findtext("metadata/copyright") != COPYRIGHT:
            raise ValueError("Package copyright must name VAIF Studio LLC")
        license = metadata.find("metadata/license")
        if license is None or license.get("type") != "expression" or license.text != "MIT":
            raise ValueError("Package license must be the MIT expression")
        groups = {group.get("targetFramework"): {(d.get("id"), d.get("version")) for d in group.findall("dependency")}
                  for group in metadata.findall("metadata/dependencies/group")}
        if groups != DEPENDENCIES:
            raise ValueError("Package dependencies must be none for net8.0 and System.Text.Json 8.0.5 for netstandard2.1")
        expected = {"README.md", "CHANGELOG.md", "LICENSE"}
        for framework in ("net8.0", "netstandard2.1"):
            expected.update({f"lib/{framework}/Vaif.Client.dll", f"lib/{framework}/Vaif.Client.xml"})
        if not expected.issubset(package.namelist()):
            raise ValueError("Package is missing a target assembly, XML documentation, or public document")


def validate_sourcelink(document, head):
    urls = document.get("documents", {}).values()
    expected = f"https://raw.githubusercontent.com/vaifstudio/vaif-dotnet/{head}/*"
    if not urls or any(url != expected for url in urls):
        raise ValueError("SourceLink must resolve only to this standalone repository HEAD")


def git(*arguments):
    return subprocess.check_output(["git", "-C", str(ROOT), *arguments], text=True).strip()


def main():
    if Path(git("rev-parse", "--show-toplevel")).resolve() != ROOT:
        raise ValueError("Pack and verify from the standalone repository root")
    if git("status", "--porcelain"):
        raise ValueError("Package provenance requires a clean standalone checkout")
    head = git("rev-parse", "HEAD")
    path = Path(sys.argv[1]) if len(sys.argv) == 2 else ROOT / "artifacts/Vaif.Client.1.0.0.nupkg"
    validate_package(path, head)
    for framework in ("net8.0", "netstandard2.1"):
        source = ROOT / f"src/Vaif.Client/obj/Release/{framework}/Vaif.Client.sourcelink.json"
        validate_sourcelink(json.loads(source.read_text()), head)
    symbols = path.with_suffix(".snupkg")
    with zipfile.ZipFile(symbols) as package:
        for framework in ("net8.0", "netstandard2.1"):
            if f"lib/{framework}/Vaif.Client.pdb" not in package.namelist():
                raise ValueError("Symbol package is missing a portable PDB")
    print(f"Package and SourceLink provenance verified for standalone HEAD {head}.")


if __name__ == "__main__":
    try:
        main()
    except (OSError, ValueError, subprocess.CalledProcessError, ET.ParseError, zipfile.BadZipFile, KeyError) as error:
        sys.exit("Package verification failed: " + str(error))
