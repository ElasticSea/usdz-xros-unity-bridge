using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdSkelAnimation : UsdTyped
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdSkelAnimation(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdSkelPINVOKE.UsdSkelAnimation_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdSkelAnimation obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdSkelAnimation obj)
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
						UsdSkelPINVOKE.delete_UsdSkelAnimation(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdSkelAnimation(UsdPrim prim)
			: this(UsdSkelPINVOKE.new_UsdSkelAnimation__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdSkelAnimation()
			: this(UsdSkelPINVOKE.new_UsdSkelAnimation__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdSkelAnimation(UsdSchemaBase schemaObj)
			: this(UsdSkelPINVOKE.new_UsdSkelAnimation__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdSkelPINVOKE.UsdSkelAnimation_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdSkelPINVOKE.UsdSkelAnimation_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdSkelAnimation Get(UsdStage stage, SdfPath path)
		{
			UsdSkelAnimation result = new UsdSkelAnimation(UsdSkelPINVOKE.UsdSkelAnimation_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdSkelAnimation Define(UsdStage stage, SdfPath path)
		{
			UsdSkelAnimation result = new UsdSkelAnimation(UsdSkelPINVOKE.UsdSkelAnimation_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetJointsAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelAnimation_GetJointsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateJointsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelAnimation_CreateJointsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateJointsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelAnimation_CreateJointsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateJointsAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelAnimation_CreateJointsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetTranslationsAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelAnimation_GetTranslationsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateTranslationsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelAnimation_CreateTranslationsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateTranslationsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelAnimation_CreateTranslationsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateTranslationsAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelAnimation_CreateTranslationsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetRotationsAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelAnimation_GetRotationsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateRotationsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelAnimation_CreateRotationsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateRotationsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelAnimation_CreateRotationsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateRotationsAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelAnimation_CreateRotationsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetScalesAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelAnimation_GetScalesAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateScalesAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelAnimation_CreateScalesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateScalesAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelAnimation_CreateScalesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateScalesAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelAnimation_CreateScalesAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetBlendShapesAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelAnimation_GetBlendShapesAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateBlendShapesAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelAnimation_CreateBlendShapesAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateBlendShapesAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelAnimation_CreateBlendShapesAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateBlendShapesAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelAnimation_CreateBlendShapesAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetBlendShapeWeightsAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelAnimation_GetBlendShapeWeightsAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateBlendShapeWeightsAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelAnimation_CreateBlendShapeWeightsAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateBlendShapeWeightsAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdSkelPINVOKE.UsdSkelAnimation_CreateBlendShapeWeightsAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateBlendShapeWeightsAttr()
		{
			return new UsdAttribute(UsdSkelPINVOKE.UsdSkelAnimation_CreateBlendShapeWeightsAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public bool GetTransforms(VtMatrix4dArray xforms, UsdTimeCode time)
		{
			bool result = UsdSkelPINVOKE.UsdSkelAnimation_GetTransforms__SWIG_0(swigCPtr, VtMatrix4dArray.getCPtr(xforms), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetTransforms(VtMatrix4dArray xforms)
		{
			return UsdSkelPINVOKE.UsdSkelAnimation_GetTransforms__SWIG_1(swigCPtr, VtMatrix4dArray.getCPtr(xforms));
		}

		public bool SetTransforms(VtMatrix4dArray xforms, UsdTimeCode time)
		{
			bool result = UsdSkelPINVOKE.UsdSkelAnimation_SetTransforms__SWIG_0(swigCPtr, VtMatrix4dArray.getCPtr(xforms), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetTransforms(VtMatrix4dArray xforms)
		{
			bool result = UsdSkelPINVOKE.UsdSkelAnimation_SetTransforms__SWIG_1(swigCPtr, VtMatrix4dArray.getCPtr(xforms));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
