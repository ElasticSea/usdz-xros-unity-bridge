using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfQuaternion : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public GfQuaternion(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfQuaternion obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfQuaternion obj)
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

		~GfQuaternion()
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
						GfPINVOKE.delete_GfQuaternion(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfQuaternion()
			: this(GfPINVOKE.new_GfQuaternion__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfQuaternion(int realVal)
			: this(GfPINVOKE.new_GfQuaternion__SWIG_1(realVal), cMemoryOwn: true)
		{
		}

		public GfQuaternion(double real, GfVec3d imaginary)
			: this(GfPINVOKE.new_GfQuaternion__SWIG_2(real, GfVec3d.getCPtr(imaginary)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetReal(double real)
		{
			GfPINVOKE.GfQuaternion_SetReal(swigCPtr, real);
		}

		public void SetImaginary(GfVec3d imaginary)
		{
			GfPINVOKE.GfQuaternion_SetImaginary(swigCPtr, GfVec3d.getCPtr(imaginary));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public double GetReal()
		{
			return GfPINVOKE.GfQuaternion_GetReal(swigCPtr);
		}

		public GfVec3d GetImaginary()
		{
			return new GfVec3d(GfPINVOKE.GfQuaternion_GetImaginary(swigCPtr), cMemoryOwn: false);
		}

		public static GfQuaternion GetZero()
		{
			return new GfQuaternion(GfPINVOKE.GfQuaternion_GetZero(), cMemoryOwn: true);
		}

		public static GfQuaternion GetIdentity()
		{
			return new GfQuaternion(GfPINVOKE.GfQuaternion_GetIdentity(), cMemoryOwn: true);
		}

		public double GetLength()
		{
			return GfPINVOKE.GfQuaternion_GetLength(swigCPtr);
		}

		public GfQuaternion GetNormalized(double eps)
		{
			return new GfQuaternion(GfPINVOKE.GfQuaternion_GetNormalized__SWIG_0(swigCPtr, eps), cMemoryOwn: true);
		}

		public GfQuaternion GetNormalized()
		{
			return new GfQuaternion(GfPINVOKE.GfQuaternion_GetNormalized__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public double Normalize(double eps)
		{
			return GfPINVOKE.GfQuaternion_Normalize__SWIG_0(swigCPtr, eps);
		}

		public double Normalize()
		{
			return GfPINVOKE.GfQuaternion_Normalize__SWIG_1(swigCPtr);
		}

		public GfQuaternion GetInverse()
		{
			return new GfQuaternion(GfPINVOKE.GfQuaternion_GetInverse(swigCPtr), cMemoryOwn: true);
		}

		public static bool Equals(GfQuaternion lhs, GfQuaternion rhs)
		{
			bool result = GfPINVOKE.GfQuaternion_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfQuaternion lhs, GfQuaternion rhs)
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

		public static bool operator !=(GfQuaternion lhs, GfQuaternion rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfQuaternion);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfQuaternion_GetHashCode(swigCPtr);
		}
	}
}
