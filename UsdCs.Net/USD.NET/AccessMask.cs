using System.Collections.Generic;
using pxr;

namespace USD.NET
{
	public class AccessMask
	{
		public Dictionary<SdfPath, DeserializationContext> Included = new Dictionary<SdfPath, DeserializationContext>();
	}
}
