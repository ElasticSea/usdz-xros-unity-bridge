using System;
using System.Runtime.InteropServices;

namespace pxr
{
	internal class KindPINVOKE
	{
		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			[DllImport("UsdCs")]
			public static extern void SWIGRegisterStringCallback_Kind(SWIGStringDelegate stringDelegate);

			[MonoPInvokeCallback]
			private static string CreateString(string cString)
			{
				return cString;
			}

			static SWIGStringHelper()
			{
				stringDelegate = CreateString;
				SWIGRegisterStringCallback_Kind(stringDelegate);
			}
		}

		public class SWIGPendingException : UsdCsPINVOKE.SWIGPendingException
		{
		}

		protected static SWIGStringHelper swigStringHelper;

		static KindPINVOKE()
		{
			swigStringHelper = new SWIGStringHelper();
		}

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_KindRegistry_GetInstance")]
		public static extern IntPtr KindRegistry_GetInstance();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_KindRegistry_HasKind")]
		public static extern bool KindRegistry_HasKind(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_KindRegistry_GetBaseKind")]
		public static extern IntPtr KindRegistry_GetBaseKind(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_KindRegistry_IsA")]
		public static extern bool KindRegistry_IsA(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_KindRegistry_GetAllKinds")]
		public static extern IntPtr KindRegistry_GetAllKinds();
	}
}
