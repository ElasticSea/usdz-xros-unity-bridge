using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdRiSplineAPI : UsdAPISchemaBase
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.SingleApplyAPI;

		public UsdRiSplineAPI(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdRiPINVOKE.UsdRiSplineAPI_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdRiSplineAPI obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdRiSplineAPI obj)
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
						UsdRiPINVOKE.delete_UsdRiSplineAPI(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdRiSplineAPI(UsdPrim prim)
			: this(UsdRiPINVOKE.new_UsdRiSplineAPI__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdRiSplineAPI()
			: this(UsdRiPINVOKE.new_UsdRiSplineAPI__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdRiSplineAPI(UsdSchemaBase schemaObj)
			: this(UsdRiPINVOKE.new_UsdRiSplineAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdRiPINVOKE.UsdRiSplineAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdRiPINVOKE.UsdRiSplineAPI_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public static bool CanApply(UsdPrim prim, out string whyNot)
		{
			bool result = UsdRiPINVOKE.UsdRiSplineAPI_CanApply__SWIG_0(UsdPrim.getCPtr(prim), out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim)
		{
			bool result = UsdRiPINVOKE.UsdRiSplineAPI_CanApply__SWIG_1(UsdPrim.getCPtr(prim));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdRiSplineAPI(UsdPrim prim, TfToken splineName, SdfValueTypeName valuesTypeName, bool doesDuplicateBSplineEndpoints)
			: this(UsdRiPINVOKE.new_UsdRiSplineAPI__SWIG_3(UsdPrim.getCPtr(prim), TfToken.getCPtr(splineName), SdfValueTypeName.getCPtr(valuesTypeName), doesDuplicateBSplineEndpoints), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdRiSplineAPI(UsdSchemaBase schemaObj, TfToken splineName, SdfValueTypeName valuesTypeName, bool doesDuplicateBSplineEndpoints)
			: this(UsdRiPINVOKE.new_UsdRiSplineAPI__SWIG_4(UsdSchemaBase.getCPtr(schemaObj), TfToken.getCPtr(splineName), SdfValueTypeName.getCPtr(valuesTypeName), doesDuplicateBSplineEndpoints), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool DoesDuplicateBSplineEndpoints()
		{
			return UsdRiPINVOKE.UsdRiSplineAPI_DoesDuplicateBSplineEndpoints(swigCPtr);
		}

		public SdfValueTypeName GetValuesTypeName()
		{
			return new SdfValueTypeName(UsdRiPINVOKE.UsdRiSplineAPI_GetValuesTypeName(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetInterpolationAttr()
		{
			return new UsdAttribute(UsdRiPINVOKE.UsdRiSplineAPI_GetInterpolationAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateInterpolationAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdRiPINVOKE.UsdRiSplineAPI_CreateInterpolationAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateInterpolationAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdRiPINVOKE.UsdRiSplineAPI_CreateInterpolationAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateInterpolationAttr()
		{
			return new UsdAttribute(UsdRiPINVOKE.UsdRiSplineAPI_CreateInterpolationAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetPositionsAttr()
		{
			return new UsdAttribute(UsdRiPINVOKE.UsdRiSplineAPI_GetPositionsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreatePositionsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdRiPINVOKE.UsdRiSplineAPI_CreatePositionsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreatePositionsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdRiPINVOKE.UsdRiSplineAPI_CreatePositionsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreatePositionsAttr()
		{
			return new UsdAttribute(UsdRiPINVOKE.UsdRiSplineAPI_CreatePositionsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetValuesAttr()
		{
			return new UsdAttribute(UsdRiPINVOKE.UsdRiSplineAPI_GetValuesAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateValuesAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdRiPINVOKE.UsdRiSplineAPI_CreateValuesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateValuesAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdRiPINVOKE.UsdRiSplineAPI_CreateValuesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateValuesAttr()
		{
			return new UsdAttribute(UsdRiPINVOKE.UsdRiSplineAPI_CreateValuesAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public bool Validate(out string reason)
		{
			bool result = UsdRiPINVOKE.UsdRiSplineAPI_Validate(swigCPtr, out reason);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
