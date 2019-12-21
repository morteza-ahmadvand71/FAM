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
    public class CurrentAffairs
    {
        public int intID;
        public int intNumber;
        public string strName;
        
        public CurrentAffairs()
        {
            this.intID = 0;
            this.intNumber = 0;
            this.strName = "";
        }

        public static DataSet GetCurrentAffairs(Connection cnConnectionArg)
        {
            DataSet dsCurrentAffairs = new DataSet();

            SqlConnection scConnection = new SqlConnection(cnConnectionArg.strConnectionStringPty);
            SqlCommand comCurrentAffairs = new SqlCommand();
            comCurrentAffairs.Connection = scConnection;
            comCurrentAffairs.CommandText = "SELECT * FROM tabCurrentAffairs";
            SqlDataAdapter daCurrentAffairs = new SqlDataAdapter(comCurrentAffairs);
            scConnection.Open();
            daCurrentAffairs.Fill(dsCurrentAffairs, "tabCurrentAffairs");
            scConnection.Close();

            return dsCurrentAffairs;
        }

        public static String GetNameByNumber(Connection cnConnection, int intNumberArg)
        {
            String strNameLoc = "";

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmCurrentAffairs = new SqlCommand("SELECT * FROM tabCurrentAffairs WHERE intNumber =" + intNumberArg.ToString() + "", scConnection);

            scConnection.Open();
            SqlDataReader drProjects = cmCurrentAffairs.ExecuteReader();

            while (drProjects.Read())
            {
                strNameLoc = drProjects["nvcName"].ToString();
            }

            drProjects.Close();
            scConnection.Close();

            return strNameLoc;
        }
    }
}
