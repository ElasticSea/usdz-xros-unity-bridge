using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfVec2f : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public const uint dimension = 2u;

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

		public GfVec2f(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfVec2f obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfVec2f obj)
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

		~GfVec2f()
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
						GfPINVOKE.delete_GfVec2f(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfVec2f()
			: this(GfPINVOKE.new_GfVec2f__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfVec2f(float value)
			: this(GfPINVOKE.new_GfVec2f__SWIG_1(value), cMemoryOwn: true)
		{
		}

		public GfVec2f(float s0, float s1)
			: this(GfPINVOKE.new_GfVec2f__SWIG_2(s0, s1), cMemoryOwn: true)
		{
		}

		public GfVec2f(GfVec2d other)
			: this(GfPINVOKE.new_GfVec2f__SWIG_4(GfVec2d.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec2f(GfVec2h other)
			: this(GfPINVOKE.new_GfVec2f__SWIG_5(GfVec2h.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec2f(GfVec2i other)
			: this(GfPINVOKE.new_GfVec2f__SWIG_6(GfVec2i.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static GfVec2f XAxis()
		{
			return new GfVec2f(GfPINVOKE.GfVec2f_XAxis(), cMemoryOwn: true);
		}

		public static GfVec2f YAxis()
		{
			return new GfVec2f(GfPINVOKE.GfVec2f_YAxis(), cMemoryOwn: true);
		}

		public static GfVec2f Axis(uint i)
		{
			return new GfVec2f(GfPINVOKE.GfVec2f_Axis(i), cMemoryOwn: true);
		}

		public GfVec2f Set(float s0, float s1)
		{
			return new GfVec2f(GfPINVOKE.GfVec2f_Set(swigCPtr, s0, s1), cMemoryOwn: false);
		}

		public GfVec2f GetProjection(GfVec2f v)
		{
			GfVec2f result = new GfVec2f(GfPINVOKE.GfVec2f_GetProjection(swigCPtr, getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec2f GetComplement(GfVec2f b)
		{
			GfVec2f result = new GfVec2f(GfPINVOKE.GfVec2f_GetComplement(swigCPtr, getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public float GetLengthSq()
		{
			return GfPINVOKE.GfVec2f_GetLengthSq(swigCPtr);
		}

		public float GetLength()
		{
			return GfPINVOKE.GfVec2f_GetLength(swigCPtr);
		}

		public float Normalize(float eps)
		{
			return GfPINVOKE.GfVec2f_Normalize__SWIG_0(swigCPtr, eps);
		}

		public float Normalize()
		{
			return GfPINVOKE.GfVec2f_Normalize__SWIG_1(swigCPtr);
		}

		public GfVec2f GetNormalized(float eps)
		{
			return new GfVec2f(GfPINVOKE.GfVec2f_GetNormalized__SWIG_0(swigCPtr, eps), cMemoryOwn: true);
		}

		public GfVec2f GetNormalized()
		{
			return new GfVec2f(GfPINVOKE.GfVec2f_GetNormalized__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public static bool Equals(GfVec2f lhs, GfVec2f rhs)
		{
			bool result = GfPINVOKE.GfVec2f_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfVec2f lhs, GfVec2f rhs)
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

		public static bool operator !=(GfVec2f lhs, GfVec2f rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfVec2f);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfVec2f_GetHashCode(swigCPtr);
		}

		protected float GetValue(int index)
		{
			return GfPINVOKE.GfVec2f_GetValue(swigCPtr, index);
		}

		protected void SetValue(int index, float value)
		{
			GfPINVOKE.GfVec2f_SetValue(swigCPtr, index, value);
		}
	}
}
