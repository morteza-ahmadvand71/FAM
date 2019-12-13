using Baran.Ferroalloy.Automation;
using Baran.Ferroalloy.Automation.Security;
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
    public partial class VendorUpdate : Form
    {
        public Vendor venUpdate;
        public Connection cnConnection;
        public User usUser;
        public FamSetting setSettings;
        private Category[] caCategories;
        private ActivityType[] atActivityTypes;

        public VendorUpdate()
        {
            InitializeComponent();
        }

        private void VendorUpdate_Load(object sender, EventArgs e)
        {
            //Fill cbCategory ComboBox
            this.caCategories = Category.GetCategories(this.cnConnection);
            this.cbCategory.Items.Add("");
            foreach (Category ctCategory in this.caCategories)
            {
                this.cbCategory.Items.Add(ctCategory.strName);
            }

            //Fill cbActivityTypes ComboBox
            this.atActivityTypes = ActivityType.GetActivityTypes(this.cnConnection);
            foreach (ActivityType atActivityType in this.atActivityTypes)
            {
                this.cbActivityTypes.Items.Add(atActivityType.strName);
            }

            //Fill Controls with Part Properties
            this.cbCategory.Text = Category.GetNameByNumber(this.cnConnection,this.venUpdate.intCategory);
            this.tbBrand.Text = this.venUpdate.strBrand;
            this.cbActivityTypes.Text = ActivityType.GetNameByCode(this.cnConnection,this.venUpdate.strActivityType);
            this.tbActivities.Text = this.venUpdate.strActivities;
            this.tbNumber.Text = this.venUpdate.intNumber.ToString();
            this.tbFirstName.Text = this.venUpdate.strFirstName;
            this.tbTell.Text = this.venUpdate.strTell;
            this.tbLastName.Text = this.venUpdate.strLastName;
            this.tbAddress.Text = this.venUpdate.strAddress;
            this.tbCity.Text = this.venUpdate.strCity;

            SetEnableBtmOk();
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            this.btmOK.Enabled = false;
            this.venUpdate.intCategory = Category.GetNumberByName(this.cnConnection,this.cbCategory.Text);
            this.venUpdate.strBrand = this.tbBrand.Text;
            this.venUpdate.strActivityType = ActivityType.GetCodeByName(this.cnConnection, this.cbActivityTypes.Text);
            this.venUpdate.strActivities = this.tbActivities.Text;
            this.tbActivities.Text = this.venUpdate.strActivities;
            this.venUpdate.intNumber = int.Parse(this.tbNumber.Text);
            this.venUpdate.strTell = this.tbTell.Text;
            this.venUpdate.strFirstName = this.tbFirstName.Text;
            this.venUpdate.strLastName = this.tbLastName.Text;
            this.venUpdate.strCity = this.tbCity.Text;
            this.venUpdate.strAddress = this.tbAddress.Text;
            this.venUpdate.Update(this.cnConnection);

            Vendors frmVendors = (Vendors)this.Owner;
            frmVendors.SearchVendors();
            this.Close();
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void SetEnableBtmOk()
        {
            if (this.tbLastName.Text.Trim().Length != 0 &&
                this.cbCategory.SelectedIndex >= 0 && this.cbActivityTypes.SelectedIndex >= 0 && this.tbActivities.Text.Trim().Length != 0 &&
                this.tbCity.Text.Trim().Length != 0 && this.tbBrand.Text.Trim().Length != 0 && this.tbNumber.Text.Trim().Length != 0)
            {
                this.btmOK.Enabled = true;
            }
            else
            {
                this.btmOK.Enabled = false;
            }
        }

        private void TbNumber_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbBrand_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbFirstName_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbLastName_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbTell_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void CbActivityTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbActivities_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbCity_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbAddress_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }
    }
}
