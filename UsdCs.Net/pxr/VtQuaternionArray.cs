using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtQuaternionArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public GfQuaternion this[int index]
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

		public VtQuaternionArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtQuaternionArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtQuaternionArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtQuaternionArray obj)
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
						VtPINVOKE.delete_VtQuaternionArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtQuaternionArray()
			: this(VtPINVOKE.new_VtQuaternionArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtQuaternionArray(VtQuaternionArray other)
			: this(VtPINVOKE.new_VtQuaternionArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtQuaternionArray(uint n)
			: this(VtPINVOKE.new_VtQuaternionArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtQuaternionArray(uint n, GfQuaternion value)
			: this(VtPINVOKE.new_VtQuaternionArray__SWIG_4(n, GfQuaternion.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtQuaternionArray AsConst()
		{
			return new VtQuaternionArray(VtPINVOKE.VtQuaternionArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(GfQuaternion element)
		{
			VtPINVOKE.VtQuaternionArray_push_back(swigCPtr, GfQuaternion.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtQuaternionArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtQuaternionArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtQuaternionArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtQuaternionArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtQuaternionArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtQuaternionArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtQuaternionArray_clear(swigCPtr);
		}

		public void assign(uint n, GfQuaternion fill)
		{
			VtPINVOKE.VtQuaternionArray_assign(swigCPtr, n, GfQuaternion.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtQuaternionArray other)
		{
			VtPINVOKE.VtQuaternionArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtQuaternionArray other)
		{
			bool result = VtPINVOKE.VtQuaternionArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtQuaternionArray_ToString(swigCPtr);
		}

		public void CopyToArray(GfQuaternion[] dest)
		{
			VtPINVOKE.VtQuaternionArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(GfQuaternion[] src)
		{
			VtPINVOKE.VtQuaternionArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtQuaternionArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtQuaternionArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected GfQuaternion GetValue(int index)
		{
			return new GfQuaternion(VtPINVOKE.VtQuaternionArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, GfQuaternion value)
		{
			VtPINVOKE.VtQuaternionArray_SetValue(swigCPtr, index, GfQuaternion.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtQuaternionArray lhs, VtQuaternionArray rhs)
		{
			bool result = VtPINVOKE.VtQuaternionArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtQuaternionArray lhs, VtQuaternionArray rhs)
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

		public static bool operator !=(VtQuaternionArray lhs, VtQuaternionArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtQuaternionArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtQuaternionArray_GetHashCode(swigCPtr);
		}
	}
}
