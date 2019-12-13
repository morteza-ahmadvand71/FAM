namespace Baran.Ferroalloy.Management
{
    partial class Invoices
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
            this.btmExit = new System.Windows.Forms.Button();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.intNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intInvoiceNumberofVendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intVendorNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcVendorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcBuyerCoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcBuyerCoIDByName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floTotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbDate = new System.Windows.Forms.CheckBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.labFromDate = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.butVendor = new System.Windows.Forms.Button();
            this.labVendor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbInvoiceNumberofVendor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btmSearch = new System.Windows.Forms.Button();
            this.labToDate = new System.Windows.Forms.Label();
            this.btmInsert = new System.Windows.Forms.Button();
            this.btmDelete = new System.Windows.Forms.Button();
            this.btmInvoiceItems = new System.Windows.Forms.Button();
            this.btmInvoiceImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // btmExit
            // 
            this.btmExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmExit.AutoSize = true;
            this.btmExit.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmExit.Location = new System.Drawing.Point(621, 699);
            this.btmExit.Margin = new System.Windows.Forms.Padding(0);
            this.btmExit.Name = "btmExit";
            this.btmExit.Size = new System.Drawing.Size(125, 35);
            this.btmExit.TabIndex = 12;
            this.btmExit.Text = "خروج";
            this.btmExit.UseVisualStyleBackColor = true;
            this.btmExit.Click += new System.EventHandler(this.btmExit_Click);
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInvoices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.125F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.bitSelect,
            this.intNumber,
            this.intInvoiceNumberofVendor,
            this.datDate,
            this.intVendorNumber,
            this.nvcVendorName,
            this.nvcBuyerCoID,
            this.nvcBuyerCoIDByName,
            this.floTotalCost});
            this.dgvInvoices.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvInvoices.Location = new System.Drawing.Point(133, 235);
            this.dgvInvoices.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInvoices.MultiSelect = false;
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvInvoices.RowTemplate.Height = 55;
            this.dgvInvoices.Size = new System.Drawing.Size(1100, 353);
            this.dgvInvoices.TabIndex = 8;
            this.dgvInvoices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellContentClick);
            this.dgvInvoices.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvInvoices_CellMouseClick);
            this.dgvInvoices.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellValueChanged);
            this.dgvInvoices.Sorted += new System.EventHandler(this.DgvInvoices_Sorted);
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
            this.intNumber.HeaderText = "شماره فاکتور";
            this.intNumber.MinimumWidth = 10;
            this.intNumber.Name = "intNumber";
            this.intNumber.ReadOnly = true;
            this.intNumber.ToolTipText = "شماره فاکتور";
            // 
            // intInvoiceNumberofVendor
            // 
            this.intInvoiceNumberofVendor.DataPropertyName = "intInvoiceNumberofVendor";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intInvoiceNumberofVendor.DefaultCellStyle = dataGridViewCellStyle5;
            this.intInvoiceNumberofVendor.HeaderText = "شماره فاکتور فروشنده";
            this.intInvoiceNumberofVendor.MinimumWidth = 10;
            this.intInvoiceNumberofVendor.Name = "intInvoiceNumberofVendor";
            this.intInvoiceNumberofVendor.ReadOnly = true;
            this.intInvoiceNumberofVendor.ToolTipText = "شماره فاکتور فروشنده";
            this.intInvoiceNumberofVendor.Width = 150;
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
            // intVendorNumber
            // 
            this.intVendorNumber.DataPropertyName = "intVendorNumber";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intVendorNumber.DefaultCellStyle = dataGridViewCellStyle7;
            this.intVendorNumber.HeaderText = "شماره فروشنده";
            this.intVendorNumber.MinimumWidth = 10;
            this.intVendorNumber.Name = "intVendorNumber";
            this.intVendorNumber.ReadOnly = true;
            this.intVendorNumber.ToolTipText = "شماره فروشنده";
            this.intVendorNumber.Visible = false;
            this.intVendorNumber.Width = 117;
            // 
            // nvcVendorName
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcVendorName.DefaultCellStyle = dataGridViewCellStyle8;
            this.nvcVendorName.HeaderText = "فروشنده";
            this.nvcVendorName.MinimumWidth = 10;
            this.nvcVendorName.Name = "nvcVendorName";
            this.nvcVendorName.Width = 85;
            // 
            // nvcBuyerCoID
            // 
            this.nvcBuyerCoID.DataPropertyName = "nvcBuyerCoID";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcBuyerCoID.DefaultCellStyle = dataGridViewCellStyle9;
            this.nvcBuyerCoID.HeaderText = "کد خرید کننده";
            this.nvcBuyerCoID.MinimumWidth = 10;
            this.nvcBuyerCoID.Name = "nvcBuyerCoID";
            this.nvcBuyerCoID.ReadOnly = true;
            this.nvcBuyerCoID.ToolTipText = "کد خرید کننده";
            this.nvcBuyerCoID.Visible = false;
            this.nvcBuyerCoID.Width = 105;
            // 
            // nvcBuyerCoIDByName
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcBuyerCoIDByName.DefaultCellStyle = dataGridViewCellStyle10;
            this.nvcBuyerCoIDByName.HeaderText = "خرید کننده";
            this.nvcBuyerCoIDByName.MinimumWidth = 10;
            this.nvcBuyerCoIDByName.Name = "nvcBuyerCoIDByName";
            this.nvcBuyerCoIDByName.ToolTipText = "خرید کننده";
            this.nvcBuyerCoIDByName.Width = 88;
            // 
            // floTotalCost
            // 
            this.floTotalCost.DataPropertyName = "floTotalCost";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Format = "N0";
            dataGridViewCellStyle11.NullValue = null;
            this.floTotalCost.DefaultCellStyle = dataGridViewCellStyle11;
            this.floTotalCost.HeaderText = "مبلغ";
            this.floTotalCost.MinimumWidth = 10;
            this.floTotalCost.Name = "floTotalCost";
            this.floTotalCost.ToolTipText = "مبلغ";
            this.floTotalCost.Width = 58;
            // 
            // cbDate
            // 
            this.cbDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDate.AutoSize = true;
            this.cbDate.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.cbDate.Location = new System.Drawing.Point(373, 166);
            this.cbDate.Margin = new System.Windows.Forms.Padding(4);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(59, 21);
            this.cbDate.TabIndex = 4;
            this.cbDate.Text = "تاریخ:";
            this.cbDate.UseVisualStyleBackColor = true;
            this.cbDate.CheckedChanged += new System.EventHandler(this.CbDate_CheckedChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTo.Enabled = false;
            this.dtpTo.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.dtpTo.Location = new System.Drawing.Point(696, 164);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 24);
            this.dtpTo.TabIndex = 6;
            // 
            // labFromDate
            // 
            this.labFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labFromDate.AutoSize = true;
            this.labFromDate.Enabled = false;
            this.labFromDate.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.labFromDate.Location = new System.Drawing.Point(440, 168);
            this.labFromDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFromDate.Name = "labFromDate";
            this.labFromDate.Size = new System.Drawing.Size(21, 17);
            this.labFromDate.TabIndex = 79;
            this.labFromDate.Text = "از:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFrom.Enabled = false;
            this.dtpFrom.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.dtpFrom.Location = new System.Drawing.Point(460, 164);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 24);
            this.dtpFrom.TabIndex = 5;
            // 
            // butVendor
            // 
            this.butVendor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butVendor.AutoSize = true;
            this.butVendor.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.butVendor.Location = new System.Drawing.Point(753, 109);
            this.butVendor.Margin = new System.Windows.Forms.Padding(4);
            this.butVendor.Name = "butVendor";
            this.butVendor.Size = new System.Drawing.Size(125, 35);
            this.butVendor.TabIndex = 3;
            this.butVendor.Text = "انتخاب";
            this.butVendor.UseVisualStyleBackColor = true;
            this.butVendor.Click += new System.EventHandler(this.ButVendor_Click);
            // 
            // labVendor
            // 
            this.labVendor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labVendor.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.labVendor.Location = new System.Drawing.Point(450, 118);
            this.labVendor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labVendor.Name = "labVendor";
            this.labVendor.Size = new System.Drawing.Size(300, 17);
            this.labVendor.TabIndex = 76;
            this.labVendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label6.Location = new System.Drawing.Point(384, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 75;
            this.label6.Text = "فروشنده:";
            // 
            // tbNumber
            // 
            this.tbNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumber.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.tbNumber.Location = new System.Drawing.Point(454, 63);
            this.tbNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumber.MaxLength = 10;
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbNumber.Size = new System.Drawing.Size(120, 24);
            this.tbNumber.TabIndex = 1;
            this.tbNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNumber.TextChanged += new System.EventHandler(this.TbNumber_TextChanged);
            this.tbNumber.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            this.tbNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetNumbericCharsTextBoxes);
            // 
            // tbInvoiceNumberofVendor
            // 
            this.tbInvoiceNumberofVendor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInvoiceNumberofVendor.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.tbInvoiceNumberofVendor.Location = new System.Drawing.Point(775, 64);
            this.tbInvoiceNumberofVendor.Margin = new System.Windows.Forms.Padding(4);
            this.tbInvoiceNumberofVendor.MaxLength = 10;
            this.tbInvoiceNumberofVendor.Name = "tbInvoiceNumberofVendor";
            this.tbInvoiceNumberofVendor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbInvoiceNumberofVendor.Size = new System.Drawing.Size(120, 24);
            this.tbInvoiceNumberofVendor.TabIndex = 2;
            this.tbInvoiceNumberofVendor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbInvoiceNumberofVendor.TextChanged += new System.EventHandler(this.TbInvoiceNumberofVendor_TextChanged);
            this.tbInvoiceNumberofVendor.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            this.tbInvoiceNumberofVendor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetNumbericCharsTextBoxes);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label4.Location = new System.Drawing.Point(629, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 72;
            this.label4.Text = "شماره فاکتور فروشنده:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label2.Location = new System.Drawing.Point(367, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 71;
            this.label2.Text = "شماره فاکتور:";
            // 
            // btmSearch
            // 
            this.btmSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmSearch.AutoSize = true;
            this.btmSearch.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmSearch.Location = new System.Drawing.Point(955, 184);
            this.btmSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btmSearch.Name = "btmSearch";
            this.btmSearch.Size = new System.Drawing.Size(125, 35);
            this.btmSearch.TabIndex = 7;
            this.btmSearch.Text = "جستجو";
            this.btmSearch.UseVisualStyleBackColor = true;
            this.btmSearch.Click += new System.EventHandler(this.btmSearch_Click);
            // 
            // labToDate
            // 
            this.labToDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labToDate.AutoSize = true;
            this.labToDate.Enabled = false;
            this.labToDate.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.labToDate.Location = new System.Drawing.Point(675, 168);
            this.labToDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labToDate.Name = "labToDate";
            this.labToDate.Size = new System.Drawing.Size(21, 17);
            this.labToDate.TabIndex = 81;
            this.labToDate.Text = "تا:";
            // 
            // btmInsert
            // 
            this.btmInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmInsert.AutoSize = true;
            this.btmInsert.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmInsert.Location = new System.Drawing.Point(839, 612);
            this.btmInsert.Margin = new System.Windows.Forms.Padding(0);
            this.btmInsert.Name = "btmInsert";
            this.btmInsert.Size = new System.Drawing.Size(125, 35);
            this.btmInsert.TabIndex = 11;
            this.btmInsert.Text = "ورود";
            this.btmInsert.UseVisualStyleBackColor = true;
            this.btmInsert.Click += new System.EventHandler(this.btmInsert_Click);
            // 
            // btmDelete
            // 
            this.btmDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmDelete.AutoSize = true;
            this.btmDelete.Enabled = false;
            this.btmDelete.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmDelete.Location = new System.Drawing.Point(695, 612);
            this.btmDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btmDelete.Name = "btmDelete";
            this.btmDelete.Size = new System.Drawing.Size(125, 35);
            this.btmDelete.TabIndex = 10;
            this.btmDelete.Text = "حذف";
            this.btmDelete.UseVisualStyleBackColor = true;
            this.btmDelete.Click += new System.EventHandler(this.btmDelete_Click);
            // 
            // btmInvoiceItems
            // 
            this.btmInvoiceItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmInvoiceItems.AutoSize = true;
            this.btmInvoiceItems.Enabled = false;
            this.btmInvoiceItems.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmInvoiceItems.Location = new System.Drawing.Point(551, 612);
            this.btmInvoiceItems.Margin = new System.Windows.Forms.Padding(0);
            this.btmInvoiceItems.Name = "btmInvoiceItems";
            this.btmInvoiceItems.Size = new System.Drawing.Size(125, 35);
            this.btmInvoiceItems.TabIndex = 9;
            this.btmInvoiceItems.Text = "آیتم‌ها";
            this.btmInvoiceItems.UseVisualStyleBackColor = true;
            this.btmInvoiceItems.Click += new System.EventHandler(this.BtmInsertInvoiceItems_Click);
            // 
            // btmInvoiceImage
            // 
            this.btmInvoiceImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmInvoiceImage.AutoSize = true;
            this.btmInvoiceImage.Enabled = false;
            this.btmInvoiceImage.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmInvoiceImage.Location = new System.Drawing.Point(407, 612);
            this.btmInvoiceImage.Margin = new System.Windows.Forms.Padding(0);
            this.btmInvoiceImage.Name = "btmInvoiceImage";
            this.btmInvoiceImage.Size = new System.Drawing.Size(125, 35);
            this.btmInvoiceImage.TabIndex = 82;
            this.btmInvoiceImage.Text = "فاکتور";
            this.btmInvoiceImage.UseVisualStyleBackColor = true;
            this.btmInvoiceImage.Click += new System.EventHandler(this.BtmInvoiceImage_Click);
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.btmInvoiceImage);
            this.Controls.Add(this.btmInvoiceItems);
            this.Controls.Add(this.btmInsert);
            this.Controls.Add(this.btmDelete);
            this.Controls.Add(this.cbDate);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.butVendor);
            this.Controls.Add(this.labVendor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.tbInvoiceNumberofVendor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btmSearch);
            this.Controls.Add(this.labToDate);
            this.Controls.Add(this.dgvInvoices);
            this.Controls.Add(this.btmExit);
            this.Controls.Add(this.labFromDate);
            this.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "Invoices";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فاکتورها";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Vendors_FormClosing);
            this.Load += new System.EventHandler(this.Vendors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmExit;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bitSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn intNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn intInvoiceNumberofVendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn datDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn intVendorNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcVendorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcBuyerCoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcBuyerCoIDByName;
        private System.Windows.Forms.DataGridViewTextBoxColumn floTotalCost;
        private System.Windows.Forms.CheckBox cbDate;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label labFromDate;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button butVendor;
        public System.Windows.Forms.Label labVendor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbInvoiceNumberofVendor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btmSearch;
        private System.Windows.Forms.Label labToDate;
        private System.Windows.Forms.Button btmInsert;
        private System.Windows.Forms.Button btmDelete;
        private System.Windows.Forms.Button btmInvoiceItems;
        private System.Windows.Forms.Button btmInvoiceImage;
    }
}