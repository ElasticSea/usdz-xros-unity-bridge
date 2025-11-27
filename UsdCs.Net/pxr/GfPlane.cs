using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfPlane : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public GfPlane(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfPlane obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfPlane obj)
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

		~GfPlane()
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
						GfPINVOKE.delete_GfPlane(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfPlane()
			: this(GfPINVOKE.new_GfPlane__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfPlane(GfVec3d normal, double distanceToOrigin)
			: this(GfPINVOKE.new_GfPlane__SWIG_1(GfVec3d.getCPtr(normal), distanceToOrigin), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfPlane(GfVec3d normal, GfVec3d point)
			: this(GfPINVOKE.new_GfPlane__SWIG_2(GfVec3d.getCPtr(normal), GfVec3d.getCPtr(point)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfPlane(GfVec3d p0, GfVec3d p1, GfVec3d p2)
			: this(GfPINVOKE.new_GfPlane__SWIG_3(GfVec3d.getCPtr(p0), GfVec3d.getCPtr(p1), GfVec3d.getCPtr(p2)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfPlane(GfVec4d eqn)
			: this(GfPINVOKE.new_GfPlane__SWIG_4(GfVec4d.getCPtr(eqn)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void Set(GfVec3d normal, double distanceToOrigin)
		{
			GfPINVOKE.GfPlane_Set__SWIG_0(swigCPtr, GfVec3d.getCPtr(normal), distanceToOrigin);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void Set(GfVec3d normal, GfVec3d point)
		{
			GfPINVOKE.GfPlane_Set__SWIG_1(swigCPtr, GfVec3d.getCPtr(normal), GfVec3d.getCPtr(point));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void Set(GfVec3d p0, GfVec3d p1, GfVec3d p2)
		{
			GfPINVOKE.GfPlane_Set__SWIG_2(swigCPtr, GfVec3d.getCPtr(p0), GfVec3d.getCPtr(p1), GfVec3d.getCPtr(p2));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void Set(GfVec4d eqn)
		{
			GfPINVOKE.GfPlane_Set__SWIG_3(swigCPtr, GfVec4d.getCPtr(eqn));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec3d GetNormal()
		{
			return new GfVec3d(GfPINVOKE.GfPlane_GetNormal(swigCPtr), cMemoryOwn: false);
		}

		public double GetDistanceFromOrigin()
		{
			return GfPINVOKE.GfPlane_GetDistanceFromOrigin(swigCPtr);
		}

		public GfVec4d GetEquation()
		{
			return new GfVec4d(GfPINVOKE.GfPlane_GetEquation(swigCPtr), cMemoryOwn: true);
		}

		public double GetDistance(GfVec3d p)
		{
			double result = GfPINVOKE.GfPlane_GetDistance(swigCPtr, GfVec3d.getCPtr(p));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec3d Project(GfVec3d p)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfPlane_Project(swigCPtr, GfVec3d.getCPtr(p)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfPlane Transform(GfMatrix4d matrix)
		{
			GfPlane result = new GfPlane(GfPINVOKE.GfPlane_Transform(swigCPtr, GfMatrix4d.getCPtr(matrix)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reorient(GfVec3d p)
		{
			GfPINVOKE.GfPlane_Reorient(swigCPtr, GfVec3d.getCPtr(p));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IntersectsPositiveHalfSpace(GfRange3d box)
		{
			bool result = GfPINVOKE.GfPlane_IntersectsPositiveHalfSpace__SWIG_0(swigCPtr, GfRange3d.getCPtr(box));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IntersectsPositiveHalfSpace(GfVec3d pt)
		{
			bool result = GfPINVOKE.GfPlane_IntersectsPositiveHalfSpace__SWIG_1(swigCPtr, GfVec3d.getCPtr(pt));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool Equals(GfPlane lhs, GfPlane rhs)
		{
			bool result = GfPINVOKE.GfPlane_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfPlane lhs, GfPlane rhs)
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

		public static bool operator !=(GfPlane lhs, GfPlane rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfPlane);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfPlane_GetHashCode(swigCPtr);
		}
	}
}
