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
    public partial class FrmMeasurementUnitsInsert : Form
    {
        public string categoryName;

        public FrmMeasurementUnitsInsert()
        {
            InitializeComponent();
        }

        private void FrmMeasurementUnitsInsert_Load(object sender, EventArgs e)
        {
            this.dgvListMeasurementUnits.AutoGenerateColumns = false;

            ListRefresh();
        }

        public void ListRefresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var categories = db.Categories.GetEntity(t => t.nvcName == categoryName);
                this.dgvListMeasurementUnits.DataSource = db.MeasurementUnits.ListMeasurementUnits(categories.intNumber);
            }
        }

        private void TxtSearchMeasurementUnits_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var categories = db.Categories.GetEntity(t => t.nvcName == categoryName);
                this.dgvListMeasurementUnits.DataSource = db.MeasurementUnits.ListMeasurementUnits(categories.intNumber, txtSearchMeasurementUnits.Text);
            }
        }

        private void BtmRegister_Click(object sender, EventArgs e)
        {
            if (txtRegisterMeasurementUnits.Text == "")
            {
                RtlMessageBox.Show("لطفا نام واحد اندازه گیری را وارد کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string measurementUnitsName = txtRegisterMeasurementUnits.Text;
                using (UnitOfWork db = new UnitOfWork())
                {
                    var categories = db.Categories.GetEntity(t => t.nvcName == categoryName);
                    var measurementUnits = db.MeasurementUnits.GetEntity(t => t.nvcName == measurementUnitsName);
                    if (measurementUnits != null)
                    {
                        RtlMessageBox.Show("این نام کالا قبلا ثبت شده است", "خطا", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        var maxNumber = db.MeasurementUnits.GetAll().Max(t => t.intNumber);
                        tabMeasurementUnits tabMeasurementUnits = new tabMeasurementUnits()
                        {
                            bitSelect = false,
                            intNumber = maxNumber + 1,
                            nvcName = measurementUnitsName,
                            intCategory = categories.intNumber
                        };
                        db.MeasurementUnits.Insert(tabMeasurementUnits);
                        db.Save();
                        RtlMessageBox.Show("ثبت با موفقیت انجام شد", "ثبت", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ListRefresh();
                        txtRegisterMeasurementUnits.Text = "";
                        txtEditMeasurementUnits.Text = "";
                    }

                }
            }
        }

        private void BtmEdit_Click(object sender, EventArgs e)
        {
            if (txtEditMeasurementUnits.Text == "")
            {
                RtlMessageBox.Show("لطفا نام واحد اندازه گیری را از لیست مقابل انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var categories = db.Categories.GetEntity(t => t.nvcName == categoryName);
                    string measurementUnitsName = txtEditMeasurementUnits.Text;
                    if (dgvListMeasurementUnits.CurrentRow != null)
                    {
                        int measurementUnitsId = int.Parse(dgvListMeasurementUnits.CurrentRow.Cells[0].Value.ToString());
                        var measurementUnits = db.MeasurementUnits.GetEntity(t => t.intID == measurementUnitsId);
                        if (measurementUnits != null)
                        {
                            measurementUnits.intID = measurementUnitsId;
                            measurementUnits.bitSelect = measurementUnits.bitSelect;
                            measurementUnits.intNumber = measurementUnits.intNumber;
                            measurementUnits.nvcName = measurementUnitsName;
                            measurementUnits.intCategory = categories.intNumber;

                            db.MeasurementUnits.Update(measurementUnits);
                            db.Save();
                            RtlMessageBox.Show("ویرایش با موفقیت انجام شد", "ثبت", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ListRefresh();
                            txtRegisterMeasurementUnits.Text = "";
                            txtEditMeasurementUnits.Text = "";
                        }
                    }
                }
            }
        }

        private void DgvListMeasurementUnits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DgvListMeasurementUnits_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListMeasurementUnits.CurrentRow != null)
            {
                DataGridViewRow dgvRow = dgvListMeasurementUnits.CurrentRow;
                this.txtEditMeasurementUnits.Text = dgvRow.Cells[1].Value.ToString();
            }
        }

        private void BtmDelete_Click(object sender, EventArgs e)
        {
            if (dgvListMeasurementUnits.CurrentRow != null)
            {
                DataGridViewRow dgvRow = dgvListMeasurementUnits.CurrentRow;
                int measurementUnitsId = Convert.ToInt32(dgvRow.Cells[0].Value.ToString());
                string measurementUnitsName = dgvRow.Cells[1].Value.ToString();
                if (RtlMessageBox.Show($"آیا از حذف {measurementUnitsName} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var measurementUnits = db.MeasurementUnits.GetEntity(t => t.intID == measurementUnitsId);
                        db.MeasurementUnits.Delete(measurementUnits);
                        db.Save();
                        ListRefresh();
                        txtRegisterMeasurementUnits.Text = "";
                        txtEditMeasurementUnits.Text = "";
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا یک واحد اندازه گیری را از لیست انتخاب کنید", "توجه", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        
    }
}
