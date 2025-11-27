using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtQuatdArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfQuatd this[int index]
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

		public VtQuatdArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtQuatdArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtQuatdArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtQuatdArray obj)
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
						VtPINVOKE.delete_VtQuatdArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtQuatdArray()
			: this(VtPINVOKE.new_VtQuatdArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtQuatdArray(VtQuatdArray other)
			: this(VtPINVOKE.new_VtQuatdArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtQuatdArray(uint n)
			: this(VtPINVOKE.new_VtQuatdArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtQuatdArray(uint n, GfQuatd value)
			: this(VtPINVOKE.new_VtQuatdArray__SWIG_4(n, GfQuatd.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtQuatdArray AsConst()
		{
			return new VtQuatdArray(VtPINVOKE.VtQuatdArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfQuatd element)
		{
			VtPINVOKE.VtQuatdArray_push_back(swigCPtr, GfQuatd.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtQuatdArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtQuatdArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtQuatdArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtQuatdArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtQuatdArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtQuatdArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtQuatdArray_clear(swigCPtr);
		}

		public void assign(uint n, GfQuatd fill)
		{
			VtPINVOKE.VtQuatdArray_assign(swigCPtr, n, GfQuatd.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtQuatdArray other)
		{
			VtPINVOKE.VtQuatdArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtQuatdArray other)
		{
			bool result = VtPINVOKE.VtQuatdArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtQuatdArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfQuatd[] dest)
		{
			VtPINVOKE.VtQuatdArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfQuatd[] src)
		{
			VtPINVOKE.VtQuatdArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtQuatdArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtQuatdArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfQuatd GetValue(int index)
		{
			return new GfQuatd(VtPINVOKE.VtQuatdArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfQuatd value)
		{
			VtPINVOKE.VtQuatdArray_SetValue(swigCPtr, index, GfQuatd.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtQuatdArray lhs, VtQuatdArray rhs)
		{
			bool result = VtPINVOKE.VtQuatdArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtQuatdArray lhs, VtQuatdArray rhs)
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

		public static bool operator !=(VtQuatdArray lhs, VtQuatdArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtQuatdArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtQuatdArray_GetHashCode(swigCPtr);
		}
	}
}
