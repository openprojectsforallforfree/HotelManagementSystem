using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Bsoft.Common;
using Bsoft.Data;

namespace UEMS.BLL
{
    public partial class ChangeDBStructure
    {
        private void CreateFiscalYearData()
        {
            StringBuilder SQLCreate = new StringBuilder();
           
            int Rslt = 0;

           
//            if (!GlobalResources.DbStruct.DoesTableExists("FiscalYears"))
//            {
//                createATable(@" 
//CREATE TABLE FiscalYears(
//Id Integer primary key autoincrement , 
//FiscalYear varchar(15),
//DateFrom varchar(15),
//DateTo varchar(15))
//");
//            }
            if (!GlobalResources.DbStruct.DoesTableExists("fiscalyears"))
            {
                SQLCreate.Remove(0, SQLCreate.Length);
                SQLCreate.Append("\n CREATE TABLE FISCALYEARS ( ");
                SQLCreate.Append("\n sn         NUMBER, ");
                SQLCreate.Append("\n FISCALYEAR VARCHAR2(9), ");
                SQLCreate.Append("\n datefrom   VARCHAR2(10),");
                SQLCreate.Append("\n dateto     VARCHAR2(10)");
                SQLCreate.Append("\n ) ");
                Rslt = GlobalResources.SelectDBConnection   .ExecuteNonQuery(SQLCreate.ToString());
                LogTrace.WriteInfoLog(base.GetType().Name, MethodBase.GetCurrentMethod().Name, "Fiscalyears table created Successfully. ");
             
                this.DefaultDataINsertInFiscalYear();
            }
            //else
            //{
                //SQLCreate.Remove(0, SQLCreate.Length);
                //SQLCreate.Append(" SELECT 1 FROM fiscalyears ");
                //if (GlobalResources.SelectDBConnection  .ExecuteDataTable(SQLCreate.ToString()).Rows.Count < 50)
                //{
                   
                //}
            //}

        }
        private void DefaultDataINsertInFiscalYear()
        {
            this.SQL.Remove(0, this.SQL.Length);
            this.SQL.Append("DELETE FROM fiscalyears");
            int del = GlobalResources.SelectDBConnection  .ExecuteNonQuery(this.SQL.ToString());
            int Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(1,'2016/2017','2016/04/01','2017/03/32')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(2,'2017/2018','2017/04/01','2018/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(3,'2018/2019','2018/04/01','2019/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(4,'2019/2020','2019/04/01','2020/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(5,'2020/2021','2020/04/01','2021/03/32')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(6,'2021/2022','2021/04/01','2022/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(7,'2022/2023','2022/04/01','2023/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(8,'2023/2024','2023/04/01','2024/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(9,'2024/2025','2024/04/01','2025/03/32')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(10,'2025/2026','2025/04/01','2026/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(11,'2026/2027','2026/04/01','2027/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(12,'2027/2028','2027/04/01','2028/03/32')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(13,'2028/2029','2028/04/01','2029/03/32')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(14,'2029/2030','2029/04/01','2030/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(15,'2030/2031','2030/04/01','2031/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(16,'2031/2032','2031/04/01','2032/03/32')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(17,'2032/2033','2032/04/01','2033/03/32')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(18,'2033/2034','2033/04/01','2034/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(19,'2034/2035','2034/04/01','2035/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(20,'2035/2036','2035/04/01','2036/03/32')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(21,'2036/2037','2036/04/01','2037/03/32')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(22,'2037/2038','2037/04/01','2038/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(23,'2038/2039','2038/04/01','2039/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(24,'2039/2040','2039/04/01','2040/03/32')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(25,'2040/2041','2040/04/01','2041/03/32')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(26,'2041/2042','2041/04/01','2042/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(27,'2042/2043','2042/04/01','2043/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(28,'2043/2044','2043/04/01','2044/03/32')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(29,'2044/2045','2044/04/01','2045/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(30,'2045/2046','2045/04/01','2046/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(31,'2046/2047','2046/04/01','2047/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(32,'2047/2048','2047/04/01','2048/03/32')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(33,'2048/2049','2048/04/01','2049/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(34,'2049/2050','2049/04/01','2050/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(35,'2050/2051','2050/04/01','2051/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(36,'2051/2052','2051/04/01','2052/03/32')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(37,'2052/2053','2052/04/01','2053/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(38,'2053/2054','2053/04/01','2054/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(39,'2054/2055','2054/04/01','2055/03/32')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(40,'2055/2056','2055/04/01','2056/03/32')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(41,'2056/2057','2056/04/01','2057/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(42,'2057/2058','2057/04/01','2058/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(43,'2058/2059','2058/04/01','2059/03/32')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(44,'2059/2060','2059/04/01','2060/03/32')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(45,'2060/2061','2060/04/01','2061/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(46,'2061/2062','2061/04/01','2062/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(47,'2062/2063','2062/04/01','2063/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(48,'2063/2064','2063/04/01','2064/03/32')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(50,'2065/2066','2065/04/01','2066/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(49,'2064/2065','2064/04/01','2065/03/31')");
            Rslt = GlobalResources.SelectDBConnection  .ExecuteNonQuery("insert into fiscalyears (sn,fiscalyear,datefrom,dateto) values(51,'2066/2067','2066/04/01','2067/03/31')");
        }
    }
}
