using System;
using System.Collections;
using System.Text;

namespace GenLib
{
    public class ReplacementList
    {
        private ArrayList m_ReplaceThis;
        private ArrayList m_WithThis;

        public ReplacementList()
        {
            m_ReplaceThis = new ArrayList();
            m_WithThis = new ArrayList();
        }

        public ArrayList ReplaceThis
        {
            get {return m_ReplaceThis;}
            set {m_ReplaceThis = value;}
        }

        public ArrayList WithThis
        {
            get {return m_WithThis;}
            set {m_WithThis = value;}
        }

        public int ListCount()
        {
           if (m_ReplaceThis == null)
                return 0;
           else return m_ReplaceThis.Count;
        }

        public string GetReplaceString(int n)
        {
            if (m_ReplaceThis == null)
                return "";
            else return (string) m_ReplaceThis[n];
        }

        public string GetWithString(int n)
        {
            if (m_WithThis == null)
                return "";
            else return (string) m_WithThis[n];
        }

        public void AddReplaceWith(string strReplace, string strWith)
        {
            if (m_ReplaceThis == null)
            {
                m_ReplaceThis = new ArrayList();
                m_WithThis = new ArrayList();
            }
            this.m_ReplaceThis.Add(strReplace);
            this.m_WithThis.Add(strWith);
        }

     }
}
