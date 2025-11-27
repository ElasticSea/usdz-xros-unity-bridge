using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdAPISchemaBase : UsdSchemaBase
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.AbstractBase;

		public UsdAPISchemaBase(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdPINVOKE.UsdAPISchemaBase_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdAPISchemaBase obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdAPISchemaBase obj)
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
						UsdPINVOKE.delete_UsdAPISchemaBase(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdPINVOKE.UsdAPISchemaBase_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdPINVOKE.UsdAPISchemaBase_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}
	}
}
