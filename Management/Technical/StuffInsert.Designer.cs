namespace Baran.Ferroalloy.Management
{
    partial class StuffInsert
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
            this.components = new System.ComponentModel.Container();
            this.btmOK = new System.Windows.Forms.Button();
            this.btmCancel = new System.Windows.Forms.Button();
            this.tbOrderPoint = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMaterials = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSections = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStores = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMeasuementUnits = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labCode = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbTypes = new System.Windows.Forms.ComboBox();
            this.lbSelectedProperties = new System.Windows.Forms.ListBox();
            this.cbProperties = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ttInsertToList = new System.Windows.Forms.ToolTip(this.components);
            this.btmTypeEdit = new System.Windows.Forms.Button();
            this.btm_MaterialEdit = new System.Windows.Forms.Button();
            this.btm_SectionEdit = new System.Windows.Forms.Button();
            this.btm_StoreEdit = new System.Windows.Forms.Button();
            this.btmInsertToList = new System.Windows.Forms.Button();
            this.ttTakeOutFromList = new System.Windows.Forms.ToolTip(this.components);
            this.btmTakeOutFromList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btmOK
            // 
            this.btmOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmOK.Enabled = false;
            this.btmOK.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btmOK.Location = new System.Drawing.Point(363, 290);
            this.btmOK.Margin = new System.Windows.Forms.Padding(4);
            this.btmOK.Name = "btmOK";
            this.btmOK.Size = new System.Drawing.Size(125, 35);
            this.btmOK.TabIndex = 6;
            this.btmOK.Text = "تایید";
            this.btmOK.UseVisualStyleBackColor = true;
            this.btmOK.Click += new System.EventHandler(this.btmOK_Click);
            // 
            // btmCancel
            // 
            this.btmCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmCancel.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btmCancel.Location = new System.Drawing.Point(523, 290);
            this.btmCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btmCancel.Name = "btmCancel";
            this.btmCancel.Size = new System.Drawing.Size(125, 35);
            this.btmCancel.TabIndex = 7;
            this.btmCancel.Text = "رد";
            this.btmCancel.UseVisualStyleBackColor = true;
            this.btmCancel.Click += new System.EventHandler(this.btmCancel_Click);
            // 
            // tbOrderPoint
            // 
            this.tbOrderPoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOrderPoint.Font = new System.Drawing.Font("B Yekan", 10F);
            this.tbOrderPoint.Location = new System.Drawing.Point(776, 136);
            this.tbOrderPoint.Margin = new System.Windows.Forms.Padding(4);
            this.tbOrderPoint.MaxLength = 10;
            this.tbOrderPoint.Name = "tbOrderPoint";
            this.tbOrderPoint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbOrderPoint.Size = new System.Drawing.Size(80, 28);
            this.tbOrderPoint.TabIndex = 29;
            this.tbOrderPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbOrderPoint.TextChanged += new System.EventHandler(this.TbOrderPoint_TextChanged);
            this.tbOrderPoint.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            this.tbOrderPoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetNumbericCharsTextBoxes);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label7.Location = new System.Drawing.Point(683, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "نقطه سفارش:";
            // 
            // cbMaterials
            // 
            this.cbMaterials.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMaterials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaterials.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbMaterials.FormattingEnabled = true;
            this.cbMaterials.Location = new System.Drawing.Point(749, 38);
            this.cbMaterials.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaterials.Name = "cbMaterials";
            this.cbMaterials.Size = new System.Drawing.Size(120, 28);
            this.cbMaterials.TabIndex = 27;
            this.cbMaterials.SelectedIndexChanged += new System.EventHandler(this.CbMaterials_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label5.Location = new System.Drawing.Point(427, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "بخش:";
            // 
            // cbSections
            // 
            this.cbSections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSections.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbSections.FormattingEnabled = true;
            this.cbSections.Location = new System.Drawing.Point(471, 38);
            this.cbSections.Margin = new System.Windows.Forms.Padding(4);
            this.cbSections.Name = "cbSections";
            this.cbSections.Size = new System.Drawing.Size(120, 28);
            this.cbSections.TabIndex = 24;
            this.cbSections.SelectedIndexChanged += new System.EventHandler(this.CbSections_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label3.Location = new System.Drawing.Point(717, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "کالا:";
            // 
            // cbStores
            // 
            this.cbStores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStores.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbStores.FormattingEnabled = true;
            this.cbStores.Location = new System.Drawing.Point(188, 38);
            this.cbStores.Margin = new System.Windows.Forms.Padding(4);
            this.cbStores.Name = "cbStores";
            this.cbStores.Size = new System.Drawing.Size(120, 28);
            this.cbStores.TabIndex = 25;
            this.cbStores.SelectedIndexChanged += new System.EventHandler(this.CbStores_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label2.Location = new System.Drawing.Point(154, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "انبار:";
            // 
            // cbMeasuementUnits
            // 
            this.cbMeasuementUnits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMeasuementUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMeasuementUnits.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbMeasuementUnits.FormattingEnabled = true;
            this.cbMeasuementUnits.Location = new System.Drawing.Point(495, 136);
            this.cbMeasuementUnits.Margin = new System.Windows.Forms.Padding(4);
            this.cbMeasuementUnits.Name = "cbMeasuementUnits";
            this.cbMeasuementUnits.Size = new System.Drawing.Size(120, 28);
            this.cbMeasuementUnits.TabIndex = 20;
            this.cbMeasuementUnits.SelectedIndexChanged += new System.EventHandler(this.CbMeasuementUnits_SelectedIndexChanged);
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(216, 136);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(120, 28);
            this.cbCategory.TabIndex = 21;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.CbCategory_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label6.Location = new System.Drawing.Point(389, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "واحد اندازه‌گیری:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label4.Location = new System.Drawing.Point(37, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "نوع:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label1.Location = new System.Drawing.Point(171, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "رسته:";
            // 
            // labCode
            // 
            this.labCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labCode.Font = new System.Drawing.Font("B Yekan", 10F);
            this.labCode.Location = new System.Drawing.Point(658, 88);
            this.labCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(300, 22);
            this.labCode.TabIndex = 33;
            // 
            // labName
            // 
            this.labName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labName.Font = new System.Drawing.Font("B Yekan", 10F);
            this.labName.Location = new System.Drawing.Point(286, 88);
            this.labName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(300, 22);
            this.labName.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label8.Location = new System.Drawing.Point(628, 89);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 21);
            this.label8.TabIndex = 31;
            this.label8.Text = "کد:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label9.Location = new System.Drawing.Point(253, 89);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 21);
            this.label9.TabIndex = 30;
            this.label9.Text = "نام:";
            // 
            // cbTypes
            // 
            this.cbTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypes.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Location = new System.Drawing.Point(68, 87);
            this.cbTypes.Margin = new System.Windows.Forms.Padding(4);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(120, 28);
            this.cbTypes.TabIndex = 34;
            this.cbTypes.SelectedIndexChanged += new System.EventHandler(this.CbCodes_SelectedIndexChanged);
            // 
            // lbSelectedProperties
            // 
            this.lbSelectedProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSelectedProperties.Font = new System.Drawing.Font("B Yekan", 10F);
            this.lbSelectedProperties.FormattingEnabled = true;
            this.lbSelectedProperties.ItemHeight = 20;
            this.lbSelectedProperties.Location = new System.Drawing.Point(561, 177);
            this.lbSelectedProperties.Name = "lbSelectedProperties";
            this.lbSelectedProperties.Size = new System.Drawing.Size(120, 84);
            this.lbSelectedProperties.TabIndex = 37;
            this.lbSelectedProperties.SelectedIndexChanged += new System.EventHandler(this.LbSelectedProperties_SelectedIndexChanged);
            // 
            // cbProperties
            // 
            this.cbProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProperties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProperties.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbProperties.FormattingEnabled = true;
            this.cbProperties.Location = new System.Drawing.Point(370, 184);
            this.cbProperties.Margin = new System.Windows.Forms.Padding(4);
            this.cbProperties.Name = "cbProperties";
            this.cbProperties.Size = new System.Drawing.Size(120, 28);
            this.cbProperties.TabIndex = 36;
            this.cbProperties.SelectedIndexChanged += new System.EventHandler(this.CbProperties_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label10.Location = new System.Drawing.Point(318, 187);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 21);
            this.label10.TabIndex = 35;
            this.label10.Text = "ویژگی:";
            // 
            // ttInsertToList
            // 
            this.ttInsertToList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ttInsertToList.Tag = "";
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
            this.btmTypeEdit.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btmTypeEdit.Location = new System.Drawing.Point(188, 83);
            this.btmTypeEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btmTypeEdit.Name = "btmTypeEdit";
            this.btmTypeEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.btmTypeEdit.Size = new System.Drawing.Size(30, 30);
            this.btmTypeEdit.TabIndex = 43;
            this.ttInsertToList.SetToolTip(this.btmTypeEdit, "انتخاب");
            this.btmTypeEdit.UseVisualStyleBackColor = false;
            this.btmTypeEdit.Click += new System.EventHandler(this.BtmTypes_Click);
            this.btmTypeEdit.MouseEnter += new System.EventHandler(this.BtmTypes_MouseEnter);
            this.btmTypeEdit.MouseLeave += new System.EventHandler(this.BtmTypes_MouseLeave);
            // 
            // btm_MaterialEdit
            // 
            this.btm_MaterialEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btm_MaterialEdit.BackColor = System.Drawing.Color.Transparent;
            this.btm_MaterialEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
            this.btm_MaterialEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btm_MaterialEdit.FlatAppearance.BorderSize = 0;
            this.btm_MaterialEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btm_MaterialEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btm_MaterialEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm_MaterialEdit.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btm_MaterialEdit.Location = new System.Drawing.Point(870, 35);
            this.btm_MaterialEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btm_MaterialEdit.Name = "btm_MaterialEdit";
            this.btm_MaterialEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.btm_MaterialEdit.Size = new System.Drawing.Size(30, 30);
            this.btm_MaterialEdit.TabIndex = 42;
            this.ttInsertToList.SetToolTip(this.btm_MaterialEdit, "انتخاب");
            this.btm_MaterialEdit.UseVisualStyleBackColor = false;
            this.btm_MaterialEdit.Click += new System.EventHandler(this.Btm_MaterialEdit_Click);
            this.btm_MaterialEdit.MouseEnter += new System.EventHandler(this.Btm_MaterialEdit_MouseEnter);
            this.btm_MaterialEdit.MouseLeave += new System.EventHandler(this.Btm_MaterialEdit_MouseLeave);
            // 
            // btm_SectionEdit
            // 
            this.btm_SectionEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btm_SectionEdit.BackColor = System.Drawing.Color.Transparent;
            this.btm_SectionEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
            this.btm_SectionEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btm_SectionEdit.FlatAppearance.BorderSize = 0;
            this.btm_SectionEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btm_SectionEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btm_SectionEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm_SectionEdit.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btm_SectionEdit.Location = new System.Drawing.Point(593, 34);
            this.btm_SectionEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btm_SectionEdit.Name = "btm_SectionEdit";
            this.btm_SectionEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.btm_SectionEdit.Size = new System.Drawing.Size(30, 30);
            this.btm_SectionEdit.TabIndex = 41;
            this.ttInsertToList.SetToolTip(this.btm_SectionEdit, "انتخاب");
            this.btm_SectionEdit.UseVisualStyleBackColor = false;
            this.btm_SectionEdit.Click += new System.EventHandler(this.Btm_SectionEdit_Click);
            this.btm_SectionEdit.MouseEnter += new System.EventHandler(this.Btm_SectionEdit_MouseEnter);
            this.btm_SectionEdit.MouseLeave += new System.EventHandler(this.Btm_SectionEdit_MouseLeave);
            // 
            // btm_StoreEdit
            // 
            this.btm_StoreEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btm_StoreEdit.BackColor = System.Drawing.Color.Transparent;
            this.btm_StoreEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
            this.btm_StoreEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btm_StoreEdit.FlatAppearance.BorderSize = 0;
            this.btm_StoreEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btm_StoreEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btm_StoreEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm_StoreEdit.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btm_StoreEdit.Location = new System.Drawing.Point(309, 35);
            this.btm_StoreEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btm_StoreEdit.Name = "btm_StoreEdit";
            this.btm_StoreEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.btm_StoreEdit.Size = new System.Drawing.Size(30, 30);
            this.btm_StoreEdit.TabIndex = 40;
            this.ttInsertToList.SetToolTip(this.btm_StoreEdit, "انتخاب");
            this.btm_StoreEdit.UseVisualStyleBackColor = false;
            this.btm_StoreEdit.Click += new System.EventHandler(this.btm_StoreEdit_Click);
            this.btm_StoreEdit.MouseEnter += new System.EventHandler(this.btm_StoreEdit_MouseEnter);
            this.btm_StoreEdit.MouseLeave += new System.EventHandler(this.btm_StoreEdit_MouseLeave);
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
            this.btmInsertToList.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btmInsertToList.Location = new System.Drawing.Point(519, 184);
            this.btmInsertToList.Margin = new System.Windows.Forms.Padding(4);
            this.btmInsertToList.Name = "btmInsertToList";
            this.btmInsertToList.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.btmInsertToList.Size = new System.Drawing.Size(35, 33);
            this.btmInsertToList.TabIndex = 38;
            this.ttInsertToList.SetToolTip(this.btmInsertToList, "انتخاب");
            this.btmInsertToList.UseVisualStyleBackColor = false;
            this.btmInsertToList.Click += new System.EventHandler(this.BtmInsertToList_Click);
            this.btmInsertToList.MouseEnter += new System.EventHandler(this.BtmInsertToList_MouseEnter);
            this.btmInsertToList.MouseLeave += new System.EventHandler(this.BtmInsertToList_MouseLeave);
            // 
            // ttTakeOutFromList
            // 
            this.ttTakeOutFromList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ttTakeOutFromList.Tag = "";
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
            this.btmTakeOutFromList.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btmTakeOutFromList.Location = new System.Drawing.Point(519, 218);
            this.btmTakeOutFromList.Margin = new System.Windows.Forms.Padding(4);
            this.btmTakeOutFromList.Name = "btmTakeOutFromList";
            this.btmTakeOutFromList.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.btmTakeOutFromList.Size = new System.Drawing.Size(35, 33);
            this.btmTakeOutFromList.TabIndex = 39;
            this.ttTakeOutFromList.SetToolTip(this.btmTakeOutFromList, "حذف");
            this.btmTakeOutFromList.UseVisualStyleBackColor = false;
            this.btmTakeOutFromList.Click += new System.EventHandler(this.BtmTakeOutFromList_Click);
            this.btmTakeOutFromList.MouseEnter += new System.EventHandler(this.BtmTakeOutFromList_MouseEnter);
            this.btmTakeOutFromList.MouseLeave += new System.EventHandler(this.BtmTakeOutFromList_MouseLeave);
            // 
            // StuffInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1001, 373);
            this.Controls.Add(this.btmTypeEdit);
            this.Controls.Add(this.btm_MaterialEdit);
            this.Controls.Add(this.btm_SectionEdit);
            this.Controls.Add(this.btm_StoreEdit);
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
            this.Font = new System.Drawing.Font("B Yekan", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StuffInsert";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ورود کالا جدید";
            this.Load += new System.EventHandler(this.StuffInsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btmOK;
        private System.Windows.Forms.Button btmCancel;
        private System.Windows.Forms.TextBox tbOrderPoint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMaterials;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSections;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMeasuementUnits;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labCode;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbTypes;
        private System.Windows.Forms.Button btmTakeOutFromList;
        private System.Windows.Forms.Button btmInsertToList;
        private System.Windows.Forms.ListBox lbSelectedProperties;
        private System.Windows.Forms.ComboBox cbProperties;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip ttInsertToList;
        private System.Windows.Forms.ToolTip ttTakeOutFromList;
        private System.Windows.Forms.Button btm_StoreEdit;
        private System.Windows.Forms.Button btm_SectionEdit;
        private System.Windows.Forms.Button btm_MaterialEdit;
        private System.Windows.Forms.Button btmTypeEdit;
    }
}