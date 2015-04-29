namespace Rennovation
{
    partial class frmReference
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
            this.tbcTabs = new System.Windows.Forms.TabControl();
            this.tabWorkers = new System.Windows.Forms.TabPage();
            this.dgrSpecials = new System.Windows.Forms.DataGridView();
            this.colSpecialObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecialWorktype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecialQual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSpecialEdit = new System.Windows.Forms.Button();
            this.btnSpecialDelete = new System.Windows.Forms.Button();
            this.btnSpecialAdd = new System.Windows.Forms.Button();
            this.lblSpecials = new System.Windows.Forms.Label();
            this.txtWorkerInfo = new System.Windows.Forms.TextBox();
            this.lblWorkerInfo = new System.Windows.Forms.Label();
            this.btnWorkerEdit = new System.Windows.Forms.Button();
            this.btnWorkerDelete = new System.Windows.Forms.Button();
            this.btnWorkerAdd = new System.Windows.Forms.Button();
            this.lblWorkers = new System.Windows.Forms.Label();
            this.lstWorkers = new System.Windows.Forms.ListBox();
            this.tabWorktypes = new System.Windows.Forms.TabPage();
            this.dgrQuals = new System.Windows.Forms.DataGridView();
            this.colQualName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQualObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQualLValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQualValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrLevels = new System.Windows.Forms.DataGridView();
            this.colLevelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLevelObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLevelValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQualEdit = new System.Windows.Forms.Button();
            this.btnLevelEdit = new System.Windows.Forms.Button();
            this.btnWorktypeEdit = new System.Windows.Forms.Button();
            this.btnQualDelete = new System.Windows.Forms.Button();
            this.btnLevelDelete = new System.Windows.Forms.Button();
            this.btnWorktypeDelete = new System.Windows.Forms.Button();
            this.btnQualAdd = new System.Windows.Forms.Button();
            this.btnLevelAdd = new System.Windows.Forms.Button();
            this.btnWorktypeAdd = new System.Windows.Forms.Button();
            this.lblQuals = new System.Windows.Forms.Label();
            this.lblLevels = new System.Windows.Forms.Label();
            this.lblWorktypes = new System.Windows.Forms.Label();
            this.lstWorktypes = new System.Windows.Forms.ListBox();
            this.tabClients = new System.Windows.Forms.TabPage();
            this.txtCustomerInfo = new System.Windows.Forms.TextBox();
            this.btnCustomerEdit = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.tbcTabs.SuspendLayout();
            this.tabWorkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSpecials)).BeginInit();
            this.tabWorktypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrQuals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrLevels)).BeginInit();
            this.tabClients.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcTabs
            // 
            this.tbcTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcTabs.Controls.Add(this.tabWorkers);
            this.tbcTabs.Controls.Add(this.tabWorktypes);
            this.tbcTabs.Controls.Add(this.tabClients);
            this.tbcTabs.Location = new System.Drawing.Point(12, 14);
            this.tbcTabs.Name = "tbcTabs";
            this.tbcTabs.SelectedIndex = 0;
            this.tbcTabs.Size = new System.Drawing.Size(616, 385);
            this.tbcTabs.TabIndex = 1;
            // 
            // tabWorkers
            // 
            this.tabWorkers.Controls.Add(this.dgrSpecials);
            this.tabWorkers.Controls.Add(this.btnSpecialEdit);
            this.tabWorkers.Controls.Add(this.btnSpecialDelete);
            this.tabWorkers.Controls.Add(this.btnSpecialAdd);
            this.tabWorkers.Controls.Add(this.lblSpecials);
            this.tabWorkers.Controls.Add(this.txtWorkerInfo);
            this.tabWorkers.Controls.Add(this.lblWorkerInfo);
            this.tabWorkers.Controls.Add(this.btnWorkerEdit);
            this.tabWorkers.Controls.Add(this.btnWorkerDelete);
            this.tabWorkers.Controls.Add(this.btnWorkerAdd);
            this.tabWorkers.Controls.Add(this.lblWorkers);
            this.tabWorkers.Controls.Add(this.lstWorkers);
            this.tabWorkers.Location = new System.Drawing.Point(4, 22);
            this.tabWorkers.Name = "tabWorkers";
            this.tabWorkers.Padding = new System.Windows.Forms.Padding(3);
            this.tabWorkers.Size = new System.Drawing.Size(608, 359);
            this.tabWorkers.TabIndex = 0;
            this.tabWorkers.Text = "Работники";
            this.tabWorkers.UseVisualStyleBackColor = true;
            // 
            // dgrSpecials
            // 
            this.dgrSpecials.AllowUserToAddRows = false;
            this.dgrSpecials.AllowUserToDeleteRows = false;
            this.dgrSpecials.AllowUserToResizeRows = false;
            this.dgrSpecials.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgrSpecials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrSpecials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSpecialObj,
            this.colSpecialWorktype,
            this.colSpecialQual});
            this.dgrSpecials.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgrSpecials.Location = new System.Drawing.Point(186, 177);
            this.dgrSpecials.MultiSelect = false;
            this.dgrSpecials.Name = "dgrSpecials";
            this.dgrSpecials.ReadOnly = true;
            this.dgrSpecials.RowHeadersWidth = 4;
            this.dgrSpecials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrSpecials.Size = new System.Drawing.Size(309, 176);
            this.dgrSpecials.TabIndex = 45;
            this.dgrSpecials.SelectionChanged += new System.EventHandler(this.dgrSpecials_SelectionChanged);
            // 
            // colSpecialObj
            // 
            this.colSpecialObj.HeaderText = "Column3";
            this.colSpecialObj.Name = "colSpecialObj";
            this.colSpecialObj.ReadOnly = true;
            this.colSpecialObj.Visible = false;
            this.colSpecialObj.Width = 130;
            // 
            // colSpecialWorktype
            // 
            this.colSpecialWorktype.HeaderText = "Тип работы";
            this.colSpecialWorktype.Name = "colSpecialWorktype";
            this.colSpecialWorktype.ReadOnly = true;
            this.colSpecialWorktype.Width = 130;
            // 
            // colSpecialQual
            // 
            this.colSpecialQual.HeaderText = "Название квалификации";
            this.colSpecialQual.Name = "colSpecialQual";
            this.colSpecialQual.ReadOnly = true;
            this.colSpecialQual.Width = 170;
            // 
            // btnSpecialEdit
            // 
            this.btnSpecialEdit.Location = new System.Drawing.Point(501, 206);
            this.btnSpecialEdit.Name = "btnSpecialEdit";
            this.btnSpecialEdit.Size = new System.Drawing.Size(101, 23);
            this.btnSpecialEdit.TabIndex = 44;
            this.btnSpecialEdit.Text = "Редактировать";
            this.btnSpecialEdit.UseVisualStyleBackColor = true;
            // 
            // btnSpecialDelete
            // 
            this.btnSpecialDelete.Location = new System.Drawing.Point(501, 235);
            this.btnSpecialDelete.Name = "btnSpecialDelete";
            this.btnSpecialDelete.Size = new System.Drawing.Size(101, 23);
            this.btnSpecialDelete.TabIndex = 43;
            this.btnSpecialDelete.Text = "Удалить";
            this.btnSpecialDelete.UseVisualStyleBackColor = true;
            // 
            // btnSpecialAdd
            // 
            this.btnSpecialAdd.Location = new System.Drawing.Point(501, 177);
            this.btnSpecialAdd.Name = "btnSpecialAdd";
            this.btnSpecialAdd.Size = new System.Drawing.Size(101, 23);
            this.btnSpecialAdd.TabIndex = 42;
            this.btnSpecialAdd.Text = "Добавить";
            this.btnSpecialAdd.UseVisualStyleBackColor = true;
            // 
            // lblSpecials
            // 
            this.lblSpecials.AutoSize = true;
            this.lblSpecials.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSpecials.Location = new System.Drawing.Point(183, 161);
            this.lblSpecials.Name = "lblSpecials";
            this.lblSpecials.Size = new System.Drawing.Size(151, 13);
            this.lblSpecials.TabIndex = 41;
            this.lblSpecials.Text = "Записи о квалификации";
            // 
            // txtWorkerInfo
            // 
            this.txtWorkerInfo.Location = new System.Drawing.Point(186, 38);
            this.txtWorkerInfo.Multiline = true;
            this.txtWorkerInfo.Name = "txtWorkerInfo";
            this.txtWorkerInfo.ReadOnly = true;
            this.txtWorkerInfo.Size = new System.Drawing.Size(416, 120);
            this.txtWorkerInfo.TabIndex = 40;
            // 
            // lblWorkerInfo
            // 
            this.lblWorkerInfo.AutoSize = true;
            this.lblWorkerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkerInfo.Location = new System.Drawing.Point(183, 22);
            this.lblWorkerInfo.Name = "lblWorkerInfo";
            this.lblWorkerInfo.Size = new System.Drawing.Size(83, 13);
            this.lblWorkerInfo.TabIndex = 39;
            this.lblWorkerInfo.Text = "Информация";
            // 
            // btnWorkerEdit
            // 
            this.btnWorkerEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWorkerEdit.Location = new System.Drawing.Point(79, 330);
            this.btnWorkerEdit.Name = "btnWorkerEdit";
            this.btnWorkerEdit.Size = new System.Drawing.Size(101, 23);
            this.btnWorkerEdit.TabIndex = 38;
            this.btnWorkerEdit.Text = "Редактировать";
            this.btnWorkerEdit.UseVisualStyleBackColor = true;
            this.btnWorkerEdit.Click += new System.EventHandler(this.btnWorkerEdit_Click);
            // 
            // btnWorkerDelete
            // 
            this.btnWorkerDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWorkerDelete.Location = new System.Drawing.Point(6, 330);
            this.btnWorkerDelete.Name = "btnWorkerDelete";
            this.btnWorkerDelete.Size = new System.Drawing.Size(67, 23);
            this.btnWorkerDelete.TabIndex = 37;
            this.btnWorkerDelete.Text = "Удалить";
            this.btnWorkerDelete.UseVisualStyleBackColor = true;
            this.btnWorkerDelete.Click += new System.EventHandler(this.btnWorkerDelete_Click);
            // 
            // btnWorkerAdd
            // 
            this.btnWorkerAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWorkerAdd.Location = new System.Drawing.Point(6, 301);
            this.btnWorkerAdd.Name = "btnWorkerAdd";
            this.btnWorkerAdd.Size = new System.Drawing.Size(174, 23);
            this.btnWorkerAdd.TabIndex = 36;
            this.btnWorkerAdd.Text = "Добавить";
            this.btnWorkerAdd.UseVisualStyleBackColor = true;
            this.btnWorkerAdd.Click += new System.EventHandler(this.btnWorkerAdd_Click);
            // 
            // lblWorkers
            // 
            this.lblWorkers.AutoSize = true;
            this.lblWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorkers.Location = new System.Drawing.Point(3, 22);
            this.lblWorkers.Name = "lblWorkers";
            this.lblWorkers.Size = new System.Drawing.Size(70, 13);
            this.lblWorkers.TabIndex = 35;
            this.lblWorkers.Text = "Работники";
            // 
            // lstWorkers
            // 
            this.lstWorkers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstWorkers.FormattingEnabled = true;
            this.lstWorkers.IntegralHeight = false;
            this.lstWorkers.Location = new System.Drawing.Point(6, 38);
            this.lstWorkers.Name = "lstWorkers";
            this.lstWorkers.Size = new System.Drawing.Size(174, 257);
            this.lstWorkers.TabIndex = 34;
            this.lstWorkers.SelectedIndexChanged += new System.EventHandler(this.lstWorkers_SelectedIndexChanged);
            // 
            // tabWorktypes
            // 
            this.tabWorktypes.Controls.Add(this.dgrQuals);
            this.tabWorktypes.Controls.Add(this.dgrLevels);
            this.tabWorktypes.Controls.Add(this.btnQualEdit);
            this.tabWorktypes.Controls.Add(this.btnLevelEdit);
            this.tabWorktypes.Controls.Add(this.btnWorktypeEdit);
            this.tabWorktypes.Controls.Add(this.btnQualDelete);
            this.tabWorktypes.Controls.Add(this.btnLevelDelete);
            this.tabWorktypes.Controls.Add(this.btnWorktypeDelete);
            this.tabWorktypes.Controls.Add(this.btnQualAdd);
            this.tabWorktypes.Controls.Add(this.btnLevelAdd);
            this.tabWorktypes.Controls.Add(this.btnWorktypeAdd);
            this.tabWorktypes.Controls.Add(this.lblQuals);
            this.tabWorktypes.Controls.Add(this.lblLevels);
            this.tabWorktypes.Controls.Add(this.lblWorktypes);
            this.tabWorktypes.Controls.Add(this.lstWorktypes);
            this.tabWorktypes.Location = new System.Drawing.Point(4, 22);
            this.tabWorktypes.Name = "tabWorktypes";
            this.tabWorktypes.Padding = new System.Windows.Forms.Padding(3);
            this.tabWorktypes.Size = new System.Drawing.Size(608, 359);
            this.tabWorktypes.TabIndex = 1;
            this.tabWorktypes.Text = "Работы";
            this.tabWorktypes.UseVisualStyleBackColor = true;
            // 
            // dgrQuals
            // 
            this.dgrQuals.AllowUserToAddRows = false;
            this.dgrQuals.AllowUserToDeleteRows = false;
            this.dgrQuals.AllowUserToResizeRows = false;
            this.dgrQuals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgrQuals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrQuals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colQualName,
            this.colQualObject,
            this.colQualLValue,
            this.colQualValue});
            this.dgrQuals.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgrQuals.Location = new System.Drawing.Point(186, 206);
            this.dgrQuals.MultiSelect = false;
            this.dgrQuals.Name = "dgrQuals";
            this.dgrQuals.ReadOnly = true;
            this.dgrQuals.RowHeadersWidth = 4;
            this.dgrQuals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrQuals.Size = new System.Drawing.Size(309, 147);
            this.dgrQuals.TabIndex = 35;
            this.dgrQuals.SelectionChanged += new System.EventHandler(this.dgrQuals_SelectionChanged);
            // 
            // colQualName
            // 
            this.colQualName.HeaderText = "Название";
            this.colQualName.Name = "colQualName";
            this.colQualName.ReadOnly = true;
            this.colQualName.Width = 120;
            // 
            // colQualObject
            // 
            this.colQualObject.HeaderText = "Column3";
            this.colQualObject.Name = "colQualObject";
            this.colQualObject.ReadOnly = true;
            this.colQualObject.Visible = false;
            // 
            // colQualLValue
            // 
            this.colQualLValue.HeaderText = "Показатель";
            this.colQualLValue.Name = "colQualLValue";
            this.colQualLValue.ReadOnly = true;
            this.colQualLValue.Width = 70;
            // 
            // colQualValue
            // 
            this.colQualValue.HeaderText = "Оплата в час";
            this.colQualValue.Name = "colQualValue";
            this.colQualValue.ReadOnly = true;
            // 
            // dgrLevels
            // 
            this.dgrLevels.AllowUserToAddRows = false;
            this.dgrLevels.AllowUserToDeleteRows = false;
            this.dgrLevels.AllowUserToResizeRows = false;
            this.dgrLevels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrLevels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLevelName,
            this.colLevelObject,
            this.colLevelValue});
            this.dgrLevels.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgrLevels.Location = new System.Drawing.Point(186, 38);
            this.dgrLevels.MultiSelect = false;
            this.dgrLevels.Name = "dgrLevels";
            this.dgrLevels.ReadOnly = true;
            this.dgrLevels.RowHeadersWidth = 4;
            this.dgrLevels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrLevels.Size = new System.Drawing.Size(309, 147);
            this.dgrLevels.TabIndex = 34;
            this.dgrLevels.SelectionChanged += new System.EventHandler(this.dgrLevels_SelectionChanged);
            // 
            // colLevelName
            // 
            this.colLevelName.HeaderText = "Название";
            this.colLevelName.Name = "colLevelName";
            this.colLevelName.ReadOnly = true;
            this.colLevelName.Width = 220;
            // 
            // colLevelObject
            // 
            this.colLevelObject.HeaderText = "Column3";
            this.colLevelObject.Name = "colLevelObject";
            this.colLevelObject.ReadOnly = true;
            this.colLevelObject.Visible = false;
            // 
            // colLevelLValue
            // 
            this.colLevelValue.HeaderText = "Показатель";
            this.colLevelValue.Name = "colLevelLValue";
            this.colLevelValue.ReadOnly = true;
            this.colLevelValue.Width = 70;
            // 
            // btnQualEdit
            // 
            this.btnQualEdit.Location = new System.Drawing.Point(501, 235);
            this.btnQualEdit.Name = "btnQualEdit";
            this.btnQualEdit.Size = new System.Drawing.Size(101, 23);
            this.btnQualEdit.TabIndex = 33;
            this.btnQualEdit.Text = "Редактировать";
            this.btnQualEdit.UseVisualStyleBackColor = true;
            this.btnQualEdit.Click += new System.EventHandler(this.btnQualEdit_Click);
            // 
            // btnLevelEdit
            // 
            this.btnLevelEdit.Location = new System.Drawing.Point(501, 67);
            this.btnLevelEdit.Name = "btnLevelEdit";
            this.btnLevelEdit.Size = new System.Drawing.Size(101, 23);
            this.btnLevelEdit.TabIndex = 33;
            this.btnLevelEdit.Text = "Редактировать";
            this.btnLevelEdit.UseVisualStyleBackColor = true;
            this.btnLevelEdit.Click += new System.EventHandler(this.btnLevelEdit_Click);
            // 
            // btnWorktypeEdit
            // 
            this.btnWorktypeEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWorktypeEdit.Location = new System.Drawing.Point(79, 330);
            this.btnWorktypeEdit.Name = "btnWorktypeEdit";
            this.btnWorktypeEdit.Size = new System.Drawing.Size(101, 23);
            this.btnWorktypeEdit.TabIndex = 33;
            this.btnWorktypeEdit.Text = "Редактировать";
            this.btnWorktypeEdit.UseVisualStyleBackColor = true;
            this.btnWorktypeEdit.Click += new System.EventHandler(this.btnWorktypeEdit_Click);
            // 
            // btnQualDelete
            // 
            this.btnQualDelete.Location = new System.Drawing.Point(501, 264);
            this.btnQualDelete.Name = "btnQualDelete";
            this.btnQualDelete.Size = new System.Drawing.Size(101, 23);
            this.btnQualDelete.TabIndex = 32;
            this.btnQualDelete.Text = "Удалить";
            this.btnQualDelete.UseVisualStyleBackColor = true;
            this.btnQualDelete.Click += new System.EventHandler(this.btnQualDelete_Click);
            // 
            // btnLevelDelete
            // 
            this.btnLevelDelete.Location = new System.Drawing.Point(501, 96);
            this.btnLevelDelete.Name = "btnLevelDelete";
            this.btnLevelDelete.Size = new System.Drawing.Size(101, 23);
            this.btnLevelDelete.TabIndex = 32;
            this.btnLevelDelete.Text = "Удалить";
            this.btnLevelDelete.UseVisualStyleBackColor = true;
            this.btnLevelDelete.Click += new System.EventHandler(this.btnLevelDelete_Click);
            // 
            // btnWorktypeDelete
            // 
            this.btnWorktypeDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWorktypeDelete.Location = new System.Drawing.Point(6, 330);
            this.btnWorktypeDelete.Name = "btnWorktypeDelete";
            this.btnWorktypeDelete.Size = new System.Drawing.Size(67, 23);
            this.btnWorktypeDelete.TabIndex = 32;
            this.btnWorktypeDelete.Text = "Удалить";
            this.btnWorktypeDelete.UseVisualStyleBackColor = true;
            this.btnWorktypeDelete.Click += new System.EventHandler(this.btnWorktypeDelete_Click);
            // 
            // btnQualAdd
            // 
            this.btnQualAdd.Location = new System.Drawing.Point(501, 206);
            this.btnQualAdd.Name = "btnQualAdd";
            this.btnQualAdd.Size = new System.Drawing.Size(101, 23);
            this.btnQualAdd.TabIndex = 31;
            this.btnQualAdd.Text = "Добавить";
            this.btnQualAdd.UseVisualStyleBackColor = true;
            this.btnQualAdd.Click += new System.EventHandler(this.btnQualAdd_Click);
            // 
            // btnLevelAdd
            // 
            this.btnLevelAdd.Location = new System.Drawing.Point(501, 38);
            this.btnLevelAdd.Name = "btnLevelAdd";
            this.btnLevelAdd.Size = new System.Drawing.Size(101, 23);
            this.btnLevelAdd.TabIndex = 31;
            this.btnLevelAdd.Text = "Добавить";
            this.btnLevelAdd.UseVisualStyleBackColor = true;
            this.btnLevelAdd.Click += new System.EventHandler(this.btnLevelAdd_Click);
            // 
            // btnWorktypeAdd
            // 
            this.btnWorktypeAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnWorktypeAdd.Location = new System.Drawing.Point(6, 301);
            this.btnWorktypeAdd.Name = "btnWorktypeAdd";
            this.btnWorktypeAdd.Size = new System.Drawing.Size(174, 23);
            this.btnWorktypeAdd.TabIndex = 31;
            this.btnWorktypeAdd.Text = "Добавить";
            this.btnWorktypeAdd.UseVisualStyleBackColor = true;
            this.btnWorktypeAdd.Click += new System.EventHandler(this.btnWorktypeAdd_Click);
            // 
            // lblQuals
            // 
            this.lblQuals.AutoSize = true;
            this.lblQuals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuals.Location = new System.Drawing.Point(183, 190);
            this.lblQuals.Name = "lblQuals";
            this.lblQuals.Size = new System.Drawing.Size(94, 13);
            this.lblQuals.TabIndex = 30;
            this.lblQuals.Text = "Квалификации";
            // 
            // lblLevels
            // 
            this.lblLevels.AutoSize = true;
            this.lblLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLevels.Location = new System.Drawing.Point(183, 22);
            this.lblLevels.Name = "lblLevels";
            this.lblLevels.Size = new System.Drawing.Size(109, 13);
            this.lblLevels.TabIndex = 30;
            this.lblLevels.Text = "Уровни качества";
            // 
            // lblWorktypes
            // 
            this.lblWorktypes.AutoSize = true;
            this.lblWorktypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWorktypes.Location = new System.Drawing.Point(3, 22);
            this.lblWorktypes.Name = "lblWorktypes";
            this.lblWorktypes.Size = new System.Drawing.Size(51, 13);
            this.lblWorktypes.TabIndex = 29;
            this.lblWorktypes.Text = "Работы";
            // 
            // lstWorktypes
            // 
            this.lstWorktypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstWorktypes.FormattingEnabled = true;
            this.lstWorktypes.IntegralHeight = false;
            this.lstWorktypes.Location = new System.Drawing.Point(6, 38);
            this.lstWorktypes.Name = "lstWorktypes";
            this.lstWorktypes.Size = new System.Drawing.Size(174, 257);
            this.lstWorktypes.TabIndex = 28;
            this.lstWorktypes.SelectedIndexChanged += new System.EventHandler(this.lstWorktypes_SelectedIndexChanged);
            // 
            // tabClients
            // 
            this.tabClients.Controls.Add(this.txtCustomerInfo);
            this.tabClients.Controls.Add(this.btnCustomerEdit);
            this.tabClients.Controls.Add(this.btnCustomerDelete);
            this.tabClients.Controls.Add(this.btnCustomerAdd);
            this.tabClients.Controls.Add(this.lblCustomerInfo);
            this.tabClients.Controls.Add(this.lblCustomers);
            this.tabClients.Controls.Add(this.lstCustomers);
            this.tabClients.Location = new System.Drawing.Point(4, 22);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabClients.Size = new System.Drawing.Size(608, 359);
            this.tabClients.TabIndex = 2;
            this.tabClients.Text = "Клиенты";
            this.tabClients.UseVisualStyleBackColor = true;
            // 
            // txtCustomerInfo
            // 
            this.txtCustomerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCustomerInfo.Location = new System.Drawing.Point(186, 38);
            this.txtCustomerInfo.Multiline = true;
            this.txtCustomerInfo.Name = "txtCustomerInfo";
            this.txtCustomerInfo.ReadOnly = true;
            this.txtCustomerInfo.Size = new System.Drawing.Size(416, 315);
            this.txtCustomerInfo.TabIndex = 27;
            // 
            // btnCustomerEdit
            // 
            this.btnCustomerEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCustomerEdit.Location = new System.Drawing.Point(79, 330);
            this.btnCustomerEdit.Name = "btnCustomerEdit";
            this.btnCustomerEdit.Size = new System.Drawing.Size(101, 23);
            this.btnCustomerEdit.TabIndex = 26;
            this.btnCustomerEdit.Text = "Редактировать";
            this.btnCustomerEdit.UseVisualStyleBackColor = true;
            this.btnCustomerEdit.Click += new System.EventHandler(this.btnClientEdit_Click);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCustomerDelete.Location = new System.Drawing.Point(6, 330);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(67, 23);
            this.btnCustomerDelete.TabIndex = 25;
            this.btnCustomerDelete.Text = "Удалить";
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnClientDelete_Click);
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCustomerAdd.Location = new System.Drawing.Point(6, 301);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(174, 23);
            this.btnCustomerAdd.TabIndex = 24;
            this.btnCustomerAdd.Text = "Добавить";
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnClientAdd_Click);
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.AutoSize = true;
            this.lblCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCustomerInfo.Location = new System.Drawing.Point(183, 22);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(83, 13);
            this.lblCustomerInfo.TabIndex = 23;
            this.lblCustomerInfo.Text = "Информация";
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCustomers.Location = new System.Drawing.Point(3, 22);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(58, 13);
            this.lblCustomers.TabIndex = 21;
            this.lblCustomers.Text = "Клиенты";
            // 
            // lstCustomers
            // 
            this.lstCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.IntegralHeight = false;
            this.lstCustomers.Location = new System.Drawing.Point(6, 38);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(174, 257);
            this.lstCustomers.TabIndex = 20;
            this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
            // 
            // frmReference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 411);
            this.Controls.Add(this.tbcTabs);
            this.MaximumSize = new System.Drawing.Size(656, 1080);
            this.MinimumSize = new System.Drawing.Size(656, 450);
            this.Name = "frmReference";
            this.Text = "Справочники";
            this.Shown += new System.EventHandler(this.frmReference_Shown);
            this.tbcTabs.ResumeLayout(false);
            this.tabWorkers.ResumeLayout(false);
            this.tabWorkers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSpecials)).EndInit();
            this.tabWorktypes.ResumeLayout(false);
            this.tabWorktypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrQuals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrLevels)).EndInit();
            this.tabClients.ResumeLayout(false);
            this.tabClients.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcTabs;
        private System.Windows.Forms.TabPage tabWorkers;
        private System.Windows.Forms.TabPage tabWorktypes;
        private System.Windows.Forms.TabPage tabClients;
        private System.Windows.Forms.Button btnCustomerEdit;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.Label lblCustomerInfo;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.TextBox txtCustomerInfo;
        private System.Windows.Forms.Button btnWorktypeEdit;
        private System.Windows.Forms.Button btnWorktypeDelete;
        private System.Windows.Forms.Button btnWorktypeAdd;
        private System.Windows.Forms.Label lblLevels;
        private System.Windows.Forms.Label lblWorktypes;
        private System.Windows.Forms.ListBox lstWorktypes;
        private System.Windows.Forms.DataGridView dgrLevels;
        private System.Windows.Forms.Button btnQualEdit;
        private System.Windows.Forms.Button btnLevelEdit;
        private System.Windows.Forms.Button btnQualDelete;
        private System.Windows.Forms.Button btnLevelDelete;
        private System.Windows.Forms.Button btnQualAdd;
        private System.Windows.Forms.Button btnLevelAdd;
        private System.Windows.Forms.Label lblQuals;
        private System.Windows.Forms.DataGridView dgrQuals;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQualName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQualObject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQualLValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQualValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevelObject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLevelValue;
        private System.Windows.Forms.TextBox txtWorkerInfo;
        private System.Windows.Forms.Label lblWorkerInfo;
        private System.Windows.Forms.Button btnWorkerEdit;
        private System.Windows.Forms.Button btnWorkerDelete;
        private System.Windows.Forms.Button btnWorkerAdd;
        private System.Windows.Forms.Label lblWorkers;
        private System.Windows.Forms.ListBox lstWorkers;
        private System.Windows.Forms.DataGridView dgrSpecials;
        private System.Windows.Forms.Button btnSpecialEdit;
        private System.Windows.Forms.Button btnSpecialDelete;
        private System.Windows.Forms.Button btnSpecialAdd;
        private System.Windows.Forms.Label lblSpecials;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecialObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecialWorktype;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecialQual;
    }
}