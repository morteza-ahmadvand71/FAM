namespace Baran.Ferroalloy.Management
{
    partial class Subprojects
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
            this.btmDelete = new System.Windows.Forms.Button();
            this.btmInsert = new System.Windows.Forms.Button();
            this.dgvSubprojects = new System.Windows.Forms.DataGridView();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.intProjectNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intCategoryAsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intProgress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcTip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labCategory = new System.Windows.Forms.Label();
            this.labTip = new System.Windows.Forms.Label();
            this.labProjectNumber = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.btmExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubprojects)).BeginInit();
            this.SuspendLayout();
            // 
            // btmDelete
            // 
            this.btmDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmDelete.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmDelete.Location = new System.Drawing.Point(310, 406);
            this.btmDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btmDelete.Name = "btmDelete";
            this.btmDelete.Size = new System.Drawing.Size(125, 35);
            this.btmDelete.TabIndex = 2;
            this.btmDelete.Text = "حذف";
            this.btmDelete.UseVisualStyleBackColor = true;
            this.btmDelete.Click += new System.EventHandler(this.btmDelete_Click);
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
            this.btmInsert.TabIndex = 1;
            this.btmInsert.Text = "ورود ";
            this.btmInsert.UseVisualStyleBackColor = true;
            this.btmInsert.Click += new System.EventHandler(this.btmInsert_Click);
            // 
            // dgvSubprojects
            // 
            this.dgvSubprojects.AllowUserToAddRows = false;
            this.dgvSubprojects.AllowUserToDeleteRows = false;
            this.dgvSubprojects.AllowUserToOrderColumns = true;
            this.dgvSubprojects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSubprojects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSubprojects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.125F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubprojects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubprojects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubprojects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.bitSelect,
            this.intProjectNumber,
            this.intCategory,
            this.intCategoryAsName,
            this.nvcName,
            this.datStart,
            this.intDuration,
            this.intProgress,
            this.nvcTip});
            this.dgvSubprojects.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvSubprojects.Location = new System.Drawing.Point(84, 71);
            this.dgvSubprojects.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSubprojects.MultiSelect = false;
            this.dgvSubprojects.Name = "dgvSubprojects";
            this.dgvSubprojects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSubprojects.RowTemplate.Height = 55;
            this.dgvSubprojects.Size = new System.Drawing.Size(743, 316);
            this.dgvSubprojects.TabIndex = 0;
            this.dgvSubprojects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubprojects_CellContentClick);
            this.dgvSubprojects.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubprojects_CellValueChanged);
            this.dgvSubprojects.Sorted += new System.EventHandler(this.DgvSubprojects_Sorted);
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
            // intProjectNumber
            // 
            this.intProjectNumber.DataPropertyName = "intProjectNumber";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intProjectNumber.DefaultCellStyle = dataGridViewCellStyle4;
            this.intProjectNumber.HeaderText = "شماره پروژه";
            this.intProjectNumber.MinimumWidth = 10;
            this.intProjectNumber.Name = "intProjectNumber";
            this.intProjectNumber.ToolTipText = "شماره پروژه";
            this.intProjectNumber.Visible = false;
            this.intProjectNumber.Width = 104;
            // 
            // intCategory
            // 
            this.intCategory.DataPropertyName = "intCategory";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intCategory.DefaultCellStyle = dataGridViewCellStyle5;
            this.intCategory.HeaderText = "کد سته";
            this.intCategory.MinimumWidth = 10;
            this.intCategory.Name = "intCategory";
            this.intCategory.ToolTipText = "کد سته";
            this.intCategory.Visible = false;
            this.intCategory.Width = 79;
            // 
            // intCategoryAsName
            // 
            this.intCategoryAsName.DataPropertyName = "intCategoryAsName";
            this.intCategoryAsName.HeaderText = "رسته";
            this.intCategoryAsName.Name = "intCategoryAsName";
            this.intCategoryAsName.ToolTipText = "رسته";
            this.intCategoryAsName.Width = 65;
            // 
            // nvcName
            // 
            this.nvcName.DataPropertyName = "nvcName";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.nvcName.DefaultCellStyle = dataGridViewCellStyle6;
            this.nvcName.HeaderText = "نام";
            this.nvcName.MinimumWidth = 10;
            this.nvcName.Name = "nvcName";
            this.nvcName.ReadOnly = true;
            this.nvcName.ToolTipText = "نام";
            this.nvcName.Width = 49;
            // 
            // datStart
            // 
            this.datStart.DataPropertyName = "datStart";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "D";
            dataGridViewCellStyle7.NullValue = null;
            this.datStart.DefaultCellStyle = dataGridViewCellStyle7;
            this.datStart.HeaderText = "تاریخ شروع";
            this.datStart.MinimumWidth = 10;
            this.datStart.Name = "datStart";
            this.datStart.ToolTipText = "تاریخ شروع";
            this.datStart.Width = 98;
            // 
            // intDuration
            // 
            this.intDuration.DataPropertyName = "intDuration";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intDuration.DefaultCellStyle = dataGridViewCellStyle8;
            this.intDuration.HeaderText = "مدت";
            this.intDuration.MinimumWidth = 10;
            this.intDuration.Name = "intDuration";
            this.intDuration.ToolTipText = "مدت";
            this.intDuration.Width = 59;
            // 
            // intProgress
            // 
            this.intProgress.DataPropertyName = "intProgress";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intProgress.DefaultCellStyle = dataGridViewCellStyle9;
            this.intProgress.HeaderText = "پیشرفت";
            this.intProgress.MinimumWidth = 10;
            this.intProgress.Name = "intProgress";
            this.intProgress.ReadOnly = true;
            this.intProgress.ToolTipText = "پیشرفت";
            this.intProgress.Width = 82;
            // 
            // nvcTip
            // 
            this.nvcTip.DataPropertyName = "nvcTip";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.nvcTip.DefaultCellStyle = dataGridViewCellStyle10;
            this.nvcTip.HeaderText = "توضیح";
            this.nvcTip.MinimumWidth = 10;
            this.nvcTip.Name = "nvcTip";
            this.nvcTip.ReadOnly = true;
            this.nvcTip.ToolTipText = "توضیح";
            this.nvcTip.Width = 69;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "نام:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "رسته:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "توضیح:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "شماره پروژه:";
            // 
            // labCategory
            // 
            this.labCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labCategory.AutoSize = true;
            this.labCategory.Location = new System.Drawing.Point(445, 30);
            this.labCategory.Name = "labCategory";
            this.labCategory.Size = new System.Drawing.Size(24, 17);
            this.labCategory.TabIndex = 23;
            this.labCategory.Text = "00";
            // 
            // labTip
            // 
            this.labTip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labTip.AutoSize = true;
            this.labTip.Location = new System.Drawing.Point(311, 64);
            this.labTip.Name = "labTip";
            this.labTip.Size = new System.Drawing.Size(24, 17);
            this.labTip.TabIndex = 23;
            this.labTip.Text = "00";
            // 
            // labProjectNumber
            // 
            this.labProjectNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labProjectNumber.AutoSize = true;
            this.labProjectNumber.Location = new System.Drawing.Point(345, 30);
            this.labProjectNumber.Name = "labProjectNumber";
            this.labProjectNumber.Size = new System.Drawing.Size(24, 17);
            this.labProjectNumber.TabIndex = 24;
            this.labProjectNumber.Text = "00";
            // 
            // labName
            // 
            this.labName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(525, 30);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(24, 17);
            this.labName.TabIndex = 25;
            this.labName.Text = "00";
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
            this.btmExit.TabIndex = 3;
            this.btmExit.Text = "خروج";
            this.btmExit.UseVisualStyleBackColor = true;
            this.btmExit.Click += new System.EventHandler(this.BtmExit_Click);
            // 
            // Subprojects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(908, 569);
            this.Controls.Add(this.btmDelete);
            this.Controls.Add(this.btmExit);
            this.Controls.Add(this.btmInsert);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.dgvSubprojects);
            this.Controls.Add(this.labProjectNumber);
            this.Controls.Add(this.labTip);
            this.Controls.Add(this.labCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Subprojects";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "زیرپروژه‌ها";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Subprojects_FormClosing);
            this.Load += new System.EventHandler(this.Subprojects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubprojects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubprojects;
      
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labCategory;
        private System.Windows.Forms.Label labTip;
        private System.Windows.Forms.Label labProjectNumber;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btmExit;
        private System.Windows.Forms.Button btmDelete;
        private System.Windows.Forms.Button btmInsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bitSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn intProjectNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn intCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn intCategoryAsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn datStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn intDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn intProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcTip;
    }
}