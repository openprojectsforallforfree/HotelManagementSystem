using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsoft.Data;
using Bsoft.Common;

namespace RestoSys.MasterEntry
{
    class staticClasses
    {
        public static  string GetGroupCode(string groupId)
        {
          string code =  GlobalResources.SelectDBConnection.ExecuteScalar("select code from Master_Product_Group where id = {0} ".With(groupId )).ToString ()??"";
          return code;
        }
    }
}
