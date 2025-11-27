using System;
using System.Collections;
using System.Collections.Generic;
using pxr;

namespace USD.NET
{
	public class SampleEnumerator<T> : IEnumerator<SampleEnumerator<T>.SampleHolder>, IEnumerator, IDisposable where T : SampleBase, new()
	{
		public class SampleHolder
		{
			public T sample = new T();

			public SdfPath path = new SdfPath();
		}

		private SdfPath[] m_paths;

		private int m_i = -1;

		private SampleHolder m_currentSample = new SampleHolder();

		private Scene m_scene;

		public SampleHolder Current => m_currentSample;

		object IEnumerator.Current => m_currentSample;

		public SampleEnumerator(Scene scene, SdfPath[] paths)
		{
			m_scene = scene;
			m_paths = paths;
			m_i = -1;
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			m_i++;
			bool flag = m_i < m_paths.Length;
			if (flag)
			{
				m_currentSample.path = m_paths[m_i];
				m_currentSample.sample = new T();
				m_scene.Read(m_currentSample.path, m_currentSample.sample);
			}
			return flag;
		}

		public void Reset()
		{
			m_i = -1;
		}
	}
}
