using System;

namespace USD.NET
{
	public class UsdNamespaceAttribute : Attribute
	{
		public string Name { get; private set; }

		public UsdNamespaceAttribute(string name)
		{
			Name = name;
		}
	}
}
