using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Data;
using System.Drawing;
using Bsoft.Common;
using System.Threading;
using Bsoft.Account;
namespace RestoSys.Reports
{


    public class Hotel_Invoice
    {

        //Settings
        private int y;
        private int x;
        const int TextVGaping = 15;
        const int LineVGaping = 5;

        //Company Details
        public static string CompanyName = "HOTEL PHOENIX";
        public static string PanNo = "";
        public static string VatNo = "";
        public static string Address = "KATHMANDU";

        private PrintDocument printDoc = new PrintDocument();

        //Bill Details

        PayMent _pay = new PayMent();

        private static Font printFont = new Font("Lucida Console", 7);
        private static Pen blackPenDash = new Pen(Color.Black, 1);
        public const int PaperWidhtinCharacters = 35;
        bool PrintOrganizationDetails = true;
        int snWidth;
        int descWidth;
        int rateWidth;
        int qtyWidth;
        int amtWidth;

        public static int GetLineWidth(Graphics g)
        {
            string maxString = new string('X', PaperWidhtinCharacters);
            SizeF sz = g.MeasureString(maxString, printFont);
            return (int)sz.Width;
        }

        public Hotel_Invoice()
        {
            blackPenDash.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
        }

        public void printBillGDI(PayMent pay)
        {
            _pay = pay;
            System.Threading.Thread t;
            t = new Thread(new ThreadStart(printDoc.Print));
            t.IsBackground = true;// the main form will close (when closing child form) if this is set .
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void printDoc_PrintPage(Object sender, PrintPageEventArgs e)
        {
            prntit(e.Graphics);
        }

        public void prntit(Graphics g)
        {
            //Define Constants
            int lineWidth = GetLineWidth(g);
            y = TextVGaping;//y coordinate
            x = 5;
            //Drawing

            if (PrintOrganizationDetails)
            {
                g.DrawString(StringFormater.makeCenteredString("Abbreviated Invoice", PaperWidhtinCharacters), printFont, Brushes.Black, x, y); y = y + TextVGaping;
                g.DrawString(StringFormater.makeCenteredString(CompanyName, PaperWidhtinCharacters), printFont, Brushes.Black, x, y); y = y + TextVGaping;
                if (PanNo.Trim().Length > 5)
                {
                    g.DrawString(StringFormater.makeCenteredString("Pan No. " + PanNo, PaperWidhtinCharacters), printFont, Brushes.Black, x, y); y = y + TextVGaping;
                }
                g.DrawString(StringFormater.makeCenteredString(Address, PaperWidhtinCharacters), printFont, Brushes.Black, x, y); y = y + TextVGaping;
            }
            else
            {
                g.DrawString(StringFormater.makeCenteredString("Invoice", PaperWidhtinCharacters), printFont, Brushes.Black, x, y); y = y + TextVGaping;
            }

            string billLine = StringFormater.makeStandardLengthStringPaddMid("Bill No: " + _pay.BillNumber, "Date:" + DateTime.Now.ToShortDateString(), PaperWidhtinCharacters);
            g.DrawString(billLine, printFont, Brushes.Black, x, y); y = y + TextVGaping;

            y = y + LineVGaping;
            g.DrawLine(blackPenDash, x, y, lineWidth, y);
            y = y + LineVGaping;

            printTable(g);
            y = y + LineVGaping;
            g.DrawLine(blackPenDash, x, y, lineWidth, y); y = y + LineVGaping;

            string _grosstotal = StringFormater.makeStandardLengthStringPaddMid("            Gross Amt", StringFormater.get2DigitsMust(_pay.SumAmount.ToString()), PaperWidhtinCharacters);
            //vat and service charge
            string _vat = StringFormater.makeStandardLengthStringPaddMid("            VAT Amt", StringFormater.get2DigitsMust(_pay.Sumvat.ToString()), PaperWidhtinCharacters);
            string _serviceCharge = StringFormater.makeStandardLengthStringPaddMid("            Service Chrg", StringFormater.get2DigitsMust(_pay.Sumservicecharge.ToString()), PaperWidhtinCharacters);

            string _discount = StringFormater.makeStandardLengthStringPaddMid("             Discount", StringFormater.get2DigitsMust(_pay.SumDiscount.ToString()), PaperWidhtinCharacters);
            string _netamt = StringFormater.makeStandardLengthStringPaddMid("              Net Amt", StringFormater.get2DigitsMust(_pay.SumnetAmount.ToString()), PaperWidhtinCharacters);
            string _dueamt = StringFormater.makeStandardLengthStringPaddMid("              Due Amt", StringFormater.get2DigitsMust(_pay.SumdueAmount.ToString()), PaperWidhtinCharacters);
            string _remainingamt = StringFormater.makeStandardLengthStringPaddMid("        Remaining Amt", StringFormater.get2DigitsMust(_pay.RemainingAmount.ToString()), PaperWidhtinCharacters);
            string _currentPayment = StringFormater.makeStandardLengthStringPaddMid("      Current Payment", StringFormater.get2DigitsMust(_pay.PaidAmount.ToString()), PaperWidhtinCharacters);

            string _tenderamt = StringFormater.makeStandardLengthStringPaddMid("           Tender Amt", StringFormater.get2DigitsMust(_pay.Tenderamount.ToString()), PaperWidhtinCharacters);
            string _returnAmt = StringFormater.makeStandardLengthStringPaddMid("           Return Amt", StringFormater.get2DigitsMust(_pay.ReturnAmount.ToString()), PaperWidhtinCharacters);
            //string _changeamt = StringFormater.makeStandardLengthStringPaddMid("              Change Amt", "324.56", PaperWidhtinCharacters);
            if (_pay.Sumvat > 0 || _pay.Sumservicecharge > 0 || _pay.SumDiscount > 0)
            {
                g.DrawString(_grosstotal, printFont, Brushes.Black, x, y); y = y + TextVGaping;
            }
            if (_pay.SumDiscount > 0)
            {
                g.DrawString(_discount, printFont, Brushes.Black, x, y); y = y + TextVGaping;
            }
            if (_pay.Sumvat > 0)
            {
                g.DrawString(_vat, printFont, Brushes.Black, x, y); y = y + TextVGaping;
            }
            if (_pay.Sumservicecharge > 0)
            {
                g.DrawString(_serviceCharge, printFont, Brushes.Black, x, y); y = y + TextVGaping;
            }
            if (_pay.Sumvat > 0 || _pay.Sumservicecharge > 0 || _pay.SumDiscount > 0)
            {
                g.DrawLine(blackPenDash, x, y, lineWidth, y); y = y + LineVGaping;
            }
            g.DrawString(_netamt, printFont, Brushes.Black, x, y); y = y + TextVGaping;
            g.DrawString(_dueamt, printFont, Brushes.Black, x, y); y = y + TextVGaping;
            g.DrawString(_currentPayment, printFont, Brushes.Black, x, y); y = y + TextVGaping;
           
            g.DrawString(_remainingamt, printFont, Brushes.Black, x, y); y = y + TextVGaping;
           

            if (_pay.Tenderamount > 0)
            {
                g.DrawString(_tenderamt, printFont, Brushes.Black, x, y); y = y + TextVGaping;
                g.DrawString(_returnAmt, printFont, Brushes.Black, x, y); y = y + TextVGaping;
            }
            y = y + LineVGaping;
            g.DrawLine(blackPenDash, x, y, lineWidth, y);
            y = y + LineVGaping;
            g.DrawString("Thankyou.", printFont, Brushes.Black, x, y); y = y + TextVGaping;
            g.DrawString("Please vist us again.", printFont, Brushes.Black, x, y); y = y + TextVGaping;
            g.DrawLine(blackPenDash, x, y, lineWidth, y);
            //add
            //if (new Random().Next(0, 6) == 5)
            //{
            //    g.DrawString("Advertisement : ", printFont, Brushes.Black, x, y); y = y + TextVGaping;
            //    g.DrawString("Please contact", printFont, Brushes.Black, x, y); y = y + TextVGaping;
            //    g.DrawString("picassoconsultant@gmail.com", printFont, Brushes.Black, x, y); y = y + TextVGaping;
            //    g.DrawString("for building design works.", printFont, Brushes.Black, x, y); y = y + TextVGaping;
            //    g.DrawString("Thankyou.", printFont, Brushes.Black, x, y); y = y + TextVGaping;
            //}
            //else if (new Random().Next(0, 6) == 5)
            //{
            //    g.DrawString("Advertisement : ", printFont, Brushes.Black, x, y); y = y + TextVGaping;
            //    g.DrawString("Please contact", printFont, Brushes.Black, x, y); y = y + TextVGaping;
            //    g.DrawString("info@shuvham.com", printFont, Brushes.Black, x, y); y = y + TextVGaping;
            //    g.DrawString("for", printFont, Brushes.Black, x, y); y = y + TextVGaping;
            //    g.DrawString("Department Store software,", printFont, Brushes.Black, x, y); y = y + TextVGaping;
            //    g.DrawString("Restaurant software etc", printFont, Brushes.Black, x, y); y = y + TextVGaping;
            //    g.DrawString("Thankyou.", printFont, Brushes.Black, x, y); y = y + TextVGaping;
            //}
        }

        private void printTable(Graphics g)
        {
            snWidth = 3;
            descWidth = 9;
            rateWidth = 5;
            qtyWidth = 4;
            amtWidth = 8;
            //Get Max Width
            try
            {
                int serialNo = 1;
                foreach (DataRow dr in _pay.PaymentData.Rows)
                {
                    snWidth = serialNo.ToString().Length > snWidth ? serialNo.ToString().Length : snWidth;
                    //descWidth = dr["description"].ToString().Length > descWidth ? dr["description"].ToString().Length : descWidth;
                    rateWidth = dr["rate"].ToString().Length > rateWidth ? dr["rate"].ToString().Length : rateWidth;
                    qtyWidth = dr["quantity"].ToString().Length > qtyWidth ? dr["quantity"].ToString().Length : qtyWidth;
                    amtWidth = dr["netamount"].ToString().Length > amtWidth ? dr["netamount"].ToString().Length : amtWidth;
                    serialNo++;
                }
            }
            catch { }
            int lineWidth = GetLineWidth(g);
            string pHead = getParticulars("Sno", "Items", "Rate", "QTY", "Amount");
            g.DrawString(pHead, printFont, Brushes.Black, x, y); y = y + TextVGaping;
            y = y + LineVGaping;
            g.DrawLine(blackPenDash, x, y, lineWidth, y);
            y = y + LineVGaping;
            try
            {
                int serialNo = 1;
                foreach (DataRow dr in _pay.PaymentData.Rows)
                {
                    string p = getParticulars(serialNo.ToString(), dr["description"].ToString(), dr["rate"].ToString(), dr["quantity"].ToString(), dr["netamount"].ToString());
                    g.DrawString(p, printFont, Brushes.Black, x, y); y = y + TextVGaping;
                    serialNo++;
                }
            }
            catch { }
        }

        private string getParticulars(string sno, string particular, string rate, string quantity, string amount)
        {
            rate = StringFormater.get2digits(rate);
            quantity = StringFormater.get2digits(quantity);
            amount = StringFormater.get2digits(amount);
            if (particular.Length > 8)
            {
                particular = particular.Substring(0, 9);
            }
            string snot = StringFormater.makeStandardLengthStringPaddLeft(sno, snWidth);
            string particulart = StringFormater.makeStandardLengthStringPaddLeft(particular, descWidth);
            string ratet = StringFormater.makeStandardLengthStringPaddLeft(rate, rateWidth);
            string quantityt = StringFormater.makeStandardLengthStringPaddLeft(quantity, qtyWidth);
            string amountt = StringFormater.makeStandardLengthStringPaddLeft(amount, amtWidth);
            string combine = string.Format("{0} {1} {2} {3} {4}", snot, particulart, ratet, quantityt, amountt);
            if (combine.Length > PaperWidhtinCharacters)
            {
                combine = string.Format("{0} {1} {2} {3}", snot, particulart, ratet, quantityt);
                combine = combine + "\n -    " + amount;
                y = y + LineVGaping;
            }
            return combine;
        }
    }




}
