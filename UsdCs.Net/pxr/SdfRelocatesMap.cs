using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfRelocatesMap : IDisposable, IDictionary<SdfPath, SdfPath>, ICollection<KeyValuePair<SdfPath, SdfPath>>, IEnumerable<KeyValuePair<SdfPath, SdfPath>>, IEnumerable
	{
		public sealed class SdfRelocatesMapEnumerator : IEnumerator, IEnumerator<KeyValuePair<SdfPath, SdfPath>>, IDisposable
		{
			private SdfRelocatesMap collectionRef;

			private IList<SdfPath> keyCollection;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public KeyValuePair<SdfPath, SdfPath> Current
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
					return (KeyValuePair<SdfPath, SdfPath>)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public SdfRelocatesMapEnumerator(SdfRelocatesMap collection)
			{
				collectionRef = collection;
				keyCollection = new List<SdfPath>(collection.Keys);
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
					SdfPath key = keyCollection[currentIndex];
					currentObject = new KeyValuePair<SdfPath, SdfPath>(key, collectionRef[key]);
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

		public SdfPath this[SdfPath key]
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

		public ICollection<SdfPath> Keys
		{
			get
			{
				ICollection<SdfPath> collection = new List<SdfPath>();
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

		public ICollection<SdfPath> Values
		{
			get
			{
				ICollection<SdfPath> collection = new List<SdfPath>();
				using SdfRelocatesMapEnumerator sdfRelocatesMapEnumerator = GetEnumerator();
				while (sdfRelocatesMapEnumerator.MoveNext())
				{
					collection.Add(sdfRelocatesMapEnumerator.Current.Value);
				}
				return collection;
			}
		}

		public SdfRelocatesMap(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfRelocatesMap obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfRelocatesMap obj)
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

		~SdfRelocatesMap()
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
						SdfPINVOKE.delete_SdfRelocatesMap(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public bool TryGetValue(SdfPath key, out SdfPath value)
		{
			if (ContainsKey(key))
			{
				value = this[key];
				return true;
			}
			value = null;
			return false;
		}

		public void Add(KeyValuePair<SdfPath, SdfPath> item)
		{
			Add(item.Key, item.Value);
		}

		public bool Remove(KeyValuePair<SdfPath, SdfPath> item)
		{
			if (Contains(item))
			{
				return Remove(item.Key);
			}
			return false;
		}

		public bool Contains(KeyValuePair<SdfPath, SdfPath> item)
		{
			if (this[item.Key] == item.Value)
			{
				return true;
			}
			return false;
		}

		public void CopyTo(KeyValuePair<SdfPath, SdfPath>[] array)
		{
			CopyTo(array, 0);
		}

		public void CopyTo(KeyValuePair<SdfPath, SdfPath>[] array, int arrayIndex)
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
			IList<SdfPath> list = new List<SdfPath>(Keys);
			for (int i = 0; i < list.Count; i++)
			{
				SdfPath key = list[i];
				array.SetValue(new KeyValuePair<SdfPath, SdfPath>(key, this[key]), arrayIndex + i);
			}
		}

		IEnumerator<KeyValuePair<SdfPath, SdfPath>> IEnumerable<KeyValuePair<SdfPath, SdfPath>>.GetEnumerator()
		{
			return new SdfRelocatesMapEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfRelocatesMapEnumerator(this);
		}

		public SdfRelocatesMapEnumerator GetEnumerator()
		{
			return new SdfRelocatesMapEnumerator(this);
		}

		public SdfRelocatesMap()
			: this(SdfPINVOKE.new_SdfRelocatesMap__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfRelocatesMap(SdfRelocatesMap other)
			: this(SdfPINVOKE.new_SdfRelocatesMap__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfRelocatesMap_size(swigCPtr);
		}

		public bool empty()
		{
			return SdfPINVOKE.SdfRelocatesMap_empty(swigCPtr);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfRelocatesMap_Clear(swigCPtr);
		}

		private SdfPath getitem(SdfPath key)
		{
			SdfPath result = new SdfPath(SdfPINVOKE.SdfRelocatesMap_getitem(swigCPtr, SdfPath.getCPtr(key)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(SdfPath key, SdfPath x)
		{
			SdfPINVOKE.SdfRelocatesMap_setitem(swigCPtr, SdfPath.getCPtr(key), SdfPath.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool ContainsKey(SdfPath key)
		{
			bool result = SdfPINVOKE.SdfRelocatesMap_ContainsKey(swigCPtr, SdfPath.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Add(SdfPath key, SdfPath value)
		{
			SdfPINVOKE.SdfRelocatesMap_Add(swigCPtr, SdfPath.getCPtr(key), SdfPath.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool Remove(SdfPath key)
		{
			bool result = SdfPINVOKE.SdfRelocatesMap_Remove(swigCPtr, SdfPath.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private IntPtr create_iterator_begin()
		{
			return SdfPINVOKE.SdfRelocatesMap_create_iterator_begin(swigCPtr);
		}

		private SdfPath get_next_key(IntPtr swigiterator)
		{
			return new SdfPath(SdfPINVOKE.SdfRelocatesMap_get_next_key(swigCPtr, swigiterator), cMemoryOwn: false);
		}

		private void destroy_iterator(IntPtr swigiterator)
		{
			SdfPINVOKE.SdfRelocatesMap_destroy_iterator(swigCPtr, swigiterator);
		}
	}
}
