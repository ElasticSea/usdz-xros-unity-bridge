using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtCharArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public char this[int index]
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

		public VtCharArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtCharArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtCharArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtCharArray obj)
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
						VtPINVOKE.delete_VtCharArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtCharArray()
			: this(VtPINVOKE.new_VtCharArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtCharArray(VtCharArray other)
			: this(VtPINVOKE.new_VtCharArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtCharArray(uint n)
			: this(VtPINVOKE.new_VtCharArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtCharArray(uint n, char value)
			: this(VtPINVOKE.new_VtCharArray__SWIG_4(n, value), cMemoryOwn: true)
		{
		}

		public VtCharArray AsConst()
		{
			return new VtCharArray(VtPINVOKE.VtCharArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(char element)
		{
			VtPINVOKE.VtCharArray_push_back(swigCPtr, element);
		}

		public void pop_back()
		{
			VtPINVOKE.VtCharArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtCharArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtCharArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtCharArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtCharArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtCharArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtCharArray_clear(swigCPtr);
		}

		public void assign(uint n, char fill)
		{
			VtPINVOKE.VtCharArray_assign(swigCPtr, n, fill);
		}

		public void swap(VtCharArray other)
		{
			VtPINVOKE.VtCharArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtCharArray other)
		{
			bool result = VtPINVOKE.VtCharArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtCharArray_ToString(swigCPtr);
		}

		public void CopyToArray(char[] dest)
		{
			VtPINVOKE.VtCharArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(char[] src)
		{
			VtPINVOKE.VtCharArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtCharArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtCharArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected char GetValue(int index)
		{
			return VtPINVOKE.VtCharArray_GetValue(swigCPtr, index);
		}

		protected void SetValue(int index, char value)
		{
			VtPINVOKE.VtCharArray_SetValue(swigCPtr, index, value);
		}

		public static bool Equals(VtCharArray lhs, VtCharArray rhs)
		{
			bool result = VtPINVOKE.VtCharArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtCharArray lhs, VtCharArray rhs)
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

		public static bool operator !=(VtCharArray lhs, VtCharArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtCharArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtCharArray_GetHashCode(swigCPtr);
		}
	}
}
