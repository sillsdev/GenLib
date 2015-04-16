using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GenLib
{
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
        }
 
        public FormInfo(string strTitle)
        {
            InitializeComponent();
            this.Text = strTitle;
        }

        public void UpdateMessage(string strMsg)
        {
            this.tbInfo.Text = strMsg;
            this.Show();
        }
    }
}
