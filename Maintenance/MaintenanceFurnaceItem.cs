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
    public class MaintenanceFurnaceItem
    {
        public struct ItemEquip
        {
            public int intID;
            public int intTabItemsID;
            public String strStoreCode;
            public Double dobAmount;
        }

        public struct ItemPerson
        {
            public int intID;
            public int intTabItemsID;
            public String strPersonCoID;
        }

        private int intID;
        private int intTabShiftID;
        private TimeSpan tsTime;
        private String strEquipTag;
        private TimeSpan tsDuration;
        private String strTip;

        public int intIDPty
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
        public int intTabShiftIDPty
        {
            get
            {
                return this.intTabShiftID;
            }
            set
            {
                this.intTabShiftID = value;
            }
        }
       
        public TimeSpan tsTimePty
        {
            get
            {
                return this.tsTime;
            }
            set
            {
                this.tsTime = value;
            }
        }
        public String strEquipTagPty
        {
            get
            {
                return this.strEquipTag;
            }
            set
            {
                this.strEquipTag = value;
            }
        }
        public TimeSpan tsDurationPty
        {
            get
            {
                return this.tsDuration;
            }
            set
            {
                this.tsDuration = value;
            }
        }
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

        public MaintenanceFurnaceItem()
        {
            this.intIDPty = -1;
            this.intTabShiftIDPty = -1;
            this.tsTimePty = new TimeSpan();
            this.strEquipTagPty = "";
            this.tsDurationPty = new TimeSpan();
            this.strTipPty = "";
        }

        public int Insert(Connection cnConnection)
        {
            int intIdLoc = -1;
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmMaintenancefurnaceShift = new SqlCommand();
            cmMaintenancefurnaceShift.CommandText =
                @"INSERT INTO tabMaintenanceFurnaceItems (intTabShiftID,timTime,nvcEquipTag,timDuration,nvcTip) VALUES (" +
                this.intTabShiftIDPty.ToString() + ",'" +
                this.tsTimePty.ToString() + "','" +
                this.strEquipTagPty + "','" +
                this.tsDurationPty.ToString() + "','" +
                this.strTipPty + "')";
            cmMaintenancefurnaceShift.Connection = cnSqlConnection;
            cnSqlConnection.Open();
            if(cmMaintenancefurnaceShift.ExecuteNonQuery() != 0)
            {
                cmMaintenancefurnaceShift.CommandText = "SELECT MAX(intID) FROM tabMaintenanceFurnaceItems";
                intIdLoc = (int)cmMaintenancefurnaceShift.ExecuteScalar();
            }
            cnSqlConnection.Close();

            return intIdLoc;
        }

        public int Update(Connection cnConnection)
        {
            int intIdLoc = -1;
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmMaintenancefurnaceShift = new SqlCommand();
            cmMaintenancefurnaceShift.CommandText =
                @"UPDATE tabMaintenanceFurnaceItems SET " +
                "timTime = '" + this.tsTimePty.ToString() + "'," +
                "nvcEquipTag = '" + this.strEquipTagPty + "'," +
                "timDuration = '" + this.tsDurationPty.ToString() + "'," +
                "nvcTip = '" + this.strTipPty + 
                "' WHERE intID = " + this.intIDPty.ToString();
            cmMaintenancefurnaceShift.Connection = cnSqlConnection;
            cnSqlConnection.Open();
            cmMaintenancefurnaceShift.ExecuteNonQuery();
            cnSqlConnection.Close();

            return intIdLoc;
        }

        public static void InsertItemEquip(Connection cnConnection, DataSet dsItemEquipArg)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmEquip = new SqlCommand();
            cmEquip.Connection = cnSqlConnection;
           

            cnSqlConnection.Open();
            foreach (DataRow drItemEquip in dsItemEquipArg.Tables["tabMaintenanceFurnaceEquips"].Rows)
            {
                if (drItemEquip.RowState != DataRowState.Deleted)
                {
                    cmEquip.CommandText = @"INSERT INTO tabMaintenanceFurnaceEquips (intTabItemsID,nvcStoreCode,floAmount) VALUES (";
                    cmEquip.CommandText +=
                        drItemEquip["intTabItemsID"].ToString() + ",'" +
                        drItemEquip["nvcStoreCode"].ToString() + "'," +
                        drItemEquip["floAmount"].ToString() + ")";
                    cmEquip.ExecuteNonQuery();
                }
            }
        }

        public static void InsertItemPerson(Connection cnConnection, DataSet dsItemPersonArg)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmPerson = new SqlCommand();
            cmPerson.Connection = cnSqlConnection;


            cnSqlConnection.Open();
            foreach (DataRow drItemEquip in dsItemPersonArg.Tables["tabMaintenanceFurnacePersons"].Rows)
            {
                if (drItemEquip.RowState != DataRowState.Deleted)
                {
                    cmPerson.CommandText = @"INSERT INTO tabMaintenanceFurnacePersons (intTabItemsID,nvcPersonCoID) VALUES (";
                    cmPerson.CommandText +=
                        drItemEquip["intTabItemsID"].ToString() + ",'" +
                        drItemEquip["nvcPersonCoID"].ToString() + "')";
                    cmPerson.ExecuteNonQuery();
                }
            }
        }

        public static DataSet GetMFIs(Connection cnConnection, MaintenanceFurnaceItem mfiItem, String strStoreCodeArg,String strPersonCoIDArg)
        {
            DataSet dsMaintenancefurnaceItems = new DataSet();

            String strCommand = @"SELECT * FROM tabMaintenanceFurnaceItems";

            if ((mfiItem.strEquipTagPty.Length != 0) || (mfiItem.strTipPty.Length != 0) || (mfiItem.intIDPty != -1) || (mfiItem.intTabShiftIDPty != -1) ||
                (strPersonCoIDArg.Length != 0) || (strStoreCodeArg.Length != 0))
            {
                strCommand += @" WHERE ";
            }

            if (mfiItem.strEquipTagPty.Length != 0)
            {
                strCommand += @"nvcEquipTag = '" + mfiItem.strEquipTagPty + "' ";
            }

            if (mfiItem.strTipPty.Length != 0)
            {
                if (mfiItem.strEquipTagPty.Length != 0)
                {
                    strCommand += @"AND nvcTip LIKE N'%" + mfiItem.strTipPty + "%' ";
                }
                else
                {
                    strCommand += @" nvcTip LIKE N'%" + mfiItem.strTipPty + "%' ";
                }
            }

            if (mfiItem.intIDPty != -1)
            {
                if (mfiItem.strEquipTagPty.Length != 0 || mfiItem.strTipPty.Length != 0)
                {
                    strCommand += @" AND intID = " + mfiItem.intIDPty.ToString();
                }
                else
                {
                    strCommand += @" intID = " + mfiItem.intIDPty.ToString();
                }
            }

            if (mfiItem.intTabShiftIDPty != -1)
            {
                if (mfiItem.strEquipTagPty.Length != 0 || mfiItem.strTipPty.Length != 0 || mfiItem.intIDPty != -1)
                {
                    strCommand += @" AND intTabShiftID = " + mfiItem.intTabShiftIDPty.ToString();
                }
                else
                {
                    strCommand += @" intTabShiftID = " + mfiItem.intTabShiftIDPty.ToString();
                }
            }

            if (strPersonCoIDArg.Length != 0)
            {
                if (mfiItem.strEquipTagPty.Length != 0 || mfiItem.strTipPty.Length != 0 || mfiItem.intIDPty != -1 || mfiItem.intTabShiftIDPty != -1)
                {
                    strCommand += @" AND intID IN (Select intTabItemsID From tabMaintenanceFurnacePersons WHERE nvcPersonCoID='" + strPersonCoIDArg + "')";
                }
                else
                {
                    strCommand += @" intID IN (Select intTabItemsID From tabMaintenanceFurnacePersons WHERE nvcPersonCoID='" + strPersonCoIDArg + "')";
                }
            }

            if (strStoreCodeArg.Length != 0)
            {
                if (mfiItem.strEquipTagPty.Length != 0 || mfiItem.strTipPty.Length != 0 || mfiItem.intIDPty != -1 || mfiItem.intTabShiftIDPty != -1 || strPersonCoIDArg.Length != 0)
                {
                    strCommand += @" AND intID IN (Select intTabItemsID From tabMaintenanceFurnaceEquips WHERE nvcStoreCode='" + strStoreCodeArg + "')";
                }
                else
                {
                    strCommand += @" intID IN (Select intTabItemsID From tabMaintenanceFurnaceEquips WHERE nvcStoreCode='" + strStoreCodeArg + "')";
                }
            }

            //MessageBox.Show(strCommand);
            //Create a SqlDataAdapter for the Suppliers table.
            SqlDataAdapter daMaintenancefurnaceItems = new SqlDataAdapter();

            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            cnSqlConnection.Open();
            daMaintenancefurnaceItems.SelectCommand = new SqlCommand(strCommand, cnSqlConnection);
            daMaintenancefurnaceItems.Fill(dsMaintenancefurnaceItems, "tabMaintenanceFurnaceItems");
            cnSqlConnection.Close();

            return dsMaintenancefurnaceItems;
        }

        public static void DeleteItems(Connection cnConnection, DataSet dsItems)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmCommand = new SqlCommand();
            cmCommand.Connection = cnSqlConnection;
            cnSqlConnection.Open();

            foreach (DataRow drItem in dsItems.Tables["tabMaintenanceFurnaceItems"].Rows)
            {
                if ((Boolean)drItem["bitSelect"])
                {
                    cmCommand.CommandText = @"DELETE FROM tabMaintenanceFurnaceItems WHERE intID = ";
                    cmCommand.CommandText += drItem["intID"].ToString();
                    cmCommand.ExecuteNonQuery();
                }
            }

            cnSqlConnection.Close();
        }

        public static DataSet GetItemPersons(Connection cnConnection,int intIDArg)
        {
            DataSet dsItemPersons = new DataSet();

            String strCommand = @"SELECT * FROM tabMaintenanceFurnacePersons WHERE intTabItemsID = " + intIDArg.ToString();
            //Create a SqlDataAdapter for the Suppliers table.
            SqlDataAdapter daItemPersons = new SqlDataAdapter();

            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            cnSqlConnection.Open();
            daItemPersons.SelectCommand = new SqlCommand(strCommand, cnSqlConnection);
            daItemPersons.Fill(dsItemPersons, "tabMaintenanceFurnacePersons");
            cnSqlConnection.Close();

            return dsItemPersons;
        }

        public static DataSet GetItemEquips(Connection cnConnection, int intIDArg)
        {
            DataSet dsItemEquips = new DataSet();

            String strCommand = @"SELECT * FROM tabMaintenanceFurnaceEquips WHERE intTabItemsID = " + intIDArg.ToString();
            //Create a SqlDataAdapter for the Suppliers table.
            SqlDataAdapter daItemEquips = new SqlDataAdapter();

            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            cnSqlConnection.Open();
            daItemEquips.SelectCommand = new SqlCommand(strCommand, cnSqlConnection);
            daItemEquips.Fill(dsItemEquips, "tabMaintenanceFurnaceEquips");
            cnSqlConnection.Close();
            
            return dsItemEquips;
        }

        public static void DeleteItemPerson(Connection cnConnection, DataSet dsPrsonsArg)
        {
            
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmCommand = new SqlCommand();
            cmCommand.Connection = cnSqlConnection;
            cnSqlConnection.Open();

            foreach (DataRow drPerson in dsPrsonsArg.Tables["tabMaintenanceFurnacePersons"].Rows)
            {
                cmCommand.CommandText = @"DELETE FROM tabMaintenanceFurnacePersons WHERE intID = ";
                cmCommand.CommandText += drPerson["intID"].ToString();
                cmCommand.ExecuteNonQuery();
            }

            cnSqlConnection.Close();
        }

        public static void DeleteItemEquips(Connection cnConnection, DataSet dsEquipsArg)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmCommand = new SqlCommand();
            cmCommand.Connection = cnSqlConnection;
            cnSqlConnection.Open();

            foreach (DataRow drEquip in dsEquipsArg.Tables["tabMaintenanceFurnaceEquips"].Rows)
            {
                cmCommand.CommandText = @"DELETE FROM tabMaintenanceFurnaceEquips WHERE intID = ";
                cmCommand.CommandText += drEquip["intID"].ToString();
                cmCommand.ExecuteNonQuery();
            }

            cnSqlConnection.Close();
        }
    }
}
