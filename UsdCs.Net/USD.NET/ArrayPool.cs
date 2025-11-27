using System;
using System.Collections.Generic;

namespace USD.NET
{
	public class ArrayPool
	{
		protected static readonly Type[] sm_defaultCtor = new Type[0];

		protected static readonly object[] sm_noParameters = new object[0];

		private Dictionary<Type, Dictionary<uint, List<Array>>> m_data = new Dictionary<Type, Dictionary<uint, List<Array>>>();

		private Dictionary<Type, List<object>> m_hndData = new Dictionary<Type, List<object>>();

		public virtual T[] Malloc<T>(uint size)
		{
			if (typeof(T[]) == typeof(string[]))
			{
				return new T[size];
			}
			lock (this)
			{
				Type typeFromHandle = typeof(T[]);
				if (!m_data.TryGetValue(typeFromHandle, out var value))
				{
					value = new Dictionary<uint, List<Array>>();
					m_data.Add(typeFromHandle, value);
				}
				if (!value.TryGetValue(size, out var value2))
				{
					value2 = new List<Array>();
					value.Add(size, value2);
				}
				if (value2.Count == 0)
				{
					return new T[size];
				}
				Array array = value2[value2.Count - 1];
				value2.RemoveAt(value2.Count - 1);
				return (T[])array;
			}
		}

		public virtual object MallocHandle(Type type)
		{
			lock (this)
			{
				if (!m_hndData.TryGetValue(type, out var value))
				{
					value = new List<object>();
					m_hndData.Add(type, value);
				}
				if (value.Count == 0)
				{
					return type.GetConstructor(sm_defaultCtor).Invoke(sm_noParameters);
				}
				object result = value[value.Count - 1];
				value.RemoveAt(value.Count - 1);
				return result;
			}
		}

		public virtual void FreeHandle<T>(T handle)
		{
			FreeHandle(handle.GetType(), handle);
		}

		public virtual void FreeHandle(Type type, object handle)
		{
			lock (this)
			{
				if (!m_hndData.TryGetValue(type, out var value))
				{
					value = new List<object>();
					m_hndData.Add(type, value);
				}
				value.Add(handle);
			}
		}

		public virtual void Free(Type arrayType, uint size, Array array)
		{
			if (arrayType == typeof(string[]))
			{
				return;
			}
			lock (this)
			{
				if (!m_data.TryGetValue(arrayType, out var value))
				{
					value = new Dictionary<uint, List<Array>>();
					m_data.Add(arrayType, value);
				}
				if (!value.TryGetValue(size, out var value2))
				{
					value2 = new List<Array>();
					value.Add(size, value2);
				}
				value2.Add(array);
			}
		}
	}
}
