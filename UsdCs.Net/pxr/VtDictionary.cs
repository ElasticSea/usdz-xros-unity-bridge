using System;
using System.Runtime.InteropServices;

namespace pxr
{
	public class VtDictionary : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public VtDictionary(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(VtDictionary obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(VtDictionary obj)
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

		~VtDictionary()
		{
			Dispose(disposing: false);
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			lock (this)
			{
				if (swigCPtr.Handle != IntPtr.Zero)
				{
					if (swigCMemOwn)
					{
						swigCMemOwn = false;
						VtPINVOKE.delete_VtDictionary(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public VtDictionary()
			: this(VtPINVOKE.new_VtDictionary__SWIG_0(), cMemoryOwn: true)
		{
		}

		public VtDictionary(int size)
			: this(VtPINVOKE.new_VtDictionary__SWIG_1(size), cMemoryOwn: true)
		{
		}

		public VtDictionary(VtDictionary other)
			: this(VtPINVOKE.new_VtDictionary__SWIG_3(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SWIGTYPE_p_std__mapT_std__string_VtValue_std__lessT_t_t__size_type count(string key)
		{
			SWIGTYPE_p_std__mapT_std__string_VtValue_std__lessT_t_t__size_type result = new SWIGTYPE_p_std__mapT_std__string_VtValue_std__lessT_t_t__size_type(VtPINVOKE.VtDictionary_count__SWIG_0(swigCPtr, key), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_std__mapT_std__string_VtValue_std__lessT_t_t__size_type erase(string key)
		{
			SWIGTYPE_p_std__mapT_std__string_VtValue_std__lessT_t_t__size_type result = new SWIGTYPE_p_std__mapT_std__string_VtValue_std__lessT_t_t__size_type(VtPINVOKE.VtDictionary_erase__SWIG_0(swigCPtr, key), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void erase(SWIGTYPE_p_VtDictionary__IteratorT_std__mapT_std__string_VtValue_std__lessT_t_t_p_std__mapT_std__string_VtValue_std__lessT_t_t__iterator_t it)
		{
			VtPINVOKE.VtDictionary_erase__SWIG_1(swigCPtr, SWIGTYPE_p_VtDictionary__IteratorT_std__mapT_std__string_VtValue_std__lessT_t_t_p_std__mapT_std__string_VtValue_std__lessT_t_t__iterator_t.getCPtr(it));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void erase(SWIGTYPE_p_VtDictionary__IteratorT_std__mapT_std__string_VtValue_std__lessT_t_t_p_std__mapT_std__string_VtValue_std__lessT_t_t__iterator_t f, SWIGTYPE_p_VtDictionary__IteratorT_std__mapT_std__string_VtValue_std__lessT_t_t_p_std__mapT_std__string_VtValue_std__lessT_t_t__iterator_t l)
		{
			VtPINVOKE.VtDictionary_erase__SWIG_2(swigCPtr, SWIGTYPE_p_VtDictionary__IteratorT_std__mapT_std__string_VtValue_std__lessT_t_t_p_std__mapT_std__string_VtValue_std__lessT_t_t__iterator_t.getCPtr(f), SWIGTYPE_p_VtDictionary__IteratorT_std__mapT_std__string_VtValue_std__lessT_t_t_p_std__mapT_std__string_VtValue_std__lessT_t_t__iterator_t.getCPtr(l));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void clear()
		{
			VtPINVOKE.VtDictionary_clear(swigCPtr);
		}

		public SWIGTYPE_p_VtDictionary__IteratorT_std__mapT_std__string_VtValue_std__lessT_t_t_p_std__mapT_std__string_VtValue_std__lessT_t_t__iterator_t find(string key)
		{
			SWIGTYPE_p_VtDictionary__IteratorT_std__mapT_std__string_VtValue_std__lessT_t_t_p_std__mapT_std__string_VtValue_std__lessT_t_t__iterator_t result = new SWIGTYPE_p_VtDictionary__IteratorT_std__mapT_std__string_VtValue_std__lessT_t_t_p_std__mapT_std__string_VtValue_std__lessT_t_t__iterator_t(VtPINVOKE.VtDictionary_find__SWIG_0(swigCPtr, key), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public SWIGTYPE_p_VtDictionary__IteratorT_std__mapT_std__string_VtValue_std__lessT_t_t_p_std__mapT_std__string_VtValue_std__lessT_t_t__iterator_t begin()
		{
			return new SWIGTYPE_p_VtDictionary__IteratorT_std__mapT_std__string_VtValue_std__lessT_t_t_p_std__mapT_std__string_VtValue_std__lessT_t_t__iterator_t(VtPINVOKE.VtDictionary_begin__SWIG_0(swigCPtr), futureUse: true);
		}

		public SWIGTYPE_p_VtDictionary__IteratorT_std__mapT_std__string_VtValue_std__lessT_t_t_p_std__mapT_std__string_VtValue_std__lessT_t_t__iterator_t end()
		{
			return new SWIGTYPE_p_VtDictionary__IteratorT_std__mapT_std__string_VtValue_std__lessT_t_t_p_std__mapT_std__string_VtValue_std__lessT_t_t__iterator_t(VtPINVOKE.VtDictionary_end__SWIG_0(swigCPtr), futureUse: true);
		}

		public SWIGTYPE_p_std__mapT_std__string_VtValue_std__lessT_t_t__size_type size()
		{
			return new SWIGTYPE_p_std__mapT_std__string_VtValue_std__lessT_t_t__size_type(VtPINVOKE.VtDictionary_size(swigCPtr), futureUse: true);
		}

		public bool empty()
		{
			return VtPINVOKE.VtDictionary_empty(swigCPtr);
		}

		public void swap(VtDictionary dict)
		{
			VtPINVOKE.VtDictionary_swap(swigCPtr, getCPtr(dict));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SWIGTYPE_p_std__pairT_VtDictionary__IteratorT_std__mapT_std__string_VtValue_std__lessT_t_t_p_std__mapT_std__string_VtValue_std__lessT_t_t__iterator_t_bool_t insert(SWIGTYPE_p_std__mapT_std__string_VtValue_std__lessT_t_t__value_type obj)
		{
			SWIGTYPE_p_std__pairT_VtDictionary__IteratorT_std__mapT_std__string_VtValue_std__lessT_t_t_p_std__mapT_std__string_VtValue_std__lessT_t_t__iterator_t_bool_t result = new SWIGTYPE_p_std__pairT_VtDictionary__IteratorT_std__mapT_std__string_VtValue_std__lessT_t_t_p_std__mapT_std__string_VtValue_std__lessT_t_t__iterator_t_bool_t(VtPINVOKE.VtDictionary_insert(swigCPtr, SWIGTYPE_p_std__mapT_std__string_VtValue_std__lessT_t_t__value_type.getCPtr(obj)), futureUse: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetValueAtPath(string keyPath, string delimiters)
		{
			IntPtr intPtr = VtPINVOKE.VtDictionary_GetValueAtPath__SWIG_0(swigCPtr, keyPath, delimiters);
			VtValue result = ((intPtr == IntPtr.Zero) ? null : new VtValue(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetValueAtPath(string keyPath)
		{
			IntPtr intPtr = VtPINVOKE.VtDictionary_GetValueAtPath__SWIG_1(swigCPtr, keyPath);
			VtValue result = ((intPtr == IntPtr.Zero) ? null : new VtValue(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public VtValue GetValueAtPath(StdStringVector keyPath)
		{
			IntPtr intPtr = VtPINVOKE.VtDictionary_GetValueAtPath__SWIG_2(swigCPtr, StdStringVector.getCPtr(keyPath));
			VtValue result = ((intPtr == IntPtr.Zero) ? null : new VtValue(intPtr, cMemoryOwn: false));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void SetValueAtPath(string keyPath, VtValue value, string delimiters)
		{
			VtPINVOKE.VtDictionary_SetValueAtPath__SWIG_0(swigCPtr, keyPath, VtValue.getCPtr(value), delimiters);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetValueAtPath(string keyPath, VtValue value)
		{
			VtPINVOKE.VtDictionary_SetValueAtPath__SWIG_1(swigCPtr, keyPath, VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetValueAtPath(StdStringVector keyPath, VtValue value)
		{
			VtPINVOKE.VtDictionary_SetValueAtPath__SWIG_2(swigCPtr, StdStringVector.getCPtr(keyPath), VtValue.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void EraseValueAtPath(string keyPath, string delimiters)
		{
			VtPINVOKE.VtDictionary_EraseValueAtPath__SWIG_0(swigCPtr, keyPath, delimiters);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void EraseValueAtPath(string keyPath)
		{
			VtPINVOKE.VtDictionary_EraseValueAtPath__SWIG_1(swigCPtr, keyPath);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void EraseValueAtPath(StdStringVector keyPath)
		{
			VtPINVOKE.VtDictionary_EraseValueAtPath__SWIG_2(swigCPtr, StdStringVector.getCPtr(keyPath));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
