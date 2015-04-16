using System;
using System.Collections;

namespace GenLib
{
	/// <summary>
	/// 
	/// </summary>
	public class CodeTable
	{
		ArrayList m_Entries;		//ArrayList of Code Table Entries

		public CodeTable()
		{
			m_Entries = new ArrayList();
		}

		public int AddEntry(CodeTableEntry entry)
		{
			return m_Entries.Add(entry);
		}

		public CodeTableEntry GetEntry(string code)
		{
			CodeTableEntry cte = null;
			for (int i = 0; i < this.Count(); i++)
			{
				cte = (CodeTableEntry) m_Entries[i];
				if (cte.Code == code)
					return cte;
			}
			return null;
		}

		public CodeTableEntry GetEntry(int n)
		{
			return (CodeTableEntry) m_Entries[n];
		}

		public void DeleteEntry(int n)
		{
			m_Entries.RemoveAt(n);
		}

		public void DeleteEntry(CodeTableEntry cte)
		{
			m_Entries.Remove(cte);
		}

		public void ClearAll()
		{
			m_Entries.Clear();
		}
			
		public int Count()
		{
			return m_Entries.Count;
		}

		public int GetIndex(string code)
		{
			CodeTableEntry cte = null;
			for (int i = 0; i < this.Count(); i++)
			{
				cte = (CodeTableEntry) m_Entries[i];
				if (cte.Code == code)
					return i;
			}
			return -1;
		}

	}
}
