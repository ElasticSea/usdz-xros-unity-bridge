using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtBoolArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public bool this[int index]
		{
			get
			{
				return GetValue(index);
			}
			set
			{
				SetValue(index, value);
			}
		}

		public VtBoolArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtBoolArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtBoolArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtBoolArray obj)
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
						VtPINVOKE.delete_VtBoolArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtBoolArray()
			: this(VtPINVOKE.new_VtBoolArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtBoolArray(VtBoolArray other)
			: this(VtPINVOKE.new_VtBoolArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtBoolArray(uint n)
			: this(VtPINVOKE.new_VtBoolArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtBoolArray(uint n, bool value)
			: this(VtPINVOKE.new_VtBoolArray__SWIG_4(n, value), cMemoryOwn: true)
		{
		}

		public VtBoolArray AsConst()
		{
			return new VtBoolArray(VtPINVOKE.VtBoolArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(bool element)
		{
			VtPINVOKE.VtBoolArray_push_back(swigCPtr, element);
		}

		public void pop_back()
		{
			VtPINVOKE.VtBoolArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtBoolArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtBoolArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtBoolArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtBoolArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtBoolArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtBoolArray_clear(swigCPtr);
		}

		public void assign(uint n, bool fill)
		{
			VtPINVOKE.VtBoolArray_assign(swigCPtr, n, fill);
		}

		public void swap(VtBoolArray other)
		{
			VtPINVOKE.VtBoolArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtBoolArray other)
		{
			bool result = VtPINVOKE.VtBoolArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtBoolArray_ToString(swigCPtr);
		}

		public void CopyToArray(bool[] dest)
		{
			VtPINVOKE.VtBoolArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(bool[] src)
		{
			VtPINVOKE.VtBoolArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtBoolArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtBoolArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected bool GetValue(int index)
		{
			return VtPINVOKE.VtBoolArray_GetValue(swigCPtr, index);
		}

		protected void SetValue(int index, bool value)
		{
			VtPINVOKE.VtBoolArray_SetValue(swigCPtr, index, value);
		}

		public static bool Equals(VtBoolArray lhs, VtBoolArray rhs)
		{
			bool result = VtPINVOKE.VtBoolArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtBoolArray lhs, VtBoolArray rhs)
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

		public static bool operator !=(VtBoolArray lhs, VtBoolArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtBoolArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtBoolArray_GetHashCode(swigCPtr);
		}
	}
}
