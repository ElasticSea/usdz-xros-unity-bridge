#include "pxr/usd/sdf/types.h"
using namespace pxr;

// 1) SWIGRegisterStringCallback_Sdf  (we just store the pointer, don't use it yet)
static void* g_sdfStringCallback = nullptr;

extern "C" __declspec(dllexport)
void __cdecl SWIGRegisterStringCallback_Sdf(void* cb)
{
    g_sdfStringCallback = cb;
}

// Prepare static SdfValueTypeName instances.
// These mirror the well-known Sdf value types.

static SdfValueTypeName g_sdfBool   = SdfValueTypeNames->Bool;
static SdfValueTypeName g_sdfUChar  = SdfValueTypeNames->UChar;
static SdfValueTypeName g_sdfInt    = SdfValueTypeNames->Int;
static SdfValueTypeName g_sdfUInt   = SdfValueTypeNames->UInt;
// (you’ll add more later: Int64, UInt64, Float, etc.)

// 2) CSharp_pxr_SdfGetValueTypeBool
extern "C" __declspec(dllexport)
void* __cdecl CSharp_pxr_SdfGetValueTypeBool()
{
    return &g_sdfBool;
}

// 3) CSharp_pxr_SdfGetValueTypeUChar
extern "C" __declspec(dllexport)
void* __cdecl CSharp_pxr_SdfGetValueTypeUChar()
{
    return &g_sdfUChar;
}

// 4) CSharp_pxr_SdfGetValueTypeInt
extern "C" __declspec(dllexport)
void* __cdecl CSharp_pxr_SdfGetValueTypeInt()
{
    return &g_sdfInt;
}

// 5) CSharp_pxr_SdfGetValueTypeUInt
extern "C" __declspec(dllexport)
void* __cdecl CSharp_pxr_SdfGetValueTypeUInt()
{
    return &g_sdfUInt;
}