namespace Baran.Ferroalloy.Management
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btmOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btmExit = new System.Windows.Forms.Button();
            this.CbSaveUserName = new System.Windows.Forms.CheckBox();
            this.labMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label1.Location = new System.Drawing.Point(148, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربری:";
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsername.Font = new System.Drawing.Font("B Yekan", 10F);
            this.tbUsername.Location = new System.Drawing.Point(217, 58);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsername.MaxLength = 20;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbUsername.Size = new System.Drawing.Size(127, 28);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.Enter += new System.EventHandler(this.TbUsername_Enter);
            // 
            // btmOk
            // 
            this.btmOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmOk.AutoSize = true;
            this.btmOk.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btmOk.Location = new System.Drawing.Point(115, 184);
            this.btmOk.Margin = new System.Windows.Forms.Padding(0);
            this.btmOk.Name = "btmOk";
            this.btmOk.Size = new System.Drawing.Size(125, 35);
            this.btmOk.TabIndex = 3;
            this.btmOk.Text = "تایید";
            this.btmOk.UseVisualStyleBackColor = true;
            this.btmOk.Click += new System.EventHandler(this.btmOk_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Yekan", 10F);
            this.label2.Location = new System.Drawing.Point(148, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "گذر واژه:";
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Font = new System.Drawing.Font("B Yekan", 10F);
            this.tbPassword.Location = new System.Drawing.Point(217, 91);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.MaxLength = 20;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPassword.Size = new System.Drawing.Size(127, 28);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.Enter += new System.EventHandler(this.TbPassword_Enter);
            // 
            // btmExit
            // 
            this.btmExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmExit.AutoSize = true;
            this.btmExit.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btmExit.Location = new System.Drawing.Point(260, 184);
            this.btmExit.Margin = new System.Windows.Forms.Padding(0);
            this.btmExit.Name = "btmExit";
            this.btmExit.Size = new System.Drawing.Size(125, 35);
            this.btmExit.TabIndex = 4;
            this.btmExit.Text = "رد";
            this.btmExit.UseVisualStyleBackColor = true;
            this.btmExit.Click += new System.EventHandler(this.btmExit_Click);
            // 
            // CbSaveUserName
            // 
            this.CbSaveUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbSaveUserName.AutoSize = true;
            this.CbSaveUserName.Font = new System.Drawing.Font("B Yekan", 10F);
            this.CbSaveUserName.Location = new System.Drawing.Point(71, 119);
            this.CbSaveUserName.Margin = new System.Windows.Forms.Padding(2);
            this.CbSaveUserName.Name = "CbSaveUserName";
            this.CbSaveUserName.Size = new System.Drawing.Size(144, 25);
            this.CbSaveUserName.TabIndex = 5;
            this.CbSaveUserName.Text = "نام کاربری ذخیره گردد";
            this.CbSaveUserName.UseVisualStyleBackColor = true;
            this.CbSaveUserName.CheckedChanged += new System.EventHandler(this.CbSaveUserName_CheckedChanged);
            // 
            // labMessage
            // 
            this.labMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labMessage.AutoSize = true;
            this.labMessage.Font = new System.Drawing.Font("B Yekan", 10F);
            this.labMessage.ForeColor = System.Drawing.Color.Blue;
            this.labMessage.Location = new System.Drawing.Point(68, 146);
            this.labMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labMessage.Name = "labMessage";
            this.labMessage.Size = new System.Drawing.Size(186, 21);
            this.labMessage.TabIndex = 4;
            this.labMessage.Text = "نام کاربری و گذرواژه را وارد کنید.";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.CbSaveUserName);
            this.Controls.Add(this.labMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btmExit);
            this.Controls.Add(this.btmOk);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Yekan", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود / خروج";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btmOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btmExit;
        private System.Windows.Forms.CheckBox CbSaveUserName;
        private System.Windows.Forms.Label labMessage;
    }
}