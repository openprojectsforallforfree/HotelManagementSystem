using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
using Bsoft.Common;
using System.Reflection;
using Bsoft.Data;
using System.Windows.Forms;
 

namespace Bsoft.Data
{
    public static class DbHelpers
    {
        public static void CreateATable(string Query)
        {
            string tableName = "";
            tableName = Query.Substring(0, Query.IndexOf('(')).ToLower();
            tableName = tableName.Replace("create", "");
            tableName = tableName.Replace("table", "");
            tableName = tableName.Trim();
            StringBuilder SQLCreate = new StringBuilder();

            int Rslt = 0;

            Rslt = GlobalResources.SelectDBConnection.ExecuteNonQuery(Query);
            if (Rslt != -1)
                LogTrace.WriteInfoLog("AppComm", MethodBase.GetCurrentMethod().Name, tableName + " table created Successfully. ");
            else
            {
                MessageBox.Show(tableName + " could not be created");
                LogTrace.WriteInfoLog("AppComm", MethodBase.GetCurrentMethod().Name, "Not created ==================>" + tableName + "  ");
            }

        }

        public  static  void createAView(string viewName, string SelectQuery)
        {
            StringBuilder SQLCreateView = new StringBuilder();

            int Rslt = 0;
           
            SQLCreateView.Append(" CREATE view " + viewName + " as  ");
            SQLCreateView.Append(SelectQuery);
            Rslt = GlobalResources.SelectDBConnection.ExecuteNonQuery(SQLCreateView.ToString());
            if (Rslt != -1)
                LogTrace.WriteInfoLog("AppComm", MethodBase.GetCurrentMethod().Name, viewName + " view created Successfully. ");
            else
            {
                MessageBox.Show(viewName + " could not be created");
                LogTrace.WriteInfoLog("AppComm", MethodBase.GetCurrentMethod().Name, "View Not created ==================>" + viewName + "  ");
            }
        }
    }
}
