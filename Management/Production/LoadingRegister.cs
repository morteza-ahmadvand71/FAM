using Baran.Ferroalloy.Automation.Security;
using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Office;
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
    public partial class LoadingRegister : Form
    {
        public static Boolean bolIsRunning;
        public Connection cnConnection;
        public User usUser;
        public FamSetting setSetings;
        //Serial Port
        private SerialPortRS232 spLoadingScale;
        //Loadings
        private Loading LodLast;
        private Loading LodCurrent;
        private Loading LodNext;
        //ShiftInfo 
        private ShiftInfo siShift;
        //DateTime for Real Start DateTime of Loading 
        private DateTime dtRealStart;
        //Timer for Loading Duration
        Timer tmrLoadingDuration;
        //Timer for Loading Duration
        Timer tmrbutRegisterDelay;
        //Weight Received from Scale
        private int intScaleWeight;
        //Weight for Enable or Disable butWeightRegister
        private int intScaleWeightForDelay;
        //Save Status of Loading in XML File. This Useful When Loading PC is Shutdown
        private String strCurrentLoadingFilePath
        {
            get
            {
                return this.setSetings.strXmlPath + @"\xmlCurrentLoading.xml";
            }
        }
        private String strNextLoadingFilePath
        {
            get
            {
                return this.setSetings.strXmlPath + @"\xmlNextLoading.xml";
            }
        }

        public LoadingRegister()
        {
            InitializeComponent();
        }
        private void LoadingRegister_Load(object sender, EventArgs e)
        {
            SetComponentsByPermisions();

            this.siShift = new ShiftInfo(this.cnConnection, this.setSetings.stProductionFurnaceShifttypePty, this.setSetings.dtProductionFurnaceDateOrginPty);
            this.intScaleWeight = 0;
            this.tmrLoadingDuration = new Timer();
            this.tmrbutRegisterDelay = new Timer();

            //SetSerialPort();

            this.LodLast = Loading.GetLastLoadingFromDB(this.cnConnection);

            //MessageBox.Show(Loading.CurrentLoaingFromToXML(this.strCurrentLoadingFilePath, "IsLoading", "", false).ToString());
            //MessageBox.Show(Loading.NextLoaingFromToXML(this.strNextLoadingFilePath, "IsLoading", "", false).ToString());
            //Postion 1: Current and Next Loading arent in Loading.
            if (!(Boolean)Loading.CurrentLoaingFromToXML(this.strCurrentLoadingFilePath, "IsLoading", "", false) &&
                !(Boolean)Loading.NextLoaingFromToXML(this.strNextLoadingFilePath, "IsLoading", "", false))
            {
                this.LodCurrent = new Loading();
                this.LodNext = new Loading();
                this.LodCurrent.intLoadingCountPty = this.LodLast.NextLoadingCount(this.siShift.GetDate(DateTime.Now));
                Loading.CurrentLoaingFromToXML(this.strCurrentLoadingFilePath, "Intialization", "", true);
                Loading.NextLoaingFromToXML(this.strNextLoadingFilePath, "Intialization", "", true);
            }
            //Postion 2: Current is in Loading and Next Loading isnt.
            if ((Boolean)Loading.CurrentLoaingFromToXML(this.strCurrentLoadingFilePath, "IsLoading", "", false) &&
                !(Boolean)Loading.NextLoaingFromToXML(this.strNextLoadingFilePath, "IsLoading", "", false))
            {
                this.LodCurrent = (Loading)Loading.CurrentLoaingFromToXML(this.strCurrentLoadingFilePath, "Loading", "", false);
                this.LodNext = new Loading();
            }
            //Postion 3: Current isnt in Loading and Next Loading is.
            if (!(Boolean)Loading.CurrentLoaingFromToXML(this.strCurrentLoadingFilePath, "IsLoading", "", false) &&
                (Boolean)Loading.NextLoaingFromToXML(this.strNextLoadingFilePath, "IsLoading", "", false))
            {
                this.LodCurrent = new Loading();
                this.LodNext = (Loading)Loading.NextLoaingFromToXML(this.strNextLoadingFilePath, "Loading", "", false);
            }

            SetFormComponents();
        }
        private void SetComponentsByPermisions()
        {
            if (this.usUser.bolProductionEnabed)
            {
                this.cbLadleNumbers.Enabled = true;
                this.cbTapholeNumbers.Enabled = true; 
                this.tbTapholePosition.Enabled = true;
                this.butEmptyLadleRegister.Enabled = true;
                this.butWeightRegister.Enabled = true;
                this.butStart.Enabled = true;
                this.butStop.Enabled = true;
                this.butRegister.Enabled = true;
                this.butTapholeClose.Enabled = true;
            }
            else
            {
                this.cbLadleNumbers.Enabled = false;
                this.cbTapholeNumbers.Enabled = false;
                this.tbTapholePosition.Enabled = false;
                this.butEmptyLadleRegister.Enabled = false;
                this.butWeightRegister.Enabled = false;
                this.butStart.Enabled = false;
                this.butStop.Enabled = false;
                this.butRegister.Enabled = false;
                this.butTapholeClose.Enabled = false;
            }
        }
        private void btmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadingRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            bolIsRunning = false;

            Management frmManagement = (Management)this.MdiParent;
            frmManagement.menWindows.DropDownItems["menWindowsLoadingRegister"].Dispose();
        }
        private void SetFormComponents()
        {
            this.cbLadleNumbers.Items.AddRange(Loading.GetCurrentLadles(this.cnConnection));

            for (int i = 1; i <= this.setSetings.intTapholeCountPty; ++i)
            {
                this.cbTapholeNumbers.Items.Add(i.ToString());
            }

            if (this.tmrLoadingDuration.Interval != 1000 && this.tmrLoadingDuration.Interval != 3000)
            {
                this.tmrLoadingDuration.Interval = 1000;
                this.tmrLoadingDuration.Tick += new System.EventHandler(this.tmrLoadingDuration_Tick);
                this.tmrbutRegisterDelay.Interval = 3000;
                this.tmrbutRegisterDelay.Tick += new System.EventHandler(this.tmrbutRegisterDelay_Tick);
            }

            Loading lodSetComponentLoc = null;
            //Postion 1
            if (!this.LodCurrent.bolIsLoadingPty && !this.LodNext.bolIsLoadingPty)
            {
                lodSetComponentLoc = this.LodCurrent;
                this.butStart.Enabled = true;
                this.butStop.Enabled = false;

                this.cbTapholeNumbers.Text = this.LodLast.strTapholeNumberPty;
                this.tbTapholePosition.Text = this.LodLast.intTapholePositionPty.ToString();
                this.cbLadleNumbers.Text = this.LodLast.strLadleNumberPty;

                this.tmrLoadingDuration.Stop();
                this.tmrbutRegisterDelay.Stop();
            }
            //Postion 2
            if (this.LodCurrent.bolIsLoadingPty && !this.LodNext.bolIsLoadingPty)
            {
                lodSetComponentLoc = this.LodCurrent;
                this.butStart.Enabled = false;
                this.butStop.Enabled = true;
                this.tmrLoadingDuration.Start();
                this.tmrbutRegisterDelay.Start();
            }
            //Postion 3
            if (!this.LodCurrent.bolIsLoadingPty && this.LodNext.bolIsLoadingPty)
            {
                lodSetComponentLoc = this.LodNext;
                this.butStart.Enabled = false;
                this.butStop.Enabled = true;
                this.tmrLoadingDuration.Start();
                this.tmrbutRegisterDelay.Start();
            }
            this.labLoadingCount.Text = lodSetComponentLoc.intLoadingCountPty.ToString();
            this.labLadleLoadingCount.Text = lodSetComponentLoc.intLadleLoadingCountPty.ToString();
            this.cbLadleNumbers.Text = lodSetComponentLoc.strLadleNumberPty.ToString();
            this.cbTapholeNumbers.Text = lodSetComponentLoc.strTapholeNumberPty.ToString();
            this.tbTapholePosition.Text = lodSetComponentLoc.intTapholePositionPty.ToString();
          ////  this.labEmptyWeight.Text = lodSetComponentLoc.intEmptyWeightPty.ToString();
            this.labFillWeight.Text = lodSetComponentLoc.intFillWeightPty.ToString();
          ////  this.labLoadingDuration.Text = lodSetComponentLoc.tsLoadingDurationPty.ToString();
            this.labStart.Text = lodSetComponentLoc.tsStartPty.ToString();
            this.labStop.Text = lodSetComponentLoc.tsStopPty.ToString();
        }
        private void spLoadingScale_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                this.intScaleWeight = System.Int32.Parse(this.spLoadingScale.ReadLine().Substring(0, 5));
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
            //Prevent Of ThreadPool thread
            Label.CheckForIllegalCrossThreadCalls = false;
            this.spLoadingScale = new SerialPortRS232(this.setSetings.strLoadingScaleSerialPortRS232Pty);
            this.spLoadingScale.Close();
            //this.SerialPortBaskol = new SerialPort(
            //    TappingSettings.GetSPSettings(FilePath_TappingSettings, SerialPort.SerialPortTypes.Weight));
            this.spLoadingScale.DataReceived +=
                new System.IO.Ports.SerialDataReceivedEventHandler(spLoadingScale_DataReceived);
            this.spLoadingScale.Open();
        }
        private void butStart_Click(object sender, EventArgs e)
        {
            DialogResult drResult = MessageBox.Show("آیا می خواهید بارگیی را شروع کنید؟", "هشدار",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (drResult == DialogResult.Yes)
            {
                this.LodCurrent = new Loading();
                this.LodNext = new Loading();

                this.LodCurrent.bolIsIntsertedPty = false;
                this.LodCurrent.bolIsLoadingPty = true;
                this.LodCurrent.dtDatePty = this.siShift.GetDate(DateTime.Now.Date);
                this.dtRealStart = DateTime.Now;
                this.LodCurrent.tsStartPty = DateTime.Now.TimeOfDay;
                this.LodCurrent.intLoadingCountPty = this.LodLast.NextLoadingCount(this.LodCurrent.dtDatePty);
                this.LodCurrent.strLadleNumberPty = this.cbLadleNumbers.Text;
                this.LodCurrent.GetLadleEmptyWeightFromDB(this.cnConnection);
                this.LodCurrent.GetLadleLoadingCountFromDB(this.cnConnection);
                this.LodCurrent.strTapholeNumberPty = this.cbTapholeNumbers.Text;
                this.LodCurrent.intTapholePositionPty = int.Parse(this.tbTapholePosition.Text);

                Loading.CurrentLoaingFromToXML(this.strCurrentLoadingFilePath, "Intialization", null, true);
                Loading.NextLoaingFromToXML(this.strNextLoadingFilePath, "Intialization", null, true);

                Loading.CurrentLoaingFromToXML(this.strCurrentLoadingFilePath, "Loading", this.LodCurrent , true);

                SetFormComponents();
            }
        }
        private void cbLadleNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Postion 1
            if (!this.LodCurrent.bolIsLoadingPty && !this.LodNext.bolIsLoadingPty)
            {
                this.LodCurrent.strLadleNumberPty = this.cbLadleNumbers.Text;
                this.LodCurrent.GetLadleEmptyWeightFromDB(this.cnConnection);
                this.LodCurrent.GetLadleLoadingCountFromDB(this.cnConnection);
                Loading.CurrentLoaingFromToXML(this.strCurrentLoadingFilePath, "LadleNumber", this.LodCurrent.strLadleNumberPty, true);
                Loading.CurrentLoaingFromToXML(this.strCurrentLoadingFilePath, "LadleLoadingCount", this.LodCurrent.intLadleLoadingCountPty, true);
               //// Loading.CurrentLoaingFromToXML(this.strCurrentLoadingFilePath, "EmptyWeight", this.LodCurrent.intEmptyWeightPty, true);
             ////   this.labEmptyWeight.Text = this.LodCurrent.intEmptyWeightPty.ToString();
                this.labLadleLoadingCount.Text = this.LodCurrent.intLadleLoadingCountPty.ToString();
            }
            //Postion 2
            if (this.LodCurrent.bolIsLoadingPty && !this.LodNext.bolIsLoadingPty)
            {
                this.LodCurrent.strLadleNumberPty = this.cbLadleNumbers.Text;
                this.LodCurrent.GetLadleEmptyWeightFromDB(this.cnConnection);
                this.LodCurrent.GetLadleLoadingCountFromDB(this.cnConnection);
                Loading.CurrentLoaingFromToXML(this.strCurrentLoadingFilePath, "LadleNumber", this.LodCurrent.strLadleNumberPty, true);
                Loading.CurrentLoaingFromToXML(this.strCurrentLoadingFilePath, "LadleLoadingCount", this.LodCurrent.intLadleLoadingCountPty, true);
              ////  Loading.CurrentLoaingFromToXML(this.strCurrentLoadingFilePath, "EmptyWeight", this.LodCurrent.intEmptyWeightPty, true);
              ////  this.labEmptyWeight.Text = this.LodCurrent.intEmptyWeightPty.ToString();
                this.labLadleLoadingCount.Text = this.LodCurrent.intLadleLoadingCountPty.ToString();
            }
            //Postion 3
            if (!this.LodCurrent.bolIsLoadingPty && this.LodNext.bolIsLoadingPty)
            {
                this.LodNext.strLadleNumberPty = this.cbLadleNumbers.Text;
                this.LodNext.GetLadleEmptyWeightFromDB(this.cnConnection);
                this.LodNext.GetLadleLoadingCountFromDB(this.cnConnection);
                Loading.NextLoaingFromToXML(this.strNextLoadingFilePath, "LadleNumber", this.LodCurrent.strLadleNumberPty, true);
                Loading.NextLoaingFromToXML(this.strNextLoadingFilePath, "LadleLoadingCount", this.LodCurrent.intLadleLoadingCountPty, true);
         ////       Loading.NextLoaingFromToXML(this.strNextLoadingFilePath, "EmptyWeight", this.LodCurrent.intEmptyWeightPty, true);
          ////      this.labEmptyWeight.Text = this.LodNext.intEmptyWeightPty.ToString();
                this.labLadleLoadingCount.Text = this.LodNext.intLadleLoadingCountPty.ToString();
            }
        }
        private void cbTapholeNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Postion 1
            if (!this.LodCurrent.bolIsLoadingPty && !this.LodNext.bolIsLoadingPty)
            {
                this.LodCurrent.strTapholeNumberPty = this.cbTapholeNumbers.Text;
                Loading.CurrentLoaingFromToXML(this.strCurrentLoadingFilePath, "TapholeNumber", this.LodCurrent.strTapholeNumberPty.ToString(), true);
            }
            //Postion 2
            if (this.LodCurrent.bolIsLoadingPty && !this.LodNext.bolIsLoadingPty)
            {
                this.LodCurrent.strTapholeNumberPty = this.cbTapholeNumbers.Text;
                Loading.CurrentLoaingFromToXML(this.strCurrentLoadingFilePath, "TapholeNumber", this.LodCurrent.strTapholeNumberPty.ToString(), true);
            }
            //Postion 3
            if (!this.LodCurrent.bolIsLoadingPty && this.LodNext.bolIsLoadingPty)
            {
                this.LodNext.strTapholeNumberPty = this.cbTapholeNumbers.Text;
                Loading.NextLoaingFromToXML(this.strNextLoadingFilePath, "TapholeNumber", this.LodCurrent.strTapholeNumberPty.ToString(), true);
            }
        }
        private void tbTapholePosition_TextChanged(object sender, EventArgs e)
        {
            //Postion 1
            if (!this.LodCurrent.bolIsLoadingPty && !this.LodNext.bolIsLoadingPty)
            {
                try
                {
                    this.LodCurrent.intTapholePositionPty = int.Parse(this.tbTapholePosition.Text);
                    Loading.CurrentLoaingFromToXML(this.strCurrentLoadingFilePath, "TapholePostion", this.LodCurrent.strTapholeNumberPty.ToString(), true);
                }
                catch (ArgumentOutOfRangeException OutOfRange)
                {
                    MessageBox.Show(OutOfRange.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                }
                catch(System.FormatException)
                {
                    //this.tbTapholePosition.Text = "";
                }
                
            }
            //Postion 2
            if (this.LodCurrent.bolIsLoadingPty && !this.LodNext.bolIsLoadingPty)
            {
                try
                {
                    this.LodCurrent.intTapholePositionPty = int.Parse(this.tbTapholePosition.Text);
                }
                catch (ArgumentOutOfRangeException OutOfRange)
                {
                    MessageBox.Show(OutOfRange.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    this.tbTapholePosition.Text = "";
                }
                Loading.CurrentLoaingFromToXML(this.strCurrentLoadingFilePath, "TapholePostion", this.LodCurrent.strTapholeNumberPty.ToString(), true);
            }
            //Postion 3
            if (!this.LodCurrent.bolIsLoadingPty && this.LodNext.bolIsLoadingPty)
            {
                try
                {
                    this.LodNext.intTapholePositionPty = int.Parse(this.tbTapholePosition.Text);
                }
                catch (ArgumentOutOfRangeException OutOfRange)
                {
                    MessageBox.Show(OutOfRange.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    this.tbTapholePosition.Text = "";
                }
                Loading.NextLoaingFromToXML(this.strNextLoadingFilePath, "TapholePostion", this.LodCurrent.strTapholeNumberPty.ToString(), true);
            }
        }
        private void butWeightRegister_Click(object sender, EventArgs e)
        {
            //Postion 1
            if (!this.LodCurrent.bolIsLoadingPty && !this.LodNext.bolIsLoadingPty)
            {
                this.LodCurrent.intFillWeightPty = this.intScaleWeight;
                Loading.CurrentLoaingFromToXML(this.strCurrentLoadingFilePath, "FillWeight", this.LodCurrent.intFillWeightPty.ToString(), true);
                this.labFillWeight.Text = this.LodCurrent.intFillWeightPty.ToString();
            }
            //Postion 2
            if (this.LodCurrent.bolIsLoadingPty && !this.LodNext.bolIsLoadingPty)
            {
                this.LodCurrent.intFillWeightPty = this.intScaleWeight;
                Loading.CurrentLoaingFromToXML(this.strCurrentLoadingFilePath, "FillWeight", this.LodCurrent.intFillWeightPty.ToString(), true);
                this.labFillWeight.Text = this.LodCurrent.intFillWeightPty.ToString();
            }
            //Postion 3
            if (!this.LodCurrent.bolIsLoadingPty && this.LodNext.bolIsLoadingPty)
            {
                this.LodNext.intFillWeightPty = this.intScaleWeight;
                Loading.NextLoaingFromToXML(this.strNextLoadingFilePath, "FillWeight", this.LodNext.intFillWeightPty.ToString(), true);
                this.labFillWeight.Text = this.LodNext.intFillWeightPty.ToString();
            }
        }
        private void tmrLoadingDuration_Tick(object sender, EventArgs e)
        {
            //Postion 1
            if (!this.LodCurrent.bolIsLoadingPty && !this.LodNext.bolIsLoadingPty)
            {
                this.labLoadingDuration.Text = (DateTime.Now - this.dtRealStart).ToString("HH:MM");
            }
            //Postion 2
            if (this.LodCurrent.bolIsLoadingPty && !this.LodNext.bolIsLoadingPty)
            {
                this.labLoadingDuration.Text = (DateTime.Now - this.dtRealStart).ToString("HH:MM");
            }
            //Postion 3
            if (!this.LodCurrent.bolIsLoadingPty && this.LodNext.bolIsLoadingPty)
            {
                this.labLoadingDuration.Text = (DateTime.Now - this.dtRealStart).ToString("HH:MM");
            }
        }
        private void tmrbutRegisterDelay_Tick(object sender, EventArgs e)
        {
            if(this.intScaleWeight == this.intScaleWeightForDelay && this.intScaleWeight != 0)
            {
                this.butWeightRegister.Enabled = true;
            }
            else
            {
                this.butWeightRegister.Enabled = false;
            }

            this.intScaleWeightForDelay = this.intScaleWeight;
        }
        private void butStop_Click(object sender, EventArgs e)
        {
            //Show MessageBox
            DialogResult ResultMess = MessageBox.Show("آیا مطمئنید که می خواهید بارگیری را خاتمه دهید؟", "هشدار",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //If Yes Button Is Pressed
            if (ResultMess == DialogResult.Yes)
            {
                this.LodCurrent.bolIsLoadingPty = false;
                this.LodCurrent.tsStopPty = DateTime.Now.TimeOfDay;

                Loading.CurrentLoaingFromToXML(this.strCurrentLoadingFilePath, "IsLoading", this.LodCurrent.bolIsLoadingPty.ToString(), true);
                Loading.CurrentLoaingFromToXML(this.strCurrentLoadingFilePath, "StopTime", this.LodCurrent.tsStopPty.ToString(), true);

                this.LodNext = new Loading();

                this.LodNext.bolIsIntsertedPty = false;
                this.LodNext.bolIsLoadingPty = true;
                this.LodNext.intLoadingCountPty = this.LodCurrent.NextLoadingCount(this.LodCurrent.dtDatePty);
                this.LodNext.dtDatePty = this.siShift.GetDate(DateTime.Now);
                this.LodNext.tsStartPty = DateTime.Now.TimeOfDay;
                this.LodNext.strLadleNumberPty = this.cbLadleNumbers.Text;
                this.LodNext.GetLadleEmptyWeightFromDB(this.cnConnection);
                this.LodNext.GetLadleLoadingCountFromDB(this.cnConnection);
                this.LodNext.strTapholeNumberPty = this.cbTapholeNumbers.Text;
                this.LodNext.intTapholePositionPty = int.Parse(this.tbTapholePosition.Text);

                Loading.NextLoaingFromToXML(this.strNextLoadingFilePath, "Intialization", "", true);

                Loading.NextLoaingFromToXML(this.strCurrentLoadingFilePath, "Loading", this.LodNext, true);

                SetFormComponents();
            }
        }
        private void butRegister_Click(object sender, EventArgs e)
        {
            DialogResult ResultMess = MessageBox.Show("آیا می خواهید اطلاعات پاتیل ثبت شود؟", "هشدار",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            if (ResultMess == DialogResult.Yes)
            {
                this.LodCurrent.Insert(this.cnConnection);
                this.LodCurrent.bolIsIntsertedPty = true;

                this.LodCurrent = this.LodNext;
                this.LodNext.bolIsIntsertedPty = true;
                this.LodNext = new Loading();

                Loading.CurrentLoaingFromToXML(this.strCurrentLoadingFilePath, "Intialization", "", true);
                Loading.NextLoaingFromToXML(this.strNextLoadingFilePath, "Intialization", "", true);

                Loading.CurrentLoaingFromToXML(this.strCurrentLoadingFilePath, "Loading", this.LodCurrent, true);

                //Select Another Ladle in cbLadleNumbers Component
                try
                {
                    ++this.cbLadleNumbers.SelectedIndex;
                }
                catch(IndexOutOfRangeException)
                {
                    this.cbLadleNumbers.SelectedIndex = 0;
                }

                SetFormComponents();
            }
        }
        private void butEmptyLadleRegister_Click(object sender, EventArgs e)
        {
            EmptyLadleRegister frmEmptyLadleRegister = new EmptyLadleRegister();
            frmEmptyLadleRegister.cnConnection = this.cnConnection;
            frmEmptyLadleRegister.setSetings = this.setSetings;
            frmEmptyLadleRegister.spEmptyLadleScale = this.spLoadingScale;
        }
    }
}
