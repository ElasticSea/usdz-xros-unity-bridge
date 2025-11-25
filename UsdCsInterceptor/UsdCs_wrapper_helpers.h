#pragma once
#define WIN32_LEAN_AND_MEAN
#include <windows.h>
#include <cstdio>
#include <cstring>

HMODULE GetRealModule();
FARPROC GetRealProc(const char* name);
void LogCall(const char* name);

#define WRAP_PROC(name, rettype, callconv, args, argnames)               \
    using name##_fn = rettype (callconv*) args;                          \
    extern "C" __declspec(dllexport) rettype callconv name args          \
    {                                                                    \
        LogCall(#name);                                                  \
        static name##_fn real = nullptr;                                 \
        if (!real)                                                       \
            real = reinterpret_cast<name##_fn>(GetRealProc(#name));      \
        if (!real) return (rettype)0;                                    \
        return real argnames;                                            \
    }

#define WRAP_PROC_VOID(name, callconv, args, argnames)                   \
    using name##_fn = void (callconv*) args;                             \
    extern "C" __declspec(dllexport) void callconv name args             \
    {                                                                    \
        LogCall(#name);                                                  \
        static name##_fn real = nullptr;                                 \
        if (!real)                                                       \
            real = reinterpret_cast<name##_fn>(GetRealProc(#name));      \
        if (real) real argnames;                                         \
    }
