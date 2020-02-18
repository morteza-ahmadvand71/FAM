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

namespace Baran.Ferroalloy.Management.Maintenance
{
    public partial class FrmStoreInsert : Form
    {
        public FrmStoreInsert()
        {
            InitializeComponent();
        }

        private void FrmCategoryInsert_Load(object sender, EventArgs e)
        {
            this.dgvListStores.AutoGenerateColumns = false;
            ListRefresh();
        }

        public void ListRefresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                this.dgvListStores.DataSource = db.Stores.ListStores();
            }
        }

        private void TxtSearchStores_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                this.dgvListStores.DataSource = db.Stores.ListStores(txtSearchStores.Text);
            }
        }

        private void BtmRegister_Click(object sender, EventArgs e)
        {
            if (txtNameStore.Text == "")
            {
                RtlMessageBox.Show("لطفا نام انبار را وارد کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nameStore = txtNameStore.Text;
                using (UnitOfWork db = new UnitOfWork())
                {
                    var stores = db.Stores.GetEntity(t => t.nvcName == nameStore);
                    if (stores != null)
                    {
                        RtlMessageBox.Show("این نام انبار قبلا ثبت شده است", "خطا", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        var maxNumber = db.Stores.GetAll().Max(t => t.intNumber);
                        tabStores tabStores = new tabStores()
                        {
                            bitSelect = false,
                            intNumber = maxNumber + 1,
                            nvcName = nameStore
                        };
                        db.Stores.Insert(tabStores);
                        db.Save();
                        RtlMessageBox.Show("ثبت با موفقیت انجام شد", "ثبت", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ListRefresh();
                        txtNameStore.Text = "";
                        txtEditStore.Text = "";
                    }

                }
            }
        }

        private void BtmEdit_Click(object sender, EventArgs e)
        {
            if (txtEditStore.Text == "")
            {
                RtlMessageBox.Show("لطفا نام انبار را از لیست مقابل انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string nameStore = txtEditStore.Text;
                    if (dgvListStores.CurrentRow != null)
                    {
                        int storeId = int.Parse(dgvListStores.CurrentRow.Cells[0].Value.ToString());
                        var stores = db.Stores.GetEntity(t => t.intID == storeId);
                        if (stores != null)
                        {
                            stores.intID = storeId;
                            stores.bitSelect = stores.bitSelect;
                            stores.intNumber = stores.intNumber;
                            stores.nvcName = nameStore;

                            db.Stores.Update(stores);
                            db.Save();
                            RtlMessageBox.Show("ویرایش با موفقیت انجام شد", "ثبت", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ListRefresh();
                            txtEditStore.Text = "";
                            txtNameStore.Text = "";
                        }
                    }
                }
            }
        }

        private void DgvListStores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DgvListStores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListStores.CurrentRow != null)
            {
                DataGridViewRow dgvRow = dgvListStores.CurrentRow;
                this.txtEditStore.Text = dgvRow.Cells[1].Value.ToString();
            }
        }

        private void BtmDelete_Click(object sender, EventArgs e)
        {
            if (dgvListStores.CurrentRow != null)
            {
                DataGridViewRow dgvRow = dgvListStores.CurrentRow;
                int storeId = Convert.ToInt32(dgvRow.Cells[0].Value.ToString());
                string storeName = dgvRow.Cells[1].Value.ToString();
                if (RtlMessageBox.Show($"آیا از حذف انبار {storeName} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var stores = db.Stores.GetEntity(t => t.intID == storeId);
                        db.Stores.Delete(stores);
                        db.Save();
                        ListRefresh();
                        txtEditStore.Text = "";
                        txtNameStore.Text = "";
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا یک انبار را از لیست انتخاب کنید", "توجه", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        
    }
}
