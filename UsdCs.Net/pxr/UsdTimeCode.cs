using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdTimeCode : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public UsdTimeCode(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdTimeCode obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdTimeCode obj)
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

		~UsdTimeCode()
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
						UsdPINVOKE.delete_UsdTimeCode(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdTimeCode(double t)
			: this(UsdPINVOKE.new_UsdTimeCode__SWIG_0(t), cMemoryOwn: true)
		{
		}

		public UsdTimeCode()
			: this(UsdPINVOKE.new_UsdTimeCode__SWIG_1(), cMemoryOwn: true)
		{
		}

		public UsdTimeCode(SdfTimeCode timeCode)
			: this(UsdPINVOKE.new_UsdTimeCode__SWIG_2(SdfTimeCode.getCPtr(timeCode)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static UsdTimeCode EarliestTime()
		{
			return new UsdTimeCode(UsdPINVOKE.UsdTimeCode_EarliestTime(), cMemoryOwn: true);
		}

		public static UsdTimeCode Default()
		{
			return new UsdTimeCode(UsdPINVOKE.UsdTimeCode_Default(), cMemoryOwn: true);
		}

		public static double SafeStep(double maxValue, double maxCompression)
		{
			return UsdPINVOKE.UsdTimeCode_SafeStep__SWIG_0(maxValue, maxCompression);
		}

		public static double SafeStep(double maxValue)
		{
			return UsdPINVOKE.UsdTimeCode_SafeStep__SWIG_1(maxValue);
		}

		public static double SafeStep()
		{
			return UsdPINVOKE.UsdTimeCode_SafeStep__SWIG_2();
		}

		public bool IsEarliestTime()
		{
			return UsdPINVOKE.UsdTimeCode_IsEarliestTime(swigCPtr);
		}

		public bool IsDefault()
		{
			return UsdPINVOKE.UsdTimeCode_IsDefault(swigCPtr);
		}

		public bool IsNumeric()
		{
			return UsdPINVOKE.UsdTimeCode_IsNumeric(swigCPtr);
		}

		public double GetValue()
		{
			return UsdPINVOKE.UsdTimeCode_GetValue(swigCPtr);
		}

		public static bool Equals(UsdTimeCode lhs, UsdTimeCode rhs)
		{
			bool result = UsdPINVOKE.UsdTimeCode_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(UsdTimeCode lhs, UsdTimeCode rhs)
		{
			bool flag = (object)lhs == null;
			bool flag2 = (object)rhs == null;
			if (flag == flag2)
			{
				if (!(flag && flag2))
				{
					return Equals(lhs, rhs);
				}
				return true;
			}
			return false;
		}

		public static bool operator !=(UsdTimeCode lhs, UsdTimeCode rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as UsdTimeCode);
		}

		public override int GetHashCode()
		{
			return UsdPINVOKE.UsdTimeCode_GetHashCode(swigCPtr);
		}

		public static implicit operator UsdTimeCode(double value)
		{
			return new UsdTimeCode(value);
		}
	}
}
