using System;
using System.IO;
using System.Runtime.InteropServices;

namespace pxr
{
	internal class UsdCsPINVOKE
	{
		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			[DllImport("__Internal")]
			public static extern void SWIGRegisterStringCallback_UsdCs(SWIGStringDelegate stringDelegate);

			[MonoPInvokeCallback]
			private static string CreateString(string cString)
			{
				return cString;
			}

			static SWIGStringHelper()
			{
				stringDelegate = CreateString;
				SWIGRegisterStringCallback_UsdCs(stringDelegate);
			}
		}

		protected class SWIGExceptionHelper
		{
			public delegate void ExceptionDelegate(string message);

			public delegate void ExceptionArgumentDelegate(string message, string paramName);

			private static ExceptionDelegate applicationDelegate;

			private static ExceptionDelegate arithmeticDelegate;

			private static ExceptionDelegate divideByZeroDelegate;

			private static ExceptionDelegate indexOutOfRangeDelegate;

			private static ExceptionDelegate invalidCastDelegate;

			private static ExceptionDelegate invalidOperationDelegate;

			private static ExceptionDelegate ioDelegate;

			private static ExceptionDelegate nullReferenceDelegate;

			private static ExceptionDelegate outOfMemoryDelegate;

			private static ExceptionDelegate overflowDelegate;

			private static ExceptionDelegate systemDelegate;

			private static ExceptionArgumentDelegate argumentDelegate;

			private static ExceptionArgumentDelegate argumentNullDelegate;

			private static ExceptionArgumentDelegate argumentOutOfRangeDelegate;

			[DllImport("__Internal")]
			[MonoPInvokeCallback]
			public static extern void SWIGRegisterExceptionCallbacks_UsdCs(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate);

			[DllImport("__Internal", EntryPoint = "SWIGRegisterExceptionArgumentCallbacks_UsdCs")]
			[MonoPInvokeCallback]
			public static extern void SWIGRegisterExceptionCallbacksArgument_UsdCs(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate);

			[MonoPInvokeCallback]
			private static void SetPendingApplicationException(string message)
			{
				SWIGPendingException.Set(new ApplicationException(message, SWIGPendingException.Retrieve()));
			}

			[MonoPInvokeCallback]
			private static void SetPendingArithmeticException(string message)
			{
				SWIGPendingException.Set(new ArithmeticException(message, SWIGPendingException.Retrieve()));
			}

			[MonoPInvokeCallback]
			private static void SetPendingDivideByZeroException(string message)
			{
				SWIGPendingException.Set(new DivideByZeroException(message, SWIGPendingException.Retrieve()));
			}

