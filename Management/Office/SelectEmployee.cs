using Baran.Ferroalloy.Automation;
using Baran.Ferroalloy.Automation.Security;
using Baran.Ferroalloy.Automation.SqlDataBase;
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
    public partial class SelectEmployee : Form
    {
        public Connection cnConnection;
        public User usUser;
        public FamSetting setSettings;
        private Employee emSearch;
        public DataTable dtEmployees;
        private Department[] depDepartments;
        public static string strCoID;
        public static string strEmployeeName;

        public SelectEmployee()
        {
            InitializeComponent();

            SelectEmployee.strCoID = "";
            SelectEmployee.strEmployeeName = "";

            this.emSearch = new Employee();
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
            if (this.usUser.bolOfficeEnabed)
            {
                this.btmInsertEmployee.Enabled = true;
            }
            else
            {
                this.btmInsertEmployee.Enabled = false;
            }
        }
            private void Employees_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void btmSearch_Click(object sender, EventArgs e)
        {
            SearchEmployees();
        }

        public void SearchEmployees()
        {
            this.emSearch.strFirstName = this.tbFirstName.Text.Trim();
            this.emSearch.strLastName = this.tbLastName.Text.Trim();
            this.emSearch.strCoID = this.tbCoID.Text.Trim();
            this.emSearch.intDepartment = Department.GetNumberByName(this.cnConnection,this.cbDepartments.Text);

            this.dtEmployees = Employee.GetEmployees(this.cnConnection, this.emSearch);

            //Set DataGridView
            this.dgvEmployees.DataSource = dtEmployees;
            
            for (int i=0;i<this.dgvEmployees.Rows.Count;i++)
            {
                this.dgvEmployees.Rows[i].Cells["intDepartmentAsName"].Value = 
                    Department.GetNameByNumber(this.cnConnection,(int)this.dgvEmployees.Rows[i].Cells["intDepartment"].Value);
            }
        }

        private void BtmSelect_Click(object sender, EventArgs e)
        {
            if (!this.cbNoName.Checked)
            {
                if (this.dgvEmployees.SelectedRows.Count == 1)
                {
                    SelectEmployee.strCoID = this.dgvEmployees.SelectedRows[0].Cells["nvcCoID"].Value.ToString();
                    SelectEmployee.strEmployeeName = this.dgvEmployees.SelectedRows[0].Cells["nvcFirstName"].Value.ToString() + " " +
                        this.dgvEmployees.SelectedRows[0].Cells["nvcLastName"].Value.ToString();
                }
            }
            else
            {
                SelectEmployee.strCoID = "-1";
                SelectEmployee.strEmployeeName = "بی‌نام";
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
                this.tbCoID.Text.Trim().Length != 0 || this.cbDepartments.SelectedIndex >= 1 || this.cbNoName.Checked)
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
            if (this.cbNoName.Checked)
            {
                this.dtEmployees = new DataTable();
                this.dgvEmployees.DataSource = this.dtEmployees;
                this.dgvEmployees.DataMember = "";

                this.dgvEmployees.Enabled = false;
                this.tbFirstName.Text = "";
                this.tbFirstName.Enabled = false;
                this.tbLastName.Text = "";
                this.tbLastName.Enabled = false;
                this.btmSearch.Enabled = false;
                this.tbCoID.Text = "";
                this.tbCoID.Enabled = false;
                this.cbDepartments.SelectedIndex = 0;
                this.cbDepartments.Enabled = false;
            }
            else
            {
                this.dgvEmployees.Enabled = true;
                this.tbFirstName.Enabled = true;
                this.tbLastName.Enabled = true;
                this.btmSearch.Enabled = true;
                this.tbCoID.Enabled = true;
                this.cbDepartments.Enabled = true;
            }

            SetEnableBtmSelect();
        }

        private void DgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void TbCoID_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmSelect();
        }

        private void CbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmSelect();
        }

        private void TbLastName_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmSelect();
        }

        private void TbFirstName_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmSelect();
        }

        private void DgvEmployees_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dgvEmployees.Rows.Count; i++)
            {
                this.dgvEmployees.Rows[i].Cells["intDepartmentAsName"].Value =
                    Department.GetNameByNumber(this.cnConnection, (int)this.dgvEmployees.Rows[i].Cells["intDepartment"].Value);
            }
        }

        private void DgvEmployees_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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

        private void BtmInsertEmployee_Click(object sender, EventArgs e)
        {
            EmployeeInsert frmEmployeeInsert = new EmployeeInsert();
            frmEmployeeInsert.cnConnection = this.cnConnection;
            frmEmployeeInsert.setSetings = this.setSettings;
            frmEmployeeInsert.usUser = this.usUser;
            frmEmployeeInsert.ShowDialog();
        }
    }
}
