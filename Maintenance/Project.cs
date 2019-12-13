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
    public class Project
    {
        public int intID;
        public int intNumber;
        public int intCategory;
        public string strName;
        public string strTip;
        public Subproject spSubprojects;

        public Project()
        {
            this.intID = 0;
            this.intNumber = 0;
            this.intCategory = 0;
            this.strName = "";
            this.strTip = "";
            this.spSubprojects = new Subproject();
        }

        public static DataSet GetProjects(Connection cnConnection, Project proSearch)
        {
            // A table mapping names the DataTable.
            DataSet dsProjects = new DataSet();

            String strCommand = @"SELECT * FROM tabProjects";

            if ( (proSearch.intNumber != 0) || (proSearch.intCategory != 0) || (proSearch.strName.Length != 0) || (proSearch.strTip.Length != 0) )
            {
                strCommand += @" WHERE ";
            }

            if (proSearch.intNumber != 0)
            {
                strCommand += @"nvcNumber = '" + proSearch.intNumber.ToString() + "' ";
            }

            if (proSearch.intCategory != 0)
            {
                if (proSearch.intNumber != 0)
                {
                    strCommand += @"AND intCategory = '" + proSearch.intCategory + "' ";
                }
                else
                {
                    strCommand += @"intCategory = '" + proSearch.intCategory + "' ";
                }
            }

            if (proSearch.strName.Length != 0)
            {
                if (proSearch.intNumber != 0 || proSearch.intCategory != 0)
                {
                    strCommand += @"AND nvcBrand  LIKE N'%" + proSearch.strName + "%' ";
                }
                else
                {
                    strCommand += @"nvcBrand  LIKE N'%" + proSearch.strName + "%' ";
                }

            }

            if (proSearch.strTip.Length != 0)
            {
                if (proSearch.intNumber != 0 || proSearch.intCategory != 0 || proSearch.strName.Length != 0)
                {
                    strCommand += @" AND nvcTell = N'" + proSearch.strTip + "' ";
                }
                else
                {
                    strCommand += @"nvcTell = N'" + proSearch.strTip + "' ";
                }

            }

            //Create a SqlDataAdapter for the Suppliers table.
            SqlDataAdapter daVendors = new SqlDataAdapter();

            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            cnSqlConnection.Open();
            daVendors.SelectCommand = new SqlCommand(strCommand, cnSqlConnection);
            daVendors.Fill(dsProjects, "tabProjects");
            cnSqlConnection.Close();

            return dsProjects;
        }

        public static void DeleteProjects(Connection cnConnection, DataSet dsVendors)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmProject = new SqlCommand();
            cmProject.Connection = cnSqlConnection;
            cnSqlConnection.Open();

            foreach (DataRow drVendor in dsVendors.Tables["tabProjects"].Rows)
            {
                if ((Boolean)drVendor["bitSelect"])
                {
                    cmProject.CommandText = @"DELETE FROM tabProjects WHERE intID = ";
                    cmProject.CommandText += drVendor["intID"].ToString();
                    cmProject.ExecuteNonQuery();
                }
            }

            cnSqlConnection.Close();
        }

        public void Update(Connection cnConnection)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmProject= new SqlCommand();
            cmProject.Connection = cnSqlConnection;
            cmProject.CommandText = "UPDATE tabProjects SET " +
                "intNumber='" + this.intNumber.ToString() + "', " +
                "intCategory=N'" + this.intCategory.ToString() + "', " +
                "nvcName=N'" + this.strName + "', " +
                "nvcTip=N'" + this.strTip + "' " +
                "WHERE intID=" + this.intID.ToString();

            cnSqlConnection.Open();
            cmProject.ExecuteNonQuery();
            cnSqlConnection.Close();
        }

        public int GetNextNumber(Connection cnConnection)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            int intNumberLoc = 0;
            SqlCommand comVendor = new SqlCommand("SELECT MAX(intNumber) FROM tabProjects ", cnSqlConnection);
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

        public void Insert(Connection cnConnection)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmProject = new SqlCommand();
            cmProject.Connection = cnSqlConnection;
            cmProject.CommandText = @"INSERT INTO tabProjects (bitSelect, intNumber, intCategory, nvcName, nvcTip) VALUES (" +
                "0," +
                GetNextNumber(cnConnection) + ",'" +
                this.intCategory.ToString() + "',N'" +
                this.strName + "',N'" +
                this.strTip + "')";

            cnSqlConnection.Open();
            cmProject.ExecuteNonQuery();
            cnSqlConnection.Close();
        }

        public static String GetNameByNumber(Connection cnConnection, int intNumberArg)
        {
            String strNameLoc = "";

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmPart = new SqlCommand("SELECT nvcName FROM tabProjects WHERE intNumber =" + intNumberArg.ToString() + "", scConnection);
           
            scConnection.Open();
            SqlDataReader drProjects = cmPart.ExecuteReader();

            while (drProjects.Read())
            {
                strNameLoc = drProjects["nvcName"].ToString();
            }
            
            drProjects.Close();
            scConnection.Close();

            return strNameLoc;
        }
        public static int GetCategoryByNumber(Connection cnConnection, int intNumberArg)
        {
            int intCategoryLoc = 0;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmProjects = new SqlCommand();

            cmProjects.Connection = scConnection;
            cmProjects.CommandText = String.Format("SELECT intCategory FROM tabProjects WHERE intNumber={0}", intNumberArg);

            scConnection.Open();
            SqlDataReader drProjects = cmProjects.ExecuteReader();

            while (drProjects.Read())
            {
                intCategoryLoc = (int)drProjects["intCategory"];
            }

            drProjects.Close();
            scConnection.Close();

            return intCategoryLoc;
        }
    }
}
