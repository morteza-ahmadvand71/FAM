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
    public partial class Types : Form
    {
        private DataSet dsTypes;
        public Connection cnConnection;
        public StoreCode.Type tySearch;

        public Types()
        {
            InitializeComponent();

            this.dsTypes = new DataSet();
        }

        private void Materials_Load(object sender, EventArgs e)
        {
            this.dsTypes = StoreCode.GetTypesAsDataSet(this.cnConnection,this.tySearch);

            this.dgvTypes.DataSource = this.dsTypes;
            this.dgvTypes.DataMember = "tabStuffTypes";
        }

        private void BtmOK_Click(object sender, EventArgs e)
        {
            for(int i=0;i<this.dsTypes.Tables["tabStuffTypes"].Rows.Count;i++)
            {
                if(this.dsTypes.Tables["tabStuffTypes"].Rows[i].RowState == DataRowState.Deleted)
                {
                    StoreCode.TypeDelete(this.cnConnection, (int)this.dsTypes.Tables["tabStuffTypes"].Rows[i]["intID",DataRowVersion.Original]);
                }

                if (this.dsTypes.Tables["tabStuffTypes"].Rows[i].RowState == DataRowState.Added)
                {
                    StoreCode.Type tyType = new StoreCode.Type();
                    tyType.strStore = this.tySearch.strStore;
                    tyType.strSection = this.tySearch.strSection;
                    tyType.strMaterial = this.tySearch.strMaterial;
                    tyType.strName = this.dsTypes.Tables["tabStuffTypes"].Rows[i]["nvcName"].ToString();

                    StoreCode.TypeInsert(this.cnConnection, tyType);
                }

                if (this.dsTypes.Tables["tabStuffTypes"].Rows[i].RowState == DataRowState.Modified)
                {
                    StoreCode.Type tyType = new StoreCode.Type();
                    tyType.intID = (int)this.dsTypes.Tables["tabStuffTypes"].Rows[i]["intID"];
                    tyType.strName = this.dsTypes.Tables["tabStuffTypes"].Rows[i]["nvcName"].ToString();
                    StoreCode.TypeUpdate(this.cnConnection, tyType);
                }
            }

            if (this.Owner is StuffUpdate)
            {
                StuffUpdate frmStuffUpdate = (StuffUpdate)this.Owner;
                frmStuffUpdate.FillTypes();
            }
            if (this.Owner is StuffInsert)
            {
                StuffInsert frmStuffInsert = (StuffInsert)this.Owner;
                frmStuffInsert.FillTypes();
            }

            this.Close();
        }

        private void BtmCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
