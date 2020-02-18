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
    public partial class FrmNames : Form
    {
        public string category;

        public FrmNames()
        {
            InitializeComponent();
        }

        private void FrmNames_Load(object sender, EventArgs e)
        {

        }

        private void DgvNames_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (dgvNames.CurrentRow != null)
                {
                    var categories = db.Categories.GetEntityByName(t => t.nvcName == category);
                    DataGridViewRow dgvRow = dgvNames.CurrentRow;
                    string nvcName = dgvRow.Cells["nvcName"].Value.ToString();
                    var name = db.Name.GetEntityByName(t => t.nvcName == nvcName);
                    if (name != null)
                    {
                        MessageBox.Show("نام کالا تکراری می باشد");
                    }
                    if (dgvRow.Cells["nvcName"].Value == DBNull.Value)
                    {
                        MessageBox.Show("نام نمی تواند خالی باشد");
                    }
                    else
                    {
                        tabName tabName = new tabName()
                        {
                            nvcName = dgvRow.Cells["nvcName"].Value.ToString(),
                            intNumber = db.Name.GetAll().Select(t => t.intNumber).Max() + 1,
                            bitSelect = false,
                            intCategory = categories.intNumber
                        };
                        db.Name.Insert(tabName);
                        db.Save();

                    }
                    //if (dgvRow.Cells["intID"].Value == DBNull.Value)
                    //{
                    //    if (dgvRow.Cells["nvcName"].Value == DBNull.Value)
                    //    {
                    //        MessageBox.Show("نام نمی تواند خالی باشد");
                    //    }
                    //    else
                    //    {
                    //        tabName tabName = new tabName()
                    //        {
                    //            nvcName = dgvRow.Cells["nvcName"].Value.ToString(),
                    //            intNumber = db.Name.GetAll().Select(t => t.intNumber).Max() + 1,
                    //            bitSelect = false,
                    //            intCategory = 1
                    //        };
                    //        db.Name.Insert(tabName);
                    //        db.Save();

                    //    }
                    //}
                    //else
                    //{
                    //tabStores tabStores = new tabStores()
                    //{
                    //    intID = Convert.ToInt32(dgvRow.Cells["intID"].Value),
                    //    nvcName = dgvRow.Cells["nvcName"].Value.ToString(),
                    //    intNumber = Convert.ToInt32(dgvRow.Cells["intNumber"].Value.ToString()),
                    //    bitSelect = false
                    //};
                    //db.Stores.Update(tabStores);
                    //db.Save();
                    //}

                }
            }
        }
    }
}
