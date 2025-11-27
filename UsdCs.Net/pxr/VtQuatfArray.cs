using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtQuatfArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfQuatf this[int index]
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

		public VtQuatfArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtQuatfArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtQuatfArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtQuatfArray obj)
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
						VtPINVOKE.delete_VtQuatfArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtQuatfArray()
			: this(VtPINVOKE.new_VtQuatfArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtQuatfArray(VtQuatfArray other)
			: this(VtPINVOKE.new_VtQuatfArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtQuatfArray(uint n)
			: this(VtPINVOKE.new_VtQuatfArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtQuatfArray(uint n, GfQuatf value)
			: this(VtPINVOKE.new_VtQuatfArray__SWIG_4(n, GfQuatf.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtQuatfArray AsConst()
		{
			return new VtQuatfArray(VtPINVOKE.VtQuatfArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfQuatf element)
		{
			VtPINVOKE.VtQuatfArray_push_back(swigCPtr, GfQuatf.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtQuatfArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtQuatfArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtQuatfArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtQuatfArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtQuatfArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtQuatfArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtQuatfArray_clear(swigCPtr);
		}

		public void assign(uint n, GfQuatf fill)
		{
			VtPINVOKE.VtQuatfArray_assign(swigCPtr, n, GfQuatf.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtQuatfArray other)
		{
			VtPINVOKE.VtQuatfArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtQuatfArray other)
		{
			bool result = VtPINVOKE.VtQuatfArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtQuatfArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfQuatf[] dest)
		{
			VtPINVOKE.VtQuatfArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfQuatf[] src)
		{
			VtPINVOKE.VtQuatfArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtQuatfArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtQuatfArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfQuatf GetValue(int index)
		{
			return new GfQuatf(VtPINVOKE.VtQuatfArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfQuatf value)
		{
			VtPINVOKE.VtQuatfArray_SetValue(swigCPtr, index, GfQuatf.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtQuatfArray lhs, VtQuatfArray rhs)
		{
			bool result = VtPINVOKE.VtQuatfArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtQuatfArray lhs, VtQuatfArray rhs)
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

		public static bool operator !=(VtQuatfArray lhs, VtQuatfArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtQuatfArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtQuatfArray_GetHashCode(swigCPtr);
		}
	}
}
