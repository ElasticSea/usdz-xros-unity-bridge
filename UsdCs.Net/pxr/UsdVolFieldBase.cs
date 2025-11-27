using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdVolFieldBase : UsdGeomXformable
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.AbstractTyped;

		public UsdVolFieldBase(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdVolPINVOKE.UsdVolFieldBase_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdVolFieldBase obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdVolFieldBase obj)
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
						UsdVolPINVOKE.delete_UsdVolFieldBase(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdVolFieldBase(UsdPrim prim)
			: this(UsdVolPINVOKE.new_UsdVolFieldBase__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdVolFieldBase()
			: this(UsdVolPINVOKE.new_UsdVolFieldBase__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdVolFieldBase(UsdSchemaBase schemaObj)
			: this(UsdVolPINVOKE.new_UsdVolFieldBase__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdVolPINVOKE.UsdVolFieldBase_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdVolPINVOKE.UsdVolFieldBase_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdVolFieldBase Get(UsdStage stage, SdfPath path)
		{
			UsdVolFieldBase result = new UsdVolFieldBase(UsdVolPINVOKE.UsdVolFieldBase_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
