using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdShadeOutputVector : IDisposable, IEnumerable, IEnumerable<UsdShadeOutput>
	{
		public sealed class UsdShadeOutputVectorEnumerator : IEnumerator, IEnumerator<UsdShadeOutput>, IDisposable
		{
			private UsdShadeOutputVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public UsdShadeOutput Current
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
					return (UsdShadeOutput)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public UsdShadeOutputVectorEnumerator(UsdShadeOutputVector collection)
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

		public UsdShadeOutput this[int index]
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

		public UsdShadeOutputVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdShadeOutputVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdShadeOutputVector obj)
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

		~UsdShadeOutputVector()
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
						UsdShadePINVOKE.delete_UsdShadeOutputVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdShadeOutputVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdShadeOutput item in c)
			{
				Add(item);
			}
		}

		public UsdShadeOutputVector(IEnumerable<UsdShadeOutput> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdShadeOutput item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(UsdShadeOutput[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(UsdShadeOutput[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, UsdShadeOutput[] array, int arrayIndex, int count)
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

		public UsdShadeOutput[] ToArray()
		{
			UsdShadeOutput[] array = new UsdShadeOutput[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<UsdShadeOutput> IEnumerable<UsdShadeOutput>.GetEnumerator()
		{
			return new UsdShadeOutputVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new UsdShadeOutputVectorEnumerator(this);
		}

		public UsdShadeOutputVectorEnumerator GetEnumerator()
		{
			return new UsdShadeOutputVectorEnumerator(this);
		}

		public void Clear()
		{
			UsdShadePINVOKE.UsdShadeOutputVector_Clear(swigCPtr);
		}

		public void Add(UsdShadeOutput x)
		{
			UsdShadePINVOKE.UsdShadeOutputVector_Add(swigCPtr, UsdShadeOutput.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return UsdShadePINVOKE.UsdShadeOutputVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return UsdShadePINVOKE.UsdShadeOutputVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			UsdShadePINVOKE.UsdShadeOutputVector_reserve(swigCPtr, n);
		}

		public UsdShadeOutputVector()
			: this(UsdShadePINVOKE.new_UsdShadeOutputVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdShadeOutputVector(UsdShadeOutputVector other)
			: this(UsdShadePINVOKE.new_UsdShadeOutputVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeOutputVector(int capacity)
			: this(UsdShadePINVOKE.new_UsdShadeOutputVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private UsdShadeOutput getitemcopy(int index)
		{
			UsdShadeOutput result = new UsdShadeOutput(UsdShadePINVOKE.UsdShadeOutputVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private UsdShadeOutput getitem(int index)
		{
			UsdShadeOutput result = new UsdShadeOutput(UsdShadePINVOKE.UsdShadeOutputVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, UsdShadeOutput val)
		{
			UsdShadePINVOKE.UsdShadeOutputVector_setitem(swigCPtr, index, UsdShadeOutput.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(UsdShadeOutputVector values)
		{
			UsdShadePINVOKE.UsdShadeOutputVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdShadeOutputVector GetRange(int index, int count)
		{
			IntPtr intPtr = UsdShadePINVOKE.UsdShadeOutputVector_GetRange(swigCPtr, index, count);
			UsdShadeOutputVector result = ((intPtr == IntPtr.Zero) ? null : new UsdShadeOutputVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, UsdShadeOutput x)
		{
			UsdShadePINVOKE.UsdShadeOutputVector_Insert(swigCPtr, index, UsdShadeOutput.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, UsdShadeOutputVector values)
		{
			UsdShadePINVOKE.UsdShadeOutputVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			UsdShadePINVOKE.UsdShadeOutputVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			UsdShadePINVOKE.UsdShadeOutputVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static UsdShadeOutputVector Repeat(UsdShadeOutput value, int count)
		{
			IntPtr intPtr = UsdShadePINVOKE.UsdShadeOutputVector_Repeat(UsdShadeOutput.getCPtr(value), count);
			UsdShadeOutputVector result = ((intPtr == IntPtr.Zero) ? null : new UsdShadeOutputVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			UsdShadePINVOKE.UsdShadeOutputVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			UsdShadePINVOKE.UsdShadeOutputVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, UsdShadeOutputVector values)
		{
			UsdShadePINVOKE.UsdShadeOutputVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
