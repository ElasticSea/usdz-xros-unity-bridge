using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfAttributeSpec : SdfPropertySpec
	{
		private HandleRef swigCPtr;

		public SdfAttributeSpec(IntPtr cPtr, bool cMemoryOwn)
			: base(SdfPINVOKE.SdfAttributeSpec_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfAttributeSpec obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfAttributeSpec obj)
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
						SdfPINVOKE.delete_SdfAttributeSpec(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public static SdfAttributeSpecHandle New(SdfPrimSpecHandle owner, string name, SdfValueTypeName typeName, SdfVariability variability, bool custom)
		{
			SdfAttributeSpecHandle result = new SdfAttributeSpecHandle(SdfPINVOKE.SdfAttributeSpec_New__SWIG_0(SdfPrimSpecHandle.getCPtr(owner), name, SdfValueTypeName.getCPtr(typeName), (int)variability, custom), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfAttributeSpecHandle New(SdfPrimSpecHandle owner, string name, SdfValueTypeName typeName, SdfVariability variability)
		{
			SdfAttributeSpecHandle result = new SdfAttributeSpecHandle(SdfPINVOKE.SdfAttributeSpec_New__SWIG_1(SdfPrimSpecHandle.getCPtr(owner), name, SdfValueTypeName.getCPtr(typeName), (int)variability), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SdfAttributeSpecHandle New(SdfPrimSpecHandle owner, string name, SdfValueTypeName typeName)
		{
			SdfAttributeSpecHandle result = new SdfAttributeSpecHandle(SdfPINVOKE.SdfAttributeSpec_New__SWIG_2(SdfPrimSpecHandle.getCPtr(owner), name, SdfValueTypeName.getCPtr(typeName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_SdfConnectionsProxy GetConnectionPathList()
		{
			return new SWIGTYPE_p_SdfConnectionsProxy(SdfPINVOKE.SdfAttributeSpec_GetConnectionPathList(swigCPtr), futureUse: true);
		}

		public bool HasConnectionPaths()
		{
			return SdfPINVOKE.SdfAttributeSpec_HasConnectionPaths(swigCPtr);
		}

		public void ClearConnectionPaths()
		{
			SdfPINVOKE.SdfAttributeSpec_ClearConnectionPaths(swigCPtr);
		}

		public VtTokenArray GetAllowedTokens()
		{
			return new VtTokenArray(SdfPINVOKE.SdfAttributeSpec_GetAllowedTokens(swigCPtr), cMemoryOwn: true);
		}

		public void SetAllowedTokens(VtTokenArray allowedTokens)
		{
			SdfPINVOKE.SdfAttributeSpec_SetAllowedTokens(swigCPtr, VtTokenArray.getCPtr(allowedTokens));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasAllowedTokens()
		{
			return SdfPINVOKE.SdfAttributeSpec_HasAllowedTokens(swigCPtr);
		}

		public void ClearAllowedTokens()
		{
			SdfPINVOKE.SdfAttributeSpec_ClearAllowedTokens(swigCPtr);
		}

		public TfEnum GetDisplayUnit()
		{
			return new TfEnum(SdfPINVOKE.SdfAttributeSpec_GetDisplayUnit(swigCPtr), cMemoryOwn: true);
		}

		public void SetDisplayUnit(TfEnum displayUnit)
		{
			SdfPINVOKE.SdfAttributeSpec_SetDisplayUnit(swigCPtr, TfEnum.getCPtr(displayUnit));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasDisplayUnit()
		{
			return SdfPINVOKE.SdfAttributeSpec_HasDisplayUnit(swigCPtr);
		}

		public void ClearDisplayUnit()
		{
			SdfPINVOKE.SdfAttributeSpec_ClearDisplayUnit(swigCPtr);
		}

		public TfToken GetColorSpace()
		{
			return new TfToken(SdfPINVOKE.SdfAttributeSpec_GetColorSpace(swigCPtr), cMemoryOwn: true);
		}

		public void SetColorSpace(TfToken colorSpace)
		{
			SdfPINVOKE.SdfAttributeSpec_SetColorSpace(swigCPtr, TfToken.getCPtr(colorSpace));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasColorSpace()
		{
			return SdfPINVOKE.SdfAttributeSpec_HasColorSpace(swigCPtr);
		}

		public void ClearColorSpace()
		{
			SdfPINVOKE.SdfAttributeSpec_ClearColorSpace(swigCPtr);
		}

		public TfToken GetRoleName()
		{
			return new TfToken(SdfPINVOKE.SdfAttributeSpec_GetRoleName(swigCPtr), cMemoryOwn: true);
		}

		public static SdfAttributeSpecHandle New(SdfPrimSpecHandle owner, string name, SdfValueTypeName typeName, bool custom = true)
		{
			return New(owner, name, typeName, SdfVariability.SdfVariabilityVarying, custom);
		}
	}
}
