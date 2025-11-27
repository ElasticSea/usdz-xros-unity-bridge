using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtVec2iArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfVec2i this[int index]
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

		public VtVec2iArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtVec2iArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtVec2iArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtVec2iArray obj)
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
						VtPINVOKE.delete_VtVec2iArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtVec2iArray()
			: this(VtPINVOKE.new_VtVec2iArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtVec2iArray(VtVec2iArray other)
			: this(VtPINVOKE.new_VtVec2iArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtVec2iArray(uint n)
			: this(VtPINVOKE.new_VtVec2iArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtVec2iArray(uint n, GfVec2i value)
			: this(VtPINVOKE.new_VtVec2iArray__SWIG_4(n, GfVec2i.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtVec2iArray AsConst()
		{
			return new VtVec2iArray(VtPINVOKE.VtVec2iArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfVec2i element)
		{
			VtPINVOKE.VtVec2iArray_push_back(swigCPtr, GfVec2i.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtVec2iArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtVec2iArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtVec2iArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtVec2iArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtVec2iArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtVec2iArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtVec2iArray_clear(swigCPtr);
		}

		public void assign(uint n, GfVec2i fill)
		{
			VtPINVOKE.VtVec2iArray_assign(swigCPtr, n, GfVec2i.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtVec2iArray other)
		{
			VtPINVOKE.VtVec2iArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtVec2iArray other)
		{
			bool result = VtPINVOKE.VtVec2iArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtVec2iArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfVec2i[] dest)
		{
			VtPINVOKE.VtVec2iArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfVec2i[] src)
		{
			VtPINVOKE.VtVec2iArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtVec2iArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtVec2iArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfVec2i GetValue(int index)
		{
			return new GfVec2i(VtPINVOKE.VtVec2iArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfVec2i value)
		{
			VtPINVOKE.VtVec2iArray_SetValue(swigCPtr, index, GfVec2i.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtVec2iArray lhs, VtVec2iArray rhs)
		{
			bool result = VtPINVOKE.VtVec2iArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtVec2iArray lhs, VtVec2iArray rhs)
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

		public static bool operator !=(VtVec2iArray lhs, VtVec2iArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtVec2iArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtVec2iArray_GetHashCode(swigCPtr);
		}
	}
}
