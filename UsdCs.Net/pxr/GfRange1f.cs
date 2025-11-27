using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfRange1f : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public const uint dimension = 1u;

		public GfRange1f(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfRange1f obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfRange1f obj)
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

		~GfRange1f()
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
						GfPINVOKE.delete_GfRange1f(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public void SetEmpty()
		{
			GfPINVOKE.GfRange1f_SetEmpty(swigCPtr);
		}

		public GfRange1f()
			: this(GfPINVOKE.new_GfRange1f__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfRange1f(float min, float max)
			: this(GfPINVOKE.new_GfRange1f__SWIG_1(min, max), cMemoryOwn: true)
		{
		}

		public float GetMin()
		{
			return GfPINVOKE.GfRange1f_GetMin(swigCPtr);
		}

		public float GetMax()
		{
			return GfPINVOKE.GfRange1f_GetMax(swigCPtr);
		}

		public float GetSize()
		{
			return GfPINVOKE.GfRange1f_GetSize(swigCPtr);
		}

		public float GetMidpoint()
		{
			return GfPINVOKE.GfRange1f_GetMidpoint(swigCPtr);
		}

		public void SetMin(float min)
		{
			GfPINVOKE.GfRange1f_SetMin(swigCPtr, min);
		}

		public void SetMax(float max)
		{
			GfPINVOKE.GfRange1f_SetMax(swigCPtr, max);
		}

		public bool IsEmpty()
		{
			return GfPINVOKE.GfRange1f_IsEmpty(swigCPtr);
		}

		public void ExtendBy(float point)
		{
			GfPINVOKE.GfRange1f_ExtendBy__SWIG_0(swigCPtr, point);
		}

		public void ExtendBy(GfRange1f range)
		{
			GfPINVOKE.GfRange1f_ExtendBy__SWIG_1(swigCPtr, getCPtr(range));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool Contains(float point)
		{
			return GfPINVOKE.GfRange1f_Contains__SWIG_0(swigCPtr, point);
		}

		public bool Contains(GfRange1f range)
		{
			bool result = GfPINVOKE.GfRange1f_Contains__SWIG_1(swigCPtr, getCPtr(range));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsInside(float point)
		{
			return GfPINVOKE.GfRange1f_IsInside__SWIG_0(swigCPtr, point);
		}

		public bool IsInside(GfRange1f range)
		{
			bool result = GfPINVOKE.GfRange1f_IsInside__SWIG_1(swigCPtr, getCPtr(range));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsOutside(GfRange1f range)
		{
			bool result = GfPINVOKE.GfRange1f_IsOutside(swigCPtr, getCPtr(range));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfRange1f GetUnion(GfRange1f a, GfRange1f b)
		{
			GfRange1f result = new GfRange1f(GfPINVOKE.GfRange1f_GetUnion(getCPtr(a), getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfRange1f UnionWith(GfRange1f b)
		{
			GfRange1f result = new GfRange1f(GfPINVOKE.GfRange1f_UnionWith__SWIG_0(swigCPtr, getCPtr(b)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfRange1f UnionWith(float b)
		{
			return new GfRange1f(GfPINVOKE.GfRange1f_UnionWith__SWIG_1(swigCPtr, b), cMemoryOwn: false);
		}

		public static GfRange1f Union(GfRange1f a, GfRange1f b)
		{
			GfRange1f result = new GfRange1f(GfPINVOKE.GfRange1f_Union__SWIG_0(getCPtr(a), getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfRange1f Union(float b)
		{
			return new GfRange1f(GfPINVOKE.GfRange1f_Union__SWIG_2(swigCPtr, b), cMemoryOwn: false);
		}

		public static GfRange1f GetIntersection(GfRange1f a, GfRange1f b)
		{
			GfRange1f result = new GfRange1f(GfPINVOKE.GfRange1f_GetIntersection(getCPtr(a), getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static GfRange1f Intersection(GfRange1f a, GfRange1f b)
		{
			GfRange1f result = new GfRange1f(GfPINVOKE.GfRange1f_Intersection__SWIG_0(getCPtr(a), getCPtr(b)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfRange1f IntersectWith(GfRange1f b)
		{
			GfRange1f result = new GfRange1f(GfPINVOKE.GfRange1f_IntersectWith(swigCPtr, getCPtr(b)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public double GetDistanceSquared(float p)
		{
			return GfPINVOKE.GfRange1f_GetDistanceSquared(swigCPtr, p);
		}

		public static bool Equals(GfRange1f lhs, GfRange1f rhs)
		{
			bool result = GfPINVOKE.GfRange1f_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfRange1f lhs, GfRange1f rhs)
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

		public static bool operator !=(GfRange1f lhs, GfRange1f rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfRange1f);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfRange1f_GetHashCode(swigCPtr);
		}
	}
}
