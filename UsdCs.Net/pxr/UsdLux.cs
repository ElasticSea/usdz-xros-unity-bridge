namespace pxr
{
	public class UsdLux
	{
		public static GfVec3f UsdLuxBlackbodyTemperatureAsRgb(float colorTemp)
		{
			return new GfVec3f(UsdLuxPINVOKE.UsdLuxBlackbodyTemperatureAsRgb(colorTemp), cMemoryOwn: true);
		}
	}
}
