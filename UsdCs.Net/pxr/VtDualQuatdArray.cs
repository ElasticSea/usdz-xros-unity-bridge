using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtDualQuatdArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfDualQuatd this[int index]
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

		public VtDualQuatdArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtDualQuatdArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtDualQuatdArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtDualQuatdArray obj)
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
						VtPINVOKE.delete_VtDualQuatdArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtDualQuatdArray()
			: this(VtPINVOKE.new_VtDualQuatdArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtDualQuatdArray(VtDualQuatdArray other)
			: this(VtPINVOKE.new_VtDualQuatdArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtDualQuatdArray(uint n)
			: this(VtPINVOKE.new_VtDualQuatdArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtDualQuatdArray(uint n, GfDualQuatd value)
			: this(VtPINVOKE.new_VtDualQuatdArray__SWIG_4(n, GfDualQuatd.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtDualQuatdArray AsConst()
		{
			return new VtDualQuatdArray(VtPINVOKE.VtDualQuatdArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfDualQuatd element)
		{
			VtPINVOKE.VtDualQuatdArray_push_back(swigCPtr, GfDualQuatd.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtDualQuatdArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtDualQuatdArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtDualQuatdArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtDualQuatdArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtDualQuatdArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtDualQuatdArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtDualQuatdArray_clear(swigCPtr);
		}

		public void assign(uint n, GfDualQuatd fill)
		{
			VtPINVOKE.VtDualQuatdArray_assign(swigCPtr, n, GfDualQuatd.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtDualQuatdArray other)
		{
			VtPINVOKE.VtDualQuatdArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtDualQuatdArray other)
		{
			bool result = VtPINVOKE.VtDualQuatdArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtDualQuatdArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfDualQuatd[] dest)
		{
			VtPINVOKE.VtDualQuatdArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfDualQuatd[] src)
		{
			VtPINVOKE.VtDualQuatdArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtDualQuatdArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtDualQuatdArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfDualQuatd GetValue(int index)
		{
			return new GfDualQuatd(VtPINVOKE.VtDualQuatdArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfDualQuatd value)
		{
			VtPINVOKE.VtDualQuatdArray_SetValue(swigCPtr, index, GfDualQuatd.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtDualQuatdArray lhs, VtDualQuatdArray rhs)
		{
			bool result = VtPINVOKE.VtDualQuatdArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtDualQuatdArray lhs, VtDualQuatdArray rhs)
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

		public static bool operator !=(VtDualQuatdArray lhs, VtDualQuatdArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtDualQuatdArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtDualQuatdArray_GetHashCode(swigCPtr);
		}
	}
}
