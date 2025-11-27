using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtDualQuathArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfDualQuath this[int index]
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

		public VtDualQuathArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtDualQuathArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtDualQuathArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtDualQuathArray obj)
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
						VtPINVOKE.delete_VtDualQuathArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtDualQuathArray()
			: this(VtPINVOKE.new_VtDualQuathArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtDualQuathArray(VtDualQuathArray other)
			: this(VtPINVOKE.new_VtDualQuathArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtDualQuathArray(uint n)
			: this(VtPINVOKE.new_VtDualQuathArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtDualQuathArray(uint n, GfDualQuath value)
			: this(VtPINVOKE.new_VtDualQuathArray__SWIG_4(n, GfDualQuath.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtDualQuathArray AsConst()
		{
			return new VtDualQuathArray(VtPINVOKE.VtDualQuathArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfDualQuath element)
		{
			VtPINVOKE.VtDualQuathArray_push_back(swigCPtr, GfDualQuath.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtDualQuathArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtDualQuathArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtDualQuathArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtDualQuathArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtDualQuathArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtDualQuathArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtDualQuathArray_clear(swigCPtr);
		}

		public void assign(uint n, GfDualQuath fill)
		{
			VtPINVOKE.VtDualQuathArray_assign(swigCPtr, n, GfDualQuath.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtDualQuathArray other)
		{
			VtPINVOKE.VtDualQuathArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtDualQuathArray other)
		{
			bool result = VtPINVOKE.VtDualQuathArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtDualQuathArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfDualQuath[] dest)
		{
			VtPINVOKE.VtDualQuathArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfDualQuath[] src)
		{
			VtPINVOKE.VtDualQuathArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtDualQuathArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtDualQuathArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfDualQuath GetValue(int index)
		{
			return new GfDualQuath(VtPINVOKE.VtDualQuathArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfDualQuath value)
		{
			VtPINVOKE.VtDualQuathArray_SetValue(swigCPtr, index, GfDualQuath.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtDualQuathArray lhs, VtDualQuathArray rhs)
		{
			bool result = VtPINVOKE.VtDualQuathArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtDualQuathArray lhs, VtDualQuathArray rhs)
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

		public static bool operator !=(VtDualQuathArray lhs, VtDualQuathArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtDualQuathArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtDualQuathArray_GetHashCode(swigCPtr);
		}
	}
}
