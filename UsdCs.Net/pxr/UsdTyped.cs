using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdTyped : UsdSchemaBase
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.AbstractBase;

		public UsdTyped(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdPINVOKE.UsdTyped_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdTyped obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdTyped obj)
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
						UsdPINVOKE.delete_UsdTyped(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdTyped(UsdPrim prim)
			: this(UsdPINVOKE.new_UsdTyped__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdTyped()
			: this(UsdPINVOKE.new_UsdTyped__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdTyped(UsdSchemaBase schemaObj)
			: this(UsdPINVOKE.new_UsdTyped__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdPINVOKE.UsdTyped_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdPINVOKE.UsdTyped_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public static UsdTyped Get(UsdStage stage, SdfPath path)
		{
			UsdTyped result = new UsdTyped(UsdPINVOKE.UsdTyped_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
