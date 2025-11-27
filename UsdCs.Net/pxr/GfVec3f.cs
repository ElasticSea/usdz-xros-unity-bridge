using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfVec3f : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public const uint dimension = 3u;

		public float this[int index]
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

		public GfVec3f(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfVec3f obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfVec3f obj)
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

		~GfVec3f()
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
						GfPINVOKE.delete_GfVec3f(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfVec3f()
			: this(GfPINVOKE.new_GfVec3f__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfVec3f(float value)
			: this(GfPINVOKE.new_GfVec3f__SWIG_1(value), cMemoryOwn: true)
		{
		}

		public GfVec3f(float s0, float s1, float s2)
			: this(GfPINVOKE.new_GfVec3f__SWIG_2(s0, s1, s2), cMemoryOwn: true)
		{
		}

		public GfVec3f(GfVec3d other)
			: this(GfPINVOKE.new_GfVec3f__SWIG_4(GfVec3d.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec3f(GfVec3h other)
			: this(GfPINVOKE.new_GfVec3f__SWIG_5(GfVec3h.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec3f(GfVec3i other)
			: this(GfPINVOKE.new_GfVec3f__SWIG_6(GfVec3i.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static GfVec3f XAxis()
		{
			return new GfVec3f(GfPINVOKE.GfVec3f_XAxis(), cMemoryOwn: true);
		}

		public static GfVec3f YAxis()
		{
			return new GfVec3f(GfPINVOKE.GfVec3f_YAxis(), cMemoryOwn: true);
		}

		public static GfVec3f ZAxis()
		{
			return new GfVec3f(GfPINVOKE.GfVec3f_ZAxis(), cMemoryOwn: true);
		}

		public static GfVec3f Axis(uint i)
		{
			return new GfVec3f(GfPINVOKE.GfVec3f_Axis(i), cMemoryOwn: true);
		}

		public GfVec3f Set(float s0, float s1, float s2)
		{
			return new GfVec3f(GfPINVOKE.GfVec3f_Set(swigCPtr, s0, s1, s2), cMemoryOwn: false);
		}

		public GfVec3f GetProjection(GfVec3f v)
		{
			GfVec3f result = new GfVec3f(GfPINVOKE.GfVec3f_GetProjection(swigCPtr, getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec3f GetComplement(GfVec3f b)
		{
			GfVec3f result = new GfVec3f(GfPINVOKE.GfVec3f_GetComplement(swigCPtr, getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public float GetLengthSq()
		{
			return GfPINVOKE.GfVec3f_GetLengthSq(swigCPtr);
		}

		public float GetLength()
		{
			return GfPINVOKE.GfVec3f_GetLength(swigCPtr);
		}

		public float Normalize(float eps)
		{
			return GfPINVOKE.GfVec3f_Normalize__SWIG_0(swigCPtr, eps);
		}

		public float Normalize()
		{
			return GfPINVOKE.GfVec3f_Normalize__SWIG_1(swigCPtr);
		}

		public GfVec3f GetNormalized(float eps)
		{
			return new GfVec3f(GfPINVOKE.GfVec3f_GetNormalized__SWIG_0(swigCPtr, eps), cMemoryOwn: true);
		}

		public GfVec3f GetNormalized()
		{
			return new GfVec3f(GfPINVOKE.GfVec3f_GetNormalized__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public static bool OrthogonalizeBasis(GfVec3f tx, GfVec3f ty, GfVec3f tz, bool normalize, double eps)
		{
			return GfPINVOKE.GfVec3f_OrthogonalizeBasis__SWIG_0(getCPtr(tx), getCPtr(ty), getCPtr(tz), normalize, eps);
		}

		public static bool OrthogonalizeBasis(GfVec3f tx, GfVec3f ty, GfVec3f tz, bool normalize)
		{
			return GfPINVOKE.GfVec3f_OrthogonalizeBasis__SWIG_1(getCPtr(tx), getCPtr(ty), getCPtr(tz), normalize);
		}

		public void BuildOrthonormalFrame(GfVec3f v1, GfVec3f v2, float eps)
		{
			GfPINVOKE.GfVec3f_BuildOrthonormalFrame__SWIG_0(swigCPtr, getCPtr(v1), getCPtr(v2), eps);
		}

		public void BuildOrthonormalFrame(GfVec3f v1, GfVec3f v2)
		{
			GfPINVOKE.GfVec3f_BuildOrthonormalFrame__SWIG_1(swigCPtr, getCPtr(v1), getCPtr(v2));
		}

		public static bool Equals(GfVec3f lhs, GfVec3f rhs)
		{
			bool result = GfPINVOKE.GfVec3f_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfVec3f lhs, GfVec3f rhs)
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

		public static bool operator !=(GfVec3f lhs, GfVec3f rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfVec3f);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfVec3f_GetHashCode(swigCPtr);
		}

		protected float GetValue(int index)
		{
			return GfPINVOKE.GfVec3f_GetValue(swigCPtr, index);
		}

		protected void SetValue(int index, float value)
		{
			GfPINVOKE.GfVec3f_SetValue(swigCPtr, index, value);
		}
	}
}
