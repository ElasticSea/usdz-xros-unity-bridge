using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtVec3hArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfVec3h this[int index]
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

		public VtVec3hArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtVec3hArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtVec3hArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtVec3hArray obj)
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
						VtPINVOKE.delete_VtVec3hArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtVec3hArray()
			: this(VtPINVOKE.new_VtVec3hArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtVec3hArray(VtVec3hArray other)
			: this(VtPINVOKE.new_VtVec3hArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtVec3hArray(uint n)
			: this(VtPINVOKE.new_VtVec3hArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtVec3hArray(uint n, GfVec3h value)
			: this(VtPINVOKE.new_VtVec3hArray__SWIG_4(n, GfVec3h.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtVec3hArray AsConst()
		{
			return new VtVec3hArray(VtPINVOKE.VtVec3hArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfVec3h element)
		{
			VtPINVOKE.VtVec3hArray_push_back(swigCPtr, GfVec3h.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtVec3hArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtVec3hArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtVec3hArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtVec3hArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtVec3hArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtVec3hArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtVec3hArray_clear(swigCPtr);
		}

		public void assign(uint n, GfVec3h fill)
		{
			VtPINVOKE.VtVec3hArray_assign(swigCPtr, n, GfVec3h.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtVec3hArray other)
		{
			VtPINVOKE.VtVec3hArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtVec3hArray other)
		{
			bool result = VtPINVOKE.VtVec3hArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtVec3hArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfVec3h[] dest)
		{
			VtPINVOKE.VtVec3hArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfVec3h[] src)
		{
			VtPINVOKE.VtVec3hArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtVec3hArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtVec3hArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfVec3h GetValue(int index)
		{
			return new GfVec3h(VtPINVOKE.VtVec3hArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfVec3h value)
		{
			VtPINVOKE.VtVec3hArray_SetValue(swigCPtr, index, GfVec3h.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtVec3hArray lhs, VtVec3hArray rhs)
		{
			bool result = VtPINVOKE.VtVec3hArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtVec3hArray lhs, VtVec3hArray rhs)
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

		public static bool operator !=(VtVec3hArray lhs, VtVec3hArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtVec3hArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtVec3hArray_GetHashCode(swigCPtr);
		}
	}
}
