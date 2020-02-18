namespace Baran.Ferroalloy.Management
{
    partial class ProjectUpdate
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
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTip = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btmCancel = new System.Windows.Forms.Button();
            this.btmOK = new System.Windows.Forms.Button();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(384, 43);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(150, 24);
            this.cbCategory.TabIndex = 75;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.CbCategory_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label4.Location = new System.Drawing.Point(340, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 82;
            this.label4.Text = "رسته:";
            // 
            // tbTip
            // 
            this.tbTip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTip.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.tbTip.Location = new System.Drawing.Point(159, 135);
            this.tbTip.Multiline = true;
            this.tbTip.Name = "tbTip";
            this.tbTip.Size = new System.Drawing.Size(400, 75);
            this.tbTip.TabIndex = 77;
            this.tbTip.TextChanged += new System.EventHandler(this.TbTip_TextChanged);
            this.tbTip.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label7.Location = new System.Drawing.Point(110, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 80;
            this.label7.Text = "توضیح:";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.tbName.Location = new System.Drawing.Point(113, 92);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(469, 24);
            this.tbName.TabIndex = 76;
            this.tbName.TextChanged += new System.EventHandler(this.TbName_TextChanged);
            this.tbName.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label6.Location = new System.Drawing.Point(84, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 81;
            this.label6.Text = "نام:";
            // 
            // btmCancel
            // 
            this.btmCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmCancel.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmCancel.Location = new System.Drawing.Point(376, 239);
            this.btmCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btmCancel.Name = "btmCancel";
            this.btmCancel.Size = new System.Drawing.Size(125, 35);
            this.btmCancel.TabIndex = 79;
            this.btmCancel.Text = "رد";
            this.btmCancel.UseVisualStyleBackColor = true;
            this.btmCancel.Click += new System.EventHandler(this.btmCancel_Click);
            // 
            // btmOK
            // 
            this.btmOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmOK.Enabled = false;
            this.btmOK.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmOK.Location = new System.Drawing.Point(216, 239);
            this.btmOK.Margin = new System.Windows.Forms.Padding(4);
            this.btmOK.Name = "btmOK";
            this.btmOK.Size = new System.Drawing.Size(125, 35);
            this.btmOK.TabIndex = 78;
            this.btmOK.Text = "تایید";
            this.btmOK.UseVisualStyleBackColor = true;
            this.btmOK.Click += new System.EventHandler(this.btmOK_Click);
            // 
            // tbNumber
            // 
            this.tbNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumber.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.tbNumber.Location = new System.Drawing.Point(189, 43);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(120, 24);
            this.tbNumber.TabIndex = 83;
            this.tbNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNumber.TextChanged += new System.EventHandler(this.TbNumber_TextChanged);
            this.tbNumber.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            this.tbNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetNumbericCharsTextBoxes);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label1.Location = new System.Drawing.Point(137, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 84;
            this.label1.Text = "شماره:";
            // 
            // ProjectUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(721, 328);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTip);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btmCancel);
            this.Controls.Add(this.btmOK);
            this.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectUpdate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "به روز رسانی پروژه";
            this.Load += new System.EventHandler(this.ProjectUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btmCancel;
        private System.Windows.Forms.Button btmOK;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label1;
    }
}