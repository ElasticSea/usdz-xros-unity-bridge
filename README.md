# usdz-xros-unity-bridge
Runtime USDZ export on visionOS (XROS) in Unity. Provides a small native OpenUSD 25.x bridge to create USD stages and write USDZ files directly on device, replacing Unity’s old UsdCs layer.

## Goal
Provide a tiny, portable replacement for Unity’s legacy `UsdCs` native layer so Unity can:

- Create and modify `UsdStage`s
- Define prims and attributes
- Write tokens, values, arrays (`TfToken`, `VtValue`, etc.)
- Save `.usd` and `.usdz` packages at runtime

Works on **Windows (for testing)** and **visionOS (XROS)**.

## Problem Breakdown
- Unity’s USD relies on **OpenUSD 20.08**, which **cannot build** on visionOS.
- XROS SDK lacks several APIs assumed by Pixar's old code (ptrace, signals, some ABI pieces).
- Unity’s SWIG layer expects **~120 specific native symbols** (`CSharp_pxr_*`).
- USD 25.x changes ABI, layout, and signatures—wrapper must normalize differences.
- Need Windows parity to capture the correct behavior of the old UsdCs.
- Need a new, minimal native wrapper that exposes only the required surface area.

## Architecture
- **USD 25.x (XROS)** — static libraries compiled for visionOS
- **USD 25.x (Windows)** — reference backend
- **Interceptor DLL** — records real input/output behavior of Unity’s original UsdCs
- **Custom native wrapper** — re-implements required USD APIs
- **Unity C# layer** — unchanged USD.NET surface API