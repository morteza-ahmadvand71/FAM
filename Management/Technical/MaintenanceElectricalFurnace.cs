using Baran.Ferroalloy.Automation.Security;
using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Maintenance;
using Baran.Ferroalloy.Office;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baran.Ferroalloy.Management
{
    public partial class MaintenanceElectricalFurnace : Form
    {
        public static Boolean bolIsRunning;
        public Connection cnConnection;
        public User usUser;
        public FamSetting setSetings;
        public MaintenanceFurnaceShift mfsCurrent = new MaintenanceFurnaceShift();
        public MaintenanceFurnaceItem mfiCurrent = new MaintenanceFurnaceItem();
        public MaintenanceFurnaceShift mfsSearch = new MaintenanceFurnaceShift();
        public MaintenanceFurnaceItem mfiSearch = new MaintenanceFurnaceItem();
        public DataSet dsShifts = new DataSet();
        public DataSet dsItems = new DataSet();
        public ShiftInfo siShiftInfo;



        public MaintenanceElectricalFurnace()
        {
            InitializeComponent();

            bolIsRunning = true;
            
        }

        private void MaintenanceElectricalFurnace_Load(object sender, EventArgs e)
        {
            SetComponentsByPermisions();

            //this.siShiftInfo = new ShiftInfo(this.cnConnection, this.setSetings.stMaintenanceFurnaceShifttypePty,
            //    this.setSetings.dtMaintenanceFurnaceShiftOrginPty);

            //GetCurrentMaintenanceShiftAndItems();
        }

        private void SetComponentsByPermisions()
        {
            if (this.usUser.bolTechnicalEnabed)
            {
                this.btmDelete.Enabled = true;
                this.btmInsert.Enabled = true;
                this.dgvItems.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvItems_CellMouseDoubleClick);
            }
            else
            {
                this.btmDelete.Enabled = false;
                this.btmInsert.Enabled = false;
                this.dgvItems.CellMouseDoubleClick -= new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvItems_CellMouseDoubleClick);
            }
        }

        public void GetCurrentMaintenanceShiftAndItems()
        {
            this.dsShifts.Clear();
            this.dsItems.Clear();

            this.mfsCurrent.dtDatePty = siShiftInfo.GetDate(DateTime.Now);
            this.mfsCurrent.shiShiftPty = siShiftInfo.GetShift(DateTime.Now.TimeOfDay);
            this.mfsCurrent.strCaltegoryPty = "01";

            this.dsShifts = MaintenanceFurnaceShift.GetMFSs(this.cnConnection, this.mfsCurrent);
            //Shift Already Inserted
            if (this.dsShifts.Tables["tabMaintenanceFurnaceShifts"].Rows.Count != 0)
            {
                this.mfsCurrent.intIDPty = (int)this.dsShifts.Tables["tabMaintenanceFurnaceShifts"].Rows[0]["intID"];
                this.mfsCurrent.strGroupPty = this.dsShifts.Tables["tabMaintenanceFurnaceShifts"].Rows[0]["nvcGroup"].ToString();

                this.dgvShifts.DataSource = this.dsShifts;
                this.dgvShifts.DataMember = "tabMaintenanceFurnaceShifts";

                this.mfiCurrent.intTabShiftIDPty = this.mfsCurrent.intIDPty;
                this.dsItems =  MaintenanceFurnaceItem.GetMFIs(this.cnConnection, this.mfiCurrent,this.tbStoreCode.Text.Trim(),this.tbPersonCoID.Text.Trim());
               
                if (this.dsItems.Tables["tabMaintenanceFurnaceItems"].Rows.Count != 0)
                {
                    this.dgvItems.DataSource = this.dsItems;
                    this.dgvItems.DataMember = "tabMaintenanceFurnaceItems";
                }
            }
            //Insert Shift
            else
            {
                this.mfsCurrent.strGroupPty = siShiftInfo.GetGroup(siShiftInfo.GetDate(DateTime.Now)).ToString();
                this.mfsCurrent.Insert(this.cnConnection);
                GetCurrentMaintenanceShiftAndItems();
            }
        }
        private void btmExit_Click(object sender, EventArgs e)
        {
            bolIsRunning = false;
            this.Close();
        }

        private void btmSearchShifts_Click(object sender, EventArgs e)
        {
            try
            {
                this.dsItems.Clear();
            }
            catch(System.NullReferenceException)
            { }
            
            DateTime dtFromDate = new DateTime();
            DateTime dtToDate = new DateTime();

            if (this.cekDate.Checked)
            {
                dtFromDate = new DateTime(this.dtpFromDate.Value.Year, this.dtpFromDate.Value.Month, this.dtpFromDate.Value.Day);
                dtToDate = new DateTime(this.dtpToDate.Value.Year, this.dtpToDate.Value.Month, this.dtpToDate.Value.Day);
            }

            this.mfsSearch.shiShiftPty = ShiftInfo.ConvertTextToShift(this.cbShift.Text);
            this.mfsSearch.strGroupPty = this.cbGroup.Text;

            this.dsShifts = MaintenanceFurnaceShift.GetMFSs(this.cnConnection, mfsSearch, dtFromDate, dtToDate);

            this.dgvShifts.DataSource = this.dsShifts;
            this.dgvShifts.DataMember = "tabMaintenanceFurnaceShifts";

            for (int i = 0;i<this.dsShifts.Tables["tabMaintenanceFurnaceShifts"].Rows.Count;i++)
            {
                int intShift = int.Parse(this.dsShifts.Tables["tabMaintenanceFurnaceShifts"].Rows[i]["nvcShift"].ToString());
                this.dsShifts.Tables["tabMaintenanceFurnaceShifts"].Rows[i]["nvcShift"] = ((ShiftInfo.Shift)intShift).ToString();
            }
        }

        private void cbDate_CheckedChanged(object sender, EventArgs e)
        {
            if(this.cekDate.Checked)
            {
                this.labFromDate.Enabled = true;
                this.labToDate.Enabled = true;
                this.dtpFromDate.Enabled = true;
                this.dtpToDate.Enabled = true;
            }
            else
            {
                this.labFromDate.Enabled = false;
                this.labToDate.Enabled = false;
                this.dtpFromDate.Enabled = false;
                this.dtpToDate.Enabled = false;
            }
        }

        private void btmSearchItems_Click(object sender, EventArgs e)
        {
            try
            {
                this.dsShifts.Clear();
            }
            catch (System.NullReferenceException)
            { }

            this.mfiSearch.strEquipTagPty = this.tbTag.Text;
            this.mfiSearch.strTipPty = this.tbTip.Text;

            this.dsItems = MaintenanceFurnaceItem.GetMFIs(this.cnConnection, this.mfiSearch,this.tbStoreCode.Text.Trim(), this.tbPersonCoID.Text.Trim());

            this.dgvItems.DataSource = this.dsItems;
            this.dgvItems.DataMember = "tabMaintenanceFurnaceItems";
        }

        private void dgvShifts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                int intIDLoc = (int)this.dgvShifts.Rows[e.RowIndex].Cells["intID"].Value;
                this.mfiSearch = new MaintenanceFurnaceItem();
                this.mfiSearch.intIDPty = intIDLoc;
                this.dsItems = MaintenanceFurnaceItem.GetMFIs(this.cnConnection, this.mfiSearch,this.tbStoreCode.Text.Trim(), this.tbPersonCoID.Text.Trim());

                this.dgvItems.DataSource = this.dsItems;
                this.dgvItems.DataMember = "tabMaintenanceFurnaceItems";

                foreach (DataRow drEmployee in this.dsItems.Tables["tabMaintenanceFurnaceItems"].Rows)
                {
                    drEmployee["nvcPersonCoID"] = Employee.GetNameByCoID(this.cnConnection, drEmployee["nvcPersonCoID"].ToString());
                }
            }
        }

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                MaintenanceFurnaceShift mfsSearchLoc = new MaintenanceFurnaceShift();
                
                int intIDLoc = (int)this.dgvItems.Rows[e.RowIndex].Cells["intTabShiftID"].Value;
                mfsSearchLoc.intIDPty = intIDLoc;
                this.dsShifts = MaintenanceFurnaceShift.GetMFSs(this.cnConnection, mfsSearchLoc);
                this.dgvShifts.DataSource = this.dsShifts;
                this.dgvShifts.DataMember = "tabMaintenanceFurnaceShifts";

                for (int i = 0; i < this.dsShifts.Tables["tabMaintenanceFurnaceShifts"].Rows.Count; i++)
                {
                    int intShift = int.Parse(this.dsShifts.Tables["tabMaintenanceFurnaceShifts"].Rows[i]["nvcShift"].ToString());
                    this.dsShifts.Tables["tabMaintenanceFurnaceShifts"].Rows[i]["nvcShift"] = ((ShiftInfo.Shift)intShift).ToString();
                }
            }
        }

        private void btmInsert_Click(object sender, EventArgs e)
        {
            MaintenanceElectricalFurnaceInsert frmMefInsert = new MaintenanceElectricalFurnaceInsert();
            frmMefInsert.Owner = this;
            frmMefInsert.cnConnection = this.cnConnection;
            frmMefInsert.mfsInsert = this.mfsCurrent;
            frmMefInsert.ShowDialog();
        }

        private void ButCurrent_Click(object sender, EventArgs e)
        {
            GetCurrentMaintenanceShiftAndItems();
        }

        private void btmDelete_Click(object sender, EventArgs e)
        {
            MaintenanceFurnaceItem.DeleteItems(this.cnConnection, this.dsItems);
            GetCurrentMaintenanceShiftAndItems();
        }

        private void dgvItems_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.ColumnIndex == -1)
            {
                MaintenanceFurnaceItem mfiUpdate = new MaintenanceFurnaceItem();
                mfiUpdate.intIDPty = (int)this.dsItems.Tables["tabMaintenanceFurnaceItems"].Rows[e.RowIndex]["intID"];
                mfiUpdate.intTabShiftIDPty = this.mfsCurrent.intIDPty;
                mfiUpdate.strEquipTagPty = this.dsItems.Tables["tabMaintenanceFurnaceItems"].Rows[e.RowIndex]["nvcEquipTag"].ToString();
                mfiUpdate.tsTimePty = (TimeSpan)this.dsItems.Tables["tabMaintenanceFurnaceItems"].Rows[e.RowIndex]["timTime"];
                mfiUpdate.tsDurationPty = (TimeSpan)this.dsItems.Tables["tabMaintenanceFurnaceItems"].Rows[e.RowIndex]["timDuration"];
                mfiUpdate.strTipPty = this.dsItems.Tables["tabMaintenanceFurnaceItems"].Rows[e.RowIndex]["nvcTip"].ToString();

                MaintenanceElectricalFurnaceUpdate frmMefUpdate = new MaintenanceElectricalFurnaceUpdate();
                frmMefUpdate.Owner = this;
                frmMefUpdate.cnConnection = this.cnConnection;
                //frmMefUpdate.mfsUpdate = this.mfsCurrent;
                frmMefUpdate.mfiUpdate = mfiUpdate;
                frmMefUpdate.ShowDialog();
            }
        }

        private void MaintenanceElectricalFurnace_FormClosing(object sender, FormClosingEventArgs e)
        {
            bolIsRunning = false;

            Management frmManagement = (Management)this.MdiParent;
            frmManagement.menWindows.DropDownItems["menWindowsMaintenanceElectricalFurnace"].Dispose();
        }
    }
}
