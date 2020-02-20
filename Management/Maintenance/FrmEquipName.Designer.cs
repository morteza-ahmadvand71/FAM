using System.Windows.Forms;

namespace Baran.Ferroalloy.Management
{
    partial class FrmEquipName
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
            this.txtEquipName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btmEdit = new System.Windows.Forms.Button();
            this.txtEditEquipName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvListEquipName = new System.Windows.Forms.DataGridView();
            this.txtSearchEquipName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbRegister.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEquipName)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRegister
            // 
            this.gbRegister.Controls.Add(this.btmRegister);
            this.gbRegister.Controls.Add(this.txtEquipName);
            this.gbRegister.Controls.Add(this.label2);
            this.gbRegister.Location = new System.Drawing.Point(12, 12);
            this.gbRegister.Name = "gbRegister";
            this.gbRegister.Size = new System.Drawing.Size(419, 161);
            this.gbRegister.TabIndex = 6;
            this.gbRegister.TabStop = false;
            this.gbRegister.Text = "ثبت نام جدید";
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
            // txtEquipName
            // 
            this.txtEquipName.Location = new System.Drawing.Point(19, 29);
            this.txtEquipName.Name = "txtEquipName";
            this.txtEquipName.Size = new System.Drawing.Size(331, 27);
            this.txtEquipName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام تجهیز:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btmEdit);
            this.groupBox2.Controls.Add(this.txtEditEquipName);
            this.groupBox2.Location = new System.Drawing.Point(12, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 195);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ویرایش نام";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(105, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "برای ویرایش نام از لیست مقابل روی نام کلیک کنید.";
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
            // txtEditEquipName
            // 
            this.txtEditEquipName.Location = new System.Drawing.Point(19, 79);
            this.txtEditEquipName.Name = "txtEditEquipName";
            this.txtEditEquipName.Size = new System.Drawing.Size(331, 27);
            this.txtEditEquipName.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.dgvListEquipName);
            this.groupBox3.Controls.Add(this.txtSearchEquipName);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(446, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 362);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "لیست نام ها";
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
            // dgvListEquipName
            // 
            this.dgvListEquipName.AllowUserToAddRows = false;
            this.dgvListEquipName.AllowUserToDeleteRows = false;
            this.dgvListEquipName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListEquipName.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListEquipName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListEquipName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.nvcName,
            this.intNumber});
            this.dgvListEquipName.Location = new System.Drawing.Point(16, 59);
            this.dgvListEquipName.Name = "dgvListEquipName";
            this.dgvListEquipName.ReadOnly = true;
            this.dgvListEquipName.Size = new System.Drawing.Size(250, 258);
            this.dgvListEquipName.TabIndex = 2;
            this.dgvListEquipName.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListEquipName_CellClick);
            // 
            // txtSearchEquipName
            // 
            this.txtSearchEquipName.Location = new System.Drawing.Point(16, 26);
            this.txtSearchEquipName.Name = "txtSearchEquipName";
            this.txtSearchEquipName.Size = new System.Drawing.Size(204, 27);
            this.txtSearchEquipName.TabIndex = 1;
            this.txtSearchEquipName.TextChanged += new System.EventHandler(this.TxtSearchEquipName_TextChanged);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "نام تجهیز:";
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
            this.nvcName.HeaderText = "نام تجهیز";
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
            // FrmEquipName
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
            this.Name = "FrmEquipName";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لیست نام";
            this.Load += new System.EventHandler(this.FrmEquipName_Load);
            this.gbRegister.ResumeLayout(false);
            this.gbRegister.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListEquipName)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private GroupBox gbRegister;
        private Button btmRegister;
        private TextBox txtEquipName;
        private Label label2;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Button btmEdit;
        private TextBox txtEditEquipName;
        private GroupBox groupBox3;
        private Button btnDelete;
        private DataGridView dgvListEquipName;
        private DataGridViewTextBoxColumn intID;
        private DataGridViewTextBoxColumn nvcName;
        private DataGridViewTextBoxColumn intNumber;
        private TextBox txtSearchEquipName;
        private Label label1;
    }
}

