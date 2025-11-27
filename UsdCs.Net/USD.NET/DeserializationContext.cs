using System.Collections.Generic;
using System.Reflection;

namespace USD.NET
{
	public class DeserializationContext
	{
		public HashSet<MemberInfo> dynamicMembers;

		public IRestorableData cachedData;

		public DeserializationContext()
		{
			dynamicMembers = new HashSet<MemberInfo>();
		}
	}
}
