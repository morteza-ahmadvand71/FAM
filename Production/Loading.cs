using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Office;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static Baran.Ferroalloy.Office.ShiftInfo;

namespace Baran.Ferroalloy.Production.LoadingUnit
{
    public class Loading
    {
        //Number of Ladle
        private String strLadleNumber;
        //Masidegi of Loading
        private int intLadleMasidegi;
        //Determinte if Loading Is Inserted To DB 
        private Boolean bolIsIntserted;
        //Determinate Loading Is Loading Or No.
        private Boolean bolIsLoading;
        //Start Time Of Loading
        private TimeSpan tsStart;
        //Stop Time Of Loading
        private TimeSpan tsStop;
        //Duration
        private TimeSpan tsDuration;
        //Date Of Loading
        private DateTime dtDate;
        //Counter Of Loading in Month
        private int intLoadingCount;
        //Taphole Of Loading
        private String strTapholeNumber;
        //Mogheiat Of Loading Dahaneh
        private int intTapholePosition;
        //Group Of Loading
        private String strGroupNumber;
        //ShiftType Of Loading Unit
        private ShiftInfo.Shift shiShift;
        //Emety Weight Of Before Loading
        private int intEmptyWeightBeforeLoading;
        //Emety Weight Of After Loading
        private int intEmptyWeightAfterLoading;
        //Fill Weight Of Loading
        private int intFillWeight;
        //Counter Of Ladle Loading
        private int intLadleLoadingCount;

        //Number of Ladle
        public String strLadleNumberPty
        {
            get
            {
                return this.strLadleNumber;
            }
            set
            {
                this.strLadleNumber = value;
            }
        }
        //Masidegi of Loading
        public int intLadleMasidegiPty
        {
            get
            {
                return this.intLadleMasidegi;
            }
            set
            {
                this.intLadleMasidegi = value;
            }
        }
        //Determinte if Loading Is Inserted To DB 
        public Boolean bolIsIntsertedPty
        {
            get
            {
                return this.bolIsIntserted;
            }
            set
            {
                this.bolIsIntserted = value;
            }
        }
        //Determinate Loading Is Loading Or No.
        public Boolean bolIsLoadingPty
        {
            get
            {
                return this.bolIsLoading;
            }
            set
            {
                this.bolIsLoading = value;
            }
        }
        //Start Time Of Loading
        public TimeSpan tsStartPty
        {
            get
            {
                return this.tsStart;
            }
            set
            {
                this.tsStart = value;
            }
        }
        //Stop Time Of Loading
        public TimeSpan tsStopPty
        {
            get
            {
                return this.tsStop;
            }
            set
            {
                //Set Stop
                this.tsStop = value;
            }
        }
        //Date Of Loading
        public DateTime dtDatePty
        {
            get
            {
                return this.dtDate;
            }
            set
            {
                this.dtDate = value;
            }
        }
        //Counter Of Loading in Month
        public int intLoadingCountPty
        {
            get
            {
                return this.intLoadingCount;
            }
            set
            {
                this.intLoadingCount = value;
            }
        }
        //Taphole Of Loading
        public String strTapholeNumberPty
        {
            get
            {
                return this.strTapholeNumber;
            }
            set
            {
               this.strTapholeNumber = value;
            }
        }
        //Mogheiat Of Loading Dahaneh
        public int intTapholePositionPty
        {
            get
            {
                return this.intTapholePosition;
            }
            set
            {
                if (value >= -60 && value <= 60)
                {
                    this.intTapholePosition = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("","عدد وارید شده باید بین -60 تا 60 باشد.");
                }
            }
        }
        //Group Of Loading
        public String strGroupNumberPty
        {
            get
            {
                return this.strGroupNumber;
            }
            set
            {
                this.strGroupNumber = value;
            }
        }
        //ShiftType Of Loading Unit
        public ShiftInfo.Shift shiShiftPty
        {
            get
            {
                return this.shiShift;
            }
            set
            {
                this.shiShift = value;
            }
        }
        //Emety Weight Of Loading
        public int intEmptyWeightBeforeLoadingPty
        {
            get
            {
                return this.intEmptyWeightBeforeLoading;
            }
            set
            {
                this.intEmptyWeightBeforeLoading = value;
            }
        }
        //Emety Weight Of Loading
        public int intEmptyWeightAfterLoadingPty
        {
            get
            {
                return this.intEmptyWeightAfterLoading;
            }
            set
            {
                this.intEmptyWeightAfterLoading = value;
            }
        }
        //Fill Weight Of Loading
        public int intFillWeightPty
        {
            get
            {
                return this.intFillWeight;
            }
            set
            {
                this.intFillWeight = value;
            }
        }
        //Net Weight
        public int intNetWeightPty
        {
            get
            {
                return (this.intFillWeightPty - this.intEmptyWeightBeforeLoadingPty);
            }
        }
        //Return Melt Interval
        public TimeSpan tsDurationPty
        {
            get
            {
                return this.tsDuration;
            }
            set
            {
                this.tsDuration = value;
            }

        }
        //return Rate of Melt
        public Double dobMeltRatePty
        {
            get
            {
                return this.intNetWeightPty / this.tsDurationPty.Minutes;
            }
        }
        //Counter Of Ladle Loading In Mounth
        public int intLadleLoadingCountPty
        {
            get
            {
                return this.intLadleLoadingCount;
            }
            set
            {
                this.intLadleLoadingCount = value;
            }
        }
               
