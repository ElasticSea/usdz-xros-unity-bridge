using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfMatrix2d : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public const uint numRows = 2u;

		public const uint numColumns = 2u;

		public GfMatrix2d(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfMatrix2d obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfMatrix2d obj)
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

		~GfMatrix2d()
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
						GfPINVOKE.delete_GfMatrix2d(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfMatrix2d()
			: this(GfPINVOKE.new_GfMatrix2d__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfMatrix2d(double m00, double m01, double m10, double m11)
			: this(GfPINVOKE.new_GfMatrix2d__SWIG_1(m00, m01, m10, m11), cMemoryOwn: true)
		{
		}

		public GfMatrix2d(double s)
			: this(GfPINVOKE.new_GfMatrix2d__SWIG_2(s), cMemoryOwn: true)
		{
		}

		public GfMatrix2d(int s)
			: this(GfPINVOKE.new_GfMatrix2d__SWIG_3(s), cMemoryOwn: true)
		{
		}

		public GfMatrix2d(GfVec2d v)
			: this(GfPINVOKE.new_GfMatrix2d__SWIG_4(GfVec2d.getCPtr(v)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix2d(StdDoubleVectorVector v)
			: this(GfPINVOKE.new_GfMatrix2d__SWIG_5(StdDoubleVectorVector.getCPtr(v)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix2d(StdFloatVectorVector v)
			: this(GfPINVOKE.new_GfMatrix2d__SWIG_6(StdFloatVectorVector.getCPtr(v)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix2d(GfMatrix2f m)
			: this(GfPINVOKE.new_GfMatrix2d__SWIG_7(GfMatrix2f.getCPtr(m)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRow(int i, GfVec2d v)
		{
			GfPINVOKE.GfMatrix2d_SetRow(swigCPtr, i, GfVec2d.getCPtr(v));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetColumn(int i, GfVec2d v)
		{
			GfPINVOKE.GfMatrix2d_SetColumn(swigCPtr, i, GfVec2d.getCPtr(v));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec2d GetRow(int i)
		{
			return new GfVec2d(GfPINVOKE.GfMatrix2d_GetRow(swigCPtr, i), cMemoryOwn: true);
		}

		public GfVec2d GetColumn(int i)
		{
			return new GfVec2d(GfPINVOKE.GfMatrix2d_GetColumn(swigCPtr, i), cMemoryOwn: true);
		}

		public GfMatrix2d Set(double m00, double m01, double m10, double m11)
		{
			return new GfMatrix2d(GfPINVOKE.GfMatrix2d_Set(swigCPtr, m00, m01, m10, m11), cMemoryOwn: false);
		}

		public GfMatrix2d SetIdentity()
		{
			return new GfMatrix2d(GfPINVOKE.GfMatrix2d_SetIdentity(swigCPtr), cMemoryOwn: false);
		}

		public GfMatrix2d SetZero()
		{
			return new GfMatrix2d(GfPINVOKE.GfMatrix2d_SetZero(swigCPtr), cMemoryOwn: false);
		}

		public GfMatrix2d SetDiagonal(double s)
		{
			return new GfMatrix2d(GfPINVOKE.GfMatrix2d_SetDiagonal__SWIG_0(swigCPtr, s), cMemoryOwn: false);
		}

		public GfMatrix2d SetDiagonal(GfVec2d arg0)
		{
			GfMatrix2d result = new GfMatrix2d(GfPINVOKE.GfMatrix2d_SetDiagonal__SWIG_1(swigCPtr, GfVec2d.getCPtr(arg0)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix2d GetTranspose()
		{
			return new GfMatrix2d(GfPINVOKE.GfMatrix2d_GetTranspose(swigCPtr), cMemoryOwn: true);
		}

		public GfMatrix2d GetInverse(out double det, double eps)
		{
			return new GfMatrix2d(GfPINVOKE.GfMatrix2d_GetInverse__SWIG_0(swigCPtr, out det, eps), cMemoryOwn: true);
		}

		public GfMatrix2d GetInverse(out double det)
		{
			return new GfMatrix2d(GfPINVOKE.GfMatrix2d_GetInverse__SWIG_1(swigCPtr, out det), cMemoryOwn: true);
		}

		public GfMatrix2d GetInverse()
		{
			return new GfMatrix2d(GfPINVOKE.GfMatrix2d_GetInverse__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public double GetDeterminant()
		{
			return GfPINVOKE.GfMatrix2d_GetDeterminant(swigCPtr);
		}

		public static bool Equals(GfMatrix2d lhs, GfMatrix2d rhs)
		{
			bool result = GfPINVOKE.GfMatrix2d_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfMatrix2d lhs, GfMatrix2d rhs)
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

		public static bool operator !=(GfMatrix2d lhs, GfMatrix2d rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfMatrix2d);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfMatrix2d_GetHashCode(swigCPtr);
		}

		public override string ToString()
		{
			return GfPINVOKE.GfMatrix2d_ToString(swigCPtr);
		}

		public void CopyToArray(double[] dest)
		{
			GfPINVOKE.GfMatrix2d_CopyToArray(swigCPtr, dest);
		}

		public void CopyFromArray(double[] src)
		{
			GfPINVOKE.GfMatrix2d_CopyFromArray(swigCPtr, src);
		}
	}
}
