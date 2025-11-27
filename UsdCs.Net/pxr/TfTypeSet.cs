using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class TfTypeSet : IDisposable, ISet<TfType>, ICollection<TfType>, IEnumerable<TfType>, IEnumerable
	{
		public sealed class TfTypeSetEnumerator : IEnumerator, IEnumerator<TfType>, IDisposable
		{
			private TfTypeSet collectionRef;

			private IList<TfType> ItemsCollection;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public TfType Current
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
					return (TfType)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public TfTypeSetEnumerator(TfTypeSet collection)
			{
				collectionRef = collection;
				ItemsCollection = new List<TfType>(collection.Items);
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
					currentObject = ItemsCollection[currentIndex];
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

		public int Count => (int)size();

		public bool IsReadOnly => false;

		private ICollection<TfType> Items
		{
			get
			{
				ICollection<TfType> collection = new List<TfType>();
				int count = Count;
				if (count > 0)
				{
					IntPtr swigiterator = create_iterator_begin();
					for (int i = 0; i < count; i++)
					{
						collection.Add(get_next(swigiterator));
					}
					destroy_iterator(swigiterator);
				}
				return collection;
			}
		}

		public TfTypeSet(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(TfTypeSet obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(TfTypeSet obj)
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

		~TfTypeSet()
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
						TfPINVOKE.delete_TfTypeSet(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		void ICollection<TfType>.Add(TfType item)
		{
			((ISet<TfType>)this).Add(item);
		}

		public bool TryGetValue(TfType equalValue, out TfType actualValue)
		{
			try
			{
				actualValue = getitem(equalValue);
				return true;
			}
			catch
			{
				actualValue = null;
				return false;
			}
		}

		public void CopyTo(TfType[] array)
		{
			CopyTo(array, 0);
		}

		public void CopyTo(TfType[] array, int arrayIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (arrayIndex < 0)
			{
				throw new ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
			}
			if (array.Rank > 1)
			{
				throw new ArgumentException("Multi dimensional array.", "array");
			}
			if (arrayIndex + Count > array.Length)
			{
				throw new ArgumentException("Number of elements to copy is too large.");
			}
			using TfTypeSetEnumerator tfTypeSetEnumerator = GetEnumerator();
			while (tfTypeSetEnumerator.MoveNext())
			{
				TfType current = tfTypeSetEnumerator.Current;
				array.SetValue(current, arrayIndex++);
			}
		}

		public void ExceptWith(IEnumerable<TfType> other)
		{
			foreach (TfType item in other)
			{
				Remove(item);
			}
		}

		public void IntersectWith(IEnumerable<TfType> other)
		{
			TfTypeSet tfTypeSet = new TfTypeSet(this);
			Clear();
			foreach (TfType item in other)
			{
				if (tfTypeSet.Contains(item))
				{
					Add(item);
				}
			}
		}

		private static int count_enum(IEnumerable<TfType> other)
		{
			int num = 0;
			foreach (TfType item in other)
			{
				num++;
			}
			return num;
		}

		public bool IsProperSubsetOf(IEnumerable<TfType> other)
		{
			if (IsSubsetOf(other))
			{
				return Count < count_enum(other);
			}
			return false;
		}

		public bool IsProperSupersetOf(IEnumerable<TfType> other)
		{
			if (IsSupersetOf(other))
			{
				return Count > count_enum(other);
			}
			return false;
		}

		public bool IsSubsetOf(IEnumerable<TfType> other)
		{
			int num = 0;
			foreach (TfType item in other)
			{
				if (Contains(item))
				{
					num++;
				}
			}
			return num == Count;
		}

		public bool IsSupersetOf(IEnumerable<TfType> other)
		{
			foreach (TfType item in other)
			{
				if (!Contains(item))
				{
					return false;
				}
			}
			return true;
		}

		public bool Overlaps(IEnumerable<TfType> other)
		{
			foreach (TfType item in other)
			{
				if (Contains(item))
				{
					return true;
				}
			}
			return false;
		}

		public bool SetEquals(IEnumerable<TfType> other)
		{
			if (IsSupersetOf(other))
			{
				return Count == count_enum(other);
			}
			return false;
		}

		public void SymmetricExceptWith(IEnumerable<TfType> other)
		{
			foreach (TfType item in other)
			{
				if (!Remove(item))
				{
					Add(item);
				}
			}
		}

		public void UnionWith(IEnumerable<TfType> other)
		{
			foreach (TfType item in other)
			{
				Add(item);
			}
		}

		IEnumerator<TfType> IEnumerable<TfType>.GetEnumerator()
		{
			return new TfTypeSetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new TfTypeSetEnumerator(this);
		}

		public TfTypeSetEnumerator GetEnumerator()
		{
			return new TfTypeSetEnumerator(this);
		}

		public TfTypeSet()
			: this(TfPINVOKE.new_TfTypeSet__SWIG_0(), cMemoryOwn: true)
		{
		}

		public TfTypeSet(TfTypeSet other)
			: this(TfPINVOKE.new_TfTypeSet__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return TfPINVOKE.TfTypeSet_size(swigCPtr);
		}

		public bool empty()
		{
			return TfPINVOKE.TfTypeSet_empty(swigCPtr);
		}

		public void Clear()
		{
			TfPINVOKE.TfTypeSet_Clear(swigCPtr);
		}

		public bool Add(TfType item)
		{
			bool result = TfPINVOKE.TfTypeSet_Add(swigCPtr, TfType.getCPtr(item));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Contains(TfType item)
		{
			bool result = TfPINVOKE.TfTypeSet_Contains(swigCPtr, TfType.getCPtr(item));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Remove(TfType item)
		{
			bool result = TfPINVOKE.TfTypeSet_Remove(swigCPtr, TfType.getCPtr(item));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private TfType getitem(TfType item)
		{
			TfType result = new TfType(TfPINVOKE.TfTypeSet_getitem(swigCPtr, TfType.getCPtr(item)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private IntPtr create_iterator_begin()
		{
			return TfPINVOKE.TfTypeSet_create_iterator_begin(swigCPtr);
		}

		private TfType get_next(IntPtr swigiterator)
		{
			return new TfType(TfPINVOKE.TfTypeSet_get_next(swigCPtr, swigiterator), cMemoryOwn: false);
		}

		private void destroy_iterator(IntPtr swigiterator)
		{
			TfPINVOKE.TfTypeSet_destroy_iterator(swigCPtr, swigiterator);
		}
	}
}
