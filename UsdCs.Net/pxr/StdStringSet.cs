using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class StdStringSet : IDisposable, ISet<string>, ICollection<string>, IEnumerable<string>, IEnumerable
	{
		public sealed class StdStringSetEnumerator : IEnumerator, IEnumerator<string>, IDisposable
		{
			private StdStringSet collectionRef;

			private IList<string> ItemsCollection;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public string Current
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
					return (string)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public StdStringSetEnumerator(StdStringSet collection)
			{
				collectionRef = collection;
				ItemsCollection = new List<string>(collection.Items);
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

		private ICollection<string> Items
		{
			get
			{
				ICollection<string> collection = new List<string>();
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

		public StdStringSet(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(StdStringSet obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(StdStringSet obj)
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

		~StdStringSet()
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
						StdPINVOKE.delete_StdStringSet(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		void ICollection<string>.Add(string item)
		{
			((ISet<string>)this).Add(item);
		}

		public bool TryGetValue(string equalValue, out string actualValue)
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

		public void CopyTo(string[] array)
		{
			CopyTo(array, 0);
		}

		public void CopyTo(string[] array, int arrayIndex)
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
			using StdStringSetEnumerator stdStringSetEnumerator = GetEnumerator();
			while (stdStringSetEnumerator.MoveNext())
			{
				string current = stdStringSetEnumerator.Current;
				array.SetValue(current, arrayIndex++);
			}
		}

		public void ExceptWith(IEnumerable<string> other)
		{
			foreach (string item in other)
			{
				Remove(item);
			}
		}

		public void IntersectWith(IEnumerable<string> other)
		{
			StdStringSet stdStringSet = new StdStringSet(this);
			Clear();
			foreach (string item in other)
			{
				if (stdStringSet.Contains(item))
				{
					Add(item);
				}
			}
		}

		private static int count_enum(IEnumerable<string> other)
		{
			int num = 0;
			foreach (string item in other)
			{
				num++;
			}
			return num;
		}

		public bool IsProperSubsetOf(IEnumerable<string> other)
		{
			if (IsSubsetOf(other))
			{
				return Count < count_enum(other);
			}
			return false;
		}

		public bool IsProperSupersetOf(IEnumerable<string> other)
		{
			if (IsSupersetOf(other))
			{
				return Count > count_enum(other);
			}
			return false;
		}

		public bool IsSubsetOf(IEnumerable<string> other)
		{
			int num = 0;
			foreach (string item in other)
			{
				if (Contains(item))
				{
					num++;
				}
			}
			return num == Count;
		}

		public bool IsSupersetOf(IEnumerable<string> other)
		{
			foreach (string item in other)
			{
				if (!Contains(item))
				{
					return false;
				}
			}
			return true;
		}

		public bool Overlaps(IEnumerable<string> other)
		{
			foreach (string item in other)
			{
				if (Contains(item))
				{
					return true;
				}
			}
			return false;
		}

		public bool SetEquals(IEnumerable<string> other)
		{
			if (IsSupersetOf(other))
			{
				return Count == count_enum(other);
			}
			return false;
		}

		public void SymmetricExceptWith(IEnumerable<string> other)
		{
			foreach (string item in other)
			{
				if (!Remove(item))
				{
					Add(item);
				}
			}
		}

		public void UnionWith(IEnumerable<string> other)
		{
			foreach (string item in other)
			{
				Add(item);
			}
		}

		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return new StdStringSetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new StdStringSetEnumerator(this);
		}

		public StdStringSetEnumerator GetEnumerator()
		{
			return new StdStringSetEnumerator(this);
		}

		public StdStringSet()
			: this(StdPINVOKE.new_StdStringSet__SWIG_0(), cMemoryOwn: true)
		{
		}

		public StdStringSet(StdStringSet other)
			: this(StdPINVOKE.new_StdStringSet__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return StdPINVOKE.StdStringSet_size(swigCPtr);
		}

		public bool empty()
		{
			return StdPINVOKE.StdStringSet_empty(swigCPtr);
		}

		public void Clear()
		{
			StdPINVOKE.StdStringSet_Clear(swigCPtr);
		}

		public bool Add(string item)
		{
			bool result = StdPINVOKE.StdStringSet_Add(swigCPtr, item);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Contains(string item)
		{
			bool result = StdPINVOKE.StdStringSet_Contains(swigCPtr, item);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Remove(string item)
		{
			bool result = StdPINVOKE.StdStringSet_Remove(swigCPtr, item);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private string getitem(string item)
		{
			string result = StdPINVOKE.StdStringSet_getitem(swigCPtr, item);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private IntPtr create_iterator_begin()
		{
			return StdPINVOKE.StdStringSet_create_iterator_begin(swigCPtr);
		}

		private string get_next(IntPtr swigiterator)
		{
			return StdPINVOKE.StdStringSet_get_next(swigCPtr, swigiterator);
		}

		private void destroy_iterator(IntPtr swigiterator)
		{
			StdPINVOKE.StdStringSet_destroy_iterator(swigCPtr, swigiterator);
		}
	}
}
