using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdShadeMaterial : UsdShadeNodeGraph
	{
		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.ConcreteTyped;

		public UsdShadeMaterial(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdShadePINVOKE.UsdShadeMaterial_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdShadeMaterial obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdShadeMaterial obj)
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
						UsdShadePINVOKE.delete_UsdShadeMaterial(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdShadeMaterial(UsdPrim prim)
			: this(UsdShadePINVOKE.new_UsdShadeMaterial__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeMaterial()
			: this(UsdShadePINVOKE.new_UsdShadeMaterial__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdShadeMaterial(UsdSchemaBase schemaObj)
			: this(UsdShadePINVOKE.new_UsdShadeMaterial__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdShadePINVOKE.UsdShadeMaterial_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdShadePINVOKE.UsdShadeMaterial_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public new static UsdShadeMaterial Get(UsdStage stage, SdfPath path)
		{
			UsdShadeMaterial result = new UsdShadeMaterial(UsdShadePINVOKE.UsdShadeMaterial_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public new static UsdShadeMaterial Define(UsdStage stage, SdfPath path)
		{
			UsdShadeMaterial result = new UsdShadeMaterial(UsdShadePINVOKE.UsdShadeMaterial_Define(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetSurfaceAttr()
		{
			return new UsdAttribute(UsdShadePINVOKE.UsdShadeMaterial_GetSurfaceAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateSurfaceAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdShadePINVOKE.UsdShadeMaterial_CreateSurfaceAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateSurfaceAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdShadePINVOKE.UsdShadeMaterial_CreateSurfaceAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateSurfaceAttr()
		{
			return new UsdAttribute(UsdShadePINVOKE.UsdShadeMaterial_CreateSurfaceAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetDisplacementAttr()
		{
			return new UsdAttribute(UsdShadePINVOKE.UsdShadeMaterial_GetDisplacementAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateDisplacementAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdShadePINVOKE.UsdShadeMaterial_CreateDisplacementAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateDisplacementAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdShadePINVOKE.UsdShadeMaterial_CreateDisplacementAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateDisplacementAttr()
		{
			return new UsdAttribute(UsdShadePINVOKE.UsdShadeMaterial_CreateDisplacementAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute GetVolumeAttr()
		{
			return new UsdAttribute(UsdShadePINVOKE.UsdShadeMaterial_GetVolumeAttr(swigCPtr), cMemoryOwn: true);
		}

		public UsdAttribute CreateVolumeAttr(VtValue defaultValue, bool writeSparsely)
		{
			UsdAttribute result = new UsdAttribute(UsdShadePINVOKE.UsdShadeMaterial_CreateVolumeAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVolumeAttr(VtValue defaultValue)
		{
			UsdAttribute result = new UsdAttribute(UsdShadePINVOKE.UsdShadeMaterial_CreateVolumeAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute CreateVolumeAttr()
		{
			return new UsdAttribute(UsdShadePINVOKE.UsdShadeMaterial_CreateVolumeAttr__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeOutput CreateSurfaceOutput(TfToken renderContext)
		{
			UsdShadeOutput result = new UsdShadeOutput(UsdShadePINVOKE.UsdShadeMaterial_CreateSurfaceOutput__SWIG_0(swigCPtr, TfToken.getCPtr(renderContext)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeOutput CreateSurfaceOutput()
		{
			return new UsdShadeOutput(UsdShadePINVOKE.UsdShadeMaterial_CreateSurfaceOutput__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeOutput GetSurfaceOutput(TfToken renderContext)
		{
			UsdShadeOutput result = new UsdShadeOutput(UsdShadePINVOKE.UsdShadeMaterial_GetSurfaceOutput__SWIG_0(swigCPtr, TfToken.getCPtr(renderContext)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeOutput GetSurfaceOutput()
		{
			return new UsdShadeOutput(UsdShadePINVOKE.UsdShadeMaterial_GetSurfaceOutput__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeOutputVector GetSurfaceOutputs()
		{
			return new UsdShadeOutputVector(UsdShadePINVOKE.UsdShadeMaterial_GetSurfaceOutputs(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeShader ComputeSurfaceSource(TfToken renderContext, TfToken sourceName, out UsdShadeAttributeType sourceType)
		{
			UsdShadeShader result = new UsdShadeShader(UsdShadePINVOKE.UsdShadeMaterial_ComputeSurfaceSource__SWIG_0(swigCPtr, TfToken.getCPtr(renderContext), TfToken.getCPtr(sourceName), out sourceType), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeShader ComputeSurfaceSource(TfToken renderContext, TfToken sourceName)
		{
			UsdShadeShader result = new UsdShadeShader(UsdShadePINVOKE.UsdShadeMaterial_ComputeSurfaceSource__SWIG_1(swigCPtr, TfToken.getCPtr(renderContext), TfToken.getCPtr(sourceName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeShader ComputeSurfaceSource(TfToken renderContext)
		{
			UsdShadeShader result = new UsdShadeShader(UsdShadePINVOKE.UsdShadeMaterial_ComputeSurfaceSource__SWIG_2(swigCPtr, TfToken.getCPtr(renderContext)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeShader ComputeSurfaceSource(TfTokenVector contextVector, TfToken sourceName, out UsdShadeAttributeType sourceType)
		{
			UsdShadeShader result = new UsdShadeShader(UsdShadePINVOKE.UsdShadeMaterial_ComputeSurfaceSource__SWIG_3(swigCPtr, TfTokenVector.getCPtr(contextVector), TfToken.getCPtr(sourceName), out sourceType), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeShader ComputeSurfaceSource(TfTokenVector contextVector, TfToken sourceName)
		{
			UsdShadeShader result = new UsdShadeShader(UsdShadePINVOKE.UsdShadeMaterial_ComputeSurfaceSource__SWIG_4(swigCPtr, TfTokenVector.getCPtr(contextVector), TfToken.getCPtr(sourceName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeShader ComputeSurfaceSource(TfTokenVector contextVector)
		{
			UsdShadeShader result = new UsdShadeShader(UsdShadePINVOKE.UsdShadeMaterial_ComputeSurfaceSource__SWIG_5(swigCPtr, TfTokenVector.getCPtr(contextVector)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeShader ComputeSurfaceSource()
		{
			return new UsdShadeShader(UsdShadePINVOKE.UsdShadeMaterial_ComputeSurfaceSource__SWIG_6(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeOutput CreateDisplacementOutput(TfToken renderContext)
		{
			UsdShadeOutput result = new UsdShadeOutput(UsdShadePINVOKE.UsdShadeMaterial_CreateDisplacementOutput__SWIG_0(swigCPtr, TfToken.getCPtr(renderContext)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeOutput CreateDisplacementOutput()
		{
			return new UsdShadeOutput(UsdShadePINVOKE.UsdShadeMaterial_CreateDisplacementOutput__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeOutput GetDisplacementOutput(TfToken renderContext)
		{
			UsdShadeOutput result = new UsdShadeOutput(UsdShadePINVOKE.UsdShadeMaterial_GetDisplacementOutput__SWIG_0(swigCPtr, TfToken.getCPtr(renderContext)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeOutput GetDisplacementOutput()
		{
			return new UsdShadeOutput(UsdShadePINVOKE.UsdShadeMaterial_GetDisplacementOutput__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeOutputVector GetDisplacementOutputs()
		{
			return new UsdShadeOutputVector(UsdShadePINVOKE.UsdShadeMaterial_GetDisplacementOutputs(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeShader ComputeDisplacementSource(TfToken renderContext, TfToken sourceName, out UsdShadeAttributeType sourceType)
		{
			UsdShadeShader result = new UsdShadeShader(UsdShadePINVOKE.UsdShadeMaterial_ComputeDisplacementSource__SWIG_0(swigCPtr, TfToken.getCPtr(renderContext), TfToken.getCPtr(sourceName), out sourceType), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeShader ComputeDisplacementSource(TfToken renderContext, TfToken sourceName)
		{
			UsdShadeShader result = new UsdShadeShader(UsdShadePINVOKE.UsdShadeMaterial_ComputeDisplacementSource__SWIG_1(swigCPtr, TfToken.getCPtr(renderContext), TfToken.getCPtr(sourceName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeShader ComputeDisplacementSource(TfToken renderContext)
		{
			UsdShadeShader result = new UsdShadeShader(UsdShadePINVOKE.UsdShadeMaterial_ComputeDisplacementSource__SWIG_2(swigCPtr, TfToken.getCPtr(renderContext)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeShader ComputeDisplacementSource(TfTokenVector contextVector, TfToken sourceName, out UsdShadeAttributeType sourceType)
		{
			UsdShadeShader result = new UsdShadeShader(UsdShadePINVOKE.UsdShadeMaterial_ComputeDisplacementSource__SWIG_3(swigCPtr, TfTokenVector.getCPtr(contextVector), TfToken.getCPtr(sourceName), out sourceType), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeShader ComputeDisplacementSource(TfTokenVector contextVector, TfToken sourceName)
		{
			UsdShadeShader result = new UsdShadeShader(UsdShadePINVOKE.UsdShadeMaterial_ComputeDisplacementSource__SWIG_4(swigCPtr, TfTokenVector.getCPtr(contextVector), TfToken.getCPtr(sourceName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeShader ComputeDisplacementSource(TfTokenVector contextVector)
		{
			UsdShadeShader result = new UsdShadeShader(UsdShadePINVOKE.UsdShadeMaterial_ComputeDisplacementSource__SWIG_5(swigCPtr, TfTokenVector.getCPtr(contextVector)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeShader ComputeDisplacementSource()
		{
			return new UsdShadeShader(UsdShadePINVOKE.UsdShadeMaterial_ComputeDisplacementSource__SWIG_6(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeOutput CreateVolumeOutput(TfToken renderContext)
		{
			UsdShadeOutput result = new UsdShadeOutput(UsdShadePINVOKE.UsdShadeMaterial_CreateVolumeOutput__SWIG_0(swigCPtr, TfToken.getCPtr(renderContext)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeOutput CreateVolumeOutput()
		{
			return new UsdShadeOutput(UsdShadePINVOKE.UsdShadeMaterial_CreateVolumeOutput__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeOutput GetVolumeOutput(TfToken renderContext)
		{
			UsdShadeOutput result = new UsdShadeOutput(UsdShadePINVOKE.UsdShadeMaterial_GetVolumeOutput__SWIG_0(swigCPtr, TfToken.getCPtr(renderContext)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeOutput GetVolumeOutput()
		{
			return new UsdShadeOutput(UsdShadePINVOKE.UsdShadeMaterial_GetVolumeOutput__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeOutputVector GetVolumeOutputs()
		{
			return new UsdShadeOutputVector(UsdShadePINVOKE.UsdShadeMaterial_GetVolumeOutputs(swigCPtr), cMemoryOwn: true);
		}

		public UsdShadeShader ComputeVolumeSource(TfToken renderContext, TfToken sourceName, out UsdShadeAttributeType sourceType)
		{
			UsdShadeShader result = new UsdShadeShader(UsdShadePINVOKE.UsdShadeMaterial_ComputeVolumeSource__SWIG_0(swigCPtr, TfToken.getCPtr(renderContext), TfToken.getCPtr(sourceName), out sourceType), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeShader ComputeVolumeSource(TfToken renderContext, TfToken sourceName)
		{
			UsdShadeShader result = new UsdShadeShader(UsdShadePINVOKE.UsdShadeMaterial_ComputeVolumeSource__SWIG_1(swigCPtr, TfToken.getCPtr(renderContext), TfToken.getCPtr(sourceName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeShader ComputeVolumeSource(TfToken renderContext)
		{
			UsdShadeShader result = new UsdShadeShader(UsdShadePINVOKE.UsdShadeMaterial_ComputeVolumeSource__SWIG_2(swigCPtr, TfToken.getCPtr(renderContext)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeShader ComputeVolumeSource(TfTokenVector contextVector, TfToken sourceName, out UsdShadeAttributeType sourceType)
		{
			UsdShadeShader result = new UsdShadeShader(UsdShadePINVOKE.UsdShadeMaterial_ComputeVolumeSource__SWIG_3(swigCPtr, TfTokenVector.getCPtr(contextVector), TfToken.getCPtr(sourceName), out sourceType), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeShader ComputeVolumeSource(TfTokenVector contextVector, TfToken sourceName)
		{
			UsdShadeShader result = new UsdShadeShader(UsdShadePINVOKE.UsdShadeMaterial_ComputeVolumeSource__SWIG_4(swigCPtr, TfTokenVector.getCPtr(contextVector), TfToken.getCPtr(sourceName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeShader ComputeVolumeSource(TfTokenVector contextVector)
		{
			UsdShadeShader result = new UsdShadeShader(UsdShadePINVOKE.UsdShadeMaterial_ComputeVolumeSource__SWIG_5(swigCPtr, TfTokenVector.getCPtr(contextVector)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeShader ComputeVolumeSource()
		{
			return new UsdShadeShader(UsdShadePINVOKE.UsdShadeMaterial_ComputeVolumeSource__SWIG_6(swigCPtr), cMemoryOwn: true);
		}

		public VariantEditContext GetEditContextForVariant(TfToken MaterialVariantName, SdfLayerHandle layer)
		{
			VariantEditContext result = new VariantEditContext(UsdShadePINVOKE.UsdShadeMaterial_GetEditContextForVariant__SWIG_0(swigCPtr, TfToken.getCPtr(MaterialVariantName), SdfLayerHandle.getCPtr(layer)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VariantEditContext GetEditContextForVariant(TfToken MaterialVariantName)
		{
			VariantEditContext result = new VariantEditContext(UsdShadePINVOKE.UsdShadeMaterial_GetEditContextForVariant__SWIG_1(swigCPtr, TfToken.getCPtr(MaterialVariantName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdVariantSet GetMaterialVariant()
		{
			return new UsdVariantSet(UsdShadePINVOKE.UsdShadeMaterial_GetMaterialVariant(swigCPtr), cMemoryOwn: true);
		}

		public static bool CreateMasterMaterialVariant(UsdPrim masterPrim, UsdPrimVector MaterialPrims, TfToken masterVariantSetName)
		{
			bool result = UsdShadePINVOKE.UsdShadeMaterial_CreateMasterMaterialVariant__SWIG_0(UsdPrim.getCPtr(masterPrim), UsdPrimVector.getCPtr(MaterialPrims), TfToken.getCPtr(masterVariantSetName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool CreateMasterMaterialVariant(UsdPrim masterPrim, UsdPrimVector MaterialPrims)
		{
			bool result = UsdShadePINVOKE.UsdShadeMaterial_CreateMasterMaterialVariant__SWIG_1(UsdPrim.getCPtr(masterPrim), UsdPrimVector.getCPtr(MaterialPrims));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeMaterial GetBaseMaterial()
		{
			return new UsdShadeMaterial(UsdShadePINVOKE.UsdShadeMaterial_GetBaseMaterial(swigCPtr), cMemoryOwn: true);
		}

		public SdfPath GetBaseMaterialPath()
		{
			return new SdfPath(UsdShadePINVOKE.UsdShadeMaterial_GetBaseMaterialPath(swigCPtr), cMemoryOwn: true);
		}

		public void SetBaseMaterial(UsdShadeMaterial baseMaterial)
		{
			UsdShadePINVOKE.UsdShadeMaterial_SetBaseMaterial(swigCPtr, getCPtr(baseMaterial));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetBaseMaterialPath(SdfPath baseMaterialPath)
		{
			UsdShadePINVOKE.UsdShadeMaterial_SetBaseMaterialPath(swigCPtr, SdfPath.getCPtr(baseMaterialPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void ClearBaseMaterial()
		{
			UsdShadePINVOKE.UsdShadeMaterial_ClearBaseMaterial(swigCPtr);
		}

		public bool HasBaseMaterial()
		{
			return UsdShadePINVOKE.UsdShadeMaterial_HasBaseMaterial(swigCPtr);
		}
	}
}
