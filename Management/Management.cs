using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Automation.Security;
using Baran.Ferroalloy.Management.Automation;
using System.IO;
using System.Globalization;
using Baran.Ferroalloy.Office;

namespace Baran.Ferroalloy.Management
{
    public partial class Management : Form
    {
        public Connection cnConnection;
        private User usLogined;
        private FamSetting setSettings;
        private Employee emLogined;
        private string strXmlPath;
      
        public Management()
        {
            InitializeComponent();

            this.strXmlPath = String.Format(@"{0}\Settings.xml", Directory.GetCurrentDirectory());

            this.cnConnection = new Connection();
            this.usLogined = new User();
            this.emLogined = new Employee();
            this.setSettings = new FamSetting();

            
        }
       
        private void Management_Load(object sender, EventArgs e)
        {
            if (CheckApplicationStatus()) 
            {
                this.setSettings = new FamSetting(this.cnConnection, this.strXmlPath);

                this.setSettings.strAppVersion = "1.6";
                this.staVersion.Text = this.setSettings.strAppVersion;
                this.Text += String.Format(" - {0}", FamSetting.GetCoInformation(this.cnConnection).strName);
            }
            else
            {
                this.menLogIn.Enabled = false;
            }
        }

        //Check DataBase for DataBase Connection
        private bool CheckApplicationStatus()
        {
            bool bolDbStatusLoc = false;
            bool bolXmlStatusLoc = false;
            bool bolFinalResultLoc = false;

            if(File.Exists(this.strXmlPath))
            {
                bolXmlStatusLoc = true;
                this.cnConnection = new Connection(this.strXmlPath, "B%90&a95");
                try
                {
                    this.cnConnection.GetConnectionStatus();
                    this.staConnectionStatus.Value = 100;
                    bolDbStatusLoc = true;
                }
                catch
                {
                    this.staConnectionStatus.Value = 0;
                    bolDbStatusLoc = false;
                }
            }
            else
            {
                bolXmlStatusLoc = false;
                bolDbStatusLoc = false;
            }

            bolFinalResultLoc = bolXmlStatusLoc & bolDbStatusLoc;

            if(!bolFinalResultLoc)
            {
                string strMessageLoc = "";
                if(!bolXmlStatusLoc)
                {
                    strMessageLoc = ".فایل تنظیمات وجود ندارد"; 
                }
                if (!bolDbStatusLoc)
                {
                    strMessageLoc += "\n";
                    strMessageLoc += ".ارتباط با پایگاه داده قطع می باشد";
                }
                MessageBox.Show(strMessageLoc,"خطا",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign);
            }

            return bolFinalResultLoc;
        }

        private void menLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("آیا می خواهید از این کاربر خارج شوید؟", "خروج", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.usLogined.Logout(this.cnConnection);

                this.menOffice.Enabled = false;
                this.menEmployees.Enabled = false;
                this.menOfficeDepartmentPrefrences.Enabled = false;
                this.MensOfficeDepartmentStoreGetOuts.Enabled = false;

                this.menFinance.Enabled = false;
                this.menCommerce.Enabled = false;
                this.menProduction.Enabled = false;
                this.menTechnical.Enabled = false;
                this.menStore.Enabled = false;
                this.menLab.Enabled = false;

                
                this.menLogOut.Enabled = false;
                this.menLogIn.Enabled = true;
                this.staUser.Text = "بدون کاربر";
            }
        }

        private void menLogIn_Click(object sender, EventArgs e)
        {
            if (!Login.bolIsRunning)
            {
                Login frmLogin = new Login();
                frmLogin.Owner = this;
                frmLogin.cnConnection = this.cnConnection;
                frmLogin.setSettings = this.setSettings;
                frmLogin.usLogined = this.usLogined;
                frmLogin.emLogined = this.emLogined;
                frmLogin.ShowDialog();
            }
        }

        private void menWindowsEmployees_Click(object sender, EventArgs e)
        {
            foreach(Form frmIntended in this.MdiChildren)
            {
                if(frmIntended is Employees)
                {
                    frmIntended.BringToFront();
                }
            }
        }

