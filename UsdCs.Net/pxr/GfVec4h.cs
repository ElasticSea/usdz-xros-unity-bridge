using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfVec4h : IDisposable
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

		public GfVec4h(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfVec4h obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfVec4h obj)
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

		~GfVec4h()
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
						GfPINVOKE.delete_GfVec4h(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfVec4h()
			: this(GfPINVOKE.new_GfVec4h__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfVec4h(GfHalf value)
			: this(GfPINVOKE.new_GfVec4h__SWIG_1(GfHalf.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec4h(GfHalf s0, GfHalf s1, GfHalf s2, GfHalf s3)
			: this(GfPINVOKE.new_GfVec4h__SWIG_2(GfHalf.getCPtr(s0), GfHalf.getCPtr(s1), GfHalf.getCPtr(s2), GfHalf.getCPtr(s3)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec4h(GfVec4d other)
			: this(GfPINVOKE.new_GfVec4h__SWIG_4(GfVec4d.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec4h(GfVec4f other)
			: this(GfPINVOKE.new_GfVec4h__SWIG_5(GfVec4f.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec4h(GfVec4i other)
			: this(GfPINVOKE.new_GfVec4h__SWIG_6(GfVec4i.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static GfVec4h XAxis()
		{
			return new GfVec4h(GfPINVOKE.GfVec4h_XAxis(), cMemoryOwn: true);
		}

		public static GfVec4h YAxis()
		{
			return new GfVec4h(GfPINVOKE.GfVec4h_YAxis(), cMemoryOwn: true);
		}

		public static GfVec4h ZAxis()
		{
			return new GfVec4h(GfPINVOKE.GfVec4h_ZAxis(), cMemoryOwn: true);
		}

		public static GfVec4h WAxis()
		{
			return new GfVec4h(GfPINVOKE.GfVec4h_WAxis(), cMemoryOwn: true);
		}

		public static GfVec4h Axis(uint i)
		{
			return new GfVec4h(GfPINVOKE.GfVec4h_Axis(i), cMemoryOwn: true);
		}

		public GfVec4h Set(GfHalf s0, GfHalf s1, GfHalf s2, GfHalf s3)
		{
			GfVec4h result = new GfVec4h(GfPINVOKE.GfVec4h_Set__SWIG_0(swigCPtr, GfHalf.getCPtr(s0), GfHalf.getCPtr(s1), GfHalf.getCPtr(s2), GfHalf.getCPtr(s3)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec4h Set(GfHalf a)
		{
			return new GfVec4h(GfPINVOKE.GfVec4h_Set__SWIG_1(swigCPtr, GfHalf.getCPtr(a)), cMemoryOwn: false);
		}

		public GfVec4h GetProjection(GfVec4h v)
		{
			GfVec4h result = new GfVec4h(GfPINVOKE.GfVec4h_GetProjection(swigCPtr, getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec4h GetComplement(GfVec4h b)
		{
			GfVec4h result = new GfVec4h(GfPINVOKE.GfVec4h_GetComplement(swigCPtr, getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfHalf GetLengthSq()
		{
			return new GfHalf(GfPINVOKE.GfVec4h_GetLengthSq(swigCPtr), cMemoryOwn: true);
		}

		public GfHalf GetLength()
		{
			return new GfHalf(GfPINVOKE.GfVec4h_GetLength(swigCPtr), cMemoryOwn: true);
		}

		public GfHalf Normalize(GfHalf eps)
		{
			GfHalf result = new GfHalf(GfPINVOKE.GfVec4h_Normalize__SWIG_0(swigCPtr, GfHalf.getCPtr(eps)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfHalf Normalize()
		{
			return new GfHalf(GfPINVOKE.GfVec4h_Normalize__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public GfVec4h GetNormalized(GfHalf eps)
		{
			GfVec4h result = new GfVec4h(GfPINVOKE.GfVec4h_GetNormalized__SWIG_0(swigCPtr, GfHalf.getCPtr(eps)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec4h GetNormalized()
		{
			return new GfVec4h(GfPINVOKE.GfVec4h_GetNormalized__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public static bool Equals(GfVec4h lhs, GfVec4h rhs)
		{
			bool result = GfPINVOKE.GfVec4h_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfVec4h lhs, GfVec4h rhs)
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

		public static bool operator !=(GfVec4h lhs, GfVec4h rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfVec4h);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfVec4h_GetHashCode(swigCPtr);
		}

		protected float GetValue(int index)
		{
			return GfPINVOKE.GfVec4h_GetValue(swigCPtr, index);
		}

		protected void SetValue(int index, float value)
		{
			GfPINVOKE.GfVec4h_SetValue(swigCPtr, index, value);
		}
	}
}
