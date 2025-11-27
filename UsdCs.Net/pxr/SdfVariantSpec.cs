using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfVariantSpec : SdfSpec
	{
		private HandleRef swigCPtr;

		private bool swigCMemOwnDerived;

		internal SdfVariantSpec(IntPtr cPtr, bool cMemoryOwn)
			: base(SdfPINVOKE.SdfVariantSpec_SWIGSmartPtrUpcast(cPtr), cMemoryOwn: true)
		{
			swigCMemOwnDerived = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		internal static HandleRef getCPtr(SdfVariantSpec obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		protected override void Dispose(bool disposing)
		{
			lock (this)
			{
				if (swigCPtr.Handle != IntPtr.Zero)
				{
					if (swigCMemOwnDerived)
					{
						swigCMemOwnDerived = false;
						SdfPINVOKE.delete_SdfVariantSpec(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public static SdfVariantSpecHandle New(SdfVariantSetSpecHandle owner, string name)
		{
			SdfVariantSpecHandle result = new SdfVariantSpecHandle(SdfPINVOKE.SdfVariantSpec_New(SdfVariantSetSpecHandle.getCPtr(owner), name), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string GetName()
		{
			string result = SdfPINVOKE.SdfVariantSpec_GetName(swigCPtr);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfToken GetNameToken()
		{
			TfToken result = new TfToken(SdfPINVOKE.SdfVariantSpec_GetNameToken(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfVariantSetSpecHandle GetOwner()
		{
			SdfVariantSetSpecHandle result = new SdfVariantSetSpecHandle(SdfPINVOKE.SdfVariantSpec_GetOwner(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPrimSpecHandle GetPrimSpec()
		{
			SdfPrimSpecHandle result = new SdfPrimSpecHandle(SdfPINVOKE.SdfVariantSpec_GetPrimSpec(swigCPtr), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public StdStringVector GetVariantNames(string name)
		{
			StdStringVector result = new StdStringVector(SdfPINVOKE.SdfVariantSpec_GetVariantNames(swigCPtr, name), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
