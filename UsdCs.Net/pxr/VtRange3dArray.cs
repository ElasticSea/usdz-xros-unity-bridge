using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtRange3dArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfRange3d this[int index]
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

		public VtRange3dArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtRange3dArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtRange3dArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtRange3dArray obj)
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
						VtPINVOKE.delete_VtRange3dArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtRange3dArray()
			: this(VtPINVOKE.new_VtRange3dArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtRange3dArray(VtRange3dArray other)
			: this(VtPINVOKE.new_VtRange3dArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtRange3dArray(uint n)
			: this(VtPINVOKE.new_VtRange3dArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtRange3dArray(uint n, GfRange3d value)
			: this(VtPINVOKE.new_VtRange3dArray__SWIG_4(n, GfRange3d.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtRange3dArray AsConst()
		{
			return new VtRange3dArray(VtPINVOKE.VtRange3dArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfRange3d element)
		{
			VtPINVOKE.VtRange3dArray_push_back(swigCPtr, GfRange3d.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtRange3dArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtRange3dArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtRange3dArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtRange3dArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtRange3dArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtRange3dArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtRange3dArray_clear(swigCPtr);
		}

		public void assign(uint n, GfRange3d fill)
		{
			VtPINVOKE.VtRange3dArray_assign(swigCPtr, n, GfRange3d.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtRange3dArray other)
		{
			VtPINVOKE.VtRange3dArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtRange3dArray other)
		{
			bool result = VtPINVOKE.VtRange3dArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtRange3dArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfRange3d[] dest)
		{
			VtPINVOKE.VtRange3dArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfRange3d[] src)
		{
			VtPINVOKE.VtRange3dArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtRange3dArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtRange3dArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfRange3d GetValue(int index)
		{
			return new GfRange3d(VtPINVOKE.VtRange3dArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfRange3d value)
		{
			VtPINVOKE.VtRange3dArray_SetValue(swigCPtr, index, GfRange3d.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtRange3dArray lhs, VtRange3dArray rhs)
		{
			bool result = VtPINVOKE.VtRange3dArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtRange3dArray lhs, VtRange3dArray rhs)
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

		public static bool operator !=(VtRange3dArray lhs, VtRange3dArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtRange3dArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtRange3dArray_GetHashCode(swigCPtr);
		}
	}
}
