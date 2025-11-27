namespace pxr
{
	public class UsdGeom
	{
		public const int USDGEOM_CYLINDER_API_VERSION = 1;

		public const int USDGEOM_XFORM_CACHE_API_VERSION = 1;

		public static TfToken UsdGeomGetStageUpAxis(UsdStage stage)
		{
			TfToken result = new TfToken(UsdGeomPINVOKE.UsdGeomGetStageUpAxis(UsdStage.getCPtr(stage)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdGeomSetStageUpAxis(UsdStage stage, TfToken axis)
		{
			bool result = UsdGeomPINVOKE.UsdGeomSetStageUpAxis(UsdStage.getCPtr(stage), TfToken.getCPtr(axis));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static TfToken UsdGeomGetFallbackUpAxis()
		{
			return new TfToken(UsdGeomPINVOKE.UsdGeomGetFallbackUpAxis(), cMemoryOwn: true);
		}

		public static double UsdGeomGetStageMetersPerUnit(UsdStage stage)
		{
			double result = UsdGeomPINVOKE.UsdGeomGetStageMetersPerUnit(UsdStage.getCPtr(stage));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdGeomStageHasAuthoredMetersPerUnit(UsdStage stage)
		{
			bool result = UsdGeomPINVOKE.UsdGeomStageHasAuthoredMetersPerUnit(UsdStage.getCPtr(stage));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdGeomSetStageMetersPerUnit(UsdStage stage, double metersPerUnit)
		{
			bool result = UsdGeomPINVOKE.UsdGeomSetStageMetersPerUnit(UsdStage.getCPtr(stage), metersPerUnit);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdGeomLinearUnitsAre(double authoredUnits, double standardUnits, double epsilon)
		{
			return UsdGeomPINVOKE.UsdGeomLinearUnitsAre__SWIG_0(authoredUnits, standardUnits, epsilon);
		}

		public static bool UsdGeomLinearUnitsAre(double authoredUnits, double standardUnits)
		{
			return UsdGeomPINVOKE.UsdGeomLinearUnitsAre__SWIG_1(authoredUnits, standardUnits);
		}

		public static bool UsdGeomPointInstancerApplyNewStyleListOps()
		{
			return UsdGeomPINVOKE.UsdGeomPointInstancerApplyNewStyleListOps();
		}

		public static bool UsdGeomPointInstancerSetOrMergeOverOp(StdInt64Vector items, SdfListOpType op, UsdPrim prim, TfToken metadataName)
		{
			bool result = UsdGeomPINVOKE.UsdGeomPointInstancerSetOrMergeOverOp(StdInt64Vector.getCPtr(items), (int)op, UsdPrim.getCPtr(prim), TfToken.getCPtr(metadataName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
