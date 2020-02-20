using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baran.Ferroalloy.Automation;
using Baran.Ferroalloy.Automation.Models;
using Baran.Ferroalloy.Automation.Security;
using Baran.Ferroalloy.Automation.ViewModels;

namespace Baran.Ferroalloy.Management.Maintenance
{
    public partial class FrmMaintenance : Form
    {
        public User usUser;

        public FrmMaintenance()
        {
            InitializeComponent();
        }

        private void FrmMaintenance_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dtpFromDate.Enabled = false;
                dtpToDate.Enabled = false;
                var shifts = db.shift.GetAll();
                cbShift.Items.Clear();
                cbSubDepartment.Items.Clear();
                foreach (var item in shifts)
                {
                    cbShift.Items.Add(item.nvcName);
                }

                var subDepartments = db.subDepartment.GetAll().Where(t => t.intDepartment == 5);
                foreach (var item in subDepartments)
                {
                    cbSubDepartment.Items.Add(item.nvcName);
                }

                Filter();
            }
            SetComponentsByPermisions();

        }


        private void Filter()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var leaderWorker = "";
                var workersName = "";
                var maintenances = db.Maintenance.GetAll().Where(t =>
                        t.tabSubDepartments.nvcName.Equals(cbSubDepartment.SelectedItem) ||
                        t.tabShifts.nvcName.Equals(cbShift.SelectedItem) ||
                        (t.datWorkGroup.Date >= dtpFromDate.Value.Date && t.datWorkGroup.Date <= dtpToDate.Value.Date)).ToList();
                List<dgvMaintenanceViewModel> list = new List<dgvMaintenanceViewModel>();
                foreach (var item in maintenances)
                {
                    var leader = db.Employees.GetEntity(t => t.nvcCoID == item.nvcCoIdLeader);
                    leaderWorker = leader.nvcFirstname + " " + leader.nvcLastname;
                    var coIds = item.nvcCoIdsWorkGroup.Split('-');
                    var coId = "";
                    for (int i = 0; i < coIds.Length; i++)
                    {
                        coId = coIds[i];
                        var coIdEmployee = db.Employees.GetEntity(t => t.nvcCoID == coId);
                        workersName += coIdEmployee.nvcFirstname + " " + coIdEmployee.nvcLastname + "-";
                    }

                    workersName = workersName.Remove(workersName.Length - 1);
                    list.Add(new dgvMaintenanceViewModel()
                    {
                        intID = item.intID,
                        datWorkGroup = item.datWorkGroup.Date,
                        nameShift = item.tabShifts.nvcName,
                        nameSubDepartment = item.tabSubDepartments.nvcName,
                        workers = workersName,
                        leaderWorker = leaderWorker
                    });
                    workersName = "";
                }

                dgvMaintenance.DataSource = list;
            }
        }

        private void BtmDelete_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (RtlMessageBox.Show($"آیا از حذف مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var selectItems = dgvMaintenance.Rows.Cast<DataGridViewRow>().Where(t => Convert.ToBoolean(t.Cells["bitSelect"].Value) == true).ToList();

                    foreach (var item in selectItems)
                    {
                        var id = int.Parse(item.Cells["intID"].Value.ToString());
                        var maintenances = db.Maintenance.GetEntity(t => t.intID == id);
                        db.Maintenance.Delete(maintenances);
                        db.Save();
                        RtlMessageBox.Show("حذف با موفقیت انجام شد", "حذف کالا", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Filter();
                    }
                }

            }
        }

        private void SetComponentsByPermisions()
        {
            if (this.usUser.bolTechnicalEnabed)
            {
                this.btmDelete.Enabled = true;
                this.btmInsert.Enabled = true;
                //this.dgvItems.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvItems_CellMouseDoubleClick);
            }
            else
            {
                this.btmDelete.Enabled = false;
                this.btmInsert.Enabled = false;
                //this.dgvItems.CellMouseDoubleClick -= new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvItems_CellMouseDoubleClick);
            }
        }


        private void BtmInsert_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var selectItem = dgvMaintenance.Rows.Cast<DataGridViewRow>().FirstOrDefault(t => Convert.ToBoolean(t.Cells["bitSelect"].Value) == true);

                if (selectItem != null)
                {
                    FrmMaintenanceItems frmMaintenanceItems = new FrmMaintenanceItems();
                    int intId = Convert.ToInt32(dgvMaintenance.CurrentRow.Cells["intID"].Value.ToString());
                    var maintenances = db.Maintenance.GetEntity(t => t.intID == intId);
                    frmMaintenanceItems.coIdsWorker = maintenances.nvcCoIdsWorkGroup;
                    frmMaintenanceItems.maintenanceId = maintenances.intID;
                    frmMaintenanceItems.Show();
                }
                else
                {
                    FrmMaintenanceInsert frmMaintenanceInsert = new FrmMaintenanceInsert();
                    frmMaintenanceInsert.Show();
                }

            }

        }

        private void DgvMaintenance_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (dgvMaintenance.CurrentRow != null)
                {
                    FrmMaintenanceUpdate frmMaintenanceUpdate = new FrmMaintenanceUpdate();
                    var maintenanceId = Convert.ToInt32(dgvMaintenance.CurrentRow.Cells["intID"].Value.ToString());
                    frmMaintenanceUpdate.maintenanceId = maintenanceId;
                    frmMaintenanceUpdate.Show();
                }
            }
        }

        private void BtnMaintenanceItem_Click(object sender, EventArgs e)
        {
            if (dgvMaintenance.CurrentRow != null)
            {
                var maintenanceId = Convert.ToInt32(dgvMaintenance.CurrentRow.Cells["intID"].Value.ToString());
                FrmMaintenanceItems frmMaintenanceItems = new FrmMaintenanceItems();
                frmMaintenanceItems.maintenanceId = maintenanceId;
                using (UnitOfWork db = new UnitOfWork())
                {
                    var maintenance = db.Maintenance.GetEntity(t => t.intID == maintenanceId);
                    frmMaintenanceItems.coIdsWorker = maintenance.nvcCoIdsWorkGroup;
                }
                frmMaintenanceItems.Show();
            }
            else
            {
                RtlMessageBox.Show("لطفا یک سطر را مشخص کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChbDateCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDateCheck.Checked)
            {
                dtpFromDate.Enabled = true;
                dtpToDate.Enabled = true;
            }
            else
            {
                dtpFromDate.Enabled = false;
                dtpToDate.Enabled = false;
            }
        }

        private void BtmSearchItems_Click(object sender, EventArgs e)
        {
            Filter();
        }


    }
}
