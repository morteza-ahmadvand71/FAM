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
    public partial class VendorInsert : Form
    {
        public Vendor venInsert = new Vendor();
        public Connection cnConnection;
        public User usUser;
        public FamSetting setSettings;
        private Category[] caCategories;
        private ActivityType[] atActivityTypes;

        public VendorInsert()
        {
            InitializeComponent();
        }

        private void VendorInsert_Load(object sender, EventArgs e)
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
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            this.venInsert.intCategory = Category.GetNumberByName(this.cnConnection, this.cbCategory.Text);
            this.venInsert.strBrand = this.tbBrand.Text;
            this.venInsert.strActivityType = ActivityType.GetCodeByName(this.cnConnection, this.cbActivityTypes.Text);
            this.venInsert.strActivities = this.tbActivities.Text;
            this.venInsert.strFirstName = this.tbFirstName.Text;
            this.venInsert.strLastName = this.tbLastName.Text;
            this.venInsert.strTell = this.tbTell.Text;
            this.venInsert.strCity = this.tbCity.Text;
            this.venInsert.strAddress = this.tbAddress.Text;
            this.venInsert.Update(this.cnConnection);
            venInsert.Insert(this.cnConnection);

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
            if ( this.tbLastName.Text.Trim().Length != 0 && this.tbActivities.Text.Trim().Length != 0 &&
                this.cbCategory.SelectedIndex >= 0 && this.cbActivityTypes.SelectedIndex >= 0 &&
                this.tbCity.Text.Trim().Length != 0 && this.tbBrand.Text.Trim().Length != 0)
            {
                this.btmOK.Enabled = true;
            }
            else
            {
                this.btmOK.Enabled = false;
            }
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
