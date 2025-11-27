using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class StdStringMap : IDisposable, IDictionary<string, string>, ICollection<KeyValuePair<string, string>>, IEnumerable<KeyValuePair<string, string>>, IEnumerable
	{
		public sealed class StdStringMapEnumerator : IEnumerator, IEnumerator<KeyValuePair<string, string>>, IDisposable
		{
			private StdStringMap collectionRef;

			private IList<string> keyCollection;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public KeyValuePair<string, string> Current
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
					return (KeyValuePair<string, string>)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public StdStringMapEnumerator(StdStringMap collection)
			{
				collectionRef = collection;
				keyCollection = new List<string>(collection.Keys);
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
					string key = keyCollection[currentIndex];
					currentObject = new KeyValuePair<string, string>(key, collectionRef[key]);
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

		public string this[string key]
		{
			get
			{
				return getitem(key);
			}
			set
			{
				setitem(key, value);
			}
		}

		public int Count => (int)size();

		public bool IsReadOnly => false;

		public ICollection<string> Keys
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
						collection.Add(get_next_key(swigiterator));
					}
					destroy_iterator(swigiterator);
				}
				return collection;
			}
		}

		public ICollection<string> Values
		{
			get
			{
				ICollection<string> collection = new List<string>();
				using StdStringMapEnumerator stdStringMapEnumerator = GetEnumerator();
				while (stdStringMapEnumerator.MoveNext())
				{
					collection.Add(stdStringMapEnumerator.Current.Value);
				}
				return collection;
			}
		}

		public StdStringMap(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(StdStringMap obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(StdStringMap obj)
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

		~StdStringMap()
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
						StdPINVOKE.delete_StdStringMap(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public bool TryGetValue(string key, out string value)
		{
			if (ContainsKey(key))
			{
				value = this[key];
				return true;
			}
			value = null;
			return false;
		}

		public void Add(KeyValuePair<string, string> item)
		{
			Add(item.Key, item.Value);
		}

		public bool Remove(KeyValuePair<string, string> item)
		{
			if (Contains(item))
			{
				return Remove(item.Key);
			}
			return false;
		}

		public bool Contains(KeyValuePair<string, string> item)
		{
			if (this[item.Key] == item.Value)
			{
				return true;
			}
			return false;
		}

		public void CopyTo(KeyValuePair<string, string>[] array)
		{
			CopyTo(array, 0);
		}

		public void CopyTo(KeyValuePair<string, string>[] array, int arrayIndex)
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
			IList<string> list = new List<string>(Keys);
			for (int i = 0; i < list.Count; i++)
			{
				string key = list[i];
				array.SetValue(new KeyValuePair<string, string>(key, this[key]), arrayIndex + i);
			}
		}

		IEnumerator<KeyValuePair<string, string>> IEnumerable<KeyValuePair<string, string>>.GetEnumerator()
		{
			return new StdStringMapEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new StdStringMapEnumerator(this);
		}

		public StdStringMapEnumerator GetEnumerator()
		{
			return new StdStringMapEnumerator(this);
		}

		public StdStringMap()
			: this(StdPINVOKE.new_StdStringMap__SWIG_0(), cMemoryOwn: true)
		{
		}

		public StdStringMap(StdStringMap other)
			: this(StdPINVOKE.new_StdStringMap__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return StdPINVOKE.StdStringMap_size(swigCPtr);
		}

		public bool empty()
		{
			return StdPINVOKE.StdStringMap_empty(swigCPtr);
		}

		public void Clear()
		{
			StdPINVOKE.StdStringMap_Clear(swigCPtr);
		}

		private string getitem(string key)
		{
			string result = StdPINVOKE.StdStringMap_getitem(swigCPtr, key);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(string key, string x)
		{
			StdPINVOKE.StdStringMap_setitem(swigCPtr, key, x);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool ContainsKey(string key)
		{
			bool result = StdPINVOKE.StdStringMap_ContainsKey(swigCPtr, key);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Add(string key, string value)
		{
			StdPINVOKE.StdStringMap_Add(swigCPtr, key, value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool Remove(string key)
		{
			bool result = StdPINVOKE.StdStringMap_Remove(swigCPtr, key);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private IntPtr create_iterator_begin()
		{
			return StdPINVOKE.StdStringMap_create_iterator_begin(swigCPtr);
		}

		private string get_next_key(IntPtr swigiterator)
		{
			return StdPINVOKE.StdStringMap_get_next_key(swigCPtr, swigiterator);
		}

		private void destroy_iterator(IntPtr swigiterator)
		{
			StdPINVOKE.StdStringMap_destroy_iterator(swigCPtr, swigiterator);
		}
	}
}
