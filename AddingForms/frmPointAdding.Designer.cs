namespace Rennovation
{
    partial class frmPointAdding
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
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.cmbWorktype = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblWorktype = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtEcost = new System.Windows.Forms.TextBox();
            this.lblEcost = new System.Windows.Forms.Label();
            this.txtFcost = new System.Windows.Forms.TextBox();
            this.lblFcost = new System.Windows.Forms.Label();
            this.lblEdate = new System.Windows.Forms.Label();
            this.chbEdate = new System.Windows.Forms.CheckBox();
            this.dtpEdate = new System.Windows.Forms.DateTimePicker();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.lblDescr = new System.Windows.Forms.Label();
            this.dgrAssigns = new System.Windows.Forms.DataGridView();
            this.colAssign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAssignEdit = new System.Windows.Forms.Button();
            this.btnAssignDelete = new System.Windows.Forms.Button();
            this.btnAssignAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrAssigns)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLevel
            // 
            this.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Location = new System.Drawing.Point(124, 39);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(298, 21);
            this.cmbLevel.TabIndex = 46;
            // 
            // cmbWorktype
            // 
            this.cmbWorktype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorktype.FormattingEnabled = true;
            this.cmbWorktype.Location = new System.Drawing.Point(124, 12);
            this.cmbWorktype.Name = "cmbWorktype";
            this.cmbWorktype.Size = new System.Drawing.Size(298, 21);
            this.cmbWorktype.TabIndex = 45;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(347, 422);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(266, 422);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(12, 42);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(109, 13);
            this.lblLevel.TabIndex = 44;
            this.lblLevel.Text = "Требуемый уровень";
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
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.Location = new System.Drawing.Point(124, 92);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(298, 20);
            this.txtAmount.TabIndex = 48;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(12, 95);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(82, 13);
            this.lblAmount.TabIndex = 47;
            this.lblAmount.Text = "Объем работы";
            // 
            // txtEcost
            // 
            this.txtEcost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEcost.Location = new System.Drawing.Point(151, 144);
            this.txtEcost.Name = "txtEcost";
            this.txtEcost.Size = new System.Drawing.Size(271, 20);
            this.txtEcost.TabIndex = 50;
            // 
            // lblEcost
            // 
            this.lblEcost.AutoSize = true;
            this.lblEcost.Location = new System.Drawing.Point(12, 147);
            this.lblEcost.Name = "lblEcost";
            this.lblEcost.Size = new System.Drawing.Size(119, 13);
            this.lblEcost.TabIndex = 49;
            this.lblEcost.Text = "Оценочная стоимость";
            // 
            // txtFcost
            // 
            this.txtFcost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFcost.Location = new System.Drawing.Point(151, 170);
            this.txtFcost.Name = "txtFcost";
            this.txtFcost.Size = new System.Drawing.Size(271, 20);
            this.txtFcost.TabIndex = 52;
            // 
            // lblFcost
            // 
            this.lblFcost.AutoSize = true;
            this.lblFcost.Location = new System.Drawing.Point(12, 173);
            this.lblFcost.Name = "lblFcost";
            this.lblFcost.Size = new System.Drawing.Size(133, 13);
            this.lblFcost.TabIndex = 51;
            this.lblFcost.Text = "Фактическая стоимость";
            // 
            // lblEdate
            // 
            this.lblEdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEdate.AutoSize = true;
            this.lblEdate.Location = new System.Drawing.Point(12, 119);
            this.lblEdate.Name = "lblEdate";
            this.lblEdate.Size = new System.Drawing.Size(89, 13);
            this.lblEdate.TabIndex = 61;
            this.lblEdate.Text = "Дата окончания";
            // 
            // chbEdate
            // 
            this.chbEdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chbEdate.AutoSize = true;
            this.chbEdate.Location = new System.Drawing.Point(338, 118);
            this.chbEdate.Name = "chbEdate";
            this.chbEdate.Size = new System.Drawing.Size(84, 17);
            this.chbEdate.TabIndex = 60;
            this.chbEdate.Text = "Не указано";
            this.chbEdate.UseVisualStyleBackColor = true;
            this.chbEdate.CheckedChanged += new System.EventHandler(this.chbEdate_CheckedChanged);
            // 
            // dtpEdate
            // 
            this.dtpEdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEdate.Location = new System.Drawing.Point(124, 118);
            this.dtpEdate.Name = "dtpEdate";
            this.dtpEdate.Size = new System.Drawing.Size(208, 20);
            this.dtpEdate.TabIndex = 59;
            // 
            // txtDescr
            // 
            this.txtDescr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescr.Location = new System.Drawing.Point(124, 66);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(298, 20);
            this.txtDescr.TabIndex = 63;
            // 
            // lblDescr
            // 
            this.lblDescr.AutoSize = true;
            this.lblDescr.Location = new System.Drawing.Point(12, 69);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(57, 13);
            this.lblDescr.TabIndex = 62;
            this.lblDescr.Text = "Описание";
            // 
            // dgrAssigns
            // 
            this.dgrAssigns.AllowUserToAddRows = false;
            this.dgrAssigns.AllowUserToDeleteRows = false;
            this.dgrAssigns.AllowUserToResizeRows = false;
            this.dgrAssigns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrAssigns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrAssigns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAssign,
            this.colWorker,
            this.colAmount});
            this.dgrAssigns.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgrAssigns.Location = new System.Drawing.Point(12, 225);
            this.dgrAssigns.MultiSelect = false;
            this.dgrAssigns.Name = "dgrAssigns";
            this.dgrAssigns.ReadOnly = true;
            this.dgrAssigns.RowHeadersWidth = 4;
            this.dgrAssigns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrAssigns.Size = new System.Drawing.Size(410, 191);
            this.dgrAssigns.TabIndex = 64;
            this.dgrAssigns.SelectionChanged += new System.EventHandler(this.dgrAssigns_SelectionChanged);
            // 
            // colAssign
            // 
            this.colAssign.HeaderText = "Column2";
            this.colAssign.Name = "colAssign";
            this.colAssign.ReadOnly = true;
            this.colAssign.Visible = false;
            // 
            // colWorker
            // 
            this.colWorker.HeaderText = "Исполнитель";
            this.colWorker.Name = "colWorker";
            this.colWorker.ReadOnly = true;
            this.colWorker.Width = 250;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Объем работы";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 120;
            // 
            // btnAssignEdit
            // 
            this.btnAssignEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssignEdit.Location = new System.Drawing.Point(119, 196);
            this.btnAssignEdit.Name = "btnAssignEdit";
            this.btnAssignEdit.Size = new System.Drawing.Size(101, 23);
            this.btnAssignEdit.TabIndex = 67;
            this.btnAssignEdit.Text = "Редактировать";
            this.btnAssignEdit.UseVisualStyleBackColor = true;
            this.btnAssignEdit.Click += new System.EventHandler(this.btnAssignEdit_Click);
            // 
            // btnAssignDelete
            // 
            this.btnAssignDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssignDelete.Location = new System.Drawing.Point(226, 196);
            this.btnAssignDelete.Name = "btnAssignDelete";
            this.btnAssignDelete.Size = new System.Drawing.Size(101, 23);
            this.btnAssignDelete.TabIndex = 66;
            this.btnAssignDelete.Text = "Удалить";
            this.btnAssignDelete.UseVisualStyleBackColor = true;
            this.btnAssignDelete.Click += new System.EventHandler(this.btnAssignDelete_Click);
            // 
            // btnAssignAdd
            // 
            this.btnAssignAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssignAdd.Location = new System.Drawing.Point(12, 196);
            this.btnAssignAdd.Name = "btnAssignAdd";
            this.btnAssignAdd.Size = new System.Drawing.Size(101, 23);
            this.btnAssignAdd.TabIndex = 65;
            this.btnAssignAdd.Text = "Добавить";
            this.btnAssignAdd.UseVisualStyleBackColor = true;
            this.btnAssignAdd.Click += new System.EventHandler(this.btnAssignAdd_Click);
            // 
            // frmPointAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 448);
            this.Controls.Add(this.btnAssignEdit);
            this.Controls.Add(this.btnAssignDelete);
            this.Controls.Add(this.btnAssignAdd);
            this.Controls.Add(this.dgrAssigns);
            this.Controls.Add(this.txtDescr);
            this.Controls.Add(this.lblDescr);
            this.Controls.Add(this.lblEdate);
            this.Controls.Add(this.chbEdate);
            this.Controls.Add(this.dtpEdate);
            this.Controls.Add(this.txtFcost);
            this.Controls.Add(this.lblFcost);
            this.Controls.Add(this.txtEcost);
            this.Controls.Add(this.lblEcost);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.cmbLevel);
            this.Controls.Add(this.cmbWorktype);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblWorktype);
            this.Name = "frmPointAdding";
            this.Text = "frmPointAdding";
            ((System.ComponentModel.ISupportInitialize)(this.dgrAssigns)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.ComboBox cmbWorktype;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblWorktype;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtEcost;
        private System.Windows.Forms.Label lblEcost;
        private System.Windows.Forms.TextBox txtFcost;
        private System.Windows.Forms.Label lblFcost;
        private System.Windows.Forms.Label lblEdate;
        private System.Windows.Forms.CheckBox chbEdate;
        private System.Windows.Forms.DateTimePicker dtpEdate;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.Label lblDescr;
        private System.Windows.Forms.DataGridView dgrAssigns;
        private System.Windows.Forms.Button btnAssignEdit;
        private System.Windows.Forms.Button btnAssignDelete;
        private System.Windows.Forms.Button btnAssignAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssign;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
    }
}