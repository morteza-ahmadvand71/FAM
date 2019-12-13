namespace Baran.Ferroalloy.Management
{
    partial class StoreGetOuts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btmExit = new System.Windows.Forms.Button();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.labToDate = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.labFromDate = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btmDelete = new System.Windows.Forms.Button();
            this.btmInsert = new System.Windows.Forms.Button();
            this.dgvStoreGetOuts = new System.Windows.Forms.DataGridView();
            this.btmSearch = new System.Windows.Forms.Button();
            this.btmStoreGetOutItems = new System.Windows.Forms.Button();
            this.butEmployee = new System.Windows.Forms.Button();
            this.labEmployee = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            this.labDepartment = new System.Windows.Forms.Label();
            this.btmConfirm = new System.Windows.Forms.Button();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.intNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intDepartmentAsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intGroupNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intSubDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intSubDepartmentAsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcRequesterCoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcRequesterCoIDAsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcDepartmentSupervisorCoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcDepartmentSupervisorCoIDAsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreGetOuts)).BeginInit();
            this.SuspendLayout();
            // 
            // btmExit
            // 
            this.btmExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmExit.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btmExit.Location = new System.Drawing.Point(616, 667);
            this.btmExit.Margin = new System.Windows.Forms.Padding(0);
            this.btmExit.Name = "btmExit";
            this.btmExit.Size = new System.Drawing.Size(125, 33);
            this.btmExit.TabIndex = 4;
            this.btmExit.Text = "خروج";
            this.btmExit.UseVisualStyleBackColor = true;
            this.btmExit.Click += new System.EventHandler(this.btmExit_Click);
            // 
            // cbDate
            // 
            this.cbDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDate.AutoSize = true;
            this.cbDate.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbDate.Location = new System.Drawing.Point(279, 100);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(60, 25);
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
            this.labToDate.Font = new System.Drawing.Font("B Yekan", 10F);
            this.labToDate.Location = new System.Drawing.Point(576, 102);
            this.labToDate.Name = "labToDate";
            this.labToDate.Size = new System.Drawing.Size(22, 21);
            this.labToDate.TabIndex = 78;
            this.labToDate.Text = "تا:";
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTo.Enabled = false;
            this.dtpTo.Font = new System.Drawing.Font("B Yekan", 10F);
            this.dtpTo.Location = new System.Drawing.Point(363, 98);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 28);
            this.dtpTo.TabIndex = 77;
            // 
            // labFromDate
            // 
            this.labFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labFromDate.AutoSize = true;
            this.labFromDate.Enabled = false;
            this.labFromDate.Font = new System.Drawing.Font("B Yekan", 10F);
            this.labFromDate.Location = new System.Drawing.Point(342, 102);
            this.labFromDate.Name = "labFromDate";
            this.labFromDate.Size = new System.Drawing.Size(24, 21);
            this.labFromDate.TabIndex = 76;
            this.labFromDate.Text = "از:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFrom.Enabled = false;
            this.dtpFrom.Font = new System.Drawing.Font("B Yekan", 10F);
            this.dtpFrom.Location = new System.Drawing.Point(596, 98);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 28);
            this.dtpFrom.TabIndex = 75;
            // 
            // tbNumber
            // 
            this.tbNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumber.Font = new System.Drawing.Font("B Yekan", 10F);
            this.tbNumber.Location = new System.Drawing.Point(943, 46);
            this.tbNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbNumber.Size = new System.Drawing.Size(120, 28);
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
            this.label2.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label2.Location = new System.Drawing.Point(892, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 69;
            this.label2.Text = "شماره:";
            // 
            // btmDelete
            // 
            this.btmDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmDelete.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btmDelete.Location = new System.Drawing.Point(692, 561);
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
            this.btmInsert.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btmInsert.Location = new System.Drawing.Point(843, 561);
            this.btmInsert.Margin = new System.Windows.Forms.Padding(0);
            this.btmInsert.Name = "btmInsert";
            this.btmInsert.Size = new System.Drawing.Size(125, 35);
            this.btmInsert.TabIndex = 85;
            this.btmInsert.Text = "ورود درخواست";
            this.btmInsert.UseVisualStyleBackColor = true;
            this.btmInsert.Click += new System.EventHandler(this.btmInsert_Click);
            // 
            // dgvStoreGetOuts
            // 
            this.dgvStoreGetOuts.AllowUserToAddRows = false;
            this.dgvStoreGetOuts.AllowUserToDeleteRows = false;
            this.dgvStoreGetOuts.AllowUserToOrderColumns = true;
            this.dgvStoreGetOuts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStoreGetOuts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStoreGetOuts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("B Yekan", 10F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStoreGetOuts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvStoreGetOuts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStoreGetOuts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.bitSelect,
            this.intNumber,
            this.intDepartment,
            this.intDepartmentAsName,
            this.intGroupNumber,
            this.datDate,
            this.intSubDepartment,
            this.intSubDepartmentAsName,
            this.nvcRequesterCoID,
            this.nvcRequesterCoIDAsName,
            this.nvcDepartmentSupervisorCoID,
            this.nvcDepartmentSupervisorCoIDAsName});
            this.dgvStoreGetOuts.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvStoreGetOuts.Location = new System.Drawing.Point(131, 208);
            this.dgvStoreGetOuts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStoreGetOuts.Name = "dgvStoreGetOuts";
            this.dgvStoreGetOuts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvStoreGetOuts.RowTemplate.Height = 55;
            this.dgvStoreGetOuts.Size = new System.Drawing.Size(1100, 332);
            this.dgvStoreGetOuts.TabIndex = 84;
            this.dgvStoreGetOuts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStoreGetOuts_CellContentClick);
            this.dgvStoreGetOuts.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStoreGetOuts_CellMouseClick);
            this.dgvStoreGetOuts.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStoreGetOuts_CellValueChanged);
            this.dgvStoreGetOuts.Sorted += new System.EventHandler(this.dgvStoreGetOuts_Sorted);
            // 
            // btmSearch
            // 
            this.btmSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmSearch.AutoSize = true;
            this.btmSearch.Enabled = false;
            this.btmSearch.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btmSearch.Location = new System.Drawing.Point(933, 150);
            this.btmSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btmSearch.Name = "btmSearch";
            this.btmSearch.Size = new System.Drawing.Size(125, 35);
            this.btmSearch.TabIndex = 87;
            this.btmSearch.Text = "جستجو";
            this.btmSearch.UseVisualStyleBackColor = true;
            this.btmSearch.Click += new System.EventHandler(this.btmSearch_Click);
            // 
            // btmStoreGetOutItems
            // 
            this.btmStoreGetOutItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmStoreGetOutItems.Enabled = false;
            this.btmStoreGetOutItems.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btmStoreGetOutItems.Location = new System.Drawing.Point(390, 561);
            this.btmStoreGetOutItems.Margin = new System.Windows.Forms.Padding(0);
            this.btmStoreGetOutItems.Name = "btmStoreGetOutItems";
            this.btmStoreGetOutItems.Size = new System.Drawing.Size(125, 35);
            this.btmStoreGetOutItems.TabIndex = 88;
            this.btmStoreGetOutItems.Text = "آیتم‌ها";
            this.btmStoreGetOutItems.UseVisualStyleBackColor = true;
            this.btmStoreGetOutItems.Click += new System.EventHandler(this.BtmStoreGetOutItems_Click);
            // 
            // butEmployee
            // 
            this.butEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butEmployee.Font = new System.Drawing.Font("B Yekan", 10F);
            this.butEmployee.Location = new System.Drawing.Point(647, 43);
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
            this.labEmployee.Font = new System.Drawing.Font("B Yekan", 10F);
            this.labEmployee.Location = new System.Drawing.Point(344, 47);
            this.labEmployee.Name = "labEmployee";
            this.labEmployee.Size = new System.Drawing.Size(300, 26);
            this.labEmployee.TabIndex = 90;
            this.labEmployee.Text = "انتخاب کنید";
            this.labEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label4.Location = new System.Drawing.Point(240, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 21);
            this.label4.TabIndex = 89;
            this.label4.Text = "درخواست کننده:";
            // 
            // cbDepartments
            // 
            this.cbDepartments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.Location = new System.Drawing.Point(883, 98);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(150, 28);
            this.cbDepartments.TabIndex = 92;
            this.cbDepartments.SelectedIndexChanged += new System.EventHandler(this.CbDepartments_SelectedIndexChanged);
            // 
            // labDepartment
            // 
            this.labDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labDepartment.AutoSize = true;
            this.labDepartment.Location = new System.Drawing.Point(843, 102);
            this.labDepartment.Name = "labDepartment";
            this.labDepartment.Size = new System.Drawing.Size(39, 21);
            this.labDepartment.TabIndex = 93;
            this.labDepartment.Text = "واحد:";
            // 
            // btmConfirm
            // 
            this.btmConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmConfirm.Enabled = false;
            this.btmConfirm.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btmConfirm.Location = new System.Drawing.Point(541, 561);
            this.btmConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.btmConfirm.Name = "btmConfirm";
            this.btmConfirm.Size = new System.Drawing.Size(125, 35);
            this.btmConfirm.TabIndex = 88;
            this.btmConfirm.Text = "تایید";
            this.btmConfirm.UseVisualStyleBackColor = true;
            this.btmConfirm.Click += new System.EventHandler(this.BtmConfirm_Click);
            // 
            // intID
            // 
            this.intID.DataPropertyName = "intID";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intID.DefaultCellStyle = dataGridViewCellStyle15;
            this.intID.HeaderText = "intID";
            this.intID.MinimumWidth = 10;
            this.intID.Name = "intID";
            this.intID.Visible = false;
            this.intID.Width = 63;
            // 
            // bitSelect
            // 
            this.bitSelect.DataPropertyName = "bitSelect";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.NullValue = false;
            this.bitSelect.DefaultCellStyle = dataGridViewCellStyle16;
            this.bitSelect.HeaderText = "انتخاب";
            this.bitSelect.MinimumWidth = 10;
            this.bitSelect.Name = "bitSelect";
            this.bitSelect.Width = 50;
            // 
            // intNumber
            // 
            this.intNumber.DataPropertyName = "intNumber";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intNumber.DefaultCellStyle = dataGridViewCellStyle17;
            this.intNumber.HeaderText = "شماره";
            this.intNumber.MinimumWidth = 10;
            this.intNumber.Name = "intNumber";
            this.intNumber.ReadOnly = true;
            this.intNumber.ToolTipText = "شماره";
            this.intNumber.Width = 66;
            // 
            // intDepartment
            // 
            this.intDepartment.DataPropertyName = "intDepartment";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intDepartment.DefaultCellStyle = dataGridViewCellStyle18;
            this.intDepartment.HeaderText = "کد دپارتمان";
            this.intDepartment.MinimumWidth = 10;
            this.intDepartment.Name = "intDepartment";
            this.intDepartment.ReadOnly = true;
            this.intDepartment.ToolTipText = "کد دپارتمان";
            this.intDepartment.Visible = false;
            this.intDepartment.Width = 96;
            // 
            // intDepartmentAsName
            // 
            this.intDepartmentAsName.DataPropertyName = "intDepartmentAsName";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intDepartmentAsName.DefaultCellStyle = dataGridViewCellStyle19;
            this.intDepartmentAsName.HeaderText = "دپارتمان";
            this.intDepartmentAsName.Name = "intDepartmentAsName";
            this.intDepartmentAsName.ToolTipText = "دپارتمان";
            this.intDepartmentAsName.Width = 79;
            // 
            // intGroupNumber
            // 
            this.intGroupNumber.DataPropertyName = "intGroupNumber";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intGroupNumber.DefaultCellStyle = dataGridViewCellStyle20;
            this.intGroupNumber.HeaderText = "گروه";
            this.intGroupNumber.Name = "intGroupNumber";
            this.intGroupNumber.ToolTipText = "گروه";
            this.intGroupNumber.Width = 59;
            // 
            // datDate
            // 
            this.datDate.DataPropertyName = "datDate";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.Format = "D";
            dataGridViewCellStyle21.NullValue = null;
            this.datDate.DefaultCellStyle = dataGridViewCellStyle21;
            this.datDate.HeaderText = "تاریخ";
            this.datDate.MinimumWidth = 10;
            this.datDate.Name = "datDate";
            this.datDate.ReadOnly = true;
            this.datDate.ToolTipText = "تاریخ";
            this.datDate.Width = 62;
            // 
            // intSubDepartment
            // 
            this.intSubDepartment.DataPropertyName = "intSubDepartment";
            this.intSubDepartment.HeaderText = "کد بخش";
            this.intSubDepartment.Name = "intSubDepartment";
            this.intSubDepartment.ToolTipText = "کد بخش";
            this.intSubDepartment.Visible = false;
            this.intSubDepartment.Width = 79;
            // 
            // intSubDepartmentAsName
            // 
            this.intSubDepartmentAsName.DataPropertyName = "intSubDepartmentAsName";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intSubDepartmentAsName.DefaultCellStyle = dataGridViewCellStyle22;
            this.intSubDepartmentAsName.HeaderText = "بخش";
            this.intSubDepartmentAsName.Name = "intSubDepartmentAsName";
            this.intSubDepartmentAsName.ToolTipText = "بخش";
            this.intSubDepartmentAsName.Width = 62;
            // 
            // nvcRequesterCoID
            // 
            this.nvcRequesterCoID.DataPropertyName = "nvcRequesterCoID";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcRequesterCoID.DefaultCellStyle = dataGridViewCellStyle23;
            this.nvcRequesterCoID.HeaderText = "کد درخواست کننده";
            this.nvcRequesterCoID.MinimumWidth = 10;
            this.nvcRequesterCoID.Name = "nvcRequesterCoID";
            this.nvcRequesterCoID.ToolTipText = "کد درخواست کننده";
            this.nvcRequesterCoID.Visible = false;
            this.nvcRequesterCoID.Width = 137;
            // 
            // nvcRequesterCoIDAsName
            // 
            this.nvcRequesterCoIDAsName.DataPropertyName = "nvcRequesterCoIDAsName";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcRequesterCoIDAsName.DefaultCellStyle = dataGridViewCellStyle24;
            this.nvcRequesterCoIDAsName.HeaderText = "درخواست کننده";
            this.nvcRequesterCoIDAsName.Name = "nvcRequesterCoIDAsName";
            this.nvcRequesterCoIDAsName.ToolTipText = "درخواست کننده";
            this.nvcRequesterCoIDAsName.Width = 120;
            // 
            // nvcDepartmentSupervisorCoID
            // 
            this.nvcDepartmentSupervisorCoID.DataPropertyName = "nvcDepartmentSupervisorCoID";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcDepartmentSupervisorCoID.DefaultCellStyle = dataGridViewCellStyle25;
            this.nvcDepartmentSupervisorCoID.HeaderText = "کد مدیر واحد";
            this.nvcDepartmentSupervisorCoID.MinimumWidth = 10;
            this.nvcDepartmentSupervisorCoID.Name = "nvcDepartmentSupervisorCoID";
            this.nvcDepartmentSupervisorCoID.ReadOnly = true;
            this.nvcDepartmentSupervisorCoID.ToolTipText = "کد مدیر واحد";
            this.nvcDepartmentSupervisorCoID.Visible = false;
            this.nvcDepartmentSupervisorCoID.Width = 105;
            // 
            // nvcDepartmentSupervisorCoIDAsName
            // 
            this.nvcDepartmentSupervisorCoIDAsName.DataPropertyName = "nvcDepartmentSupervisorCoIDAsName";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcDepartmentSupervisorCoIDAsName.DefaultCellStyle = dataGridViewCellStyle26;
            this.nvcDepartmentSupervisorCoIDAsName.HeaderText = "مدیر واحد";
            this.nvcDepartmentSupervisorCoIDAsName.Name = "nvcDepartmentSupervisorCoIDAsName";
            this.nvcDepartmentSupervisorCoIDAsName.ToolTipText = "مدیر واحد";
            this.nvcDepartmentSupervisorCoIDAsName.Width = 88;
            // 
            // StoreGetOuts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.cbDepartments);
            this.Controls.Add(this.labDepartment);
            this.Controls.Add(this.butEmployee);
            this.Controls.Add(this.labEmployee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btmConfirm);
            this.Controls.Add(this.btmStoreGetOutItems);
            this.Controls.Add(this.btmSearch);
            this.Controls.Add(this.btmDelete);
            this.Controls.Add(this.btmInsert);
            this.Controls.Add(this.dgvStoreGetOuts);
            this.Controls.Add(this.cbDate);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.labFromDate);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btmExit);
            this.Controls.Add(this.labToDate);
            this.Font = new System.Drawing.Font("B Yekan", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StoreGetOuts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "درخواست خروج کالا از انبار";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Requests_FormClosing);
            this.Load += new System.EventHandler(this.StoreGetOuts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStoreGetOuts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmExit;
        private System.Windows.Forms.CheckBox cbDate;
        private System.Windows.Forms.Label labToDate;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label labFromDate;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btmDelete;
        private System.Windows.Forms.Button btmInsert;
        private System.Windows.Forms.DataGridView dgvStoreGetOuts;
        private System.Windows.Forms.Button btmSearch;
        private System.Windows.Forms.Button btmStoreGetOutItems;
        private System.Windows.Forms.Button butEmployee;
        public System.Windows.Forms.Label labEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.Label labDepartment;
        private System.Windows.Forms.Button btmConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bitSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn intNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn intDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn intDepartmentAsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn intGroupNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn datDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn intSubDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn intSubDepartmentAsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcRequesterCoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcRequesterCoIDAsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcDepartmentSupervisorCoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcDepartmentSupervisorCoIDAsName;
    }
}