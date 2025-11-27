using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdRelationshipVector : IDisposable, IEnumerable, IEnumerable<UsdRelationship>
	{
		public sealed class UsdRelationshipVectorEnumerator : IEnumerator, IEnumerator<UsdRelationship>, IDisposable
		{
			private UsdRelationshipVector collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public UsdRelationship Current
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
					return (UsdRelationship)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public UsdRelationshipVectorEnumerator(UsdRelationshipVector collection)
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

		public UsdRelationship this[int index]
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

		public UsdRelationshipVector(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdRelationshipVector obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdRelationshipVector obj)
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

		~UsdRelationshipVector()
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
						UsdPINVOKE.delete_UsdRelationshipVector(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdRelationshipVector(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdRelationship item in c)
			{
				Add(item);
			}
		}

		public UsdRelationshipVector(IEnumerable<UsdRelationship> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdRelationship item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(UsdRelationship[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(UsdRelationship[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, UsdRelationship[] array, int arrayIndex, int count)
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

		public UsdRelationship[] ToArray()
		{
			UsdRelationship[] array = new UsdRelationship[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<UsdRelationship> IEnumerable<UsdRelationship>.GetEnumerator()
		{
			return new UsdRelationshipVectorEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new UsdRelationshipVectorEnumerator(this);
		}

		public UsdRelationshipVectorEnumerator GetEnumerator()
		{
			return new UsdRelationshipVectorEnumerator(this);
		}

		public void Clear()
		{
			UsdPINVOKE.UsdRelationshipVector_Clear(swigCPtr);
		}

		public void Add(UsdRelationship x)
		{
			UsdPINVOKE.UsdRelationshipVector_Add(swigCPtr, UsdRelationship.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return UsdPINVOKE.UsdRelationshipVector_size(swigCPtr);
		}

		private uint capacity()
		{
			return UsdPINVOKE.UsdRelationshipVector_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			UsdPINVOKE.UsdRelationshipVector_reserve(swigCPtr, n);
		}

		public UsdRelationshipVector()
			: this(UsdPINVOKE.new_UsdRelationshipVector__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdRelationshipVector(UsdRelationshipVector other)
			: this(UsdPINVOKE.new_UsdRelationshipVector__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdRelationshipVector(int capacity)
			: this(UsdPINVOKE.new_UsdRelationshipVector__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private UsdRelationship getitemcopy(int index)
		{
			UsdRelationship result = new UsdRelationship(UsdPINVOKE.UsdRelationshipVector_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private UsdRelationship getitem(int index)
		{
			UsdRelationship result = new UsdRelationship(UsdPINVOKE.UsdRelationshipVector_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, UsdRelationship val)
		{
			UsdPINVOKE.UsdRelationshipVector_setitem(swigCPtr, index, UsdRelationship.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(UsdRelationshipVector values)
		{
			UsdPINVOKE.UsdRelationshipVector_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdRelationshipVector GetRange(int index, int count)
		{
			IntPtr intPtr = UsdPINVOKE.UsdRelationshipVector_GetRange(swigCPtr, index, count);
			UsdRelationshipVector result = ((intPtr == IntPtr.Zero) ? null : new UsdRelationshipVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, UsdRelationship x)
		{
			UsdPINVOKE.UsdRelationshipVector_Insert(swigCPtr, index, UsdRelationship.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, UsdRelationshipVector values)
		{
			UsdPINVOKE.UsdRelationshipVector_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			UsdPINVOKE.UsdRelationshipVector_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			UsdPINVOKE.UsdRelationshipVector_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static UsdRelationshipVector Repeat(UsdRelationship value, int count)
		{
			IntPtr intPtr = UsdPINVOKE.UsdRelationshipVector_Repeat(UsdRelationship.getCPtr(value), count);
			UsdRelationshipVector result = ((intPtr == IntPtr.Zero) ? null : new UsdRelationshipVector(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			UsdPINVOKE.UsdRelationshipVector_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			UsdPINVOKE.UsdRelationshipVector_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, UsdRelationshipVector values)
		{
			UsdPINVOKE.UsdRelationshipVector_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
