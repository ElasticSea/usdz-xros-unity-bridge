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
        LogRaw("[MISSING LOG] name: %s\n", #name);                 \
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
        LogRaw("[MISSING LOG] name: %s\n", #name);                 \
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
// Generic implementation – don't use directly, use the typed wrappers below.
#define WRAP_IMPL(name, rettype, callconv, args, argnames, LOG_ARGS, LOG_RET, DEFAULT_VAL) \
    using name##_fn = rettype (callconv*) args;                                      \
    extern "C" __declspec(dllexport) rettype callconv name args                      \
    {                                                                                \
        static name##_fn real = nullptr;                                             \
        if (!real)                                                                   \
            real = reinterpret_cast<name##_fn>(GetRealProc(#name));                  \
                                                                                     \
        Header(#name);                                                               \
        do { LOG_ARGS; } while (0);                                                  \
                                                                                     \
        rettype _ret = real ? real argnames : (DEFAULT_VAL);                         \
        LOG_RET(_ret);                                                               \
        return _ret;                                                                 \
    }

#define WRAP_VOID(name, callconv, args, argnames, LOG_ARGS)                 \
    using name##_fn = void (callconv*) args;                                         \
    extern "C" __declspec(dllexport) void callconv name args                         \
    {                                                                                \
        static name##_fn real = nullptr;                                             \
        if (!real)                                                                   \
            real = reinterpret_cast<name##_fn>(GetRealProc(#name));                  \
                                                                                     \
        Header(#name);                                                               \
                                                                                     \
        do { LOG_ARGS; } while (0);                                                  \
        if (real) real argnames;                                                     \
                                                                                     \
        LogReturnVoid();                                                             \
    }

#define WRAP_POINTER(name, callconv, args, argnames, LOG_ARGS)                       \
    WRAP_IMPL(                                                                       \
        name, void*, callconv, args, argnames, LOG_ARGS,                             \
        LogReturnHandle, nullptr)

#define WRAP_BOOL(name, callconv, args, argnames, LOG_ARGS)                          \
    WRAP_IMPL(                                                                       \
        name, bool, callconv, args, argnames, LOG_ARGS,                              \
        LogReturnBool, false)

#define WRAP_INT(name, callconv, args, argnames, LOG_ARGS)                           \
    WRAP_IMPL(                                                                       \
        name, int, callconv, args, argnames, LOG_ARGS,                               \
        LogReturnInt, 0)

#define WRAP_CSTR(name, callconv, args, argnames, LOG_ARGS)                           \
    WRAP_IMPL(                                                                       \
        name, const char*, callconv, args, argnames, LOG_ARGS,                               \
        LogReturnCStr, nullptr)