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
    public class Subproject
    {
        public int intID;
        public int intProjectNumber;
        public int intCategory;
        public string strName;
        public DateTime dtStart;
        public int intDuration;
        public int intProgress;
        public string strTip;

        public Subproject()
        {
            this.intID = 0;
            this.intProjectNumber = 0;
            this.intCategory = 0;
            this.strName = "";
            this.dtStart = new DateTime();
            this.intDuration = 0;
            this.intProgress = 0;
            this.strTip = "";
        }

        public static DataSet GetSubprojects(Connection cnConnection, Subproject spSearch)
        {
            // A table mapping names the DataTable.
            DataSet dsSubprojects = new DataSet();

            String strCommand = @"SELECT * FROM tabSubprojects";

            if ((spSearch.intCategory != 0) || (spSearch.intProjectNumber != 0) ||
                (spSearch.strName.Length != 0) || (spSearch.dtStart.Year != 1) || (spSearch.intDuration != 0) ||
                (spSearch.intProgress != 0) || (spSearch.strTip.Length != 0))
            {
                strCommand += @" WHERE ";
            }

            if (spSearch.intCategory != 0)
            {
                strCommand += @"intcCategory = '" + spSearch.intCategory + "' ";
            }

            if (spSearch.intProjectNumber != 0)
            {
                if (spSearch.intCategory != 0)
                {
                    strCommand += @"AND intProjectNumber = '" + spSearch.intProjectNumber.ToString() + "' ";
                }
                else
                {
                    strCommand += @"intProjectNumber = '" + spSearch.intProjectNumber.ToString() + "' ";
                }
            }

            if (spSearch.strName.Length != 0)
            {
                if (spSearch.intCategory != 0 || spSearch.intProjectNumber != 0)
                {
                    strCommand += @"AND nvcName  LIKE N'%" + spSearch.strName + "%' ";
                }
                else
                {
                    strCommand += @"nvcName  LIKE N'%" + spSearch.strName + "%' ";
                }
            }

            if (spSearch.dtStart.Year != 1)
            {
                if (spSearch.intCategory != 0 || spSearch.intProjectNumber != 0 || spSearch.strName.Length != 0)
                {
                    strCommand += @" AND datStart = '" + spSearch.dtStart.Year.ToString() + "-" + spSearch.dtStart.Month.ToString() + "-" + spSearch.dtStart.Day.ToString() + "' ";
                }
                else
                {
                    strCommand += @"datStart = '" + spSearch.dtStart.Year.ToString() + "-" + spSearch.dtStart.Month.ToString() + "-" + spSearch.dtStart.Day.ToString() + "' ";
                }
            }

            if (spSearch.intDuration != 0)
            {
                if (spSearch.intCategory != 0 || spSearch.intProjectNumber != 0 || spSearch.strName.Length != 0 || spSearch.dtStart.Year != 1)
                {
                    strCommand += @" AND intDuration = '" + spSearch.intDuration.ToString() + "' ";
                }
                else
                {
                    strCommand += @"intDuration = '" + spSearch.intDuration.ToString() + "' ";
                }

            }

            if (spSearch.intProgress != 0)
            {
                if (spSearch.intCategory != 0 || spSearch.intProjectNumber != 0 || spSearch.strName.Length != 0 ||
                    spSearch.dtStart.Year != 1)
                {
                    strCommand += @" AND intProgress = '" + spSearch.intProgress + "' ";
                }
                else
                {
                    strCommand += @"intProgress = '" + spSearch.intProgress + "' ";
                }

            }

            if (spSearch.strTip.Length != 0)
            {
                if (spSearch.intCategory != 0 || spSearch.intProjectNumber != 0 || spSearch.strName.Length != 0 ||
                    spSearch.dtStart.Year != 1 || spSearch.intProgress != 0)
                {
                    strCommand += @" AND nvcTip = '" + spSearch.strTip + "' ";
                }
                else
                {
                    strCommand += @"nvcTip = '" + spSearch.strTip + "' ";
                }

            }

            strCommand += " ORDER BY datStart";

            //Create a SqlDataAdapter for the Suppliers table. 
            SqlDataAdapter daSubprojects = new SqlDataAdapter();

            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            cnSqlConnection.Open();
            daSubprojects.SelectCommand = new SqlCommand(strCommand, cnSqlConnection);
            daSubprojects.Fill(dsSubprojects, "tabSubprojects");
            cnSqlConnection.Close();

            return dsSubprojects;
        }

        public void Insert(Connection cnConnection)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmSubproject = new SqlCommand();
            cmSubproject.Connection = cnSqlConnection;
            cmSubproject.CommandText = @"INSERT INTO tabSubprojects (bitSelect, intCategory, intProjectNumber, nvcName, datStart,intDuration,intProgress,nvcTip) VALUES (" +
                "0,'" +
                this.intCategory + "'," +
                this.intProjectNumber.ToString() + ",N'" +
                this.strName + "','" +
                this.dtStart.Year.ToString() + "-" + this.dtStart.Month.ToString() + "-" + this.dtStart.Day.ToString() + "'," +
                this.intDuration.ToString() + "," +
                this.intProgress.ToString() + ",N'" +
                this.strTip + "')";

            cnSqlConnection.Open();
            cmSubproject.ExecuteNonQuery();
            cnSqlConnection.Close();
        }

        public void Update(Connection cnConnection)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmSubproject = new SqlCommand();
            cmSubproject.Connection = cnSqlConnection;
            cmSubproject.CommandText = "UPDATE tabSubprojects SET " +
                "intCategory=N'" + this.intCategory + "', " +
                "intProjectNumber=" + this.intProjectNumber.ToString() + ", " +
                "nvcName=N'" + this.strName + "', " +
                "datStart=N'" + this.dtStart.Year.ToString() + "-" + this.dtStart.Month.ToString() + "-" + this.dtStart.Day.ToString() + "', " +
                "intDuration=N'" + this.intDuration.ToString() + "', " +
                "intProgress=N'" + this.intProgress.ToString() + "', " +
                "nvcTip=N'" + this.strTip + "' " +
                "WHERE intID=" + this.intID.ToString();

            cnSqlConnection.Open();
            cmSubproject.ExecuteNonQuery();
            cnSqlConnection.Close();
        }

        public static void DeleteSubprojects(Connection cnConnection, DataSet dsVendors)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmProject = new SqlCommand();
            cmProject.Connection = cnSqlConnection;
            cnSqlConnection.Open();

            foreach (DataRow drVendor in dsVendors.Tables["tabSubprojects"].Rows)
            {
                if ((Boolean)drVendor["bitSelect"])
                {
                    cmProject.CommandText = @"DELETE FROM tabSubprojects WHERE intID = ";
                    cmProject.CommandText += drVendor["intID"].ToString();
                    cmProject.ExecuteNonQuery();
                }
            }

            cnSqlConnection.Close();
        }
    }
}
