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
    public partial class FormItemSelection : Form
    {
        public FormItemSelection(ArrayList alAvailable, ArrayList alSelected)
        {
            string str;
            InitializeComponent();
            for (int i = 0; i < alAvailable.Count; i++)
            {
                str = alAvailable[i].ToString();
                if (str.ToLower() == str)
                {
                    if (alSelected.IndexOf(str) < 0)
                        this.lbAvailable.Items.Add(alAvailable[i].ToString());
                }
            }
            if (lbAvailable.Items.Count > 0)
                this.lbAvailable.SetSelected(0, true);

            for (int i = 0; i < alSelected.Count; i++)
            {
                this.lbSelected.Items.Add(alSelected[i].ToString());
            }
            if (lbSelected.Items.Count > 0)
                this.lbSelected.SetSelected(0, true);
        }

        public FormItemSelection(ArrayList alAvailable, ArrayList alSelected, string title)
        {
            string str;
            InitializeComponent();
            for (int i = 0; i < alAvailable.Count; i++)
            {
                str = alAvailable[i].ToString();
                if (str.ToLower() == str)
                {
                    if (alSelected.IndexOf(str) < 0)
                        this.lbAvailable.Items.Add(alAvailable[i].ToString());
                }
            }
            if (lbAvailable.Items.Count > 0)
                this.lbAvailable.SetSelected(0, true);


            for (int i = 0; i < alSelected.Count; i++)
            {
                this.lbSelected.Items.Add(alSelected[i].ToString());
            }
            if (lbSelected.Items.Count > 0)
                this.lbSelected.SetSelected(0, true);

            if (title != null)
                this.Text = title;
        }

        public FormItemSelection(ArrayList alAvailable, ArrayList alSelected, string title, Font fnt)
        {
            string str;
            InitializeComponent();
            for (int i = 0; i < alAvailable.Count; i++)
            {
                str = alAvailable[i].ToString();
                if (str.ToLower() == str)
                {
                    if (alSelected.IndexOf(str) < 0)
                        this.lbAvailable.Items.Add(alAvailable[i].ToString());
                }
            }
            // select first item
            if (lbAvailable.Items.Count > 0)
                this.lbAvailable.SetSelected(0, true);

            for (int i = 0; i < alSelected.Count; i++)
            {
                this.lbSelected.Items.Add(alSelected[i].ToString());
            }
            // select first item
            if (lbSelected.Items.Count > 0)
                this.lbSelected.SetSelected(0, true);
            
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

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            object obj = null;
            for (int i = 0; i < lbAvailable.Items.Count; i++)
            {
                obj = lbAvailable.Items[i];
                lbSelected.Items.Add(obj);
            }
            for (int i = lbAvailable.Items.Count; 0 <i; i--)
                lbAvailable.Items.RemoveAt(i-1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            object obj = lbAvailable.SelectedItem;
            int ndx = lbAvailable.SelectedIndex;
            if (obj != null)
            {
                lbSelected.Items.Add(obj);
                lbAvailable.Items.Remove(obj);
            }
            if ((0 <= ndx) && (ndx < lbAvailable.Items.Count))
                lbAvailable.SetSelected(ndx, true);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            object obj = lbSelected.SelectedItem;
            int ndx = lbSelected.SelectedIndex;
            if (obj != null)
            {
                lbAvailable.Items.Add(obj);
                lbSelected.Items.Remove(obj);
            }
            if ((0 <= ndx)  && (ndx < lbSelected.Items.Count))
                lbSelected.SetSelected(ndx, true);
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            object obj = null;
            for (int i = 0; i < lbSelected.Items.Count; i++)
            {
                obj = lbSelected.Items[i];
                lbAvailable.Items.Add(obj);
            }
            for (int i = lbSelected.Items.Count; 0 < i; i--)
                lbSelected.Items.RemoveAt(i - 1);

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
