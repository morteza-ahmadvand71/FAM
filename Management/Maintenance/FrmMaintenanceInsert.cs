using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baran.Ferroalloy.Automation;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Management.Maintenance
{
    public partial class FrmMaintenanceInsert : Form
    {
        public FrmMaintenanceInsert()
        {
            InitializeComponent();
        }

        private void FrmMaintenanceInsert_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<int> intWorkGroup = new List<int> { 1, 2, 3, 4 };
                foreach (var item in intWorkGroup)
                {
                    cbWorkGroup.Items.Add(item);
                }

                var shifts = db.shift.GetAll();
                foreach (var item in shifts)
                {
                    cbShift.Items.Add(item.nvcName);
                }

                var subDepartments = db.subDepartment.GetAll().Where(t => t.intDepartment == 5);
                foreach (var item in subDepartments)
                {
                    cbSubDepartment.Items.Add(item.nvcName);
                }

                SetEnableBtmOk();
            }
        }

        private void BtmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbSubDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var employees = db.Employees.Get(t =>
                    t.intWorkGroup == (int)cbWorkGroup.SelectedItem && t.intDepartment == 5 &&
                    t.tabSubDepartments.nvcName == cbSubDepartment.SelectedItem && t.intSubDepartmentSubset == 3); //فنی=5 کوره=3
                var workGroupsName = "";
                var leaderName = "";
                if (employees != null)
                {
                    foreach (var item in employees)
                    {
                        workGroupsName += item.nvcFirstname + " " + item.nvcLastname + "-";
                        if (item.bitIsLeader == true)
                        {
                            leaderName = item.nvcFirstname + " " + item.nvcLastname;
                        }
                    }
                    workGroupsName = workGroupsName.Remove(workGroupsName.Length - 1);
                    txtworkGrop.Text = workGroupsName;
                    txtLeaderWorkGroup.Text = leaderName;
                }
                SetEnableBtmOk();
            }
        }

        private void SetEnableBtmOk()
        {
            if (this.cbShift.SelectedIndex >= 0 && this.cbSubDepartment.SelectedIndex >= 0 &&
                this.cbSubDepartment.SelectedIndex >= 0 && this.txtworkGrop.Text.Trim().Length != 0 &&
                this.txtLeaderWorkGroup.Text.Trim().Length != 0)
            {
                this.btmOK.Enabled = true;
            }
            else
            {
                this.btmOK.Enabled = false;
            }
        }

        private void BtmOK_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var shiftId = db.shift.GetEntity(t => t.nvcName == cbShift.SelectedItem).intNumber;
                var subDepartmentId = db.subDepartment.GetEntity(t => t.nvcName == cbSubDepartment.SelectedItem).intNumber;
                var workGroup = txtworkGrop.Text.Split('-');

                var coIds = "";
                foreach (var item in workGroup)
                {
                    coIds += db.Employees.GetEntity(t => t.nvcFirstname + " " + t.nvcLastname == item).nvcCoID +"-";
                }
                coIds = coIds.Remove(coIds.Length - 1);

                var coIdLeader = db.Employees.GetEntity(t => t.nvcFirstname + " " + t.nvcLastname == txtLeaderWorkGroup.Text).nvcCoID;
                tabMaintenances tabMaintenances = new tabMaintenances()
                {
                    intDepartment = 5,
                    bitSelect = false,
                    datWorkGroup = dtMaintenance.Value,
                    intShift = shiftId,
                    intSubDepartment = subDepartmentId,
                    nvcCoIdsWorkGroup = coIds,
                    nvcCoIdLeader = coIdLeader,
                    intWourkGroup = (int)cbWorkGroup.SelectedItem
                };
                var maintenancInsert = db.Maintenance.Insert(tabMaintenances);
                db.Save();
                this.Close();
                FrmMaintenanceItems frmMaintenanceItems=new FrmMaintenanceItems();
                frmMaintenanceItems.coIdsWorker = tabMaintenances.nvcCoIdsWorkGroup;
                frmMaintenanceItems.maintenanceId = maintenancInsert.intID;
                frmMaintenanceItems.Show();
                
            }
        }

        private void BtnSelectEmployee_Click(object sender, EventArgs e)
        {
            SelectEmployee selectEmployee=new SelectEmployee();
            selectEmployee.Show();
        }
    }
}
