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
    public partial class FormBrowse : Form
    {
        public FormBrowse()
        {
            InitializeComponent();
        }

        public void AddColHeaders(ArrayList al, Color clr, Font fnt)
        {
            dgvBrowse.ColumnCount = al.Count;
            dgvBrowse.ColumnHeadersVisible = true;
            dgvBrowse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            
            DataGridViewCellStyle dgvcsHeaders = new DataGridViewCellStyle();
            dgvcsHeaders.BackColor = clr;
            dgvcsHeaders.Font = fnt;
            dgvcsHeaders.ForeColor = Color.White;
            dgvBrowse.ColumnHeadersDefaultCellStyle = dgvcsHeaders;

            for (int i = 0; i < al.Count; i++)
            {
                dgvBrowse.Columns[i].Name = al[i].ToString();
            }
        }

        public void AddRow(ArrayList al)
        {
            int n = dgvBrowse.Rows.Add();
            for (int i = 0; i < al.Count; i++)
            {
                dgvBrowse.Rows[n].Cells[i].Value = al[i];
            }
        }

        private void FormBrowse_SizeChanged(object sender, EventArgs e)
        {
            //this.dgvBrowse.Size.Height = this.Size.Height;
            //this.dgvBrowse.Size.Width = this.Size.Width;
        }

    }
}
