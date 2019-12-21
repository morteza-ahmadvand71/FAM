using Baran.Ferroalloy.Automation.SqlDataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Office
{
    public class Post
    {
        public static string GetNameByNumber(Connection cnConnection, int intNumberArg)
        {
            String strNameLoc = "";
           
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmEmployee = new SqlCommand();
            
            cmEmployee.CommandText = string.Format("SELECT * FROM tabPosts WHERE intNumber={0}",intNumberArg);
            cmEmployee.Connection = cnSqlConnection;

            cnSqlConnection.Open();

            SqlDataReader drPost = cmEmployee.ExecuteReader();

            while (drPost.Read())
            {
                strNameLoc = drPost["nvcName"].ToString();
            }

            drPost.Close();
            cnSqlConnection.Close();

            return strNameLoc;
        } 
    }
}
