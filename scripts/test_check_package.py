import importlib.util
from pathlib import Path
import tempfile
import unittest
import zipfile

spec = importlib.util.spec_from_file_location("check_package", Path(__file__).with_name("check-package.py"))
module = importlib.util.module_from_spec(spec)
spec.loader.exec_module(module)

HEAD = "1234567890123456789012345678901234567890"


class PackageProvenanceTests(unittest.TestCase):
    def package(self, commit=HEAD, url="https://github.com/vaifstudio/vaif-dotnet", json_version="8.0.5",
                copyright="Copyright (c) 2026 VAIF Studio LLC"):
        temporary = tempfile.TemporaryDirectory()
        self.addCleanup(temporary.cleanup)
        path = Path(temporary.name) / "Vaif.Client.1.0.0.nupkg"
        with zipfile.ZipFile(path, "w") as package:
            package.writestr("Vaif.Client.nuspec", (
                '<package xmlns="http://schemas.microsoft.com/packaging/2013/05/nuspec.xsd"><metadata>'
                f'<id>Vaif.Client</id><version>1.0.0</version><copyright>{copyright}</copyright>'
                '<license type="expression">MIT</license>'
                f'<repository type="git" url="{url}" commit="{commit}"/>'
                '<dependencies><group targetFramework="net8.0" /><group targetFramework=".NETStandard2.1">'
                f'<dependency id="System.Text.Json" version="{json_version}" exclude="Build,Analyzers" />'
                '</group></dependencies></metadata></package>'))
            for target in ("net8.0", "netstandard2.1"):
                for extension in ("dll", "xml"):
                    package.writestr(f"lib/{target}/Vaif.Client.{extension}", "fixture")
            for name in ("README.md", "CHANGELOG.md", "LICENSE"):
                package.writestr(name, "fixture")
        return path

    def test_accepts_standalone_head(self):
        module.validate_package(self.package(), HEAD)

    def test_rejects_another_repository_commit(self):
        with self.assertRaisesRegex(ValueError, "commit"):
            module.validate_package(self.package(commit="aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"), HEAD)

    def test_rejects_another_repository_url(self):
        with self.assertRaisesRegex(ValueError, "repository"):
            module.validate_package(self.package(url="https://github.com/example/other"), HEAD)

    def test_rejects_a_dependency_above_the_advisory_free_floor(self):
        with self.assertRaisesRegex(ValueError, "System.Text.Json 8.0.5"):
            module.validate_package(self.package(json_version="8.0.6"), HEAD)

    def test_rejects_a_dependency_with_a_known_advisory(self):
        with self.assertRaisesRegex(ValueError, "System.Text.Json 8.0.5"):
            module.validate_package(self.package(json_version="8.0.4"), HEAD)

    def test_rejects_missing_copyright_owner(self):
        with self.assertRaisesRegex(ValueError, "copyright"):
            module.validate_package(self.package(copyright="VAIF"), HEAD)

    def test_sourcelink_points_at_standalone_head(self):
        module.validate_sourcelink({"documents": {"/_/*": "https://raw.githubusercontent.com/vaifstudio/vaif-dotnet/1234567890123456789012345678901234567890/*"}}, HEAD)

    def test_rejects_sourcelink_from_other_repository(self):
        with self.assertRaisesRegex(ValueError, "SourceLink"):
            module.validate_sourcelink({"documents": {"/_/*": "https://raw.githubusercontent.com/example/other/1234567890123456789012345678901234567890/*"}}, HEAD)

    def test_rejects_absent_sourcelink(self):
        with self.assertRaisesRegex(ValueError, "SourceLink"):
            module.validate_sourcelink({"documents": {}}, HEAD)


if __name__ == "__main__":
    unittest.main()