			[MonoPInvokeCallback]
			private static void SetPendingIndexOutOfRangeException(string message)
			{
				SWIGPendingException.Set(new IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
			}

			[MonoPInvokeCallback]
			private static void SetPendingInvalidCastException(string message)
			{
				SWIGPendingException.Set(new InvalidCastException(message, SWIGPendingException.Retrieve()));
			}

			[MonoPInvokeCallback]
			private static void SetPendingInvalidOperationException(string message)
			{
				SWIGPendingException.Set(new InvalidOperationException(message, SWIGPendingException.Retrieve()));
			}

			[MonoPInvokeCallback]
			private static void SetPendingIOException(string message)
			{
				SWIGPendingException.Set(new IOException(message, SWIGPendingException.Retrieve()));
			}

			[MonoPInvokeCallback]
			private static void SetPendingNullReferenceException(string message)
			{
				SWIGPendingException.Set(new NullReferenceException(message, SWIGPendingException.Retrieve()));
			}

			[MonoPInvokeCallback]
			private static void SetPendingOutOfMemoryException(string message)
			{
				SWIGPendingException.Set(new OutOfMemoryException(message, SWIGPendingException.Retrieve()));
			}

			[MonoPInvokeCallback]
			private static void SetPendingOverflowException(string message)
			{
				SWIGPendingException.Set(new OverflowException(message, SWIGPendingException.Retrieve()));
			}

			[MonoPInvokeCallback]
			private static void SetPendingSystemException(string message)
			{
				SWIGPendingException.Set(new SystemException(message, SWIGPendingException.Retrieve()));
			}

			[MonoPInvokeCallback]
			private static void SetPendingArgumentException(string message, string paramName)
			{
				SWIGPendingException.Set(new ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
			}

			[MonoPInvokeCallback]
			private static void SetPendingArgumentNullException(string message, string paramName)
			{
				Exception ex = SWIGPendingException.Retrieve();
				if (ex != null)
				{
					message = message + " Inner Exception: " + ex.Message;
				}
				SWIGPendingException.Set(new ArgumentNullException(paramName, message));
			}

			[MonoPInvokeCallback]
			private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
			{
				Exception ex = SWIGPendingException.Retrieve();
				if (ex != null)
				{
					message = message + " Inner Exception: " + ex.Message;
				}
				SWIGPendingException.Set(new ArgumentOutOfRangeException(paramName, message));
			}

			static SWIGExceptionHelper()
			{
				applicationDelegate = SetPendingApplicationException;
				arithmeticDelegate = SetPendingArithmeticException;
				divideByZeroDelegate = SetPendingDivideByZeroException;
				indexOutOfRangeDelegate = SetPendingIndexOutOfRangeException;
				invalidCastDelegate = SetPendingInvalidCastException;
				invalidOperationDelegate = SetPendingInvalidOperationException;
				ioDelegate = SetPendingIOException;
				nullReferenceDelegate = SetPendingNullReferenceException;
				outOfMemoryDelegate = SetPendingOutOfMemoryException;
				overflowDelegate = SetPendingOverflowException;
				systemDelegate = SetPendingSystemException;
				argumentDelegate = SetPendingArgumentException;
				argumentNullDelegate = SetPendingArgumentNullException;
				argumentOutOfRangeDelegate = SetPendingArgumentOutOfRangeException;
				SWIGRegisterExceptionCallbacks_UsdCs(applicationDelegate, arithmeticDelegate, divideByZeroDelegate, indexOutOfRangeDelegate, invalidCastDelegate, invalidOperationDelegate, ioDelegate, nullReferenceDelegate, outOfMemoryDelegate, overflowDelegate, systemDelegate);
				SWIGRegisterExceptionCallbacksArgument_UsdCs(argumentDelegate, argumentNullDelegate, argumentOutOfRangeDelegate);
			}
		}

		public class SWIGPendingException
		{
			[ThreadStatic]
			private static Exception pendingException;

			private static int numExceptionsPending;

			private static object exceptionsLock;

			public static bool Pending
			{
				get
				{
					bool result = false;
					if (numExceptionsPending > 0 && pendingException != null)
					{
						result = true;
					}
					return result;
				}
			}

			public static void Set(Exception e)
			{
				if (pendingException != null)
				{
					throw new ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
				}
				pendingException = e;
				lock (exceptionsLock)
				{
					numExceptionsPending++;
				}
			}

			public static Exception Retrieve()
			{
				Exception result = null;
				if (numExceptionsPending > 0 && pendingException != null)
				{
					result = pendingException;
					pendingException = null;
					lock (exceptionsLock)
					{
						numExceptionsPending--;
					}
				}
				return result;
			}

			static SWIGPendingException()
			{
				exceptionsLock = new object();
			}
		}

		protected static SWIGStringHelper swigStringHelper;

		protected static SWIGExceptionHelper swigExceptionHelper;

		static UsdCsPINVOKE()
		{
			swigStringHelper = new SWIGStringHelper();
			swigExceptionHelper = new SWIGExceptionHelper();
		}

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SetEnv")]
		public static extern void SetEnv(string jarg1, string jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_GetFusedTransform")]
		public static extern IntPtr GetFusedTransform(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_WriteUsdZip")]
		public static extern bool WriteUsdZip(string jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_GetFusedDisplayColor")]
		public static extern IntPtr GetFusedDisplayColor(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_SetFusedDisplayColor")]
		public static extern bool SetFusedDisplayColor(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);
	}
}
