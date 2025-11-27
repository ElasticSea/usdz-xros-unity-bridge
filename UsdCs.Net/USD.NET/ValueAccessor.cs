using System;

namespace USD.NET
{
	public interface ValueAccessor
	{
		object GetValue();

		void SetValue(object value);

		Type GetValueType();
	}
}
