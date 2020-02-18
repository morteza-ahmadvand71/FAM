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

namespace Baran.Ferroalloy.Management.Maintenance
{
    public partial class PartUpdate : Form
    {
        public int partId;

        public PartUpdate()
        {
            InitializeComponent();
        }

        private void PartUpdate_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var part = db.Parts.GetEntity(t => t.intID == partId);
                var stores = db.Stores.GetAll();
                foreach (var item in stores)
                {
                    this.cbStores.Items.Add(item.nvcName);
                }
                cbStores.SelectedItem = part.tabStores.nvcName;

                var categories = db.Categories.GetAll();
                foreach (var item in categories)
                {
                    this.cbCategories.Items.Add(item.nvcName);
                }
                cbCategories.SelectedItem = part.tabCategories.nvcName;

                cbName.SelectedItem = part.tabName.nvcName;

                cbBranch.SelectedItem = part.tabBranch.nvcName;

                cbSubBranch.SelectedItem = part.tabSubBranch.nvcName;

                labName.Text = part.tabName.nvcName + " " + part.tabBranch.nvcName + " " + part.tabSubBranch.nvcName;
                var storeId ="";
                var categoryId = "";
                var nameId = "";
                var branchId = "";
                var subBranchId = "";
                if (part.tabStores.intNumber.ToString().Length == 1)
                {
                    storeId = 0 + part.tabStores.intNumber.ToString();
                }
                else
                {
                    storeId = part.tabStores.intNumber.ToString();
                }
                if (part.tabCategories.intNumber.ToString().Length == 1)
                {
                    categoryId = 0 + part.tabCategories.intNumber.ToString();
                }
                else
                {
                    categoryId = part.tabCategories.intNumber.ToString();
                }
                if (part.tabName.intNumber.ToString().Length == 1)
                {
                    nameId = 0 + part.tabName.intNumber.ToString();
                }
                else
                {
                    nameId = part.tabName.intNumber.ToString();
                }
                if (part.tabBranch.intNumber.ToString().Length == 1)
                {
                    branchId = 0 + part.tabBranch.intNumber.ToString();
                }
                else
                {
                    branchId = part.tabBranch.intNumber.ToString();
                }
                if (part.tabSubBranch.intNumber.ToString().Length == 1)
                {
                    subBranchId = 0 + part.tabSubBranch.intNumber.ToString();
                }
                else
                {
                    subBranchId = part.tabSubBranch.intNumber.ToString();
                }
                labCode.Text = storeId + "" + categoryId + "" + nameId + "" + branchId + "" + subBranchId;
                var measurementUnits = db.MeasurementUnits.Get(t => t.intCategory == cbCategories.SelectedIndex);
                foreach (var item in measurementUnits)
                {
                    cbMeasuementUnits.Items.Add(item.nvcName);
                }
                cbMeasuementUnits.SelectedItem = part.tabMeasurementUnits.nvcName;

                tbOrderPoint.Text = part.floOrderPoint.ToString();

