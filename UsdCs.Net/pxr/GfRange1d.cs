using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfRange1d : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public const uint dimension = 1u;

		public GfRange1d(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfRange1d obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfRange1d obj)
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

		~GfRange1d()
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
						GfPINVOKE.delete_GfRange1d(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public void SetEmpty()
		{
			GfPINVOKE.GfRange1d_SetEmpty(swigCPtr);
		}

		public GfRange1d()
			: this(GfPINVOKE.new_GfRange1d__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfRange1d(double min, double max)
			: this(GfPINVOKE.new_GfRange1d__SWIG_1(min, max), cMemoryOwn: true)
		{
		}

		public double GetMin()
		{
			return GfPINVOKE.GfRange1d_GetMin(swigCPtr);
		}

		public double GetMax()
		{
			return GfPINVOKE.GfRange1d_GetMax(swigCPtr);
		}

		public double GetSize()
		{
			return GfPINVOKE.GfRange1d_GetSize(swigCPtr);
		}

		public double GetMidpoint()
		{
			return GfPINVOKE.GfRange1d_GetMidpoint(swigCPtr);
		}

		public void SetMin(double min)
		{
			GfPINVOKE.GfRange1d_SetMin(swigCPtr, min);
		}

		public void SetMax(double max)
		{
			GfPINVOKE.GfRange1d_SetMax(swigCPtr, max);
		}

		public bool IsEmpty()
		{
			return GfPINVOKE.GfRange1d_IsEmpty(swigCPtr);
		}

		public void ExtendBy(double point)
		{
			GfPINVOKE.GfRange1d_ExtendBy__SWIG_0(swigCPtr, point);
		}

		public void ExtendBy(GfRange1d range)
		{
			GfPINVOKE.GfRange1d_ExtendBy__SWIG_1(swigCPtr, getCPtr(range));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool Contains(double point)
		{
			return GfPINVOKE.GfRange1d_Contains__SWIG_0(swigCPtr, point);
		}

		public bool Contains(GfRange1d range)
		{
			bool result = GfPINVOKE.GfRange1d_Contains__SWIG_1(swigCPtr, getCPtr(range));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsInside(double point)
		{
			return GfPINVOKE.GfRange1d_IsInside__SWIG_0(swigCPtr, point);
		}

		public bool IsInside(GfRange1d range)
		{
			bool result = GfPINVOKE.GfRange1d_IsInside__SWIG_1(swigCPtr, getCPtr(range));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsOutside(GfRange1d range)
		{
			bool result = GfPINVOKE.GfRange1d_IsOutside(swigCPtr, getCPtr(range));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfRange1d GetUnion(GfRange1d a, GfRange1d b)
		{
			GfRange1d result = new GfRange1d(GfPINVOKE.GfRange1d_GetUnion(getCPtr(a), getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfRange1d UnionWith(GfRange1d b)
		{
			GfRange1d result = new GfRange1d(GfPINVOKE.GfRange1d_UnionWith__SWIG_0(swigCPtr, getCPtr(b)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfRange1d UnionWith(double b)
		{
			return new GfRange1d(GfPINVOKE.GfRange1d_UnionWith__SWIG_1(swigCPtr, b), cMemoryOwn: false);
		}

		public static GfRange1d Union(GfRange1d a, GfRange1d b)
		{
			GfRange1d result = new GfRange1d(GfPINVOKE.GfRange1d_Union__SWIG_0(getCPtr(a), getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfRange1d Union(double b)
		{
			return new GfRange1d(GfPINVOKE.GfRange1d_Union__SWIG_2(swigCPtr, b), cMemoryOwn: false);
		}

		public static GfRange1d GetIntersection(GfRange1d a, GfRange1d b)
		{
			GfRange1d result = new GfRange1d(GfPINVOKE.GfRange1d_GetIntersection(getCPtr(a), getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfRange1d Intersection(GfRange1d a, GfRange1d b)
		{
			GfRange1d result = new GfRange1d(GfPINVOKE.GfRange1d_Intersection__SWIG_0(getCPtr(a), getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfRange1d IntersectWith(GfRange1d b)
		{
			GfRange1d result = new GfRange1d(GfPINVOKE.GfRange1d_IntersectWith(swigCPtr, getCPtr(b)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public double GetDistanceSquared(double p)
		{
			return GfPINVOKE.GfRange1d_GetDistanceSquared(swigCPtr, p);
		}

		public static bool Equals(GfRange1d lhs, GfRange1d rhs)
		{
			bool result = GfPINVOKE.GfRange1d_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfRange1d lhs, GfRange1d rhs)
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

		public static bool operator !=(GfRange1d lhs, GfRange1d rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfRange1d);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfRange1d_GetHashCode(swigCPtr);
		}
	}
}
