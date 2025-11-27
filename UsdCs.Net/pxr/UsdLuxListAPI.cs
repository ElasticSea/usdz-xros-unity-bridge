using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdLuxListAPI : UsdAPISchemaBase
	{
		public enum ComputeMode
		{
			ComputeModeConsultModelHierarchyCache,
			ComputeModeIgnoreCache
		}

		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.SingleApplyAPI;

		public UsdLuxListAPI(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdLuxPINVOKE.UsdLuxListAPI_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdLuxListAPI obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdLuxListAPI obj)
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
						UsdLuxPINVOKE.delete_UsdLuxListAPI(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdLuxListAPI(UsdPrim prim)
			: this(UsdLuxPINVOKE.new_UsdLuxListAPI__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdLuxListAPI()
			: this(UsdLuxPINVOKE.new_UsdLuxListAPI__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdLuxListAPI(UsdSchemaBase schemaObj)
			: this(UsdLuxPINVOKE.new_UsdLuxListAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdLuxPINVOKE.UsdLuxListAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdLuxPINVOKE.UsdLuxListAPI_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public static UsdLuxListAPI Get(UsdStage stage, SdfPath path)
		{
			UsdLuxListAPI result = new UsdLuxListAPI(UsdLuxPINVOKE.UsdLuxListAPI_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim, out string whyNot)
		{
			bool result = UsdLuxPINVOKE.UsdLuxListAPI_CanApply__SWIG_0(UsdPrim.getCPtr(prim), out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim)
		{
			bool result = UsdLuxPINVOKE.UsdLuxListAPI_CanApply__SWIG_1(UsdPrim.getCPtr(prim));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdLuxListAPI Apply(UsdPrim prim)
		{
			UsdLuxListAPI result = new UsdLuxListAPI(UsdLuxPINVOKE.UsdLuxListAPI_Apply(UsdPrim.getCPtr(prim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetLightListCacheBehaviorAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxListAPI_GetLightListCacheBehaviorAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateLightListCacheBehaviorAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxListAPI_CreateLightListCacheBehaviorAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateLightListCacheBehaviorAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdLuxPINVOKE.UsdLuxListAPI_CreateLightListCacheBehaviorAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateLightListCacheBehaviorAttr()
		{
			return new UsdAttribute(UsdLuxPINVOKE.UsdLuxListAPI_CreateLightListCacheBehaviorAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdRelationship GetLightListRel()
		{
			return new UsdRelationship(UsdLuxPINVOKE.UsdLuxListAPI_GetLightListRel(swigCPtr), cMemoryOwn: true);
		}

		public UsdRelationship CreateLightListRel()
		{
			return new UsdRelationship(UsdLuxPINVOKE.UsdLuxListAPI_CreateLightListRel(swigCPtr), cMemoryOwn: true);
		}

		public SdfPathSet ComputeLightList(ComputeMode mode)
		{
			return new SdfPathSet(UsdLuxPINVOKE.UsdLuxListAPI_ComputeLightList(swigCPtr, (int)mode), cMemoryOwn: true);
		}

		public void StoreLightList(SdfPathSet arg0)
		{
			UsdLuxPINVOKE.UsdLuxListAPI_StoreLightList(swigCPtr, SdfPathSet.getCPtr(arg0));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InvalidateLightList()
		{
			UsdLuxPINVOKE.UsdLuxListAPI_InvalidateLightList(swigCPtr);
		}
	}
}