                SetEnableBtmOk();
            }
        }

        private void SetEnableBtmOk()
        {
            if (this.cbBranch.SelectedIndex >= 0 && this.cbStores.SelectedIndex >= 0 &&
                this.cbCategories.SelectedIndex >= 0 && this.cbName.SelectedIndex >= 0 &&
                this.cbSubBranch.SelectedIndex >= 0 && this.cbMeasuementUnits.SelectedIndex >= 0 &&
                this.tbOrderPoint.Text.Trim().Length != 0 && this.lbSelectedProperties.Items.Count >= 1)
            {
                this.btmOK.Enabled = true;
            }
            else
            {
                this.btmOK.Enabled = false;
            }
        }

        private void BtmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbName.Items.Clear();
            cbBranch.Items.Clear();
            cbSubBranch.Items.Clear();
            labName.Text = "";
            labCode.Text = "";
            cbMeasuementUnits.Items.Clear();
            cbProperties.Items.Clear();
            lbSelectedProperties.Items.Clear();
            tbOrderPoint.Text = "";
            using (UnitOfWork db = new UnitOfWork())
            {
                var categoryId = cbCategories.SelectedIndex;
                var names = db.Name.Get(t => t.intCategory == categoryId);
                foreach (var item in names)
                {
                    cbName.Items.Add(item.nvcName);
                }

                var measurementUnits = db.MeasurementUnits.Get(t => t.intCategory == categoryId);
                foreach (var item in measurementUnits)
                {
                    cbMeasuementUnits.Items.Add(item.nvcName);
                }
            }
        }

        private void CbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBranch.Items.Clear();
            cbSubBranch.Items.Clear();
            labName.Text = "";
            labCode.Text = "";
            cbProperties.Items.Clear();
            lbSelectedProperties.Items.Clear();
            tbOrderPoint.Text = "";
            using (UnitOfWork db = new UnitOfWork())
            {
                var name = cbName.SelectedItem;
                var branches = db.Branch.GetAll().Where(t => t.tabName.nvcName.Equals(name));
                foreach (var item in branches)
                {
                    cbBranch.Items.Add(item.nvcName);
                }

            }
        }

        private void CbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSubBranch.Items.Clear();
            labName.Text = "";
            labCode.Text = "";
            cbProperties.Items.Clear();
            lbSelectedProperties.Items.Clear();
            tbOrderPoint.Text = "";
            using (UnitOfWork db = new UnitOfWork())
            {
                var name = cbBranch.SelectedItem;
                var branches = db.SubBranch.GetAll().Where(t => t.tabBranch.nvcName.Equals(name));
                foreach (var item in branches)
                {
                    cbSubBranch.Items.Add(item.nvcName);
                }
            }
        }

        private void CbSubBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            labName.Text = "";
            labCode.Text = "";
            cbProperties.Items.Clear();
            lbSelectedProperties.Items.Clear();
            tbOrderPoint.Text = "";
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

            }
        }

        private void BtmOK_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var storeId = db.Stores.GetEntityByName(t => t.nvcName == cbStores.SelectedItem).intNumber;
                var categoryId = db.Categories.GetEntityByName(t => t.nvcName == cbCategories.SelectedItem).intNumber;
                var nameId = db.Name.GetEntityByName(t => t.nvcName == cbName.SelectedItem).intNumber;
                var branchId = db.Branch.GetEntityByName(t => t.nvcName == cbBranch.SelectedItem).intNumber;
                var subBranchId = db.SubBranch.GetEntityByName(t => t.nvcName == cbSubBranch.SelectedItem).intNumber;
                var measuementUnitsId = db.MeasurementUnits
                    .GetEntityByName(t => t.nvcName == cbMeasuementUnits.SelectedItem).intNumber;
                var orderPoint = tbOrderPoint.Text;
                var part = db.Parts.GetEntity(t => t.intID == partId);
                part.bitSelect = false;
                part.floOrderPoint = double.Parse(orderPoint);
                part.floSupply = 0;
                part.intStore = storeId;
                part.intName = nameId;
                part.intCategory = categoryId;
                part.intBranch = branchId;
                part.intSubBranch = subBranchId;
                part.intMeasurementUnit = measuementUnitsId;
                var listProperties = "";
                foreach (var item in lbSelectedProperties.Items)
                {
                    listProperties += item + "-";
                }

                listProperties = listProperties.Remove(listProperties.Length - 1);
                part.nvcProperties = listProperties;
                db.Parts.Update(part);
                db.Save();
                DialogResult = DialogResult.OK;
                
            }
        }

        private void CbMeasuementUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                var categoryId = db.Categories.GetEntityByName(t => t.nvcName == cbCategories.SelectedItem).intNumber;
                var measuementUnitsId = db.MeasurementUnits.GetEntityByName(t => t.nvcName == cbMeasuementUnits.SelectedItem).intNumber;
                var properties = db.properties.GetByWhere(t => t.intCategory == categoryId && t.intMeasurementUnit == measuementUnitsId);
                foreach (var item in properties)
                {
                    cbProperties.Items.Add(item.nvcName);
                    lbSelectedProperties.Items.Add(item.nvcName);
                }
            }
            
        }

        private void Btm_PropertiesRegister_Click(object sender, EventArgs e)
        {
            if (cbProperties.SelectedIndex == -1)
            {
                RtlMessageBox.Show("لطفا ویژگی مورد نظر را انتخاب کنید", "توجه", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                lbSelectedProperties.Items.Add(cbProperties.SelectedItem);
                cbProperties.SelectedIndex = -1;
                if (lbSelectedProperties.Items.Count == 5)
                {
                    this.Btm_PropertiesRegister.Enabled = false;
                }
            }
        }

        private void Btm_PropertiesDelete_Click(object sender, EventArgs e)
        {
            if (lbSelectedProperties.SelectedItem != null)
            {
                this.lbSelectedProperties.Items.RemoveAt(this.lbSelectedProperties.SelectedIndex);
                if (this.lbSelectedProperties.Items.Count < 4)
                {
                    this.Btm_PropertiesRegister.Enabled = true;
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا برای حذف ویژگی مورد نظر را انتخاب کنید", "اخطار", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
