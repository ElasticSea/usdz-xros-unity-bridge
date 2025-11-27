using System;
using System.Runtime.InteropServices;

namespace pxr
{
	internal class UsdPINVOKE
	{
		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			[DllImport("__Internal")]
			public static extern void SWIGRegisterStringCallback_Usd(SWIGStringDelegate stringDelegate);

			[MonoPInvokeCallback]
			private static string CreateString(string cString)
			{
				return cString;
			}

			static SWIGStringHelper()
			{
				stringDelegate = CreateString;
				SWIGRegisterStringCallback_Usd(stringDelegate);
			}
		}

		public class SWIGPendingException : UsdCsPINVOKE.SWIGPendingException
		{
		}

		protected static SWIGStringHelper swigStringHelper;

		static UsdPINVOKE()
		{
			swigStringHelper = new SWIGStringHelper();
		}

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPropertyVector_Clear")]
		public static extern void UsdPropertyVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPropertyVector_Add")]
		public static extern void UsdPropertyVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPropertyVector_size")]
		public static extern uint UsdPropertyVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPropertyVector_capacity")]
		public static extern uint UsdPropertyVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPropertyVector_reserve")]
		public static extern void UsdPropertyVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdPropertyVector__SWIG_0")]
		public static extern IntPtr new_UsdPropertyVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdPropertyVector__SWIG_1")]
		public static extern IntPtr new_UsdPropertyVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdPropertyVector__SWIG_2")]
		public static extern IntPtr new_UsdPropertyVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPropertyVector_getitemcopy")]
		public static extern IntPtr UsdPropertyVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPropertyVector_getitem")]
		public static extern IntPtr UsdPropertyVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPropertyVector_setitem")]
		public static extern void UsdPropertyVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPropertyVector_AddRange")]
		public static extern void UsdPropertyVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPropertyVector_GetRange")]
		public static extern IntPtr UsdPropertyVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPropertyVector_Insert")]
		public static extern void UsdPropertyVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPropertyVector_InsertRange")]
		public static extern void UsdPropertyVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPropertyVector_RemoveAt")]
		public static extern void UsdPropertyVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPropertyVector_RemoveRange")]
		public static extern void UsdPropertyVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPropertyVector_Repeat")]
		public static extern IntPtr UsdPropertyVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPropertyVector_Reverse__SWIG_0")]
		public static extern void UsdPropertyVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPropertyVector_Reverse__SWIG_1")]
		public static extern void UsdPropertyVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPropertyVector_SetRange")]
		public static extern void UsdPropertyVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdPropertyVector")]
		public static extern void delete_UsdPropertyVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdProperty")]
		public static extern IntPtr new_UsdProperty();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdProperty_GetPropertyStack__SWIG_0")]
		public static extern IntPtr UsdProperty_GetPropertyStack__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdProperty_GetPropertyStack__SWIG_1")]
		public static extern IntPtr UsdProperty_GetPropertyStack__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdProperty_GetPropertyStackWithLayerOffsets__SWIG_0")]
		public static extern IntPtr UsdProperty_GetPropertyStackWithLayerOffsets__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdProperty_GetPropertyStackWithLayerOffsets__SWIG_1")]
		public static extern IntPtr UsdProperty_GetPropertyStackWithLayerOffsets__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdProperty_GetBaseName")]
		public static extern IntPtr UsdProperty_GetBaseName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdProperty_GetNamespace")]
		public static extern IntPtr UsdProperty_GetNamespace(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdProperty_SplitName")]
		public static extern IntPtr UsdProperty_SplitName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdProperty_GetDisplayGroup")]
		public static extern string UsdProperty_GetDisplayGroup(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdProperty_SetDisplayGroup")]
		public static extern bool UsdProperty_SetDisplayGroup(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdProperty_ClearDisplayGroup")]
		public static extern bool UsdProperty_ClearDisplayGroup(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdProperty_HasAuthoredDisplayGroup")]
		public static extern bool UsdProperty_HasAuthoredDisplayGroup(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdProperty_GetNestedDisplayGroups")]
		public static extern IntPtr UsdProperty_GetNestedDisplayGroups(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdProperty_SetNestedDisplayGroups")]
		public static extern bool UsdProperty_SetNestedDisplayGroups(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdProperty_IsCustom")]
		public static extern bool UsdProperty_IsCustom(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdProperty_SetCustom")]
		public static extern bool UsdProperty_SetCustom(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdProperty_IsDefined")]
		public static extern bool UsdProperty_IsDefined(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdProperty_IsAuthored")]
		public static extern bool UsdProperty_IsAuthored(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdProperty_IsAuthoredAt")]
		public static extern bool UsdProperty_IsAuthoredAt(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdProperty_FlattenTo__SWIG_0")]
		public static extern IntPtr UsdProperty_FlattenTo__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdProperty_FlattenTo__SWIG_1")]
		public static extern IntPtr UsdProperty_FlattenTo__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdProperty_FlattenTo__SWIG_2")]
		public static extern IntPtr UsdProperty_FlattenTo__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdProperty")]
		public static extern void delete_UsdProperty(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeVector_Clear")]
		public static extern void UsdAttributeVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeVector_Add")]
		public static extern void UsdAttributeVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeVector_size")]
		public static extern uint UsdAttributeVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeVector_capacity")]
		public static extern uint UsdAttributeVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeVector_reserve")]
		public static extern void UsdAttributeVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdAttributeVector__SWIG_0")]
		public static extern IntPtr new_UsdAttributeVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdAttributeVector__SWIG_1")]
		public static extern IntPtr new_UsdAttributeVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdAttributeVector__SWIG_2")]
		public static extern IntPtr new_UsdAttributeVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeVector_getitemcopy")]
		public static extern IntPtr UsdAttributeVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeVector_getitem")]
		public static extern IntPtr UsdAttributeVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeVector_setitem")]
		public static extern void UsdAttributeVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeVector_AddRange")]
		public static extern void UsdAttributeVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeVector_GetRange")]
		public static extern IntPtr UsdAttributeVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeVector_Insert")]
		public static extern void UsdAttributeVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeVector_InsertRange")]
		public static extern void UsdAttributeVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeVector_RemoveAt")]
		public static extern void UsdAttributeVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeVector_RemoveRange")]
		public static extern void UsdAttributeVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeVector_Repeat")]
		public static extern IntPtr UsdAttributeVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeVector_Reverse__SWIG_0")]
		public static extern void UsdAttributeVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeVector_Reverse__SWIG_1")]
		public static extern void UsdAttributeVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeVector_SetRange")]
		public static extern void UsdAttributeVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdAttributeVector")]
		public static extern void delete_UsdAttributeVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdAttribute")]
		public static extern IntPtr new_UsdAttribute();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_GetVariability")]
		public static extern int UsdAttribute_GetVariability(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_SetVariability")]
		public static extern bool UsdAttribute_SetVariability(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_GetTypeName")]
		public static extern IntPtr UsdAttribute_GetTypeName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_SetTypeName")]
		public static extern bool UsdAttribute_SetTypeName(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_GetRoleName")]
		public static extern IntPtr UsdAttribute_GetRoleName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_GetUnionedTimeSamples")]
		public static extern bool UsdAttribute_GetUnionedTimeSamples(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_GetUnionedTimeSamplesInInterval")]
		public static extern bool UsdAttribute_GetUnionedTimeSamplesInInterval(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_GetNumTimeSamples")]
		public static extern uint UsdAttribute_GetNumTimeSamples(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_GetBracketingTimeSamples")]
		public static extern bool UsdAttribute_GetBracketingTimeSamples(HandleRef jarg1, double jarg2, out double jarg3, out double jarg4, out double jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_HasValue")]
		public static extern bool UsdAttribute_HasValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_HasAuthoredValueOpinion")]
		public static extern bool UsdAttribute_HasAuthoredValueOpinion(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_HasAuthoredValue")]
		public static extern bool UsdAttribute_HasAuthoredValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_HasFallbackValue")]
		public static extern bool UsdAttribute_HasFallbackValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_ValueMightBeTimeVarying")]
		public static extern bool UsdAttribute_ValueMightBeTimeVarying(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_Get__SWIG_2")]
		public static extern bool UsdAttribute_Get__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_GetResolveInfo__SWIG_0")]
		public static extern IntPtr UsdAttribute_GetResolveInfo__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_GetResolveInfo__SWIG_1")]
		public static extern IntPtr UsdAttribute_GetResolveInfo__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_Set__SWIG_2")]
		public static extern bool UsdAttribute_Set__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_Set__SWIG_3")]
		public static extern bool UsdAttribute_Set__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_Clear")]
		public static extern bool UsdAttribute_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_ClearAtTime")]
		public static extern bool UsdAttribute_ClearAtTime(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_ClearDefault")]
		public static extern bool UsdAttribute_ClearDefault(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_Block")]
		public static extern void UsdAttribute_Block(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_AddConnection__SWIG_0")]
		public static extern bool UsdAttribute_AddConnection__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_AddConnection__SWIG_1")]
		public static extern bool UsdAttribute_AddConnection__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_RemoveConnection")]
		public static extern bool UsdAttribute_RemoveConnection(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_SetConnections")]
		public static extern bool UsdAttribute_SetConnections(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_ClearConnections")]
		public static extern bool UsdAttribute_ClearConnections(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_GetConnections")]
		public static extern bool UsdAttribute_GetConnections(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_HasAuthoredConnections")]
		public static extern bool UsdAttribute_HasAuthoredConnections(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_GetColorSpace")]
		public static extern IntPtr UsdAttribute_GetColorSpace(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_SetColorSpace")]
		public static extern void UsdAttribute_SetColorSpace(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_HasColorSpace")]
		public static extern bool UsdAttribute_HasColorSpace(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_ClearColorSpace")]
		public static extern bool UsdAttribute_ClearColorSpace(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_GetTimeSamples")]
		public static extern IntPtr UsdAttribute_GetTimeSamples(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_GetTimeSamplesInInterval")]
		public static extern IntPtr UsdAttribute_GetTimeSamplesInInterval(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_Get__SWIG_3")]
		public static extern IntPtr UsdAttribute_Get__SWIG_3(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_Get__SWIG_4")]
		public static extern IntPtr UsdAttribute_Get__SWIG_4(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdAttribute")]
		public static extern void delete_UsdAttribute(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQueryVector_Clear")]
		public static extern void UsdAttributeQueryVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQueryVector_Add")]
		public static extern void UsdAttributeQueryVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQueryVector_size")]
		public static extern uint UsdAttributeQueryVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQueryVector_capacity")]
		public static extern uint UsdAttributeQueryVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQueryVector_reserve")]
		public static extern void UsdAttributeQueryVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdAttributeQueryVector__SWIG_0")]
		public static extern IntPtr new_UsdAttributeQueryVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdAttributeQueryVector__SWIG_1")]
		public static extern IntPtr new_UsdAttributeQueryVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdAttributeQueryVector__SWIG_2")]
		public static extern IntPtr new_UsdAttributeQueryVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQueryVector_getitemcopy")]
		public static extern IntPtr UsdAttributeQueryVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQueryVector_getitem")]
		public static extern IntPtr UsdAttributeQueryVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQueryVector_setitem")]
		public static extern void UsdAttributeQueryVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQueryVector_AddRange")]
		public static extern void UsdAttributeQueryVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQueryVector_GetRange")]
		public static extern IntPtr UsdAttributeQueryVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQueryVector_Insert")]
		public static extern void UsdAttributeQueryVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQueryVector_InsertRange")]
		public static extern void UsdAttributeQueryVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQueryVector_RemoveAt")]
		public static extern void UsdAttributeQueryVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQueryVector_RemoveRange")]
		public static extern void UsdAttributeQueryVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQueryVector_Repeat")]
		public static extern IntPtr UsdAttributeQueryVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQueryVector_Reverse__SWIG_0")]
		public static extern void UsdAttributeQueryVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQueryVector_Reverse__SWIG_1")]
		public static extern void UsdAttributeQueryVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQueryVector_SetRange")]
		public static extern void UsdAttributeQueryVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdAttributeQueryVector")]
		public static extern void delete_UsdAttributeQueryVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdAttributeQuery__SWIG_0")]
		public static extern IntPtr new_UsdAttributeQuery__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdAttributeQuery__SWIG_1")]
		public static extern IntPtr new_UsdAttributeQuery__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdAttributeQuery__SWIG_3")]
		public static extern IntPtr new_UsdAttributeQuery__SWIG_3(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdAttributeQuery__SWIG_4")]
		public static extern IntPtr new_UsdAttributeQuery__SWIG_4(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdAttributeQuery__SWIG_5")]
		public static extern IntPtr new_UsdAttributeQuery__SWIG_5(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQuery_CreateQueries")]
		public static extern IntPtr UsdAttributeQuery_CreateQueries(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQuery_GetAttribute")]
		public static extern IntPtr UsdAttributeQuery_GetAttribute(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQuery_IsValid")]
		public static extern bool UsdAttributeQuery_IsValid(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQuery_Get__SWIG_2")]
		public static extern bool UsdAttributeQuery_Get__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQuery_Get__SWIG_3")]
		public static extern bool UsdAttributeQuery_Get__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQuery_GetTimeSamples")]
		public static extern bool UsdAttributeQuery_GetTimeSamples(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQuery_GetUnionedTimeSamples")]
		public static extern bool UsdAttributeQuery_GetUnionedTimeSamples(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQuery_GetUnionedTimeSamplesInInterval")]
		public static extern bool UsdAttributeQuery_GetUnionedTimeSamplesInInterval(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQuery_GetNumTimeSamples")]
		public static extern uint UsdAttributeQuery_GetNumTimeSamples(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQuery_GetBracketingTimeSamples")]
		public static extern bool UsdAttributeQuery_GetBracketingTimeSamples(HandleRef jarg1, double jarg2, out double jarg3, out double jarg4, out double jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQuery_HasValue")]
		public static extern bool UsdAttributeQuery_HasValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQuery_HasAuthoredValueOpinion")]
		public static extern bool UsdAttributeQuery_HasAuthoredValueOpinion(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQuery_HasAuthoredValue")]
		public static extern bool UsdAttributeQuery_HasAuthoredValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQuery_HasFallbackValue")]
		public static extern bool UsdAttributeQuery_HasFallbackValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttributeQuery_ValueMightBeTimeVarying")]
		public static extern bool UsdAttributeQuery_ValueMightBeTimeVarying(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdAttributeQuery")]
		public static extern void delete_UsdAttributeQuery(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdMetadataValueMap_GetKeys")]
		public static extern IntPtr UsdMetadataValueMap_GetKeys(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdMetadataValueMap_GetValue")]
		public static extern IntPtr UsdMetadataValueMap_GetValue(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdMetadataValueMap_SetValue")]
		public static extern void UsdMetadataValueMap_SetValue(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdMetadataValueMap")]
		public static extern IntPtr new_UsdMetadataValueMap();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdMetadataValueMap")]
		public static extern void delete_UsdMetadataValueMap(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePtrVector_Clear")]
		public static extern void UsdStagePtrVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePtrVector_Add")]
		public static extern void UsdStagePtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePtrVector_size")]
		public static extern uint UsdStagePtrVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePtrVector_capacity")]
		public static extern uint UsdStagePtrVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePtrVector_reserve")]
		public static extern void UsdStagePtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStagePtrVector__SWIG_0")]
		public static extern IntPtr new_UsdStagePtrVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStagePtrVector__SWIG_1")]
		public static extern IntPtr new_UsdStagePtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStagePtrVector__SWIG_2")]
		public static extern IntPtr new_UsdStagePtrVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePtrVector_getitemcopy")]
		public static extern IntPtr UsdStagePtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePtrVector_getitem")]
		public static extern IntPtr UsdStagePtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePtrVector_setitem")]
		public static extern void UsdStagePtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePtrVector_AddRange")]
		public static extern void UsdStagePtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePtrVector_GetRange")]
		public static extern IntPtr UsdStagePtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePtrVector_Insert")]
		public static extern void UsdStagePtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePtrVector_InsertRange")]
		public static extern void UsdStagePtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePtrVector_RemoveAt")]
		public static extern void UsdStagePtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePtrVector_RemoveRange")]
		public static extern void UsdStagePtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePtrVector_Repeat")]
		public static extern IntPtr UsdStagePtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePtrVector_Reverse__SWIG_0")]
		public static extern void UsdStagePtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePtrVector_Reverse__SWIG_1")]
		public static extern void UsdStagePtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePtrVector_SetRange")]
		public static extern void UsdStagePtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdStagePtrVector")]
		public static extern void delete_UsdStagePtrVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstPtrVector_Clear")]
		public static extern void UsdStageConstPtrVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstPtrVector_Add")]
		public static extern void UsdStageConstPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstPtrVector_size")]
		public static extern uint UsdStageConstPtrVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstPtrVector_capacity")]
		public static extern uint UsdStageConstPtrVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstPtrVector_reserve")]
		public static extern void UsdStageConstPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStageConstPtrVector__SWIG_0")]
		public static extern IntPtr new_UsdStageConstPtrVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStageConstPtrVector__SWIG_1")]
		public static extern IntPtr new_UsdStageConstPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStageConstPtrVector__SWIG_2")]
		public static extern IntPtr new_UsdStageConstPtrVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstPtrVector_getitemcopy")]
		public static extern IntPtr UsdStageConstPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstPtrVector_getitem")]
		public static extern IntPtr UsdStageConstPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstPtrVector_setitem")]
		public static extern void UsdStageConstPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstPtrVector_AddRange")]
		public static extern void UsdStageConstPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstPtrVector_GetRange")]
		public static extern IntPtr UsdStageConstPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstPtrVector_Insert")]
		public static extern void UsdStageConstPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstPtrVector_InsertRange")]
		public static extern void UsdStageConstPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstPtrVector_RemoveAt")]
		public static extern void UsdStageConstPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstPtrVector_RemoveRange")]
		public static extern void UsdStageConstPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstPtrVector_Repeat")]
		public static extern IntPtr UsdStageConstPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstPtrVector_Reverse__SWIG_0")]
		public static extern void UsdStageConstPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstPtrVector_Reverse__SWIG_1")]
		public static extern void UsdStageConstPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstPtrVector_SetRange")]
		public static extern void UsdStageConstPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdStageConstPtrVector")]
		public static extern void delete_UsdStageConstPtrVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageRefPtrVector_Clear")]
		public static extern void UsdStageRefPtrVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageRefPtrVector_Add")]
		public static extern void UsdStageRefPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageRefPtrVector_size")]
		public static extern uint UsdStageRefPtrVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageRefPtrVector_capacity")]
		public static extern uint UsdStageRefPtrVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageRefPtrVector_reserve")]
		public static extern void UsdStageRefPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStageRefPtrVector__SWIG_0")]
		public static extern IntPtr new_UsdStageRefPtrVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStageRefPtrVector__SWIG_1")]
		public static extern IntPtr new_UsdStageRefPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStageRefPtrVector__SWIG_2")]
		public static extern IntPtr new_UsdStageRefPtrVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageRefPtrVector_getitemcopy")]
		public static extern IntPtr UsdStageRefPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageRefPtrVector_getitem")]
		public static extern IntPtr UsdStageRefPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageRefPtrVector_setitem")]
		public static extern void UsdStageRefPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageRefPtrVector_AddRange")]
		public static extern void UsdStageRefPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageRefPtrVector_GetRange")]
		public static extern IntPtr UsdStageRefPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageRefPtrVector_Insert")]
		public static extern void UsdStageRefPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageRefPtrVector_InsertRange")]
		public static extern void UsdStageRefPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageRefPtrVector_RemoveAt")]
		public static extern void UsdStageRefPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageRefPtrVector_RemoveRange")]
		public static extern void UsdStageRefPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageRefPtrVector_Repeat")]
		public static extern IntPtr UsdStageRefPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageRefPtrVector_Reverse__SWIG_0")]
		public static extern void UsdStageRefPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageRefPtrVector_Reverse__SWIG_1")]
		public static extern void UsdStageRefPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageRefPtrVector_SetRange")]
		public static extern void UsdStageRefPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdStageRefPtrVector")]
		public static extern void delete_UsdStageRefPtrVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstRefPtrVector_Clear")]
		public static extern void UsdStageConstRefPtrVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstRefPtrVector_Add")]
		public static extern void UsdStageConstRefPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstRefPtrVector_size")]
		public static extern uint UsdStageConstRefPtrVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstRefPtrVector_capacity")]
		public static extern uint UsdStageConstRefPtrVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstRefPtrVector_reserve")]
		public static extern void UsdStageConstRefPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStageConstRefPtrVector__SWIG_0")]
		public static extern IntPtr new_UsdStageConstRefPtrVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStageConstRefPtrVector__SWIG_1")]
		public static extern IntPtr new_UsdStageConstRefPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStageConstRefPtrVector__SWIG_2")]
		public static extern IntPtr new_UsdStageConstRefPtrVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstRefPtrVector_getitemcopy")]
		public static extern IntPtr UsdStageConstRefPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstRefPtrVector_getitem")]
		public static extern IntPtr UsdStageConstRefPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstRefPtrVector_setitem")]
		public static extern void UsdStageConstRefPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstRefPtrVector_AddRange")]
		public static extern void UsdStageConstRefPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstRefPtrVector_GetRange")]
		public static extern IntPtr UsdStageConstRefPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstRefPtrVector_Insert")]
		public static extern void UsdStageConstRefPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstRefPtrVector_InsertRange")]
		public static extern void UsdStageConstRefPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstRefPtrVector_RemoveAt")]
		public static extern void UsdStageConstRefPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstRefPtrVector_RemoveRange")]
		public static extern void UsdStageConstRefPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstRefPtrVector_Repeat")]
		public static extern IntPtr UsdStageConstRefPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstRefPtrVector_Reverse__SWIG_0")]
		public static extern void UsdStageConstRefPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstRefPtrVector_Reverse__SWIG_1")]
		public static extern void UsdStageConstRefPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageConstRefPtrVector_SetRange")]
		public static extern void UsdStageConstRefPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdStageConstRefPtrVector")]
		public static extern void delete_UsdStageConstRefPtrVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdDescribe__SWIG_0")]
		public static extern string UsdDescribe__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdDescribe__SWIG_1")]
		public static extern string UsdDescribe__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdDescribe__SWIG_3")]
		public static extern string UsdDescribe__SWIG_3(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdEditTarget__SWIG_0")]
		public static extern IntPtr new_UsdEditTarget__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdEditTarget__SWIG_1")]
		public static extern IntPtr new_UsdEditTarget__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdEditTarget__SWIG_2")]
		public static extern IntPtr new_UsdEditTarget__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdEditTarget__SWIG_3")]
		public static extern IntPtr new_UsdEditTarget__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdEditTarget__SWIG_4")]
		public static extern IntPtr new_UsdEditTarget__SWIG_4(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdEditTarget__SWIG_5")]
		public static extern IntPtr new_UsdEditTarget__SWIG_5(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdEditTarget__SWIG_6")]
		public static extern IntPtr new_UsdEditTarget__SWIG_6(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdEditTarget_ForLocalDirectVariant")]
		public static extern IntPtr UsdEditTarget_ForLocalDirectVariant(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdEditTarget_IsNull")]
		public static extern bool UsdEditTarget_IsNull(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdEditTarget_IsValid")]
		public static extern bool UsdEditTarget_IsValid(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdEditTarget_GetLayer")]
		public static extern IntPtr UsdEditTarget_GetLayer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdEditTarget_MapToSpecPath")]
		public static extern IntPtr UsdEditTarget_MapToSpecPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdEditTarget_GetPrimSpecForScenePath")]
		public static extern IntPtr UsdEditTarget_GetPrimSpecForScenePath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdEditTarget_GetPropertySpecForScenePath")]
		public static extern IntPtr UsdEditTarget_GetPropertySpecForScenePath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdEditTarget_GetSpecForScenePath")]
		public static extern IntPtr UsdEditTarget_GetSpecForScenePath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdEditTarget_GetMapFunction")]
		public static extern IntPtr UsdEditTarget_GetMapFunction(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdEditTarget_ComposeOver")]
		public static extern IntPtr UsdEditTarget_ComposeOver(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdEditTarget")]
		public static extern void delete_UsdEditTarget(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdInherits_AddInherit__SWIG_0")]
		public static extern bool UsdInherits_AddInherit__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdInherits_AddInherit__SWIG_1")]
		public static extern bool UsdInherits_AddInherit__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdInherits_RemoveInherit")]
		public static extern bool UsdInherits_RemoveInherit(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdInherits_ClearInherits")]
		public static extern bool UsdInherits_ClearInherits(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdInherits_SetInherits")]
		public static extern bool UsdInherits_SetInherits(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdInherits_GetAllDirectInherits")]
		public static extern IntPtr UsdInherits_GetAllDirectInherits(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdInherits_GetPrim__SWIG_0")]
		public static extern IntPtr UsdInherits_GetPrim__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdInherits")]
		public static extern void delete_UsdInherits(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdIsSubtype")]
		public static extern bool UsdIsSubtype(int jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdIsConvertible")]
		public static extern bool UsdIsConvertible(int jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdIsConcrete")]
		public static extern bool UsdIsConcrete(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdObject")]
		public static extern IntPtr new_UsdObject();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_IsValid")]
		public static extern bool UsdObject_IsValid(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_GetStage")]
		public static extern IntPtr UsdObject_GetStage(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_GetPath")]
		public static extern IntPtr UsdObject_GetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_GetPrimPath")]
		public static extern IntPtr UsdObject_GetPrimPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_GetPrim")]
		public static extern IntPtr UsdObject_GetPrim(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_GetName")]
		public static extern IntPtr UsdObject_GetName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_GetDescription")]
		public static extern string UsdObject_GetDescription(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_SetMetadata")]
		public static extern bool UsdObject_SetMetadata(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_ClearMetadata")]
		public static extern bool UsdObject_ClearMetadata(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_HasMetadata")]
		public static extern bool UsdObject_HasMetadata(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_HasAuthoredMetadata")]
		public static extern bool UsdObject_HasAuthoredMetadata(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_SetMetadataByDictKey")]
		public static extern bool UsdObject_SetMetadataByDictKey(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_ClearMetadataByDictKey")]
		public static extern bool UsdObject_ClearMetadataByDictKey(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_HasMetadataDictKey")]
		public static extern bool UsdObject_HasMetadataDictKey(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_HasAuthoredMetadataDictKey")]
		public static extern bool UsdObject_HasAuthoredMetadataDictKey(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_GetAllMetadata")]
		public static extern IntPtr UsdObject_GetAllMetadata(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_GetAllAuthoredMetadata")]
		public static extern IntPtr UsdObject_GetAllAuthoredMetadata(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_IsHidden")]
		public static extern bool UsdObject_IsHidden(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_SetHidden")]
		public static extern bool UsdObject_SetHidden(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_ClearHidden")]
		public static extern bool UsdObject_ClearHidden(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_HasAuthoredHidden")]
		public static extern bool UsdObject_HasAuthoredHidden(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_GetCustomData")]
		public static extern IntPtr UsdObject_GetCustomData(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_GetCustomDataByKey")]
		public static extern IntPtr UsdObject_GetCustomDataByKey(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_SetCustomData")]
		public static extern void UsdObject_SetCustomData(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_SetCustomDataByKey")]
		public static extern void UsdObject_SetCustomDataByKey(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_ClearCustomData")]
		public static extern void UsdObject_ClearCustomData(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_ClearCustomDataByKey")]
		public static extern void UsdObject_ClearCustomDataByKey(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_HasCustomData")]
		public static extern bool UsdObject_HasCustomData(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_HasCustomDataKey")]
		public static extern bool UsdObject_HasCustomDataKey(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_HasAuthoredCustomData")]
		public static extern bool UsdObject_HasAuthoredCustomData(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_HasAuthoredCustomDataKey")]
		public static extern bool UsdObject_HasAuthoredCustomDataKey(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_GetAssetInfo")]
		public static extern IntPtr UsdObject_GetAssetInfo(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_GetAssetInfoByKey")]
		public static extern IntPtr UsdObject_GetAssetInfoByKey(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_SetAssetInfo")]
		public static extern void UsdObject_SetAssetInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_SetAssetInfoByKey")]
		public static extern void UsdObject_SetAssetInfoByKey(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_ClearAssetInfo")]
		public static extern void UsdObject_ClearAssetInfo(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_ClearAssetInfoByKey")]
		public static extern void UsdObject_ClearAssetInfoByKey(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_HasAssetInfo")]
		public static extern bool UsdObject_HasAssetInfo(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_HasAssetInfoKey")]
		public static extern bool UsdObject_HasAssetInfoKey(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_HasAuthoredAssetInfo")]
		public static extern bool UsdObject_HasAuthoredAssetInfo(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_HasAuthoredAssetInfoKey")]
		public static extern bool UsdObject_HasAuthoredAssetInfoKey(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_GetDocumentation")]
		public static extern string UsdObject_GetDocumentation(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_SetDocumentation")]
		public static extern bool UsdObject_SetDocumentation(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_ClearDocumentation")]
		public static extern bool UsdObject_ClearDocumentation(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_HasAuthoredDocumentation")]
		public static extern bool UsdObject_HasAuthoredDocumentation(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_GetDisplayName")]
		public static extern string UsdObject_GetDisplayName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_SetDisplayName")]
		public static extern bool UsdObject_SetDisplayName(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_ClearDisplayName")]
		public static extern bool UsdObject_ClearDisplayName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_HasAuthoredDisplayName")]
		public static extern bool UsdObject_HasAuthoredDisplayName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_GetNamespaceDelimiter")]
		public static extern char UsdObject_GetNamespaceDelimiter();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_Usd_GetObjType")]
		public static extern int Usd_GetObjType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_Equals")]
		public static extern bool UsdObject_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_GetHashCode")]
		public static extern int UsdObject_GetHashCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject__IsValid")]
		public static extern bool UsdObject__IsValid(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_GetMetadata")]
		public static extern IntPtr UsdObject_GetMetadata(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObject_GetMetadataByDictKey")]
		public static extern IntPtr UsdObject_GetMetadataByDictKey(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdObject")]
		public static extern void delete_UsdObject(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPayloadVector_Clear")]
		public static extern void SdfPayloadVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPayloadVector_Add")]
		public static extern void SdfPayloadVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPayloadVector_size")]
		public static extern uint SdfPayloadVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPayloadVector_capacity")]
		public static extern uint SdfPayloadVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPayloadVector_reserve")]
		public static extern void SdfPayloadVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPayloadVector__SWIG_0")]
		public static extern IntPtr new_SdfPayloadVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPayloadVector__SWIG_1")]
		public static extern IntPtr new_SdfPayloadVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_SdfPayloadVector__SWIG_2")]
		public static extern IntPtr new_SdfPayloadVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPayloadVector_getitemcopy")]
		public static extern IntPtr SdfPayloadVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPayloadVector_getitem")]
		public static extern IntPtr SdfPayloadVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPayloadVector_setitem")]
		public static extern void SdfPayloadVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPayloadVector_AddRange")]
		public static extern void SdfPayloadVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPayloadVector_GetRange")]
		public static extern IntPtr SdfPayloadVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPayloadVector_Insert")]
		public static extern void SdfPayloadVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPayloadVector_InsertRange")]
		public static extern void SdfPayloadVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPayloadVector_RemoveAt")]
		public static extern void SdfPayloadVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPayloadVector_RemoveRange")]
		public static extern void SdfPayloadVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPayloadVector_Repeat")]
		public static extern IntPtr SdfPayloadVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPayloadVector_Reverse__SWIG_0")]
		public static extern void SdfPayloadVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPayloadVector_Reverse__SWIG_1")]
		public static extern void SdfPayloadVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SdfPayloadVector_SetRange")]
		public static extern void SdfPayloadVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_SdfPayloadVector")]
		public static extern void delete_SdfPayloadVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPayloads_AddPayload__SWIG_0")]
		public static extern bool UsdPayloads_AddPayload__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPayloads_AddPayload__SWIG_1")]
		public static extern bool UsdPayloads_AddPayload__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPayloads_AddPayload__SWIG_2")]
		public static extern bool UsdPayloads_AddPayload__SWIG_2(HandleRef jarg1, string jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPayloads_AddPayload__SWIG_3")]
		public static extern bool UsdPayloads_AddPayload__SWIG_3(HandleRef jarg1, string jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPayloads_AddPayload__SWIG_4")]
		public static extern bool UsdPayloads_AddPayload__SWIG_4(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPayloads_AddPayload__SWIG_5")]
		public static extern bool UsdPayloads_AddPayload__SWIG_5(HandleRef jarg1, string jarg2, HandleRef jarg3, int jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPayloads_AddPayload__SWIG_6")]
		public static extern bool UsdPayloads_AddPayload__SWIG_6(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPayloads_AddPayload__SWIG_7")]
		public static extern bool UsdPayloads_AddPayload__SWIG_7(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPayloads_AddInternalPayload__SWIG_0")]
		public static extern bool UsdPayloads_AddInternalPayload__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPayloads_AddInternalPayload__SWIG_1")]
		public static extern bool UsdPayloads_AddInternalPayload__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPayloads_AddInternalPayload__SWIG_2")]
		public static extern bool UsdPayloads_AddInternalPayload__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPayloads_RemovePayload")]
		public static extern bool UsdPayloads_RemovePayload(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPayloads_ClearPayloads")]
		public static extern bool UsdPayloads_ClearPayloads(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPayloads_SetPayloads")]
		public static extern bool UsdPayloads_SetPayloads(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPayloads_GetPrim__SWIG_0")]
		public static extern IntPtr UsdPayloads_GetPrim__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdPayloads")]
		public static extern void delete_UsdPayloads(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_GetPrimFromVector")]
		public static extern void GetPrimFromVector(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimVector_Clear")]
		public static extern void UsdPrimVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimVector_Add")]
		public static extern void UsdPrimVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimVector_size")]
		public static extern uint UsdPrimVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimVector_capacity")]
		public static extern uint UsdPrimVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimVector_reserve")]
		public static extern void UsdPrimVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdPrimVector__SWIG_0")]
		public static extern IntPtr new_UsdPrimVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdPrimVector__SWIG_1")]
		public static extern IntPtr new_UsdPrimVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdPrimVector__SWIG_2")]
		public static extern IntPtr new_UsdPrimVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimVector_getitemcopy")]
		public static extern IntPtr UsdPrimVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimVector_getitem")]
		public static extern IntPtr UsdPrimVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimVector_setitem")]
		public static extern void UsdPrimVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimVector_AddRange")]
		public static extern void UsdPrimVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimVector_GetRange")]
		public static extern IntPtr UsdPrimVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimVector_Insert")]
		public static extern void UsdPrimVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimVector_InsertRange")]
		public static extern void UsdPrimVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimVector_RemoveAt")]
		public static extern void UsdPrimVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimVector_RemoveRange")]
		public static extern void UsdPrimVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimVector_Repeat")]
		public static extern IntPtr UsdPrimVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimVector_Reverse__SWIG_0")]
		public static extern void UsdPrimVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimVector_Reverse__SWIG_1")]
		public static extern void UsdPrimVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimVector_SetRange")]
		public static extern void UsdPrimVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdPrimVector")]
		public static extern void delete_UsdPrimVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimSiblingIterator_MoveNext")]
		public static extern void UsdPrimSiblingIterator_MoveNext(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimSiblingIterator_GetCurrent")]
		public static extern IntPtr UsdPrimSiblingIterator_GetCurrent(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimSiblingIterator_Equals")]
		public static extern bool UsdPrimSiblingIterator_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimSiblingIterator_GetHashCode")]
		public static extern int UsdPrimSiblingIterator_GetHashCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdPrimSiblingIterator")]
		public static extern IntPtr new_UsdPrimSiblingIterator();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdPrimSiblingIterator")]
		public static extern void delete_UsdPrimSiblingIterator(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimSubtreeIterator_MoveNext")]
		public static extern void UsdPrimSubtreeIterator_MoveNext(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimSubtreeIterator_GetCurrent")]
		public static extern IntPtr UsdPrimSubtreeIterator_GetCurrent(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimSubtreeIterator_Equals")]
		public static extern bool UsdPrimSubtreeIterator_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimSubtreeIterator_GetHashCode")]
		public static extern int UsdPrimSubtreeIterator_GetHashCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdPrimSubtreeIterator")]
		public static extern IntPtr new_UsdPrimSubtreeIterator();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdPrimSubtreeIterator")]
		public static extern void delete_UsdPrimSubtreeIterator(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimSiblingRange_begin")]
		public static extern IntPtr UsdPrimSiblingRange_begin(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimSiblingRange_end")]
		public static extern IntPtr UsdPrimSiblingRange_end(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimSiblingRange_GetStart")]
		public static extern IntPtr UsdPrimSiblingRange_GetStart(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimSiblingRange_GetEnd")]
		public static extern IntPtr UsdPrimSiblingRange_GetEnd(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdPrimSiblingRange")]
		public static extern IntPtr new_UsdPrimSiblingRange();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdPrimSiblingRange")]
		public static extern void delete_UsdPrimSiblingRange(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimSubtreeRange_begin")]
		public static extern IntPtr UsdPrimSubtreeRange_begin(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimSubtreeRange_end")]
		public static extern IntPtr UsdPrimSubtreeRange_end(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimSubtreeRange_GetStart")]
		public static extern IntPtr UsdPrimSubtreeRange_GetStart(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimSubtreeRange_GetEnd")]
		public static extern IntPtr UsdPrimSubtreeRange_GetEnd(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdPrimSubtreeRange")]
		public static extern IntPtr new_UsdPrimSubtreeRange();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdPrimSubtreeRange")]
		public static extern void delete_UsdPrimSubtreeRange(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdPrim")]
		public static extern IntPtr new_UsdPrim();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetPrimTypeInfo")]
		public static extern IntPtr UsdPrim_GetPrimTypeInfo(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetPrimDefinition")]
		public static extern IntPtr UsdPrim_GetPrimDefinition(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetSpecifier")]
		public static extern int UsdPrim_GetSpecifier(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetPrimStack")]
		public static extern IntPtr UsdPrim_GetPrimStack(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetPrimStackWithLayerOffsets")]
		public static extern IntPtr UsdPrim_GetPrimStackWithLayerOffsets(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_SetSpecifier")]
		public static extern bool UsdPrim_SetSpecifier(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetTypeName")]
		public static extern IntPtr UsdPrim_GetTypeName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_SetTypeName")]
		public static extern bool UsdPrim_SetTypeName(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_ClearTypeName")]
		public static extern bool UsdPrim_ClearTypeName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasAuthoredTypeName")]
		public static extern bool UsdPrim_HasAuthoredTypeName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_IsActive")]
		public static extern bool UsdPrim_IsActive(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_SetActive")]
		public static extern bool UsdPrim_SetActive(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_ClearActive")]
		public static extern bool UsdPrim_ClearActive(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasAuthoredActive")]
		public static extern bool UsdPrim_HasAuthoredActive(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_IsLoaded")]
		public static extern bool UsdPrim_IsLoaded(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_IsModel")]
		public static extern bool UsdPrim_IsModel(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_IsGroup")]
		public static extern bool UsdPrim_IsGroup(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_IsAbstract")]
		public static extern bool UsdPrim_IsAbstract(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_IsDefined")]
		public static extern bool UsdPrim_IsDefined(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasDefiningSpecifier")]
		public static extern bool UsdPrim_HasDefiningSpecifier(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetAppliedSchemas")]
		public static extern IntPtr UsdPrim_GetAppliedSchemas(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetPropertyNames__SWIG_0")]
		public static extern IntPtr UsdPrim_GetPropertyNames__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetPropertyNames__SWIG_1")]
		public static extern IntPtr UsdPrim_GetPropertyNames__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetAuthoredPropertyNames__SWIG_0")]
		public static extern IntPtr UsdPrim_GetAuthoredPropertyNames__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetAuthoredPropertyNames__SWIG_1")]
		public static extern IntPtr UsdPrim_GetAuthoredPropertyNames__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetProperties__SWIG_0")]
		public static extern IntPtr UsdPrim_GetProperties__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetProperties__SWIG_1")]
		public static extern IntPtr UsdPrim_GetProperties__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetAuthoredProperties__SWIG_0")]
		public static extern IntPtr UsdPrim_GetAuthoredProperties__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetAuthoredProperties__SWIG_1")]
		public static extern IntPtr UsdPrim_GetAuthoredProperties__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetPropertiesInNamespace__SWIG_0")]
		public static extern IntPtr UsdPrim_GetPropertiesInNamespace__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetPropertiesInNamespace__SWIG_1")]
		public static extern IntPtr UsdPrim_GetPropertiesInNamespace__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetAuthoredPropertiesInNamespace__SWIG_0")]
		public static extern IntPtr UsdPrim_GetAuthoredPropertiesInNamespace__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetAuthoredPropertiesInNamespace__SWIG_1")]
		public static extern IntPtr UsdPrim_GetAuthoredPropertiesInNamespace__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetPropertyOrder")]
		public static extern IntPtr UsdPrim_GetPropertyOrder(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_SetPropertyOrder")]
		public static extern void UsdPrim_SetPropertyOrder(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_ClearPropertyOrder")]
		public static extern void UsdPrim_ClearPropertyOrder(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_RemoveProperty")]
		public static extern bool UsdPrim_RemoveProperty(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetProperty")]
		public static extern IntPtr UsdPrim_GetProperty(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasProperty")]
		public static extern bool UsdPrim_HasProperty(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_IsA__SWIG_1")]
		public static extern bool UsdPrim_IsA__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_IsA__SWIG_2")]
		public static extern bool UsdPrim_IsA__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_IsA__SWIG_3")]
		public static extern bool UsdPrim_IsA__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_IsInFamily__SWIG_0")]
		public static extern bool UsdPrim_IsInFamily__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_IsInFamily__SWIG_1")]
		public static extern bool UsdPrim_IsInFamily__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_IsInFamily__SWIG_3")]
		public static extern bool UsdPrim_IsInFamily__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_IsInFamily__SWIG_4")]
		public static extern bool UsdPrim_IsInFamily__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetVersionIfIsInFamily")]
		public static extern bool UsdPrim_GetVersionIfIsInFamily(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasAPI__SWIG_2")]
		public static extern bool UsdPrim_HasAPI__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasAPI__SWIG_3")]
		public static extern bool UsdPrim_HasAPI__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasAPI__SWIG_4")]
		public static extern bool UsdPrim_HasAPI__SWIG_4(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasAPI__SWIG_5")]
		public static extern bool UsdPrim_HasAPI__SWIG_5(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasAPI__SWIG_6")]
		public static extern bool UsdPrim_HasAPI__SWIG_6(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasAPI__SWIG_7")]
		public static extern bool UsdPrim_HasAPI__SWIG_7(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasAPIInFamily__SWIG_0")]
		public static extern bool UsdPrim_HasAPIInFamily__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasAPIInFamily__SWIG_1")]
		public static extern bool UsdPrim_HasAPIInFamily__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasAPIInFamily__SWIG_2")]
		public static extern bool UsdPrim_HasAPIInFamily__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasAPIInFamily__SWIG_3")]
		public static extern bool UsdPrim_HasAPIInFamily__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasAPIInFamily__SWIG_6")]
		public static extern bool UsdPrim_HasAPIInFamily__SWIG_6(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasAPIInFamily__SWIG_7")]
		public static extern bool UsdPrim_HasAPIInFamily__SWIG_7(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasAPIInFamily__SWIG_8")]
		public static extern bool UsdPrim_HasAPIInFamily__SWIG_8(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasAPIInFamily__SWIG_9")]
		public static extern bool UsdPrim_HasAPIInFamily__SWIG_9(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetVersionIfHasAPIInFamily__SWIG_0")]
		public static extern bool UsdPrim_GetVersionIfHasAPIInFamily__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetVersionIfHasAPIInFamily__SWIG_1")]
		public static extern bool UsdPrim_GetVersionIfHasAPIInFamily__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_CanApplyAPI__SWIG_4")]
		public static extern bool UsdPrim_CanApplyAPI__SWIG_4(HandleRef jarg1, HandleRef jarg2, out string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_CanApplyAPI__SWIG_5")]
		public static extern bool UsdPrim_CanApplyAPI__SWIG_5(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_CanApplyAPI__SWIG_6")]
		public static extern bool UsdPrim_CanApplyAPI__SWIG_6(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, out string jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_CanApplyAPI__SWIG_7")]
		public static extern bool UsdPrim_CanApplyAPI__SWIG_7(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_CanApplyAPI__SWIG_8")]
		public static extern bool UsdPrim_CanApplyAPI__SWIG_8(HandleRef jarg1, HandleRef jarg2, out string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_CanApplyAPI__SWIG_9")]
		public static extern bool UsdPrim_CanApplyAPI__SWIG_9(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_CanApplyAPI__SWIG_10")]
		public static extern bool UsdPrim_CanApplyAPI__SWIG_10(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, out string jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_CanApplyAPI__SWIG_11")]
		public static extern bool UsdPrim_CanApplyAPI__SWIG_11(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_CanApplyAPI__SWIG_12")]
		public static extern bool UsdPrim_CanApplyAPI__SWIG_12(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, out string jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_CanApplyAPI__SWIG_13")]
		public static extern bool UsdPrim_CanApplyAPI__SWIG_13(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_CanApplyAPI__SWIG_14")]
		public static extern bool UsdPrim_CanApplyAPI__SWIG_14(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, out string jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_CanApplyAPI__SWIG_15")]
		public static extern bool UsdPrim_CanApplyAPI__SWIG_15(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_ApplyAPI__SWIG_2")]
		public static extern bool UsdPrim_ApplyAPI__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_ApplyAPI__SWIG_3")]
		public static extern bool UsdPrim_ApplyAPI__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_ApplyAPI__SWIG_4")]
		public static extern bool UsdPrim_ApplyAPI__SWIG_4(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_ApplyAPI__SWIG_5")]
		public static extern bool UsdPrim_ApplyAPI__SWIG_5(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_ApplyAPI__SWIG_6")]
		public static extern bool UsdPrim_ApplyAPI__SWIG_6(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_ApplyAPI__SWIG_7")]
		public static extern bool UsdPrim_ApplyAPI__SWIG_7(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_RemoveAPI__SWIG_2")]
		public static extern bool UsdPrim_RemoveAPI__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_RemoveAPI__SWIG_3")]
		public static extern bool UsdPrim_RemoveAPI__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_RemoveAPI__SWIG_4")]
		public static extern bool UsdPrim_RemoveAPI__SWIG_4(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_RemoveAPI__SWIG_5")]
		public static extern bool UsdPrim_RemoveAPI__SWIG_5(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_RemoveAPI__SWIG_6")]
		public static extern bool UsdPrim_RemoveAPI__SWIG_6(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_RemoveAPI__SWIG_7")]
		public static extern bool UsdPrim_RemoveAPI__SWIG_7(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_AddAppliedSchema")]
		public static extern bool UsdPrim_AddAppliedSchema(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_RemoveAppliedSchema")]
		public static extern bool UsdPrim_RemoveAppliedSchema(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetChild")]
		public static extern IntPtr UsdPrim_GetChild(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetChildren")]
		public static extern IntPtr UsdPrim_GetChildren(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetAllChildren")]
		public static extern IntPtr UsdPrim_GetAllChildren(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetFilteredChildren")]
		public static extern IntPtr UsdPrim_GetFilteredChildren(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetChildrenNames")]
		public static extern IntPtr UsdPrim_GetChildrenNames(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetAllChildrenNames")]
		public static extern IntPtr UsdPrim_GetAllChildrenNames(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetFilteredChildrenNames")]
		public static extern IntPtr UsdPrim_GetFilteredChildrenNames(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetDescendants")]
		public static extern IntPtr UsdPrim_GetDescendants(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetAllDescendants")]
		public static extern IntPtr UsdPrim_GetAllDescendants(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetFilteredDescendants")]
		public static extern IntPtr UsdPrim_GetFilteredDescendants(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetChildrenReorder")]
		public static extern IntPtr UsdPrim_GetChildrenReorder(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_SetChildrenReorder")]
		public static extern void UsdPrim_SetChildrenReorder(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_ClearChildrenReorder")]
		public static extern void UsdPrim_ClearChildrenReorder(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetParent")]
		public static extern IntPtr UsdPrim_GetParent(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetNextSibling")]
		public static extern IntPtr UsdPrim_GetNextSibling(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetFilteredNextSibling")]
		public static extern IntPtr UsdPrim_GetFilteredNextSibling(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_IsPseudoRoot")]
		public static extern bool UsdPrim_IsPseudoRoot(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetPrimAtPath")]
		public static extern IntPtr UsdPrim_GetPrimAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetObjectAtPath")]
		public static extern IntPtr UsdPrim_GetObjectAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetPropertyAtPath")]
		public static extern IntPtr UsdPrim_GetPropertyAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetAttributeAtPath")]
		public static extern IntPtr UsdPrim_GetAttributeAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetRelationshipAtPath")]
		public static extern IntPtr UsdPrim_GetRelationshipAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetVariantSets")]
		public static extern IntPtr UsdPrim_GetVariantSets(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetVariantSet")]
		public static extern IntPtr UsdPrim_GetVariantSet(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasVariantSets")]
		public static extern bool UsdPrim_HasVariantSets(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_CreateAttribute__SWIG_0")]
		public static extern IntPtr UsdPrim_CreateAttribute__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4, int jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_CreateAttribute__SWIG_1")]
		public static extern IntPtr UsdPrim_CreateAttribute__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_CreateAttribute__SWIG_2")]
		public static extern IntPtr UsdPrim_CreateAttribute__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_CreateAttribute__SWIG_3")]
		public static extern IntPtr UsdPrim_CreateAttribute__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_CreateAttribute__SWIG_4")]
		public static extern IntPtr UsdPrim_CreateAttribute__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4, int jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_CreateAttribute__SWIG_5")]
		public static extern IntPtr UsdPrim_CreateAttribute__SWIG_5(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_CreateAttribute__SWIG_6")]
		public static extern IntPtr UsdPrim_CreateAttribute__SWIG_6(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_CreateAttribute__SWIG_7")]
		public static extern IntPtr UsdPrim_CreateAttribute__SWIG_7(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetAttributes")]
		public static extern IntPtr UsdPrim_GetAttributes(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetAuthoredAttributes")]
		public static extern IntPtr UsdPrim_GetAuthoredAttributes(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetAttribute")]
		public static extern IntPtr UsdPrim_GetAttribute(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasAttribute")]
		public static extern bool UsdPrim_HasAttribute(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_CreateRelationship__SWIG_0")]
		public static extern IntPtr UsdPrim_CreateRelationship__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_CreateRelationship__SWIG_1")]
		public static extern IntPtr UsdPrim_CreateRelationship__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_CreateRelationship__SWIG_2")]
		public static extern IntPtr UsdPrim_CreateRelationship__SWIG_2(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_CreateRelationship__SWIG_3")]
		public static extern IntPtr UsdPrim_CreateRelationship__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetRelationships")]
		public static extern IntPtr UsdPrim_GetRelationships(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetAuthoredRelationships")]
		public static extern IntPtr UsdPrim_GetAuthoredRelationships(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetRelationship")]
		public static extern IntPtr UsdPrim_GetRelationship(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasRelationship")]
		public static extern bool UsdPrim_HasRelationship(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_ClearPayload")]
		public static extern bool UsdPrim_ClearPayload(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasPayload")]
		public static extern bool UsdPrim_HasPayload(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_SetPayload__SWIG_0")]
		public static extern bool UsdPrim_SetPayload__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_SetPayload__SWIG_1")]
		public static extern bool UsdPrim_SetPayload__SWIG_1(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_SetPayload__SWIG_2")]
		public static extern bool UsdPrim_SetPayload__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetPayloads")]
		public static extern IntPtr UsdPrim_GetPayloads(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasAuthoredPayloads")]
		public static extern bool UsdPrim_HasAuthoredPayloads(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_Load__SWIG_0")]
		public static extern void UsdPrim_Load__SWIG_0(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_Load__SWIG_1")]
		public static extern void UsdPrim_Load__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_Unload")]
		public static extern void UsdPrim_Unload(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetReferences")]
		public static extern IntPtr UsdPrim_GetReferences(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasAuthoredReferences")]
		public static extern bool UsdPrim_HasAuthoredReferences(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetInherits")]
		public static extern IntPtr UsdPrim_GetInherits(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasAuthoredInherits")]
		public static extern bool UsdPrim_HasAuthoredInherits(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetSpecializes")]
		public static extern IntPtr UsdPrim_GetSpecializes(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasAuthoredSpecializes")]
		public static extern bool UsdPrim_HasAuthoredSpecializes(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_IsInstanceable")]
		public static extern bool UsdPrim_IsInstanceable(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_SetInstanceable")]
		public static extern bool UsdPrim_SetInstanceable(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_ClearInstanceable")]
		public static extern bool UsdPrim_ClearInstanceable(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_HasAuthoredInstanceable")]
		public static extern bool UsdPrim_HasAuthoredInstanceable(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_IsInstance")]
		public static extern bool UsdPrim_IsInstance(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_IsInstanceProxy")]
		public static extern bool UsdPrim_IsInstanceProxy(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_IsPrototypePath")]
		public static extern bool UsdPrim_IsPrototypePath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_IsPathInPrototype")]
		public static extern bool UsdPrim_IsPathInPrototype(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_IsPrototype")]
		public static extern bool UsdPrim_IsPrototype(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_IsInPrototype")]
		public static extern bool UsdPrim_IsInPrototype(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetPrototype")]
		public static extern IntPtr UsdPrim_GetPrototype(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetPrimInPrototype")]
		public static extern IntPtr UsdPrim_GetPrimInPrototype(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetInstances")]
		public static extern IntPtr UsdPrim_GetInstances(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetPrimIndex")]
		public static extern IntPtr UsdPrim_GetPrimIndex(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_ComputeExpandedPrimIndex")]
		public static extern IntPtr UsdPrim_ComputeExpandedPrimIndex(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_MakeResolveTargetUpToEditTarget")]
		public static extern IntPtr UsdPrim_MakeResolveTargetUpToEditTarget(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_MakeResolveTargetStrongerThanEditTarget")]
		public static extern IntPtr UsdPrim_MakeResolveTargetStrongerThanEditTarget(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_GetAttributeValue")]
		public static extern bool UsdPrim_GetAttributeValue(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdPrim")]
		public static extern void delete_UsdPrim(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArcVector_Clear")]
		public static extern void UsdPrimCompositionQueryArcVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArcVector_Add")]
		public static extern void UsdPrimCompositionQueryArcVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArcVector_size")]
		public static extern uint UsdPrimCompositionQueryArcVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArcVector_capacity")]
		public static extern uint UsdPrimCompositionQueryArcVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArcVector_reserve")]
		public static extern void UsdPrimCompositionQueryArcVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdPrimCompositionQueryArcVector__SWIG_0")]
		public static extern IntPtr new_UsdPrimCompositionQueryArcVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdPrimCompositionQueryArcVector__SWIG_1")]
		public static extern IntPtr new_UsdPrimCompositionQueryArcVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdPrimCompositionQueryArcVector__SWIG_2")]
		public static extern IntPtr new_UsdPrimCompositionQueryArcVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArcVector_getitemcopy")]
		public static extern IntPtr UsdPrimCompositionQueryArcVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArcVector_getitem")]
		public static extern IntPtr UsdPrimCompositionQueryArcVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArcVector_setitem")]
		public static extern void UsdPrimCompositionQueryArcVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArcVector_AddRange")]
		public static extern void UsdPrimCompositionQueryArcVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArcVector_GetRange")]
		public static extern IntPtr UsdPrimCompositionQueryArcVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArcVector_Insert")]
		public static extern void UsdPrimCompositionQueryArcVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArcVector_InsertRange")]
		public static extern void UsdPrimCompositionQueryArcVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArcVector_RemoveAt")]
		public static extern void UsdPrimCompositionQueryArcVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArcVector_RemoveRange")]
		public static extern void UsdPrimCompositionQueryArcVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArcVector_Repeat")]
		public static extern IntPtr UsdPrimCompositionQueryArcVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArcVector_Reverse__SWIG_0")]
		public static extern void UsdPrimCompositionQueryArcVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArcVector_Reverse__SWIG_1")]
		public static extern void UsdPrimCompositionQueryArcVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArcVector_SetRange")]
		public static extern void UsdPrimCompositionQueryArcVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdPrimCompositionQueryArcVector")]
		public static extern void delete_UsdPrimCompositionQueryArcVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdPrimCompositionQueryArc")]
		public static extern void delete_UsdPrimCompositionQueryArc(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArc_GetTargetNode")]
		public static extern IntPtr UsdPrimCompositionQueryArc_GetTargetNode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArc_GetIntroducingNode")]
		public static extern IntPtr UsdPrimCompositionQueryArc_GetIntroducingNode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArc_GetTargetLayer")]
		public static extern IntPtr UsdPrimCompositionQueryArc_GetTargetLayer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArc_GetTargetPrimPath")]
		public static extern IntPtr UsdPrimCompositionQueryArc_GetTargetPrimPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArc_MakeResolveTargetUpTo__SWIG_0")]
		public static extern IntPtr UsdPrimCompositionQueryArc_MakeResolveTargetUpTo__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArc_MakeResolveTargetUpTo__SWIG_1")]
		public static extern IntPtr UsdPrimCompositionQueryArc_MakeResolveTargetUpTo__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArc_MakeResolveTargetStrongerThan__SWIG_0")]
		public static extern IntPtr UsdPrimCompositionQueryArc_MakeResolveTargetStrongerThan__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArc_MakeResolveTargetStrongerThan__SWIG_1")]
		public static extern IntPtr UsdPrimCompositionQueryArc_MakeResolveTargetStrongerThan__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArc_GetIntroducingLayer")]
		public static extern IntPtr UsdPrimCompositionQueryArc_GetIntroducingLayer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArc_GetIntroducingPrimPath")]
		public static extern IntPtr UsdPrimCompositionQueryArc_GetIntroducingPrimPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArc_GetIntroducingListEditor__SWIG_0")]
		public static extern bool UsdPrimCompositionQueryArc_GetIntroducingListEditor__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArc_GetIntroducingListEditor__SWIG_1")]
		public static extern bool UsdPrimCompositionQueryArc_GetIntroducingListEditor__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArc_GetIntroducingListEditor__SWIG_2")]
		public static extern bool UsdPrimCompositionQueryArc_GetIntroducingListEditor__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArc_GetIntroducingListEditor__SWIG_3")]
		public static extern bool UsdPrimCompositionQueryArc_GetIntroducingListEditor__SWIG_3(HandleRef jarg1, HandleRef jarg2, out string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArc_GetArcType")]
		public static extern int UsdPrimCompositionQueryArc_GetArcType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArc_IsImplicit")]
		public static extern bool UsdPrimCompositionQueryArc_IsImplicit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArc_IsAncestral")]
		public static extern bool UsdPrimCompositionQueryArc_IsAncestral(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArc_HasSpecs")]
		public static extern bool UsdPrimCompositionQueryArc_HasSpecs(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArc_IsIntroducedInRootLayerStack")]
		public static extern bool UsdPrimCompositionQueryArc_IsIntroducedInRootLayerStack(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQueryArc_IsIntroducedInRootLayerPrimSpec")]
		public static extern bool UsdPrimCompositionQueryArc_IsIntroducedInRootLayerPrimSpec(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQuery_Filter_arcTypeFilter_set")]
		public static extern void UsdPrimCompositionQuery_Filter_arcTypeFilter_set(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQuery_Filter_arcTypeFilter_get")]
		public static extern int UsdPrimCompositionQuery_Filter_arcTypeFilter_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQuery_Filter_dependencyTypeFilter_set")]
		public static extern void UsdPrimCompositionQuery_Filter_dependencyTypeFilter_set(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQuery_Filter_dependencyTypeFilter_get")]
		public static extern int UsdPrimCompositionQuery_Filter_dependencyTypeFilter_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQuery_Filter_arcIntroducedFilter_set")]
		public static extern void UsdPrimCompositionQuery_Filter_arcIntroducedFilter_set(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQuery_Filter_arcIntroducedFilter_get")]
		public static extern int UsdPrimCompositionQuery_Filter_arcIntroducedFilter_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQuery_Filter_hasSpecsFilter_set")]
		public static extern void UsdPrimCompositionQuery_Filter_hasSpecsFilter_set(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQuery_Filter_hasSpecsFilter_get")]
		public static extern int UsdPrimCompositionQuery_Filter_hasSpecsFilter_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdPrimCompositionQuery_Filter")]
		public static extern IntPtr new_UsdPrimCompositionQuery_Filter();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdPrimCompositionQuery_Filter")]
		public static extern void delete_UsdPrimCompositionQuery_Filter(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQuery_GetDirectReferences")]
		public static extern IntPtr UsdPrimCompositionQuery_GetDirectReferences(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQuery_GetDirectInherits")]
		public static extern IntPtr UsdPrimCompositionQuery_GetDirectInherits(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQuery_GetDirectRootLayerArcs")]
		public static extern IntPtr UsdPrimCompositionQuery_GetDirectRootLayerArcs(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdPrimCompositionQuery__SWIG_0")]
		public static extern IntPtr new_UsdPrimCompositionQuery__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdPrimCompositionQuery__SWIG_1")]
		public static extern IntPtr new_UsdPrimCompositionQuery__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdPrimCompositionQuery")]
		public static extern void delete_UsdPrimCompositionQuery(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQuery_SetFilter")]
		public static extern void UsdPrimCompositionQuery_SetFilter(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQuery_GetFilter")]
		public static extern IntPtr UsdPrimCompositionQuery_GetFilter(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimCompositionQuery_GetCompositionArcs")]
		public static extern IntPtr UsdPrimCompositionQuery_GetCompositionArcs(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_Usd_Term__SWIG_0")]
		public static extern IntPtr new_Usd_Term__SWIG_0(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_Usd_Term__SWIG_1")]
		public static extern IntPtr new_Usd_Term__SWIG_1(int jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_Usd_Term_flag_set")]
		public static extern void Usd_Term_flag_set(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_Usd_Term_flag_get")]
		public static extern int Usd_Term_flag_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_Usd_Term_negated_set")]
		public static extern void Usd_Term_negated_set(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_Usd_Term_negated_get")]
		public static extern bool Usd_Term_negated_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_Usd_Term")]
		public static extern void delete_Usd_Term(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_Usd_PrimFlagsPredicate__SWIG_0")]
		public static extern IntPtr new_Usd_PrimFlagsPredicate__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_Usd_PrimFlagsPredicate__SWIG_1")]
		public static extern IntPtr new_Usd_PrimFlagsPredicate__SWIG_1(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_Usd_PrimFlagsPredicate__SWIG_2")]
		public static extern IntPtr new_Usd_PrimFlagsPredicate__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_Usd_PrimFlagsPredicate_Tautology")]
		public static extern IntPtr Usd_PrimFlagsPredicate_Tautology();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_Usd_PrimFlagsPredicate_Contradiction")]
		public static extern IntPtr Usd_PrimFlagsPredicate_Contradiction();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_Usd_PrimFlagsPredicate_TraverseInstanceProxies")]
		public static extern IntPtr Usd_PrimFlagsPredicate_TraverseInstanceProxies(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_Usd_PrimFlagsPredicate_IncludeInstanceProxiesInTraversal")]
		public static extern bool Usd_PrimFlagsPredicate_IncludeInstanceProxiesInTraversal(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_Usd_PrimFlagsPredicate")]
		public static extern void delete_Usd_PrimFlagsPredicate(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_Usd_PrimFlagsConjunction__SWIG_0")]
		public static extern IntPtr new_Usd_PrimFlagsConjunction__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_Usd_PrimFlagsConjunction__SWIG_1")]
		public static extern IntPtr new_Usd_PrimFlagsConjunction__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_Usd_PrimFlagsConjunction")]
		public static extern void delete_Usd_PrimFlagsConjunction(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_Usd_PrimFlagsDisjunction__SWIG_0")]
		public static extern IntPtr new_Usd_PrimFlagsDisjunction__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_Usd_PrimFlagsDisjunction__SWIG_1")]
		public static extern IntPtr new_Usd_PrimFlagsDisjunction__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_Usd_PrimFlagsDisjunction")]
		public static extern void delete_Usd_PrimFlagsDisjunction(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimIsActive_get")]
		public static extern int UsdPrimIsActive_get();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimIsLoaded_get")]
		public static extern int UsdPrimIsLoaded_get();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimIsModel_get")]
		public static extern int UsdPrimIsModel_get();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimIsGroup_get")]
		public static extern int UsdPrimIsGroup_get();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimIsAbstract_get")]
		public static extern int UsdPrimIsAbstract_get();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimIsDefined_get")]
		public static extern int UsdPrimIsDefined_get();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimIsInstance_get")]
		public static extern int UsdPrimIsInstance_get();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimHasDefiningSpecifier_get")]
		public static extern int UsdPrimHasDefiningSpecifier_get();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimDefaultPredicate_get")]
		public static extern IntPtr UsdPrimDefaultPredicate_get();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimAllPrimsPredicate_get")]
		public static extern IntPtr UsdPrimAllPrimsPredicate_get();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTraverseInstanceProxies__SWIG_0")]
		public static extern IntPtr UsdTraverseInstanceProxies__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTraverseInstanceProxies__SWIG_1")]
		public static extern IntPtr UsdTraverseInstanceProxies__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdPrimRange_EndSentinel")]
		public static extern void delete_UsdPrimRange_EndSentinel(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdPrimRange_iterator__SWIG_0")]
		public static extern IntPtr new_UsdPrimRange_iterator__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdPrimRange_iterator__SWIG_1")]
		public static extern IntPtr new_UsdPrimRange_iterator__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimRange_iterator_IsPostVisit")]
		public static extern bool UsdPrimRange_iterator_IsPostVisit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimRange_iterator_PruneChildren")]
		public static extern void UsdPrimRange_iterator_PruneChildren(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimRange_iterator_Equals")]
		public static extern bool UsdPrimRange_iterator_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimRange_iterator_GetHashCode")]
		public static extern int UsdPrimRange_iterator_GetHashCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimRange_iterator_MoveNext")]
		public static extern void UsdPrimRange_iterator_MoveNext(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimRange_iterator_GetCurrent")]
		public static extern IntPtr UsdPrimRange_iterator_GetCurrent(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdPrimRange_iterator")]
		public static extern void delete_UsdPrimRange_iterator(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdPrimRange__SWIG_0")]
		public static extern IntPtr new_UsdPrimRange__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdPrimRange__SWIG_1")]
		public static extern IntPtr new_UsdPrimRange__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdPrimRange__SWIG_2")]
		public static extern IntPtr new_UsdPrimRange__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimRange_PreAndPostVisit__SWIG_0")]
		public static extern IntPtr UsdPrimRange_PreAndPostVisit__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimRange_PreAndPostVisit__SWIG_1")]
		public static extern IntPtr UsdPrimRange_PreAndPostVisit__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimRange_AllPrims")]
		public static extern IntPtr UsdPrimRange_AllPrims(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimRange_AllPrimsPreAndPostVisit")]
		public static extern IntPtr UsdPrimRange_AllPrimsPreAndPostVisit(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimRange_Stage__SWIG_0")]
		public static extern IntPtr UsdPrimRange_Stage__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimRange_Stage__SWIG_1")]
		public static extern IntPtr UsdPrimRange_Stage__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimRange_GetStart")]
		public static extern IntPtr UsdPrimRange_GetStart(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimRange_GetCurrent")]
		public static extern IntPtr UsdPrimRange_GetCurrent(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimRange_GetEnd")]
		public static extern IntPtr UsdPrimRange_GetEnd(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimRange_IncrementBegin")]
		public static extern void UsdPrimRange_IncrementBegin(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimRange_SetBegin")]
		public static extern void UsdPrimRange_SetBegin(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimRange_IsEmpty")]
		public static extern bool UsdPrimRange_IsEmpty(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimRange_Equals")]
		public static extern bool UsdPrimRange_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrimRange_GetHashCode")]
		public static extern int UsdPrimRange_GetHashCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdPrimRange")]
		public static extern void delete_UsdPrimRange(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdReferences_AddReference__SWIG_0")]
		public static extern bool UsdReferences_AddReference__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdReferences_AddReference__SWIG_1")]
		public static extern bool UsdReferences_AddReference__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdReferences_AddReference__SWIG_2")]
		public static extern bool UsdReferences_AddReference__SWIG_2(HandleRef jarg1, string jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdReferences_AddReference__SWIG_3")]
		public static extern bool UsdReferences_AddReference__SWIG_3(HandleRef jarg1, string jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdReferences_AddReference__SWIG_4")]
		public static extern bool UsdReferences_AddReference__SWIG_4(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdReferences_AddReference__SWIG_5")]
		public static extern bool UsdReferences_AddReference__SWIG_5(HandleRef jarg1, string jarg2, HandleRef jarg3, int jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdReferences_AddReference__SWIG_6")]
		public static extern bool UsdReferences_AddReference__SWIG_6(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdReferences_AddReference__SWIG_7")]
		public static extern bool UsdReferences_AddReference__SWIG_7(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdReferences_AddInternalReference__SWIG_0")]
		public static extern bool UsdReferences_AddInternalReference__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdReferences_AddInternalReference__SWIG_1")]
		public static extern bool UsdReferences_AddInternalReference__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdReferences_AddInternalReference__SWIG_2")]
		public static extern bool UsdReferences_AddInternalReference__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdReferences_RemoveReference")]
		public static extern bool UsdReferences_RemoveReference(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdReferences_ClearReferences")]
		public static extern bool UsdReferences_ClearReferences(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdReferences_SetReferences")]
		public static extern bool UsdReferences_SetReferences(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdReferences_GetPrim__SWIG_0")]
		public static extern IntPtr UsdReferences_GetPrim__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdReferences")]
		public static extern void delete_UsdReferences(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationshipVector_Clear")]
		public static extern void UsdRelationshipVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationshipVector_Add")]
		public static extern void UsdRelationshipVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationshipVector_size")]
		public static extern uint UsdRelationshipVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationshipVector_capacity")]
		public static extern uint UsdRelationshipVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationshipVector_reserve")]
		public static extern void UsdRelationshipVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdRelationshipVector__SWIG_0")]
		public static extern IntPtr new_UsdRelationshipVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdRelationshipVector__SWIG_1")]
		public static extern IntPtr new_UsdRelationshipVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdRelationshipVector__SWIG_2")]
		public static extern IntPtr new_UsdRelationshipVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationshipVector_getitemcopy")]
		public static extern IntPtr UsdRelationshipVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationshipVector_getitem")]
		public static extern IntPtr UsdRelationshipVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationshipVector_setitem")]
		public static extern void UsdRelationshipVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationshipVector_AddRange")]
		public static extern void UsdRelationshipVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationshipVector_GetRange")]
		public static extern IntPtr UsdRelationshipVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationshipVector_Insert")]
		public static extern void UsdRelationshipVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationshipVector_InsertRange")]
		public static extern void UsdRelationshipVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationshipVector_RemoveAt")]
		public static extern void UsdRelationshipVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationshipVector_RemoveRange")]
		public static extern void UsdRelationshipVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationshipVector_Repeat")]
		public static extern IntPtr UsdRelationshipVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationshipVector_Reverse__SWIG_0")]
		public static extern void UsdRelationshipVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationshipVector_Reverse__SWIG_1")]
		public static extern void UsdRelationshipVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationshipVector_SetRange")]
		public static extern void UsdRelationshipVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdRelationshipVector")]
		public static extern void delete_UsdRelationshipVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdRelationship")]
		public static extern IntPtr new_UsdRelationship();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationship_AddTarget__SWIG_0")]
		public static extern bool UsdRelationship_AddTarget__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationship_AddTarget__SWIG_1")]
		public static extern bool UsdRelationship_AddTarget__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationship_RemoveTarget")]
		public static extern bool UsdRelationship_RemoveTarget(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationship_SetTargets")]
		public static extern bool UsdRelationship_SetTargets(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationship_ClearTargets")]
		public static extern bool UsdRelationship_ClearTargets(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationship_HasAuthoredTargets")]
		public static extern bool UsdRelationship_HasAuthoredTargets(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationship_GetTargets")]
		public static extern IntPtr UsdRelationship_GetTargets(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationship_GetForwardedTargets")]
		public static extern IntPtr UsdRelationship_GetForwardedTargets(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdRelationship")]
		public static extern void delete_UsdRelationship(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdResolveInfo")]
		public static extern IntPtr new_UsdResolveInfo();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdResolveInfo_GetSource")]
		public static extern int UsdResolveInfo_GetSource(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdResolveInfo_HasAuthoredValueOpinion")]
		public static extern bool UsdResolveInfo_HasAuthoredValueOpinion(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdResolveInfo_HasAuthoredValue")]
		public static extern bool UsdResolveInfo_HasAuthoredValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdResolveInfo_GetNode")]
		public static extern IntPtr UsdResolveInfo_GetNode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdResolveInfo_ValueIsBlocked")]
		public static extern bool UsdResolveInfo_ValueIsBlocked(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdResolveInfo")]
		public static extern void delete_UsdResolveInfo(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdResolveTarget")]
		public static extern IntPtr new_UsdResolveTarget();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdResolveTarget_GetPrimIndex")]
		public static extern IntPtr UsdResolveTarget_GetPrimIndex(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdResolveTarget_GetStartNode")]
		public static extern IntPtr UsdResolveTarget_GetStartNode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdResolveTarget_GetStartLayer")]
		public static extern IntPtr UsdResolveTarget_GetStartLayer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdResolveTarget_GetStopNode")]
		public static extern IntPtr UsdResolveTarget_GetStopNode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdResolveTarget_GetStopLayer")]
		public static extern IntPtr UsdResolveTarget_GetStopLayer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdResolveTarget_IsNull")]
		public static extern bool UsdResolveTarget_IsNull(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdResolveTarget")]
		public static extern void delete_UsdResolveTarget(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdSchemaBase_IsConcrete")]
		public static extern bool UsdSchemaBase_IsConcrete(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdSchemaBase_IsTyped")]
		public static extern bool UsdSchemaBase_IsTyped(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdSchemaBase_IsAPISchema")]
		public static extern bool UsdSchemaBase_IsAPISchema(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdSchemaBase_IsAppliedAPISchema")]
		public static extern bool UsdSchemaBase_IsAppliedAPISchema(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdSchemaBase_IsMultipleApplyAPISchema")]
		public static extern bool UsdSchemaBase_IsMultipleApplyAPISchema(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdSchemaBase_GetSchemaKind")]
		public static extern int UsdSchemaBase_GetSchemaKind(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdSchemaBase__SWIG_0")]
		public static extern IntPtr new_UsdSchemaBase__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdSchemaBase__SWIG_1")]
		public static extern IntPtr new_UsdSchemaBase__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdSchemaBase__SWIG_2")]
		public static extern IntPtr new_UsdSchemaBase__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdSchemaBase")]
		public static extern void delete_UsdSchemaBase(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdSchemaBase_GetPrim")]
		public static extern IntPtr UsdSchemaBase_GetPrim(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdSchemaBase_GetPath")]
		public static extern IntPtr UsdSchemaBase_GetPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdSchemaBase_GetSchemaClassPrimDefinition")]
		public static extern IntPtr UsdSchemaBase_GetSchemaClassPrimDefinition(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdSchemaBase_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdSchemaBase_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdSchemaBase_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdSchemaBase_GetSchemaAttributeNames__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdSchemaBase__IsValid")]
		public static extern bool UsdSchemaBase__IsValid(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdSchemaBase_Equals")]
		public static extern bool UsdSchemaBase_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdSchemaBase_GetHashCode")]
		public static extern int UsdSchemaBase_GetHashCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdAPISchemaBase")]
		public static extern void delete_UsdAPISchemaBase(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAPISchemaBase_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdAPISchemaBase_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAPISchemaBase_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdAPISchemaBase_GetSchemaAttributeNames__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdClipsAPI__SWIG_0")]
		public static extern IntPtr new_UsdClipsAPI__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdClipsAPI__SWIG_1")]
		public static extern IntPtr new_UsdClipsAPI__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdClipsAPI__SWIG_2")]
		public static extern IntPtr new_UsdClipsAPI__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdClipsAPI")]
		public static extern void delete_UsdClipsAPI(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdClipsAPI_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdClipsAPI_GetSchemaAttributeNames__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_Get")]
		public static extern IntPtr UsdClipsAPI_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GetClips")]
		public static extern bool UsdClipsAPI_GetClips(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_SetClips")]
		public static extern bool UsdClipsAPI_SetClips(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GetClipSets")]
		public static extern bool UsdClipsAPI_GetClipSets(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_SetClipSets")]
		public static extern bool UsdClipsAPI_SetClipSets(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_ComputeClipAssetPaths__SWIG_0")]
		public static extern IntPtr UsdClipsAPI_ComputeClipAssetPaths__SWIG_0(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_ComputeClipAssetPaths__SWIG_1")]
		public static extern IntPtr UsdClipsAPI_ComputeClipAssetPaths__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GetClipAssetPaths__SWIG_0")]
		public static extern bool UsdClipsAPI_GetClipAssetPaths__SWIG_0(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GetClipAssetPaths__SWIG_1")]
		public static extern bool UsdClipsAPI_GetClipAssetPaths__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_SetClipAssetPaths__SWIG_0")]
		public static extern bool UsdClipsAPI_SetClipAssetPaths__SWIG_0(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_SetClipAssetPaths__SWIG_1")]
		public static extern bool UsdClipsAPI_SetClipAssetPaths__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GetClipPrimPath__SWIG_0")]
		public static extern bool UsdClipsAPI_GetClipPrimPath__SWIG_0(HandleRef jarg1, out string jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GetClipPrimPath__SWIG_1")]
		public static extern bool UsdClipsAPI_GetClipPrimPath__SWIG_1(HandleRef jarg1, out string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_SetClipPrimPath__SWIG_0")]
		public static extern bool UsdClipsAPI_SetClipPrimPath__SWIG_0(HandleRef jarg1, string jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_SetClipPrimPath__SWIG_1")]
		public static extern bool UsdClipsAPI_SetClipPrimPath__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GetClipActive__SWIG_0")]
		public static extern bool UsdClipsAPI_GetClipActive__SWIG_0(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GetClipActive__SWIG_1")]
		public static extern bool UsdClipsAPI_GetClipActive__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_SetClipActive__SWIG_0")]
		public static extern bool UsdClipsAPI_SetClipActive__SWIG_0(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_SetClipActive__SWIG_1")]
		public static extern bool UsdClipsAPI_SetClipActive__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GetClipTimes__SWIG_0")]
		public static extern bool UsdClipsAPI_GetClipTimes__SWIG_0(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GetClipTimes__SWIG_1")]
		public static extern bool UsdClipsAPI_GetClipTimes__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_SetClipTimes__SWIG_0")]
		public static extern bool UsdClipsAPI_SetClipTimes__SWIG_0(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_SetClipTimes__SWIG_1")]
		public static extern bool UsdClipsAPI_SetClipTimes__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GetClipManifestAssetPath__SWIG_0")]
		public static extern bool UsdClipsAPI_GetClipManifestAssetPath__SWIG_0(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GetClipManifestAssetPath__SWIG_1")]
		public static extern bool UsdClipsAPI_GetClipManifestAssetPath__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_SetClipManifestAssetPath__SWIG_0")]
		public static extern bool UsdClipsAPI_SetClipManifestAssetPath__SWIG_0(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_SetClipManifestAssetPath__SWIG_1")]
		public static extern bool UsdClipsAPI_SetClipManifestAssetPath__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GenerateClipManifest__SWIG_0")]
		public static extern IntPtr UsdClipsAPI_GenerateClipManifest__SWIG_0(HandleRef jarg1, string jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GenerateClipManifest__SWIG_1")]
		public static extern IntPtr UsdClipsAPI_GenerateClipManifest__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GenerateClipManifest__SWIG_2")]
		public static extern IntPtr UsdClipsAPI_GenerateClipManifest__SWIG_2(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GenerateClipManifest__SWIG_3")]
		public static extern IntPtr UsdClipsAPI_GenerateClipManifest__SWIG_3(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GenerateClipManifestFromLayers")]
		public static extern IntPtr UsdClipsAPI_GenerateClipManifestFromLayers(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GetInterpolateMissingClipValues__SWIG_0")]
		public static extern bool UsdClipsAPI_GetInterpolateMissingClipValues__SWIG_0(HandleRef jarg1, out bool jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GetInterpolateMissingClipValues__SWIG_1")]
		public static extern bool UsdClipsAPI_GetInterpolateMissingClipValues__SWIG_1(HandleRef jarg1, out bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_SetInterpolateMissingClipValues__SWIG_0")]
		public static extern bool UsdClipsAPI_SetInterpolateMissingClipValues__SWIG_0(HandleRef jarg1, bool jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_SetInterpolateMissingClipValues__SWIG_1")]
		public static extern bool UsdClipsAPI_SetInterpolateMissingClipValues__SWIG_1(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GetClipTemplateAssetPath__SWIG_0")]
		public static extern bool UsdClipsAPI_GetClipTemplateAssetPath__SWIG_0(HandleRef jarg1, out string jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GetClipTemplateAssetPath__SWIG_1")]
		public static extern bool UsdClipsAPI_GetClipTemplateAssetPath__SWIG_1(HandleRef jarg1, out string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_SetClipTemplateAssetPath__SWIG_0")]
		public static extern bool UsdClipsAPI_SetClipTemplateAssetPath__SWIG_0(HandleRef jarg1, string jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_SetClipTemplateAssetPath__SWIG_1")]
		public static extern bool UsdClipsAPI_SetClipTemplateAssetPath__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GetClipTemplateStride__SWIG_0")]
		public static extern bool UsdClipsAPI_GetClipTemplateStride__SWIG_0(HandleRef jarg1, out double jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GetClipTemplateStride__SWIG_1")]
		public static extern bool UsdClipsAPI_GetClipTemplateStride__SWIG_1(HandleRef jarg1, out double jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_SetClipTemplateActiveOffset__SWIG_0")]
		public static extern bool UsdClipsAPI_SetClipTemplateActiveOffset__SWIG_0(HandleRef jarg1, double jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_SetClipTemplateActiveOffset__SWIG_1")]
		public static extern bool UsdClipsAPI_SetClipTemplateActiveOffset__SWIG_1(HandleRef jarg1, double jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GetClipTemplateActiveOffset__SWIG_0")]
		public static extern bool UsdClipsAPI_GetClipTemplateActiveOffset__SWIG_0(HandleRef jarg1, out double jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GetClipTemplateActiveOffset__SWIG_1")]
		public static extern bool UsdClipsAPI_GetClipTemplateActiveOffset__SWIG_1(HandleRef jarg1, out double jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_SetClipTemplateStride__SWIG_0")]
		public static extern bool UsdClipsAPI_SetClipTemplateStride__SWIG_0(HandleRef jarg1, double jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_SetClipTemplateStride__SWIG_1")]
		public static extern bool UsdClipsAPI_SetClipTemplateStride__SWIG_1(HandleRef jarg1, double jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GetClipTemplateStartTime__SWIG_0")]
		public static extern bool UsdClipsAPI_GetClipTemplateStartTime__SWIG_0(HandleRef jarg1, out double jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GetClipTemplateStartTime__SWIG_1")]
		public static extern bool UsdClipsAPI_GetClipTemplateStartTime__SWIG_1(HandleRef jarg1, out double jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_SetClipTemplateStartTime__SWIG_0")]
		public static extern bool UsdClipsAPI_SetClipTemplateStartTime__SWIG_0(HandleRef jarg1, double jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_SetClipTemplateStartTime__SWIG_1")]
		public static extern bool UsdClipsAPI_SetClipTemplateStartTime__SWIG_1(HandleRef jarg1, double jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GetClipTemplateEndTime__SWIG_0")]
		public static extern bool UsdClipsAPI_GetClipTemplateEndTime__SWIG_0(HandleRef jarg1, out double jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_GetClipTemplateEndTime__SWIG_1")]
		public static extern bool UsdClipsAPI_GetClipTemplateEndTime__SWIG_1(HandleRef jarg1, out double jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_SetClipTemplateEndTime__SWIG_0")]
		public static extern bool UsdClipsAPI_SetClipTemplateEndTime__SWIG_0(HandleRef jarg1, double jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_SetClipTemplateEndTime__SWIG_1")]
		public static extern bool UsdClipsAPI_SetClipTemplateEndTime__SWIG_1(HandleRef jarg1, double jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdObjectSet__SWIG_0")]
		public static extern IntPtr new_UsdObjectSet__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdObjectSet__SWIG_1")]
		public static extern IntPtr new_UsdObjectSet__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObjectSet_size")]
		public static extern uint UsdObjectSet_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObjectSet_empty")]
		public static extern bool UsdObjectSet_empty(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObjectSet_Clear")]
		public static extern void UsdObjectSet_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObjectSet_Add")]
		public static extern bool UsdObjectSet_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObjectSet_Contains")]
		public static extern bool UsdObjectSet_Contains(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObjectSet_Remove")]
		public static extern bool UsdObjectSet_Remove(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObjectSet_getitem")]
		public static extern IntPtr UsdObjectSet_getitem(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObjectSet_create_iterator_begin")]
		public static extern IntPtr UsdObjectSet_create_iterator_begin(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObjectSet_get_next")]
		public static extern IntPtr UsdObjectSet_get_next(HandleRef jarg1, IntPtr jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdObjectSet_destroy_iterator")]
		public static extern void UsdObjectSet_destroy_iterator(HandleRef jarg1, IntPtr jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdObjectSet")]
		public static extern void delete_UsdObjectSet(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPIVector_Clear")]
		public static extern void UsdCollectionAPIVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPIVector_Add")]
		public static extern void UsdCollectionAPIVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPIVector_size")]
		public static extern uint UsdCollectionAPIVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPIVector_capacity")]
		public static extern uint UsdCollectionAPIVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPIVector_reserve")]
		public static extern void UsdCollectionAPIVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdCollectionAPIVector__SWIG_0")]
		public static extern IntPtr new_UsdCollectionAPIVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdCollectionAPIVector__SWIG_1")]
		public static extern IntPtr new_UsdCollectionAPIVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdCollectionAPIVector__SWIG_2")]
		public static extern IntPtr new_UsdCollectionAPIVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPIVector_getitemcopy")]
		public static extern IntPtr UsdCollectionAPIVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPIVector_getitem")]
		public static extern IntPtr UsdCollectionAPIVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPIVector_setitem")]
		public static extern void UsdCollectionAPIVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPIVector_AddRange")]
		public static extern void UsdCollectionAPIVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPIVector_GetRange")]
		public static extern IntPtr UsdCollectionAPIVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPIVector_Insert")]
		public static extern void UsdCollectionAPIVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPIVector_InsertRange")]
		public static extern void UsdCollectionAPIVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPIVector_RemoveAt")]
		public static extern void UsdCollectionAPIVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPIVector_RemoveRange")]
		public static extern void UsdCollectionAPIVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPIVector_Repeat")]
		public static extern IntPtr UsdCollectionAPIVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPIVector_Reverse__SWIG_0")]
		public static extern void UsdCollectionAPIVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPIVector_Reverse__SWIG_1")]
		public static extern void UsdCollectionAPIVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPIVector_SetRange")]
		public static extern void UsdCollectionAPIVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdCollectionAPIVector")]
		public static extern void delete_UsdCollectionAPIVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdCollectionAPI__SWIG_0")]
		public static extern IntPtr new_UsdCollectionAPI__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdCollectionAPI__SWIG_1")]
		public static extern IntPtr new_UsdCollectionAPI__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdCollectionAPI__SWIG_2")]
		public static extern IntPtr new_UsdCollectionAPI__SWIG_2();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdCollectionAPI__SWIG_3")]
		public static extern IntPtr new_UsdCollectionAPI__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdCollectionAPI")]
		public static extern void delete_UsdCollectionAPI(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdCollectionAPI_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdCollectionAPI_GetSchemaAttributeNames__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_GetSchemaAttributeNames__SWIG_2")]
		public static extern IntPtr UsdCollectionAPI_GetSchemaAttributeNames__SWIG_2(bool jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_GetName")]
		public static extern IntPtr UsdCollectionAPI_GetName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_Get__SWIG_0")]
		public static extern IntPtr UsdCollectionAPI_Get__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_Get__SWIG_1")]
		public static extern IntPtr UsdCollectionAPI_Get__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_GetAll")]
		public static extern IntPtr UsdCollectionAPI_GetAll(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_IsSchemaPropertyBaseName")]
		public static extern bool UsdCollectionAPI_IsSchemaPropertyBaseName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_IsCollectionAPIPath")]
		public static extern bool UsdCollectionAPI_IsCollectionAPIPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_CanApply__SWIG_0")]
		public static extern bool UsdCollectionAPI_CanApply__SWIG_0(HandleRef jarg1, HandleRef jarg2, out string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_CanApply__SWIG_1")]
		public static extern bool UsdCollectionAPI_CanApply__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_Apply")]
		public static extern IntPtr UsdCollectionAPI_Apply(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_GetExpansionRuleAttr")]
		public static extern IntPtr UsdCollectionAPI_GetExpansionRuleAttr(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_CreateExpansionRuleAttr__SWIG_0")]
		public static extern IntPtr UsdCollectionAPI_CreateExpansionRuleAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_CreateExpansionRuleAttr__SWIG_1")]
		public static extern IntPtr UsdCollectionAPI_CreateExpansionRuleAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_CreateExpansionRuleAttr__SWIG_2")]
		public static extern IntPtr UsdCollectionAPI_CreateExpansionRuleAttr__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_GetIncludeRootAttr")]
		public static extern IntPtr UsdCollectionAPI_GetIncludeRootAttr(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_CreateIncludeRootAttr__SWIG_0")]
		public static extern IntPtr UsdCollectionAPI_CreateIncludeRootAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_CreateIncludeRootAttr__SWIG_1")]
		public static extern IntPtr UsdCollectionAPI_CreateIncludeRootAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_CreateIncludeRootAttr__SWIG_2")]
		public static extern IntPtr UsdCollectionAPI_CreateIncludeRootAttr__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_GetIncludesRel")]
		public static extern IntPtr UsdCollectionAPI_GetIncludesRel(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_CreateIncludesRel")]
		public static extern IntPtr UsdCollectionAPI_CreateIncludesRel(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_GetExcludesRel")]
		public static extern IntPtr UsdCollectionAPI_GetExcludesRel(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_CreateExcludesRel")]
		public static extern IntPtr UsdCollectionAPI_CreateExcludesRel(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_GetCollection__SWIG_0")]
		public static extern IntPtr UsdCollectionAPI_GetCollection__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_GetCollection__SWIG_1")]
		public static extern IntPtr UsdCollectionAPI_GetCollection__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_GetAllCollections")]
		public static extern IntPtr UsdCollectionAPI_GetAllCollections(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_GetCollectionPath")]
		public static extern IntPtr UsdCollectionAPI_GetCollectionPath(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_GetNamedCollectionPath")]
		public static extern IntPtr UsdCollectionAPI_GetNamedCollectionPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_ComputeMembershipQuery__SWIG_0")]
		public static extern IntPtr UsdCollectionAPI_ComputeMembershipQuery__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_ComputeMembershipQuery__SWIG_1")]
		public static extern void UsdCollectionAPI_ComputeMembershipQuery__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_HasNoIncludedPaths")]
		public static extern bool UsdCollectionAPI_HasNoIncludedPaths(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_ComputeIncludedObjects__SWIG_0")]
		public static extern IntPtr UsdCollectionAPI_ComputeIncludedObjects__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_ComputeIncludedObjects__SWIG_1")]
		public static extern IntPtr UsdCollectionAPI_ComputeIncludedObjects__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_ComputeIncludedPaths__SWIG_0")]
		public static extern IntPtr UsdCollectionAPI_ComputeIncludedPaths__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_ComputeIncludedPaths__SWIG_1")]
		public static extern IntPtr UsdCollectionAPI_ComputeIncludedPaths__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_IncludePath")]
		public static extern bool UsdCollectionAPI_IncludePath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_ExcludePath")]
		public static extern bool UsdCollectionAPI_ExcludePath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_Validate")]
		public static extern bool UsdCollectionAPI_Validate(HandleRef jarg1, out string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_ResetCollection")]
		public static extern bool UsdCollectionAPI_ResetCollection(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_BlockCollection")]
		public static extern bool UsdCollectionAPI_BlockCollection(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_CanContainPropertyName")]
		public static extern bool UsdCollectionAPI_CanContainPropertyName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdModelAPI__SWIG_0")]
		public static extern IntPtr new_UsdModelAPI__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdModelAPI__SWIG_1")]
		public static extern IntPtr new_UsdModelAPI__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdModelAPI__SWIG_2")]
		public static extern IntPtr new_UsdModelAPI__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdModelAPI")]
		public static extern void delete_UsdModelAPI(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdModelAPI_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdModelAPI_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdModelAPI_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdModelAPI_GetSchemaAttributeNames__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdModelAPI_Get")]
		public static extern IntPtr UsdModelAPI_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdModelAPI_GetKind")]
		public static extern bool UsdModelAPI_GetKind(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdModelAPI_SetKind")]
		public static extern bool UsdModelAPI_SetKind(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdModelAPI_IsKind__SWIG_0")]
		public static extern bool UsdModelAPI_IsKind__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdModelAPI_IsKind__SWIG_1")]
		public static extern bool UsdModelAPI_IsKind__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdModelAPI_IsModel")]
		public static extern bool UsdModelAPI_IsModel(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdModelAPI_IsGroup")]
		public static extern bool UsdModelAPI_IsGroup(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdModelAPI_GetAssetIdentifier")]
		public static extern bool UsdModelAPI_GetAssetIdentifier(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdModelAPI_SetAssetIdentifier")]
		public static extern void UsdModelAPI_SetAssetIdentifier(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdModelAPI_GetAssetName")]
		public static extern bool UsdModelAPI_GetAssetName(HandleRef jarg1, out string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdModelAPI_SetAssetName")]
		public static extern void UsdModelAPI_SetAssetName(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdModelAPI_GetAssetVersion")]
		public static extern bool UsdModelAPI_GetAssetVersion(HandleRef jarg1, out string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdModelAPI_SetAssetVersion")]
		public static extern void UsdModelAPI_SetAssetVersion(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdModelAPI_GetPayloadAssetDependencies")]
		public static extern bool UsdModelAPI_GetPayloadAssetDependencies(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdModelAPI_SetPayloadAssetDependencies")]
		public static extern void UsdModelAPI_SetPayloadAssetDependencies(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdModelAPI_GetAssetInfo")]
		public static extern bool UsdModelAPI_GetAssetInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdModelAPI_SetAssetInfo")]
		public static extern void UsdModelAPI_SetAssetInfo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdTyped__SWIG_0")]
		public static extern IntPtr new_UsdTyped__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdTyped__SWIG_1")]
		public static extern IntPtr new_UsdTyped__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdTyped__SWIG_2")]
		public static extern IntPtr new_UsdTyped__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdTyped")]
		public static extern void delete_UsdTyped(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTyped_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdTyped_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTyped_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdTyped_GetSchemaAttributeNames__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTyped_Get")]
		public static extern IntPtr UsdTyped_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdSpecializes_AddSpecialize__SWIG_0")]
		public static extern bool UsdSpecializes_AddSpecialize__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdSpecializes_AddSpecialize__SWIG_1")]
		public static extern bool UsdSpecializes_AddSpecialize__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdSpecializes_RemoveSpecialize")]
		public static extern bool UsdSpecializes_RemoveSpecialize(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdSpecializes_ClearSpecializes")]
		public static extern bool UsdSpecializes_ClearSpecializes(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdSpecializes_SetSpecializes")]
		public static extern bool UsdSpecializes_SetSpecializes(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdSpecializes_GetPrim__SWIG_0")]
		public static extern IntPtr UsdSpecializes_GetPrim__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdSpecializes")]
		public static extern void delete_UsdSpecializes(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_CreateNew__SWIG_0")]
		public static extern IntPtr UsdStage_CreateNew__SWIG_0(string jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_CreateNew__SWIG_1")]
		public static extern IntPtr UsdStage_CreateNew__SWIG_1(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_CreateNew__SWIG_2")]
		public static extern IntPtr UsdStage_CreateNew__SWIG_2(string jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_CreateNew__SWIG_3")]
		public static extern IntPtr UsdStage_CreateNew__SWIG_3(string jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_CreateNew__SWIG_4")]
		public static extern IntPtr UsdStage_CreateNew__SWIG_4(string jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_CreateNew__SWIG_5")]
		public static extern IntPtr UsdStage_CreateNew__SWIG_5(string jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_CreateNew__SWIG_6")]
		public static extern IntPtr UsdStage_CreateNew__SWIG_6(string jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_CreateNew__SWIG_7")]
		public static extern IntPtr UsdStage_CreateNew__SWIG_7(string jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_CreateInMemory__SWIG_0")]
		public static extern IntPtr UsdStage_CreateInMemory__SWIG_0(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_CreateInMemory__SWIG_1")]
		public static extern IntPtr UsdStage_CreateInMemory__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_CreateInMemory__SWIG_2")]
		public static extern IntPtr UsdStage_CreateInMemory__SWIG_2(string jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_CreateInMemory__SWIG_3")]
		public static extern IntPtr UsdStage_CreateInMemory__SWIG_3(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_CreateInMemory__SWIG_4")]
		public static extern IntPtr UsdStage_CreateInMemory__SWIG_4(string jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_CreateInMemory__SWIG_5")]
		public static extern IntPtr UsdStage_CreateInMemory__SWIG_5(string jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_CreateInMemory__SWIG_6")]
		public static extern IntPtr UsdStage_CreateInMemory__SWIG_6(string jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_CreateInMemory__SWIG_7")]
		public static extern IntPtr UsdStage_CreateInMemory__SWIG_7(string jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_CreateInMemory__SWIG_8")]
		public static extern IntPtr UsdStage_CreateInMemory__SWIG_8(string jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_CreateInMemory__SWIG_9")]
		public static extern IntPtr UsdStage_CreateInMemory__SWIG_9(string jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_Open__SWIG_0")]
		public static extern IntPtr UsdStage_Open__SWIG_0(string jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_Open__SWIG_1")]
		public static extern IntPtr UsdStage_Open__SWIG_1(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_Open__SWIG_2")]
		public static extern IntPtr UsdStage_Open__SWIG_2(string jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_Open__SWIG_3")]
		public static extern IntPtr UsdStage_Open__SWIG_3(string jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_OpenMasked__SWIG_0")]
		public static extern IntPtr UsdStage_OpenMasked__SWIG_0(string jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_OpenMasked__SWIG_1")]
		public static extern IntPtr UsdStage_OpenMasked__SWIG_1(string jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_OpenMasked__SWIG_2")]
		public static extern IntPtr UsdStage_OpenMasked__SWIG_2(string jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_OpenMasked__SWIG_3")]
		public static extern IntPtr UsdStage_OpenMasked__SWIG_3(string jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_Open__SWIG_4")]
		public static extern IntPtr UsdStage_Open__SWIG_4(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_Open__SWIG_5")]
		public static extern IntPtr UsdStage_Open__SWIG_5(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_Open__SWIG_6")]
		public static extern IntPtr UsdStage_Open__SWIG_6(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_Open__SWIG_7")]
		public static extern IntPtr UsdStage_Open__SWIG_7(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_Open__SWIG_8")]
		public static extern IntPtr UsdStage_Open__SWIG_8(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_Open__SWIG_9")]
		public static extern IntPtr UsdStage_Open__SWIG_9(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_Open__SWIG_10")]
		public static extern IntPtr UsdStage_Open__SWIG_10(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_Open__SWIG_11")]
		public static extern IntPtr UsdStage_Open__SWIG_11(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_OpenMasked__SWIG_4")]
		public static extern IntPtr UsdStage_OpenMasked__SWIG_4(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_OpenMasked__SWIG_5")]
		public static extern IntPtr UsdStage_OpenMasked__SWIG_5(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_OpenMasked__SWIG_6")]
		public static extern IntPtr UsdStage_OpenMasked__SWIG_6(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_OpenMasked__SWIG_7")]
		public static extern IntPtr UsdStage_OpenMasked__SWIG_7(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_OpenMasked__SWIG_8")]
		public static extern IntPtr UsdStage_OpenMasked__SWIG_8(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_OpenMasked__SWIG_9")]
		public static extern IntPtr UsdStage_OpenMasked__SWIG_9(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_OpenMasked__SWIG_10")]
		public static extern IntPtr UsdStage_OpenMasked__SWIG_10(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_OpenMasked__SWIG_11")]
		public static extern IntPtr UsdStage_OpenMasked__SWIG_11(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdStage")]
		public static extern void delete_UsdStage(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_Reload")]
		public static extern void UsdStage_Reload(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_IsSupportedFile")]
		public static extern bool UsdStage_IsSupportedFile(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_Save")]
		public static extern void UsdStage_Save(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_SaveSessionLayers")]
		public static extern void UsdStage_SaveSessionLayers(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetGlobalVariantFallbacks")]
		public static extern IntPtr UsdStage_GetGlobalVariantFallbacks();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_SetGlobalVariantFallbacks")]
		public static extern void UsdStage_SetGlobalVariantFallbacks(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_Load__SWIG_0")]
		public static extern IntPtr UsdStage_Load__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_Load__SWIG_1")]
		public static extern IntPtr UsdStage_Load__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_Load__SWIG_2")]
		public static extern IntPtr UsdStage_Load__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_Unload__SWIG_0")]
		public static extern void UsdStage_Unload__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_Unload__SWIG_1")]
		public static extern void UsdStage_Unload__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_LoadAndUnload__SWIG_0")]
		public static extern void UsdStage_LoadAndUnload__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_LoadAndUnload__SWIG_1")]
		public static extern void UsdStage_LoadAndUnload__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetLoadSet")]
		public static extern IntPtr UsdStage_GetLoadSet(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_FindLoadable__SWIG_0")]
		public static extern IntPtr UsdStage_FindLoadable__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_FindLoadable__SWIG_1")]
		public static extern IntPtr UsdStage_FindLoadable__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetLoadRules")]
		public static extern IntPtr UsdStage_GetLoadRules(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_SetLoadRules")]
		public static extern void UsdStage_SetLoadRules(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetPopulationMask")]
		public static extern IntPtr UsdStage_GetPopulationMask(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_SetPopulationMask")]
		public static extern void UsdStage_SetPopulationMask(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetPseudoRoot")]
		public static extern IntPtr UsdStage_GetPseudoRoot(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetDefaultPrim")]
		public static extern IntPtr UsdStage_GetDefaultPrim(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_SetDefaultPrim")]
		public static extern void UsdStage_SetDefaultPrim(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_ClearDefaultPrim")]
		public static extern void UsdStage_ClearDefaultPrim(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_HasDefaultPrim")]
		public static extern bool UsdStage_HasDefaultPrim(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetPrimAtPath")]
		public static extern IntPtr UsdStage_GetPrimAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetObjectAtPath")]
		public static extern IntPtr UsdStage_GetObjectAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetPropertyAtPath")]
		public static extern IntPtr UsdStage_GetPropertyAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetAttributeAtPath")]
		public static extern IntPtr UsdStage_GetAttributeAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetRelationshipAtPath")]
		public static extern IntPtr UsdStage_GetRelationshipAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_Traverse__SWIG_0")]
		public static extern IntPtr UsdStage_Traverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_Traverse__SWIG_1")]
		public static extern IntPtr UsdStage_Traverse__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_TraverseAll")]
		public static extern IntPtr UsdStage_TraverseAll(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_OverridePrim")]
		public static extern IntPtr UsdStage_OverridePrim(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_DefinePrim__SWIG_0")]
		public static extern IntPtr UsdStage_DefinePrim__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_DefinePrim__SWIG_1")]
		public static extern IntPtr UsdStage_DefinePrim__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_CreateClassPrim")]
		public static extern IntPtr UsdStage_CreateClassPrim(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_RemovePrim")]
		public static extern bool UsdStage_RemovePrim(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetSessionLayer")]
		public static extern IntPtr UsdStage_GetSessionLayer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetRootLayer")]
		public static extern IntPtr UsdStage_GetRootLayer(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetPathResolverContext")]
		public static extern IntPtr UsdStage_GetPathResolverContext(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_ResolveIdentifierToEditTarget")]
		public static extern string UsdStage_ResolveIdentifierToEditTarget(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetLayerStack__SWIG_0")]
		public static extern IntPtr UsdStage_GetLayerStack__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetLayerStack__SWIG_1")]
		public static extern IntPtr UsdStage_GetLayerStack__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetUsedLayers__SWIG_0")]
		public static extern IntPtr UsdStage_GetUsedLayers__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetUsedLayers__SWIG_1")]
		public static extern IntPtr UsdStage_GetUsedLayers__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_HasLocalLayer")]
		public static extern bool UsdStage_HasLocalLayer(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetEditTarget")]
		public static extern IntPtr UsdStage_GetEditTarget(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetEditTargetForLocalLayer__SWIG_0")]
		public static extern IntPtr UsdStage_GetEditTargetForLocalLayer__SWIG_0(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetEditTargetForLocalLayer__SWIG_1")]
		public static extern IntPtr UsdStage_GetEditTargetForLocalLayer__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_SetEditTarget")]
		public static extern void UsdStage_SetEditTarget(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_MuteLayer")]
		public static extern void UsdStage_MuteLayer(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_UnmuteLayer")]
		public static extern void UsdStage_UnmuteLayer(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_MuteAndUnmuteLayers")]
		public static extern void UsdStage_MuteAndUnmuteLayers(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetMutedLayers")]
		public static extern IntPtr UsdStage_GetMutedLayers(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_IsLayerMuted")]
		public static extern bool UsdStage_IsLayerMuted(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_Export__SWIG_0")]
		public static extern bool UsdStage_Export__SWIG_0(HandleRef jarg1, string jarg2, bool jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_Export__SWIG_1")]
		public static extern bool UsdStage_Export__SWIG_1(HandleRef jarg1, string jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_Export__SWIG_2")]
		public static extern bool UsdStage_Export__SWIG_2(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_ExportToString__SWIG_0")]
		public static extern bool UsdStage_ExportToString__SWIG_0(HandleRef jarg1, out string jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_ExportToString__SWIG_1")]
		public static extern bool UsdStage_ExportToString__SWIG_1(HandleRef jarg1, out string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_Flatten__SWIG_0")]
		public static extern IntPtr UsdStage_Flatten__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_Flatten__SWIG_1")]
		public static extern IntPtr UsdStage_Flatten__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetMetadata")]
		public static extern bool UsdStage_GetMetadata(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_HasMetadata")]
		public static extern bool UsdStage_HasMetadata(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_HasAuthoredMetadata")]
		public static extern bool UsdStage_HasAuthoredMetadata(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_SetMetadata")]
		public static extern bool UsdStage_SetMetadata(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_ClearMetadata")]
		public static extern bool UsdStage_ClearMetadata(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetMetadataByDictKey")]
		public static extern bool UsdStage_GetMetadataByDictKey(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_HasMetadataDictKey")]
		public static extern bool UsdStage_HasMetadataDictKey(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_HasAuthoredMetadataDictKey")]
		public static extern bool UsdStage_HasAuthoredMetadataDictKey(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_SetMetadataByDictKey")]
		public static extern bool UsdStage_SetMetadataByDictKey(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_ClearMetadataByDictKey")]
		public static extern bool UsdStage_ClearMetadataByDictKey(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_WriteFallbackPrimTypes")]
		public static extern void UsdStage_WriteFallbackPrimTypes(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetStartTimeCode")]
		public static extern double UsdStage_GetStartTimeCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_SetStartTimeCode")]
		public static extern void UsdStage_SetStartTimeCode(HandleRef jarg1, double jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetEndTimeCode")]
		public static extern double UsdStage_GetEndTimeCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_SetEndTimeCode")]
		public static extern void UsdStage_SetEndTimeCode(HandleRef jarg1, double jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_HasAuthoredTimeCodeRange")]
		public static extern bool UsdStage_HasAuthoredTimeCodeRange(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetTimeCodesPerSecond")]
		public static extern double UsdStage_GetTimeCodesPerSecond(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_SetTimeCodesPerSecond")]
		public static extern void UsdStage_SetTimeCodesPerSecond(HandleRef jarg1, double jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetFramesPerSecond")]
		public static extern double UsdStage_GetFramesPerSecond(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_SetFramesPerSecond")]
		public static extern void UsdStage_SetFramesPerSecond(HandleRef jarg1, double jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_SetColorConfiguration")]
		public static extern void UsdStage_SetColorConfiguration(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetColorConfiguration")]
		public static extern IntPtr UsdStage_GetColorConfiguration(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_SetColorManagementSystem")]
		public static extern void UsdStage_SetColorManagementSystem(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetColorManagementSystem")]
		public static extern IntPtr UsdStage_GetColorManagementSystem(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetColorConfigFallbacks")]
		public static extern void UsdStage_GetColorConfigFallbacks(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_SetColorConfigFallbacks")]
		public static extern void UsdStage_SetColorConfigFallbacks(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_SetInterpolationType")]
		public static extern void UsdStage_SetInterpolationType(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetInterpolationType")]
		public static extern int UsdStage_GetInterpolationType(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetPrototypes")]
		public static extern IntPtr UsdStage_GetPrototypes(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetAllPrims")]
		public static extern IntPtr UsdStage_GetAllPrims(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetAllPrimsByType")]
		public static extern IntPtr UsdStage_GetAllPrimsByType(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetAllPaths")]
		public static extern IntPtr UsdStage_GetAllPaths(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStage_GetAllPathsByType")]
		public static extern IntPtr UsdStage_GetAllPathsByType(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStageCacheResultPair__SWIG_0")]
		public static extern IntPtr new_UsdStageCacheResultPair__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStageCacheResultPair__SWIG_1")]
		public static extern IntPtr new_UsdStageCacheResultPair__SWIG_1(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStageCacheResultPair__SWIG_2")]
		public static extern IntPtr new_UsdStageCacheResultPair__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCacheResultPair_first_set")]
		public static extern void UsdStageCacheResultPair_first_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCacheResultPair_first_get")]
		public static extern IntPtr UsdStageCacheResultPair_first_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCacheResultPair_second_set")]
		public static extern void UsdStageCacheResultPair_second_set(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCacheResultPair_second_get")]
		public static extern bool UsdStageCacheResultPair_second_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdStageCacheResultPair")]
		public static extern void delete_UsdStageCacheResultPair(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStageCache__SWIG_0")]
		public static extern IntPtr new_UsdStageCache__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStageCache__SWIG_1")]
		public static extern IntPtr new_UsdStageCache__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdStageCache")]
		public static extern void delete_UsdStageCache(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCache_swap")]
		public static extern void UsdStageCache_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCache_GetAllStages")]
		public static extern IntPtr UsdStageCache_GetAllStages(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCache_Size")]
		public static extern uint UsdStageCache_Size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCache_IsEmpty")]
		public static extern bool UsdStageCache_IsEmpty(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCache_RequestStage")]
		public static extern IntPtr UsdStageCache_RequestStage(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCache_Find")]
		public static extern IntPtr UsdStageCache_Find(HandleRef jarg1, long jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCache_FindOneMatching__SWIG_0")]
		public static extern IntPtr UsdStageCache_FindOneMatching__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCache_FindOneMatching__SWIG_1")]
		public static extern IntPtr UsdStageCache_FindOneMatching__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCache_FindOneMatching__SWIG_2")]
		public static extern IntPtr UsdStageCache_FindOneMatching__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCache_FindOneMatching__SWIG_3")]
		public static extern IntPtr UsdStageCache_FindOneMatching__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCache_FindAllMatching__SWIG_0")]
		public static extern IntPtr UsdStageCache_FindAllMatching__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCache_FindAllMatching__SWIG_1")]
		public static extern IntPtr UsdStageCache_FindAllMatching__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCache_FindAllMatching__SWIG_2")]
		public static extern IntPtr UsdStageCache_FindAllMatching__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCache_FindAllMatching__SWIG_3")]
		public static extern IntPtr UsdStageCache_FindAllMatching__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCache_GetId")]
		public static extern long UsdStageCache_GetId(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCache_Contains__SWIG_0")]
		public static extern bool UsdStageCache_Contains__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCache_Contains__SWIG_1")]
		public static extern bool UsdStageCache_Contains__SWIG_1(HandleRef jarg1, long jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCache_Insert")]
		public static extern long UsdStageCache_Insert(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCache_Erase__SWIG_0")]
		public static extern bool UsdStageCache_Erase__SWIG_0(HandleRef jarg1, long jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCache_Erase__SWIG_1")]
		public static extern bool UsdStageCache_Erase__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCache_EraseAll__SWIG_0")]
		public static extern uint UsdStageCache_EraseAll__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCache_EraseAll__SWIG_1")]
		public static extern uint UsdStageCache_EraseAll__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCache_EraseAll__SWIG_2")]
		public static extern uint UsdStageCache_EraseAll__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCache_Clear")]
		public static extern void UsdStageCache_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCache_SetDebugName")]
		public static extern void UsdStageCache_SetDebugName(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCache_GetDebugName")]
		public static extern string UsdStageCache_GetDebugName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdStageCacheRequest")]
		public static extern void delete_UsdStageCacheRequest(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCacheRequest_IsSatisfiedBy__SWIG_0")]
		public static extern bool UsdStageCacheRequest_IsSatisfiedBy__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCacheRequest_IsSatisfiedBy__SWIG_1")]
		public static extern bool UsdStageCacheRequest_IsSatisfiedBy__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageCacheRequest_Manufacture")]
		public static extern IntPtr UsdStageCacheRequest_Manufacture(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStageLoadRulesPair__SWIG_0")]
		public static extern IntPtr new_UsdStageLoadRulesPair__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStageLoadRulesPair__SWIG_1")]
		public static extern IntPtr new_UsdStageLoadRulesPair__SWIG_1(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStageLoadRulesPair__SWIG_2")]
		public static extern IntPtr new_UsdStageLoadRulesPair__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRulesPair_first_set")]
		public static extern void UsdStageLoadRulesPair_first_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRulesPair_first_get")]
		public static extern IntPtr UsdStageLoadRulesPair_first_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRulesPair_second_set")]
		public static extern void UsdStageLoadRulesPair_second_set(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRulesPair_second_get")]
		public static extern int UsdStageLoadRulesPair_second_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdStageLoadRulesPair")]
		public static extern void delete_UsdStageLoadRulesPair(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRulesVectorPair_Clear")]
		public static extern void UsdStageLoadRulesVectorPair_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRulesVectorPair_Add")]
		public static extern void UsdStageLoadRulesVectorPair_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRulesVectorPair_size")]
		public static extern uint UsdStageLoadRulesVectorPair_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRulesVectorPair_capacity")]
		public static extern uint UsdStageLoadRulesVectorPair_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRulesVectorPair_reserve")]
		public static extern void UsdStageLoadRulesVectorPair_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStageLoadRulesVectorPair__SWIG_0")]
		public static extern IntPtr new_UsdStageLoadRulesVectorPair__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStageLoadRulesVectorPair__SWIG_1")]
		public static extern IntPtr new_UsdStageLoadRulesVectorPair__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStageLoadRulesVectorPair__SWIG_2")]
		public static extern IntPtr new_UsdStageLoadRulesVectorPair__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRulesVectorPair_getitemcopy")]
		public static extern IntPtr UsdStageLoadRulesVectorPair_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRulesVectorPair_getitem")]
		public static extern IntPtr UsdStageLoadRulesVectorPair_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRulesVectorPair_setitem")]
		public static extern void UsdStageLoadRulesVectorPair_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRulesVectorPair_AddRange")]
		public static extern void UsdStageLoadRulesVectorPair_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRulesVectorPair_GetRange")]
		public static extern IntPtr UsdStageLoadRulesVectorPair_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRulesVectorPair_Insert")]
		public static extern void UsdStageLoadRulesVectorPair_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRulesVectorPair_InsertRange")]
		public static extern void UsdStageLoadRulesVectorPair_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRulesVectorPair_RemoveAt")]
		public static extern void UsdStageLoadRulesVectorPair_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRulesVectorPair_RemoveRange")]
		public static extern void UsdStageLoadRulesVectorPair_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRulesVectorPair_Repeat")]
		public static extern IntPtr UsdStageLoadRulesVectorPair_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRulesVectorPair_Reverse__SWIG_0")]
		public static extern void UsdStageLoadRulesVectorPair_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRulesVectorPair_Reverse__SWIG_1")]
		public static extern void UsdStageLoadRulesVectorPair_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRulesVectorPair_SetRange")]
		public static extern void UsdStageLoadRulesVectorPair_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdStageLoadRulesVectorPair")]
		public static extern void delete_UsdStageLoadRulesVectorPair(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStageLoadRules__SWIG_0")]
		public static extern IntPtr new_UsdStageLoadRules__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRules_LoadAll")]
		public static extern IntPtr UsdStageLoadRules_LoadAll();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRules_LoadNone")]
		public static extern IntPtr UsdStageLoadRules_LoadNone();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStageLoadRules__SWIG_1")]
		public static extern IntPtr new_UsdStageLoadRules__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRules_LoadWithDescendants")]
		public static extern void UsdStageLoadRules_LoadWithDescendants(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRules_LoadWithoutDescendants")]
		public static extern void UsdStageLoadRules_LoadWithoutDescendants(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRules_Unload")]
		public static extern void UsdStageLoadRules_Unload(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRules_LoadAndUnload")]
		public static extern void UsdStageLoadRules_LoadAndUnload(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRules_AddRule")]
		public static extern void UsdStageLoadRules_AddRule(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRules_SetRules__SWIG_0")]
		public static extern void UsdStageLoadRules_SetRules__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRules_Minimize")]
		public static extern void UsdStageLoadRules_Minimize(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRules_IsLoaded")]
		public static extern bool UsdStageLoadRules_IsLoaded(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRules_IsLoadedWithAllDescendants")]
		public static extern bool UsdStageLoadRules_IsLoadedWithAllDescendants(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRules_IsLoadedWithNoDescendants")]
		public static extern bool UsdStageLoadRules_IsLoadedWithNoDescendants(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRules_GetEffectiveRuleForPath")]
		public static extern int UsdStageLoadRules_GetEffectiveRuleForPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRules_GetRules")]
		public static extern IntPtr UsdStageLoadRules_GetRules(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStageLoadRules_swap")]
		public static extern void UsdStageLoadRules_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdStageLoadRules")]
		public static extern void delete_UsdStageLoadRules(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePopulationMask_All")]
		public static extern IntPtr UsdStagePopulationMask_All();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStagePopulationMask__SWIG_0")]
		public static extern IntPtr new_UsdStagePopulationMask__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStagePopulationMask__SWIG_1")]
		public static extern IntPtr new_UsdStagePopulationMask__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdStagePopulationMask__SWIG_4")]
		public static extern IntPtr new_UsdStagePopulationMask__SWIG_4(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePopulationMask_Union")]
		public static extern IntPtr UsdStagePopulationMask_Union(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePopulationMask_GetUnion__SWIG_0")]
		public static extern IntPtr UsdStagePopulationMask_GetUnion__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePopulationMask_GetUnion__SWIG_1")]
		public static extern IntPtr UsdStagePopulationMask_GetUnion__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePopulationMask_Intersection")]
		public static extern IntPtr UsdStagePopulationMask_Intersection(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePopulationMask_GetIntersection")]
		public static extern IntPtr UsdStagePopulationMask_GetIntersection(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePopulationMask_Includes__SWIG_0")]
		public static extern bool UsdStagePopulationMask_Includes__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePopulationMask_Includes__SWIG_1")]
		public static extern bool UsdStagePopulationMask_Includes__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePopulationMask_IncludesSubtree")]
		public static extern bool UsdStagePopulationMask_IncludesSubtree(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePopulationMask_IsEmpty")]
		public static extern bool UsdStagePopulationMask_IsEmpty(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePopulationMask_GetIncludedChildNames")]
		public static extern bool UsdStagePopulationMask_GetIncludedChildNames(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePopulationMask_GetPaths")]
		public static extern IntPtr UsdStagePopulationMask_GetPaths(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePopulationMask_Add__SWIG_0")]
		public static extern IntPtr UsdStagePopulationMask_Add__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePopulationMask_Add__SWIG_1")]
		public static extern IntPtr UsdStagePopulationMask_Add__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdStagePopulationMask_swap")]
		public static extern void UsdStagePopulationMask_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdStagePopulationMask")]
		public static extern void delete_UsdStagePopulationMask(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCodeVector_Clear")]
		public static extern void UsdTimeCodeVector_Clear(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCodeVector_Add")]
		public static extern void UsdTimeCodeVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCodeVector_size")]
		public static extern uint UsdTimeCodeVector_size(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCodeVector_capacity")]
		public static extern uint UsdTimeCodeVector_capacity(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCodeVector_reserve")]
		public static extern void UsdTimeCodeVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdTimeCodeVector__SWIG_0")]
		public static extern IntPtr new_UsdTimeCodeVector__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdTimeCodeVector__SWIG_1")]
		public static extern IntPtr new_UsdTimeCodeVector__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdTimeCodeVector__SWIG_2")]
		public static extern IntPtr new_UsdTimeCodeVector__SWIG_2(int jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCodeVector_getitemcopy")]
		public static extern IntPtr UsdTimeCodeVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCodeVector_getitem")]
		public static extern IntPtr UsdTimeCodeVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCodeVector_setitem")]
		public static extern void UsdTimeCodeVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCodeVector_AddRange")]
		public static extern void UsdTimeCodeVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCodeVector_GetRange")]
		public static extern IntPtr UsdTimeCodeVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCodeVector_Insert")]
		public static extern void UsdTimeCodeVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCodeVector_InsertRange")]
		public static extern void UsdTimeCodeVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCodeVector_RemoveAt")]
		public static extern void UsdTimeCodeVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCodeVector_RemoveRange")]
		public static extern void UsdTimeCodeVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCodeVector_Repeat")]
		public static extern IntPtr UsdTimeCodeVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCodeVector_Reverse__SWIG_0")]
		public static extern void UsdTimeCodeVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCodeVector_Reverse__SWIG_1")]
		public static extern void UsdTimeCodeVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCodeVector_SetRange")]
		public static extern void UsdTimeCodeVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdTimeCodeVector")]
		public static extern void delete_UsdTimeCodeVector(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdTimeCode__SWIG_0")]
		public static extern IntPtr new_UsdTimeCode__SWIG_0(double jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdTimeCode__SWIG_1")]
		public static extern IntPtr new_UsdTimeCode__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdTimeCode__SWIG_2")]
		public static extern IntPtr new_UsdTimeCode__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCode_EarliestTime")]
		public static extern IntPtr UsdTimeCode_EarliestTime();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCode_Default")]
		public static extern IntPtr UsdTimeCode_Default();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCode_SafeStep__SWIG_0")]
		public static extern double UsdTimeCode_SafeStep__SWIG_0(double jarg1, double jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCode_SafeStep__SWIG_1")]
		public static extern double UsdTimeCode_SafeStep__SWIG_1(double jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCode_SafeStep__SWIG_2")]
		public static extern double UsdTimeCode_SafeStep__SWIG_2();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCode_IsEarliestTime")]
		public static extern bool UsdTimeCode_IsEarliestTime(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCode_IsDefault")]
		public static extern bool UsdTimeCode_IsDefault(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCode_IsNumeric")]
		public static extern bool UsdTimeCode_IsNumeric(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCode_GetValue")]
		public static extern double UsdTimeCode_GetValue(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCode_Equals")]
		public static extern bool UsdTimeCode_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTimeCode_GetHashCode")]
		public static extern int UsdTimeCode_GetHashCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdTimeCode")]
		public static extern void delete_UsdTimeCode(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_VariantEditContext__SWIG_0")]
		public static extern IntPtr new_VariantEditContext__SWIG_0();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_VariantEditContext__SWIG_1")]
		public static extern IntPtr new_VariantEditContext__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_VariantEditContext__SWIG_2")]
		public static extern IntPtr new_VariantEditContext__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_VariantEditContext_first_set")]
		public static extern void VariantEditContext_first_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_VariantEditContext_first_get")]
		public static extern IntPtr VariantEditContext_first_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_VariantEditContext_second_set")]
		public static extern void VariantEditContext_second_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_VariantEditContext_second_get")]
		public static extern IntPtr VariantEditContext_second_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_VariantEditContext")]
		public static extern void delete_VariantEditContext(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVariantSet_AddVariant__SWIG_0")]
		public static extern bool UsdVariantSet_AddVariant__SWIG_0(HandleRef jarg1, string jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVariantSet_AddVariant__SWIG_1")]
		public static extern bool UsdVariantSet_AddVariant__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVariantSet_GetVariantNames")]
		public static extern IntPtr UsdVariantSet_GetVariantNames(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVariantSet_HasAuthoredVariant")]
		public static extern bool UsdVariantSet_HasAuthoredVariant(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVariantSet_GetVariantSelection")]
		public static extern string UsdVariantSet_GetVariantSelection(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVariantSet_HasAuthoredVariantSelection__SWIG_0")]
		public static extern bool UsdVariantSet_HasAuthoredVariantSelection__SWIG_0(HandleRef jarg1, out string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVariantSet_HasAuthoredVariantSelection__SWIG_1")]
		public static extern bool UsdVariantSet_HasAuthoredVariantSelection__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVariantSet_SetVariantSelection")]
		public static extern bool UsdVariantSet_SetVariantSelection(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVariantSet_ClearVariantSelection")]
		public static extern bool UsdVariantSet_ClearVariantSelection(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVariantSet_BlockVariantSelection")]
		public static extern bool UsdVariantSet_BlockVariantSelection(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVariantSet_GetVariantEditTarget__SWIG_0")]
		public static extern IntPtr UsdVariantSet_GetVariantEditTarget__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVariantSet_GetVariantEditTarget__SWIG_1")]
		public static extern IntPtr UsdVariantSet_GetVariantEditTarget__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVariantSet_GetVariantEditContext__SWIG_0")]
		public static extern IntPtr UsdVariantSet_GetVariantEditContext__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVariantSet_GetVariantEditContext__SWIG_1")]
		public static extern IntPtr UsdVariantSet_GetVariantEditContext__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVariantSet_GetPrim")]
		public static extern IntPtr UsdVariantSet_GetPrim(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVariantSet_GetName")]
		public static extern string UsdVariantSet_GetName(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVariantSet_IsValid")]
		public static extern bool UsdVariantSet_IsValid(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdVariantSet")]
		public static extern void delete_UsdVariantSet(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVariantSets_AddVariantSet__SWIG_0")]
		public static extern IntPtr UsdVariantSets_AddVariantSet__SWIG_0(HandleRef jarg1, string jarg2, int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVariantSets_AddVariantSet__SWIG_1")]
		public static extern IntPtr UsdVariantSets_AddVariantSet__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVariantSets_GetNames__SWIG_0")]
		public static extern bool UsdVariantSets_GetNames__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVariantSets_GetNames__SWIG_1")]
		public static extern IntPtr UsdVariantSets_GetNames__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVariantSets_GetVariantSet")]
		public static extern IntPtr UsdVariantSets_GetVariantSet(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVariantSets_HasVariantSet")]
		public static extern bool UsdVariantSets_HasVariantSet(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVariantSets_GetVariantSelection")]
		public static extern string UsdVariantSets_GetVariantSelection(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVariantSets_SetSelection")]
		public static extern bool UsdVariantSets_SetSelection(HandleRef jarg1, string jarg2, string jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVariantSets_GetAllVariantSelections")]
		public static extern IntPtr UsdVariantSets_GetAllVariantSelections(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdVariantSets")]
		public static extern void delete_UsdVariantSets(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdZipFile_Open__SWIG_0")]
		public static extern IntPtr UsdZipFile_Open__SWIG_0(string jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdZipFile_Open__SWIG_1")]
		public static extern IntPtr UsdZipFile_Open__SWIG_1(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdZipFile")]
		public static extern IntPtr new_UsdZipFile();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdZipFile")]
		public static extern void delete_UsdZipFile(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdZipFile_FileInfo_dataOffset_set")]
		public static extern void UsdZipFile_FileInfo_dataOffset_set(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdZipFile_FileInfo_dataOffset_get")]
		public static extern uint UsdZipFile_FileInfo_dataOffset_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdZipFile_FileInfo_size_set")]
		public static extern void UsdZipFile_FileInfo_size_set(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdZipFile_FileInfo_size_get")]
		public static extern uint UsdZipFile_FileInfo_size_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdZipFile_FileInfo_uncompressedSize_set")]
		public static extern void UsdZipFile_FileInfo_uncompressedSize_set(HandleRef jarg1, uint jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdZipFile_FileInfo_uncompressedSize_get")]
		public static extern uint UsdZipFile_FileInfo_uncompressedSize_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdZipFile_FileInfo_compressionMethod_set")]
		public static extern void UsdZipFile_FileInfo_compressionMethod_set(HandleRef jarg1, ushort jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdZipFile_FileInfo_compressionMethod_get")]
		public static extern ushort UsdZipFile_FileInfo_compressionMethod_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdZipFile_FileInfo_encrypted_set")]
		public static extern void UsdZipFile_FileInfo_encrypted_set(HandleRef jarg1, bool jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdZipFile_FileInfo_encrypted_get")]
		public static extern bool UsdZipFile_FileInfo_encrypted_get(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdZipFile_FileInfo")]
		public static extern IntPtr new_UsdZipFile_FileInfo();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdZipFile_FileInfo")]
		public static extern void delete_UsdZipFile_FileInfo(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdZipFile_begin")]
		public static extern IntPtr UsdZipFile_begin(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdZipFile_cbegin")]
		public static extern IntPtr UsdZipFile_cbegin(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdZipFile_end")]
		public static extern IntPtr UsdZipFile_end(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdZipFile_cend")]
		public static extern IntPtr UsdZipFile_cend(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdZipFile_Find")]
		public static extern IntPtr UsdZipFile_Find(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdZipFile_DumpContents")]
		public static extern void UsdZipFile_DumpContents(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdZipFile_GetFileNames")]
		public static extern IntPtr UsdZipFile_GetFileNames(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdZipFile_GetFile")]
		public static extern IntPtr UsdZipFile_GetFile(HandleRef jarg1, string jarg2, out int jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdZipFile_GetFileInfo")]
		public static extern IntPtr UsdZipFile_GetFileInfo(HandleRef jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdProperty_SWIGUpcast")]
		public static extern IntPtr UsdProperty_SWIGUpcast(IntPtr jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAttribute_SWIGUpcast")]
		public static extern IntPtr UsdAttribute_SWIGUpcast(IntPtr jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdPrim_SWIGUpcast")]
		public static extern IntPtr UsdPrim_SWIGUpcast(IntPtr jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_Usd_PrimFlagsConjunction_SWIGUpcast")]
		public static extern IntPtr Usd_PrimFlagsConjunction_SWIGUpcast(IntPtr jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_Usd_PrimFlagsDisjunction_SWIGUpcast")]
		public static extern IntPtr Usd_PrimFlagsDisjunction_SWIGUpcast(IntPtr jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdRelationship_SWIGUpcast")]
		public static extern IntPtr UsdRelationship_SWIGUpcast(IntPtr jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdAPISchemaBase_SWIGUpcast")]
		public static extern IntPtr UsdAPISchemaBase_SWIGUpcast(IntPtr jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdClipsAPI_SWIGUpcast")]
		public static extern IntPtr UsdClipsAPI_SWIGUpcast(IntPtr jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdCollectionAPI_SWIGUpcast")]
		public static extern IntPtr UsdCollectionAPI_SWIGUpcast(IntPtr jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdModelAPI_SWIGUpcast")]
		public static extern IntPtr UsdModelAPI_SWIGUpcast(IntPtr jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdTyped_SWIGUpcast")]
		public static extern IntPtr UsdTyped_SWIGUpcast(IntPtr jarg1);
	}
}
