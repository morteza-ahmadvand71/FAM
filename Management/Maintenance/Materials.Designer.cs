namespace Baran.Ferroalloy.Management.Technical
{
    partial class Materials
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btmCancel = new System.Windows.Forms.Button();
            this.btmOK = new System.Windows.Forms.Button();
            this.dgvMaterials = new System.Windows.Forms.DataGridView();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // btmCancel
            // 
            this.btmCancel.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmCancel.Location = new System.Drawing.Point(292, 468);
            this.btmCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btmCancel.Name = "btmCancel";
            this.btmCancel.Size = new System.Drawing.Size(125, 35);
            this.btmCancel.TabIndex = 9;
            this.btmCancel.Text = "رد";
            this.btmCancel.UseVisualStyleBackColor = true;
            this.btmCancel.Click += new System.EventHandler(this.BtmCancel_Click);
            // 
            // btmOK
            // 
            this.btmOK.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.btmOK.Location = new System.Drawing.Point(141, 468);
            this.btmOK.Margin = new System.Windows.Forms.Padding(4);
            this.btmOK.Name = "btmOK";
            this.btmOK.Size = new System.Drawing.Size(125, 35);
            this.btmOK.TabIndex = 8;
            this.btmOK.Text = "تایید";
            this.btmOK.UseVisualStyleBackColor = true;
            this.btmOK.Click += new System.EventHandler(this.BtmOK_Click);
            // 
            // dgvMaterials
            // 
            this.dgvMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMaterials.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.125F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaterials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.nvcStore,
            this.nvcSection,
            this.nvcName,
            this.nvcCode});
            this.dgvMaterials.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvMaterials.Location = new System.Drawing.Point(129, 40);
            this.dgvMaterials.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMaterials.Name = "dgvMaterials";
            this.dgvMaterials.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvMaterials.RowTemplate.Height = 55;
            this.dgvMaterials.Size = new System.Drawing.Size(302, 403);
            this.dgvMaterials.TabIndex = 10;
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
            // nvcStore
            // 
            this.nvcStore.DataPropertyName = "nvcStore";
            this.nvcStore.HeaderText = "انبار";
            this.nvcStore.MinimumWidth = 10;
            this.nvcStore.Name = "nvcStore";
            this.nvcStore.Visible = false;
            this.nvcStore.Width = 54;
            // 
            // nvcSection
            // 
            this.nvcSection.DataPropertyName = "nvcSection";
            this.nvcSection.HeaderText = "بخش";
            this.nvcSection.MinimumWidth = 10;
            this.nvcSection.Name = "nvcSection";
            this.nvcSection.ToolTipText = "بخش";
            this.nvcSection.Visible = false;
            this.nvcSection.Width = 65;
            // 
            // nvcName
            // 
            this.nvcName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nvcName.DataPropertyName = "nvcName";
            this.nvcName.HeaderText = "نام";
            this.nvcName.MinimumWidth = 10;
            this.nvcName.Name = "nvcName";
            this.nvcName.ToolTipText = "نام";
            this.nvcName.Width = 150;
            // 
            // nvcCode
            // 
            this.nvcCode.DataPropertyName = "nvcCode";
            this.nvcCode.HeaderText = "کد";
            this.nvcCode.MinimumWidth = 10;
            this.nvcCode.Name = "nvcCode";
            this.nvcCode.ToolTipText = "کد";
            this.nvcCode.Visible = false;
            this.nvcCode.Width = 48;
            // 
            // Materials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(551, 544);
            this.Controls.Add(this.dgvMaterials);
            this.Controls.Add(this.btmCancel);
            this.Controls.Add(this.btmOK);
            this.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Materials";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "کالاها";
            this.Load += new System.EventHandler(this.Materials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmCancel;
        private System.Windows.Forms.Button btmOK;
        private System.Windows.Forms.DataGridView dgvMaterials;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcCode;
    }
}