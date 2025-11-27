using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdStageLoadRules : IDisposable
	{
		public enum Rule
		{
			AllRule,
			OnlyRule,
			NoneRule
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdStageLoadRules(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdStageLoadRules obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdStageLoadRules obj)
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

		~UsdStageLoadRules()
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
						UsdPINVOKE.delete_UsdStageLoadRules(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdStageLoadRules()
			: this(UsdPINVOKE.new_UsdStageLoadRules__SWIG_0(), cMemoryOwn: true)
		{
		}

		public static UsdStageLoadRules LoadAll()
		{
			return new UsdStageLoadRules(UsdPINVOKE.UsdStageLoadRules_LoadAll(), cMemoryOwn: true);
		}

		public static UsdStageLoadRules LoadNone()
		{
			return new UsdStageLoadRules(UsdPINVOKE.UsdStageLoadRules_LoadNone(), cMemoryOwn: true);
		}

		public UsdStageLoadRules(UsdStageLoadRules arg0)
			: this(UsdPINVOKE.new_UsdStageLoadRules__SWIG_1(getCPtr(arg0)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void LoadWithDescendants(SdfPath path)
		{
			UsdPINVOKE.UsdStageLoadRules_LoadWithDescendants(swigCPtr, SdfPath.getCPtr(path));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void LoadWithoutDescendants(SdfPath path)
		{
			UsdPINVOKE.UsdStageLoadRules_LoadWithoutDescendants(swigCPtr, SdfPath.getCPtr(path));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void Unload(SdfPath path)
		{
			UsdPINVOKE.UsdStageLoadRules_Unload(swigCPtr, SdfPath.getCPtr(path));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void LoadAndUnload(SdfPathSet loadSet, SdfPathSet unloadSet, UsdLoadPolicy policy)
		{
			UsdPINVOKE.UsdStageLoadRules_LoadAndUnload(swigCPtr, SdfPathSet.getCPtr(loadSet), SdfPathSet.getCPtr(unloadSet), (int)policy);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRule(SdfPath path, Rule rule)
		{
			UsdPINVOKE.UsdStageLoadRules_AddRule(swigCPtr, SdfPath.getCPtr(path), (int)rule);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRules(UsdStageLoadRulesVectorPair rules)
		{
			UsdPINVOKE.UsdStageLoadRules_SetRules__SWIG_0(swigCPtr, UsdStageLoadRulesVectorPair.getCPtr(rules));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void Minimize()
		{
			UsdPINVOKE.UsdStageLoadRules_Minimize(swigCPtr);
		}

		public bool IsLoaded(SdfPath path)
		{
			bool result = UsdPINVOKE.UsdStageLoadRules_IsLoaded(swigCPtr, SdfPath.getCPtr(path));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsLoadedWithAllDescendants(SdfPath path)
		{
			bool result = UsdPINVOKE.UsdStageLoadRules_IsLoadedWithAllDescendants(swigCPtr, SdfPath.getCPtr(path));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsLoadedWithNoDescendants(SdfPath path)
		{
			bool result = UsdPINVOKE.UsdStageLoadRules_IsLoadedWithNoDescendants(swigCPtr, SdfPath.getCPtr(path));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public Rule GetEffectiveRuleForPath(SdfPath path)
		{
			Rule result = (Rule)UsdPINVOKE.UsdStageLoadRules_GetEffectiveRuleForPath(swigCPtr, SdfPath.getCPtr(path));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdStageLoadRulesVectorPair GetRules()
		{
			return new UsdStageLoadRulesVectorPair(UsdPINVOKE.UsdStageLoadRules_GetRules(swigCPtr), cMemoryOwn: false);
		}

		public void swap(UsdStageLoadRules other)
		{
			UsdPINVOKE.UsdStageLoadRules_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
