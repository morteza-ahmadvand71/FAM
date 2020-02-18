using Baran.Ferroalloy.Automation;
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

namespace Baran.Ferroalloy.Management
{
    public partial class StuffUpdate : Form
    {
        public Stuff stUpdate;
        public Connection cnConnection;
        private Category[] caCategories;
        private StoreCode.Store[] stStores;
        private StoreCode.Section[] seSections;
        private StoreCode.Material[] maMaterials;
        private StoreCode.Type[] tyTypes;
        private MeasurementUnit[] meMeasurementUnits;
        public StuffProperty[] spUpdate;
        private Property[] prProperties;
        private string strOrginalStoreCode;

        public StuffUpdate()
        {
            InitializeComponent();
        }

        private void StuffUpdate_Load(object sender, EventArgs e)
        {
            this.strOrginalStoreCode = this.stUpdate.strStoreCode;

            //Fill cbCategory ComboBox
            this.caCategories = Category.GetCategories(this.cnConnection);
            foreach (Category ctCategory in this.caCategories)
            {
                this.cbCategory.Items.Add(ctCategory.strName);
            }

            //Fill cbStores
            FillStores();

            //Fill cbMeasuementUnits
            this.cbMeasuementUnits.Items.Clear();
            this.meMeasurementUnits = MeasurementUnit.GetMeasurementUnits(this.cnConnection);
            foreach (MeasurementUnit meMeasurementUnit in this.meMeasurementUnits)
            {
                this.cbMeasuementUnits.Items.Add(meMeasurementUnit.strName);
            }

            //Fill cbProperties
            this.cbProperties.Items.Clear();
            this.prProperties = Property.GetProperties(this.cnConnection);
            foreach (Property prProperty in this.prProperties)
            {
                this.cbProperties.Items.Add(prProperty.strName);
            }

            //Fill lbSelectedProperties
            this.spUpdate = StuffProperty.GetStuffProperties(this.cnConnection, this.stUpdate.strStoreCode);
            foreach(StuffProperty spStuffProperty in this.spUpdate)
            {
                this.lbSelectedProperties.Items.Add(Property.GetNameByCode(this.cnConnection,spStuffProperty.strProperty));
            }

            //Fill Controls with Part Properties
            this.cbStores.Text = StoreCode.GetStoreNameByCode(this.cnConnection, this.stUpdate.strStore);
            this.cbSections.Text = StoreCode.GetSectionNameByCode(this.cnConnection, this.stUpdate.strStore, this.stUpdate.strSection);
            this.cbMaterials.Text = StoreCode.GetMaterialNameByCode(this.cnConnection, this.stUpdate.strStore, this.stUpdate.strSection,this.stUpdate.strMaterial);
            this.cbTypes.Text = StoreCode.GetTypeNameByCode(this.cnConnection, this.stUpdate.strStore, this.stUpdate.strSection, this.stUpdate.strMaterial, this.stUpdate.strType);
            this.cbCategory.Text = Category.GetNameByNumber(this.cnConnection, this.stUpdate.intCategory);
            this.cbMeasuementUnits.Text = MeasurementUnit.GetNameByCode(this.cnConnection, this.stUpdate.strMeasurementUnit);
            this.tbOrderPoint.Text = this.stUpdate.dobOrderPoint.ToString();

            SetEnableBtmOk();
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            if(this.strOrginalStoreCode == this.stUpdate.strStoreCode)
            {
                this.btmOK.Enabled = false;
                this.stUpdate.strStore = this.stStores[this.cbStores.SelectedIndex].strCode;
                this.stUpdate.strSection = this.seSections[this.cbSections.SelectedIndex].strCode;
                this.stUpdate.strMaterial = this.maMaterials[this.cbMaterials.SelectedIndex].strCode;
                this.stUpdate.strType = this.tyTypes[this.cbTypes.SelectedIndex].strCode;
                this.stUpdate.intCategory = this.caCategories[this.cbCategory.SelectedIndex].intNumber;
                this.stUpdate.strMeasurementUnit = this.meMeasurementUnits[this.cbMeasuementUnits.SelectedIndex].strCode;
                this.stUpdate.dobOrderPoint = Double.Parse(this.tbOrderPoint.Text.Trim());
                this.stUpdate.Update(this.cnConnection);

                for (int i = 0; i < this.lbSelectedProperties.Items.Count; i++)
                {
                    bool bolPropertyIsExist = false;
                    string strCodeLoc = Property.GetCodeByName(this.cnConnection, this.lbSelectedProperties.Items[i].ToString());
                    for (int j = 0; j < this.spUpdate.Length; j++)
                    {
                        if (strCodeLoc == this.spUpdate[j].strProperty)
                        {
                            bolPropertyIsExist = true;
                        }
                    }

                    if (!bolPropertyIsExist)
                    {
                        StuffProperty spInsertLoc = new StuffProperty();
                        spInsertLoc.strStoreCode = this.stUpdate.strStoreCode;
                        spInsertLoc.strProperty = Property.GetCodeByName(this.cnConnection, this.lbSelectedProperties.Items[i].ToString());
                        spInsertLoc.Insert(this.cnConnection);
                    }
                }

                for (int j = 0; j < this.spUpdate.Length; j++)
                {
                    bool bolPropertyIsExist = false;
                    for (int i = 0; i < this.lbSelectedProperties.Items.Count; i++)
                    {
                        string strCodeLoc = Property.GetCodeByName(this.cnConnection, this.lbSelectedProperties.Items[i].ToString());
                        if (strCodeLoc == this.spUpdate[j].strProperty)
                        {
                            bolPropertyIsExist = true;
                        }
                    }

                    if (!bolPropertyIsExist)
                    {
                        this.spUpdate[j].Delete(this.cnConnection);
                    }
                }

                Parts frmStuffs = (Parts)this.Owner;
                frmStuffs.SearchStuffs();
                this.Close();
            }
            else if(!Stuff.IsStuff(this.cnConnection, this.stUpdate.strStoreCode))
            {
                this.btmOK.Enabled = false;
                this.stUpdate.strStore = this.stStores[this.cbStores.SelectedIndex].strCode;
                this.stUpdate.strSection = this.seSections[this.cbSections.SelectedIndex].strCode;
                this.stUpdate.strMaterial = this.maMaterials[this.cbMaterials.SelectedIndex].strCode;
                this.stUpdate.strType = this.tyTypes[this.cbTypes.SelectedIndex].strCode;
                this.stUpdate.intCategory = this.caCategories[this.cbCategory.SelectedIndex].intNumber;
                this.stUpdate.strMeasurementUnit = this.meMeasurementUnits[this.cbMeasuementUnits.SelectedIndex].strCode;
                this.stUpdate.dobOrderPoint = Double.Parse(this.tbOrderPoint.Text.Trim());
                this.stUpdate.Update(this.cnConnection);

                for (int i = 0; i < this.lbSelectedProperties.Items.Count; i++)
                {
                    bool bolPropertyIsExist = false;
                    string strCodeLoc = Property.GetCodeByName(this.cnConnection, this.lbSelectedProperties.Items[i].ToString());
                    for (int j = 0; j < this.spUpdate.Length; j++)
                    {
                        if (strCodeLoc == this.spUpdate[j].strProperty)
                        {
                            bolPropertyIsExist = true;
                        }
                    }

                    if (!bolPropertyIsExist)
                    {
                        StuffProperty spInsertLoc = new StuffProperty();
                        spInsertLoc.strStoreCode = this.stUpdate.strStoreCode;
                        spInsertLoc.strProperty = Property.GetCodeByName(this.cnConnection, this.lbSelectedProperties.Items[i].ToString());
                        spInsertLoc.Insert(this.cnConnection);
                    }
                }

                for (int j = 0; j < this.spUpdate.Length; j++)
                {
                    bool bolPropertyIsExist = false;
                    for (int i = 0; i < this.lbSelectedProperties.Items.Count; i++)
                    {
                        string strCodeLoc = Property.GetCodeByName(this.cnConnection, this.lbSelectedProperties.Items[i].ToString());
                        if (strCodeLoc == this.spUpdate[j].strProperty)
                        {
                            bolPropertyIsExist = true;
                        }
                    }

                    if (!bolPropertyIsExist)
                    {
                        this.spUpdate[j].Delete(this.cnConnection);
                    }
                }

                Parts frmStuffs = (Parts)this.Owner;
                frmStuffs.SearchStuffs();
                this.Close();
            }
            else
            {
                MessageBox.Show(".این کالا پیش از این ثبت شده است");
            }
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fill cbMajorGroups
            FillSections();
         
            SetEnableBtmOk();
        }

