using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class NdrSdfTypeIndicator : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfValueTypeName first
		{
			get
			{
				IntPtr intPtr = NdrPINVOKE.NdrSdfTypeIndicator_first_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new SdfValueTypeName(intPtr, cMemoryOwn: false);
			}
			set
			{
				NdrPINVOKE.NdrSdfTypeIndicator_first_set(swigCPtr, SdfValueTypeName.getCPtr(value));
			}
		}

		public TfToken second
		{
			get
			{
				IntPtr intPtr = NdrPINVOKE.NdrSdfTypeIndicator_second_get(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new TfToken(intPtr, cMemoryOwn: false);
			}
			set
			{
				NdrPINVOKE.NdrSdfTypeIndicator_second_set(swigCPtr, TfToken.getCPtr(value));
			}
		}

		public NdrSdfTypeIndicator(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(NdrSdfTypeIndicator obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(NdrSdfTypeIndicator obj)
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

		~NdrSdfTypeIndicator()
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
						NdrPINVOKE.delete_NdrSdfTypeIndicator(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public NdrSdfTypeIndicator()
			: this(NdrPINVOKE.new_NdrSdfTypeIndicator__SWIG_0(), cMemoryOwn: true)
		{
		}

		public NdrSdfTypeIndicator(SdfValueTypeName first, TfToken second)
			: this(NdrPINVOKE.new_NdrSdfTypeIndicator__SWIG_1(SdfValueTypeName.getCPtr(first), TfToken.getCPtr(second)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public NdrSdfTypeIndicator(NdrSdfTypeIndicator other)
			: this(NdrPINVOKE.new_NdrSdfTypeIndicator__SWIG_2(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
