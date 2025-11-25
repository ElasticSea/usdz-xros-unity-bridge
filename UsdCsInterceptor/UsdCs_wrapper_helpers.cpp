#include "UsdCs_wrapper_helpers.h"

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

HMODULE GetRealModule()
{
    if (g_realUsdCs)
        return g_realUsdCs;

    char path[MAX_PATH] = {};
    DWORD len = GetModuleFileNameA(GetOwnModule(), path, MAX_PATH);

    if (len == 0 || len >= MAX_PATH)
    {
        // Fallback: just the name
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

    // IMPORTANT: use LoadLibraryEx so dependencies are searched in this DLL's folder
    g_realUsdCs = LoadLibraryExA(
        path,
        nullptr,
        LOAD_WITH_ALTERED_SEARCH_PATH  // or LOAD_LIBRARY_SEARCH_DLL_LOAD_DIR on newer SDKs
    );

    if (!g_realUsdCs)
    {
        DWORD err = GetLastError();
        FILE* f = nullptr;
        fopen_s(&f, "C:\\temp\\UsdCs_wrapper_log.txt", "a");
        if (f)
        {
            fprintf(f,
                "[UsdCs wrapper] LoadLibraryEx failed.\n"
                "  Tried path: %s\n"
                "  GetLastError: %lu\n",
                path, (unsigned long)err);
            fclose(f);
        }
    }
    else
    {
        FILE* f = nullptr;
        fopen_s(&f, "C:\\temp\\UsdCs_wrapper_log.txt", "a");
        if (f)
        {
            fprintf(f, "[UsdCs wrapper] Loaded original DLL from: %s\n", path);
            fclose(f);
        }
    }

    return g_realUsdCs;
}

FARPROC GetRealProc(const char* name)
{
    HMODULE mod = GetRealModule();
    if (!mod)
    {
        FILE* f = nullptr;
        fopen_s(&f, "C:\\temp\\UsdCs_wrapper_log.txt", "a");
        if (f)
        {
            fprintf(f, "[UsdCs wrapper] ERROR: GetRealModule() failed when resolving %s\n", name);
            fclose(f);
        }
        return nullptr;
    }


    FARPROC proc = GetProcAddress(mod, name);
    if (!proc)
    {
        FILE* f = nullptr;
        fopen_s(&f, "C:\\temp\\UsdCs_wrapper_log.txt", "a");
        if (f)
        {
            fprintf(f, "[UsdCs wrapper] ERROR: GetProcAddress failed for %s\n", name);
            fclose(f);
        }
    }

    return proc;
}

void LogCall(const char* name)
{
    FILE* f = nullptr;
    fopen_s(&f, "C:\\temp\\UsdCs_wrapper_log.txt", "a");
    if (f)
    {
        fprintf(f, "[UsdCs wrapper] CALL: %s\n", name);
        fclose(f);
    }
}