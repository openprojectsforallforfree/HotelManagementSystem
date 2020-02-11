using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Printing;
using System.Data;
using System.Drawing;
using Bsoft.Common;
namespace Pasal.Reports
{


     public  class  Invoice
    {

        //Settings
        public const int PaperWidhtinCharacters = 35;
        //Company Details
        public static string CompanyName = "Company Name";
        public static string PanNo = "1234567890123";
        public static string VatNo = "9876543210123";
        public static string Address = "GhatteKulo ,Kathmandu";
        
        private static Font printFont = new Font("Lucida Console", 7);
        private static Pen blackPenDash = new Pen(Color.Black, 1);

        private   PrintDocument printDoc = new PrintDocument();

        //Bill Details
        private   string BillNo = "123123123";
        private   string Date = "12/55/2011";
        private   DataTable Particulars;
        private   string GrossTotal = "9999999";
        private   string NetTotal = "9999999";
        private   string Discount = "55555";
        private   string Tender = "9999999";
        private   string ReturnAmt = "9999999";

        
        public   Invoice()
        {
            blackPenDash.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
        }

        public   void Print(string billNo, string date, string net, string gross, string discount, string tender, string returnAmt, DataTable particulars)
        {
            BillNo = billNo;
            Date = date;
            Particulars = particulars;
            NetTotal = net;
            GrossTotal = gross;
            Discount = discount;
            Tender = tender;
            ReturnAmt = returnAmt;
            printDoc.Print();
        }

        private   void printDoc_PrintPage(Object sender, PrintPageEventArgs e)
        {
            prntit(e.Graphics);
        }
        private   int y;
        private   int x;
        const int TextVGaping = 15;
        const int LineVGaping = 5;
        private static int GetLineWidth(Graphics g)
        {
            string maxString = new string('X', PaperWidhtinCharacters);
            SizeF sz = g.MeasureString(maxString, printFont);
            return (int)sz.Width;
        }
        public   void prntit(Graphics g)
        {
            //Define Constants


            int lineWidth = GetLineWidth(g);

            y = TextVGaping;//y coordinate
            x = 5;
            //Drawing
            g.DrawString(StringFormater.makeCenteredString("Abbreviated Invoice", PaperWidhtinCharacters), printFont, Brushes.Black, x, y); y = y + TextVGaping;
            g.DrawString(StringFormater.makeCenteredString(CompanyName, PaperWidhtinCharacters), printFont, Brushes.Black, x, y); y = y + TextVGaping;
            if (PanNo.Trim().Length > 5)
            {
                g.DrawString(StringFormater.makeCenteredString("Pan No. " + PanNo, PaperWidhtinCharacters), printFont, Brushes.Black, x, y); y = y + TextVGaping;
            }
            g.DrawString(StringFormater.makeCenteredString(Address, PaperWidhtinCharacters), printFont, Brushes.Black, x, y); y = y + TextVGaping;
            string billLine = StringFormater.makeStandardLengthStringPaddMid("Bill No: " + BillNo, "Date:" + DateTime.Now.ToShortDateString(), PaperWidhtinCharacters);

            g.DrawString(billLine, printFont, Brushes.Black, x, y); y = y + TextVGaping;

            y = y + LineVGaping;
            g.DrawLine(blackPenDash, x, y, lineWidth, y);
            y = y + LineVGaping;

            printTable(g);
            y = y + LineVGaping;
            g.DrawLine(blackPenDash, x, y, lineWidth, y);
            y = y + LineVGaping;

            string _grosstotal = StringFormater.makeStandardLengthStringPaddMid("            Gross Amt", StringFormater.get2DigitsMust(GrossTotal), PaperWidhtinCharacters);
            string _discount = StringFormater.makeStandardLengthStringPaddMid("             Discount", StringFormater.get2DigitsMust(Discount), PaperWidhtinCharacters);
            string _netamt = StringFormater.makeStandardLengthStringPaddMid("              Net Amt", StringFormater.get2DigitsMust(NetTotal), PaperWidhtinCharacters);
            string _tenderamt = StringFormater.makeStandardLengthStringPaddMid("           Tender Amt", StringFormater.get2DigitsMust(Tender), PaperWidhtinCharacters);
            string _returnAmt = StringFormater.makeStandardLengthStringPaddMid("           Return Amt", StringFormater.get2DigitsMust(ReturnAmt), PaperWidhtinCharacters);

            //string _changeamt = StringFormater.makeStandardLengthStringPaddMid("              Change Amt", "324.56", PaperWidhtinCharacters);

            if (Discount.Trim().ToDouble() > 0)
            {
                g.DrawString(_grosstotal, printFont, Brushes.Black, x, y); y = y + TextVGaping;
                g.DrawString(_discount, printFont, Brushes.Black, x, y); y = y + TextVGaping;
                y = y + LineVGaping;
                g.DrawLine(blackPenDash, x, y, lineWidth, y);
                y = y + LineVGaping;

            }
            g.DrawString(_netamt, printFont, Brushes.Black, x, y); y = y + TextVGaping;
            g.DrawString(_tenderamt, printFont, Brushes.Black, x, y); y = y + TextVGaping;
            g.DrawString(_returnAmt, printFont, Brushes.Black, x, y); y = y + TextVGaping;

            //y = y + LineVGaping;
            //g.DrawLine(blackPenDash, x, y, lineWidth, y);
            //y = y + LineVGaping;

            //  g.DrawString(netamt, printFont, Brushes.Black, x, y); y = y + TextVGaping;

            y = y + LineVGaping;
            g.DrawLine(blackPenDash, x, y, lineWidth, y);
            y = y + LineVGaping;

            g.DrawString("Thankyou.", printFont, Brushes.Black, x, y); y = y + TextVGaping;
            g.DrawString("Please vist us again.", printFont, Brushes.Black, x, y); y = y + TextVGaping;
        }
          int snWidth;
          int descWidth;
          int rateWidth;
          int qtyWidth;
          int amtWidth;
        private   void printTable(Graphics g)
        {
            snWidth = 3;
            descWidth = 9;
            rateWidth = 5;
            qtyWidth = 4;
            amtWidth = 8;
            //Get Max Width
            try
            {
                foreach (DataRow dr in Particulars.Rows)
                {
                    snWidth = dr["sn"].ToString().Length > snWidth ? dr["sn"].ToString().Length : snWidth;
                    //descWidth = dr["description"].ToString().Length > descWidth ? dr["description"].ToString().Length : descWidth;
                    rateWidth = dr["rate"].ToString().Length > rateWidth ? dr["rate"].ToString().Length : rateWidth;
                    qtyWidth = dr["qty"].ToString().Length > qtyWidth ? dr["qty"].ToString().Length : qtyWidth;
                    amtWidth = dr["netamount"].ToString().Length > amtWidth ? dr["netamount"].ToString().Length : amtWidth;
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
                foreach (DataRow dr in Particulars.Rows)
                {
                    string p = getParticulars(dr["sn"].ToString(), dr["description"].ToString(), dr["rate"].ToString(), dr["qty"].ToString(), dr["netamount"].ToString());
                    g.DrawString(p, printFont, Brushes.Black, x, y); y = y + TextVGaping;
                }
            }
            catch { }
        }

        public   string getParticulars(string sno, string particular, string rate, string quantity, string amount)
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
