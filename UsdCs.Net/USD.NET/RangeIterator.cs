using System;
using System.Collections;
using System.Collections.Generic;
using pxr;

namespace USD.NET
{
	public class RangeIterator : IEnumerable, IEnumerable<UsdPrim>, IEnumerator, IEnumerator<UsdPrim>, IDisposable
	{
		private UsdPrimRange m_range;

		private UsdPrimRange.iterator m_cur;

		private bool m_primed;

		private UsdPrimRange.iterator m_end;

		public UsdPrim Current => m_cur.GetCurrent();

		object IEnumerator.Current => m_cur.GetCurrent();

		public RangeIterator(UsdPrimRange range)
		{
			m_range = range;
			m_cur = range.GetStart();
			m_end = range.GetEnd();
			m_primed = false;
		}

		public void PruneChildren()
		{
			m_cur.PruneChildren();
		}

		public bool IsPostVisit()
		{
			return m_cur.IsPostVisit();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this;
		}

		public IEnumerator<UsdPrim> GetEnumerator()
		{
			return this;
		}

		public virtual void Dispose()
		{
			if (m_cur != null)
			{
				m_cur.Dispose();
				m_cur = null;
			}
			if (m_range != null)
			{
				m_range.Dispose();
				m_range = null;
			}
		}

		public bool MoveNext()
		{
			if (!m_primed)
			{
				m_primed = true;
			}
			else
			{
				m_cur.MoveNext();
			}
			return m_cur != m_end;
		}

		public void Reset()
		{
			m_cur = m_range.GetStart();
			m_primed = false;
		}
	}
}
