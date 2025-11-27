using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfVec4f : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public const uint dimension = 4u;

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

		public GfVec4f(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfVec4f obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfVec4f obj)
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

		~GfVec4f()
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
						GfPINVOKE.delete_GfVec4f(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfVec4f()
			: this(GfPINVOKE.new_GfVec4f__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfVec4f(float value)
			: this(GfPINVOKE.new_GfVec4f__SWIG_1(value), cMemoryOwn: true)
		{
		}

		public GfVec4f(float s0, float s1, float s2, float s3)
			: this(GfPINVOKE.new_GfVec4f__SWIG_2(s0, s1, s2, s3), cMemoryOwn: true)
		{
		}

		public GfVec4f(GfVec4d other)
			: this(GfPINVOKE.new_GfVec4f__SWIG_4(GfVec4d.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec4f(GfVec4h other)
			: this(GfPINVOKE.new_GfVec4f__SWIG_5(GfVec4h.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec4f(GfVec4i other)
			: this(GfPINVOKE.new_GfVec4f__SWIG_6(GfVec4i.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static GfVec4f XAxis()
		{
			return new GfVec4f(GfPINVOKE.GfVec4f_XAxis(), cMemoryOwn: true);
		}

		public static GfVec4f YAxis()
		{
			return new GfVec4f(GfPINVOKE.GfVec4f_YAxis(), cMemoryOwn: true);
		}

		public static GfVec4f ZAxis()
		{
			return new GfVec4f(GfPINVOKE.GfVec4f_ZAxis(), cMemoryOwn: true);
		}

		public static GfVec4f WAxis()
		{
			return new GfVec4f(GfPINVOKE.GfVec4f_WAxis(), cMemoryOwn: true);
		}

		public static GfVec4f Axis(uint i)
		{
			return new GfVec4f(GfPINVOKE.GfVec4f_Axis(i), cMemoryOwn: true);
		}

		public GfVec4f Set(float s0, float s1, float s2, float s3)
		{
			return new GfVec4f(GfPINVOKE.GfVec4f_Set(swigCPtr, s0, s1, s2, s3), cMemoryOwn: false);
		}

		public GfVec4f GetProjection(GfVec4f v)
		{
			GfVec4f result = new GfVec4f(GfPINVOKE.GfVec4f_GetProjection(swigCPtr, getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec4f GetComplement(GfVec4f b)
		{
			GfVec4f result = new GfVec4f(GfPINVOKE.GfVec4f_GetComplement(swigCPtr, getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public float GetLengthSq()
		{
			return GfPINVOKE.GfVec4f_GetLengthSq(swigCPtr);
		}

		public float GetLength()
		{
			return GfPINVOKE.GfVec4f_GetLength(swigCPtr);
		}

		public float Normalize(float eps)
		{
			return GfPINVOKE.GfVec4f_Normalize__SWIG_0(swigCPtr, eps);
		}

		public float Normalize()
		{
			return GfPINVOKE.GfVec4f_Normalize__SWIG_1(swigCPtr);
		}

		public GfVec4f GetNormalized(float eps)
		{
			return new GfVec4f(GfPINVOKE.GfVec4f_GetNormalized__SWIG_0(swigCPtr, eps), cMemoryOwn: true);
		}

		public GfVec4f GetNormalized()
		{
			return new GfVec4f(GfPINVOKE.GfVec4f_GetNormalized__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public static bool Equals(GfVec4f lhs, GfVec4f rhs)
		{
			bool result = GfPINVOKE.GfVec4f_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfVec4f lhs, GfVec4f rhs)
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

		public static bool operator !=(GfVec4f lhs, GfVec4f rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfVec4f);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfVec4f_GetHashCode(swigCPtr);
		}

		protected float GetValue(int index)
		{
			return GfPINVOKE.GfVec4f_GetValue(swigCPtr, index);
		}

		protected void SetValue(int index, float value)
		{
			GfPINVOKE.GfVec4f_SetValue(swigCPtr, index, value);
		}
	}
}
