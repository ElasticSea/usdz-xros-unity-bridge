using System;
using pxr;

namespace USD.NET
{
	public class VertexDataAttribute : Attribute
	{
		public static TfToken Interpolation = new TfToken("vertex");

		private int m_elementSize;

		public int ElementSize
		{
			get
			{
				return m_elementSize;
			}
			set
			{
				if (value < 1)
				{
					throw new ArgumentException("elementSize must be greater than zero");
				}
				m_elementSize = value;
			}
		}

		public VertexDataAttribute()
		{
			ElementSize = 1;
		}

		public VertexDataAttribute(int elementSize)
		{
			ElementSize = elementSize;
		}
	}
}
