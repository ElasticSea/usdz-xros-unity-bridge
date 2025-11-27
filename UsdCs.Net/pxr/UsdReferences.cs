using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdReferences : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdReferences(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdReferences obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdReferences obj)
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

		~UsdReferences()
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
						UsdPINVOKE.delete_UsdReferences(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public bool AddReference(SdfReference ref_, UsdListPosition position)
		{
			bool result = UsdPINVOKE.UsdReferences_AddReference__SWIG_0(swigCPtr, SdfReference.getCPtr(ref_), (int)position);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddReference(SdfReference ref_)
		{
			bool result = UsdPINVOKE.UsdReferences_AddReference__SWIG_1(swigCPtr, SdfReference.getCPtr(ref_));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddReference(string identifier, SdfPath primPath, SdfLayerOffset layerOffset, UsdListPosition position)
		{
			bool result = UsdPINVOKE.UsdReferences_AddReference__SWIG_2(swigCPtr, identifier, SdfPath.getCPtr(primPath), SdfLayerOffset.getCPtr(layerOffset), (int)position);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddReference(string identifier, SdfPath primPath, SdfLayerOffset layerOffset)
		{
			bool result = UsdPINVOKE.UsdReferences_AddReference__SWIG_3(swigCPtr, identifier, SdfPath.getCPtr(primPath), SdfLayerOffset.getCPtr(layerOffset));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddReference(string identifier, SdfPath primPath)
		{
			bool result = UsdPINVOKE.UsdReferences_AddReference__SWIG_4(swigCPtr, identifier, SdfPath.getCPtr(primPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddReference(string identifier, SdfLayerOffset layerOffset, UsdListPosition position)
		{
			bool result = UsdPINVOKE.UsdReferences_AddReference__SWIG_5(swigCPtr, identifier, SdfLayerOffset.getCPtr(layerOffset), (int)position);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddReference(string identifier, SdfLayerOffset layerOffset)
		{
			bool result = UsdPINVOKE.UsdReferences_AddReference__SWIG_6(swigCPtr, identifier, SdfLayerOffset.getCPtr(layerOffset));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddReference(string identifier)
		{
			bool result = UsdPINVOKE.UsdReferences_AddReference__SWIG_7(swigCPtr, identifier);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddInternalReference(SdfPath primPath, SdfLayerOffset layerOffset, UsdListPosition position)
		{
			bool result = UsdPINVOKE.UsdReferences_AddInternalReference__SWIG_0(swigCPtr, SdfPath.getCPtr(primPath), SdfLayerOffset.getCPtr(layerOffset), (int)position);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddInternalReference(SdfPath primPath, SdfLayerOffset layerOffset)
		{
			bool result = UsdPINVOKE.UsdReferences_AddInternalReference__SWIG_1(swigCPtr, SdfPath.getCPtr(primPath), SdfLayerOffset.getCPtr(layerOffset));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddInternalReference(SdfPath primPath)
		{
			bool result = UsdPINVOKE.UsdReferences_AddInternalReference__SWIG_2(swigCPtr, SdfPath.getCPtr(primPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool RemoveReference(SdfReference ref_)
		{
			bool result = UsdPINVOKE.UsdReferences_RemoveReference(swigCPtr, SdfReference.getCPtr(ref_));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ClearReferences()
		{
			return UsdPINVOKE.UsdReferences_ClearReferences(swigCPtr);
		}

		public bool SetReferences(StdReferenceVector items)
		{
			bool result = UsdPINVOKE.UsdReferences_SetReferences(swigCPtr, StdReferenceVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPrim GetPrim()
		{
			return new UsdPrim(UsdPINVOKE.UsdReferences_GetPrim__SWIG_0(swigCPtr), cMemoryOwn: false);
		}
	}
}
