using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtIntervalArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfInterval this[int index]
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

		public VtIntervalArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtIntervalArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtIntervalArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtIntervalArray obj)
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
						VtPINVOKE.delete_VtIntervalArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtIntervalArray()
			: this(VtPINVOKE.new_VtIntervalArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtIntervalArray(VtIntervalArray other)
			: this(VtPINVOKE.new_VtIntervalArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtIntervalArray(uint n)
			: this(VtPINVOKE.new_VtIntervalArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtIntervalArray(uint n, GfInterval value)
			: this(VtPINVOKE.new_VtIntervalArray__SWIG_4(n, GfInterval.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtIntervalArray AsConst()
		{
			return new VtIntervalArray(VtPINVOKE.VtIntervalArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfInterval element)
		{
			VtPINVOKE.VtIntervalArray_push_back(swigCPtr, GfInterval.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtIntervalArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtIntervalArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtIntervalArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtIntervalArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtIntervalArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtIntervalArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtIntervalArray_clear(swigCPtr);
		}

		public void assign(uint n, GfInterval fill)
		{
			VtPINVOKE.VtIntervalArray_assign(swigCPtr, n, GfInterval.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtIntervalArray other)
		{
			VtPINVOKE.VtIntervalArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtIntervalArray other)
		{
			bool result = VtPINVOKE.VtIntervalArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtIntervalArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfInterval[] dest)
		{
			VtPINVOKE.VtIntervalArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfInterval[] src)
		{
			VtPINVOKE.VtIntervalArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtIntervalArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtIntervalArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfInterval GetValue(int index)
		{
			return new GfInterval(VtPINVOKE.VtIntervalArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfInterval value)
		{
			VtPINVOKE.VtIntervalArray_SetValue(swigCPtr, index, GfInterval.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtIntervalArray lhs, VtIntervalArray rhs)
		{
			bool result = VtPINVOKE.VtIntervalArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtIntervalArray lhs, VtIntervalArray rhs)
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

		public static bool operator !=(VtIntervalArray lhs, VtIntervalArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtIntervalArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtIntervalArray_GetHashCode(swigCPtr);
		}
	}
}
