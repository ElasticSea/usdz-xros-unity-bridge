using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class NdrTokenMap : IDisposable, IDictionary<TfToken, string>, ICollection<KeyValuePair<TfToken, string>>, IEnumerable<KeyValuePair<TfToken, string>>, IEnumerable
	{
		public sealed class NdrTokenMapEnumerator : IEnumerator, IEnumerator<KeyValuePair<TfToken, string>>, IDisposable
		{
			private NdrTokenMap collectionRef;

			private IList<TfToken> keyCollection;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public KeyValuePair<TfToken, string> Current
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
					return (KeyValuePair<TfToken, string>)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public NdrTokenMapEnumerator(NdrTokenMap collection)
			{
				collectionRef = collection;
				keyCollection = new List<TfToken>(collection.Keys);
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
					TfToken key = keyCollection[currentIndex];
					currentObject = new KeyValuePair<TfToken, string>(key, collectionRef[key]);
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

		public string this[TfToken key]
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

		public ICollection<TfToken> Keys
		{
			get
			{
				ICollection<TfToken> collection = new List<TfToken>();
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
				using NdrTokenMapEnumerator ndrTokenMapEnumerator = GetEnumerator();
				while (ndrTokenMapEnumerator.MoveNext())
				{
					collection.Add(ndrTokenMapEnumerator.Current.Value);
				}
				return collection;
			}
		}

		public NdrTokenMap(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(NdrTokenMap obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(NdrTokenMap obj)
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

		~NdrTokenMap()
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
						NdrPINVOKE.delete_NdrTokenMap(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public bool TryGetValue(TfToken key, out string value)
		{
			if (ContainsKey(key))
			{
				value = this[key];
				return true;
			}
			value = null;
			return false;
		}

		public void Add(KeyValuePair<TfToken, string> item)
		{
			Add(item.Key, item.Value);
		}

		public bool Remove(KeyValuePair<TfToken, string> item)
		{
			if (Contains(item))
			{
				return Remove(item.Key);
			}
			return false;
		}

		public bool Contains(KeyValuePair<TfToken, string> item)
		{
			if (this[item.Key] == item.Value)
			{
				return true;
			}
			return false;
		}

		public void CopyTo(KeyValuePair<TfToken, string>[] array)
		{
			CopyTo(array, 0);
		}

		public void CopyTo(KeyValuePair<TfToken, string>[] array, int arrayIndex)
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
			IList<TfToken> list = new List<TfToken>(Keys);
			for (int i = 0; i < list.Count; i++)
			{
				TfToken key = list[i];
				array.SetValue(new KeyValuePair<TfToken, string>(key, this[key]), arrayIndex + i);
			}
		}

		IEnumerator<KeyValuePair<TfToken, string>> IEnumerable<KeyValuePair<TfToken, string>>.GetEnumerator()
		{
			return new NdrTokenMapEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new NdrTokenMapEnumerator(this);
		}

		public NdrTokenMapEnumerator GetEnumerator()
		{
			return new NdrTokenMapEnumerator(this);
		}

		public NdrTokenMap()
			: this(NdrPINVOKE.new_NdrTokenMap__SWIG_0(), cMemoryOwn: true)
		{
		}

		public NdrTokenMap(NdrTokenMap other)
			: this(NdrPINVOKE.new_NdrTokenMap__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return NdrPINVOKE.NdrTokenMap_size(swigCPtr);
		}

		public bool empty()
		{
			return NdrPINVOKE.NdrTokenMap_empty(swigCPtr);
		}

		public void Clear()
		{
			NdrPINVOKE.NdrTokenMap_Clear(swigCPtr);
		}

		private string getitem(TfToken key)
		{
			string result = NdrPINVOKE.NdrTokenMap_getitem(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(TfToken key, string x)
		{
			NdrPINVOKE.NdrTokenMap_setitem(swigCPtr, TfToken.getCPtr(key), x);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool ContainsKey(TfToken key)
		{
			bool result = NdrPINVOKE.NdrTokenMap_ContainsKey(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Add(TfToken key, string value)
		{
			NdrPINVOKE.NdrTokenMap_Add(swigCPtr, TfToken.getCPtr(key), value);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool Remove(TfToken key)
		{
			bool result = NdrPINVOKE.NdrTokenMap_Remove(swigCPtr, TfToken.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private IntPtr create_iterator_begin()
		{
			return NdrPINVOKE.NdrTokenMap_create_iterator_begin(swigCPtr);
		}

		private TfToken get_next_key(IntPtr swigiterator)
		{
			return new TfToken(NdrPINVOKE.NdrTokenMap_get_next_key(swigCPtr, swigiterator), cMemoryOwn: false);
		}

		private void destroy_iterator(IntPtr swigiterator)
		{
			NdrPINVOKE.NdrTokenMap_destroy_iterator(swigCPtr, swigiterator);
		}
	}
}
