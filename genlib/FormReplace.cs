using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace GenLib
{
	/// <summary>
	/// Summary description for FormReplace.
	/// </summary>
	public class FormReplace : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label labFind;
		private System.Windows.Forms.TextBox tbFind;
		private System.Windows.Forms.Label labReplace;
		private System.Windows.Forms.TextBox tbReplace;
		private System.Windows.Forms.CheckBox ckCase;
		private System.Windows.Forms.CheckBox ckWord;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Button btnReplace;
		private System.Windows.Forms.Button btnAll;
		private System.Windows.Forms.Button btnCancel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private RichTextBox m_Rtb;

		public FormReplace(RichTextBox rtb)
		{
			InitializeComponent();
			m_Rtb = rtb;
            m_Rtb.SelectionStart = 0;
			this.tbFind.Text = m_Rtb.SelectedText;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.labFind = new System.Windows.Forms.Label();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.labReplace = new System.Windows.Forms.Label();
            this.tbReplace = new System.Windows.Forms.TextBox();
            this.ckCase = new System.Windows.Forms.CheckBox();
            this.ckWord = new System.Windows.Forms.CheckBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labFind
            // 
            this.labFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFind.Location = new System.Drawing.Point(16, 24);
            this.labFind.Name = "labFind";
            this.labFind.Size = new System.Drawing.Size(120, 24);
            this.labFind.TabIndex = 0;
            this.labFind.Text = "Find what";
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(144, 24);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(160, 24);
            this.tbFind.TabIndex = 1;
            // 
            // labReplace
            // 
            this.labReplace.Location = new System.Drawing.Point(16, 64);
            this.labReplace.Name = "labReplace";
            this.labReplace.Size = new System.Drawing.Size(120, 24);
            this.labReplace.TabIndex = 2;
            this.labReplace.Text = "Replace with";
            // 
            // tbReplace
            // 
            this.tbReplace.Location = new System.Drawing.Point(144, 64);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(160, 24);
            this.tbReplace.TabIndex = 3;
            // 
            // ckCase
            // 
            this.ckCase.Location = new System.Drawing.Point(24, 112);
            this.ckCase.Name = "ckCase";
            this.ckCase.Size = new System.Drawing.Size(120, 24);
            this.ckCase.TabIndex = 4;
            this.ckCase.Text = "Match case";
            // 
            // ckWord
            // 
            this.ckWord.Location = new System.Drawing.Point(24, 152);
            this.ckWord.Name = "ckWord";
            this.ckWord.Size = new System.Drawing.Size(200, 24);
            this.ckWord.TabIndex = 5;
            this.ckWord.Text = "Match whole word only";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(336, 24);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(150, 32);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "Find next";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(336, 64);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(150, 32);
            this.btnReplace.TabIndex = 7;
            this.btnReplace.Text = "Replace";
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(336, 112);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(150, 32);
            this.btnAll.TabIndex = 8;
            this.btnAll.Text = "Replace All";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(386, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 32);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormReplace
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 17);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(507, 203);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.ckWord);
            this.Controls.Add(this.ckCase);
            this.Controls.Add(this.tbReplace);
            this.Controls.Add(this.labReplace);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.labFind);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormReplace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        public string FindText
        {
            get { return this.tbFind.Text; }
        }

        private void btnFind_Click(object sender, System.EventArgs e)
		{
			string strFindText = this.tbFind.Text;
			int ndx = 0;
			RichTextBoxFinds rtbf = RichTextBoxFinds.None;
            if (strFindText != "")
            {
                bool fMatchCase = this.ckCase.Checked;
                bool fMatchWord = this.ckWord.Checked;
                if (fMatchCase)
                    rtbf = rtbf | RichTextBoxFinds.MatchCase;
                if (fMatchWord)
                    rtbf = rtbf | RichTextBoxFinds.WholeWord;

                ndx = m_Rtb.Find(strFindText, m_Rtb.SelectionStart + m_Rtb.SelectionLength,
                    rtbf);
                if (ndx >= 0)
                {
                    m_Rtb.SelectionStart = ndx;
                    m_Rtb.SelectionLength = strFindText.Length;
                }
                else MessageBox.Show(strFindText + " not found");
            }
            else MessageBox.Show("Find text not specified");
		}

		private void btnReplace_Click(object sender, System.EventArgs e)
		{
			string strReplaceText = this.tbReplace.Text;
			string strFindText = this.tbFind.Text;
			int ndx = 0;
			RichTextBoxFinds rtbf = RichTextBoxFinds.None;
			if (strFindText != "")
			{
                if (strReplaceText != "")
                {
                    if ((m_Rtb.SelectedText != "") && (m_Rtb.SelectionLength > 0))
                    {
                        m_Rtb.SelectedText = strReplaceText;
                        m_Rtb.SelectionStart = m_Rtb.SelectionStart - strReplaceText.Length;
                        m_Rtb.SelectionLength = strReplaceText.Length;
                    }
                    bool fMatchCase = this.ckCase.Checked;
                    bool fMatchWord = this.ckWord.Checked;
                    if (fMatchCase)
                        rtbf = rtbf | RichTextBoxFinds.MatchCase;
                    if (fMatchWord)
                        rtbf = rtbf | RichTextBoxFinds.WholeWord;

                    ndx = m_Rtb.Find(strFindText,
                        m_Rtb.SelectionStart + m_Rtb.SelectionLength, rtbf);
                    if (ndx >= 0)
                    {
                        m_Rtb.SelectionStart = ndx;
                        m_Rtb.SelectionLength = strFindText.Length;
                    }
                    else MessageBox.Show(strFindText + " not found");
                }
                else MessageBox.Show("Replace text not specified");
			}
            else MessageBox.Show("Find text not specified");
		}

		private void btnAll_Click(object sender, System.EventArgs e)
		{
			string strReplaceText = this.tbReplace.Text;
			string strFindText = this.tbFind.Text;
			int ndx = 0;
			bool fDone = false;
			RichTextBoxFinds rtbf = RichTextBoxFinds.None;
            if (strFindText != "")
            {
                if (strReplaceText != "")
                {
                    bool fMatchCase = this.ckCase.Checked;
                    bool fMatchWord = this.ckWord.Checked;
                    if (fMatchCase)
                        rtbf = rtbf | RichTextBoxFinds.MatchCase;
                    if (fMatchWord)
                        rtbf = rtbf | RichTextBoxFinds.WholeWord;

                    m_Rtb.Select(0, 0);		//Goto Top
                    while (!fDone)
                    {
                        ndx = m_Rtb.Find(strFindText,
                            m_Rtb.SelectionStart + m_Rtb.SelectionLength, rtbf);
                        if (ndx >= 0)
                        {
                            m_Rtb.SelectionStart = ndx;
                            m_Rtb.SelectionLength = strFindText.Length;
                            if ((m_Rtb.SelectedText != "") && (m_Rtb.SelectionLength > 0))
                            {
                                m_Rtb.SelectedText = strReplaceText;
                                m_Rtb.SelectionStart = m_Rtb.SelectionStart - strReplaceText.Length;
                                m_Rtb.SelectionLength = strReplaceText.Length;
                            }
                        }
                        else fDone = true;
                    }
                }
                else MessageBox.Show("Replace text not specified");
            }
            else MessageBox.Show("Find text not specified");
		}

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			Form.ActiveForm.Close();
		}
	}
}
