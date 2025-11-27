using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtMatrix2dArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfMatrix2d this[int index]
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

		public VtMatrix2dArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtMatrix2dArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtMatrix2dArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtMatrix2dArray obj)
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
						VtPINVOKE.delete_VtMatrix2dArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtMatrix2dArray()
			: this(VtPINVOKE.new_VtMatrix2dArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtMatrix2dArray(VtMatrix2dArray other)
			: this(VtPINVOKE.new_VtMatrix2dArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtMatrix2dArray(uint n)
			: this(VtPINVOKE.new_VtMatrix2dArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtMatrix2dArray(uint n, GfMatrix2d value)
			: this(VtPINVOKE.new_VtMatrix2dArray__SWIG_4(n, GfMatrix2d.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtMatrix2dArray AsConst()
		{
			return new VtMatrix2dArray(VtPINVOKE.VtMatrix2dArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfMatrix2d element)
		{
			VtPINVOKE.VtMatrix2dArray_push_back(swigCPtr, GfMatrix2d.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtMatrix2dArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtMatrix2dArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtMatrix2dArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtMatrix2dArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtMatrix2dArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtMatrix2dArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtMatrix2dArray_clear(swigCPtr);
		}

		public void assign(uint n, GfMatrix2d fill)
		{
			VtPINVOKE.VtMatrix2dArray_assign(swigCPtr, n, GfMatrix2d.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtMatrix2dArray other)
		{
			VtPINVOKE.VtMatrix2dArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtMatrix2dArray other)
		{
			bool result = VtPINVOKE.VtMatrix2dArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtMatrix2dArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfMatrix2d[] dest)
		{
			VtPINVOKE.VtMatrix2dArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfMatrix2d[] src)
		{
			VtPINVOKE.VtMatrix2dArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtMatrix2dArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtMatrix2dArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfMatrix2d GetValue(int index)
		{
			return new GfMatrix2d(VtPINVOKE.VtMatrix2dArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfMatrix2d value)
		{
			VtPINVOKE.VtMatrix2dArray_SetValue(swigCPtr, index, GfMatrix2d.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtMatrix2dArray lhs, VtMatrix2dArray rhs)
		{
			bool result = VtPINVOKE.VtMatrix2dArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtMatrix2dArray lhs, VtMatrix2dArray rhs)
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

		public static bool operator !=(VtMatrix2dArray lhs, VtMatrix2dArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtMatrix2dArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtMatrix2dArray_GetHashCode(swigCPtr);
		}
	}
}
