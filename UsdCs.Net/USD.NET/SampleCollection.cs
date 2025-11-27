using System.Collections;
using System.Collections.Generic;
using pxr;

namespace USD.NET
{
	public class SampleCollection<T> : IEnumerable<SampleEnumerator<T>.SampleHolder>, IEnumerable where T : SampleBase, new()
	{
		private SdfPath[] m_paths;

		private Scene m_scene;

		public int Length => m_paths.Length;

		public SampleCollection(Scene scene, SdfPathVector paths)
		{
			m_paths = new SdfPath[paths.Count];
			paths.CopyTo(m_paths);
			m_scene = scene;
		}

		public IEnumerator<SampleEnumerator<T>.SampleHolder> GetEnumerator()
		{
			return new SampleEnumerator<T>(m_scene, m_paths);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SampleEnumerator<T>(m_scene, m_paths);
		}
	}
}
