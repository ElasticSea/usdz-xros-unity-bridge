using System;
using System.Reflection;
using pxr;

namespace USD.NET
{
	public class DefaultConversions
	{
		public static VtValue ToVtValue(object value)
		{
			return CastToVtValue(value, value.GetType());
		}

		public static VtValue CastToVtValue<T>(T t, Type trueType) where T : class
		{
			ConstructorInfo constructor = typeof(VtValue).GetConstructor(new Type[1] { trueType });
			if (constructor == null)
			{
				throw new ApplicationException($"Cannot construct VtValue from T({trueType.Name})");
			}
			return constructor.Invoke(new object[1] { t }) as VtValue;
		}
	}
}
