using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtMatrix3fArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfMatrix3f this[int index]
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

		public VtMatrix3fArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtMatrix3fArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtMatrix3fArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtMatrix3fArray obj)
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
						VtPINVOKE.delete_VtMatrix3fArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtMatrix3fArray()
			: this(VtPINVOKE.new_VtMatrix3fArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtMatrix3fArray(VtMatrix3fArray other)
			: this(VtPINVOKE.new_VtMatrix3fArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtMatrix3fArray(uint n)
			: this(VtPINVOKE.new_VtMatrix3fArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtMatrix3fArray(uint n, GfMatrix3f value)
			: this(VtPINVOKE.new_VtMatrix3fArray__SWIG_4(n, GfMatrix3f.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtMatrix3fArray AsConst()
		{
			return new VtMatrix3fArray(VtPINVOKE.VtMatrix3fArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfMatrix3f element)
		{
			VtPINVOKE.VtMatrix3fArray_push_back(swigCPtr, GfMatrix3f.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtMatrix3fArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtMatrix3fArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtMatrix3fArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtMatrix3fArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtMatrix3fArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtMatrix3fArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtMatrix3fArray_clear(swigCPtr);
		}

		public void assign(uint n, GfMatrix3f fill)
		{
			VtPINVOKE.VtMatrix3fArray_assign(swigCPtr, n, GfMatrix3f.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtMatrix3fArray other)
		{
			VtPINVOKE.VtMatrix3fArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtMatrix3fArray other)
		{
			bool result = VtPINVOKE.VtMatrix3fArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtMatrix3fArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfMatrix3f[] dest)
		{
			VtPINVOKE.VtMatrix3fArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfMatrix3f[] src)
		{
			VtPINVOKE.VtMatrix3fArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtMatrix3fArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtMatrix3fArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfMatrix3f GetValue(int index)
		{
			return new GfMatrix3f(VtPINVOKE.VtMatrix3fArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfMatrix3f value)
		{
			VtPINVOKE.VtMatrix3fArray_SetValue(swigCPtr, index, GfMatrix3f.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtMatrix3fArray lhs, VtMatrix3fArray rhs)
		{
			bool result = VtPINVOKE.VtMatrix3fArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtMatrix3fArray lhs, VtMatrix3fArray rhs)
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

		public static bool operator !=(VtMatrix3fArray lhs, VtMatrix3fArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtMatrix3fArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtMatrix3fArray_GetHashCode(swigCPtr);
		}
	}
}
