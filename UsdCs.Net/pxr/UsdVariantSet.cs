using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdVariantSet : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdVariantSet(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdVariantSet obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdVariantSet obj)
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

		~UsdVariantSet()
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
						UsdPINVOKE.delete_UsdVariantSet(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public bool AddVariant(string variantName, UsdListPosition position)
		{
			bool result = UsdPINVOKE.UsdVariantSet_AddVariant__SWIG_0(swigCPtr, variantName, (int)position);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddVariant(string variantName)
		{
			bool result = UsdPINVOKE.UsdVariantSet_AddVariant__SWIG_1(swigCPtr, variantName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public StdStringVector GetVariantNames()
		{
			return new StdStringVector(UsdPINVOKE.UsdVariantSet_GetVariantNames(swigCPtr), cMemoryOwn: true);
		}

		public bool HasAuthoredVariant(string variantName)
		{
			bool result = UsdPINVOKE.UsdVariantSet_HasAuthoredVariant(swigCPtr, variantName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string GetVariantSelection()
		{
			return UsdPINVOKE.UsdVariantSet_GetVariantSelection(swigCPtr);
		}

		public bool HasAuthoredVariantSelection(out string value)
		{
			bool result = UsdPINVOKE.UsdVariantSet_HasAuthoredVariantSelection__SWIG_0(swigCPtr, out value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasAuthoredVariantSelection()
		{
			return UsdPINVOKE.UsdVariantSet_HasAuthoredVariantSelection__SWIG_1(swigCPtr);
		}

		public bool SetVariantSelection(string variantName)
		{
			bool result = UsdPINVOKE.UsdVariantSet_SetVariantSelection(swigCPtr, variantName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ClearVariantSelection()
		{
			return UsdPINVOKE.UsdVariantSet_ClearVariantSelection(swigCPtr);
		}

		public bool BlockVariantSelection()
		{
			return UsdPINVOKE.UsdVariantSet_BlockVariantSelection(swigCPtr);
		}

		public UsdEditTarget GetVariantEditTarget(SdfLayerHandle layer)
		{
			UsdEditTarget result = new UsdEditTarget(UsdPINVOKE.UsdVariantSet_GetVariantEditTarget__SWIG_0(swigCPtr, SdfLayerHandle.getCPtr(layer)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdEditTarget GetVariantEditTarget()
		{
			return new UsdEditTarget(UsdPINVOKE.UsdVariantSet_GetVariantEditTarget__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public VariantEditContext GetVariantEditContext(SdfLayerHandle layer)
		{
			VariantEditContext result = new VariantEditContext(UsdPINVOKE.UsdVariantSet_GetVariantEditContext__SWIG_0(swigCPtr, SdfLayerHandle.getCPtr(layer)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VariantEditContext GetVariantEditContext()
		{
			return new VariantEditContext(UsdPINVOKE.UsdVariantSet_GetVariantEditContext__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdPrim GetPrim()
		{
			return new UsdPrim(UsdPINVOKE.UsdVariantSet_GetPrim(swigCPtr), cMemoryOwn: false);
		}

		public string GetName()
		{
			return UsdPINVOKE.UsdVariantSet_GetName(swigCPtr);
		}

		public bool IsValid()
		{
			return UsdPINVOKE.UsdVariantSet_IsValid(swigCPtr);
		}
	}
}
