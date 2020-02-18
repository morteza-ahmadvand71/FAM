using Baran.Ferroalloy.Automation;
using Baran.Ferroalloy.Automation.Security;
using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Maintenance;
using Baran.Ferroalloy.Management.Technical;
using Baran.Ferroalloy.Office;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baran.Ferroalloy.Automation.Models;
using Baran.Ferroalloy.Management.Maintenance;

namespace Baran.Ferroalloy.Management
{
    public partial class PartInsert : Form
    {
        public Stuff stInsert;
        public StuffProperty spInsert;
        public Connection cnConnection;
        public User usUser;
        public FamSetting setSettings;
        //private Category[] caCategories;
        private StoreCode.Store[] stStores;
        private StoreCode.Section[] seSections;
        private StoreCode.Material[] maMaterials;
        private StoreCode.Type[] tyTypes;
        private MeasurementUnit[] meMeasurementUnits;
        private Property[] prProperties;



        public PartInsert()
        {
            InitializeComponent();

            this.stInsert = new Stuff();
        }

        private void PartInsert_Load(object sender, EventArgs e)
        {
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

                this.btm_NameEdit.Enabled = false;
                this.Btm_BranchEdit.Enabled = false;
                this.Btm_SubBranchEdit.Enabled = false;
                this.Btm_MeasurementUnitsEdit.Enabled = false;
                this.Btm_PropertiesRegister.Enabled = false;
            }

            //Fill cbCategory ComboBox
            //this.caCategories = Category.GetCategories(this.cnConnection);
            //foreach (Category ctCategory in this.caCategories)
            //{
            //    this.cbCategory.Items.Add(ctCategory.strName);
            //}

            ////Fill cbStores
            //this.stStores = StoreCode.GetStores(this.cnConnection);
            //foreach (StoreCode.Store stStore in this.stStores)
            //{
            //    this.cbStores.Items.Add(stStore.strName);
            //}

            ////Fill cbMeasuementUnits
            //this.cbMeasuementUnits.Items.Clear();
            //this.meMeasurementUnits = MeasurementUnit.GetMeasurementUnits(this.cnConnection);
            //foreach (MeasurementUnit meMeasurementUnit in this.meMeasurementUnits)
            //{
            //    this.cbMeasuementUnits.Items.Add(meMeasurementUnit.strName);
            //}

            ////Fill cbProperties
            //this.cbProperties.Items.Clear();
            //this.prProperties = Property.GetProperties(this.cnConnection);
            //foreach (Property prProperty in this.prProperties)
            //{
            //    this.cbProperties.Items.Add(prProperty.strName);
            //}
        }

        #region Stores

        private void CbStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbName.Items.Clear();
            this.cbCategories.SelectedIndex = -1;
            this.cbBranch.Items.Clear();
            this.cbSubBranch.Items.Clear();
            this.cbMeasuementUnits.Items.Clear();
            this.lbSelectedProperties.Items.Clear();
            lbSelectedProperties.Items.Clear();
            tbOrderPoint.Clear();
            //Fill cbMajorGroups
            //this.cbCategories.Items.Clear();
            //this.seSections = StoreCode.GetSections(this.cnConnection, this.stStores[this.cbStores.SelectedIndex].strCode);
            //foreach (StoreCode.Section seSections in this.seSections)
            //{
            //    this.cbCategories.Items.Add(seSections.strName);
            //}

            //this.cbName.Items.Clear();
            //this.cbTypes.Items.Clear();
            //this.labCode.Text = "";
            //this.labName.Text = "";

