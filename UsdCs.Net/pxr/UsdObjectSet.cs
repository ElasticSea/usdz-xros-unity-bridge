using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class UsdObjectSet : IDisposable, ISet<UsdObject>, ICollection<UsdObject>, IEnumerable<UsdObject>, IEnumerable
	{
		public sealed class UsdObjectSetEnumerator : IEnumerator, IEnumerator<UsdObject>, IDisposable
		{
			private UsdObjectSet collectionRef;

			private IList<UsdObject> ItemsCollection;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public UsdObject Current
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
					return (UsdObject)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public UsdObjectSetEnumerator(UsdObjectSet collection)
			{
				collectionRef = collection;
				ItemsCollection = new List<UsdObject>(collection.Items);
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

		private ICollection<UsdObject> Items
		{
			get
			{
				ICollection<UsdObject> collection = new List<UsdObject>();
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

		public UsdObjectSet(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(UsdObjectSet obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(UsdObjectSet obj)
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

		~UsdObjectSet()
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
						UsdPINVOKE.delete_UsdObjectSet(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		void ICollection<UsdObject>.Add(UsdObject item)
		{
			((ISet<UsdObject>)this).Add(item);
		}

		public bool TryGetValue(UsdObject equalValue, out UsdObject actualValue)
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

		public void CopyTo(UsdObject[] array)
		{
			CopyTo(array, 0);
		}

		public void CopyTo(UsdObject[] array, int arrayIndex)
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
			using UsdObjectSetEnumerator usdObjectSetEnumerator = GetEnumerator();
			while (usdObjectSetEnumerator.MoveNext())
			{
				UsdObject current = usdObjectSetEnumerator.Current;
				array.SetValue(current, arrayIndex++);
			}
		}

		public void ExceptWith(IEnumerable<UsdObject> other)
		{
			foreach (UsdObject item in other)
			{
				Remove(item);
			}
		}

		public void IntersectWith(IEnumerable<UsdObject> other)
		{
			UsdObjectSet usdObjectSet = new UsdObjectSet(this);
			Clear();
			foreach (UsdObject item in other)
			{
				if (usdObjectSet.Contains(item))
				{
					Add(item);
				}
			}
		}

		private static int count_enum(IEnumerable<UsdObject> other)
		{
			int num = 0;
			foreach (UsdObject item in other)
			{
				num++;
			}
			return num;
		}

		public bool IsProperSubsetOf(IEnumerable<UsdObject> other)
		{
			if (IsSubsetOf(other))
			{
				return Count < count_enum(other);
			}
			return false;
		}

		public bool IsProperSupersetOf(IEnumerable<UsdObject> other)
		{
			if (IsSupersetOf(other))
			{
				return Count > count_enum(other);
			}
			return false;
		}

		public bool IsSubsetOf(IEnumerable<UsdObject> other)
		{
			int num = 0;
			foreach (UsdObject item in other)
			{
				if (Contains(item))
				{
					num++;
				}
			}
			return num == Count;
		}

		public bool IsSupersetOf(IEnumerable<UsdObject> other)
		{
			foreach (UsdObject item in other)
			{
				if (!Contains(item))
				{
					return false;
				}
			}
			return true;
		}

		public bool Overlaps(IEnumerable<UsdObject> other)
		{
			foreach (UsdObject item in other)
			{
				if (Contains(item))
				{
					return true;
				}
			}
			return false;
		}

		public bool SetEquals(IEnumerable<UsdObject> other)
		{
			if (IsSupersetOf(other))
			{
				return Count == count_enum(other);
			}
			return false;
		}

		public void SymmetricExceptWith(IEnumerable<UsdObject> other)
		{
			foreach (UsdObject item in other)
			{
				if (!Remove(item))
				{
					Add(item);
				}
			}
		}

		public void UnionWith(IEnumerable<UsdObject> other)
		{
			foreach (UsdObject item in other)
			{
				Add(item);
			}
		}

		IEnumerator<UsdObject> IEnumerable<UsdObject>.GetEnumerator()
		{
			return new UsdObjectSetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new UsdObjectSetEnumerator(this);
		}

		public UsdObjectSetEnumerator GetEnumerator()
		{
			return new UsdObjectSetEnumerator(this);
		}

		public UsdObjectSet()
			: this(UsdPINVOKE.new_UsdObjectSet__SWIG_0(), cMemoryOwn: true)
		{
		}

		public UsdObjectSet(UsdObjectSet other)
			: this(UsdPINVOKE.new_UsdObjectSet__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return UsdPINVOKE.UsdObjectSet_size(swigCPtr);
		}

		public bool empty()
		{
			return UsdPINVOKE.UsdObjectSet_empty(swigCPtr);
		}

		public void Clear()
		{
			UsdPINVOKE.UsdObjectSet_Clear(swigCPtr);
		}

		public bool Add(UsdObject item)
		{
			bool result = UsdPINVOKE.UsdObjectSet_Add(swigCPtr, UsdObject.getCPtr(item));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Contains(UsdObject item)
		{
			bool result = UsdPINVOKE.UsdObjectSet_Contains(swigCPtr, UsdObject.getCPtr(item));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Remove(UsdObject item)
		{
			bool result = UsdPINVOKE.UsdObjectSet_Remove(swigCPtr, UsdObject.getCPtr(item));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private UsdObject getitem(UsdObject item)
		{
			UsdObject result = new UsdObject(UsdPINVOKE.UsdObjectSet_getitem(swigCPtr, UsdObject.getCPtr(item)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private IntPtr create_iterator_begin()
		{
			return UsdPINVOKE.UsdObjectSet_create_iterator_begin(swigCPtr);
		}

		private UsdObject get_next(IntPtr swigiterator)
		{
			return new UsdObject(UsdPINVOKE.UsdObjectSet_get_next(swigCPtr, swigiterator), cMemoryOwn: false);
		}

		private void destroy_iterator(IntPtr swigiterator)
		{
			UsdPINVOKE.UsdObjectSet_destroy_iterator(swigCPtr, swigiterator);
		}
	}
}
