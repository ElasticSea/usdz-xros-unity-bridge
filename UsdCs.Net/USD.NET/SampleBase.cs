using System;

namespace USD.NET
{
	[Serializable]
	public class SampleBase
	{
		public void Free()
		{
			foreach (Array item in Reflect.ExtractArrays(this))
			{
				if (item.Rank != 1)
				{
					throw new NotImplementedException("Multi-dimensional arrays are not supported");
				}
				UsdIo.ArrayAllocator.Free(item.GetType(), (uint)item.GetLength(0), item);
			}
		}
	}
}
