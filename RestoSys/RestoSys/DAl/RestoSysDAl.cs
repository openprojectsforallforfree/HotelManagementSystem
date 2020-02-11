using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Bsoft.Data;
using Bsoft.Common;
using Bsoft.AppCom;
using RestoSys.BLL;
namespace RestoSys
{
    class RestoSysDAl
    {

        public static DataTable GetOrderTable()
        {
            string SQL = "select * from OrderTables";
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(SQL.ToString());
            return dt;
        }

        public static DataTable GetItemsForMenu()
        {
            string SQL = string.Format("select * from Master_Product_Group where fk_itemtype in ('{0}','{1}','{2}','{3}')",
                ItemType.Manufacture, ItemType.Retail, ItemType.Service, ItemType.Lend);
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(SQL.ToString());
            return dt;
        }

        public static DataTable GetItems(string itemGroupId)
        {
            string SQL = string.Format(@"select   p.Id productId , p.sellingPrice  rate,p.t1_Name  description,
p.t1_Code code,p.t1_Remarks remarks ,p.costPrice costprice
from ProductFrmView p where p.t1_fk_Group = {0} ", itemGroupId);
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(SQL.ToString());
            return dt;
        }
  


        public static decimal GetDiscountPercent(string customerId)
        {
            string sql = @"SELECT DISCOUNTPERCENT FROM Master_CustomerType CT 
                            LEFT JOIN Master_Customer CM
                            ON CM.FK_Master_CustomerType = CT.ID
                            WHERE CM.ID ={0}".With(customerId);

            string DISCOUNT = GlobalResources.SelectDBConnection.ExecuteScalar(sql).ToString();
            if (DISCOUNT != null)
            {
                return DISCOUNT.ToDecimal();
            }
            return 0;

        }

        internal static string GetIncomeOrExpense(string GroupId)
        {
            string SQL = string.Format("select fk_ItemType from Master_Product_Group where id= '{0}'", GroupId);
            string fkItemType = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
            return fkItemType;
        }




        #region Frm Pay

        public static string GetSoldquantity(string purchageId)
        {

            string quantity;
            StringBuilder SQL = new StringBuilder();
            try
            {
                SQL.AppendFormat("SELECT sum(Quantity) from Inv_Stock where fk_Inv_Purchase = {0} and fk_stockModfType_Code ='{1}'", purchageId.ToString(), StockType.Sales);
                quantity = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
                if (quantity != "")
                {
                    return quantity;
                }
            }
            catch
            {
                return "0";
            }
            return "0";
        }

        public static bool UpdatequantityTOStore(string Purchageid, string productId, string salesId, string soldQty, string stockType)
        {
            //double totalsoldquantity;
            //totalsoldquantity = Convert.ToDouble(getSoldquantity(Purchageid));
            //totalsoldquantity += soldQty;
            string sql = string.Format(@"INSERT INTO Inv_Stock (fk_inv_Purchase,fk_Master_Product , fk_inv_sale ,Quantity,fk_StockModfType_Code,Date,USerId) values 
                                        ('{0}','{1}','{2}', {3},'{4}','{5}','{6}')",
                                        Purchageid, productId, salesId,
                                        soldQty, stockType, DateTime.Now.ToString("yyyyMMdd"), GlobalValues.LoginUserName 
                                       );
            var ret = GlobalResources.SelectDBConnection.ExecuteNonQuery(sql);
            if (ret.ToInt() > 0)
            {
                return true;
            }
            return false;

        }


        public static string GetQuantity(string table, string id, string field)
        {
            string quantity;
            StringBuilder SQL = new StringBuilder();
            try
            {
                SQL.AppendFormat("SELECT {0} from {1} where id = {2}", field, table, id);
                quantity = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
                if (quantity != "")
                {
                    return quantity;
                }
            }
            catch
            {
                return "0";
            }
            return "0";
        }

        #endregion

        public static int Savetransaction(string customerId, CalculateVATServiceChargeDiscountAmount calculator, DataTable _dtItems)
        {

            StringBuilder SQL = new StringBuilder();
            //
            //Update Sale Account
            //
            SQL.Remove(0, SQL.Length);
            SQL.Append(" INSERT INTO Acc_Sale  ");
            if (customerId != "")
            {
                SQL.AppendFormat(@" (Amount,fk_Master_Customer,CreditAmount,dueAmount, Discount,
                                TenderAmount,ReturnAmount,ServiceCharge,VAT,Date,UserId ) values ( {0} , {1} , {2} , {3}",
                    calculator.AmountToPay,
                    customerId,
                    calculator.CreditAmount.ToString(),
                    calculator.CreditAmount.ToString()
                    );
                SQL.AppendFormat("\n, {0} , {1} , {2} ,{3} ,{4}, {5} ,'{6}' )",
               calculator.Discount.ToString(),
               calculator.Tender.ToString(),
               "0",
               calculator.ServiceCharge,
               calculator.VAT,
               DateTime.Now.ToString("yyyyMMdd"),
               GlobalValues.LoginUserName
               );
            }
            else
            {
                SQL.AppendFormat("\n ( Amount,Discount,TenderAmount,ReturnAmount,ServiceCharge,VAT,Date,UserId ) values ( {0}",
                     calculator.AmountToPay.ToString());
               SQL.AppendFormat("\n, {0} , {1} , {2} ,{3} ,{4}, {5} ,'{6}' )",
               calculator.Discount.ToString(),
               calculator.Tender.ToString(),
               calculator.ReturnAmt.ToString(),
               calculator.ServiceCharge,
               calculator.VAT,
               DateTime.Now.ToString("yyyyMMdd"),
               GlobalValues.LoginUserName
               );
            }
           
            int rsl = GlobalResources.SelectDBConnection.ExecuteNonQuery(SQL.ToString());
            if (rsl == -1)
            {
                return 0;//save
            }

            SQL.Remove(0, SQL.Length);
            SQL.AppendFormat("SELECT MAX(id) FROM Acc_Sale WHERE UserId = '{0}'", GlobalValues.LoginUserName);
            object accidObj = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString());
            int accId = 0;


            try
            { accId = Convert.ToInt32(accidObj.ToString()); }
            catch { }


            //
            //If success update Inv_sale
            //      

            foreach (DataRow dr in _dtItems.Rows)
            {

                string procuctID = Conversion.ToString(dr, "ProductID");
                SQL.Remove(0, SQL.Length);
                SQL.Append(" INSERT INTO Inv_Sale ");
                SQL.Append("\n ( fk_purchage,fk_sale,fk_product,Quantity,Rate,CostPrice,Amount,Discount,NetAmount,Remarks,Date,UserId ) values (");
                SQL.AppendFormat("\n {0}", Conversion.ToInt32(dr, "purchageId"));
                SQL.AppendFormat("\n, {0}", accId.ToString());
                SQL.AppendFormat("\n, {0}", procuctID);
                SQL.AppendFormat("\n, {0}", Conversion.ToDecimal(dr, "quantity"));
                SQL.AppendFormat("\n, {0}", Conversion.ToDecimal(dr, "rate"));
                SQL.AppendFormat("\n, {0}", Conversion.ToDecimal(dr, "CostPrice"));//
                SQL.AppendFormat("\n, {0}", Conversion.ToDecimal(dr, "Amount"));
                SQL.AppendFormat("\n, {0}", Conversion.ToDecimal(dr, "Discount"));
                SQL.AppendFormat("\n, {0}", Conversion.ToDecimal(dr, "netamount"));
                SQL.AppendFormat("\n, '{0}'", Conversion.ToString(dr, "remarks"));
                SQL.AppendFormat("\n, '{0}'", DateTime.Now.ToString("yyyyMMdd"));
                SQL.AppendFormat("\n, '{0}'", GlobalValues.LoginUserName);

                SQL.Append("\n)");
                rsl = GlobalResources.SelectDBConnection.ExecuteNonQuery(SQL.ToString());
                //Update in products 
                string purchaseId;
                double soldqty;
                purchaseId = Conversion.ToString(dr, "purchageId");
                soldqty = Conversion.ToDouble(dr, "quantity") ;
                //lot of trick requiered here.
                //There might be multiple purchase id for single product find them according to the quanity and
                //update them respectively
                if (purchaseId == null)
                {
                    RestoSys.RestoSysDAl.UpdatequantityTOStore("", procuctID, "", soldqty.ToString(), StockType.Sales);
                }
                else
                {
                    RestoSys.RestoSysDAl.UpdatequantityTOStore(purchaseId, procuctID, "", soldqty.ToString(), StockType.Sales);
                }
            }
            return accId;
        }

        private static DataTable _barcodes = null;
        private static DataTable Barcodes
        {
            get
            {
                try
                {
                    if (_barcodes == null)
                    {
                        string SQL = "SELECT id,t1_code code,barcode FROM ProductFrmView";
                        _barcodes = GlobalResources.SelectDBConnection.ExecuteDataTable(SQL);
                    }
                    return _barcodes;
                }
                catch
                {
                    throw;
                }
            }
        }


        public static string GetProductIdFromBarCode(string barcode)
        {
            DataRow[] v = Barcodes.Select("barcode = '{0}'".With(barcode));
            if (v!=null && v.Length >0 )
            {
                return v[0]["id"].ToString();
            }
            return "";
        }
    }
}