        private void menEmployees_Click(object sender, EventArgs e)
        {
            if (!Employees.bolIsRunning)
            {
                ToolStripMenuItem menWindowsEmployees = new ToolStripMenuItem();
                menWindowsEmployees.Name = "menWindowsEmployees";
                menWindowsEmployees.Text = "کارمندان";
                menWindowsEmployees.Click += new System.EventHandler(this.menWindowsEmployees_Click);
                this.menWindows.DropDownItems.Add(menWindowsEmployees);

                Employees frmEmployees = new Employees();
                frmEmployees.MdiParent = this;
                frmEmployees.setSettings = this.setSettings;
                frmEmployees.usUser = this.usLogined;
                frmEmployees.cnConnection = this.cnConnection;
                frmEmployees.Show();
                frmEmployees.WindowState = FormWindowState.Maximized;
            }
        }

        private void menWindowsTechnicalDocuments_Click(object sender, EventArgs e)
        {
            foreach (Form frmIntended in this.MdiChildren)
            {
                if (frmIntended is TechnicalDocuments)
                {
                    frmIntended.BringToFront();
                }
            }
        }

        private void menTechnicalDocuments_Click(object sender, EventArgs e)
        {
            if (!TechnicalDocuments.bolIsRunning)
            {
                ToolStripMenuItem menWindowsTechnicalDocuments = new ToolStripMenuItem();
                menWindowsTechnicalDocuments.Name = "menWindowsTechnicalDocuments";
                menWindowsTechnicalDocuments.Text = "مستندات";
                menWindowsTechnicalDocuments.AutoSize = false;
                menWindowsTechnicalDocuments.Height = 45;
                menWindowsTechnicalDocuments.Width = 400;
                menWindowsTechnicalDocuments.Click += new System.EventHandler(this.menWindowsTechnicalDocuments_Click);
                this.menWindows.DropDownItems.Add(menWindowsTechnicalDocuments);

                TechnicalDocuments frmTechnicalDocuments = new TechnicalDocuments();
                frmTechnicalDocuments.MdiParent = this;
                frmTechnicalDocuments.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frmTechnicalDocuments.Dock = DockStyle.Fill;
                frmTechnicalDocuments.cnConnection = this.cnConnection;
                frmTechnicalDocuments.usUser = this.usLogined;
                frmTechnicalDocuments.Show();
            }
        }

        private void menWindowsMaintenanceElectricalFurnace_Click(object sender, EventArgs e)
        {
            foreach (Form frmIntended in this.MdiChildren)
            {
                if (frmIntended is MaintenanceElectricalFurnace)
                {
                    frmIntended.BringToFront();
                }
            }
        }

        private void menMaintenanceElectricalFurnace_Click(object sender, EventArgs e)
        {
            if (!MaintenanceElectricalFurnace.bolIsRunning)
            {
                ToolStripMenuItem menWindowsMaintenanceElectricalFurnace = new ToolStripMenuItem();
                menWindowsMaintenanceElectricalFurnace.Name = "menWindowsMaintenanceElectricalFurnace";
                menWindowsMaintenanceElectricalFurnace.Text = "نگهداری برق کوره";
                menWindowsMaintenanceElectricalFurnace.AutoSize = false;
                menWindowsMaintenanceElectricalFurnace.Height = 45;
                menWindowsMaintenanceElectricalFurnace.Width = 400;
                menWindowsMaintenanceElectricalFurnace.Click += new System.EventHandler(this.menWindowsMaintenanceElectricalFurnace_Click);
                this.menWindows.DropDownItems.Add(menWindowsMaintenanceElectricalFurnace);

                MaintenanceElectricalFurnace frmFurnaceElectricalMaintenance = new MaintenanceElectricalFurnace();
                frmFurnaceElectricalMaintenance.MdiParent = this;
                frmFurnaceElectricalMaintenance.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frmFurnaceElectricalMaintenance.Dock = DockStyle.Fill;
                frmFurnaceElectricalMaintenance.cnConnection = this.cnConnection;
                frmFurnaceElectricalMaintenance.usUser = this.usLogined;
                frmFurnaceElectricalMaintenance.setSetings = this.setSettings;
                frmFurnaceElectricalMaintenance.Show();
            }
        }

        private void menWindowsLoadingRegister_Click(object sender, EventArgs e)
        {
            foreach (Form frmIntended in this.MdiChildren)
            {
                if (frmIntended is LoadingRegister)
                {
                    frmIntended.BringToFront();
                }
            }
        }

