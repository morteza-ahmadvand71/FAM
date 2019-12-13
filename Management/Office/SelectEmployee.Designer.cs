namespace Baran.Ferroalloy.Management
{
    partial class SelectEmployee
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
            this.cbNoName = new System.Windows.Forms.CheckBox();
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCoID = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btmSearch = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btmSelect = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nvcFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intDepartmentAsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcNationalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcCoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcTip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btmInsertEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNoName
            // 
            this.cbNoName.AutoSize = true;
            this.cbNoName.Location = new System.Drawing.Point(145, 136);
            this.cbNoName.Name = "cbNoName";
            this.cbNoName.Size = new System.Drawing.Size(60, 25);
            this.cbNoName.TabIndex = 29;
            this.cbNoName.Text = "بی نام";
            this.cbNoName.UseVisualStyleBackColor = true;
            this.cbNoName.CheckedChanged += new System.EventHandler(this.CbNoName_CheckedChanged);
            // 
            // cbDepartments
            // 
            this.cbDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.Location = new System.Drawing.Point(533, 36);
            this.cbDepartments.Margin = new System.Windows.Forms.Padding(4);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(150, 28);
            this.cbDepartments.TabIndex = 23;
            this.cbDepartments.SelectedIndexChanged += new System.EventHandler(this.CbDepartments_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "واحد:";
            // 
            // tbCoID
            // 
            this.tbCoID.Location = new System.Drawing.Point(252, 36);
            this.tbCoID.Margin = new System.Windows.Forms.Padding(4);
            this.tbCoID.MaxLength = 4;
            this.tbCoID.Name = "tbCoID";
            this.tbCoID.Size = new System.Drawing.Size(80, 28);
            this.tbCoID.TabIndex = 25;
            this.tbCoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCoID.TextChanged += new System.EventHandler(this.TbCoID_TextChanged);
            this.tbCoID.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            this.tbCoID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetNumbericCharsTextBoxes);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(286, 82);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(150, 28);
            this.tbLastName.TabIndex = 22;
            this.tbLastName.TextChanged += new System.EventHandler(this.TbLastName_TextChanged);
            this.tbLastName.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            this.tbLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetNumbericCharsTextBoxes);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "کد پرسنلی:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "نام خانوادگی:";
            // 
            // btmSearch
            // 
            this.btmSearch.Enabled = false;
            this.btmSearch.Location = new System.Drawing.Point(640, 129);
            this.btmSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btmSearch.Name = "btmSearch";
            this.btmSearch.Size = new System.Drawing.Size(125, 35);
            this.btmSearch.TabIndex = 27;
            this.btmSearch.Text = "جستجو";
            this.btmSearch.UseVisualStyleBackColor = true;
            this.btmSearch.Click += new System.EventHandler(this.btmSearch_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(504, 82);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(150, 28);
            this.tbFirstName.TabIndex = 21;
            this.tbFirstName.TextChanged += new System.EventHandler(this.TbFirstName_TextChanged);
            this.tbFirstName.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            this.tbFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetNumbericCharsTextBoxes);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "نام:";
            // 
            // btmSelect
            // 
            this.btmSelect.Enabled = false;
            this.btmSelect.Location = new System.Drawing.Point(466, 477);
            this.btmSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btmSelect.Name = "btmSelect";
            this.btmSelect.Size = new System.Drawing.Size(125, 35);
            this.btmSelect.TabIndex = 31;
            this.btmSelect.Text = "انتخاب";
            this.btmSelect.UseVisualStyleBackColor = true;
            this.btmSelect.Click += new System.EventHandler(this.BtmSelect_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AllowUserToOrderColumns = true;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmployees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Yekan", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.bitSelect,
            this.nvcFirstName,
            this.nvcLastName,
            this.intDepartment,
            this.intDepartmentAsName,
            this.nvcNationalID,
            this.nvcCoID,
            this.nvcTip});
            this.dgvEmployees.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvEmployees.Location = new System.Drawing.Point(84, 188);
            this.dgvEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvEmployees.RowTemplate.Height = 55;
            this.dgvEmployees.Size = new System.Drawing.Size(743, 228);
            this.dgvEmployees.TabIndex = 30;
            this.dgvEmployees.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvEmployees_CellMouseClick);
            this.dgvEmployees.Sorted += new System.EventHandler(this.DgvEmployees_Sorted);
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
            // nvcFirstName
            // 
            this.nvcFirstName.DataPropertyName = "nvcFirstName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.nvcFirstName.DefaultCellStyle = dataGridViewCellStyle4;
            this.nvcFirstName.HeaderText = "نام";
            this.nvcFirstName.MinimumWidth = 10;
            this.nvcFirstName.Name = "nvcFirstName";
            this.nvcFirstName.ReadOnly = true;
            this.nvcFirstName.ToolTipText = "نام کوچک";
            this.nvcFirstName.Width = 50;
            // 
            // nvcLastName
            // 
            this.nvcLastName.DataPropertyName = "nvcLastName";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.nvcLastName.DefaultCellStyle = dataGridViewCellStyle5;
            this.nvcLastName.HeaderText = "نام خانوادگی";
            this.nvcLastName.MinimumWidth = 10;
            this.nvcLastName.Name = "nvcLastName";
            this.nvcLastName.ReadOnly = true;
            this.nvcLastName.Width = 99;
            // 
            // intDepartment
            // 
            this.intDepartment.DataPropertyName = "intDepartment";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intDepartment.DefaultCellStyle = dataGridViewCellStyle6;
            this.intDepartment.HeaderText = "کد واحد";
            this.intDepartment.MinimumWidth = 10;
            this.intDepartment.Name = "intDepartment";
            this.intDepartment.ReadOnly = true;
            this.intDepartment.ToolTipText = "کد واحد";
            this.intDepartment.Visible = false;
            this.intDepartment.Width = 78;
            // 
            // intDepartmentAsName
            // 
            this.intDepartmentAsName.DataPropertyName = "intDepartmentAsName";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intDepartmentAsName.DefaultCellStyle = dataGridViewCellStyle7;
            this.intDepartmentAsName.HeaderText = "واحد";
            this.intDepartmentAsName.MinimumWidth = 10;
            this.intDepartmentAsName.Name = "intDepartmentAsName";
            this.intDepartmentAsName.ReadOnly = true;
            this.intDepartmentAsName.ToolTipText = "واحد";
            this.intDepartmentAsName.Width = 60;
            // 
            // nvcNationalID
            // 
            this.nvcNationalID.DataPropertyName = "nvcNationalID";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcNationalID.DefaultCellStyle = dataGridViewCellStyle8;
            this.nvcNationalID.HeaderText = "کد ملی";
            this.nvcNationalID.MinimumWidth = 10;
            this.nvcNationalID.Name = "nvcNationalID";
            this.nvcNationalID.ReadOnly = true;
            this.nvcNationalID.Width = 71;
            // 
            // nvcCoID
            // 
            this.nvcCoID.DataPropertyName = "nvcCoID";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcCoID.DefaultCellStyle = dataGridViewCellStyle9;
            this.nvcCoID.HeaderText = "کد پرسنلی";
            this.nvcCoID.MinimumWidth = 10;
            this.nvcCoID.Name = "nvcCoID";
            this.nvcCoID.ReadOnly = true;
            this.nvcCoID.ToolTipText = "کد پرسنلی";
            this.nvcCoID.Width = 91;
            // 
            // nvcTip
            // 
            this.nvcTip.DataPropertyName = "nvcTip";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nvcTip.DefaultCellStyle = dataGridViewCellStyle10;
            this.nvcTip.HeaderText = "شرح";
            this.nvcTip.MinimumWidth = 10;
            this.nvcTip.Name = "nvcTip";
            this.nvcTip.ReadOnly = true;
            this.nvcTip.Visible = false;
            this.nvcTip.Width = 62;
            // 
            // btmInsertEmployee
            // 
            this.btmInsertEmployee.Location = new System.Drawing.Point(321, 477);
            this.btmInsertEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btmInsertEmployee.Name = "btmInsertEmployee";
            this.btmInsertEmployee.Size = new System.Drawing.Size(125, 35);
            this.btmInsertEmployee.TabIndex = 32;
            this.btmInsertEmployee.Text = "ورود کارمند";
            this.btmInsertEmployee.UseVisualStyleBackColor = true;
            this.btmInsertEmployee.Click += new System.EventHandler(this.BtmInsertEmployee_Click);
            // 
            // SelectEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(914, 561);
            this.Controls.Add(this.btmInsertEmployee);
            this.Controls.Add(this.btmSelect);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.cbNoName);
            this.Controls.Add(this.cbDepartments);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCoID);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btmSearch);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Yekan", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectEmployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "انتخاب کارمند";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employees_FormClosing);
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbNoName;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCoID;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btmSearch;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btmSelect;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bitSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn intDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn intDepartmentAsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcNationalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcCoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcTip;
        private System.Windows.Forms.Button btmInsertEmployee;
    }
}