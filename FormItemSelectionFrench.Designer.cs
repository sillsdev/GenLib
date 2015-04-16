namespace GenLib
{
    partial class FormItemSelectionFrench
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbAvailable = new System.Windows.Forms.ListBox();
            this.lbSelected = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labAvailable = new System.Windows.Forms.Label();
            this.labSelected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAvailable
            // 
            this.lbAvailable.FormattingEnabled = true;
            this.lbAvailable.ItemHeight = 18;
            this.lbAvailable.Location = new System.Drawing.Point(22, 57);
            this.lbAvailable.Name = "lbAvailable";
            this.lbAvailable.Size = new System.Drawing.Size(144, 256);
            this.lbAvailable.Sorted = true;
            this.lbAvailable.TabIndex = 1;
            // 
            // lbSelected
            // 
            this.lbSelected.FormattingEnabled = true;
            this.lbSelected.ItemHeight = 18;
            this.lbSelected.Location = new System.Drawing.Point(313, 57);
            this.lbSelected.Name = "lbSelected";
            this.lbSelected.Size = new System.Drawing.Size(144, 256);
            this.lbSelected.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(190, 103);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(190, 165);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 32);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Enlever";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(190, 349);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 32);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(313, 349);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 32);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labAvailable
            // 
            this.labAvailable.AutoSize = true;
            this.labAvailable.Location = new System.Drawing.Point(18, 24);
            this.labAvailable.Name = "labAvailable";
            this.labAvailable.Size = new System.Drawing.Size(148, 18);
            this.labAvailable.TabIndex = 0;
            this.labAvailable.Text = "Éléments disponibles";
            // 
            // labSelected
            // 
            this.labSelected.AutoSize = true;
            this.labSelected.Location = new System.Drawing.Point(310, 24);
            this.labSelected.Name = "labSelected";
            this.labSelected.Size = new System.Drawing.Size(157, 18);
            this.labSelected.TabIndex = 2;
            this.labSelected.Text = "Éléments séléctionnés";
            // 
            // FormItemSelectionFrench
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 394);
            this.Controls.Add(this.labSelected);
            this.Controls.Add(this.labAvailable);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbSelected);
            this.Controls.Add(this.lbAvailable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormItemSelectionFrench";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choix d\'Élément";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAvailable;
        private System.Windows.Forms.ListBox lbSelected;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labAvailable;
        private System.Windows.Forms.Label labSelected;
    }
}