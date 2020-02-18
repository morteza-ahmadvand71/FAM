namespace Baran.Ferroalloy.Management.Maintenance
{
    partial class FrmBranchInsert
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
            this.btmRegister = new System.Windows.Forms.Button();
            this.txtRegisterBranch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btmEdit = new System.Windows.Forms.Button();
            this.txtEditBranch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvListBranch = new System.Windows.Forms.DataGridView();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchBranch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btmDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBranch)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btmRegister);
            this.groupBox1.Controls.Add(this.txtRegisterBranch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 161);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ثبت شاخه جدید";
            // 
            // btmRegister
            // 
            this.btmRegister.Location = new System.Drawing.Point(19, 90);
            this.btmRegister.Name = "btmRegister";
            this.btmRegister.Size = new System.Drawing.Size(102, 33);
            this.btmRegister.TabIndex = 2;
            this.btmRegister.Text = "ورود";
            this.btmRegister.UseVisualStyleBackColor = true;
            this.btmRegister.Click += new System.EventHandler(this.BtmRegister_Click);
            // 
            // txtRegisterBranch
            // 
            this.txtRegisterBranch.Location = new System.Drawing.Point(19, 29);
            this.txtRegisterBranch.Name = "txtRegisterBranch";
            this.txtRegisterBranch.Size = new System.Drawing.Size(337, 27);
            this.txtRegisterBranch.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام شاخه:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btmEdit);
            this.groupBox2.Controls.Add(this.txtEditBranch);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 195);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ویرایش شاخه";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(24, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(389, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "برای ویرایش شاخه از لیست مقابل روی نام شاخه دوبار کلیک کنید.";
            // 
            // btmEdit
            // 
            this.btmEdit.Location = new System.Drawing.Point(19, 140);
            this.btmEdit.Name = "btmEdit";
            this.btmEdit.Size = new System.Drawing.Size(102, 33);
            this.btmEdit.TabIndex = 5;
            this.btmEdit.Text = "ویرایش";
            this.btmEdit.UseVisualStyleBackColor = true;
            this.btmEdit.Click += new System.EventHandler(this.BtmEdit_Click);
            // 
            // txtEditBranch
            // 
            this.txtEditBranch.Location = new System.Drawing.Point(19, 79);
            this.txtEditBranch.Name = "txtEditBranch";
            this.txtEditBranch.Size = new System.Drawing.Size(337, 27);
            this.txtEditBranch.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "نام شاخه:";
            // 
            // dgvListBranch
            // 
            this.dgvListBranch.AllowUserToAddRows = false;
            this.dgvListBranch.AllowUserToDeleteRows = false;
            this.dgvListBranch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListBranch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListBranch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListBranch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.nvcName,
            this.intNumber});
            this.dgvListBranch.Location = new System.Drawing.Point(16, 59);
            this.dgvListBranch.Name = "dgvListBranch";
            this.dgvListBranch.ReadOnly = true;
            this.dgvListBranch.Size = new System.Drawing.Size(250, 258);
            this.dgvListBranch.TabIndex = 2;
            this.dgvListBranch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListBranch_CellClick);
            this.dgvListBranch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListBranch_CellDoubleClick);
            // 
            // intID
            // 
            this.intID.DataPropertyName = "intID";
            this.intID.HeaderText = "intID";
            this.intID.Name = "intID";
            this.intID.ReadOnly = true;
            this.intID.Visible = false;
            // 
            // nvcName
            // 
            this.nvcName.DataPropertyName = "nvcName";
            this.nvcName.HeaderText = "نام شاخه";
            this.nvcName.Name = "nvcName";
            this.nvcName.ReadOnly = true;
            // 
            // intNumber
            // 
            this.intNumber.DataPropertyName = "intNumber";
            this.intNumber.HeaderText = "intNumber";
            this.intNumber.Name = "intNumber";
            this.intNumber.ReadOnly = true;
            this.intNumber.Visible = false;
            // 
            // txtSearchBranch
            // 
            this.txtSearchBranch.Location = new System.Drawing.Point(16, 26);
            this.txtSearchBranch.Name = "txtSearchBranch";
            this.txtSearchBranch.Size = new System.Drawing.Size(204, 27);
            this.txtSearchBranch.TabIndex = 1;
            this.txtSearchBranch.TextChanged += new System.EventHandler(this.TxtSearchBranch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btmDelete);
            this.groupBox3.Controls.Add(this.dgvListBranch);
            this.groupBox3.Controls.Add(this.txtSearchBranch);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(446, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 362);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "لیست شاخه ها";
            // 
            // btmDelete
            // 
            this.btmDelete.Location = new System.Drawing.Point(16, 323);
            this.btmDelete.Name = "btmDelete";
            this.btmDelete.Size = new System.Drawing.Size(102, 33);
            this.btmDelete.TabIndex = 7;
            this.btmDelete.Text = "حذف";
            this.btmDelete.UseVisualStyleBackColor = true;
            this.btmDelete.Click += new System.EventHandler(this.BtmDelete_Click);
            // 
            // FrmBranchInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(737, 386);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBranchInsert";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "شاخه ها";
            this.Load += new System.EventHandler(this.FrmBranchInsert_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListBranch)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btmRegister;
        private System.Windows.Forms.TextBox txtRegisterBranch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btmEdit;
        private System.Windows.Forms.TextBox txtEditBranch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvListBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn intNumber;
        private System.Windows.Forms.TextBox txtSearchBranch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btmDelete;
    }
}