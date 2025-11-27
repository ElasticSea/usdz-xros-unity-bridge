namespace pxr
{
	public class Plug
	{
		public static string PlugFindPluginResource(PlugPlugin plugin, string path, bool verify)
		{
			string result = PlugPINVOKE.PlugFindPluginResource__SWIG_0(PlugPlugin.getCPtr(plugin), path, verify);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}

		public static string PlugFindPluginResource(PlugPlugin plugin, string path)
		{
			string result = PlugPINVOKE.PlugFindPluginResource__SWIG_1(PlugPlugin.getCPtr(plugin), path);
			if (UsdCsPINVOKE.SWIGPendingException.Pending)
			{
				throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
			}
			return result;
		}
	}
}
