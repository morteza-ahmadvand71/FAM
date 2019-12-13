using Baran.Ferroalloy.Automation;
using Baran.Ferroalloy.Automation.Security;
using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Maintenance;
using Baran.Ferroalloy.Office;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baran.Ferroalloy.Management
{
    public partial class Stuffs : Form
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
        private Category[] caCategories;
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

        public Stuffs()
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

        private void Stuffs_Load(object sender, EventArgs e)
        {
            SetComponentsByPermisions();

            //Fill cbStores
            this.stStores = StoreCode.GetStores(this.cnConnection);
            this.cbStores.Items.Add("");
            foreach (StoreCode.Store stStore in this.stStores)
            {
                this.cbStores.Items.Add(stStore.strName);
            }

            //Fill cbCategory ComboBox
            this.caCategories = Category.GetCategories(this.cnConnection);
            this.cbCategory.Items.Add("");
            foreach (Category ctCategory in this.caCategories)
            {
                this.cbCategory.Items.Add(ctCategory.strName);
            }
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

        private void btmSearch_Click(object sender, EventArgs e)
        {
            this.btmSearch.Enabled = false;
            SearchStuffs();
            this.btmSearch.Enabled = true;
        }

        public void SearchStuffs()
        {
            this.stSearch.strStore = StoreCode.GetStoreCodeByName(this.cnConnection, this.cbStores.Text);
            this.stSearch.strSection = StoreCode.GetSectionCodeByName(this.cnConnection, this.stSearch.strStore, this.cbSections.Text);
            this.stSearch.strMaterial = StoreCode.GetMaterialCodeByName(this.cnConnection, this.stSearch.strStore, this.stSearch.strSection, this.cbMaterials.Text);
            this.stSearch.strType = StoreCode.GetTypeCodeByName(this.cnConnection, this.stSearch.strStore, this.stSearch.strSection, this.stSearch.strMaterial, this.cbTypes.Text);
            this.stSearch.intCategory = Category.GetNumberByName(this.cnConnection, this.cbCategory.Text);
            this.stSearch.strMeasurementUnit = MeasurementUnit.GetCodeByName(this.cnConnection, this.cbMeasuementUnits.Text);
           
            this.dsStuffs = Stuff.GetStuffs(this.cnConnection, this.stSearch);

            this.dgvStuffs.DataSource = this.dsStuffs;
            this.dgvStuffs.DataMember = "tabStuffs";

            for(int i=0;i<this.dgvStuffs.Rows.Count;i++)
            {
                this.dgvStuffs.Rows[i].Cells["intCategoryAsName"].Value = 
                    Category.GetNameByNumber(this.cnConnection,(int)this.dsStuffs.Tables["tabStuffs"].Rows[i]["intCategory"]);

                this.dgvStuffs.Rows[i].Cells["nvcStoreAsName"].Value =
                    StoreCode.GetStoreNameByCode(this.cnConnection, this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcStore"].ToString());

                this.dgvStuffs.Rows[i].Cells["nvcSectionAsName"].Value =
                    StoreCode.GetSectionNameByCode(this.cnConnection, this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcStore"].ToString(),
                    this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcSection"].ToString());

                this.dgvStuffs.Rows[i].Cells["nvcMaterialAsName"].Value =
                    StoreCode.GetMaterialNameByCode(this.cnConnection, 
                    this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcStore"].ToString(),
                    this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcSection"].ToString(),
                    this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcMaterial"].ToString());

                this.dgvStuffs.Rows[i].Cells["nvcTypeAsName"].Value =
                    StoreCode.GetTypeNameByCode(this.cnConnection,
                    this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcStore"].ToString(),
                    this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcSection"].ToString(),
                    this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcMaterial"].ToString(),
                    this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcType"].ToString());

                this.dgvStuffs.Rows[i].Cells["nvcMeasurementUnitAsName"].Value =
                    MeasurementUnit.GetNameByCode(this.cnConnection, this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcMeasurementUnit"].ToString());
            }
        }

        private void btmDelete_Click(object sender, EventArgs e)
        {
            Int16 intSelectedEmployees = 0;
            foreach (DataRow drEmployee in this.dsStuffs.Tables["tabStuffs"].Rows)
            {
                if ((Boolean)drEmployee["bitSelect"])
                {
                    ++intSelectedEmployees;
                }
            }

            if (intSelectedEmployees > 0)
            {
                DialogResult dialogResult = MessageBox.Show("آیا می خواهید " + intSelectedEmployees.ToString() + " کالا را حذف کنید؟", "حذف", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.btmDelete.Enabled = false;
                    Stuff.DeleteStuffs(this.cnConnection, this.dsStuffs);
                    SearchStuffs();
                    this.btmDelete.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show(".هیچ کالاای انتخاب نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
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
            StuffInsert frmStuffInsert = new StuffInsert();
            frmStuffInsert.Owner = this;
            frmStuffInsert.cnConnection = this.cnConnection;
            frmStuffInsert.ShowDialog();
            this.btmInsert.Enabled = true;
        }

        private void ShowPics(int intIDArg,int intPicsCountArg,int intPicNumberArg)
        {
            //String strPath = this.setSettings.strEquipPicsPathPty + @"\" + this.intPicsID.ToString() + "-" + intPicNumberArg.ToString() + ".jpg";
            //this.pbPicture.ImageLocation = strPath;

        }

        private void dgvStuffs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == -1)
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

        private void CbStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fill cbMajorGroups
            this.cbSections.Items.Clear();
            if(this.cbStores.SelectedIndex>0)
            {
                this.seSections = StoreCode.GetSections(this.cnConnection, this.stStores[this.cbStores.SelectedIndex - 1].strCode);
                this.cbSections.Items.Add("");
                foreach (StoreCode.Section seSection in this.seSections)
                {
                    this.cbSections.Items.Add(seSection.strName);
                }

                this.cbMaterials.Items.Clear();
                this.cbTypes.Items.Clear();
                this.labCode.Text = "";
                this.labName.Text = "";
            }
            
            SetEnableBtmSearch();
        }

        private void CbSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fill cbMinorGroups
            this.cbMaterials.Items.Clear();
            if (this.cbSections.SelectedIndex > 0)
            {
                this.maMaterials = StoreCode.GetMaterials(this.cnConnection,
               this.stStores[this.cbStores.SelectedIndex - 1].strCode,
               this.seSections[this.cbSections.SelectedIndex - 1].strCode);
                this.cbMaterials.Items.Add("");
                foreach (StoreCode.Material maMaterial in this.maMaterials)
                {
                    this.cbMaterials.Items.Add(maMaterial.strName);
                }

                this.cbTypes.Items.Clear();
                this.labCode.Text = "";
                this.labName.Text = "";
            }

            SetEnableBtmSearch();
        }

        private void CbMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fill cbCodes
            this.cbTypes.Items.Clear();
            if (this.cbMaterials.SelectedIndex > 0)
            {
                this.tyTypes = StoreCode.GetTypes(this.cnConnection,
               this.stStores[this.cbStores.SelectedIndex - 1].strCode,
               this.seSections[this.cbSections.SelectedIndex - 1].strCode,
               this.maMaterials[this.cbMaterials.SelectedIndex - 1].strCode);
                this.cbTypes.Items.Add("");
                foreach (StoreCode.Type tyType in this.tyTypes)
                {
                    this.cbTypes.Items.Add(tyType.strName);
                }

                this.labCode.Text = "";
                this.labName.Text = "";
            }

            SetEnableBtmSearch();
        }

        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fill cbMeasuementUnits
            this.cbMeasuementUnits.Items.Clear();
            this.meMeasurementUnits = MeasurementUnit.GetMeasurementUnits(this.cnConnection,this.caCategories[this.cbCategory.SelectedIndex-1].intNumber);
            this.cbMeasuementUnits.Items.Add("");
            foreach (MeasurementUnit meMeasurementUnit in this.meMeasurementUnits)
            {
                this.cbMeasuementUnits.Items.Add(meMeasurementUnit.strName);
            }

            //Fill cbProperties
            this.cbProperties.Items.Clear();
            this.prProperties = Property.GetProperties(this.cnConnection, this.caCategories[this.cbCategory.SelectedIndex - 1].intNumber);
            this.cbProperties.Items.Add("");
            foreach (Property prProperty in this.prProperties)
            {
                this.cbProperties.Items.Add(prProperty.strName);
            }

            SetEnableBtmSearch();
        }

        private void SetEnableBtmSearch()
        {
            if (this.cbTypes.SelectedIndex >= 1 || this.cbStores.SelectedIndex >= 1 ||
                this.cbSections.SelectedIndex >= 1 || this.cbMaterials.SelectedIndex >= 1 ||
                this.cbCategory.SelectedIndex >= 1 || this.cbMeasuementUnits.SelectedIndex >= 1 ||
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

        private void CbCodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.labName.Text = "";
            this.labCode.Text = "";

            if (this.cbTypes.SelectedIndex > 0)
            {
                this.labName.Text = this.cbMaterials.Text + " - " + this.cbTypes.Text;
                this.labCode.Text = this.stStores[this.cbStores.SelectedIndex - 1].strCode +
                    this.seSections[this.cbSections.SelectedIndex - 1].strCode +
                    this.maMaterials[this.cbMaterials.SelectedIndex - 1].strCode +
                    this.tyTypes[this.cbTypes.SelectedIndex - 1].strCode;
            }

            SetEnableBtmSearch();
        }

        private void dgvStuffs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvStuffs.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void dgvStuffs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.bolEnableBtmDeleteByInterface = false;

            for (int i = 0; i < this.dgvStuffs.Rows.Count; i++)
            {
                if ((bool)this.dgvStuffs.Rows[i].Cells["bitSelect"].Value)
                {
                    this.bolEnableBtmDeleteByInterface = true;
                }
            }

            SetEnableComponents();
        }

        private void DgvStuffs_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dgvStuffs.Rows.Count; i++)
            {
                this.dgvStuffs.Rows[i].Cells["intCategoryAsName"].Value =
                    Category.GetNameByNumber(this.cnConnection, (int)this.dsStuffs.Tables["tabStuffs"].Rows[i]["intCategory"]);

                this.dgvStuffs.Rows[i].Cells["nvcStoreAsName"].Value =
                    StoreCode.GetStoreNameByCode(this.cnConnection, this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcStore"].ToString());

                this.dgvStuffs.Rows[i].Cells["nvcSectionAsName"].Value =
                    StoreCode.GetSectionNameByCode(this.cnConnection, this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcStore"].ToString(),
                    this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcSection"].ToString());

                this.dgvStuffs.Rows[i].Cells["nvcMaterialAsName"].Value =
                    StoreCode.GetMaterialNameByCode(this.cnConnection,
                    this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcStore"].ToString(),
                    this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcSection"].ToString(),
                    this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcMaterial"].ToString());

                this.dgvStuffs.Rows[i].Cells["nvcTypeAsName"].Value =
                    StoreCode.GetTypeNameByCode(this.cnConnection,
                    this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcStore"].ToString(),
                    this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcSection"].ToString(),
                    this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcMaterial"].ToString(),
                    this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcType"].ToString());

                this.dgvStuffs.Rows[i].Cells["nvcMeasurementUnitAsName"].Value =
                    MeasurementUnit.GetNameByCode(this.cnConnection, this.dsStuffs.Tables["tabStuffs"].Rows[i]["nvcMeasurementUnit"].ToString());
            }
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
