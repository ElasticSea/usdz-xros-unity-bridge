## Build USD
win
```bash
python build_scripts/build_usd.py ./build_win64 --no-python --no-tests --no-examples --no-tutorials --build-monolithic
```
xros
```bash
python3 build_scripts/build_usd.py ./build_xros --build-target visionOS --no-python --no-materialx --no-tests --no-imaging --no-usdview --no-examples --no-tutorials --build-args=TBB,extra_inc=big_iron.inc
```

## Build Wrapper
win
```bash
python build.py D:/ElasticSea/OpenUSD/build_win64 win64 D:/ElasticSea/blockworks/Packages/com.unity.usd.core@a7855ade4aa6/Runtime/Plugins/x86_64/Windows/lib
copy /Y "D:\ElasticSea\usdz-xros-unity-bridge\UsdCsWrapper\build\RelWithDebInfo\UsdCs.dll" "D:\ElasticSea\blockworks\Packages\com.unity.usd.core@a7855ade4aa6\Runtime\Plugins\x86_64\Windows\lib\UsdCs.dll"
```
visionos
```bash
python3 build.py /Users/elasticsea/Repo/OpenUSD/build_xros visionOS
copy /Y "/Users/elasticsea/Repo/usdz-xros-unity-bridge/UsdCsWrapper/build_visionOS/RelWithDebInfo-xros/libUsdCs.a" "/Users/elasticsea/Repo/blockworks/Packages/com.unity.usd.core@a7855ade4aa6/Runtime/Plugins/arm64/VisionsOs/libUsdCs.a"
```