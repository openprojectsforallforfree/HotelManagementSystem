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
using Bsoft.Utility;
using Bsoft.Forms;
using Bsoft.Common;
using Bsoft.Report.Print;
using Bsoft.Data;
using Bsoft.AppCom;
using System.Threading;
using RestoSys.Reports;
using RestoSys.Inventory;
using RestoSys.BLL;
namespace RestoSys.Forms
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmPayWithDiscount : Friuts.EntryFormBase
    {
        DataTable _dtItems;
        RestoSys.BLL.CalculateVATServiceChargeDiscountAmount calculator = new RestoSys.BLL.CalculateVATServiceChargeDiscountAmount();
        string CustomerId = "", customerName = "";



        public frmPayWithDiscount(decimal totalAmount, DataTable dtItems)
            : base()
        {
            InitializeComponent();
            discountControl.discountUpdated += new Bsoft.Controls.DiscountControl.discountUpdatedH(discountControl_discountPUpdated);
            calculator.Amount = totalAmount;
            discountControl.Amount = calculator.AmountAfterServiceCharge;
            _dtItems = dtItems;
            DisplayData();
        }

        void discountControl_discountPUpdated(decimal percent, decimal discountAmount)
        {
            calculator.discountAmount = discountAmount;
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBrowseCustomer_Click(object sender, EventArgs e)
        {
            RestoSys.Forms.frmCustomerList frm = new RestoSys.Forms.frmCustomerList();
            frm.FormType = FormTypes.SelectionForm;
            // frm.toolStrip1.Enabled = false;
            frm.valueSelected += new ListingFormBase.ValueSelected(frmCustomer_valueSelected);
            frm.ShowDialog(this);
        }

        void frmCustomer_valueSelected(object sender, string SelectedPrimaryKey)
        {
            DataGridViewRow row = (DataGridViewRow)((ListingFormBase)sender).SelectedValue;
            string namefrst = row.Cells["colName"].Value.ToString();
            string namelst = row.Cells["colLastName"].Value.ToString();
            CustomerId = row.Cells["colId"].Value.ToString();
            //SelectComboValue(cboProduct, KEY);
            customerName = namefrst + " " + namelst;
            txtCustomerName.Text = customerName;
            discountControl.txtDiscountPercent.Text = RestoSysDAl.GetDiscountPercent(CustomerId).ToString();
            discountControl.txtDiscountPercent.Select();
            discountControl.txtDiscountPercent.Focus();
        }

        private void btnCancelCustomer_Click(object sender, EventArgs e)
        {
            CustomerId = "";
            customerName = "";
            txtCustomerName.Text = customerName;
            discountControl.txtDiscountPercent.Text = "0";
            discountControl.txtDiscountPercent.Select();
            discountControl.txtDiscountPercent.Focus();
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

        private void TransactionSave(string customerid)
        {
            int billno = RestoSys.RestoSysDAl.Savetransaction(customerid, calculator, _dtItems);
            if (ApplicationSetting.PrintBilll)
            {
                RestoSys.BLL.PrintTheBill prntBill = new PrintTheBill();
                prntBill.printBillGDI(_dtItems, billno, txtTender.Text, sevenPayAmount.Value.ToString(),
                     sevenShoppingAmount.Value.ToString(), discountControl.DiscountAmount.ToString(),
                     sevenReturn.Value.ToString(), sevenVat.Value.ToString(), sevenServiceCharge.Value.ToString());
            }
            DialogResult = DialogResult.OK;
        }

        private void DisplayData()
        {
            sevenShoppingAmount.Value = calculator.Amount.ToString();
            sevenServiceCharge.Value = calculator.ServiceCharge.ToString();
            sevenVat.Value = calculator.VAT.ToString();
            sevenSubTotal.Value = calculator.AmountAfterDiscount.ToString();
            sevenReturn.Value = calculator.ReturnAmt.ToString();
            sevenPayAmount.Value = calculator.AmountToPay.ToString();
            //discountControl.Amount = calculator.AmountAfterServiceCharge;
            lblInWords.Text = new Bsoft.Common.NumberInWords().inWords(calculator.AmountToPay.ToString());
        }

        private void txtTender_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtTender.Text = sevenPayAmount.Value.ToString();
        }
    
    }
}
