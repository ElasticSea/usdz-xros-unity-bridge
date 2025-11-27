using System;
using System.Runtime.InteropServices;

namespace pxr
{
	internal class ArPINVOKE
	{
		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			[DllImport("UsdCs")]
			public static extern void SWIGRegisterStringCallback_Ar(SWIGStringDelegate stringDelegate);

			[MonoPInvokeCallback]
			private static string CreateString(string cString)
			{
				return cString;
			}

			static SWIGStringHelper()
			{
				stringDelegate = CreateString;
				SWIGRegisterStringCallback_Ar(stringDelegate);
			}
		}

		public class SWIGPendingException : UsdCsPINVOKE.SWIGPendingException
		{
		}

		protected static SWIGStringHelper swigStringHelper;

		static ArPINVOKE()
		{
			swigStringHelper = new SWIGStringHelper();
		}

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_ArResolverContext__SWIG_0")]
		public static extern IntPtr new_ArResolverContext__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_ArResolverContext__SWIG_1")]
		public static extern IntPtr new_ArResolverContext__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_ArResolverContext_IsEmpty")]
		public static extern bool ArResolverContext_IsEmpty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_ArResolverContext_GetDebugString")]
		public static extern string ArResolverContext_GetDebugString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_ArResolverContext")]
		public static extern void delete_ArResolverContext(HandleRef jarg1);
	}
}
