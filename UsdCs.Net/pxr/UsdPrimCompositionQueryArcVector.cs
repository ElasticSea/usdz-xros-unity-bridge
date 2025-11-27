using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdPrimCompositionQueryArcVector : IDisposable, IEnumerable, IEnumerable<UsdPrimCompositionQueryArc>
	{
		public sealed class UsdPrimCompositionQueryArcVectorEnumerator : IEnumerator, IEnumerator<UsdPrimCompositionQueryArc>, IDisposable
		{
			private UsdPrimCompositionQueryArcVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public UsdPrimCompositionQueryArc Current
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
					return (UsdPrimCompositionQueryArc)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public UsdPrimCompositionQueryArcVectorEnumerator(UsdPrimCompositionQueryArcVector collection)
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

		public UsdPrimCompositionQueryArc this[int index]
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

		public UsdPrimCompositionQueryArcVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdPrimCompositionQueryArcVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdPrimCompositionQueryArcVector obj)
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

		~UsdPrimCompositionQueryArcVector()
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
						UsdPINVOKE.delete_UsdPrimCompositionQueryArcVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdPrimCompositionQueryArcVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdPrimCompositionQueryArc item in c)
			{
				Add(item);
			}
		}

		public UsdPrimCompositionQueryArcVector(IEnumerable<UsdPrimCompositionQueryArc> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdPrimCompositionQueryArc item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(UsdPrimCompositionQueryArc[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(UsdPrimCompositionQueryArc[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, UsdPrimCompositionQueryArc[] array, int arrayIndex, int count)
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

		public UsdPrimCompositionQueryArc[] ToArray()
		{
			UsdPrimCompositionQueryArc[] array = new UsdPrimCompositionQueryArc[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<UsdPrimCompositionQueryArc> IEnumerable<UsdPrimCompositionQueryArc>.GetEnumerator()
		{
			return new UsdPrimCompositionQueryArcVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new UsdPrimCompositionQueryArcVectorEnumerator(this);
		}

		public UsdPrimCompositionQueryArcVectorEnumerator GetEnumerator()
		{
			return new UsdPrimCompositionQueryArcVectorEnumerator(this);
		}

		public void Clear()
		{
			UsdPINVOKE.UsdPrimCompositionQueryArcVector_Clear(swigCPtr);
		}

		public void Add(UsdPrimCompositionQueryArc x)
		{
			UsdPINVOKE.UsdPrimCompositionQueryArcVector_Add(swigCPtr, UsdPrimCompositionQueryArc.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return UsdPINVOKE.UsdPrimCompositionQueryArcVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return UsdPINVOKE.UsdPrimCompositionQueryArcVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			UsdPINVOKE.UsdPrimCompositionQueryArcVector_reserve(swigCPtr, n);
		}

		public UsdPrimCompositionQueryArcVector()
			: this(UsdPINVOKE.new_UsdPrimCompositionQueryArcVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdPrimCompositionQueryArcVector(UsdPrimCompositionQueryArcVector other)
			: this(UsdPINVOKE.new_UsdPrimCompositionQueryArcVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdPrimCompositionQueryArcVector(int capacity)
			: this(UsdPINVOKE.new_UsdPrimCompositionQueryArcVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private UsdPrimCompositionQueryArc getitemcopy(int index)
		{
			UsdPrimCompositionQueryArc result = new UsdPrimCompositionQueryArc(UsdPINVOKE.UsdPrimCompositionQueryArcVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private UsdPrimCompositionQueryArc getitem(int index)
		{
			UsdPrimCompositionQueryArc result = new UsdPrimCompositionQueryArc(UsdPINVOKE.UsdPrimCompositionQueryArcVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, UsdPrimCompositionQueryArc val)
		{
			UsdPINVOKE.UsdPrimCompositionQueryArcVector_setitem(swigCPtr, index, UsdPrimCompositionQueryArc.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(UsdPrimCompositionQueryArcVector values)
		{
			UsdPINVOKE.UsdPrimCompositionQueryArcVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdPrimCompositionQueryArcVector GetRange(int index, int count)
		{
			IntPtr intPtr = UsdPINVOKE.UsdPrimCompositionQueryArcVector_GetRange(swigCPtr, index, count);
			UsdPrimCompositionQueryArcVector result = ((intPtr == IntPtr.Zero) ? null : new UsdPrimCompositionQueryArcVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, UsdPrimCompositionQueryArc x)
		{
			UsdPINVOKE.UsdPrimCompositionQueryArcVector_Insert(swigCPtr, index, UsdPrimCompositionQueryArc.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, UsdPrimCompositionQueryArcVector values)
		{
			UsdPINVOKE.UsdPrimCompositionQueryArcVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			UsdPINVOKE.UsdPrimCompositionQueryArcVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			UsdPINVOKE.UsdPrimCompositionQueryArcVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static UsdPrimCompositionQueryArcVector Repeat(UsdPrimCompositionQueryArc value, int count)
		{
			IntPtr intPtr = UsdPINVOKE.UsdPrimCompositionQueryArcVector_Repeat(UsdPrimCompositionQueryArc.getCPtr(value), count);
			UsdPrimCompositionQueryArcVector result = ((intPtr == IntPtr.Zero) ? null : new UsdPrimCompositionQueryArcVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			UsdPINVOKE.UsdPrimCompositionQueryArcVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			UsdPINVOKE.UsdPrimCompositionQueryArcVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, UsdPrimCompositionQueryArcVector values)
		{
			UsdPINVOKE.UsdPrimCompositionQueryArcVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
