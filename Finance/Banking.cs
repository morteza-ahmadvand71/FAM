using Baran.Ferroalloy.Automation.SqlDataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Finance
{
    public class Banking
    {
        public int intID;
        public string strBankName;
        public string strBankAccount;
        public string strBankShaba;
        public string strBankAtmCard;

        public Banking()
        {
            this.intID = 0;
            this.strBankName = "";
            this.strBankAccount = "";
            this.strBankShaba = "";
            this.strBankAtmCard = "";
        }
        public static DataTable GetBankNames(Connection cnConnection)
        {
            DataTable dtBankNames = new DataTable();

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);

            SqlCommand comBankNames = new SqlCommand();
            comBankNames.Connection = scConnection;
            comBankNames.CommandText = @"SELECT * FROM tabBanks";

            SqlDataAdapter daBankNames = new SqlDataAdapter();
            daBankNames.SelectCommand = comBankNames;

            scConnection.Open();
            daBankNames.Fill(dtBankNames);
            scConnection.Close();

            return dtBankNames;
        }
    }
   
}
