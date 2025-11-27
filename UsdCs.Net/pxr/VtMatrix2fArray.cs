using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtMatrix2fArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfMatrix2f this[int index]
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

		public VtMatrix2fArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtMatrix2fArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtMatrix2fArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtMatrix2fArray obj)
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
						VtPINVOKE.delete_VtMatrix2fArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtMatrix2fArray()
			: this(VtPINVOKE.new_VtMatrix2fArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtMatrix2fArray(VtMatrix2fArray other)
			: this(VtPINVOKE.new_VtMatrix2fArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtMatrix2fArray(uint n)
			: this(VtPINVOKE.new_VtMatrix2fArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtMatrix2fArray(uint n, GfMatrix2f value)
			: this(VtPINVOKE.new_VtMatrix2fArray__SWIG_4(n, GfMatrix2f.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtMatrix2fArray AsConst()
		{
			return new VtMatrix2fArray(VtPINVOKE.VtMatrix2fArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfMatrix2f element)
		{
			VtPINVOKE.VtMatrix2fArray_push_back(swigCPtr, GfMatrix2f.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtMatrix2fArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtMatrix2fArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtMatrix2fArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtMatrix2fArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtMatrix2fArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtMatrix2fArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtMatrix2fArray_clear(swigCPtr);
		}

		public void assign(uint n, GfMatrix2f fill)
		{
			VtPINVOKE.VtMatrix2fArray_assign(swigCPtr, n, GfMatrix2f.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtMatrix2fArray other)
		{
			VtPINVOKE.VtMatrix2fArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtMatrix2fArray other)
		{
			bool result = VtPINVOKE.VtMatrix2fArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtMatrix2fArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfMatrix2f[] dest)
		{
			VtPINVOKE.VtMatrix2fArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfMatrix2f[] src)
		{
			VtPINVOKE.VtMatrix2fArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtMatrix2fArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtMatrix2fArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfMatrix2f GetValue(int index)
		{
			return new GfMatrix2f(VtPINVOKE.VtMatrix2fArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfMatrix2f value)
		{
			VtPINVOKE.VtMatrix2fArray_SetValue(swigCPtr, index, GfMatrix2f.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtMatrix2fArray lhs, VtMatrix2fArray rhs)
		{
			bool result = VtPINVOKE.VtMatrix2fArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtMatrix2fArray lhs, VtMatrix2fArray rhs)
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

		public static bool operator !=(VtMatrix2fArray lhs, VtMatrix2fArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtMatrix2fArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtMatrix2fArray_GetHashCode(swigCPtr);
		}
	}
}
