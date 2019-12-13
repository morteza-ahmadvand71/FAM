using Baran.Ferroalloy.Automation.SqlDataBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baran.Ferroalloy.Maintenance
{
    public class MeasurementUnit
    {
        public int intID;
        public string strCategory;
        public string strName;
        public string strCode;

        public MeasurementUnit()
        {

        }

        public static MeasurementUnit[] GetMeasurementUnits(Connection cnConnection)
        {
            MeasurementUnit[] cuCountsUnit;
            Int16 intRowsCount = 0;

            SqlConnection cnSqlConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmCommand = new SqlCommand("SELECT * FROM tabMeasurementUnits", cnSqlConnection);

            cnSqlConnection.Open();
            SqlDataReader drDataReader = cmCommand.ExecuteReader();
            while (drDataReader.Read())
            {
                ++intRowsCount;
            }
            drDataReader.Close();

            cuCountsUnit = new MeasurementUnit[intRowsCount];
            drDataReader = cmCommand.ExecuteReader();
            intRowsCount = 0;
            while (drDataReader.Read())
            {
                cuCountsUnit[intRowsCount] = new MeasurementUnit();
                cuCountsUnit[intRowsCount].strName = drDataReader["nvcName"].ToString();
                cuCountsUnit[intRowsCount].strCode = drDataReader["nvcCode"].ToString();
                ++intRowsCount;
            }

            return cuCountsUnit;
        }
        public static MeasurementUnit[] GetMeasurementUnits(Connection cnConnection,int intCategoryArg)
        {
            MeasurementUnit[] cuCountsUnit;
            Int16 intRowsCount = 0;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmMeasurementUnits = new SqlCommand();

            cmMeasurementUnits.Connection = scConnection;
            cmMeasurementUnits.CommandText = String.Format("SELECT * FROM tabMeasurementUnits WHERE intCategory={0}",intCategoryArg);

            scConnection.Open();
            SqlDataReader drDataReader = cmMeasurementUnits.ExecuteReader();
            while (drDataReader.Read())
            {
                ++intRowsCount;
            }
            drDataReader.Close();

            cuCountsUnit = new MeasurementUnit[intRowsCount];
            drDataReader = cmMeasurementUnits.ExecuteReader();
            intRowsCount = 0;
            while (drDataReader.Read())
            {
                cuCountsUnit[intRowsCount] = new MeasurementUnit();
                cuCountsUnit[intRowsCount].strName = drDataReader["nvcName"].ToString();
                cuCountsUnit[intRowsCount].strCode = drDataReader["nvcCode"].ToString();
                ++intRowsCount;
            }

            return cuCountsUnit;
        }
        public static String GetCodeByName(Connection cnConnection, String strEquipountsunitName)
        {
            String strEquipountsunitCodeLoc = "";

            SqlConnection cnPart = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmPart = new SqlCommand("SELECT * FROM tabMeasurementUnits WHERE nvcName=N'" + strEquipountsunitName + "'", cnPart);
           
            cnPart.Open();
            SqlDataReader drPart = cmPart.ExecuteReader();
            while (drPart.Read())
            {
                strEquipountsunitCodeLoc = drPart["nvcCode"].ToString();
            }

            drPart.Close();
            cnPart.Close();

            return strEquipountsunitCodeLoc;
        }
        public static String GetNameByCode(Connection cnConnection, String strEquipountsunitCode)
        {
            String strEquipountsunitNameLoc = "";

            SqlConnection cnPart = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmPart = new SqlCommand("SELECT * FROM tabMeasurementUnits WHERE nvcCode=N'" + strEquipountsunitCode + "'", cnPart);
            //MessageBox.Show(cmPart.CommandText);
            cnPart.Open();
            SqlDataReader drPart = cmPart.ExecuteReader();
            while (drPart.Read())
            {
                strEquipountsunitNameLoc = drPart["nvcName"].ToString();
            }

            drPart.Close();
            cnPart.Close();

            return strEquipountsunitNameLoc;
        }
    }
}
