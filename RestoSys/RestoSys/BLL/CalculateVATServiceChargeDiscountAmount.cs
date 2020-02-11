using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Bsoft.Common;
namespace RestoSys.BLL
{
    public class CalculateVATServiceChargeDiscountAmount
    {
        //In totals
        //Discount percet is always calculated from totaldiscount/total
        //Discount amount is always sum of inidvidual disounts.
        //In individual items
        //Discount percet is always calculated from discountAmt/(rate*qty)
        //discount amt is either entered directly or escalted from discount amount
        //Cases of user interaction
        //Item add                  keep others as it is , just enter row with 0 discount   update sub amt ,amt   update disocunt and amount in dC
        //Item Remove               keep others as it is , remove row                       update disocunt and   amount in dC
        //qty change + -            keep others as it is , set discount = 0 and             update sub amt ,amt   update disocunt and amount in dC
        //Items Discount entered    Find sum discount and then set to discout cntrl         update sub amt ,amt
        //Total Discount entered    Escalate discount                                       update sub amt ,amt
        static decimal svFactor = 0;
        public CalculateVATServiceChargeDiscountAmount()
        {
            decimal s = ApplicationSetting.ServiceChargePercent;
            decimal v = ApplicationSetting.VatPercent;
            svFactor = (1 + (s / 100)) * (1 + (v / 100));
        }

        public decimal DiscountPercent
        {
            get
            {
                if (Total > 0)
                {
                    return (Discount / Total) * 100;
                }
                else
                {
                    return 0;
                }
            }
        }

        //just set discountAmount and amount and get all details
        public decimal Discount = 0;
        public decimal Total = 0;
        public decimal ServiceCharge
        {
            get
            {
                return Math.Round(SubTotal * (ApplicationSetting.ServiceChargePercent / (decimal)100), 2);
            }
        }

        public decimal TaxableAmount
        {
            get
            {
                return SubTotal + ServiceCharge;
            }
        }

        public decimal SubTotal
        {
            get
            {
                return Total - Discount; ;
            }
        }

        public decimal VAT
        {
            get
            {
                return Math.Round(TaxableAmount * ApplicationSetting.VatPercent / (decimal)100, 2);
            }
        }

        public decimal GrandTotal
        {
            get
            {
                return TaxableAmount + VAT;
            }
        }

        public decimal AmountToPay
        {
            get
            {
                return Math.Round(GrandTotal, 0);
            }
        }
        public decimal Tender = 0;

        public decimal ReturnAmt
        {
            get
            {

                return Tender - AmountToPay;
            }
        }

        public decimal CreditAmount
        {
            get
            {
                return AmountToPay - Tender;
            }
        }

        public static decimal GetAdjustedDiscountForRoundedGrandTotal(decimal grandTotal, decimal amount)
        {
            decimal d = amount - (grandTotal / svFactor);
            return Math.Round(d, 2);
        }

        public static decimal GetGrandTotalWithoutDiscount(decimal total)
        {
            return total * svFactor;
        }

    }

    public class CalculateAmounts
    {
        public decimal Amount = 0;
        public decimal Discount = 0;
        public decimal Servicecharge = 0;
        public decimal VAT = 0;
        public decimal Netamount = 0;
        public decimal Dueamount = 0;
        public decimal Tender = 0;
        public decimal ReturnAmt
        {
            get
            {
                return Tender - Netamount;
            }
        }
        public decimal TaxableamountCalc
        {
            get { return Amount - Discount + Servicecharge; }

        }
        public decimal CreditAmount
        {
            get;
            set;
        }
       

        public static CalculateAmounts GetTotals(DataTable dt)
        {
            CalculateAmounts cm = new CalculateAmounts();
            //dueamt
            cm.Amount = dt.Rows[0]["Amount"].ToString().ToDecimal();
            cm.Discount = dt.Rows[0]["Discount"].ToString().ToDecimal();
            //cm.grossamount = dt.Rows[0][""].ToString().ToDecimal();
            cm.Servicecharge = dt.Rows[0]["ServiceCharge"].ToString().ToDecimal();
            // cm.taxableamount = dt.Rows[0][""].ToString().ToDecimal();
            cm.VAT = dt.Rows[0]["VAT"].ToString().ToDecimal();
            cm.Netamount = dt.Rows[0]["NetAmount"].ToString().ToDecimal();
            cm.Dueamount = dt.Rows[0]["dueamt"].ToString().ToDecimal();
            return cm;
        }

        

    }
}

