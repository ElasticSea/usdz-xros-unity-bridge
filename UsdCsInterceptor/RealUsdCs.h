// RealUsdCs.h
#pragma once
#include <windows.h>

// Load the original UsdCs DLL and fetch functions.
HMODULE RealUsdCs_GetModule();
FARPROC RealUsdCs_GetProc(const char* name);
