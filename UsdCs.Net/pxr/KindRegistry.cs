using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class KindRegistry : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public KindRegistry(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(KindRegistry obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(KindRegistry obj)
		{
			if (obj != null)
			{
				if (!obj.swigCMemOwn)
				{
					throw new ApplicationException("Cannot release ownership as memory is not owned");
				}
				HandleRef result = obj.swigCPtr;
				obj.swigCMemOwn = false;
				obj.Dispose();
				return result;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		~KindRegistry()
		{
			Dispose(disposing: false);
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			lock (this)
			{
				if (swigCPtr.Handle != IntPtr.Zero)
				{
					if (swigCMemOwn)
					{
						swigCMemOwn = false;
						throw new MethodAccessException("C++ destructor does not have public access");
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public static KindRegistry GetInstance()
		{
			return new KindRegistry(KindPINVOKE.KindRegistry_GetInstance(), cMemoryOwn: false);
		}

		public static bool HasKind(TfToken kind)
		{
			bool result = KindPINVOKE.KindRegistry_HasKind(TfToken.getCPtr(kind));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfToken GetBaseKind(TfToken kind)
		{
			TfToken result = new TfToken(KindPINVOKE.KindRegistry_GetBaseKind(TfToken.getCPtr(kind)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IsA(TfToken derivedKind, TfToken baseKind)
		{
			bool result = KindPINVOKE.KindRegistry_IsA(TfToken.getCPtr(derivedKind), TfToken.getCPtr(baseKind));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfTokenVector GetAllKinds()
		{
			return new TfTokenVector(KindPINVOKE.KindRegistry_GetAllKinds(), cMemoryOwn: true);
		}
	}
}
