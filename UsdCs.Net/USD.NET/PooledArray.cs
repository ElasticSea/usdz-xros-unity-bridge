using System;

namespace USD.NET
{
	internal class PooledArray<T> : IDisposable
	{
		private ArrayPool m_allocator;

		private uint m_size;

		private bool disposed;

		public T[] Value { get; private set; }

		public PooledArray(ArrayPool allocator, uint size)
		{
			m_allocator = allocator;
			Resize(size);
		}

		public void Resize(uint size)
		{
			Free();
			m_size = size;
			Value = m_allocator.Malloc<T>(size);
		}

		public void Free()
		{
			if (Value != null)
			{
				m_allocator.Free(typeof(T), m_size, Value);
				Value = null;
			}
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!disposed)
			{
				if (disposing)
				{
					m_allocator.Free(typeof(T), m_size, Value);
				}
				disposed = true;
			}
		}

		~PooledArray()
		{
			Dispose(disposing: false);
		}
	}
}
