using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfRange3d : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public const uint dimension = 3u;

		public static GfRange3d UnitCube
		{
			get
			{
				IntPtr intPtr = GfPINVOKE.GfRange3d_UnitCube_get();
				return (intPtr == IntPtr.Zero) ? null : new GfRange3d(intPtr, cMemoryOwn: false);
			}
		}

		public GfRange3d(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfRange3d obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfRange3d obj)
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

		~GfRange3d()
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
						GfPINVOKE.delete_GfRange3d(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public void SetEmpty()
		{
			GfPINVOKE.GfRange3d_SetEmpty(swigCPtr);
		}

		public GfRange3d()
			: this(GfPINVOKE.new_GfRange3d__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfRange3d(GfVec3d min, GfVec3d max)
			: this(GfPINVOKE.new_GfRange3d__SWIG_1(GfVec3d.getCPtr(min), GfVec3d.getCPtr(max)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec3d GetMin()
		{
			return new GfVec3d(GfPINVOKE.GfRange3d_GetMin(swigCPtr), cMemoryOwn: false);
		}

		public GfVec3d GetMax()
		{
			return new GfVec3d(GfPINVOKE.GfRange3d_GetMax(swigCPtr), cMemoryOwn: false);
		}

		public GfVec3d GetSize()
		{
			return new GfVec3d(GfPINVOKE.GfRange3d_GetSize(swigCPtr), cMemoryOwn: true);
		}

		public GfVec3d GetMidpoint()
		{
			return new GfVec3d(GfPINVOKE.GfRange3d_GetMidpoint(swigCPtr), cMemoryOwn: true);
		}

		public void SetMin(GfVec3d min)
		{
			GfPINVOKE.GfRange3d_SetMin(swigCPtr, GfVec3d.getCPtr(min));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetMax(GfVec3d max)
		{
			GfPINVOKE.GfRange3d_SetMax(swigCPtr, GfVec3d.getCPtr(max));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsEmpty()
		{
			return GfPINVOKE.GfRange3d_IsEmpty(swigCPtr);
		}

		public void ExtendBy(GfVec3d point)
		{
			GfPINVOKE.GfRange3d_ExtendBy__SWIG_0(swigCPtr, GfVec3d.getCPtr(point));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void ExtendBy(GfRange3d range)
		{
			GfPINVOKE.GfRange3d_ExtendBy__SWIG_1(swigCPtr, getCPtr(range));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool Contains(GfVec3d point)
		{
			bool result = GfPINVOKE.GfRange3d_Contains__SWIG_0(swigCPtr, GfVec3d.getCPtr(point));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Contains(GfRange3d range)
		{
			bool result = GfPINVOKE.GfRange3d_Contains__SWIG_1(swigCPtr, getCPtr(range));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsInside(GfVec3d point)
		{
			bool result = GfPINVOKE.GfRange3d_IsInside__SWIG_0(swigCPtr, GfVec3d.getCPtr(point));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsInside(GfRange3d range)
		{
			bool result = GfPINVOKE.GfRange3d_IsInside__SWIG_1(swigCPtr, getCPtr(range));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsOutside(GfRange3d range)
		{
			bool result = GfPINVOKE.GfRange3d_IsOutside(swigCPtr, getCPtr(range));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfRange3d GetUnion(GfRange3d a, GfRange3d b)
		{
			GfRange3d result = new GfRange3d(GfPINVOKE.GfRange3d_GetUnion(getCPtr(a), getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfRange3d UnionWith(GfRange3d b)
		{
			GfRange3d result = new GfRange3d(GfPINVOKE.GfRange3d_UnionWith__SWIG_0(swigCPtr, getCPtr(b)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfRange3d UnionWith(GfVec3d b)
		{
			GfRange3d result = new GfRange3d(GfPINVOKE.GfRange3d_UnionWith__SWIG_1(swigCPtr, GfVec3d.getCPtr(b)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfRange3d Union(GfRange3d a, GfRange3d b)
		{
			GfRange3d result = new GfRange3d(GfPINVOKE.GfRange3d_Union__SWIG_0(getCPtr(a), getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfRange3d Union(GfVec3d b)
		{
			GfRange3d result = new GfRange3d(GfPINVOKE.GfRange3d_Union__SWIG_2(swigCPtr, GfVec3d.getCPtr(b)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfRange3d GetIntersection(GfRange3d a, GfRange3d b)
		{
			GfRange3d result = new GfRange3d(GfPINVOKE.GfRange3d_GetIntersection(getCPtr(a), getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfRange3d Intersection(GfRange3d a, GfRange3d b)
		{
			GfRange3d result = new GfRange3d(GfPINVOKE.GfRange3d_Intersection__SWIG_0(getCPtr(a), getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfRange3d IntersectWith(GfRange3d b)
		{
			GfRange3d result = new GfRange3d(GfPINVOKE.GfRange3d_IntersectWith(swigCPtr, getCPtr(b)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public double GetDistanceSquared(GfVec3d p)
		{
			double result = GfPINVOKE.GfRange3d_GetDistanceSquared(swigCPtr, GfVec3d.getCPtr(p));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec3d GetCorner(uint i)
		{
			return new GfVec3d(GfPINVOKE.GfRange3d_GetCorner(swigCPtr, i), cMemoryOwn: true);
		}

		public GfRange3d GetOctant(uint i)
		{
			return new GfRange3d(GfPINVOKE.GfRange3d_GetOctant(swigCPtr, i), cMemoryOwn: true);
		}

		public static bool Equals(GfRange3d lhs, GfRange3d rhs)
		{
			bool result = GfPINVOKE.GfRange3d_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfRange3d lhs, GfRange3d rhs)
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

		public static bool operator !=(GfRange3d lhs, GfRange3d rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfRange3d);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfRange3d_GetHashCode(swigCPtr);
		}
	}
}
