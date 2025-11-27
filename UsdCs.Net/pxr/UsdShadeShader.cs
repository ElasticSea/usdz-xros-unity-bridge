using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdShadeShader : UsdTyped
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdShadeShader(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdShadePINVOKE.UsdShadeShader_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdShadeShader obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdShadeShader obj)
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
						UsdShadePINVOKE.delete_UsdShadeShader(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdShadeShader(UsdPrim prim)
			: this(UsdShadePINVOKE.new_UsdShadeShader__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeShader()
			: this(UsdShadePINVOKE.new_UsdShadeShader__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdShadeShader(UsdSchemaBase schemaObj)
			: this(UsdShadePINVOKE.new_UsdShadeShader__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdShadePINVOKE.UsdShadeShader_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdShadePINVOKE.UsdShadeShader_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdShadeShader Get(UsdStage stage, SdfPath path)
		{
			UsdShadeShader result = new UsdShadeShader(UsdShadePINVOKE.UsdShadeShader_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdShadeShader Define(UsdStage stage, SdfPath path)
		{
			UsdShadeShader result = new UsdShadeShader(UsdShadePINVOKE.UsdShadeShader_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeShader(UsdShadeConnectableAPI connectable)
			: this(UsdShadePINVOKE.new_UsdShadeShader__SWIG_3(UsdShadeConnectableAPI.getCPtr(connectable)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeConnectableAPI ConnectableAPI()
		{
			return new UsdShadeConnectableAPI(UsdShadePINVOKE.UsdShadeShader_ConnectableAPI(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeOutput CreateOutput(TfToken name, SdfValueTypeName typeName)
		{
			UsdShadeOutput result = new UsdShadeOutput(UsdShadePINVOKE.UsdShadeShader_CreateOutput(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeOutput GetOutput(TfToken name)
		{
			UsdShadeOutput result = new UsdShadeOutput(UsdShadePINVOKE.UsdShadeShader_GetOutput(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeOutputVector GetOutputs(bool onlyAuthored)
		{
			return new UsdShadeOutputVector(UsdShadePINVOKE.UsdShadeShader_GetOutputs__SWIG_0(swigCPtr, onlyAuthored), cMemoryOwn: true);
		}

		public UsdShadeOutputVector GetOutputs()
		{
			return new UsdShadeOutputVector(UsdShadePINVOKE.UsdShadeShader_GetOutputs__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeInput CreateInput(TfToken name, SdfValueTypeName typeName)
		{
			UsdShadeInput result = new UsdShadeInput(UsdShadePINVOKE.UsdShadeShader_CreateInput(swigCPtr, TfToken.getCPtr(name), SdfValueTypeName.getCPtr(typeName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeInput GetInput(TfToken name)
		{
			UsdShadeInput result = new UsdShadeInput(UsdShadePINVOKE.UsdShadeShader_GetInput(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeInputVector GetInputs(bool onlyAuthored)
		{
			return new UsdShadeInputVector(UsdShadePINVOKE.UsdShadeShader_GetInputs__SWIG_0(swigCPtr, onlyAuthored), cMemoryOwn: true);
		}

		public UsdShadeInputVector GetInputs()
		{
			return new UsdShadeInputVector(UsdShadePINVOKE.UsdShadeShader_GetInputs__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetImplementationSourceAttr()
		{
			return new UsdAttribute(UsdShadePINVOKE.UsdShadeShader_GetImplementationSourceAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateImplementationSourceAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdShadePINVOKE.UsdShadeShader_CreateImplementationSourceAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateImplementationSourceAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdShadePINVOKE.UsdShadeShader_CreateImplementationSourceAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateImplementationSourceAttr()
		{
			return new UsdAttribute(UsdShadePINVOKE.UsdShadeShader_CreateImplementationSourceAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetIdAttr()
		{
			return new UsdAttribute(UsdShadePINVOKE.UsdShadeShader_GetIdAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateIdAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdShadePINVOKE.UsdShadeShader_CreateIdAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateIdAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdShadePINVOKE.UsdShadeShader_CreateIdAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateIdAttr()
		{
			return new UsdAttribute(UsdShadePINVOKE.UsdShadeShader_CreateIdAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public TfToken GetImplementationSource()
		{
			return new TfToken(UsdShadePINVOKE.UsdShadeShader_GetImplementationSource(swigCPtr), cMemoryOwn: true);
		}

		public bool SetShaderId(TfToken id)
		{
			bool result = UsdShadePINVOKE.UsdShadeShader_SetShaderId(swigCPtr, TfToken.getCPtr(id));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetShaderId(TfToken id)
		{
			return UsdShadePINVOKE.UsdShadeShader_GetShaderId(swigCPtr, TfToken.getCPtr(id));
		}

		public bool SetSourceAsset(SdfAssetPath sourceAsset, TfToken sourceType)
		{
			bool result = UsdShadePINVOKE.UsdShadeShader_SetSourceAsset__SWIG_0(swigCPtr, SdfAssetPath.getCPtr(sourceAsset), TfToken.getCPtr(sourceType));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetSourceAsset(SdfAssetPath sourceAsset)
		{
			bool result = UsdShadePINVOKE.UsdShadeShader_SetSourceAsset__SWIG_1(swigCPtr, SdfAssetPath.getCPtr(sourceAsset));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetSourceAsset(SdfAssetPath sourceAsset, TfToken sourceType)
		{
			bool result = UsdShadePINVOKE.UsdShadeShader_GetSourceAsset__SWIG_0(swigCPtr, SdfAssetPath.getCPtr(sourceAsset), TfToken.getCPtr(sourceType));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetSourceAsset(SdfAssetPath sourceAsset)
		{
			return UsdShadePINVOKE.UsdShadeShader_GetSourceAsset__SWIG_1(swigCPtr, SdfAssetPath.getCPtr(sourceAsset));
		}

		public bool SetSourceAssetSubIdentifier(TfToken subIdentifier, TfToken sourceType)
		{
			bool result = UsdShadePINVOKE.UsdShadeShader_SetSourceAssetSubIdentifier__SWIG_0(swigCPtr, TfToken.getCPtr(subIdentifier), TfToken.getCPtr(sourceType));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetSourceAssetSubIdentifier(TfToken subIdentifier)
		{
			bool result = UsdShadePINVOKE.UsdShadeShader_SetSourceAssetSubIdentifier__SWIG_1(swigCPtr, TfToken.getCPtr(subIdentifier));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetSourceAssetSubIdentifier(TfToken subIdentifier, TfToken sourceType)
		{
			bool result = UsdShadePINVOKE.UsdShadeShader_GetSourceAssetSubIdentifier__SWIG_0(swigCPtr, TfToken.getCPtr(subIdentifier), TfToken.getCPtr(sourceType));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetSourceAssetSubIdentifier(TfToken subIdentifier)
		{
			return UsdShadePINVOKE.UsdShadeShader_GetSourceAssetSubIdentifier__SWIG_1(swigCPtr, TfToken.getCPtr(subIdentifier));
		}

		public bool SetSourceCode(string sourceCode, TfToken sourceType)
		{
			bool result = UsdShadePINVOKE.UsdShadeShader_SetSourceCode__SWIG_0(swigCPtr, sourceCode, TfToken.getCPtr(sourceType));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetSourceCode(string sourceCode)
		{
			bool result = UsdShadePINVOKE.UsdShadeShader_SetSourceCode__SWIG_1(swigCPtr, sourceCode);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetSourceCode(out string sourceCode, TfToken sourceType)
		{
			bool result = UsdShadePINVOKE.UsdShadeShader_GetSourceCode__SWIG_0(swigCPtr, out sourceCode, TfToken.getCPtr(sourceType));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetSourceCode(out string sourceCode)
		{
			bool result = UsdShadePINVOKE.UsdShadeShader_GetSourceCode__SWIG_1(swigCPtr, out sourceCode);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdrShaderNode GetShaderNodeForSourceType(TfToken sourceType)
		{
			IntPtr intPtr = UsdShadePINVOKE.UsdShadeShader_GetShaderNodeForSourceType(swigCPtr, TfToken.getCPtr(sourceType));
			SdrShaderNode result = ((intPtr == IntPtr.Zero) ? null : new SdrShaderNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public NdrTokenMap GetSdrMetadata()
		{
			return new NdrTokenMap(UsdShadePINVOKE.UsdShadeShader_GetSdrMetadata(swigCPtr), cMemoryOwn: true);
		}

		public string GetSdrMetadataByKey(TfToken key)
		{
			string result = UsdShadePINVOKE.UsdShadeShader_GetSdrMetadataByKey(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetSdrMetadata(NdrTokenMap sdrMetadata)
		{
			UsdShadePINVOKE.UsdShadeShader_SetSdrMetadata(swigCPtr, NdrTokenMap.getCPtr(sdrMetadata));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetSdrMetadataByKey(TfToken key, string value)
		{
			UsdShadePINVOKE.UsdShadeShader_SetSdrMetadataByKey(swigCPtr, TfToken.getCPtr(key), value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasSdrMetadata()
		{
			return UsdShadePINVOKE.UsdShadeShader_HasSdrMetadata(swigCPtr);
		}

		public bool HasSdrMetadataByKey(TfToken key)
		{
			bool result = UsdShadePINVOKE.UsdShadeShader_HasSdrMetadataByKey(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ClearSdrMetadata()
		{
			UsdShadePINVOKE.UsdShadeShader_ClearSdrMetadata(swigCPtr);
		}

		public void ClearSdrMetadataByKey(TfToken key)
		{
			UsdShadePINVOKE.UsdShadeShader_ClearSdrMetadataByKey(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
