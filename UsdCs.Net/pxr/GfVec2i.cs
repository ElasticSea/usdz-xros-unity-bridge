using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfVec2i : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public const uint dimension = 2u;

		public int this[int index]
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

		public GfVec2i(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfVec2i obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfVec2i obj)
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

		~GfVec2i()
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
						GfPINVOKE.delete_GfVec2i(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfVec2i()
			: this(GfPINVOKE.new_GfVec2i__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfVec2i(int value)
			: this(GfPINVOKE.new_GfVec2i__SWIG_1(value), cMemoryOwn: true)
		{
		}

		public GfVec2i(int s0, int s1)
			: this(GfPINVOKE.new_GfVec2i__SWIG_2(s0, s1), cMemoryOwn: true)
		{
		}

		public static GfVec2i XAxis()
		{
			return new GfVec2i(GfPINVOKE.GfVec2i_XAxis(), cMemoryOwn: true);
		}

		public static GfVec2i YAxis()
		{
			return new GfVec2i(GfPINVOKE.GfVec2i_YAxis(), cMemoryOwn: true);
		}

		public static GfVec2i Axis(uint i)
		{
			return new GfVec2i(GfPINVOKE.GfVec2i_Axis(i), cMemoryOwn: true);
		}

		public GfVec2i Set(int s0, int s1)
		{
			return new GfVec2i(GfPINVOKE.GfVec2i_Set(swigCPtr, s0, s1), cMemoryOwn: false);
		}

		public GfVec2i GetProjection(GfVec2i v)
		{
			GfVec2i result = new GfVec2i(GfPINVOKE.GfVec2i_GetProjection(swigCPtr, getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec2i GetComplement(GfVec2i b)
		{
			GfVec2i result = new GfVec2i(GfPINVOKE.GfVec2i_GetComplement(swigCPtr, getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public int GetLengthSq()
		{
			return GfPINVOKE.GfVec2i_GetLengthSq(swigCPtr);
		}

		public static bool Equals(GfVec2i lhs, GfVec2i rhs)
		{
			bool result = GfPINVOKE.GfVec2i_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfVec2i lhs, GfVec2i rhs)
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

		public static bool operator !=(GfVec2i lhs, GfVec2i rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfVec2i);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfVec2i_GetHashCode(swigCPtr);
		}

		protected int GetValue(int index)
		{
			return GfPINVOKE.GfVec2i_GetValue(swigCPtr, index);
		}

		protected void SetValue(int index, int value)
		{
			GfPINVOKE.GfVec2i_SetValue(swigCPtr, index, value);
		}
	}
}
