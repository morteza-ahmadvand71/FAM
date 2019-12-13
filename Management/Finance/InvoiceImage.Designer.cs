namespace Baran.Ferroalloy.Management.Finance
{
    partial class InvoiceImage
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
            this.pbFactor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFactor)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFactor
            // 
            this.pbFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFactor.Image = global::Baran.Ferroalloy.Management.Properties.Resources._6;
            this.pbFactor.Location = new System.Drawing.Point(0, 0);
            this.pbFactor.Margin = new System.Windows.Forms.Padding(4);
            this.pbFactor.Name = "pbFactor";
            this.pbFactor.Size = new System.Drawing.Size(2481, 1530);
            this.pbFactor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFactor.TabIndex = 0;
            this.pbFactor.TabStop = false;
            // 
            // InvoiceImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2481, 1530);
            this.Controls.Add(this.pbFactor);
            this.Font = new System.Drawing.Font("Tahoma", 10.125F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InvoiceImage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فاکتور";
            this.Load += new System.EventHandler(this.Factor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFactor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFactor;
    }
}