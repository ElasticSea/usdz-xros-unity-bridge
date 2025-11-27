using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdVolOpenVDBAsset : UsdVolFieldAsset
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdVolOpenVDBAsset(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdVolPINVOKE.UsdVolOpenVDBAsset_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdVolOpenVDBAsset obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdVolOpenVDBAsset obj)
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
						UsdVolPINVOKE.delete_UsdVolOpenVDBAsset(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdVolOpenVDBAsset(UsdPrim prim)
			: this(UsdVolPINVOKE.new_UsdVolOpenVDBAsset__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdVolOpenVDBAsset()
			: this(UsdVolPINVOKE.new_UsdVolOpenVDBAsset__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdVolOpenVDBAsset(UsdSchemaBase schemaObj)
			: this(UsdVolPINVOKE.new_UsdVolOpenVDBAsset__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdVolPINVOKE.UsdVolOpenVDBAsset_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdVolPINVOKE.UsdVolOpenVDBAsset_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdVolOpenVDBAsset Get(UsdStage stage, SdfPath path)
		{
			UsdVolOpenVDBAsset result = new UsdVolOpenVDBAsset(UsdVolPINVOKE.UsdVolOpenVDBAsset_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdVolOpenVDBAsset Define(UsdStage stage, SdfPath path)
		{
			UsdVolOpenVDBAsset result = new UsdVolOpenVDBAsset(UsdVolPINVOKE.UsdVolOpenVDBAsset_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public new UsdAttribute GetFieldDataTypeAttr()
		{
			return new UsdAttribute(UsdVolPINVOKE.UsdVolOpenVDBAsset_GetFieldDataTypeAttr(swigCPtr), cMemoryOwn: true);
		}

		public new UsdAttribute CreateFieldDataTypeAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdVolPINVOKE.UsdVolOpenVDBAsset_CreateFieldDataTypeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public new UsdAttribute CreateFieldDataTypeAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdVolPINVOKE.UsdVolOpenVDBAsset_CreateFieldDataTypeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public new UsdAttribute CreateFieldDataTypeAttr()
		{
			return new UsdAttribute(UsdVolPINVOKE.UsdVolOpenVDBAsset_CreateFieldDataTypeAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetFieldClassAttr()
		{
			return new UsdAttribute(UsdVolPINVOKE.UsdVolOpenVDBAsset_GetFieldClassAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateFieldClassAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdVolPINVOKE.UsdVolOpenVDBAsset_CreateFieldClassAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateFieldClassAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdVolPINVOKE.UsdVolOpenVDBAsset_CreateFieldClassAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateFieldClassAttr()
		{
			return new UsdAttribute(UsdVolPINVOKE.UsdVolOpenVDBAsset_CreateFieldClassAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}
	}
}
