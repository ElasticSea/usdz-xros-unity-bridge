using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdObject : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdObject(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdObject obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdObject obj)
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

		~UsdObject()
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
						UsdPINVOKE.delete_UsdObject(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdObject()
			: this(UsdPINVOKE.new_UsdObject(), cMemoryOwn: true)
		{
		}

		public bool IsValid()
		{
			return UsdPINVOKE.UsdObject_IsValid(swigCPtr);
		}

		public UsdStage GetStage()
		{
			IntPtr intPtr = UsdPINVOKE.UsdObject_GetStage(swigCPtr);
			return (intPtr == IntPtr.Zero) ? null : new UsdStage(intPtr, cMemoryOwn: true);
		}

		public SdfPath GetPath()
		{
			return new SdfPath(UsdPINVOKE.UsdObject_GetPath(swigCPtr), cMemoryOwn: true);
		}

		public SdfPath GetPrimPath()
		{
			return new SdfPath(UsdPINVOKE.UsdObject_GetPrimPath(swigCPtr), cMemoryOwn: false);
		}

		public UsdPrim GetPrim()
		{
			return new UsdPrim(UsdPINVOKE.UsdObject_GetPrim(swigCPtr), cMemoryOwn: true);
		}

		public TfToken GetName()
		{
			return new TfToken(UsdPINVOKE.UsdObject_GetName(swigCPtr), cMemoryOwn: false);
		}

		public string GetDescription()
		{
			return UsdPINVOKE.UsdObject_GetDescription(swigCPtr);
		}

		public bool SetMetadata(TfToken key, VtValue value)
		{
			bool result = UsdPINVOKE.UsdObject_SetMetadata(swigCPtr, TfToken.getCPtr(key), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ClearMetadata(TfToken key)
		{
			bool result = UsdPINVOKE.UsdObject_ClearMetadata(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasMetadata(TfToken key)
		{
			bool result = UsdPINVOKE.UsdObject_HasMetadata(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasAuthoredMetadata(TfToken key)
		{
			bool result = UsdPINVOKE.UsdObject_HasAuthoredMetadata(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetMetadataByDictKey(TfToken key, TfToken keyPath, VtValue value)
		{
			bool result = UsdPINVOKE.UsdObject_SetMetadataByDictKey(swigCPtr, TfToken.getCPtr(key), TfToken.getCPtr(keyPath), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ClearMetadataByDictKey(TfToken key, TfToken keyPath)
		{
			bool result = UsdPINVOKE.UsdObject_ClearMetadataByDictKey(swigCPtr, TfToken.getCPtr(key), TfToken.getCPtr(keyPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasMetadataDictKey(TfToken key, TfToken keyPath)
		{
			bool result = UsdPINVOKE.UsdObject_HasMetadataDictKey(swigCPtr, TfToken.getCPtr(key), TfToken.getCPtr(keyPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasAuthoredMetadataDictKey(TfToken key, TfToken keyPath)
		{
			bool result = UsdPINVOKE.UsdObject_HasAuthoredMetadataDictKey(swigCPtr, TfToken.getCPtr(key), TfToken.getCPtr(keyPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdMetadataValueMap GetAllMetadata()
		{
			return new UsdMetadataValueMap(UsdPINVOKE.UsdObject_GetAllMetadata(swigCPtr), cMemoryOwn: true);
		}

		public UsdMetadataValueMap GetAllAuthoredMetadata()
		{
			return new UsdMetadataValueMap(UsdPINVOKE.UsdObject_GetAllAuthoredMetadata(swigCPtr), cMemoryOwn: true);
		}

		public bool IsHidden()
		{
			return UsdPINVOKE.UsdObject_IsHidden(swigCPtr);
		}

		public bool SetHidden(bool hidden)
		{
			return UsdPINVOKE.UsdObject_SetHidden(swigCPtr, hidden);
		}

		public bool ClearHidden()
		{
			return UsdPINVOKE.UsdObject_ClearHidden(swigCPtr);
		}

		public bool HasAuthoredHidden()
		{
			return UsdPINVOKE.UsdObject_HasAuthoredHidden(swigCPtr);
		}

		public VtDictionary GetCustomData()
		{
			return new VtDictionary(UsdPINVOKE.UsdObject_GetCustomData(swigCPtr), cMemoryOwn: true);
		}

		public VtValue GetCustomDataByKey(TfToken keyPath)
		{
			VtValue result = new VtValue(UsdPINVOKE.UsdObject_GetCustomDataByKey(swigCPtr, TfToken.getCPtr(keyPath)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetCustomData(VtDictionary customData)
		{
			UsdPINVOKE.UsdObject_SetCustomData(swigCPtr, VtDictionary.getCPtr(customData));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetCustomDataByKey(TfToken keyPath, VtValue value)
		{
			UsdPINVOKE.UsdObject_SetCustomDataByKey(swigCPtr, TfToken.getCPtr(keyPath), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void ClearCustomData()
		{
			UsdPINVOKE.UsdObject_ClearCustomData(swigCPtr);
		}

		public void ClearCustomDataByKey(TfToken keyPath)
		{
			UsdPINVOKE.UsdObject_ClearCustomDataByKey(swigCPtr, TfToken.getCPtr(keyPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasCustomData()
		{
			return UsdPINVOKE.UsdObject_HasCustomData(swigCPtr);
		}

		public bool HasCustomDataKey(TfToken keyPath)
		{
			bool result = UsdPINVOKE.UsdObject_HasCustomDataKey(swigCPtr, TfToken.getCPtr(keyPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasAuthoredCustomData()
		{
			return UsdPINVOKE.UsdObject_HasAuthoredCustomData(swigCPtr);
		}

		public bool HasAuthoredCustomDataKey(TfToken keyPath)
		{
			bool result = UsdPINVOKE.UsdObject_HasAuthoredCustomDataKey(swigCPtr, TfToken.getCPtr(keyPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtDictionary GetAssetInfo()
		{
			return new VtDictionary(UsdPINVOKE.UsdObject_GetAssetInfo(swigCPtr), cMemoryOwn: true);
		}

		public VtValue GetAssetInfoByKey(TfToken keyPath)
		{
			VtValue result = new VtValue(UsdPINVOKE.UsdObject_GetAssetInfoByKey(swigCPtr, TfToken.getCPtr(keyPath)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetAssetInfo(VtDictionary customData)
		{
			UsdPINVOKE.UsdObject_SetAssetInfo(swigCPtr, VtDictionary.getCPtr(customData));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetAssetInfoByKey(TfToken keyPath, VtValue value)
		{
			UsdPINVOKE.UsdObject_SetAssetInfoByKey(swigCPtr, TfToken.getCPtr(keyPath), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void ClearAssetInfo()
		{
			UsdPINVOKE.UsdObject_ClearAssetInfo(swigCPtr);
		}

		public void ClearAssetInfoByKey(TfToken keyPath)
		{
			UsdPINVOKE.UsdObject_ClearAssetInfoByKey(swigCPtr, TfToken.getCPtr(keyPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasAssetInfo()
		{
			return UsdPINVOKE.UsdObject_HasAssetInfo(swigCPtr);
		}

		public bool HasAssetInfoKey(TfToken keyPath)
		{
			bool result = UsdPINVOKE.UsdObject_HasAssetInfoKey(swigCPtr, TfToken.getCPtr(keyPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasAuthoredAssetInfo()
		{
			return UsdPINVOKE.UsdObject_HasAuthoredAssetInfo(swigCPtr);
		}

		public bool HasAuthoredAssetInfoKey(TfToken keyPath)
		{
			bool result = UsdPINVOKE.UsdObject_HasAuthoredAssetInfoKey(swigCPtr, TfToken.getCPtr(keyPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public string GetDocumentation()
		{
			return UsdPINVOKE.UsdObject_GetDocumentation(swigCPtr);
		}

		public bool SetDocumentation(string doc)
		{
			bool result = UsdPINVOKE.UsdObject_SetDocumentation(swigCPtr, doc);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ClearDocumentation()
		{
			return UsdPINVOKE.UsdObject_ClearDocumentation(swigCPtr);
		}

		public bool HasAuthoredDocumentation()
		{
			return UsdPINVOKE.UsdObject_HasAuthoredDocumentation(swigCPtr);
		}

		public string GetDisplayName()
		{
			return UsdPINVOKE.UsdObject_GetDisplayName(swigCPtr);
		}

		public bool SetDisplayName(string name)
		{
			bool result = UsdPINVOKE.UsdObject_SetDisplayName(swigCPtr, name);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ClearDisplayName()
		{
			return UsdPINVOKE.UsdObject_ClearDisplayName(swigCPtr);
		}

		public bool HasAuthoredDisplayName()
		{
			return UsdPINVOKE.UsdObject_HasAuthoredDisplayName(swigCPtr);
		}

		public static char GetNamespaceDelimiter()
		{
			return UsdPINVOKE.UsdObject_GetNamespaceDelimiter();
		}

		public static bool Equals(UsdObject lhs, UsdObject rhs)
		{
			bool result = UsdPINVOKE.UsdObject_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(UsdObject lhs, UsdObject rhs)
		{
			bool flag = (object)lhs == null;
			bool flag2 = (object)rhs == null;
			if (flag == flag2)
			{
				if (!(flag && flag2))
				{
					return Equals(lhs, rhs);
				}
				return true;
			}
			return false;
		}

		public static bool operator !=(UsdObject lhs, UsdObject rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as UsdObject);
		}

		public override int GetHashCode()
		{
			return UsdPINVOKE.UsdObject_GetHashCode(swigCPtr);
		}

		private bool _IsValid()
		{
			return UsdPINVOKE.UsdObject__IsValid(swigCPtr);
		}

		public static implicit operator bool(UsdObject obj)
		{
			return obj._IsValid();
		}

		public VtValue GetMetadata(TfToken key)
		{
			VtValue result = new VtValue(UsdPINVOKE.UsdObject_GetMetadata(swigCPtr, TfToken.getCPtr(key)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetMetadataByDictKey(TfToken key, TfToken keyPath)
		{
			VtValue result = new VtValue(UsdPINVOKE.UsdObject_GetMetadataByDictKey(swigCPtr, TfToken.getCPtr(key), TfToken.getCPtr(keyPath)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
