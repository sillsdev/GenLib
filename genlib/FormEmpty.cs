using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GenLib
{
    public partial class FormEmpty : Form
    {
        public FormEmpty()
        {
            InitializeComponent();
        }

        public Button buttonOk
        {
            get { return this.btnOK; }
        }

        public Button buttonCancel
        {
            get { return this.btnCancel; }
        }

    }
}
