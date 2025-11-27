using System;
using System.Runtime.InteropServices;

namespace pxr
{
	internal class UsdLuxPINVOKE
	{
		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			[DllImport("UsdCs")]
			public static extern void SWIGRegisterStringCallback_UsdLux(SWIGStringDelegate stringDelegate);

			[MonoPInvokeCallback]
			private static string CreateString(string cString)
			{
				return cString;
			}

			static SWIGStringHelper()
			{
				stringDelegate = CreateString;
				SWIGRegisterStringCallback_UsdLux(stringDelegate);
			}
		}

		public class SWIGPendingException : UsdCsPINVOKE.SWIGPendingException
		{
		}

		protected static SWIGStringHelper swigStringHelper;

		static UsdLuxPINVOKE()
		{
			swigStringHelper = new SWIGStringHelper();
		}

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBlackbodyTemperatureAsRgb")]
		public static extern IntPtr UsdLuxBlackbodyTemperatureAsRgb(float jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxBoundableLightBase__SWIG_0")]
		public static extern IntPtr new_UsdLuxBoundableLightBase__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxBoundableLightBase__SWIG_1")]
		public static extern IntPtr new_UsdLuxBoundableLightBase__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxBoundableLightBase__SWIG_2")]
		public static extern IntPtr new_UsdLuxBoundableLightBase__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdLuxBoundableLightBase")]
		public static extern void delete_UsdLuxBoundableLightBase(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdLuxBoundableLightBase_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdLuxBoundableLightBase_GetSchemaAttributeNames__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_Get")]
		public static extern IntPtr UsdLuxBoundableLightBase_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_LightAPI")]
		public static extern IntPtr UsdLuxBoundableLightBase_LightAPI(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_GetIntensityAttr")]
		public static extern IntPtr UsdLuxBoundableLightBase_GetIntensityAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_CreateIntensityAttr__SWIG_0")]
		public static extern IntPtr UsdLuxBoundableLightBase_CreateIntensityAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_CreateIntensityAttr__SWIG_1")]
		public static extern IntPtr UsdLuxBoundableLightBase_CreateIntensityAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_CreateIntensityAttr__SWIG_2")]
		public static extern IntPtr UsdLuxBoundableLightBase_CreateIntensityAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_GetExposureAttr")]
		public static extern IntPtr UsdLuxBoundableLightBase_GetExposureAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_CreateExposureAttr__SWIG_0")]
		public static extern IntPtr UsdLuxBoundableLightBase_CreateExposureAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_CreateExposureAttr__SWIG_1")]
		public static extern IntPtr UsdLuxBoundableLightBase_CreateExposureAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_CreateExposureAttr__SWIG_2")]
		public static extern IntPtr UsdLuxBoundableLightBase_CreateExposureAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_GetDiffuseAttr")]
		public static extern IntPtr UsdLuxBoundableLightBase_GetDiffuseAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_CreateDiffuseAttr__SWIG_0")]
		public static extern IntPtr UsdLuxBoundableLightBase_CreateDiffuseAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_CreateDiffuseAttr__SWIG_1")]
		public static extern IntPtr UsdLuxBoundableLightBase_CreateDiffuseAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_CreateDiffuseAttr__SWIG_2")]
		public static extern IntPtr UsdLuxBoundableLightBase_CreateDiffuseAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_GetSpecularAttr")]
		public static extern IntPtr UsdLuxBoundableLightBase_GetSpecularAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_CreateSpecularAttr__SWIG_0")]
		public static extern IntPtr UsdLuxBoundableLightBase_CreateSpecularAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_CreateSpecularAttr__SWIG_1")]
		public static extern IntPtr UsdLuxBoundableLightBase_CreateSpecularAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_CreateSpecularAttr__SWIG_2")]
		public static extern IntPtr UsdLuxBoundableLightBase_CreateSpecularAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_GetNormalizeAttr")]
		public static extern IntPtr UsdLuxBoundableLightBase_GetNormalizeAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_CreateNormalizeAttr__SWIG_0")]
		public static extern IntPtr UsdLuxBoundableLightBase_CreateNormalizeAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_CreateNormalizeAttr__SWIG_1")]
		public static extern IntPtr UsdLuxBoundableLightBase_CreateNormalizeAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_CreateNormalizeAttr__SWIG_2")]
		public static extern IntPtr UsdLuxBoundableLightBase_CreateNormalizeAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_GetColorAttr")]
		public static extern IntPtr UsdLuxBoundableLightBase_GetColorAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_CreateColorAttr__SWIG_0")]
		public static extern IntPtr UsdLuxBoundableLightBase_CreateColorAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_CreateColorAttr__SWIG_1")]
		public static extern IntPtr UsdLuxBoundableLightBase_CreateColorAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_CreateColorAttr__SWIG_2")]
		public static extern IntPtr UsdLuxBoundableLightBase_CreateColorAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_GetEnableColorTemperatureAttr")]
		public static extern IntPtr UsdLuxBoundableLightBase_GetEnableColorTemperatureAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_CreateEnableColorTemperatureAttr__SWIG_0")]
		public static extern IntPtr UsdLuxBoundableLightBase_CreateEnableColorTemperatureAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_CreateEnableColorTemperatureAttr__SWIG_1")]
		public static extern IntPtr UsdLuxBoundableLightBase_CreateEnableColorTemperatureAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_CreateEnableColorTemperatureAttr__SWIG_2")]
		public static extern IntPtr UsdLuxBoundableLightBase_CreateEnableColorTemperatureAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_GetColorTemperatureAttr")]
		public static extern IntPtr UsdLuxBoundableLightBase_GetColorTemperatureAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_CreateColorTemperatureAttr__SWIG_0")]
		public static extern IntPtr UsdLuxBoundableLightBase_CreateColorTemperatureAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_CreateColorTemperatureAttr__SWIG_1")]
		public static extern IntPtr UsdLuxBoundableLightBase_CreateColorTemperatureAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_CreateColorTemperatureAttr__SWIG_2")]
		public static extern IntPtr UsdLuxBoundableLightBase_CreateColorTemperatureAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_GetFiltersRel")]
		public static extern IntPtr UsdLuxBoundableLightBase_GetFiltersRel(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_CreateFiltersRel")]
		public static extern IntPtr UsdLuxBoundableLightBase_CreateFiltersRel(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxCylinderLight__SWIG_0")]
		public static extern IntPtr new_UsdLuxCylinderLight__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxCylinderLight__SWIG_1")]
		public static extern IntPtr new_UsdLuxCylinderLight__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxCylinderLight__SWIG_2")]
		public static extern IntPtr new_UsdLuxCylinderLight__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdLuxCylinderLight")]
		public static extern void delete_UsdLuxCylinderLight(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxCylinderLight_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdLuxCylinderLight_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxCylinderLight_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdLuxCylinderLight_GetSchemaAttributeNames__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxCylinderLight_Get")]
		public static extern IntPtr UsdLuxCylinderLight_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxCylinderLight_Define")]
		public static extern IntPtr UsdLuxCylinderLight_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxCylinderLight_GetLengthAttr")]
		public static extern IntPtr UsdLuxCylinderLight_GetLengthAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxCylinderLight_CreateLengthAttr__SWIG_0")]
		public static extern IntPtr UsdLuxCylinderLight_CreateLengthAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxCylinderLight_CreateLengthAttr__SWIG_1")]
		public static extern IntPtr UsdLuxCylinderLight_CreateLengthAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxCylinderLight_CreateLengthAttr__SWIG_2")]
		public static extern IntPtr UsdLuxCylinderLight_CreateLengthAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxCylinderLight_GetRadiusAttr")]
		public static extern IntPtr UsdLuxCylinderLight_GetRadiusAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxCylinderLight_CreateRadiusAttr__SWIG_0")]
		public static extern IntPtr UsdLuxCylinderLight_CreateRadiusAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxCylinderLight_CreateRadiusAttr__SWIG_1")]
		public static extern IntPtr UsdLuxCylinderLight_CreateRadiusAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxCylinderLight_CreateRadiusAttr__SWIG_2")]
		public static extern IntPtr UsdLuxCylinderLight_CreateRadiusAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxCylinderLight_GetTreatAsLineAttr")]
		public static extern IntPtr UsdLuxCylinderLight_GetTreatAsLineAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxCylinderLight_CreateTreatAsLineAttr__SWIG_0")]
		public static extern IntPtr UsdLuxCylinderLight_CreateTreatAsLineAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxCylinderLight_CreateTreatAsLineAttr__SWIG_1")]
		public static extern IntPtr UsdLuxCylinderLight_CreateTreatAsLineAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxCylinderLight_CreateTreatAsLineAttr__SWIG_2")]
		public static extern IntPtr UsdLuxCylinderLight_CreateTreatAsLineAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxDiskLight__SWIG_0")]
		public static extern IntPtr new_UsdLuxDiskLight__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxDiskLight__SWIG_1")]
		public static extern IntPtr new_UsdLuxDiskLight__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxDiskLight__SWIG_2")]
		public static extern IntPtr new_UsdLuxDiskLight__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdLuxDiskLight")]
		public static extern void delete_UsdLuxDiskLight(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDiskLight_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdLuxDiskLight_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDiskLight_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdLuxDiskLight_GetSchemaAttributeNames__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDiskLight_Get")]
		public static extern IntPtr UsdLuxDiskLight_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDiskLight_Define")]
		public static extern IntPtr UsdLuxDiskLight_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDiskLight_GetRadiusAttr")]
		public static extern IntPtr UsdLuxDiskLight_GetRadiusAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDiskLight_CreateRadiusAttr__SWIG_0")]
		public static extern IntPtr UsdLuxDiskLight_CreateRadiusAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDiskLight_CreateRadiusAttr__SWIG_1")]
		public static extern IntPtr UsdLuxDiskLight_CreateRadiusAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDiskLight_CreateRadiusAttr__SWIG_2")]
		public static extern IntPtr UsdLuxDiskLight_CreateRadiusAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxNonboundableLightBase__SWIG_0")]
		public static extern IntPtr new_UsdLuxNonboundableLightBase__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxNonboundableLightBase__SWIG_1")]
		public static extern IntPtr new_UsdLuxNonboundableLightBase__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxNonboundableLightBase__SWIG_2")]
		public static extern IntPtr new_UsdLuxNonboundableLightBase__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdLuxNonboundableLightBase")]
		public static extern void delete_UsdLuxNonboundableLightBase(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdLuxNonboundableLightBase_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdLuxNonboundableLightBase_GetSchemaAttributeNames__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_Get")]
		public static extern IntPtr UsdLuxNonboundableLightBase_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_LightAPI")]
		public static extern IntPtr UsdLuxNonboundableLightBase_LightAPI(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_GetIntensityAttr")]
		public static extern IntPtr UsdLuxNonboundableLightBase_GetIntensityAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_CreateIntensityAttr__SWIG_0")]
		public static extern IntPtr UsdLuxNonboundableLightBase_CreateIntensityAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_CreateIntensityAttr__SWIG_1")]
		public static extern IntPtr UsdLuxNonboundableLightBase_CreateIntensityAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_CreateIntensityAttr__SWIG_2")]
		public static extern IntPtr UsdLuxNonboundableLightBase_CreateIntensityAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_GetExposureAttr")]
		public static extern IntPtr UsdLuxNonboundableLightBase_GetExposureAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_CreateExposureAttr__SWIG_0")]
		public static extern IntPtr UsdLuxNonboundableLightBase_CreateExposureAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_CreateExposureAttr__SWIG_1")]
		public static extern IntPtr UsdLuxNonboundableLightBase_CreateExposureAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_CreateExposureAttr__SWIG_2")]
		public static extern IntPtr UsdLuxNonboundableLightBase_CreateExposureAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_GetDiffuseAttr")]
		public static extern IntPtr UsdLuxNonboundableLightBase_GetDiffuseAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_CreateDiffuseAttr__SWIG_0")]
		public static extern IntPtr UsdLuxNonboundableLightBase_CreateDiffuseAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_CreateDiffuseAttr__SWIG_1")]
		public static extern IntPtr UsdLuxNonboundableLightBase_CreateDiffuseAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_CreateDiffuseAttr__SWIG_2")]
		public static extern IntPtr UsdLuxNonboundableLightBase_CreateDiffuseAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_GetSpecularAttr")]
		public static extern IntPtr UsdLuxNonboundableLightBase_GetSpecularAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_CreateSpecularAttr__SWIG_0")]
		public static extern IntPtr UsdLuxNonboundableLightBase_CreateSpecularAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_CreateSpecularAttr__SWIG_1")]
		public static extern IntPtr UsdLuxNonboundableLightBase_CreateSpecularAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_CreateSpecularAttr__SWIG_2")]
		public static extern IntPtr UsdLuxNonboundableLightBase_CreateSpecularAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_GetNormalizeAttr")]
		public static extern IntPtr UsdLuxNonboundableLightBase_GetNormalizeAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_CreateNormalizeAttr__SWIG_0")]
		public static extern IntPtr UsdLuxNonboundableLightBase_CreateNormalizeAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_CreateNormalizeAttr__SWIG_1")]
		public static extern IntPtr UsdLuxNonboundableLightBase_CreateNormalizeAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_CreateNormalizeAttr__SWIG_2")]
		public static extern IntPtr UsdLuxNonboundableLightBase_CreateNormalizeAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_GetColorAttr")]
		public static extern IntPtr UsdLuxNonboundableLightBase_GetColorAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_CreateColorAttr__SWIG_0")]
		public static extern IntPtr UsdLuxNonboundableLightBase_CreateColorAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_CreateColorAttr__SWIG_1")]
		public static extern IntPtr UsdLuxNonboundableLightBase_CreateColorAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_CreateColorAttr__SWIG_2")]
		public static extern IntPtr UsdLuxNonboundableLightBase_CreateColorAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_GetEnableColorTemperatureAttr")]
		public static extern IntPtr UsdLuxNonboundableLightBase_GetEnableColorTemperatureAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_CreateEnableColorTemperatureAttr__SWIG_0")]
		public static extern IntPtr UsdLuxNonboundableLightBase_CreateEnableColorTemperatureAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_CreateEnableColorTemperatureAttr__SWIG_1")]
		public static extern IntPtr UsdLuxNonboundableLightBase_CreateEnableColorTemperatureAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_CreateEnableColorTemperatureAttr__SWIG_2")]
		public static extern IntPtr UsdLuxNonboundableLightBase_CreateEnableColorTemperatureAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_GetColorTemperatureAttr")]
		public static extern IntPtr UsdLuxNonboundableLightBase_GetColorTemperatureAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_CreateColorTemperatureAttr__SWIG_0")]
		public static extern IntPtr UsdLuxNonboundableLightBase_CreateColorTemperatureAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_CreateColorTemperatureAttr__SWIG_1")]
		public static extern IntPtr UsdLuxNonboundableLightBase_CreateColorTemperatureAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_CreateColorTemperatureAttr__SWIG_2")]
		public static extern IntPtr UsdLuxNonboundableLightBase_CreateColorTemperatureAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_GetFiltersRel")]
		public static extern IntPtr UsdLuxNonboundableLightBase_GetFiltersRel(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_CreateFiltersRel")]
		public static extern IntPtr UsdLuxNonboundableLightBase_CreateFiltersRel(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxDistantLight__SWIG_0")]
		public static extern IntPtr new_UsdLuxDistantLight__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxDistantLight__SWIG_1")]
		public static extern IntPtr new_UsdLuxDistantLight__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxDistantLight__SWIG_2")]
		public static extern IntPtr new_UsdLuxDistantLight__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdLuxDistantLight")]
		public static extern void delete_UsdLuxDistantLight(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDistantLight_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdLuxDistantLight_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDistantLight_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdLuxDistantLight_GetSchemaAttributeNames__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDistantLight_Get")]
		public static extern IntPtr UsdLuxDistantLight_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDistantLight_Define")]
		public static extern IntPtr UsdLuxDistantLight_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDistantLight_GetAngleAttr")]
		public static extern IntPtr UsdLuxDistantLight_GetAngleAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDistantLight_CreateAngleAttr__SWIG_0")]
		public static extern IntPtr UsdLuxDistantLight_CreateAngleAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDistantLight_CreateAngleAttr__SWIG_1")]
		public static extern IntPtr UsdLuxDistantLight_CreateAngleAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDistantLight_CreateAngleAttr__SWIG_2")]
		public static extern IntPtr UsdLuxDistantLight_CreateAngleAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxDomeLight__SWIG_0")]
		public static extern IntPtr new_UsdLuxDomeLight__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxDomeLight__SWIG_1")]
		public static extern IntPtr new_UsdLuxDomeLight__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxDomeLight__SWIG_2")]
		public static extern IntPtr new_UsdLuxDomeLight__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdLuxDomeLight")]
		public static extern void delete_UsdLuxDomeLight(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDomeLight_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdLuxDomeLight_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDomeLight_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdLuxDomeLight_GetSchemaAttributeNames__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDomeLight_Get")]
		public static extern IntPtr UsdLuxDomeLight_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDomeLight_Define")]
		public static extern IntPtr UsdLuxDomeLight_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDomeLight_GetTextureFileAttr")]
		public static extern IntPtr UsdLuxDomeLight_GetTextureFileAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDomeLight_CreateTextureFileAttr__SWIG_0")]
		public static extern IntPtr UsdLuxDomeLight_CreateTextureFileAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDomeLight_CreateTextureFileAttr__SWIG_1")]
		public static extern IntPtr UsdLuxDomeLight_CreateTextureFileAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDomeLight_CreateTextureFileAttr__SWIG_2")]
		public static extern IntPtr UsdLuxDomeLight_CreateTextureFileAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDomeLight_GetTextureFormatAttr")]
		public static extern IntPtr UsdLuxDomeLight_GetTextureFormatAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDomeLight_CreateTextureFormatAttr__SWIG_0")]
		public static extern IntPtr UsdLuxDomeLight_CreateTextureFormatAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDomeLight_CreateTextureFormatAttr__SWIG_1")]
		public static extern IntPtr UsdLuxDomeLight_CreateTextureFormatAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDomeLight_CreateTextureFormatAttr__SWIG_2")]
		public static extern IntPtr UsdLuxDomeLight_CreateTextureFormatAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDomeLight_GetGuideRadiusAttr")]
		public static extern IntPtr UsdLuxDomeLight_GetGuideRadiusAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDomeLight_CreateGuideRadiusAttr__SWIG_0")]
		public static extern IntPtr UsdLuxDomeLight_CreateGuideRadiusAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDomeLight_CreateGuideRadiusAttr__SWIG_1")]
		public static extern IntPtr UsdLuxDomeLight_CreateGuideRadiusAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDomeLight_CreateGuideRadiusAttr__SWIG_2")]
		public static extern IntPtr UsdLuxDomeLight_CreateGuideRadiusAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDomeLight_GetPortalsRel")]
		public static extern IntPtr UsdLuxDomeLight_GetPortalsRel(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDomeLight_CreatePortalsRel")]
		public static extern IntPtr UsdLuxDomeLight_CreatePortalsRel(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDomeLight_OrientToStageUpAxis")]
		public static extern void UsdLuxDomeLight_OrientToStageUpAxis(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxGeometryLight__SWIG_0")]
		public static extern IntPtr new_UsdLuxGeometryLight__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxGeometryLight__SWIG_1")]
		public static extern IntPtr new_UsdLuxGeometryLight__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxGeometryLight__SWIG_2")]
		public static extern IntPtr new_UsdLuxGeometryLight__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdLuxGeometryLight")]
		public static extern void delete_UsdLuxGeometryLight(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxGeometryLight_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdLuxGeometryLight_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxGeometryLight_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdLuxGeometryLight_GetSchemaAttributeNames__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxGeometryLight_Get")]
		public static extern IntPtr UsdLuxGeometryLight_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxGeometryLight_Define")]
		public static extern IntPtr UsdLuxGeometryLight_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxGeometryLight_GetGeometryRel")]
		public static extern IntPtr UsdLuxGeometryLight_GetGeometryRel(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxGeometryLight_CreateGeometryRel")]
		public static extern IntPtr UsdLuxGeometryLight_CreateGeometryRel(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxLightAPI__SWIG_0")]
		public static extern IntPtr new_UsdLuxLightAPI__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxLightAPI__SWIG_1")]
		public static extern IntPtr new_UsdLuxLightAPI__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxLightAPI__SWIG_2")]
		public static extern IntPtr new_UsdLuxLightAPI__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdLuxLightAPI")]
		public static extern void delete_UsdLuxLightAPI(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdLuxLightAPI_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdLuxLightAPI_GetSchemaAttributeNames__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_Get")]
		public static extern IntPtr UsdLuxLightAPI_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CanApply__SWIG_0")]
		public static extern bool UsdLuxLightAPI_CanApply__SWIG_0(HandleRef jarg1, out string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CanApply__SWIG_1")]
		public static extern bool UsdLuxLightAPI_CanApply__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_Apply")]
		public static extern IntPtr UsdLuxLightAPI_Apply(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_GetShaderIdAttr")]
		public static extern IntPtr UsdLuxLightAPI_GetShaderIdAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateShaderIdAttr__SWIG_0")]
		public static extern IntPtr UsdLuxLightAPI_CreateShaderIdAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateShaderIdAttr__SWIG_1")]
		public static extern IntPtr UsdLuxLightAPI_CreateShaderIdAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateShaderIdAttr__SWIG_2")]
		public static extern IntPtr UsdLuxLightAPI_CreateShaderIdAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_GetMaterialSyncModeAttr")]
		public static extern IntPtr UsdLuxLightAPI_GetMaterialSyncModeAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateMaterialSyncModeAttr__SWIG_0")]
		public static extern IntPtr UsdLuxLightAPI_CreateMaterialSyncModeAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateMaterialSyncModeAttr__SWIG_1")]
		public static extern IntPtr UsdLuxLightAPI_CreateMaterialSyncModeAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateMaterialSyncModeAttr__SWIG_2")]
		public static extern IntPtr UsdLuxLightAPI_CreateMaterialSyncModeAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_GetIntensityAttr")]
		public static extern IntPtr UsdLuxLightAPI_GetIntensityAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateIntensityAttr__SWIG_0")]
		public static extern IntPtr UsdLuxLightAPI_CreateIntensityAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateIntensityAttr__SWIG_1")]
		public static extern IntPtr UsdLuxLightAPI_CreateIntensityAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateIntensityAttr__SWIG_2")]
		public static extern IntPtr UsdLuxLightAPI_CreateIntensityAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_GetExposureAttr")]
		public static extern IntPtr UsdLuxLightAPI_GetExposureAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateExposureAttr__SWIG_0")]
		public static extern IntPtr UsdLuxLightAPI_CreateExposureAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateExposureAttr__SWIG_1")]
		public static extern IntPtr UsdLuxLightAPI_CreateExposureAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateExposureAttr__SWIG_2")]
		public static extern IntPtr UsdLuxLightAPI_CreateExposureAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_GetDiffuseAttr")]
		public static extern IntPtr UsdLuxLightAPI_GetDiffuseAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateDiffuseAttr__SWIG_0")]
		public static extern IntPtr UsdLuxLightAPI_CreateDiffuseAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateDiffuseAttr__SWIG_1")]
		public static extern IntPtr UsdLuxLightAPI_CreateDiffuseAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateDiffuseAttr__SWIG_2")]
		public static extern IntPtr UsdLuxLightAPI_CreateDiffuseAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_GetSpecularAttr")]
		public static extern IntPtr UsdLuxLightAPI_GetSpecularAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateSpecularAttr__SWIG_0")]
		public static extern IntPtr UsdLuxLightAPI_CreateSpecularAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateSpecularAttr__SWIG_1")]
		public static extern IntPtr UsdLuxLightAPI_CreateSpecularAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateSpecularAttr__SWIG_2")]
		public static extern IntPtr UsdLuxLightAPI_CreateSpecularAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_GetNormalizeAttr")]
		public static extern IntPtr UsdLuxLightAPI_GetNormalizeAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateNormalizeAttr__SWIG_0")]
		public static extern IntPtr UsdLuxLightAPI_CreateNormalizeAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateNormalizeAttr__SWIG_1")]
		public static extern IntPtr UsdLuxLightAPI_CreateNormalizeAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateNormalizeAttr__SWIG_2")]
		public static extern IntPtr UsdLuxLightAPI_CreateNormalizeAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_GetColorAttr")]
		public static extern IntPtr UsdLuxLightAPI_GetColorAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateColorAttr__SWIG_0")]
		public static extern IntPtr UsdLuxLightAPI_CreateColorAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateColorAttr__SWIG_1")]
		public static extern IntPtr UsdLuxLightAPI_CreateColorAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateColorAttr__SWIG_2")]
		public static extern IntPtr UsdLuxLightAPI_CreateColorAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_GetEnableColorTemperatureAttr")]
		public static extern IntPtr UsdLuxLightAPI_GetEnableColorTemperatureAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateEnableColorTemperatureAttr__SWIG_0")]
		public static extern IntPtr UsdLuxLightAPI_CreateEnableColorTemperatureAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateEnableColorTemperatureAttr__SWIG_1")]
		public static extern IntPtr UsdLuxLightAPI_CreateEnableColorTemperatureAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateEnableColorTemperatureAttr__SWIG_2")]
		public static extern IntPtr UsdLuxLightAPI_CreateEnableColorTemperatureAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_GetColorTemperatureAttr")]
		public static extern IntPtr UsdLuxLightAPI_GetColorTemperatureAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateColorTemperatureAttr__SWIG_0")]
		public static extern IntPtr UsdLuxLightAPI_CreateColorTemperatureAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateColorTemperatureAttr__SWIG_1")]
		public static extern IntPtr UsdLuxLightAPI_CreateColorTemperatureAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateColorTemperatureAttr__SWIG_2")]
		public static extern IntPtr UsdLuxLightAPI_CreateColorTemperatureAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_GetFiltersRel")]
		public static extern IntPtr UsdLuxLightAPI_GetFiltersRel(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateFiltersRel")]
		public static extern IntPtr UsdLuxLightAPI_CreateFiltersRel(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxLightAPI__SWIG_3")]
		public static extern IntPtr new_UsdLuxLightAPI__SWIG_3(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_ConnectableAPI")]
		public static extern IntPtr UsdLuxLightAPI_ConnectableAPI(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateOutput")]
		public static extern IntPtr UsdLuxLightAPI_CreateOutput(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_GetOutput")]
		public static extern IntPtr UsdLuxLightAPI_GetOutput(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_GetOutputs__SWIG_0")]
		public static extern IntPtr UsdLuxLightAPI_GetOutputs__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_GetOutputs__SWIG_1")]
		public static extern IntPtr UsdLuxLightAPI_GetOutputs__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateInput")]
		public static extern IntPtr UsdLuxLightAPI_CreateInput(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_GetInput")]
		public static extern IntPtr UsdLuxLightAPI_GetInput(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_GetInputs__SWIG_0")]
		public static extern IntPtr UsdLuxLightAPI_GetInputs__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_GetInputs__SWIG_1")]
		public static extern IntPtr UsdLuxLightAPI_GetInputs__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_GetLightLinkCollectionAPI")]
		public static extern IntPtr UsdLuxLightAPI_GetLightLinkCollectionAPI(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_GetShadowLinkCollectionAPI")]
		public static extern IntPtr UsdLuxLightAPI_GetShadowLinkCollectionAPI(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_GetShaderIdAttrForRenderContext")]
		public static extern IntPtr UsdLuxLightAPI_GetShaderIdAttrForRenderContext(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateShaderIdAttrForRenderContext__SWIG_0")]
		public static extern IntPtr UsdLuxLightAPI_CreateShaderIdAttrForRenderContext__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateShaderIdAttrForRenderContext__SWIG_1")]
		public static extern IntPtr UsdLuxLightAPI_CreateShaderIdAttrForRenderContext__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_CreateShaderIdAttrForRenderContext__SWIG_2")]
		public static extern IntPtr UsdLuxLightAPI_CreateShaderIdAttrForRenderContext__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_GetShaderId")]
		public static extern IntPtr UsdLuxLightAPI_GetShaderId(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxLightFilter__SWIG_0")]
		public static extern IntPtr new_UsdLuxLightFilter__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxLightFilter__SWIG_1")]
		public static extern IntPtr new_UsdLuxLightFilter__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxLightFilter__SWIG_2")]
		public static extern IntPtr new_UsdLuxLightFilter__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdLuxLightFilter")]
		public static extern void delete_UsdLuxLightFilter(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightFilter_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdLuxLightFilter_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightFilter_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdLuxLightFilter_GetSchemaAttributeNames__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightFilter_Get")]
		public static extern IntPtr UsdLuxLightFilter_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightFilter_Define")]
		public static extern IntPtr UsdLuxLightFilter_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightFilter_GetShaderIdAttr")]
		public static extern IntPtr UsdLuxLightFilter_GetShaderIdAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightFilter_CreateShaderIdAttr__SWIG_0")]
		public static extern IntPtr UsdLuxLightFilter_CreateShaderIdAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightFilter_CreateShaderIdAttr__SWIG_1")]
		public static extern IntPtr UsdLuxLightFilter_CreateShaderIdAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightFilter_CreateShaderIdAttr__SWIG_2")]
		public static extern IntPtr UsdLuxLightFilter_CreateShaderIdAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxLightFilter__SWIG_3")]
		public static extern IntPtr new_UsdLuxLightFilter__SWIG_3(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightFilter_ConnectableAPI")]
		public static extern IntPtr UsdLuxLightFilter_ConnectableAPI(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightFilter_CreateOutput")]
		public static extern IntPtr UsdLuxLightFilter_CreateOutput(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightFilter_GetOutput")]
		public static extern IntPtr UsdLuxLightFilter_GetOutput(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightFilter_GetOutputs__SWIG_0")]
		public static extern IntPtr UsdLuxLightFilter_GetOutputs__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightFilter_GetOutputs__SWIG_1")]
		public static extern IntPtr UsdLuxLightFilter_GetOutputs__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightFilter_CreateInput")]
		public static extern IntPtr UsdLuxLightFilter_CreateInput(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightFilter_GetInput")]
		public static extern IntPtr UsdLuxLightFilter_GetInput(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightFilter_GetInputs__SWIG_0")]
		public static extern IntPtr UsdLuxLightFilter_GetInputs__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightFilter_GetInputs__SWIG_1")]
		public static extern IntPtr UsdLuxLightFilter_GetInputs__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightFilter_GetFilterLinkCollectionAPI")]
		public static extern IntPtr UsdLuxLightFilter_GetFilterLinkCollectionAPI(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightFilter_GetShaderIdAttrForRenderContext")]
		public static extern IntPtr UsdLuxLightFilter_GetShaderIdAttrForRenderContext(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightFilter_CreateShaderIdAttrForRenderContext__SWIG_0")]
		public static extern IntPtr UsdLuxLightFilter_CreateShaderIdAttrForRenderContext__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightFilter_CreateShaderIdAttrForRenderContext__SWIG_1")]
		public static extern IntPtr UsdLuxLightFilter_CreateShaderIdAttrForRenderContext__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightFilter_CreateShaderIdAttrForRenderContext__SWIG_2")]
		public static extern IntPtr UsdLuxLightFilter_CreateShaderIdAttrForRenderContext__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightFilter_GetShaderId")]
		public static extern IntPtr UsdLuxLightFilter_GetShaderId(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxLightListAPI__SWIG_0")]
		public static extern IntPtr new_UsdLuxLightListAPI__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxLightListAPI__SWIG_1")]
		public static extern IntPtr new_UsdLuxLightListAPI__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxLightListAPI__SWIG_2")]
		public static extern IntPtr new_UsdLuxLightListAPI__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdLuxLightListAPI")]
		public static extern void delete_UsdLuxLightListAPI(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightListAPI_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdLuxLightListAPI_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightListAPI_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdLuxLightListAPI_GetSchemaAttributeNames__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightListAPI_Get")]
		public static extern IntPtr UsdLuxLightListAPI_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightListAPI_CanApply__SWIG_0")]
		public static extern bool UsdLuxLightListAPI_CanApply__SWIG_0(HandleRef jarg1, out string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightListAPI_CanApply__SWIG_1")]
		public static extern bool UsdLuxLightListAPI_CanApply__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightListAPI_Apply")]
		public static extern IntPtr UsdLuxLightListAPI_Apply(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightListAPI_GetLightListCacheBehaviorAttr")]
		public static extern IntPtr UsdLuxLightListAPI_GetLightListCacheBehaviorAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightListAPI_CreateLightListCacheBehaviorAttr__SWIG_0")]
		public static extern IntPtr UsdLuxLightListAPI_CreateLightListCacheBehaviorAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightListAPI_CreateLightListCacheBehaviorAttr__SWIG_1")]
		public static extern IntPtr UsdLuxLightListAPI_CreateLightListCacheBehaviorAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightListAPI_CreateLightListCacheBehaviorAttr__SWIG_2")]
		public static extern IntPtr UsdLuxLightListAPI_CreateLightListCacheBehaviorAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightListAPI_GetLightListRel")]
		public static extern IntPtr UsdLuxLightListAPI_GetLightListRel(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightListAPI_CreateLightListRel")]
		public static extern IntPtr UsdLuxLightListAPI_CreateLightListRel(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightListAPI_ComputeLightList")]
		public static extern IntPtr UsdLuxLightListAPI_ComputeLightList(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightListAPI_StoreLightList")]
		public static extern void UsdLuxLightListAPI_StoreLightList(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightListAPI_InvalidateLightList")]
		public static extern void UsdLuxLightListAPI_InvalidateLightList(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxListAPI__SWIG_0")]
		public static extern IntPtr new_UsdLuxListAPI__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxListAPI__SWIG_1")]
		public static extern IntPtr new_UsdLuxListAPI__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxListAPI__SWIG_2")]
		public static extern IntPtr new_UsdLuxListAPI__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdLuxListAPI")]
		public static extern void delete_UsdLuxListAPI(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxListAPI_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdLuxListAPI_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxListAPI_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdLuxListAPI_GetSchemaAttributeNames__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxListAPI_Get")]
		public static extern IntPtr UsdLuxListAPI_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxListAPI_CanApply__SWIG_0")]
		public static extern bool UsdLuxListAPI_CanApply__SWIG_0(HandleRef jarg1, out string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxListAPI_CanApply__SWIG_1")]
		public static extern bool UsdLuxListAPI_CanApply__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxListAPI_Apply")]
		public static extern IntPtr UsdLuxListAPI_Apply(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxListAPI_GetLightListCacheBehaviorAttr")]
		public static extern IntPtr UsdLuxListAPI_GetLightListCacheBehaviorAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxListAPI_CreateLightListCacheBehaviorAttr__SWIG_0")]
		public static extern IntPtr UsdLuxListAPI_CreateLightListCacheBehaviorAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxListAPI_CreateLightListCacheBehaviorAttr__SWIG_1")]
		public static extern IntPtr UsdLuxListAPI_CreateLightListCacheBehaviorAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxListAPI_CreateLightListCacheBehaviorAttr__SWIG_2")]
		public static extern IntPtr UsdLuxListAPI_CreateLightListCacheBehaviorAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxListAPI_GetLightListRel")]
		public static extern IntPtr UsdLuxListAPI_GetLightListRel(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxListAPI_CreateLightListRel")]
		public static extern IntPtr UsdLuxListAPI_CreateLightListRel(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxListAPI_ComputeLightList")]
		public static extern IntPtr UsdLuxListAPI_ComputeLightList(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxListAPI_StoreLightList")]
		public static extern void UsdLuxListAPI_StoreLightList(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxListAPI_InvalidateLightList")]
		public static extern void UsdLuxListAPI_InvalidateLightList(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxMeshLightAPI__SWIG_0")]
		public static extern IntPtr new_UsdLuxMeshLightAPI__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxMeshLightAPI__SWIG_1")]
		public static extern IntPtr new_UsdLuxMeshLightAPI__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxMeshLightAPI__SWIG_2")]
		public static extern IntPtr new_UsdLuxMeshLightAPI__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdLuxMeshLightAPI")]
		public static extern void delete_UsdLuxMeshLightAPI(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxMeshLightAPI_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdLuxMeshLightAPI_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxMeshLightAPI_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdLuxMeshLightAPI_GetSchemaAttributeNames__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxMeshLightAPI_Get")]
		public static extern IntPtr UsdLuxMeshLightAPI_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxMeshLightAPI_CanApply__SWIG_0")]
		public static extern bool UsdLuxMeshLightAPI_CanApply__SWIG_0(HandleRef jarg1, out string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxMeshLightAPI_CanApply__SWIG_1")]
		public static extern bool UsdLuxMeshLightAPI_CanApply__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxMeshLightAPI_Apply")]
		public static extern IntPtr UsdLuxMeshLightAPI_Apply(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxPluginLight__SWIG_0")]
		public static extern IntPtr new_UsdLuxPluginLight__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxPluginLight__SWIG_1")]
		public static extern IntPtr new_UsdLuxPluginLight__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxPluginLight__SWIG_2")]
		public static extern IntPtr new_UsdLuxPluginLight__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdLuxPluginLight")]
		public static extern void delete_UsdLuxPluginLight(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxPluginLight_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdLuxPluginLight_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxPluginLight_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdLuxPluginLight_GetSchemaAttributeNames__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxPluginLight_Get")]
		public static extern IntPtr UsdLuxPluginLight_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxPluginLight_Define")]
		public static extern IntPtr UsdLuxPluginLight_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxPluginLight_GetNodeDefAPI")]
		public static extern IntPtr UsdLuxPluginLight_GetNodeDefAPI(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxPluginLightFilter__SWIG_0")]
		public static extern IntPtr new_UsdLuxPluginLightFilter__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxPluginLightFilter__SWIG_1")]
		public static extern IntPtr new_UsdLuxPluginLightFilter__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxPluginLightFilter__SWIG_2")]
		public static extern IntPtr new_UsdLuxPluginLightFilter__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdLuxPluginLightFilter")]
		public static extern void delete_UsdLuxPluginLightFilter(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxPluginLightFilter_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdLuxPluginLightFilter_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxPluginLightFilter_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdLuxPluginLightFilter_GetSchemaAttributeNames__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxPluginLightFilter_Get")]
		public static extern IntPtr UsdLuxPluginLightFilter_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxPluginLightFilter_Define")]
		public static extern IntPtr UsdLuxPluginLightFilter_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxPluginLightFilter_GetNodeDefAPI")]
		public static extern IntPtr UsdLuxPluginLightFilter_GetNodeDefAPI(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxPortalLight__SWIG_0")]
		public static extern IntPtr new_UsdLuxPortalLight__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxPortalLight__SWIG_1")]
		public static extern IntPtr new_UsdLuxPortalLight__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxPortalLight__SWIG_2")]
		public static extern IntPtr new_UsdLuxPortalLight__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdLuxPortalLight")]
		public static extern void delete_UsdLuxPortalLight(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxPortalLight_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdLuxPortalLight_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxPortalLight_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdLuxPortalLight_GetSchemaAttributeNames__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxPortalLight_Get")]
		public static extern IntPtr UsdLuxPortalLight_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxPortalLight_Define")]
		public static extern IntPtr UsdLuxPortalLight_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxRectLight__SWIG_0")]
		public static extern IntPtr new_UsdLuxRectLight__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxRectLight__SWIG_1")]
		public static extern IntPtr new_UsdLuxRectLight__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxRectLight__SWIG_2")]
		public static extern IntPtr new_UsdLuxRectLight__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdLuxRectLight")]
		public static extern void delete_UsdLuxRectLight(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxRectLight_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdLuxRectLight_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxRectLight_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdLuxRectLight_GetSchemaAttributeNames__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxRectLight_Get")]
		public static extern IntPtr UsdLuxRectLight_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxRectLight_Define")]
		public static extern IntPtr UsdLuxRectLight_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxRectLight_GetWidthAttr")]
		public static extern IntPtr UsdLuxRectLight_GetWidthAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxRectLight_CreateWidthAttr__SWIG_0")]
		public static extern IntPtr UsdLuxRectLight_CreateWidthAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxRectLight_CreateWidthAttr__SWIG_1")]
		public static extern IntPtr UsdLuxRectLight_CreateWidthAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxRectLight_CreateWidthAttr__SWIG_2")]
		public static extern IntPtr UsdLuxRectLight_CreateWidthAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxRectLight_GetHeightAttr")]
		public static extern IntPtr UsdLuxRectLight_GetHeightAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxRectLight_CreateHeightAttr__SWIG_0")]
		public static extern IntPtr UsdLuxRectLight_CreateHeightAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxRectLight_CreateHeightAttr__SWIG_1")]
		public static extern IntPtr UsdLuxRectLight_CreateHeightAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxRectLight_CreateHeightAttr__SWIG_2")]
		public static extern IntPtr UsdLuxRectLight_CreateHeightAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxRectLight_GetTextureFileAttr")]
		public static extern IntPtr UsdLuxRectLight_GetTextureFileAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxRectLight_CreateTextureFileAttr__SWIG_0")]
		public static extern IntPtr UsdLuxRectLight_CreateTextureFileAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxRectLight_CreateTextureFileAttr__SWIG_1")]
		public static extern IntPtr UsdLuxRectLight_CreateTextureFileAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxRectLight_CreateTextureFileAttr__SWIG_2")]
		public static extern IntPtr UsdLuxRectLight_CreateTextureFileAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxShadowAPI__SWIG_0")]
		public static extern IntPtr new_UsdLuxShadowAPI__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxShadowAPI__SWIG_1")]
		public static extern IntPtr new_UsdLuxShadowAPI__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxShadowAPI__SWIG_2")]
		public static extern IntPtr new_UsdLuxShadowAPI__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdLuxShadowAPI")]
		public static extern void delete_UsdLuxShadowAPI(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdLuxShadowAPI_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdLuxShadowAPI_GetSchemaAttributeNames__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_Get")]
		public static extern IntPtr UsdLuxShadowAPI_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_CanApply__SWIG_0")]
		public static extern bool UsdLuxShadowAPI_CanApply__SWIG_0(HandleRef jarg1, out string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_CanApply__SWIG_1")]
		public static extern bool UsdLuxShadowAPI_CanApply__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_Apply")]
		public static extern IntPtr UsdLuxShadowAPI_Apply(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_GetShadowEnableAttr")]
		public static extern IntPtr UsdLuxShadowAPI_GetShadowEnableAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_CreateShadowEnableAttr__SWIG_0")]
		public static extern IntPtr UsdLuxShadowAPI_CreateShadowEnableAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_CreateShadowEnableAttr__SWIG_1")]
		public static extern IntPtr UsdLuxShadowAPI_CreateShadowEnableAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_CreateShadowEnableAttr__SWIG_2")]
		public static extern IntPtr UsdLuxShadowAPI_CreateShadowEnableAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_GetShadowColorAttr")]
		public static extern IntPtr UsdLuxShadowAPI_GetShadowColorAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_CreateShadowColorAttr__SWIG_0")]
		public static extern IntPtr UsdLuxShadowAPI_CreateShadowColorAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_CreateShadowColorAttr__SWIG_1")]
		public static extern IntPtr UsdLuxShadowAPI_CreateShadowColorAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_CreateShadowColorAttr__SWIG_2")]
		public static extern IntPtr UsdLuxShadowAPI_CreateShadowColorAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_GetShadowDistanceAttr")]
		public static extern IntPtr UsdLuxShadowAPI_GetShadowDistanceAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_CreateShadowDistanceAttr__SWIG_0")]
		public static extern IntPtr UsdLuxShadowAPI_CreateShadowDistanceAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_CreateShadowDistanceAttr__SWIG_1")]
		public static extern IntPtr UsdLuxShadowAPI_CreateShadowDistanceAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_CreateShadowDistanceAttr__SWIG_2")]
		public static extern IntPtr UsdLuxShadowAPI_CreateShadowDistanceAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_GetShadowFalloffAttr")]
		public static extern IntPtr UsdLuxShadowAPI_GetShadowFalloffAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_CreateShadowFalloffAttr__SWIG_0")]
		public static extern IntPtr UsdLuxShadowAPI_CreateShadowFalloffAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_CreateShadowFalloffAttr__SWIG_1")]
		public static extern IntPtr UsdLuxShadowAPI_CreateShadowFalloffAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_CreateShadowFalloffAttr__SWIG_2")]
		public static extern IntPtr UsdLuxShadowAPI_CreateShadowFalloffAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_GetShadowFalloffGammaAttr")]
		public static extern IntPtr UsdLuxShadowAPI_GetShadowFalloffGammaAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_CreateShadowFalloffGammaAttr__SWIG_0")]
		public static extern IntPtr UsdLuxShadowAPI_CreateShadowFalloffGammaAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_CreateShadowFalloffGammaAttr__SWIG_1")]
		public static extern IntPtr UsdLuxShadowAPI_CreateShadowFalloffGammaAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_CreateShadowFalloffGammaAttr__SWIG_2")]
		public static extern IntPtr UsdLuxShadowAPI_CreateShadowFalloffGammaAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxShadowAPI__SWIG_3")]
		public static extern IntPtr new_UsdLuxShadowAPI__SWIG_3(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_ConnectableAPI")]
		public static extern IntPtr UsdLuxShadowAPI_ConnectableAPI(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_CreateOutput")]
		public static extern IntPtr UsdLuxShadowAPI_CreateOutput(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_GetOutput")]
		public static extern IntPtr UsdLuxShadowAPI_GetOutput(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_GetOutputs__SWIG_0")]
		public static extern IntPtr UsdLuxShadowAPI_GetOutputs__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_GetOutputs__SWIG_1")]
		public static extern IntPtr UsdLuxShadowAPI_GetOutputs__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_CreateInput")]
		public static extern IntPtr UsdLuxShadowAPI_CreateInput(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_GetInput")]
		public static extern IntPtr UsdLuxShadowAPI_GetInput(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_GetInputs__SWIG_0")]
		public static extern IntPtr UsdLuxShadowAPI_GetInputs__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_GetInputs__SWIG_1")]
		public static extern IntPtr UsdLuxShadowAPI_GetInputs__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxShapingAPI__SWIG_0")]
		public static extern IntPtr new_UsdLuxShapingAPI__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxShapingAPI__SWIG_1")]
		public static extern IntPtr new_UsdLuxShapingAPI__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxShapingAPI__SWIG_2")]
		public static extern IntPtr new_UsdLuxShapingAPI__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdLuxShapingAPI")]
		public static extern void delete_UsdLuxShapingAPI(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdLuxShapingAPI_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdLuxShapingAPI_GetSchemaAttributeNames__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_Get")]
		public static extern IntPtr UsdLuxShapingAPI_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_CanApply__SWIG_0")]
		public static extern bool UsdLuxShapingAPI_CanApply__SWIG_0(HandleRef jarg1, out string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_CanApply__SWIG_1")]
		public static extern bool UsdLuxShapingAPI_CanApply__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_Apply")]
		public static extern IntPtr UsdLuxShapingAPI_Apply(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_GetShapingFocusAttr")]
		public static extern IntPtr UsdLuxShapingAPI_GetShapingFocusAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_CreateShapingFocusAttr__SWIG_0")]
		public static extern IntPtr UsdLuxShapingAPI_CreateShapingFocusAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_CreateShapingFocusAttr__SWIG_1")]
		public static extern IntPtr UsdLuxShapingAPI_CreateShapingFocusAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_CreateShapingFocusAttr__SWIG_2")]
		public static extern IntPtr UsdLuxShapingAPI_CreateShapingFocusAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_GetShapingFocusTintAttr")]
		public static extern IntPtr UsdLuxShapingAPI_GetShapingFocusTintAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_CreateShapingFocusTintAttr__SWIG_0")]
		public static extern IntPtr UsdLuxShapingAPI_CreateShapingFocusTintAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_CreateShapingFocusTintAttr__SWIG_1")]
		public static extern IntPtr UsdLuxShapingAPI_CreateShapingFocusTintAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_CreateShapingFocusTintAttr__SWIG_2")]
		public static extern IntPtr UsdLuxShapingAPI_CreateShapingFocusTintAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_GetShapingConeAngleAttr")]
		public static extern IntPtr UsdLuxShapingAPI_GetShapingConeAngleAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_CreateShapingConeAngleAttr__SWIG_0")]
		public static extern IntPtr UsdLuxShapingAPI_CreateShapingConeAngleAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_CreateShapingConeAngleAttr__SWIG_1")]
		public static extern IntPtr UsdLuxShapingAPI_CreateShapingConeAngleAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_CreateShapingConeAngleAttr__SWIG_2")]
		public static extern IntPtr UsdLuxShapingAPI_CreateShapingConeAngleAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_GetShapingConeSoftnessAttr")]
		public static extern IntPtr UsdLuxShapingAPI_GetShapingConeSoftnessAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_CreateShapingConeSoftnessAttr__SWIG_0")]
		public static extern IntPtr UsdLuxShapingAPI_CreateShapingConeSoftnessAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_CreateShapingConeSoftnessAttr__SWIG_1")]
		public static extern IntPtr UsdLuxShapingAPI_CreateShapingConeSoftnessAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_CreateShapingConeSoftnessAttr__SWIG_2")]
		public static extern IntPtr UsdLuxShapingAPI_CreateShapingConeSoftnessAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_GetShapingIesFileAttr")]
		public static extern IntPtr UsdLuxShapingAPI_GetShapingIesFileAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_CreateShapingIesFileAttr__SWIG_0")]
		public static extern IntPtr UsdLuxShapingAPI_CreateShapingIesFileAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_CreateShapingIesFileAttr__SWIG_1")]
		public static extern IntPtr UsdLuxShapingAPI_CreateShapingIesFileAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_CreateShapingIesFileAttr__SWIG_2")]
		public static extern IntPtr UsdLuxShapingAPI_CreateShapingIesFileAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_GetShapingIesAngleScaleAttr")]
		public static extern IntPtr UsdLuxShapingAPI_GetShapingIesAngleScaleAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_CreateShapingIesAngleScaleAttr__SWIG_0")]
		public static extern IntPtr UsdLuxShapingAPI_CreateShapingIesAngleScaleAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_CreateShapingIesAngleScaleAttr__SWIG_1")]
		public static extern IntPtr UsdLuxShapingAPI_CreateShapingIesAngleScaleAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_CreateShapingIesAngleScaleAttr__SWIG_2")]
		public static extern IntPtr UsdLuxShapingAPI_CreateShapingIesAngleScaleAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_GetShapingIesNormalizeAttr")]
		public static extern IntPtr UsdLuxShapingAPI_GetShapingIesNormalizeAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_CreateShapingIesNormalizeAttr__SWIG_0")]
		public static extern IntPtr UsdLuxShapingAPI_CreateShapingIesNormalizeAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_CreateShapingIesNormalizeAttr__SWIG_1")]
		public static extern IntPtr UsdLuxShapingAPI_CreateShapingIesNormalizeAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_CreateShapingIesNormalizeAttr__SWIG_2")]
		public static extern IntPtr UsdLuxShapingAPI_CreateShapingIesNormalizeAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxShapingAPI__SWIG_3")]
		public static extern IntPtr new_UsdLuxShapingAPI__SWIG_3(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_ConnectableAPI")]
		public static extern IntPtr UsdLuxShapingAPI_ConnectableAPI(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_CreateOutput")]
		public static extern IntPtr UsdLuxShapingAPI_CreateOutput(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_GetOutput")]
		public static extern IntPtr UsdLuxShapingAPI_GetOutput(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_GetOutputs__SWIG_0")]
		public static extern IntPtr UsdLuxShapingAPI_GetOutputs__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_GetOutputs__SWIG_1")]
		public static extern IntPtr UsdLuxShapingAPI_GetOutputs__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_CreateInput")]
		public static extern IntPtr UsdLuxShapingAPI_CreateInput(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_GetInput")]
		public static extern IntPtr UsdLuxShapingAPI_GetInput(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_GetInputs__SWIG_0")]
		public static extern IntPtr UsdLuxShapingAPI_GetInputs__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_GetInputs__SWIG_1")]
		public static extern IntPtr UsdLuxShapingAPI_GetInputs__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxSphereLight__SWIG_0")]
		public static extern IntPtr new_UsdLuxSphereLight__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxSphereLight__SWIG_1")]
		public static extern IntPtr new_UsdLuxSphereLight__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxSphereLight__SWIG_2")]
		public static extern IntPtr new_UsdLuxSphereLight__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdLuxSphereLight")]
		public static extern void delete_UsdLuxSphereLight(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxSphereLight_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdLuxSphereLight_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxSphereLight_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdLuxSphereLight_GetSchemaAttributeNames__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxSphereLight_Get")]
		public static extern IntPtr UsdLuxSphereLight_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxSphereLight_Define")]
		public static extern IntPtr UsdLuxSphereLight_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxSphereLight_GetRadiusAttr")]
		public static extern IntPtr UsdLuxSphereLight_GetRadiusAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxSphereLight_CreateRadiusAttr__SWIG_0")]
		public static extern IntPtr UsdLuxSphereLight_CreateRadiusAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxSphereLight_CreateRadiusAttr__SWIG_1")]
		public static extern IntPtr UsdLuxSphereLight_CreateRadiusAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxSphereLight_CreateRadiusAttr__SWIG_2")]
		public static extern IntPtr UsdLuxSphereLight_CreateRadiusAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxSphereLight_GetTreatAsPointAttr")]
		public static extern IntPtr UsdLuxSphereLight_GetTreatAsPointAttr(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxSphereLight_CreateTreatAsPointAttr__SWIG_0")]
		public static extern IntPtr UsdLuxSphereLight_CreateTreatAsPointAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxSphereLight_CreateTreatAsPointAttr__SWIG_1")]
		public static extern IntPtr UsdLuxSphereLight_CreateTreatAsPointAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxSphereLight_CreateTreatAsPointAttr__SWIG_2")]
		public static extern IntPtr UsdLuxSphereLight_CreateTreatAsPointAttr__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxVolumeLightAPI__SWIG_0")]
		public static extern IntPtr new_UsdLuxVolumeLightAPI__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxVolumeLightAPI__SWIG_1")]
		public static extern IntPtr new_UsdLuxVolumeLightAPI__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_UsdLuxVolumeLightAPI__SWIG_2")]
		public static extern IntPtr new_UsdLuxVolumeLightAPI__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_UsdLuxVolumeLightAPI")]
		public static extern void delete_UsdLuxVolumeLightAPI(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxVolumeLightAPI_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdLuxVolumeLightAPI_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxVolumeLightAPI_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdLuxVolumeLightAPI_GetSchemaAttributeNames__SWIG_1();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxVolumeLightAPI_Get")]
		public static extern IntPtr UsdLuxVolumeLightAPI_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxVolumeLightAPI_CanApply__SWIG_0")]
		public static extern bool UsdLuxVolumeLightAPI_CanApply__SWIG_0(HandleRef jarg1, out string jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxVolumeLightAPI_CanApply__SWIG_1")]
		public static extern bool UsdLuxVolumeLightAPI_CanApply__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxVolumeLightAPI_Apply")]
		public static extern IntPtr UsdLuxVolumeLightAPI_Apply(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxBoundableLightBase_SWIGUpcast")]
		public static extern IntPtr UsdLuxBoundableLightBase_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxCylinderLight_SWIGUpcast")]
		public static extern IntPtr UsdLuxCylinderLight_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDiskLight_SWIGUpcast")]
		public static extern IntPtr UsdLuxDiskLight_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxNonboundableLightBase_SWIGUpcast")]
		public static extern IntPtr UsdLuxNonboundableLightBase_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDistantLight_SWIGUpcast")]
		public static extern IntPtr UsdLuxDistantLight_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxDomeLight_SWIGUpcast")]
		public static extern IntPtr UsdLuxDomeLight_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxGeometryLight_SWIGUpcast")]
		public static extern IntPtr UsdLuxGeometryLight_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightAPI_SWIGUpcast")]
		public static extern IntPtr UsdLuxLightAPI_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightFilter_SWIGUpcast")]
		public static extern IntPtr UsdLuxLightFilter_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxLightListAPI_SWIGUpcast")]
		public static extern IntPtr UsdLuxLightListAPI_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxListAPI_SWIGUpcast")]
		public static extern IntPtr UsdLuxListAPI_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxMeshLightAPI_SWIGUpcast")]
		public static extern IntPtr UsdLuxMeshLightAPI_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxPluginLight_SWIGUpcast")]
		public static extern IntPtr UsdLuxPluginLight_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxPluginLightFilter_SWIGUpcast")]
		public static extern IntPtr UsdLuxPluginLightFilter_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxPortalLight_SWIGUpcast")]
		public static extern IntPtr UsdLuxPortalLight_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxRectLight_SWIGUpcast")]
		public static extern IntPtr UsdLuxRectLight_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShadowAPI_SWIGUpcast")]
		public static extern IntPtr UsdLuxShadowAPI_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxShapingAPI_SWIGUpcast")]
		public static extern IntPtr UsdLuxShapingAPI_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxSphereLight_SWIGUpcast")]
		public static extern IntPtr UsdLuxSphereLight_SWIGUpcast(IntPtr jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_UsdLuxVolumeLightAPI_SWIGUpcast")]
		public static extern IntPtr UsdLuxVolumeLightAPI_SWIGUpcast(IntPtr jarg1);
	}
}
