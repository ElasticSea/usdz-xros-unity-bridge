using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtMatrix4dArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfMatrix4d this[int index]
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

		public VtMatrix4dArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtMatrix4dArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtMatrix4dArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtMatrix4dArray obj)
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
						VtPINVOKE.delete_VtMatrix4dArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtMatrix4dArray()
			: this(VtPINVOKE.new_VtMatrix4dArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtMatrix4dArray(VtMatrix4dArray other)
			: this(VtPINVOKE.new_VtMatrix4dArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtMatrix4dArray(uint n)
			: this(VtPINVOKE.new_VtMatrix4dArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtMatrix4dArray(uint n, GfMatrix4d value)
			: this(VtPINVOKE.new_VtMatrix4dArray__SWIG_4(n, GfMatrix4d.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtMatrix4dArray AsConst()
		{
			return new VtMatrix4dArray(VtPINVOKE.VtMatrix4dArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfMatrix4d element)
		{
			VtPINVOKE.VtMatrix4dArray_push_back(swigCPtr, GfMatrix4d.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtMatrix4dArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtMatrix4dArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtMatrix4dArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtMatrix4dArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtMatrix4dArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtMatrix4dArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtMatrix4dArray_clear(swigCPtr);
		}

		public void assign(uint n, GfMatrix4d fill)
		{
			VtPINVOKE.VtMatrix4dArray_assign(swigCPtr, n, GfMatrix4d.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtMatrix4dArray other)
		{
			VtPINVOKE.VtMatrix4dArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtMatrix4dArray other)
		{
			bool result = VtPINVOKE.VtMatrix4dArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtMatrix4dArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfMatrix4d[] dest)
		{
			VtPINVOKE.VtMatrix4dArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfMatrix4d[] src)
		{
			VtPINVOKE.VtMatrix4dArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtMatrix4dArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtMatrix4dArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfMatrix4d GetValue(int index)
		{
			return new GfMatrix4d(VtPINVOKE.VtMatrix4dArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfMatrix4d value)
		{
			VtPINVOKE.VtMatrix4dArray_SetValue(swigCPtr, index, GfMatrix4d.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtMatrix4dArray lhs, VtMatrix4dArray rhs)
		{
			bool result = VtPINVOKE.VtMatrix4dArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtMatrix4dArray lhs, VtMatrix4dArray rhs)
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

		public static bool operator !=(VtMatrix4dArray lhs, VtMatrix4dArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtMatrix4dArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtMatrix4dArray_GetHashCode(swigCPtr);
		}
	}
}
