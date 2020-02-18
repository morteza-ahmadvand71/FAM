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
    public partial class ProjectUpdate : Form
    {
        public Project proUpdate;
        public Connection cnConnection;
        private Category[] caCategories;

        public ProjectUpdate()
        {
            InitializeComponent();
        }

        private void ProjectUpdate_Load(object sender, EventArgs e)
        {
            //Fill cbCategory ComboBox
            this.caCategories = Category.GetCategories(this.cnConnection);
            foreach (Category ctCategory in this.caCategories)
            {
                this.cbCategory.Items.Add(ctCategory.strName);
            }

            //Fill Controls with Part Properties
            this.cbCategory.Text = Category.GetNameByNumber(this.cnConnection,this.proUpdate.intCategory);
            this.tbName.Text = this.proUpdate.strName;
            this.tbNumber.Text = this.proUpdate.intNumber.ToString();
            this.tbTip.Text = this.proUpdate.strTip;
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            this.proUpdate.intCategory = this.caCategories[this.cbCategory.SelectedIndex].intNumber;
            this.proUpdate.strName = this.tbName.Text;
            this.proUpdate.intNumber = int.Parse(this.tbNumber.Text);
            this.proUpdate.strTip = this.tbTip.Text;

            this.proUpdate.Update(this.cnConnection);

            Projects frmProjects = (Projects)this.Owner;
            frmProjects.SearchProjects();
            this.Close();
        }

        private void SetEnableBtmOk()
        {
            if (this.tbNumber.Text.Trim().Length != 0 && this.cbCategory.SelectedIndex >= 0 &&
                this.tbName.Text.Trim().Length != 0)
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

        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TbNumber_TextChanged(object sender, EventArgs e)
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

        private void TbTip_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }
    }
}
