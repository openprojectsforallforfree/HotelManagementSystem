using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsoft.Data;
using System.Data;
using Bsoft.Common;
using RestoSys.Hotel;

namespace RestoSys.DAl
{
    class CustomerDAL
    {
        /// <summary>
        /// CustomerDetails
        /// </summary>
        /// <param name="ItemId"></param>
        /// <returns></returns>
        public static string GetCustomerName(string Id)
        {
            string name = "";
            try
            {
                StringBuilder SQL = new StringBuilder();
                SQL.Append(string.Format("SELECT name || ' ' || lastname FROM Master_Customer where id='{0}'", Id));
                name = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
            }
            catch
            {
                throw;
            }
            return name;
        }

        public static decimal GetCustomerDiscount(string Id)
        {
            decimal discountPercent = 0;
            try
            {
                StringBuilder SQL = new StringBuilder();
                SQL.Append(string.Format("SELECT DiscountPercent FROM Master_CustomerType where id= (select fk_Master_CustomerType from Master_Customer where id = '{0}')", Id));
                discountPercent = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString().ToDecimal();
            }
            catch
            {
                throw;
            }
            return discountPercent;
        }

        public static string  GetCustomeType(string Id)
        {
            string  ctype ="";
            try
            {
                StringBuilder SQL = new StringBuilder();
                SQL.Append(string.Format("SELECT Title FROM Master_CustomerType where id= (select fk_Master_CustomerType from Master_Customer where id = '{0}')", Id));
                ctype = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
            }
            catch
            {
                throw;
            }
            return ctype;
        }

        public static DataTable GetCustomers()
        {
            try
            {
                StringBuilder SQL = new StringBuilder();
                SQL.Append("SELECT Id, name || ' ' || lastname as Name , Phone FROM Master_Customer");
                return GlobalResources.SelectDBConnection.ExecuteDataTable(SQL.ToString());
            }
            catch
            {
                throw;
            }
        }

        public static DataTable GetCurrentCustomers()
        {
            try
            {
                StringBuilder SQL = new StringBuilder();
                SQL.Append(@"SELECT distinct fk_master_customer as id,  CustomerName , IdNumber FROM 
(select * from Hotel_RoomSales_View
                        union all
select * from Hotel_ProductSales_View)  where dueamt>0");
                return GlobalResources.SelectDBConnection.ExecuteDataTable(SQL.ToString());
            }
            catch
            {
                throw;
            }
        }

        public static DataTable GetCurrentCustomers2()
        {
            try
            {
                StringBuilder SQL = new StringBuilder();
                SQL.Append(@"select fk_master_customer as id,customerName,ProductName, IdNumber from  
(select * from Hotel_RoomSales_View
                        union all
select * from Hotel_ProductSales_View)  where dueamt<>0 or outdate >= {0} or bookingstaus = '{1}' or bookingstaus = '{2}' order by id desc".With(DateTime.Now.ToString("yyyyMMdd"), BookingStatus.Booked, BookingStatus.Occupied));
                return GlobalResources.SelectDBConnection.ExecuteDataTable(SQL.ToString());
            }
            catch
            {
                throw;
            }
        }




    }
}
