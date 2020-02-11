using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Bsoft.Common;
namespace Bsoft.Account
{
    public class PayMent
    {
        public DataTable PaymentData;
        public decimal Tenderamount = 0;//todo
        public decimal ReturnAmount = 0;//todo
        public string BillNumber = "";
        public string Date = "";
        public int AccountId = 0;
        public decimal PaidAmount = 0;
        #region get data
        public decimal SumAmount
        {
            get
            {
                return GetSum(PaymentColumns.Amount);
            }
        }


        public decimal SumDiscount
        {
            get
            {
                return GetSum(PaymentColumns.Discount);
            }
        }
        public decimal Sumservicecharge
        {
            get
            {
                return GetSum(PaymentColumns.ServiceCharge);
            }
        }
        public decimal Sumvat
        {
            get
            {
                return GetSum(PaymentColumns.VAT);
            }
        }
        public decimal SumnetAmount
        {
            get
            {
                return GetSum(PaymentColumns.NetAmount);
            }
        }

        public decimal SumdueAmount
        {
            get
            {
                return GetSum(PaymentColumns.DueAmount);
            }
        }

        public decimal TaxableAmount
        {
            get
            {
                return SumnetAmount - SumDiscount + Sumservicecharge;
            }
        }

        public decimal RemainingAmount
        {
            get
            {
                return SumdueAmount - PaidAmount;
            }
        }

        private decimal GetSum(string column)
        {
            decimal sum = 0;
            foreach (DataRow dr in PaymentData.Rows)
            {
                sum += dr[column].ToString().ToDecimal();
            }
            return sum;
        }
        #endregion
        public PayMent()
        {
        }
        public PayMent(DataTable paymentData, decimal paidAmount)
        {
            PaymentData = paymentData;
            PaidAmount = paidAmount;
        }

        public static class PaymentColumns
        {
            public const string Description = "Description";
            public const string Rate = "Rate";
            public const string Quantity = "Quantity";
            public const string Amount = "Amount";
            public const string Discount = "Discount";
            public const string ServiceCharge = "ServiceCharge";
            public const string VAT = "VAT";
            public const string NetAmount = "NetAmount";
            public const string DueAmount = "DueAmount";
            public const string Remarks = "Remarks";
        }
    }
}
