namespace Baran.Ferroalloy.Management
{
    partial class Projects
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
            this.btmExit = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTip = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btmSearch = new System.Windows.Forms.Button();
            this.btmSubprojects = new System.Windows.Forms.Button();
            this.btmDelete = new System.Windows.Forms.Button();
            this.btmInsert = new System.Windows.Forms.Button();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.intNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intCategoryAsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcTip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // btmExit
            // 
            this.btmExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmExit.AutoSize = true;
            this.btmExit.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmExit.Location = new System.Drawing.Point(548, 702);
            this.btmExit.Margin = new System.Windows.Forms.Padding(0);
            this.btmExit.Name = "btmExit";
            this.btmExit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btmExit.Size = new System.Drawing.Size(125, 35);
            this.btmExit.TabIndex = 9;
            this.btmExit.Text = "خروج";
            this.btmExit.UseVisualStyleBackColor = true;
            this.btmExit.Click += new System.EventHandler(this.btmExit_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(803, 55);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(150, 24);
            this.cbCategory.TabIndex = 60;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.CbCategory_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(758, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 67;
            this.label4.Text = "رسته:";
            // 
            // tbTip
            // 
            this.tbTip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTip.Location = new System.Drawing.Point(470, 110);
            this.tbTip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTip.MaxLength = 200;
            this.tbTip.Multiline = true;
            this.tbTip.Name = "tbTip";
            this.tbTip.Size = new System.Drawing.Size(400, 62);
            this.tbTip.TabIndex = 63;
            this.tbTip.TextChanged += new System.EventHandler(this.TbTip_TextChanged);
            this.tbTip.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 113);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 65;
            this.label7.Text = "توضیح:";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(377, 54);
            this.tbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbName.MaxLength = 200;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(150, 24);
            this.tbName.TabIndex = 61;
            this.tbName.TextChanged += new System.EventHandler(this.TbName_TextChanged);
            this.tbName.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 66;
            this.label6.Text = "نام:";
            // 
            // tbNumber
            // 
            this.tbNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumber.Location = new System.Drawing.Point(609, 54);
            this.tbNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNumber.MaxLength = 20;
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbNumber.Size = new System.Drawing.Size(120, 24);
            this.tbNumber.TabIndex = 59;
            this.tbNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNumber.TextChanged += new System.EventHandler(this.TbNumber_TextChanged);
            this.tbNumber.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            this.tbNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetNumbericCharsTextBoxes);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "شماره:";
            // 
            // btmSearch
            // 
            this.btmSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmSearch.AutoSize = true;
            this.btmSearch.Location = new System.Drawing.Point(873, 192);
            this.btmSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btmSearch.Name = "btmSearch";
            this.btmSearch.Size = new System.Drawing.Size(125, 35);
            this.btmSearch.TabIndex = 64;
            this.btmSearch.Text = "جستجو";
            this.btmSearch.UseVisualStyleBackColor = true;
            this.btmSearch.Click += new System.EventHandler(this.btmSearch_Click);
            // 
            // btmSubprojects
            // 
            this.btmSubprojects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmSubprojects.AutoSize = true;
            this.btmSubprojects.Enabled = false;
            this.btmSubprojects.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmSubprojects.Location = new System.Drawing.Point(392, 624);
            this.btmSubprojects.Margin = new System.Windows.Forms.Padding(0);
            this.btmSubprojects.Name = "btmSubprojects";
            this.btmSubprojects.Size = new System.Drawing.Size(125, 35);
            this.btmSubprojects.TabIndex = 69;
            this.btmSubprojects.Text = "زیرپروژه‌ها";
            this.btmSubprojects.UseVisualStyleBackColor = true;
            this.btmSubprojects.Click += new System.EventHandler(this.BtmSubProjects_Click);
            // 
            // btmDelete
            // 
            this.btmDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmDelete.AutoSize = true;
            this.btmDelete.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmDelete.Location = new System.Drawing.Point(548, 624);
            this.btmDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btmDelete.Name = "btmDelete";
            this.btmDelete.Size = new System.Drawing.Size(125, 35);
            this.btmDelete.TabIndex = 71;
            this.btmDelete.Text = "حذف";
            this.btmDelete.UseVisualStyleBackColor = true;
            this.btmDelete.Click += new System.EventHandler(this.btmDelete_Click);
            // 
            // btmInsert
            // 
            this.btmInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmInsert.AutoSize = true;
            this.btmInsert.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmInsert.Location = new System.Drawing.Point(704, 624);
            this.btmInsert.Margin = new System.Windows.Forms.Padding(0);
            this.btmInsert.Name = "btmInsert";
            this.btmInsert.Size = new System.Drawing.Size(125, 35);
            this.btmInsert.TabIndex = 70;
            this.btmInsert.Text = "ورود پروژه";
            this.btmInsert.UseVisualStyleBackColor = true;
            this.btmInsert.Click += new System.EventHandler(this.btmInsert_Click);
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.AllowUserToDeleteRows = false;
            this.dgvProjects.AllowUserToOrderColumns = true;
            this.dgvProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.125F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.bitSelect,
            this.intNumber,
            this.intCategory,
            this.intCategoryAsName,
            this.nvcName,
            this.nvcTip});
            this.dgvProjects.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvProjects.Location = new System.Drawing.Point(129, 247);
            this.dgvProjects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvProjects.RowTemplate.Height = 55;
            this.dgvProjects.Size = new System.Drawing.Size(1100, 353);
            this.dgvProjects.TabIndex = 68;
            this.dgvProjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjects_CellContentClick);
            this.dgvProjects.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvProjects_CellMouseClick);
            this.dgvProjects.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjects_CellValueChanged);
            this.dgvProjects.Sorted += new System.EventHandler(this.DgvProjects_Sorted);
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
            this.intNumber.HeaderText = "شماره پروژه";
            this.intNumber.MinimumWidth = 10;
            this.intNumber.Name = "intNumber";
            this.intNumber.ReadOnly = true;
            this.intNumber.ToolTipText = "شماره پروژه";
            this.intNumber.Width = 104;
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
            this.intCategoryAsName.HeaderText = "رسته";
            this.intCategoryAsName.MinimumWidth = 10;
            this.intCategoryAsName.Name = "intCategoryAsName";
            this.intCategoryAsName.ToolTipText = "رسته";
            this.intCategoryAsName.Width = 65;
            // 
            // nvcName
            // 
            this.nvcName.DataPropertyName = "nvcName";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcName.DefaultCellStyle = dataGridViewCellStyle6;
            this.nvcName.HeaderText = "نام";
            this.nvcName.MinimumWidth = 10;
            this.nvcName.Name = "nvcName";
            this.nvcName.ReadOnly = true;
            this.nvcName.ToolTipText = "نام";
            this.nvcName.Width = 49;
            // 
            // nvcTip
            // 
            this.nvcTip.DataPropertyName = "nvcTip";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcTip.DefaultCellStyle = dataGridViewCellStyle7;
            this.nvcTip.HeaderText = "توضیح";
            this.nvcTip.MinimumWidth = 10;
            this.nvcTip.Name = "nvcTip";
            this.nvcTip.ReadOnly = true;
            this.nvcTip.ToolTipText = "توضیح";
            this.nvcTip.Width = 69;
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.btmSubprojects);
            this.Controls.Add(this.btmDelete);
            this.Controls.Add(this.btmInsert);
            this.Controls.Add(this.dgvProjects);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btmSearch);
            this.Controls.Add(this.btmExit);
            this.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Projects";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "پروژه‌ها";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Projects_FormClosing);
            this.Load += new System.EventHandler(this.Vendors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmExit;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btmSearch;
        private System.Windows.Forms.Button btmSubprojects;
        private System.Windows.Forms.Button btmDelete;
        private System.Windows.Forms.Button btmInsert;
        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bitSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn intNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn intCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn intCategoryAsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcTip;
    }
}