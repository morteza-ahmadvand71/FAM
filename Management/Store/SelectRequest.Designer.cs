namespace Baran.Ferroalloy.Management
{
    partial class SelectRequest
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
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.intNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intRowBudget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intRowBudgetText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcRequesterCoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcRequesterCoIdByName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcSupervisorCoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcPlantmanagerCoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcCeoCoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btmEmployee = new System.Windows.Forms.Button();
            this.labEmployee = new System.Windows.Forms.Label();
            this.cbNoName = new System.Windows.Forms.CheckBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRowBudget = new System.Windows.Forms.ComboBox();
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.labToDate = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.labFromDate = new System.Windows.Forms.Label();
            this.btmSearch = new System.Windows.Forms.Button();
            this.btmInsertRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // btmSelect
            // 
            this.btmSelect.Enabled = false;
            this.btmSelect.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btmSelect.Location = new System.Drawing.Point(932, 954);
            this.btmSelect.Margin = new System.Windows.Forms.Padding(0);
            this.btmSelect.Name = "btmSelect";
            this.btmSelect.Size = new System.Drawing.Size(250, 70);
            this.btmSelect.TabIndex = 4;
            this.btmSelect.Text = "انتخاب";
            this.btmSelect.UseVisualStyleBackColor = true;
            this.btmSelect.Click += new System.EventHandler(this.BtmSelect_Click);
            // 
            // dgvRequests
            // 
            this.dgvRequests.AllowUserToAddRows = false;
            this.dgvRequests.AllowUserToDeleteRows = false;
            this.dgvRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRequests.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.125F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.bitSelect,
            this.intNumber,
            this.intDepartment,
            this.datDate,
            this.intRowBudget,
            this.intRowBudgetText,
            this.nvcRequesterCoID,
            this.nvcRequesterCoIdByName,
            this.nvcSupervisorCoID,
            this.nvcPlantmanagerCoID,
            this.nvcCeoCoID});
            this.dgvRequests.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvRequests.Location = new System.Drawing.Point(168, 448);
            this.dgvRequests.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvRequests.RowTemplate.Height = 55;
            this.dgvRequests.Size = new System.Drawing.Size(1486, 456);
            this.dgvRequests.TabIndex = 0;
            this.dgvRequests.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvRequests_CellMouseClick);
            this.dgvRequests.Sorted += new System.EventHandler(this.DgvRequests_Sorted);
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
            this.intID.Width = 200;
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
            this.bitSelect.Width = 130;
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
            this.intNumber.Width = 133;
            // 
            // intDepartment
            // 
            this.intDepartment.DataPropertyName = "intDepartment";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intDepartment.DefaultCellStyle = dataGridViewCellStyle5;
            this.intDepartment.HeaderText = "دپارتمان";
            this.intDepartment.MinimumWidth = 10;
            this.intDepartment.Name = "intDepartment";
            this.intDepartment.ReadOnly = true;
            this.intDepartment.ToolTipText = "دپارتمان";
            this.intDepartment.Width = 149;
            // 
            // datDate
            // 
            this.datDate.DataPropertyName = "datDate";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "D";
            dataGridViewCellStyle6.NullValue = null;
            this.datDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.datDate.HeaderText = "تاریخ";
            this.datDate.MinimumWidth = 10;
            this.datDate.Name = "datDate";
            this.datDate.ReadOnly = true;
            this.datDate.ToolTipText = "تاریخ";
            this.datDate.Width = 113;
            // 
            // intRowBudget
            // 
            this.intRowBudget.DataPropertyName = "intRowBudget";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intRowBudget.DefaultCellStyle = dataGridViewCellStyle7;
            this.intRowBudget.HeaderText = "شماره ردیف بودجه";
            this.intRowBudget.MinimumWidth = 10;
            this.intRowBudget.Name = "intRowBudget";
            this.intRowBudget.Visible = false;
            this.intRowBudget.Width = 400;
            // 
            // intRowBudgetText
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intRowBudgetText.DefaultCellStyle = dataGridViewCellStyle8;
            this.intRowBudgetText.HeaderText = "ردیف بودجه";
            this.intRowBudgetText.MinimumWidth = 10;
            this.intRowBudgetText.Name = "intRowBudgetText";
            this.intRowBudgetText.Width = 190;
            // 
            // nvcRequesterCoID
            // 
            this.nvcRequesterCoID.DataPropertyName = "nvcRequesterCoID";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcRequesterCoID.DefaultCellStyle = dataGridViewCellStyle9;
            this.nvcRequesterCoID.HeaderText = "شماره درخواست کننده";
            this.nvcRequesterCoID.MinimumWidth = 10;
            this.nvcRequesterCoID.Name = "nvcRequesterCoID";
            this.nvcRequesterCoID.ReadOnly = true;
            this.nvcRequesterCoID.ToolTipText = "شماره درخواست کننده";
            this.nvcRequesterCoID.Visible = false;
            this.nvcRequesterCoID.Width = 250;
            // 
            // nvcRequesterCoIdByName
            // 
            this.nvcRequesterCoIdByName.DataPropertyName = "nvcRequesterCoIdByName";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcRequesterCoIdByName.DefaultCellStyle = dataGridViewCellStyle10;
            this.nvcRequesterCoIdByName.HeaderText = "درخواست کننده";
            this.nvcRequesterCoIdByName.MinimumWidth = 10;
            this.nvcRequesterCoIdByName.Name = "nvcRequesterCoIdByName";
            this.nvcRequesterCoIdByName.ToolTipText = "درخواست کننده";
            this.nvcRequesterCoIdByName.Width = 238;
            // 
            // nvcSupervisorCoID
            // 
            this.nvcSupervisorCoID.DataPropertyName = "nvcSupervisorCoID";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcSupervisorCoID.DefaultCellStyle = dataGridViewCellStyle11;
            this.nvcSupervisorCoID.HeaderText = "مدیر واحد";
            this.nvcSupervisorCoID.MinimumWidth = 10;
            this.nvcSupervisorCoID.Name = "nvcSupervisorCoID";
            this.nvcSupervisorCoID.ReadOnly = true;
            this.nvcSupervisorCoID.ToolTipText = "مدیر واحد";
            this.nvcSupervisorCoID.Width = 167;
            // 
            // nvcPlantmanagerCoID
            // 
            this.nvcPlantmanagerCoID.DataPropertyName = "nvcPlantmanagerCoID";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcPlantmanagerCoID.DefaultCellStyle = dataGridViewCellStyle12;
            this.nvcPlantmanagerCoID.HeaderText = "مدیر کارخانه";
            this.nvcPlantmanagerCoID.MinimumWidth = 10;
            this.nvcPlantmanagerCoID.Name = "nvcPlantmanagerCoID";
            this.nvcPlantmanagerCoID.Visible = false;
            this.nvcPlantmanagerCoID.Width = 250;
            // 
            // nvcCeoCoID
            // 
            this.nvcCeoCoID.DataPropertyName = "nvcCeoCoID";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcCeoCoID.DefaultCellStyle = dataGridViewCellStyle13;
            this.nvcCeoCoID.HeaderText = "مدیر عامل";
            this.nvcCeoCoID.MinimumWidth = 10;
            this.nvcCeoCoID.Name = "nvcCeoCoID";
            this.nvcCeoCoID.Visible = false;
            this.nvcCeoCoID.Width = 250;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Enabled = false;
            this.dtpFrom.Location = new System.Drawing.Point(754, 160);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(396, 40);
            this.dtpFrom.TabIndex = 84;
            // 
            // btmEmployee
            // 
            this.btmEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btmEmployee.Location = new System.Drawing.Point(1158, 244);
            this.btmEmployee.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btmEmployee.Name = "btmEmployee";
            this.btmEmployee.Size = new System.Drawing.Size(250, 70);
            this.btmEmployee.TabIndex = 100;
            this.btmEmployee.Text = "انتخاب";
            this.btmEmployee.UseVisualStyleBackColor = true;
            this.btmEmployee.Click += new System.EventHandler(this.btmEmployee_Click);
            // 
            // labEmployee
            // 
            this.labEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labEmployee.Location = new System.Drawing.Point(610, 254);
            this.labEmployee.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labEmployee.Name = "labEmployee";
            this.labEmployee.Size = new System.Drawing.Size(600, 50);
            this.labEmployee.TabIndex = 99;
            this.labEmployee.Text = "انتخاب کنید .............................................";
            this.labEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbNoName
            // 
            this.cbNoName.AutoSize = true;
            this.cbNoName.Location = new System.Drawing.Point(194, 370);
            this.cbNoName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbNoName.Name = "cbNoName";
            this.cbNoName.Size = new System.Drawing.Size(218, 37);
            this.cbNoName.TabIndex = 98;
            this.cbNoName.Text = "بدون درخواست";
            this.cbNoName.UseVisualStyleBackColor = true;
            this.cbNoName.CheckedChanged += new System.EventHandler(this.CbNoName_CheckedChanged);
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(736, 68);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(296, 41);
            this.cbCategory.TabIndex = 92;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.CbCategory_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(644, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 33);
            this.label5.TabIndex = 97;
            this.label5.Text = "رسته:";
            // 
            // cbRowBudget
            // 
            this.cbRowBudget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRowBudget.FormattingEnabled = true;
            this.cbRowBudget.Location = new System.Drawing.Point(1358, 68);
            this.cbRowBudget.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbRowBudget.Name = "cbRowBudget";
            this.cbRowBudget.Size = new System.Drawing.Size(296, 41);
            this.cbRowBudget.TabIndex = 94;
            this.cbRowBudget.SelectedIndexChanged += new System.EventHandler(this.CbRowBudget_SelectedIndexChanged);
            // 
            // cbDepartments
            // 
            this.cbDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.Location = new System.Drawing.Point(188, 68);
            this.cbDepartments.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(296, 41);
            this.cbDepartments.TabIndex = 96;
            this.cbDepartments.SelectedIndexChanged += new System.EventHandler(this.CbDepartments_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 33);
            this.label3.TabIndex = 95;
            this.label3.Text = "واحد:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1198, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 33);
            this.label1.TabIndex = 93;
            this.label1.Text = "ردیف بودجه:";
            // 
            // tbNumber
            // 
            this.tbNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbNumber.Location = new System.Drawing.Point(244, 160);
            this.tbNumber.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tbNumber.MaxLength = 10;
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbNumber.Size = new System.Drawing.Size(236, 40);
            this.tbNumber.TabIndex = 91;
            this.tbNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNumber.TextChanged += new System.EventHandler(this.TbNumber_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 262);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 33);
            this.label4.TabIndex = 90;
            this.label4.Text = "درخواست کننده:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 33);
            this.label2.TabIndex = 89;
            this.label2.Text = "شماره:";
            // 
            // cbDate
            // 
            this.cbDate.AutoSize = true;
            this.cbDate.Location = new System.Drawing.Point(584, 164);
            this.cbDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(110, 37);
            this.cbDate.TabIndex = 88;
            this.cbDate.Text = "تاریخ:";
            this.cbDate.UseVisualStyleBackColor = true;
            this.cbDate.CheckedChanged += new System.EventHandler(this.CbDate_CheckedChanged);
            // 
            // labToDate
            // 
            this.labToDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labToDate.AutoSize = true;
            this.labToDate.Enabled = false;
            this.labToDate.Location = new System.Drawing.Point(1176, 168);
            this.labToDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labToDate.Name = "labToDate";
            this.labToDate.Size = new System.Drawing.Size(41, 33);
            this.labToDate.TabIndex = 87;
            this.labToDate.Text = "تا:";
            // 
            // dtpTo
            // 
            this.dtpTo.Enabled = false;
            this.dtpTo.Location = new System.Drawing.Point(1218, 160);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(396, 40);
            this.dtpTo.TabIndex = 86;
            // 
            // labFromDate
            // 
            this.labFromDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labFromDate.AutoSize = true;
            this.labFromDate.Enabled = false;
            this.labFromDate.Location = new System.Drawing.Point(712, 168);
            this.labFromDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labFromDate.Name = "labFromDate";
            this.labFromDate.Size = new System.Drawing.Size(42, 33);
            this.labFromDate.TabIndex = 85;
            this.labFromDate.Text = "از:";
            // 
            // btmSearch
            // 
            this.btmSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btmSearch.Enabled = false;
            this.btmSearch.Location = new System.Drawing.Point(1356, 344);
            this.btmSearch.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btmSearch.Name = "btmSearch";
            this.btmSearch.Size = new System.Drawing.Size(250, 70);
            this.btmSearch.TabIndex = 83;
            this.btmSearch.Text = "جستجو";
            this.btmSearch.UseVisualStyleBackColor = true;
            this.btmSearch.Click += new System.EventHandler(this.btmSearch_Click);
            // 
            // btmInsertRequest
            // 
            this.btmInsertRequest.Location = new System.Drawing.Point(632, 954);
            this.btmInsertRequest.Margin = new System.Windows.Forms.Padding(8);
            this.btmInsertRequest.Name = "btmInsertRequest";
            this.btmInsertRequest.Size = new System.Drawing.Size(250, 70);
            this.btmInsertRequest.TabIndex = 101;
            this.btmInsertRequest.Text = "ورود درخواست";
            this.btmInsertRequest.UseVisualStyleBackColor = true;
            this.btmInsertRequest.Click += new System.EventHandler(this.BtmInsertRequest_Click);
            // 
            // SelectRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1816, 1138);
            this.Controls.Add(this.btmInsertRequest);
            this.Controls.Add(this.dgvRequests);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.btmEmployee);
            this.Controls.Add(this.labEmployee);
            this.Controls.Add(this.cbNoName);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbRowBudget);
            this.Controls.Add(this.cbDepartments);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDate);
            this.Controls.Add(this.labToDate);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.labFromDate);
            this.Controls.Add(this.btmSearch);
            this.Controls.Add(this.btmSelect);
            this.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectRequest";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "انتخاب درخواست";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Requests_FormClosing);
            this.Load += new System.EventHandler(this.Requests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmSelect;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bitSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn intNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn intDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn datDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn intRowBudget;
        private System.Windows.Forms.DataGridViewTextBoxColumn intRowBudgetText;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcRequesterCoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcRequesterCoIdByName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcSupervisorCoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcPlantmanagerCoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcCeoCoID;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btmEmployee;
        public System.Windows.Forms.Label labEmployee;
        private System.Windows.Forms.CheckBox cbNoName;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbRowBudget;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbDate;
        private System.Windows.Forms.Label labToDate;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label labFromDate;
        private System.Windows.Forms.Button btmSearch;
        private System.Windows.Forms.Button btmInsertRequest;
    }
}