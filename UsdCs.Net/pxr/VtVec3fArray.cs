using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtVec3fArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfVec3f this[int index]
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

		public VtVec3fArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtVec3fArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtVec3fArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtVec3fArray obj)
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
						VtPINVOKE.delete_VtVec3fArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtVec3fArray()
			: this(VtPINVOKE.new_VtVec3fArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtVec3fArray(VtVec3fArray other)
			: this(VtPINVOKE.new_VtVec3fArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtVec3fArray(uint n)
			: this(VtPINVOKE.new_VtVec3fArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtVec3fArray(uint n, GfVec3f value)
			: this(VtPINVOKE.new_VtVec3fArray__SWIG_4(n, GfVec3f.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtVec3fArray AsConst()
		{
			return new VtVec3fArray(VtPINVOKE.VtVec3fArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfVec3f element)
		{
			VtPINVOKE.VtVec3fArray_push_back(swigCPtr, GfVec3f.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtVec3fArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtVec3fArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtVec3fArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtVec3fArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtVec3fArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtVec3fArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtVec3fArray_clear(swigCPtr);
		}

		public void assign(uint n, GfVec3f fill)
		{
			VtPINVOKE.VtVec3fArray_assign(swigCPtr, n, GfVec3f.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtVec3fArray other)
		{
			VtPINVOKE.VtVec3fArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtVec3fArray other)
		{
			bool result = VtPINVOKE.VtVec3fArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtVec3fArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfVec3f[] dest)
		{
			VtPINVOKE.VtVec3fArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfVec3f[] src)
		{
			VtPINVOKE.VtVec3fArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtVec3fArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtVec3fArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfVec3f GetValue(int index)
		{
			return new GfVec3f(VtPINVOKE.VtVec3fArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfVec3f value)
		{
			VtPINVOKE.VtVec3fArray_SetValue(swigCPtr, index, GfVec3f.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtVec3fArray lhs, VtVec3fArray rhs)
		{
			bool result = VtPINVOKE.VtVec3fArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtVec3fArray lhs, VtVec3fArray rhs)
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

		public static bool operator !=(VtVec3fArray lhs, VtVec3fArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtVec3fArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtVec3fArray_GetHashCode(swigCPtr);
		}
	}
}
