using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdVolFieldAsset : UsdVolFieldBase
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.AbstractTyped;

		public UsdVolFieldAsset(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdVolPINVOKE.UsdVolFieldAsset_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdVolFieldAsset obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdVolFieldAsset obj)
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
						UsdVolPINVOKE.delete_UsdVolFieldAsset(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdVolFieldAsset(UsdPrim prim)
			: this(UsdVolPINVOKE.new_UsdVolFieldAsset__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdVolFieldAsset()
			: this(UsdVolPINVOKE.new_UsdVolFieldAsset__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdVolFieldAsset(UsdSchemaBase schemaObj)
			: this(UsdVolPINVOKE.new_UsdVolFieldAsset__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdVolPINVOKE.UsdVolFieldAsset_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdVolPINVOKE.UsdVolFieldAsset_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdVolFieldAsset Get(UsdStage stage, SdfPath path)
		{
			UsdVolFieldAsset result = new UsdVolFieldAsset(UsdVolPINVOKE.UsdVolFieldAsset_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetFilePathAttr()
		{
			return new UsdAttribute(UsdVolPINVOKE.UsdVolFieldAsset_GetFilePathAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateFilePathAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdVolPINVOKE.UsdVolFieldAsset_CreateFilePathAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateFilePathAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdVolPINVOKE.UsdVolFieldAsset_CreateFilePathAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateFilePathAttr()
		{
			return new UsdAttribute(UsdVolPINVOKE.UsdVolFieldAsset_CreateFilePathAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetFieldNameAttr()
		{
			return new UsdAttribute(UsdVolPINVOKE.UsdVolFieldAsset_GetFieldNameAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateFieldNameAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdVolPINVOKE.UsdVolFieldAsset_CreateFieldNameAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateFieldNameAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdVolPINVOKE.UsdVolFieldAsset_CreateFieldNameAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateFieldNameAttr()
		{
			return new UsdAttribute(UsdVolPINVOKE.UsdVolFieldAsset_CreateFieldNameAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetFieldIndexAttr()
		{
			return new UsdAttribute(UsdVolPINVOKE.UsdVolFieldAsset_GetFieldIndexAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateFieldIndexAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdVolPINVOKE.UsdVolFieldAsset_CreateFieldIndexAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateFieldIndexAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdVolPINVOKE.UsdVolFieldAsset_CreateFieldIndexAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateFieldIndexAttr()
		{
			return new UsdAttribute(UsdVolPINVOKE.UsdVolFieldAsset_CreateFieldIndexAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetFieldDataTypeAttr()
		{
			return new UsdAttribute(UsdVolPINVOKE.UsdVolFieldAsset_GetFieldDataTypeAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateFieldDataTypeAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdVolPINVOKE.UsdVolFieldAsset_CreateFieldDataTypeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateFieldDataTypeAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdVolPINVOKE.UsdVolFieldAsset_CreateFieldDataTypeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateFieldDataTypeAttr()
		{
			return new UsdAttribute(UsdVolPINVOKE.UsdVolFieldAsset_CreateFieldDataTypeAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetVectorDataRoleHintAttr()
		{
			return new UsdAttribute(UsdVolPINVOKE.UsdVolFieldAsset_GetVectorDataRoleHintAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateVectorDataRoleHintAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdVolPINVOKE.UsdVolFieldAsset_CreateVectorDataRoleHintAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVectorDataRoleHintAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdVolPINVOKE.UsdVolFieldAsset_CreateVectorDataRoleHintAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVectorDataRoleHintAttr()
		{
			return new UsdAttribute(UsdVolPINVOKE.UsdVolFieldAsset_CreateVectorDataRoleHintAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}
	}
}
