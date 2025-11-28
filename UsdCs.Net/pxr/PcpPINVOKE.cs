using System;
using System.Runtime.InteropServices;

namespace pxr
{
	internal class PcpPINVOKE
	{
		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			[DllImport(UsdDll.USD_EXPORT_NAME)]
			public static extern void SWIGRegisterStringCallback_Pcp(SWIGStringDelegate stringDelegate);

			[MonoPInvokeCallback]
			private static string CreateString(string cString)
			{
				return cString;
			}

			static SWIGStringHelper()
			{
				stringDelegate = CreateString;
				SWIGRegisterStringCallback_Pcp(stringDelegate);
			}
		}

		public class SWIGPendingException : UsdCsPINVOKE.SWIGPendingException
		{
		}

		protected static SWIGStringHelper swigStringHelper;

		static PcpPINVOKE()
		{
			swigStringHelper = new SWIGStringHelper();
		}

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpArc")]
		public static extern IntPtr new_PcpArc();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpArc_type_set")]
		public static extern void PcpArc_type_set(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpArc_type_get")]
		public static extern int PcpArc_type_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpArc_parent_set")]
		public static extern void PcpArc_parent_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpArc_parent_get")]
		public static extern IntPtr PcpArc_parent_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpArc_origin_set")]
		public static extern void PcpArc_origin_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpArc_origin_get")]
		public static extern IntPtr PcpArc_origin_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpArc_mapToParent_set")]
		public static extern void PcpArc_mapToParent_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpArc_mapToParent_get")]
		public static extern IntPtr PcpArc_mapToParent_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpArc_siblingNumAtOrigin_set")]
		public static extern void PcpArc_siblingNumAtOrigin_set(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpArc_siblingNumAtOrigin_get")]
		public static extern int PcpArc_siblingNumAtOrigin_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpArc_namespaceDepth_set")]
		public static extern void PcpArc_namespaceDepth_set(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpArc_namespaceDepth_get")]
		public static extern int PcpArc_namespaceDepth_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PcpArc")]
		public static extern void delete_PcpArc(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackPtrVector_Clear")]
		public static extern void PcpLayerStackPtrVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackPtrVector_Add")]
		public static extern void PcpLayerStackPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackPtrVector_size")]
		public static extern uint PcpLayerStackPtrVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackPtrVector_capacity")]
		public static extern uint PcpLayerStackPtrVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackPtrVector_reserve")]
		public static extern void PcpLayerStackPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpLayerStackPtrVector__SWIG_0")]
		public static extern IntPtr new_PcpLayerStackPtrVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpLayerStackPtrVector__SWIG_1")]
		public static extern IntPtr new_PcpLayerStackPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpLayerStackPtrVector__SWIG_2")]
		public static extern IntPtr new_PcpLayerStackPtrVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackPtrVector_getitemcopy")]
		public static extern IntPtr PcpLayerStackPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackPtrVector_getitem")]
		public static extern IntPtr PcpLayerStackPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackPtrVector_setitem")]
		public static extern void PcpLayerStackPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackPtrVector_AddRange")]
		public static extern void PcpLayerStackPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackPtrVector_GetRange")]
		public static extern IntPtr PcpLayerStackPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackPtrVector_Insert")]
		public static extern void PcpLayerStackPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackPtrVector_InsertRange")]
		public static extern void PcpLayerStackPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackPtrVector_RemoveAt")]
		public static extern void PcpLayerStackPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackPtrVector_RemoveRange")]
		public static extern void PcpLayerStackPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackPtrVector_Repeat")]
		public static extern IntPtr PcpLayerStackPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackPtrVector_Reverse__SWIG_0")]
		public static extern void PcpLayerStackPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackPtrVector_Reverse__SWIG_1")]
		public static extern void PcpLayerStackPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackPtrVector_SetRange")]
		public static extern void PcpLayerStackPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PcpLayerStackPtrVector")]
		public static extern void delete_PcpLayerStackPtrVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstPtrVector_Clear")]
		public static extern void PcpLayerStackConstPtrVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstPtrVector_Add")]
		public static extern void PcpLayerStackConstPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstPtrVector_size")]
		public static extern uint PcpLayerStackConstPtrVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstPtrVector_capacity")]
		public static extern uint PcpLayerStackConstPtrVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstPtrVector_reserve")]
		public static extern void PcpLayerStackConstPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpLayerStackConstPtrVector__SWIG_0")]
		public static extern IntPtr new_PcpLayerStackConstPtrVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpLayerStackConstPtrVector__SWIG_1")]
		public static extern IntPtr new_PcpLayerStackConstPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpLayerStackConstPtrVector__SWIG_2")]
		public static extern IntPtr new_PcpLayerStackConstPtrVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstPtrVector_getitemcopy")]
		public static extern IntPtr PcpLayerStackConstPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstPtrVector_getitem")]
		public static extern IntPtr PcpLayerStackConstPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstPtrVector_setitem")]
		public static extern void PcpLayerStackConstPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstPtrVector_AddRange")]
		public static extern void PcpLayerStackConstPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstPtrVector_GetRange")]
		public static extern IntPtr PcpLayerStackConstPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstPtrVector_Insert")]
		public static extern void PcpLayerStackConstPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstPtrVector_InsertRange")]
		public static extern void PcpLayerStackConstPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstPtrVector_RemoveAt")]
		public static extern void PcpLayerStackConstPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstPtrVector_RemoveRange")]
		public static extern void PcpLayerStackConstPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstPtrVector_Repeat")]
		public static extern IntPtr PcpLayerStackConstPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstPtrVector_Reverse__SWIG_0")]
		public static extern void PcpLayerStackConstPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstPtrVector_Reverse__SWIG_1")]
		public static extern void PcpLayerStackConstPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstPtrVector_SetRange")]
		public static extern void PcpLayerStackConstPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PcpLayerStackConstPtrVector")]
		public static extern void delete_PcpLayerStackConstPtrVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackRefPtrVector_Clear")]
		public static extern void PcpLayerStackRefPtrVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackRefPtrVector_Add")]
		public static extern void PcpLayerStackRefPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackRefPtrVector_size")]
		public static extern uint PcpLayerStackRefPtrVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackRefPtrVector_capacity")]
		public static extern uint PcpLayerStackRefPtrVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackRefPtrVector_reserve")]
		public static extern void PcpLayerStackRefPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpLayerStackRefPtrVector__SWIG_0")]
		public static extern IntPtr new_PcpLayerStackRefPtrVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpLayerStackRefPtrVector__SWIG_1")]
		public static extern IntPtr new_PcpLayerStackRefPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpLayerStackRefPtrVector__SWIG_2")]
		public static extern IntPtr new_PcpLayerStackRefPtrVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackRefPtrVector_getitemcopy")]
		public static extern IntPtr PcpLayerStackRefPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackRefPtrVector_getitem")]
		public static extern IntPtr PcpLayerStackRefPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackRefPtrVector_setitem")]
		public static extern void PcpLayerStackRefPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackRefPtrVector_AddRange")]
		public static extern void PcpLayerStackRefPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackRefPtrVector_GetRange")]
		public static extern IntPtr PcpLayerStackRefPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackRefPtrVector_Insert")]
		public static extern void PcpLayerStackRefPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackRefPtrVector_InsertRange")]
		public static extern void PcpLayerStackRefPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackRefPtrVector_RemoveAt")]
		public static extern void PcpLayerStackRefPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackRefPtrVector_RemoveRange")]
		public static extern void PcpLayerStackRefPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackRefPtrVector_Repeat")]
		public static extern IntPtr PcpLayerStackRefPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackRefPtrVector_Reverse__SWIG_0")]
		public static extern void PcpLayerStackRefPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackRefPtrVector_Reverse__SWIG_1")]
		public static extern void PcpLayerStackRefPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackRefPtrVector_SetRange")]
		public static extern void PcpLayerStackRefPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PcpLayerStackRefPtrVector")]
		public static extern void delete_PcpLayerStackRefPtrVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstRefPtrVector_Clear")]
		public static extern void PcpLayerStackConstRefPtrVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstRefPtrVector_Add")]
		public static extern void PcpLayerStackConstRefPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstRefPtrVector_size")]
		public static extern uint PcpLayerStackConstRefPtrVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstRefPtrVector_capacity")]
		public static extern uint PcpLayerStackConstRefPtrVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstRefPtrVector_reserve")]
		public static extern void PcpLayerStackConstRefPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpLayerStackConstRefPtrVector__SWIG_0")]
		public static extern IntPtr new_PcpLayerStackConstRefPtrVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpLayerStackConstRefPtrVector__SWIG_1")]
		public static extern IntPtr new_PcpLayerStackConstRefPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpLayerStackConstRefPtrVector__SWIG_2")]
		public static extern IntPtr new_PcpLayerStackConstRefPtrVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstRefPtrVector_getitemcopy")]
		public static extern IntPtr PcpLayerStackConstRefPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstRefPtrVector_getitem")]
		public static extern IntPtr PcpLayerStackConstRefPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstRefPtrVector_setitem")]
		public static extern void PcpLayerStackConstRefPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstRefPtrVector_AddRange")]
		public static extern void PcpLayerStackConstRefPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstRefPtrVector_GetRange")]
		public static extern IntPtr PcpLayerStackConstRefPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstRefPtrVector_Insert")]
		public static extern void PcpLayerStackConstRefPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstRefPtrVector_InsertRange")]
		public static extern void PcpLayerStackConstRefPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstRefPtrVector_RemoveAt")]
		public static extern void PcpLayerStackConstRefPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstRefPtrVector_RemoveRange")]
		public static extern void PcpLayerStackConstRefPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstRefPtrVector_Repeat")]
		public static extern IntPtr PcpLayerStackConstRefPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstRefPtrVector_Reverse__SWIG_0")]
		public static extern void PcpLayerStackConstRefPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstRefPtrVector_Reverse__SWIG_1")]
		public static extern void PcpLayerStackConstRefPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackConstRefPtrVector_SetRange")]
		public static extern void PcpLayerStackConstRefPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PcpLayerStackConstRefPtrVector")]
		public static extern void delete_PcpLayerStackConstRefPtrVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpCache__SWIG_0")]
		public static extern IntPtr new_PcpCache__SWIG_0(HandleRef jarg1, string jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpCache__SWIG_1")]
		public static extern IntPtr new_PcpCache__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpCache__SWIG_2")]
		public static extern IntPtr new_PcpCache__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PcpCache")]
		public static extern void delete_PcpCache(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_GetLayerStackIdentifier")]
		public static extern IntPtr PcpCache_GetLayerStackIdentifier(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_GetLayerStack")]
		public static extern IntPtr PcpCache_GetLayerStack(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_HasRootLayerStack")]
		public static extern bool PcpCache_HasRootLayerStack(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_IsUsd")]
		public static extern bool PcpCache_IsUsd(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_GetFileFormatTarget")]
		public static extern string PcpCache_GetFileFormatTarget(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_GetVariantFallbacks")]
		public static extern IntPtr PcpCache_GetVariantFallbacks(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_SetVariantFallbacks__SWIG_0")]
		public static extern void PcpCache_SetVariantFallbacks__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_SetVariantFallbacks__SWIG_1")]
		public static extern void PcpCache_SetVariantFallbacks__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_IsPayloadIncluded")]
		public static extern bool PcpCache_IsPayloadIncluded(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_GetIncludedPayloads")]
		public static extern IntPtr PcpCache_GetIncludedPayloads(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_RequestPayloads__SWIG_0")]
		public static extern void PcpCache_RequestPayloads__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_RequestPayloads__SWIG_1")]
		public static extern void PcpCache_RequestPayloads__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_RequestLayerMuting__SWIG_0")]
		public static extern void PcpCache_RequestLayerMuting__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, HandleRef jarg6);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_RequestLayerMuting__SWIG_1")]
		public static extern void PcpCache_RequestLayerMuting__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_RequestLayerMuting__SWIG_2")]
		public static extern void PcpCache_RequestLayerMuting__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_RequestLayerMuting__SWIG_3")]
		public static extern void PcpCache_RequestLayerMuting__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_GetMutedLayers")]
		public static extern IntPtr PcpCache_GetMutedLayers(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_IsLayerMuted__SWIG_0")]
		public static extern bool PcpCache_IsLayerMuted__SWIG_0(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_IsLayerMuted__SWIG_1")]
		public static extern bool PcpCache_IsLayerMuted__SWIG_1(HandleRef jarg1, HandleRef jarg2, string jarg3, out string jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_IsLayerMuted__SWIG_2")]
		public static extern bool PcpCache_IsLayerMuted__SWIG_2(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_GetPrimIndexInputs")]
		public static extern IntPtr PcpCache_GetPrimIndexInputs(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_ComputeLayerStack")]
		public static extern IntPtr PcpCache_ComputeLayerStack(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_FindLayerStack")]
		public static extern IntPtr PcpCache_FindLayerStack(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_UsesLayerStack")]
		public static extern bool PcpCache_UsesLayerStack(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_ComputePrimIndex")]
		public static extern IntPtr PcpCache_ComputePrimIndex(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_FindPrimIndex")]
		public static extern IntPtr PcpCache_FindPrimIndex(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_ComputePropertyIndex")]
		public static extern IntPtr PcpCache_ComputePropertyIndex(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_FindPropertyIndex")]
		public static extern IntPtr PcpCache_FindPropertyIndex(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_ComputeRelationshipTargetPaths")]
		public static extern void PcpCache_ComputeRelationshipTargetPaths(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4, HandleRef jarg5, bool jarg6, HandleRef jarg7, HandleRef jarg8);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_ComputeAttributeConnectionPaths")]
		public static extern void PcpCache_ComputeAttributeConnectionPaths(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4, HandleRef jarg5, bool jarg6, HandleRef jarg7, HandleRef jarg8);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_GetUsedLayers")]
		public static extern IntPtr PcpCache_GetUsedLayers(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_GetUsedLayersRevision")]
		public static extern uint PcpCache_GetUsedLayersRevision(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_GetUsedRootLayers")]
		public static extern IntPtr PcpCache_GetUsedRootLayers(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_FindAllLayerStacksUsingLayer")]
		public static extern IntPtr PcpCache_FindAllLayerStacksUsingLayer(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_FindSiteDependencies__SWIG_0")]
		public static extern IntPtr PcpCache_FindSiteDependencies__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, bool jarg5, bool jarg6, bool jarg7);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_FindSiteDependencies__SWIG_1")]
		public static extern IntPtr PcpCache_FindSiteDependencies__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, bool jarg5, bool jarg6, bool jarg7);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_CanHaveOpinionForSite")]
		public static extern bool PcpCache_CanHaveOpinionForSite(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_GetInvalidSublayerIdentifiers")]
		public static extern IntPtr PcpCache_GetInvalidSublayerIdentifiers(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_IsInvalidSublayerIdentifier")]
		public static extern bool PcpCache_IsInvalidSublayerIdentifier(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_GetInvalidAssetPaths")]
		public static extern IntPtr PcpCache_GetInvalidAssetPaths(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_IsInvalidAssetPath")]
		public static extern bool PcpCache_IsInvalidAssetPath(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_HasAnyDynamicFileFormatArgumentDependencies")]
		public static extern bool PcpCache_HasAnyDynamicFileFormatArgumentDependencies(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_IsPossibleDynamicFileFormatArgumentField")]
		public static extern bool PcpCache_IsPossibleDynamicFileFormatArgumentField(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_GetDynamicFileFormatArgumentDependencyData")]
		public static extern IntPtr PcpCache_GetDynamicFileFormatArgumentDependencyData(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_Apply")]
		public static extern void PcpCache_Apply(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_Reload")]
		public static extern void PcpCache_Reload(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_ReloadReferences")]
		public static extern void PcpCache_ReloadReferences(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpCache_PrintStatistics")]
		public static extern void PcpCache_PrintStatistics(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_SdfLayerConstRefPtrVector_Clear")]
		public static extern void SdfLayerConstRefPtrVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_SdfLayerConstRefPtrVector_Add")]
		public static extern void SdfLayerConstRefPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_SdfLayerConstRefPtrVector_size")]
		public static extern uint SdfLayerConstRefPtrVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_SdfLayerConstRefPtrVector_capacity")]
		public static extern uint SdfLayerConstRefPtrVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_SdfLayerConstRefPtrVector_reserve")]
		public static extern void SdfLayerConstRefPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_SdfLayerConstRefPtrVector__SWIG_0")]
		public static extern IntPtr new_SdfLayerConstRefPtrVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_SdfLayerConstRefPtrVector__SWIG_1")]
		public static extern IntPtr new_SdfLayerConstRefPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_SdfLayerConstRefPtrVector__SWIG_2")]
		public static extern IntPtr new_SdfLayerConstRefPtrVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_SdfLayerConstRefPtrVector_getitemcopy")]
		public static extern IntPtr SdfLayerConstRefPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_SdfLayerConstRefPtrVector_getitem")]
		public static extern IntPtr SdfLayerConstRefPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_SdfLayerConstRefPtrVector_setitem")]
		public static extern void SdfLayerConstRefPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_SdfLayerConstRefPtrVector_AddRange")]
		public static extern void SdfLayerConstRefPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_SdfLayerConstRefPtrVector_GetRange")]
		public static extern IntPtr SdfLayerConstRefPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_SdfLayerConstRefPtrVector_Insert")]
		public static extern void SdfLayerConstRefPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_SdfLayerConstRefPtrVector_InsertRange")]
		public static extern void SdfLayerConstRefPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_SdfLayerConstRefPtrVector_RemoveAt")]
		public static extern void SdfLayerConstRefPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_SdfLayerConstRefPtrVector_RemoveRange")]
		public static extern void SdfLayerConstRefPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_SdfLayerConstRefPtrVector_Repeat")]
		public static extern IntPtr SdfLayerConstRefPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_SdfLayerConstRefPtrVector_Reverse__SWIG_0")]
		public static extern void SdfLayerConstRefPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_SdfLayerConstRefPtrVector_Reverse__SWIG_1")]
		public static extern void SdfLayerConstRefPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_SdfLayerConstRefPtrVector_SetRange")]
		public static extern void SdfLayerConstRefPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_SdfLayerConstRefPtrVector")]
		public static extern void delete_SdfLayerConstRefPtrVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PcpLayerStack")]
		public static extern void delete_PcpLayerStack(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStack_GetIdentifier")]
		public static extern IntPtr PcpLayerStack_GetIdentifier(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStack_GetLayers")]
		public static extern IntPtr PcpLayerStack_GetLayers(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStack_GetSessionLayers")]
		public static extern IntPtr PcpLayerStack_GetSessionLayers(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStack_GetLayerTree")]
		public static extern IntPtr PcpLayerStack_GetLayerTree(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStack_GetLayerOffsetForLayer__SWIG_0")]
		public static extern IntPtr PcpLayerStack_GetLayerOffsetForLayer__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStack_GetLayerOffsetForLayer__SWIG_1")]
		public static extern IntPtr PcpLayerStack_GetLayerOffsetForLayer__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStack_GetLayerOffsetForLayer__SWIG_2")]
		public static extern IntPtr PcpLayerStack_GetLayerOffsetForLayer__SWIG_2(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStack_GetMutedLayers")]
		public static extern IntPtr PcpLayerStack_GetMutedLayers(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStack_GetLocalErrors")]
		public static extern IntPtr PcpLayerStack_GetLocalErrors(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStack_HasLayer__SWIG_0")]
		public static extern bool PcpLayerStack_HasLayer__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStack_HasLayer__SWIG_1")]
		public static extern bool PcpLayerStack_HasLayer__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStack_GetTimeCodesPerSecond")]
		public static extern double PcpLayerStack_GetTimeCodesPerSecond(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStack_GetRelocatesSourceToTarget")]
		public static extern IntPtr PcpLayerStack_GetRelocatesSourceToTarget(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStack_GetRelocatesTargetToSource")]
		public static extern IntPtr PcpLayerStack_GetRelocatesTargetToSource(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStack_GetIncrementalRelocatesSourceToTarget")]
		public static extern IntPtr PcpLayerStack_GetIncrementalRelocatesSourceToTarget(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStack_GetIncrementalRelocatesTargetToSource")]
		public static extern IntPtr PcpLayerStack_GetIncrementalRelocatesTargetToSource(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStack_GetPathsToPrimsWithRelocates")]
		public static extern IntPtr PcpLayerStack_GetPathsToPrimsWithRelocates(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStack_Apply")]
		public static extern void PcpLayerStack_Apply(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStack_GetExpressionForRelocatesAtPath")]
		public static extern IntPtr PcpLayerStack_GetExpressionForRelocatesAtPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpIsTimeScalingForLayerTimeCodesPerSecondDisabled")]
		public static extern bool PcpIsTimeScalingForLayerTimeCodesPerSecondDisabled();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpLayerStackIdentifier__SWIG_0")]
		public static extern IntPtr new_PcpLayerStackIdentifier__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpLayerStackIdentifier__SWIG_1")]
		public static extern IntPtr new_PcpLayerStackIdentifier__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpLayerStackIdentifier__SWIG_2")]
		public static extern IntPtr new_PcpLayerStackIdentifier__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpLayerStackIdentifier__SWIG_3")]
		public static extern IntPtr new_PcpLayerStackIdentifier__SWIG_3(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpLayerStackIdentifier_Hash")]
		public static extern IntPtr new_PcpLayerStackIdentifier_Hash();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PcpLayerStackIdentifier_Hash")]
		public static extern void delete_PcpLayerStackIdentifier_Hash(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackIdentifier_GetHash")]
		public static extern uint PcpLayerStackIdentifier_GetHash(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackIdentifier_rootLayer_get")]
		public static extern IntPtr PcpLayerStackIdentifier_rootLayer_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackIdentifier_sessionLayer_get")]
		public static extern IntPtr PcpLayerStackIdentifier_sessionLayer_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackIdentifier_pathResolverContext_get")]
		public static extern IntPtr PcpLayerStackIdentifier_pathResolverContext_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PcpLayerStackIdentifier")]
		public static extern void delete_PcpLayerStackIdentifier(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpLayerStackIdentifierStr__SWIG_0")]
		public static extern IntPtr new_PcpLayerStackIdentifierStr__SWIG_0(string jarg1, string jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpLayerStackIdentifierStr__SWIG_1")]
		public static extern IntPtr new_PcpLayerStackIdentifierStr__SWIG_1(string jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpLayerStackIdentifierStr__SWIG_2")]
		public static extern IntPtr new_PcpLayerStackIdentifierStr__SWIG_2(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpLayerStackIdentifierStr__SWIG_3")]
		public static extern IntPtr new_PcpLayerStackIdentifierStr__SWIG_3();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpLayerStackIdentifierStr__SWIG_4")]
		public static extern IntPtr new_PcpLayerStackIdentifierStr__SWIG_4(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpLayerStackIdentifierStr_Hash")]
		public static extern IntPtr new_PcpLayerStackIdentifierStr_Hash();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PcpLayerStackIdentifierStr_Hash")]
		public static extern void delete_PcpLayerStackIdentifierStr_Hash(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackIdentifierStr_GetHash")]
		public static extern uint PcpLayerStackIdentifierStr_GetHash(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackIdentifierStr_rootLayerId_set")]
		public static extern void PcpLayerStackIdentifierStr_rootLayerId_set(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackIdentifierStr_rootLayerId_get")]
		public static extern string PcpLayerStackIdentifierStr_rootLayerId_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackIdentifierStr_sessionLayerId_set")]
		public static extern void PcpLayerStackIdentifierStr_sessionLayerId_set(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackIdentifierStr_sessionLayerId_get")]
		public static extern string PcpLayerStackIdentifierStr_sessionLayerId_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackIdentifierStr_pathResolverContext_set")]
		public static extern void PcpLayerStackIdentifierStr_pathResolverContext_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpLayerStackIdentifierStr_pathResolverContext_get")]
		public static extern IntPtr PcpLayerStackIdentifierStr_pathResolverContext_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PcpLayerStackIdentifierStr")]
		public static extern void delete_PcpLayerStackIdentifierStr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRefVector_Clear")]
		public static extern void PcpNodeRefVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRefVector_Add")]
		public static extern void PcpNodeRefVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRefVector_size")]
		public static extern uint PcpNodeRefVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRefVector_capacity")]
		public static extern uint PcpNodeRefVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRefVector_reserve")]
		public static extern void PcpNodeRefVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpNodeRefVector__SWIG_0")]
		public static extern IntPtr new_PcpNodeRefVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpNodeRefVector__SWIG_1")]
		public static extern IntPtr new_PcpNodeRefVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpNodeRefVector__SWIG_2")]
		public static extern IntPtr new_PcpNodeRefVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRefVector_getitemcopy")]
		public static extern IntPtr PcpNodeRefVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRefVector_getitem")]
		public static extern IntPtr PcpNodeRefVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRefVector_setitem")]
		public static extern void PcpNodeRefVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRefVector_AddRange")]
		public static extern void PcpNodeRefVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRefVector_GetRange")]
		public static extern IntPtr PcpNodeRefVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRefVector_Insert")]
		public static extern void PcpNodeRefVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRefVector_InsertRange")]
		public static extern void PcpNodeRefVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRefVector_RemoveAt")]
		public static extern void PcpNodeRefVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRefVector_RemoveRange")]
		public static extern void PcpNodeRefVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRefVector_Repeat")]
		public static extern IntPtr PcpNodeRefVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRefVector_Reverse__SWIG_0")]
		public static extern void PcpNodeRefVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRefVector_Reverse__SWIG_1")]
		public static extern void PcpNodeRefVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRefVector_SetRange")]
		public static extern void PcpNodeRefVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PcpNodeRefVector")]
		public static extern void delete_PcpNodeRefVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphRefPtrVector_Clear")]
		public static extern void PcpPrimIndex_GraphRefPtrVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphRefPtrVector_Add")]
		public static extern void PcpPrimIndex_GraphRefPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphRefPtrVector_size")]
		public static extern uint PcpPrimIndex_GraphRefPtrVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphRefPtrVector_capacity")]
		public static extern uint PcpPrimIndex_GraphRefPtrVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphRefPtrVector_reserve")]
		public static extern void PcpPrimIndex_GraphRefPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpPrimIndex_GraphRefPtrVector__SWIG_0")]
		public static extern IntPtr new_PcpPrimIndex_GraphRefPtrVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpPrimIndex_GraphRefPtrVector__SWIG_1")]
		public static extern IntPtr new_PcpPrimIndex_GraphRefPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpPrimIndex_GraphRefPtrVector__SWIG_2")]
		public static extern IntPtr new_PcpPrimIndex_GraphRefPtrVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphRefPtrVector_getitemcopy")]
		public static extern IntPtr PcpPrimIndex_GraphRefPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphRefPtrVector_getitem")]
		public static extern IntPtr PcpPrimIndex_GraphRefPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphRefPtrVector_setitem")]
		public static extern void PcpPrimIndex_GraphRefPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphRefPtrVector_AddRange")]
		public static extern void PcpPrimIndex_GraphRefPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphRefPtrVector_GetRange")]
		public static extern IntPtr PcpPrimIndex_GraphRefPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphRefPtrVector_Insert")]
		public static extern void PcpPrimIndex_GraphRefPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphRefPtrVector_InsertRange")]
		public static extern void PcpPrimIndex_GraphRefPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphRefPtrVector_RemoveAt")]
		public static extern void PcpPrimIndex_GraphRefPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphRefPtrVector_RemoveRange")]
		public static extern void PcpPrimIndex_GraphRefPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphRefPtrVector_Repeat")]
		public static extern IntPtr PcpPrimIndex_GraphRefPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphRefPtrVector_Reverse__SWIG_0")]
		public static extern void PcpPrimIndex_GraphRefPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphRefPtrVector_Reverse__SWIG_1")]
		public static extern void PcpPrimIndex_GraphRefPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphRefPtrVector_SetRange")]
		public static extern void PcpPrimIndex_GraphRefPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PcpPrimIndex_GraphRefPtrVector")]
		public static extern void delete_PcpPrimIndex_GraphRefPtrVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphConstRefPtrVector_Clear")]
		public static extern void PcpPrimIndex_GraphConstRefPtrVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphConstRefPtrVector_Add")]
		public static extern void PcpPrimIndex_GraphConstRefPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphConstRefPtrVector_size")]
		public static extern uint PcpPrimIndex_GraphConstRefPtrVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphConstRefPtrVector_capacity")]
		public static extern uint PcpPrimIndex_GraphConstRefPtrVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphConstRefPtrVector_reserve")]
		public static extern void PcpPrimIndex_GraphConstRefPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpPrimIndex_GraphConstRefPtrVector__SWIG_0")]
		public static extern IntPtr new_PcpPrimIndex_GraphConstRefPtrVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpPrimIndex_GraphConstRefPtrVector__SWIG_1")]
		public static extern IntPtr new_PcpPrimIndex_GraphConstRefPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpPrimIndex_GraphConstRefPtrVector__SWIG_2")]
		public static extern IntPtr new_PcpPrimIndex_GraphConstRefPtrVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphConstRefPtrVector_getitemcopy")]
		public static extern IntPtr PcpPrimIndex_GraphConstRefPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphConstRefPtrVector_getitem")]
		public static extern IntPtr PcpPrimIndex_GraphConstRefPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphConstRefPtrVector_setitem")]
		public static extern void PcpPrimIndex_GraphConstRefPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphConstRefPtrVector_AddRange")]
		public static extern void PcpPrimIndex_GraphConstRefPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphConstRefPtrVector_GetRange")]
		public static extern IntPtr PcpPrimIndex_GraphConstRefPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphConstRefPtrVector_Insert")]
		public static extern void PcpPrimIndex_GraphConstRefPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphConstRefPtrVector_InsertRange")]
		public static extern void PcpPrimIndex_GraphConstRefPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphConstRefPtrVector_RemoveAt")]
		public static extern void PcpPrimIndex_GraphConstRefPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphConstRefPtrVector_RemoveRange")]
		public static extern void PcpPrimIndex_GraphConstRefPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphConstRefPtrVector_Repeat")]
		public static extern IntPtr PcpPrimIndex_GraphConstRefPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphConstRefPtrVector_Reverse__SWIG_0")]
		public static extern void PcpPrimIndex_GraphConstRefPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphConstRefPtrVector_Reverse__SWIG_1")]
		public static extern void PcpPrimIndex_GraphConstRefPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GraphConstRefPtrVector_SetRange")]
		public static extern void PcpPrimIndex_GraphConstRefPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PcpPrimIndex_GraphConstRefPtrVector")]
		public static extern void delete_PcpPrimIndex_GraphConstRefPtrVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpNodeRef")]
		public static extern IntPtr new_PcpNodeRef();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpNodeRef_Hash")]
		public static extern IntPtr new_PcpNodeRef_Hash();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PcpNodeRef_Hash")]
		public static extern void delete_PcpNodeRef_Hash(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_GetArcType")]
		public static extern int PcpNodeRef_GetArcType(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_GetParentNode")]
		public static extern IntPtr PcpNodeRef_GetParentNode(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_InsertChild")]
		public static extern IntPtr PcpNodeRef_InsertChild(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_InsertChildSubgraph")]
		public static extern IntPtr PcpNodeRef_InsertChildSubgraph(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_GetOriginNode")]
		public static extern IntPtr PcpNodeRef_GetOriginNode(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_GetOriginRootNode")]
		public static extern IntPtr PcpNodeRef_GetOriginRootNode(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_GetRootNode")]
		public static extern IntPtr PcpNodeRef_GetRootNode(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_GetMapToParent")]
		public static extern IntPtr PcpNodeRef_GetMapToParent(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_GetMapToRoot")]
		public static extern IntPtr PcpNodeRef_GetMapToRoot(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_GetSiblingNumAtOrigin")]
		public static extern int PcpNodeRef_GetSiblingNumAtOrigin(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_GetNamespaceDepth")]
		public static extern int PcpNodeRef_GetNamespaceDepth(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_GetDepthBelowIntroduction")]
		public static extern int PcpNodeRef_GetDepthBelowIntroduction(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_GetPathAtIntroduction")]
		public static extern IntPtr PcpNodeRef_GetPathAtIntroduction(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_GetIntroPath")]
		public static extern IntPtr PcpNodeRef_GetIntroPath(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_GetSite")]
		public static extern IntPtr PcpNodeRef_GetSite(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_GetPath")]
		public static extern IntPtr PcpNodeRef_GetPath(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_GetLayerStack")]
		public static extern IntPtr PcpNodeRef_GetLayerStack(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_IsRootNode")]
		public static extern bool PcpNodeRef_IsRootNode(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_SetIsDueToAncestor")]
		public static extern void PcpNodeRef_SetIsDueToAncestor(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_IsDueToAncestor")]
		public static extern bool PcpNodeRef_IsDueToAncestor(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_SetHasSymmetry")]
		public static extern void PcpNodeRef_SetHasSymmetry(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_HasSymmetry")]
		public static extern bool PcpNodeRef_HasSymmetry(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_SetPermission")]
		public static extern void PcpNodeRef_SetPermission(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_GetPermission")]
		public static extern int PcpNodeRef_GetPermission(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_SetInert")]
		public static extern void PcpNodeRef_SetInert(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_IsInert")]
		public static extern bool PcpNodeRef_IsInert(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_SetCulled")]
		public static extern void PcpNodeRef_SetCulled(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_IsCulled")]
		public static extern bool PcpNodeRef_IsCulled(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_SetRestricted")]
		public static extern void PcpNodeRef_SetRestricted(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_IsRestricted")]
		public static extern bool PcpNodeRef_IsRestricted(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_CanContributeSpecs")]
		public static extern bool PcpNodeRef_CanContributeSpecs(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_SetHasSpecs")]
		public static extern void PcpNodeRef_SetHasSpecs(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_HasSpecs")]
		public static extern bool PcpNodeRef_HasSpecs(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_GetCompressedSdSite")]
		public static extern IntPtr PcpNodeRef_GetCompressedSdSite(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpNodeRef_GetChildren")]
		public static extern IntPtr PcpNodeRef_GetChildren(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PcpNodeRef")]
		public static extern void delete_PcpNodeRef(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpNodeRef_ChildrenIterator__SWIG_0")]
		public static extern IntPtr new_PcpNodeRef_ChildrenIterator__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpNodeRef_ChildrenIterator__SWIG_1")]
		public static extern IntPtr new_PcpNodeRef_ChildrenIterator__SWIG_1(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpNodeRef_ChildrenIterator__SWIG_2")]
		public static extern IntPtr new_PcpNodeRef_ChildrenIterator__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PcpNodeRef_ChildrenIterator")]
		public static extern void delete_PcpNodeRef_ChildrenIterator(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpNodeRef_ChildrenReverseIterator__SWIG_0")]
		public static extern IntPtr new_PcpNodeRef_ChildrenReverseIterator__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpNodeRef_ChildrenReverseIterator__SWIG_1")]
		public static extern IntPtr new_PcpNodeRef_ChildrenReverseIterator__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpNodeRef_ChildrenReverseIterator__SWIG_2")]
		public static extern IntPtr new_PcpNodeRef_ChildrenReverseIterator__SWIG_2(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpNodeRef_ChildrenReverseIterator__SWIG_3")]
		public static extern IntPtr new_PcpNodeRef_ChildrenReverseIterator__SWIG_3(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PcpNodeRef_ChildrenReverseIterator")]
		public static extern void delete_PcpNodeRef_ChildrenReverseIterator(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_begin")]
		public static extern IntPtr begin(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_end")]
		public static extern IntPtr end(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpPrimIndex__SWIG_0")]
		public static extern IntPtr new_PcpPrimIndex__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpPrimIndex__SWIG_1")]
		public static extern IntPtr new_PcpPrimIndex__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_Swap")]
		public static extern void PcpPrimIndex_Swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_swap")]
		public static extern void PcpPrimIndex_swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_IsValid")]
		public static extern bool PcpPrimIndex_IsValid(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_SetGraph")]
		public static extern void PcpPrimIndex_SetGraph(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GetGraph")]
		public static extern IntPtr PcpPrimIndex_GetGraph(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GetRootNode")]
		public static extern IntPtr PcpPrimIndex_GetRootNode(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GetPath")]
		public static extern IntPtr PcpPrimIndex_GetPath(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_HasSpecs")]
		public static extern bool PcpPrimIndex_HasSpecs(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_HasAnyPayloads")]
		public static extern bool PcpPrimIndex_HasAnyPayloads(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_IsUsd")]
		public static extern bool PcpPrimIndex_IsUsd(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_IsInstanceable")]
		public static extern bool PcpPrimIndex_IsInstanceable(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GetNodeRange__SWIG_0")]
		public static extern IntPtr PcpPrimIndex_GetNodeRange__SWIG_0(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GetNodeRange__SWIG_1")]
		public static extern IntPtr PcpPrimIndex_GetNodeRange__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GetNodeIteratorAtNode")]
		public static extern IntPtr PcpPrimIndex_GetNodeIteratorAtNode(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GetPrimRange__SWIG_0")]
		public static extern IntPtr PcpPrimIndex_GetPrimRange__SWIG_0(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GetPrimRange__SWIG_1")]
		public static extern IntPtr PcpPrimIndex_GetPrimRange__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GetPrimRangeForNode")]
		public static extern IntPtr PcpPrimIndex_GetPrimRangeForNode(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GetNodeProvidingSpec__SWIG_0")]
		public static extern IntPtr PcpPrimIndex_GetNodeProvidingSpec__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GetNodeProvidingSpec__SWIG_1")]
		public static extern IntPtr PcpPrimIndex_GetNodeProvidingSpec__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GetLocalErrors")]
		public static extern IntPtr PcpPrimIndex_GetLocalErrors(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_PrintStatistics")]
		public static extern void PcpPrimIndex_PrintStatistics(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_DumpToString__SWIG_0")]
		public static extern string PcpPrimIndex_DumpToString__SWIG_0(HandleRef jarg1, bool jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_DumpToString__SWIG_1")]
		public static extern string PcpPrimIndex_DumpToString__SWIG_1(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_DumpToString__SWIG_2")]
		public static extern string PcpPrimIndex_DumpToString__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_DumpToDotGraph__SWIG_0")]
		public static extern void PcpPrimIndex_DumpToDotGraph__SWIG_0(HandleRef jarg1, string jarg2, bool jarg3, bool jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_DumpToDotGraph__SWIG_1")]
		public static extern void PcpPrimIndex_DumpToDotGraph__SWIG_1(HandleRef jarg1, string jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_DumpToDotGraph__SWIG_2")]
		public static extern void PcpPrimIndex_DumpToDotGraph__SWIG_2(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_ComputePrimChildNames")]
		public static extern void PcpPrimIndex_ComputePrimChildNames(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_ComputePrimPropertyNames")]
		public static extern void PcpPrimIndex_ComputePrimPropertyNames(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_ComposeAuthoredVariantSelections")]
		public static extern IntPtr PcpPrimIndex_ComposeAuthoredVariantSelections(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPrimIndex_GetSelectionAppliedForVariantSet")]
		public static extern string PcpPrimIndex_GetSelectionAppliedForVariantSet(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PcpPrimIndex")]
		public static extern void delete_PcpPrimIndex(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpComputePrimIndex__SWIG_0")]
		public static extern void PcpComputePrimIndex__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpComputePrimIndex__SWIG_1")]
		public static extern void PcpComputePrimIndex__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpIsNewDefaultStandinBehaviorEnabled")]
		public static extern bool PcpIsNewDefaultStandinBehaviorEnabled();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpPropertyIndex__SWIG_0")]
		public static extern IntPtr new_PcpPropertyIndex__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpPropertyIndex__SWIG_1")]
		public static extern IntPtr new_PcpPropertyIndex__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPropertyIndex_Swap")]
		public static extern void PcpPropertyIndex_Swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPropertyIndex_IsEmpty")]
		public static extern bool PcpPropertyIndex_IsEmpty(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPropertyIndex_GetPropertyRange__SWIG_0")]
		public static extern IntPtr PcpPropertyIndex_GetPropertyRange__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPropertyIndex_GetPropertyRange__SWIG_1")]
		public static extern IntPtr PcpPropertyIndex_GetPropertyRange__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPropertyIndex_GetLocalErrors")]
		public static extern IntPtr PcpPropertyIndex_GetLocalErrors(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpPropertyIndex_GetNumLocalSpecs")]
		public static extern uint PcpPropertyIndex_GetNumLocalSpecs(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PcpPropertyIndex")]
		public static extern void delete_PcpPropertyIndex(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpBuildPropertyIndex")]
		public static extern void PcpBuildPropertyIndex(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpBuildPrimPropertyIndex")]
		public static extern void PcpBuildPrimPropertyIndex(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpVariantFallbackMap__SWIG_0")]
		public static extern IntPtr new_PcpVariantFallbackMap__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpVariantFallbackMap__SWIG_1")]
		public static extern IntPtr new_PcpVariantFallbackMap__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpVariantFallbackMap_size")]
		public static extern uint PcpVariantFallbackMap_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpVariantFallbackMap_empty")]
		public static extern bool PcpVariantFallbackMap_empty(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpVariantFallbackMap_Clear")]
		public static extern void PcpVariantFallbackMap_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpVariantFallbackMap_getitem")]
		public static extern IntPtr PcpVariantFallbackMap_getitem(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpVariantFallbackMap_setitem")]
		public static extern void PcpVariantFallbackMap_setitem(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpVariantFallbackMap_ContainsKey")]
		public static extern bool PcpVariantFallbackMap_ContainsKey(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpVariantFallbackMap_Add")]
		public static extern void PcpVariantFallbackMap_Add(HandleRef jarg1, string jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpVariantFallbackMap_Remove")]
		public static extern bool PcpVariantFallbackMap_Remove(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpVariantFallbackMap_create_iterator_begin")]
		public static extern IntPtr PcpVariantFallbackMap_create_iterator_begin(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpVariantFallbackMap_get_next_key")]
		public static extern string PcpVariantFallbackMap_get_next_key(HandleRef jarg1, IntPtr jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpVariantFallbackMap_destroy_iterator")]
		public static extern void PcpVariantFallbackMap_destroy_iterator(HandleRef jarg1, IntPtr jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PcpVariantFallbackMap")]
		public static extern void delete_PcpVariantFallbackMap(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpIsInheritArc")]
		public static extern bool PcpIsInheritArc(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpIsSpecializeArc")]
		public static extern bool PcpIsSpecializeArc(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpIsClassBasedArc")]
		public static extern bool PcpIsClassBasedArc(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpSiteTrackerSegment_site_set")]
		public static extern void PcpSiteTrackerSegment_site_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpSiteTrackerSegment_site_get")]
		public static extern IntPtr PcpSiteTrackerSegment_site_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpSiteTrackerSegment_arcType_set")]
		public static extern void PcpSiteTrackerSegment_arcType_set(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PcpSiteTrackerSegment_arcType_get")]
		public static extern int PcpSiteTrackerSegment_arcType_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_PcpSiteTrackerSegment")]
		public static extern IntPtr new_PcpSiteTrackerSegment();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_PcpSiteTrackerSegment")]
		public static extern void delete_PcpSiteTrackerSegment(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_PCP_INVALID_INDEX_get")]
		public static extern uint PCP_INVALID_INDEX_get();
	}
}
