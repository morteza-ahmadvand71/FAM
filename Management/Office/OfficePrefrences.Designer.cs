namespace Baran.Ferroalloy.Management
{
    partial class OfficePrefrences
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btmExit = new System.Windows.Forms.Button();
            this.tpPrefrences = new System.Windows.Forms.TabControl();
            this.tabCo = new System.Windows.Forms.TabPage();
            this.tbWebSite = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.dtpRegister = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btmCoSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTaxID = new System.Windows.Forms.TextBox();
            this.tbCoID = new System.Windows.Forms.TextBox();
            this.tbFax = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbProvince = new System.Windows.Forms.TextBox();
            this.tbRegisterNumber = new System.Windows.Forms.TextBox();
            this.tbTell = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPostalCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.cbTypes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabDepartments = new System.Windows.Forms.TabPage();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.btmDepartmentsSave = new System.Windows.Forms.Button();
            this.tabCategories = new System.Windows.Forms.TabPage();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.btmCategoriesSave = new System.Windows.Forms.Button();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitSelect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitIsActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpPrefrences.SuspendLayout();
            this.tabCo.SuspendLayout();
            this.tabDepartments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.tabCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
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
            this.tpPrefrences.Location = new System.Drawing.Point(271, 30);
            this.tpPrefrences.Name = "tpPrefrences";
            this.tpPrefrences.RightToLeftLayout = true;
            this.tpPrefrences.SelectedIndex = 0;
            this.tpPrefrences.Size = new System.Drawing.Size(821, 613);
            this.tpPrefrences.TabIndex = 10;
            // 
            // tabCo
            // 
            this.tabCo.BackColor = System.Drawing.SystemColors.Control;
            this.tabCo.Controls.Add(this.tbWebSite);
            this.tabCo.Controls.Add(this.label12);
            this.tabCo.Controls.Add(this.tbCity);
            this.tabCo.Controls.Add(this.dtpRegister);
            this.tabCo.Controls.Add(this.label8);
            this.tabCo.Controls.Add(this.btmCoSave);
            this.tabCo.Controls.Add(this.label7);
            this.tabCo.Controls.Add(this.tbTaxID);
            this.tabCo.Controls.Add(this.tbCoID);
            this.tabCo.Controls.Add(this.tbFax);
            this.tabCo.Controls.Add(this.label11);
            this.tabCo.Controls.Add(this.label9);
            this.tabCo.Controls.Add(this.label4);
            this.tabCo.Controls.Add(this.tbProvince);
            this.tabCo.Controls.Add(this.tbRegisterNumber);
            this.tabCo.Controls.Add(this.tbTell);
            this.tabCo.Controls.Add(this.label3);
            this.tabCo.Controls.Add(this.tbPostalCode);
            this.tabCo.Controls.Add(this.label2);
            this.tabCo.Controls.Add(this.tbAddress);
            this.tabCo.Controls.Add(this.cbTypes);
            this.tabCo.Controls.Add(this.label5);
            this.tabCo.Controls.Add(this.label1);
            this.tabCo.Controls.Add(this.tbName);
            this.tabCo.Controls.Add(this.label10);
            this.tabCo.Controls.Add(this.label13);
            this.tabCo.Controls.Add(this.label6);
            this.tabCo.Controls.Add(this.label14);
            this.tabCo.Location = new System.Drawing.Point(4, 25);
            this.tabCo.Name = "tabCo";
            this.tabCo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCo.Size = new System.Drawing.Size(813, 584);
            this.tabCo.TabIndex = 2;
            this.tabCo.Text = "شرکت";
            // 
            // tbWebSite
            // 
            this.tbWebSite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWebSite.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWebSite.Location = new System.Drawing.Point(195, 395);
            this.tbWebSite.Margin = new System.Windows.Forms.Padding(2);
            this.tbWebSite.MaxLength = 20;
            this.tbWebSite.Name = "tbWebSite";
            this.tbWebSite.Size = new System.Drawing.Size(150, 24);
            this.tbWebSite.TabIndex = 13;
            this.tbWebSite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbWebSite.Enter += new System.EventHandler(this.SetEnglishLanguageTextBoxes);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label12.Location = new System.Drawing.Point(345, 200);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 35;
            this.label12.Text = "شهرستان:";
            // 
            // tbCity
            // 
            this.tbCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCity.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCity.Location = new System.Drawing.Point(195, 197);
            this.tbCity.Margin = new System.Windows.Forms.Padding(2);
            this.tbCity.MaxLength = 20;
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(150, 24);
            this.tbCity.TabIndex = 7;
            this.tbCity.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            // 
            // dtpRegister
            // 
            this.dtpRegister.Location = new System.Drawing.Point(195, 112);
            this.dtpRegister.Name = "dtpRegister";
            this.dtpRegister.Size = new System.Drawing.Size(190, 24);
            this.dtpRegister.TabIndex = 3;
            this.dtpRegister.ValueChanged += new System.EventHandler(this.DtpRegister_ValueChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(385, 116);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "تاریخ ثبت:";
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
            this.btmCoSave.Size = new System.Drawing.Size(126, 35);
            this.btmCoSave.TabIndex = 14;
            this.btmCoSave.Text = "ذخیره";
            this.btmCoSave.UseVisualStyleBackColor = true;
            this.btmCoSave.Click += new System.EventHandler(this.BtmCoSave_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label7.Location = new System.Drawing.Point(596, 398);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "کد اقتصادی:";
            // 
            // tbTaxID
            // 
            this.tbTaxID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTaxID.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaxID.Location = new System.Drawing.Point(446, 394);
            this.tbTaxID.Margin = new System.Windows.Forms.Padding(2);
            this.tbTaxID.MaxLength = 20;
            this.tbTaxID.Name = "tbTaxID";
            this.tbTaxID.Size = new System.Drawing.Size(150, 24);
            this.tbTaxID.TabIndex = 12;
            this.tbTaxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTaxID.TextChanged += new System.EventHandler(this.TbTaxID_TextChanged);
            this.tbTaxID.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            this.tbTaxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetNumbericCharsTextBoxes);
            // 
            // tbCoID
            // 
            this.tbCoID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCoID.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCoID.Location = new System.Drawing.Point(195, 155);
            this.tbCoID.Margin = new System.Windows.Forms.Padding(2);
            this.tbCoID.MaxLength = 20;
            this.tbCoID.Name = "tbCoID";
            this.tbCoID.Size = new System.Drawing.Size(150, 24);
            this.tbCoID.TabIndex = 5;
            this.tbCoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbCoID.TextChanged += new System.EventHandler(this.TbRegisterID_TextChanged);
            this.tbCoID.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            this.tbCoID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetNumbericCharsTextBoxes);
            // 
            // tbFax
            // 
            this.tbFax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFax.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFax.Location = new System.Drawing.Point(195, 351);
            this.tbFax.Margin = new System.Windows.Forms.Padding(2);
            this.tbFax.MaxLength = 20;
            this.tbFax.Name = "tbFax";
            this.tbFax.Size = new System.Drawing.Size(150, 24);
            this.tbFax.TabIndex = 11;
            this.tbFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbFax.TextChanged += new System.EventHandler(this.TbFax_TextChanged);
            this.tbFax.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            this.tbFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetNumbericCharsTextBoxes);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label11.Location = new System.Drawing.Point(596, 201);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "استان:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label9.Location = new System.Drawing.Point(596, 158);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "شماره ثبت:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label4.Location = new System.Drawing.Point(596, 354);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "تلفن:";
            // 
            // tbProvince
            // 
            this.tbProvince.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbProvince.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProvince.Location = new System.Drawing.Point(446, 198);
            this.tbProvince.Margin = new System.Windows.Forms.Padding(2);
            this.tbProvince.MaxLength = 20;
            this.tbProvince.Name = "tbProvince";
            this.tbProvince.Size = new System.Drawing.Size(150, 24);
            this.tbProvince.TabIndex = 6;
            this.tbProvince.TextChanged += new System.EventHandler(this.TbRegisterNumber_TextChanged);
            this.tbProvince.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            // 
            // tbRegisterNumber
            // 
            this.tbRegisterNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRegisterNumber.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegisterNumber.Location = new System.Drawing.Point(446, 155);
            this.tbRegisterNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbRegisterNumber.MaxLength = 20;
            this.tbRegisterNumber.Name = "tbRegisterNumber";
            this.tbRegisterNumber.Size = new System.Drawing.Size(150, 24);
            this.tbRegisterNumber.TabIndex = 4;
            this.tbRegisterNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbRegisterNumber.TextChanged += new System.EventHandler(this.TbRegisterNumber_TextChanged);
            this.tbRegisterNumber.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            this.tbRegisterNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetNumbericCharsTextBoxes);
            // 
            // tbTell
            // 
            this.tbTell.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTell.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTell.Location = new System.Drawing.Point(446, 351);
            this.tbTell.Margin = new System.Windows.Forms.Padding(2);
            this.tbTell.MaxLength = 20;
            this.tbTell.Name = "tbTell";
            this.tbTell.Size = new System.Drawing.Size(150, 24);
            this.tbTell.TabIndex = 10;
            this.tbTell.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbTell.TextChanged += new System.EventHandler(this.TbTell_TextChanged);
            this.tbTell.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            this.tbTell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetNumbericCharsTextBoxes);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label3.Location = new System.Drawing.Point(596, 312);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "کدپستی:";
            // 
            // tbPostalCode
            // 
            this.tbPostalCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPostalCode.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostalCode.Location = new System.Drawing.Point(445, 308);
            this.tbPostalCode.Margin = new System.Windows.Forms.Padding(2);
            this.tbPostalCode.MaxLength = 20;
            this.tbPostalCode.Name = "tbPostalCode";
            this.tbPostalCode.Size = new System.Drawing.Size(150, 24);
            this.tbPostalCode.TabIndex = 9;
            this.tbPostalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPostalCode.TextChanged += new System.EventHandler(this.TbPostalCode_TextChanged);
            this.tbPostalCode.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            this.tbPostalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetNumbericCharsTextBoxes);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label2.Location = new System.Drawing.Point(596, 253);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "نشانی:";
            // 
            // tbAddress
            // 
            this.tbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAddress.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(195, 241);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(2);
            this.tbAddress.MaxLength = 200;
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(400, 48);
            this.tbAddress.TabIndex = 8;
            this.tbAddress.TextChanged += new System.EventHandler(this.TbAddress_TextChanged);
            this.tbAddress.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            // 
            // cbTypes
            // 
            this.cbTypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypes.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Items.AddRange(new object[] {
            "مسولیت محدود",
            "سهامی خاص",
            "سهامی عام"});
            this.cbTypes.Location = new System.Drawing.Point(475, 112);
            this.cbTypes.Margin = new System.Windows.Forms.Padding(2);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(120, 24);
            this.cbTypes.TabIndex = 2;
            this.cbTypes.SelectedIndexChanged += new System.EventHandler(this.CbTypes_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(596, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "نوع ثبت:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label1.Location = new System.Drawing.Point(596, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "نام:";
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Font = new System.Drawing.Font("Tahoma", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(195, 69);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.MaxLength = 50;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(400, 24);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.TbName_TextChanged);
            this.tbName.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label10.Location = new System.Drawing.Point(345, 158);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "شناسه:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label13.Location = new System.Drawing.Point(345, 399);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 17);
            this.label13.TabIndex = 37;
            this.label13.Text = "وب سایت:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label6.Location = new System.Drawing.Point(344, 354);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "فکس:";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.label14.Location = new System.Drawing.Point(143, 398);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label14.Size = new System.Drawing.Size(54, 17);
            this.label14.TabIndex = 39;
            this.label14.Text = "WWW.";
            // 
            // tabDepartments
            // 
            this.tabDepartments.BackColor = System.Drawing.SystemColors.Control;
            this.tabDepartments.Controls.Add(this.dgvDepartments);
            this.tabDepartments.Controls.Add(this.btmDepartmentsSave);
            this.tabDepartments.Location = new System.Drawing.Point(4, 25);
            this.tabDepartments.Name = "tabDepartments";
            this.tabDepartments.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepartments.Size = new System.Drawing.Size(813, 584);
            this.tabDepartments.TabIndex = 0;
            this.tabDepartments.Text = "واحدها";
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDepartments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.125F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepartments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.nvcName,
            this.bitSelect,
            this.bitIsActual,
            this.intNumber});
            this.dgvDepartments.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvDepartments.Location = new System.Drawing.Point(273, 63);
            this.dgvDepartments.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDepartments.RowTemplate.Height = 55;
            this.dgvDepartments.Size = new System.Drawing.Size(302, 403);
            this.dgvDepartments.TabIndex = 13;
            this.dgvDepartments.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDepartments_CellValueChanged);
            this.dgvDepartments.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvDepartments_RowsAdded);
            this.dgvDepartments.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DgvDepartments_RowsRemoved);
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
            this.btmDepartmentsSave.Click += new System.EventHandler(this.btmDepartmentsSave_Click);
            // 
            // tabCategories
            // 
            this.tabCategories.BackColor = System.Drawing.SystemColors.Control;
            this.tabCategories.Controls.Add(this.dgvCategories);
            this.tabCategories.Controls.Add(this.btmCategoriesSave);
            this.tabCategories.Location = new System.Drawing.Point(4, 25);
            this.tabCategories.Name = "tabCategories";
            this.tabCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategories.Size = new System.Drawing.Size(813, 584);
            this.tabCategories.TabIndex = 1;
            this.tabCategories.Text = "رسته‌ها";
            // 
            // dgvCategories
            // 
            this.dgvCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCategories.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10.125F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvCategories.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvCategories.Location = new System.Drawing.Point(273, 63);
            this.dgvCategories.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvCategories.RowTemplate.Height = 55;
            this.dgvCategories.Size = new System.Drawing.Size(302, 403);
            this.dgvCategories.TabIndex = 14;
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
            this.btmCategoriesSave.Click += new System.EventHandler(this.BtmCategoriesSave_Click);
            // 
            // intID
            // 
            this.intID.DataPropertyName = "intID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intID.DefaultCellStyle = dataGridViewCellStyle2;
            this.intID.HeaderText = "intID";
            this.intID.MinimumWidth = 10;
            this.intID.Name = "intID";
            this.intID.ToolTipText = "intID";
            this.intID.Visible = false;
            this.intID.Width = 62;
            // 
            // nvcName
            // 
            this.nvcName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nvcName.DataPropertyName = "nvcName";
            this.nvcName.HeaderText = "نام";
            this.nvcName.MinimumWidth = 10;
            this.nvcName.Name = "nvcName";
            this.nvcName.ToolTipText = "نام";
            // 
            // bitSelect
            // 
            this.bitSelect.DataPropertyName = "bitSelect";
            this.bitSelect.HeaderText = "bitSelect";
            this.bitSelect.MinimumWidth = 10;
            this.bitSelect.Name = "bitSelect";
            this.bitSelect.ToolTipText = "bitSelect";
            this.bitSelect.Visible = false;
            this.bitSelect.Width = 84;
            // 
            // bitIsActual
            // 
            this.bitIsActual.DataPropertyName = "bitIsActual";
            this.bitIsActual.HeaderText = "bitIsActual";
            this.bitIsActual.Name = "bitIsActual";
            this.bitIsActual.ToolTipText = "bitIsActual";
            this.bitIsActual.Visible = false;
            this.bitIsActual.Width = 95;
            // 
            // intNumber
            // 
            this.intNumber.DataPropertyName = "intNumber";
            this.intNumber.HeaderText = "intNumber";
            this.intNumber.Name = "intNumber";
            this.intNumber.ToolTipText = "intNumber";
            this.intNumber.Visible = false;
            this.intNumber.Width = 97;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "intID";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn1.HeaderText = "intID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ToolTipText = "intID";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 62;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nvcName";
            this.dataGridViewTextBoxColumn2.HeaderText = "نام";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ToolTipText = "نام";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "bitSelect";
            this.dataGridViewTextBoxColumn3.HeaderText = "bitSelect";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ToolTipText = "bitSelect";
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 84;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "bitIsActual";
            this.dataGridViewTextBoxColumn4.HeaderText = "bitIsActual";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ToolTipText = "bitIsActual";
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 95;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "intNumber";
            this.dataGridViewTextBoxColumn5.HeaderText = "intNumber";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ToolTipText = "intNumber";
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 97;
            // 
            // OfficePrefrences
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
            this.Name = "OfficePrefrences";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.tabCategories.ResumeLayout(false);
            this.tabCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.TabPage tabCo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbTypes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPostalCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btmCoSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTaxID;
        private System.Windows.Forms.DateTimePicker dtpRegister;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCoID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbRegisterNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbWebSite;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbProvince;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitIsActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn intNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}