using Baran.Ferroalloy.Automation.SqlDataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Store
{
    public class StoreGetOutItem
    {
        public int intID;
        public bool bitSelect;
        public int intStoreGetOutNumber;
        public string  strStuffStoreCode;
        public double dobStuffAmount;
        public string strEquipTag;
        public int intTechnicalActionType;

        public StoreGetOutItem()
        {
            this.intID = 0;
            this.bitSelect = false;
            this.intStoreGetOutNumber = 0;
            this.strStuffStoreCode = "";
            this.dobStuffAmount = 0;
            this.strEquipTag = "";
            this.intTechnicalActionType = 0;
        }

        public static DataTable GetStoreGetOutItemsBySGONumber(Connection cnConnection,int intStoreGetOutNumberArg)
        {
            DataTable dtStoreGetOutItems = new DataTable();

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStoreGetOutItems = new SqlCommand();

            cmStoreGetOutItems.Connection = scConnection;
            cmStoreGetOutItems.CommandText = string.Format("SELECT * FROM tabStoreGetOutItems WHERE intStoreGetOutNumber={0}", intStoreGetOutNumberArg);

            scConnection.Open();
            
            SqlDataAdapter daStoreGetOutItems = new SqlDataAdapter();
            daStoreGetOutItems.SelectCommand = cmStoreGetOutItems;
            daStoreGetOutItems.Fill(dtStoreGetOutItems);
            
            scConnection.Close();

            return dtStoreGetOutItems;
        }
        public bool Insert(Connection cnConnection)
        {
            bool bolResultLoc = false;

            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStoreGetOutItems = new SqlCommand();

            cmStoreGetOutItems.Connection = cnSqlConnection;
            cmStoreGetOutItems.CommandText = String.Format(
                "INSERT INTO tabStoreGetOutItems (intStoreGetOutNumber, nvcStuffStoreCode, floStuffAmount, nvcEquipTag, intTechnicalActionType) " +
                "VALUES ({0},'{1}',{2},'{3}',{4})", this.intStoreGetOutNumber, this.strStuffStoreCode, this.dobStuffAmount, this.strEquipTag, this.intTechnicalActionType);

            cnSqlConnection.Open();
            if (cmStoreGetOutItems.ExecuteNonQuery() > 1)
            {
                bolResultLoc = true;
            }
            else
            {
                bolResultLoc = false;
            }
            cnSqlConnection.Close();

            return bolResultLoc;
        }
        public bool Update(Connection cnConnection)
        {
            bool bolResultLoc = false;

            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStoreGetOutItems = new SqlCommand();

            cmStoreGetOutItems.Connection = cnSqlConnection;
            cmStoreGetOutItems.CommandText = string.Format(
                "UPDATE tabStoreGetOutItems SET intStoreGetOutNumber={0},nvcStuffStoreCode='{1}',floStuffAmount={2},nvcEquipTag='{3}',intTechnicalActionType={4} WHERE intID={5}",
                this.intStoreGetOutNumber, this.strStuffStoreCode, this.dobStuffAmount, this.strEquipTag, this.intTechnicalActionType, this.intID);

            cnSqlConnection.Open();
            if (cmStoreGetOutItems.ExecuteNonQuery() > 1)
            {
                bolResultLoc = true;
            }
            else
            {
                bolResultLoc = false;
            }
            cnSqlConnection.Close();

            return bolResultLoc;
        }
    }
}
