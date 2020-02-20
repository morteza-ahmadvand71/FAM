namespace Baran.Ferroalloy.Management.Maintenance
{
    partial class FrmSelectPart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbStores = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBranch = new System.Windows.Forms.ComboBox();
            this.cbSubBranch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labCode = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.btmSearch = new System.Windows.Forms.Button();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.branchTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subBranchTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btmSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            this.SuspendLayout();
            // 
            // cbStores
            // 
            this.cbStores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStores.FormattingEnabled = true;
            this.cbStores.Location = new System.Drawing.Point(130, 49);
            this.cbStores.Margin = new System.Windows.Forms.Padding(4);
            this.cbStores.Name = "cbStores";
            this.cbStores.Size = new System.Drawing.Size(133, 28);
            this.cbStores.TabIndex = 34;
            this.cbStores.SelectedIndexChanged += new System.EventHandler(this.CbStores_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(94, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "انبار:";
            // 
            // cbCategories
            // 
            this.cbCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(380, 49);
            this.cbCategories.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(133, 28);
            this.cbCategories.TabIndex = 36;
            this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.CbCategories_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(339, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "رسته:";
            // 
            // cbName
            // 
            this.cbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(651, 48);
            this.cbName.Margin = new System.Windows.Forms.Padding(4);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(150, 28);
            this.cbName.TabIndex = 38;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbNames_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(595, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 21);
            this.label5.TabIndex = 37;
            this.label5.Text = "نام کالا:";
            // 
            // cbBranch
            // 
            this.cbBranch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBranch.FormattingEnabled = true;
            this.cbBranch.Location = new System.Drawing.Point(267, 114);
            this.cbBranch.Margin = new System.Windows.Forms.Padding(4);
            this.cbBranch.Name = "cbBranch";
            this.cbBranch.Size = new System.Drawing.Size(133, 28);
            this.cbBranch.TabIndex = 46;
            this.cbBranch.SelectedIndexChanged += new System.EventHandler(this.CbBranch_SelectedIndexChanged);
            // 
            // cbSubBranch
            // 
            this.cbSubBranch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSubBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubBranch.FormattingEnabled = true;
            this.cbSubBranch.Location = new System.Drawing.Point(556, 114);
            this.cbSubBranch.Margin = new System.Windows.Forms.Padding(4);
            this.cbSubBranch.Name = "cbSubBranch";
            this.cbSubBranch.Size = new System.Drawing.Size(133, 28);
            this.cbSubBranch.TabIndex = 48;
            this.cbSubBranch.SelectedIndexChanged += new System.EventHandler(this.CbSubBranch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(222, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "شاخه:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(490, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 50;
            this.label4.Text = "زیرشاخه:";
            // 
            // labCode
            // 
            this.labCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labCode.Location = new System.Drawing.Point(136, 171);
            this.labCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(169, 23);
            this.labCode.TabIndex = 54;
            // 
            // labName
            // 
            this.labName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labName.Location = new System.Drawing.Point(351, 171);
            this.labName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(204, 23);
            this.labName.TabIndex = 53;
            // 
            // btmSearch
            // 
            this.btmSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmSearch.Enabled = false;
            this.btmSearch.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btmSearch.Location = new System.Drawing.Point(615, 166);
            this.btmSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btmSearch.Name = "btmSearch";
            this.btmSearch.Size = new System.Drawing.Size(186, 28);
            this.btmSearch.TabIndex = 55;
            this.btmSearch.Text = "جستجو";
            this.btmSearch.UseVisualStyleBackColor = true;
            this.btmSearch.Click += new System.EventHandler(this.BtmSearch_Click);
            // 
            // dgvParts
            // 
            this.dgvParts.AllowUserToAddRows = false;
            this.dgvParts.AllowUserToDeleteRows = false;
            this.dgvParts.AllowUserToOrderColumns = true;
            this.dgvParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.StoreTitle,
            this.categoryTitle,
            this.nameTitle,
            this.branchTitle,
            this.subBranchTitle});
            this.dgvParts.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvParts.Location = new System.Drawing.Point(76, 219);
            this.dgvParts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.ReadOnly = true;
            this.dgvParts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvParts.RowTemplate.Height = 55;
            this.dgvParts.Size = new System.Drawing.Size(743, 228);
            this.dgvParts.TabIndex = 56;
            // 
            // intID
            // 
            this.intID.DataPropertyName = "intID";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intID.DefaultCellStyle = dataGridViewCellStyle12;
            this.intID.HeaderText = "intID";
            this.intID.MinimumWidth = 10;
            this.intID.Name = "intID";
            this.intID.ReadOnly = true;
            this.intID.Visible = false;
            // 
            // StoreTitle
            // 
            this.StoreTitle.DataPropertyName = "storeTitle";
            this.StoreTitle.HeaderText = "انبار";
            this.StoreTitle.Name = "StoreTitle";
            this.StoreTitle.ReadOnly = true;
            // 
            // categoryTitle
            // 
            this.categoryTitle.DataPropertyName = "categoryTitle";
            this.categoryTitle.HeaderText = "رسته";
            this.categoryTitle.Name = "categoryTitle";
            this.categoryTitle.ReadOnly = true;
            // 
            // nameTitle
            // 
            this.nameTitle.DataPropertyName = "nameTitle";
            this.nameTitle.HeaderText = "نام کالا";
            this.nameTitle.Name = "nameTitle";
            this.nameTitle.ReadOnly = true;
            // 
            // branchTitle
            // 
            this.branchTitle.DataPropertyName = "branchTitle";
            this.branchTitle.HeaderText = "شاخه";
            this.branchTitle.Name = "branchTitle";
            this.branchTitle.ReadOnly = true;
            // 
            // subBranchTitle
            // 
            this.subBranchTitle.DataPropertyName = "subBranchTitle";
            this.subBranchTitle.HeaderText = "زیرشاخه";
            this.subBranchTitle.Name = "subBranchTitle";
            this.subBranchTitle.ReadOnly = true;
            // 
            // btmSelect
            // 
            this.btmSelect.Location = new System.Drawing.Point(275, 484);
            this.btmSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btmSelect.Name = "btmSelect";
            this.btmSelect.Size = new System.Drawing.Size(125, 35);
            this.btmSelect.TabIndex = 57;
            this.btmSelect.Text = "انتخاب";
            this.btmSelect.UseVisualStyleBackColor = true;
            this.btmSelect.Click += new System.EventHandler(this.BtmSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(470, 484);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 35);
            this.btnClose.TabIndex = 58;
            this.btnClose.Text = "رد";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(102, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 21);
            this.label6.TabIndex = 59;
            this.label6.Text = "کد:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(315, 171);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 21);
            this.label8.TabIndex = 60;
            this.label8.Text = "نام:";
            // 
            // FrmSelectPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 591);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btmSelect);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.btmSearch);
            this.Controls.Add(this.labCode);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSubBranch);
            this.Controls.Add(this.cbBranch);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbStores);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSelectPart";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "انتخاب قطعه";
            this.Load += new System.EventHandler(this.FrmSelectPart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBranch;
        private System.Windows.Forms.ComboBox cbSubBranch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labCode;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btmSearch;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.Button btmSelect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn branchTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn subBranchTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}