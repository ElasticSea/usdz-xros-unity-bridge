using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdUtilsSparseValueWriter : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdUtilsSparseValueWriter(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdUtilsSparseValueWriter obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdUtilsSparseValueWriter obj)
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

		~UsdUtilsSparseValueWriter()
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
						UsdUtilsPINVOKE.delete_UsdUtilsSparseValueWriter(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public bool SetAttribute(UsdAttribute attr, VtValue value, UsdTimeCode time)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsSparseValueWriter_SetAttribute__SWIG_0(swigCPtr, UsdAttribute.getCPtr(attr), VtValue.getCPtr(value), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetAttribute(UsdAttribute attr, VtValue value)
		{
			bool result = UsdUtilsPINVOKE.UsdUtilsSparseValueWriter_SetAttribute__SWIG_1(swigCPtr, UsdAttribute.getCPtr(attr), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Clear()
		{
			UsdUtilsPINVOKE.UsdUtilsSparseValueWriter_Clear(swigCPtr);
		}

		public SWIGTYPE_p_std__vectorT_UsdUtilsSparseAttrValueWriter_t GetSparseAttrValueWriters()
		{
			return new SWIGTYPE_p_std__vectorT_UsdUtilsSparseAttrValueWriter_t(UsdUtilsPINVOKE.UsdUtilsSparseValueWriter_GetSparseAttrValueWriters(swigCPtr), futureUse: true);
		}

		public UsdUtilsSparseValueWriter()
			: this(UsdUtilsPINVOKE.new_UsdUtilsSparseValueWriter(), cMemoryOwn: true)
		{
		}
	}
}
