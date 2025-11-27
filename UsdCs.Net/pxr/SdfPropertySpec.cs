using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfPropertySpec : SdfSpec
	{
		private HandleRef swigCPtr;

		public SdfPropertySpec(IntPtr cPtr, bool cMemoryOwn)
			: base(SdfPINVOKE.SdfPropertySpec_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfPropertySpec obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfPropertySpec obj)
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
						SdfPINVOKE.delete_SdfPropertySpec(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public string GetName()
		{
			return SdfPINVOKE.SdfPropertySpec_GetName(swigCPtr);
		}

		public TfToken GetNameToken()
		{
			return new TfToken(SdfPINVOKE.SdfPropertySpec_GetNameToken(swigCPtr), cMemoryOwn: true);
		}

		public bool CanSetName(string newName, out string whyNot)
		{
			bool result = SdfPINVOKE.SdfPropertySpec_CanSetName(swigCPtr, newName, out whyNot);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetName(string newName, bool validate)
		{
			bool result = SdfPINVOKE.SdfPropertySpec_SetName__SWIG_0(swigCPtr, newName, validate);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetName(string newName)
		{
			bool result = SdfPINVOKE.SdfPropertySpec_SetName__SWIG_1(swigCPtr, newName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IsValidName(string name)
		{
			bool result = SdfPINVOKE.SdfPropertySpec_IsValidName(name);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfSpecHandle GetOwner()
		{
			return new SdfSpecHandle(SdfPINVOKE.SdfPropertySpec_GetOwner(swigCPtr), cMemoryOwn: true);
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetCustomData()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfPropertySpec_GetCustomData(swigCPtr), futureUse: true);
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetAssetInfo()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfPropertySpec_GetAssetInfo(swigCPtr), futureUse: true);
		}

		public void SetCustomData(string name, VtValue value)
		{
			SdfPINVOKE.SdfPropertySpec_SetCustomData(swigCPtr, name, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetAssetInfo(string name, VtValue value)
		{
			SdfPINVOKE.SdfPropertySpec_SetAssetInfo(swigCPtr, name, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetDisplayGroup()
		{
			return SdfPINVOKE.SdfPropertySpec_GetDisplayGroup(swigCPtr);
		}

		public void SetDisplayGroup(string value)
		{
			SdfPINVOKE.SdfPropertySpec_SetDisplayGroup(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetDisplayName()
		{
			return SdfPINVOKE.SdfPropertySpec_GetDisplayName(swigCPtr);
		}

		public void SetDisplayName(string value)
		{
			SdfPINVOKE.SdfPropertySpec_SetDisplayName(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetDocumentation()
		{
			return SdfPINVOKE.SdfPropertySpec_GetDocumentation(swigCPtr);
		}

		public void SetDocumentation(string value)
		{
			SdfPINVOKE.SdfPropertySpec_SetDocumentation(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool GetHidden()
		{
			return SdfPINVOKE.SdfPropertySpec_GetHidden(swigCPtr);
		}

		public void SetHidden(bool value)
		{
			SdfPINVOKE.SdfPropertySpec_SetHidden(swigCPtr, value);
		}

		public SdfPermission GetPermission()
		{
			return (SdfPermission)SdfPINVOKE.SdfPropertySpec_GetPermission(swigCPtr);
		}

		public void SetPermission(SdfPermission value)
		{
			SdfPINVOKE.SdfPropertySpec_SetPermission(swigCPtr, (int)value);
		}

		public string GetPrefix()
		{
			return SdfPINVOKE.SdfPropertySpec_GetPrefix(swigCPtr);
		}

		public void SetPrefix(string value)
		{
			SdfPINVOKE.SdfPropertySpec_SetPrefix(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetSuffix()
		{
			return SdfPINVOKE.SdfPropertySpec_GetSuffix(swigCPtr);
		}

		public void SetSuffix(string value)
		{
			SdfPINVOKE.SdfPropertySpec_SetSuffix(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public string GetSymmetricPeer()
		{
			return SdfPINVOKE.SdfPropertySpec_GetSymmetricPeer(swigCPtr);
		}

		public void SetSymmetricPeer(string peerName)
		{
			SdfPINVOKE.SdfPropertySpec_SetSymmetricPeer(swigCPtr, peerName);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SWIGTYPE_p_SdfDictionaryProxy GetSymmetryArguments()
		{
			return new SWIGTYPE_p_SdfDictionaryProxy(SdfPINVOKE.SdfPropertySpec_GetSymmetryArguments(swigCPtr), futureUse: true);
		}

		public void SetSymmetryArgument(string name, VtValue value)
		{
			SdfPINVOKE.SdfPropertySpec_SetSymmetryArgument(swigCPtr, name, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public TfToken GetSymmetryFunction()
		{
			return new TfToken(SdfPINVOKE.SdfPropertySpec_GetSymmetryFunction(swigCPtr), cMemoryOwn: true);
		}

		public void SetSymmetryFunction(TfToken functionName)
		{
			SdfPINVOKE.SdfPropertySpec_SetSymmetryFunction(swigCPtr, TfToken.getCPtr(functionName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SWIGTYPE_p_std__mapT_double_VtValue_std__lessT_double_t_t GetTimeSampleMap()
		{
			return new SWIGTYPE_p_std__mapT_double_VtValue_std__lessT_double_t_t(SdfPINVOKE.SdfPropertySpec_GetTimeSampleMap(swigCPtr), futureUse: true);
		}

		public TfType GetValueType()
		{
			return new TfType(SdfPINVOKE.SdfPropertySpec_GetValueType(swigCPtr), cMemoryOwn: true);
		}

		public SdfValueTypeName GetTypeName()
		{
			return new SdfValueTypeName(SdfPINVOKE.SdfPropertySpec_GetTypeName(swigCPtr), cMemoryOwn: true);
		}

		private VtValue GetDefaultValue()
		{
			return new VtValue(SdfPINVOKE.SdfPropertySpec_GetDefaultValue(swigCPtr), cMemoryOwn: true);
		}

		private bool SetDefaultValue(VtValue defaultValue)
		{
			bool result = SdfPINVOKE.SdfPropertySpec_SetDefaultValue(swigCPtr, VtValue.getCPtr(defaultValue));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool HasDefaultValue()
		{
			return SdfPINVOKE.SdfPropertySpec_HasDefaultValue(swigCPtr);
		}

		public void ClearDefaultValue()
		{
			SdfPINVOKE.SdfPropertySpec_ClearDefaultValue(swigCPtr);
		}

		public string GetComment()
		{
			return SdfPINVOKE.SdfPropertySpec_GetComment(swigCPtr);
		}

		public void SetComment(string value)
		{
			SdfPINVOKE.SdfPropertySpec_SetComment(swigCPtr, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsCustom()
		{
			return SdfPINVOKE.SdfPropertySpec_IsCustom(swigCPtr);
		}

		public void SetCustom(bool custom)
		{
			SdfPINVOKE.SdfPropertySpec_SetCustom(swigCPtr, custom);
		}

		public SdfVariability GetVariability()
		{
			return (SdfVariability)SdfPINVOKE.SdfPropertySpec_GetVariability(swigCPtr);
		}

		public bool HasOnlyRequiredFields()
		{
			return SdfPINVOKE.SdfPropertySpec_HasOnlyRequiredFields(swigCPtr);
		}
	}
}
