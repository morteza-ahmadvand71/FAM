namespace Baran.Ferroalloy.Management
{
    partial class StuffUpdate
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
            this.lbSelectedProperties = new System.Windows.Forms.ListBox();
            this.cbProperties = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbSections = new System.Windows.Forms.ComboBox();
            this.cbTypes = new System.Windows.Forms.ComboBox();
            this.labCode = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbOrderPoint = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMaterials = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStores = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMeasuementUnits = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btmCancel = new System.Windows.Forms.Button();
            this.btmOK = new System.Windows.Forms.Button();
            this.btmMaterialEdit = new System.Windows.Forms.Button();
            this.btmTypeEdit = new System.Windows.Forms.Button();
            this.btmSectionEdit = new System.Windows.Forms.Button();
            this.btmStoreEdit = new System.Windows.Forms.Button();
            this.btmTakeOutFromList = new System.Windows.Forms.Button();
            this.btmInsertToList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSelectedProperties
            // 
            this.lbSelectedProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSelectedProperties.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.lbSelectedProperties.FormattingEnabled = true;
            this.lbSelectedProperties.ItemHeight = 16;
            this.lbSelectedProperties.Location = new System.Drawing.Point(563, 185);
            this.lbSelectedProperties.Name = "lbSelectedProperties";
            this.lbSelectedProperties.Size = new System.Drawing.Size(120, 84);
            this.lbSelectedProperties.TabIndex = 66;
            this.lbSelectedProperties.SelectedIndexChanged += new System.EventHandler(this.LbSelectedProperties_SelectedIndexChanged);
            // 
            // cbProperties
            // 
            this.cbProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProperties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProperties.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.cbProperties.FormattingEnabled = true;
            this.cbProperties.Location = new System.Drawing.Point(372, 192);
            this.cbProperties.Margin = new System.Windows.Forms.Padding(4);
            this.cbProperties.Name = "cbProperties";
            this.cbProperties.Size = new System.Drawing.Size(120, 24);
            this.cbProperties.TabIndex = 65;
            this.cbProperties.SelectedIndexChanged += new System.EventHandler(this.CbProperties_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label10.Location = new System.Drawing.Point(322, 195);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 64;
            this.label10.Text = "ویژگی:";
            // 
            // cbSections
            // 
            this.cbSections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSections.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.cbSections.FormattingEnabled = true;
            this.cbSections.Location = new System.Drawing.Point(475, 46);
            this.cbSections.Margin = new System.Windows.Forms.Padding(4);
            this.cbSections.Name = "cbSections";
            this.cbSections.Size = new System.Drawing.Size(120, 24);
            this.cbSections.TabIndex = 53;
            this.cbSections.SelectedIndexChanged += new System.EventHandler(this.CbSections_SelectedIndexChanged);
            // 
            // cbTypes
            // 
            this.cbTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypes.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Location = new System.Drawing.Point(70, 95);
            this.cbTypes.Margin = new System.Windows.Forms.Padding(4);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(120, 24);
            this.cbTypes.TabIndex = 63;
            this.cbTypes.SelectedIndexChanged += new System.EventHandler(this.CbTypes_SelectedIndexChanged);
            // 
            // labCode
            // 
            this.labCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labCode.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.labCode.Location = new System.Drawing.Point(660, 96);
            this.labCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(300, 22);
            this.labCode.TabIndex = 62;
            // 
            // labName
            // 
            this.labName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labName.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.labName.Location = new System.Drawing.Point(288, 96);
            this.labName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(300, 22);
            this.labName.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label8.Location = new System.Drawing.Point(630, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 17);
            this.label8.TabIndex = 60;
            this.label8.Text = "کد:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label9.Location = new System.Drawing.Point(255, 97);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 17);
            this.label9.TabIndex = 59;
            this.label9.Text = "نام:";
            // 
            // tbOrderPoint
            // 
            this.tbOrderPoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOrderPoint.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.tbOrderPoint.Location = new System.Drawing.Point(778, 144);
            this.tbOrderPoint.Margin = new System.Windows.Forms.Padding(4);
            this.tbOrderPoint.MaxLength = 10;
            this.tbOrderPoint.Name = "tbOrderPoint";
            this.tbOrderPoint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbOrderPoint.Size = new System.Drawing.Size(80, 24);
            this.tbOrderPoint.TabIndex = 58;
            this.tbOrderPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbOrderPoint.TextChanged += new System.EventHandler(this.TbOrderPoint_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label7.Location = new System.Drawing.Point(685, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 57;
            this.label7.Text = "نقطه سفارش:";
            // 
            // cbMaterials
            // 
            this.cbMaterials.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMaterials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaterials.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.cbMaterials.FormattingEnabled = true;
            this.cbMaterials.Location = new System.Drawing.Point(751, 46);
            this.cbMaterials.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaterials.Name = "cbMaterials";
            this.cbMaterials.Size = new System.Drawing.Size(120, 24);
            this.cbMaterials.TabIndex = 56;
            this.cbMaterials.SelectedIndexChanged += new System.EventHandler(this.CbMaterials_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label5.Location = new System.Drawing.Point(426, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 55;
            this.label5.Text = "بخش:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label3.Location = new System.Drawing.Point(719, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "کالا:";
            // 
            // cbStores
            // 
            this.cbStores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStores.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.cbStores.FormattingEnabled = true;
            this.cbStores.Location = new System.Drawing.Point(190, 46);
            this.cbStores.Margin = new System.Windows.Forms.Padding(4);
            this.cbStores.Name = "cbStores";
            this.cbStores.Size = new System.Drawing.Size(120, 24);
            this.cbStores.TabIndex = 54;
            this.cbStores.SelectedIndexChanged += new System.EventHandler(this.CbStores_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label2.Location = new System.Drawing.Point(154, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "انبار:";
            // 
            // cbMeasuementUnits
            // 
            this.cbMeasuementUnits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMeasuementUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMeasuementUnits.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.cbMeasuementUnits.FormattingEnabled = true;
            this.cbMeasuementUnits.Location = new System.Drawing.Point(497, 144);
            this.cbMeasuementUnits.Margin = new System.Windows.Forms.Padding(4);
            this.cbMeasuementUnits.Name = "cbMeasuementUnits";
            this.cbMeasuementUnits.Size = new System.Drawing.Size(120, 24);
            this.cbMeasuementUnits.TabIndex = 49;
            this.cbMeasuementUnits.SelectedIndexChanged += new System.EventHandler(this.CbMeasuementUnits_SelectedIndexChanged);
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(218, 144);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(120, 24);
            this.cbCategory.TabIndex = 50;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.CbCategory_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label6.Location = new System.Drawing.Point(391, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "واحد اندازه‌گیری:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label4.Location = new System.Drawing.Point(41, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "نوع:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label1.Location = new System.Drawing.Point(173, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 47;
            this.label1.Text = "رسته:";
            // 
            // btmCancel
            // 
            this.btmCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmCancel.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmCancel.Location = new System.Drawing.Point(525, 298);
            this.btmCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btmCancel.Name = "btmCancel";
            this.btmCancel.Size = new System.Drawing.Size(125, 35);
            this.btmCancel.TabIndex = 45;
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
            this.btmOK.Location = new System.Drawing.Point(365, 298);
            this.btmOK.Margin = new System.Windows.Forms.Padding(4);
            this.btmOK.Name = "btmOK";
            this.btmOK.Size = new System.Drawing.Size(125, 35);
            this.btmOK.TabIndex = 44;
            this.btmOK.Text = "تایید";
            this.btmOK.UseVisualStyleBackColor = true;
            this.btmOK.Click += new System.EventHandler(this.btmOK_Click);
            // 
            // btmMaterialEdit
            // 
            this.btmMaterialEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btmMaterialEdit.BackColor = System.Drawing.Color.Transparent;
            this.btmMaterialEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
            this.btmMaterialEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btmMaterialEdit.FlatAppearance.BorderSize = 0;
            this.btmMaterialEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btmMaterialEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btmMaterialEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmMaterialEdit.Location = new System.Drawing.Point(874, 43);
            this.btmMaterialEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btmMaterialEdit.Name = "btmMaterialEdit";
            this.btmMaterialEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.btmMaterialEdit.Size = new System.Drawing.Size(30, 30);
            this.btmMaterialEdit.TabIndex = 72;
            this.btmMaterialEdit.UseVisualStyleBackColor = false;
            this.btmMaterialEdit.Click += new System.EventHandler(this.BtmMaterialEdit_Click);
            this.btmMaterialEdit.MouseEnter += new System.EventHandler(this.BtmMaterialEdit_MouseEnter);
            this.btmMaterialEdit.MouseLeave += new System.EventHandler(this.BtmMaterialEdit_MouseLeave);
            // 
            // btmTypeEdit
            // 
            this.btmTypeEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmTypeEdit.BackColor = System.Drawing.Color.Transparent;
            this.btmTypeEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
            this.btmTypeEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btmTypeEdit.FlatAppearance.BorderSize = 0;
            this.btmTypeEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btmTypeEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btmTypeEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmTypeEdit.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmTypeEdit.Location = new System.Drawing.Point(196, 91);
            this.btmTypeEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btmTypeEdit.Name = "btmTypeEdit";
            this.btmTypeEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.btmTypeEdit.Size = new System.Drawing.Size(30, 30);
            this.btmTypeEdit.TabIndex = 71;
            this.btmTypeEdit.UseVisualStyleBackColor = false;
            this.btmTypeEdit.Click += new System.EventHandler(this.BtmTypeEdit_Click);
            this.btmTypeEdit.MouseEnter += new System.EventHandler(this.BtmTypeEdit_MouseEnter);
            this.btmTypeEdit.MouseLeave += new System.EventHandler(this.BtmTypeEdit_MouseLeave);
            // 
            // btmSectionEdit
            // 
            this.btmSectionEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmSectionEdit.BackColor = System.Drawing.Color.Transparent;
            this.btmSectionEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
            this.btmSectionEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btmSectionEdit.FlatAppearance.BorderSize = 0;
            this.btmSectionEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btmSectionEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btmSectionEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmSectionEdit.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmSectionEdit.Location = new System.Drawing.Point(600, 42);
            this.btmSectionEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btmSectionEdit.Name = "btmSectionEdit";
            this.btmSectionEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.btmSectionEdit.Size = new System.Drawing.Size(30, 30);
            this.btmSectionEdit.TabIndex = 70;
            this.btmSectionEdit.UseVisualStyleBackColor = false;
            this.btmSectionEdit.Click += new System.EventHandler(this.BtmSectionEdit_Click);
            this.btmSectionEdit.MouseEnter += new System.EventHandler(this.BtmSectionEdit_MouseEnter);
            this.btmSectionEdit.MouseLeave += new System.EventHandler(this.BtmSectionEdit_MouseLeave);
            // 
            // btmStoreEdit
            // 
            this.btmStoreEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmStoreEdit.BackColor = System.Drawing.Color.Transparent;
            this.btmStoreEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
            this.btmStoreEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btmStoreEdit.FlatAppearance.BorderSize = 0;
            this.btmStoreEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btmStoreEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btmStoreEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmStoreEdit.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmStoreEdit.Location = new System.Drawing.Point(314, 43);
            this.btmStoreEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btmStoreEdit.Name = "btmStoreEdit";
            this.btmStoreEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.btmStoreEdit.Size = new System.Drawing.Size(30, 30);
            this.btmStoreEdit.TabIndex = 69;
            this.btmStoreEdit.UseVisualStyleBackColor = false;
            this.btmStoreEdit.Click += new System.EventHandler(this.BtmStoreEdit_Click);
            this.btmStoreEdit.MouseEnter += new System.EventHandler(this.BtmStoreEdit_MouseEnter);
            this.btmStoreEdit.MouseLeave += new System.EventHandler(this.BtmStoreEdit_MouseLeave);
            // 
            // btmTakeOutFromList
            // 
            this.btmTakeOutFromList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmTakeOutFromList.BackColor = System.Drawing.Color.Transparent;
            this.btmTakeOutFromList.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._2_1;
            this.btmTakeOutFromList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btmTakeOutFromList.Enabled = false;
            this.btmTakeOutFromList.FlatAppearance.BorderSize = 0;
            this.btmTakeOutFromList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btmTakeOutFromList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btmTakeOutFromList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmTakeOutFromList.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmTakeOutFromList.Location = new System.Drawing.Point(521, 226);
            this.btmTakeOutFromList.Margin = new System.Windows.Forms.Padding(4);
            this.btmTakeOutFromList.Name = "btmTakeOutFromList";
            this.btmTakeOutFromList.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.btmTakeOutFromList.Size = new System.Drawing.Size(35, 33);
            this.btmTakeOutFromList.TabIndex = 68;
            this.btmTakeOutFromList.UseVisualStyleBackColor = false;
            this.btmTakeOutFromList.Click += new System.EventHandler(this.BtmTakeOutFromList_Click);
            this.btmTakeOutFromList.MouseEnter += new System.EventHandler(this.BtmTakeOutFromList_MouseEnter);
            this.btmTakeOutFromList.MouseLeave += new System.EventHandler(this.BtmTakeOutFromList_MouseLeave);
            // 
            // btmInsertToList
            // 
            this.btmInsertToList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmInsertToList.BackColor = System.Drawing.Color.Transparent;
            this.btmInsertToList.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._1_1;
            this.btmInsertToList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btmInsertToList.Enabled = false;
            this.btmInsertToList.FlatAppearance.BorderSize = 0;
            this.btmInsertToList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btmInsertToList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btmInsertToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmInsertToList.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmInsertToList.Location = new System.Drawing.Point(521, 192);
            this.btmInsertToList.Margin = new System.Windows.Forms.Padding(4);
            this.btmInsertToList.Name = "btmInsertToList";
            this.btmInsertToList.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.btmInsertToList.Size = new System.Drawing.Size(35, 33);
            this.btmInsertToList.TabIndex = 67;
            this.btmInsertToList.UseVisualStyleBackColor = false;
            this.btmInsertToList.Click += new System.EventHandler(this.BtmInsertToList_Click);
            this.btmInsertToList.MouseEnter += new System.EventHandler(this.BtmInsertToList_MouseEnter);
            this.btmInsertToList.MouseLeave += new System.EventHandler(this.BtmInsertToList_MouseLeave);
            // 
            // StuffUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1001, 373);
            this.Controls.Add(this.btmMaterialEdit);
            this.Controls.Add(this.btmTypeEdit);
            this.Controls.Add(this.btmSectionEdit);
            this.Controls.Add(this.btmStoreEdit);
            this.Controls.Add(this.btmTakeOutFromList);
            this.Controls.Add(this.btmInsertToList);
            this.Controls.Add(this.lbSelectedProperties);
            this.Controls.Add(this.cbProperties);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbSections);
            this.Controls.Add(this.cbTypes);
            this.Controls.Add(this.labCode);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbOrderPoint);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbMaterials);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbStores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMeasuementUnits);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btmCancel);
            this.Controls.Add(this.btmOK);
            this.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StuffUpdate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "به روز رسانی کالا";
            this.Load += new System.EventHandler(this.StuffUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmTypeEdit;
        private System.Windows.Forms.Button btmSectionEdit;
        private System.Windows.Forms.Button btmStoreEdit;
        private System.Windows.Forms.Button btmTakeOutFromList;
        private System.Windows.Forms.Button btmInsertToList;
        private System.Windows.Forms.ListBox lbSelectedProperties;
        private System.Windows.Forms.ComboBox cbProperties;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbSections;
        private System.Windows.Forms.ComboBox cbTypes;
        private System.Windows.Forms.Label labCode;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbOrderPoint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMaterials;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMeasuementUnits;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btmCancel;
        private System.Windows.Forms.Button btmOK;
        private System.Windows.Forms.Button btmMaterialEdit;
    }
}