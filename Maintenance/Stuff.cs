using Baran.Ferroalloy.Automation.SqlDataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baran.Ferroalloy.Maintenance
{
    public class Stuff
    {
        public int intID;
     
        public string strStore;
        public string strSection;
        public string strMaterial;
        public string strType;
        public int intCategory;
        public string strMeasurementUnit;
        public Double dobOrderPoint;
        public Double dobSupply;

        public string strStoreCode
        {
            get
            {
                return strStore + "-" + strSection + "-" + strMaterial + "-" + strType;
            }
        }
        //Constructor
        public Stuff()
        {
            this.strStore = "";
            this.strSection = "";
            this.strMaterial = "";
            this.strType = "";
            this.intCategory = 0;
            this.strMeasurementUnit = "";
            this.dobOrderPoint = 0;
            this.dobSupply = 0;
        }
        
        public static DataSet GetStuffs(Connection cnConnection, Stuff stSearchArg)
        {
            // A table mapping names the DataTable.
            DataSet dsStuffs = new DataSet();

            String strCommand = @"SELECT * FROM tabStuffs";

            if (stSearchArg.strStore.Length != 0 || stSearchArg.strSection.Length != 0 || stSearchArg.strMaterial.Length != 0 ||
                stSearchArg.strType.Length != 0 || stSearchArg.intCategory != 0 || stSearchArg.strMeasurementUnit.Length != 0 ||
                stSearchArg.dobOrderPoint  != 0 || stSearchArg.dobSupply != 0)
            {
                strCommand += @" WHERE ";
            }

            if (stSearchArg.strStore.Length != 0)
            {
                strCommand += @"nvcStore = '" + stSearchArg.strStore + "' ";
            }

            if (stSearchArg.strSection.Length != 0)
            {
                if (stSearchArg.strStore.Length != 0)
                {
                    strCommand += @"AND nvcSection = '" + stSearchArg.strSection + "' ";
                }
                else
                {
                    strCommand += @"nvcSection = '" + stSearchArg.strSection + "' ";
                }
            }

            if (stSearchArg.strMaterial.Length != 0)
            {
                if (stSearchArg.strStore.Length != 0 || stSearchArg.strSection.Length != 0)
                {
                    strCommand += @" AND nvcMaterial = '" + stSearchArg.strMaterial + "' ";
                }
                else
                {
                    strCommand += @"nvcMaterial = '" + stSearchArg.strMaterial + "'";
                }
            }

            if (stSearchArg.strType.Length != 0)
            {
                if (stSearchArg.strStore.Length != 0 || stSearchArg.strSection.Length != 0 || stSearchArg.strMaterial.Length != 0)
                {
                    strCommand += @" AND nvcType = '" + stSearchArg.strType + "' ";
                }
                else
                {
                    strCommand += @"nvcType = '" + stSearchArg.strType + "' ";
                }
            }

            if (stSearchArg.intCategory != 0)
            {
                if (stSearchArg.strStore.Length != 0 || stSearchArg.strSection.Length != 0 || stSearchArg.strMaterial.Length != 0 || 
                    stSearchArg.strType.Length != 0)
                {
                    strCommand += @" AND intCategory = '" + stSearchArg.intCategory + "' ";
                }
                else
                {
                    strCommand += @"intCategory = '" + stSearchArg.intCategory + "' ";
                }
            }

            if (stSearchArg.strMeasurementUnit.Length != 0)
            {
                if (stSearchArg.strStore.Length != 0 || stSearchArg.strSection.Length != 0 || stSearchArg.strMaterial.Length != 0 ||
                     stSearchArg.strType.Length != 0 || stSearchArg.intCategory != 0)
                {
                    strCommand += @" AND nvcMeasurementUnit = '" + stSearchArg.strMeasurementUnit + "' ";
                }
                else
                {
                    strCommand += @"nvcMeasurementUnit = '" + stSearchArg.strMeasurementUnit + "' ";
                }
            }

            if (stSearchArg.dobOrderPoint != 0)
            {
                if (stSearchArg.strStore.Length != 0 || stSearchArg.strSection.Length != 0 || stSearchArg.strMaterial.Length != 0 ||
                     stSearchArg.strType.Length != 0 || stSearchArg.intCategory != 0 || stSearchArg.strMeasurementUnit.Length != 0)
                {
                    strCommand += @" AND floOrderPoint = " + stSearchArg.dobOrderPoint.ToString() + " ";
                }
                else
                {
                    strCommand += @"floOrderPoint = " + stSearchArg.dobOrderPoint.ToString() + " ";
                }
            }

            if (stSearchArg.dobSupply != 0)
            {
                if (stSearchArg.strStore.Length != 0 || stSearchArg.strSection.Length != 0 || stSearchArg.strMaterial.Length != 0 ||
                     stSearchArg.strType.Length != 0 || stSearchArg.intCategory != 0 || stSearchArg.strMeasurementUnit.Length != 0 ||
                     stSearchArg.dobOrderPoint != 0)
                {
                    strCommand += @" AND floSupply = " + stSearchArg.dobSupply.ToString() + " ";
                }
                else
                {
                    strCommand += @"floSupply = " + stSearchArg.dobSupply.ToString() + " ";
                }
            }

            //Create a SqlDataAdapter for the Suppliers table.
            SqlDataAdapter daStuffs = new SqlDataAdapter();

            SqlConnection sqSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            sqSqlConnection.Open();
            daStuffs.SelectCommand = new SqlCommand(strCommand, sqSqlConnection);
            daStuffs.Fill(dsStuffs, "tabStuffs");
            sqSqlConnection.Close();

            return dsStuffs;
        }
        public static void DeleteStuffs(Connection cnConnection, DataSet dsParts)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmCommand = new SqlCommand();
            cmCommand.Connection = cnSqlConnection;
            cnSqlConnection.Open();

            foreach (DataRow drPart in dsParts.Tables["tabStuffs"].Rows)
            {
                if ((Boolean)drPart["bitSelect"])
                {
                    cmCommand.CommandText = @"DELETE FROM tabStuffs WHERE intID = ";
                    cmCommand.CommandText += drPart["intID"].ToString();
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
            cmCommand.CommandText = @"INSERT INTO tabStuffs (bitSelect, nvcStore, nvcSection, nvcMaterial, nvcType, intCategory, nvcMeasurementUnit, floOrderPoint, floSupply) VALUES (" +
               "0,'" +
                this.strStore + "','" +
                this.strSection + "','" +
                this.strMaterial + "','" +
                this.strType + "','" +
                this.intCategory + "','" +
                this.strMeasurementUnit + "'," +
                this.dobOrderPoint.ToString() + "," +
                this.dobSupply.ToString() + ")";
            
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
            cmCommand.CommandText = "UPDATE tabStuffs SET " +
                "nvcStore='" + this.strStore + "', " +
                "nvcSection='" + this.strSection + "', " +
                "nvcMaterial='" + this.strMaterial + "', " +
                "nvcType='" + this.strType + "', " +
                "intCategory='" + this.intCategory + "', " +
                "nvcMeasurementUnit='" + this.strMeasurementUnit + "', " +
                "floOrderPoint=" + this.dobOrderPoint.ToString() + ", " +
                "floSupply=" + this.dobSupply.ToString() + " " +
                "WHERE intID=" + this.intID.ToString();

            cnSqlConnection.Open();
            cmCommand.ExecuteNonQuery();
            cnSqlConnection.Close();
        }
        public static bool IsStuff(Connection cnConnection,string strStoreCodeArg)
        {
            bool bolResultLoc = false;
            string[] strStorCodeArraysLoc = strStoreCodeArg.Split('-');

            SqlConnection scSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffs = new SqlCommand();

            cmStuffs.Connection = scSqlConnection;
            cmStuffs.CommandText = "SELECT intID FROM tabStuffs WHERE " + 
                "nvcStore='" + strStorCodeArraysLoc[0] + "' AND " +
                "nvcSection='" + strStorCodeArraysLoc[1] + "' AND " +
                "nvcMaterial='" + strStorCodeArraysLoc[2] + "' AND " +
                "nvcType='" + strStorCodeArraysLoc[3] + "'";

            scSqlConnection.Open();
            SqlDataReader drStuffs = cmStuffs.ExecuteReader();
            if(drStuffs.Read())
            {
                bolResultLoc = true;
            }
            else
            {
                bolResultLoc = false;
            }
            scSqlConnection.Close();

            return bolResultLoc;
        }
        
    }
}
