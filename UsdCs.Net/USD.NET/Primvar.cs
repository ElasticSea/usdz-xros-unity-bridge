using System;

namespace USD.NET
{
	public class Primvar<T> : PrimvarBase, ValueAccessor
	{
		public T value;

		public bool IsArray => typeof(T).IsArray;

		public int Length
		{
			get
			{
				if (!IsArray || value == null)
				{
					return 0;
				}
				return (value as Array).Length;
			}
		}

		public object GetValue()
		{
			return value;
		}

		public void SetValue(object o)
		{
			value = (T)o;
		}

		public Type GetValueType()
		{
			return typeof(T);
		}
	}
}
