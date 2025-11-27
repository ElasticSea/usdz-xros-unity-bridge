namespace pxr
{
	public class Ndr
	{
		public static string NdrGetIdentifierString(TfToken id)
		{
			string result = NdrPINVOKE.NdrGetIdentifierString(TfToken.getCPtr(id));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool NdrFsHelpersSplitShaderIdentifier(TfToken identifier, TfToken family, TfToken name, NdrVersion version)
		{
			bool result = NdrPINVOKE.NdrFsHelpersSplitShaderIdentifier(TfToken.getCPtr(identifier), TfToken.getCPtr(family), TfToken.getCPtr(name), NdrVersion.getCPtr(version));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static NdrNodeDiscoveryResultVector NdrFsHelpersDiscoverNodes(StdStringVector searchPaths, StdStringVector allowedExtensions, bool followSymlinks, NdrDiscoveryPluginContext context, SWIGTYPE_p_std__functionT_bool_fTfToken_const_R_TfToken_p_TfToken_p_NdrVersion_pF_t parseIdentifierFn)
		{
			NdrNodeDiscoveryResultVector result = new NdrNodeDiscoveryResultVector(NdrPINVOKE.NdrFsHelpersDiscoverNodes__SWIG_0(StdStringVector.getCPtr(searchPaths), StdStringVector.getCPtr(allowedExtensions), followSymlinks, NdrDiscoveryPluginContext.getCPtr(context), SWIGTYPE_p_std__functionT_bool_fTfToken_const_R_TfToken_p_TfToken_p_NdrVersion_pF_t.getCPtr(parseIdentifierFn)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static NdrNodeDiscoveryResultVector NdrFsHelpersDiscoverNodes(StdStringVector searchPaths, StdStringVector allowedExtensions, bool followSymlinks, NdrDiscoveryPluginContext context)
		{
			NdrNodeDiscoveryResultVector result = new NdrNodeDiscoveryResultVector(NdrPINVOKE.NdrFsHelpersDiscoverNodes__SWIG_1(StdStringVector.getCPtr(searchPaths), StdStringVector.getCPtr(allowedExtensions), followSymlinks, NdrDiscoveryPluginContext.getCPtr(context)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static NdrNodeDiscoveryResultVector NdrFsHelpersDiscoverNodes(StdStringVector searchPaths, StdStringVector allowedExtensions, bool followSymlinks)
		{
			NdrNodeDiscoveryResultVector result = new NdrNodeDiscoveryResultVector(NdrPINVOKE.NdrFsHelpersDiscoverNodes__SWIG_2(StdStringVector.getCPtr(searchPaths), StdStringVector.getCPtr(allowedExtensions), followSymlinks), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static NdrNodeDiscoveryResultVector NdrFsHelpersDiscoverNodes(StdStringVector searchPaths, StdStringVector allowedExtensions)
		{
			NdrNodeDiscoveryResultVector result = new NdrNodeDiscoveryResultVector(NdrPINVOKE.NdrFsHelpersDiscoverNodes__SWIG_3(StdStringVector.getCPtr(searchPaths), StdStringVector.getCPtr(allowedExtensions)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SWIGTYPE_p_std__vectorT_NdrDiscoveryUri_t NdrFsHelpersDiscoverFiles(StdStringVector searchPaths, StdStringVector allowedExtensions, bool followSymlinks)
		{
			SWIGTYPE_p_std__vectorT_NdrDiscoveryUri_t result = new SWIGTYPE_p_std__vectorT_NdrDiscoveryUri_t(NdrPINVOKE.NdrFsHelpersDiscoverFiles__SWIG_0(StdStringVector.getCPtr(searchPaths), StdStringVector.getCPtr(allowedExtensions), followSymlinks), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SWIGTYPE_p_std__vectorT_NdrDiscoveryUri_t NdrFsHelpersDiscoverFiles(StdStringVector searchPaths, StdStringVector allowedExtensions)
		{
			SWIGTYPE_p_std__vectorT_NdrDiscoveryUri_t result = new SWIGTYPE_p_std__vectorT_NdrDiscoveryUri_t(NdrPINVOKE.NdrFsHelpersDiscoverFiles__SWIG_1(StdStringVector.getCPtr(searchPaths), StdStringVector.getCPtr(allowedExtensions)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