        //Constructor
        public Loading()
        {
            this.bolIsIntserted = true;
            this.bolIsLoadingPty = false;
            this.strLadleNumberPty = "0";
            this.intLadleMasidegiPty = 0;
            this.tsStartPty = new TimeSpan();
            this.tsStopPty = new TimeSpan();
            this.dtDatePty = new DateTime();
            this.intLoadingCountPty = 0;
            this.strTapholeNumberPty = "0";
            this.intTapholePositionPty = 0;
            this.strGroupNumberPty = "0";
            this.intEmptyWeightBeforeLoadingPty = 0;
            this.intEmptyWeightAfterLoadingPty = 0;
            this.intFillWeightPty = 0;
            this.intLadleLoadingCountPty = 0;
        }
        public static Object CurrentLoaingFromToXML(String strXMLFilePathArg, String strAttributeArg, Object strValueArg, Boolean bolSetArg)
        {
            Object objValue = null;

            //Declare And Instance XmlDocument
            XmlDocument docLoading = new XmlDocument();
            //Load XmlDocument
            docLoading.Load(strXMLFilePathArg);
            //Declare XmlNodeList
            XmlNode nodLoading;

            switch (strAttributeArg)
            {
                case "IsInsertedToDB":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/IsInsertedToDB");
                        //Set Value
                        nodLoading.InnerText = ((Boolean)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = Boolean.Parse(docLoading.SelectSingleNode("Loading/IsInsertedToDB").InnerText);
                    }
                    break;
                case "IsLoading":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/IsLoading");
                        //Set Value
                        nodLoading.InnerText = ((Boolean)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = Boolean.Parse(docLoading.SelectSingleNode("Loading/IsLoading").InnerText);
                    }
                    break;
                case "LoadingCount":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/LoadingCount");
                        //Set Value
                        nodLoading.InnerText = ((int)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = int.Parse(docLoading.SelectSingleNode("Loading/LoadingCount").InnerText);
                    }
                    break;
                case "Date":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/Date");
                        //Set Value
                        nodLoading.InnerText = ((DateTime)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = DateTime.Parse(docLoading.SelectSingleNode("Loading/Date").InnerText);
                    }
                    break;
                case "StartTime":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/StartTime");
                        //Set Value
                        nodLoading.InnerText = ((TimeSpan)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = TimeSpan.Parse(docLoading.SelectSingleNode("Loading/StartTime").InnerText);
                    }
                    break;
                case "StopTime":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/StopTime");
                        //Set Value
                        nodLoading.InnerText = ((TimeSpan)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = TimeSpan.Parse(docLoading.SelectSingleNode("Loading/StopTime").InnerText);
                    }
                    break;
                case "Duration":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/Duration");
                        //Set Value
                        nodLoading.InnerText = ((TimeSpan)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = TimeSpan.Parse(docLoading.SelectSingleNode("Loading/Duration").InnerText);
                    }
                    break;

                case "LadleNumber":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/LadleNumber");
                        //Set Value
                        nodLoading.InnerText = ((String)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = docLoading.SelectSingleNode("Loading/LadleNumber").InnerText;
                    }
                    break;
                case "LadleLoadingCount":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/LadleLoadingCount");
                        //Set Value
                        nodLoading.InnerText = ((int)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = int.Parse(docLoading.SelectSingleNode("Loading/LadleLoadingCount").InnerText);
                    }
                    break;
                case "EmptyWeightBefore":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/EmptyWeightBefore");
                        //Set Value
                        nodLoading.InnerText = ((int)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = int.Parse(docLoading.SelectSingleNode("Loading/EmptyWeightBefore").InnerText);
                    }
                    break;
                case "EmptyWeightAfter":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/EmptyWeightAfter");
                        //Set Value
                        nodLoading.InnerText = ((int)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = int.Parse(docLoading.SelectSingleNode("Loading/EmptyWeightAfter").InnerText);
                    }
                    break;
                case "FillWeight":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/FillWeight");
                        //Set Value
                        nodLoading.InnerText = ((int)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = int.Parse(docLoading.SelectSingleNode("Loading/FillWeight").InnerText);
                    }
                    break;
                case "MasidegiWeight":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/MasidegiWeight");
                        //Set Value
                        nodLoading.InnerText = ((int)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = int.Parse(docLoading.SelectSingleNode("Loading/MasidegiWeight").InnerText);
                    }
                    break;
                case "TapholeNumber":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/TapholeNumber");
                        //Set Value
                        nodLoading.InnerText = ((String)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = docLoading.SelectSingleNode("Loading/TapholeNumber").InnerText;
                    }
                    break;
                case "TapholePosition":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/TapholePosition");
                        //Set Value
                        nodLoading.InnerText = ((int)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = int.Parse(docLoading.SelectSingleNode("Loading/TapholePosition").InnerText);
                    }
                    break;
                case "GroupNumber":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/GroupNumber");
                        //Set Value
                        nodLoading.InnerText = ((String)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = docLoading.SelectSingleNode("Loading/GroupNumber").InnerText;
                    }
                    break;
                case "Shift":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/Shift");
                        //Set Value
                        nodLoading.InnerText = ((int)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = int.Parse(docLoading.SelectSingleNode("Loading/Shift").InnerText);
                    }
                    break;
                case "Loading":
                    Loading lodLoading = (Loading)strValueArg;
                    if (bolSetArg)
                    {
                        //Node: IsInsertedToDB
                        XmlNode nodIsInsertedToDB = docLoading.SelectSingleNode("Loading/j");
                        nodIsInsertedToDB.InnerText = (lodLoading.bolIsIntsertedPty).ToString();
                        //Node: IsLoading
                        XmlNode nodIsLoading = docLoading.SelectSingleNode("Loading/IsLoading");
                        nodIsLoading.InnerText = (lodLoading.bolIsLoadingPty).ToString();
                        //Node: nodIsLoadingCount
                        XmlNode nodLoadingCount = docLoading.SelectSingleNode("Loading/LoadingCount");
                        nodLoadingCount.InnerText = (lodLoading.intLoadingCountPty).ToString();
                        //Node: nodDate
                        XmlNode nodDate = docLoading.SelectSingleNode("Loading/Date");
                        nodDate.InnerText = (lodLoading.dtDatePty).ToString();
                        //Node: StartTime
                        XmlNode nodStartTime = docLoading.SelectSingleNode("Loading/StartTime");
                        nodStartTime.InnerText = (lodLoading.tsStartPty).ToString();
                        //Node: StopTime
                        XmlNode nodStopTime = docLoading.SelectSingleNode("Loading/StopTime");
                        nodStopTime.InnerText = (lodLoading.tsStopPty).ToString();
                        //Node: LadleNumber
                        XmlNode nodLadleNumber = docLoading.SelectSingleNode("Loading/LadleNumber");
                        nodLadleNumber.InnerText = (lodLoading.strLadleNumberPty).ToString();
                        //Node: LadleLoadingCount
                        XmlNode nodLadleLoadingCount = docLoading.SelectSingleNode("Loading/LadleLoadingCount");
                        nodLadleLoadingCount.InnerText = (lodLoading.intLadleLoadingCountPty).ToString();
                        //Node: EmptyWeightBefore
                        XmlNode nodEmptyWeightBefore = docLoading.SelectSingleNode("Loading/EmptyWeightAfter");
                        nodEmptyWeightBefore.InnerText = (lodLoading.intEmptyWeightBeforeLoadingPty).ToString();
                        //Node: EmptyWeightAfter
                        XmlNode nodEmptyWeightAfter = docLoading.SelectSingleNode("Loading/EmptyWeightBefore");
                        nodEmptyWeightAfter.InnerText = (lodLoading.intEmptyWeightAfterLoadingPty).ToString();
                        //Node: FillWeight
                        XmlNode nodFillWeight = docLoading.SelectSingleNode("Loading/FillWeight");
                        nodFillWeight.InnerText = (lodLoading.intFillWeightPty).ToString();
                        //Node: MasidegiWeight
                        XmlNode nodMasidegiWeight = docLoading.SelectSingleNode("Loading/MasidegiWeight");
                        nodMasidegiWeight.InnerText = (lodLoading.intFillWeightPty).ToString();
                        //Node: TapholeNumber
                        XmlNode nodTapholeNumber = docLoading.SelectSingleNode("Loading/TapholeNumber");
                        nodTapholeNumber.InnerText = (lodLoading.strTapholeNumber).ToString();
                        //Node: TapholePosition
                        XmlNode nodTapholePosition = docLoading.SelectSingleNode("Loading/TapholePosition");
                        nodTapholePosition.InnerText = (lodLoading.intTapholePositionPty).ToString();
                        //Node: GroupNumber
                        XmlNode nodGroupNumber = docLoading.SelectSingleNode("Loading/GroupNumber");
                        nodGroupNumber.InnerText = (lodLoading.strGroupNumberPty).ToString();
                        //Node: Shift
                        XmlNode nodShift = docLoading.SelectSingleNode("Loading/Shift");
                        nodShift.InnerText = ((int)lodLoading.shiShiftPty).ToString();

                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }

                    else
                    {
                        lodLoading.bolIsLoadingPty = Boolean.Parse(docLoading.SelectSingleNode("Loading/IsLoading").InnerText);
                        lodLoading.intLoadingCountPty = int.Parse(docLoading.SelectSingleNode("Loading/LoadingCount").InnerText);
                        lodLoading.dtDatePty = DateTime.Parse(docLoading.SelectSingleNode("Loading/Date").InnerText);
                        lodLoading.tsStartPty = TimeSpan.Parse(docLoading.SelectSingleNode("Loading/StartTime").InnerText);
                        lodLoading.tsStopPty = TimeSpan.Parse(docLoading.SelectSingleNode("Loading/StopTime").InnerText);
                        lodLoading.tsDurationPty = TimeSpan.Parse(docLoading.SelectSingleNode("Loading/Duration").InnerText);
                        lodLoading.strLadleNumberPty = docLoading.SelectSingleNode("Loading/LadleNumber").InnerText;
                        lodLoading.intLadleLoadingCountPty = int.Parse(docLoading.SelectSingleNode("Loading/LadleLoadingCount").InnerText);
                        lodLoading.intEmptyWeightBeforeLoadingPty = int.Parse(docLoading.SelectSingleNode("Loading/EmptyWeightBefore").InnerText);
                        lodLoading.intEmptyWeightAfterLoadingPty = int.Parse(docLoading.SelectSingleNode("Loading/EmptyWeightAfter").InnerText);
                        lodLoading.intFillWeightPty = int.Parse(docLoading.SelectSingleNode("Loading/FillWeight").InnerText);
                        lodLoading.intLadleMasidegiPty = int.Parse(docLoading.SelectSingleNode("Loading/MasidegiWeight").InnerText);
                        lodLoading.strTapholeNumberPty = docLoading.SelectSingleNode("Loading/TapholeNumber").InnerText;
                        lodLoading.intTapholePositionPty = int.Parse(docLoading.SelectSingleNode("Loading/TapholePosition").InnerText);
                        lodLoading.strGroupNumberPty = docLoading.SelectSingleNode("Loading/GroupNumber").InnerText;
                        lodLoading.shiShiftPty = (ShiftInfo.Shift)int.Parse(docLoading.SelectSingleNode("Loading/Shift").InnerText);
                    }

                    objValue = lodLoading;
                    break;
                case "Intialization":
                    if (bolSetArg)
                    {
                        //Node: IsIntsertedToDB
                        nodLoading = docLoading.SelectSingleNode("Loading/IsIntsertedToDB");
                        nodLoading.InnerText = "true";
                        //Node: IsLoading
                        nodLoading = docLoading.SelectSingleNode("Loading/IsLoading");
                        nodLoading.InnerText = "false";
                        //Node: LoadingCount
                        nodLoading = docLoading.SelectSingleNode("Loading/LoadingCount");
                        nodLoading.InnerText = "0";
                        //Node: Date
                        nodLoading = docLoading.SelectSingleNode("Loading/Date");
                        nodLoading.InnerText = "0001/01/01 00:00:00";
                        //Node: StartTime
                        nodLoading = docLoading.SelectSingleNode("Loading/StartTime");
                        nodLoading.InnerText = "00:00:00";
                        //Node: StopTime
                        nodLoading = docLoading.SelectSingleNode("Loading/StopTime");
                        nodLoading.InnerText = "00:00:00";
                        //Node: LadleNumber
                        nodLoading = docLoading.SelectSingleNode("Loading/LadleNumber");
                        nodLoading.InnerText = "0";
                        //Node: LadleLoadingCount
                        nodLoading = docLoading.SelectSingleNode("Loading/LadleLoadingCount");
                        nodLoading.InnerText = "0";
                        //Node: EmptyWeight
                        nodLoading = docLoading.SelectSingleNode("Loading/EmptyWeight");
                        nodLoading.InnerText = "0";
                        //Node: FillWeight
                        nodLoading = docLoading.SelectSingleNode("Loading/FillWeight");
                        nodLoading.InnerText = "0";
                        //Node: MasidegiWeight
                        nodLoading = docLoading.SelectSingleNode("Loading/MasidegiWeight");
                        nodLoading.InnerText = "0";
                        //Node: TapholeNumber
                        nodLoading = docLoading.SelectSingleNode("Loading/TapholeNumber");
                        nodLoading.InnerText = "0";
                        //Node: TapholePosition
                        nodLoading = docLoading.SelectSingleNode("Loading/TapholePosition");
                        nodLoading.InnerText = "0";
                        //Node: GroupNumber
                        nodLoading = docLoading.SelectSingleNode("Loading/GroupNumber");
                        nodLoading.InnerText = "0";
                        //Node: Shift
                        nodLoading = docLoading.SelectSingleNode("Loading/Shift");
                        nodLoading.InnerText = "0";

                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    break;
            }

            return objValue;
        }
        public static Object NextLoaingFromToXML(String strXMLFilePathArg, String strAttributeArg, Object strValueArg, Boolean bolSetArg)
        {
            Object objValue = null;

            //Declare And Instance XmlDocument
            XmlDocument docLoading = new XmlDocument();
            //Load XmlDocument
            docLoading.Load(strXMLFilePathArg);
            //Declare XmlNodeList
            XmlNode nodLoading;

            switch (strAttributeArg)
            {
                case "IsInsertedToCurrent":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/IsInsertedToCurrent");
                        //Set Value
                        nodLoading.InnerText = ((Boolean)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = Boolean.Parse(docLoading.SelectSingleNode("Loading/IsInsertedToCurrent").InnerText);
                    }
                    break;
                case "IsLoading":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/IsLoading");
                        //Set Value
                        nodLoading.InnerText = ((Boolean)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = Boolean.Parse(docLoading.SelectSingleNode("Loading/IsLoading").InnerText);
                    }
                    break;
                case "LoadingCount":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/LoadingCount");
                        //Set Value
                        nodLoading.InnerText = ((int)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = int.Parse(docLoading.SelectSingleNode("Loading/LoadingCount").InnerText);
                    }
                    break;
                case "Date":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/Date");
                        //Set Value
                        nodLoading.InnerText = ((DateTime)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = DateTime.Parse(docLoading.SelectSingleNode("Loading/Date").InnerText);
                    }
                    break;
                case "StartTime":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/StartTime");
                        //Set Value
                        nodLoading.InnerText = ((TimeSpan)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = TimeSpan.Parse(docLoading.SelectSingleNode("Loading/StartTime").InnerText);
                    }
                    break;
                case "StopTime":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/StopTime");
                        //Set Value
                        nodLoading.InnerText = ((TimeSpan)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = TimeSpan.Parse(docLoading.SelectSingleNode("Loading/StopTime").InnerText);
                    }
                    break;

                case "LadleNumber":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/LadleNumber");
                        //Set Value
                        nodLoading.InnerText = ((String)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = docLoading.SelectSingleNode("Loading/LadleNumber").InnerText;
                    }
                    break;
                case "LadleLoadingCount":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/LadleLoadingCount");
                        //Set Value
                        nodLoading.InnerText = ((int)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = int.Parse(docLoading.SelectSingleNode("Loading/LadleLoadingCount").InnerText);
                    }
                    break;
                case "EmptyWeight":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/EmptyWeight");
                        //Set Value
                        nodLoading.InnerText = ((int)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = int.Parse(docLoading.SelectSingleNode("Loading/EmptyWeight").InnerText);
                    }
                    break;
                case "FillWeight":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/FillWeight");
                        //Set Value
                        nodLoading.InnerText = ((int)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = int.Parse(docLoading.SelectSingleNode("Loading/FillWeight").InnerText);
                    }
                    break;
                case "MasidegiWeight":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/MasidegiWeight");
                        //Set Value
                        nodLoading.InnerText = ((int)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = int.Parse(docLoading.SelectSingleNode("Loading/MasidegiWeight").InnerText);
                    }
                    break;
                case "TapholeNumber":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/TapholeNumber");
                        //Set Value
                        nodLoading.InnerText = ((String)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = docLoading.SelectSingleNode("Loading/TapholeNumber").InnerText;
                    }
                    break;
                case "TapholePosition":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/TapholePosition");
                        //Set Value
                        nodLoading.InnerText = ((int)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = int.Parse(docLoading.SelectSingleNode("Loading/TapholePosition").InnerText);
                    }
                    break;
                case "GroupNumber":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/GroupNumber");
                        //Set Value
                        nodLoading.InnerText = ((String)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = docLoading.SelectSingleNode("Loading/GroupNumber").InnerText;
                    }
                    break;
                case "Shift":
                    if (bolSetArg)
                    {
                        //Select Nodes
                        nodLoading = docLoading.SelectSingleNode("Loading/Shift");
                        //Set Value
                        nodLoading.InnerText = ((int)strValueArg).ToString();
                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    else
                    {
                        objValue = int.Parse(docLoading.SelectSingleNode("Loading/Shift").InnerText);
                    }
                    break;
                case "Loading":
                    Loading lodLoading = new Loading();

                    if (bolSetArg)
                    {
                        //Node: IsInsertedToCurrent
                        XmlNode nodIsInsertedToDB = docLoading.SelectSingleNode("Loading/IsInsertedToCurrent");
                        nodIsInsertedToDB.InnerText = ((Boolean)strValueArg).ToString();
                        //Node: IsLoading
                        XmlNode nodIsLoading = docLoading.SelectSingleNode("Loading/IsLoading");
                        nodIsLoading.InnerText = ((Boolean)strValueArg).ToString();
                        //Node: nodIsLoadingCount
                        XmlNode nodLoadingCount = docLoading.SelectSingleNode("Loading/LoadingCount");
                        nodLoadingCount.InnerText = ((Boolean)strValueArg).ToString();
                        //Node: nodDate
                        XmlNode nodDate = docLoading.SelectSingleNode("Loading/Date");
                        nodDate.InnerText = ((Boolean)strValueArg).ToString();
                        //Node: StartTime
                        XmlNode nodStartTime = docLoading.SelectSingleNode("Loading/StartTime");
                        nodStartTime.InnerText = ((Boolean)strValueArg).ToString();
                        //Node: StopTime
                        XmlNode nodStopTime = docLoading.SelectSingleNode("Loading/StopTime");
                        nodStopTime.InnerText = ((Boolean)strValueArg).ToString();
                        //Node: LadleNumber
                        XmlNode nodLadleNumber = docLoading.SelectSingleNode("Loading/LadleNumber");
                        nodLadleNumber.InnerText = ((Boolean)strValueArg).ToString();
                        //Node: LadleLoadingCount
                        XmlNode nodLadleLoadingCount = docLoading.SelectSingleNode("Loading/LadleLoadingCount");
                        nodLadleLoadingCount.InnerText = ((Boolean)strValueArg).ToString();
                        //Node: EmptyWeight
                        XmlNode nodEmptyWeight = docLoading.SelectSingleNode("Loading/EmptyWeight");
                        nodEmptyWeight.InnerText = ((Boolean)strValueArg).ToString();
                        //Node: FillWeight
                        XmlNode nodFillWeight = docLoading.SelectSingleNode("Loading/FillWeight");
                        nodFillWeight.InnerText = ((Boolean)strValueArg).ToString();
                        //Node: MasidegiWeight
                        XmlNode nodMasidegiWeight = docLoading.SelectSingleNode("Loading/MasidegiWeight");
                        nodMasidegiWeight.InnerText = ((Boolean)strValueArg).ToString();
                        //Node: TapholeNumber
                        XmlNode nodTapholeNumber = docLoading.SelectSingleNode("Loading/TapholeNumber");
                        nodTapholeNumber.InnerText = ((Boolean)strValueArg).ToString();
                        //Node: TapholePosition
                        XmlNode nodTapholePosition = docLoading.SelectSingleNode("Loading/TapholePosition");
                        nodTapholePosition.InnerText = ((Boolean)strValueArg).ToString();
                        //Node: GroupNumber
                        XmlNode nodGroupNumber = docLoading.SelectSingleNode("Loading/GroupNumber");
                        nodGroupNumber.InnerText = ((Boolean)strValueArg).ToString();
                        //Node: Shift
                        XmlNode nodShift = docLoading.SelectSingleNode("Loading/Shift");
                        nodShift.InnerText = ((Boolean)strValueArg).ToString();

                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }

                    else
                    {
                        lodLoading.bolIsLoadingPty = Boolean.Parse(docLoading.SelectSingleNode("Loading/IsInsertedToCurrent").InnerText);
                        lodLoading.intLoadingCountPty = int.Parse(docLoading.SelectSingleNode("Loading/LoadingCount").InnerText);
                        lodLoading.dtDatePty = DateTime.Parse(docLoading.SelectSingleNode("Loading/Date").InnerText);
                        lodLoading.tsStartPty = TimeSpan.Parse(docLoading.SelectSingleNode("Loading/StartTime").InnerText);
                        lodLoading.tsStopPty = TimeSpan.Parse(docLoading.SelectSingleNode("Loading/StopTime").InnerText);
                        lodLoading.tsDurationPty = TimeSpan.Parse(docLoading.SelectSingleNode("Loading/Duration").InnerText);
                        lodLoading.strLadleNumberPty = docLoading.SelectSingleNode("Loading/LadleNumber").InnerText;
                        lodLoading.intLadleLoadingCountPty = int.Parse(docLoading.SelectSingleNode("Loading/LadleLoadingCount").InnerText);
                        lodLoading.intEmptyWeightBeforeLoadingPty = int.Parse(docLoading.SelectSingleNode("Loading/EmptyWeightBefore").InnerText);
                        lodLoading.intEmptyWeightAfterLoadingPty = int.Parse(docLoading.SelectSingleNode("Loading/EmptyWeightAfter").InnerText);
                        lodLoading.intFillWeightPty = int.Parse(docLoading.SelectSingleNode("Loading/FillWeight").InnerText);
                        lodLoading.intLadleMasidegiPty = int.Parse(docLoading.SelectSingleNode("Loading/MasidegiWeight").InnerText);
                        lodLoading.strTapholeNumberPty = docLoading.SelectSingleNode("Loading/TapholeNumber").InnerText;
                        lodLoading.intTapholePositionPty = int.Parse(docLoading.SelectSingleNode("Loading/TapholePosition").InnerText);
                        lodLoading.strGroupNumberPty = docLoading.SelectSingleNode("Loading/GroupNumber").InnerText;
                        lodLoading.shiShiftPty = (ShiftInfo.Shift)int.Parse(docLoading.SelectSingleNode("Loading/Shift").InnerText);
                    }

                    objValue = lodLoading;
                    break;
                case "Intialization":
                    if (bolSetArg)
                    {
                        //Node: IsIntsertedToDB
                        nodLoading = docLoading.SelectSingleNode("Loading/IsInsertedToCurrent");
                        nodLoading.InnerText = "true";
                        //Node: IsLoading
                        nodLoading = docLoading.SelectSingleNode("Loading/IsLoading");
                        nodLoading.InnerText = "false";
                        //Node: LoadingCount
                        nodLoading = docLoading.SelectSingleNode("Loading/LoadingCount");
                        nodLoading.InnerText = "0";
                        //Node: Date
                        nodLoading = docLoading.SelectSingleNode("Loading/Date");
                        nodLoading.InnerText = "0001/01/01 00:00:00";
                        //Node: StartTime
                        nodLoading = docLoading.SelectSingleNode("Loading/StartTime");
                        nodLoading.InnerText = "00:00:00";
                        //Node: StopTime
                        nodLoading = docLoading.SelectSingleNode("Loading/StopTime");
                        nodLoading.InnerText = "00:00:00";
                        //Node: LadleNumber
                        nodLoading = docLoading.SelectSingleNode("Loading/LadleNumber");
                        nodLoading.InnerText = "0";
                        //Node: LadleLoadingCount
                        nodLoading = docLoading.SelectSingleNode("Loading/LadleLoadingCount");
                        nodLoading.InnerText = "0";
                        //Node: EmptyWeight
                        nodLoading = docLoading.SelectSingleNode("Loading/EmptyWeight");
                        nodLoading.InnerText = "0";
                        //Node: FillWeight
                        nodLoading = docLoading.SelectSingleNode("Loading/FillWeight");
                        nodLoading.InnerText = "0";
                        //Node: MasidegiWeight
                        nodLoading = docLoading.SelectSingleNode("Loading/MasidegiWeight");
                        nodLoading.InnerText = "0";
                        //Node: TapholeNumber
                        nodLoading = docLoading.SelectSingleNode("Loading/TapholeNumber");
                        nodLoading.InnerText = "0";
                        //Node: TapholePosition
                        nodLoading = docLoading.SelectSingleNode("Loading/TapholePosition");
                        nodLoading.InnerText = "0";
                        //Node: GroupNumber
                        nodLoading = docLoading.SelectSingleNode("Loading/GroupNumber");
                        nodLoading.InnerText = "0";
                        //Node: Shift
                        nodLoading = docLoading.SelectSingleNode("Loading/Shift");
                        nodLoading.InnerText = "0";

                        //Save Xml file
                        docLoading.Save(strXMLFilePathArg);
                    }
                    break;
            }

            return objValue;
        }
        public static Loading GetLastLoadingFromDB(Connection cnConnection)
        {
            Loading lodLastLoading = new Loading();
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmPatilLoading = new SqlCommand("SELECT * FROM tabProductionMeltLoadings WHERE intID = (SELECT MAX(intID) FROM tabProductionMeltLoadings)", cnSqlConnection);

            cnSqlConnection.Open();
            SqlDataReader drPatilLoading = cmPatilLoading.ExecuteReader();
            while (drPatilLoading.Read())
            {
                lodLastLoading.intLoadingCountPty = (int)drPatilLoading["intLoadingCount"];
                lodLastLoading.dtDatePty = (DateTime)drPatilLoading["datDate"];
                lodLastLoading.tsStartPty = (TimeSpan)drPatilLoading["timStart"];
                lodLastLoading.tsStopPty = (TimeSpan)drPatilLoading["timStop"];
                lodLastLoading.strLadleNumberPty = (String)drPatilLoading["nvcLadleNumber"];
                lodLastLoading.intLadleLoadingCountPty = (int)drPatilLoading["intLadleLoadingCount"];
                lodLastLoading.intEmptyWeightBeforeLoadingPty = (int)drPatilLoading["intEmptyWeightBefore"];
                lodLastLoading.intEmptyWeightAfterLoadingPty = (int)drPatilLoading["intEmptyWeightAfter"];
                lodLastLoading.intFillWeightPty = (int)drPatilLoading["intFillWeight"];
                lodLastLoading.intLadleMasidegiPty = (int)drPatilLoading["intMasidegiWeight"];
                lodLastLoading.strTapholeNumberPty = (String)drPatilLoading["nvcTapholeNumber"];
                lodLastLoading.intTapholePositionPty = (int)drPatilLoading["intTapholePosition"];
                lodLastLoading.strGroupNumberPty = (String)drPatilLoading["nvcGroupNumber"];
                lodLastLoading.shiShiftPty = (ShiftInfo.Shift)((int)drPatilLoading["intShift"]);
            }
            drPatilLoading.Close();
            cnSqlConnection.Close();

            return lodLastLoading;
        }
        //Get Current Ladles
        public static String[] GetCurrentLadles(Connection cnConnection)
        {
            String[] strLadleNumbers;
            ArrayList alLadleNumbers = new ArrayList();

            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmTabLoadingLadles = new SqlCommand("SELECT * FROM TabLoadingLadles WHERE bitIsCurrent = 1", cnSqlConnection);

            cnSqlConnection.Open();
            SqlDataReader drTabLoadingLadles = cmTabLoadingLadles.ExecuteReader();
            while (drTabLoadingLadles.Read())
            {
                alLadleNumbers.Add(drTabLoadingLadles["nvcNumber"].ToString());
            }
            drTabLoadingLadles.Close();
            cnSqlConnection.Close();

            strLadleNumbers = new string[alLadleNumbers.Count];
            for (int i=0;i< alLadleNumbers.Count; ++i)
            {
                strLadleNumbers[i] = (String)alLadleNumbers[i];
            }
            

            return strLadleNumbers;
        }
        //Get Current Patils From XML File
        public static void SetCurrentLadle(Connection cnConnection, String strCurrentLadleArg)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmTabLoadingLadles = new SqlCommand("SELECT intServiceCount FROM TabLoadingLadles WHERE nvcNumber = " + strCurrentLadleArg, cnSqlConnection);

            cnSqlConnection.Open();
            int intServiceCountLoc = (int)cmTabLoadingLadles.ExecuteScalar();

            cmTabLoadingLadles = new SqlCommand("UPDATE TabLoadingLadles SET bitIsCurrent = 1, intServiceCount = " + 
                (intServiceCountLoc + 1).ToString() + " WHERE nvcNumber = " + strCurrentLadleArg.ToString() + "strCurrentLadleArg", cnSqlConnection);
            cmTabLoadingLadles.ExecuteNonQuery();
        }
        public static void SetInserviceLadle(Connection cnConnection, String strCurrentLadleArg)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);

