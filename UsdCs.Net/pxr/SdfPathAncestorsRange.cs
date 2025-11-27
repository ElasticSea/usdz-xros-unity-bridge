using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfPathAncestorsRange : IDisposable
	{
		public class iterator : IDisposable
		{
			private HandleRef swigCPtr;

			protected bool swigCMemOwn;

			public iterator(IntPtr cPtr, bool cMemoryOwn)
			{
				swigCMemOwn = cMemoryOwn;
				swigCPtr = new HandleRef(this, cPtr);
			}

			public static HandleRef getCPtr(iterator obj)
			{
				return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
			}

			public static HandleRef swigRelease(iterator obj)
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

			~iterator()
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
							SdfPINVOKE.delete_SdfPathAncestorsRange_iterator(swigCPtr);
						}
						swigCPtr = new HandleRef(null, IntPtr.Zero);
					}
				}
			}

			public iterator(SdfPath path)
				: this(SdfPINVOKE.new_SdfPathAncestorsRange_iterator__SWIG_0(SdfPath.getCPtr(path)), cMemoryOwn: true)
			{
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
			}

			public iterator()
				: this(SdfPINVOKE.new_SdfPathAncestorsRange_iterator__SWIG_1(), cMemoryOwn: true)
			{
			}

			public SdfPath __ref__()
			{
				return new SdfPath(SdfPINVOKE.SdfPathAncestorsRange_iterator___ref__(swigCPtr), cMemoryOwn: false);
			}

			public SdfPath __deref__()
			{
				IntPtr intPtr = SdfPINVOKE.SdfPathAncestorsRange_iterator___deref__(swigCPtr);
				return (intPtr == IntPtr.Zero) ? null : new SdfPath(intPtr, cMemoryOwn: false);
			}

			public uint GetPathElementCount()
			{
				return SdfPINVOKE.SdfPathAncestorsRange_iterator_GetPathElementCount(swigCPtr);
			}

			public bool IsAbsolutePath()
			{
				return SdfPINVOKE.SdfPathAncestorsRange_iterator_IsAbsolutePath(swigCPtr);
			}

			public bool IsAbsoluteRootPath()
			{
				return SdfPINVOKE.SdfPathAncestorsRange_iterator_IsAbsoluteRootPath(swigCPtr);
			}

			public bool IsPrimPath()
			{
				return SdfPINVOKE.SdfPathAncestorsRange_iterator_IsPrimPath(swigCPtr);
			}

			public bool IsAbsoluteRootOrPrimPath()
			{
				return SdfPINVOKE.SdfPathAncestorsRange_iterator_IsAbsoluteRootOrPrimPath(swigCPtr);
			}

			public bool IsRootPrimPath()
			{
				return SdfPINVOKE.SdfPathAncestorsRange_iterator_IsRootPrimPath(swigCPtr);
			}

			public bool IsPropertyPath()
			{
				return SdfPINVOKE.SdfPathAncestorsRange_iterator_IsPropertyPath(swigCPtr);
			}

			public bool IsPrimPropertyPath()
			{
				return SdfPINVOKE.SdfPathAncestorsRange_iterator_IsPrimPropertyPath(swigCPtr);
			}

			public bool IsNamespacedPropertyPath()
			{
				return SdfPINVOKE.SdfPathAncestorsRange_iterator_IsNamespacedPropertyPath(swigCPtr);
			}

			public bool IsPrimVariantSelectionPath()
			{
				return SdfPINVOKE.SdfPathAncestorsRange_iterator_IsPrimVariantSelectionPath(swigCPtr);
			}

			public bool IsPrimOrPrimVariantSelectionPath()
			{
				return SdfPINVOKE.SdfPathAncestorsRange_iterator_IsPrimOrPrimVariantSelectionPath(swigCPtr);
			}

			public bool ContainsPrimVariantSelection()
			{
				return SdfPINVOKE.SdfPathAncestorsRange_iterator_ContainsPrimVariantSelection(swigCPtr);
			}

			public bool ContainsPropertyElements()
			{
				return SdfPINVOKE.SdfPathAncestorsRange_iterator_ContainsPropertyElements(swigCPtr);
			}

			public bool ContainsTargetPath()
			{
				return SdfPINVOKE.SdfPathAncestorsRange_iterator_ContainsTargetPath(swigCPtr);
			}

			public bool IsRelationalAttributePath()
			{
				return SdfPINVOKE.SdfPathAncestorsRange_iterator_IsRelationalAttributePath(swigCPtr);
			}

			public bool IsTargetPath()
			{
				return SdfPINVOKE.SdfPathAncestorsRange_iterator_IsTargetPath(swigCPtr);
			}

			public bool IsMapperPath()
			{
				return SdfPINVOKE.SdfPathAncestorsRange_iterator_IsMapperPath(swigCPtr);
			}

			public bool IsMapperArgPath()
			{
				return SdfPINVOKE.SdfPathAncestorsRange_iterator_IsMapperArgPath(swigCPtr);
			}

			public bool IsExpressionPath()
			{
				return SdfPINVOKE.SdfPathAncestorsRange_iterator_IsExpressionPath(swigCPtr);
			}

			public bool IsEmpty()
			{
				return SdfPINVOKE.SdfPathAncestorsRange_iterator_IsEmpty(swigCPtr);
			}

			public TfToken GetAsToken()
			{
				return new TfToken(SdfPINVOKE.SdfPathAncestorsRange_iterator_GetAsToken(swigCPtr), cMemoryOwn: true);
			}

			public TfToken GetToken()
			{
				return new TfToken(SdfPINVOKE.SdfPathAncestorsRange_iterator_GetToken(swigCPtr), cMemoryOwn: false);
			}

			public string GetAsString()
			{
				return SdfPINVOKE.SdfPathAncestorsRange_iterator_GetAsString(swigCPtr);
			}

			public string GetString()
			{
				return SdfPINVOKE.SdfPathAncestorsRange_iterator_GetString(swigCPtr);
			}

			public string GetText()
			{
				return SdfPINVOKE.SdfPathAncestorsRange_iterator_GetText(swigCPtr);
			}

			public SdfPathVector GetPrefixes()
			{
				return new SdfPathVector(SdfPINVOKE.SdfPathAncestorsRange_iterator_GetPrefixes__SWIG_0(swigCPtr), cMemoryOwn: true);
			}

			public void GetPrefixes(SdfPathVector prefixes)
			{
				SdfPINVOKE.SdfPathAncestorsRange_iterator_GetPrefixes__SWIG_1(swigCPtr, SdfPathVector.getCPtr(prefixes));
			}

			public SdfPathAncestorsRange GetAncestorsRange()
			{
				return new SdfPathAncestorsRange(SdfPINVOKE.SdfPathAncestorsRange_iterator_GetAncestorsRange(swigCPtr), cMemoryOwn: true);
			}

			public string GetName()
			{
				return SdfPINVOKE.SdfPathAncestorsRange_iterator_GetName(swigCPtr);
			}

			public TfToken GetNameToken()
			{
				return new TfToken(SdfPINVOKE.SdfPathAncestorsRange_iterator_GetNameToken(swigCPtr), cMemoryOwn: false);
			}

			public string GetElementString()
			{
				return SdfPINVOKE.SdfPathAncestorsRange_iterator_GetElementString(swigCPtr);
			}

			public TfToken GetElementToken()
			{
				return new TfToken(SdfPINVOKE.SdfPathAncestorsRange_iterator_GetElementToken(swigCPtr), cMemoryOwn: true);
			}

			public SdfPath ReplaceName(TfToken newName)
			{
				SdfPath result = new SdfPath(SdfPINVOKE.SdfPathAncestorsRange_iterator_ReplaceName(swigCPtr, TfToken.getCPtr(newName)), cMemoryOwn: true);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}

			public SdfPath GetTargetPath()
			{
				return new SdfPath(SdfPINVOKE.SdfPathAncestorsRange_iterator_GetTargetPath(swigCPtr), cMemoryOwn: false);
			}

			public void GetAllTargetPathsRecursively(SdfPathVector result)
			{
				SdfPINVOKE.SdfPathAncestorsRange_iterator_GetAllTargetPathsRecursively(swigCPtr, SdfPathVector.getCPtr(result));
			}

			public StdStringPair GetVariantSelection()
			{
				return new StdStringPair(SdfPINVOKE.SdfPathAncestorsRange_iterator_GetVariantSelection(swigCPtr), cMemoryOwn: true);
			}

			public bool HasPrefix(SdfPath prefix)
			{
				bool result = SdfPINVOKE.SdfPathAncestorsRange_iterator_HasPrefix(swigCPtr, SdfPath.getCPtr(prefix));
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}

			public SdfPath GetParentPath()
			{
				return new SdfPath(SdfPINVOKE.SdfPathAncestorsRange_iterator_GetParentPath(swigCPtr), cMemoryOwn: true);
			}

			public SdfPath GetPrimPath()
			{
				return new SdfPath(SdfPINVOKE.SdfPathAncestorsRange_iterator_GetPrimPath(swigCPtr), cMemoryOwn: true);
			}

			public SdfPath GetPrimOrPrimVariantSelectionPath()
			{
				return new SdfPath(SdfPINVOKE.SdfPathAncestorsRange_iterator_GetPrimOrPrimVariantSelectionPath(swigCPtr), cMemoryOwn: true);
			}

			public SdfPath GetAbsoluteRootOrPrimPath()
			{
				return new SdfPath(SdfPINVOKE.SdfPathAncestorsRange_iterator_GetAbsoluteRootOrPrimPath(swigCPtr), cMemoryOwn: true);
			}

			public SdfPath StripAllVariantSelections()
			{
				return new SdfPath(SdfPINVOKE.SdfPathAncestorsRange_iterator_StripAllVariantSelections(swigCPtr), cMemoryOwn: true);
			}

			public SdfPath AppendPath(SdfPath newSuffix)
			{
				SdfPath result = new SdfPath(SdfPINVOKE.SdfPathAncestorsRange_iterator_AppendPath(swigCPtr, SdfPath.getCPtr(newSuffix)), cMemoryOwn: true);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}

			public SdfPath AppendChild(TfToken childName)
			{
				SdfPath result = new SdfPath(SdfPINVOKE.SdfPathAncestorsRange_iterator_AppendChild(swigCPtr, TfToken.getCPtr(childName)), cMemoryOwn: true);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}

			public SdfPath AppendProperty(TfToken propName)
			{
				SdfPath result = new SdfPath(SdfPINVOKE.SdfPathAncestorsRange_iterator_AppendProperty(swigCPtr, TfToken.getCPtr(propName)), cMemoryOwn: true);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}

			public SdfPath AppendVariantSelection(string variantSet, string variant)
			{
				SdfPath result = new SdfPath(SdfPINVOKE.SdfPathAncestorsRange_iterator_AppendVariantSelection(swigCPtr, variantSet, variant), cMemoryOwn: true);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}

			public SdfPath AppendTarget(SdfPath targetPath)
			{
				SdfPath result = new SdfPath(SdfPINVOKE.SdfPathAncestorsRange_iterator_AppendTarget(swigCPtr, SdfPath.getCPtr(targetPath)), cMemoryOwn: true);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}

			public SdfPath AppendRelationalAttribute(TfToken attrName)
			{
				SdfPath result = new SdfPath(SdfPINVOKE.SdfPathAncestorsRange_iterator_AppendRelationalAttribute(swigCPtr, TfToken.getCPtr(attrName)), cMemoryOwn: true);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}

			public SdfPath ReplaceTargetPath(SdfPath newTargetPath)
			{
				SdfPath result = new SdfPath(SdfPINVOKE.SdfPathAncestorsRange_iterator_ReplaceTargetPath(swigCPtr, SdfPath.getCPtr(newTargetPath)), cMemoryOwn: true);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}

			public SdfPath AppendMapper(SdfPath targetPath)
			{
				SdfPath result = new SdfPath(SdfPINVOKE.SdfPathAncestorsRange_iterator_AppendMapper(swigCPtr, SdfPath.getCPtr(targetPath)), cMemoryOwn: true);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}

			public SdfPath AppendMapperArg(TfToken argName)
			{
				SdfPath result = new SdfPath(SdfPINVOKE.SdfPathAncestorsRange_iterator_AppendMapperArg(swigCPtr, TfToken.getCPtr(argName)), cMemoryOwn: true);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}

			public SdfPath AppendExpression()
			{
				return new SdfPath(SdfPINVOKE.SdfPathAncestorsRange_iterator_AppendExpression(swigCPtr), cMemoryOwn: true);
			}

			public SdfPath AppendElementString(string element)
			{
				SdfPath result = new SdfPath(SdfPINVOKE.SdfPathAncestorsRange_iterator_AppendElementString(swigCPtr, element), cMemoryOwn: true);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}

			public SdfPath AppendElementToken(TfToken elementTok)
			{
				SdfPath result = new SdfPath(SdfPINVOKE.SdfPathAncestorsRange_iterator_AppendElementToken(swigCPtr, TfToken.getCPtr(elementTok)), cMemoryOwn: true);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}

			public SdfPath ReplacePrefix(SdfPath oldPrefix, SdfPath newPrefix, bool fixTargetPaths)
			{
				SdfPath result = new SdfPath(SdfPINVOKE.SdfPathAncestorsRange_iterator_ReplacePrefix__SWIG_0(swigCPtr, SdfPath.getCPtr(oldPrefix), SdfPath.getCPtr(newPrefix), fixTargetPaths), cMemoryOwn: true);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}

			public SdfPath ReplacePrefix(SdfPath oldPrefix, SdfPath newPrefix)
			{
				SdfPath result = new SdfPath(SdfPINVOKE.SdfPathAncestorsRange_iterator_ReplacePrefix__SWIG_1(swigCPtr, SdfPath.getCPtr(oldPrefix), SdfPath.getCPtr(newPrefix)), cMemoryOwn: true);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}

			public SdfPath GetCommonPrefix(SdfPath path)
			{
				SdfPath result = new SdfPath(SdfPINVOKE.SdfPathAncestorsRange_iterator_GetCommonPrefix(swigCPtr, SdfPath.getCPtr(path)), cMemoryOwn: true);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}

			public SdfPathPair RemoveCommonSuffix(SdfPath otherPath, bool stopAtRootPrim)
			{
				SdfPathPair result = new SdfPathPair(SdfPINVOKE.SdfPathAncestorsRange_iterator_RemoveCommonSuffix__SWIG_0(swigCPtr, SdfPath.getCPtr(otherPath), stopAtRootPrim), cMemoryOwn: true);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}

			public SdfPathPair RemoveCommonSuffix(SdfPath otherPath)
			{
				SdfPathPair result = new SdfPathPair(SdfPINVOKE.SdfPathAncestorsRange_iterator_RemoveCommonSuffix__SWIG_1(swigCPtr, SdfPath.getCPtr(otherPath)), cMemoryOwn: true);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}

			public SdfPath MakeAbsolutePath(SdfPath anchor)
			{
				SdfPath result = new SdfPath(SdfPINVOKE.SdfPathAncestorsRange_iterator_MakeAbsolutePath(swigCPtr, SdfPath.getCPtr(anchor)), cMemoryOwn: true);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}

			public SdfPath MakeRelativePath(SdfPath anchor)
			{
				SdfPath result = new SdfPath(SdfPINVOKE.SdfPathAncestorsRange_iterator_MakeRelativePath(swigCPtr, SdfPath.getCPtr(anchor)), cMemoryOwn: true);
				if (UsdCsPINVOKE.SWIGPendingException.Pending)
				{
					throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
				}
				return result;
			}

			public uint GetHash()
			{
				return SdfPINVOKE.SdfPathAncestorsRange_iterator_GetHash(swigCPtr);
			}
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public SdfPathAncestorsRange(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfPathAncestorsRange obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfPathAncestorsRange obj)
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

		~SdfPathAncestorsRange()
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
						SdfPINVOKE.delete_SdfPathAncestorsRange(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfPathAncestorsRange(SdfPath path)
			: this(SdfPINVOKE.new_SdfPathAncestorsRange(SdfPath.getCPtr(path)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfPath GetPath()
		{
			return new SdfPath(SdfPINVOKE.SdfPathAncestorsRange_GetPath(swigCPtr), cMemoryOwn: false);
		}

		public iterator begin()
		{
			return new iterator(SdfPINVOKE.SdfPathAncestorsRange_begin(swigCPtr), cMemoryOwn: true);
		}

		public iterator end()
		{
			return new iterator(SdfPINVOKE.SdfPathAncestorsRange_end(swigCPtr), cMemoryOwn: true);
		}
	}
}
