using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtVec2fArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfVec2f this[int index]
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

		public VtVec2fArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtVec2fArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtVec2fArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtVec2fArray obj)
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
						VtPINVOKE.delete_VtVec2fArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtVec2fArray()
			: this(VtPINVOKE.new_VtVec2fArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtVec2fArray(VtVec2fArray other)
			: this(VtPINVOKE.new_VtVec2fArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtVec2fArray(uint n)
			: this(VtPINVOKE.new_VtVec2fArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtVec2fArray(uint n, GfVec2f value)
			: this(VtPINVOKE.new_VtVec2fArray__SWIG_4(n, GfVec2f.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtVec2fArray AsConst()
		{
			return new VtVec2fArray(VtPINVOKE.VtVec2fArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfVec2f element)
		{
			VtPINVOKE.VtVec2fArray_push_back(swigCPtr, GfVec2f.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtVec2fArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtVec2fArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtVec2fArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtVec2fArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtVec2fArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtVec2fArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtVec2fArray_clear(swigCPtr);
		}

		public void assign(uint n, GfVec2f fill)
		{
			VtPINVOKE.VtVec2fArray_assign(swigCPtr, n, GfVec2f.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtVec2fArray other)
		{
			VtPINVOKE.VtVec2fArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtVec2fArray other)
		{
			bool result = VtPINVOKE.VtVec2fArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtVec2fArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfVec2f[] dest)
		{
			VtPINVOKE.VtVec2fArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfVec2f[] src)
		{
			VtPINVOKE.VtVec2fArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtVec2fArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtVec2fArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfVec2f GetValue(int index)
		{
			return new GfVec2f(VtPINVOKE.VtVec2fArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfVec2f value)
		{
			VtPINVOKE.VtVec2fArray_SetValue(swigCPtr, index, GfVec2f.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtVec2fArray lhs, VtVec2fArray rhs)
		{
			bool result = VtPINVOKE.VtVec2fArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtVec2fArray lhs, VtVec2fArray rhs)
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

		public static bool operator !=(VtVec2fArray lhs, VtVec2fArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtVec2fArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtVec2fArray_GetHashCode(swigCPtr);
		}
	}
}
