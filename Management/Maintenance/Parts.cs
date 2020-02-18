using Baran.Ferroalloy.Automation;
using Baran.Ferroalloy.Automation.Security;
using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Maintenance;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Baran.Ferroalloy.Management.Maintenance;

namespace Baran.Ferroalloy.Management
{
    public partial class Parts : Form
    {
        public static Boolean bolIsRunning;
        public Connection cnConnection;
        public User usUser;
        public FamSetting setSettings;
        public DataSet dsStuffs;
        private StoreCode.Store[] stStores;
        private StoreCode.Section[] seSections;
        private StoreCode.Material[] maMaterials;
        private StoreCode.Type[] tyTypes;
        private MeasurementUnit[] meMeasurementUnits;
        //private Category[] caCategories;
        private Property[] prProperties;
        private Stuff stSearch;
        private Stuff stUpdate;
        //private int intPicsID;
        //private int intPicsCount;
        //private int intPicNumber;
        private bool bolEnableBtmSearchByInterface;
        private bool bolEnableBtmSearchByPermision;
        private bool bolEnableBtmDeleteByInterface;
        private bool bolEnableBtmDeleteByPermision;
        private bool bolEnableBtmInsertByInterface;
        private bool bolEnableBtmInsertByPermision;

        public Parts()
        {
            InitializeComponent();

            this.stSearch = new Stuff();
            this.stUpdate = new Stuff();
            bolIsRunning = true;
            this.bolEnableBtmSearchByInterface = false;
            this.bolEnableBtmSearchByPermision = false;
            this.bolEnableBtmDeleteByInterface = false;
            this.bolEnableBtmDeleteByPermision = false;
            this.bolEnableBtmInsertByInterface = true;
            this.bolEnableBtmInsertByPermision = false;
        }

        private void Parts_Load(object sender, EventArgs e)
        {
            SetComponentsByPermisions();

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

                dgvStuffs.AutoGenerateColumns = false;

            }

        }

        #region Stores

        private void CbStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbName.Items.Clear();
            this.cbCategories.SelectedIndex = -1;
            this.cbBranch.Items.Clear();
            this.cbSubBranch.Items.Clear();
            this.cbMeasuementUnits.Items.Clear();
            this.cbProperties.Items.Clear();
            //Fill cbMajorGroups
            //this.cbCategories.Items.Clear();
            //if (this.cbStores.SelectedIndex > 0)
            //{
            //    this.seSections = StoreCode.GetSections(this.cnConnection, this.stStores[this.cbStores.SelectedIndex - 1].strCode);
            //    this.cbCategories.Items.Add("");
            //    foreach (StoreCode.Section seSection in this.seSections)
            //    {
            //        this.cbCategories.Items.Add(seSection.strName);
            //    }