        private void menLoadingRegister_Click(object sender, EventArgs e)
        {
            if (!LoadingRegister.bolIsRunning)
            {
                ToolStripMenuItem menWindowsLoadingRegister = new ToolStripMenuItem();
                menWindowsLoadingRegister.Name = "menWindowsLoadingRegister";
                menWindowsLoadingRegister.Text = "ثبت بارگیری";
                menWindowsLoadingRegister.AutoSize = false;
                menWindowsLoadingRegister.Height = 45;
                menWindowsLoadingRegister.Width = 400;
                menWindowsLoadingRegister.Click += new System.EventHandler(this.menWindowsLoadingRegister_Click);
                this.menWindows.DropDownItems.Add(menWindowsLoadingRegister);

                LoadingRegister frmLoadingRegister = new LoadingRegister();
                frmLoadingRegister.MdiParent = this;
                frmLoadingRegister.setSetings = this.setSettings;
                frmLoadingRegister.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frmLoadingRegister.Dock = DockStyle.Fill;
                frmLoadingRegister.cnConnection = this.cnConnection;
                frmLoadingRegister.usUser = this.usLogined;
                frmLoadingRegister.setSetings = this.setSettings;
                frmLoadingRegister.Show();
            }
        }

        private void menStoreDepartmentVendors_Click(object sender, EventArgs e)
        {
            if (!Vendors.bolIsRunning)
            {
                ToolStripMenuItem menWindowsVendors = new ToolStripMenuItem();
                menWindowsVendors.Name = "menWindowsVendors";
                menWindowsVendors.Text = "فروشنده‌ها";
                menWindowsVendors.Click += new System.EventHandler(this.menWindowsVendors_Click);
                this.menWindows.DropDownItems.Add(menWindowsVendors);

                Vendors frmVendors = new Vendors();
                frmVendors.MdiParent = this;
                frmVendors.setSettings = this.setSettings;
                frmVendors.cnConnection = this.cnConnection;
                frmVendors.usUser = this.usLogined;
                frmVendors.Show();
                frmVendors.WindowState = FormWindowState.Maximized;
            }
        }

        private void menWindowsVendors_Click(object sender, EventArgs e)
        {
            foreach (Form frmIntended in this.MdiChildren)
            {
                if (frmIntended is Vendors)
                {
                    frmIntended.BringToFront();
                }
            }
        }

        private void menAbout_Click(object sender, EventArgs e)
        {
            About frmAbout = new About();
            frmAbout.cnConnection = this.cnConnection;
            frmAbout.setSettings = this.setSettings;
            frmAbout.usUser = this.usLogined;
            frmAbout.ShowDialog(this);
        }

        private void menStoreDepartmentInvoices_Click(object sender, EventArgs e)
        {
            if (!Vendors.bolIsRunning)
            {
                ToolStripMenuItem menWindowsInvoices = new ToolStripMenuItem();
                menWindowsInvoices.Name = "menWindowsInvoices";
                menWindowsInvoices.Text = "فاکتورها";
                menWindowsInvoices.Click += new System.EventHandler(this.menWindowsInvoices_Click);
                this.menWindows.DropDownItems.Add(menWindowsInvoices);

                Invoices frmInvoices = new Invoices();
                frmInvoices.setSettings = this.setSettings;
                frmInvoices.MdiParent = this;
                frmInvoices.usUser = this.usLogined;
                frmInvoices.cnConnection = this.cnConnection;
                frmInvoices.Show();
                frmInvoices.WindowState = FormWindowState.Maximized;
            }
        }

        private void menWindowsInvoices_Click(object sender, EventArgs e)
        {
            foreach (Form frmIntended in this.MdiChildren)
            {
                if (frmIntended is Vendors)
                {
                    frmIntended.BringToFront();
                }
            }
        }

        private void MenProjects_Click(object sender, EventArgs e)
        {
            if (!Projects.bolIsRunning)
            {
                ToolStripMenuItem menWindowsProjects = new ToolStripMenuItem();
                menWindowsProjects.Name = "menWindowsProjects";
                menWindowsProjects.Text = "پروژه‌ها";
                menWindowsProjects.Click += new System.EventHandler(this.menWindowsEmployees_Click);
                this.menWindows.DropDownItems.Add(menWindowsProjects);

                Projects frmProjects = new Projects();
                frmProjects.setSettings = this.setSettings;
                frmProjects.MdiParent = this;
                frmProjects.cnConnection = this.cnConnection;
                frmProjects.usUser = this.usLogined;
                frmProjects.Show();
                frmProjects.WindowState = FormWindowState.Maximized;
            }
        }

