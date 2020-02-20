using Baran.Ferroalloy.Automation;
using Baran.Ferroalloy.Automation.Security;
using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Maintenance;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Baran.Ferroalloy.Automation.ViewModels.Maintenance;
using Baran.Ferroalloy.Management.Maintenance;

namespace Baran.Ferroalloy.Management
{
    public partial class FrmEquips : Form
    {

        public FrmEquips()
        {
            InitializeComponent();

        }

        private void FrmZones_Load(object sender, EventArgs e)
        {
            dgvEquips.AutoGenerateColumns = false;
            using (UnitOfWork db=new UnitOfWork())
            {
                var zones = db.Zone.GetAll();
                foreach (var item in zones)
                {
                    cbZones.Items.Add(item.nvcName);
                }

                var categories = db.Categories.GetAll();
                foreach (var item in categories)
                {
                    cbCategories.Items.Add(item.nvcName);
                }
            }
        }

        private void CbZones_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSubZones.Items.Clear();
            labCode.Text = "";
            labName.Text = "";
            using (UnitOfWork db=new UnitOfWork())
            {
                var subZones = db.SubZone.GetByWhere(t => t.tabZones.nvcName == cbZones.SelectedItem);
                foreach (var item in subZones)
                {
                    cbSubZones.Items.Add(item.nvcName);
                }
            }
        }

        private void CbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbEqiupName.Items.Clear();
            labCode.Text = "";
            labName.Text = "";
            using (UnitOfWork db=new UnitOfWork())
            {
                var equipName = db.EquipName.GetByWhere(t => t.tabCategories.nvcName == cbCategories.SelectedItem);
                foreach (var item in equipName)
                {
                    cbEqiupName.Items.Add(item.nvcName);
                }
            }
        }

        private void CbEqiupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            labCode.Text = "";
            labName.Text = "";
            using (UnitOfWork db=new UnitOfWork())
            {
                this.labName.Text = cbEqiupName.SelectedItem.ToString();
                var zoneId = db.Zone.GetEntityByName(t => t.nvcName == cbZones.SelectedItem).intNumber.ToString();
                if (zoneId.Length == 1)
                {
                    zoneId = 0 + zoneId;
                }
                else
                {
                    zoneId = zoneId;
                }

                var subZoneId = db.SubZone.GetEntityByName(t => t.nvcName == cbSubZones.SelectedItem).intNumber.ToString();
                if (subZoneId.Length == 1)
                {
                    subZoneId = 0 + subZoneId;
                }
                else
                {
                    subZoneId = subZoneId;
                }

                var categoryId = db.Categories.GetEntityByName(t => t.nvcName == cbCategories.SelectedItem).intNumber.ToString();
                if (categoryId.Length == 1)
                {
                    categoryId = 0 + categoryId;
                }
                else
                {
                    categoryId = categoryId;
                }

                var eqiupNameId = db.EquipName.GetEntityByName(t => t.nvcName == cbEqiupName.SelectedItem).intNumber.ToString();
                if (eqiupNameId.Length == 1)
                {
                    eqiupNameId = 0 + eqiupNameId;
                }
                else
                {
                    eqiupNameId = eqiupNameId;
                }

                labCode.Text = zoneId + "" + subZoneId + "" + categoryId + "" + eqiupNameId;
            }
        }

        private void BtmSearch_Click(object sender, EventArgs e)
        {
            Filter();
        }

        public void Filter()
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                var equips = db.Equip.GetAll().Where(t =>
                    t.tabZones.nvcName.Equals(cbZones.SelectedItem) ||
                    t.tabSubZones.nvcName.Equals(cbSubZones.SelectedItem) ||
                    t.tabCategories.nvcName.Equals(cbCategories.SelectedItem) ||
                    t.tabEquipName.Equals(cbEqiupName.SelectedItem));
                List<EquipsViewModel> list=new List<EquipsViewModel>();
                foreach (var item in equips)
                {
                    list.Add(new EquipsViewModel()
                    {
                        intID = item.intID,
                        categoryTitle = item.tabCategories.nvcName,
                        equipNameTitle = item.tabEquipName.nvcName,
                        subZoneTitle = item.tabSubZones.nvcName,
                        zoneTitle = item.tabZones.nvcName
                    });
                }

                dgvEquips.DataSource = list;
            }
        }

        private void BtmDelete_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (RtlMessageBox.Show($"آیا از حذف مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var selectItems = dgvEquips.Rows.Cast<DataGridViewRow>().Where(t => Convert.ToBoolean(t.Cells["bitSelect"].Value) == true).ToList();

                    foreach (var item in selectItems)
                    {
                        var id = int.Parse(item.Cells["intID"].Value.ToString());
                        var equips = db.Equip.GetEntity(t => t.intID == id);
                        db.Equip.Delete(equips);
                        db.Save();
                        //RtlMessageBox.Show("حذف با موفقیت انجام شد", "حذف کالا", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Filter();
                    }
                }

            }
        }

        private void BtmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtmInsert_Click(object sender, EventArgs e)
        {
            FrmEquipInsert frmEquipInsert=new FrmEquipInsert();
            frmEquipInsert.ShowDialog();
        }
    }
}
