using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtDualQuatfArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfDualQuatf this[int index]
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

		public VtDualQuatfArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtDualQuatfArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtDualQuatfArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtDualQuatfArray obj)
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
						VtPINVOKE.delete_VtDualQuatfArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtDualQuatfArray()
			: this(VtPINVOKE.new_VtDualQuatfArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtDualQuatfArray(VtDualQuatfArray other)
			: this(VtPINVOKE.new_VtDualQuatfArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtDualQuatfArray(uint n)
			: this(VtPINVOKE.new_VtDualQuatfArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtDualQuatfArray(uint n, GfDualQuatf value)
			: this(VtPINVOKE.new_VtDualQuatfArray__SWIG_4(n, GfDualQuatf.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtDualQuatfArray AsConst()
		{
			return new VtDualQuatfArray(VtPINVOKE.VtDualQuatfArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfDualQuatf element)
		{
			VtPINVOKE.VtDualQuatfArray_push_back(swigCPtr, GfDualQuatf.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtDualQuatfArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtDualQuatfArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtDualQuatfArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtDualQuatfArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtDualQuatfArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtDualQuatfArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtDualQuatfArray_clear(swigCPtr);
		}

		public void assign(uint n, GfDualQuatf fill)
		{
			VtPINVOKE.VtDualQuatfArray_assign(swigCPtr, n, GfDualQuatf.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtDualQuatfArray other)
		{
			VtPINVOKE.VtDualQuatfArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtDualQuatfArray other)
		{
			bool result = VtPINVOKE.VtDualQuatfArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtDualQuatfArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfDualQuatf[] dest)
		{
			VtPINVOKE.VtDualQuatfArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfDualQuatf[] src)
		{
			VtPINVOKE.VtDualQuatfArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtDualQuatfArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtDualQuatfArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfDualQuatf GetValue(int index)
		{
			return new GfDualQuatf(VtPINVOKE.VtDualQuatfArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfDualQuatf value)
		{
			VtPINVOKE.VtDualQuatfArray_SetValue(swigCPtr, index, GfDualQuatf.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtDualQuatfArray lhs, VtDualQuatfArray rhs)
		{
			bool result = VtPINVOKE.VtDualQuatfArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtDualQuatfArray lhs, VtDualQuatfArray rhs)
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

		public static bool operator !=(VtDualQuatfArray lhs, VtDualQuatfArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtDualQuatfArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtDualQuatfArray_GetHashCode(swigCPtr);
		}
	}
}
