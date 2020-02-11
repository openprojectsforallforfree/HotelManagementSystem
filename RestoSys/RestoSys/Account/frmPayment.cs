using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bsoft.Controls;
using System.Data.SqlClient;
using Friuts;
using UEMS.BLL;
 
using Bsoft.Forms;
using Bsoft.Common;
using Bsoft.Report.Print;
using Bsoft.Data;
using Bsoft.AppCom;
using System.Threading;
using RestoSys.Reports;
using RestoSys.BLL;
using RestoSys.DAl;
namespace RestoSys.Forms
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmPayment : Friuts.EntryFormBase
    {
        public string CustomerId = "";
        CalculateAmounts calculator = new CalculateAmounts();
        DataTable dtItems;
        public frmPayment()
        {
            InitializeComponent();
        }
        public frmPayment(CalculateAmounts _calculator, DataTable _dtItems, string _customerId)
        {
            InitializeComponent();
            dtItems = _dtItems;
            calculator = _calculator;
            CustomerId = _customerId;
            //Display data
            sevenShoppingAmount.Value = calculator.Amount.ToString();
            sevenDiscount.Value = calculator.Discount.ToString();
            lblServiceCharge.Text = calculator.Servicecharge.ToString();
            lblVAT.Text = calculator.VAT.ToString();
            lblTaxableAmount.Text = calculator.TaxableamountCalc.ToString();
            sevenReturn.Value = calculator.ReturnAmt.ToString();
            sevenPayAmount.Value = calculator.Netamount.ToString();
            lblCustomer.Text = CustomerDAL.GetCustomerName(_customerId);
            lblInWords.Text = new Bsoft.Common.NumberInWords().inWords(calculator.Netamount.ToString());
        }

        private void txtTender_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal tenderAmount = txtTender.Text.ToDecimal();
                calculator.Tender = tenderAmount;
                decimal retamt = calculator.ReturnAmt;
                if (retamt < 0)
                {
                    sevenReturn.ColorLight = Color.Red;
                }
                else
                {
                    sevenReturn.ColorLight = Color.LawnGreen;
                }
                sevenReturn.Value = retamt.ToString();
            }
            catch
            {
                throw;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (calculator.ReturnAmt < 0)
            {
                if (MessageBoxMy.Show("The Tender Amount is not enough. \nDo you want Partial payment?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBoxMy.Show("Partial payment system currently not available.");
                }
                DialogResult = DialogResult.No;
            }
            else
            {
                string billno = PaymentDAL.Savetransaction(CustomerId, calculator, dtItems);
                if (ApplicationSetting.PrintBilll)
                {
                    // printBill(_dtItems, billno);
                    RestoSys.BLL.PrintTheBill prnt = new PrintTheBill();
                    prnt.printBillGDI(
                        dtItems,
                        billno.ToInt(),
                        txtTender.Text,
                        sevenPayAmount.Value.ToString(),
                        sevenShoppingAmount.Value.ToString(),
                        sevenDiscount.Value.ToString(),
                        sevenReturn.Value.ToString(),
                        calculator.VAT.ToString(),
                        calculator.Servicecharge.ToString()
                        );
                }
                DialogResult = DialogResult.OK;
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTender_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtTender.Text = sevenPayAmount.Value.ToString();
        }


    }
}
