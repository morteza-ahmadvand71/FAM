namespace Baran.Ferroalloy.Management
{
    partial class StorePrefrences
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
            this.btmExit = new System.Windows.Forms.Button();
            this.tpPrefrences = new System.Windows.Forms.TabControl();
            this.tabCo = new System.Windows.Forms.TabPage();
            this.btmCoSave = new System.Windows.Forms.Button();
            this.tabDepartments = new System.Windows.Forms.TabPage();
            this.btmDepartmentsSave = new System.Windows.Forms.Button();
            this.tabCategories = new System.Windows.Forms.TabPage();
            this.btmCategoriesSave = new System.Windows.Forms.Button();
            this.tpPrefrences.SuspendLayout();
            this.tabCo.SuspendLayout();
            this.tabDepartments.SuspendLayout();
            this.tabCategories.SuspendLayout();
            this.SuspendLayout();
            // 
            // btmExit
            // 
            this.btmExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmExit.AutoSize = true;
            this.btmExit.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmExit.Location = new System.Drawing.Point(620, 681);
            this.btmExit.Margin = new System.Windows.Forms.Padding(2);
            this.btmExit.Name = "btmExit";
            this.btmExit.Size = new System.Drawing.Size(125, 35);
            this.btmExit.TabIndex = 9;
            this.btmExit.Text = "خروج";
            this.btmExit.UseVisualStyleBackColor = true;
            this.btmExit.Click += new System.EventHandler(this.btmExit_Click);
            // 
            // tpPrefrences
            // 
            this.tpPrefrences.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpPrefrences.Controls.Add(this.tabCo);
            this.tpPrefrences.Controls.Add(this.tabDepartments);
            this.tpPrefrences.Controls.Add(this.tabCategories);
            this.tpPrefrences.Location = new System.Drawing.Point(263, 30);
            this.tpPrefrences.Name = "tpPrefrences";
            this.tpPrefrences.RightToLeftLayout = true;
            this.tpPrefrences.SelectedIndex = 0;
            this.tpPrefrences.Size = new System.Drawing.Size(821, 613);
            this.tpPrefrences.TabIndex = 10;
            // 
            // tabCo
            // 
            this.tabCo.BackColor = System.Drawing.SystemColors.Control;
            this.tabCo.Controls.Add(this.btmCoSave);
            this.tabCo.Location = new System.Drawing.Point(4, 25);
            this.tabCo.Name = "tabCo";
            this.tabCo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCo.Size = new System.Drawing.Size(813, 584);
            this.tabCo.TabIndex = 2;
            this.tabCo.Text = "شرکت";
            // 
            // btmCoSave
            // 
            this.btmCoSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmCoSave.AutoSize = true;
            this.btmCoSave.Enabled = false;
            this.btmCoSave.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmCoSave.Location = new System.Drawing.Point(92, 515);
            this.btmCoSave.Margin = new System.Windows.Forms.Padding(2);
            this.btmCoSave.Name = "btmCoSave";
            this.btmCoSave.Size = new System.Drawing.Size(125, 35);
            this.btmCoSave.TabIndex = 14;
            this.btmCoSave.Text = "ذخیره";
            this.btmCoSave.UseVisualStyleBackColor = true;
            // 
            // tabDepartments
            // 
            this.tabDepartments.BackColor = System.Drawing.SystemColors.Control;
            this.tabDepartments.Controls.Add(this.btmDepartmentsSave);
            this.tabDepartments.Location = new System.Drawing.Point(4, 25);
            this.tabDepartments.Name = "tabDepartments";
            this.tabDepartments.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepartments.Size = new System.Drawing.Size(813, 584);
            this.tabDepartments.TabIndex = 0;
            this.tabDepartments.Text = "واحدها";
            // 
            // btmDepartmentsSave
            // 
            this.btmDepartmentsSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmDepartmentsSave.AutoSize = true;
            this.btmDepartmentsSave.Enabled = false;
            this.btmDepartmentsSave.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmDepartmentsSave.Location = new System.Drawing.Point(92, 515);
            this.btmDepartmentsSave.Margin = new System.Windows.Forms.Padding(2);
            this.btmDepartmentsSave.Name = "btmDepartmentsSave";
            this.btmDepartmentsSave.Size = new System.Drawing.Size(125, 35);
            this.btmDepartmentsSave.TabIndex = 12;
            this.btmDepartmentsSave.Text = "ذخیره";
            this.btmDepartmentsSave.UseVisualStyleBackColor = true;
            // 
            // tabCategories
            // 
            this.tabCategories.BackColor = System.Drawing.SystemColors.Control;
            this.tabCategories.Controls.Add(this.btmCategoriesSave);
            this.tabCategories.Location = new System.Drawing.Point(4, 25);
            this.tabCategories.Name = "tabCategories";
            this.tabCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategories.Size = new System.Drawing.Size(813, 584);
            this.tabCategories.TabIndex = 1;
            this.tabCategories.Text = "رسته‌ها";
            // 
            // btmCategoriesSave
            // 
            this.btmCategoriesSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmCategoriesSave.AutoSize = true;
            this.btmCategoriesSave.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmCategoriesSave.Location = new System.Drawing.Point(92, 515);
            this.btmCategoriesSave.Margin = new System.Windows.Forms.Padding(2);
            this.btmCategoriesSave.Name = "btmCategoriesSave";
            this.btmCategoriesSave.Size = new System.Drawing.Size(125, 35);
            this.btmCategoriesSave.TabIndex = 11;
            this.btmCategoriesSave.Text = "ذخیره";
            this.btmCategoriesSave.UseVisualStyleBackColor = true;
            // 
            // StorePrefrences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.tpPrefrences);
            this.Controls.Add(this.btmExit);
            this.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StorePrefrences";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تنظیمات واحد اداری";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employees_FormClosing);
            this.Load += new System.EventHandler(this.Employees_Load);
            this.Enter += new System.EventHandler(this.Employees_Enter);
            this.tpPrefrences.ResumeLayout(false);
            this.tabCo.ResumeLayout(false);
            this.tabCo.PerformLayout();
            this.tabDepartments.ResumeLayout(false);
            this.tabDepartments.PerformLayout();
            this.tabCategories.ResumeLayout(false);
            this.tabCategories.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btmExit;
        private System.Windows.Forms.TabControl tpPrefrences;
        private System.Windows.Forms.TabPage tabDepartments;
        private System.Windows.Forms.TabPage tabCategories;
        private System.Windows.Forms.Button btmCategoriesSave;
        private System.Windows.Forms.Button btmDepartmentsSave;
        private System.Windows.Forms.TabPage tabCo;
        private System.Windows.Forms.Button btmCoSave;
    }
}