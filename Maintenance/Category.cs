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
    public class Category
    {
        public int intID;
        public bool bolSelect;
        public bool bolIsActual;
        public string strName;
        public int intNumber;

        public Category()
        {
            this.intID = 0;
            this.bolSelect = false;
            this.bolIsActual = false;
            this.strName = "";
            this.intNumber = 0;
        }

        public static Category[] GetCategories(Connection cnConnection)
        {
            Category[] ctCategories;
            Int16 intRowsCount = 0;

            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmCommand = new SqlCommand("SELECT * FROM tabCategories WHERE bitIsActual=1 ORDER BY nvcName", cnSqlConnection);

            cnSqlConnection.Open();
            SqlDataReader drDataReader = cmCommand.ExecuteReader();
            while (drDataReader.Read())
            {
                ++intRowsCount;
            }
            drDataReader.Close();

            ctCategories = new Category[intRowsCount];
            drDataReader = cmCommand.ExecuteReader();
            intRowsCount = 0;
            while (drDataReader.Read())
            {
                ctCategories[intRowsCount] = new Category();
                ctCategories[intRowsCount].strName = drDataReader["nvcName"].ToString();
                ctCategories[intRowsCount].intNumber = (int)drDataReader["intNumber"];
                ++intRowsCount;
            }

            return ctCategories;
        }
        public static DataTable GetCategoriesAsDataTable(Connection cnConnection)
        {
            DataTable dtCategories = new DataTable();

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmCategories = new SqlCommand();

            cmCategories.Connection = scConnection;
            cmCategories.CommandText = "SELECT * FROM tabCategories WHERE bitIsActual=1 ORDER BY nvcName";

            scConnection.Open();
            SqlDataAdapter daCategories = new SqlDataAdapter();
            daCategories.SelectCommand = cmCategories;
            daCategories.Fill(dtCategories);
            scConnection.Close();

            return dtCategories;
        }
        public static int GetNumberByName(Connection cnConnection, String strCatagoryName)
        {
            int intNumberLoc = 0;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmCategories = new SqlCommand();

            cmCategories.Connection = scConnection;
            cmCategories.CommandText = String.Format("SELECT intNumber FROM tabCategories WHERE nvcName=N'{0}'",strCatagoryName);

            scConnection.Open();
            SqlDataReader drCategories = cmCategories.ExecuteReader();

            if (drCategories.Read())
            {
                intNumberLoc = (int)drCategories["intNumber"];
            }

            drCategories.Close();
            scConnection.Close();

            return intNumberLoc;
        }
        public static String GetNameByNumber(Connection cnConnection, int intNumberLoc)
        {
            String strNameLoc = "";

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmCategories = new SqlCommand();

            cmCategories.Connection = scConnection;
            cmCategories.CommandText = String.Format("SELECT nvcName FROM tabCategories WHERE intNumber=N'{0}'", intNumberLoc);

            scConnection.Open();
            SqlDataReader drCategories = cmCategories.ExecuteReader();

            while (drCategories.Read())
            {
                strNameLoc = drCategories["nvcName"].ToString();
            }

            drCategories.Close();
            scConnection.Close();

            return strNameLoc;
        }
        private static int NextNumber(Connection cnConnection)
        {
            int intNextCode = 0;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffStores = new SqlCommand("SELECT MAX(intNumber) FROM tabCategories", scConnection);

            scConnection.Open();
            intNextCode = (int)cmStuffStores.ExecuteScalar();

            intNextCode = ++intNextCode;
            scConnection.Close();

            return intNextCode;
        }
        public static bool Delete(Connection cnConnection, int intIdArg)
        {
            bool bolResultLoc = false;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStores = new SqlCommand();

            cmStores.CommandText = String.Format("DELETE FROM tabCategories WHERE intID={0}", intIdArg);
            cmStores.Connection = scConnection;

            scConnection.Open();
            if (cmStores.ExecuteNonQuery() >= 1)
            {
                bolResultLoc = true;
            }
            scConnection.Close();

            return bolResultLoc;
        }
        public static bool Insert(Connection cnConnection, string strNameArg)
        {
            bool bolResultLoc = false;
            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStores = new SqlCommand();
            cmStores.Connection = scConnection;
            cmStores.CommandText = String.Format("INSERT INTO tabCategories (nvcName, intNumber) VALUES (N'{0}','{1}')", strNameArg, NextNumber(cnConnection));

            scConnection.Open();
            if (cmStores.ExecuteNonQuery() >= 1)
            {
                bolResultLoc = true;
            }
            scConnection.Close();

            return bolResultLoc;
        }
        public static bool Update(Connection cnConnection, Category deCategoryArg)
        {
            bool bolResultLoc = false;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmDepartments = new SqlCommand();

            cmDepartments.Connection = scConnection;
            cmDepartments.CommandText = String.Format("UPDATE tabCategories SET nvcName=N'{0}' WHERE intID={1}", deCategoryArg.strName, deCategoryArg.intID);

            scConnection.Open();
            if (cmDepartments.ExecuteNonQuery() >= 1)
            {
                bolResultLoc = true;
            }
            scConnection.Close();

            return bolResultLoc;
        }
    }
}
