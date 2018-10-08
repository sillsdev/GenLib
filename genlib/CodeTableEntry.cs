using System;

namespace GenLib
{
	/// <summary>
	/// 
	/// </summary>
	public class CodeTableEntry
	{
		private string m_Code;		// Code
		private string m_Desc;		// Description or Name

		public CodeTableEntry(string code, string desc)
		{
			m_Code = code;
			m_Desc = desc;
		}

		public string Code
		{
			get {return m_Code;}
			set {m_Code = value;}
		}

		public string Description
		{
			get {return m_Desc;}
			set {m_Desc = value;}
		}

	}
}
