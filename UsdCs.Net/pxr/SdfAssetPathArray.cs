using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfAssetPathArray : Vt_ArrayBase
	{
		private HandleRef swigCPtr;

		public SdfAssetPath this[int index]
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

		public SdfAssetPathArray(IntPtr cPtr, bool cMemoryOwn)
			: base(VtPINVOKE.SdfAssetPathArray_SWIGUpcast(cPtr), cMemoryOwn)
		{
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfAssetPathArray obj)
		{
			if (!(obj == null))
			{
				return obj.swigCPtr;
			}
			return new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfAssetPathArray obj)
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
						VtPINVOKE.delete_SdfAssetPathArray(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
				base.Dispose(disposing);
			}
		}

		public SdfAssetPathArray()
			: this(VtPINVOKE.new_SdfAssetPathArray__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfAssetPathArray(SdfAssetPathArray other)
			: this(VtPINVOKE.new_SdfAssetPathArray__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfAssetPathArray(uint n)
			: this(VtPINVOKE.new_SdfAssetPathArray__SWIG_3(n), cMemoryOwn: true)
		{
		}

		public SdfAssetPathArray(uint n, SdfAssetPath value)
			: this(VtPINVOKE.new_SdfAssetPathArray__SWIG_4(n, SdfAssetPath.getCPtr(value)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfAssetPathArray AsConst()
		{
			return new SdfAssetPathArray(VtPINVOKE.SdfAssetPathArray_AsConst(swigCPtr), cMemoryOwn: false);
		}

		public void push_back(SdfAssetPath element)
		{
			VtPINVOKE.SdfAssetPathArray_push_back(swigCPtr, SdfAssetPath.getCPtr(element));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void pop_back()
		{
			VtPINVOKE.SdfAssetPathArray_pop_back(swigCPtr);
		}

		public uint size()
		{
			return VtPINVOKE.SdfAssetPathArray_size(swigCPtr);
		}

		public uint capacity()
		{
			return VtPINVOKE.SdfAssetPathArray_capacity(swigCPtr);
		}

		public bool empty()
		{
			return VtPINVOKE.SdfAssetPathArray_empty(swigCPtr);
		}

		public void reserve(uint num)
		{
			VtPINVOKE.SdfAssetPathArray_reserve(swigCPtr, num);
		}

		public void resize(uint newSize)
		{
			VtPINVOKE.SdfAssetPathArray_resize(swigCPtr, newSize);
		}

		public void clear()
		{
			VtPINVOKE.SdfAssetPathArray_clear(swigCPtr);
		}

		public void assign(uint n, SdfAssetPath fill)
		{
			VtPINVOKE.SdfAssetPathArray_assign(swigCPtr, n, SdfAssetPath.getCPtr(fill));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void swap(SdfAssetPathArray other)
		{
			VtPINVOKE.SdfAssetPathArray_swap(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool IsIdentical(SdfAssetPathArray other)
		{
			bool result = VtPINVOKE.SdfAssetPathArray_IsIdentical(swigCPtr, getCPtr(other));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public override string ToString()
		{
			return VtPINVOKE.SdfAssetPathArray_ToString(swigCPtr);
		}

		public void CopyToArray(SdfAssetPath[] dest)
		{
			VtPINVOKE.SdfAssetPathArray_CopyToArray__SWIG_0(swigCPtr, dest);
		}

		public void CopyFromArray(SdfAssetPath[] src)
		{
			VtPINVOKE.SdfAssetPathArray_CopyFromArray__SWIG_0(swigCPtr, src);
		}

		public void CopyToArray(IntPtr dest)
		{
			VtPINVOKE.SdfAssetPathArray_CopyToArray__SWIG_1(swigCPtr, dest);
		}

		public void CopyFromArray(IntPtr src)
		{
			VtPINVOKE.SdfAssetPathArray_CopyFromArray__SWIG_1(swigCPtr, src);
		}

		protected SdfAssetPath GetValue(int index)
		{
			return new SdfAssetPath(VtPINVOKE.SdfAssetPathArray_GetValue(swigCPtr, index), cMemoryOwn: false);
		}

		protected void SetValue(int index, SdfAssetPath value)
		{
			VtPINVOKE.SdfAssetPathArray_SetValue(swigCPtr, index, SdfAssetPath.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static bool Equals(SdfAssetPathArray lhs, SdfAssetPathArray rhs)
		{
			bool result = VtPINVOKE.SdfAssetPathArray_Equals(getCPtr(lhs), getCPtr(rhs));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static bool operator ==(SdfAssetPathArray lhs, SdfAssetPathArray rhs)
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

		public static bool operator !=(SdfAssetPathArray lhs, SdfAssetPathArray rhs)
		{
			return !(lhs == rhs);
		}

		public override bool Equals(object rhs)
		{
			return Equals(this, rhs as SdfAssetPathArray);
		}

		public override int GetHashCode()
		{
			return VtPINVOKE.SdfAssetPathArray_GetHashCode(swigCPtr);
		}
	}
}
