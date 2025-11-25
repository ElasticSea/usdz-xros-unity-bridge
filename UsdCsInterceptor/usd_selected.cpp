#include "UsdCs_wrapper_helpers.h"
#include "Logger.h"

#define LOG_ARGS_NONE ((void)0)
#define LOG_ARGS_PTR1(a) do { LogArgPtr(#a, a); } while (0)
#define LOG_ARGS_PTR2(a,b) do { LogArgPtr(#a, a); LogArgPtr(#b, b); } while (0)
#define LOG_ARGS_PTR3(a,b,c) do { LogArgPtr(#a, a); LogArgPtr(#b, b); LogArgPtr(#c, c); } while (0)
#define LOG_ARGS_PTR4(a,b,c,d) do { LogArgPtr(#a,a); LogArgPtr(#b,b); LogArgPtr(#c,c); LogArgPtr(#d,d); } while(0)
#define LOG_ARGS_PTR5(a,b,c,d,e) do { LogArgPtr(#a,a); LogArgPtr(#b,b); LogArgPtr(#c,c); LogArgPtr(#d,d); LogArgPtr(#e,e); } while(0)
#define LOG_ARGS_PTR11(a,b,c,d,e,f,g,h,i,j,k) do { LogArgPtr(#a, a); LogArgPtr(#b, b); LogArgPtr(#c, c); LogArgPtr(#d, d); LogArgPtr(#e, e); LogArgPtr(#f, f); LogArgPtr(#g, g); LogArgPtr(#h, h); LogArgPtr(#i, i); LogArgPtr(#j, j); LogArgPtr(#k, k); } while (0)
#define LOG_ARGS_D16(a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p) do { LogArgDouble(#a,a); LogArgDouble(#b,b); LogArgDouble(#c,c); LogArgDouble(#d,d); LogArgDouble(#e,e); LogArgDouble(#f,f); LogArgDouble(#g,g); LogArgDouble(#h,h); LogArgDouble(#i,i); LogArgDouble(#j,j); LogArgDouble(#k,k); LogArgDouble(#l,l); LogArgDouble(#m,m); LogArgDouble(#n,n); LogArgDouble(#o,o); LogArgDouble(#p,p); } while(0)
#define LOG_ARGS_F2(a,b) do { LogArgFloat(#a,a); LogArgFloat(#b,b); } while(0)
#define LOG_ARGS_F3(a,b,c)  do { LogArgFloat(#a,a); LogArgFloat(#b,b); LogArgFloat(#c,c); } while(0)
#define LOG_ARGS_F4(a,b,c,d) do { LogArgFloat(#a,a); LogArgFloat(#b,b); LogArgFloat(#c,c); LogArgFloat(#d,d); } while(0)
#define LOG_ARGS_U1(a) do { LogArgUInt(#a, a); } while (0)
#define LOG_ARGS_PTR_I_PTR(a,b,c) do { LogArgPtr(#a,a); LogArgInt(#b,b); LogArgPtr(#c,c); } while(0)
#define LOG_ARGS_B1(a) do { LogArgBool(#a,a); } while(0)
#define LOG_ARGS_I1(a) do { LogArgInt(#a,a); } while(0)
#define LOG_ARGS_F1(a) do { LogArgFloat(#a,a); } while(0)
#define LOG_ARGS_D1(a) do { LogArgDouble(#a,a); } while(0)
#define LOG_ARGS_STR1(a) do { LogArgString(#a,a); } while(0)
#define LOG_ARGS_PTR3_B1_I1(a,b,c,d,e) do { LogArgPtr(#a,a); LogArgPtr(#b,b); LogArgPtr(#c,c); LogArgBool(#d,d); LogArgInt(#e,e); } while(0)
#define LOG_ARGS_PTR1_I1(a,b) do { LogArgPtr(#a,a); LogArgInt(#b,b); } while(0)
#define LOG_ARGS_PTR1_STR1(a,b) do { LogArgPtr(#a,a); LogArgString(#b,b); } while(0)
#define LOG_ARGS_PTR1_D1(a,b) do { LogArgPtr(#a,a); LogArgDouble(#b,b); } while(0)

