using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdShadeUtils : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdShadeUtils(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdShadeUtils obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdShadeUtils obj)
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

		~UsdShadeUtils()
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
						UsdShadePINVOKE.delete_UsdShadeUtils(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public static string GetPrefixForAttributeType(UsdShadeAttributeType sourceType)
		{
			return UsdShadePINVOKE.UsdShadeUtils_GetPrefixForAttributeType((int)sourceType);
		}

		public static SdfPath GetConnectedSourcePath(UsdShadeConnectionSourceInfo srcInfo)
		{
			SdfPath result = new SdfPath(UsdShadePINVOKE.UsdShadeUtils_GetConnectedSourcePath(UsdShadeConnectionSourceInfo.getCPtr(srcInfo)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdShadeTokenAttributeTypePair GetBaseNameAndType(TfToken fullName)
		{
			UsdShadeTokenAttributeTypePair result = new UsdShadeTokenAttributeTypePair(UsdShadePINVOKE.UsdShadeUtils_GetBaseNameAndType(TfToken.getCPtr(fullName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static UsdShadeAttributeType GetType(TfToken fullName)
		{
			UsdShadeAttributeType result = (UsdShadeAttributeType)UsdShadePINVOKE.UsdShadeUtils_GetType(TfToken.getCPtr(fullName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfToken GetFullName(TfToken baseName, UsdShadeAttributeType type)
		{
			TfToken result = new TfToken(UsdShadePINVOKE.UsdShadeUtils_GetFullName(TfToken.getCPtr(baseName), (int)type), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SWIGTYPE_p_TfSmallVectorT_UsdAttribute_1_t GetValueProducingAttributes(UsdShadeInput input, bool shaderOutputsOnly)
		{
			SWIGTYPE_p_TfSmallVectorT_UsdAttribute_1_t result = new SWIGTYPE_p_TfSmallVectorT_UsdAttribute_1_t(UsdShadePINVOKE.UsdShadeUtils_GetValueProducingAttributes__SWIG_0(UsdShadeInput.getCPtr(input), shaderOutputsOnly), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SWIGTYPE_p_TfSmallVectorT_UsdAttribute_1_t GetValueProducingAttributes(UsdShadeInput input)
		{
			SWIGTYPE_p_TfSmallVectorT_UsdAttribute_1_t result = new SWIGTYPE_p_TfSmallVectorT_UsdAttribute_1_t(UsdShadePINVOKE.UsdShadeUtils_GetValueProducingAttributes__SWIG_1(UsdShadeInput.getCPtr(input)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SWIGTYPE_p_TfSmallVectorT_UsdAttribute_1_t GetValueProducingAttributes(UsdShadeOutput output, bool shaderOutputsOnly)
		{
			SWIGTYPE_p_TfSmallVectorT_UsdAttribute_1_t result = new SWIGTYPE_p_TfSmallVectorT_UsdAttribute_1_t(UsdShadePINVOKE.UsdShadeUtils_GetValueProducingAttributes__SWIG_2(UsdShadeOutput.getCPtr(output), shaderOutputsOnly), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SWIGTYPE_p_TfSmallVectorT_UsdAttribute_1_t GetValueProducingAttributes(UsdShadeOutput output)
		{
			SWIGTYPE_p_TfSmallVectorT_UsdAttribute_1_t result = new SWIGTYPE_p_TfSmallVectorT_UsdAttribute_1_t(UsdShadePINVOKE.UsdShadeUtils_GetValueProducingAttributes__SWIG_3(UsdShadeOutput.getCPtr(output)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdShadeUtils()
			: this(UsdShadePINVOKE.new_UsdShadeUtils(), cMemoryOwn: true)
		{
		}
	}
}
