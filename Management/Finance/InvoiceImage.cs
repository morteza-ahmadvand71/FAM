using Baran.Ferroalloy.Automation.SqlDataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baran.Ferroalloy.Management.Finance
{
       public partial class InvoiceImage : Form
    {
        public Connection cnConnection;
        public FamSetting setSettings;
        public string strInvoiceImagePath;
        public InvoiceImage()
        {
            InitializeComponent();
        }

        private void Factor_Load(object sender, EventArgs e)
        {
            this.pbFactor.Image = Image.FromFile(this.strInvoiceImagePath);
        }
    }
}
