using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtTokenArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public TfToken this[int index]
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

		public VtTokenArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtTokenArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtTokenArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtTokenArray obj)
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
						VtPINVOKE.delete_VtTokenArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtTokenArray()
			: this(VtPINVOKE.new_VtTokenArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtTokenArray(VtTokenArray other)
			: this(VtPINVOKE.new_VtTokenArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtTokenArray(uint n)
			: this(VtPINVOKE.new_VtTokenArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtTokenArray(uint n, TfToken value)
			: this(VtPINVOKE.new_VtTokenArray__SWIG_4(n, TfToken.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtTokenArray AsConst()
		{
			return new VtTokenArray(VtPINVOKE.VtTokenArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(TfToken element)
		{
			VtPINVOKE.VtTokenArray_push_back(swigCPtr, TfToken.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtTokenArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtTokenArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtTokenArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtTokenArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtTokenArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtTokenArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtTokenArray_clear(swigCPtr);
		}

		public void assign(uint n, TfToken fill)
		{
			VtPINVOKE.VtTokenArray_assign(swigCPtr, n, TfToken.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtTokenArray other)
		{
			VtPINVOKE.VtTokenArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtTokenArray other)
		{
			bool result = VtPINVOKE.VtTokenArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtTokenArray_ToString(swigCPtr);
		}

		public void CopyToArray(TfToken[] dest)
		{
			VtPINVOKE.VtTokenArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(TfToken[] src)
		{
			VtPINVOKE.VtTokenArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtTokenArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtTokenArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected TfToken GetValue(int index)
		{
			return new TfToken(VtPINVOKE.VtTokenArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, TfToken value)
		{
			VtPINVOKE.VtTokenArray_SetValue(swigCPtr, index, TfToken.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtTokenArray lhs, VtTokenArray rhs)
		{
			bool result = VtPINVOKE.VtTokenArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtTokenArray lhs, VtTokenArray rhs)
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

		public static bool operator !=(VtTokenArray lhs, VtTokenArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtTokenArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtTokenArray_GetHashCode(swigCPtr);
		}
	}
}
