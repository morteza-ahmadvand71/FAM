namespace Baran.Ferroalloy.Management.Maintenance
{
    partial class FrmMaintenanceItems
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
            this.btnSelectEquip = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtWorker = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtTips = new System.Windows.Forms.TextBox();
            this.chbIsSuccessful = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chbIsNeedToShutDown = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chbIsDueToShutDown = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbWorkGroup = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimeItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEquip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvMaintenanceItems = new System.Windows.Forms.DataGridView();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcEquip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceItems)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelectEquip);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtWorker);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.txtTips);
            this.groupBox1.Controls.Add(this.chbIsSuccessful);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.chbIsNeedToShutDown);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.chbIsDueToShutDown);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbWorkGroup);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDuration);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTimeItem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEquip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ورود آیتم تعمیراتی";
            // 
            // btnSelectEquip
            // 
            this.btnSelectEquip.Location = new System.Drawing.Point(420, 26);
            this.btnSelectEquip.Name = "btnSelectEquip";
            this.btnSelectEquip.Size = new System.Drawing.Size(72, 26);
            this.btnSelectEquip.TabIndex = 42;
            this.btnSelectEquip.Text = "انتخاب";
            this.btnSelectEquip.UseVisualStyleBackColor = true;
            this.btnSelectEquip.Click += new System.EventHandler(this.BtnSelectEquip_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(519, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 20);
            this.label11.TabIndex = 40;
            this.label11.Text = "شرح:";
            // 
            // txtWorker
            // 
            this.txtWorker.Location = new System.Drawing.Point(7, 92);
            this.txtWorker.Multiline = true;
            this.txtWorker.Name = "txtWorker";
            this.txtWorker.Size = new System.Drawing.Size(476, 27);
            this.txtWorker.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(488, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "تعمیرکاران:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(6, 369);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 32);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "ورود";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // txtTips
            // 
            this.txtTips.Location = new System.Drawing.Point(7, 234);
            this.txtTips.Multiline = true;
            this.txtTips.Name = "txtTips";
            this.txtTips.Size = new System.Drawing.Size(547, 129);
            this.txtTips.TabIndex = 37;
            // 
            // chbIsSuccessful
            // 
            this.chbIsSuccessful.AutoSize = true;
            this.chbIsSuccessful.Location = new System.Drawing.Point(529, 181);
            this.chbIsSuccessful.Name = "chbIsSuccessful";
            this.chbIsSuccessful.Size = new System.Drawing.Size(15, 14);
            this.chbIsSuccessful.TabIndex = 36;
            this.chbIsSuccessful.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "آیا تعمیر موفقیت آمیز بوده است؟";
            // 
            // chbIsNeedToShutDown
            // 
            this.chbIsNeedToShutDown.AutoSize = true;
            this.chbIsNeedToShutDown.Location = new System.Drawing.Point(529, 161);
            this.chbIsNeedToShutDown.Name = "chbIsNeedToShutDown";
            this.chbIsNeedToShutDown.Size = new System.Drawing.Size(15, 14);
            this.chbIsNeedToShutDown.TabIndex = 34;
            this.chbIsNeedToShutDown.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "آیا موقع تعمیر نیاز است که دستگاه خاموش شود؟";
            // 
            // chbIsDueToShutDown
            // 
            this.chbIsDueToShutDown.AutoSize = true;
            this.chbIsDueToShutDown.Location = new System.Drawing.Point(529, 139);
            this.chbIsDueToShutDown.Name = "chbIsDueToShutDown";
            this.chbIsDueToShutDown.Size = new System.Drawing.Size(15, 14);
            this.chbIsDueToShutDown.TabIndex = 32;
            this.chbIsDueToShutDown.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "آیا موقع تعمیر دستگاه خاموش شده است؟";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "نوع تعمیر:";
            // 
            // cbWorkGroup
            // 
            this.cbWorkGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWorkGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorkGroup.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbWorkGroup.FormattingEnabled = true;
            this.cbWorkGroup.Location = new System.Drawing.Point(7, 26);
            this.cbWorkGroup.Margin = new System.Windows.Forms.Padding(4);
            this.cbWorkGroup.Name = "cbWorkGroup";
            this.cbWorkGroup.Size = new System.Drawing.Size(199, 28);
            this.cbWorkGroup.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "دقیقه";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(51, 59);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(155, 27);
            this.txtDuration.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "مدت:";
            // 
            // txtTimeItem
            // 
            this.txtTimeItem.Location = new System.Drawing.Point(279, 59);
            this.txtTimeItem.Name = "txtTimeItem";
            this.txtTimeItem.Size = new System.Drawing.Size(204, 27);
            this.txtTimeItem.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ساعت تعمیر:";
            // 
            // txtEquip
            // 
            this.txtEquip.Enabled = false;
            this.txtEquip.Location = new System.Drawing.Point(279, 26);
            this.txtEquip.Name = "txtEquip";
            this.txtEquip.Size = new System.Drawing.Size(135, 27);
            this.txtEquip.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام تجهیز:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.dgvMaintenanceItems);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(578, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 407);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست آیتم های تعمیراتی";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 32);
            this.button1.TabIndex = 41;
            this.button1.Text = "ورود قطعات تعمیراتی";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(153, 369);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dgvMaintenanceItems
            // 
            this.dgvMaintenanceItems.AllowUserToAddRows = false;
            this.dgvMaintenanceItems.AllowUserToDeleteRows = false;
            this.dgvMaintenanceItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaintenanceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintenanceItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.nvcEquip});
            this.dgvMaintenanceItems.Location = new System.Drawing.Point(6, 62);
            this.dgvMaintenanceItems.Name = "dgvMaintenanceItems";
            this.dgvMaintenanceItems.ReadOnly = true;
            this.dgvMaintenanceItems.Size = new System.Drawing.Size(399, 301);
            this.dgvMaintenanceItems.TabIndex = 2;
            // 
            // intID
            // 
            this.intID.DataPropertyName = "intID";
            this.intID.HeaderText = "intID";
            this.intID.Name = "intID";
            this.intID.ReadOnly = true;
            this.intID.Visible = false;
            // 
            // nvcEquip
            // 
            this.nvcEquip.DataPropertyName = "nvcEquip";
            this.nvcEquip.HeaderText = "نام تجهیز";
            this.nvcEquip.Name = "nvcEquip";
            this.nvcEquip.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(345, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو:";
            // 
            // FrmMaintenanceItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1001, 431);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMaintenanceItems";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "آیتم های تعمیراتی";
            this.Load += new System.EventHandler(this.FrmMaintenanceItems_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenanceItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMaintenanceItems;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimeItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtWorker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtTips;
        private System.Windows.Forms.CheckBox chbIsSuccessful;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chbIsNeedToShutDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chbIsDueToShutDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbWorkGroup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcEquip;
        private System.Windows.Forms.Button btnSelectEquip;
        private System.Windows.Forms.TextBox txtEquip;
    }
}