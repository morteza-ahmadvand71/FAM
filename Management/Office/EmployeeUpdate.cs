using Baran.Ferroalloy.Automation;
using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Finance;
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
        private SubDepartment[] depSubDepartments;
        private DataTable dtBankNames;

        public EmployeeUpdate()
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

            //Fill cbSubDepartment
            this.depSubDepartments = SubDepartment.GetSubDepartments(this.cnConnection, this.emUpdate.intDepartment);
            foreach (SubDepartment depSubDepartment in this.depSubDepartments)
            {
                this.cbSubDepartment.Items.Add(depSubDepartment.strName);
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

            //Fill cbBankName
            this.dtBankNames = Banking.GetBankNames(this.cnConnection);
            this.cbBankName.DataSource = this.dtBankNames;
            this.cbBankName.DisplayMember = "nvcName";
            this.cbBankName.SelectedIndex = -1;

            this.tbCoID.Text = this.emUpdate.strCoID;
            this.tbFirstName.Text = this.emUpdate.strFirstName;
            this.tbLastName.Text = this.emUpdate.strLastName;
            this.tbNationalID.Text = this.emUpdate.strNationalID;
            this.tbInsuranceNumber.Text = this.emUpdate.strInsuranceNumber;
            this.cbIsShiftMode.Checked = this.emUpdate.bolIsShiftMode;
            this.cbShiftType.Text = ((ShiftInfo.ShiftType)this.emUpdate.intShiftType).ToString();
            this.tbPhoneNumber.Text = this.emUpdate.strPhoneNumber;
            this.tbFatherName.Text = this.emUpdate.strFatherName;
            this.dtpBrightDate.Value = this.emUpdate.dtBirth;
            this.cbDepartments.Text = Department.GetNameByNumber(this.cnConnection, this.emUpdate.intDepartment);
            this.cbSubDepartment.Text = SubDepartment.GetNameByNumber(this.cnConnection, this.emUpdate.intDepartment, this.emUpdate.intSubDepartment);
            this.cbPosts.Text = ((Employee.PostType)this.emUpdate.intPost).ToString();
            this.cbEmploymentTypes.Text = ((Employee.EmploymentType)this.emUpdate.intEmploymentType).ToString();
            this.cbBankName.Text = this.emUpdate.bnkInfo.strBankName;
            this.tbBankAccount.Text = this.emUpdate.bnkInfo.strBankAccount;
            this.tbBankShaba.Text = this.emUpdate.bnkInfo.strBankShaba;
            this.tbBankAtmCard.Text = this.emUpdate.bnkInfo.strBankAtmCard;
            this.cbEducationLevels.Text = ((Employee.EducationLevel)this.emUpdate.intEducationLevel).ToString();
            this.cbLocationProvince.Text = this.emUpdate.strLocationProvince;
            this.tbLocationCounty.Text = this.emUpdate.strLocationCounty;
            this.tbLocationCityVillage.Text = this.emUpdate.strLocationCityVillage;
            this.tbLocationAddress.Text = this.emUpdate.strLocationAddress;
            this.tbPostalCode.Text = this.emUpdate.strPostalCode;

            this.tbNationalID.Text = this.emUpdate.strNationalID;

            SetEnableBtmOk();
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            this.btmOK.Enabled = false;

            this.emUpdate.strCoID = Language.GetEnglishText(this.tbCoID.Text);
            this.emUpdate.strFirstName = this.tbFirstName.Text.Trim();
            this.emUpdate.strLastName = this.tbLastName.Text.Trim();
            this.emUpdate.strNationalID = Language.GetEnglishText(this.tbNationalID.Text);
            this.emUpdate.strInsuranceNumber = this.tbInsuranceNumber.Text.Trim();
            this.emUpdate.bolIsShiftMode = this.cbIsShiftMode.Checked;
            this.emUpdate.intShiftType = this.cbShiftType.SelectedIndex + 1;
            this.emUpdate.strPhoneNumber = Language.GetEnglishText(this.tbPhoneNumber.Text);
            this.emUpdate.strFatherName = this.tbFatherName.Text.Trim();
            this.emUpdate.dtBirth = this.dtpBrightDate.Value;
            this.emUpdate.intDepartment = this.depDepartments[this.cbDepartments.SelectedIndex].intNumber;
            this.emUpdate.intSubDepartment = this.depSubDepartments[this.cbSubDepartment.SelectedIndex].intNumber;
            this.emUpdate.intPost = this.cbPosts.SelectedIndex + 1;
            this.emUpdate.intEmploymentType = this.cbEmploymentTypes.SelectedIndex + 1;
            this.emUpdate.bnkInfo.strBankName = this.cbBankName.Text;
            this.emUpdate.bnkInfo.strBankAccount = Language.GetEnglishText(this.tbBankAccount.Text);
            this.emUpdate.bnkInfo.strBankShaba = Language.GetEnglishText(this.tbBankShaba.Text);
            this.emUpdate.bnkInfo.strBankAtmCard = Language.GetEnglishText(this.tbBankAtmCard.Text);
            this.emUpdate.intEducationLevel = this.cbEducationLevels.SelectedIndex + 1;
            this.emUpdate.strLocationProvince = this.cbLocationProvince.SelectedItem.ToString();
            this.emUpdate.strLocationCounty = this.tbLocationCounty.Text.Trim();
            this.emUpdate.strLocationCityVillage = this.tbLocationCityVillage.Text.Trim();
            this.emUpdate.strLocationAddress = this.tbLocationAddress.Text.Trim();
            this.emUpdate.strPostalCode = Language.GetEnglishText(this.tbPostalCode.Text);
            this.emUpdate.Update(this.cnConnection);

            Employees frmEmployees = (Employees)this.Owner;
            frmEmployees.SearchEmployees();
            this.Close();
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetToNumbericText(KeyPressEventArgs kpeKeyPressArg)
        {
            if (!char.IsControl(kpeKeyPressArg.KeyChar) && !char.IsDigit(kpeKeyPressArg.KeyChar))
            {
                kpeKeyPressArg.Handled = true;
            }
        }

        private void SetToPersianText()
        {
            Language.SetFarsiLanguage();
        }

        private void SetEnableBtmOk()
        {
            bool bolShift = false;
            if (this.cbIsShiftMode.Checked && this.cbShiftType.SelectedIndex >= 0)
            {
                bolShift = true;
            }
            if (!this.cbIsShiftMode.Checked)
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

        private void tbCoID_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void tbCoID_Enter(object sender, EventArgs e)
        {
            SetToPersianText();
        }

        private void tbCoID_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetToNumbericText(e);
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void tbFirstName_Enter(object sender, EventArgs e)
        {
            SetToPersianText();
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void tbLastName_Enter(object sender, EventArgs e)
        {
            SetToPersianText();
        }

        private void tbNationalID_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void tbNationalID_Enter(object sender, EventArgs e)
        {
            SetToPersianText();
        }

        private void tbNationalID_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetToNumbericText(e);
        }

        private void tbInsuranceNumber_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void tbInsuranceNumber_Enter(object sender, EventArgs e)
        {
            SetToPersianText();
        }

        private void tbInsuranceNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetToNumbericText(e);
        }

        private void cbIsShiftMode_CheckedChanged(object sender, EventArgs e)
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

        private void tbPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void tbPhoneNumber_Enter(object sender, EventArgs e)
        {
            SetToPersianText();
        }

        private void tbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetToNumbericText(e);
        }

        private void tbFatherName_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void tbFatherName_Enter(object sender, EventArgs e)
        {
            SetToPersianText();
        }

        private void tbBankAccount_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void tbBankAccount_Enter(object sender, EventArgs e)
        {
            SetToPersianText();
        }

        private void tbBankAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetToNumbericText(e);
        }

        private void tbBankShaba_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void tbBankShaba_Enter(object sender, EventArgs e)
        {
            SetToPersianText();
        }

        private void tbBankShaba_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetToNumbericText(e);
        }

        private void tbBankAtmCard_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void tbBankAtmCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetToNumbericText(e);
        }

        private void tbBankAtmCard_Enter(object sender, EventArgs e)
        {
            SetToPersianText();
        }

        private void tbLocationCounty_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void tbLocationCounty_Enter(object sender, EventArgs e)
        {
            SetToPersianText();
        }

        private void tbLocationCityVillage_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void tbLocationCityVillage_Enter(object sender, EventArgs e)
        {
            SetToPersianText();
        }

        private void tbLocationAddress_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void tbLocationAddress_Enter(object sender, EventArgs e)
        {
            SetToPersianText();
        }

        private void tbPostalCode_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void tbPostalCode_Enter(object sender, EventArgs e)
        {
            SetToPersianText();
        }

        private void tbPostalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            SetToNumbericText(e);
        }
    }
}
