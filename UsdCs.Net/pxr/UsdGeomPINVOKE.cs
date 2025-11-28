using System;
using System.Runtime.InteropServices;

namespace pxr
{
	internal class UsdGeomPINVOKE
	{
		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			[DllImport(UsdDll.USD_EXPORT_NAME)]
			public static extern void SWIGRegisterStringCallback_UsdGeom(SWIGStringDelegate stringDelegate);

			[MonoPInvokeCallback]
			private static string CreateString(string cString)
			{
				return cString;
			}

			static SWIGStringHelper()
			{
				stringDelegate = CreateString;
				SWIGRegisterStringCallback_UsdGeom(stringDelegate);
			}
		}

		public class SWIGPendingException : UsdCsPINVOKE.SWIGPendingException
		{
		}

		protected static SWIGStringHelper swigStringHelper;

		static UsdGeomPINVOKE()
		{
			swigStringHelper = new SWIGStringHelper();
		}

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomPointBased__SWIG_0")]
		public static extern IntPtr new_UsdGeomPointBased__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomPointBased__SWIG_1")]
		public static extern IntPtr new_UsdGeomPointBased__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomPointBased__SWIG_2")]
		public static extern IntPtr new_UsdGeomPointBased__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomPointBased")]
		public static extern void delete_UsdGeomPointBased(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomPointBased_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomPointBased_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_Get")]
		public static extern IntPtr UsdGeomPointBased_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_GetPointsAttr")]
		public static extern IntPtr UsdGeomPointBased_GetPointsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_CreatePointsAttr__SWIG_0")]
		public static extern IntPtr UsdGeomPointBased_CreatePointsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_CreatePointsAttr__SWIG_1")]
		public static extern IntPtr UsdGeomPointBased_CreatePointsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_CreatePointsAttr__SWIG_2")]
		public static extern IntPtr UsdGeomPointBased_CreatePointsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_GetVelocitiesAttr")]
		public static extern IntPtr UsdGeomPointBased_GetVelocitiesAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_CreateVelocitiesAttr__SWIG_0")]
		public static extern IntPtr UsdGeomPointBased_CreateVelocitiesAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_CreateVelocitiesAttr__SWIG_1")]
		public static extern IntPtr UsdGeomPointBased_CreateVelocitiesAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_CreateVelocitiesAttr__SWIG_2")]
		public static extern IntPtr UsdGeomPointBased_CreateVelocitiesAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_GetAccelerationsAttr")]
		public static extern IntPtr UsdGeomPointBased_GetAccelerationsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_CreateAccelerationsAttr__SWIG_0")]
		public static extern IntPtr UsdGeomPointBased_CreateAccelerationsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_CreateAccelerationsAttr__SWIG_1")]
		public static extern IntPtr UsdGeomPointBased_CreateAccelerationsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_CreateAccelerationsAttr__SWIG_2")]
		public static extern IntPtr UsdGeomPointBased_CreateAccelerationsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_GetNormalsAttr")]
		public static extern IntPtr UsdGeomPointBased_GetNormalsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_CreateNormalsAttr__SWIG_0")]
		public static extern IntPtr UsdGeomPointBased_CreateNormalsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_CreateNormalsAttr__SWIG_1")]
		public static extern IntPtr UsdGeomPointBased_CreateNormalsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_CreateNormalsAttr__SWIG_2")]
		public static extern IntPtr UsdGeomPointBased_CreateNormalsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_GetNormalsInterpolation")]
		public static extern IntPtr UsdGeomPointBased_GetNormalsInterpolation(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_SetNormalsInterpolation")]
		public static extern bool UsdGeomPointBased_SetNormalsInterpolation(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_ComputeExtent__SWIG_0")]
		public static extern bool UsdGeomPointBased_ComputeExtent__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_ComputeExtent__SWIG_1")]
		public static extern bool UsdGeomPointBased_ComputeExtent__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_ComputePointsAtTime__SWIG_0")]
		public static extern bool UsdGeomPointBased_ComputePointsAtTime__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_ComputePointsAtTimes")]
		public static extern bool UsdGeomPointBased_ComputePointsAtTimes(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_ComputePointsAtTime__SWIG_1")]
		public static extern bool UsdGeomPointBased_ComputePointsAtTime__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, HandleRef jarg6, HandleRef jarg7, float jarg8);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_ComputePointsAtTime__SWIG_2")]
		public static extern bool UsdGeomPointBased_ComputePointsAtTime__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, HandleRef jarg6, HandleRef jarg7);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomCurves__SWIG_0")]
		public static extern IntPtr new_UsdGeomCurves__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomCurves__SWIG_1")]
		public static extern IntPtr new_UsdGeomCurves__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomCurves__SWIG_2")]
		public static extern IntPtr new_UsdGeomCurves__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomCurves")]
		public static extern void delete_UsdGeomCurves(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCurves_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomCurves_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCurves_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomCurves_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCurves_Get")]
		public static extern IntPtr UsdGeomCurves_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCurves_GetCurveVertexCountsAttr")]
		public static extern IntPtr UsdGeomCurves_GetCurveVertexCountsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCurves_CreateCurveVertexCountsAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCurves_CreateCurveVertexCountsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCurves_CreateCurveVertexCountsAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCurves_CreateCurveVertexCountsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCurves_CreateCurveVertexCountsAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCurves_CreateCurveVertexCountsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCurves_GetWidthsAttr")]
		public static extern IntPtr UsdGeomCurves_GetWidthsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCurves_CreateWidthsAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCurves_CreateWidthsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCurves_CreateWidthsAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCurves_CreateWidthsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCurves_CreateWidthsAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCurves_CreateWidthsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCurves_GetWidthsInterpolation")]
		public static extern IntPtr UsdGeomCurves_GetWidthsInterpolation(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCurves_SetWidthsInterpolation")]
		public static extern bool UsdGeomCurves_SetWidthsInterpolation(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCurves_ComputeExtent__SWIG_0")]
		public static extern bool UsdGeomCurves_ComputeExtent__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCurves_ComputeExtent__SWIG_1")]
		public static extern bool UsdGeomCurves_ComputeExtent__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCurves_GetCurveCount__SWIG_0")]
		public static extern uint UsdGeomCurves_GetCurveCount__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCurves_GetCurveCount__SWIG_1")]
		public static extern uint UsdGeomCurves_GetCurveCount__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomBasisCurves__SWIG_0")]
		public static extern IntPtr new_UsdGeomBasisCurves__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomBasisCurves__SWIG_1")]
		public static extern IntPtr new_UsdGeomBasisCurves__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomBasisCurves__SWIG_2")]
		public static extern IntPtr new_UsdGeomBasisCurves__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomBasisCurves")]
		public static extern void delete_UsdGeomBasisCurves(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurves_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomBasisCurves_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurves_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomBasisCurves_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurves_Get")]
		public static extern IntPtr UsdGeomBasisCurves_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurves_Define")]
		public static extern IntPtr UsdGeomBasisCurves_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurves_GetTypeAttr")]
		public static extern IntPtr UsdGeomBasisCurves_GetTypeAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurves_CreateTypeAttr__SWIG_0")]
		public static extern IntPtr UsdGeomBasisCurves_CreateTypeAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurves_CreateTypeAttr__SWIG_1")]
		public static extern IntPtr UsdGeomBasisCurves_CreateTypeAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurves_CreateTypeAttr__SWIG_2")]
		public static extern IntPtr UsdGeomBasisCurves_CreateTypeAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurves_GetBasisAttr")]
		public static extern IntPtr UsdGeomBasisCurves_GetBasisAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurves_CreateBasisAttr__SWIG_0")]
		public static extern IntPtr UsdGeomBasisCurves_CreateBasisAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurves_CreateBasisAttr__SWIG_1")]
		public static extern IntPtr UsdGeomBasisCurves_CreateBasisAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurves_CreateBasisAttr__SWIG_2")]
		public static extern IntPtr UsdGeomBasisCurves_CreateBasisAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurves_GetWrapAttr")]
		public static extern IntPtr UsdGeomBasisCurves_GetWrapAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurves_CreateWrapAttr__SWIG_0")]
		public static extern IntPtr UsdGeomBasisCurves_CreateWrapAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurves_CreateWrapAttr__SWIG_1")]
		public static extern IntPtr UsdGeomBasisCurves_CreateWrapAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurves_CreateWrapAttr__SWIG_2")]
		public static extern IntPtr UsdGeomBasisCurves_CreateWrapAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurves_ComputeInterpolationForSize__SWIG_0")]
		public static extern IntPtr UsdGeomBasisCurves_ComputeInterpolationForSize__SWIG_0(HandleRef jarg1, uint jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurves_ComputeInterpolationForSize__SWIG_1")]
		public static extern IntPtr UsdGeomBasisCurves_ComputeInterpolationForSize__SWIG_1(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurves_ComputeUniformDataSize")]
		public static extern uint UsdGeomBasisCurves_ComputeUniformDataSize(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurves_ComputeVaryingDataSize")]
		public static extern uint UsdGeomBasisCurves_ComputeVaryingDataSize(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurves_ComputeVertexDataSize")]
		public static extern uint UsdGeomBasisCurves_ComputeVertexDataSize(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomBasisCurvesComputeInterpolationInfoPair__SWIG_0")]
		public static extern IntPtr new_UsdGeomBasisCurvesComputeInterpolationInfoPair__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomBasisCurvesComputeInterpolationInfoPair__SWIG_1")]
		public static extern IntPtr new_UsdGeomBasisCurvesComputeInterpolationInfoPair__SWIG_1(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomBasisCurvesComputeInterpolationInfoPair__SWIG_2")]
		public static extern IntPtr new_UsdGeomBasisCurvesComputeInterpolationInfoPair__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurvesComputeInterpolationInfoPair_first_set")]
		public static extern void UsdGeomBasisCurvesComputeInterpolationInfoPair_first_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurvesComputeInterpolationInfoPair_first_get")]
		public static extern IntPtr UsdGeomBasisCurvesComputeInterpolationInfoPair_first_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurvesComputeInterpolationInfoPair_second_set")]
		public static extern void UsdGeomBasisCurvesComputeInterpolationInfoPair_second_set(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurvesComputeInterpolationInfoPair_second_get")]
		public static extern uint UsdGeomBasisCurvesComputeInterpolationInfoPair_second_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomBasisCurvesComputeInterpolationInfoPair")]
		public static extern void delete_UsdGeomBasisCurvesComputeInterpolationInfoPair(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurvesComputeInterpolationInfo_Clear")]
		public static extern void UsdGeomBasisCurvesComputeInterpolationInfo_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurvesComputeInterpolationInfo_Add")]
		public static extern void UsdGeomBasisCurvesComputeInterpolationInfo_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurvesComputeInterpolationInfo_size")]
		public static extern uint UsdGeomBasisCurvesComputeInterpolationInfo_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurvesComputeInterpolationInfo_capacity")]
		public static extern uint UsdGeomBasisCurvesComputeInterpolationInfo_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurvesComputeInterpolationInfo_reserve")]
		public static extern void UsdGeomBasisCurvesComputeInterpolationInfo_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomBasisCurvesComputeInterpolationInfo__SWIG_0")]
		public static extern IntPtr new_UsdGeomBasisCurvesComputeInterpolationInfo__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomBasisCurvesComputeInterpolationInfo__SWIG_1")]
		public static extern IntPtr new_UsdGeomBasisCurvesComputeInterpolationInfo__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomBasisCurvesComputeInterpolationInfo__SWIG_2")]
		public static extern IntPtr new_UsdGeomBasisCurvesComputeInterpolationInfo__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurvesComputeInterpolationInfo_getitemcopy")]
		public static extern IntPtr UsdGeomBasisCurvesComputeInterpolationInfo_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurvesComputeInterpolationInfo_getitem")]
		public static extern IntPtr UsdGeomBasisCurvesComputeInterpolationInfo_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurvesComputeInterpolationInfo_setitem")]
		public static extern void UsdGeomBasisCurvesComputeInterpolationInfo_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurvesComputeInterpolationInfo_AddRange")]
		public static extern void UsdGeomBasisCurvesComputeInterpolationInfo_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurvesComputeInterpolationInfo_GetRange")]
		public static extern IntPtr UsdGeomBasisCurvesComputeInterpolationInfo_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurvesComputeInterpolationInfo_Insert")]
		public static extern void UsdGeomBasisCurvesComputeInterpolationInfo_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurvesComputeInterpolationInfo_InsertRange")]
		public static extern void UsdGeomBasisCurvesComputeInterpolationInfo_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurvesComputeInterpolationInfo_RemoveAt")]
		public static extern void UsdGeomBasisCurvesComputeInterpolationInfo_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurvesComputeInterpolationInfo_RemoveRange")]
		public static extern void UsdGeomBasisCurvesComputeInterpolationInfo_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurvesComputeInterpolationInfo_Repeat")]
		public static extern IntPtr UsdGeomBasisCurvesComputeInterpolationInfo_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurvesComputeInterpolationInfo_Reverse__SWIG_0")]
		public static extern void UsdGeomBasisCurvesComputeInterpolationInfo_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurvesComputeInterpolationInfo_Reverse__SWIG_1")]
		public static extern void UsdGeomBasisCurvesComputeInterpolationInfo_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurvesComputeInterpolationInfo_SetRange")]
		public static extern void UsdGeomBasisCurvesComputeInterpolationInfo_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomBasisCurvesComputeInterpolationInfo")]
		public static extern void delete_UsdGeomBasisCurvesComputeInterpolationInfo(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomBBoxCache__SWIG_0")]
		public static extern IntPtr new_UsdGeomBBoxCache__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3, bool jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomBBoxCache__SWIG_1")]
		public static extern IntPtr new_UsdGeomBBoxCache__SWIG_1(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomBBoxCache__SWIG_2")]
		public static extern IntPtr new_UsdGeomBBoxCache__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomBBoxCache__SWIG_3")]
		public static extern IntPtr new_UsdGeomBBoxCache__SWIG_3(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBBoxCache_ComputeWorldBound")]
		public static extern IntPtr UsdGeomBBoxCache_ComputeWorldBound(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBBoxCache_ComputeWorldBoundWithOverrides")]
		public static extern IntPtr UsdGeomBBoxCache_ComputeWorldBoundWithOverrides(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBBoxCache_ComputeRelativeBound")]
		public static extern IntPtr UsdGeomBBoxCache_ComputeRelativeBound(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBBoxCache_ComputeLocalBound")]
		public static extern IntPtr UsdGeomBBoxCache_ComputeLocalBound(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBBoxCache_ComputeUntransformedBound__SWIG_0")]
		public static extern IntPtr UsdGeomBBoxCache_ComputeUntransformedBound__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBBoxCache_ComputeUntransformedBound__SWIG_1")]
		public static extern IntPtr UsdGeomBBoxCache_ComputeUntransformedBound__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBBoxCache_ComputePointInstanceWorldBounds")]
		public static extern bool UsdGeomBBoxCache_ComputePointInstanceWorldBounds(HandleRef jarg1, HandleRef jarg2, [In][MarshalAs(UnmanagedType.LPArray)] long[] jarg3, uint jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBBoxCache_ComputePointInstanceWorldBound")]
		public static extern IntPtr UsdGeomBBoxCache_ComputePointInstanceWorldBound(HandleRef jarg1, HandleRef jarg2, long jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBBoxCache_ComputePointInstanceRelativeBounds")]
		public static extern bool UsdGeomBBoxCache_ComputePointInstanceRelativeBounds(HandleRef jarg1, HandleRef jarg2, [In][MarshalAs(UnmanagedType.LPArray)] long[] jarg3, uint jarg4, HandleRef jarg5, HandleRef jarg6);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBBoxCache_ComputePointInstanceRelativeBound")]
		public static extern IntPtr UsdGeomBBoxCache_ComputePointInstanceRelativeBound(HandleRef jarg1, HandleRef jarg2, long jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBBoxCache_ComputePointInstanceLocalBounds")]
		public static extern bool UsdGeomBBoxCache_ComputePointInstanceLocalBounds(HandleRef jarg1, HandleRef jarg2, [In][MarshalAs(UnmanagedType.LPArray)] long[] jarg3, uint jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBBoxCache_ComputePointInstanceLocalBound")]
		public static extern IntPtr UsdGeomBBoxCache_ComputePointInstanceLocalBound(HandleRef jarg1, HandleRef jarg2, long jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBBoxCache_ComputePointInstanceUntransformedBounds")]
		public static extern bool UsdGeomBBoxCache_ComputePointInstanceUntransformedBounds(HandleRef jarg1, HandleRef jarg2, [In][MarshalAs(UnmanagedType.LPArray)] long[] jarg3, uint jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBBoxCache_ComputePointInstanceUntransformedBound")]
		public static extern IntPtr UsdGeomBBoxCache_ComputePointInstanceUntransformedBound(HandleRef jarg1, HandleRef jarg2, long jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBBoxCache_Clear")]
		public static extern void UsdGeomBBoxCache_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBBoxCache_SetIncludedPurposes")]
		public static extern void UsdGeomBBoxCache_SetIncludedPurposes(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBBoxCache_GetIncludedPurposes")]
		public static extern IntPtr UsdGeomBBoxCache_GetIncludedPurposes(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBBoxCache_GetUseExtentsHint")]
		public static extern bool UsdGeomBBoxCache_GetUseExtentsHint(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBBoxCache_GetIgnoreVisibility")]
		public static extern bool UsdGeomBBoxCache_GetIgnoreVisibility(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBBoxCache_SetTime")]
		public static extern void UsdGeomBBoxCache_SetTime(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBBoxCache_GetTime")]
		public static extern IntPtr UsdGeomBBoxCache_GetTime(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBBoxCache_SetBaseTime")]
		public static extern void UsdGeomBBoxCache_SetBaseTime(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBBoxCache_GetBaseTime")]
		public static extern IntPtr UsdGeomBBoxCache_GetBaseTime(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBBoxCache_ClearBaseTime")]
		public static extern void UsdGeomBBoxCache_ClearBaseTime(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBBoxCache_HasBaseTime")]
		public static extern bool UsdGeomBBoxCache_HasBaseTime(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomBBoxCache")]
		public static extern void delete_UsdGeomBBoxCache(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomXformable__SWIG_0")]
		public static extern IntPtr new_UsdGeomXformable__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomXformable__SWIG_1")]
		public static extern IntPtr new_UsdGeomXformable__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomXformable__SWIG_2")]
		public static extern IntPtr new_UsdGeomXformable__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomXformable")]
		public static extern void delete_UsdGeomXformable(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomXformable_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomXformable_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_Get")]
		public static extern IntPtr UsdGeomXformable_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_GetXformOpOrderAttr")]
		public static extern IntPtr UsdGeomXformable_GetXformOpOrderAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_CreateXformOpOrderAttr__SWIG_0")]
		public static extern IntPtr UsdGeomXformable_CreateXformOpOrderAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_CreateXformOpOrderAttr__SWIG_1")]
		public static extern IntPtr UsdGeomXformable_CreateXformOpOrderAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_CreateXformOpOrderAttr__SWIG_2")]
		public static extern IntPtr UsdGeomXformable_CreateXformOpOrderAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomXformable_XformQuery__SWIG_0")]
		public static extern IntPtr new_UsdGeomXformable_XformQuery__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomXformable_XformQuery__SWIG_1")]
		public static extern IntPtr new_UsdGeomXformable_XformQuery__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_XformQuery_GetLocalTransformation")]
		public static extern bool UsdGeomXformable_XformQuery_GetLocalTransformation(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_XformQuery_GetResetXformStack")]
		public static extern bool UsdGeomXformable_XformQuery_GetResetXformStack(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_XformQuery_TransformMightBeTimeVarying")]
		public static extern bool UsdGeomXformable_XformQuery_TransformMightBeTimeVarying(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_XformQuery_HasNonEmptyXformOpOrder")]
		public static extern bool UsdGeomXformable_XformQuery_HasNonEmptyXformOpOrder(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_XformQuery_GetTimeSamples")]
		public static extern bool UsdGeomXformable_XformQuery_GetTimeSamples(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_XformQuery_IsAttributeIncludedInLocalTransform")]
		public static extern bool UsdGeomXformable_XformQuery_IsAttributeIncludedInLocalTransform(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomXformable_XformQuery")]
		public static extern void delete_UsdGeomXformable_XformQuery(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddXformOp__SWIG_0")]
		public static extern IntPtr UsdGeomXformable_AddXformOp__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, HandleRef jarg4, bool jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddXformOp__SWIG_1")]
		public static extern IntPtr UsdGeomXformable_AddXformOp__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddXformOp__SWIG_2")]
		public static extern IntPtr UsdGeomXformable_AddXformOp__SWIG_2(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddXformOp__SWIG_3")]
		public static extern IntPtr UsdGeomXformable_AddXformOp__SWIG_3(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddTranslateOp__SWIG_0")]
		public static extern IntPtr UsdGeomXformable_AddTranslateOp__SWIG_0(HandleRef jarg1, int jarg2, HandleRef jarg3, bool jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddTranslateOp__SWIG_1")]
		public static extern IntPtr UsdGeomXformable_AddTranslateOp__SWIG_1(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddTranslateOp__SWIG_2")]
		public static extern IntPtr UsdGeomXformable_AddTranslateOp__SWIG_2(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddTranslateOp__SWIG_3")]
		public static extern IntPtr UsdGeomXformable_AddTranslateOp__SWIG_3(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddScaleOp__SWIG_0")]
		public static extern IntPtr UsdGeomXformable_AddScaleOp__SWIG_0(HandleRef jarg1, int jarg2, HandleRef jarg3, bool jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddScaleOp__SWIG_1")]
		public static extern IntPtr UsdGeomXformable_AddScaleOp__SWIG_1(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddScaleOp__SWIG_2")]
		public static extern IntPtr UsdGeomXformable_AddScaleOp__SWIG_2(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddScaleOp__SWIG_3")]
		public static extern IntPtr UsdGeomXformable_AddScaleOp__SWIG_3(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateXOp__SWIG_0")]
		public static extern IntPtr UsdGeomXformable_AddRotateXOp__SWIG_0(HandleRef jarg1, int jarg2, HandleRef jarg3, bool jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateXOp__SWIG_1")]
		public static extern IntPtr UsdGeomXformable_AddRotateXOp__SWIG_1(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateXOp__SWIG_2")]
		public static extern IntPtr UsdGeomXformable_AddRotateXOp__SWIG_2(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateXOp__SWIG_3")]
		public static extern IntPtr UsdGeomXformable_AddRotateXOp__SWIG_3(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateYOp__SWIG_0")]
		public static extern IntPtr UsdGeomXformable_AddRotateYOp__SWIG_0(HandleRef jarg1, int jarg2, HandleRef jarg3, bool jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateYOp__SWIG_1")]
		public static extern IntPtr UsdGeomXformable_AddRotateYOp__SWIG_1(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateYOp__SWIG_2")]
		public static extern IntPtr UsdGeomXformable_AddRotateYOp__SWIG_2(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateYOp__SWIG_3")]
		public static extern IntPtr UsdGeomXformable_AddRotateYOp__SWIG_3(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateZOp__SWIG_0")]
		public static extern IntPtr UsdGeomXformable_AddRotateZOp__SWIG_0(HandleRef jarg1, int jarg2, HandleRef jarg3, bool jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateZOp__SWIG_1")]
		public static extern IntPtr UsdGeomXformable_AddRotateZOp__SWIG_1(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateZOp__SWIG_2")]
		public static extern IntPtr UsdGeomXformable_AddRotateZOp__SWIG_2(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateZOp__SWIG_3")]
		public static extern IntPtr UsdGeomXformable_AddRotateZOp__SWIG_3(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateXYZOp__SWIG_0")]
		public static extern IntPtr UsdGeomXformable_AddRotateXYZOp__SWIG_0(HandleRef jarg1, int jarg2, HandleRef jarg3, bool jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateXYZOp__SWIG_1")]
		public static extern IntPtr UsdGeomXformable_AddRotateXYZOp__SWIG_1(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateXYZOp__SWIG_2")]
		public static extern IntPtr UsdGeomXformable_AddRotateXYZOp__SWIG_2(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateXYZOp__SWIG_3")]
		public static extern IntPtr UsdGeomXformable_AddRotateXYZOp__SWIG_3(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateXZYOp__SWIG_0")]
		public static extern IntPtr UsdGeomXformable_AddRotateXZYOp__SWIG_0(HandleRef jarg1, int jarg2, HandleRef jarg3, bool jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateXZYOp__SWIG_1")]
		public static extern IntPtr UsdGeomXformable_AddRotateXZYOp__SWIG_1(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateXZYOp__SWIG_2")]
		public static extern IntPtr UsdGeomXformable_AddRotateXZYOp__SWIG_2(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateXZYOp__SWIG_3")]
		public static extern IntPtr UsdGeomXformable_AddRotateXZYOp__SWIG_3(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateYXZOp__SWIG_0")]
		public static extern IntPtr UsdGeomXformable_AddRotateYXZOp__SWIG_0(HandleRef jarg1, int jarg2, HandleRef jarg3, bool jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateYXZOp__SWIG_1")]
		public static extern IntPtr UsdGeomXformable_AddRotateYXZOp__SWIG_1(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateYXZOp__SWIG_2")]
		public static extern IntPtr UsdGeomXformable_AddRotateYXZOp__SWIG_2(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateYXZOp__SWIG_3")]
		public static extern IntPtr UsdGeomXformable_AddRotateYXZOp__SWIG_3(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateYZXOp__SWIG_0")]
		public static extern IntPtr UsdGeomXformable_AddRotateYZXOp__SWIG_0(HandleRef jarg1, int jarg2, HandleRef jarg3, bool jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateYZXOp__SWIG_1")]
		public static extern IntPtr UsdGeomXformable_AddRotateYZXOp__SWIG_1(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateYZXOp__SWIG_2")]
		public static extern IntPtr UsdGeomXformable_AddRotateYZXOp__SWIG_2(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateYZXOp__SWIG_3")]
		public static extern IntPtr UsdGeomXformable_AddRotateYZXOp__SWIG_3(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateZXYOp__SWIG_0")]
		public static extern IntPtr UsdGeomXformable_AddRotateZXYOp__SWIG_0(HandleRef jarg1, int jarg2, HandleRef jarg3, bool jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateZXYOp__SWIG_1")]
		public static extern IntPtr UsdGeomXformable_AddRotateZXYOp__SWIG_1(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateZXYOp__SWIG_2")]
		public static extern IntPtr UsdGeomXformable_AddRotateZXYOp__SWIG_2(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateZXYOp__SWIG_3")]
		public static extern IntPtr UsdGeomXformable_AddRotateZXYOp__SWIG_3(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateZYXOp__SWIG_0")]
		public static extern IntPtr UsdGeomXformable_AddRotateZYXOp__SWIG_0(HandleRef jarg1, int jarg2, HandleRef jarg3, bool jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateZYXOp__SWIG_1")]
		public static extern IntPtr UsdGeomXformable_AddRotateZYXOp__SWIG_1(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateZYXOp__SWIG_2")]
		public static extern IntPtr UsdGeomXformable_AddRotateZYXOp__SWIG_2(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddRotateZYXOp__SWIG_3")]
		public static extern IntPtr UsdGeomXformable_AddRotateZYXOp__SWIG_3(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddOrientOp__SWIG_0")]
		public static extern IntPtr UsdGeomXformable_AddOrientOp__SWIG_0(HandleRef jarg1, int jarg2, HandleRef jarg3, bool jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddOrientOp__SWIG_1")]
		public static extern IntPtr UsdGeomXformable_AddOrientOp__SWIG_1(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddOrientOp__SWIG_2")]
		public static extern IntPtr UsdGeomXformable_AddOrientOp__SWIG_2(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddOrientOp__SWIG_3")]
		public static extern IntPtr UsdGeomXformable_AddOrientOp__SWIG_3(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddTransformOp__SWIG_0")]
		public static extern IntPtr UsdGeomXformable_AddTransformOp__SWIG_0(HandleRef jarg1, int jarg2, HandleRef jarg3, bool jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddTransformOp__SWIG_1")]
		public static extern IntPtr UsdGeomXformable_AddTransformOp__SWIG_1(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddTransformOp__SWIG_2")]
		public static extern IntPtr UsdGeomXformable_AddTransformOp__SWIG_2(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_AddTransformOp__SWIG_3")]
		public static extern IntPtr UsdGeomXformable_AddTransformOp__SWIG_3(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_SetResetXformStack")]
		public static extern bool UsdGeomXformable_SetResetXformStack(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_GetResetXformStack")]
		public static extern bool UsdGeomXformable_GetResetXformStack(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_SetXformOpOrder__SWIG_0")]
		public static extern bool UsdGeomXformable_SetXformOpOrder__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_SetXformOpOrder__SWIG_1")]
		public static extern bool UsdGeomXformable_SetXformOpOrder__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_GetOrderedXformOps")]
		public static extern IntPtr UsdGeomXformable_GetOrderedXformOps(HandleRef jarg1, out bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_ClearXformOpOrder")]
		public static extern bool UsdGeomXformable_ClearXformOpOrder(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_MakeMatrixXform")]
		public static extern IntPtr UsdGeomXformable_MakeMatrixXform(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_TransformMightBeTimeVarying__SWIG_0")]
		public static extern bool UsdGeomXformable_TransformMightBeTimeVarying__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_TransformMightBeTimeVarying__SWIG_1")]
		public static extern bool UsdGeomXformable_TransformMightBeTimeVarying__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_GetTimeSamples__SWIG_0")]
		public static extern bool UsdGeomXformable_GetTimeSamples__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_GetTimeSamples__SWIG_1")]
		public static extern bool UsdGeomXformable_GetTimeSamples__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_GetLocalTransformation__SWIG_0")]
		public static extern bool UsdGeomXformable_GetLocalTransformation__SWIG_0(HandleRef jarg1, HandleRef jarg2, out bool jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_GetLocalTransformation__SWIG_1")]
		public static extern bool UsdGeomXformable_GetLocalTransformation__SWIG_1(HandleRef jarg1, HandleRef jarg2, out bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_GetLocalTransformation__SWIG_2")]
		public static extern bool UsdGeomXformable_GetLocalTransformation__SWIG_2(HandleRef jarg1, HandleRef jarg2, out bool jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_GetLocalTransformation__SWIG_3")]
		public static extern bool UsdGeomXformable_GetLocalTransformation__SWIG_3(HandleRef jarg1, HandleRef jarg2, out bool jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_GetLocalTransformation__SWIG_4")]
		public static extern bool UsdGeomXformable_GetLocalTransformation__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_IsTransformationAffectedByAttrNamed")]
		public static extern bool UsdGeomXformable_IsTransformationAffectedByAttrNamed(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomBoundable__SWIG_0")]
		public static extern IntPtr new_UsdGeomBoundable__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomBoundable__SWIG_1")]
		public static extern IntPtr new_UsdGeomBoundable__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomBoundable__SWIG_2")]
		public static extern IntPtr new_UsdGeomBoundable__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomBoundable")]
		public static extern void delete_UsdGeomBoundable(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBoundable_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomBoundable_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBoundable_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomBoundable_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBoundable_Get")]
		public static extern IntPtr UsdGeomBoundable_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBoundable_GetExtentAttr")]
		public static extern IntPtr UsdGeomBoundable_GetExtentAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBoundable_CreateExtentAttr__SWIG_0")]
		public static extern IntPtr UsdGeomBoundable_CreateExtentAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBoundable_CreateExtentAttr__SWIG_1")]
		public static extern IntPtr UsdGeomBoundable_CreateExtentAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBoundable_CreateExtentAttr__SWIG_2")]
		public static extern IntPtr UsdGeomBoundable_CreateExtentAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBoundable_ComputeExtent")]
		public static extern bool UsdGeomBoundable_ComputeExtent(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBoundable_ComputeExtentFromPlugins__SWIG_0")]
		public static extern bool UsdGeomBoundable_ComputeExtentFromPlugins__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBoundable_ComputeExtentFromPlugins__SWIG_1")]
		public static extern bool UsdGeomBoundable_ComputeExtentFromPlugins__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomCamera__SWIG_0")]
		public static extern IntPtr new_UsdGeomCamera__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomCamera__SWIG_1")]
		public static extern IntPtr new_UsdGeomCamera__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomCamera__SWIG_2")]
		public static extern IntPtr new_UsdGeomCamera__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomCamera")]
		public static extern void delete_UsdGeomCamera(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomCamera_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomCamera_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_Get")]
		public static extern IntPtr UsdGeomCamera_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_Define")]
		public static extern IntPtr UsdGeomCamera_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_GetProjectionAttr")]
		public static extern IntPtr UsdGeomCamera_GetProjectionAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateProjectionAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCamera_CreateProjectionAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateProjectionAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCamera_CreateProjectionAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateProjectionAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCamera_CreateProjectionAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_GetHorizontalApertureAttr")]
		public static extern IntPtr UsdGeomCamera_GetHorizontalApertureAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateHorizontalApertureAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCamera_CreateHorizontalApertureAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateHorizontalApertureAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCamera_CreateHorizontalApertureAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateHorizontalApertureAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCamera_CreateHorizontalApertureAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_GetVerticalApertureAttr")]
		public static extern IntPtr UsdGeomCamera_GetVerticalApertureAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateVerticalApertureAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCamera_CreateVerticalApertureAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateVerticalApertureAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCamera_CreateVerticalApertureAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateVerticalApertureAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCamera_CreateVerticalApertureAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_GetHorizontalApertureOffsetAttr")]
		public static extern IntPtr UsdGeomCamera_GetHorizontalApertureOffsetAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateHorizontalApertureOffsetAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCamera_CreateHorizontalApertureOffsetAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateHorizontalApertureOffsetAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCamera_CreateHorizontalApertureOffsetAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateHorizontalApertureOffsetAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCamera_CreateHorizontalApertureOffsetAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_GetVerticalApertureOffsetAttr")]
		public static extern IntPtr UsdGeomCamera_GetVerticalApertureOffsetAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateVerticalApertureOffsetAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCamera_CreateVerticalApertureOffsetAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateVerticalApertureOffsetAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCamera_CreateVerticalApertureOffsetAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateVerticalApertureOffsetAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCamera_CreateVerticalApertureOffsetAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_GetFocalLengthAttr")]
		public static extern IntPtr UsdGeomCamera_GetFocalLengthAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateFocalLengthAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCamera_CreateFocalLengthAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateFocalLengthAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCamera_CreateFocalLengthAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateFocalLengthAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCamera_CreateFocalLengthAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_GetClippingRangeAttr")]
		public static extern IntPtr UsdGeomCamera_GetClippingRangeAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateClippingRangeAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCamera_CreateClippingRangeAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateClippingRangeAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCamera_CreateClippingRangeAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateClippingRangeAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCamera_CreateClippingRangeAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_GetClippingPlanesAttr")]
		public static extern IntPtr UsdGeomCamera_GetClippingPlanesAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateClippingPlanesAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCamera_CreateClippingPlanesAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateClippingPlanesAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCamera_CreateClippingPlanesAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateClippingPlanesAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCamera_CreateClippingPlanesAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_GetFStopAttr")]
		public static extern IntPtr UsdGeomCamera_GetFStopAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateFStopAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCamera_CreateFStopAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateFStopAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCamera_CreateFStopAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateFStopAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCamera_CreateFStopAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_GetFocusDistanceAttr")]
		public static extern IntPtr UsdGeomCamera_GetFocusDistanceAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateFocusDistanceAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCamera_CreateFocusDistanceAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateFocusDistanceAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCamera_CreateFocusDistanceAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateFocusDistanceAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCamera_CreateFocusDistanceAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_GetStereoRoleAttr")]
		public static extern IntPtr UsdGeomCamera_GetStereoRoleAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateStereoRoleAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCamera_CreateStereoRoleAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateStereoRoleAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCamera_CreateStereoRoleAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateStereoRoleAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCamera_CreateStereoRoleAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_GetShutterOpenAttr")]
		public static extern IntPtr UsdGeomCamera_GetShutterOpenAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateShutterOpenAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCamera_CreateShutterOpenAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateShutterOpenAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCamera_CreateShutterOpenAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateShutterOpenAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCamera_CreateShutterOpenAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_GetShutterCloseAttr")]
		public static extern IntPtr UsdGeomCamera_GetShutterCloseAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateShutterCloseAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCamera_CreateShutterCloseAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateShutterCloseAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCamera_CreateShutterCloseAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateShutterCloseAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCamera_CreateShutterCloseAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_GetExposureAttr")]
		public static extern IntPtr UsdGeomCamera_GetExposureAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateExposureAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCamera_CreateExposureAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateExposureAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCamera_CreateExposureAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_CreateExposureAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCamera_CreateExposureAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_GetCamera")]
		public static extern IntPtr UsdGeomCamera_GetCamera(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_SetFromCamera")]
		public static extern void UsdGeomCamera_SetFromCamera(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomGprim__SWIG_0")]
		public static extern IntPtr new_UsdGeomGprim__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomGprim__SWIG_1")]
		public static extern IntPtr new_UsdGeomGprim__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomGprim__SWIG_2")]
		public static extern IntPtr new_UsdGeomGprim__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomGprim")]
		public static extern void delete_UsdGeomGprim(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomGprim_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomGprim_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_Get")]
		public static extern IntPtr UsdGeomGprim_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_GetDisplayColorAttr")]
		public static extern IntPtr UsdGeomGprim_GetDisplayColorAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_CreateDisplayColorAttr__SWIG_0")]
		public static extern IntPtr UsdGeomGprim_CreateDisplayColorAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_CreateDisplayColorAttr__SWIG_1")]
		public static extern IntPtr UsdGeomGprim_CreateDisplayColorAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_CreateDisplayColorAttr__SWIG_2")]
		public static extern IntPtr UsdGeomGprim_CreateDisplayColorAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_GetDisplayOpacityAttr")]
		public static extern IntPtr UsdGeomGprim_GetDisplayOpacityAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_CreateDisplayOpacityAttr__SWIG_0")]
		public static extern IntPtr UsdGeomGprim_CreateDisplayOpacityAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_CreateDisplayOpacityAttr__SWIG_1")]
		public static extern IntPtr UsdGeomGprim_CreateDisplayOpacityAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_CreateDisplayOpacityAttr__SWIG_2")]
		public static extern IntPtr UsdGeomGprim_CreateDisplayOpacityAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_GetDoubleSidedAttr")]
		public static extern IntPtr UsdGeomGprim_GetDoubleSidedAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_CreateDoubleSidedAttr__SWIG_0")]
		public static extern IntPtr UsdGeomGprim_CreateDoubleSidedAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_CreateDoubleSidedAttr__SWIG_1")]
		public static extern IntPtr UsdGeomGprim_CreateDoubleSidedAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_CreateDoubleSidedAttr__SWIG_2")]
		public static extern IntPtr UsdGeomGprim_CreateDoubleSidedAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_GetOrientationAttr")]
		public static extern IntPtr UsdGeomGprim_GetOrientationAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_CreateOrientationAttr__SWIG_0")]
		public static extern IntPtr UsdGeomGprim_CreateOrientationAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_CreateOrientationAttr__SWIG_1")]
		public static extern IntPtr UsdGeomGprim_CreateOrientationAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_CreateOrientationAttr__SWIG_2")]
		public static extern IntPtr UsdGeomGprim_CreateOrientationAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_GetDisplayColorPrimvar")]
		public static extern IntPtr UsdGeomGprim_GetDisplayColorPrimvar(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_CreateDisplayColorPrimvar__SWIG_0")]
		public static extern IntPtr UsdGeomGprim_CreateDisplayColorPrimvar__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_CreateDisplayColorPrimvar__SWIG_1")]
		public static extern IntPtr UsdGeomGprim_CreateDisplayColorPrimvar__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_CreateDisplayColorPrimvar__SWIG_2")]
		public static extern IntPtr UsdGeomGprim_CreateDisplayColorPrimvar__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_GetDisplayOpacityPrimvar")]
		public static extern IntPtr UsdGeomGprim_GetDisplayOpacityPrimvar(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_CreateDisplayOpacityPrimvar__SWIG_0")]
		public static extern IntPtr UsdGeomGprim_CreateDisplayOpacityPrimvar__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_CreateDisplayOpacityPrimvar__SWIG_1")]
		public static extern IntPtr UsdGeomGprim_CreateDisplayOpacityPrimvar__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_CreateDisplayOpacityPrimvar__SWIG_2")]
		public static extern IntPtr UsdGeomGprim_CreateDisplayOpacityPrimvar__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomCapsule__SWIG_0")]
		public static extern IntPtr new_UsdGeomCapsule__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomCapsule__SWIG_1")]
		public static extern IntPtr new_UsdGeomCapsule__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomCapsule__SWIG_2")]
		public static extern IntPtr new_UsdGeomCapsule__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomCapsule")]
		public static extern void delete_UsdGeomCapsule(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCapsule_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomCapsule_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCapsule_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomCapsule_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCapsule_Get")]
		public static extern IntPtr UsdGeomCapsule_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCapsule_Define")]
		public static extern IntPtr UsdGeomCapsule_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCapsule_GetHeightAttr")]
		public static extern IntPtr UsdGeomCapsule_GetHeightAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCapsule_CreateHeightAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCapsule_CreateHeightAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCapsule_CreateHeightAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCapsule_CreateHeightAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCapsule_CreateHeightAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCapsule_CreateHeightAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCapsule_GetRadiusAttr")]
		public static extern IntPtr UsdGeomCapsule_GetRadiusAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCapsule_CreateRadiusAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCapsule_CreateRadiusAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCapsule_CreateRadiusAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCapsule_CreateRadiusAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCapsule_CreateRadiusAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCapsule_CreateRadiusAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCapsule_GetAxisAttr")]
		public static extern IntPtr UsdGeomCapsule_GetAxisAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCapsule_CreateAxisAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCapsule_CreateAxisAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCapsule_CreateAxisAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCapsule_CreateAxisAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCapsule_CreateAxisAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCapsule_CreateAxisAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCapsule_GetExtentAttr")]
		public static extern IntPtr UsdGeomCapsule_GetExtentAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCapsule_CreateExtentAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCapsule_CreateExtentAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCapsule_CreateExtentAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCapsule_CreateExtentAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCapsule_CreateExtentAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCapsule_CreateExtentAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCapsule_ComputeExtent__SWIG_0")]
		public static extern bool UsdGeomCapsule_ComputeExtent__SWIG_0(double jarg1, double jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCapsule_ComputeExtent__SWIG_1")]
		public static extern bool UsdGeomCapsule_ComputeExtent__SWIG_1(double jarg1, double jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomCone__SWIG_0")]
		public static extern IntPtr new_UsdGeomCone__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomCone__SWIG_1")]
		public static extern IntPtr new_UsdGeomCone__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomCone__SWIG_2")]
		public static extern IntPtr new_UsdGeomCone__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomCone")]
		public static extern void delete_UsdGeomCone(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCone_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomCone_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCone_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomCone_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCone_Get")]
		public static extern IntPtr UsdGeomCone_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCone_Define")]
		public static extern IntPtr UsdGeomCone_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCone_GetHeightAttr")]
		public static extern IntPtr UsdGeomCone_GetHeightAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCone_CreateHeightAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCone_CreateHeightAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCone_CreateHeightAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCone_CreateHeightAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCone_CreateHeightAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCone_CreateHeightAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCone_GetRadiusAttr")]
		public static extern IntPtr UsdGeomCone_GetRadiusAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCone_CreateRadiusAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCone_CreateRadiusAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCone_CreateRadiusAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCone_CreateRadiusAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCone_CreateRadiusAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCone_CreateRadiusAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCone_GetAxisAttr")]
		public static extern IntPtr UsdGeomCone_GetAxisAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCone_CreateAxisAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCone_CreateAxisAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCone_CreateAxisAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCone_CreateAxisAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCone_CreateAxisAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCone_CreateAxisAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCone_GetExtentAttr")]
		public static extern IntPtr UsdGeomCone_GetExtentAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCone_CreateExtentAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCone_CreateExtentAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCone_CreateExtentAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCone_CreateExtentAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCone_CreateExtentAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCone_CreateExtentAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCone_ComputeExtent__SWIG_0")]
		public static extern bool UsdGeomCone_ComputeExtent__SWIG_0(double jarg1, double jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCone_ComputeExtent__SWIG_1")]
		public static extern bool UsdGeomCone_ComputeExtent__SWIG_1(double jarg1, double jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomConstraintTarget__SWIG_0")]
		public static extern IntPtr new_UsdGeomConstraintTarget__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomConstraintTarget__SWIG_1")]
		public static extern IntPtr new_UsdGeomConstraintTarget__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTarget_IsValid")]
		public static extern bool UsdGeomConstraintTarget_IsValid(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTarget_GetAttr")]
		public static extern IntPtr UsdGeomConstraintTarget_GetAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTarget_IsDefined")]
		public static extern bool UsdGeomConstraintTarget_IsDefined(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTarget_Get__SWIG_0")]
		public static extern bool UsdGeomConstraintTarget_Get__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTarget_Get__SWIG_1")]
		public static extern bool UsdGeomConstraintTarget_Get__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTarget_Set__SWIG_0")]
		public static extern bool UsdGeomConstraintTarget_Set__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTarget_Set__SWIG_1")]
		public static extern bool UsdGeomConstraintTarget_Set__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTarget_GetIdentifier")]
		public static extern IntPtr UsdGeomConstraintTarget_GetIdentifier(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTarget_SetIdentifier")]
		public static extern void UsdGeomConstraintTarget_SetIdentifier(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTarget_GetConstraintAttrName")]
		public static extern IntPtr UsdGeomConstraintTarget_GetConstraintAttrName(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTarget_ComputeInWorldSpace__SWIG_0")]
		public static extern IntPtr UsdGeomConstraintTarget_ComputeInWorldSpace__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTarget_ComputeInWorldSpace__SWIG_1")]
		public static extern IntPtr UsdGeomConstraintTarget_ComputeInWorldSpace__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTarget_ComputeInWorldSpace__SWIG_2")]
		public static extern IntPtr UsdGeomConstraintTarget_ComputeInWorldSpace__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomConstraintTarget")]
		public static extern void delete_UsdGeomConstraintTarget(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomCube__SWIG_0")]
		public static extern IntPtr new_UsdGeomCube__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomCube__SWIG_1")]
		public static extern IntPtr new_UsdGeomCube__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomCube__SWIG_2")]
		public static extern IntPtr new_UsdGeomCube__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomCube")]
		public static extern void delete_UsdGeomCube(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCube_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomCube_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCube_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomCube_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCube_Get")]
		public static extern IntPtr UsdGeomCube_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCube_Define")]
		public static extern IntPtr UsdGeomCube_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCube_GetSizeAttr")]
		public static extern IntPtr UsdGeomCube_GetSizeAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCube_CreateSizeAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCube_CreateSizeAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCube_CreateSizeAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCube_CreateSizeAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCube_CreateSizeAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCube_CreateSizeAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCube_GetExtentAttr")]
		public static extern IntPtr UsdGeomCube_GetExtentAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCube_CreateExtentAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCube_CreateExtentAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCube_CreateExtentAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCube_CreateExtentAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCube_CreateExtentAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCube_CreateExtentAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCube_ComputeExtent__SWIG_0")]
		public static extern bool UsdGeomCube_ComputeExtent__SWIG_0(double jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCube_ComputeExtent__SWIG_1")]
		public static extern bool UsdGeomCube_ComputeExtent__SWIG_1(double jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomCylinder__SWIG_0")]
		public static extern IntPtr new_UsdGeomCylinder__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomCylinder__SWIG_1")]
		public static extern IntPtr new_UsdGeomCylinder__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomCylinder__SWIG_2")]
		public static extern IntPtr new_UsdGeomCylinder__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomCylinder")]
		public static extern void delete_UsdGeomCylinder(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCylinder_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomCylinder_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCylinder_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomCylinder_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCylinder_Get")]
		public static extern IntPtr UsdGeomCylinder_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCylinder_Define")]
		public static extern IntPtr UsdGeomCylinder_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCylinder_GetHeightAttr")]
		public static extern IntPtr UsdGeomCylinder_GetHeightAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCylinder_CreateHeightAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCylinder_CreateHeightAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCylinder_CreateHeightAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCylinder_CreateHeightAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCylinder_CreateHeightAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCylinder_CreateHeightAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCylinder_GetRadiusAttr")]
		public static extern IntPtr UsdGeomCylinder_GetRadiusAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCylinder_CreateRadiusAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCylinder_CreateRadiusAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCylinder_CreateRadiusAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCylinder_CreateRadiusAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCylinder_CreateRadiusAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCylinder_CreateRadiusAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCylinder_GetAxisAttr")]
		public static extern IntPtr UsdGeomCylinder_GetAxisAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCylinder_CreateAxisAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCylinder_CreateAxisAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCylinder_CreateAxisAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCylinder_CreateAxisAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCylinder_CreateAxisAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCylinder_CreateAxisAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCylinder_GetExtentAttr")]
		public static extern IntPtr UsdGeomCylinder_GetExtentAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCylinder_CreateExtentAttr__SWIG_0")]
		public static extern IntPtr UsdGeomCylinder_CreateExtentAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCylinder_CreateExtentAttr__SWIG_1")]
		public static extern IntPtr UsdGeomCylinder_CreateExtentAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCylinder_CreateExtentAttr__SWIG_2")]
		public static extern IntPtr UsdGeomCylinder_CreateExtentAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCylinder_ComputeExtent__SWIG_0")]
		public static extern bool UsdGeomCylinder_ComputeExtent__SWIG_0(double jarg1, double jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCylinder_ComputeExtent__SWIG_1")]
		public static extern bool UsdGeomCylinder_ComputeExtent__SWIG_1(double jarg1, double jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomImageable__SWIG_0")]
		public static extern IntPtr new_UsdGeomImageable__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomImageable__SWIG_1")]
		public static extern IntPtr new_UsdGeomImageable__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomImageable__SWIG_2")]
		public static extern IntPtr new_UsdGeomImageable__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomImageable")]
		public static extern void delete_UsdGeomImageable(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomImageable_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomImageable_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_Get")]
		public static extern IntPtr UsdGeomImageable_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_GetVisibilityAttr")]
		public static extern IntPtr UsdGeomImageable_GetVisibilityAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_CreateVisibilityAttr__SWIG_0")]
		public static extern IntPtr UsdGeomImageable_CreateVisibilityAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_CreateVisibilityAttr__SWIG_1")]
		public static extern IntPtr UsdGeomImageable_CreateVisibilityAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_CreateVisibilityAttr__SWIG_2")]
		public static extern IntPtr UsdGeomImageable_CreateVisibilityAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_GetPurposeAttr")]
		public static extern IntPtr UsdGeomImageable_GetPurposeAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_CreatePurposeAttr__SWIG_0")]
		public static extern IntPtr UsdGeomImageable_CreatePurposeAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_CreatePurposeAttr__SWIG_1")]
		public static extern IntPtr UsdGeomImageable_CreatePurposeAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_CreatePurposeAttr__SWIG_2")]
		public static extern IntPtr UsdGeomImageable_CreatePurposeAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_GetProxyPrimRel")]
		public static extern IntPtr UsdGeomImageable_GetProxyPrimRel(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_CreateProxyPrimRel")]
		public static extern IntPtr UsdGeomImageable_CreateProxyPrimRel(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_GetOrderedPurposeTokens")]
		public static extern IntPtr UsdGeomImageable_GetOrderedPurposeTokens();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_MakeVisible__SWIG_0")]
		public static extern void UsdGeomImageable_MakeVisible__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_MakeVisible__SWIG_1")]
		public static extern void UsdGeomImageable_MakeVisible__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_MakeInvisible__SWIG_0")]
		public static extern void UsdGeomImageable_MakeInvisible__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_MakeInvisible__SWIG_1")]
		public static extern void UsdGeomImageable_MakeInvisible__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputeVisibility__SWIG_0")]
		public static extern IntPtr UsdGeomImageable_ComputeVisibility__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputeVisibility__SWIG_1")]
		public static extern IntPtr UsdGeomImageable_ComputeVisibility__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_GetPurposeVisibilityAttr__SWIG_0")]
		public static extern IntPtr UsdGeomImageable_GetPurposeVisibilityAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_GetPurposeVisibilityAttr__SWIG_1")]
		public static extern IntPtr UsdGeomImageable_GetPurposeVisibilityAttr__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputeEffectiveVisibility__SWIG_0")]
		public static extern IntPtr UsdGeomImageable_ComputeEffectiveVisibility__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputeEffectiveVisibility__SWIG_1")]
		public static extern IntPtr UsdGeomImageable_ComputeEffectiveVisibility__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputeEffectiveVisibility__SWIG_2")]
		public static extern IntPtr UsdGeomImageable_ComputeEffectiveVisibility__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomImageable_PurposeInfo__SWIG_0")]
		public static extern IntPtr new_UsdGeomImageable_PurposeInfo__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomImageable_PurposeInfo__SWIG_1")]
		public static extern IntPtr new_UsdGeomImageable_PurposeInfo__SWIG_1(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_PurposeInfo_purpose_set")]
		public static extern void UsdGeomImageable_PurposeInfo_purpose_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_PurposeInfo_purpose_get")]
		public static extern IntPtr UsdGeomImageable_PurposeInfo_purpose_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_PurposeInfo_isInheritable_set")]
		public static extern void UsdGeomImageable_PurposeInfo_isInheritable_set(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_PurposeInfo_isInheritable_get")]
		public static extern bool UsdGeomImageable_PurposeInfo_isInheritable_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_PurposeInfo_GetInheritablePurpose")]
		public static extern IntPtr UsdGeomImageable_PurposeInfo_GetInheritablePurpose(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomImageable_PurposeInfo")]
		public static extern void delete_UsdGeomImageable_PurposeInfo(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputePurposeInfo__SWIG_0")]
		public static extern IntPtr UsdGeomImageable_ComputePurposeInfo__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputePurposeInfo__SWIG_1")]
		public static extern IntPtr UsdGeomImageable_ComputePurposeInfo__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputePurpose")]
		public static extern IntPtr UsdGeomImageable_ComputePurpose(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputeProxyPrim__SWIG_0")]
		public static extern IntPtr UsdGeomImageable_ComputeProxyPrim__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputeProxyPrim__SWIG_1")]
		public static extern IntPtr UsdGeomImageable_ComputeProxyPrim__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_SetProxyPrim__SWIG_0")]
		public static extern bool UsdGeomImageable_SetProxyPrim__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_SetProxyPrim__SWIG_1")]
		public static extern bool UsdGeomImageable_SetProxyPrim__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputeWorldBound__SWIG_0")]
		public static extern IntPtr UsdGeomImageable_ComputeWorldBound__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, HandleRef jarg6);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputeWorldBound__SWIG_1")]
		public static extern IntPtr UsdGeomImageable_ComputeWorldBound__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputeWorldBound__SWIG_2")]
		public static extern IntPtr UsdGeomImageable_ComputeWorldBound__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputeWorldBound__SWIG_3")]
		public static extern IntPtr UsdGeomImageable_ComputeWorldBound__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputeWorldBound__SWIG_4")]
		public static extern IntPtr UsdGeomImageable_ComputeWorldBound__SWIG_4(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputeLocalBound__SWIG_0")]
		public static extern IntPtr UsdGeomImageable_ComputeLocalBound__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, HandleRef jarg6);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputeLocalBound__SWIG_1")]
		public static extern IntPtr UsdGeomImageable_ComputeLocalBound__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputeLocalBound__SWIG_2")]
		public static extern IntPtr UsdGeomImageable_ComputeLocalBound__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputeLocalBound__SWIG_3")]
		public static extern IntPtr UsdGeomImageable_ComputeLocalBound__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputeLocalBound__SWIG_4")]
		public static extern IntPtr UsdGeomImageable_ComputeLocalBound__SWIG_4(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputeUntransformedBound__SWIG_0")]
		public static extern IntPtr UsdGeomImageable_ComputeUntransformedBound__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, HandleRef jarg6);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputeUntransformedBound__SWIG_1")]
		public static extern IntPtr UsdGeomImageable_ComputeUntransformedBound__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputeUntransformedBound__SWIG_2")]
		public static extern IntPtr UsdGeomImageable_ComputeUntransformedBound__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputeUntransformedBound__SWIG_3")]
		public static extern IntPtr UsdGeomImageable_ComputeUntransformedBound__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputeUntransformedBound__SWIG_4")]
		public static extern IntPtr UsdGeomImageable_ComputeUntransformedBound__SWIG_4(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputeLocalToWorldTransform")]
		public static extern IntPtr UsdGeomImageable_ComputeLocalToWorldTransform(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_ComputeParentToWorldTransform")]
		public static extern IntPtr UsdGeomImageable_ComputeParentToWorldTransform(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomMesh__SWIG_0")]
		public static extern IntPtr new_UsdGeomMesh__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomMesh__SWIG_1")]
		public static extern IntPtr new_UsdGeomMesh__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomMesh__SWIG_2")]
		public static extern IntPtr new_UsdGeomMesh__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomMesh")]
		public static extern void delete_UsdGeomMesh(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomMesh_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomMesh_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_Get")]
		public static extern IntPtr UsdGeomMesh_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_Define")]
		public static extern IntPtr UsdGeomMesh_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_GetFaceVertexIndicesAttr")]
		public static extern IntPtr UsdGeomMesh_GetFaceVertexIndicesAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateFaceVertexIndicesAttr__SWIG_0")]
		public static extern IntPtr UsdGeomMesh_CreateFaceVertexIndicesAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateFaceVertexIndicesAttr__SWIG_1")]
		public static extern IntPtr UsdGeomMesh_CreateFaceVertexIndicesAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateFaceVertexIndicesAttr__SWIG_2")]
		public static extern IntPtr UsdGeomMesh_CreateFaceVertexIndicesAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_GetFaceVertexCountsAttr")]
		public static extern IntPtr UsdGeomMesh_GetFaceVertexCountsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateFaceVertexCountsAttr__SWIG_0")]
		public static extern IntPtr UsdGeomMesh_CreateFaceVertexCountsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateFaceVertexCountsAttr__SWIG_1")]
		public static extern IntPtr UsdGeomMesh_CreateFaceVertexCountsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateFaceVertexCountsAttr__SWIG_2")]
		public static extern IntPtr UsdGeomMesh_CreateFaceVertexCountsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_GetSubdivisionSchemeAttr")]
		public static extern IntPtr UsdGeomMesh_GetSubdivisionSchemeAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateSubdivisionSchemeAttr__SWIG_0")]
		public static extern IntPtr UsdGeomMesh_CreateSubdivisionSchemeAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateSubdivisionSchemeAttr__SWIG_1")]
		public static extern IntPtr UsdGeomMesh_CreateSubdivisionSchemeAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateSubdivisionSchemeAttr__SWIG_2")]
		public static extern IntPtr UsdGeomMesh_CreateSubdivisionSchemeAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_GetInterpolateBoundaryAttr")]
		public static extern IntPtr UsdGeomMesh_GetInterpolateBoundaryAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateInterpolateBoundaryAttr__SWIG_0")]
		public static extern IntPtr UsdGeomMesh_CreateInterpolateBoundaryAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateInterpolateBoundaryAttr__SWIG_1")]
		public static extern IntPtr UsdGeomMesh_CreateInterpolateBoundaryAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateInterpolateBoundaryAttr__SWIG_2")]
		public static extern IntPtr UsdGeomMesh_CreateInterpolateBoundaryAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_GetFaceVaryingLinearInterpolationAttr")]
		public static extern IntPtr UsdGeomMesh_GetFaceVaryingLinearInterpolationAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateFaceVaryingLinearInterpolationAttr__SWIG_0")]
		public static extern IntPtr UsdGeomMesh_CreateFaceVaryingLinearInterpolationAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateFaceVaryingLinearInterpolationAttr__SWIG_1")]
		public static extern IntPtr UsdGeomMesh_CreateFaceVaryingLinearInterpolationAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateFaceVaryingLinearInterpolationAttr__SWIG_2")]
		public static extern IntPtr UsdGeomMesh_CreateFaceVaryingLinearInterpolationAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_GetTriangleSubdivisionRuleAttr")]
		public static extern IntPtr UsdGeomMesh_GetTriangleSubdivisionRuleAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateTriangleSubdivisionRuleAttr__SWIG_0")]
		public static extern IntPtr UsdGeomMesh_CreateTriangleSubdivisionRuleAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateTriangleSubdivisionRuleAttr__SWIG_1")]
		public static extern IntPtr UsdGeomMesh_CreateTriangleSubdivisionRuleAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateTriangleSubdivisionRuleAttr__SWIG_2")]
		public static extern IntPtr UsdGeomMesh_CreateTriangleSubdivisionRuleAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_GetHoleIndicesAttr")]
		public static extern IntPtr UsdGeomMesh_GetHoleIndicesAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateHoleIndicesAttr__SWIG_0")]
		public static extern IntPtr UsdGeomMesh_CreateHoleIndicesAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateHoleIndicesAttr__SWIG_1")]
		public static extern IntPtr UsdGeomMesh_CreateHoleIndicesAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateHoleIndicesAttr__SWIG_2")]
		public static extern IntPtr UsdGeomMesh_CreateHoleIndicesAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_GetCornerIndicesAttr")]
		public static extern IntPtr UsdGeomMesh_GetCornerIndicesAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateCornerIndicesAttr__SWIG_0")]
		public static extern IntPtr UsdGeomMesh_CreateCornerIndicesAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateCornerIndicesAttr__SWIG_1")]
		public static extern IntPtr UsdGeomMesh_CreateCornerIndicesAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateCornerIndicesAttr__SWIG_2")]
		public static extern IntPtr UsdGeomMesh_CreateCornerIndicesAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_GetCornerSharpnessesAttr")]
		public static extern IntPtr UsdGeomMesh_GetCornerSharpnessesAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateCornerSharpnessesAttr__SWIG_0")]
		public static extern IntPtr UsdGeomMesh_CreateCornerSharpnessesAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateCornerSharpnessesAttr__SWIG_1")]
		public static extern IntPtr UsdGeomMesh_CreateCornerSharpnessesAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateCornerSharpnessesAttr__SWIG_2")]
		public static extern IntPtr UsdGeomMesh_CreateCornerSharpnessesAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_GetCreaseIndicesAttr")]
		public static extern IntPtr UsdGeomMesh_GetCreaseIndicesAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateCreaseIndicesAttr__SWIG_0")]
		public static extern IntPtr UsdGeomMesh_CreateCreaseIndicesAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateCreaseIndicesAttr__SWIG_1")]
		public static extern IntPtr UsdGeomMesh_CreateCreaseIndicesAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateCreaseIndicesAttr__SWIG_2")]
		public static extern IntPtr UsdGeomMesh_CreateCreaseIndicesAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_GetCreaseLengthsAttr")]
		public static extern IntPtr UsdGeomMesh_GetCreaseLengthsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateCreaseLengthsAttr__SWIG_0")]
		public static extern IntPtr UsdGeomMesh_CreateCreaseLengthsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateCreaseLengthsAttr__SWIG_1")]
		public static extern IntPtr UsdGeomMesh_CreateCreaseLengthsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateCreaseLengthsAttr__SWIG_2")]
		public static extern IntPtr UsdGeomMesh_CreateCreaseLengthsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_GetCreaseSharpnessesAttr")]
		public static extern IntPtr UsdGeomMesh_GetCreaseSharpnessesAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateCreaseSharpnessesAttr__SWIG_0")]
		public static extern IntPtr UsdGeomMesh_CreateCreaseSharpnessesAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateCreaseSharpnessesAttr__SWIG_1")]
		public static extern IntPtr UsdGeomMesh_CreateCreaseSharpnessesAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_CreateCreaseSharpnessesAttr__SWIG_2")]
		public static extern IntPtr UsdGeomMesh_CreateCreaseSharpnessesAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_ValidateTopology__SWIG_0")]
		public static extern bool UsdGeomMesh_ValidateTopology__SWIG_0(HandleRef jarg1, HandleRef jarg2, uint jarg3, out string jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_ValidateTopology__SWIG_1")]
		public static extern bool UsdGeomMesh_ValidateTopology__SWIG_1(HandleRef jarg1, HandleRef jarg2, uint jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_IsSharpnessInfinite")]
		public static extern bool UsdGeomMesh_IsSharpnessInfinite(float jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_SHARPNESS_INFINITE_get")]
		public static extern float UsdGeomMesh_SHARPNESS_INFINITE_get();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_GetFaceCount__SWIG_0")]
		public static extern uint UsdGeomMesh_GetFaceCount__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_GetFaceCount__SWIG_1")]
		public static extern uint UsdGeomMesh_GetFaceCount__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_Triangulate")]
		public static extern void UsdGeomMesh_Triangulate(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGetStageUpAxis")]
		public static extern IntPtr UsdGeomGetStageUpAxis(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSetStageUpAxis")]
		public static extern bool UsdGeomSetStageUpAxis(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGetFallbackUpAxis")]
		public static extern IntPtr UsdGeomGetFallbackUpAxis();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGetStageMetersPerUnit")]
		public static extern double UsdGeomGetStageMetersPerUnit(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomStageHasAuthoredMetersPerUnit")]
		public static extern bool UsdGeomStageHasAuthoredMetersPerUnit(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSetStageMetersPerUnit")]
		public static extern bool UsdGeomSetStageMetersPerUnit(HandleRef jarg1, double jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomLinearUnitsAre__SWIG_0")]
		public static extern bool UsdGeomLinearUnitsAre__SWIG_0(double jarg1, double jarg2, double jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomLinearUnitsAre__SWIG_1")]
		public static extern bool UsdGeomLinearUnitsAre__SWIG_1(double jarg1, double jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomLinearUnits")]
		public static extern IntPtr new_UsdGeomLinearUnits();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomLinearUnits")]
		public static extern void delete_UsdGeomLinearUnits(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomModelAPI__SWIG_0")]
		public static extern IntPtr new_UsdGeomModelAPI__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomModelAPI__SWIG_1")]
		public static extern IntPtr new_UsdGeomModelAPI__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomModelAPI__SWIG_2")]
		public static extern IntPtr new_UsdGeomModelAPI__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomModelAPI")]
		public static extern void delete_UsdGeomModelAPI(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomModelAPI_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomModelAPI_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_Get")]
		public static extern IntPtr UsdGeomModelAPI_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CanApply__SWIG_0")]
		public static extern bool UsdGeomModelAPI_CanApply__SWIG_0(HandleRef jarg1, out string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CanApply__SWIG_1")]
		public static extern bool UsdGeomModelAPI_CanApply__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_Apply")]
		public static extern IntPtr UsdGeomModelAPI_Apply(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_GetModelDrawModeAttr")]
		public static extern IntPtr UsdGeomModelAPI_GetModelDrawModeAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelDrawModeAttr__SWIG_0")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelDrawModeAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelDrawModeAttr__SWIG_1")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelDrawModeAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelDrawModeAttr__SWIG_2")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelDrawModeAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_GetModelApplyDrawModeAttr")]
		public static extern IntPtr UsdGeomModelAPI_GetModelApplyDrawModeAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelApplyDrawModeAttr__SWIG_0")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelApplyDrawModeAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelApplyDrawModeAttr__SWIG_1")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelApplyDrawModeAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelApplyDrawModeAttr__SWIG_2")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelApplyDrawModeAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_GetModelDrawModeColorAttr")]
		public static extern IntPtr UsdGeomModelAPI_GetModelDrawModeColorAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelDrawModeColorAttr__SWIG_0")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelDrawModeColorAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelDrawModeColorAttr__SWIG_1")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelDrawModeColorAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelDrawModeColorAttr__SWIG_2")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelDrawModeColorAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_GetModelCardGeometryAttr")]
		public static extern IntPtr UsdGeomModelAPI_GetModelCardGeometryAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelCardGeometryAttr__SWIG_0")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelCardGeometryAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelCardGeometryAttr__SWIG_1")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelCardGeometryAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelCardGeometryAttr__SWIG_2")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelCardGeometryAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_GetModelCardTextureXPosAttr")]
		public static extern IntPtr UsdGeomModelAPI_GetModelCardTextureXPosAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelCardTextureXPosAttr__SWIG_0")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelCardTextureXPosAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelCardTextureXPosAttr__SWIG_1")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelCardTextureXPosAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelCardTextureXPosAttr__SWIG_2")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelCardTextureXPosAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_GetModelCardTextureYPosAttr")]
		public static extern IntPtr UsdGeomModelAPI_GetModelCardTextureYPosAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelCardTextureYPosAttr__SWIG_0")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelCardTextureYPosAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelCardTextureYPosAttr__SWIG_1")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelCardTextureYPosAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelCardTextureYPosAttr__SWIG_2")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelCardTextureYPosAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_GetModelCardTextureZPosAttr")]
		public static extern IntPtr UsdGeomModelAPI_GetModelCardTextureZPosAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelCardTextureZPosAttr__SWIG_0")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelCardTextureZPosAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelCardTextureZPosAttr__SWIG_1")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelCardTextureZPosAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelCardTextureZPosAttr__SWIG_2")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelCardTextureZPosAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_GetModelCardTextureXNegAttr")]
		public static extern IntPtr UsdGeomModelAPI_GetModelCardTextureXNegAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelCardTextureXNegAttr__SWIG_0")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelCardTextureXNegAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelCardTextureXNegAttr__SWIG_1")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelCardTextureXNegAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelCardTextureXNegAttr__SWIG_2")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelCardTextureXNegAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_GetModelCardTextureYNegAttr")]
		public static extern IntPtr UsdGeomModelAPI_GetModelCardTextureYNegAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelCardTextureYNegAttr__SWIG_0")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelCardTextureYNegAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelCardTextureYNegAttr__SWIG_1")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelCardTextureYNegAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelCardTextureYNegAttr__SWIG_2")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelCardTextureYNegAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_GetModelCardTextureZNegAttr")]
		public static extern IntPtr UsdGeomModelAPI_GetModelCardTextureZNegAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelCardTextureZNegAttr__SWIG_0")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelCardTextureZNegAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelCardTextureZNegAttr__SWIG_1")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelCardTextureZNegAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateModelCardTextureZNegAttr__SWIG_2")]
		public static extern IntPtr UsdGeomModelAPI_CreateModelCardTextureZNegAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_GetExtentsHint__SWIG_0")]
		public static extern bool UsdGeomModelAPI_GetExtentsHint__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_GetExtentsHint__SWIG_1")]
		public static extern bool UsdGeomModelAPI_GetExtentsHint__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_SetExtentsHint__SWIG_0")]
		public static extern bool UsdGeomModelAPI_SetExtentsHint__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_SetExtentsHint__SWIG_1")]
		public static extern bool UsdGeomModelAPI_SetExtentsHint__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_GetExtentsHintAttr")]
		public static extern IntPtr UsdGeomModelAPI_GetExtentsHintAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_ComputeExtentsHint")]
		public static extern IntPtr UsdGeomModelAPI_ComputeExtentsHint(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_GetConstraintTarget")]
		public static extern IntPtr UsdGeomModelAPI_GetConstraintTarget(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_CreateConstraintTarget")]
		public static extern IntPtr UsdGeomModelAPI_CreateConstraintTarget(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_GetConstraintTargets")]
		public static extern IntPtr UsdGeomModelAPI_GetConstraintTargets(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_ComputeModelDrawMode__SWIG_0")]
		public static extern IntPtr UsdGeomModelAPI_ComputeModelDrawMode__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_ComputeModelDrawMode__SWIG_1")]
		public static extern IntPtr UsdGeomModelAPI_ComputeModelDrawMode__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTargetVector_Clear")]
		public static extern void UsdGeomConstraintTargetVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTargetVector_Add")]
		public static extern void UsdGeomConstraintTargetVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTargetVector_size")]
		public static extern uint UsdGeomConstraintTargetVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTargetVector_capacity")]
		public static extern uint UsdGeomConstraintTargetVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTargetVector_reserve")]
		public static extern void UsdGeomConstraintTargetVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomConstraintTargetVector__SWIG_0")]
		public static extern IntPtr new_UsdGeomConstraintTargetVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomConstraintTargetVector__SWIG_1")]
		public static extern IntPtr new_UsdGeomConstraintTargetVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomConstraintTargetVector__SWIG_2")]
		public static extern IntPtr new_UsdGeomConstraintTargetVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTargetVector_getitemcopy")]
		public static extern IntPtr UsdGeomConstraintTargetVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTargetVector_getitem")]
		public static extern IntPtr UsdGeomConstraintTargetVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTargetVector_setitem")]
		public static extern void UsdGeomConstraintTargetVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTargetVector_AddRange")]
		public static extern void UsdGeomConstraintTargetVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTargetVector_GetRange")]
		public static extern IntPtr UsdGeomConstraintTargetVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTargetVector_Insert")]
		public static extern void UsdGeomConstraintTargetVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTargetVector_InsertRange")]
		public static extern void UsdGeomConstraintTargetVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTargetVector_RemoveAt")]
		public static extern void UsdGeomConstraintTargetVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTargetVector_RemoveRange")]
		public static extern void UsdGeomConstraintTargetVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTargetVector_Repeat")]
		public static extern IntPtr UsdGeomConstraintTargetVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTargetVector_Reverse__SWIG_0")]
		public static extern void UsdGeomConstraintTargetVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTargetVector_Reverse__SWIG_1")]
		public static extern void UsdGeomConstraintTargetVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomConstraintTargetVector_SetRange")]
		public static extern void UsdGeomConstraintTargetVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomConstraintTargetVector")]
		public static extern void delete_UsdGeomConstraintTargetVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomMotionAPI__SWIG_0")]
		public static extern IntPtr new_UsdGeomMotionAPI__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomMotionAPI__SWIG_1")]
		public static extern IntPtr new_UsdGeomMotionAPI__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomMotionAPI__SWIG_2")]
		public static extern IntPtr new_UsdGeomMotionAPI__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomMotionAPI")]
		public static extern void delete_UsdGeomMotionAPI(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMotionAPI_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomMotionAPI_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMotionAPI_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomMotionAPI_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMotionAPI_Get")]
		public static extern IntPtr UsdGeomMotionAPI_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMotionAPI_CanApply__SWIG_0")]
		public static extern bool UsdGeomMotionAPI_CanApply__SWIG_0(HandleRef jarg1, out string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMotionAPI_CanApply__SWIG_1")]
		public static extern bool UsdGeomMotionAPI_CanApply__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMotionAPI_Apply")]
		public static extern IntPtr UsdGeomMotionAPI_Apply(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMotionAPI_GetMotionBlurScaleAttr")]
		public static extern IntPtr UsdGeomMotionAPI_GetMotionBlurScaleAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMotionAPI_CreateMotionBlurScaleAttr__SWIG_0")]
		public static extern IntPtr UsdGeomMotionAPI_CreateMotionBlurScaleAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMotionAPI_CreateMotionBlurScaleAttr__SWIG_1")]
		public static extern IntPtr UsdGeomMotionAPI_CreateMotionBlurScaleAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMotionAPI_CreateMotionBlurScaleAttr__SWIG_2")]
		public static extern IntPtr UsdGeomMotionAPI_CreateMotionBlurScaleAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMotionAPI_GetVelocityScaleAttr")]
		public static extern IntPtr UsdGeomMotionAPI_GetVelocityScaleAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMotionAPI_CreateVelocityScaleAttr__SWIG_0")]
		public static extern IntPtr UsdGeomMotionAPI_CreateVelocityScaleAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMotionAPI_CreateVelocityScaleAttr__SWIG_1")]
		public static extern IntPtr UsdGeomMotionAPI_CreateVelocityScaleAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMotionAPI_CreateVelocityScaleAttr__SWIG_2")]
		public static extern IntPtr UsdGeomMotionAPI_CreateVelocityScaleAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMotionAPI_GetNonlinearSampleCountAttr")]
		public static extern IntPtr UsdGeomMotionAPI_GetNonlinearSampleCountAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMotionAPI_CreateNonlinearSampleCountAttr__SWIG_0")]
		public static extern IntPtr UsdGeomMotionAPI_CreateNonlinearSampleCountAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMotionAPI_CreateNonlinearSampleCountAttr__SWIG_1")]
		public static extern IntPtr UsdGeomMotionAPI_CreateNonlinearSampleCountAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMotionAPI_CreateNonlinearSampleCountAttr__SWIG_2")]
		public static extern IntPtr UsdGeomMotionAPI_CreateNonlinearSampleCountAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMotionAPI_ComputeVelocityScale__SWIG_0")]
		public static extern float UsdGeomMotionAPI_ComputeVelocityScale__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMotionAPI_ComputeVelocityScale__SWIG_1")]
		public static extern float UsdGeomMotionAPI_ComputeVelocityScale__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMotionAPI_ComputeNonlinearSampleCount__SWIG_0")]
		public static extern int UsdGeomMotionAPI_ComputeNonlinearSampleCount__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMotionAPI_ComputeNonlinearSampleCount__SWIG_1")]
		public static extern int UsdGeomMotionAPI_ComputeNonlinearSampleCount__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMotionAPI_ComputeMotionBlurScale__SWIG_0")]
		public static extern float UsdGeomMotionAPI_ComputeMotionBlurScale__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMotionAPI_ComputeMotionBlurScale__SWIG_1")]
		public static extern float UsdGeomMotionAPI_ComputeMotionBlurScale__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomNurbsCurves__SWIG_0")]
		public static extern IntPtr new_UsdGeomNurbsCurves__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomNurbsCurves__SWIG_1")]
		public static extern IntPtr new_UsdGeomNurbsCurves__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomNurbsCurves__SWIG_2")]
		public static extern IntPtr new_UsdGeomNurbsCurves__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomNurbsCurves")]
		public static extern void delete_UsdGeomNurbsCurves(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsCurves_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomNurbsCurves_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsCurves_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomNurbsCurves_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsCurves_Get")]
		public static extern IntPtr UsdGeomNurbsCurves_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsCurves_Define")]
		public static extern IntPtr UsdGeomNurbsCurves_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsCurves_GetOrderAttr")]
		public static extern IntPtr UsdGeomNurbsCurves_GetOrderAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsCurves_CreateOrderAttr__SWIG_0")]
		public static extern IntPtr UsdGeomNurbsCurves_CreateOrderAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsCurves_CreateOrderAttr__SWIG_1")]
		public static extern IntPtr UsdGeomNurbsCurves_CreateOrderAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsCurves_CreateOrderAttr__SWIG_2")]
		public static extern IntPtr UsdGeomNurbsCurves_CreateOrderAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsCurves_GetKnotsAttr")]
		public static extern IntPtr UsdGeomNurbsCurves_GetKnotsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsCurves_CreateKnotsAttr__SWIG_0")]
		public static extern IntPtr UsdGeomNurbsCurves_CreateKnotsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsCurves_CreateKnotsAttr__SWIG_1")]
		public static extern IntPtr UsdGeomNurbsCurves_CreateKnotsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsCurves_CreateKnotsAttr__SWIG_2")]
		public static extern IntPtr UsdGeomNurbsCurves_CreateKnotsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsCurves_GetRangesAttr")]
		public static extern IntPtr UsdGeomNurbsCurves_GetRangesAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsCurves_CreateRangesAttr__SWIG_0")]
		public static extern IntPtr UsdGeomNurbsCurves_CreateRangesAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsCurves_CreateRangesAttr__SWIG_1")]
		public static extern IntPtr UsdGeomNurbsCurves_CreateRangesAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsCurves_CreateRangesAttr__SWIG_2")]
		public static extern IntPtr UsdGeomNurbsCurves_CreateRangesAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomNurbsPatch__SWIG_0")]
		public static extern IntPtr new_UsdGeomNurbsPatch__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomNurbsPatch__SWIG_1")]
		public static extern IntPtr new_UsdGeomNurbsPatch__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomNurbsPatch__SWIG_2")]
		public static extern IntPtr new_UsdGeomNurbsPatch__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomNurbsPatch")]
		public static extern void delete_UsdGeomNurbsPatch(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomNurbsPatch_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomNurbsPatch_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_Get")]
		public static extern IntPtr UsdGeomNurbsPatch_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_Define")]
		public static extern IntPtr UsdGeomNurbsPatch_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_GetUVertexCountAttr")]
		public static extern IntPtr UsdGeomNurbsPatch_GetUVertexCountAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateUVertexCountAttr__SWIG_0")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateUVertexCountAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateUVertexCountAttr__SWIG_1")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateUVertexCountAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateUVertexCountAttr__SWIG_2")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateUVertexCountAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_GetVVertexCountAttr")]
		public static extern IntPtr UsdGeomNurbsPatch_GetVVertexCountAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateVVertexCountAttr__SWIG_0")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateVVertexCountAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateVVertexCountAttr__SWIG_1")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateVVertexCountAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateVVertexCountAttr__SWIG_2")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateVVertexCountAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_GetUOrderAttr")]
		public static extern IntPtr UsdGeomNurbsPatch_GetUOrderAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateUOrderAttr__SWIG_0")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateUOrderAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateUOrderAttr__SWIG_1")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateUOrderAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateUOrderAttr__SWIG_2")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateUOrderAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_GetVOrderAttr")]
		public static extern IntPtr UsdGeomNurbsPatch_GetVOrderAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateVOrderAttr__SWIG_0")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateVOrderAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateVOrderAttr__SWIG_1")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateVOrderAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateVOrderAttr__SWIG_2")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateVOrderAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_GetUKnotsAttr")]
		public static extern IntPtr UsdGeomNurbsPatch_GetUKnotsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateUKnotsAttr__SWIG_0")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateUKnotsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateUKnotsAttr__SWIG_1")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateUKnotsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateUKnotsAttr__SWIG_2")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateUKnotsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_GetVKnotsAttr")]
		public static extern IntPtr UsdGeomNurbsPatch_GetVKnotsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateVKnotsAttr__SWIG_0")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateVKnotsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateVKnotsAttr__SWIG_1")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateVKnotsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateVKnotsAttr__SWIG_2")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateVKnotsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_GetUFormAttr")]
		public static extern IntPtr UsdGeomNurbsPatch_GetUFormAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateUFormAttr__SWIG_0")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateUFormAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateUFormAttr__SWIG_1")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateUFormAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateUFormAttr__SWIG_2")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateUFormAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_GetVFormAttr")]
		public static extern IntPtr UsdGeomNurbsPatch_GetVFormAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateVFormAttr__SWIG_0")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateVFormAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateVFormAttr__SWIG_1")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateVFormAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateVFormAttr__SWIG_2")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateVFormAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_GetURangeAttr")]
		public static extern IntPtr UsdGeomNurbsPatch_GetURangeAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateURangeAttr__SWIG_0")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateURangeAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateURangeAttr__SWIG_1")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateURangeAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateURangeAttr__SWIG_2")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateURangeAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_GetVRangeAttr")]
		public static extern IntPtr UsdGeomNurbsPatch_GetVRangeAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateVRangeAttr__SWIG_0")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateVRangeAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateVRangeAttr__SWIG_1")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateVRangeAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateVRangeAttr__SWIG_2")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateVRangeAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_GetPointWeightsAttr")]
		public static extern IntPtr UsdGeomNurbsPatch_GetPointWeightsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreatePointWeightsAttr__SWIG_0")]
		public static extern IntPtr UsdGeomNurbsPatch_CreatePointWeightsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreatePointWeightsAttr__SWIG_1")]
		public static extern IntPtr UsdGeomNurbsPatch_CreatePointWeightsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreatePointWeightsAttr__SWIG_2")]
		public static extern IntPtr UsdGeomNurbsPatch_CreatePointWeightsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_GetTrimCurveCountsAttr")]
		public static extern IntPtr UsdGeomNurbsPatch_GetTrimCurveCountsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateTrimCurveCountsAttr__SWIG_0")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateTrimCurveCountsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateTrimCurveCountsAttr__SWIG_1")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateTrimCurveCountsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateTrimCurveCountsAttr__SWIG_2")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateTrimCurveCountsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_GetTrimCurveOrdersAttr")]
		public static extern IntPtr UsdGeomNurbsPatch_GetTrimCurveOrdersAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateTrimCurveOrdersAttr__SWIG_0")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateTrimCurveOrdersAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateTrimCurveOrdersAttr__SWIG_1")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateTrimCurveOrdersAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateTrimCurveOrdersAttr__SWIG_2")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateTrimCurveOrdersAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_GetTrimCurveVertexCountsAttr")]
		public static extern IntPtr UsdGeomNurbsPatch_GetTrimCurveVertexCountsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateTrimCurveVertexCountsAttr__SWIG_0")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateTrimCurveVertexCountsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateTrimCurveVertexCountsAttr__SWIG_1")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateTrimCurveVertexCountsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateTrimCurveVertexCountsAttr__SWIG_2")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateTrimCurveVertexCountsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_GetTrimCurveKnotsAttr")]
		public static extern IntPtr UsdGeomNurbsPatch_GetTrimCurveKnotsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateTrimCurveKnotsAttr__SWIG_0")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateTrimCurveKnotsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateTrimCurveKnotsAttr__SWIG_1")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateTrimCurveKnotsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateTrimCurveKnotsAttr__SWIG_2")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateTrimCurveKnotsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_GetTrimCurveRangesAttr")]
		public static extern IntPtr UsdGeomNurbsPatch_GetTrimCurveRangesAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateTrimCurveRangesAttr__SWIG_0")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateTrimCurveRangesAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateTrimCurveRangesAttr__SWIG_1")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateTrimCurveRangesAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateTrimCurveRangesAttr__SWIG_2")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateTrimCurveRangesAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_GetTrimCurvePointsAttr")]
		public static extern IntPtr UsdGeomNurbsPatch_GetTrimCurvePointsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateTrimCurvePointsAttr__SWIG_0")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateTrimCurvePointsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateTrimCurvePointsAttr__SWIG_1")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateTrimCurvePointsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_CreateTrimCurvePointsAttr__SWIG_2")]
		public static extern IntPtr UsdGeomNurbsPatch_CreateTrimCurvePointsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomPlane__SWIG_0")]
		public static extern IntPtr new_UsdGeomPlane__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomPlane__SWIG_1")]
		public static extern IntPtr new_UsdGeomPlane__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomPlane__SWIG_2")]
		public static extern IntPtr new_UsdGeomPlane__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomPlane")]
		public static extern void delete_UsdGeomPlane(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomPlane_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomPlane_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_Get")]
		public static extern IntPtr UsdGeomPlane_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_Define")]
		public static extern IntPtr UsdGeomPlane_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_GetDoubleSidedAttr")]
		public static extern IntPtr UsdGeomPlane_GetDoubleSidedAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_CreateDoubleSidedAttr__SWIG_0")]
		public static extern IntPtr UsdGeomPlane_CreateDoubleSidedAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_CreateDoubleSidedAttr__SWIG_1")]
		public static extern IntPtr UsdGeomPlane_CreateDoubleSidedAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_CreateDoubleSidedAttr__SWIG_2")]
		public static extern IntPtr UsdGeomPlane_CreateDoubleSidedAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_GetWidthAttr")]
		public static extern IntPtr UsdGeomPlane_GetWidthAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_CreateWidthAttr__SWIG_0")]
		public static extern IntPtr UsdGeomPlane_CreateWidthAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_CreateWidthAttr__SWIG_1")]
		public static extern IntPtr UsdGeomPlane_CreateWidthAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_CreateWidthAttr__SWIG_2")]
		public static extern IntPtr UsdGeomPlane_CreateWidthAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_GetLengthAttr")]
		public static extern IntPtr UsdGeomPlane_GetLengthAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_CreateLengthAttr__SWIG_0")]
		public static extern IntPtr UsdGeomPlane_CreateLengthAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_CreateLengthAttr__SWIG_1")]
		public static extern IntPtr UsdGeomPlane_CreateLengthAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_CreateLengthAttr__SWIG_2")]
		public static extern IntPtr UsdGeomPlane_CreateLengthAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_GetAxisAttr")]
		public static extern IntPtr UsdGeomPlane_GetAxisAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_CreateAxisAttr__SWIG_0")]
		public static extern IntPtr UsdGeomPlane_CreateAxisAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_CreateAxisAttr__SWIG_1")]
		public static extern IntPtr UsdGeomPlane_CreateAxisAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_CreateAxisAttr__SWIG_2")]
		public static extern IntPtr UsdGeomPlane_CreateAxisAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_GetExtentAttr")]
		public static extern IntPtr UsdGeomPlane_GetExtentAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_CreateExtentAttr__SWIG_0")]
		public static extern IntPtr UsdGeomPlane_CreateExtentAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_CreateExtentAttr__SWIG_1")]
		public static extern IntPtr UsdGeomPlane_CreateExtentAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_CreateExtentAttr__SWIG_2")]
		public static extern IntPtr UsdGeomPlane_CreateExtentAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_ComputeExtent__SWIG_0")]
		public static extern bool UsdGeomPlane_ComputeExtent__SWIG_0(double jarg1, double jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_ComputeExtent__SWIG_1")]
		public static extern bool UsdGeomPlane_ComputeExtent__SWIG_1(double jarg1, double jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtMatrix4dArrayVector_Clear")]
		public static extern void VtMatrix4dArrayVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtMatrix4dArrayVector_Add")]
		public static extern void VtMatrix4dArrayVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtMatrix4dArrayVector_size")]
		public static extern uint VtMatrix4dArrayVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtMatrix4dArrayVector_capacity")]
		public static extern uint VtMatrix4dArrayVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtMatrix4dArrayVector_reserve")]
		public static extern void VtMatrix4dArrayVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_VtMatrix4dArrayVector__SWIG_0")]
		public static extern IntPtr new_VtMatrix4dArrayVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_VtMatrix4dArrayVector__SWIG_1")]
		public static extern IntPtr new_VtMatrix4dArrayVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_VtMatrix4dArrayVector__SWIG_2")]
		public static extern IntPtr new_VtMatrix4dArrayVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtMatrix4dArrayVector_getitemcopy")]
		public static extern IntPtr VtMatrix4dArrayVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtMatrix4dArrayVector_getitem")]
		public static extern IntPtr VtMatrix4dArrayVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtMatrix4dArrayVector_setitem")]
		public static extern void VtMatrix4dArrayVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtMatrix4dArrayVector_AddRange")]
		public static extern void VtMatrix4dArrayVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtMatrix4dArrayVector_GetRange")]
		public static extern IntPtr VtMatrix4dArrayVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtMatrix4dArrayVector_Insert")]
		public static extern void VtMatrix4dArrayVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtMatrix4dArrayVector_InsertRange")]
		public static extern void VtMatrix4dArrayVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtMatrix4dArrayVector_RemoveAt")]
		public static extern void VtMatrix4dArrayVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtMatrix4dArrayVector_RemoveRange")]
		public static extern void VtMatrix4dArrayVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtMatrix4dArrayVector_Repeat")]
		public static extern IntPtr VtMatrix4dArrayVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtMatrix4dArrayVector_Reverse__SWIG_0")]
		public static extern void VtMatrix4dArrayVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtMatrix4dArrayVector_Reverse__SWIG_1")]
		public static extern void VtMatrix4dArrayVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtMatrix4dArrayVector_SetRange")]
		public static extern void VtMatrix4dArrayVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_VtMatrix4dArrayVector")]
		public static extern void delete_VtMatrix4dArrayVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtVec3fArrayVector_Clear")]
		public static extern void VtVec3fArrayVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtVec3fArrayVector_Add")]
		public static extern void VtVec3fArrayVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtVec3fArrayVector_size")]
		public static extern uint VtVec3fArrayVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtVec3fArrayVector_capacity")]
		public static extern uint VtVec3fArrayVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtVec3fArrayVector_reserve")]
		public static extern void VtVec3fArrayVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_VtVec3fArrayVector__SWIG_0")]
		public static extern IntPtr new_VtVec3fArrayVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_VtVec3fArrayVector__SWIG_1")]
		public static extern IntPtr new_VtVec3fArrayVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_VtVec3fArrayVector__SWIG_2")]
		public static extern IntPtr new_VtVec3fArrayVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtVec3fArrayVector_getitemcopy")]
		public static extern IntPtr VtVec3fArrayVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtVec3fArrayVector_getitem")]
		public static extern IntPtr VtVec3fArrayVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtVec3fArrayVector_setitem")]
		public static extern void VtVec3fArrayVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtVec3fArrayVector_AddRange")]
		public static extern void VtVec3fArrayVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtVec3fArrayVector_GetRange")]
		public static extern IntPtr VtVec3fArrayVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtVec3fArrayVector_Insert")]
		public static extern void VtVec3fArrayVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtVec3fArrayVector_InsertRange")]
		public static extern void VtVec3fArrayVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtVec3fArrayVector_RemoveAt")]
		public static extern void VtVec3fArrayVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtVec3fArrayVector_RemoveRange")]
		public static extern void VtVec3fArrayVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtVec3fArrayVector_Repeat")]
		public static extern IntPtr VtVec3fArrayVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtVec3fArrayVector_Reverse__SWIG_0")]
		public static extern void VtVec3fArrayVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtVec3fArrayVector_Reverse__SWIG_1")]
		public static extern void VtVec3fArrayVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_VtVec3fArrayVector_SetRange")]
		public static extern void VtVec3fArrayVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_VtVec3fArrayVector")]
		public static extern void delete_VtVec3fArrayVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomPointInstancer__SWIG_0")]
		public static extern IntPtr new_UsdGeomPointInstancer__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomPointInstancer__SWIG_1")]
		public static extern IntPtr new_UsdGeomPointInstancer__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomPointInstancer__SWIG_2")]
		public static extern IntPtr new_UsdGeomPointInstancer__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomPointInstancer")]
		public static extern void delete_UsdGeomPointInstancer(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomPointInstancer_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomPointInstancer_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_Get")]
		public static extern IntPtr UsdGeomPointInstancer_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_Define")]
		public static extern IntPtr UsdGeomPointInstancer_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_GetProtoIndicesAttr")]
		public static extern IntPtr UsdGeomPointInstancer_GetProtoIndicesAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreateProtoIndicesAttr__SWIG_0")]
		public static extern IntPtr UsdGeomPointInstancer_CreateProtoIndicesAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreateProtoIndicesAttr__SWIG_1")]
		public static extern IntPtr UsdGeomPointInstancer_CreateProtoIndicesAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreateProtoIndicesAttr__SWIG_2")]
		public static extern IntPtr UsdGeomPointInstancer_CreateProtoIndicesAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_GetIdsAttr")]
		public static extern IntPtr UsdGeomPointInstancer_GetIdsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreateIdsAttr__SWIG_0")]
		public static extern IntPtr UsdGeomPointInstancer_CreateIdsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreateIdsAttr__SWIG_1")]
		public static extern IntPtr UsdGeomPointInstancer_CreateIdsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreateIdsAttr__SWIG_2")]
		public static extern IntPtr UsdGeomPointInstancer_CreateIdsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_GetPositionsAttr")]
		public static extern IntPtr UsdGeomPointInstancer_GetPositionsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreatePositionsAttr__SWIG_0")]
		public static extern IntPtr UsdGeomPointInstancer_CreatePositionsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreatePositionsAttr__SWIG_1")]
		public static extern IntPtr UsdGeomPointInstancer_CreatePositionsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreatePositionsAttr__SWIG_2")]
		public static extern IntPtr UsdGeomPointInstancer_CreatePositionsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_GetOrientationsAttr")]
		public static extern IntPtr UsdGeomPointInstancer_GetOrientationsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreateOrientationsAttr__SWIG_0")]
		public static extern IntPtr UsdGeomPointInstancer_CreateOrientationsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreateOrientationsAttr__SWIG_1")]
		public static extern IntPtr UsdGeomPointInstancer_CreateOrientationsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreateOrientationsAttr__SWIG_2")]
		public static extern IntPtr UsdGeomPointInstancer_CreateOrientationsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_GetScalesAttr")]
		public static extern IntPtr UsdGeomPointInstancer_GetScalesAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreateScalesAttr__SWIG_0")]
		public static extern IntPtr UsdGeomPointInstancer_CreateScalesAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreateScalesAttr__SWIG_1")]
		public static extern IntPtr UsdGeomPointInstancer_CreateScalesAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreateScalesAttr__SWIG_2")]
		public static extern IntPtr UsdGeomPointInstancer_CreateScalesAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_GetVelocitiesAttr")]
		public static extern IntPtr UsdGeomPointInstancer_GetVelocitiesAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreateVelocitiesAttr__SWIG_0")]
		public static extern IntPtr UsdGeomPointInstancer_CreateVelocitiesAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreateVelocitiesAttr__SWIG_1")]
		public static extern IntPtr UsdGeomPointInstancer_CreateVelocitiesAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreateVelocitiesAttr__SWIG_2")]
		public static extern IntPtr UsdGeomPointInstancer_CreateVelocitiesAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_GetAccelerationsAttr")]
		public static extern IntPtr UsdGeomPointInstancer_GetAccelerationsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreateAccelerationsAttr__SWIG_0")]
		public static extern IntPtr UsdGeomPointInstancer_CreateAccelerationsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreateAccelerationsAttr__SWIG_1")]
		public static extern IntPtr UsdGeomPointInstancer_CreateAccelerationsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreateAccelerationsAttr__SWIG_2")]
		public static extern IntPtr UsdGeomPointInstancer_CreateAccelerationsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_GetAngularVelocitiesAttr")]
		public static extern IntPtr UsdGeomPointInstancer_GetAngularVelocitiesAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreateAngularVelocitiesAttr__SWIG_0")]
		public static extern IntPtr UsdGeomPointInstancer_CreateAngularVelocitiesAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreateAngularVelocitiesAttr__SWIG_1")]
		public static extern IntPtr UsdGeomPointInstancer_CreateAngularVelocitiesAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreateAngularVelocitiesAttr__SWIG_2")]
		public static extern IntPtr UsdGeomPointInstancer_CreateAngularVelocitiesAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_GetInvisibleIdsAttr")]
		public static extern IntPtr UsdGeomPointInstancer_GetInvisibleIdsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreateInvisibleIdsAttr__SWIG_0")]
		public static extern IntPtr UsdGeomPointInstancer_CreateInvisibleIdsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreateInvisibleIdsAttr__SWIG_1")]
		public static extern IntPtr UsdGeomPointInstancer_CreateInvisibleIdsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreateInvisibleIdsAttr__SWIG_2")]
		public static extern IntPtr UsdGeomPointInstancer_CreateInvisibleIdsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_GetPrototypesRel")]
		public static extern IntPtr UsdGeomPointInstancer_GetPrototypesRel(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_CreatePrototypesRel")]
		public static extern IntPtr UsdGeomPointInstancer_CreatePrototypesRel(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_ActivateId")]
		public static extern bool UsdGeomPointInstancer_ActivateId(HandleRef jarg1, long jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_ActivateIds")]
		public static extern bool UsdGeomPointInstancer_ActivateIds(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_ActivateAllIds")]
		public static extern bool UsdGeomPointInstancer_ActivateAllIds(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_DeactivateId")]
		public static extern bool UsdGeomPointInstancer_DeactivateId(HandleRef jarg1, long jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_DeactivateIds")]
		public static extern bool UsdGeomPointInstancer_DeactivateIds(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_VisId")]
		public static extern bool UsdGeomPointInstancer_VisId(HandleRef jarg1, long jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_VisIds")]
		public static extern bool UsdGeomPointInstancer_VisIds(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_VisAllIds")]
		public static extern bool UsdGeomPointInstancer_VisAllIds(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_InvisId")]
		public static extern bool UsdGeomPointInstancer_InvisId(HandleRef jarg1, long jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_InvisIds")]
		public static extern bool UsdGeomPointInstancer_InvisIds(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_ComputeMaskAtTime__SWIG_0")]
		public static extern IntPtr UsdGeomPointInstancer_ComputeMaskAtTime__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_ComputeMaskAtTime__SWIG_1")]
		public static extern IntPtr UsdGeomPointInstancer_ComputeMaskAtTime__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_ComputeInstanceTransformsAtTime__SWIG_0")]
		public static extern bool UsdGeomPointInstancer_ComputeInstanceTransformsAtTime__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5, int jarg6);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_ComputeInstanceTransformsAtTime__SWIG_1")]
		public static extern bool UsdGeomPointInstancer_ComputeInstanceTransformsAtTime__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_ComputeInstanceTransformsAtTime__SWIG_2")]
		public static extern bool UsdGeomPointInstancer_ComputeInstanceTransformsAtTime__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_ComputeInstanceTransformsAtTimes__SWIG_0")]
		public static extern bool UsdGeomPointInstancer_ComputeInstanceTransformsAtTimes__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5, int jarg6);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_ComputeInstanceTransformsAtTimes__SWIG_1")]
		public static extern bool UsdGeomPointInstancer_ComputeInstanceTransformsAtTimes__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_ComputeInstanceTransformsAtTimes__SWIG_2")]
		public static extern bool UsdGeomPointInstancer_ComputeInstanceTransformsAtTimes__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_ComputeInstanceTransformsAtTime__SWIG_3")]
		public static extern bool UsdGeomPointInstancer_ComputeInstanceTransformsAtTime__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, HandleRef jarg6, HandleRef jarg7, HandleRef jarg8, HandleRef jarg9, HandleRef jarg10, HandleRef jarg11, HandleRef jarg12, HandleRef jarg13, HandleRef jarg14, float jarg15);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_ComputeInstanceTransformsAtTime__SWIG_4")]
		public static extern bool UsdGeomPointInstancer_ComputeInstanceTransformsAtTime__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, HandleRef jarg6, HandleRef jarg7, HandleRef jarg8, HandleRef jarg9, HandleRef jarg10, HandleRef jarg11, HandleRef jarg12, HandleRef jarg13, HandleRef jarg14);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_ComputeExtentAtTime__SWIG_0")]
		public static extern bool UsdGeomPointInstancer_ComputeExtentAtTime__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_ComputeExtentAtTime__SWIG_1")]
		public static extern bool UsdGeomPointInstancer_ComputeExtentAtTime__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_ComputeExtentAtTimes__SWIG_0")]
		public static extern bool UsdGeomPointInstancer_ComputeExtentAtTimes__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_ComputeExtentAtTimes__SWIG_1")]
		public static extern bool UsdGeomPointInstancer_ComputeExtentAtTimes__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_GetInstanceCount__SWIG_0")]
		public static extern uint UsdGeomPointInstancer_GetInstanceCount__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_GetInstanceCount__SWIG_1")]
		public static extern uint UsdGeomPointInstancer_GetInstanceCount__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancerApplyNewStyleListOps")]
		public static extern bool UsdGeomPointInstancerApplyNewStyleListOps();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancerSetOrMergeOverOp")]
		public static extern bool UsdGeomPointInstancerSetOrMergeOverOp(HandleRef jarg1, int jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomPoints__SWIG_0")]
		public static extern IntPtr new_UsdGeomPoints__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomPoints__SWIG_1")]
		public static extern IntPtr new_UsdGeomPoints__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomPoints__SWIG_2")]
		public static extern IntPtr new_UsdGeomPoints__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomPoints")]
		public static extern void delete_UsdGeomPoints(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPoints_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomPoints_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPoints_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomPoints_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPoints_Get")]
		public static extern IntPtr UsdGeomPoints_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPoints_Define")]
		public static extern IntPtr UsdGeomPoints_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPoints_GetWidthsAttr")]
		public static extern IntPtr UsdGeomPoints_GetWidthsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPoints_CreateWidthsAttr__SWIG_0")]
		public static extern IntPtr UsdGeomPoints_CreateWidthsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPoints_CreateWidthsAttr__SWIG_1")]
		public static extern IntPtr UsdGeomPoints_CreateWidthsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPoints_CreateWidthsAttr__SWIG_2")]
		public static extern IntPtr UsdGeomPoints_CreateWidthsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPoints_GetIdsAttr")]
		public static extern IntPtr UsdGeomPoints_GetIdsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPoints_CreateIdsAttr__SWIG_0")]
		public static extern IntPtr UsdGeomPoints_CreateIdsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPoints_CreateIdsAttr__SWIG_1")]
		public static extern IntPtr UsdGeomPoints_CreateIdsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPoints_CreateIdsAttr__SWIG_2")]
		public static extern IntPtr UsdGeomPoints_CreateIdsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPoints_GetWidthsInterpolation")]
		public static extern IntPtr UsdGeomPoints_GetWidthsInterpolation(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPoints_SetWidthsInterpolation")]
		public static extern bool UsdGeomPoints_SetWidthsInterpolation(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPoints_ComputeExtent__SWIG_0")]
		public static extern bool UsdGeomPoints_ComputeExtent__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPoints_ComputeExtent__SWIG_1")]
		public static extern bool UsdGeomPoints_ComputeExtent__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPoints_GetPointCount__SWIG_0")]
		public static extern uint UsdGeomPoints_GetPointCount__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPoints_GetPointCount__SWIG_1")]
		public static extern uint UsdGeomPoints_GetPointCount__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarVector_Clear")]
		public static extern void UsdGeomPrimvarVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarVector_Add")]
		public static extern void UsdGeomPrimvarVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarVector_size")]
		public static extern uint UsdGeomPrimvarVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarVector_capacity")]
		public static extern uint UsdGeomPrimvarVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarVector_reserve")]
		public static extern void UsdGeomPrimvarVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomPrimvarVector__SWIG_0")]
		public static extern IntPtr new_UsdGeomPrimvarVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomPrimvarVector__SWIG_1")]
		public static extern IntPtr new_UsdGeomPrimvarVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomPrimvarVector__SWIG_2")]
		public static extern IntPtr new_UsdGeomPrimvarVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarVector_getitemcopy")]
		public static extern IntPtr UsdGeomPrimvarVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarVector_getitem")]
		public static extern IntPtr UsdGeomPrimvarVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarVector_setitem")]
		public static extern void UsdGeomPrimvarVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarVector_AddRange")]
		public static extern void UsdGeomPrimvarVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarVector_GetRange")]
		public static extern IntPtr UsdGeomPrimvarVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarVector_Insert")]
		public static extern void UsdGeomPrimvarVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarVector_InsertRange")]
		public static extern void UsdGeomPrimvarVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarVector_RemoveAt")]
		public static extern void UsdGeomPrimvarVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarVector_RemoveRange")]
		public static extern void UsdGeomPrimvarVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarVector_Repeat")]
		public static extern IntPtr UsdGeomPrimvarVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarVector_Reverse__SWIG_0")]
		public static extern void UsdGeomPrimvarVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarVector_Reverse__SWIG_1")]
		public static extern void UsdGeomPrimvarVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarVector_SetRange")]
		public static extern void UsdGeomPrimvarVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomPrimvarVector")]
		public static extern void delete_UsdGeomPrimvarVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomPrimvar__SWIG_0")]
		public static extern IntPtr new_UsdGeomPrimvar__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomPrimvar__SWIG_1")]
		public static extern IntPtr new_UsdGeomPrimvar__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomPrimvar__SWIG_2")]
		public static extern IntPtr new_UsdGeomPrimvar__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_GetInterpolation")]
		public static extern IntPtr UsdGeomPrimvar_GetInterpolation(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_SetInterpolation")]
		public static extern bool UsdGeomPrimvar_SetInterpolation(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_HasAuthoredInterpolation")]
		public static extern bool UsdGeomPrimvar_HasAuthoredInterpolation(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_GetElementSize")]
		public static extern int UsdGeomPrimvar_GetElementSize(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_SetElementSize")]
		public static extern bool UsdGeomPrimvar_SetElementSize(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_HasAuthoredElementSize")]
		public static extern bool UsdGeomPrimvar_HasAuthoredElementSize(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_IsPrimvar")]
		public static extern bool UsdGeomPrimvar_IsPrimvar(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_IsValidPrimvarName")]
		public static extern bool UsdGeomPrimvar_IsValidPrimvarName(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_StripPrimvarsName")]
		public static extern IntPtr UsdGeomPrimvar_StripPrimvarsName(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_IsValidInterpolation")]
		public static extern bool UsdGeomPrimvar_IsValidInterpolation(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_GetDeclarationInfo")]
		public static extern void UsdGeomPrimvar_GetDeclarationInfo(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, out int jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_GetAttr")]
		public static extern IntPtr UsdGeomPrimvar_GetAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_IsDefined")]
		public static extern bool UsdGeomPrimvar_IsDefined(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_HasValue")]
		public static extern bool UsdGeomPrimvar_HasValue(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_HasAuthoredValue")]
		public static extern bool UsdGeomPrimvar_HasAuthoredValue(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_GetName")]
		public static extern IntPtr UsdGeomPrimvar_GetName(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_GetPrimvarName")]
		public static extern IntPtr UsdGeomPrimvar_GetPrimvarName(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_NameContainsNamespaces")]
		public static extern bool UsdGeomPrimvar_NameContainsNamespaces(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_GetBaseName")]
		public static extern IntPtr UsdGeomPrimvar_GetBaseName(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_GetNamespace")]
		public static extern IntPtr UsdGeomPrimvar_GetNamespace(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_SplitName")]
		public static extern IntPtr UsdGeomPrimvar_SplitName(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_GetTypeName")]
		public static extern IntPtr UsdGeomPrimvar_GetTypeName(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_GetTimeSamples")]
		public static extern bool UsdGeomPrimvar_GetTimeSamples(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_ValueMightBeTimeVarying")]
		public static extern bool UsdGeomPrimvar_ValueMightBeTimeVarying(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_SetIndices__SWIG_0")]
		public static extern bool UsdGeomPrimvar_SetIndices__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_SetIndices__SWIG_1")]
		public static extern bool UsdGeomPrimvar_SetIndices__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_GetIndices__SWIG_0")]
		public static extern bool UsdGeomPrimvar_GetIndices__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_GetIndices__SWIG_1")]
		public static extern bool UsdGeomPrimvar_GetIndices__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_BlockIndices")]
		public static extern void UsdGeomPrimvar_BlockIndices(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_IsIndexed")]
		public static extern bool UsdGeomPrimvar_IsIndexed(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_GetIndicesAttr")]
		public static extern IntPtr UsdGeomPrimvar_GetIndicesAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_CreateIndicesAttr")]
		public static extern IntPtr UsdGeomPrimvar_CreateIndicesAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_SetUnauthoredValuesIndex")]
		public static extern bool UsdGeomPrimvar_SetUnauthoredValuesIndex(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_GetUnauthoredValuesIndex")]
		public static extern int UsdGeomPrimvar_GetUnauthoredValuesIndex(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_ComputeFlattened__SWIG_2")]
		public static extern bool UsdGeomPrimvar_ComputeFlattened__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_ComputeFlattened__SWIG_3")]
		public static extern bool UsdGeomPrimvar_ComputeFlattened__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_ComputeFlattened__SWIG_4")]
		public static extern bool UsdGeomPrimvar_ComputeFlattened__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, out string jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_IsIdTarget")]
		public static extern bool UsdGeomPrimvar_IsIdTarget(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvar_SetIdTarget")]
		public static extern bool UsdGeomPrimvar_SetIdTarget(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomPrimvar")]
		public static extern void delete_UsdGeomPrimvar(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomPrimvarsAPI__SWIG_0")]
		public static extern IntPtr new_UsdGeomPrimvarsAPI__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomPrimvarsAPI__SWIG_1")]
		public static extern IntPtr new_UsdGeomPrimvarsAPI__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomPrimvarsAPI__SWIG_2")]
		public static extern IntPtr new_UsdGeomPrimvarsAPI__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomPrimvarsAPI")]
		public static extern void delete_UsdGeomPrimvarsAPI(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarsAPI_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomPrimvarsAPI_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarsAPI_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomPrimvarsAPI_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarsAPI_Get")]
		public static extern IntPtr UsdGeomPrimvarsAPI_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarsAPI_CreatePrimvar__SWIG_0")]
		public static extern IntPtr UsdGeomPrimvarsAPI_CreatePrimvar__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarsAPI_CreatePrimvar__SWIG_1")]
		public static extern IntPtr UsdGeomPrimvarsAPI_CreatePrimvar__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarsAPI_CreatePrimvar__SWIG_2")]
		public static extern IntPtr UsdGeomPrimvarsAPI_CreatePrimvar__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarsAPI_RemovePrimvar")]
		public static extern bool UsdGeomPrimvarsAPI_RemovePrimvar(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarsAPI_BlockPrimvar")]
		public static extern void UsdGeomPrimvarsAPI_BlockPrimvar(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarsAPI_GetPrimvar")]
		public static extern IntPtr UsdGeomPrimvarsAPI_GetPrimvar(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarsAPI_GetPrimvars")]
		public static extern IntPtr UsdGeomPrimvarsAPI_GetPrimvars(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarsAPI_GetAuthoredPrimvars")]
		public static extern IntPtr UsdGeomPrimvarsAPI_GetAuthoredPrimvars(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarsAPI_GetPrimvarsWithValues")]
		public static extern IntPtr UsdGeomPrimvarsAPI_GetPrimvarsWithValues(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarsAPI_GetPrimvarsWithAuthoredValues")]
		public static extern IntPtr UsdGeomPrimvarsAPI_GetPrimvarsWithAuthoredValues(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarsAPI_FindInheritablePrimvars")]
		public static extern IntPtr UsdGeomPrimvarsAPI_FindInheritablePrimvars(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarsAPI_FindIncrementallyInheritablePrimvars")]
		public static extern IntPtr UsdGeomPrimvarsAPI_FindIncrementallyInheritablePrimvars(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarsAPI_FindPrimvarWithInheritance__SWIG_0")]
		public static extern IntPtr UsdGeomPrimvarsAPI_FindPrimvarWithInheritance__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarsAPI_FindPrimvarWithInheritance__SWIG_1")]
		public static extern IntPtr UsdGeomPrimvarsAPI_FindPrimvarWithInheritance__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarsAPI_FindPrimvarsWithInheritance__SWIG_0")]
		public static extern IntPtr UsdGeomPrimvarsAPI_FindPrimvarsWithInheritance__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarsAPI_FindPrimvarsWithInheritance__SWIG_1")]
		public static extern IntPtr UsdGeomPrimvarsAPI_FindPrimvarsWithInheritance__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarsAPI_HasPrimvar")]
		public static extern bool UsdGeomPrimvarsAPI_HasPrimvar(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarsAPI_HasPossiblyInheritedPrimvar")]
		public static extern bool UsdGeomPrimvarsAPI_HasPossiblyInheritedPrimvar(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarsAPI_CanContainPropertyName")]
		public static extern bool UsdGeomPrimvarsAPI_CanContainPropertyName(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomScope__SWIG_0")]
		public static extern IntPtr new_UsdGeomScope__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomScope__SWIG_1")]
		public static extern IntPtr new_UsdGeomScope__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomScope__SWIG_2")]
		public static extern IntPtr new_UsdGeomScope__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomScope")]
		public static extern void delete_UsdGeomScope(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomScope_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomScope_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomScope_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomScope_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomScope_Get")]
		public static extern IntPtr UsdGeomScope_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomScope_Define")]
		public static extern IntPtr UsdGeomScope_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomSphere__SWIG_0")]
		public static extern IntPtr new_UsdGeomSphere__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomSphere__SWIG_1")]
		public static extern IntPtr new_UsdGeomSphere__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomSphere__SWIG_2")]
		public static extern IntPtr new_UsdGeomSphere__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomSphere")]
		public static extern void delete_UsdGeomSphere(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSphere_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomSphere_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSphere_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomSphere_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSphere_Get")]
		public static extern IntPtr UsdGeomSphere_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSphere_Define")]
		public static extern IntPtr UsdGeomSphere_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSphere_GetRadiusAttr")]
		public static extern IntPtr UsdGeomSphere_GetRadiusAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSphere_CreateRadiusAttr__SWIG_0")]
		public static extern IntPtr UsdGeomSphere_CreateRadiusAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSphere_CreateRadiusAttr__SWIG_1")]
		public static extern IntPtr UsdGeomSphere_CreateRadiusAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSphere_CreateRadiusAttr__SWIG_2")]
		public static extern IntPtr UsdGeomSphere_CreateRadiusAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSphere_GetExtentAttr")]
		public static extern IntPtr UsdGeomSphere_GetExtentAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSphere_CreateExtentAttr__SWIG_0")]
		public static extern IntPtr UsdGeomSphere_CreateExtentAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSphere_CreateExtentAttr__SWIG_1")]
		public static extern IntPtr UsdGeomSphere_CreateExtentAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSphere_CreateExtentAttr__SWIG_2")]
		public static extern IntPtr UsdGeomSphere_CreateExtentAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSphere_ComputeExtent__SWIG_0")]
		public static extern bool UsdGeomSphere_ComputeExtent__SWIG_0(double jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSphere_ComputeExtent__SWIG_1")]
		public static extern bool UsdGeomSphere_ComputeExtent__SWIG_1(double jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubsetVector_Clear")]
		public static extern void UsdGeomSubsetVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubsetVector_Add")]
		public static extern void UsdGeomSubsetVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubsetVector_size")]
		public static extern uint UsdGeomSubsetVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubsetVector_capacity")]
		public static extern uint UsdGeomSubsetVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubsetVector_reserve")]
		public static extern void UsdGeomSubsetVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomSubsetVector__SWIG_0")]
		public static extern IntPtr new_UsdGeomSubsetVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomSubsetVector__SWIG_1")]
		public static extern IntPtr new_UsdGeomSubsetVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomSubsetVector__SWIG_2")]
		public static extern IntPtr new_UsdGeomSubsetVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubsetVector_getitemcopy")]
		public static extern IntPtr UsdGeomSubsetVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubsetVector_getitem")]
		public static extern IntPtr UsdGeomSubsetVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubsetVector_setitem")]
		public static extern void UsdGeomSubsetVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubsetVector_AddRange")]
		public static extern void UsdGeomSubsetVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubsetVector_GetRange")]
		public static extern IntPtr UsdGeomSubsetVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubsetVector_Insert")]
		public static extern void UsdGeomSubsetVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubsetVector_InsertRange")]
		public static extern void UsdGeomSubsetVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubsetVector_RemoveAt")]
		public static extern void UsdGeomSubsetVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubsetVector_RemoveRange")]
		public static extern void UsdGeomSubsetVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubsetVector_Repeat")]
		public static extern IntPtr UsdGeomSubsetVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubsetVector_Reverse__SWIG_0")]
		public static extern void UsdGeomSubsetVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubsetVector_Reverse__SWIG_1")]
		public static extern void UsdGeomSubsetVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubsetVector_SetRange")]
		public static extern void UsdGeomSubsetVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomSubsetVector")]
		public static extern void delete_UsdGeomSubsetVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomSubset__SWIG_0")]
		public static extern IntPtr new_UsdGeomSubset__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomSubset__SWIG_1")]
		public static extern IntPtr new_UsdGeomSubset__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomSubset__SWIG_2")]
		public static extern IntPtr new_UsdGeomSubset__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomSubset")]
		public static extern void delete_UsdGeomSubset(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomSubset_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomSubset_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_Get")]
		public static extern IntPtr UsdGeomSubset_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_Define")]
		public static extern IntPtr UsdGeomSubset_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_GetElementTypeAttr")]
		public static extern IntPtr UsdGeomSubset_GetElementTypeAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_CreateElementTypeAttr__SWIG_0")]
		public static extern IntPtr UsdGeomSubset_CreateElementTypeAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_CreateElementTypeAttr__SWIG_1")]
		public static extern IntPtr UsdGeomSubset_CreateElementTypeAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_CreateElementTypeAttr__SWIG_2")]
		public static extern IntPtr UsdGeomSubset_CreateElementTypeAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_GetIndicesAttr")]
		public static extern IntPtr UsdGeomSubset_GetIndicesAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_CreateIndicesAttr__SWIG_0")]
		public static extern IntPtr UsdGeomSubset_CreateIndicesAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_CreateIndicesAttr__SWIG_1")]
		public static extern IntPtr UsdGeomSubset_CreateIndicesAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_CreateIndicesAttr__SWIG_2")]
		public static extern IntPtr UsdGeomSubset_CreateIndicesAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_GetFamilyNameAttr")]
		public static extern IntPtr UsdGeomSubset_GetFamilyNameAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_CreateFamilyNameAttr__SWIG_0")]
		public static extern IntPtr UsdGeomSubset_CreateFamilyNameAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_CreateFamilyNameAttr__SWIG_1")]
		public static extern IntPtr UsdGeomSubset_CreateFamilyNameAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_CreateFamilyNameAttr__SWIG_2")]
		public static extern IntPtr UsdGeomSubset_CreateFamilyNameAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_CreateGeomSubset__SWIG_0")]
		public static extern IntPtr UsdGeomSubset_CreateGeomSubset__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, HandleRef jarg6);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_CreateGeomSubset__SWIG_1")]
		public static extern IntPtr UsdGeomSubset_CreateGeomSubset__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_CreateGeomSubset__SWIG_2")]
		public static extern IntPtr UsdGeomSubset_CreateGeomSubset__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_CreateUniqueGeomSubset__SWIG_0")]
		public static extern IntPtr UsdGeomSubset_CreateUniqueGeomSubset__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, HandleRef jarg6);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_CreateUniqueGeomSubset__SWIG_1")]
		public static extern IntPtr UsdGeomSubset_CreateUniqueGeomSubset__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_CreateUniqueGeomSubset__SWIG_2")]
		public static extern IntPtr UsdGeomSubset_CreateUniqueGeomSubset__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_GetAllGeomSubsets")]
		public static extern IntPtr UsdGeomSubset_GetAllGeomSubsets(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_GetGeomSubsets__SWIG_0")]
		public static extern IntPtr UsdGeomSubset_GetGeomSubsets__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_GetGeomSubsets__SWIG_1")]
		public static extern IntPtr UsdGeomSubset_GetGeomSubsets__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_GetGeomSubsets__SWIG_2")]
		public static extern IntPtr UsdGeomSubset_GetGeomSubsets__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_GetAllGeomSubsetFamilyNames")]
		public static extern IntPtr UsdGeomSubset_GetAllGeomSubsetFamilyNames(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_SetFamilyType")]
		public static extern bool UsdGeomSubset_SetFamilyType(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_GetFamilyType")]
		public static extern IntPtr UsdGeomSubset_GetFamilyType(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_GetUnassignedIndices__SWIG_0")]
		public static extern IntPtr UsdGeomSubset_GetUnassignedIndices__SWIG_0(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_GetUnassignedIndices__SWIG_1")]
		public static extern IntPtr UsdGeomSubset_GetUnassignedIndices__SWIG_1(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_ValidateSubsets")]
		public static extern bool UsdGeomSubset_ValidateSubsets(HandleRef jarg1, uint jarg2, HandleRef jarg3, out string jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_ValidateFamily")]
		public static extern bool UsdGeomSubset_ValidateFamily(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, out string jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomVisibilityAPI__SWIG_0")]
		public static extern IntPtr new_UsdGeomVisibilityAPI__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomVisibilityAPI__SWIG_1")]
		public static extern IntPtr new_UsdGeomVisibilityAPI__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomVisibilityAPI__SWIG_2")]
		public static extern IntPtr new_UsdGeomVisibilityAPI__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomVisibilityAPI")]
		public static extern void delete_UsdGeomVisibilityAPI(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomVisibilityAPI_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomVisibilityAPI_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomVisibilityAPI_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomVisibilityAPI_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomVisibilityAPI_Get")]
		public static extern IntPtr UsdGeomVisibilityAPI_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomVisibilityAPI_CanApply__SWIG_0")]
		public static extern bool UsdGeomVisibilityAPI_CanApply__SWIG_0(HandleRef jarg1, out string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomVisibilityAPI_CanApply__SWIG_1")]
		public static extern bool UsdGeomVisibilityAPI_CanApply__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomVisibilityAPI_Apply")]
		public static extern IntPtr UsdGeomVisibilityAPI_Apply(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomVisibilityAPI_GetGuideVisibilityAttr")]
		public static extern IntPtr UsdGeomVisibilityAPI_GetGuideVisibilityAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomVisibilityAPI_CreateGuideVisibilityAttr__SWIG_0")]
		public static extern IntPtr UsdGeomVisibilityAPI_CreateGuideVisibilityAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomVisibilityAPI_CreateGuideVisibilityAttr__SWIG_1")]
		public static extern IntPtr UsdGeomVisibilityAPI_CreateGuideVisibilityAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomVisibilityAPI_CreateGuideVisibilityAttr__SWIG_2")]
		public static extern IntPtr UsdGeomVisibilityAPI_CreateGuideVisibilityAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomVisibilityAPI_GetProxyVisibilityAttr")]
		public static extern IntPtr UsdGeomVisibilityAPI_GetProxyVisibilityAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomVisibilityAPI_CreateProxyVisibilityAttr__SWIG_0")]
		public static extern IntPtr UsdGeomVisibilityAPI_CreateProxyVisibilityAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomVisibilityAPI_CreateProxyVisibilityAttr__SWIG_1")]
		public static extern IntPtr UsdGeomVisibilityAPI_CreateProxyVisibilityAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomVisibilityAPI_CreateProxyVisibilityAttr__SWIG_2")]
		public static extern IntPtr UsdGeomVisibilityAPI_CreateProxyVisibilityAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomVisibilityAPI_GetRenderVisibilityAttr")]
		public static extern IntPtr UsdGeomVisibilityAPI_GetRenderVisibilityAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomVisibilityAPI_CreateRenderVisibilityAttr__SWIG_0")]
		public static extern IntPtr UsdGeomVisibilityAPI_CreateRenderVisibilityAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomVisibilityAPI_CreateRenderVisibilityAttr__SWIG_1")]
		public static extern IntPtr UsdGeomVisibilityAPI_CreateRenderVisibilityAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomVisibilityAPI_CreateRenderVisibilityAttr__SWIG_2")]
		public static extern IntPtr UsdGeomVisibilityAPI_CreateRenderVisibilityAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomVisibilityAPI_GetPurposeVisibilityAttr")]
		public static extern IntPtr UsdGeomVisibilityAPI_GetPurposeVisibilityAttr(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomXform__SWIG_0")]
		public static extern IntPtr new_UsdGeomXform__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomXform__SWIG_1")]
		public static extern IntPtr new_UsdGeomXform__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomXform__SWIG_2")]
		public static extern IntPtr new_UsdGeomXform__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomXform")]
		public static extern void delete_UsdGeomXform(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXform_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomXform_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXform_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomXform_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXform_Get")]
		public static extern IntPtr UsdGeomXform_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXform_Define")]
		public static extern IntPtr UsdGeomXform_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomXformCache__SWIG_0")]
		public static extern IntPtr new_UsdGeomXformCache__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomXformCache__SWIG_1")]
		public static extern IntPtr new_UsdGeomXformCache__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCache_GetLocalToWorldTransform")]
		public static extern IntPtr UsdGeomXformCache_GetLocalToWorldTransform(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCache_GetParentToWorldTransform")]
		public static extern IntPtr UsdGeomXformCache_GetParentToWorldTransform(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCache_GetLocalTransformation")]
		public static extern IntPtr UsdGeomXformCache_GetLocalTransformation(HandleRef jarg1, HandleRef jarg2, out bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCache_ComputeRelativeTransform")]
		public static extern IntPtr UsdGeomXformCache_ComputeRelativeTransform(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, out bool jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCache_IsAttributeIncludedInLocalTransform")]
		public static extern bool UsdGeomXformCache_IsAttributeIncludedInLocalTransform(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCache_TransformMightBeTimeVarying")]
		public static extern bool UsdGeomXformCache_TransformMightBeTimeVarying(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCache_GetResetXformStack")]
		public static extern bool UsdGeomXformCache_GetResetXformStack(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCache_Clear")]
		public static extern void UsdGeomXformCache_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCache_SetTime")]
		public static extern void UsdGeomXformCache_SetTime(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCache_GetTime")]
		public static extern IntPtr UsdGeomXformCache_GetTime(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCache_Swap")]
		public static extern void UsdGeomXformCache_Swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomXformCache")]
		public static extern void delete_UsdGeomXformCache(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomXformCommonAPI__SWIG_0")]
		public static extern IntPtr new_UsdGeomXformCommonAPI__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomXformCommonAPI__SWIG_1")]
		public static extern IntPtr new_UsdGeomXformCommonAPI__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomXformCommonAPI__SWIG_2")]
		public static extern IntPtr new_UsdGeomXformCommonAPI__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomXformCommonAPI")]
		public static extern void delete_UsdGeomXformCommonAPI(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdGeomXformCommonAPI_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdGeomXformCommonAPI_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_Get")]
		public static extern IntPtr UsdGeomXformCommonAPI_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_Ops_translateOp_set")]
		public static extern void UsdGeomXformCommonAPI_Ops_translateOp_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_Ops_translateOp_get")]
		public static extern IntPtr UsdGeomXformCommonAPI_Ops_translateOp_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_Ops_pivotOp_set")]
		public static extern void UsdGeomXformCommonAPI_Ops_pivotOp_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_Ops_pivotOp_get")]
		public static extern IntPtr UsdGeomXformCommonAPI_Ops_pivotOp_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_Ops_rotateOp_set")]
		public static extern void UsdGeomXformCommonAPI_Ops_rotateOp_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_Ops_rotateOp_get")]
		public static extern IntPtr UsdGeomXformCommonAPI_Ops_rotateOp_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_Ops_scaleOp_set")]
		public static extern void UsdGeomXformCommonAPI_Ops_scaleOp_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_Ops_scaleOp_get")]
		public static extern IntPtr UsdGeomXformCommonAPI_Ops_scaleOp_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_Ops_inversePivotOp_set")]
		public static extern void UsdGeomXformCommonAPI_Ops_inversePivotOp_set(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_Ops_inversePivotOp_get")]
		public static extern IntPtr UsdGeomXformCommonAPI_Ops_inversePivotOp_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomXformCommonAPI_Ops")]
		public static extern IntPtr new_UsdGeomXformCommonAPI_Ops();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomXformCommonAPI_Ops")]
		public static extern void delete_UsdGeomXformCommonAPI_Ops(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_SetXformVectors")]
		public static extern bool UsdGeomXformCommonAPI_SetXformVectors(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, int jarg6, HandleRef jarg7);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_GetXformVectors")]
		public static extern bool UsdGeomXformCommonAPI_GetXformVectors(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, out UsdGeomXformCommonAPI.RotationOrder jarg6, HandleRef jarg7);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_GetXformVectorsByAccumulation")]
		public static extern bool UsdGeomXformCommonAPI_GetXformVectorsByAccumulation(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, out UsdGeomXformCommonAPI.RotationOrder jarg6, HandleRef jarg7);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_GetResetXformStack")]
		public static extern bool UsdGeomXformCommonAPI_GetResetXformStack(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_SetTranslate__SWIG_0")]
		public static extern bool UsdGeomXformCommonAPI_SetTranslate__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_SetTranslate__SWIG_1")]
		public static extern bool UsdGeomXformCommonAPI_SetTranslate__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_SetPivot__SWIG_0")]
		public static extern bool UsdGeomXformCommonAPI_SetPivot__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_SetPivot__SWIG_1")]
		public static extern bool UsdGeomXformCommonAPI_SetPivot__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_SetRotate__SWIG_0")]
		public static extern bool UsdGeomXformCommonAPI_SetRotate__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_SetRotate__SWIG_1")]
		public static extern bool UsdGeomXformCommonAPI_SetRotate__SWIG_1(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_SetRotate__SWIG_2")]
		public static extern bool UsdGeomXformCommonAPI_SetRotate__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_SetScale__SWIG_0")]
		public static extern bool UsdGeomXformCommonAPI_SetScale__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_SetScale__SWIG_1")]
		public static extern bool UsdGeomXformCommonAPI_SetScale__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_SetResetXformStack")]
		public static extern bool UsdGeomXformCommonAPI_SetResetXformStack(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_CreateXformOps__SWIG_0")]
		public static extern IntPtr UsdGeomXformCommonAPI_CreateXformOps__SWIG_0(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5, int jarg6);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_CreateXformOps__SWIG_1")]
		public static extern IntPtr UsdGeomXformCommonAPI_CreateXformOps__SWIG_1(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_CreateXformOps__SWIG_2")]
		public static extern IntPtr UsdGeomXformCommonAPI_CreateXformOps__SWIG_2(HandleRef jarg1, int jarg2, int jarg3, int jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_CreateXformOps__SWIG_3")]
		public static extern IntPtr UsdGeomXformCommonAPI_CreateXformOps__SWIG_3(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_CreateXformOps__SWIG_4")]
		public static extern IntPtr UsdGeomXformCommonAPI_CreateXformOps__SWIG_4(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_CreateXformOps__SWIG_5")]
		public static extern IntPtr UsdGeomXformCommonAPI_CreateXformOps__SWIG_5(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_CreateXformOps__SWIG_6")]
		public static extern IntPtr UsdGeomXformCommonAPI_CreateXformOps__SWIG_6(HandleRef jarg1, int jarg2, int jarg3, int jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_CreateXformOps__SWIG_7")]
		public static extern IntPtr UsdGeomXformCommonAPI_CreateXformOps__SWIG_7(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_CreateXformOps__SWIG_8")]
		public static extern IntPtr UsdGeomXformCommonAPI_CreateXformOps__SWIG_8(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_CreateXformOps__SWIG_9")]
		public static extern IntPtr UsdGeomXformCommonAPI_CreateXformOps__SWIG_9(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_GetRotationTransform")]
		public static extern IntPtr UsdGeomXformCommonAPI_GetRotationTransform(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_ConvertRotationOrderToOpType")]
		public static extern int UsdGeomXformCommonAPI_ConvertRotationOrderToOpType(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_ConvertOpTypeToRotationOrder")]
		public static extern int UsdGeomXformCommonAPI_ConvertOpTypeToRotationOrder(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_CanConvertOpTypeToRotationOrder")]
		public static extern bool UsdGeomXformCommonAPI_CanConvertOpTypeToRotationOrder(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI__IsValid")]
		public static extern bool UsdGeomXformCommonAPI__IsValid(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOpVector_Clear")]
		public static extern void UsdGeomXformOpVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOpVector_Add")]
		public static extern void UsdGeomXformOpVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOpVector_size")]
		public static extern uint UsdGeomXformOpVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOpVector_capacity")]
		public static extern uint UsdGeomXformOpVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOpVector_reserve")]
		public static extern void UsdGeomXformOpVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomXformOpVector__SWIG_0")]
		public static extern IntPtr new_UsdGeomXformOpVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomXformOpVector__SWIG_1")]
		public static extern IntPtr new_UsdGeomXformOpVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomXformOpVector__SWIG_2")]
		public static extern IntPtr new_UsdGeomXformOpVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOpVector_getitemcopy")]
		public static extern IntPtr UsdGeomXformOpVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOpVector_getitem")]
		public static extern IntPtr UsdGeomXformOpVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOpVector_setitem")]
		public static extern void UsdGeomXformOpVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOpVector_AddRange")]
		public static extern void UsdGeomXformOpVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOpVector_GetRange")]
		public static extern IntPtr UsdGeomXformOpVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOpVector_Insert")]
		public static extern void UsdGeomXformOpVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOpVector_InsertRange")]
		public static extern void UsdGeomXformOpVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOpVector_RemoveAt")]
		public static extern void UsdGeomXformOpVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOpVector_RemoveRange")]
		public static extern void UsdGeomXformOpVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOpVector_Repeat")]
		public static extern IntPtr UsdGeomXformOpVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOpVector_Reverse__SWIG_0")]
		public static extern void UsdGeomXformOpVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOpVector_Reverse__SWIG_1")]
		public static extern void UsdGeomXformOpVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOpVector_SetRange")]
		public static extern void UsdGeomXformOpVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomXformOpVector")]
		public static extern void delete_UsdGeomXformOpVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomXformOp__SWIG_0")]
		public static extern IntPtr new_UsdGeomXformOp__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomXformOp__SWIG_1")]
		public static extern IntPtr new_UsdGeomXformOp__SWIG_1(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdGeomXformOp__SWIG_2")]
		public static extern IntPtr new_UsdGeomXformOp__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_IsXformOp__SWIG_0")]
		public static extern bool UsdGeomXformOp_IsXformOp__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_IsXformOp__SWIG_1")]
		public static extern bool UsdGeomXformOp_IsXformOp__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_GetOpTypeToken")]
		public static extern IntPtr UsdGeomXformOp_GetOpTypeToken(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_GetOpTypeEnum")]
		public static extern int UsdGeomXformOp_GetOpTypeEnum(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_GetPrecisionFromValueTypeName")]
		public static extern int UsdGeomXformOp_GetPrecisionFromValueTypeName(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_GetValueTypeName")]
		public static extern IntPtr UsdGeomXformOp_GetValueTypeName(int jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_GetOpName__SWIG_0")]
		public static extern IntPtr UsdGeomXformOp_GetOpName__SWIG_0(int jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_GetOpName__SWIG_1")]
		public static extern IntPtr UsdGeomXformOp_GetOpName__SWIG_1(int jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_GetOpName__SWIG_2")]
		public static extern IntPtr UsdGeomXformOp_GetOpName__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_GetOpType")]
		public static extern int UsdGeomXformOp_GetOpType(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_GetPrecision")]
		public static extern int UsdGeomXformOp_GetPrecision(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_IsInverseOp")]
		public static extern bool UsdGeomXformOp_IsInverseOp(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_GetOpName__SWIG_3")]
		public static extern IntPtr UsdGeomXformOp_GetOpName__SWIG_3(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_HasSuffix")]
		public static extern bool UsdGeomXformOp_HasSuffix(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_GetOpTransform__SWIG_0")]
		public static extern IntPtr UsdGeomXformOp_GetOpTransform__SWIG_0(int jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_GetOpTransform__SWIG_1")]
		public static extern IntPtr UsdGeomXformOp_GetOpTransform__SWIG_1(int jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_GetOpTransform__SWIG_2")]
		public static extern IntPtr UsdGeomXformOp_GetOpTransform__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_MightBeTimeVarying")]
		public static extern bool UsdGeomXformOp_MightBeTimeVarying(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_GetAttr")]
		public static extern IntPtr UsdGeomXformOp_GetAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_IsDefined")]
		public static extern bool UsdGeomXformOp_IsDefined(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_GetName")]
		public static extern IntPtr UsdGeomXformOp_GetName(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_GetBaseName")]
		public static extern IntPtr UsdGeomXformOp_GetBaseName(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_GetNamespace")]
		public static extern IntPtr UsdGeomXformOp_GetNamespace(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_SplitName")]
		public static extern IntPtr UsdGeomXformOp_SplitName(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_GetTypeName")]
		public static extern IntPtr UsdGeomXformOp_GetTypeName(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_GetTimeSamples")]
		public static extern bool UsdGeomXformOp_GetTimeSamples(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_GetNumTimeSamples")]
		public static extern uint UsdGeomXformOp_GetNumTimeSamples(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_Set__SWIG_2")]
		public static extern bool UsdGeomXformOp_Set__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformOp_Set__SWIG_3")]
		public static extern bool UsdGeomXformOp_Set__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdGeomXformOp")]
		public static extern void delete_UsdGeomXformOp(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointBased_SWIGUpcast")]
		public static extern IntPtr UsdGeomPointBased_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCurves_SWIGUpcast")]
		public static extern IntPtr UsdGeomCurves_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBasisCurves_SWIGUpcast")]
		public static extern IntPtr UsdGeomBasisCurves_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformable_SWIGUpcast")]
		public static extern IntPtr UsdGeomXformable_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomBoundable_SWIGUpcast")]
		public static extern IntPtr UsdGeomBoundable_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCamera_SWIGUpcast")]
		public static extern IntPtr UsdGeomCamera_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomGprim_SWIGUpcast")]
		public static extern IntPtr UsdGeomGprim_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCapsule_SWIGUpcast")]
		public static extern IntPtr UsdGeomCapsule_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCone_SWIGUpcast")]
		public static extern IntPtr UsdGeomCone_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCube_SWIGUpcast")]
		public static extern IntPtr UsdGeomCube_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomCylinder_SWIGUpcast")]
		public static extern IntPtr UsdGeomCylinder_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomImageable_SWIGUpcast")]
		public static extern IntPtr UsdGeomImageable_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMesh_SWIGUpcast")]
		public static extern IntPtr UsdGeomMesh_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomModelAPI_SWIGUpcast")]
		public static extern IntPtr UsdGeomModelAPI_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomMotionAPI_SWIGUpcast")]
		public static extern IntPtr UsdGeomMotionAPI_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsCurves_SWIGUpcast")]
		public static extern IntPtr UsdGeomNurbsCurves_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomNurbsPatch_SWIGUpcast")]
		public static extern IntPtr UsdGeomNurbsPatch_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPlane_SWIGUpcast")]
		public static extern IntPtr UsdGeomPlane_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPointInstancer_SWIGUpcast")]
		public static extern IntPtr UsdGeomPointInstancer_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPoints_SWIGUpcast")]
		public static extern IntPtr UsdGeomPoints_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomPrimvarsAPI_SWIGUpcast")]
		public static extern IntPtr UsdGeomPrimvarsAPI_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomScope_SWIGUpcast")]
		public static extern IntPtr UsdGeomScope_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSphere_SWIGUpcast")]
		public static extern IntPtr UsdGeomSphere_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomSubset_SWIGUpcast")]
		public static extern IntPtr UsdGeomSubset_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomVisibilityAPI_SWIGUpcast")]
		public static extern IntPtr UsdGeomVisibilityAPI_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXform_SWIGUpcast")]
		public static extern IntPtr UsdGeomXform_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdGeomXformCommonAPI_SWIGUpcast")]
		public static extern IntPtr UsdGeomXformCommonAPI_SWIGUpcast(IntPtr jarg1);
	}
}