        private void MensStoreDepartmentStorePurchaseRequests_Click(object sender, EventArgs e)
        {
            if (!Projects.bolIsRunning)
            {
                ToolStripMenuItem menWindowsRequests = new ToolStripMenuItem();
                menWindowsRequests.Name = "menWindowsRequests";
                menWindowsRequests.Text = "درخواست‌ها";
                menWindowsRequests.Click += new System.EventHandler(this.menWindowsEmployees_Click);
                this.menWindows.DropDownItems.Add(menWindowsRequests);

                Requests frmRequests = new Requests();
                frmRequests.MdiParent = this;
                frmRequests.cnConnection = this.cnConnection;
                frmRequests.usUser = this.usLogined;
                frmRequests.Show();
                frmRequests.WindowState = FormWindowState.Maximized;
            }
        }

        private void MenOfficeDepartmentPrefrences_Click(object sender, EventArgs e)
        {
            if (!Projects.bolIsRunning)
            {
                ToolStripMenuItem menWindowsOfficeDepartmentPrefrences = new ToolStripMenuItem();
                menWindowsOfficeDepartmentPrefrences.Name = "menWindowsOfficeDepartmentPrefrences";
                menWindowsOfficeDepartmentPrefrences.Text = "تنظیمات واحد اداری";
                menWindowsOfficeDepartmentPrefrences.Click += new System.EventHandler(menWindowsOfficeDepartmentPrefrences_Click);
                this.menWindows.DropDownItems.Add(menWindowsOfficeDepartmentPrefrences);

                OfficePrefrences frmPrefrences = new OfficePrefrences();
                frmPrefrences.MdiParent = this;
                frmPrefrences.cnConnection = this.cnConnection;
                frmPrefrences.setSettings = this.setSettings;
                frmPrefrences.usUser = this.usLogined;
                frmPrefrences.Show();
                frmPrefrences.WindowState = FormWindowState.Maximized;
            }
        }

        private void menWindowsOfficeDepartmentPrefrences_Click(object sender, EventArgs e)
        {
            foreach (Form frmIntended in this.MdiChildren)
            {
                if (frmIntended is OfficePrefrences)
                {
                    frmIntended.BringToFront();
                }
            }
        }

        private void menStoreDepartmentStuffs_Click(object sender, EventArgs e)
        {
            if (!Stuffs.bolIsRunning)
            {
                ToolStripMenuItem menWindowsStuffs = new ToolStripMenuItem();
                menWindowsStuffs.Name = "menWindowsStuffs";
                menWindowsStuffs.Text = "کالا";
                menWindowsStuffs.Click += new System.EventHandler(this.menWindowsStuffs_Click);
                this.menWindows.DropDownItems.Add(menWindowsStuffs);

                Stuffs frmStuffs = new Stuffs();
                frmStuffs.MdiParent = this;
                frmStuffs.setSettings = this.setSettings;
                frmStuffs.cnConnection = this.cnConnection;
                frmStuffs.usUser = this.usLogined;
                frmStuffs.Show();
                frmStuffs.WindowState = FormWindowState.Maximized;
            }
        }

        private void menWindowsStuffs_Click(object sender, EventArgs e)
        {
            foreach (Form frmIntended in this.MdiChildren)
            {
                if (frmIntended is Stuffs)
                {
                    frmIntended.BringToFront();
                }
            }
        }

        private void TimCurrentDateTime_Tick(object sender, EventArgs e)
        {
            this.labTime.Text = DateTime.Now.ToString("HH:mm");
            this.labDate.Text = DateTime.Now.ToString("dddd،  dd MMMM yyyy");
        }

