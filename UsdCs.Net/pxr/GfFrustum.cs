using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfFrustum : IDisposable
	{
		public enum ProjectionType
		{
			Orthographic,
			Perspective
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public GfFrustum(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfFrustum obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfFrustum obj)
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

		~GfFrustum()
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
						GfPINVOKE.delete_GfFrustum(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfFrustum()
			: this(GfPINVOKE.new_GfFrustum__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfFrustum(GfFrustum o)
			: this(GfPINVOKE.new_GfFrustum__SWIG_1(getCPtr(o)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfFrustum(GfVec3d position, GfRotation rotation, GfRange2d window, GfRange1d nearFar, ProjectionType projectionType, double viewDistance)
			: this(GfPINVOKE.new_GfFrustum__SWIG_3(GfVec3d.getCPtr(position), GfRotation.getCPtr(rotation), GfRange2d.getCPtr(window), GfRange1d.getCPtr(nearFar), (int)projectionType, viewDistance), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfFrustum(GfVec3d position, GfRotation rotation, GfRange2d window, GfRange1d nearFar, ProjectionType projectionType)
			: this(GfPINVOKE.new_GfFrustum__SWIG_4(GfVec3d.getCPtr(position), GfRotation.getCPtr(rotation), GfRange2d.getCPtr(window), GfRange1d.getCPtr(nearFar), (int)projectionType), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfFrustum(GfMatrix4d camToWorldXf, GfRange2d window, GfRange1d nearFar, ProjectionType projectionType, double viewDistance)
			: this(GfPINVOKE.new_GfFrustum__SWIG_5(GfMatrix4d.getCPtr(camToWorldXf), GfRange2d.getCPtr(window), GfRange1d.getCPtr(nearFar), (int)projectionType, viewDistance), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfFrustum(GfMatrix4d camToWorldXf, GfRange2d window, GfRange1d nearFar, ProjectionType projectionType)
			: this(GfPINVOKE.new_GfFrustum__SWIG_6(GfMatrix4d.getCPtr(camToWorldXf), GfRange2d.getCPtr(window), GfRange1d.getCPtr(nearFar), (int)projectionType), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetPosition(GfVec3d position)
		{
			GfPINVOKE.GfFrustum_SetPosition(swigCPtr, GfVec3d.getCPtr(position));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec3d GetPosition()
		{
			return new GfVec3d(GfPINVOKE.GfFrustum_GetPosition(swigCPtr), cMemoryOwn: false);
		}

		public void SetRotation(GfRotation rotation)
		{
			GfPINVOKE.GfFrustum_SetRotation(swigCPtr, GfRotation.getCPtr(rotation));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfRotation GetRotation()
		{
			return new GfRotation(GfPINVOKE.GfFrustum_GetRotation(swigCPtr), cMemoryOwn: false);
		}

		public void SetPositionAndRotationFromMatrix(GfMatrix4d camToWorldXf)
		{
			GfPINVOKE.GfFrustum_SetPositionAndRotationFromMatrix(swigCPtr, GfMatrix4d.getCPtr(camToWorldXf));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetWindow(GfRange2d window)
		{
			GfPINVOKE.GfFrustum_SetWindow(swigCPtr, GfRange2d.getCPtr(window));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfRange2d GetWindow()
		{
			return new GfRange2d(GfPINVOKE.GfFrustum_GetWindow(swigCPtr), cMemoryOwn: false);
		}

		public static double GetReferencePlaneDepth()
		{
			return GfPINVOKE.GfFrustum_GetReferencePlaneDepth();
		}

		public void SetNearFar(GfRange1d nearFar)
		{
			GfPINVOKE.GfFrustum_SetNearFar(swigCPtr, GfRange1d.getCPtr(nearFar));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfRange1d GetNearFar()
		{
			return new GfRange1d(GfPINVOKE.GfFrustum_GetNearFar(swigCPtr), cMemoryOwn: false);
		}

		public void SetViewDistance(double viewDistance)
		{
			GfPINVOKE.GfFrustum_SetViewDistance(swigCPtr, viewDistance);
		}

		public double GetViewDistance()
		{
			return GfPINVOKE.GfFrustum_GetViewDistance(swigCPtr);
		}

		public void SetProjectionType(ProjectionType projectionType)
		{
			GfPINVOKE.GfFrustum_SetProjectionType(swigCPtr, (int)projectionType);
		}

		public ProjectionType GetProjectionType()
		{
			return (ProjectionType)GfPINVOKE.GfFrustum_GetProjectionType(swigCPtr);
		}

		public void SetPerspective(double fieldOfViewHeight, double aspectRatio, double nearDistance, double farDistance)
		{
			GfPINVOKE.GfFrustum_SetPerspective__SWIG_0(swigCPtr, fieldOfViewHeight, aspectRatio, nearDistance, farDistance);
		}

		public void SetPerspective(double fieldOfView, bool isFovVertical, double aspectRatio, double nearDistance, double farDistance)
		{
			GfPINVOKE.GfFrustum_SetPerspective__SWIG_1(swigCPtr, fieldOfView, isFovVertical, aspectRatio, nearDistance, farDistance);
		}

		public bool GetPerspective(out double fieldOfViewHeight, out double aspectRatio, out double nearDistance, out double farDistance)
		{
			return GfPINVOKE.GfFrustum_GetPerspective__SWIG_0(swigCPtr, out fieldOfViewHeight, out aspectRatio, out nearDistance, out farDistance);
		}

		public bool GetPerspective(bool isFovVertical, out double fieldOfView, out double aspectRatio, out double nearDistance, out double farDistance)
		{
			return GfPINVOKE.GfFrustum_GetPerspective__SWIG_1(swigCPtr, isFovVertical, out fieldOfView, out aspectRatio, out nearDistance, out farDistance);
		}

		public double GetFOV(bool isFovVertical)
		{
			return GfPINVOKE.GfFrustum_GetFOV__SWIG_0(swigCPtr, isFovVertical);
		}

		public double GetFOV()
		{
			return GfPINVOKE.GfFrustum_GetFOV__SWIG_1(swigCPtr);
		}

		public void SetOrthographic(double left, double right, double bottom, double top, double nearPlane, double farPlane)
		{
			GfPINVOKE.GfFrustum_SetOrthographic(swigCPtr, left, right, bottom, top, nearPlane, farPlane);
		}

		public bool GetOrthographic(out double left, out double right, out double bottom, out double top, out double nearPlane, out double farPlane)
		{
			return GfPINVOKE.GfFrustum_GetOrthographic(swigCPtr, out left, out right, out bottom, out top, out nearPlane, out farPlane);
		}

		public void FitToSphere(GfVec3d center, double radius, double slack)
		{
			GfPINVOKE.GfFrustum_FitToSphere__SWIG_0(swigCPtr, GfVec3d.getCPtr(center), radius, slack);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void FitToSphere(GfVec3d center, double radius)
		{
			GfPINVOKE.GfFrustum_FitToSphere__SWIG_1(swigCPtr, GfVec3d.getCPtr(center), radius);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfFrustum Transform(GfMatrix4d matrix)
		{
			GfFrustum result = new GfFrustum(GfPINVOKE.GfFrustum_Transform(swigCPtr, GfMatrix4d.getCPtr(matrix)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfVec3d ComputeViewDirection()
		{
			return new GfVec3d(GfPINVOKE.GfFrustum_ComputeViewDirection(swigCPtr), cMemoryOwn: true);
		}

		public GfVec3d ComputeUpVector()
		{
			return new GfVec3d(GfPINVOKE.GfFrustum_ComputeUpVector(swigCPtr), cMemoryOwn: true);
		}

		public void ComputeViewFrame(GfVec3d side, GfVec3d up, GfVec3d view)
		{
			GfPINVOKE.GfFrustum_ComputeViewFrame(swigCPtr, GfVec3d.getCPtr(side), GfVec3d.getCPtr(up), GfVec3d.getCPtr(view));
		}

		public GfVec3d ComputeLookAtPoint()
		{
			return new GfVec3d(GfPINVOKE.GfFrustum_ComputeLookAtPoint(swigCPtr), cMemoryOwn: true);
		}

		public GfMatrix4d ComputeViewMatrix()
		{
			return new GfMatrix4d(GfPINVOKE.GfFrustum_ComputeViewMatrix(swigCPtr), cMemoryOwn: true);
		}

		public GfMatrix4d ComputeViewInverse()
		{
			return new GfMatrix4d(GfPINVOKE.GfFrustum_ComputeViewInverse(swigCPtr), cMemoryOwn: true);
		}

		public GfMatrix4d ComputeProjectionMatrix()
		{
			return new GfMatrix4d(GfPINVOKE.GfFrustum_ComputeProjectionMatrix(swigCPtr), cMemoryOwn: true);
		}

		public double ComputeAspectRatio()
		{
			return GfPINVOKE.GfFrustum_ComputeAspectRatio(swigCPtr);
		}

		public GfVec3dVector ComputeCorners()
		{
			return new GfVec3dVector(GfPINVOKE.GfFrustum_ComputeCorners(swigCPtr), cMemoryOwn: true);
		}

		public GfVec3dVector ComputeCornersAtDistance(double d)
		{
			return new GfVec3dVector(GfPINVOKE.GfFrustum_ComputeCornersAtDistance(swigCPtr, d), cMemoryOwn: true);
		}

		public GfFrustum ComputeNarrowedFrustum(GfVec2d windowPos, GfVec2d size)
		{
			GfFrustum result = new GfFrustum(GfPINVOKE.GfFrustum_ComputeNarrowedFrustum__SWIG_0(swigCPtr, GfVec2d.getCPtr(windowPos), GfVec2d.getCPtr(size)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfFrustum ComputeNarrowedFrustum(GfVec3d worldPoint, GfVec2d size)
		{
			GfFrustum result = new GfFrustum(GfPINVOKE.GfFrustum_ComputeNarrowedFrustum__SWIG_1(swigCPtr, GfVec3d.getCPtr(worldPoint), GfVec2d.getCPtr(size)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfRay ComputeRay(GfVec2d windowPos)
		{
			GfRay result = new GfRay(GfPINVOKE.GfFrustum_ComputeRay__SWIG_0(swigCPtr, GfVec2d.getCPtr(windowPos)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfRay ComputeRay(GfVec3d worldSpacePos)
		{
			GfRay result = new GfRay(GfPINVOKE.GfFrustum_ComputeRay__SWIG_1(swigCPtr, GfVec3d.getCPtr(worldSpacePos)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfRay ComputePickRay(GfVec2d windowPos)
		{
			GfRay result = new GfRay(GfPINVOKE.GfFrustum_ComputePickRay__SWIG_0(swigCPtr, GfVec2d.getCPtr(windowPos)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public GfRay ComputePickRay(GfVec3d worldSpacePos)
		{
			GfRay result = new GfRay(GfPINVOKE.GfFrustum_ComputePickRay__SWIG_1(swigCPtr, GfVec3d.getCPtr(worldSpacePos)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersects(GfBBox3d bbox)
		{
			bool result = GfPINVOKE.GfFrustum_Intersects__SWIG_0(swigCPtr, GfBBox3d.getCPtr(bbox));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersects(GfVec3d point)
		{
			bool result = GfPINVOKE.GfFrustum_Intersects__SWIG_1(swigCPtr, GfVec3d.getCPtr(point));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersects(GfVec3d p0, GfVec3d p1)
		{
			bool result = GfPINVOKE.GfFrustum_Intersects__SWIG_2(swigCPtr, GfVec3d.getCPtr(p0), GfVec3d.getCPtr(p1));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Intersects(GfVec3d p0, GfVec3d p1, GfVec3d p2)
		{
			bool result = GfPINVOKE.GfFrustum_Intersects__SWIG_3(swigCPtr, GfVec3d.getCPtr(p0), GfVec3d.getCPtr(p1), GfVec3d.getCPtr(p2));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IntersectsViewVolume(GfBBox3d bbox, GfMatrix4d vpMat)
		{
			bool result = GfPINVOKE.GfFrustum_IntersectsViewVolume(GfBBox3d.getCPtr(bbox), GfMatrix4d.getCPtr(vpMat));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool Equals(GfFrustum lhs, GfFrustum rhs)
		{
			bool result = GfPINVOKE.GfFrustum_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfFrustum lhs, GfFrustum rhs)
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

		public static bool operator !=(GfFrustum lhs, GfFrustum rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfFrustum);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfFrustum_GetHashCode(swigCPtr);
		}
	}
}
