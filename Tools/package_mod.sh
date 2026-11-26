#!/usr/bin/env bash
set -euo pipefail

ROOT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")/.." && pwd)"
cd "$ROOT_DIR"

if ! command -v dotnet >/dev/null 2>&1; then
    if [[ -x "/usr/local/share/dotnet/dotnet" ]]; then
        export PATH="/usr/local/share/dotnet:$PATH"
    else
        echo "Error: dotnet CLI not found." >&2
        exit 1
    fi
fi

VERSION="$(python3 -c '
import re, sys
txt = open("GalacticScale3.csproj", encoding="utf-8").read()
m = re.search(r"<Version>(\d+\.\d+\.\d+)</Version>", txt)
if not m:
    sys.exit(1)
print(m.group(1))
')"

if [[ ! "$VERSION" =~ ^([0-9]+)\.([0-9]+)\.([0-9]+)$ ]]; then
    echo "Error: Invalid semver '$VERSION' in GalacticScale3.csproj" >&2
    exit 1
fi

MAJOR="${BASH_REMATCH[1]}"
MINOR="${BASH_REMATCH[2]}"
PATCH="${BASH_REMATCH[3]}"
VERSION_CODE=$(( MAJOR * 1000000 + MINOR * 1000 + PATCH ))

# Verify version consistency across Bootstrap.cs and thunderstore.toml
python3 - "$VERSION" <<'PY'
import re, sys
ver = sys.argv[1]
boot = open("Bootstrap.cs", encoding="utf-8").read()
if f'"{ver}"' not in boot:
    raise SystemExit(f"Version mismatch in Bootstrap.cs (expected {ver})")
toml = open("thunderstore.toml", encoding="utf-8").read()
if f'versionNumber = "{ver}"' not in toml:
    raise SystemExit(f"Version mismatch in thunderstore.toml (expected {ver})")
PY

echo "Building Release for GalacticScale v${VERSION} (versionCode=${VERSION_CODE})..."
dotnet build GalacticScale3.csproj -c Release

DLL_PATH="bin/Release/GalacticScale.dll"
if [[ ! -f "$DLL_PATH" ]]; then
    echo "Error: Built DLL not found at $DLL_PATH" >&2
    exit 1
fi

# Verify embedded resources exist in the compiled Release binary
python3 - "$DLL_PATH" <<'PY'
import sys
data = open(sys.argv[1], "rb").read()
for marker in (b"GalacticScale.Assets.constellations.json", b"GalacticScale.Translations.zh-CN.tsv"):
    if marker not in data:
        raise SystemExit(f"Missing embedded resource marker in {sys.argv[1]}: {marker!r}")
print("Verified embedded resources in Release DLL.")
PY

mkdir -p dist
ZIP_NAME="Galactic_Scale-GalacticScale-${VERSION}.zip"
ZIP_PATH="dist/${ZIP_NAME}"
SHA_PATH="${ZIP_PATH}.sha256"

# Extract metadata from thunderstore.toml and build Thunderstore/r2modman V1 zip
python3 - "$ZIP_PATH" "$VERSION" <<'PY'
import json, os, re, sys, zipfile

zip_path, version = sys.argv[1:3]
toml = open("thunderstore.toml", encoding="utf-8").read()

def get_toml_str(key, default=""):
    m = re.search(rf'^{key}\s*=\s*"([^"]*)"', toml, re.M)
    return m.group(1) if m else default

desc = get_toml_str("description", f"v{version} GalacticScale")[:250]
url = get_toml_str("websiteUrl", "https://downloads.kimily.ch/galactic-scale/")

manifest = {
    "name": "GalacticScale",
    "version_number": version,
    "website_url": url,
    "description": desc,
    "dependencies": [
        "xiaoye97-BepInEx-5.4.17",
        "crecheng-CloseError-1.0.0"
    ],
}

files = [
    ("Package/icon.png", "icon.png"),
    ("Package/README.md", "README.md"),
    ("Package/3rdPartyLicenses.md", "3rdPartyLicenses.md"),
    ("bin/Release/GalacticScale.dll", "GalacticScale.dll"),
    ("Package/GSUI.dll", "GSUI.dll"),
    ("Package/galacticbundle", "galacticbundle"),
]

for src, _ in files:
    if not os.path.isfile(src):
        raise SystemExit(f"Missing package file: {src}")

tmp_zip = zip_path + ".tmp"
with zipfile.ZipFile(tmp_zip, "w", compression=zipfile.ZIP_DEFLATED, compresslevel=9) as zf:
    zf.writestr("manifest.json", json.dumps(manifest, indent=2) + "\n")
    for src, arcname in files:
        zf.write(src, arcname=arcname)

os.replace(tmp_zip, zip_path)
PY

SHA256="$(shasum -a 256 "$ZIP_PATH" | awk '{print $1}')"
printf "%s  %s\n" "$SHA256" "$ZIP_NAME" > "$SHA_PATH"

echo "Packaged: $ROOT_DIR/$ZIP_PATH"
echo "SHA-256:  $SHA256"
echo "Version:  $VERSION (code: $VERSION_CODE)"
