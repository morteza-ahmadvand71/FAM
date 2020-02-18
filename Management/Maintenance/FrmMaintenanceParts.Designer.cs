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
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMaintenaceType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labCode = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbSubBranch = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbBranch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbStores = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvMaintenanceParts = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intMaintenaceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceParts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.txtCount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbMaintenaceType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labCode);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbSubBranch);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbBranch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbCategories);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbStores);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 349);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ورود قطعه تعمیری";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(16, 304);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 30);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "ورود";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(80, 229);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(119, 27);
            this.txtCount.TabIndex = 69;
            this.txtCount.TextChanged += new System.EventHandler(this.TxtCount_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label7.Location = new System.Drawing.Point(206, 232);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 21);
            this.label7.TabIndex = 68;
            this.label7.Text = "مقدار:";
            // 
            // cbMaintenaceType
            // 
            this.cbMaintenaceType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMaintenaceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaintenaceType.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbMaintenaceType.FormattingEnabled = true;
            this.cbMaintenaceType.Location = new System.Drawing.Point(295, 229);
            this.cbMaintenaceType.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaintenaceType.Name = "cbMaintenaceType";
            this.cbMaintenaceType.Size = new System.Drawing.Size(120, 28);
            this.cbMaintenaceType.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label6.Location = new System.Drawing.Point(423, 232);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 21);
            this.label6.TabIndex = 64;
            this.label6.Text = "نوع تعمیر:";
            // 
            // labCode
            // 
            this.labCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labCode.Font = new System.Drawing.Font("B Yekan", 10F);
            this.labCode.Location = new System.Drawing.Point(154, 183);
            this.labCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(196, 22);
            this.labCode.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label8.Location = new System.Drawing.Point(358, 183);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 21);
            this.label8.TabIndex = 60;
            this.label8.Text = "کد:";
            // 
            // labName
            // 
            this.labName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labName.Font = new System.Drawing.Font("B Yekan", 10F);
            this.labName.Location = new System.Drawing.Point(154, 145);
            this.labName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(196, 22);
            this.labName.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label9.Location = new System.Drawing.Point(358, 145);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 21);
            this.label9.TabIndex = 58;
            this.label9.Text = "نام:";
            // 
            // cbSubBranch
            // 
            this.cbSubBranch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSubBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubBranch.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbSubBranch.FormattingEnabled = true;
            this.cbSubBranch.Location = new System.Drawing.Point(16, 90);
            this.cbSubBranch.Margin = new System.Windows.Forms.Padding(4);
            this.cbSubBranch.Name = "cbSubBranch";
            this.cbSubBranch.Size = new System.Drawing.Size(120, 28);
            this.cbSubBranch.TabIndex = 57;
            this.cbSubBranch.SelectedIndexChanged += new System.EventHandler(this.CbSubBranch_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label11.Location = new System.Drawing.Point(144, 94);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 21);
            this.label11.TabIndex = 56;
            this.label11.Text = "زیرشاخه:";
            // 
            // cbBranch
            // 
            this.cbBranch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBranch.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbBranch.FormattingEnabled = true;
            this.cbBranch.Location = new System.Drawing.Point(210, 88);
            this.cbBranch.Margin = new System.Windows.Forms.Padding(4);
            this.cbBranch.Name = "cbBranch";
            this.cbBranch.Size = new System.Drawing.Size(120, 28);
            this.cbBranch.TabIndex = 55;
            this.cbBranch.SelectedIndexChanged += new System.EventHandler(this.CbBranch_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label4.Location = new System.Drawing.Point(338, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 54;
            this.label4.Text = "شاخه:";
            // 
            // cbName
            // 
            this.cbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbName.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(387, 87);
            this.cbName.Margin = new System.Windows.Forms.Padding(4);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(120, 28);
            this.cbName.TabIndex = 53;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.CbName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label3.Location = new System.Drawing.Point(515, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 52;
            this.label3.Text = "نام کالا:";
            // 
            // cbCategories
            // 
            this.cbCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(80, 27);
            this.cbCategories.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(120, 28);
            this.cbCategories.TabIndex = 50;
            this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.CbCategories_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label5.Location = new System.Drawing.Point(208, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 51;
            this.label5.Text = "رسته:";
            // 
            // cbStores
            // 
            this.cbStores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStores.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbStores.FormattingEnabled = true;
            this.cbStores.Location = new System.Drawing.Point(295, 27);
            this.cbStores.Margin = new System.Windows.Forms.Padding(4);
            this.cbStores.Name = "cbStores";
            this.cbStores.Size = new System.Drawing.Size(120, 28);
            this.cbStores.TabIndex = 49;
            this.cbStores.SelectedIndexChanged += new System.EventHandler(this.CbStores_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label2.Location = new System.Drawing.Point(423, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 48;
            this.label2.Text = "انبار:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.dgvMaintenanceParts);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(599, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 349);
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
            this.dgvMaintenanceParts.Size = new System.Drawing.Size(378, 250);
            this.dgvMaintenanceParts.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(324, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو:";
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
        private System.Windows.Forms.ComboBox cbSubBranch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbBranch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbStores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMaintenaceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn intMaintenaceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn intCount;
    }
}