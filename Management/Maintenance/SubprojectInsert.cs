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
    public partial class SubprojectInsert : Form
    {
        public Subproject spInsert;

        public Connection cnConnection;
        private Category[] caCategories;

        public SubprojectInsert()
        {
            InitializeComponent();

            this.spInsert = new Subproject();
        }

        private void SubprojectInsert_Load(object sender, EventArgs e)
        {
            
            //Fill cbCategory ComboBox
            this.caCategories = Category.GetCategories(this.cnConnection);
            this.cbCategory.Items.Add("");
            foreach (Category ctCategory in this.caCategories)
            {
                this.cbCategory.Items.Add(ctCategory.strName);
            }
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            this.btmOK.Enabled = false;
            this.spInsert.intCategory = this.caCategories[this.cbCategory.SelectedIndex].intNumber;
            this.spInsert.dtStart = this.dtpStartDate.Value;
            this.spInsert.strName = this.tbName.Text;
            this.spInsert.intDuration = int.Parse(this.tbDuration.Text);
            this.spInsert.strTip = this.tbTip.Text;


            spInsert.Insert(this.cnConnection);

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
                this.tbprogress.Text.Trim().Length != 0)
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
