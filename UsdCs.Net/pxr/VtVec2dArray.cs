using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtVec2dArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfVec2d this[int index]
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

		public VtVec2dArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtVec2dArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtVec2dArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtVec2dArray obj)
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
						VtPINVOKE.delete_VtVec2dArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtVec2dArray()
			: this(VtPINVOKE.new_VtVec2dArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtVec2dArray(VtVec2dArray other)
			: this(VtPINVOKE.new_VtVec2dArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtVec2dArray(uint n)
			: this(VtPINVOKE.new_VtVec2dArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtVec2dArray(uint n, GfVec2d value)
			: this(VtPINVOKE.new_VtVec2dArray__SWIG_4(n, GfVec2d.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtVec2dArray AsConst()
		{
			return new VtVec2dArray(VtPINVOKE.VtVec2dArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfVec2d element)
		{
			VtPINVOKE.VtVec2dArray_push_back(swigCPtr, GfVec2d.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtVec2dArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtVec2dArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtVec2dArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtVec2dArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtVec2dArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtVec2dArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtVec2dArray_clear(swigCPtr);
		}

		public void assign(uint n, GfVec2d fill)
		{
			VtPINVOKE.VtVec2dArray_assign(swigCPtr, n, GfVec2d.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtVec2dArray other)
		{
			VtPINVOKE.VtVec2dArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtVec2dArray other)
		{
			bool result = VtPINVOKE.VtVec2dArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtVec2dArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfVec2d[] dest)
		{
			VtPINVOKE.VtVec2dArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfVec2d[] src)
		{
			VtPINVOKE.VtVec2dArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtVec2dArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtVec2dArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfVec2d GetValue(int index)
		{
			return new GfVec2d(VtPINVOKE.VtVec2dArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfVec2d value)
		{
			VtPINVOKE.VtVec2dArray_SetValue(swigCPtr, index, GfVec2d.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtVec2dArray lhs, VtVec2dArray rhs)
		{
			bool result = VtPINVOKE.VtVec2dArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtVec2dArray lhs, VtVec2dArray rhs)
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

		public static bool operator !=(VtVec2dArray lhs, VtVec2dArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtVec2dArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtVec2dArray_GetHashCode(swigCPtr);
		}
	}
}
