namespace Rennovation
{
    partial class frmIntervalAdding
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
            this.lblEdate = new System.Windows.Forms.Label();
            this.chbEdate = new System.Windows.Forms.CheckBox();
            this.dtpEdate = new System.Windows.Forms.DateTimePicker();
            this.txtEstime = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtEetime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbMark = new System.Windows.Forms.CheckBox();
            this.grbPlan = new System.Windows.Forms.GroupBox();
            this.grbFact = new System.Windows.Forms.GroupBox();
            this.dtpFdate = new System.Windows.Forms.DateTimePicker();
            this.chbFdate = new System.Windows.Forms.CheckBox();
            this.txtFetime = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.txtFstime = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grbPlan.SuspendLayout();
            this.grbFact.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEdate
            // 
            this.lblEdate.AutoSize = true;
            this.lblEdate.Location = new System.Drawing.Point(6, 22);
            this.lblEdate.Name = "lblEdate";
            this.lblEdate.Size = new System.Drawing.Size(33, 13);
            this.lblEdate.TabIndex = 64;
            this.lblEdate.Text = "Дата";
            // 
            // chbEdate
            // 
            this.chbEdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbEdate.AutoSize = true;
            this.chbEdate.Location = new System.Drawing.Point(320, 19);
            this.chbEdate.Name = "chbEdate";
            this.chbEdate.Size = new System.Drawing.Size(84, 17);
            this.chbEdate.TabIndex = 63;
            this.chbEdate.Text = "Не указано";
            this.chbEdate.UseVisualStyleBackColor = true;
            this.chbEdate.CheckedChanged += new System.EventHandler(this.chbEdate_CheckedChanged);
            // 
            // dtpEdate
            // 
            this.dtpEdate.Location = new System.Drawing.Point(130, 19);
            this.dtpEdate.Name = "dtpEdate";
            this.dtpEdate.Size = new System.Drawing.Size(184, 20);
            this.dtpEdate.TabIndex = 62;
            this.dtpEdate.ValueChanged += new System.EventHandler(this.dtpEdate_ValueChanged);
            // 
            // txtEstime
            // 
            this.txtEstime.Location = new System.Drawing.Point(130, 45);
            this.txtEstime.Name = "txtEstime";
            this.txtEstime.Size = new System.Drawing.Size(274, 20);
            this.txtEstime.TabIndex = 66;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(6, 48);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(78, 13);
            this.lblAmount.TabIndex = 65;
            this.lblAmount.Text = "Время начала";
            // 
            // txtEetime
            // 
            this.txtEetime.Location = new System.Drawing.Point(130, 71);
            this.txtEetime.Name = "txtEetime";
            this.txtEetime.Size = new System.Drawing.Size(274, 20);
            this.txtEetime.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Время окончания";
            // 
            // chbMark
            // 
            this.chbMark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbMark.AutoSize = true;
            this.chbMark.Location = new System.Drawing.Point(12, 284);
            this.chbMark.Name = "chbMark";
            this.chbMark.Size = new System.Drawing.Size(77, 17);
            this.chbMark.TabIndex = 69;
            this.chbMark.Text = "Завершен";
            this.chbMark.UseVisualStyleBackColor = true;
            // 
            // grbPlan
            // 
            this.grbPlan.Controls.Add(this.dtpEdate);
            this.grbPlan.Controls.Add(this.chbEdate);
            this.grbPlan.Controls.Add(this.txtEetime);
            this.grbPlan.Controls.Add(this.lblEdate);
            this.grbPlan.Controls.Add(this.label1);
            this.grbPlan.Controls.Add(this.lblAmount);
            this.grbPlan.Controls.Add(this.txtEstime);
            this.grbPlan.Location = new System.Drawing.Point(12, 12);
            this.grbPlan.Name = "grbPlan";
            this.grbPlan.Size = new System.Drawing.Size(410, 130);
            this.grbPlan.TabIndex = 70;
            this.grbPlan.TabStop = false;
            this.grbPlan.Text = "Планируемое";
            // 
            // grbFact
            // 
            this.grbFact.Controls.Add(this.dtpFdate);
            this.grbFact.Controls.Add(this.chbFdate);
            this.grbFact.Controls.Add(this.txtFetime);
            this.grbFact.Controls.Add(this.label35);
            this.grbFact.Controls.Add(this.label36);
            this.grbFact.Controls.Add(this.label37);
            this.grbFact.Controls.Add(this.txtFstime);
            this.grbFact.Location = new System.Drawing.Point(12, 148);
            this.grbFact.Name = "grbFact";
            this.grbFact.Size = new System.Drawing.Size(410, 130);
            this.grbFact.TabIndex = 81;
            this.grbFact.TabStop = false;
            this.grbFact.Text = "Фактическое";
            // 
            // dtpFdate
            // 
            this.dtpFdate.Location = new System.Drawing.Point(130, 19);
            this.dtpFdate.Name = "dtpFdate";
            this.dtpFdate.Size = new System.Drawing.Size(184, 20);
            this.dtpFdate.TabIndex = 62;
            this.dtpFdate.ValueChanged += new System.EventHandler(this.dtpFdate_ValueChanged);
            // 
            // chbFdate
            // 
            this.chbFdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbFdate.AutoSize = true;
            this.chbFdate.Location = new System.Drawing.Point(320, 19);
            this.chbFdate.Name = "chbFdate";
            this.chbFdate.Size = new System.Drawing.Size(84, 17);
            this.chbFdate.TabIndex = 63;
            this.chbFdate.Text = "Не указано";
            this.chbFdate.UseVisualStyleBackColor = true;
            this.chbFdate.CheckedChanged += new System.EventHandler(this.chbFdate_CheckedChanged);
            // 
            // txtFetime
            // 
            this.txtFetime.Location = new System.Drawing.Point(130, 71);
            this.txtFetime.Name = "txtFetime";
            this.txtFetime.Size = new System.Drawing.Size(274, 20);
            this.txtFetime.TabIndex = 68;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(6, 22);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(33, 13);
            this.label35.TabIndex = 64;
            this.label35.Text = "Дата";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 74);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(96, 13);
            this.label36.TabIndex = 67;
            this.label36.Text = "Время окончания";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(6, 48);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(78, 13);
            this.label37.TabIndex = 65;
            this.label37.Text = "Время начала";
            // 
            // txtFstime
            // 
            this.txtFstime.Location = new System.Drawing.Point(130, 45);
            this.txtFstime.Name = "txtFstime";
            this.txtFstime.Size = new System.Drawing.Size(274, 20);
            this.txtFstime.TabIndex = 66;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(347, 284);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 83;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(266, 284);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 82;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmIntervalAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grbFact);
            this.Controls.Add(this.grbPlan);
            this.Controls.Add(this.chbMark);
            this.MaximumSize = new System.Drawing.Size(450, 350);
            this.MinimumSize = new System.Drawing.Size(450, 350);
            this.Name = "frmIntervalAdding";
            this.Text = "frmIntervalAdding";
            this.grbPlan.ResumeLayout(false);
            this.grbPlan.PerformLayout();
            this.grbFact.ResumeLayout(false);
            this.grbFact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEdate;
        private System.Windows.Forms.CheckBox chbEdate;
        private System.Windows.Forms.DateTimePicker dtpEdate;
        private System.Windows.Forms.TextBox txtEstime;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtEetime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chbMark;
        private System.Windows.Forms.GroupBox grbPlan;
        private System.Windows.Forms.GroupBox grbFact;
        private System.Windows.Forms.DateTimePicker dtpFdate;
        private System.Windows.Forms.CheckBox chbFdate;
        private System.Windows.Forms.TextBox txtFetime;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtFstime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}