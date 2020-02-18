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
    public partial class FrmCategoryInsert : Form
    {
        public FrmCategoryInsert()
        {
            InitializeComponent();
        }

        private void FrmCategoryInsert_Load(object sender, EventArgs e)
        {
            this.dgvListCategory.AutoGenerateColumns = false;

            ListRefresh();
        }

        public void ListRefresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                this.dgvListCategory.DataSource = db.Categories.ListCategories();
            }
        }

        private void TxtSearchCategory_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                this.dgvListCategory.DataSource = db.Categories.ListCategories(txtSearchCategory.Text);
            }
        }

        private void BtmRegister_Click(object sender, EventArgs e)
        {
            if (txtRegisterCategory.Text == "")
            {
                RtlMessageBox.Show("لطفا نام رسته را وارد کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string categoryName = txtRegisterCategory.Text;
                using (UnitOfWork db = new UnitOfWork())
                {
                    var categories = db.Categories.GetEntity(t => t.nvcName == categoryName);
                    if (categories != null)
                    {
                        RtlMessageBox.Show("این نام انبار قبلا ثبت شده است", "خطا", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        var maxNumber = db.Categories.GetAll().Max(t => t.intNumber);
                        tabCategories tabCategories = new tabCategories()
                        {
                            bitSelect = false,
                            intNumber = maxNumber + 1,
                            nvcName = categoryName
                        };
                        db.Categories.Insert(tabCategories);
                        db.Save();
                        RtlMessageBox.Show("ثبت با موفقیت انجام شد", "ثبت", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ListRefresh();
                        txtRegisterCategory.Text = "";
                        txtEditCategory.Text = "";
                    }

                }
            }
        }

        private void BtmEdit_Click(object sender, EventArgs e)
        {
            if (txtEditCategory.Text == "")
            {
                RtlMessageBox.Show("لطفا نام رسته را از لیست مقابل انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string categoryName = txtEditCategory.Text;
                    if (dgvListCategory.CurrentRow != null)
                    {
                        int categoryId = int.Parse(dgvListCategory.CurrentRow.Cells[0].Value.ToString());
                        var categories = db.Categories.GetEntity(t => t.intID == categoryId);
                        if (categories != null)
                        {
                            categories.intID = categoryId;
                            categories.bitSelect = categories.bitSelect;
                            categories.intNumber = categories.intNumber;
                            categories.nvcName = categoryName;

                            db.Categories.Update(categories);
                            db.Save();
                            RtlMessageBox.Show("ویرایش با موفقیت انجام شد", "ثبت", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ListRefresh();
                            txtEditCategory.Text = "";
                            txtRegisterCategory.Text = "";
                        }
                    }
                }
            }
        }

        private void DgvListCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void DgvListCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListCategory.CurrentRow != null)
            {
                DataGridViewRow dgvRow = dgvListCategory.CurrentRow;
                this.txtEditCategory.Text = dgvRow.Cells[1].Value.ToString();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvListCategory.CurrentRow != null)
            {
                DataGridViewRow dgvRow = dgvListCategory.CurrentRow;
                int categoryId = Convert.ToInt32(dgvRow.Cells[0].Value.ToString());
                string categoryName = dgvRow.Cells[1].Value.ToString();
                if (RtlMessageBox.Show($"آیا از حذف {categoryName} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var categories = db.Categories.GetEntity(t => t.intID == categoryId);
                        db.Categories.Delete(categories);
                        db.Save();
                        ListRefresh();
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا یک رسته را از لیست انتخاب کنید", "توجه", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        
    }
}
