using Baran.Ferroalloy.Automation;
using Baran.Ferroalloy.Automation.SqlDataBase;
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
    public partial class EmployeeUpdate : Form
    {
        public Employee emUpdate;
        public Connection cnConnection;
        private Department[] depDepartments;
        private string strOrginalCoID;

        public EmployeeUpdate()
        {
            InitializeComponent();
        }

        private void EmployeeUpdate_Load(object sender, EventArgs e)
        {
            this.strOrginalCoID = this.emUpdate.strCoID;

            //Fill cbDepartments ComboBox
            this.depDepartments = Department.GetDepartments(this.cnConnection);
            foreach (Department depDepartment in this.depDepartments)
            {
                this.cbDepartments.Items.Add(depDepartment.strName);
            }

            this.tbFirstName.Text = this.emUpdate.strFirstName;
            this.tbLastName.Text = this.emUpdate.strLastName;
            this.tbCoID.Text = this.emUpdate.strCoID;
            this.cbDepartments.Text = Department.GetNameByNumber(this.cnConnection,this.emUpdate.intDepartment);
            this.tbNationalID.Text = this.emUpdate.strNationalID;

            SetEnableBtmOk();
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            if (this.strOrginalCoID == this.tbCoID.Text.Trim())
            {
                this.btmOK.Enabled = false;
                this.emUpdate.strFirstName = this.tbFirstName.Text.Trim();
                this.emUpdate.strLastName = this.tbLastName.Text.Trim();
                this.emUpdate.strCoID = this.tbCoID.Text.Trim();
                this.emUpdate.strNationalID = this.tbNationalID.Text.Trim();
                this.emUpdate.intDepartment = Department.GetNumberByName(this.cnConnection, this.cbDepartments.Text);
                this.emUpdate.Update(this.cnConnection);
            }
            else if(!Employee.IsEmployee(this.cnConnection, this.tbCoID.Text.Trim()))
            {
                this.btmOK.Enabled = false;
                this.emUpdate.strFirstName = this.tbFirstName.Text.Trim();
                this.emUpdate.strLastName = this.tbLastName.Text.Trim();
                this.emUpdate.strCoID = this.tbCoID.Text.Trim();
                this.emUpdate.strNationalID = this.tbNationalID.Text.Trim();
                this.emUpdate.intDepartment = Department.GetNumberByName(this.cnConnection, this.cbDepartments.Text);
                this.emUpdate.Update(this.cnConnection);
            }
            else
            {
                MessageBox.Show(".این کد پرسنلی پیش از این ثبت شده است");
            }

            Employees frmEmployees = (Employees)this.Owner;
            frmEmployees.SearchEmployees();
            this.Close();
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetNumbericTextButtoms(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SetFarsiLanguageTextBoxes()
        {
            Language.SetFarsiLanguage();
        }

        private void SetEnableBtmOk()
        {
            if (this.tbFirstName.Text.Trim().Length != 0 && this.tbLastName.Text.Trim().Length != 0 &&
                this.cbDepartments.SelectedIndex >= 1 && this.tbCoID.Text.Trim().Length != 0 &&
                this.tbNationalID.Text.Trim().Length != 0)
            {
                this.btmOK.Enabled = true;
            }
            else
            {
                this.btmOK.Enabled = false;
            }
        }

        private void CbDepartments_SelectedIndexChanged(object sender, EventArgs e)
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

        private void TbCoID_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbNationalID_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void EmployeeUpdate_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    btmCancel_Click(new object(), new EventArgs());
                    break;
                case Keys.F6:
                    btmOK_Click(new object(), new EventArgs());
                    break;
                case Keys.F10:
                    Application.Exit();
                    break;
            }
        }

        private void TbShift_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbFatherName_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void DtpBrightDate_ValueChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void CbSubDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void CbPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void CbEmploymentTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void CbEducationLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void CbLocationProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbLocationCity_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbLocationVilage_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbLocationAddress_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbCoID_Enter(object sender, EventArgs e)
        {
            SetFarsiLanguageTextBoxes();
        }

        private void TbFirstName_Enter(object sender, EventArgs e)
        {
            SetFarsiLanguageTextBoxes();
        }

        private void TbLastName_Enter(object sender, EventArgs e)
        {
            SetFarsiLanguageTextBoxes();
        }

        private void TbNationalID_Enter(object sender, EventArgs e)
        {
            SetFarsiLanguageTextBoxes();
        }

        private void TbShift_Enter(object sender, EventArgs e)
        {
            SetFarsiLanguageTextBoxes();
        }

        private void TbPhoneNumber_Enter(object sender, EventArgs e)
        {
            SetFarsiLanguageTextBoxes();
        }

        private void TbFatherName_Enter(object sender, EventArgs e)
        {
            SetFarsiLanguageTextBoxes();
        }

        private void TbLocationCity_Enter(object sender, EventArgs e)
        {
            SetFarsiLanguageTextBoxes();
        }

        private void TbLocationVilage_Enter(object sender, EventArgs e)
        {
            SetFarsiLanguageTextBoxes();
        }

        private void TbLocationAddress_Enter(object sender, EventArgs e)
        {
            SetFarsiLanguageTextBoxes();
        }

        private void TbCoID_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetNumbericTextButtoms(sender, e);
        }

        private void TbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetNumbericTextButtoms(sender, e);
        }

        private void TbNationalID_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetNumbericTextButtoms(sender, e);
        }
    }
}
