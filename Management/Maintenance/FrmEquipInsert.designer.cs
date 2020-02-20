using System.Windows.Forms;

namespace Baran.Ferroalloy.Management
{
    partial class FrmEquipInsert
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
            this.cbZones = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSubZones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEqiupName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btmCancel = new System.Windows.Forms.Button();
            this.btmOK = new System.Windows.Forms.Button();
            this.labCode = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_EquipNameEdit = new System.Windows.Forms.Button();
            this.btn_CategoryEdit = new System.Windows.Forms.Button();
            this.btn_SubZonesEdit = new System.Windows.Forms.Button();
            this.btn_ZonesEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbZones
            // 
            this.cbZones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbZones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZones.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbZones.FormattingEnabled = true;
            this.cbZones.Location = new System.Drawing.Point(94, 44);
            this.cbZones.Margin = new System.Windows.Forms.Padding(4);
            this.cbZones.Name = "cbZones";
            this.cbZones.Size = new System.Drawing.Size(120, 28);
            this.cbZones.TabIndex = 42;
            this.cbZones.SelectedIndexChanged += new System.EventHandler(this.CbZones_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label2.Location = new System.Drawing.Point(45, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "بخش:";
            // 
            // cbSubZones
            // 
            this.cbSubZones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSubZones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubZones.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbSubZones.FormattingEnabled = true;
            this.cbSubZones.Location = new System.Drawing.Point(365, 46);
            this.cbSubZones.Margin = new System.Windows.Forms.Padding(4);
            this.cbSubZones.Name = "cbSubZones";
            this.cbSubZones.Size = new System.Drawing.Size(120, 28);
            this.cbSubZones.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label1.Location = new System.Drawing.Point(299, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 44;
            this.label1.Text = "زیربخش:";
            // 
            // cbEqiupName
            // 
            this.cbEqiupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEqiupName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEqiupName.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbEqiupName.FormattingEnabled = true;
            this.cbEqiupName.Location = new System.Drawing.Point(365, 118);
            this.cbEqiupName.Margin = new System.Windows.Forms.Padding(4);
            this.cbEqiupName.Name = "cbEqiupName";
            this.cbEqiupName.Size = new System.Drawing.Size(120, 28);
            this.cbEqiupName.TabIndex = 51;
            this.cbEqiupName.SelectedIndexChanged += new System.EventHandler(this.CbEqiupName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label3.Location = new System.Drawing.Point(328, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "نام:";
            // 
            // cbCategories
            // 
            this.cbCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(94, 116);
            this.cbCategories.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(120, 28);
            this.cbCategories.TabIndex = 48;
            this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.CbCategories_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label4.Location = new System.Drawing.Point(44, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 47;
            this.label4.Text = "رسته:";
            // 
            // btmCancel
            // 
            this.btmCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmCancel.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btmCancel.Location = new System.Drawing.Point(314, 267);
            this.btmCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btmCancel.Name = "btmCancel";
            this.btmCancel.Size = new System.Drawing.Size(125, 35);
            this.btmCancel.TabIndex = 54;
            this.btmCancel.Text = "رد";
            this.btmCancel.UseVisualStyleBackColor = true;
            this.btmCancel.Click += new System.EventHandler(this.BtmCancel_Click);
            // 
            // btmOK
            // 
            this.btmOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmOK.Enabled = false;
            this.btmOK.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btmOK.Location = new System.Drawing.Point(154, 267);
            this.btmOK.Margin = new System.Windows.Forms.Padding(4);
            this.btmOK.Name = "btmOK";
            this.btmOK.Size = new System.Drawing.Size(125, 35);
            this.btmOK.TabIndex = 53;
            this.btmOK.Text = "تایید";
            this.btmOK.UseVisualStyleBackColor = true;
            this.btmOK.Click += new System.EventHandler(this.BtmOK_Click);
            // 
            // labCode
            // 
            this.labCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labCode.Location = new System.Drawing.Point(234, 174);
            this.labCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(239, 23);
            this.labCode.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(202, 174);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "کد:";
            // 
            // labName
            // 
            this.labName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labName.Location = new System.Drawing.Point(234, 216);
            this.labName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(239, 23);
            this.labName.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 216);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 20);
            this.label7.TabIndex = 57;
            this.label7.Text = "نام:";
            // 
            // btn_EquipNameEdit
            // 
            this.btn_EquipNameEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_EquipNameEdit.BackColor = System.Drawing.Color.Transparent;
            this.btn_EquipNameEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
            this.btn_EquipNameEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_EquipNameEdit.FlatAppearance.BorderSize = 0;
            this.btn_EquipNameEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_EquipNameEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_EquipNameEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EquipNameEdit.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btn_EquipNameEdit.Location = new System.Drawing.Point(486, 115);
            this.btn_EquipNameEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_EquipNameEdit.Name = "btn_EquipNameEdit";
            this.btn_EquipNameEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.btn_EquipNameEdit.Size = new System.Drawing.Size(30, 30);
            this.btn_EquipNameEdit.TabIndex = 52;
            this.btn_EquipNameEdit.UseVisualStyleBackColor = false;
            this.btn_EquipNameEdit.Click += new System.EventHandler(this.Btn_EquipNameEdit_Click);
            // 
            // btn_CategoryEdit
            // 
            this.btn_CategoryEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CategoryEdit.BackColor = System.Drawing.Color.Transparent;
            this.btn_CategoryEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
            this.btn_CategoryEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_CategoryEdit.FlatAppearance.BorderSize = 0;
            this.btn_CategoryEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_CategoryEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_CategoryEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CategoryEdit.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btn_CategoryEdit.Location = new System.Drawing.Point(215, 113);
            this.btn_CategoryEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CategoryEdit.Name = "btn_CategoryEdit";
            this.btn_CategoryEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.btn_CategoryEdit.Size = new System.Drawing.Size(30, 30);
            this.btn_CategoryEdit.TabIndex = 49;
            this.btn_CategoryEdit.UseVisualStyleBackColor = false;
            this.btn_CategoryEdit.Click += new System.EventHandler(this.Btn_CategoryEdit_Click);
            // 
            // btn_SubZonesEdit
            // 
            this.btn_SubZonesEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SubZonesEdit.BackColor = System.Drawing.Color.Transparent;
            this.btn_SubZonesEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
            this.btn_SubZonesEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_SubZonesEdit.FlatAppearance.BorderSize = 0;
            this.btn_SubZonesEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_SubZonesEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_SubZonesEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SubZonesEdit.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btn_SubZonesEdit.Location = new System.Drawing.Point(486, 43);
            this.btn_SubZonesEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SubZonesEdit.Name = "btn_SubZonesEdit";
            this.btn_SubZonesEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.btn_SubZonesEdit.Size = new System.Drawing.Size(30, 30);
            this.btn_SubZonesEdit.TabIndex = 46;
            this.btn_SubZonesEdit.UseVisualStyleBackColor = false;
            this.btn_SubZonesEdit.Click += new System.EventHandler(this.Btn_SubZonesEdit_Click);
            // 
            // btn_ZonesEdit
            // 
            this.btn_ZonesEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ZonesEdit.BackColor = System.Drawing.Color.Transparent;
            this.btn_ZonesEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
            this.btn_ZonesEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ZonesEdit.FlatAppearance.BorderSize = 0;
            this.btn_ZonesEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ZonesEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ZonesEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ZonesEdit.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btn_ZonesEdit.Location = new System.Drawing.Point(215, 41);
            this.btn_ZonesEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ZonesEdit.Name = "btn_ZonesEdit";
            this.btn_ZonesEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.btn_ZonesEdit.Size = new System.Drawing.Size(30, 30);
            this.btn_ZonesEdit.TabIndex = 43;
            this.btn_ZonesEdit.UseVisualStyleBackColor = false;
            this.btn_ZonesEdit.Click += new System.EventHandler(this.Btn_ZonesEdit_Click);
            // 
            // FrmEquipInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(590, 350);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labCode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btmCancel);
            this.Controls.Add(this.btmOK);
            this.Controls.Add(this.btn_EquipNameEdit);
            this.Controls.Add(this.cbEqiupName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_CategoryEdit);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_SubZonesEdit);
            this.Controls.Add(this.cbSubZones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ZonesEdit);
            this.Controls.Add(this.cbZones);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEquipInsert";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "وارد کردن تجهیز";
            this.Load += new System.EventHandler(this.FrmEquipInsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_ZonesEdit;
        private ComboBox cbZones;
        private Label label2;
        private Button btn_SubZonesEdit;
        private ComboBox cbSubZones;
        private Label label1;
        private Button btn_EquipNameEdit;
        private ComboBox cbEqiupName;
        private Label label3;
        private Button btn_CategoryEdit;
        private ComboBox cbCategories;
        private Label label4;
        private Button btmCancel;
        private Button btmOK;
        private Label labCode;
        private Label label8;
        private Label labName;
        private Label label7;
    }
}

