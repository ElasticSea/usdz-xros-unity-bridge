using pxr;

namespace USD.NET
{
	public struct UsdTypeBinding
	{
		public ToVtConverter toVtValue;

		public ToCsConverter toCsObject;

		public SdfValueTypeName sdfTypeName;

		public UsdTypeBinding(ToVtConverter toVtConverter, ToCsConverter toCsConverter, SdfValueTypeName sdfName)
		{
			toVtValue = toVtConverter;
			toCsObject = toCsConverter;
			sdfTypeName = sdfName;
		}
	}
}
