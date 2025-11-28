using System;
using System.Runtime.InteropServices;

namespace pxr
{
	internal class StdPINVOKE
	{
		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			[DllImport(UsdDll.USD_EXPORT_NAME)]
			public static extern void SWIGRegisterStringCallback_Std(SWIGStringDelegate stringDelegate);

			[MonoPInvokeCallback]
			private static string CreateString(string cString)
			{
				return cString;
			}

			static SWIGStringHelper()
			{
				stringDelegate = CreateString;
				SWIGRegisterStringCallback_Std(stringDelegate);
			}
		}

		public class SWIGPendingException : UsdCsPINVOKE.SWIGPendingException
		{
		}

		protected static SWIGStringHelper swigStringHelper;

		static StdPINVOKE()
		{
			swigStringHelper = new SWIGStringHelper();
		}

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVector_Clear")]
		public static extern void StdDoubleVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVector_Add")]
		public static extern void StdDoubleVector_Add(HandleRef jarg1, double jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVector_size")]
		public static extern uint StdDoubleVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVector_capacity")]
		public static extern uint StdDoubleVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVector_reserve")]
		public static extern void StdDoubleVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdDoubleVector__SWIG_0")]
		public static extern IntPtr new_StdDoubleVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdDoubleVector__SWIG_1")]
		public static extern IntPtr new_StdDoubleVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdDoubleVector__SWIG_2")]
		public static extern IntPtr new_StdDoubleVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVector_getitemcopy")]
		public static extern double StdDoubleVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVector_getitem")]
		public static extern double StdDoubleVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVector_setitem")]
		public static extern void StdDoubleVector_setitem(HandleRef jarg1, int jarg2, double jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVector_AddRange")]
		public static extern void StdDoubleVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVector_GetRange")]
		public static extern IntPtr StdDoubleVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVector_Insert")]
		public static extern void StdDoubleVector_Insert(HandleRef jarg1, int jarg2, double jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVector_InsertRange")]
		public static extern void StdDoubleVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVector_RemoveAt")]
		public static extern void StdDoubleVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVector_RemoveRange")]
		public static extern void StdDoubleVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVector_Repeat")]
		public static extern IntPtr StdDoubleVector_Repeat(double jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVector_Reverse__SWIG_0")]
		public static extern void StdDoubleVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVector_Reverse__SWIG_1")]
		public static extern void StdDoubleVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVector_SetRange")]
		public static extern void StdDoubleVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVector_Contains")]
		public static extern bool StdDoubleVector_Contains(HandleRef jarg1, double jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVector_IndexOf")]
		public static extern int StdDoubleVector_IndexOf(HandleRef jarg1, double jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVector_LastIndexOf")]
		public static extern int StdDoubleVector_LastIndexOf(HandleRef jarg1, double jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVector_Remove")]
		public static extern bool StdDoubleVector_Remove(HandleRef jarg1, double jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_StdDoubleVector")]
		public static extern void delete_StdDoubleVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVectorVector_Clear")]
		public static extern void StdDoubleVectorVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVectorVector_Add")]
		public static extern void StdDoubleVectorVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVectorVector_size")]
		public static extern uint StdDoubleVectorVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVectorVector_capacity")]
		public static extern uint StdDoubleVectorVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVectorVector_reserve")]
		public static extern void StdDoubleVectorVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdDoubleVectorVector__SWIG_0")]
		public static extern IntPtr new_StdDoubleVectorVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdDoubleVectorVector__SWIG_1")]
		public static extern IntPtr new_StdDoubleVectorVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdDoubleVectorVector__SWIG_2")]
		public static extern IntPtr new_StdDoubleVectorVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVectorVector_getitemcopy")]
		public static extern IntPtr StdDoubleVectorVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVectorVector_getitem")]
		public static extern IntPtr StdDoubleVectorVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVectorVector_setitem")]
		public static extern void StdDoubleVectorVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVectorVector_AddRange")]
		public static extern void StdDoubleVectorVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVectorVector_GetRange")]
		public static extern IntPtr StdDoubleVectorVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVectorVector_Insert")]
		public static extern void StdDoubleVectorVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVectorVector_InsertRange")]
		public static extern void StdDoubleVectorVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVectorVector_RemoveAt")]
		public static extern void StdDoubleVectorVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVectorVector_RemoveRange")]
		public static extern void StdDoubleVectorVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVectorVector_Repeat")]
		public static extern IntPtr StdDoubleVectorVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVectorVector_Reverse__SWIG_0")]
		public static extern void StdDoubleVectorVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVectorVector_Reverse__SWIG_1")]
		public static extern void StdDoubleVectorVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdDoubleVectorVector_SetRange")]
		public static extern void StdDoubleVectorVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_StdDoubleVectorVector")]
		public static extern void delete_StdDoubleVectorVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVector_Clear")]
		public static extern void StdFloatVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVector_Add")]
		public static extern void StdFloatVector_Add(HandleRef jarg1, float jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVector_size")]
		public static extern uint StdFloatVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVector_capacity")]
		public static extern uint StdFloatVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVector_reserve")]
		public static extern void StdFloatVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdFloatVector__SWIG_0")]
		public static extern IntPtr new_StdFloatVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdFloatVector__SWIG_1")]
		public static extern IntPtr new_StdFloatVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdFloatVector__SWIG_2")]
		public static extern IntPtr new_StdFloatVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVector_getitemcopy")]
		public static extern float StdFloatVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVector_getitem")]
		public static extern float StdFloatVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVector_setitem")]
		public static extern void StdFloatVector_setitem(HandleRef jarg1, int jarg2, float jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVector_AddRange")]
		public static extern void StdFloatVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVector_GetRange")]
		public static extern IntPtr StdFloatVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVector_Insert")]
		public static extern void StdFloatVector_Insert(HandleRef jarg1, int jarg2, float jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVector_InsertRange")]
		public static extern void StdFloatVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVector_RemoveAt")]
		public static extern void StdFloatVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVector_RemoveRange")]
		public static extern void StdFloatVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVector_Repeat")]
		public static extern IntPtr StdFloatVector_Repeat(float jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVector_Reverse__SWIG_0")]
		public static extern void StdFloatVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVector_Reverse__SWIG_1")]
		public static extern void StdFloatVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVector_SetRange")]
		public static extern void StdFloatVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVector_Contains")]
		public static extern bool StdFloatVector_Contains(HandleRef jarg1, float jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVector_IndexOf")]
		public static extern int StdFloatVector_IndexOf(HandleRef jarg1, float jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVector_LastIndexOf")]
		public static extern int StdFloatVector_LastIndexOf(HandleRef jarg1, float jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVector_Remove")]
		public static extern bool StdFloatVector_Remove(HandleRef jarg1, float jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_StdFloatVector")]
		public static extern void delete_StdFloatVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVectorVector_Clear")]
		public static extern void StdFloatVectorVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVectorVector_Add")]
		public static extern void StdFloatVectorVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVectorVector_size")]
		public static extern uint StdFloatVectorVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVectorVector_capacity")]
		public static extern uint StdFloatVectorVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVectorVector_reserve")]
		public static extern void StdFloatVectorVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdFloatVectorVector__SWIG_0")]
		public static extern IntPtr new_StdFloatVectorVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdFloatVectorVector__SWIG_1")]
		public static extern IntPtr new_StdFloatVectorVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdFloatVectorVector__SWIG_2")]
		public static extern IntPtr new_StdFloatVectorVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVectorVector_getitemcopy")]
		public static extern IntPtr StdFloatVectorVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVectorVector_getitem")]
		public static extern IntPtr StdFloatVectorVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVectorVector_setitem")]
		public static extern void StdFloatVectorVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVectorVector_AddRange")]
		public static extern void StdFloatVectorVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVectorVector_GetRange")]
		public static extern IntPtr StdFloatVectorVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVectorVector_Insert")]
		public static extern void StdFloatVectorVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVectorVector_InsertRange")]
		public static extern void StdFloatVectorVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVectorVector_RemoveAt")]
		public static extern void StdFloatVectorVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVectorVector_RemoveRange")]
		public static extern void StdFloatVectorVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVectorVector_Repeat")]
		public static extern IntPtr StdFloatVectorVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVectorVector_Reverse__SWIG_0")]
		public static extern void StdFloatVectorVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVectorVector_Reverse__SWIG_1")]
		public static extern void StdFloatVectorVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdFloatVectorVector_SetRange")]
		public static extern void StdFloatVectorVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_StdFloatVectorVector")]
		public static extern void delete_StdFloatVectorVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdBoolVector_Clear")]
		public static extern void StdBoolVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdBoolVector_Add")]
		public static extern void StdBoolVector_Add(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdBoolVector_size")]
		public static extern uint StdBoolVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdBoolVector_capacity")]
		public static extern uint StdBoolVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdBoolVector_reserve")]
		public static extern void StdBoolVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdBoolVector__SWIG_0")]
		public static extern IntPtr new_StdBoolVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdBoolVector__SWIG_1")]
		public static extern IntPtr new_StdBoolVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdBoolVector__SWIG_2")]
		public static extern IntPtr new_StdBoolVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdBoolVector_getitemcopy")]
		public static extern bool StdBoolVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdBoolVector_getitem")]
		public static extern bool StdBoolVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdBoolVector_setitem")]
		public static extern void StdBoolVector_setitem(HandleRef jarg1, int jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdBoolVector_AddRange")]
		public static extern void StdBoolVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdBoolVector_GetRange")]
		public static extern IntPtr StdBoolVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdBoolVector_Insert")]
		public static extern void StdBoolVector_Insert(HandleRef jarg1, int jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdBoolVector_InsertRange")]
		public static extern void StdBoolVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdBoolVector_RemoveAt")]
		public static extern void StdBoolVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdBoolVector_RemoveRange")]
		public static extern void StdBoolVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdBoolVector_Repeat")]
		public static extern IntPtr StdBoolVector_Repeat(bool jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdBoolVector_Reverse__SWIG_0")]
		public static extern void StdBoolVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdBoolVector_Reverse__SWIG_1")]
		public static extern void StdBoolVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdBoolVector_SetRange")]
		public static extern void StdBoolVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdBoolVector_Contains")]
		public static extern bool StdBoolVector_Contains(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdBoolVector_IndexOf")]
		public static extern int StdBoolVector_IndexOf(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdBoolVector_LastIndexOf")]
		public static extern int StdBoolVector_LastIndexOf(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdBoolVector_Remove")]
		public static extern bool StdBoolVector_Remove(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_StdBoolVector")]
		public static extern void delete_StdBoolVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdIntVector_Clear")]
		public static extern void StdIntVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdIntVector_Add")]
		public static extern void StdIntVector_Add(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdIntVector_size")]
		public static extern uint StdIntVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdIntVector_capacity")]
		public static extern uint StdIntVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdIntVector_reserve")]
		public static extern void StdIntVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdIntVector__SWIG_0")]
		public static extern IntPtr new_StdIntVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdIntVector__SWIG_1")]
		public static extern IntPtr new_StdIntVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdIntVector__SWIG_2")]
		public static extern IntPtr new_StdIntVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdIntVector_getitemcopy")]
		public static extern int StdIntVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdIntVector_getitem")]
		public static extern int StdIntVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdIntVector_setitem")]
		public static extern void StdIntVector_setitem(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdIntVector_AddRange")]
		public static extern void StdIntVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdIntVector_GetRange")]
		public static extern IntPtr StdIntVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdIntVector_Insert")]
		public static extern void StdIntVector_Insert(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdIntVector_InsertRange")]
		public static extern void StdIntVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdIntVector_RemoveAt")]
		public static extern void StdIntVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdIntVector_RemoveRange")]
		public static extern void StdIntVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdIntVector_Repeat")]
		public static extern IntPtr StdIntVector_Repeat(int jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdIntVector_Reverse__SWIG_0")]
		public static extern void StdIntVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdIntVector_Reverse__SWIG_1")]
		public static extern void StdIntVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdIntVector_SetRange")]
		public static extern void StdIntVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdIntVector_Contains")]
		public static extern bool StdIntVector_Contains(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdIntVector_IndexOf")]
		public static extern int StdIntVector_IndexOf(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdIntVector_LastIndexOf")]
		public static extern int StdIntVector_LastIndexOf(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdIntVector_Remove")]
		public static extern bool StdIntVector_Remove(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_StdIntVector")]
		public static extern void delete_StdIntVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUIntVector_Clear")]
		public static extern void StdUIntVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUIntVector_Add")]
		public static extern void StdUIntVector_Add(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUIntVector_size")]
		public static extern uint StdUIntVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUIntVector_capacity")]
		public static extern uint StdUIntVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUIntVector_reserve")]
		public static extern void StdUIntVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdUIntVector__SWIG_0")]
		public static extern IntPtr new_StdUIntVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdUIntVector__SWIG_1")]
		public static extern IntPtr new_StdUIntVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdUIntVector__SWIG_2")]
		public static extern IntPtr new_StdUIntVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUIntVector_getitemcopy")]
		public static extern uint StdUIntVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUIntVector_getitem")]
		public static extern uint StdUIntVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUIntVector_setitem")]
		public static extern void StdUIntVector_setitem(HandleRef jarg1, int jarg2, uint jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUIntVector_AddRange")]
		public static extern void StdUIntVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUIntVector_GetRange")]
		public static extern IntPtr StdUIntVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUIntVector_Insert")]
		public static extern void StdUIntVector_Insert(HandleRef jarg1, int jarg2, uint jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUIntVector_InsertRange")]
		public static extern void StdUIntVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUIntVector_RemoveAt")]
		public static extern void StdUIntVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUIntVector_RemoveRange")]
		public static extern void StdUIntVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUIntVector_Repeat")]
		public static extern IntPtr StdUIntVector_Repeat(uint jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUIntVector_Reverse__SWIG_0")]
		public static extern void StdUIntVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUIntVector_Reverse__SWIG_1")]
		public static extern void StdUIntVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUIntVector_SetRange")]
		public static extern void StdUIntVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUIntVector_Contains")]
		public static extern bool StdUIntVector_Contains(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUIntVector_IndexOf")]
		public static extern int StdUIntVector_IndexOf(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUIntVector_LastIndexOf")]
		public static extern int StdUIntVector_LastIndexOf(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUIntVector_Remove")]
		public static extern bool StdUIntVector_Remove(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_StdUIntVector")]
		public static extern void delete_StdUIntVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdInt64Vector_Clear")]
		public static extern void StdInt64Vector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdInt64Vector_Add")]
		public static extern void StdInt64Vector_Add(HandleRef jarg1, long jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdInt64Vector_size")]
		public static extern uint StdInt64Vector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdInt64Vector_capacity")]
		public static extern uint StdInt64Vector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdInt64Vector_reserve")]
		public static extern void StdInt64Vector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdInt64Vector__SWIG_0")]
		public static extern IntPtr new_StdInt64Vector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdInt64Vector__SWIG_1")]
		public static extern IntPtr new_StdInt64Vector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdInt64Vector__SWIG_2")]
		public static extern IntPtr new_StdInt64Vector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdInt64Vector_getitemcopy")]
		public static extern long StdInt64Vector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdInt64Vector_getitem")]
		public static extern long StdInt64Vector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdInt64Vector_setitem")]
		public static extern void StdInt64Vector_setitem(HandleRef jarg1, int jarg2, long jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdInt64Vector_AddRange")]
		public static extern void StdInt64Vector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdInt64Vector_GetRange")]
		public static extern IntPtr StdInt64Vector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdInt64Vector_Insert")]
		public static extern void StdInt64Vector_Insert(HandleRef jarg1, int jarg2, long jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdInt64Vector_InsertRange")]
		public static extern void StdInt64Vector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdInt64Vector_RemoveAt")]
		public static extern void StdInt64Vector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdInt64Vector_RemoveRange")]
		public static extern void StdInt64Vector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdInt64Vector_Repeat")]
		public static extern IntPtr StdInt64Vector_Repeat(long jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdInt64Vector_Reverse__SWIG_0")]
		public static extern void StdInt64Vector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdInt64Vector_Reverse__SWIG_1")]
		public static extern void StdInt64Vector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdInt64Vector_SetRange")]
		public static extern void StdInt64Vector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdInt64Vector_Contains")]
		public static extern bool StdInt64Vector_Contains(HandleRef jarg1, long jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdInt64Vector_IndexOf")]
		public static extern int StdInt64Vector_IndexOf(HandleRef jarg1, long jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdInt64Vector_LastIndexOf")]
		public static extern int StdInt64Vector_LastIndexOf(HandleRef jarg1, long jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdInt64Vector_Remove")]
		public static extern bool StdInt64Vector_Remove(HandleRef jarg1, long jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_StdInt64Vector")]
		public static extern void delete_StdInt64Vector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUInt64Vector_Clear")]
		public static extern void StdUInt64Vector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUInt64Vector_Add")]
		public static extern void StdUInt64Vector_Add(HandleRef jarg1, ulong jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUInt64Vector_size")]
		public static extern uint StdUInt64Vector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUInt64Vector_capacity")]
		public static extern uint StdUInt64Vector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUInt64Vector_reserve")]
		public static extern void StdUInt64Vector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdUInt64Vector__SWIG_0")]
		public static extern IntPtr new_StdUInt64Vector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdUInt64Vector__SWIG_1")]
		public static extern IntPtr new_StdUInt64Vector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdUInt64Vector__SWIG_2")]
		public static extern IntPtr new_StdUInt64Vector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUInt64Vector_getitemcopy")]
		public static extern ulong StdUInt64Vector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUInt64Vector_getitem")]
		public static extern ulong StdUInt64Vector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUInt64Vector_setitem")]
		public static extern void StdUInt64Vector_setitem(HandleRef jarg1, int jarg2, ulong jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUInt64Vector_AddRange")]
		public static extern void StdUInt64Vector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUInt64Vector_GetRange")]
		public static extern IntPtr StdUInt64Vector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUInt64Vector_Insert")]
		public static extern void StdUInt64Vector_Insert(HandleRef jarg1, int jarg2, ulong jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUInt64Vector_InsertRange")]
		public static extern void StdUInt64Vector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUInt64Vector_RemoveAt")]
		public static extern void StdUInt64Vector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUInt64Vector_RemoveRange")]
		public static extern void StdUInt64Vector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUInt64Vector_Repeat")]
		public static extern IntPtr StdUInt64Vector_Repeat(ulong jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUInt64Vector_Reverse__SWIG_0")]
		public static extern void StdUInt64Vector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUInt64Vector_Reverse__SWIG_1")]
		public static extern void StdUInt64Vector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUInt64Vector_SetRange")]
		public static extern void StdUInt64Vector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUInt64Vector_Contains")]
		public static extern bool StdUInt64Vector_Contains(HandleRef jarg1, ulong jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUInt64Vector_IndexOf")]
		public static extern int StdUInt64Vector_IndexOf(HandleRef jarg1, ulong jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUInt64Vector_LastIndexOf")]
		public static extern int StdUInt64Vector_LastIndexOf(HandleRef jarg1, ulong jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdUInt64Vector_Remove")]
		public static extern bool StdUInt64Vector_Remove(HandleRef jarg1, ulong jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_StdUInt64Vector")]
		public static extern void delete_StdUInt64Vector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringVector_Clear")]
		public static extern void StdStringVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringVector_Add")]
		public static extern void StdStringVector_Add(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringVector_size")]
		public static extern uint StdStringVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringVector_capacity")]
		public static extern uint StdStringVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringVector_reserve")]
		public static extern void StdStringVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdStringVector__SWIG_0")]
		public static extern IntPtr new_StdStringVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdStringVector__SWIG_1")]
		public static extern IntPtr new_StdStringVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdStringVector__SWIG_2")]
		public static extern IntPtr new_StdStringVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringVector_getitemcopy")]
		public static extern string StdStringVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringVector_getitem")]
		public static extern string StdStringVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringVector_setitem")]
		public static extern void StdStringVector_setitem(HandleRef jarg1, int jarg2, string jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringVector_AddRange")]
		public static extern void StdStringVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringVector_GetRange")]
		public static extern IntPtr StdStringVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringVector_Insert")]
		public static extern void StdStringVector_Insert(HandleRef jarg1, int jarg2, string jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringVector_InsertRange")]
		public static extern void StdStringVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringVector_RemoveAt")]
		public static extern void StdStringVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringVector_RemoveRange")]
		public static extern void StdStringVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringVector_Repeat")]
		public static extern IntPtr StdStringVector_Repeat(string jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringVector_Reverse__SWIG_0")]
		public static extern void StdStringVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringVector_Reverse__SWIG_1")]
		public static extern void StdStringVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringVector_SetRange")]
		public static extern void StdStringVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringVector_Contains")]
		public static extern bool StdStringVector_Contains(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringVector_IndexOf")]
		public static extern int StdStringVector_IndexOf(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringVector_LastIndexOf")]
		public static extern int StdStringVector_LastIndexOf(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringVector_Remove")]
		public static extern bool StdStringVector_Remove(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_StdStringVector")]
		public static extern void delete_StdStringVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdStringSet__SWIG_0")]
		public static extern IntPtr new_StdStringSet__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdStringSet__SWIG_1")]
		public static extern IntPtr new_StdStringSet__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringSet_size")]
		public static extern uint StdStringSet_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringSet_empty")]
		public static extern bool StdStringSet_empty(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringSet_Clear")]
		public static extern void StdStringSet_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringSet_Add")]
		public static extern bool StdStringSet_Add(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringSet_Contains")]
		public static extern bool StdStringSet_Contains(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringSet_Remove")]
		public static extern bool StdStringSet_Remove(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringSet_getitem")]
		public static extern string StdStringSet_getitem(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringSet_create_iterator_begin")]
		public static extern IntPtr StdStringSet_create_iterator_begin(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringSet_get_next")]
		public static extern string StdStringSet_get_next(HandleRef jarg1, IntPtr jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringSet_destroy_iterator")]
		public static extern void StdStringSet_destroy_iterator(HandleRef jarg1, IntPtr jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_StdStringSet")]
		public static extern void delete_StdStringSet(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdStringPair__SWIG_0")]
		public static extern IntPtr new_StdStringPair__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdStringPair__SWIG_1")]
		public static extern IntPtr new_StdStringPair__SWIG_1(string jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdStringPair__SWIG_2")]
		public static extern IntPtr new_StdStringPair__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringPair_first_set")]
		public static extern void StdStringPair_first_set(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringPair_first_get")]
		public static extern string StdStringPair_first_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringPair_second_set")]
		public static extern void StdStringPair_second_set(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringPair_second_get")]
		public static extern string StdStringPair_second_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_StdStringPair")]
		public static extern void delete_StdStringPair(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdStringMap__SWIG_0")]
		public static extern IntPtr new_StdStringMap__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_StdStringMap__SWIG_1")]
		public static extern IntPtr new_StdStringMap__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringMap_size")]
		public static extern uint StdStringMap_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringMap_empty")]
		public static extern bool StdStringMap_empty(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringMap_Clear")]
		public static extern void StdStringMap_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringMap_getitem")]
		public static extern string StdStringMap_getitem(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringMap_setitem")]
		public static extern void StdStringMap_setitem(HandleRef jarg1, string jarg2, string jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringMap_ContainsKey")]
		public static extern bool StdStringMap_ContainsKey(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringMap_Add")]
		public static extern void StdStringMap_Add(HandleRef jarg1, string jarg2, string jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringMap_Remove")]
		public static extern bool StdStringMap_Remove(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringMap_create_iterator_begin")]
		public static extern IntPtr StdStringMap_create_iterator_begin(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringMap_get_next_key")]
		public static extern string StdStringMap_get_next_key(HandleRef jarg1, IntPtr jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_StdStringMap_destroy_iterator")]
		public static extern void StdStringMap_destroy_iterator(HandleRef jarg1, IntPtr jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_StdStringMap")]
		public static extern void delete_StdStringMap(HandleRef jarg1);
	}
}
