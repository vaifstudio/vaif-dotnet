#!/usr/bin/env python3
"""Keep the compilation fixture identical to README C# samples."""
from pathlib import Path
import re
import sys

root = Path(__file__).resolve().parents[1]
samples = re.findall(r"```csharp\n(.*?)```", (root / "README.md").read_text(), re.S)
expected = "// README examples, compiled by CI. Requires a disposable project to execute.\n" + "\n".join(samples)
if (root / "examples/ReadmeExamples/Program.cs").read_text() != expected:
    sys.exit("README examples changed; update examples/ReadmeExamples/Program.cs before building.")
print(f"README compilation fixture matches all {len(samples)} C# samples.")