        private void MenStoreDepartmentStoreGetOuts_Click(object sender, EventArgs e)
        {
            if (!Stuffs.bolIsRunning)
            {
                ToolStripMenuItem menWindowsStoreDepartmentStoreGetOuts = new ToolStripMenuItem();
                menWindowsStoreDepartmentStoreGetOuts.Name = "menWindowsStoreDepartmentStoreGetOuts";
                menWindowsStoreDepartmentStoreGetOuts.Text = "درخواست‌های کالا از انبار";
                menWindowsStoreDepartmentStoreGetOuts.Click += new System.EventHandler(this.menWindowsStoreDepartmentStoreGetOuts_Click);
                this.menWindows.DropDownItems.Add(menWindowsStoreDepartmentStoreGetOuts);

                StoreGetOuts frmStoreGetOuts = new StoreGetOuts();
                frmStoreGetOuts.MdiParent = this;
                frmStoreGetOuts.setSettings = this.setSettings;
                frmStoreGetOuts.cnConnection = this.cnConnection;
                frmStoreGetOuts.usLogined = this.usLogined;
                frmStoreGetOuts.emLogined = this.emLogined;
                frmStoreGetOuts.Show();
                frmStoreGetOuts.WindowState = FormWindowState.Maximized;
            }
        }

        private void menWindowsStoreDepartmentStoreGetOuts_Click(object sender, EventArgs e)
        {
            foreach (Form frmIntended in this.MdiChildren)
            {
                if (frmIntended is StoreGetOuts)
                {
                    frmIntended.BringToFront();
                }
            }
        }

        private void MensOfficeDepartmentStoreGetOuts_Click(object sender, EventArgs e)
        {
            if (!StoreGetOuts.bolIsRunning)
            {
                ToolStripMenuItem menWindowsOfficeDepartmentStoreGetOuts = new ToolStripMenuItem();
                menWindowsOfficeDepartmentStoreGetOuts.Name = "menWindowsStoreGetOuts";
                menWindowsOfficeDepartmentStoreGetOuts.Text = "درخواست‌های کالا از انبار";
                menWindowsOfficeDepartmentStoreGetOuts.Click += new System.EventHandler(this.menWindowsOfficeDepartmentStoreGetOuts_Click);
                this.menWindows.DropDownItems.Add(menWindowsOfficeDepartmentStoreGetOuts);

                StoreGetOuts frmStoreGetOuts = new StoreGetOuts();
                frmStoreGetOuts.MdiParent = this;
                frmStoreGetOuts.setSettings = this.setSettings;
                frmStoreGetOuts.cnConnection = this.cnConnection;
                frmStoreGetOuts.usLogined = this.usLogined;
                frmStoreGetOuts.emLogined = this.emLogined;
                frmStoreGetOuts.Show();
                frmStoreGetOuts.WindowState = FormWindowState.Maximized;
            }
        }

        private void menWindowsOfficeDepartmentStoreGetOuts_Click(object sender, EventArgs e)
        {
            foreach (Form frmIntended in this.MdiChildren)
            {
                if (frmIntended is StoreGetOuts)
                {
                    frmIntended.BringToFront();
                }
            }
        }

        private void menLabDepartmentStoreGetOuts_Click(object sender, EventArgs e)
        {
            if (!StoreGetOuts.bolIsRunning)
            {
                ToolStripMenuItem menWindowsLabDepartmentStoreGetOuts = new ToolStripMenuItem();
                menWindowsLabDepartmentStoreGetOuts.Name = "menWindowsStoreGetOuts";
                menWindowsLabDepartmentStoreGetOuts.Text = "درخواست‌های کالا از انبار";
                menWindowsLabDepartmentStoreGetOuts.Click += new System.EventHandler(this.menWindowsLabDepartmentStoreGetOuts_Click);
                this.menWindows.DropDownItems.Add(menWindowsLabDepartmentStoreGetOuts);

                StoreGetOuts frmStoreGetOuts = new StoreGetOuts();
                frmStoreGetOuts.MdiParent = this;
                frmStoreGetOuts.setSettings = this.setSettings;
                frmStoreGetOuts.cnConnection = this.cnConnection;
                frmStoreGetOuts.usLogined = this.usLogined;
                frmStoreGetOuts.emLogined = this.emLogined;
                frmStoreGetOuts.Show();
                frmStoreGetOuts.WindowState = FormWindowState.Maximized;
            }
        }

        private void menWindowsLabDepartmentStoreGetOuts_Click(object sender, EventArgs e)
        {
            foreach (Form frmIntended in this.MdiChildren)
            {
                if (frmIntended is StoreGetOuts)
                {
                    frmIntended.BringToFront();
                }
            }
        }

