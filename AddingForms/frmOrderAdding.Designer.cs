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
            this.dtpCdate = new System.Windows.Forms.DateTimePicker();
            this.chbCdate = new System.Windows.Forms.CheckBox();
            this.lblCdate = new System.Windows.Forms.Label();
            this.lblBdate = new System.Windows.Forms.Label();
            this.chbBdate = new System.Windows.Forms.CheckBox();
            this.dtpBdate = new System.Windows.Forms.DateTimePicker();
            this.lblEdate = new System.Windows.Forms.Label();
            this.chbEdate = new System.Windows.Forms.CheckBox();
            this.dtpEdate = new System.Windows.Forms.DateTimePicker();
            this.lblEcost = new System.Windows.Forms.Label();
            this.txtEcost = new System.Windows.Forms.TextBox();
            this.lblFcost = new System.Windows.Forms.Label();
            this.txtFcost = new System.Windows.Forms.TextBox();
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
            this.btnCancel.Location = new System.Drawing.Point(347, 331);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(266, 331);
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
            this.chbFMark.Location = new System.Drawing.Point(12, 328);
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
            this.txtObject.Size = new System.Drawing.Size(303, 130);
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
            // dtpCdate
            // 
            this.dtpCdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCdate.Location = new System.Drawing.Point(119, 201);
            this.dtpCdate.Name = "dtpCdate";
            this.dtpCdate.Size = new System.Drawing.Size(213, 20);
            this.dtpCdate.TabIndex = 50;
            // 
            // chbCdate
            // 
            this.chbCdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbCdate.AutoSize = true;
            this.chbCdate.Location = new System.Drawing.Point(338, 201);
            this.chbCdate.Name = "chbCdate";
            this.chbCdate.Size = new System.Drawing.Size(84, 17);
            this.chbCdate.TabIndex = 51;
            this.chbCdate.Text = "Не указано";
            this.chbCdate.UseVisualStyleBackColor = true;
            this.chbCdate.CheckedChanged += new System.EventHandler(this.chbCdate_CheckedChanged);
            // 
            // lblCdate
            // 
            this.lblCdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCdate.AutoSize = true;
            this.lblCdate.Location = new System.Drawing.Point(12, 202);
            this.lblCdate.Name = "lblCdate";
            this.lblCdate.Size = new System.Drawing.Size(101, 13);
            this.lblCdate.TabIndex = 52;
            this.lblCdate.Text = "Дата составления";
            // 
            // lblBdate
            // 
            this.lblBdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBdate.AutoSize = true;
            this.lblBdate.Location = new System.Drawing.Point(12, 228);
            this.lblBdate.Name = "lblBdate";
            this.lblBdate.Size = new System.Drawing.Size(71, 13);
            this.lblBdate.TabIndex = 55;
            this.lblBdate.Text = "Дата начала";
            // 
            // chbBdate
            // 
            this.chbBdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbBdate.AutoSize = true;
            this.chbBdate.Location = new System.Drawing.Point(338, 227);
            this.chbBdate.Name = "chbBdate";
            this.chbBdate.Size = new System.Drawing.Size(84, 17);
            this.chbBdate.TabIndex = 54;
            this.chbBdate.Text = "Не указано";
            this.chbBdate.UseVisualStyleBackColor = true;
            this.chbBdate.CheckedChanged += new System.EventHandler(this.chbBdate_CheckedChanged);
            // 
            // dtpBdate
            // 
            this.dtpBdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBdate.Location = new System.Drawing.Point(119, 227);
            this.dtpBdate.Name = "dtpBdate";
            this.dtpBdate.Size = new System.Drawing.Size(213, 20);
            this.dtpBdate.TabIndex = 53;
            // 
            // lblEdate
            // 
            this.lblEdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEdate.AutoSize = true;
            this.lblEdate.Location = new System.Drawing.Point(12, 254);
            this.lblEdate.Name = "lblEdate";
            this.lblEdate.Size = new System.Drawing.Size(89, 13);
            this.lblEdate.TabIndex = 58;
            this.lblEdate.Text = "Дата окончания";
            // 
            // chbEdate
            // 
            this.chbEdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbEdate.AutoSize = true;
            this.chbEdate.Location = new System.Drawing.Point(338, 253);
            this.chbEdate.Name = "chbEdate";
            this.chbEdate.Size = new System.Drawing.Size(84, 17);
            this.chbEdate.TabIndex = 57;
            this.chbEdate.Text = "Не указано";
            this.chbEdate.UseVisualStyleBackColor = true;
            this.chbEdate.CheckedChanged += new System.EventHandler(this.chbEdate_CheckedChanged);
            // 
            // dtpEdate
            // 
            this.dtpEdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEdate.Location = new System.Drawing.Point(119, 253);
            this.dtpEdate.Name = "dtpEdate";
            this.dtpEdate.Size = new System.Drawing.Size(213, 20);
            this.dtpEdate.TabIndex = 56;
            // 
            // lblEcost
            // 
            this.lblEcost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEcost.AutoSize = true;
            this.lblEcost.Location = new System.Drawing.Point(12, 282);
            this.lblEcost.Name = "lblEcost";
            this.lblEcost.Size = new System.Drawing.Size(119, 13);
            this.lblEcost.TabIndex = 60;
            this.lblEcost.Text = "Оценочная стоимость";
            // 
            // txtEcost
            // 
            this.txtEcost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEcost.Location = new System.Drawing.Point(151, 279);
            this.txtEcost.Name = "txtEcost";
            this.txtEcost.Size = new System.Drawing.Size(271, 20);
            this.txtEcost.TabIndex = 59;
            // 
            // lblFcost
            // 
            this.lblFcost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFcost.AutoSize = true;
            this.lblFcost.Location = new System.Drawing.Point(12, 308);
            this.lblFcost.Name = "lblFcost";
            this.lblFcost.Size = new System.Drawing.Size(133, 13);
            this.lblFcost.TabIndex = 62;
            this.lblFcost.Text = "Фактическая стоимость";
            // 
            // txtFcost
            // 
            this.txtFcost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFcost.Location = new System.Drawing.Point(151, 305);
            this.txtFcost.Name = "txtFcost";
            this.txtFcost.Size = new System.Drawing.Size(271, 20);
            this.txtFcost.TabIndex = 61;
            // 
            // frmOrderAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 357);
            this.Controls.Add(this.lblFcost);
            this.Controls.Add(this.txtFcost);
            this.Controls.Add(this.lblEcost);
            this.Controls.Add(this.txtEcost);
            this.Controls.Add(this.lblEdate);
            this.Controls.Add(this.chbEdate);
            this.Controls.Add(this.dtpEdate);
            this.Controls.Add(this.lblBdate);
            this.Controls.Add(this.chbBdate);
            this.Controls.Add(this.dtpBdate);
            this.Controls.Add(this.lblCdate);
            this.Controls.Add(this.chbCdate);
            this.Controls.Add(this.dtpCdate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtObject);
            this.Controls.Add(this.chbFMark);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblQual);
            this.Controls.Add(this.lblCustomer);
            this.MaximumSize = new System.Drawing.Size(450, 1080);
            this.MinimumSize = new System.Drawing.Size(450, 300);
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
        private System.Windows.Forms.DateTimePicker dtpCdate;
        private System.Windows.Forms.CheckBox chbCdate;
        private System.Windows.Forms.Label lblCdate;
        private System.Windows.Forms.Label lblBdate;
        private System.Windows.Forms.CheckBox chbBdate;
        private System.Windows.Forms.DateTimePicker dtpBdate;
        private System.Windows.Forms.Label lblEdate;
        private System.Windows.Forms.CheckBox chbEdate;
        private System.Windows.Forms.DateTimePicker dtpEdate;
        private System.Windows.Forms.Label lblEcost;
        private System.Windows.Forms.TextBox txtEcost;
        private System.Windows.Forms.Label lblFcost;
        private System.Windows.Forms.TextBox txtFcost;

    }
}