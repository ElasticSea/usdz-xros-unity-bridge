namespace pxr
{
	public class UsdCs
	{
		public static void SetEnv(string name, string value)
		{
			UsdCsPINVOKE.SetEnv(name, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static VtValue GetFusedTransform(UsdPrim prim, UsdTimeCode time)
		{
			VtValue result = new VtValue(UsdCsPINVOKE.GetFusedTransform(UsdPrim.getCPtr(prim), UsdTimeCode.getCPtr(time)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool WriteUsdZip(string usdzFilePath, StdStringVector filesToArchive)
		{
			bool result = UsdCsPINVOKE.WriteUsdZip(usdzFilePath, StdStringVector.getCPtr(filesToArchive));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static VtValue GetFusedDisplayColor(UsdPrim prim, UsdTimeCode time)
		{
			VtValue result = new VtValue(UsdCsPINVOKE.GetFusedDisplayColor(UsdPrim.getCPtr(prim), UsdTimeCode.getCPtr(time)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool SetFusedDisplayColor(UsdPrim prim, VtVec4fArray values, UsdTimeCode time)
		{
			bool result = UsdCsPINVOKE.SetFusedDisplayColor(UsdPrim.getCPtr(prim), VtVec4fArray.getCPtr(values), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
