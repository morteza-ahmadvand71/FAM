namespace Baran.Ferroalloy.Management.Maintenance
{
    partial class FrmMeasurementUnitsInsert
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
            this.gbRegister = new System.Windows.Forms.GroupBox();
            this.btmRegister = new System.Windows.Forms.Button();
            this.txtRegisterMeasurementUnits = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btmEdit = new System.Windows.Forms.Button();
            this.txtEditMeasurementUnits = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btmDelete = new System.Windows.Forms.Button();
            this.dgvListMeasurementUnits = new System.Windows.Forms.DataGridView();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchMeasurementUnits = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbRegister.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMeasurementUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRegister
            // 
            this.gbRegister.Controls.Add(this.btmRegister);
            this.gbRegister.Controls.Add(this.txtRegisterMeasurementUnits);
            this.gbRegister.Controls.Add(this.label2);
            this.gbRegister.Location = new System.Drawing.Point(12, 12);
            this.gbRegister.Name = "gbRegister";
            this.gbRegister.Size = new System.Drawing.Size(419, 161);
            this.gbRegister.TabIndex = 6;
            this.gbRegister.TabStop = false;
            this.gbRegister.Text = "ثبت واحد اندازه گیری";
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
            // txtRegisterMeasurementUnits
            // 
            this.txtRegisterMeasurementUnits.Location = new System.Drawing.Point(19, 29);
            this.txtRegisterMeasurementUnits.Name = "txtRegisterMeasurementUnits";
            this.txtRegisterMeasurementUnits.Size = new System.Drawing.Size(274, 27);
            this.txtRegisterMeasurementUnits.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام واحد اندازه گیری:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btmEdit);
            this.groupBox2.Controls.Add(this.txtEditMeasurementUnits);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 195);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ویرایش واحد اندازه گیری";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Yekan", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(56, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(357, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "برای ویرایش واحد اندازه گیری از لیست مقابل روی آن کلیک کنید.";
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
            // txtEditMeasurementUnits
            // 
            this.txtEditMeasurementUnits.Location = new System.Drawing.Point(19, 79);
            this.txtEditMeasurementUnits.Name = "txtEditMeasurementUnits";
            this.txtEditMeasurementUnits.Size = new System.Drawing.Size(274, 27);
            this.txtEditMeasurementUnits.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "نام واحد اندازه گیری:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btmDelete);
            this.groupBox3.Controls.Add(this.dgvListMeasurementUnits);
            this.groupBox3.Controls.Add(this.txtSearchMeasurementUnits);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(446, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 362);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "لیست واحد اندازه گیری";
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
            // dgvListMeasurementUnits
            // 
            this.dgvListMeasurementUnits.AllowUserToAddRows = false;
            this.dgvListMeasurementUnits.AllowUserToDeleteRows = false;
            this.dgvListMeasurementUnits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListMeasurementUnits.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListMeasurementUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListMeasurementUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.nvcName,
            this.intNumber});
            this.dgvListMeasurementUnits.Location = new System.Drawing.Point(16, 59);
            this.dgvListMeasurementUnits.Name = "dgvListMeasurementUnits";
            this.dgvListMeasurementUnits.ReadOnly = true;
            this.dgvListMeasurementUnits.Size = new System.Drawing.Size(250, 258);
            this.dgvListMeasurementUnits.TabIndex = 2;
            this.dgvListMeasurementUnits.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListMeasurementUnits_CellClick);
            this.dgvListMeasurementUnits.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListMeasurementUnits_CellDoubleClick);
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
            this.nvcName.HeaderText = "نام واحد اندازه گیری";
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
            // txtSearchMeasurementUnits
            // 
            this.txtSearchMeasurementUnits.Location = new System.Drawing.Point(16, 26);
            this.txtSearchMeasurementUnits.Name = "txtSearchMeasurementUnits";
            this.txtSearchMeasurementUnits.Size = new System.Drawing.Size(204, 27);
            this.txtSearchMeasurementUnits.TabIndex = 1;
            this.txtSearchMeasurementUnits.TextChanged += new System.EventHandler(this.TxtSearchMeasurementUnits_TextChanged);
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
            // FrmMeasurementUnitsInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(737, 386);
            this.Controls.Add(this.gbRegister);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMeasurementUnitsInsert";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "واحدهای اندازه گیری";
            this.Load += new System.EventHandler(this.FrmMeasurementUnitsInsert_Load);
            this.gbRegister.ResumeLayout(false);
            this.gbRegister.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMeasurementUnits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegister;
        private System.Windows.Forms.Button btmRegister;
        private System.Windows.Forms.TextBox txtRegisterMeasurementUnits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btmEdit;
        private System.Windows.Forms.TextBox txtEditMeasurementUnits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvListMeasurementUnits;
        private System.Windows.Forms.TextBox txtSearchMeasurementUnits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn intNumber;
        private System.Windows.Forms.Button btmDelete;
    }
}