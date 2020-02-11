using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Printing;
using System.Drawing;
using System.Data;
namespace Bsoft.Report.Print
{
  public   class clsPrinting
    {
        private PrintDocument printDoc = new PrintDocument();
        DataTable particularDt; 
        string total,billno;
        public clsPrinting(DataTable  particularDt_,string total_,string billno_ )
        {
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
            particularDt = particularDt_;
            total=total_ ;
            billno = billno_;
             
        }

        public void Print()
        {
            printDoc.Print();
            printDoc.Dispose();
        }
        private void printDoc_PrintPage(Object sender, PrintPageEventArgs e)
        {
            prntit(e.Graphics, particularDt, total, billno);
        }

       
        #region formatings
        string get2digits(string inStr)
        {
            if (inStr.Contains("."))
            {
                int dot = inStr.IndexOf('.');
                if (inStr.Length - dot > 3)
                {
                    inStr = inStr.Substring(0, dot + 3);
                }
                else if (inStr.Length - dot == 1)
                {
                    inStr = inStr + "00";
                }
                else if (inStr.Length - dot == 2)
                {
                    inStr = inStr + "0";
                }

            }
            return inStr;
        }

        private string getParticulars(string sno, string particular, string rate, string quantity, string amount)
        {
            rate = get2digits(rate);
            quantity = get2digits(quantity);
            amount = get2digits(amount);
            if (particular.Length > 9)
            {
                particular = particular.Substring(0, 10);
            }
            string snot = makeStandardLengthStringPaddLeft(sno, 3);
            string particulart = makeStandardLengthStringPaddLeft (particular,9);
            string ratet = makeStandardLengthStringPaddLeft(rate, 5);
            string quantityt = makeStandardLengthStringPaddLeft(quantity, 4);
            string amountt = makeStandardLengthStringPaddLeft(amount, 7);
            string combine = string.Format("{0} {1} {2} {3} {4}", snot, particulart, ratet, quantityt, amountt);
            return combine;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="instring"></param>
        /// <param name="length">Length of string to make</param>
        /// <returns></returns>
        private string makeStandardLengthStringPaddLeft(string instring, int length)
        {
            string temp = "";
            int spacereqd = 0;
            spacereqd = length - instring.Length;
            while (spacereqd > 0)
            {
                temp = temp + " ";
                spacereqd--;
            }
            return temp + instring;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="instring"></param>
        /// <param name="length">Length of container</param>
        /// <returns></returns>
        private string makeCenteredString(string instring, int length)
        {
            string temp = "";
            int spacereqd = 0;
            spacereqd = length - instring.Length;
            spacereqd = spacereqd / 2;
            while (spacereqd > 0)
            {
                temp = temp + " ";
                spacereqd--;
            }
            return temp + instring;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="instring"></param>
        /// <param name="length">Length of string to make</param>
        /// <returns></returns>
        private string makeStandardLengthStringPaddMid(string leftstring, string rightstring, int length)
        {
            string temp = "";
            int spacereqd = 0;
            spacereqd = length - leftstring.Length - rightstring.Length;
            while (spacereqd > 0)
            {
                temp = temp + " ";
                spacereqd--;
            }
            return leftstring + temp + rightstring;
        }
        #endregion

        private void prntit(Graphics g, DataTable dt, string totala, string billnoa)
        {
            int serialNo = 1;
            //Define Constants
            int PaperWidhtinCharacters = 35;
            string maxString = new string('X', PaperWidhtinCharacters);
            int TextVGaping = 15;
            int LineVGaping = 5;
            //Pen blackPen  = new Pen(Color.Black, 1);

            Pen blackPenDash = new Pen(Color.Black, 1);
            blackPenDash.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            //blackPen.Brush = 
            //Font printFont = new Font("Calibri", 10);
            //Font printFont = new Font("Courier New", 10);
            Font printFont = new Font("Lucida Console", 7);
            //Font impFont = new Font("Lucida Console", 8, FontStyle.Bold   );
            //Calculations
            SizeF sz = g.MeasureString(maxString, printFont);
            int lineWidth = (int)sz.Width;
            int y = TextVGaping;//y coordinate
            int x = 5;
            //Drawing
            g.DrawString(makeCenteredString("Abbreviated Invoice", PaperWidhtinCharacters), printFont, Brushes.Black, x, y); y = y + TextVGaping;
            g.DrawString(makeCenteredString("Shop@KAYA", PaperWidhtinCharacters), printFont, Brushes.Black, x, y); y = y + TextVGaping;
            g.DrawString(makeCenteredString("Ghattekulo,Kathmandu", PaperWidhtinCharacters), printFont, Brushes.Black, x, y); y = y + TextVGaping;
            string billLine = makeStandardLengthStringPaddMid("Bill No: " + billnoa, "Date:" + DateTime.Now.ToShortDateString(), PaperWidhtinCharacters);

            g.DrawString(billLine, printFont, Brushes.Black, x, y); y = y + TextVGaping;

            y = y + LineVGaping;
            g.DrawLine(blackPenDash, x, y, lineWidth, y);
            y = y + LineVGaping;

            string pHead = getParticulars("Sno", "Particular", "Rate", "QTY", "  Amount");
            g.DrawString(pHead, printFont, Brushes.Black, x, y); y = y + TextVGaping;

            y = y + LineVGaping;
            g.DrawLine(blackPenDash, x, y, lineWidth, y);
            y = y + LineVGaping;
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string p = getParticulars((serialNo++).ToString(), dr["description"].ToString(), dr["rate"].ToString(), dr["qty"].ToString(), dr["netamount"].ToString());
                    g.DrawString(p, printFont, Brushes.Black, x, y); y = y + TextVGaping;
                }
            }
            catch { }
            y = y + LineVGaping;
            g.DrawLine(blackPenDash, x, y, lineWidth, y);
            y = y + LineVGaping;

            string total = makeStandardLengthStringPaddMid("              Total", get2digits(totala), PaperWidhtinCharacters);
            //string discount = makeStandardLengthStringPaddMid("               Discount", get2digits(discounta), PaperWidhtinCharacters);
            //string netamt = makeStandardLengthStringPaddMid("               Net Amt", get2digits(neta), PaperWidhtinCharacters);
            //string tenderamt = makeStandardLengthStringPaddMid("               Tender Amt", "12.33", PaperWidhtinCharacters);
            //string changeamt = makeStandardLengthStringPaddMid("               Change Amt", "324.56", PaperWidhtinCharacters);
            g.DrawString(total, printFont, Brushes.Black, x, y); y = y + TextVGaping;
            //g.DrawString(discount, printFont, Brushes.Black, x, y); y = y + TextVGaping;

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

    }
}
