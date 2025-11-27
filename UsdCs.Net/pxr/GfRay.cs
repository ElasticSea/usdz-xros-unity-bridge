using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfRay : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public GfRay(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfRay obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfRay obj)
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

		~GfRay()
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
						GfPINVOKE.delete_GfRay(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfRay()
			: this(GfPINVOKE.new_GfRay__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfRay(GfVec3d startPoint, GfVec3d direction)
			: this(GfPINVOKE.new_GfRay__SWIG_1(GfVec3d.getCPtr(startPoint), GfVec3d.getCPtr(direction)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetPointAndDirection(GfVec3d startPoint, GfVec3d direction)
		{
			GfPINVOKE.GfRay_SetPointAndDirection(swigCPtr, GfVec3d.getCPtr(startPoint), GfVec3d.getCPtr(direction));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetEnds(GfVec3d startPoint, GfVec3d endPoint)
		{
			GfPINVOKE.GfRay_SetEnds(swigCPtr, GfVec3d.getCPtr(startPoint), GfVec3d.getCPtr(endPoint));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec3d GetStartPoint()
		{
			return new GfVec3d(GfPINVOKE.GfRay_GetStartPoint(swigCPtr), cMemoryOwn: false);
		}

		public GfVec3d GetDirection()
		{
			return new GfVec3d(GfPINVOKE.GfRay_GetDirection(swigCPtr), cMemoryOwn: false);
		}

		public GfVec3d GetPoint(double distance)
		{
			return new GfVec3d(GfPINVOKE.GfRay_GetPoint(swigCPtr, distance), cMemoryOwn: true);
		}

		public GfRay Transform(GfMatrix4d matrix)
		{
			GfRay result = new GfRay(GfPINVOKE.GfRay_Transform(swigCPtr, GfMatrix4d.getCPtr(matrix)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec3d FindClosestPoint(GfVec3d point, out double rayDistance)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfRay_FindClosestPoint__SWIG_0(swigCPtr, GfVec3d.getCPtr(point), out rayDistance), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec3d FindClosestPoint(GfVec3d point)
		{
			GfVec3d result = new GfVec3d(GfPINVOKE.GfRay_FindClosestPoint__SWIG_1(swigCPtr, GfVec3d.getCPtr(point)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersect(GfVec3d p0, GfVec3d p1, GfVec3d p2, out double distance, GfVec3d barycentricCoords, out bool frontFacing, double maxDist)
		{
			bool result = GfPINVOKE.GfRay_Intersect__SWIG_0(swigCPtr, GfVec3d.getCPtr(p0), GfVec3d.getCPtr(p1), GfVec3d.getCPtr(p2), out distance, GfVec3d.getCPtr(barycentricCoords), out frontFacing, maxDist);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersect(GfVec3d p0, GfVec3d p1, GfVec3d p2, out double distance, GfVec3d barycentricCoords, out bool frontFacing)
		{
			bool result = GfPINVOKE.GfRay_Intersect__SWIG_1(swigCPtr, GfVec3d.getCPtr(p0), GfVec3d.getCPtr(p1), GfVec3d.getCPtr(p2), out distance, GfVec3d.getCPtr(barycentricCoords), out frontFacing);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersect(GfVec3d p0, GfVec3d p1, GfVec3d p2, out double distance, GfVec3d barycentricCoords)
		{
			bool result = GfPINVOKE.GfRay_Intersect__SWIG_2(swigCPtr, GfVec3d.getCPtr(p0), GfVec3d.getCPtr(p1), GfVec3d.getCPtr(p2), out distance, GfVec3d.getCPtr(barycentricCoords));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersect(GfVec3d p0, GfVec3d p1, GfVec3d p2, out double distance)
		{
			bool result = GfPINVOKE.GfRay_Intersect__SWIG_3(swigCPtr, GfVec3d.getCPtr(p0), GfVec3d.getCPtr(p1), GfVec3d.getCPtr(p2), out distance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersect(GfVec3d p0, GfVec3d p1, GfVec3d p2)
		{
			bool result = GfPINVOKE.GfRay_Intersect__SWIG_4(swigCPtr, GfVec3d.getCPtr(p0), GfVec3d.getCPtr(p1), GfVec3d.getCPtr(p2));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersect(GfPlane plane, out double distance, out bool frontFacing)
		{
			bool result = GfPINVOKE.GfRay_Intersect__SWIG_5(swigCPtr, GfPlane.getCPtr(plane), out distance, out frontFacing);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersect(GfPlane plane, out double distance)
		{
			bool result = GfPINVOKE.GfRay_Intersect__SWIG_6(swigCPtr, GfPlane.getCPtr(plane), out distance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersect(GfPlane plane)
		{
			bool result = GfPINVOKE.GfRay_Intersect__SWIG_7(swigCPtr, GfPlane.getCPtr(plane));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersect(GfRange3d box, out double enterDistance, out double exitDistance)
		{
			bool result = GfPINVOKE.GfRay_Intersect__SWIG_8(swigCPtr, GfRange3d.getCPtr(box), out enterDistance, out exitDistance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersect(GfRange3d box, out double enterDistance)
		{
			bool result = GfPINVOKE.GfRay_Intersect__SWIG_9(swigCPtr, GfRange3d.getCPtr(box), out enterDistance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersect(GfRange3d box)
		{
			bool result = GfPINVOKE.GfRay_Intersect__SWIG_10(swigCPtr, GfRange3d.getCPtr(box));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersect(GfBBox3d box, out double enterDistance, out double exitDistance)
		{
			bool result = GfPINVOKE.GfRay_Intersect__SWIG_11(swigCPtr, GfBBox3d.getCPtr(box), out enterDistance, out exitDistance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersect(GfBBox3d box, out double enterDistance)
		{
			bool result = GfPINVOKE.GfRay_Intersect__SWIG_12(swigCPtr, GfBBox3d.getCPtr(box), out enterDistance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersect(GfBBox3d box)
		{
			bool result = GfPINVOKE.GfRay_Intersect__SWIG_13(swigCPtr, GfBBox3d.getCPtr(box));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersect(GfVec3d center, double radius, out double enterDistance, out double exitDistance)
		{
			bool result = GfPINVOKE.GfRay_Intersect__SWIG_14(swigCPtr, GfVec3d.getCPtr(center), radius, out enterDistance, out exitDistance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersect(GfVec3d center, double radius, out double enterDistance)
		{
			bool result = GfPINVOKE.GfRay_Intersect__SWIG_15(swigCPtr, GfVec3d.getCPtr(center), radius, out enterDistance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersect(GfVec3d center, double radius)
		{
			bool result = GfPINVOKE.GfRay_Intersect__SWIG_16(swigCPtr, GfVec3d.getCPtr(center), radius);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersect(GfVec3d origin, GfVec3d axis, double radius, out double enterDistance, out double exitDistance)
		{
			bool result = GfPINVOKE.GfRay_Intersect__SWIG_17(swigCPtr, GfVec3d.getCPtr(origin), GfVec3d.getCPtr(axis), radius, out enterDistance, out exitDistance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersect(GfVec3d origin, GfVec3d axis, double radius, out double enterDistance)
		{
			bool result = GfPINVOKE.GfRay_Intersect__SWIG_18(swigCPtr, GfVec3d.getCPtr(origin), GfVec3d.getCPtr(axis), radius, out enterDistance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersect(GfVec3d origin, GfVec3d axis, double radius)
		{
			bool result = GfPINVOKE.GfRay_Intersect__SWIG_19(swigCPtr, GfVec3d.getCPtr(origin), GfVec3d.getCPtr(axis), radius);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersect(GfVec3d origin, GfVec3d axis, double radius, double height, out double enterDistance, out double exitDistance)
		{
			bool result = GfPINVOKE.GfRay_Intersect__SWIG_20(swigCPtr, GfVec3d.getCPtr(origin), GfVec3d.getCPtr(axis), radius, height, out enterDistance, out exitDistance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersect(GfVec3d origin, GfVec3d axis, double radius, double height, out double enterDistance)
		{
			bool result = GfPINVOKE.GfRay_Intersect__SWIG_21(swigCPtr, GfVec3d.getCPtr(origin), GfVec3d.getCPtr(axis), radius, height, out enterDistance);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersect(GfVec3d origin, GfVec3d axis, double radius, double height)
		{
			bool result = GfPINVOKE.GfRay_Intersect__SWIG_22(swigCPtr, GfVec3d.getCPtr(origin), GfVec3d.getCPtr(axis), radius, height);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool Equals(GfRay lhs, GfRay rhs)
		{
			bool result = GfPINVOKE.GfRay_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfRay lhs, GfRay rhs)
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

		public static bool operator !=(GfRay lhs, GfRay rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfRay);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfRay_GetHashCode(swigCPtr);
		}
	}
}
