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
    public class InvoiceItem
    {
        //ID
        public int intID;
        //Number of Invoice
        public int intInvoiceNumber;
        //Request
        public int intRequest;
        //Equip
        public string strEquipStorecode;
        //Amount
        public double dblAmount;
        //Price
        public double dblPrice;

        public InvoiceItem()
        {
            this.intID = 0;
            this.strEquipStorecode = "";
            this.intInvoiceNumber = 0;
            this.intRequest = 0;
            this.dblAmount = 0;
            this.dblPrice = 0;
        }
        public static DataSet GetInvoiceItems(Connection cnConnection, InvoiceItem invSearchArg)
        {
            DataSet dsInvoiceItems = new DataSet();

            String strInvoiceItems = @"SELECT * FROM tabInvoiceItems";

            if (invSearchArg.intID != 0 || invSearchArg.intInvoiceNumber != 0 || invSearchArg.strEquipStorecode.Length != 0 ||
                invSearchArg.dblAmount != 0 || invSearchArg.dblPrice != 0 || invSearchArg.intRequest != 0)
            {
                strInvoiceItems += @" WHERE ";
            }

            if (invSearchArg.intID != 0)
            {
                strInvoiceItems += @"intID = '" + ((int)invSearchArg.intID).ToString() + "' ";
            }

            if (invSearchArg.intInvoiceNumber != 0)
            {
                if (invSearchArg.intID != 0)
                {
                    strInvoiceItems += @"AND intInvoiceNumber = '" + invSearchArg.intInvoiceNumber + "' ";
                }
                else
                {
                    strInvoiceItems += @"intInvoiceNumber = '" + invSearchArg.intInvoiceNumber + "' ";
                }
            }

            if (invSearchArg.strEquipStorecode.Length != 0)
            {
                if (invSearchArg.intID != 0 || invSearchArg.intInvoiceNumber != 0 )
                {
                    strInvoiceItems += @" AND nvcStoreCode = " + invSearchArg.strEquipStorecode + "";
                }
                else
                {
                    strInvoiceItems += @" nvcStoreCode = " + invSearchArg.strEquipStorecode + "";
                }
            }

            if (invSearchArg.dblAmount != 0)
            {
                if (invSearchArg.intID != 0 || invSearchArg.intInvoiceNumber != 0 || invSearchArg.strEquipStorecode.Length != 0 )
                {
                    strInvoiceItems += @" AND floAmount = '" + invSearchArg.dblAmount.ToString() + "'";
                }
                else
                {
                    strInvoiceItems += @" floAmount = '" + invSearchArg.dblAmount.ToString() + "'";
                }
            }

            if (invSearchArg.dblPrice != 0)
            {
                if (invSearchArg.intID != 0 || invSearchArg.intInvoiceNumber != 0 || invSearchArg.strEquipStorecode.Length != 0 || invSearchArg.dblAmount != 0)
                {
                    strInvoiceItems += @" AND floPrice = '" + invSearchArg.dblPrice.ToString() + "'";
                }
                else
                {
                    strInvoiceItems += @" floPrice = '" + invSearchArg.dblPrice.ToString() + "'";
                }
            }
            
            if (invSearchArg.intRequest != 0)
            {
                if (invSearchArg.intID != 0 || invSearchArg.intInvoiceNumber != 0 || invSearchArg.strEquipStorecode.Length != 0 || 
                   invSearchArg.dblAmount != 0 || invSearchArg.dblPrice != 0)
                {
                    strInvoiceItems += @" AND intRequestNumber = '" + invSearchArg.intRequest.ToString() + "'";
                }
                else
                {
                    strInvoiceItems += @" intRequestNumber = '" + invSearchArg.intRequest.ToString() + "'";
                }
            }



            //Create a SqlDataAdapter for the Suppliers table.
            SqlDataAdapter daInvoiceItems = new SqlDataAdapter();

            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            cnSqlConnection.Open();
            daInvoiceItems.SelectCommand = new SqlCommand(strInvoiceItems, cnSqlConnection);
            daInvoiceItems.Fill(dsInvoiceItems, "tabInvoiceItems");
            cnSqlConnection.Close();

            return dsInvoiceItems;
        }
        public void Update(Connection cnConnection)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmInvoiceItem = new SqlCommand();
            cmInvoiceItem.Connection = cnSqlConnection;
            cmInvoiceItem.CommandText = "UPDATE tabInvoiceItems SET " +
                "intInvoiceNumber='" + this.intInvoiceNumber.ToString() + "', " +
                "nvcStoreCode='" + this.strEquipStorecode + "', " +
                "floAmount='" + this.dblAmount.ToString() + "', " +
                "floPrice='" + this.dblPrice.ToString() + "', " +
                "intRequestNumber=" + this.intRequest.ToString() + " " +
                "WHERE intID=" + this.intID.ToString();

            cnSqlConnection.Open();
            cmInvoiceItem.ExecuteNonQuery();
            cnSqlConnection.Close();
        }
        public void Insert(Connection cnConnection)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmInvoiceItem = new SqlCommand();
            cmInvoiceItem.Connection = cnSqlConnection;
            cmInvoiceItem.CommandText = @"INSERT INTO tabInvoiceItems (bitSelect, intInvoiceNumber, nvcStoreCode, intRequestNumber, floAmount, floPrice) VALUES (" +
                "0,'" +
                this.intInvoiceNumber.ToString() + "','" +
                this.strEquipStorecode + "','" +
                this.intRequest.ToString() + "','" +
                this.dblAmount.ToString() + "','" +
                this.dblPrice.ToString() + "')";

            cnSqlConnection.Open();
            cmInvoiceItem.ExecuteNonQuery();
            cnSqlConnection.Close();
        }
        public static double GetCurrentSupply(Connection cnConnection,string strStoreCode)
        {
            double dobSupply = 0;
            string[] strStoreCodeArrayLoc = strStoreCode.Split('-');

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffs = new SqlCommand();

            cmStuffs.Connection = scConnection;
            cmStuffs.CommandText = String.Format(
                "SELECT floSupply FROM tabStufffs WHERE nvcStore={0} AND nvcSection={1} AND nvcMaterial={2} AND nvcType={3}",
                strStoreCodeArrayLoc[0], strStoreCodeArrayLoc[1], strStoreCodeArrayLoc[2], strStoreCodeArrayLoc[3]);

            scConnection.Open();
            SqlDataReader drStuffs = cmStuffs.ExecuteReader();

            if(drStuffs.Read())
            {
                dobSupply = (double)drStuffs["floSupply"];
            }

            drStuffs.Close();
            scConnection.Close();

            return dobSupply;
        }
        public static double GetNewSupply(Connection cnConnection, string strStoreCode,double dobAmountArg)
        {
            double dobSupply = 0;
            string[] strStoreCodeArrayLoc = strStoreCode.Split('-');

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffs = new SqlCommand();

            cmStuffs.Connection = scConnection;
            cmStuffs.CommandText = String.Format(
                "SELECT floSupply FROM tabStufffs WHERE nvcStore={0} AND nvcSection={1} AND nvcMaterial={2} AND nvcType={3}",
                strStoreCodeArrayLoc[0], strStoreCodeArrayLoc[1], strStoreCodeArrayLoc[2], strStoreCodeArrayLoc[3]);

            scConnection.Open();
            SqlDataReader drStuffs = cmStuffs.ExecuteReader();

            if (drStuffs.Read())
            {
                dobSupply = (double)drStuffs["floSupply"] + dobAmountArg;
            }

            drStuffs.Close();
            scConnection.Close();

            return dobSupply;
        }
    }
}
