using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Baran.Ferroalloy.Automation.Security;
using System.Xml;

namespace Baran.Ferroalloy.Automation.SqlDataBase
{
    public class Connection
    {
        //Connection String of DataBase
        private String strConnectionString;
        
        //Connection String of DataBase
        public String strConnectionStringPty
        {
            get
            {
                return this.strConnectionString;
            }
            set
            {
                this.strConnectionString = value;
            }
        }
        //to Determinate Data Base is Connected. Read Only
        public void GetConnectionStatus()
        {
            SqlConnection ConConnectionLoc = new SqlConnection(this.strConnectionStringPty);

            try
            {
                ConConnectionLoc.Open();
            }
            catch
            {
                throw new ExceptionConnection("DataBase Isnt Ready");
            }
            finally
            {
                ConConnectionLoc.Close();
            }

        }

        //Constructor
        public Connection()
        {
            this.strConnectionStringPty = "";
        }
        public Connection(String strConntionString)
        {
            this.strConnectionStringPty = strConntionString;
        }
        public Connection(String strXmlFilePath, String strKeys)
        {
            String strConnectionStringLoc = "";

            //Set Keys for Encrypt and Decrypt
            Cryption.strKeys = ASCIIEncoding.ASCII.GetBytes(strKeys);

            XmlDocument xdSettings = new XmlDocument();
            xdSettings.Load(strXmlFilePath);

            XmlNode xnConnectionString = xdSettings.SelectSingleNode("/App/DataBase/ConnectionString");
            strConnectionStringLoc =
                "Data Source=" + xnConnectionString.Attributes["DataSource"].Value +
                ";Initial Catalog=" + xnConnectionString.Attributes["InitialCatalog"].Value +
                ";Persist Security Info=" + xnConnectionString.Attributes["PersistSecurityInfo"].Value +
                ";User ID=" + Cryption.Decrypt(xnConnectionString.Attributes["UserID"].Value) +
                ";Password=" + Cryption.Decrypt(xnConnectionString.Attributes["Password"].Value);

            this.strConnectionStringPty = strConnectionStringLoc;
        }
    }
    
}
