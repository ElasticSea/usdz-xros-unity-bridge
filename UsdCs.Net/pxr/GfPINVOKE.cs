using System;
using System.Runtime.InteropServices;

namespace pxr
{
	internal class GfPINVOKE
	{
		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			[DllImport("UsdCs")]
			public static extern void SWIGRegisterStringCallback_Gf(SWIGStringDelegate stringDelegate);

			[MonoPInvokeCallback]
			private static string CreateString(string cString)
			{
				return cString;
			}

			static SWIGStringHelper()
			{
				stringDelegate = CreateString;
				SWIGRegisterStringCallback_Gf(stringDelegate);
			}
		}

		public class SWIGPendingException : UsdCsPINVOKE.SWIGPendingException
		{
		}

		protected static SWIGStringHelper swigStringHelper;

		static GfPINVOKE()
		{
			swigStringHelper = new SWIGStringHelper();
		}

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfBBox3d__SWIG_0")]
		public static extern IntPtr new_GfBBox3d__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfBBox3d__SWIG_1")]
		public static extern IntPtr new_GfBBox3d__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfBBox3d__SWIG_2")]
		public static extern IntPtr new_GfBBox3d__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfBBox3d__SWIG_3")]
		public static extern IntPtr new_GfBBox3d__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfBBox3d_Set")]
		public static extern void GfBBox3d_Set(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfBBox3d_SetMatrix")]
		public static extern void GfBBox3d_SetMatrix(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfBBox3d_SetRange")]
		public static extern void GfBBox3d_SetRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfBBox3d_GetRange")]
		public static extern IntPtr GfBBox3d_GetRange(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfBBox3d_GetBox")]
		public static extern IntPtr GfBBox3d_GetBox(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfBBox3d_GetMatrix")]
		public static extern IntPtr GfBBox3d_GetMatrix(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfBBox3d_GetInverseMatrix")]
		public static extern IntPtr GfBBox3d_GetInverseMatrix(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfBBox3d_SetHasZeroAreaPrimitives")]
		public static extern void GfBBox3d_SetHasZeroAreaPrimitives(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfBBox3d_HasZeroAreaPrimitives")]
		public static extern bool GfBBox3d_HasZeroAreaPrimitives(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfBBox3d_GetVolume")]
		public static extern double GfBBox3d_GetVolume(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfBBox3d_Transform")]
		public static extern void GfBBox3d_Transform(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfBBox3d_ComputeAlignedRange")]
		public static extern IntPtr GfBBox3d_ComputeAlignedRange(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfBBox3d_ComputeAlignedBox")]
		public static extern IntPtr GfBBox3d_ComputeAlignedBox(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfBBox3d_Combine")]
		public static extern IntPtr GfBBox3d_Combine(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfBBox3d_ComputeCentroid")]
		public static extern IntPtr GfBBox3d_ComputeCentroid(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfBBox3d_Equals")]
		public static extern bool GfBBox3d_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfBBox3d_GetHashCode")]
		public static extern int GfBBox3d_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfBBox3d")]
		public static extern void delete_GfBBox3d(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_APERTURE_UNIT_get")]
		public static extern double GfCamera_APERTURE_UNIT_get();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_FOCAL_LENGTH_UNIT_get")]
		public static extern double GfCamera_FOCAL_LENGTH_UNIT_get();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_DEFAULT_HORIZONTAL_APERTURE_get")]
		public static extern double GfCamera_DEFAULT_HORIZONTAL_APERTURE_get();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_DEFAULT_VERTICAL_APERTURE_get")]
		public static extern double GfCamera_DEFAULT_VERTICAL_APERTURE_get();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfCamera__SWIG_0")]
		public static extern IntPtr new_GfCamera__SWIG_0(HandleRef jarg1, int jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7, HandleRef jarg8, HandleRef jarg9, float jarg10, float jarg11);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfCamera__SWIG_1")]
		public static extern IntPtr new_GfCamera__SWIG_1(HandleRef jarg1, int jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7, HandleRef jarg8, HandleRef jarg9, float jarg10);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfCamera__SWIG_2")]
		public static extern IntPtr new_GfCamera__SWIG_2(HandleRef jarg1, int jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7, HandleRef jarg8, HandleRef jarg9);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfCamera__SWIG_3")]
		public static extern IntPtr new_GfCamera__SWIG_3(HandleRef jarg1, int jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7, HandleRef jarg8);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfCamera__SWIG_4")]
		public static extern IntPtr new_GfCamera__SWIG_4(HandleRef jarg1, int jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfCamera__SWIG_5")]
		public static extern IntPtr new_GfCamera__SWIG_5(HandleRef jarg1, int jarg2, float jarg3, float jarg4, float jarg5, float jarg6);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfCamera__SWIG_6")]
		public static extern IntPtr new_GfCamera__SWIG_6(HandleRef jarg1, int jarg2, float jarg3, float jarg4, float jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfCamera__SWIG_7")]
		public static extern IntPtr new_GfCamera__SWIG_7(HandleRef jarg1, int jarg2, float jarg3, float jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfCamera__SWIG_8")]
		public static extern IntPtr new_GfCamera__SWIG_8(HandleRef jarg1, int jarg2, float jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfCamera__SWIG_9")]
		public static extern IntPtr new_GfCamera__SWIG_9(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfCamera__SWIG_10")]
		public static extern IntPtr new_GfCamera__SWIG_10(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfCamera__SWIG_11")]
		public static extern IntPtr new_GfCamera__SWIG_11();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_SetTransform")]
		public static extern void GfCamera_SetTransform(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_SetProjection")]
		public static extern void GfCamera_SetProjection(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_SetFocalLength")]
		public static extern void GfCamera_SetFocalLength(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_SetHorizontalAperture")]
		public static extern void GfCamera_SetHorizontalAperture(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_SetVerticalAperture")]
		public static extern void GfCamera_SetVerticalAperture(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_SetHorizontalApertureOffset")]
		public static extern void GfCamera_SetHorizontalApertureOffset(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_SetVerticalApertureOffset")]
		public static extern void GfCamera_SetVerticalApertureOffset(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_SetPerspectiveFromAspectRatioAndFieldOfView__SWIG_0")]
		public static extern void GfCamera_SetPerspectiveFromAspectRatioAndFieldOfView__SWIG_0(HandleRef jarg1, float jarg2, float jarg3, int jarg4, float jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_SetPerspectiveFromAspectRatioAndFieldOfView__SWIG_1")]
		public static extern void GfCamera_SetPerspectiveFromAspectRatioAndFieldOfView__SWIG_1(HandleRef jarg1, float jarg2, float jarg3, int jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_SetOrthographicFromAspectRatioAndSize")]
		public static extern void GfCamera_SetOrthographicFromAspectRatioAndSize(HandleRef jarg1, float jarg2, float jarg3, int jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_SetFromViewAndProjectionMatrix__SWIG_0")]
		public static extern void GfCamera_SetFromViewAndProjectionMatrix__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, float jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_SetFromViewAndProjectionMatrix__SWIG_1")]
		public static extern void GfCamera_SetFromViewAndProjectionMatrix__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_SetClippingRange")]
		public static extern void GfCamera_SetClippingRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_SetClippingPlanes")]
		public static extern void GfCamera_SetClippingPlanes(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_SetFStop")]
		public static extern void GfCamera_SetFStop(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_SetFocusDistance")]
		public static extern void GfCamera_SetFocusDistance(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_GetTransform")]
		public static extern IntPtr GfCamera_GetTransform(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_GetProjection")]
		public static extern int GfCamera_GetProjection(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_GetHorizontalAperture")]
		public static extern float GfCamera_GetHorizontalAperture(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_GetVerticalAperture")]
		public static extern float GfCamera_GetVerticalAperture(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_GetHorizontalApertureOffset")]
		public static extern float GfCamera_GetHorizontalApertureOffset(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_GetVerticalApertureOffset")]
		public static extern float GfCamera_GetVerticalApertureOffset(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_GetAspectRatio")]
		public static extern float GfCamera_GetAspectRatio(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_GetFocalLength")]
		public static extern float GfCamera_GetFocalLength(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_GetFieldOfView")]
		public static extern float GfCamera_GetFieldOfView(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_GetClippingRange")]
		public static extern IntPtr GfCamera_GetClippingRange(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_GetClippingPlanes")]
		public static extern IntPtr GfCamera_GetClippingPlanes(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_GetFrustum")]
		public static extern IntPtr GfCamera_GetFrustum(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_GetFStop")]
		public static extern float GfCamera_GetFStop(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_GetFocusDistance")]
		public static extern float GfCamera_GetFocusDistance(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_Equals")]
		public static extern bool GfCamera_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCamera_GetHashCode")]
		public static extern int GfCamera_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfCamera")]
		public static extern void delete_GfCamera(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDot__SWIG_0")]
		public static extern double GfDot__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfDualQuatd__SWIG_0")]
		public static extern IntPtr new_GfDualQuatd__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfDualQuatd__SWIG_1")]
		public static extern IntPtr new_GfDualQuatd__SWIG_1(double jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfDualQuatd__SWIG_2")]
		public static extern IntPtr new_GfDualQuatd__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfDualQuatd__SWIG_3")]
		public static extern IntPtr new_GfDualQuatd__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfDualQuatd__SWIG_4")]
		public static extern IntPtr new_GfDualQuatd__SWIG_4(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfDualQuatd__SWIG_5")]
		public static extern IntPtr new_GfDualQuatd__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfDualQuatd__SWIG_6")]
		public static extern IntPtr new_GfDualQuatd__SWIG_6(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatd_SetReal")]
		public static extern void GfDualQuatd_SetReal(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatd_SetDual")]
		public static extern void GfDualQuatd_SetDual(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatd_GetReal")]
		public static extern IntPtr GfDualQuatd_GetReal(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatd_GetDual")]
		public static extern IntPtr GfDualQuatd_GetDual(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatd_GetZero")]
		public static extern IntPtr GfDualQuatd_GetZero();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatd_GetIdentity")]
		public static extern IntPtr GfDualQuatd_GetIdentity();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatd_GetLength")]
		public static extern IntPtr GfDualQuatd_GetLength(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatd_GetNormalized__SWIG_0")]
		public static extern IntPtr GfDualQuatd_GetNormalized__SWIG_0(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatd_GetNormalized__SWIG_1")]
		public static extern IntPtr GfDualQuatd_GetNormalized__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatd_Normalize__SWIG_0")]
		public static extern IntPtr GfDualQuatd_Normalize__SWIG_0(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatd_Normalize__SWIG_1")]
		public static extern IntPtr GfDualQuatd_Normalize__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatd_GetConjugate")]
		public static extern IntPtr GfDualQuatd_GetConjugate(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatd_GetInverse")]
		public static extern IntPtr GfDualQuatd_GetInverse(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatd_SetTranslation")]
		public static extern void GfDualQuatd_SetTranslation(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatd_GetTranslation")]
		public static extern IntPtr GfDualQuatd_GetTranslation(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatd_Transform")]
		public static extern IntPtr GfDualQuatd_Transform(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatd_Equals")]
		public static extern bool GfDualQuatd_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatd_GetHashCode")]
		public static extern int GfDualQuatd_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfDualQuatd")]
		public static extern void delete_GfDualQuatd(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDot__SWIG_1")]
		public static extern float GfDot__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfDualQuatf__SWIG_0")]
		public static extern IntPtr new_GfDualQuatf__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfDualQuatf__SWIG_1")]
		public static extern IntPtr new_GfDualQuatf__SWIG_1(float jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfDualQuatf__SWIG_2")]
		public static extern IntPtr new_GfDualQuatf__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfDualQuatf__SWIG_3")]
		public static extern IntPtr new_GfDualQuatf__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfDualQuatf__SWIG_4")]
		public static extern IntPtr new_GfDualQuatf__SWIG_4(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfDualQuatf__SWIG_5")]
		public static extern IntPtr new_GfDualQuatf__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfDualQuatf__SWIG_6")]
		public static extern IntPtr new_GfDualQuatf__SWIG_6(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatf_SetReal")]
		public static extern void GfDualQuatf_SetReal(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatf_SetDual")]
		public static extern void GfDualQuatf_SetDual(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatf_GetReal")]
		public static extern IntPtr GfDualQuatf_GetReal(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatf_GetDual")]
		public static extern IntPtr GfDualQuatf_GetDual(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatf_GetZero")]
		public static extern IntPtr GfDualQuatf_GetZero();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatf_GetIdentity")]
		public static extern IntPtr GfDualQuatf_GetIdentity();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatf_GetLength")]
		public static extern IntPtr GfDualQuatf_GetLength(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatf_GetNormalized__SWIG_0")]
		public static extern IntPtr GfDualQuatf_GetNormalized__SWIG_0(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatf_GetNormalized__SWIG_1")]
		public static extern IntPtr GfDualQuatf_GetNormalized__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatf_Normalize__SWIG_0")]
		public static extern IntPtr GfDualQuatf_Normalize__SWIG_0(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatf_Normalize__SWIG_1")]
		public static extern IntPtr GfDualQuatf_Normalize__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatf_GetConjugate")]
		public static extern IntPtr GfDualQuatf_GetConjugate(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatf_GetInverse")]
		public static extern IntPtr GfDualQuatf_GetInverse(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatf_SetTranslation")]
		public static extern void GfDualQuatf_SetTranslation(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatf_GetTranslation")]
		public static extern IntPtr GfDualQuatf_GetTranslation(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatf_Transform")]
		public static extern IntPtr GfDualQuatf_Transform(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatf_Equals")]
		public static extern bool GfDualQuatf_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuatf_GetHashCode")]
		public static extern int GfDualQuatf_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfDualQuatf")]
		public static extern void delete_GfDualQuatf(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDot__SWIG_2")]
		public static extern IntPtr GfDot__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfDualQuath__SWIG_0")]
		public static extern IntPtr new_GfDualQuath__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfDualQuath__SWIG_1")]
		public static extern IntPtr new_GfDualQuath__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfDualQuath__SWIG_2")]
		public static extern IntPtr new_GfDualQuath__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfDualQuath__SWIG_3")]
		public static extern IntPtr new_GfDualQuath__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfDualQuath__SWIG_4")]
		public static extern IntPtr new_GfDualQuath__SWIG_4(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfDualQuath__SWIG_5")]
		public static extern IntPtr new_GfDualQuath__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfDualQuath__SWIG_6")]
		public static extern IntPtr new_GfDualQuath__SWIG_6(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuath_SetReal")]
		public static extern void GfDualQuath_SetReal(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuath_SetDual")]
		public static extern void GfDualQuath_SetDual(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuath_GetReal")]
		public static extern IntPtr GfDualQuath_GetReal(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuath_GetDual")]
		public static extern IntPtr GfDualQuath_GetDual(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuath_GetZero")]
		public static extern IntPtr GfDualQuath_GetZero();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuath_GetIdentity")]
		public static extern IntPtr GfDualQuath_GetIdentity();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuath_GetLength")]
		public static extern IntPtr GfDualQuath_GetLength(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuath_GetNormalized__SWIG_0")]
		public static extern IntPtr GfDualQuath_GetNormalized__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuath_GetNormalized__SWIG_1")]
		public static extern IntPtr GfDualQuath_GetNormalized__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuath_Normalize__SWIG_0")]
		public static extern IntPtr GfDualQuath_Normalize__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuath_Normalize__SWIG_1")]
		public static extern IntPtr GfDualQuath_Normalize__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuath_GetConjugate")]
		public static extern IntPtr GfDualQuath_GetConjugate(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuath_GetInverse")]
		public static extern IntPtr GfDualQuath_GetInverse(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuath_SetTranslation")]
		public static extern void GfDualQuath_SetTranslation(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuath_GetTranslation")]
		public static extern IntPtr GfDualQuath_GetTranslation(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuath_Transform")]
		public static extern IntPtr GfDualQuath_Transform(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuath_Equals")]
		public static extern bool GfDualQuath_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDualQuath_GetHashCode")]
		public static extern int GfDualQuath_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfDualQuath")]
		public static extern void delete_GfDualQuath(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfFrustum__SWIG_0")]
		public static extern IntPtr new_GfFrustum__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfFrustum__SWIG_1")]
		public static extern IntPtr new_GfFrustum__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfFrustum__SWIG_3")]
		public static extern IntPtr new_GfFrustum__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5, double jarg6);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfFrustum__SWIG_4")]
		public static extern IntPtr new_GfFrustum__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfFrustum__SWIG_5")]
		public static extern IntPtr new_GfFrustum__SWIG_5(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4, double jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfFrustum__SWIG_6")]
		public static extern IntPtr new_GfFrustum__SWIG_6(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfFrustum")]
		public static extern void delete_GfFrustum(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_SetPosition")]
		public static extern void GfFrustum_SetPosition(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_GetPosition")]
		public static extern IntPtr GfFrustum_GetPosition(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_SetRotation")]
		public static extern void GfFrustum_SetRotation(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_GetRotation")]
		public static extern IntPtr GfFrustum_GetRotation(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_SetPositionAndRotationFromMatrix")]
		public static extern void GfFrustum_SetPositionAndRotationFromMatrix(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_SetWindow")]
		public static extern void GfFrustum_SetWindow(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_GetWindow")]
		public static extern IntPtr GfFrustum_GetWindow(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_GetReferencePlaneDepth")]
		public static extern double GfFrustum_GetReferencePlaneDepth();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_SetNearFar")]
		public static extern void GfFrustum_SetNearFar(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_GetNearFar")]
		public static extern IntPtr GfFrustum_GetNearFar(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_SetViewDistance")]
		public static extern void GfFrustum_SetViewDistance(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_GetViewDistance")]
		public static extern double GfFrustum_GetViewDistance(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_SetProjectionType")]
		public static extern void GfFrustum_SetProjectionType(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_GetProjectionType")]
		public static extern int GfFrustum_GetProjectionType(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_SetPerspective__SWIG_0")]
		public static extern void GfFrustum_SetPerspective__SWIG_0(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_SetPerspective__SWIG_1")]
		public static extern void GfFrustum_SetPerspective__SWIG_1(HandleRef jarg1, double jarg2, bool jarg3, double jarg4, double jarg5, double jarg6);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_GetPerspective__SWIG_0")]
		public static extern bool GfFrustum_GetPerspective__SWIG_0(HandleRef jarg1, out double jarg2, out double jarg3, out double jarg4, out double jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_GetPerspective__SWIG_1")]
		public static extern bool GfFrustum_GetPerspective__SWIG_1(HandleRef jarg1, bool jarg2, out double jarg3, out double jarg4, out double jarg5, out double jarg6);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_GetFOV__SWIG_0")]
		public static extern double GfFrustum_GetFOV__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_GetFOV__SWIG_1")]
		public static extern double GfFrustum_GetFOV__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_SetOrthographic")]
		public static extern void GfFrustum_SetOrthographic(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5, double jarg6, double jarg7);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_GetOrthographic")]
		public static extern bool GfFrustum_GetOrthographic(HandleRef jarg1, out double jarg2, out double jarg3, out double jarg4, out double jarg5, out double jarg6, out double jarg7);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_FitToSphere__SWIG_0")]
		public static extern void GfFrustum_FitToSphere__SWIG_0(HandleRef jarg1, HandleRef jarg2, double jarg3, double jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_FitToSphere__SWIG_1")]
		public static extern void GfFrustum_FitToSphere__SWIG_1(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_Transform")]
		public static extern IntPtr GfFrustum_Transform(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_ComputeViewDirection")]
		public static extern IntPtr GfFrustum_ComputeViewDirection(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_ComputeUpVector")]
		public static extern IntPtr GfFrustum_ComputeUpVector(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_ComputeViewFrame")]
		public static extern void GfFrustum_ComputeViewFrame(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_ComputeLookAtPoint")]
		public static extern IntPtr GfFrustum_ComputeLookAtPoint(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_ComputeViewMatrix")]
		public static extern IntPtr GfFrustum_ComputeViewMatrix(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_ComputeViewInverse")]
		public static extern IntPtr GfFrustum_ComputeViewInverse(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_ComputeProjectionMatrix")]
		public static extern IntPtr GfFrustum_ComputeProjectionMatrix(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_ComputeAspectRatio")]
		public static extern double GfFrustum_ComputeAspectRatio(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_ComputeCorners")]
		public static extern IntPtr GfFrustum_ComputeCorners(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_ComputeCornersAtDistance")]
		public static extern IntPtr GfFrustum_ComputeCornersAtDistance(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_ComputeNarrowedFrustum__SWIG_0")]
		public static extern IntPtr GfFrustum_ComputeNarrowedFrustum__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_ComputeNarrowedFrustum__SWIG_1")]
		public static extern IntPtr GfFrustum_ComputeNarrowedFrustum__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_ComputeRay__SWIG_0")]
		public static extern IntPtr GfFrustum_ComputeRay__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_ComputeRay__SWIG_1")]
		public static extern IntPtr GfFrustum_ComputeRay__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_ComputePickRay__SWIG_0")]
		public static extern IntPtr GfFrustum_ComputePickRay__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_ComputePickRay__SWIG_1")]
		public static extern IntPtr GfFrustum_ComputePickRay__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_Intersects__SWIG_0")]
		public static extern bool GfFrustum_Intersects__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_Intersects__SWIG_1")]
		public static extern bool GfFrustum_Intersects__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_Intersects__SWIG_2")]
		public static extern bool GfFrustum_Intersects__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_Intersects__SWIG_3")]
		public static extern bool GfFrustum_Intersects__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_IntersectsViewVolume")]
		public static extern bool GfFrustum_IntersectsViewVolume(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_Equals")]
		public static extern bool GfFrustum_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFrustum_GetHashCode")]
		public static extern int GfFrustum_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfApplyGamma__SWIG_0")]
		public static extern IntPtr GfApplyGamma__SWIG_0(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfApplyGamma__SWIG_1")]
		public static extern IntPtr GfApplyGamma__SWIG_1(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfApplyGamma__SWIG_2")]
		public static extern IntPtr GfApplyGamma__SWIG_2(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfApplyGamma__SWIG_3")]
		public static extern IntPtr GfApplyGamma__SWIG_3(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfApplyGamma__SWIG_4")]
		public static extern IntPtr GfApplyGamma__SWIG_4(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfApplyGamma__SWIG_5")]
		public static extern IntPtr GfApplyGamma__SWIG_5(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfApplyGamma__SWIG_6")]
		public static extern float GfApplyGamma__SWIG_6(float jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfApplyGamma__SWIG_7")]
		public static extern byte GfApplyGamma__SWIG_7(byte jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetDisplayGamma")]
		public static extern double GfGetDisplayGamma();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfConvertLinearToDisplay__SWIG_0")]
		public static extern IntPtr GfConvertLinearToDisplay__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfConvertLinearToDisplay__SWIG_1")]
		public static extern IntPtr GfConvertLinearToDisplay__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfConvertLinearToDisplay__SWIG_2")]
		public static extern IntPtr GfConvertLinearToDisplay__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfConvertLinearToDisplay__SWIG_3")]
		public static extern IntPtr GfConvertLinearToDisplay__SWIG_3(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfConvertLinearToDisplay__SWIG_4")]
		public static extern IntPtr GfConvertLinearToDisplay__SWIG_4(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfConvertLinearToDisplay__SWIG_5")]
		public static extern IntPtr GfConvertLinearToDisplay__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfConvertLinearToDisplay__SWIG_6")]
		public static extern float GfConvertLinearToDisplay__SWIG_6(float jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfConvertLinearToDisplay__SWIG_7")]
		public static extern byte GfConvertLinearToDisplay__SWIG_7(byte jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfConvertDisplayToLinear__SWIG_0")]
		public static extern IntPtr GfConvertDisplayToLinear__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfConvertDisplayToLinear__SWIG_1")]
		public static extern IntPtr GfConvertDisplayToLinear__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfConvertDisplayToLinear__SWIG_2")]
		public static extern IntPtr GfConvertDisplayToLinear__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfConvertDisplayToLinear__SWIG_3")]
		public static extern IntPtr GfConvertDisplayToLinear__SWIG_3(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfConvertDisplayToLinear__SWIG_4")]
		public static extern IntPtr GfConvertDisplayToLinear__SWIG_4(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfConvertDisplayToLinear__SWIG_5")]
		public static extern IntPtr GfConvertDisplayToLinear__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfConvertDisplayToLinear__SWIG_6")]
		public static extern float GfConvertDisplayToLinear__SWIG_6(float jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfConvertDisplayToLinear__SWIG_7")]
		public static extern byte GfConvertDisplayToLinear__SWIG_7(byte jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfHalf_Equals")]
		public static extern bool GfHalf_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfHalf_GetHashCode")]
		public static extern int GfHalf_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfHalf")]
		public static extern IntPtr new_GfHalf();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfHalf")]
		public static extern void delete_GfHalf(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetHomogenized__SWIG_0")]
		public static extern IntPtr GfGetHomogenized__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfHomogeneousCross__SWIG_0")]
		public static extern IntPtr GfHomogeneousCross__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetHomogenized__SWIG_1")]
		public static extern IntPtr GfGetHomogenized__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfHomogeneousCross__SWIG_1")]
		public static extern IntPtr GfHomogeneousCross__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfProject__SWIG_0")]
		public static extern IntPtr GfProject__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfProject__SWIG_1")]
		public static extern IntPtr GfProject__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfInterval__SWIG_0")]
		public static extern IntPtr new_GfInterval__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfInterval__SWIG_1")]
		public static extern IntPtr new_GfInterval__SWIG_1(double jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfInterval__SWIG_2")]
		public static extern IntPtr new_GfInterval__SWIG_2(double jarg1, double jarg2, bool jarg3, bool jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfInterval__SWIG_3")]
		public static extern IntPtr new_GfInterval__SWIG_3(double jarg1, double jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfInterval__SWIG_4")]
		public static extern IntPtr new_GfInterval__SWIG_4(double jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfInterval_Hash")]
		public static extern uint GfInterval_Hash(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfInterval_GetMin")]
		public static extern double GfInterval_GetMin(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfInterval_GetMax")]
		public static extern double GfInterval_GetMax(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfInterval_SetMin__SWIG_0")]
		public static extern void GfInterval_SetMin__SWIG_0(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfInterval_SetMin__SWIG_1")]
		public static extern void GfInterval_SetMin__SWIG_1(HandleRef jarg1, double jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfInterval_SetMax__SWIG_0")]
		public static extern void GfInterval_SetMax__SWIG_0(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfInterval_SetMax__SWIG_1")]
		public static extern void GfInterval_SetMax__SWIG_1(HandleRef jarg1, double jarg2, bool jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfInterval_IsMinClosed")]
		public static extern bool GfInterval_IsMinClosed(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfInterval_IsMaxClosed")]
		public static extern bool GfInterval_IsMaxClosed(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfInterval_IsMinOpen")]
		public static extern bool GfInterval_IsMinOpen(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfInterval_IsMaxOpen")]
		public static extern bool GfInterval_IsMaxOpen(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfInterval_IsMaxFinite")]
		public static extern bool GfInterval_IsMaxFinite(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfInterval_IsMinFinite")]
		public static extern bool GfInterval_IsMinFinite(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfInterval_IsFinite")]
		public static extern bool GfInterval_IsFinite(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfInterval_IsEmpty")]
		public static extern bool GfInterval_IsEmpty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfInterval_GetSize")]
		public static extern double GfInterval_GetSize(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfInterval_Size")]
		public static extern double GfInterval_Size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfInterval_Contains__SWIG_0")]
		public static extern bool GfInterval_Contains__SWIG_0(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfInterval_In")]
		public static extern bool GfInterval_In(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfInterval_Contains__SWIG_1")]
		public static extern bool GfInterval_Contains__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfInterval_Intersects")]
		public static extern bool GfInterval_Intersects(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfInterval_GetFullInterval")]
		public static extern IntPtr GfInterval_GetFullInterval();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfInterval_Equals")]
		public static extern bool GfInterval_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfInterval_GetHashCode")]
		public static extern int GfInterval_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfInterval")]
		public static extern void delete_GfInterval(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfLine__SWIG_0")]
		public static extern IntPtr new_GfLine__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfLine__SWIG_1")]
		public static extern IntPtr new_GfLine__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfLine_Set")]
		public static extern double GfLine_Set(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfLine_GetPoint")]
		public static extern IntPtr GfLine_GetPoint(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfLine_GetDirection")]
		public static extern IntPtr GfLine_GetDirection(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfLine_FindClosestPoint__SWIG_0")]
		public static extern IntPtr GfLine_FindClosestPoint__SWIG_0(HandleRef jarg1, HandleRef jarg2, out double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfLine_FindClosestPoint__SWIG_1")]
		public static extern IntPtr GfLine_FindClosestPoint__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFindClosestPoints__SWIG_0")]
		public static extern bool GfFindClosestPoints__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, out double jarg5, out double jarg6);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfLine_Equals")]
		public static extern bool GfLine_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfLine_GetHashCode")]
		public static extern int GfLine_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfLine")]
		public static extern void delete_GfLine(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFindClosestPoints__SWIG_1")]
		public static extern bool GfFindClosestPoints__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, out double jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFindClosestPoints__SWIG_2")]
		public static extern bool GfFindClosestPoints__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFindClosestPoints__SWIG_3")]
		public static extern bool GfFindClosestPoints__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFindClosestPoints__SWIG_4")]
		public static extern bool GfFindClosestPoints__SWIG_4(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfLineSeg__SWIG_0")]
		public static extern IntPtr new_GfLineSeg__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfLineSeg__SWIG_1")]
		public static extern IntPtr new_GfLineSeg__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfLineSeg_GetPoint")]
		public static extern IntPtr GfLineSeg_GetPoint(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfLineSeg_GetDirection")]
		public static extern IntPtr GfLineSeg_GetDirection(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfLineSeg_GetLength")]
		public static extern double GfLineSeg_GetLength(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfLineSeg_FindClosestPoint__SWIG_0")]
		public static extern IntPtr GfLineSeg_FindClosestPoint__SWIG_0(HandleRef jarg1, HandleRef jarg2, out double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfLineSeg_FindClosestPoint__SWIG_1")]
		public static extern IntPtr GfLineSeg_FindClosestPoint__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFindClosestPoints__SWIG_5")]
		public static extern bool GfFindClosestPoints__SWIG_5(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, out double jarg5, out double jarg6);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFindClosestPoints__SWIG_6")]
		public static extern bool GfFindClosestPoints__SWIG_6(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, out double jarg5, out double jarg6);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfLineSeg_Equals")]
		public static extern bool GfLineSeg_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfLineSeg_GetHashCode")]
		public static extern int GfLineSeg_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfLineSeg")]
		public static extern void delete_GfLineSeg(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFindClosestPoints__SWIG_7")]
		public static extern bool GfFindClosestPoints__SWIG_7(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, out double jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFindClosestPoints__SWIG_8")]
		public static extern bool GfFindClosestPoints__SWIG_8(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFindClosestPoints__SWIG_9")]
		public static extern bool GfFindClosestPoints__SWIG_9(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFindClosestPoints__SWIG_10")]
		public static extern bool GfFindClosestPoints__SWIG_10(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFindClosestPoints__SWIG_11")]
		public static extern bool GfFindClosestPoints__SWIG_11(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, out double jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFindClosestPoints__SWIG_12")]
		public static extern bool GfFindClosestPoints__SWIG_12(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFindClosestPoints__SWIG_13")]
		public static extern bool GfFindClosestPoints__SWIG_13(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFindClosestPoints__SWIG_14")]
		public static extern bool GfFindClosestPoints__SWIG_14(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfIsClose__SWIG_0")]
		public static extern bool GfIsClose__SWIG_0(double jarg1, double jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRadiansToDegrees")]
		public static extern double GfRadiansToDegrees(double jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDegreesToRadians")]
		public static extern double GfDegreesToRadians(double jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSqrt__SWIG_0")]
		public static extern double GfSqrt__SWIG_0(double jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSqrt__SWIG_1")]
		public static extern float GfSqrt__SWIG_1(float jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfExp__SWIG_0")]
		public static extern double GfExp__SWIG_0(double jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfExp__SWIG_1")]
		public static extern float GfExp__SWIG_1(float jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfLog__SWIG_0")]
		public static extern double GfLog__SWIG_0(double jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfLog__SWIG_1")]
		public static extern float GfLog__SWIG_1(float jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFloor__SWIG_0")]
		public static extern double GfFloor__SWIG_0(double jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFloor__SWIG_1")]
		public static extern float GfFloor__SWIG_1(float jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCeil__SWIG_0")]
		public static extern double GfCeil__SWIG_0(double jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCeil__SWIG_1")]
		public static extern float GfCeil__SWIG_1(float jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfAbs__SWIG_0")]
		public static extern double GfAbs__SWIG_0(double jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfAbs__SWIG_1")]
		public static extern float GfAbs__SWIG_1(float jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRound__SWIG_0")]
		public static extern double GfRound__SWIG_0(double jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRound__SWIG_1")]
		public static extern float GfRound__SWIG_1(float jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfPow__SWIG_0")]
		public static extern double GfPow__SWIG_0(double jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfPow__SWIG_1")]
		public static extern float GfPow__SWIG_1(float jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSin__SWIG_0")]
		public static extern double GfSin__SWIG_0(double jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSin__SWIG_1")]
		public static extern float GfSin__SWIG_1(float jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCos__SWIG_0")]
		public static extern double GfCos__SWIG_0(double jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCos__SWIG_1")]
		public static extern float GfCos__SWIG_1(float jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSinCos__SWIG_0")]
		public static extern void GfSinCos__SWIG_0(double jarg1, out double jarg2, out double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSinCos__SWIG_1")]
		public static extern void GfSinCos__SWIG_1(float jarg1, out float jarg2, out float jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfClamp__SWIG_0")]
		public static extern double GfClamp__SWIG_0(double jarg1, double jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfClamp__SWIG_1")]
		public static extern float GfClamp__SWIG_1(float jarg1, float jarg2, float jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMod__SWIG_0")]
		public static extern double GfMod__SWIG_0(double jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMod__SWIG_1")]
		public static extern float GfMod__SWIG_1(float jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSqr__SWIG_1")]
		public static extern double GfSqr__SWIG_1(double jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSqr__SWIG_2")]
		public static extern double GfSqr__SWIG_2(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSqr__SWIG_3")]
		public static extern double GfSqr__SWIG_3(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSqr__SWIG_4")]
		public static extern double GfSqr__SWIG_4(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSqr__SWIG_5")]
		public static extern double GfSqr__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSqr__SWIG_6")]
		public static extern double GfSqr__SWIG_6(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSqr__SWIG_7")]
		public static extern double GfSqr__SWIG_7(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSqr__SWIG_8")]
		public static extern double GfSqr__SWIG_8(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSqr__SWIG_9")]
		public static extern double GfSqr__SWIG_9(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSqr__SWIG_10")]
		public static extern double GfSqr__SWIG_10(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSgn__SWIG_1")]
		public static extern double GfSgn__SWIG_1(double jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSgn__SWIG_2")]
		public static extern int GfSgn__SWIG_2(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfLerp__SWIG_1")]
		public static extern double GfLerp__SWIG_1(double jarg1, double jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfLerp__SWIG_2")]
		public static extern float GfLerp__SWIG_2(double jarg1, float jarg2, float jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfLerp__SWIG_3")]
		public static extern IntPtr GfLerp__SWIG_3(double jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfLerp__SWIG_4")]
		public static extern IntPtr GfLerp__SWIG_4(double jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfLerp__SWIG_5")]
		public static extern IntPtr GfLerp__SWIG_5(double jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfLerp__SWIG_6")]
		public static extern IntPtr GfLerp__SWIG_6(double jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfLerp__SWIG_7")]
		public static extern IntPtr GfLerp__SWIG_7(double jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfLerp__SWIG_8")]
		public static extern IntPtr GfLerp__SWIG_8(double jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfLerp__SWIG_9")]
		public static extern IntPtr GfLerp__SWIG_9(double jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfLerp__SWIG_10")]
		public static extern IntPtr GfLerp__SWIG_10(double jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMin__SWIG_4")]
		public static extern double GfMin__SWIG_4(double jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMin__SWIG_5")]
		public static extern double GfMin__SWIG_5(double jarg1, double jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMin__SWIG_6")]
		public static extern double GfMin__SWIG_6(double jarg1, double jarg2, double jarg3, double jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMin__SWIG_7")]
		public static extern double GfMin__SWIG_7(double jarg1, double jarg2, double jarg3, double jarg4, double jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMin__SWIG_8")]
		public static extern int GfMin__SWIG_8(int jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMin__SWIG_9")]
		public static extern int GfMin__SWIG_9(int jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMin__SWIG_10")]
		public static extern int GfMin__SWIG_10(int jarg1, int jarg2, int jarg3, int jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMin__SWIG_11")]
		public static extern int GfMin__SWIG_11(int jarg1, int jarg2, int jarg3, int jarg4, int jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMax__SWIG_4")]
		public static extern double GfMax__SWIG_4(double jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMax__SWIG_5")]
		public static extern double GfMax__SWIG_5(double jarg1, double jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMax__SWIG_6")]
		public static extern double GfMax__SWIG_6(double jarg1, double jarg2, double jarg3, double jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMax__SWIG_7")]
		public static extern double GfMax__SWIG_7(double jarg1, double jarg2, double jarg3, double jarg4, double jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMax__SWIG_8")]
		public static extern int GfMax__SWIG_8(int jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMax__SWIG_9")]
		public static extern int GfMax__SWIG_9(int jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMax__SWIG_10")]
		public static extern int GfMax__SWIG_10(int jarg1, int jarg2, int jarg3, int jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMax__SWIG_11")]
		public static extern int GfMax__SWIG_11(int jarg1, int jarg2, int jarg3, int jarg4, int jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix2d__SWIG_0")]
		public static extern IntPtr new_GfMatrix2d__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix2d__SWIG_1")]
		public static extern IntPtr new_GfMatrix2d__SWIG_1(double jarg1, double jarg2, double jarg3, double jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix2d__SWIG_2")]
		public static extern IntPtr new_GfMatrix2d__SWIG_2(double jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix2d__SWIG_3")]
		public static extern IntPtr new_GfMatrix2d__SWIG_3(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix2d__SWIG_4")]
		public static extern IntPtr new_GfMatrix2d__SWIG_4(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix2d__SWIG_5")]
		public static extern IntPtr new_GfMatrix2d__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix2d__SWIG_6")]
		public static extern IntPtr new_GfMatrix2d__SWIG_6(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix2d__SWIG_7")]
		public static extern IntPtr new_GfMatrix2d__SWIG_7(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2d_SetRow")]
		public static extern void GfMatrix2d_SetRow(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2d_SetColumn")]
		public static extern void GfMatrix2d_SetColumn(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2d_GetRow")]
		public static extern IntPtr GfMatrix2d_GetRow(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2d_GetColumn")]
		public static extern IntPtr GfMatrix2d_GetColumn(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2d_Set")]
		public static extern IntPtr GfMatrix2d_Set(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2d_SetIdentity")]
		public static extern IntPtr GfMatrix2d_SetIdentity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2d_SetZero")]
		public static extern IntPtr GfMatrix2d_SetZero(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2d_SetDiagonal__SWIG_0")]
		public static extern IntPtr GfMatrix2d_SetDiagonal__SWIG_0(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2d_SetDiagonal__SWIG_1")]
		public static extern IntPtr GfMatrix2d_SetDiagonal__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2d_GetTranspose")]
		public static extern IntPtr GfMatrix2d_GetTranspose(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2d_GetInverse__SWIG_0")]
		public static extern IntPtr GfMatrix2d_GetInverse__SWIG_0(HandleRef jarg1, out double jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2d_GetInverse__SWIG_1")]
		public static extern IntPtr GfMatrix2d_GetInverse__SWIG_1(HandleRef jarg1, out double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2d_GetInverse__SWIG_2")]
		public static extern IntPtr GfMatrix2d_GetInverse__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2d_GetDeterminant")]
		public static extern double GfMatrix2d_GetDeterminant(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2d_Equals")]
		public static extern bool GfMatrix2d_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2d_GetHashCode")]
		public static extern int GfMatrix2d_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2d_ToString")]
		public static extern string GfMatrix2d_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2d_CopyToArray")]
		public static extern void GfMatrix2d_CopyToArray(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] double[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2d_CopyFromArray")]
		public static extern void GfMatrix2d_CopyFromArray(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] double[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfMatrix2d")]
		public static extern void delete_GfMatrix2d(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfIsClose__SWIG_1")]
		public static extern bool GfIsClose__SWIG_1(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix2f__SWIG_0")]
		public static extern IntPtr new_GfMatrix2f__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix2f__SWIG_1")]
		public static extern IntPtr new_GfMatrix2f__SWIG_1(float jarg1, float jarg2, float jarg3, float jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix2f__SWIG_2")]
		public static extern IntPtr new_GfMatrix2f__SWIG_2(float jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix2f__SWIG_3")]
		public static extern IntPtr new_GfMatrix2f__SWIG_3(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix2f__SWIG_4")]
		public static extern IntPtr new_GfMatrix2f__SWIG_4(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix2f__SWIG_5")]
		public static extern IntPtr new_GfMatrix2f__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix2f__SWIG_6")]
		public static extern IntPtr new_GfMatrix2f__SWIG_6(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix2f__SWIG_7")]
		public static extern IntPtr new_GfMatrix2f__SWIG_7(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2f_SetRow")]
		public static extern void GfMatrix2f_SetRow(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2f_SetColumn")]
		public static extern void GfMatrix2f_SetColumn(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2f_GetRow")]
		public static extern IntPtr GfMatrix2f_GetRow(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2f_GetColumn")]
		public static extern IntPtr GfMatrix2f_GetColumn(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2f_Set")]
		public static extern IntPtr GfMatrix2f_Set(HandleRef jarg1, float jarg2, float jarg3, float jarg4, float jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2f_SetIdentity")]
		public static extern IntPtr GfMatrix2f_SetIdentity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2f_SetZero")]
		public static extern IntPtr GfMatrix2f_SetZero(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2f_SetDiagonal__SWIG_0")]
		public static extern IntPtr GfMatrix2f_SetDiagonal__SWIG_0(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2f_SetDiagonal__SWIG_1")]
		public static extern IntPtr GfMatrix2f_SetDiagonal__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2f_GetTranspose")]
		public static extern IntPtr GfMatrix2f_GetTranspose(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2f_GetInverse__SWIG_0")]
		public static extern IntPtr GfMatrix2f_GetInverse__SWIG_0(HandleRef jarg1, out double jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2f_GetInverse__SWIG_1")]
		public static extern IntPtr GfMatrix2f_GetInverse__SWIG_1(HandleRef jarg1, out double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2f_GetInverse__SWIG_2")]
		public static extern IntPtr GfMatrix2f_GetInverse__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2f_GetDeterminant")]
		public static extern double GfMatrix2f_GetDeterminant(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2f_Equals")]
		public static extern bool GfMatrix2f_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2f_GetHashCode")]
		public static extern int GfMatrix2f_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2f_ToString")]
		public static extern string GfMatrix2f_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2f_CopyToArray")]
		public static extern void GfMatrix2f_CopyToArray(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] float[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix2f_CopyFromArray")]
		public static extern void GfMatrix2f_CopyFromArray(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] float[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfMatrix2f")]
		public static extern void delete_GfMatrix2f(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfIsClose__SWIG_2")]
		public static extern bool GfIsClose__SWIG_2(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix3d__SWIG_0")]
		public static extern IntPtr new_GfMatrix3d__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix3d__SWIG_1")]
		public static extern IntPtr new_GfMatrix3d__SWIG_1(double jarg1, double jarg2, double jarg3, double jarg4, double jarg5, double jarg6, double jarg7, double jarg8, double jarg9);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix3d__SWIG_2")]
		public static extern IntPtr new_GfMatrix3d__SWIG_2(double jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix3d__SWIG_3")]
		public static extern IntPtr new_GfMatrix3d__SWIG_3(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix3d__SWIG_4")]
		public static extern IntPtr new_GfMatrix3d__SWIG_4(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix3d__SWIG_5")]
		public static extern IntPtr new_GfMatrix3d__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix3d__SWIG_6")]
		public static extern IntPtr new_GfMatrix3d__SWIG_6(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix3d__SWIG_7")]
		public static extern IntPtr new_GfMatrix3d__SWIG_7(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix3d__SWIG_8")]
		public static extern IntPtr new_GfMatrix3d__SWIG_8(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix3d__SWIG_9")]
		public static extern IntPtr new_GfMatrix3d__SWIG_9(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_SetRow")]
		public static extern void GfMatrix3d_SetRow(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_SetColumn")]
		public static extern void GfMatrix3d_SetColumn(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_GetRow")]
		public static extern IntPtr GfMatrix3d_GetRow(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_GetColumn")]
		public static extern IntPtr GfMatrix3d_GetColumn(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_Set")]
		public static extern IntPtr GfMatrix3d_Set(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5, double jarg6, double jarg7, double jarg8, double jarg9, double jarg10);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_SetIdentity")]
		public static extern IntPtr GfMatrix3d_SetIdentity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_SetZero")]
		public static extern IntPtr GfMatrix3d_SetZero(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_SetDiagonal__SWIG_0")]
		public static extern IntPtr GfMatrix3d_SetDiagonal__SWIG_0(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_SetDiagonal__SWIG_1")]
		public static extern IntPtr GfMatrix3d_SetDiagonal__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_GetTranspose")]
		public static extern IntPtr GfMatrix3d_GetTranspose(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_GetInverse__SWIG_0")]
		public static extern IntPtr GfMatrix3d_GetInverse__SWIG_0(HandleRef jarg1, out double jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_GetInverse__SWIG_1")]
		public static extern IntPtr GfMatrix3d_GetInverse__SWIG_1(HandleRef jarg1, out double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_GetInverse__SWIG_2")]
		public static extern IntPtr GfMatrix3d_GetInverse__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_GetDeterminant")]
		public static extern double GfMatrix3d_GetDeterminant(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_Orthonormalize__SWIG_0")]
		public static extern bool GfMatrix3d_Orthonormalize__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_Orthonormalize__SWIG_1")]
		public static extern bool GfMatrix3d_Orthonormalize__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_GetOrthonormalized__SWIG_0")]
		public static extern IntPtr GfMatrix3d_GetOrthonormalized__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_GetOrthonormalized__SWIG_1")]
		public static extern IntPtr GfMatrix3d_GetOrthonormalized__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_GetHandedness")]
		public static extern double GfMatrix3d_GetHandedness(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_IsRightHanded")]
		public static extern bool GfMatrix3d_IsRightHanded(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_IsLeftHanded")]
		public static extern bool GfMatrix3d_IsLeftHanded(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_SetScale__SWIG_0")]
		public static extern IntPtr GfMatrix3d_SetScale__SWIG_0(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_SetRotate__SWIG_0")]
		public static extern IntPtr GfMatrix3d_SetRotate__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_SetRotate__SWIG_1")]
		public static extern IntPtr GfMatrix3d_SetRotate__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_SetScale__SWIG_1")]
		public static extern IntPtr GfMatrix3d_SetScale__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_ExtractRotation")]
		public static extern IntPtr GfMatrix3d_ExtractRotation(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_DecomposeRotation")]
		public static extern IntPtr GfMatrix3d_DecomposeRotation(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_ExtractRotationQuaternion")]
		public static extern IntPtr GfMatrix3d_ExtractRotationQuaternion(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_Equals")]
		public static extern bool GfMatrix3d_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_GetHashCode")]
		public static extern int GfMatrix3d_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_ToString")]
		public static extern string GfMatrix3d_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_CopyToArray")]
		public static extern void GfMatrix3d_CopyToArray(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] double[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3d_CopyFromArray")]
		public static extern void GfMatrix3d_CopyFromArray(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] double[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfMatrix3d")]
		public static extern void delete_GfMatrix3d(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfIsClose__SWIG_3")]
		public static extern bool GfIsClose__SWIG_3(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix3f__SWIG_0")]
		public static extern IntPtr new_GfMatrix3f__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix3f__SWIG_1")]
		public static extern IntPtr new_GfMatrix3f__SWIG_1(float jarg1, float jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7, float jarg8, float jarg9);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix3f__SWIG_2")]
		public static extern IntPtr new_GfMatrix3f__SWIG_2(float jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix3f__SWIG_3")]
		public static extern IntPtr new_GfMatrix3f__SWIG_3(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix3f__SWIG_4")]
		public static extern IntPtr new_GfMatrix3f__SWIG_4(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix3f__SWIG_5")]
		public static extern IntPtr new_GfMatrix3f__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix3f__SWIG_6")]
		public static extern IntPtr new_GfMatrix3f__SWIG_6(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix3f__SWIG_7")]
		public static extern IntPtr new_GfMatrix3f__SWIG_7(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix3f__SWIG_8")]
		public static extern IntPtr new_GfMatrix3f__SWIG_8(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix3f__SWIG_9")]
		public static extern IntPtr new_GfMatrix3f__SWIG_9(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_SetRow")]
		public static extern void GfMatrix3f_SetRow(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_SetColumn")]
		public static extern void GfMatrix3f_SetColumn(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_GetRow")]
		public static extern IntPtr GfMatrix3f_GetRow(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_GetColumn")]
		public static extern IntPtr GfMatrix3f_GetColumn(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_Set")]
		public static extern IntPtr GfMatrix3f_Set(HandleRef jarg1, float jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7, float jarg8, float jarg9, float jarg10);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_SetIdentity")]
		public static extern IntPtr GfMatrix3f_SetIdentity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_SetZero")]
		public static extern IntPtr GfMatrix3f_SetZero(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_SetDiagonal__SWIG_0")]
		public static extern IntPtr GfMatrix3f_SetDiagonal__SWIG_0(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_SetDiagonal__SWIG_1")]
		public static extern IntPtr GfMatrix3f_SetDiagonal__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_GetTranspose")]
		public static extern IntPtr GfMatrix3f_GetTranspose(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_GetInverse__SWIG_0")]
		public static extern IntPtr GfMatrix3f_GetInverse__SWIG_0(HandleRef jarg1, out double jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_GetInverse__SWIG_1")]
		public static extern IntPtr GfMatrix3f_GetInverse__SWIG_1(HandleRef jarg1, out double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_GetInverse__SWIG_2")]
		public static extern IntPtr GfMatrix3f_GetInverse__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_GetDeterminant")]
		public static extern double GfMatrix3f_GetDeterminant(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_Orthonormalize__SWIG_0")]
		public static extern bool GfMatrix3f_Orthonormalize__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_Orthonormalize__SWIG_1")]
		public static extern bool GfMatrix3f_Orthonormalize__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_GetOrthonormalized__SWIG_0")]
		public static extern IntPtr GfMatrix3f_GetOrthonormalized__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_GetOrthonormalized__SWIG_1")]
		public static extern IntPtr GfMatrix3f_GetOrthonormalized__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_GetHandedness")]
		public static extern double GfMatrix3f_GetHandedness(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_IsRightHanded")]
		public static extern bool GfMatrix3f_IsRightHanded(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_IsLeftHanded")]
		public static extern bool GfMatrix3f_IsLeftHanded(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_SetScale__SWIG_0")]
		public static extern IntPtr GfMatrix3f_SetScale__SWIG_0(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_SetRotate__SWIG_0")]
		public static extern IntPtr GfMatrix3f_SetRotate__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_SetRotate__SWIG_1")]
		public static extern IntPtr GfMatrix3f_SetRotate__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_SetScale__SWIG_1")]
		public static extern IntPtr GfMatrix3f_SetScale__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_ExtractRotation")]
		public static extern IntPtr GfMatrix3f_ExtractRotation(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_DecomposeRotation")]
		public static extern IntPtr GfMatrix3f_DecomposeRotation(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_ExtractRotationQuaternion")]
		public static extern IntPtr GfMatrix3f_ExtractRotationQuaternion(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_Equals")]
		public static extern bool GfMatrix3f_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_GetHashCode")]
		public static extern int GfMatrix3f_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_ToString")]
		public static extern string GfMatrix3f_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_CopyToArray")]
		public static extern void GfMatrix3f_CopyToArray(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] float[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix3f_CopyFromArray")]
		public static extern void GfMatrix3f_CopyFromArray(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] float[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfMatrix3f")]
		public static extern void delete_GfMatrix3f(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfIsClose__SWIG_4")]
		public static extern bool GfIsClose__SWIG_4(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix4d__SWIG_0")]
		public static extern IntPtr new_GfMatrix4d__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix4d__SWIG_1")]
		public static extern IntPtr new_GfMatrix4d__SWIG_1(double jarg1, double jarg2, double jarg3, double jarg4, double jarg5, double jarg6, double jarg7, double jarg8, double jarg9, double jarg10, double jarg11, double jarg12, double jarg13, double jarg14, double jarg15, double jarg16);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix4d__SWIG_2")]
		public static extern IntPtr new_GfMatrix4d__SWIG_2(double jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix4d__SWIG_3")]
		public static extern IntPtr new_GfMatrix4d__SWIG_3(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix4d__SWIG_4")]
		public static extern IntPtr new_GfMatrix4d__SWIG_4(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix4d__SWIG_5")]
		public static extern IntPtr new_GfMatrix4d__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix4d__SWIG_6")]
		public static extern IntPtr new_GfMatrix4d__SWIG_6(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix4d__SWIG_7")]
		public static extern IntPtr new_GfMatrix4d__SWIG_7(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix4d__SWIG_8")]
		public static extern IntPtr new_GfMatrix4d__SWIG_8(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix4d__SWIG_9")]
		public static extern IntPtr new_GfMatrix4d__SWIG_9(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix4d__SWIG_10")]
		public static extern IntPtr new_GfMatrix4d__SWIG_10(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_SetRow")]
		public static extern void GfMatrix4d_SetRow(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_SetColumn")]
		public static extern void GfMatrix4d_SetColumn(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_GetRow")]
		public static extern IntPtr GfMatrix4d_GetRow(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_GetColumn")]
		public static extern IntPtr GfMatrix4d_GetColumn(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_Set")]
		public static extern IntPtr GfMatrix4d_Set(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5, double jarg6, double jarg7, double jarg8, double jarg9, double jarg10, double jarg11, double jarg12, double jarg13, double jarg14, double jarg15, double jarg16, double jarg17);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_SetIdentity")]
		public static extern IntPtr GfMatrix4d_SetIdentity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_SetZero")]
		public static extern IntPtr GfMatrix4d_SetZero(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_SetDiagonal__SWIG_0")]
		public static extern IntPtr GfMatrix4d_SetDiagonal__SWIG_0(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_SetDiagonal__SWIG_1")]
		public static extern IntPtr GfMatrix4d_SetDiagonal__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_GetTranspose")]
		public static extern IntPtr GfMatrix4d_GetTranspose(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_GetInverse__SWIG_0")]
		public static extern IntPtr GfMatrix4d_GetInverse__SWIG_0(HandleRef jarg1, out double jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_GetInverse__SWIG_1")]
		public static extern IntPtr GfMatrix4d_GetInverse__SWIG_1(HandleRef jarg1, out double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_GetInverse__SWIG_2")]
		public static extern IntPtr GfMatrix4d_GetInverse__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_GetDeterminant")]
		public static extern double GfMatrix4d_GetDeterminant(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_SetRow3")]
		public static extern void GfMatrix4d_SetRow3(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_GetRow3")]
		public static extern IntPtr GfMatrix4d_GetRow3(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_GetDeterminant3")]
		public static extern double GfMatrix4d_GetDeterminant3(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_HasOrthogonalRows3")]
		public static extern bool GfMatrix4d_HasOrthogonalRows3(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_Orthonormalize__SWIG_0")]
		public static extern bool GfMatrix4d_Orthonormalize__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_Orthonormalize__SWIG_1")]
		public static extern bool GfMatrix4d_Orthonormalize__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_GetOrthonormalized__SWIG_0")]
		public static extern IntPtr GfMatrix4d_GetOrthonormalized__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_GetOrthonormalized__SWIG_1")]
		public static extern IntPtr GfMatrix4d_GetOrthonormalized__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_GetHandedness")]
		public static extern double GfMatrix4d_GetHandedness(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_IsRightHanded")]
		public static extern bool GfMatrix4d_IsRightHanded(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_IsLeftHanded")]
		public static extern bool GfMatrix4d_IsLeftHanded(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_SetScale__SWIG_0")]
		public static extern IntPtr GfMatrix4d_SetScale__SWIG_0(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_RemoveScaleShear")]
		public static extern IntPtr GfMatrix4d_RemoveScaleShear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_SetRotate__SWIG_0")]
		public static extern IntPtr GfMatrix4d_SetRotate__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_SetRotateOnly__SWIG_0")]
		public static extern IntPtr GfMatrix4d_SetRotateOnly__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_SetRotate__SWIG_1")]
		public static extern IntPtr GfMatrix4d_SetRotate__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_SetRotateOnly__SWIG_1")]
		public static extern IntPtr GfMatrix4d_SetRotateOnly__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_SetRotate__SWIG_2")]
		public static extern IntPtr GfMatrix4d_SetRotate__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_SetRotateOnly__SWIG_2")]
		public static extern IntPtr GfMatrix4d_SetRotateOnly__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_SetScale__SWIG_1")]
		public static extern IntPtr GfMatrix4d_SetScale__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_SetTranslate")]
		public static extern IntPtr GfMatrix4d_SetTranslate(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_SetTranslateOnly")]
		public static extern IntPtr GfMatrix4d_SetTranslateOnly(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_SetTransform__SWIG_0")]
		public static extern IntPtr GfMatrix4d_SetTransform__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_SetTransform__SWIG_1")]
		public static extern IntPtr GfMatrix4d_SetTransform__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_SetLookAt__SWIG_0")]
		public static extern IntPtr GfMatrix4d_SetLookAt__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_SetLookAt__SWIG_1")]
		public static extern IntPtr GfMatrix4d_SetLookAt__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_Factor__SWIG_0")]
		public static extern bool GfMatrix4d_Factor__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, HandleRef jarg6, double jarg7);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_Factor__SWIG_1")]
		public static extern bool GfMatrix4d_Factor__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, HandleRef jarg6);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_ExtractTranslation")]
		public static extern IntPtr GfMatrix4d_ExtractTranslation(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_ExtractRotation")]
		public static extern IntPtr GfMatrix4d_ExtractRotation(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_ExtractRotationQuat")]
		public static extern IntPtr GfMatrix4d_ExtractRotationQuat(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_DecomposeRotation")]
		public static extern IntPtr GfMatrix4d_DecomposeRotation(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_ExtractRotationMatrix")]
		public static extern IntPtr GfMatrix4d_ExtractRotationMatrix(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_Transform__SWIG_0")]
		public static extern IntPtr GfMatrix4d_Transform__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_Transform__SWIG_1")]
		public static extern IntPtr GfMatrix4d_Transform__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_TransformDir__SWIG_0")]
		public static extern IntPtr GfMatrix4d_TransformDir__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_TransformDir__SWIG_1")]
		public static extern IntPtr GfMatrix4d_TransformDir__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_TransformAffine__SWIG_0")]
		public static extern IntPtr GfMatrix4d_TransformAffine__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_TransformAffine__SWIG_1")]
		public static extern IntPtr GfMatrix4d_TransformAffine__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_Equals")]
		public static extern bool GfMatrix4d_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_GetHashCode")]
		public static extern int GfMatrix4d_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_ToString")]
		public static extern string GfMatrix4d_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_CopyToArray")]
		public static extern void GfMatrix4d_CopyToArray(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] double[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4d_CopyFromArray")]
		public static extern void GfMatrix4d_CopyFromArray(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] double[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfMatrix4d")]
		public static extern void delete_GfMatrix4d(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfIsClose__SWIG_5")]
		public static extern bool GfIsClose__SWIG_5(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix4f__SWIG_0")]
		public static extern IntPtr new_GfMatrix4f__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix4f__SWIG_1")]
		public static extern IntPtr new_GfMatrix4f__SWIG_1(float jarg1, float jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7, float jarg8, float jarg9, float jarg10, float jarg11, float jarg12, float jarg13, float jarg14, float jarg15, float jarg16);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix4f__SWIG_2")]
		public static extern IntPtr new_GfMatrix4f__SWIG_2(float jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix4f__SWIG_3")]
		public static extern IntPtr new_GfMatrix4f__SWIG_3(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix4f__SWIG_4")]
		public static extern IntPtr new_GfMatrix4f__SWIG_4(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix4f__SWIG_5")]
		public static extern IntPtr new_GfMatrix4f__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix4f__SWIG_6")]
		public static extern IntPtr new_GfMatrix4f__SWIG_6(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix4f__SWIG_7")]
		public static extern IntPtr new_GfMatrix4f__SWIG_7(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix4f__SWIG_8")]
		public static extern IntPtr new_GfMatrix4f__SWIG_8(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix4f__SWIG_9")]
		public static extern IntPtr new_GfMatrix4f__SWIG_9(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfMatrix4f__SWIG_10")]
		public static extern IntPtr new_GfMatrix4f__SWIG_10(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_SetRow")]
		public static extern void GfMatrix4f_SetRow(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_SetColumn")]
		public static extern void GfMatrix4f_SetColumn(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_GetRow")]
		public static extern IntPtr GfMatrix4f_GetRow(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_GetColumn")]
		public static extern IntPtr GfMatrix4f_GetColumn(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_Set")]
		public static extern IntPtr GfMatrix4f_Set(HandleRef jarg1, float jarg2, float jarg3, float jarg4, float jarg5, float jarg6, float jarg7, float jarg8, float jarg9, float jarg10, float jarg11, float jarg12, float jarg13, float jarg14, float jarg15, float jarg16, float jarg17);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_SetIdentity")]
		public static extern IntPtr GfMatrix4f_SetIdentity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_SetZero")]
		public static extern IntPtr GfMatrix4f_SetZero(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_SetDiagonal__SWIG_0")]
		public static extern IntPtr GfMatrix4f_SetDiagonal__SWIG_0(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_SetDiagonal__SWIG_1")]
		public static extern IntPtr GfMatrix4f_SetDiagonal__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_GetTranspose")]
		public static extern IntPtr GfMatrix4f_GetTranspose(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_GetInverse__SWIG_0")]
		public static extern IntPtr GfMatrix4f_GetInverse__SWIG_0(HandleRef jarg1, out double jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_GetInverse__SWIG_1")]
		public static extern IntPtr GfMatrix4f_GetInverse__SWIG_1(HandleRef jarg1, out double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_GetInverse__SWIG_2")]
		public static extern IntPtr GfMatrix4f_GetInverse__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_GetDeterminant")]
		public static extern double GfMatrix4f_GetDeterminant(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_SetRow3")]
		public static extern void GfMatrix4f_SetRow3(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_GetRow3")]
		public static extern IntPtr GfMatrix4f_GetRow3(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_GetDeterminant3")]
		public static extern double GfMatrix4f_GetDeterminant3(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_HasOrthogonalRows3")]
		public static extern bool GfMatrix4f_HasOrthogonalRows3(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_Orthonormalize__SWIG_0")]
		public static extern bool GfMatrix4f_Orthonormalize__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_Orthonormalize__SWIG_1")]
		public static extern bool GfMatrix4f_Orthonormalize__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_GetOrthonormalized__SWIG_0")]
		public static extern IntPtr GfMatrix4f_GetOrthonormalized__SWIG_0(HandleRef jarg1, bool jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_GetOrthonormalized__SWIG_1")]
		public static extern IntPtr GfMatrix4f_GetOrthonormalized__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_GetHandedness")]
		public static extern double GfMatrix4f_GetHandedness(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_IsRightHanded")]
		public static extern bool GfMatrix4f_IsRightHanded(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_IsLeftHanded")]
		public static extern bool GfMatrix4f_IsLeftHanded(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_SetScale__SWIG_0")]
		public static extern IntPtr GfMatrix4f_SetScale__SWIG_0(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_RemoveScaleShear")]
		public static extern IntPtr GfMatrix4f_RemoveScaleShear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_SetRotate__SWIG_0")]
		public static extern IntPtr GfMatrix4f_SetRotate__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_SetRotateOnly__SWIG_0")]
		public static extern IntPtr GfMatrix4f_SetRotateOnly__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_SetRotate__SWIG_1")]
		public static extern IntPtr GfMatrix4f_SetRotate__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_SetRotateOnly__SWIG_1")]
		public static extern IntPtr GfMatrix4f_SetRotateOnly__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_SetRotate__SWIG_2")]
		public static extern IntPtr GfMatrix4f_SetRotate__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_SetRotateOnly__SWIG_2")]
		public static extern IntPtr GfMatrix4f_SetRotateOnly__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_SetScale__SWIG_1")]
		public static extern IntPtr GfMatrix4f_SetScale__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_SetTranslate")]
		public static extern IntPtr GfMatrix4f_SetTranslate(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_SetTranslateOnly")]
		public static extern IntPtr GfMatrix4f_SetTranslateOnly(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_SetTransform__SWIG_0")]
		public static extern IntPtr GfMatrix4f_SetTransform__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_SetTransform__SWIG_1")]
		public static extern IntPtr GfMatrix4f_SetTransform__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_SetLookAt__SWIG_0")]
		public static extern IntPtr GfMatrix4f_SetLookAt__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_SetLookAt__SWIG_1")]
		public static extern IntPtr GfMatrix4f_SetLookAt__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_Factor__SWIG_0")]
		public static extern bool GfMatrix4f_Factor__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, HandleRef jarg6, float jarg7);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_Factor__SWIG_1")]
		public static extern bool GfMatrix4f_Factor__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, HandleRef jarg6);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_ExtractTranslation")]
		public static extern IntPtr GfMatrix4f_ExtractTranslation(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_ExtractRotation")]
		public static extern IntPtr GfMatrix4f_ExtractRotation(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_ExtractRotationQuat")]
		public static extern IntPtr GfMatrix4f_ExtractRotationQuat(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_DecomposeRotation")]
		public static extern IntPtr GfMatrix4f_DecomposeRotation(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_ExtractRotationMatrix")]
		public static extern IntPtr GfMatrix4f_ExtractRotationMatrix(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_Transform__SWIG_0")]
		public static extern IntPtr GfMatrix4f_Transform__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_Transform__SWIG_1")]
		public static extern IntPtr GfMatrix4f_Transform__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_TransformDir__SWIG_0")]
		public static extern IntPtr GfMatrix4f_TransformDir__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_TransformDir__SWIG_1")]
		public static extern IntPtr GfMatrix4f_TransformDir__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_TransformAffine__SWIG_0")]
		public static extern IntPtr GfMatrix4f_TransformAffine__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_TransformAffine__SWIG_1")]
		public static extern IntPtr GfMatrix4f_TransformAffine__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_Equals")]
		public static extern bool GfMatrix4f_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_GetHashCode")]
		public static extern int GfMatrix4f_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_ToString")]
		public static extern string GfMatrix4f_ToString(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_CopyToArray")]
		public static extern void GfMatrix4f_CopyToArray(HandleRef jarg1, [Out][MarshalAs(UnmanagedType.LPArray)] float[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfMatrix4f_CopyFromArray")]
		public static extern void GfMatrix4f_CopyFromArray(HandleRef jarg1, [In][MarshalAs(UnmanagedType.LPArray)] float[] jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfMatrix4f")]
		public static extern void delete_GfMatrix4f(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfIsClose__SWIG_6")]
		public static extern bool GfIsClose__SWIG_6(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfPlane__SWIG_0")]
		public static extern IntPtr new_GfPlane__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfPlane__SWIG_1")]
		public static extern IntPtr new_GfPlane__SWIG_1(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfPlane__SWIG_2")]
		public static extern IntPtr new_GfPlane__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfPlane__SWIG_3")]
		public static extern IntPtr new_GfPlane__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfPlane__SWIG_4")]
		public static extern IntPtr new_GfPlane__SWIG_4(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfPlane_Set__SWIG_0")]
		public static extern void GfPlane_Set__SWIG_0(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfPlane_Set__SWIG_1")]
		public static extern void GfPlane_Set__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfPlane_Set__SWIG_2")]
		public static extern void GfPlane_Set__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfPlane_Set__SWIG_3")]
		public static extern void GfPlane_Set__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfPlane_GetNormal")]
		public static extern IntPtr GfPlane_GetNormal(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfPlane_GetDistanceFromOrigin")]
		public static extern double GfPlane_GetDistanceFromOrigin(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfPlane_GetEquation")]
		public static extern IntPtr GfPlane_GetEquation(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfPlane_GetDistance")]
		public static extern double GfPlane_GetDistance(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfPlane_Project")]
		public static extern IntPtr GfPlane_Project(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfPlane_Transform")]
		public static extern IntPtr GfPlane_Transform(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfPlane_Reorient")]
		public static extern void GfPlane_Reorient(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfPlane_IntersectsPositiveHalfSpace__SWIG_0")]
		public static extern bool GfPlane_IntersectsPositiveHalfSpace__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfPlane_IntersectsPositiveHalfSpace__SWIG_1")]
		public static extern bool GfPlane_IntersectsPositiveHalfSpace__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfPlane_Equals")]
		public static extern bool GfPlane_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfPlane_GetHashCode")]
		public static extern int GfPlane_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfPlane")]
		public static extern void delete_GfPlane(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFitPlaneToPoints")]
		public static extern bool GfFitPlaneToPoints(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDot__SWIG_3")]
		public static extern double GfDot__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfQuatd__SWIG_0")]
		public static extern IntPtr new_GfQuatd__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfQuatd__SWIG_1")]
		public static extern IntPtr new_GfQuatd__SWIG_1(double jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfQuatd__SWIG_2")]
		public static extern IntPtr new_GfQuatd__SWIG_2(double jarg1, double jarg2, double jarg3, double jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfQuatd__SWIG_3")]
		public static extern IntPtr new_GfQuatd__SWIG_3(double jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfQuatd__SWIG_4")]
		public static extern IntPtr new_GfQuatd__SWIG_4(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfQuatd__SWIG_5")]
		public static extern IntPtr new_GfQuatd__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatd_GetZero")]
		public static extern IntPtr GfQuatd_GetZero();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatd_GetIdentity")]
		public static extern IntPtr GfQuatd_GetIdentity();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatd_GetReal")]
		public static extern double GfQuatd_GetReal(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatd_SetReal")]
		public static extern void GfQuatd_SetReal(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatd_GetImaginary")]
		public static extern IntPtr GfQuatd_GetImaginary(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatd_SetImaginary__SWIG_0")]
		public static extern void GfQuatd_SetImaginary__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatd_SetImaginary__SWIG_1")]
		public static extern void GfQuatd_SetImaginary__SWIG_1(HandleRef jarg1, double jarg2, double jarg3, double jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatd_GetLength")]
		public static extern double GfQuatd_GetLength(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatd_GetNormalized__SWIG_0")]
		public static extern IntPtr GfQuatd_GetNormalized__SWIG_0(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatd_GetNormalized__SWIG_1")]
		public static extern IntPtr GfQuatd_GetNormalized__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatd_Normalize__SWIG_0")]
		public static extern double GfQuatd_Normalize__SWIG_0(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatd_Normalize__SWIG_1")]
		public static extern double GfQuatd_Normalize__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatd_GetConjugate")]
		public static extern IntPtr GfQuatd_GetConjugate(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatd_GetInverse")]
		public static extern IntPtr GfQuatd_GetInverse(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatd_Transform")]
		public static extern IntPtr GfQuatd_Transform(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatd_Equals")]
		public static extern bool GfQuatd_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatd_GetHashCode")]
		public static extern int GfQuatd_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfQuatd")]
		public static extern void delete_GfQuatd(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSlerp__SWIG_0")]
		public static extern IntPtr GfSlerp__SWIG_0(double jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSlerp__SWIG_1")]
		public static extern IntPtr GfSlerp__SWIG_1(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfQuaternion__SWIG_0")]
		public static extern IntPtr new_GfQuaternion__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfQuaternion__SWIG_1")]
		public static extern IntPtr new_GfQuaternion__SWIG_1(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfQuaternion__SWIG_2")]
		public static extern IntPtr new_GfQuaternion__SWIG_2(double jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuaternion_SetReal")]
		public static extern void GfQuaternion_SetReal(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuaternion_SetImaginary")]
		public static extern void GfQuaternion_SetImaginary(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuaternion_GetReal")]
		public static extern double GfQuaternion_GetReal(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuaternion_GetImaginary")]
		public static extern IntPtr GfQuaternion_GetImaginary(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuaternion_GetZero")]
		public static extern IntPtr GfQuaternion_GetZero();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuaternion_GetIdentity")]
		public static extern IntPtr GfQuaternion_GetIdentity();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuaternion_GetLength")]
		public static extern double GfQuaternion_GetLength(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuaternion_GetNormalized__SWIG_0")]
		public static extern IntPtr GfQuaternion_GetNormalized__SWIG_0(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuaternion_GetNormalized__SWIG_1")]
		public static extern IntPtr GfQuaternion_GetNormalized__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuaternion_Normalize__SWIG_0")]
		public static extern double GfQuaternion_Normalize__SWIG_0(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuaternion_Normalize__SWIG_1")]
		public static extern double GfQuaternion_Normalize__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuaternion_GetInverse")]
		public static extern IntPtr GfQuaternion_GetInverse(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSlerp__SWIG_2")]
		public static extern IntPtr GfSlerp__SWIG_2(double jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSlerp__SWIG_3")]
		public static extern IntPtr GfSlerp__SWIG_3(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuaternion_Equals")]
		public static extern bool GfQuaternion_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuaternion_GetHashCode")]
		public static extern int GfQuaternion_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfQuaternion")]
		public static extern void delete_GfQuaternion(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDot__SWIG_4")]
		public static extern double GfDot__SWIG_4(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDot__SWIG_5")]
		public static extern float GfDot__SWIG_5(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfQuatf__SWIG_0")]
		public static extern IntPtr new_GfQuatf__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfQuatf__SWIG_1")]
		public static extern IntPtr new_GfQuatf__SWIG_1(float jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfQuatf__SWIG_2")]
		public static extern IntPtr new_GfQuatf__SWIG_2(float jarg1, float jarg2, float jarg3, float jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfQuatf__SWIG_3")]
		public static extern IntPtr new_GfQuatf__SWIG_3(float jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfQuatf__SWIG_4")]
		public static extern IntPtr new_GfQuatf__SWIG_4(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfQuatf__SWIG_5")]
		public static extern IntPtr new_GfQuatf__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatf_GetZero")]
		public static extern IntPtr GfQuatf_GetZero();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatf_GetIdentity")]
		public static extern IntPtr GfQuatf_GetIdentity();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatf_GetReal")]
		public static extern float GfQuatf_GetReal(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatf_SetReal")]
		public static extern void GfQuatf_SetReal(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatf_GetImaginary")]
		public static extern IntPtr GfQuatf_GetImaginary(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatf_SetImaginary__SWIG_0")]
		public static extern void GfQuatf_SetImaginary__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatf_SetImaginary__SWIG_1")]
		public static extern void GfQuatf_SetImaginary__SWIG_1(HandleRef jarg1, float jarg2, float jarg3, float jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatf_GetLength")]
		public static extern float GfQuatf_GetLength(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatf_GetNormalized__SWIG_0")]
		public static extern IntPtr GfQuatf_GetNormalized__SWIG_0(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatf_GetNormalized__SWIG_1")]
		public static extern IntPtr GfQuatf_GetNormalized__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatf_Normalize__SWIG_0")]
		public static extern float GfQuatf_Normalize__SWIG_0(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatf_Normalize__SWIG_1")]
		public static extern float GfQuatf_Normalize__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatf_GetConjugate")]
		public static extern IntPtr GfQuatf_GetConjugate(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatf_GetInverse")]
		public static extern IntPtr GfQuatf_GetInverse(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatf_Transform")]
		public static extern IntPtr GfQuatf_Transform(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatf_Equals")]
		public static extern bool GfQuatf_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuatf_GetHashCode")]
		public static extern int GfQuatf_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfQuatf")]
		public static extern void delete_GfQuatf(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSlerp__SWIG_4")]
		public static extern IntPtr GfSlerp__SWIG_4(double jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSlerp__SWIG_5")]
		public static extern IntPtr GfSlerp__SWIG_5(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDot__SWIG_6")]
		public static extern IntPtr GfDot__SWIG_6(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfQuath__SWIG_0")]
		public static extern IntPtr new_GfQuath__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfQuath__SWIG_1")]
		public static extern IntPtr new_GfQuath__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfQuath__SWIG_2")]
		public static extern IntPtr new_GfQuath__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfQuath__SWIG_3")]
		public static extern IntPtr new_GfQuath__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfQuath__SWIG_4")]
		public static extern IntPtr new_GfQuath__SWIG_4(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfQuath__SWIG_5")]
		public static extern IntPtr new_GfQuath__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuath_GetZero")]
		public static extern IntPtr GfQuath_GetZero();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuath_GetIdentity")]
		public static extern IntPtr GfQuath_GetIdentity();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuath_GetReal")]
		public static extern IntPtr GfQuath_GetReal(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuath_SetReal")]
		public static extern void GfQuath_SetReal(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuath_GetImaginary")]
		public static extern IntPtr GfQuath_GetImaginary(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuath_SetImaginary__SWIG_0")]
		public static extern void GfQuath_SetImaginary__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuath_SetImaginary__SWIG_1")]
		public static extern void GfQuath_SetImaginary__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuath_GetLength")]
		public static extern IntPtr GfQuath_GetLength(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuath_GetNormalized__SWIG_0")]
		public static extern IntPtr GfQuath_GetNormalized__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuath_GetNormalized__SWIG_1")]
		public static extern IntPtr GfQuath_GetNormalized__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuath_Normalize__SWIG_0")]
		public static extern IntPtr GfQuath_Normalize__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuath_Normalize__SWIG_1")]
		public static extern IntPtr GfQuath_Normalize__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuath_GetConjugate")]
		public static extern IntPtr GfQuath_GetConjugate(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuath_GetInverse")]
		public static extern IntPtr GfQuath_GetInverse(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuath_Transform")]
		public static extern IntPtr GfQuath_Transform(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuath_Equals")]
		public static extern bool GfQuath_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfQuath_GetHashCode")]
		public static extern int GfQuath_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfQuath")]
		public static extern void delete_GfQuath(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSlerp__SWIG_6")]
		public static extern IntPtr GfSlerp__SWIG_6(double jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSlerp__SWIG_7")]
		public static extern IntPtr GfSlerp__SWIG_7(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1d_SetEmpty")]
		public static extern void GfRange1d_SetEmpty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfRange1d__SWIG_0")]
		public static extern IntPtr new_GfRange1d__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfRange1d__SWIG_1")]
		public static extern IntPtr new_GfRange1d__SWIG_1(double jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1d_GetMin")]
		public static extern double GfRange1d_GetMin(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1d_GetMax")]
		public static extern double GfRange1d_GetMax(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1d_GetSize")]
		public static extern double GfRange1d_GetSize(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1d_GetMidpoint")]
		public static extern double GfRange1d_GetMidpoint(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1d_SetMin")]
		public static extern void GfRange1d_SetMin(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1d_SetMax")]
		public static extern void GfRange1d_SetMax(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1d_IsEmpty")]
		public static extern bool GfRange1d_IsEmpty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1d_ExtendBy__SWIG_0")]
		public static extern void GfRange1d_ExtendBy__SWIG_0(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1d_ExtendBy__SWIG_1")]
		public static extern void GfRange1d_ExtendBy__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1d_Contains__SWIG_0")]
		public static extern bool GfRange1d_Contains__SWIG_0(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1d_Contains__SWIG_1")]
		public static extern bool GfRange1d_Contains__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1d_IsInside__SWIG_0")]
		public static extern bool GfRange1d_IsInside__SWIG_0(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1d_IsInside__SWIG_1")]
		public static extern bool GfRange1d_IsInside__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1d_IsOutside")]
		public static extern bool GfRange1d_IsOutside(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1d_GetUnion")]
		public static extern IntPtr GfRange1d_GetUnion(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1d_UnionWith__SWIG_0")]
		public static extern IntPtr GfRange1d_UnionWith__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1d_UnionWith__SWIG_1")]
		public static extern IntPtr GfRange1d_UnionWith__SWIG_1(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1d_Union__SWIG_0")]
		public static extern IntPtr GfRange1d_Union__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1d_Union__SWIG_2")]
		public static extern IntPtr GfRange1d_Union__SWIG_2(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1d_GetIntersection")]
		public static extern IntPtr GfRange1d_GetIntersection(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1d_Intersection__SWIG_0")]
		public static extern IntPtr GfRange1d_Intersection__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1d_IntersectWith")]
		public static extern IntPtr GfRange1d_IntersectWith(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1d_GetDistanceSquared")]
		public static extern double GfRange1d_GetDistanceSquared(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1d_Equals")]
		public static extern bool GfRange1d_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1d_GetHashCode")]
		public static extern int GfRange1d_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfRange1d")]
		public static extern void delete_GfRange1d(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1f_SetEmpty")]
		public static extern void GfRange1f_SetEmpty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfRange1f__SWIG_0")]
		public static extern IntPtr new_GfRange1f__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfRange1f__SWIG_1")]
		public static extern IntPtr new_GfRange1f__SWIG_1(float jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1f_GetMin")]
		public static extern float GfRange1f_GetMin(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1f_GetMax")]
		public static extern float GfRange1f_GetMax(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1f_GetSize")]
		public static extern float GfRange1f_GetSize(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1f_GetMidpoint")]
		public static extern float GfRange1f_GetMidpoint(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1f_SetMin")]
		public static extern void GfRange1f_SetMin(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1f_SetMax")]
		public static extern void GfRange1f_SetMax(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1f_IsEmpty")]
		public static extern bool GfRange1f_IsEmpty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1f_ExtendBy__SWIG_0")]
		public static extern void GfRange1f_ExtendBy__SWIG_0(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1f_ExtendBy__SWIG_1")]
		public static extern void GfRange1f_ExtendBy__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1f_Contains__SWIG_0")]
		public static extern bool GfRange1f_Contains__SWIG_0(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1f_Contains__SWIG_1")]
		public static extern bool GfRange1f_Contains__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1f_IsInside__SWIG_0")]
		public static extern bool GfRange1f_IsInside__SWIG_0(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1f_IsInside__SWIG_1")]
		public static extern bool GfRange1f_IsInside__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1f_IsOutside")]
		public static extern bool GfRange1f_IsOutside(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1f_GetUnion")]
		public static extern IntPtr GfRange1f_GetUnion(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1f_UnionWith__SWIG_0")]
		public static extern IntPtr GfRange1f_UnionWith__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1f_UnionWith__SWIG_1")]
		public static extern IntPtr GfRange1f_UnionWith__SWIG_1(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1f_Union__SWIG_0")]
		public static extern IntPtr GfRange1f_Union__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1f_Union__SWIG_2")]
		public static extern IntPtr GfRange1f_Union__SWIG_2(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1f_GetIntersection")]
		public static extern IntPtr GfRange1f_GetIntersection(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1f_Intersection__SWIG_0")]
		public static extern IntPtr GfRange1f_Intersection__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1f_IntersectWith")]
		public static extern IntPtr GfRange1f_IntersectWith(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1f_GetDistanceSquared")]
		public static extern double GfRange1f_GetDistanceSquared(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1f_Equals")]
		public static extern bool GfRange1f_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange1f_GetHashCode")]
		public static extern int GfRange1f_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfRange1f")]
		public static extern void delete_GfRange1f(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_SetEmpty")]
		public static extern void GfRange2d_SetEmpty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfRange2d__SWIG_0")]
		public static extern IntPtr new_GfRange2d__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfRange2d__SWIG_1")]
		public static extern IntPtr new_GfRange2d__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_GetMin")]
		public static extern IntPtr GfRange2d_GetMin(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_GetMax")]
		public static extern IntPtr GfRange2d_GetMax(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_GetSize")]
		public static extern IntPtr GfRange2d_GetSize(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_GetMidpoint")]
		public static extern IntPtr GfRange2d_GetMidpoint(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_SetMin")]
		public static extern void GfRange2d_SetMin(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_SetMax")]
		public static extern void GfRange2d_SetMax(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_IsEmpty")]
		public static extern bool GfRange2d_IsEmpty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_ExtendBy__SWIG_0")]
		public static extern void GfRange2d_ExtendBy__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_ExtendBy__SWIG_1")]
		public static extern void GfRange2d_ExtendBy__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_Contains__SWIG_0")]
		public static extern bool GfRange2d_Contains__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_Contains__SWIG_1")]
		public static extern bool GfRange2d_Contains__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_IsInside__SWIG_0")]
		public static extern bool GfRange2d_IsInside__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_IsInside__SWIG_1")]
		public static extern bool GfRange2d_IsInside__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_IsOutside")]
		public static extern bool GfRange2d_IsOutside(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_GetUnion")]
		public static extern IntPtr GfRange2d_GetUnion(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_UnionWith__SWIG_0")]
		public static extern IntPtr GfRange2d_UnionWith__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_UnionWith__SWIG_1")]
		public static extern IntPtr GfRange2d_UnionWith__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_Union__SWIG_0")]
		public static extern IntPtr GfRange2d_Union__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_Union__SWIG_2")]
		public static extern IntPtr GfRange2d_Union__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_GetIntersection")]
		public static extern IntPtr GfRange2d_GetIntersection(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_Intersection__SWIG_0")]
		public static extern IntPtr GfRange2d_Intersection__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_IntersectWith")]
		public static extern IntPtr GfRange2d_IntersectWith(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_GetDistanceSquared")]
		public static extern double GfRange2d_GetDistanceSquared(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_GetCorner")]
		public static extern IntPtr GfRange2d_GetCorner(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_GetQuadrant")]
		public static extern IntPtr GfRange2d_GetQuadrant(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_UnitSquare_get")]
		public static extern IntPtr GfRange2d_UnitSquare_get();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_Equals")]
		public static extern bool GfRange2d_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange2d_GetHashCode")]
		public static extern int GfRange2d_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfRange2d")]
		public static extern void delete_GfRange2d(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_SetEmpty")]
		public static extern void GfRange3d_SetEmpty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfRange3d__SWIG_0")]
		public static extern IntPtr new_GfRange3d__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfRange3d__SWIG_1")]
		public static extern IntPtr new_GfRange3d__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_GetMin")]
		public static extern IntPtr GfRange3d_GetMin(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_GetMax")]
		public static extern IntPtr GfRange3d_GetMax(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_GetSize")]
		public static extern IntPtr GfRange3d_GetSize(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_GetMidpoint")]
		public static extern IntPtr GfRange3d_GetMidpoint(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_SetMin")]
		public static extern void GfRange3d_SetMin(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_SetMax")]
		public static extern void GfRange3d_SetMax(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_IsEmpty")]
		public static extern bool GfRange3d_IsEmpty(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_ExtendBy__SWIG_0")]
		public static extern void GfRange3d_ExtendBy__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_ExtendBy__SWIG_1")]
		public static extern void GfRange3d_ExtendBy__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_Contains__SWIG_0")]
		public static extern bool GfRange3d_Contains__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_Contains__SWIG_1")]
		public static extern bool GfRange3d_Contains__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_IsInside__SWIG_0")]
		public static extern bool GfRange3d_IsInside__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_IsInside__SWIG_1")]
		public static extern bool GfRange3d_IsInside__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_IsOutside")]
		public static extern bool GfRange3d_IsOutside(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_GetUnion")]
		public static extern IntPtr GfRange3d_GetUnion(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_UnionWith__SWIG_0")]
		public static extern IntPtr GfRange3d_UnionWith__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_UnionWith__SWIG_1")]
		public static extern IntPtr GfRange3d_UnionWith__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_Union__SWIG_0")]
		public static extern IntPtr GfRange3d_Union__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_Union__SWIG_2")]
		public static extern IntPtr GfRange3d_Union__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_GetIntersection")]
		public static extern IntPtr GfRange3d_GetIntersection(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_Intersection__SWIG_0")]
		public static extern IntPtr GfRange3d_Intersection__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_IntersectWith")]
		public static extern IntPtr GfRange3d_IntersectWith(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_GetDistanceSquared")]
		public static extern double GfRange3d_GetDistanceSquared(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_GetCorner")]
		public static extern IntPtr GfRange3d_GetCorner(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_GetOctant")]
		public static extern IntPtr GfRange3d_GetOctant(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_UnitCube_get")]
		public static extern IntPtr GfRange3d_UnitCube_get();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_Equals")]
		public static extern bool GfRange3d_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRange3d_GetHashCode")]
		public static extern int GfRange3d_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfRange3d")]
		public static extern void delete_GfRange3d(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfRay__SWIG_0")]
		public static extern IntPtr new_GfRay__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfRay__SWIG_1")]
		public static extern IntPtr new_GfRay__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_SetPointAndDirection")]
		public static extern void GfRay_SetPointAndDirection(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_SetEnds")]
		public static extern void GfRay_SetEnds(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_GetStartPoint")]
		public static extern IntPtr GfRay_GetStartPoint(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_GetDirection")]
		public static extern IntPtr GfRay_GetDirection(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_GetPoint")]
		public static extern IntPtr GfRay_GetPoint(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_Transform")]
		public static extern IntPtr GfRay_Transform(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_FindClosestPoint__SWIG_0")]
		public static extern IntPtr GfRay_FindClosestPoint__SWIG_0(HandleRef jarg1, HandleRef jarg2, out double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_FindClosestPoint__SWIG_1")]
		public static extern IntPtr GfRay_FindClosestPoint__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_Intersect__SWIG_0")]
		public static extern bool GfRay_Intersect__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, out double jarg5, HandleRef jarg6, out bool jarg7, double jarg8);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_Intersect__SWIG_1")]
		public static extern bool GfRay_Intersect__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, out double jarg5, HandleRef jarg6, out bool jarg7);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_Intersect__SWIG_2")]
		public static extern bool GfRay_Intersect__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, out double jarg5, HandleRef jarg6);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_Intersect__SWIG_3")]
		public static extern bool GfRay_Intersect__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, out double jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_Intersect__SWIG_4")]
		public static extern bool GfRay_Intersect__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_Intersect__SWIG_5")]
		public static extern bool GfRay_Intersect__SWIG_5(HandleRef jarg1, HandleRef jarg2, out double jarg3, out bool jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_Intersect__SWIG_6")]
		public static extern bool GfRay_Intersect__SWIG_6(HandleRef jarg1, HandleRef jarg2, out double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_Intersect__SWIG_7")]
		public static extern bool GfRay_Intersect__SWIG_7(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_Intersect__SWIG_8")]
		public static extern bool GfRay_Intersect__SWIG_8(HandleRef jarg1, HandleRef jarg2, out double jarg3, out double jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_Intersect__SWIG_9")]
		public static extern bool GfRay_Intersect__SWIG_9(HandleRef jarg1, HandleRef jarg2, out double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_Intersect__SWIG_10")]
		public static extern bool GfRay_Intersect__SWIG_10(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_Intersect__SWIG_11")]
		public static extern bool GfRay_Intersect__SWIG_11(HandleRef jarg1, HandleRef jarg2, out double jarg3, out double jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_Intersect__SWIG_12")]
		public static extern bool GfRay_Intersect__SWIG_12(HandleRef jarg1, HandleRef jarg2, out double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_Intersect__SWIG_13")]
		public static extern bool GfRay_Intersect__SWIG_13(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_Intersect__SWIG_14")]
		public static extern bool GfRay_Intersect__SWIG_14(HandleRef jarg1, HandleRef jarg2, double jarg3, out double jarg4, out double jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_Intersect__SWIG_15")]
		public static extern bool GfRay_Intersect__SWIG_15(HandleRef jarg1, HandleRef jarg2, double jarg3, out double jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_Intersect__SWIG_16")]
		public static extern bool GfRay_Intersect__SWIG_16(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_Intersect__SWIG_17")]
		public static extern bool GfRay_Intersect__SWIG_17(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, double jarg4, out double jarg5, out double jarg6);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_Intersect__SWIG_18")]
		public static extern bool GfRay_Intersect__SWIG_18(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, double jarg4, out double jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_Intersect__SWIG_19")]
		public static extern bool GfRay_Intersect__SWIG_19(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, double jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_Intersect__SWIG_20")]
		public static extern bool GfRay_Intersect__SWIG_20(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, double jarg4, double jarg5, out double jarg6, out double jarg7);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_Intersect__SWIG_21")]
		public static extern bool GfRay_Intersect__SWIG_21(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, double jarg4, double jarg5, out double jarg6);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_Intersect__SWIG_22")]
		public static extern bool GfRay_Intersect__SWIG_22(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, double jarg4, double jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFindClosestPoints__SWIG_15")]
		public static extern bool GfFindClosestPoints__SWIG_15(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, out double jarg5, out double jarg6);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFindClosestPoints__SWIG_16")]
		public static extern bool GfFindClosestPoints__SWIG_16(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, out double jarg5, out double jarg6);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_Equals")]
		public static extern bool GfRay_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRay_GetHashCode")]
		public static extern int GfRay_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfRay")]
		public static extern void delete_GfRay(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFindClosestPoints__SWIG_17")]
		public static extern bool GfFindClosestPoints__SWIG_17(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, out double jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFindClosestPoints__SWIG_18")]
		public static extern bool GfFindClosestPoints__SWIG_18(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFindClosestPoints__SWIG_19")]
		public static extern bool GfFindClosestPoints__SWIG_19(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFindClosestPoints__SWIG_20")]
		public static extern bool GfFindClosestPoints__SWIG_20(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFindClosestPoints__SWIG_21")]
		public static extern bool GfFindClosestPoints__SWIG_21(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, out double jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFindClosestPoints__SWIG_22")]
		public static extern bool GfFindClosestPoints__SWIG_22(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFindClosestPoints__SWIG_23")]
		public static extern bool GfFindClosestPoints__SWIG_23(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfFindClosestPoints__SWIG_24")]
		public static extern bool GfFindClosestPoints__SWIG_24(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfRotation__SWIG_0")]
		public static extern IntPtr new_GfRotation__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfRotation__SWIG_1")]
		public static extern IntPtr new_GfRotation__SWIG_1(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfRotation__SWIG_2")]
		public static extern IntPtr new_GfRotation__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfRotation__SWIG_3")]
		public static extern IntPtr new_GfRotation__SWIG_3(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfRotation__SWIG_4")]
		public static extern IntPtr new_GfRotation__SWIG_4(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRotation_SetAxisAngle")]
		public static extern IntPtr GfRotation_SetAxisAngle(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRotation_SetQuat")]
		public static extern IntPtr GfRotation_SetQuat(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRotation_SetQuaternion")]
		public static extern IntPtr GfRotation_SetQuaternion(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRotation_SetRotateInto")]
		public static extern IntPtr GfRotation_SetRotateInto(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRotation_SetIdentity")]
		public static extern IntPtr GfRotation_SetIdentity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRotation_GetAxis")]
		public static extern IntPtr GfRotation_GetAxis(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRotation_GetAngle")]
		public static extern double GfRotation_GetAngle(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRotation_GetQuaternion")]
		public static extern IntPtr GfRotation_GetQuaternion(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRotation_GetQuat")]
		public static extern IntPtr GfRotation_GetQuat(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRotation_GetInverse")]
		public static extern IntPtr GfRotation_GetInverse(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRotation_Decompose")]
		public static extern IntPtr GfRotation_Decompose(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRotation_DecomposeRotation__SWIG_0")]
		public static extern void GfRotation_DecomposeRotation__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, double jarg5, out double jarg6, out double jarg7, out double jarg8, out double jarg9, bool jarg10, double jarg11);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRotation_DecomposeRotation__SWIG_1")]
		public static extern void GfRotation_DecomposeRotation__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, double jarg5, out double jarg6, out double jarg7, out double jarg8, out double jarg9, bool jarg10);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRotation_DecomposeRotation__SWIG_2")]
		public static extern void GfRotation_DecomposeRotation__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, double jarg5, out double jarg6, out double jarg7, out double jarg8, out double jarg9);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRotation_DecomposeRotation__SWIG_3")]
		public static extern void GfRotation_DecomposeRotation__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, double jarg5, out double jarg6, out double jarg7, out double jarg8);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRotation_RotateOntoProjected")]
		public static extern IntPtr GfRotation_RotateOntoProjected(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRotation_MatchClosestEulerRotation")]
		public static extern void GfRotation_MatchClosestEulerRotation(double jarg1, double jarg2, double jarg3, double jarg4, out double jarg5, out double jarg6, out double jarg7, out double jarg8);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRotation_TransformDir__SWIG_0")]
		public static extern IntPtr GfRotation_TransformDir__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRotation_TransformDir__SWIG_1")]
		public static extern IntPtr GfRotation_TransformDir__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRotation_Equals")]
		public static extern bool GfRotation_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfRotation_GetHashCode")]
		public static extern int GfRotation_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfRotation")]
		public static extern void delete_GfRotation(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec2d__SWIG_0")]
		public static extern IntPtr new_GfVec2d__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec2d__SWIG_1")]
		public static extern IntPtr new_GfVec2d__SWIG_1(double jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec2d__SWIG_2")]
		public static extern IntPtr new_GfVec2d__SWIG_2(double jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec2d__SWIG_4")]
		public static extern IntPtr new_GfVec2d__SWIG_4(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec2d__SWIG_5")]
		public static extern IntPtr new_GfVec2d__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec2d__SWIG_6")]
		public static extern IntPtr new_GfVec2d__SWIG_6(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2d_XAxis")]
		public static extern IntPtr GfVec2d_XAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2d_YAxis")]
		public static extern IntPtr GfVec2d_YAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2d_Axis")]
		public static extern IntPtr GfVec2d_Axis(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2d_Set")]
		public static extern IntPtr GfVec2d_Set(HandleRef jarg1, double jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2d_GetProjection")]
		public static extern IntPtr GfVec2d_GetProjection(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2d_GetComplement")]
		public static extern IntPtr GfVec2d_GetComplement(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2d_GetLengthSq")]
		public static extern double GfVec2d_GetLengthSq(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2d_GetLength")]
		public static extern double GfVec2d_GetLength(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2d_Normalize__SWIG_0")]
		public static extern double GfVec2d_Normalize__SWIG_0(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2d_Normalize__SWIG_1")]
		public static extern double GfVec2d_Normalize__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2d_GetNormalized__SWIG_0")]
		public static extern IntPtr GfVec2d_GetNormalized__SWIG_0(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2d_GetNormalized__SWIG_1")]
		public static extern IntPtr GfVec2d_GetNormalized__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2d_Equals")]
		public static extern bool GfVec2d_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2d_GetHashCode")]
		public static extern int GfVec2d_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2d_GetValue")]
		public static extern double GfVec2d_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2d_SetValue")]
		public static extern void GfVec2d_SetValue(HandleRef jarg1, int jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfVec2d")]
		public static extern void delete_GfVec2d(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCompMult__SWIG_0")]
		public static extern IntPtr GfCompMult__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCompDiv__SWIG_0")]
		public static extern IntPtr GfCompDiv__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDot__SWIG_7")]
		public static extern double GfDot__SWIG_7(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetLength__SWIG_0")]
		public static extern double GfGetLength__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfNormalize__SWIG_0")]
		public static extern double GfNormalize__SWIG_0(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfNormalize__SWIG_1")]
		public static extern double GfNormalize__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetNormalized__SWIG_0")]
		public static extern IntPtr GfGetNormalized__SWIG_0(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetNormalized__SWIG_1")]
		public static extern IntPtr GfGetNormalized__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetProjection__SWIG_0")]
		public static extern IntPtr GfGetProjection__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetComplement__SWIG_0")]
		public static extern IntPtr GfGetComplement__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfIsClose__SWIG_7")]
		public static extern bool GfIsClose__SWIG_7(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec2f__SWIG_0")]
		public static extern IntPtr new_GfVec2f__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec2f__SWIG_1")]
		public static extern IntPtr new_GfVec2f__SWIG_1(float jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec2f__SWIG_2")]
		public static extern IntPtr new_GfVec2f__SWIG_2(float jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec2f__SWIG_4")]
		public static extern IntPtr new_GfVec2f__SWIG_4(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec2f__SWIG_5")]
		public static extern IntPtr new_GfVec2f__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec2f__SWIG_6")]
		public static extern IntPtr new_GfVec2f__SWIG_6(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2f_XAxis")]
		public static extern IntPtr GfVec2f_XAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2f_YAxis")]
		public static extern IntPtr GfVec2f_YAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2f_Axis")]
		public static extern IntPtr GfVec2f_Axis(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2f_Set")]
		public static extern IntPtr GfVec2f_Set(HandleRef jarg1, float jarg2, float jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2f_GetProjection")]
		public static extern IntPtr GfVec2f_GetProjection(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2f_GetComplement")]
		public static extern IntPtr GfVec2f_GetComplement(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2f_GetLengthSq")]
		public static extern float GfVec2f_GetLengthSq(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2f_GetLength")]
		public static extern float GfVec2f_GetLength(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2f_Normalize__SWIG_0")]
		public static extern float GfVec2f_Normalize__SWIG_0(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2f_Normalize__SWIG_1")]
		public static extern float GfVec2f_Normalize__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2f_GetNormalized__SWIG_0")]
		public static extern IntPtr GfVec2f_GetNormalized__SWIG_0(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2f_GetNormalized__SWIG_1")]
		public static extern IntPtr GfVec2f_GetNormalized__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2f_Equals")]
		public static extern bool GfVec2f_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2f_GetHashCode")]
		public static extern int GfVec2f_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2f_GetValue")]
		public static extern float GfVec2f_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2f_SetValue")]
		public static extern void GfVec2f_SetValue(HandleRef jarg1, int jarg2, float jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfVec2f")]
		public static extern void delete_GfVec2f(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCompMult__SWIG_1")]
		public static extern IntPtr GfCompMult__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCompDiv__SWIG_1")]
		public static extern IntPtr GfCompDiv__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDot__SWIG_8")]
		public static extern float GfDot__SWIG_8(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetLength__SWIG_1")]
		public static extern float GfGetLength__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfNormalize__SWIG_2")]
		public static extern float GfNormalize__SWIG_2(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfNormalize__SWIG_3")]
		public static extern float GfNormalize__SWIG_3(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetNormalized__SWIG_2")]
		public static extern IntPtr GfGetNormalized__SWIG_2(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetNormalized__SWIG_3")]
		public static extern IntPtr GfGetNormalized__SWIG_3(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetProjection__SWIG_1")]
		public static extern IntPtr GfGetProjection__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetComplement__SWIG_1")]
		public static extern IntPtr GfGetComplement__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfIsClose__SWIG_8")]
		public static extern bool GfIsClose__SWIG_8(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec2h__SWIG_0")]
		public static extern IntPtr new_GfVec2h__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec2h__SWIG_1")]
		public static extern IntPtr new_GfVec2h__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec2h__SWIG_2")]
		public static extern IntPtr new_GfVec2h__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec2h__SWIG_4")]
		public static extern IntPtr new_GfVec2h__SWIG_4(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec2h__SWIG_5")]
		public static extern IntPtr new_GfVec2h__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec2h__SWIG_6")]
		public static extern IntPtr new_GfVec2h__SWIG_6(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2h_XAxis")]
		public static extern IntPtr GfVec2h_XAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2h_YAxis")]
		public static extern IntPtr GfVec2h_YAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2h_Axis")]
		public static extern IntPtr GfVec2h_Axis(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2h_Set__SWIG_0")]
		public static extern IntPtr GfVec2h_Set__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2h_Set__SWIG_1")]
		public static extern IntPtr GfVec2h_Set__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2h_GetProjection")]
		public static extern IntPtr GfVec2h_GetProjection(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2h_GetComplement")]
		public static extern IntPtr GfVec2h_GetComplement(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2h_GetLengthSq")]
		public static extern IntPtr GfVec2h_GetLengthSq(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2h_GetLength")]
		public static extern IntPtr GfVec2h_GetLength(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2h_Normalize__SWIG_0")]
		public static extern IntPtr GfVec2h_Normalize__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2h_Normalize__SWIG_1")]
		public static extern IntPtr GfVec2h_Normalize__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2h_GetNormalized__SWIG_0")]
		public static extern IntPtr GfVec2h_GetNormalized__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2h_GetNormalized__SWIG_1")]
		public static extern IntPtr GfVec2h_GetNormalized__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2h_Equals")]
		public static extern bool GfVec2h_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2h_GetHashCode")]
		public static extern int GfVec2h_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2h_GetValue")]
		public static extern float GfVec2h_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2h_SetValue")]
		public static extern void GfVec2h_SetValue(HandleRef jarg1, int jarg2, float jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfVec2h")]
		public static extern void delete_GfVec2h(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCompMult__SWIG_2")]
		public static extern IntPtr GfCompMult__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCompDiv__SWIG_2")]
		public static extern IntPtr GfCompDiv__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDot__SWIG_9")]
		public static extern IntPtr GfDot__SWIG_9(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetLength__SWIG_2")]
		public static extern IntPtr GfGetLength__SWIG_2(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfNormalize__SWIG_4")]
		public static extern IntPtr GfNormalize__SWIG_4(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfNormalize__SWIG_5")]
		public static extern IntPtr GfNormalize__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetNormalized__SWIG_4")]
		public static extern IntPtr GfGetNormalized__SWIG_4(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetNormalized__SWIG_5")]
		public static extern IntPtr GfGetNormalized__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetProjection__SWIG_2")]
		public static extern IntPtr GfGetProjection__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetComplement__SWIG_2")]
		public static extern IntPtr GfGetComplement__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfIsClose__SWIG_9")]
		public static extern bool GfIsClose__SWIG_9(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec2i__SWIG_0")]
		public static extern IntPtr new_GfVec2i__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec2i__SWIG_1")]
		public static extern IntPtr new_GfVec2i__SWIG_1(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec2i__SWIG_2")]
		public static extern IntPtr new_GfVec2i__SWIG_2(int jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2i_XAxis")]
		public static extern IntPtr GfVec2i_XAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2i_YAxis")]
		public static extern IntPtr GfVec2i_YAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2i_Axis")]
		public static extern IntPtr GfVec2i_Axis(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2i_Set")]
		public static extern IntPtr GfVec2i_Set(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2i_GetProjection")]
		public static extern IntPtr GfVec2i_GetProjection(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2i_GetComplement")]
		public static extern IntPtr GfVec2i_GetComplement(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2i_GetLengthSq")]
		public static extern int GfVec2i_GetLengthSq(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2i_Equals")]
		public static extern bool GfVec2i_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2i_GetHashCode")]
		public static extern int GfVec2i_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2i_GetValue")]
		public static extern int GfVec2i_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec2i_SetValue")]
		public static extern void GfVec2i_SetValue(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfVec2i")]
		public static extern void delete_GfVec2i(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCompMult__SWIG_3")]
		public static extern IntPtr GfCompMult__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCompDiv__SWIG_3")]
		public static extern IntPtr GfCompDiv__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDot__SWIG_10")]
		public static extern int GfDot__SWIG_10(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec3d__SWIG_0")]
		public static extern IntPtr new_GfVec3d__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec3d__SWIG_1")]
		public static extern IntPtr new_GfVec3d__SWIG_1(double jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec3d__SWIG_2")]
		public static extern IntPtr new_GfVec3d__SWIG_2(double jarg1, double jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec3d__SWIG_4")]
		public static extern IntPtr new_GfVec3d__SWIG_4(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec3d__SWIG_5")]
		public static extern IntPtr new_GfVec3d__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec3d__SWIG_6")]
		public static extern IntPtr new_GfVec3d__SWIG_6(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3d_XAxis")]
		public static extern IntPtr GfVec3d_XAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3d_YAxis")]
		public static extern IntPtr GfVec3d_YAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3d_ZAxis")]
		public static extern IntPtr GfVec3d_ZAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3d_Axis")]
		public static extern IntPtr GfVec3d_Axis(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3d_Set")]
		public static extern IntPtr GfVec3d_Set(HandleRef jarg1, double jarg2, double jarg3, double jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3d_GetProjection")]
		public static extern IntPtr GfVec3d_GetProjection(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3d_GetComplement")]
		public static extern IntPtr GfVec3d_GetComplement(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3d_GetLengthSq")]
		public static extern double GfVec3d_GetLengthSq(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3d_GetLength")]
		public static extern double GfVec3d_GetLength(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3d_Normalize__SWIG_0")]
		public static extern double GfVec3d_Normalize__SWIG_0(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3d_Normalize__SWIG_1")]
		public static extern double GfVec3d_Normalize__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3d_GetNormalized__SWIG_0")]
		public static extern IntPtr GfVec3d_GetNormalized__SWIG_0(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3d_GetNormalized__SWIG_1")]
		public static extern IntPtr GfVec3d_GetNormalized__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3d_OrthogonalizeBasis__SWIG_0")]
		public static extern bool GfVec3d_OrthogonalizeBasis__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4, double jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3d_OrthogonalizeBasis__SWIG_1")]
		public static extern bool GfVec3d_OrthogonalizeBasis__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3d_BuildOrthonormalFrame__SWIG_0")]
		public static extern void GfVec3d_BuildOrthonormalFrame__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, double jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3d_BuildOrthonormalFrame__SWIG_1")]
		public static extern void GfVec3d_BuildOrthonormalFrame__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3d_Equals")]
		public static extern bool GfVec3d_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3d_GetHashCode")]
		public static extern int GfVec3d_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3d_GetValue")]
		public static extern double GfVec3d_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3d_SetValue")]
		public static extern void GfVec3d_SetValue(HandleRef jarg1, int jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfVec3d")]
		public static extern void delete_GfVec3d(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCompMult__SWIG_4")]
		public static extern IntPtr GfCompMult__SWIG_4(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCompDiv__SWIG_4")]
		public static extern IntPtr GfCompDiv__SWIG_4(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDot__SWIG_11")]
		public static extern double GfDot__SWIG_11(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetLength__SWIG_3")]
		public static extern double GfGetLength__SWIG_3(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfNormalize__SWIG_6")]
		public static extern double GfNormalize__SWIG_6(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfNormalize__SWIG_7")]
		public static extern double GfNormalize__SWIG_7(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetNormalized__SWIG_6")]
		public static extern IntPtr GfGetNormalized__SWIG_6(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetNormalized__SWIG_7")]
		public static extern IntPtr GfGetNormalized__SWIG_7(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetProjection__SWIG_3")]
		public static extern IntPtr GfGetProjection__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetComplement__SWIG_3")]
		public static extern IntPtr GfGetComplement__SWIG_3(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfIsClose__SWIG_10")]
		public static extern bool GfIsClose__SWIG_10(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfOrthogonalizeBasis__SWIG_0")]
		public static extern bool GfOrthogonalizeBasis__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4, double jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfOrthogonalizeBasis__SWIG_1")]
		public static extern bool GfOrthogonalizeBasis__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfBuildOrthonormalFrame__SWIG_0")]
		public static extern void GfBuildOrthonormalFrame__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, double jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfBuildOrthonormalFrame__SWIG_1")]
		public static extern void GfBuildOrthonormalFrame__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCross__SWIG_0")]
		public static extern IntPtr GfCross__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSlerp__SWIG_8")]
		public static extern IntPtr GfSlerp__SWIG_8(double jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3dVector_Clear")]
		public static extern void GfVec3dVector_Clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3dVector_Add")]
		public static extern void GfVec3dVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3dVector_size")]
		public static extern uint GfVec3dVector_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3dVector_capacity")]
		public static extern uint GfVec3dVector_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3dVector_reserve")]
		public static extern void GfVec3dVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec3dVector__SWIG_0")]
		public static extern IntPtr new_GfVec3dVector__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec3dVector__SWIG_1")]
		public static extern IntPtr new_GfVec3dVector__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec3dVector__SWIG_2")]
		public static extern IntPtr new_GfVec3dVector__SWIG_2(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3dVector_getitemcopy")]
		public static extern IntPtr GfVec3dVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3dVector_getitem")]
		public static extern IntPtr GfVec3dVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3dVector_setitem")]
		public static extern void GfVec3dVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3dVector_AddRange")]
		public static extern void GfVec3dVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3dVector_GetRange")]
		public static extern IntPtr GfVec3dVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3dVector_Insert")]
		public static extern void GfVec3dVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3dVector_InsertRange")]
		public static extern void GfVec3dVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3dVector_RemoveAt")]
		public static extern void GfVec3dVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3dVector_RemoveRange")]
		public static extern void GfVec3dVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3dVector_Repeat")]
		public static extern IntPtr GfVec3dVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3dVector_Reverse__SWIG_0")]
		public static extern void GfVec3dVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3dVector_Reverse__SWIG_1")]
		public static extern void GfVec3dVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3dVector_SetRange")]
		public static extern void GfVec3dVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfVec3dVector")]
		public static extern void delete_GfVec3dVector(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec3f__SWIG_0")]
		public static extern IntPtr new_GfVec3f__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec3f__SWIG_1")]
		public static extern IntPtr new_GfVec3f__SWIG_1(float jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec3f__SWIG_2")]
		public static extern IntPtr new_GfVec3f__SWIG_2(float jarg1, float jarg2, float jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec3f__SWIG_4")]
		public static extern IntPtr new_GfVec3f__SWIG_4(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec3f__SWIG_5")]
		public static extern IntPtr new_GfVec3f__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec3f__SWIG_6")]
		public static extern IntPtr new_GfVec3f__SWIG_6(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3f_XAxis")]
		public static extern IntPtr GfVec3f_XAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3f_YAxis")]
		public static extern IntPtr GfVec3f_YAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3f_ZAxis")]
		public static extern IntPtr GfVec3f_ZAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3f_Axis")]
		public static extern IntPtr GfVec3f_Axis(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3f_Set")]
		public static extern IntPtr GfVec3f_Set(HandleRef jarg1, float jarg2, float jarg3, float jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3f_GetProjection")]
		public static extern IntPtr GfVec3f_GetProjection(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3f_GetComplement")]
		public static extern IntPtr GfVec3f_GetComplement(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3f_GetLengthSq")]
		public static extern float GfVec3f_GetLengthSq(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3f_GetLength")]
		public static extern float GfVec3f_GetLength(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3f_Normalize__SWIG_0")]
		public static extern float GfVec3f_Normalize__SWIG_0(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3f_Normalize__SWIG_1")]
		public static extern float GfVec3f_Normalize__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3f_GetNormalized__SWIG_0")]
		public static extern IntPtr GfVec3f_GetNormalized__SWIG_0(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3f_GetNormalized__SWIG_1")]
		public static extern IntPtr GfVec3f_GetNormalized__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3f_OrthogonalizeBasis__SWIG_0")]
		public static extern bool GfVec3f_OrthogonalizeBasis__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4, double jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3f_OrthogonalizeBasis__SWIG_1")]
		public static extern bool GfVec3f_OrthogonalizeBasis__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3f_BuildOrthonormalFrame__SWIG_0")]
		public static extern void GfVec3f_BuildOrthonormalFrame__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, float jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3f_BuildOrthonormalFrame__SWIG_1")]
		public static extern void GfVec3f_BuildOrthonormalFrame__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3f_Equals")]
		public static extern bool GfVec3f_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3f_GetHashCode")]
		public static extern int GfVec3f_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3f_GetValue")]
		public static extern float GfVec3f_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3f_SetValue")]
		public static extern void GfVec3f_SetValue(HandleRef jarg1, int jarg2, float jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfVec3f")]
		public static extern void delete_GfVec3f(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCompMult__SWIG_5")]
		public static extern IntPtr GfCompMult__SWIG_5(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCompDiv__SWIG_5")]
		public static extern IntPtr GfCompDiv__SWIG_5(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDot__SWIG_12")]
		public static extern float GfDot__SWIG_12(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetLength__SWIG_4")]
		public static extern float GfGetLength__SWIG_4(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfNormalize__SWIG_8")]
		public static extern float GfNormalize__SWIG_8(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfNormalize__SWIG_9")]
		public static extern float GfNormalize__SWIG_9(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetNormalized__SWIG_8")]
		public static extern IntPtr GfGetNormalized__SWIG_8(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetNormalized__SWIG_9")]
		public static extern IntPtr GfGetNormalized__SWIG_9(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetProjection__SWIG_4")]
		public static extern IntPtr GfGetProjection__SWIG_4(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetComplement__SWIG_4")]
		public static extern IntPtr GfGetComplement__SWIG_4(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfIsClose__SWIG_11")]
		public static extern bool GfIsClose__SWIG_11(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfOrthogonalizeBasis__SWIG_2")]
		public static extern bool GfOrthogonalizeBasis__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4, double jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfOrthogonalizeBasis__SWIG_3")]
		public static extern bool GfOrthogonalizeBasis__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfBuildOrthonormalFrame__SWIG_2")]
		public static extern void GfBuildOrthonormalFrame__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, float jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfBuildOrthonormalFrame__SWIG_3")]
		public static extern void GfBuildOrthonormalFrame__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCross__SWIG_1")]
		public static extern IntPtr GfCross__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSlerp__SWIG_9")]
		public static extern IntPtr GfSlerp__SWIG_9(double jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec3h__SWIG_0")]
		public static extern IntPtr new_GfVec3h__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec3h__SWIG_1")]
		public static extern IntPtr new_GfVec3h__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec3h__SWIG_2")]
		public static extern IntPtr new_GfVec3h__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec3h__SWIG_4")]
		public static extern IntPtr new_GfVec3h__SWIG_4(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec3h__SWIG_5")]
		public static extern IntPtr new_GfVec3h__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec3h__SWIG_6")]
		public static extern IntPtr new_GfVec3h__SWIG_6(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3h_XAxis")]
		public static extern IntPtr GfVec3h_XAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3h_YAxis")]
		public static extern IntPtr GfVec3h_YAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3h_ZAxis")]
		public static extern IntPtr GfVec3h_ZAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3h_Axis")]
		public static extern IntPtr GfVec3h_Axis(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3h_Set__SWIG_0")]
		public static extern IntPtr GfVec3h_Set__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3h_Set__SWIG_1")]
		public static extern IntPtr GfVec3h_Set__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3h_GetProjection")]
		public static extern IntPtr GfVec3h_GetProjection(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3h_GetComplement")]
		public static extern IntPtr GfVec3h_GetComplement(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3h_GetLengthSq")]
		public static extern IntPtr GfVec3h_GetLengthSq(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3h_GetLength")]
		public static extern IntPtr GfVec3h_GetLength(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3h_Normalize__SWIG_0")]
		public static extern IntPtr GfVec3h_Normalize__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3h_Normalize__SWIG_1")]
		public static extern IntPtr GfVec3h_Normalize__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3h_GetNormalized__SWIG_0")]
		public static extern IntPtr GfVec3h_GetNormalized__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3h_GetNormalized__SWIG_1")]
		public static extern IntPtr GfVec3h_GetNormalized__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3h_OrthogonalizeBasis__SWIG_0")]
		public static extern bool GfVec3h_OrthogonalizeBasis__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4, double jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3h_OrthogonalizeBasis__SWIG_1")]
		public static extern bool GfVec3h_OrthogonalizeBasis__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3h_BuildOrthonormalFrame__SWIG_0")]
		public static extern void GfVec3h_BuildOrthonormalFrame__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3h_BuildOrthonormalFrame__SWIG_1")]
		public static extern void GfVec3h_BuildOrthonormalFrame__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3h_Equals")]
		public static extern bool GfVec3h_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3h_GetHashCode")]
		public static extern int GfVec3h_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3h_GetValue")]
		public static extern float GfVec3h_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3h_SetValue")]
		public static extern void GfVec3h_SetValue(HandleRef jarg1, int jarg2, float jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfVec3h")]
		public static extern void delete_GfVec3h(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCompMult__SWIG_6")]
		public static extern IntPtr GfCompMult__SWIG_6(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCompDiv__SWIG_6")]
		public static extern IntPtr GfCompDiv__SWIG_6(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDot__SWIG_13")]
		public static extern IntPtr GfDot__SWIG_13(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetLength__SWIG_5")]
		public static extern IntPtr GfGetLength__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfNormalize__SWIG_10")]
		public static extern IntPtr GfNormalize__SWIG_10(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfNormalize__SWIG_11")]
		public static extern IntPtr GfNormalize__SWIG_11(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetNormalized__SWIG_10")]
		public static extern IntPtr GfGetNormalized__SWIG_10(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetNormalized__SWIG_11")]
		public static extern IntPtr GfGetNormalized__SWIG_11(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetProjection__SWIG_5")]
		public static extern IntPtr GfGetProjection__SWIG_5(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetComplement__SWIG_5")]
		public static extern IntPtr GfGetComplement__SWIG_5(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfIsClose__SWIG_12")]
		public static extern bool GfIsClose__SWIG_12(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfOrthogonalizeBasis__SWIG_4")]
		public static extern bool GfOrthogonalizeBasis__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4, double jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfOrthogonalizeBasis__SWIG_5")]
		public static extern bool GfOrthogonalizeBasis__SWIG_5(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfBuildOrthonormalFrame__SWIG_4")]
		public static extern void GfBuildOrthonormalFrame__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfBuildOrthonormalFrame__SWIG_5")]
		public static extern void GfBuildOrthonormalFrame__SWIG_5(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCross__SWIG_2")]
		public static extern IntPtr GfCross__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfSlerp__SWIG_10")]
		public static extern IntPtr GfSlerp__SWIG_10(double jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec3i__SWIG_0")]
		public static extern IntPtr new_GfVec3i__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec3i__SWIG_1")]
		public static extern IntPtr new_GfVec3i__SWIG_1(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec3i__SWIG_2")]
		public static extern IntPtr new_GfVec3i__SWIG_2(int jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3i_XAxis")]
		public static extern IntPtr GfVec3i_XAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3i_YAxis")]
		public static extern IntPtr GfVec3i_YAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3i_ZAxis")]
		public static extern IntPtr GfVec3i_ZAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3i_Axis")]
		public static extern IntPtr GfVec3i_Axis(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3i_Set")]
		public static extern IntPtr GfVec3i_Set(HandleRef jarg1, int jarg2, int jarg3, int jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3i_GetProjection")]
		public static extern IntPtr GfVec3i_GetProjection(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3i_GetComplement")]
		public static extern IntPtr GfVec3i_GetComplement(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3i_GetLengthSq")]
		public static extern int GfVec3i_GetLengthSq(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3i_Equals")]
		public static extern bool GfVec3i_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3i_GetHashCode")]
		public static extern int GfVec3i_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3i_GetValue")]
		public static extern int GfVec3i_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec3i_SetValue")]
		public static extern void GfVec3i_SetValue(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfVec3i")]
		public static extern void delete_GfVec3i(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCompMult__SWIG_7")]
		public static extern IntPtr GfCompMult__SWIG_7(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCompDiv__SWIG_7")]
		public static extern IntPtr GfCompDiv__SWIG_7(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDot__SWIG_14")]
		public static extern int GfDot__SWIG_14(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec4d__SWIG_0")]
		public static extern IntPtr new_GfVec4d__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec4d__SWIG_1")]
		public static extern IntPtr new_GfVec4d__SWIG_1(double jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec4d__SWIG_2")]
		public static extern IntPtr new_GfVec4d__SWIG_2(double jarg1, double jarg2, double jarg3, double jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec4d__SWIG_4")]
		public static extern IntPtr new_GfVec4d__SWIG_4(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec4d__SWIG_5")]
		public static extern IntPtr new_GfVec4d__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec4d__SWIG_6")]
		public static extern IntPtr new_GfVec4d__SWIG_6(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4d_XAxis")]
		public static extern IntPtr GfVec4d_XAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4d_YAxis")]
		public static extern IntPtr GfVec4d_YAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4d_ZAxis")]
		public static extern IntPtr GfVec4d_ZAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4d_WAxis")]
		public static extern IntPtr GfVec4d_WAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4d_Axis")]
		public static extern IntPtr GfVec4d_Axis(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4d_Set")]
		public static extern IntPtr GfVec4d_Set(HandleRef jarg1, double jarg2, double jarg3, double jarg4, double jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4d_GetProjection")]
		public static extern IntPtr GfVec4d_GetProjection(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4d_GetComplement")]
		public static extern IntPtr GfVec4d_GetComplement(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4d_GetLengthSq")]
		public static extern double GfVec4d_GetLengthSq(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4d_GetLength")]
		public static extern double GfVec4d_GetLength(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4d_Normalize__SWIG_0")]
		public static extern double GfVec4d_Normalize__SWIG_0(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4d_Normalize__SWIG_1")]
		public static extern double GfVec4d_Normalize__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4d_GetNormalized__SWIG_0")]
		public static extern IntPtr GfVec4d_GetNormalized__SWIG_0(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4d_GetNormalized__SWIG_1")]
		public static extern IntPtr GfVec4d_GetNormalized__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4d_Equals")]
		public static extern bool GfVec4d_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4d_GetHashCode")]
		public static extern int GfVec4d_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4d_GetValue")]
		public static extern double GfVec4d_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4d_SetValue")]
		public static extern void GfVec4d_SetValue(HandleRef jarg1, int jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfVec4d")]
		public static extern void delete_GfVec4d(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCompMult__SWIG_8")]
		public static extern IntPtr GfCompMult__SWIG_8(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCompDiv__SWIG_8")]
		public static extern IntPtr GfCompDiv__SWIG_8(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDot__SWIG_15")]
		public static extern double GfDot__SWIG_15(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetLength__SWIG_6")]
		public static extern double GfGetLength__SWIG_6(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfNormalize__SWIG_12")]
		public static extern double GfNormalize__SWIG_12(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfNormalize__SWIG_13")]
		public static extern double GfNormalize__SWIG_13(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetNormalized__SWIG_12")]
		public static extern IntPtr GfGetNormalized__SWIG_12(HandleRef jarg1, double jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetNormalized__SWIG_13")]
		public static extern IntPtr GfGetNormalized__SWIG_13(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetProjection__SWIG_6")]
		public static extern IntPtr GfGetProjection__SWIG_6(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetComplement__SWIG_6")]
		public static extern IntPtr GfGetComplement__SWIG_6(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfIsClose__SWIG_13")]
		public static extern bool GfIsClose__SWIG_13(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4fVector_Clear")]
		public static extern void GfVec4fVector_Clear(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4fVector_Add")]
		public static extern void GfVec4fVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4fVector_size")]
		public static extern uint GfVec4fVector_size(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4fVector_capacity")]
		public static extern uint GfVec4fVector_capacity(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4fVector_reserve")]
		public static extern void GfVec4fVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec4fVector__SWIG_0")]
		public static extern IntPtr new_GfVec4fVector__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec4fVector__SWIG_1")]
		public static extern IntPtr new_GfVec4fVector__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec4fVector__SWIG_2")]
		public static extern IntPtr new_GfVec4fVector__SWIG_2(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4fVector_getitemcopy")]
		public static extern IntPtr GfVec4fVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4fVector_getitem")]
		public static extern IntPtr GfVec4fVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4fVector_setitem")]
		public static extern void GfVec4fVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4fVector_AddRange")]
		public static extern void GfVec4fVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4fVector_GetRange")]
		public static extern IntPtr GfVec4fVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4fVector_Insert")]
		public static extern void GfVec4fVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4fVector_InsertRange")]
		public static extern void GfVec4fVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4fVector_RemoveAt")]
		public static extern void GfVec4fVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4fVector_RemoveRange")]
		public static extern void GfVec4fVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4fVector_Repeat")]
		public static extern IntPtr GfVec4fVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4fVector_Reverse__SWIG_0")]
		public static extern void GfVec4fVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4fVector_Reverse__SWIG_1")]
		public static extern void GfVec4fVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4fVector_SetRange")]
		public static extern void GfVec4fVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfVec4fVector")]
		public static extern void delete_GfVec4fVector(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec4f__SWIG_0")]
		public static extern IntPtr new_GfVec4f__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec4f__SWIG_1")]
		public static extern IntPtr new_GfVec4f__SWIG_1(float jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec4f__SWIG_2")]
		public static extern IntPtr new_GfVec4f__SWIG_2(float jarg1, float jarg2, float jarg3, float jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec4f__SWIG_4")]
		public static extern IntPtr new_GfVec4f__SWIG_4(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec4f__SWIG_5")]
		public static extern IntPtr new_GfVec4f__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec4f__SWIG_6")]
		public static extern IntPtr new_GfVec4f__SWIG_6(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4f_XAxis")]
		public static extern IntPtr GfVec4f_XAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4f_YAxis")]
		public static extern IntPtr GfVec4f_YAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4f_ZAxis")]
		public static extern IntPtr GfVec4f_ZAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4f_WAxis")]
		public static extern IntPtr GfVec4f_WAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4f_Axis")]
		public static extern IntPtr GfVec4f_Axis(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4f_Set")]
		public static extern IntPtr GfVec4f_Set(HandleRef jarg1, float jarg2, float jarg3, float jarg4, float jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4f_GetProjection")]
		public static extern IntPtr GfVec4f_GetProjection(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4f_GetComplement")]
		public static extern IntPtr GfVec4f_GetComplement(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4f_GetLengthSq")]
		public static extern float GfVec4f_GetLengthSq(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4f_GetLength")]
		public static extern float GfVec4f_GetLength(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4f_Normalize__SWIG_0")]
		public static extern float GfVec4f_Normalize__SWIG_0(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4f_Normalize__SWIG_1")]
		public static extern float GfVec4f_Normalize__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4f_GetNormalized__SWIG_0")]
		public static extern IntPtr GfVec4f_GetNormalized__SWIG_0(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4f_GetNormalized__SWIG_1")]
		public static extern IntPtr GfVec4f_GetNormalized__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4f_Equals")]
		public static extern bool GfVec4f_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4f_GetHashCode")]
		public static extern int GfVec4f_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4f_GetValue")]
		public static extern float GfVec4f_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4f_SetValue")]
		public static extern void GfVec4f_SetValue(HandleRef jarg1, int jarg2, float jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfVec4f")]
		public static extern void delete_GfVec4f(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCompMult__SWIG_9")]
		public static extern IntPtr GfCompMult__SWIG_9(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCompDiv__SWIG_9")]
		public static extern IntPtr GfCompDiv__SWIG_9(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDot__SWIG_16")]
		public static extern float GfDot__SWIG_16(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetLength__SWIG_7")]
		public static extern float GfGetLength__SWIG_7(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfNormalize__SWIG_14")]
		public static extern float GfNormalize__SWIG_14(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfNormalize__SWIG_15")]
		public static extern float GfNormalize__SWIG_15(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetNormalized__SWIG_14")]
		public static extern IntPtr GfGetNormalized__SWIG_14(HandleRef jarg1, float jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetNormalized__SWIG_15")]
		public static extern IntPtr GfGetNormalized__SWIG_15(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetProjection__SWIG_7")]
		public static extern IntPtr GfGetProjection__SWIG_7(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetComplement__SWIG_7")]
		public static extern IntPtr GfGetComplement__SWIG_7(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfIsClose__SWIG_14")]
		public static extern bool GfIsClose__SWIG_14(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec4h__SWIG_0")]
		public static extern IntPtr new_GfVec4h__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec4h__SWIG_1")]
		public static extern IntPtr new_GfVec4h__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec4h__SWIG_2")]
		public static extern IntPtr new_GfVec4h__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec4h__SWIG_4")]
		public static extern IntPtr new_GfVec4h__SWIG_4(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec4h__SWIG_5")]
		public static extern IntPtr new_GfVec4h__SWIG_5(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec4h__SWIG_6")]
		public static extern IntPtr new_GfVec4h__SWIG_6(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4h_XAxis")]
		public static extern IntPtr GfVec4h_XAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4h_YAxis")]
		public static extern IntPtr GfVec4h_YAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4h_ZAxis")]
		public static extern IntPtr GfVec4h_ZAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4h_WAxis")]
		public static extern IntPtr GfVec4h_WAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4h_Axis")]
		public static extern IntPtr GfVec4h_Axis(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4h_Set__SWIG_0")]
		public static extern IntPtr GfVec4h_Set__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4h_Set__SWIG_1")]
		public static extern IntPtr GfVec4h_Set__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4h_GetProjection")]
		public static extern IntPtr GfVec4h_GetProjection(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4h_GetComplement")]
		public static extern IntPtr GfVec4h_GetComplement(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4h_GetLengthSq")]
		public static extern IntPtr GfVec4h_GetLengthSq(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4h_GetLength")]
		public static extern IntPtr GfVec4h_GetLength(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4h_Normalize__SWIG_0")]
		public static extern IntPtr GfVec4h_Normalize__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4h_Normalize__SWIG_1")]
		public static extern IntPtr GfVec4h_Normalize__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4h_GetNormalized__SWIG_0")]
		public static extern IntPtr GfVec4h_GetNormalized__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4h_GetNormalized__SWIG_1")]
		public static extern IntPtr GfVec4h_GetNormalized__SWIG_1(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4h_Equals")]
		public static extern bool GfVec4h_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4h_GetHashCode")]
		public static extern int GfVec4h_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4h_GetValue")]
		public static extern float GfVec4h_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4h_SetValue")]
		public static extern void GfVec4h_SetValue(HandleRef jarg1, int jarg2, float jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfVec4h")]
		public static extern void delete_GfVec4h(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCompMult__SWIG_10")]
		public static extern IntPtr GfCompMult__SWIG_10(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCompDiv__SWIG_10")]
		public static extern IntPtr GfCompDiv__SWIG_10(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDot__SWIG_17")]
		public static extern IntPtr GfDot__SWIG_17(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetLength__SWIG_8")]
		public static extern IntPtr GfGetLength__SWIG_8(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfNormalize__SWIG_16")]
		public static extern IntPtr GfNormalize__SWIG_16(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfNormalize__SWIG_17")]
		public static extern IntPtr GfNormalize__SWIG_17(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetNormalized__SWIG_16")]
		public static extern IntPtr GfGetNormalized__SWIG_16(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetNormalized__SWIG_17")]
		public static extern IntPtr GfGetNormalized__SWIG_17(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetProjection__SWIG_8")]
		public static extern IntPtr GfGetProjection__SWIG_8(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfGetComplement__SWIG_8")]
		public static extern IntPtr GfGetComplement__SWIG_8(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfIsClose__SWIG_15")]
		public static extern bool GfIsClose__SWIG_15(HandleRef jarg1, HandleRef jarg2, double jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec4i__SWIG_0")]
		public static extern IntPtr new_GfVec4i__SWIG_0();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec4i__SWIG_1")]
		public static extern IntPtr new_GfVec4i__SWIG_1(int jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_new_GfVec4i__SWIG_2")]
		public static extern IntPtr new_GfVec4i__SWIG_2(int jarg1, int jarg2, int jarg3, int jarg4);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4i_XAxis")]
		public static extern IntPtr GfVec4i_XAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4i_YAxis")]
		public static extern IntPtr GfVec4i_YAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4i_ZAxis")]
		public static extern IntPtr GfVec4i_ZAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4i_WAxis")]
		public static extern IntPtr GfVec4i_WAxis();

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4i_Axis")]
		public static extern IntPtr GfVec4i_Axis(uint jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4i_Set")]
		public static extern IntPtr GfVec4i_Set(HandleRef jarg1, int jarg2, int jarg3, int jarg4, int jarg5);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4i_GetProjection")]
		public static extern IntPtr GfVec4i_GetProjection(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4i_GetComplement")]
		public static extern IntPtr GfVec4i_GetComplement(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4i_GetLengthSq")]
		public static extern int GfVec4i_GetLengthSq(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4i_Equals")]
		public static extern bool GfVec4i_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4i_GetHashCode")]
		public static extern int GfVec4i_GetHashCode(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4i_GetValue")]
		public static extern int GfVec4i_GetValue(HandleRef jarg1, int jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfVec4i_SetValue")]
		public static extern void GfVec4i_SetValue(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_delete_GfVec4i")]
		public static extern void delete_GfVec4i(HandleRef jarg1);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCompMult__SWIG_11")]
		public static extern IntPtr GfCompMult__SWIG_11(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfCompDiv__SWIG_11")]
		public static extern IntPtr GfCompDiv__SWIG_11(HandleRef jarg1, HandleRef jarg2);

		[DllImport("UsdCs", EntryPoint = "CSharp_pxr_GfDot__SWIG_18")]
		public static extern int GfDot__SWIG_18(HandleRef jarg1, HandleRef jarg2);
	}
}
