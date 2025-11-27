using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtValue : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public VtValue(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtValue obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtValue obj)
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

		~VtValue()
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
						VtPINVOKE.delete_VtValue(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public VtValue()
			: this(VtPINVOKE.new_VtValue__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtValue(VtValue other)
			: this(VtPINVOKE.new_VtValue__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtValue Swap(VtValue rhs)
		{
			VtValue result = new VtValue(VtPINVOKE.VtValue_Swap(swigCPtr, getCPtr(rhs)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void UncheckedSwap(VtValue rhs)
		{
			VtPINVOKE.VtValue_UncheckedSwap(swigCPtr, getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsArrayValued()
		{
			return VtPINVOKE.VtValue_IsArrayValued(swigCPtr);
		}

		public uint GetArraySize()
		{
			return VtPINVOKE.VtValue_GetArraySize(swigCPtr);
		}

		public TfType GetTfType()
		{
			return new TfType(VtPINVOKE.VtValue_GetTfType(swigCPtr), cMemoryOwn: true);
		}

		public string GetTypeName()
		{
			return VtPINVOKE.VtValue_GetTypeName(swigCPtr);
		}

		public int GetKnownValueTypeIndex()
		{
			return VtPINVOKE.VtValue_GetKnownValueTypeIndex(swigCPtr);
		}

		public static VtValue CastToTypeOf(VtValue val, VtValue other)
		{
			VtValue result = new VtValue(VtPINVOKE.VtValue_CastToTypeOf__SWIG_0(getCPtr(val), getCPtr(other)), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool CanCastToTypeOf(VtValue other)
		{
			bool result = VtPINVOKE.VtValue_CanCastToTypeOf(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool IsEmpty()
		{
			return VtPINVOKE.VtValue_IsEmpty(swigCPtr);
		}

		public bool CanHash()
		{
			return VtPINVOKE.VtValue_CanHash(swigCPtr);
		}

		public uint GetHash()
		{
			return VtPINVOKE.VtValue_GetHash(swigCPtr);
		}

		public static bool Equals(VtValue lhs, VtValue rhs)
		{
			bool result = VtPINVOKE.VtValue_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtValue lhs, VtValue rhs)
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

		public static bool operator !=(VtValue lhs, VtValue rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtValue);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtValue_GetHashCode(swigCPtr);
		}

		public static implicit operator double(VtValue value)
		{
			return Vt.VtValueTodouble(value);
		}

		public static implicit operator VtValue(double value)
		{
			return new VtValue(value);
		}

		public VtValue(double obj)
			: this(VtPINVOKE.new_VtValue__SWIG_4(obj), cMemoryOwn: true)
		{
		}

		public static implicit operator VtDoubleArray(VtValue value)
		{
			return Vt.VtValueToVtDoubleArray(value);
		}

		public static implicit operator VtValue(VtDoubleArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtDoubleArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_5(VtDoubleArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator float(VtValue value)
		{
			return Vt.VtValueTofloat(value);
		}

		public static implicit operator VtValue(float value)
		{
			return new VtValue(value);
		}

		public VtValue(float obj)
			: this(VtPINVOKE.new_VtValue__SWIG_6(obj), cMemoryOwn: true)
		{
		}

		public static implicit operator VtFloatArray(VtValue value)
		{
			return Vt.VtValueToVtFloatArray(value);
		}

		public static implicit operator VtValue(VtFloatArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtFloatArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_7(VtFloatArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfHalf(VtValue value)
		{
			return Vt.VtValueToGfHalf(value);
		}

		public static implicit operator VtValue(GfHalf value)
		{
			return new VtValue(value);
		}

		public VtValue(GfHalf obj)
			: this(VtPINVOKE.new_VtValue__SWIG_8(GfHalf.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtHalfArray(VtValue value)
		{
			return Vt.VtValueToVtHalfArray(value);
		}

		public static implicit operator VtValue(VtHalfArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtHalfArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_9(VtHalfArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator bool(VtValue value)
		{
			return Vt.VtValueTobool(value);
		}

		public static implicit operator VtValue(bool value)
		{
			return new VtValue(value);
		}

		public VtValue(bool obj)
			: this(VtPINVOKE.new_VtValue__SWIG_10(obj), cMemoryOwn: true)
		{
		}

		public static implicit operator VtBoolArray(VtValue value)
		{
			return Vt.VtValueToVtBoolArray(value);
		}

		public static implicit operator VtValue(VtBoolArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtBoolArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_11(VtBoolArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator char(VtValue value)
		{
			return Vt.VtValueTochar(value);
		}

		public static implicit operator VtValue(char value)
		{
			return new VtValue(value);
		}

		public VtValue(char obj)
			: this(VtPINVOKE.new_VtValue__SWIG_12(obj), cMemoryOwn: true)
		{
		}

		public static implicit operator VtCharArray(VtValue value)
		{
			return Vt.VtValueToVtCharArray(value);
		}

		public static implicit operator VtValue(VtCharArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtCharArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_13(VtCharArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator byte(VtValue value)
		{
			return Vt.VtValueTobyte(value);
		}

		public static implicit operator VtValue(byte value)
		{
			return new VtValue(value);
		}

		public VtValue(byte obj)
			: this(VtPINVOKE.new_VtValue__SWIG_14(obj), cMemoryOwn: true)
		{
		}

		public static implicit operator VtUCharArray(VtValue value)
		{
			return Vt.VtValueToVtUCharArray(value);
		}

		public static implicit operator VtValue(VtUCharArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtUCharArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_15(VtUCharArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator int(VtValue value)
		{
			return Vt.VtValueToint(value);
		}

		public static implicit operator VtValue(int value)
		{
			return new VtValue(value);
		}

		public VtValue(int obj)
			: this(VtPINVOKE.new_VtValue__SWIG_16(obj), cMemoryOwn: true)
		{
		}

		public static implicit operator VtIntArray(VtValue value)
		{
			return Vt.VtValueToVtIntArray(value);
		}

		public static implicit operator VtValue(VtIntArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtIntArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_17(VtIntArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator uint(VtValue value)
		{
			return Vt.VtValueTouint(value);
		}

		public static implicit operator VtValue(uint value)
		{
			return new VtValue(value);
		}

		public VtValue(uint obj)
			: this(VtPINVOKE.new_VtValue__SWIG_18(obj), cMemoryOwn: true)
		{
		}

		public static implicit operator VtUIntArray(VtValue value)
		{
			return Vt.VtValueToVtUIntArray(value);
		}

		public static implicit operator VtValue(VtUIntArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtUIntArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_19(VtUIntArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator long(VtValue value)
		{
			return Vt.VtValueTolong(value);
		}

		public static implicit operator VtValue(long value)
		{
			return new VtValue(value);
		}

		public VtValue(long obj)
			: this(VtPINVOKE.new_VtValue__SWIG_20(obj), cMemoryOwn: true)
		{
		}

		public static implicit operator VtInt64Array(VtValue value)
		{
			return Vt.VtValueToVtInt64Array(value);
		}

		public static implicit operator VtValue(VtInt64Array value)
		{
			return new VtValue(value);
		}

		public VtValue(VtInt64Array obj)
			: this(VtPINVOKE.new_VtValue__SWIG_21(VtInt64Array.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator ulong(VtValue value)
		{
			return Vt.VtValueToulong(value);
		}

		public static implicit operator VtValue(ulong value)
		{
			return new VtValue(value);
		}

		public VtValue(ulong obj)
			: this(VtPINVOKE.new_VtValue__SWIG_22(obj), cMemoryOwn: true)
		{
		}

		public static implicit operator VtUInt64Array(VtValue value)
		{
			return Vt.VtValueToVtUInt64Array(value);
		}

		public static implicit operator VtValue(VtUInt64Array value)
		{
			return new VtValue(value);
		}

		public VtValue(VtUInt64Array obj)
			: this(VtPINVOKE.new_VtValue__SWIG_23(VtUInt64Array.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfVec4i(VtValue value)
		{
			return Vt.VtValueToGfVec4i(value);
		}

		public static implicit operator VtValue(GfVec4i value)
		{
			return new VtValue(value);
		}

		public VtValue(GfVec4i obj)
			: this(VtPINVOKE.new_VtValue__SWIG_24(GfVec4i.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtVec4iArray(VtValue value)
		{
			return Vt.VtValueToVtVec4iArray(value);
		}

		public static implicit operator VtValue(VtVec4iArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtVec4iArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_25(VtVec4iArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfVec3i(VtValue value)
		{
			return Vt.VtValueToGfVec3i(value);
		}

		public static implicit operator VtValue(GfVec3i value)
		{
			return new VtValue(value);
		}

		public VtValue(GfVec3i obj)
			: this(VtPINVOKE.new_VtValue__SWIG_26(GfVec3i.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtVec3iArray(VtValue value)
		{
			return Vt.VtValueToVtVec3iArray(value);
		}

		public static implicit operator VtValue(VtVec3iArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtVec3iArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_27(VtVec3iArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfVec2i(VtValue value)
		{
			return Vt.VtValueToGfVec2i(value);
		}

		public static implicit operator VtValue(GfVec2i value)
		{
			return new VtValue(value);
		}

		public VtValue(GfVec2i obj)
			: this(VtPINVOKE.new_VtValue__SWIG_28(GfVec2i.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtVec2iArray(VtValue value)
		{
			return Vt.VtValueToVtVec2iArray(value);
		}

		public static implicit operator VtValue(VtVec2iArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtVec2iArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_29(VtVec2iArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfVec4h(VtValue value)
		{
			return Vt.VtValueToGfVec4h(value);
		}

		public static implicit operator VtValue(GfVec4h value)
		{
			return new VtValue(value);
		}

		public VtValue(GfVec4h obj)
			: this(VtPINVOKE.new_VtValue__SWIG_30(GfVec4h.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtVec4hArray(VtValue value)
		{
			return Vt.VtValueToVtVec4hArray(value);
		}

		public static implicit operator VtValue(VtVec4hArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtVec4hArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_31(VtVec4hArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfVec3h(VtValue value)
		{
			return Vt.VtValueToGfVec3h(value);
		}

		public static implicit operator VtValue(GfVec3h value)
		{
			return new VtValue(value);
		}

		public VtValue(GfVec3h obj)
			: this(VtPINVOKE.new_VtValue__SWIG_32(GfVec3h.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtVec3hArray(VtValue value)
		{
			return Vt.VtValueToVtVec3hArray(value);
		}

		public static implicit operator VtValue(VtVec3hArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtVec3hArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_33(VtVec3hArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfVec2h(VtValue value)
		{
			return Vt.VtValueToGfVec2h(value);
		}

		public static implicit operator VtValue(GfVec2h value)
		{
			return new VtValue(value);
		}

		public VtValue(GfVec2h obj)
			: this(VtPINVOKE.new_VtValue__SWIG_34(GfVec2h.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtVec2hArray(VtValue value)
		{
			return Vt.VtValueToVtVec2hArray(value);
		}

		public static implicit operator VtValue(VtVec2hArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtVec2hArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_35(VtVec2hArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfVec4f(VtValue value)
		{
			return Vt.VtValueToGfVec4f(value);
		}

		public static implicit operator VtValue(GfVec4f value)
		{
			return new VtValue(value);
		}

		public VtValue(GfVec4f obj)
			: this(VtPINVOKE.new_VtValue__SWIG_36(GfVec4f.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtVec4fArray(VtValue value)
		{
			return Vt.VtValueToVtVec4fArray(value);
		}

		public static implicit operator VtValue(VtVec4fArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtVec4fArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_37(VtVec4fArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfVec3f(VtValue value)
		{
			return Vt.VtValueToGfVec3f(value);
		}

		public static implicit operator VtValue(GfVec3f value)
		{
			return new VtValue(value);
		}

		public VtValue(GfVec3f obj)
			: this(VtPINVOKE.new_VtValue__SWIG_38(GfVec3f.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtVec3fArray(VtValue value)
		{
			return Vt.VtValueToVtVec3fArray(value);
		}

		public static implicit operator VtValue(VtVec3fArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtVec3fArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_39(VtVec3fArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfVec2f(VtValue value)
		{
			return Vt.VtValueToGfVec2f(value);
		}

		public static implicit operator VtValue(GfVec2f value)
		{
			return new VtValue(value);
		}

		public VtValue(GfVec2f obj)
			: this(VtPINVOKE.new_VtValue__SWIG_40(GfVec2f.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtVec2fArray(VtValue value)
		{
			return Vt.VtValueToVtVec2fArray(value);
		}

		public static implicit operator VtValue(VtVec2fArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtVec2fArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_41(VtVec2fArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfVec4d(VtValue value)
		{
			return Vt.VtValueToGfVec4d(value);
		}

		public static implicit operator VtValue(GfVec4d value)
		{
			return new VtValue(value);
		}

		public VtValue(GfVec4d obj)
			: this(VtPINVOKE.new_VtValue__SWIG_42(GfVec4d.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtVec4dArray(VtValue value)
		{
			return Vt.VtValueToVtVec4dArray(value);
		}

		public static implicit operator VtValue(VtVec4dArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtVec4dArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_43(VtVec4dArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfVec3d(VtValue value)
		{
			return Vt.VtValueToGfVec3d(value);
		}

		public static implicit operator VtValue(GfVec3d value)
		{
			return new VtValue(value);
		}

		public VtValue(GfVec3d obj)
			: this(VtPINVOKE.new_VtValue__SWIG_44(GfVec3d.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtVec3dArray(VtValue value)
		{
			return Vt.VtValueToVtVec3dArray(value);
		}

		public static implicit operator VtValue(VtVec3dArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtVec3dArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_45(VtVec3dArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfVec2d(VtValue value)
		{
			return Vt.VtValueToGfVec2d(value);
		}

		public static implicit operator VtValue(GfVec2d value)
		{
			return new VtValue(value);
		}

		public VtValue(GfVec2d obj)
			: this(VtPINVOKE.new_VtValue__SWIG_46(GfVec2d.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtVec2dArray(VtValue value)
		{
			return Vt.VtValueToVtVec2dArray(value);
		}

		public static implicit operator VtValue(VtVec2dArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtVec2dArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_47(VtVec2dArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfMatrix4d(VtValue value)
		{
			return Vt.VtValueToGfMatrix4d(value);
		}

		public static implicit operator VtValue(GfMatrix4d value)
		{
			return new VtValue(value);
		}

		public VtValue(GfMatrix4d obj)
			: this(VtPINVOKE.new_VtValue__SWIG_48(GfMatrix4d.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtMatrix4dArray(VtValue value)
		{
			return Vt.VtValueToVtMatrix4dArray(value);
		}

		public static implicit operator VtValue(VtMatrix4dArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtMatrix4dArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_49(VtMatrix4dArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfMatrix3d(VtValue value)
		{
			return Vt.VtValueToGfMatrix3d(value);
		}

		public static implicit operator VtValue(GfMatrix3d value)
		{
			return new VtValue(value);
		}

		public VtValue(GfMatrix3d obj)
			: this(VtPINVOKE.new_VtValue__SWIG_50(GfMatrix3d.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtMatrix3dArray(VtValue value)
		{
			return Vt.VtValueToVtMatrix3dArray(value);
		}

		public static implicit operator VtValue(VtMatrix3dArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtMatrix3dArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_51(VtMatrix3dArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfMatrix2d(VtValue value)
		{
			return Vt.VtValueToGfMatrix2d(value);
		}

		public static implicit operator VtValue(GfMatrix2d value)
		{
			return new VtValue(value);
		}

		public VtValue(GfMatrix2d obj)
			: this(VtPINVOKE.new_VtValue__SWIG_52(GfMatrix2d.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtMatrix2dArray(VtValue value)
		{
			return Vt.VtValueToVtMatrix2dArray(value);
		}

		public static implicit operator VtValue(VtMatrix2dArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtMatrix2dArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_53(VtMatrix2dArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfMatrix4f(VtValue value)
		{
			return Vt.VtValueToGfMatrix4f(value);
		}

		public static implicit operator VtValue(GfMatrix4f value)
		{
			return new VtValue(value);
		}

		public VtValue(GfMatrix4f obj)
			: this(VtPINVOKE.new_VtValue__SWIG_54(GfMatrix4f.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtMatrix4fArray(VtValue value)
		{
			return Vt.VtValueToVtMatrix4fArray(value);
		}

		public static implicit operator VtValue(VtMatrix4fArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtMatrix4fArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_55(VtMatrix4fArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfMatrix3f(VtValue value)
		{
			return Vt.VtValueToGfMatrix3f(value);
		}

		public static implicit operator VtValue(GfMatrix3f value)
		{
			return new VtValue(value);
		}

		public VtValue(GfMatrix3f obj)
			: this(VtPINVOKE.new_VtValue__SWIG_56(GfMatrix3f.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtMatrix3fArray(VtValue value)
		{
			return Vt.VtValueToVtMatrix3fArray(value);
		}

		public static implicit operator VtValue(VtMatrix3fArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtMatrix3fArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_57(VtMatrix3fArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfMatrix2f(VtValue value)
		{
			return Vt.VtValueToGfMatrix2f(value);
		}

		public static implicit operator VtValue(GfMatrix2f value)
		{
			return new VtValue(value);
		}

		public VtValue(GfMatrix2f obj)
			: this(VtPINVOKE.new_VtValue__SWIG_58(GfMatrix2f.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtMatrix2fArray(VtValue value)
		{
			return Vt.VtValueToVtMatrix2fArray(value);
		}

		public static implicit operator VtValue(VtMatrix2fArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtMatrix2fArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_59(VtMatrix2fArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfRange3d(VtValue value)
		{
			return Vt.VtValueToGfRange3d(value);
		}

		public static implicit operator VtValue(GfRange3d value)
		{
			return new VtValue(value);
		}

		public VtValue(GfRange3d obj)
			: this(VtPINVOKE.new_VtValue__SWIG_60(GfRange3d.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtRange3dArray(VtValue value)
		{
			return Vt.VtValueToVtRange3dArray(value);
		}

		public static implicit operator VtValue(VtRange3dArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtRange3dArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_61(VtRange3dArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfRange2d(VtValue value)
		{
			return Vt.VtValueToGfRange2d(value);
		}

		public static implicit operator VtValue(GfRange2d value)
		{
			return new VtValue(value);
		}

		public VtValue(GfRange2d obj)
			: this(VtPINVOKE.new_VtValue__SWIG_62(GfRange2d.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtRange2dArray(VtValue value)
		{
			return Vt.VtValueToVtRange2dArray(value);
		}

		public static implicit operator VtValue(VtRange2dArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtRange2dArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_63(VtRange2dArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfRange1f(VtValue value)
		{
			return Vt.VtValueToGfRange1f(value);
		}

		public static implicit operator VtValue(GfRange1f value)
		{
			return new VtValue(value);
		}

		public VtValue(GfRange1f obj)
			: this(VtPINVOKE.new_VtValue__SWIG_64(GfRange1f.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtRange1fArray(VtValue value)
		{
			return Vt.VtValueToVtRange1fArray(value);
		}

		public static implicit operator VtValue(VtRange1fArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtRange1fArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_65(VtRange1fArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfRange1d(VtValue value)
		{
			return Vt.VtValueToGfRange1d(value);
		}

		public static implicit operator VtValue(GfRange1d value)
		{
			return new VtValue(value);
		}

		public VtValue(GfRange1d obj)
			: this(VtPINVOKE.new_VtValue__SWIG_66(GfRange1d.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtRange1dArray(VtValue value)
		{
			return Vt.VtValueToVtRange1dArray(value);
		}

		public static implicit operator VtValue(VtRange1dArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtRange1dArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_67(VtRange1dArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfInterval(VtValue value)
		{
			return Vt.VtValueToGfInterval(value);
		}

		public static implicit operator VtValue(GfInterval value)
		{
			return new VtValue(value);
		}

		public VtValue(GfInterval obj)
			: this(VtPINVOKE.new_VtValue__SWIG_68(GfInterval.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtIntervalArray(VtValue value)
		{
			return Vt.VtValueToVtIntervalArray(value);
		}

		public static implicit operator VtValue(VtIntervalArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtIntervalArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_69(VtIntervalArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator string(VtValue value)
		{
			return Vt.VtValueTostring(value);
		}

		public static implicit operator VtValue(string value)
		{
			return new VtValue(value);
		}

		public VtValue(string obj)
			: this(VtPINVOKE.new_VtValue__SWIG_70(obj), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtStringArray(VtValue value)
		{
			return Vt.VtValueToVtStringArray(value);
		}

		public static implicit operator VtValue(VtStringArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtStringArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_71(VtStringArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator TfToken(VtValue value)
		{
			return Vt.VtValueToTfToken(value);
		}

		public static implicit operator VtValue(TfToken value)
		{
			return new VtValue(value);
		}

		public VtValue(TfToken obj)
			: this(VtPINVOKE.new_VtValue__SWIG_72(TfToken.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtTokenArray(VtValue value)
		{
			return Vt.VtValueToVtTokenArray(value);
		}

		public static implicit operator VtValue(VtTokenArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtTokenArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_73(VtTokenArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfQuath(VtValue value)
		{
			return Vt.VtValueToGfQuath(value);
		}

		public static implicit operator VtValue(GfQuath value)
		{
			return new VtValue(value);
		}

		public VtValue(GfQuath obj)
			: this(VtPINVOKE.new_VtValue__SWIG_74(GfQuath.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtQuathArray(VtValue value)
		{
			return Vt.VtValueToVtQuathArray(value);
		}

		public static implicit operator VtValue(VtQuathArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtQuathArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_75(VtQuathArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfQuatf(VtValue value)
		{
			return Vt.VtValueToGfQuatf(value);
		}

		public static implicit operator VtValue(GfQuatf value)
		{
			return new VtValue(value);
		}

		public VtValue(GfQuatf obj)
			: this(VtPINVOKE.new_VtValue__SWIG_76(GfQuatf.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtQuatfArray(VtValue value)
		{
			return Vt.VtValueToVtQuatfArray(value);
		}

		public static implicit operator VtValue(VtQuatfArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtQuatfArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_77(VtQuatfArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfQuatd(VtValue value)
		{
			return Vt.VtValueToGfQuatd(value);
		}

		public static implicit operator VtValue(GfQuatd value)
		{
			return new VtValue(value);
		}

		public VtValue(GfQuatd obj)
			: this(VtPINVOKE.new_VtValue__SWIG_78(GfQuatd.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtQuatdArray(VtValue value)
		{
			return Vt.VtValueToVtQuatdArray(value);
		}

		public static implicit operator VtValue(VtQuatdArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtQuatdArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_79(VtQuatdArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfQuaternion(VtValue value)
		{
			return Vt.VtValueToGfQuaternion(value);
		}

		public static implicit operator VtValue(GfQuaternion value)
		{
			return new VtValue(value);
		}

		public VtValue(GfQuaternion obj)
			: this(VtPINVOKE.new_VtValue__SWIG_80(GfQuaternion.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtQuaternionArray(VtValue value)
		{
			return Vt.VtValueToVtQuaternionArray(value);
		}

		public static implicit operator VtValue(VtQuaternionArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtQuaternionArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_81(VtQuaternionArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfDualQuath(VtValue value)
		{
			return Vt.VtValueToGfDualQuath(value);
		}

		public static implicit operator VtValue(GfDualQuath value)
		{
			return new VtValue(value);
		}

		public VtValue(GfDualQuath obj)
			: this(VtPINVOKE.new_VtValue__SWIG_82(GfDualQuath.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtDualQuathArray(VtValue value)
		{
			return Vt.VtValueToVtDualQuathArray(value);
		}

		public static implicit operator VtValue(VtDualQuathArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtDualQuathArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_83(VtDualQuathArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfDualQuatf(VtValue value)
		{
			return Vt.VtValueToGfDualQuatf(value);
		}

		public static implicit operator VtValue(GfDualQuatf value)
		{
			return new VtValue(value);
		}

		public VtValue(GfDualQuatf obj)
			: this(VtPINVOKE.new_VtValue__SWIG_84(GfDualQuatf.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtDualQuatfArray(VtValue value)
		{
			return Vt.VtValueToVtDualQuatfArray(value);
		}

		public static implicit operator VtValue(VtDualQuatfArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtDualQuatfArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_85(VtDualQuatfArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfDualQuatd(VtValue value)
		{
			return Vt.VtValueToGfDualQuatd(value);
		}

		public static implicit operator VtValue(GfDualQuatd value)
		{
			return new VtValue(value);
		}

		public VtValue(GfDualQuatd obj)
			: this(VtPINVOKE.new_VtValue__SWIG_86(GfDualQuatd.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator VtDualQuatdArray(VtValue value)
		{
			return Vt.VtValueToVtDualQuatdArray(value);
		}

		public static implicit operator VtValue(VtDualQuatdArray value)
		{
			return new VtValue(value);
		}

		public VtValue(VtDualQuatdArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_87(VtDualQuatdArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator GfFrustum(VtValue value)
		{
			return Vt.VtValueToGfFrustum(value);
		}

		public static implicit operator VtValue(GfFrustum value)
		{
			return new VtValue(value);
		}

		public VtValue(GfFrustum obj)
			: this(VtPINVOKE.new_VtValue__SWIG_88(GfFrustum.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator SdfAssetPath(VtValue value)
		{
			return Vt.VtValueToSdfAssetPath(value);
		}

		public static implicit operator VtValue(SdfAssetPath value)
		{
			return new VtValue(value);
		}

		public VtValue(SdfAssetPath obj)
			: this(VtPINVOKE.new_VtValue__SWIG_89(SdfAssetPath.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static implicit operator SdfAssetPathArray(VtValue value)
		{
			return Vt.VtValueToSdfAssetPathArray(value);
		}

		public static implicit operator VtValue(SdfAssetPathArray value)
		{
			return new VtValue(value);
		}

		public VtValue(SdfAssetPathArray obj)
			: this(VtPINVOKE.new_VtValue__SWIG_90(SdfAssetPathArray.getCPtr(obj)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
