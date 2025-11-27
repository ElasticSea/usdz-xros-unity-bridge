using System.Collections.Generic;

namespace USD.NET
{
	public interface IArbitraryPrimvars
	{
		void AddPrimvars(List<string> primvars);

		Dictionary<string, Primvar<object>> GetArbitraryPrimvars();
	}
}
