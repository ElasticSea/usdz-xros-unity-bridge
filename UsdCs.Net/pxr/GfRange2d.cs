using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfRange2d : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public const uint dimension = 2u;

		public static GfRange2d UnitSquare
		{
			get
			{
				IntPtr intPtr = GfPINVOKE.GfRange2d_UnitSquare_get();
				return (intPtr == IntPtr.Zero) ? null : new GfRange2d(intPtr, cMemoryOwn: false);
			}
		}

		public GfRange2d(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfRange2d obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfRange2d obj)
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

		~GfRange2d()
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
						GfPINVOKE.delete_GfRange2d(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public void SetEmpty()
		{
			GfPINVOKE.GfRange2d_SetEmpty(swigCPtr);
		}

		public GfRange2d()
			: this(GfPINVOKE.new_GfRange2d__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfRange2d(GfVec2d min, GfVec2d max)
			: this(GfPINVOKE.new_GfRange2d__SWIG_1(GfVec2d.getCPtr(min), GfVec2d.getCPtr(max)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec2d GetMin()
		{
			return new GfVec2d(GfPINVOKE.GfRange2d_GetMin(swigCPtr), cMemoryOwn: false);
		}

		public GfVec2d GetMax()
		{
			return new GfVec2d(GfPINVOKE.GfRange2d_GetMax(swigCPtr), cMemoryOwn: false);
		}

		public GfVec2d GetSize()
		{
			return new GfVec2d(GfPINVOKE.GfRange2d_GetSize(swigCPtr), cMemoryOwn: true);
		}

		public GfVec2d GetMidpoint()
		{
			return new GfVec2d(GfPINVOKE.GfRange2d_GetMidpoint(swigCPtr), cMemoryOwn: true);
		}

		public void SetMin(GfVec2d min)
		{
			GfPINVOKE.GfRange2d_SetMin(swigCPtr, GfVec2d.getCPtr(min));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetMax(GfVec2d max)
		{
			GfPINVOKE.GfRange2d_SetMax(swigCPtr, GfVec2d.getCPtr(max));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsEmpty()
		{
			return GfPINVOKE.GfRange2d_IsEmpty(swigCPtr);
		}

		public void ExtendBy(GfVec2d point)
		{
			GfPINVOKE.GfRange2d_ExtendBy__SWIG_0(swigCPtr, GfVec2d.getCPtr(point));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void ExtendBy(GfRange2d range)
		{
			GfPINVOKE.GfRange2d_ExtendBy__SWIG_1(swigCPtr, getCPtr(range));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool Contains(GfVec2d point)
		{
			bool result = GfPINVOKE.GfRange2d_Contains__SWIG_0(swigCPtr, GfVec2d.getCPtr(point));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Contains(GfRange2d range)
		{
			bool result = GfPINVOKE.GfRange2d_Contains__SWIG_1(swigCPtr, getCPtr(range));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsInside(GfVec2d point)
		{
			bool result = GfPINVOKE.GfRange2d_IsInside__SWIG_0(swigCPtr, GfVec2d.getCPtr(point));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsInside(GfRange2d range)
		{
			bool result = GfPINVOKE.GfRange2d_IsInside__SWIG_1(swigCPtr, getCPtr(range));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsOutside(GfRange2d range)
		{
			bool result = GfPINVOKE.GfRange2d_IsOutside(swigCPtr, getCPtr(range));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfRange2d GetUnion(GfRange2d a, GfRange2d b)
		{
			GfRange2d result = new GfRange2d(GfPINVOKE.GfRange2d_GetUnion(getCPtr(a), getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfRange2d UnionWith(GfRange2d b)
		{
			GfRange2d result = new GfRange2d(GfPINVOKE.GfRange2d_UnionWith__SWIG_0(swigCPtr, getCPtr(b)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfRange2d UnionWith(GfVec2d b)
		{
			GfRange2d result = new GfRange2d(GfPINVOKE.GfRange2d_UnionWith__SWIG_1(swigCPtr, GfVec2d.getCPtr(b)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfRange2d Union(GfRange2d a, GfRange2d b)
		{
			GfRange2d result = new GfRange2d(GfPINVOKE.GfRange2d_Union__SWIG_0(getCPtr(a), getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfRange2d Union(GfVec2d b)
		{
			GfRange2d result = new GfRange2d(GfPINVOKE.GfRange2d_Union__SWIG_2(swigCPtr, GfVec2d.getCPtr(b)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfRange2d GetIntersection(GfRange2d a, GfRange2d b)
		{
			GfRange2d result = new GfRange2d(GfPINVOKE.GfRange2d_GetIntersection(getCPtr(a), getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfRange2d Intersection(GfRange2d a, GfRange2d b)
		{
			GfRange2d result = new GfRange2d(GfPINVOKE.GfRange2d_Intersection__SWIG_0(getCPtr(a), getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfRange2d IntersectWith(GfRange2d b)
		{
			GfRange2d result = new GfRange2d(GfPINVOKE.GfRange2d_IntersectWith(swigCPtr, getCPtr(b)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public double GetDistanceSquared(GfVec2d p)
		{
			double result = GfPINVOKE.GfRange2d_GetDistanceSquared(swigCPtr, GfVec2d.getCPtr(p));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec2d GetCorner(uint i)
		{
			return new GfVec2d(GfPINVOKE.GfRange2d_GetCorner(swigCPtr, i), cMemoryOwn: true);
		}

		public GfRange2d GetQuadrant(uint i)
		{
			return new GfRange2d(GfPINVOKE.GfRange2d_GetQuadrant(swigCPtr, i), cMemoryOwn: true);
		}

		public static bool Equals(GfRange2d lhs, GfRange2d rhs)
		{
			bool result = GfPINVOKE.GfRange2d_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfRange2d lhs, GfRange2d rhs)
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

		public static bool operator !=(GfRange2d lhs, GfRange2d rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfRange2d);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfRange2d_GetHashCode(swigCPtr);
		}
	}
}
