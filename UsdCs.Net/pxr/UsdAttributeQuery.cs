using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdAttributeQuery : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdAttributeQuery(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdAttributeQuery obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdAttributeQuery obj)
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

		~UsdAttributeQuery()
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
						UsdPINVOKE.delete_UsdAttributeQuery(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdAttributeQuery()
			: this(UsdPINVOKE.new_UsdAttributeQuery__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdAttributeQuery(UsdAttributeQuery other)
			: this(UsdPINVOKE.new_UsdAttributeQuery__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdAttributeQuery(UsdAttribute attr)
			: this(UsdPINVOKE.new_UsdAttributeQuery__SWIG_3(UsdAttribute.getCPtr(attr)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdAttributeQuery(UsdPrim prim, TfToken attrName)
			: this(UsdPINVOKE.new_UsdAttributeQuery__SWIG_4(UsdPrim.getCPtr(prim), TfToken.getCPtr(attrName)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdAttributeQuery(UsdAttribute attr, UsdResolveTarget resolveTarget)
			: this(UsdPINVOKE.new_UsdAttributeQuery__SWIG_5(UsdAttribute.getCPtr(attr), UsdResolveTarget.getCPtr(resolveTarget)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static UsdAttributeQueryVector CreateQueries(UsdPrim prim, TfTokenVector attrNames)
		{
			UsdAttributeQueryVector result = new UsdAttributeQueryVector(UsdPINVOKE.UsdAttributeQuery_CreateQueries(UsdPrim.getCPtr(prim), TfTokenVector.getCPtr(attrNames)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdAttribute GetAttribute()
		{
			return new UsdAttribute(UsdPINVOKE.UsdAttributeQuery_GetAttribute(swigCPtr), cMemoryOwn: false);
		}

		public bool IsValid()
		{
			return UsdPINVOKE.UsdAttributeQuery_IsValid(swigCPtr);
		}

		public bool Get(VtValue value, UsdTimeCode time)
		{
			bool result = UsdPINVOKE.UsdAttributeQuery_Get__SWIG_2(swigCPtr, VtValue.getCPtr(value), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Get(VtValue value)
		{
			return UsdPINVOKE.UsdAttributeQuery_Get__SWIG_3(swigCPtr, VtValue.getCPtr(value));
		}

		public bool GetTimeSamples(StdDoubleVector times)
		{
			return UsdPINVOKE.UsdAttributeQuery_GetTimeSamples(swigCPtr, StdDoubleVector.getCPtr(times));
		}

		public static bool GetUnionedTimeSamples(UsdAttributeQueryVector attrQueries, StdDoubleVector times)
		{
			bool result = UsdPINVOKE.UsdAttributeQuery_GetUnionedTimeSamples(UsdAttributeQueryVector.getCPtr(attrQueries), StdDoubleVector.getCPtr(times));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GetUnionedTimeSamplesInInterval(UsdAttributeQueryVector attrQueries, GfInterval interval, StdDoubleVector times)
		{
			bool result = UsdPINVOKE.UsdAttributeQuery_GetUnionedTimeSamplesInInterval(UsdAttributeQueryVector.getCPtr(attrQueries), GfInterval.getCPtr(interval), StdDoubleVector.getCPtr(times));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public uint GetNumTimeSamples()
		{
			return UsdPINVOKE.UsdAttributeQuery_GetNumTimeSamples(swigCPtr);
		}

		public bool GetBracketingTimeSamples(double desiredTime, out double lower, out double upper, out double hasTimeSamples)
		{
			return UsdPINVOKE.UsdAttributeQuery_GetBracketingTimeSamples(swigCPtr, desiredTime, out lower, out upper, out hasTimeSamples);
		}

		public bool HasValue()
		{
			return UsdPINVOKE.UsdAttributeQuery_HasValue(swigCPtr);
		}

		public bool HasAuthoredValueOpinion()
		{
			return UsdPINVOKE.UsdAttributeQuery_HasAuthoredValueOpinion(swigCPtr);
		}

		public bool HasAuthoredValue()
		{
			return UsdPINVOKE.UsdAttributeQuery_HasAuthoredValue(swigCPtr);
		}

		public bool HasFallbackValue()
		{
			return UsdPINVOKE.UsdAttributeQuery_HasFallbackValue(swigCPtr);
		}

		public bool ValueMightBeTimeVarying()
		{
			return UsdPINVOKE.UsdAttributeQuery_ValueMightBeTimeVarying(swigCPtr);
		}
	}
}
