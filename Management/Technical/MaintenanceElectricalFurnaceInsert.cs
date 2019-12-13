using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Maintenance;
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
    public partial class MaintenanceElectricalFurnaceInsert : Form
    {
        public Connection cnConnection;
        public MaintenanceFurnaceShift mfsInsert = new MaintenanceFurnaceShift();
        private MaintenanceFurnaceItem mfiInsert = new MaintenanceFurnaceItem();
        private DataSet dsPersons = new DataSet();
        private DataSet dsEquips = new DataSet();

        public MaintenanceElectricalFurnaceInsert()
        {
            InitializeComponent();
        }

        private void MaintenanceElectricalFurnaceInsert_Load(object sender, EventArgs e)
        {
            this.mfiInsert.intTabShiftIDPty = this.mfsInsert.intIDPty;
            
            DataTable dtPersons = new DataTable("tabMaintenanceFurnacePersons");
            dtPersons.Columns.Add("intTabItemsID");
            dtPersons.Columns.Add("nvcPersonCoID");
            dtPersons.Columns.Add("nvcPersonName");
            this.dsPersons.Tables.Add(dtPersons);

            DataTable dtEquips = new DataTable("tabMaintenanceFurnaceEquips");
            dtEquips.Columns.Add("intTabItemsID");
            dtEquips.Columns.Add("nvcStoreCode");
            dtEquips.Columns.Add("nvcName");
            dtEquips.Columns.Add("floAmount");
            this.dsEquips.Tables.Add(dtEquips);
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            this.mfiInsert.strEquipTagPty = this.tbTag.Text.Trim();
            this.mfiInsert.tsDurationPty = TimeSpan.Parse(this.tbDuration.Text.Trim());
            this.mfiInsert.strTipPty = this.tbTip.Text.Trim();
            this.mfiInsert.tsTimePty = TimeSpan.Parse(this.tbTime.Text.Trim());
            this.mfiInsert.intIDPty = this.mfiInsert.Insert(this.cnConnection);

            foreach(DataRow drPerson in this.dsPersons.Tables["tabMaintenanceFurnacePersons"].Rows)
            {
                drPerson["intTabItemsID"] = this.mfiInsert.intIDPty;
            }
            foreach (DataRow drEquip in this.dsEquips.Tables["tabMaintenanceFurnaceEquips"].Rows)
            {
                drEquip["intTabItemsID"] = this.mfiInsert.intIDPty;
            }

            MaintenanceFurnaceItem.InsertItemEquip(this.cnConnection, this.dsEquips);
            MaintenanceFurnaceItem.InsertItemPerson(this.cnConnection, this.dsPersons);

            MaintenanceElectricalFurnace frmMfi = (MaintenanceElectricalFurnace)this.Owner;
            frmMfi.GetCurrentMaintenanceShiftAndItems();
            this.Close();
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (this.cbCategory.SelectedIndex != 0)
            //{
            //    //Fill cbName ComboBox
            //    EquipName[] tyNames = EquipName.GetNamesByCategory(this.cnConnection, this.caCategories[this.cbCategory.SelectedIndex-1].strCodePty);
            //    this.cbName.Items.Clear();
            //    this.cbName.Items.Add("");
            //    foreach (EquipName ctCategory in tyNames)
            //    {
            //        this.cbName.Items.Add(ctCategory.strNamePty);
            //    }

            //    //Fill cbName ComboBox
            //    EquipMainProperty[] mpMainProperties = EquipMainProperty.GetMainPrpertiesByCategory(this.cnConnection, this.caCategories[this.cbCategory.SelectedIndex-1].strCodePty);
            //    this.cbMainProperty.Items.Clear();
            //    this.cbMainProperty.Items.Add("");
            //    foreach (EquipMainProperty mpPrperties in mpMainProperties)
            //    {
            //        this.cbMainProperty.Items.Add(mpPrperties.strNamePty);
            //    }
            //}
        }

        private void tbPersonCoID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && this.tbPersonCoID.Text.Trim().Length != 0)
            {
                String strPersonName = Employee.GetNameByCoID(this.cnConnection, this.tbPersonCoID.Text.Trim());
                if (strPersonName.Length != 0)
                { 
                    this.dsPersons.Tables["tabMaintenanceFurnacePersons"].Rows.Add(-1,this.tbPersonCoID.Text.Trim(), strPersonName);
                    this.dgvPersons.DataSource = this.dsPersons;
                    this.dgvPersons.DataMember = "tabMaintenanceFurnacePersons";
                }
                else
                {
                    MessageBox.Show("کد اشتباه است.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
            }
        }

        private void tbEquip_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && this.tbEquip.Text.Trim().Length != 0)
            {
                Stuff parSearch = new Stuff();
                //parSearch.strStoreCodePty = this.tbEquip.Text.Trim();
                //DataSet dsEquipResult = Part.GetParts(this.cnConnection, parSearch);
                //if (dsEquipResult.Tables["tabParts"].Rows.Count != 0)
                //{
                //    String strEquipNameCode = dsEquipResult.Tables["tabParts"].Rows[0]["nvcName"].ToString();
                //    //String strEquipName = EquipName.GetEquipnameByCode(this.cnConnection, strEquipNameCode);
                //    this.dsEquips.Tables["tabMaintenanceFurnaceEquips"].Rows.Add(-1,this.tbEquip.Text.Trim(),strEquipName,
                //        Double.Parse(this.tbEquipCount.Text.Trim()));
                //    this.dgvEquips.DataSource = this.dsEquips;
                //    this.dgvEquips.DataMember = "tabMaintenanceFurnaceEquips";
                //}
                //else
                //{
                //    MessageBox.Show("کد اشتباه است.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                //        MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                //}
            }
        }

        private void dgvPersons_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if(this.dgvPersons.SelectedRows.Count != 0)
                {
                    for (int i=0;i<this.dgvPersons.SelectedRows.Count;i++)
                    {
                        this.dsPersons.Tables["tabMaintenanceFurnacePersons"].Rows[this.dgvPersons.SelectedRows[i].Index].Delete();
                    } 
                }
            }
        }

        private void dgvEquips_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (this.dgvEquips.SelectedRows.Count != 0)
                {
                    for (int i = 0; i < this.dgvEquips.SelectedRows.Count; i++)
                    {
                        this.dsEquips.Tables["tabMaintenanceFurnacePersons"].Rows[this.dgvEquips.SelectedRows[i].Index].Delete();
                    }
                }
            }
        }
    }
}
