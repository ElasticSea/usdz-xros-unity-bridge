using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfVec4i : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public const uint dimension = 4u;

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

		public GfVec4i(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfVec4i obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfVec4i obj)
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

		~GfVec4i()
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
						GfPINVOKE.delete_GfVec4i(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfVec4i()
			: this(GfPINVOKE.new_GfVec4i__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfVec4i(int value)
			: this(GfPINVOKE.new_GfVec4i__SWIG_1(value), cMemoryOwn: true)
		{
		}

		public GfVec4i(int s0, int s1, int s2, int s3)
			: this(GfPINVOKE.new_GfVec4i__SWIG_2(s0, s1, s2, s3), cMemoryOwn: true)
		{
		}

		public static GfVec4i XAxis()
		{
			return new GfVec4i(GfPINVOKE.GfVec4i_XAxis(), cMemoryOwn: true);
		}

		public static GfVec4i YAxis()
		{
			return new GfVec4i(GfPINVOKE.GfVec4i_YAxis(), cMemoryOwn: true);
		}

		public static GfVec4i ZAxis()
		{
			return new GfVec4i(GfPINVOKE.GfVec4i_ZAxis(), cMemoryOwn: true);
		}

		public static GfVec4i WAxis()
		{
			return new GfVec4i(GfPINVOKE.GfVec4i_WAxis(), cMemoryOwn: true);
		}

		public static GfVec4i Axis(uint i)
		{
			return new GfVec4i(GfPINVOKE.GfVec4i_Axis(i), cMemoryOwn: true);
		}

		public GfVec4i Set(int s0, int s1, int s2, int s3)
		{
			return new GfVec4i(GfPINVOKE.GfVec4i_Set(swigCPtr, s0, s1, s2, s3), cMemoryOwn: false);
		}

		public GfVec4i GetProjection(GfVec4i v)
		{
			GfVec4i result = new GfVec4i(GfPINVOKE.GfVec4i_GetProjection(swigCPtr, getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec4i GetComplement(GfVec4i b)
		{
			GfVec4i result = new GfVec4i(GfPINVOKE.GfVec4i_GetComplement(swigCPtr, getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public int GetLengthSq()
		{
			return GfPINVOKE.GfVec4i_GetLengthSq(swigCPtr);
		}

		public static bool Equals(GfVec4i lhs, GfVec4i rhs)
		{
			bool result = GfPINVOKE.GfVec4i_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfVec4i lhs, GfVec4i rhs)
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

		public static bool operator !=(GfVec4i lhs, GfVec4i rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfVec4i);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfVec4i_GetHashCode(swigCPtr);
		}

		protected int GetValue(int index)
		{
			return GfPINVOKE.GfVec4i_GetValue(swigCPtr, index);
		}

		protected void SetValue(int index, int value)
		{
			GfPINVOKE.GfVec4i_SetValue(swigCPtr, index, value);
		}
	}
}
