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
    public class StoreGetOut
    {
        public int intID;
        public bool bitSelect;
        public int intNumber;
        public int intDepartment;
        public int intSubDepartment;
        public DateTime dtDate;
        public int intGroupNumber;
        public string strRequesterCoID;
        public string strDepartmentSupervisorCoID;

        public StoreGetOut()
        {
            this.intID = 0;
            this.bitSelect = false;
            this.intNumber = 0;
            this.intDepartment = 0;
            this.intSubDepartment = 0;
            this.dtDate = new DateTime();
            this.intGroupNumber = 0;
            this.strRequesterCoID = "";
            this.strDepartmentSupervisorCoID = "";
        }

        public static DataTable GetStoreGetouts(Connection cnConnection, StoreGetOut sgoSearchArg,DateTime dtStartArg,DateTime dtEndArg)
        {
            DataTable dtStoreGetouts = new DataTable();

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStoreGetouts = new SqlCommand();
            SqlDataAdapter daStoreGetouts = new SqlDataAdapter();

            cmStoreGetouts.Connection = scConnection;
            cmStoreGetouts.CommandText = "SELECT * FROM tabStoreGetOuts";

            if (sgoSearchArg.intNumber != 0 || sgoSearchArg.intDepartment != 0 || sgoSearchArg.intSubDepartment != 0|| 
                 sgoSearchArg.intGroupNumber != 0 || sgoSearchArg.strRequesterCoID.Length != 0 || sgoSearchArg.strDepartmentSupervisorCoID.Length != 0 ||
                 dtStartArg.Year != 1 || dtEndArg.Year != 1)
            {
                cmStoreGetouts.CommandText += " WHERE ";
            }

            if (sgoSearchArg.intNumber != 0)
            {
                cmStoreGetouts.CommandText += "intNumber = " + sgoSearchArg.intNumber + " ";
            }

            if (sgoSearchArg.intDepartment != 0)
            {
                if (sgoSearchArg.intNumber != 0)
                {
                    cmStoreGetouts.CommandText += "AND intDepartment = " + sgoSearchArg.intDepartment + " ";
                }
                else
                {
                    cmStoreGetouts.CommandText += "intDepartment = " + sgoSearchArg.intDepartment + " ";
                }
            }

            if (sgoSearchArg.intSubDepartment != 0)
            {
                if (sgoSearchArg.intNumber != 0 || sgoSearchArg.intDepartment != 0)
                {
                    cmStoreGetouts.CommandText += " AND intSubDepartment = " + sgoSearchArg.intSubDepartment != 0 + " ";
                }
                else
                {
                    cmStoreGetouts.CommandText += "intSubDepartment = " + sgoSearchArg.intSubDepartment != 0 + " ";
                }

            }

            if (sgoSearchArg.intGroupNumber != 0)
            {
                if (sgoSearchArg.intNumber != 0 || sgoSearchArg.intDepartment != 0 || sgoSearchArg.intSubDepartment != 0)
                {
                    cmStoreGetouts.CommandText += " AND intGroupNumber = " + sgoSearchArg.intGroupNumber + " ";
                }
                else
                {
                    cmStoreGetouts.CommandText += "intGroupNumber = " + sgoSearchArg.intGroupNumber + " ";
                }
            }

            if (sgoSearchArg.strRequesterCoID.Length != 0)
            {
                if (sgoSearchArg.intNumber != 0 || sgoSearchArg.intDepartment != 0 || sgoSearchArg.intSubDepartment != 0 || sgoSearchArg.intGroupNumber != 0)
                {
                    cmStoreGetouts.CommandText += " AND nvcRequesterCoID = '" + sgoSearchArg.strRequesterCoID + "' ";
                }
                else
                {
                    cmStoreGetouts.CommandText += "nvcRequesterCoID = '" + sgoSearchArg.strRequesterCoID + "' ";
                }
            }

            if (sgoSearchArg.strDepartmentSupervisorCoID.Length != 0)
            {
                if (sgoSearchArg.intNumber != 0 || sgoSearchArg.intDepartment != 0 || sgoSearchArg.intSubDepartment != 0 || sgoSearchArg.intGroupNumber != 0
                    || sgoSearchArg.strRequesterCoID.Length != 0)
                {
                    cmStoreGetouts.CommandText += " AND nvcDepartmentSupervisorCoID = '" + sgoSearchArg.strDepartmentSupervisorCoID + "' ";
                }
                else
                {
                    cmStoreGetouts.CommandText += "nvcDepartmentSupervisorCoID = '" + sgoSearchArg.strDepartmentSupervisorCoID + "' ";
                }
            }

            if (dtStartArg.Year != 1)
            {
                if (sgoSearchArg.intNumber != 0 || sgoSearchArg.intDepartment != 0 || sgoSearchArg.intSubDepartment != 0 || sgoSearchArg.intGroupNumber != 0
                    || sgoSearchArg.strRequesterCoID.Length != 0 || sgoSearchArg.strDepartmentSupervisorCoID.Length != 0)
                {
                    cmStoreGetouts.CommandText += " AND datDate BETWEEN '" + dtStartArg.Year.ToString() + "-" + dtStartArg.Month.ToString() + "-" + dtStartArg.Day.ToString() + "' AND '" + dtEndArg.Year.ToString() + "-" + dtEndArg.Month.ToString() + "-" + dtEndArg.Day.ToString() + "'";
                }
                else
                {
                    cmStoreGetouts.CommandText += " datDate BETWEEN '" + dtStartArg.Year.ToString() + "-" + dtStartArg.Month.ToString() + "-" + dtStartArg.Day.ToString() + "' AND '" + dtEndArg.Year.ToString() + "-" + dtEndArg.Month.ToString() + "-" + dtEndArg.Day.ToString() + "'";
                }
            }

            scConnection.Open();
            daStoreGetouts.SelectCommand = cmStoreGetouts;
            daStoreGetouts.Fill(dtStoreGetouts);
            scConnection.Close();

            return dtStoreGetouts;
        }
        public static void DeleteStoreGetOuts(Connection cnConnection, DataTable dtStoreGetOutsArg)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmRequests = new SqlCommand();

            cmRequests.Connection = cnSqlConnection;
            cnSqlConnection.Open();

            foreach (DataRow drRequest in dtStoreGetOutsArg.Rows)
            {
                if ((Boolean)drRequest["bitSelect"])
                {
                    cmRequests.CommandText = @"DELETE FROM tabStoreGetOuts WHERE intID = ";
                    cmRequests.CommandText += drRequest["intID"].ToString();
                    cmRequests.ExecuteNonQuery();
                }
            }

            cnSqlConnection.Close();
        }
        public int GetNextNumber(Connection cnConnection)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            int intNumberLoc = 0;
            SqlCommand comVendor = new SqlCommand("SELECT MAX(intNumber) FROM tabStoreGetOuts ", cnSqlConnection);
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
        public bool Insert(Connection cnConnection)
        {
            bool bolResultLoc = false;

            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmRequests = new SqlCommand();

            cmRequests.Connection = cnSqlConnection;
            cmRequests.CommandText = String.Format(
                "INSERT INTO tabStoreGetOuts (intNumber, intDepartment, intSubDepartment, datDate, intGroupNumber, nvcRequesterCoID, nvcDepartmentSupervisorCoID) " +
                "VALUES ({0},{1},{2},'{3}-{4}-{5}',{6},'{7}','{8}')", GetNextNumber(cnConnection).ToString(), this.intDepartment, this.intSubDepartment, this.dtDate.Year,this.dtDate.Month,this.dtDate.Day, this.intGroupNumber, this.strRequesterCoID, 
                this.strDepartmentSupervisorCoID);
              
            cnSqlConnection.Open();
            if(cmRequests.ExecuteNonQuery()>=1)
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
            SqlCommand cmRequests = new SqlCommand();

            cmRequests.Connection = cnSqlConnection;
            cmRequests.CommandText = string.Format(
                "UPDATE tabStoreGetOuts SET intNumber={0},intDepartment={1},intSubDepartment={2},datDate='{3}-{4}-{5}',intGroupNumber={6},nvcRequesterCoID='{7}',nvcDepartmentSupervisorCoID='{8}' WHERE intID={9}",
                this.intNumber,this.intDepartment,intSubDepartment,this.dtDate.Year,this.dtDate.Month,this.dtDate.Day,this.intGroupNumber,this.strRequesterCoID,this.strDepartmentSupervisorCoID,this.intID);
                

            cnSqlConnection.Open();
            if(cmRequests.ExecuteNonQuery()>=1)
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
        public bool ConfirmByDepartmentSupervisor(Connection cnConnection)
        {
            bool bolResultLoc;

            SqlConnection scConnection = new SqlConnection();
            SqlCommand cmStoreGetOuts = new SqlCommand(cnConnection.strConnectionStringPty);

            cmStoreGetOuts.Connection = scConnection;
            cmStoreGetOuts.CommandText = 
                string.Format("UPDATE tabStoreGetOuts SET nvcDepartmentSupervisorCoID={0} WHERE intID={1}",
                this.strDepartmentSupervisorCoID, this.intID);

            scConnection.Open();
            if(cmStoreGetOuts.ExecuteNonQuery()>=1)
            {
                bolResultLoc = true;
            }
            else
            {
                bolResultLoc = false;
            }

            return bolResultLoc;
        }
        public static void ConfirmByDepartmentSupervisor(Connection cnConnection, DataTable dtStoreGetOutsArg, string strCoIDArg)
        {
            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStoreGetOuts = new SqlCommand();

            cmStoreGetOuts.Connection = scConnection;

            scConnection.Open();

            foreach (DataRow drStoreGetOut in dtStoreGetOutsArg.Rows)
            {
                if ((Boolean)drStoreGetOut["bitSelect"])
                {
                    cmStoreGetOuts.CommandText = string.Format("UPDATE tabStoreGetOuts SET nvcDepartmentSupervisorCoID={0} WHERE intID={1}",
                    strCoIDArg, drStoreGetOut["intID"].ToString());
                    cmStoreGetOuts.ExecuteNonQuery();
                }
            }

            scConnection.Close();
        }
    }
}
