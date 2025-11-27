using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfVec3d : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public const uint dimension = 3u;

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

		public GfVec3d(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfVec3d obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfVec3d obj)
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

		~GfVec3d()
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
						GfPINVOKE.delete_GfVec3d(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfVec3d()
			: this(GfPINVOKE.new_GfVec3d__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfVec3d(double value)
			: this(GfPINVOKE.new_GfVec3d__SWIG_1(value), cMemoryOwn: true)
		{
		}

		public GfVec3d(double s0, double s1, double s2)
			: this(GfPINVOKE.new_GfVec3d__SWIG_2(s0, s1, s2), cMemoryOwn: true)
		{
		}

		public GfVec3d(GfVec3f other)
			: this(GfPINVOKE.new_GfVec3d__SWIG_4(GfVec3f.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec3d(GfVec3h other)
			: this(GfPINVOKE.new_GfVec3d__SWIG_5(GfVec3h.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec3d(GfVec3i other)
			: this(GfPINVOKE.new_GfVec3d__SWIG_6(GfVec3i.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static GfVec3d XAxis()
		{
			return new GfVec3d(GfPINVOKE.GfVec3d_XAxis(), cMemoryOwn: true);
		}

		public static GfVec3d YAxis()
		{
			return new GfVec3d(GfPINVOKE.GfVec3d_YAxis(), cMemoryOwn: true);
		}

		public static GfVec3d ZAxis()
		{
			return new GfVec3d(GfPINVOKE.GfVec3d_ZAxis(), cMemoryOwn: true);
		}

		public static GfVec3d Axis(uint i)
		{
			return new GfVec3d(GfPINVOKE.GfVec3d_Axis(i), cMemoryOwn: true);
		}

		public GfVec3d Set(double s0, double s1, double s2)
		{
			return new GfVec3d(GfPINVOKE.GfVec3d_Set(swigCPtr, s0, s1, s2), cMemoryOwn: false);
		}

		public GfVec3d GetProjection(GfVec3d v)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfVec3d_GetProjection(swigCPtr, getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec3d GetComplement(GfVec3d b)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfVec3d_GetComplement(swigCPtr, getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public double GetLengthSq()
		{
			return GfPINVOKE.GfVec3d_GetLengthSq(swigCPtr);
		}

		public double GetLength()
		{
			return GfPINVOKE.GfVec3d_GetLength(swigCPtr);
		}

		public double Normalize(double eps)
		{
			return GfPINVOKE.GfVec3d_Normalize__SWIG_0(swigCPtr, eps);
		}

		public double Normalize()
		{
			return GfPINVOKE.GfVec3d_Normalize__SWIG_1(swigCPtr);
		}

		public GfVec3d GetNormalized(double eps)
		{
			return new GfVec3d(GfPINVOKE.GfVec3d_GetNormalized__SWIG_0(swigCPtr, eps), cMemoryOwn: true);
		}

		public GfVec3d GetNormalized()
		{
			return new GfVec3d(GfPINVOKE.GfVec3d_GetNormalized__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public static bool OrthogonalizeBasis(GfVec3d tx, GfVec3d ty, GfVec3d tz, bool normalize, double eps)
		{
			return GfPINVOKE.GfVec3d_OrthogonalizeBasis__SWIG_0(getCPtr(tx), getCPtr(ty), getCPtr(tz), normalize, eps);
		}

		public static bool OrthogonalizeBasis(GfVec3d tx, GfVec3d ty, GfVec3d tz, bool normalize)
		{
			return GfPINVOKE.GfVec3d_OrthogonalizeBasis__SWIG_1(getCPtr(tx), getCPtr(ty), getCPtr(tz), normalize);
		}

		public void BuildOrthonormalFrame(GfVec3d v1, GfVec3d v2, double eps)
		{
			GfPINVOKE.GfVec3d_BuildOrthonormalFrame__SWIG_0(swigCPtr, getCPtr(v1), getCPtr(v2), eps);
		}

		public void BuildOrthonormalFrame(GfVec3d v1, GfVec3d v2)
		{
			GfPINVOKE.GfVec3d_BuildOrthonormalFrame__SWIG_1(swigCPtr, getCPtr(v1), getCPtr(v2));
		}

		public static bool Equals(GfVec3d lhs, GfVec3d rhs)
		{
			bool result = GfPINVOKE.GfVec3d_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfVec3d lhs, GfVec3d rhs)
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

		public static bool operator !=(GfVec3d lhs, GfVec3d rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfVec3d);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfVec3d_GetHashCode(swigCPtr);
		}

		protected double GetValue(int index)
		{
			return GfPINVOKE.GfVec3d_GetValue(swigCPtr, index);
		}

		protected void SetValue(int index, double value)
		{
			GfPINVOKE.GfVec3d_SetValue(swigCPtr, index, value);
		}
	}
}
