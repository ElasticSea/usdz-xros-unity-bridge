using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfSubLayerProxy : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfSubLayerProxy(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfSubLayerProxy obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfSubLayerProxy obj)
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

		~SdfSubLayerProxy()
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
						SdfPINVOKE.delete_SdfSubLayerProxy(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public void push_back(string layerPath)
		{
			SdfPINVOKE.SdfSubLayerProxy_push_back(swigCPtr, layerPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public uint size()
		{
			return SdfPINVOKE.SdfSubLayerProxy_size(swigCPtr);
		}

		public SdfPath GetPath()
		{
			return new SdfPath(SdfPINVOKE.SdfSubLayerProxy_GetPath(swigCPtr), cMemoryOwn: true);
		}

		public uint Count(string value)
		{
			uint result = SdfPINVOKE.SdfSubLayerProxy_Count(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public uint Find(string value)
		{
			uint result = SdfPINVOKE.SdfSubLayerProxy_Find(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, string value)
		{
			SdfPINVOKE.SdfSubLayerProxy_Insert(swigCPtr, index, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void Remove(string value)
		{
			SdfPINVOKE.SdfSubLayerProxy_Remove(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void Replace(string oldValue, string newValue)
		{
			SdfPINVOKE.SdfSubLayerProxy_Replace(swigCPtr, oldValue, newValue);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void Erase(uint index)
		{
			SdfPINVOKE.SdfSubLayerProxy_Erase(swigCPtr, index);
		}

		public bool IsExpired()
		{
			return SdfPINVOKE.SdfSubLayerProxy_IsExpired(swigCPtr);
		}
	}
}
