using Baran.Ferroalloy.Automation.SqlDataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Maintenance
{
    public class Property
    {
        public int intID;
        public string strName;
        public string strCode;
        public string strCategory;

        public Property()
        {
            this.intID = 0;
            this.strName = "";
            this.strCode = "";
            this.strCategory = "";
        }

        public static Property[] GetProperties(Connection cnConnection)
        {
            Property[] prProperties;
            int intRowsCount = 0;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffStores = new SqlCommand("SELECT * FROM tabProperties ORDER BY nvcName", scConnection);

            scConnection.Open();
            SqlDataReader drProperties = cmStuffStores.ExecuteReader();
            while (drProperties.Read())
            {
                ++intRowsCount;
            }
            drProperties.Close();

            prProperties = new Property[intRowsCount];
            drProperties = cmStuffStores.ExecuteReader();
            intRowsCount = 0;
            while (drProperties.Read())
            {
                prProperties[intRowsCount] = new Property();
                prProperties[intRowsCount].strName = drProperties["nvcName"].ToString();
                prProperties[intRowsCount].strCode = drProperties["nvcCode"].ToString();
                ++intRowsCount;
            }

            return prProperties;
        }
        public static Property[] GetProperties(Connection cnConnection,int intCategoryArg)
        {
            Property[] prProperties;
            int intRowsCount = 0;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmProperties = new SqlCommand();

            cmProperties.Connection = scConnection;
            cmProperties.CommandText = String.Format("SELECT * FROM tabProperties WHERE intCategory={0} ORDER BY nvcName'", intCategoryArg);

            scConnection.Open();
            SqlDataReader drProperties = cmProperties.ExecuteReader();
            if (drProperties.Read())
            {
                ++intRowsCount;
            }
            drProperties.Close();

            prProperties = new Property[intRowsCount];
            drProperties = cmProperties.ExecuteReader();
            intRowsCount = 0;
            while (drProperties.Read())
            {
                prProperties[intRowsCount] = new Property();
                prProperties[intRowsCount].strName = drProperties["nvcName"].ToString();
                prProperties[intRowsCount].strCode = drProperties["nvcCode"].ToString();
                ++intRowsCount;
            }

            return prProperties;
        }
        public static String GetCodeByName(Connection cnConnection, String strNameArg)
        {
            String strCodeLoc = "";

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffStores = new SqlCommand("SELECT * FROM tabProperties WHERE nvcName =N'" + strNameArg + "' ORDER BY nvcName", scConnection);

            scConnection.Open();
            SqlDataReader drStuffStores = cmStuffStores.ExecuteReader();

            while (drStuffStores.Read())
            {
                strCodeLoc = drStuffStores["nvcCode"].ToString();
            }

            drStuffStores.Close();
            scConnection.Close();

            return strCodeLoc;
        }
        public static String GetNameByCode(Connection cnConnection, String strCodeArg)
        {
            String strNameLoc = "";

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffStores = new SqlCommand("SELECT * FROM tabProperties WHERE nvcCode ='" + strCodeArg + "' ORDER BY nvcName", scConnection);

            scConnection.Open();
            SqlDataReader drStuffStores = cmStuffStores.ExecuteReader();

            while (drStuffStores.Read())
            {
                strNameLoc = drStuffStores["nvcName"].ToString();
            }

            drStuffStores.Close();
            scConnection.Close();

            return strNameLoc;
        }

    }
}
