using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdGeomPrimvarVector : IDisposable, IEnumerable, IEnumerable<UsdGeomPrimvar>
	{
		public sealed class UsdGeomPrimvarVectorEnumerator : IEnumerator, IEnumerator<UsdGeomPrimvar>, IDisposable
		{
			private UsdGeomPrimvarVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public UsdGeomPrimvar Current
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
					return (UsdGeomPrimvar)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public UsdGeomPrimvarVectorEnumerator(UsdGeomPrimvarVector collection)
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

		public UsdGeomPrimvar this[int index]
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

		public UsdGeomPrimvarVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdGeomPrimvarVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdGeomPrimvarVector obj)
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

		~UsdGeomPrimvarVector()
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
						UsdGeomPINVOKE.delete_UsdGeomPrimvarVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdGeomPrimvarVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdGeomPrimvar item in c)
			{
				Add(item);
			}
		}

		public UsdGeomPrimvarVector(IEnumerable<UsdGeomPrimvar> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdGeomPrimvar item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(UsdGeomPrimvar[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(UsdGeomPrimvar[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, UsdGeomPrimvar[] array, int arrayIndex, int count)
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

		public UsdGeomPrimvar[] ToArray()
		{
			UsdGeomPrimvar[] array = new UsdGeomPrimvar[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<UsdGeomPrimvar> IEnumerable<UsdGeomPrimvar>.GetEnumerator()
		{
			return new UsdGeomPrimvarVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new UsdGeomPrimvarVectorEnumerator(this);
		}

		public UsdGeomPrimvarVectorEnumerator GetEnumerator()
		{
			return new UsdGeomPrimvarVectorEnumerator(this);
		}

		public void Clear()
		{
			UsdGeomPINVOKE.UsdGeomPrimvarVector_Clear(swigCPtr);
		}

		public void Add(UsdGeomPrimvar x)
		{
			UsdGeomPINVOKE.UsdGeomPrimvarVector_Add(swigCPtr, UsdGeomPrimvar.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return UsdGeomPINVOKE.UsdGeomPrimvarVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return UsdGeomPINVOKE.UsdGeomPrimvarVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			UsdGeomPINVOKE.UsdGeomPrimvarVector_reserve(swigCPtr, n);
		}

		public UsdGeomPrimvarVector()
			: this(UsdGeomPINVOKE.new_UsdGeomPrimvarVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdGeomPrimvarVector(UsdGeomPrimvarVector other)
			: this(UsdGeomPINVOKE.new_UsdGeomPrimvarVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomPrimvarVector(int capacity)
			: this(UsdGeomPINVOKE.new_UsdGeomPrimvarVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private UsdGeomPrimvar getitemcopy(int index)
		{
			UsdGeomPrimvar result = new UsdGeomPrimvar(UsdGeomPINVOKE.UsdGeomPrimvarVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private UsdGeomPrimvar getitem(int index)
		{
			UsdGeomPrimvar result = new UsdGeomPrimvar(UsdGeomPINVOKE.UsdGeomPrimvarVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, UsdGeomPrimvar val)
		{
			UsdGeomPINVOKE.UsdGeomPrimvarVector_setitem(swigCPtr, index, UsdGeomPrimvar.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(UsdGeomPrimvarVector values)
		{
			UsdGeomPINVOKE.UsdGeomPrimvarVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdGeomPrimvarVector GetRange(int index, int count)
		{
			IntPtr intPtr = UsdGeomPINVOKE.UsdGeomPrimvarVector_GetRange(swigCPtr, index, count);
			UsdGeomPrimvarVector result = ((intPtr == IntPtr.Zero) ? null : new UsdGeomPrimvarVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, UsdGeomPrimvar x)
		{
			UsdGeomPINVOKE.UsdGeomPrimvarVector_Insert(swigCPtr, index, UsdGeomPrimvar.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, UsdGeomPrimvarVector values)
		{
			UsdGeomPINVOKE.UsdGeomPrimvarVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			UsdGeomPINVOKE.UsdGeomPrimvarVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			UsdGeomPINVOKE.UsdGeomPrimvarVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static UsdGeomPrimvarVector Repeat(UsdGeomPrimvar value, int count)
		{
			IntPtr intPtr = UsdGeomPINVOKE.UsdGeomPrimvarVector_Repeat(UsdGeomPrimvar.getCPtr(value), count);
			UsdGeomPrimvarVector result = ((intPtr == IntPtr.Zero) ? null : new UsdGeomPrimvarVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			UsdGeomPINVOKE.UsdGeomPrimvarVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			UsdGeomPINVOKE.UsdGeomPrimvarVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, UsdGeomPrimvarVector values)
		{
			UsdGeomPINVOKE.UsdGeomPrimvarVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
