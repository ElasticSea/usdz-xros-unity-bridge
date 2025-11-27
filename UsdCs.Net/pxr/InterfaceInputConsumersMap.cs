using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class InterfaceInputConsumersMap : IDisposable, IDictionary<UsdShadeInput, UsdShadeInputVector>, ICollection<KeyValuePair<UsdShadeInput, UsdShadeInputVector>>, IEnumerable<KeyValuePair<UsdShadeInput, UsdShadeInputVector>>, IEnumerable
	{
		public sealed class InterfaceInputConsumersMapEnumerator : IEnumerator, IEnumerator<KeyValuePair<UsdShadeInput, UsdShadeInputVector>>, IDisposable
		{
			private InterfaceInputConsumersMap collectionRef;

			private IList<UsdShadeInput> keyCollection;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public KeyValuePair<UsdShadeInput, UsdShadeInputVector> Current
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
					return (KeyValuePair<UsdShadeInput, UsdShadeInputVector>)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public InterfaceInputConsumersMapEnumerator(InterfaceInputConsumersMap collection)
			{
				collectionRef = collection;
				keyCollection = new List<UsdShadeInput>(collection.Keys);
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
					UsdShadeInput key = keyCollection[currentIndex];
					currentObject = new KeyValuePair<UsdShadeInput, UsdShadeInputVector>(key, collectionRef[key]);
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

		public UsdShadeInputVector this[UsdShadeInput key]
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

		public ICollection<UsdShadeInput> Keys
		{
			get
			{
				ICollection<UsdShadeInput> collection = new List<UsdShadeInput>();
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

		public ICollection<UsdShadeInputVector> Values
		{
			get
			{
				ICollection<UsdShadeInputVector> collection = new List<UsdShadeInputVector>();
				using InterfaceInputConsumersMapEnumerator interfaceInputConsumersMapEnumerator = GetEnumerator();
				while (interfaceInputConsumersMapEnumerator.MoveNext())
				{
					collection.Add(interfaceInputConsumersMapEnumerator.Current.Value);
				}
				return collection;
			}
		}

		public InterfaceInputConsumersMap(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(InterfaceInputConsumersMap obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(InterfaceInputConsumersMap obj)
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

		~InterfaceInputConsumersMap()
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
						UsdShadePINVOKE.delete_InterfaceInputConsumersMap(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		public bool TryGetValue(UsdShadeInput key, out UsdShadeInputVector value)
		{
			if (ContainsKey(key))
			{
				value = this[key];
				return true;
			}
			value = null;
			return false;
		}

		public void Add(KeyValuePair<UsdShadeInput, UsdShadeInputVector> item)
		{
			Add(item.Key, item.Value);
		}

		public bool Remove(KeyValuePair<UsdShadeInput, UsdShadeInputVector> item)
		{
			if (Contains(item))
			{
				return Remove(item.Key);
			}
			return false;
		}

		public bool Contains(KeyValuePair<UsdShadeInput, UsdShadeInputVector> item)
		{
			if (this[item.Key] == item.Value)
			{
				return true;
			}
			return false;
		}

		public void CopyTo(KeyValuePair<UsdShadeInput, UsdShadeInputVector>[] array)
		{
			CopyTo(array, 0);
		}

		public void CopyTo(KeyValuePair<UsdShadeInput, UsdShadeInputVector>[] array, int arrayIndex)
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
			IList<UsdShadeInput> list = new List<UsdShadeInput>(Keys);
			for (int i = 0; i < list.Count; i++)
			{
				UsdShadeInput key = list[i];
				array.SetValue(new KeyValuePair<UsdShadeInput, UsdShadeInputVector>(key, this[key]), arrayIndex + i);
			}
		}

		IEnumerator<KeyValuePair<UsdShadeInput, UsdShadeInputVector>> IEnumerable<KeyValuePair<UsdShadeInput, UsdShadeInputVector>>.GetEnumerator()
		{
			return new InterfaceInputConsumersMapEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new InterfaceInputConsumersMapEnumerator(this);
		}

		public InterfaceInputConsumersMapEnumerator GetEnumerator()
		{
			return new InterfaceInputConsumersMapEnumerator(this);
		}

		public InterfaceInputConsumersMap()
			: this(UsdShadePINVOKE.new_InterfaceInputConsumersMap__SWIG_0(), cMemoryOwn: true)
		{
		}

		public InterfaceInputConsumersMap(InterfaceInputConsumersMap other)
			: this(UsdShadePINVOKE.new_InterfaceInputConsumersMap__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return UsdShadePINVOKE.InterfaceInputConsumersMap_size(swigCPtr);
		}

		public bool empty()
		{
			return UsdShadePINVOKE.InterfaceInputConsumersMap_empty(swigCPtr);
		}

		public void Clear()
		{
			UsdShadePINVOKE.InterfaceInputConsumersMap_Clear(swigCPtr);
		}

		private UsdShadeInputVector getitem(UsdShadeInput key)
		{
			UsdShadeInputVector result = new UsdShadeInputVector(UsdShadePINVOKE.InterfaceInputConsumersMap_getitem(swigCPtr, UsdShadeInput.getCPtr(key)), cMemoryOwn: false);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private void setitem(UsdShadeInput key, UsdShadeInputVector x)
		{
			UsdShadePINVOKE.InterfaceInputConsumersMap_setitem(swigCPtr, UsdShadeInput.getCPtr(key), UsdShadeInputVector.getCPtr(x));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool ContainsKey(UsdShadeInput key)
		{
			bool result = UsdShadePINVOKE.InterfaceInputConsumersMap_ContainsKey(swigCPtr, UsdShadeInput.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public void Add(UsdShadeInput key, UsdShadeInputVector value)
		{
			UsdShadePINVOKE.InterfaceInputConsumersMap_Add(swigCPtr, UsdShadeInput.getCPtr(key), UsdShadeInputVector.getCPtr(value));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		public bool Remove(UsdShadeInput key)
		{
			bool result = UsdShadePINVOKE.InterfaceInputConsumersMap_Remove(swigCPtr, UsdShadeInput.getCPtr(key));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private IntPtr create_iterator_begin()
		{
			return UsdShadePINVOKE.InterfaceInputConsumersMap_create_iterator_begin(swigCPtr);
		}

		private UsdShadeInput get_next_key(IntPtr swigiterator)
		{
			return new UsdShadeInput(UsdShadePINVOKE.InterfaceInputConsumersMap_get_next_key(swigCPtr, swigiterator), cMemoryOwn: false);
		}

		private void destroy_iterator(IntPtr swigiterator)
		{
			UsdShadePINVOKE.InterfaceInputConsumersMap_destroy_iterator(swigCPtr, swigiterator);
		}
	}
}
