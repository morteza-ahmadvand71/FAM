using Baran.Ferroalloy.Automation.SqlDataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Office
{
    public class Department
    {
        public int intID;
        public bool bolSelect;
        public bool bolIsActual;
        public string strName;
        public int intNumber;

        public Department()
        {
            this.intID = 0;
            this.bolSelect = false;
            this.bolIsActual = false;
            this.strName = "";
            this.intNumber = 0;
        }

        public static Department[] GetDepartments(Connection cnConnection)
        {
            Department[] depDepartments;
            int intRowsCount = 0;

            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmCommand = new SqlCommand("SELECT * FROM tabDepartments WHERE bitIsActual=1", cnSqlConnection);

            cnSqlConnection.Open();
            SqlDataReader drDepartments = cmCommand.ExecuteReader();
            while (drDepartments.Read())
            {
                ++intRowsCount;
            }
            drDepartments.Close();

            depDepartments = new Department[intRowsCount];
            drDepartments = cmCommand.ExecuteReader();
            intRowsCount = 0;
            while (drDepartments.Read())
            {
                depDepartments[intRowsCount] = new Department();
                depDepartments[intRowsCount].strName = drDepartments["nvcName"].ToString();
                depDepartments[intRowsCount].intNumber = (int)drDepartments["intNumber"];
                ++intRowsCount;
            }

            return depDepartments;
        }
        public static DataTable GetDepartmentsAsDataTable(Connection cnConnection)
        {
            DataTable dtDepartments = new DataTable();

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffStores = new SqlCommand("SELECT * FROM tabDepartments WHERE bitIsActual=1 ORDER BY nvcName", scConnection);

            scConnection.Open();
            SqlDataAdapter daDepartments = new SqlDataAdapter();
            daDepartments.SelectCommand = cmStuffStores;
            daDepartments.Fill(dtDepartments);
            scConnection.Close();

            return dtDepartments;
        }
        public static bool Delete(Connection cnConnection, int intIdArg)
        {
            bool bolResultLoc = false;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStores = new SqlCommand();

            cmStores.CommandText = String.Format("DELETE FROM tabDepartments WHERE intID={0}", intIdArg);
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
            cmStores.CommandText = String.Format( "INSERT INTO tabDepartments (nvcName, intNumber) VALUES (N'{0}','{1}')",strNameArg,NextNumber(cnConnection));

            scConnection.Open();
            if (cmStores.ExecuteNonQuery() >= 1)
            {
                bolResultLoc = true;
            }
            scConnection.Close();

            return bolResultLoc;
        }
        private static int NextNumber(Connection cnConnection)
        {
            int intNextCode = 0;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffStores = new SqlCommand("SELECT MAX(intNumber) FROM tabDepartments", scConnection);

            scConnection.Open();
            intNextCode = (int)cmStuffStores.ExecuteScalar();

            intNextCode = ++intNextCode;
            scConnection.Close();

            return intNextCode;
        }
        public static bool Update(Connection cnConnection, Department deDepartmentArg)
        {
            bool bolResultLoc = false;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmDepartments = new SqlCommand();

            cmDepartments.Connection = scConnection;
            cmDepartments.CommandText = String.Format("UPDATE tabDepartments SET nvcName=N'{0}' WHERE intID={1}", deDepartmentArg.strName, deDepartmentArg.intID);

            scConnection.Open();
            if (cmDepartments.ExecuteNonQuery() >= 1)
            {
                bolResultLoc = true;
            }
            scConnection.Close();

            return bolResultLoc;
        }
        public static int GetNumberByName(Connection cnConnection, String strNameArg)
        {
            int intNumberLoc = 0;

            SqlConnection scDepartment = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmDepartment = new SqlCommand();

            cmDepartment.Connection = scDepartment;
            cmDepartment.CommandText = String.Format("SELECT * FROM tabDepartments WHERE nvcName=N'{0}'", strNameArg);

            scDepartment.Open();
            SqlDataReader drDepartment = cmDepartment.ExecuteReader();

            if (drDepartment.Read())
            {
                intNumberLoc = (int)drDepartment["intNumber"];
            }

            drDepartment.Close();
            scDepartment.Close();

            return intNumberLoc;
        }
        public static String GetNameByNumber(Connection cnConnection, int intNumberArg)
        {
            String strNameLoc = "";

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmDepartments = new SqlCommand();

            cmDepartments.Connection = scConnection;
            cmDepartments.CommandText = String.Format("SELECT nvcName FROM tabDepartments WHERE intNumber='{0}'", intNumberArg);

            scConnection.Open();
            SqlDataReader drDepartment = cmDepartments.ExecuteReader();

            if (drDepartment.Read())
            {
                strNameLoc = drDepartment["nvcName"].ToString();
            }

            scConnection.Close();

            return strNameLoc;
        }

    }
}
