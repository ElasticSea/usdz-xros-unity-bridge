import os
import sys
import subprocess

if len(sys.argv) < 2:
    print("Usage: python build.py <USD_ROOT_PATH> [platform]")
    print("  platform: win64 (default), visionOS")
    sys.exit(1)

USD_ROOT = sys.argv[1]
platform = sys.argv[2] if len(sys.argv) >= 3 else "win64"

build_dir = f"build_{platform}"
if not os.path.exists(build_dir):
    os.makedirs(build_dir)

os.chdir(build_dir)

cmake_cmd = ["cmake"]

if platform == "visionOS":
    # Must run this on macOS with Xcode + visionOS SDK installed
    cmake_cmd += [
        "-G", "Xcode",
        "-DCMAKE_SYSTEM_NAME=visionOS",
        "-DCMAKE_OSX_SYSROOT=xros",
        "-DCMAKE_OSX_ARCHITECTURES=arm64",
        "-DCMAKE_OSX_DEPLOYMENT_TARGET=1.0",

        # Disable code signing
        "-DCMAKE_XCODE_ATTRIBUTE_CODE_SIGNING_ALLOWED=NO",
        "-DCMAKE_XCODE_ATTRIBUTE_CODE_SIGNING_REQUIRED=NO",
        "-DCMAKE_XCODE_ATTRIBUTE_CODE_SIGN_IDENTITY=",

        f"-DUSD_ROOT={USD_ROOT}",
        "..",
    ]
elif platform == "win64":
    # Generic Windows host build
    cmake_cmd += [
        f"-DUSD_ROOT={USD_ROOT}",
        "..",
    ]
else:
    print(f"Unknown platform: {platform}")
    sys.exit(1)

# Configure
subprocess.check_call(cmake_cmd)

# Build
build_cmd = [
    "cmake",
    "--build", ".",
    "--config", "RelWithDebInfo"
]

subprocess.check_call(build_cmd)
