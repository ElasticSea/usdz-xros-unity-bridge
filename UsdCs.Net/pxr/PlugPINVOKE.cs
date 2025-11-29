using System;
using System.Runtime.InteropServices;

namespace pxr
{
	internal class PlugPINVOKE
	{
		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			[DllImport(UsdDll.USD_EXPORT_NAME)]
			public static extern void SWIGRegisterStringCallback_Plug(SWIGStringDelegate stringDelegate);

			[MonoPInvokeCallback]
			private static string CreateString(string cString)
			{
				return cString;
			}

			static SWIGStringHelper()
			{
				stringDelegate = CreateString;
				SWIGRegisterStringCallback_Plug(stringDelegate);
			}
		}

		public class SWIGPendingException : UsdCsPINVOKE.SWIGPendingException
		{
		}

		protected static SWIGStringHelper swigStringHelper;

		static PlugPINVOKE()
		{
			swigStringHelper = new SWIGStringHelper();
		}

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginPtrVector_Clear")]
		public static extern void PlugPluginPtrVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginPtrVector_Add")]
		public static extern void PlugPluginPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginPtrVector_size")]
		public static extern uint PlugPluginPtrVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginPtrVector_capacity")]
		public static extern uint PlugPluginPtrVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginPtrVector_reserve")]
		public static extern void PlugPluginPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PlugPluginPtrVector__SWIG_0")]
		public static extern IntPtr new_PlugPluginPtrVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PlugPluginPtrVector__SWIG_1")]
		public static extern IntPtr new_PlugPluginPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PlugPluginPtrVector__SWIG_2")]
		public static extern IntPtr new_PlugPluginPtrVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginPtrVector_getitemcopy")]
		public static extern IntPtr PlugPluginPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginPtrVector_getitem")]
		public static extern IntPtr PlugPluginPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginPtrVector_setitem")]
		public static extern void PlugPluginPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginPtrVector_AddRange")]
		public static extern void PlugPluginPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginPtrVector_GetRange")]
		public static extern IntPtr PlugPluginPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginPtrVector_Insert")]
		public static extern void PlugPluginPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginPtrVector_InsertRange")]
		public static extern void PlugPluginPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginPtrVector_RemoveAt")]
		public static extern void PlugPluginPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginPtrVector_RemoveRange")]
		public static extern void PlugPluginPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginPtrVector_Repeat")]
		public static extern IntPtr PlugPluginPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginPtrVector_Reverse__SWIG_0")]
		public static extern void PlugPluginPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginPtrVector_Reverse__SWIG_1")]
		public static extern void PlugPluginPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginPtrVector_SetRange")]
		public static extern void PlugPluginPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PlugPluginPtrVector")]
		public static extern void delete_PlugPluginPtrVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstPtrVector_Clear")]
		public static extern void PlugPluginConstPtrVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstPtrVector_Add")]
		public static extern void PlugPluginConstPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstPtrVector_size")]
		public static extern uint PlugPluginConstPtrVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstPtrVector_capacity")]
		public static extern uint PlugPluginConstPtrVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstPtrVector_reserve")]
		public static extern void PlugPluginConstPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PlugPluginConstPtrVector__SWIG_0")]
		public static extern IntPtr new_PlugPluginConstPtrVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PlugPluginConstPtrVector__SWIG_1")]
		public static extern IntPtr new_PlugPluginConstPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PlugPluginConstPtrVector__SWIG_2")]
		public static extern IntPtr new_PlugPluginConstPtrVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstPtrVector_getitemcopy")]
		public static extern IntPtr PlugPluginConstPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstPtrVector_getitem")]
		public static extern IntPtr PlugPluginConstPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstPtrVector_setitem")]
		public static extern void PlugPluginConstPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstPtrVector_AddRange")]
		public static extern void PlugPluginConstPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstPtrVector_GetRange")]
		public static extern IntPtr PlugPluginConstPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstPtrVector_Insert")]
		public static extern void PlugPluginConstPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstPtrVector_InsertRange")]
		public static extern void PlugPluginConstPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstPtrVector_RemoveAt")]
		public static extern void PlugPluginConstPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstPtrVector_RemoveRange")]
		public static extern void PlugPluginConstPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstPtrVector_Repeat")]
		public static extern IntPtr PlugPluginConstPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstPtrVector_Reverse__SWIG_0")]
		public static extern void PlugPluginConstPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstPtrVector_Reverse__SWIG_1")]
		public static extern void PlugPluginConstPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstPtrVector_SetRange")]
		public static extern void PlugPluginConstPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PlugPluginConstPtrVector")]
		public static extern void delete_PlugPluginConstPtrVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginRefPtrVector_Clear")]
		public static extern void PlugPluginRefPtrVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginRefPtrVector_Add")]
		public static extern void PlugPluginRefPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginRefPtrVector_size")]
		public static extern uint PlugPluginRefPtrVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginRefPtrVector_capacity")]
		public static extern uint PlugPluginRefPtrVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginRefPtrVector_reserve")]
		public static extern void PlugPluginRefPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PlugPluginRefPtrVector__SWIG_0")]
		public static extern IntPtr new_PlugPluginRefPtrVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PlugPluginRefPtrVector__SWIG_1")]
		public static extern IntPtr new_PlugPluginRefPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PlugPluginRefPtrVector__SWIG_2")]
		public static extern IntPtr new_PlugPluginRefPtrVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginRefPtrVector_getitemcopy")]
		public static extern IntPtr PlugPluginRefPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginRefPtrVector_getitem")]
		public static extern IntPtr PlugPluginRefPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginRefPtrVector_setitem")]
		public static extern void PlugPluginRefPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginRefPtrVector_AddRange")]
		public static extern void PlugPluginRefPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginRefPtrVector_GetRange")]
		public static extern IntPtr PlugPluginRefPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginRefPtrVector_Insert")]
		public static extern void PlugPluginRefPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginRefPtrVector_InsertRange")]
		public static extern void PlugPluginRefPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginRefPtrVector_RemoveAt")]
		public static extern void PlugPluginRefPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginRefPtrVector_RemoveRange")]
		public static extern void PlugPluginRefPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginRefPtrVector_Repeat")]
		public static extern IntPtr PlugPluginRefPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginRefPtrVector_Reverse__SWIG_0")]
		public static extern void PlugPluginRefPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginRefPtrVector_Reverse__SWIG_1")]
		public static extern void PlugPluginRefPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginRefPtrVector_SetRange")]
		public static extern void PlugPluginRefPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PlugPluginRefPtrVector")]
		public static extern void delete_PlugPluginRefPtrVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstRefPtrVector_Clear")]
		public static extern void PlugPluginConstRefPtrVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstRefPtrVector_Add")]
		public static extern void PlugPluginConstRefPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstRefPtrVector_size")]
		public static extern uint PlugPluginConstRefPtrVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstRefPtrVector_capacity")]
		public static extern uint PlugPluginConstRefPtrVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstRefPtrVector_reserve")]
		public static extern void PlugPluginConstRefPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PlugPluginConstRefPtrVector__SWIG_0")]
		public static extern IntPtr new_PlugPluginConstRefPtrVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PlugPluginConstRefPtrVector__SWIG_1")]
		public static extern IntPtr new_PlugPluginConstRefPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PlugPluginConstRefPtrVector__SWIG_2")]
		public static extern IntPtr new_PlugPluginConstRefPtrVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstRefPtrVector_getitemcopy")]
		public static extern IntPtr PlugPluginConstRefPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstRefPtrVector_getitem")]
		public static extern IntPtr PlugPluginConstRefPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstRefPtrVector_setitem")]
		public static extern void PlugPluginConstRefPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstRefPtrVector_AddRange")]
		public static extern void PlugPluginConstRefPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstRefPtrVector_GetRange")]
		public static extern IntPtr PlugPluginConstRefPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstRefPtrVector_Insert")]
		public static extern void PlugPluginConstRefPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstRefPtrVector_InsertRange")]
		public static extern void PlugPluginConstRefPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstRefPtrVector_RemoveAt")]
		public static extern void PlugPluginConstRefPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstRefPtrVector_RemoveRange")]
		public static extern void PlugPluginConstRefPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstRefPtrVector_Repeat")]
		public static extern IntPtr PlugPluginConstRefPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstRefPtrVector_Reverse__SWIG_0")]
		public static extern void PlugPluginConstRefPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstRefPtrVector_Reverse__SWIG_1")]
		public static extern void PlugPluginConstRefPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPluginConstRefPtrVector_SetRange")]
		public static extern void PlugPluginConstRefPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PlugPluginConstRefPtrVector")]
		public static extern void delete_PlugPluginConstRefPtrVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PlugPlugin")]
		public static extern void delete_PlugPlugin(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPlugin_Load")]
		public static extern bool PlugPlugin_Load(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPlugin_IsLoaded")]
		public static extern bool PlugPlugin_IsLoaded(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPlugin_IsResource")]
		public static extern bool PlugPlugin_IsResource(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPlugin_GetMetadata")]
		public static extern IntPtr PlugPlugin_GetMetadata(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPlugin_GetMetadataForType")]
		public static extern IntPtr PlugPlugin_GetMetadataForType(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPlugin_GetDependencies")]
		public static extern IntPtr PlugPlugin_GetDependencies(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPlugin_DeclaresType__SWIG_0")]
		public static extern bool PlugPlugin_DeclaresType__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPlugin_DeclaresType__SWIG_1")]
		public static extern bool PlugPlugin_DeclaresType__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPlugin_GetName")]
		public static extern string PlugPlugin_GetName(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPlugin_GetPath")]
		public static extern string PlugPlugin_GetPath(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPlugin_GetResourcePath")]
		public static extern string PlugPlugin_GetResourcePath(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPlugin_MakeResourcePath")]
		public static extern string PlugPlugin_MakeResourcePath(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPlugin_FindPluginResource__SWIG_0")]
		public static extern string PlugPlugin_FindPluginResource__SWIG_0(HandleRef jarg1, string jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugPlugin_FindPluginResource__SWIG_1")]
		public static extern string PlugPlugin_FindPluginResource__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugFindPluginResource__SWIG_0")]
		public static extern string PlugFindPluginResource__SWIG_0(HandleRef jarg1, string jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugFindPluginResource__SWIG_1")]
		public static extern string PlugFindPluginResource__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugRegistry_GetInstance")]
		public static extern IntPtr PlugRegistry_GetInstance();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugRegistry_RegisterPlugins__SWIG_0")]
		public static extern IntPtr PlugRegistry_RegisterPlugins__SWIG_0(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugRegistry_RegisterPlugins__SWIG_1")]
		public static extern IntPtr PlugRegistry_RegisterPlugins__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugRegistry_FindTypeByName")]
		public static extern IntPtr PlugRegistry_FindTypeByName(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugRegistry_FindDerivedTypeByName")]
		public static extern IntPtr PlugRegistry_FindDerivedTypeByName(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugRegistry_GetDirectlyDerivedTypes")]
		public static extern IntPtr PlugRegistry_GetDirectlyDerivedTypes(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugRegistry_GetAllDerivedTypes")]
		public static extern void PlugRegistry_GetAllDerivedTypes(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugRegistry_GetPluginForType")]
		public static extern IntPtr PlugRegistry_GetPluginForType(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugRegistry_GetAllPlugins")]
		public static extern IntPtr PlugRegistry_GetAllPlugins(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugRegistry_GetPluginWithName")]
		public static extern IntPtr PlugRegistry_GetPluginWithName(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugRegistry_GetStringFromPluginMetaData")]
		public static extern string PlugRegistry_GetStringFromPluginMetaData(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PlugRegistry_GetDataFromPluginMetaData")]
		public static extern IntPtr PlugRegistry_GetDataFromPluginMetaData(HandleRef jarg1, HandleRef jarg2, string jarg3);
	}
}
