using Baran.Ferroalloy.Automation;
using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Finance;
using Baran.Ferroalloy.Maintenance;
using Baran.Ferroalloy.Office;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baran.Ferroalloy.Management
{
    public partial class SubprojectUpdate : Form
    {
        public Subproject spUpdate;
        public Connection cnConnection;
        private Category[] caCategories;

        public SubprojectUpdate()
        {
            InitializeComponent();

            this.spUpdate = new Subproject();
        }

        private void InvoiceUpdate_Load(object sender, EventArgs e)
        {
            //Fill cbCategory ComboBox
            this.caCategories = Category.GetCategories(this.cnConnection);
            this.cbCategory.Items.Add("");
            foreach (Category ctCategory in this.caCategories)
            {
                this.cbCategory.Items.Add(ctCategory.strName);
            }

            //Fill Controls with Part Properties
            this.tbProjectNumber.Text = this.spUpdate.intProjectNumber.ToString();
            this.cbCategory.Text = Category.GetNameByNumber(this.cnConnection,this.spUpdate.intCategory);
            this.tbName.Text = this.spUpdate.strName;
            this.dtpStartDate.Value = this.spUpdate.dtStart;
            this.tbprogress.Text = this.spUpdate.intProgress.ToString();
            this.tbDuration.Text = this.spUpdate.intDuration.ToString();
            this.tbTip.Text = this.spUpdate.strTip;
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            this.btmOK.Enabled = false;
            this.spUpdate.intProjectNumber = int.Parse(this.tbProjectNumber.Text.Trim());
            this.spUpdate.dtStart = this.dtpStartDate.Value;
            this.spUpdate.intCategory = this.caCategories[this.cbCategory.SelectedIndex].intNumber;
            this.spUpdate.strName = this.tbName.Text.Trim();
            this.spUpdate.dtStart = this.dtpStartDate.Value;
            this.spUpdate.intProgress = int.Parse(this.tbprogress.Text.Trim());
            this.spUpdate.intDuration = int.Parse(this.tbDuration.Text.Trim());
            this.spUpdate.strTip = this.tbTip.Text.Trim();

            this.spUpdate.Update(this.cnConnection);

            Subprojects frmSubprojects = (Subprojects)this.Owner;
            frmSubprojects.SearchSubprojects();
            this.Close();
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetEnableBtmOk()
        {
            if (this.tbName.Text.Trim().Length != 0 && this.tbDuration.Text.Trim().Length != 0 &&
                this.dtpStartDate.Value.Year != 1 && this.cbCategory.SelectedIndex != -1 &&
                this.tbprogress.Text.Trim().Length != 0 && this.tbProjectNumber.Text.Trim().Length != 0)
            {
                this.btmOK.Enabled = true;
            }
            else
            {
                this.btmOK.Enabled = false;
            }
        }

        private void SetFarsiLanguageTextBoxes(object sender, EventArgs e)
        {
            Language.SetFarsiLanguage();
        }

        private void SetNumbericCharsTextBoxes(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DtpStartDate_ValueChanged(object sender, EventArgs e)
        {
          

            SetEnableBtmOk();
        }

        private void TbProjectNumber_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbName_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbDuration_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void Tbprogress_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbTip_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }
    }
}
