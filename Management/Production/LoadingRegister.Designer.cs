namespace Baran.Ferroalloy.Management
{
    partial class LoadingRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labLoadingCount = new System.Windows.Forms.Label();
            this.labLadleLoadingCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLadleNumbers = new System.Windows.Forms.ComboBox();
            this.cbTapholeNumbers = new System.Windows.Forms.ComboBox();
            this.tbTapholePosition = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.butWeightRegister = new System.Windows.Forms.Button();
            this.labWeight = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labFillWeight = new System.Windows.Forms.Label();
            this.labEmptyWeight = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labLoadingDuration = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labStop = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.butStop = new System.Windows.Forms.Button();
            this.labStart = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.butStart = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.butTapholeClose = new System.Windows.Forms.Button();
            this.butRegister = new System.Windows.Forms.Button();
            this.butEmptyLadleRegister = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btmExit
            // 
            this.btmExit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btmExit.Location = new System.Drawing.Point(1209, 1487);
            this.btmExit.Margin = new System.Windows.Forms.Padding(0);
            this.btmExit.Name = "btmExit";
            this.btmExit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btmExit.Size = new System.Drawing.Size(256, 63);
            this.btmExit.TabIndex = 5;
            this.btmExit.Text = "خروج";
            this.btmExit.UseVisualStyleBackColor = true;
            this.btmExit.Click += new System.EventHandler(this.btmExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(796, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "بار:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Location = new System.Drawing.Point(283, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 51);
            this.label2.TabIndex = 7;
            this.label2.Text = "پاتیل:";
            // 
            // labLoadingCount
            // 
            this.labLoadingCount.AutoSize = true;
            this.labLoadingCount.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labLoadingCount.Location = new System.Drawing.Point(736, 63);
            this.labLoadingCount.Name = "labLoadingCount";
            this.labLoadingCount.Size = new System.Drawing.Size(54, 51);
            this.labLoadingCount.TabIndex = 8;
            this.labLoadingCount.Text = "00";
            // 
            // labLadleLoadingCount
            // 
            this.labLadleLoadingCount.AutoSize = true;
            this.labLadleLoadingCount.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labLadleLoadingCount.Location = new System.Drawing.Point(214, 63);
            this.labLadleLoadingCount.Name = "labLadleLoadingCount";
            this.labLadleLoadingCount.Size = new System.Drawing.Size(54, 51);
            this.labLadleLoadingCount.TabIndex = 9;
            this.labLadleLoadingCount.Text = "00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLadleNumbers);
            this.groupBox1.Controls.Add(this.cbTapholeNumbers);
            this.groupBox1.Controls.Add(this.tbTapholePosition);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(689, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1365, 154);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تنظیمات";
            // 
            // cbLadleNumbers
            // 
            this.cbLadleNumbers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLadleNumbers.FormattingEnabled = true;
            this.cbLadleNumbers.Location = new System.Drawing.Point(1039, 69);
            this.cbLadleNumbers.Name = "cbLadleNumbers";
            this.cbLadleNumbers.Size = new System.Drawing.Size(100, 40);
            this.cbLadleNumbers.TabIndex = 10;
            this.cbLadleNumbers.SelectedIndexChanged += new System.EventHandler(this.cbLadleNumbers_SelectedIndexChanged);
            // 
            // cbTapholeNumbers
            // 
            this.cbTapholeNumbers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTapholeNumbers.FormattingEnabled = true;
            this.cbTapholeNumbers.Location = new System.Drawing.Point(587, 69);
            this.cbTapholeNumbers.Name = "cbTapholeNumbers";
            this.cbTapholeNumbers.Size = new System.Drawing.Size(100, 40);
            this.cbTapholeNumbers.TabIndex = 10;
            this.cbTapholeNumbers.SelectedIndexChanged += new System.EventHandler(this.cbTapholeNumbers_SelectedIndexChanged);
            // 
            // tbTapholePosition
            // 
            this.tbTapholePosition.Location = new System.Drawing.Point(103, 70);
            this.tbTapholePosition.Name = "tbTapholePosition";
            this.tbTapholePosition.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbTapholePosition.Size = new System.Drawing.Size(100, 39);
            this.tbTapholePosition.TabIndex = 9;
            this.tbTapholePosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTapholePosition.TextChanged += new System.EventHandler(this.tbTapholePosition_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(211, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "شماره دهانه:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(691, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "شماره دهانه:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(1142, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "شماره پاتیل:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.labLoadingCount);
            this.groupBox2.Controls.Add(this.labLadleLoadingCount);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(835, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1073, 158);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "شمارنده";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.butWeightRegister);
            this.groupBox3.Controls.Add(this.labWeight);
            this.groupBox3.Location = new System.Drawing.Point(875, 472);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 525);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "باسکول";
            // 
            // butWeightRegister
            // 
            this.butWeightRegister.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.butWeightRegister.Location = new System.Drawing.Point(86, 423);
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
            this.labWeight.Location = new System.Drawing.Point(142, 161);
            this.labWeight.Name = "labWeight";
            this.labWeight.Size = new System.Drawing.Size(153, 72);
            this.labWeight.TabIndex = 8;
            this.labWeight.Text = "12350";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.butEmptyLadleRegister);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.labFillWeight);
            this.groupBox4.Controls.Add(this.labEmptyWeight);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(1424, 472);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(422, 382);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "وزن پاتیل";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(328, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 37);
            this.label7.TabIndex = 7;
            this.label7.Text = "پر:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.Location = new System.Drawing.Point(42, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 37);
            this.label10.TabIndex = 7;
            this.label10.Text = "کیلوگرم";
            // 
            // labFillWeight
            // 
            this.labFillWeight.AutoSize = true;
            this.labFillWeight.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labFillWeight.Location = new System.Drawing.Point(185, 169);
            this.labFillWeight.Name = "labFillWeight";
            this.labFillWeight.Size = new System.Drawing.Size(79, 37);
            this.labFillWeight.TabIndex = 7;
            this.labFillWeight.Text = "12350";
            // 
            // labEmptyWeight
            // 
            this.labEmptyWeight.AutoSize = true;
            this.labEmptyWeight.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labEmptyWeight.Location = new System.Drawing.Point(185, 92);
            this.labEmptyWeight.Name = "labEmptyWeight";
            this.labEmptyWeight.Size = new System.Drawing.Size(74, 37);
            this.labEmptyWeight.TabIndex = 7;
            this.labEmptyWeight.Text = "8350";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.Location = new System.Drawing.Point(42, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 37);
            this.label9.TabIndex = 7;
            this.label9.Text = "کیلوگرم";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(309, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 37);
            this.label6.TabIndex = 7;
            this.label6.Text = "خالی:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labLoadingDuration);
            this.groupBox5.Location = new System.Drawing.Point(1424, 860);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(422, 138);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "مدت زمان";
            // 
            // labLoadingDuration
            // 
            this.labLoadingDuration.AutoSize = true;
            this.labLoadingDuration.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.labLoadingDuration.Location = new System.Drawing.Point(125, 38);
            this.labLoadingDuration.Name = "labLoadingDuration";
            this.labLoadingDuration.Size = new System.Drawing.Size(142, 72);
            this.labLoadingDuration.TabIndex = 15;
            this.labLoadingDuration.Text = "12:35";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labStop);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.butStop);
            this.groupBox6.Controls.Add(this.labStart);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.butStart);
            this.groupBox6.Location = new System.Drawing.Point(714, 1018);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1314, 205);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "زمان";
            // 
            // labStop
            // 
            this.labStop.AutoSize = true;
            this.labStop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labStop.Location = new System.Drawing.Point(239, 54);
            this.labStop.Name = "labStop";
            this.labStop.Size = new System.Drawing.Size(69, 37);
            this.labStop.TabIndex = 19;
            this.labStop.Text = "10:22";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label17.Location = new System.Drawing.Point(327, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 37);
            this.label17.TabIndex = 18;
            this.label17.Text = "شروع:";
            // 
            // butStop
            // 
            this.butStop.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.butStop.Location = new System.Drawing.Point(199, 112);
            this.butStop.Margin = new System.Windows.Forms.Padding(0);
            this.butStop.Name = "butStop";
            this.butStop.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.butStop.Size = new System.Drawing.Size(256, 63);
            this.butStop.TabIndex = 17;
            this.butStop.Text = "پایان";
            this.butStop.UseVisualStyleBackColor = true;
            this.butStop.Click += new System.EventHandler(this.butStop_Click);
            // 
            // labStart
            // 
            this.labStart.AutoSize = true;
            this.labStart.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labStart.Location = new System.Drawing.Point(956, 54);
            this.labStart.Name = "labStart";
            this.labStart.Size = new System.Drawing.Size(69, 37);
            this.labStart.TabIndex = 16;
            this.labStart.Text = "10:22";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label14.Location = new System.Drawing.Point(1044, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 37);
            this.label14.TabIndex = 15;
            this.label14.Text = "شروع:";
            // 
            // butStart
            // 
            this.butStart.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.butStart.Location = new System.Drawing.Point(905, 112);
            this.butStart.Margin = new System.Windows.Forms.Padding(0);
            this.butStart.Name = "butStart";
            this.butStart.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.butStart.Size = new System.Drawing.Size(256, 63);
            this.butStart.TabIndex = 14;
            this.butStart.Text = "شروع";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.butTapholeClose);
            this.groupBox7.Controls.Add(this.butRegister);
            this.groupBox7.Location = new System.Drawing.Point(787, 1246);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1177, 147);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "فرایند نهایی";
            // 
            // butTapholeClose
            // 
            this.butTapholeClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.butTapholeClose.Location = new System.Drawing.Point(192, 51);
            this.butTapholeClose.Margin = new System.Windows.Forms.Padding(0);
            this.butTapholeClose.Name = "butTapholeClose";
            this.butTapholeClose.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.butTapholeClose.Size = new System.Drawing.Size(256, 63);
            this.butTapholeClose.TabIndex = 18;
            this.butTapholeClose.Text = "بستن دهانه";
            this.butTapholeClose.UseVisualStyleBackColor = true;
            // 
            // butRegister
            // 
            this.butRegister.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.butRegister.Location = new System.Drawing.Point(758, 51);
            this.butRegister.Margin = new System.Windows.Forms.Padding(0);
            this.butRegister.Name = "butRegister";
            this.butRegister.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.butRegister.Size = new System.Drawing.Size(256, 63);
            this.butRegister.TabIndex = 17;
            this.butRegister.Text = "ثبت";
            this.butRegister.UseVisualStyleBackColor = true;
            this.butRegister.Click += new System.EventHandler(this.butRegister_Click);
            // 
            // butEmptyLadleRegister
            // 
            this.butEmptyLadleRegister.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.butEmptyLadleRegister.Location = new System.Drawing.Point(74, 283);
            this.butEmptyLadleRegister.Margin = new System.Windows.Forms.Padding(0);
            this.butEmptyLadleRegister.Name = "butEmptyLadleRegister";
            this.butEmptyLadleRegister.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.butEmptyLadleRegister.Size = new System.Drawing.Size(256, 63);
            this.butEmptyLadleRegister.TabIndex = 18;
            this.butEmptyLadleRegister.Text = "ثبت پاتیل خالی";
            this.butEmptyLadleRegister.UseVisualStyleBackColor = true;
            this.butEmptyLadleRegister.Click += new System.EventHandler(this.butEmptyLadleRegister_Click);
            // 
            // LoadingRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2674, 1629);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btmExit);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingRegister";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "LoadingRegister";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoadingRegister_FormClosing);
            this.Load += new System.EventHandler(this.LoadingRegister_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labLoadingCount;
        private System.Windows.Forms.Label labLadleLoadingCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbLadleNumbers;
        private System.Windows.Forms.ComboBox cbTapholeNumbers;
        private System.Windows.Forms.TextBox tbTapholePosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button butWeightRegister;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labWeight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labFillWeight;
        private System.Windows.Forms.Label labEmptyWeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labLoadingDuration;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label labStop;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button butStop;
        private System.Windows.Forms.Label labStart;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button butTapholeClose;
        private System.Windows.Forms.Button butRegister;
        private System.Windows.Forms.Button butEmptyLadleRegister;
    }
}