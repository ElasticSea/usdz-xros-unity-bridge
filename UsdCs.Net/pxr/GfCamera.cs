using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfCamera : IDisposable
	{
		public enum Projection
		{
			Perspective,
			Orthographic
		}

		public enum FOVDirection
		{
			FOVHorizontal,
			FOVVertical
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public static double APERTURE_UNIT => GfPINVOKE.GfCamera_APERTURE_UNIT_get();

		public static double FOCAL_LENGTH_UNIT => GfPINVOKE.GfCamera_FOCAL_LENGTH_UNIT_get();

		public static double DEFAULT_HORIZONTAL_APERTURE => GfPINVOKE.GfCamera_DEFAULT_HORIZONTAL_APERTURE_get();

		public static double DEFAULT_VERTICAL_APERTURE => GfPINVOKE.GfCamera_DEFAULT_VERTICAL_APERTURE_get();

		public GfCamera(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfCamera obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfCamera obj)
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

		~GfCamera()
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
						GfPINVOKE.delete_GfCamera(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfCamera(GfMatrix4d transform, Projection projection, float horizontalAperture, float verticalAperture, float horizontalApertureOffset, float verticalApertureOffset, float focalLength, GfRange1f clippingRange, GfVec4fVector clippingPlanes, float fStop, float focusDistance)
			: this(GfPINVOKE.new_GfCamera__SWIG_0(GfMatrix4d.getCPtr(transform), (int)projection, horizontalAperture, verticalAperture, horizontalApertureOffset, verticalApertureOffset, focalLength, GfRange1f.getCPtr(clippingRange), GfVec4fVector.getCPtr(clippingPlanes), fStop, focusDistance), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfCamera(GfMatrix4d transform, Projection projection, float horizontalAperture, float verticalAperture, float horizontalApertureOffset, float verticalApertureOffset, float focalLength, GfRange1f clippingRange, GfVec4fVector clippingPlanes, float fStop)
			: this(GfPINVOKE.new_GfCamera__SWIG_1(GfMatrix4d.getCPtr(transform), (int)projection, horizontalAperture, verticalAperture, horizontalApertureOffset, verticalApertureOffset, focalLength, GfRange1f.getCPtr(clippingRange), GfVec4fVector.getCPtr(clippingPlanes), fStop), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfCamera(GfMatrix4d transform, Projection projection, float horizontalAperture, float verticalAperture, float horizontalApertureOffset, float verticalApertureOffset, float focalLength, GfRange1f clippingRange, GfVec4fVector clippingPlanes)
			: this(GfPINVOKE.new_GfCamera__SWIG_2(GfMatrix4d.getCPtr(transform), (int)projection, horizontalAperture, verticalAperture, horizontalApertureOffset, verticalApertureOffset, focalLength, GfRange1f.getCPtr(clippingRange), GfVec4fVector.getCPtr(clippingPlanes)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfCamera(GfMatrix4d transform, Projection projection, float horizontalAperture, float verticalAperture, float horizontalApertureOffset, float verticalApertureOffset, float focalLength, GfRange1f clippingRange)
			: this(GfPINVOKE.new_GfCamera__SWIG_3(GfMatrix4d.getCPtr(transform), (int)projection, horizontalAperture, verticalAperture, horizontalApertureOffset, verticalApertureOffset, focalLength, GfRange1f.getCPtr(clippingRange)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfCamera(GfMatrix4d transform, Projection projection, float horizontalAperture, float verticalAperture, float horizontalApertureOffset, float verticalApertureOffset, float focalLength)
			: this(GfPINVOKE.new_GfCamera__SWIG_4(GfMatrix4d.getCPtr(transform), (int)projection, horizontalAperture, verticalAperture, horizontalApertureOffset, verticalApertureOffset, focalLength), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfCamera(GfMatrix4d transform, Projection projection, float horizontalAperture, float verticalAperture, float horizontalApertureOffset, float verticalApertureOffset)
			: this(GfPINVOKE.new_GfCamera__SWIG_5(GfMatrix4d.getCPtr(transform), (int)projection, horizontalAperture, verticalAperture, horizontalApertureOffset, verticalApertureOffset), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfCamera(GfMatrix4d transform, Projection projection, float horizontalAperture, float verticalAperture, float horizontalApertureOffset)
			: this(GfPINVOKE.new_GfCamera__SWIG_6(GfMatrix4d.getCPtr(transform), (int)projection, horizontalAperture, verticalAperture, horizontalApertureOffset), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfCamera(GfMatrix4d transform, Projection projection, float horizontalAperture, float verticalAperture)
			: this(GfPINVOKE.new_GfCamera__SWIG_7(GfMatrix4d.getCPtr(transform), (int)projection, horizontalAperture, verticalAperture), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfCamera(GfMatrix4d transform, Projection projection, float horizontalAperture)
			: this(GfPINVOKE.new_GfCamera__SWIG_8(GfMatrix4d.getCPtr(transform), (int)projection, horizontalAperture), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfCamera(GfMatrix4d transform, Projection projection)
			: this(GfPINVOKE.new_GfCamera__SWIG_9(GfMatrix4d.getCPtr(transform), (int)projection), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfCamera(GfMatrix4d transform)
			: this(GfPINVOKE.new_GfCamera__SWIG_10(GfMatrix4d.getCPtr(transform)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfCamera()
			: this(GfPINVOKE.new_GfCamera__SWIG_11(), cMemoryOwn: true)
		{
		}

		public void SetTransform(GfMatrix4d val)
		{
			GfPINVOKE.GfCamera_SetTransform(swigCPtr, GfMatrix4d.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetProjection(Projection val)
		{
			GfPINVOKE.GfCamera_SetProjection(swigCPtr, (int)val);
		}

		public void SetFocalLength(float val)
		{
			GfPINVOKE.GfCamera_SetFocalLength(swigCPtr, val);
		}

		public void SetHorizontalAperture(float val)
		{
			GfPINVOKE.GfCamera_SetHorizontalAperture(swigCPtr, val);
		}

		public void SetVerticalAperture(float val)
		{
			GfPINVOKE.GfCamera_SetVerticalAperture(swigCPtr, val);
		}

		public void SetHorizontalApertureOffset(float val)
		{
			GfPINVOKE.GfCamera_SetHorizontalApertureOffset(swigCPtr, val);
		}

		public void SetVerticalApertureOffset(float val)
		{
			GfPINVOKE.GfCamera_SetVerticalApertureOffset(swigCPtr, val);
		}

		public void SetPerspectiveFromAspectRatioAndFieldOfView(float aspectRatio, float fieldOfView, FOVDirection direction, float horizontalAperture)
		{
			GfPINVOKE.GfCamera_SetPerspectiveFromAspectRatioAndFieldOfView__SWIG_0(swigCPtr, aspectRatio, fieldOfView, (int)direction, horizontalAperture);
		}

		public void SetPerspectiveFromAspectRatioAndFieldOfView(float aspectRatio, float fieldOfView, FOVDirection direction)
		{
			GfPINVOKE.GfCamera_SetPerspectiveFromAspectRatioAndFieldOfView__SWIG_1(swigCPtr, aspectRatio, fieldOfView, (int)direction);
		}

		public void SetOrthographicFromAspectRatioAndSize(float aspectRatio, float orthographicSize, FOVDirection direction)
		{
			GfPINVOKE.GfCamera_SetOrthographicFromAspectRatioAndSize(swigCPtr, aspectRatio, orthographicSize, (int)direction);
		}

		public void SetFromViewAndProjectionMatrix(GfMatrix4d viewMatrix, GfMatrix4d projMatix, float focalLength)
		{
			GfPINVOKE.GfCamera_SetFromViewAndProjectionMatrix__SWIG_0(swigCPtr, GfMatrix4d.getCPtr(viewMatrix), GfMatrix4d.getCPtr(projMatix), focalLength);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetFromViewAndProjectionMatrix(GfMatrix4d viewMatrix, GfMatrix4d projMatix)
		{
			GfPINVOKE.GfCamera_SetFromViewAndProjectionMatrix__SWIG_1(swigCPtr, GfMatrix4d.getCPtr(viewMatrix), GfMatrix4d.getCPtr(projMatix));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetClippingRange(GfRange1f val)
		{
			GfPINVOKE.GfCamera_SetClippingRange(swigCPtr, GfRange1f.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetClippingPlanes(GfVec4fVector val)
		{
			GfPINVOKE.GfCamera_SetClippingPlanes(swigCPtr, GfVec4fVector.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetFStop(float val)
		{
			GfPINVOKE.GfCamera_SetFStop(swigCPtr, val);
		}

		public void SetFocusDistance(float val)
		{
			GfPINVOKE.GfCamera_SetFocusDistance(swigCPtr, val);
		}

		public GfMatrix4d GetTransform()
		{
			return new GfMatrix4d(GfPINVOKE.GfCamera_GetTransform(swigCPtr), cMemoryOwn: true);
		}

		public Projection GetProjection()
		{
			return (Projection)GfPINVOKE.GfCamera_GetProjection(swigCPtr);
		}

		public float GetHorizontalAperture()
		{
			return GfPINVOKE.GfCamera_GetHorizontalAperture(swigCPtr);
		}

		public float GetVerticalAperture()
		{
			return GfPINVOKE.GfCamera_GetVerticalAperture(swigCPtr);
		}

		public float GetHorizontalApertureOffset()
		{
			return GfPINVOKE.GfCamera_GetHorizontalApertureOffset(swigCPtr);
		}

		public float GetVerticalApertureOffset()
		{
			return GfPINVOKE.GfCamera_GetVerticalApertureOffset(swigCPtr);
		}

		public float GetAspectRatio()
		{
			return GfPINVOKE.GfCamera_GetAspectRatio(swigCPtr);
		}

		public float GetFocalLength()
		{
			return GfPINVOKE.GfCamera_GetFocalLength(swigCPtr);
		}

		public float GetFieldOfView(FOVDirection direction)
		{
			return GfPINVOKE.GfCamera_GetFieldOfView(swigCPtr, (int)direction);
		}

		public GfRange1f GetClippingRange()
		{
			return new GfRange1f(GfPINVOKE.GfCamera_GetClippingRange(swigCPtr), cMemoryOwn: true);
		}

		public GfVec4fVector GetClippingPlanes()
		{
			return new GfVec4fVector(GfPINVOKE.GfCamera_GetClippingPlanes(swigCPtr), cMemoryOwn: false);
		}

		public GfFrustum GetFrustum()
		{
			return new GfFrustum(GfPINVOKE.GfCamera_GetFrustum(swigCPtr), cMemoryOwn: true);
		}

		public float GetFStop()
		{
			return GfPINVOKE.GfCamera_GetFStop(swigCPtr);
		}

		public float GetFocusDistance()
		{
			return GfPINVOKE.GfCamera_GetFocusDistance(swigCPtr);
		}

		public static bool Equals(GfCamera lhs, GfCamera rhs)
		{
			bool result = GfPINVOKE.GfCamera_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(GfCamera lhs, GfCamera rhs)
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

		public static bool operator !=(GfCamera lhs, GfCamera rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as GfCamera);
		}

		public override int GetHashCode()
		{
			return GfPINVOKE.GfCamera_GetHashCode(swigCPtr);
		}
	}
}
