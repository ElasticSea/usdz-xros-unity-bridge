using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtIntArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public int this[int index]
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

		public VtIntArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtIntArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtIntArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtIntArray obj)
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
						VtPINVOKE.delete_VtIntArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtIntArray()
			: this(VtPINVOKE.new_VtIntArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtIntArray(VtIntArray other)
			: this(VtPINVOKE.new_VtIntArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtIntArray(uint n)
			: this(VtPINVOKE.new_VtIntArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtIntArray(uint n, int value)
			: this(VtPINVOKE.new_VtIntArray__SWIG_4(n, value), cMemoryOwn: true)
		{
		}

		public VtIntArray AsConst()
		{
			return new VtIntArray(VtPINVOKE.VtIntArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(int element)
		{
			VtPINVOKE.VtIntArray_push_back(swigCPtr, element);
		}

		public void pop_back()
		{
			VtPINVOKE.VtIntArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtIntArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtIntArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtIntArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtIntArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtIntArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtIntArray_clear(swigCPtr);
		}

		public void assign(uint n, int fill)
		{
			VtPINVOKE.VtIntArray_assign(swigCPtr, n, fill);
		}

		public void swap(VtIntArray other)
		{
			VtPINVOKE.VtIntArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtIntArray other)
		{
			bool result = VtPINVOKE.VtIntArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtIntArray_ToString(swigCPtr);
		}

		public void CopyToArray(int[] dest)
		{
			VtPINVOKE.VtIntArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(int[] src)
		{
			VtPINVOKE.VtIntArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtIntArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtIntArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected int GetValue(int index)
		{
			return VtPINVOKE.VtIntArray_GetValue(swigCPtr, index);
		}

		protected void SetValue(int index, int value)
		{
			VtPINVOKE.VtIntArray_SetValue(swigCPtr, index, value);
		}

		public static bool Equals(VtIntArray lhs, VtIntArray rhs)
		{
			bool result = VtPINVOKE.VtIntArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtIntArray lhs, VtIntArray rhs)
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

		public static bool operator !=(VtIntArray lhs, VtIntArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtIntArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtIntArray_GetHashCode(swigCPtr);
		}
	}
}
