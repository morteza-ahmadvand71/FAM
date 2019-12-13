using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Office;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Baran.Ferroalloy.Management
{
    public class FamSetting
    {
        private ShiftInfo.ShiftType stMaintenanceFurnaceShifttype;
        private DateTime dtMaintenanceFurnaceShiftOrgin;
        private ShiftInfo.ShiftType stProductionFurnaceShifttype;
        private DateTime dtProductionFurnaceDateOrgin;
        private String strEquipPicsPath;
        public string strInvoiceImagesPath;
        private int intTapholeCount;
        private int intLadleCount;
        private String[] strLoadingScaleSerialPortRS232;
        public String strXmlPath;
        public string strAppVersion;

        public struct CoInformation
        {
            public int intID;
            public string strName;
            public string strCoType;
            public DateTime dtRegister;
            public string strRegisterCode;
            public string strCoID;
            public string strAddress;
            public string strPostalCode;
            public string strTell;
            public string strFax;
            public string strTaxID;
            public string strProvince;
            public string strCity;
            public string strWebSite;

        }

        public ShiftInfo.ShiftType stMaintenanceFurnaceShifttypePty
        {
            get
            {
                return this.stMaintenanceFurnaceShifttype;
            }
            set
            {
                this.stMaintenanceFurnaceShifttype = value;
            }
        }
        public DateTime dtMaintenanceFurnaceShiftOrginPty
        {
            get
            {
                return this.dtMaintenanceFurnaceShiftOrgin;
            }
            set
            {
                this.dtMaintenanceFurnaceShiftOrgin = value;
            }
        }
        public ShiftInfo.ShiftType stProductionFurnaceShifttypePty
        {
            get
            {
                return this.stProductionFurnaceShifttype;
            }
            set
            {
                this.stProductionFurnaceShifttype = value;
            }
        }
        public DateTime dtProductionFurnaceDateOrginPty
        {
            get
            {
                return this.dtProductionFurnaceDateOrgin;
            }
            set
            {
                this.dtProductionFurnaceDateOrgin = value;
            }
        }
        public String strEquipPicsPathPty
        {
            get
            {
                return this.strEquipPicsPath;
            }
            set
            {
                this.strEquipPicsPath = value;
            }
        }
        public int intTapholeCountPty
        {
            get
            {
                return this.intTapholeCount;
            }
            set
            {
                this.intTapholeCount = value;
            }
        }
        public int intLadleCountPty
        {
            get
            {
                return this.intLadleCount;
            }
            set
            {
                this.intLadleCount = value;
            }
        }
        public String[] strLoadingScaleSerialPortRS232Pty
        {
            get
            {
                return this.strLoadingScaleSerialPortRS232;
            }
            set
            {
                this.strLoadingScaleSerialPortRS232 = value;
            }
        }

        public FamSetting()
        {
            this.stMaintenanceFurnaceShifttypePty = new ShiftInfo.ShiftType();
            this.dtMaintenanceFurnaceShiftOrginPty = new DateTime();
            this.stProductionFurnaceShifttypePty = new ShiftInfo.ShiftType();
            this.dtProductionFurnaceDateOrginPty = new DateTime();
            this.strEquipPicsPathPty = "";
            this.strInvoiceImagesPath = "";
            this.intTapholeCountPty = 0;
            this.intLadleCountPty = 0;
            this.strLoadingScaleSerialPortRS232Pty = new string[1];
            this.strXmlPath = "";
            this.strAppVersion = "";
           
        }
        public FamSetting(Connection cnConnection,string strXmlPathArg)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmSqlCommand = new SqlCommand("SELECT * FROM tabFamSettings",cnSqlConnection);

            cnSqlConnection.Open();
            SqlDataReader drFamSettings = cmSqlCommand.ExecuteReader();
            while (drFamSettings.Read())
            {
                this.stMaintenanceFurnaceShifttypePty = (ShiftInfo.ShiftType)drFamSettings["intMaintenanceFurnaceShifttype"];
                this.dtMaintenanceFurnaceShiftOrginPty = (DateTime)drFamSettings["datMaintenanceFurnaceDateOrgin"];
                this.stProductionFurnaceShifttypePty = (ShiftInfo.ShiftType)drFamSettings["intProductionFurnaceShifttype"];
                this.dtProductionFurnaceDateOrginPty = (DateTime)drFamSettings["datProductionFurnaceDateOrgin"];
                this.strEquipPicsPathPty = drFamSettings["nvcEquipPicsPath"].ToString();
                this.strInvoiceImagesPath = drFamSettings["nvcInvoiceImagesPath"].ToString();
                this.intTapholeCountPty = (Byte)drFamSettings["tinTapholeCount"];
                this.intLadleCountPty = (Byte)drFamSettings["tinLadleCount"];
                this.strLoadingScaleSerialPortRS232Pty = drFamSettings["nvcLoadingSerialPortRS232"].ToString().Split('-');
                this.strXmlPath = strXmlPathArg;
                this.strAppVersion = "";
            }

            drFamSettings.Close();
            cnSqlConnection.Close();
        }

        public static string GetLastUserName(string strXmlFilePath)
        {
            string strLastUserName;

            XmlDocument xdSettings = new XmlDocument();
            xdSettings.Load(strXmlFilePath);

            XmlNode xnLastUserName = xdSettings.SelectSingleNode("/App/DataBase/Login");
            strLastUserName = xnLastUserName.Attributes["LastUserName"].Value;

            return strLastUserName;
        }

        public static void SetLastUserName(string strXmlFilePath,string strLastUserNameArg)
        {
            XmlDocument xdSettings = new XmlDocument();
            xdSettings.Load(strXmlFilePath);

            XmlNode xnLastUserName = xdSettings.SelectSingleNode("/App/DataBase/Login");
            xnLastUserName.Attributes["LastUserName"].Value = strLastUserNameArg;

            xdSettings.Save(strXmlFilePath);
        }

        public static bool GetSaveUserName(string strXmlFilePath)
        {
            bool bolSaveUserName;

            XmlDocument xdSettings = new XmlDocument();
            xdSettings.Load(strXmlFilePath);

            XmlNode xnLastUserName = xdSettings.SelectSingleNode("/App/DataBase/Login");
            bolSaveUserName = bool.Parse(xnLastUserName.Attributes["SaveUserName"].Value);

             return bolSaveUserName;
        }

        public static void SetSaveUserName(string strXmlFilePath,bool bolSaveUserNameArg)
        {
            XmlDocument xdSettings = new XmlDocument();
            xdSettings.Load(strXmlFilePath);

            XmlNode xnLastUserName = xdSettings.SelectSingleNode("/App/DataBase/Login");
            xnLastUserName.Attributes["SaveUserName"].Value = bolSaveUserNameArg.ToString();

            xdSettings.Save(strXmlFilePath);
        }

        public static CoInformation GetCoInformation(Connection cnConnection)
        {
            CoInformation ciResultLoc = new CoInformation();

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmCoInformation = new SqlCommand();

            cmCoInformation.Connection = scConnection;
            cmCoInformation.CommandText = "SELECT * FROM tabCoInformation";

            scConnection.Open();
            SqlDataReader drCoInformation = cmCoInformation.ExecuteReader();

            if (drCoInformation.Read())
            {
                ciResultLoc.intID = (int)drCoInformation["intID"];
                ciResultLoc.strName = drCoInformation["nvcName"].ToString();
                ciResultLoc.strCoType = drCoInformation["nvcCoType"].ToString();
                ciResultLoc.dtRegister = (DateTime)drCoInformation["datRegister"];
                ciResultLoc.strRegisterCode = drCoInformation["nvcRegisterCode"].ToString();
                ciResultLoc.strCoID = drCoInformation["nvcCoID"].ToString();
                ciResultLoc.strAddress = drCoInformation["nvcAddress"].ToString();
                ciResultLoc.strPostalCode = drCoInformation["nvcPostalCode"].ToString();
                ciResultLoc.strTell = drCoInformation["nvcTell"].ToString();
                ciResultLoc.strFax = drCoInformation["nvcFax"].ToString();
                ciResultLoc.strTaxID = drCoInformation["nvcTaxID"].ToString();
                ciResultLoc.strProvince = drCoInformation["nvcProvince"].ToString();
                ciResultLoc.strCity = drCoInformation["nvcCity"].ToString();
                ciResultLoc.strWebSite = drCoInformation["nvcWebSite"].ToString();
            }

            drCoInformation.Close();
            scConnection.Close();

            return ciResultLoc;
        }

        public static bool SetCoInformation(Connection cnConnection, CoInformation ciResultArg)
        {
            bool bolResultLoc = false;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmCoInformation = new SqlCommand();

            cmCoInformation.Connection = scConnection;
            cmCoInformation.CommandText = "SELECT intID FROM tabCoInformation";

            scConnection.Open();
            SqlDataReader drCoInformation = cmCoInformation.ExecuteReader();

            if(drCoInformation.Read())
            {
                cmCoInformation.CommandText = String.Format(
                "UPDATE tabCoInformation SET nvcName=N'{0}', nvcCoType=N'{1}',datRegister='{2}-{3}-{4}',nvcRegisterCode='{5}',nvcCoID='{6}'," +
                "nvcAddress=N'{7}',nvcPostalCode='{8}',nvcTell='{9}',nvcFax='{10}',nvcTaxID={11}, nvcProvince='{12}', nvcCity='{13}', nvcWebSite='{14}'",
                ciResultArg.strName, ciResultArg.strCoType, ciResultArg.dtRegister.Year, ciResultArg.dtRegister.Month, ciResultArg.dtRegister.Day,
                ciResultArg.strRegisterCode, ciResultArg.strCoID, ciResultArg.strAddress, ciResultArg.strPostalCode, ciResultArg.strTell, ciResultArg.strFax,
                ciResultArg.strTaxID, ciResultArg.strProvince, ciResultArg.strCity, ciResultArg.strWebSite);
            }
            else
            {
                cmCoInformation.CommandText = String.Format(
                    "INSERT INTO tabCoInformation (nvcName,nvcCoType,datRegister,nvcRegisterCode,nvcCoID,nvcAddress,nvcPostalCode,nvcTell,nvcFax,nvcTaxID,nvcProvince,nvcCity,nvcWebSite)" +
                    " VALUES (N'{0}',N'{1}','{2}-{3}-{4}','{5}','{6}',N'{7}','{8}','{9}','{10}',{11},'{12}','{13}','{14}')", ciResultArg.strName, ciResultArg.strCoType, ciResultArg.dtRegister.Year,
                    ciResultArg.dtRegister.Month, ciResultArg.dtRegister.Day, ciResultArg.strRegisterCode, ciResultArg.strCoID, ciResultArg.strAddress,
                    ciResultArg.strPostalCode, ciResultArg.strTell, ciResultArg.strFax, ciResultArg.strTaxID, ciResultArg.strProvince, ciResultArg.strCity, ciResultArg.strWebSite);
            }

            drCoInformation.Close();

            if (cmCoInformation.ExecuteNonQuery() >= 1)
            {
                bolResultLoc = true;
            }
            else
            {
                bolResultLoc = false;
            }
            scConnection.Close();

            return bolResultLoc;
        }
    }
}
