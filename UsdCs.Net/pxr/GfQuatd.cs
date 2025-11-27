using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfQuatd : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public GfQuatd(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfQuatd obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfQuatd obj)
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

		~GfQuatd()
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
						GfPINVOKE.delete_GfQuatd(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfQuatd()
			: this(GfPINVOKE.new_GfQuatd__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfQuatd(double realVal)
			: this(GfPINVOKE.new_GfQuatd__SWIG_1(realVal), cMemoryOwn: true)
		{
		}

		public GfQuatd(double real, double i, double j, double k)
			: this(GfPINVOKE.new_GfQuatd__SWIG_2(real, i, j, k), cMemoryOwn: true)
		{
		}

		public GfQuatd(double real, GfVec3d imaginary)
			: this(GfPINVOKE.new_GfQuatd__SWIG_3(real, GfVec3d.getCPtr(imaginary)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfQuatd(GfQuatf other)
			: this(GfPINVOKE.new_GfQuatd__SWIG_4(GfQuatf.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfQuatd(GfQuath other)
			: this(GfPINVOKE.new_GfQuatd__SWIG_5(GfQuath.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static GfQuatd GetZero()
		{
			return new GfQuatd(GfPINVOKE.GfQuatd_GetZero(), cMemoryOwn: true);
		}

		public static GfQuatd GetIdentity()
		{
			return new GfQuatd(GfPINVOKE.GfQuatd_GetIdentity(), cMemoryOwn: true);
		}

		public double GetReal()
		{
			return GfPINVOKE.GfQuatd_GetReal(swigCPtr);
		}

		public void SetReal(double real)
		{
			GfPINVOKE.GfQuatd_SetReal(swigCPtr, real);
		}

		public GfVec3d GetImaginary()
		{
			return new GfVec3d(GfPINVOKE.GfQuatd_GetImaginary(swigCPtr), cMemoryOwn: false);
		}

		public void SetImaginary(GfVec3d imaginary)
		{
			GfPINVOKE.GfQuatd_SetImaginary__SWIG_0(swigCPtr, GfVec3d.getCPtr(imaginary));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetImaginary(double i, double j, double k)
		{
			GfPINVOKE.GfQuatd_SetImaginary__SWIG_1(swigCPtr, i, j, k);
		}

		public double GetLength()
		{
			return GfPINVOKE.GfQuatd_GetLength(swigCPtr);
		}

		public GfQuatd GetNormalized(double eps)
		{
			return new GfQuatd(GfPINVOKE.GfQuatd_GetNormalized__SWIG_0(swigCPtr, eps), cMemoryOwn: true);
		}

		public GfQuatd GetNormalized()
		{
			return new GfQuatd(GfPINVOKE.GfQuatd_GetNormalized__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public double Normalize(double eps)
		{
			return GfPINVOKE.GfQuatd_Normalize__SWIG_0(swigCPtr, eps);
		}

		public double Normalize()
		{
			return GfPINVOKE.GfQuatd_Normalize__SWIG_1(swigCPtr);
		}

		public GfQuatd GetConjugate()
		{
			return new GfQuatd(GfPINVOKE.GfQuatd_GetConjugate(swigCPtr), cMemoryOwn: true);
		}

		public GfQuatd GetInverse()
		{
			return new GfQuatd(GfPINVOKE.GfQuatd_GetInverse(swigCPtr), cMemoryOwn: true);
		}

		public GfVec3d Transform(GfVec3d point)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfQuatd_Transform(swigCPtr, GfVec3d.getCPtr(point)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool Equals(GfQuatd lhs, GfQuatd rhs)
		{
			bool result = GfPINVOKE.GfQuatd_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfQuatd lhs, GfQuatd rhs)
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

		public static bool operator !=(GfQuatd lhs, GfQuatd rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfQuatd);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfQuatd_GetHashCode(swigCPtr);
		}
	}
}
