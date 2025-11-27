using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdMetadataValueMap : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public VtValue this[TfToken index]
		{
			get
			{
				return GetValue(index);
			}
			set
			{
				SetValue(index, value);
			}
		}

		public UsdMetadataValueMap(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdMetadataValueMap obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdMetadataValueMap obj)
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

		~UsdMetadataValueMap()
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
						UsdPINVOKE.delete_UsdMetadataValueMap(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public TfTokenVector GetKeys()
		{
			return new TfTokenVector(UsdPINVOKE.UsdMetadataValueMap_GetKeys(swigCPtr), cMemoryOwn: true);
		}

		public VtValue GetValue(TfToken key)
		{
			VtValue result = new VtValue(UsdPINVOKE.UsdMetadataValueMap_GetValue(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		protected void SetValue(TfToken key, VtValue value)
		{
			UsdPINVOKE.UsdMetadataValueMap_SetValue(swigCPtr, TfToken.getCPtr(key), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdMetadataValueMap()
			: this(UsdPINVOKE.new_UsdMetadataValueMap(), cMemoryOwn: true)
		{
		}
	}
}
