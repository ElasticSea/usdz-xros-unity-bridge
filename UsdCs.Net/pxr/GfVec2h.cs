using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfVec2h : IDisposable
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

		public GfVec2h(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfVec2h obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfVec2h obj)
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

		~GfVec2h()
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
						GfPINVOKE.delete_GfVec2h(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfVec2h()
			: this(GfPINVOKE.new_GfVec2h__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfVec2h(GfHalf value)
			: this(GfPINVOKE.new_GfVec2h__SWIG_1(GfHalf.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec2h(GfHalf s0, GfHalf s1)
			: this(GfPINVOKE.new_GfVec2h__SWIG_2(GfHalf.getCPtr(s0), GfHalf.getCPtr(s1)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec2h(GfVec2d other)
			: this(GfPINVOKE.new_GfVec2h__SWIG_4(GfVec2d.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec2h(GfVec2f other)
			: this(GfPINVOKE.new_GfVec2h__SWIG_5(GfVec2f.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec2h(GfVec2i other)
			: this(GfPINVOKE.new_GfVec2h__SWIG_6(GfVec2i.getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static GfVec2h XAxis()
		{
			return new GfVec2h(GfPINVOKE.GfVec2h_XAxis(), cMemoryOwn: true);
		}

		public static GfVec2h YAxis()
		{
			return new GfVec2h(GfPINVOKE.GfVec2h_YAxis(), cMemoryOwn: true);
		}

		public static GfVec2h Axis(uint i)
		{
			return new GfVec2h(GfPINVOKE.GfVec2h_Axis(i), cMemoryOwn: true);
		}

		public GfVec2h Set(GfHalf s0, GfHalf s1)
		{
			GfVec2h result = new GfVec2h(GfPINVOKE.GfVec2h_Set__SWIG_0(swigCPtr, GfHalf.getCPtr(s0), GfHalf.getCPtr(s1)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec2h Set(GfHalf a)
		{
			return new GfVec2h(GfPINVOKE.GfVec2h_Set__SWIG_1(swigCPtr, GfHalf.getCPtr(a)), cMemoryOwn: false);
		}

		public GfVec2h GetProjection(GfVec2h v)
		{
			GfVec2h result = new GfVec2h(GfPINVOKE.GfVec2h_GetProjection(swigCPtr, getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec2h GetComplement(GfVec2h b)
		{
			GfVec2h result = new GfVec2h(GfPINVOKE.GfVec2h_GetComplement(swigCPtr, getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfHalf GetLengthSq()
		{
			return new GfHalf(GfPINVOKE.GfVec2h_GetLengthSq(swigCPtr), cMemoryOwn: true);
		}

		public GfHalf GetLength()
		{
			return new GfHalf(GfPINVOKE.GfVec2h_GetLength(swigCPtr), cMemoryOwn: true);
		}

		public GfHalf Normalize(GfHalf eps)
		{
			GfHalf result = new GfHalf(GfPINVOKE.GfVec2h_Normalize__SWIG_0(swigCPtr, GfHalf.getCPtr(eps)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfHalf Normalize()
		{
			return new GfHalf(GfPINVOKE.GfVec2h_Normalize__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public GfVec2h GetNormalized(GfHalf eps)
		{
			GfVec2h result = new GfVec2h(GfPINVOKE.GfVec2h_GetNormalized__SWIG_0(swigCPtr, GfHalf.getCPtr(eps)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec2h GetNormalized()
		{
			return new GfVec2h(GfPINVOKE.GfVec2h_GetNormalized__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public static bool Equals(GfVec2h lhs, GfVec2h rhs)
		{
			bool result = GfPINVOKE.GfVec2h_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfVec2h lhs, GfVec2h rhs)
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

		public static bool operator !=(GfVec2h lhs, GfVec2h rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfVec2h);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfVec2h_GetHashCode(swigCPtr);
		}

		protected float GetValue(int index)
		{
			return GfPINVOKE.GfVec2h_GetValue(swigCPtr, index);
		}

		protected void SetValue(int index, float value)
		{
			GfPINVOKE.GfVec2h_SetValue(swigCPtr, index, value);
		}
	}
}
