using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace GenLib
{
	/// <summary>
	/// Summary description for FormProgress.
	/// </summary>
	public class FormProgressBar : System.Windows.Forms.Form
	{
        private System.Windows.Forms.ProgressBar pb;
		/// <summary>
		/// Required designer variable.
		/// </summary>
        private System.ComponentModel.Container components = null;

        private bool m_Quit;

		public FormProgressBar()
		{
			InitializeComponent();
            m_Quit = false;
		}

		public FormProgressBar(string strTitle)
		{
			InitializeComponent();
            m_Quit = false;
			this.Text = strTitle;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProgressBar));
            this.pb = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(0, 0);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(400, 24);
            this.pb.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb.TabIndex = 1;
            // 
            // FormProgressBar
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 17);
            this.ClientSize = new System.Drawing.Size(402, 26);
            this.Controls.Add(this.pb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProgressBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Progress Bar";
            this.TopMost = true;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormProgressBar_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormProgressBar_KeyUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormProgressBar_KeyDown);
            this.ResumeLayout(false);

		}
		#endregion

        public bool Quit
        {
            get { return m_Quit; }
        }

        public void PB_Init(int nMin, int nMax)
		{
            if (nMax < nMin)
                nMax = nMin;
            pb.Minimum = nMin;
            pb.Maximum = nMax;
            pb.Value = nMin;
            this.Show();
		}

		public void PB_Update(int n)
		{
			if ( (pb.Minimum < n)  && (n < pb.Maximum) )
			{
				pb.Value = n;
				this.Show();
			}
		}

        private void btnCancel_Click(object sender, EventArgs e)
        {
            m_Quit = true;
            MessageBox.Show("Cancel key pressed");
        }

        private void btnCancel_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Key has been pressed");
        }

        private void FormProgressBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("KeyPress");
        }

        private void FormProgressBar_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("KeyDown");
        }

        private void FormProgressBar_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show("KeyUp");

        }
		
  
	}
}
