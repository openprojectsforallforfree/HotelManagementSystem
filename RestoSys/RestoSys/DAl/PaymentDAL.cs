using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestoSys.BLL;
using System.Data;
using Bsoft.AppCom;
using Bsoft.Data;
using Bsoft.Forms;
using RestoSys.Hotel;
using System.Data.Common;
using Bsoft.Account;
using Bsoft.Common;
using System.Data.SQLite;

namespace RestoSys.DAl
{
    class PaymentDAL
    {

        public static DataTable GetPayableItems(string customerID)
        {
            string SQL = string.Format(@"select * from 
(select * from Hotel_RoomSales_View
                        union all
select * from Hotel_ProductSales_View) where fk_Master_Customer = '{0}' and bookingstaus = 'Occupied'", customerID);
            return GlobalResources.SelectDBConnection.ExecuteDataTable(SQL.ToString());
        }




        public static DataTable GetSummaryofPayableItems(string customerID)
        {
            string SQL = string.Format(@"
                            select 
                            sum(Amount) Amount ,
                            sum(Discount) Discount,
                            sum( VAT) VAT,
                            sum( ServiceCharge) ServiceCharge,
                            sum( NetAmount) NetAmount,
                            sum(dueamt)  dueamt
                            from 
(select * from Hotel_RoomSales_View
                        union all
select * from Hotel_ProductSales_View)
where fk_Master_Customer = '{0}' and bookingstaus = 'Occupied'
            ", customerID);
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(SQL.ToString());
            return dt;
        }
        public static int CancelBooking(string id, string table)
        {
            string UpdateSQL = string.Format(@"UPDATE  {0} 
                                        set netamount=0, dueamt =dueamt-netamount,bookingstaus ='{2}' ,cancelDate='{3}'
                                        where id = {1}", table, id, BookingStatus.Canceled, DateTime.Now.ToString("yyyyMMdd"));
            return GlobalResources.SelectDBConnection.ExecuteNonQuery(UpdateSQL);
        }
        public static string Savetransaction(string customerId, CalculateAmounts calculator, DataTable dtItems)
        {
            string accId = "";
            DbTransaction tran = GlobalResources.SelectDBConnection.BeginTransaction();
            try
            {
                string sql = string.Format(@"
                                INSERT INTO Hotel_Account
                                (
                                Amount,
                                TenderAmount,
                                ReturnAmount,
                                Date,
                                UserId,
                                fk_Master_Customer
                                )values ({0},{1},{2},{3},{4},{5})",
                                                                  calculator.Amount,
                                                                  calculator.Tender,
                                                                  calculator.ReturnAmt,
                                                                  DateTime.Now.ToString("yyyyMMdd"),
                                                                  GlobalValues.LoginUserName,
                                                                  customerId);
                GlobalResources.SelectDBConnection.ExecuteNonQuery(sql);
                accId = GlobalResources.SelectDBConnection.ExecuteScalar(string.Format("SELECT MAX(id) FROM Hotel_Account WHERE  UserId = '{0}'", GlobalValues.LoginUserName)).ToString();
                foreach (DataRow dr in dtItems.Rows)
                {
                    string UpdateSQL = string.Format(@"UPDATE  {0} 
                                        set dueamt =0,accid= '[{2}]',bookingstaus ='Cleared' 
                                        where id = {1}", dr["tablename"].ToString(), dr["id"].ToString(), accId);
                    GlobalResources.SelectDBConnection.ExecuteNonQuery(UpdateSQL.ToString());
                }
                //                GlobalResources.SelectDBConnection.CommitTransaction(ref tran);
            }
            catch (Exception ex)
            {
                //   GlobalResources.SelectDBConnection.RollbackTransaction(ref tran);
                MessageBoxMy.Show("Some error occured please contact admin. " + ex.StackTrace);
            }
            return accId;
        }

        //        foreach
        //if t>0
        //    if t-d>=0
        //        t=t-d
        //        d=0
        //    else
        //        d= d-t
        //        t=0
        //    end if
        //end if
        //end foreach
        //if t >0
        //set d of any one = -1*t

        public static string Savetransaction(string customerId, PayMent pay, DataTable dtItems)
        {
            string accId = "";

            SQLiteTransaction tran = GlobalResources.SelectDBConnection.BeginTransaction();
            try
            {
                string sql = string.Format(@"
                                INSERT INTO Hotel_Account
                                (
                                Amount,
                                PaidAmount,
                                TenderAmount,
                                ReturnAmount,
                                Date,
                                UserId,
                                fk_Master_Customer
                                )values ({0},{1},{2},{3},{4},'{5}',{6})",
                                                                  pay.SumdueAmount,
                                                                  pay.PaidAmount,
                                                                  pay.Tenderamount,
                                                                  pay.ReturnAmount,
                                                                  DateTime.Now.ToString("yyyyMMdd"),
                                                                  GlobalValues.LoginUserName,
                                                                  customerId);
                int rows = GlobalResources.SelectDBConnection.ExecuteNonQuery(sql);
                accId = GlobalResources.SelectDBConnection.ExecuteScalar(string.Format("SELECT MAX(id) FROM Hotel_Account WHERE  UserId = '{0}'", GlobalValues.LoginUserName)).ToString();
                string UpdateSQL = "";
                decimal tempPaidAmount = pay.PaidAmount;
                decimal currentDueAmount = 0;
                if (tempPaidAmount > 0)
                {//pay case
                    foreach (DataRow dr in dtItems.Rows)
                    {
                        if (tempPaidAmount > 0)
                        {
                            currentDueAmount = dr["dueAmount"].ToString().ToDecimal();

                            if ((tempPaidAmount - currentDueAmount) > 0)
                            {//clear all due
                                tempPaidAmount = tempPaidAmount - currentDueAmount;
                                currentDueAmount = 0;
                                if (tempPaidAmount > 0 && dr == dtItems.Rows[dtItems.Rows.Count - 1])
                                {//last item make it refund
                                    currentDueAmount = -1 * tempPaidAmount;
                                }
                            }
                            else
                            {//not enough have some due
                                currentDueAmount = currentDueAmount - tempPaidAmount;
                                tempPaidAmount = 0;
                            }
                            UpdateSQL = string.Format(@"UPDATE  {0} 
                                        set dueamt ={3},accid= accid || '[{2}]'  
                                        where id = {1}",
                                                               dr["coltablename"].ToString(),
                                                               dr["bookingid"].ToString(),
                                                               accId,
                                                               currentDueAmount);
                            GlobalResources.SelectDBConnection.ExecuteNonQuery(UpdateSQL.ToString());
                        }

                        
                    }
                }
                else
                {//refund case
                    if (dtItems.Rows.Count > 0)
                    {
                        DataRow dr = dtItems.Rows[dtItems.Rows.Count - 1];
                        UpdateSQL = string.Format(@"UPDATE  {0} 
                                        set dueamt =dueamt - {3},accid= accid || '[{2}]'  
                                        where id = {1}",
                                                                     dr["coltablename"].ToString(),
                                                                     dr["bookingid"].ToString(),
                                                                     accId,
                                                                     tempPaidAmount);
                        GlobalResources.SelectDBConnection.ExecuteNonQuery(UpdateSQL.ToString());
                    }
                    else
                    {
                        GlobalResources.SelectDBConnection.RollbackTransaction(ref tran);
                    }

                }
                GlobalResources.SelectDBConnection.CommitTransaction(ref tran);
            }
            catch (Exception ex)
            {
                GlobalResources.SelectDBConnection.RollbackTransaction(ref tran);
                MessageBoxMy.Show("Some error occured please contact admin. " + ex.StackTrace);
            }
            return accId;
        }


        /// <summary>
        /// Check out
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="pay"></param>
        /// <param name="dtItems"></param>
        /// <returns></returns>
        public static int CheckOut(string customerId, DataTable dtItems)
        {
            int retVal = 0;
            SQLiteTransaction tran = GlobalResources.SelectDBConnection.BeginTransaction();
            try
            {

                foreach (DataRow dr in dtItems.Rows)
                {
                    string UpdateSQL = string.Format(@"UPDATE  {0} 
                                        set bookingstaus = '{2}'
                                        where id = {1}",
                                                           dr["tablename"].ToString(),
                                                           dr["id"].ToString(),
                                                           BookingStatus.Cleared);
                    retVal = GlobalResources.SelectDBConnection.ExecuteNonQuery(UpdateSQL.ToString());
                }

                GlobalResources.SelectDBConnection.CommitTransaction(ref tran);
            }
            catch (Exception ex)
            {
                GlobalResources.SelectDBConnection.RollbackTransaction(ref tran);
                MessageBoxMy.Show("Some error occured please contact admin. " + ex.StackTrace);
            }
            return retVal;
        }
    }
}
