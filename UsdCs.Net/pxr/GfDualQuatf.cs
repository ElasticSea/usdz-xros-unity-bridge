using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfDualQuatf : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public GfDualQuatf(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfDualQuatf obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfDualQuatf obj)
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

		~GfDualQuatf()
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
						GfPINVOKE.delete_GfDualQuatf(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfDualQuatf()
			: this(GfPINVOKE.new_GfDualQuatf__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfDualQuatf(float realVal)
			: this(GfPINVOKE.new_GfDualQuatf__SWIG_1(realVal), cMemoryOwn: true)
		{
		}

		public GfDualQuatf(GfQuatf real)
			: this(GfPINVOKE.new_GfDualQuatf__SWIG_2(GfQuatf.getCPtr(real)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfDualQuatf(GfQuatf real, GfQuatf dual)
			: this(GfPINVOKE.new_GfDualQuatf__SWIG_3(GfQuatf.getCPtr(real), GfQuatf.getCPtr(dual)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfDualQuatf(GfQuatf rotation, GfVec3f translation)
			: this(GfPINVOKE.new_GfDualQuatf__SWIG_4(GfQuatf.getCPtr(rotation), GfVec3f.getCPtr(translation)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfDualQuatf(GfDualQuatd other)
			: this(GfPINVOKE.new_GfDualQuatf__SWIG_5(GfDualQuatd.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfDualQuatf(GfDualQuath other)
			: this(GfPINVOKE.new_GfDualQuatf__SWIG_6(GfDualQuath.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetReal(GfQuatf real)
		{
			GfPINVOKE.GfDualQuatf_SetReal(swigCPtr, GfQuatf.getCPtr(real));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetDual(GfQuatf dual)
		{
			GfPINVOKE.GfDualQuatf_SetDual(swigCPtr, GfQuatf.getCPtr(dual));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfQuatf GetReal()
		{
			return new GfQuatf(GfPINVOKE.GfDualQuatf_GetReal(swigCPtr), cMemoryOwn: false);
		}

		public GfQuatf GetDual()
		{
			return new GfQuatf(GfPINVOKE.GfDualQuatf_GetDual(swigCPtr), cMemoryOwn: false);
		}

		public static GfDualQuatf GetZero()
		{
			return new GfDualQuatf(GfPINVOKE.GfDualQuatf_GetZero(), cMemoryOwn: true);
		}

		public static GfDualQuatf GetIdentity()
		{
			return new GfDualQuatf(GfPINVOKE.GfDualQuatf_GetIdentity(), cMemoryOwn: true);
		}

		public SWIGTYPE_p_std__pairT_float_float_t GetLength()
		{
			return new SWIGTYPE_p_std__pairT_float_float_t(GfPINVOKE.GfDualQuatf_GetLength(swigCPtr), futureUse: true);
		}

		public GfDualQuatf GetNormalized(float eps)
		{
			return new GfDualQuatf(GfPINVOKE.GfDualQuatf_GetNormalized__SWIG_0(swigCPtr, eps), cMemoryOwn: true);
		}

		public GfDualQuatf GetNormalized()
		{
			return new GfDualQuatf(GfPINVOKE.GfDualQuatf_GetNormalized__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public SWIGTYPE_p_std__pairT_float_float_t Normalize(float eps)
		{
			return new SWIGTYPE_p_std__pairT_float_float_t(GfPINVOKE.GfDualQuatf_Normalize__SWIG_0(swigCPtr, eps), futureUse: true);
		}

		public SWIGTYPE_p_std__pairT_float_float_t Normalize()
		{
			return new SWIGTYPE_p_std__pairT_float_float_t(GfPINVOKE.GfDualQuatf_Normalize__SWIG_1(swigCPtr), futureUse: true);
		}

		public GfDualQuatf GetConjugate()
		{
			return new GfDualQuatf(GfPINVOKE.GfDualQuatf_GetConjugate(swigCPtr), cMemoryOwn: true);
		}

		public GfDualQuatf GetInverse()
		{
			return new GfDualQuatf(GfPINVOKE.GfDualQuatf_GetInverse(swigCPtr), cMemoryOwn: true);
		}

		public void SetTranslation(GfVec3f translation)
		{
			GfPINVOKE.GfDualQuatf_SetTranslation(swigCPtr, GfVec3f.getCPtr(translation));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec3f GetTranslation()
		{
			return new GfVec3f(GfPINVOKE.GfDualQuatf_GetTranslation(swigCPtr), cMemoryOwn: true);
		}

		public GfVec3f Transform(GfVec3f vec)
		{
			GfVec3f result = new GfVec3f(GfPINVOKE.GfDualQuatf_Transform(swigCPtr, GfVec3f.getCPtr(vec)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool Equals(GfDualQuatf lhs, GfDualQuatf rhs)
		{
			bool result = GfPINVOKE.GfDualQuatf_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfDualQuatf lhs, GfDualQuatf rhs)
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

		public static bool operator !=(GfDualQuatf lhs, GfDualQuatf rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfDualQuatf);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfDualQuatf_GetHashCode(swigCPtr);
		}
	}
}
