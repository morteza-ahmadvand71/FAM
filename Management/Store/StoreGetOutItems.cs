using Baran.Ferroalloy.Automation.Security;
using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Finance;
using Baran.Ferroalloy.Maintenance;
using Baran.Ferroalloy.Office;
using Baran.Ferroalloy.Store;
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
    public partial class StoreGetOutItems : Form
    {
        public Connection cnConnection;
        public User usUser;
        public FamSetting setSettings;
        public StoreGetOut sgoStoreGetOut;
        public DataTable dtStoreGetOutItems;
        public StoreGetOutItem sgoiSearch;
        private StoreGetOutItem sgoiUpdate;
        private bool bolEnableBtmDeleteByInterface;
        private bool bolEnableBtmDeleteByPermision;
        private bool bolEnableBtmInsertByInterface;
        private bool bolEnableBtmInsertByPermision;

        public StoreGetOutItems()
        {
            InitializeComponent();

            this.sgoStoreGetOut = new StoreGetOut();
            this.sgoiSearch = new StoreGetOutItem();
            this.sgoiUpdate = new StoreGetOutItem();
            

            this.bolEnableBtmDeleteByInterface = false;
            this.bolEnableBtmDeleteByPermision = false;
            this.bolEnableBtmInsertByInterface = true;
            this.bolEnableBtmInsertByPermision = false;
        }

        private void RequestItems_Load(object sender, EventArgs e)
        {
            SetComponentsByPermisions();

            this.labStoreGetOutNumber.Text = this.sgoStoreGetOut.intNumber.ToString();
            this.labStoreGetOutDate.Text = this.sgoStoreGetOut.dtDate.ToString("D");
            this.labStoreGetOutDepartment.Text = Department.GetNameByNumber(this.cnConnection, this.sgoStoreGetOut.intDepartment);
            this.labStoreGetOutRequester.Text = Employee.GetNameByCoID(this.cnConnection,this.sgoStoreGetOut.strRequesterCoID);

            SearchRequestItems();
        }

        private void SetComponentsByPermisions()
        {
            if (this.usUser.bolStoreEnabed)
            {
                this.bolEnableBtmDeleteByPermision = true;
                this.bolEnableBtmInsertByPermision = true;
                this.dgvStoreGetOutItems.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvStoreGetOutItems_CellMouseDoubleClick);
                this.dgvStoreGetOutItems.Columns["bitSelect"].Visible = true;
            }
            else
            {
                this.bolEnableBtmDeleteByPermision = false;
                this.bolEnableBtmInsertByPermision = false;
                this.dgvStoreGetOutItems.CellMouseDoubleClick -= new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvStoreGetOutItems_CellMouseDoubleClick);
                this.dgvStoreGetOutItems.Columns["bitSelect"].Visible = false;
            }

            SetEnableComponents();
        }

        private void SetEnableComponents()
        {
            
            this.btmDelete.Enabled = this.bolEnableBtmDeleteByPermision & this.bolEnableBtmDeleteByInterface;
            this.btmInsert.Enabled = this.bolEnableBtmInsertByPermision & this.bolEnableBtmInsertByInterface;
        }


        private void RequestItems_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        public void SearchRequestItems()
        {
            this.dtStoreGetOutItems = StoreGetOutItem.GetStoreGetOutItemsBySGONumber(this.cnConnection, this.sgoStoreGetOut.intNumber);

            this.dgvStoreGetOutItems.DataSource = this.dtStoreGetOutItems;

            //for(int i=0;i<this.dtStoreGetOutItems.Rows.Count;i++)
            //{
            //    this.dgvStoreGetOutItems.Rows[i].Cells["nvcStuffStoreCodeAsName"].Value =
            //        StoreCode.GetNameByStoreCode(this.cnConnection, this.dgvStoreGetOutItems.Rows[i].Cells["nvcStuffStoreCode"].Value.ToString());
            //    this.dgvStoreGetOutItems.Rows[i].Cells["intTechnicalActionTypeAsName"].Value =
            //         (Maintenance.ActionType)this.dgvStoreGetOutItems.Rows[i].Cells["intTechnicalActionType"].Value;
            //}
        }                                                               

        private void btmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvStoreGetOutItems_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                StoreGetOutItemUpdate frmStoreGetOutItemUpdate = new StoreGetOutItemUpdate();

                frmStoreGetOutItemUpdate.Owner = this;
                frmStoreGetOutItemUpdate.sgoiUpdate = this.sgoiUpdate;
                frmStoreGetOutItemUpdate.cnConnection = this.cnConnection;
                frmStoreGetOutItemUpdate.setSettings = this.setSettings;
                frmStoreGetOutItemUpdate.usUser = this.usUser;

                this.sgoiUpdate.intID = (int)this.dgvStoreGetOutItems.Rows[e.RowIndex].Cells["intID"].Value;
                this.sgoiUpdate.intStoreGetOutNumber = (int)this.dgvStoreGetOutItems.Rows[e.RowIndex].Cells["intStoreGetOutNumber"].Value;
                this.sgoiUpdate.strStuffStoreCode = this.dgvStoreGetOutItems.Rows[e.RowIndex].Cells["nvcStuffStoreCode"].Value.ToString();
                this.sgoiUpdate.strEquipTag = this.dgvStoreGetOutItems.Rows[e.RowIndex].Cells["nvcEquipTag"].Value.ToString();
                this.sgoiUpdate.dobStuffAmount = (double)this.dgvStoreGetOutItems.Rows[e.RowIndex].Cells["floStuffAmount"].Value;
                this.sgoiUpdate.intTechnicalActionType = (int)this.dgvStoreGetOutItems.Rows[e.RowIndex].Cells["intTechnicalActionType"].Value;

                frmStoreGetOutItemUpdate.ShowDialog();
            }
        }

        private void btmInsert_Click(object sender, EventArgs e)
        {
            this.btmInsert.Enabled = false;
            StoreGetOutItemInsert frmStoreGetOutItemInsert = new StoreGetOutItemInsert();
            frmStoreGetOutItemInsert.Owner = this;
            frmStoreGetOutItemInsert.cnConnection = this.cnConnection;
            frmStoreGetOutItemInsert.setSettings = this.setSettings;
            frmStoreGetOutItemInsert.usUser = this.usUser;
            frmStoreGetOutItemInsert.sgoiInsert.intStoreGetOutNumber = this.sgoStoreGetOut.intNumber;
            frmStoreGetOutItemInsert.ShowDialog();
            this.btmInsert.Enabled = true;
        }

        private void btmDelete_Click(object sender, EventArgs e)
        {
            int intSelectedInvoiceItems = 0;
            foreach (DataRow drInvoiceItems in this.dtStoreGetOutItems.Rows)
            {
                if ((Boolean)drInvoiceItems["bitSelect"])
                {
                    ++intSelectedInvoiceItems;
                }
            }

            if (intSelectedInvoiceItems > 0)
            {
                DialogResult dialogResult = MessageBox.Show("آیا می خواهید " + intSelectedInvoiceItems.ToString() + " آیتم را حذف کنید؟", "حذف", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.btmDelete.Enabled = false;
                    //RequestItem.DeleteRequestItems(this.cnConnection, this.dtStoreGetOutItems);
                    SearchRequestItems();
                    this.btmDelete.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show(".هیچ آیتم انتخاب نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void DgvStoreGetOutItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvStoreGetOutItems.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void DgvStoreGetOutItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                this.bolEnableBtmDeleteByInterface = false;

                for (int i = 0; i < this.dgvStoreGetOutItems.Rows.Count; i++)
                {
                    if ((bool)this.dgvStoreGetOutItems.Rows[i].Cells["bitSelect"].Value)
                    {
                        this.bolEnableBtmDeleteByInterface = true;
                    }
                }

                SetEnableComponents();
            }
        }

        private void DgvStoreGetOutItems_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dtStoreGetOutItems.Rows.Count; i++)
            {
                this.dgvStoreGetOutItems.Rows[i].Cells["nvcStuffStoreCodeAsName"].Value =
                    StoreCode.GetNameByStoreCode(this.cnConnection, this.dgvStoreGetOutItems.Rows[i].Cells["nvcStuffStoreCode"].Value.ToString());
            }
        }

       
    }
}
