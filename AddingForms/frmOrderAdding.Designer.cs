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
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblQual = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.chbFMark = new System.Windows.Forms.CheckBox();
            this.txtObject = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(119, 12);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(303, 21);
            this.cmbCustomer.TabIndex = 45;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(347, 292);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(266, 292);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblQual
            // 
            this.lblQual.AutoSize = true;
            this.lblQual.Location = new System.Drawing.Point(12, 68);
            this.lblQual.Name = "lblQual";
            this.lblQual.Size = new System.Drawing.Size(45, 13);
            this.lblQual.TabIndex = 44;
            this.lblQual.Text = "Объект";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(12, 15);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(55, 13);
            this.lblCustomer.TabIndex = 43;
            this.lblCustomer.Text = "Заказчик";
            // 
            // chbFMark
            // 
            this.chbFMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbFMark.AutoSize = true;
            this.chbFMark.Location = new System.Drawing.Point(12, 289);
            this.chbFMark.Name = "chbFMark";
            this.chbFMark.Size = new System.Drawing.Size(77, 17);
            this.chbFMark.TabIndex = 46;
            this.chbFMark.Text = "Завершён";
            this.chbFMark.UseVisualStyleBackColor = true;
            // 
            // txtObject
            // 
            this.txtObject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObject.Location = new System.Drawing.Point(119, 65);
            this.txtObject.Multiline = true;
            this.txtObject.Name = "txtObject";
            this.txtObject.Size = new System.Drawing.Size(303, 221);
            this.txtObject.TabIndex = 47;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(119, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(303, 20);
            this.txtName.TabIndex = 48;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 13);
            this.lblName.TabIndex = 49;
            this.lblName.Text = "Название";
            // 
            // frmOrderAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 318);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtObject);
            this.Controls.Add(this.chbFMark);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblQual);
            this.Controls.Add(this.lblCustomer);
            this.Name = "frmOrderAdding";
            this.Text = "frmOrderAdding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblQual;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.CheckBox chbFMark;
        private System.Windows.Forms.TextBox txtObject;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;

    }
}