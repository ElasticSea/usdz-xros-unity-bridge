using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdShadeTokenAttributeTypePair : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public TfToken first
		{
			get
			{
				IntPtr intPtr = UsdShadePINVOKE.UsdShadeTokenAttributeTypePair_first_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new TfToken(intPtr, cMemoryOwn: false);
			}
			set
			{
				UsdShadePINVOKE.UsdShadeTokenAttributeTypePair_first_set(swigCPtr, TfToken.getCPtr(value));
			}
		}

		public UsdShadeAttributeType second
		{
			get
			{
				return (UsdShadeAttributeType)UsdShadePINVOKE.UsdShadeTokenAttributeTypePair_second_get(swigCPtr);
			}
			set
			{
				UsdShadePINVOKE.UsdShadeTokenAttributeTypePair_second_set(swigCPtr, (int)value);
			}
		}

		public UsdShadeTokenAttributeTypePair(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdShadeTokenAttributeTypePair obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdShadeTokenAttributeTypePair obj)
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

		~UsdShadeTokenAttributeTypePair()
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
						UsdShadePINVOKE.delete_UsdShadeTokenAttributeTypePair(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdShadeTokenAttributeTypePair()
			: this(UsdShadePINVOKE.new_UsdShadeTokenAttributeTypePair__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdShadeTokenAttributeTypePair(TfToken first, UsdShadeAttributeType second)
			: this(UsdShadePINVOKE.new_UsdShadeTokenAttributeTypePair__SWIG_1(TfToken.getCPtr(first), (int)second), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeTokenAttributeTypePair(UsdShadeTokenAttributeTypePair other)
			: this(UsdShadePINVOKE.new_UsdShadeTokenAttributeTypePair__SWIG_2(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
