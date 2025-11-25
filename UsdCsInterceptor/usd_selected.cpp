#include "UsdCs_wrapper_helpers.h"
#include "Logger.h"

// Swig callbacks not really usd
WRAP_PROC_VOID(SWIGRegisterExceptionArgumentCallbacks_UsdCs, __cdecl, (void* p0, void* p1, void* p2), (p0, p1, p2));
WRAP_PROC_VOID(SWIGRegisterExceptionCallbacks_UsdCs, __cdecl, (void* p0, void* p1, void* p2, void* p3, void* p4, void* p5, void* p6, void* p7, void* p8, void* p9, void* p10), (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10));
WRAP_PROC_VOID(SWIGRegisterStringCallback_Gf, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(SWIGRegisterStringCallback_Sdf, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(SWIGRegisterStringCallback_Std, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(SWIGRegisterStringCallback_Tf, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(SWIGRegisterStringCallback_Usd, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(SWIGRegisterStringCallback_UsdCs, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(SWIGRegisterStringCallback_UsdGeom, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(SWIGRegisterStringCallback_UsdShade, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(SWIGRegisterStringCallback_UsdUtils, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(SWIGRegisterStringCallback_Vt, __cdecl, (void* p0), (p0));

// Sdf type getters
WRAP_PROC(CSharp_pxr_SdfGetValueTypeAsset, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeAssetArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeBool, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeBoolArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeColor3d, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeColor3dArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeColor3f, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeColor3fArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeColor3h, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeColor3hArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeColor4d, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeColor4dArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeColor4f, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeColor4fArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeColor4h, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeColor4hArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeDouble, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeDouble2, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeDouble2Array, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeDouble3, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeDouble3Array, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeDouble4, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeDouble4Array, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeDoubleArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeFloat, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeFloat2, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeFloat2Array, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeFloat3, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeFloat3Array, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeFloat4, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeFloat4Array, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeFloatArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeFrame4d, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeFrame4dArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeGroup, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeHalf, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeHalf2, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeHalf2Array, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeHalf3, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeHalf3Array, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeHalf4, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeHalf4Array, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeHalfArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeInt, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeInt2, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeInt2Array, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeInt3, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeInt3Array, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeInt4, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeInt4Array, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeInt64, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeInt64Array, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeIntArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeMatrix2d, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeMatrix2dArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeMatrix3d, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeMatrix3dArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeMatrix4d, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeMatrix4dArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeNormal3d, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeNormal3dArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeNormal3f, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeNormal3fArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeNormal3h, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeNormal3hArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeOpaque, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypePoint3d, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypePoint3dArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypePoint3f, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypePoint3fArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypePoint3h, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypePoint3hArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeQuatd, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeQuatdArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeQuatf, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeQuatfArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeQuath, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeQuathArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeString, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeStringArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeTexCoord2d, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeTexCoord2dArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeTexCoord2f, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeTexCoord2fArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeTexCoord2h, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeTexCoord2hArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeTexCoord3d, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeTexCoord3dArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeTexCoord3f, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeTexCoord3fArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeTexCoord3h, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeTexCoord3hArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeTimeCode, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeTimeCodeArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeToken, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeTokenArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeUChar, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeUCharArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeUInt, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeUInt64, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeUInt64Array, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeUIntArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeVector3d, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeVector3dArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeVector3f, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeVector3fArray, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeVector3h, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_SdfGetValueTypeVector3hArray, void*, __cdecl, (), ());

// Gf math
WRAP_PROC(CSharp_pxr_new_GfMatrix4d__SWIG_1, void*, __cdecl, (double p0, double p1, double p2, double p3, double p4, double p5, double p6, double p7, double p8, double p9, double p10, double p11, double p12, double p13, double p14, double p15), (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15));
WRAP_PROC(CSharp_pxr_new_GfVec2f__SWIG_2, void*, __cdecl, (float p0, float p1), (p0, p1));
WRAP_PROC(CSharp_pxr_new_GfVec3f__SWIG_2, void*, __cdecl, (float p0, float p1, float p2), (p0, p1, p2));
WRAP_PROC(CSharp_pxr_new_GfVec4f__SWIG_2, void*, __cdecl, (float p0, float p1, float p2, float p3), (p0, p1, p2, p3));
WRAP_PROC_VOID(CSharp_pxr_delete_GfMatrix4d, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(CSharp_pxr_delete_GfVec2f, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(CSharp_pxr_delete_GfVec3f, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(CSharp_pxr_delete_GfVec4f, __cdecl, (void* p0), (p0));

// Values
WRAP_PROC_VOID(CSharp_pxr_delete_VtIntArray, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(CSharp_pxr_delete_VtTokenArray, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(CSharp_pxr_delete_VtValue, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(CSharp_pxr_delete_VtVec2fArray, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(CSharp_pxr_delete_VtVec3fArray, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(CSharp_pxr_delete_VtVec4fArray, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_new_VtIntArray__SWIG_3, void*, __cdecl, (unsigned int p0), (p0));
WRAP_PROC(CSharp_pxr_new_VtTokenArray__SWIG_3, void*, __cdecl, (unsigned int p0), (p0));
WRAP_PROC(CSharp_pxr_new_VtValue__SWIG_0, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_new_VtValue__SWIG_10, void*, __cdecl, (bool p0), (p0));
WRAP_PROC(CSharp_pxr_new_VtValue__SWIG_16, void*, __cdecl, (int p0), (p0));
WRAP_PROC(CSharp_pxr_new_VtValue__SWIG_17, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_new_VtValue__SWIG_36, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_new_VtValue__SWIG_37, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_new_VtValue__SWIG_38, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_new_VtValue__SWIG_39, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_new_VtValue__SWIG_4, void*, __cdecl, (double p0), (p0));
WRAP_PROC(CSharp_pxr_new_VtValue__SWIG_40, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_new_VtValue__SWIG_41, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_new_VtValue__SWIG_48, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_new_VtValue__SWIG_6, void*, __cdecl, (float p0), (p0));
WRAP_PROC(CSharp_pxr_new_VtValue__SWIG_70, void*, __cdecl, (const char* p0), (p0));
WRAP_PROC(CSharp_pxr_new_VtValue__SWIG_72, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_new_VtValue__SWIG_73, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_new_VtValue__SWIG_89, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_new_VtVec2fArray__SWIG_3, void*, __cdecl, (unsigned int p0), (p0));
WRAP_PROC(CSharp_pxr_new_VtVec3fArray__SWIG_3, void*, __cdecl, (unsigned int p0), (p0));
WRAP_PROC(CSharp_pxr_new_VtVec4fArray__SWIG_3, void*, __cdecl, (unsigned int p0), (p0));
WRAP_PROC(CSharp_pxr_VtIntArray_SWIGUpcast, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_VtTokenArray_SWIGUpcast, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_VtValueToTfToken__SWIG_0, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_VtValueToVtVec4fArray__SWIG_0, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_VtVec2fArray_SWIGUpcast, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_VtVec3fArray_SWIGUpcast, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_VtVec4fArray_SWIGUpcast, void*, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(CSharp_pxr_VtIntArray_CopyFromArray__SWIG_1, __cdecl, (void* p0, void* p1), (p0, p1));
WRAP_PROC_VOID(CSharp_pxr_VtTokenArray_SetValue, __cdecl, (void* p0, int p1, void* p2), (p0, p1, p2));
WRAP_PROC_VOID(CSharp_pxr_VtVec2fArray_CopyFromArray__SWIG_1, __cdecl, (void* p0, void* p1), (p0, p1));
WRAP_PROC_VOID(CSharp_pxr_VtVec3fArray_CopyFromArray__SWIG_1, __cdecl, (void* p0, void* p1), (p0, p1));
WRAP_PROC_VOID(CSharp_pxr_VtVec3fArray_SetValue, __cdecl, (void* p0, int p1, void* p2), (p0, p1, p2));
WRAP_PROC_VOID(CSharp_pxr_VtVec4fArray_CopyFromArray__SWIG_1, __cdecl, (void* p0, void* p1), (p0, p1));

// usd stage
WRAP_PROC_VOID(CSharp_pxr_delete_UsdStage, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_UsdStage_CreateNew__SWIG_1, void*, __cdecl, (const char* p0), (p0));
WRAP_PROC(CSharp_pxr_UsdStage_DefinePrim__SWIG_0, void*, __cdecl, (void* p0, void* p1, void* p2), (p0, p1, p2));
WRAP_PROC(CSharp_pxr_UsdStage_GetEditTarget, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_UsdStage_GetMetadata, bool, __cdecl, (void* p0, void* p1, void* p2), (p0, p1, p2));
WRAP_PROC(CSharp_pxr_UsdStage_GetPrimAtPath, void*, __cdecl, (void* p0, void* p1), (p0, p1));
WRAP_PROC(CSharp_pxr_UsdStage_SetMetadata, bool, __cdecl, (void* p0, void* p1, void* p2), (p0, p1, p2));
WRAP_PROC_VOID(CSharp_pxr_UsdStage_Save, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(CSharp_pxr_UsdStage_SetDefaultPrim, __cdecl, (void* p0, void* p1), (p0, p1));
// usd - object
WRAP_PROC_VOID(CSharp_pxr_UsdObject_SetCustomDataByKey, __cdecl, (void* p0, void* p1, void* p2), (p0, p1, p2));
WRAP_PROC(CSharp_pxr_UsdAttribute_SetConnections, bool, __cdecl, (void* p0, void* p1), (p0, p1));
// usd - time/edit target
WRAP_PROC_VOID(CSharp_pxr_delete_UsdTimeCode, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_new_UsdTimeCode__SWIG_0, void*, __cdecl, (double p0), (p0));
WRAP_PROC(CSharp_pxr_UsdTimeCode_Default, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_UsdEditTarget_GetLayer, void*, __cdecl, (void* p0), (p0));
// usd - prim
WRAP_PROC(CSharp_pxr_UsdPrim_CreateAttribute__SWIG_0, void*, __cdecl, (void* p0, void* p1, void* p2, bool p3, int p4), (p0, p1, p2, p3, p4));
WRAP_PROC(CSharp_pxr_UsdPrim_CreateAttribute__SWIG_4, void*, __cdecl, (void* p0, void* p1, void* p2, bool p3, int p4), (p0, p1, p2, p3, p4));
WRAP_PROC(CSharp_pxr_UsdPrim_GetAttribute, void*, __cdecl, (void* p0, void* p1), (p0, p1));
WRAP_PROC(CSharp_pxr_UsdPrim_GetTypeName, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_UsdPrim_SetTypeName, bool, __cdecl, (void* p0, void* p1), (p0, p1));
WRAP_PROC(CSharp_pxr_UsdPrim_SWIGUpcast, void*, __cdecl, (void* p0), (p0));
// usd - deletes
WRAP_PROC_VOID(CSharp_pxr_delete_UsdPrim, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(CSharp_pxr_delete_UsdAttribute, __cdecl, (void* p0), (p0));
// usd - object/property
WRAP_PROC(CSharp_pxr_UsdObject__IsValid, bool, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_UsdObject_IsValid, bool, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_UsdProperty_SWIGUpcast, void*, __cdecl, (void* p0), (p0));
// usd - schemabase/type
WRAP_PROC(CSharp_pxr_UsdSchemaBase_GetPath, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_UsdSchemaBase_GetPrim, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_UsdTyped_SWIGUpcast, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_UsdAPISchemaBase_SWIGUpcast, void*, __cdecl, (void* p0), (p0));

// Geom
WRAP_PROC_VOID(CSharp_pxr_delete_UsdGeomImageable, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(CSharp_pxr_delete_UsdGeomMesh, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(CSharp_pxr_delete_UsdGeomPrimvar, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(CSharp_pxr_delete_UsdGeomPrimvarsAPI, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(CSharp_pxr_delete_UsdGeomSubset, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_new_UsdGeomImageable__SWIG_0, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_new_UsdGeomMesh__SWIG_0, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_new_UsdGeomPrimvar__SWIG_2, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_new_UsdGeomPrimvarsAPI__SWIG_2, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_UsdGeomBoundable_SWIGUpcast, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_UsdGeomGprim_SWIGUpcast, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_UsdGeomImageable_SWIGUpcast, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_UsdGeomMesh_SWIGUpcast, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_UsdGeomPointBased_SWIGUpcast, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_UsdGeomPrimvar_GetAttr, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_UsdGeomPrimvar_SetElementSize, bool, __cdecl, (void* p0, int p1), (p0, p1));
WRAP_PROC(CSharp_pxr_UsdGeomPrimvar_SetInterpolation, bool, __cdecl, (void* p0, void* p1), (p0, p1));
WRAP_PROC(CSharp_pxr_UsdGeomPrimvarsAPI_CreatePrimvar__SWIG_1, void*, __cdecl, (void* p0, void* p1, void* p2, void* p3), (p0, p1, p2, p3));
WRAP_PROC(CSharp_pxr_UsdGeomPrimvarsAPI_SWIGUpcast, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_UsdGeomSubset_CreateUniqueGeomSubset__SWIG_1, void*, __cdecl, (void* p0, void* p1, void* p2, void* p3, void* p4), (p0, p1, p2, p3, p4));
WRAP_PROC(CSharp_pxr_UsdGeomSubset_SWIGUpcast, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_UsdGeomXformable_SWIGUpcast, void*, __cdecl, (void* p0), (p0));

// shade
WRAP_PROC_VOID(CSharp_pxr_delete_UsdShadeMaterial, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(CSharp_pxr_delete_UsdShadeMaterialBindingAPI, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_new_UsdShadeMaterial__SWIG_0, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_new_UsdShadeMaterialBindingAPI__SWIG_0, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_UsdShadeMaterial_SWIGUpcast, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_UsdShadeMaterialBindingAPI_Apply, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_UsdShadeMaterialBindingAPI_Bind__SWIG_2, bool, __cdecl, (void* p0, void* p1), (p0, p1));
WRAP_PROC(CSharp_pxr_UsdShadeMaterialBindingAPI_SWIGUpcast, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_UsdShadeNodeGraph_SWIGUpcast, void*, __cdecl, (void* p0), (p0));

// utils
WRAP_PROC(CSharp_pxr_new_UsdUtilsSparseValueWriter, void*, __cdecl, (), ());
WRAP_PROC_VOID(CSharp_pxr_delete_UsdUtilsSparseValueWriter, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_UsdUtilsCreateNewARKitUsdzPackage__SWIG_1, bool, __cdecl, (void* p0, const char* p1), (p0, p1));
WRAP_PROC(CSharp_pxr_UsdUtilsSparseValueWriter_SetAttribute__SWIG_0, bool, __cdecl, (void* p0, void* p1, void* p2, void* p3), (p0, p1, p2, p3));

// tokens
WRAP_PROC(CSharp_pxr_TfMakeValidIdentifier, const char*, __cdecl, (const char* p0), (p0));
WRAP_PROC_VOID(CSharp_pxr_delete_TfToken, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_SdfValueTypeName_GetAsToken, void*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_new_TfToken__SWIG_3, void*, __cdecl, (const char* p0), (p0));
WRAP_PROC(CSharp_pxr_TfToken_GetText, const char*, __cdecl, (void* p0), (p0));
// tf - diagnostics
WRAP_PROC_VOID(CSharp_pxr_TfDiagnosticMgr_AddDelegate, __cdecl, (void* p0, void* p1), (p0, p1));
WRAP_PROC_VOID(CSharp_pxr_TfDiagnosticMgr_Delegate_director_connect, __cdecl, (void* p0, void* p1, void* p2, void* p3, void* p4), (p0, p1, p2, p3, p4));
WRAP_PROC_VOID(CSharp_pxr_delete_TfDiagnosticMgr_Delegate, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_new_TfDiagnosticMgr_Delegate, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_TfDiagnosticMgr_GetInstance, void*, __cdecl, (), ());

// sdf
WRAP_PROC_VOID(CSharp_pxr_delete_SdfAssetPath, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(CSharp_pxr_delete_SdfPath, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(CSharp_pxr_delete_SdfPathVector, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(CSharp_pxr_delete_SdfValueTypeName, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(CSharp_pxr_delete_StdStringVector, __cdecl, (void* p0), (p0));
WRAP_PROC_VOID(CSharp_pxr_SdfLayerHandle_SetEndTimeCode, __cdecl, (void* p0, double p1), (p0, p1));
WRAP_PROC_VOID(CSharp_pxr_SdfLayerHandle_SetStartTimeCode, __cdecl, (void* p0, double p1), (p0, p1));
WRAP_PROC_VOID(CSharp_pxr_SdfPathVector_Add, __cdecl, (void* p0, void* p1), (p0, p1));
WRAP_PROC_VOID(CSharp_pxr_StdStringVector_Add, __cdecl, (void* p0, const char* p1), (p0, p1));
WRAP_PROC(CSharp_pxr_new_SdfAssetPath__SWIG_1, void*, __cdecl, (const char* p0), (p0));
WRAP_PROC(CSharp_pxr_new_SdfPath__SWIG_1, void*, __cdecl, (const char* p0), (p0));
WRAP_PROC(CSharp_pxr_new_SdfPathVector__SWIG_0, void*, __cdecl, (), ());
WRAP_PROC(CSharp_pxr_new_StdStringVector__SWIG_2, void*, __cdecl, (int p0), (p0));
WRAP_PROC(CSharp_pxr_SdfLayerHandle_GetIdentifier, const char*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_SdfPath_AppendProperty, void*, __cdecl, (void* p0, void* p1), (p0, p1));
WRAP_PROC(CSharp_pxr_SdfPath_GetText, const char*, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_SdfPath_IsRootPrimPath, bool, __cdecl, (void* p0), (p0));
WRAP_PROC(CSharp_pxr_UsdAttribute_SWIGUpcast, void*, __cdecl, (void* p0), (p0));

// unity/usdnet helpers
WRAP_PROC(CSharp_pxr_SetFusedDisplayColor, bool, __cdecl, (void* p0, void* p1, void* p2), (p0, p1, p2));