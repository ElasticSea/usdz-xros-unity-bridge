#include "pxr/usd/usdUtils/sparseValueWriter.h"
#include "pxr/usd/usdShade/materialBindingAPI.h"
#include "pxr/usd/usdUtils/usdzPackage.h"
#include "pxr/usd/usdGeom/primvarsAPI.h"


using namespace pxr;

#if defined(_WIN32)
#   define USDCS_EXPORT __declspec(dllexport)
#else
#   define USDCS_EXPORT __attribute__((visibility("default")))
#endif

//#pragma region Debug Log
//static FILE* g_
//static void 
//{
//    if (!g_
//        g_
//
//    if (g_
//    {
//        fprintf(g_
//        fflush(g_
//    }
//}
//#pragma endregion

namespace pxr
{
    static TfToken VtValueToTfToken(const VtValue& v)
    {
        return v.Get<TfToken>();
    }

    static VtVec4fArray VtValueToVtVec4fArray(const VtValue& v)
    {
        return v.Get<VtVec4fArray>();
    }
}

// // Swig callbacks not really usd
// ==============================
// Exception callbacks (UsdCs)
// ==============================

extern "C" USDCS_EXPORT
void __cdecl SWIGRegisterExceptionCallbacks_UsdCs(
    void* application,
    void* arithmetic,
    void* divideByZero,
    void* indexOutOfRange,
    void* invalidCast,
    void* invalidOperation,
    void* io,
    void* nullReference,
    void* outOfMemory,
    void* overflow,
    void* system,
    void* argument,
    void* argumentNull,
    void* argumentOutOfRange)
{
    // You can ignore these, since you’re not using SWIG’s pending-exception system.
    // They’re only here so the C# side can successfully register its delegates.
    (void)application;
    (void)arithmetic;
    (void)divideByZero;
    (void)indexOutOfRange;
    (void)invalidCast;
    (void)invalidOperation;
    (void)io;
    (void)nullReference;
    (void)outOfMemory;
    (void)overflow;
    (void)system;
    (void)argument;
    (void)argumentNull;
    (void)argumentOutOfRange;
}

extern "C" USDCS_EXPORT
void __cdecl SWIGRegisterExceptionArgumentCallbacks_UsdCs(
    void* argument,
    void* argumentNull,
    void* argumentOutOfRange)
{
    // Same story: we just accept the callbacks and ignore them.
    (void)argument;
    (void)argumentNull;
    (void)argumentOutOfRange;
}

static void* g_gfStringCallback = nullptr;

extern "C" USDCS_EXPORT
void __cdecl SWIGRegisterStringCallback_Gf(void* cb)
{
    g_gfStringCallback = cb;
}
static void *g_sdfStringCallback = nullptr;
extern "C" USDCS_EXPORT void __cdecl SWIGRegisterStringCallback_Sdf(void *cb)
{
    g_sdfStringCallback = cb;
}
static void* g_stdStringCallback = nullptr;

extern "C" USDCS_EXPORT
void __cdecl SWIGRegisterStringCallback_Std(void* cb)
{
    g_stdStringCallback = cb;
}
static void* g_tfStringCallback = nullptr;

extern "C" USDCS_EXPORT
void __cdecl SWIGRegisterStringCallback_Tf(void* cb)
{
    g_tfStringCallback = cb;
}
static void* g_usdStringCallback = nullptr;
extern "C" USDCS_EXPORT
void __cdecl SWIGRegisterStringCallback_Usd(void* cb)
{
    g_usdStringCallback = cb;
}
static void* g_usdCsStringCallback = nullptr;

extern "C" USDCS_EXPORT
void __cdecl SWIGRegisterStringCallback_UsdCs(void* cb)
{
    g_usdCsStringCallback = cb;
}
static void* g_usdGeomStringCallback = nullptr;

extern "C" USDCS_EXPORT
void __cdecl SWIGRegisterStringCallback_UsdGeom(void* cb)
{
    g_usdGeomStringCallback = cb;
}
static void* g_usdShadeStringCallback = nullptr;

extern "C" USDCS_EXPORT
void __cdecl SWIGRegisterStringCallback_UsdShade(void* cb)
{
    g_usdShadeStringCallback = cb;
}
static void* g_usdUtilsStringCallback = nullptr;

extern "C" USDCS_EXPORT
void __cdecl SWIGRegisterStringCallback_UsdUtils(void* cb)
{
    g_usdUtilsStringCallback = cb;
}
static void* g_vtStringCallback = nullptr;

extern "C" USDCS_EXPORT
void __cdecl SWIGRegisterStringCallback_Vt(void* cb)
{
    g_vtStringCallback = cb;
}

