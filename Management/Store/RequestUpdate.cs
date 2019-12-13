using Baran.Ferroalloy.Automation;
using Baran.Ferroalloy.Automation.Security;
using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Finance;
using Baran.Ferroalloy.Maintenance;
using Baran.Ferroalloy.Office;
using Baran.Ferroalloy.Store;
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
    public partial class RequestUpdate : Form
    {
        public Request reqUpdate;
        public Connection cnConnection;
        public User usUser;
        public FamSetting setSettings;
        private Category[] caCategories;
        private Department[] deDepartments;
        private DataSet dsCurrentAffairs;
        private DataSet dsProjects;

        public RequestUpdate()
        {
            InitializeComponent();

            this.reqUpdate = new Request();
        }

        private void RequestUpdate_Load(object sender, EventArgs e)
        {
            //Fill cbCategory ComboBox
            this.caCategories = Category.GetCategories(this.cnConnection);
            foreach (Category ctCategory in this.caCategories)
            {
                this.cbCategory.Items.Add(ctCategory.strName);
            }

            //Fill deDepartments
            this.deDepartments = Department.GetDepartments(this.cnConnection);
            foreach (Department deDepartment in this.deDepartments)
            {
                this.cbDepartment.Items.Add(deDepartment.strName);
            }

            //Fill cbRowBudget
            this.cbRowBudget.Items.Clear();
            this.dsCurrentAffairs = CurrentAffairs.GetCurrentAffairs(this.cnConnection);
            foreach (DataRow drCurrentAffair in this.dsCurrentAffairs.Tables["tabCurrentAffairs"].Rows)
            {
                this.cbRowBudget.Items.Add(drCurrentAffair["nvcName"].ToString());
            }
            Project proSearch = new Project();
            proSearch.intCategory = Category.GetNumberByName(this.cnConnection, this.cbCategory.Text);
            this.dsProjects = Project.GetProjects(this.cnConnection, proSearch);
            foreach (DataRow drCurrentAffair in this.dsProjects.Tables["tabProjects"].Rows)
            {
                this.cbRowBudget.Items.Add(drCurrentAffair["nvcName"].ToString());
            }

            //Fill Controls with Part Properties
            this.tbNumber.Text = this.reqUpdate.intNumber.ToString();
            this.cbDepartment.Text = Department.GetNameByNumber(this.cnConnection, this.reqUpdate.intDepartment);
            this.dtpDate.Value = this.reqUpdate.dtDate;
            if(this.reqUpdate.intRowBudget < 100)
            {
                this.cbRowBudget.Text = CurrentAffairs.GetNameByNumber(this.cnConnection,this.reqUpdate.intRowBudget);
            }
            if (this.reqUpdate.intRowBudget >= 100)
            {
                this.cbCategory.Text =
                    Category.GetNameByNumber(this.cnConnection, Project.GetCategoryByNumber(this.cnConnection, this.reqUpdate.intRowBudget));
                this.cbRowBudget.Text = Project.GetNameByNumber(this.cnConnection, this.reqUpdate.intRowBudget); 
            }
            this.labEmployee1.Text = Employee.GetNameByCoID(this.cnConnection,this.reqUpdate.strRequesterCoID);
            this.labEmployee2.Text = Employee.GetNameByCoID(this.cnConnection, this.reqUpdate.strSupervisorCoID);
            this.labEmployee3.Text = Employee.GetNameByCoID(this.cnConnection, this.reqUpdate.strPlantmanagerCoID);
            this.labEmployee4.Text = Employee.GetNameByCoID(this.cnConnection, this.reqUpdate.strCeoCoID);

            SetEnableBtmOk();
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            if (this.cbRowBudget.SelectedIndex < this.dsCurrentAffairs.Tables["tabCurrentAffairs"].Rows.Count)
            {
                this.reqUpdate.intRowBudget = (int)this.dsCurrentAffairs.Tables["tabCurrentAffairs"].Rows[this.cbRowBudget.SelectedIndex]["intNumber"];
            }
            if (this.cbRowBudget.SelectedIndex >= this.dsCurrentAffairs.Tables["tabCurrentAffairs"].Rows.Count)
            {
                this.reqUpdate.intRowBudget =
                    (int)this.dsProjects.Tables["tabProjects"].Rows[(this.cbRowBudget.SelectedIndex - this.dsCurrentAffairs.Tables["tabCurrentAffairs"].Rows.Count)]["intNumber"];
            }
            this.reqUpdate.intDepartment = this.deDepartments[this.cbDepartment.SelectedIndex].intNumber;
            this.reqUpdate.intNumber = int.Parse(this.tbNumber.Text.Trim());
            this.reqUpdate.dtDate = this.dtpDate.Value;
            this.reqUpdate.Update(this.cnConnection);

            Requests frmRequests = (Requests)this.Owner;
            frmRequests.SearchRequests();
            this.Close();
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbRowBudget.Items.Clear();

            this.dsCurrentAffairs = CurrentAffairs.GetCurrentAffairs(this.cnConnection);
            foreach (DataRow drCurrentAffair in this.dsCurrentAffairs.Tables["tabCurrentAffairs"].Rows)
            {
                this.cbRowBudget.Items.Add(drCurrentAffair["nvcName"].ToString());
            }

            Project proSearch = new Project();
            proSearch.intCategory = Category.GetNumberByName(this.cnConnection, this.cbCategory.Text);
            this.dsProjects = Project.GetProjects(this.cnConnection, proSearch);
            foreach (DataRow drCurrentAffair in this.dsProjects.Tables["tabProjects"].Rows)
            {
                this.cbRowBudget.Items.Add(drCurrentAffair["nvcName"].ToString());
            }
        }

        private void CbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void CbRowBudget_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void DtpDate_ValueChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void ButEmployee1_Click(object sender, EventArgs e)
        {
            SelectEmployee frmSelectEmployee = new SelectEmployee();
            frmSelectEmployee.Owner = this;
            frmSelectEmployee.cnConnection = this.cnConnection;
            frmSelectEmployee.setSettings = this.setSettings;
            frmSelectEmployee.usUser = this.usUser;
            frmSelectEmployee.ShowDialog();
            this.reqUpdate.strRequesterCoID = SelectEmployee.strCoID;
            this.labEmployee1.Text = SelectEmployee.strEmployeeName;

            SetEnableBtmOk();
        }

        private void ButEmployee2_Click(object sender, EventArgs e)
        {
            SelectEmployee frmSelectEmployee = new SelectEmployee();
            frmSelectEmployee.Owner = this;
            frmSelectEmployee.cnConnection = this.cnConnection;
            frmSelectEmployee.setSettings = this.setSettings;
            frmSelectEmployee.usUser = this.usUser;
            frmSelectEmployee.ShowDialog();
            this.reqUpdate.strSupervisorCoID = SelectEmployee.strCoID;
            this.labEmployee2.Text = SelectEmployee.strEmployeeName;

            SetEnableBtmOk();
        }

        private void ButEmployee3_Click(object sender, EventArgs e)
        {
            SelectEmployee frmSelectEmployee = new SelectEmployee();
            frmSelectEmployee.Owner = this;
            frmSelectEmployee.cnConnection = this.cnConnection;
            frmSelectEmployee.setSettings = this.setSettings;
            frmSelectEmployee.usUser = this.usUser;
            frmSelectEmployee.ShowDialog();
            this.reqUpdate.strPlantmanagerCoID = SelectEmployee.strCoID;
            this.labEmployee3.Text = SelectEmployee.strEmployeeName;

            SetEnableBtmOk();
        }

        private void ButEmployee4_Click(object sender, EventArgs e)
        {
            SelectEmployee frmSelectEmployee = new SelectEmployee();
            frmSelectEmployee.Owner = this;
            frmSelectEmployee.cnConnection = this.cnConnection;
            frmSelectEmployee.setSettings = this.setSettings;
            frmSelectEmployee.usUser = this.usUser;
            frmSelectEmployee.ShowDialog();
            this.reqUpdate.strCeoCoID = SelectEmployee.strCoID;
            this.labEmployee4.Text = SelectEmployee.strEmployeeName;

            SetEnableBtmOk();
        }

        private void SetEnableBtmOk()
        {
            if (this.reqUpdate.strRequesterCoID.Length != 0 && this.reqUpdate.strSupervisorCoID.Length != 0 &&
               this.reqUpdate.strPlantmanagerCoID.Length != 0 && this.reqUpdate.strCeoCoID.Length != 0 &&
               this.cbRowBudget.SelectedIndex > -1 && this.cbDepartment.SelectedIndex > -1 &&
               this.tbNumber.Text.Trim().Length != 0 )
            {
                this.btmOK.Enabled = true;
            }
            else
            {
                this.btmOK.Enabled = false;
            }
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

        private void TbNumber_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }
    }
}
