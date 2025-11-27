using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdAttribute : UsdProperty
	{
		private HandleRef swigCPtr;

		public UsdAttribute(IntPtr cPtr, bool cMemoryOwn)
			: base(UsdPINVOKE.UsdAttribute_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdAttribute obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdAttribute obj)
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

		protected override void Dispose(bool disposing)
		{
			lock (this)
			{
				if (swigCPtr.Handle != IntPtr.Zero)
				{
					if (swigCMemOwn)
					{
						swigCMemOwn = false;
						UsdPINVOKE.delete_UsdAttribute(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public UsdAttribute()
			: this(UsdPINVOKE.new_UsdAttribute(), cMemoryOwn: true)
		{
		}

		public SdfVariability GetVariability()
		{
			return (SdfVariability)UsdPINVOKE.UsdAttribute_GetVariability(swigCPtr);
		}

		public bool SetVariability(SdfVariability variability)
		{
			return UsdPINVOKE.UsdAttribute_SetVariability(swigCPtr, (int)variability);
		}

		public SdfValueTypeName GetTypeName()
		{
			return new SdfValueTypeName(UsdPINVOKE.UsdAttribute_GetTypeName(swigCPtr), cMemoryOwn: true);
		}

		public bool SetTypeName(SdfValueTypeName typeName)
		{
			bool result = UsdPINVOKE.UsdAttribute_SetTypeName(swigCPtr, SdfValueTypeName.getCPtr(typeName));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public TfToken GetRoleName()
		{
			return new TfToken(UsdPINVOKE.UsdAttribute_GetRoleName(swigCPtr), cMemoryOwn: true);
		}

		public static bool GetUnionedTimeSamples(UsdAttributeVector attrs, StdDoubleVector times)
		{
			bool result = UsdPINVOKE.UsdAttribute_GetUnionedTimeSamples(UsdAttributeVector.getCPtr(attrs), StdDoubleVector.getCPtr(times));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool GetUnionedTimeSamplesInInterval(UsdAttributeVector attrs, GfInterval interval, StdDoubleVector times)
		{
			bool result = UsdPINVOKE.UsdAttribute_GetUnionedTimeSamplesInInterval(UsdAttributeVector.getCPtr(attrs), GfInterval.getCPtr(interval), StdDoubleVector.getCPtr(times));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public uint GetNumTimeSamples()
		{
			return UsdPINVOKE.UsdAttribute_GetNumTimeSamples(swigCPtr);
		}

		public bool GetBracketingTimeSamples(double desiredTime, out double lower, out double upper, out double hasTimeSamples)
		{
			return UsdPINVOKE.UsdAttribute_GetBracketingTimeSamples(swigCPtr, desiredTime, out lower, out upper, out hasTimeSamples);
		}

		public bool HasValue()
		{
			return UsdPINVOKE.UsdAttribute_HasValue(swigCPtr);
		}

		public bool HasAuthoredValueOpinion()
		{
			return UsdPINVOKE.UsdAttribute_HasAuthoredValueOpinion(swigCPtr);
		}

		public bool HasAuthoredValue()
		{
			return UsdPINVOKE.UsdAttribute_HasAuthoredValue(swigCPtr);
		}

		public bool HasFallbackValue()
		{
			return UsdPINVOKE.UsdAttribute_HasFallbackValue(swigCPtr);
		}

		public bool ValueMightBeTimeVarying()
		{
			return UsdPINVOKE.UsdAttribute_ValueMightBeTimeVarying(swigCPtr);
		}

		public bool Get(VtValue value, UsdTimeCode time)
		{
			bool result = UsdPINVOKE.UsdAttribute_Get__SWIG_2(swigCPtr, VtValue.getCPtr(value), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdResolveInfo GetResolveInfo(UsdTimeCode time)
		{
			UsdResolveInfo result = new UsdResolveInfo(UsdPINVOKE.UsdAttribute_GetResolveInfo__SWIG_0(swigCPtr, UsdTimeCode.getCPtr(time)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public UsdResolveInfo GetResolveInfo()
		{
			return new UsdResolveInfo(UsdPINVOKE.UsdAttribute_GetResolveInfo__SWIG_1(swigCPtr), cMemoryOwn: true);
		}

		public bool Set(VtValue value, UsdTimeCode time)
		{
			bool result = UsdPINVOKE.UsdAttribute_Set__SWIG_2(swigCPtr, VtValue.getCPtr(value), UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Set(VtValue value)
		{
			bool result = UsdPINVOKE.UsdAttribute_Set__SWIG_3(swigCPtr, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Clear()
		{
			return UsdPINVOKE.UsdAttribute_Clear(swigCPtr);
		}

		public bool ClearAtTime(UsdTimeCode time)
		{
			bool result = UsdPINVOKE.UsdAttribute_ClearAtTime(swigCPtr, UsdTimeCode.getCPtr(time));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ClearDefault()
		{
			return UsdPINVOKE.UsdAttribute_ClearDefault(swigCPtr);
		}

		public void Block()
		{
			UsdPINVOKE.UsdAttribute_Block(swigCPtr);
		}

		public bool AddConnection(SdfPath source, UsdListPosition position)
		{
			bool result = UsdPINVOKE.UsdAttribute_AddConnection__SWIG_0(swigCPtr, SdfPath.getCPtr(source), (int)position);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool AddConnection(SdfPath source)
		{
			bool result = UsdPINVOKE.UsdAttribute_AddConnection__SWIG_1(swigCPtr, SdfPath.getCPtr(source));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool RemoveConnection(SdfPath source)
		{
			bool result = UsdPINVOKE.UsdAttribute_RemoveConnection(swigCPtr, SdfPath.getCPtr(source));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool SetConnections(SdfPathVector sources)
		{
			bool result = UsdPINVOKE.UsdAttribute_SetConnections(swigCPtr, SdfPathVector.getCPtr(sources));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool ClearConnections()
		{
			return UsdPINVOKE.UsdAttribute_ClearConnections(swigCPtr);
		}

		public bool GetConnections(SdfPathVector sources)
		{
			return UsdPINVOKE.UsdAttribute_GetConnections(swigCPtr, SdfPathVector.getCPtr(sources));
		}

		public bool HasAuthoredConnections()
		{
			return UsdPINVOKE.UsdAttribute_HasAuthoredConnections(swigCPtr);
		}

		public TfToken GetColorSpace()
		{
			return new TfToken(UsdPINVOKE.UsdAttribute_GetColorSpace(swigCPtr), cMemoryOwn: true);
		}

		public void SetColorSpace(TfToken colorSpace)
		{
			UsdPINVOKE.UsdAttribute_SetColorSpace(swigCPtr, TfToken.getCPtr(colorSpace));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool HasColorSpace()
		{
			return UsdPINVOKE.UsdAttribute_HasColorSpace(swigCPtr);
		}

		public bool ClearColorSpace()
		{
			return UsdPINVOKE.UsdAttribute_ClearColorSpace(swigCPtr);
		}

		public StdDoubleVector GetTimeSamples()
		{
			return new StdDoubleVector(UsdPINVOKE.UsdAttribute_GetTimeSamples(swigCPtr), cMemoryOwn: true);
		}

		public StdDoubleVector GetTimeSamplesInInterval(GfInterval interval)
		{
			StdDoubleVector result = new StdDoubleVector(UsdPINVOKE.UsdAttribute_GetTimeSamplesInInterval(swigCPtr, GfInterval.getCPtr(interval)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue Get()
		{
			return new VtValue(UsdPINVOKE.UsdAttribute_Get__SWIG_3(swigCPtr), cMemoryOwn: true);
		}

		public VtValue Get(UsdTimeCode time)
		{
			VtValue result = new VtValue(UsdPINVOKE.UsdAttribute_Get__SWIG_4(swigCPtr, UsdTimeCode.getCPtr(time)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
