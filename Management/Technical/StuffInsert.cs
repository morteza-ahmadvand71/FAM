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

namespace Baran.Ferroalloy.Management
{
    public partial class StuffInsert : Form
    {
        public Stuff stInsert;
        public StuffProperty spInsert;
        public Connection cnConnection;
        public User usUser;
        public FamSetting setSettings;
        private Category[] caCategories;
        private StoreCode.Store[] stStores;
        private StoreCode.Section[] seSections;
        private StoreCode.Material[] maMaterials;
        private StoreCode.Type[] tyTypes;
        private MeasurementUnit[] meMeasurementUnits;
        private Property[] prProperties;

        public StuffInsert()
        {
            InitializeComponent();

            this.stInsert = new Stuff();
        }

        private void StuffInsert_Load(object sender, EventArgs e)
        {
            //Fill cbCategory ComboBox
            this.caCategories = Category.GetCategories(this.cnConnection);
            foreach (Category ctCategory in this.caCategories)
            {
                this.cbCategory.Items.Add(ctCategory.strName);
            }

            //Fill cbStores
            this.stStores = StoreCode.GetStores(this.cnConnection);
            foreach (StoreCode.Store stStore in this.stStores)
            {
                this.cbStores.Items.Add(stStore.strName);
            }

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
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            if (!Stuff.IsStuff(this.cnConnection, this.stInsert.strStoreCode))
            {
                this.btmOK.Enabled = false;
                this.stInsert.strStore = this.stStores[this.cbStores.SelectedIndex].strCode;
                this.stInsert.strSection = this.seSections[this.cbSections.SelectedIndex].strCode;
                this.stInsert.strMaterial = this.maMaterials[this.cbMaterials.SelectedIndex].strCode;
                this.stInsert.strType = this.tyTypes[this.cbTypes.SelectedIndex].strCode;
                this.stInsert.intCategory = this.caCategories[this.cbCategory.SelectedIndex].intNumber;
                this.stInsert.strMeasurementUnit = this.meMeasurementUnits[this.cbMeasuementUnits.SelectedIndex].strCode;
                this.stInsert.dobOrderPoint = Double.Parse(this.tbOrderPoint.Text.Trim());
                this.stInsert.Insert(this.cnConnection);

                for (int i = 0; i < this.lbSelectedProperties.Items.Count; i++)
                {
                    this.spInsert = new StuffProperty();
                    this.spInsert.strStoreCode = this.stInsert.strStoreCode;
                    this.spInsert.strProperty = Property.GetCodeByName(this.cnConnection, this.lbSelectedProperties.Items[i].ToString());
                    this.spInsert.Insert(this.cnConnection);
                }

                Stuffs frmStuffs = (Stuffs)this.Owner;
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

            SetEnableBtmOk();
        }

        private void CbSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fill cbMinorGroups
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

            SetEnableBtmOk();
        }

        private void CbMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fill cbTypes
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

            SetEnableBtmOk();
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
            if (this.cbTypes.SelectedIndex >= 0 && this.cbStores.SelectedIndex >= 0 &&
                this.cbSections.SelectedIndex >= 0 && this.cbMaterials.SelectedIndex >= 0 &&
                this.cbCategory.SelectedIndex >= 0 && this.cbMeasuementUnits.SelectedIndex >= 0 &&
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
            this.labName.Text = this.cbMaterials.Text + " - " + this.cbTypes.Text;
            this.labCode.Text = this.stStores[this.cbStores.SelectedIndex].strCode +
                this.seSections[this.cbSections.SelectedIndex].strCode +
                this.maMaterials[this.cbMaterials.SelectedIndex].strCode +
                this.tyTypes[this.cbTypes.SelectedIndex].strCode;

            SetEnableBtmOk();
        }

        private void BtmInsertToList_Click(object sender, EventArgs e)
        {
            if(!this.lbSelectedProperties.Items.Contains(this.cbProperties.Text))
            {
                this.lbSelectedProperties.Items.Add(this.cbProperties.Text);
            }
           
            if(this.lbSelectedProperties.Items.Count == 4)
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

        private void LbSelectedProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btmTakeOutFromList.Enabled = true;
        }

        private void CbProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btmInsertToList.Enabled = true;
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
            Stores stStores = new Stores();
            stStores.cnConnection = this.cnConnection;
            stStores.Owner = this;
            stStores.ShowDialog();
        }

        private void Btm_SectionEdit_MouseEnter(object sender, EventArgs e)
        {
            this.btm_SectionEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_2;
        }

        private void Btm_SectionEdit_MouseLeave(object sender, EventArgs e)
        {
            this.btm_SectionEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
        }

        private void Btm_SectionEdit_Click(object sender, EventArgs e)
        {
            Sections seSections = new Sections();
            seSections.cnConnection = this.cnConnection;
            seSections.Owner = this;
            seSections.strStore = this.stStores[this.cbStores.SelectedIndex].strCode;
            seSections.ShowDialog();
        }

        private void Btm_MaterialEdit_MouseEnter(object sender, EventArgs e)
        {
            this.btm_MaterialEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_2;
        }

        private void Btm_MaterialEdit_MouseLeave(object sender, EventArgs e)
        {
            this.btm_MaterialEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
        }

        private void Btm_MaterialEdit_Click(object sender, EventArgs e)
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

        private void BtmTypes_MouseEnter(object sender, EventArgs e)
        {
            this.btmTypeEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_2;
        }

        private void BtmTypes_MouseLeave(object sender, EventArgs e)
        {
            this.btmTypeEdit.BackgroundImage = global::Baran.Ferroalloy.Management.Properties.Resources._3_1;
        }

        private void BtmTypes_Click(object sender, EventArgs e)
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

        private void CbMeasuementUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbOrderPoint_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }
    }
}
