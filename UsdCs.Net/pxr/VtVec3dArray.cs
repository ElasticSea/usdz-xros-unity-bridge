using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtVec3dArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfVec3d this[int index]
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

		public VtVec3dArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtVec3dArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtVec3dArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtVec3dArray obj)
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
						VtPINVOKE.delete_VtVec3dArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtVec3dArray()
			: this(VtPINVOKE.new_VtVec3dArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtVec3dArray(VtVec3dArray other)
			: this(VtPINVOKE.new_VtVec3dArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtVec3dArray(uint n)
			: this(VtPINVOKE.new_VtVec3dArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtVec3dArray(uint n, GfVec3d value)
			: this(VtPINVOKE.new_VtVec3dArray__SWIG_4(n, GfVec3d.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtVec3dArray AsConst()
		{
			return new VtVec3dArray(VtPINVOKE.VtVec3dArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfVec3d element)
		{
			VtPINVOKE.VtVec3dArray_push_back(swigCPtr, GfVec3d.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtVec3dArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtVec3dArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtVec3dArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtVec3dArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtVec3dArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtVec3dArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtVec3dArray_clear(swigCPtr);
		}

		public void assign(uint n, GfVec3d fill)
		{
			VtPINVOKE.VtVec3dArray_assign(swigCPtr, n, GfVec3d.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtVec3dArray other)
		{
			VtPINVOKE.VtVec3dArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtVec3dArray other)
		{
			bool result = VtPINVOKE.VtVec3dArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtVec3dArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfVec3d[] dest)
		{
			VtPINVOKE.VtVec3dArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfVec3d[] src)
		{
			VtPINVOKE.VtVec3dArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtVec3dArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtVec3dArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfVec3d GetValue(int index)
		{
			return new GfVec3d(VtPINVOKE.VtVec3dArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfVec3d value)
		{
			VtPINVOKE.VtVec3dArray_SetValue(swigCPtr, index, GfVec3d.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtVec3dArray lhs, VtVec3dArray rhs)
		{
			bool result = VtPINVOKE.VtVec3dArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtVec3dArray lhs, VtVec3dArray rhs)
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

		public static bool operator !=(VtVec3dArray lhs, VtVec3dArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtVec3dArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtVec3dArray_GetHashCode(swigCPtr);
		}
	}
}
