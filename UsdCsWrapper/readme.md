## Build USD
```bash
python build_scripts/build_usd.py ./build_win64 --no-python --no-tests --no-examples --no-tutorials --build-monolithic
```

## Build Wrapper
```bash
python build.py D:/ElasticSea/OpenUSD/build_win64
```

```bash
copy /Y "D:\ElasticSea\usdz-xros-unity-bridge\UsdCsWrapper\build\RelWithDebInfo\UsdCs.dll" "D:\ElasticSea\blockworks\Packages\com.unity.usd.core@a7855ade4aa6\Runtime\Plugins\x86_64\Windows\lib\UsdCs.dll"
```

