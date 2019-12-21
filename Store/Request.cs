using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Office;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Store
{
    public class Request
    {
        //ID Field of Sql Server Table
        public int intID;
        //Request Number
        public int intNumber;
        //Department
        public int intDepartment;
        //Row Budget
        public int intRowBudget;
        //Date of Request
        public DateTime dtDate;
        //CoID of Requester
        public String strRequesterCoID;
        //Confirmation Supervisor of Request
        public String strSupervisorCoID;
        //Confirmation Plant Manager of Request
        public String strPlantmanagerCoID;
        //Confirmation CEO of Request
        public String strCeoCoID;
      
        
        public Request()
        {
            this.intID = 0;
            this.intNumber = 0;
            this.intDepartment = 0;
            this.intRowBudget = 0;
            this.strRequesterCoID = "";
            this.dtDate = new DateTime();
            this.strSupervisorCoID = "";
            this.strPlantmanagerCoID = "";
            this.strCeoCoID = "";
        }

        public static DataSet GetRequests(Connection cnConnection, Request ReqSearch,DateTime dtFromArg,DateTime dtToArg)
        {
            // A table mapping names the DataTable.
            DataSet dsProjects = new DataSet();

            String strCommand = @"SELECT * FROM tabRequests";

            if (ReqSearch.intNumber != 0 || ReqSearch.intDepartment != 0 || dtFromArg.Year != 1 || ReqSearch.strRequesterCoID.Length != 0 || 
                ReqSearch.strSupervisorCoID.Length != 0 || ReqSearch.strPlantmanagerCoID.Length != 0 || ReqSearch.strCeoCoID.Length != 0 || ReqSearch.intRowBudget != 0)
            {
                strCommand += @" WHERE ";
            }

            if (ReqSearch.intNumber != 0)
            {
                strCommand += @"nvcNumber = '" + ReqSearch.intNumber.ToString() + "' ";
            }

            if (ReqSearch.intDepartment != 0)
            {
                if (ReqSearch.intNumber != 0)
                {
                    strCommand += @"AND intDepartment = " + ReqSearch.intDepartment + " ";
                }
                else
                {
                    strCommand += @"intDepartment = " + ReqSearch.intDepartment + " ";
                }
            }

            if (dtFromArg.Year != 1)
            {
                if (ReqSearch.intNumber != 0 || ReqSearch.intDepartment != 0)
                {
                    strCommand += @" AND datDate BETWEEN '" + dtFromArg.Year.ToString() + "-" + dtFromArg.Month.ToString() + "-" + dtFromArg.Day.ToString() + "' AND '" + dtToArg.Year.ToString() + "-" + dtToArg.Month.ToString() + "-" + dtToArg.Day.ToString() + "'";
                }
                else
                {
                    strCommand += @" datDate BETWEEN '" + dtFromArg.Year.ToString() + "-" + dtFromArg.Month.ToString() + "-" + dtFromArg.Day.ToString() + "' AND '" + dtToArg.Year.ToString() + "-" + dtToArg.Month.ToString() + "-" + dtToArg.Day.ToString() + "'";
                }
            }

            if (ReqSearch.strRequesterCoID.Length != 0)
            {
                if (ReqSearch.intNumber != 0 || ReqSearch.intDepartment != 0 || dtFromArg.Year != 1)
                {
                    strCommand += @" AND nvcRequesterCoID = N'" + ReqSearch.strRequesterCoID + "' ";
                }
                else
                {
                    strCommand += @"nvcRequesterCoID = N'" + ReqSearch.strRequesterCoID + "' ";
                }
            }

            if (ReqSearch.strSupervisorCoID.Length != 0)
            {
                if (ReqSearch.intNumber != 0 || ReqSearch.intDepartment != 0 || dtFromArg.Year != 1 || ReqSearch.strRequesterCoID.Length != 0)
                {
                    strCommand += @" AND nvcSupervisorCoID = N'" + ReqSearch.strSupervisorCoID + "' ";
                }
                else
                {
                    strCommand += @"nvcSupervisorCoID = N'" + ReqSearch.strSupervisorCoID + "' ";
                }
            }

            if (ReqSearch.strPlantmanagerCoID.Length != 0)
            {
                if (ReqSearch.intNumber != 0 || ReqSearch.intDepartment != 0 || dtFromArg.Year != 1 || ReqSearch.strRequesterCoID.Length != 0
                    || ReqSearch.strSupervisorCoID.Length != 0)
                {
                    strCommand += @" AND nvcPlantmanagerCoID = N'" + ReqSearch.strPlantmanagerCoID + "' ";
                }
                else
                {
                    strCommand += @"nvcPlantmanagerCoID = N'" + ReqSearch.strPlantmanagerCoID + "' ";
                }
            }

            if (ReqSearch.strCeoCoID.Length != 0)
            {
                if (ReqSearch.intNumber != 0 || ReqSearch.intDepartment != 0 || dtFromArg.Year != 1 || ReqSearch.strRequesterCoID.Length != 0
                    || ReqSearch.strSupervisorCoID.Length != 0)
                {
                    strCommand += @" AND nvcCeoCoID = N'" + ReqSearch.strCeoCoID + "' ";
                }
                else
                {
                    strCommand += @"nvcCeoCoID = N'" + ReqSearch.strCeoCoID + "' ";
                }
            }

            if (ReqSearch.intRowBudget != 0)
            {
                if (ReqSearch.intNumber != 0 || ReqSearch.intDepartment != 0 || dtFromArg.Year != 1 || ReqSearch.strRequesterCoID.Length != 0
                    || ReqSearch.strSupervisorCoID.Length != 0 || ReqSearch.strCeoCoID.Length != 0)
                {
                    strCommand += @" AND intRowBudget = " + ReqSearch.intRowBudget + " ";
                }
                else
                {
                    strCommand += @"intRowBudget = " + ReqSearch.intRowBudget + " ";
                }
            }
            
            //Create a SqlDataAdapter for the Suppliers table.
            SqlDataAdapter daVendors = new SqlDataAdapter();

            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            cnSqlConnection.Open();
            daVendors.SelectCommand = new SqlCommand(strCommand, cnSqlConnection);
            daVendors.Fill(dsProjects, "tabRequests");
            cnSqlConnection.Close();

            return dsProjects;
        }

        public int GetNextNumber(Connection cnConnection)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            int intNumberLoc = 0;
            SqlCommand comVendor = new SqlCommand("SELECT MAX(intNumber) FROM tabRequests ", cnSqlConnection);
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
            SqlCommand cmRequests = new SqlCommand();
            cmRequests.Connection = cnSqlConnection;
            cmRequests.CommandText = @"INSERT INTO tabRequests (bitSelect, intNumber, intDepartment, intRowBudget, datDate, nvcRequesterCoID, nvcSupervisorCoID, nvcPlantmanagerCoID, nvcCeoCoID) VALUES (" +
                "0," +
                GetNextNumber(cnConnection).ToString() + ",'" +
                this.intDepartment + "'," +
                this.intRowBudget.ToString() + ",'" + 
                this.dtDate.Year.ToString() + "-" + this.dtDate.Month.ToString() + "-" + this.dtDate.Day.ToString() + "','" +
                this.strRequesterCoID + "','" +
                this.strSupervisorCoID + "','" +
                this.strPlantmanagerCoID + "','" +
                this.strCeoCoID + "')";

            cnSqlConnection.Open();
            cmRequests.ExecuteNonQuery();
            cnSqlConnection.Close();
        }
        //Update The Object in Sql Server DataBase
        public void Update(Connection cnConnection)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmRequests = new SqlCommand();
            cmRequests.Connection = cnSqlConnection;
            cmRequests.CommandText = "UPDATE tabRequests SET " +
                "intNumber=" + this.intNumber.ToString() + ", " +
                "intDepartment='" + this.intDepartment + "', " +
                "intRowBudget=" + this.intRowBudget.ToString() + ", " +
                "datDate='" + this.dtDate.Year.ToString() + "-" + this.dtDate.Month.ToString() + "-" + this.dtDate.Day.ToString() + "', " +
                "nvcRequesterCoID='" + this.strRequesterCoID + "', " +
                "nvcSupervisorCoID='" + this.strSupervisorCoID + "', " +
                "nvcPlantmanagerCoID='" + this.strPlantmanagerCoID + "', " +
                "nvcCeoCoID='" + this.strCeoCoID + "' " +
                "WHERE intID=" + this.intID.ToString();

            cnSqlConnection.Open();
            cmRequests.ExecuteNonQuery();
            cnSqlConnection.Close();
        }
        //Delete The Object from Sql Server DataBase
        public static void DeleteRequests(Connection cnConnection, DataSet dsVendors)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmRequests = new SqlCommand();
            cmRequests.Connection = cnSqlConnection;
            cnSqlConnection.Open();

            foreach (DataRow drRequest in dsVendors.Tables["tabRequests"].Rows)
            {
                if ((Boolean)drRequest["bitSelect"])
                {
                    cmRequests.CommandText = @"DELETE FROM tabRequests WHERE intID = ";
                    cmRequests.CommandText += drRequest["intID"].ToString();
                    cmRequests.ExecuteNonQuery();
                }
            }

            cnSqlConnection.Close();
        }

        public static Request GetRequestByNumner(Connection cnConnection,int intNumberArg)
        {
            // A table mapping names the DataTable.
            Request reqResultLoc = new Request();

            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand scRequests = new SqlCommand();

            scRequests.Connection = cnSqlConnection;
            scRequests.CommandText = @"SELECT * FROM tabRequests WHERE intNumber=" + intNumberArg.ToString();

            cnSqlConnection.Open();
            SqlDataReader drRequest = scRequests.ExecuteReader();

            if(drRequest.Read())
            {
                reqResultLoc.intID = (int)drRequest["intID"];
                reqResultLoc.intNumber = (int)drRequest["intID"];
                reqResultLoc.intDepartment = (int)drRequest["intDepartment"];
                reqResultLoc.intRowBudget = (int)drRequest["intRowBudget"];
                reqResultLoc.dtDate = (DateTime)drRequest["datDate"];
                reqResultLoc.strRequesterCoID = drRequest["nvcRequesterCoID"].ToString();
                reqResultLoc.strSupervisorCoID = drRequest["nvcSupervisorCoID"].ToString();
                reqResultLoc.strPlantmanagerCoID = drRequest["nvcPlantmanagerCoID"].ToString();
                reqResultLoc.strCeoCoID = drRequest["nvcCeoCoID"].ToString();
            }

            drRequest.Close();
            cnSqlConnection.Close();

            return reqResultLoc;
        }
        public static string GetNameByNumner(Connection cnConnection, int intNumberArg)
        {
            // A table mapping names the DataTable.
            string strName = "";

            SqlConnection scSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmRequests = new SqlCommand();

            cmRequests.Connection = scSqlConnection;
            cmRequests.CommandText = @"SELECT * FROM tabRequests WHERE intNumber=" + intNumberArg.ToString();

            scSqlConnection.Open();
            SqlDataReader drRequest = cmRequests.ExecuteReader();

            if(intNumberArg != -1)
            {
                if (drRequest.Read())
                {
                    strName = Department.GetNameByNumber(cnConnection, (int)drRequest["intDepartment"]) + " - " +
                        Employee.GetNameByCoID(cnConnection, drRequest["nvcRequesterCoID"].ToString()) + " - " +
                        intNumberArg.ToString();
                }
            }
            else
            {
                strName = "بدون درخواست";
            }
            

            drRequest.Close();
            scSqlConnection.Close();

            return strName;
        }
    }
}
