using System;
using System.Runtime.InteropServices;

namespace pxr
{
	internal class UsdRiPINVOKE
	{
		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			[DllImport(UsdDll.USD_EXPORT_NAME)]
			public static extern void SWIGRegisterStringCallback_UsdRi(SWIGStringDelegate stringDelegate);

			[MonoPInvokeCallback]
			private static string CreateString(string cString)
			{
				return cString;
			}

			static SWIGStringHelper()
			{
				stringDelegate = CreateString;
				SWIGRegisterStringCallback_UsdRi(stringDelegate);
			}
		}

		public class SWIGPendingException : UsdCsPINVOKE.SWIGPendingException
		{
		}

		protected static SWIGStringHelper swigStringHelper;

		static UsdRiPINVOKE()
		{
			swigStringHelper = new SWIGStringHelper();
		}

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdRiMaterialAPI__SWIG_0")]
		public static extern IntPtr new_UsdRiMaterialAPI__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdRiMaterialAPI__SWIG_1")]
		public static extern IntPtr new_UsdRiMaterialAPI__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdRiMaterialAPI__SWIG_2")]
		public static extern IntPtr new_UsdRiMaterialAPI__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdRiMaterialAPI")]
		public static extern void delete_UsdRiMaterialAPI(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdRiMaterialAPI_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdRiMaterialAPI_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_Get")]
		public static extern IntPtr UsdRiMaterialAPI_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_CanApply__SWIG_0")]
		public static extern bool UsdRiMaterialAPI_CanApply__SWIG_0(HandleRef jarg1, out string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_CanApply__SWIG_1")]
		public static extern bool UsdRiMaterialAPI_CanApply__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_Apply")]
		public static extern IntPtr UsdRiMaterialAPI_Apply(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_GetSurfaceAttr")]
		public static extern IntPtr UsdRiMaterialAPI_GetSurfaceAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_CreateSurfaceAttr__SWIG_0")]
		public static extern IntPtr UsdRiMaterialAPI_CreateSurfaceAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_CreateSurfaceAttr__SWIG_1")]
		public static extern IntPtr UsdRiMaterialAPI_CreateSurfaceAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_CreateSurfaceAttr__SWIG_2")]
		public static extern IntPtr UsdRiMaterialAPI_CreateSurfaceAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_GetDisplacementAttr")]
		public static extern IntPtr UsdRiMaterialAPI_GetDisplacementAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_CreateDisplacementAttr__SWIG_0")]
		public static extern IntPtr UsdRiMaterialAPI_CreateDisplacementAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_CreateDisplacementAttr__SWIG_1")]
		public static extern IntPtr UsdRiMaterialAPI_CreateDisplacementAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_CreateDisplacementAttr__SWIG_2")]
		public static extern IntPtr UsdRiMaterialAPI_CreateDisplacementAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_GetVolumeAttr")]
		public static extern IntPtr UsdRiMaterialAPI_GetVolumeAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_CreateVolumeAttr__SWIG_0")]
		public static extern IntPtr UsdRiMaterialAPI_CreateVolumeAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_CreateVolumeAttr__SWIG_1")]
		public static extern IntPtr UsdRiMaterialAPI_CreateVolumeAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_CreateVolumeAttr__SWIG_2")]
		public static extern IntPtr UsdRiMaterialAPI_CreateVolumeAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdRiMaterialAPI__SWIG_3")]
		public static extern IntPtr new_UsdRiMaterialAPI__SWIG_3(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_GetSurfaceOutput")]
		public static extern IntPtr UsdRiMaterialAPI_GetSurfaceOutput(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_GetDisplacementOutput")]
		public static extern IntPtr UsdRiMaterialAPI_GetDisplacementOutput(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_GetVolumeOutput")]
		public static extern IntPtr UsdRiMaterialAPI_GetVolumeOutput(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_SetSurfaceSource")]
		public static extern bool UsdRiMaterialAPI_SetSurfaceSource(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_SetDisplacementSource")]
		public static extern bool UsdRiMaterialAPI_SetDisplacementSource(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_SetVolumeSource")]
		public static extern bool UsdRiMaterialAPI_SetVolumeSource(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_GetSurface__SWIG_0")]
		public static extern IntPtr UsdRiMaterialAPI_GetSurface__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_GetSurface__SWIG_1")]
		public static extern IntPtr UsdRiMaterialAPI_GetSurface__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_GetDisplacement__SWIG_0")]
		public static extern IntPtr UsdRiMaterialAPI_GetDisplacement__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_GetDisplacement__SWIG_1")]
		public static extern IntPtr UsdRiMaterialAPI_GetDisplacement__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_GetVolume__SWIG_0")]
		public static extern IntPtr UsdRiMaterialAPI_GetVolume__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_GetVolume__SWIG_1")]
		public static extern IntPtr UsdRiMaterialAPI_GetVolume__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_ComputeInterfaceInputConsumersMap__SWIG_0")]
		public static extern IntPtr UsdRiMaterialAPI_ComputeInterfaceInputConsumersMap__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_ComputeInterfaceInputConsumersMap__SWIG_1")]
		public static extern IntPtr UsdRiMaterialAPI_ComputeInterfaceInputConsumersMap__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiConvertToRManInterpolateBoundary")]
		public static extern int UsdRiConvertToRManInterpolateBoundary(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiConvertFromRManInterpolateBoundary")]
		public static extern IntPtr UsdRiConvertFromRManInterpolateBoundary(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiConvertToRManFaceVaryingLinearInterpolation")]
		public static extern int UsdRiConvertToRManFaceVaryingLinearInterpolation(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiConvertFromRManFaceVaryingLinearInterpolation")]
		public static extern IntPtr UsdRiConvertFromRManFaceVaryingLinearInterpolation(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiConvertToRManTriangleSubdivisionRule")]
		public static extern int UsdRiConvertToRManTriangleSubdivisionRule(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiConvertFromRManTriangleSubdivisionRule")]
		public static extern IntPtr UsdRiConvertFromRManTriangleSubdivisionRule(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdRiSplineAPI__SWIG_0")]
		public static extern IntPtr new_UsdRiSplineAPI__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdRiSplineAPI__SWIG_1")]
		public static extern IntPtr new_UsdRiSplineAPI__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdRiSplineAPI__SWIG_2")]
		public static extern IntPtr new_UsdRiSplineAPI__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdRiSplineAPI")]
		public static extern void delete_UsdRiSplineAPI(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiSplineAPI_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdRiSplineAPI_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiSplineAPI_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdRiSplineAPI_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiSplineAPI_CanApply__SWIG_0")]
		public static extern bool UsdRiSplineAPI_CanApply__SWIG_0(HandleRef jarg1, out string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiSplineAPI_CanApply__SWIG_1")]
		public static extern bool UsdRiSplineAPI_CanApply__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdRiSplineAPI__SWIG_3")]
		public static extern IntPtr new_UsdRiSplineAPI__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdRiSplineAPI__SWIG_4")]
		public static extern IntPtr new_UsdRiSplineAPI__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiSplineAPI_DoesDuplicateBSplineEndpoints")]
		public static extern bool UsdRiSplineAPI_DoesDuplicateBSplineEndpoints(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiSplineAPI_GetValuesTypeName")]
		public static extern IntPtr UsdRiSplineAPI_GetValuesTypeName(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiSplineAPI_GetInterpolationAttr")]
		public static extern IntPtr UsdRiSplineAPI_GetInterpolationAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiSplineAPI_CreateInterpolationAttr__SWIG_0")]
		public static extern IntPtr UsdRiSplineAPI_CreateInterpolationAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiSplineAPI_CreateInterpolationAttr__SWIG_1")]
		public static extern IntPtr UsdRiSplineAPI_CreateInterpolationAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiSplineAPI_CreateInterpolationAttr__SWIG_2")]
		public static extern IntPtr UsdRiSplineAPI_CreateInterpolationAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiSplineAPI_GetPositionsAttr")]
		public static extern IntPtr UsdRiSplineAPI_GetPositionsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiSplineAPI_CreatePositionsAttr__SWIG_0")]
		public static extern IntPtr UsdRiSplineAPI_CreatePositionsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiSplineAPI_CreatePositionsAttr__SWIG_1")]
		public static extern IntPtr UsdRiSplineAPI_CreatePositionsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiSplineAPI_CreatePositionsAttr__SWIG_2")]
		public static extern IntPtr UsdRiSplineAPI_CreatePositionsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiSplineAPI_GetValuesAttr")]
		public static extern IntPtr UsdRiSplineAPI_GetValuesAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiSplineAPI_CreateValuesAttr__SWIG_0")]
		public static extern IntPtr UsdRiSplineAPI_CreateValuesAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiSplineAPI_CreateValuesAttr__SWIG_1")]
		public static extern IntPtr UsdRiSplineAPI_CreateValuesAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiSplineAPI_CreateValuesAttr__SWIG_2")]
		public static extern IntPtr UsdRiSplineAPI_CreateValuesAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiSplineAPI_Validate")]
		public static extern bool UsdRiSplineAPI_Validate(HandleRef jarg1, out string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdRiStatementsAPI__SWIG_0")]
		public static extern IntPtr new_UsdRiStatementsAPI__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdRiStatementsAPI__SWIG_1")]
		public static extern IntPtr new_UsdRiStatementsAPI__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdRiStatementsAPI__SWIG_2")]
		public static extern IntPtr new_UsdRiStatementsAPI__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdRiStatementsAPI")]
		public static extern void delete_UsdRiStatementsAPI(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdRiStatementsAPI_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdRiStatementsAPI_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_Get")]
		public static extern IntPtr UsdRiStatementsAPI_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_CanApply__SWIG_0")]
		public static extern bool UsdRiStatementsAPI_CanApply__SWIG_0(HandleRef jarg1, out string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_CanApply__SWIG_1")]
		public static extern bool UsdRiStatementsAPI_CanApply__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_Apply")]
		public static extern IntPtr UsdRiStatementsAPI_Apply(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_CreateRiAttribute__SWIG_0")]
		public static extern IntPtr UsdRiStatementsAPI_CreateRiAttribute__SWIG_0(HandleRef jarg1, HandleRef jarg2, string jarg3, string jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_CreateRiAttribute__SWIG_1")]
		public static extern IntPtr UsdRiStatementsAPI_CreateRiAttribute__SWIG_1(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_CreateRiAttribute__SWIG_2")]
		public static extern IntPtr UsdRiStatementsAPI_CreateRiAttribute__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, string jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_CreateRiAttribute__SWIG_3")]
		public static extern IntPtr UsdRiStatementsAPI_CreateRiAttribute__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_GetRiAttribute__SWIG_0")]
		public static extern IntPtr UsdRiStatementsAPI_GetRiAttribute__SWIG_0(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_GetRiAttribute__SWIG_1")]
		public static extern IntPtr UsdRiStatementsAPI_GetRiAttribute__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_GetRiAttributes__SWIG_0")]
		public static extern IntPtr UsdRiStatementsAPI_GetRiAttributes__SWIG_0(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_GetRiAttributes__SWIG_1")]
		public static extern IntPtr UsdRiStatementsAPI_GetRiAttributes__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_GetRiAttributeName")]
		public static extern IntPtr UsdRiStatementsAPI_GetRiAttributeName(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_GetRiAttributeNameSpace")]
		public static extern IntPtr UsdRiStatementsAPI_GetRiAttributeNameSpace(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_IsRiAttribute")]
		public static extern bool UsdRiStatementsAPI_IsRiAttribute(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_MakeRiAttributePropertyName")]
		public static extern string UsdRiStatementsAPI_MakeRiAttributePropertyName(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_SetCoordinateSystem")]
		public static extern void UsdRiStatementsAPI_SetCoordinateSystem(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_GetCoordinateSystem")]
		public static extern string UsdRiStatementsAPI_GetCoordinateSystem(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_HasCoordinateSystem")]
		public static extern bool UsdRiStatementsAPI_HasCoordinateSystem(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_SetScopedCoordinateSystem")]
		public static extern void UsdRiStatementsAPI_SetScopedCoordinateSystem(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_GetScopedCoordinateSystem")]
		public static extern string UsdRiStatementsAPI_GetScopedCoordinateSystem(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_HasScopedCoordinateSystem")]
		public static extern bool UsdRiStatementsAPI_HasScopedCoordinateSystem(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_GetModelCoordinateSystems")]
		public static extern bool UsdRiStatementsAPI_GetModelCoordinateSystems(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_GetModelScopedCoordinateSystems")]
		public static extern bool UsdRiStatementsAPI_GetModelScopedCoordinateSystems(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiMaterialAPI_SWIGUpcast")]
		public static extern IntPtr UsdRiMaterialAPI_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiSplineAPI_SWIGUpcast")]
		public static extern IntPtr UsdRiSplineAPI_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdRiStatementsAPI_SWIGUpcast")]
		public static extern IntPtr UsdRiStatementsAPI_SWIGUpcast(IntPtr jarg1);
	}
}
