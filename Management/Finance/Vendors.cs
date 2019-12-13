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
    public partial class Vendors : Form
    {
        public static Boolean bolIsRunning;
        public Connection cnConnection;
        public User usUser;
        public FamSetting setSettings;
        public DataSet dsVendors;
        private Category[] caCategories;
        private ActivityType[] atActivityTypes;
        private Vendor venSearch;
        private Vendor venUpdate;
        private bool bolEnableBtmSearchByInterface;
        private bool bolEnableBtmSearchByPermision;
        private bool bolEnableBtmDeleteByInterface;
        private bool bolEnableBtmDeleteByPermision;
        private bool bolEnableBtmInsertByInterface;
        private bool bolEnableBtmInsertByPermision;

        public Vendors()
        {
            InitializeComponent();

            bolIsRunning = true;
            this.bolEnableBtmSearchByInterface = false;
            this.bolEnableBtmSearchByPermision = false;
            this.bolEnableBtmDeleteByInterface = false;
            this.bolEnableBtmDeleteByPermision = false;
            this.bolEnableBtmInsertByInterface = true;
            this.bolEnableBtmInsertByPermision = false;
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

            //Fill cbActivityTypes ComboBox
            this.atActivityTypes = ActivityType.GetActivityTypes(this.cnConnection);
            this.cbActivityTypes.Items.Add("");
            foreach (ActivityType atActivityType in this.atActivityTypes)
            {
                this.cbActivityTypes.Items.Add(atActivityType.strName);
            }
        }

        private void SetComponentsByPermisions()
        {
            if (this.usUser.bolFinanceEnabed)
            {
                this.bolEnableBtmSearchByPermision = true;
                this.bolEnableBtmDeleteByPermision = true;
                this.bolEnableBtmInsertByPermision = true;
                this.dgvVendors.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVendors_CellMouseDoubleClick);
                this.dgvVendors.Columns["bitSelect"].Visible = true;
            }
            else
            {
                this.bolEnableBtmSearchByPermision = true;
                this.bolEnableBtmDeleteByPermision = false;
                this.bolEnableBtmInsertByPermision = false;
                this.dgvVendors.CellMouseDoubleClick -= new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVendors_CellMouseDoubleClick);
                this.dgvVendors.Columns["bitSelect"].Visible = false;
            }

            SetEnableComponents();
        }

        private void SetEnableComponents()
        {
            this.btmSearch.Enabled = this.bolEnableBtmSearchByPermision & this.bolEnableBtmSearchByInterface;
            this.btmDelete.Enabled = this.bolEnableBtmDeleteByPermision & this.bolEnableBtmDeleteByInterface;
            this.btmInsert.Enabled = this.bolEnableBtmInsertByPermision & this.bolEnableBtmInsertByInterface;
        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Vendors_FormClosing(object sender, FormClosingEventArgs e)
        {
            bolIsRunning = false;
           
            Management frmManagement = (Management)this.MdiParent;
            frmManagement.menWindows.DropDownItems["menWindowsVendors"].Dispose();
        }

        private void btmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmSearch_Click(object sender, EventArgs e)
        {
            this.btmSearch.Enabled = false;
            SearchVendors();
            this.btmSearch.Enabled = true;
        }

        public void SearchVendors()
        {
            this.venSearch = new Vendor();
            if (this.cbCategory.SelectedIndex>=1)
            {
                this.venSearch.intCategory = this.caCategories[this.cbCategory.SelectedIndex - 1].intNumber;
            }
            if(this.cbActivityTypes.SelectedIndex >= 1)
            {
                this.venSearch.strActivityType = this.atActivityTypes[this.cbActivityTypes.SelectedIndex - 1].strCode;
            }
            this.venSearch.strBrand = this.tbBrand.Text.Trim();
            if(this.tbNumber.Text.Trim().Length != 0)
            {
                this.venSearch.intNumber = int.Parse(this.tbNumber.Text.Trim());
            }
            
            this.venSearch.strFirstName = this.tbFirstName.Text.Trim();
            this.venSearch.strLastName = this.tbLastName.Text.Trim();
            this.venSearch.strCity = this.tbCity.Text.Trim();
            this.venSearch.strActivities = this.tbActivities.Text.Trim();

            this.dsVendors = Vendor.GetVendors(this.cnConnection, this.venSearch);

            this.dgvVendors.DataSource = this.dsVendors;
            this.dgvVendors.DataMember = "tabVendors";

            for (int i=0;i<this.dgvVendors.Rows.Count;i++)
            {
                this.dgvVendors.Rows[i].Cells["intCategoryByName"].Value = 
                    Category.GetNameByNumber(this.cnConnection,(int)this.dgvVendors.Rows[i].Cells["intCategory"].Value);
                this.dgvVendors.Rows[i].Cells["nvcActivityTypeByName"].Value =
                   ActivityType.GetNameByCode(this.cnConnection, this.dgvVendors.Rows[i].Cells["nvcActivityType"].Value.ToString());
            }
        }

        private void btmDelete_Click(object sender, EventArgs e)
        {
            Int16 intSelectedEmployees = 0;
            foreach (DataRow drVendor in this.dsVendors.Tables["tabVendors"].Rows)
            {
                if ((Boolean)drVendor["bitSelect"])
                {
                    ++intSelectedEmployees;
                }
            }

            if (intSelectedEmployees > 0)
            {
                DialogResult dialogResult = MessageBox.Show("آیا می خواهید " + intSelectedEmployees.ToString() + " فروشنده‌ای را حذف کنید؟", "حذف", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.btmDelete.Enabled = false;
                    Vendor.DeleteVendors(this.cnConnection, this.dsVendors);
                    SearchVendors();
                    this.btmDelete.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show(".هیچ فروشنده‌ای انتخاب نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void dgvVendors_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            VendorUpdate frmVendorUpdate = new VendorUpdate();
            frmVendorUpdate.Owner = this;
            this.venUpdate = new Vendor();
            frmVendorUpdate.venUpdate = this.venUpdate;
            frmVendorUpdate.cnConnection = this.cnConnection;
            frmVendorUpdate.setSettings = this.setSettings;
            frmVendorUpdate.usUser = this.usUser;

            this.venUpdate.intID = (int)this.dgvVendors.Rows[e.RowIndex].Cells["intID"].Value;
            this.venUpdate.intCategory = (int)this.dgvVendors.Rows[e.RowIndex].Cells["intCategory"].Value;
            this.venUpdate.intNumber = (int)this.dgvVendors.Rows[e.RowIndex].Cells["intNumber"].Value;
            this.venUpdate.strBrand = this.dgvVendors.Rows[e.RowIndex].Cells["nvcBrand"].Value.ToString();
            this.venUpdate.strActivityType = this.dgvVendors.Rows[e.RowIndex].Cells["nvcActivityType"].Value.ToString();
            this.venUpdate.strActivities = this.dgvVendors.Rows[e.RowIndex].Cells["nvcActivities"].Value.ToString();
            this.venUpdate.strTell = this.dgvVendors.Rows[e.RowIndex].Cells["nvcTell"].Value.ToString();
            this.venUpdate.strFirstName = this.dgvVendors.Rows[e.RowIndex].Cells["nvcFirstName"].Value.ToString();
            this.venUpdate.strLastName = this.dgvVendors.Rows[e.RowIndex].Cells["nvcLastName"].Value.ToString();
            this.venUpdate.strAddress = this.dgvVendors.Rows[e.RowIndex].Cells["nvcAddress"].Value.ToString();
            this.venUpdate.strCity = this.dgvVendors.Rows[e.RowIndex].Cells["nvcCity"].Value.ToString();

            frmVendorUpdate.ShowDialog();
        }

        private void btmInsert_Click(object sender, EventArgs e)
        {
            this.btmInsert.Enabled = false;
            VendorInsert frmVendorInsert = new VendorInsert();
            frmVendorInsert.Owner = this;
            frmVendorInsert.cnConnection = this.cnConnection;
            frmVendorInsert.setSettings = this.setSettings;
            frmVendorInsert.usUser = this.usUser;
            frmVendorInsert.ShowDialog();
            this.btmInsert.Enabled = true;
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

        private void SetEnableBtmSearch()
        {
            if (this.tbFirstName.Text.Trim().Length != 0 || this.tbLastName.Text.Trim().Length != 0 ||
               this.cbCategory.SelectedIndex >= 1 || this.cbActivityTypes.SelectedIndex >= 1 ||
               this.tbBrand.Text.Trim().Length != 0 || this.tbNumber.Text.Trim().Length != 0 ||
               this.tbActivities.Text.Trim().Length != 0 || this.tbCity.Text.Trim().Length != 0)
            {
                this.bolEnableBtmSearchByInterface = true;
            }
            else
            {
                this.bolEnableBtmSearchByInterface = false;
            }

            SetEnableComponents();
        }

        private void dgvVendors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvVendors.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void dgvVendors_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.bolEnableBtmDeleteByInterface = false;

            for (int i = 0; i < this.dgvVendors.Rows.Count; i++)
            {
                if ((bool)this.dgvVendors.Rows[i].Cells["bitSelect"].Value)
                {
                    this.bolEnableBtmDeleteByInterface = true;
                }
            }

            SetEnableComponents();
        }

        private void TbLastName_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmSearch();
        }

        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmSearch();
        }

        private void CbActivityTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmSearch();
        }

        private void TbBrand_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmSearch();
        }

        private void TbNumber_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmSearch();
        }

        private void TbFirstName_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmSearch();
        }

        private void TbActivities_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmSearch();
        }

        private void TbCity_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmSearch();
        }

        private void DgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvVendors.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void DgvEmployees_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.bolEnableBtmDeleteByInterface = false;

            for (int i = 0; i < this.dgvVendors.Rows.Count; i++)
            {
                if ((bool)this.dgvVendors.Rows[i].Cells["bitSelect"].Value)
                {
                    this.bolEnableBtmDeleteByInterface = true;
                }
            }

            SetEnableComponents();
        }

        private void DgvVendors_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dgvVendors.Rows.Count; i++)
            {
                this.dgvVendors.Rows[i].Cells["intCategoryByName"].Value =
                    Category.GetNameByNumber(this.cnConnection, (int)this.dgvVendors.Rows[i].Cells["intCategory"].Value);
                this.dgvVendors.Rows[i].Cells["nvcActivityTypeByName"].Value =
                   ActivityType.GetNameByCode(this.cnConnection, this.dgvVendors.Rows[i].Cells["nvcActivityType"].Value.ToString());
            }
        }
    }
}
