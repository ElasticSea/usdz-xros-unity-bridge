using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtVec4dArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfVec4d this[int index]
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

		public VtVec4dArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtVec4dArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtVec4dArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtVec4dArray obj)
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
						VtPINVOKE.delete_VtVec4dArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtVec4dArray()
			: this(VtPINVOKE.new_VtVec4dArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtVec4dArray(VtVec4dArray other)
			: this(VtPINVOKE.new_VtVec4dArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtVec4dArray(uint n)
			: this(VtPINVOKE.new_VtVec4dArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtVec4dArray(uint n, GfVec4d value)
			: this(VtPINVOKE.new_VtVec4dArray__SWIG_4(n, GfVec4d.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtVec4dArray AsConst()
		{
			return new VtVec4dArray(VtPINVOKE.VtVec4dArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfVec4d element)
		{
			VtPINVOKE.VtVec4dArray_push_back(swigCPtr, GfVec4d.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtVec4dArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtVec4dArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtVec4dArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtVec4dArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtVec4dArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtVec4dArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtVec4dArray_clear(swigCPtr);
		}

		public void assign(uint n, GfVec4d fill)
		{
			VtPINVOKE.VtVec4dArray_assign(swigCPtr, n, GfVec4d.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtVec4dArray other)
		{
			VtPINVOKE.VtVec4dArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtVec4dArray other)
		{
			bool result = VtPINVOKE.VtVec4dArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtVec4dArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfVec4d[] dest)
		{
			VtPINVOKE.VtVec4dArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfVec4d[] src)
		{
			VtPINVOKE.VtVec4dArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtVec4dArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtVec4dArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfVec4d GetValue(int index)
		{
			return new GfVec4d(VtPINVOKE.VtVec4dArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfVec4d value)
		{
			VtPINVOKE.VtVec4dArray_SetValue(swigCPtr, index, GfVec4d.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtVec4dArray lhs, VtVec4dArray rhs)
		{
			bool result = VtPINVOKE.VtVec4dArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtVec4dArray lhs, VtVec4dArray rhs)
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

		public static bool operator !=(VtVec4dArray lhs, VtVec4dArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtVec4dArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtVec4dArray_GetHashCode(swigCPtr);
		}
	}
}
