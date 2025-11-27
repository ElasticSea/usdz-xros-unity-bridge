using System;
using System.Runtime.InteropServices;

namespace pxr
{
	internal class VtPINVOKE
	{
		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			[DllImport("UsdCs")]
			public static extern void SWIGRegisterStringCallback_Vt(SWIGStringDelegate stringDelegate);

			[MonoPInvokeCallback]
			private static string CreateString(string cString)
			{
				return cString;
			}

			static SWIGStringHelper()
			{
				stringDelegate = CreateString;
				SWIGRegisterStringCallback_Vt(stringDelegate);
			}
		}

		public class SWIGPendingException : UsdCsPINVOKE.SWIGPendingException
		{
		}

		protected static SWIGStringHelper swigStringHelper;

		static VtPINVOKE()
		{
			swigStringHelper = new SWIGStringHelper();
		}

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_Vt_ArrayForeignDataSource__SWIG_0")]
		public static extern IntPtr new_Vt_ArrayForeignDataSource__SWIG_0(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_Vt_ArrayForeignDataSource__SWIG_1")]
		public static extern IntPtr new_Vt_ArrayForeignDataSource__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_Vt_ArrayForeignDataSource__SWIG_2")]
		public static extern IntPtr new_Vt_ArrayForeignDataSource__SWIG_2();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_Vt_ArrayForeignDataSource")]
		public static extern void delete_Vt_ArrayForeignDataSource(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_Vt_ArrayBase__SWIG_0")]
		public static extern IntPtr new_Vt_ArrayBase__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_Vt_ArrayBase__SWIG_1")]
		public static extern IntPtr new_Vt_ArrayBase__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_Vt_ArrayBase__SWIG_2")]
		public static extern IntPtr new_Vt_ArrayBase__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_Vt_ArrayBase")]
		public static extern void delete_Vt_ArrayBase(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtDictionary__SWIG_0")]
		public static extern IntPtr new_VtDictionary__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtDictionary__SWIG_1")]
		public static extern IntPtr new_VtDictionary__SWIG_1(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtDictionary__SWIG_3")]
		public static extern IntPtr new_VtDictionary__SWIG_3(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDictionary_count__SWIG_0")]
		public static extern IntPtr VtDictionary_count__SWIG_0(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDictionary_erase__SWIG_0")]
		public static extern IntPtr VtDictionary_erase__SWIG_0(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDictionary_erase__SWIG_1")]
		public static extern void VtDictionary_erase__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDictionary_erase__SWIG_2")]
		public static extern void VtDictionary_erase__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDictionary_clear")]
		public static extern void VtDictionary_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDictionary_find__SWIG_0")]
		public static extern IntPtr VtDictionary_find__SWIG_0(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDictionary_begin__SWIG_0")]
		public static extern IntPtr VtDictionary_begin__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDictionary_end__SWIG_0")]
		public static extern IntPtr VtDictionary_end__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDictionary_size")]
		public static extern IntPtr VtDictionary_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDictionary_empty")]
		public static extern bool VtDictionary_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDictionary_swap")]
		public static extern void VtDictionary_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDictionary_insert")]
		public static extern IntPtr VtDictionary_insert(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDictionary_GetValueAtPath__SWIG_0")]
		public static extern IntPtr VtDictionary_GetValueAtPath__SWIG_0(HandleRef jarg1, string jarg2, string jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDictionary_GetValueAtPath__SWIG_1")]
		public static extern IntPtr VtDictionary_GetValueAtPath__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDictionary_GetValueAtPath__SWIG_2")]
		public static extern IntPtr VtDictionary_GetValueAtPath__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDictionary_SetValueAtPath__SWIG_0")]
		public static extern void VtDictionary_SetValueAtPath__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3, string jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDictionary_SetValueAtPath__SWIG_1")]
		public static extern void VtDictionary_SetValueAtPath__SWIG_1(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDictionary_SetValueAtPath__SWIG_2")]
		public static extern void VtDictionary_SetValueAtPath__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDictionary_EraseValueAtPath__SWIG_0")]
		public static extern void VtDictionary_EraseValueAtPath__SWIG_0(HandleRef jarg1, string jarg2, string jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDictionary_EraseValueAtPath__SWIG_1")]
		public static extern void VtDictionary_EraseValueAtPath__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDictionary_EraseValueAtPath__SWIG_2")]
		public static extern void VtDictionary_EraseValueAtPath__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtDictionary")]
		public static extern void delete_VtDictionary(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtGetEmptyDictionary")]
		public static extern IntPtr VtGetEmptyDictionary();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDictionaryOver__SWIG_0")]
		public static extern IntPtr VtDictionaryOver__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDictionaryOver__SWIG_1")]
		public static extern IntPtr VtDictionaryOver__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDictionaryOverRecursive__SWIG_0")]
		public static extern IntPtr VtDictionaryOverRecursive__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDictionaryOverRecursive__SWIG_1")]
		public static extern IntPtr VtDictionaryOverRecursive__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtDictionaryHash")]
		public static extern IntPtr new_VtDictionaryHash();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtDictionaryHash")]
		public static extern void delete_VtDictionaryHash(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_0")]
		public static extern IntPtr new_VtValue__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_1")]
		public static extern IntPtr new_VtValue__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtValue")]
		public static extern void delete_VtValue(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValue_Swap")]
		public static extern IntPtr VtValue_Swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValue_UncheckedSwap")]
		public static extern void VtValue_UncheckedSwap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValue_IsArrayValued")]
		public static extern bool VtValue_IsArrayValued(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValue_GetArraySize")]
		public static extern uint VtValue_GetArraySize(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValue_GetTfType")]
		public static extern IntPtr VtValue_GetTfType(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValue_GetTypeName")]
		public static extern string VtValue_GetTypeName(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValue_GetKnownValueTypeIndex")]
		public static extern int VtValue_GetKnownValueTypeIndex(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValue_CastToTypeOf__SWIG_0")]
		public static extern IntPtr VtValue_CastToTypeOf__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValue_CanCastToTypeOf")]
		public static extern bool VtValue_CanCastToTypeOf(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValue_IsEmpty")]
		public static extern bool VtValue_IsEmpty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValue_CanHash")]
		public static extern bool VtValue_CanHash(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValue_GetHash")]
		public static extern uint VtValue_GetHash(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValue_Equals")]
		public static extern bool VtValue_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValue_GetHashCode")]
		public static extern int VtValue_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_4")]
		public static extern IntPtr new_VtValue__SWIG_4(double jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_5")]
		public static extern IntPtr new_VtValue__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_6")]
		public static extern IntPtr new_VtValue__SWIG_6(float jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_7")]
		public static extern IntPtr new_VtValue__SWIG_7(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_8")]
		public static extern IntPtr new_VtValue__SWIG_8(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_9")]
		public static extern IntPtr new_VtValue__SWIG_9(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_10")]
		public static extern IntPtr new_VtValue__SWIG_10(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_11")]
		public static extern IntPtr new_VtValue__SWIG_11(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_12")]
		public static extern IntPtr new_VtValue__SWIG_12(char jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_13")]
		public static extern IntPtr new_VtValue__SWIG_13(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_14")]
		public static extern IntPtr new_VtValue__SWIG_14(byte jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_15")]
		public static extern IntPtr new_VtValue__SWIG_15(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_16")]
		public static extern IntPtr new_VtValue__SWIG_16(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_17")]
		public static extern IntPtr new_VtValue__SWIG_17(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_18")]
		public static extern IntPtr new_VtValue__SWIG_18(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_19")]
		public static extern IntPtr new_VtValue__SWIG_19(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_20")]
		public static extern IntPtr new_VtValue__SWIG_20(long jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_21")]
		public static extern IntPtr new_VtValue__SWIG_21(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_22")]
		public static extern IntPtr new_VtValue__SWIG_22(ulong jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_23")]
		public static extern IntPtr new_VtValue__SWIG_23(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_24")]
		public static extern IntPtr new_VtValue__SWIG_24(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_25")]
		public static extern IntPtr new_VtValue__SWIG_25(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_26")]
		public static extern IntPtr new_VtValue__SWIG_26(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_27")]
		public static extern IntPtr new_VtValue__SWIG_27(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_28")]
		public static extern IntPtr new_VtValue__SWIG_28(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_29")]
		public static extern IntPtr new_VtValue__SWIG_29(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_30")]
		public static extern IntPtr new_VtValue__SWIG_30(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_31")]
		public static extern IntPtr new_VtValue__SWIG_31(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_32")]
		public static extern IntPtr new_VtValue__SWIG_32(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_33")]
		public static extern IntPtr new_VtValue__SWIG_33(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_34")]
		public static extern IntPtr new_VtValue__SWIG_34(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_35")]
		public static extern IntPtr new_VtValue__SWIG_35(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_36")]
		public static extern IntPtr new_VtValue__SWIG_36(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_37")]
		public static extern IntPtr new_VtValue__SWIG_37(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_38")]
		public static extern IntPtr new_VtValue__SWIG_38(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_39")]
		public static extern IntPtr new_VtValue__SWIG_39(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_40")]
		public static extern IntPtr new_VtValue__SWIG_40(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_41")]
		public static extern IntPtr new_VtValue__SWIG_41(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_42")]
		public static extern IntPtr new_VtValue__SWIG_42(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_43")]
		public static extern IntPtr new_VtValue__SWIG_43(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_44")]
		public static extern IntPtr new_VtValue__SWIG_44(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_45")]
		public static extern IntPtr new_VtValue__SWIG_45(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_46")]
		public static extern IntPtr new_VtValue__SWIG_46(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_47")]
		public static extern IntPtr new_VtValue__SWIG_47(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_48")]
		public static extern IntPtr new_VtValue__SWIG_48(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_49")]
		public static extern IntPtr new_VtValue__SWIG_49(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_50")]
		public static extern IntPtr new_VtValue__SWIG_50(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_51")]
		public static extern IntPtr new_VtValue__SWIG_51(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_52")]
		public static extern IntPtr new_VtValue__SWIG_52(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_53")]
		public static extern IntPtr new_VtValue__SWIG_53(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_54")]
		public static extern IntPtr new_VtValue__SWIG_54(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_55")]
		public static extern IntPtr new_VtValue__SWIG_55(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_56")]
		public static extern IntPtr new_VtValue__SWIG_56(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_57")]
		public static extern IntPtr new_VtValue__SWIG_57(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_58")]
		public static extern IntPtr new_VtValue__SWIG_58(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_59")]
		public static extern IntPtr new_VtValue__SWIG_59(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_60")]
		public static extern IntPtr new_VtValue__SWIG_60(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_61")]
		public static extern IntPtr new_VtValue__SWIG_61(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_62")]
		public static extern IntPtr new_VtValue__SWIG_62(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_63")]
		public static extern IntPtr new_VtValue__SWIG_63(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_64")]
		public static extern IntPtr new_VtValue__SWIG_64(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_65")]
		public static extern IntPtr new_VtValue__SWIG_65(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_66")]
		public static extern IntPtr new_VtValue__SWIG_66(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_67")]
		public static extern IntPtr new_VtValue__SWIG_67(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_68")]
		public static extern IntPtr new_VtValue__SWIG_68(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_69")]
		public static extern IntPtr new_VtValue__SWIG_69(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_70")]
		public static extern IntPtr new_VtValue__SWIG_70(string jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_71")]
		public static extern IntPtr new_VtValue__SWIG_71(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_72")]
		public static extern IntPtr new_VtValue__SWIG_72(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_73")]
		public static extern IntPtr new_VtValue__SWIG_73(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_74")]
		public static extern IntPtr new_VtValue__SWIG_74(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_75")]
		public static extern IntPtr new_VtValue__SWIG_75(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_76")]
		public static extern IntPtr new_VtValue__SWIG_76(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_77")]
		public static extern IntPtr new_VtValue__SWIG_77(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_78")]
		public static extern IntPtr new_VtValue__SWIG_78(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_79")]
		public static extern IntPtr new_VtValue__SWIG_79(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_80")]
		public static extern IntPtr new_VtValue__SWIG_80(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_81")]
		public static extern IntPtr new_VtValue__SWIG_81(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_82")]
		public static extern IntPtr new_VtValue__SWIG_82(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_83")]
		public static extern IntPtr new_VtValue__SWIG_83(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_84")]
		public static extern IntPtr new_VtValue__SWIG_84(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_85")]
		public static extern IntPtr new_VtValue__SWIG_85(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_86")]
		public static extern IntPtr new_VtValue__SWIG_86(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_87")]
		public static extern IntPtr new_VtValue__SWIG_87(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_88")]
		public static extern IntPtr new_VtValue__SWIG_88(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_89")]
		public static extern IntPtr new_VtValue__SWIG_89(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtValue__SWIG_90")]
		public static extern IntPtr new_VtValue__SWIG_90(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueTodouble__SWIG_0")]
		public static extern double VtValueTodouble__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueTodouble__SWIG_1")]
		public static extern void VtValueTodouble__SWIG_1(HandleRef jarg1, out double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtDoubleArray__SWIG_0")]
		public static extern IntPtr new_VtDoubleArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtDoubleArray__SWIG_1")]
		public static extern IntPtr new_VtDoubleArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtDoubleArray__SWIG_3")]
		public static extern IntPtr new_VtDoubleArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtDoubleArray__SWIG_4")]
		public static extern IntPtr new_VtDoubleArray__SWIG_4(uint jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtDoubleArray")]
		public static extern void delete_VtDoubleArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDoubleArray_AsConst")]
		public static extern IntPtr VtDoubleArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDoubleArray_push_back")]
		public static extern void VtDoubleArray_push_back(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDoubleArray_pop_back")]
		public static extern void VtDoubleArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDoubleArray_size")]
		public static extern uint VtDoubleArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDoubleArray_capacity")]
		public static extern uint VtDoubleArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDoubleArray_empty")]
		public static extern bool VtDoubleArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDoubleArray_reserve")]
		public static extern void VtDoubleArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDoubleArray_resize")]
		public static extern void VtDoubleArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDoubleArray_clear")]
		public static extern void VtDoubleArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDoubleArray_assign")]
		public static extern void VtDoubleArray_assign(HandleRef jarg1, uint jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDoubleArray_swap")]
		public static extern void VtDoubleArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDoubleArray_IsIdentical")]
		public static extern bool VtDoubleArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDoubleArray_ToString")]
		public static extern string VtDoubleArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDoubleArray_CopyToArray__SWIG_0")]
		public static extern void VtDoubleArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] double[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDoubleArray_CopyFromArray__SWIG_0")]
		public static extern void VtDoubleArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] double[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDoubleArray_CopyToArray__SWIG_1")]
		public static extern void VtDoubleArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDoubleArray_CopyFromArray__SWIG_1")]
		public static extern void VtDoubleArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDoubleArray_GetValue")]
		public static extern double VtDoubleArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDoubleArray_SetValue")]
		public static extern void VtDoubleArray_SetValue(HandleRef jarg1, int jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDoubleArray_Equals")]
		public static extern bool VtDoubleArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDoubleArray_GetHashCode")]
		public static extern int VtDoubleArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtDoubleArray__SWIG_0")]
		public static extern IntPtr VtValueToVtDoubleArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtDoubleArray__SWIG_1")]
		public static extern void VtValueToVtDoubleArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueTofloat__SWIG_0")]
		public static extern float VtValueTofloat__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueTofloat__SWIG_1")]
		public static extern void VtValueTofloat__SWIG_1(HandleRef jarg1, out float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtFloatArray__SWIG_0")]
		public static extern IntPtr new_VtFloatArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtFloatArray__SWIG_1")]
		public static extern IntPtr new_VtFloatArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtFloatArray__SWIG_3")]
		public static extern IntPtr new_VtFloatArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtFloatArray__SWIG_4")]
		public static extern IntPtr new_VtFloatArray__SWIG_4(uint jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtFloatArray")]
		public static extern void delete_VtFloatArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtFloatArray_AsConst")]
		public static extern IntPtr VtFloatArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtFloatArray_push_back")]
		public static extern void VtFloatArray_push_back(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtFloatArray_pop_back")]
		public static extern void VtFloatArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtFloatArray_size")]
		public static extern uint VtFloatArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtFloatArray_capacity")]
		public static extern uint VtFloatArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtFloatArray_empty")]
		public static extern bool VtFloatArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtFloatArray_reserve")]
		public static extern void VtFloatArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtFloatArray_resize")]
		public static extern void VtFloatArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtFloatArray_clear")]
		public static extern void VtFloatArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtFloatArray_assign")]
		public static extern void VtFloatArray_assign(HandleRef jarg1, uint jarg2, float jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtFloatArray_swap")]
		public static extern void VtFloatArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtFloatArray_IsIdentical")]
		public static extern bool VtFloatArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtFloatArray_ToString")]
		public static extern string VtFloatArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtFloatArray_CopyToArray__SWIG_0")]
		public static extern void VtFloatArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] float[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtFloatArray_CopyFromArray__SWIG_0")]
		public static extern void VtFloatArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] float[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtFloatArray_CopyToArray__SWIG_1")]
		public static extern void VtFloatArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtFloatArray_CopyFromArray__SWIG_1")]
		public static extern void VtFloatArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtFloatArray_GetValue")]
		public static extern float VtFloatArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtFloatArray_SetValue")]
		public static extern void VtFloatArray_SetValue(HandleRef jarg1, int jarg2, float jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtFloatArray_Equals")]
		public static extern bool VtFloatArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtFloatArray_GetHashCode")]
		public static extern int VtFloatArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtFloatArray__SWIG_0")]
		public static extern IntPtr VtValueToVtFloatArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtFloatArray__SWIG_1")]
		public static extern void VtValueToVtFloatArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfHalf__SWIG_0")]
		public static extern IntPtr VtValueToGfHalf__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfHalf__SWIG_1")]
		public static extern void VtValueToGfHalf__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtHalfArray__SWIG_0")]
		public static extern IntPtr new_VtHalfArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtHalfArray__SWIG_1")]
		public static extern IntPtr new_VtHalfArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtHalfArray__SWIG_3")]
		public static extern IntPtr new_VtHalfArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtHalfArray__SWIG_4")]
		public static extern IntPtr new_VtHalfArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtHalfArray")]
		public static extern void delete_VtHalfArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtHalfArray_AsConst")]
		public static extern IntPtr VtHalfArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtHalfArray_push_back")]
		public static extern void VtHalfArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtHalfArray_pop_back")]
		public static extern void VtHalfArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtHalfArray_size")]
		public static extern uint VtHalfArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtHalfArray_capacity")]
		public static extern uint VtHalfArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtHalfArray_empty")]
		public static extern bool VtHalfArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtHalfArray_reserve")]
		public static extern void VtHalfArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtHalfArray_resize")]
		public static extern void VtHalfArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtHalfArray_clear")]
		public static extern void VtHalfArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtHalfArray_assign")]
		public static extern void VtHalfArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtHalfArray_swap")]
		public static extern void VtHalfArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtHalfArray_IsIdentical")]
		public static extern bool VtHalfArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtHalfArray_ToString")]
		public static extern string VtHalfArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtHalfArray_CopyToArray__SWIG_0")]
		public static extern void VtHalfArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfHalf[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtHalfArray_CopyFromArray__SWIG_0")]
		public static extern void VtHalfArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfHalf[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtHalfArray_CopyToArray__SWIG_1")]
		public static extern void VtHalfArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtHalfArray_CopyFromArray__SWIG_1")]
		public static extern void VtHalfArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtHalfArray_GetValue")]
		public static extern IntPtr VtHalfArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtHalfArray_SetValue")]
		public static extern void VtHalfArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtHalfArray_Equals")]
		public static extern bool VtHalfArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtHalfArray_GetHashCode")]
		public static extern int VtHalfArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtHalfArray__SWIG_0")]
		public static extern IntPtr VtValueToVtHalfArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtHalfArray__SWIG_1")]
		public static extern void VtValueToVtHalfArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueTobool__SWIG_0")]
		public static extern bool VtValueTobool__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueTobool__SWIG_1")]
		public static extern void VtValueTobool__SWIG_1(HandleRef jarg1, out bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtBoolArray__SWIG_0")]
		public static extern IntPtr new_VtBoolArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtBoolArray__SWIG_1")]
		public static extern IntPtr new_VtBoolArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtBoolArray__SWIG_3")]
		public static extern IntPtr new_VtBoolArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtBoolArray__SWIG_4")]
		public static extern IntPtr new_VtBoolArray__SWIG_4(uint jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtBoolArray")]
		public static extern void delete_VtBoolArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtBoolArray_AsConst")]
		public static extern IntPtr VtBoolArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtBoolArray_push_back")]
		public static extern void VtBoolArray_push_back(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtBoolArray_pop_back")]
		public static extern void VtBoolArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtBoolArray_size")]
		public static extern uint VtBoolArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtBoolArray_capacity")]
		public static extern uint VtBoolArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtBoolArray_empty")]
		public static extern bool VtBoolArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtBoolArray_reserve")]
		public static extern void VtBoolArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtBoolArray_resize")]
		public static extern void VtBoolArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtBoolArray_clear")]
		public static extern void VtBoolArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtBoolArray_assign")]
		public static extern void VtBoolArray_assign(HandleRef jarg1, uint jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtBoolArray_swap")]
		public static extern void VtBoolArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtBoolArray_IsIdentical")]
		public static extern bool VtBoolArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtBoolArray_ToString")]
		public static extern string VtBoolArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtBoolArray_CopyToArray__SWIG_0")]
		public static extern void VtBoolArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] bool[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtBoolArray_CopyFromArray__SWIG_0")]
		public static extern void VtBoolArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] bool[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtBoolArray_CopyToArray__SWIG_1")]
		public static extern void VtBoolArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtBoolArray_CopyFromArray__SWIG_1")]
		public static extern void VtBoolArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtBoolArray_GetValue")]
		public static extern bool VtBoolArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtBoolArray_SetValue")]
		public static extern void VtBoolArray_SetValue(HandleRef jarg1, int jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtBoolArray_Equals")]
		public static extern bool VtBoolArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtBoolArray_GetHashCode")]
		public static extern int VtBoolArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtBoolArray__SWIG_0")]
		public static extern IntPtr VtValueToVtBoolArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtBoolArray__SWIG_1")]
		public static extern void VtValueToVtBoolArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueTochar__SWIG_0")]
		public static extern char VtValueTochar__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueTochar__SWIG_1")]
		public static extern void VtValueTochar__SWIG_1(HandleRef jarg1, out char jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtCharArray__SWIG_0")]
		public static extern IntPtr new_VtCharArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtCharArray__SWIG_1")]
		public static extern IntPtr new_VtCharArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtCharArray__SWIG_3")]
		public static extern IntPtr new_VtCharArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtCharArray__SWIG_4")]
		public static extern IntPtr new_VtCharArray__SWIG_4(uint jarg1, char jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtCharArray")]
		public static extern void delete_VtCharArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtCharArray_AsConst")]
		public static extern IntPtr VtCharArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtCharArray_push_back")]
		public static extern void VtCharArray_push_back(HandleRef jarg1, char jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtCharArray_pop_back")]
		public static extern void VtCharArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtCharArray_size")]
		public static extern uint VtCharArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtCharArray_capacity")]
		public static extern uint VtCharArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtCharArray_empty")]
		public static extern bool VtCharArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtCharArray_reserve")]
		public static extern void VtCharArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtCharArray_resize")]
		public static extern void VtCharArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtCharArray_clear")]
		public static extern void VtCharArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtCharArray_assign")]
		public static extern void VtCharArray_assign(HandleRef jarg1, uint jarg2, char jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtCharArray_swap")]
		public static extern void VtCharArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtCharArray_IsIdentical")]
		public static extern bool VtCharArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtCharArray_ToString")]
		public static extern string VtCharArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtCharArray_CopyToArray__SWIG_0")]
		public static extern void VtCharArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] char[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtCharArray_CopyFromArray__SWIG_0")]
		public static extern void VtCharArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] char[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtCharArray_CopyToArray__SWIG_1")]
		public static extern void VtCharArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtCharArray_CopyFromArray__SWIG_1")]
		public static extern void VtCharArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtCharArray_GetValue")]
		public static extern char VtCharArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtCharArray_SetValue")]
		public static extern void VtCharArray_SetValue(HandleRef jarg1, int jarg2, char jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtCharArray_Equals")]
		public static extern bool VtCharArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtCharArray_GetHashCode")]
		public static extern int VtCharArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtCharArray__SWIG_0")]
		public static extern IntPtr VtValueToVtCharArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtCharArray__SWIG_1")]
		public static extern void VtValueToVtCharArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueTobyte__SWIG_0")]
		public static extern byte VtValueTobyte__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueTobyte__SWIG_1")]
		public static extern void VtValueTobyte__SWIG_1(HandleRef jarg1, out byte jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtUCharArray__SWIG_0")]
		public static extern IntPtr new_VtUCharArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtUCharArray__SWIG_1")]
		public static extern IntPtr new_VtUCharArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtUCharArray__SWIG_3")]
		public static extern IntPtr new_VtUCharArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtUCharArray__SWIG_4")]
		public static extern IntPtr new_VtUCharArray__SWIG_4(uint jarg1, byte jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtUCharArray")]
		public static extern void delete_VtUCharArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUCharArray_AsConst")]
		public static extern IntPtr VtUCharArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUCharArray_push_back")]
		public static extern void VtUCharArray_push_back(HandleRef jarg1, byte jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUCharArray_pop_back")]
		public static extern void VtUCharArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUCharArray_size")]
		public static extern uint VtUCharArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUCharArray_capacity")]
		public static extern uint VtUCharArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUCharArray_empty")]
		public static extern bool VtUCharArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUCharArray_reserve")]
		public static extern void VtUCharArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUCharArray_resize")]
		public static extern void VtUCharArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUCharArray_clear")]
		public static extern void VtUCharArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUCharArray_assign")]
		public static extern void VtUCharArray_assign(HandleRef jarg1, uint jarg2, byte jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUCharArray_swap")]
		public static extern void VtUCharArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUCharArray_IsIdentical")]
		public static extern bool VtUCharArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUCharArray_ToString")]
		public static extern string VtUCharArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUCharArray_CopyToArray__SWIG_0")]
		public static extern void VtUCharArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] byte[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUCharArray_CopyFromArray__SWIG_0")]
		public static extern void VtUCharArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] byte[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUCharArray_CopyToArray__SWIG_1")]
		public static extern void VtUCharArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUCharArray_CopyFromArray__SWIG_1")]
		public static extern void VtUCharArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUCharArray_GetValue")]
		public static extern byte VtUCharArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUCharArray_SetValue")]
		public static extern void VtUCharArray_SetValue(HandleRef jarg1, int jarg2, byte jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUCharArray_Equals")]
		public static extern bool VtUCharArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUCharArray_GetHashCode")]
		public static extern int VtUCharArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtUCharArray__SWIG_0")]
		public static extern IntPtr VtValueToVtUCharArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtUCharArray__SWIG_1")]
		public static extern void VtValueToVtUCharArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToint__SWIG_0")]
		public static extern int VtValueToint__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToint__SWIG_1")]
		public static extern void VtValueToint__SWIG_1(HandleRef jarg1, out int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtIntArray__SWIG_0")]
		public static extern IntPtr new_VtIntArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtIntArray__SWIG_1")]
		public static extern IntPtr new_VtIntArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtIntArray__SWIG_3")]
		public static extern IntPtr new_VtIntArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtIntArray__SWIG_4")]
		public static extern IntPtr new_VtIntArray__SWIG_4(uint jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtIntArray")]
		public static extern void delete_VtIntArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntArray_AsConst")]
		public static extern IntPtr VtIntArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntArray_push_back")]
		public static extern void VtIntArray_push_back(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntArray_pop_back")]
		public static extern void VtIntArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntArray_size")]
		public static extern uint VtIntArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntArray_capacity")]
		public static extern uint VtIntArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntArray_empty")]
		public static extern bool VtIntArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntArray_reserve")]
		public static extern void VtIntArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntArray_resize")]
		public static extern void VtIntArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntArray_clear")]
		public static extern void VtIntArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntArray_assign")]
		public static extern void VtIntArray_assign(HandleRef jarg1, uint jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntArray_swap")]
		public static extern void VtIntArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntArray_IsIdentical")]
		public static extern bool VtIntArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntArray_ToString")]
		public static extern string VtIntArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntArray_CopyToArray__SWIG_0")]
		public static extern void VtIntArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] int[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntArray_CopyFromArray__SWIG_0")]
		public static extern void VtIntArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] int[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntArray_CopyToArray__SWIG_1")]
		public static extern void VtIntArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntArray_CopyFromArray__SWIG_1")]
		public static extern void VtIntArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntArray_GetValue")]
		public static extern int VtIntArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntArray_SetValue")]
		public static extern void VtIntArray_SetValue(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntArray_Equals")]
		public static extern bool VtIntArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntArray_GetHashCode")]
		public static extern int VtIntArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtIntArray__SWIG_0")]
		public static extern IntPtr VtValueToVtIntArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtIntArray__SWIG_1")]
		public static extern void VtValueToVtIntArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueTouint__SWIG_0")]
		public static extern uint VtValueTouint__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueTouint__SWIG_1")]
		public static extern void VtValueTouint__SWIG_1(HandleRef jarg1, out uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtUIntArray__SWIG_0")]
		public static extern IntPtr new_VtUIntArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtUIntArray__SWIG_1")]
		public static extern IntPtr new_VtUIntArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtUIntArray__SWIG_3")]
		public static extern IntPtr new_VtUIntArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtUIntArray__SWIG_4")]
		public static extern IntPtr new_VtUIntArray__SWIG_4(uint jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtUIntArray")]
		public static extern void delete_VtUIntArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUIntArray_AsConst")]
		public static extern IntPtr VtUIntArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUIntArray_push_back")]
		public static extern void VtUIntArray_push_back(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUIntArray_pop_back")]
		public static extern void VtUIntArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUIntArray_size")]
		public static extern uint VtUIntArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUIntArray_capacity")]
		public static extern uint VtUIntArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUIntArray_empty")]
		public static extern bool VtUIntArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUIntArray_reserve")]
		public static extern void VtUIntArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUIntArray_resize")]
		public static extern void VtUIntArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUIntArray_clear")]
		public static extern void VtUIntArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUIntArray_assign")]
		public static extern void VtUIntArray_assign(HandleRef jarg1, uint jarg2, uint jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUIntArray_swap")]
		public static extern void VtUIntArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUIntArray_IsIdentical")]
		public static extern bool VtUIntArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUIntArray_ToString")]
		public static extern string VtUIntArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUIntArray_CopyToArray__SWIG_0")]
		public static extern void VtUIntArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] uint[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUIntArray_CopyFromArray__SWIG_0")]
		public static extern void VtUIntArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] uint[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUIntArray_CopyToArray__SWIG_1")]
		public static extern void VtUIntArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUIntArray_CopyFromArray__SWIG_1")]
		public static extern void VtUIntArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUIntArray_GetValue")]
		public static extern uint VtUIntArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUIntArray_SetValue")]
		public static extern void VtUIntArray_SetValue(HandleRef jarg1, int jarg2, uint jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUIntArray_Equals")]
		public static extern bool VtUIntArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUIntArray_GetHashCode")]
		public static extern int VtUIntArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtUIntArray__SWIG_0")]
		public static extern IntPtr VtValueToVtUIntArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtUIntArray__SWIG_1")]
		public static extern void VtValueToVtUIntArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueTolong__SWIG_0")]
		public static extern long VtValueTolong__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueTolong__SWIG_1")]
		public static extern void VtValueTolong__SWIG_1(HandleRef jarg1, out long jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtInt64Array__SWIG_0")]
		public static extern IntPtr new_VtInt64Array__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtInt64Array__SWIG_1")]
		public static extern IntPtr new_VtInt64Array__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtInt64Array__SWIG_3")]
		public static extern IntPtr new_VtInt64Array__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtInt64Array__SWIG_4")]
		public static extern IntPtr new_VtInt64Array__SWIG_4(uint jarg1, long jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtInt64Array")]
		public static extern void delete_VtInt64Array(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtInt64Array_AsConst")]
		public static extern IntPtr VtInt64Array_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtInt64Array_push_back")]
		public static extern void VtInt64Array_push_back(HandleRef jarg1, long jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtInt64Array_pop_back")]
		public static extern void VtInt64Array_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtInt64Array_size")]
		public static extern uint VtInt64Array_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtInt64Array_capacity")]
		public static extern uint VtInt64Array_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtInt64Array_empty")]
		public static extern bool VtInt64Array_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtInt64Array_reserve")]
		public static extern void VtInt64Array_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtInt64Array_resize")]
		public static extern void VtInt64Array_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtInt64Array_clear")]
		public static extern void VtInt64Array_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtInt64Array_assign")]
		public static extern void VtInt64Array_assign(HandleRef jarg1, uint jarg2, long jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtInt64Array_swap")]
		public static extern void VtInt64Array_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtInt64Array_IsIdentical")]
		public static extern bool VtInt64Array_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtInt64Array_ToString")]
		public static extern string VtInt64Array_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtInt64Array_CopyToArray__SWIG_0")]
		public static extern void VtInt64Array_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] long[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtInt64Array_CopyFromArray__SWIG_0")]
		public static extern void VtInt64Array_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] long[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtInt64Array_CopyToArray__SWIG_1")]
		public static extern void VtInt64Array_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtInt64Array_CopyFromArray__SWIG_1")]
		public static extern void VtInt64Array_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtInt64Array_GetValue")]
		public static extern long VtInt64Array_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtInt64Array_SetValue")]
		public static extern void VtInt64Array_SetValue(HandleRef jarg1, int jarg2, long jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtInt64Array_Equals")]
		public static extern bool VtInt64Array_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtInt64Array_GetHashCode")]
		public static extern int VtInt64Array_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtInt64Array__SWIG_0")]
		public static extern IntPtr VtValueToVtInt64Array__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtInt64Array__SWIG_1")]
		public static extern void VtValueToVtInt64Array__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToulong__SWIG_0")]
		public static extern ulong VtValueToulong__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToulong__SWIG_1")]
		public static extern void VtValueToulong__SWIG_1(HandleRef jarg1, out ulong jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtUInt64Array__SWIG_0")]
		public static extern IntPtr new_VtUInt64Array__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtUInt64Array__SWIG_1")]
		public static extern IntPtr new_VtUInt64Array__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtUInt64Array__SWIG_3")]
		public static extern IntPtr new_VtUInt64Array__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtUInt64Array__SWIG_4")]
		public static extern IntPtr new_VtUInt64Array__SWIG_4(uint jarg1, ulong jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtUInt64Array")]
		public static extern void delete_VtUInt64Array(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUInt64Array_AsConst")]
		public static extern IntPtr VtUInt64Array_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUInt64Array_push_back")]
		public static extern void VtUInt64Array_push_back(HandleRef jarg1, ulong jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUInt64Array_pop_back")]
		public static extern void VtUInt64Array_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUInt64Array_size")]
		public static extern uint VtUInt64Array_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUInt64Array_capacity")]
		public static extern uint VtUInt64Array_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUInt64Array_empty")]
		public static extern bool VtUInt64Array_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUInt64Array_reserve")]
		public static extern void VtUInt64Array_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUInt64Array_resize")]
		public static extern void VtUInt64Array_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUInt64Array_clear")]
		public static extern void VtUInt64Array_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUInt64Array_assign")]
		public static extern void VtUInt64Array_assign(HandleRef jarg1, uint jarg2, ulong jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUInt64Array_swap")]
		public static extern void VtUInt64Array_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUInt64Array_IsIdentical")]
		public static extern bool VtUInt64Array_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUInt64Array_ToString")]
		public static extern string VtUInt64Array_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUInt64Array_CopyToArray__SWIG_0")]
		public static extern void VtUInt64Array_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] ulong[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUInt64Array_CopyFromArray__SWIG_0")]
		public static extern void VtUInt64Array_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] ulong[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUInt64Array_CopyToArray__SWIG_1")]
		public static extern void VtUInt64Array_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUInt64Array_CopyFromArray__SWIG_1")]
		public static extern void VtUInt64Array_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUInt64Array_GetValue")]
		public static extern ulong VtUInt64Array_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUInt64Array_SetValue")]
		public static extern void VtUInt64Array_SetValue(HandleRef jarg1, int jarg2, ulong jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUInt64Array_Equals")]
		public static extern bool VtUInt64Array_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUInt64Array_GetHashCode")]
		public static extern int VtUInt64Array_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtUInt64Array__SWIG_0")]
		public static extern IntPtr VtValueToVtUInt64Array__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtUInt64Array__SWIG_1")]
		public static extern void VtValueToVtUInt64Array__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfVec4i__SWIG_0")]
		public static extern IntPtr VtValueToGfVec4i__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfVec4i__SWIG_1")]
		public static extern void VtValueToGfVec4i__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec4iArray__SWIG_0")]
		public static extern IntPtr new_VtVec4iArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec4iArray__SWIG_1")]
		public static extern IntPtr new_VtVec4iArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec4iArray__SWIG_3")]
		public static extern IntPtr new_VtVec4iArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec4iArray__SWIG_4")]
		public static extern IntPtr new_VtVec4iArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtVec4iArray")]
		public static extern void delete_VtVec4iArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4iArray_AsConst")]
		public static extern IntPtr VtVec4iArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4iArray_push_back")]
		public static extern void VtVec4iArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4iArray_pop_back")]
		public static extern void VtVec4iArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4iArray_size")]
		public static extern uint VtVec4iArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4iArray_capacity")]
		public static extern uint VtVec4iArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4iArray_empty")]
		public static extern bool VtVec4iArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4iArray_reserve")]
		public static extern void VtVec4iArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4iArray_resize")]
		public static extern void VtVec4iArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4iArray_clear")]
		public static extern void VtVec4iArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4iArray_assign")]
		public static extern void VtVec4iArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4iArray_swap")]
		public static extern void VtVec4iArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4iArray_IsIdentical")]
		public static extern bool VtVec4iArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4iArray_ToString")]
		public static extern string VtVec4iArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4iArray_CopyToArray__SWIG_0")]
		public static extern void VtVec4iArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfVec4i[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4iArray_CopyFromArray__SWIG_0")]
		public static extern void VtVec4iArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfVec4i[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4iArray_CopyToArray__SWIG_1")]
		public static extern void VtVec4iArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4iArray_CopyFromArray__SWIG_1")]
		public static extern void VtVec4iArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4iArray_GetValue")]
		public static extern IntPtr VtVec4iArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4iArray_SetValue")]
		public static extern void VtVec4iArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4iArray_Equals")]
		public static extern bool VtVec4iArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4iArray_GetHashCode")]
		public static extern int VtVec4iArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtVec4iArray__SWIG_0")]
		public static extern IntPtr VtValueToVtVec4iArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtVec4iArray__SWIG_1")]
		public static extern void VtValueToVtVec4iArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfVec3i__SWIG_0")]
		public static extern IntPtr VtValueToGfVec3i__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfVec3i__SWIG_1")]
		public static extern void VtValueToGfVec3i__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec3iArray__SWIG_0")]
		public static extern IntPtr new_VtVec3iArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec3iArray__SWIG_1")]
		public static extern IntPtr new_VtVec3iArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec3iArray__SWIG_3")]
		public static extern IntPtr new_VtVec3iArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec3iArray__SWIG_4")]
		public static extern IntPtr new_VtVec3iArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtVec3iArray")]
		public static extern void delete_VtVec3iArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3iArray_AsConst")]
		public static extern IntPtr VtVec3iArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3iArray_push_back")]
		public static extern void VtVec3iArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3iArray_pop_back")]
		public static extern void VtVec3iArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3iArray_size")]
		public static extern uint VtVec3iArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3iArray_capacity")]
		public static extern uint VtVec3iArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3iArray_empty")]
		public static extern bool VtVec3iArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3iArray_reserve")]
		public static extern void VtVec3iArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3iArray_resize")]
		public static extern void VtVec3iArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3iArray_clear")]
		public static extern void VtVec3iArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3iArray_assign")]
		public static extern void VtVec3iArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3iArray_swap")]
		public static extern void VtVec3iArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3iArray_IsIdentical")]
		public static extern bool VtVec3iArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3iArray_ToString")]
		public static extern string VtVec3iArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3iArray_CopyToArray__SWIG_0")]
		public static extern void VtVec3iArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfVec3i[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3iArray_CopyFromArray__SWIG_0")]
		public static extern void VtVec3iArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfVec3i[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3iArray_CopyToArray__SWIG_1")]
		public static extern void VtVec3iArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3iArray_CopyFromArray__SWIG_1")]
		public static extern void VtVec3iArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3iArray_GetValue")]
		public static extern IntPtr VtVec3iArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3iArray_SetValue")]
		public static extern void VtVec3iArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3iArray_Equals")]
		public static extern bool VtVec3iArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3iArray_GetHashCode")]
		public static extern int VtVec3iArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtVec3iArray__SWIG_0")]
		public static extern IntPtr VtValueToVtVec3iArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtVec3iArray__SWIG_1")]
		public static extern void VtValueToVtVec3iArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfVec2i__SWIG_0")]
		public static extern IntPtr VtValueToGfVec2i__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfVec2i__SWIG_1")]
		public static extern void VtValueToGfVec2i__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec2iArray__SWIG_0")]
		public static extern IntPtr new_VtVec2iArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec2iArray__SWIG_1")]
		public static extern IntPtr new_VtVec2iArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec2iArray__SWIG_3")]
		public static extern IntPtr new_VtVec2iArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec2iArray__SWIG_4")]
		public static extern IntPtr new_VtVec2iArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtVec2iArray")]
		public static extern void delete_VtVec2iArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2iArray_AsConst")]
		public static extern IntPtr VtVec2iArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2iArray_push_back")]
		public static extern void VtVec2iArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2iArray_pop_back")]
		public static extern void VtVec2iArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2iArray_size")]
		public static extern uint VtVec2iArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2iArray_capacity")]
		public static extern uint VtVec2iArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2iArray_empty")]
		public static extern bool VtVec2iArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2iArray_reserve")]
		public static extern void VtVec2iArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2iArray_resize")]
		public static extern void VtVec2iArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2iArray_clear")]
		public static extern void VtVec2iArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2iArray_assign")]
		public static extern void VtVec2iArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2iArray_swap")]
		public static extern void VtVec2iArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2iArray_IsIdentical")]
		public static extern bool VtVec2iArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2iArray_ToString")]
		public static extern string VtVec2iArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2iArray_CopyToArray__SWIG_0")]
		public static extern void VtVec2iArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfVec2i[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2iArray_CopyFromArray__SWIG_0")]
		public static extern void VtVec2iArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfVec2i[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2iArray_CopyToArray__SWIG_1")]
		public static extern void VtVec2iArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2iArray_CopyFromArray__SWIG_1")]
		public static extern void VtVec2iArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2iArray_GetValue")]
		public static extern IntPtr VtVec2iArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2iArray_SetValue")]
		public static extern void VtVec2iArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2iArray_Equals")]
		public static extern bool VtVec2iArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2iArray_GetHashCode")]
		public static extern int VtVec2iArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtVec2iArray__SWIG_0")]
		public static extern IntPtr VtValueToVtVec2iArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtVec2iArray__SWIG_1")]
		public static extern void VtValueToVtVec2iArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfVec4h__SWIG_0")]
		public static extern IntPtr VtValueToGfVec4h__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfVec4h__SWIG_1")]
		public static extern void VtValueToGfVec4h__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec4hArray__SWIG_0")]
		public static extern IntPtr new_VtVec4hArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec4hArray__SWIG_1")]
		public static extern IntPtr new_VtVec4hArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec4hArray__SWIG_3")]
		public static extern IntPtr new_VtVec4hArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec4hArray__SWIG_4")]
		public static extern IntPtr new_VtVec4hArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtVec4hArray")]
		public static extern void delete_VtVec4hArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4hArray_AsConst")]
		public static extern IntPtr VtVec4hArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4hArray_push_back")]
		public static extern void VtVec4hArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4hArray_pop_back")]
		public static extern void VtVec4hArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4hArray_size")]
		public static extern uint VtVec4hArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4hArray_capacity")]
		public static extern uint VtVec4hArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4hArray_empty")]
		public static extern bool VtVec4hArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4hArray_reserve")]
		public static extern void VtVec4hArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4hArray_resize")]
		public static extern void VtVec4hArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4hArray_clear")]
		public static extern void VtVec4hArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4hArray_assign")]
		public static extern void VtVec4hArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4hArray_swap")]
		public static extern void VtVec4hArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4hArray_IsIdentical")]
		public static extern bool VtVec4hArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4hArray_ToString")]
		public static extern string VtVec4hArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4hArray_CopyToArray__SWIG_0")]
		public static extern void VtVec4hArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfVec4h[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4hArray_CopyFromArray__SWIG_0")]
		public static extern void VtVec4hArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfVec4h[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4hArray_CopyToArray__SWIG_1")]
		public static extern void VtVec4hArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4hArray_CopyFromArray__SWIG_1")]
		public static extern void VtVec4hArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4hArray_GetValue")]
		public static extern IntPtr VtVec4hArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4hArray_SetValue")]
		public static extern void VtVec4hArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4hArray_Equals")]
		public static extern bool VtVec4hArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4hArray_GetHashCode")]
		public static extern int VtVec4hArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtVec4hArray__SWIG_0")]
		public static extern IntPtr VtValueToVtVec4hArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtVec4hArray__SWIG_1")]
		public static extern void VtValueToVtVec4hArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfVec3h__SWIG_0")]
		public static extern IntPtr VtValueToGfVec3h__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfVec3h__SWIG_1")]
		public static extern void VtValueToGfVec3h__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec3hArray__SWIG_0")]
		public static extern IntPtr new_VtVec3hArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec3hArray__SWIG_1")]
		public static extern IntPtr new_VtVec3hArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec3hArray__SWIG_3")]
		public static extern IntPtr new_VtVec3hArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec3hArray__SWIG_4")]
		public static extern IntPtr new_VtVec3hArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtVec3hArray")]
		public static extern void delete_VtVec3hArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3hArray_AsConst")]
		public static extern IntPtr VtVec3hArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3hArray_push_back")]
		public static extern void VtVec3hArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3hArray_pop_back")]
		public static extern void VtVec3hArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3hArray_size")]
		public static extern uint VtVec3hArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3hArray_capacity")]
		public static extern uint VtVec3hArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3hArray_empty")]
		public static extern bool VtVec3hArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3hArray_reserve")]
		public static extern void VtVec3hArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3hArray_resize")]
		public static extern void VtVec3hArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3hArray_clear")]
		public static extern void VtVec3hArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3hArray_assign")]
		public static extern void VtVec3hArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3hArray_swap")]
		public static extern void VtVec3hArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3hArray_IsIdentical")]
		public static extern bool VtVec3hArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3hArray_ToString")]
		public static extern string VtVec3hArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3hArray_CopyToArray__SWIG_0")]
		public static extern void VtVec3hArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfVec3h[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3hArray_CopyFromArray__SWIG_0")]
		public static extern void VtVec3hArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfVec3h[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3hArray_CopyToArray__SWIG_1")]
		public static extern void VtVec3hArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3hArray_CopyFromArray__SWIG_1")]
		public static extern void VtVec3hArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3hArray_GetValue")]
		public static extern IntPtr VtVec3hArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3hArray_SetValue")]
		public static extern void VtVec3hArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3hArray_Equals")]
		public static extern bool VtVec3hArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3hArray_GetHashCode")]
		public static extern int VtVec3hArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtVec3hArray__SWIG_0")]
		public static extern IntPtr VtValueToVtVec3hArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtVec3hArray__SWIG_1")]
		public static extern void VtValueToVtVec3hArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfVec2h__SWIG_0")]
		public static extern IntPtr VtValueToGfVec2h__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfVec2h__SWIG_1")]
		public static extern void VtValueToGfVec2h__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec2hArray__SWIG_0")]
		public static extern IntPtr new_VtVec2hArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec2hArray__SWIG_1")]
		public static extern IntPtr new_VtVec2hArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec2hArray__SWIG_3")]
		public static extern IntPtr new_VtVec2hArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec2hArray__SWIG_4")]
		public static extern IntPtr new_VtVec2hArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtVec2hArray")]
		public static extern void delete_VtVec2hArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2hArray_AsConst")]
		public static extern IntPtr VtVec2hArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2hArray_push_back")]
		public static extern void VtVec2hArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2hArray_pop_back")]
		public static extern void VtVec2hArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2hArray_size")]
		public static extern uint VtVec2hArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2hArray_capacity")]
		public static extern uint VtVec2hArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2hArray_empty")]
		public static extern bool VtVec2hArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2hArray_reserve")]
		public static extern void VtVec2hArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2hArray_resize")]
		public static extern void VtVec2hArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2hArray_clear")]
		public static extern void VtVec2hArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2hArray_assign")]
		public static extern void VtVec2hArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2hArray_swap")]
		public static extern void VtVec2hArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2hArray_IsIdentical")]
		public static extern bool VtVec2hArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2hArray_ToString")]
		public static extern string VtVec2hArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2hArray_CopyToArray__SWIG_0")]
		public static extern void VtVec2hArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfVec2h[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2hArray_CopyFromArray__SWIG_0")]
		public static extern void VtVec2hArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfVec2h[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2hArray_CopyToArray__SWIG_1")]
		public static extern void VtVec2hArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2hArray_CopyFromArray__SWIG_1")]
		public static extern void VtVec2hArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2hArray_GetValue")]
		public static extern IntPtr VtVec2hArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2hArray_SetValue")]
		public static extern void VtVec2hArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2hArray_Equals")]
		public static extern bool VtVec2hArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2hArray_GetHashCode")]
		public static extern int VtVec2hArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtVec2hArray__SWIG_0")]
		public static extern IntPtr VtValueToVtVec2hArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtVec2hArray__SWIG_1")]
		public static extern void VtValueToVtVec2hArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfVec4f__SWIG_0")]
		public static extern IntPtr VtValueToGfVec4f__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfVec4f__SWIG_1")]
		public static extern void VtValueToGfVec4f__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec4fArray__SWIG_0")]
		public static extern IntPtr new_VtVec4fArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec4fArray__SWIG_1")]
		public static extern IntPtr new_VtVec4fArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec4fArray__SWIG_3")]
		public static extern IntPtr new_VtVec4fArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec4fArray__SWIG_4")]
		public static extern IntPtr new_VtVec4fArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtVec4fArray")]
		public static extern void delete_VtVec4fArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4fArray_AsConst")]
		public static extern IntPtr VtVec4fArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4fArray_push_back")]
		public static extern void VtVec4fArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4fArray_pop_back")]
		public static extern void VtVec4fArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4fArray_size")]
		public static extern uint VtVec4fArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4fArray_capacity")]
		public static extern uint VtVec4fArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4fArray_empty")]
		public static extern bool VtVec4fArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4fArray_reserve")]
		public static extern void VtVec4fArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4fArray_resize")]
		public static extern void VtVec4fArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4fArray_clear")]
		public static extern void VtVec4fArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4fArray_assign")]
		public static extern void VtVec4fArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4fArray_swap")]
		public static extern void VtVec4fArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4fArray_IsIdentical")]
		public static extern bool VtVec4fArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4fArray_ToString")]
		public static extern string VtVec4fArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4fArray_CopyToArray__SWIG_0")]
		public static extern void VtVec4fArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfVec4f[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4fArray_CopyFromArray__SWIG_0")]
		public static extern void VtVec4fArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfVec4f[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4fArray_CopyToArray__SWIG_1")]
		public static extern void VtVec4fArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4fArray_CopyFromArray__SWIG_1")]
		public static extern void VtVec4fArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4fArray_GetValue")]
		public static extern IntPtr VtVec4fArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4fArray_SetValue")]
		public static extern void VtVec4fArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4fArray_Equals")]
		public static extern bool VtVec4fArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4fArray_GetHashCode")]
		public static extern int VtVec4fArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtVec4fArray__SWIG_0")]
		public static extern IntPtr VtValueToVtVec4fArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtVec4fArray__SWIG_1")]
		public static extern void VtValueToVtVec4fArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfVec3f__SWIG_0")]
		public static extern IntPtr VtValueToGfVec3f__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfVec3f__SWIG_1")]
		public static extern void VtValueToGfVec3f__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec3fArray__SWIG_0")]
		public static extern IntPtr new_VtVec3fArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec3fArray__SWIG_1")]
		public static extern IntPtr new_VtVec3fArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec3fArray__SWIG_3")]
		public static extern IntPtr new_VtVec3fArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec3fArray__SWIG_4")]
		public static extern IntPtr new_VtVec3fArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtVec3fArray")]
		public static extern void delete_VtVec3fArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3fArray_AsConst")]
		public static extern IntPtr VtVec3fArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3fArray_push_back")]
		public static extern void VtVec3fArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3fArray_pop_back")]
		public static extern void VtVec3fArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3fArray_size")]
		public static extern uint VtVec3fArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3fArray_capacity")]
		public static extern uint VtVec3fArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3fArray_empty")]
		public static extern bool VtVec3fArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3fArray_reserve")]
		public static extern void VtVec3fArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3fArray_resize")]
		public static extern void VtVec3fArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3fArray_clear")]
		public static extern void VtVec3fArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3fArray_assign")]
		public static extern void VtVec3fArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3fArray_swap")]
		public static extern void VtVec3fArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3fArray_IsIdentical")]
		public static extern bool VtVec3fArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3fArray_ToString")]
		public static extern string VtVec3fArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3fArray_CopyToArray__SWIG_0")]
		public static extern void VtVec3fArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfVec3f[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3fArray_CopyFromArray__SWIG_0")]
		public static extern void VtVec3fArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfVec3f[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3fArray_CopyToArray__SWIG_1")]
		public static extern void VtVec3fArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3fArray_CopyFromArray__SWIG_1")]
		public static extern void VtVec3fArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3fArray_GetValue")]
		public static extern IntPtr VtVec3fArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3fArray_SetValue")]
		public static extern void VtVec3fArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3fArray_Equals")]
		public static extern bool VtVec3fArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3fArray_GetHashCode")]
		public static extern int VtVec3fArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtVec3fArray__SWIG_0")]
		public static extern IntPtr VtValueToVtVec3fArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtVec3fArray__SWIG_1")]
		public static extern void VtValueToVtVec3fArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfVec2f__SWIG_0")]
		public static extern IntPtr VtValueToGfVec2f__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfVec2f__SWIG_1")]
		public static extern void VtValueToGfVec2f__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec2fArray__SWIG_0")]
		public static extern IntPtr new_VtVec2fArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec2fArray__SWIG_1")]
		public static extern IntPtr new_VtVec2fArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec2fArray__SWIG_3")]
		public static extern IntPtr new_VtVec2fArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec2fArray__SWIG_4")]
		public static extern IntPtr new_VtVec2fArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtVec2fArray")]
		public static extern void delete_VtVec2fArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2fArray_AsConst")]
		public static extern IntPtr VtVec2fArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2fArray_push_back")]
		public static extern void VtVec2fArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2fArray_pop_back")]
		public static extern void VtVec2fArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2fArray_size")]
		public static extern uint VtVec2fArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2fArray_capacity")]
		public static extern uint VtVec2fArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2fArray_empty")]
		public static extern bool VtVec2fArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2fArray_reserve")]
		public static extern void VtVec2fArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2fArray_resize")]
		public static extern void VtVec2fArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2fArray_clear")]
		public static extern void VtVec2fArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2fArray_assign")]
		public static extern void VtVec2fArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2fArray_swap")]
		public static extern void VtVec2fArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2fArray_IsIdentical")]
		public static extern bool VtVec2fArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2fArray_ToString")]
		public static extern string VtVec2fArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2fArray_CopyToArray__SWIG_0")]
		public static extern void VtVec2fArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfVec2f[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2fArray_CopyFromArray__SWIG_0")]
		public static extern void VtVec2fArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfVec2f[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2fArray_CopyToArray__SWIG_1")]
		public static extern void VtVec2fArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2fArray_CopyFromArray__SWIG_1")]
		public static extern void VtVec2fArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2fArray_GetValue")]
		public static extern IntPtr VtVec2fArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2fArray_SetValue")]
		public static extern void VtVec2fArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2fArray_Equals")]
		public static extern bool VtVec2fArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2fArray_GetHashCode")]
		public static extern int VtVec2fArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtVec2fArray__SWIG_0")]
		public static extern IntPtr VtValueToVtVec2fArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtVec2fArray__SWIG_1")]
		public static extern void VtValueToVtVec2fArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfVec4d__SWIG_0")]
		public static extern IntPtr VtValueToGfVec4d__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfVec4d__SWIG_1")]
		public static extern void VtValueToGfVec4d__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec4dArray__SWIG_0")]
		public static extern IntPtr new_VtVec4dArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec4dArray__SWIG_1")]
		public static extern IntPtr new_VtVec4dArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec4dArray__SWIG_3")]
		public static extern IntPtr new_VtVec4dArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec4dArray__SWIG_4")]
		public static extern IntPtr new_VtVec4dArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtVec4dArray")]
		public static extern void delete_VtVec4dArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4dArray_AsConst")]
		public static extern IntPtr VtVec4dArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4dArray_push_back")]
		public static extern void VtVec4dArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4dArray_pop_back")]
		public static extern void VtVec4dArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4dArray_size")]
		public static extern uint VtVec4dArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4dArray_capacity")]
		public static extern uint VtVec4dArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4dArray_empty")]
		public static extern bool VtVec4dArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4dArray_reserve")]
		public static extern void VtVec4dArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4dArray_resize")]
		public static extern void VtVec4dArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4dArray_clear")]
		public static extern void VtVec4dArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4dArray_assign")]
		public static extern void VtVec4dArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4dArray_swap")]
		public static extern void VtVec4dArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4dArray_IsIdentical")]
		public static extern bool VtVec4dArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4dArray_ToString")]
		public static extern string VtVec4dArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4dArray_CopyToArray__SWIG_0")]
		public static extern void VtVec4dArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfVec4d[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4dArray_CopyFromArray__SWIG_0")]
		public static extern void VtVec4dArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfVec4d[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4dArray_CopyToArray__SWIG_1")]
		public static extern void VtVec4dArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4dArray_CopyFromArray__SWIG_1")]
		public static extern void VtVec4dArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4dArray_GetValue")]
		public static extern IntPtr VtVec4dArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4dArray_SetValue")]
		public static extern void VtVec4dArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4dArray_Equals")]
		public static extern bool VtVec4dArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4dArray_GetHashCode")]
		public static extern int VtVec4dArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtVec4dArray__SWIG_0")]
		public static extern IntPtr VtValueToVtVec4dArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtVec4dArray__SWIG_1")]
		public static extern void VtValueToVtVec4dArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfVec3d__SWIG_0")]
		public static extern IntPtr VtValueToGfVec3d__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfVec3d__SWIG_1")]
		public static extern void VtValueToGfVec3d__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec3dArray__SWIG_0")]
		public static extern IntPtr new_VtVec3dArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec3dArray__SWIG_1")]
		public static extern IntPtr new_VtVec3dArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec3dArray__SWIG_3")]
		public static extern IntPtr new_VtVec3dArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec3dArray__SWIG_4")]
		public static extern IntPtr new_VtVec3dArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtVec3dArray")]
		public static extern void delete_VtVec3dArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3dArray_AsConst")]
		public static extern IntPtr VtVec3dArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3dArray_push_back")]
		public static extern void VtVec3dArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3dArray_pop_back")]
		public static extern void VtVec3dArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3dArray_size")]
		public static extern uint VtVec3dArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3dArray_capacity")]
		public static extern uint VtVec3dArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3dArray_empty")]
		public static extern bool VtVec3dArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3dArray_reserve")]
		public static extern void VtVec3dArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3dArray_resize")]
		public static extern void VtVec3dArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3dArray_clear")]
		public static extern void VtVec3dArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3dArray_assign")]
		public static extern void VtVec3dArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3dArray_swap")]
		public static extern void VtVec3dArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3dArray_IsIdentical")]
		public static extern bool VtVec3dArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3dArray_ToString")]
		public static extern string VtVec3dArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3dArray_CopyToArray__SWIG_0")]
		public static extern void VtVec3dArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfVec3d[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3dArray_CopyFromArray__SWIG_0")]
		public static extern void VtVec3dArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfVec3d[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3dArray_CopyToArray__SWIG_1")]
		public static extern void VtVec3dArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3dArray_CopyFromArray__SWIG_1")]
		public static extern void VtVec3dArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3dArray_GetValue")]
		public static extern IntPtr VtVec3dArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3dArray_SetValue")]
		public static extern void VtVec3dArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3dArray_Equals")]
		public static extern bool VtVec3dArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3dArray_GetHashCode")]
		public static extern int VtVec3dArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtVec3dArray__SWIG_0")]
		public static extern IntPtr VtValueToVtVec3dArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtVec3dArray__SWIG_1")]
		public static extern void VtValueToVtVec3dArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfVec2d__SWIG_0")]
		public static extern IntPtr VtValueToGfVec2d__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfVec2d__SWIG_1")]
		public static extern void VtValueToGfVec2d__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec2dArray__SWIG_0")]
		public static extern IntPtr new_VtVec2dArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec2dArray__SWIG_1")]
		public static extern IntPtr new_VtVec2dArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec2dArray__SWIG_3")]
		public static extern IntPtr new_VtVec2dArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtVec2dArray__SWIG_4")]
		public static extern IntPtr new_VtVec2dArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtVec2dArray")]
		public static extern void delete_VtVec2dArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2dArray_AsConst")]
		public static extern IntPtr VtVec2dArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2dArray_push_back")]
		public static extern void VtVec2dArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2dArray_pop_back")]
		public static extern void VtVec2dArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2dArray_size")]
		public static extern uint VtVec2dArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2dArray_capacity")]
		public static extern uint VtVec2dArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2dArray_empty")]
		public static extern bool VtVec2dArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2dArray_reserve")]
		public static extern void VtVec2dArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2dArray_resize")]
		public static extern void VtVec2dArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2dArray_clear")]
		public static extern void VtVec2dArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2dArray_assign")]
		public static extern void VtVec2dArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2dArray_swap")]
		public static extern void VtVec2dArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2dArray_IsIdentical")]
		public static extern bool VtVec2dArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2dArray_ToString")]
		public static extern string VtVec2dArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2dArray_CopyToArray__SWIG_0")]
		public static extern void VtVec2dArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfVec2d[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2dArray_CopyFromArray__SWIG_0")]
		public static extern void VtVec2dArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfVec2d[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2dArray_CopyToArray__SWIG_1")]
		public static extern void VtVec2dArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2dArray_CopyFromArray__SWIG_1")]
		public static extern void VtVec2dArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2dArray_GetValue")]
		public static extern IntPtr VtVec2dArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2dArray_SetValue")]
		public static extern void VtVec2dArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2dArray_Equals")]
		public static extern bool VtVec2dArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2dArray_GetHashCode")]
		public static extern int VtVec2dArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtVec2dArray__SWIG_0")]
		public static extern IntPtr VtValueToVtVec2dArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtVec2dArray__SWIG_1")]
		public static extern void VtValueToVtVec2dArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfMatrix4d__SWIG_0")]
		public static extern IntPtr VtValueToGfMatrix4d__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfMatrix4d__SWIG_1")]
		public static extern void VtValueToGfMatrix4d__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtMatrix4dArray__SWIG_0")]
		public static extern IntPtr new_VtMatrix4dArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtMatrix4dArray__SWIG_1")]
		public static extern IntPtr new_VtMatrix4dArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtMatrix4dArray__SWIG_3")]
		public static extern IntPtr new_VtMatrix4dArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtMatrix4dArray__SWIG_4")]
		public static extern IntPtr new_VtMatrix4dArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtMatrix4dArray")]
		public static extern void delete_VtMatrix4dArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4dArray_AsConst")]
		public static extern IntPtr VtMatrix4dArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4dArray_push_back")]
		public static extern void VtMatrix4dArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4dArray_pop_back")]
		public static extern void VtMatrix4dArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4dArray_size")]
		public static extern uint VtMatrix4dArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4dArray_capacity")]
		public static extern uint VtMatrix4dArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4dArray_empty")]
		public static extern bool VtMatrix4dArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4dArray_reserve")]
		public static extern void VtMatrix4dArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4dArray_resize")]
		public static extern void VtMatrix4dArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4dArray_clear")]
		public static extern void VtMatrix4dArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4dArray_assign")]
		public static extern void VtMatrix4dArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4dArray_swap")]
		public static extern void VtMatrix4dArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4dArray_IsIdentical")]
		public static extern bool VtMatrix4dArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4dArray_ToString")]
		public static extern string VtMatrix4dArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4dArray_CopyToArray__SWIG_0")]
		public static extern void VtMatrix4dArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfMatrix4d[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4dArray_CopyFromArray__SWIG_0")]
		public static extern void VtMatrix4dArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfMatrix4d[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4dArray_CopyToArray__SWIG_1")]
		public static extern void VtMatrix4dArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4dArray_CopyFromArray__SWIG_1")]
		public static extern void VtMatrix4dArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4dArray_GetValue")]
		public static extern IntPtr VtMatrix4dArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4dArray_SetValue")]
		public static extern void VtMatrix4dArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4dArray_Equals")]
		public static extern bool VtMatrix4dArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4dArray_GetHashCode")]
		public static extern int VtMatrix4dArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtMatrix4dArray__SWIG_0")]
		public static extern IntPtr VtValueToVtMatrix4dArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtMatrix4dArray__SWIG_1")]
		public static extern void VtValueToVtMatrix4dArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfMatrix3d__SWIG_0")]
		public static extern IntPtr VtValueToGfMatrix3d__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfMatrix3d__SWIG_1")]
		public static extern void VtValueToGfMatrix3d__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtMatrix3dArray__SWIG_0")]
		public static extern IntPtr new_VtMatrix3dArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtMatrix3dArray__SWIG_1")]
		public static extern IntPtr new_VtMatrix3dArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtMatrix3dArray__SWIG_3")]
		public static extern IntPtr new_VtMatrix3dArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtMatrix3dArray__SWIG_4")]
		public static extern IntPtr new_VtMatrix3dArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtMatrix3dArray")]
		public static extern void delete_VtMatrix3dArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3dArray_AsConst")]
		public static extern IntPtr VtMatrix3dArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3dArray_push_back")]
		public static extern void VtMatrix3dArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3dArray_pop_back")]
		public static extern void VtMatrix3dArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3dArray_size")]
		public static extern uint VtMatrix3dArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3dArray_capacity")]
		public static extern uint VtMatrix3dArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3dArray_empty")]
		public static extern bool VtMatrix3dArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3dArray_reserve")]
		public static extern void VtMatrix3dArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3dArray_resize")]
		public static extern void VtMatrix3dArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3dArray_clear")]
		public static extern void VtMatrix3dArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3dArray_assign")]
		public static extern void VtMatrix3dArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3dArray_swap")]
		public static extern void VtMatrix3dArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3dArray_IsIdentical")]
		public static extern bool VtMatrix3dArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3dArray_ToString")]
		public static extern string VtMatrix3dArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3dArray_CopyToArray__SWIG_0")]
		public static extern void VtMatrix3dArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfMatrix3d[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3dArray_CopyFromArray__SWIG_0")]
		public static extern void VtMatrix3dArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfMatrix3d[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3dArray_CopyToArray__SWIG_1")]
		public static extern void VtMatrix3dArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3dArray_CopyFromArray__SWIG_1")]
		public static extern void VtMatrix3dArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3dArray_GetValue")]
		public static extern IntPtr VtMatrix3dArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3dArray_SetValue")]
		public static extern void VtMatrix3dArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3dArray_Equals")]
		public static extern bool VtMatrix3dArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3dArray_GetHashCode")]
		public static extern int VtMatrix3dArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtMatrix3dArray__SWIG_0")]
		public static extern IntPtr VtValueToVtMatrix3dArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtMatrix3dArray__SWIG_1")]
		public static extern void VtValueToVtMatrix3dArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfMatrix2d__SWIG_0")]
		public static extern IntPtr VtValueToGfMatrix2d__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfMatrix2d__SWIG_1")]
		public static extern void VtValueToGfMatrix2d__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtMatrix2dArray__SWIG_0")]
		public static extern IntPtr new_VtMatrix2dArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtMatrix2dArray__SWIG_1")]
		public static extern IntPtr new_VtMatrix2dArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtMatrix2dArray__SWIG_3")]
		public static extern IntPtr new_VtMatrix2dArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtMatrix2dArray__SWIG_4")]
		public static extern IntPtr new_VtMatrix2dArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtMatrix2dArray")]
		public static extern void delete_VtMatrix2dArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2dArray_AsConst")]
		public static extern IntPtr VtMatrix2dArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2dArray_push_back")]
		public static extern void VtMatrix2dArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2dArray_pop_back")]
		public static extern void VtMatrix2dArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2dArray_size")]
		public static extern uint VtMatrix2dArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2dArray_capacity")]
		public static extern uint VtMatrix2dArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2dArray_empty")]
		public static extern bool VtMatrix2dArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2dArray_reserve")]
		public static extern void VtMatrix2dArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2dArray_resize")]
		public static extern void VtMatrix2dArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2dArray_clear")]
		public static extern void VtMatrix2dArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2dArray_assign")]
		public static extern void VtMatrix2dArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2dArray_swap")]
		public static extern void VtMatrix2dArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2dArray_IsIdentical")]
		public static extern bool VtMatrix2dArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2dArray_ToString")]
		public static extern string VtMatrix2dArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2dArray_CopyToArray__SWIG_0")]
		public static extern void VtMatrix2dArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfMatrix2d[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2dArray_CopyFromArray__SWIG_0")]
		public static extern void VtMatrix2dArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfMatrix2d[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2dArray_CopyToArray__SWIG_1")]
		public static extern void VtMatrix2dArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2dArray_CopyFromArray__SWIG_1")]
		public static extern void VtMatrix2dArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2dArray_GetValue")]
		public static extern IntPtr VtMatrix2dArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2dArray_SetValue")]
		public static extern void VtMatrix2dArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2dArray_Equals")]
		public static extern bool VtMatrix2dArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2dArray_GetHashCode")]
		public static extern int VtMatrix2dArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtMatrix2dArray__SWIG_0")]
		public static extern IntPtr VtValueToVtMatrix2dArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtMatrix2dArray__SWIG_1")]
		public static extern void VtValueToVtMatrix2dArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfMatrix4f__SWIG_0")]
		public static extern IntPtr VtValueToGfMatrix4f__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfMatrix4f__SWIG_1")]
		public static extern void VtValueToGfMatrix4f__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtMatrix4fArray__SWIG_0")]
		public static extern IntPtr new_VtMatrix4fArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtMatrix4fArray__SWIG_1")]
		public static extern IntPtr new_VtMatrix4fArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtMatrix4fArray__SWIG_3")]
		public static extern IntPtr new_VtMatrix4fArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtMatrix4fArray__SWIG_4")]
		public static extern IntPtr new_VtMatrix4fArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtMatrix4fArray")]
		public static extern void delete_VtMatrix4fArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4fArray_AsConst")]
		public static extern IntPtr VtMatrix4fArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4fArray_push_back")]
		public static extern void VtMatrix4fArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4fArray_pop_back")]
		public static extern void VtMatrix4fArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4fArray_size")]
		public static extern uint VtMatrix4fArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4fArray_capacity")]
		public static extern uint VtMatrix4fArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4fArray_empty")]
		public static extern bool VtMatrix4fArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4fArray_reserve")]
		public static extern void VtMatrix4fArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4fArray_resize")]
		public static extern void VtMatrix4fArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4fArray_clear")]
		public static extern void VtMatrix4fArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4fArray_assign")]
		public static extern void VtMatrix4fArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4fArray_swap")]
		public static extern void VtMatrix4fArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4fArray_IsIdentical")]
		public static extern bool VtMatrix4fArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4fArray_ToString")]
		public static extern string VtMatrix4fArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4fArray_CopyToArray__SWIG_0")]
		public static extern void VtMatrix4fArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfMatrix4f[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4fArray_CopyFromArray__SWIG_0")]
		public static extern void VtMatrix4fArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfMatrix4f[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4fArray_CopyToArray__SWIG_1")]
		public static extern void VtMatrix4fArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4fArray_CopyFromArray__SWIG_1")]
		public static extern void VtMatrix4fArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4fArray_GetValue")]
		public static extern IntPtr VtMatrix4fArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4fArray_SetValue")]
		public static extern void VtMatrix4fArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4fArray_Equals")]
		public static extern bool VtMatrix4fArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4fArray_GetHashCode")]
		public static extern int VtMatrix4fArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtMatrix4fArray__SWIG_0")]
		public static extern IntPtr VtValueToVtMatrix4fArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtMatrix4fArray__SWIG_1")]
		public static extern void VtValueToVtMatrix4fArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfMatrix3f__SWIG_0")]
		public static extern IntPtr VtValueToGfMatrix3f__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfMatrix3f__SWIG_1")]
		public static extern void VtValueToGfMatrix3f__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtMatrix3fArray__SWIG_0")]
		public static extern IntPtr new_VtMatrix3fArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtMatrix3fArray__SWIG_1")]
		public static extern IntPtr new_VtMatrix3fArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtMatrix3fArray__SWIG_3")]
		public static extern IntPtr new_VtMatrix3fArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtMatrix3fArray__SWIG_4")]
		public static extern IntPtr new_VtMatrix3fArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtMatrix3fArray")]
		public static extern void delete_VtMatrix3fArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3fArray_AsConst")]
		public static extern IntPtr VtMatrix3fArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3fArray_push_back")]
		public static extern void VtMatrix3fArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3fArray_pop_back")]
		public static extern void VtMatrix3fArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3fArray_size")]
		public static extern uint VtMatrix3fArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3fArray_capacity")]
		public static extern uint VtMatrix3fArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3fArray_empty")]
		public static extern bool VtMatrix3fArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3fArray_reserve")]
		public static extern void VtMatrix3fArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3fArray_resize")]
		public static extern void VtMatrix3fArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3fArray_clear")]
		public static extern void VtMatrix3fArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3fArray_assign")]
		public static extern void VtMatrix3fArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3fArray_swap")]
		public static extern void VtMatrix3fArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3fArray_IsIdentical")]
		public static extern bool VtMatrix3fArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3fArray_ToString")]
		public static extern string VtMatrix3fArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3fArray_CopyToArray__SWIG_0")]
		public static extern void VtMatrix3fArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfMatrix3f[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3fArray_CopyFromArray__SWIG_0")]
		public static extern void VtMatrix3fArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfMatrix3f[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3fArray_CopyToArray__SWIG_1")]
		public static extern void VtMatrix3fArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3fArray_CopyFromArray__SWIG_1")]
		public static extern void VtMatrix3fArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3fArray_GetValue")]
		public static extern IntPtr VtMatrix3fArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3fArray_SetValue")]
		public static extern void VtMatrix3fArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3fArray_Equals")]
		public static extern bool VtMatrix3fArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3fArray_GetHashCode")]
		public static extern int VtMatrix3fArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtMatrix3fArray__SWIG_0")]
		public static extern IntPtr VtValueToVtMatrix3fArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtMatrix3fArray__SWIG_1")]
		public static extern void VtValueToVtMatrix3fArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfMatrix2f__SWIG_0")]
		public static extern IntPtr VtValueToGfMatrix2f__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfMatrix2f__SWIG_1")]
		public static extern void VtValueToGfMatrix2f__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtMatrix2fArray__SWIG_0")]
		public static extern IntPtr new_VtMatrix2fArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtMatrix2fArray__SWIG_1")]
		public static extern IntPtr new_VtMatrix2fArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtMatrix2fArray__SWIG_3")]
		public static extern IntPtr new_VtMatrix2fArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtMatrix2fArray__SWIG_4")]
		public static extern IntPtr new_VtMatrix2fArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtMatrix2fArray")]
		public static extern void delete_VtMatrix2fArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2fArray_AsConst")]
		public static extern IntPtr VtMatrix2fArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2fArray_push_back")]
		public static extern void VtMatrix2fArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2fArray_pop_back")]
		public static extern void VtMatrix2fArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2fArray_size")]
		public static extern uint VtMatrix2fArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2fArray_capacity")]
		public static extern uint VtMatrix2fArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2fArray_empty")]
		public static extern bool VtMatrix2fArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2fArray_reserve")]
		public static extern void VtMatrix2fArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2fArray_resize")]
		public static extern void VtMatrix2fArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2fArray_clear")]
		public static extern void VtMatrix2fArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2fArray_assign")]
		public static extern void VtMatrix2fArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2fArray_swap")]
		public static extern void VtMatrix2fArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2fArray_IsIdentical")]
		public static extern bool VtMatrix2fArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2fArray_ToString")]
		public static extern string VtMatrix2fArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2fArray_CopyToArray__SWIG_0")]
		public static extern void VtMatrix2fArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfMatrix2f[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2fArray_CopyFromArray__SWIG_0")]
		public static extern void VtMatrix2fArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfMatrix2f[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2fArray_CopyToArray__SWIG_1")]
		public static extern void VtMatrix2fArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2fArray_CopyFromArray__SWIG_1")]
		public static extern void VtMatrix2fArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2fArray_GetValue")]
		public static extern IntPtr VtMatrix2fArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2fArray_SetValue")]
		public static extern void VtMatrix2fArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2fArray_Equals")]
		public static extern bool VtMatrix2fArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2fArray_GetHashCode")]
		public static extern int VtMatrix2fArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtMatrix2fArray__SWIG_0")]
		public static extern IntPtr VtValueToVtMatrix2fArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtMatrix2fArray__SWIG_1")]
		public static extern void VtValueToVtMatrix2fArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfRange3d__SWIG_0")]
		public static extern IntPtr VtValueToGfRange3d__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfRange3d__SWIG_1")]
		public static extern void VtValueToGfRange3d__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtRange3dArray__SWIG_0")]
		public static extern IntPtr new_VtRange3dArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtRange3dArray__SWIG_1")]
		public static extern IntPtr new_VtRange3dArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtRange3dArray__SWIG_3")]
		public static extern IntPtr new_VtRange3dArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtRange3dArray__SWIG_4")]
		public static extern IntPtr new_VtRange3dArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtRange3dArray")]
		public static extern void delete_VtRange3dArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange3dArray_AsConst")]
		public static extern IntPtr VtRange3dArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange3dArray_push_back")]
		public static extern void VtRange3dArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange3dArray_pop_back")]
		public static extern void VtRange3dArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange3dArray_size")]
		public static extern uint VtRange3dArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange3dArray_capacity")]
		public static extern uint VtRange3dArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange3dArray_empty")]
		public static extern bool VtRange3dArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange3dArray_reserve")]
		public static extern void VtRange3dArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange3dArray_resize")]
		public static extern void VtRange3dArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange3dArray_clear")]
		public static extern void VtRange3dArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange3dArray_assign")]
		public static extern void VtRange3dArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange3dArray_swap")]
		public static extern void VtRange3dArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange3dArray_IsIdentical")]
		public static extern bool VtRange3dArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange3dArray_ToString")]
		public static extern string VtRange3dArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange3dArray_CopyToArray__SWIG_0")]
		public static extern void VtRange3dArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfRange3d[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange3dArray_CopyFromArray__SWIG_0")]
		public static extern void VtRange3dArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfRange3d[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange3dArray_CopyToArray__SWIG_1")]
		public static extern void VtRange3dArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange3dArray_CopyFromArray__SWIG_1")]
		public static extern void VtRange3dArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange3dArray_GetValue")]
		public static extern IntPtr VtRange3dArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange3dArray_SetValue")]
		public static extern void VtRange3dArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange3dArray_Equals")]
		public static extern bool VtRange3dArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange3dArray_GetHashCode")]
		public static extern int VtRange3dArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtRange3dArray__SWIG_0")]
		public static extern IntPtr VtValueToVtRange3dArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtRange3dArray__SWIG_1")]
		public static extern void VtValueToVtRange3dArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfRange2d__SWIG_0")]
		public static extern IntPtr VtValueToGfRange2d__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfRange2d__SWIG_1")]
		public static extern void VtValueToGfRange2d__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtRange2dArray__SWIG_0")]
		public static extern IntPtr new_VtRange2dArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtRange2dArray__SWIG_1")]
		public static extern IntPtr new_VtRange2dArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtRange2dArray__SWIG_3")]
		public static extern IntPtr new_VtRange2dArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtRange2dArray__SWIG_4")]
		public static extern IntPtr new_VtRange2dArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtRange2dArray")]
		public static extern void delete_VtRange2dArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange2dArray_AsConst")]
		public static extern IntPtr VtRange2dArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange2dArray_push_back")]
		public static extern void VtRange2dArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange2dArray_pop_back")]
		public static extern void VtRange2dArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange2dArray_size")]
		public static extern uint VtRange2dArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange2dArray_capacity")]
		public static extern uint VtRange2dArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange2dArray_empty")]
		public static extern bool VtRange2dArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange2dArray_reserve")]
		public static extern void VtRange2dArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange2dArray_resize")]
		public static extern void VtRange2dArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange2dArray_clear")]
		public static extern void VtRange2dArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange2dArray_assign")]
		public static extern void VtRange2dArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange2dArray_swap")]
		public static extern void VtRange2dArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange2dArray_IsIdentical")]
		public static extern bool VtRange2dArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange2dArray_ToString")]
		public static extern string VtRange2dArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange2dArray_CopyToArray__SWIG_0")]
		public static extern void VtRange2dArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfRange2d[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange2dArray_CopyFromArray__SWIG_0")]
		public static extern void VtRange2dArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfRange2d[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange2dArray_CopyToArray__SWIG_1")]
		public static extern void VtRange2dArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange2dArray_CopyFromArray__SWIG_1")]
		public static extern void VtRange2dArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange2dArray_GetValue")]
		public static extern IntPtr VtRange2dArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange2dArray_SetValue")]
		public static extern void VtRange2dArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange2dArray_Equals")]
		public static extern bool VtRange2dArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange2dArray_GetHashCode")]
		public static extern int VtRange2dArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtRange2dArray__SWIG_0")]
		public static extern IntPtr VtValueToVtRange2dArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtRange2dArray__SWIG_1")]
		public static extern void VtValueToVtRange2dArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfRange1f__SWIG_0")]
		public static extern IntPtr VtValueToGfRange1f__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfRange1f__SWIG_1")]
		public static extern void VtValueToGfRange1f__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtRange1fArray__SWIG_0")]
		public static extern IntPtr new_VtRange1fArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtRange1fArray__SWIG_1")]
		public static extern IntPtr new_VtRange1fArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtRange1fArray__SWIG_3")]
		public static extern IntPtr new_VtRange1fArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtRange1fArray__SWIG_4")]
		public static extern IntPtr new_VtRange1fArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtRange1fArray")]
		public static extern void delete_VtRange1fArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1fArray_AsConst")]
		public static extern IntPtr VtRange1fArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1fArray_push_back")]
		public static extern void VtRange1fArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1fArray_pop_back")]
		public static extern void VtRange1fArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1fArray_size")]
		public static extern uint VtRange1fArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1fArray_capacity")]
		public static extern uint VtRange1fArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1fArray_empty")]
		public static extern bool VtRange1fArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1fArray_reserve")]
		public static extern void VtRange1fArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1fArray_resize")]
		public static extern void VtRange1fArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1fArray_clear")]
		public static extern void VtRange1fArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1fArray_assign")]
		public static extern void VtRange1fArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1fArray_swap")]
		public static extern void VtRange1fArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1fArray_IsIdentical")]
		public static extern bool VtRange1fArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1fArray_ToString")]
		public static extern string VtRange1fArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1fArray_CopyToArray__SWIG_0")]
		public static extern void VtRange1fArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfRange1f[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1fArray_CopyFromArray__SWIG_0")]
		public static extern void VtRange1fArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfRange1f[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1fArray_CopyToArray__SWIG_1")]
		public static extern void VtRange1fArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1fArray_CopyFromArray__SWIG_1")]
		public static extern void VtRange1fArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1fArray_GetValue")]
		public static extern IntPtr VtRange1fArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1fArray_SetValue")]
		public static extern void VtRange1fArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1fArray_Equals")]
		public static extern bool VtRange1fArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1fArray_GetHashCode")]
		public static extern int VtRange1fArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtRange1fArray__SWIG_0")]
		public static extern IntPtr VtValueToVtRange1fArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtRange1fArray__SWIG_1")]
		public static extern void VtValueToVtRange1fArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfRange1d__SWIG_0")]
		public static extern IntPtr VtValueToGfRange1d__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfRange1d__SWIG_1")]
		public static extern void VtValueToGfRange1d__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtRange1dArray__SWIG_0")]
		public static extern IntPtr new_VtRange1dArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtRange1dArray__SWIG_1")]
		public static extern IntPtr new_VtRange1dArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtRange1dArray__SWIG_3")]
		public static extern IntPtr new_VtRange1dArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtRange1dArray__SWIG_4")]
		public static extern IntPtr new_VtRange1dArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtRange1dArray")]
		public static extern void delete_VtRange1dArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1dArray_AsConst")]
		public static extern IntPtr VtRange1dArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1dArray_push_back")]
		public static extern void VtRange1dArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1dArray_pop_back")]
		public static extern void VtRange1dArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1dArray_size")]
		public static extern uint VtRange1dArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1dArray_capacity")]
		public static extern uint VtRange1dArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1dArray_empty")]
		public static extern bool VtRange1dArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1dArray_reserve")]
		public static extern void VtRange1dArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1dArray_resize")]
		public static extern void VtRange1dArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1dArray_clear")]
		public static extern void VtRange1dArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1dArray_assign")]
		public static extern void VtRange1dArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1dArray_swap")]
		public static extern void VtRange1dArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1dArray_IsIdentical")]
		public static extern bool VtRange1dArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1dArray_ToString")]
		public static extern string VtRange1dArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1dArray_CopyToArray__SWIG_0")]
		public static extern void VtRange1dArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfRange1d[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1dArray_CopyFromArray__SWIG_0")]
		public static extern void VtRange1dArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfRange1d[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1dArray_CopyToArray__SWIG_1")]
		public static extern void VtRange1dArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1dArray_CopyFromArray__SWIG_1")]
		public static extern void VtRange1dArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1dArray_GetValue")]
		public static extern IntPtr VtRange1dArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1dArray_SetValue")]
		public static extern void VtRange1dArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1dArray_Equals")]
		public static extern bool VtRange1dArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1dArray_GetHashCode")]
		public static extern int VtRange1dArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtRange1dArray__SWIG_0")]
		public static extern IntPtr VtValueToVtRange1dArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtRange1dArray__SWIG_1")]
		public static extern void VtValueToVtRange1dArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfInterval__SWIG_0")]
		public static extern IntPtr VtValueToGfInterval__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfInterval__SWIG_1")]
		public static extern void VtValueToGfInterval__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtIntervalArray__SWIG_0")]
		public static extern IntPtr new_VtIntervalArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtIntervalArray__SWIG_1")]
		public static extern IntPtr new_VtIntervalArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtIntervalArray__SWIG_3")]
		public static extern IntPtr new_VtIntervalArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtIntervalArray__SWIG_4")]
		public static extern IntPtr new_VtIntervalArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtIntervalArray")]
		public static extern void delete_VtIntervalArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntervalArray_AsConst")]
		public static extern IntPtr VtIntervalArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntervalArray_push_back")]
		public static extern void VtIntervalArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntervalArray_pop_back")]
		public static extern void VtIntervalArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntervalArray_size")]
		public static extern uint VtIntervalArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntervalArray_capacity")]
		public static extern uint VtIntervalArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntervalArray_empty")]
		public static extern bool VtIntervalArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntervalArray_reserve")]
		public static extern void VtIntervalArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntervalArray_resize")]
		public static extern void VtIntervalArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntervalArray_clear")]
		public static extern void VtIntervalArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntervalArray_assign")]
		public static extern void VtIntervalArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntervalArray_swap")]
		public static extern void VtIntervalArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntervalArray_IsIdentical")]
		public static extern bool VtIntervalArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntervalArray_ToString")]
		public static extern string VtIntervalArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntervalArray_CopyToArray__SWIG_0")]
		public static extern void VtIntervalArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfInterval[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntervalArray_CopyFromArray__SWIG_0")]
		public static extern void VtIntervalArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfInterval[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntervalArray_CopyToArray__SWIG_1")]
		public static extern void VtIntervalArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntervalArray_CopyFromArray__SWIG_1")]
		public static extern void VtIntervalArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntervalArray_GetValue")]
		public static extern IntPtr VtIntervalArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntervalArray_SetValue")]
		public static extern void VtIntervalArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntervalArray_Equals")]
		public static extern bool VtIntervalArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntervalArray_GetHashCode")]
		public static extern int VtIntervalArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtIntervalArray__SWIG_0")]
		public static extern IntPtr VtValueToVtIntervalArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtIntervalArray__SWIG_1")]
		public static extern void VtValueToVtIntervalArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueTostring__SWIG_0")]
		public static extern string VtValueTostring__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueTostring__SWIG_1")]
		public static extern void VtValueTostring__SWIG_1(HandleRef jarg1, out string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtStringArray__SWIG_0")]
		public static extern IntPtr new_VtStringArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtStringArray__SWIG_1")]
		public static extern IntPtr new_VtStringArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtStringArray__SWIG_3")]
		public static extern IntPtr new_VtStringArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtStringArray__SWIG_4")]
		public static extern IntPtr new_VtStringArray__SWIG_4(uint jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtStringArray")]
		public static extern void delete_VtStringArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtStringArray_AsConst")]
		public static extern IntPtr VtStringArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtStringArray_push_back")]
		public static extern void VtStringArray_push_back(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtStringArray_pop_back")]
		public static extern void VtStringArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtStringArray_size")]
		public static extern uint VtStringArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtStringArray_capacity")]
		public static extern uint VtStringArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtStringArray_empty")]
		public static extern bool VtStringArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtStringArray_reserve")]
		public static extern void VtStringArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtStringArray_resize")]
		public static extern void VtStringArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtStringArray_clear")]
		public static extern void VtStringArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtStringArray_assign")]
		public static extern void VtStringArray_assign(HandleRef jarg1, uint jarg2, string jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtStringArray_swap")]
		public static extern void VtStringArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtStringArray_IsIdentical")]
		public static extern bool VtStringArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtStringArray_ToString")]
		public static extern string VtStringArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtStringArray_CopyToArray__SWIG_0")]
		public static extern void VtStringArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] string[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtStringArray_CopyFromArray__SWIG_0")]
		public static extern void VtStringArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] string[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtStringArray_CopyToArray__SWIG_1")]
		public static extern void VtStringArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtStringArray_CopyFromArray__SWIG_1")]
		public static extern void VtStringArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtStringArray_GetValue")]
		public static extern string VtStringArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtStringArray_SetValue")]
		public static extern void VtStringArray_SetValue(HandleRef jarg1, int jarg2, string jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtStringArray_Equals")]
		public static extern bool VtStringArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtStringArray_GetHashCode")]
		public static extern int VtStringArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtStringArray__SWIG_0")]
		public static extern IntPtr VtValueToVtStringArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtStringArray__SWIG_1")]
		public static extern void VtValueToVtStringArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToTfToken__SWIG_0")]
		public static extern IntPtr VtValueToTfToken__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToTfToken__SWIG_1")]
		public static extern void VtValueToTfToken__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtTokenArray__SWIG_0")]
		public static extern IntPtr new_VtTokenArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtTokenArray__SWIG_1")]
		public static extern IntPtr new_VtTokenArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtTokenArray__SWIG_3")]
		public static extern IntPtr new_VtTokenArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtTokenArray__SWIG_4")]
		public static extern IntPtr new_VtTokenArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtTokenArray")]
		public static extern void delete_VtTokenArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtTokenArray_AsConst")]
		public static extern IntPtr VtTokenArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtTokenArray_push_back")]
		public static extern void VtTokenArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtTokenArray_pop_back")]
		public static extern void VtTokenArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtTokenArray_size")]
		public static extern uint VtTokenArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtTokenArray_capacity")]
		public static extern uint VtTokenArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtTokenArray_empty")]
		public static extern bool VtTokenArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtTokenArray_reserve")]
		public static extern void VtTokenArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtTokenArray_resize")]
		public static extern void VtTokenArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtTokenArray_clear")]
		public static extern void VtTokenArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtTokenArray_assign")]
		public static extern void VtTokenArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtTokenArray_swap")]
		public static extern void VtTokenArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtTokenArray_IsIdentical")]
		public static extern bool VtTokenArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtTokenArray_ToString")]
		public static extern string VtTokenArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtTokenArray_CopyToArray__SWIG_0")]
		public static extern void VtTokenArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] TfToken[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtTokenArray_CopyFromArray__SWIG_0")]
		public static extern void VtTokenArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] TfToken[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtTokenArray_CopyToArray__SWIG_1")]
		public static extern void VtTokenArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtTokenArray_CopyFromArray__SWIG_1")]
		public static extern void VtTokenArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtTokenArray_GetValue")]
		public static extern IntPtr VtTokenArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtTokenArray_SetValue")]
		public static extern void VtTokenArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtTokenArray_Equals")]
		public static extern bool VtTokenArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtTokenArray_GetHashCode")]
		public static extern int VtTokenArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtTokenArray__SWIG_0")]
		public static extern IntPtr VtValueToVtTokenArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtTokenArray__SWIG_1")]
		public static extern void VtValueToVtTokenArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfQuath__SWIG_0")]
		public static extern IntPtr VtValueToGfQuath__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfQuath__SWIG_1")]
		public static extern void VtValueToGfQuath__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtQuathArray__SWIG_0")]
		public static extern IntPtr new_VtQuathArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtQuathArray__SWIG_1")]
		public static extern IntPtr new_VtQuathArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtQuathArray__SWIG_3")]
		public static extern IntPtr new_VtQuathArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtQuathArray__SWIG_4")]
		public static extern IntPtr new_VtQuathArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtQuathArray")]
		public static extern void delete_VtQuathArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuathArray_AsConst")]
		public static extern IntPtr VtQuathArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuathArray_push_back")]
		public static extern void VtQuathArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuathArray_pop_back")]
		public static extern void VtQuathArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuathArray_size")]
		public static extern uint VtQuathArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuathArray_capacity")]
		public static extern uint VtQuathArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuathArray_empty")]
		public static extern bool VtQuathArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuathArray_reserve")]
		public static extern void VtQuathArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuathArray_resize")]
		public static extern void VtQuathArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuathArray_clear")]
		public static extern void VtQuathArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuathArray_assign")]
		public static extern void VtQuathArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuathArray_swap")]
		public static extern void VtQuathArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuathArray_IsIdentical")]
		public static extern bool VtQuathArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuathArray_ToString")]
		public static extern string VtQuathArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuathArray_CopyToArray__SWIG_0")]
		public static extern void VtQuathArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfQuath[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuathArray_CopyFromArray__SWIG_0")]
		public static extern void VtQuathArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfQuath[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuathArray_CopyToArray__SWIG_1")]
		public static extern void VtQuathArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuathArray_CopyFromArray__SWIG_1")]
		public static extern void VtQuathArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuathArray_GetValue")]
		public static extern IntPtr VtQuathArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuathArray_SetValue")]
		public static extern void VtQuathArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuathArray_Equals")]
		public static extern bool VtQuathArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuathArray_GetHashCode")]
		public static extern int VtQuathArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtQuathArray__SWIG_0")]
		public static extern IntPtr VtValueToVtQuathArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtQuathArray__SWIG_1")]
		public static extern void VtValueToVtQuathArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfQuatf__SWIG_0")]
		public static extern IntPtr VtValueToGfQuatf__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfQuatf__SWIG_1")]
		public static extern void VtValueToGfQuatf__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtQuatfArray__SWIG_0")]
		public static extern IntPtr new_VtQuatfArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtQuatfArray__SWIG_1")]
		public static extern IntPtr new_VtQuatfArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtQuatfArray__SWIG_3")]
		public static extern IntPtr new_VtQuatfArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtQuatfArray__SWIG_4")]
		public static extern IntPtr new_VtQuatfArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtQuatfArray")]
		public static extern void delete_VtQuatfArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatfArray_AsConst")]
		public static extern IntPtr VtQuatfArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatfArray_push_back")]
		public static extern void VtQuatfArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatfArray_pop_back")]
		public static extern void VtQuatfArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatfArray_size")]
		public static extern uint VtQuatfArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatfArray_capacity")]
		public static extern uint VtQuatfArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatfArray_empty")]
		public static extern bool VtQuatfArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatfArray_reserve")]
		public static extern void VtQuatfArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatfArray_resize")]
		public static extern void VtQuatfArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatfArray_clear")]
		public static extern void VtQuatfArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatfArray_assign")]
		public static extern void VtQuatfArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatfArray_swap")]
		public static extern void VtQuatfArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatfArray_IsIdentical")]
		public static extern bool VtQuatfArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatfArray_ToString")]
		public static extern string VtQuatfArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatfArray_CopyToArray__SWIG_0")]
		public static extern void VtQuatfArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfQuatf[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatfArray_CopyFromArray__SWIG_0")]
		public static extern void VtQuatfArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfQuatf[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatfArray_CopyToArray__SWIG_1")]
		public static extern void VtQuatfArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatfArray_CopyFromArray__SWIG_1")]
		public static extern void VtQuatfArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatfArray_GetValue")]
		public static extern IntPtr VtQuatfArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatfArray_SetValue")]
		public static extern void VtQuatfArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatfArray_Equals")]
		public static extern bool VtQuatfArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatfArray_GetHashCode")]
		public static extern int VtQuatfArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtQuatfArray__SWIG_0")]
		public static extern IntPtr VtValueToVtQuatfArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtQuatfArray__SWIG_1")]
		public static extern void VtValueToVtQuatfArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfQuatd__SWIG_0")]
		public static extern IntPtr VtValueToGfQuatd__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfQuatd__SWIG_1")]
		public static extern void VtValueToGfQuatd__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtQuatdArray__SWIG_0")]
		public static extern IntPtr new_VtQuatdArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtQuatdArray__SWIG_1")]
		public static extern IntPtr new_VtQuatdArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtQuatdArray__SWIG_3")]
		public static extern IntPtr new_VtQuatdArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtQuatdArray__SWIG_4")]
		public static extern IntPtr new_VtQuatdArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtQuatdArray")]
		public static extern void delete_VtQuatdArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatdArray_AsConst")]
		public static extern IntPtr VtQuatdArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatdArray_push_back")]
		public static extern void VtQuatdArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatdArray_pop_back")]
		public static extern void VtQuatdArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatdArray_size")]
		public static extern uint VtQuatdArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatdArray_capacity")]
		public static extern uint VtQuatdArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatdArray_empty")]
		public static extern bool VtQuatdArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatdArray_reserve")]
		public static extern void VtQuatdArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatdArray_resize")]
		public static extern void VtQuatdArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatdArray_clear")]
		public static extern void VtQuatdArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatdArray_assign")]
		public static extern void VtQuatdArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatdArray_swap")]
		public static extern void VtQuatdArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatdArray_IsIdentical")]
		public static extern bool VtQuatdArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatdArray_ToString")]
		public static extern string VtQuatdArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatdArray_CopyToArray__SWIG_0")]
		public static extern void VtQuatdArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfQuatd[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatdArray_CopyFromArray__SWIG_0")]
		public static extern void VtQuatdArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfQuatd[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatdArray_CopyToArray__SWIG_1")]
		public static extern void VtQuatdArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatdArray_CopyFromArray__SWIG_1")]
		public static extern void VtQuatdArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatdArray_GetValue")]
		public static extern IntPtr VtQuatdArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatdArray_SetValue")]
		public static extern void VtQuatdArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatdArray_Equals")]
		public static extern bool VtQuatdArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatdArray_GetHashCode")]
		public static extern int VtQuatdArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtQuatdArray__SWIG_0")]
		public static extern IntPtr VtValueToVtQuatdArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtQuatdArray__SWIG_1")]
		public static extern void VtValueToVtQuatdArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfQuaternion__SWIG_0")]
		public static extern IntPtr VtValueToGfQuaternion__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfQuaternion__SWIG_1")]
		public static extern void VtValueToGfQuaternion__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtQuaternionArray__SWIG_0")]
		public static extern IntPtr new_VtQuaternionArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtQuaternionArray__SWIG_1")]
		public static extern IntPtr new_VtQuaternionArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtQuaternionArray__SWIG_3")]
		public static extern IntPtr new_VtQuaternionArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtQuaternionArray__SWIG_4")]
		public static extern IntPtr new_VtQuaternionArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtQuaternionArray")]
		public static extern void delete_VtQuaternionArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuaternionArray_AsConst")]
		public static extern IntPtr VtQuaternionArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuaternionArray_push_back")]
		public static extern void VtQuaternionArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuaternionArray_pop_back")]
		public static extern void VtQuaternionArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuaternionArray_size")]
		public static extern uint VtQuaternionArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuaternionArray_capacity")]
		public static extern uint VtQuaternionArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuaternionArray_empty")]
		public static extern bool VtQuaternionArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuaternionArray_reserve")]
		public static extern void VtQuaternionArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuaternionArray_resize")]
		public static extern void VtQuaternionArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuaternionArray_clear")]
		public static extern void VtQuaternionArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuaternionArray_assign")]
		public static extern void VtQuaternionArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuaternionArray_swap")]
		public static extern void VtQuaternionArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuaternionArray_IsIdentical")]
		public static extern bool VtQuaternionArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuaternionArray_ToString")]
		public static extern string VtQuaternionArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuaternionArray_CopyToArray__SWIG_0")]
		public static extern void VtQuaternionArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfQuaternion[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuaternionArray_CopyFromArray__SWIG_0")]
		public static extern void VtQuaternionArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfQuaternion[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuaternionArray_CopyToArray__SWIG_1")]
		public static extern void VtQuaternionArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuaternionArray_CopyFromArray__SWIG_1")]
		public static extern void VtQuaternionArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuaternionArray_GetValue")]
		public static extern IntPtr VtQuaternionArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuaternionArray_SetValue")]
		public static extern void VtQuaternionArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuaternionArray_Equals")]
		public static extern bool VtQuaternionArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuaternionArray_GetHashCode")]
		public static extern int VtQuaternionArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtQuaternionArray__SWIG_0")]
		public static extern IntPtr VtValueToVtQuaternionArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtQuaternionArray__SWIG_1")]
		public static extern void VtValueToVtQuaternionArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfDualQuath__SWIG_0")]
		public static extern IntPtr VtValueToGfDualQuath__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfDualQuath__SWIG_1")]
		public static extern void VtValueToGfDualQuath__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtDualQuathArray__SWIG_0")]
		public static extern IntPtr new_VtDualQuathArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtDualQuathArray__SWIG_1")]
		public static extern IntPtr new_VtDualQuathArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtDualQuathArray__SWIG_3")]
		public static extern IntPtr new_VtDualQuathArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtDualQuathArray__SWIG_4")]
		public static extern IntPtr new_VtDualQuathArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtDualQuathArray")]
		public static extern void delete_VtDualQuathArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuathArray_AsConst")]
		public static extern IntPtr VtDualQuathArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuathArray_push_back")]
		public static extern void VtDualQuathArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuathArray_pop_back")]
		public static extern void VtDualQuathArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuathArray_size")]
		public static extern uint VtDualQuathArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuathArray_capacity")]
		public static extern uint VtDualQuathArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuathArray_empty")]
		public static extern bool VtDualQuathArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuathArray_reserve")]
		public static extern void VtDualQuathArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuathArray_resize")]
		public static extern void VtDualQuathArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuathArray_clear")]
		public static extern void VtDualQuathArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuathArray_assign")]
		public static extern void VtDualQuathArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuathArray_swap")]
		public static extern void VtDualQuathArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuathArray_IsIdentical")]
		public static extern bool VtDualQuathArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuathArray_ToString")]
		public static extern string VtDualQuathArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuathArray_CopyToArray__SWIG_0")]
		public static extern void VtDualQuathArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfDualQuath[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuathArray_CopyFromArray__SWIG_0")]
		public static extern void VtDualQuathArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfDualQuath[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuathArray_CopyToArray__SWIG_1")]
		public static extern void VtDualQuathArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuathArray_CopyFromArray__SWIG_1")]
		public static extern void VtDualQuathArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuathArray_GetValue")]
		public static extern IntPtr VtDualQuathArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuathArray_SetValue")]
		public static extern void VtDualQuathArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuathArray_Equals")]
		public static extern bool VtDualQuathArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuathArray_GetHashCode")]
		public static extern int VtDualQuathArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtDualQuathArray__SWIG_0")]
		public static extern IntPtr VtValueToVtDualQuathArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtDualQuathArray__SWIG_1")]
		public static extern void VtValueToVtDualQuathArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfDualQuatf__SWIG_0")]
		public static extern IntPtr VtValueToGfDualQuatf__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfDualQuatf__SWIG_1")]
		public static extern void VtValueToGfDualQuatf__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtDualQuatfArray__SWIG_0")]
		public static extern IntPtr new_VtDualQuatfArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtDualQuatfArray__SWIG_1")]
		public static extern IntPtr new_VtDualQuatfArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtDualQuatfArray__SWIG_3")]
		public static extern IntPtr new_VtDualQuatfArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtDualQuatfArray__SWIG_4")]
		public static extern IntPtr new_VtDualQuatfArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtDualQuatfArray")]
		public static extern void delete_VtDualQuatfArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatfArray_AsConst")]
		public static extern IntPtr VtDualQuatfArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatfArray_push_back")]
		public static extern void VtDualQuatfArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatfArray_pop_back")]
		public static extern void VtDualQuatfArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatfArray_size")]
		public static extern uint VtDualQuatfArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatfArray_capacity")]
		public static extern uint VtDualQuatfArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatfArray_empty")]
		public static extern bool VtDualQuatfArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatfArray_reserve")]
		public static extern void VtDualQuatfArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatfArray_resize")]
		public static extern void VtDualQuatfArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatfArray_clear")]
		public static extern void VtDualQuatfArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatfArray_assign")]
		public static extern void VtDualQuatfArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatfArray_swap")]
		public static extern void VtDualQuatfArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatfArray_IsIdentical")]
		public static extern bool VtDualQuatfArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatfArray_ToString")]
		public static extern string VtDualQuatfArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatfArray_CopyToArray__SWIG_0")]
		public static extern void VtDualQuatfArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfDualQuatf[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatfArray_CopyFromArray__SWIG_0")]
		public static extern void VtDualQuatfArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfDualQuatf[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatfArray_CopyToArray__SWIG_1")]
		public static extern void VtDualQuatfArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatfArray_CopyFromArray__SWIG_1")]
		public static extern void VtDualQuatfArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatfArray_GetValue")]
		public static extern IntPtr VtDualQuatfArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatfArray_SetValue")]
		public static extern void VtDualQuatfArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatfArray_Equals")]
		public static extern bool VtDualQuatfArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatfArray_GetHashCode")]
		public static extern int VtDualQuatfArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtDualQuatfArray__SWIG_0")]
		public static extern IntPtr VtValueToVtDualQuatfArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtDualQuatfArray__SWIG_1")]
		public static extern void VtValueToVtDualQuatfArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfDualQuatd__SWIG_0")]
		public static extern IntPtr VtValueToGfDualQuatd__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfDualQuatd__SWIG_1")]
		public static extern void VtValueToGfDualQuatd__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtDualQuatdArray__SWIG_0")]
		public static extern IntPtr new_VtDualQuatdArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtDualQuatdArray__SWIG_1")]
		public static extern IntPtr new_VtDualQuatdArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtDualQuatdArray__SWIG_3")]
		public static extern IntPtr new_VtDualQuatdArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_VtDualQuatdArray__SWIG_4")]
		public static extern IntPtr new_VtDualQuatdArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_VtDualQuatdArray")]
		public static extern void delete_VtDualQuatdArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatdArray_AsConst")]
		public static extern IntPtr VtDualQuatdArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatdArray_push_back")]
		public static extern void VtDualQuatdArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatdArray_pop_back")]
		public static extern void VtDualQuatdArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatdArray_size")]
		public static extern uint VtDualQuatdArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatdArray_capacity")]
		public static extern uint VtDualQuatdArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatdArray_empty")]
		public static extern bool VtDualQuatdArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatdArray_reserve")]
		public static extern void VtDualQuatdArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatdArray_resize")]
		public static extern void VtDualQuatdArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatdArray_clear")]
		public static extern void VtDualQuatdArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatdArray_assign")]
		public static extern void VtDualQuatdArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatdArray_swap")]
		public static extern void VtDualQuatdArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatdArray_IsIdentical")]
		public static extern bool VtDualQuatdArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatdArray_ToString")]
		public static extern string VtDualQuatdArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatdArray_CopyToArray__SWIG_0")]
		public static extern void VtDualQuatdArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] GfDualQuatd[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatdArray_CopyFromArray__SWIG_0")]
		public static extern void VtDualQuatdArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] GfDualQuatd[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatdArray_CopyToArray__SWIG_1")]
		public static extern void VtDualQuatdArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatdArray_CopyFromArray__SWIG_1")]
		public static extern void VtDualQuatdArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatdArray_GetValue")]
		public static extern IntPtr VtDualQuatdArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatdArray_SetValue")]
		public static extern void VtDualQuatdArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatdArray_Equals")]
		public static extern bool VtDualQuatdArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatdArray_GetHashCode")]
		public static extern int VtDualQuatdArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtDualQuatdArray__SWIG_0")]
		public static extern IntPtr VtValueToVtDualQuatdArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToVtDualQuatdArray__SWIG_1")]
		public static extern void VtValueToVtDualQuatdArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfFrustum__SWIG_0")]
		public static extern IntPtr VtValueToGfFrustum__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToGfFrustum__SWIG_1")]
		public static extern void VtValueToGfFrustum__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToSdfAssetPath__SWIG_0")]
		public static extern IntPtr VtValueToSdfAssetPath__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToSdfAssetPath__SWIG_1")]
		public static extern void VtValueToSdfAssetPath__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_SdfAssetPathArray__SWIG_0")]
		public static extern IntPtr new_SdfAssetPathArray__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_SdfAssetPathArray__SWIG_1")]
		public static extern IntPtr new_SdfAssetPathArray__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_SdfAssetPathArray__SWIG_3")]
		public static extern IntPtr new_SdfAssetPathArray__SWIG_3(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_SdfAssetPathArray__SWIG_4")]
		public static extern IntPtr new_SdfAssetPathArray__SWIG_4(uint jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_SdfAssetPathArray")]
		public static extern void delete_SdfAssetPathArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfAssetPathArray_AsConst")]
		public static extern IntPtr SdfAssetPathArray_AsConst(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfAssetPathArray_push_back")]
		public static extern void SdfAssetPathArray_push_back(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfAssetPathArray_pop_back")]
		public static extern void SdfAssetPathArray_pop_back(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfAssetPathArray_size")]
		public static extern uint SdfAssetPathArray_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfAssetPathArray_capacity")]
		public static extern uint SdfAssetPathArray_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfAssetPathArray_empty")]
		public static extern bool SdfAssetPathArray_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfAssetPathArray_reserve")]
		public static extern void SdfAssetPathArray_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfAssetPathArray_resize")]
		public static extern void SdfAssetPathArray_resize(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfAssetPathArray_clear")]
		public static extern void SdfAssetPathArray_clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfAssetPathArray_assign")]
		public static extern void SdfAssetPathArray_assign(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfAssetPathArray_swap")]
		public static extern void SdfAssetPathArray_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfAssetPathArray_IsIdentical")]
		public static extern bool SdfAssetPathArray_IsIdentical(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfAssetPathArray_ToString")]
		public static extern string SdfAssetPathArray_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfAssetPathArray_CopyToArray__SWIG_0")]
		public static extern void SdfAssetPathArray_CopyToArray__SWIG_0(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] SdfAssetPath[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfAssetPathArray_CopyFromArray__SWIG_0")]
		public static extern void SdfAssetPathArray_CopyFromArray__SWIG_0(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] SdfAssetPath[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfAssetPathArray_CopyToArray__SWIG_1")]
		public static extern void SdfAssetPathArray_CopyToArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfAssetPathArray_CopyFromArray__SWIG_1")]
		public static extern void SdfAssetPathArray_CopyFromArray__SWIG_1(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfAssetPathArray_GetValue")]
		public static extern IntPtr SdfAssetPathArray_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfAssetPathArray_SetValue")]
		public static extern void SdfAssetPathArray_SetValue(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfAssetPathArray_Equals")]
		public static extern bool SdfAssetPathArray_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfAssetPathArray_GetHashCode")]
		public static extern int SdfAssetPathArray_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToSdfAssetPathArray__SWIG_0")]
		public static extern IntPtr VtValueToSdfAssetPathArray__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtValueToSdfAssetPathArray__SWIG_1")]
		public static extern void VtValueToSdfAssetPathArray__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDoubleArray_SWIGUpcast")]
		public static extern IntPtr VtDoubleArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtFloatArray_SWIGUpcast")]
		public static extern IntPtr VtFloatArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtHalfArray_SWIGUpcast")]
		public static extern IntPtr VtHalfArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtBoolArray_SWIGUpcast")]
		public static extern IntPtr VtBoolArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtCharArray_SWIGUpcast")]
		public static extern IntPtr VtCharArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUCharArray_SWIGUpcast")]
		public static extern IntPtr VtUCharArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntArray_SWIGUpcast")]
		public static extern IntPtr VtIntArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUIntArray_SWIGUpcast")]
		public static extern IntPtr VtUIntArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtInt64Array_SWIGUpcast")]
		public static extern IntPtr VtInt64Array_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtUInt64Array_SWIGUpcast")]
		public static extern IntPtr VtUInt64Array_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4iArray_SWIGUpcast")]
		public static extern IntPtr VtVec4iArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3iArray_SWIGUpcast")]
		public static extern IntPtr VtVec3iArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2iArray_SWIGUpcast")]
		public static extern IntPtr VtVec2iArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4hArray_SWIGUpcast")]
		public static extern IntPtr VtVec4hArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3hArray_SWIGUpcast")]
		public static extern IntPtr VtVec3hArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2hArray_SWIGUpcast")]
		public static extern IntPtr VtVec2hArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4fArray_SWIGUpcast")]
		public static extern IntPtr VtVec4fArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3fArray_SWIGUpcast")]
		public static extern IntPtr VtVec3fArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2fArray_SWIGUpcast")]
		public static extern IntPtr VtVec2fArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec4dArray_SWIGUpcast")]
		public static extern IntPtr VtVec4dArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec3dArray_SWIGUpcast")]
		public static extern IntPtr VtVec3dArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtVec2dArray_SWIGUpcast")]
		public static extern IntPtr VtVec2dArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4dArray_SWIGUpcast")]
		public static extern IntPtr VtMatrix4dArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3dArray_SWIGUpcast")]
		public static extern IntPtr VtMatrix3dArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2dArray_SWIGUpcast")]
		public static extern IntPtr VtMatrix2dArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix4fArray_SWIGUpcast")]
		public static extern IntPtr VtMatrix4fArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix3fArray_SWIGUpcast")]
		public static extern IntPtr VtMatrix3fArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtMatrix2fArray_SWIGUpcast")]
		public static extern IntPtr VtMatrix2fArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange3dArray_SWIGUpcast")]
		public static extern IntPtr VtRange3dArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange2dArray_SWIGUpcast")]
		public static extern IntPtr VtRange2dArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1fArray_SWIGUpcast")]
		public static extern IntPtr VtRange1fArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtRange1dArray_SWIGUpcast")]
		public static extern IntPtr VtRange1dArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtIntervalArray_SWIGUpcast")]
		public static extern IntPtr VtIntervalArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtStringArray_SWIGUpcast")]
		public static extern IntPtr VtStringArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtTokenArray_SWIGUpcast")]
		public static extern IntPtr VtTokenArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuathArray_SWIGUpcast")]
		public static extern IntPtr VtQuathArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatfArray_SWIGUpcast")]
		public static extern IntPtr VtQuatfArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuatdArray_SWIGUpcast")]
		public static extern IntPtr VtQuatdArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtQuaternionArray_SWIGUpcast")]
		public static extern IntPtr VtQuaternionArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuathArray_SWIGUpcast")]
		public static extern IntPtr VtDualQuathArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatfArray_SWIGUpcast")]
		public static extern IntPtr VtDualQuatfArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_VtDualQuatdArray_SWIGUpcast")]
		public static extern IntPtr VtDualQuatdArray_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_SdfAssetPathArray_SWIGUpcast")]
		public static extern IntPtr SdfAssetPathArray_SWIGUpcast(IntPtr jarg1);
	}
}
