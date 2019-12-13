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
    public class RequestItem
    {
        public int intID;
        public int intRequestNumber;
        public string strStoreCode;
        public double dblAmount;

        public RequestItem()
        {
            this.intID = 0;
            this.intRequestNumber = 0;
            this.strStoreCode = "";
            this.dblAmount = 0;
        }

        public static DataSet GetRequestItems(Connection cnConnection, RequestItem riSearch)
        {
            // A table mapping names the DataTable.
            DataSet dsRequestItemsLoc = new DataSet();

            String strCommand = @"SELECT * FROM tabRequestItems";

            if (riSearch.intRequestNumber != 0 || riSearch.strStoreCode.Length != 0 || riSearch.dblAmount != 0 )
            {
                strCommand += @" WHERE ";
            }

            if (riSearch.intRequestNumber != 0)
            {
                strCommand += @"intRequestNumber = '" + riSearch.intRequestNumber.ToString() + "' ";
            }


            if (riSearch.strStoreCode.Length != 0)
            {
                if (riSearch.intRequestNumber != 0 )
                {
                    strCommand += @" AND nvcStoreCode = N'" + riSearch.strStoreCode + "' ";
                }
                else
                {
                    strCommand += @"nvcStoreCode = N'" + riSearch.strStoreCode + "' ";
                }
            }

            if (riSearch.dblAmount != 0)
            {
                if (riSearch.intRequestNumber != 0  || riSearch.strStoreCode.Length != 0)
                {
                    strCommand += @" AND floAmount = N'" + riSearch.dblAmount.ToString().Replace('/', '.') + "' ";
                }
                else
                {
                    strCommand += @"floAmount = N'" + riSearch.dblAmount.ToString().Replace('/', '.') + "' ";
                }
            }

            //Create a SqlDataAdapter for the Suppliers table.
            SqlDataAdapter daVendors = new SqlDataAdapter();

            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            cnSqlConnection.Open();
            daVendors.SelectCommand = new SqlCommand(strCommand, cnSqlConnection);
            daVendors.Fill(dsRequestItemsLoc, "tabRequestItems");
            cnSqlConnection.Close();

            return dsRequestItemsLoc;
        }

        public static void DeleteRequestItems(Connection cnConnection, DataSet dsRequestItems)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmRequests = new SqlCommand();
            cmRequests.Connection = cnSqlConnection;
            cnSqlConnection.Open();

            foreach (DataRow drRequest in dsRequestItems.Tables["tabRequestItems"].Rows)
            {
                if ((Boolean)drRequest["bitSelect"])
                {
                    cmRequests.CommandText = @"DELETE FROM tabRequestItems WHERE intID = ";
                    cmRequests.CommandText += drRequest["intID"].ToString();
                    cmRequests.ExecuteNonQuery();
                }
            }

            cnSqlConnection.Close();
        }

        public void Update(Connection cnConnection)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmRequestItems = new SqlCommand();
            cmRequestItems.Connection = cnSqlConnection;
            cmRequestItems.CommandText = "UPDATE tabRequestItems SET " +
                "intRequestNumber=" + this.intRequestNumber.ToString() + ", " +
                "nvcStoreCode='" + this.strStoreCode + "', " +
                "floAmount=" + this.dblAmount.ToString().Replace('/', '.') + " " +
                "WHERE intID=" + this.intID.ToString();

            cnSqlConnection.Open();
            cmRequestItems.ExecuteNonQuery();
            cnSqlConnection.Close();
        }

        public void Insert(Connection cnConnection)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmRequests = new SqlCommand();
            cmRequests.Connection = cnSqlConnection;
            cmRequests.CommandText = @"INSERT INTO tabRequestItems (bitSelect, intRequestNumber, nvcStoreCode, floAmount) VALUES (" +
                "0," +
                this.intRequestNumber.ToString() + ",'" +
                this.strStoreCode + "'," +
                this.dblAmount.ToString().Replace('/','.') + ")";

            cnSqlConnection.Open();
            cmRequests.ExecuteNonQuery();
            cnSqlConnection.Close();
        }

    }
}
