namespace EscapeUnusedMethods;

public static class Export
{
    public static string ExportMethods(MethodSignature[] managedSignatures)
    {
        var output = "";

        output += "#include <cstdint>\n" +
                  "\n";

        output += "#if defined(_WIN32)\n" +
                  "#   define USDCS_EXPORT __declspec(dllexport)\n" +
                  "#else\n" +
                  "#   define USDCS_EXPORT __attribute__((visibility(\"default\")))\n" +
                  "#endif\n" +
                  "\n";

        foreach (var ms in managedSignatures)
        {
            var returnSig = GetReturnTypeSig(ms.ReturnType);
            var nameSig = ms.Signature;

            // Fix: if no args -> use "void"
            var argsSig = ms.Args.Length == 0
                ? "void"
                : string.Join(", ", ms.Args.Select(a =>
                {
                    var cppType = ToCppArgType(a.type);
                    return $"{cppType} {a.name}";
                }));

            // Fix: ensure return statement ends with semicolon + indent correctly
            string returnValue = GetReturnImpl(ms.ReturnType);
            if (!string.IsNullOrEmpty(returnValue))
                returnValue = "    " + returnValue; // indent inside the function
            else
                returnValue = ""; // void-return functions
    
            output += "extern \"C\" USDCS_EXPORT\n" +
                      $"{returnSig} __cdecl {nameSig}({argsSig})\n" +
                      "{\n" +
                      $"{returnValue}\n" +
                      "}\n";
        }

        return output;
    }

    private static string ToCppArgType(string cs)
    {
        switch (cs)
        {
            case "double": return "double";
            case "float": return "float";
            case "byte": return "unsigned char";
            case "int": return "int";
            case "uint": return "unsigned int";
            case "string": return "char*";
            case "IntPtr": return "void*";
            case "bool": return "bool";
            case "long": return "int64_t";
            case "ulong": return "uint64_t";
            case "char": return "char";
            case "ushort": return "unsigned short";

            case "out double": return "double*";
            case "out byte": return "unsigned char*";
            case "out char": return "char*";
            case "out float": return "float*";
            case "out int": return "int*";
            case "out uint": return "unsigned int*";
            case "out bool": return "bool*";
            case "out long": return "int64_t*";
            case "out ulong": return "uint64_t*";
            case "out string": return "char**";
            case "GfHalf": return "uint16_t";
            
            case "out UsdGeomXformCommonAPI.RotationOrder": return "int*";
            case "out UsdShadeAttributeType": return "int*";
            case "UsdTimeCode": return "double"; // special: real C++ type


            case "ExceptionDelegate":
            case "ExceptionArgumentDelegate":
            case "SWIGStringDelegate":
            case "HandleRef":
            case "TfDiagnosticMgr.Delegate.SwigDelegateDelegate_0":
            case "TfDiagnosticMgr.Delegate.SwigDelegateDelegate_1":
            case "TfDiagnosticMgr.Delegate.SwigDelegateDelegate_2":
            case "TfDiagnosticMgr.Delegate.SwigDelegateDelegate_3":
            case "TfDiagnosticMgr.Delegate.SwigDelegateDelegate_4":
            case "TfDiagnosticMgr.Delegate.SwigDelegateDelegate_5":

            case "SdfAssetPath":
            case "SdfAssetPathArray":
            case "SdfPathVector":
            case "SdfVariantSelection":

            case "SdfPrimSpecHandle":
            case "SdfLayerRefPtr":
            case "UsdPrim":
            case "UsdAttribute":
            case "UsdRelationship":
            case "UsdStage":
                
            case "GfRect2i": 
            case "GfBBox3d": 
            case "GfPlane": 
            case "GfFrustum": 
            case "GfRay": 
            case "GfLine3d": 
            case "GfRange1i": 
            case "GfRange2i": 
            case "GfRange3i": 
            case "GfVec1i": 
            case "GfVec2i": 
            case "GfVec3i": 
            case "GfVec4i": 
            case "GfVec1h": 
            case "GfVec2h": 
            case "GfVec3h": 
            case "GfVec4h": 
            case "GfVec1f": 
            case "GfVec2f": 
            case "GfVec3f": 
            case "GfVec4f": 
            case "GfVec1d": 
            case "GfVec2d": 
            case "GfVec3d": 
            case "GfVec4d": 
            case "GfMatrix1d": 
            case "GfMatrix2d": 
            case "GfMatrix3d": 
            case "GfMatrix4d": 
            case "GfMatrix1f": 
            case "GfMatrix2f": 
            case "GfMatrix3f": 
            case "GfMatrix4f": 
            case "GfRange1d": 
            case "GfRange2d": 
            case "GfRange3d": 
            case "GfRange4d": 
            case "GfRange1f": 
            case "GfRange2f": 
            case "GfRange3f": 
            case "GfRange4f": 
            case "GfInterval": 
            case "TfToken": 
            case "GfQuath": 
            case "GfQuatf": 
            case "GfQuatd": 
            case "GfDualQuatf": 
            case "GfDualQuatd": 
            case "GfDualQuath": 
            case "GfQuaternion":
            case "GfQuaternionh":
            case "GfQuaternionf":
            case "GfQuaterniond":
                return "void*";

            default:
                throw new Exception("Unknown arg type: " + cs);
        }
    }
    
    private static string GetReturnTypeSig(returns ret)
    {
        switch (ret)
        {
            case returns.@void:
                return "void";

            case returns.IntPtr:
                return "void*";

            case returns.@bool:
                return "bool";

            case returns.@string:
                return "char*";

            case returns.@double:
                return "double";

            case returns.@int:
                return "int";

            case returns.@float:
                return "float";

            case returns.@byte:
                return "unsigned char";

            case returns.@uint:
                return "unsigned int";

            case returns.@long:
                return "int64_t";

            case returns.@ulong:
                return "uint64_t";

            case returns.@char:
                return "char";

            case returns.@ushort:
                return "unsigned short";

            default:
                throw new ArgumentOutOfRangeException(nameof(ret), ret, null);
        }
    }

    private static string GetReturnImpl(returns ret)
    {
        switch (ret)
        {
            case returns.@void:
                return "return;";

            case returns.IntPtr:
                return "return nullptr;";

            case returns.@bool:
                return "return false;";

            case returns.@string:
                return "return nullptr;";

            case returns.@double:
                return "return 0.0;";

            case returns.@int:
                return "return 0;";

            case returns.@float:
                return "return 0.0f;";

            case returns.@byte:
                return "return 0;"; // unsigned char

            case returns.@uint:
                return "return 0;"; // unsigned int

            case returns.@long:
                return "return 0;"; // int64_t

            case returns.@ulong:
                return "return 0;"; // uint64_t

            case returns.@char:
                return "return 0;"; // char

            case returns.@ushort:
                return "return 0;"; // unsigned short

            default:
                throw new ArgumentOutOfRangeException(nameof(ret), ret, null);
        }
    }
}