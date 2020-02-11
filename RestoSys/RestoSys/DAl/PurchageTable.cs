using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bsoft.Common;
using System.Data;
using Bsoft.Data;

namespace RestoSys.BLL
{
    class PurchageTable
    {

        public static void InsertORUpdatePurchase(string productId, string costprice, string sellingprice, int quantity)
        {

            string sql = @"select count(*) from Inv_Purchase WHERE fk_Product = {0} ".With(productId);

            if (GlobalResources.SelectDBConnection.ExecuteScalar (sql).ToInt () > 0)
            {
                UpdatePurchase(productId, costprice, sellingprice, quantity);
            }
            else
            {
                InsertPurchase(productId, costprice, sellingprice, quantity);
            }


        }

        public static void InsertPurchase(string productId, string costprice, string sellingprice, int quantity)
        {
            string sql = @"INSERT INTO Inv_Purchase 
                    (
                    ManufactureDate,
                    ExpiryDate,
                    fk_Product,
                    fk_Vendor,
                    Quantity,
                    CostPrice,
                    SellingPrice,
                    PurchageDate,
                    Remarks,
                    UserId,
                    entrydate
                    )  
                    VALUES
                    (
                    NULL,NULL,{0},NULL,
                    {1},{2},{3},'{4}',
                    '',1,'{5}'
                    )".With(productId,
                      quantity.ToString(), costprice, sellingprice, DateTime.Now.ToString("yyyyMMdd"),
                      DateTime.Now.ToString("yyyyMMdd"));

            GlobalResources.SelectDBConnection.ExecuteNonQuery(sql );
        }

        public static void UpdatePurchase(string productId, string costprice, string sellingprice, int quantity)
        {
            string sql = @"UPDATE Inv_Purchase SET  
                            Quantity = {1}, 
                            CostPrice = {2}, 
                            SellingPrice = {3}, 
                            Remarks = '', 
                            entrydate = '{4}'   
                            WHERE fk_Product = {0} ".With(productId,
                      quantity.ToString(), costprice, sellingprice, DateTime.Now.ToString("yyyyMMdd"));

          int retval=  GlobalResources.SelectDBConnection.ExecuteNonQuery(sql);
        }
        public static string  GetProductId(string purchaseId)
        {
            string sql = @"SELECT fk_product from Inv_Purchase   
                            WHERE id = {0} ".With(purchaseId);

            return  GlobalResources.SelectDBConnection.ExecuteScalar (sql).ToString ();
        }


    }
}
