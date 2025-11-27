using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdModelAPI : UsdAPISchemaBase
	{
		public enum KindValidation
		{
			KindValidationNone,
			KindValidationModelHierarchy
		}

		private HandleRef swigCPtr;

		public new const UsdSchemaKind schemaKind = UsdSchemaKind.NonAppliedAPI;

		public UsdModelAPI(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdPINVOKE.UsdModelAPI_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdModelAPI obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdModelAPI obj)
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
						UsdPINVOKE.delete_UsdModelAPI(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdModelAPI(UsdPrim prim)
			: this(UsdPINVOKE.new_UsdModelAPI__SWIG_0(UsdPrim.getCPtr(prim)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdModelAPI()
			: this(UsdPINVOKE.new_UsdModelAPI__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdModelAPI(UsdSchemaBase schemaObj)
			: this(UsdPINVOKE.new_UsdModelAPI__SWIG_2(UsdSchemaBase.getCPtr(schemaObj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited)
		{
			return new TfTokenVector(UsdPINVOKE.UsdModelAPI_GetSchemaAttributeNames__SWIG_0(includeInherited), cMemoryOwn: false);
		}

		public new static TfTokenVector GetSchemaAttributeNames()
		{
			return new TfTokenVector(UsdPINVOKE.UsdModelAPI_GetSchemaAttributeNames__SWIG_1(), cMemoryOwn: false);
		}

		public static UsdModelAPI Get(UsdStage stage, SdfPath path)
		{
			UsdModelAPI result = new UsdModelAPI(UsdPINVOKE.UsdModelAPI_Get(UsdStage.getCPtr(stage), SdfPath.getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool GetKind(TfToken kind)
		{
			return UsdPINVOKE.UsdModelAPI_GetKind(swigCPtr, TfToken.getCPtr(kind));
		}

		public bool SetKind(TfToken kind)
		{
			bool result = UsdPINVOKE.UsdModelAPI_SetKind(swigCPtr, TfToken.getCPtr(kind));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsKind(TfToken baseKind, KindValidation validation)
		{
			bool result = UsdPINVOKE.UsdModelAPI_IsKind__SWIG_0(swigCPtr, TfToken.getCPtr(baseKind), (int)validation);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsKind(TfToken baseKind)
		{
			bool result = UsdPINVOKE.UsdModelAPI_IsKind__SWIG_1(swigCPtr, TfToken.getCPtr(baseKind));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsModel()
		{
			return UsdPINVOKE.UsdModelAPI_IsModel(swigCPtr);
		}

		public bool IsGroup()
		{
			return UsdPINVOKE.UsdModelAPI_IsGroup(swigCPtr);
		}

		public bool GetAssetIdentifier(SdfAssetPath identifier)
		{
			return UsdPINVOKE.UsdModelAPI_GetAssetIdentifier(swigCPtr, SdfAssetPath.getCPtr(identifier));
		}

		public void SetAssetIdentifier(SdfAssetPath identifier)
		{
			UsdPINVOKE.UsdModelAPI_SetAssetIdentifier(swigCPtr, SdfAssetPath.getCPtr(identifier));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool GetAssetName(out string assetName)
		{
			bool result = UsdPINVOKE.UsdModelAPI_GetAssetName(swigCPtr, out assetName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetAssetName(string assetName)
		{
			UsdPINVOKE.UsdModelAPI_SetAssetName(swigCPtr, assetName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool GetAssetVersion(out string version)
		{
			bool result = UsdPINVOKE.UsdModelAPI_GetAssetVersion(swigCPtr, out version);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetAssetVersion(string version)
		{
			UsdPINVOKE.UsdModelAPI_SetAssetVersion(swigCPtr, version);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool GetPayloadAssetDependencies(SdfAssetPathArray assetDeps)
		{
			return UsdPINVOKE.UsdModelAPI_GetPayloadAssetDependencies(swigCPtr, SdfAssetPathArray.getCPtr(assetDeps));
		}

		public void SetPayloadAssetDependencies(SdfAssetPathArray assetDeps)
		{
			UsdPINVOKE.UsdModelAPI_SetPayloadAssetDependencies(swigCPtr, SdfAssetPathArray.getCPtr(assetDeps));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool GetAssetInfo(VtDictionary info)
		{
			return UsdPINVOKE.UsdModelAPI_GetAssetInfo(swigCPtr, VtDictionary.getCPtr(info));
		}

		public void SetAssetInfo(VtDictionary info)
		{
			UsdPINVOKE.UsdModelAPI_SetAssetInfo(swigCPtr, VtDictionary.getCPtr(info));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
