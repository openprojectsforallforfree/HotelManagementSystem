using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Bsoft.Data;
namespace RestoSys.BLL
{
    class ExpiryAlert
    {
        public static DataTable GetExpringItemsDetails(DateTime date)
        {
            string sql = string.Format(@"SELECT * FROM PurchaseRptView where ExpiryDate >= '{0}'", date.ToString("yyyyMMdd"));
             DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(sql);
            return dt;
        }
    }
}
