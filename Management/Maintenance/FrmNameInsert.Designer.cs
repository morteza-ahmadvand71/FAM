namespace Baran.Ferroalloy.Management.Maintenance
{
    partial class FrmNameInsert
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
            this.label2 = new System.Windows.Forms.Label();
            this.gbRegister = new System.Windows.Forms.GroupBox();
            this.btmRegister = new System.Windows.Forms.Button();
            this.txtRegisterName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btmEdit = new System.Windows.Forms.Button();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvListName = new System.Windows.Forms.DataGridView();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbRegister.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListName)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام کالا:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // gbRegister
            // 
            this.gbRegister.Controls.Add(this.btmRegister);
            this.gbRegister.Controls.Add(this.txtRegisterName);
            this.gbRegister.Controls.Add(this.label2);
            this.gbRegister.Location = new System.Drawing.Point(12, 12);
            this.gbRegister.Name = "gbRegister";
            this.gbRegister.Size = new System.Drawing.Size(419, 161);
            this.gbRegister.TabIndex = 3;
            this.gbRegister.TabStop = false;
            this.gbRegister.Text = "ثبت کالای جدید";
            this.gbRegister.Enter += new System.EventHandler(this.GbRegister_Enter);
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
            // txtRegisterName
            // 
            this.txtRegisterName.Location = new System.Drawing.Point(19, 29);
            this.txtRegisterName.Name = "txtRegisterName";
            this.txtRegisterName.Size = new System.Drawing.Size(343, 27);
            this.txtRegisterName.TabIndex = 1;
            this.txtRegisterName.TextChanged += new System.EventHandler(this.TxtRegisterName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(82, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "برای ویرایش کالا از لیست مقابل روی نام کالا کلیک کنید.";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
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
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(19, 79);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(343, 27);
            this.txtEditName.TabIndex = 4;
            this.txtEditName.TextChanged += new System.EventHandler(this.TxtEditName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "نام کالا:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.dgvListName);
            this.groupBox3.Controls.Add(this.txtSearchName);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(446, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 362);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "لیست کالا ها";
            this.groupBox3.Enter += new System.EventHandler(this.GroupBox3_Enter);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(16, 323);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 33);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dgvListName
            // 
            this.dgvListName.AllowUserToAddRows = false;
            this.dgvListName.AllowUserToDeleteRows = false;
            this.dgvListName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListName.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.nvcName,
            this.intNumber});
            this.dgvListName.Location = new System.Drawing.Point(16, 59);
            this.dgvListName.Name = "dgvListName";
            this.dgvListName.ReadOnly = true;
            this.dgvListName.Size = new System.Drawing.Size(250, 258);
            this.dgvListName.TabIndex = 2;
            this.dgvListName.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListName_CellClick);
            this.dgvListName.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListName_CellContentClick);
            this.dgvListName.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListName_CellDoubleClick);
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
            this.nvcName.HeaderText = "نام کالا";
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
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(16, 26);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(204, 27);
            this.txtSearchName.TabIndex = 1;
            this.txtSearchName.TextChanged += new System.EventHandler(this.TxtSearchCategory_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btmEdit);
            this.groupBox2.Controls.Add(this.txtEditName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 195);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ویرایش کالا";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // FrmNameInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(737, 386);
            this.Controls.Add(this.gbRegister);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNameInsert";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "نام کالاها";
            this.Load += new System.EventHandler(this.FrmNameInsert_Load);
            this.gbRegister.ResumeLayout(false);
            this.gbRegister.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListName)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbRegister;
        private System.Windows.Forms.Button btmRegister;
        private System.Windows.Forms.TextBox txtRegisterName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btmEdit;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvListName;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn intNumber;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
    }
}