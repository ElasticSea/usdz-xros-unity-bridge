using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfPayload : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfPayload(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfPayload obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfPayload obj)
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

		~SdfPayload()
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
						SdfPINVOKE.delete_SdfPayload(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfPayload(string assetPath, SdfPath primPath, SdfLayerOffset layerOffset)
			: this(SdfPINVOKE.new_SdfPayload__SWIG_0(assetPath, SdfPath.getCPtr(primPath), SdfLayerOffset.getCPtr(layerOffset)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfPayload(string assetPath, SdfPath primPath)
			: this(SdfPINVOKE.new_SdfPayload__SWIG_1(assetPath, SdfPath.getCPtr(primPath)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfPayload(string assetPath)
			: this(SdfPINVOKE.new_SdfPayload__SWIG_2(assetPath), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfPayload()
			: this(SdfPINVOKE.new_SdfPayload__SWIG_3(), cMemoryOwn: true)
		{
		}

		public string GetAssetPath()
		{
			return SdfPINVOKE.SdfPayload_GetAssetPath(swigCPtr);
		}

		public void SetAssetPath(string assetPath)
		{
			SdfPINVOKE.SdfPayload_SetAssetPath(swigCPtr, assetPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfPath GetPrimPath()
		{
			return new SdfPath(SdfPINVOKE.SdfPayload_GetPrimPath(swigCPtr), cMemoryOwn: false);
		}

		public void SetPrimPath(SdfPath primPath)
		{
			SdfPINVOKE.SdfPayload_SetPrimPath(swigCPtr, SdfPath.getCPtr(primPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfLayerOffset GetLayerOffset()
		{
			return new SdfLayerOffset(SdfPINVOKE.SdfPayload_GetLayerOffset(swigCPtr), cMemoryOwn: false);
		}

		public void SetLayerOffset(SdfLayerOffset layerOffset)
		{
			SdfPINVOKE.SdfPayload_SetLayerOffset(swigCPtr, SdfLayerOffset.getCPtr(layerOffset));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