        private void MensProductionDepartmentStoreGetOuts_Click(object sender, EventArgs e)
        {
            if (!StoreGetOuts.bolIsRunning)
            {
                ToolStripMenuItem menWindowsProductionDepartmentStoreGetOuts = new ToolStripMenuItem();
                menWindowsProductionDepartmentStoreGetOuts.Name = "menWindowsStoreGetOuts";
                menWindowsProductionDepartmentStoreGetOuts.Text = "درخواست‌های کالا از انبار";
                menWindowsProductionDepartmentStoreGetOuts.Click += new System.EventHandler(this.menWindowsProductionDepartmentStoreGetOuts_Click);
                this.menWindows.DropDownItems.Add(menWindowsProductionDepartmentStoreGetOuts);

                StoreGetOuts frmStoreGetOuts = new StoreGetOuts();
                frmStoreGetOuts.MdiParent = this;
                frmStoreGetOuts.setSettings = this.setSettings;
                frmStoreGetOuts.cnConnection = this.cnConnection;
                frmStoreGetOuts.usLogined = this.usLogined;
                frmStoreGetOuts.emLogined = this.emLogined;
                frmStoreGetOuts.Show();
                frmStoreGetOuts.WindowState = FormWindowState.Maximized;
            }
        }

        private void menWindowsProductionDepartmentStoreGetOuts_Click(object sender, EventArgs e)
        {
            foreach (Form frmIntended in this.MdiChildren)
            {
                if (frmIntended is StoreGetOuts)
                {
                    frmIntended.BringToFront();
                }
            }
        }

        private void MensTechnicalDepartmentStoreGetOuts_Click(object sender, EventArgs e)
        {
            if (!StoreGetOuts.bolIsRunning)
            {
                ToolStripMenuItem menWindowsTechnicalDepartmentStoreGetOuts = new ToolStripMenuItem();
                menWindowsTechnicalDepartmentStoreGetOuts.Name = "menWindowsStoreGetOuts";
                menWindowsTechnicalDepartmentStoreGetOuts.Text = "درخواست‌های کالا از انبار";
                menWindowsTechnicalDepartmentStoreGetOuts.Click += new System.EventHandler(this.menWindowsTechnicalDepartmentStoreGetOuts_Click);
                this.menWindows.DropDownItems.Add(menWindowsTechnicalDepartmentStoreGetOuts);

                StoreGetOuts frmStoreGetOuts = new StoreGetOuts();
                frmStoreGetOuts.MdiParent = this;
                frmStoreGetOuts.setSettings = this.setSettings;
                frmStoreGetOuts.cnConnection = this.cnConnection;
                frmStoreGetOuts.usLogined = this.usLogined;
                frmStoreGetOuts.emLogined = this.emLogined;
                frmStoreGetOuts.Show();
                frmStoreGetOuts.WindowState = FormWindowState.Maximized;
            }
        }

        private void menWindowsTechnicalDepartmentStoreGetOuts_Click(object sender, EventArgs e)
        {
            foreach (Form frmIntended in this.MdiChildren)
            {
                if (frmIntended is StoreGetOuts)
                {
                    frmIntended.BringToFront();
                }
            }
        }

        private void MenTechnicalDepartmentPrefrences_Click(object sender, EventArgs e)
        {
            if (!Projects.bolIsRunning)
            {
                ToolStripMenuItem menTechnicalDepartmentWindowsPrefrences = new ToolStripMenuItem();
                menTechnicalDepartmentWindowsPrefrences.Name = "menTechnicalDepartmentWindowsPrefrences";
                menTechnicalDepartmentWindowsPrefrences.Text = "تنظیمات واحد فنی";
                menTechnicalDepartmentWindowsPrefrences.Click += new System.EventHandler(MenWindowsTechnicalDepartmentPrefrences_Click);
                this.menWindows.DropDownItems.Add(menTechnicalDepartmentWindowsPrefrences);

                TechnicalPrefrences frmPrefrences = new TechnicalPrefrences();
                frmPrefrences.MdiParent = this;
                frmPrefrences.cnConnection = this.cnConnection;
                frmPrefrences.setSettings = this.setSettings;
                frmPrefrences.usUser = this.usLogined;
                frmPrefrences.Show();
                frmPrefrences.WindowState = FormWindowState.Maximized;
            }
        }

        private void MenWindowsTechnicalDepartmentPrefrences_Click(object sender, EventArgs e)
        {
            foreach (Form frmIntended in this.MdiChildren)
            {
                if (frmIntended is TechnicalPrefrences)
                {
                    frmIntended.BringToFront();
                }
            }
        }

