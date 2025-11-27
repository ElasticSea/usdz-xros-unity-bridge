using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfPath : IDisposable
	{
		public class Hash : IDisposable
		{
			private HandleRef swigCPtr;

			protected bool swigCMemOwn;

			public Hash(IntPtr cPtr, bool cMemoryOwn)
			{
				swigCMemOwn = cMemoryOwn;
				swigCPtr = new HandleRef(this, cPtr);
			}

			public static HandleRef getCPtr(Hash obj)
			{
				return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
			}

			public static HandleRef swigRelease(Hash obj)
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

			~Hash()
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
							SdfPINVOKE.delete_SdfPath_Hash(swigCPtr);
						}
						swigCPtr = new HandleRef(null, IntPtr.Zero);
					}
				}
			}

			public Hash()
				: this(SdfPINVOKE.new_SdfPath_Hash(), cMemoryOwn: true)
			{
			}
		}

		public class FastLessThan : IDisposable
		{
			private HandleRef swigCPtr;

			protected bool swigCMemOwn;

			public FastLessThan(IntPtr cPtr, bool cMemoryOwn)
			{
				swigCMemOwn = cMemoryOwn;
				swigCPtr = new HandleRef(this, cPtr);
			}

			public static HandleRef getCPtr(FastLessThan obj)
			{
				return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
			}

			public static HandleRef swigRelease(FastLessThan obj)
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

			~FastLessThan()
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
							SdfPINVOKE.delete_SdfPath_FastLessThan(swigCPtr);
						}
						swigCPtr = new HandleRef(null, IntPtr.Zero);
					}
				}
			}

			public FastLessThan()
				: this(SdfPINVOKE.new_SdfPath_FastLessThan(), cMemoryOwn: true)
			{
			}
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public static string emptyPath => GetEmptyPath();

		public SdfPath(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfPath obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfPath obj)
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

		~SdfPath()
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
						SdfPINVOKE.delete_SdfPath(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		private static SdfPath GetEmptyPath()
		{
			return new SdfPath(SdfPINVOKE.SdfPath_GetEmptyPath(), cMemoryOwn: false);
		}

		public static SdfPath AbsoluteRootPath()
		{
			return new SdfPath(SdfPINVOKE.SdfPath_AbsoluteRootPath(), cMemoryOwn: false);
		}

		public static SdfPath ReflexiveRelativePath()
		{
			return new SdfPath(SdfPINVOKE.SdfPath_ReflexiveRelativePath(), cMemoryOwn: false);
		}

		public SdfPath()
			: this(SdfPINVOKE.new_SdfPath__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfPath(string path)
			: this(SdfPINVOKE.new_SdfPath__SWIG_1(path), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public uint GetPathElementCount()
		{
			return SdfPINVOKE.SdfPath_GetPathElementCount(swigCPtr);
		}

		public bool IsAbsolutePath()
		{
			return SdfPINVOKE.SdfPath_IsAbsolutePath(swigCPtr);
		}

		public bool IsAbsoluteRootPath()
		{
			return SdfPINVOKE.SdfPath_IsAbsoluteRootPath(swigCPtr);
		}

		public bool IsPrimPath()
		{
			return SdfPINVOKE.SdfPath_IsPrimPath(swigCPtr);
		}

		public bool IsAbsoluteRootOrPrimPath()
		{
			return SdfPINVOKE.SdfPath_IsAbsoluteRootOrPrimPath(swigCPtr);
		}

		public bool IsRootPrimPath()
		{
			return SdfPINVOKE.SdfPath_IsRootPrimPath(swigCPtr);
		}

		public bool IsPropertyPath()
		{
			return SdfPINVOKE.SdfPath_IsPropertyPath(swigCPtr);
		}

		public bool IsPrimPropertyPath()
		{
			return SdfPINVOKE.SdfPath_IsPrimPropertyPath(swigCPtr);
		}

		public bool IsNamespacedPropertyPath()
		{
			return SdfPINVOKE.SdfPath_IsNamespacedPropertyPath(swigCPtr);
		}

		public bool IsPrimVariantSelectionPath()
		{
			return SdfPINVOKE.SdfPath_IsPrimVariantSelectionPath(swigCPtr);
		}

		public bool IsPrimOrPrimVariantSelectionPath()
		{
			return SdfPINVOKE.SdfPath_IsPrimOrPrimVariantSelectionPath(swigCPtr);
		}

		public bool ContainsPrimVariantSelection()
		{
			return SdfPINVOKE.SdfPath_ContainsPrimVariantSelection(swigCPtr);
		}

		public bool ContainsPropertyElements()
		{
			return SdfPINVOKE.SdfPath_ContainsPropertyElements(swigCPtr);
		}

		public bool ContainsTargetPath()
		{
			return SdfPINVOKE.SdfPath_ContainsTargetPath(swigCPtr);
		}

		public bool IsRelationalAttributePath()
		{
			return SdfPINVOKE.SdfPath_IsRelationalAttributePath(swigCPtr);
		}

		public bool IsTargetPath()
		{
			return SdfPINVOKE.SdfPath_IsTargetPath(swigCPtr);
		}

		public bool IsMapperPath()
		{
			return SdfPINVOKE.SdfPath_IsMapperPath(swigCPtr);
		}

		public bool IsMapperArgPath()
		{
			return SdfPINVOKE.SdfPath_IsMapperArgPath(swigCPtr);
		}

		public bool IsExpressionPath()
		{
			return SdfPINVOKE.SdfPath_IsExpressionPath(swigCPtr);
		}

		public bool IsEmpty()
		{
			return SdfPINVOKE.SdfPath_IsEmpty(swigCPtr);
		}

		public TfToken GetAsToken()
		{
			return new TfToken(SdfPINVOKE.SdfPath_GetAsToken(swigCPtr), cMemoryOwn: true);
		}

		public TfToken GetToken()
		{
			return new TfToken(SdfPINVOKE.SdfPath_GetToken(swigCPtr), cMemoryOwn: false);
		}

		public string GetAsString()
		{
			return SdfPINVOKE.SdfPath_GetAsString(swigCPtr);
		}

		public string GetString()
		{
			return SdfPINVOKE.SdfPath_GetString(swigCPtr);
		}

		public string GetText()
		{
			return SdfPINVOKE.SdfPath_GetText(swigCPtr);
		}

		public SdfPathVector GetPrefixes()
		{
			return new SdfPathVector(SdfPINVOKE.SdfPath_GetPrefixes__SWIG_0(swigCPtr), cMemoryOwn: true);
		}

		public void GetPrefixes(SdfPathVector prefixes)
		{
			SdfPINVOKE.SdfPath_GetPrefixes__SWIG_1(swigCPtr, SdfPathVector.getCPtr(prefixes));
		}

		public SdfPathAncestorsRange GetAncestorsRange()
		{
			return new SdfPathAncestorsRange(SdfPINVOKE.SdfPath_GetAncestorsRange(swigCPtr), cMemoryOwn: true);
		}

		public string GetName()
		{
			return SdfPINVOKE.SdfPath_GetName(swigCPtr);
		}

		public TfToken GetNameToken()
		{
			return new TfToken(SdfPINVOKE.SdfPath_GetNameToken(swigCPtr), cMemoryOwn: false);
		}

		public string GetElementString()
		{
			return SdfPINVOKE.SdfPath_GetElementString(swigCPtr);
		}

		public TfToken GetElementToken()
		{
			return new TfToken(SdfPINVOKE.SdfPath_GetElementToken(swigCPtr), cMemoryOwn: true);
		}

		public SdfPath ReplaceName(TfToken newName)
		{
			SdfPath result = new SdfPath(SdfPINVOKE.SdfPath_ReplaceName(swigCPtr, TfToken.getCPtr(newName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPath GetTargetPath()
		{
			return new SdfPath(SdfPINVOKE.SdfPath_GetTargetPath(swigCPtr), cMemoryOwn: false);
		}

		public void GetAllTargetPathsRecursively(SdfPathVector result)
		{
			SdfPINVOKE.SdfPath_GetAllTargetPathsRecursively(swigCPtr, SdfPathVector.getCPtr(result));
		}

		public StdStringPair GetVariantSelection()
		{
			return new StdStringPair(SdfPINVOKE.SdfPath_GetVariantSelection(swigCPtr), cMemoryOwn: true);
		}

		public bool HasPrefix(SdfPath prefix)
		{
			bool result = SdfPINVOKE.SdfPath_HasPrefix(swigCPtr, getCPtr(prefix));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPath GetParentPath()
		{
			return new SdfPath(SdfPINVOKE.SdfPath_GetParentPath(swigCPtr), cMemoryOwn: true);
		}

		public SdfPath GetPrimPath()
		{
			return new SdfPath(SdfPINVOKE.SdfPath_GetPrimPath(swigCPtr), cMemoryOwn: true);
		}

		public SdfPath GetPrimOrPrimVariantSelectionPath()
		{
			return new SdfPath(SdfPINVOKE.SdfPath_GetPrimOrPrimVariantSelectionPath(swigCPtr), cMemoryOwn: true);
		}

		public SdfPath GetAbsoluteRootOrPrimPath()
		{
			return new SdfPath(SdfPINVOKE.SdfPath_GetAbsoluteRootOrPrimPath(swigCPtr), cMemoryOwn: true);
		}

		public SdfPath StripAllVariantSelections()
		{
			return new SdfPath(SdfPINVOKE.SdfPath_StripAllVariantSelections(swigCPtr), cMemoryOwn: true);
		}

		public SdfPath AppendPath(SdfPath newSuffix)
		{
			SdfPath result = new SdfPath(SdfPINVOKE.SdfPath_AppendPath(swigCPtr, getCPtr(newSuffix)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPath AppendChild(TfToken childName)
		{
			SdfPath result = new SdfPath(SdfPINVOKE.SdfPath_AppendChild(swigCPtr, TfToken.getCPtr(childName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPath AppendProperty(TfToken propName)
		{
			SdfPath result = new SdfPath(SdfPINVOKE.SdfPath_AppendProperty(swigCPtr, TfToken.getCPtr(propName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPath AppendVariantSelection(string variantSet, string variant)
		{
			SdfPath result = new SdfPath(SdfPINVOKE.SdfPath_AppendVariantSelection(swigCPtr, variantSet, variant), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPath AppendTarget(SdfPath targetPath)
		{
			SdfPath result = new SdfPath(SdfPINVOKE.SdfPath_AppendTarget(swigCPtr, getCPtr(targetPath)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPath AppendRelationalAttribute(TfToken attrName)
		{
			SdfPath result = new SdfPath(SdfPINVOKE.SdfPath_AppendRelationalAttribute(swigCPtr, TfToken.getCPtr(attrName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPath ReplaceTargetPath(SdfPath newTargetPath)
		{
			SdfPath result = new SdfPath(SdfPINVOKE.SdfPath_ReplaceTargetPath(swigCPtr, getCPtr(newTargetPath)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPath AppendMapper(SdfPath targetPath)
		{
			SdfPath result = new SdfPath(SdfPINVOKE.SdfPath_AppendMapper(swigCPtr, getCPtr(targetPath)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPath AppendMapperArg(TfToken argName)
		{
			SdfPath result = new SdfPath(SdfPINVOKE.SdfPath_AppendMapperArg(swigCPtr, TfToken.getCPtr(argName)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPath AppendExpression()
		{
			return new SdfPath(SdfPINVOKE.SdfPath_AppendExpression(swigCPtr), cMemoryOwn: true);
		}

		public SdfPath AppendElementString(string element)
		{
			SdfPath result = new SdfPath(SdfPINVOKE.SdfPath_AppendElementString(swigCPtr, element), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPath AppendElementToken(TfToken elementTok)
		{
			SdfPath result = new SdfPath(SdfPINVOKE.SdfPath_AppendElementToken(swigCPtr, TfToken.getCPtr(elementTok)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPath ReplacePrefix(SdfPath oldPrefix, SdfPath newPrefix, bool fixTargetPaths)
		{
			SdfPath result = new SdfPath(SdfPINVOKE.SdfPath_ReplacePrefix__SWIG_0(swigCPtr, getCPtr(oldPrefix), getCPtr(newPrefix), fixTargetPaths), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPath ReplacePrefix(SdfPath oldPrefix, SdfPath newPrefix)
		{
			SdfPath result = new SdfPath(SdfPINVOKE.SdfPath_ReplacePrefix__SWIG_1(swigCPtr, getCPtr(oldPrefix), getCPtr(newPrefix)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPath GetCommonPrefix(SdfPath path)
		{
			SdfPath result = new SdfPath(SdfPINVOKE.SdfPath_GetCommonPrefix(swigCPtr, getCPtr(path)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPathPair RemoveCommonSuffix(SdfPath otherPath, bool stopAtRootPrim)
		{
			SdfPathPair result = new SdfPathPair(SdfPINVOKE.SdfPath_RemoveCommonSuffix__SWIG_0(swigCPtr, getCPtr(otherPath), stopAtRootPrim), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPathPair RemoveCommonSuffix(SdfPath otherPath)
		{
			SdfPathPair result = new SdfPathPair(SdfPINVOKE.SdfPath_RemoveCommonSuffix__SWIG_1(swigCPtr, getCPtr(otherPath)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPath MakeAbsolutePath(SdfPath anchor)
		{
			SdfPath result = new SdfPath(SdfPINVOKE.SdfPath_MakeAbsolutePath(swigCPtr, getCPtr(anchor)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdfPath MakeRelativePath(SdfPath anchor)
		{
			SdfPath result = new SdfPath(SdfPINVOKE.SdfPath_MakeRelativePath(swigCPtr, getCPtr(anchor)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IsValidIdentifier(string name)
		{
			bool result = SdfPINVOKE.SdfPath_IsValidIdentifier(name);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IsValidNamespacedIdentifier(string name)
		{
			bool result = SdfPINVOKE.SdfPath_IsValidNamespacedIdentifier(name);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static StdStringVector TokenizeIdentifier(string name)
		{
			StdStringVector result = new StdStringVector(SdfPINVOKE.SdfPath_TokenizeIdentifier(name), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfTokenVector TokenizeIdentifierAsTokens(string name)
		{
			TfTokenVector result = new TfTokenVector(SdfPINVOKE.SdfPath_TokenizeIdentifierAsTokens(name), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string JoinIdentifier(StdStringVector names)
		{
			string result = SdfPINVOKE.SdfPath_JoinIdentifier__SWIG_0(StdStringVector.getCPtr(names));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string JoinIdentifier(TfTokenVector names)
		{
			string result = SdfPINVOKE.SdfPath_JoinIdentifier__SWIG_1(TfTokenVector.getCPtr(names));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string JoinIdentifier(string lhs, string rhs)
		{
			string result = SdfPINVOKE.SdfPath_JoinIdentifier__SWIG_2(lhs, rhs);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string JoinIdentifier(TfToken lhs, TfToken rhs)
		{
			string result = SdfPINVOKE.SdfPath_JoinIdentifier__SWIG_3(TfToken.getCPtr(lhs), TfToken.getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string StripNamespace(string name)
		{
			string result = SdfPINVOKE.SdfPath_StripNamespace__SWIG_0(name);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfToken StripNamespace(TfToken name)
		{
			TfToken result = new TfToken(SdfPINVOKE.SdfPath_StripNamespace__SWIG_1(TfToken.getCPtr(name)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SWIGTYPE_p_std__pairT_std__string_bool_t StripPrefixNamespace(string name, string matchNamespace)
		{
			SWIGTYPE_p_std__pairT_std__string_bool_t result = new SWIGTYPE_p_std__pairT_std__string_bool_t(SdfPINVOKE.SdfPath_StripPrefixNamespace(name, matchNamespace), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IsValidPathString(string pathString, out string errMsg)
		{
			bool result = SdfPINVOKE.SdfPath_IsValidPathString__SWIG_0(pathString, out errMsg);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IsValidPathString(string pathString)
		{
			bool result = SdfPINVOKE.SdfPath_IsValidPathString__SWIG_1(pathString);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public uint GetHash()
		{
			return SdfPINVOKE.SdfPath_GetHash(swigCPtr);
		}

		public static SdfPathVector GetConciseRelativePaths(SdfPathVector paths)
		{
			SdfPathVector result = new SdfPathVector(SdfPINVOKE.SdfPath_GetConciseRelativePaths(SdfPathVector.getCPtr(paths)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void RemoveDescendentPaths(SdfPathVector paths)
		{
			SdfPINVOKE.SdfPath_RemoveDescendentPaths(SdfPathVector.getCPtr(paths));
		}

		public static void RemoveAncestorPaths(SdfPathVector paths)
		{
			SdfPINVOKE.SdfPath_RemoveAncestorPaths(SdfPathVector.getCPtr(paths));
		}

		public static bool Equals(SdfPath lhs, SdfPath rhs)
		{
			bool result = SdfPINVOKE.SdfPath_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(SdfPath lhs, SdfPath rhs)
		{
			bool flag = (object)lhs == null;
			bool flag2 = (object)rhs == null;
			if (flag == flag2)
			{
				if (!(flag && flag2))
				{
					return Equals(lhs, rhs);
				}
				return true;
			}
			return false;
		}

		public static bool operator !=(SdfPath lhs, SdfPath rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as SdfPath);
		}

		public override int GetHashCode()
		{
			return SdfPINVOKE.SdfPath_GetHashCode(swigCPtr);
		}

		public static implicit operator string(SdfPath value)
		{
			return value.GetText();
		}

		public static implicit operator SdfPath(string value)
		{
			return new SdfPath(value);
		}

		public override string ToString()
		{
			return this;
		}
	}
}
