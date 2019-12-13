using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Finance;
using Baran.Ferroalloy.Maintenance;
using Baran.Ferroalloy.Office;
using Baran.Ferroalloy.Store;
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
    public partial class RequestItemUpdate : Form
    {
        public RequestItem riUpdate;
        public Connection cnConnection;

        public RequestItemUpdate()
        {
            InitializeComponent();

            this.riUpdate = new RequestItem();
        }

        private void RequestItemUpdate_Load(object sender, EventArgs e)
        {
            //Fill Controls with RequestItemUpdate Properties
            this.tbRequestNumber.Text = this.riUpdate.intRequestNumber.ToString();
            this.labStuff.Text = this.riUpdate.strStoreCode;
            this.tbAmount.Text = this.riUpdate.dblAmount.ToString();
        }

        private void SetEnableBtmOk()
        {
            if (this.tbAmount.Text.Trim().Length != 0 && this.riUpdate.strStoreCode.Length != 0 &&
                this.tbRequestNumber.Text.Trim().Length != 0)
            {
                this.btmOK.Enabled = true;
            }
            else
            {
                this.btmOK.Enabled = false;
            }
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            this.btmOK.Enabled = false;
            if (this.tbAmount.Text.Trim().Length != 0)
            {
                this.riUpdate.dblAmount = double.Parse(this.tbAmount.Text.Trim());
            }
            if (this.tbRequestNumber.Text.Trim().Length != 0)
            {
                this.riUpdate.intRequestNumber = int.Parse(this.tbRequestNumber.Text.Trim());
            }

            this.riUpdate.Update(this.cnConnection);

            RequestItems frmRequestItems = (RequestItems)this.Owner;
            frmRequestItems.SearchRequestItems();
            this.Close();
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TbRequestNumber_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbAmount_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void ButStuff_Click(object sender, EventArgs e)
        {
            SelectStuff frmSelectStuff = new SelectStuff();
            frmSelectStuff.Owner = this;
            frmSelectStuff.cnConnection = this.cnConnection;
            frmSelectStuff.ShowDialog();
            if (SelectStuff.strStuffStoreCode.Length != 0)
            {
                this.riUpdate.strStoreCode = SelectStuff.strStuffStoreCode;
                this.labStuff.Text = SelectStuff.strStuffName;
            }

            SetEnableBtmOk();
        }
    }
}
