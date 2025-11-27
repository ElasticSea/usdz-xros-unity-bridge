using System;

namespace USD.NET
{
	public class UsdSchemaAttribute : Attribute
	{
		public string Name { get; private set; }

		public UsdSchemaAttribute(string name)
		{
			Name = name;
		}
	}
}
