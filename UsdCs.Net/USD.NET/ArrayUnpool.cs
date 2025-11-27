using System;

namespace USD.NET
{
	public class ArrayUnpool : ArrayPool
	{
		public override T[] Malloc<T>(uint size)
		{
			return new T[size];
		}

		public override void Free(Type type, uint size, Array array)
		{
		}

		public override object MallocHandle(Type type)
		{
			return type.GetConstructor(ArrayPool.sm_defaultCtor).Invoke(ArrayPool.sm_noParameters);
		}

		public override void FreeHandle<T>(T handle)
		{
		}

		public override void FreeHandle(Type type, object handle)
		{
		}
	}
}
