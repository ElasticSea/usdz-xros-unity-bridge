// RealUsdCs.cpp
#include "RealUsdCs.h"
#include "Logger.h"
#include <cstring>
#include "LoggerConfig.h"
#define ORIGINAL_DLL_NAME "UsdCs_original.dll"

static HMODULE g_realUsdCs = nullptr;

static HMODULE GetOwnModule()
{
    HMODULE h = nullptr;
    GetModuleHandleExA(
        GET_MODULE_HANDLE_EX_FLAG_FROM_ADDRESS |
        GET_MODULE_HANDLE_EX_FLAG_UNCHANGED_REFCOUNT,
        reinterpret_cast<LPCSTR>(&GetOwnModule),
        &h);
    return h;
}

HMODULE RealUsdCs_GetModule()
{
    if (g_realUsdCs)
        return g_realUsdCs;

    char path[MAX_PATH] = {};
    DWORD len = GetModuleFileNameA(GetOwnModule(), path, MAX_PATH);

    if (len == 0 || len >= MAX_PATH)
    {
        strcpy_s(path, ORIGINAL_DLL_NAME);
    }
    else
    {
        char* lastSlash = strrchr(path, '\\');
        if (lastSlash)
            *(lastSlash + 1) = '\0';
        else
            path[0] = '\0';

        strcat_s(path, ORIGINAL_DLL_NAME);
    }

    g_realUsdCs = LoadLibraryExA(
        path,
        nullptr,
        LOAD_WITH_ALTERED_SEARCH_PATH);

    if (!g_realUsdCs)
    {
        DWORD err = GetLastError();
        LogRaw(
            "[UsdCs wrapper] LoadLibraryEx failed. Tried path: %s, GetLastError: %lu\n",
            path, (unsigned long)err);
    }
    else
    {
        LogRaw("[UsdCs wrapper] Loaded original DLL from: %s\n", path);
    }

    return g_realUsdCs;
}

FARPROC RealUsdCs_GetProc(const char* name)
{
    HMODULE mod = RealUsdCs_GetModule();
    if (!mod)
    {
        LogRaw(
            "[UsdCs wrapper] ERROR: RealUsdCs_GetModule() failed when resolving %s\n",
            name);
        return nullptr;
    }

    FARPROC proc = GetProcAddress(mod, name);
    if (!proc)
    {
        LogRaw(
            "[UsdCs wrapper] ERROR: GetProcAddress failed for %s\n",
            name);
    }
    return proc;
}
