import copy
import importlib.util
import json
import subprocess
import tempfile
from pathlib import Path
import unittest
from unittest.mock import patch

spec = importlib.util.spec_from_file_location("audit", Path(__file__).with_name("check-dependencies.py"))
audit = importlib.util.module_from_spec(spec)
spec.loader.exec_module(audit)


class AuditTests(unittest.TestCase):
    def setUp(self):
        self.inventory = {"version": 1, "projects": [
            {"path": "/src/Vaif.Client.csproj", "frameworks": [{"framework": "net8.0"}, {"framework": "netstandard2.1"}]},
            {"path": "/tests/Vaif.Client.Tests.csproj", "frameworks": [{"framework": "net8.0"}]}]}
        self.report = copy.deepcopy(self.inventory)
        self.report["sources"] = [audit.SOURCE]

    def test_accepts_clean_complete_audit(self):
        audit.validate(self.report, self.inventory)

    def test_fails_for_any_vulnerability_including_transitive_low(self):
        for key in ("topLevelPackages", "transitivePackages"):
            with self.subTest(key=key):
                report = copy.deepcopy(self.report)
                report["projects"][0]["frameworks"][1][key] = [{"id": "affected", "resolvedVersion": "1.0", "vulnerabilities": [{"severity": "Low", "advisoryurl": "advisory"}]}]
                with self.assertRaisesRegex(ValueError, "Known dependency vulnerabilities"):
                    audit.validate(report, self.inventory)

    def test_empty_inventory_is_not_a_clean_audit(self):
        self.inventory["projects"][0].pop("frameworks")
        with self.assertRaisesRegex(ValueError, "Incomplete SDK inventory"):
            audit.validate(self.report, self.inventory)

    def test_failed_feed_is_not_a_clean_audit(self):
        self.report["logs"] = [{"level": "error", "message": "Unable to load source"}]
        with self.assertRaisesRegex(ValueError, "could not complete"):
            audit.validate(self.report, self.inventory)

    def test_missing_project_is_not_a_clean_audit(self):
        self.report["projects"].pop()
        with self.assertRaisesRegex(ValueError, "every inventoried project"):
            audit.validate(self.report, self.inventory)

    def test_main_rejects_vulnerabilities_even_when_dotnet_exits_zero(self):
        for key in ("topLevelPackages", "transitivePackages"):
            with self.subTest(key=key), tempfile.TemporaryDirectory() as directory:
                report = copy.deepcopy(self.report)
                report["projects"][0]["frameworks"][1][key] = [{
                    "id": "affected", "resolvedVersion": "1.0",
                    "vulnerabilities": [{"severity": "Low", "advisoryurl": "advisory"}]}]
                results = [subprocess.CompletedProcess([], 0),
                           subprocess.CompletedProcess([], 0, json.dumps(self.inventory), ""),
                           subprocess.CompletedProcess([], 0, json.dumps(report), "")]
                with patch.object(audit, "ROOT", Path(directory)), patch.object(audit.subprocess, "run", side_effect=results):
                    with self.assertRaisesRegex(ValueError, "Known dependency vulnerabilities"):
                        audit.main()

    def test_main_stops_when_restore_fails(self):
        with patch.object(audit.subprocess, "run", side_effect=subprocess.CalledProcessError(1, "dotnet restore")):
            with self.assertRaises(subprocess.CalledProcessError):
                audit.main()

    def test_main_rejects_invalid_json(self):
        results = [subprocess.CompletedProcess([], 0), subprocess.CompletedProcess([], 0, "not json", "")]
        with patch.object(audit.subprocess, "run", side_effect=results):
            with self.assertRaises(ValueError):
                audit.main()


if __name__ == "__main__":
    unittest.main()
