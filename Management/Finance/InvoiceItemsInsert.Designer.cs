namespace Baran.Ferroalloy.Management
{
    partial class InvoiceItemsInsert
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
            this.label4 = new System.Windows.Forms.Label();
            this.btmStuff = new System.Windows.Forms.Button();
            this.labStuff = new System.Windows.Forms.Label();
            this.butRequest = new System.Windows.Forms.Button();
            this.labRequest = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btmCancel = new System.Windows.Forms.Button();
            this.btmOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label4.Location = new System.Drawing.Point(510, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 77;
            this.label4.Text = "ریال";
            // 
            // btmStuff
            // 
            this.btmStuff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmStuff.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmStuff.Location = new System.Drawing.Point(449, 83);
            this.btmStuff.Name = "btmStuff";
            this.btmStuff.Size = new System.Drawing.Size(125, 35);
            this.btmStuff.TabIndex = 76;
            this.btmStuff.Text = "انتخاب";
            this.btmStuff.UseVisualStyleBackColor = true;
            this.btmStuff.Click += new System.EventHandler(this.BtmStuff_Click);
            // 
            // labStuff
            // 
            this.labStuff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labStuff.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.labStuff.Location = new System.Drawing.Point(145, 88);
            this.labStuff.Name = "labStuff";
            this.labStuff.Size = new System.Drawing.Size(300, 25);
            this.labStuff.TabIndex = 75;
            this.labStuff.Text = "انتخاب کنید ....................................................................." +
    ".............";
            this.labStuff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // butRequest
            // 
            this.butRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.butRequest.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.butRequest.Location = new System.Drawing.Point(465, 28);
            this.butRequest.Name = "butRequest";
            this.butRequest.Size = new System.Drawing.Size(125, 35);
            this.butRequest.TabIndex = 74;
            this.butRequest.Text = "انتخاب";
            this.butRequest.UseVisualStyleBackColor = true;
            this.butRequest.Click += new System.EventHandler(this.ButRequest_Click);
            // 
            // labRequest
            // 
            this.labRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labRequest.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.labRequest.Location = new System.Drawing.Point(162, 33);
            this.labRequest.Name = "labRequest";
            this.labRequest.Size = new System.Drawing.Size(300, 25);
            this.labRequest.TabIndex = 73;
            this.labRequest.Text = "انتخاب کنید";
            this.labRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbPrice
            // 
            this.tbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPrice.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.tbPrice.Location = new System.Drawing.Point(386, 140);
            this.tbPrice.MaxLength = 20;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbPrice.Size = new System.Drawing.Size(120, 24);
            this.tbPrice.TabIndex = 72;
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPrice.TextChanged += new System.EventHandler(this.TbPrice_TextChanged);
            this.tbPrice.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetNumbericCharsTextBoxes);
            // 
            // tbAmount
            // 
            this.tbAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAmount.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.tbAmount.Location = new System.Drawing.Point(188, 140);
            this.tbAmount.MaxLength = 20;
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbAmount.Size = new System.Drawing.Size(120, 24);
            this.tbAmount.TabIndex = 71;
            this.tbAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAmount.TextChanged += new System.EventHandler(this.TbAmount_TextChanged);
            this.tbAmount.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetNumbericCharsTextBoxes);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label3.Location = new System.Drawing.Point(146, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 70;
            this.label3.Text = "مقدار:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label1.Location = new System.Drawing.Point(341, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 69;
            this.label1.Text = "قیمت:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label2.Location = new System.Drawing.Point(97, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "درخواست:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label6.Location = new System.Drawing.Point(118, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 68;
            this.label6.Text = "کالا:";
            // 
            // btmCancel
            // 
            this.btmCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmCancel.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmCancel.Location = new System.Drawing.Point(365, 205);
            this.btmCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btmCancel.Name = "btmCancel";
            this.btmCancel.Size = new System.Drawing.Size(125, 35);
            this.btmCancel.TabIndex = 66;
            this.btmCancel.Text = "رد";
            this.btmCancel.UseVisualStyleBackColor = true;
            this.btmCancel.Click += new System.EventHandler(this.btmCancel_Click);
            // 
            // btmOK
            // 
            this.btmOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmOK.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmOK.Location = new System.Drawing.Point(194, 205);
            this.btmOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btmOK.Name = "btmOK";
            this.btmOK.Size = new System.Drawing.Size(125, 35);
            this.btmOK.TabIndex = 65;
            this.btmOK.Text = "تایید";
            this.btmOK.UseVisualStyleBackColor = true;
            this.btmOK.Click += new System.EventHandler(this.btmOK_Click);
            // 
            // InvoiceItemsInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(686, 279);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btmStuff);
            this.Controls.Add(this.labStuff);
            this.Controls.Add(this.butRequest);
            this.Controls.Add(this.labRequest);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btmCancel);
            this.Controls.Add(this.btmOK);
            this.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceItemsInsert";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ورود آیتم جدید";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btmStuff;
        public System.Windows.Forms.Label labStuff;
        private System.Windows.Forms.Button butRequest;
        public System.Windows.Forms.Label labRequest;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btmCancel;
        private System.Windows.Forms.Button btmOK;
    }
}