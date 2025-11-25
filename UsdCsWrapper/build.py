import os
import sys
import subprocess

if len(sys.argv) < 2:
    print("Usage: python build.py <USD_ROOT_PATH>")
    sys.exit(1)

USD_ROOT = sys.argv[1]

# Create build directory
if not os.path.exists("build"):
    os.makedirs("build")

os.chdir("build")

# Configure
subprocess.check_call([
    "cmake",
    f"-DUSD_ROOT={USD_ROOT}",
    ".."
])

# Build
subprocess.check_call([
    "cmake",
    "--build", ".",
    "--config", "RelWithDebInfo"
])
