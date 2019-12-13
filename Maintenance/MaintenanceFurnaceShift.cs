using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Office;
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
    public class MaintenanceFurnaceShift
    {
       
        private int intID;
        private String strCaltegory;
        private DateTime dtDate;
        private ShiftInfo.Shift shiShift;
        private String strGroup;
        /// <summary>
        /// 
        /// </summary>
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
        public String strCaltegoryPty
        {
            get
            {
                return this.strCaltegory;
            }
            set
            {
                this.strCaltegory = value;
            }
        }
        public DateTime dtDatePty
        {
            get
            {
                return this.dtDate;
            }
            set
            {
                this.dtDate = value;
            }
        }
        public ShiftInfo.Shift shiShiftPty
        {
            get
            {
                return this.shiShift;
            }
            set
            {
                this.shiShift = value;
            }
        }
        public String strGroupPty
        {
            get
            {
                return this.strGroup;
            }
            set
            {
                this.strGroup = value;
            }
        }

        public MaintenanceFurnaceShift()
        {
            this.intIDPty = -1;
            this.dtDate = new DateTime();
            this.shiShiftPty = 0;
            this.strGroupPty = "";

        }
        public void Insert(Connection cnConnection)
        {
            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmMaintenancefurnaceShift = new SqlCommand();
            cmMaintenancefurnaceShift.CommandText = @"INSERT INTO tabMaintenanceFurnaceShifts(datDate,intCategory,nvcShift,nvcGroup) VALUES (" +
              "'" + this.dtDate.Year.ToString() + "-" + this.dtDate.Month.ToString() + "-" + this.dtDate.Day.ToString() + "'" +
              ",'" + this.strCaltegoryPty + "'" +
              "," + ((int)this.shiShiftPty).ToString() +
              "," + this.strGroupPty + ")";
            cmMaintenancefurnaceShift.Connection = cnSqlConnection;
            cnSqlConnection.Open();
            cmMaintenancefurnaceShift.ExecuteNonQuery();
            cnSqlConnection.Close();
        }
        /// <summary>
        /// Get MaintenanceFurnaceShifts Base on a MaintenanceFurnaceShift Boject and From and to DateTime
        /// </summary>
        public static DataSet GetMFSs(Connection cnConnection, 
            MaintenanceFurnaceShift mfsSearchArg,DateTime dtFromDate, DateTime dtToDate)
        {
            DataSet dsMaintenancefurnaceshifts = new DataSet();

            String strCommand = @"SELECT * FROM tabMaintenanceFurnaceShifts";

            if ((mfsSearchArg.intIDPty != -1) || (mfsSearchArg.dtDatePty.Year != 1 ) ||(mfsSearchArg.shiShiftPty != 0) || 
                (mfsSearchArg.strGroupPty.Length != 0) || (dtFromDate.Year != 1) || (dtToDate.Year != 1) || (mfsSearchArg.strCaltegoryPty.Length != 0))
            {
                strCommand += @" WHERE ";
            }

            if (mfsSearchArg.shiShiftPty != 0)
            {
                strCommand += @"nvcShift = '" + ((int)mfsSearchArg.shiShiftPty).ToString() + "' ";
            }

            if (mfsSearchArg.strGroupPty.Length != 0)
            {
                if (mfsSearchArg.shiShiftPty != 0)
                {
                    strCommand += @"AND nvcGroup = '" + mfsSearchArg.strGroupPty + "' ";
                }
                else
                {
                    strCommand += @"nvcGroup = '" + mfsSearchArg.strGroupPty + "' ";
                }
            }

            if (dtFromDate.Year != 1 && dtToDate.Year != 1)
            {
                if (mfsSearchArg.shiShiftPty != 0 || mfsSearchArg.strGroupPty.Length != 0)
                {
                    strCommand += @" AND datDate BETWEEN '" + dtFromDate.Year.ToString() + "-" + dtFromDate.Month.ToString() + "-" + dtFromDate.Day.ToString() + "' AND '" + dtToDate.Year.ToString() + "-" + dtToDate.Month.ToString() + "-" + dtToDate.Day.ToString() + "'";
                }
                else
                {
                    strCommand += @" datDate BETWEEN '" + dtFromDate.Year.ToString() + "-" + dtFromDate.Month.ToString() + "-" + dtFromDate.Day.ToString() + "' AND '" + dtToDate.Year.ToString() + "-" + dtToDate.Month.ToString() + "-" + dtToDate.Day.ToString() + "'";
                }
            }

            if (mfsSearchArg.intIDPty != -1)
            {
                if (mfsSearchArg.shiShiftPty != 0 || mfsSearchArg.strGroupPty.Length != 0 || (dtFromDate.Year != 1 && dtToDate.Year != 1))
                {
                    strCommand += @" AND intID = " + mfsSearchArg.intIDPty.ToString() + "";
                }
                else
                {
                    strCommand += @" intID = " + mfsSearchArg.intIDPty.ToString() + "";
                }
            }

            if (mfsSearchArg.dtDatePty.Year != 1)
            {
                if (mfsSearchArg.shiShiftPty != 0 || mfsSearchArg.strGroupPty.Length != 0 || (dtFromDate.Year != 1 && dtToDate.Year != 1) || mfsSearchArg.intIDPty != -1)
                {
                    strCommand += @" AND datDate = '" + mfsSearchArg.dtDatePty.Year.ToString() + "-" + mfsSearchArg.dtDatePty.Month.ToString() + "-" + mfsSearchArg.dtDatePty.Day.ToString() + "'";
                }
                else
                {
                    strCommand += @" datDate = '" + mfsSearchArg.dtDatePty.Year.ToString() + "-" + mfsSearchArg.dtDatePty.Month.ToString() + "-" + mfsSearchArg.dtDatePty.Day.ToString() + "'";
                }
            }

            if (mfsSearchArg.strCaltegoryPty.Length != 0)
            {
                if (mfsSearchArg.shiShiftPty != 0 || mfsSearchArg.strGroupPty.Length != 0 || (dtFromDate.Year != 1 && dtToDate.Year != 1) || mfsSearchArg.intIDPty != -1 || mfsSearchArg.dtDatePty.Year != 1)
                {
                    strCommand += @" AND intCategory = '" + mfsSearchArg.strCaltegoryPty + "'";
                }
                else
                {
                    strCommand += @" intCategory = '" + mfsSearchArg.strCaltegoryPty + "'";
                }
            }

            //Create a SqlDataAdapter for the Suppliers table.
            SqlDataAdapter daMaintenancefurnaceshifts = new SqlDataAdapter();

            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            cnSqlConnection.Open();
            daMaintenancefurnaceshifts.SelectCommand = new SqlCommand(strCommand, cnSqlConnection);
            daMaintenancefurnaceshifts.Fill(dsMaintenancefurnaceshifts, "tabMaintenanceFurnaceShifts");
            cnSqlConnection.Close();

            return dsMaintenancefurnaceshifts;
        }
        /// <summary>
        /// Get MaintenanceFurnaceShifts Base on a MaintenanceFurnaceShift Boject
        /// </summary>
        public static DataSet GetMFSs(Connection cnConnection,
            MaintenanceFurnaceShift mfsSearchArg)
        {
            DataSet dsMaintenancefurnaceshifts = new DataSet();

            String strCommand = @"SELECT * FROM tabMaintenanceFurnaceShifts";

            if ((mfsSearchArg.intIDPty != -1) || (mfsSearchArg.dtDatePty.Year != 1) || (mfsSearchArg.shiShiftPty != 0) ||
                (mfsSearchArg.strGroupPty.Length != 0))
            {
                strCommand += @" WHERE ";
            }

            if (mfsSearchArg.shiShiftPty != 0)
            {
                strCommand += @"nvcShift = '" + ((int)mfsSearchArg.shiShiftPty).ToString() + "' ";
            }

            if (mfsSearchArg.strGroupPty.Length != 0)
            {
                if (mfsSearchArg.shiShiftPty != 0)
                {
                    strCommand += @"AND nvcGroup = '" + mfsSearchArg.strGroupPty + "' ";
                }
                else
                {
                    strCommand += @"nvcGroup = '" + mfsSearchArg.strGroupPty + "' ";
                }
            }

            if (mfsSearchArg.intIDPty != -1)
            {
                if (mfsSearchArg.shiShiftPty != 0 || mfsSearchArg.strGroupPty.Length != 0 )
                {
                    strCommand += @" AND intID = " + mfsSearchArg.intIDPty.ToString() + "";
                }
                else
                {
                    strCommand += @" intID = " + mfsSearchArg.intIDPty.ToString() + "";
                }
            }

            if (mfsSearchArg.dtDatePty.Year != 1)
            {
                if (mfsSearchArg.shiShiftPty != 0 || mfsSearchArg.strGroupPty.Length != 0 || mfsSearchArg.intIDPty != -1)
                {
                    strCommand += @" AND datDate = '" + mfsSearchArg.dtDatePty.Year.ToString() + "-" + mfsSearchArg.dtDatePty.Month.ToString() + "-" + mfsSearchArg.dtDatePty.Day.ToString() + "'";
                }
                else
                {
                    strCommand += @" datDate = '" + mfsSearchArg.dtDatePty.Year.ToString() + "-" + mfsSearchArg.dtDatePty.Month.ToString() + "-" + mfsSearchArg.dtDatePty.Day.ToString() + "'";
                }
            }

            //MessageBox.Show(strCommand);
            //Create a SqlDataAdapter for the Suppliers table.
            SqlDataAdapter daMaintenancefurnaceshifts = new SqlDataAdapter();

            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            cnSqlConnection.Open();
            daMaintenancefurnaceshifts.SelectCommand = new SqlCommand(strCommand, cnSqlConnection);
            daMaintenancefurnaceshifts.Fill(dsMaintenancefurnaceshifts, "tabMaintenanceFurnaceShifts");
            cnSqlConnection.Close();

            return dsMaintenancefurnaceshifts;
        }
    }
}
