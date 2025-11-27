using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtMatrix3dArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfMatrix3d this[int index]
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

		public VtMatrix3dArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtMatrix3dArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtMatrix3dArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtMatrix3dArray obj)
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
						VtPINVOKE.delete_VtMatrix3dArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtMatrix3dArray()
			: this(VtPINVOKE.new_VtMatrix3dArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtMatrix3dArray(VtMatrix3dArray other)
			: this(VtPINVOKE.new_VtMatrix3dArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtMatrix3dArray(uint n)
			: this(VtPINVOKE.new_VtMatrix3dArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtMatrix3dArray(uint n, GfMatrix3d value)
			: this(VtPINVOKE.new_VtMatrix3dArray__SWIG_4(n, GfMatrix3d.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtMatrix3dArray AsConst()
		{
			return new VtMatrix3dArray(VtPINVOKE.VtMatrix3dArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfMatrix3d element)
		{
			VtPINVOKE.VtMatrix3dArray_push_back(swigCPtr, GfMatrix3d.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtMatrix3dArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtMatrix3dArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtMatrix3dArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtMatrix3dArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtMatrix3dArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtMatrix3dArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtMatrix3dArray_clear(swigCPtr);
		}

		public void assign(uint n, GfMatrix3d fill)
		{
			VtPINVOKE.VtMatrix3dArray_assign(swigCPtr, n, GfMatrix3d.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtMatrix3dArray other)
		{
			VtPINVOKE.VtMatrix3dArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtMatrix3dArray other)
		{
			bool result = VtPINVOKE.VtMatrix3dArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtMatrix3dArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfMatrix3d[] dest)
		{
			VtPINVOKE.VtMatrix3dArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfMatrix3d[] src)
		{
			VtPINVOKE.VtMatrix3dArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtMatrix3dArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtMatrix3dArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfMatrix3d GetValue(int index)
		{
			return new GfMatrix3d(VtPINVOKE.VtMatrix3dArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfMatrix3d value)
		{
			VtPINVOKE.VtMatrix3dArray_SetValue(swigCPtr, index, GfMatrix3d.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtMatrix3dArray lhs, VtMatrix3dArray rhs)
		{
			bool result = VtPINVOKE.VtMatrix3dArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtMatrix3dArray lhs, VtMatrix3dArray rhs)
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

		public static bool operator !=(VtMatrix3dArray lhs, VtMatrix3dArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtMatrix3dArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtMatrix3dArray_GetHashCode(swigCPtr);
		}
	}
}
