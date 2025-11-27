using System;

namespace USD.NET
{
	internal class PooledHandle<T> : IDisposable
	{
		private ArrayPool m_allocator;

		private bool disposed;

		public T Value { get; set; }

		public PooledHandle(ArrayPool allocator)
		{
			m_allocator = allocator;
			Value = (T)m_allocator.MallocHandle(typeof(T));
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
					m_allocator.FreeHandle(Value);
				}
				disposed = true;
			}
		}

		~PooledHandle()
		{
			Dispose(disposing: false);
		}
	}
}
