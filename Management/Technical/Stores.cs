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

namespace Baran.Ferroalloy.Management.Technical
{
    public partial class Stores : Form
    {
        private DataSet dsStores;
        public Connection cnConnection;
        public Stores()
        {
            InitializeComponent();

            this.dsStores = new DataSet();
        }

        private void Stores_Load(object sender, EventArgs e)
        {

            this.dsStores = StoreCode.GetStoresAsDataSet(this.cnConnection);

            this.dgvStores.DataSource = this.dsStores;
            this.dgvStores.DataMember = "tabStuffStores";
        }

        private void BtmOK_Click(object sender, EventArgs e)
        {
            for(int i=0;i<this.dsStores.Tables["tabStuffStores"].Rows.Count;i++)
            {
                if(this.dsStores.Tables["tabStuffStores"].Rows[i].RowState == DataRowState.Deleted)
                {
                    StoreCode.StoreDelete(this.cnConnection, (int)this.dsStores.Tables["tabStuffStores"].Rows[i]["intID",DataRowVersion.Original]);
                }

                if (this.dsStores.Tables["tabStuffStores"].Rows[i].RowState == DataRowState.Added)
                {
                    StoreCode.StoreInsert(this.cnConnection, this.dsStores.Tables["tabStuffStores"].Rows[i]["nvcName"].ToString());
                }

                if (this.dsStores.Tables["tabStuffStores"].Rows[i].RowState == DataRowState.Modified)
                {
                    StoreCode.Store stUpdateLoc = new StoreCode.Store();
                    stUpdateLoc.strName = this.dsStores.Tables["tabStuffStores"].Rows[i]["nvcName"].ToString();
                    stUpdateLoc.intID = (int)this.dsStores.Tables["tabStuffStores"].Rows[i]["intID"];
                    StoreCode.StoreUpdate(this.cnConnection, stUpdateLoc);
                }
            }

            if(this.Owner is StuffUpdate)
            {  
                StuffUpdate frmStuffUpdate = (StuffUpdate)this.Owner;
                frmStuffUpdate.FillStores();
            }
            if (this.Owner is StuffInsert)
            {
                StuffInsert frmStuffInsert = (StuffInsert)this.Owner;
                frmStuffInsert.FillStores();
            }


            this.Close();
        }

        private void BtmCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
