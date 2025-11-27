using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdShadeNodeDefAPI : UsdAPISchemaBase
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.SingleApplyAPI;

		public UsdShadeNodeDefAPI(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdShadePINVOKE.UsdShadeNodeDefAPI_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdShadeNodeDefAPI obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdShadeNodeDefAPI obj)
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
						UsdShadePINVOKE.delete_UsdShadeNodeDefAPI(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdShadeNodeDefAPI(UsdPrim prim)
			: this(UsdShadePINVOKE.new_UsdShadeNodeDefAPI__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeNodeDefAPI()
			: this(UsdShadePINVOKE.new_UsdShadeNodeDefAPI__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdShadeNodeDefAPI(UsdSchemaBase schemaObj)
			: this(UsdShadePINVOKE.new_UsdShadeNodeDefAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdShadePINVOKE.UsdShadeNodeDefAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdShadePINVOKE.UsdShadeNodeDefAPI_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public static UsdShadeNodeDefAPI Get(UsdStage stage, SdfPath path)
		{
			UsdShadeNodeDefAPI result = new UsdShadeNodeDefAPI(UsdShadePINVOKE.UsdShadeNodeDefAPI_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim, out string whyNot)
		{
			bool result = UsdShadePINVOKE.UsdShadeNodeDefAPI_CanApply__SWIG_0(UsdPrim.getCPtr(prim), out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CanApply(UsdPrim prim)
		{
			bool result = UsdShadePINVOKE.UsdShadeNodeDefAPI_CanApply__SWIG_1(UsdPrim.getCPtr(prim));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdShadeNodeDefAPI Apply(UsdPrim prim)
		{
			UsdShadeNodeDefAPI result = new UsdShadeNodeDefAPI(UsdShadePINVOKE.UsdShadeNodeDefAPI_Apply(UsdPrim.getCPtr(prim)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetImplementationSourceAttr()
		{
			return new UsdAttribute(UsdShadePINVOKE.UsdShadeNodeDefAPI_GetImplementationSourceAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateImplementationSourceAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdShadePINVOKE.UsdShadeNodeDefAPI_CreateImplementationSourceAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateImplementationSourceAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdShadePINVOKE.UsdShadeNodeDefAPI_CreateImplementationSourceAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateImplementationSourceAttr()
		{
			return new UsdAttribute(UsdShadePINVOKE.UsdShadeNodeDefAPI_CreateImplementationSourceAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetIdAttr()
		{
			return new UsdAttribute(UsdShadePINVOKE.UsdShadeNodeDefAPI_GetIdAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateIdAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdShadePINVOKE.UsdShadeNodeDefAPI_CreateIdAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateIdAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdShadePINVOKE.UsdShadeNodeDefAPI_CreateIdAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateIdAttr()
		{
			return new UsdAttribute(UsdShadePINVOKE.UsdShadeNodeDefAPI_CreateIdAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public TfToken GetImplementationSource()
		{
			return new TfToken(UsdShadePINVOKE.UsdShadeNodeDefAPI_GetImplementationSource(swigCPtr), cMemoryOwn: true);
		}

		public bool SetShaderId(TfToken id)
		{
			bool result = UsdShadePINVOKE.UsdShadeNodeDefAPI_SetShaderId(swigCPtr, TfToken.getCPtr(id));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetShaderId(TfToken id)
		{
			return UsdShadePINVOKE.UsdShadeNodeDefAPI_GetShaderId(swigCPtr, TfToken.getCPtr(id));
		}

		public bool SetSourceAsset(SdfAssetPath sourceAsset, TfToken sourceType)
		{
			bool result = UsdShadePINVOKE.UsdShadeNodeDefAPI_SetSourceAsset__SWIG_0(swigCPtr, SdfAssetPath.getCPtr(sourceAsset), TfToken.getCPtr(sourceType));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetSourceAsset(SdfAssetPath sourceAsset)
		{
			bool result = UsdShadePINVOKE.UsdShadeNodeDefAPI_SetSourceAsset__SWIG_1(swigCPtr, SdfAssetPath.getCPtr(sourceAsset));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetSourceAsset(SdfAssetPath sourceAsset, TfToken sourceType)
		{
			bool result = UsdShadePINVOKE.UsdShadeNodeDefAPI_GetSourceAsset__SWIG_0(swigCPtr, SdfAssetPath.getCPtr(sourceAsset), TfToken.getCPtr(sourceType));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetSourceAsset(SdfAssetPath sourceAsset)
		{
			return UsdShadePINVOKE.UsdShadeNodeDefAPI_GetSourceAsset__SWIG_1(swigCPtr, SdfAssetPath.getCPtr(sourceAsset));
		}

		public bool SetSourceAssetSubIdentifier(TfToken subIdentifier, TfToken sourceType)
		{
			bool result = UsdShadePINVOKE.UsdShadeNodeDefAPI_SetSourceAssetSubIdentifier__SWIG_0(swigCPtr, TfToken.getCPtr(subIdentifier), TfToken.getCPtr(sourceType));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetSourceAssetSubIdentifier(TfToken subIdentifier)
		{
			bool result = UsdShadePINVOKE.UsdShadeNodeDefAPI_SetSourceAssetSubIdentifier__SWIG_1(swigCPtr, TfToken.getCPtr(subIdentifier));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetSourceAssetSubIdentifier(TfToken subIdentifier, TfToken sourceType)
		{
			bool result = UsdShadePINVOKE.UsdShadeNodeDefAPI_GetSourceAssetSubIdentifier__SWIG_0(swigCPtr, TfToken.getCPtr(subIdentifier), TfToken.getCPtr(sourceType));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetSourceAssetSubIdentifier(TfToken subIdentifier)
		{
			return UsdShadePINVOKE.UsdShadeNodeDefAPI_GetSourceAssetSubIdentifier__SWIG_1(swigCPtr, TfToken.getCPtr(subIdentifier));
		}

		public bool SetSourceCode(string sourceCode, TfToken sourceType)
		{
			bool result = UsdShadePINVOKE.UsdShadeNodeDefAPI_SetSourceCode__SWIG_0(swigCPtr, sourceCode, TfToken.getCPtr(sourceType));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetSourceCode(string sourceCode)
		{
			bool result = UsdShadePINVOKE.UsdShadeNodeDefAPI_SetSourceCode__SWIG_1(swigCPtr, sourceCode);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetSourceCode(out string sourceCode, TfToken sourceType)
		{
			bool result = UsdShadePINVOKE.UsdShadeNodeDefAPI_GetSourceCode__SWIG_0(swigCPtr, out sourceCode, TfToken.getCPtr(sourceType));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetSourceCode(out string sourceCode)
		{
			bool result = UsdShadePINVOKE.UsdShadeNodeDefAPI_GetSourceCode__SWIG_1(swigCPtr, out sourceCode);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdrShaderNode GetShaderNodeForSourceType(TfToken sourceType)
		{
			IntPtr intPtr = UsdShadePINVOKE.UsdShadeNodeDefAPI_GetShaderNodeForSourceType(swigCPtr, TfToken.getCPtr(sourceType));
			SdrShaderNode result = ((intPtr == IntPtr.Zero) ? null : new SdrShaderNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
