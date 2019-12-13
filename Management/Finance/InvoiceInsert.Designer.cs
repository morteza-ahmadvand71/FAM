namespace Baran.Ferroalloy.Management
{
    partial class InvoiceInsert
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
            this.labEmployee = new System.Windows.Forms.Label();
            this.butEmployee = new System.Windows.Forms.Button();
            this.labVendor = new System.Windows.Forms.Label();
            this.butVendor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tbInvoiceNumberofVendor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btmCancel = new System.Windows.Forms.Button();
            this.btmOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labEmployee
            // 
            this.labEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labEmployee.Location = new System.Drawing.Point(436, 47);
            this.labEmployee.Name = "labEmployee";
            this.labEmployee.Size = new System.Drawing.Size(253, 17);
            this.labEmployee.TabIndex = 84;
            this.labEmployee.Text = "انتخاب کنید ...";
            this.labEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // butEmployee
            // 
            this.butEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butEmployee.Location = new System.Drawing.Point(737, 37);
            this.butEmployee.Name = "butEmployee";
            this.butEmployee.Size = new System.Drawing.Size(125, 35);
            this.butEmployee.TabIndex = 83;
            this.butEmployee.Text = "انتخاب";
            this.butEmployee.UseVisualStyleBackColor = true;
            this.butEmployee.Click += new System.EventHandler(this.ButEmployee_Click);
            // 
            // labVendor
            // 
            this.labVendor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labVendor.Location = new System.Drawing.Point(296, 103);
            this.labVendor.Name = "labVendor";
            this.labVendor.Size = new System.Drawing.Size(253, 17);
            this.labVendor.TabIndex = 82;
            this.labVendor.Text = "انتخاب کنید ...";
            this.labVendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // butVendor
            // 
            this.butVendor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butVendor.Location = new System.Drawing.Point(602, 93);
            this.butVendor.Name = "butVendor";
            this.butVendor.Size = new System.Drawing.Size(125, 35);
            this.butVendor.TabIndex = 81;
            this.butVendor.Text = "انتخاب";
            this.butVendor.UseVisualStyleBackColor = true;
            this.butVendor.Click += new System.EventHandler(this.ButVendor_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 80;
            this.label6.Text = "فروشنده:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 79;
            this.label3.Text = "خریدکننده:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 75;
            this.label4.Text = "شماره فاکتور فروشنده:";
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDate.Location = new System.Drawing.Point(382, 145);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 24);
            this.dtpDate.TabIndex = 78;
            this.dtpDate.ValueChanged += new System.EventHandler(this.DtpDate_ValueChanged);
            // 
            // tbInvoiceNumberofVendor
            // 
            this.tbInvoiceNumberofVendor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInvoiceNumberofVendor.Location = new System.Drawing.Point(219, 44);
            this.tbInvoiceNumberofVendor.MaxLength = 10;
            this.tbInvoiceNumberofVendor.Name = "tbInvoiceNumberofVendor";
            this.tbInvoiceNumberofVendor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbInvoiceNumberofVendor.Size = new System.Drawing.Size(120, 24);
            this.tbInvoiceNumberofVendor.TabIndex = 76;
            this.tbInvoiceNumberofVendor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbInvoiceNumberofVendor.TextChanged += new System.EventHandler(this.TbInvoiceNumberofVendor_TextChanged);
            this.tbInvoiceNumberofVendor.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            this.tbInvoiceNumberofVendor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetNumbericCharsTextBoxes);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 77;
            this.label1.Text = "تاریخ:";
            // 
            // btmCancel
            // 
            this.btmCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmCancel.AutoSize = true;
            this.btmCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btmCancel.Location = new System.Drawing.Point(487, 205);
            this.btmCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btmCancel.Name = "btmCancel";
            this.btmCancel.Size = new System.Drawing.Size(125, 35);
            this.btmCancel.TabIndex = 74;
            this.btmCancel.Text = "رد";
            this.btmCancel.UseVisualStyleBackColor = true;
            this.btmCancel.Click += new System.EventHandler(this.btmCancel_Click);
            // 
            // btmOK
            // 
            this.btmOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmOK.AutoSize = true;
            this.btmOK.Enabled = false;
            this.btmOK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btmOK.Location = new System.Drawing.Point(330, 205);
            this.btmOK.Margin = new System.Windows.Forms.Padding(4);
            this.btmOK.Name = "btmOK";
            this.btmOK.Size = new System.Drawing.Size(125, 35);
            this.btmOK.TabIndex = 73;
            this.btmOK.Text = "تایید";
            this.btmOK.UseVisualStyleBackColor = true;
            this.btmOK.Click += new System.EventHandler(this.btmOK_Click);
            // 
            // InvoiceInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(945, 277);
            this.Controls.Add(this.labEmployee);
            this.Controls.Add(this.butEmployee);
            this.Controls.Add(this.labVendor);
            this.Controls.Add(this.butVendor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.tbInvoiceNumberofVendor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btmCancel);
            this.Controls.Add(this.btmOK);
            this.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceInsert";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ورود فاکتور جدید";
            this.Load += new System.EventHandler(this.InvoiceInsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labEmployee;
        private System.Windows.Forms.Button butEmployee;
        public System.Windows.Forms.Label labVendor;
        private System.Windows.Forms.Button butVendor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox tbInvoiceNumberofVendor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btmCancel;
        private System.Windows.Forms.Button btmOK;
    }
}