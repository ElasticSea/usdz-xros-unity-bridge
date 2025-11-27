using System.Collections.Generic;
using pxr;

namespace USD.NET
{
	internal class TokenCache
	{
		private Dictionary<string, Dictionary<string, TfToken>> m_cache = new Dictionary<string, Dictionary<string, TfToken>>();

		public TfToken this[string token] => GetCache(string.Empty, token);

		public TfToken this[string usdNamespace, string token] => GetCache(usdNamespace, token);

		private TfToken GetCache(string ns, string token)
		{
			if (ns == null)
			{
				ns = string.Empty;
			}
			if (token == null)
			{
				token = string.Empty;
			}
			TfToken value2;
			lock (this)
			{
				if (!m_cache.TryGetValue(ns, out var value))
				{
					value = new Dictionary<string, TfToken>();
					m_cache[ns] = value;
				}
				if (!value.TryGetValue(token, out value2))
				{
					value2 = (value[token] = new TfToken(IntrinsicTypeConverter.JoinNamespace(ns, token)));
				}
			}
			return value2;
		}
	}
}
