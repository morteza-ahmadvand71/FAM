namespace Baran.Ferroalloy.Management
{
    partial class RequestItemUpdate
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
            this.tbRequestNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.butStuff = new System.Windows.Forms.Button();
            this.labStuff = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btmCancel = new System.Windows.Forms.Button();
            this.btmOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbRequestNumber
            // 
            this.tbRequestNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbRequestNumber.Location = new System.Drawing.Point(258, 98);
            this.tbRequestNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbRequestNumber.MaxLength = 20;
            this.tbRequestNumber.Name = "tbRequestNumber";
            this.tbRequestNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbRequestNumber.Size = new System.Drawing.Size(120, 24);
            this.tbRequestNumber.TabIndex = 73;
            this.tbRequestNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRequestNumber.TextChanged += new System.EventHandler(this.TbRequestNumber_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 72;
            this.label4.Text = "شماره درخواست:";
            // 
            // butStuff
            // 
            this.butStuff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butStuff.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.butStuff.Location = new System.Drawing.Point(475, 40);
            this.butStuff.Name = "butStuff";
            this.butStuff.Size = new System.Drawing.Size(125, 35);
            this.butStuff.TabIndex = 104;
            this.butStuff.Text = "انتخاب";
            this.butStuff.UseVisualStyleBackColor = true;
            this.butStuff.Click += new System.EventHandler(this.ButStuff_Click);
            // 
            // labStuff
            // 
            this.labStuff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labStuff.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.labStuff.Location = new System.Drawing.Point(166, 45);
            this.labStuff.Name = "labStuff";
            this.labStuff.Size = new System.Drawing.Size(300, 25);
            this.labStuff.TabIndex = 103;
            this.labStuff.Text = "انتخاب کنید";
            this.labStuff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbAmount
            // 
            this.tbAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAmount.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.tbAmount.Location = new System.Drawing.Point(464, 98);
            this.tbAmount.Margin = new System.Windows.Forms.Padding(4);
            this.tbAmount.MaxLength = 20;
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbAmount.Size = new System.Drawing.Size(120, 24);
            this.tbAmount.TabIndex = 102;
            this.tbAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAmount.TextChanged += new System.EventHandler(this.TbAmount_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label2.Location = new System.Drawing.Point(419, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 101;
            this.label2.Text = "مقدار:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label3.Location = new System.Drawing.Point(136, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 100;
            this.label3.Text = "کالا:";
            // 
            // btmCancel
            // 
            this.btmCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmCancel.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmCancel.Location = new System.Drawing.Point(394, 173);
            this.btmCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btmCancel.Name = "btmCancel";
            this.btmCancel.Size = new System.Drawing.Size(125, 35);
            this.btmCancel.TabIndex = 99;
            this.btmCancel.Text = "رد";
            this.btmCancel.UseVisualStyleBackColor = true;
            this.btmCancel.Click += new System.EventHandler(this.btmCancel_Click);
            // 
            // btmOK
            // 
            this.btmOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmOK.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmOK.Location = new System.Drawing.Point(233, 173);
            this.btmOK.Margin = new System.Windows.Forms.Padding(4);
            this.btmOK.Name = "btmOK";
            this.btmOK.Size = new System.Drawing.Size(125, 35);
            this.btmOK.TabIndex = 98;
            this.btmOK.Text = "تایید";
            this.btmOK.UseVisualStyleBackColor = true;
            this.btmOK.Click += new System.EventHandler(this.btmOK_Click);
            // 
            // RequestItemUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(753, 248);
            this.Controls.Add(this.butStuff);
            this.Controls.Add(this.labStuff);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btmCancel);
            this.Controls.Add(this.btmOK);
            this.Controls.Add(this.tbRequestNumber);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RequestItemUpdate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "به روز رسانی آیتم";
            this.Load += new System.EventHandler(this.RequestItemUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbRequestNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butStuff;
        public System.Windows.Forms.Label labStuff;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btmCancel;
        private System.Windows.Forms.Button btmOK;
    }
}