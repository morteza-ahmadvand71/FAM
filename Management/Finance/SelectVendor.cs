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
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baran.Ferroalloy.Management
{
    public partial class SelectVendor : Form
    {
        public Connection cnConnection;
        public FamSetting setSettings;
        public User usUser;
        public DataSet dsVendors;
        private Category[] caCategories;
        private Vendor venSearch;
        public Vendor venSelected;
        public static int intNumberSelectedVendor;
        public static string strNameSelectedVendor;

        public SelectVendor()
        {
            InitializeComponent();

            this.venSelected = new Vendor();
            SelectVendor.intNumberSelectedVendor = 0;
            SelectVendor.strNameSelectedVendor = "";
        }

        private void Vendors_Load(object sender, EventArgs e)
        {
            SetComponentsByPermisions();

            //Fill cbCategory ComboBox
            this.caCategories = Category.GetCategories(this.cnConnection);
            this.cbCategory.Items.Add("");
            foreach (Category ctCategory in this.caCategories)
            {
                this.cbCategory.Items.Add(ctCategory.strName);
            }
        }

        private void SetComponentsByPermisions()
        {
            if (this.usUser.bolFinanceEnabed)
            {
                this.btmInsertVendor.Enabled = true;
            }
            else
            {
                this.btmInsertVendor.Enabled = false;
            }
        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Vendors_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btmSearch_Click(object sender, EventArgs e)
        {
            SearchVendors();
        }

        public void SearchVendors()
        {
            this.venSearch = new Vendor();
            this.venSearch.intCategory = this.caCategories[this.cbCategory.SelectedIndex-1].intNumber;
            this.venSearch.strBrand = this.tbBrand.Text.Trim();
            if(this.tbNumber.Text.Trim().Length != 0)
            {
                this.venSearch.intNumber = int.Parse(this.tbNumber.Text.Trim());
            }
            this.venSearch.strFirstName = this.tbFirstName.Text.Trim();
            this.venSearch.strLastName = this.tbLastName.Text.Trim();
            this.venSearch.strCity = this.tbCity.Text.Trim();

            this.dsVendors = Vendor.GetVendors(this.cnConnection, this.venSearch);

            this.dgvVendors.DataSource = this.dsVendors;
            this.dgvVendors.DataMember = "tabVendors";

            for (int i=0;i<this.dgvVendors.Rows.Count;i++)
            {
                this.dgvVendors.Rows[i].Cells["intCategoryAsName"].Value = 
                    Category.GetNameByNumber(this.cnConnection, (int)this.dgvVendors.Rows[i].Cells["intCategory"].Value);
            }
        }

        private void btmInsert_Click(object sender, EventArgs e)
        {
            VendorInsert frmVendorInsert = new VendorInsert();
            frmVendorInsert.Owner = this;
            frmVendorInsert.cnConnection = this.cnConnection;
            frmVendorInsert.ShowDialog();
        }

        private void BtmSelect_Click(object sender, EventArgs e)
        {
            if(!this.cbNoName.Checked)
            {
                if(this.dgvVendors.SelectedRows.Count == 1)
                {
                    SelectVendor.intNumberSelectedVendor = (int)this.dgvVendors.SelectedRows[0].Cells["intNumber"].Value;
                    SelectVendor.strNameSelectedVendor = this.dgvVendors.SelectedRows[0].Cells["nvcFirstName"].Value.ToString() + " " +
                        this.dgvVendors.SelectedRows[0].Cells["nvcLastName"].Value.ToString() + " - " +
                        this.dgvVendors.SelectedRows[0].Cells["nvcBrand"].Value.ToString();
                }
            }
            else
            {
                intNumberSelectedVendor = -1;
                strNameSelectedVendor = "بی نام";
            }

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

        private void SetEnableBtmSelect()
        {
            if (this.tbFirstName.Text.Trim().Length != 0 || this.tbLastName.Text.Trim().Length != 0 ||
                this.cbCategory.SelectedIndex >= 1 || this.tbNumber.Text.Length != 0 ||
                this.tbCity.Text.Length != 0 || this.tbBrand.Text.Trim().Length != 0 || this.cbNoName.Checked)
            {
                this.btmSearch.Enabled = true;
            }
            else
            {
                this.btmSearch.Enabled = false;
            }
        }

        private void CbNoName_CheckedChanged(object sender, EventArgs e)
        {
            if(this.cbNoName.Checked)
            {
                this.dsVendors = new DataSet();
                this.dgvVendors.DataSource = this.dsVendors;
                this.dgvVendors.DataMember = "";

                this.dgvVendors.Enabled = false;
                this.tbFirstName.Text = "";
                this.tbFirstName.Enabled = false;
                this.tbLastName.Text = "";
                this.tbLastName.Enabled = false;
                this.cbCategory.SelectedIndex = 0;
                this.cbCategory.Enabled = false;
                this.tbNumber.Text = "";
                this.tbNumber.Enabled = false;
                this.tbCity.Text = "";
                this.tbCity.Enabled = false;
                this.tbBrand.Text = "";
                this.tbBrand.Enabled = false;
                this.btmSearch.Enabled = false;
            }
            else
            {
                this.dgvVendors.Enabled = true;
                this.tbFirstName.Enabled = true;
                this.tbLastName.Enabled = true;
                this.cbCategory.Enabled = true;
                this.tbNumber.Enabled = true;
                this.tbCity.Enabled = true;
                this.tbBrand.Enabled = true;
                this.btmSearch.Enabled = true;
            }

            SetEnableBtmSelect();
        }

        private void DgvVendors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                this.btmSelect.Enabled = true;
            }
            else
            {
                this.btmSelect.Enabled = false;
            }
        }

        private void DgvVendors_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == -1)
            {
                this.btmSelect.Enabled = true;
            }
            else
            {
                this.btmSelect.Enabled = false;
            }
        }

        private void DgvVendors_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dgvVendors.Rows.Count; i++)
            {
                this.dgvVendors.Rows[i].Cells["intCategoryByName"].Value =
                    Category.GetNameByNumber(this.cnConnection, (int)this.dgvVendors.Rows[i].Cells["intCategory"].Value);
            }
        }

        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmSelect();
        }

        private void TbNumber_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmSelect();
        }

        private void TbBrand_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmSelect();
        }

        private void TbFirstName_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmSelect();
        }

        private void TbLastName_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmSelect();
        }

        private void TbCity_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmSelect();
        }

        private void BtmInsertVendor_Click(object sender, EventArgs e)
        {
            VendorInsert frmVendorInsert = new VendorInsert();
            frmVendorInsert.cnConnection = this.cnConnection;
            frmVendorInsert.setSettings = this.setSettings;
            frmVendorInsert.usUser = this.usUser;
            frmVendorInsert.ShowDialog();
        }
    }
}
