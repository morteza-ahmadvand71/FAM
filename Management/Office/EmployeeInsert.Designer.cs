﻿namespace Baran.Ferroalloy.Management
{
    partial class EmployeeInsert
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
            this.tbNationalID = new System.Windows.Forms.TextBox();
            this.tbCoID = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btmOK = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btmCancel = new System.Windows.Forms.Button();
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ttEmployee = new System.Windows.Forms.ToolTip(this.components);
            this.cbSubDepartment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPosts = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbEmploymentTypes = new System.Windows.Forms.ComboBox();
            this.tbShift = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpBrightDate = new System.Windows.Forms.DateTimePicker();
            this.tbFatherName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbEducationLevels = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbLocationProvince = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbLocationAddress = new System.Windows.Forms.TextBox();
            this.tbLocationCity = new System.Windows.Forms.TextBox();
            this.tbLocationVilage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbNationalID
            // 
            this.tbNationalID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNationalID.Font = new System.Drawing.Font("B Yekan", 10F);
            this.tbNationalID.Location = new System.Drawing.Point(912, 43);
            this.tbNationalID.Margin = new System.Windows.Forms.Padding(4);
            this.tbNationalID.MaxLength = 10;
            this.tbNationalID.Name = "tbNationalID";
            this.tbNationalID.Size = new System.Drawing.Size(120, 28);
            this.tbNationalID.TabIndex = 4;
            this.tbNationalID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbNationalID.TextChanged += new System.EventHandler(this.TbNationalID_TextChanged);
            this.tbNationalID.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            this.tbNationalID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetNumbericTextButtoms);
            // 
            // tbCoID
            // 
            this.tbCoID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCoID.Font = new System.Drawing.Font("B Yekan", 10F);
            this.tbCoID.Location = new System.Drawing.Point(159, 43);
            this.tbCoID.Margin = new System.Windows.Forms.Padding(4);
            this.tbCoID.MaxLength = 3;
            this.tbCoID.Name = "tbCoID";
            this.tbCoID.Size = new System.Drawing.Size(80, 28);
            this.tbCoID.TabIndex = 1;
            this.tbCoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCoID.TextChanged += new System.EventHandler(this.TbCoID_TextChanged);
            this.tbCoID.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            this.tbCoID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetNumbericTextButtoms);
            // 
            // tbLastName
            // 
            this.tbLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLastName.Font = new System.Drawing.Font("B Yekan", 10F);
            this.tbLastName.Location = new System.Drawing.Point(638, 43);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbLastName.MaxLength = 20;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(150, 28);
            this.tbLastName.TabIndex = 3;
            this.tbLastName.TextChanged += new System.EventHandler(this.TbLastName_TextChanged);
            this.tbLastName.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label4.Location = new System.Drawing.Point(864, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "کد ملی:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label3.Location = new System.Drawing.Point(91, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "کد پرسنلی:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label2.Location = new System.Drawing.Point(562, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "نام خانوادگی:";
            // 
            // btmOK
            // 
            this.btmOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btmOK.Enabled = false;
            this.btmOK.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btmOK.Location = new System.Drawing.Point(432, 331);
            this.btmOK.Margin = new System.Windows.Forms.Padding(4);
            this.btmOK.Name = "btmOK";
            this.btmOK.Size = new System.Drawing.Size(125, 35);
            this.btmOK.TabIndex = 14;
            this.btmOK.Text = "تایید";
            this.ttEmployee.SetToolTip(this.btmOK, "تایید F6");
            this.btmOK.UseVisualStyleBackColor = true;
            this.btmOK.Click += new System.EventHandler(this.btmOK_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFirstName.Font = new System.Drawing.Font("B Yekan", 10F);
            this.tbFirstName.Location = new System.Drawing.Point(336, 43);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbFirstName.MaxLength = 20;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(150, 28);
            this.tbFirstName.TabIndex = 2;
            this.tbFirstName.TextChanged += new System.EventHandler(this.TbFirstName_TextChanged);
            this.tbFirstName.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label1.Location = new System.Drawing.Point(309, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "نام:";
            // 
            // btmCancel
            // 
            this.btmCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btmCancel.Font = new System.Drawing.Font("B Yekan", 10F);
            this.btmCancel.Location = new System.Drawing.Point(581, 331);
            this.btmCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btmCancel.Name = "btmCancel";
            this.btmCancel.Size = new System.Drawing.Size(125, 35);
            this.btmCancel.TabIndex = 15;
            this.btmCancel.Text = "رد";
            this.ttEmployee.SetToolTip(this.btmCancel, "رد F5");
            this.btmCancel.UseVisualStyleBackColor = true;
            this.btmCancel.Click += new System.EventHandler(this.btmCancel_Click);
            // 
            // cbDepartments
            // 
            this.cbDepartments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartments.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.Location = new System.Drawing.Point(129, 145);
            this.cbDepartments.Margin = new System.Windows.Forms.Padding(4);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(150, 28);
            this.cbDepartments.TabIndex = 5;
            this.cbDepartments.SelectedIndexChanged += new System.EventHandler(this.CbDepartments_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label6.Location = new System.Drawing.Point(91, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "واحد:";
            // 
            // cbSubDepartment
            // 
            this.cbSubDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSubDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubDepartment.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbSubDepartment.FormattingEnabled = true;
            this.cbSubDepartment.Location = new System.Drawing.Point(367, 145);
            this.cbSubDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.cbSubDepartment.Name = "cbSubDepartment";
            this.cbSubDepartment.Size = new System.Drawing.Size(150, 28);
            this.cbSubDepartment.TabIndex = 6;
            this.cbSubDepartment.SelectedIndexChanged += new System.EventHandler(this.CbSubDepartment_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label5.Location = new System.Drawing.Point(327, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "بخش:";
            // 
            // cbPosts
            // 
            this.cbPosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPosts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosts.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbPosts.FormattingEnabled = true;
            this.cbPosts.Location = new System.Drawing.Point(608, 145);
            this.cbPosts.Margin = new System.Windows.Forms.Padding(4);
            this.cbPosts.Name = "cbPosts";
            this.cbPosts.Size = new System.Drawing.Size(150, 28);
            this.cbPosts.TabIndex = 7;
            this.cbPosts.SelectedIndexChanged += new System.EventHandler(this.CbPosts_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label7.Location = new System.Drawing.Point(567, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "سمت:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label8.Location = new System.Drawing.Point(804, 149);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "نوع استخدام:";
            // 
            // cbEmploymentTypes
            // 
            this.cbEmploymentTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEmploymentTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmploymentTypes.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbEmploymentTypes.FormattingEnabled = true;
            this.cbEmploymentTypes.Location = new System.Drawing.Point(882, 145);
            this.cbEmploymentTypes.Margin = new System.Windows.Forms.Padding(4);
            this.cbEmploymentTypes.Name = "cbEmploymentTypes";
            this.cbEmploymentTypes.Size = new System.Drawing.Size(150, 28);
            this.cbEmploymentTypes.TabIndex = 8;
            this.cbEmploymentTypes.SelectedIndexChanged += new System.EventHandler(this.CbEmploymentTypes_SelectedIndexChanged);
            // 
            // tbShift
            // 
            this.tbShift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbShift.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tbShift.Font = new System.Drawing.Font("B Yekan", 10F);
            this.tbShift.Location = new System.Drawing.Point(137, 94);
            this.tbShift.Margin = new System.Windows.Forms.Padding(4);
            this.tbShift.MaxLength = 3;
            this.tbShift.Name = "tbShift";
            this.tbShift.Size = new System.Drawing.Size(80, 28);
            this.tbShift.TabIndex = 9;
            this.tbShift.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbShift.TextChanged += new System.EventHandler(this.TbShift_TextChanged);
            this.tbShift.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            this.tbShift.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetNumbericTextButtoms);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label9.Location = new System.Drawing.Point(91, 98);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "شیفت:";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPhoneNumber.Font = new System.Drawing.Font("B Yekan", 10F);
            this.tbPhoneNumber.Location = new System.Drawing.Point(337, 94);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbPhoneNumber.MaxLength = 20;
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(150, 28);
            this.tbPhoneNumber.TabIndex = 10;
            this.tbPhoneNumber.TextChanged += new System.EventHandler(this.TbPhoneNumber_TextChanged);
            this.tbPhoneNumber.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            this.tbPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SetNumbericTextButtoms);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label10.Location = new System.Drawing.Point(267, 98);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 21);
            this.label10.TabIndex = 23;
            this.label10.Text = "تلفن همراه:";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label11.Location = new System.Drawing.Point(766, 97);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 21);
            this.label11.TabIndex = 24;
            this.label11.Text = "تاریخ تولد:";
            // 
            // dtpBrightDate
            // 
            this.dtpBrightDate.Location = new System.Drawing.Point(832, 93);
            this.dtpBrightDate.Name = "dtpBrightDate";
            this.dtpBrightDate.Size = new System.Drawing.Size(200, 28);
            this.dtpBrightDate.TabIndex = 11;
            this.dtpBrightDate.ValueChanged += new System.EventHandler(this.DtpBrightDate_ValueChanged);
            // 
            // tbFatherName
            // 
            this.tbFatherName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFatherName.Font = new System.Drawing.Font("B Yekan", 10F);
            this.tbFatherName.Location = new System.Drawing.Point(581, 95);
            this.tbFatherName.Margin = new System.Windows.Forms.Padding(4);
            this.tbFatherName.MaxLength = 20;
            this.tbFatherName.Name = "tbFatherName";
            this.tbFatherName.Size = new System.Drawing.Size(150, 28);
            this.tbFatherName.TabIndex = 12;
            this.tbFatherName.TextChanged += new System.EventHandler(this.TbFatherName_TextChanged);
            this.tbFatherName.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label12.Location = new System.Drawing.Point(531, 99);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 21);
            this.label12.TabIndex = 27;
            this.label12.Text = "نام پدر:";
            // 
            // cbEducationLevels
            // 
            this.cbEducationLevels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEducationLevels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEducationLevels.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbEducationLevels.FormattingEnabled = true;
            this.cbEducationLevels.Location = new System.Drawing.Point(171, 196);
            this.cbEducationLevels.Margin = new System.Windows.Forms.Padding(4);
            this.cbEducationLevels.Name = "cbEducationLevels";
            this.cbEducationLevels.Size = new System.Drawing.Size(150, 28);
            this.cbEducationLevels.TabIndex = 13;
            this.cbEducationLevels.SelectedIndexChanged += new System.EventHandler(this.CbEducationLevels_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label13.Location = new System.Drawing.Point(91, 200);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 21);
            this.label13.TabIndex = 29;
            this.label13.Text = "سطح تحصیلی:";
            // 
            // cbLocationProvince
            // 
            this.cbLocationProvince.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLocationProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocationProvince.Font = new System.Drawing.Font("B Yekan", 10F);
            this.cbLocationProvince.FormattingEnabled = true;
            this.cbLocationProvince.Location = new System.Drawing.Point(397, 196);
            this.cbLocationProvince.Margin = new System.Windows.Forms.Padding(4);
            this.cbLocationProvince.Name = "cbLocationProvince";
            this.cbLocationProvince.Size = new System.Drawing.Size(150, 28);
            this.cbLocationProvince.TabIndex = 30;
            this.cbLocationProvince.SelectedIndexChanged += new System.EventHandler(this.CbLocationProvince_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label14.Location = new System.Drawing.Point(354, 200);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 21);
            this.label14.TabIndex = 31;
            this.label14.Text = "استان:";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label15.Location = new System.Drawing.Point(579, 200);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 21);
            this.label15.TabIndex = 33;
            this.label15.Text = "شهرستان:";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label16.Location = new System.Drawing.Point(813, 200);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 21);
            this.label16.TabIndex = 35;
            this.label16.Text = "شهر/روستا:";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label17.Location = new System.Drawing.Point(276, 251);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 21);
            this.label17.TabIndex = 36;
            this.label17.Text = "نشانی:";
            // 
            // tbLocationAddress
            // 
            this.tbLocationAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLocationAddress.Font = new System.Drawing.Font("B Yekan", 10F);
            this.tbLocationAddress.Location = new System.Drawing.Point(318, 248);
            this.tbLocationAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbLocationAddress.MaxLength = 20;
            this.tbLocationAddress.Multiline = true;
            this.tbLocationAddress.Name = "tbLocationAddress";
            this.tbLocationAddress.Size = new System.Drawing.Size(500, 40);
            this.tbLocationAddress.TabIndex = 37;
            this.tbLocationAddress.TextChanged += new System.EventHandler(this.TbLocationAddress_TextChanged);
            this.tbLocationAddress.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            // 
            // tbLocationCity
            // 
            this.tbLocationCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLocationCity.Font = new System.Drawing.Font("B Yekan", 10F);
            this.tbLocationCity.Location = new System.Drawing.Point(639, 196);
            this.tbLocationCity.Margin = new System.Windows.Forms.Padding(4);
            this.tbLocationCity.MaxLength = 20;
            this.tbLocationCity.Name = "tbLocationCity";
            this.tbLocationCity.Size = new System.Drawing.Size(150, 28);
            this.tbLocationCity.TabIndex = 38;
            this.tbLocationCity.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            // 
            // tbLocationVilage
            // 
            this.tbLocationVilage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLocationVilage.Font = new System.Drawing.Font("B Yekan", 10F);
            this.tbLocationVilage.Location = new System.Drawing.Point(882, 197);
            this.tbLocationVilage.Margin = new System.Windows.Forms.Padding(4);
            this.tbLocationVilage.MaxLength = 20;
            this.tbLocationVilage.Name = "tbLocationVilage";
            this.tbLocationVilage.Size = new System.Drawing.Size(150, 28);
            this.tbLocationVilage.TabIndex = 39;
            this.tbLocationVilage.Enter += new System.EventHandler(this.SetFarsiLanguageTextBoxes);
            // 
            // EmployeeInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1140, 421);
            this.Controls.Add(this.tbLocationVilage);
            this.Controls.Add(this.tbLocationCity);
            this.Controls.Add(this.tbLocationAddress);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbLocationProvince);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbEducationLevels);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbFatherName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpBrightDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbShift);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbPosts);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbSubDepartment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.cbEmploymentTypes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbDepartments);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNationalID);
            this.Controls.Add(this.tbCoID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btmCancel);
            this.Controls.Add(this.btmOK);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("B Yekan", 10F);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeInsert";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ورود کارمند جدید";
            this.Load += new System.EventHandler(this.EmployeeUpdate_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmployeeInsert_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNationalID;
        private System.Windows.Forms.TextBox tbCoID;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btmOK;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btmCancel;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip ttEmployee;
        private System.Windows.Forms.ComboBox cbSubDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPosts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbEmploymentTypes;
        private System.Windows.Forms.TextBox tbShift;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpBrightDate;
        private System.Windows.Forms.TextBox tbFatherName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbEducationLevels;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbLocationProvince;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbLocationAddress;
        private System.Windows.Forms.TextBox tbLocationCity;
        private System.Windows.Forms.TextBox tbLocationVilage;
    }
}