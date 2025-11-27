using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfVec4d : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public const uint dimension = 4u;

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

		public GfVec4d(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfVec4d obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfVec4d obj)
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

		~GfVec4d()
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
						GfPINVOKE.delete_GfVec4d(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfVec4d()
			: this(GfPINVOKE.new_GfVec4d__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfVec4d(double value)
			: this(GfPINVOKE.new_GfVec4d__SWIG_1(value), cMemoryOwn: true)
		{
		}

		public GfVec4d(double s0, double s1, double s2, double s3)
			: this(GfPINVOKE.new_GfVec4d__SWIG_2(s0, s1, s2, s3), cMemoryOwn: true)
		{
		}

		public GfVec4d(GfVec4f other)
			: this(GfPINVOKE.new_GfVec4d__SWIG_4(GfVec4f.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec4d(GfVec4h other)
			: this(GfPINVOKE.new_GfVec4d__SWIG_5(GfVec4h.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec4d(GfVec4i other)
			: this(GfPINVOKE.new_GfVec4d__SWIG_6(GfVec4i.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static GfVec4d XAxis()
		{
			return new GfVec4d(GfPINVOKE.GfVec4d_XAxis(), cMemoryOwn: true);
		}

		public static GfVec4d YAxis()
		{
			return new GfVec4d(GfPINVOKE.GfVec4d_YAxis(), cMemoryOwn: true);
		}

		public static GfVec4d ZAxis()
		{
			return new GfVec4d(GfPINVOKE.GfVec4d_ZAxis(), cMemoryOwn: true);
		}

		public static GfVec4d WAxis()
		{
			return new GfVec4d(GfPINVOKE.GfVec4d_WAxis(), cMemoryOwn: true);
		}

		public static GfVec4d Axis(uint i)
		{
			return new GfVec4d(GfPINVOKE.GfVec4d_Axis(i), cMemoryOwn: true);
		}

		public GfVec4d Set(double s0, double s1, double s2, double s3)
		{
			return new GfVec4d(GfPINVOKE.GfVec4d_Set(swigCPtr, s0, s1, s2, s3), cMemoryOwn: false);
		}

		public GfVec4d GetProjection(GfVec4d v)
		{
			GfVec4d result = new GfVec4d(GfPINVOKE.GfVec4d_GetProjection(swigCPtr, getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec4d GetComplement(GfVec4d b)
		{
			GfVec4d result = new GfVec4d(GfPINVOKE.GfVec4d_GetComplement(swigCPtr, getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public double GetLengthSq()
		{
			return GfPINVOKE.GfVec4d_GetLengthSq(swigCPtr);
		}

		public double GetLength()
		{
			return GfPINVOKE.GfVec4d_GetLength(swigCPtr);
		}

		public double Normalize(double eps)
		{
			return GfPINVOKE.GfVec4d_Normalize__SWIG_0(swigCPtr, eps);
		}

		public double Normalize()
		{
			return GfPINVOKE.GfVec4d_Normalize__SWIG_1(swigCPtr);
		}

		public GfVec4d GetNormalized(double eps)
		{
			return new GfVec4d(GfPINVOKE.GfVec4d_GetNormalized__SWIG_0(swigCPtr, eps), cMemoryOwn: true);
		}

		public GfVec4d GetNormalized()
		{
			return new GfVec4d(GfPINVOKE.GfVec4d_GetNormalized__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public static bool Equals(GfVec4d lhs, GfVec4d rhs)
		{
			bool result = GfPINVOKE.GfVec4d_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfVec4d lhs, GfVec4d rhs)
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

		public static bool operator !=(GfVec4d lhs, GfVec4d rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfVec4d);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfVec4d_GetHashCode(swigCPtr);
		}

		protected double GetValue(int index)
		{
			return GfPINVOKE.GfVec4d_GetValue(swigCPtr, index);
		}

		protected void SetValue(int index, double value)
		{
			GfPINVOKE.GfVec4d_SetValue(swigCPtr, index, value);
		}
	}
}
