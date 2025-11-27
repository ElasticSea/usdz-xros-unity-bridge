using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfQuatf : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public GfQuatf(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfQuatf obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfQuatf obj)
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

		~GfQuatf()
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
						GfPINVOKE.delete_GfQuatf(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfQuatf()
			: this(GfPINVOKE.new_GfQuatf__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfQuatf(float realVal)
			: this(GfPINVOKE.new_GfQuatf__SWIG_1(realVal), cMemoryOwn: true)
		{
		}

		public GfQuatf(float real, float i, float j, float k)
			: this(GfPINVOKE.new_GfQuatf__SWIG_2(real, i, j, k), cMemoryOwn: true)
		{
		}

		public GfQuatf(float real, GfVec3f imaginary)
			: this(GfPINVOKE.new_GfQuatf__SWIG_3(real, GfVec3f.getCPtr(imaginary)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfQuatf(GfQuatd other)
			: this(GfPINVOKE.new_GfQuatf__SWIG_4(GfQuatd.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfQuatf(GfQuath other)
			: this(GfPINVOKE.new_GfQuatf__SWIG_5(GfQuath.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static GfQuatf GetZero()
		{
			return new GfQuatf(GfPINVOKE.GfQuatf_GetZero(), cMemoryOwn: true);
		}

		public static GfQuatf GetIdentity()
		{
			return new GfQuatf(GfPINVOKE.GfQuatf_GetIdentity(), cMemoryOwn: true);
		}

		public float GetReal()
		{
			return GfPINVOKE.GfQuatf_GetReal(swigCPtr);
		}

		public void SetReal(float real)
		{
			GfPINVOKE.GfQuatf_SetReal(swigCPtr, real);
		}

		public GfVec3f GetImaginary()
		{
			return new GfVec3f(GfPINVOKE.GfQuatf_GetImaginary(swigCPtr), cMemoryOwn: false);
		}

		public void SetImaginary(GfVec3f imaginary)
		{
			GfPINVOKE.GfQuatf_SetImaginary__SWIG_0(swigCPtr, GfVec3f.getCPtr(imaginary));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetImaginary(float i, float j, float k)
		{
			GfPINVOKE.GfQuatf_SetImaginary__SWIG_1(swigCPtr, i, j, k);
		}

		public float GetLength()
		{
			return GfPINVOKE.GfQuatf_GetLength(swigCPtr);
		}

		public GfQuatf GetNormalized(float eps)
		{
			return new GfQuatf(GfPINVOKE.GfQuatf_GetNormalized__SWIG_0(swigCPtr, eps), cMemoryOwn: true);
		}

		public GfQuatf GetNormalized()
		{
			return new GfQuatf(GfPINVOKE.GfQuatf_GetNormalized__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public float Normalize(float eps)
		{
			return GfPINVOKE.GfQuatf_Normalize__SWIG_0(swigCPtr, eps);
		}

		public float Normalize()
		{
			return GfPINVOKE.GfQuatf_Normalize__SWIG_1(swigCPtr);
		}

		public GfQuatf GetConjugate()
		{
			return new GfQuatf(GfPINVOKE.GfQuatf_GetConjugate(swigCPtr), cMemoryOwn: true);
		}

		public GfQuatf GetInverse()
		{
			return new GfQuatf(GfPINVOKE.GfQuatf_GetInverse(swigCPtr), cMemoryOwn: true);
		}

		public GfVec3f Transform(GfVec3f point)
		{
			GfVec3f result = new GfVec3f(GfPINVOKE.GfQuatf_Transform(swigCPtr, GfVec3f.getCPtr(point)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool Equals(GfQuatf lhs, GfQuatf rhs)
		{
			bool result = GfPINVOKE.GfQuatf_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfQuatf lhs, GfQuatf rhs)
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

		public static bool operator !=(GfQuatf lhs, GfQuatf rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfQuatf);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfQuatf_GetHashCode(swigCPtr);
		}
	}
}
