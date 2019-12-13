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
    public partial class MaintenanceElectricalFurnaceUpdate : Form
    {
        public Connection cnConnection;
        public MaintenanceFurnaceItem mfiUpdate;
        private DataSet dsPrimaryPersons;
        private DataSet dsPrimaryEquips;
        private DataSet dsPersons;
        private DataSet dsEquips;

        public MaintenanceElectricalFurnaceUpdate()
        {
            InitializeComponent();
        }

        private void MaintenanceElectricalFurnaceUpdate_Load(object sender, EventArgs e)
        {         
            this.tbTag.Text = this.mfiUpdate.strEquipTagPty;
            this.tbTime.Text = this.mfiUpdate.tsTimePty.ToString();
            this.tbDuration.Text = this.mfiUpdate.tsDurationPty.ToString();
            this.tbTip.Text = this.mfiUpdate.strTipPty;

            this.dsPersons = MaintenanceFurnaceItem.GetItemPersons(this.cnConnection, this.mfiUpdate.intIDPty);
            this.dsPrimaryPersons = this.dsPersons.Copy();

            this.dsPersons.Tables["tabMaintenanceFurnacePersons"].Columns.Add("nvcName");
            this.dgvPersons.DataSource = this.dsPersons;
            this.dgvPersons.DataMember = "tabMaintenanceFurnacePersons";
            this.dgvPersons.Columns["intID"].Visible = false;
            foreach (DataRow drPerson in this.dsPersons.Tables["tabMaintenanceFurnacePersons"].Rows)
            {
                drPerson["nvcName"] = Employee.GetNameByCoID(this.cnConnection,drPerson["nvcPersonCoID"].ToString());
            }

            this.dsEquips = MaintenanceFurnaceItem.GetItemEquips(this.cnConnection, this.mfiUpdate.intIDPty);
            this.dsPrimaryEquips = this.dsEquips.Copy();
            this.dsEquips.Tables["tabMaintenanceFurnaceEquips"].Columns.Add("nvcName");
            this.dgvEquips.DataSource = this.dsEquips;
            this.dgvEquips.DataMember = "tabMaintenanceFurnaceEquips";
            this.dgvEquips.Columns["intID"].Visible = false;
            foreach (DataRow drEquip in this.dsEquips.Tables["tabMaintenanceFurnaceEquips"].Rows)
            {
                Stuff parSearch = new Stuff();
                //parSearch.strStoreCode = this.tbEquip.Text.Trim();
                //DataSet dsEquipResult = Part.GetParts(this.cnConnection, parSearch);
                //if (dsEquipResult.Tables["tabParts"].Rows.Count != 0)
                //{
                //    String strEquipNameCode = dsEquipResult.Tables["tabParts"].Rows[0]["nvcName"].ToString();
                //    //String strEquipName = EquipName.GetEquipnameByCode(this.cnConnection, strEquipNameCode);
                //    drEquip["nvcName"] = strEquipName;
                //}
            }
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            this.mfiUpdate.strEquipTagPty = this.tbTag.Text.Trim();
            this.mfiUpdate.tsDurationPty = TimeSpan.Parse(this.tbDuration.Text.Trim());
            this.mfiUpdate.strTipPty = this.tbTip.Text.Trim();
            this.mfiUpdate.tsTimePty = TimeSpan.Parse(this.tbTime.Text.Trim());
            this.mfiUpdate.Update(this.cnConnection);

            MaintenanceFurnaceItem.DeleteItemEquips(this.cnConnection, this.dsPrimaryEquips);
            MaintenanceFurnaceItem.DeleteItemPerson(this.cnConnection, this.dsPrimaryPersons);
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


        private void tbPersonCoID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && this.tbPersonCoID.Text.Trim().Length != 0)
            {
                String strPersonName = Employee.GetNameByCoID(this.cnConnection, this.tbPersonCoID.Text.Trim());
                if (strPersonName.Length != 0)
                {
                    this.dsPersons.Tables["tabMaintenanceFurnacePersons"].Rows.Add(-1,this.mfiUpdate.intIDPty, this.tbPersonCoID.Text.Trim(), strPersonName);
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
            if (e.KeyCode == Keys.Enter && this.tbEquip.Text.Trim().Length != 0 && this.tbEquipCount.Text.Trim().Length != 0)
            {
                Stuff parSearch = new Stuff();
                //parSearch.strStoreCodePty = this.tbEquip.Text.Trim();
                //DataSet dsEquipResult = Part.GetParts(this.cnConnection, parSearch);
                //if (dsEquipResult.Tables["tabParts"].Rows.Count != 0)
                //{
                //    String strEquipNameCode = dsEquipResult.Tables["tabParts"].Rows[0]["nvcName"].ToString();
                //    String strEquipName = EquipName.GetEquipnameByCode(this.cnConnection, strEquipNameCode);
                //    this.dsEquips.Tables["tabMaintenanceFurnaceEquips"].Rows.Add(-1,this.mfiUpdate.intIDPty, this.tbEquip.Text.Trim(),
                //        Double.Parse(this.tbEquipCount.Text.Trim()),strEquipName);
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
