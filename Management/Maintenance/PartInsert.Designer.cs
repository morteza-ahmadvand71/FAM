namespace Baran.Ferroalloy.Management
{
    partial class PartInsert
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
            this.cbName = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStores = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMeasuementUnits = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labCode = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbBranch = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ttInsertToList = new System.Windows.Forms.ToolTip(this.components);
            this.Btm_PropertiesRegister = new System.Windows.Forms.Button();
            this.Btm_MeasurementUnitsEdit = new System.Windows.Forms.Button();
            this.Btm_SubBranchEdit = new System.Windows.Forms.Button();
            this.Btm_BranchEdit = new System.Windows.Forms.Button();
            this.btm_NameEdit = new System.Windows.Forms.Button();
            this.btm_CategoryEdit = new System.Windows.Forms.Button();
            this.btm_StoreEdit = new System.Windows.Forms.Button();
            this.Btm_PropertiesDelete = new System.Windows.Forms.Button();
            this.ttTakeOutFromList = new System.Windows.Forms.ToolTip(this.components);
            this.cbSubBranch = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbSelectedProperties = new System.Windows.Forms.ListBox();
            this.cbProperties = new System.Windows.Forms.ComboBox();
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
            this.tbOrderPoint.Location = new System.Drawing.Point(858, 183);
            this.tbOrderPoint.Margin = new System.Windows.Forms.Padding(4);
            this.tbOrderPoint.MaxLength = 10;
            this.tbOrderPoint.Name = "tbOrderPoint";
            this.tbOrderPoint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbOrderPoint.Size = new System.Drawing.Size(120, 28);
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
            this.label7.Location = new System.Drawing.Point(765, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "نقطه سفارش:";
            // 
            // cbName
            // 
            this.cbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbName.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(749, 38);
            this.cbName.Margin = new System.Windows.Forms.Padding(4);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(120, 28);
            this.cbName.TabIndex = 27;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.CbName_SelectedIndexChanged);
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
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "رسته:";
            // 
            // cbCategories
            // 
            this.cbCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(471, 38);
            this.cbCategories.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(120, 28);
            this.cbCategories.TabIndex = 24;
            this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.CbCategories_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label3.Location = new System.Drawing.Point(693, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "نام کالا:";
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
            this.cbMeasuementUnits.Location = new System.Drawing.Point(188, 183);
            this.cbMeasuementUnits.Margin = new System.Windows.Forms.Padding(4);
            this.cbMeasuementUnits.Name = "cbMeasuementUnits";
            this.cbMeasuementUnits.Size = new System.Drawing.Size(120, 28);
            this.cbMeasuementUnits.TabIndex = 20;
            this.cbMeasuementUnits.SelectedIndexChanged += new System.EventHandler(this.CbMeasuementUnits_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label6.Location = new System.Drawing.Point(82, 187);
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
            this.label4.Location = new System.Drawing.Point(28, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "شاخه:";
            // 
            // labCode
            // 
            this.labCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labCode.Font = new System.Drawing.Font("B Yekan", 10F);
            this.labCode.Location = new System.Drawing.Point(729, 113);
            this.labCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(177, 22);
            this.labCode.TabIndex = 33;
            // 
            // labName
            // 
            this.labName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labName.Font = new System.Drawing.Font("B Yekan", 10F);
            this.labName.Location = new System.Drawing.Point(525, 112);
            this.labName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(162, 22);
            this.labName.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label8.Location = new System.Drawing.Point(693, 115);
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
            this.label9.Location = new System.Drawing.Point(486, 114);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 21);
            this.label9.TabIndex = 30;
            this.label9.Text = "نام:";
            // 
            // cbBranch
            // 
            this.cbBranch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBranch.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbBranch.FormattingEnabled = true;
            this.cbBranch.Location = new System.Drawing.Point(68, 112);
            this.cbBranch.Margin = new System.Windows.Forms.Padding(4);
            this.cbBranch.Name = "cbBranch";
            this.cbBranch.Size = new System.Drawing.Size(120, 28);
            this.cbBranch.TabIndex = 34;
            this.cbBranch.SelectedIndexChanged += new System.EventHandler(this.CbBranch_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label10.Location = new System.Drawing.Point(419, 186);
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
            // Btm_PropertiesRegister
            // 
            this.Btm_PropertiesRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btm_PropertiesRegister.BackColor = System.Drawing.Color.Transparent;
            this.Btm_PropertiesRegister.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._1_1;
            this.Btm_PropertiesRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btm_PropertiesRegister.FlatAppearance.BorderSize = 0;
            this.Btm_PropertiesRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btm_PropertiesRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btm_PropertiesRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_PropertiesRegister.Font = new System.Drawing.Font("B Yekan", 10F);
            this.Btm_PropertiesRegister.Location = new System.Drawing.Point(593, 155);
            this.Btm_PropertiesRegister.Margin = new System.Windows.Forms.Padding(4);
            this.Btm_PropertiesRegister.Name = "Btm_PropertiesRegister";
            this.Btm_PropertiesRegister.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.Btm_PropertiesRegister.Size = new System.Drawing.Size(30, 30);
            this.Btm_PropertiesRegister.TabIndex = 48;
            this.ttInsertToList.SetToolTip(this.Btm_PropertiesRegister, "انتخاب");
            this.Btm_PropertiesRegister.UseVisualStyleBackColor = false;
            this.Btm_PropertiesRegister.Click += new System.EventHandler(this.Btm_PropertiesRegister_Click);
            // 
            // Btm_MeasurementUnitsEdit
            // 
            this.Btm_MeasurementUnitsEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btm_MeasurementUnitsEdit.BackColor = System.Drawing.Color.Transparent;
            this.Btm_MeasurementUnitsEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
            this.Btm_MeasurementUnitsEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btm_MeasurementUnitsEdit.FlatAppearance.BorderSize = 0;
            this.Btm_MeasurementUnitsEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btm_MeasurementUnitsEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btm_MeasurementUnitsEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_MeasurementUnitsEdit.Font = new System.Drawing.Font("B Yekan", 10F);
            this.Btm_MeasurementUnitsEdit.Location = new System.Drawing.Point(309, 182);
            this.Btm_MeasurementUnitsEdit.Margin = new System.Windows.Forms.Padding(4);
            this.Btm_MeasurementUnitsEdit.Name = "Btm_MeasurementUnitsEdit";
            this.Btm_MeasurementUnitsEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.Btm_MeasurementUnitsEdit.Size = new System.Drawing.Size(30, 30);
            this.Btm_MeasurementUnitsEdit.TabIndex = 47;
            this.ttInsertToList.SetToolTip(this.Btm_MeasurementUnitsEdit, "انتخاب");
            this.Btm_MeasurementUnitsEdit.UseVisualStyleBackColor = false;
            this.Btm_MeasurementUnitsEdit.Click += new System.EventHandler(this.Btm_MeasurementUnitsEdit_Click);
            // 
            // Btm_SubBranchEdit
            // 
            this.Btm_SubBranchEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btm_SubBranchEdit.BackColor = System.Drawing.Color.Transparent;
            this.Btm_SubBranchEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
            this.Btm_SubBranchEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btm_SubBranchEdit.FlatAppearance.BorderSize = 0;
            this.Btm_SubBranchEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btm_SubBranchEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btm_SubBranchEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_SubBranchEdit.Font = new System.Drawing.Font("B Yekan", 10F);
            this.Btm_SubBranchEdit.Location = new System.Drawing.Point(429, 109);
            this.Btm_SubBranchEdit.Margin = new System.Windows.Forms.Padding(4);
            this.Btm_SubBranchEdit.Name = "Btm_SubBranchEdit";
            this.Btm_SubBranchEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.Btm_SubBranchEdit.Size = new System.Drawing.Size(30, 30);
            this.Btm_SubBranchEdit.TabIndex = 46;
            this.ttInsertToList.SetToolTip(this.Btm_SubBranchEdit, "انتخاب");
            this.Btm_SubBranchEdit.UseVisualStyleBackColor = false;
            this.Btm_SubBranchEdit.Click += new System.EventHandler(this.Btm_SubBranchEdit_Click);
            // 
            // Btm_BranchEdit
            // 
            this.Btm_BranchEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btm_BranchEdit.BackColor = System.Drawing.Color.Transparent;
            this.Btm_BranchEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
            this.Btm_BranchEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btm_BranchEdit.FlatAppearance.BorderSize = 0;
            this.Btm_BranchEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btm_BranchEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btm_BranchEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_BranchEdit.Font = new System.Drawing.Font("B Yekan", 10F);
            this.Btm_BranchEdit.Location = new System.Drawing.Point(188, 108);
            this.Btm_BranchEdit.Margin = new System.Windows.Forms.Padding(4);
            this.Btm_BranchEdit.Name = "Btm_BranchEdit";
            this.Btm_BranchEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.Btm_BranchEdit.Size = new System.Drawing.Size(30, 30);
            this.Btm_BranchEdit.TabIndex = 43;
            this.ttInsertToList.SetToolTip(this.Btm_BranchEdit, "انتخاب");
            this.Btm_BranchEdit.UseVisualStyleBackColor = false;
            this.Btm_BranchEdit.Click += new System.EventHandler(this.Btm_BranchEdit_Click);
            this.Btm_BranchEdit.MouseEnter += new System.EventHandler(this.BtmTypes_MouseEnter);
            this.Btm_BranchEdit.MouseLeave += new System.EventHandler(this.BtmTypes_MouseLeave);
            // 
            // btm_NameEdit
            // 
            this.btm_NameEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btm_NameEdit.BackColor = System.Drawing.Color.Transparent;
            this.btm_NameEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
            this.btm_NameEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btm_NameEdit.FlatAppearance.BorderSize = 0;
            this.btm_NameEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btm_NameEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btm_NameEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm_NameEdit.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btm_NameEdit.Location = new System.Drawing.Point(870, 35);
            this.btm_NameEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btm_NameEdit.Name = "btm_NameEdit";
            this.btm_NameEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.btm_NameEdit.Size = new System.Drawing.Size(30, 30);
            this.btm_NameEdit.TabIndex = 42;
            this.ttInsertToList.SetToolTip(this.btm_NameEdit, "انتخاب");
            this.btm_NameEdit.UseVisualStyleBackColor = false;
            this.btm_NameEdit.Click += new System.EventHandler(this.Btm_NameEdit_Click);
            this.btm_NameEdit.MouseEnter += new System.EventHandler(this.Btm_MaterialEdit_MouseEnter);
            this.btm_NameEdit.MouseLeave += new System.EventHandler(this.Btm_MaterialEdit_MouseLeave);
            // 
            // btm_CategoryEdit
            // 
            this.btm_CategoryEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btm_CategoryEdit.BackColor = System.Drawing.Color.Transparent;
            this.btm_CategoryEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
            this.btm_CategoryEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btm_CategoryEdit.FlatAppearance.BorderSize = 0;
            this.btm_CategoryEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btm_CategoryEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btm_CategoryEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm_CategoryEdit.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btm_CategoryEdit.Location = new System.Drawing.Point(593, 34);
            this.btm_CategoryEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btm_CategoryEdit.Name = "btm_CategoryEdit";
            this.btm_CategoryEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.btm_CategoryEdit.Size = new System.Drawing.Size(30, 30);
            this.btm_CategoryEdit.TabIndex = 41;
            this.ttInsertToList.SetToolTip(this.btm_CategoryEdit, "انتخاب");
            this.btm_CategoryEdit.UseVisualStyleBackColor = false;
            this.btm_CategoryEdit.Click += new System.EventHandler(this.Btm_CategoryEdit_Click);
            this.btm_CategoryEdit.MouseEnter += new System.EventHandler(this.Btm_SectionEdit_MouseEnter);
            this.btm_CategoryEdit.MouseLeave += new System.EventHandler(this.Btm_SectionEdit_MouseLeave);
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
            // Btm_PropertiesDelete
            // 
            this.Btm_PropertiesDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btm_PropertiesDelete.BackColor = System.Drawing.Color.Transparent;
            this.Btm_PropertiesDelete.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._2_1;
            this.Btm_PropertiesDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btm_PropertiesDelete.FlatAppearance.BorderSize = 0;
            this.Btm_PropertiesDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btm_PropertiesDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btm_PropertiesDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_PropertiesDelete.Font = new System.Drawing.Font("B Yekan", 10F);
            this.Btm_PropertiesDelete.Location = new System.Drawing.Point(593, 209);
            this.Btm_PropertiesDelete.Margin = new System.Windows.Forms.Padding(4);
            this.Btm_PropertiesDelete.Name = "Btm_PropertiesDelete";
            this.Btm_PropertiesDelete.Padding = new System.Windows.Forms.Padding(0, 0, 0, 14);
            this.Btm_PropertiesDelete.Size = new System.Drawing.Size(30, 30);
            this.Btm_PropertiesDelete.TabIndex = 51;
            this.ttInsertToList.SetToolTip(this.Btm_PropertiesDelete, "انتخاب");
            this.Btm_PropertiesDelete.UseVisualStyleBackColor = false;
            this.Btm_PropertiesDelete.Click += new System.EventHandler(this.Btm_PropertiesDelete_Click);
            // 
            // ttTakeOutFromList
            // 
            this.ttTakeOutFromList.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ttTakeOutFromList.Tag = "";
            // 
            // cbSubBranch
            // 
            this.cbSubBranch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSubBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubBranch.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbSubBranch.FormattingEnabled = true;
            this.cbSubBranch.Location = new System.Drawing.Point(309, 113);
            this.cbSubBranch.Margin = new System.Windows.Forms.Padding(4);
            this.cbSubBranch.Name = "cbSubBranch";
            this.cbSubBranch.Size = new System.Drawing.Size(120, 28);
            this.cbSubBranch.TabIndex = 45;
            this.cbSubBranch.SelectedIndexChanged += new System.EventHandler(this.CbSubBranch_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label11.Location = new System.Drawing.Point(243, 115);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 21);
            this.label11.TabIndex = 44;
            this.label11.Text = "زیرشاخه:";
            // 
            // lbSelectedProperties
            // 
            this.lbSelectedProperties.FormattingEnabled = true;
            this.lbSelectedProperties.ItemHeight = 20;
            this.lbSelectedProperties.Location = new System.Drawing.Point(630, 155);
            this.lbSelectedProperties.Name = "lbSelectedProperties";
            this.lbSelectedProperties.Size = new System.Drawing.Size(120, 104);
            this.lbSelectedProperties.TabIndex = 49;
            // 
            // cbProperties
            // 
            this.cbProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProperties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProperties.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbProperties.FormattingEnabled = true;
            this.cbProperties.Location = new System.Drawing.Point(465, 183);
            this.cbProperties.Margin = new System.Windows.Forms.Padding(4);
            this.cbProperties.Name = "cbProperties";
            this.cbProperties.Size = new System.Drawing.Size(120, 28);
            this.cbProperties.TabIndex = 53;
            // 
            // PartInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1001, 373);
            this.Controls.Add(this.cbProperties);
            this.Controls.Add(this.Btm_PropertiesDelete);
            this.Controls.Add(this.lbSelectedProperties);
            this.Controls.Add(this.Btm_PropertiesRegister);
            this.Controls.Add(this.Btm_MeasurementUnitsEdit);
            this.Controls.Add(this.Btm_SubBranchEdit);
            this.Controls.Add(this.cbSubBranch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Btm_BranchEdit);
            this.Controls.Add(this.btm_NameEdit);
            this.Controls.Add(this.btm_CategoryEdit);
            this.Controls.Add(this.btm_StoreEdit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.cbBranch);
            this.Controls.Add(this.labCode);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbOrderPoint);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbStores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMeasuementUnits);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btmCancel);
            this.Controls.Add(this.btmOK);
            this.Font = new System.Drawing.Font("B Yekan", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PartInsert";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ورود کالا جدید";
            this.Load += new System.EventHandler(this.PartInsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btmOK;
        private System.Windows.Forms.Button btmCancel;
        private System.Windows.Forms.TextBox tbOrderPoint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMeasuementUnits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labCode;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbBranch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip ttInsertToList;
        private System.Windows.Forms.ToolTip ttTakeOutFromList;
        private System.Windows.Forms.Button btm_StoreEdit;
        private System.Windows.Forms.Button btm_NameEdit;
        private System.Windows.Forms.Button Btm_BranchEdit;
        private System.Windows.Forms.Button Btm_SubBranchEdit;
        private System.Windows.Forms.ComboBox cbSubBranch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btm_CategoryEdit;
        private System.Windows.Forms.Button Btm_MeasurementUnitsEdit;
        private System.Windows.Forms.Button Btm_PropertiesRegister;
        private System.Windows.Forms.ListBox lbSelectedProperties;
        private System.Windows.Forms.Button Btm_PropertiesDelete;
        private System.Windows.Forms.ComboBox cbProperties;
    }
}