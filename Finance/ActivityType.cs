using Baran.Ferroalloy.Automation.SqlDataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Finance
{
    public class ActivityType
    {
        public int intID;
        public String strName;
        public String strCode;
        public String strTip;

      
        public ActivityType()
        {
            this.intID = 0;
            this.strName = "";
            this.strCode = "";
            this.strTip = "";
        }

        public static ActivityType[] GetActivityTypes(Connection cnConnection)
        {
            ActivityType[] atActivityTypes;
            Int16 intRowsCount = 0;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmActivityTypes = new SqlCommand("SELECT * FROM tabActivityTypes", scConnection);

            scConnection.Open();
            SqlDataReader drActivityTypes = cmActivityTypes.ExecuteReader();
            while (drActivityTypes.Read())
            {
                ++intRowsCount;
            }
            drActivityTypes.Close();

            atActivityTypes = new ActivityType[intRowsCount];
            drActivityTypes = cmActivityTypes.ExecuteReader();
            intRowsCount = 0;
            while (drActivityTypes.Read())
            {
                atActivityTypes[intRowsCount] = new ActivityType();
                atActivityTypes[intRowsCount].strName = drActivityTypes["nvcName"].ToString();
                atActivityTypes[intRowsCount].strCode = drActivityTypes["nvcCode"].ToString();
                ++intRowsCount;
            }

            return atActivityTypes;
        }
        public static String GetCodeByName(Connection cnConnection, String strName)
        {
            String strCodeLoc = "";

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmActivityTypes = new SqlCommand("SELECT * FROM tabActivityTypes WHERE nvcName =N'" + strName + "'", scConnection);
           
            scConnection.Open();
            SqlDataReader drActivityTypes = cmActivityTypes.ExecuteReader();

            while (drActivityTypes.Read())
            {
                strCodeLoc = drActivityTypes["nvcCode"].ToString();
            }

            drActivityTypes.Close();
            scConnection.Close();

            return strCodeLoc;
        }
        public static String GetNameByCode(Connection cnConnection, String strCodeArg)
        {
            String strNameLoc = "";

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmActivityTypes = new SqlCommand("SELECT * FROM tabActivityTypes WHERE nvcCode =N'" + strCodeArg + "'", scConnection);
           
            scConnection.Open();
            SqlDataReader drActivityTypes = cmActivityTypes.ExecuteReader();

            while (drActivityTypes.Read())
            {
                strNameLoc = drActivityTypes["nvcName"].ToString();
            }

            drActivityTypes.Close();
            scConnection.Close();

            return strNameLoc;
        }
    }
}
