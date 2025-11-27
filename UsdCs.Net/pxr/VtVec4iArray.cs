using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtVec4iArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfVec4i this[int index]
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

		public VtVec4iArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtVec4iArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtVec4iArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtVec4iArray obj)
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
						VtPINVOKE.delete_VtVec4iArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtVec4iArray()
			: this(VtPINVOKE.new_VtVec4iArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtVec4iArray(VtVec4iArray other)
			: this(VtPINVOKE.new_VtVec4iArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtVec4iArray(uint n)
			: this(VtPINVOKE.new_VtVec4iArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtVec4iArray(uint n, GfVec4i value)
			: this(VtPINVOKE.new_VtVec4iArray__SWIG_4(n, GfVec4i.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtVec4iArray AsConst()
		{
			return new VtVec4iArray(VtPINVOKE.VtVec4iArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfVec4i element)
		{
			VtPINVOKE.VtVec4iArray_push_back(swigCPtr, GfVec4i.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtVec4iArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtVec4iArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtVec4iArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtVec4iArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtVec4iArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtVec4iArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtVec4iArray_clear(swigCPtr);
		}

		public void assign(uint n, GfVec4i fill)
		{
			VtPINVOKE.VtVec4iArray_assign(swigCPtr, n, GfVec4i.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtVec4iArray other)
		{
			VtPINVOKE.VtVec4iArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtVec4iArray other)
		{
			bool result = VtPINVOKE.VtVec4iArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtVec4iArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfVec4i[] dest)
		{
			VtPINVOKE.VtVec4iArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfVec4i[] src)
		{
			VtPINVOKE.VtVec4iArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtVec4iArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtVec4iArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfVec4i GetValue(int index)
		{
			return new GfVec4i(VtPINVOKE.VtVec4iArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfVec4i value)
		{
			VtPINVOKE.VtVec4iArray_SetValue(swigCPtr, index, GfVec4i.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtVec4iArray lhs, VtVec4iArray rhs)
		{
			bool result = VtPINVOKE.VtVec4iArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtVec4iArray lhs, VtVec4iArray rhs)
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

		public static bool operator !=(VtVec4iArray lhs, VtVec4iArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtVec4iArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtVec4iArray_GetHashCode(swigCPtr);
		}
	}
}
