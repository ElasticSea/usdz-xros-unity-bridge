using System;
using System.Runtime.InteropServices;

namespace pxr
{
	internal class TfPINVOKE
	{
		protected class SWIGStringHelper
		{
			public delegate string SWIGStringDelegate(string message);

			private static SWIGStringDelegate stringDelegate;

			[DllImport(UsdDll.USD_EXPORT_NAME)]
			public static extern void SWIGRegisterStringCallback_Tf(SWIGStringDelegate stringDelegate);

			[MonoPInvokeCallback]
			private static string CreateString(string cString)
			{
				return cString;
			}

			static SWIGStringHelper()
			{
				stringDelegate = CreateString;
				SWIGRegisterStringCallback_Tf(stringDelegate);
			}
		}

		public class SWIGPendingException : UsdCsPINVOKE.SWIGPendingException
		{
		}

		protected static SWIGStringHelper swigStringHelper;

		static TfPINVOKE()
		{
			swigStringHelper = new SWIGStringHelper();
		}

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_TfCallContext__SWIG_0")]
		public static extern IntPtr new_TfCallContext__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_TfCallContext__SWIG_1")]
		public static extern IntPtr new_TfCallContext__SWIG_1(string jarg1, string jarg2, uint jarg3, string jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfCallContext_GetFile")]
		public static extern string TfCallContext_GetFile(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfCallContext_GetFunction")]
		public static extern string TfCallContext_GetFunction(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfCallContext_GetLine")]
		public static extern uint TfCallContext_GetLine(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfCallContext_GetPrettyFunction")]
		public static extern string TfCallContext_GetPrettyFunction(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfCallContext_Hide")]
		public static extern IntPtr TfCallContext_Hide(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfCallContext_IsHidden")]
		public static extern bool TfCallContext_IsHidden(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_TfCallContext")]
		public static extern void delete_TfCallContext(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticBase_GetContext")]
		public static extern IntPtr TfDiagnosticBase_GetContext(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticBase_GetSourceFileName")]
		public static extern string TfDiagnosticBase_GetSourceFileName(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticBase_GetSourceLineNumber")]
		public static extern uint TfDiagnosticBase_GetSourceLineNumber(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticBase_GetCommentary")]
		public static extern string TfDiagnosticBase_GetCommentary(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticBase_GetSourceFunction")]
		public static extern string TfDiagnosticBase_GetSourceFunction(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticBase_AugmentCommentary")]
		public static extern void TfDiagnosticBase_AugmentCommentary(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticBase_GetDiagnosticCode")]
		public static extern IntPtr TfDiagnosticBase_GetDiagnosticCode(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticBase_GetDiagnosticCodeAsString")]
		public static extern string TfDiagnosticBase_GetDiagnosticCodeAsString(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticBase_GetQuiet")]
		public static extern bool TfDiagnosticBase_GetQuiet(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticBase_IsFatal")]
		public static extern bool TfDiagnosticBase_IsFatal(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticBase_IsCodingError")]
		public static extern bool TfDiagnosticBase_IsCodingError(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_TfDiagnosticBase")]
		public static extern void delete_TfDiagnosticBase(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticMgr_GetCodeName")]
		public static extern string TfDiagnosticMgr_GetCodeName(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_TfDiagnosticMgr_Delegate")]
		public static extern void delete_TfDiagnosticMgr_Delegate(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticMgr_Delegate_IssueError")]
		public static extern void TfDiagnosticMgr_Delegate_IssueError(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticMgr_Delegate_IssueFatalError")]
		public static extern void TfDiagnosticMgr_Delegate_IssueFatalError(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticMgr_Delegate_IssueStatus")]
		public static extern void TfDiagnosticMgr_Delegate_IssueStatus(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticMgr_Delegate_IssueWarning")]
		public static extern void TfDiagnosticMgr_Delegate_IssueWarning(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_TfDiagnosticMgr_Delegate")]
		public static extern IntPtr new_TfDiagnosticMgr_Delegate();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticMgr_Delegate_director_connect")]
		public static extern void TfDiagnosticMgr_Delegate_director_connect(HandleRef jarg1, TfDiagnosticMgr.Delegate.SwigDelegateDelegate_0 delegate0, TfDiagnosticMgr.Delegate.SwigDelegateDelegate_1 delegate1, TfDiagnosticMgr.Delegate.SwigDelegateDelegate_2 delegate2, TfDiagnosticMgr.Delegate.SwigDelegateDelegate_3 delegate3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticMgr_GetInstance")]
		public static extern IntPtr TfDiagnosticMgr_GetInstance();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticMgr_AddDelegate")]
		public static extern void TfDiagnosticMgr_AddDelegate(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticMgr_RemoveDelegate")]
		public static extern void TfDiagnosticMgr_RemoveDelegate(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticMgr_SetQuiet")]
		public static extern void TfDiagnosticMgr_SetQuiet(HandleRef jarg1, bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticMgr_AppendError")]
		public static extern void TfDiagnosticMgr_AppendError(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticMgr_PostError")]
		public static extern void TfDiagnosticMgr_PostError(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticMgr_PostWarning")]
		public static extern void TfDiagnosticMgr_PostWarning(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticMgr_PostStatus")]
		public static extern void TfDiagnosticMgr_PostStatus(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticMgr_PostFatal")]
		public static extern void TfDiagnosticMgr_PostFatal(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3, string jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDiagnosticMgr_HasActiveErrorMark")]
		public static extern bool TfDiagnosticMgr_HasActiveErrorMark(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_TfEnum")]
		public static extern IntPtr new_TfEnum();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfEnum_GetValueAsInt")]
		public static extern int TfEnum_GetValueAsInt(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfEnum_GetName")]
		public static extern string TfEnum_GetName(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfEnum_GetFullName")]
		public static extern string TfEnum_GetFullName(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfEnum_GetDisplayName")]
		public static extern string TfEnum_GetDisplayName(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfEnum_GetAllNames")]
		public static extern IntPtr TfEnum_GetAllNames(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfEnum_GetValueFromFullName__SWIG_0")]
		public static extern IntPtr TfEnum_GetValueFromFullName__SWIG_0(string jarg1, out bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfEnum_GetValueFromFullName__SWIG_1")]
		public static extern IntPtr TfEnum_GetValueFromFullName__SWIG_1(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfEnum_IsKnownEnumType")]
		public static extern bool TfEnum_IsKnownEnumType(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfEnum__AddName__SWIG_0")]
		public static extern void TfEnum__AddName__SWIG_0(HandleRef jarg1, string jarg2, string jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfEnum__AddName__SWIG_1")]
		public static extern void TfEnum__AddName__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfEnum_AddName__SWIG_0")]
		public static extern void TfEnum_AddName__SWIG_0(HandleRef jarg1, string jarg2, string jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfEnum_AddName__SWIG_1")]
		public static extern void TfEnum_AddName__SWIG_1(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_TfEnum")]
		public static extern void delete_TfEnum(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfError_GetErrorCode")]
		public static extern IntPtr TfError_GetErrorCode(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfError_GetErrorCodeAsString")]
		public static extern string TfError_GetErrorCodeAsString(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_TfError")]
		public static extern void delete_TfError(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_TfStatus")]
		public static extern void delete_TfStatus(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringPrintf")]
		public static extern string TfStringPrintf(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfSafeString")]
		public static extern string TfSafeString(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfIntToString")]
		public static extern string TfIntToString(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringToDouble__SWIG_0")]
		public static extern double TfStringToDouble__SWIG_0(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringToDouble__SWIG_2")]
		public static extern double TfStringToDouble__SWIG_2(string jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringToLong__SWIG_0")]
		public static extern int TfStringToLong__SWIG_0(string jarg1, out bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringToLong__SWIG_1")]
		public static extern int TfStringToLong__SWIG_1(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringToULong__SWIG_0")]
		public static extern uint TfStringToULong__SWIG_0(string jarg1, out bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringToULong__SWIG_1")]
		public static extern uint TfStringToULong__SWIG_1(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringToInt64__SWIG_0")]
		public static extern long TfStringToInt64__SWIG_0(string jarg1, out bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringToInt64__SWIG_1")]
		public static extern long TfStringToInt64__SWIG_1(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringToUInt64__SWIG_0")]
		public static extern ulong TfStringToUInt64__SWIG_0(string jarg1, out bool jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringToUInt64__SWIG_1")]
		public static extern ulong TfStringToUInt64__SWIG_1(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_Tf_StringStartsWithImpl")]
		public static extern bool Tf_StringStartsWithImpl(string jarg1, uint jarg2, string jarg3, uint jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringStartsWith__SWIG_0")]
		public static extern bool TfStringStartsWith__SWIG_0(string jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_Tf_StringEndsWithImpl")]
		public static extern bool Tf_StringEndsWithImpl(string jarg1, uint jarg2, string jarg3, uint jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringEndsWith__SWIG_0")]
		public static extern bool TfStringEndsWith__SWIG_0(string jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringContains__SWIG_0")]
		public static extern bool TfStringContains__SWIG_0(string jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringContains__SWIG_2")]
		public static extern bool TfStringContains__SWIG_2(string jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringToLower")]
		public static extern string TfStringToLower(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringToUpper")]
		public static extern string TfStringToUpper(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringCapitalize")]
		public static extern string TfStringCapitalize(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringTrimLeft__SWIG_0")]
		public static extern string TfStringTrimLeft__SWIG_0(string jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringTrimLeft__SWIG_1")]
		public static extern string TfStringTrimLeft__SWIG_1(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringTrimRight__SWIG_0")]
		public static extern string TfStringTrimRight__SWIG_0(string jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringTrimRight__SWIG_1")]
		public static extern string TfStringTrimRight__SWIG_1(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringTrim__SWIG_0")]
		public static extern string TfStringTrim__SWIG_0(string jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringTrim__SWIG_1")]
		public static extern string TfStringTrim__SWIG_1(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringGetCommonPrefix")]
		public static extern string TfStringGetCommonPrefix(string jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringGetSuffix__SWIG_0")]
		public static extern string TfStringGetSuffix__SWIG_0(string jarg1, char jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringGetSuffix__SWIG_1")]
		public static extern string TfStringGetSuffix__SWIG_1(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringGetBeforeSuffix__SWIG_0")]
		public static extern string TfStringGetBeforeSuffix__SWIG_0(string jarg1, char jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringGetBeforeSuffix__SWIG_1")]
		public static extern string TfStringGetBeforeSuffix__SWIG_1(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfGetBaseName")]
		public static extern string TfGetBaseName(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfGetPathName")]
		public static extern string TfGetPathName(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringReplace")]
		public static extern string TfStringReplace(string jarg1, string jarg2, string jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringJoin__SWIG_2")]
		public static extern string TfStringJoin__SWIG_2(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringJoin__SWIG_3")]
		public static extern string TfStringJoin__SWIG_3(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringJoin__SWIG_4")]
		public static extern string TfStringJoin__SWIG_4(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringJoin__SWIG_5")]
		public static extern string TfStringJoin__SWIG_5(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringSplit")]
		public static extern IntPtr TfStringSplit(string jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringTokenize__SWIG_0")]
		public static extern IntPtr TfStringTokenize__SWIG_0(string jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringTokenize__SWIG_1")]
		public static extern IntPtr TfStringTokenize__SWIG_1(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringTokenizeToSet__SWIG_0")]
		public static extern IntPtr TfStringTokenizeToSet__SWIG_0(string jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringTokenizeToSet__SWIG_1")]
		public static extern IntPtr TfStringTokenizeToSet__SWIG_1(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfQuotedStringTokenize__SWIG_0")]
		public static extern IntPtr TfQuotedStringTokenize__SWIG_0(string jarg1, string jarg2, out string jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfQuotedStringTokenize__SWIG_1")]
		public static extern IntPtr TfQuotedStringTokenize__SWIG_1(string jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfQuotedStringTokenize__SWIG_2")]
		public static extern IntPtr TfQuotedStringTokenize__SWIG_2(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfMatchedStringTokenize__SWIG_0")]
		public static extern IntPtr TfMatchedStringTokenize__SWIG_0(string jarg1, char jarg2, char jarg3, char jarg4, out string jarg5);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfMatchedStringTokenize__SWIG_1")]
		public static extern IntPtr TfMatchedStringTokenize__SWIG_1(string jarg1, char jarg2, char jarg3, char jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfMatchedStringTokenize__SWIG_2")]
		public static extern IntPtr TfMatchedStringTokenize__SWIG_2(string jarg1, char jarg2, char jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfMatchedStringTokenize__SWIG_3")]
		public static extern IntPtr TfMatchedStringTokenize__SWIG_3(string jarg1, char jarg2, char jarg3, out string jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_TfDictionaryLessThan")]
		public static extern IntPtr new_TfDictionaryLessThan();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_TfDictionaryLessThan")]
		public static extern void delete_TfDictionaryLessThan(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringify__SWIG_1")]
		public static extern string TfStringify__SWIG_1(bool jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringify__SWIG_2")]
		public static extern string TfStringify__SWIG_2(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringify__SWIG_3")]
		public static extern string TfStringify__SWIG_3(float jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringify__SWIG_4")]
		public static extern string TfStringify__SWIG_4(double jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfDoubleToString")]
		public static extern bool TfDoubleToString(double jarg1, string jarg2, int jarg3, bool jarg4);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_TfStreamFloat")]
		public static extern IntPtr new_TfStreamFloat(float jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStreamFloat_value_set")]
		public static extern void TfStreamFloat_value_set(HandleRef jarg1, float jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStreamFloat_value_get")]
		public static extern float TfStreamFloat_value_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_TfStreamFloat")]
		public static extern void delete_TfStreamFloat(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_TfStreamDouble")]
		public static extern IntPtr new_TfStreamDouble(double jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStreamDouble_value_set")]
		public static extern void TfStreamDouble_value_set(HandleRef jarg1, double jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStreamDouble_value_get")]
		public static extern double TfStreamDouble_value_get(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_TfStreamDouble")]
		public static extern void delete_TfStreamDouble(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringGlobToRegex")]
		public static extern string TfStringGlobToRegex(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfEscapeString")]
		public static extern string TfEscapeString(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfEscapeStringReplaceChar")]
		public static extern void TfEscapeStringReplaceChar(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStringCatPaths")]
		public static extern string TfStringCatPaths(string jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfIsValidIdentifier")]
		public static extern bool TfIsValidIdentifier(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfMakeValidIdentifier")]
		public static extern string TfMakeValidIdentifier(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfGetXmlEscapedString")]
		public static extern string TfGetXmlEscapedString(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTokenVector_Clear")]
		public static extern void TfTokenVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTokenVector_Add")]
		public static extern void TfTokenVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTokenVector_size")]
		public static extern uint TfTokenVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTokenVector_capacity")]
		public static extern uint TfTokenVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTokenVector_reserve")]
		public static extern void TfTokenVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_TfTokenVector__SWIG_0")]
		public static extern IntPtr new_TfTokenVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_TfTokenVector__SWIG_1")]
		public static extern IntPtr new_TfTokenVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_TfTokenVector__SWIG_2")]
		public static extern IntPtr new_TfTokenVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTokenVector_getitemcopy")]
		public static extern IntPtr TfTokenVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTokenVector_getitem")]
		public static extern IntPtr TfTokenVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTokenVector_setitem")]
		public static extern void TfTokenVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTokenVector_AddRange")]
		public static extern void TfTokenVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTokenVector_GetRange")]
		public static extern IntPtr TfTokenVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTokenVector_Insert")]
		public static extern void TfTokenVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTokenVector_InsertRange")]
		public static extern void TfTokenVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTokenVector_RemoveAt")]
		public static extern void TfTokenVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTokenVector_RemoveRange")]
		public static extern void TfTokenVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTokenVector_Repeat")]
		public static extern IntPtr TfTokenVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTokenVector_Reverse__SWIG_0")]
		public static extern void TfTokenVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTokenVector_Reverse__SWIG_1")]
		public static extern void TfTokenVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTokenVector_SetRange")]
		public static extern void TfTokenVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_TfTokenVector")]
		public static extern void delete_TfTokenVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_TfToken__SWIG_0")]
		public static extern IntPtr new_TfToken__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_TfToken__SWIG_1")]
		public static extern IntPtr new_TfToken__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_TfToken")]
		public static extern void delete_TfToken(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_TfToken__SWIG_3")]
		public static extern IntPtr new_TfToken__SWIG_3(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_TfToken__SWIG_4")]
		public static extern IntPtr new_TfToken__SWIG_4(string jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfToken_Find")]
		public static extern IntPtr TfToken_Find(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfToken_Hash")]
		public static extern uint TfToken_Hash(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_TfToken_HashFunctor")]
		public static extern IntPtr new_TfToken_HashFunctor();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_TfToken_HashFunctor")]
		public static extern void delete_TfToken_HashFunctor(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfToken_size")]
		public static extern uint TfToken_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfToken_GetText")]
		public static extern string TfToken_GetText(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfToken_data")]
		public static extern string TfToken_data(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfToken_GetString")]
		public static extern string TfToken_GetString(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfToken_Swap")]
		public static extern void TfToken_Swap(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfToken_IsEmpty")]
		public static extern bool TfToken_IsEmpty(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfToken_IsImmortal")]
		public static extern bool TfToken_IsImmortal(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfToken_Equals")]
		public static extern bool TfToken_Equals(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfToken_GetHashCode")]
		public static extern int TfToken_GetHashCode(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_TfTokenFastArbitraryLessThan")]
		public static extern IntPtr new_TfTokenFastArbitraryLessThan();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_TfTokenFastArbitraryLessThan")]
		public static extern void delete_TfTokenFastArbitraryLessThan(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfToTokenVector")]
		public static extern IntPtr TfToTokenVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfToStringVector")]
		public static extern IntPtr TfToStringVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeVector_Clear")]
		public static extern void TfTypeVector_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeVector_Add")]
		public static extern void TfTypeVector_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeVector_size")]
		public static extern uint TfTypeVector_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeVector_capacity")]
		public static extern uint TfTypeVector_capacity(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeVector_reserve")]
		public static extern void TfTypeVector_reserve(HandleRef jarg1, uint jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_TfTypeVector__SWIG_0")]
		public static extern IntPtr new_TfTypeVector__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_TfTypeVector__SWIG_1")]
		public static extern IntPtr new_TfTypeVector__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_TfTypeVector__SWIG_2")]
		public static extern IntPtr new_TfTypeVector__SWIG_2(int jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeVector_getitemcopy")]
		public static extern IntPtr TfTypeVector_getitemcopy(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeVector_getitem")]
		public static extern IntPtr TfTypeVector_getitem(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeVector_setitem")]
		public static extern void TfTypeVector_setitem(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeVector_AddRange")]
		public static extern void TfTypeVector_AddRange(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeVector_GetRange")]
		public static extern IntPtr TfTypeVector_GetRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeVector_Insert")]
		public static extern void TfTypeVector_Insert(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeVector_InsertRange")]
		public static extern void TfTypeVector_InsertRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeVector_RemoveAt")]
		public static extern void TfTypeVector_RemoveAt(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeVector_RemoveRange")]
		public static extern void TfTypeVector_RemoveRange(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeVector_Repeat")]
		public static extern IntPtr TfTypeVector_Repeat(HandleRef jarg1, int jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeVector_Reverse__SWIG_0")]
		public static extern void TfTypeVector_Reverse__SWIG_0(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeVector_Reverse__SWIG_1")]
		public static extern void TfTypeVector_Reverse__SWIG_1(HandleRef jarg1, int jarg2, int jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeVector_SetRange")]
		public static extern void TfTypeVector_SetRange(HandleRef jarg1, int jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_TfTypeVector")]
		public static extern void delete_TfTypeVector(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_TfTypeSet__SWIG_0")]
		public static extern IntPtr new_TfTypeSet__SWIG_0();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_TfTypeSet__SWIG_1")]
		public static extern IntPtr new_TfTypeSet__SWIG_1(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeSet_size")]
		public static extern uint TfTypeSet_size(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeSet_empty")]
		public static extern bool TfTypeSet_empty(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeSet_Clear")]
		public static extern void TfTypeSet_Clear(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeSet_Add")]
		public static extern bool TfTypeSet_Add(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeSet_Contains")]
		public static extern bool TfTypeSet_Contains(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeSet_Remove")]
		public static extern bool TfTypeSet_Remove(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeSet_getitem")]
		public static extern IntPtr TfTypeSet_getitem(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeSet_create_iterator_begin")]
		public static extern IntPtr TfTypeSet_create_iterator_begin(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeSet_get_next")]
		public static extern IntPtr TfTypeSet_get_next(HandleRef jarg1, IntPtr jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfTypeSet_destroy_iterator")]
		public static extern void TfTypeSet_destroy_iterator(HandleRef jarg1, IntPtr jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_TfTypeSet")]
		public static extern void delete_TfTypeSet(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_TfType_FactoryBase")]
		public static extern void delete_TfType_FactoryBase(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_TfType_FactoryBase")]
		public static extern IntPtr new_TfType_FactoryBase();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_new_TfType")]
		public static extern IntPtr new_TfType();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfType_GetUnknownType")]
		public static extern IntPtr TfType_GetUnknownType();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfType_FindByName")]
		public static extern IntPtr TfType_FindByName(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfType_FindDerivedByName")]
		public static extern IntPtr TfType_FindDerivedByName(HandleRef jarg1, string jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfType_GetRoot")]
		public static extern IntPtr TfType_GetRoot();

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfType_GetTypeName")]
		public static extern string TfType_GetTypeName(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfType_GetAliases")]
		public static extern IntPtr TfType_GetAliases(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfType_GetBaseTypes")]
		public static extern IntPtr TfType_GetBaseTypes(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfType_GetNBaseTypes")]
		public static extern uint TfType_GetNBaseTypes(HandleRef jarg1, HandleRef jarg2, uint jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfType_GetDirectlyDerivedTypes")]
		public static extern IntPtr TfType_GetDirectlyDerivedTypes(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfType_GetCanonicalType")]
		public static extern IntPtr TfType_GetCanonicalType(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfType_GetAllDerivedTypes")]
		public static extern void TfType_GetAllDerivedTypes(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfType_GetAllAncestorTypes")]
		public static extern void TfType_GetAllAncestorTypes(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfType_IsA")]
		public static extern bool TfType_IsA(HandleRef jarg1, HandleRef jarg2);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfType_IsUnknown")]
		public static extern bool TfType_IsUnknown(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfType_IsRoot")]
		public static extern bool TfType_IsRoot(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfType_IsEnumType")]
		public static extern bool TfType_IsEnumType(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfType_IsPlainOldDataType")]
		public static extern bool TfType_IsPlainOldDataType(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfType_GetSizeof")]
		public static extern uint TfType_GetSizeof(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfType_Declare")]
		public static extern IntPtr TfType_Declare(string jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfType_AddAlias")]
		public static extern void TfType_AddAlias(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfType_Alias")]
		public static extern IntPtr TfType_Alias(HandleRef jarg1, HandleRef jarg2, string jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfType_CastToAncestor__SWIG_0")]
		public static extern IntPtr TfType_CastToAncestor__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfType_CastFromAncestor__SWIG_0")]
		public static extern IntPtr TfType_CastFromAncestor__SWIG_0(HandleRef jarg1, HandleRef jarg2, HandleRef jarg3);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_TfType")]
		public static extern void delete_TfType(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_delete_TfWarning")]
		public static extern void delete_TfWarning(HandleRef jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfError_SWIGUpcast")]
		public static extern IntPtr TfError_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfStatus_SWIGUpcast")]
		public static extern IntPtr TfStatus_SWIGUpcast(IntPtr jarg1);

		[DllImport(UsdDll.USD_EXPORT_NAME, EntryPoint = "CSharp_pxr_TfWarning_SWIGUpcast")]
		public static extern IntPtr TfWarning_SWIGUpcast(IntPtr jarg1);
	}
}
