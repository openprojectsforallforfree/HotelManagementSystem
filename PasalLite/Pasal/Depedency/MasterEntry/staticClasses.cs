using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsoft.Data;
using Bsoft.Common;

namespace Pasal.MasterEntry
{
    class staticClasses
    {
        public static  string GetGroupCode(string groupId)
        {
          string code =  GlobalResources.SelectDBConnection.ExecuteScalar("select code from product_group_master where id = {0} ".With(groupId )).ToString ()??"";
          return code;
        }
    }
}
