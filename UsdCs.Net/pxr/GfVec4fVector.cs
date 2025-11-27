using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class GfVec4fVector : IDisposable, IEnumerable, IEnumerable<GfVec4f>
	{
		public sealed class GfVec4fVectorEnumerator : IEnumerator, IEnumerator<GfVec4f>, IDisposable
		{
			private GfVec4fVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public GfVec4f Current
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
					return (GfVec4f)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public GfVec4fVectorEnumerator(GfVec4fVector collection)
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

		public GfVec4f this[int index]
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

		public GfVec4fVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(GfVec4fVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(GfVec4fVector obj)
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

		~GfVec4fVector()
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
						GfPINVOKE.delete_GfVec4fVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public GfVec4fVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (GfVec4f item in c)
			{
				Add(item);
			}
		}

		public GfVec4fVector(IEnumerable<GfVec4f> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (GfVec4f item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(GfVec4f[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(GfVec4f[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, GfVec4f[] array, int arrayIndex, int count)
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

		public GfVec4f[] ToArray()
		{
			GfVec4f[] array = new GfVec4f[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<GfVec4f> IEnumerable<GfVec4f>.GetEnumerator()
		{
			return new GfVec4fVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new GfVec4fVectorEnumerator(this);
		}

		public GfVec4fVectorEnumerator GetEnumerator()
		{
			return new GfVec4fVectorEnumerator(this);
		}

		public void Clear()
		{
			GfPINVOKE.GfVec4fVector_Clear(swigCPtr);
		}

		public void Add(GfVec4f x)
		{
			GfPINVOKE.GfVec4fVector_Add(swigCPtr, GfVec4f.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return GfPINVOKE.GfVec4fVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return GfPINVOKE.GfVec4fVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			GfPINVOKE.GfVec4fVector_reserve(swigCPtr, n);
		}

		public GfVec4fVector()
			: this(GfPINVOKE.new_GfVec4fVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public GfVec4fVector(GfVec4fVector other)
			: this(GfPINVOKE.new_GfVec4fVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec4fVector(int capacity)
			: this(GfPINVOKE.new_GfVec4fVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private GfVec4f getitemcopy(int index)
		{
			GfVec4f result = new GfVec4f(GfPINVOKE.GfVec4fVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private GfVec4f getitem(int index)
		{
			GfVec4f result = new GfVec4f(GfPINVOKE.GfVec4fVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, GfVec4f val)
		{
			GfPINVOKE.GfVec4fVector_setitem(swigCPtr, index, GfVec4f.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(GfVec4fVector values)
		{
			GfPINVOKE.GfVec4fVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public GfVec4fVector GetRange(int index, int count)
		{
			IntPtr intPtr = GfPINVOKE.GfVec4fVector_GetRange(swigCPtr, index, count);
			GfVec4fVector result = ((intPtr == IntPtr.Zero) ? null : new GfVec4fVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, GfVec4f x)
		{
			GfPINVOKE.GfVec4fVector_Insert(swigCPtr, index, GfVec4f.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, GfVec4fVector values)
		{
			GfPINVOKE.GfVec4fVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			GfPINVOKE.GfVec4fVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			GfPINVOKE.GfVec4fVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static GfVec4fVector Repeat(GfVec4f value, int count)
		{
			IntPtr intPtr = GfPINVOKE.GfVec4fVector_Repeat(GfVec4f.getCPtr(value), count);
			GfVec4fVector result = ((intPtr == IntPtr.Zero) ? null : new GfVec4fVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			GfPINVOKE.GfVec4fVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			GfPINVOKE.GfVec4fVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, GfVec4fVector values)
		{
			GfPINVOKE.GfVec4fVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
