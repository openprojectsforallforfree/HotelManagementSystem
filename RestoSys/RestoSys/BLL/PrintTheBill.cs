using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading;
using Bsoft.AppCom;
using RestoSys.Reports;
using Bsoft.Account;
using Bsoft .Common ;
namespace RestoSys.BLL
{
    class PrintTheBill
    {
        int _billNo;
        string _tender;
        string _discount;
        string _shop;
        string _return;
        string _sevenPay;
        string _vat;
        string _serviceChrg;
        DataTable _billItems;

        private void WindowThreadPrintBill()
        {
            //clsPrinting prnt = new clsPrinting(_billItems, sevenPayAmount.Value.ToString(), _billNo.ToString());
            //prnt.Print();
            Invoice inv = new Invoice();

            (new Invoice()).Print(_billNo.ToString(), DateTime.Now.ToString(), _sevenPay, _shop
                 , _discount, _tender, _return, _vat, _serviceChrg, _billItems);
        }

        private void WindowThreadPrintItemWiseBill()
        {
            //clsPrinting prnt = new clsPrinting(_billItems, sevenPayAmount.Value.ToString(), _billNo.ToString());
            //prnt.Print();
            for (int rowcnt = 0; rowcnt < _billItems.Rows.Count; rowcnt++)
            {
                //int itemCount = _billItems.Rows[rowcnt ]["qty"].ToString().ToInt();
                //make a dt 
                int colcnt = 0;
                DataTable dt = new DataTable();
                dt = _billItems.Clone();
                dt.Rows.Add();
                foreach (DataColumn dc in dt.Columns)
                {
                    dt.Rows[0][colcnt] = _billItems.Rows[rowcnt][colcnt];
                    colcnt++;
                }
                //for (int i = 0; i < itemCount; i++)
                //{
                Invoice inv = new Invoice();
                (new Invoice()).Print(_billNo.ToString(), DateTime.Now.ToString(), _sevenPay, _shop
                     , _discount, _tender, _return, _vat, _serviceChrg, dt);
                //}
            }

        }

        public void printBillGDI(DataTable billitems, int billno, string tender, string payamount, string shopamount, string discountamount
            , string returnamount, string vat, string servicecharge)
        {
            _billItems = billitems;
            _billNo = billno;


            _tender = tender;
            _sevenPay = payamount;
            _shop = shopamount;
            _discount = discountamount;
            _return = returnamount;
            _vat = vat;
            _serviceChrg = servicecharge;


            System.Threading.Thread t;
            //if (GlobalValues.BillPerInvoce)
            //{
            //    t = new Thread(new ThreadStart(WindowThreadPrintItemWiseBill));
            //}
            //else
            //{
            t = new Thread(new ThreadStart(WindowThreadPrintBill));
            // }
            t.IsBackground = true;// the main form will close (when closing child form) if this is set .
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }


        public void printBillGDI(PayMent pay)
        {
            _billItems = pay.PaymentData ;
            _billNo = pay.BillNumber.ToInt() ;
            _tender = pay.Tenderamount.ToString () ;
            _sevenPay = pay.SumnetAmount.ToString();
            _shop = pay.SumAmount.ToString();
            _discount = pay.SumDiscount.ToString();
            _return = pay.ReturnAmount.ToString();
            _vat = pay.Sumvat.ToString();
            _serviceChrg = pay.Sumservicecharge.ToString();

            System.Threading.Thread t;
            
            t = new Thread(new ThreadStart(WindowThreadPrintBill));
            
            t.IsBackground = true;// the main form will close (when closing child form) if this is set .
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
    }
}
