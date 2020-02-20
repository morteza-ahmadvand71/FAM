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
using Baran.Ferroalloy.Maintenance;

namespace Baran.Ferroalloy.Management.Maintenance
{
    public partial class FrmMaintenanceItems : Form
    {
        public string coIdsWorker = "";
        public int maintenanceId;

        public FrmMaintenanceItems()
        {
            InitializeComponent();
        }

        private void FrmMaintenanceItems_Load(object sender, EventArgs e)
        {
            this.dgvMaintenanceItems.AutoGenerateColumns = false;
            ListRefresh();
            //SetEnableBtmOk();
            using (UnitOfWork db = new UnitOfWork())
            {
                List<string> maintenanceTypesList = new List<string>()
                {
                    MaintenanceTypes.MaintenaceTypes.تعمیر.ToString(), MaintenanceTypes.MaintenaceTypes.تعویض.ToString(),
                    MaintenanceTypes.MaintenaceTypes.گسترش.ToString()
                };
                foreach (var item in maintenanceTypesList)
                {
                    cbWorkGroup.Items.Add(item);
                }

                string fullName = "";
                var coId = coIdsWorker.Split('-');
                foreach (var item in coId)
                {
                    var employees = db.Employees.GetEntity(t => t.nvcCoID == item);
                    string name = employees.nvcFirstname + " " + employees.nvcLastname + "-";
                    fullName += name;
                }
                fullName = fullName.Remove(fullName.Length - 1);

                txtWorker.Text = fullName;
            }
        }

        public void ListRefresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                this.dgvMaintenanceItems.DataSource = db.MaintenanceItem.ListMaintenanceItems(maintenanceId);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                this.dgvMaintenanceItems.DataSource = db.MaintenanceItem.ListMaintenanceItems(maintenanceId, txtSearch.Text);
            }
        }

        private void SetEnableBtmOk()
        {
            if (txtEquip.Text.Length != 0 && txtTimeItem.Text.Length != 0 && txtDuration.Text.Length != 0 &&
                cbWorkGroup.SelectedIndex > 0 && txtWorker.Text.Length != 0 && txtTips.Text.Length != 0)
            {
                btnRegister.Enabled = true;
            }
            else
            {
                btnRegister.Enabled = false;
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var coIds = "";
                var nameWorker = txtWorker.Text.Trim().Split('-');
                foreach (var item in nameWorker)
                {
                    coIds += db.Employees.GetEntity(t => t.nvcFirstname + " " + t.nvcLastname == item).nvcCoID + "-";
                }

                coIds = coIds.Remove(coIds.Length - 1);

                List<string> maintenanceTypesList = new List<string>()
                {
                    MaintenanceTypes.MaintenaceTypes.تعمیر.ToString(), MaintenanceTypes.MaintenaceTypes.تعویض.ToString(),
                    MaintenanceTypes.MaintenaceTypes.گسترش.ToString()
                };
                var maintenanceType = 0;
                foreach (var item in maintenanceTypesList)
                {
                    if (item == (string)cbWorkGroup.SelectedItem)
                    {
                        switch (item.ToString())
                        {
                            case "تعمیر":
                                maintenanceType = 1;
                                break;
                            case "تعویض":
                                maintenanceType = 2;
                                break;
                            case "گسترش":
                                maintenanceType = 3;
                                break;
                        }
                    }

                }
                tabMaintenanceItems tabMaintenanceItems = new tabMaintenanceItems()
                {
                    intMaintenance = maintenanceId,
                    bitIsDueToShutDown = chbIsDueToShutDown.Checked,
                    bitIsNeedToShutDown = chbIsNeedToShutDown.Checked,
                    bitIsSuccessful = chbIsSuccessful.Checked,
                    bitSelect = false,
                    intDuration = int.Parse(txtDuration.Text),
                    timItem = DateTime.Now.TimeOfDay,
                    intMaintenanceType = maintenanceType,
                    nvcEquip = txtEquip.Text,
                    nvcTips = txtTips.Text.Trim(),
                    nvcCoIdsWorker = coIds
                };
                db.MaintenanceItem.Insert(tabMaintenanceItems);
                db.Save();
                txtEquip.Text = "";
                txtTimeItem.Text = "";
                txtDuration.Text = "";
                cbWorkGroup.Items.Clear();
                txtWorker.Text = "";
                txtTips.Text = "";
                chbIsDueToShutDown.Checked = false;
                chbIsNeedToShutDown.Checked = false;
                chbIsSuccessful.Checked = false;
                ListRefresh();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMaintenanceItems.CurrentRow != null)
            {
                if (RtlMessageBox.Show("آیا از حذف مطمئن هستید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var maintenaceItemsId = Convert.ToInt32(dgvMaintenanceItems.CurrentRow.Cells[0].Value.ToString());
                        var maintenanceItems = db.MaintenanceItem.GetEntity(t => t.intID == maintenaceItemsId);
                        var maintenanceParts =
                            db.MaintenanceParts.GetByWhere(t => t.intMaintenanceItem == maintenaceItemsId);
                        if (maintenanceParts.Any())
                        {
                            RtlMessageBox.Show("حذف امکان پذیر نیست", "خطا", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        else
                        {
                            db.MaintenanceItem.Delete(maintenanceItems);
                            db.Save();
                            ListRefresh();
                        }
                        
                    }
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmMaintenanceParts frmMaintenanceParts = new FrmMaintenanceParts();
            if (dgvMaintenanceItems.CurrentRow != null)
            {
                frmMaintenanceParts.maintenanceItemId = int.Parse(dgvMaintenanceItems.CurrentRow.Cells[0].Value.ToString());
            }

            frmMaintenanceParts.Show();
        }

        private void BtnSelectEquip_Click(object sender, EventArgs e)
        {
            FrmSelectEquip frmSelectEquip = new FrmSelectEquip();
            frmSelectEquip.ShowDialog();
            txtEquip.Text = frmSelectEquip.equipName;
        }
    }
}
