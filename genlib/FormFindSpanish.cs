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
	public class FormFindSpanish : System.Windows.Forms.Form
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

		public FormFindSpanish(RichTextBox rtb)
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
            this.labFind.Location = new System.Drawing.Point(14, 20);
            this.labFind.Name = "labFind";
            this.labFind.Size = new System.Drawing.Size(103, 20);
            this.labFind.TabIndex = 0;
            this.labFind.Text = "Buscar qué";
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(129, 20);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(137, 21);
            this.tbFind.TabIndex = 1;
            // 
            // ckCase
            // 
            this.ckCase.Location = new System.Drawing.Point(21, 53);
            this.ckCase.Name = "ckCase";
            this.ckCase.Size = new System.Drawing.Size(245, 19);
            this.ckCase.TabIndex = 3;
            this.ckCase.Text = "Coincidir mayúsculas y minúsculas";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(279, 20);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(129, 26);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Buscar siguiente";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(322, 79);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 26);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ckWord
            // 
            this.ckWord.Location = new System.Drawing.Point(21, 79);
            this.ckWord.Name = "ckWord";
            this.ckWord.Size = new System.Drawing.Size(245, 20);
            this.ckWord.TabIndex = 4;
            this.ckWord.Text = "Coincidir sólo con la palabra completa";
            // 
            // FormFindSpanish
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(494, 153);
            this.Controls.Add(this.ckWord);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.ckCase);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.labFind);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormFindSpanish";
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
                else MessageBox.Show(strFindText + " No encontrado");
            }
            else MessageBox.Show("Buscar texto no especificado");
        }

		private void btnCancel_Click(object sender, System.EventArgs e)
		{
			Form.ActiveForm.Close();
		}

	}
}
