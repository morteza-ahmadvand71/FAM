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
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baran.Ferroalloy.Management
{
    public partial class SelectRequest : Form
    {
        public Connection cnConnection;
        public User usUser;
        public FamSetting setSettings;
        private Category[] caCategories;
        private Department[] deDepartments;
        public DataSet dsRequests;
        private Request reqSearch;
        private DataSet dsCurrentAffairs;
        private DataSet dsProjects;
        public static string strRequestName;
        public static int intRequestNumber;


        public SelectRequest()
        {
            InitializeComponent();

            SelectRequest.intRequestNumber = 0;
            SelectRequest.strRequestName = "";
        }

        private void Requests_Load(object sender, EventArgs e)
        {
            SetComponentsByPermisions();

            this.reqSearch = new Request();
      
            //Fill cbCategory ComboBox
            this.caCategories = Category.GetCategories(this.cnConnection);
            this.cbCategory.Items.Add("");
            foreach (Category ctCategory in this.caCategories)
            {
                this.cbCategory.Items.Add(ctCategory.strName);
            }

            //cbDepartment
            this.deDepartments = Department.GetDepartments(this.cnConnection);
            foreach (Department deDepartment in this.deDepartments)
            {
                this.cbDepartments.Items.Add(deDepartment.strName);
            }
        }

        private void SetComponentsByPermisions()
        {
            if (this.usUser.bolStoreEnabed)
            {
                this.btmInsertRequest.Enabled = true;
            }
            else
            {
                this.btmInsertRequest.Enabled = false;
            }
        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Requests_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmSearch_Click(object sender, EventArgs e)
        {
            SearchRequests();
        }

        public void SearchRequests()
        {
           // this.reqSearch = new Request();
            DateTime dtFromLoc = new DateTime();
            DateTime dtToLoc = new DateTime();

            try
            {
                this.reqSearch.intNumber = int.Parse(this.tbNumber.Text);
            }
            catch (System.FormatException)
            {

            }
            this.reqSearch.intDepartment = Category.GetNumberByName(this.cnConnection,this.cbCategory.Text);

            if(this.cbRowBudget.SelectedIndex >= 1)
            {
                if(this.cbRowBudget.SelectedIndex <= this.dsCurrentAffairs.Tables["tabCurrentAffairs"].Rows.Count)
                {
                    this.reqSearch.intRowBudget = (int)this.dsCurrentAffairs.Tables["tabCurrentAffairs"].Rows[this.cbRowBudget.SelectedIndex-1]["intNumber"];
                }

                if (this.cbRowBudget.SelectedIndex > this.dsCurrentAffairs.Tables["tabCurrentAffairs"].Rows.Count)
                {
                    this.reqSearch.intRowBudget = 
                        (int)this.dsProjects.Tables["tabProjects"].Rows[(this.cbRowBudget.SelectedIndex - this.dsCurrentAffairs.Tables["tabCurrentAffairs"].Rows.Count)-1]["intNumber"];
                }
            }


            if (this.cbDate.Checked)
            {
                dtFromLoc = this.dtpFrom.Value;
                dtToLoc = this.dtpTo.Value;
            }
            
            this.dsRequests = Request.GetRequests(this.cnConnection, this.reqSearch, dtFromLoc, dtToLoc);

            this.dgvRequests.DataSource = this.dsRequests;
            this.dgvRequests.DataMember = "tabRequests";

            for (int i=0;i<this.dsRequests.Tables["tabRequests"].Rows.Count; ++i)
            {
                this.dgvRequests.Rows[i].Cells["intRowBudgetText"].Value = 
                    Project.GetNameByNumber(this.cnConnection, (int)this.dsRequests.Tables["tabRequests"].Rows[i]["intRowBudget"]);

                this.dgvRequests.Rows[i].Cells["intDepartment"].Value = 
                    Department.GetNameByNumber(this.cnConnection, (int)this.dsRequests.Tables["tabRequests"].Rows[i]["intDepartment"]);

                this.dgvRequests.Rows[i].Cells["nvcRequesterCoIdByName"].Value =
                    Employee.GetNameByCoID(this.cnConnection, this.dsRequests.Tables["tabRequests"].Rows[i]["nvcRequesterCoID"].ToString());
            }
        }


        private void CbDate_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbDate.Checked)
            {
                this.dtpFrom.Enabled = true;
                this.labFromDate.Enabled = true;
                this.dtpTo.Enabled = true;
                this.labToDate.Enabled = true;
            }
            else
            {
                this.dtpFrom.Enabled = false;
                this.labFromDate.Enabled = false;
                this.dtpTo.Enabled = false;
                this.labToDate.Enabled = false;
            }

            SetEnableBtmSelect();
        }

        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbRowBudget.Items.Clear();
            this.cbRowBudget.Items.Add("");

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

            SetEnableBtmSelect();
        }

        private void BtmSelect_Click(object sender, EventArgs e)
        {
            if (!this.cbNoName.Checked)
            {
                if (this.dgvRequests.SelectedRows.Count == 1)
                {
                    SelectRequest.intRequestNumber = (int)this.dgvRequests.SelectedRows[0].Cells["intNumber"].Value;
                    SelectRequest.strRequestName = Request.GetNameByNumner(this.cnConnection, (int)this.dgvRequests.SelectedRows[0].Cells["intNumber"].Value);
                }
            }
            else
            {
                SelectRequest.intRequestNumber = -1;
                SelectRequest.strRequestName = "بدون درخواست";
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
            if (this.tbNumber.Text.Trim().Length != 0 || this.reqSearch.strRequesterCoID.Length != 0 ||
                this.cbDate.Checked || this.cbCategory.SelectedIndex >= 1 || this.cbDepartments.SelectedIndex >= 1 ||
                this.cbRowBudget.SelectedIndex >= 1)
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
                this.dsRequests = new DataSet();
                this.dgvRequests.DataSource = this.dsRequests;
                this.dgvRequests.DataMember = "";

                this.dgvRequests.Enabled = false;
                this.tbNumber.Text = "";
                this.tbNumber.Enabled = false;
                this.btmEmployee.Enabled = false;
                this.btmSearch.Enabled = false;
                this.cbDate.Checked = false;
                this.cbDate.Enabled = false;
                this.cbDepartments.SelectedIndex = 0;
                this.cbDepartments.Enabled = false;
                this.cbCategory.SelectedIndex = 0;
                this.cbCategory.Enabled = false; 
                this.cbRowBudget.SelectedIndex = 0;
                this.cbRowBudget.Enabled = false;
                this.btmSelect.Enabled = true;
            }
            else
            {
                this.dgvRequests.Enabled = true;
                this.tbNumber.Enabled = true;
                this.btmEmployee.Enabled = true;
                this.btmSearch.Enabled = true;
                this.cbDate.Checked = true;
                this.cbDate.Enabled = true;
                this.cbDepartments.Enabled = true;
                this.cbCategory.Enabled = true;
                this.cbRowBudget.Enabled = true;
                this.btmSelect.Enabled = false;
            }

            SetEnableBtmSelect();
        }

        private void btmEmployee_Click(object sender, EventArgs e)
        {
            SelectEmployee frmSelectEmployee = new SelectEmployee();
            frmSelectEmployee.Owner = this;
            frmSelectEmployee.cnConnection = this.cnConnection;
            frmSelectEmployee.ShowDialog();

            if(SelectEmployee.strCoID != "")
            {
                this.reqSearch.strRequesterCoID = SelectEmployee.strCoID;
                this.labEmployee.Text = SelectEmployee.strEmployeeName;
            }
            
            SetEnableBtmSelect();
        }

        private void DgvRequests_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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

        private void CbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmSelect();
        }

        private void CbRowBudget_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmSelect();
        }

        private void TbNumber_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmSelect();
        }

        private void DgvRequests_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dsRequests.Tables["tabRequests"].Rows.Count; ++i)
            {
                this.dgvRequests.Rows[i].Cells["intRowBudgetText"].Value =
                    Project.GetNameByNumber(this.cnConnection, (int)this.dsRequests.Tables["tabRequests"].Rows[i]["intRowBudget"]);

                this.dgvRequests.Rows[i].Cells["intDepartment"].Value =
                    Department.GetNameByNumber(this.cnConnection, (int)this.dsRequests.Tables["tabRequests"].Rows[i]["intDepartment"]);

                this.dgvRequests.Rows[i].Cells["nvcRequesterCoIdByName"].Value =
                    Employee.GetNameByCoID(this.cnConnection, this.dsRequests.Tables["tabRequests"].Rows[i]["nvcRequesterCoID"].ToString());
            }
        }

        private void BtmInsertRequest_Click(object sender, EventArgs e)
        {
            RequestInsert frmRequestInsert = new RequestInsert();
            frmRequestInsert.cnConnection = this.cnConnection;
            frmRequestInsert.setSettings = this.setSettings;
            frmRequestInsert.usUser = this.usUser;
            frmRequestInsert.ShowDialog();
        }
    }
}
