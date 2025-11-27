using System;
using System.Runtime.InteropServices;

namespace pxr
{
	internal class NdrPINVOKE
	{
		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			[DllImport("UsdCs")]
			public static extern void SWIGRegisterStringCallback_Ndr(SWIGStringDelegate stringDelegate);

			[MonoPInvokeCallback]
			private static string CreateString(string cString)
			{
				return cString;
			}

			static SWIGStringHelper()
			{
				stringDelegate = CreateString;
				SWIGRegisterStringCallback_Ndr(stringDelegate);
			}
		}

		public class SWIGPendingException : UsdCsPINVOKE.SWIGPendingException
		{
		}

		protected static SWIGStringHelper swigStringHelper;

		static NdrPINVOKE()
		{
			swigStringHelper = new SWIGStringHelper();
		}

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrTokenMap__SWIG_0")]
		public static extern IntPtr new_NdrTokenMap__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrTokenMap__SWIG_1")]
		public static extern IntPtr new_NdrTokenMap__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrTokenMap_size")]
		public static extern uint NdrTokenMap_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrTokenMap_empty")]
		public static extern bool NdrTokenMap_empty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrTokenMap_Clear")]
		public static extern void NdrTokenMap_Clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrTokenMap_getitem")]
		public static extern string NdrTokenMap_getitem(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrTokenMap_setitem")]
		public static extern void NdrTokenMap_setitem(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrTokenMap_ContainsKey")]
		public static extern bool NdrTokenMap_ContainsKey(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrTokenMap_Add")]
		public static extern void NdrTokenMap_Add(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrTokenMap_Remove")]
		public static extern bool NdrTokenMap_Remove(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrTokenMap_create_iterator_begin")]
		public static extern IntPtr NdrTokenMap_create_iterator_begin(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrTokenMap_get_next_key")]
		public static extern IntPtr NdrTokenMap_get_next_key(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrTokenMap_destroy_iterator")]
		public static extern void NdrTokenMap_destroy_iterator(HandleRef jarg1, IntPtr jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_NdrTokenMap")]
		public static extern void delete_NdrTokenMap(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrSdfTypeIndicator__SWIG_0")]
		public static extern IntPtr new_NdrSdfTypeIndicator__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrSdfTypeIndicator__SWIG_1")]
		public static extern IntPtr new_NdrSdfTypeIndicator__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrSdfTypeIndicator__SWIG_2")]
		public static extern IntPtr new_NdrSdfTypeIndicator__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrSdfTypeIndicator_first_set")]
		public static extern void NdrSdfTypeIndicator_first_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrSdfTypeIndicator_first_get")]
		public static extern IntPtr NdrSdfTypeIndicator_first_get(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrSdfTypeIndicator_second_set")]
		public static extern void NdrSdfTypeIndicator_second_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrSdfTypeIndicator_second_get")]
		public static extern IntPtr NdrSdfTypeIndicator_second_get(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_NdrSdfTypeIndicator")]
		public static extern void delete_NdrSdfTypeIndicator(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrGetIdentifierString")]
		public static extern string NdrGetIdentifierString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrVersion__SWIG_0")]
		public static extern IntPtr new_NdrVersion__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrVersion__SWIG_1")]
		public static extern IntPtr new_NdrVersion__SWIG_1(int jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrVersion__SWIG_2")]
		public static extern IntPtr new_NdrVersion__SWIG_2(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrVersion__SWIG_3")]
		public static extern IntPtr new_NdrVersion__SWIG_3(string jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrVersion_GetAsDefault")]
		public static extern IntPtr NdrVersion_GetAsDefault(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrVersion_GetMajor")]
		public static extern int NdrVersion_GetMajor(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrVersion_GetMinor")]
		public static extern int NdrVersion_GetMinor(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrVersion_IsDefault")]
		public static extern bool NdrVersion_IsDefault(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrVersion_GetString")]
		public static extern string NdrVersion_GetString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrVersion_GetStringSuffix")]
		public static extern string NdrVersion_GetStringSuffix(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrVersion_GetHash")]
		public static extern uint NdrVersion_GetHash(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_NdrVersion")]
		public static extern void delete_NdrVersion(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextPtrVector_Clear")]
		public static extern void NdrDiscoveryPluginContextPtrVector_Clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextPtrVector_Add")]
		public static extern void NdrDiscoveryPluginContextPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextPtrVector_size")]
		public static extern uint NdrDiscoveryPluginContextPtrVector_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextPtrVector_capacity")]
		public static extern uint NdrDiscoveryPluginContextPtrVector_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextPtrVector_reserve")]
		public static extern void NdrDiscoveryPluginContextPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrDiscoveryPluginContextPtrVector__SWIG_0")]
		public static extern IntPtr new_NdrDiscoveryPluginContextPtrVector__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrDiscoveryPluginContextPtrVector__SWIG_1")]
		public static extern IntPtr new_NdrDiscoveryPluginContextPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrDiscoveryPluginContextPtrVector__SWIG_2")]
		public static extern IntPtr new_NdrDiscoveryPluginContextPtrVector__SWIG_2(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextPtrVector_getitemcopy")]
		public static extern IntPtr NdrDiscoveryPluginContextPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextPtrVector_getitem")]
		public static extern IntPtr NdrDiscoveryPluginContextPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextPtrVector_setitem")]
		public static extern void NdrDiscoveryPluginContextPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextPtrVector_AddRange")]
		public static extern void NdrDiscoveryPluginContextPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextPtrVector_GetRange")]
		public static extern IntPtr NdrDiscoveryPluginContextPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextPtrVector_Insert")]
		public static extern void NdrDiscoveryPluginContextPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextPtrVector_InsertRange")]
		public static extern void NdrDiscoveryPluginContextPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextPtrVector_RemoveAt")]
		public static extern void NdrDiscoveryPluginContextPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextPtrVector_RemoveRange")]
		public static extern void NdrDiscoveryPluginContextPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextPtrVector_Repeat")]
		public static extern IntPtr NdrDiscoveryPluginContextPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextPtrVector_Reverse__SWIG_0")]
		public static extern void NdrDiscoveryPluginContextPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextPtrVector_Reverse__SWIG_1")]
		public static extern void NdrDiscoveryPluginContextPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextPtrVector_SetRange")]
		public static extern void NdrDiscoveryPluginContextPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_NdrDiscoveryPluginContextPtrVector")]
		public static extern void delete_NdrDiscoveryPluginContextPtrVector(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstPtrVector_Clear")]
		public static extern void NdrDiscoveryPluginContextConstPtrVector_Clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstPtrVector_Add")]
		public static extern void NdrDiscoveryPluginContextConstPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstPtrVector_size")]
		public static extern uint NdrDiscoveryPluginContextConstPtrVector_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstPtrVector_capacity")]
		public static extern uint NdrDiscoveryPluginContextConstPtrVector_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstPtrVector_reserve")]
		public static extern void NdrDiscoveryPluginContextConstPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrDiscoveryPluginContextConstPtrVector__SWIG_0")]
		public static extern IntPtr new_NdrDiscoveryPluginContextConstPtrVector__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrDiscoveryPluginContextConstPtrVector__SWIG_1")]
		public static extern IntPtr new_NdrDiscoveryPluginContextConstPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrDiscoveryPluginContextConstPtrVector__SWIG_2")]
		public static extern IntPtr new_NdrDiscoveryPluginContextConstPtrVector__SWIG_2(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstPtrVector_getitemcopy")]
		public static extern IntPtr NdrDiscoveryPluginContextConstPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstPtrVector_getitem")]
		public static extern IntPtr NdrDiscoveryPluginContextConstPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstPtrVector_setitem")]
		public static extern void NdrDiscoveryPluginContextConstPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstPtrVector_AddRange")]
		public static extern void NdrDiscoveryPluginContextConstPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstPtrVector_GetRange")]
		public static extern IntPtr NdrDiscoveryPluginContextConstPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstPtrVector_Insert")]
		public static extern void NdrDiscoveryPluginContextConstPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstPtrVector_InsertRange")]
		public static extern void NdrDiscoveryPluginContextConstPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstPtrVector_RemoveAt")]
		public static extern void NdrDiscoveryPluginContextConstPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstPtrVector_RemoveRange")]
		public static extern void NdrDiscoveryPluginContextConstPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstPtrVector_Repeat")]
		public static extern IntPtr NdrDiscoveryPluginContextConstPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstPtrVector_Reverse__SWIG_0")]
		public static extern void NdrDiscoveryPluginContextConstPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstPtrVector_Reverse__SWIG_1")]
		public static extern void NdrDiscoveryPluginContextConstPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstPtrVector_SetRange")]
		public static extern void NdrDiscoveryPluginContextConstPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_NdrDiscoveryPluginContextConstPtrVector")]
		public static extern void delete_NdrDiscoveryPluginContextConstPtrVector(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextRefPtrVector_Clear")]
		public static extern void NdrDiscoveryPluginContextRefPtrVector_Clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextRefPtrVector_Add")]
		public static extern void NdrDiscoveryPluginContextRefPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextRefPtrVector_size")]
		public static extern uint NdrDiscoveryPluginContextRefPtrVector_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextRefPtrVector_capacity")]
		public static extern uint NdrDiscoveryPluginContextRefPtrVector_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextRefPtrVector_reserve")]
		public static extern void NdrDiscoveryPluginContextRefPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrDiscoveryPluginContextRefPtrVector__SWIG_0")]
		public static extern IntPtr new_NdrDiscoveryPluginContextRefPtrVector__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrDiscoveryPluginContextRefPtrVector__SWIG_1")]
		public static extern IntPtr new_NdrDiscoveryPluginContextRefPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrDiscoveryPluginContextRefPtrVector__SWIG_2")]
		public static extern IntPtr new_NdrDiscoveryPluginContextRefPtrVector__SWIG_2(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextRefPtrVector_getitemcopy")]
		public static extern IntPtr NdrDiscoveryPluginContextRefPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextRefPtrVector_getitem")]
		public static extern IntPtr NdrDiscoveryPluginContextRefPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextRefPtrVector_setitem")]
		public static extern void NdrDiscoveryPluginContextRefPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextRefPtrVector_AddRange")]
		public static extern void NdrDiscoveryPluginContextRefPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextRefPtrVector_GetRange")]
		public static extern IntPtr NdrDiscoveryPluginContextRefPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextRefPtrVector_Insert")]
		public static extern void NdrDiscoveryPluginContextRefPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextRefPtrVector_InsertRange")]
		public static extern void NdrDiscoveryPluginContextRefPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextRefPtrVector_RemoveAt")]
		public static extern void NdrDiscoveryPluginContextRefPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextRefPtrVector_RemoveRange")]
		public static extern void NdrDiscoveryPluginContextRefPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextRefPtrVector_Repeat")]
		public static extern IntPtr NdrDiscoveryPluginContextRefPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextRefPtrVector_Reverse__SWIG_0")]
		public static extern void NdrDiscoveryPluginContextRefPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextRefPtrVector_Reverse__SWIG_1")]
		public static extern void NdrDiscoveryPluginContextRefPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextRefPtrVector_SetRange")]
		public static extern void NdrDiscoveryPluginContextRefPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_NdrDiscoveryPluginContextRefPtrVector")]
		public static extern void delete_NdrDiscoveryPluginContextRefPtrVector(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstRefPtrVector_Clear")]
		public static extern void NdrDiscoveryPluginContextConstRefPtrVector_Clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstRefPtrVector_Add")]
		public static extern void NdrDiscoveryPluginContextConstRefPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstRefPtrVector_size")]
		public static extern uint NdrDiscoveryPluginContextConstRefPtrVector_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstRefPtrVector_capacity")]
		public static extern uint NdrDiscoveryPluginContextConstRefPtrVector_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstRefPtrVector_reserve")]
		public static extern void NdrDiscoveryPluginContextConstRefPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrDiscoveryPluginContextConstRefPtrVector__SWIG_0")]
		public static extern IntPtr new_NdrDiscoveryPluginContextConstRefPtrVector__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrDiscoveryPluginContextConstRefPtrVector__SWIG_1")]
		public static extern IntPtr new_NdrDiscoveryPluginContextConstRefPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrDiscoveryPluginContextConstRefPtrVector__SWIG_2")]
		public static extern IntPtr new_NdrDiscoveryPluginContextConstRefPtrVector__SWIG_2(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstRefPtrVector_getitemcopy")]
		public static extern IntPtr NdrDiscoveryPluginContextConstRefPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstRefPtrVector_getitem")]
		public static extern IntPtr NdrDiscoveryPluginContextConstRefPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstRefPtrVector_setitem")]
		public static extern void NdrDiscoveryPluginContextConstRefPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstRefPtrVector_AddRange")]
		public static extern void NdrDiscoveryPluginContextConstRefPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstRefPtrVector_GetRange")]
		public static extern IntPtr NdrDiscoveryPluginContextConstRefPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstRefPtrVector_Insert")]
		public static extern void NdrDiscoveryPluginContextConstRefPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstRefPtrVector_InsertRange")]
		public static extern void NdrDiscoveryPluginContextConstRefPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstRefPtrVector_RemoveAt")]
		public static extern void NdrDiscoveryPluginContextConstRefPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstRefPtrVector_RemoveRange")]
		public static extern void NdrDiscoveryPluginContextConstRefPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstRefPtrVector_Repeat")]
		public static extern IntPtr NdrDiscoveryPluginContextConstRefPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstRefPtrVector_Reverse__SWIG_0")]
		public static extern void NdrDiscoveryPluginContextConstRefPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstRefPtrVector_Reverse__SWIG_1")]
		public static extern void NdrDiscoveryPluginContextConstRefPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContextConstRefPtrVector_SetRange")]
		public static extern void NdrDiscoveryPluginContextConstRefPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_NdrDiscoveryPluginContextConstRefPtrVector")]
		public static extern void delete_NdrDiscoveryPluginContextConstRefPtrVector(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_NdrDiscoveryPluginContext")]
		public static extern void delete_NdrDiscoveryPluginContext(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginContext_GetSourceType")]
		public static extern IntPtr NdrDiscoveryPluginContext_GetSourceType(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginPtrVector_Clear")]
		public static extern void NdrDiscoveryPluginPtrVector_Clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginPtrVector_Add")]
		public static extern void NdrDiscoveryPluginPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginPtrVector_size")]
		public static extern uint NdrDiscoveryPluginPtrVector_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginPtrVector_capacity")]
		public static extern uint NdrDiscoveryPluginPtrVector_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginPtrVector_reserve")]
		public static extern void NdrDiscoveryPluginPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrDiscoveryPluginPtrVector__SWIG_0")]
		public static extern IntPtr new_NdrDiscoveryPluginPtrVector__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrDiscoveryPluginPtrVector__SWIG_1")]
		public static extern IntPtr new_NdrDiscoveryPluginPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrDiscoveryPluginPtrVector__SWIG_2")]
		public static extern IntPtr new_NdrDiscoveryPluginPtrVector__SWIG_2(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginPtrVector_getitemcopy")]
		public static extern IntPtr NdrDiscoveryPluginPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginPtrVector_getitem")]
		public static extern IntPtr NdrDiscoveryPluginPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginPtrVector_setitem")]
		public static extern void NdrDiscoveryPluginPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginPtrVector_AddRange")]
		public static extern void NdrDiscoveryPluginPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginPtrVector_GetRange")]
		public static extern IntPtr NdrDiscoveryPluginPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginPtrVector_Insert")]
		public static extern void NdrDiscoveryPluginPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginPtrVector_InsertRange")]
		public static extern void NdrDiscoveryPluginPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginPtrVector_RemoveAt")]
		public static extern void NdrDiscoveryPluginPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginPtrVector_RemoveRange")]
		public static extern void NdrDiscoveryPluginPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginPtrVector_Repeat")]
		public static extern IntPtr NdrDiscoveryPluginPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginPtrVector_Reverse__SWIG_0")]
		public static extern void NdrDiscoveryPluginPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginPtrVector_Reverse__SWIG_1")]
		public static extern void NdrDiscoveryPluginPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginPtrVector_SetRange")]
		public static extern void NdrDiscoveryPluginPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_NdrDiscoveryPluginPtrVector")]
		public static extern void delete_NdrDiscoveryPluginPtrVector(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstPtrVector_Clear")]
		public static extern void NdrDiscoveryPluginConstPtrVector_Clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstPtrVector_Add")]
		public static extern void NdrDiscoveryPluginConstPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstPtrVector_size")]
		public static extern uint NdrDiscoveryPluginConstPtrVector_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstPtrVector_capacity")]
		public static extern uint NdrDiscoveryPluginConstPtrVector_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstPtrVector_reserve")]
		public static extern void NdrDiscoveryPluginConstPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrDiscoveryPluginConstPtrVector__SWIG_0")]
		public static extern IntPtr new_NdrDiscoveryPluginConstPtrVector__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrDiscoveryPluginConstPtrVector__SWIG_1")]
		public static extern IntPtr new_NdrDiscoveryPluginConstPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrDiscoveryPluginConstPtrVector__SWIG_2")]
		public static extern IntPtr new_NdrDiscoveryPluginConstPtrVector__SWIG_2(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstPtrVector_getitemcopy")]
		public static extern IntPtr NdrDiscoveryPluginConstPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstPtrVector_getitem")]
		public static extern IntPtr NdrDiscoveryPluginConstPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstPtrVector_setitem")]
		public static extern void NdrDiscoveryPluginConstPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstPtrVector_AddRange")]
		public static extern void NdrDiscoveryPluginConstPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstPtrVector_GetRange")]
		public static extern IntPtr NdrDiscoveryPluginConstPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstPtrVector_Insert")]
		public static extern void NdrDiscoveryPluginConstPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstPtrVector_InsertRange")]
		public static extern void NdrDiscoveryPluginConstPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstPtrVector_RemoveAt")]
		public static extern void NdrDiscoveryPluginConstPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstPtrVector_RemoveRange")]
		public static extern void NdrDiscoveryPluginConstPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstPtrVector_Repeat")]
		public static extern IntPtr NdrDiscoveryPluginConstPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstPtrVector_Reverse__SWIG_0")]
		public static extern void NdrDiscoveryPluginConstPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstPtrVector_Reverse__SWIG_1")]
		public static extern void NdrDiscoveryPluginConstPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstPtrVector_SetRange")]
		public static extern void NdrDiscoveryPluginConstPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_NdrDiscoveryPluginConstPtrVector")]
		public static extern void delete_NdrDiscoveryPluginConstPtrVector(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginRefPtrVector_Clear")]
		public static extern void NdrDiscoveryPluginRefPtrVector_Clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginRefPtrVector_Add")]
		public static extern void NdrDiscoveryPluginRefPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginRefPtrVector_size")]
		public static extern uint NdrDiscoveryPluginRefPtrVector_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginRefPtrVector_capacity")]
		public static extern uint NdrDiscoveryPluginRefPtrVector_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginRefPtrVector_reserve")]
		public static extern void NdrDiscoveryPluginRefPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrDiscoveryPluginRefPtrVector__SWIG_0")]
		public static extern IntPtr new_NdrDiscoveryPluginRefPtrVector__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrDiscoveryPluginRefPtrVector__SWIG_1")]
		public static extern IntPtr new_NdrDiscoveryPluginRefPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrDiscoveryPluginRefPtrVector__SWIG_2")]
		public static extern IntPtr new_NdrDiscoveryPluginRefPtrVector__SWIG_2(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginRefPtrVector_getitemcopy")]
		public static extern IntPtr NdrDiscoveryPluginRefPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginRefPtrVector_getitem")]
		public static extern IntPtr NdrDiscoveryPluginRefPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginRefPtrVector_setitem")]
		public static extern void NdrDiscoveryPluginRefPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginRefPtrVector_AddRange")]
		public static extern void NdrDiscoveryPluginRefPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginRefPtrVector_GetRange")]
		public static extern IntPtr NdrDiscoveryPluginRefPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginRefPtrVector_Insert")]
		public static extern void NdrDiscoveryPluginRefPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginRefPtrVector_InsertRange")]
		public static extern void NdrDiscoveryPluginRefPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginRefPtrVector_RemoveAt")]
		public static extern void NdrDiscoveryPluginRefPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginRefPtrVector_RemoveRange")]
		public static extern void NdrDiscoveryPluginRefPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginRefPtrVector_Repeat")]
		public static extern IntPtr NdrDiscoveryPluginRefPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginRefPtrVector_Reverse__SWIG_0")]
		public static extern void NdrDiscoveryPluginRefPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginRefPtrVector_Reverse__SWIG_1")]
		public static extern void NdrDiscoveryPluginRefPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginRefPtrVector_SetRange")]
		public static extern void NdrDiscoveryPluginRefPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_NdrDiscoveryPluginRefPtrVector")]
		public static extern void delete_NdrDiscoveryPluginRefPtrVector(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstRefPtrVector_Clear")]
		public static extern void NdrDiscoveryPluginConstRefPtrVector_Clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstRefPtrVector_Add")]
		public static extern void NdrDiscoveryPluginConstRefPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstRefPtrVector_size")]
		public static extern uint NdrDiscoveryPluginConstRefPtrVector_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstRefPtrVector_capacity")]
		public static extern uint NdrDiscoveryPluginConstRefPtrVector_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstRefPtrVector_reserve")]
		public static extern void NdrDiscoveryPluginConstRefPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrDiscoveryPluginConstRefPtrVector__SWIG_0")]
		public static extern IntPtr new_NdrDiscoveryPluginConstRefPtrVector__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrDiscoveryPluginConstRefPtrVector__SWIG_1")]
		public static extern IntPtr new_NdrDiscoveryPluginConstRefPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrDiscoveryPluginConstRefPtrVector__SWIG_2")]
		public static extern IntPtr new_NdrDiscoveryPluginConstRefPtrVector__SWIG_2(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstRefPtrVector_getitemcopy")]
		public static extern IntPtr NdrDiscoveryPluginConstRefPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstRefPtrVector_getitem")]
		public static extern IntPtr NdrDiscoveryPluginConstRefPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstRefPtrVector_setitem")]
		public static extern void NdrDiscoveryPluginConstRefPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstRefPtrVector_AddRange")]
		public static extern void NdrDiscoveryPluginConstRefPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstRefPtrVector_GetRange")]
		public static extern IntPtr NdrDiscoveryPluginConstRefPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstRefPtrVector_Insert")]
		public static extern void NdrDiscoveryPluginConstRefPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstRefPtrVector_InsertRange")]
		public static extern void NdrDiscoveryPluginConstRefPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstRefPtrVector_RemoveAt")]
		public static extern void NdrDiscoveryPluginConstRefPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstRefPtrVector_RemoveRange")]
		public static extern void NdrDiscoveryPluginConstRefPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstRefPtrVector_Repeat")]
		public static extern IntPtr NdrDiscoveryPluginConstRefPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstRefPtrVector_Reverse__SWIG_0")]
		public static extern void NdrDiscoveryPluginConstRefPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstRefPtrVector_Reverse__SWIG_1")]
		public static extern void NdrDiscoveryPluginConstRefPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginConstRefPtrVector_SetRange")]
		public static extern void NdrDiscoveryPluginConstRefPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_NdrDiscoveryPluginConstRefPtrVector")]
		public static extern void delete_NdrDiscoveryPluginConstRefPtrVector(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_NdrDiscoveryPlugin")]
		public static extern void delete_NdrDiscoveryPlugin(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPlugin_DiscoverNodes")]
		public static extern IntPtr NdrDiscoveryPlugin_DiscoverNodes(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPlugin_GetSearchURIs")]
		public static extern IntPtr NdrDiscoveryPlugin_GetSearchURIs(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginFactoryBase_New")]
		public static extern IntPtr NdrDiscoveryPluginFactoryBase_New(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_NdrDiscoveryPluginFactoryBase")]
		public static extern void delete_NdrDiscoveryPluginFactoryBase(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginPtrVector_Clear")]
		public static extern void _NdrFilesystemDiscoveryPluginPtrVector_Clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginPtrVector_Add")]
		public static extern void _NdrFilesystemDiscoveryPluginPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginPtrVector_size")]
		public static extern uint _NdrFilesystemDiscoveryPluginPtrVector_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginPtrVector_capacity")]
		public static extern uint _NdrFilesystemDiscoveryPluginPtrVector_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginPtrVector_reserve")]
		public static extern void _NdrFilesystemDiscoveryPluginPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new__NdrFilesystemDiscoveryPluginPtrVector__SWIG_0")]
		public static extern IntPtr new__NdrFilesystemDiscoveryPluginPtrVector__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new__NdrFilesystemDiscoveryPluginPtrVector__SWIG_1")]
		public static extern IntPtr new__NdrFilesystemDiscoveryPluginPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new__NdrFilesystemDiscoveryPluginPtrVector__SWIG_2")]
		public static extern IntPtr new__NdrFilesystemDiscoveryPluginPtrVector__SWIG_2(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginPtrVector_getitemcopy")]
		public static extern IntPtr _NdrFilesystemDiscoveryPluginPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginPtrVector_getitem")]
		public static extern IntPtr _NdrFilesystemDiscoveryPluginPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginPtrVector_setitem")]
		public static extern void _NdrFilesystemDiscoveryPluginPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginPtrVector_AddRange")]
		public static extern void _NdrFilesystemDiscoveryPluginPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginPtrVector_GetRange")]
		public static extern IntPtr _NdrFilesystemDiscoveryPluginPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginPtrVector_Insert")]
		public static extern void _NdrFilesystemDiscoveryPluginPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginPtrVector_InsertRange")]
		public static extern void _NdrFilesystemDiscoveryPluginPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginPtrVector_RemoveAt")]
		public static extern void _NdrFilesystemDiscoveryPluginPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginPtrVector_RemoveRange")]
		public static extern void _NdrFilesystemDiscoveryPluginPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginPtrVector_Repeat")]
		public static extern IntPtr _NdrFilesystemDiscoveryPluginPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginPtrVector_Reverse__SWIG_0")]
		public static extern void _NdrFilesystemDiscoveryPluginPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginPtrVector_Reverse__SWIG_1")]
		public static extern void _NdrFilesystemDiscoveryPluginPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginPtrVector_SetRange")]
		public static extern void _NdrFilesystemDiscoveryPluginPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete__NdrFilesystemDiscoveryPluginPtrVector")]
		public static extern void delete__NdrFilesystemDiscoveryPluginPtrVector(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstPtrVector_Clear")]
		public static extern void _NdrFilesystemDiscoveryPluginConstPtrVector_Clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstPtrVector_Add")]
		public static extern void _NdrFilesystemDiscoveryPluginConstPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstPtrVector_size")]
		public static extern uint _NdrFilesystemDiscoveryPluginConstPtrVector_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstPtrVector_capacity")]
		public static extern uint _NdrFilesystemDiscoveryPluginConstPtrVector_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstPtrVector_reserve")]
		public static extern void _NdrFilesystemDiscoveryPluginConstPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new__NdrFilesystemDiscoveryPluginConstPtrVector__SWIG_0")]
		public static extern IntPtr new__NdrFilesystemDiscoveryPluginConstPtrVector__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new__NdrFilesystemDiscoveryPluginConstPtrVector__SWIG_1")]
		public static extern IntPtr new__NdrFilesystemDiscoveryPluginConstPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new__NdrFilesystemDiscoveryPluginConstPtrVector__SWIG_2")]
		public static extern IntPtr new__NdrFilesystemDiscoveryPluginConstPtrVector__SWIG_2(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstPtrVector_getitemcopy")]
		public static extern IntPtr _NdrFilesystemDiscoveryPluginConstPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstPtrVector_getitem")]
		public static extern IntPtr _NdrFilesystemDiscoveryPluginConstPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstPtrVector_setitem")]
		public static extern void _NdrFilesystemDiscoveryPluginConstPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstPtrVector_AddRange")]
		public static extern void _NdrFilesystemDiscoveryPluginConstPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstPtrVector_GetRange")]
		public static extern IntPtr _NdrFilesystemDiscoveryPluginConstPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstPtrVector_Insert")]
		public static extern void _NdrFilesystemDiscoveryPluginConstPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstPtrVector_InsertRange")]
		public static extern void _NdrFilesystemDiscoveryPluginConstPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstPtrVector_RemoveAt")]
		public static extern void _NdrFilesystemDiscoveryPluginConstPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstPtrVector_RemoveRange")]
		public static extern void _NdrFilesystemDiscoveryPluginConstPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstPtrVector_Repeat")]
		public static extern IntPtr _NdrFilesystemDiscoveryPluginConstPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstPtrVector_Reverse__SWIG_0")]
		public static extern void _NdrFilesystemDiscoveryPluginConstPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstPtrVector_Reverse__SWIG_1")]
		public static extern void _NdrFilesystemDiscoveryPluginConstPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstPtrVector_SetRange")]
		public static extern void _NdrFilesystemDiscoveryPluginConstPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete__NdrFilesystemDiscoveryPluginConstPtrVector")]
		public static extern void delete__NdrFilesystemDiscoveryPluginConstPtrVector(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginRefPtrVector_Clear")]
		public static extern void _NdrFilesystemDiscoveryPluginRefPtrVector_Clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginRefPtrVector_Add")]
		public static extern void _NdrFilesystemDiscoveryPluginRefPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginRefPtrVector_size")]
		public static extern uint _NdrFilesystemDiscoveryPluginRefPtrVector_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginRefPtrVector_capacity")]
		public static extern uint _NdrFilesystemDiscoveryPluginRefPtrVector_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginRefPtrVector_reserve")]
		public static extern void _NdrFilesystemDiscoveryPluginRefPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new__NdrFilesystemDiscoveryPluginRefPtrVector__SWIG_0")]
		public static extern IntPtr new__NdrFilesystemDiscoveryPluginRefPtrVector__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new__NdrFilesystemDiscoveryPluginRefPtrVector__SWIG_1")]
		public static extern IntPtr new__NdrFilesystemDiscoveryPluginRefPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new__NdrFilesystemDiscoveryPluginRefPtrVector__SWIG_2")]
		public static extern IntPtr new__NdrFilesystemDiscoveryPluginRefPtrVector__SWIG_2(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginRefPtrVector_getitemcopy")]
		public static extern IntPtr _NdrFilesystemDiscoveryPluginRefPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginRefPtrVector_getitem")]
		public static extern IntPtr _NdrFilesystemDiscoveryPluginRefPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginRefPtrVector_setitem")]
		public static extern void _NdrFilesystemDiscoveryPluginRefPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginRefPtrVector_AddRange")]
		public static extern void _NdrFilesystemDiscoveryPluginRefPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginRefPtrVector_GetRange")]
		public static extern IntPtr _NdrFilesystemDiscoveryPluginRefPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginRefPtrVector_Insert")]
		public static extern void _NdrFilesystemDiscoveryPluginRefPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginRefPtrVector_InsertRange")]
		public static extern void _NdrFilesystemDiscoveryPluginRefPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginRefPtrVector_RemoveAt")]
		public static extern void _NdrFilesystemDiscoveryPluginRefPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginRefPtrVector_RemoveRange")]
		public static extern void _NdrFilesystemDiscoveryPluginRefPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginRefPtrVector_Repeat")]
		public static extern IntPtr _NdrFilesystemDiscoveryPluginRefPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginRefPtrVector_Reverse__SWIG_0")]
		public static extern void _NdrFilesystemDiscoveryPluginRefPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginRefPtrVector_Reverse__SWIG_1")]
		public static extern void _NdrFilesystemDiscoveryPluginRefPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginRefPtrVector_SetRange")]
		public static extern void _NdrFilesystemDiscoveryPluginRefPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete__NdrFilesystemDiscoveryPluginRefPtrVector")]
		public static extern void delete__NdrFilesystemDiscoveryPluginRefPtrVector(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstRefPtrVector_Clear")]
		public static extern void _NdrFilesystemDiscoveryPluginConstRefPtrVector_Clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstRefPtrVector_Add")]
		public static extern void _NdrFilesystemDiscoveryPluginConstRefPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstRefPtrVector_size")]
		public static extern uint _NdrFilesystemDiscoveryPluginConstRefPtrVector_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstRefPtrVector_capacity")]
		public static extern uint _NdrFilesystemDiscoveryPluginConstRefPtrVector_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstRefPtrVector_reserve")]
		public static extern void _NdrFilesystemDiscoveryPluginConstRefPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new__NdrFilesystemDiscoveryPluginConstRefPtrVector__SWIG_0")]
		public static extern IntPtr new__NdrFilesystemDiscoveryPluginConstRefPtrVector__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new__NdrFilesystemDiscoveryPluginConstRefPtrVector__SWIG_1")]
		public static extern IntPtr new__NdrFilesystemDiscoveryPluginConstRefPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new__NdrFilesystemDiscoveryPluginConstRefPtrVector__SWIG_2")]
		public static extern IntPtr new__NdrFilesystemDiscoveryPluginConstRefPtrVector__SWIG_2(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstRefPtrVector_getitemcopy")]
		public static extern IntPtr _NdrFilesystemDiscoveryPluginConstRefPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstRefPtrVector_getitem")]
		public static extern IntPtr _NdrFilesystemDiscoveryPluginConstRefPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstRefPtrVector_setitem")]
		public static extern void _NdrFilesystemDiscoveryPluginConstRefPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstRefPtrVector_AddRange")]
		public static extern void _NdrFilesystemDiscoveryPluginConstRefPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstRefPtrVector_GetRange")]
		public static extern IntPtr _NdrFilesystemDiscoveryPluginConstRefPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstRefPtrVector_Insert")]
		public static extern void _NdrFilesystemDiscoveryPluginConstRefPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstRefPtrVector_InsertRange")]
		public static extern void _NdrFilesystemDiscoveryPluginConstRefPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstRefPtrVector_RemoveAt")]
		public static extern void _NdrFilesystemDiscoveryPluginConstRefPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstRefPtrVector_RemoveRange")]
		public static extern void _NdrFilesystemDiscoveryPluginConstRefPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstRefPtrVector_Repeat")]
		public static extern IntPtr _NdrFilesystemDiscoveryPluginConstRefPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstRefPtrVector_Reverse__SWIG_0")]
		public static extern void _NdrFilesystemDiscoveryPluginConstRefPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstRefPtrVector_Reverse__SWIG_1")]
		public static extern void _NdrFilesystemDiscoveryPluginConstRefPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr__NdrFilesystemDiscoveryPluginConstRefPtrVector_SetRange")]
		public static extern void _NdrFilesystemDiscoveryPluginConstRefPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete__NdrFilesystemDiscoveryPluginConstRefPtrVector")]
		public static extern void delete__NdrFilesystemDiscoveryPluginConstRefPtrVector(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrFsHelpersSplitShaderIdentifier")]
		public static extern bool NdrFsHelpersSplitShaderIdentifier(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrFsHelpersDiscoverNodes__SWIG_0")]
		public static extern IntPtr NdrFsHelpersDiscoverNodes__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrFsHelpersDiscoverNodes__SWIG_1")]
		public static extern IntPtr NdrFsHelpersDiscoverNodes__SWIG_1(HandleRef jarg1, HandleRef jarg2, bool jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrFsHelpersDiscoverNodes__SWIG_2")]
		public static extern IntPtr NdrFsHelpersDiscoverNodes__SWIG_2(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrFsHelpersDiscoverNodes__SWIG_3")]
		public static extern IntPtr NdrFsHelpersDiscoverNodes__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryUri_uri_set")]
		public static extern void NdrDiscoveryUri_uri_set(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryUri_uri_get")]
		public static extern string NdrDiscoveryUri_uri_get(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryUri_resolvedUri_set")]
		public static extern void NdrDiscoveryUri_resolvedUri_set(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryUri_resolvedUri_get")]
		public static extern string NdrDiscoveryUri_resolvedUri_get(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrDiscoveryUri")]
		public static extern IntPtr new_NdrDiscoveryUri();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_NdrDiscoveryUri")]
		public static extern void delete_NdrDiscoveryUri(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrFsHelpersDiscoverFiles__SWIG_0")]
		public static extern IntPtr NdrFsHelpersDiscoverFiles__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrFsHelpersDiscoverFiles__SWIG_1")]
		public static extern IntPtr NdrFsHelpersDiscoverFiles__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_NdrNode")]
		public static extern void delete_NdrNode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNode_GetIdentifier")]
		public static extern IntPtr NdrNode_GetIdentifier(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNode_GetVersion")]
		public static extern IntPtr NdrNode_GetVersion(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNode_GetName")]
		public static extern string NdrNode_GetName(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNode_GetFamily")]
		public static extern IntPtr NdrNode_GetFamily(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNode_GetContext")]
		public static extern IntPtr NdrNode_GetContext(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNode_GetSourceType")]
		public static extern IntPtr NdrNode_GetSourceType(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNode_GetResolvedDefinitionURI")]
		public static extern string NdrNode_GetResolvedDefinitionURI(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNode_GetResolvedImplementationURI")]
		public static extern string NdrNode_GetResolvedImplementationURI(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNode_GetSourceCode")]
		public static extern string NdrNode_GetSourceCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNode_IsValid")]
		public static extern bool NdrNode_IsValid(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNode_GetInfoString")]
		public static extern string NdrNode_GetInfoString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNode_GetInputNames")]
		public static extern IntPtr NdrNode_GetInputNames(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNode_GetOutputNames")]
		public static extern IntPtr NdrNode_GetOutputNames(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNode_GetInput")]
		public static extern IntPtr NdrNode_GetInput(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNode_GetOutput")]
		public static extern IntPtr NdrNode_GetOutput(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNode_GetMetadata")]
		public static extern IntPtr NdrNode_GetMetadata(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResultVector_Clear")]
		public static extern void NdrNodeDiscoveryResultVector_Clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResultVector_Add")]
		public static extern void NdrNodeDiscoveryResultVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResultVector_size")]
		public static extern uint NdrNodeDiscoveryResultVector_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResultVector_capacity")]
		public static extern uint NdrNodeDiscoveryResultVector_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResultVector_reserve")]
		public static extern void NdrNodeDiscoveryResultVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrNodeDiscoveryResultVector__SWIG_0")]
		public static extern IntPtr new_NdrNodeDiscoveryResultVector__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrNodeDiscoveryResultVector__SWIG_1")]
		public static extern IntPtr new_NdrNodeDiscoveryResultVector__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrNodeDiscoveryResultVector__SWIG_2")]
		public static extern IntPtr new_NdrNodeDiscoveryResultVector__SWIG_2(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResultVector_getitemcopy")]
		public static extern IntPtr NdrNodeDiscoveryResultVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResultVector_getitem")]
		public static extern IntPtr NdrNodeDiscoveryResultVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResultVector_setitem")]
		public static extern void NdrNodeDiscoveryResultVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResultVector_AddRange")]
		public static extern void NdrNodeDiscoveryResultVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResultVector_GetRange")]
		public static extern IntPtr NdrNodeDiscoveryResultVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResultVector_Insert")]
		public static extern void NdrNodeDiscoveryResultVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResultVector_InsertRange")]
		public static extern void NdrNodeDiscoveryResultVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResultVector_RemoveAt")]
		public static extern void NdrNodeDiscoveryResultVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResultVector_RemoveRange")]
		public static extern void NdrNodeDiscoveryResultVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResultVector_Repeat")]
		public static extern IntPtr NdrNodeDiscoveryResultVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResultVector_Reverse__SWIG_0")]
		public static extern void NdrNodeDiscoveryResultVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResultVector_Reverse__SWIG_1")]
		public static extern void NdrNodeDiscoveryResultVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResultVector_SetRange")]
		public static extern void NdrNodeDiscoveryResultVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_NdrNodeDiscoveryResultVector")]
		public static extern void delete_NdrNodeDiscoveryResultVector(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrNodeDiscoveryResult__SWIG_0")]
		public static extern IntPtr new_NdrNodeDiscoveryResult__SWIG_0(HandleRef jarg1, HandleRef jarg2, string jarg3, HandleRef jarg4, HandleRef jarg5, HandleRef jarg6, string jarg7, string jarg8, string jarg9, HandleRef jarg10, string jarg11, HandleRef jarg12);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrNodeDiscoveryResult__SWIG_1")]
		public static extern IntPtr new_NdrNodeDiscoveryResult__SWIG_1(HandleRef jarg1, HandleRef jarg2, string jarg3, HandleRef jarg4, HandleRef jarg5, HandleRef jarg6, string jarg7, string jarg8, string jarg9, HandleRef jarg10, string jarg11);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrNodeDiscoveryResult__SWIG_2")]
		public static extern IntPtr new_NdrNodeDiscoveryResult__SWIG_2(HandleRef jarg1, HandleRef jarg2, string jarg3, HandleRef jarg4, HandleRef jarg5, HandleRef jarg6, string jarg7, string jarg8, string jarg9, HandleRef jarg10);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrNodeDiscoveryResult__SWIG_3")]
		public static extern IntPtr new_NdrNodeDiscoveryResult__SWIG_3(HandleRef jarg1, HandleRef jarg2, string jarg3, HandleRef jarg4, HandleRef jarg5, HandleRef jarg6, string jarg7, string jarg8, string jarg9);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrNodeDiscoveryResult__SWIG_4")]
		public static extern IntPtr new_NdrNodeDiscoveryResult__SWIG_4(HandleRef jarg1, HandleRef jarg2, string jarg3, HandleRef jarg4, HandleRef jarg5, HandleRef jarg6, string jarg7, string jarg8);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResult_identifier_set")]
		public static extern void NdrNodeDiscoveryResult_identifier_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResult_identifier_get")]
		public static extern IntPtr NdrNodeDiscoveryResult_identifier_get(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResult_version_set")]
		public static extern void NdrNodeDiscoveryResult_version_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResult_version_get")]
		public static extern IntPtr NdrNodeDiscoveryResult_version_get(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResult_name_set")]
		public static extern void NdrNodeDiscoveryResult_name_set(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResult_name_get")]
		public static extern string NdrNodeDiscoveryResult_name_get(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResult_family_set")]
		public static extern void NdrNodeDiscoveryResult_family_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResult_family_get")]
		public static extern IntPtr NdrNodeDiscoveryResult_family_get(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResult_discoveryType_set")]
		public static extern void NdrNodeDiscoveryResult_discoveryType_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResult_discoveryType_get")]
		public static extern IntPtr NdrNodeDiscoveryResult_discoveryType_get(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResult_sourceType_set")]
		public static extern void NdrNodeDiscoveryResult_sourceType_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResult_sourceType_get")]
		public static extern IntPtr NdrNodeDiscoveryResult_sourceType_get(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResult_uri_set")]
		public static extern void NdrNodeDiscoveryResult_uri_set(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResult_uri_get")]
		public static extern string NdrNodeDiscoveryResult_uri_get(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResult_resolvedUri_set")]
		public static extern void NdrNodeDiscoveryResult_resolvedUri_set(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResult_resolvedUri_get")]
		public static extern string NdrNodeDiscoveryResult_resolvedUri_get(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResult_sourceCode_set")]
		public static extern void NdrNodeDiscoveryResult_sourceCode_set(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResult_sourceCode_get")]
		public static extern string NdrNodeDiscoveryResult_sourceCode_get(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResult_metadata_set")]
		public static extern void NdrNodeDiscoveryResult_metadata_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResult_metadata_get")]
		public static extern IntPtr NdrNodeDiscoveryResult_metadata_get(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResult_blindData_set")]
		public static extern void NdrNodeDiscoveryResult_blindData_set(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResult_blindData_get")]
		public static extern string NdrNodeDiscoveryResult_blindData_get(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResult_subIdentifier_set")]
		public static extern void NdrNodeDiscoveryResult_subIdentifier_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrNodeDiscoveryResult_subIdentifier_get")]
		public static extern IntPtr NdrNodeDiscoveryResult_subIdentifier_get(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_NdrNodeDiscoveryResult")]
		public static extern void delete_NdrNodeDiscoveryResult(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_NdrParserPlugin")]
		public static extern void delete_NdrParserPlugin(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrParserPlugin_GetDiscoveryTypes")]
		public static extern IntPtr NdrParserPlugin_GetDiscoveryTypes(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrParserPlugin_GetSourceType")]
		public static extern IntPtr NdrParserPlugin_GetSourceType(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrParserPluginFactoryBase_New")]
		public static extern IntPtr NdrParserPluginFactoryBase_New(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_NdrParserPluginFactoryBase")]
		public static extern void delete_NdrParserPluginFactoryBase(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_NdrProperty")]
		public static extern IntPtr new_NdrProperty(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4, uint jarg5, bool jarg6, HandleRef jarg7);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_NdrProperty")]
		public static extern void delete_NdrProperty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrProperty_GetName")]
		public static extern IntPtr NdrProperty_GetName(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrProperty_GetTfType")]
		public static extern IntPtr NdrProperty_GetTfType(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrProperty_GetDefaultValue")]
		public static extern IntPtr NdrProperty_GetDefaultValue(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrProperty_IsOutput")]
		public static extern bool NdrProperty_IsOutput(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrProperty_IsArray")]
		public static extern bool NdrProperty_IsArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrProperty_IsDynamicArray")]
		public static extern bool NdrProperty_IsDynamicArray(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrProperty_GetArraySize")]
		public static extern int NdrProperty_GetArraySize(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrProperty_GetInfoString")]
		public static extern string NdrProperty_GetInfoString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrProperty_GetMetadata")]
		public static extern IntPtr NdrProperty_GetMetadata(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrProperty_IsConnectable")]
		public static extern bool NdrProperty_IsConnectable(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrProperty_CanConnectTo")]
		public static extern bool NdrProperty_CanConnectTo(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrProperty_GetTypeAsSdfType")]
		public static extern IntPtr NdrProperty_GetTypeAsSdfType(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrProperty_GetDefaultValueAsSdfType")]
		public static extern IntPtr NdrProperty_GetDefaultValueAsSdfType(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_SetExtraDiscoveryPlugins__SWIG_0")]
		public static extern void NdrRegistry_SetExtraDiscoveryPlugins__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_SetExtraDiscoveryPlugins__SWIG_1")]
		public static extern void NdrRegistry_SetExtraDiscoveryPlugins__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_AddDiscoveryResult__SWIG_0")]
		public static extern void NdrRegistry_AddDiscoveryResult__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_SetExtraParserPlugins")]
		public static extern void NdrRegistry_SetExtraParserPlugins(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_GetNodeFromAsset__SWIG_0")]
		public static extern IntPtr NdrRegistry_GetNodeFromAsset__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_GetNodeFromAsset__SWIG_1")]
		public static extern IntPtr NdrRegistry_GetNodeFromAsset__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_GetNodeFromAsset__SWIG_2")]
		public static extern IntPtr NdrRegistry_GetNodeFromAsset__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_GetNodeFromSourceCode")]
		public static extern IntPtr NdrRegistry_GetNodeFromSourceCode(HandleRef jarg1, string jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_GetSearchURIs")]
		public static extern IntPtr NdrRegistry_GetSearchURIs(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_GetNodeIdentifiers__SWIG_0")]
		public static extern IntPtr NdrRegistry_GetNodeIdentifiers__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_GetNodeIdentifiers__SWIG_1")]
		public static extern IntPtr NdrRegistry_GetNodeIdentifiers__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_GetNodeIdentifiers__SWIG_2")]
		public static extern IntPtr NdrRegistry_GetNodeIdentifiers__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_GetNodeNames__SWIG_0")]
		public static extern IntPtr NdrRegistry_GetNodeNames__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_GetNodeNames__SWIG_1")]
		public static extern IntPtr NdrRegistry_GetNodeNames__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_GetNodeByIdentifier__SWIG_0")]
		public static extern IntPtr NdrRegistry_GetNodeByIdentifier__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_GetNodeByIdentifier__SWIG_1")]
		public static extern IntPtr NdrRegistry_GetNodeByIdentifier__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_GetNodeByIdentifierAndType")]
		public static extern IntPtr NdrRegistry_GetNodeByIdentifierAndType(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_GetNodeByName__SWIG_0")]
		public static extern IntPtr NdrRegistry_GetNodeByName__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3, int jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_GetNodeByName__SWIG_1")]
		public static extern IntPtr NdrRegistry_GetNodeByName__SWIG_1(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_GetNodeByName__SWIG_2")]
		public static extern IntPtr NdrRegistry_GetNodeByName__SWIG_2(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_GetNodeByNameAndType__SWIG_0")]
		public static extern IntPtr NdrRegistry_GetNodeByNameAndType__SWIG_0(HandleRef jarg1, string jarg2, HandleRef jarg3, int jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_GetNodeByNameAndType__SWIG_1")]
		public static extern IntPtr NdrRegistry_GetNodeByNameAndType__SWIG_1(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_GetNodesByIdentifier")]
		public static extern IntPtr NdrRegistry_GetNodesByIdentifier(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_GetNodesByName__SWIG_0")]
		public static extern IntPtr NdrRegistry_GetNodesByName__SWIG_0(HandleRef jarg1, string jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_GetNodesByName__SWIG_1")]
		public static extern IntPtr NdrRegistry_GetNodesByName__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_GetNodesByFamily__SWIG_0")]
		public static extern IntPtr NdrRegistry_GetNodesByFamily__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_GetNodesByFamily__SWIG_1")]
		public static extern IntPtr NdrRegistry_GetNodesByFamily__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_GetNodesByFamily__SWIG_2")]
		public static extern IntPtr NdrRegistry_GetNodesByFamily__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrRegistry_GetAllNodeSourceTypes")]
		public static extern IntPtr NdrRegistry_GetAllNodeSourceTypes(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrDiscoveryPluginFactoryBase_SWIGUpcast")]
		public static extern IntPtr NdrDiscoveryPluginFactoryBase_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_NdrParserPluginFactoryBase_SWIGUpcast")]
		public static extern IntPtr NdrParserPluginFactoryBase_SWIGUpcast(IntPtr jarg1);
	}
}
