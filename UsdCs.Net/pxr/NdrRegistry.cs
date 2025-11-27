using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class NdrRegistry : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public NdrRegistry(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(NdrRegistry obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(NdrRegistry obj)
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

		~NdrRegistry()
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
						throw new MethodAccessException("C++ destructor does not have public access");
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public void SetExtraDiscoveryPlugins(SWIGTYPE_p_NdrDiscoveryPluginRefPtrVector plugins)
		{
			NdrPINVOKE.NdrRegistry_SetExtraDiscoveryPlugins__SWIG_0(swigCPtr, SWIGTYPE_p_NdrDiscoveryPluginRefPtrVector.getCPtr(plugins));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetExtraDiscoveryPlugins(TfTypeVector pluginTypes)
		{
			NdrPINVOKE.NdrRegistry_SetExtraDiscoveryPlugins__SWIG_1(swigCPtr, TfTypeVector.getCPtr(pluginTypes));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddDiscoveryResult(NdrNodeDiscoveryResult discoveryResult)
		{
			NdrPINVOKE.NdrRegistry_AddDiscoveryResult__SWIG_0(swigCPtr, NdrNodeDiscoveryResult.swigRelease(discoveryResult));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetExtraParserPlugins(TfTypeVector pluginTypes)
		{
			NdrPINVOKE.NdrRegistry_SetExtraParserPlugins(swigCPtr, TfTypeVector.getCPtr(pluginTypes));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public NdrNode GetNodeFromAsset(SdfAssetPath asset, NdrTokenMap metadata, TfToken subIdentifier, TfToken sourceType)
		{
			IntPtr intPtr = NdrPINVOKE.NdrRegistry_GetNodeFromAsset__SWIG_0(swigCPtr, SdfAssetPath.getCPtr(asset), NdrTokenMap.getCPtr(metadata), TfToken.getCPtr(subIdentifier), TfToken.getCPtr(sourceType));
			NdrNode result = ((intPtr == IntPtr.Zero) ? null : new NdrNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public NdrNode GetNodeFromAsset(SdfAssetPath asset, NdrTokenMap metadata, TfToken subIdentifier)
		{
			IntPtr intPtr = NdrPINVOKE.NdrRegistry_GetNodeFromAsset__SWIG_1(swigCPtr, SdfAssetPath.getCPtr(asset), NdrTokenMap.getCPtr(metadata), TfToken.getCPtr(subIdentifier));
			NdrNode result = ((intPtr == IntPtr.Zero) ? null : new NdrNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public NdrNode GetNodeFromAsset(SdfAssetPath asset, NdrTokenMap metadata)
		{
			IntPtr intPtr = NdrPINVOKE.NdrRegistry_GetNodeFromAsset__SWIG_2(swigCPtr, SdfAssetPath.getCPtr(asset), NdrTokenMap.getCPtr(metadata));
			NdrNode result = ((intPtr == IntPtr.Zero) ? null : new NdrNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public NdrNode GetNodeFromSourceCode(string sourceCode, TfToken sourceType, NdrTokenMap metadata)
		{
			IntPtr intPtr = NdrPINVOKE.NdrRegistry_GetNodeFromSourceCode(swigCPtr, sourceCode, TfToken.getCPtr(sourceType), NdrTokenMap.getCPtr(metadata));
			NdrNode result = ((intPtr == IntPtr.Zero) ? null : new NdrNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public StdStringVector GetSearchURIs()
		{
			return new StdStringVector(NdrPINVOKE.NdrRegistry_GetSearchURIs(swigCPtr), cMemoryOwn: true);
		}

		public TfTokenVector GetNodeIdentifiers(TfToken family, NdrVersionFilter filter)
		{
			TfTokenVector result = new TfTokenVector(NdrPINVOKE.NdrRegistry_GetNodeIdentifiers__SWIG_0(swigCPtr, TfToken.getCPtr(family), (int)filter), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfTokenVector GetNodeIdentifiers(TfToken family)
		{
			TfTokenVector result = new TfTokenVector(NdrPINVOKE.NdrRegistry_GetNodeIdentifiers__SWIG_1(swigCPtr, TfToken.getCPtr(family)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfTokenVector GetNodeIdentifiers()
		{
			return new TfTokenVector(NdrPINVOKE.NdrRegistry_GetNodeIdentifiers__SWIG_2(swigCPtr), cMemoryOwn: true);
		}

		public StdStringVector GetNodeNames(TfToken family)
		{
			StdStringVector result = new StdStringVector(NdrPINVOKE.NdrRegistry_GetNodeNames__SWIG_0(swigCPtr, TfToken.getCPtr(family)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public StdStringVector GetNodeNames()
		{
			return new StdStringVector(NdrPINVOKE.NdrRegistry_GetNodeNames__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public NdrNode GetNodeByIdentifier(TfToken identifier, TfTokenVector sourceTypePriority)
		{
			IntPtr intPtr = NdrPINVOKE.NdrRegistry_GetNodeByIdentifier__SWIG_0(swigCPtr, TfToken.getCPtr(identifier), TfTokenVector.getCPtr(sourceTypePriority));
			NdrNode result = ((intPtr == IntPtr.Zero) ? null : new NdrNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public NdrNode GetNodeByIdentifier(TfToken identifier)
		{
			IntPtr intPtr = NdrPINVOKE.NdrRegistry_GetNodeByIdentifier__SWIG_1(swigCPtr, TfToken.getCPtr(identifier));
			NdrNode result = ((intPtr == IntPtr.Zero) ? null : new NdrNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public NdrNode GetNodeByIdentifierAndType(TfToken identifier, TfToken sourceType)
		{
			IntPtr intPtr = NdrPINVOKE.NdrRegistry_GetNodeByIdentifierAndType(swigCPtr, TfToken.getCPtr(identifier), TfToken.getCPtr(sourceType));
			NdrNode result = ((intPtr == IntPtr.Zero) ? null : new NdrNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public NdrNode GetNodeByName(string name, TfTokenVector sourceTypePriority, NdrVersionFilter filter)
		{
			IntPtr intPtr = NdrPINVOKE.NdrRegistry_GetNodeByName__SWIG_0(swigCPtr, name, TfTokenVector.getCPtr(sourceTypePriority), (int)filter);
			NdrNode result = ((intPtr == IntPtr.Zero) ? null : new NdrNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public NdrNode GetNodeByName(string name, TfTokenVector sourceTypePriority)
		{
			IntPtr intPtr = NdrPINVOKE.NdrRegistry_GetNodeByName__SWIG_1(swigCPtr, name, TfTokenVector.getCPtr(sourceTypePriority));
			NdrNode result = ((intPtr == IntPtr.Zero) ? null : new NdrNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public NdrNode GetNodeByName(string name)
		{
			IntPtr intPtr = NdrPINVOKE.NdrRegistry_GetNodeByName__SWIG_2(swigCPtr, name);
			NdrNode result = ((intPtr == IntPtr.Zero) ? null : new NdrNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public NdrNode GetNodeByNameAndType(string name, TfToken sourceType, NdrVersionFilter filter)
		{
			IntPtr intPtr = NdrPINVOKE.NdrRegistry_GetNodeByNameAndType__SWIG_0(swigCPtr, name, TfToken.getCPtr(sourceType), (int)filter);
			NdrNode result = ((intPtr == IntPtr.Zero) ? null : new NdrNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public NdrNode GetNodeByNameAndType(string name, TfToken sourceType)
		{
			IntPtr intPtr = NdrPINVOKE.NdrRegistry_GetNodeByNameAndType__SWIG_1(swigCPtr, name, TfToken.getCPtr(sourceType));
			NdrNode result = ((intPtr == IntPtr.Zero) ? null : new NdrNode(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_std__vectorT_NdrNode_const_p_t GetNodesByIdentifier(TfToken identifier)
		{
			SWIGTYPE_p_std__vectorT_NdrNode_const_p_t result = new SWIGTYPE_p_std__vectorT_NdrNode_const_p_t(NdrPINVOKE.NdrRegistry_GetNodesByIdentifier(swigCPtr, TfToken.getCPtr(identifier)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_std__vectorT_NdrNode_const_p_t GetNodesByName(string name, NdrVersionFilter filter)
		{
			SWIGTYPE_p_std__vectorT_NdrNode_const_p_t result = new SWIGTYPE_p_std__vectorT_NdrNode_const_p_t(NdrPINVOKE.NdrRegistry_GetNodesByName__SWIG_0(swigCPtr, name, (int)filter), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_std__vectorT_NdrNode_const_p_t GetNodesByName(string name)
		{
			SWIGTYPE_p_std__vectorT_NdrNode_const_p_t result = new SWIGTYPE_p_std__vectorT_NdrNode_const_p_t(NdrPINVOKE.NdrRegistry_GetNodesByName__SWIG_1(swigCPtr, name), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_std__vectorT_NdrNode_const_p_t GetNodesByFamily(TfToken family, NdrVersionFilter filter)
		{
			SWIGTYPE_p_std__vectorT_NdrNode_const_p_t result = new SWIGTYPE_p_std__vectorT_NdrNode_const_p_t(NdrPINVOKE.NdrRegistry_GetNodesByFamily__SWIG_0(swigCPtr, TfToken.getCPtr(family), (int)filter), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_std__vectorT_NdrNode_const_p_t GetNodesByFamily(TfToken family)
		{
			SWIGTYPE_p_std__vectorT_NdrNode_const_p_t result = new SWIGTYPE_p_std__vectorT_NdrNode_const_p_t(NdrPINVOKE.NdrRegistry_GetNodesByFamily__SWIG_1(swigCPtr, TfToken.getCPtr(family)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_std__vectorT_NdrNode_const_p_t GetNodesByFamily()
		{
			return new SWIGTYPE_p_std__vectorT_NdrNode_const_p_t(NdrPINVOKE.NdrRegistry_GetNodesByFamily__SWIG_2(swigCPtr), futureUse: true);
		}

		public TfTokenVector GetAllNodeSourceTypes()
		{
			return new TfTokenVector(NdrPINVOKE.NdrRegistry_GetAllNodeSourceTypes(swigCPtr), cMemoryOwn: true);
		}
	}
}
