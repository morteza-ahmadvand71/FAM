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
    public partial class StoreGetOuts : Form
    {
        public static Boolean bolIsRunning;
        public Connection cnConnection;
        public User usLogined;
        public Employee emLogined;
        public FamSetting setSettings;
        private Department[] deDepartments;
        public DataTable dtStoreGetOuts;
        private StoreGetOut sgoSearch;
        private StoreGetOut sgoUpdate;
        public static bool bolWritePermision;
        private bool bolEnableBtmSearchByInterface;
        private bool bolEnableBtmSearchByPermision;
        private bool bolEnableBtmDeleteByInterface;
        private bool bolEnableBtmDeleteByPermision;
        private bool bolEnableBtmInsertByInterface;
        private bool bolEnableBtmInsertByPermision;
        private bool bolEnableBtmConfirmByInterface;
        private bool bolEnableBtmConfirmByPermision;

        public StoreGetOuts()
        {
            InitializeComponent();

            bolIsRunning = true;
            this.bolEnableBtmSearchByInterface = false;
            this.bolEnableBtmSearchByPermision = false;
            this.bolEnableBtmDeleteByInterface = false;
            this.bolEnableBtmDeleteByPermision = false;
            this.bolEnableBtmInsertByInterface = true;
            this.bolEnableBtmInsertByPermision = false;
            this.bolEnableBtmConfirmByInterface = false;
            this.bolEnableBtmConfirmByPermision = false;
        }

        private void StoreGetOuts_Load(object sender, EventArgs e)
        {
            SetComponentsByPermisions();

            this.sgoSearch = new StoreGetOut();
            this.sgoUpdate = new StoreGetOut();

            //cbDepartment
            this.deDepartments = Department.GetDepartments(this.cnConnection);
            this.cbDepartments.Items.Add("");
            foreach (Department deDepartment in this.deDepartments)
            {
                this.cbDepartments.Items.Add(deDepartment.strName);
            }

            //Store Department
            if (this.emLogined.intDepartment == 6)
            {
                this.cbDepartments.Visible = true;
                this.labDepartment.Visible = true;
            }
            else
            {
                this.cbDepartments.SelectedItem = Department.GetNameByNumber(this.cnConnection, this.emLogined.intDepartment);
                this.cbDepartments.Visible = false;
                this.labDepartment.Visible = false;
            }
          
        }

        private void SetComponentsByPermisions()
        {
            if (this.usLogined.bolStoreEnabed)
            {
                this.bolEnableBtmSearchByPermision = true;
                this.bolEnableBtmDeleteByPermision = true;
                this.bolEnableBtmInsertByPermision = true;
                this.bolEnableBtmConfirmByPermision = true;
                this.dgvStoreGetOuts.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStoreGetOuts_CellMouseDoubleClick);
                this.dgvStoreGetOuts.Columns["bitSelect"].Visible = true;
            }
            else
            {
                this.bolEnableBtmSearchByPermision = true;
                this.bolEnableBtmDeleteByPermision = false;
                this.bolEnableBtmInsertByPermision = false;
                this.bolEnableBtmConfirmByPermision = false;
                this.dgvStoreGetOuts.CellMouseDoubleClick -= new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStoreGetOuts_CellMouseDoubleClick);
                this.dgvStoreGetOuts.Columns["bitSelect"].Visible = false;
            }

            SetEnableComponents();
        }

        private void SetEnableComponents()
        {
            this.btmSearch.Enabled = this.bolEnableBtmSearchByPermision & this.bolEnableBtmSearchByInterface;
            this.btmDelete.Enabled = this.bolEnableBtmDeleteByPermision & this.bolEnableBtmDeleteByInterface;
            this.btmInsert.Enabled = this.bolEnableBtmInsertByPermision & this.bolEnableBtmInsertByInterface;
            this.btmConfirm.Enabled = this.bolEnableBtmConfirmByPermision & this.bolEnableBtmConfirmByInterface;
        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Requests_FormClosing(object sender, FormClosingEventArgs e)
        {
            bolIsRunning = false;

            Management frmManagement = (Management)this.MdiParent;
            
            frmManagement.menWindows.DropDownItems["menWindowsStoreGetOuts"].Dispose();
                      
            
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
            this.sgoSearch = new StoreGetOut();
            DateTime dtFromLoc = new DateTime();
            DateTime dtToLoc = new DateTime();

            if(this.tbNumber.Text.Trim().Length != 0)
            {
                this.sgoSearch.intNumber = int.Parse(this.tbNumber.Text.Trim());
            }
            if (this.cbDepartments.SelectedIndex >= 1)
            {
                this.sgoSearch.intDepartment = this.deDepartments[this.cbDepartments.SelectedIndex - 1].intNumber;
            }

            if (this.cbDate.Checked)
            {
                dtFromLoc = this.dtpFrom.Value;
                dtToLoc = this.dtpTo.Value;
            }
            
            this.dtStoreGetOuts = StoreGetOut.GetStoreGetouts(this.cnConnection, this.sgoSearch, dtFromLoc, dtToLoc);

            this.dgvStoreGetOuts.DataSource = this.dtStoreGetOuts;

            for (int i=0;i<this.dtStoreGetOuts.Rows.Count; ++i)
            {
                this.dgvStoreGetOuts.Rows[i].Cells["intDepartmentAsName"].Value = 
                    Department.GetNameByNumber(this.cnConnection, (int)this.dgvStoreGetOuts.Rows[i].Cells["intDepartment"].Value);

                SubDepartment sdSubDepartment = new SubDepartment();
                sdSubDepartment.intDepartmnt = (int)this.dgvStoreGetOuts.Rows[i].Cells["intDepartment"].Value;
                sdSubDepartment.intNumber = (int)this.dgvStoreGetOuts.Rows[i].Cells["intNumber"].Value;
                this.dgvStoreGetOuts.Rows[i].Cells["intSubDepartmentAsName"].Value =
                    SubDepartment.GetNameByNumber(this.cnConnection, sdSubDepartment);

                this.dgvStoreGetOuts.Rows[i].Cells["nvcRequesterCoIDAsName"].Value =
                   Employee.GetNameByCoID(this.cnConnection, this.dgvStoreGetOuts.Rows[i].Cells["nvcRequesterCoID"].Value.ToString());

                this.dgvStoreGetOuts.Rows[i].Cells["nvcDepartmentSupervisorCoIDAsName"].Value =
                   Employee.GetNameByCoID(this.cnConnection, this.dgvStoreGetOuts.Rows[i].Cells["nvcDepartmentSupervisorCoID"].Value.ToString());

                this.dgvStoreGetOuts.Rows[i].Cells["nvcStoreSupervisorCoIDAsName"].Value =
                   Employee.GetNameByCoID(this.cnConnection, this.dgvStoreGetOuts.Rows[i].Cells["nvcStoreSupervisorCoID"].Value.ToString());
            }
        }

        private void btmDelete_Click(object sender, EventArgs e)
        {
            Int16 intSelectedRequests = 0;
            foreach (DataRow drVendor in this.dtStoreGetOuts.Rows)
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

                    StoreGetOut.DeleteStoreGetOuts(this.cnConnection, this.dtStoreGetOuts);

                    this.btmDelete.Enabled = true;
                }

                SearchRequests();
            }
            else
            {
                MessageBox.Show(".هیچ درخواست انتخاب نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void dgvStoreGetOuts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {   
            if(e.RowIndex != -1)
            {
                StoreGetOutUpdate frmStoreGetOutUpdate = new StoreGetOutUpdate();
                frmStoreGetOutUpdate.Owner = this;

                frmStoreGetOutUpdate.sgoUpdate = this.sgoUpdate;
                frmStoreGetOutUpdate.cnConnection = this.cnConnection;
                frmStoreGetOutUpdate.setSettings = this.setSettings;
                frmStoreGetOutUpdate.usLogined = this.usLogined;
                frmStoreGetOutUpdate.emLogined = this.emLogined;

                this.sgoUpdate.intID = (int)this.dgvStoreGetOuts.Rows[e.RowIndex].Cells["intID"].Value;
                this.sgoUpdate.intNumber = (int)this.dgvStoreGetOuts.Rows[e.RowIndex].Cells["intNumber"].Value;
                this.sgoUpdate.intGroupNumber = (int)this.dgvStoreGetOuts.Rows[e.RowIndex].Cells["intGroupNumber"].Value;
                this.sgoUpdate.intDepartment = (int)this.dgvStoreGetOuts.Rows[e.RowIndex].Cells["intDepartment"].Value;
                this.sgoUpdate.intSubDepartment = (int)this.dgvStoreGetOuts.Rows[e.RowIndex].Cells["intSubDepartment"].Value;
                this.sgoUpdate.dtDate = (DateTime)this.dgvStoreGetOuts.Rows[e.RowIndex].Cells["datDate"].Value;
                this.sgoUpdate.strRequesterCoID = this.dgvStoreGetOuts.Rows[e.RowIndex].Cells["nvcRequesterCoID"].Value.ToString();
                this.sgoUpdate.strDepartmentSupervisorCoID = this.dgvStoreGetOuts.Rows[e.RowIndex].Cells["nvcDepartmentSupervisorCoID"].Value.ToString();
                
                frmStoreGetOutUpdate.ShowDialog();
            }
        }

        private void btmInsert_Click(object sender, EventArgs e)
        {
            this.btmInsert.Enabled = false;
            StoreGetOutInsert frmStoreGetOutsInsert = new StoreGetOutInsert();
            frmStoreGetOutsInsert.Owner = this;
            frmStoreGetOutsInsert.setSettings = this.setSettings;
            frmStoreGetOutsInsert.usLogined = this.usLogined;
            frmStoreGetOutsInsert.emLogined = this.emLogined;
            frmStoreGetOutsInsert.cnConnection = this.cnConnection;
            frmStoreGetOutsInsert.ShowDialog();
            this.btmInsert.Enabled = true;
        }

        private void BtmStoreGetOutItems_Click(object sender, EventArgs e)
        {
            if (this.dgvStoreGetOuts.SelectedRows.Count != 0)
            {
                this.btmStoreGetOutItems.Enabled = false;
                StoreGetOutItems frmStoreGetOutItems = new StoreGetOutItems();
               
                frmStoreGetOutItems.sgoStoreGetOut.intNumber = (int)this.dgvStoreGetOuts.SelectedRows[0].Cells["intNumber"].Value;
                frmStoreGetOutItems.sgoStoreGetOut.strRequesterCoID = this.dgvStoreGetOuts.SelectedRows[0].Cells["nvcRequesterCoID"].Value.ToString();
                frmStoreGetOutItems.sgoStoreGetOut.intDepartment = (int)this.dgvStoreGetOuts.SelectedRows[0].Cells["intDepartment"].Value;
                frmStoreGetOutItems.sgoStoreGetOut.dtDate = (DateTime)this.dgvStoreGetOuts.SelectedRows[0].Cells["datDate"].Value;

                frmStoreGetOutItems.sgoiSearch.intStoreGetOutNumber = (int)this.dgvStoreGetOuts.SelectedRows[0].Cells["intNumber"].Value;

                frmStoreGetOutItems.cnConnection = this.cnConnection;
                frmStoreGetOutItems.setSettings = this.setSettings;
                frmStoreGetOutItems.usUser = this.usLogined;
                frmStoreGetOutItems.ShowDialog();
                this.btmStoreGetOutItems.Enabled = true;
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
            if (this.sgoSearch.strRequesterCoID.Length != 0 || this.tbNumber.Text.Trim().Length != 0 ||
                this.cbDepartments.SelectedIndex >= 1 || this.cbDate.Checked)
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
                this.sgoSearch.strRequesterCoID = SelectEmployee.strCoID;
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

        private void dgvStoreGetOuts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvStoreGetOuts.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void dgvStoreGetOuts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.bolEnableBtmDeleteByInterface = false;
            this.bolEnableBtmConfirmByInterface = false;

            for (int i = 0; i < this.dgvStoreGetOuts.Rows.Count; i++)
            {
                if ((bool)this.dgvStoreGetOuts.Rows[i].Cells["bitSelect"].Value)
                {
                    this.bolEnableBtmDeleteByInterface = true;
                    this.bolEnableBtmConfirmByInterface = true;
                }
            }

            SetEnableComponents();
        }

        private void dgvStoreGetOuts_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dtStoreGetOuts.Rows.Count; ++i)
            {
                this.dgvStoreGetOuts.Rows[i].Cells["intDepartmentAsName"].Value =
                    Department.GetNameByNumber(this.cnConnection, (int)this.dgvStoreGetOuts.Rows[i].Cells["intDepartment"].Value);

                SubDepartment sdSubDepartment = new SubDepartment();
                sdSubDepartment.intDepartmnt = (int)this.dgvStoreGetOuts.Rows[i].Cells["intDepartment"].Value;
                sdSubDepartment.intNumber = (int)this.dgvStoreGetOuts.Rows[i].Cells["intSubDepartment"].Value;
                this.dgvStoreGetOuts.Rows[i].Cells["intSubDepartmentAsName"].Value =
                    SubDepartment.GetNameByNumber(this.cnConnection, sdSubDepartment);

                this.dgvStoreGetOuts.Rows[i].Cells["nvcRequesterCoIDAsName"].Value =
                   Employee.GetNameByCoID(this.cnConnection, this.dgvStoreGetOuts.Rows[i].Cells["nvcRequesterCoID"].Value.ToString());

                this.dgvStoreGetOuts.Rows[i].Cells["nvcDepartmentSupervisorCoIDAsName"].Value =
                   Employee.GetNameByCoID(this.cnConnection, this.dgvStoreGetOuts.Rows[i].Cells["nvcDepartmentSupervisorCoID"].Value.ToString());

                this.dgvStoreGetOuts.Rows[i].Cells["nvcStoreSupervisorCoIDAsName"].Value =
                   Employee.GetNameByCoID(this.cnConnection, this.dgvStoreGetOuts.Rows[i].Cells["nvcStoreSupervisorCoID"].Value.ToString());
            }
        }

        private void dgvStoreGetOuts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.ColumnIndex == -1)
            {
                this.btmStoreGetOutItems.Enabled = true;
            }
            else
            {
                this.btmStoreGetOutItems.Enabled = false;
            }
        }

        private void CbDepartments_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmSearch();
        }

        private void BtmConfirm_Click(object sender, EventArgs e)
        {
            int intSelectedRows = 0;
            foreach (DataRow drStoreGetOut in this.dtStoreGetOuts.Rows)
            {
                if ((Boolean)drStoreGetOut["bitSelect"])
                {
                    ++intSelectedRows;
                }
            }

            if (intSelectedRows > 0)
            {
                DialogResult dialogResult = MessageBox.Show("آیا می خواهید " + intSelectedRows.ToString() + " درخواست را تایید کنید؟", "تایید", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.btmDelete.Enabled = false;

                    StoreGetOut.ConfirmByDepartmentSupervisor(this.cnConnection, this.dtStoreGetOuts,this.emLogined.strCoID);

                    this.btmDelete.Enabled = true;
                }

                SearchRequests();
            }
            else
            {
                MessageBox.Show(".هیچ درخواستی انتخاب نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }
    }
}
