using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtRange2dArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfRange2d this[int index]
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

		public VtRange2dArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtRange2dArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtRange2dArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtRange2dArray obj)
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
						VtPINVOKE.delete_VtRange2dArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtRange2dArray()
			: this(VtPINVOKE.new_VtRange2dArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtRange2dArray(VtRange2dArray other)
			: this(VtPINVOKE.new_VtRange2dArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtRange2dArray(uint n)
			: this(VtPINVOKE.new_VtRange2dArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtRange2dArray(uint n, GfRange2d value)
			: this(VtPINVOKE.new_VtRange2dArray__SWIG_4(n, GfRange2d.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtRange2dArray AsConst()
		{
			return new VtRange2dArray(VtPINVOKE.VtRange2dArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfRange2d element)
		{
			VtPINVOKE.VtRange2dArray_push_back(swigCPtr, GfRange2d.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtRange2dArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtRange2dArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtRange2dArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtRange2dArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtRange2dArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtRange2dArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtRange2dArray_clear(swigCPtr);
		}

		public void assign(uint n, GfRange2d fill)
		{
			VtPINVOKE.VtRange2dArray_assign(swigCPtr, n, GfRange2d.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtRange2dArray other)
		{
			VtPINVOKE.VtRange2dArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtRange2dArray other)
		{
			bool result = VtPINVOKE.VtRange2dArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtRange2dArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfRange2d[] dest)
		{
			VtPINVOKE.VtRange2dArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfRange2d[] src)
		{
			VtPINVOKE.VtRange2dArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtRange2dArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtRange2dArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfRange2d GetValue(int index)
		{
			return new GfRange2d(VtPINVOKE.VtRange2dArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfRange2d value)
		{
			VtPINVOKE.VtRange2dArray_SetValue(swigCPtr, index, GfRange2d.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtRange2dArray lhs, VtRange2dArray rhs)
		{
			bool result = VtPINVOKE.VtRange2dArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtRange2dArray lhs, VtRange2dArray rhs)
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

		public static bool operator !=(VtRange2dArray lhs, VtRange2dArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtRange2dArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtRange2dArray_GetHashCode(swigCPtr);
		}
	}
}
