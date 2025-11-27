using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtInt64Array : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public long this[int index]
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

		public VtInt64Array(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtInt64Array_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtInt64Array obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtInt64Array obj)
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
						VtPINVOKE.delete_VtInt64Array(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtInt64Array()
			: this(VtPINVOKE.new_VtInt64Array__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtInt64Array(VtInt64Array other)
			: this(VtPINVOKE.new_VtInt64Array__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtInt64Array(uint n)
			: this(VtPINVOKE.new_VtInt64Array__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtInt64Array(uint n, long value)
			: this(VtPINVOKE.new_VtInt64Array__SWIG_4(n, value), cMemoryOwn: true)
		{
		}

		public VtInt64Array AsConst()
		{
			return new VtInt64Array(VtPINVOKE.VtInt64Array_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(long element)
		{
			VtPINVOKE.VtInt64Array_push_back(swigCPtr, element);
		}

		public void pop_back()
		{
			VtPINVOKE.VtInt64Array_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtInt64Array_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtInt64Array_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtInt64Array_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtInt64Array_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtInt64Array_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtInt64Array_clear(swigCPtr);
		}

		public void assign(uint n, long fill)
		{
			VtPINVOKE.VtInt64Array_assign(swigCPtr, n, fill);
		}

		public void swap(VtInt64Array other)
		{
			VtPINVOKE.VtInt64Array_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtInt64Array other)
		{
			bool result = VtPINVOKE.VtInt64Array_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtInt64Array_ToString(swigCPtr);
		}

		public void CopyToArray(long[] dest)
		{
			VtPINVOKE.VtInt64Array_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(long[] src)
		{
			VtPINVOKE.VtInt64Array_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtInt64Array_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtInt64Array_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected long GetValue(int index)
		{
			return VtPINVOKE.VtInt64Array_GetValue(swigCPtr, index);
		}

		protected void SetValue(int index, long value)
		{
			VtPINVOKE.VtInt64Array_SetValue(swigCPtr, index, value);
		}

		public static bool Equals(VtInt64Array lhs, VtInt64Array rhs)
		{
			bool result = VtPINVOKE.VtInt64Array_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtInt64Array lhs, VtInt64Array rhs)
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

		public static bool operator !=(VtInt64Array lhs, VtInt64Array rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtInt64Array);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtInt64Array_GetHashCode(swigCPtr);
		}
	}
}
