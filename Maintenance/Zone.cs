using Baran.Ferroalloy.Automation.SqlDataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Maintenance
{
    public class Zone
    {
        private Int16 intID;
        private String strName;
        private String strCode;
        private String strTip;

        public Int16 intIDPty
        {
            get
            {
                return this.intID;
            }
            set
            {
                this.intID = value;
            }
        }
        public String strNamePty
        {
            get
            {
                return this.strName;
            }
            set
            {
                this.strName = value;
            }
        }
        public String strCodePty
        {
            get
            {
                return this.strCode;
            }
            set
            {
                this.strCode = value;
            }
        }
        public String strTipPty
        {
            get
            {
                return this.strTip;
            }
            set
            {
                this.strTip = value;
            }
        }
        public Zone()
        {

        }

        public static Zone[] GetZones(Connection cnConnection)
        {
            Zone[] ctCategories;
            Int16 intRowsCount = 0;

            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmCommand = new SqlCommand("SELECT * FROM tabZones", cnSqlConnection);

            cnSqlConnection.Open();
            SqlDataReader drDataReader = cmCommand.ExecuteReader();
            while (drDataReader.Read())
            {
                ++intRowsCount;
            }
            drDataReader.Close();

            ctCategories = new Zone[intRowsCount];
            drDataReader = cmCommand.ExecuteReader();
            intRowsCount = 0;
            while (drDataReader.Read())
            {
                ctCategories[intRowsCount] = new Zone();
                ctCategories[intRowsCount].strNamePty = drDataReader["nvcName"].ToString();
                ctCategories[intRowsCount].strCodePty = drDataReader["nvcCode"].ToString();
                ++intRowsCount;
            }

            return ctCategories;
        }
        public static String GetZoneCode(Connection cnConnection, String strCatagoryName)
        {
            String strCatagoryCodeLoc = "";

            SqlConnection cnPart = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmPart = new SqlCommand("SELECT * FROM tabZones WHERE nvcName =N'" + strCatagoryName + "'", cnPart);
            //MessageBox.Show(cmPart.CommandText);
            cnPart.Open();
            SqlDataReader drPart = cmPart.ExecuteReader();

            while (drPart.Read())
            {
                strCatagoryCodeLoc = drPart["nvcCode"].ToString();
            }

            drPart.Close();
            cnPart.Close();

            return strCatagoryCodeLoc;
        }
        public static String GetZoneName(Connection cnConnection, String strCatagoryCode)
        {
            String strCatagoryNameLoc = "";

            SqlConnection cnPart = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmPart = new SqlCommand("SELECT * FROM tabZones WHERE nvcCode =N'" + strCatagoryCode + "'", cnPart);
            //MessageBox.Show(cmPart.CommandText);
            cnPart.Open();
            SqlDataReader drPart = cmPart.ExecuteReader();

            while (drPart.Read())
            {
                strCatagoryNameLoc = drPart["nvcName"].ToString();
            }

            drPart.Close();
            cnPart.Close();

            return strCatagoryNameLoc;
        }
    }
}
