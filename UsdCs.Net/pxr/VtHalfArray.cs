using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtHalfArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfHalf this[int index]
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

		public VtHalfArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtHalfArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtHalfArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtHalfArray obj)
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
						VtPINVOKE.delete_VtHalfArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtHalfArray()
			: this(VtPINVOKE.new_VtHalfArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtHalfArray(VtHalfArray other)
			: this(VtPINVOKE.new_VtHalfArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtHalfArray(uint n)
			: this(VtPINVOKE.new_VtHalfArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtHalfArray(uint n, GfHalf value)
			: this(VtPINVOKE.new_VtHalfArray__SWIG_4(n, GfHalf.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtHalfArray AsConst()
		{
			return new VtHalfArray(VtPINVOKE.VtHalfArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfHalf element)
		{
			VtPINVOKE.VtHalfArray_push_back(swigCPtr, GfHalf.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtHalfArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtHalfArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtHalfArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtHalfArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtHalfArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtHalfArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtHalfArray_clear(swigCPtr);
		}

		public void assign(uint n, GfHalf fill)
		{
			VtPINVOKE.VtHalfArray_assign(swigCPtr, n, GfHalf.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtHalfArray other)
		{
			VtPINVOKE.VtHalfArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtHalfArray other)
		{
			bool result = VtPINVOKE.VtHalfArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtHalfArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfHalf[] dest)
		{
			VtPINVOKE.VtHalfArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfHalf[] src)
		{
			VtPINVOKE.VtHalfArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtHalfArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtHalfArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfHalf GetValue(int index)
		{
			return new GfHalf(VtPINVOKE.VtHalfArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfHalf value)
		{
			VtPINVOKE.VtHalfArray_SetValue(swigCPtr, index, GfHalf.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtHalfArray lhs, VtHalfArray rhs)
		{
			bool result = VtPINVOKE.VtHalfArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtHalfArray lhs, VtHalfArray rhs)
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

		public static bool operator !=(VtHalfArray lhs, VtHalfArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtHalfArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtHalfArray_GetHashCode(swigCPtr);
		}
	}
}
