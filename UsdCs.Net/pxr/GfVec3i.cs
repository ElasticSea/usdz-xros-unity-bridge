using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfVec3i : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public const uint dimension = 3u;

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

		public GfVec3i(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfVec3i obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfVec3i obj)
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

		~GfVec3i()
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
						GfPINVOKE.delete_GfVec3i(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfVec3i()
			: this(GfPINVOKE.new_GfVec3i__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfVec3i(int value)
			: this(GfPINVOKE.new_GfVec3i__SWIG_1(value), cMemoryOwn: true)
		{
		}

		public GfVec3i(int s0, int s1, int s2)
			: this(GfPINVOKE.new_GfVec3i__SWIG_2(s0, s1, s2), cMemoryOwn: true)
		{
		}

		public static GfVec3i XAxis()
		{
			return new GfVec3i(GfPINVOKE.GfVec3i_XAxis(), cMemoryOwn: true);
		}

		public static GfVec3i YAxis()
		{
			return new GfVec3i(GfPINVOKE.GfVec3i_YAxis(), cMemoryOwn: true);
		}

		public static GfVec3i ZAxis()
		{
			return new GfVec3i(GfPINVOKE.GfVec3i_ZAxis(), cMemoryOwn: true);
		}

		public static GfVec3i Axis(uint i)
		{
			return new GfVec3i(GfPINVOKE.GfVec3i_Axis(i), cMemoryOwn: true);
		}

		public GfVec3i Set(int s0, int s1, int s2)
		{
			return new GfVec3i(GfPINVOKE.GfVec3i_Set(swigCPtr, s0, s1, s2), cMemoryOwn: false);
		}

		public GfVec3i GetProjection(GfVec3i v)
		{
			GfVec3i result = new GfVec3i(GfPINVOKE.GfVec3i_GetProjection(swigCPtr, getCPtr(v)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec3i GetComplement(GfVec3i b)
		{
			GfVec3i result = new GfVec3i(GfPINVOKE.GfVec3i_GetComplement(swigCPtr, getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public int GetLengthSq()
		{
			return GfPINVOKE.GfVec3i_GetLengthSq(swigCPtr);
		}

		public static bool Equals(GfVec3i lhs, GfVec3i rhs)
		{
			bool result = GfPINVOKE.GfVec3i_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfVec3i lhs, GfVec3i rhs)
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

		public static bool operator !=(GfVec3i lhs, GfVec3i rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfVec3i);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfVec3i_GetHashCode(swigCPtr);
		}

		protected int GetValue(int index)
		{
			return GfPINVOKE.GfVec3i_GetValue(swigCPtr, index);
		}

		protected void SetValue(int index, int value)
		{
			GfPINVOKE.GfVec3i_SetValue(swigCPtr, index, value);
		}
	}
}