            //    this.cbName.Items.Clear();
            //    this.cbBranch.Items.Clear();
            //    this.labCode.Text = "";
            //    this.labName.Text = "";
            //}

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
                //this.maMaterials = StoreCode.GetMaterials(this.cnConnection,
                //    this.stStores[this.cbStores.SelectedIndex - 1].strCode,
                //    this.seSections[this.cbCategories.SelectedIndex - 1].strCode);
                //this.cbMaterials.Items.Add("");
                //foreach (StoreCode.Material maMaterial in this.maMaterials)
                //{
                //    this.cbMaterials.Items.Add(maMaterial.strName);
                //}
                using (UnitOfWork db = new UnitOfWork())
                {
                    var categoryId = cbCategories.SelectedIndex;
                    var names = db.Name.Get(t => t.intCategory == categoryId);
                    foreach (var item in names)
                    {
                        cbName.Items.Add(item.nvcName);
                    }

                    var measurementUnitses = db.MeasurementUnits.Get(t => t.intCategory == categoryId);
                    foreach (var item in measurementUnitses)
                    {
                        cbMeasuementUnits.Items.Add(item.nvcName);
                    }
                }
                this.cbBranch.Items.Clear();
                this.labCode.Text = "";
                this.labName.Text = "";
            }

            SetEnableBtmSearch();
        }
        private void CbSections_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        }

        private void CbMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fill cbCodes
            //this.cbBranch.Items.Clear();
            //if (this.cbNames.SelectedIndex > 0)
            //{
            //    this.tyTypes = StoreCode.GetTypes(this.cnConnection,
            //        this.stStores[this.cbStores.SelectedIndex - 1].strCode,
            //        this.seSections[this.cbCategories.SelectedIndex - 1].strCode,
            //        this.maMaterials[this.cbNames.SelectedIndex - 1].strCode);
            //    this.cbBranch.Items.Add("");
            //    foreach (StoreCode.Type tyType in this.tyTypes)
            //    {
            //        this.cbBranch.Items.Add(tyType.strName);
            //    }

            //    this.labCode.Text = "";
            //    this.labName.Text = "";
            //}

            //SetEnableBtmSearch();
        }

        #endregion

        #region Branch

        private void CbBranch_SelectedIndexChanged_1(object sender, EventArgs e)
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

        }

        private void CbCodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.labName.Text = "";
            //this.labCode.Text = "";

            //if (this.cbBranch.SelectedIndex > 0)
            //{
            //    this.labName.Text = this.cbNames.Text + " - " + this.cbBranch.Text;
            //    this.labCode.Text = this.stStores[this.cbStores.SelectedIndex - 1].strCode +
            //                        this.seSections[this.cbCategories.SelectedIndex - 1].strCode +
            //                        this.maMaterials[this.cbNames.SelectedIndex - 1].strCode +
            //                        this.tyTypes[this.cbBranch.SelectedIndex - 1].strCode;
            //}

            //SetEnableBtmSearch();
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

                var parts = db.Parts.GetAll().FirstOrDefault(t =>
                    t.intStore == int.Parse(storeId) && t.intCategory == int.Parse(categoryId) && t.intName == int.Parse(nameId) &&
                    t.intBranch == int.Parse(branchId) && t.intSubBranch == int.Parse(subBranchId));
                var properties = parts.nvcProperties.Split('-');
                for (int i = 0; i < properties.Length; i++)
                {
                    cbProperties.Items.Add(properties[i]);
                }
            }
        }

        #endregion

        private void btmSearch_Click(object sender, EventArgs e)
        {
            this.btmSearch.Enabled = false;
            //SearchStuffs();
            Filter();
            this.btmSearch.Enabled = true;
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
                dgvStuffs.DataSource = list;
            }
        }

        #endregion

        private void DgvStuffs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStuffs.CurrentRow != null)
            {
                PartUpdate partUpdate = new PartUpdate();
                partUpdate.partId = int.Parse(dgvStuffs.CurrentRow.Cells[0].Value.ToString());
                partUpdate.ShowDialog();
            }
        }

        private void btmDelete_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (RtlMessageBox.Show($"آیا از حذف مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var selectItems = dgvStuffs.Rows.Cast<DataGridViewRow>().Where(t => Convert.ToBoolean(t.Cells[1].Value) == true).ToList();

                    foreach (var item in selectItems)
                    {
                        var id = int.Parse(item.Cells[0].Value.ToString());
                        var part = db.Parts.GetEntity(t => t.intID == id);
                        db.Parts.Delete(part);
                        db.Save();
                        RtlMessageBox.Show("حذف با موفقیت انجام شد", "حذف کالا", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Filter();
                    }
                }
                 
            }
            //Int16 intSelectedEmployees = 0;
            //foreach (DataRow drEmployee in this.dsStuffs.Tables["tabStuffs"].Rows)
            //{
            //    if ((Boolean)drEmployee["bitSelect"])
            //    {
            //        ++intSelectedEmployees;
            //    }
            //}

            //if (intSelectedEmployees > 0)
            //{
            //    DialogResult dialogResult = MessageBox.Show("آیا می خواهید " + intSelectedEmployees.ToString() + " کالا را حذف کنید؟", "حذف", MessageBoxButtons.YesNo);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        this.btmDelete.Enabled = false;
            //        Stuff.DeleteStuffs(this.cnConnection, this.dsStuffs);
            //        SearchStuffs();
            //        this.btmDelete.Enabled = true;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show(".هیچ کالاای انتخاب نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }

        private void dgvStuffs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //this.bolEnableBtmDeleteByInterface = false;

            //for (int i = 0; i < this.dgvStuffs.Rows.Count; i++)
            //{
            //    if (bool.Parse(this.dgvStuffs.Rows[i].Cells[1].Value.ToString()))
            //    {
            //        this.bolEnableBtmDeleteByInterface = true;
            //    }
            //}

            //SetEnableComponents();
            btmDelete.Enabled = true;
        }








        private void SetComponentsByPermisions()
        {
            if (this.usUser.bolTechnicalEnabed)
            {
                this.bolEnableBtmSearchByPermision = true;
                this.bolEnableBtmDeleteByPermision = true;
                this.bolEnableBtmInsertByPermision = true;
                this.dgvStuffs.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStuffs_CellMouseDoubleClick);
                this.dgvStuffs.Columns["bitSelect"].Visible = true;
            }
            else
            {
                this.bolEnableBtmSearchByPermision = true;
                this.bolEnableBtmDeleteByPermision = false;
                this.bolEnableBtmInsertByPermision = false;
                this.dgvStuffs.CellMouseDoubleClick -= new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStuffs_CellMouseDoubleClick);
                this.dgvStuffs.Columns["bitSelect"].Visible = false;
            }

            SetEnableComponents();
        }

        private void SetEnableComponents()
        {
            this.btmSearch.Enabled = this.bolEnableBtmSearchByPermision & this.bolEnableBtmSearchByInterface;
            this.btmDelete.Enabled = this.bolEnableBtmDeleteByPermision & this.bolEnableBtmDeleteByInterface;
            this.btmInsert.Enabled = this.bolEnableBtmInsertByPermision & this.bolEnableBtmInsertByInterface;
        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Employees_FormClosing(object sender, FormClosingEventArgs e)
        {
            bolIsRunning = false;

            Management frmManagement = (Management)this.MdiParent;
            frmManagement.menWindows.DropDownItems["menWindowsStuffs"].Dispose();
        }

        private void btmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void SearchStuffs()
        {
            this.stSearch.strStore = StoreCode.GetStoreCodeByName(this.cnConnection, this.cbStores.Text);
            this.stSearch.strSection = StoreCode.GetSectionCodeByName(this.cnConnection, this.stSearch.strStore, this.cbCategories.Text);
            this.stSearch.strMaterial = StoreCode.GetMaterialCodeByName(this.cnConnection, this.stSearch.strStore, this.stSearch.strSection, this.cbName.Text);
            this.stSearch.strType = StoreCode.GetTypeCodeByName(this.cnConnection, this.stSearch.strStore, this.stSearch.strSection, this.stSearch.strMaterial, this.cbBranch.Text);
            //this.stSearch.intCategory = Category.GetNumberByName(this.cnConnection, this.cbCategory.Text);
            this.stSearch.strMeasurementUnit = MeasurementUnit.GetCodeByName(this.cnConnection, this.cbMeasuementUnits.Text);

            this.dsStuffs = Stuff.GetStuffs(this.cnConnection, this.stSearch);

            this.dgvStuffs.DataSource = this.dsStuffs;
            this.dgvStuffs.DataMember = "tabStuffs";

            //for (int i = 0; i < this.dgvStuffs.Rows.Count; i++)
            //{
            //    this.dgvStuffs.Rows[i].Cells["intCategoryAsName"].Value =
            //        Category.GetNameByNumber(this.cnConnection, (int)this.dsStuffs.Tables["tabStuffs"].Rows[i]["intCategory"]);

            //    this.dgvStuffs.Rows[i].Cells["nvcStoreAsName"].Value =
            //        StoreCode.GetStoreNameByCode(this.cnConnection, this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcStore"].ToString());

            //    this.dgvStuffs.Rows[i].Cells["nvcSectionAsName"].Value =
            //        StoreCode.GetSectionNameByCode(this.cnConnection, this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcStore"].ToString(),
            //        this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcSection"].ToString());

            //    this.dgvStuffs.Rows[i].Cells["nvcMaterialAsName"].Value =
            //        StoreCode.GetMaterialNameByCode(this.cnConnection,
            //        this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcStore"].ToString(),
            //        this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcSection"].ToString(),
            //        this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcMaterial"].ToString());

            //    this.dgvStuffs.Rows[i].Cells["nvcTypeAsName"].Value =
            //        StoreCode.GetTypeNameByCode(this.cnConnection,
            //        this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcStore"].ToString(),
            //        this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcSection"].ToString(),
            //        this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcMaterial"].ToString(),
            //        this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcType"].ToString());

            //    this.dgvStuffs.Rows[i].Cells["nvcMeasurementUnitAsName"].Value =
            //        MeasurementUnit.GetNameByCode(this.cnConnection, this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcMeasurementUnit"].ToString());
            //}
        }

       

        private void dgvStuffs_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                StuffUpdate frmPStuffUpdate = new StuffUpdate();
                frmPStuffUpdate.Owner = this;
                this.stUpdate = new Stuff();
                frmPStuffUpdate.stUpdate = this.stUpdate;
                frmPStuffUpdate.cnConnection = this.cnConnection;

                this.stUpdate.intID = (int)this.dsStuffs.Tables["tabStuffs"].Rows[e.RowIndex]["intID"];
                this.stUpdate.strStore = this.dsStuffs.Tables["tabStuffs"].Rows[e.RowIndex]["nvcStore"].ToString();
                this.stUpdate.strSection = this.dsStuffs.Tables["tabStuffs"].Rows[e.RowIndex]["nvcSection"].ToString();
                this.stUpdate.strMaterial = this.dsStuffs.Tables["tabStuffs"].Rows[e.RowIndex]["nvcMaterial"].ToString();
                this.stUpdate.strType = this.dsStuffs.Tables["tabStuffs"].Rows[e.RowIndex]["nvcType"].ToString();
                this.stUpdate.intCategory = (int)this.dsStuffs.Tables["tabStuffs"].Rows[e.RowIndex]["intCategory"];
                this.stUpdate.strMeasurementUnit = this.dsStuffs.Tables["tabStuffs"].Rows[e.RowIndex]["nvcMeasurementUnit"].ToString();
                this.stUpdate.dobOrderPoint = (double)this.dsStuffs.Tables["tabStuffs"].Rows[e.RowIndex]["floOrderPoint"];
                this.stUpdate.dobSupply = (double)this.dsStuffs.Tables["tabStuffs"].Rows[e.RowIndex]["floSupply"];

                frmPStuffUpdate.ShowDialog();
            }
        }

        private void btmInsert_Click(object sender, EventArgs e)
        {
            this.btmInsert.Enabled = false;
            //FrmPartInsert frmPartInsert = new FrmPartInsert();
            //frmPartInsert.Owner = this;
            //frmPartInsert.ShowDialog();
            PartInsert frmStuffInsert = new PartInsert();
            frmStuffInsert.Owner = this;
            frmStuffInsert.cnConnection = this.cnConnection;
            frmStuffInsert.ShowDialog();
            this.btmInsert.Enabled = true;
        }

        private void ShowPics(int intIDArg, int intPicsCountArg, int intPicNumberArg)
        {
            //String strPath = this.setSettings.strEquipPicsPathPty + @"\" + this.intPicsID.ToString() + "-" + intPicNumberArg.ToString() + ".jpg";
            //this.pbPicture.ImageLocation = strPath;

        }

        private void dgvStuffs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1)
            {
                //this.intPicNumber = 1;
                //this.intPicsID = (Int16)this.dsStuffs.Tables["tabParts"].Rows[e.RowIndex]["intID"];
                //this.intPicsCount = (Byte)this.dsStuffs.Tables["tabParts"].Rows[e.RowIndex]["tinPicsCount"];
                //ShowPics(this.intPicsID, this.intPicsCount, this.intPicNumber);
            }
        }

        private void butPicNext_Click(object sender, EventArgs e)
        {
            //if (this.intPicNumber <= this.intPicsCount-1)
            //{
            //    this.intPicNumber += 1;
            //    ShowPics(this.intPicsID, this.intPicsCount, this.intPicNumber);
            //}

        }

        private void butPicBack_Click(object sender, EventArgs e)
        {
            //if (this.intPicNumber >= 2)
            //{
            //    this.intPicNumber -= 1;
            //    ShowPics(this.intPicsID, this.intPicsCount, this.intPicNumber);
            //}
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






        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fill cbMeasuementUnits
            this.cbMeasuementUnits.Items.Clear();
            //this.meMeasurementUnits = MeasurementUnit.GetMeasurementUnits(this.cnConnection, this.caCategories[this.cbCategory.SelectedIndex - 1].intNumber);
            this.cbMeasuementUnits.Items.Add("");
            foreach (MeasurementUnit meMeasurementUnit in this.meMeasurementUnits)
            {
                this.cbMeasuementUnits.Items.Add(meMeasurementUnit.strName);
            }

            //Fill cbProperties
            this.cbProperties.Items.Clear();
            //this.prProperties = Property.GetProperties(this.cnConnection, this.caCategories[this.cbCategory.SelectedIndex - 1].intNumber);
            this.cbProperties.Items.Add("");
            foreach (Property prProperty in this.prProperties)
            {
                this.cbProperties.Items.Add(prProperty.strName);
            }

            SetEnableBtmSearch();
        }

        private void SetEnableBtmSearch()
        {
            if (this.cbBranch.SelectedIndex >= 1 || this.cbStores.SelectedIndex >= 1 ||
                this.cbCategories.SelectedIndex >= 1 || this.cbName.SelectedIndex >= 1 ||
                //this.cbCategory.SelectedIndex >= 1 || this.cbMeasuementUnits.SelectedIndex >= 1 ||
                this.cbProperties.SelectedIndex >= 1)
            {
                this.bolEnableBtmSearchByInterface = true;
            }
            else
            {
                this.bolEnableBtmSearchByInterface = false;
            }

            SetEnableComponents();
        }




        private void dgvStuffs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvStuffs.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        
        private void DgvStuffs_Sorted(object sender, EventArgs e)
        {
            //for (int i = 0; i < this.dgvStuffs.Rows.Count; i++)
            //{
            //    this.dgvStuffs.Rows[i].Cells["intCategoryAsName"].Value =
            //        Category.GetNameByNumber(this.cnConnection, (int)this.dsStuffs.Tables["tabStuffs"].Rows[i]["intCategory"]);

            //    this.dgvStuffs.Rows[i].Cells["nvcStoreAsName"].Value =
            //        StoreCode.GetStoreNameByCode(this.cnConnection, this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcStore"].ToString());

            //    this.dgvStuffs.Rows[i].Cells["nvcSectionAsName"].Value =
            //        StoreCode.GetSectionNameByCode(this.cnConnection, this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcStore"].ToString(),
            //        this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcSection"].ToString());

            //    this.dgvStuffs.Rows[i].Cells["nvcMaterialAsName"].Value =
            //        StoreCode.GetMaterialNameByCode(this.cnConnection,
            //        this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcStore"].ToString(),
            //        this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcSection"].ToString(),
            //        this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcMaterial"].ToString());

            //    this.dgvStuffs.Rows[i].Cells["nvcTypeAsName"].Value =
            //        StoreCode.GetTypeNameByCode(this.cnConnection,
            //        this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcStore"].ToString(),
            //        this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcSection"].ToString(),
            //        this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcMaterial"].ToString(),
            //        this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcType"].ToString());

            //    this.dgvStuffs.Rows[i].Cells["nvcMeasurementUnitAsName"].Value =
            //        MeasurementUnit.GetNameByCode(this.cnConnection, this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcMeasurementUnit"].ToString());
            //}
        }

        private void CbProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmSearch();
        }

        private void CbMeasuementUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmSearch();
        }
    }
}
