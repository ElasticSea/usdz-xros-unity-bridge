namespace pxr
{
	public class UsdRi
	{
		public static int UsdRiConvertToRManInterpolateBoundary(TfToken token)
		{
			int result = UsdRiPINVOKE.UsdRiConvertToRManInterpolateBoundary(TfToken.getCPtr(token));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfToken UsdRiConvertFromRManInterpolateBoundary(int i)
		{
			return new TfToken(UsdRiPINVOKE.UsdRiConvertFromRManInterpolateBoundary(i), cMemoryOwn: false);
		}

		public static int UsdRiConvertToRManFaceVaryingLinearInterpolation(TfToken token)
		{
			int result = UsdRiPINVOKE.UsdRiConvertToRManFaceVaryingLinearInterpolation(TfToken.getCPtr(token));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfToken UsdRiConvertFromRManFaceVaryingLinearInterpolation(int i)
		{
			return new TfToken(UsdRiPINVOKE.UsdRiConvertFromRManFaceVaryingLinearInterpolation(i), cMemoryOwn: false);
		}

		public static int UsdRiConvertToRManTriangleSubdivisionRule(TfToken token)
		{
			int result = UsdRiPINVOKE.UsdRiConvertToRManTriangleSubdivisionRule(TfToken.getCPtr(token));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfToken UsdRiConvertFromRManTriangleSubdivisionRule(int i)
		{
			return new TfToken(UsdRiPINVOKE.UsdRiConvertFromRManTriangleSubdivisionRule(i), cMemoryOwn: false);
		}
	}
}
