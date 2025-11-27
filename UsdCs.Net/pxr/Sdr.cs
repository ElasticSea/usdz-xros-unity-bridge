namespace pxr
{
	public class Sdr
	{
		public static bool IsTruthy(TfToken key, NdrTokenMap metadata)
		{
			bool result = SdrPINVOKE.IsTruthy(TfToken.getCPtr(key), NdrTokenMap.getCPtr(metadata));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string StringVal(TfToken key, NdrTokenMap metadata, string defaultValue)
		{
			string result = SdrPINVOKE.StringVal__SWIG_0(TfToken.getCPtr(key), NdrTokenMap.getCPtr(metadata), defaultValue);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string StringVal(TfToken key, NdrTokenMap metadata)
		{
			string result = SdrPINVOKE.StringVal__SWIG_1(TfToken.getCPtr(key), NdrTokenMap.getCPtr(metadata));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfToken TokenVal(TfToken key, NdrTokenMap metadata, TfToken defaultValue)
		{
			TfToken result = new TfToken(SdrPINVOKE.TokenVal__SWIG_0(TfToken.getCPtr(key), NdrTokenMap.getCPtr(metadata), TfToken.getCPtr(defaultValue)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfToken TokenVal(TfToken key, NdrTokenMap metadata)
		{
			TfToken result = new TfToken(SdrPINVOKE.TokenVal__SWIG_1(TfToken.getCPtr(key), NdrTokenMap.getCPtr(metadata)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static int IntVal(TfToken key, NdrTokenMap metadata, int defaultValue)
		{
			int result = SdrPINVOKE.IntVal__SWIG_0(TfToken.getCPtr(key), NdrTokenMap.getCPtr(metadata), defaultValue);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static int IntVal(TfToken key, NdrTokenMap metadata)
		{
			int result = SdrPINVOKE.IntVal__SWIG_1(TfToken.getCPtr(key), NdrTokenMap.getCPtr(metadata));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static StdStringVector StringVecVal(TfToken key, NdrTokenMap metadata)
		{
			StdStringVector result = new StdStringVector(SdrPINVOKE.StringVecVal(TfToken.getCPtr(key), NdrTokenMap.getCPtr(metadata)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfTokenVector TokenVecVal(TfToken key, NdrTokenMap metadata)
		{
			TfTokenVector result = new TfTokenVector(SdrPINVOKE.TokenVecVal(TfToken.getCPtr(key), NdrTokenMap.getCPtr(metadata)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static SWIGTYPE_p_std__vectorT_std__pairT_TfToken_TfToken_t_t OptionVecVal(string optionStr)
		{
			SWIGTYPE_p_std__vectorT_std__pairT_TfToken_TfToken_t_t result = new SWIGTYPE_p_std__vectorT_std__pairT_TfToken_TfToken_t_t(SdrPINVOKE.OptionVecVal(optionStr), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string CreateStringFromStringVec(StdStringVector stringVec)
		{
			string result = SdrPINVOKE.CreateStringFromStringVec(StdStringVector.getCPtr(stringVec));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IsPropertyAnAssetIdentifier(NdrTokenMap metadata)
		{
			bool result = SdrPINVOKE.IsPropertyAnAssetIdentifier(NdrTokenMap.getCPtr(metadata));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool IsPropertyATerminal(NdrTokenMap metadata)
		{
			bool result = SdrPINVOKE.IsPropertyATerminal(NdrTokenMap.getCPtr(metadata));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfToken GetRoleFromMetadata(NdrTokenMap metadata)
		{
			TfToken result = new TfToken(SdrPINVOKE.GetRoleFromMetadata(NdrTokenMap.getCPtr(metadata)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
