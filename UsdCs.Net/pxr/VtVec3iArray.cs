using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtVec3iArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfVec3i this[int index]
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

		public VtVec3iArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtVec3iArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtVec3iArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtVec3iArray obj)
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
						VtPINVOKE.delete_VtVec3iArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtVec3iArray()
			: this(VtPINVOKE.new_VtVec3iArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtVec3iArray(VtVec3iArray other)
			: this(VtPINVOKE.new_VtVec3iArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtVec3iArray(uint n)
			: this(VtPINVOKE.new_VtVec3iArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtVec3iArray(uint n, GfVec3i value)
			: this(VtPINVOKE.new_VtVec3iArray__SWIG_4(n, GfVec3i.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtVec3iArray AsConst()
		{
			return new VtVec3iArray(VtPINVOKE.VtVec3iArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfVec3i element)
		{
			VtPINVOKE.VtVec3iArray_push_back(swigCPtr, GfVec3i.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtVec3iArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtVec3iArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtVec3iArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtVec3iArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtVec3iArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtVec3iArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtVec3iArray_clear(swigCPtr);
		}

		public void assign(uint n, GfVec3i fill)
		{
			VtPINVOKE.VtVec3iArray_assign(swigCPtr, n, GfVec3i.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtVec3iArray other)
		{
			VtPINVOKE.VtVec3iArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtVec3iArray other)
		{
			bool result = VtPINVOKE.VtVec3iArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtVec3iArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfVec3i[] dest)
		{
			VtPINVOKE.VtVec3iArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfVec3i[] src)
		{
			VtPINVOKE.VtVec3iArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtVec3iArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtVec3iArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfVec3i GetValue(int index)
		{
			return new GfVec3i(VtPINVOKE.VtVec3iArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfVec3i value)
		{
			VtPINVOKE.VtVec3iArray_SetValue(swigCPtr, index, GfVec3i.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtVec3iArray lhs, VtVec3iArray rhs)
		{
			bool result = VtPINVOKE.VtVec3iArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtVec3iArray lhs, VtVec3iArray rhs)
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

		public static bool operator !=(VtVec3iArray lhs, VtVec3iArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtVec3iArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtVec3iArray_GetHashCode(swigCPtr);
		}
	}
}
