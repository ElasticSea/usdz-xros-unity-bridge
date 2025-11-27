using System;
using System.Runtime.InteropServices;

namespace pxr
{
	internal class UsdVolPINVOKE
	{
		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			[DllImport("__Internal")]
			public static extern void SWIGRegisterStringCallback_UsdVol(SWIGStringDelegate stringDelegate);

			[MonoPInvokeCallback]
			private static string CreateString(string cString)
			{
				return cString;
			}

			static SWIGStringHelper()
			{
				stringDelegate = CreateString;
				SWIGRegisterStringCallback_UsdVol(stringDelegate);
			}
		}

		public class SWIGPendingException : UsdCsPINVOKE.SWIGPendingException
		{
		}

		protected static SWIGStringHelper swigStringHelper;

		static UsdVolPINVOKE()
		{
			swigStringHelper = new SWIGStringHelper();
		}

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdVolFieldBase__SWIG_0")]
		public static extern IntPtr new_UsdVolFieldBase__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdVolFieldBase__SWIG_1")]
		public static extern IntPtr new_UsdVolFieldBase__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdVolFieldBase__SWIG_2")]
		public static extern IntPtr new_UsdVolFieldBase__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdVolFieldBase")]
		public static extern void delete_UsdVolFieldBase(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldBase_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdVolFieldBase_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldBase_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdVolFieldBase_GetSchemaAttributeNames__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldBase_Get")]
		public static extern IntPtr UsdVolFieldBase_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdVolFieldAsset__SWIG_0")]
		public static extern IntPtr new_UsdVolFieldAsset__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdVolFieldAsset__SWIG_1")]
		public static extern IntPtr new_UsdVolFieldAsset__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdVolFieldAsset__SWIG_2")]
		public static extern IntPtr new_UsdVolFieldAsset__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdVolFieldAsset")]
		public static extern void delete_UsdVolFieldAsset(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldAsset_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdVolFieldAsset_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldAsset_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdVolFieldAsset_GetSchemaAttributeNames__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldAsset_Get")]
		public static extern IntPtr UsdVolFieldAsset_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldAsset_GetFilePathAttr")]
		public static extern IntPtr UsdVolFieldAsset_GetFilePathAttr(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldAsset_CreateFilePathAttr__SWIG_0")]
		public static extern IntPtr UsdVolFieldAsset_CreateFilePathAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldAsset_CreateFilePathAttr__SWIG_1")]
		public static extern IntPtr UsdVolFieldAsset_CreateFilePathAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldAsset_CreateFilePathAttr__SWIG_2")]
		public static extern IntPtr UsdVolFieldAsset_CreateFilePathAttr__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldAsset_GetFieldNameAttr")]
		public static extern IntPtr UsdVolFieldAsset_GetFieldNameAttr(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldAsset_CreateFieldNameAttr__SWIG_0")]
		public static extern IntPtr UsdVolFieldAsset_CreateFieldNameAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldAsset_CreateFieldNameAttr__SWIG_1")]
		public static extern IntPtr UsdVolFieldAsset_CreateFieldNameAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldAsset_CreateFieldNameAttr__SWIG_2")]
		public static extern IntPtr UsdVolFieldAsset_CreateFieldNameAttr__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldAsset_GetFieldIndexAttr")]
		public static extern IntPtr UsdVolFieldAsset_GetFieldIndexAttr(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldAsset_CreateFieldIndexAttr__SWIG_0")]
		public static extern IntPtr UsdVolFieldAsset_CreateFieldIndexAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldAsset_CreateFieldIndexAttr__SWIG_1")]
		public static extern IntPtr UsdVolFieldAsset_CreateFieldIndexAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldAsset_CreateFieldIndexAttr__SWIG_2")]
		public static extern IntPtr UsdVolFieldAsset_CreateFieldIndexAttr__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldAsset_GetFieldDataTypeAttr")]
		public static extern IntPtr UsdVolFieldAsset_GetFieldDataTypeAttr(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldAsset_CreateFieldDataTypeAttr__SWIG_0")]
		public static extern IntPtr UsdVolFieldAsset_CreateFieldDataTypeAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldAsset_CreateFieldDataTypeAttr__SWIG_1")]
		public static extern IntPtr UsdVolFieldAsset_CreateFieldDataTypeAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldAsset_CreateFieldDataTypeAttr__SWIG_2")]
		public static extern IntPtr UsdVolFieldAsset_CreateFieldDataTypeAttr__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldAsset_GetVectorDataRoleHintAttr")]
		public static extern IntPtr UsdVolFieldAsset_GetVectorDataRoleHintAttr(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldAsset_CreateVectorDataRoleHintAttr__SWIG_0")]
		public static extern IntPtr UsdVolFieldAsset_CreateVectorDataRoleHintAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldAsset_CreateVectorDataRoleHintAttr__SWIG_1")]
		public static extern IntPtr UsdVolFieldAsset_CreateVectorDataRoleHintAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldAsset_CreateVectorDataRoleHintAttr__SWIG_2")]
		public static extern IntPtr UsdVolFieldAsset_CreateVectorDataRoleHintAttr__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdVolField3DAsset__SWIG_0")]
		public static extern IntPtr new_UsdVolField3DAsset__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdVolField3DAsset__SWIG_1")]
		public static extern IntPtr new_UsdVolField3DAsset__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdVolField3DAsset__SWIG_2")]
		public static extern IntPtr new_UsdVolField3DAsset__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdVolField3DAsset")]
		public static extern void delete_UsdVolField3DAsset(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolField3DAsset_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdVolField3DAsset_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolField3DAsset_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdVolField3DAsset_GetSchemaAttributeNames__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolField3DAsset_Get")]
		public static extern IntPtr UsdVolField3DAsset_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolField3DAsset_Define")]
		public static extern IntPtr UsdVolField3DAsset_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolField3DAsset_GetFieldDataTypeAttr")]
		public static extern IntPtr UsdVolField3DAsset_GetFieldDataTypeAttr(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolField3DAsset_CreateFieldDataTypeAttr__SWIG_0")]
		public static extern IntPtr UsdVolField3DAsset_CreateFieldDataTypeAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolField3DAsset_CreateFieldDataTypeAttr__SWIG_1")]
		public static extern IntPtr UsdVolField3DAsset_CreateFieldDataTypeAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolField3DAsset_CreateFieldDataTypeAttr__SWIG_2")]
		public static extern IntPtr UsdVolField3DAsset_CreateFieldDataTypeAttr__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolField3DAsset_GetFieldPurposeAttr")]
		public static extern IntPtr UsdVolField3DAsset_GetFieldPurposeAttr(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolField3DAsset_CreateFieldPurposeAttr__SWIG_0")]
		public static extern IntPtr UsdVolField3DAsset_CreateFieldPurposeAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolField3DAsset_CreateFieldPurposeAttr__SWIG_1")]
		public static extern IntPtr UsdVolField3DAsset_CreateFieldPurposeAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolField3DAsset_CreateFieldPurposeAttr__SWIG_2")]
		public static extern IntPtr UsdVolField3DAsset_CreateFieldPurposeAttr__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdVolOpenVDBAsset__SWIG_0")]
		public static extern IntPtr new_UsdVolOpenVDBAsset__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdVolOpenVDBAsset__SWIG_1")]
		public static extern IntPtr new_UsdVolOpenVDBAsset__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdVolOpenVDBAsset__SWIG_2")]
		public static extern IntPtr new_UsdVolOpenVDBAsset__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdVolOpenVDBAsset")]
		public static extern void delete_UsdVolOpenVDBAsset(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolOpenVDBAsset_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdVolOpenVDBAsset_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolOpenVDBAsset_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdVolOpenVDBAsset_GetSchemaAttributeNames__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolOpenVDBAsset_Get")]
		public static extern IntPtr UsdVolOpenVDBAsset_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolOpenVDBAsset_Define")]
		public static extern IntPtr UsdVolOpenVDBAsset_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolOpenVDBAsset_GetFieldDataTypeAttr")]
		public static extern IntPtr UsdVolOpenVDBAsset_GetFieldDataTypeAttr(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolOpenVDBAsset_CreateFieldDataTypeAttr__SWIG_0")]
		public static extern IntPtr UsdVolOpenVDBAsset_CreateFieldDataTypeAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolOpenVDBAsset_CreateFieldDataTypeAttr__SWIG_1")]
		public static extern IntPtr UsdVolOpenVDBAsset_CreateFieldDataTypeAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolOpenVDBAsset_CreateFieldDataTypeAttr__SWIG_2")]
		public static extern IntPtr UsdVolOpenVDBAsset_CreateFieldDataTypeAttr__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolOpenVDBAsset_GetFieldClassAttr")]
		public static extern IntPtr UsdVolOpenVDBAsset_GetFieldClassAttr(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolOpenVDBAsset_CreateFieldClassAttr__SWIG_0")]
		public static extern IntPtr UsdVolOpenVDBAsset_CreateFieldClassAttr__SWIG_0(HandleRef jarg1, HandleRef jarg2, bool jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolOpenVDBAsset_CreateFieldClassAttr__SWIG_1")]
		public static extern IntPtr UsdVolOpenVDBAsset_CreateFieldClassAttr__SWIG_1(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolOpenVDBAsset_CreateFieldClassAttr__SWIG_2")]
		public static extern IntPtr UsdVolOpenVDBAsset_CreateFieldClassAttr__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdVolVolume__SWIG_0")]
		public static extern IntPtr new_UsdVolVolume__SWIG_0(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdVolVolume__SWIG_1")]
		public static extern IntPtr new_UsdVolVolume__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_new_UsdVolVolume__SWIG_2")]
		public static extern IntPtr new_UsdVolVolume__SWIG_2(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_delete_UsdVolVolume")]
		public static extern void delete_UsdVolVolume(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolVolume_GetSchemaAttributeNames__SWIG_0")]
		public static extern IntPtr UsdVolVolume_GetSchemaAttributeNames__SWIG_0(bool jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolVolume_GetSchemaAttributeNames__SWIG_1")]
		public static extern IntPtr UsdVolVolume_GetSchemaAttributeNames__SWIG_1();

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolVolume_Get")]
		public static extern IntPtr UsdVolVolume_Get(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolVolume_Define")]
		public static extern IntPtr UsdVolVolume_Define(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolVolume_GetFieldPaths")]
		public static extern IntPtr UsdVolVolume_GetFieldPaths(HandleRef jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolVolume_HasFieldRelationship")]
		public static extern bool UsdVolVolume_HasFieldRelationship(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolVolume_GetFieldPath")]
		public static extern IntPtr UsdVolVolume_GetFieldPath(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolVolume_CreateFieldRelationship")]
		public static extern bool UsdVolVolume_CreateFieldRelationship(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolVolume_BlockFieldRelationship")]
		public static extern bool UsdVolVolume_BlockFieldRelationship(HandleRef jarg1, HandleRef jarg2);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldBase_SWIGUpcast")]
		public static extern IntPtr UsdVolFieldBase_SWIGUpcast(IntPtr jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolFieldAsset_SWIGUpcast")]
		public static extern IntPtr UsdVolFieldAsset_SWIGUpcast(IntPtr jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolField3DAsset_SWIGUpcast")]
		public static extern IntPtr UsdVolField3DAsset_SWIGUpcast(IntPtr jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolOpenVDBAsset_SWIGUpcast")]
		public static extern IntPtr UsdVolOpenVDBAsset_SWIGUpcast(IntPtr jarg1);

		[DllImport("__Internal", EntryPoint = "CSharp_pxr_UsdVolVolume_SWIGUpcast")]
		public static extern IntPtr UsdVolVolume_SWIGUpcast(IntPtr jarg1);
	}
}
