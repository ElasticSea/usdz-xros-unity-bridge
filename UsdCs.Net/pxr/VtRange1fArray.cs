using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtRange1fArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfRange1f this[int index]
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

		public VtRange1fArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtRange1fArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtRange1fArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtRange1fArray obj)
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
						VtPINVOKE.delete_VtRange1fArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtRange1fArray()
			: this(VtPINVOKE.new_VtRange1fArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtRange1fArray(VtRange1fArray other)
			: this(VtPINVOKE.new_VtRange1fArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtRange1fArray(uint n)
			: this(VtPINVOKE.new_VtRange1fArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtRange1fArray(uint n, GfRange1f value)
			: this(VtPINVOKE.new_VtRange1fArray__SWIG_4(n, GfRange1f.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtRange1fArray AsConst()
		{
			return new VtRange1fArray(VtPINVOKE.VtRange1fArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfRange1f element)
		{
			VtPINVOKE.VtRange1fArray_push_back(swigCPtr, GfRange1f.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtRange1fArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtRange1fArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtRange1fArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtRange1fArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtRange1fArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtRange1fArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtRange1fArray_clear(swigCPtr);
		}

		public void assign(uint n, GfRange1f fill)
		{
			VtPINVOKE.VtRange1fArray_assign(swigCPtr, n, GfRange1f.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtRange1fArray other)
		{
			VtPINVOKE.VtRange1fArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtRange1fArray other)
		{
			bool result = VtPINVOKE.VtRange1fArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtRange1fArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfRange1f[] dest)
		{
			VtPINVOKE.VtRange1fArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfRange1f[] src)
		{
			VtPINVOKE.VtRange1fArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtRange1fArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtRange1fArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfRange1f GetValue(int index)
		{
			return new GfRange1f(VtPINVOKE.VtRange1fArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfRange1f value)
		{
			VtPINVOKE.VtRange1fArray_SetValue(swigCPtr, index, GfRange1f.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtRange1fArray lhs, VtRange1fArray rhs)
		{
			bool result = VtPINVOKE.VtRange1fArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtRange1fArray lhs, VtRange1fArray rhs)
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

		public static bool operator !=(VtRange1fArray lhs, VtRange1fArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtRange1fArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtRange1fArray_GetHashCode(swigCPtr);
		}
	}
}
