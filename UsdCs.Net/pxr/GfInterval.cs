using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfInterval : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public GfInterval(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfInterval obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfInterval obj)
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

		~GfInterval()
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
						GfPINVOKE.delete_GfInterval(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfInterval()
			: this(GfPINVOKE.new_GfInterval__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfInterval(double val)
			: this(GfPINVOKE.new_GfInterval__SWIG_1(val), cMemoryOwn: true)
		{
		}

		public GfInterval(double min, double max, bool minClosed, bool maxClosed)
			: this(GfPINVOKE.new_GfInterval__SWIG_2(min, max, minClosed, maxClosed), cMemoryOwn: true)
		{
		}

		public GfInterval(double min, double max, bool minClosed)
			: this(GfPINVOKE.new_GfInterval__SWIG_3(min, max, minClosed), cMemoryOwn: true)
		{
		}

		public GfInterval(double min, double max)
			: this(GfPINVOKE.new_GfInterval__SWIG_4(min, max), cMemoryOwn: true)
		{
		}

		public uint Hash()
		{
			return GfPINVOKE.GfInterval_Hash(swigCPtr);
		}

		public double GetMin()
		{
			return GfPINVOKE.GfInterval_GetMin(swigCPtr);
		}

		public double GetMax()
		{
			return GfPINVOKE.GfInterval_GetMax(swigCPtr);
		}

		public void SetMin(double v)
		{
			GfPINVOKE.GfInterval_SetMin__SWIG_0(swigCPtr, v);
		}

		public void SetMin(double v, bool minClosed)
		{
			GfPINVOKE.GfInterval_SetMin__SWIG_1(swigCPtr, v, minClosed);
		}

		public void SetMax(double v)
		{
			GfPINVOKE.GfInterval_SetMax__SWIG_0(swigCPtr, v);
		}

		public void SetMax(double v, bool maxClosed)
		{
			GfPINVOKE.GfInterval_SetMax__SWIG_1(swigCPtr, v, maxClosed);
		}

		public bool IsMinClosed()
		{
			return GfPINVOKE.GfInterval_IsMinClosed(swigCPtr);
		}

		public bool IsMaxClosed()
		{
			return GfPINVOKE.GfInterval_IsMaxClosed(swigCPtr);
		}

		public bool IsMinOpen()
		{
			return GfPINVOKE.GfInterval_IsMinOpen(swigCPtr);
		}

		public bool IsMaxOpen()
		{
			return GfPINVOKE.GfInterval_IsMaxOpen(swigCPtr);
		}

		public bool IsMaxFinite()
		{
			return GfPINVOKE.GfInterval_IsMaxFinite(swigCPtr);
		}

		public bool IsMinFinite()
		{
			return GfPINVOKE.GfInterval_IsMinFinite(swigCPtr);
		}

		public bool IsFinite()
		{
			return GfPINVOKE.GfInterval_IsFinite(swigCPtr);
		}

		public bool IsEmpty()
		{
			return GfPINVOKE.GfInterval_IsEmpty(swigCPtr);
		}

		public double GetSize()
		{
			return GfPINVOKE.GfInterval_GetSize(swigCPtr);
		}

		public double Size()
		{
			return GfPINVOKE.GfInterval_Size(swigCPtr);
		}

		public bool Contains(double d)
		{
			return GfPINVOKE.GfInterval_Contains__SWIG_0(swigCPtr, d);
		}

		public bool In(double d)
		{
			return GfPINVOKE.GfInterval_In(swigCPtr, d);
		}

		public bool Contains(GfInterval i)
		{
			bool result = GfPINVOKE.GfInterval_Contains__SWIG_1(swigCPtr, getCPtr(i));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersects(GfInterval i)
		{
			bool result = GfPINVOKE.GfInterval_Intersects(swigCPtr, getCPtr(i));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfInterval GetFullInterval()
		{
			return new GfInterval(GfPINVOKE.GfInterval_GetFullInterval(), cMemoryOwn: true);
		}

		public static bool Equals(GfInterval lhs, GfInterval rhs)
		{
			bool result = GfPINVOKE.GfInterval_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfInterval lhs, GfInterval rhs)
		{
			bool flag = (object)lhs == null;
			bool flag2 = (object)rhs == null;
			if (flag == flag2)
			{
				if (!(flag && flag2))
				{
					return Equals(lhs, rhs);
				}
				return true;
			}
			return false;
		}

		public static bool operator !=(GfInterval lhs, GfInterval rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfInterval);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfInterval_GetHashCode(swigCPtr);
		}
	}
}
