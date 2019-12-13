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
    public class StoreCode
    {
        public struct Store
        {
            public int intID;
            public string strName;
            public string strCode;
        }

        public struct Section
        {
            public int intID;
            public string strStore;
            public string strName;
            public string strCode;
        }

        public struct Material
        {
            public int intID;
            public string strStore;
            public string strSection;
            public string strName;
            public string strCode;
        }

        public struct Type
        {
            public int intID;
            public string strStore;
            public string strSection;
            public string strMaterial;
            public string strName;
            public string strCode;
        }

        public static Store[] GetStores(Connection cnConnection)
        {
            Store[] stStores;
            Int16 intRowsCount = 0;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffStores = new SqlCommand("SELECT * FROM tabStuffStores ORDER BY nvcName", scConnection);

            scConnection.Open();
            SqlDataReader drDataReader = cmStuffStores.ExecuteReader();
            while (drDataReader.Read())
            {
                ++intRowsCount;
            }
            drDataReader.Close();

            stStores = new Store[intRowsCount];
            drDataReader = cmStuffStores.ExecuteReader();
            intRowsCount = 0;
            while (drDataReader.Read())
            {
                stStores[intRowsCount] = new Store();
                stStores[intRowsCount].intID = (int)drDataReader["intID"];
                stStores[intRowsCount].strName = drDataReader["nvcName"].ToString();
                stStores[intRowsCount].strCode = drDataReader["nvcCode"].ToString();
                ++intRowsCount;
            }

            return stStores;
        }
        public static DataSet GetStoresAsDataSet(Connection cnConnection)
        {
            DataSet dsStores = new DataSet();

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffStores = new SqlCommand("SELECT * FROM tabStuffStores ORDER BY nvcName", scConnection);

            SqlDataAdapter daStores = new SqlDataAdapter();
            daStores.SelectCommand = cmStuffStores;
            daStores.Fill(dsStores, "tabStuffStores");

            return dsStores;
        }
        public static String GetStoreCodeByName(Connection cnConnection, String strNameArg)
        {
            String strCodeLoc = "";

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffStores = new SqlCommand("SELECT * FROM tabStuffStores WHERE nvcName =N'" + strNameArg + "'", scConnection);

            scConnection.Open();
            SqlDataReader drStuffStores = cmStuffStores.ExecuteReader();

            while (drStuffStores.Read())
            {
                strCodeLoc = drStuffStores["nvcCode"].ToString();
            }

            drStuffStores.Close();
            scConnection.Close();

            return strCodeLoc;
        }
        public static String GetStoreNameByCode(Connection cnConnection, String strCodeArg)
        {
            String strNameLoc = "";

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffStores = new SqlCommand("SELECT * FROM tabStuffStores WHERE nvcCode ='" + strCodeArg + "'", scConnection);
            
            scConnection.Open();
            SqlDataReader drStuffStores = cmStuffStores.ExecuteReader();

            while (drStuffStores.Read())
            {
                strNameLoc = drStuffStores["nvcName"].ToString();
            }

            drStuffStores.Close();
            scConnection.Close();

            return strNameLoc;
        }
        public static bool StoreDelete(Connection cnConnection,int intIdArg)
        {
            bool bolResultLoc = false;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStores = new SqlCommand();
            cmStores.CommandText = "DELETE FROM tabStuffStores WHERE intID=" + intIdArg.ToString();
            cmStores.Connection = scConnection;

            scConnection.Open();
            if (cmStores.ExecuteNonQuery() >= 1)
            {
                bolResultLoc = true;
            }
            scConnection.Close();

            return bolResultLoc;
        }
        public static string StoreNextCode(Connection cnConnection)
        {
            string strNextCode = "";
            
            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffStores = new SqlCommand("SELECT MAX(nvcCode) FROM tabStuffStores", scConnection);

            scConnection.Open();
            strNextCode = cmStuffStores.ExecuteScalar().ToString();

            if (strNextCode == "")
            {
                strNextCode = "0";
            }
            strNextCode = (int.Parse(strNextCode) + 1).ToString();
            scConnection.Close();

            return strNextCode;
        }
        public static bool StoreInsert(Connection cnConnection, string strNameArg)
        {
            bool bolResultLoc = false;
            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStores = new SqlCommand();
            cmStores.Connection = scConnection;
            cmStores.CommandText = @"INSERT INTO tabStuffStores (nvcName, nvcCode) VALUES (N'" +
                strNameArg + "','" +
                StoreNextCode(cnConnection) + "')";

            scConnection.Open();
            if(cmStores.ExecuteNonQuery() >= 1)
            {
                bolResultLoc = true;
            }
            scConnection.Close();

            return bolResultLoc;
        }
        public static bool StoreUpdate(Connection cnConnection, Store stStoreArg)
        {
            bool bolResultLoc = false;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStores = new SqlCommand();

            cmStores.Connection = scConnection;
            cmStores.CommandText = "UPDATE tabStuffStores SET " +
                "nvcName=N'" + stStoreArg.strName + "' " +
                "WHERE intID=" + stStoreArg.intID.ToString();

            scConnection.Open();
            if(cmStores.ExecuteNonQuery() >= 1)
            {
                bolResultLoc = true;
            }
            scConnection.Close();

            return bolResultLoc;
        }

        public static Section[] GetSections(Connection cnConnection,string strStoreArg)
        {
            Section[] seSections;
            Int16 intRowsCount = 0;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffStores = new SqlCommand("SELECT * FROM tabStuffSections WHERE nvcStore='" + strStoreArg + "' ORDER BY nvcName", scConnection);

            scConnection.Open();
            SqlDataReader drDataReader = cmStuffStores.ExecuteReader();
            while (drDataReader.Read())
            {
                ++intRowsCount;
            }
            drDataReader.Close();

            seSections = new Section[intRowsCount];
            drDataReader = cmStuffStores.ExecuteReader();
            intRowsCount = 0;
            while (drDataReader.Read())
            {
                seSections[intRowsCount] = new Section();
                seSections[intRowsCount].intID = (int)drDataReader["intID"];
                seSections[intRowsCount].strStore = drDataReader["nvcStore"].ToString();
                seSections[intRowsCount].strName = drDataReader["nvcName"].ToString();
                seSections[intRowsCount].strCode = drDataReader["nvcCode"].ToString();
                ++intRowsCount;
            }

            return seSections;
        }
        public static DataSet GetSectionsAsDataSet(Connection cnConnection, string strStoreArg)
        {
            DataSet dsSections = new DataSet();

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffSections = new SqlCommand();

            cmStuffSections.Connection = scConnection;
            cmStuffSections.CommandText = "SELECT * FROM tabStuffSections WHERE nvcStore=" + strStoreArg + " ORDER BY nvcName";

            SqlDataAdapter daStuffSections = new SqlDataAdapter(cmStuffSections);
            daStuffSections.Fill(dsSections, "tabStuffSections");

            return dsSections;
        }
        public static String GetSectionCodeByName(Connection cnConnection, string strStoreArg, String strNameArg)
        {
            String strCodeLoc = "";

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffStores = new SqlCommand();
            cmStuffStores.Connection = scConnection;
            cmStuffStores.CommandText = "SELECT * FROM tabStuffSections WHERE nvcStore='" + strStoreArg + "' AND nvcName=N'" + strNameArg + "'";

            scConnection.Open();
            SqlDataReader drStuffStores = cmStuffStores.ExecuteReader();

            while (drStuffStores.Read())
            {
                strCodeLoc = drStuffStores["nvcCode"].ToString();
            }

            drStuffStores.Close();
            scConnection.Close();

            return strCodeLoc;
        }
        public static String GetSectionNameByCode(Connection cnConnection, string strStoreArg, String strCodeArg)
        {
            String strNameLoc = "";

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffStores = new SqlCommand();
            cmStuffStores.Connection = scConnection;
            cmStuffStores.CommandText = "SELECT * FROM tabStuffSections WHERE nvcStore='" + strStoreArg + "' AND nvcCode ='" + strCodeArg + "'";

            scConnection.Open();
            SqlDataReader drStuffStores = cmStuffStores.ExecuteReader();

            while (drStuffStores.Read())
            {
                strNameLoc = drStuffStores["nvcName"].ToString();
            }

            drStuffStores.Close();
            scConnection.Close();

            return strNameLoc;
        }
        public static bool SectionDelete(Connection cnConnection, int intIdArg)
        {
            bool bolResultLoc = false;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStores = new SqlCommand();
            cmStores.CommandText = "DELETE FROM tabStuffSections WHERE intID=" + intIdArg.ToString();
            cmStores.Connection = scConnection;

            scConnection.Open();
            if (cmStores.ExecuteNonQuery() >= 1)
            {
                bolResultLoc = true;
            }
            scConnection.Close();

            return bolResultLoc;
        }
        public static string SectionNextCode(Connection cnConnection, string strStoreArg)
        {
            string strNextCode = "";

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffStores = new SqlCommand("SELECT MAX(nvcCode) FROM tabStuffSections WHERE nvcStore='" + strStoreArg + "'", scConnection);
            
            scConnection.Open();
            strNextCode = cmStuffStores.ExecuteScalar().ToString();

            if (strNextCode == "")
            {
                strNextCode = "0";
            }
            strNextCode = (int.Parse(strNextCode) + 1).ToString();
            strNextCode = strNextCode.PadLeft(2, '0');
            scConnection.Close();

            return strNextCode;
        }
        public static bool SectionInsert(Connection cnConnection, Section seSectionArg)
        {
            bool bolResultLoc = false;
            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStores = new SqlCommand();
            cmStores.Connection = scConnection;
            cmStores.CommandText = @"INSERT INTO tabStuffSections (nvcStore, nvcName, nvcCode) VALUES ('" +
                seSectionArg.strStore + "',N'" +
                seSectionArg.strName + "','" +
                SectionNextCode(cnConnection, seSectionArg.strStore) + "')";

            scConnection.Open();
            if (cmStores.ExecuteNonQuery() >= 1)
            {
                bolResultLoc = true;
            }
            scConnection.Close();

            return bolResultLoc;
        }
        public static bool SectionUpdate(Connection cnConnection, Section seSectionArg)
        {
            bool bolResultLoc = false;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStores = new SqlCommand();

            cmStores.Connection = scConnection;
            cmStores.CommandText = "UPDATE tabStuffSections SET " +
                "nvcName=N'" + seSectionArg.strName + "' " +
                "WHERE intID=" + seSectionArg.intID.ToString();

            scConnection.Open();
            if (cmStores.ExecuteNonQuery() >= 1)
            {
                bolResultLoc = true;
            }
            scConnection.Close();

            return bolResultLoc;
        }

        public static Material[] GetMaterials(Connection cnConnection, string strStoreArg, string strSectionArg)
        {
            Material[] maMaterials;
            Int16 intRowsCount = 0;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffStores = new SqlCommand();
            cmStuffStores.CommandText = "SELECT * FROM tabStuffMaterials WHERE nvcStore='" + strStoreArg + "' AND nvcSection='" + strSectionArg + "' ORDER BY nvcName";
            cmStuffStores.Connection = scConnection;

            scConnection.Open();
            SqlDataReader drDataReader = cmStuffStores.ExecuteReader();
            while (drDataReader.Read())
            {
                ++intRowsCount;
            }
            drDataReader.Close();

            maMaterials = new Material[intRowsCount];
            drDataReader = cmStuffStores.ExecuteReader();
            intRowsCount = 0;
            while (drDataReader.Read())
            {
                maMaterials[intRowsCount] = new Material();
                maMaterials[intRowsCount].intID = (int)drDataReader["intID"];
                maMaterials[intRowsCount].strStore = drDataReader["nvcStore"].ToString();
                maMaterials[intRowsCount].strSection = drDataReader["nvcSection"].ToString();
                maMaterials[intRowsCount].strName = drDataReader["nvcName"].ToString();
                maMaterials[intRowsCount].strCode = drDataReader["nvcCode"].ToString();
                ++intRowsCount;
            }

            return maMaterials;
        }
        public static DataSet GetMaterialsAsDataSet(Connection cnConnection, Material maSearchArg)
        {
            DataSet dsMaterials = new DataSet();

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmMaterials = new SqlCommand();

            cmMaterials.Connection = scConnection;
            cmMaterials.CommandText = "SELECT * FROM tabStuffMaterials WHERE "+
                "nvcStore='" + maSearchArg.strStore + 
                "' AND nvcSection='" + maSearchArg.strSection +
                "' ORDER BY nvcName";

            SqlDataAdapter daStuffMaterials = new SqlDataAdapter(cmMaterials);
            daStuffMaterials.Fill(dsMaterials, "tabStuffMaterials");

            return dsMaterials;
        }
        public static String GetMaterialCodeByName(Connection cnConnection, string strStoreArg, string strSectionArg, String strNameArg)
        {
            String strCodeLoc = "";

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffStores = new SqlCommand();
            cmStuffStores.Connection = scConnection;
            cmStuffStores.CommandText = "SELECT * FROM tabStuffMaterials WHERE nvcStore='" + strStoreArg + "' AND nvcSection='" +
                strSectionArg + "' AND nvcName = N'" + strNameArg + "'";

            scConnection.Open();
            SqlDataReader drStuffStores = cmStuffStores.ExecuteReader();

            while (drStuffStores.Read())
            {
                strCodeLoc = drStuffStores["nvcCode"].ToString();
            }

            drStuffStores.Close();
            scConnection.Close();

            return strCodeLoc;
        }
        public static String GetMaterialNameByCode(Connection cnConnection, string strStoreArg, string strSectionArg, String strCodeArg)
        {
            String strNameLoc = "";

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffStores = new SqlCommand();
            cmStuffStores.Connection = scConnection;
            cmStuffStores.CommandText = "SELECT * FROM tabStuffMaterials WHERE nvcStore='" + strStoreArg + "' AND nvcSection='" +
                strSectionArg + "' AND nvcCode = '" + strCodeArg + "'";

            scConnection.Open();
            SqlDataReader drStuffStores = cmStuffStores.ExecuteReader();

            while (drStuffStores.Read())
            {
                strNameLoc = drStuffStores["nvcName"].ToString();
            }

            drStuffStores.Close();
            scConnection.Close();

            return strNameLoc;
        }
        public static string MaterialNextCode(Connection cnConnection, Material maSearchArg)
        {
            string strNextCode = "";

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffStores = new SqlCommand();

            cmStuffStores.Connection = scConnection;
            cmStuffStores.CommandText = "SELECT MAX(nvcCode) FROM tabStuffMaterials WHERE " +
                "nvcStore='" + maSearchArg.strStore + 
                "' AND nvcSection='" + maSearchArg.strSection + "'";

           

            scConnection.Open();
            strNextCode = cmStuffStores.ExecuteScalar().ToString();

            if (strNextCode == "")
            {
                strNextCode = "0";
            }
            strNextCode = (int.Parse(strNextCode) + 1).ToString();
            strNextCode = strNextCode.PadLeft(2, '0');

            scConnection.Close();

            return strNextCode;
        }
        public static bool MaterialDelete(Connection cnConnection, int intIdArg)
        {
            bool bolResultLoc = false;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStores = new SqlCommand();
            cmStores.CommandText = "DELETE FROM tabStuffMaterials WHERE intID=" + intIdArg.ToString();
            cmStores.Connection = scConnection;

            scConnection.Open();
            if (cmStores.ExecuteNonQuery() >= 1)
            {
                bolResultLoc = true;
            }
            scConnection.Close();

            return bolResultLoc;
        }
        public static bool MaterialInsert(Connection cnConnection, Material seSectionArg)
        {
            bool bolResultLoc = false;
            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmMaterials = new SqlCommand();
            cmMaterials.Connection = scConnection;
            cmMaterials.CommandText = @"INSERT INTO tabStuffMaterials (nvcStore, nvcSection, nvcName, nvcCode) VALUES ('" +
                seSectionArg.strStore + "','" +
                seSectionArg.strSection + "',N'" +
                seSectionArg.strName + "','" +
                MaterialNextCode(cnConnection, seSectionArg) + "')";

            scConnection.Open();
            if (cmMaterials.ExecuteNonQuery() >= 1)
            {
                bolResultLoc = true;
            }
            scConnection.Close();

            return bolResultLoc;
        }
        public static bool MaterialUpdate(Connection cnConnection, Material seSectionArg)
        {
            bool bolResultLoc = false;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmMaterials = new SqlCommand();

            cmMaterials.Connection = scConnection;
            cmMaterials.CommandText = "UPDATE tabStuffMaterials SET " +
                "nvcName=N'" + seSectionArg.strName + "' " +
                "WHERE intID=" + seSectionArg.intID.ToString();

            scConnection.Open();
            if (cmMaterials.ExecuteNonQuery() >= 1)
            {
                bolResultLoc = true;
            }
            scConnection.Close();

            return bolResultLoc;
        }

        public static Type[] GetTypes(Connection cnConnection, string strStoreArg, string strSectionArg, string strMaterialArg)
        {
            Type[] tyTypes;
            Int16 intRowsCount = 0;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffStores = new SqlCommand();
            cmStuffStores.Connection = scConnection;
            cmStuffStores.CommandText = "SELECT * FROM tabStuffTypes WHERE " +
                "nvcStore='" + strStoreArg + "' AND " +
                "nvcSection='" + strSectionArg + "' AND " +
                "nvcMaterial='" + strMaterialArg + "' ORDER BY nvcName";

            scConnection.Open();
            SqlDataReader drDataReader = cmStuffStores.ExecuteReader();
            while (drDataReader.Read())
            {
                ++intRowsCount;
            }
            drDataReader.Close();

            tyTypes = new Type[intRowsCount];
            drDataReader = cmStuffStores.ExecuteReader();
            intRowsCount = 0;
            while (drDataReader.Read())
            {
                tyTypes[intRowsCount] = new Type();
                tyTypes[intRowsCount].intID = (int)drDataReader["intID"];
                tyTypes[intRowsCount].strStore = drDataReader["nvcStore"].ToString();
                tyTypes[intRowsCount].strSection = drDataReader["nvcSection"].ToString();
                tyTypes[intRowsCount].strMaterial = drDataReader["nvcMaterial"].ToString();
                tyTypes[intRowsCount].strName = drDataReader["nvcName"].ToString();
                tyTypes[intRowsCount].strCode = drDataReader["nvcCode"].ToString();
                ++intRowsCount;
            }

            return tyTypes;
        }
        public static DataSet GetTypesAsDataSet(Connection cnConnection, Type tyTypeArg)
        {
            DataSet dsTypes = new DataSet();

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmMaterials = new SqlCommand();

            cmMaterials.Connection = scConnection;
            cmMaterials.CommandText = "SELECT * FROM tabStuffTypes WHERE " +
                "nvcStore='" + tyTypeArg.strStore +
                "' AND nvcSection='" + tyTypeArg.strSection +
                "' AND nvcMaterial='" + tyTypeArg.strMaterial +
                "' ORDER BY nvcName";

            SqlDataAdapter daStuffTypes = new SqlDataAdapter(cmMaterials);
            daStuffTypes.Fill(dsTypes, "tabStuffTypes");

            return dsTypes;
        }
        public static String GetTypeCodeByName(Connection cnConnection, string strStoreArg, string strSectionArg, string strMaterialArg, String strNameArg)
        {
            String strCodeLoc = "";

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffStores = new SqlCommand();
            cmStuffStores.Connection = scConnection;
            cmStuffStores.CommandText = "SELECT * FROM tabStuffTypes WHERE " +
                "nvcStore='" + strStoreArg + "' AND " +
                "nvcSection='" + strSectionArg + "' AND " +
                "nvcMaterial='" + strMaterialArg + "' AND " +
                "nvcName='" + strNameArg + "'";

            scConnection.Open();
            SqlDataReader drStuffStores = cmStuffStores.ExecuteReader();

            while (drStuffStores.Read())
            {
                strCodeLoc = drStuffStores["nvcCode"].ToString();
            }

            drStuffStores.Close();
            scConnection.Close();

            return strCodeLoc;
        }
        public static String GetTypeNameByCode(Connection cnConnection, string strStoreArg, string strSectionArg, string strMaterialArg, String strCodeArg)
        {
            String strNameLoc = "";

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffStores = new SqlCommand();
            cmStuffStores.Connection = scConnection;
            cmStuffStores.CommandText = "SELECT * FROM tabStuffTypes WHERE " +
                "nvcStore='" + strStoreArg + "' AND " +
                "nvcSection='" + strSectionArg + "' AND " +
                "nvcMaterial='" + strMaterialArg + "' AND " +
                "nvcCode='" + strCodeArg + "'";

            scConnection.Open();
            SqlDataReader drStuffStores = cmStuffStores.ExecuteReader();

            while (drStuffStores.Read())
            {
                strNameLoc = drStuffStores["nvcName"].ToString();
            }

            drStuffStores.Close();
            scConnection.Close();

            return strNameLoc;
        }
        public static string TypeNextCode(Connection cnConnection, Type tyTypeArg)
        {
            string strNextCode = "";

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmStuffStores = new SqlCommand();

            cmStuffStores.Connection = scConnection;
            cmStuffStores.CommandText = "SELECT MAX(nvcCode) FROM tabStuffTypes WHERE " +
                 "nvcStore='" + tyTypeArg.strStore +
                 "' AND nvcSection='" + tyTypeArg.strSection +
                 "' AND nvcMaterial='" + tyTypeArg.strMaterial + "'";


            scConnection.Open();
            strNextCode = cmStuffStores.ExecuteScalar().ToString();

            if (strNextCode == "")
            {
                strNextCode = "0";
            }
            strNextCode = (int.Parse(strNextCode) + 1).ToString();
            strNextCode = strNextCode.PadLeft(3, '0');

            scConnection.Close();

            return strNextCode;
        }
        public static bool TypeDelete(Connection cnConnection, int intIdArg)
        {
            bool bolResultLoc = false;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmTypes = new SqlCommand();
            cmTypes.CommandText = "DELETE FROM tabStuffTypes WHERE intID=" + intIdArg.ToString();
            cmTypes.Connection = scConnection;

            scConnection.Open();
            if (cmTypes.ExecuteNonQuery() >= 1)
            {
                bolResultLoc = true;
            }
            scConnection.Close();

            return bolResultLoc;
        }
        public static bool TypeInsert(Connection cnConnection, Type tyTypeArg)
        {
            bool bolResultLoc = false;
            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmTypes = new SqlCommand();
            cmTypes.Connection = scConnection;
            cmTypes.CommandText = @"INSERT INTO tabStuffTypes (nvcStore, nvcSection,nvcMaterial, nvcName, nvcCode) VALUES ('" +
                tyTypeArg.strStore + "','" +
                tyTypeArg.strSection + "','" +
                tyTypeArg.strMaterial + "',N'" +
                tyTypeArg.strName + "','" +
                TypeNextCode(cnConnection, tyTypeArg) + "')";

            scConnection.Open();
            if (cmTypes.ExecuteNonQuery() >= 1)
            {
                bolResultLoc = true;
            }
            scConnection.Close();

            return bolResultLoc;
        }
        public static bool TypeUpdate(Connection cnConnection, Type tyTypeArg)
        {
            bool bolResultLoc = false;

            SqlConnection scConnection = new SqlConnection(cnConnection.strConnectionStringPty);
            SqlCommand cmTypes = new SqlCommand();

            cmTypes.Connection = scConnection;
            cmTypes.CommandText = "UPDATE tabStuffTypes SET " +
                "nvcName=N'" + tyTypeArg.strName + "' " +
                "WHERE intID=" + tyTypeArg.intID.ToString();

            scConnection.Open();
            if (cmTypes.ExecuteNonQuery() >= 1)
            {
                bolResultLoc = true;
            }
            scConnection.Close();

            return bolResultLoc;
        }

        public static string GetMaterialTypeFromStoreCode(Connection cnConnection,string strStoreCode)
        {
            string strMaterialType;
            string strStore = strStoreCode.Split('-')[0];
            string strSection = strStoreCode.Split('-')[1];
            string strMaterial = strStoreCode.Split('-')[2];
            string strType = strStoreCode.Split('-')[3];

            strMaterialType = GetMaterialNameByCode(cnConnection, strStore, strSection, strMaterial) + " - " +
                GetTypeNameByCode(cnConnection, strStore, strSection, strMaterial,strType);

            return strMaterialType;
        }
        public static string GetNameByStoreCode(Connection cnConnection, string strStoreCodeArg)
        {
            string strNameLoc = "";
            string[] strStoreCodeArryLoc = strStoreCodeArg.Split('-');

            string strMaterialLoc = GetMaterialNameByCode(cnConnection, strStoreCodeArryLoc[0], strStoreCodeArryLoc[1], strStoreCodeArryLoc[2]);
            string strTypeLoc = GetTypeNameByCode(cnConnection, strStoreCodeArryLoc[0], strStoreCodeArryLoc[1], strStoreCodeArryLoc[2], strStoreCodeArryLoc[3]);
            strNameLoc = string.Format("{0}-{1}", strMaterialLoc, strTypeLoc);

            return strNameLoc;
        }

    }
}
