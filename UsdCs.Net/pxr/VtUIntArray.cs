using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtUIntArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public uint this[int index]
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

		public VtUIntArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtUIntArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtUIntArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtUIntArray obj)
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
						VtPINVOKE.delete_VtUIntArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtUIntArray()
			: this(VtPINVOKE.new_VtUIntArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtUIntArray(VtUIntArray other)
			: this(VtPINVOKE.new_VtUIntArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtUIntArray(uint n)
			: this(VtPINVOKE.new_VtUIntArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtUIntArray(uint n, uint value)
			: this(VtPINVOKE.new_VtUIntArray__SWIG_4(n, value), cMemoryOwn: true)
		{
		}

		public VtUIntArray AsConst()
		{
			return new VtUIntArray(VtPINVOKE.VtUIntArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(uint element)
		{
			VtPINVOKE.VtUIntArray_push_back(swigCPtr, element);
		}

		public void pop_back()
		{
			VtPINVOKE.VtUIntArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtUIntArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtUIntArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtUIntArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtUIntArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtUIntArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtUIntArray_clear(swigCPtr);
		}

		public void assign(uint n, uint fill)
		{
			VtPINVOKE.VtUIntArray_assign(swigCPtr, n, fill);
		}

		public void swap(VtUIntArray other)
		{
			VtPINVOKE.VtUIntArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtUIntArray other)
		{
			bool result = VtPINVOKE.VtUIntArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtUIntArray_ToString(swigCPtr);
		}

		public void CopyToArray(uint[] dest)
		{
			VtPINVOKE.VtUIntArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(uint[] src)
		{
			VtPINVOKE.VtUIntArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtUIntArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtUIntArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected uint GetValue(int index)
		{
			return VtPINVOKE.VtUIntArray_GetValue(swigCPtr, index);
		}

		protected void SetValue(int index, uint value)
		{
			VtPINVOKE.VtUIntArray_SetValue(swigCPtr, index, value);
		}

		public static bool Equals(VtUIntArray lhs, VtUIntArray rhs)
		{
			bool result = VtPINVOKE.VtUIntArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtUIntArray lhs, VtUIntArray rhs)
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

		public static bool operator !=(VtUIntArray lhs, VtUIntArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtUIntArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtUIntArray_GetHashCode(swigCPtr);
		}
	}
}
