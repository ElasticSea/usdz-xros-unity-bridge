using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfVariantSetSpecHandle : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfVariantSetSpecHandle(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfVariantSetSpecHandle obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfVariantSetSpecHandle obj)
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

		~SdfVariantSetSpecHandle()
		{
			Dispose(disposing: false);
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			lock (this)
			{
				if (swigCPtr.Handle != IntPtr.Zero)
				{
					if (swigCMemOwn)
					{
						swigCMemOwn = false;
						SdfPINVOKE.delete_SdfVariantSetSpecHandle(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfVariantSetSpecHandle()
			: this(SdfPINVOKE.new_SdfVariantSetSpecHandle__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfVariantSetSpecHandle(SdfVariantSetSpec baseType)
			: this(SdfPINVOKE.new_SdfVariantSetSpecHandle__SWIG_1(SdfVariantSetSpec.getCPtr(baseType)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfVariantSetSpecHandle(SdfVariantSetSpecHandle otherHandle)
			: this(SdfPINVOKE.new_SdfVariantSetSpecHandle__SWIG_2(getCPtr(otherHandle)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfVariantSetSpec __deref__()
		{
			IntPtr intPtr = SdfPINVOKE.SdfVariantSetSpecHandle___deref__(swigCPtr);
			return (intPtr == IntPtr.Zero) ? null : new SdfVariantSetSpec(intPtr, cMemoryOwn: false);
		}

		public SdfVariantSetSpecHandle New(SdfPrimSpecHandle prim, string name)
		{
			SdfVariantSetSpecHandle result = new SdfVariantSetSpecHandle(SdfPINVOKE.SdfVariantSetSpecHandle_New__SWIG_0(swigCPtr, SdfPrimSpecHandle.getCPtr(prim), name), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfVariantSetSpecHandle New(SdfVariantSpecHandle prim, string name)
		{
			SdfVariantSetSpecHandle result = new SdfVariantSetSpecHandle(SdfPINVOKE.SdfVariantSetSpecHandle_New__SWIG_1(swigCPtr, SdfVariantSpecHandle.getCPtr(prim), name), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string GetName()
		{
			return SdfPINVOKE.SdfVariantSetSpecHandle_GetName(swigCPtr);
		}

		public TfToken GetNameToken()
		{
			return new TfToken(SdfPINVOKE.SdfVariantSetSpecHandle_GetNameToken(swigCPtr), cMemoryOwn: true);
		}

		public SdfSpecHandle GetOwner()
		{
			return new SdfSpecHandle(SdfPINVOKE.SdfVariantSetSpecHandle_GetOwner(swigCPtr), cMemoryOwn: true);
		}

		public SWIGTYPE_p_SdfVariantView GetVariants()
		{
			return new SWIGTYPE_p_SdfVariantView(SdfPINVOKE.SdfVariantSetSpecHandle_GetVariants(swigCPtr), futureUse: true);
		}

		public SdfVariantSpecHandleVector GetVariantList()
		{
			return new SdfVariantSpecHandleVector(SdfPINVOKE.SdfVariantSetSpecHandle_GetVariantList(swigCPtr), cMemoryOwn: true);
		}

		public void RemoveVariant(SdfVariantSpecHandle variant)
		{
			SdfPINVOKE.SdfVariantSetSpecHandle_RemoveVariant(swigCPtr, SdfVariantSpecHandle.getCPtr(variant));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SWIGTYPE_p_SdfSchemaBase GetSchema()
		{
			return new SWIGTYPE_p_SdfSchemaBase(SdfPINVOKE.SdfVariantSetSpecHandle_GetSchema(swigCPtr), futureUse: false);
		}

		public SdfSpecType GetSpecType()
		{
			return (SdfSpecType)SdfPINVOKE.SdfVariantSetSpecHandle_GetSpecType(swigCPtr);
		}

		public bool IsDormant()
		{
			return SdfPINVOKE.SdfVariantSetSpecHandle_IsDormant(swigCPtr);
		}

		public SdfLayerHandle GetLayer()
		{
			return new SdfLayerHandle(SdfPINVOKE.SdfVariantSetSpecHandle_GetLayer(swigCPtr), cMemoryOwn: true);
		}

		public SdfPath GetPath()
		{
			return new SdfPath(SdfPINVOKE.SdfVariantSetSpecHandle_GetPath(swigCPtr), cMemoryOwn: true);
		}

		public bool PermissionToEdit()
		{
			return SdfPINVOKE.SdfVariantSetSpecHandle_PermissionToEdit(swigCPtr);
		}

		public TfTokenVector ListInfoKeys()
		{
			return new TfTokenVector(SdfPINVOKE.SdfVariantSetSpecHandle_ListInfoKeys(swigCPtr), cMemoryOwn: true);
		}

		public TfTokenVector GetMetaDataInfoKeys()
		{
			return new TfTokenVector(SdfPINVOKE.SdfVariantSetSpecHandle_GetMetaDataInfoKeys(swigCPtr), cMemoryOwn: true);
		}

		public TfToken GetMetaDataDisplayGroup(TfToken key)
		{
			TfToken result = new TfToken(SdfPINVOKE.SdfVariantSetSpecHandle_GetMetaDataDisplayGroup(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetInfo(TfToken key)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfVariantSetSpecHandle_GetInfo(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetInfo(TfToken key, VtValue value)
		{
			SdfPINVOKE.SdfVariantSetSpecHandle_SetInfo(swigCPtr, TfToken.getCPtr(key), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetInfoDictionaryValue(TfToken dictionaryKey, TfToken entryKey, VtValue value)
		{
			SdfPINVOKE.SdfVariantSetSpecHandle_SetInfoDictionaryValue(swigCPtr, TfToken.getCPtr(dictionaryKey), TfToken.getCPtr(entryKey), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasInfo(TfToken key)
		{
			bool result = SdfPINVOKE.SdfVariantSetSpecHandle_HasInfo(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void ClearInfo(TfToken key)
		{
			SdfPINVOKE.SdfVariantSetSpecHandle_ClearInfo(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public TfType GetTypeForInfo(TfToken key)
		{
			TfType result = new TfType(SdfPINVOKE.SdfVariantSetSpecHandle_GetTypeForInfo(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetFallbackForInfo(TfToken key)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfVariantSetSpecHandle_GetFallbackForInfo(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsInert(bool ignoreChildren)
		{
			return SdfPINVOKE.SdfVariantSetSpecHandle_IsInert__SWIG_0(swigCPtr, ignoreChildren);
		}

		public bool IsInert()
		{
			return SdfPINVOKE.SdfVariantSetSpecHandle_IsInert__SWIG_1(swigCPtr);
		}

		public TfTokenVector ListFields()
		{
			return new TfTokenVector(SdfPINVOKE.SdfVariantSetSpecHandle_ListFields(swigCPtr), cMemoryOwn: true);
		}

		public bool HasField(TfToken name)
		{
			bool result = SdfPINVOKE.SdfVariantSetSpecHandle_HasField(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetField(TfToken name)
		{
			VtValue result = new VtValue(SdfPINVOKE.SdfVariantSetSpecHandle_GetField(swigCPtr, TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetField(TfToken name, VtValue value)
		{
			bool result = SdfPINVOKE.SdfVariantSetSpecHandle_SetField(swigCPtr, TfToken.getCPtr(name), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ClearField(TfToken name)
		{
			bool result = SdfPINVOKE.SdfVariantSetSpecHandle_ClearField(swigCPtr, TfToken.getCPtr(name));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
