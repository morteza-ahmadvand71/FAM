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
    public class Vendor
    {
        //ID
        public int intID;
        //Number
        public int intNumber;
        //Category
        public int intCategory;
        //Brand
        public string strBrand;
        public string strActivityType;
        public string strActivities;
        //Tell
        public string strTell;
        //First Name of Owner
        public string strFirstName;
        //Last Name of Owner
        public string strLastName;
        //City
        public string strCity;
        //Address
        public string strAddress;

        public Vendor()
        {
            this.intID = 0;
            this.intNumber = 0;
            this.intCategory = 0;
            this.strBrand = "";
            this.strActivityType = "";
            this.strActivities = "";
            this.strTell = "";
            this.strFirstName = "";
            this.strLastName = "";
            this.strCity = "";
            this.strAddress = "";
        }
        public static DataSet GetVendors(Connection cnConnection, Vendor venSearch)
        {
            // A table mapping names the DataTable.
            DataSet dsVendors = new DataSet();

            String strCommand = @"SELECT * FROM tabVendors";

            if (venSearch.intNumber != 0 || venSearch.intCategory != 0 || venSearch.strBrand.Length != 0 ||
                venSearch.strTell.Length != 0 || venSearch.strFirstName.Length != 0 || venSearch.strLastName.Length != 0 ||
                venSearch.strAddress.Length != 0 || venSearch.strCity.Length != 0 || venSearch.strActivityType.Length !=0 ||
                venSearch.strActivities.Length != 0)
            {
                strCommand += @" WHERE ";
            }

            if (venSearch.intNumber != 0)
            {
                strCommand += @"nvcNumber = '" + venSearch.intNumber.ToString() + "' ";
            }

            if (venSearch.intCategory != 0)
            {
                if (venSearch.intNumber != 0)
                {
                    strCommand += @"AND intCategory = '" + venSearch.intCategory + "' ";
                }
                else
                {
                    strCommand += @"intCategory = '" + venSearch.intCategory + "' ";
                }

            }

            if (venSearch.strBrand.Length != 0)
            {
                if (venSearch.intNumber != 0 || venSearch.intCategory != 0)
                {
                    strCommand += @"AND nvcBrand  LIKE N'%" + venSearch.strBrand + "%' ";
                }
                else
                {
                    strCommand += @"nvcBrand  LIKE N'%" + venSearch.strBrand + "%' ";
                }
            }

            if (venSearch.strTell.Length != 0)
            {
                if (venSearch.intNumber != 0 || venSearch.intCategory != 0 || venSearch.strBrand.Length != 0)
                {
                    strCommand += @" AND nvcTell = N'" + venSearch.strTell + "' ";
                }
                else
                {
                    strCommand += @"nvcTell = N'" + venSearch.strTell + "' ";
                }
            }

            if (venSearch.strFirstName.Length != 0)
            {
                if (venSearch.intNumber != 0 || venSearch.intCategory != 0 || venSearch.strBrand.Length != 0 ||
                    venSearch.strTell.Length != 0)
                {
                    strCommand += @" AND nvcFirstName LIKE N'%" + venSearch.strTell + "%' ";
                }
                else
                {
                    strCommand += @"nvcFirstName LIKE N'%" + venSearch.strTell + "%' ";
                }
            }

            if (venSearch.strLastName.Length != 0)
            {
                if (venSearch.intNumber != 0 || venSearch.intCategory != 0 || venSearch.strBrand.Length != 0 ||
                    venSearch.strTell.Length != 0 || venSearch.strFirstName.Length != 0 )
                {
                    strCommand += @" AND nvcLastName LIKE N'%" + venSearch.strLastName + "%' ";
                }
                else
                {
                    strCommand += @"nvcLastName LIKE N'%" + venSearch.strLastName + "%' ";
                }
            }

            if (venSearch.strCity.Length != 0)
            {
                if (venSearch.intNumber != 0 || venSearch.intCategory != 0 || venSearch.strBrand.Length != 0 ||
                    venSearch.strTell.Length != 0 || venSearch.strFirstName.Length != 0 || venSearch.strLastName.Length != 0)
                {
                    strCommand += @" AND nvcCity LIKE N'%" + venSearch.strCity + "%' ";
                }
                else
                {
                    strCommand += @"nvcCity LIKE N'%" + venSearch.strCity + "%' ";
                }
            }

            if (venSearch.strAddress.Length != 0)
            {
                if (venSearch.intNumber != 0 || venSearch.intCategory != 0 || venSearch.strBrand.Length != 0 ||
                    venSearch.strTell.Length != 0 || venSearch.strFirstName.Length != 0 || venSearch.strLastName.Length != 0 || venSearch.strCity.Length != 0)
                {
                    strCommand += @" AND nvcAddress LIKE N'%" + venSearch.strAddress + "%' ";
                }
                else
                {
                    strCommand += @"nvcAddress LIKE N'%" + venSearch.strAddress + "%' ";
                }
            }

            if (venSearch.strActivityType.Length != 0)
            {
                if (venSearch.intNumber != 0 || venSearch.intCategory != 0 || venSearch.strBrand.Length != 0 ||
                    venSearch.strTell.Length != 0 || venSearch.strFirstName.Length != 0 || venSearch.strLastName.Length != 0 || venSearch.strCity.Length != 0
                    || venSearch.strAddress.Length != 0)
                {
                    strCommand += @" AND nvcActivityType = '" + venSearch.strActivityType + "' ";
                }
                else
                {
                    strCommand += @"nvcActivityType = '" + venSearch.strActivityType + "' ";
                }
            }

            if (venSearch.strActivities.Length != 0)
            {
                if (venSearch.intNumber != 0 || venSearch.intCategory != 0 || venSearch.strBrand.Length != 0 ||
                    venSearch.strTell.Length != 0 || venSearch.strFirstName.Length != 0 || venSearch.strLastName.Length != 0 || venSearch.strCity.Length != 0
                    || venSearch.strAddress.Length != 0 || venSearch.strActivityType.Length != 0)
                {
                    strCommand += @" AND nvcActivities LIKE N'%" + venSearch.strActivities + "%' ";
                }
                else
                {
                    strCommand += @"nvcActivities LIKE N'%" + venSearch.strActivities + "%' ";
                }
            }

            //Create a SqlDataAdapter for the Suppliers table.
            SqlDataAdapter daVendors = new SqlDataAdapter();

            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            cnSqlConnection.Open();
            daVendors.SelectCommand = new SqlCommand(strCommand, cnSqlConnection);
            daVendors.Fill(dsVendors, "tabVendors");
            cnSqlConnection.Close();

            return dsVendors;
        }

        public void Update(Connection cnConnection)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmVendor = new SqlCommand();
            cmVendor.Connection = cnSqlConnection;
            cmVendor.CommandText = "UPDATE tabVendors SET " +
                "intNumber='" + this.intNumber.ToString() + "', " +
                "intCategory=N'" + this.intCategory + "', " +
                "nvcBrand=N'" + this.strBrand + "', " +
                "nvcActivityType='" + this.strActivityType + "', " +
                "nvcActivities=N'" + this.strActivities + "', " +
                "nvcTell='" + this.strTell + "', " +
                "nvcFirstName=N'" + this.strFirstName + "', " +
                "nvcLastName=N'" + this.strLastName + "', " +
                "nvcCity=N'" + this.strCity + "', " +
                "nvcAddress=N'" + this.strAddress + "' " +
                "WHERE intID=" + this.intID.ToString();

            cnSqlConnection.Open();
            cmVendor.ExecuteNonQuery();
            cnSqlConnection.Close();
        }

        public int GetNextNumber(Connection cnConnection)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            int intNumberLoc = 0;
            SqlCommand comVendor = new SqlCommand("SELECT MAX(intNumber) FROM tabVendors ", cnSqlConnection);
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
            SqlCommand cmVendor = new SqlCommand();
            cmVendor.Connection = cnSqlConnection;
            cmVendor.CommandText = @"INSERT INTO tabVendors (bitSelect,intNumber, intCategory, nvcBrand, nvcActivityType, nvcActivities, nvcTell, nvcFirstName, nvcLastName, nvcCity, nvcAddress) VALUES (" +
                "0,'" +
                GetNextNumber(cnConnection) + "',N'" +
                this.intCategory + "',N'" +
                this.strBrand + "','" +
                this.strActivityType + "',N'" +
                this.strActivities + "',N'" +
                this.strTell + "',N'" +
                this.strFirstName + "',N'" +
                this.strLastName + "',N'" +
                this.strCity + "',N'" +
                this.strAddress + "')";

            cnSqlConnection.Open();
            cmVendor.ExecuteNonQuery();
            cnSqlConnection.Close();
        }

        public static void DeleteVendors(Connection cnConnection, DataSet dsVendors)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmVendor = new SqlCommand();
            cmVendor.Connection = cnSqlConnection;
            cnSqlConnection.Open();

            foreach (DataRow drVendor in dsVendors.Tables["tabVendors"].Rows)
            {
                if ((Boolean)drVendor["bitSelect"])
                {
                    cmVendor.CommandText = @"DELETE FROM tabVendors WHERE intID = ";
                    cmVendor.CommandText += drVendor["intID"].ToString();
                    cmVendor.ExecuteNonQuery();
                }
            }

            cnSqlConnection.Close();
        }

        public static String GetNameByNumber(Connection cnConnection, int intNumberArg)
        {
            String strNameLoc = "";

            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmEmployee = new SqlCommand(@"SELECT * FROM tabVendors WHERE intNumber = " + intNumberArg, cnSqlConnection);
            cnSqlConnection.Open();

            SqlDataReader drEmployee = cmEmployee.ExecuteReader();

            if (drEmployee.Read())
            {
                strNameLoc = drEmployee["nvcFirstName"].ToString() + " " +
                    drEmployee["nvcLastName"].ToString() + " - " +
                    drEmployee["nvcBrand"].ToString();
            }

            drEmployee.Close();
            cnSqlConnection.Close();

            return strNameLoc;
        }

    }
}
