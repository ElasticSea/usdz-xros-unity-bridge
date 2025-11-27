using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomPointBased : UsdGeomGprim
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.AbstractTyped;

		public UsdGeomPointBased(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdGeomPINVOKE.UsdGeomPointBased_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomPointBased obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomPointBased obj)
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

		protected override void Dispose(bool disposing)
		{
			lock (this)
			{
				if (swigCPtr.Handle != IntPtr.Zero)
				{
					if (swigCMemOwn)
					{
						swigCMemOwn = false;
						UsdGeomPINVOKE.delete_UsdGeomPointBased(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdGeomPointBased(UsdPrim prim)
			: this(UsdGeomPINVOKE.new_UsdGeomPointBased__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomPointBased()
			: this(UsdGeomPINVOKE.new_UsdGeomPointBased__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdGeomPointBased(UsdSchemaBase schemaObj)
			: this(UsdGeomPINVOKE.new_UsdGeomPointBased__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomPointBased_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdGeomPINVOKE.UsdGeomPointBased_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdGeomPointBased Get(UsdStage stage, SdfPath path)
		{
			UsdGeomPointBased result = new UsdGeomPointBased(UsdGeomPINVOKE.UsdGeomPointBased_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetPointsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointBased_GetPointsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreatePointsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointBased_CreatePointsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreatePointsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointBased_CreatePointsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreatePointsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointBased_CreatePointsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetVelocitiesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointBased_GetVelocitiesAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateVelocitiesAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointBased_CreateVelocitiesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVelocitiesAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointBased_CreateVelocitiesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVelocitiesAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointBased_CreateVelocitiesAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetAccelerationsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointBased_GetAccelerationsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateAccelerationsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointBased_CreateAccelerationsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateAccelerationsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointBased_CreateAccelerationsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateAccelerationsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointBased_CreateAccelerationsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetNormalsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointBased_GetNormalsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateNormalsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointBased_CreateNormalsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateNormalsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointBased_CreateNormalsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateNormalsAttr()
		{
			return new UsdAttribute(UsdGeomPINVOKE.UsdGeomPointBased_CreateNormalsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public TfToken GetNormalsInterpolation()
		{
			return new TfToken(UsdGeomPINVOKE.UsdGeomPointBased_GetNormalsInterpolation(swigCPtr), cMemoryOwn: true);
		}

		public bool SetNormalsInterpolation(TfToken interpolation)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointBased_SetNormalsInterpolation(swigCPtr, TfToken.getCPtr(interpolation));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ComputeExtent(VtVec3fArray points, VtVec3fArray extent)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointBased_ComputeExtent__SWIG_0(VtVec3fArray.getCPtr(points), VtVec3fArray.getCPtr(extent));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ComputeExtent(VtVec3fArray points, GfMatrix4d transform, VtVec3fArray extent)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointBased_ComputeExtent__SWIG_1(VtVec3fArray.getCPtr(points), GfMatrix4d.getCPtr(transform), VtVec3fArray.getCPtr(extent));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ComputePointsAtTime(VtVec3fArray points, UsdTimeCode time, UsdTimeCode baseTime)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointBased_ComputePointsAtTime__SWIG_0(swigCPtr, VtVec3fArray.getCPtr(points), UsdTimeCode.getCPtr(time), UsdTimeCode.getCPtr(baseTime));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ComputePointsAtTimes(VtVec3fArrayVector pointsArray, UsdTimeCodeVector times, UsdTimeCode baseTime)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointBased_ComputePointsAtTimes(swigCPtr, VtVec3fArrayVector.getCPtr(pointsArray), UsdTimeCodeVector.getCPtr(times), UsdTimeCode.getCPtr(baseTime));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ComputePointsAtTime(VtVec3fArray points, UsdStage stage, UsdTimeCode time, VtVec3fArray positions, VtVec3fArray velocities, UsdTimeCode velocitiesSampleTime, VtVec3fArray accelerations, float velocityScale)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointBased_ComputePointsAtTime__SWIG_1(VtVec3fArray.getCPtr(points), UsdStage.getCPtr(stage), UsdTimeCode.getCPtr(time), VtVec3fArray.getCPtr(positions), VtVec3fArray.getCPtr(velocities), UsdTimeCode.getCPtr(velocitiesSampleTime), VtVec3fArray.getCPtr(accelerations), velocityScale);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ComputePointsAtTime(VtVec3fArray points, UsdStage stage, UsdTimeCode time, VtVec3fArray positions, VtVec3fArray velocities, UsdTimeCode velocitiesSampleTime, VtVec3fArray accelerations)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointBased_ComputePointsAtTime__SWIG_2(VtVec3fArray.getCPtr(points), UsdStage.getCPtr(stage), UsdTimeCode.getCPtr(time), VtVec3fArray.getCPtr(positions), VtVec3fArray.getCPtr(velocities), UsdTimeCode.getCPtr(velocitiesSampleTime), VtVec3fArray.getCPtr(accelerations));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
