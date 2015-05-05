namespace Rennovation
{
    partial class frmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dgrPoints = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.btnOrderEdit = new System.Windows.Forms.Button();
            this.btnOrderDelete = new System.Windows.Forms.Button();
            this.btnOrderAdd = new System.Windows.Forms.Button();
            this.txtOrderInfo = new System.Windows.Forms.TextBox();
            this.btnPointEdit = new System.Windows.Forms.Button();
            this.btnPointDelete = new System.Windows.Forms.Button();
            this.btnPointAdd = new System.Windows.Forms.Button();
            this.colPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorktype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            this.справочникиToolStripMenuItem.Click += new System.EventHandler(this.mstReferenceClick);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(715, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dgrPoints
            // 
            this.dgrPoints.AllowUserToAddRows = false;
            this.dgrPoints.AllowUserToDeleteRows = false;
            this.dgrPoints.AllowUserToResizeRows = false;
            this.dgrPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrPoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPoint,
            this.colDescr,
            this.colWorktype,
            this.colAmount});
            this.dgrPoints.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgrPoints.Location = new System.Drawing.Point(192, 180);
            this.dgrPoints.MultiSelect = false;
            this.dgrPoints.Name = "dgrPoints";
            this.dgrPoints.ReadOnly = true;
            this.dgrPoints.RowHeadersWidth = 4;
            this.dgrPoints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrPoints.Size = new System.Drawing.Size(511, 198);
            this.dgrPoints.TabIndex = 26;
            this.dgrPoints.SelectionChanged += new System.EventHandler(this.dgrPoints_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(189, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Пункты заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(189, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Информация";
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrders.Location = new System.Drawing.Point(9, 35);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(52, 13);
            this.lblOrders.TabIndex = 20;
            this.lblOrders.Text = "Заказы";
            // 
            // lstOrders
            // 
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.IntegralHeight = false;
            this.lstOrders.Items.AddRange(new object[] {
            "Заказ №12373",
            "Заказ №12332",
            "Заказ №21333",
            "Заказ №85883"});
            this.lstOrders.Location = new System.Drawing.Point(12, 51);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(174, 327);
            this.lstOrders.TabIndex = 0;
            this.lstOrders.SelectedIndexChanged += new System.EventHandler(this.lstOrders_SelectedIndexChanged);
            // 
            // btnOrderEdit
            // 
            this.btnOrderEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOrderEdit.Location = new System.Drawing.Point(85, 413);
            this.btnOrderEdit.Name = "btnOrderEdit";
            this.btnOrderEdit.Size = new System.Drawing.Size(101, 23);
            this.btnOrderEdit.TabIndex = 3;
            this.btnOrderEdit.Text = "Редактировать";
            this.btnOrderEdit.UseVisualStyleBackColor = true;
            this.btnOrderEdit.Click += new System.EventHandler(this.btnOrderEdit_Click);
            // 
            // btnOrderDelete
            // 
            this.btnOrderDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOrderDelete.Location = new System.Drawing.Point(12, 413);
            this.btnOrderDelete.Name = "btnOrderDelete";
            this.btnOrderDelete.Size = new System.Drawing.Size(67, 23);
            this.btnOrderDelete.TabIndex = 2;
            this.btnOrderDelete.Text = "Удалить";
            this.btnOrderDelete.UseVisualStyleBackColor = true;
            this.btnOrderDelete.Click += new System.EventHandler(this.btnOrderDelete_Click);
            // 
            // btnOrderAdd
            // 
            this.btnOrderAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOrderAdd.Location = new System.Drawing.Point(12, 384);
            this.btnOrderAdd.Name = "btnOrderAdd";
            this.btnOrderAdd.Size = new System.Drawing.Size(174, 23);
            this.btnOrderAdd.TabIndex = 1;
            this.btnOrderAdd.Text = "Добавить";
            this.btnOrderAdd.UseVisualStyleBackColor = true;
            this.btnOrderAdd.Click += new System.EventHandler(this.btnOrderAdd_Click);
            // 
            // txtOrderInfo
            // 
            this.txtOrderInfo.Location = new System.Drawing.Point(192, 51);
            this.txtOrderInfo.Multiline = true;
            this.txtOrderInfo.Name = "txtOrderInfo";
            this.txtOrderInfo.ReadOnly = true;
            this.txtOrderInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOrderInfo.Size = new System.Drawing.Size(511, 110);
            this.txtOrderInfo.TabIndex = 42;
            // 
            // btnPointEdit
            // 
            this.btnPointEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPointEdit.Location = new System.Drawing.Point(602, 413);
            this.btnPointEdit.Name = "btnPointEdit";
            this.btnPointEdit.Size = new System.Drawing.Size(101, 23);
            this.btnPointEdit.TabIndex = 45;
            this.btnPointEdit.Text = "Редактировать";
            this.btnPointEdit.UseVisualStyleBackColor = true;
            this.btnPointEdit.Click += new System.EventHandler(this.btnPointEdit_Click);
            // 
            // btnPointDelete
            // 
            this.btnPointDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPointDelete.Location = new System.Drawing.Point(529, 413);
            this.btnPointDelete.Name = "btnPointDelete";
            this.btnPointDelete.Size = new System.Drawing.Size(67, 23);
            this.btnPointDelete.TabIndex = 44;
            this.btnPointDelete.Text = "Удалить";
            this.btnPointDelete.UseVisualStyleBackColor = true;
            this.btnPointDelete.Click += new System.EventHandler(this.btnPointDelete_Click);
            // 
            // btnPointAdd
            // 
            this.btnPointAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPointAdd.Location = new System.Drawing.Point(529, 384);
            this.btnPointAdd.Name = "btnPointAdd";
            this.btnPointAdd.Size = new System.Drawing.Size(174, 23);
            this.btnPointAdd.TabIndex = 43;
            this.btnPointAdd.Text = "Добавить";
            this.btnPointAdd.UseVisualStyleBackColor = true;
            this.btnPointAdd.Click += new System.EventHandler(this.btnPointAdd_Click);
            // 
            // colPoint
            // 
            this.colPoint.HeaderText = "Column2";
            this.colPoint.Name = "colPoint";
            this.colPoint.ReadOnly = true;
            this.colPoint.Visible = false;
            // 
            // colDescr
            // 
            this.colDescr.HeaderText = "Описание";
            this.colDescr.Name = "colDescr";
            this.colDescr.ReadOnly = true;
            this.colDescr.Width = 200;
            // 
            // colWorktype
            // 
            this.colWorktype.HeaderText = "Работа";
            this.colWorktype.Name = "colWorktype";
            this.colWorktype.ReadOnly = true;
            this.colWorktype.Width = 180;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "Объем работы";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 120;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 448);
            this.Controls.Add(this.btnPointEdit);
            this.Controls.Add(this.btnPointDelete);
            this.Controls.Add(this.btnPointAdd);
            this.Controls.Add(this.txtOrderInfo);
            this.Controls.Add(this.btnOrderEdit);
            this.Controls.Add(this.btnOrderDelete);
            this.Controls.Add(this.btnOrderAdd);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgrPoints);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.lstOrders);
            this.Name = "frmMain";
            this.Text = "Rennovation";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgrPoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.Button btnOrderEdit;
        private System.Windows.Forms.Button btnOrderDelete;
        private System.Windows.Forms.Button btnOrderAdd;
        private System.Windows.Forms.TextBox txtOrderInfo;
        private System.Windows.Forms.Button btnPointEdit;
        private System.Windows.Forms.Button btnPointDelete;
        private System.Windows.Forms.Button btnPointAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorktype;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
    }
}

