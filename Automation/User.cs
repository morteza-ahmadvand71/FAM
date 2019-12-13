using Baran.Ferroalloy.Automation.SqlDataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baran.Ferroalloy.Automation.Security
{
    public class User
    {
        public int intID;
        public string strUsername;
        public string strPassword;
        public string strCoID;
        public bool bolLogined;
        public bool bolOfficeEnabed;
        public bool bolFinanceEnabed;
        public bool bolCommerceEnabed;
        public bool bolProductionEnabed;
        public bool bolTechnicalEnabed;
        public bool bolStoreEnabed;
        public bool bolLabEnabed;
       
        public enum AccountStatus
        {
            UserOrPassNotCorrect = 1,
            AccountAlreadyLogined = 2,
            AccountIsReady = 3
        }

        public User()
        {
            this.intID = 0;
            this.strUsername = "";
            this.strPassword = "";
            this.strCoID = "";
            this.bolLogined = false;
            this.bolOfficeEnabed = false;
            this.bolFinanceEnabed = false;
            this.bolCommerceEnabed = false;
            this.bolProductionEnabed = false;
            this.bolTechnicalEnabed = false;
            this.bolStoreEnabed = false;
            this.bolLabEnabed = false;
        }

        public static AccountStatus GetAccountStatus(Connection cnConnection, String strUsername, String strPassword)
        {
            AccountStatus usResultLoc;

            String strUsernameLoc = strUsername.ToLower();
            String strCommand = "SELECT * FROM tabUsers WHERE nvcUsername='" + strUsernameLoc.ToLower() + "' AND nvcPassword='" + strPassword + "'";
            
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);

            cnSqlConnection.Open();
            SqlCommand cmCommand = new SqlCommand(strCommand, cnSqlConnection);
            SqlDataReader drDataReader = cmCommand.ExecuteReader();

            if (drDataReader.Read())
            {
                if ((bool)drDataReader["bitLogined"])
                {
                    usResultLoc = AccountStatus.AccountAlreadyLogined;
                }
                else
                {
                    usResultLoc = AccountStatus.AccountIsReady;
                }
            }
            else
            {
                usResultLoc = AccountStatus.UserOrPassNotCorrect;
            }

            drDataReader.Close();
            cnSqlConnection.Close();

            return usResultLoc;
        }
        public static bool Login(Connection cnConnection,ref User usUserLoc, String strUsername, String strPassword)
        {
            bool bolResultLoc = false;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmUsers = new SqlCommand();

            cmUsers.Connection = scConnection;
            cmUsers.CommandText = string.Format("SELECT * FROM tabUsers WHERE nvcUsername='{0}' AND nvcPassword='{1}'", strUsername.ToLower(), strPassword);

            scConnection.Open();
            SqlDataReader drDataReader = cmUsers.ExecuteReader();

            usUserLoc.intID = 0;
            usUserLoc.strCoID = "";
            usUserLoc.strUsername = "";
            usUserLoc.strPassword = "";
            usUserLoc.bolLogined = false;
            usUserLoc.bolOfficeEnabed = false;
            usUserLoc.bolFinanceEnabed = false;
            usUserLoc.bolCommerceEnabed = false;
            usUserLoc.bolProductionEnabed = false;
            usUserLoc.bolTechnicalEnabed = false;
            usUserLoc.bolStoreEnabed = false;
            usUserLoc.bolLabEnabed = false;

            if (drDataReader.Read())
            {
                usUserLoc.intID = (int)drDataReader["intID"];
                usUserLoc.strCoID = drDataReader["nvcCoID"].ToString();
                usUserLoc.strUsername = drDataReader["nvcUsername"].ToString();
                usUserLoc.strPassword = drDataReader["nvcPassword"].ToString();
                usUserLoc.bolLogined = (bool)drDataReader["bitLogined"];
                usUserLoc.bolOfficeEnabed = (Boolean)drDataReader["bitOfficeEnabed"];
                usUserLoc.bolFinanceEnabed = (Boolean)drDataReader["bitFinanceEnabed"];
                usUserLoc.bolCommerceEnabed = (Boolean)drDataReader["bitCommerceEnabed"];
                usUserLoc.bolProductionEnabed = (Boolean)drDataReader["bitProductionEnabed"];
                usUserLoc.bolTechnicalEnabed = (Boolean)drDataReader["bitTechnicalEnabed"];
                usUserLoc.bolStoreEnabed = (Boolean)drDataReader["bitStoreEnabed"];
                usUserLoc.bolLabEnabed = (Boolean)drDataReader["bitLabEnabed"];

                bolResultLoc = true;
            }
            else
            {
                bolResultLoc = false;
            }

            drDataReader.Close();
         
            cmUsers.CommandText = string.Format("UPDATE tabUsers SET bitLogined=1 WHERE intID={0}", usUserLoc.intID);

            if (cmUsers.ExecuteNonQuery() >= 1)
            {
                usUserLoc.bolLogined = true;
                bolResultLoc = true;
            }
            else
            {
                bolResultLoc = false;
            }
            scConnection.Close();

            return bolResultLoc;
        }
        public bool Logout(Connection cnConnection)
        {
            bool bolResultLoc = false;

            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmUsers = new SqlCommand();

            cmUsers.Connection = cnSqlConnection;
            cmUsers.CommandText = string.Format("UPDATE tabUsers SET bitLogined=0 WHERE intID={0}", this.intID);

            cnSqlConnection.Open();
            if (cmUsers.ExecuteNonQuery() >= 1)
            {
                this.intID = 0;
                this.strCoID = "";
                this.strUsername = "";
                this.strPassword = "";
                this.bolLogined = false;
                this.bolOfficeEnabed = false;
                this.bolFinanceEnabed = false;
                this.bolCommerceEnabed = false;
                this.bolProductionEnabed = false;
                this.bolTechnicalEnabed = false;
                this.bolStoreEnabed = false;
                this.bolLabEnabed = false;

                bolResultLoc = true;
            }
            else
            {
                bolResultLoc = false;
            }
            cnSqlConnection.Close();

            return bolResultLoc;
        }
        public static bool AnyUserIsLogined(Connection cnConnection)
        {
            bool bolResultLoc;

            SqlConnection ScConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmUsers = new SqlCommand();

            cmUsers.Connection = ScConnection;
            cmUsers.CommandText = "SELECT intID FROM tabUsers WHERE bitLogined=1";

            ScConnection.Open();
            SqlDataReader drDataReader = cmUsers.ExecuteReader();

            if (drDataReader.Read())
            {
                bolResultLoc = true;
            }
            else
            {
                bolResultLoc = false;
            }

            drDataReader.Close();
            ScConnection.Close();

            return bolResultLoc;
        }

        //Insert The Object in Sql Server DataBase
        protected Boolean Insert()
        {
            Boolean bolResult = false;

            return bolResult;
        }
        //Update The Object in Sql Server DataBase
        protected Boolean Update()
        {
            Boolean bolResult = false;

            return bolResult;
        }
        //Delete The Object from Sql Server DataBase
        protected Boolean Delete()
        {
            Boolean bolResult = false;

            return bolResult;
        }
        //Override ToString

    }
}