            SqlCommand cmTabLoadingLadles = new SqlCommand("UPDATE TabLoadingLadles SET bitIsCurrent = 0 WHERE nvcNumber = " +
                strCurrentLadleArg.ToString() + "strCurrentLadleArg", cnSqlConnection);
            cmTabLoadingLadles.ExecuteNonQuery();

            cnSqlConnection.Close();
        }
        //Get Loading Count From XML File
        public static int GetLoadingCount(Connection cnConnection, DateTime datetime,
            DateTime[] StartTimes, String Xml_InsertLoadingInDB_Path)
        {
            //Persian Calendar For Get Persian Date Of Given Date.
            System.Globalization.PersianCalendar PersianCal =
                new System.Globalization.PersianCalendar();

            //Get Inserted Loading
            Loading InsertedLoading = null;
            //InsertLoadingInDB.GetLoading(Xml_InsertLoadingInDB_Path);

            //Month Of Given Date
            int GivenMonth = 0;
            //PersianCal.GetMonth(NobateKaryTreeStageTowDay.GetDateTimeIFI(datetime, StartTimes[0]));

            //Loading Number
            int intLoadingCountLoc = 0;

            if (!InsertedLoading.bolIsIntserted)
            {
                #region If Loading Isnt Inserted

                //Month Of Given Date
                int InsertedMonth = 0;
                    //PersianCal.GetMonth(NobateKaryTreeStageTowDay.GetDateTimeIFI(InsertedLoading.dtDatePty, StartTimes[0]));

                if (InsertedMonth == GivenMonth)
                {
                    intLoadingCountLoc = InsertedLoading.intLoadingCountPty;
                    ++intLoadingCountLoc;
                }
                else
                {
                    ++intLoadingCountLoc;
                }

                #endregion If Loading Isnt Inserted
            }
            else
            {
                //Declare And Instance Com_Sel_Tapping
                SqlCommand cmPatilLoading = new SqlCommand();
                SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
                cmPatilLoading.Connection = cnSqlConnection;
                cmPatilLoading.CommandText =
                    "SELECT CouLoad_PL,Date_PL FROM Tab_PatilLoading WHERE ID_PL=(SELECT MAX(ID_PL) FROM Tab_PatilLoading)";

                //Open Connection
                cmPatilLoading.Connection.Open();

                //Create And Instance SqlDataReader
                SqlDataReader drPatilLoading = cmPatilLoading.ExecuteReader();

                //Get Info
                drPatilLoading.Read();
                if (drPatilLoading.HasRows)
                {
                    DateTime DT_LoadingDate = (DateTime)drPatilLoading.GetDateTime(drPatilLoading.GetOrdinal("Date_PL"));
                    Byte LastMounth = (Byte)PersianCal.GetMonth(DT_LoadingDate);

                    //
                    if (LastMounth == GivenMonth)
                    {
                        intLoadingCountLoc = UInt16.Parse(drPatilLoading.GetSqlInt16(drPatilLoading.GetOrdinal("CouLoad_PL")).ToString());
                    }
                }
                //Pluse Loading Number
                intLoadingCountLoc++;

                //Close Connection
                cmPatilLoading.Connection.Close();






                //    #region If Loading Is Inserted

                //    switch (cnConnection.Type)
                //    {
                //        case Connection.DBTypes.OleDB:
                //            #region OleDB

                //            //Declare And Instance Com_Sel_Tapping
                //            OleDbCommand Com_Sel_Tapping = new OleDbCommand();
                //            Com_Sel_Tapping.Connection = cnConnection.OLE;
                //            Com_Sel_Tapping.CommandText =
                //                "SELECT CouLoad_PL,Date_PL FROM Tab_PatilLoading WHERE ID_PL=(SELECT MAX(ID_PL) FROM Tab_PatilLoading)";

                //            //Open Connection
                //            Com_Sel_Tapping.Connection.Open();

                //            //Create And Instance SqlDataReader
                //            OleDbDataReader DR_Tapping = Com_Sel_Tapping.ExecuteReader();

                //            //Get Info
                //            DR_Tapping.Read();
                //            if (DR_Tapping.HasRows)
                //            {
                //                DateTime DT_LoadingDate = (DateTime)DR_Tapping.GetDateTime(DR_Tapping.GetOrdinal("Date_PL"));
                //                Byte LastMounth = (Byte)PersianCal.GetMonth(DT_LoadingDate);

                //                //
                //                if (LastMounth == GivenMonth)
                //                {
                //                    LoadingNumber = (UInt16)DR_Tapping.GetInt16(DR_Tapping.GetOrdinal("CouLoad_PL"));
                //                }
                //            }
                //            //Pluse Loading Number
                //            LoadingNumber++;

                //            //Close Connection
                //            Com_Sel_Tapping.Connection.Close();

                //            //
                //            break;

                //        #endregion OleDB
                //        case Connection.DBTypes.SQLServer:
                //            #region SqlDB

                //            //Declare And Instance Com_Sel_Tapping
                //            SqlCommand SqlCom_Sel_Tapping = new SqlCommand();
                //            SqlCom_Sel_Tapping.Connection = cnConnection.SQL;
                //            SqlCom_Sel_Tapping.CommandText =
                //                "SELECT CouLoad_PL,Date_PL FROM Tab_PatilLoading WHERE ID_PL=(SELECT MAX(ID_PL) FROM Tab_PatilLoading)";

                //            //Open Connection
                //            SqlCom_Sel_Tapping.Connection.Open();

                //            //Create And Instance SqlDataReader
                //            SqlDataReader SqlDR_Tapping = SqlCom_Sel_Tapping.ExecuteReader();

                //            //Get Info
                //            SqlDR_Tapping.Read();
                //            if (SqlDR_Tapping.HasRows)
                //            {
                //                DateTime DT_LoadingDate = (DateTime)SqlDR_Tapping.GetDateTime(SqlDR_Tapping.GetOrdinal("Date_PL"));
                //                Byte LastMounth = (Byte)PersianCal.GetMonth(DT_LoadingDate);

                //                //
                //                if (LastMounth == GivenMonth)
                //                {
                //                    LoadingNumber = UInt16.Parse(SqlDR_Tapping.GetSqlInt16(SqlDR_Tapping.GetOrdinal("CouLoad_PL")).ToString());
                //                }
                //            }
                //            //Pluse Loading Number
                //            LoadingNumber++;

                //            //Close Connection
                //            SqlCom_Sel_Tapping.Connection.Close();

                //            //
                //            break;

                //            #endregion SqlDB
                //    }

                //    #endregion If Loading Is Inserted
                //}
            }
            //Return Value
            return intLoadingCountLoc;
        }
        //Get Empty Weight Of Patil.
        public void GetLadleEmptyWeightFromDB(Connection cnConnection)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmTabLoadingLadles = new SqlCommand(
                "SELECT intEmptyWeight FROM TabLoadingLadles WHERE nvcNumber = '" + this.strLadleNumber + "'", cnSqlConnection);

