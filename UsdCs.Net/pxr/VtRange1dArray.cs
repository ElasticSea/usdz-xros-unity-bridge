using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtRange1dArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfRange1d this[int index]
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

		public VtRange1dArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtRange1dArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtRange1dArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtRange1dArray obj)
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
						VtPINVOKE.delete_VtRange1dArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtRange1dArray()
			: this(VtPINVOKE.new_VtRange1dArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtRange1dArray(VtRange1dArray other)
			: this(VtPINVOKE.new_VtRange1dArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtRange1dArray(uint n)
			: this(VtPINVOKE.new_VtRange1dArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtRange1dArray(uint n, GfRange1d value)
			: this(VtPINVOKE.new_VtRange1dArray__SWIG_4(n, GfRange1d.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtRange1dArray AsConst()
		{
			return new VtRange1dArray(VtPINVOKE.VtRange1dArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfRange1d element)
		{
			VtPINVOKE.VtRange1dArray_push_back(swigCPtr, GfRange1d.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtRange1dArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtRange1dArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtRange1dArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtRange1dArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtRange1dArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtRange1dArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtRange1dArray_clear(swigCPtr);
		}

		public void assign(uint n, GfRange1d fill)
		{
			VtPINVOKE.VtRange1dArray_assign(swigCPtr, n, GfRange1d.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtRange1dArray other)
		{
			VtPINVOKE.VtRange1dArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtRange1dArray other)
		{
			bool result = VtPINVOKE.VtRange1dArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtRange1dArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfRange1d[] dest)
		{
			VtPINVOKE.VtRange1dArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfRange1d[] src)
		{
			VtPINVOKE.VtRange1dArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtRange1dArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtRange1dArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfRange1d GetValue(int index)
		{
			return new GfRange1d(VtPINVOKE.VtRange1dArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfRange1d value)
		{
			VtPINVOKE.VtRange1dArray_SetValue(swigCPtr, index, GfRange1d.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtRange1dArray lhs, VtRange1dArray rhs)
		{
			bool result = VtPINVOKE.VtRange1dArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtRange1dArray lhs, VtRange1dArray rhs)
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

		public static bool operator !=(VtRange1dArray lhs, VtRange1dArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtRange1dArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtRange1dArray_GetHashCode(swigCPtr);
		}
	}
}
