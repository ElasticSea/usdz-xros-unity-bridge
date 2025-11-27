using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdVariantSets : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdVariantSets(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdVariantSets obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdVariantSets obj)
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

		~UsdVariantSets()
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
						UsdPINVOKE.delete_UsdVariantSets(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdVariantSet AddVariantSet(string variantSetName, UsdListPosition position)
		{
			UsdVariantSet result = new UsdVariantSet(UsdPINVOKE.UsdVariantSets_AddVariantSet__SWIG_0(swigCPtr, variantSetName, (int)position), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdVariantSet AddVariantSet(string variantSetName)
		{
			UsdVariantSet result = new UsdVariantSet(UsdPINVOKE.UsdVariantSets_AddVariantSet__SWIG_1(swigCPtr, variantSetName), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetNames(StdStringVector names)
		{
			return UsdPINVOKE.UsdVariantSets_GetNames__SWIG_0(swigCPtr, StdStringVector.getCPtr(names));
		}

		public StdStringVector GetNames()
		{
			return new StdStringVector(UsdPINVOKE.UsdVariantSets_GetNames__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdVariantSet GetVariantSet(string variantSetName)
		{
			UsdVariantSet result = new UsdVariantSet(UsdPINVOKE.UsdVariantSets_GetVariantSet(swigCPtr, variantSetName), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasVariantSet(string variantSetName)
		{
			bool result = UsdPINVOKE.UsdVariantSets_HasVariantSet(swigCPtr, variantSetName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string GetVariantSelection(string variantSetName)
		{
			string result = UsdPINVOKE.UsdVariantSets_GetVariantSelection(swigCPtr, variantSetName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetSelection(string variantSetName, string variantName)
		{
			bool result = UsdPINVOKE.UsdVariantSets_SetSelection(swigCPtr, variantSetName, variantName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public StdStringMap GetAllVariantSelections()
		{
			return new StdStringMap(UsdPINVOKE.UsdVariantSets_GetAllVariantSelections(swigCPtr), cMemoryOwn: true);
		}
	}
}
