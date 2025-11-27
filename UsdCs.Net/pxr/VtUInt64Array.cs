using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtUInt64Array : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public ulong this[int index]
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

		public VtUInt64Array(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.VtUInt64Array_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtUInt64Array obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtUInt64Array obj)
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
						VtPINVOKE.delete_VtUInt64Array(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public VtUInt64Array()
			: this(VtPINVOKE.new_VtUInt64Array__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtUInt64Array(VtUInt64Array other)
			: this(VtPINVOKE.new_VtUInt64Array__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public VtUInt64Array(uint n)
			: this(VtPINVOKE.new_VtUInt64Array__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public VtUInt64Array(uint n, ulong value)
			: this(VtPINVOKE.new_VtUInt64Array__SWIG_4(n, value), cMemoryOwn: true)
		{
		}

		public VtUInt64Array AsConst()
		{
			return new VtUInt64Array(VtPINVOKE.VtUInt64Array_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(ulong element)
		{
			VtPINVOKE.VtUInt64Array_push_back(swigCPtr, element);
		}

		public void pop_back()
		{
			VtPINVOKE.VtUInt64Array_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.VtUInt64Array_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.VtUInt64Array_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.VtUInt64Array_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.VtUInt64Array_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.VtUInt64Array_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.VtUInt64Array_clear(swigCPtr);
		}

		public void assign(uint n, ulong fill)
		{
			VtPINVOKE.VtUInt64Array_assign(swigCPtr, n, fill);
		}

		public void swap(VtUInt64Array other)
		{
			VtPINVOKE.VtUInt64Array_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(VtUInt64Array other)
		{
			bool result = VtPINVOKE.VtUInt64Array_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.VtUInt64Array_ToString(swigCPtr);
		}

		public void CopyToArray(ulong[] dest)
		{
			VtPINVOKE.VtUInt64Array_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(ulong[] src)
		{
			VtPINVOKE.VtUInt64Array_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.VtUInt64Array_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.VtUInt64Array_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected ulong GetValue(int index)
		{
			return VtPINVOKE.VtUInt64Array_GetValue(swigCPtr, index);
		}

		protected void SetValue(int index, ulong value)
		{
			VtPINVOKE.VtUInt64Array_SetValue(swigCPtr, index, value);
		}

		public static bool Equals(VtUInt64Array lhs, VtUInt64Array rhs)
		{
			bool result = VtPINVOKE.VtUInt64Array_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(VtUInt64Array lhs, VtUInt64Array rhs)
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

		public static bool operator !=(VtUInt64Array lhs, VtUInt64Array rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as VtUInt64Array);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.VtUInt64Array_GetHashCode(swigCPtr);
		}
	}
}
