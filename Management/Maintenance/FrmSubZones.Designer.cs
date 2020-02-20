using System.Windows.Forms;

namespace Baran.Ferroalloy.Management.Maintenance
{
    partial class FrmSubZones
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
            this.txtNameSubZone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btmEdit = new System.Windows.Forms.Button();
            this.txtEditSubZone = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btmDelete = new System.Windows.Forms.Button();
            this.dgvListSubZone = new System.Windows.Forms.DataGridView();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchSubZone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSubZone)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btmRegister);
            this.groupBox1.Controls.Add(this.txtNameSubZone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 161);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ثبت زیربخش جدید";
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
            // txtNameSubZone
            // 
            this.txtNameSubZone.Location = new System.Drawing.Point(19, 29);
            this.txtNameSubZone.Name = "txtNameSubZone";
            this.txtNameSubZone.Size = new System.Drawing.Size(316, 27);
            this.txtNameSubZone.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام زیربخش:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btmEdit);
            this.groupBox2.Controls.Add(this.txtEditSubZone);
            this.groupBox2.Location = new System.Drawing.Point(12, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 195);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ویرایش زیربخش";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "نام زیربخش:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(22, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(391, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "برای ویرایش زیربخش از لیست مقابل روی نام زیربخش کلیک کنید.";
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
            // txtEditSubZone
            // 
            this.txtEditSubZone.Location = new System.Drawing.Point(19, 79);
            this.txtEditSubZone.Name = "txtEditSubZone";
            this.txtEditSubZone.Size = new System.Drawing.Size(316, 27);
            this.txtEditSubZone.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btmDelete);
            this.groupBox3.Controls.Add(this.dgvListSubZone);
            this.groupBox3.Controls.Add(this.txtSearchSubZone);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(446, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 362);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "لیست زیربخش ها";
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
            // dgvListSubZone
            // 
            this.dgvListSubZone.AllowUserToAddRows = false;
            this.dgvListSubZone.AllowUserToDeleteRows = false;
            this.dgvListSubZone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListSubZone.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListSubZone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListSubZone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.nvcName,
            this.intNumber});
            this.dgvListSubZone.Location = new System.Drawing.Point(16, 59);
            this.dgvListSubZone.Name = "dgvListSubZone";
            this.dgvListSubZone.ReadOnly = true;
            this.dgvListSubZone.Size = new System.Drawing.Size(250, 258);
            this.dgvListSubZone.TabIndex = 2;
            this.dgvListSubZone.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListSubZone_CellClick);
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
            this.nvcName.HeaderText = "نام زیربخش";
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
            // txtSearchSubZone
            // 
            this.txtSearchSubZone.Location = new System.Drawing.Point(16, 26);
            this.txtSearchSubZone.Name = "txtSearchSubZone";
            this.txtSearchSubZone.Size = new System.Drawing.Size(204, 27);
            this.txtSearchSubZone.TabIndex = 1;
            this.txtSearchSubZone.TextChanged += new System.EventHandler(this.TxtSearchSubZone_TextChanged);
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
            // FrmSubZones
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
            this.Name = "FrmSubZones";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لیست زیربخش ها";
            this.Load += new System.EventHandler(this.FrmSubZones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSubZone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btmRegister;
        private TextBox txtNameSubZone;
        private Label label2;
        private GroupBox groupBox2;
        private Label label3;
        private Label label4;
        private Button btmEdit;
        private TextBox txtEditSubZone;
        private GroupBox groupBox3;
        private Button btmDelete;
        private DataGridView dgvListSubZone;
        private DataGridViewTextBoxColumn intID;
        private DataGridViewTextBoxColumn nvcName;
        private DataGridViewTextBoxColumn intNumber;
        private TextBox txtSearchSubZone;
        private Label label1;
    }
}

