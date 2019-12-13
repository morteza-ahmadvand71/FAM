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
    public partial class RequestItems : Form
    {
        public Connection cnConnection;
        public User usUser;
        public FamSetting setSettings;
        public Request reqRequest;
        public DataSet dsRequestItems;
        public RequestItem riSearch;
        private RequestItem riUpdate;
        private bool bolEnableBtmDeleteByInterface;
        private bool bolEnableBtmDeleteByPermision;
        private bool bolEnableBtmInsertByInterface;
        private bool bolEnableBtmInsertByPermision;

        public RequestItems()
        {
            InitializeComponent();
   
            this.riSearch = new RequestItem();
            this.riUpdate = new RequestItem();
            this.reqRequest = new Request();

            this.bolEnableBtmDeleteByInterface = false;
            this.bolEnableBtmDeleteByPermision = false;
            this.bolEnableBtmInsertByInterface = true;
            this.bolEnableBtmInsertByPermision = false;
        }

        private void RequestItems_Load(object sender, EventArgs e)
        {
            SetComponentsByPermisions();

            this.labRequestNumber.Text = this.reqRequest.intNumber.ToString();
            this.labRequestDate.Text = this.reqRequest.dtDate.ToString("yy:MM:dd");
            this.labRequestCategory.Text = Category.GetNameByNumber(this.cnConnection,this.reqRequest.intDepartment);
            this.labRequester.Text = Employee.GetNameByCoID(this.cnConnection,this.reqRequest.strRequesterCoID);

            SearchRequestItems();
        }

        private void SetComponentsByPermisions()
        {
            if (this.usUser.bolStoreEnabed)
            {
                this.btmDelete.Enabled = true;
                this.btmInsert.Enabled = true;
                this.dgvRequestItems.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRequestItems_CellMouseDoubleClick);
                this.dgvRequestItems.Columns["bitSelect"].Visible = true;
            }
            else
            {
                this.btmDelete.Enabled = false;
                this.btmInsert.Enabled = false;
                this.dgvRequestItems.CellMouseDoubleClick -= new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRequestItems_CellMouseDoubleClick);
                this.dgvRequestItems.Columns["bitSelect"].Visible = false;
            }
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
            this.dsRequestItems = RequestItem.GetRequestItems(this.cnConnection, this.riSearch);
                                                                    
            this.dgvRequestItems.DataSource = this.dsRequestItems;
            this.dgvRequestItems.DataMember = "tabRequestItems";
        }                                                               

        private void btmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRequestItems_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                RequestItemUpdate frmRequestItemUpdate = new RequestItemUpdate();

                frmRequestItemUpdate.Owner = this;
                frmRequestItemUpdate.riUpdate = this.riUpdate;
                frmRequestItemUpdate.cnConnection = this.cnConnection;

                this.riUpdate.intID = (int)this.dgvRequestItems.Rows[e.RowIndex].Cells["intID"].Value;
                this.riUpdate.intRequestNumber = (int)this.dgvRequestItems.Rows[e.RowIndex].Cells["intRequestNumber"].Value;
                this.riUpdate.strStoreCode = this.dgvRequestItems.Rows[e.RowIndex].Cells["nvcStorecode"].Value.ToString();
                this.riUpdate.dblAmount = (double)this.dgvRequestItems.Rows[e.RowIndex].Cells["floAmount"].Value;

                frmRequestItemUpdate.ShowDialog();
            }
           
        }

        private void btmInsert_Click(object sender, EventArgs e)
        {
            this.btmInsert.Enabled = false;
            RequestItemInsert frmRequestItemInsert = new RequestItemInsert();
            frmRequestItemInsert.Owner = this;
            frmRequestItemInsert.cnConnection = this.cnConnection;
            frmRequestItemInsert.riInsert.intRequestNumber = this.reqRequest.intNumber;
            frmRequestItemInsert.ShowDialog();
            this.btmInsert.Enabled = true;
        }

        private void btmDelete_Click(object sender, EventArgs e)
        {
            int intSelectedInvoiceItems = 0;
            foreach (DataRow drInvoiceItems in this.dsRequestItems.Tables["tabRequestItems"].Rows)
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
                    RequestItem.DeleteRequestItems(this.cnConnection, this.dsRequestItems);
                    SearchRequestItems();
                    this.btmDelete.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show(".هیچ آیتم انتخاب نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void dgvRequestItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvRequestItems.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void dgvRequestItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.bolEnableBtmDeleteByInterface = false;

            for (int i = 0; i < this.dgvRequestItems.Rows.Count; i++)
            {
                if ((bool)this.dgvRequestItems.Rows[i].Cells["bitSelect"].Value)
                {
                    this.bolEnableBtmDeleteByInterface = true;
                }
            }

            SetEnableComponents();
        }
    }
}
