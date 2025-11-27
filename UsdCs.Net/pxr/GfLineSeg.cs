using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfLineSeg : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public GfLineSeg(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfLineSeg obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfLineSeg obj)
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

		~GfLineSeg()
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
						GfPINVOKE.delete_GfLineSeg(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfLineSeg()
			: this(GfPINVOKE.new_GfLineSeg__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfLineSeg(GfVec3d p0, GfVec3d p1)
			: this(GfPINVOKE.new_GfLineSeg__SWIG_1(GfVec3d.getCPtr(p0), GfVec3d.getCPtr(p1)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec3d GetPoint(double t)
		{
			return new GfVec3d(GfPINVOKE.GfLineSeg_GetPoint(swigCPtr, t), cMemoryOwn: true);
		}

		public GfVec3d GetDirection()
		{
			return new GfVec3d(GfPINVOKE.GfLineSeg_GetDirection(swigCPtr), cMemoryOwn: false);
		}

		public double GetLength()
		{
			return GfPINVOKE.GfLineSeg_GetLength(swigCPtr);
		}

		public GfVec3d FindClosestPoint(GfVec3d point, out double t)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfLineSeg_FindClosestPoint__SWIG_0(swigCPtr, GfVec3d.getCPtr(point), out t), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec3d FindClosestPoint(GfVec3d point)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfLineSeg_FindClosestPoint__SWIG_1(swigCPtr, GfVec3d.getCPtr(point)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool Equals(GfLineSeg lhs, GfLineSeg rhs)
		{
			bool result = GfPINVOKE.GfLineSeg_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfLineSeg lhs, GfLineSeg rhs)
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

		public static bool operator !=(GfLineSeg lhs, GfLineSeg rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfLineSeg);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfLineSeg_GetHashCode(swigCPtr);
		}
	}
}
