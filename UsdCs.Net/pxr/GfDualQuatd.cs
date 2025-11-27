using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfDualQuatd : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public GfDualQuatd(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfDualQuatd obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfDualQuatd obj)
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

		~GfDualQuatd()
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
						GfPINVOKE.delete_GfDualQuatd(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfDualQuatd()
			: this(GfPINVOKE.new_GfDualQuatd__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfDualQuatd(double realVal)
			: this(GfPINVOKE.new_GfDualQuatd__SWIG_1(realVal), cMemoryOwn: true)
		{
		}

		public GfDualQuatd(GfQuatd real)
			: this(GfPINVOKE.new_GfDualQuatd__SWIG_2(GfQuatd.getCPtr(real)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfDualQuatd(GfQuatd real, GfQuatd dual)
			: this(GfPINVOKE.new_GfDualQuatd__SWIG_3(GfQuatd.getCPtr(real), GfQuatd.getCPtr(dual)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfDualQuatd(GfQuatd rotation, GfVec3d translation)
			: this(GfPINVOKE.new_GfDualQuatd__SWIG_4(GfQuatd.getCPtr(rotation), GfVec3d.getCPtr(translation)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfDualQuatd(GfDualQuatf other)
			: this(GfPINVOKE.new_GfDualQuatd__SWIG_5(GfDualQuatf.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfDualQuatd(GfDualQuath other)
			: this(GfPINVOKE.new_GfDualQuatd__SWIG_6(GfDualQuath.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetReal(GfQuatd real)
		{
			GfPINVOKE.GfDualQuatd_SetReal(swigCPtr, GfQuatd.getCPtr(real));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetDual(GfQuatd dual)
		{
			GfPINVOKE.GfDualQuatd_SetDual(swigCPtr, GfQuatd.getCPtr(dual));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfQuatd GetReal()
		{
			return new GfQuatd(GfPINVOKE.GfDualQuatd_GetReal(swigCPtr), cMemoryOwn: false);
		}

		public GfQuatd GetDual()
		{
			return new GfQuatd(GfPINVOKE.GfDualQuatd_GetDual(swigCPtr), cMemoryOwn: false);
		}

		public static GfDualQuatd GetZero()
		{
			return new GfDualQuatd(GfPINVOKE.GfDualQuatd_GetZero(), cMemoryOwn: true);
		}

		public static GfDualQuatd GetIdentity()
		{
			return new GfDualQuatd(GfPINVOKE.GfDualQuatd_GetIdentity(), cMemoryOwn: true);
		}

		public SWIGTYPE_p_std__pairT_double_double_t GetLength()
		{
			return new SWIGTYPE_p_std__pairT_double_double_t(GfPINVOKE.GfDualQuatd_GetLength(swigCPtr), futureUse: true);
		}

		public GfDualQuatd GetNormalized(double eps)
		{
			return new GfDualQuatd(GfPINVOKE.GfDualQuatd_GetNormalized__SWIG_0(swigCPtr, eps), cMemoryOwn: true);
		}

		public GfDualQuatd GetNormalized()
		{
			return new GfDualQuatd(GfPINVOKE.GfDualQuatd_GetNormalized__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public SWIGTYPE_p_std__pairT_double_double_t Normalize(double eps)
		{
			return new SWIGTYPE_p_std__pairT_double_double_t(GfPINVOKE.GfDualQuatd_Normalize__SWIG_0(swigCPtr, eps), futureUse: true);
		}

		public SWIGTYPE_p_std__pairT_double_double_t Normalize()
		{
			return new SWIGTYPE_p_std__pairT_double_double_t(GfPINVOKE.GfDualQuatd_Normalize__SWIG_1(swigCPtr), futureUse: true);
		}

		public GfDualQuatd GetConjugate()
		{
			return new GfDualQuatd(GfPINVOKE.GfDualQuatd_GetConjugate(swigCPtr), cMemoryOwn: true);
		}

		public GfDualQuatd GetInverse()
		{
			return new GfDualQuatd(GfPINVOKE.GfDualQuatd_GetInverse(swigCPtr), cMemoryOwn: true);
		}

		public void SetTranslation(GfVec3d translation)
		{
			GfPINVOKE.GfDualQuatd_SetTranslation(swigCPtr, GfVec3d.getCPtr(translation));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec3d GetTranslation()
		{
			return new GfVec3d(GfPINVOKE.GfDualQuatd_GetTranslation(swigCPtr), cMemoryOwn: true);
		}

		public GfVec3d Transform(GfVec3d vec)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfDualQuatd_Transform(swigCPtr, GfVec3d.getCPtr(vec)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool Equals(GfDualQuatd lhs, GfDualQuatd rhs)
		{
			bool result = GfPINVOKE.GfDualQuatd_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfDualQuatd lhs, GfDualQuatd rhs)
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

		public static bool operator !=(GfDualQuatd lhs, GfDualQuatd rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfDualQuatd);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfDualQuatd_GetHashCode(swigCPtr);
		}
	}
}