// Swig callbacks not really usd
WRAP_VOID(SWIGRegisterExceptionArgumentCallbacks_UsdCs, __cdecl, (void* p0, void* p1, void* p2), (p0, p1, p2), LOG_ARGS_PTR3(p0, p1, p2));
WRAP_VOID(SWIGRegisterExceptionCallbacks_UsdCs, __cdecl, (void* p0, void* p1, void* p2, void* p3, void* p4, void* p5, void* p6, void* p7, void* p8, void* p9, void* p10), (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10), LOG_ARGS_PTR11(p0,p1,p2,p3,p4,p5,p6,p7,p8,p9,p10));
WRAP_VOID(SWIGRegisterStringCallback_Gf, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(SWIGRegisterStringCallback_Sdf, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(SWIGRegisterStringCallback_Std, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(SWIGRegisterStringCallback_Tf, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(SWIGRegisterStringCallback_Usd, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(SWIGRegisterStringCallback_UsdCs, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(SWIGRegisterStringCallback_UsdGeom, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(SWIGRegisterStringCallback_UsdShade, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(SWIGRegisterStringCallback_UsdUtils, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(SWIGRegisterStringCallback_Vt, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));

// Sdf type getters
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeAsset, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeAssetArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeBool, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeBoolArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeColor3d, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeColor3dArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeColor3f, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeColor3fArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeColor3h, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeColor3hArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeColor4d, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeColor4dArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeColor4f, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeColor4fArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeColor4h, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeColor4hArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeDouble, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeDouble2, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeDouble2Array, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeDouble3, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeDouble3Array, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeDouble4, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeDouble4Array, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeDoubleArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeFloat, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeFloat2, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeFloat2Array, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeFloat3, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeFloat3Array, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeFloat4, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeFloat4Array, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeFloatArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeFrame4d, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeFrame4dArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeGroup, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeHalf, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeHalf2, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeHalf2Array, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeHalf3, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeHalf3Array, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeHalf4, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeHalf4Array, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeHalfArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeInt, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeInt2, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeInt2Array, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeInt3, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeInt3Array, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeInt4, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeInt4Array, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeInt64, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeInt64Array, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeIntArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeMatrix2d, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeMatrix2dArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeMatrix3d, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeMatrix3dArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeMatrix4d, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeMatrix4dArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeNormal3d, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeNormal3dArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeNormal3f, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeNormal3fArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeNormal3h, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeNormal3hArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeOpaque, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypePoint3d, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypePoint3dArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypePoint3f, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypePoint3fArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypePoint3h, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypePoint3hArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeQuatd, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeQuatdArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeQuatf, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeQuatfArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeQuath, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeQuathArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeString, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeStringArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeTexCoord2d, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeTexCoord2dArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeTexCoord2f, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeTexCoord2fArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeTexCoord2h, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeTexCoord2hArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeTexCoord3d, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeTexCoord3dArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeTexCoord3f, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeTexCoord3fArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeTexCoord3h, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeTexCoord3hArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeTimeCode, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeTimeCodeArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeToken, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeTokenArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeUChar, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeUCharArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeUInt, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeUInt64, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeUInt64Array, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeUIntArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeVector3d, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeVector3dArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeVector3f, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeVector3fArray, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeVector3h, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_SdfGetValueTypeVector3hArray, __cdecl, (), (), LOG_ARGS_NONE);

// Gf math
WRAP_POINTER(CSharp_pxr_new_GfMatrix4d__SWIG_1, __cdecl, (double p0, double p1, double p2, double p3, double p4, double p5, double p6, double p7, double p8, double p9, double p10, double p11, double p12, double p13, double p14, double p15), (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15), LOG_ARGS_D16(p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15));
WRAP_POINTER(CSharp_pxr_new_GfVec2f__SWIG_2, __cdecl, (float p0, float p1), (p0, p1), LOG_ARGS_F2(p0, p1));
WRAP_POINTER(CSharp_pxr_new_GfVec3f__SWIG_2, __cdecl, (float p0, float p1, float p2), (p0, p1, p2), LOG_ARGS_F3(p0, p1, p2));
WRAP_POINTER(CSharp_pxr_new_GfVec4f__SWIG_2, __cdecl, (float p0, float p1, float p2, float p3), (p0, p1, p2, p3), LOG_ARGS_F4(p0, p1, p2, p3));
WRAP_VOID(CSharp_pxr_delete_GfMatrix4d, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(CSharp_pxr_delete_GfVec2f, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(CSharp_pxr_delete_GfVec3f, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(CSharp_pxr_delete_GfVec4f, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));

// Values
WRAP_VOID(CSharp_pxr_delete_VtIntArray, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(CSharp_pxr_delete_VtTokenArray, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(CSharp_pxr_delete_VtValue, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(CSharp_pxr_delete_VtVec2fArray, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(CSharp_pxr_delete_VtVec3fArray, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(CSharp_pxr_delete_VtVec4fArray, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_new_VtIntArray__SWIG_3, __cdecl, (unsigned int p0), (p0), LOG_ARGS_U1(p0));
WRAP_POINTER(CSharp_pxr_new_VtTokenArray__SWIG_3, __cdecl, (unsigned int p0), (p0), LOG_ARGS_U1(p0));
WRAP_POINTER(CSharp_pxr_new_VtValue__SWIG_0, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_new_VtValue__SWIG_10, __cdecl, (bool p0), (p0), LOG_ARGS_B1(p0));
WRAP_POINTER(CSharp_pxr_new_VtValue__SWIG_16, __cdecl, (int p0), (p0), LOG_ARGS_I1(p0));
WRAP_POINTER(CSharp_pxr_new_VtValue__SWIG_17, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_new_VtValue__SWIG_36, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_new_VtValue__SWIG_37, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_new_VtValue__SWIG_38, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_new_VtValue__SWIG_39, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_new_VtValue__SWIG_40, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_new_VtValue__SWIG_41, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_new_VtValue__SWIG_48, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_new_VtValue__SWIG_72, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_new_VtValue__SWIG_73, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_new_VtValue__SWIG_89, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_new_VtValue__SWIG_4, __cdecl, (double p0), (p0), LOG_ARGS_D1(p0));
WRAP_POINTER(CSharp_pxr_new_VtValue__SWIG_6, __cdecl, (float p0), (p0), LOG_ARGS_F1(p0));
WRAP_POINTER(CSharp_pxr_new_VtValue__SWIG_70, __cdecl, (const char* p0), (p0), LOG_ARGS_STR1(p0));
WRAP_POINTER(CSharp_pxr_new_VtVec2fArray__SWIG_3, __cdecl, (unsigned int p0), (p0), LOG_ARGS_U1(p0));
WRAP_POINTER(CSharp_pxr_new_VtVec3fArray__SWIG_3, __cdecl, (unsigned int p0), (p0), LOG_ARGS_U1(p0));
WRAP_POINTER(CSharp_pxr_new_VtVec4fArray__SWIG_3, __cdecl, (unsigned int p0), (p0), LOG_ARGS_U1(p0));
WRAP_POINTER(CSharp_pxr_VtIntArray_SWIGUpcast, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_VtTokenArray_SWIGUpcast, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_VtValueToTfToken__SWIG_0, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_VtValueToVtVec4fArray__SWIG_0, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_VtVec2fArray_SWIGUpcast, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_VtVec3fArray_SWIGUpcast, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_VtVec4fArray_SWIGUpcast, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(CSharp_pxr_VtIntArray_CopyFromArray__SWIG_1, __cdecl, (void* p0, void* p1), (p0, p1), LOG_ARGS_PTR2(p0, p1));
WRAP_VOID(CSharp_pxr_VtTokenArray_SetValue, __cdecl, (void* p0, int p1, void* p2), (p0, p1, p2), LOG_ARGS_PTR_I_PTR(p0, p1, p2));
WRAP_VOID(CSharp_pxr_VtVec2fArray_CopyFromArray__SWIG_1, __cdecl, (void* p0, void* p1), (p0, p1), LOG_ARGS_PTR2(p0, p1));
WRAP_VOID(CSharp_pxr_VtVec3fArray_CopyFromArray__SWIG_1, __cdecl, (void* p0, void* p1), (p0, p1), LOG_ARGS_PTR2(p0, p1));
WRAP_VOID(CSharp_pxr_VtVec3fArray_SetValue, __cdecl, (void* p0, int p1, void* p2), (p0, p1, p2), LOG_ARGS_PTR_I_PTR(p0, p1, p2));
WRAP_VOID(CSharp_pxr_VtVec4fArray_CopyFromArray__SWIG_1, __cdecl, (void* p0, void* p1), (p0, p1), LOG_ARGS_PTR2(p0, p1));

// usd stage
WRAP_VOID(CSharp_pxr_delete_UsdStage, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_UsdStage_CreateNew__SWIG_1, __cdecl, (const char* p0), (p0), LOG_ARGS_STR1(p0));
WRAP_POINTER(CSharp_pxr_UsdStage_DefinePrim__SWIG_0, __cdecl, (void* p0, void* p1, void* p2), (p0, p1, p2), LOG_ARGS_PTR3(p0, p1, p2));
WRAP_POINTER(CSharp_pxr_UsdStage_GetEditTarget, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_BOOL(CSharp_pxr_UsdStage_GetMetadata, __cdecl, (void* p0, void* p1, void* p2), (p0, p1, p2), LOG_ARGS_PTR3(p0, p1, p2));
WRAP_POINTER(CSharp_pxr_UsdStage_GetPrimAtPath, __cdecl, (void* p0, void* p1), (p0, p1), LOG_ARGS_PTR2(p0, p1));
WRAP_BOOL(CSharp_pxr_UsdStage_SetMetadata, __cdecl, (void* p0, void* p1, void* p2), (p0, p1, p2), LOG_ARGS_PTR3(p0, p1, p2));
WRAP_VOID(CSharp_pxr_UsdStage_Save, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(CSharp_pxr_UsdStage_SetDefaultPrim, __cdecl, (void* p0, void* p1), (p0, p1), LOG_ARGS_PTR2(p0, p1));

// usd - object
WRAP_VOID(CSharp_pxr_UsdObject_SetCustomDataByKey, __cdecl, (void* p0, void* p1, void* p2), (p0, p1, p2), LOG_ARGS_PTR3(p0, p1, p2));
WRAP_BOOL(CSharp_pxr_UsdAttribute_SetConnections, __cdecl, (void* p0, void* p1), (p0, p1), LOG_ARGS_PTR2(p0, p1));
// usd - time/edit target
WRAP_VOID(CSharp_pxr_delete_UsdTimeCode, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_new_UsdTimeCode__SWIG_0, __cdecl, (double p0), (p0), LOG_ARGS_D1(p0));
WRAP_POINTER(CSharp_pxr_UsdTimeCode_Default, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_UsdEditTarget_GetLayer, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
// usd - prim
WRAP_POINTER(CSharp_pxr_UsdPrim_CreateAttribute__SWIG_0, __cdecl, (void* p0, void* p1, void* p2, bool p3, int p4), (p0, p1, p2, p3, p4), LOG_ARGS_PTR3_B1_I1(p0, p1, p2, p3, p4));
WRAP_POINTER(CSharp_pxr_UsdPrim_CreateAttribute__SWIG_4, __cdecl, (void* p0, void* p1, void* p2, bool p3, int p4), (p0, p1, p2, p3, p4), LOG_ARGS_PTR3_B1_I1(p0, p1, p2, p3, p4));
WRAP_POINTER(CSharp_pxr_UsdPrim_GetAttribute, __cdecl, (void* p0, void* p1), (p0, p1), LOG_ARGS_PTR2(p0, p1));
WRAP_POINTER(CSharp_pxr_UsdPrim_GetTypeName, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_BOOL(CSharp_pxr_UsdPrim_SetTypeName, __cdecl, (void* p0, void* p1), (p0, p1), LOG_ARGS_PTR2(p0, p1));
WRAP_POINTER(CSharp_pxr_UsdPrim_SWIGUpcast, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
// usd - deletes
WRAP_VOID(CSharp_pxr_delete_UsdPrim, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(CSharp_pxr_delete_UsdAttribute, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
// usd - object/property
WRAP_BOOL(CSharp_pxr_UsdObject__IsValid, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_BOOL(CSharp_pxr_UsdObject_IsValid, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_UsdProperty_SWIGUpcast, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
// usd - schemabase/type
WRAP_POINTER(CSharp_pxr_UsdSchemaBase_GetPath, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_UsdSchemaBase_GetPrim, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_UsdTyped_SWIGUpcast, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_UsdAPISchemaBase_SWIGUpcast, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));

// Geom
WRAP_VOID(CSharp_pxr_delete_UsdGeomImageable, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(CSharp_pxr_delete_UsdGeomMesh, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(CSharp_pxr_delete_UsdGeomPrimvar, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(CSharp_pxr_delete_UsdGeomPrimvarsAPI, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(CSharp_pxr_delete_UsdGeomSubset, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_new_UsdGeomImageable__SWIG_0, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_new_UsdGeomMesh__SWIG_0, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_new_UsdGeomPrimvar__SWIG_2, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_new_UsdGeomPrimvarsAPI__SWIG_2, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));

WRAP_POINTER(CSharp_pxr_UsdGeomBoundable_SWIGUpcast, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_UsdGeomGprim_SWIGUpcast, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_UsdGeomImageable_SWIGUpcast, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_UsdGeomMesh_SWIGUpcast, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_UsdGeomPointBased_SWIGUpcast, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));

WRAP_POINTER(CSharp_pxr_UsdGeomPrimvar_GetAttr, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));

WRAP_BOOL(CSharp_pxr_UsdGeomPrimvar_SetElementSize, __cdecl, (void* p0, int p1), (p0, p1), LOG_ARGS_PTR1_I1(p0, p1));
WRAP_BOOL(CSharp_pxr_UsdGeomPrimvar_SetInterpolation, __cdecl, (void* p0, void* p1), (p0, p1), LOG_ARGS_PTR2(p0, p1));
WRAP_POINTER(CSharp_pxr_UsdGeomPrimvarsAPI_CreatePrimvar__SWIG_1, __cdecl, (void* p0, void* p1, void* p2, void* p3), (p0, p1, p2, p3), LOG_ARGS_PTR4(p0, p1, p2, p3));
WRAP_POINTER(CSharp_pxr_UsdGeomPrimvarsAPI_SWIGUpcast, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_UsdGeomSubset_CreateUniqueGeomSubset__SWIG_1, __cdecl, (void* p0, void* p1, void* p2, void* p3, void* p4), (p0, p1, p2, p3, p4), LOG_ARGS_PTR5(p0, p1, p2, p3, p4));
WRAP_POINTER(CSharp_pxr_UsdGeomSubset_SWIGUpcast, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_UsdGeomXformable_SWIGUpcast, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));

// shade
WRAP_VOID(CSharp_pxr_delete_UsdShadeMaterial, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(CSharp_pxr_delete_UsdShadeMaterialBindingAPI, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_new_UsdShadeMaterial__SWIG_0, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_new_UsdShadeMaterialBindingAPI__SWIG_0, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_UsdShadeMaterial_SWIGUpcast, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_UsdShadeMaterialBindingAPI_Apply, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_BOOL(CSharp_pxr_UsdShadeMaterialBindingAPI_Bind__SWIG_2, __cdecl, (void* p0, void* p1), (p0, p1), LOG_ARGS_PTR2(p0, p1));
WRAP_POINTER(CSharp_pxr_UsdShadeMaterialBindingAPI_SWIGUpcast, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_UsdShadeNodeGraph_SWIGUpcast, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));

// utils
WRAP_POINTER(CSharp_pxr_new_UsdUtilsSparseValueWriter, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_VOID(CSharp_pxr_delete_UsdUtilsSparseValueWriter, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_BOOL(CSharp_pxr_UsdUtilsCreateNewARKitUsdzPackage__SWIG_1, __cdecl, (void* p0, const char* p1), (p0, p1), LOG_ARGS_PTR1_STR1(p0, p1));
WRAP_BOOL(CSharp_pxr_UsdUtilsSparseValueWriter_SetAttribute__SWIG_0, __cdecl, (void* p0, void* p1, void* p2, void* p3), (p0, p1, p2, p3), LOG_ARGS_PTR4(p0, p1, p2, p3));

// tokens
WRAP_CSTR(CSharp_pxr_TfMakeValidIdentifier, __cdecl, (const char* p0), (p0), LOG_ARGS_STR1(p0));
WRAP_VOID(CSharp_pxr_delete_TfToken, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_SdfValueTypeName_GetAsToken, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_new_TfToken__SWIG_3, __cdecl, (const char* p0), (p0), LOG_ARGS_STR1(p0));
WRAP_CSTR(CSharp_pxr_TfToken_GetText, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
// tf - diagnostics
WRAP_VOID(CSharp_pxr_TfDiagnosticMgr_AddDelegate, __cdecl, (void* p0, void* p1), (p0, p1), LOG_ARGS_PTR2(p0, p1));
WRAP_VOID(CSharp_pxr_TfDiagnosticMgr_Delegate_director_connect, __cdecl, (void* p0, void* p1, void* p2, void* p3, void* p4), (p0, p1, p2, p3, p4), LOG_ARGS_PTR5(p0, p1, p2, p3, p4));
WRAP_VOID(CSharp_pxr_delete_TfDiagnosticMgr_Delegate, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_new_TfDiagnosticMgr_Delegate, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_TfDiagnosticMgr_GetInstance, __cdecl, (), (), LOG_ARGS_NONE);

// sdf
WRAP_VOID(CSharp_pxr_delete_SdfAssetPath, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(CSharp_pxr_delete_SdfPath, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(CSharp_pxr_delete_SdfPathVector, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(CSharp_pxr_delete_SdfValueTypeName, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(CSharp_pxr_delete_StdStringVector, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_VOID(CSharp_pxr_SdfLayerHandle_SetEndTimeCode, __cdecl, (void* p0, double p1), (p0, p1), LOG_ARGS_PTR1_D1(p0, p1));
WRAP_VOID(CSharp_pxr_SdfLayerHandle_SetStartTimeCode, __cdecl, (void* p0, double p1), (p0, p1), LOG_ARGS_PTR1_D1(p0, p1));
WRAP_VOID(CSharp_pxr_SdfPathVector_Add, __cdecl, (void* p0, void* p1), (p0, p1), LOG_ARGS_PTR2(p0, p1));
WRAP_VOID(CSharp_pxr_StdStringVector_Add, __cdecl, (void* p0, const char* p1), (p0, p1), LOG_ARGS_PTR1_STR1(p0, p1));

WRAP_POINTER(CSharp_pxr_new_SdfAssetPath__SWIG_1, __cdecl, (const char* p0), (p0), LOG_ARGS_STR1(p0));
WRAP_POINTER(CSharp_pxr_new_SdfPath__SWIG_1, __cdecl, (const char* p0), (p0), LOG_ARGS_STR1(p0));
WRAP_POINTER(CSharp_pxr_new_SdfPathVector__SWIG_0, __cdecl, (), (), LOG_ARGS_NONE);
WRAP_POINTER(CSharp_pxr_new_StdStringVector__SWIG_2, __cdecl, (int p0), (p0), LOG_ARGS_I1(p0));

WRAP_CSTR(CSharp_pxr_SdfLayerHandle_GetIdentifier, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_SdfPath_AppendProperty, __cdecl, (void* p0, void* p1), (p0, p1), LOG_ARGS_PTR2(p0, p1));
WRAP_CSTR(CSharp_pxr_SdfPath_GetText, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_BOOL(CSharp_pxr_SdfPath_IsRootPrimPath, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));
WRAP_POINTER(CSharp_pxr_UsdAttribute_SWIGUpcast, __cdecl, (void* p0), (p0), LOG_ARGS_PTR1(p0));

// unity/usdnet helpers
WRAP_BOOL(CSharp_pxr_SetFusedDisplayColor, __cdecl, (void* p0, void* p1, void* p2), (p0, p1, p2), LOG_ARGS_PTR3(p0, p1, p2));