using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Production.LoadingUnit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baran.Ferroalloy.Management
{
    public partial class EmptyLadleRegister : Form
    {
        public static Boolean bolIsRunning;
        public Connection cnConnection;
        public FamSetting setSetings;
        public static bool bolWritePermision;
        //Serial Port
        public SerialPortRS232 spEmptyLadleScale;
        //Save Status of Loading in XML File. This Useful When Loading PC is Shutdown
        private String strCurrentLoadingFilePath
        {
            get
            {
                return this.setSetings.strXmlPath + @"\xmlCurrentLoading.xml";
            }
        }
        //Weight Received from Scale
        private int intScaleWeight;
        //Timer for Delay of Weight
        private Timer tmrbutRegisterDelay;
        //Weight for Enable or Disable butWeightRegister
        private int intScaleWeightForDelay;

        public EmptyLadleRegister()
        {
            InitializeComponent();
        }
        private void spEmptyLadleScale_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                this.intScaleWeight = System.Int32.Parse(this.spEmptyLadleScale.ReadLine().Substring(0, 5));
                if (this.labWeight.Text != this.intScaleWeight.ToString())
                {
                    this.labWeight.Text = this.intScaleWeight.ToString();
                }
                if (this.intScaleWeight == 0)
                {
                    this.butWeightRegister.Enabled = false;
                }
            }
            catch (System.FormatException)
            {
            }
        }
        private void SetSerialPort()
        {
            this.spEmptyLadleScale.DataReceived +=
                new System.IO.Ports.SerialDataReceivedEventHandler(spEmptyLadleScale_DataReceived);
        }
        private void EmptyLadleRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.spEmptyLadleScale.DataReceived -=
                new System.IO.Ports.SerialDataReceivedEventHandler(spEmptyLadleScale_DataReceived);
        }
        private void tmrbutRegisterDelay_Tick(object sender, EventArgs e)
        {
            if (this.intScaleWeight == this.intScaleWeightForDelay && this.intScaleWeight != 0)
            {
                this.butWeightRegister.Enabled = true;
            }
            else
            {
                this.butWeightRegister.Enabled = false;
            }

            this.intScaleWeightForDelay = this.intScaleWeight;
        }
        private void SetFormComponents()
        {
            this.cbLadleNumbers.Items.AddRange(Loading.GetCurrentLadles(this.cnConnection));

            if (this.tmrbutRegisterDelay.Interval != 3000 )
            {
                this.tmrbutRegisterDelay.Interval = 3000;
                this.tmrbutRegisterDelay.Tick += new System.EventHandler(this.tmrbutRegisterDelay_Tick);
            }
        }
        private void butWeightRegister_Click(object sender, EventArgs e)
        {
            this.labEmptyWeight.Text = this.intScaleWeight.ToString();
            this.butRegister.Enabled = true;
        }
        private void butRegister_Click(object sender, EventArgs e)
        {
            this.butRegister.Enabled = false;
            this.butWeightRegister.Enabled = false;
        }
        private void EmptyLadleRegister_Load(object sender, EventArgs e)
        {
            this.tmrbutRegisterDelay = new Timer();
        }
    }
}
