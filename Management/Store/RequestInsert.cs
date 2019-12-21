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
    public partial class RequestInsert : Form
    {
        public Request reqInsert;
        public Connection cnConnection;
        public FamSetting setSettings;
        public User usUser;
        private Category[] caCategories;
        private Department[] deDepartments; 
        private DataSet dsCurrentAffairs;
        private DataSet dsProjects;
        
        public RequestInsert()
        {
            InitializeComponent();

            this.reqInsert = new Request();
        }

        private void RequestInsert_Load(object sender, EventArgs e)
        {
            //Fill cbCategory
            this.caCategories = Category.GetCategories(this.cnConnection);
            foreach (Category ctCategory in this.caCategories)
            {
                this.cbCategory.Items.Add(ctCategory.strName);
            }

            //cbDepartment
            this.deDepartments = Department.GetDepartments(this.cnConnection);
            foreach (Department deDepartment in this.deDepartments)
            {
                this.cbDepartment.Items.Add(deDepartment.strName);
            }
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            this.reqInsert.intDepartment = this.deDepartments[this.cbDepartment.SelectedIndex].intNumber;
            this.reqInsert.dtDate = this.dtpDate.Value;
            if (this.cbRowBudget.SelectedIndex < this.dsCurrentAffairs.Tables["tabCurrentAffairs"].Rows.Count)
            {
                this.reqInsert.intRowBudget = (int)this.dsCurrentAffairs.Tables["tabCurrentAffairs"].Rows[this.cbRowBudget.SelectedIndex]["intNumber"];
            }
            if (this.cbRowBudget.SelectedIndex >= this.dsCurrentAffairs.Tables["tabCurrentAffairs"].Rows.Count)
            {
                this.reqInsert.intRowBudget =
                    (int)this.dsProjects.Tables["tabProjects"].Rows[(this.cbRowBudget.SelectedIndex - this.dsCurrentAffairs.Tables["tabCurrentAffairs"].Rows.Count)]["intNumber"];
            }
          
            reqInsert.Insert(this.cnConnection);

            Requests frmInvoices = (Requests)this.Owner;
            frmInvoices.SearchRequests();
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

        private void ButEmployee1_Click(object sender, EventArgs e)
        {
            SelectEmployee frmSelectEmployee = new SelectEmployee();
            frmSelectEmployee.Owner = this;
            frmSelectEmployee.setSettings = this.setSettings;
            frmSelectEmployee.usUser = this.usUser;
            frmSelectEmployee.cnConnection = this.cnConnection;
            frmSelectEmployee.ShowDialog();
            this.reqInsert.strRequesterCoID = SelectEmployee.strCoID;
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
            this.reqInsert.strSupervisorCoID = SelectEmployee.strCoID;
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
            this.reqInsert.strPlantmanagerCoID = SelectEmployee.strCoID;
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
            this.reqInsert.strCeoCoID = SelectEmployee.strCoID;
            this.labEmployee4.Text = SelectEmployee.strEmployeeName;

            SetEnableBtmOk();
        }

        private void SetEnableBtmOk()
        {
            if (this.reqInsert.strRequesterCoID.Length != 0 && this.reqInsert.strSupervisorCoID.Length != 0 &&
              this.reqInsert.strPlantmanagerCoID.Length != 0 && this.reqInsert.strCeoCoID.Length != 0 &&
              this.cbRowBudget.SelectedIndex > -1 && this.cbDepartment.SelectedIndex > -1 )
            {
                this.btmOK.Enabled = true;
            }
            else
            {
                this.btmOK.Enabled = false;
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

        private void LabEmployee1_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }
    }
}
