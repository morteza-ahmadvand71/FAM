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
    public partial class RequestItemInsert : Form
    {
        public RequestItem riInsert;
        public Connection cnConnection;

        public RequestItemInsert()
        {
            InitializeComponent();

            this.riInsert = new RequestItem();
        }

        private void RequestItemInsert_Load(object sender, EventArgs e)
        {
            
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            this.btmOK.Enabled = false;
            if(this.tbAmount.Text.Trim().Length != 0)
            {
                this.riInsert.dblAmount = double.Parse(this.tbAmount.Text.Trim());
            }
            
            this.riInsert.Insert(this.cnConnection);

            RequestItems frmRequestItems = (RequestItems)this.Owner;
            frmRequestItems.SearchRequestItems();
            this.Close();
        }

        private void SetEnableBtmOk()
        {
            if (this.tbAmount.Text.Trim().Length != 0 && this.riInsert.strStoreCode.Length != 0)
            {
                this.btmOK.Enabled = true;
            }
            else
            {
                this.btmOK.Enabled = false;
            }
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if(SelectStuff.strStuffStoreCode.Length != 0 )
            {
                this.riInsert.strStoreCode = SelectStuff.strStuffStoreCode;
                this.labStuff.Text = SelectStuff.strStuffName;
            }

            SetEnableBtmOk();
        }
    }
}
