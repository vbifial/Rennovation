namespace Rennovation
{
    partial class frmOrderAdding
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
            this.cmbQual = new System.Windows.Forms.ComboBox();
            this.cmbWorktype = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblQual = new System.Windows.Forms.Label();
            this.lblWorktype = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbQual
            // 
            this.cmbQual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQual.FormattingEnabled = true;
            this.cmbQual.Location = new System.Drawing.Point(119, 39);
            this.cmbQual.Name = "cmbQual";
            this.cmbQual.Size = new System.Drawing.Size(303, 21);
            this.cmbQual.TabIndex = 46;
            // 
            // cmbWorktype
            // 
            this.cmbWorktype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorktype.FormattingEnabled = true;
            this.cmbWorktype.Location = new System.Drawing.Point(119, 12);
            this.cmbWorktype.Name = "cmbWorktype";
            this.cmbWorktype.Size = new System.Drawing.Size(303, 21);
            this.cmbWorktype.TabIndex = 45;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(347, 67);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(266, 67);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblQual
            // 
            this.lblQual.AutoSize = true;
            this.lblQual.Location = new System.Drawing.Point(12, 42);
            this.lblQual.Name = "lblQual";
            this.lblQual.Size = new System.Drawing.Size(82, 13);
            this.lblQual.TabIndex = 44;
            this.lblQual.Text = "Квалификация";
            // 
            // lblWorktype
            // 
            this.lblWorktype.AutoSize = true;
            this.lblWorktype.Location = new System.Drawing.Point(12, 15);
            this.lblWorktype.Name = "lblWorktype";
            this.lblWorktype.Size = new System.Drawing.Size(43, 13);
            this.lblWorktype.TabIndex = 43;
            this.lblWorktype.Text = "Работа";
            // 
            // frmOrderAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 93);
            this.Controls.Add(this.cmbQual);
            this.Controls.Add(this.cmbWorktype);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblQual);
            this.Controls.Add(this.lblWorktype);
            this.Name = "frmOrderAdding";
            this.Text = "frmOrderAdding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbQual;
        private System.Windows.Forms.ComboBox cmbWorktype;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblQual;
        private System.Windows.Forms.Label lblWorktype;

    }
}