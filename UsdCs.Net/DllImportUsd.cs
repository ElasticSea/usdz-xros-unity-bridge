using System;

public static class UsdDll
{
#if USD_INTERNAL
    public const string USD_EXPORT_NAME = "__Internal";
#elif USD_USDCS
    public const string USD_EXPORT_NAME = "UsdCs";
#else
    // Missing
#endif
}
