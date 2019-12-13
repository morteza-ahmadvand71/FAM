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
    public partial class SelectStuff : Form
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
        //private Category[] caCategories;
        private Stuff stSearch;
        public static string strStuffStoreCode;
        public static string strStuffName;


        public SelectStuff()
        {
            InitializeComponent();

            SelectStuff.strStuffStoreCode = "";
            SelectStuff.strStuffName = "";
            this.stSearch = new Stuff();
         
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

        }

        private void SetComponentsByPermisions()
        {
            if (this.usUser.bolTechnicalEnabed)
            {
                this.btmInsertStuff.Enabled = true;
            }
            else
            {
                this.btmInsertStuff.Enabled = false;
            }
        }

        private void Employees_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btmSearch_Click(object sender, EventArgs e)
        {
            SearchStuffs();
        }

        public void SearchStuffs()
        {
            if(this.cbStores.SelectedIndex >= 1)
            {
                this.stSearch.strStore = this.stStores[this.cbStores.SelectedIndex-1].strCode;
            }
            if (this.cbSections.SelectedIndex >= 1)
            {
                this.stSearch.strSection = this.seSections[this.cbSections.SelectedIndex-1].strCode;
            }
            if (this.cbMaterials.SelectedIndex >= 1)
            {
                this.stSearch.strMaterial = this.maMaterials[this.cbMaterials.SelectedIndex-1].strCode;
            }
            if (this.cbTypes.SelectedIndex >= 1)
            {
                this.stSearch.strType = this.tyTypes[this.cbTypes.SelectedIndex-1].strCode;
            }
            

            this.dsStuffs = Stuff.GetStuffs(this.cnConnection, this.stSearch);

            this.dgvStuffs.DataSource = this.dsStuffs;
            this.dgvStuffs.DataMember = "tabStuffs";

            for(int i=0;i<this.dgvStuffs.Rows.Count;i++)
            {
                this.dgvStuffs.Rows[i].Cells["intCategoryAsName"].Value = 
                    Category.GetNameByNumber(this.cnConnection, (int)this.dgvStuffs.Rows[i].Cells["intCategory"].Value);

                this.dgvStuffs.Rows[i].Cells["nvcStoreAsName"].Value =
                    StoreCode.GetStoreNameByCode(this.cnConnection, this.dgvStuffs.Rows[i].Cells["nvcStore"].Value.ToString());

                this.dgvStuffs.Rows[i].Cells["nvcSectionAsName"].Value =
                    StoreCode.GetSectionNameByCode(this.cnConnection, this.dgvStuffs.Rows[i].Cells["nvcStore"].Value.ToString(),
                    this.dgvStuffs.Rows[i].Cells["nvcSection"].Value.ToString());

                this.dgvStuffs.Rows[i].Cells["nvcMaterialAsName"].Value =
                    StoreCode.GetMaterialNameByCode(this.cnConnection,
                    this.dgvStuffs.Rows[i].Cells["nvcStore"].Value.ToString(),
                    this.dgvStuffs.Rows[i].Cells["nvcSection"].Value.ToString(),
                    this.dgvStuffs.Rows[i].Cells["nvcMaterial"].Value.ToString());

                this.dgvStuffs.Rows[i].Cells["nvcTypeAsName"].Value =
                    StoreCode.GetTypeNameByCode(this.cnConnection,
                    this.dgvStuffs.Rows[i].Cells["nvcStore"].Value.ToString(),
                    this.dgvStuffs.Rows[i].Cells["nvcSection"].Value.ToString(),
                    this.dgvStuffs.Rows[i].Cells["nvcMaterial"].Value.ToString(),
                    this.dgvStuffs.Rows[i].Cells["nvcType"].Value.ToString());
            }
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
            this.seSections = StoreCode.GetSections(this.cnConnection,this.stStores[this.cbStores.SelectedIndex-1].strCode);
            this.cbSections.Items.Add("");
            foreach (StoreCode.Section seSection in this.seSections)
            {
                this.cbSections.Items.Add(seSection.strName);
            }

            this.cbMaterials.Items.Clear();
            this.cbTypes.Items.Clear();
            this.labCode.Text = "";
            this.labName.Text = "";

            SetEnableBtmSearch(new object(), new EventArgs());
        }

        private void CbSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fill cbMinorGroups
            this.cbMaterials.Items.Clear();
            this.maMaterials = StoreCode.GetMaterials(this.cnConnection,
               this.stStores[this.cbStores.SelectedIndex - 1].strCode,
               this.seSections[this.cbSections.SelectedIndex - 1].strCode);
            this.cbMaterials.Items.Add("");
            foreach (StoreCode.Material maMaterial in this.maMaterials)
            {
                this.cbMaterials.Items.Add(maMaterial.strName);
            }

            SetEnableBtmSearch(new object(), new EventArgs());

            this.cbTypes.Items.Clear();
            this.labCode.Text = "";
            this.labName.Text = "";
        }

        private void CbMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fill cbCodes
            this.cbTypes.Items.Clear();
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

            SetEnableBtmSearch(new object(), new EventArgs());
        }

        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           SetEnableBtmSearch(new object(), new EventArgs());
        }

        private void SetEnableBtmSearch(object sender, EventArgs e)
        {
            if (this.cbTypes.SelectedIndex >= 1 || this.cbStores.SelectedIndex >= 1 ||
                this.cbSections.SelectedIndex >= 1 || this.cbMaterials.SelectedIndex >= 1 )
            {
                this.btmSearch.Enabled = true;
            }
            else
            {
                this.btmSearch.Enabled = false;
            }
        }

        private void CbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.labName.Text = this.cbMaterials.Text + " - " + this.cbTypes.Text;
            this.labCode.Text = this.stStores[this.cbStores.SelectedIndex - 1].strCode +
                this.seSections[this.cbSections.SelectedIndex - 1].strCode +
                this.maMaterials[this.cbMaterials.SelectedIndex - 1].strCode +
                this.tyTypes[this.cbTypes.SelectedIndex - 1].strCode;

            SetEnableBtmSearch(new object(), new EventArgs());
        }

        private void BtmSelect_Click(object sender, EventArgs e)
        {
            SelectStuff.strStuffStoreCode = this.dgvStuffs.Rows[0].Cells["nvcStore"].Value.ToString() + "-" +
                this.dgvStuffs.Rows[this.dgvStuffs.SelectedRows[0].Index].Cells["nvcSection"].Value.ToString() + "-" +
                this.dgvStuffs.Rows[this.dgvStuffs.SelectedRows[0].Index].Cells["nvcMaterial"].Value.ToString() + "-" +
                this.dgvStuffs.Rows[this.dgvStuffs.SelectedRows[0].Index].Cells["nvcType"].Value.ToString();
            SelectStuff.strStuffName = 
                this.dgvStuffs.Rows[this.dgvStuffs.SelectedRows[0].Index].Cells["nvcMaterialAsName"].Value.ToString() + "-" +
                this.dgvStuffs.Rows[this.dgvStuffs.SelectedRows[0].Index].Cells["nvcTypeAsName"].Value.ToString();

            this.Close();
        }

        private void DgvStuffs_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == -1 && e.RowIndex != -1)
            {
                this.btmSelect.Enabled = true;
            }
            else
            {
                this.btmSelect.Enabled = false;
            }
        }

        private void DgvStuffs_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dgvStuffs.Rows.Count; i++)
            {
                this.dgvStuffs.Rows[i].Cells["intCategoryAsName"].Value =
                    Category.GetNameByNumber(this.cnConnection, (int)this.dgvStuffs.Rows[i].Cells["intCategory"].Value);

                this.dgvStuffs.Rows[i].Cells["nvcStoreAsName"].Value =
                    StoreCode.GetStoreNameByCode(this.cnConnection, this.dgvStuffs.Rows[i].Cells["nvcStore"].Value.ToString());

                this.dgvStuffs.Rows[i].Cells["nvcSectionAsName"].Value =
                    StoreCode.GetSectionNameByCode(this.cnConnection, this.dgvStuffs.Rows[i].Cells["nvcStore"].Value.ToString(),
                    this.dgvStuffs.Rows[i].Cells["nvcSection"].Value.ToString());

                this.dgvStuffs.Rows[i].Cells["nvcMaterialAsName"].Value =
                    StoreCode.GetMaterialNameByCode(this.cnConnection,
                    this.dgvStuffs.Rows[i].Cells["nvcStore"].Value.ToString(),
                    this.dgvStuffs.Rows[i].Cells["nvcSection"].Value.ToString(),
                    this.dgvStuffs.Rows[i].Cells["nvcMaterial"].Value.ToString());

                this.dgvStuffs.Rows[i].Cells["nvcTypeAsName"].Value =
                    StoreCode.GetTypeNameByCode(this.cnConnection,
                    this.dgvStuffs.Rows[i].Cells["nvcStore"].Value.ToString(),
                    this.dgvStuffs.Rows[i].Cells["nvcSection"].Value.ToString(),
                    this.dgvStuffs.Rows[i].Cells["nvcMaterial"].Value.ToString(),
                    this.dgvStuffs.Rows[i].Cells["nvcType"].Value.ToString());
            }
        }

        private void BtmInsertStuff_Click(object sender, EventArgs e)
        {
            StuffInsert frmStuffInsert = new StuffInsert();
            frmStuffInsert.cnConnection = this.cnConnection;
            frmStuffInsert.setSettings = this.setSettings;
            frmStuffInsert.usUser = this.usUser;
            frmStuffInsert.ShowDialog();
        }
    }
}
