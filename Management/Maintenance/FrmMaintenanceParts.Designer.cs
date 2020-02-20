namespace Baran.Ferroalloy.Management.Maintenance
{
    partial class FrmMaintenanceParts
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvMaintenanceParts = new System.Windows.Forms.DataGridView();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intMaintenaceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMaintenaceType = new System.Windows.Forms.ComboBox();
            this.labCode = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSelectPart = new System.Windows.Forms.Button();
            this.labMeasurementUnit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceParts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labMeasurementUnit);
            this.groupBox1.Controls.Add(this.btnSelectPart);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.txtCount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbMaintenaceType);
            this.groupBox1.Controls.Add(this.labCode);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 349);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ورود قطعه تعمیری";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.dgvMaintenanceParts);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(313, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(676, 349);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست قطعات تعمیری";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 313);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dgvMaintenanceParts
            // 
            this.dgvMaintenanceParts.AllowUserToAddRows = false;
            this.dgvMaintenanceParts.AllowUserToDeleteRows = false;
            this.dgvMaintenanceParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaintenanceParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintenanceParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.nvcPart,
            this.intMaintenaceType,
            this.intCount});
            this.dgvMaintenanceParts.Location = new System.Drawing.Point(6, 57);
            this.dgvMaintenanceParts.Name = "dgvMaintenanceParts";
            this.dgvMaintenanceParts.ReadOnly = true;
            this.dgvMaintenanceParts.Size = new System.Drawing.Size(664, 250);
            this.dgvMaintenanceParts.TabIndex = 2;
            // 
            // intID
            // 
            this.intID.DataPropertyName = "intID";
            this.intID.HeaderText = "intID";
            this.intID.Name = "intID";
            this.intID.ReadOnly = true;
            this.intID.Visible = false;
            // 
            // nvcPart
            // 
            this.nvcPart.DataPropertyName = "namePart";
            this.nvcPart.HeaderText = "نام قطعه";
            this.nvcPart.Name = "nvcPart";
            this.nvcPart.ReadOnly = true;
            // 
            // intMaintenaceType
            // 
            this.intMaintenaceType.DataPropertyName = "maintenanceType";
            this.intMaintenaceType.HeaderText = "نوع تعمیر";
            this.intMaintenaceType.Name = "intMaintenaceType";
            this.intMaintenaceType.ReadOnly = true;
            // 
            // intCount
            // 
            this.intCount.DataPropertyName = "count";
            this.intCount.HeaderText = "تعداد";
            this.intCount.Name = "intCount";
            this.intCount.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(600, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(622, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(6, 313);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 30);
            this.btnRegister.TabIndex = 79;
            this.btnRegister.Text = "ورود";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(118, 245);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(93, 27);
            this.txtCount.TabIndex = 87;
            this.txtCount.TextChanged += new System.EventHandler(this.TxtCount_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label7.Location = new System.Drawing.Point(220, 248);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 21);
            this.label7.TabIndex = 86;
            this.label7.Text = "مقدار:";
            // 
            // cbMaintenaceType
            // 
            this.cbMaintenaceType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMaintenaceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaintenaceType.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbMaintenaceType.FormattingEnabled = true;
            this.cbMaintenaceType.Location = new System.Drawing.Point(48, 176);
            this.cbMaintenaceType.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaintenaceType.Name = "cbMaintenaceType";
            this.cbMaintenaceType.Size = new System.Drawing.Size(163, 28);
            this.cbMaintenaceType.TabIndex = 85;
            // 
            // labCode
            // 
            this.labCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labCode.Font = new System.Drawing.Font("B Yekan", 10F);
            this.labCode.Location = new System.Drawing.Point(18, 118);
            this.labCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(197, 22);
            this.labCode.TabIndex = 83;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label8.Location = new System.Drawing.Point(223, 118);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 21);
            this.label8.TabIndex = 82;
            this.label8.Text = "کد:";
            // 
            // labName
            // 
            this.labName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labName.Font = new System.Drawing.Font("B Yekan", 10F);
            this.labName.Location = new System.Drawing.Point(18, 83);
            this.labName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(196, 22);
            this.labName.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label9.Location = new System.Drawing.Point(222, 83);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 21);
            this.label9.TabIndex = 80;
            this.label9.Text = "نام:";
            // 
            // btnSelectPart
            // 
            this.btnSelectPart.Location = new System.Drawing.Point(48, 27);
            this.btnSelectPart.Name = "btnSelectPart";
            this.btnSelectPart.Size = new System.Drawing.Size(150, 29);
            this.btnSelectPart.TabIndex = 89;
            this.btnSelectPart.Text = "انتخاب";
            this.btnSelectPart.UseVisualStyleBackColor = true;
            this.btnSelectPart.Click += new System.EventHandler(this.BtnSelectPart_Click);
            // 
            // labMeasurementUnit
            // 
            this.labMeasurementUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labMeasurementUnit.Font = new System.Drawing.Font("B Yekan", 10F);
            this.labMeasurementUnit.Location = new System.Drawing.Point(18, 245);
            this.labMeasurementUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labMeasurementUnit.Name = "labMeasurementUnit";
            this.labMeasurementUnit.Size = new System.Drawing.Size(93, 27);
            this.labMeasurementUnit.TabIndex = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 91;
            this.label2.Text = "انتخاب قطعه:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 92;
            this.label3.Text = "نوع تعمیر:";
            // 
            // FrmMaintenanceParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1001, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMaintenanceParts";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "قطعات تعمیری";
            this.Load += new System.EventHandler(this.FrmMaintenanceParts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceParts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMaintenanceParts;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn intMaintenaceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn intCount;
        private System.Windows.Forms.Button btnSelectPart;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMaintenaceType;
        private System.Windows.Forms.Label labCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labMeasurementUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}