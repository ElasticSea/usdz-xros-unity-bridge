using System;
using pxr;

namespace USD.NET
{
	public class UsdVariabilityAttribute : Attribute
	{
		public SdfVariability SdfVariability { get; private set; }

		public UsdVariabilityAttribute(Variability variability)
		{
			SdfVariability = ((variability == Variability.Uniform) ? SdfVariability.SdfVariabilityUniform : SdfVariability.SdfVariabilityVarying);
		}
	}
}
