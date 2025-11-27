using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdLuxPluginLightFilter : UsdLuxLightFilter
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdLuxPluginLightFilter(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdLuxPINVOKE.UsdLuxPluginLightFilter_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdLuxPluginLightFilter obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdLuxPluginLightFilter obj)
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
						UsdLuxPINVOKE.delete_UsdLuxPluginLightFilter(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdLuxPluginLightFilter(UsdPrim prim)
			: this(UsdLuxPINVOKE.new_UsdLuxPluginLightFilter__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdLuxPluginLightFilter()
			: this(UsdLuxPINVOKE.new_UsdLuxPluginLightFilter__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdLuxPluginLightFilter(UsdSchemaBase schemaObj)
			: this(UsdLuxPINVOKE.new_UsdLuxPluginLightFilter__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdLuxPINVOKE.UsdLuxPluginLightFilter_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdLuxPINVOKE.UsdLuxPluginLightFilter_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdLuxPluginLightFilter Get(UsdStage stage, SdfPath path)
		{
			UsdLuxPluginLightFilter result = new UsdLuxPluginLightFilter(UsdLuxPINVOKE.UsdLuxPluginLightFilter_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public new static UsdLuxPluginLightFilter Define(UsdStage stage, SdfPath path)
		{
			UsdLuxPluginLightFilter result = new UsdLuxPluginLightFilter(UsdLuxPINVOKE.UsdLuxPluginLightFilter_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeNodeDefAPI GetNodeDefAPI()
		{
			return new UsdShadeNodeDefAPI(UsdLuxPINVOKE.UsdLuxPluginLightFilter_GetNodeDefAPI(swigCPtr), cMemoryOwn: true);
		}
	}
}