        private void MenProductionDepartmentPrefrences_Click(object sender, EventArgs e)
        {
            if (!Projects.bolIsRunning)
            {
                ToolStripMenuItem menProductionDepartmentWindowsPrefrences = new ToolStripMenuItem();
                menProductionDepartmentWindowsPrefrences.Name = "menProductionDepartmentWindowsPrefrences";
                menProductionDepartmentWindowsPrefrences.Text = "تنظیمات واحد فنی";
                menProductionDepartmentWindowsPrefrences.Click += new System.EventHandler(MenWindowsProductionDepartmentPrefrences_Click);
                this.menWindows.DropDownItems.Add(menProductionDepartmentWindowsPrefrences);

                ProductionPrefrences frmPrefrences = new ProductionPrefrences();
                frmPrefrences.MdiParent = this;
                frmPrefrences.cnConnection = this.cnConnection;
                frmPrefrences.setSettings = this.setSettings;
                frmPrefrences.usUser = this.usLogined;
                frmPrefrences.Show();
                frmPrefrences.WindowState = FormWindowState.Maximized;
            }
        }

        private void MenWindowsProductionDepartmentPrefrences_Click(object sender, EventArgs e)
        {
            foreach (Form frmIntended in this.MdiChildren)
            {
                if (frmIntended is ProductionPrefrences)
                {
                    frmIntended.BringToFront();
                }
            }
        }

        private void MenStoreDepartmentPrefrences_Click(object sender, EventArgs e)
        {
            if (!Projects.bolIsRunning)
            {
                ToolStripMenuItem menStoreDepartmentWindowsPrefrences = new ToolStripMenuItem();
                menStoreDepartmentWindowsPrefrences.Name = "menStoreDepartmentWindowsPrefrences";
                menStoreDepartmentWindowsPrefrences.Text = "تنظیمات واحد انبار";
                menStoreDepartmentWindowsPrefrences.Click += new System.EventHandler(MenWindowsStoreDepartmentPrefrences_Click);
                this.menWindows.DropDownItems.Add(menStoreDepartmentWindowsPrefrences);

                StorePrefrences frmPrefrences = new StorePrefrences();
                frmPrefrences.MdiParent = this;
                frmPrefrences.cnConnection = this.cnConnection;
                frmPrefrences.setSettings = this.setSettings;
                frmPrefrences.usUser = this.usLogined;
                frmPrefrences.Show();
                frmPrefrences.WindowState = FormWindowState.Maximized;
            }
        }

        private void MenWindowsStoreDepartmentPrefrences_Click(object sender, EventArgs e)
        {
            foreach (Form frmIntended in this.MdiChildren)
            {
                if (frmIntended is StorePrefrences)
                {
                    frmIntended.BringToFront();
                }
            }
        }

        private void menLabDepartmentPrefrences_Click(object sender, EventArgs e)
        {
            if (!Projects.bolIsRunning)
            {
                ToolStripMenuItem menLabDepartmentWindowsPrefrences = new ToolStripMenuItem();
                menLabDepartmentWindowsPrefrences.Name = "menLabDepartmentWindowsPrefrences";
                menLabDepartmentWindowsPrefrences.Text = "تنظیمات واحد آزمایشگاه";
                menLabDepartmentWindowsPrefrences.Click += new System.EventHandler(MenWindowsLabDepartmentPrefrences_Click);
                this.menWindows.DropDownItems.Add(menLabDepartmentWindowsPrefrences);

                StorePrefrences frmPrefrences = new StorePrefrences();
                frmPrefrences.MdiParent = this;
                frmPrefrences.cnConnection = this.cnConnection;
                frmPrefrences.setSettings = this.setSettings;
                frmPrefrences.usUser = this.usLogined;
                frmPrefrences.Show();
                frmPrefrences.WindowState = FormWindowState.Maximized;
            }
        }

        private void MenWindowsLabDepartmentPrefrences_Click(object sender, EventArgs e)
        {
            foreach (Form frmIntended in this.MdiChildren)
            {
                if (frmIntended is StorePrefrences)
                {
                    frmIntended.BringToFront();
                }
            }
        }

        private void Management_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.usLogined.bolLogined)
            {
                this.usLogined.Logout(this.cnConnection);
            }
        }

        private void Management_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F10:
                    Application.Exit();
                    break;
            }
        }
    }
}
