namespace Baran.Ferroalloy.Management
{
    partial class SelectStuff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btmSelect = new System.Windows.Forms.Button();
            this.dgvStuffs = new System.Windows.Forms.DataGridView();
            this.labCode = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTypes = new System.Windows.Forms.ComboBox();
            this.cbMaterials = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSections = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStores = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btmSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btmInsertStuff = new System.Windows.Forms.Button();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.intCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intCategoryAsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcStoreAsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcSectionAsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcMaterialAsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcTypeAsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcMeasurementUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcMeasurementUnitAsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floOrderPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floSupply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuffs)).BeginInit();
            this.SuspendLayout();
            // 
            // btmSelect
            // 
            this.btmSelect.Enabled = false;
            this.btmSelect.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmSelect.Location = new System.Drawing.Point(321, 477);
            this.btmSelect.Margin = new System.Windows.Forms.Padding(0);
            this.btmSelect.Name = "btmSelect";
            this.btmSelect.Size = new System.Drawing.Size(125, 33);
            this.btmSelect.TabIndex = 4;
            this.btmSelect.Text = "انتخاب";
            this.btmSelect.UseVisualStyleBackColor = true;
            this.btmSelect.Click += new System.EventHandler(this.BtmSelect_Click);
            // 
            // dgvStuffs
            // 
            this.dgvStuffs.AllowUserToAddRows = false;
            this.dgvStuffs.AllowUserToDeleteRows = false;
            this.dgvStuffs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStuffs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.125F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStuffs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStuffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStuffs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.bitSelect,
            this.intCategory,
            this.intCategoryAsName,
            this.nvcStore,
            this.nvcStoreAsName,
            this.nvcSection,
            this.nvcSectionAsName,
            this.nvcMaterial,
            this.nvcMaterialAsName,
            this.nvcType,
            this.nvcTypeAsName,
            this.nvcMeasurementUnit,
            this.nvcMeasurementUnitAsName,
            this.floOrderPoint,
            this.floSupply});
            this.dgvStuffs.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvStuffs.Location = new System.Drawing.Point(84, 188);
            this.dgvStuffs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStuffs.Name = "dgvStuffs";
            this.dgvStuffs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvStuffs.RowTemplate.Height = 55;
            this.dgvStuffs.Size = new System.Drawing.Size(743, 228);
            this.dgvStuffs.TabIndex = 0;
            this.dgvStuffs.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvStuffs_CellMouseClick);
            this.dgvStuffs.Sorted += new System.EventHandler(this.DgvStuffs_Sorted);
            // 
            // labCode
            // 
            this.labCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labCode.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.labCode.Location = new System.Drawing.Point(492, 93);
            this.labCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(300, 24);
            this.labCode.TabIndex = 33;
            // 
            // labName
            // 
            this.labName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labName.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.labName.Location = new System.Drawing.Point(158, 93);
            this.labName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(300, 24);
            this.labName.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label8.Location = new System.Drawing.Point(466, 95);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "کد:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label7.Location = new System.Drawing.Point(131, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "نام:";
            // 
            // cbTypes
            // 
            this.cbTypes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypes.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Location = new System.Drawing.Point(721, 46);
            this.cbTypes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(150, 24);
            this.cbTypes.TabIndex = 29;
            this.cbTypes.SelectedIndexChanged += new System.EventHandler(this.CbTypes_SelectedIndexChanged);
            // 
            // cbMaterials
            // 
            this.cbMaterials.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMaterials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaterials.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.cbMaterials.FormattingEnabled = true;
            this.cbMaterials.Location = new System.Drawing.Point(508, 45);
            this.cbMaterials.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMaterials.Name = "cbMaterials";
            this.cbMaterials.Size = new System.Drawing.Size(150, 24);
            this.cbMaterials.TabIndex = 28;
            this.cbMaterials.SelectedIndexChanged += new System.EventHandler(this.CbMaterials_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label5.Location = new System.Drawing.Point(475, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "کالا:";
            // 
            // cbSections
            // 
            this.cbSections.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSections.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.cbSections.FormattingEnabled = true;
            this.cbSections.Location = new System.Drawing.Point(296, 45);
            this.cbSections.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSections.Name = "cbSections";
            this.cbSections.Size = new System.Drawing.Size(150, 24);
            this.cbSections.TabIndex = 25;
            this.cbSections.SelectedIndexChanged += new System.EventHandler(this.CbSections_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label3.Location = new System.Drawing.Point(250, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "بخش:";
            // 
            // cbStores
            // 
            this.cbStores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStores.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.cbStores.FormattingEnabled = true;
            this.cbStores.Location = new System.Drawing.Point(78, 45);
            this.cbStores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbStores.Name = "cbStores";
            this.cbStores.Size = new System.Drawing.Size(150, 24);
            this.cbStores.TabIndex = 26;
            this.cbStores.SelectedIndexChanged += new System.EventHandler(this.CbStores_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label2.Location = new System.Drawing.Point(44, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "انبار:";
            // 
            // btmSearch
            // 
            this.btmSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btmSearch.Enabled = false;
            this.btmSearch.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmSearch.Location = new System.Drawing.Point(672, 132);
            this.btmSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btmSearch.Name = "btmSearch";
            this.btmSearch.Size = new System.Drawing.Size(125, 33);
            this.btmSearch.TabIndex = 20;
            this.btmSearch.Text = "جستجو";
            this.btmSearch.UseVisualStyleBackColor = true;
            this.btmSearch.Click += new System.EventHandler(this.btmSearch_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label4.Location = new System.Drawing.Point(689, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "نوع:";
            // 
            // btmInsertStuff
            // 
            this.btmInsertStuff.Location = new System.Drawing.Point(465, 477);
            this.btmInsertStuff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btmInsertStuff.Name = "btmInsertStuff";
            this.btmInsertStuff.Size = new System.Drawing.Size(125, 35);
            this.btmInsertStuff.TabIndex = 34;
            this.btmInsertStuff.Text = "ورود کالا";
            this.btmInsertStuff.UseVisualStyleBackColor = true;
            this.btmInsertStuff.Click += new System.EventHandler(this.BtmInsertStuff_Click);
            // 
            // intID
            // 
            this.intID.DataPropertyName = "intID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intID.DefaultCellStyle = dataGridViewCellStyle2;
            this.intID.HeaderText = "intID";
            this.intID.MinimumWidth = 10;
            this.intID.Name = "intID";
            this.intID.Visible = false;
            this.intID.Width = 62;
            // 
            // bitSelect
            // 
            this.bitSelect.DataPropertyName = "bitSelect";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = false;
            this.bitSelect.DefaultCellStyle = dataGridViewCellStyle3;
            this.bitSelect.HeaderText = "انتخاب";
            this.bitSelect.MinimumWidth = 10;
            this.bitSelect.Name = "bitSelect";
            this.bitSelect.Visible = false;
            this.bitSelect.Width = 51;
            // 
            // intCategory
            // 
            this.intCategory.DataPropertyName = "intCategory";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intCategory.DefaultCellStyle = dataGridViewCellStyle4;
            this.intCategory.HeaderText = "شماره رسته";
            this.intCategory.MinimumWidth = 10;
            this.intCategory.Name = "intCategory";
            this.intCategory.ReadOnly = true;
            this.intCategory.ToolTipText = "شماره رسته";
            this.intCategory.Visible = false;
            this.intCategory.Width = 108;
            // 
            // intCategoryAsName
            // 
            this.intCategoryAsName.DataPropertyName = "intCategoryAsName";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intCategoryAsName.DefaultCellStyle = dataGridViewCellStyle5;
            this.intCategoryAsName.HeaderText = "رسته";
            this.intCategoryAsName.MinimumWidth = 10;
            this.intCategoryAsName.Name = "intCategoryAsName";
            this.intCategoryAsName.ToolTipText = "رسته";
            this.intCategoryAsName.Width = 65;
            // 
            // nvcStore
            // 
            this.nvcStore.DataPropertyName = "nvcStore";
            this.nvcStore.HeaderText = "کد انبار";
            this.nvcStore.MinimumWidth = 10;
            this.nvcStore.Name = "nvcStore";
            this.nvcStore.ToolTipText = "کد انبار";
            this.nvcStore.Visible = false;
            this.nvcStore.Width = 73;
            // 
            // nvcStoreAsName
            // 
            this.nvcStoreAsName.DataPropertyName = "nvcStoreAsName";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcStoreAsName.DefaultCellStyle = dataGridViewCellStyle6;
            this.nvcStoreAsName.HeaderText = "انبار";
            this.nvcStoreAsName.MinimumWidth = 10;
            this.nvcStoreAsName.Name = "nvcStoreAsName";
            this.nvcStoreAsName.ToolTipText = "انبار";
            this.nvcStoreAsName.Width = 54;
            // 
            // nvcSection
            // 
            this.nvcSection.DataPropertyName = "nvcSection";
            this.nvcSection.HeaderText = "کد بخش";
            this.nvcSection.MinimumWidth = 10;
            this.nvcSection.Name = "nvcSection";
            this.nvcSection.ToolTipText = "کد بخش";
            this.nvcSection.Visible = false;
            this.nvcSection.Width = 84;
            // 
            // nvcSectionAsName
            // 
            this.nvcSectionAsName.DataPropertyName = "nvcSectionAsName";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcSectionAsName.DefaultCellStyle = dataGridViewCellStyle7;
            this.nvcSectionAsName.HeaderText = "بخش";
            this.nvcSectionAsName.MinimumWidth = 10;
            this.nvcSectionAsName.Name = "nvcSectionAsName";
            this.nvcSectionAsName.ToolTipText = "بخش";
            this.nvcSectionAsName.Width = 65;
            // 
            // nvcMaterial
            // 
            this.nvcMaterial.DataPropertyName = "nvcMaterial";
            this.nvcMaterial.HeaderText = "کد کالا";
            this.nvcMaterial.MinimumWidth = 10;
            this.nvcMaterial.Name = "nvcMaterial";
            this.nvcMaterial.ToolTipText = "کد کالا";
            this.nvcMaterial.Visible = false;
            this.nvcMaterial.Width = 72;
            // 
            // nvcMaterialAsName
            // 
            this.nvcMaterialAsName.DataPropertyName = "nvcMaterialAsName";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcMaterialAsName.DefaultCellStyle = dataGridViewCellStyle8;
            this.nvcMaterialAsName.HeaderText = "کالا";
            this.nvcMaterialAsName.MinimumWidth = 10;
            this.nvcMaterialAsName.Name = "nvcMaterialAsName";
            this.nvcMaterialAsName.ToolTipText = "کالا";
            this.nvcMaterialAsName.Width = 53;
            // 
            // nvcType
            // 
            this.nvcType.DataPropertyName = "nvcType";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcType.DefaultCellStyle = dataGridViewCellStyle9;
            this.nvcType.HeaderText = "کد نوع";
            this.nvcType.MinimumWidth = 10;
            this.nvcType.Name = "nvcType";
            this.nvcType.ToolTipText = "کد نوع";
            this.nvcType.Visible = false;
            this.nvcType.Width = 70;
            // 
            // nvcTypeAsName
            // 
            this.nvcTypeAsName.DataPropertyName = "nvcTypeAsName";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcTypeAsName.DefaultCellStyle = dataGridViewCellStyle10;
            this.nvcTypeAsName.HeaderText = "نوع";
            this.nvcTypeAsName.MinimumWidth = 10;
            this.nvcTypeAsName.Name = "nvcTypeAsName";
            this.nvcTypeAsName.ToolTipText = "نوع";
            this.nvcTypeAsName.Width = 51;
            // 
            // nvcMeasurementUnit
            // 
            this.nvcMeasurementUnit.DataPropertyName = "nvcMeasurementUnit";
            this.nvcMeasurementUnit.HeaderText = "کد واحد اندازه گیری";
            this.nvcMeasurementUnit.MinimumWidth = 10;
            this.nvcMeasurementUnit.Name = "nvcMeasurementUnit";
            this.nvcMeasurementUnit.ToolTipText = "کد واحد اندازه گیری";
            this.nvcMeasurementUnit.Visible = false;
            this.nvcMeasurementUnit.Width = 146;
            // 
            // nvcMeasurementUnitAsName
            // 
            this.nvcMeasurementUnitAsName.DataPropertyName = "nvcMeasurementUnitAsName";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcMeasurementUnitAsName.DefaultCellStyle = dataGridViewCellStyle11;
            this.nvcMeasurementUnitAsName.HeaderText = "واحد اندازه‌گیری";
            this.nvcMeasurementUnitAsName.MinimumWidth = 10;
            this.nvcMeasurementUnitAsName.Name = "nvcMeasurementUnitAsName";
            this.nvcMeasurementUnitAsName.ToolTipText = "واحد اندازه‌گیری";
            this.nvcMeasurementUnitAsName.Visible = false;
            this.nvcMeasurementUnitAsName.Width = 123;
            // 
            // floOrderPoint
            // 
            this.floOrderPoint.DataPropertyName = "floOrderPoint";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.floOrderPoint.DefaultCellStyle = dataGridViewCellStyle12;
            this.floOrderPoint.HeaderText = "نقطه سفارش";
            this.floOrderPoint.MinimumWidth = 10;
            this.floOrderPoint.Name = "floOrderPoint";
            this.floOrderPoint.ToolTipText = "نقطه سفارش";
            this.floOrderPoint.Visible = false;
            this.floOrderPoint.Width = 113;
            // 
            // floSupply
            // 
            this.floSupply.DataPropertyName = "floSupply";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.floSupply.DefaultCellStyle = dataGridViewCellStyle13;
            this.floSupply.HeaderText = "موجودی";
            this.floSupply.MinimumWidth = 10;
            this.floSupply.Name = "floSupply";
            this.floSupply.ToolTipText = "موجودی";
            this.floSupply.Visible = false;
            this.floSupply.Width = 80;
            // 
            // SelectStuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(914, 561);
            this.Controls.Add(this.btmInsertStuff);
            this.Controls.Add(this.dgvStuffs);
            this.Controls.Add(this.labCode);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbTypes);
            this.Controls.Add(this.cbMaterials);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbSections);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbStores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btmSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btmSelect);
            this.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectStuff";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "انتخاب کالا";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employees_FormClosing);
            this.Load += new System.EventHandler(this.Stuffs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStuffs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmSelect;
        private System.Windows.Forms.DataGridView dgvStuffs;
        private System.Windows.Forms.Label labCode;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTypes;
        private System.Windows.Forms.ComboBox cbMaterials;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSections;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btmSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btmInsertStuff;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bitSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn intCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn intCategoryAsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcStoreAsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcSectionAsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcMaterialAsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcType;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcTypeAsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcMeasurementUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcMeasurementUnitAsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn floOrderPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn floSupply;
    }
}