using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfQuath : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public GfQuath(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfQuath obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfQuath obj)
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

		~GfQuath()
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
						GfPINVOKE.delete_GfQuath(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfQuath()
			: this(GfPINVOKE.new_GfQuath__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfQuath(GfHalf realVal)
			: this(GfPINVOKE.new_GfQuath__SWIG_1(GfHalf.getCPtr(realVal)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfQuath(GfHalf real, GfHalf i, GfHalf j, GfHalf k)
			: this(GfPINVOKE.new_GfQuath__SWIG_2(GfHalf.getCPtr(real), GfHalf.getCPtr(i), GfHalf.getCPtr(j), GfHalf.getCPtr(k)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfQuath(GfHalf real, GfVec3h imaginary)
			: this(GfPINVOKE.new_GfQuath__SWIG_3(GfHalf.getCPtr(real), GfVec3h.getCPtr(imaginary)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfQuath(GfQuatd other)
			: this(GfPINVOKE.new_GfQuath__SWIG_4(GfQuatd.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfQuath(GfQuatf other)
			: this(GfPINVOKE.new_GfQuath__SWIG_5(GfQuatf.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static GfQuath GetZero()
		{
			return new GfQuath(GfPINVOKE.GfQuath_GetZero(), cMemoryOwn: true);
		}

		public static GfQuath GetIdentity()
		{
			return new GfQuath(GfPINVOKE.GfQuath_GetIdentity(), cMemoryOwn: true);
		}

		public GfHalf GetReal()
		{
			return new GfHalf(GfPINVOKE.GfQuath_GetReal(swigCPtr), cMemoryOwn: true);
		}

		public void SetReal(GfHalf real)
		{
			GfPINVOKE.GfQuath_SetReal(swigCPtr, GfHalf.getCPtr(real));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec3h GetImaginary()
		{
			return new GfVec3h(GfPINVOKE.GfQuath_GetImaginary(swigCPtr), cMemoryOwn: false);
		}

		public void SetImaginary(GfVec3h imaginary)
		{
			GfPINVOKE.GfQuath_SetImaginary__SWIG_0(swigCPtr, GfVec3h.getCPtr(imaginary));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetImaginary(GfHalf i, GfHalf j, GfHalf k)
		{
			GfPINVOKE.GfQuath_SetImaginary__SWIG_1(swigCPtr, GfHalf.getCPtr(i), GfHalf.getCPtr(j), GfHalf.getCPtr(k));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfHalf GetLength()
		{
			return new GfHalf(GfPINVOKE.GfQuath_GetLength(swigCPtr), cMemoryOwn: true);
		}

		public GfQuath GetNormalized(GfHalf eps)
		{
			GfQuath result = new GfQuath(GfPINVOKE.GfQuath_GetNormalized__SWIG_0(swigCPtr, GfHalf.getCPtr(eps)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfQuath GetNormalized()
		{
			return new GfQuath(GfPINVOKE.GfQuath_GetNormalized__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public GfHalf Normalize(GfHalf eps)
		{
			GfHalf result = new GfHalf(GfPINVOKE.GfQuath_Normalize__SWIG_0(swigCPtr, GfHalf.getCPtr(eps)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfHalf Normalize()
		{
			return new GfHalf(GfPINVOKE.GfQuath_Normalize__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public GfQuath GetConjugate()
		{
			return new GfQuath(GfPINVOKE.GfQuath_GetConjugate(swigCPtr), cMemoryOwn: true);
		}

		public GfQuath GetInverse()
		{
			return new GfQuath(GfPINVOKE.GfQuath_GetInverse(swigCPtr), cMemoryOwn: true);
		}

		public GfVec3h Transform(GfVec3h point)
		{
			GfVec3h result = new GfVec3h(GfPINVOKE.GfQuath_Transform(swigCPtr, GfVec3h.getCPtr(point)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool Equals(GfQuath lhs, GfQuath rhs)
		{
			bool result = GfPINVOKE.GfQuath_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfQuath lhs, GfQuath rhs)
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

		public static bool operator !=(GfQuath lhs, GfQuath rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfQuath);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfQuath_GetHashCode(swigCPtr);
		}
	}
}
