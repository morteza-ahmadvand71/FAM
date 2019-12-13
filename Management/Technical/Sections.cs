using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Maintenance;
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
    public partial class Sections : Form
    {
        private DataSet dsSections;
        public Connection cnConnection;
        public string strStore;
        public Sections()
        {
            InitializeComponent();
        }

        private void Stores_Load(object sender, EventArgs e)
        {
            this.dsSections = StoreCode.GetSectionsAsDataSet(this.cnConnection,this.strStore);
            this.dgvSections.DataSource = this.dsSections;
            this.dgvSections.DataMember = "tabStuffSections";
        }

        private void BtmOK_Click(object sender, EventArgs e)
        {
            for(int i=0;i<this.dsSections.Tables["tabStuffSections"].Rows.Count;i++)
            {
                if(this.dsSections.Tables["tabStuffSections"].Rows[i].RowState == DataRowState.Deleted)
                {
                    StoreCode.SectionDelete(this.cnConnection, (int)this.dsSections.Tables["tabStuffSections"].Rows[i]["intID",DataRowVersion.Original]);
                }

                if (this.dsSections.Tables["tabStuffSections"].Rows[i].RowState == DataRowState.Added)
                {
                    StoreCode.Section seSInsert = new StoreCode.Section();
                    seSInsert.strStore = this.strStore;
                    seSInsert.strName = this.dsSections.Tables["tabStuffSections"].Rows[i]["nvcName"].ToString();
                    StoreCode.SectionInsert(this.cnConnection, seSInsert);
                }

                if (this.dsSections.Tables["tabStuffSections"].Rows[i].RowState == DataRowState.Modified)
                {
                    StoreCode.Section seSInsert = new StoreCode.Section();
                    seSInsert.intID = (int)this.dsSections.Tables["tabStuffSections"].Rows[i]["intID"];
                    seSInsert.strName = this.dsSections.Tables["tabStuffSections"].Rows[i]["nvcName"].ToString(); 
                    StoreCode.SectionUpdate(this.cnConnection, seSInsert);
                }
            }

            if (this.Owner is StuffUpdate)
            {
                StuffUpdate frmStuffUpdate = (StuffUpdate)this.Owner;
                frmStuffUpdate.FillSections();
            }
            if (this.Owner is StuffInsert)
            {
                StuffInsert frmStuffInsert = (StuffInsert)this.Owner;
                frmStuffInsert.FillSections();
            }

            

            this.Close();
        }

        private void BtmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
