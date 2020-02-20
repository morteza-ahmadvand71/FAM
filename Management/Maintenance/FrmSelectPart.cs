using Baran.Ferroalloy.Automation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baran.Ferroalloy.Management.Maintenance
{
    public partial class FrmSelectPart : Form
    {
        private bool bolEnableBtmSearchByInterface;
        public int partId;
        public string partName;
        public string partCode;
        public string measurementUnit;

        public FrmSelectPart()
        {
            InitializeComponent();
            bolEnableBtmSearchByInterface = false;
            partId = 0;
            partName = "";
            partCode = "";
            measurementUnit = "";
        }

        private void FrmSelectPart_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                //Fill cbStores
                var storeses = db.Stores.GetAll();
                foreach (var item in storeses)
                {
                    cbStores.Items.Add(item.nvcName);
                }
                //Fill cbCategory
                var categorieses = db.Categories.GetAll();
                foreach (var item in categorieses)
                {
                    cbCategories.Items.Add(item.nvcName);
                }

                dgvParts.AutoGenerateColumns = false;

            }
            SetEnableBtmSearch();
        }



        #region Filter

        public void Filter()
        {
            using (UnitOfWork db = new UnitOfWork())
            {

                var filter = db.Parts.GetAll().Where(t =>
                    t.tabStores.nvcName.Equals(cbStores.SelectedItem) ||
                    t.tabCategories.nvcName.Equals(cbCategories.SelectedItem) ||
                    t.tabName.nvcName.Equals(cbName.SelectedItem) ||
                    t.tabBranch.Equals(cbBranch.SelectedItem) ||
                    t.tabSubBranch.nvcName.Equals(cbSubBranch.SelectedItem));
                List<PartsViewModel> list = new List<PartsViewModel>();
                foreach (var item in filter)
                {
                    var parts = db.Parts.GetEntityById(item.intID);
                    list.Add(new PartsViewModel()
                    {
                        storeTitle = item.tabStores.nvcName,
                        categoryTitle = item.tabCategories.nvcName,
                        nameTitle = item.tabName.nvcName,
                        branchTitle = item.tabBranch.nvcName,
                        subBranchTitle = item.tabSubBranch.nvcName,
                        measurementUnitTitle = item.tabMeasurementUnits.nvcName,
                        floOrderPoint = parts.floOrderPoint,
                        floSupply = parts.floSupply,
                        intID = item.intID
                    });
                }
                dgvParts.DataSource = list;
            }
        }

        #endregion

        #region Stores

        private void CbStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbName.Items.Clear();
            this.cbCategories.SelectedIndex = -1;
            this.cbBranch.Items.Clear();
            this.cbSubBranch.Items.Clear();
            labCode.Text = "";
            labName.Text = "";

            SetEnableBtmSearch();
        }

        #endregion

        #region Categories

        private void CbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fill cbMinorGroups
            this.cbName.Items.Clear();
            this.cbSubBranch.Items.Clear();
            if (this.cbCategories.SelectedIndex > 0)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var categoryId = cbCategories.SelectedIndex;
                    var names = db.Name.Get(t => t.intCategory == categoryId);
                    foreach (var item in names)
                    {
                        cbName.Items.Add(item.nvcName);
                    }
                }
                this.cbBranch.Items.Clear();
                this.labCode.Text = "";
                this.labName.Text = "";
            }

            SetEnableBtmSearch();
        }

        #endregion

        #region Names

        private void cbNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbBranch.Items.Clear();
            using (UnitOfWork db = new UnitOfWork())
            {
                var name = cbName.SelectedItem;
                var branches = db.Branch.GetAll().Where(t => t.tabName.nvcName.Equals(name));
                foreach (var item in branches)
                {
                    cbBranch.Items.Add(item.nvcName);
                }
            }
            SetEnableBtmSearch();
        }

        #endregion

        #region Branch

        private void CbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbSubBranch.Items.Clear();
            using (UnitOfWork db = new UnitOfWork())
            {
                var name = cbBranch.SelectedItem;
                var branches = db.SubBranch.GetAll().Where(t => t.tabBranch.nvcName.Equals(name));
                foreach (var item in branches)
                {
                    cbSubBranch.Items.Add(item.nvcName);
                }
            }
            SetEnableBtmSearch();
        }

        #endregion

        #region SubBranch

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

                //var parts = db.Parts.GetAll().FirstOrDefault(t =>
                //    t.intStore == int.Parse(storeId) && t.intCategory == int.Parse(categoryId) && t.intName == int.Parse(nameId) &&
                //    t.intBranch == int.Parse(branchId) && t.intSubBranch == int.Parse(subBranchId));
            }
            SetEnableBtmSearch();
        }

        #endregion

        private void SetEnableBtmSearch()
        {
            if (this.cbBranch.SelectedIndex >= 1 || this.cbStores.SelectedIndex >= 1 ||
                this.cbCategories.SelectedIndex >= 1 || this.cbName.SelectedIndex >= 1)
            {
                this.btmSearch.Enabled = true;
            }
            else
            {
                this.btmSearch.Enabled = false;
            }
        }

        private void BtmSearch_Click(object sender, EventArgs e)
        {
            this.btmSearch.Enabled = false;
            Filter();
            this.btmSearch.Enabled = true;
        }

        private void BtmSelect_Click(object sender, EventArgs e)
        {
            if (dgvParts.CurrentRow != null)
            {
                partId = Convert.ToInt32(dgvParts.CurrentRow.Cells["intID"].Value.ToString());
                using (UnitOfWork db=new UnitOfWork())
                {
                    var parts = db.Parts.GetEntity(t => t.intID == partId);
                    partName = parts.tabName.nvcName + " " + parts.tabBranch.nvcName + " " + parts.tabSubBranch.nvcName;
                    var measurementUnits = db.MeasurementUnits.GetEntity(t => t.intCategory == parts.intCategory);
                    measurementUnit = measurementUnits.nvcName;
                    var storeId = parts.intStore.ToString();
                    if (storeId.Length == 1)
                    {
                        storeId = 0 + storeId;
                    }
                    else
                    {
                        storeId = storeId;
                    }

                    var categoryId = parts.intCategory.ToString();
                    if (categoryId.Length == 1)
                    {
                        categoryId = 0 + categoryId;
                    }
                    else
                    {
                        categoryId = categoryId;
                    }

                    var nameId = parts.intName.ToString();
                    if (nameId.Length == 1)
                    {
                        nameId = 0 + nameId;
                    }
                    else
                    {
                        nameId = nameId;
                    }

                    var branchId = parts.intBranch.ToString();
                    if (branchId.Length == 1)
                    {
                        branchId = 0 + branchId;
                    }
                    else
                    {
                        branchId = branchId;
                    }
                    var subBranchId = parts.intSubBranch.ToString();
                    if (subBranchId.Length == 1)
                    {
                        subBranchId = 0 + subBranchId;
                    }
                    else
                    {
                        subBranchId = subBranchId;
                    }
                    partCode = storeId + "-" + categoryId + "-" + nameId + "-" + branchId + "-" + subBranchId;
                }
                this.Close();
            }
            else
            {
                RtlMessageBox.Show("لطفا یک قطعه را انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
