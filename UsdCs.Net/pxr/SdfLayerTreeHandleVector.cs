using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfLayerTreeHandleVector : IDisposable, IEnumerable, IEnumerable<SdfLayerTree>
	{
		public sealed class SdfLayerTreeHandleVectorEnumerator : IEnumerator, IEnumerator<SdfLayerTree>, IDisposable
		{
			private SdfLayerTreeHandleVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SdfLayerTree Current
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
					return (SdfLayerTree)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public SdfLayerTreeHandleVectorEnumerator(SdfLayerTreeHandleVector collection)
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

		public SdfLayerTree this[int index]
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

		public SdfLayerTreeHandleVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfLayerTreeHandleVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfLayerTreeHandleVector obj)
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

		~SdfLayerTreeHandleVector()
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
						SdfPINVOKE.delete_SdfLayerTreeHandleVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public SdfLayerTreeHandleVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfLayerTree item in c)
			{
				Add(item);
			}
		}

		public SdfLayerTreeHandleVector(IEnumerable<SdfLayerTree> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (SdfLayerTree item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(SdfLayerTree[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(SdfLayerTree[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, SdfLayerTree[] array, int arrayIndex, int count)
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

		public SdfLayerTree[] ToArray()
		{
			SdfLayerTree[] array = new SdfLayerTree[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<SdfLayerTree> IEnumerable<SdfLayerTree>.GetEnumerator()
		{
			return new SdfLayerTreeHandleVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfLayerTreeHandleVectorEnumerator(this);
		}

		public SdfLayerTreeHandleVectorEnumerator GetEnumerator()
		{
			return new SdfLayerTreeHandleVectorEnumerator(this);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfLayerTreeHandleVector_Clear(swigCPtr);
		}

		public void Add(SdfLayerTree x)
		{
			SdfPINVOKE.SdfLayerTreeHandleVector_Add(swigCPtr, SdfLayerTree.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfLayerTreeHandleVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return SdfPINVOKE.SdfLayerTreeHandleVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			SdfPINVOKE.SdfLayerTreeHandleVector_reserve(swigCPtr, n);
		}

		public SdfLayerTreeHandleVector()
			: this(SdfPINVOKE.new_SdfLayerTreeHandleVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfLayerTreeHandleVector(SdfLayerTreeHandleVector other)
			: this(SdfPINVOKE.new_SdfLayerTreeHandleVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfLayerTreeHandleVector(int capacity)
			: this(SdfPINVOKE.new_SdfLayerTreeHandleVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private SdfLayerTree getitemcopy(int index)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerTreeHandleVector_getitemcopy(swigCPtr, index);
			SdfLayerTree result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerTree(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfLayerTree getitem(int index)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerTreeHandleVector_getitem(swigCPtr, index);
			SdfLayerTree result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerTree(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, SdfLayerTree val)
		{
			SdfPINVOKE.SdfLayerTreeHandleVector_setitem(swigCPtr, index, SdfLayerTree.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(SdfLayerTreeHandleVector values)
		{
			SdfPINVOKE.SdfLayerTreeHandleVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public SdfLayerTreeHandleVector GetRange(int index, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerTreeHandleVector_GetRange(swigCPtr, index, count);
			SdfLayerTreeHandleVector result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerTreeHandleVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, SdfLayerTree x)
		{
			SdfPINVOKE.SdfLayerTreeHandleVector_Insert(swigCPtr, index, SdfLayerTree.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, SdfLayerTreeHandleVector values)
		{
			SdfPINVOKE.SdfLayerTreeHandleVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			SdfPINVOKE.SdfLayerTreeHandleVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			SdfPINVOKE.SdfLayerTreeHandleVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static SdfLayerTreeHandleVector Repeat(SdfLayerTree value, int count)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerTreeHandleVector_Repeat(SdfLayerTree.getCPtr(value), count);
			SdfLayerTreeHandleVector result = ((intPtr == IntPtr.Zero) ? null : new SdfLayerTreeHandleVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			SdfPINVOKE.SdfLayerTreeHandleVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			SdfPINVOKE.SdfLayerTreeHandleVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, SdfLayerTreeHandleVector values)
		{
			SdfPINVOKE.SdfLayerTreeHandleVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
