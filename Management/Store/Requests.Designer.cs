namespace Baran.Ferroalloy.Management
{
    partial class Requests
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
            this.btmExit = new System.Windows.Forms.Button();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRowBudget = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.labToDate = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.labFromDate = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btmDelete = new System.Windows.Forms.Button();
            this.btmInsert = new System.Windows.Forms.Button();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.btmSearch = new System.Windows.Forms.Button();
            this.btmItems = new System.Windows.Forms.Button();
            this.butEmployee = new System.Windows.Forms.Button();
            this.labEmployee = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.intNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intDepartmentAsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intRowBudget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intRowBudgetAsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcRequesterCoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcRequesterCoIDAsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcSupervisorCoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcSupervisorCoIDAsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcPlantmanagerCoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcPlantmanagerCoIDAsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcCeoCoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcCeoCoIDAsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // btmExit
            // 
            this.btmExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmExit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btmExit.Location = new System.Drawing.Point(616, 667);
            this.btmExit.Margin = new System.Windows.Forms.Padding(0);
            this.btmExit.Name = "btmExit";
            this.btmExit.Size = new System.Drawing.Size(125, 33);
            this.btmExit.TabIndex = 4;
            this.btmExit.Text = "خروج";
            this.btmExit.UseVisualStyleBackColor = true;
            this.btmExit.Click += new System.EventHandler(this.btmExit_Click);
            // 
            // cbDepartment
            // 
            this.cbDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(349, 91);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(150, 24);
            this.cbDepartment.TabIndex = 83;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.CbDepartment_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 82;
            this.label3.Text = "دپارتمان:";
            // 
            // cbRowBudget
            // 
            this.cbRowBudget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRowBudget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRowBudget.FormattingEnabled = true;
            this.cbRowBudget.Location = new System.Drawing.Point(844, 91);
            this.cbRowBudget.Name = "cbRowBudget";
            this.cbRowBudget.Size = new System.Drawing.Size(150, 24);
            this.cbRowBudget.TabIndex = 81;
            this.cbRowBudget.SelectedIndexChanged += new System.EventHandler(this.CbRowBudget_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(764, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 80;
            this.label1.Text = "ردیف بودجه:";
            // 
            // cbDate
            // 
            this.cbDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDate.AutoSize = true;
            this.cbDate.Location = new System.Drawing.Point(387, 137);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(59, 21);
            this.cbDate.TabIndex = 79;
            this.cbDate.Text = "تاریخ:";
            this.cbDate.UseVisualStyleBackColor = true;
            this.cbDate.CheckedChanged += new System.EventHandler(this.CbDate_CheckedChanged);
            // 
            // labToDate
            // 
            this.labToDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labToDate.AutoSize = true;
            this.labToDate.Enabled = false;
            this.labToDate.Location = new System.Drawing.Point(685, 139);
            this.labToDate.Name = "labToDate";
            this.labToDate.Size = new System.Drawing.Size(21, 17);
            this.labToDate.TabIndex = 78;
            this.labToDate.Text = "تا:";
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTo.Enabled = false;
            this.dtpTo.Location = new System.Drawing.Point(472, 135);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 24);
            this.dtpTo.TabIndex = 77;
            // 
            // labFromDate
            // 
            this.labFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labFromDate.AutoSize = true;
            this.labFromDate.Enabled = false;
            this.labFromDate.Location = new System.Drawing.Point(451, 139);
            this.labFromDate.Name = "labFromDate";
            this.labFromDate.Size = new System.Drawing.Size(21, 17);
            this.labFromDate.TabIndex = 76;
            this.labFromDate.Text = "از:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFrom.Enabled = false;
            this.dtpFrom.Location = new System.Drawing.Point(705, 135);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 24);
            this.dtpFrom.TabIndex = 75;
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(577, 91);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(150, 24);
            this.cbCategory.TabIndex = 74;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.CbCategory_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(532, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 73;
            this.label7.Text = "رسته:";
            // 
            // tbNumber
            // 
            this.tbNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumber.Location = new System.Drawing.Point(918, 47);
            this.tbNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbNumber.Size = new System.Drawing.Size(120, 24);
            this.tbNumber.TabIndex = 71;
            this.tbNumber.TextChanged += new System.EventHandler(this.TbNumber_TextChanged);
            this.tbNumber.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            this.tbNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetNumbericCharsTextBoxes);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(867, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "شماره:";
            // 
            // btmDelete
            // 
            this.btmDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmDelete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btmDelete.Location = new System.Drawing.Point(616, 573);
            this.btmDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btmDelete.Name = "btmDelete";
            this.btmDelete.Size = new System.Drawing.Size(125, 35);
            this.btmDelete.TabIndex = 86;
            this.btmDelete.Text = "حذف";
            this.btmDelete.UseVisualStyleBackColor = true;
            this.btmDelete.Click += new System.EventHandler(this.btmDelete_Click);
            // 
            // btmInsert
            // 
            this.btmInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmInsert.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btmInsert.Location = new System.Drawing.Point(767, 573);
            this.btmInsert.Margin = new System.Windows.Forms.Padding(0);
            this.btmInsert.Name = "btmInsert";
            this.btmInsert.Size = new System.Drawing.Size(125, 35);
            this.btmInsert.TabIndex = 85;
            this.btmInsert.Text = "ورود درخواست";
            this.btmInsert.UseVisualStyleBackColor = true;
            this.btmInsert.Click += new System.EventHandler(this.btmInsert_Click);
            // 
            // dgvRequests
            // 
            this.dgvRequests.AllowUserToAddRows = false;
            this.dgvRequests.AllowUserToDeleteRows = false;
            this.dgvRequests.AllowUserToOrderColumns = true;
            this.dgvRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.intDepartmentAsName,
            this.datDate,
            this.intRowBudget,
            this.intRowBudgetAsName,
            this.nvcRequesterCoID,
            this.nvcRequesterCoIDAsName,
            this.nvcSupervisorCoID,
            this.nvcSupervisorCoIDAsName,
            this.nvcPlantmanagerCoID,
            this.nvcPlantmanagerCoIDAsName,
            this.nvcCeoCoID,
            this.nvcCeoCoIDAsName});
            this.dgvRequests.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvRequests.Location = new System.Drawing.Point(131, 208);
            this.dgvRequests.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvRequests.RowTemplate.Height = 55;
            this.dgvRequests.Size = new System.Drawing.Size(1100, 332);
            this.dgvRequests.TabIndex = 84;
            this.dgvRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStuffs_CellContentClick);
            this.dgvRequests.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvRequests_CellMouseClick);
            this.dgvRequests.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStuffs_CellValueChanged);
            this.dgvRequests.Sorted += new System.EventHandler(this.DgvRequests_Sorted);
            // 
            // btmSearch
            // 
            this.btmSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmSearch.AutoSize = true;
            this.btmSearch.Enabled = false;
            this.btmSearch.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmSearch.Location = new System.Drawing.Point(933, 150);
            this.btmSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btmSearch.Name = "btmSearch";
            this.btmSearch.Size = new System.Drawing.Size(125, 35);
            this.btmSearch.TabIndex = 87;
            this.btmSearch.Text = "جستجو";
            this.btmSearch.UseVisualStyleBackColor = true;
            this.btmSearch.Click += new System.EventHandler(this.btmSearch_Click);
            // 
            // btmItems
            // 
            this.btmItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmItems.Enabled = false;
            this.btmItems.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btmItems.Location = new System.Drawing.Point(464, 573);
            this.btmItems.Margin = new System.Windows.Forms.Padding(0);
            this.btmItems.Name = "btmItems";
            this.btmItems.Size = new System.Drawing.Size(125, 35);
            this.btmItems.TabIndex = 88;
            this.btmItems.Text = "آیتم‌ها";
            this.btmItems.UseVisualStyleBackColor = true;
            this.btmItems.Click += new System.EventHandler(this.BtmInvoiceItems_Click);
            // 
            // butEmployee
            // 
            this.butEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butEmployee.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.butEmployee.Location = new System.Drawing.Point(659, 43);
            this.butEmployee.Name = "butEmployee";
            this.butEmployee.Size = new System.Drawing.Size(125, 35);
            this.butEmployee.TabIndex = 91;
            this.butEmployee.Text = "انتخاب";
            this.butEmployee.UseVisualStyleBackColor = true;
            this.butEmployee.Click += new System.EventHandler(this.ButEmployee_Click);
            // 
            // labEmployee
            // 
            this.labEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labEmployee.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.labEmployee.Location = new System.Drawing.Point(356, 51);
            this.labEmployee.Name = "labEmployee";
            this.labEmployee.Size = new System.Drawing.Size(300, 16);
            this.labEmployee.TabIndex = 90;
            this.labEmployee.Text = "انتخاب کنید";
            this.labEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label4.Location = new System.Drawing.Point(252, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 89;
            this.label4.Text = "درخواست کننده:";
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
            // intDepartment
            // 
            this.intDepartment.DataPropertyName = "intDepartment";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intDepartment.DefaultCellStyle = dataGridViewCellStyle5;
            this.intDepartment.HeaderText = "کد دپارتمان";
            this.intDepartment.MinimumWidth = 10;
            this.intDepartment.Name = "intDepartment";
            this.intDepartment.ReadOnly = true;
            this.intDepartment.ToolTipText = "کد دپارتمان";
            this.intDepartment.Visible = false;
            this.intDepartment.Width = 98;
            // 
            // intDepartmentAsName
            // 
            this.intDepartmentAsName.DataPropertyName = "intDepartmentAsName";
            this.intDepartmentAsName.HeaderText = "دپارتمان";
            this.intDepartmentAsName.Name = "intDepartmentAsName";
            this.intDepartmentAsName.ToolTipText = "دپارتمان";
            this.intDepartmentAsName.Width = 79;
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
            this.datDate.Width = 60;
            // 
            // intRowBudget
            // 
            this.intRowBudget.DataPropertyName = "intRowBudget";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intRowBudget.DefaultCellStyle = dataGridViewCellStyle7;
            this.intRowBudget.HeaderText = "کد ردیف بودجه";
            this.intRowBudget.MinimumWidth = 10;
            this.intRowBudget.Name = "intRowBudget";
            this.intRowBudget.ToolTipText = "کد ردیف بودجه";
            this.intRowBudget.Visible = false;
            this.intRowBudget.Width = 119;
            // 
            // intRowBudgetAsName
            // 
            this.intRowBudgetAsName.DataPropertyName = "intRowBudgetAsName";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intRowBudgetAsName.DefaultCellStyle = dataGridViewCellStyle8;
            this.intRowBudgetAsName.HeaderText = "ردیف بودجه";
            this.intRowBudgetAsName.MinimumWidth = 10;
            this.intRowBudgetAsName.Name = "intRowBudgetAsName";
            this.intRowBudgetAsName.ToolTipText = "ردیف بودجه";
            // 
            // nvcRequesterCoID
            // 
            this.nvcRequesterCoID.DataPropertyName = "nvcRequesterCoID";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcRequesterCoID.DefaultCellStyle = dataGridViewCellStyle9;
            this.nvcRequesterCoID.HeaderText = "کد درخواست کننده";
            this.nvcRequesterCoID.MinimumWidth = 10;
            this.nvcRequesterCoID.Name = "nvcRequesterCoID";
            this.nvcRequesterCoID.ReadOnly = true;
            this.nvcRequesterCoID.ToolTipText = "کد درخواست کننده";
            this.nvcRequesterCoID.Visible = false;
            this.nvcRequesterCoID.Width = 145;
            // 
            // nvcRequesterCoIDAsName
            // 
            this.nvcRequesterCoIDAsName.DataPropertyName = "nvcRequesterCoIDAsName";
            this.nvcRequesterCoIDAsName.HeaderText = "درخواست کننده";
            this.nvcRequesterCoIDAsName.Name = "nvcRequesterCoIDAsName";
            this.nvcRequesterCoIDAsName.ToolTipText = "درخواست کننده";
            this.nvcRequesterCoIDAsName.Width = 126;
            // 
            // nvcSupervisorCoID
            // 
            this.nvcSupervisorCoID.DataPropertyName = "nvcSupervisorCoID";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcSupervisorCoID.DefaultCellStyle = dataGridViewCellStyle10;
            this.nvcSupervisorCoID.HeaderText = "کد مدیر واحد";
            this.nvcSupervisorCoID.MinimumWidth = 10;
            this.nvcSupervisorCoID.Name = "nvcSupervisorCoID";
            this.nvcSupervisorCoID.ReadOnly = true;
            this.nvcSupervisorCoID.ToolTipText = "کد مدیر واحد";
            this.nvcSupervisorCoID.Visible = false;
            this.nvcSupervisorCoID.Width = 107;
            // 
            // nvcSupervisorCoIDAsName
            // 
            this.nvcSupervisorCoIDAsName.DataPropertyName = "nvcSupervisorCoIDAsName";
            this.nvcSupervisorCoIDAsName.HeaderText = "مدیر واحد";
            this.nvcSupervisorCoIDAsName.Name = "nvcSupervisorCoIDAsName";
            this.nvcSupervisorCoIDAsName.ToolTipText = "مدیر واحد";
            this.nvcSupervisorCoIDAsName.Width = 88;
            // 
            // nvcPlantmanagerCoID
            // 
            this.nvcPlantmanagerCoID.DataPropertyName = "nvcPlantmanagerCoID";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcPlantmanagerCoID.DefaultCellStyle = dataGridViewCellStyle11;
            this.nvcPlantmanagerCoID.HeaderText = "کد مدیر کارخانه";
            this.nvcPlantmanagerCoID.MinimumWidth = 10;
            this.nvcPlantmanagerCoID.Name = "nvcPlantmanagerCoID";
            this.nvcPlantmanagerCoID.ToolTipText = "کد مدیر کارخانه";
            this.nvcPlantmanagerCoID.Visible = false;
            this.nvcPlantmanagerCoID.Width = 122;
            // 
            // nvcPlantmanagerCoIDAsName
            // 
            this.nvcPlantmanagerCoIDAsName.DataPropertyName = "nvcPlantmanagerCoIDAsName";
            this.nvcPlantmanagerCoIDAsName.HeaderText = "مدیر کارخانه";
            this.nvcPlantmanagerCoIDAsName.Name = "nvcPlantmanagerCoIDAsName";
            this.nvcPlantmanagerCoIDAsName.ToolTipText = "مدیر کارخانه";
            this.nvcPlantmanagerCoIDAsName.Width = 103;
            // 
            // nvcCeoCoID
            // 
            this.nvcCeoCoID.DataPropertyName = "nvcCeoCoID";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcCeoCoID.DefaultCellStyle = dataGridViewCellStyle12;
            this.nvcCeoCoID.HeaderText = "کد مدیر عامل";
            this.nvcCeoCoID.MinimumWidth = 10;
            this.nvcCeoCoID.Name = "nvcCeoCoID";
            this.nvcCeoCoID.ToolTipText = "کد مدیر عامل";
            this.nvcCeoCoID.Visible = false;
            this.nvcCeoCoID.Width = 110;
            // 
            // nvcCeoCoIDAsName
            // 
            this.nvcCeoCoIDAsName.DataPropertyName = "nvcCeoCoIDAsName";
            this.nvcCeoCoIDAsName.HeaderText = "مدیر عامل";
            this.nvcCeoCoIDAsName.Name = "nvcCeoCoIDAsName";
            this.nvcCeoCoIDAsName.ToolTipText = "مدیر عامل";
            this.nvcCeoCoIDAsName.Width = 91;
            // 
            // Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.butEmployee);
            this.Controls.Add(this.labEmployee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btmItems);
            this.Controls.Add(this.btmSearch);
            this.Controls.Add(this.btmDelete);
            this.Controls.Add(this.btmInsert);
            this.Controls.Add(this.dgvRequests);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbRowBudget);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDate);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.labFromDate);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btmExit);
            this.Controls.Add(this.labToDate);
            this.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Requests";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "درخواست‌ها";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Requests_FormClosing);
            this.Load += new System.EventHandler(this.Requests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmExit;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbRowBudget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbDate;
        private System.Windows.Forms.Label labToDate;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label labFromDate;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btmDelete;
        private System.Windows.Forms.Button btmInsert;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.Button btmSearch;
        private System.Windows.Forms.Button btmItems;
        private System.Windows.Forms.Button butEmployee;
        public System.Windows.Forms.Label labEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bitSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn intNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn intDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn intDepartmentAsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn datDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn intRowBudget;
        private System.Windows.Forms.DataGridViewTextBoxColumn intRowBudgetAsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcRequesterCoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcRequesterCoIDAsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcSupervisorCoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcSupervisorCoIDAsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcPlantmanagerCoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcPlantmanagerCoIDAsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcCeoCoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcCeoCoIDAsName;
    }
}