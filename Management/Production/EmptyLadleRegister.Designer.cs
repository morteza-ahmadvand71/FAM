namespace Baran.Ferroalloy.Management
{
    partial class EmptyLadleRegister
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
            this.cbLadleNumbers = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.butWeightRegister = new System.Windows.Forms.Button();
            this.labWeight = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labEmptyWeight = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.butRegister = new System.Windows.Forms.Button();
            this.btmExit = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbLadleNumbers
            // 
            this.cbLadleNumbers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLadleNumbers.FormattingEnabled = true;
            this.cbLadleNumbers.Location = new System.Drawing.Point(686, 77);
            this.cbLadleNumbers.Name = "cbLadleNumbers";
            this.cbLadleNumbers.Size = new System.Drawing.Size(100, 40);
            this.cbLadleNumbers.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(529, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "شماره پاتیل:";
            // 
            // butWeightRegister
            // 
            this.butWeightRegister.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.butWeightRegister.Location = new System.Drawing.Point(50, 355);
            this.butWeightRegister.Margin = new System.Windows.Forms.Padding(0);
            this.butWeightRegister.Name = "butWeightRegister";
            this.butWeightRegister.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.butWeightRegister.Size = new System.Drawing.Size(256, 63);
            this.butWeightRegister.TabIndex = 14;
            this.butWeightRegister.Text = "وزن کن";
            this.butWeightRegister.UseVisualStyleBackColor = true;
            this.butWeightRegister.Click += new System.EventHandler(this.butWeightRegister_Click);
            // 
            // labWeight
            // 
            this.labWeight.AutoSize = true;
            this.labWeight.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.labWeight.Location = new System.Drawing.Point(116, 128);
            this.labWeight.Name = "labWeight";
            this.labWeight.Size = new System.Drawing.Size(153, 72);
            this.labWeight.TabIndex = 8;
            this.labWeight.Text = "12350";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.butWeightRegister);
            this.groupBox3.Controls.Add(this.labWeight);
            this.groupBox3.Location = new System.Drawing.Point(491, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 446);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "باسکول";
            // 
            // labEmptyWeight
            // 
            this.labEmptyWeight.AutoSize = true;
            this.labEmptyWeight.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labEmptyWeight.Location = new System.Drawing.Point(656, 665);
            this.labEmptyWeight.Name = "labEmptyWeight";
            this.labEmptyWeight.Size = new System.Drawing.Size(74, 37);
            this.labEmptyWeight.TabIndex = 14;
            this.labEmptyWeight.Text = "8350";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.Location = new System.Drawing.Point(772, 665);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 37);
            this.label9.TabIndex = 15;
            this.label9.Text = "کیلوگرم";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(487, 665);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 37);
            this.label6.TabIndex = 16;
            this.label6.Text = "وزن خالی:";
            // 
            // butRegister
            // 
            this.butRegister.Enabled = false;
            this.butRegister.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.butRegister.Location = new System.Drawing.Point(399, 771);
            this.butRegister.Margin = new System.Windows.Forms.Padding(0);
            this.butRegister.Name = "butRegister";
            this.butRegister.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.butRegister.Size = new System.Drawing.Size(256, 63);
            this.butRegister.TabIndex = 18;
            this.butRegister.Text = "ثبت";
            this.butRegister.UseVisualStyleBackColor = true;
            this.butRegister.Click += new System.EventHandler(this.butRegister_Click);
            // 
            // btmExit
            // 
            this.btmExit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btmExit.Location = new System.Drawing.Point(748, 771);
            this.btmExit.Margin = new System.Windows.Forms.Padding(0);
            this.btmExit.Name = "btmExit";
            this.btmExit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btmExit.Size = new System.Drawing.Size(256, 63);
            this.btmExit.TabIndex = 19;
            this.btmExit.Text = "خروج";
            this.btmExit.UseVisualStyleBackColor = true;
            // 
            // EmptyLadleRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 941);
            this.Controls.Add(this.btmExit);
            this.Controls.Add(this.butRegister);
            this.Controls.Add(this.labEmptyWeight);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cbLadleNumbers);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmptyLadleRegister";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ثبت پاتیل خالی";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmptyLadleRegister_FormClosing);
            this.Load += new System.EventHandler(this.EmptyLadleRegister_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLadleNumbers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butWeightRegister;
        private System.Windows.Forms.Label labWeight;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labEmptyWeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butRegister;
        private System.Windows.Forms.Button btmExit;
    }
}