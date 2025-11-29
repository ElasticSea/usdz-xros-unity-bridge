import os
import sys
import subprocess
import shutil

if len(sys.argv) < 2:
    print("Usage: python build.py <USD_ROOT_PATH> [platform] [output_dir]")
    print("  platform: win64, visionOS")
    print("  output_dir: optional folder to copy UsdCs.dll into (win64 only)")
    sys.exit(1)

USD_ROOT = sys.argv[1]
platform = sys.argv[2]
output_dir = os.path.abspath(sys.argv[3]) if len(sys.argv) >= 4 else None

orig_cwd = os.getcwd()
build_dir = os.path.join(orig_cwd, f"build_{platform}")
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

# Optional copy step (win64 only)
if output_dir:
    if platform == "win64":
        dll_name = "UsdCs.dll"
        src_path = os.path.join(os.getcwd(), "RelWithDebInfo", dll_name)

        if not os.path.isfile(src_path):
            print(f"ERROR: Built dll not found at: {src_path}")
            sys.exit(1)

        if not os.path.isdir(output_dir):
            os.makedirs(output_dir, exist_ok=True)

        dst_path = os.path.join(output_dir, dll_name)
        shutil.copy2(src_path, dst_path)
        print(f"Copied {src_path} -> {dst_path}")
    else:
        print("NOTE: output_dir was given, but auto-copy is only implemented for win64.")
