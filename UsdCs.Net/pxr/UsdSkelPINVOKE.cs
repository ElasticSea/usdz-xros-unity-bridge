using System;
using System.Runtime.InteropServices;

namespace pxr
{
	internal class UsdSkelPINVOKE
	{
		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			[DllImport(UsdDll.USD_EXPORT_NAME)]
			public static extern void SWIGRegisterStringCallback_UsdSkel(SWIGStringDelegate stringDelegate);

			[MonoPInvokeCallback]
			private static string CreateString(string cString)
			{
				return cString;
			}

			static SWIGStringHelper()
			{
				stringDelegate = CreateString;
				SWIGRegisterStringCallback_UsdSkel(stringDelegate);
			}
		}

		public class SWIGPendingException : UsdCsPINVOKE.SWIGPendingException
		{
		}

		protected static SWIGStringHelper swigStringHelper;

		static UsdSkelPINVOKE()
		{
			swigStringHelper = new SWIGStringHelper();
		}

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelAnimMapper__SWIG_0")]
		public static extern IntPtr new_UsdSkelAnimMapper__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelAnimMapper__SWIG_1")]
		public static extern IntPtr new_UsdSkelAnimMapper__SWIG_1(uint jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelAnimMapper__SWIG_2")]
		public static extern IntPtr new_UsdSkelAnimMapper__SWIG_2(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelAnimMapper__SWIG_3")]
		public static extern IntPtr new_UsdSkelAnimMapper__SWIG_3(HandleRef jarg1, uint jarg2, HandleRef jarg3, uint jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimMapper_Remap__SWIG_3")]
		public static extern bool UsdSkelAnimMapper_Remap__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimMapper_Remap__SWIG_4")]
		public static extern bool UsdSkelAnimMapper_Remap__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimMapper_Remap__SWIG_5")]
		public static extern bool UsdSkelAnimMapper_Remap__SWIG_5(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimMapper_IsIdentity")]
		public static extern bool UsdSkelAnimMapper_IsIdentity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimMapper_IsSparse")]
		public static extern bool UsdSkelAnimMapper_IsSparse(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimMapper_IsNull")]
		public static extern bool UsdSkelAnimMapper_IsNull(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimMapper_size")]
		public static extern uint UsdSkelAnimMapper_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdSkelAnimMapper")]
		public static extern void delete_UsdSkelAnimMapper(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplRefPtrVector_Clear")]
		public static extern void UsdSkel_AnimQueryImplRefPtrVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplRefPtrVector_Add")]
		public static extern void UsdSkel_AnimQueryImplRefPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplRefPtrVector_size")]
		public static extern uint UsdSkel_AnimQueryImplRefPtrVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplRefPtrVector_capacity")]
		public static extern uint UsdSkel_AnimQueryImplRefPtrVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplRefPtrVector_reserve")]
		public static extern void UsdSkel_AnimQueryImplRefPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkel_AnimQueryImplRefPtrVector__SWIG_0")]
		public static extern IntPtr new_UsdSkel_AnimQueryImplRefPtrVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkel_AnimQueryImplRefPtrVector__SWIG_1")]
		public static extern IntPtr new_UsdSkel_AnimQueryImplRefPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkel_AnimQueryImplRefPtrVector__SWIG_2")]
		public static extern IntPtr new_UsdSkel_AnimQueryImplRefPtrVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplRefPtrVector_getitemcopy")]
		public static extern IntPtr UsdSkel_AnimQueryImplRefPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplRefPtrVector_getitem")]
		public static extern IntPtr UsdSkel_AnimQueryImplRefPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplRefPtrVector_setitem")]
		public static extern void UsdSkel_AnimQueryImplRefPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplRefPtrVector_AddRange")]
		public static extern void UsdSkel_AnimQueryImplRefPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplRefPtrVector_GetRange")]
		public static extern IntPtr UsdSkel_AnimQueryImplRefPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplRefPtrVector_Insert")]
		public static extern void UsdSkel_AnimQueryImplRefPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplRefPtrVector_InsertRange")]
		public static extern void UsdSkel_AnimQueryImplRefPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplRefPtrVector_RemoveAt")]
		public static extern void UsdSkel_AnimQueryImplRefPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplRefPtrVector_RemoveRange")]
		public static extern void UsdSkel_AnimQueryImplRefPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplRefPtrVector_Repeat")]
		public static extern IntPtr UsdSkel_AnimQueryImplRefPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplRefPtrVector_Reverse__SWIG_0")]
		public static extern void UsdSkel_AnimQueryImplRefPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplRefPtrVector_Reverse__SWIG_1")]
		public static extern void UsdSkel_AnimQueryImplRefPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplRefPtrVector_SetRange")]
		public static extern void UsdSkel_AnimQueryImplRefPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdSkel_AnimQueryImplRefPtrVector")]
		public static extern void delete_UsdSkel_AnimQueryImplRefPtrVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplConstRefPtrVector_Clear")]
		public static extern void UsdSkel_AnimQueryImplConstRefPtrVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplConstRefPtrVector_Add")]
		public static extern void UsdSkel_AnimQueryImplConstRefPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplConstRefPtrVector_size")]
		public static extern uint UsdSkel_AnimQueryImplConstRefPtrVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplConstRefPtrVector_capacity")]
		public static extern uint UsdSkel_AnimQueryImplConstRefPtrVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplConstRefPtrVector_reserve")]
		public static extern void UsdSkel_AnimQueryImplConstRefPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkel_AnimQueryImplConstRefPtrVector__SWIG_0")]
		public static extern IntPtr new_UsdSkel_AnimQueryImplConstRefPtrVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkel_AnimQueryImplConstRefPtrVector__SWIG_1")]
		public static extern IntPtr new_UsdSkel_AnimQueryImplConstRefPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkel_AnimQueryImplConstRefPtrVector__SWIG_2")]
		public static extern IntPtr new_UsdSkel_AnimQueryImplConstRefPtrVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplConstRefPtrVector_getitemcopy")]
		public static extern IntPtr UsdSkel_AnimQueryImplConstRefPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplConstRefPtrVector_getitem")]
		public static extern IntPtr UsdSkel_AnimQueryImplConstRefPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplConstRefPtrVector_setitem")]
		public static extern void UsdSkel_AnimQueryImplConstRefPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplConstRefPtrVector_AddRange")]
		public static extern void UsdSkel_AnimQueryImplConstRefPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplConstRefPtrVector_GetRange")]
		public static extern IntPtr UsdSkel_AnimQueryImplConstRefPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplConstRefPtrVector_Insert")]
		public static extern void UsdSkel_AnimQueryImplConstRefPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplConstRefPtrVector_InsertRange")]
		public static extern void UsdSkel_AnimQueryImplConstRefPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplConstRefPtrVector_RemoveAt")]
		public static extern void UsdSkel_AnimQueryImplConstRefPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplConstRefPtrVector_RemoveRange")]
		public static extern void UsdSkel_AnimQueryImplConstRefPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplConstRefPtrVector_Repeat")]
		public static extern IntPtr UsdSkel_AnimQueryImplConstRefPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplConstRefPtrVector_Reverse__SWIG_0")]
		public static extern void UsdSkel_AnimQueryImplConstRefPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplConstRefPtrVector_Reverse__SWIG_1")]
		public static extern void UsdSkel_AnimQueryImplConstRefPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_AnimQueryImplConstRefPtrVector_SetRange")]
		public static extern void UsdSkel_AnimQueryImplConstRefPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdSkel_AnimQueryImplConstRefPtrVector")]
		public static extern void delete_UsdSkel_AnimQueryImplConstRefPtrVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelAnimQuery")]
		public static extern IntPtr new_UsdSkelAnimQuery();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimQuery_IsValid")]
		public static extern bool UsdSkelAnimQuery_IsValid(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimQuery_GetPrim")]
		public static extern IntPtr UsdSkelAnimQuery_GetPrim(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimQuery_ComputeJointLocalTransformComponents__SWIG_0")]
		public static extern bool UsdSkelAnimQuery_ComputeJointLocalTransformComponents__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimQuery_ComputeJointLocalTransformComponents__SWIG_1")]
		public static extern bool UsdSkelAnimQuery_ComputeJointLocalTransformComponents__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimQuery_ComputeBlendShapeWeights__SWIG_0")]
		public static extern bool UsdSkelAnimQuery_ComputeBlendShapeWeights__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimQuery_ComputeBlendShapeWeights__SWIG_1")]
		public static extern bool UsdSkelAnimQuery_ComputeBlendShapeWeights__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimQuery_GetJointTransformTimeSamples")]
		public static extern bool UsdSkelAnimQuery_GetJointTransformTimeSamples(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimQuery_GetJointTransformTimeSamplesInInterval")]
		public static extern bool UsdSkelAnimQuery_GetJointTransformTimeSamplesInInterval(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimQuery_GetJointTransformAttributes")]
		public static extern bool UsdSkelAnimQuery_GetJointTransformAttributes(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimQuery_JointTransformsMightBeTimeVarying")]
		public static extern bool UsdSkelAnimQuery_JointTransformsMightBeTimeVarying(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimQuery_GetBlendShapeWeightTimeSamples")]
		public static extern bool UsdSkelAnimQuery_GetBlendShapeWeightTimeSamples(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimQuery_GetBlendShapeWeightTimeSamplesInInterval")]
		public static extern bool UsdSkelAnimQuery_GetBlendShapeWeightTimeSamplesInInterval(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimQuery_GetBlendShapeWeightAttributes")]
		public static extern bool UsdSkelAnimQuery_GetBlendShapeWeightAttributes(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimQuery_BlendShapeWeightsMightBeTimeVarying")]
		public static extern bool UsdSkelAnimQuery_BlendShapeWeightsMightBeTimeVarying(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimQuery_GetJointOrder")]
		public static extern IntPtr UsdSkelAnimQuery_GetJointOrder(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimQuery_GetBlendShapeOrder")]
		public static extern IntPtr UsdSkelAnimQuery_GetBlendShapeOrder(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimQuery_GetDescription")]
		public static extern string UsdSkelAnimQuery_GetDescription(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdSkelAnimQuery")]
		public static extern void delete_UsdSkelAnimQuery(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelAnimation__SWIG_0")]
		public static extern IntPtr new_UsdSkelAnimation__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelAnimation__SWIG_1")]
		public static extern IntPtr new_UsdSkelAnimation__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelAnimation__SWIG_2")]
		public static extern IntPtr new_UsdSkelAnimation__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdSkelAnimation")]
		public static extern void delete_UsdSkelAnimation(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdSkelAnimation_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdSkelAnimation_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_Get")]
		public static extern IntPtr UsdSkelAnimation_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_Define")]
		public static extern IntPtr UsdSkelAnimation_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_GetJointsAttr")]
		public static extern IntPtr UsdSkelAnimation_GetJointsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_CreateJointsAttr__SWIG_0")]
		public static extern IntPtr UsdSkelAnimation_CreateJointsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_CreateJointsAttr__SWIG_1")]
		public static extern IntPtr UsdSkelAnimation_CreateJointsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_CreateJointsAttr__SWIG_2")]
		public static extern IntPtr UsdSkelAnimation_CreateJointsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_GetTranslationsAttr")]
		public static extern IntPtr UsdSkelAnimation_GetTranslationsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_CreateTranslationsAttr__SWIG_0")]
		public static extern IntPtr UsdSkelAnimation_CreateTranslationsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_CreateTranslationsAttr__SWIG_1")]
		public static extern IntPtr UsdSkelAnimation_CreateTranslationsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_CreateTranslationsAttr__SWIG_2")]
		public static extern IntPtr UsdSkelAnimation_CreateTranslationsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_GetRotationsAttr")]
		public static extern IntPtr UsdSkelAnimation_GetRotationsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_CreateRotationsAttr__SWIG_0")]
		public static extern IntPtr UsdSkelAnimation_CreateRotationsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_CreateRotationsAttr__SWIG_1")]
		public static extern IntPtr UsdSkelAnimation_CreateRotationsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_CreateRotationsAttr__SWIG_2")]
		public static extern IntPtr UsdSkelAnimation_CreateRotationsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_GetScalesAttr")]
		public static extern IntPtr UsdSkelAnimation_GetScalesAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_CreateScalesAttr__SWIG_0")]
		public static extern IntPtr UsdSkelAnimation_CreateScalesAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_CreateScalesAttr__SWIG_1")]
		public static extern IntPtr UsdSkelAnimation_CreateScalesAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_CreateScalesAttr__SWIG_2")]
		public static extern IntPtr UsdSkelAnimation_CreateScalesAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_GetBlendShapesAttr")]
		public static extern IntPtr UsdSkelAnimation_GetBlendShapesAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_CreateBlendShapesAttr__SWIG_0")]
		public static extern IntPtr UsdSkelAnimation_CreateBlendShapesAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_CreateBlendShapesAttr__SWIG_1")]
		public static extern IntPtr UsdSkelAnimation_CreateBlendShapesAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_CreateBlendShapesAttr__SWIG_2")]
		public static extern IntPtr UsdSkelAnimation_CreateBlendShapesAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_GetBlendShapeWeightsAttr")]
		public static extern IntPtr UsdSkelAnimation_GetBlendShapeWeightsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_CreateBlendShapeWeightsAttr__SWIG_0")]
		public static extern IntPtr UsdSkelAnimation_CreateBlendShapeWeightsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_CreateBlendShapeWeightsAttr__SWIG_1")]
		public static extern IntPtr UsdSkelAnimation_CreateBlendShapeWeightsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_CreateBlendShapeWeightsAttr__SWIG_2")]
		public static extern IntPtr UsdSkelAnimation_CreateBlendShapeWeightsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_GetTransforms__SWIG_0")]
		public static extern bool UsdSkelAnimation_GetTransforms__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_GetTransforms__SWIG_1")]
		public static extern bool UsdSkelAnimation_GetTransforms__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_SetTransforms__SWIG_0")]
		public static extern bool UsdSkelAnimation_SetTransforms__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_SetTransforms__SWIG_1")]
		public static extern bool UsdSkelAnimation_SetTransforms__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingVector_Clear")]
		public static extern void UsdSkelBindingVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingVector_Add")]
		public static extern void UsdSkelBindingVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingVector_size")]
		public static extern uint UsdSkelBindingVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingVector_capacity")]
		public static extern uint UsdSkelBindingVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingVector_reserve")]
		public static extern void UsdSkelBindingVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelBindingVector__SWIG_0")]
		public static extern IntPtr new_UsdSkelBindingVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelBindingVector__SWIG_1")]
		public static extern IntPtr new_UsdSkelBindingVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelBindingVector__SWIG_2")]
		public static extern IntPtr new_UsdSkelBindingVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingVector_getitemcopy")]
		public static extern IntPtr UsdSkelBindingVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingVector_getitem")]
		public static extern IntPtr UsdSkelBindingVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingVector_setitem")]
		public static extern void UsdSkelBindingVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingVector_AddRange")]
		public static extern void UsdSkelBindingVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingVector_GetRange")]
		public static extern IntPtr UsdSkelBindingVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingVector_Insert")]
		public static extern void UsdSkelBindingVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingVector_InsertRange")]
		public static extern void UsdSkelBindingVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingVector_RemoveAt")]
		public static extern void UsdSkelBindingVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingVector_RemoveRange")]
		public static extern void UsdSkelBindingVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingVector_Repeat")]
		public static extern IntPtr UsdSkelBindingVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingVector_Reverse__SWIG_0")]
		public static extern void UsdSkelBindingVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingVector_Reverse__SWIG_1")]
		public static extern void UsdSkelBindingVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingVector_SetRange")]
		public static extern void UsdSkelBindingVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdSkelBindingVector")]
		public static extern void delete_UsdSkelBindingVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQueryVector_Clear")]
		public static extern void UsdSkelSkinningQueryVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQueryVector_Add")]
		public static extern void UsdSkelSkinningQueryVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQueryVector_size")]
		public static extern uint UsdSkelSkinningQueryVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQueryVector_capacity")]
		public static extern uint UsdSkelSkinningQueryVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQueryVector_reserve")]
		public static extern void UsdSkelSkinningQueryVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelSkinningQueryVector__SWIG_0")]
		public static extern IntPtr new_UsdSkelSkinningQueryVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelSkinningQueryVector__SWIG_1")]
		public static extern IntPtr new_UsdSkelSkinningQueryVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelSkinningQueryVector__SWIG_2")]
		public static extern IntPtr new_UsdSkelSkinningQueryVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQueryVector_getitemcopy")]
		public static extern IntPtr UsdSkelSkinningQueryVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQueryVector_getitem")]
		public static extern IntPtr UsdSkelSkinningQueryVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQueryVector_setitem")]
		public static extern void UsdSkelSkinningQueryVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQueryVector_AddRange")]
		public static extern void UsdSkelSkinningQueryVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQueryVector_GetRange")]
		public static extern IntPtr UsdSkelSkinningQueryVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQueryVector_Insert")]
		public static extern void UsdSkelSkinningQueryVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQueryVector_InsertRange")]
		public static extern void UsdSkelSkinningQueryVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQueryVector_RemoveAt")]
		public static extern void UsdSkelSkinningQueryVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQueryVector_RemoveRange")]
		public static extern void UsdSkelSkinningQueryVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQueryVector_Repeat")]
		public static extern IntPtr UsdSkelSkinningQueryVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQueryVector_Reverse__SWIG_0")]
		public static extern void UsdSkelSkinningQueryVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQueryVector_Reverse__SWIG_1")]
		public static extern void UsdSkelSkinningQueryVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQueryVector_SetRange")]
		public static extern void UsdSkelSkinningQueryVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdSkelSkinningQueryVector")]
		public static extern void delete_UsdSkelSkinningQueryVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelBinding__SWIG_0")]
		public static extern IntPtr new_UsdSkelBinding__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelBinding__SWIG_1")]
		public static extern IntPtr new_UsdSkelBinding__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBinding_GetSkeleton")]
		public static extern IntPtr UsdSkelBinding_GetSkeleton(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBinding_GetSkinningTargets")]
		public static extern IntPtr UsdSkelBinding_GetSkinningTargets(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBinding_GetSkinningTargetsAsVector")]
		public static extern IntPtr UsdSkelBinding_GetSkinningTargetsAsVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdSkelBinding")]
		public static extern void delete_UsdSkelBinding(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelBindingAPI__SWIG_0")]
		public static extern IntPtr new_UsdSkelBindingAPI__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelBindingAPI__SWIG_1")]
		public static extern IntPtr new_UsdSkelBindingAPI__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelBindingAPI__SWIG_2")]
		public static extern IntPtr new_UsdSkelBindingAPI__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdSkelBindingAPI")]
		public static extern void delete_UsdSkelBindingAPI(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdSkelBindingAPI_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdSkelBindingAPI_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_Get")]
		public static extern IntPtr UsdSkelBindingAPI_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CanApply__SWIG_0")]
		public static extern bool UsdSkelBindingAPI_CanApply__SWIG_0(HandleRef jarg1, out string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CanApply__SWIG_1")]
		public static extern bool UsdSkelBindingAPI_CanApply__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_Apply")]
		public static extern IntPtr UsdSkelBindingAPI_Apply(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_GetSkinningMethodAttr")]
		public static extern IntPtr UsdSkelBindingAPI_GetSkinningMethodAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CreateSkinningMethodAttr__SWIG_0")]
		public static extern IntPtr UsdSkelBindingAPI_CreateSkinningMethodAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CreateSkinningMethodAttr__SWIG_1")]
		public static extern IntPtr UsdSkelBindingAPI_CreateSkinningMethodAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CreateSkinningMethodAttr__SWIG_2")]
		public static extern IntPtr UsdSkelBindingAPI_CreateSkinningMethodAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_GetGeomBindTransformAttr")]
		public static extern IntPtr UsdSkelBindingAPI_GetGeomBindTransformAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CreateGeomBindTransformAttr__SWIG_0")]
		public static extern IntPtr UsdSkelBindingAPI_CreateGeomBindTransformAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CreateGeomBindTransformAttr__SWIG_1")]
		public static extern IntPtr UsdSkelBindingAPI_CreateGeomBindTransformAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CreateGeomBindTransformAttr__SWIG_2")]
		public static extern IntPtr UsdSkelBindingAPI_CreateGeomBindTransformAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_GetJointsAttr")]
		public static extern IntPtr UsdSkelBindingAPI_GetJointsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CreateJointsAttr__SWIG_0")]
		public static extern IntPtr UsdSkelBindingAPI_CreateJointsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CreateJointsAttr__SWIG_1")]
		public static extern IntPtr UsdSkelBindingAPI_CreateJointsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CreateJointsAttr__SWIG_2")]
		public static extern IntPtr UsdSkelBindingAPI_CreateJointsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_GetJointIndicesAttr")]
		public static extern IntPtr UsdSkelBindingAPI_GetJointIndicesAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CreateJointIndicesAttr__SWIG_0")]
		public static extern IntPtr UsdSkelBindingAPI_CreateJointIndicesAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CreateJointIndicesAttr__SWIG_1")]
		public static extern IntPtr UsdSkelBindingAPI_CreateJointIndicesAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CreateJointIndicesAttr__SWIG_2")]
		public static extern IntPtr UsdSkelBindingAPI_CreateJointIndicesAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_GetJointWeightsAttr")]
		public static extern IntPtr UsdSkelBindingAPI_GetJointWeightsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CreateJointWeightsAttr__SWIG_0")]
		public static extern IntPtr UsdSkelBindingAPI_CreateJointWeightsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CreateJointWeightsAttr__SWIG_1")]
		public static extern IntPtr UsdSkelBindingAPI_CreateJointWeightsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CreateJointWeightsAttr__SWIG_2")]
		public static extern IntPtr UsdSkelBindingAPI_CreateJointWeightsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_GetBlendShapesAttr")]
		public static extern IntPtr UsdSkelBindingAPI_GetBlendShapesAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CreateBlendShapesAttr__SWIG_0")]
		public static extern IntPtr UsdSkelBindingAPI_CreateBlendShapesAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CreateBlendShapesAttr__SWIG_1")]
		public static extern IntPtr UsdSkelBindingAPI_CreateBlendShapesAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CreateBlendShapesAttr__SWIG_2")]
		public static extern IntPtr UsdSkelBindingAPI_CreateBlendShapesAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_GetAnimationSourceRel")]
		public static extern IntPtr UsdSkelBindingAPI_GetAnimationSourceRel(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CreateAnimationSourceRel")]
		public static extern IntPtr UsdSkelBindingAPI_CreateAnimationSourceRel(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_GetSkeletonRel")]
		public static extern IntPtr UsdSkelBindingAPI_GetSkeletonRel(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CreateSkeletonRel")]
		public static extern IntPtr UsdSkelBindingAPI_CreateSkeletonRel(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_GetBlendShapeTargetsRel")]
		public static extern IntPtr UsdSkelBindingAPI_GetBlendShapeTargetsRel(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CreateBlendShapeTargetsRel")]
		public static extern IntPtr UsdSkelBindingAPI_CreateBlendShapeTargetsRel(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_GetJointIndicesPrimvar")]
		public static extern IntPtr UsdSkelBindingAPI_GetJointIndicesPrimvar(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CreateJointIndicesPrimvar__SWIG_0")]
		public static extern IntPtr UsdSkelBindingAPI_CreateJointIndicesPrimvar__SWIG_0(HandleRef jarg1, bool jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CreateJointIndicesPrimvar__SWIG_1")]
		public static extern IntPtr UsdSkelBindingAPI_CreateJointIndicesPrimvar__SWIG_1(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_GetJointWeightsPrimvar")]
		public static extern IntPtr UsdSkelBindingAPI_GetJointWeightsPrimvar(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CreateJointWeightsPrimvar__SWIG_0")]
		public static extern IntPtr UsdSkelBindingAPI_CreateJointWeightsPrimvar__SWIG_0(HandleRef jarg1, bool jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_CreateJointWeightsPrimvar__SWIG_1")]
		public static extern IntPtr UsdSkelBindingAPI_CreateJointWeightsPrimvar__SWIG_1(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_SetRigidJointInfluence__SWIG_0")]
		public static extern bool UsdSkelBindingAPI_SetRigidJointInfluence__SWIG_0(HandleRef jarg1, int jarg2, float jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_SetRigidJointInfluence__SWIG_1")]
		public static extern bool UsdSkelBindingAPI_SetRigidJointInfluence__SWIG_1(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_GetSkeleton")]
		public static extern bool UsdSkelBindingAPI_GetSkeleton(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_GetAnimationSource")]
		public static extern bool UsdSkelBindingAPI_GetAnimationSource(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_GetInheritedSkeleton")]
		public static extern IntPtr UsdSkelBindingAPI_GetInheritedSkeleton(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_GetInheritedAnimationSource")]
		public static extern IntPtr UsdSkelBindingAPI_GetInheritedAnimationSource(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_ValidateJointIndices__SWIG_0")]
		public static extern bool UsdSkelBindingAPI_ValidateJointIndices__SWIG_0(HandleRef jarg1, uint jarg2, out string jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_ValidateJointIndices__SWIG_1")]
		public static extern bool UsdSkelBindingAPI_ValidateJointIndices__SWIG_1(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelBlendShape__SWIG_0")]
		public static extern IntPtr new_UsdSkelBlendShape__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelBlendShape__SWIG_1")]
		public static extern IntPtr new_UsdSkelBlendShape__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelBlendShape__SWIG_2")]
		public static extern IntPtr new_UsdSkelBlendShape__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdSkelBlendShape")]
		public static extern void delete_UsdSkelBlendShape(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBlendShape_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdSkelBlendShape_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBlendShape_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdSkelBlendShape_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBlendShape_Get")]
		public static extern IntPtr UsdSkelBlendShape_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBlendShape_Define")]
		public static extern IntPtr UsdSkelBlendShape_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBlendShape_GetOffsetsAttr")]
		public static extern IntPtr UsdSkelBlendShape_GetOffsetsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBlendShape_CreateOffsetsAttr__SWIG_0")]
		public static extern IntPtr UsdSkelBlendShape_CreateOffsetsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBlendShape_CreateOffsetsAttr__SWIG_1")]
		public static extern IntPtr UsdSkelBlendShape_CreateOffsetsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBlendShape_CreateOffsetsAttr__SWIG_2")]
		public static extern IntPtr UsdSkelBlendShape_CreateOffsetsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBlendShape_GetNormalOffsetsAttr")]
		public static extern IntPtr UsdSkelBlendShape_GetNormalOffsetsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBlendShape_CreateNormalOffsetsAttr__SWIG_0")]
		public static extern IntPtr UsdSkelBlendShape_CreateNormalOffsetsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBlendShape_CreateNormalOffsetsAttr__SWIG_1")]
		public static extern IntPtr UsdSkelBlendShape_CreateNormalOffsetsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBlendShape_CreateNormalOffsetsAttr__SWIG_2")]
		public static extern IntPtr UsdSkelBlendShape_CreateNormalOffsetsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBlendShape_GetPointIndicesAttr")]
		public static extern IntPtr UsdSkelBlendShape_GetPointIndicesAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBlendShape_CreatePointIndicesAttr__SWIG_0")]
		public static extern IntPtr UsdSkelBlendShape_CreatePointIndicesAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBlendShape_CreatePointIndicesAttr__SWIG_1")]
		public static extern IntPtr UsdSkelBlendShape_CreatePointIndicesAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBlendShape_CreatePointIndicesAttr__SWIG_2")]
		public static extern IntPtr UsdSkelBlendShape_CreatePointIndicesAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBlendShape_CreateInbetween")]
		public static extern IntPtr UsdSkelBlendShape_CreateInbetween(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBlendShape_GetInbetween")]
		public static extern IntPtr UsdSkelBlendShape_GetInbetween(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBlendShape_HasInbetween")]
		public static extern bool UsdSkelBlendShape_HasInbetween(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBlendShape_GetInbetweens")]
		public static extern IntPtr UsdSkelBlendShape_GetInbetweens(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBlendShape_GetAuthoredInbetweens")]
		public static extern IntPtr UsdSkelBlendShape_GetAuthoredInbetweens(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBlendShape_ValidatePointIndices__SWIG_0")]
		public static extern bool UsdSkelBlendShape_ValidatePointIndices__SWIG_0(HandleRef jarg1, uint jarg2, out string jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBlendShape_ValidatePointIndices__SWIG_1")]
		public static extern bool UsdSkelBlendShape_ValidatePointIndices__SWIG_1(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelCache")]
		public static extern IntPtr new_UsdSkelCache();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelCache_Clear")]
		public static extern void UsdSkelCache_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelCache_Populate")]
		public static extern bool UsdSkelCache_Populate(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelCache_GetSkelQuery")]
		public static extern IntPtr UsdSkelCache_GetSkelQuery(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelCache_GetAnimQuery__SWIG_0")]
		public static extern IntPtr UsdSkelCache_GetAnimQuery__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelCache_GetAnimQuery__SWIG_1")]
		public static extern IntPtr UsdSkelCache_GetAnimQuery__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelCache_GetSkinningQuery")]
		public static extern IntPtr UsdSkelCache_GetSkinningQuery(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelCache_ComputeSkelBindings")]
		public static extern bool UsdSkelCache_ComputeSkelBindings(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelCache_ComputeSkelBinding")]
		public static extern bool UsdSkelCache_ComputeSkelBinding(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdSkelCache")]
		public static extern void delete_UsdSkelCache(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShapeVector_Clear")]
		public static extern void UsdSkelInbetweenShapeVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShapeVector_Add")]
		public static extern void UsdSkelInbetweenShapeVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShapeVector_size")]
		public static extern uint UsdSkelInbetweenShapeVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShapeVector_capacity")]
		public static extern uint UsdSkelInbetweenShapeVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShapeVector_reserve")]
		public static extern void UsdSkelInbetweenShapeVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelInbetweenShapeVector__SWIG_0")]
		public static extern IntPtr new_UsdSkelInbetweenShapeVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelInbetweenShapeVector__SWIG_1")]
		public static extern IntPtr new_UsdSkelInbetweenShapeVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelInbetweenShapeVector__SWIG_2")]
		public static extern IntPtr new_UsdSkelInbetweenShapeVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShapeVector_getitemcopy")]
		public static extern IntPtr UsdSkelInbetweenShapeVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShapeVector_getitem")]
		public static extern IntPtr UsdSkelInbetweenShapeVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShapeVector_setitem")]
		public static extern void UsdSkelInbetweenShapeVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShapeVector_AddRange")]
		public static extern void UsdSkelInbetweenShapeVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShapeVector_GetRange")]
		public static extern IntPtr UsdSkelInbetweenShapeVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShapeVector_Insert")]
		public static extern void UsdSkelInbetweenShapeVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShapeVector_InsertRange")]
		public static extern void UsdSkelInbetweenShapeVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShapeVector_RemoveAt")]
		public static extern void UsdSkelInbetweenShapeVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShapeVector_RemoveRange")]
		public static extern void UsdSkelInbetweenShapeVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShapeVector_Repeat")]
		public static extern IntPtr UsdSkelInbetweenShapeVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShapeVector_Reverse__SWIG_0")]
		public static extern void UsdSkelInbetweenShapeVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShapeVector_Reverse__SWIG_1")]
		public static extern void UsdSkelInbetweenShapeVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShapeVector_SetRange")]
		public static extern void UsdSkelInbetweenShapeVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdSkelInbetweenShapeVector")]
		public static extern void delete_UsdSkelInbetweenShapeVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelInbetweenShape__SWIG_0")]
		public static extern IntPtr new_UsdSkelInbetweenShape__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelInbetweenShape__SWIG_1")]
		public static extern IntPtr new_UsdSkelInbetweenShape__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShape_GetWeight")]
		public static extern bool UsdSkelInbetweenShape_GetWeight(HandleRef jarg1, out float jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShape_SetWeight")]
		public static extern bool UsdSkelInbetweenShape_SetWeight(HandleRef jarg1, float jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShape_HasAuthoredWeight")]
		public static extern bool UsdSkelInbetweenShape_HasAuthoredWeight(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShape_GetOffsets")]
		public static extern bool UsdSkelInbetweenShape_GetOffsets(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShape_SetOffsets")]
		public static extern bool UsdSkelInbetweenShape_SetOffsets(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShape_GetNormalOffsetsAttr")]
		public static extern IntPtr UsdSkelInbetweenShape_GetNormalOffsetsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShape_CreateNormalOffsetsAttr__SWIG_0")]
		public static extern IntPtr UsdSkelInbetweenShape_CreateNormalOffsetsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShape_CreateNormalOffsetsAttr__SWIG_1")]
		public static extern IntPtr UsdSkelInbetweenShape_CreateNormalOffsetsAttr__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShape_GetNormalOffsets")]
		public static extern bool UsdSkelInbetweenShape_GetNormalOffsets(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShape_SetNormalOffsets")]
		public static extern bool UsdSkelInbetweenShape_SetNormalOffsets(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShape_IsInbetween")]
		public static extern bool UsdSkelInbetweenShape_IsInbetween(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShape_GetAttr")]
		public static extern IntPtr UsdSkelInbetweenShape_GetAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInbetweenShape_IsDefined")]
		public static extern bool UsdSkelInbetweenShape_IsDefined(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdSkelInbetweenShape")]
		public static extern void delete_UsdSkelInbetweenShape(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelPackedJointAnimation__SWIG_0")]
		public static extern IntPtr new_UsdSkelPackedJointAnimation__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelPackedJointAnimation__SWIG_1")]
		public static extern IntPtr new_UsdSkelPackedJointAnimation__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelPackedJointAnimation__SWIG_2")]
		public static extern IntPtr new_UsdSkelPackedJointAnimation__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdSkelPackedJointAnimation")]
		public static extern void delete_UsdSkelPackedJointAnimation(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelPackedJointAnimation_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdSkelPackedJointAnimation_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelPackedJointAnimation_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdSkelPackedJointAnimation_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelPackedJointAnimation_Get")]
		public static extern IntPtr UsdSkelPackedJointAnimation_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelPackedJointAnimation_Define")]
		public static extern IntPtr UsdSkelPackedJointAnimation_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelRoot__SWIG_0")]
		public static extern IntPtr new_UsdSkelRoot__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelRoot__SWIG_1")]
		public static extern IntPtr new_UsdSkelRoot__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelRoot__SWIG_2")]
		public static extern IntPtr new_UsdSkelRoot__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdSkelRoot")]
		public static extern void delete_UsdSkelRoot(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelRoot_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdSkelRoot_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelRoot_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdSkelRoot_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelRoot_Get")]
		public static extern IntPtr UsdSkelRoot_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelRoot_Define")]
		public static extern IntPtr UsdSkelRoot_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelRoot_Find")]
		public static extern IntPtr UsdSkelRoot_Find(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelSkeleton__SWIG_0")]
		public static extern IntPtr new_UsdSkelSkeleton__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelSkeleton__SWIG_1")]
		public static extern IntPtr new_UsdSkelSkeleton__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelSkeleton__SWIG_2")]
		public static extern IntPtr new_UsdSkelSkeleton__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdSkelSkeleton")]
		public static extern void delete_UsdSkelSkeleton(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeleton_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdSkelSkeleton_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeleton_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdSkelSkeleton_GetSchemaAttributeNames__SWIG_1();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeleton_Get")]
		public static extern IntPtr UsdSkelSkeleton_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeleton_Define")]
		public static extern IntPtr UsdSkelSkeleton_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeleton_GetJointsAttr")]
		public static extern IntPtr UsdSkelSkeleton_GetJointsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeleton_CreateJointsAttr__SWIG_0")]
		public static extern IntPtr UsdSkelSkeleton_CreateJointsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeleton_CreateJointsAttr__SWIG_1")]
		public static extern IntPtr UsdSkelSkeleton_CreateJointsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeleton_CreateJointsAttr__SWIG_2")]
		public static extern IntPtr UsdSkelSkeleton_CreateJointsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeleton_GetJointNamesAttr")]
		public static extern IntPtr UsdSkelSkeleton_GetJointNamesAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeleton_CreateJointNamesAttr__SWIG_0")]
		public static extern IntPtr UsdSkelSkeleton_CreateJointNamesAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeleton_CreateJointNamesAttr__SWIG_1")]
		public static extern IntPtr UsdSkelSkeleton_CreateJointNamesAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeleton_CreateJointNamesAttr__SWIG_2")]
		public static extern IntPtr UsdSkelSkeleton_CreateJointNamesAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeleton_GetBindTransformsAttr")]
		public static extern IntPtr UsdSkelSkeleton_GetBindTransformsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeleton_CreateBindTransformsAttr__SWIG_0")]
		public static extern IntPtr UsdSkelSkeleton_CreateBindTransformsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeleton_CreateBindTransformsAttr__SWIG_1")]
		public static extern IntPtr UsdSkelSkeleton_CreateBindTransformsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeleton_CreateBindTransformsAttr__SWIG_2")]
		public static extern IntPtr UsdSkelSkeleton_CreateBindTransformsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeleton_GetRestTransformsAttr")]
		public static extern IntPtr UsdSkelSkeleton_GetRestTransformsAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeleton_CreateRestTransformsAttr__SWIG_0")]
		public static extern IntPtr UsdSkelSkeleton_CreateRestTransformsAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeleton_CreateRestTransformsAttr__SWIG_1")]
		public static extern IntPtr UsdSkelSkeleton_CreateRestTransformsAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeleton_CreateRestTransformsAttr__SWIG_2")]
		public static extern IntPtr UsdSkelSkeleton_CreateRestTransformsAttr__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionRefPtrVector_Clear")]
		public static extern void UsdSkel_SkelDefinitionRefPtrVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionRefPtrVector_Add")]
		public static extern void UsdSkel_SkelDefinitionRefPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionRefPtrVector_size")]
		public static extern uint UsdSkel_SkelDefinitionRefPtrVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionRefPtrVector_capacity")]
		public static extern uint UsdSkel_SkelDefinitionRefPtrVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionRefPtrVector_reserve")]
		public static extern void UsdSkel_SkelDefinitionRefPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkel_SkelDefinitionRefPtrVector__SWIG_0")]
		public static extern IntPtr new_UsdSkel_SkelDefinitionRefPtrVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkel_SkelDefinitionRefPtrVector__SWIG_1")]
		public static extern IntPtr new_UsdSkel_SkelDefinitionRefPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkel_SkelDefinitionRefPtrVector__SWIG_2")]
		public static extern IntPtr new_UsdSkel_SkelDefinitionRefPtrVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionRefPtrVector_getitemcopy")]
		public static extern IntPtr UsdSkel_SkelDefinitionRefPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionRefPtrVector_getitem")]
		public static extern IntPtr UsdSkel_SkelDefinitionRefPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionRefPtrVector_setitem")]
		public static extern void UsdSkel_SkelDefinitionRefPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionRefPtrVector_AddRange")]
		public static extern void UsdSkel_SkelDefinitionRefPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionRefPtrVector_GetRange")]
		public static extern IntPtr UsdSkel_SkelDefinitionRefPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionRefPtrVector_Insert")]
		public static extern void UsdSkel_SkelDefinitionRefPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionRefPtrVector_InsertRange")]
		public static extern void UsdSkel_SkelDefinitionRefPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionRefPtrVector_RemoveAt")]
		public static extern void UsdSkel_SkelDefinitionRefPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionRefPtrVector_RemoveRange")]
		public static extern void UsdSkel_SkelDefinitionRefPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionRefPtrVector_Repeat")]
		public static extern IntPtr UsdSkel_SkelDefinitionRefPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionRefPtrVector_Reverse__SWIG_0")]
		public static extern void UsdSkel_SkelDefinitionRefPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionRefPtrVector_Reverse__SWIG_1")]
		public static extern void UsdSkel_SkelDefinitionRefPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionRefPtrVector_SetRange")]
		public static extern void UsdSkel_SkelDefinitionRefPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdSkel_SkelDefinitionRefPtrVector")]
		public static extern void delete_UsdSkel_SkelDefinitionRefPtrVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionConstRefPtrVector_Clear")]
		public static extern void UsdSkel_SkelDefinitionConstRefPtrVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionConstRefPtrVector_Add")]
		public static extern void UsdSkel_SkelDefinitionConstRefPtrVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionConstRefPtrVector_size")]
		public static extern uint UsdSkel_SkelDefinitionConstRefPtrVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionConstRefPtrVector_capacity")]
		public static extern uint UsdSkel_SkelDefinitionConstRefPtrVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionConstRefPtrVector_reserve")]
		public static extern void UsdSkel_SkelDefinitionConstRefPtrVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkel_SkelDefinitionConstRefPtrVector__SWIG_0")]
		public static extern IntPtr new_UsdSkel_SkelDefinitionConstRefPtrVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkel_SkelDefinitionConstRefPtrVector__SWIG_1")]
		public static extern IntPtr new_UsdSkel_SkelDefinitionConstRefPtrVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkel_SkelDefinitionConstRefPtrVector__SWIG_2")]
		public static extern IntPtr new_UsdSkel_SkelDefinitionConstRefPtrVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionConstRefPtrVector_getitemcopy")]
		public static extern IntPtr UsdSkel_SkelDefinitionConstRefPtrVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionConstRefPtrVector_getitem")]
		public static extern IntPtr UsdSkel_SkelDefinitionConstRefPtrVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionConstRefPtrVector_setitem")]
		public static extern void UsdSkel_SkelDefinitionConstRefPtrVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionConstRefPtrVector_AddRange")]
		public static extern void UsdSkel_SkelDefinitionConstRefPtrVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionConstRefPtrVector_GetRange")]
		public static extern IntPtr UsdSkel_SkelDefinitionConstRefPtrVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionConstRefPtrVector_Insert")]
		public static extern void UsdSkel_SkelDefinitionConstRefPtrVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionConstRefPtrVector_InsertRange")]
		public static extern void UsdSkel_SkelDefinitionConstRefPtrVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionConstRefPtrVector_RemoveAt")]
		public static extern void UsdSkel_SkelDefinitionConstRefPtrVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionConstRefPtrVector_RemoveRange")]
		public static extern void UsdSkel_SkelDefinitionConstRefPtrVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionConstRefPtrVector_Repeat")]
		public static extern IntPtr UsdSkel_SkelDefinitionConstRefPtrVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionConstRefPtrVector_Reverse__SWIG_0")]
		public static extern void UsdSkel_SkelDefinitionConstRefPtrVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionConstRefPtrVector_Reverse__SWIG_1")]
		public static extern void UsdSkel_SkelDefinitionConstRefPtrVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkel_SkelDefinitionConstRefPtrVector_SetRange")]
		public static extern void UsdSkel_SkelDefinitionConstRefPtrVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdSkel_SkelDefinitionConstRefPtrVector")]
		public static extern void delete_UsdSkel_SkelDefinitionConstRefPtrVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelSkeletonQuery")]
		public static extern IntPtr new_UsdSkelSkeletonQuery();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeletonQuery_IsValid")]
		public static extern bool UsdSkelSkeletonQuery_IsValid(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeletonQuery_HasBindPose")]
		public static extern bool UsdSkelSkeletonQuery_HasBindPose(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeletonQuery_HasRestPose")]
		public static extern bool UsdSkelSkeletonQuery_HasRestPose(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeletonQuery_GetPrim")]
		public static extern IntPtr UsdSkelSkeletonQuery_GetPrim(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeletonQuery_GetSkeleton")]
		public static extern IntPtr UsdSkelSkeletonQuery_GetSkeleton(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeletonQuery_GetAnimQuery")]
		public static extern IntPtr UsdSkelSkeletonQuery_GetAnimQuery(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeletonQuery_GetTopology")]
		public static extern IntPtr UsdSkelSkeletonQuery_GetTopology(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeletonQuery_GetMapper")]
		public static extern IntPtr UsdSkelSkeletonQuery_GetMapper(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeletonQuery_GetJointOrder")]
		public static extern IntPtr UsdSkelSkeletonQuery_GetJointOrder(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeletonQuery_GetDescription")]
		public static extern string UsdSkelSkeletonQuery_GetDescription(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeletonQuery_ComputeJointLocalTransforms__SWIG_2")]
		public static extern bool UsdSkelSkeletonQuery_ComputeJointLocalTransforms__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, bool jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeletonQuery_ComputeJointLocalTransforms__SWIG_3")]
		public static extern bool UsdSkelSkeletonQuery_ComputeJointLocalTransforms__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeletonQuery_GetJointWorldBindTransforms")]
		public static extern bool UsdSkelSkeletonQuery_GetJointWorldBindTransforms(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdSkelSkeletonQuery")]
		public static extern void delete_UsdSkelSkeletonQuery(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelSkinningQuery__SWIG_0")]
		public static extern IntPtr new_UsdSkelSkinningQuery__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelSkinningQuery__SWIG_1")]
		public static extern IntPtr new_UsdSkelSkinningQuery__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, HandleRef jarg6, HandleRef jarg7, HandleRef jarg8, HandleRef jarg9, HandleRef jarg10);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_IsValid")]
		public static extern bool UsdSkelSkinningQuery_IsValid(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_GetPrim")]
		public static extern IntPtr UsdSkelSkinningQuery_GetPrim(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_HasBlendShapes")]
		public static extern bool UsdSkelSkinningQuery_HasBlendShapes(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_HasJointInfluences")]
		public static extern bool UsdSkelSkinningQuery_HasJointInfluences(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_GetNumInfluencesPerComponent")]
		public static extern int UsdSkelSkinningQuery_GetNumInfluencesPerComponent(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_GetInterpolation")]
		public static extern IntPtr UsdSkelSkinningQuery_GetInterpolation(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_IsRigidlyDeformed")]
		public static extern bool UsdSkelSkinningQuery_IsRigidlyDeformed(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_GetSkinningMethodAttr")]
		public static extern IntPtr UsdSkelSkinningQuery_GetSkinningMethodAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_GetGeomBindTransformAttr")]
		public static extern IntPtr UsdSkelSkinningQuery_GetGeomBindTransformAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_GetJointIndicesPrimvar")]
		public static extern IntPtr UsdSkelSkinningQuery_GetJointIndicesPrimvar(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_GetJointWeightsPrimvar")]
		public static extern IntPtr UsdSkelSkinningQuery_GetJointWeightsPrimvar(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_GetBlendShapesAttr")]
		public static extern IntPtr UsdSkelSkinningQuery_GetBlendShapesAttr(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_GetBlendShapeTargetsRel")]
		public static extern IntPtr UsdSkelSkinningQuery_GetBlendShapeTargetsRel(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_GetJointMapper")]
		public static extern IntPtr UsdSkelSkinningQuery_GetJointMapper(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_GetMapper")]
		public static extern IntPtr UsdSkelSkinningQuery_GetMapper(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_GetBlendShapeMapper")]
		public static extern IntPtr UsdSkelSkinningQuery_GetBlendShapeMapper(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_GetJointOrder")]
		public static extern bool UsdSkelSkinningQuery_GetJointOrder(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_GetBlendShapeOrder")]
		public static extern bool UsdSkelSkinningQuery_GetBlendShapeOrder(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_GetTimeSamples")]
		public static extern bool UsdSkelSkinningQuery_GetTimeSamples(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_ComputeJointInfluences__SWIG_0")]
		public static extern bool UsdSkelSkinningQuery_ComputeJointInfluences__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_ComputeJointInfluences__SWIG_1")]
		public static extern bool UsdSkelSkinningQuery_ComputeJointInfluences__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_ComputeVaryingJointInfluences__SWIG_0")]
		public static extern bool UsdSkelSkinningQuery_ComputeVaryingJointInfluences__SWIG_0(HandleRef jarg1, uint jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_ComputeVaryingJointInfluences__SWIG_1")]
		public static extern bool UsdSkelSkinningQuery_ComputeVaryingJointInfluences__SWIG_1(HandleRef jarg1, uint jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_GetSkinningMethod")]
		public static extern IntPtr UsdSkelSkinningQuery_GetSkinningMethod(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_GetGeomBindTransform__SWIG_0")]
		public static extern IntPtr UsdSkelSkinningQuery_GetGeomBindTransform__SWIG_0(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_GetGeomBindTransform__SWIG_1")]
		public static extern IntPtr UsdSkelSkinningQuery_GetGeomBindTransform__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinningQuery_GetDescription")]
		public static extern string UsdSkelSkinningQuery_GetDescription(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdSkelSkinningQuery")]
		public static extern void delete_UsdSkelSkinningQuery(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelTopology__SWIG_0")]
		public static extern IntPtr new_UsdSkelTopology__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelTopology__SWIG_1")]
		public static extern IntPtr new_UsdSkelTopology__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelTopology__SWIG_2")]
		public static extern IntPtr new_UsdSkelTopology__SWIG_2(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelTopology__SWIG_3")]
		public static extern IntPtr new_UsdSkelTopology__SWIG_3(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelTopology_Validate__SWIG_0")]
		public static extern bool UsdSkelTopology_Validate__SWIG_0(HandleRef jarg1, out string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelTopology_Validate__SWIG_1")]
		public static extern bool UsdSkelTopology_Validate__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelTopology_GetParentIndices")]
		public static extern IntPtr UsdSkelTopology_GetParentIndices(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelTopology_GetNumJoints")]
		public static extern uint UsdSkelTopology_GetNumJoints(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelTopology_size")]
		public static extern uint UsdSkelTopology_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelTopology_GetParent")]
		public static extern int UsdSkelTopology_GetParent(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelTopology_IsRoot")]
		public static extern bool UsdSkelTopology_IsRoot(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_UsdSkelTopology__SWIG_4")]
		public static extern IntPtr new_UsdSkelTopology__SWIG_4(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_UsdSkelTopology")]
		public static extern void delete_UsdSkelTopology(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelIsSkelAnimationPrim")]
		public static extern bool UsdSkelIsSkelAnimationPrim(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelIsSkinnablePrim")]
		public static extern bool UsdSkelIsSkinnablePrim(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelComputeJointLocalTransforms__SWIG_0")]
		public static extern bool UsdSkelComputeJointLocalTransforms__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelComputeJointLocalTransforms__SWIG_1")]
		public static extern bool UsdSkelComputeJointLocalTransforms__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelComputeJointLocalTransforms__SWIG_2")]
		public static extern bool UsdSkelComputeJointLocalTransforms__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelComputeJointLocalTransforms__SWIG_3")]
		public static extern bool UsdSkelComputeJointLocalTransforms__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelComputeJointLocalTransforms__SWIG_4")]
		public static extern bool UsdSkelComputeJointLocalTransforms__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelComputeJointLocalTransforms__SWIG_5")]
		public static extern bool UsdSkelComputeJointLocalTransforms__SWIG_5(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelComputeJointLocalTransforms__SWIG_6")]
		public static extern bool UsdSkelComputeJointLocalTransforms__SWIG_6(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelComputeJointLocalTransforms__SWIG_7")]
		public static extern bool UsdSkelComputeJointLocalTransforms__SWIG_7(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelComputeJointLocalTransforms__SWIG_8")]
		public static extern bool UsdSkelComputeJointLocalTransforms__SWIG_8(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelComputeJointLocalTransforms__SWIG_9")]
		public static extern bool UsdSkelComputeJointLocalTransforms__SWIG_9(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelComputeJointLocalTransforms__SWIG_10")]
		public static extern bool UsdSkelComputeJointLocalTransforms__SWIG_10(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelComputeJointLocalTransforms__SWIG_11")]
		public static extern bool UsdSkelComputeJointLocalTransforms__SWIG_11(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelComputeJointLocalTransforms__SWIG_12")]
		public static extern bool UsdSkelComputeJointLocalTransforms__SWIG_12(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelComputeJointLocalTransforms__SWIG_13")]
		public static extern bool UsdSkelComputeJointLocalTransforms__SWIG_13(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelConcatJointTransforms__SWIG_0")]
		public static extern bool UsdSkelConcatJointTransforms__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelConcatJointTransforms__SWIG_1")]
		public static extern bool UsdSkelConcatJointTransforms__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelConcatJointTransforms__SWIG_2")]
		public static extern bool UsdSkelConcatJointTransforms__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelConcatJointTransforms__SWIG_3")]
		public static extern bool UsdSkelConcatJointTransforms__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelConcatJointTransforms__SWIG_4")]
		public static extern bool UsdSkelConcatJointTransforms__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelConcatJointTransforms__SWIG_5")]
		public static extern bool UsdSkelConcatJointTransforms__SWIG_5(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelConcatJointTransforms__SWIG_6")]
		public static extern bool UsdSkelConcatJointTransforms__SWIG_6(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelConcatJointTransforms__SWIG_7")]
		public static extern bool UsdSkelConcatJointTransforms__SWIG_7(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelComputeJointsExtent__SWIG_3")]
		public static extern bool UsdSkelComputeJointsExtent__SWIG_3(HandleRef jarg1, HandleRef jarg2, float jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelComputeJointsExtent__SWIG_4")]
		public static extern bool UsdSkelComputeJointsExtent__SWIG_4(HandleRef jarg1, HandleRef jarg2, float jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelComputeJointsExtent__SWIG_5")]
		public static extern bool UsdSkelComputeJointsExtent__SWIG_5(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelComputeJointsExtent__SWIG_6")]
		public static extern bool UsdSkelComputeJointsExtent__SWIG_6(HandleRef jarg1, uint jarg2, HandleRef jarg3, float jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelComputeJointsExtent__SWIG_7")]
		public static extern bool UsdSkelComputeJointsExtent__SWIG_7(HandleRef jarg1, uint jarg2, HandleRef jarg3, float jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelComputeJointsExtent__SWIG_8")]
		public static extern bool UsdSkelComputeJointsExtent__SWIG_8(HandleRef jarg1, uint jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelDecomposeTransforms__SWIG_0")]
		public static extern bool UsdSkelDecomposeTransforms__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelDecomposeTransforms__SWIG_1")]
		public static extern bool UsdSkelDecomposeTransforms__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelDecomposeTransforms__SWIG_2")]
		public static extern bool UsdSkelDecomposeTransforms__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelDecomposeTransforms__SWIG_3")]
		public static extern bool UsdSkelDecomposeTransforms__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, uint jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelMakeTransforms__SWIG_0")]
		public static extern bool UsdSkelMakeTransforms__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelMakeTransforms__SWIG_1")]
		public static extern bool UsdSkelMakeTransforms__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelMakeTransforms__SWIG_2")]
		public static extern bool UsdSkelMakeTransforms__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelMakeTransforms__SWIG_3")]
		public static extern bool UsdSkelMakeTransforms__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, uint jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelNormalizeWeights__SWIG_0")]
		public static extern bool UsdSkelNormalizeWeights__SWIG_0(HandleRef jarg1, int jarg2, float jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelNormalizeWeights__SWIG_1")]
		public static extern bool UsdSkelNormalizeWeights__SWIG_1(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelNormalizeWeights__SWIG_2")]
		public static extern bool UsdSkelNormalizeWeights__SWIG_2(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSortInfluences__SWIG_0")]
		public static extern bool UsdSkelSortInfluences__SWIG_0(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSortInfluences__SWIG_1")]
		public static extern bool UsdSkelSortInfluences__SWIG_1(HandleRef jarg1, HandleRef jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelExpandConstantInfluencesToVarying__SWIG_0")]
		public static extern bool UsdSkelExpandConstantInfluencesToVarying__SWIG_0(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelExpandConstantInfluencesToVarying__SWIG_1")]
		public static extern bool UsdSkelExpandConstantInfluencesToVarying__SWIG_1(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelResizeInfluences__SWIG_0")]
		public static extern bool UsdSkelResizeInfluences__SWIG_0(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelResizeInfluences__SWIG_1")]
		public static extern bool UsdSkelResizeInfluences__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelInterleaveInfluences")]
		public static extern bool UsdSkelInterleaveInfluences(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinPoints__SWIG_0")]
		public static extern bool UsdSkelSkinPoints__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, int jarg6, HandleRef jarg7, bool jarg8);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinPoints__SWIG_1")]
		public static extern bool UsdSkelSkinPoints__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, int jarg6, HandleRef jarg7);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinPoints__SWIG_2")]
		public static extern bool UsdSkelSkinPoints__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, int jarg6, HandleRef jarg7, bool jarg8);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinPoints__SWIG_3")]
		public static extern bool UsdSkelSkinPoints__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, int jarg6, HandleRef jarg7);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinPoints__SWIG_4")]
		public static extern bool UsdSkelSkinPoints__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5, HandleRef jarg6, bool jarg7);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinPoints__SWIG_5")]
		public static extern bool UsdSkelSkinPoints__SWIG_5(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5, HandleRef jarg6);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinPoints__SWIG_6")]
		public static extern bool UsdSkelSkinPoints__SWIG_6(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5, HandleRef jarg6, bool jarg7);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinPoints__SWIG_7")]
		public static extern bool UsdSkelSkinPoints__SWIG_7(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5, HandleRef jarg6);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinPoints__SWIG_8")]
		public static extern bool UsdSkelSkinPoints__SWIG_8(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, int jarg6, HandleRef jarg7);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinPoints__SWIG_9")]
		public static extern bool UsdSkelSkinPoints__SWIG_9(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, uint jarg4, HandleRef jarg5, HandleRef jarg6, uint jarg7, int jarg8, HandleRef jarg9, uint jarg10, bool jarg11);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinPoints__SWIG_10")]
		public static extern bool UsdSkelSkinPoints__SWIG_10(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, uint jarg4, HandleRef jarg5, HandleRef jarg6, uint jarg7, int jarg8, HandleRef jarg9, uint jarg10);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinPointsLBS__SWIG_0")]
		public static extern bool UsdSkelSkinPointsLBS__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5, HandleRef jarg6, bool jarg7);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinPointsLBS__SWIG_1")]
		public static extern bool UsdSkelSkinPointsLBS__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5, HandleRef jarg6);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinPointsLBS__SWIG_2")]
		public static extern bool UsdSkelSkinPointsLBS__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5, HandleRef jarg6, bool jarg7);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinPointsLBS__SWIG_3")]
		public static extern bool UsdSkelSkinPointsLBS__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5, HandleRef jarg6);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinPointsLBS__SWIG_4")]
		public static extern bool UsdSkelSkinPointsLBS__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4, HandleRef jarg5, bool jarg6);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinPointsLBS__SWIG_5")]
		public static extern bool UsdSkelSkinPointsLBS__SWIG_5(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinPointsLBS__SWIG_6")]
		public static extern bool UsdSkelSkinPointsLBS__SWIG_6(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4, HandleRef jarg5, bool jarg6);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinPointsLBS__SWIG_7")]
		public static extern bool UsdSkelSkinPointsLBS__SWIG_7(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinPointsLBS__SWIG_8")]
		public static extern bool UsdSkelSkinPointsLBS__SWIG_8(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5, HandleRef jarg6);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinPointsLBS__SWIG_9")]
		public static extern bool UsdSkelSkinPointsLBS__SWIG_9(HandleRef jarg1, HandleRef jarg2, uint jarg3, HandleRef jarg4, HandleRef jarg5, uint jarg6, int jarg7, HandleRef jarg8, uint jarg9, bool jarg10);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinPointsLBS__SWIG_10")]
		public static extern bool UsdSkelSkinPointsLBS__SWIG_10(HandleRef jarg1, HandleRef jarg2, uint jarg3, HandleRef jarg4, HandleRef jarg5, uint jarg6, int jarg7, HandleRef jarg8, uint jarg9);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinNormals__SWIG_0")]
		public static extern bool UsdSkelSkinNormals__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, int jarg6, HandleRef jarg7, bool jarg8);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinNormals__SWIG_1")]
		public static extern bool UsdSkelSkinNormals__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, int jarg6, HandleRef jarg7);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinNormals__SWIG_2")]
		public static extern bool UsdSkelSkinNormals__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, int jarg6, HandleRef jarg7, bool jarg8);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinNormals__SWIG_3")]
		public static extern bool UsdSkelSkinNormals__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, int jarg6, HandleRef jarg7);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinNormals__SWIG_4")]
		public static extern bool UsdSkelSkinNormals__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5, HandleRef jarg6, bool jarg7);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinNormals__SWIG_5")]
		public static extern bool UsdSkelSkinNormals__SWIG_5(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5, HandleRef jarg6);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinNormals__SWIG_6")]
		public static extern bool UsdSkelSkinNormals__SWIG_6(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5, HandleRef jarg6, bool jarg7);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinNormals__SWIG_7")]
		public static extern bool UsdSkelSkinNormals__SWIG_7(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5, HandleRef jarg6);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinFaceVaryingNormals__SWIG_0")]
		public static extern bool UsdSkelSkinFaceVaryingNormals__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, int jarg6, HandleRef jarg7, HandleRef jarg8, bool jarg9);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinFaceVaryingNormals__SWIG_1")]
		public static extern bool UsdSkelSkinFaceVaryingNormals__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, int jarg6, HandleRef jarg7, HandleRef jarg8);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinFaceVaryingNormals__SWIG_2")]
		public static extern bool UsdSkelSkinFaceVaryingNormals__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, int jarg6, HandleRef jarg7, HandleRef jarg8, bool jarg9);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinFaceVaryingNormals__SWIG_3")]
		public static extern bool UsdSkelSkinFaceVaryingNormals__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, int jarg6, HandleRef jarg7, HandleRef jarg8);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinNormalsLBS__SWIG_0")]
		public static extern bool UsdSkelSkinNormalsLBS__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5, HandleRef jarg6, bool jarg7);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinNormalsLBS__SWIG_1")]
		public static extern bool UsdSkelSkinNormalsLBS__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5, HandleRef jarg6);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinNormalsLBS__SWIG_2")]
		public static extern bool UsdSkelSkinNormalsLBS__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5, HandleRef jarg6, bool jarg7);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinNormalsLBS__SWIG_3")]
		public static extern bool UsdSkelSkinNormalsLBS__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5, HandleRef jarg6);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinNormalsLBS__SWIG_4")]
		public static extern bool UsdSkelSkinNormalsLBS__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4, HandleRef jarg5, bool jarg6);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinNormalsLBS__SWIG_5")]
		public static extern bool UsdSkelSkinNormalsLBS__SWIG_5(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinNormalsLBS__SWIG_6")]
		public static extern bool UsdSkelSkinNormalsLBS__SWIG_6(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4, HandleRef jarg5, bool jarg6);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinNormalsLBS__SWIG_7")]
		public static extern bool UsdSkelSkinNormalsLBS__SWIG_7(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, int jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinFaceVaryingNormalsLBS__SWIG_0")]
		public static extern bool UsdSkelSkinFaceVaryingNormalsLBS__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5, HandleRef jarg6, HandleRef jarg7, bool jarg8);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinFaceVaryingNormalsLBS__SWIG_1")]
		public static extern bool UsdSkelSkinFaceVaryingNormalsLBS__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5, HandleRef jarg6, HandleRef jarg7);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinFaceVaryingNormalsLBS__SWIG_2")]
		public static extern bool UsdSkelSkinFaceVaryingNormalsLBS__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5, HandleRef jarg6, HandleRef jarg7, bool jarg8);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinFaceVaryingNormalsLBS__SWIG_3")]
		public static extern bool UsdSkelSkinFaceVaryingNormalsLBS__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, int jarg5, HandleRef jarg6, HandleRef jarg7);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinTransform__SWIG_0")]
		public static extern bool UsdSkelSkinTransform__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, HandleRef jarg6);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinTransform__SWIG_1")]
		public static extern bool UsdSkelSkinTransform__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5, HandleRef jarg6);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinTransform__SWIG_2")]
		public static extern bool UsdSkelSkinTransform__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinTransform__SWIG_3")]
		public static extern bool UsdSkelSkinTransform__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinTransform__SWIG_4")]
		public static extern bool UsdSkelSkinTransform__SWIG_4(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, uint jarg4, HandleRef jarg5, HandleRef jarg6, uint jarg7, HandleRef jarg8);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinTransformLBS__SWIG_0")]
		public static extern bool UsdSkelSkinTransformLBS__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinTransformLBS__SWIG_1")]
		public static extern bool UsdSkelSkinTransformLBS__SWIG_1(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4, HandleRef jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinTransformLBS__SWIG_2")]
		public static extern bool UsdSkelSkinTransformLBS__SWIG_2(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinTransformLBS__SWIG_3")]
		public static extern bool UsdSkelSkinTransformLBS__SWIG_3(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkinTransformLBS__SWIG_4")]
		public static extern bool UsdSkelSkinTransformLBS__SWIG_4(HandleRef jarg1, HandleRef jarg2, uint jarg3, HandleRef jarg4, HandleRef jarg5, uint jarg6, HandleRef jarg7);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelApplyBlendShape")]
		public static extern bool UsdSkelApplyBlendShape(float jarg1, HandleRef jarg2, HandleRef jarg3, HandleRef jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelAnimation_SWIGUpcast")]
		public static extern IntPtr UsdSkelAnimation_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBindingAPI_SWIGUpcast")]
		public static extern IntPtr UsdSkelBindingAPI_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelBlendShape_SWIGUpcast")]
		public static extern IntPtr UsdSkelBlendShape_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelPackedJointAnimation_SWIGUpcast")]
		public static extern IntPtr UsdSkelPackedJointAnimation_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelRoot_SWIGUpcast")]
		public static extern IntPtr UsdSkelRoot_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_UsdSkelSkeleton_SWIGUpcast")]
		public static extern IntPtr UsdSkelSkeleton_SWIGUpcast(IntPtr jarg1);
	}
}
