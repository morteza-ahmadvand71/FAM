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
    public partial class FrmMaintenanceParts : Form
    {
        public int maintenanceItemId;

        public FrmMaintenanceParts()
        {
            InitializeComponent();
        }

        private void FrmMaintenanceParts_Load(object sender, EventArgs e)
        {
            this.dgvMaintenanceParts.AutoGenerateColumns = false;
            ListRefresh();
            using (UnitOfWork db = new UnitOfWork())
            {

                List<string> maintenanceTypesList = new List<string>()
                {
                    MaintenanceTypes.MaintenaceTypes.تعمیر.ToString(), MaintenanceTypes.MaintenaceTypes.تعویض.ToString(),
                    MaintenanceTypes.MaintenaceTypes.گسترش.ToString()
                };
                foreach (var item in maintenanceTypesList)
                {
                    cbMaintenaceType.Items.Add(item);
                }
                SetEnableBtmOk();
            }
        }

        private void SetEnableBtmOk()
        {
            if (this.cbMaintenaceType.SelectedIndex >= 0 &&
                this.txtCount.Text.Trim().Length != 0)
            {
                this.btnRegister.Enabled = true;
            }
            else
            {
                this.btnRegister.Enabled = false;
            }
        }

        public void ListRefresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                this.dgvMaintenanceParts.DataSource = db.MaintenanceParts.dgvListMaintenanceParts(maintenanceItemId);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                this.dgvMaintenanceParts.DataSource = db.MaintenanceParts.dgvListMaintenanceParts(maintenanceItemId,txtSearch.Text);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                if (dgvMaintenanceParts.CurrentRow != null)
                {
                    if (RtlMessageBox.Show("آیا از حذف مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        var maintenancePartId = Convert.ToInt32(dgvMaintenanceParts.CurrentRow.Cells[0].Value.ToString());
                        var maintenanceParts = db.MaintenanceParts.GetEntity(t => t.intID == maintenancePartId);
                        if (maintenanceParts != null)
                        {
                            db.MaintenanceParts.Delete(maintenanceParts);
                            db.Save();
                            ListRefresh();
                        }
                    }
                }
                    
                else
                {
                    RtlMessageBox.Show("لطفا یک قطعه را انتخاب کنید", "خطا", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            
        }

        private void TxtCount_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void BtnSelectPart_Click(object sender, EventArgs e)
        {
            FrmSelectPart frmSelectPart=new FrmSelectPart();
            frmSelectPart.ShowDialog();

            labName.Text = frmSelectPart.partName;
            labCode.Text = frmSelectPart.partCode;
            labMeasurementUnit.Text = frmSelectPart.measurementUnit;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<string> maintenanceTypesList = new List<string>()
                {
                    MaintenanceTypes.MaintenaceTypes.تعمیر.ToString(), MaintenanceTypes.MaintenaceTypes.تعویض.ToString(),
                    MaintenanceTypes.MaintenaceTypes.گسترش.ToString()
                };
                var maintenanceType = 0;
                foreach (var item in maintenanceTypesList)
                {
                    if (item == (string)cbMaintenaceType.SelectedItem)
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
                var count = txtCount.Text.Trim();
                tabMaintenanceParts tabMaintenanceParts = new tabMaintenanceParts()
                {
                    intMaintenanceItem = maintenanceItemId,
                    bitSelect = false,
                    intCount = Convert.ToDouble(count),
                    intMaintenaceType = maintenanceType,
                    nvcPart = labCode.Text
                };
                db.MaintenanceParts.Insert(tabMaintenanceParts);
                db.Save();
                ListRefresh();
            }
        }
    }
}
