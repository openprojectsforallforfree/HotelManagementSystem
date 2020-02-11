using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using Bsoft.Forms;
using Bsoft.Data;
using UEMS.Reports;
namespace RestoSys.Reports
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class TransactionReport : Friuts.ListingFormBase
    {
        public TransactionReport()
        {
            InitializeComponent();
            FormType = FormTypes.Report;
            ListingDataGridView = grid;
            TableName = "TransactionReportView";
            dtFrom.Select();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
            string s = SelectSQL;
            displaySummary("colAmount", lblAmount);
            displaySummary("colDiscount", lblDiscount);
            displaySummary("colServiceCharge", lblServiceCharge);
            displaySummary("colVAT", lblVAT);
            displaySummary("colCredit", lblCredit);
            displaySummary("colDue", lblDue);

        }


        private void frmproductSumrpt_Load(object sender, EventArgs e)
        {
            ComboBoxDataLoader loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add("ID", "EngName", "SuperAdmin_Rights_Users", cboUser, false);
            loader.LoadDataInComboBoxes();
            btnSearch.Select();

            DataTableColumns.Add("TransactionDate", ColumnTypes.EnglishDate , "colDate");
            DataTableColumns.Add("Amount", ColumnTypes.AmountRound2, "colAmount");
            DataTableColumns.Add("Discount", ColumnTypes.AmountRound2, "colDiscount");
            DataTableColumns.Add("ServiceCharge", ColumnTypes.AmountRound2, "colServiceCharge");
            DataTableColumns.Add("VAT", ColumnTypes.AmountRound2, "colVAT");
            DataTableColumns.Add("UserName", ColumnTypes.String, "colUser");
            DataTableColumns.Add("Customer", ColumnTypes.String , "colCustomer");
            DataTableColumns.Add("Credit", ColumnTypes.AmountRound2, "colCredit");
            DataTableColumns.Add("Due", ColumnTypes.AmountRound2, "colDue");
            DataTableColumns.Add("Tender", ColumnTypes.AmountRound2, "colTender");
            DataTableColumns.Add("ReturnAmt", ColumnTypes.AmountRound2, "colReturn");
        }

        public override string GetWhereClauseForSelect()
        {
            ComboItem citem;
            StringBuilder SQL = new StringBuilder();
            SQL.AppendLine("WHERE 1 = 1 ");
            if (txtCustomerName.Text.Trim() != "")
            {
                SQL.AppendFormat(" \n AND Customer like '{0}%'", txtCustomerName.Text.Trim());
            }
            if (cboUser.Text != "")
            {
                citem = (ComboItem)cboUser.SelectedItem;
                SQL.Append(" \n AND UserId=" + citem.Key.ToString());
            }
            if (dtFrom.Checked)
            {
                SQL.Append(" \n AND TransactionDate >= '" + dtFrom.Value.ToString(Configuration.DB_DATE_FORMAT) + "'");
            }
            if (dtTo.Checked)
            {
                SQL.Append(" \n AND TransactionDate <= '" + dtTo.Value.ToString(Configuration.DB_DATE_FORMAT) + "'");
            }
           
            if (cboDue.Checked)
            {
                SQL.Append(" \n AND Due > '0'");
            }
            if (cboCredit.Checked)
            {
                SQL.Append(" \n AND Credit > '0'");
            }
            return SQL.ToString();
        }


        private void ExportToolbar_Click(object sender, EventArgs e)
        {
            ExcelReport excel = new ExcelReport(this.Text, 4, grid);
        }

        private void displaySummary(String colName, Control ctrl)
        {
            decimal total = 0;
            foreach (DataGridViewRow dgvr in grid.Rows)
            {
                decimal val = 0;
                try
                {
                    val = Math.Round(Convert.ToDecimal(dgvr.Cells[colName].Value.ToString()), 2);
                }
                catch { }

                total += val;
            }
            ctrl.Text = total.ToString();
        }


    }
}

