using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdLuxGeometryLight : UsdLuxNonboundableLightBase
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdLuxGeometryLight(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdLuxPINVOKE.UsdLuxGeometryLight_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdLuxGeometryLight obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdLuxGeometryLight obj)
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
						UsdLuxPINVOKE.delete_UsdLuxGeometryLight(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdLuxGeometryLight(UsdPrim prim)
			: this(UsdLuxPINVOKE.new_UsdLuxGeometryLight__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdLuxGeometryLight()
			: this(UsdLuxPINVOKE.new_UsdLuxGeometryLight__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdLuxGeometryLight(UsdSchemaBase schemaObj)
			: this(UsdLuxPINVOKE.new_UsdLuxGeometryLight__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdLuxPINVOKE.UsdLuxGeometryLight_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdLuxPINVOKE.UsdLuxGeometryLight_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdLuxGeometryLight Get(UsdStage stage, SdfPath path)
		{
			UsdLuxGeometryLight result = new UsdLuxGeometryLight(UsdLuxPINVOKE.UsdLuxGeometryLight_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdLuxGeometryLight Define(UsdStage stage, SdfPath path)
		{
			UsdLuxGeometryLight result = new UsdLuxGeometryLight(UsdLuxPINVOKE.UsdLuxGeometryLight_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdRelationship GetGeometryRel()
		{
			return new UsdRelationship(UsdLuxPINVOKE.UsdLuxGeometryLight_GetGeometryRel(swigCPtr), cMemoryOwn: true);
		}

		public UsdRelationship CreateGeometryRel()
		{
			return new UsdRelationship(UsdLuxPINVOKE.UsdLuxGeometryLight_CreateGeometryRel(swigCPtr), cMemoryOwn: true);
		}
	}
}
