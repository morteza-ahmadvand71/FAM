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
                //Fill cbStores
                var stores = db.Stores.GetAll();
                foreach (var item in stores)
                {
                    this.cbStores.Items.Add(item.nvcName);
                }
                //Fill Category
                var categories = db.Categories.GetAll();
                foreach (var item in categories)
                {
                    this.cbCategories.Items.Add(item.nvcName);
                }

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

        private void CbStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbName.Items.Clear();
            this.cbCategories.SelectedIndex = -1;
            this.cbBranch.Items.Clear();
            this.cbSubBranch.Items.Clear();
            txtCount.Clear();
            SetEnableBtmOk();
        }

        private void CbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbName.Items.Clear();
            this.cbSubBranch.Items.Clear();
            this.cbBranch.Items.Clear();
            txtCount.Clear();
            using (UnitOfWork db = new UnitOfWork())
            {

                var categoryId = cbCategories.SelectedIndex;
                var names = db.Name.Get(t => t.intCategory == categoryId);
                foreach (var item in names)
                {
                    cbName.Items.Add(item.nvcName);
                }

            }
            SetEnableBtmOk();
            this.labCode.Text = "";
            this.labName.Text = "";
        }

        private void CbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbBranch.Items.Clear();
            this.cbSubBranch.Items.Clear();
            txtCount.Clear();
            this.labCode.Text = "";
            this.labName.Text = "";
            using (UnitOfWork db = new UnitOfWork())
            {
                var name = cbName.SelectedItem;
                var branches = db.Branch.GetAll().Where(t => t.tabName.nvcName.Equals(name));
                foreach (var item in branches)
                {
                    cbBranch.Items.Add(item.nvcName);
                }
                SetEnableBtmOk();
            }
        }

        private void CbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbSubBranch.Items.Clear();
            txtCount.Clear();
            this.labCode.Text = "";
            this.labName.Text = "";
            using (UnitOfWork db = new UnitOfWork())
            {
                var name = cbBranch.SelectedItem;
                var branches = db.SubBranch.GetAll().Where(t => t.tabBranch.nvcName.Equals(name));
                foreach (var item in branches)
                {
                    cbSubBranch.Items.Add(item.nvcName);
                }
            }

            SetEnableBtmOk();
        }

        private void CbSubBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                this.labName.Text = cbName.SelectedItem + " " + cbBranch.SelectedItem + " " + cbSubBranch.SelectedItem;
                var storeId = db.Stores.GetEntityByName(t => t.nvcName == cbStores.SelectedItem).intNumber.ToString();
                if (storeId.Length == 1)
                {
                    storeId = 0 + storeId;
                }
                else
                {
                    storeId = storeId;
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
                var nameId = db.Name.GetEntityByName(t => t.nvcName == cbName.SelectedItem).intNumber.ToString();
                if (nameId.Length == 1)
                {
                    nameId = 0 + nameId;
                }
                else
                {
                    nameId = nameId;
                }
                var branchId = db.Branch.GetEntityByName(t => t.nvcName == cbBranch.SelectedItem).intNumber.ToString();
                if (branchId.Length == 1)
                {
                    branchId = 0 + branchId;
                }
                else
                {
                    branchId = branchId;
                }
                var subBranchId = db.SubBranch.GetEntityByName(t => t.nvcName == cbSubBranch.SelectedItem).intNumber.ToString();
                if (subBranchId.Length == 1)
                {
                    subBranchId = 0 + subBranchId;
                }
                else
                {
                    subBranchId = subBranchId;
                }
                this.labCode.Text = storeId + "" + categoryId + "" + nameId + "" + branchId + "" + subBranchId;

                txtCount.Clear();
                SetEnableBtmOk();
            }
        }

        private void SetEnableBtmOk()
        {
            if (this.cbBranch.SelectedIndex >= 0 && this.cbStores.SelectedIndex >= 0 &&
                this.cbCategories.SelectedIndex >= 0 && this.cbName.SelectedIndex >= 0 &&
                this.cbSubBranch.SelectedIndex >= 0 && this.cbMaintenaceType.SelectedIndex >= 0 &&
                this.txtCount.Text.Trim().Length != 0)
            {
                this.btnRegister.Enabled = true;
            }
            else
            {
                this.btnRegister.Enabled = false;
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var storeId = db.Stores.GetEntityByName(t => t.nvcName == cbStores.SelectedItem).intNumber.ToString();
                if (storeId.Length == 1)
                {
                    storeId = 0 + storeId;
                }
                else
                {
                    storeId = storeId;
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
                var nameId = db.Name.GetEntityByName(t => t.nvcName == cbName.SelectedItem).intNumber.ToString();
                if (nameId.Length == 1)
                {
                    nameId = 0 + nameId;
                }
                else
                {
                    nameId = nameId;
                }
                var branchId = db.Branch.GetEntityByName(t => t.nvcName == cbBranch.SelectedItem).intNumber.ToString();
                if (branchId.Length == 1)
                {
                    branchId = 0 + branchId;
                }
                else
                {
                    branchId = branchId;
                }
                var subBranchId = db.SubBranch.GetEntityByName(t => t.nvcName == cbSubBranch.SelectedItem).intNumber.ToString();
                if (subBranchId.Length == 1)
                {
                    subBranchId = 0 + subBranchId;
                }
                else
                {
                    subBranchId = subBranchId;
                }
                var part = storeId + "-" + categoryId + "-" + nameId + "-" + branchId + "-" + subBranchId;
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
                var count = txtCount.Text;
                tabMaintenanceParts tabMaintenanceParts = new tabMaintenanceParts()
                {
                    intMaintenanceItem = maintenanceItemId,
                    bitSelect = false,
                    intCount = Convert.ToDouble(count),
                    intMaintenaceType = maintenanceType,
                    nvcPart = part
                };
                db.MaintenanceParts.Insert(tabMaintenanceParts);
                db.Save();
                ListRefresh();
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
    }
}
