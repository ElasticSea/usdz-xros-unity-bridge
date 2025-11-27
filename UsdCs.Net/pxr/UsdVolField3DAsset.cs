using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdVolField3DAsset : UsdVolFieldAsset
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdVolField3DAsset(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdVolPINVOKE.UsdVolField3DAsset_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdVolField3DAsset obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdVolField3DAsset obj)
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
						UsdVolPINVOKE.delete_UsdVolField3DAsset(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdVolField3DAsset(UsdPrim prim)
			: this(UsdVolPINVOKE.new_UsdVolField3DAsset__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdVolField3DAsset()
			: this(UsdVolPINVOKE.new_UsdVolField3DAsset__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdVolField3DAsset(UsdSchemaBase schemaObj)
			: this(UsdVolPINVOKE.new_UsdVolField3DAsset__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdVolPINVOKE.UsdVolField3DAsset_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdVolPINVOKE.UsdVolField3DAsset_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdVolField3DAsset Get(UsdStage stage, SdfPath path)
		{
			UsdVolField3DAsset result = new UsdVolField3DAsset(UsdVolPINVOKE.UsdVolField3DAsset_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdVolField3DAsset Define(UsdStage stage, SdfPath path)
		{
			UsdVolField3DAsset result = new UsdVolField3DAsset(UsdVolPINVOKE.UsdVolField3DAsset_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public new UsdAttribute GetFieldDataTypeAttr()
		{
			return new UsdAttribute(UsdVolPINVOKE.UsdVolField3DAsset_GetFieldDataTypeAttr(swigCPtr), cMemoryOwn: true);
		}

		public new UsdAttribute CreateFieldDataTypeAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdVolPINVOKE.UsdVolField3DAsset_CreateFieldDataTypeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public new UsdAttribute CreateFieldDataTypeAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdVolPINVOKE.UsdVolField3DAsset_CreateFieldDataTypeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public new UsdAttribute CreateFieldDataTypeAttr()
		{
			return new UsdAttribute(UsdVolPINVOKE.UsdVolField3DAsset_CreateFieldDataTypeAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetFieldPurposeAttr()
		{
			return new UsdAttribute(UsdVolPINVOKE.UsdVolField3DAsset_GetFieldPurposeAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateFieldPurposeAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdVolPINVOKE.UsdVolField3DAsset_CreateFieldPurposeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateFieldPurposeAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdVolPINVOKE.UsdVolField3DAsset_CreateFieldPurposeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateFieldPurposeAttr()
		{
			return new UsdAttribute(UsdVolPINVOKE.UsdVolField3DAsset_CreateFieldPurposeAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}
	}
}
