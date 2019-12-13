using Baran.Ferroalloy.Automation.SqlDataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Finance
{
    public class Invoice
    {
        //ID
        public int intID;
        //Invoice Number
        public int intNumber;
        //Invoice Number of Vendor
        public int intInvoiceNumberofVendor;
        //Date
        public DateTime dtDate;
        //Vendor Number
        public int intVendorNumber;
        //Buyer
        public string strBuyerCoID;
       

        public Invoice()
        {
            this.intID = 0;
            this.intNumber = 0;
            this.intInvoiceNumberofVendor = 0;
            this.intVendorNumber = 0;
            this.dtDate = new DateTime();
            this.strBuyerCoID = "";
        }

        public static DataSet GetInvoices(Connection cnConnection,
           Invoice invSearchArg, DateTime dtFromArg, DateTime dtToArg)
        {
            DataSet dsInvoices = new DataSet();

            String strInvoice = @"SELECT * FROM tabInvoices";

            if (invSearchArg.intID != 0 || invSearchArg.intNumber != 0 || invSearchArg.intInvoiceNumberofVendor != 0 ||
                invSearchArg.strBuyerCoID.Length != 0 || dtFromArg.Year != 1 || dtToArg.Year != 1 || invSearchArg.intVendorNumber != 0)
            {
                strInvoice += @" WHERE ";
            }

            if (invSearchArg.intID != 0)
            {
                strInvoice += @"intID = '" + ((int)invSearchArg.intID).ToString() + "' ";
            }

            if (invSearchArg.intNumber != 0)
            {
                if (invSearchArg.intID != 0)
                {
                    strInvoice += @"AND intNumber = '" + invSearchArg.intNumber + "' ";
                }
                else
                {
                    strInvoice += @"intNumber = '" + invSearchArg.intNumber + "' ";
                }
            }

            if (dtFromArg.Year != 1 && dtToArg.Year != 1)
            {
                if (invSearchArg.intID != 0 || invSearchArg.intNumber != 0)
                {
                    strInvoice += @" AND datDate BETWEEN '" + dtFromArg.Year.ToString() + "-" + dtFromArg.Month.ToString() + "-" + dtFromArg.Day.ToString() + "' AND '" + dtToArg.Year.ToString() + "-" + dtToArg.Month.ToString() + "-" + dtToArg.Day.ToString() + "'";
                }
                else
                {
                    strInvoice += @" datDate BETWEEN '" + dtFromArg.Year.ToString() + "-" + dtFromArg.Month.ToString() + "-" + dtFromArg.Day.ToString() + "' AND '" + dtToArg.Year.ToString() + "-" + dtToArg.Month.ToString() + "-" + dtToArg.Day.ToString() + "'";
                }
            }

            if (invSearchArg.intInvoiceNumberofVendor != 0)
            {
                if (invSearchArg.intID != 0 || invSearchArg.intNumber != 0 || (dtFromArg.Year != 1 && dtToArg.Year != 1))
                {
                    strInvoice += @" AND intInvoiceNumberofVendor = " + invSearchArg.intInvoiceNumberofVendor + "";
                }
                else
                {
                    strInvoice += @" intInvoiceNumberofVendor = " + invSearchArg.intInvoiceNumberofVendor + "";
                }
            }

            if (invSearchArg.strBuyerCoID.Length != 0)
            {
                if (invSearchArg.intID != 0 || invSearchArg.intNumber != 0 || (dtFromArg.Year != 1 && dtToArg.Year != 1) || invSearchArg.intInvoiceNumberofVendor != 0)
                {
                    strInvoice += @" AND nvcCoID = '" + invSearchArg.strBuyerCoID + "'";
                }
                else
                {
                    strInvoice += @" nvcCoID = '" + invSearchArg.strBuyerCoID + "'";
                }
            }

            if (invSearchArg.intVendorNumber != 0)
            {
                if (invSearchArg.intID != 0 || invSearchArg.intNumber != 0 || (dtFromArg.Year != 1 && dtToArg.Year != 1) ||
                    invSearchArg.intInvoiceNumberofVendor != 0 || invSearchArg.strBuyerCoID.Length != 0)
                {
                    strInvoice += @" AND intVendorNumber = " + invSearchArg.intVendorNumber.ToString() + "";
                }
                else
                {
                    strInvoice += @" intVendorNumber = " + invSearchArg.intVendorNumber.ToString() + "";
                }
            }



            //Create a SqlDataAdapter for the Suppliers table.
            SqlDataAdapter daMaintenancefurnaceshifts = new SqlDataAdapter();

            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            cnSqlConnection.Open();
            daMaintenancefurnaceshifts.SelectCommand = new SqlCommand(strInvoice, cnSqlConnection);
            daMaintenancefurnaceshifts.Fill(dsInvoices, "tabInvoices");
            cnSqlConnection.Close();

            return dsInvoices;
        }

        public void Update(Connection cnConnection)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmInvoice = new SqlCommand();
            cmInvoice.Connection = cnSqlConnection;
            cmInvoice.CommandText = "UPDATE tabInvoices SET " +
                "intNumber='" + this.intNumber.ToString() + "', " +
                "intInvoiceNumberofVendor='" + this.intInvoiceNumberofVendor.ToString() + "', " +
                "datDate='" + this.dtDate.Year.ToString() + "-" + this.dtDate.Month.ToString() + "-" + this.dtDate.Day.ToString() + "', " +
                "intVendorNumber='" + this.intVendorNumber.ToString() + "', " +
                "nvcBuyerCoID='" + this.strBuyerCoID + "' " +
                "WHERE intID=" + this.intID.ToString();

            cnSqlConnection.Open();
            cmInvoice.ExecuteNonQuery();
            cnSqlConnection.Close();
        }

        public int GetNextNumber(Connection cnConnection)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            int intNumberLoc = 0;
            SqlCommand comVendor = new SqlCommand("SELECT MAX(intNumber) FROM tabInvoices ", cnSqlConnection);
            cnSqlConnection.Open();
            try
            {
                intNumberLoc = int.Parse(comVendor.ExecuteScalar().ToString());
            }
            catch
            {
                intNumberLoc = 0;
            }
            
            cnSqlConnection.Close();

            ++intNumberLoc;

            return intNumberLoc;
        }

        //Insert The Object in Sql Server DataBase
        public void Insert(Connection cnConnection)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmInvoice = new SqlCommand();
            cmInvoice.Connection = cnSqlConnection;
            cmInvoice.CommandText = @"INSERT INTO tabInvoices (bitSelect, intNumber, intInvoiceNumberofVendor, datDate, intVendorNumber, nvcBuyerCoID) VALUES (" +
                "0,'" +
                GetNextNumber(cnConnection) + "','" +
                this.intInvoiceNumberofVendor + "','" +
                this.dtDate.Year.ToString() + "-" + this.dtDate.Month.ToString() + "-" + this.dtDate.Day.ToString() + "'," +
                this.intVendorNumber + ",'" +
                this.strBuyerCoID + "')";

            cnSqlConnection.Open();
            cmInvoice.ExecuteNonQuery();
            cnSqlConnection.Close();
        }

        public static void DeleteVendors(Connection cnConnection, DataSet dsVendors)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmInvoice = new SqlCommand();
            cmInvoice.Connection = cnSqlConnection;
            cnSqlConnection.Open();

            foreach (DataRow drVendor in dsVendors.Tables["tabInvoices"].Rows)
            {
                if ((Boolean)drVendor["bitSelect"])
                {
                    cmInvoice.CommandText = @"DELETE FROM tabInvoices WHERE intID = ";
                    cmInvoice.CommandText += drVendor["intID"].ToString();
                    cmInvoice.ExecuteNonQuery();
                }
            }

            cnSqlConnection.Close();
        }
    }
}
