using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtFloatArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public float this[int index]
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

		public VtFloatArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtFloatArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtFloatArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtFloatArray obj)
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
						VtPINVOKE.delete_VtFloatArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtFloatArray()
			: this(VtPINVOKE.new_VtFloatArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtFloatArray(VtFloatArray other)
			: this(VtPINVOKE.new_VtFloatArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtFloatArray(uint n)
			: this(VtPINVOKE.new_VtFloatArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtFloatArray(uint n, float value)
			: this(VtPINVOKE.new_VtFloatArray__SWIG_4(n, value), cMemoryOwn: true)
		{
		}

		public VtFloatArray AsConst()
		{
			return new VtFloatArray(VtPINVOKE.VtFloatArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(float element)
		{
			VtPINVOKE.VtFloatArray_push_back(swigCPtr, element);
		}

		public void pop_back()
		{
			VtPINVOKE.VtFloatArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtFloatArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtFloatArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtFloatArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtFloatArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtFloatArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtFloatArray_clear(swigCPtr);
		}

		public void assign(uint n, float fill)
		{
			VtPINVOKE.VtFloatArray_assign(swigCPtr, n, fill);
		}

		public void swap(VtFloatArray other)
		{
			VtPINVOKE.VtFloatArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtFloatArray other)
		{
			bool result = VtPINVOKE.VtFloatArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtFloatArray_ToString(swigCPtr);
		}

		public void CopyToArray(float[] dest)
		{
			VtPINVOKE.VtFloatArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(float[] src)
		{
			VtPINVOKE.VtFloatArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtFloatArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtFloatArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected float GetValue(int index)
		{
			return VtPINVOKE.VtFloatArray_GetValue(swigCPtr, index);
		}

		protected void SetValue(int index, float value)
		{
			VtPINVOKE.VtFloatArray_SetValue(swigCPtr, index, value);
		}

		public static bool Equals(VtFloatArray lhs, VtFloatArray rhs)
		{
			bool result = VtPINVOKE.VtFloatArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtFloatArray lhs, VtFloatArray rhs)
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

		public static bool operator !=(VtFloatArray lhs, VtFloatArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtFloatArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtFloatArray_GetHashCode(swigCPtr);
		}
	}
}
