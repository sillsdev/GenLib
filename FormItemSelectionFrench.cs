using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace GenLib
{
    public partial class FormItemSelectionFrench : Form
    {
        public FormItemSelectionFrench(ArrayList alAvailable, ArrayList alSelected)
        {
            string str;
            InitializeComponent();
            for (int i = 0; i < alAvailable.Count; i++)
            {
                str = alAvailable[i].ToString();
                if ( alSelected.IndexOf(str) < 0 )
                  this.lbAvailable.Items.Add(alAvailable[i].ToString());
            }
            for (int i = 0; i < alSelected.Count; i++)
            {
                this.lbSelected.Items.Add(alSelected[i].ToString());
            }
        }

        public FormItemSelectionFrench(ArrayList alAvailable, ArrayList alSelected, string title)
        {
            string str;
            InitializeComponent();
            for (int i = 0; i < alAvailable.Count; i++)
            {
                str = alAvailable[i].ToString();
                if (alSelected.IndexOf(str) < 0)
                    this.lbAvailable.Items.Add(alAvailable[i].ToString());
            }
            for (int i = 0; i < alSelected.Count; i++)
            {
                this.lbSelected.Items.Add(alSelected[i].ToString());
            }
            if (title != "")
                this.Text = title;
        }

        public FormItemSelectionFrench(ArrayList alAvailable, ArrayList alSelected, string title, Font fnt)
        {
            string str;
            InitializeComponent();
            for (int i = 0; i < alAvailable.Count; i++)
            {
                str = alAvailable[i].ToString();
                if (alSelected.IndexOf(str) < 0)
                    this.lbAvailable.Items.Add(alAvailable[i].ToString());
            }
            for (int i = 0; i < alSelected.Count; i++)
            {
                this.lbSelected.Items.Add(alSelected[i].ToString());
            }
            if (title != "")
                this.Text = title;
            if (fnt != null)
            {
                this.lbAvailable.Font = fnt;
                this.lbSelected.Font = fnt;
            }
        }

        public ArrayList Selection()
        {
            ArrayList al = new ArrayList();
            for (int i = 0; i < lbSelected.Items.Count; i++)
                al.Add(lbSelected.Items[i]);
            return al;
        }

        public ArrayList Available()
        {
            ArrayList al = new ArrayList();
            for (int i = 0; i < lbAvailable.Items.Count; i++)
                al.Add(lbAvailable.Items[i]);
            return al;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            object obj = lbAvailable.SelectedItem;
            lbSelected.Items.Add(obj);
            lbAvailable.Items.Remove(obj);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            object obj = lbSelected.SelectedItem;
            lbAvailable.Items.Add(obj);
            lbSelected.Items.Remove(obj);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