            SetEnableBtmOk();
        }

        #endregion

        #region Category

        private void CbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbName.Items.Clear();
            this.cbSubBranch.Items.Clear();
            this.cbBranch.Items.Clear();
            this.cbMeasuementUnits.Items.Clear();
            cbProperties.Items.Clear();
            lbSelectedProperties.Items.Clear();
            tbOrderPoint.Clear();
            using (UnitOfWork db = new UnitOfWork())
            {

                var categoryId = cbCategories.SelectedIndex;
                var names = db.Name.Get(t => t.intCategory == categoryId);
                foreach (var item in names)
                {
                    cbName.Items.Add(item.nvcName);
                }
                this.btm_NameEdit.Enabled = true;

            }
            //this.maMaterials = StoreCode.GetMaterials(this.cnConnection,
            //    this.stStores[this.cbStores.SelectedIndex].strCode,
            //    this.seSections[this.cbCategories.SelectedIndex].strCode);
            //foreach (StoreCode.Material miMinorGroup in this.maMaterials)
            //{
            //    this.cbMaterials.Items.Add(miMinorGroup.strName);
            //}

            this.labCode.Text = "";
            this.labName.Text = "";

            SetEnableBtmOk();
        }

        private void Btm_CategoryEdit_Click(object sender, EventArgs e)
        {
            FrmCategoryInsert frmCategoryInsert = new FrmCategoryInsert();
            frmCategoryInsert.ShowDialog();
            //FrmCategories categories = new FrmCategories();
            //categories.cnConnection = this.cnConnection;
            //categories.Owner = this;
            //seSections.strStore = this.stStores[this.cbStores.SelectedIndex].strCode;
            //categories.ShowDialog();
        }

        #endregion

        #region Name

        private void CbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbBranch.Items.Clear();
            this.cbSubBranch.Items.Clear();
            this.cbMeasuementUnits.Items.Clear();
            lbSelectedProperties.Items.Clear();
            tbOrderPoint.Clear();
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
                this.Btm_BranchEdit.Enabled = true;
            }
            SetEnableBtmOk();
        }

        private void Btm_NameEdit_Click(object sender, EventArgs e)
        {
            FrmNameInsert frmNameInsert = new FrmNameInsert();
            frmNameInsert.categoryName = cbCategories.SelectedItem.ToString();
            //frmNames.cnConnection = this.cnConnection;
            frmNameInsert.Owner = this;
            //seSections.strStore = this.stStores[this.cbStores.SelectedIndex].strCode;
            frmNameInsert.ShowDialog();
            this.cbCategories.SelectedIndex = -1;
        }

        #endregion

        #region Branch

        private void CbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbSubBranch.Items.Clear();
            this.cbMeasuementUnits.Items.Clear();
            lbSelectedProperties.Items.Clear();
            tbOrderPoint.Clear();
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
            this.Btm_SubBranchEdit.Enabled = true;
            SetEnableBtmOk();
        }

        private void Btm_BranchEdit_Click(object sender, EventArgs e)
        {
            FrmBranchInsert frmBranchInsert = new FrmBranchInsert();
            frmBranchInsert.name = cbName.SelectedItem.ToString();
            //frmBranchInsert.cnConnection = this.cnConnection;
            frmBranchInsert.Owner = this;
            //seSections.strStore = this.stStores[this.cbStores.SelectedIndex].strCode;
            frmBranchInsert.ShowDialog();
            this.cbCategories.SelectedIndex = -1;
            cbName.Items.Clear();
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
                if (parts != null)
                {
                    var properties = parts.nvcProperties.Split('-');
                    for (int i = 0; i < properties.Length; i++)
                    {
                        lbSelectedProperties.Items.Add(properties[i]);
                    }
                }

                var measurementUnits = db.MeasurementUnits.GetAll().Where(t => t.intCategory == int.Parse(categoryId));
                foreach (var item in measurementUnits)
                {
                    cbMeasuementUnits.Items.Add(item.nvcName);
                }
                this.Btm_MeasurementUnitsEdit.Enabled = true;
                this.Btm_PropertiesRegister.Enabled = true;
                Btm_PropertiesRegister.Enabled = true;
                Btm_PropertiesDelete.Enabled = true;
                lbSelectedProperties.Items.Clear();
                tbOrderPoint.Clear();
                SetEnableBtmOk();
            }
        }

        private void Btm_SubBranchEdit_Click(object sender, EventArgs e)
        {
            FrmSubBranchInsert frmSubBranchInsert = new FrmSubBranchInsert();
            frmSubBranchInsert.branchName = cbBranch.SelectedItem.ToString();
            //frmBranchInsert.cnConnection = this.cnConnection;
            frmSubBranchInsert.Owner = this;
            //seSections.strStore = this.stStores[this.cbStores.SelectedIndex].strCode;
            frmSubBranchInsert.ShowDialog();
            this.cbCategories.SelectedIndex = -1;
            cbName.Items.Clear();
            cbBranch.Items.Clear();
        }

        #endregion

        #region MeasurementUnits

        private void CbMeasuementUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var categoryId = db.Categories.GetEntityByName(t => t.nvcName == cbCategories.SelectedItem).intNumber;
                var measuementUnitsId = db.MeasurementUnits.GetEntityByName(t => t.nvcName == cbMeasuementUnits.SelectedItem).intNumber;
                var properties = db.properties.Get(t => t.intCategory == categoryId && t.intMeasurementUnit == measuementUnitsId);
                foreach (var item in properties)
                {
                    cbProperties.Items.Add(item.nvcName);
                }
            }
            SetEnableBtmOk();
        }

        private void Btm_MeasurementUnitsEdit_Click(object sender, EventArgs e)
        {
            FrmMeasurementUnitsInsert frmMeasurementUnitsInsert = new FrmMeasurementUnitsInsert();
            frmMeasurementUnitsInsert.categoryName = cbCategories.SelectedItem.ToString();
            frmMeasurementUnitsInsert.Owner = this;
            frmMeasurementUnitsInsert.ShowDialog();
            this.cbCategories.SelectedIndex = -1;
            cbName.Items.Clear();
            cbBranch.Items.Clear();
            cbSubBranch.Items.Clear();
            lbSelectedProperties.Items.Clear();
            tbOrderPoint.Clear();
            SetEnableBtmOk();
        }

        #endregion

        #region Properties

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
            SetEnableBtmOk();
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

        #endregion

        private void btmOK_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var storeId = db.Stores.GetEntityByName(t => t.nvcName == cbStores.SelectedItem).intNumber;
                var categoryId = db.Categories.GetEntityByName(t => t.nvcName == cbCategories.SelectedItem).intNumber;
                var nameId = db.Name.GetEntityByName(t => t.nvcName == cbName.SelectedItem).intNumber;
                var branchId = db.Branch.GetEntityByName(t => t.nvcName == cbBranch.SelectedItem).intNumber;
                var subBranchId = db.SubBranch.GetEntityByName(t => t.nvcName == cbSubBranch.SelectedItem).intNumber;
                var measuementUnitsId = db.MeasurementUnits.GetEntityByName(t => t.nvcName == cbMeasuementUnits.SelectedItem).intNumber;
                var orderPoint = tbOrderPoint.Text;
                var parts = db.Parts.GetEntity(t =>
                    t.intStore == storeId && t.intCategory == categoryId && t.intName == nameId &&
                    t.intBranch == branchId && t.intSubBranch == subBranchId);
                if (parts != null)
                {
                    RtlMessageBox.Show("این کالا قبلا ثبت شده است", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tabParts tabParts = new tabParts();

                    tabParts.bitSelect = false;
                    tabParts.floOrderPoint = double.Parse(orderPoint);
                    tabParts.floSupply = 0;
                    tabParts.intStore = storeId;
                    tabParts.intName = nameId;
                    tabParts.intCategory = categoryId;
                    tabParts.intBranch = branchId;
                    tabParts.intSubBranch = subBranchId;
                    tabParts.intMeasurementUnit = measuementUnitsId;
                    var listProperties = "";
                    foreach (var item in lbSelectedProperties.Items)
                    {
                        listProperties += item + "-";
                    }
                    listProperties = listProperties.Remove(listProperties.Length - 1);
                    tabParts.nvcProperties = listProperties;
                    db.Parts.Insert(tabParts);
                    db.Save();
                    DialogResult = DialogResult.OK;
                }
            }

            //if (!Stuff.IsStuff(this.cnConnection, this.stInsert.strStoreCode))
            //{
            //    this.btmOK.Enabled = false;
            //    this.stInsert.strStore = this.stStores[this.cbStores.SelectedIndex].strCode;
            //    this.stInsert.strSection = this.seSections[this.cbCategories.SelectedIndex].strCode;
            //    this.stInsert.strMaterial = this.maMaterials[this.cbName.SelectedIndex].strCode;
            //    this.stInsert.strType = this.tyTypes[this.cbBranch.SelectedIndex].strCode;
            //    //this.stInsert.intCategory = this.caCategories[this.cbCategory.SelectedIndex].intNumber;
            //    this.stInsert.strMeasurementUnit = this.meMeasurementUnits[this.cbMeasuementUnits.SelectedIndex].strCode;
            //    this.stInsert.dobOrderPoint = Double.Parse(this.tbOrderPoint.Text.Trim());
            //    this.stInsert.Insert(this.cnConnection);

            //    //for (int i = 0; i < this.lbSelectedProperties.Items.Count; i++)
            //    //{
            //    //    this.spInsert = new StuffProperty();
            //    //    this.spInsert.strStoreCode = this.stInsert.strStoreCode;
            //    //    this.spInsert.strProperty = Property.GetCodeByName(this.cnConnection, this.lbSelectedProperties.Items[i].ToString());
            //    //    this.spInsert.Insert(this.cnConnection);
            //    //}

            //    Parts frmStuffs = (Parts)this.Owner;
            //    frmStuffs.SearchStuffs();
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show(".این کالا پیش از این ثبت شده است");
            //}

        }











        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void CbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SetEnableBtmOk();
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

        private void CbCodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.labName.Text = this.cbName.Text + " - " + this.cbBranch.Text;
            this.labCode.Text = this.stStores[this.cbStores.SelectedIndex].strCode +
                this.seSections[this.cbCategories.SelectedIndex].strCode +
                this.maMaterials[this.cbName.SelectedIndex].strCode +
                this.tyTypes[this.cbBranch.SelectedIndex].strCode;

            SetEnableBtmOk();
        }

        private void BtmInsertToList_Click(object sender, EventArgs e)
        {
            //if(!this.lbSelectedProperties.Items.Contains(this.cbProperties.Text))
            //{
            //    this.lbSelectedProperties.Items.Add(this.cbProperties.Text);
            //}

            //if(this.lbSelectedProperties.Items.Count == 4)
            //{
            //    this.btmInsertToList.Enabled = false;
            //}

            SetEnableBtmOk();
        }

        private void BtmTakeOutFromList_Click(object sender, EventArgs e)
        {
            //this.lbSelectedProperties.Items.RemoveAt(this.lbSelectedProperties.SelectedIndex);
            //if (this.lbSelectedProperties.Items.Count < 4)
            //{
            //    this.btmInsertToList.Enabled = true;
            //}

            SetEnableBtmOk();
        }

        private void LbSelectedProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.btmTakeOutFromList.Enabled = true;
        }

        private void CbProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.btmInsertToList.Enabled = true;
        }

        private void BtmInsertToList_MouseEnter(object sender, EventArgs e)
        {
            //this.btmInsertToList.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._1_2;
        }

        private void BtmInsertToList_MouseLeave(object sender, EventArgs e)
        {
            //this.btmInsertToList.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._1_1;
        }

        private void BtmTakeOutFromList_MouseEnter(object sender, EventArgs e)
        {
            //this.btmTakeOutFromList.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._2_2;
        }

        private void BtmTakeOutFromList_MouseLeave(object sender, EventArgs e)
        {
            //this.btmTakeOutFromList.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._2_1;
        }

        private void btm_StoreEdit_MouseEnter(object sender, EventArgs e)
        {
            this.btm_StoreEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_2;
        }

        private void btm_StoreEdit_MouseLeave(object sender, EventArgs e)
        {
            this.btm_StoreEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
        }

        private void btm_StoreEdit_Click(object sender, EventArgs e)
        {
            FrmStoreInsert frmCategoryInsert = new FrmStoreInsert();
            frmCategoryInsert.ShowDialog();
            //Stores stStores = new Stores();
            //stStores.cnConnection = this.cnConnection;
            //stStores.Owner = this;
            //stStores.ShowDialog();
        }

        private void Btm_SectionEdit_MouseEnter(object sender, EventArgs e)
        {
            this.btm_CategoryEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_2;
        }

        private void Btm_SectionEdit_MouseLeave(object sender, EventArgs e)
        {
            this.btm_CategoryEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
        }



        private void Btm_MaterialEdit_MouseEnter(object sender, EventArgs e)
        {
            this.btm_NameEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_2;
        }

        private void Btm_MaterialEdit_MouseLeave(object sender, EventArgs e)
        {
            this.btm_NameEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
        }

        private void Btm_MaterialEdit_Click(object sender, EventArgs e)
        {
            StoreCode.Material maSearchLoc = new StoreCode.Material();
            maSearchLoc.intID = this.seSections[this.cbCategories.SelectedIndex].intID;
            maSearchLoc.strStore = this.seSections[this.cbCategories.SelectedIndex].strStore;
            maSearchLoc.strSection = this.seSections[this.cbCategories.SelectedIndex].strCode;

            Materials maMaterials = new Materials();
            maMaterials.cnConnection = this.cnConnection;
            maMaterials.Owner = this;
            maMaterials.maSearch = maSearchLoc;
            maMaterials.ShowDialog();
        }

        private void BtmTypes_MouseEnter(object sender, EventArgs e)
        {
            this.Btm_BranchEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_2;
        }

        private void BtmTypes_MouseLeave(object sender, EventArgs e)
        {
            this.Btm_BranchEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
        }

        private void BtmTypes_Click(object sender, EventArgs e)
        {
            StoreCode.Type tyTypeLoc = new StoreCode.Type();
            tyTypeLoc.intID = this.maMaterials[this.cbName.SelectedIndex].intID;
            tyTypeLoc.strStore = this.maMaterials[this.cbName.SelectedIndex].strStore;
            tyTypeLoc.strSection = this.maMaterials[this.cbName.SelectedIndex].strSection;
            tyTypeLoc.strMaterial = this.maMaterials[this.cbName.SelectedIndex].strCode;

            Types tyType = new Types();
            tyType.cnConnection = this.cnConnection;
            tyType.Owner = this;
            tyType.tySearch = tyTypeLoc;
            tyType.ShowDialog();
        }

        public void FillStores()
        {
            this.cbStores.Items.Clear();
            this.stStores = StoreCode.GetStores(this.cnConnection);
            foreach (StoreCode.Store stStore in this.stStores)
            {
                this.cbStores.Items.Add(stStore.strName);
            }

            this.cbCategories.Items.Clear();
            this.cbName.Items.Clear();
            this.cbBranch.Items.Clear();
            this.labCode.Text = "";
            this.labName.Text = "";
        }

        public void FillSections()
        {
            this.cbCategories.Items.Clear();
            this.seSections = StoreCode.GetSections(this.cnConnection, this.stStores[this.cbStores.SelectedIndex].strCode);
            foreach (StoreCode.Section seSections in this.seSections)
            {
                this.cbCategories.Items.Add(seSections.strName);
            }

            this.cbName.Items.Clear();
            this.cbBranch.Items.Clear();
            this.labCode.Text = "";
            this.labName.Text = "";
        }

        public void FillMaterials()
        {
            this.cbName.Items.Clear();
            this.maMaterials = StoreCode.GetMaterials(this.cnConnection,
              this.stStores[this.cbStores.SelectedIndex].strCode,
              this.seSections[this.cbCategories.SelectedIndex].strCode);
            foreach (StoreCode.Material miMinorGroup in this.maMaterials)
            {
                this.cbName.Items.Add(miMinorGroup.strName);
            }

            this.cbBranch.Items.Clear();
            this.labCode.Text = "";
            this.labName.Text = "";
        }

        public void FillTypes()
        {
            this.cbBranch.Items.Clear();
            this.tyTypes = StoreCode.GetTypes(this.cnConnection,
                this.stStores[this.cbStores.SelectedIndex].strCode,
                this.seSections[this.cbCategories.SelectedIndex].strCode,
                this.maMaterials[this.cbName.SelectedIndex].strCode);
            foreach (StoreCode.Type coCode in this.tyTypes)
            {
                this.cbBranch.Items.Add(coCode.strName);
            }

            this.labCode.Text = "";
            this.labName.Text = "";
        }



        private void TbOrderPoint_TextChanged(object sender, EventArgs e)
        {
            this.btmOK.Enabled = true;
            SetEnableBtmOk();
        }
    }
}
