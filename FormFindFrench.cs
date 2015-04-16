using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace GenLib
{
	/// <summary>
	/// Summary description for FormFind.
	/// </summary>
	public class FormFindFrench : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label labFind;
		private System.Windows.Forms.TextBox tbFind;
		private System.Windows.Forms.CheckBox ckCase;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.CheckBox ckWord;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private RichTextBox m_Rtb;

		public FormFindFrench(RichTextBox rtb)
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
            this.ckCase = new System.Windows.Forms.CheckBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ckWord = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labFind
            // 
            this.labFind.Location = new System.Drawing.Point(16, 24);
            this.labFind.Name = "labFind";
            this.labFind.Size = new System.Drawing.Size(120, 24);
            this.labFind.TabIndex = 0;
            this.labFind.Text = "Texte recherché";
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(150, 24);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(160, 24);
            this.tbFind.TabIndex = 1;
            // 
            // ckCase
            // 
            this.ckCase.Location = new System.Drawing.Point(24, 64);
            this.ckCase.Name = "ckCase";
            this.ckCase.Size = new System.Drawing.Size(207, 24);
            this.ckCase.TabIndex = 3;
            this.ckCase.Text = "Respecter la casse";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(326, 24);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(150, 32);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Rechercher suivant";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(376, 96);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 32);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ckWord
            // 
            this.ckWord.Location = new System.Drawing.Point(24, 96);
            this.ckWord.Name = "ckWord";
            this.ckWord.Size = new System.Drawing.Size(200, 24);
            this.ckWord.TabIndex = 4;
            this.ckWord.Text = "Mots entiers uniquement";
            // 
            // FormFindFrench
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 17);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(494, 153);
            this.Controls.Add(this.ckWord);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.ckCase);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.labFind);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormFindFrench";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rechercher";
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
                else MessageBox.Show(strFindText + " introuvable");
            }
            else MessageBox.Show("Texte recherché manquant");
        }

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			Form.ActiveForm.Close();
		}

	}
}
