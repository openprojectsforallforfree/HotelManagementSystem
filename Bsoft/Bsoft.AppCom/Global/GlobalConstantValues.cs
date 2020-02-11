using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
 
using Bsoft.Common;
using Friuts;
using Bsoft.Data;
namespace Bsoft.AppCom
{
    public static class ConstantValues
    {
        public static string Org_Name
        {
            get { return ConstantValuesUtility.GetData("Org_Name"); }
            set { ConstantValuesUtility.SetData("Org_Name", value); }
        }
        public static string Org_Phone
        {
            get { return ConstantValuesUtility.GetData("Org_Phone"); }
            set { ConstantValuesUtility.SetData("Org_Phone", value); }
        }
        public static string Org_Fax
        {
            get { return ConstantValuesUtility.GetData("Org_Fax"); }
            set { ConstantValuesUtility.SetData("Org_Fax", value); }
        }
        public static string Org_Url
        {
            get { return ConstantValuesUtility.GetData("Org_Url"); }
            set { ConstantValuesUtility.SetData("Org_Url", value); }
        }
        public static string Org_Email
        {
            get { return ConstantValuesUtility.GetData("Org_Email"); }
            set { ConstantValuesUtility.SetData("Org_Email", value); }
        }
        public static string Org_PoBox
        {
            get { return ConstantValuesUtility.GetData("Org_PoBox"); }
            set { ConstantValuesUtility.SetData("Org_PoBox", value); }
        }
        public static string Org_Tole
        {
            get { return ConstantValuesUtility.GetData("Org_Tole"); }
            set { ConstantValuesUtility.SetData("Org_Tole", value); }
        }
        public static string Org_WardNo
        {
            get { return ConstantValuesUtility.GetData("Org_WardNo"); }
            set { ConstantValuesUtility.SetData("Org_WardNo", value); }
        }
        public static string Org_LocalBody
        {
            get { return ConstantValuesUtility.GetData("Org_LocalBody"); }
            set { ConstantValuesUtility.SetData("Org_LocalBody", value); }
        }
        public static string Org_District
        {
            get { return ConstantValuesUtility.GetData("Org_District"); }
            set { ConstantValuesUtility.SetData("Org_District", value); }
        }
        public static string Org_Zone
        {
            get { return ConstantValuesUtility.GetData("Org_Zone"); }
            set { ConstantValuesUtility.SetData("Org_Zone", value); }
        }
        public static string Org_Country
        {
            get { return ConstantValuesUtility.GetData("Org_Country"); }
            set { ConstantValuesUtility.SetData("Org_Country", value); }
        }
        public static int Org_DistrictId
        {
            get { return ConstantValuesUtility.GetData("Org_DistrictId").ToInt(); }
            set { ConstantValuesUtility.SetData("Org_DistrictId", value.ToString()); }
        }
        public static int Org_ZoneId
        {
            get { return ConstantValuesUtility.GetData("Org_ZoneId").ToInt(); }
            set { ConstantValuesUtility.SetData("Org_ZoneId", value.ToString()); }
        }
        public static int Org_LocalBodyId
        {
            get { return ConstantValuesUtility.GetData("Org_LocalBodyId").ToInt(); }
            set { ConstantValuesUtility.SetData("Org_LocalBodyId", value.ToString()); }
        }

        public static string  PANNo
        {
            get { return ConstantValuesUtility.GetData("Org_PANNo"); }
            set { ConstantValuesUtility.SetData("Org_PANNo", value.ToString()); }
        }
        public static string VATNo
        {
            get { return ConstantValuesUtility.GetData("VATNo"); }
            set { ConstantValuesUtility.SetData("VATNo", value.ToString()); }
        }

        public static string CurrentFiscalYearValue
        {
            get { return ConstantValuesUtility.GetData("CurrentFiscalYearValue"); }
            set { ConstantValuesUtility.SetData("CurrentFiscalYearValue", value); }
        }

