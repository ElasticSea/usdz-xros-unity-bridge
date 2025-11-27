using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtVec4hArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfVec4h this[int index]
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

		public VtVec4hArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtVec4hArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtVec4hArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtVec4hArray obj)
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
						VtPINVOKE.delete_VtVec4hArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtVec4hArray()
			: this(VtPINVOKE.new_VtVec4hArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtVec4hArray(VtVec4hArray other)
			: this(VtPINVOKE.new_VtVec4hArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtVec4hArray(uint n)
			: this(VtPINVOKE.new_VtVec4hArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtVec4hArray(uint n, GfVec4h value)
			: this(VtPINVOKE.new_VtVec4hArray__SWIG_4(n, GfVec4h.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtVec4hArray AsConst()
		{
			return new VtVec4hArray(VtPINVOKE.VtVec4hArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfVec4h element)
		{
			VtPINVOKE.VtVec4hArray_push_back(swigCPtr, GfVec4h.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtVec4hArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtVec4hArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtVec4hArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtVec4hArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtVec4hArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtVec4hArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtVec4hArray_clear(swigCPtr);
		}

		public void assign(uint n, GfVec4h fill)
		{
			VtPINVOKE.VtVec4hArray_assign(swigCPtr, n, GfVec4h.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtVec4hArray other)
		{
			VtPINVOKE.VtVec4hArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtVec4hArray other)
		{
			bool result = VtPINVOKE.VtVec4hArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtVec4hArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfVec4h[] dest)
		{
			VtPINVOKE.VtVec4hArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfVec4h[] src)
		{
			VtPINVOKE.VtVec4hArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtVec4hArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtVec4hArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfVec4h GetValue(int index)
		{
			return new GfVec4h(VtPINVOKE.VtVec4hArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfVec4h value)
		{
			VtPINVOKE.VtVec4hArray_SetValue(swigCPtr, index, GfVec4h.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtVec4hArray lhs, VtVec4hArray rhs)
		{
			bool result = VtPINVOKE.VtVec4hArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtVec4hArray lhs, VtVec4hArray rhs)
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

		public static bool operator !=(VtVec4hArray lhs, VtVec4hArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtVec4hArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtVec4hArray_GetHashCode(swigCPtr);
		}
	}
}
