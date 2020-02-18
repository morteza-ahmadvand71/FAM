namespace Baran.Ferroalloy.Management.Maintenance
{
    partial class FrmNames
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
            this.dgvNames = new System.Windows.Forms.DataGridView();
            this.btmCancel = new System.Windows.Forms.Button();
            this.btmOK = new System.Windows.Forms.Button();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNames)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNames
            // 
            this.dgvNames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNames.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.nvcName,
            this.intNumber});
            this.dgvNames.Location = new System.Drawing.Point(135, 53);
            this.dgvNames.Name = "dgvNames";
            this.dgvNames.Size = new System.Drawing.Size(280, 387);
            this.dgvNames.TabIndex = 13;
            this.dgvNames.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvNames_CellValueChanged);
            // 
            // btmCancel
            // 
            this.btmCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btmCancel.Location = new System.Drawing.Point(290, 459);
            this.btmCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btmCancel.Name = "btmCancel";
            this.btmCancel.Size = new System.Drawing.Size(125, 33);
            this.btmCancel.TabIndex = 12;
            this.btmCancel.Text = "رد";
            this.btmCancel.UseVisualStyleBackColor = true;
            // 
            // btmOK
            // 
            this.btmOK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btmOK.Location = new System.Drawing.Point(135, 459);
            this.btmOK.Margin = new System.Windows.Forms.Padding(4);
            this.btmOK.Name = "btmOK";
            this.btmOK.Size = new System.Drawing.Size(125, 33);
            this.btmOK.TabIndex = 11;
            this.btmOK.Text = "تایید";
            this.btmOK.UseVisualStyleBackColor = true;
            // 
            // intID
            // 
            this.intID.DataPropertyName = "intID";
            this.intID.HeaderText = "intID";
            this.intID.Name = "intID";
            this.intID.Visible = false;
            // 
            // nvcName
            // 
            this.nvcName.DataPropertyName = "nvcName";
            this.nvcName.HeaderText = "نام";
            this.nvcName.Name = "nvcName";
            // 
            // intNumber
            // 
            this.intNumber.DataPropertyName = "intNumber";
            this.intNumber.HeaderText = "کد";
            this.intNumber.Name = "intNumber";
            this.intNumber.Visible = false;
            // 
            // FrmNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(551, 544);
            this.Controls.Add(this.dgvNames);
            this.Controls.Add(this.btmCancel);
            this.Controls.Add(this.btmOK);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "FrmNames";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "نام کالاها";
            this.Load += new System.EventHandler(this.FrmNames_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNames;
        private System.Windows.Forms.Button btmCancel;
        private System.Windows.Forms.Button btmOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn intNumber;
    }
}