#!/usr/bin/env python3
"""Fail closed on NuGet vulnerabilities or incomplete audit data. Run from any cwd."""
import json
from pathlib import Path
import subprocess
import sys

ROOT = Path(__file__).resolve().parents[1]
SOURCE = "https://api.nuget.org/v3/index.json"


def validate(report, inventory):
    """The inventory proves both SDK frameworks were restored before auditing."""
    for document in (report, inventory):
        if document.get("version") != 1:
            raise ValueError("Unsupported or missing NuGet report version")
        for entry in document.get("logs", []):
            if entry.get("level", "").lower() in ("warning", "error"):
                raise ValueError("NuGet could not complete the dependency audit: " + entry.get("message", "unknown error"))
    projects = inventory.get("projects", [])
    library = next((p for p in projects if Path(p["path"]).name == "Vaif.Client.csproj"), None)
    if library is None or {f["framework"] for f in library.get("frameworks", [])} != {"net8.0", "netstandard2.1"}:
        raise ValueError("Incomplete SDK inventory: restore both target frameworks before scanning")
    if not any(Path(p["path"]).name == "Vaif.Client.Tests.csproj" and p.get("frameworks") for p in projects):
        raise ValueError("Incomplete test dependency inventory")
    if {p["path"] for p in projects} != {p["path"] for p in report.get("projects", [])}:
        raise ValueError("Audit did not cover every inventoried project")
    if report.get("sources") != [SOURCE]:
        raise ValueError("Audit did not use the required NuGet source")
    found = []
    for project in report["projects"]:
        for framework in project.get("frameworks", []):
            for key in ("topLevelPackages", "transitivePackages"):
                for package in framework.get(key, []):
                    for advisory in package.get("vulnerabilities", []):
                        found.append(f'{package["id"]} {package["resolvedVersion"]}: {advisory.get("severity")} {advisory.get("advisoryurl")}')
    if found:
        raise ValueError("Known dependency vulnerabilities:\n" + "\n".join(found))


def run_json(args):
    result = subprocess.run(args, cwd=ROOT, text=True, capture_output=True, check=True, timeout=180)
    if result.stderr.strip():
        raise ValueError("NuGet emitted diagnostics: " + result.stderr.strip())
    return json.loads(result.stdout)


def main():
    # A failed restore must stop the scan. An empty --vulnerable report produced
    # from missing assets is not evidence that dependencies are safe.
    subprocess.run(["dotnet", "restore", "Vaif.Client.sln", "--configfile", "NuGet.Config",
                    "--force", "--disable-parallel", "-m:1", "-nr:false", "-p:NuGetAudit=true", "-p:NuGetAuditMode=all",
                    "-p:NuGetAuditLevel=low", "-p:TreatWarningsAsErrors=true"], cwd=ROOT, check=True, timeout=180)
    inventory = run_json(["dotnet", "list", "Vaif.Client.sln", "package", "--include-transitive", "--format", "json"])
    report = run_json(["dotnet", "list", "Vaif.Client.sln", "package", "--vulnerable", "--include-transitive",
                       "--source", SOURCE, "--format", "json"])
    artifacts = ROOT / "artifacts"
    artifacts.mkdir(exist_ok=True)
    (artifacts / "dependencies.json").write_text(json.dumps(inventory, indent=2) + "\n")
    (artifacts / "vulnerabilities.json").write_text(json.dumps(report, indent=2) + "\n")
    validate(report, inventory)
    print("NuGet dependency audit passed: no known vulnerabilities in the resolved direct/transitive packages.")


if __name__ == "__main__":
    try:
        main()
    except (subprocess.CalledProcessError, subprocess.TimeoutExpired, ValueError, OSError) as error:
        sys.exit("Dependency audit failed or incomplete: " + str(error))
