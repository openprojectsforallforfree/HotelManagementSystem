using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsoft.Data;
using System.Data;
using Bsoft.Common;

namespace RestoSys.DAl
{
    class ProductDAL
    {
        public static DataTable GetProduct(string id)
        {
            string SQL = string.Format("select name As Name,'Rs ' || sellingprice as 'Rate' ,remarks as Remarks    from master_product where id = '{0}'", id);
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(SQL.ToString());
            return dt;
        }
        public static string  GetProductRate(string id)
        {
            string SQL = string.Format("select sellingprice as 'Rate'  from master_product where id = '{0}'", id);
            return  GlobalResources.SelectDBConnection.ExecuteScalar (SQL.ToString()).ToString ();
           
        }
        public static string GetProductName(string Id)
        {
            string name = "";
            try
            {
                StringBuilder SQL = new StringBuilder();
                SQL.Append(string.Format("SELECT name from Master_Product where id ='{0}'", Id));
                name = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
            }
            catch
            {
                throw;
            }
            return name;
        }

        public static string GetProductType(string Id)
        {
            string name = "";
            try
            {
                StringBuilder SQL = new StringBuilder();
                SQL.Append(string.Format("SELECT ItemTypeCode from ProductFrmView where id ='{0}'", Id));
                name = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
            }
            catch
            {
                throw;
            }
            return name;
        }

        public static bool  IsStockApplicatble(string Id)
        {
            if (GetProductType(Id).ToUpper() == "M")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public  static DataTable GetProductsSold(string productId, int noofdaysback)
        {
            string sql = string.Format(@"
                            select t1.id salesid,
                            Inv_Purchase.id as purchaseid  ,
                            t1.date as [Selling
                            Date],
                            cast (t1.quantity as decimal(10,2)) as Quantity,
                            cast (t1.salesreturn as decimal(10,2))  as [Sales
                            Return],
                            cast (t1.rate as decimal(10,2))  as MRP ,
                            cast (t1.discount as decimal(10,2)) as [Discount
                            Given],
                            cast (t1.netamount as decimal(10,2)) as Amount,
                            SuperAdmin_Rights_Users.ENGNAME as username ,
                            t1.remarks from Inv_Sale t1
                             left outer join Inv_Purchase on
                             Inv_Purchase.id = t1.fk_Purchage
                             left outer join Master_Product on
                             Master_Product.id = Inv_Purchase.fk_Product
                             left outer join SuperAdmin_Rights_Users on
                             SuperAdmin_Rights_Users.id = t1.UserId 
                             where t1.date >= '{0}'
                            AND t1.date <= '{1}'
                            and t1.fk_product = {2}
                        ", DateTime.Now.AddDays(-1 * noofdaysback).ToString("yyyyMMdd"),
                     DateTime.Now.ToString("yyyyMMdd"),
                    productId);
         return    GlobalResources.SelectDBConnection.ExecuteDataTable(sql);
        }

        public static DataTable GetProductWithStockRemaining(string productId)
        {
            string sql = "";
            if (IsStockApplicatble(productId))
            {
                sql = @"
                    SELECT 
                    PurchaseRptView.Inv_PurchaseId as purchaseid,
                    PurchaseRptView.Inv_Purchase_entrydate  as [Purchage Date],
                    cast (PurchaseRptView.MRP as decimal(10,2))  as MRP,
                    cast (PurchaseRptView.Cost  as decimal(10,2))  as costprice,
                    cast (PurchaseRptView.purchageQuantity  as decimal(10,2))  as QTY,
                    cast ( PurchaseRptView.SoldQuantity  as decimal(10,2))*-1 as SOLD ,
                    PurchaseRptView.stock   as Stock, 
                    PurchaseRptView.ManufactureDate as [Mnf Date],
                    PurchaseRptView.ExpiryDate  as [Ex Date], 
                    PurchaseRptView.VendorName [vendor Name],
                    PurchaseRptView.purchageRemarks  as  remarks from PurchaseRptView
                    where PurchaseRptView.ProductId ={0} and  stock > 0
                ".With(productId);
            }
            else
            {
                sql = @"
                   SELECT 
                    Name,
                    cast (sellingPrice as decimal(10,2))  as MRP,
                    cast (costPrice  as decimal(10,2))  as costprice from master_product
                    where Id = {0} 
                ".With(productId);
            }
           

            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(sql.ToString());
            return dt;
        }
    }
}
