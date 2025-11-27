using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace pxr
{
	public class SdfLayerRefPtrSet : IDisposable, ISet<SdfLayer>, ICollection<SdfLayer>, IEnumerable<SdfLayer>, IEnumerable
	{
		public sealed class SdfLayerRefPtrSetEnumerator : IEnumerator, IEnumerator<SdfLayer>, IDisposable
		{
			private SdfLayerRefPtrSet collectionRef;

			private IList<SdfLayer> ItemsCollection;

			private int currentIndex;

			private object currentObject;

			private int currentSize;

			public SdfLayer Current
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
					return (SdfLayer)currentObject;
				}
			}

			object IEnumerator.Current => Current;

			public SdfLayerRefPtrSetEnumerator(SdfLayerRefPtrSet collection)
			{
				collectionRef = collection;
				ItemsCollection = new List<SdfLayer>(collection.Items);
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

		private ICollection<SdfLayer> Items
		{
			get
			{
				ICollection<SdfLayer> collection = new List<SdfLayer>();
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

		public SdfLayerRefPtrSet(IntPtr cPtr, bool cMemoryOwn)
		{
			swigCMemOwn = cMemoryOwn;
			swigCPtr = new HandleRef(this, cPtr);
		}

		public static HandleRef getCPtr(SdfLayerRefPtrSet obj)
		{
			return obj?.swigCPtr ?? new HandleRef(null, IntPtr.Zero);
		}

		public static HandleRef swigRelease(SdfLayerRefPtrSet obj)
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

		~SdfLayerRefPtrSet()
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
						SdfPINVOKE.delete_SdfLayerRefPtrSet(swigCPtr);
					}
					swigCPtr = new HandleRef(null, IntPtr.Zero);
				}
			}
		}

		void ICollection<SdfLayer>.Add(SdfLayer item)
		{
			((ISet<SdfLayer>)this).Add(item);
		}

		public bool TryGetValue(SdfLayer equalValue, out SdfLayer actualValue)
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

		public void CopyTo(SdfLayer[] array)
		{
			CopyTo(array, 0);
		}

		public void CopyTo(SdfLayer[] array, int arrayIndex)
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
			using SdfLayerRefPtrSetEnumerator sdfLayerRefPtrSetEnumerator = GetEnumerator();
			while (sdfLayerRefPtrSetEnumerator.MoveNext())
			{
				SdfLayer current = sdfLayerRefPtrSetEnumerator.Current;
				array.SetValue(current, arrayIndex++);
			}
		}

		public void ExceptWith(IEnumerable<SdfLayer> other)
		{
			foreach (SdfLayer item in other)
			{
				Remove(item);
			}
		}

		public void IntersectWith(IEnumerable<SdfLayer> other)
		{
			SdfLayerRefPtrSet sdfLayerRefPtrSet = new SdfLayerRefPtrSet(this);
			Clear();
			foreach (SdfLayer item in other)
			{
				if (sdfLayerRefPtrSet.Contains(item))
				{
					Add(item);
				}
			}
		}

		private static int count_enum(IEnumerable<SdfLayer> other)
		{
			int num = 0;
			foreach (SdfLayer item in other)
			{
				num++;
			}
			return num;
		}

		public bool IsProperSubsetOf(IEnumerable<SdfLayer> other)
		{
			if (IsSubsetOf(other))
			{
				return Count < count_enum(other);
			}
			return false;
		}

		public bool IsProperSupersetOf(IEnumerable<SdfLayer> other)
		{
			if (IsSupersetOf(other))
			{
				return Count > count_enum(other);
			}
			return false;
		}

		public bool IsSubsetOf(IEnumerable<SdfLayer> other)
		{
			int num = 0;
			foreach (SdfLayer item in other)
			{
				if (Contains(item))
				{
					num++;
				}
			}
			return num == Count;
		}

		public bool IsSupersetOf(IEnumerable<SdfLayer> other)
		{
			foreach (SdfLayer item in other)
			{
				if (!Contains(item))
				{
					return false;
				}
			}
			return true;
		}

		public bool Overlaps(IEnumerable<SdfLayer> other)
		{
			foreach (SdfLayer item in other)
			{
				if (Contains(item))
				{
					return true;
				}
			}
			return false;
		}

		public bool SetEquals(IEnumerable<SdfLayer> other)
		{
			if (IsSupersetOf(other))
			{
				return Count == count_enum(other);
			}
			return false;
		}

		public void SymmetricExceptWith(IEnumerable<SdfLayer> other)
		{
			foreach (SdfLayer item in other)
			{
				if (!Remove(item))
				{
					Add(item);
				}
			}
		}

		public void UnionWith(IEnumerable<SdfLayer> other)
		{
			foreach (SdfLayer item in other)
			{
				Add(item);
			}
		}

		IEnumerator<SdfLayer> IEnumerable<SdfLayer>.GetEnumerator()
		{
			return new SdfLayerRefPtrSetEnumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SdfLayerRefPtrSetEnumerator(this);
		}

		public SdfLayerRefPtrSetEnumerator GetEnumerator()
		{
			return new SdfLayerRefPtrSetEnumerator(this);
		}

		public SdfLayerRefPtrSet()
			: this(SdfPINVOKE.new_SdfLayerRefPtrSet__SWIG_0(), cMemoryOwn: true)
		{
		}

		public SdfLayerRefPtrSet(SdfLayerRefPtrSet other)
			: this(SdfPINVOKE.new_SdfLayerRefPtrSet__SWIG_1(getCPtr(other)), cMemoryOwn: true)
		{
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
		}

		private uint size()
		{
			return SdfPINVOKE.SdfLayerRefPtrSet_size(swigCPtr);
		}

		public bool empty()
		{
			return SdfPINVOKE.SdfLayerRefPtrSet_empty(swigCPtr);
		}

		public void Clear()
		{
			SdfPINVOKE.SdfLayerRefPtrSet_Clear(swigCPtr);
		}

		public bool Add(SdfLayer item)
		{
			bool result = SdfPINVOKE.SdfLayerRefPtrSet_Add(swigCPtr, SdfLayer.getCPtr(item));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Contains(SdfLayer item)
		{
			bool result = SdfPINVOKE.SdfLayerRefPtrSet_Contains(swigCPtr, SdfLayer.getCPtr(item));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public bool Remove(SdfLayer item)
		{
			bool result = SdfPINVOKE.SdfLayerRefPtrSet_Remove(swigCPtr, SdfLayer.getCPtr(item));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private SdfLayer getitem(SdfLayer item)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerRefPtrSet_getitem(swigCPtr, SdfLayer.getCPtr(item));
			SdfLayer result = ((intPtr == IntPtr.Zero) ? null : new SdfLayer(intPtr, cMemoryOwn: true));
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		private IntPtr create_iterator_begin()
		{
			return SdfPINVOKE.SdfLayerRefPtrSet_create_iterator_begin(swigCPtr);
		}

		private SdfLayer get_next(IntPtr swigiterator)
		{
			IntPtr intPtr = SdfPINVOKE.SdfLayerRefPtrSet_get_next(swigCPtr, swigiterator);
			return (intPtr == IntPtr.Zero) ? null : new SdfLayer(intPtr, cMemoryOwn: true);
		}

		private void destroy_iterator(IntPtr swigiterator)
		{
			SdfPINVOKE.SdfLayerRefPtrSet_destroy_iterator(swigCPtr, swigiterator);
		}
	}
}
