using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdUtilsSparseAttrValueWriter : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdUtilsSparseAttrValueWriter(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdUtilsSparseAttrValueWriter obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdUtilsSparseAttrValueWriter obj)
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

		~UsdUtilsSparseAttrValueWriter()
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
						UsdUtilsPINVOKE.delete_UsdUtilsSparseAttrValueWriter(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdUtilsSparseAttrValueWriter(UsdAttribute attr, VtValue defaultValue)
			: this(UsdUtilsPINVOKE.new_UsdUtilsSparseAttrValueWriter__SWIG_0(UsdAttribute.getCPtr(attr), VtValue.getCPtr(defaultValue)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdUtilsSparseAttrValueWriter(UsdAttribute attr)
			: this(UsdUtilsPINVOKE.new_UsdUtilsSparseAttrValueWriter__SWIG_1(UsdAttribute.getCPtr(attr)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool SetTimeSample(VtValue value, UsdTimeCode time)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsSparseAttrValueWriter_SetTimeSample__SWIG_0(swigCPtr, VtValue.getCPtr(value), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetAttr()
		{
			return new UsdAttribute(UsdUtilsPINVOKE.UsdUtilsSparseAttrValueWriter_GetAttr(swigCPtr), cMemoryOwn: false);
		}
	}
}
