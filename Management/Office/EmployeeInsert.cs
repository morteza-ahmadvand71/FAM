using Baran.Ferroalloy.Automation;
using Baran.Ferroalloy.Automation.Security;
using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Office;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baran.Ferroalloy.Management
{
    public partial class EmployeeInsert : Form
    {
        public Connection cnConnection;
        public User usUser;
        public FamSetting setSetings;
        public Employee emInsert = new Employee();
        private Department[] depDepartments;
        private SubDepartment[] depSubDepartments;

        public EmployeeInsert()
        {
            InitializeComponent();
        }

        private void EmployeeUpdate_Load(object sender, EventArgs e)
        {
            //Fill cbDepartments ComboBox
            this.depDepartments = Department.GetDepartments(this.cnConnection);
            foreach (Department depDepartment in this.depDepartments)
            {
                this.cbDepartments.Items.Add(depDepartment.strName);
            }

            //Next Corporation ID
            this.tbCoID.Text = Employee.GetNextCoId(this.cnConnection);

            //Fill cbShiftType
            this.cbShiftType.DataSource = Enum.GetValues(typeof(ShiftInfo.ShiftType));
            this.cbShiftType.SelectedIndex = -1;

            //Fill cbPosts
            this.cbPosts.DataSource = Enum.GetValues(typeof(Employee.PostType));
            this.cbPosts.SelectedIndex = -1;

            //Fill cbEmploymentTypes
            this.cbEmploymentTypes.DataSource = Enum.GetValues(typeof(Employee.EmploymentType));
            this.cbEmploymentTypes.SelectedIndex = -1;

            //Fill cbEducationLevels
            this.cbEducationLevels.DataSource = Enum.GetValues(typeof(Employee.EducationLevel));
            this.cbEducationLevels.SelectedIndex = -1;
            
            //Fill cbLocationProvince
            this.cbLocationProvince.DataSource = Employee.GetProvinces(this.cnConnection);
            this.cbLocationProvince.SelectedIndex = -1;
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            if(!Employee.IsEmployee(this.cnConnection, Language.GetEnglishText(this.tbCoID.Text)))
            {
                this.btmOK.Enabled = false;

                this.emInsert.strCoID = Language.GetEnglishText(this.tbCoID.Text);
                this.emInsert.strFirstName = this.tbFirstName.Text.Trim();
                this.emInsert.strLastName = this.tbLastName.Text.Trim();
                this.emInsert.strNationalID = Language.GetEnglishText(this.tbNationalID.Text);
                this.emInsert.strInsuranceNumber = this.tbInsuranceNumber.Text.Trim();
                this.emInsert.bolIsShiftMode = this.cbIsShiftMode.Checked;
                this.emInsert.intShiftType = this.cbShiftType.SelectedIndex + 1;
                this.emInsert.strPhoneNumber = Language.GetEnglishText(this.tbPhoneNumber.Text);
                this.emInsert.strFatherName = this.tbFatherName.Text.Trim();
                this.emInsert.dtBirth = this.dtpBrightDate.Value;
                this.emInsert.intDepartment = this.depDepartments[this.cbDepartments.SelectedIndex].intNumber;
                this.emInsert.intSubDepartment = this.depSubDepartments[this.cbSubDepartment.SelectedIndex].intNumber;
                this.emInsert.intPost = this.cbPosts.SelectedIndex + 1;
                this.emInsert.intEmploymentType = this.cbEmploymentTypes.SelectedIndex + 1;

                this.emInsert.intEducationLevel = this.cbEducationLevels.SelectedIndex + 1;
                this.emInsert.strLocationProvince = this.cbLocationProvince.SelectedItem.ToString();
                this.emInsert.strLocationCounty = this.tbLocationCounty.Text.Trim();
                this.emInsert.strLocationCityVillage = this.tbLocationCityVillage.Text.Trim();
                this.emInsert.strLocationAddress = this.tbLocationAddress.Text.Trim();
                this.emInsert.strPostalCode = this.tbPostalCode.Text.Trim();

                this.emInsert.Insert(this.cnConnection);

                if(this.Owner is Employees)
                {
                    Employees frmEmployees = (Employees)this.Owner;
                    frmEmployees.SearchEmployees();
                }
               
                this.Close();
            }
            else
            {
                MessageBox.Show(".این کد پرسنلی پیش از این ثبت شده است");
            }
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetEnableBtmOk()
        {
            bool bolShift = false;
            if (this.cbIsShiftMode.Checked && this.cbShiftType.SelectedIndex >=0)
            {
                bolShift = true;
            }
            if(!this.cbIsShiftMode.Checked)
            {
                bolShift = true;
            }

            if (this.tbFirstName.Text.Trim().Length != 0 && this.tbLastName.Text.Trim().Length != 0 &&
                this.cbDepartments.SelectedIndex != -1 && this.tbCoID.Text.Trim().Length != 0 &&
                this.tbNationalID.Text.Trim().Length != 0 && this.cbSubDepartment.SelectedIndex != -1 &&
                this.cbPosts.SelectedIndex != -1 && this.cbEmploymentTypes.SelectedIndex != -1 &&
                this.cbEducationLevels.SelectedIndex != -1 && this.tbLocationAddress.Text.Trim().Length != 0 &&
                this.tbFatherName.Text.Trim().Length != 0 && this.dtpBrightDate.Value != DateTime.Today &&
                this.cbLocationProvince.SelectedIndex != -1 && this.tbLocationCounty.Text.Trim().Length != 0 &&
                this.tbLocationCityVillage.Text.Trim().Length != 0 && bolShift)
            {
                this.btmOK.Enabled = true;
            }
            else
            {
                this.btmOK.Enabled = false;
            }
        }

        private void SetNumbericTextButtoms(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SetFarsiLanguageTextBoxes(object sender, EventArgs e)
        {
            Language.SetFarsiLanguage();
        }

        private void TbFirstName_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbLastName_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk(); ;
        }

        private void TbCoID_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void CbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cbDepartments.SelectedIndex != -1)
            {
                //Fill cbSubDepartment
                this.cbSubDepartment.Items.Clear();
                this.depSubDepartments = SubDepartment.GetSubDepartments(this.cnConnection, this.depDepartments[this.cbDepartments.SelectedIndex].intNumber);
                foreach (SubDepartment depSubDepartment in this.depSubDepartments)
                {
                    this.cbSubDepartment.Items.Add(depSubDepartment.strName);
                }

                SetEnableBtmOk();
            }
        }

        private void TbNationalID_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void EmployeeInsert_KeyDown(object sender, KeyEventArgs e)
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

        private void TbShift_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void DtpBrightDate_ValueChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void CbEducationLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbFatherName_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void CbLocationProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void CbLocationCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void CbLocationVilage_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbLocationAddress_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void cbShift_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbIsShiftMode.Checked)
            {
                this.labShift.Enabled = true;
                this.cbShiftType.Enabled = true;
            }
            else
            {
                this.labShift.Enabled = false;
                this.cbShiftType.Enabled = false;
            }
        }
    }
}