// // Sdf type getters
#pragma region Sdf value types
static SdfValueTypeName g_SdfGetValueTypeAsset = SdfValueTypeNames->Asset;
static SdfValueTypeName g_SdfGetValueTypeAssetArray = SdfValueTypeNames->AssetArray;
static SdfValueTypeName g_SdfGetValueTypeBool = SdfValueTypeNames->Bool;
static SdfValueTypeName g_SdfGetValueTypeBoolArray = SdfValueTypeNames->BoolArray;
static SdfValueTypeName g_SdfGetValueTypeColor3d = SdfValueTypeNames->Color3d;
static SdfValueTypeName g_SdfGetValueTypeColor3dArray = SdfValueTypeNames->Color3dArray;
static SdfValueTypeName g_SdfGetValueTypeColor3f = SdfValueTypeNames->Color3f;
static SdfValueTypeName g_SdfGetValueTypeColor3fArray = SdfValueTypeNames->Color3fArray;
static SdfValueTypeName g_SdfGetValueTypeColor3h = SdfValueTypeNames->Color3h;
static SdfValueTypeName g_SdfGetValueTypeColor3hArray = SdfValueTypeNames->Color3hArray;
static SdfValueTypeName g_SdfGetValueTypeColor4d = SdfValueTypeNames->Color4d;
static SdfValueTypeName g_SdfGetValueTypeColor4dArray = SdfValueTypeNames->Color4dArray;
static SdfValueTypeName g_SdfGetValueTypeColor4f = SdfValueTypeNames->Color4f;
static SdfValueTypeName g_SdfGetValueTypeColor4fArray = SdfValueTypeNames->Color4fArray;
static SdfValueTypeName g_SdfGetValueTypeColor4h = SdfValueTypeNames->Color4h;
static SdfValueTypeName g_SdfGetValueTypeColor4hArray = SdfValueTypeNames->Color4hArray;
static SdfValueTypeName g_SdfGetValueTypeDouble = SdfValueTypeNames->Double;
static SdfValueTypeName g_SdfGetValueTypeDouble2 = SdfValueTypeNames->Double2;
static SdfValueTypeName g_SdfGetValueTypeDouble2Array = SdfValueTypeNames->Double2Array;
static SdfValueTypeName g_SdfGetValueTypeDouble3 = SdfValueTypeNames->Double3;
static SdfValueTypeName g_SdfGetValueTypeDouble3Array = SdfValueTypeNames->Double3Array;
static SdfValueTypeName g_SdfGetValueTypeDouble4 = SdfValueTypeNames->Double4;
static SdfValueTypeName g_SdfGetValueTypeDouble4Array = SdfValueTypeNames->Double4Array;
static SdfValueTypeName g_SdfGetValueTypeDoubleArray = SdfValueTypeNames->DoubleArray;
static SdfValueTypeName g_SdfGetValueTypeFloat = SdfValueTypeNames->Float;
static SdfValueTypeName g_SdfGetValueTypeFloat2 = SdfValueTypeNames->Float2;
static SdfValueTypeName g_SdfGetValueTypeFloat2Array = SdfValueTypeNames->Float2Array;
static SdfValueTypeName g_SdfGetValueTypeFloat3 = SdfValueTypeNames->Float3;
static SdfValueTypeName g_SdfGetValueTypeFloat3Array = SdfValueTypeNames->Float3Array;
static SdfValueTypeName g_SdfGetValueTypeFloat4 = SdfValueTypeNames->Float4;
static SdfValueTypeName g_SdfGetValueTypeFloat4Array = SdfValueTypeNames->Float4Array;
static SdfValueTypeName g_SdfGetValueTypeFloatArray = SdfValueTypeNames->FloatArray;
static SdfValueTypeName g_SdfGetValueTypeFrame4d = SdfValueTypeNames->Frame4d;
static SdfValueTypeName g_SdfGetValueTypeFrame4dArray = SdfValueTypeNames->Frame4dArray;
static SdfValueTypeName g_SdfGetValueTypeGroup = SdfValueTypeNames->Group;
static SdfValueTypeName g_SdfGetValueTypeOpaque = SdfValueTypeNames->Opaque;
static SdfValueTypeName g_SdfGetValueTypeHalf = SdfValueTypeNames->Half;
static SdfValueTypeName g_SdfGetValueTypeHalf2 = SdfValueTypeNames->Half2;
static SdfValueTypeName g_SdfGetValueTypeHalf2Array = SdfValueTypeNames->Half2Array;
static SdfValueTypeName g_SdfGetValueTypeHalf3 = SdfValueTypeNames->Half3;
static SdfValueTypeName g_SdfGetValueTypeHalf3Array = SdfValueTypeNames->Half3Array;
static SdfValueTypeName g_SdfGetValueTypeHalf4 = SdfValueTypeNames->Half4;
static SdfValueTypeName g_SdfGetValueTypeHalf4Array = SdfValueTypeNames->Half4Array;
static SdfValueTypeName g_SdfGetValueTypeHalfArray = SdfValueTypeNames->HalfArray;
static SdfValueTypeName g_SdfGetValueTypeInt = SdfValueTypeNames->Int;
static SdfValueTypeName g_SdfGetValueTypeInt2 = SdfValueTypeNames->Int2;
static SdfValueTypeName g_SdfGetValueTypeInt2Array = SdfValueTypeNames->Int2Array;
static SdfValueTypeName g_SdfGetValueTypeInt3 = SdfValueTypeNames->Int3;
static SdfValueTypeName g_SdfGetValueTypeInt3Array = SdfValueTypeNames->Int3Array;
static SdfValueTypeName g_SdfGetValueTypeInt4 = SdfValueTypeNames->Int4;
static SdfValueTypeName g_SdfGetValueTypeInt4Array = SdfValueTypeNames->Int4Array;
static SdfValueTypeName g_SdfGetValueTypeInt64 = SdfValueTypeNames->Int64;
static SdfValueTypeName g_SdfGetValueTypeInt64Array = SdfValueTypeNames->Int64Array;
static SdfValueTypeName g_SdfGetValueTypeIntArray = SdfValueTypeNames->IntArray;
static SdfValueTypeName g_SdfGetValueTypeUChar = SdfValueTypeNames->UChar;
static SdfValueTypeName g_SdfGetValueTypeUCharArray = SdfValueTypeNames->UCharArray;
static SdfValueTypeName g_SdfGetValueTypeUInt = SdfValueTypeNames->UInt;
static SdfValueTypeName g_SdfGetValueTypeUInt64 = SdfValueTypeNames->UInt64;
static SdfValueTypeName g_SdfGetValueTypeUInt64Array = SdfValueTypeNames->UInt64Array;
static SdfValueTypeName g_SdfGetValueTypeUIntArray = SdfValueTypeNames->UIntArray;
static SdfValueTypeName g_SdfGetValueTypeMatrix2d = SdfValueTypeNames->Matrix2d;
static SdfValueTypeName g_SdfGetValueTypeMatrix2dArray = SdfValueTypeNames->Matrix2dArray;
static SdfValueTypeName g_SdfGetValueTypeMatrix3d = SdfValueTypeNames->Matrix3d;
static SdfValueTypeName g_SdfGetValueTypeMatrix3dArray = SdfValueTypeNames->Matrix3dArray;
static SdfValueTypeName g_SdfGetValueTypeMatrix4d = SdfValueTypeNames->Matrix4d;
static SdfValueTypeName g_SdfGetValueTypeMatrix4dArray = SdfValueTypeNames->Matrix4dArray;
static SdfValueTypeName g_SdfGetValueTypeNormal3d = SdfValueTypeNames->Normal3d;
static SdfValueTypeName g_SdfGetValueTypeNormal3dArray = SdfValueTypeNames->Normal3dArray;
static SdfValueTypeName g_SdfGetValueTypeNormal3f = SdfValueTypeNames->Normal3f;
static SdfValueTypeName g_SdfGetValueTypeNormal3fArray = SdfValueTypeNames->Normal3fArray;
static SdfValueTypeName g_SdfGetValueTypeNormal3h = SdfValueTypeNames->Normal3h;
static SdfValueTypeName g_SdfGetValueTypeNormal3hArray = SdfValueTypeNames->Normal3hArray;
static SdfValueTypeName g_SdfGetValueTypePoint3d = SdfValueTypeNames->Point3d;
static SdfValueTypeName g_SdfGetValueTypePoint3dArray = SdfValueTypeNames->Point3dArray;
static SdfValueTypeName g_SdfGetValueTypePoint3f = SdfValueTypeNames->Point3f;
static SdfValueTypeName g_SdfGetValueTypePoint3fArray = SdfValueTypeNames->Point3fArray;
static SdfValueTypeName g_SdfGetValueTypePoint3h = SdfValueTypeNames->Point3h;
static SdfValueTypeName g_SdfGetValueTypePoint3hArray = SdfValueTypeNames->Point3hArray;
static SdfValueTypeName g_SdfGetValueTypeQuatd = SdfValueTypeNames->Quatd;
static SdfValueTypeName g_SdfGetValueTypeQuatdArray = SdfValueTypeNames->QuatdArray;
static SdfValueTypeName g_SdfGetValueTypeQuatf = SdfValueTypeNames->Quatf;
static SdfValueTypeName g_SdfGetValueTypeQuatfArray = SdfValueTypeNames->QuatfArray;
static SdfValueTypeName g_SdfGetValueTypeQuath = SdfValueTypeNames->Quath;
static SdfValueTypeName g_SdfGetValueTypeQuathArray = SdfValueTypeNames->QuathArray;
static SdfValueTypeName g_SdfGetValueTypeString = SdfValueTypeNames->String;
static SdfValueTypeName g_SdfGetValueTypeStringArray = SdfValueTypeNames->StringArray;
static SdfValueTypeName g_SdfGetValueTypeToken = SdfValueTypeNames->Token;
static SdfValueTypeName g_SdfGetValueTypeTokenArray = SdfValueTypeNames->TokenArray;
static SdfValueTypeName g_SdfGetValueTypeTexCoord2d = SdfValueTypeNames->TexCoord2d;
static SdfValueTypeName g_SdfGetValueTypeTexCoord2dArray = SdfValueTypeNames->TexCoord2dArray;
static SdfValueTypeName g_SdfGetValueTypeTexCoord2f = SdfValueTypeNames->TexCoord2f;
static SdfValueTypeName g_SdfGetValueTypeTexCoord2fArray = SdfValueTypeNames->TexCoord2fArray;
static SdfValueTypeName g_SdfGetValueTypeTexCoord2h = SdfValueTypeNames->TexCoord2h;
static SdfValueTypeName g_SdfGetValueTypeTexCoord2hArray = SdfValueTypeNames->TexCoord2hArray;
static SdfValueTypeName g_SdfGetValueTypeTexCoord3d = SdfValueTypeNames->TexCoord3d;
static SdfValueTypeName g_SdfGetValueTypeTexCoord3dArray = SdfValueTypeNames->TexCoord3dArray;
static SdfValueTypeName g_SdfGetValueTypeTexCoord3f = SdfValueTypeNames->TexCoord3f;
static SdfValueTypeName g_SdfGetValueTypeTexCoord3fArray = SdfValueTypeNames->TexCoord3fArray;
static SdfValueTypeName g_SdfGetValueTypeTexCoord3h = SdfValueTypeNames->TexCoord3h;
static SdfValueTypeName g_SdfGetValueTypeTexCoord3hArray = SdfValueTypeNames->TexCoord3hArray;
static SdfValueTypeName g_SdfGetValueTypeTimeCode = SdfValueTypeNames->TimeCode;
static SdfValueTypeName g_SdfGetValueTypeTimeCodeArray = SdfValueTypeNames->TimeCodeArray;
static SdfValueTypeName g_SdfGetValueTypeVector3d = SdfValueTypeNames->Vector3d;
static SdfValueTypeName g_SdfGetValueTypeVector3dArray = SdfValueTypeNames->Vector3dArray;
static SdfValueTypeName g_SdfGetValueTypeVector3f = SdfValueTypeNames->Vector3f;
static SdfValueTypeName g_SdfGetValueTypeVector3fArray = SdfValueTypeNames->Vector3fArray;
static SdfValueTypeName g_SdfGetValueTypeVector3h = SdfValueTypeNames->Vector3h;
static SdfValueTypeName g_SdfGetValueTypeVector3hArray = SdfValueTypeNames->Vector3hArray;
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeAsset() { return &g_SdfGetValueTypeAsset; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeAssetArray() { return &g_SdfGetValueTypeAssetArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeBool() { return &g_SdfGetValueTypeBool; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeBoolArray() { return &g_SdfGetValueTypeBoolArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeColor3d() { return &g_SdfGetValueTypeColor3d; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeColor3dArray() { return &g_SdfGetValueTypeColor3dArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeColor3f() { return &g_SdfGetValueTypeColor3f; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeColor3fArray() { return &g_SdfGetValueTypeColor3fArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeColor3h() { return &g_SdfGetValueTypeColor3h; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeColor3hArray() { return &g_SdfGetValueTypeColor3hArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeColor4d() { return &g_SdfGetValueTypeColor4d; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeColor4dArray() { return &g_SdfGetValueTypeColor4dArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeColor4f() { return &g_SdfGetValueTypeColor4f; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeColor4fArray() { return &g_SdfGetValueTypeColor4fArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeColor4h() { return &g_SdfGetValueTypeColor4h; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeColor4hArray() { return &g_SdfGetValueTypeColor4hArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeDouble() { return &g_SdfGetValueTypeDouble; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeDouble2() { return &g_SdfGetValueTypeDouble2; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeDouble2Array() { return &g_SdfGetValueTypeDouble2Array; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeDouble3() { return &g_SdfGetValueTypeDouble3; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeDouble3Array() { return &g_SdfGetValueTypeDouble3Array; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeDouble4() { return &g_SdfGetValueTypeDouble4; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeDouble4Array() { return &g_SdfGetValueTypeDouble4Array; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeDoubleArray() { return &g_SdfGetValueTypeDoubleArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeFloat() { return &g_SdfGetValueTypeFloat; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeFloat2() { return &g_SdfGetValueTypeFloat2; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeFloat2Array() { return &g_SdfGetValueTypeFloat2Array; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeFloat3() { return &g_SdfGetValueTypeFloat3; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeFloat3Array() { return &g_SdfGetValueTypeFloat3Array; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeFloat4() { return &g_SdfGetValueTypeFloat4; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeFloat4Array() { return &g_SdfGetValueTypeFloat4Array; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeFloatArray() { return &g_SdfGetValueTypeFloatArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeFrame4d() { return &g_SdfGetValueTypeFrame4d; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeFrame4dArray() { return &g_SdfGetValueTypeFrame4dArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeGroup() { return &g_SdfGetValueTypeGroup; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeHalf() { return &g_SdfGetValueTypeHalf; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeHalf2() { return &g_SdfGetValueTypeHalf2; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeHalf2Array() { return &g_SdfGetValueTypeHalf2Array; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeHalf3() { return &g_SdfGetValueTypeHalf3; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeHalf3Array() { return &g_SdfGetValueTypeHalf3Array; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeHalf4() { return &g_SdfGetValueTypeHalf4; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeHalf4Array() { return &g_SdfGetValueTypeHalf4Array; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeHalfArray() { return &g_SdfGetValueTypeHalfArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeInt() { return &g_SdfGetValueTypeInt; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeInt2() { return &g_SdfGetValueTypeInt2; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeInt2Array() { return &g_SdfGetValueTypeInt2Array; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeInt3() { return &g_SdfGetValueTypeInt3; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeInt3Array() { return &g_SdfGetValueTypeInt3Array; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeInt4() { return &g_SdfGetValueTypeInt4; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeInt4Array() { return &g_SdfGetValueTypeInt4Array; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeInt64() { return &g_SdfGetValueTypeInt64; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeInt64Array() { return &g_SdfGetValueTypeInt64Array; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeIntArray() { return &g_SdfGetValueTypeIntArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeMatrix2d() { return &g_SdfGetValueTypeMatrix2d; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeMatrix2dArray() { return &g_SdfGetValueTypeMatrix2dArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeMatrix3d() { return &g_SdfGetValueTypeMatrix3d; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeMatrix3dArray() { return &g_SdfGetValueTypeMatrix3dArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeMatrix4d() { return &g_SdfGetValueTypeMatrix4d; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeMatrix4dArray() { return &g_SdfGetValueTypeMatrix4dArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeNormal3d() { return &g_SdfGetValueTypeNormal3d; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeNormal3dArray() { return &g_SdfGetValueTypeNormal3dArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeNormal3f() { return &g_SdfGetValueTypeNormal3f; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeNormal3fArray() { return &g_SdfGetValueTypeNormal3fArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeNormal3h() { return &g_SdfGetValueTypeNormal3h; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeNormal3hArray() { return &g_SdfGetValueTypeNormal3hArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeOpaque() { return &g_SdfGetValueTypeOpaque; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypePoint3d() { return &g_SdfGetValueTypePoint3d; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypePoint3dArray() { return &g_SdfGetValueTypePoint3dArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypePoint3f() { return &g_SdfGetValueTypePoint3f; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypePoint3fArray() { return &g_SdfGetValueTypePoint3fArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypePoint3h() { return &g_SdfGetValueTypePoint3h; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypePoint3hArray() { return &g_SdfGetValueTypePoint3hArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeQuatd() { return &g_SdfGetValueTypeQuatd; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeQuatdArray() { return &g_SdfGetValueTypeQuatdArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeQuatf() { return &g_SdfGetValueTypeQuatf; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeQuatfArray() { return &g_SdfGetValueTypeQuatfArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeQuath() { return &g_SdfGetValueTypeQuath; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeQuathArray() { return &g_SdfGetValueTypeQuathArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeString() { return &g_SdfGetValueTypeString; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeStringArray() { return &g_SdfGetValueTypeStringArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeTexCoord2d() { return &g_SdfGetValueTypeTexCoord2d; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeTexCoord2dArray() { return &g_SdfGetValueTypeTexCoord2dArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeTexCoord2f() { return &g_SdfGetValueTypeTexCoord2f; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeTexCoord2fArray() { return &g_SdfGetValueTypeTexCoord2fArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeTexCoord2h() { return &g_SdfGetValueTypeTexCoord2h; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeTexCoord2hArray() { return &g_SdfGetValueTypeTexCoord2hArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeTexCoord3d() { return &g_SdfGetValueTypeTexCoord3d; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeTexCoord3dArray() { return &g_SdfGetValueTypeTexCoord3dArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeTexCoord3f() { return &g_SdfGetValueTypeTexCoord3f; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeTexCoord3fArray() { return &g_SdfGetValueTypeTexCoord3fArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeTexCoord3h() { return &g_SdfGetValueTypeTexCoord3h; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeTexCoord3hArray() { return &g_SdfGetValueTypeTexCoord3hArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeTimeCode() { return &g_SdfGetValueTypeTimeCode; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeTimeCodeArray() { return &g_SdfGetValueTypeTimeCodeArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeToken() { return &g_SdfGetValueTypeToken; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeTokenArray() { return &g_SdfGetValueTypeTokenArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeUChar() { return &g_SdfGetValueTypeUChar; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeUCharArray() { return &g_SdfGetValueTypeUCharArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeUInt() { return &g_SdfGetValueTypeUInt; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeUInt64() { return &g_SdfGetValueTypeUInt64; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeUInt64Array() { return &g_SdfGetValueTypeUInt64Array; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeUIntArray() { return &g_SdfGetValueTypeUIntArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeVector3d() { return &g_SdfGetValueTypeVector3d; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeVector3dArray() { return &g_SdfGetValueTypeVector3dArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeVector3f() { return &g_SdfGetValueTypeVector3f; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeVector3fArray() { return &g_SdfGetValueTypeVector3fArray; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeVector3h() { return &g_SdfGetValueTypeVector3h; }
extern "C" USDCS_EXPORT void *__cdecl CSharp_pxr_SdfGetValueTypeVector3hArray() { return &g_SdfGetValueTypeVector3hArray; }
#pragma endregion
// // Gf math
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_GfMatrix4d__SWIG_1(
    double jarg1,  double jarg2,  double jarg3,  double jarg4,
    double jarg5,  double jarg6,  double jarg7,  double jarg8,
    double jarg9,  double jarg10, double jarg11, double jarg12,
    double jarg13, double jarg14, double jarg15, double jarg16)
{
    return new pxr::GfMatrix4d(
        jarg1,  jarg2,  jarg3,  jarg4,
        jarg5,  jarg6,  jarg7,  jarg8,
        jarg9,  jarg10, jarg11, jarg12,
        jarg13, jarg14, jarg15, jarg16
    );
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_GfVec2f__SWIG_2(float jarg1, float jarg2)
{
    return new pxr::GfVec2f(jarg1, jarg2);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_GfVec3f__SWIG_2(float jarg1, float jarg2, float jarg3)
{
    return new pxr::GfVec3f(jarg1, jarg2, jarg3);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_VtValue__SWIG_16(int p0)
{
    return new pxr::VtValue(p0);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_GfVec4f__SWIG_2(float jarg1, float jarg2, float jarg3, float jarg4)
{
    return new pxr::GfVec4f(jarg1, jarg2, jarg3, jarg4);
}

// // Values
// Usd core types
extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_UsdStage(void* jarg1)
{
    using StageHandle = pxr::TfRefPtr<pxr::UsdStage>;
    StageHandle* handle = static_cast<StageHandle*>(jarg1);
    delete handle; // this decrefs the underlying UsdStage correctly
}

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_UsdPrim(void* p0)
{
    delete static_cast<pxr::UsdPrim*>(p0);
}

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_UsdAttribute(void* p0)
{
    delete static_cast<pxr::UsdAttribute*>(p0);
}

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_UsdTimeCode(void* p0)
{
    delete static_cast<pxr::UsdTimeCode*>(p0);
}

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_UsdObject(void* p0); // only if you had such a function, otherwise skip


// UsdGeom / UsdShade / UsdUtils

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_UsdGeomImageable(void* p0)
{
    delete static_cast<pxr::UsdGeomImageable*>(p0);
}

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_UsdGeomPrimvar(void* p0)
{
    delete static_cast<pxr::UsdGeomPrimvar*>(p0);
}

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_UsdGeomPrimvarsAPI(void* p0)
{
    delete static_cast<pxr::UsdGeomPrimvarsAPI*>(p0);
}

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_UsdShadeMaterial(void* p0)
{
    delete static_cast<pxr::UsdShadeMaterial*>(p0);
}

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_UsdShadeMaterialBindingAPI(void* p0)
{
    delete static_cast<pxr::UsdShadeMaterialBindingAPI*>(p0);
}

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_UsdUtilsSparseValueWriter(void* p0)
{
    delete static_cast<pxr::UsdUtilsSparseValueWriter*>(p0);
}


// Sdf / Tf

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_SdfPath(void* p0)
{
    delete static_cast<pxr::SdfPath*>(p0);
}

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_SdfAssetPath(void* p0)
{
    delete static_cast<pxr::SdfAssetPath*>(p0);
}

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_SdfValueTypeName(void* p0)
{
    delete static_cast<pxr::SdfValueTypeName*>(p0);
}

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_TfToken(void* p0)
{
    delete static_cast<pxr::TfToken*>(p0);
}

// This is the delegate type SWIG uses for TfDiagnosticMgr::Delegate.
// If your original SWIG delete took this pointer, this is correct:
extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_TfDiagnosticMgr_Delegate(void* p0)
{
    delete static_cast<pxr::TfDiagnosticMgr::Delegate*>(p0);
}


// Gf math types

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_GfVec2f(void* p0)
{
    delete static_cast<pxr::GfVec2f*>(p0);
}

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_GfVec3f(void* p0)
{
    delete static_cast<pxr::GfVec3f*>(p0);
}

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_GfVec4f(void* p0)
{
    delete static_cast<pxr::GfVec4f*>(p0);
}

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_GfMatrix4d(void* p0)
{
    delete static_cast<pxr::GfMatrix4d*>(p0);
}


// VtValue + Vt arrays

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_VtValue(void* p0)
{
    delete static_cast<pxr::VtValue*>(p0);
}

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_VtTokenArray(void* p0)
{
    delete static_cast<pxr::VtArray<pxr::TfToken>*>(p0);
}

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_VtVec3fArray(void* p0)
{
    delete static_cast<pxr::VtArray<pxr::GfVec3f>*>(p0);
}

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_VtVec4fArray(void* p0)
{
    delete static_cast<pxr::VtArray<pxr::GfVec4f>*>(p0);
}

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_VtVec2fArray(void* p0)
{
    delete static_cast<pxr::VtArray<pxr::GfVec2f>*>(p0);
}

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_VtIntArray(void* p0)
{
    delete static_cast<pxr::VtArray<int>*>(p0);
}


// std::vector wrappers

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_StdStringVector(void* p0)
{
    delete static_cast<std::vector<std::string>*>(p0);
}

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_delete_SdfPathVector(void* p0)
{
    delete static_cast<std::vector<pxr::SdfPath>*>(p0);
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_VtIntArray__SWIG_3(unsigned long jarg1)
{
    size_t count = static_cast<size_t>(jarg1);
    return new pxr::VtArray<int>(count);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_VtTokenArray__SWIG_3(unsigned long jarg1)
{
    size_t count = static_cast<size_t>(jarg1);
    return new pxr::VtArray<pxr::TfToken>(count);
}


// UsdPrim → UsdObject
extern "C" USDCS_EXPORT
pxr::UsdObject* __cdecl CSharp_pxr_UsdPrim_SWIGUpcast(pxr::UsdPrim* jarg1)
{
    
    return static_cast<pxr::UsdObject*>(jarg1);
}

// VtArray<TfToken> → Vt_ArrayBase
extern "C" USDCS_EXPORT
pxr::Vt_ArrayBase* __cdecl CSharp_pxr_VtTokenArray_SWIGUpcast(pxr::VtArray<pxr::TfToken>* jarg1)
{
    
    return static_cast<pxr::Vt_ArrayBase*>(jarg1);
}

// VtArray<int> → Vt_ArrayBase
extern "C" USDCS_EXPORT
pxr::Vt_ArrayBase* __cdecl CSharp_pxr_VtIntArray_SWIGUpcast(pxr::VtArray<int>* jarg1)
{
    
    return static_cast<pxr::Vt_ArrayBase*>(jarg1);
}

// VtArray<GfVec3f> → Vt_ArrayBase
extern "C" USDCS_EXPORT
pxr::Vt_ArrayBase* __cdecl CSharp_pxr_VtVec3fArray_SWIGUpcast(pxr::VtArray<pxr::GfVec3f>* jarg1)
{
    
    return static_cast<pxr::Vt_ArrayBase*>(jarg1);
}

// UsdAPISchemaBase → UsdSchemaBase
extern "C" USDCS_EXPORT
pxr::UsdSchemaBase* __cdecl CSharp_pxr_UsdAPISchemaBase_SWIGUpcast(pxr::UsdAPISchemaBase* jarg1)
{
    
    return static_cast<pxr::UsdSchemaBase*>(jarg1);
}

// VtArray<GfVec4f> → Vt_ArrayBase
extern "C" USDCS_EXPORT
pxr::Vt_ArrayBase* __cdecl CSharp_pxr_VtVec4fArray_SWIGUpcast(pxr::VtArray<pxr::GfVec4f>* jarg1)
{
    
    return static_cast<pxr::Vt_ArrayBase*>(jarg1);
}

// VtArray<GfVec2f> → Vt_ArrayBase
extern "C" USDCS_EXPORT
pxr::Vt_ArrayBase* __cdecl CSharp_pxr_VtVec2fArray_SWIGUpcast(pxr::VtArray<pxr::GfVec2f>* jarg1)
{
    
    return static_cast<pxr::Vt_ArrayBase*>(jarg1);
}

// UsdGeomImageable → UsdTyped
extern "C" USDCS_EXPORT
pxr::UsdTyped* __cdecl CSharp_pxr_UsdGeomImageable_SWIGUpcast(pxr::UsdGeomImageable* jarg1)
{
    
    return static_cast<pxr::UsdTyped*>(jarg1);
}

// UsdTyped → UsdSchemaBase
extern "C" USDCS_EXPORT
pxr::UsdSchemaBase* __cdecl CSharp_pxr_UsdTyped_SWIGUpcast(pxr::UsdTyped* jarg1)
{
    
    return static_cast<pxr::UsdSchemaBase*>(jarg1);
}

// UsdAttribute → UsdProperty
extern "C" USDCS_EXPORT
pxr::UsdProperty* __cdecl CSharp_pxr_UsdAttribute_SWIGUpcast(pxr::UsdAttribute* jarg1)
{
    
    return static_cast<pxr::UsdProperty*>(jarg1);
}

// UsdProperty → UsdObject
extern "C" USDCS_EXPORT
pxr::UsdObject* __cdecl CSharp_pxr_UsdProperty_SWIGUpcast(pxr::UsdProperty* jarg1)
{
    
    return static_cast<pxr::UsdObject*>(jarg1);
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_VtValue__SWIG_17(void* p0)
{
    
    auto* arr = static_cast<pxr::VtIntArray*>(p0);
    if (!arr) return nullptr;
    return new pxr::VtValue(*arr);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_VtValue__SWIG_36(void* p0)
{
    
    auto* v = static_cast<pxr::GfVec4f*>(p0);
    if (!v) return nullptr;
    return new pxr::VtValue(*v);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_VtValue__SWIG_37(void* p0)
{
    
    auto* arr = static_cast<pxr::VtVec4fArray*>(p0);
    if (!arr) return nullptr;
    return new pxr::VtValue(*arr);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_VtValue__SWIG_38(void* p0)
{
    
    auto* v = static_cast<pxr::GfVec3f*>(p0);
    if (!v) return nullptr;
    return new pxr::VtValue(*v);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_VtValue__SWIG_39(void* p0)
{
    
    auto* arr = static_cast<pxr::VtVec3fArray*>(p0);
    if (!arr) return nullptr;
    return new pxr::VtValue(*arr);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_VtValue__SWIG_40(void* p0)
{
    
    auto* v = static_cast<pxr::GfVec2f*>(p0);
    if (!v) return nullptr;
    return new pxr::VtValue(*v);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_VtValue__SWIG_41(void* p0)
{
    
    auto* arr = static_cast<pxr::VtVec2fArray*>(p0);
    if (!arr) return nullptr;
    return new pxr::VtValue(*arr);
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_VtValue__SWIG_4(double p0)
{
    return new pxr::VtValue(p0);
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_VtValue__SWIG_10(bool p0)
{
    return new pxr::VtValue(p0);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_VtValue__SWIG_48(void* p0)
{
    
    auto* mat = static_cast<pxr::GfMatrix4d*>(p0);
    if (!mat) return nullptr;

    return new pxr::VtValue(*mat);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_VtValue__SWIG_72(void* p0)
{
    
    auto* tok = static_cast<pxr::TfToken*>(p0);
    if (!tok) return nullptr;
    return new pxr::VtValue(*tok);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_VtValue__SWIG_73(void* p0)
{
    
    auto* arr = static_cast<pxr::VtTokenArray*>(p0);
    if (!arr) return nullptr;
    return new pxr::VtValue(*arr);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_VtValue__SWIG_70(const char* p0)
{
    if (!p0)
        return nullptr;

    std::string s(p0);
    return new pxr::VtValue(s);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_VtValue__SWIG_89(void* p0)
{
    
    auto* path = static_cast<pxr::SdfAssetPath*>(p0);
    if (!path) return nullptr;
    return new pxr::VtValue(*path);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_VtValue__SWIG_6(float p0)
{
    return new pxr::VtValue(p0);
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_VtVec2fArray__SWIG_3(unsigned long jarg1)
{
    size_t count = static_cast<size_t>(jarg1);

    auto* arr = new pxr::VtArray<pxr::GfVec2f>(count);
    return arr;
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_VtVec3fArray__SWIG_3(unsigned long jarg1)
{
    size_t count = static_cast<size_t>(jarg1);
    return new pxr::VtArray<pxr::GfVec3f>(count);
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_VtVec4fArray__SWIG_3(unsigned long jarg1)
{
    size_t count = static_cast<size_t>(jarg1);

    auto* arr = new pxr::VtArray<pxr::GfVec4f>(count);
    return arr;
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_VtValueToTfToken__SWIG_0(void* jarg1)
{
    auto* v = static_cast<const pxr::VtValue*>(jarg1);
    if (!v)
        return nullptr;

    pxr::TfToken tok = pxr::VtValueToTfToken(*v);

    return new pxr::TfToken(tok);
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_VtValueToVtVec4fArray__SWIG_0(void* jarg1)
{
    auto* v = static_cast<const pxr::VtValue*>(jarg1);
    if (!v)
        return nullptr;

    pxr::VtVec4fArray result = pxr::VtValueToVtVec4fArray(*v);
    return new pxr::VtVec4fArray(result);
}


extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_VtIntArray_CopyFromArray__SWIG_1(void* jarg1, void* jarg2)
{
    auto* dst = static_cast<pxr::VtArray<int>*>(jarg1);
    auto* src = static_cast<const int*>(jarg2);

    if (!dst || !src)
        return;

    // dst must already be sized by the caller (Unity / SWIG binding)
    const size_t n = dst->size();

    // Copy from raw memory → VtArray elements
    for (size_t i = 0; i < n; ++i)
        (*dst)[i] = src[i];
}

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_VtTokenArray_SetValue(void* jarg1, int jarg2, void* jarg3)
{
    auto* arr   = static_cast<pxr::VtArray<pxr::TfToken>*>(jarg1);
    auto* token = static_cast<const pxr::TfToken*>(jarg3);

    if (!arr || !token)
        return;

    const int idx = jarg2;
    if (idx < 0 || static_cast<size_t>(idx) >= arr->size())
        return; // SWIG would throw; we just bail out

    (*arr)[static_cast<size_t>(idx)] = *token;
}

// VtArray<GfVec2f> ← raw GfVec2f[]
extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_VtVec2fArray_CopyFromArray__SWIG_1(void* jarg1, void* jarg2)
{
    auto* dst = static_cast<pxr::VtArray<pxr::GfVec2f>*>(jarg1);
    auto* src = static_cast<const pxr::GfVec2f*>(jarg2);

    if (!dst || !src)
        return;

    const size_t n = dst->size();
    for (size_t i = 0; i < n; ++i)
        (*dst)[i] = src[i];
}

// VtArray<GfVec3f> ← raw GfVec3f[]
extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_VtVec3fArray_CopyFromArray__SWIG_1(void* jarg1, void* jarg2)
{
    auto* dst = static_cast<pxr::VtArray<pxr::GfVec3f>*>(jarg1);
    auto* src = static_cast<const pxr::GfVec3f*>(jarg2);

    if (!dst || !src)
        return;

    const size_t n = dst->size();
    for (size_t i = 0; i < n; ++i)
        (*dst)[i] = src[i];
}

// VtArray<GfVec3f>[index] = value
extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_VtVec3fArray_SetValue(void* jarg1, int jarg2, void* jarg3)
{
    auto* arr  = static_cast<pxr::VtArray<pxr::GfVec3f>*>(jarg1);
    auto* val  = static_cast<const pxr::GfVec3f*>(jarg3);

    if (!arr || !val)
        return;

    const int idx = jarg2;
    if (idx < 0 || static_cast<size_t>(idx) >= arr->size())
        return; // SWIG would throw; we just bail out

    (*arr)[static_cast<size_t>(idx)] = *val;
}

// VtArray<GfVec4f> ← raw GfVec4f[]
extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_VtVec4fArray_CopyFromArray__SWIG_1(void* jarg1, void* jarg2)
{
    auto* dst = static_cast<pxr::VtArray<pxr::GfVec4f>*>(jarg1);
    auto* src = static_cast<const pxr::GfVec4f*>(jarg2);

    if (!dst || !src)
        return;

    const size_t n = dst->size();
    for (size_t i = 0; i < n; ++i)
        (*dst)[i] = src[i];
}


// // usd stage
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_UsdStage_CreateNew__SWIG_1(char* jarg1)
{
        
    if (!jarg1)
        return nullptr; // ignore SWIG exception plumbing

    std::string path(jarg1);
    pxr::UsdStageRefPtr stage = pxr::UsdStage::CreateNew(path);
    if (!stage)
        return nullptr;

        

    // SWIG expects a pointer to UsdStageRefPtr (TfRefPtr<UsdStage>)
    return new pxr::UsdStageRefPtr(stage);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_UsdStage_DefinePrim__SWIG_0(void* jarg1, void* jarg2, void* jarg3)
{
    // jarg1: TfRefPtr<UsdStage>
    auto* smartStage = static_cast<pxr::TfRefPtr<pxr::UsdStage>*>(jarg1);
    if (!smartStage)
        return nullptr;

    pxr::UsdStage* stage = smartStage->operator->();
    if (!stage)
        return nullptr;

    auto* path  = static_cast<const pxr::SdfPath*>(jarg2);
    auto* type  = static_cast<const pxr::TfToken*>(jarg3);

    if (!path || !type)
        return nullptr;

    pxr::UsdPrim prim = stage->DefinePrim(*path, *type);

    // SWIG returns a heap-allocated UsdPrim copy
    return new pxr::UsdPrim(prim);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_UsdStage_GetEditTarget(void* jarg1)
{
    

    if (!jarg1)
        return nullptr;

    // jarg1 is TfRefPtr<const UsdStage>
    auto* smartStage =
        static_cast<pxr::TfRefPtr<const pxr::UsdStage>*>(jarg1);

    const pxr::UsdStage* stage =
        smartStage ? smartStage->operator->() : nullptr;

    if (!stage)
        return nullptr;

    // IMPORTANT: return pointer to internal edit target, not a new one
    const pxr::UsdEditTarget& et = stage->GetEditTarget();

    return const_cast<pxr::UsdEditTarget*>(&et);
}
extern "C" USDCS_EXPORT
unsigned int __cdecl CSharp_pxr_UsdStage_GetMetadata(void* jarg1, void* jarg2, void* jarg3)
{
    // jarg1: TfRefPtr<const UsdStage>
    auto* smartStage =
        static_cast<pxr::TfRefPtr<const pxr::UsdStage>*>(jarg1);

    const pxr::UsdStage* stage =
        smartStage ? smartStage->operator->() : nullptr;

    if (!stage)
        return 0;

    auto* key   = static_cast<const pxr::TfToken*>(jarg2);
    auto* value = static_cast<pxr::VtValue*>(jarg3);

    if (!key || !value)
        return 0;

    // USD API:
    // bool GetMetadata(const TfToken&, VtValue*)
    bool ok = stage->GetMetadata(*key, value);
    return ok ? 1u : 0u;
}


extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_UsdStage_GetPrimAtPath(void* jarg1, void* jarg2)
{
    

    if (!jarg1 || !jarg2)
        return nullptr;

    // jarg1: TfRefPtr<const UsdStage>
    auto* smartStage =
        static_cast<pxr::TfRefPtr<const pxr::UsdStage>*>(jarg1);
    const pxr::UsdStage* stage =
        smartStage ? smartStage->operator->() : nullptr;
    if (!stage)
        return nullptr;

    auto* path = static_cast<const pxr::SdfPath*>(jarg2);

    pxr::UsdPrim prim = stage->GetPrimAtPath(*path);

    // SWIG returns a heap-allocated copy of UsdPrim
    return new pxr::UsdPrim(prim);
}

extern "C" USDCS_EXPORT
unsigned int __cdecl CSharp_pxr_UsdStage_SetMetadata(void* jarg1, void* jarg2, void* jarg3)
{
    

    if (!jarg1 || !jarg2 || !jarg3)
        return 0;

    // jarg1 is a TfRefPtr<const UsdStage>
    auto* smartStage = static_cast<pxr::TfRefPtr<const pxr::UsdStage>*>(jarg1);
    const pxr::UsdStage* stage = smartStage ? smartStage->operator->() : nullptr;
    if (!stage)
        return 0;

    auto* key   = static_cast<pxr::TfToken*>(jarg2);
    auto* value = static_cast<pxr::VtValue*>(jarg3);
    if (!key || !value)
        return 0;

    bool ok = stage->SetMetadata(*key, *value);
    return ok ? 1u : 0u;
}

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_UsdStage_Save(void* jarg1)
{
    // jarg1 is TfRefPtr<UsdStage>
    auto* smart = static_cast<pxr::TfRefPtr<pxr::UsdStage>*>(jarg1);
    pxr::UsdStage* stage = smart ? smart->operator->() : nullptr;

    if (!stage)
        return;

    stage->Save();
}
extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_UsdStage_SetDefaultPrim(void* jarg1, void* jarg2)
{
    // jarg1 is a TfRefPtr<UsdStage>
    auto* smartStage = static_cast<pxr::TfRefPtr<pxr::UsdStage>*>(jarg1);
    pxr::UsdStage* stage = smartStage ? smartStage->operator->() : nullptr;

    auto* prim = static_cast<pxr::UsdPrim*>(jarg2);

    if (!stage || !prim)
        return;

    stage->SetDefaultPrim(*prim);
}


// // usd - object
extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_UsdObject_SetCustomDataByKey(void* jarg1, void* jarg2, void* jarg3)
{
    auto* obj   = static_cast<pxr::UsdObject*>(jarg1);
    auto* key   = static_cast<const pxr::TfToken*>(jarg2);
    auto* value = static_cast<const pxr::VtValue*>(jarg3);

    if (!obj || !key || !value)
        return;

    obj->SetCustomDataByKey(*key, *value);
}

extern "C" USDCS_EXPORT
unsigned int __cdecl CSharp_pxr_UsdAttribute_SetConnections(void* jarg1, void* jarg2)
{
    auto* attr = static_cast<const pxr::UsdAttribute*>(jarg1);
    auto* paths = static_cast<const std::vector<pxr::SdfPath>*>(jarg2);

    if (!attr || !paths)
        return 0;

    bool ok = attr->SetConnections(*paths);
    return ok ? 1u : 0u;
}
// // usd - time/edit target
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_UsdTimeCode__SWIG_0(double jarg1)
{
    

    // jarg1 is just the double time value
    double time = jarg1;

    auto* tc = new pxr::UsdTimeCode(time);
    return static_cast<void*>(tc);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_UsdTimeCode_Default()
{
    UsdTimeCode result = UsdTimeCode::Default();
    return new UsdTimeCode(result);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_UsdEditTarget_GetLayer(void* jarg1)
{
    

    if (!jarg1)
        return nullptr;

    auto* editTarget = static_cast<pxr::UsdEditTarget*>(jarg1);

    // SWIG returns a pointer to the internal SdfLayerHandle
    const pxr::SdfLayerHandle& layer = editTarget->GetLayer();
    return const_cast<pxr::SdfLayerHandle*>(&layer);
}

// // usd - prim
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_UsdPrim_CreateAttribute__SWIG_0(
    void*        jarg1,
    void*        jarg2,
    void*        jarg3,
    unsigned int jarg4,
    int          jarg5)
{
    auto* prim  = static_cast<const pxr::UsdPrim*>(jarg1);
    auto* name  = static_cast<const pxr::TfToken*>(jarg2);
    auto* type  = static_cast<const pxr::SdfValueTypeName*>(jarg3);

    if (!prim || !name || !type)
        return nullptr;

    bool                custom      = (jarg4 != 0);
    pxr::SdfVariability variability = static_cast<pxr::SdfVariability>(jarg5);

    pxr::UsdAttribute attr =
        prim->CreateAttribute(*name, *type, custom, variability);

    return new pxr::UsdAttribute(attr);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_VtValue__SWIG_0()
{
    return new pxr::VtValue();
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_UsdPrim_CreateAttribute__SWIG_4(
    void*       jarg1,
    void*       jarg2,
    void*       jarg3,
    unsigned int jarg4,
    int         jarg5)
{
    auto* prim   = static_cast<const pxr::UsdPrim*>(jarg1);
    auto* names  = static_cast<const std::vector<std::string>*>(jarg2);
    auto* type   = static_cast<const pxr::SdfValueTypeName*>(jarg3);

    if (!prim || !names || !type)
        return nullptr;

    bool              custom      = (jarg4 != 0);
    pxr::SdfVariability variability = static_cast<pxr::SdfVariability>(jarg5);

    pxr::UsdAttribute attr =
        prim->CreateAttribute(*names, *type, custom, variability);

    return new pxr::UsdAttribute(attr);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_UsdPrim_GetAttribute(void* jarg1, void* jarg2)
{
    auto* prim  = static_cast<const pxr::UsdPrim*>(jarg1);
    auto* token = static_cast<const pxr::TfToken*>(jarg2);

    if (!prim || !token)
        return nullptr;

    pxr::UsdAttribute attr = prim->GetAttribute(*token);
    return new pxr::UsdAttribute(attr);
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_UsdPrim_GetTypeName(void* jarg1)
{
    if (!jarg1)
        return nullptr;

    auto* prim = static_cast<const pxr::UsdPrim*>(jarg1);

    // GetTypeName() returns: const TfToken&
    const pxr::TfToken& t = prim->GetTypeName();

    // SWIG returns the address of that internal token
    return const_cast<pxr::TfToken*>(&t);
}

extern "C" USDCS_EXPORT
unsigned int __cdecl CSharp_pxr_UsdPrim_SetTypeName(void* jarg1, void* jarg2)
{
    auto* prim  = static_cast<pxr::UsdPrim*>(jarg1);
    auto* token = static_cast<pxr::TfToken*>(jarg2);

    if (!prim || !token)
        return 0;

    bool ok = prim->SetTypeName(*token);
    return ok ? 1u : 0u;
}

// // usd - deletes
// // usd - object/property
extern "C" USDCS_EXPORT
unsigned int __cdecl CSharp_pxr_UsdObject__IsValid(void* jarg1)
{
    auto* obj = static_cast<pxr::UsdObject*>(jarg1);
    if (!obj)
        return 0;

    bool ok = obj->IsValid();
    return ok ? 1u : 0u;
}

extern "C" USDCS_EXPORT
unsigned int __cdecl CSharp_pxr_UsdObject_IsValid(void* jarg1)
{
    if (!jarg1)
        return 0;

    auto* obj = static_cast<const pxr::UsdObject*>(jarg1);

    bool valid = obj->IsValid();
    return valid ? 1u : 0u;
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_UsdSchemaBase_GetPath(void* jarg1)
{
    auto* schema = static_cast<const pxr::UsdSchemaBase*>(jarg1);
    if (!schema)
        return nullptr;

    pxr::SdfPath path = schema->GetPath();
    return new pxr::SdfPath(path);
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_UsdGeomMesh__SWIG_0(void* jarg1)
{
    auto* prim = static_cast<const pxr::UsdPrim*>(jarg1);
    if (!prim)
        return nullptr;

    return new pxr::UsdGeomMesh(*prim);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_UsdGeomBoundable_SWIGUpcast(void* jarg1)
{
    return (pxr::UsdGeomXformable*) jarg1;
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_UsdGeomGprim_SWIGUpcast(void* jarg1)
{
    return (pxr::UsdGeomBoundable*) jarg1;
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_UsdGeomMesh_SWIGUpcast(void* jarg1)
{
    return (pxr::UsdGeomPointBased*) jarg1;
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_UsdGeomXformable_SWIGUpcast(void* jarg1)
{
    return (pxr::UsdGeomImageable*) jarg1;
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_UsdGeomSubset_SWIGUpcast(void* jarg1)
{
    return (pxr::UsdTyped*) jarg1;
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_UsdGeomSubset_CreateUniqueGeomSubset__SWIG_1(
    void* jarg1,
    void* jarg2,
    void* jarg3,
    void* jarg4,
    void* jarg5)
{
    auto* imageable  = static_cast<const pxr::UsdGeomImageable*>(jarg1);
    auto* name       = static_cast<const pxr::TfToken*>(jarg2);
    auto* elementType= static_cast<const pxr::TfToken*>(jarg3);
    auto* indices    = static_cast<const pxr::VtArray<int>*>(jarg4);  // VtIntArray
    auto* familyName = static_cast<const pxr::TfToken*>(jarg5);

    if (!imageable || !name || !elementType || !indices || !familyName)
        return nullptr;

    pxr::UsdGeomSubset subset =
        pxr::UsdGeomSubset::CreateUniqueGeomSubset(
            *imageable,
            *name,
            *elementType,
            *indices,
            *familyName);

    return new pxr::UsdGeomSubset(subset);
}
extern "C" USDCS_EXPORT
pxr::UsdGeomGprim* __cdecl CSharp_pxr_UsdGeomPointBased_SWIGUpcast(
    pxr::UsdGeomPointBased* jarg1)
{
    return static_cast<pxr::UsdGeomGprim*>(jarg1);
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_UsdSchemaBase_GetPrim(void* jarg1)
{
    auto* schema = static_cast<const pxr::UsdSchemaBase*>(jarg1);
    if (!schema)
        return nullptr;

    pxr::UsdPrim prim = schema->GetPrim();
    return new pxr::UsdPrim(prim);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_UsdGeomPrimvar__SWIG_2(void* p0)
{
    auto* src = static_cast<pxr::UsdGeomPrimvar*>(p0);
    if (!src)
        return nullptr;

    return new pxr::UsdGeomPrimvar(*src);
}

// // Geom
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_UsdGeomImageable__SWIG_0(void* jarg1)
{
    auto* prim = static_cast<const pxr::UsdPrim*>(jarg1);
    if (!prim)
        return nullptr;

    // Same behavior as SWIG:
    // Construct a new heap-allocated UsdGeomImageable from the UsdPrim
    auto* img = new pxr::UsdGeomImageable(*prim);

    return img;
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_UsdGeomPrimvarsAPI__SWIG_2(void* p0)
{
    auto* base = static_cast<pxr::UsdSchemaBase*>(p0);
    if (!base)
        return nullptr;

    return new pxr::UsdGeomPrimvarsAPI(*base);
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_UsdGeomPrimvar_GetAttr(void* jarg1)
{
    auto* pv = static_cast<pxr::UsdGeomPrimvar*>(jarg1);
    if (!pv)
        return nullptr;

    // Returns a reference: const UsdAttribute&
    const pxr::UsdAttribute& attr = pv->GetAttr();

    // SWIG returns a pointer to the internal UsdAttribute
    return const_cast<pxr::UsdAttribute*>(&attr);
}


extern "C" USDCS_EXPORT
unsigned int __cdecl CSharp_pxr_UsdGeomPrimvar_SetElementSize(void* jarg1, int jarg2)
{
    auto* primvar = static_cast<pxr::UsdGeomPrimvar*>(jarg1);
    if (!primvar)
        return 0;

    bool ok = primvar->SetElementSize(jarg2);
    return ok ? 1u : 0u;
}

extern "C" USDCS_EXPORT
unsigned int __cdecl CSharp_pxr_UsdGeomPrimvar_SetInterpolation(void* jarg1, void* jarg2)
{
    auto* primvar = static_cast<pxr::UsdGeomPrimvar*>(jarg1);
    auto* token   = static_cast<pxr::TfToken*>(jarg2);

    if (!primvar || !token)
        return 0;

    bool ok = primvar->SetInterpolation(*token);
    return ok ? 1u : 0u;
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_UsdGeomPrimvarsAPI_CreatePrimvar__SWIG_1(
    void* jarg1,
    void* jarg2,
    void* jarg3,
    void* jarg4)
{
    auto* api         = static_cast<const pxr::UsdGeomPrimvarsAPI*>(jarg1);
    auto* name        = static_cast<const pxr::TfToken*>(jarg2);
    auto* typeName    = static_cast<const pxr::SdfValueTypeName*>(jarg3);
    auto* interpToken = static_cast<const pxr::TfToken*>(jarg4);

    if (!api || !name || !typeName || !interpToken)
        return nullptr;

    pxr::UsdGeomPrimvar pv =
        api->CreatePrimvar(*name, *typeName, *interpToken /* interpolation */);

    // SWIG returns a heap-allocated UsdGeomPrimvar
    return new pxr::UsdGeomPrimvar(pv);
}

extern "C" USDCS_EXPORT
pxr::UsdAPISchemaBase* __cdecl CSharp_pxr_UsdGeomPrimvarsAPI_SWIGUpcast(pxr::UsdGeomPrimvarsAPI* jarg1)
{
    return static_cast<pxr::UsdAPISchemaBase*>(jarg1);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_UsdShadeMaterial__SWIG_0(void* jarg1)
{
    auto* prim = static_cast<const pxr::UsdPrim*>(jarg1);
    if (!prim)
        return nullptr;

    return new pxr::UsdShadeMaterial(*prim);
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_UsdShadeMaterialBindingAPI__SWIG_0(void* jarg1)
{
    auto* prim = static_cast<const pxr::UsdPrim*>(jarg1);
    if (!prim)
        return nullptr;

    return new pxr::UsdShadeMaterialBindingAPI(*prim);
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_UsdShadeMaterial_SWIGUpcast(void* jarg1)
{
    return (pxr::UsdShadeNodeGraph*) jarg1;
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_UsdShadeMaterialBindingAPI_Apply(void* jarg1)
{
    auto* prim = static_cast<const pxr::UsdPrim*>(jarg1);
    if (!prim)
        return nullptr;

    pxr::UsdShadeMaterialBindingAPI api =
        pxr::UsdShadeMaterialBindingAPI::Apply(*prim);

    return new pxr::UsdShadeMaterialBindingAPI(api);
}

extern "C" USDCS_EXPORT
unsigned int __cdecl CSharp_pxr_UsdShadeMaterialBindingAPI_Bind__SWIG_2(
    void* jarg1,
    void* jarg2)
{
    auto* api      = static_cast<const pxr::UsdShadeMaterialBindingAPI*>(jarg1);
    auto* material = static_cast<const pxr::UsdShadeMaterial*>(jarg2);

    if (!api || !material)
        return 0;

    bool ok = api->Bind(*material);
    return ok ? 1u : 0u;
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_UsdShadeMaterialBindingAPI_SWIGUpcast(void* jarg1)
{
    return (pxr::UsdAPISchemaBase*)jarg1;
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_UsdShadeNodeGraph_SWIGUpcast(void* jarg1)
{
    return (pxr::UsdTyped*) jarg1;
}



// // utils
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_UsdUtilsSparseValueWriter()
{
    return new UsdUtilsSparseValueWriter();
}
extern "C" USDCS_EXPORT
unsigned int __cdecl CSharp_pxr_UsdUtilsCreateNewARKitUsdzPackage__SWIG_1(
    void* jarg1,
    char* jarg2)
{
    auto* path = static_cast<const pxr::SdfAssetPath*>(jarg1);
    if (!path || !jarg2)
        return 0;

    // SWIG converts jarg2 → temporary std::string(arg2_str)
    std::string dest(jarg2);

    bool ok = pxr::UsdUtilsCreateNewARKitUsdzPackage(*path, dest);
    return ok ? 1u : 0u;
}

extern "C" USDCS_EXPORT
unsigned int __cdecl CSharp_pxr_UsdUtilsSparseValueWriter_SetAttribute__SWIG_0(
    void* jarg1,
    void* jarg2,
    void* jarg3,
    void* jarg4)
{
    auto* writer = static_cast<pxr::UsdUtilsSparseValueWriter*>(jarg1);
    auto* attr   = static_cast<pxr::UsdAttribute*>(jarg2);
    auto* value  = static_cast<pxr::VtValue*>(jarg3);
    auto* time   = static_cast<pxr::UsdTimeCode*>(jarg4);

    if (!writer || !attr || !value || !time)
        return 0;

    pxr::UsdTimeCode t = *time;
    bool ok = writer->SetAttribute(*attr, *value, t);
    return ok ? 1u : 0u;
}


// // tokens
extern "C" USDCS_EXPORT
char* __cdecl CSharp_pxr_TfMakeValidIdentifier(char* jarg1)
{
    

    if (!jarg1)
        return nullptr; // SWIG would set an exception; we just return null.

    std::string input(jarg1);
    std::string result = pxr::TfMakeValidIdentifier(input);

    if (!g_tfStringCallback)
        return nullptr; // Should be set via SWIGRegisterStringCallback_Tf

    using StringCallback = char* (__stdcall*)(const char*);
    auto cb = reinterpret_cast<StringCallback>(g_tfStringCallback);

    return cb(result.c_str());
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_SdfValueTypeName_GetAsToken(void* jarg1)
{
    auto* arg1 = static_cast<SdfValueTypeName*>(jarg1);
    TfToken result = arg1->GetAsToken();
    return new TfToken(result);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_TfToken__SWIG_3(char* jarg1)
{
    if (!jarg1)
        return nullptr;   // stub: ignoring SWIG exception plumbing

    std::string s(jarg1);
    
    return new pxr::TfToken(s);
}
extern "C" USDCS_EXPORT
char* __cdecl CSharp_pxr_TfToken_GetText(void* jarg1)
{
    auto* arg1 = static_cast<TfToken*>(jarg1);
    const char* text = arg1->GetText();

    // callback type: char* (*)(const char*)
    using Callback = char* (__cdecl *)(const char*);

    auto cb = reinterpret_cast<Callback>(g_tfStringCallback);
    return cb ? cb(text) : nullptr;
}
// // tf - diagnostics
extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_TfDiagnosticMgr_AddDelegate(void* p0, void* p1)
{
    // Stub – ignore diagnostic delegate registration for now.
    (void)p0;
    (void)p1;
}
extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_TfDiagnosticMgr_Delegate_director_connect(
    void* p0, void* p1, void* p2, void* p3, void* p4)
{
    // stub – we ignore diagnostic delegate wiring for now
    (void)p0; (void)p1; (void)p2; (void)p3; (void)p4;
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_TfDiagnosticMgr_Delegate()
{
    // TODO: real TfDiagnosticMgr_Delegate implementation if we ever need it.
    // For now: return a non-null dummy pointer so SWIG has “an object”.
    static int dummy;
    return &dummy;
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_TfDiagnosticMgr_GetInstance()
{
    // TODO: real implementation if needed.
    // Return a stable dummy pointer for now.
    static int dummy;
    return &dummy;
}

// // sdf
extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_SdfLayerHandle_SetEndTimeCode(void* jarg1, double jarg2)
{
    

    if (!jarg1)
        return;

    auto* handle = static_cast<pxr::SdfLayerHandle*>(jarg1);

    pxr::SdfLayer* layer = handle->operator->();
    if (!layer)
        return;

    layer->SetEndTimeCode(jarg2);
}

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_SdfLayerHandle_SetStartTimeCode(void* jarg1, double jarg2)
{
    

    if (!jarg1)
        return;

    auto* handle = static_cast<pxr::SdfLayerHandle*>(jarg1);

    // Same semantics as SWIG:
    // (*handle) == underlying SdfLayer*
    pxr::SdfLayer* layer = handle->operator->();

    if (!layer)
        return;

    layer->SetStartTimeCode(jarg2);
}

extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_SdfPathVector_Add(void* jarg1, void* jarg2)
{
    auto* vec  = static_cast<std::vector<pxr::SdfPath>*>(jarg1);
    auto* path = static_cast<const pxr::SdfPath*>(jarg2);

    if (!vec || !path)
        return;

    vec->push_back(*path);
}
extern "C" USDCS_EXPORT
void __cdecl CSharp_pxr_StdStringVector_Add(void* jarg1, char* jarg2)
{
    auto* vec = static_cast<std::vector<std::string>*>(jarg1);
    if (!vec || !jarg2)
        return;

    vec->push_back(std::string(jarg2));
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_SdfAssetPath__SWIG_1(char* jarg1)
{
    if (!jarg1)
        return nullptr;

    std::string path(jarg1);
    return new pxr::SdfAssetPath(path);
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_SdfPath__SWIG_1(char* jarg1)
{
    

    if (!jarg1)
        return nullptr; // SWIG would set an exception; we just return null.

    std::string pathStr(jarg1);
    auto* path = new pxr::SdfPath(pathStr);
    return static_cast<void*>(path);
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_SdfPathVector__SWIG_0()
{
    return new std::vector<pxr::SdfPath>();
}
extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_new_StdStringVector__SWIG_2(int jarg1)
{
    if (jarg1 < 0)
        return nullptr; // SWIG would set an exception, but you skip that machinery

    // SWIG’s new_std_vector...__SWIG_2(arg1) == std::vector<std::string>(arg1)
    auto* vec = new std::vector<std::string>(static_cast<size_t>(jarg1));

    return static_cast<void*>(vec);
}

extern "C" USDCS_EXPORT
char* __cdecl CSharp_pxr_SdfLayerHandle_GetIdentifier(void* jarg1)
{
    if (!jarg1)
        return nullptr;

    auto* handle = static_cast<pxr::SdfLayerHandle*>(jarg1);
    pxr::SdfLayer* layer = handle->operator->();
    if (!layer)
        return nullptr;

    const std::string& id = layer->GetIdentifier();

    // Use Sdf string callback
    if (!g_sdfStringCallback)
        return nullptr;

    using StringCallback = char* (__stdcall*)(const char*);
    auto cb = reinterpret_cast<StringCallback>(g_sdfStringCallback);

    return cb(id.c_str());
}

extern "C" USDCS_EXPORT
void* __cdecl CSharp_pxr_SdfPath_AppendProperty(void* jarg1, void* jarg2)
{
    auto* path  = static_cast<const pxr::SdfPath*>(jarg1);
    auto* token = static_cast<const pxr::TfToken*>(jarg2);

    if (!path || !token)
        return nullptr;

    pxr::SdfPath result = path->AppendProperty(*token);
    return new pxr::SdfPath(result);
}
extern "C" USDCS_EXPORT
char* __cdecl CSharp_pxr_SdfPath_GetText(void* jarg1)
{
    

    if (!jarg1)
        return nullptr;

    auto* path = static_cast<const pxr::SdfPath*>(jarg1);

    const char* text = path->GetText();  // internal USD string (do NOT free)

    // Must use Sdf string callback
    if (!g_sdfStringCallback)
        return nullptr;

    using StringCallback = char* (__stdcall*)(const char*);
    auto cb = reinterpret_cast<StringCallback>(g_sdfStringCallback);

    return cb(text);
}
extern "C" USDCS_EXPORT
unsigned int __cdecl CSharp_pxr_SdfPath_IsRootPrimPath(void* jarg1)
{
    

    if (!jarg1)
        return 0;

    auto* path = static_cast<const pxr::SdfPath*>(jarg1);

    bool r = path->IsRootPrimPath();
    return r ? 1u : 0u;
}

// // unity/usdnet helpers



bool SetFusedDisplayColor(UsdPrim prim, VtVec4fArray values, UsdTimeCode time) {
  if (!prim) { return false; }

  UsdGeomMesh mesh(prim);
  auto rgbPv = mesh.CreateDisplayColorAttr();
  auto alphaPv = mesh.CreateDisplayOpacityAttr();
  
  mesh.GetDisplayColorPrimvar().SetInterpolation(UsdGeomTokens->vertex);
  mesh.GetDisplayOpacityPrimvar().SetInterpolation(UsdGeomTokens->vertex);

  size_t n = values.size();
  VtVec3fArray rgb(n);
  VtFloatArray alpha(n);

  for (size_t i = 0; i < n; i++) {
    rgb[i][0] = values[i][0];
    rgb[i][1] = values[i][1];
    rgb[i][2] = values[i][2];
    alpha[i] = values[i][3];
  }

  return rgbPv.Set(rgb, time) && alphaPv.Set(alpha, time);
}

extern "C" USDCS_EXPORT
unsigned int __cdecl CSharp_pxr_SetFusedDisplayColor(void* jarg1, void* jarg2, void* jarg3)
{
    auto* prim  = static_cast<pxr::UsdPrim*>(jarg1);
    auto* vals  = static_cast<pxr::VtVec4fArray*>(jarg2);
    auto* time  = static_cast<pxr::UsdTimeCode*>(jarg3);

    if (!prim || !vals || !time)
        return 0;

    bool ok = SetFusedDisplayColor(*prim, *vals, *time);
    return ok ? 1u : 0u;
}