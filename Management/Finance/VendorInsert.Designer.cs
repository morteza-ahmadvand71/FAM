namespace Baran.Ferroalloy.Management
{
    partial class VendorInsert
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
            this.tbTell = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbActivityTypes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbActivities = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btmOK
            // 
            this.btmOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btmOK.AutoSize = true;
            this.btmOK.Enabled = false;
            this.btmOK.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmOK.Location = new System.Drawing.Point(276, 326);
            this.btmOK.Margin = new System.Windows.Forms.Padding(4);
            this.btmOK.Name = "btmOK";
            this.btmOK.Size = new System.Drawing.Size(125, 35);
            this.btmOK.TabIndex = 10;
            this.btmOK.Text = "تایید";
            this.btmOK.UseVisualStyleBackColor = true;
            this.btmOK.Click += new System.EventHandler(this.btmOK_Click);
            // 
            // btmCancel
            // 
            this.btmCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btmCancel.AutoSize = true;
            this.btmCancel.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmCancel.Location = new System.Drawing.Point(436, 326);
            this.btmCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btmCancel.Name = "btmCancel";
            this.btmCancel.Size = new System.Drawing.Size(125, 35);
            this.btmCancel.TabIndex = 11;
            this.btmCancel.Text = "رد";
            this.btmCancel.UseVisualStyleBackColor = true;
            this.btmCancel.Click += new System.EventHandler(this.btmCancel_Click);
            // 
            // tbTell
            // 
            this.tbTell.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTell.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.tbTell.Location = new System.Drawing.Point(619, 81);
            this.tbTell.MaxLength = 15;
            this.tbTell.Name = "tbTell";
            this.tbTell.Size = new System.Drawing.Size(120, 24);
            this.tbTell.TabIndex = 5;
            this.tbTell.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTell.TextChanged += new System.EventHandler(this.TbTell_TextChanged);
            this.tbTell.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            this.tbTell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetNumbericCharsTextBoxes);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label5.Location = new System.Drawing.Point(579, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 66;
            this.label5.Text = "تلفن:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label3.Location = new System.Drawing.Point(302, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "نشانی:";
            // 
            // tbAddress
            // 
            this.tbAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbAddress.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.tbAddress.Location = new System.Drawing.Point(356, 223);
            this.tbAddress.MaxLength = 200;
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(400, 75);
            this.tbAddress.TabIndex = 9;
            this.tbAddress.TextChanged += new System.EventHandler(this.TbAddress_TextChanged);
            this.tbAddress.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label8.Location = new System.Drawing.Point(86, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 64;
            this.label8.Text = "شهر:";
            // 
            // tbCity
            // 
            this.tbCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCity.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.tbCity.Location = new System.Drawing.Point(126, 223);
            this.tbCity.MaxLength = 20;
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(150, 24);
            this.tbCity.TabIndex = 8;
            this.tbCity.TextChanged += new System.EventHandler(this.TbCity_TextChanged);
            this.tbCity.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbFirstName.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.tbFirstName.Location = new System.Drawing.Point(120, 81);
            this.tbFirstName.MaxLength = 20;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(150, 24);
            this.tbFirstName.TabIndex = 3;
            this.tbFirstName.TextChanged += new System.EventHandler(this.TbFirstName_TextChanged);
            this.tbFirstName.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            // 
            // tbLastName
            // 
            this.tbLastName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbLastName.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.tbLastName.Location = new System.Drawing.Point(389, 81);
            this.tbLastName.MaxLength = 20;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(150, 24);
            this.tbLastName.TabIndex = 4;
            this.tbLastName.TextChanged += new System.EventHandler(this.TbLastName_TextChanged);
            this.tbLastName.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label7.Location = new System.Drawing.Point(302, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 63;
            this.label7.Text = "نام خانوادگی:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label6.Location = new System.Drawing.Point(92, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 62;
            this.label6.Text = "نام:";
            // 
            // tbBrand
            // 
            this.tbBrand.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbBrand.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.tbBrand.Location = new System.Drawing.Point(494, 36);
            this.tbBrand.MaxLength = 20;
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbBrand.Size = new System.Drawing.Size(150, 24);
            this.tbBrand.TabIndex = 2;
            this.tbBrand.TextChanged += new System.EventHandler(this.TbBrand_TextChanged);
            this.tbBrand.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label2.Location = new System.Drawing.Point(460, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 60;
            this.label2.Text = "برند:";
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(242, 36);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(150, 24);
            this.cbCategory.TabIndex = 1;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.CbCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label1.Location = new System.Drawing.Point(196, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 59;
            this.label1.Text = "رسته:";
            // 
            // cbActivityTypes
            // 
            this.cbActivityTypes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbActivityTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActivityTypes.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.cbActivityTypes.FormattingEnabled = true;
            this.cbActivityTypes.Location = new System.Drawing.Point(118, 126);
            this.cbActivityTypes.Name = "cbActivityTypes";
            this.cbActivityTypes.Size = new System.Drawing.Size(150, 24);
            this.cbActivityTypes.TabIndex = 6;
            this.cbActivityTypes.SelectedIndexChanged += new System.EventHandler(this.CbActivityTypes_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label4.Location = new System.Drawing.Point(45, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 68;
            this.label4.Text = "نوع فعالیت:";
            // 
            // tbActivities
            // 
            this.tbActivities.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbActivities.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.tbActivities.Location = new System.Drawing.Point(393, 126);
            this.tbActivities.MaxLength = 200;
            this.tbActivities.Multiline = true;
            this.tbActivities.Name = "tbActivities";
            this.tbActivities.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbActivities.Size = new System.Drawing.Size(400, 75);
            this.tbActivities.TabIndex = 7;
            this.tbActivities.TextChanged += new System.EventHandler(this.TbActivities_TextChanged);
            this.tbActivities.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label9.Location = new System.Drawing.Point(327, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 70;
            this.label9.Text = "فعالیت‌ها:";
            // 
            // VendorInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(854, 396);
            this.Controls.Add(this.tbActivities);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbActivityTypes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTell);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbBrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btmCancel);
            this.Controls.Add(this.btmOK);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VendorInsert";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ورود فروشنده جدید";
            this.Load += new System.EventHandler(this.VendorInsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btmOK;
        private System.Windows.Forms.Button btmCancel;
        private System.Windows.Forms.TextBox tbTell;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbActivityTypes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbActivities;
        private System.Windows.Forms.Label label9;
    }
}