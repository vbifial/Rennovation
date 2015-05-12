namespace Rennovation
{
    partial class frmAssignAdding
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
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cmbWorker = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblWorktype = new System.Windows.Forms.Label();
            this.btnIntervalEdit = new System.Windows.Forms.Button();
            this.btnIntervalDelete = new System.Windows.Forms.Button();
            this.btnIntervalAdd = new System.Windows.Forms.Button();
            this.dgrIntervals = new System.Windows.Forms.DataGridView();
            this.colInterval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFstime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMark = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrIntervals)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.Location = new System.Drawing.Point(124, 39);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(298, 20);
            this.txtAmount.TabIndex = 75;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(12, 42);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(82, 13);
            this.lblAmount.TabIndex = 74;
            this.lblAmount.Text = "Объем работы";
            // 
            // cmbWorker
            // 
            this.cmbWorker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorker.FormattingEnabled = true;
            this.cmbWorker.Location = new System.Drawing.Point(124, 12);
            this.cmbWorker.Name = "cmbWorker";
            this.cmbWorker.Size = new System.Drawing.Size(298, 21);
            this.cmbWorker.TabIndex = 72;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(347, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 69;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(266, 287);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 68;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblWorktype
            // 
            this.lblWorktype.AutoSize = true;
            this.lblWorktype.Location = new System.Drawing.Point(12, 15);
            this.lblWorktype.Name = "lblWorktype";
            this.lblWorktype.Size = new System.Drawing.Size(55, 13);
            this.lblWorktype.TabIndex = 70;
            this.lblWorktype.Text = "Работник";
            // 
            // btnIntervalEdit
            // 
            this.btnIntervalEdit.Location = new System.Drawing.Point(119, 65);
            this.btnIntervalEdit.Name = "btnIntervalEdit";
            this.btnIntervalEdit.Size = new System.Drawing.Size(101, 23);
            this.btnIntervalEdit.TabIndex = 79;
            this.btnIntervalEdit.Text = "Редактировать";
            this.btnIntervalEdit.UseVisualStyleBackColor = true;
            this.btnIntervalEdit.Click += new System.EventHandler(this.btnIntervalEdit_Click);
            // 
            // btnIntervalDelete
            // 
            this.btnIntervalDelete.Location = new System.Drawing.Point(226, 65);
            this.btnIntervalDelete.Name = "btnIntervalDelete";
            this.btnIntervalDelete.Size = new System.Drawing.Size(101, 23);
            this.btnIntervalDelete.TabIndex = 78;
            this.btnIntervalDelete.Text = "Удалить";
            this.btnIntervalDelete.UseVisualStyleBackColor = true;
            this.btnIntervalDelete.Click += new System.EventHandler(this.btnIntervalDelete_Click);
            // 
            // btnIntervalAdd
            // 
            this.btnIntervalAdd.Location = new System.Drawing.Point(12, 65);
            this.btnIntervalAdd.Name = "btnIntervalAdd";
            this.btnIntervalAdd.Size = new System.Drawing.Size(101, 23);
            this.btnIntervalAdd.TabIndex = 77;
            this.btnIntervalAdd.Text = "Добавить";
            this.btnIntervalAdd.UseVisualStyleBackColor = true;
            this.btnIntervalAdd.Click += new System.EventHandler(this.btnIntervalAdd_Click);
            // 
            // dgrIntervals
            // 
            this.dgrIntervals.AllowUserToAddRows = false;
            this.dgrIntervals.AllowUserToDeleteRows = false;
            this.dgrIntervals.AllowUserToResizeRows = false;
            this.dgrIntervals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgrIntervals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrIntervals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInterval,
            this.colEdate,
            this.colEstime,
            this.colEetime,
            this.colFdate,
            this.colFstime,
            this.colFetime,
            this.colMark});
            this.dgrIntervals.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgrIntervals.Location = new System.Drawing.Point(12, 94);
            this.dgrIntervals.MultiSelect = false;
            this.dgrIntervals.Name = "dgrIntervals";
            this.dgrIntervals.ReadOnly = true;
            this.dgrIntervals.RowHeadersWidth = 4;
            this.dgrIntervals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrIntervals.Size = new System.Drawing.Size(410, 189);
            this.dgrIntervals.TabIndex = 76;
            this.dgrIntervals.SelectionChanged += new System.EventHandler(this.dgrIntervals_SelectionChanged);
            // 
            // colInterval
            // 
            this.colInterval.HeaderText = "Value";
            this.colInterval.Name = "colInterval";
            this.colInterval.ReadOnly = true;
            this.colInterval.Visible = false;
            // 
            // colEdate
            // 
            this.colEdate.HeaderText = "Дата (план)";
            this.colEdate.Name = "colEdate";
            this.colEdate.ReadOnly = true;
            this.colEdate.Width = 70;
            // 
            // colEstime
            // 
            this.colEstime.HeaderText = "Начало (план)";
            this.colEstime.Name = "colEstime";
            this.colEstime.ReadOnly = true;
            this.colEstime.Width = 50;
            // 
            // colEetime
            // 
            this.colEetime.HeaderText = "Конец (план)";
            this.colEetime.Name = "colEetime";
            this.colEetime.ReadOnly = true;
            this.colEetime.Width = 50;
            // 
            // colFdate
            // 
            this.colFdate.HeaderText = "Дата (факт)";
            this.colFdate.Name = "colFdate";
            this.colFdate.ReadOnly = true;
            this.colFdate.Width = 70;
            // 
            // colFstime
            // 
            this.colFstime.HeaderText = "Начало (факт)";
            this.colFstime.Name = "colFstime";
            this.colFstime.ReadOnly = true;
            this.colFstime.Width = 50;
            // 
            // colFetime
            // 
            this.colFetime.HeaderText = "Конец (факт)";
            this.colFetime.Name = "colFetime";
            this.colFetime.ReadOnly = true;
            this.colFetime.Width = 50;
            // 
            // colMark
            // 
            this.colMark.HeaderText = "Завершен";
            this.colMark.Name = "colMark";
            this.colMark.ReadOnly = true;
            this.colMark.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colMark.Width = 60;
            // 
            // frmAssignAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 313);
            this.Controls.Add(this.btnIntervalEdit);
            this.Controls.Add(this.btnIntervalDelete);
            this.Controls.Add(this.btnIntervalAdd);
            this.Controls.Add(this.dgrIntervals);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.cmbWorker);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblWorktype);
            this.MinimumSize = new System.Drawing.Size(450, 352);
            this.Name = "frmAssignAdding";
            this.Text = "frmAssignAdding";
            this.Shown += new System.EventHandler(this.frmAssignAdding_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgrIntervals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox cmbWorker;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblWorktype;
        private System.Windows.Forms.Button btnIntervalEdit;
        private System.Windows.Forms.Button btnIntervalDelete;
        private System.Windows.Forms.Button btnIntervalAdd;
        private System.Windows.Forms.DataGridView dgrIntervals;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInterval;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFstime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFetime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colMark;
    }
}