        public static string RegistraionKey
        {
            get { return ConstantValuesUtility.GetData("RegistraionKey"); }
            set { ConstantValuesUtility.SetData("RegistraionKey", value); }
        }
        public static string BuildDetail
        {
            get { return ConstantValuesUtility.GetData("BuildDetail"); }
            set { ConstantValuesUtility.SetData("BuildDetail", value); }
        }
        public static string LastLoginDate
        {
            get { return ConstantValuesUtility.GetData("LastLoginDate"); }
            set { ConstantValuesUtility.SetData("LastLoginDate", value); }
        }
        public static int  UseCount
        {
            get { return ConstantValuesUtility.GetData("UseCount").ToInt (); }
            set { ConstantValuesUtility.SetData("UseCount", value.ToString ()); }
        }
        public static string _productName = "";
        public static string _productVersion= "";
        public static string ProductName
        {
            get { return _productName; }
            set { _productName= value; }
        }
        public static string ProductVersion
        {
            get { return _productVersion; }
            set { _productVersion = value; }
        }
        #region first key
        //public static string firstKey
        //{
        //    get
        //    {
        //        return ConstantValuesUtility.GetData("FirstKey");
        //    }
        //    set
        //    {
        //        ConstantValuesUtility.SetData("FirstKey", value.ToString());
        //    }
        //}

        //public static bool checkFirstKey
        //{
        //    get
        //    {
        //        // regkey = Properties.Settings.Default.RegistrationKey;
        //        Bsoft.Common.skgen bb = new Bsoft.Common.skgen();
        //        if ((bb.isFirstKeyMachine(firstKey)))
        //        { return true; }
        //        else { return false; }
        //    }
        //}

        #endregion
    }

    public static class ConstantValuesUtility
    {
        #region Constant Value select ,Insert & Update

        /// <summary>
        /// IF the the key does not exist new key is inserted 
        /// IF exists it is updated
        /// Uses constantvalues table
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool SetData(string key, string value)
        {
            key = key.ToUpper();
            bool status = false;
            DataTable dt = null;
            StringBuilder Sql = new StringBuilder();
            Sql.Append("SELECT ");
            Sql.Append("\n\tid, VariableName,  Value");
            Sql.Append("\nFROM");
            Sql.Append("\n\tSuperAdmin_ConstantValues");
            Sql.Append("\nWHERE");
            Sql.AppendFormat(" VariableName = '{0}'", key);

            dt = GlobalResources.SelectDBConnection.ExecuteDataTable(Sql.ToString());

            if (dt != null && dt.Rows != null && dt.Rows.Count > 0)
                UpdateConstantValues(key, value);
            else
                InsertConstantValues(key, value);

            return status;
        }
        private static bool InsertConstantValues(string VarName, string strValues)
        {
            VarName = VarName.ToUpper();
            string SQL = string.Format(@"
            INSERT INTO SuperAdmin_ConstantValues
            ( VariableName,  Value)
            VALUES
            ('{0}','{1}')
", VarName, strValues);

            int res = GlobalResources.SelectDBConnection.ExecuteNonQuery(SQL.ToString());
            if (res > 0)
            {
                return true;
            }
            return false;
        }
        private static bool UpdateConstantValues(string VarName, string StrValues)
        {
            VarName = VarName.ToUpper();
            StringBuilder SqlUPdate = new StringBuilder();
            SqlUPdate.Append("UPDATE SuperAdmin_ConstantValues SET ");
            SqlUPdate.AppendFormat("\n\t  Value = '{0}'", StrValues);
            SqlUPdate.Append("\n WHERE");
            SqlUPdate.AppendFormat("\n VariableName = '{1}'", StrValues, VarName.ToUpper().ToString());

            int res = GlobalResources.SelectDBConnection.ExecuteNonQuery(SqlUPdate.ToString());
            if (res > 0)
            {
                return true;
            }
            return false;
        }
        public static string GetData(string VarName)
        {
            VarName = VarName.ToUpper();
            string sql = string.Format("SELECT  Value FROM SuperAdmin_ConstantValues where VariableName='{0}'", VarName);
            string st = string.Empty;
            try
            {
                st = GlobalResources.SelectDBConnection.ExecuteScalar(sql.ToString()).ToString();
            }
            catch { }
            return st;
        }
        #endregion
    }
}
