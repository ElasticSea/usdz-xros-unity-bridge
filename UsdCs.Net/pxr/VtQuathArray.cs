using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtQuathArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfQuath this[int index]
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

		public VtQuathArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtQuathArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtQuathArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtQuathArray obj)
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
						VtPINVOKE.delete_VtQuathArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtQuathArray()
			: this(VtPINVOKE.new_VtQuathArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtQuathArray(VtQuathArray other)
			: this(VtPINVOKE.new_VtQuathArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtQuathArray(uint n)
			: this(VtPINVOKE.new_VtQuathArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtQuathArray(uint n, GfQuath value)
			: this(VtPINVOKE.new_VtQuathArray__SWIG_4(n, GfQuath.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtQuathArray AsConst()
		{
			return new VtQuathArray(VtPINVOKE.VtQuathArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfQuath element)
		{
			VtPINVOKE.VtQuathArray_push_back(swigCPtr, GfQuath.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtQuathArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtQuathArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtQuathArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtQuathArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtQuathArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtQuathArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtQuathArray_clear(swigCPtr);
		}

		public void assign(uint n, GfQuath fill)
		{
			VtPINVOKE.VtQuathArray_assign(swigCPtr, n, GfQuath.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtQuathArray other)
		{
			VtPINVOKE.VtQuathArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtQuathArray other)
		{
			bool result = VtPINVOKE.VtQuathArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtQuathArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfQuath[] dest)
		{
			VtPINVOKE.VtQuathArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfQuath[] src)
		{
			VtPINVOKE.VtQuathArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtQuathArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtQuathArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfQuath GetValue(int index)
		{
			return new GfQuath(VtPINVOKE.VtQuathArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfQuath value)
		{
			VtPINVOKE.VtQuathArray_SetValue(swigCPtr, index, GfQuath.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtQuathArray lhs, VtQuathArray rhs)
		{
			bool result = VtPINVOKE.VtQuathArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtQuathArray lhs, VtQuathArray rhs)
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

		public static bool operator !=(VtQuathArray lhs, VtQuathArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtQuathArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtQuathArray_GetHashCode(swigCPtr);
		}
	}
}
