namespace Baran.Ferroalloy.Management
{
    partial class InvoiceItems
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btmDelete = new System.Windows.Forms.Button();
            this.btmInsert = new System.Windows.Forms.Button();
            this.dgvInvoiceItems = new System.Windows.Forms.DataGridView();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.intInvoiceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intRequestNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcStoreCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcStoreCodeAsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floTotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intRequestNumberAsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labInvoiceNumber = new System.Windows.Forms.Label();
            this.labInvoiceDate = new System.Windows.Forms.Label();
            this.btmExit = new System.Windows.Forms.Button();
            this.labVendor = new System.Windows.Forms.Label();
            this.labTotalCost = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btmDelete
            // 
            this.btmDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmDelete.Enabled = false;
            this.btmDelete.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmDelete.Location = new System.Drawing.Point(310, 406);
            this.btmDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btmDelete.Name = "btmDelete";
            this.btmDelete.Size = new System.Drawing.Size(125, 35);
            this.btmDelete.TabIndex = 27;
            this.btmDelete.Text = "حذف";
            this.btmDelete.UseVisualStyleBackColor = true;
            this.btmDelete.Click += new System.EventHandler(this.BtmDelete_Click);
            // 
            // btmInsert
            // 
            this.btmInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmInsert.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmInsert.Location = new System.Drawing.Point(472, 406);
            this.btmInsert.Margin = new System.Windows.Forms.Padding(0);
            this.btmInsert.Name = "btmInsert";
            this.btmInsert.Size = new System.Drawing.Size(125, 35);
            this.btmInsert.TabIndex = 28;
            this.btmInsert.Text = "ورود ";
            this.btmInsert.UseVisualStyleBackColor = true;
            this.btmInsert.Click += new System.EventHandler(this.BtmInsert_Click);
            // 
            // dgvInvoiceItems
            // 
            this.dgvInvoiceItems.AllowUserToAddRows = false;
            this.dgvInvoiceItems.AllowUserToDeleteRows = false;
            this.dgvInvoiceItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoiceItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInvoiceItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.125F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.bitSelect,
            this.intInvoiceNumber,
            this.intRequestNumber,
            this.nvcStoreCode,
            this.nvcStoreCodeAsName,
            this.floAmount,
            this.floPrice,
            this.floTotalCost,
            this.intRequestNumberAsName});
            this.dgvInvoiceItems.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvInvoiceItems.Location = new System.Drawing.Point(84, 71);
            this.dgvInvoiceItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInvoiceItems.MultiSelect = false;
            this.dgvInvoiceItems.Name = "dgvInvoiceItems";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 10.125F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvInvoiceItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvInvoiceItems.RowTemplate.Height = 55;
            this.dgvInvoiceItems.Size = new System.Drawing.Size(743, 316);
            this.dgvInvoiceItems.TabIndex = 0;
            this.dgvInvoiceItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellContentClick);
            this.dgvInvoiceItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoices_CellValueChanged);
            // 
            // intID
            // 
            this.intID.DataPropertyName = "intID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intID.DefaultCellStyle = dataGridViewCellStyle2;
            this.intID.HeaderText = "intID";
            this.intID.MinimumWidth = 10;
            this.intID.Name = "intID";
            this.intID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.bitSelect.Width = 51;
            // 
            // intInvoiceNumber
            // 
            this.intInvoiceNumber.DataPropertyName = "intInvoiceNumber";
            this.intInvoiceNumber.HeaderText = "شماره فاکتور";
            this.intInvoiceNumber.MinimumWidth = 10;
            this.intInvoiceNumber.Name = "intInvoiceNumber";
            this.intInvoiceNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.intInvoiceNumber.ToolTipText = "شماره فاکتور";
            this.intInvoiceNumber.Visible = false;
            this.intInvoiceNumber.Width = 200;
            // 
            // intRequestNumber
            // 
            this.intRequestNumber.DataPropertyName = "intRequestNumber";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intRequestNumber.DefaultCellStyle = dataGridViewCellStyle4;
            this.intRequestNumber.HeaderText = "شماره درخواست";
            this.intRequestNumber.MinimumWidth = 10;
            this.intRequestNumber.Name = "intRequestNumber";
            this.intRequestNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.intRequestNumber.ToolTipText = "شماره درخواست";
            this.intRequestNumber.Visible = false;
            this.intRequestNumber.Width = 200;
            // 
            // nvcStoreCode
            // 
            this.nvcStoreCode.DataPropertyName = "nvcStoreCode";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcStoreCode.DefaultCellStyle = dataGridViewCellStyle5;
            this.nvcStoreCode.HeaderText = "کد کالا";
            this.nvcStoreCode.MinimumWidth = 10;
            this.nvcStoreCode.Name = "nvcStoreCode";
            this.nvcStoreCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nvcStoreCode.ToolTipText = "کد کالا";
            this.nvcStoreCode.Visible = false;
            this.nvcStoreCode.Width = 550;
            // 
            // nvcStoreCodeAsName
            // 
            this.nvcStoreCodeAsName.DataPropertyName = "nvcStoreCodeAsName";
            this.nvcStoreCodeAsName.HeaderText = "کالا";
            this.nvcStoreCodeAsName.MinimumWidth = 10;
            this.nvcStoreCodeAsName.Name = "nvcStoreCodeAsName";
            this.nvcStoreCodeAsName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nvcStoreCodeAsName.Width = 34;
            // 
            // floAmount
            // 
            this.floAmount.DataPropertyName = "floAmount";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "N0";
            this.floAmount.DefaultCellStyle = dataGridViewCellStyle6;
            this.floAmount.HeaderText = "مقدار";
            this.floAmount.MinimumWidth = 10;
            this.floAmount.Name = "floAmount";
            this.floAmount.ReadOnly = true;
            this.floAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.floAmount.ToolTipText = "مقدار";
            this.floAmount.Width = 44;
            // 
            // floPrice
            // 
            this.floPrice.DataPropertyName = "floPrice";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.floPrice.DefaultCellStyle = dataGridViewCellStyle7;
            this.floPrice.HeaderText = "قیمت واحد (ریال)";
            this.floPrice.MinimumWidth = 10;
            this.floPrice.Name = "floPrice";
            this.floPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.floPrice.ToolTipText = "قیمت واحد (ریال)";
            this.floPrice.Width = 102;
            // 
            // floTotalCost
            // 
            this.floTotalCost.DataPropertyName = "floTotalCost";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "N0";
            this.floTotalCost.DefaultCellStyle = dataGridViewCellStyle8;
            this.floTotalCost.HeaderText = "قیمت کل (ریال)";
            this.floTotalCost.MinimumWidth = 10;
            this.floTotalCost.Name = "floTotalCost";
            this.floTotalCost.ToolTipText = "قیمت کل (ریال)";
            this.floTotalCost.Width = 113;
            // 
            // intRequestNumberAsName
            // 
            this.intRequestNumberAsName.DataPropertyName = "intRequestNumberAsName";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intRequestNumberAsName.DefaultCellStyle = dataGridViewCellStyle9;
            this.intRequestNumberAsName.HeaderText = "درخواست";
            this.intRequestNumberAsName.MinimumWidth = 10;
            this.intRequestNumberAsName.Name = "intRequestNumberAsName";
            this.intRequestNumberAsName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.intRequestNumberAsName.ToolTipText = "درخواست";
            this.intRequestNumberAsName.Width = 71;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "تاریخ:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(607, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "فروشنده:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "شماره فاکتور:";
            // 
            // labInvoiceNumber
            // 
            this.labInvoiceNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labInvoiceNumber.AutoSize = true;
            this.labInvoiceNumber.Location = new System.Drawing.Point(264, 39);
            this.labInvoiceNumber.Name = "labInvoiceNumber";
            this.labInvoiceNumber.Size = new System.Drawing.Size(24, 17);
            this.labInvoiceNumber.TabIndex = 24;
            this.labInvoiceNumber.Text = "00";
            // 
            // labInvoiceDate
            // 
            this.labInvoiceDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labInvoiceDate.AutoSize = true;
            this.labInvoiceDate.Location = new System.Drawing.Point(393, 39);
            this.labInvoiceDate.Name = "labInvoiceDate";
            this.labInvoiceDate.Size = new System.Drawing.Size(24, 17);
            this.labInvoiceDate.TabIndex = 25;
            this.labInvoiceDate.Text = "00";
            // 
            // btmExit
            // 
            this.btmExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmExit.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmExit.Location = new System.Drawing.Point(390, 477);
            this.btmExit.Margin = new System.Windows.Forms.Padding(0);
            this.btmExit.Name = "btmExit";
            this.btmExit.Size = new System.Drawing.Size(125, 35);
            this.btmExit.TabIndex = 26;
            this.btmExit.Text = "خروج";
            this.btmExit.UseVisualStyleBackColor = true;
            this.btmExit.Click += new System.EventHandler(this.BtmExit_Click);
            // 
            // labVendor
            // 
            this.labVendor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labVendor.AutoSize = true;
            this.labVendor.Location = new System.Drawing.Point(673, 39);
            this.labVendor.Name = "labVendor";
            this.labVendor.Size = new System.Drawing.Size(24, 17);
            this.labVendor.TabIndex = 27;
            this.labVendor.Text = "00";
            this.labVendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labTotalCost
            // 
            this.labTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labTotalCost.Location = new System.Drawing.Point(679, 395);
            this.labTotalCost.Name = "labTotalCost";
            this.labTotalCost.Size = new System.Drawing.Size(95, 17);
            this.labTotalCost.TabIndex = 30;
            this.labTotalCost.Text = "00";
            this.labTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(777, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "ریال";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(645, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "کل:";
            // 
            // InvoiceItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(908, 569);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labTotalCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labVendor);
            this.Controls.Add(this.btmExit);
            this.Controls.Add(this.labInvoiceDate);
            this.Controls.Add(this.btmInsert);
            this.Controls.Add(this.btmDelete);
            this.Controls.Add(this.labInvoiceNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInvoiceItems);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceItems";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "آیتم ها";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InvoiceItems_FormClosing);
            this.Load += new System.EventHandler(this.InvoiceItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvoiceItems;
      
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labInvoiceNumber;
        private System.Windows.Forms.Label labInvoiceDate;
        private System.Windows.Forms.Button btmExit;
        private System.Windows.Forms.Button btmDelete;
        private System.Windows.Forms.Button btmInsert;
        public System.Windows.Forms.Label labVendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bitSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn intInvoiceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn intRequestNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcStoreCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcStoreCodeAsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn floAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn floPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn floTotalCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn intRequestNumberAsName;
        private System.Windows.Forms.Label labTotalCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}