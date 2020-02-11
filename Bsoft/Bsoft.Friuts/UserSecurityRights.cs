using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Bsoft .Controls ;
using Bsoft;
 
using Bsoft.Common;
using Bsoft.Data;
namespace Friuts
{
    public class UserSecurityRights
    {

        #region Member variables.
        

        #endregion

        #region Constructors & Finalizers.

        #endregion

        #region Public Properti
        #endregion

        #region Security rights Methods
        /// <summary>
        /// Pass the rights name if user rights is available the value is true 
        /// other wise retur false
        /// </summary>
        /// <param name="MenuRightsName"></param>
        /// <returns></returns>
        public bool UserSecurityRight(string MenuRightsName, string loginUserSN )
        {

            string rightsName = string.Empty;
            rightsName = MenuRightsName.ToString();
            StringBuilder Sql = new StringBuilder();


            //Checking ADMIN Username yes or no
            DataTable rsAdmin = null;
            StringBuilder adm = new StringBuilder();

            adm.Append("SELECT UserID FROM UserMaster ");
            adm.Append("\n WHERE ");
            adm.AppendFormat("\n SN = {0}", loginUserSN);
            rsAdmin = GlobalResources.SelectDBConnection.ExecuteDataTable(adm.ToString());
            if (rsAdmin.Rows.Count > 0)
            {
                if (rsAdmin.Rows[0]["UserID"].ToString().ToUpper().Equals("ADMIN"))
                {
                    return true;
                }
            }

            //IF ADMIN USER NOT ...
            Sql.Append("SELECT 1 FROM tbUserSecurityRights"); 
            Sql.Append("\nWHERE ");
            Sql.Append("\nRightsID IN ( SELECT SN FROM UserAssignments ");
            Sql.Append("\nWHERE ");
            Sql.AppendFormat("\n\t RightsName = '{0}'", rightsName);
            Sql.Append(" )");
            Sql.AppendFormat("\n\t AND UserID = '{0}'", loginUserSN);
            
            DataTable rs = null;
            rs = GlobalResources.SelectDBConnection.ExecuteDataTable(Sql.ToString());
            if (rs.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        
        public bool UserSecurityRight(string MenuRightsName, int loginUserSN, string Module)
        {

            string rightsName = string.Empty;
            rightsName = MenuRightsName.ToString();
            StringBuilder Sql = new StringBuilder();

            //Checking ADMIN Username yes or no
            DataTable rsAdmin = null;
            StringBuilder adm = new StringBuilder();

            adm.Append("SELECT UserID FROM UserMaster ");
            adm.Append("\n WHERE ");
            adm.AppendFormat("\n SN = {0}", loginUserSN);
            rsAdmin = GlobalResources.SelectDBConnection.ExecuteDataTable(adm.ToString());
            if (rsAdmin.Rows.Count > 0)
            {
                if (rsAdmin.Rows[0]["UserID"].ToString().ToUpper().Equals("ADMIN"))
                {
                    return true;
                }
            }
            
            //IF NOT ADMIN USER ONLY
            Sql.Append("SELECT 1 FROM tbUserSecurityRights");
            Sql.Append("\nWHERE ");
            Sql.Append("\nRightsID IN ( SELECT SN FROM UserAssignments ");
            Sql.Append("\nWHERE ");
            Sql.AppendFormat("\n\t RightsName = '{0}'", rightsName);
            Sql.AppendFormat("\n AND MODULE = '{0}'", Module);
            Sql.Append(" )");
            
            Sql.AppendFormat("\n\t AND UserID = '{0}'", loginUserSN);

            DataTable rs = null;
            rs = GlobalResources.SelectDBConnection.ExecuteDataTable(Sql.ToString());
            if (rs.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public DataTable RightsListDataTable (int LoginUserSN, string Module)
        {
            if (LoginUserSN < 1)
            {
                return null;
            }
            DataTable dt = null;
            StringBuilder Sql = new StringBuilder();
            
            Sql.Append(" SELECT UserID, RightsID, RightsName  FROM tbUserSecurityRights S ");
            Sql.Append("\n LEFT JOIN UserAssignments R ON s.rightsID = R.SN ");
            Sql.AppendFormat("\n WHERE UserID = {0}", LoginUserSN);
            if (Module.Trim() == "")
            {
                Sql.Append("\n AND MODULE IS NULL "); //FOR ipt PROJCET MODULE TYPEIS NULL 
            }
            else
            {
                Sql.AppendFormat("\n AND MODULE = '{0}'", Module);
            }
            dt = GlobalResources.SelectDBConnection.ExecuteDataTable(Sql.ToString());
            return dt;
        }

        public bool RightsEnabledDisabled( DataTable dt, string MenuRightsName)
        {
            if (dt.Rows.Count < 1)
            {
                return false;
            }
            DataRow[] Rows = null;
            Rows = dt.Select(string.Format("RightsName = '{0}'", MenuRightsName));
            if (Rows.Length > 0)
            {
                return true;
            }
            return false;
        }


        
        #endregion
    }
}
