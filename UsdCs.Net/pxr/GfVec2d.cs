using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfVec2d : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public const uint dimension = 2u;

		public double this[int index]
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

		public GfVec2d(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfVec2d obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfVec2d obj)
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

		~GfVec2d()
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
						GfPINVOKE.delete_GfVec2d(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfVec2d()
			: this(GfPINVOKE.new_GfVec2d__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfVec2d(double value)
			: this(GfPINVOKE.new_GfVec2d__SWIG_1(value), cMemoryOwn: true)
		{
		}

		public GfVec2d(double s0, double s1)
			: this(GfPINVOKE.new_GfVec2d__SWIG_2(s0, s1), cMemoryOwn: true)
		{
		}

		public GfVec2d(GfVec2f other)
			: this(GfPINVOKE.new_GfVec2d__SWIG_4(GfVec2f.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec2d(GfVec2h other)
			: this(GfPINVOKE.new_GfVec2d__SWIG_5(GfVec2h.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec2d(GfVec2i other)
			: this(GfPINVOKE.new_GfVec2d__SWIG_6(GfVec2i.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static GfVec2d XAxis()
		{
			return new GfVec2d(GfPINVOKE.GfVec2d_XAxis(), cMemoryOwn: true);
		}

		public static GfVec2d YAxis()
		{
			return new GfVec2d(GfPINVOKE.GfVec2d_YAxis(), cMemoryOwn: true);
		}

		public static GfVec2d Axis(uint i)
		{
			return new GfVec2d(GfPINVOKE.GfVec2d_Axis(i), cMemoryOwn: true);
		}

		public GfVec2d Set(double s0, double s1)
		{
			return new GfVec2d(GfPINVOKE.GfVec2d_Set(swigCPtr, s0, s1), cMemoryOwn: false);
		}

		public GfVec2d GetProjection(GfVec2d v)
		{
			GfVec2d result = new GfVec2d(GfPINVOKE.GfVec2d_GetProjection(swigCPtr, getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec2d GetComplement(GfVec2d b)
		{
			GfVec2d result = new GfVec2d(GfPINVOKE.GfVec2d_GetComplement(swigCPtr, getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public double GetLengthSq()
		{
			return GfPINVOKE.GfVec2d_GetLengthSq(swigCPtr);
		}

		public double GetLength()
		{
			return GfPINVOKE.GfVec2d_GetLength(swigCPtr);
		}

		public double Normalize(double eps)
		{
			return GfPINVOKE.GfVec2d_Normalize__SWIG_0(swigCPtr, eps);
		}

		public double Normalize()
		{
			return GfPINVOKE.GfVec2d_Normalize__SWIG_1(swigCPtr);
		}

		public GfVec2d GetNormalized(double eps)
		{
			return new GfVec2d(GfPINVOKE.GfVec2d_GetNormalized__SWIG_0(swigCPtr, eps), cMemoryOwn: true);
		}

		public GfVec2d GetNormalized()
		{
			return new GfVec2d(GfPINVOKE.GfVec2d_GetNormalized__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public static bool Equals(GfVec2d lhs, GfVec2d rhs)
		{
			bool result = GfPINVOKE.GfVec2d_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfVec2d lhs, GfVec2d rhs)
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

		public static bool operator !=(GfVec2d lhs, GfVec2d rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfVec2d);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfVec2d_GetHashCode(swigCPtr);
		}

		protected double GetValue(int index)
		{
			return GfPINVOKE.GfVec2d_GetValue(swigCPtr, index);
		}

		protected void SetValue(int index, double value)
		{
			GfPINVOKE.GfVec2d_SetValue(swigCPtr, index, value);
		}
	}
}
