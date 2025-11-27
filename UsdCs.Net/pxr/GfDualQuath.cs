using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfDualQuath : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public GfDualQuath(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfDualQuath obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfDualQuath obj)
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

		~GfDualQuath()
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
						GfPINVOKE.delete_GfDualQuath(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfDualQuath()
			: this(GfPINVOKE.new_GfDualQuath__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfDualQuath(GfHalf realVal)
			: this(GfPINVOKE.new_GfDualQuath__SWIG_1(GfHalf.getCPtr(realVal)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfDualQuath(GfQuath real)
			: this(GfPINVOKE.new_GfDualQuath__SWIG_2(GfQuath.getCPtr(real)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfDualQuath(GfQuath real, GfQuath dual)
			: this(GfPINVOKE.new_GfDualQuath__SWIG_3(GfQuath.getCPtr(real), GfQuath.getCPtr(dual)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfDualQuath(GfQuath rotation, GfVec3h translation)
			: this(GfPINVOKE.new_GfDualQuath__SWIG_4(GfQuath.getCPtr(rotation), GfVec3h.getCPtr(translation)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfDualQuath(GfDualQuatd other)
			: this(GfPINVOKE.new_GfDualQuath__SWIG_5(GfDualQuatd.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfDualQuath(GfDualQuatf other)
			: this(GfPINVOKE.new_GfDualQuath__SWIG_6(GfDualQuatf.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetReal(GfQuath real)
		{
			GfPINVOKE.GfDualQuath_SetReal(swigCPtr, GfQuath.getCPtr(real));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetDual(GfQuath dual)
		{
			GfPINVOKE.GfDualQuath_SetDual(swigCPtr, GfQuath.getCPtr(dual));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfQuath GetReal()
		{
			return new GfQuath(GfPINVOKE.GfDualQuath_GetReal(swigCPtr), cMemoryOwn: false);
		}

		public GfQuath GetDual()
		{
			return new GfQuath(GfPINVOKE.GfDualQuath_GetDual(swigCPtr), cMemoryOwn: false);
		}

		public static GfDualQuath GetZero()
		{
			return new GfDualQuath(GfPINVOKE.GfDualQuath_GetZero(), cMemoryOwn: true);
		}

		public static GfDualQuath GetIdentity()
		{
			return new GfDualQuath(GfPINVOKE.GfDualQuath_GetIdentity(), cMemoryOwn: true);
		}

		public SWIGTYPE_p_std__pairT_GfHalf_GfHalf_t GetLength()
		{
			return new SWIGTYPE_p_std__pairT_GfHalf_GfHalf_t(GfPINVOKE.GfDualQuath_GetLength(swigCPtr), futureUse: true);
		}

		public GfDualQuath GetNormalized(GfHalf eps)
		{
			GfDualQuath result = new GfDualQuath(GfPINVOKE.GfDualQuath_GetNormalized__SWIG_0(swigCPtr, GfHalf.getCPtr(eps)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfDualQuath GetNormalized()
		{
			return new GfDualQuath(GfPINVOKE.GfDualQuath_GetNormalized__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public SWIGTYPE_p_std__pairT_GfHalf_GfHalf_t Normalize(GfHalf eps)
		{
			SWIGTYPE_p_std__pairT_GfHalf_GfHalf_t result = new SWIGTYPE_p_std__pairT_GfHalf_GfHalf_t(GfPINVOKE.GfDualQuath_Normalize__SWIG_0(swigCPtr, GfHalf.getCPtr(eps)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_std__pairT_GfHalf_GfHalf_t Normalize()
		{
			return new SWIGTYPE_p_std__pairT_GfHalf_GfHalf_t(GfPINVOKE.GfDualQuath_Normalize__SWIG_1(swigCPtr), futureUse: true);
		}

		public GfDualQuath GetConjugate()
		{
			return new GfDualQuath(GfPINVOKE.GfDualQuath_GetConjugate(swigCPtr), cMemoryOwn: true);
		}

		public GfDualQuath GetInverse()
		{
			return new GfDualQuath(GfPINVOKE.GfDualQuath_GetInverse(swigCPtr), cMemoryOwn: true);
		}

		public void SetTranslation(GfVec3h translation)
		{
			GfPINVOKE.GfDualQuath_SetTranslation(swigCPtr, GfVec3h.getCPtr(translation));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec3h GetTranslation()
		{
			return new GfVec3h(GfPINVOKE.GfDualQuath_GetTranslation(swigCPtr), cMemoryOwn: true);
		}

		public GfVec3h Transform(GfVec3h vec)
		{
			GfVec3h result = new GfVec3h(GfPINVOKE.GfDualQuath_Transform(swigCPtr, GfVec3h.getCPtr(vec)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool Equals(GfDualQuath lhs, GfDualQuath rhs)
		{
			bool result = GfPINVOKE.GfDualQuath_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfDualQuath lhs, GfDualQuath rhs)
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

		public static bool operator !=(GfDualQuath lhs, GfDualQuath rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfDualQuath);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfDualQuath_GetHashCode(swigCPtr);
		}
	}
}
