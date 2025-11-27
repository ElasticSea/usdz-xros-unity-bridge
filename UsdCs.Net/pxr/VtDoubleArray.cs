using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtDoubleArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public double this[int index]
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

		public VtDoubleArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtDoubleArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtDoubleArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtDoubleArray obj)
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
						VtPINVOKE.delete_VtDoubleArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtDoubleArray()
			: this(VtPINVOKE.new_VtDoubleArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtDoubleArray(VtDoubleArray other)
			: this(VtPINVOKE.new_VtDoubleArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtDoubleArray(uint n)
			: this(VtPINVOKE.new_VtDoubleArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtDoubleArray(uint n, double value)
			: this(VtPINVOKE.new_VtDoubleArray__SWIG_4(n, value), cMemoryOwn: true)
		{
		}

		public VtDoubleArray AsConst()
		{
			return new VtDoubleArray(VtPINVOKE.VtDoubleArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(double element)
		{
			VtPINVOKE.VtDoubleArray_push_back(swigCPtr, element);
		}

		public void pop_back()
		{
			VtPINVOKE.VtDoubleArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtDoubleArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtDoubleArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtDoubleArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtDoubleArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtDoubleArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtDoubleArray_clear(swigCPtr);
		}

		public void assign(uint n, double fill)
		{
			VtPINVOKE.VtDoubleArray_assign(swigCPtr, n, fill);
		}

		public void swap(VtDoubleArray other)
		{
			VtPINVOKE.VtDoubleArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtDoubleArray other)
		{
			bool result = VtPINVOKE.VtDoubleArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtDoubleArray_ToString(swigCPtr);
		}

		public void CopyToArray(double[] dest)
		{
			VtPINVOKE.VtDoubleArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(double[] src)
		{
			VtPINVOKE.VtDoubleArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtDoubleArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtDoubleArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected double GetValue(int index)
		{
			return VtPINVOKE.VtDoubleArray_GetValue(swigCPtr, index);
		}

		protected void SetValue(int index, double value)
		{
			VtPINVOKE.VtDoubleArray_SetValue(swigCPtr, index, value);
		}

		public static bool Equals(VtDoubleArray lhs, VtDoubleArray rhs)
		{
			bool result = VtPINVOKE.VtDoubleArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtDoubleArray lhs, VtDoubleArray rhs)
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

		public static bool operator !=(VtDoubleArray lhs, VtDoubleArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtDoubleArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtDoubleArray_GetHashCode(swigCPtr);
		}
	}
}
