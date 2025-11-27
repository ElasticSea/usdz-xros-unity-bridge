using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdSkel_AnimQueryImplConstRefPtrVector : IDisposable, IEnumerable, IEnumerable<SWIGTYPE_p_UsdSkel_AnimQueryImpl>
	{
		public sealed class UsdSkel_AnimQueryImplConstRefPtrVectorEnumerator : IEnumerator, IEnumerator<SWIGTYPE_p_UsdSkel_AnimQueryImpl>, IDisposable
		{
			private UsdSkel_AnimQueryImplConstRefPtrVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SWIGTYPE_p_UsdSkel_AnimQueryImpl Current
			{
				get
				{
					if (currentIndex == -1)
					{
						throw new InvalidOperationException("Enumeration not started.");
					}
					if (currentIndex > currentSize - 1)
					{
						throw new InvalidOperationException("Enumeration finished.");
					}
					if (currentObject == null)
					{
						throw new InvalidOperationException("Collection modified.");
					}
					return (SWIGTYPE_p_UsdSkel_AnimQueryImpl)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public UsdSkel_AnimQueryImplConstRefPtrVectorEnumerator(UsdSkel_AnimQueryImplConstRefPtrVector collection)
			{
				collectionRef = collection;
				currentIndex = -1;
				currentObject = null;
				currentSize = collectionRef.Count;
			}

			public bool MoveNext()
			{
				int count = collectionRef.Count;
				bool flag = currentIndex + 1 < count && count == currentSize;
				if (flag)
				{
					currentIndex++;
					currentObject = collectionRef[currentIndex];
				}
				else
				{
					currentObject = null;
				}
				return flag;
			}

			public void Reset()
			{
				currentIndex = -1;
				currentObject = null;
				if (collectionRef.Count != currentSize)
				{
					throw new InvalidOperationException("Collection modified.");
				}
			}

			public void Dispose()
			{
				currentIndex = -1;
				currentObject = null;
			}
		}

		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public bool IsFixedSize => false;

		public bool IsReadOnly => false;

		public SWIGTYPE_p_UsdSkel_AnimQueryImpl this[int index]
		{
			get
			{
				return getitem(index);
			}
			set
			{
				setitem(index, value);
			}
		}

		public int Capacity
		{
			get
			{
				return (int)capacity();
			}
			set
			{
				if (value < 0 || (uint)value < size())
				{
					throw new ArgumentOutOfRangeException("Capacity");
				}
				reserve((uint)value);
			}
		}

		public int Count => (int)size();

		public bool IsSynchronized => false;

		public UsdSkel_AnimQueryImplConstRefPtrVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdSkel_AnimQueryImplConstRefPtrVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdSkel_AnimQueryImplConstRefPtrVector obj)
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

		~UsdSkel_AnimQueryImplConstRefPtrVector()
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
						UsdSkelPINVOKE.delete_UsdSkel_AnimQueryImplConstRefPtrVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdSkel_AnimQueryImplConstRefPtrVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SWIGTYPE_p_UsdSkel_AnimQueryImpl item in c)
			{
				Add(item);
			}
		}

		public UsdSkel_AnimQueryImplConstRefPtrVector(IEnumerable<SWIGTYPE_p_UsdSkel_AnimQueryImpl> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SWIGTYPE_p_UsdSkel_AnimQueryImpl item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SWIGTYPE_p_UsdSkel_AnimQueryImpl[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SWIGTYPE_p_UsdSkel_AnimQueryImpl[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SWIGTYPE_p_UsdSkel_AnimQueryImpl[] array, int arrayIndex, int count)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index", "Value is less than zero");
			}
			if (arrayIndex < 0)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count", "Value is less than zero");
			}
			if (array.Rank > 1)
			{
				throw new ArgumentException("Multi dimensional array.", "array");
			}
			if (index + count > Count || arrayIndex + count > array.Length)
			{
				throw new ArgumentException("Number of elements to copy is too large.");
			}
			for (int i = 0; i < count; i++)
			{
				array.SetValue(getitemcopy(index + i), arrayIndex + i);
			}
		}

		public SWIGTYPE_p_UsdSkel_AnimQueryImpl[] ToArray()
		{
			SWIGTYPE_p_UsdSkel_AnimQueryImpl[] array = new SWIGTYPE_p_UsdSkel_AnimQueryImpl[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SWIGTYPE_p_UsdSkel_AnimQueryImpl> IEnumerable<SWIGTYPE_p_UsdSkel_AnimQueryImpl>.GetEnumerator()
		{
			return new UsdSkel_AnimQueryImplConstRefPtrVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new UsdSkel_AnimQueryImplConstRefPtrVectorEnumerator(this);
		}

		public UsdSkel_AnimQueryImplConstRefPtrVectorEnumerator GetEnumerator()
		{
			return new UsdSkel_AnimQueryImplConstRefPtrVectorEnumerator(this);
		}

		public void Clear()
		{
			UsdSkelPINVOKE.UsdSkel_AnimQueryImplConstRefPtrVector_Clear(swigCPtr);
		}

		public void Add(SWIGTYPE_p_UsdSkel_AnimQueryImpl x)
		{
			UsdSkelPINVOKE.UsdSkel_AnimQueryImplConstRefPtrVector_Add(swigCPtr, SWIGTYPE_p_UsdSkel_AnimQueryImpl.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return UsdSkelPINVOKE.UsdSkel_AnimQueryImplConstRefPtrVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return UsdSkelPINVOKE.UsdSkel_AnimQueryImplConstRefPtrVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			UsdSkelPINVOKE.UsdSkel_AnimQueryImplConstRefPtrVector_reserve(swigCPtr, n);
		}

		public UsdSkel_AnimQueryImplConstRefPtrVector()
			: this(UsdSkelPINVOKE.new_UsdSkel_AnimQueryImplConstRefPtrVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdSkel_AnimQueryImplConstRefPtrVector(UsdSkel_AnimQueryImplConstRefPtrVector other)
			: this(UsdSkelPINVOKE.new_UsdSkel_AnimQueryImplConstRefPtrVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdSkel_AnimQueryImplConstRefPtrVector(int capacity)
			: this(UsdSkelPINVOKE.new_UsdSkel_AnimQueryImplConstRefPtrVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SWIGTYPE_p_UsdSkel_AnimQueryImpl getitemcopy(int index)
		{
			IntPtr intPtr = UsdSkelPINVOKE.UsdSkel_AnimQueryImplConstRefPtrVector_getitemcopy(swigCPtr, index);
			SWIGTYPE_p_UsdSkel_AnimQueryImpl result = ((intPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_UsdSkel_AnimQueryImpl(intPtr, futureUse: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SWIGTYPE_p_UsdSkel_AnimQueryImpl getitem(int index)
		{
			IntPtr intPtr = UsdSkelPINVOKE.UsdSkel_AnimQueryImplConstRefPtrVector_getitem(swigCPtr, index);
			SWIGTYPE_p_UsdSkel_AnimQueryImpl result = ((intPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_UsdSkel_AnimQueryImpl(intPtr, futureUse: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SWIGTYPE_p_UsdSkel_AnimQueryImpl val)
		{
			UsdSkelPINVOKE.UsdSkel_AnimQueryImplConstRefPtrVector_setitem(swigCPtr, index, SWIGTYPE_p_UsdSkel_AnimQueryImpl.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(UsdSkel_AnimQueryImplConstRefPtrVector values)
		{
			UsdSkelPINVOKE.UsdSkel_AnimQueryImplConstRefPtrVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdSkel_AnimQueryImplConstRefPtrVector GetRange(int index, int count)
		{
			IntPtr intPtr = UsdSkelPINVOKE.UsdSkel_AnimQueryImplConstRefPtrVector_GetRange(swigCPtr, index, count);
			UsdSkel_AnimQueryImplConstRefPtrVector result = ((intPtr == IntPtr.Zero) ? null : new UsdSkel_AnimQueryImplConstRefPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SWIGTYPE_p_UsdSkel_AnimQueryImpl x)
		{
			UsdSkelPINVOKE.UsdSkel_AnimQueryImplConstRefPtrVector_Insert(swigCPtr, index, SWIGTYPE_p_UsdSkel_AnimQueryImpl.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, UsdSkel_AnimQueryImplConstRefPtrVector values)
		{
			UsdSkelPINVOKE.UsdSkel_AnimQueryImplConstRefPtrVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			UsdSkelPINVOKE.UsdSkel_AnimQueryImplConstRefPtrVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			UsdSkelPINVOKE.UsdSkel_AnimQueryImplConstRefPtrVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static UsdSkel_AnimQueryImplConstRefPtrVector Repeat(SWIGTYPE_p_UsdSkel_AnimQueryImpl value, int count)
		{
			IntPtr intPtr = UsdSkelPINVOKE.UsdSkel_AnimQueryImplConstRefPtrVector_Repeat(SWIGTYPE_p_UsdSkel_AnimQueryImpl.getCPtr(value), count);
			UsdSkel_AnimQueryImplConstRefPtrVector result = ((intPtr == IntPtr.Zero) ? null : new UsdSkel_AnimQueryImplConstRefPtrVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			UsdSkelPINVOKE.UsdSkel_AnimQueryImplConstRefPtrVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			UsdSkelPINVOKE.UsdSkel_AnimQueryImplConstRefPtrVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, UsdSkel_AnimQueryImplConstRefPtrVector values)
		{
			UsdSkelPINVOKE.UsdSkel_AnimQueryImplConstRefPtrVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
