using Baran.Ferroalloy.Automation.SqlDataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Maintenance
{
    public class StuffProperty
    {
        public int intID;
        public bool bolSelect;
        public string strStoreCode;
        public string strProperty;

        public StuffProperty()
        {
            this.intID = 0;
            this.bolSelect = false;
            this.strStoreCode = "";
            this.strProperty = "";
        }

        public static StuffProperty[] GetStuffProperties(Connection cnConnection,string strStoreCode)
        {
            StuffProperty[] spStuffProperties;
            Int16 intRowsCount = 0;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffStores = new SqlCommand();
            cmStuffStores.Connection = scConnection;
            cmStuffStores.CommandText = "SELECT * FROM tabStuffProperties WHERE nvcStoreCode='" + strStoreCode + "' ORDER BY nvcProperty";

            scConnection.Open();
            SqlDataReader drDataReader = cmStuffStores.ExecuteReader();
            while (drDataReader.Read())
            {
                ++intRowsCount;
            }
            drDataReader.Close();

            spStuffProperties = new StuffProperty[intRowsCount];
            drDataReader = cmStuffStores.ExecuteReader();
            intRowsCount = 0;
            while (drDataReader.Read())
            {
                spStuffProperties[intRowsCount] = new StuffProperty();
                spStuffProperties[intRowsCount].intID = (int)drDataReader["intID"];
                spStuffProperties[intRowsCount].strStoreCode = drDataReader["nvcStoreCode"].ToString();
                spStuffProperties[intRowsCount].strProperty = drDataReader["nvcProperty"].ToString();
                ++intRowsCount;
            }

            return spStuffProperties;
        }
        public void Insert(Connection cnConnection)
        {
            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffProperties = new SqlCommand();
            cmStuffProperties.Connection = scConnection;
            cmStuffProperties.CommandText = @"INSERT INTO tabStuffProperties (bitSelect, nvcStoreCode, nvcProperty) VALUES (" +
                "0,'" +
                this.strStoreCode + "','" +
                this.strProperty + "')";

            scConnection.Open();
            cmStuffProperties.ExecuteNonQuery();
            scConnection.Close();
        }

        public  void Delete(Connection cnConnection)
        {
            SqlConnection scSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffProperties = new SqlCommand();
            cmStuffProperties.Connection = scSqlConnection;
            cmStuffProperties.CommandText = @"DELETE FROM tabStuffProperties WHERE intID=" + this.intID.ToString();
            scSqlConnection.Open();

            cmStuffProperties.ExecuteNonQuery();

            scSqlConnection.Close();
        }
    }
}
