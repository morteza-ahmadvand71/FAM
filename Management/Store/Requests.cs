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
    public partial class Requests : Form
    {
        public static Boolean bolIsRunning;
        public Connection cnConnection;
        public User usUser;
        public FamSetting setSettings;
        private Category[] caCategories;
        private Department[] deDepartments;
        public DataSet dsRequests;
        private Request reqSearch;
        private Request reqUpdate;
        private DataSet dsCurrentAffairs;
        private DataSet dsProjects;
        private bool bolEnableBtmSearchByInterface;
        private bool bolEnableBtmSearchByPermision;
        private bool bolEnableBtmDeleteByInterface;
        private bool bolEnableBtmDeleteByPermision;
        private bool bolEnableBtmInsertByInterface;
        private bool bolEnableBtmInsertByPermision;

        public Requests()
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

        private void Requests_Load(object sender, EventArgs e)
        {
            SetComponentsByPermisions();

            this.reqSearch = new Request();
            this.reqUpdate = new Request();

            //Fill cbCategory ComboBox
            this.caCategories = Category.GetCategories(this.cnConnection);
            this.cbCategory.Items.Add("");
            foreach (Category ctCategory in this.caCategories)
            {
                this.cbCategory.Items.Add(ctCategory.strName);
            }

            //cbDepartment
            this.deDepartments = Department.GetDepartments(this.cnConnection);
            this.cbDepartment.Items.Add("");
            foreach (Department deDepartment in this.deDepartments)
            {
                this.cbDepartment.Items.Add(deDepartment.strName);
            }
        }

        private void SetComponentsByPermisions()
        {
            if (this.usUser.bolStoreEnabed)
            {
                this.bolEnableBtmSearchByPermision = true;
                this.bolEnableBtmDeleteByPermision = true;
                this.bolEnableBtmInsertByPermision = true;
                this.dgvRequests.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRequests_CellMouseDoubleClick);
                this.dgvRequests.Columns["bitSelect"].Visible = true;
            }
            else
            {
                this.bolEnableBtmSearchByPermision = true;
                this.bolEnableBtmDeleteByPermision = false;
                this.bolEnableBtmInsertByPermision = false;
                this.dgvRequests.CellMouseDoubleClick -= new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRequests_CellMouseDoubleClick);
                this.dgvRequests.Columns["bitSelect"].Visible = false;
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

        private void Requests_FormClosing(object sender, FormClosingEventArgs e)
        {
            bolIsRunning = false;

            Management frmManagement = (Management)this.MdiParent;
            frmManagement.menWindows.DropDownItems["menWindowsRequests"].Dispose();
        }

        private void btmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmSearch_Click(object sender, EventArgs e)
        {
            this.btmSearch.Enabled = false;
            SearchRequests();
            this.btmSearch.Enabled = true;
        }

        public void SearchRequests()
        {
            this.reqSearch = new Request();
            DateTime dtFromLoc = new DateTime();
            DateTime dtToLoc = new DateTime();

            if(this.tbNumber.Text.Trim().Length != 0)
            {
                this.reqSearch.intNumber = int.Parse(this.tbNumber.Text.Trim());
            }
            if(this.cbDepartment.SelectedIndex >=1)
            {
                this.reqSearch.intDepartment = this.deDepartments[this.cbDepartment.SelectedIndex - 1].intNumber;
            }

            if (this.cbRowBudget.SelectedIndex >= 1)
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
                this.dgvRequests.Rows[i].Cells["intRowBudgetAsName"].Value = 
                    Project.GetNameByNumber(this.cnConnection, (int)this.dgvRequests.Rows[i].Cells["intRowBudget"].Value);

                this.dgvRequests.Rows[i].Cells["intDepartmentAsName"].Value = 
                    Department.GetNameByNumber(this.cnConnection, (int)this.dgvRequests.Rows[i].Cells["intDepartment"].Value);

                this.dgvRequests.Rows[i].Cells["nvcRequesterCoIDAsName"].Value =
                   Employee.GetNameByCoID(this.cnConnection, this.dgvRequests.Rows[i].Cells["nvcRequesterCoID"].Value.ToString());

                this.dgvRequests.Rows[i].Cells["nvcSupervisorCoIDAsName"].Value =
                   Employee.GetNameByCoID(this.cnConnection, this.dgvRequests.Rows[i].Cells["nvcSupervisorCoID"].Value.ToString());

                this.dgvRequests.Rows[i].Cells["nvcPlantmanagerCoIDAsName"].Value =
                   Employee.GetNameByCoID(this.cnConnection, this.dgvRequests.Rows[i].Cells["nvcPlantmanagerCoID"].Value.ToString());

                this.dgvRequests.Rows[i].Cells["nvcCeoCoIDAsName"].Value =
                   Employee.GetNameByCoID(this.cnConnection, this.dgvRequests.Rows[i].Cells["nvcCeoCoID"].Value.ToString());
            }
        }

        private void btmDelete_Click(object sender, EventArgs e)
        {
            Int16 intSelectedRequests = 0;
            foreach (DataRow drVendor in this.dsRequests.Tables["tabRequests"].Rows)
            {
                if ((Boolean)drVendor["bitSelect"])
                {
                    ++intSelectedRequests;
                }
            }

            if (intSelectedRequests > 0)
            {
                DialogResult dialogResult = MessageBox.Show("آیا می خواهید " + intSelectedRequests.ToString() + " درخواست را حذف کنید؟", "حذف", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.btmDelete.Enabled = false;
                    Request.DeleteRequests(this.cnConnection, this.dsRequests);
                    SearchRequests();
                    this.btmDelete.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show(".هیچ درخواست انتخاب نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void dgvRequests_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {   
            if(e.RowIndex != -1)
            {
                RequestUpdate frmRequestUpdate = new RequestUpdate();
                frmRequestUpdate.Owner = this;

                frmRequestUpdate.reqUpdate = this.reqUpdate;
                frmRequestUpdate.cnConnection = this.cnConnection;
                frmRequestUpdate.setSettings = this.setSettings;
                frmRequestUpdate.usUser = this.usUser;

                this.reqUpdate.intID = (int)this.dgvRequests.Rows[e.RowIndex].Cells["intID"].Value;
                this.reqUpdate.intDepartment = (int)this.dgvRequests.Rows[e.RowIndex].Cells["intDepartment"].Value;
                this.reqUpdate.intNumber = (int)this.dgvRequests.Rows[e.RowIndex].Cells["intNumber"].Value;
                this.reqUpdate.dtDate = (DateTime)this.dgvRequests.Rows[e.RowIndex].Cells["datDate"].Value;
                this.reqUpdate.intRowBudget = (int)this.dgvRequests.Rows[e.RowIndex].Cells["intRowBudget"].Value;
                this.reqUpdate.strRequesterCoID = this.dgvRequests.Rows[e.RowIndex].Cells["nvcRequesterCoID"].Value.ToString();
                this.reqUpdate.strSupervisorCoID = this.dgvRequests.Rows[e.RowIndex].Cells["nvcSupervisorCoID"].Value.ToString();
                this.reqUpdate.strPlantmanagerCoID = this.dgvRequests.Rows[e.RowIndex].Cells["nvcPlantmanagerCoID"].Value.ToString();
                this.reqUpdate.strCeoCoID = this.dgvRequests.Rows[e.RowIndex].Cells["nvcCEOCoID"].Value.ToString();

                frmRequestUpdate.ShowDialog();
            }
        }

        private void btmInsert_Click(object sender, EventArgs e)
        {
            this.btmInsert.Enabled = false;
            RequestInsert frmRequestInsert = new RequestInsert();
            frmRequestInsert.Owner = this;
            frmRequestInsert.setSettings = this.setSettings;
            frmRequestInsert.usUser = this.usUser;
            frmRequestInsert.cnConnection = this.cnConnection;
            frmRequestInsert.ShowDialog();
            this.btmInsert.Enabled = true;
        }

        private void BtmInvoiceItems_Click(object sender, EventArgs e)
        {
            if (this.dgvRequests.SelectedRows.Count != 0)
            {
                this.btmItems.Enabled = false;
                RequestItems frmRequestItems = new RequestItems();
                frmRequestItems.riSearch.intRequestNumber = (int)this.dgvRequests.SelectedRows[0].Cells["intNumber"].Value;
                frmRequestItems.reqRequest.intNumber = (int)this.dgvRequests.SelectedRows[0].Cells["intNumber"].Value;
                frmRequestItems.reqRequest.strRequesterCoID = this.dgvRequests.SelectedRows[0].Cells["nvcRequesterCoID"].Value.ToString();
                frmRequestItems.reqRequest.intDepartment = (int)this.dgvRequests.SelectedRows[0].Cells["intDepartment"].Value;
                frmRequestItems.reqRequest.dtDate = (DateTime)this.dgvRequests.SelectedRows[0].Cells["datDate"].Value;

                frmRequestItems.cnConnection = this.cnConnection;
                frmRequestItems.setSettings = this.setSettings;
                frmRequestItems.usUser = this.usUser;
                frmRequestItems.ShowDialog();
                this.btmItems.Enabled = true;
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

            SetEnableBtmSearch();
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
            if (this.reqSearch.strRequesterCoID.Length != 0 || this.tbNumber.Text.Trim().Length != 0 ||
                this.cbDepartment.SelectedIndex >= 1 || this.cbRowBudget.SelectedIndex >= 1 ||
                this.cbDate.Checked)
            {
                this.bolEnableBtmSearchByInterface = true;
            }
            else
            {
                this.bolEnableBtmSearchByInterface = false;
            }

            SetEnableComponents();
        }

        private void ButEmployee_Click(object sender, EventArgs e)
        {
            SelectEmployee frmSelectEmployee = new SelectEmployee();
            frmSelectEmployee.Owner = this;
            frmSelectEmployee.cnConnection = this.cnConnection;
            frmSelectEmployee.ShowDialog();
            if (SelectEmployee.strCoID.Length != 0)
            {
                this.reqSearch.strRequesterCoID = SelectEmployee.strCoID;
                this.labEmployee.Text = SelectEmployee.strEmployeeName;
            }
           
            SetEnableBtmSearch();
        }

        private void CbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmSearch();
        }

        private void CbRowBudget_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmSearch();
        }

        private void TbNumber_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmSearch();
        }

        private void dgvStuffs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvRequests.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void dgvStuffs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.bolEnableBtmDeleteByInterface = false;

            for (int i = 0; i < this.dgvRequests.Rows.Count; i++)
            {
                if ((bool)this.dgvRequests.Rows[i].Cells["bitSelect"].Value)
                {
                    this.bolEnableBtmDeleteByInterface = true;
                }
            }

            SetEnableComponents();
        }

        private void DgvRequests_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dsRequests.Tables["tabRequests"].Rows.Count; ++i)
            {
                this.dgvRequests.Rows[i].Cells["intRowBudgetAsName"].Value =
                    Project.GetNameByNumber(this.cnConnection, (int)this.dgvRequests.Rows[i].Cells["intRowBudget"].Value);

                this.dgvRequests.Rows[i].Cells["intDepartmentAsName"].Value =
                    Department.GetNameByNumber(this.cnConnection, (int)this.dgvRequests.Rows[i].Cells["intDepartment"].Value);

                this.dgvRequests.Rows[i].Cells["nvcRequesterCoIDAsName"].Value =
                   Employee.GetNameByCoID(this.cnConnection, this.dgvRequests.Rows[i].Cells["nvcRequesterCoID"].Value.ToString());

                this.dgvRequests.Rows[i].Cells["nvcSupervisorCoIDAsName"].Value =
                   Employee.GetNameByCoID(this.cnConnection, this.dgvRequests.Rows[i].Cells["nvcSupervisorCoID"].Value.ToString());

                this.dgvRequests.Rows[i].Cells["nvcPlantmanagerCoIDAsName"].Value =
                   Employee.GetNameByCoID(this.cnConnection, this.dgvRequests.Rows[i].Cells["nvcPlantmanagerCoID"].Value.ToString());

                this.dgvRequests.Rows[i].Cells["nvcCeoCoIDAsName"].Value =
                   Employee.GetNameByCoID(this.cnConnection, this.dgvRequests.Rows[i].Cells["nvcCeoCoID"].Value.ToString());
            }
        }

        private void DgvRequests_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.ColumnIndex == -1)
            {
                this.btmItems.Enabled = true;
            }
            else
            {
                this.btmItems.Enabled = false;
            }
        }
    }
}
