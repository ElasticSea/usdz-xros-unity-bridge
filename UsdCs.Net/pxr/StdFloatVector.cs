using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class StdFloatVector : IDisposable, IEnumerable, IList<float>, ICollection<float>, IEnumerable<float>
	{
		public sealed class StdFloatVectorEnumerator : IEnumerator, IEnumerator<float>, IDisposable
		{
			private StdFloatVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public float Current
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
					return (float)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public StdFloatVectorEnumerator(StdFloatVector collection)
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

		public float this[int index]
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

		public StdFloatVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(StdFloatVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(StdFloatVector obj)
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

		~StdFloatVector()
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
						StdPINVOKE.delete_StdFloatVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public StdFloatVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (float item in c)
			{
				Add(item);
			}
		}

		public StdFloatVector(IEnumerable<float> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (float item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(float[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(float[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, float[] array, int arrayIndex, int count)
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

		public float[] ToArray()
		{
			float[] array = new float[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<float> IEnumerable<float>.GetEnumerator()
		{
			return new StdFloatVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new StdFloatVectorEnumerator(this);
		}

		public StdFloatVectorEnumerator GetEnumerator()
		{
			return new StdFloatVectorEnumerator(this);
		}

		public void Clear()
		{
			StdPINVOKE.StdFloatVector_Clear(swigCPtr);
		}

		public void Add(float x)
		{
			StdPINVOKE.StdFloatVector_Add(swigCPtr, x);
		}

		private uint size()
		{
			return StdPINVOKE.StdFloatVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return StdPINVOKE.StdFloatVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			StdPINVOKE.StdFloatVector_reserve(swigCPtr, n);
		}

		public StdFloatVector()
			: this(StdPINVOKE.new_StdFloatVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public StdFloatVector(StdFloatVector other)
			: this(StdPINVOKE.new_StdFloatVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public StdFloatVector(int capacity)
			: this(StdPINVOKE.new_StdFloatVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private float getitemcopy(int index)
		{
			float result = StdPINVOKE.StdFloatVector_getitemcopy(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private float getitem(int index)
		{
			float result = StdPINVOKE.StdFloatVector_getitem(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, float val)
		{
			StdPINVOKE.StdFloatVector_setitem(swigCPtr, index, val);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(StdFloatVector values)
		{
			StdPINVOKE.StdFloatVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public StdFloatVector GetRange(int index, int count)
		{
			IntPtr intPtr = StdPINVOKE.StdFloatVector_GetRange(swigCPtr, index, count);
			StdFloatVector result = ((intPtr == IntPtr.Zero) ? null : new StdFloatVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, float x)
		{
			StdPINVOKE.StdFloatVector_Insert(swigCPtr, index, x);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, StdFloatVector values)
		{
			StdPINVOKE.StdFloatVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			StdPINVOKE.StdFloatVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			StdPINVOKE.StdFloatVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static StdFloatVector Repeat(float value, int count)
		{
			IntPtr intPtr = StdPINVOKE.StdFloatVector_Repeat(value, count);
			StdFloatVector result = ((intPtr == IntPtr.Zero) ? null : new StdFloatVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			StdPINVOKE.StdFloatVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			StdPINVOKE.StdFloatVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, StdFloatVector values)
		{
			StdPINVOKE.StdFloatVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool Contains(float value)
		{
			return StdPINVOKE.StdFloatVector_Contains(swigCPtr, value);
		}

		public int IndexOf(float value)
		{
			return StdPINVOKE.StdFloatVector_IndexOf(swigCPtr, value);
		}

		public int LastIndexOf(float value)
		{
			return StdPINVOKE.StdFloatVector_LastIndexOf(swigCPtr, value);
		}

		public bool Remove(float value)
		{
			return StdPINVOKE.StdFloatVector_Remove(swigCPtr, value);
		}
	}
}
