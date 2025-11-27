using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdPayloads : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdPayloads(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdPayloads obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdPayloads obj)
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

		~UsdPayloads()
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
						UsdPINVOKE.delete_UsdPayloads(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public bool AddPayload(SdfPayload payload, UsdListPosition position)
		{
			bool result = UsdPINVOKE.UsdPayloads_AddPayload__SWIG_0(swigCPtr, SdfPayload.getCPtr(payload), (int)position);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddPayload(SdfPayload payload)
		{
			bool result = UsdPINVOKE.UsdPayloads_AddPayload__SWIG_1(swigCPtr, SdfPayload.getCPtr(payload));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddPayload(string identifier, SdfPath primPath, SdfLayerOffset layerOffset, UsdListPosition position)
		{
			bool result = UsdPINVOKE.UsdPayloads_AddPayload__SWIG_2(swigCPtr, identifier, SdfPath.getCPtr(primPath), SdfLayerOffset.getCPtr(layerOffset), (int)position);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddPayload(string identifier, SdfPath primPath, SdfLayerOffset layerOffset)
		{
			bool result = UsdPINVOKE.UsdPayloads_AddPayload__SWIG_3(swigCPtr, identifier, SdfPath.getCPtr(primPath), SdfLayerOffset.getCPtr(layerOffset));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddPayload(string identifier, SdfPath primPath)
		{
			bool result = UsdPINVOKE.UsdPayloads_AddPayload__SWIG_4(swigCPtr, identifier, SdfPath.getCPtr(primPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddPayload(string identifier, SdfLayerOffset layerOffset, UsdListPosition position)
		{
			bool result = UsdPINVOKE.UsdPayloads_AddPayload__SWIG_5(swigCPtr, identifier, SdfLayerOffset.getCPtr(layerOffset), (int)position);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddPayload(string identifier, SdfLayerOffset layerOffset)
		{
			bool result = UsdPINVOKE.UsdPayloads_AddPayload__SWIG_6(swigCPtr, identifier, SdfLayerOffset.getCPtr(layerOffset));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddPayload(string identifier)
		{
			bool result = UsdPINVOKE.UsdPayloads_AddPayload__SWIG_7(swigCPtr, identifier);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddInternalPayload(SdfPath primPath, SdfLayerOffset layerOffset, UsdListPosition position)
		{
			bool result = UsdPINVOKE.UsdPayloads_AddInternalPayload__SWIG_0(swigCPtr, SdfPath.getCPtr(primPath), SdfLayerOffset.getCPtr(layerOffset), (int)position);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddInternalPayload(SdfPath primPath, SdfLayerOffset layerOffset)
		{
			bool result = UsdPINVOKE.UsdPayloads_AddInternalPayload__SWIG_1(swigCPtr, SdfPath.getCPtr(primPath), SdfLayerOffset.getCPtr(layerOffset));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddInternalPayload(SdfPath primPath)
		{
			bool result = UsdPINVOKE.UsdPayloads_AddInternalPayload__SWIG_2(swigCPtr, SdfPath.getCPtr(primPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool RemovePayload(SdfPayload ref_)
		{
			bool result = UsdPINVOKE.UsdPayloads_RemovePayload(swigCPtr, SdfPayload.getCPtr(ref_));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ClearPayloads()
		{
			return UsdPINVOKE.UsdPayloads_ClearPayloads(swigCPtr);
		}

		public bool SetPayloads(SdfPayloadVector items)
		{
			bool result = UsdPINVOKE.UsdPayloads_SetPayloads(swigCPtr, SdfPayloadVector.getCPtr(items));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdPrim GetPrim()
		{
			return new UsdPrim(UsdPINVOKE.UsdPayloads_GetPrim__SWIG_0(swigCPtr), cMemoryOwn: false);
		}
	}
}
