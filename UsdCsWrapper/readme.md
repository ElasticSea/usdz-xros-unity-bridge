## Build USD
```bash
win
python build_scripts/build_usd.py ./build_win64 --no-python --no-tests --no-examples --no-tutorials --build-monolithic
xros
python3 build_scripts/build_usd.py ./build_xros --no-python --no-materialx --no-tests --usd-imaging --no-usdview --no-examples --no-tutorials --build-monolithic --build-args=TBB,extra_inc=big_iron.inc
```

## Build Wrapper
```bash
win
python build.py D:/ElasticSea/OpenUSD/build_win64
visionos
python3 build.py /Users/elasticsea/Repo/OpenUSD/build_xros visionOS
```

```bash
copy /Y "D:\ElasticSea\usdz-xros-unity-bridge\UsdCsWrapper\build\RelWithDebInfo\UsdCs.dll" "D:\ElasticSea\blockworks\Packages\com.unity.usd.core@a7855ade4aa6\Runtime\Plugins\x86_64\Windows\lib\UsdCs.dll"
```

s