using System;
using System.Runtime.InteropServices;

namespace pxr
{
	internal class SdrPINVOKE
	{
		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			[DllImport("UsdCs")]
			public static extern void SWIGRegisterStringCallback_Sdr(SWIGStringDelegate stringDelegate);

			[MonoPInvokeCallback]
			private static string CreateString(string cString)
			{
				return cString;
			}

			static SWIGStringHelper()
			{
				stringDelegate = CreateString;
				SWIGRegisterStringCallback_Sdr(stringDelegate);
			}
		}

		public class SWIGPendingException : UsdCsPINVOKE.SWIGPendingException
		{
		}

		protected static SWIGStringHelper swigStringHelper;

		static SdrPINVOKE()
		{
			swigStringHelper = new SWIGStringHelper();
		}

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrRegistry_GetInstance")]
		public static extern IntPtr SdrRegistry_GetInstance();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrRegistry_GetShaderNodeByIdentifier__SWIG_0")]
		public static extern IntPtr SdrRegistry_GetShaderNodeByIdentifier__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrRegistry_GetShaderNodeByIdentifier__SWIG_1")]
		public static extern IntPtr SdrRegistry_GetShaderNodeByIdentifier__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrRegistry_GetShaderNodeByIdentifierAndType")]
		public static extern IntPtr SdrRegistry_GetShaderNodeByIdentifierAndType(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrRegistry_GetShaderNodeByName__SWIG_0")]
		public static extern IntPtr SdrRegistry_GetShaderNodeByName__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3, int jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrRegistry_GetShaderNodeByName__SWIG_1")]
		public static extern IntPtr SdrRegistry_GetShaderNodeByName__SWIG_1(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrRegistry_GetShaderNodeByName__SWIG_2")]
		public static extern IntPtr SdrRegistry_GetShaderNodeByName__SWIG_2(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrRegistry_GetShaderNodeByNameAndType__SWIG_0")]
		public static extern IntPtr SdrRegistry_GetShaderNodeByNameAndType__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3, int jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrRegistry_GetShaderNodeByNameAndType__SWIG_1")]
		public static extern IntPtr SdrRegistry_GetShaderNodeByNameAndType__SWIG_1(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrRegistry_GetShaderNodeFromAsset__SWIG_0")]
		public static extern IntPtr SdrRegistry_GetShaderNodeFromAsset__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrRegistry_GetShaderNodeFromAsset__SWIG_1")]
		public static extern IntPtr SdrRegistry_GetShaderNodeFromAsset__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrRegistry_GetShaderNodeFromAsset__SWIG_2")]
		public static extern IntPtr SdrRegistry_GetShaderNodeFromAsset__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrRegistry_GetShaderNodeFromAsset__SWIG_3")]
		public static extern IntPtr SdrRegistry_GetShaderNodeFromAsset__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrRegistry_GetShaderNodeFromSourceCode__SWIG_0")]
		public static extern IntPtr SdrRegistry_GetShaderNodeFromSourceCode__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrRegistry_GetShaderNodeFromSourceCode__SWIG_1")]
		public static extern IntPtr SdrRegistry_GetShaderNodeFromSourceCode__SWIG_1(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrRegistry_GetShaderNodesByIdentifier")]
		public static extern IntPtr SdrRegistry_GetShaderNodesByIdentifier(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrRegistry_GetShaderNodesByName__SWIG_0")]
		public static extern IntPtr SdrRegistry_GetShaderNodesByName__SWIG_0(HandleRef jarg1, string jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrRegistry_GetShaderNodesByName__SWIG_1")]
		public static extern IntPtr SdrRegistry_GetShaderNodesByName__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrRegistry_GetShaderNodesByFamily__SWIG_0")]
		public static extern IntPtr SdrRegistry_GetShaderNodesByFamily__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrRegistry_GetShaderNodesByFamily__SWIG_1")]
		public static extern IntPtr SdrRegistry_GetShaderNodesByFamily__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrRegistry_GetShaderNodesByFamily__SWIG_2")]
		public static extern IntPtr SdrRegistry_GetShaderNodesByFamily__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_IsTruthy")]
		public static extern bool IsTruthy(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_StringVal__SWIG_0")]
		public static extern string StringVal__SWIG_0(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_StringVal__SWIG_1")]
		public static extern string StringVal__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_TokenVal__SWIG_0")]
		public static extern IntPtr TokenVal__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_TokenVal__SWIG_1")]
		public static extern IntPtr TokenVal__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_IntVal__SWIG_0")]
		public static extern int IntVal__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_IntVal__SWIG_1")]
		public static extern int IntVal__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_StringVecVal")]
		public static extern IntPtr StringVecVal(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_TokenVecVal")]
		public static extern IntPtr TokenVecVal(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_OptionVecVal")]
		public static extern IntPtr OptionVecVal(string jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_CreateStringFromStringVec")]
		public static extern string CreateStringFromStringVec(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_IsPropertyAnAssetIdentifier")]
		public static extern bool IsPropertyAnAssetIdentifier(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_IsPropertyATerminal")]
		public static extern bool IsPropertyATerminal(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GetRoleFromMetadata")]
		public static extern IntPtr GetRoleFromMetadata(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderNode_GetShaderInput")]
		public static extern IntPtr SdrShaderNode_GetShaderInput(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderNode_GetShaderOutput")]
		public static extern IntPtr SdrShaderNode_GetShaderOutput(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderNode_GetAssetIdentifierInputNames")]
		public static extern IntPtr SdrShaderNode_GetAssetIdentifierInputNames(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderNode_GetDefaultInput")]
		public static extern IntPtr SdrShaderNode_GetDefaultInput(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderNode_GetLabel")]
		public static extern IntPtr SdrShaderNode_GetLabel(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderNode_GetCategory")]
		public static extern IntPtr SdrShaderNode_GetCategory(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderNode_GetRole")]
		public static extern string SdrShaderNode_GetRole(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderNode_GetHelp")]
		public static extern string SdrShaderNode_GetHelp(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderNode_GetDepartments")]
		public static extern IntPtr SdrShaderNode_GetDepartments(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderNode_GetPages")]
		public static extern IntPtr SdrShaderNode_GetPages(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderNode_GetPrimvars")]
		public static extern IntPtr SdrShaderNode_GetPrimvars(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderNode_GetAdditionalPrimvarProperties")]
		public static extern IntPtr SdrShaderNode_GetAdditionalPrimvarProperties(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderNode_GetImplementationName")]
		public static extern string SdrShaderNode_GetImplementationName(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderNode_GetPropertyNamesForPage")]
		public static extern IntPtr SdrShaderNode_GetPropertyNamesForPage(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderNode_GetAllVstructNames")]
		public static extern IntPtr SdrShaderNode_GetAllVstructNames(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_SdrShaderNode")]
		public static extern void delete_SdrShaderNode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_SdrShaderProperty")]
		public static extern IntPtr new_SdrShaderProperty(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4, uint jarg5, HandleRef jarg6, HandleRef jarg7, HandleRef jarg8);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderProperty_GetLabel")]
		public static extern IntPtr SdrShaderProperty_GetLabel(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderProperty_GetHelp")]
		public static extern string SdrShaderProperty_GetHelp(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderProperty_GetPage")]
		public static extern IntPtr SdrShaderProperty_GetPage(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderProperty_GetWidget")]
		public static extern IntPtr SdrShaderProperty_GetWidget(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderProperty_GetHints")]
		public static extern IntPtr SdrShaderProperty_GetHints(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderProperty_GetOptions")]
		public static extern IntPtr SdrShaderProperty_GetOptions(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderProperty_GetImplementationName")]
		public static extern string SdrShaderProperty_GetImplementationName(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderProperty_GetVStructMemberOf")]
		public static extern IntPtr SdrShaderProperty_GetVStructMemberOf(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderProperty_GetVStructMemberName")]
		public static extern IntPtr SdrShaderProperty_GetVStructMemberName(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderProperty_IsVStructMember")]
		public static extern bool SdrShaderProperty_IsVStructMember(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderProperty_IsVStruct")]
		public static extern bool SdrShaderProperty_IsVStruct(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderProperty_GetVStructConditionalExpr")]
		public static extern IntPtr SdrShaderProperty_GetVStructConditionalExpr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderProperty_IsConnectable")]
		public static extern bool SdrShaderProperty_IsConnectable(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderProperty_GetValidConnectionTypes")]
		public static extern IntPtr SdrShaderProperty_GetValidConnectionTypes(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderProperty_CanConnectTo")]
		public static extern bool SdrShaderProperty_CanConnectTo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderProperty_GetTypeAsSdfType")]
		public static extern IntPtr SdrShaderProperty_GetTypeAsSdfType(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderProperty_GetDefaultValueAsSdfType")]
		public static extern IntPtr SdrShaderProperty_GetDefaultValueAsSdfType(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderProperty_IsAssetIdentifier")]
		public static extern bool SdrShaderProperty_IsAssetIdentifier(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderProperty_IsDefaultInput")]
		public static extern bool SdrShaderProperty_IsDefaultInput(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_SdrShaderProperty")]
		public static extern void delete_SdrShaderProperty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrRegistry_SWIGUpcast")]
		public static extern IntPtr SdrRegistry_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderNode_SWIGUpcast")]
		public static extern IntPtr SdrShaderNode_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdrShaderProperty_SWIGUpcast")]
		public static extern IntPtr SdrShaderProperty_SWIGUpcast(IntPtr jarg1);
	}
}
