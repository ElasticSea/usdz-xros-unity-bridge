// In some .cpp in the DLL (not in a header)
#include <windows.h>
#include "Logger.h"

BOOL APIENTRY DllMain(HMODULE hModule,
    DWORD  ul_reason_for_call,
    LPVOID lpReserved)
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
        Init();
        // we don't care about per-thread callbacks
        DisableThreadLibraryCalls(hModule);
        break;

    case DLL_PROCESS_DETACH:
        Shutdown();
        break;
    }
    return TRUE;
}
