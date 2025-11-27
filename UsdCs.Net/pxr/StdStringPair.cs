using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class StdStringPair : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public string first
		{
			get
			{
				string result = StdPINVOKE.StdStringPair_first_get(swigCPtr);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
			set
			{
				StdPINVOKE.StdStringPair_first_set(swigCPtr, value);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
		}

		public string second
		{
			get
			{
				string result = StdPINVOKE.StdStringPair_second_get(swigCPtr);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}
			set
			{
				StdPINVOKE.StdStringPair_second_set(swigCPtr, value);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}
		}

		public StdStringPair(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(StdStringPair obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(StdStringPair obj)
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

		~StdStringPair()
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
						StdPINVOKE.delete_StdStringPair(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public StdStringPair()
			: this(StdPINVOKE.new_StdStringPair__SWIG_0(), cMemoryOwn: true)
		{
		}

		public StdStringPair(string first, string second)
			: this(StdPINVOKE.new_StdStringPair__SWIG_1(first, second), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public StdStringPair(StdStringPair other)
			: this(StdPINVOKE.new_StdStringPair__SWIG_2(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
