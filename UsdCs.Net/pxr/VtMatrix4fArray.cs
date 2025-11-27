using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtMatrix4fArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfMatrix4f this[int index]
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

		public VtMatrix4fArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtMatrix4fArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtMatrix4fArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtMatrix4fArray obj)
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
						VtPINVOKE.delete_VtMatrix4fArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtMatrix4fArray()
			: this(VtPINVOKE.new_VtMatrix4fArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtMatrix4fArray(VtMatrix4fArray other)
			: this(VtPINVOKE.new_VtMatrix4fArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtMatrix4fArray(uint n)
			: this(VtPINVOKE.new_VtMatrix4fArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtMatrix4fArray(uint n, GfMatrix4f value)
			: this(VtPINVOKE.new_VtMatrix4fArray__SWIG_4(n, GfMatrix4f.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtMatrix4fArray AsConst()
		{
			return new VtMatrix4fArray(VtPINVOKE.VtMatrix4fArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfMatrix4f element)
		{
			VtPINVOKE.VtMatrix4fArray_push_back(swigCPtr, GfMatrix4f.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtMatrix4fArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtMatrix4fArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtMatrix4fArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtMatrix4fArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtMatrix4fArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtMatrix4fArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtMatrix4fArray_clear(swigCPtr);
		}

		public void assign(uint n, GfMatrix4f fill)
		{
			VtPINVOKE.VtMatrix4fArray_assign(swigCPtr, n, GfMatrix4f.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtMatrix4fArray other)
		{
			VtPINVOKE.VtMatrix4fArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtMatrix4fArray other)
		{
			bool result = VtPINVOKE.VtMatrix4fArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtMatrix4fArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfMatrix4f[] dest)
		{
			VtPINVOKE.VtMatrix4fArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfMatrix4f[] src)
		{
			VtPINVOKE.VtMatrix4fArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtMatrix4fArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtMatrix4fArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfMatrix4f GetValue(int index)
		{
			return new GfMatrix4f(VtPINVOKE.VtMatrix4fArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfMatrix4f value)
		{
			VtPINVOKE.VtMatrix4fArray_SetValue(swigCPtr, index, GfMatrix4f.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtMatrix4fArray lhs, VtMatrix4fArray rhs)
		{
			bool result = VtPINVOKE.VtMatrix4fArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtMatrix4fArray lhs, VtMatrix4fArray rhs)
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

		public static bool operator !=(VtMatrix4fArray lhs, VtMatrix4fArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtMatrix4fArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtMatrix4fArray_GetHashCode(swigCPtr);
		}
	}
}
