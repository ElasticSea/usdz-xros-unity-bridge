using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfVariantSetSpec : SdfSpec
	{
		private HandleRef swigCPtr;

		public SdfVariantSetSpec(IntPtr cPtr, bool cMemoryOwn)
			: base(SdfPINVOKE.SdfVariantSetSpec_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfVariantSetSpec obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfVariantSetSpec obj)
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

		protected override void Dispose(bool disposing)
		{
			lock (this)
			{
				if (swigCPtr.Handle != IntPtr.Zero)
				{
					if (swigCMemOwn)
					{
						swigCMemOwn = false;
						SdfPINVOKE.delete_SdfVariantSetSpec(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public static SdfVariantSetSpecHandle New(SdfPrimSpecHandle prim, string name)
		{
			SdfVariantSetSpecHandle result = new SdfVariantSetSpecHandle(SdfPINVOKE.SdfVariantSetSpec_New__SWIG_0(SdfPrimSpecHandle.getCPtr(prim), name), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfVariantSetSpecHandle New(SdfVariantSpecHandle prim, string name)
		{
			SdfVariantSetSpecHandle result = new SdfVariantSetSpecHandle(SdfPINVOKE.SdfVariantSetSpec_New__SWIG_1(SdfVariantSpecHandle.getCPtr(prim), name), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string GetName()
		{
			return SdfPINVOKE.SdfVariantSetSpec_GetName(swigCPtr);
		}

		public TfToken GetNameToken()
		{
			return new TfToken(SdfPINVOKE.SdfVariantSetSpec_GetNameToken(swigCPtr), cMemoryOwn: true);
		}

		public SdfSpecHandle GetOwner()
		{
			return new SdfSpecHandle(SdfPINVOKE.SdfVariantSetSpec_GetOwner(swigCPtr), cMemoryOwn: true);
		}

		public SWIGTYPE_p_SdfVariantView GetVariants()
		{
			return new SWIGTYPE_p_SdfVariantView(SdfPINVOKE.SdfVariantSetSpec_GetVariants(swigCPtr), futureUse: true);
		}

		public SdfVariantSpecHandleVector GetVariantList()
		{
			return new SdfVariantSpecHandleVector(SdfPINVOKE.SdfVariantSetSpec_GetVariantList(swigCPtr), cMemoryOwn: true);
		}

		public void RemoveVariant(SdfVariantSpecHandle variant)
		{
			SdfPINVOKE.SdfVariantSetSpec_RemoveVariant(swigCPtr, SdfVariantSpecHandle.getCPtr(variant));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
