using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtVec2hArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfVec2h this[int index]
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

		public VtVec2hArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtVec2hArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtVec2hArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtVec2hArray obj)
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
						VtPINVOKE.delete_VtVec2hArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtVec2hArray()
			: this(VtPINVOKE.new_VtVec2hArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtVec2hArray(VtVec2hArray other)
			: this(VtPINVOKE.new_VtVec2hArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtVec2hArray(uint n)
			: this(VtPINVOKE.new_VtVec2hArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtVec2hArray(uint n, GfVec2h value)
			: this(VtPINVOKE.new_VtVec2hArray__SWIG_4(n, GfVec2h.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtVec2hArray AsConst()
		{
			return new VtVec2hArray(VtPINVOKE.VtVec2hArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfVec2h element)
		{
			VtPINVOKE.VtVec2hArray_push_back(swigCPtr, GfVec2h.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtVec2hArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtVec2hArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtVec2hArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtVec2hArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtVec2hArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtVec2hArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtVec2hArray_clear(swigCPtr);
		}

		public void assign(uint n, GfVec2h fill)
		{
			VtPINVOKE.VtVec2hArray_assign(swigCPtr, n, GfVec2h.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtVec2hArray other)
		{
			VtPINVOKE.VtVec2hArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtVec2hArray other)
		{
			bool result = VtPINVOKE.VtVec2hArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtVec2hArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfVec2h[] dest)
		{
			VtPINVOKE.VtVec2hArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfVec2h[] src)
		{
			VtPINVOKE.VtVec2hArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtVec2hArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtVec2hArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfVec2h GetValue(int index)
		{
			return new GfVec2h(VtPINVOKE.VtVec2hArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfVec2h value)
		{
			VtPINVOKE.VtVec2hArray_SetValue(swigCPtr, index, GfVec2h.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtVec2hArray lhs, VtVec2hArray rhs)
		{
			bool result = VtPINVOKE.VtVec2hArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtVec2hArray lhs, VtVec2hArray rhs)
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

		public static bool operator !=(VtVec2hArray lhs, VtVec2hArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtVec2hArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtVec2hArray_GetHashCode(swigCPtr);
		}
	}
}
