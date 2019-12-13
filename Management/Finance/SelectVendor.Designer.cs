namespace Baran.Ferroalloy.Management
{
    partial class SelectVendor
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
            this.cbNoName = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btmSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVendors = new System.Windows.Forms.DataGridView();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.intNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intCategoryAsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcActivityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcActivities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcTell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btmInsertVendor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendors)).BeginInit();
            this.SuspendLayout();
            // 
            // btmSelect
            // 
            this.btmSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmSelect.Enabled = false;
            this.btmSelect.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmSelect.Location = new System.Drawing.Point(467, 477);
            this.btmSelect.Margin = new System.Windows.Forms.Padding(0);
            this.btmSelect.Name = "btmSelect";
            this.btmSelect.Size = new System.Drawing.Size(109, 35);
            this.btmSelect.TabIndex = 4;
            this.btmSelect.Text = "انتخاب";
            this.btmSelect.UseVisualStyleBackColor = true;
            this.btmSelect.Click += new System.EventHandler(this.BtmSelect_Click);
            // 
            // cbNoName
            // 
            this.cbNoName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNoName.AutoSize = true;
            this.cbNoName.Location = new System.Drawing.Point(109, 139);
            this.cbNoName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbNoName.Name = "cbNoName";
            this.cbNoName.Size = new System.Drawing.Size(65, 21);
            this.cbNoName.TabIndex = 32;
            this.cbNoName.Text = "بی نام";
            this.cbNoName.UseVisualStyleBackColor = true;
            this.cbNoName.CheckedChanged += new System.EventHandler(this.CbNoName_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(596, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "شهر:";
            // 
            // tbCity
            // 
            this.tbCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCity.Location = new System.Drawing.Point(636, 87);
            this.tbCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCity.MaxLength = 20;
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(134, 24);
            this.tbCity.TabIndex = 28;
            this.tbCity.TextChanged += new System.EventHandler(this.TbCity_TextChanged);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFirstName.Location = new System.Drawing.Point(138, 88);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFirstName.MaxLength = 20;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(134, 24);
            this.tbFirstName.TabIndex = 29;
            this.tbFirstName.TextChanged += new System.EventHandler(this.TbFirstName_TextChanged);
            // 
            // tbLastName
            // 
            this.tbLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLastName.Location = new System.Drawing.Point(410, 88);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLastName.MaxLength = 20;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(134, 24);
            this.tbLastName.TabIndex = 30;
            this.tbLastName.TextChanged += new System.EventHandler(this.TbLastName_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "نام خانوادگی:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "نام:";
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(192, 42);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(134, 24);
            this.cbCategory.TabIndex = 25;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.CbCategory_SelectedIndexChanged);
            // 
            // tbBrand
            // 
            this.tbBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBrand.Location = new System.Drawing.Point(593, 41);
            this.tbBrand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbBrand.MaxLength = 20;
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbBrand.Size = new System.Drawing.Size(134, 24);
            this.tbBrand.TabIndex = 23;
            this.tbBrand.TextChanged += new System.EventHandler(this.TbBrand_TextChanged);
            // 
            // tbNumber
            // 
            this.tbNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumber.Location = new System.Drawing.Point(417, 41);
            this.tbNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNumber.MaxLength = 10;
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbNumber.Size = new System.Drawing.Size(104, 24);
            this.tbNumber.TabIndex = 24;
            this.tbNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNumber.TextChanged += new System.EventHandler(this.TbNumber_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "شماره:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "برند:";
            // 
            // btmSearch
            // 
            this.btmSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmSearch.Location = new System.Drawing.Point(683, 132);
            this.btmSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btmSearch.Name = "btmSearch";
            this.btmSearch.Size = new System.Drawing.Size(109, 35);
            this.btmSearch.TabIndex = 20;
            this.btmSearch.Text = "جستجو";
            this.btmSearch.UseVisualStyleBackColor = true;
            this.btmSearch.Click += new System.EventHandler(this.btmSearch_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "رسته:";
            // 
            // dgvVendors
            // 
            this.dgvVendors.AllowUserToAddRows = false;
            this.dgvVendors.AllowUserToDeleteRows = false;
            this.dgvVendors.AllowUserToOrderColumns = true;
            this.dgvVendors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVendors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVendors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.125F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVendors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.bitSelect,
            this.intNumber,
            this.intCategory,
            this.intCategoryAsName,
            this.nvcBrand,
            this.nvcActivityType,
            this.nvcActivities,
            this.nvcFirstName,
            this.nvcLastName,
            this.nvcTell,
            this.nvcCity,
            this.nvcAddress});
            this.dgvVendors.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvVendors.Location = new System.Drawing.Point(84, 188);
            this.dgvVendors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvVendors.MultiSelect = false;
            this.dgvVendors.Name = "dgvVendors";
            this.dgvVendors.ReadOnly = true;
            this.dgvVendors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvVendors.RowTemplate.Height = 55;
            this.dgvVendors.Size = new System.Drawing.Size(727, 228);
            this.dgvVendors.TabIndex = 33;
            this.dgvVendors.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvVendors_CellMouseClick);
            this.dgvVendors.Sorted += new System.EventHandler(this.DgvVendors_Sorted);
            // 
            // intID
            // 
            this.intID.DataPropertyName = "intID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intID.DefaultCellStyle = dataGridViewCellStyle2;
            this.intID.HeaderText = "intID";
            this.intID.MinimumWidth = 10;
            this.intID.Name = "intID";
            this.intID.ReadOnly = true;
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
            this.bitSelect.ReadOnly = true;
            this.bitSelect.Visible = false;
            this.bitSelect.Width = 51;
            // 
            // intNumber
            // 
            this.intNumber.DataPropertyName = "intNumber";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intNumber.DefaultCellStyle = dataGridViewCellStyle4;
            this.intNumber.HeaderText = "شماره";
            this.intNumber.MinimumWidth = 10;
            this.intNumber.Name = "intNumber";
            this.intNumber.ReadOnly = true;
            this.intNumber.ToolTipText = "شماره";
            this.intNumber.Width = 72;
            // 
            // intCategory
            // 
            this.intCategory.DataPropertyName = "intCategory";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intCategory.DefaultCellStyle = dataGridViewCellStyle5;
            this.intCategory.HeaderText = "کد رسته";
            this.intCategory.MinimumWidth = 10;
            this.intCategory.Name = "intCategory";
            this.intCategory.ReadOnly = true;
            this.intCategory.ToolTipText = "کد رسته";
            this.intCategory.Visible = false;
            this.intCategory.Width = 84;
            // 
            // intCategoryAsName
            // 
            this.intCategoryAsName.DataPropertyName = "intCategoryAsName";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intCategoryAsName.DefaultCellStyle = dataGridViewCellStyle6;
            this.intCategoryAsName.HeaderText = "رسته";
            this.intCategoryAsName.MinimumWidth = 10;
            this.intCategoryAsName.Name = "intCategoryAsName";
            this.intCategoryAsName.ReadOnly = true;
            this.intCategoryAsName.ToolTipText = "رسته";
            this.intCategoryAsName.Width = 65;
            // 
            // nvcBrand
            // 
            this.nvcBrand.DataPropertyName = "nvcBrand";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcBrand.DefaultCellStyle = dataGridViewCellStyle7;
            this.nvcBrand.HeaderText = "برند";
            this.nvcBrand.MinimumWidth = 10;
            this.nvcBrand.Name = "nvcBrand";
            this.nvcBrand.ReadOnly = true;
            this.nvcBrand.ToolTipText = "برند";
            this.nvcBrand.Width = 55;
            // 
            // nvcActivityType
            // 
            this.nvcActivityType.DataPropertyName = "nvcActivityType";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcActivityType.DefaultCellStyle = dataGridViewCellStyle8;
            this.nvcActivityType.HeaderText = "نوع فعالیت";
            this.nvcActivityType.MinimumWidth = 10;
            this.nvcActivityType.Name = "nvcActivityType";
            this.nvcActivityType.ReadOnly = true;
            this.nvcActivityType.ToolTipText = "نوع فعالیت";
            this.nvcActivityType.Visible = false;
            this.nvcActivityType.Width = 94;
            // 
            // nvcActivities
            // 
            this.nvcActivities.DataPropertyName = "nvcActivities";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcActivities.DefaultCellStyle = dataGridViewCellStyle9;
            this.nvcActivities.HeaderText = "فعالیت‌ها";
            this.nvcActivities.MinimumWidth = 10;
            this.nvcActivities.Name = "nvcActivities";
            this.nvcActivities.ReadOnly = true;
            this.nvcActivities.ToolTipText = "فعالیت‌ها";
            this.nvcActivities.Visible = false;
            this.nvcActivities.Width = 85;
            // 
            // nvcFirstName
            // 
            this.nvcFirstName.DataPropertyName = "nvcFirstName";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcFirstName.DefaultCellStyle = dataGridViewCellStyle10;
            this.nvcFirstName.HeaderText = "نام";
            this.nvcFirstName.MinimumWidth = 10;
            this.nvcFirstName.Name = "nvcFirstName";
            this.nvcFirstName.ReadOnly = true;
            this.nvcFirstName.ToolTipText = "نام";
            this.nvcFirstName.Width = 49;
            // 
            // nvcLastName
            // 
            this.nvcLastName.DataPropertyName = "nvcLastName";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcLastName.DefaultCellStyle = dataGridViewCellStyle11;
            this.nvcLastName.HeaderText = "نام خانوادگی";
            this.nvcLastName.MinimumWidth = 10;
            this.nvcLastName.Name = "nvcLastName";
            this.nvcLastName.ReadOnly = true;
            this.nvcLastName.ToolTipText = "نام خانوادگی";
            this.nvcLastName.Width = 107;
            // 
            // nvcTell
            // 
            this.nvcTell.DataPropertyName = "nvcTell";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcTell.DefaultCellStyle = dataGridViewCellStyle12;
            this.nvcTell.HeaderText = "تلفن";
            this.nvcTell.MinimumWidth = 10;
            this.nvcTell.Name = "nvcTell";
            this.nvcTell.ReadOnly = true;
            this.nvcTell.Visible = false;
            this.nvcTell.Width = 60;
            // 
            // nvcCity
            // 
            this.nvcCity.DataPropertyName = "nvcCity";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcCity.DefaultCellStyle = dataGridViewCellStyle13;
            this.nvcCity.HeaderText = "شهر";
            this.nvcCity.MinimumWidth = 10;
            this.nvcCity.Name = "nvcCity";
            this.nvcCity.ReadOnly = true;
            this.nvcCity.ToolTipText = "شهر";
            this.nvcCity.Width = 61;
            // 
            // nvcAddress
            // 
            this.nvcAddress.DataPropertyName = "nvcAddress";
            this.nvcAddress.HeaderText = "نشانی";
            this.nvcAddress.MinimumWidth = 10;
            this.nvcAddress.Name = "nvcAddress";
            this.nvcAddress.ReadOnly = true;
            this.nvcAddress.Width = 74;
            // 
            // btmInsertVendor
            // 
            this.btmInsertVendor.Location = new System.Drawing.Point(316, 477);
            this.btmInsertVendor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btmInsertVendor.Name = "btmInsertVendor";
            this.btmInsertVendor.Size = new System.Drawing.Size(125, 35);
            this.btmInsertVendor.TabIndex = 102;
            this.btmInsertVendor.Text = "ورود فروشنده";
            this.btmInsertVendor.UseVisualStyleBackColor = true;
            this.btmInsertVendor.Click += new System.EventHandler(this.BtmInsertVendor_Click);
            // 
            // SelectVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(670, 446);
            this.Controls.Add(this.btmInsertVendor);
            this.Controls.Add(this.dgvVendors);
            this.Controls.Add(this.cbNoName);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.tbBrand);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btmSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btmSelect);
            this.Controls.Add(this.label8);
            this.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectVendor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "انتخاب فروشنده";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Vendors_FormClosing);
            this.Load += new System.EventHandler(this.Vendors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmSelect;
        private System.Windows.Forms.CheckBox cbNoName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btmSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVendors;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bitSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn intNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn intCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn intCategoryAsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcActivityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcActivities;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcTell;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcAddress;
        private System.Windows.Forms.Button btmInsertVendor;
    }
}