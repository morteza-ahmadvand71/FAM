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
    public class TechnicalDocument
    {
        //ID Field of Sql Server Table
        private Int16 intID;
        //Document Number
        private String strCode;
        //Category
        public int intCategory;
        //Zone Code
        private String strZone;
        //Corporation Name
        private String strCoDesigner;
        //Designer Name
        private String strPersonDesigner;
        //Revision Number
        private String strRevisionNumber;
        //Tip
        private String strTip;

        //ID Field of Sql Server Table
        public Int16 intIDPty
        {
            get
            {
                return this.intID;
            }
            set
            {
                this.intID = value;
            }
        }
        //Document Number
        public String strCodePty
        {
            get
            {
                return this.strCode;
            }
            set
            {
                this.strCode = value;
            }
        }
        
        //Zone Code
        public String strZonePty
        {
            get
            {
                return this.strZone;
            }
            set
            {
                this.strZone = value;
            }
        }
        //Corporation Name
        public String strCoDesignerPty
        {
            get
            {
                return this.strCoDesigner;
            }
            set
            {
                this.strCoDesigner = value;
            }
        }
        //Designer Name
        public string strPersonDesignerPty
        {
            get
            {
                return this.strPersonDesigner;
            }
            set
            {
                this.strPersonDesigner = value;
            }
        }
        //Revision Number
        public String strRevisionNumberPty
        {
            get
            {
                return this.strRevisionNumber;
            }
            set
            {
                this.strRevisionNumber = value;
            }
        }
        //Tip
        public String strTipPty
        {
            get
            {
                return this.strTip;
            }
            set
            {
                this.strTip = value;
            }
        }

        public static DataSet GetTechnicalDocuments(Connection cnConnection, TechnicalDocument tdSearch)
        {
            // A table mapping names the DataTable.
            DataSet dsTechnicalDocuments = new DataSet();

            String strCommand = @"SELECT * FROM tabTechnicalDocuments";

            if ((tdSearch.intCategory != 0) || (tdSearch.strZonePty.Length != 0) || (tdSearch.strCodePty.Length != 0) ||
                (tdSearch.strCoDesignerPty.Length != 0) || (tdSearch.strPersonDesignerPty.Length != 0) ||
                (tdSearch.strRevisionNumberPty.Length != 0))
            {
                strCommand += @" WHERE ";
            }

            if (tdSearch.intCategory != 0)
            {
                strCommand += @"intCategory = '" + tdSearch.intCategory + "' ";
            }

            if (tdSearch.strZonePty.Length != 0)
            {
                if (tdSearch.intCategory != 0)
                {
                    strCommand += @"AND nvcZone = '" + tdSearch.strZonePty + "' ";
                }
                else
                {
                    strCommand += @"nvcZone = '" + tdSearch.strZonePty + "' ";
                }
            }

            if (tdSearch.strCodePty.Length != 0)
            {
                if (tdSearch.intCategory != 0 || tdSearch.strZonePty.Length != 0)
                {
                    strCommand += @" AND nvcCode LIKE '%" + tdSearch.strCodePty + "%' ";
                }
                else
                {
                    strCommand += @"nvcCode LIKE '%" + tdSearch.strCodePty + "%'";
                }

            }

            if (tdSearch.strCoDesignerPty.Length != 0)
            {
                if (tdSearch.intCategory != 0 || tdSearch.strZonePty.Length != 0 || tdSearch.strCodePty.Length != 0)
                {
                    strCommand += @" AND nvcCoDesigner LIKE '%" + tdSearch.strCoDesignerPty + "%' ";
                }
                else
                {
                    strCommand += @"nvcCoDesigner LIKE '%" + tdSearch.strCoDesignerPty + "%' ";
                }
            }

            if (tdSearch.strPersonDesignerPty.Length != 0)
            {
                if (tdSearch.intCategory != 0 || tdSearch.strZonePty.Length != 0 || tdSearch.strCodePty.Length != 0 ||
                    tdSearch.strCoDesignerPty.Length != 0)
                {
                    strCommand += @" AND nvcDesignerName LIKE '%" + tdSearch.strPersonDesignerPty + "%' ";
                }
                else
                {
                    strCommand += @"nvcDesignerName LIKE '%" + tdSearch.strPersonDesignerPty + "%' ";
                }
            }

            if (tdSearch.strRevisionNumberPty.Length != 0)
            {
                if (tdSearch.intCategory != 0 || tdSearch.strZonePty.Length != 0 || tdSearch.strCodePty.Length != 0 ||
                    tdSearch.strCoDesignerPty.Length != 0 || tdSearch.strPersonDesignerPty.Length != 0)
                {
                    strCommand += @" AND nvcRevisionNumber LIKE '%" + tdSearch.strRevisionNumberPty + "%' ";
                }
                else
                {
                    strCommand += @"nvcRevisionNumber LIKE '%" + tdSearch.strRevisionNumberPty + "%' ";
                }
            }

            //MessageBox.Show(strCommand);
            //Create a SqlDataAdapter for the Suppliers table.
            SqlDataAdapter daTechnicalDocuments = new SqlDataAdapter();

            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            cnSqlConnection.Open();
            daTechnicalDocuments.SelectCommand = new SqlCommand(strCommand, cnSqlConnection);
            daTechnicalDocuments.Fill(dsTechnicalDocuments, "tabTechnicalDocuments");
            cnSqlConnection.Close();

            return dsTechnicalDocuments;
        }
        public static void DeleteTechnicalDocuments(Connection cnConnection, DataSet dsTechnicalDocuments)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmCommand = new SqlCommand();
            cmCommand.Connection = cnSqlConnection;
            cnSqlConnection.Open();

            foreach (DataRow drTechnicalDocument in dsTechnicalDocuments.Tables["tabTechnicalDocuments"].Rows)
            {
                if ((Boolean)drTechnicalDocument["bitSelect"])
                {
                    cmCommand.CommandText = @"DELETE FROM tabTechnicalDocuments WHERE intID = ";
                    cmCommand.CommandText += drTechnicalDocument["intID"].ToString();
                    cmCommand.ExecuteNonQuery();
                }
            }

            cnSqlConnection.Close();
        }
        //Insert The Object in Sql Server DataBase
        public void Insert(Connection cnConnection)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmCommand = new SqlCommand();
            cmCommand.Connection = cnSqlConnection;
            cmCommand.CommandText = @"INSERT INTO tabTechnicalDocuments (intCategory, nvcZone, nvcCode, nvcCoDesigner, nvcPersonDesigner, nvcRevisionNumber, nvcTip) VALUES ('" +
                this.intCategory + "','" +
                this.strZonePty + "','" +
                this.strCodePty + "','" +
                this.strCoDesignerPty + "','" +
                this.strPersonDesignerPty + "','" +
                this.strRevisionNumberPty + "','" +
                this.strTipPty + "')";

            cnSqlConnection.Open();
            cmCommand.ExecuteNonQuery();
            cnSqlConnection.Close();
        }
        //Update The Object in Sql Server DataBase
        public void Update(Connection cnConnection)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmCommand = new SqlCommand();
            cmCommand.Connection = cnSqlConnection;
            cmCommand.CommandText = "UPDATE tabTechnicalDocuments SET " +
                "intCategory='" + this.intCategory + "', " +
                "nvcZone='" + this.strZonePty + "', " +
                "nvcCode='" + this.strCodePty + "', " +
                "nvcCoDesigner='" + this.strCoDesignerPty + "', " +
                "nvcPersonDesigner='" + this.strPersonDesignerPty + "', " +
                "nvcRevisionNumber='" + this.strRevisionNumberPty + "', " +
                "nvcTip='" + this.strTipPty + "' " +
                "WHERE intID=" + this.intIDPty.ToString();

            cnSqlConnection.Open();
            cmCommand.ExecuteNonQuery();
            cnSqlConnection.Close();
        }
        //Delete The Object from Sql Server DataBase
        protected Boolean Delete()
        {
            Boolean bolResult = false;

            return bolResult;
        }
    }
}
