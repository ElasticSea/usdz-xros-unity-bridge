using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdStageLoadRulesVectorPair : IDisposable, IEnumerable, IEnumerable<UsdStageLoadRulesPair>
	{
		public sealed class UsdStageLoadRulesVectorPairEnumerator : IEnumerator, IEnumerator<UsdStageLoadRulesPair>, IDisposable
		{
			private UsdStageLoadRulesVectorPair collectionRef;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public UsdStageLoadRulesPair Current
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
					return (UsdStageLoadRulesPair)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public UsdStageLoadRulesVectorPairEnumerator(UsdStageLoadRulesVectorPair collection)
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

		public UsdStageLoadRulesPair this[int index]
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

		public UsdStageLoadRulesVectorPair(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdStageLoadRulesVectorPair obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdStageLoadRulesVectorPair obj)
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

		~UsdStageLoadRulesVectorPair()
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
						UsdPINVOKE.delete_UsdStageLoadRulesVectorPair(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public UsdStageLoadRulesVectorPair(IEnumerable c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdStageLoadRulesPair item in c)
			{
				Add(item);
			}
		}

		public UsdStageLoadRulesVectorPair(IEnumerable<UsdStageLoadRulesPair> c)
			: this()
		{
			if (c == null)
			{
				throw new ArgumentNullException("c");
			}
			foreach (UsdStageLoadRulesPair item in c)
			{
				Add(item);
			}
		}

		public void CopyTo(UsdStageLoadRulesPair[] array)
		{
			CopyTo(0, array, 0, Count);
		}

		public void CopyTo(UsdStageLoadRulesPair[] array, int arrayIndex)
		{
			CopyTo(0, array, arrayIndex, Count);
		}

		public void CopyTo(int index, UsdStageLoadRulesPair[] array, int arrayIndex, int count)
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

		public UsdStageLoadRulesPair[] ToArray()
		{
			UsdStageLoadRulesPair[] array = new UsdStageLoadRulesPair[Count];
			CopyTo(array);
			return array;
		}

		IEnumerator<UsdStageLoadRulesPair> IEnumerable<UsdStageLoadRulesPair>.GetEnumerator()
		{
			return new UsdStageLoadRulesVectorPairEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new UsdStageLoadRulesVectorPairEnumerator(this);
		}

		public UsdStageLoadRulesVectorPairEnumerator GetEnumerator()
		{
			return new UsdStageLoadRulesVectorPairEnumerator(this);
		}

		public void Clear()
		{
			UsdPINVOKE.UsdStageLoadRulesVectorPair_Clear(swigCPtr);
		}

		public void Add(UsdStageLoadRulesPair x)
		{
			UsdPINVOKE.UsdStageLoadRulesVectorPair_Add(swigCPtr, UsdStageLoadRulesPair.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return UsdPINVOKE.UsdStageLoadRulesVectorPair_size(swigCPtr);
		}

		private uint capacity()
		{
			return UsdPINVOKE.UsdStageLoadRulesVectorPair_capacity(swigCPtr);
		}

		private void reserve(uint n)
		{
			UsdPINVOKE.UsdStageLoadRulesVectorPair_reserve(swigCPtr, n);
		}

		public UsdStageLoadRulesVectorPair()
			: this(UsdPINVOKE.new_UsdStageLoadRulesVectorPair__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdStageLoadRulesVectorPair(UsdStageLoadRulesVectorPair other)
			: this(UsdPINVOKE.new_UsdStageLoadRulesVectorPair__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdStageLoadRulesVectorPair(int capacity)
			: this(UsdPINVOKE.new_UsdStageLoadRulesVectorPair__SWIG_2(capacity), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private UsdStageLoadRulesPair getitemcopy(int index)
		{
			UsdStageLoadRulesPair result = new UsdStageLoadRulesPair(UsdPINVOKE.UsdStageLoadRulesVectorPair_getitemcopy(swigCPtr, index), cMemoryOwn: true);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private UsdStageLoadRulesPair getitem(int index)
		{
			UsdStageLoadRulesPair result = new UsdStageLoadRulesPair(UsdPINVOKE.UsdStageLoadRulesVectorPair_getitem(swigCPtr, index), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(int index, UsdStageLoadRulesPair val)
		{
			UsdPINVOKE.UsdStageLoadRulesVectorPair_setitem(swigCPtr, index, UsdStageLoadRulesPair.getCPtr(val));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void AddRange(UsdStageLoadRulesVectorPair values)
		{
			UsdPINVOKE.UsdStageLoadRulesVectorPair_AddRange(swigCPtr, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public UsdStageLoadRulesVectorPair GetRange(int index, int count)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStageLoadRulesVectorPair_GetRange(swigCPtr, index, count);
			UsdStageLoadRulesVectorPair result = ((intPtr == IntPtr.Zero) ? null : new UsdStageLoadRulesVectorPair(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Insert(int index, UsdStageLoadRulesPair x)
		{
			UsdPINVOKE.UsdStageLoadRulesVectorPair_Insert(swigCPtr, index, UsdStageLoadRulesPair.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void InsertRange(int index, UsdStageLoadRulesVectorPair values)
		{
			UsdPINVOKE.UsdStageLoadRulesVectorPair_InsertRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveAt(int index)
		{
			UsdPINVOKE.UsdStageLoadRulesVectorPair_RemoveAt(swigCPtr, index);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void RemoveRange(int index, int count)
		{
			UsdPINVOKE.UsdStageLoadRulesVectorPair_RemoveRange(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public static UsdStageLoadRulesVectorPair Repeat(UsdStageLoadRulesPair value, int count)
		{
			IntPtr intPtr = UsdPINVOKE.UsdStageLoadRulesVectorPair_Repeat(UsdStageLoadRulesPair.getCPtr(value), count);
			UsdStageLoadRulesVectorPair result = ((intPtr == IntPtr.Zero) ? null : new UsdStageLoadRulesVectorPair(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Reverse()
		{
			UsdPINVOKE.UsdStageLoadRulesVectorPair_Reverse__SWIG_0(swigCPtr);
		}

		public void Reverse(int index, int count)
		{
			UsdPINVOKE.UsdStageLoadRulesVectorPair_Reverse__SWIG_1(swigCPtr, index, count);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public void SetRange(int index, UsdStageLoadRulesVectorPair values)
		{
			UsdPINVOKE.UsdStageLoadRulesVectorPair_SetRange(swigCPtr, index, getCPtr(values));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}
	}
}
