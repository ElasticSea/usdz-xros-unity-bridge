#pragma once
#define WIN32_LEAN_AND_MEAN
#include <windows.h>
#include <cstdio>
#include <cstring>

HMODULE GetRealModule();
FARPROC GetRealProc(const char* name);

// ORIGINAL
#define WRAP_PROC(name, rettype, callconv, args, argnames)               \
    using name##_fn = rettype (callconv*) args;                          \
    extern "C" __declspec(dllexport) rettype callconv name args          \
    {                                                                    \
        LogImmediate("[MISSING LOG] name: %s\n", #name);                 \
        static name##_fn real = nullptr;                                 \
        if (!real)                                                       \
            real = reinterpret_cast<name##_fn>(GetRealProc(#name));      \
                                                                         \
        rettype _ret = (real != nullptr) ? real argnames : (rettype)0;   \
        return _ret;                                                     \
    }

#define WRAP_PROC_VOID(name, callconv, args, argnames)                   \
    using name##_fn = void (callconv*) args;                             \
    extern "C" __declspec(dllexport) void callconv name args             \
    {                                                                    \
        LogImmediate("[MISSING LOG] name: %s\n", #name);                 \
        static name##_fn real = nullptr;                                 \
        if (!real)                                                       \
            real = reinterpret_cast<name##_fn>(GetRealProc(#name));      \
                                                                         \
        if (real) real argnames;                                         \
    }

// name         - symbol name (no quotes)
// rettype      - return type (e.g. void*)
// callconv     - calling conv (e.g. __cdecl)
// args         - full arg list in parens (e.g. (void* jarg1, const char* jarg2))
// argnames     - parens with only arg names (e.g. (jarg1, jarg2))
// LOG_ARGS     - code block that calls Logger_Arg_* for each argument
#define WRAP_PROC_VOID_LOG(name, callconv, args, argnames, LOG_ARGS)                 \
    using name##_fn = void (callconv*) args;                                         \
    extern "C" __declspec(dllexport) void callconv name args                         \
    {                                                                                \
        static name##_fn real = nullptr;                                             \
        if (!real)                                                                   \
            real = reinterpret_cast<name##_fn>(GetRealProc(#name));                  \
                                                                                     \
        Begin();                                                                     \
        Header(#name);                                                               \
                                                                                     \
        do { LOG_ARGS; } while (0);                                                  \
        if (real) real argnames;                                                     \
                                                                                     \
        LogReturnVoid();                                                             \
        End();                                                                       \
    }

#define WRAP_PROC_RET_HANDLE_LOG(name, rettype, callconv, args, argnames, LOG_ARGS)   \
    using name##_fn = rettype (callconv*) args;                                      \
    extern "C" __declspec(dllexport) rettype callconv name args                      \
    {                                                                                \
        static name##_fn real = nullptr;                                             \
        if (!real)                                                                   \
            real = reinterpret_cast<name##_fn>(GetRealProc(#name));                  \
                                                                                     \
        Begin();                                                                     \
        Header(#name);                                                               \
                                                                                     \
        do { LOG_ARGS; } while (0);                                                  \
        rettype _ret = (real != nullptr) ? real argnames : (rettype)0;               \
                                                                                     \
        LogReturnHandle((void*)_ret);                                                \
        End();                                                                       \
        return _ret;                                                                 \
    }


#define WRAP_PROC_RET_INT_LOG(name, callconv, args, argnames, LOG_ARGS)              \
    using name##_fn = int (callconv*) args;                                          \
    extern "C" __declspec(dllexport) int callconv name args                          \
    {                                                                                \
        static name##_fn real = nullptr;                                             \
        if (!real)                                                                   \
            real = reinterpret_cast<name##_fn>(GetRealProc(#name));                  \
                                                                                     \
        Begin();                                                                     \
        Header(#name);                                                               \
                                                                                     \
        do { LOG_ARGS; } while (0);                                                  \
        int _ret = (real != nullptr) ? real argnames : 0;                            \
                                                                                     \
        LogReturnInt(_ret);                                                \
        End();                                                                       \
        return _ret;                                                                 \
    }
