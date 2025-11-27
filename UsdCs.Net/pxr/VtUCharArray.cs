using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtUCharArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public byte this[int index]
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

		public VtUCharArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtUCharArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtUCharArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtUCharArray obj)
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
						VtPINVOKE.delete_VtUCharArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtUCharArray()
			: this(VtPINVOKE.new_VtUCharArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtUCharArray(VtUCharArray other)
			: this(VtPINVOKE.new_VtUCharArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtUCharArray(uint n)
			: this(VtPINVOKE.new_VtUCharArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtUCharArray(uint n, byte value)
			: this(VtPINVOKE.new_VtUCharArray__SWIG_4(n, value), cMemoryOwn: true)
		{
		}

		public VtUCharArray AsConst()
		{
			return new VtUCharArray(VtPINVOKE.VtUCharArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(byte element)
		{
			VtPINVOKE.VtUCharArray_push_back(swigCPtr, element);
		}

		public void pop_back()
		{
			VtPINVOKE.VtUCharArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtUCharArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtUCharArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtUCharArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtUCharArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtUCharArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtUCharArray_clear(swigCPtr);
		}

		public void assign(uint n, byte fill)
		{
			VtPINVOKE.VtUCharArray_assign(swigCPtr, n, fill);
		}

		public void swap(VtUCharArray other)
		{
			VtPINVOKE.VtUCharArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtUCharArray other)
		{
			bool result = VtPINVOKE.VtUCharArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtUCharArray_ToString(swigCPtr);
		}

		public void CopyToArray(byte[] dest)
		{
			VtPINVOKE.VtUCharArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(byte[] src)
		{
			VtPINVOKE.VtUCharArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtUCharArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtUCharArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected byte GetValue(int index)
		{
			return VtPINVOKE.VtUCharArray_GetValue(swigCPtr, index);
		}

		protected void SetValue(int index, byte value)
		{
			VtPINVOKE.VtUCharArray_SetValue(swigCPtr, index, value);
		}

		public static bool Equals(VtUCharArray lhs, VtUCharArray rhs)
		{
			bool result = VtPINVOKE.VtUCharArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtUCharArray lhs, VtUCharArray rhs)
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

		public static bool operator !=(VtUCharArray lhs, VtUCharArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtUCharArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtUCharArray_GetHashCode(swigCPtr);
		}
	}
}
