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
using Baran.Ferroalloy.Automation;
using Baran.Ferroalloy.Automation.Models;

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
            this.dgvStores.AutoGenerateColumns = false;
            using (UnitOfWork db = new UnitOfWork())
            {
                var stores = db.Stores.GetAll();
                List<StoresViewModel> list = new List<StoresViewModel>();
                foreach (var item in stores)
                {
                    list.Add(new StoresViewModel()
                    {
                        intNumber = item.intNumber,
                        nvcName = item.nvcName,
                        intID = item.intID
                    });
                }

                this.dgvStores.DataSource = list;

            }

            //this.dsStores = StoreCode.GetStoresAsDataSet(this.cnConnection);

            //this.dgvStores.DataSource = this.dsStores;
            //this.dgvStores.DataMember = "tabStuffStores";
        }

        private void BtmOK_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                tabStores tabStores = new tabStores();
                var intNumber = db.Stores.GetAll().Last().intNumber;
                var rowsCount = this.dgvStores.Rows.Count;
                var index = dgvStores.CurrentCell.RowIndex;
            }
            //for (int i = 0; i < this.dsStores.Tables["tabStuffStores"].Rows.Count; i++)
            //{
            //    if (this.dsStores.Tables["tabStuffStores"].Rows[i].RowState == DataRowState.Deleted)
            //    {
            //        StoreCode.StoreDelete(this.cnConnection, (int)this.dsStores.Tables["tabStuffStores"].Rows[i]["intID", DataRowVersion.Original]);
            //    }

            //    if (this.dsStores.Tables["tabStuffStores"].Rows[i].RowState == DataRowState.Added)
            //    {
            //       StoreCode.StoreInsert(this.cnConnection, this.dsStores.Tables["tabStuffStores"].Rows[i]["nvcName"].ToString());
            //    }

            //    if (this.dsStores.Tables["tabStuffStores"].Rows[i].RowState == DataRowState.Modified)
            //    {
            //        StoreCode.Store stUpdateLoc = new StoreCode.Store();
            //        stUpdateLoc.strName = this.dsStores.Tables["tabStuffStores"].Rows[i]["nvcName"].ToString();
            //        stUpdateLoc.intID = (int)this.dsStores.Tables["tabStuffStores"].Rows[i]["intID"];
            //        StoreCode.StoreUpdate(this.cnConnection, stUpdateLoc);
            //    }
            //}

            //if (this.Owner is StuffUpdate)
            //{
            //    StuffUpdate frmStuffUpdate = (StuffUpdate)this.Owner;
            //    frmStuffUpdate.FillStores();
            //}
            //if (this.Owner is PartInsert)
            //{
            //    PartInsert frmStuffInsert = (PartInsert)this.Owner;
            //    frmStuffInsert.FillStores();
            //}


            this.Close();
        }

        private void BtmCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void DgvStores_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (dgvStores.CurrentRow != null)
                {
                    DataGridViewRow dgvRow = dgvStores.CurrentRow;
                    if (dgvRow.Cells["intID"].Value == DBNull.Value)
                    {
                        if (dgvRow.Cells["nvcName"].Value == DBNull.Value)
                        {
                            MessageBox.Show("نام انبار نمی تواند خالی باشد");
                        }
                        else
                        {
                            tabStores tabStores = new tabStores()
                            {
                                nvcName = dgvRow.Cells["nvcName"].Value.ToString(),
                                intNumber = db.Stores.GetAll().Select(t=>t.intNumber).Max() + 1,
                                bitSelect = false
                            };
                            db.Stores.Insert(tabStores);
                            db.Save();

                        }
                    }
                    else
                    {
                        tabStores tabStores = new tabStores()
                        {
                            intID = Convert.ToInt32(dgvRow.Cells["intID"].Value),
                            nvcName = dgvRow.Cells["nvcName"].Value.ToString(),
                            intNumber = Convert.ToInt32(dgvRow.Cells["intNumber"].Value.ToString()),
                            bitSelect = false
                        };
                        db.Stores.Update(tabStores);
                        db.Save();
                    }

                }
            }
        }

        private void DgvStores_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (dgvStores.CurrentRow.Cells["intID"].Value != DBNull.Value)
                {
                    string nvcName = dgvStores.CurrentRow.Cells["nvcName"].Value.ToString();
                    int intID = Convert.ToInt32(dgvStores.CurrentRow.Cells["intID"].Value.ToString());
                    if (MessageBox.Show($"آیا مایل به حذف انبار {nvcName} هستید؟", "اخطار", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        db.Stores.DeleteById(intID);
                        db.Save();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
        }
    }
}
