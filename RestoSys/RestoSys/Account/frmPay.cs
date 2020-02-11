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
namespace RestoSys.Forms
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmPay : Friuts.EntryFormBase
    {
        RestoSys.BLL.CalculateVATServiceChargeDiscountAmount calculator = new RestoSys.BLL.CalculateVATServiceChargeDiscountAmount();
        DataTable dtItems;
        public frmPay()
        {
            InitializeComponent();
        }
        public frmPay(CalculateVATServiceChargeDiscountAmount _calculator, DataTable _dtItems)
        {
            InitializeComponent();
            dtItems = _dtItems;
            calculator = _calculator;
            DisplayData();
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

        private void frmPay_Load(object sender, EventArgs e)
        {
            lblInWords.Text = new Bsoft.Common.NumberInWords().inWords(calculator.AmountToPay.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string a = txtTender.Text;
            if (calculator.ReturnAmt < 0)
            {
                if (MessageBoxMy.Show("The Tender Amount is not enough. \nDo you want to give Credit?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (CustomerId.Trim() == "")
                    {
                        MessageBoxMy.Show("Please Browse the customer name first.", MessageBoxButtons.OK);
                    }
                    else
                    {

                        if (MessageBoxMy.Show("Do you want to give credit \nof Amount Rs:" + calculator.CreditAmount.ToString() + " to \n" + customerName, MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            TransactionSave(CustomerId);
                        }
                    }
                }
            }
            else
            {
                TransactionSave("");
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

        #region Customer Related
        string CustomerId = "", customerName = "";
        private void fsBrowse_Click(object sender, EventArgs e)
        {
            RestoSys.Forms.frmCustomerList frm = new RestoSys.Forms.frmCustomerList();
            frm.FormType = FormTypes.SelectionForm;
            // frm.toolStrip1.Enabled = false;
            frm.valueSelected += new ListingFormBase.ValueSelected(frm_valueSelected);
            frm.ShowDialog(this);
        }

        void frm_valueSelected(object sender, string SelectedPrimaryKey)
        {
            DataGridViewRow row = (DataGridViewRow)((ListingFormBase)sender).SelectedValue;
            string namefrst = row.Cells["colName"].Value.ToString();
            string namelst = row.Cells["colLastName"].Value.ToString();
            CustomerId = row.Cells["colId"].Value.ToString();
            //SelectComboValue(cboProduct, KEY);
            customerName = namefrst + " " + namelst;
            txtCustomerName.Text = customerName;
            sevenDiscount.Value = RestoSysDAl.GetDiscountPercent(CustomerId).ToString();
        }

        private void btnCancelCustomer_Click(object sender, EventArgs e)
        {
            CustomerId = "";
            customerName = "";
            txtCustomerName.Text = customerName;
            sevenDiscount.Value = "0";
        }
        #endregion

        private void DisplayData()
        {
            sevenShoppingAmount.Value = calculator.Total.ToString();
            sevenDiscount.Value = calculator.Discount.ToString();
            //  sevenServiceCharge.Value = calculator.ServiceCharge.ToString();
            //  sevenVat.Value = calculator.VAT.ToString();
            //  sevenSubTotal.Value = calculator.AmountAfterDiscount.ToString();
            sevenReturn.Value = calculator.ReturnAmt.ToString();
            sevenPayAmount.Value = calculator.AmountToPay.ToString();
            //discountControl.Amount = calculator.AmountAfterServiceCharge;
            lblInWords.Text = new Bsoft.Common.NumberInWords().inWords(calculator.AmountToPay.ToString());
        }

        private void TransactionSave(string customerid)
        {
            int billno = RestoSys.RestoSysDAl.Savetransaction(customerid, calculator, dtItems);
            if (ApplicationSetting.PrintBilll)
            {
                // printBill(_dtItems, billno);
                RestoSys.BLL.PrintTheBill prnt = new PrintTheBill();
                prnt.printBillGDI(
                    dtItems,
                    billno,
                    txtTender.Text,
                    sevenPayAmount.Value.ToString(),
                    sevenShoppingAmount.Value.ToString(),
                    sevenDiscount.Value.ToString(),
                    sevenReturn.Value.ToString(),
                    calculator.VAT.ToString (),
                    calculator.ServiceCharge.ToString ()
                    );
            }
            DialogResult = DialogResult.OK;
        }
    }
}
