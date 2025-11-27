using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdSkelBlendShape : UsdTyped
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdSkelBlendShape(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdSkelPINVOKE.UsdSkelBlendShape_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdSkelBlendShape obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdSkelBlendShape obj)
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
						UsdSkelPINVOKE.delete_UsdSkelBlendShape(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdSkelBlendShape(UsdPrim prim)
			: this(UsdSkelPINVOKE.new_UsdSkelBlendShape__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdSkelBlendShape()
			: this(UsdSkelPINVOKE.new_UsdSkelBlendShape__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdSkelBlendShape(UsdSchemaBase schemaObj)
			: this(UsdSkelPINVOKE.new_UsdSkelBlendShape__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdSkelPINVOKE.UsdSkelBlendShape_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdSkelPINVOKE.UsdSkelBlendShape_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdSkelBlendShape Get(UsdStage stage, SdfPath path)
		{
			UsdSkelBlendShape result = new UsdSkelBlendShape(UsdSkelPINVOKE.UsdSkelBlendShape_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdSkelBlendShape Define(UsdStage stage, SdfPath path)
		{
			UsdSkelBlendShape result = new UsdSkelBlendShape(UsdSkelPINVOKE.UsdSkelBlendShape_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetOffsetsAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelBlendShape_GetOffsetsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateOffsetsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelBlendShape_CreateOffsetsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateOffsetsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelBlendShape_CreateOffsetsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateOffsetsAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelBlendShape_CreateOffsetsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetNormalOffsetsAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelBlendShape_GetNormalOffsetsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateNormalOffsetsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelBlendShape_CreateNormalOffsetsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateNormalOffsetsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelBlendShape_CreateNormalOffsetsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateNormalOffsetsAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelBlendShape_CreateNormalOffsetsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetPointIndicesAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelBlendShape_GetPointIndicesAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreatePointIndicesAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelBlendShape_CreatePointIndicesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreatePointIndicesAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelBlendShape_CreatePointIndicesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreatePointIndicesAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelBlendShape_CreatePointIndicesAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdSkelInbetweenShape CreateInbetween(TfToken name)
		{
			UsdSkelInbetweenShape result = new UsdSkelInbetweenShape(UsdSkelPINVOKE.UsdSkelBlendShape_CreateInbetween(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdSkelInbetweenShape GetInbetween(TfToken name)
		{
			UsdSkelInbetweenShape result = new UsdSkelInbetweenShape(UsdSkelPINVOKE.UsdSkelBlendShape_GetInbetween(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasInbetween(TfToken name)
		{
			bool result = UsdSkelPINVOKE.UsdSkelBlendShape_HasInbetween(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdSkelInbetweenShapeVector GetInbetweens()
		{
			return new UsdSkelInbetweenShapeVector(UsdSkelPINVOKE.UsdSkelBlendShape_GetInbetweens(swigCPtr), cMemoryOwn: true);
		}

		public UsdSkelInbetweenShapeVector GetAuthoredInbetweens()
		{
			return new UsdSkelInbetweenShapeVector(UsdSkelPINVOKE.UsdSkelBlendShape_GetAuthoredInbetweens(swigCPtr), cMemoryOwn: true);
		}

		public static bool ValidatePointIndices(SWIGTYPE_p_TfSpanT_int_const_t indices, uint numPoints, out string reason)
		{
			bool result = UsdSkelPINVOKE.UsdSkelBlendShape_ValidatePointIndices__SWIG_0(SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(indices), numPoints, out reason);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool ValidatePointIndices(SWIGTYPE_p_TfSpanT_int_const_t indices, uint numPoints)
		{
			bool result = UsdSkelPINVOKE.UsdSkelBlendShape_ValidatePointIndices__SWIG_1(SWIGTYPE_p_TfSpanT_int_const_t.getCPtr(indices), numPoints);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
