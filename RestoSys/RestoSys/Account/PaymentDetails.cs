using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Friuts;
using RestoSys.BLL;
using RestoSys.DAl;
using Bsoft.Common;
using Bsoft.Common.Utilities;
using Bsoft.Account;
using Bsoft.Forms;
using RestoSys.Reports;
namespace RestoSys.Account
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class PaymentDetails : Friuts.ListingFormBase  
    {
        public PaymentDetails()
        {
            InitializeComponent();
            TableName = "aa";
            ListingDataGridView = grid;
            LoadDataInFormLoad = false;
            FormType = FormTypes.MultipleSelect;
        }
        string CustomerId = "";
        DataTable DtItems = new DataTable();
        public PaymentDetails(DataTable _dtItems, string _customerId)
        {
            CustomerId = _customerId;
            DtItems = _dtItems;
            InitializeComponent();
            TableName = "aa";
            ListingDataGridView = grid;
            LoadDataInFormLoad = false;
            FormType = FormTypes.MultipleSelect;

            DataTableColumns.Add("id", ColumnTypes.Number, "bookingid");
            DataTableColumns.Add("fk_product", ColumnTypes.Number, "productId");
            DataTableColumns.Add("ProductName", ColumnTypes.Number, "description");
            DataTableColumns.Add("quantity", ColumnTypes.Number, "quantity");
            DataTableColumns.Add("rate", ColumnTypes.Number, "rate");
            DataTableColumns.Add("amount", ColumnTypes.Number, "amount");
            DataTableColumns.Add("discount", ColumnTypes.Number, "discount");
            DataTableColumns.Add("netamount", ColumnTypes.Number, "netamount");
            DataTableColumns.Add("dueamt", ColumnTypes.Number, "dueamount");
            DataTableColumns.Add("tableName", ColumnTypes.String, "colTableName");
            DataTableColumns.Add("vat", ColumnTypes.String, "vat");
            DataTableColumns.Add("servicecharge", ColumnTypes.String, "ServiceCharge");
            LoadDataTable(_dtItems);
            MultiSelectSelectAll();
            Text = "Pay ment details for customer : {0}".With(CustomerDAL.GetCustomerName(_customerId));
        }
        private DataGridViewCellStyle dataGridRowStyle = new DataGridViewCellStyle();
        private DataGridViewCellStyle dataGridColumnHeaderCellStyle = new DataGridViewCellStyle();
        private DataGridViewCellStyle dataGridCellStyle = new DataGridViewCellStyle();
        private DataGridViewCellStyle dataGridViewRowHeaderCellStyle = new DataGridViewCellStyle();


        //override this to make sure the multi select works properly
        public override void SetDataGridViewProperties(DataGridView dataGridView)
        {

            dataGridView.ColumnHeadersHeight = 35;
            dataGridView.RowHeadersWidth = 54;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = true;
            dataGridView.MultiSelect = false;
            dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(223)))), ((int)(((byte)(224)))));

            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView.StandardTab = true; //required...
            ////Column Header Style
            dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridColumnHeaderCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridColumnHeaderCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            dataGridColumnHeaderCellStyle.Font = dataGridView.ColumnHeadersDefaultCellStyle.Font;
            dataGridColumnHeaderCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridColumnHeaderCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridColumnHeaderCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridColumnHeaderCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridColumnHeaderCellStyle;

            ////Cell Style
            dataGridCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(223)))), ((int)(((byte)(224)))));
            dataGridCellStyle.Font = dataGridView.DefaultCellStyle.Font;
            dataGridCellStyle.ForeColor = System.Drawing.Color.Black;
            dataGridCellStyle.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridCellStyle.NullValue = string.Empty;
            dataGridView.DefaultCellStyle = dataGridCellStyle;

            dataGridRowStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));

            dataGridView.AlternatingRowsDefaultCellStyle = dataGridRowStyle;

            //Row Header Style
            dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewRowHeaderCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewRowHeaderCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));

            dataGridViewRowHeaderCellStyle.Font = Bsoft.Design.FormDesginBase.DigitFont;
            dataGridViewRowHeaderCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridViewRowHeaderCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewRowHeaderCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewRowHeaderCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewRowHeaderCellStyle;

        }




        private void fsButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }



        private void txtTender_TextChanged(object sender, EventArgs e)
        {

            //pay.Tenderamount = txtTender.Text.ToDecimal();
            //sevenReturn.Value = pay.ReturnAmount.ToString ();

        }

        PayMent pay = null;
        DataTable cDataTable = new DataTable();

        // amount is amount paid by customer or amount refunded
        private void Calculate()
        {
            cDataTable = GetMultiSelectDataTable();
            pay = new PayMent(cDataTable, txtAmountPaid.Text.ToDecimal());
            sevenTotalDue.Value = pay.SumdueAmount.ToString();

            DataTable summary = new DataTable();
            summary.Columns.Add("Name");
            summary.Columns.Add("Value");
            summary.Rows.Add("Amount", pay.SumAmount);
            summary.Rows.Add("Discount", pay.SumDiscount);
            if (pay.Sumservicecharge > 0)
            {
                summary.Rows.Add("Service Charge", pay.Sumservicecharge);
                summary.Rows.Add("Taxable Amount", pay.TaxableAmount);
            }
            if (pay.Sumvat > 0)
            {
                summary.Rows.Add("VAT", pay.Sumvat);
            }

            summary.Rows.Add("NetAmount", pay.SumnetAmount);
            if (pay.SumnetAmount - pay.SumdueAmount > 0)
            {
                summary.Rows.Add("Paid Amount", pay.SumnetAmount - pay.SumdueAmount);
                summary.Rows.Add("Due Amount", pay.SumdueAmount);
            }


            gridSummary.DataSource = summary;
            gridSummary.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridSummary.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            sevenDueAmount.Value = (sevenTotalDue.Value.ToDecimal() - txtAmountPaid.Text.ToDecimal()).ToString();
            txtAmountPaid.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAmountPaid.Text.ToDecimal() == 0)
            {
                MessageBoxMy.Show("Please enter some amount first.");
                txtAmountPaid.Focus();
                return;
            }
            string message = "Did you receive Rs {0}?";
            if (txtAmountPaid.Text.ToDecimal() < 0)
            {
                message = "Did you refund Rs {0}.?";
            }
            if (MessageBoxMy.Show(message.With(StringUtilities.GetMoneyFromat(txtAmountPaid.Text)), MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string billno = PaymentDAL.Savetransaction(CustomerId, pay, cDataTable);
                pay.BillNumber = billno;
                if (ApplicationSetting.PrintBilll)
                {
                    Hotel_Invoice prnt = new Hotel_Invoice();
                    prnt.printBillGDI(
                        pay
                        );
                }
                DialogResult = DialogResult.OK;
            }
        }


        private void grid_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (grid.IsCurrentCellDirty)
            {
                grid.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.Rows.Count > 0)
            {
                Calculate();
            }
        }

        private void lblcopy_Click(object sender, EventArgs e)
        {
            txtAmountPaid.Text = sevenTotalDue.Value.ToString();
        }

        private void txtAmountPaid_TextChanged(object sender, EventArgs e)
        {

            Calculate();
            if (txtAmountPaid.Value.Contains("-"))
            {
                lblPayamount.Text = "Refunded Amount";
            }
            else
            {
                lblPayamount.Text = "Received Amount";
            }

            if (sevenDueAmount.Value.ToDecimal() < 0)
            {
                lblDue.Text = "Amount to Refund";
            }
            else
            {
                lblDue.Text = "Due Amount";
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            // base.OnKeyDown(e);
            if (e.KeyCode == Keys.Enter)
            {
                if (ActiveControl is  TextBox )
                {
                    TextBox MultiLine = (TextBox)ActiveControl;
                    if (MultiLine.Multiline)
                    {
                        return; //do noing
                    }
                    else
                    {
                        SendKeys.Send("{TAB}");
                    }
                }
            }
            
            if (e.KeyCode == Keys.Tab)
            {
                if (ActiveControl is TextBox)
                {
                    TextBox TxtBox = (TextBox)ActiveControl;
                    TxtBox.SelectAll(); //Text higlighted..
                }
            }
        }
    }
}
