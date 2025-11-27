using System;
using System.Runtime.InteropServices;

namespace pxr
{
	internal class UsdShadePINVOKE
	{
		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			[DllImport("UsdCs")]
			public static extern void SWIGRegisterStringCallback_UsdShade(SWIGStringDelegate stringDelegate);

			[MonoPInvokeCallback]
			private static string CreateString(string cString)
			{
				return cString;
			}

			static SWIGStringHelper()
			{
				stringDelegate = CreateString;
				SWIGRegisterStringCallback_UsdShade(stringDelegate);
			}
		}

		public class SWIGPendingException : UsdCsPINVOKE.SWIGPendingException
		{
		}

		protected static SWIGStringHelper swigStringHelper;

		static UsdShadePINVOKE()
		{
			swigStringHelper = new SWIGStringHelper();
		}

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeConnectableAPI__SWIG_0")]
		public static extern IntPtr new_UsdShadeConnectableAPI__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeConnectableAPI__SWIG_1")]
		public static extern IntPtr new_UsdShadeConnectableAPI__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeConnectableAPI__SWIG_2")]
		public static extern IntPtr new_UsdShadeConnectableAPI__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdShadeConnectableAPI")]
		public static extern void delete_UsdShadeConnectableAPI(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdShadeConnectableAPI_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdShadeConnectableAPI_GetSchemaAttributeNames__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_Get")]
		public static extern IntPtr UsdShadeConnectableAPI_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_IsContainer")]
		public static extern bool UsdShadeConnectableAPI_IsContainer(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_RequiresEncapsulation")]
		public static extern bool UsdShadeConnectableAPI_RequiresEncapsulation(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_CanConnect__SWIG_0")]
		public static extern bool UsdShadeConnectableAPI_CanConnect__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_CanConnect__SWIG_1")]
		public static extern bool UsdShadeConnectableAPI_CanConnect__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_CanConnect__SWIG_2")]
		public static extern bool UsdShadeConnectableAPI_CanConnect__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_CanConnect__SWIG_3")]
		public static extern bool UsdShadeConnectableAPI_CanConnect__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_CanConnect__SWIG_4")]
		public static extern bool UsdShadeConnectableAPI_CanConnect__SWIG_4(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_CanConnect__SWIG_5")]
		public static extern bool UsdShadeConnectableAPI_CanConnect__SWIG_5(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_CanConnect__SWIG_6")]
		public static extern bool UsdShadeConnectableAPI_CanConnect__SWIG_6(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ConnectToSource__SWIG_0")]
		public static extern bool UsdShadeConnectableAPI_ConnectToSource__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ConnectToSource__SWIG_1")]
		public static extern bool UsdShadeConnectableAPI_ConnectToSource__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ConnectToSource__SWIG_2")]
		public static extern bool UsdShadeConnectableAPI_ConnectToSource__SWIG_2(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ConnectToSource__SWIG_3")]
		public static extern bool UsdShadeConnectableAPI_ConnectToSource__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ConnectToSource__SWIG_4")]
		public static extern bool UsdShadeConnectableAPI_ConnectToSource__SWIG_4(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ConnectToSource__SWIG_5")]
		public static extern bool UsdShadeConnectableAPI_ConnectToSource__SWIG_5(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ConnectToSource__SWIG_6")]
		public static extern bool UsdShadeConnectableAPI_ConnectToSource__SWIG_6(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4, HandleRef jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ConnectToSource__SWIG_7")]
		public static extern bool UsdShadeConnectableAPI_ConnectToSource__SWIG_7(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ConnectToSource__SWIG_8")]
		public static extern bool UsdShadeConnectableAPI_ConnectToSource__SWIG_8(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ConnectToSource__SWIG_9")]
		public static extern bool UsdShadeConnectableAPI_ConnectToSource__SWIG_9(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4, HandleRef jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ConnectToSource__SWIG_10")]
		public static extern bool UsdShadeConnectableAPI_ConnectToSource__SWIG_10(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ConnectToSource__SWIG_11")]
		public static extern bool UsdShadeConnectableAPI_ConnectToSource__SWIG_11(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ConnectToSource__SWIG_12")]
		public static extern bool UsdShadeConnectableAPI_ConnectToSource__SWIG_12(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4, HandleRef jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ConnectToSource__SWIG_13")]
		public static extern bool UsdShadeConnectableAPI_ConnectToSource__SWIG_13(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ConnectToSource__SWIG_14")]
		public static extern bool UsdShadeConnectableAPI_ConnectToSource__SWIG_14(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ConnectToSource__SWIG_15")]
		public static extern bool UsdShadeConnectableAPI_ConnectToSource__SWIG_15(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ConnectToSource__SWIG_16")]
		public static extern bool UsdShadeConnectableAPI_ConnectToSource__SWIG_16(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ConnectToSource__SWIG_17")]
		public static extern bool UsdShadeConnectableAPI_ConnectToSource__SWIG_17(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ConnectToSource__SWIG_18")]
		public static extern bool UsdShadeConnectableAPI_ConnectToSource__SWIG_18(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ConnectToSource__SWIG_19")]
		public static extern bool UsdShadeConnectableAPI_ConnectToSource__SWIG_19(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ConnectToSource__SWIG_20")]
		public static extern bool UsdShadeConnectableAPI_ConnectToSource__SWIG_20(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ConnectToSource__SWIG_21")]
		public static extern bool UsdShadeConnectableAPI_ConnectToSource__SWIG_21(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ConnectToSource__SWIG_22")]
		public static extern bool UsdShadeConnectableAPI_ConnectToSource__SWIG_22(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ConnectToSource__SWIG_23")]
		public static extern bool UsdShadeConnectableAPI_ConnectToSource__SWIG_23(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_SetConnectedSources")]
		public static extern bool UsdShadeConnectableAPI_SetConnectedSources(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_GetConnectedSource__SWIG_0")]
		public static extern bool UsdShadeConnectableAPI_GetConnectedSource__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_GetConnectedSource__SWIG_1")]
		public static extern bool UsdShadeConnectableAPI_GetConnectedSource__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_GetConnectedSource__SWIG_2")]
		public static extern bool UsdShadeConnectableAPI_GetConnectedSource__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_GetConnectedSources__SWIG_0")]
		public static extern IntPtr UsdShadeConnectableAPI_GetConnectedSources__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_GetConnectedSources__SWIG_1")]
		public static extern IntPtr UsdShadeConnectableAPI_GetConnectedSources__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_GetConnectedSources__SWIG_2")]
		public static extern IntPtr UsdShadeConnectableAPI_GetConnectedSources__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_GetConnectedSources__SWIG_3")]
		public static extern IntPtr UsdShadeConnectableAPI_GetConnectedSources__SWIG_3(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_GetConnectedSources__SWIG_4")]
		public static extern IntPtr UsdShadeConnectableAPI_GetConnectedSources__SWIG_4(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_GetConnectedSources__SWIG_5")]
		public static extern IntPtr UsdShadeConnectableAPI_GetConnectedSources__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_GetRawConnectedSourcePaths__SWIG_0")]
		public static extern bool UsdShadeConnectableAPI_GetRawConnectedSourcePaths__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_GetRawConnectedSourcePaths__SWIG_1")]
		public static extern bool UsdShadeConnectableAPI_GetRawConnectedSourcePaths__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_GetRawConnectedSourcePaths__SWIG_2")]
		public static extern bool UsdShadeConnectableAPI_GetRawConnectedSourcePaths__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_HasConnectedSource__SWIG_0")]
		public static extern bool UsdShadeConnectableAPI_HasConnectedSource__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_HasConnectedSource__SWIG_1")]
		public static extern bool UsdShadeConnectableAPI_HasConnectedSource__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_HasConnectedSource__SWIG_2")]
		public static extern bool UsdShadeConnectableAPI_HasConnectedSource__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_IsSourceConnectionFromBaseMaterial__SWIG_0")]
		public static extern bool UsdShadeConnectableAPI_IsSourceConnectionFromBaseMaterial__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_IsSourceConnectionFromBaseMaterial__SWIG_1")]
		public static extern bool UsdShadeConnectableAPI_IsSourceConnectionFromBaseMaterial__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_IsSourceConnectionFromBaseMaterial__SWIG_2")]
		public static extern bool UsdShadeConnectableAPI_IsSourceConnectionFromBaseMaterial__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_DisconnectSource__SWIG_0")]
		public static extern bool UsdShadeConnectableAPI_DisconnectSource__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_DisconnectSource__SWIG_1")]
		public static extern bool UsdShadeConnectableAPI_DisconnectSource__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_DisconnectSource__SWIG_2")]
		public static extern bool UsdShadeConnectableAPI_DisconnectSource__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_DisconnectSource__SWIG_3")]
		public static extern bool UsdShadeConnectableAPI_DisconnectSource__SWIG_3(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_DisconnectSource__SWIG_4")]
		public static extern bool UsdShadeConnectableAPI_DisconnectSource__SWIG_4(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_DisconnectSource__SWIG_5")]
		public static extern bool UsdShadeConnectableAPI_DisconnectSource__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ClearSources__SWIG_0")]
		public static extern bool UsdShadeConnectableAPI_ClearSources__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ClearSources__SWIG_1")]
		public static extern bool UsdShadeConnectableAPI_ClearSources__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ClearSources__SWIG_2")]
		public static extern bool UsdShadeConnectableAPI_ClearSources__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ClearSource__SWIG_0")]
		public static extern bool UsdShadeConnectableAPI_ClearSource__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ClearSource__SWIG_1")]
		public static extern bool UsdShadeConnectableAPI_ClearSource__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_ClearSource__SWIG_2")]
		public static extern bool UsdShadeConnectableAPI_ClearSource__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_HasConnectableAPI")]
		public static extern bool UsdShadeConnectableAPI_HasConnectableAPI(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_CreateOutput")]
		public static extern IntPtr UsdShadeConnectableAPI_CreateOutput(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_GetOutput")]
		public static extern IntPtr UsdShadeConnectableAPI_GetOutput(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_GetOutputs__SWIG_0")]
		public static extern IntPtr UsdShadeConnectableAPI_GetOutputs__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_GetOutputs__SWIG_1")]
		public static extern IntPtr UsdShadeConnectableAPI_GetOutputs__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_CreateInput")]
		public static extern IntPtr UsdShadeConnectableAPI_CreateInput(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_GetInput")]
		public static extern IntPtr UsdShadeConnectableAPI_GetInput(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_GetInputs__SWIG_0")]
		public static extern IntPtr UsdShadeConnectableAPI_GetInputs__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_GetInputs__SWIG_1")]
		public static extern IntPtr UsdShadeConnectableAPI_GetInputs__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectionSourceInfo_source_set")]
		public static extern void UsdShadeConnectionSourceInfo_source_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectionSourceInfo_source_get")]
		public static extern IntPtr UsdShadeConnectionSourceInfo_source_get(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectionSourceInfo_sourceName_set")]
		public static extern void UsdShadeConnectionSourceInfo_sourceName_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectionSourceInfo_sourceName_get")]
		public static extern IntPtr UsdShadeConnectionSourceInfo_sourceName_get(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectionSourceInfo_sourceType_set")]
		public static extern void UsdShadeConnectionSourceInfo_sourceType_set(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectionSourceInfo_sourceType_get")]
		public static extern int UsdShadeConnectionSourceInfo_sourceType_get(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectionSourceInfo_typeName_set")]
		public static extern void UsdShadeConnectionSourceInfo_typeName_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectionSourceInfo_typeName_get")]
		public static extern IntPtr UsdShadeConnectionSourceInfo_typeName_get(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeConnectionSourceInfo__SWIG_0")]
		public static extern IntPtr new_UsdShadeConnectionSourceInfo__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeConnectionSourceInfo__SWIG_1")]
		public static extern IntPtr new_UsdShadeConnectionSourceInfo__SWIG_1(HandleRef jarg1, HandleRef jarg2, int jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeConnectionSourceInfo__SWIG_2")]
		public static extern IntPtr new_UsdShadeConnectionSourceInfo__SWIG_2(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeConnectionSourceInfo__SWIG_3")]
		public static extern IntPtr new_UsdShadeConnectionSourceInfo__SWIG_3(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeConnectionSourceInfo__SWIG_4")]
		public static extern IntPtr new_UsdShadeConnectionSourceInfo__SWIG_4(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeConnectionSourceInfo__SWIG_5")]
		public static extern IntPtr new_UsdShadeConnectionSourceInfo__SWIG_5(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectionSourceInfo_IsValid")]
		public static extern bool UsdShadeConnectionSourceInfo_IsValid(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdShadeConnectionSourceInfo")]
		public static extern void delete_UsdShadeConnectionSourceInfo(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeConnectableAPIBehavior__SWIG_0")]
		public static extern IntPtr new_UsdShadeConnectableAPIBehavior__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeConnectableAPIBehavior__SWIG_1")]
		public static extern IntPtr new_UsdShadeConnectableAPIBehavior__SWIG_1(bool jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdShadeConnectableAPIBehavior")]
		public static extern void delete_UsdShadeConnectableAPIBehavior(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPIBehavior_CanConnectInputToSource")]
		public static extern bool UsdShadeConnectableAPIBehavior_CanConnectInputToSource(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, out string jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPIBehavior_CanConnectOutputToSource")]
		public static extern bool UsdShadeConnectableAPIBehavior_CanConnectOutputToSource(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, out string jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPIBehavior_IsContainer")]
		public static extern bool UsdShadeConnectableAPIBehavior_IsContainer(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPIBehavior_RequiresEncapsulation")]
		public static extern bool UsdShadeConnectableAPIBehavior_RequiresEncapsulation(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeRegisterConnectableAPIBehavior")]
		public static extern void UsdShadeRegisterConnectableAPIBehavior(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInputVector_Clear")]
		public static extern void UsdShadeInputVector_Clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInputVector_Add")]
		public static extern void UsdShadeInputVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInputVector_size")]
		public static extern uint UsdShadeInputVector_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInputVector_capacity")]
		public static extern uint UsdShadeInputVector_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInputVector_reserve")]
		public static extern void UsdShadeInputVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeInputVector__SWIG_0")]
		public static extern IntPtr new_UsdShadeInputVector__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeInputVector__SWIG_1")]
		public static extern IntPtr new_UsdShadeInputVector__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeInputVector__SWIG_2")]
		public static extern IntPtr new_UsdShadeInputVector__SWIG_2(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInputVector_getitemcopy")]
		public static extern IntPtr UsdShadeInputVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInputVector_getitem")]
		public static extern IntPtr UsdShadeInputVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInputVector_setitem")]
		public static extern void UsdShadeInputVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInputVector_AddRange")]
		public static extern void UsdShadeInputVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInputVector_GetRange")]
		public static extern IntPtr UsdShadeInputVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInputVector_Insert")]
		public static extern void UsdShadeInputVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInputVector_InsertRange")]
		public static extern void UsdShadeInputVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInputVector_RemoveAt")]
		public static extern void UsdShadeInputVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInputVector_RemoveRange")]
		public static extern void UsdShadeInputVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInputVector_Repeat")]
		public static extern IntPtr UsdShadeInputVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInputVector_Reverse__SWIG_0")]
		public static extern void UsdShadeInputVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInputVector_Reverse__SWIG_1")]
		public static extern void UsdShadeInputVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInputVector_SetRange")]
		public static extern void UsdShadeInputVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdShadeInputVector")]
		public static extern void delete_UsdShadeInputVector(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeInput__SWIG_0")]
		public static extern IntPtr new_UsdShadeInput__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_GetFullName")]
		public static extern IntPtr UsdShadeInput_GetFullName(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_GetBaseName")]
		public static extern IntPtr UsdShadeInput_GetBaseName(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_GetTypeName")]
		public static extern IntPtr UsdShadeInput_GetTypeName(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_GetPrim")]
		public static extern IntPtr UsdShadeInput_GetPrim(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_Get__SWIG_2")]
		public static extern bool UsdShadeInput_Get__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_Get__SWIG_3")]
		public static extern bool UsdShadeInput_Get__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_Set__SWIG_0")]
		public static extern bool UsdShadeInput_Set__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_Set__SWIG_1")]
		public static extern bool UsdShadeInput_Set__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeInput_Hash")]
		public static extern IntPtr new_UsdShadeInput_Hash();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdShadeInput_Hash")]
		public static extern void delete_UsdShadeInput_Hash(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_SetRenderType")]
		public static extern bool UsdShadeInput_SetRenderType(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_GetRenderType")]
		public static extern IntPtr UsdShadeInput_GetRenderType(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_HasRenderType")]
		public static extern bool UsdShadeInput_HasRenderType(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_GetSdrMetadata")]
		public static extern IntPtr UsdShadeInput_GetSdrMetadata(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_GetSdrMetadataByKey")]
		public static extern string UsdShadeInput_GetSdrMetadataByKey(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_SetSdrMetadata")]
		public static extern void UsdShadeInput_SetSdrMetadata(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_SetSdrMetadataByKey")]
		public static extern void UsdShadeInput_SetSdrMetadataByKey(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_HasSdrMetadata")]
		public static extern bool UsdShadeInput_HasSdrMetadata(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_HasSdrMetadataByKey")]
		public static extern bool UsdShadeInput_HasSdrMetadataByKey(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_ClearSdrMetadata")]
		public static extern void UsdShadeInput_ClearSdrMetadata(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_ClearSdrMetadataByKey")]
		public static extern void UsdShadeInput_ClearSdrMetadataByKey(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeInput__SWIG_1")]
		public static extern IntPtr new_UsdShadeInput__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_IsInput")]
		public static extern bool UsdShadeInput_IsInput(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_IsInterfaceInputName")]
		public static extern bool UsdShadeInput_IsInterfaceInputName(string jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_GetAttr")]
		public static extern IntPtr UsdShadeInput_GetAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_IsDefined")]
		public static extern bool UsdShadeInput_IsDefined(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_SetDocumentation")]
		public static extern bool UsdShadeInput_SetDocumentation(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_GetDocumentation")]
		public static extern string UsdShadeInput_GetDocumentation(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_SetDisplayGroup")]
		public static extern bool UsdShadeInput_SetDisplayGroup(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_GetDisplayGroup")]
		public static extern string UsdShadeInput_GetDisplayGroup(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_CanConnect__SWIG_0")]
		public static extern bool UsdShadeInput_CanConnect__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_CanConnect__SWIG_1")]
		public static extern bool UsdShadeInput_CanConnect__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_CanConnect__SWIG_2")]
		public static extern bool UsdShadeInput_CanConnect__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_ConnectToSource__SWIG_0")]
		public static extern bool UsdShadeInput_ConnectToSource__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_ConnectToSource__SWIG_1")]
		public static extern bool UsdShadeInput_ConnectToSource__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_ConnectToSource__SWIG_2")]
		public static extern bool UsdShadeInput_ConnectToSource__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4, HandleRef jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_ConnectToSource__SWIG_3")]
		public static extern bool UsdShadeInput_ConnectToSource__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_ConnectToSource__SWIG_4")]
		public static extern bool UsdShadeInput_ConnectToSource__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_ConnectToSource__SWIG_5")]
		public static extern bool UsdShadeInput_ConnectToSource__SWIG_5(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_ConnectToSource__SWIG_6")]
		public static extern bool UsdShadeInput_ConnectToSource__SWIG_6(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_ConnectToSource__SWIG_7")]
		public static extern bool UsdShadeInput_ConnectToSource__SWIG_7(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_SetConnectedSources")]
		public static extern bool UsdShadeInput_SetConnectedSources(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_GetConnectedSources__SWIG_0")]
		public static extern IntPtr UsdShadeInput_GetConnectedSources__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_GetConnectedSources__SWIG_1")]
		public static extern IntPtr UsdShadeInput_GetConnectedSources__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_GetConnectedSource")]
		public static extern bool UsdShadeInput_GetConnectedSource(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, out UsdShadeAttributeType jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_GetRawConnectedSourcePaths")]
		public static extern bool UsdShadeInput_GetRawConnectedSourcePaths(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_HasConnectedSource")]
		public static extern bool UsdShadeInput_HasConnectedSource(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_IsSourceConnectionFromBaseMaterial")]
		public static extern bool UsdShadeInput_IsSourceConnectionFromBaseMaterial(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_DisconnectSource__SWIG_0")]
		public static extern bool UsdShadeInput_DisconnectSource__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_DisconnectSource__SWIG_1")]
		public static extern bool UsdShadeInput_DisconnectSource__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_ClearSources")]
		public static extern bool UsdShadeInput_ClearSources(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_ClearSource")]
		public static extern bool UsdShadeInput_ClearSource(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_SetConnectability")]
		public static extern bool UsdShadeInput_SetConnectability(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_GetConnectability")]
		public static extern IntPtr UsdShadeInput_GetConnectability(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_ClearConnectability")]
		public static extern bool UsdShadeInput_ClearConnectability(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_GetValueProducingAttributes__SWIG_0")]
		public static extern IntPtr UsdShadeInput_GetValueProducingAttributes__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_GetValueProducingAttributes__SWIG_1")]
		public static extern IntPtr UsdShadeInput_GetValueProducingAttributes__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeInput_GetValueProducingAttribute")]
		public static extern IntPtr UsdShadeInput_GetValueProducingAttribute(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdShadeInput")]
		public static extern void delete_UsdShadeInput(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_InterfaceInputConsumersMap__SWIG_0")]
		public static extern IntPtr new_InterfaceInputConsumersMap__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_InterfaceInputConsumersMap__SWIG_1")]
		public static extern IntPtr new_InterfaceInputConsumersMap__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_InterfaceInputConsumersMap_size")]
		public static extern uint InterfaceInputConsumersMap_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_InterfaceInputConsumersMap_empty")]
		public static extern bool InterfaceInputConsumersMap_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_InterfaceInputConsumersMap_Clear")]
		public static extern void InterfaceInputConsumersMap_Clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_InterfaceInputConsumersMap_getitem")]
		public static extern IntPtr InterfaceInputConsumersMap_getitem(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_InterfaceInputConsumersMap_setitem")]
		public static extern void InterfaceInputConsumersMap_setitem(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_InterfaceInputConsumersMap_ContainsKey")]
		public static extern bool InterfaceInputConsumersMap_ContainsKey(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_InterfaceInputConsumersMap_Add")]
		public static extern void InterfaceInputConsumersMap_Add(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_InterfaceInputConsumersMap_Remove")]
		public static extern bool InterfaceInputConsumersMap_Remove(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_InterfaceInputConsumersMap_create_iterator_begin")]
		public static extern IntPtr InterfaceInputConsumersMap_create_iterator_begin(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_InterfaceInputConsumersMap_get_next_key")]
		public static extern IntPtr InterfaceInputConsumersMap_get_next_key(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_InterfaceInputConsumersMap_destroy_iterator")]
		public static extern void InterfaceInputConsumersMap_destroy_iterator(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_InterfaceInputConsumersMap")]
		public static extern void delete_InterfaceInputConsumersMap(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeNodeGraph__SWIG_0")]
		public static extern IntPtr new_UsdShadeNodeGraph__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeNodeGraph__SWIG_1")]
		public static extern IntPtr new_UsdShadeNodeGraph__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeNodeGraph__SWIG_2")]
		public static extern IntPtr new_UsdShadeNodeGraph__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdShadeNodeGraph")]
		public static extern void delete_UsdShadeNodeGraph(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeGraph_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdShadeNodeGraph_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeGraph_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdShadeNodeGraph_GetSchemaAttributeNames__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeGraph_Get")]
		public static extern IntPtr UsdShadeNodeGraph_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeGraph_Define")]
		public static extern IntPtr UsdShadeNodeGraph_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeNodeGraph__SWIG_3")]
		public static extern IntPtr new_UsdShadeNodeGraph__SWIG_3(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeGraph_ConnectableAPI")]
		public static extern IntPtr UsdShadeNodeGraph_ConnectableAPI(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeGraph_CreateOutput")]
		public static extern IntPtr UsdShadeNodeGraph_CreateOutput(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeGraph_GetOutput")]
		public static extern IntPtr UsdShadeNodeGraph_GetOutput(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeGraph_GetOutputs__SWIG_0")]
		public static extern IntPtr UsdShadeNodeGraph_GetOutputs__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeGraph_GetOutputs__SWIG_1")]
		public static extern IntPtr UsdShadeNodeGraph_GetOutputs__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeGraph_ComputeOutputSource")]
		public static extern IntPtr UsdShadeNodeGraph_ComputeOutputSource(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, out UsdShadeAttributeType jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeGraph_CreateInput")]
		public static extern IntPtr UsdShadeNodeGraph_CreateInput(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeGraph_GetInput")]
		public static extern IntPtr UsdShadeNodeGraph_GetInput(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeGraph_GetInputs__SWIG_0")]
		public static extern IntPtr UsdShadeNodeGraph_GetInputs__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeGraph_GetInputs__SWIG_1")]
		public static extern IntPtr UsdShadeNodeGraph_GetInputs__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeNodeGraph_NodeGraphHasher")]
		public static extern IntPtr new_UsdShadeNodeGraph_NodeGraphHasher();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdShadeNodeGraph_NodeGraphHasher")]
		public static extern void delete_UsdShadeNodeGraph_NodeGraphHasher(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeNodeGraph_NodeGraphEqualFn")]
		public static extern IntPtr new_UsdShadeNodeGraph_NodeGraphEqualFn();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdShadeNodeGraph_NodeGraphEqualFn")]
		public static extern void delete_UsdShadeNodeGraph_NodeGraphEqualFn(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeGraph_GetInterfaceInputs")]
		public static extern IntPtr UsdShadeNodeGraph_GetInterfaceInputs(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeGraph_ComputeInterfaceInputConsumersMap__SWIG_0")]
		public static extern IntPtr UsdShadeNodeGraph_ComputeInterfaceInputConsumersMap__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeGraph_ComputeInterfaceInputConsumersMap__SWIG_1")]
		public static extern IntPtr UsdShadeNodeGraph_ComputeInterfaceInputConsumersMap__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialVector_Clear")]
		public static extern void UsdShadeMaterialVector_Clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialVector_Add")]
		public static extern void UsdShadeMaterialVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialVector_size")]
		public static extern uint UsdShadeMaterialVector_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialVector_capacity")]
		public static extern uint UsdShadeMaterialVector_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialVector_reserve")]
		public static extern void UsdShadeMaterialVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeMaterialVector__SWIG_0")]
		public static extern IntPtr new_UsdShadeMaterialVector__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeMaterialVector__SWIG_1")]
		public static extern IntPtr new_UsdShadeMaterialVector__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeMaterialVector__SWIG_2")]
		public static extern IntPtr new_UsdShadeMaterialVector__SWIG_2(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialVector_getitemcopy")]
		public static extern IntPtr UsdShadeMaterialVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialVector_getitem")]
		public static extern IntPtr UsdShadeMaterialVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialVector_setitem")]
		public static extern void UsdShadeMaterialVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialVector_AddRange")]
		public static extern void UsdShadeMaterialVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialVector_GetRange")]
		public static extern IntPtr UsdShadeMaterialVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialVector_Insert")]
		public static extern void UsdShadeMaterialVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialVector_InsertRange")]
		public static extern void UsdShadeMaterialVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialVector_RemoveAt")]
		public static extern void UsdShadeMaterialVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialVector_RemoveRange")]
		public static extern void UsdShadeMaterialVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialVector_Repeat")]
		public static extern IntPtr UsdShadeMaterialVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialVector_Reverse__SWIG_0")]
		public static extern void UsdShadeMaterialVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialVector_Reverse__SWIG_1")]
		public static extern void UsdShadeMaterialVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialVector_SetRange")]
		public static extern void UsdShadeMaterialVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdShadeMaterialVector")]
		public static extern void delete_UsdShadeMaterialVector(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeMaterial__SWIG_0")]
		public static extern IntPtr new_UsdShadeMaterial__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeMaterial__SWIG_1")]
		public static extern IntPtr new_UsdShadeMaterial__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeMaterial__SWIG_2")]
		public static extern IntPtr new_UsdShadeMaterial__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdShadeMaterial")]
		public static extern void delete_UsdShadeMaterial(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdShadeMaterial_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdShadeMaterial_GetSchemaAttributeNames__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_Get")]
		public static extern IntPtr UsdShadeMaterial_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_Define")]
		public static extern IntPtr UsdShadeMaterial_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_GetSurfaceAttr")]
		public static extern IntPtr UsdShadeMaterial_GetSurfaceAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_CreateSurfaceAttr__SWIG_0")]
		public static extern IntPtr UsdShadeMaterial_CreateSurfaceAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_CreateSurfaceAttr__SWIG_1")]
		public static extern IntPtr UsdShadeMaterial_CreateSurfaceAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_CreateSurfaceAttr__SWIG_2")]
		public static extern IntPtr UsdShadeMaterial_CreateSurfaceAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_GetDisplacementAttr")]
		public static extern IntPtr UsdShadeMaterial_GetDisplacementAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_CreateDisplacementAttr__SWIG_0")]
		public static extern IntPtr UsdShadeMaterial_CreateDisplacementAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_CreateDisplacementAttr__SWIG_1")]
		public static extern IntPtr UsdShadeMaterial_CreateDisplacementAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_CreateDisplacementAttr__SWIG_2")]
		public static extern IntPtr UsdShadeMaterial_CreateDisplacementAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_GetVolumeAttr")]
		public static extern IntPtr UsdShadeMaterial_GetVolumeAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_CreateVolumeAttr__SWIG_0")]
		public static extern IntPtr UsdShadeMaterial_CreateVolumeAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_CreateVolumeAttr__SWIG_1")]
		public static extern IntPtr UsdShadeMaterial_CreateVolumeAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_CreateVolumeAttr__SWIG_2")]
		public static extern IntPtr UsdShadeMaterial_CreateVolumeAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_CreateSurfaceOutput__SWIG_0")]
		public static extern IntPtr UsdShadeMaterial_CreateSurfaceOutput__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_CreateSurfaceOutput__SWIG_1")]
		public static extern IntPtr UsdShadeMaterial_CreateSurfaceOutput__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_GetSurfaceOutput__SWIG_0")]
		public static extern IntPtr UsdShadeMaterial_GetSurfaceOutput__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_GetSurfaceOutput__SWIG_1")]
		public static extern IntPtr UsdShadeMaterial_GetSurfaceOutput__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_GetSurfaceOutputs")]
		public static extern IntPtr UsdShadeMaterial_GetSurfaceOutputs(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_ComputeSurfaceSource__SWIG_0")]
		public static extern IntPtr UsdShadeMaterial_ComputeSurfaceSource__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, out UsdShadeAttributeType jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_ComputeSurfaceSource__SWIG_1")]
		public static extern IntPtr UsdShadeMaterial_ComputeSurfaceSource__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_ComputeSurfaceSource__SWIG_2")]
		public static extern IntPtr UsdShadeMaterial_ComputeSurfaceSource__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_ComputeSurfaceSource__SWIG_3")]
		public static extern IntPtr UsdShadeMaterial_ComputeSurfaceSource__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, out UsdShadeAttributeType jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_ComputeSurfaceSource__SWIG_4")]
		public static extern IntPtr UsdShadeMaterial_ComputeSurfaceSource__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_ComputeSurfaceSource__SWIG_5")]
		public static extern IntPtr UsdShadeMaterial_ComputeSurfaceSource__SWIG_5(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_ComputeSurfaceSource__SWIG_6")]
		public static extern IntPtr UsdShadeMaterial_ComputeSurfaceSource__SWIG_6(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_CreateDisplacementOutput__SWIG_0")]
		public static extern IntPtr UsdShadeMaterial_CreateDisplacementOutput__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_CreateDisplacementOutput__SWIG_1")]
		public static extern IntPtr UsdShadeMaterial_CreateDisplacementOutput__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_GetDisplacementOutput__SWIG_0")]
		public static extern IntPtr UsdShadeMaterial_GetDisplacementOutput__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_GetDisplacementOutput__SWIG_1")]
		public static extern IntPtr UsdShadeMaterial_GetDisplacementOutput__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_GetDisplacementOutputs")]
		public static extern IntPtr UsdShadeMaterial_GetDisplacementOutputs(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_ComputeDisplacementSource__SWIG_0")]
		public static extern IntPtr UsdShadeMaterial_ComputeDisplacementSource__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, out UsdShadeAttributeType jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_ComputeDisplacementSource__SWIG_1")]
		public static extern IntPtr UsdShadeMaterial_ComputeDisplacementSource__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_ComputeDisplacementSource__SWIG_2")]
		public static extern IntPtr UsdShadeMaterial_ComputeDisplacementSource__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_ComputeDisplacementSource__SWIG_3")]
		public static extern IntPtr UsdShadeMaterial_ComputeDisplacementSource__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, out UsdShadeAttributeType jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_ComputeDisplacementSource__SWIG_4")]
		public static extern IntPtr UsdShadeMaterial_ComputeDisplacementSource__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_ComputeDisplacementSource__SWIG_5")]
		public static extern IntPtr UsdShadeMaterial_ComputeDisplacementSource__SWIG_5(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_ComputeDisplacementSource__SWIG_6")]
		public static extern IntPtr UsdShadeMaterial_ComputeDisplacementSource__SWIG_6(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_CreateVolumeOutput__SWIG_0")]
		public static extern IntPtr UsdShadeMaterial_CreateVolumeOutput__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_CreateVolumeOutput__SWIG_1")]
		public static extern IntPtr UsdShadeMaterial_CreateVolumeOutput__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_GetVolumeOutput__SWIG_0")]
		public static extern IntPtr UsdShadeMaterial_GetVolumeOutput__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_GetVolumeOutput__SWIG_1")]
		public static extern IntPtr UsdShadeMaterial_GetVolumeOutput__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_GetVolumeOutputs")]
		public static extern IntPtr UsdShadeMaterial_GetVolumeOutputs(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_ComputeVolumeSource__SWIG_0")]
		public static extern IntPtr UsdShadeMaterial_ComputeVolumeSource__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, out UsdShadeAttributeType jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_ComputeVolumeSource__SWIG_1")]
		public static extern IntPtr UsdShadeMaterial_ComputeVolumeSource__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_ComputeVolumeSource__SWIG_2")]
		public static extern IntPtr UsdShadeMaterial_ComputeVolumeSource__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_ComputeVolumeSource__SWIG_3")]
		public static extern IntPtr UsdShadeMaterial_ComputeVolumeSource__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, out UsdShadeAttributeType jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_ComputeVolumeSource__SWIG_4")]
		public static extern IntPtr UsdShadeMaterial_ComputeVolumeSource__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_ComputeVolumeSource__SWIG_5")]
		public static extern IntPtr UsdShadeMaterial_ComputeVolumeSource__SWIG_5(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_ComputeVolumeSource__SWIG_6")]
		public static extern IntPtr UsdShadeMaterial_ComputeVolumeSource__SWIG_6(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_GetEditContextForVariant__SWIG_0")]
		public static extern IntPtr UsdShadeMaterial_GetEditContextForVariant__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_GetEditContextForVariant__SWIG_1")]
		public static extern IntPtr UsdShadeMaterial_GetEditContextForVariant__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_GetMaterialVariant")]
		public static extern IntPtr UsdShadeMaterial_GetMaterialVariant(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_CreateMasterMaterialVariant__SWIG_0")]
		public static extern bool UsdShadeMaterial_CreateMasterMaterialVariant__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_CreateMasterMaterialVariant__SWIG_1")]
		public static extern bool UsdShadeMaterial_CreateMasterMaterialVariant__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_GetBaseMaterial")]
		public static extern IntPtr UsdShadeMaterial_GetBaseMaterial(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_GetBaseMaterialPath")]
		public static extern IntPtr UsdShadeMaterial_GetBaseMaterialPath(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_SetBaseMaterial")]
		public static extern void UsdShadeMaterial_SetBaseMaterial(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_SetBaseMaterialPath")]
		public static extern void UsdShadeMaterial_SetBaseMaterialPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_ClearBaseMaterial")]
		public static extern void UsdShadeMaterial_ClearBaseMaterial(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_HasBaseMaterial")]
		public static extern bool UsdShadeMaterial_HasBaseMaterial(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPICollectionBindingVector_Clear")]
		public static extern void UsdShadeMaterialBindingAPICollectionBindingVector_Clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPICollectionBindingVector_Add")]
		public static extern void UsdShadeMaterialBindingAPICollectionBindingVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPICollectionBindingVector_size")]
		public static extern uint UsdShadeMaterialBindingAPICollectionBindingVector_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPICollectionBindingVector_capacity")]
		public static extern uint UsdShadeMaterialBindingAPICollectionBindingVector_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPICollectionBindingVector_reserve")]
		public static extern void UsdShadeMaterialBindingAPICollectionBindingVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeMaterialBindingAPICollectionBindingVector__SWIG_0")]
		public static extern IntPtr new_UsdShadeMaterialBindingAPICollectionBindingVector__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeMaterialBindingAPICollectionBindingVector__SWIG_1")]
		public static extern IntPtr new_UsdShadeMaterialBindingAPICollectionBindingVector__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeMaterialBindingAPICollectionBindingVector__SWIG_2")]
		public static extern IntPtr new_UsdShadeMaterialBindingAPICollectionBindingVector__SWIG_2(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPICollectionBindingVector_getitemcopy")]
		public static extern IntPtr UsdShadeMaterialBindingAPICollectionBindingVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPICollectionBindingVector_getitem")]
		public static extern IntPtr UsdShadeMaterialBindingAPICollectionBindingVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPICollectionBindingVector_setitem")]
		public static extern void UsdShadeMaterialBindingAPICollectionBindingVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPICollectionBindingVector_AddRange")]
		public static extern void UsdShadeMaterialBindingAPICollectionBindingVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPICollectionBindingVector_GetRange")]
		public static extern IntPtr UsdShadeMaterialBindingAPICollectionBindingVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPICollectionBindingVector_Insert")]
		public static extern void UsdShadeMaterialBindingAPICollectionBindingVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPICollectionBindingVector_InsertRange")]
		public static extern void UsdShadeMaterialBindingAPICollectionBindingVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPICollectionBindingVector_RemoveAt")]
		public static extern void UsdShadeMaterialBindingAPICollectionBindingVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPICollectionBindingVector_RemoveRange")]
		public static extern void UsdShadeMaterialBindingAPICollectionBindingVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPICollectionBindingVector_Repeat")]
		public static extern IntPtr UsdShadeMaterialBindingAPICollectionBindingVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPICollectionBindingVector_Reverse__SWIG_0")]
		public static extern void UsdShadeMaterialBindingAPICollectionBindingVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPICollectionBindingVector_Reverse__SWIG_1")]
		public static extern void UsdShadeMaterialBindingAPICollectionBindingVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPICollectionBindingVector_SetRange")]
		public static extern void UsdShadeMaterialBindingAPICollectionBindingVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdShadeMaterialBindingAPICollectionBindingVector")]
		public static extern void delete_UsdShadeMaterialBindingAPICollectionBindingVector(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeMaterialBindingAPI__SWIG_0")]
		public static extern IntPtr new_UsdShadeMaterialBindingAPI__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeMaterialBindingAPI__SWIG_1")]
		public static extern IntPtr new_UsdShadeMaterialBindingAPI__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeMaterialBindingAPI__SWIG_2")]
		public static extern IntPtr new_UsdShadeMaterialBindingAPI__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdShadeMaterialBindingAPI")]
		public static extern void delete_UsdShadeMaterialBindingAPI(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_GetSchemaAttributeNames__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_Get")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_CanApply__SWIG_0")]
		public static extern bool UsdShadeMaterialBindingAPI_CanApply__SWIG_0(HandleRef jarg1, out string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_CanApply__SWIG_1")]
		public static extern bool UsdShadeMaterialBindingAPI_CanApply__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_Apply")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_Apply(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_GetDirectBindingRel__SWIG_0")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_GetDirectBindingRel__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_GetDirectBindingRel__SWIG_1")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_GetDirectBindingRel__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_GetCollectionBindingRel__SWIG_0")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_GetCollectionBindingRel__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_GetCollectionBindingRel__SWIG_1")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_GetCollectionBindingRel__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_GetCollectionBindingRels__SWIG_0")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_GetCollectionBindingRels__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_GetCollectionBindingRels__SWIG_1")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_GetCollectionBindingRels__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeMaterialBindingAPI_DirectBinding__SWIG_0")]
		public static extern IntPtr new_UsdShadeMaterialBindingAPI_DirectBinding__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeMaterialBindingAPI_DirectBinding__SWIG_1")]
		public static extern IntPtr new_UsdShadeMaterialBindingAPI_DirectBinding__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_DirectBinding_GetMaterial")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_DirectBinding_GetMaterial(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_DirectBinding_GetMaterialPath")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_DirectBinding_GetMaterialPath(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_DirectBinding_GetBindingRel")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_DirectBinding_GetBindingRel(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_DirectBinding_GetMaterialPurpose")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_DirectBinding_GetMaterialPurpose(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdShadeMaterialBindingAPI_DirectBinding")]
		public static extern void delete_UsdShadeMaterialBindingAPI_DirectBinding(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeMaterialBindingAPI_CollectionBinding__SWIG_0")]
		public static extern IntPtr new_UsdShadeMaterialBindingAPI_CollectionBinding__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeMaterialBindingAPI_CollectionBinding__SWIG_1")]
		public static extern IntPtr new_UsdShadeMaterialBindingAPI_CollectionBinding__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_CollectionBinding_GetMaterial")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_CollectionBinding_GetMaterial(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_CollectionBinding_GetCollection")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_CollectionBinding_GetCollection(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_CollectionBinding_IsCollectionBindingRel")]
		public static extern bool UsdShadeMaterialBindingAPI_CollectionBinding_IsCollectionBindingRel(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_CollectionBinding_IsValid")]
		public static extern bool UsdShadeMaterialBindingAPI_CollectionBinding_IsValid(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_CollectionBinding_GetCollectionPath")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_CollectionBinding_GetCollectionPath(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_CollectionBinding_GetMaterialPath")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_CollectionBinding_GetMaterialPath(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_CollectionBinding_GetBindingRel")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_CollectionBinding_GetBindingRel(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdShadeMaterialBindingAPI_CollectionBinding")]
		public static extern void delete_UsdShadeMaterialBindingAPI_CollectionBinding(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_GetDirectBinding__SWIG_0")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_GetDirectBinding__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_GetDirectBinding__SWIG_1")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_GetDirectBinding__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_GetCollectionBindings__SWIG_0")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_GetCollectionBindings__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_GetCollectionBindings__SWIG_1")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_GetCollectionBindings__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_GetMaterialBindingStrength")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_GetMaterialBindingStrength(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_SetMaterialBindingStrength")]
		public static extern bool UsdShadeMaterialBindingAPI_SetMaterialBindingStrength(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_Bind__SWIG_0")]
		public static extern bool UsdShadeMaterialBindingAPI_Bind__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_Bind__SWIG_1")]
		public static extern bool UsdShadeMaterialBindingAPI_Bind__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_Bind__SWIG_2")]
		public static extern bool UsdShadeMaterialBindingAPI_Bind__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_Bind__SWIG_3")]
		public static extern bool UsdShadeMaterialBindingAPI_Bind__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, HandleRef jarg6);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_Bind__SWIG_4")]
		public static extern bool UsdShadeMaterialBindingAPI_Bind__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_Bind__SWIG_5")]
		public static extern bool UsdShadeMaterialBindingAPI_Bind__SWIG_5(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_Bind__SWIG_6")]
		public static extern bool UsdShadeMaterialBindingAPI_Bind__SWIG_6(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_UnbindDirectBinding__SWIG_0")]
		public static extern bool UsdShadeMaterialBindingAPI_UnbindDirectBinding__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_UnbindDirectBinding__SWIG_1")]
		public static extern bool UsdShadeMaterialBindingAPI_UnbindDirectBinding__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_UnbindCollectionBinding__SWIG_0")]
		public static extern bool UsdShadeMaterialBindingAPI_UnbindCollectionBinding__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_UnbindCollectionBinding__SWIG_1")]
		public static extern bool UsdShadeMaterialBindingAPI_UnbindCollectionBinding__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_UnbindAllBindings")]
		public static extern bool UsdShadeMaterialBindingAPI_UnbindAllBindings(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_RemovePrimFromBindingCollection")]
		public static extern bool UsdShadeMaterialBindingAPI_RemovePrimFromBindingCollection(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_AddPrimToBindingCollection")]
		public static extern bool UsdShadeMaterialBindingAPI_AddPrimToBindingCollection(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_GetMaterialPurposes")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_GetMaterialPurposes();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_GetResolvedTargetPathFromBindingRel")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_GetResolvedTargetPathFromBindingRel(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_ComputeBoundMaterial__SWIG_0")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_ComputeBoundMaterial__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_ComputeBoundMaterial__SWIG_1")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_ComputeBoundMaterial__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_ComputeBoundMaterial__SWIG_2")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_ComputeBoundMaterial__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_ComputeBoundMaterials__SWIG_0")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_ComputeBoundMaterials__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_ComputeBoundMaterials__SWIG_1")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_ComputeBoundMaterials__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_ComputeBoundMaterials__SWIG_2")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_ComputeBoundMaterials__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_CreateMaterialBindSubset__SWIG_0")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_CreateMaterialBindSubset__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_CreateMaterialBindSubset__SWIG_1")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_CreateMaterialBindSubset__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_GetMaterialBindSubsets")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_GetMaterialBindSubsets(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_SetMaterialBindSubsetsFamilyType")]
		public static extern bool UsdShadeMaterialBindingAPI_SetMaterialBindSubsetsFamilyType(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_GetMaterialBindSubsetsFamilyType")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_GetMaterialBindSubsetsFamilyType(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_CanContainPropertyName")]
		public static extern bool UsdShadeMaterialBindingAPI_CanContainPropertyName(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeNodeDefAPI__SWIG_0")]
		public static extern IntPtr new_UsdShadeNodeDefAPI__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeNodeDefAPI__SWIG_1")]
		public static extern IntPtr new_UsdShadeNodeDefAPI__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeNodeDefAPI__SWIG_2")]
		public static extern IntPtr new_UsdShadeNodeDefAPI__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdShadeNodeDefAPI")]
		public static extern void delete_UsdShadeNodeDefAPI(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdShadeNodeDefAPI_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdShadeNodeDefAPI_GetSchemaAttributeNames__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_Get")]
		public static extern IntPtr UsdShadeNodeDefAPI_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_CanApply__SWIG_0")]
		public static extern bool UsdShadeNodeDefAPI_CanApply__SWIG_0(HandleRef jarg1, out string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_CanApply__SWIG_1")]
		public static extern bool UsdShadeNodeDefAPI_CanApply__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_Apply")]
		public static extern IntPtr UsdShadeNodeDefAPI_Apply(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_GetImplementationSourceAttr")]
		public static extern IntPtr UsdShadeNodeDefAPI_GetImplementationSourceAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_CreateImplementationSourceAttr__SWIG_0")]
		public static extern IntPtr UsdShadeNodeDefAPI_CreateImplementationSourceAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_CreateImplementationSourceAttr__SWIG_1")]
		public static extern IntPtr UsdShadeNodeDefAPI_CreateImplementationSourceAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_CreateImplementationSourceAttr__SWIG_2")]
		public static extern IntPtr UsdShadeNodeDefAPI_CreateImplementationSourceAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_GetIdAttr")]
		public static extern IntPtr UsdShadeNodeDefAPI_GetIdAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_CreateIdAttr__SWIG_0")]
		public static extern IntPtr UsdShadeNodeDefAPI_CreateIdAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_CreateIdAttr__SWIG_1")]
		public static extern IntPtr UsdShadeNodeDefAPI_CreateIdAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_CreateIdAttr__SWIG_2")]
		public static extern IntPtr UsdShadeNodeDefAPI_CreateIdAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_GetImplementationSource")]
		public static extern IntPtr UsdShadeNodeDefAPI_GetImplementationSource(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_SetShaderId")]
		public static extern bool UsdShadeNodeDefAPI_SetShaderId(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_GetShaderId")]
		public static extern bool UsdShadeNodeDefAPI_GetShaderId(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_SetSourceAsset__SWIG_0")]
		public static extern bool UsdShadeNodeDefAPI_SetSourceAsset__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_SetSourceAsset__SWIG_1")]
		public static extern bool UsdShadeNodeDefAPI_SetSourceAsset__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_GetSourceAsset__SWIG_0")]
		public static extern bool UsdShadeNodeDefAPI_GetSourceAsset__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_GetSourceAsset__SWIG_1")]
		public static extern bool UsdShadeNodeDefAPI_GetSourceAsset__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_SetSourceAssetSubIdentifier__SWIG_0")]
		public static extern bool UsdShadeNodeDefAPI_SetSourceAssetSubIdentifier__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_SetSourceAssetSubIdentifier__SWIG_1")]
		public static extern bool UsdShadeNodeDefAPI_SetSourceAssetSubIdentifier__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_GetSourceAssetSubIdentifier__SWIG_0")]
		public static extern bool UsdShadeNodeDefAPI_GetSourceAssetSubIdentifier__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_GetSourceAssetSubIdentifier__SWIG_1")]
		public static extern bool UsdShadeNodeDefAPI_GetSourceAssetSubIdentifier__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_SetSourceCode__SWIG_0")]
		public static extern bool UsdShadeNodeDefAPI_SetSourceCode__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_SetSourceCode__SWIG_1")]
		public static extern bool UsdShadeNodeDefAPI_SetSourceCode__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_GetSourceCode__SWIG_0")]
		public static extern bool UsdShadeNodeDefAPI_GetSourceCode__SWIG_0(HandleRef jarg1, out string jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_GetSourceCode__SWIG_1")]
		public static extern bool UsdShadeNodeDefAPI_GetSourceCode__SWIG_1(HandleRef jarg1, out string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_GetShaderNodeForSourceType")]
		public static extern IntPtr UsdShadeNodeDefAPI_GetShaderNodeForSourceType(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutputVector_Clear")]
		public static extern void UsdShadeOutputVector_Clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutputVector_Add")]
		public static extern void UsdShadeOutputVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutputVector_size")]
		public static extern uint UsdShadeOutputVector_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutputVector_capacity")]
		public static extern uint UsdShadeOutputVector_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutputVector_reserve")]
		public static extern void UsdShadeOutputVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeOutputVector__SWIG_0")]
		public static extern IntPtr new_UsdShadeOutputVector__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeOutputVector__SWIG_1")]
		public static extern IntPtr new_UsdShadeOutputVector__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeOutputVector__SWIG_2")]
		public static extern IntPtr new_UsdShadeOutputVector__SWIG_2(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutputVector_getitemcopy")]
		public static extern IntPtr UsdShadeOutputVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutputVector_getitem")]
		public static extern IntPtr UsdShadeOutputVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutputVector_setitem")]
		public static extern void UsdShadeOutputVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutputVector_AddRange")]
		public static extern void UsdShadeOutputVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutputVector_GetRange")]
		public static extern IntPtr UsdShadeOutputVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutputVector_Insert")]
		public static extern void UsdShadeOutputVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutputVector_InsertRange")]
		public static extern void UsdShadeOutputVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutputVector_RemoveAt")]
		public static extern void UsdShadeOutputVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutputVector_RemoveRange")]
		public static extern void UsdShadeOutputVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutputVector_Repeat")]
		public static extern IntPtr UsdShadeOutputVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutputVector_Reverse__SWIG_0")]
		public static extern void UsdShadeOutputVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutputVector_Reverse__SWIG_1")]
		public static extern void UsdShadeOutputVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutputVector_SetRange")]
		public static extern void UsdShadeOutputVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdShadeOutputVector")]
		public static extern void delete_UsdShadeOutputVector(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeOutput__SWIG_0")]
		public static extern IntPtr new_UsdShadeOutput__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_GetFullName")]
		public static extern IntPtr UsdShadeOutput_GetFullName(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_GetBaseName")]
		public static extern IntPtr UsdShadeOutput_GetBaseName(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_GetPrim")]
		public static extern IntPtr UsdShadeOutput_GetPrim(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_GetTypeName")]
		public static extern IntPtr UsdShadeOutput_GetTypeName(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_Set__SWIG_0")]
		public static extern bool UsdShadeOutput_Set__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_Set__SWIG_1")]
		public static extern bool UsdShadeOutput_Set__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_SetRenderType")]
		public static extern bool UsdShadeOutput_SetRenderType(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_GetRenderType")]
		public static extern IntPtr UsdShadeOutput_GetRenderType(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_HasRenderType")]
		public static extern bool UsdShadeOutput_HasRenderType(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_GetSdrMetadata")]
		public static extern IntPtr UsdShadeOutput_GetSdrMetadata(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_GetSdrMetadataByKey")]
		public static extern string UsdShadeOutput_GetSdrMetadataByKey(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_SetSdrMetadata")]
		public static extern void UsdShadeOutput_SetSdrMetadata(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_SetSdrMetadataByKey")]
		public static extern void UsdShadeOutput_SetSdrMetadataByKey(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_HasSdrMetadata")]
		public static extern bool UsdShadeOutput_HasSdrMetadata(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_HasSdrMetadataByKey")]
		public static extern bool UsdShadeOutput_HasSdrMetadataByKey(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_ClearSdrMetadata")]
		public static extern void UsdShadeOutput_ClearSdrMetadata(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_ClearSdrMetadataByKey")]
		public static extern void UsdShadeOutput_ClearSdrMetadataByKey(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeOutput__SWIG_1")]
		public static extern IntPtr new_UsdShadeOutput__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_IsOutput")]
		public static extern bool UsdShadeOutput_IsOutput(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_GetAttr")]
		public static extern IntPtr UsdShadeOutput_GetAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_IsDefined")]
		public static extern bool UsdShadeOutput_IsDefined(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_CanConnect__SWIG_0")]
		public static extern bool UsdShadeOutput_CanConnect__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_CanConnect__SWIG_1")]
		public static extern bool UsdShadeOutput_CanConnect__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_CanConnect__SWIG_2")]
		public static extern bool UsdShadeOutput_CanConnect__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_ConnectToSource__SWIG_0")]
		public static extern bool UsdShadeOutput_ConnectToSource__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_ConnectToSource__SWIG_1")]
		public static extern bool UsdShadeOutput_ConnectToSource__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_ConnectToSource__SWIG_2")]
		public static extern bool UsdShadeOutput_ConnectToSource__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4, HandleRef jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_ConnectToSource__SWIG_3")]
		public static extern bool UsdShadeOutput_ConnectToSource__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_ConnectToSource__SWIG_4")]
		public static extern bool UsdShadeOutput_ConnectToSource__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_ConnectToSource__SWIG_5")]
		public static extern bool UsdShadeOutput_ConnectToSource__SWIG_5(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_ConnectToSource__SWIG_6")]
		public static extern bool UsdShadeOutput_ConnectToSource__SWIG_6(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_ConnectToSource__SWIG_7")]
		public static extern bool UsdShadeOutput_ConnectToSource__SWIG_7(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_SetConnectedSources")]
		public static extern bool UsdShadeOutput_SetConnectedSources(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_GetConnectedSources__SWIG_0")]
		public static extern IntPtr UsdShadeOutput_GetConnectedSources__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_GetConnectedSources__SWIG_1")]
		public static extern IntPtr UsdShadeOutput_GetConnectedSources__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_GetConnectedSource")]
		public static extern bool UsdShadeOutput_GetConnectedSource(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, out UsdShadeAttributeType jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_GetRawConnectedSourcePaths")]
		public static extern bool UsdShadeOutput_GetRawConnectedSourcePaths(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_HasConnectedSource")]
		public static extern bool UsdShadeOutput_HasConnectedSource(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_IsSourceConnectionFromBaseMaterial")]
		public static extern bool UsdShadeOutput_IsSourceConnectionFromBaseMaterial(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_DisconnectSource__SWIG_0")]
		public static extern bool UsdShadeOutput_DisconnectSource__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_DisconnectSource__SWIG_1")]
		public static extern bool UsdShadeOutput_DisconnectSource__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_ClearSources")]
		public static extern bool UsdShadeOutput_ClearSources(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_ClearSource")]
		public static extern bool UsdShadeOutput_ClearSource(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_GetValueProducingAttributes__SWIG_0")]
		public static extern IntPtr UsdShadeOutput_GetValueProducingAttributes__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeOutput_GetValueProducingAttributes__SWIG_1")]
		public static extern IntPtr UsdShadeOutput_GetValueProducingAttributes__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdShadeOutput")]
		public static extern void delete_UsdShadeOutput(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShaderVector_Clear")]
		public static extern void UsdShadeShaderVector_Clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShaderVector_Add")]
		public static extern void UsdShadeShaderVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShaderVector_size")]
		public static extern uint UsdShadeShaderVector_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShaderVector_capacity")]
		public static extern uint UsdShadeShaderVector_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShaderVector_reserve")]
		public static extern void UsdShadeShaderVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeShaderVector__SWIG_0")]
		public static extern IntPtr new_UsdShadeShaderVector__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeShaderVector__SWIG_1")]
		public static extern IntPtr new_UsdShadeShaderVector__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeShaderVector__SWIG_2")]
		public static extern IntPtr new_UsdShadeShaderVector__SWIG_2(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShaderVector_getitemcopy")]
		public static extern IntPtr UsdShadeShaderVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShaderVector_getitem")]
		public static extern IntPtr UsdShadeShaderVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShaderVector_setitem")]
		public static extern void UsdShadeShaderVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShaderVector_AddRange")]
		public static extern void UsdShadeShaderVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShaderVector_GetRange")]
		public static extern IntPtr UsdShadeShaderVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShaderVector_Insert")]
		public static extern void UsdShadeShaderVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShaderVector_InsertRange")]
		public static extern void UsdShadeShaderVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShaderVector_RemoveAt")]
		public static extern void UsdShadeShaderVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShaderVector_RemoveRange")]
		public static extern void UsdShadeShaderVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShaderVector_Repeat")]
		public static extern IntPtr UsdShadeShaderVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShaderVector_Reverse__SWIG_0")]
		public static extern void UsdShadeShaderVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShaderVector_Reverse__SWIG_1")]
		public static extern void UsdShadeShaderVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShaderVector_SetRange")]
		public static extern void UsdShadeShaderVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdShadeShaderVector")]
		public static extern void delete_UsdShadeShaderVector(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeShader__SWIG_0")]
		public static extern IntPtr new_UsdShadeShader__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeShader__SWIG_1")]
		public static extern IntPtr new_UsdShadeShader__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeShader__SWIG_2")]
		public static extern IntPtr new_UsdShadeShader__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdShadeShader")]
		public static extern void delete_UsdShadeShader(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdShadeShader_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdShadeShader_GetSchemaAttributeNames__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_Get")]
		public static extern IntPtr UsdShadeShader_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_Define")]
		public static extern IntPtr UsdShadeShader_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeShader__SWIG_3")]
		public static extern IntPtr new_UsdShadeShader__SWIG_3(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_ConnectableAPI")]
		public static extern IntPtr UsdShadeShader_ConnectableAPI(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_CreateOutput")]
		public static extern IntPtr UsdShadeShader_CreateOutput(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_GetOutput")]
		public static extern IntPtr UsdShadeShader_GetOutput(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_GetOutputs__SWIG_0")]
		public static extern IntPtr UsdShadeShader_GetOutputs__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_GetOutputs__SWIG_1")]
		public static extern IntPtr UsdShadeShader_GetOutputs__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_CreateInput")]
		public static extern IntPtr UsdShadeShader_CreateInput(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_GetInput")]
		public static extern IntPtr UsdShadeShader_GetInput(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_GetInputs__SWIG_0")]
		public static extern IntPtr UsdShadeShader_GetInputs__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_GetInputs__SWIG_1")]
		public static extern IntPtr UsdShadeShader_GetInputs__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_GetImplementationSourceAttr")]
		public static extern IntPtr UsdShadeShader_GetImplementationSourceAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_CreateImplementationSourceAttr__SWIG_0")]
		public static extern IntPtr UsdShadeShader_CreateImplementationSourceAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_CreateImplementationSourceAttr__SWIG_1")]
		public static extern IntPtr UsdShadeShader_CreateImplementationSourceAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_CreateImplementationSourceAttr__SWIG_2")]
		public static extern IntPtr UsdShadeShader_CreateImplementationSourceAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_GetIdAttr")]
		public static extern IntPtr UsdShadeShader_GetIdAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_CreateIdAttr__SWIG_0")]
		public static extern IntPtr UsdShadeShader_CreateIdAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_CreateIdAttr__SWIG_1")]
		public static extern IntPtr UsdShadeShader_CreateIdAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_CreateIdAttr__SWIG_2")]
		public static extern IntPtr UsdShadeShader_CreateIdAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_GetImplementationSource")]
		public static extern IntPtr UsdShadeShader_GetImplementationSource(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_SetShaderId")]
		public static extern bool UsdShadeShader_SetShaderId(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_GetShaderId")]
		public static extern bool UsdShadeShader_GetShaderId(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_SetSourceAsset__SWIG_0")]
		public static extern bool UsdShadeShader_SetSourceAsset__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_SetSourceAsset__SWIG_1")]
		public static extern bool UsdShadeShader_SetSourceAsset__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_GetSourceAsset__SWIG_0")]
		public static extern bool UsdShadeShader_GetSourceAsset__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_GetSourceAsset__SWIG_1")]
		public static extern bool UsdShadeShader_GetSourceAsset__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_SetSourceAssetSubIdentifier__SWIG_0")]
		public static extern bool UsdShadeShader_SetSourceAssetSubIdentifier__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_SetSourceAssetSubIdentifier__SWIG_1")]
		public static extern bool UsdShadeShader_SetSourceAssetSubIdentifier__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_GetSourceAssetSubIdentifier__SWIG_0")]
		public static extern bool UsdShadeShader_GetSourceAssetSubIdentifier__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_GetSourceAssetSubIdentifier__SWIG_1")]
		public static extern bool UsdShadeShader_GetSourceAssetSubIdentifier__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_SetSourceCode__SWIG_0")]
		public static extern bool UsdShadeShader_SetSourceCode__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_SetSourceCode__SWIG_1")]
		public static extern bool UsdShadeShader_SetSourceCode__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_GetSourceCode__SWIG_0")]
		public static extern bool UsdShadeShader_GetSourceCode__SWIG_0(HandleRef jarg1, out string jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_GetSourceCode__SWIG_1")]
		public static extern bool UsdShadeShader_GetSourceCode__SWIG_1(HandleRef jarg1, out string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_GetShaderNodeForSourceType")]
		public static extern IntPtr UsdShadeShader_GetShaderNodeForSourceType(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_GetSdrMetadata")]
		public static extern IntPtr UsdShadeShader_GetSdrMetadata(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_GetSdrMetadataByKey")]
		public static extern string UsdShadeShader_GetSdrMetadataByKey(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_SetSdrMetadata")]
		public static extern void UsdShadeShader_SetSdrMetadata(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_SetSdrMetadataByKey")]
		public static extern void UsdShadeShader_SetSdrMetadataByKey(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_HasSdrMetadata")]
		public static extern bool UsdShadeShader_HasSdrMetadata(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_HasSdrMetadataByKey")]
		public static extern bool UsdShadeShader_HasSdrMetadataByKey(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_ClearSdrMetadata")]
		public static extern void UsdShadeShader_ClearSdrMetadata(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_ClearSdrMetadataByKey")]
		public static extern void UsdShadeShader_ClearSdrMetadataByKey(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeShaderDefParserPlugin")]
		public static extern IntPtr new_UsdShadeShaderDefParserPlugin();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdShadeShaderDefParserPlugin")]
		public static extern void delete_UsdShadeShaderDefParserPlugin(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShaderDefParserPlugin_GetDiscoveryTypes")]
		public static extern IntPtr UsdShadeShaderDefParserPlugin_GetDiscoveryTypes(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShaderDefParserPlugin_GetSourceType")]
		public static extern IntPtr UsdShadeShaderDefParserPlugin_GetSourceType(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShaderDefUtils_GetNodeDiscoveryResults")]
		public static extern IntPtr UsdShadeShaderDefUtils_GetNodeDiscoveryResults(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShaderDefUtils_GetPrimvarNamesMetadataString")]
		public static extern string UsdShadeShaderDefUtils_GetPrimvarNamesMetadataString(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeShaderDefUtils")]
		public static extern IntPtr new_UsdShadeShaderDefUtils();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdShadeShaderDefUtils")]
		public static extern void delete_UsdShadeShaderDefUtils(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeTokenAttributeTypePair__SWIG_0")]
		public static extern IntPtr new_UsdShadeTokenAttributeTypePair__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeTokenAttributeTypePair__SWIG_1")]
		public static extern IntPtr new_UsdShadeTokenAttributeTypePair__SWIG_1(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeTokenAttributeTypePair__SWIG_2")]
		public static extern IntPtr new_UsdShadeTokenAttributeTypePair__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeTokenAttributeTypePair_first_set")]
		public static extern void UsdShadeTokenAttributeTypePair_first_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeTokenAttributeTypePair_first_get")]
		public static extern IntPtr UsdShadeTokenAttributeTypePair_first_get(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeTokenAttributeTypePair_second_set")]
		public static extern void UsdShadeTokenAttributeTypePair_second_set(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeTokenAttributeTypePair_second_get")]
		public static extern int UsdShadeTokenAttributeTypePair_second_get(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdShadeTokenAttributeTypePair")]
		public static extern void delete_UsdShadeTokenAttributeTypePair(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeUtils_GetPrefixForAttributeType")]
		public static extern string UsdShadeUtils_GetPrefixForAttributeType(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeUtils_GetConnectedSourcePath")]
		public static extern IntPtr UsdShadeUtils_GetConnectedSourcePath(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeUtils_GetBaseNameAndType")]
		public static extern IntPtr UsdShadeUtils_GetBaseNameAndType(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeUtils_GetType")]
		public static extern int UsdShadeUtils_GetType(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeUtils_GetFullName")]
		public static extern IntPtr UsdShadeUtils_GetFullName(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeUtils_GetValueProducingAttributes__SWIG_0")]
		public static extern IntPtr UsdShadeUtils_GetValueProducingAttributes__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeUtils_GetValueProducingAttributes__SWIG_1")]
		public static extern IntPtr UsdShadeUtils_GetValueProducingAttributes__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeUtils_GetValueProducingAttributes__SWIG_2")]
		public static extern IntPtr UsdShadeUtils_GetValueProducingAttributes__SWIG_2(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeUtils_GetValueProducingAttributes__SWIG_3")]
		public static extern IntPtr UsdShadeUtils_GetValueProducingAttributes__SWIG_3(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdShadeUtils")]
		public static extern IntPtr new_UsdShadeUtils();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdShadeUtils")]
		public static extern void delete_UsdShadeUtils(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeConnectableAPI_SWIGUpcast")]
		public static extern IntPtr UsdShadeConnectableAPI_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeGraph_SWIGUpcast")]
		public static extern IntPtr UsdShadeNodeGraph_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterial_SWIGUpcast")]
		public static extern IntPtr UsdShadeMaterial_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeMaterialBindingAPI_SWIGUpcast")]
		public static extern IntPtr UsdShadeMaterialBindingAPI_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeNodeDefAPI_SWIGUpcast")]
		public static extern IntPtr UsdShadeNodeDefAPI_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShader_SWIGUpcast")]
		public static extern IntPtr UsdShadeShader_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdShadeShaderDefParserPlugin_SWIGUpcast")]
		public static extern IntPtr UsdShadeShaderDefParserPlugin_SWIGUpcast(IntPtr jarg1);
	}
}
