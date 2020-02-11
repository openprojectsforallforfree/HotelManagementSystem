using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsoft.Common;
using System.Reflection;
using Bsoft.Data;

namespace UEMS.BLL 
{
    public partial class ChangeDBStructure
    {
        public void CreateGeneralDb()
        {
            StringBuilder SQLCreate = new StringBuilder();
          
            int Rslt = 0;
       
            if (!GlobalResources.DbStruct.DoesTableExists("OptionSex"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append(" CREATE TABLE OptionSex( ");
                SQLCreate.Append(" \n SN number PRIMARY KEY NOT NULL UNIQUE ");
                SQLCreate.Append(" \n, Nepname NVARCHAR2 (50)");
                SQLCreate.Append(" \n, EngName NVARCHAR2 (50))");
                Rslt = GlobalResources.SelectDBConnection   .ExecuteNonQuery(SQLCreate.ToString());
                LogTrace.WriteInfoLog(base.GetType().Name, MethodBase.GetCurrentMethod().Name, "OptionSex table created Successfully. ");
              
                Rslt = GlobalResources.SelectDBConnection   .ExecuteNonQuery("insert into OptionSex (sn,Nepname,engname) values(1,'पुरूष','Male')");
                Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into OptionSex (sn,Nepname,engname) values(2,'महिला','Female')");
                Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into OptionSex (sn,Nepname,engname) values(3,'अन्य','Other')");
            }
        }
    }
}
