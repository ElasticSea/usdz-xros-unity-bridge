using System;

namespace pxr
{
	public class Usd
	{
		public static Usd_PrimFlags UsdPrimIsActive => (Usd_PrimFlags)UsdPINVOKE.UsdPrimIsActive_get();

		public static Usd_PrimFlags UsdPrimIsLoaded => (Usd_PrimFlags)UsdPINVOKE.UsdPrimIsLoaded_get();

		public static Usd_PrimFlags UsdPrimIsModel => (Usd_PrimFlags)UsdPINVOKE.UsdPrimIsModel_get();

		public static Usd_PrimFlags UsdPrimIsGroup => (Usd_PrimFlags)UsdPINVOKE.UsdPrimIsGroup_get();

		public static Usd_PrimFlags UsdPrimIsAbstract => (Usd_PrimFlags)UsdPINVOKE.UsdPrimIsAbstract_get();

		public static Usd_PrimFlags UsdPrimIsDefined => (Usd_PrimFlags)UsdPINVOKE.UsdPrimIsDefined_get();

		public static Usd_PrimFlags UsdPrimIsInstance => (Usd_PrimFlags)UsdPINVOKE.UsdPrimIsInstance_get();

		public static Usd_PrimFlags UsdPrimHasDefiningSpecifier => (Usd_PrimFlags)UsdPINVOKE.UsdPrimHasDefiningSpecifier_get();

		public static Usd_PrimFlagsConjunction UsdPrimDefaultPredicate
		{
			get
			{
				IntPtr intPtr = UsdPINVOKE.UsdPrimDefaultPredicate_get();
				return (intPtr == IntPtr.Zero) ? null : new Usd_PrimFlagsConjunction(intPtr, cMemoryOwn: false);
			}
		}

		public static Usd_PrimFlagsPredicate UsdPrimAllPrimsPredicate
		{
			get
			{
				IntPtr intPtr = UsdPINVOKE.UsdPrimAllPrimsPredicate_get();
				return (intPtr == IntPtr.Zero) ? null : new Usd_PrimFlagsPredicate(intPtr, cMemoryOwn: false);
			}
		}

		public static string UsdDescribe(UsdObject arg0)
		{
			string result = UsdPINVOKE.UsdDescribe__SWIG_0(UsdObject.getCPtr(arg0));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string UsdDescribe(UsdStage arg0)
		{
			string result = UsdPINVOKE.UsdDescribe__SWIG_1(UsdStage.getCPtr(arg0));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string UsdDescribe(UsdStageCache arg0)
		{
			string result = UsdPINVOKE.UsdDescribe__SWIG_3(UsdStageCache.getCPtr(arg0));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool UsdIsSubtype(UsdObjType baseType, UsdObjType subType)
		{
			return UsdPINVOKE.UsdIsSubtype((int)baseType, (int)subType);
		}

		public static bool UsdIsConvertible(UsdObjType from, UsdObjType to)
		{
			return UsdPINVOKE.UsdIsConvertible((int)from, (int)to);
		}

		public static bool UsdIsConcrete(UsdObjType type)
		{
			return UsdPINVOKE.UsdIsConcrete((int)type);
		}

		public static UsdObjType Usd_GetObjType(UsdObject obj)
		{
			UsdObjType result = (UsdObjType)UsdPINVOKE.Usd_GetObjType(UsdObject.getCPtr(obj));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static void GetPrimFromVector(UsdPrimVector prims, int index, UsdPrim output)
		{
			UsdPINVOKE.GetPrimFromVector(UsdPrimVector.getCPtr(prims), index, UsdPrim.getCPtr(output));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static Usd_PrimFlagsPredicate UsdTraverseInstanceProxies(Usd_PrimFlagsPredicate predicate)
		{
			Usd_PrimFlagsPredicate result = new Usd_PrimFlagsPredicate(UsdPINVOKE.UsdTraverseInstanceProxies__SWIG_0(Usd_PrimFlagsPredicate.getCPtr(predicate)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static Usd_PrimFlagsPredicate UsdTraverseInstanceProxies()
		{
			return new Usd_PrimFlagsPredicate(UsdPINVOKE.UsdTraverseInstanceProxies__SWIG_1(), cMemoryOwn: true);
		}
	}
}
