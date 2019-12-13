using Baran.Ferroalloy.Automation;
using Baran.Ferroalloy.Automation.Security;
using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Maintenance;
using Baran.Ferroalloy.Management.Properties;
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
    public partial class OfficePrefrences : Form
    {
        public static Boolean bolIsRunning;
        public Connection cnConnection;
        public FamSetting setSettings;
        public User usUser;
        private DataTable dtDepartments;
        private DataTable dtCategories;
        private FamSetting.CoInformation ciCoInformation;
        public static bool bolWritePermision;
        private bool bolEnableBtmSearchByInterface;
        private bool bolEnableBtmSearchByPermision;
        private bool bolEnableBtmDeleteByInterface;
        private bool bolEnableBtmDeleteByPermision;
        private bool bolEnableBtmInsertByInterface;
        private bool bolEnableBtmInsertByPermision;

       

        public OfficePrefrences()
        {
            InitializeComponent();

            this.dtDepartments = new DataTable();

            bolIsRunning = true;
           
            this.bolEnableBtmSearchByInterface = false;
            this.bolEnableBtmSearchByPermision = true;
            this.bolEnableBtmDeleteByInterface = false;
            this.bolEnableBtmDeleteByPermision = false;
            this.bolEnableBtmInsertByInterface = true;
            this.bolEnableBtmInsertByPermision = false;
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            SetComponentsByPermisions();

            this.dtDepartments = Department.GetDepartmentsAsDataTable(this.cnConnection);
            this.dgvDepartments.DataSource = this.dtDepartments;

            this.dtCategories = Category.GetCategoriesAsDataTable(this.cnConnection);
            this.dgvCategories.DataSource = this.dtCategories;

            this.ciCoInformation = FamSetting.GetCoInformation(this.cnConnection);
            
            this.tbName.Text = this.ciCoInformation.strName;
            this.cbTypes.SelectedItem = this.ciCoInformation.strCoType;
            if (this.ciCoInformation.dtRegister.Year != 1)
            {
                this.dtpRegister.Value = this.ciCoInformation.dtRegister;
            }
            this.tbRegisterNumber.Text = this.ciCoInformation.strRegisterCode;
            this.tbCoID.Text = this.ciCoInformation.strCoID;
            this.tbAddress.Text = this.ciCoInformation.strAddress;
            this.tbPostalCode.Text = this.ciCoInformation.strPostalCode;
            this.tbTell.Text = this.ciCoInformation.strTell;
            this.tbFax.Text = this.ciCoInformation.strFax;
            this.tbTaxID.Text = this.ciCoInformation.strTaxID;
            this.tbProvince.Text = this.ciCoInformation.strProvince;
            this.tbCity.Text = this.ciCoInformation.strCity;
            this.tbWebSite.Text = this.ciCoInformation.strWebSite;

            this.btmCoSave.Enabled = false;
        }

        private void SetComponentsByPermisions()
        {
            if(this.usUser.bolOfficeEnabed)
            {
                this.bolEnableBtmSearchByPermision = true;
                this.bolEnableBtmDeleteByPermision = true;
                this.bolEnableBtmInsertByPermision = true;
            }
            else
            {
                this.bolEnableBtmSearchByPermision = true;
                this.bolEnableBtmDeleteByPermision = false;
                this.bolEnableBtmInsertByPermision = false;
            }

            SetEnableComponents();
        }

        private void SetEnableComponents()
        {
            //this.btmSearch.Enabled = this.bolEnableBtmSearchByPermision & this.bolEnableBtmSearchByInterface;
            //this.btmDelete.Enabled = this.bolEnableBtmDeleteByPermision & this.bolEnableBtmDeleteByInterface;
            //this.btmInsert.Enabled = this.bolEnableBtmInsertByPermision & this.bolEnableBtmInsertByInterface;
        }

        private void Employees_FormClosing(object sender, FormClosingEventArgs e)
        {
            bolIsRunning = false;

            Management frmManagement = (Management)this.MdiParent;
            frmManagement.menWindows.DropDownItems["menWindowsOfficeDepartmentPrefrences"].Dispose();
        }

        private void btmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Employees_Enter(object sender, EventArgs e)
        {
           
        }

        private void SetFarsiLanguageTextBoxes(object sender, EventArgs e)
        {
            Language.SetFarsiLanguage();
        }

        private void SetEnglishLanguageTextBoxes(object sender, EventArgs e)
        {
            Language.SetEnglishLanguage();
        }

        private void SetNumbericCharsTextBoxes(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btmDepartmentsSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dtDepartments.Rows.Count; i++)
            {
                if (this.dtDepartments.Rows[i].RowState == DataRowState.Deleted)
                {
                    Department.Delete(this.cnConnection, (int)this.dtDepartments.Rows[i]["intID", DataRowVersion.Original]);
                }

                if (this.dtDepartments.Rows[i].RowState == DataRowState.Added)
                {
                    Department.Insert(this.cnConnection, this.dtDepartments.Rows[i]["nvcName"].ToString());
                }

                if (this.dtDepartments.Rows[i].RowState == DataRowState.Modified)
                {
                    Department deDepartmentLoc = new Department();
                    deDepartmentLoc.strName = this.dtDepartments.Rows[i]["nvcName"].ToString();
                    deDepartmentLoc.intID = (int)this.dtDepartments.Rows[i]["intID"];
                    Department.Update(this.cnConnection, deDepartmentLoc);
                }
            }

            this.btmDepartmentsSave.Enabled = false;
        }

        private void DgvDepartments_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.btmDepartmentsSave.Enabled = true;
        }

        private void DgvDepartments_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.btmDepartmentsSave.Enabled = true;
        }

        private void DgvDepartments_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.btmDepartmentsSave.Enabled = true;
        }

        private void BtmCategoriesSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dtCategories.Rows.Count; i++)
            {
                if (this.dtCategories.Rows[i].RowState == DataRowState.Deleted)
                {
                    Category.Delete(this.cnConnection, (int)this.dtCategories.Rows[i]["intID", DataRowVersion.Original]);
                }

                if (this.dtCategories.Rows[i].RowState == DataRowState.Added)
                {
                    Category.Insert(this.cnConnection, this.dtCategories.Rows[i]["nvcName"].ToString());
                }

                if (this.dtCategories.Rows[i].RowState == DataRowState.Modified)
                {
                    Category caCategory = new Category();
                    caCategory.strName = this.dtCategories.Rows[i]["nvcName"].ToString();
                    caCategory.intID = (int)this.dtCategories.Rows[i]["intID"];
                    Category.Update(this.cnConnection, caCategory);
                }
            }

            this.btmDepartmentsSave.Enabled = false;
        }

        private void TbName_TextChanged(object sender, EventArgs e)
        {
            this.btmCoSave.Enabled = true;
        }

        private void CbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btmCoSave.Enabled = true;
        }

        private void DtpRegister_ValueChanged(object sender, EventArgs e)
        {
            this.btmCoSave.Enabled = true;
        }

        private void TbRegisterNumber_TextChanged(object sender, EventArgs e)
        {
            this.btmCoSave.Enabled = true;
        }

        private void TbRegisterID_TextChanged(object sender, EventArgs e)
        {
            this.btmCoSave.Enabled = true;
        }

        private void TbAddress_TextChanged(object sender, EventArgs e)
        {
            this.btmCoSave.Enabled = true;
        }

        private void TbPostalCode_TextChanged(object sender, EventArgs e)
        {
            this.btmCoSave.Enabled = true;
        }

        private void TbTell_TextChanged(object sender, EventArgs e)
        {
            this.btmCoSave.Enabled = true;
        }

        private void TbFax_TextChanged(object sender, EventArgs e)
        {
            this.btmCoSave.Enabled = true;
        }

        private void TbTaxID_TextChanged(object sender, EventArgs e)
        {
            this.btmCoSave.Enabled = true;
        }

        private void BtmCoSave_Click(object sender, EventArgs e)
        {
            this.ciCoInformation = new FamSetting.CoInformation();

            this.ciCoInformation.strName = this.tbName.Text.Trim();
            this.ciCoInformation.strCoType = this.cbTypes.SelectedItem.ToString();
            this.ciCoInformation.dtRegister = (DateTime)this.dtpRegister.Value;
            this.ciCoInformation.strRegisterCode = this.tbRegisterNumber.Text.Trim();
            this.ciCoInformation.strCoID = this.tbCoID.Text.Trim();
            this.ciCoInformation.strAddress = this.tbAddress.Text.Trim();
            this.ciCoInformation.strPostalCode = this.tbPostalCode.Text.Trim();
            this.ciCoInformation.strTell = this.tbTell.Text.Trim();
            this.ciCoInformation.strFax = this.tbFax.Text.Trim();
            this.ciCoInformation.strTaxID = this.tbTaxID.Text.Trim();
            this.ciCoInformation.strProvince = this.tbProvince.Text.Trim();
            this.ciCoInformation.strCity = this.tbCity.Text.Trim();
            this.ciCoInformation.strWebSite = this.tbWebSite.Text.Trim();

            FamSetting.SetCoInformation(this.cnConnection, this.ciCoInformation);

            this.btmCoSave.Enabled = false;
        }
    }
}
