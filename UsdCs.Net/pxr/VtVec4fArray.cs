using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtVec4fArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfVec4f this[int index]
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

		public VtVec4fArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtVec4fArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtVec4fArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtVec4fArray obj)
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
						VtPINVOKE.delete_VtVec4fArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtVec4fArray()
			: this(VtPINVOKE.new_VtVec4fArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtVec4fArray(VtVec4fArray other)
			: this(VtPINVOKE.new_VtVec4fArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtVec4fArray(uint n)
			: this(VtPINVOKE.new_VtVec4fArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtVec4fArray(uint n, GfVec4f value)
			: this(VtPINVOKE.new_VtVec4fArray__SWIG_4(n, GfVec4f.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtVec4fArray AsConst()
		{
			return new VtVec4fArray(VtPINVOKE.VtVec4fArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfVec4f element)
		{
			VtPINVOKE.VtVec4fArray_push_back(swigCPtr, GfVec4f.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtVec4fArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtVec4fArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtVec4fArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtVec4fArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtVec4fArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtVec4fArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtVec4fArray_clear(swigCPtr);
		}

		public void assign(uint n, GfVec4f fill)
		{
			VtPINVOKE.VtVec4fArray_assign(swigCPtr, n, GfVec4f.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtVec4fArray other)
		{
			VtPINVOKE.VtVec4fArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtVec4fArray other)
		{
			bool result = VtPINVOKE.VtVec4fArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtVec4fArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfVec4f[] dest)
		{
			VtPINVOKE.VtVec4fArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfVec4f[] src)
		{
			VtPINVOKE.VtVec4fArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtVec4fArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtVec4fArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfVec4f GetValue(int index)
		{
			return new GfVec4f(VtPINVOKE.VtVec4fArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfVec4f value)
		{
			VtPINVOKE.VtVec4fArray_SetValue(swigCPtr, index, GfVec4f.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtVec4fArray lhs, VtVec4fArray rhs)
		{
			bool result = VtPINVOKE.VtVec4fArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtVec4fArray lhs, VtVec4fArray rhs)
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

		public static bool operator !=(VtVec4fArray lhs, VtVec4fArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtVec4fArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtVec4fArray_GetHashCode(swigCPtr);
		}
	}
}
