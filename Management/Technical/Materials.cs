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
    public partial class Materials : Form
    {
        private DataSet dsMaterials;
        public Connection cnConnection;
        public StoreCode.Material maSearch;

        public Materials()
        {
            InitializeComponent();

            this.dsMaterials = new DataSet();
        }

        private void Materials_Load(object sender, EventArgs e)
        {
            this.dsMaterials = StoreCode.GetMaterialsAsDataSet(this.cnConnection,this.maSearch);
           
            this.dgvMaterials.DataSource = this.dsMaterials;
            this.dgvMaterials.DataMember = "tabStuffMaterials";
        }

        private void BtmOK_Click(object sender, EventArgs e)
        {
            for(int i=0;i<this.dsMaterials.Tables["tabStuffMaterials"].Rows.Count;i++)
            {
                if(this.dsMaterials.Tables["tabStuffMaterials"].Rows[i].RowState == DataRowState.Deleted)
                {
                    StoreCode.MaterialDelete(this.cnConnection, (int)this.dsMaterials.Tables["tabStuffMaterials"].Rows[i]["intID",DataRowVersion.Original]);
                }

                if (this.dsMaterials.Tables["tabStuffMaterials"].Rows[i].RowState == DataRowState.Added)
                {
                    StoreCode.Material maMaterial = new StoreCode.Material();
                    
                    maMaterial.strStore = this.maSearch.strStore;
                    maMaterial.strSection = this.maSearch.strSection;
                    maMaterial.strName = this.dsMaterials.Tables["tabStuffMaterials"].Rows[i]["nvcName"].ToString();

                    StoreCode.MaterialInsert(this.cnConnection, maMaterial);
                }

                if (this.dsMaterials.Tables["tabStuffMaterials"].Rows[i].RowState == DataRowState.Modified)
                {
                    StoreCode.Material maMaterial = new StoreCode.Material();
                    maMaterial.intID = (int)this.dsMaterials.Tables["tabStuffMaterials"].Rows[i]["intID"];
                    maMaterial.strName = this.dsMaterials.Tables["tabStuffMaterials"].Rows[i]["nvcName"].ToString();
                    StoreCode.MaterialUpdate(this.cnConnection, maMaterial);
                }
            }

            if (this.Owner is StuffUpdate)
            {
                StuffUpdate frmStuffUpdate = (StuffUpdate)this.Owner;
                frmStuffUpdate.FillMaterials();
            }
            if (this.Owner is StuffInsert)
            {
                StuffInsert frmStuffInsert = (StuffInsert)this.Owner;
                frmStuffInsert.FillMaterials();
            }

            this.Close();
        }

        private void BtmCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
