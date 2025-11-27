namespace pxr
{
	public class UsdShade
	{
		public static void UsdShadeRegisterConnectableAPIBehavior(TfType connectablePrimType, SWIGTYPE_p_std__shared_ptrT_UsdShadeConnectableAPIBehavior_t behavior)
		{
			UsdShadePINVOKE.UsdShadeRegisterConnectableAPIBehavior(TfType.getCPtr(connectablePrimType), SWIGTYPE_p_std__shared_ptrT_UsdShadeConnectableAPIBehavior_t.getCPtr(behavior));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
