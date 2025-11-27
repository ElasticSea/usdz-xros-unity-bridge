using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfMatrix2f : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public const uint numRows = 2u;

		public const uint numColumns = 2u;

		public GfMatrix2f(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfMatrix2f obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfMatrix2f obj)
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

		~GfMatrix2f()
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
						GfPINVOKE.delete_GfMatrix2f(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfMatrix2f()
			: this(GfPINVOKE.new_GfMatrix2f__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfMatrix2f(float m00, float m01, float m10, float m11)
			: this(GfPINVOKE.new_GfMatrix2f__SWIG_1(m00, m01, m10, m11), cMemoryOwn: true)
		{
		}

		public GfMatrix2f(float s)
			: this(GfPINVOKE.new_GfMatrix2f__SWIG_2(s), cMemoryOwn: true)
		{
		}

		public GfMatrix2f(int s)
			: this(GfPINVOKE.new_GfMatrix2f__SWIG_3(s), cMemoryOwn: true)
		{
		}

		public GfMatrix2f(GfVec2f v)
			: this(GfPINVOKE.new_GfMatrix2f__SWIG_4(GfVec2f.getCPtr(v)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix2f(StdDoubleVectorVector v)
			: this(GfPINVOKE.new_GfMatrix2f__SWIG_5(StdDoubleVectorVector.getCPtr(v)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix2f(StdFloatVectorVector v)
			: this(GfPINVOKE.new_GfMatrix2f__SWIG_6(StdFloatVectorVector.getCPtr(v)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfMatrix2f(GfMatrix2d m)
			: this(GfPINVOKE.new_GfMatrix2f__SWIG_7(GfMatrix2d.getCPtr(m)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRow(int i, GfVec2f v)
		{
			GfPINVOKE.GfMatrix2f_SetRow(swigCPtr, i, GfVec2f.getCPtr(v));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetColumn(int i, GfVec2f v)
		{
			GfPINVOKE.GfMatrix2f_SetColumn(swigCPtr, i, GfVec2f.getCPtr(v));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec2f GetRow(int i)
		{
			return new GfVec2f(GfPINVOKE.GfMatrix2f_GetRow(swigCPtr, i), cMemoryOwn: true);
		}

		public GfVec2f GetColumn(int i)
		{
			return new GfVec2f(GfPINVOKE.GfMatrix2f_GetColumn(swigCPtr, i), cMemoryOwn: true);
		}

		public GfMatrix2f Set(float m00, float m01, float m10, float m11)
		{
			return new GfMatrix2f(GfPINVOKE.GfMatrix2f_Set(swigCPtr, m00, m01, m10, m11), cMemoryOwn: false);
		}

		public GfMatrix2f SetIdentity()
		{
			return new GfMatrix2f(GfPINVOKE.GfMatrix2f_SetIdentity(swigCPtr), cMemoryOwn: false);
		}

		public GfMatrix2f SetZero()
		{
			return new GfMatrix2f(GfPINVOKE.GfMatrix2f_SetZero(swigCPtr), cMemoryOwn: false);
		}

		public GfMatrix2f SetDiagonal(float s)
		{
			return new GfMatrix2f(GfPINVOKE.GfMatrix2f_SetDiagonal__SWIG_0(swigCPtr, s), cMemoryOwn: false);
		}

		public GfMatrix2f SetDiagonal(GfVec2f arg0)
		{
			GfMatrix2f result = new GfMatrix2f(GfPINVOKE.GfMatrix2f_SetDiagonal__SWIG_1(swigCPtr, GfVec2f.getCPtr(arg0)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfMatrix2f GetTranspose()
		{
			return new GfMatrix2f(GfPINVOKE.GfMatrix2f_GetTranspose(swigCPtr), cMemoryOwn: true);
		}

		public GfMatrix2f GetInverse(out double det, double eps)
		{
			return new GfMatrix2f(GfPINVOKE.GfMatrix2f_GetInverse__SWIG_0(swigCPtr, out det, eps), cMemoryOwn: true);
		}

		public GfMatrix2f GetInverse(out double det)
		{
			return new GfMatrix2f(GfPINVOKE.GfMatrix2f_GetInverse__SWIG_1(swigCPtr, out det), cMemoryOwn: true);
		}

		public GfMatrix2f GetInverse()
		{
			return new GfMatrix2f(GfPINVOKE.GfMatrix2f_GetInverse__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public double GetDeterminant()
		{
			return GfPINVOKE.GfMatrix2f_GetDeterminant(swigCPtr);
		}

		public static bool Equals(GfMatrix2f lhs, GfMatrix2f rhs)
		{
			bool result = GfPINVOKE.GfMatrix2f_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfMatrix2f lhs, GfMatrix2f rhs)
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

		public static bool operator !=(GfMatrix2f lhs, GfMatrix2f rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfMatrix2f);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfMatrix2f_GetHashCode(swigCPtr);
		}

		public override string ToString()
		{
			return GfPINVOKE.GfMatrix2f_ToString(swigCPtr);
		}

		public void CopyToArray(float[] dest)
		{
			GfPINVOKE.GfMatrix2f_CopyToArray(swigCPtr, dest);
		}

		public void CopyFromArray(float[] src)
		{
			GfPINVOKE.GfMatrix2f_CopyFromArray(swigCPtr, src);
		}
	}
}
