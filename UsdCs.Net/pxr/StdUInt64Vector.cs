using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class StdUInt64Vector : IDisposable, IEnumerable, IList<ulong>, ICollection<ulong>, IEnumerable<ulong>
	{
		public sealed class StdUInt64VectorEnumerator : IEnumerator, IEnumerator<ulong>, IDisposable
		{
			private StdUInt64Vector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public ulong Current
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
					return (ulong)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public StdUInt64VectorEnumerator(StdUInt64Vector collection)
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

		public ulong this[int index]
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

		public StdUInt64Vector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(StdUInt64Vector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(StdUInt64Vector obj)
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

		~StdUInt64Vector()
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
						StdPINVOKE.delete_StdUInt64Vector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public StdUInt64Vector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (ulong item in c)
			{
				Add(item);
			}
		}

		public StdUInt64Vector(IEnumerable<ulong> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (ulong item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(ulong[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(ulong[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, ulong[] array, int arrayIndex, int count)
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

		public ulong[] ToArray()
		{
			ulong[] array = new ulong[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<ulong> IEnumerable<ulong>.GetEnumerator()
		{
			return new StdUInt64VectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new StdUInt64VectorEnumerator(this);
		}

		public StdUInt64VectorEnumerator GetEnumerator()
		{
			return new StdUInt64VectorEnumerator(this);
		}

		public void Clear()
		{
			StdPINVOKE.StdUInt64Vector_Clear(swigCPtr);
		}

		public void Add(ulong x)
		{
			StdPINVOKE.StdUInt64Vector_Add(swigCPtr, x);
		}

		private uint size()
		{
			return StdPINVOKE.StdUInt64Vector_size(swigCPtr);
		}

		private uint capacity()
		{
			return StdPINVOKE.StdUInt64Vector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			StdPINVOKE.StdUInt64Vector_reserve(swigCPtr, n);
		}

		public StdUInt64Vector()
			: this(StdPINVOKE.new_StdUInt64Vector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public StdUInt64Vector(StdUInt64Vector other)
			: this(StdPINVOKE.new_StdUInt64Vector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public StdUInt64Vector(int capacity)
			: this(StdPINVOKE.new_StdUInt64Vector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private ulong getitemcopy(int index)
		{
			ulong result = StdPINVOKE.StdUInt64Vector_getitemcopy(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private ulong getitem(int index)
		{
			ulong result = StdPINVOKE.StdUInt64Vector_getitem(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, ulong val)
		{
			StdPINVOKE.StdUInt64Vector_setitem(swigCPtr, index, val);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(StdUInt64Vector values)
		{
			StdPINVOKE.StdUInt64Vector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public StdUInt64Vector GetRange(int index, int count)
		{
			IntPtr intPtr = StdPINVOKE.StdUInt64Vector_GetRange(swigCPtr, index, count);
			StdUInt64Vector result = ((intPtr == IntPtr.Zero) ? null : new StdUInt64Vector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, ulong x)
		{
			StdPINVOKE.StdUInt64Vector_Insert(swigCPtr, index, x);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, StdUInt64Vector values)
		{
			StdPINVOKE.StdUInt64Vector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			StdPINVOKE.StdUInt64Vector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			StdPINVOKE.StdUInt64Vector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static StdUInt64Vector Repeat(ulong value, int count)
		{
			IntPtr intPtr = StdPINVOKE.StdUInt64Vector_Repeat(value, count);
			StdUInt64Vector result = ((intPtr == IntPtr.Zero) ? null : new StdUInt64Vector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			StdPINVOKE.StdUInt64Vector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			StdPINVOKE.StdUInt64Vector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, StdUInt64Vector values)
		{
			StdPINVOKE.StdUInt64Vector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool Contains(ulong value)
		{
			return StdPINVOKE.StdUInt64Vector_Contains(swigCPtr, value);
		}

		public int IndexOf(ulong value)
		{
			return StdPINVOKE.StdUInt64Vector_IndexOf(swigCPtr, value);
		}

		public int LastIndexOf(ulong value)
		{
			return StdPINVOKE.StdUInt64Vector_LastIndexOf(swigCPtr, value);
		}

		public bool Remove(ulong value)
		{
			return StdPINVOKE.StdUInt64Vector_Remove(swigCPtr, value);
		}
	}
}
