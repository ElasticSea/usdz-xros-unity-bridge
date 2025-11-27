using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtStringArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public string this[int index]
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

		public VtStringArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtStringArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtStringArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtStringArray obj)
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
						VtPINVOKE.delete_VtStringArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtStringArray()
			: this(VtPINVOKE.new_VtStringArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtStringArray(VtStringArray other)
			: this(VtPINVOKE.new_VtStringArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtStringArray(uint n)
			: this(VtPINVOKE.new_VtStringArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtStringArray(uint n, string value)
			: this(VtPINVOKE.new_VtStringArray__SWIG_4(n, value), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtStringArray AsConst()
		{
			return new VtStringArray(VtPINVOKE.VtStringArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(string element)
		{
			VtPINVOKE.VtStringArray_push_back(swigCPtr, element);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.VtStringArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtStringArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtStringArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtStringArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtStringArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtStringArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtStringArray_clear(swigCPtr);
		}

		public void assign(uint n, string fill)
		{
			VtPINVOKE.VtStringArray_assign(swigCPtr, n, fill);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(VtStringArray other)
		{
			VtPINVOKE.VtStringArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtStringArray other)
		{
			bool result = VtPINVOKE.VtStringArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtStringArray_ToString(swigCPtr);
		}

		public void CopyToArray(string[] dest)
		{
			VtPINVOKE.VtStringArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(string[] src)
		{
			VtPINVOKE.VtStringArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtStringArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtStringArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected string GetValue(int index)
		{
			return VtPINVOKE.VtStringArray_GetValue(swigCPtr, index);
		}

		protected void SetValue(int index, string value)
		{
			VtPINVOKE.VtStringArray_SetValue(swigCPtr, index, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(VtStringArray lhs, VtStringArray rhs)
		{
			bool result = VtPINVOKE.VtStringArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtStringArray lhs, VtStringArray rhs)
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

		public static bool operator !=(VtStringArray lhs, VtStringArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtStringArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtStringArray_GetHashCode(swigCPtr);
		}
	}
}