        private void CbSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fill cbMinorGroups
            FillMaterials();

            SetEnableBtmOk();
        }

        private void CbMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fill cbCodes
            FillTypes();

            SetEnableBtmOk();
        }

        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
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
            if (this.cbTypes.SelectedIndex >= 0 && this.cbStores.SelectedIndex >= 0 &&
                this.cbSections.SelectedIndex >= 0 && this.cbMaterials.SelectedIndex >= 0 &&
                this.cbCategory.SelectedIndex >= 0 && this.cbMeasuementUnits.SelectedIndex >= 0 &&
                this.tbOrderPoint.Text.Trim().Length != 0 && this.lbSelectedProperties.Items.Count >= 2)
            {
                this.btmOK.Enabled = true;
            }
            else
            {
                this.btmOK.Enabled = false;
            }
        }

        private void CbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.labName.Text = this.cbMaterials.Text + " - " + this.cbTypes.Text;
            this.labCode.Text = this.stStores[this.cbStores.SelectedIndex].strCode +
                this.seSections[this.cbSections.SelectedIndex].strCode +
                this.maMaterials[this.cbMaterials.SelectedIndex].strCode +
                this.tyTypes[this.cbTypes.SelectedIndex].strCode;

            SetEnableBtmOk();
        }

        private void CbProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btmInsertToList.Enabled = true;

            SetEnableBtmOk();
        }

        private void LbSelectedProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btmTakeOutFromList.Enabled = true;
        }

        private void BtmInsertToList_Click(object sender, EventArgs e)
        {
            if (!this.lbSelectedProperties.Items.Contains(this.cbProperties.Text))
            {
                this.lbSelectedProperties.Items.Add(this.cbProperties.Text);
            }

            if (this.lbSelectedProperties.Items.Count == 4)
            {
                this.btmInsertToList.Enabled = false;
            }

            SetEnableBtmOk();
        }

        private void BtmTakeOutFromList_Click(object sender, EventArgs e)
        {
            this.lbSelectedProperties.Items.RemoveAt(this.lbSelectedProperties.SelectedIndex);
            if (this.lbSelectedProperties.Items.Count < 4)
            {
                this.btmInsertToList.Enabled = true;
            }

            SetEnableBtmOk();
        }

        private void BtmStoreEdit_MouseEnter(object sender, EventArgs e)
        {
            this.btmStoreEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_2;
        }

        private void BtmStoreEdit_MouseLeave(object sender, EventArgs e)
        {
            this.btmStoreEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
        }

        private void BtmStoreEdit_Click(object sender, EventArgs e)
        {
            Stores stStores = new Stores();
            stStores.cnConnection = this.cnConnection;
            stStores.Owner = this;
            stStores.ShowDialog();
        }

        private void BtmSectionEdit_MouseEnter(object sender, EventArgs e)
        {
            this.btmSectionEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_2;
        }

        private void BtmSectionEdit_MouseLeave(object sender, EventArgs e)
        {
            this.btmSectionEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
        }

        private void BtmSectionEdit_Click(object sender, EventArgs e)
        {
            //FrmCategories frmCategories = new FrmCategories();
            //frmCategories.cnConnection = this.cnConnection;
            //frmCategories.Owner = this;
            //frmCategories.strStore = this.stStores[this.cbStores.SelectedIndex].strCode;
            //frmCategories.ShowDialog();
        }

        private void BtmMaterialEdit_MouseEnter(object sender, EventArgs e)
        {
            this.btmMaterialEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_2;
        }

        private void BtmMaterialEdit_MouseLeave(object sender, EventArgs e)
        {
            this.btmMaterialEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
        }

        private void BtmMaterialEdit_Click(object sender, EventArgs e)
        {
            StoreCode.Material maSearchLoc = new StoreCode.Material();
            maSearchLoc.intID = this.seSections[this.cbSections.SelectedIndex].intID;
            maSearchLoc.strStore = this.seSections[this.cbSections.SelectedIndex].strStore;
            maSearchLoc.strSection = this.seSections[this.cbSections.SelectedIndex].strCode;

            Materials maMaterials = new Materials();
            maMaterials.cnConnection = this.cnConnection;
            maMaterials.Owner = this;
            maMaterials.maSearch = maSearchLoc;
            maMaterials.ShowDialog();
        }

        private void BtmTypeEdit_MouseEnter(object sender, EventArgs e)
        {
            this.btmTypeEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_2;
        }

        private void BtmTypeEdit_MouseLeave(object sender, EventArgs e)
        {
            this.btmTypeEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
        }

        private void BtmTypeEdit_Click(object sender, EventArgs e)
        {
            StoreCode.Type tyTypeLoc = new StoreCode.Type();
            tyTypeLoc.intID = this.maMaterials[this.cbMaterials.SelectedIndex].intID;
            tyTypeLoc.strStore = this.maMaterials[this.cbMaterials.SelectedIndex].strStore;
            tyTypeLoc.strSection = this.maMaterials[this.cbMaterials.SelectedIndex].strSection;
            tyTypeLoc.strMaterial = this.maMaterials[this.cbMaterials.SelectedIndex].strCode;

            Types tyType = new Types();
            tyType.cnConnection = this.cnConnection;
            tyType.Owner = this;
            tyType.tySearch = tyTypeLoc;
            tyType.ShowDialog();
        }

        private void BtmInsertToList_MouseEnter(object sender, EventArgs e)
        {
            this.btmInsertToList.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._1_2;
        }

        private void BtmInsertToList_MouseLeave(object sender, EventArgs e)
        {
            this.btmInsertToList.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._1_1;
        }

        private void BtmTakeOutFromList_MouseEnter(object sender, EventArgs e)
        {
            this.btmTakeOutFromList.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._2_2;
        }

        private void BtmTakeOutFromList_MouseLeave(object sender, EventArgs e)
        {
            this.btmTakeOutFromList.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._2_1;
        }

        private void CbMeasuementUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbOrderPoint_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        public void FillStores()
        {
            this.cbStores.Items.Clear();
            this.stStores = StoreCode.GetStores(this.cnConnection);
            foreach (StoreCode.Store stStore in this.stStores)
            {
                this.cbStores.Items.Add(stStore.strName);
            }

            this.cbSections.Items.Clear();
            this.cbMaterials.Items.Clear();
            this.cbTypes.Items.Clear();
            this.labCode.Text = "";
            this.labName.Text = "";
        }

        public void FillSections()
        {
            this.cbSections.Items.Clear();
            this.seSections = StoreCode.GetSections(this.cnConnection, this.stStores[this.cbStores.SelectedIndex].strCode);
            foreach (StoreCode.Section seSections in this.seSections)
            {
                this.cbSections.Items.Add(seSections.strName);
            }

            this.cbMaterials.Items.Clear();
            this.cbTypes.Items.Clear();
            this.labCode.Text = "";
            this.labName.Text = "";
        }

        public void FillMaterials()
        {
            this.cbMaterials.Items.Clear();
            this.maMaterials = StoreCode.GetMaterials(this.cnConnection,
              this.stStores[this.cbStores.SelectedIndex].strCode,
              this.seSections[this.cbSections.SelectedIndex].strCode);
            foreach (StoreCode.Material miMinorGroup in this.maMaterials)
            {
                this.cbMaterials.Items.Add(miMinorGroup.strName);
            }

            this.cbTypes.Items.Clear();
            this.labCode.Text = "";
            this.labName.Text = "";
        }

        public void FillTypes()
        {
            this.cbTypes.Items.Clear();
            this.tyTypes = StoreCode.GetTypes(this.cnConnection,
                this.stStores[this.cbStores.SelectedIndex].strCode,
                this.seSections[this.cbSections.SelectedIndex].strCode,
                this.maMaterials[this.cbMaterials.SelectedIndex].strCode);
            foreach (StoreCode.Type coCode in this.tyTypes)
            {
                this.cbTypes.Items.Add(coCode.strName);
            }

            this.labCode.Text = "";
            this.labName.Text = "";
        }
    }

}
