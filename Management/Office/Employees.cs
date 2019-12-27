using Baran.Ferroalloy.Automation;
using Baran.Ferroalloy.Automation.Security;
using Baran.Ferroalloy.Automation.SqlDataBase;
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
    public partial class Employees : Form
    {
        public static Boolean bolIsRunning;
        public Connection cnConnection;
        public FamSetting setSettings;
        public User usUser;
        private Employee emSearch;
        public DataTable dtEmployees;
        private Department[] depDepartments;
        public static bool bolWritePermision;
        private bool bolEnableBtmSearchByInterface;
        private bool bolEnableBtmSearchByPermision;
        private bool bolEnableBtmDeleteByInterface;
        private bool bolEnableBtmDeleteByPermision;
        private bool bolEnableBtmInsertByInterface;
        private bool bolEnableBtmInsertByPermision;

        public Employees()
        {
            InitializeComponent();

            bolIsRunning = true;
           
            this.emSearch = new Employee();
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

            //Fill cbDepartments ComboBox
            this.depDepartments = Department.GetDepartments(this.cnConnection);
            this.cbDepartments.Items.Add("");
            foreach (Department depDepartment in this.depDepartments)
            {
                this.cbDepartments.Items.Add(depDepartment.strName);
            }
        }

        private void SetComponentsByPermisions()
        {
            if(this.usUser.bolOfficeEnabed)
            {
                this.bolEnableBtmSearchByPermision = true;
                this.bolEnableBtmDeleteByPermision = true;
                this.bolEnableBtmInsertByPermision = true;
                this.dgvEmployees.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmployees_CellMouseDoubleClick);
                this.dgvEmployees.Columns["bitSelect"].Visible = true;
            }
            else
            {
                this.bolEnableBtmSearchByPermision = true;
                this.bolEnableBtmDeleteByPermision = false;
                this.bolEnableBtmInsertByPermision = false;
                this.dgvEmployees.CellMouseDoubleClick -= new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmployees_CellMouseDoubleClick);
                this.dgvEmployees.Columns["bitSelect"].Visible = false;
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

        private void Employees_FormClosing(object sender, FormClosingEventArgs e)
        {
            bolIsRunning = false;

            Management frmManagement = (Management)this.MdiParent;
            frmManagement.menWindows.DropDownItems["menWindowsEmployees"].Dispose();
        }

        private void btmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmSearch_Click(object sender, EventArgs e)
        {
            this.btmSearch.Enabled = false;
            SearchEmployees();
            this.btmSearch.Enabled = true;
        }

        public void SearchEmployees()
        {
            this.emSearch.strFirstName = this.tbFirstName.Text.Trim();
            this.emSearch.strLastName = this.tbLastName.Text.Trim();
            this.emSearch.strCoID = this.tbCoID.Text.Trim();
            if(this.cbDepartments.SelectedIndex >= 1)
            {
                this.emSearch.intDepartment = this.depDepartments[this.cbDepartments.SelectedIndex - 1].intNumber;
            }
            this.emSearch.strNationalID = this.tbNationalID.Text.Trim();
            this.dtEmployees = Employee.GetEmployees(this.cnConnection, this.emSearch);
            
            //Set DataGridView
            this.dgvEmployees.DataSource = dtEmployees;

            UpdateDgvFields();
        }

        private void UpdateDgvFields()
        {
            for (int i = 0; i < this.dtEmployees.Rows.Count; i++)
            {
                this.dgvEmployees.Rows[i].Cells["intDepartmentAsName"].Value =
                    Department.GetNameByNumber(cnConnection, (int)this.dgvEmployees.Rows[i].Cells["intDepartment"].Value);

                SubDepartment sdSubDepartment = new SubDepartment();
                sdSubDepartment.intDepartmnt = (int)this.dgvEmployees.Rows[i].Cells["intDepartment"].Value;
                sdSubDepartment.intNumber = (int)this.dgvEmployees.Rows[i].Cells["intSubDepartment"].Value;
                this.dgvEmployees.Rows[i].Cells["intSubDepartmentAsName"].Value = 
                    SubDepartment.GetNameByNumber(cnConnection, sdSubDepartment.intDepartmnt, sdSubDepartment.intNumber);

                this.dgvEmployees.Rows[i].Cells["intEducationLevelAsName"].Value = (Employee.EducationLevel)this.dgvEmployees.Rows[i].Cells["intEducationLevel"].Value;

                this.dgvEmployees.Rows[i].Cells["intEmploymentTypeAsName"].Value = (Employee.EmploymentType)this.dgvEmployees.Rows[i].Cells["intEmploymentType"].Value;

                this.dgvEmployees.Rows[i].Cells["intPostAsName"].Value = 
                    Post.GetNameByNumber(this.cnConnection,(int)this.dgvEmployees.Rows[i].Cells["intPost"].Value);

                if((bool)this.dgvEmployees.Rows[i].Cells["bitIsShiftMode"].Value)
                {
                    this.dgvEmployees.Rows[i].Cells["bitIsShiftModeAsName"].Value = "بله";
                }
                else
                {
                    this.dgvEmployees.Rows[i].Cells["bitIsShiftModeAsName"].Value = "خیر";
                }

                if((int)this.dgvEmployees.Rows[i].Cells["intShiftType"].Value == -1)
                {
                    this.dgvEmployees.Rows[i].Cells["intShiftTypeAsName"].Value = "-";
                }
                else
                {
                    this.dgvEmployees.Rows[i].Cells["intShiftTypeAsName"].Value = 
                        ((ShiftInfo.ShiftType)this.dgvEmployees.Rows[i].Cells["intShiftType"].Value).ToString();
                }
            }
        }

        private void btmDelete_Click(object sender, EventArgs e)
        {
            Int16 intSelectedEmployees = 0;
            foreach (DataRow drEmployee in this.dtEmployees.Rows)
            {
                if ((bool)drEmployee["bitSelect"])
                {
                    ++intSelectedEmployees;
                }
            }

            if (intSelectedEmployees > 0)
            {
                DialogResult dialogResult = MessageBox.Show("آیا می خواهید " + intSelectedEmployees.ToString() + " کارمند را حذف کنید؟", "حذف", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.btmDelete.Enabled = false;
                    Employee.DeleteEmployees(this.cnConnection, this.dtEmployees);
                    SearchEmployees();
                    this.btmDelete.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show(".هیچ کارمندی انتخاب نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void dgvEmployees_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(this.dgvEmployees.SelectedRows.Count == 1 && this.dgvEmployees.SelectedRows[0].Index != -1)
            {
                EmployeeUpdate frmEmployeeUpdate = new EmployeeUpdate();
                frmEmployeeUpdate.Owner = this;
                frmEmployeeUpdate.cnConnection = this.cnConnection;

                Employee emEmployee = new Employee();
                emEmployee.intID = (int)this.dgvEmployees.Rows[e.RowIndex].Cells["intID"].Value;
                emEmployee.strCoID = this.dgvEmployees.Rows[e.RowIndex].Cells["nvcCoID"].Value.ToString();
                emEmployee.strFirstName = this.dgvEmployees.Rows[e.RowIndex].Cells["nvcFirstName"].Value.ToString();
                emEmployee.strLastName = this.dgvEmployees.Rows[e.RowIndex].Cells["nvcLastName"].Value.ToString();
                emEmployee.strNationalID = this.dgvEmployees.Rows[e.RowIndex].Cells["nvcNationalID"].Value.ToString();
                emEmployee.strInsuranceNumber = this.dgvEmployees.Rows[e.RowIndex].Cells["nvcCoID"].Value.ToString();
                emEmployee.bolIsShiftMode = (bool)this.dgvEmployees.Rows[e.RowIndex].Cells["bitIsShiftMode"].Value;
                emEmployee.intShiftType = (int)this.dgvEmployees.Rows[e.RowIndex].Cells["intShiftType"].Value;
                emEmployee.strPhoneNumber = this.dgvEmployees.Rows[e.RowIndex].Cells["nvcMobileNumber"].Value.ToString();
                emEmployee.strFatherName = this.dgvEmployees.Rows[e.RowIndex].Cells["nvcFatherName"].Value.ToString();
                emEmployee.dtBirth = (DateTime)this.dgvEmployees.Rows[e.RowIndex].Cells["datBirth"].Value;
                emEmployee.intDepartment = (int)this.dgvEmployees.Rows[e.RowIndex].Cells["intDepartment"].Value;
                emEmployee.intSubDepartment = (int)this.dgvEmployees.Rows[e.RowIndex].Cells["intSubDepartment"].Value;
                emEmployee.intPost = (int)this.dgvEmployees.Rows[e.RowIndex].Cells["intPost"].Value;
                emEmployee.intEmploymentType = (int)this.dgvEmployees.Rows[e.RowIndex].Cells["intEmploymentType"].Value;
                emEmployee.bnkInfo.strBankName = this.dgvEmployees.Rows[e.RowIndex].Cells["nvcName"].Value.ToString();
                emEmployee.bnkInfo.strBankAccount = this.dgvEmployees.Rows[e.RowIndex].Cells["nvcAccount"].Value.ToString();
                emEmployee.bnkInfo.strBankShaba = this.dgvEmployees.Rows[e.RowIndex].Cells["nvcShaba"].Value.ToString();
                emEmployee.bnkInfo.strBankAtmCard = this.dgvEmployees.Rows[e.RowIndex].Cells["nvcAtmCard"].Value.ToString();
                emEmployee.intEducationLevel = (int)this.dgvEmployees.Rows[e.RowIndex].Cells["intEducationLevel"].Value;
                emEmployee.strLocationProvince = this.dgvEmployees.Rows[e.RowIndex].Cells["nvcLocationProvince"].Value.ToString();
                emEmployee.strLocationCounty = this.dgvEmployees.Rows[e.RowIndex].Cells["nvcLocationCounty"].Value.ToString();
                emEmployee.strLocationCityVillage = this.dgvEmployees.Rows[e.RowIndex].Cells["nvcLocationCityVillage"].Value.ToString();
                emEmployee.strLocationAddress = this.dgvEmployees.Rows[e.RowIndex].Cells["nvcLocationAddress"].Value.ToString();
                emEmployee.strPostalCode = this.dgvEmployees.Rows[e.RowIndex].Cells["nvcCoID"].Value.ToString();


                frmEmployeeUpdate.emUpdate = emEmployee;

                frmEmployeeUpdate.ShowDialog();
            }
        }

        private void btmInsert_Click(object sender, EventArgs e)
        {
            this.btmInsert.Enabled = false;
            EmployeeInsert frmEmployeeInsert = new EmployeeInsert();
            frmEmployeeInsert.Owner = this;
            frmEmployeeInsert.cnConnection = this.cnConnection;
            frmEmployeeInsert.ShowDialog();
            this.btmInsert.Enabled = true;
        }

        private void Employees_Enter(object sender, EventArgs e)
        {
           
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
            if(this.tbFirstName.Text.Trim().Length != 0 || this.tbLastName.Text.Trim().Length != 0 ||
                this.cbDepartments.SelectedIndex >= 1 || this.tbCoID.Text.Trim().Length != 0 ||
                this.tbNationalID.Text.Trim().Length != 0)
            {
                this.bolEnableBtmSearchByInterface = true;
            }
            else
            {
                this.bolEnableBtmSearchByInterface = false;
            }

            SetEnableComponents();
        }

        private void DgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvEmployees.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void DgvEmployees_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.bolEnableBtmDeleteByInterface = false;

            for (int i = 0; i < this.dgvEmployees.Rows.Count; i++)
            {
                if ((bool)this.dgvEmployees.Rows[i].Cells["bitSelect"].Value)
                {
                    this.bolEnableBtmDeleteByInterface = true;
                }
            }

            SetEnableComponents();
        }

        private void DgvEmployees_Sorted(object sender, EventArgs e)
        {
            UpdateDgvFields(); 
        }

        private void TbFirstName_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmSearch();
        }

        private void TbLastName_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmSearch();
        }

        private void TbNationalID_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmSearch();
        }

        private void TbCoID_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmSearch();
        }

        private void CbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmSearch();
        }

        private void Employees_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    btmSearch_Click(new object(), new EventArgs());
                    break;
                case Keys.F3:
                    btmDelete_Click(new object(), new EventArgs());
                    break;
                case Keys.F4:
                    btmInsert_Click(new object(), new EventArgs());
                    break;
                case Keys.F5:
                    btmExit_Click(new object(), new EventArgs());
                    break;
                case Keys.F7:
                    dgvEmployees_CellMouseDoubleClick(new object(),new DataGridViewCellMouseEventArgs(0,0,0,0,new MouseEventArgs( MouseButtons.Left,0,0,0,0)));
                    break;
                case Keys.F10:
                    Application.Exit();
                    break;
            }
        }
    }
}
