namespace Baran.Ferroalloy.Management
{
    partial class RequestInsert
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
            this.btmOK = new System.Windows.Forms.Button();
            this.btmCancel = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbRowBudget = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.butEmployee1 = new System.Windows.Forms.Button();
            this.labEmployee1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.butEmployee2 = new System.Windows.Forms.Button();
            this.labEmployee2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.butEmployee3 = new System.Windows.Forms.Button();
            this.labEmployee3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.butEmployee4 = new System.Windows.Forms.Button();
            this.labEmployee4 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btmOK
            // 
            this.btmOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmOK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btmOK.Location = new System.Drawing.Point(293, 369);
            this.btmOK.Margin = new System.Windows.Forms.Padding(4);
            this.btmOK.Name = "btmOK";
            this.btmOK.Size = new System.Drawing.Size(125, 35);
            this.btmOK.TabIndex = 8;
            this.btmOK.Text = "تایید";
            this.btmOK.UseVisualStyleBackColor = true;
            this.btmOK.Click += new System.EventHandler(this.btmOK_Click);
            // 
            // btmCancel
            // 
            this.btmCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btmCancel.Location = new System.Drawing.Point(444, 369);
            this.btmCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btmCancel.Name = "btmCancel";
            this.btmCancel.Size = new System.Drawing.Size(125, 35);
            this.btmCancel.TabIndex = 9;
            this.btmCancel.Text = "رد";
            this.btmCancel.UseVisualStyleBackColor = true;
            this.btmCancel.Click += new System.EventHandler(this.btmCancel_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Location = new System.Drawing.Point(344, 79);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 24);
            this.dtpDate.TabIndex = 64;
            this.dtpDate.ValueChanged += new System.EventHandler(this.DtpDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 63;
            this.label1.Text = "تاریخ:";
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(332, 29);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(150, 24);
            this.cbCategory.TabIndex = 70;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.CbCategory_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 69;
            this.label7.Text = "رسته:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1257, 425);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 75;
            this.label6.Text = "مدیر عامل:";
            // 
            // cbRowBudget
            // 
            this.cbRowBudget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRowBudget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRowBudget.FormattingEnabled = true;
            this.cbRowBudget.Location = new System.Drawing.Point(593, 29);
            this.cbRowBudget.Name = "cbRowBudget";
            this.cbRowBudget.Size = new System.Drawing.Size(200, 24);
            this.cbRowBudget.TabIndex = 78;
            this.cbRowBudget.SelectedIndexChanged += new System.EventHandler(this.CbRowBudget_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(512, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 77;
            this.label2.Text = "ردیف بودجه:";
            // 
            // cbDepartment
            // 
            this.cbDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(105, 29);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(150, 24);
            this.cbDepartment.TabIndex = 80;
            this.cbDepartment.SelectedIndexChanged += new System.EventHandler(this.CbDepartment_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 79;
            this.label8.Text = "دپارتمان:";
            // 
            // butEmployee1
            // 
            this.butEmployee1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butEmployee1.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.butEmployee1.Location = new System.Drawing.Point(563, 126);
            this.butEmployee1.Name = "butEmployee1";
            this.butEmployee1.Size = new System.Drawing.Size(125, 35);
            this.butEmployee1.TabIndex = 94;
            this.butEmployee1.Text = "انتخاب";
            this.butEmployee1.UseVisualStyleBackColor = true;
            this.butEmployee1.Click += new System.EventHandler(this.ButEmployee1_Click);
            // 
            // labEmployee1
            // 
            this.labEmployee1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labEmployee1.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.labEmployee1.Location = new System.Drawing.Point(260, 131);
            this.labEmployee1.Name = "labEmployee1";
            this.labEmployee1.Size = new System.Drawing.Size(300, 25);
            this.labEmployee1.TabIndex = 93;
            this.labEmployee1.Text = "انتخاب کنید";
            this.labEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labEmployee1.Click += new System.EventHandler(this.LabEmployee1_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label9.Location = new System.Drawing.Point(156, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 17);
            this.label9.TabIndex = 92;
            this.label9.Text = "درخواست کننده:";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // butEmployee2
            // 
            this.butEmployee2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butEmployee2.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.butEmployee2.Location = new System.Drawing.Point(563, 179);
            this.butEmployee2.Name = "butEmployee2";
            this.butEmployee2.Size = new System.Drawing.Size(125, 35);
            this.butEmployee2.TabIndex = 97;
            this.butEmployee2.Text = "انتخاب";
            this.butEmployee2.UseVisualStyleBackColor = true;
            this.butEmployee2.Click += new System.EventHandler(this.ButEmployee2_Click);
            // 
            // labEmployee2
            // 
            this.labEmployee2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labEmployee2.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.labEmployee2.Location = new System.Drawing.Point(260, 184);
            this.labEmployee2.Name = "labEmployee2";
            this.labEmployee2.Size = new System.Drawing.Size(300, 25);
            this.labEmployee2.TabIndex = 96;
            this.labEmployee2.Text = "انتخاب کنید";
            this.labEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label11.Location = new System.Drawing.Point(156, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 95;
            this.label11.Text = "مدیر واحد:";
            // 
            // butEmployee3
            // 
            this.butEmployee3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butEmployee3.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.butEmployee3.Location = new System.Drawing.Point(563, 233);
            this.butEmployee3.Name = "butEmployee3";
            this.butEmployee3.Size = new System.Drawing.Size(125, 35);
            this.butEmployee3.TabIndex = 100;
            this.butEmployee3.Text = "انتخاب";
            this.butEmployee3.UseVisualStyleBackColor = true;
            this.butEmployee3.Click += new System.EventHandler(this.ButEmployee3_Click);
            // 
            // labEmployee3
            // 
            this.labEmployee3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labEmployee3.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.labEmployee3.Location = new System.Drawing.Point(260, 238);
            this.labEmployee3.Name = "labEmployee3";
            this.labEmployee3.Size = new System.Drawing.Size(300, 25);
            this.labEmployee3.TabIndex = 99;
            this.labEmployee3.Text = "انتخاب کنید";
            this.labEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label13.Location = new System.Drawing.Point(156, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 17);
            this.label13.TabIndex = 98;
            this.label13.Text = "مدیر کارخانه:";
            // 
            // butEmployee4
            // 
            this.butEmployee4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butEmployee4.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.butEmployee4.Location = new System.Drawing.Point(563, 289);
            this.butEmployee4.Name = "butEmployee4";
            this.butEmployee4.Size = new System.Drawing.Size(125, 35);
            this.butEmployee4.TabIndex = 103;
            this.butEmployee4.Text = "انتخاب";
            this.butEmployee4.UseVisualStyleBackColor = true;
            this.butEmployee4.Click += new System.EventHandler(this.ButEmployee4_Click);
            // 
            // labEmployee4
            // 
            this.labEmployee4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labEmployee4.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.labEmployee4.Location = new System.Drawing.Point(260, 294);
            this.labEmployee4.Name = "labEmployee4";
            this.labEmployee4.Size = new System.Drawing.Size(300, 25);
            this.labEmployee4.TabIndex = 102;
            this.labEmployee4.Text = "انتخاب کنید";
            this.labEmployee4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label4.Location = new System.Drawing.Point(156, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 101;
            this.label4.Text = "مدیر عامل:";
            // 
            // RequestInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(861, 453);
            this.Controls.Add(this.butEmployee4);
            this.Controls.Add(this.labEmployee4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butEmployee3);
            this.Controls.Add(this.labEmployee3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.butEmployee2);
            this.Controls.Add(this.labEmployee2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.butEmployee1);
            this.Controls.Add(this.labEmployee1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbRowBudget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btmCancel);
            this.Controls.Add(this.btmOK);
            this.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RequestInsert";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ورود درخواست جدید";
            this.Load += new System.EventHandler(this.RequestInsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btmOK;
        private System.Windows.Forms.Button btmCancel;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbRowBudget;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button butEmployee1;
        public System.Windows.Forms.Label labEmployee1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button butEmployee2;
        public System.Windows.Forms.Label labEmployee2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button butEmployee3;
        public System.Windows.Forms.Label labEmployee3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button butEmployee4;
        public System.Windows.Forms.Label labEmployee4;
        private System.Windows.Forms.Label label4;
    }
}