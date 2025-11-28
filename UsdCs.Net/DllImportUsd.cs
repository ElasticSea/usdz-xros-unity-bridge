using System;

internal static class UsdDll
{
#if USD_INTERNAL
    internal const string USD_EXPORT_NAME = "__Internal";
#elif USD_USDCS
    internal const string USD_EXPORT_NAME = "UsdCs";
#else
    // Missing
#endif
}
