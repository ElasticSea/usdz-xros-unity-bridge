using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdrRegistry : NdrRegistry
	{
		private HandleRef swigCPtr;

		public SdrRegistry(IntPtr cPtr, bool cMemoryOwn)
			: base(SdrPINVOKE.SdrRegistry_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdrRegistry obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdrRegistry obj)
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

		protected override void Dispose(bool disposing)
		{
			lock (this)
			{
				if (swigCPtr.Handle != IntPtr.Zero)
				{
					if (swigCMemOwn)
					{
						swigCMemOwn = false;
						throw new MethodAccessException("C++ destructor does not have public access");
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public static SdrRegistry GetInstance()
		{
			return new SdrRegistry(SdrPINVOKE.SdrRegistry_GetInstance(), cMemoryOwn: false);
		}

		public SdrShaderNode GetShaderNodeByIdentifier(TfToken identifier, TfTokenVector typePriority)
		{
			IntPtr intPtr = SdrPINVOKE.SdrRegistry_GetShaderNodeByIdentifier__SWIG_0(swigCPtr, TfToken.getCPtr(identifier), TfTokenVector.getCPtr(typePriority));
			SdrShaderNode result = ((intPtr == IntPtr.Zero) ? null : new SdrShaderNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdrShaderNode GetShaderNodeByIdentifier(TfToken identifier)
		{
			IntPtr intPtr = SdrPINVOKE.SdrRegistry_GetShaderNodeByIdentifier__SWIG_1(swigCPtr, TfToken.getCPtr(identifier));
			SdrShaderNode result = ((intPtr == IntPtr.Zero) ? null : new SdrShaderNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdrShaderNode GetShaderNodeByIdentifierAndType(TfToken identifier, TfToken nodeType)
		{
			IntPtr intPtr = SdrPINVOKE.SdrRegistry_GetShaderNodeByIdentifierAndType(swigCPtr, TfToken.getCPtr(identifier), TfToken.getCPtr(nodeType));
			SdrShaderNode result = ((intPtr == IntPtr.Zero) ? null : new SdrShaderNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdrShaderNode GetShaderNodeByName(string name, TfTokenVector typePriority, NdrVersionFilter filter)
		{
			IntPtr intPtr = SdrPINVOKE.SdrRegistry_GetShaderNodeByName__SWIG_0(swigCPtr, name, TfTokenVector.getCPtr(typePriority), (int)filter);
			SdrShaderNode result = ((intPtr == IntPtr.Zero) ? null : new SdrShaderNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdrShaderNode GetShaderNodeByName(string name, TfTokenVector typePriority)
		{
			IntPtr intPtr = SdrPINVOKE.SdrRegistry_GetShaderNodeByName__SWIG_1(swigCPtr, name, TfTokenVector.getCPtr(typePriority));
			SdrShaderNode result = ((intPtr == IntPtr.Zero) ? null : new SdrShaderNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdrShaderNode GetShaderNodeByName(string name)
		{
			IntPtr intPtr = SdrPINVOKE.SdrRegistry_GetShaderNodeByName__SWIG_2(swigCPtr, name);
			SdrShaderNode result = ((intPtr == IntPtr.Zero) ? null : new SdrShaderNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdrShaderNode GetShaderNodeByNameAndType(string name, TfToken nodeType, NdrVersionFilter filter)
		{
			IntPtr intPtr = SdrPINVOKE.SdrRegistry_GetShaderNodeByNameAndType__SWIG_0(swigCPtr, name, TfToken.getCPtr(nodeType), (int)filter);
			SdrShaderNode result = ((intPtr == IntPtr.Zero) ? null : new SdrShaderNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdrShaderNode GetShaderNodeByNameAndType(string name, TfToken nodeType)
		{
			IntPtr intPtr = SdrPINVOKE.SdrRegistry_GetShaderNodeByNameAndType__SWIG_1(swigCPtr, name, TfToken.getCPtr(nodeType));
			SdrShaderNode result = ((intPtr == IntPtr.Zero) ? null : new SdrShaderNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdrShaderNode GetShaderNodeFromAsset(SdfAssetPath shaderAsset, NdrTokenMap metadata, TfToken subIdentifier, TfToken sourceType)
		{
			IntPtr intPtr = SdrPINVOKE.SdrRegistry_GetShaderNodeFromAsset__SWIG_0(swigCPtr, SdfAssetPath.getCPtr(shaderAsset), NdrTokenMap.getCPtr(metadata), TfToken.getCPtr(subIdentifier), TfToken.getCPtr(sourceType));
			SdrShaderNode result = ((intPtr == IntPtr.Zero) ? null : new SdrShaderNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdrShaderNode GetShaderNodeFromAsset(SdfAssetPath shaderAsset, NdrTokenMap metadata, TfToken subIdentifier)
		{
			IntPtr intPtr = SdrPINVOKE.SdrRegistry_GetShaderNodeFromAsset__SWIG_1(swigCPtr, SdfAssetPath.getCPtr(shaderAsset), NdrTokenMap.getCPtr(metadata), TfToken.getCPtr(subIdentifier));
			SdrShaderNode result = ((intPtr == IntPtr.Zero) ? null : new SdrShaderNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdrShaderNode GetShaderNodeFromAsset(SdfAssetPath shaderAsset, NdrTokenMap metadata)
		{
			IntPtr intPtr = SdrPINVOKE.SdrRegistry_GetShaderNodeFromAsset__SWIG_2(swigCPtr, SdfAssetPath.getCPtr(shaderAsset), NdrTokenMap.getCPtr(metadata));
			SdrShaderNode result = ((intPtr == IntPtr.Zero) ? null : new SdrShaderNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdrShaderNode GetShaderNodeFromAsset(SdfAssetPath shaderAsset)
		{
			IntPtr intPtr = SdrPINVOKE.SdrRegistry_GetShaderNodeFromAsset__SWIG_3(swigCPtr, SdfAssetPath.getCPtr(shaderAsset));
			SdrShaderNode result = ((intPtr == IntPtr.Zero) ? null : new SdrShaderNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdrShaderNode GetShaderNodeFromSourceCode(string sourceCode, TfToken sourceType, NdrTokenMap metadata)
		{
			IntPtr intPtr = SdrPINVOKE.SdrRegistry_GetShaderNodeFromSourceCode__SWIG_0(swigCPtr, sourceCode, TfToken.getCPtr(sourceType), NdrTokenMap.getCPtr(metadata));
			SdrShaderNode result = ((intPtr == IntPtr.Zero) ? null : new SdrShaderNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SdrShaderNode GetShaderNodeFromSourceCode(string sourceCode, TfToken sourceType)
		{
			IntPtr intPtr = SdrPINVOKE.SdrRegistry_GetShaderNodeFromSourceCode__SWIG_1(swigCPtr, sourceCode, TfToken.getCPtr(sourceType));
			SdrShaderNode result = ((intPtr == IntPtr.Zero) ? null : new SdrShaderNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t GetShaderNodesByIdentifier(TfToken identifier)
		{
			SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t result = new SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t(SdrPINVOKE.SdrRegistry_GetShaderNodesByIdentifier(swigCPtr, TfToken.getCPtr(identifier)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t GetShaderNodesByName(string name, NdrVersionFilter filter)
		{
			SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t result = new SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t(SdrPINVOKE.SdrRegistry_GetShaderNodesByName__SWIG_0(swigCPtr, name, (int)filter), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t GetShaderNodesByName(string name)
		{
			SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t result = new SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t(SdrPINVOKE.SdrRegistry_GetShaderNodesByName__SWIG_1(swigCPtr, name), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t GetShaderNodesByFamily(TfToken family, NdrVersionFilter filter)
		{
			SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t result = new SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t(SdrPINVOKE.SdrRegistry_GetShaderNodesByFamily__SWIG_0(swigCPtr, TfToken.getCPtr(family), (int)filter), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t GetShaderNodesByFamily(TfToken family)
		{
			SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t result = new SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t(SdrPINVOKE.SdrRegistry_GetShaderNodesByFamily__SWIG_1(swigCPtr, TfToken.getCPtr(family)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t GetShaderNodesByFamily()
		{
			return new SWIGTYPE_p_std__vectorT_SdrShaderNode_const_p_t(SdrPINVOKE.SdrRegistry_GetShaderNodesByFamily__SWIG_2(swigCPtr), futureUse: true);
		}
	}
}
