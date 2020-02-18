namespace Baran.Ferroalloy.Management.Technical
{
    partial class Stores
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
            this.btmCancel = new System.Windows.Forms.Button();
            this.btmOK = new System.Windows.Forms.Button();
            this.dgvStores = new System.Windows.Forms.DataGridView();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStores)).BeginInit();
            this.SuspendLayout();
            // 
            // btmCancel
            // 
            this.btmCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btmCancel.Location = new System.Drawing.Point(296, 468);
            this.btmCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btmCancel.Name = "btmCancel";
            this.btmCancel.Size = new System.Drawing.Size(125, 33);
            this.btmCancel.TabIndex = 9;
            this.btmCancel.Text = "رد";
            this.btmCancel.UseVisualStyleBackColor = true;
            this.btmCancel.Click += new System.EventHandler(this.BtmCancel_Click);
            // 
            // btmOK
            // 
            this.btmOK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btmOK.Location = new System.Drawing.Point(141, 468);
            this.btmOK.Margin = new System.Windows.Forms.Padding(4);
            this.btmOK.Name = "btmOK";
            this.btmOK.Size = new System.Drawing.Size(125, 33);
            this.btmOK.TabIndex = 8;
            this.btmOK.Text = "تایید";
            this.btmOK.UseVisualStyleBackColor = true;
            this.btmOK.Click += new System.EventHandler(this.BtmOK_Click);
            // 
            // dgvStores
            // 
            this.dgvStores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.nvcName,
            this.intNumber});
            this.dgvStores.Location = new System.Drawing.Point(141, 62);
            this.dgvStores.Name = "dgvStores";
            this.dgvStores.Size = new System.Drawing.Size(280, 387);
            this.dgvStores.TabIndex = 10;
            this.dgvStores.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStores_CellValueChanged);
            this.dgvStores.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DgvStores_UserDeletingRow);
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
            // 
            // Stores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(551, 544);
            this.Controls.Add(this.dgvStores);
            this.Controls.Add(this.btmCancel);
            this.Controls.Add(this.btmOK);
            this.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Stores";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "انبارها";
            this.Load += new System.EventHandler(this.Stores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmCancel;
        private System.Windows.Forms.Button btmOK;
        private System.Windows.Forms.DataGridView dgvStores;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn intNumber;
    }
}