            cnSqlConnection.Open();
            this.intEmptyWeightBeforeLoadingPty = (int)cmTabLoadingLadles.ExecuteScalar();
            cnSqlConnection.Close();
        }
        //Set Empty Weight Of Patil
        public void SetLadleEmptyWeightToDB(Connection cnConnection)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmTabLoadingLadles = new SqlCommand(
                "UPDATE TabLoadingLadles intEmptyWeight = " + this.intEmptyWeightBeforeLoadingPty.ToString() + " WHERE nvcNumber = '" + this.strLadleNumber + "'", cnSqlConnection);

            cnSqlConnection.Open();
            cmTabLoadingLadles.ExecuteNonQuery();
            cnSqlConnection.Close();
        }
        //Get Counter Of Patil
        public void GetLadleLoadingCountFromDB(Connection cnConnection)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmTabLoadingLadles = new SqlCommand(
                "SELECT intLoadingCount FROM TabLoadingLadles WHERE nvcNumber = '" + this.strLadleNumber + "'", cnSqlConnection);

            cnSqlConnection.Open();
            this.intLadleLoadingCountPty = (Byte)cmTabLoadingLadles.ExecuteScalar();
            cnSqlConnection.Close();
        }
        //Set Counter Of Patil
        public void SetLadleLoadingCountToDB(Connection cnConnection)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmTabLoadingLadles = new SqlCommand(
                "UPDATE TabLoadingLadles intLoadingCount = " + this.intLadleLoadingCountPty.ToString() + " WHERE nvcNumber = '" + this.strLadleNumber + "'", cnSqlConnection);

            cnSqlConnection.Open();
            cmTabLoadingLadles.ExecuteNonQuery();
            cnSqlConnection.Close();
        }
        public int NextLoadingCount(DateTime dtIntened)
        {
            if (dtIntened.Month == this.dtDatePty.Month)
            {
                this.intLadleLoadingCountPty += 1;
            }
            if (dtIntened.Month > this.dtDatePty.Month)
            {
                this.intLadleLoadingCountPty = 1;
            }

            return this.intLadleLoadingCountPty;
        }
        public void Insert(Connection cnConnection)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmTabProductionMeltLoadings = new SqlCommand();
            cmTabProductionMeltLoadings.Connection = cnSqlConnection;
            cmTabProductionMeltLoadings.CommandText = 
                @"INSERT INTO TabProductionMeltLoadings (datDate, timStart, timStop, intLoadingCount, nvcLadleNumber,intLadleLoadingCount,nvcTapholeNumber" +
                ",intTapholePosition,nvcGroupNumber,nvcShift,intMasidegiWeight,intEmptyWeight,intFillWeight) VALUES (" +
                this.dtDatePty.Date.ToString() + "," +
                this.tsStartPty.ToString() + "," +
                this.tsStopPty.ToString() + "," +
                this.intLoadingCountPty.ToString() + "," +
                this.strLadleNumberPty + "," +
                this.intLadleLoadingCountPty.ToString() + "," +
                this.strTapholeNumberPty + "," +
                this.intTapholePositionPty.ToString() + "," +
                this.strGroupNumberPty.ToString() + "," +
                ((int)this.shiShiftPty).ToString() + "," +
                this.intLadleMasidegiPty.ToString() + "," +
                this.intEmptyWeightBeforeLoadingPty.ToString() + "," +
                this.intFillWeightPty.ToString() + ")";
            cnSqlConnection.Open();
            cmTabProductionMeltLoadings.ExecuteNonQuery();
            cnSqlConnection.Close();
        }
    }
}
