using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using Bsoft.Forms;
using UEMS.Reports;
using Bsoft.Data;
namespace RestoSys.Reports
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmSalesReport : Friuts .ListingFormBase
    {
        public frmSalesReport()
        {
            InitializeComponent();
            FormType = FormTypes.Report;
            ListingDataGridView = grid;
            TableName = "SalesView";
            searchCriterion1.grpDateFromTo.Text = "Selling Date Range";
            loadDataGrid();

            if (Properties.Settings.Default.Type == SoftwareTypes.Ticket )
            {
               // grid.Columns["colSalesRetrun"].Visible = false;
                grid.Columns["colTotalCost"].Visible = false;
                grid.Columns["Profit"].Visible = false;
                //searchCriterion1.grpDateFromTo.Visible = false;
                searchCriterion1.lblfk_Company.Visible = searchCriterion1.cboCompany.Visible = false;
                searchCriterion1.cboVendor.Visible = searchCriterion1.lblVendor.Visible = false;

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
         
            AddSearchCriteria();
            LoadData();
            displaySummary("profit", lblProfit);
            displaySummary("adjustedCostPrice", lblTotalStandardCost);
            displaySummary("adjustedGrossAmount", lblAmount);

            displaySummary("adjustedDiscount", lblDiscount);
            //displaySummary("adjustedAmount", lblNetAmount);
           // displaySummary("t2_listprice", lblNetAmount);
           
            //lblTotalStandardCost.Text = getSummaryAmount("colstandardcost", "colquantity_sold").ToString();
            //decimal salesreturn = getSalesReturnAmount();

        }
        private decimal getSalesReturnAmount()
        {
            decimal total = 0;
            foreach (DataGridViewRow dgvr in grid.Rows)
            {
                decimal val = 0;
                try
                {

                    val = Convert.ToDecimal(dgvr.Cells["colstandardcost"].Value.ToString());
                }
                catch { }
                decimal qtyReturn = 0;
                try
                {

                    qtyReturn = Convert.ToDecimal(dgvr.Cells["colSalesRetrun"].Value.ToString());
                }
                catch { }
                decimal qty  = 0;
                try
                {

                    qty = Convert.ToDecimal(dgvr.Cells["colquantity_sold"].Value.ToString());
                }
                catch { }
                decimal discount = 0;
                try
                {

                    discount = Convert.ToDecimal(dgvr.Cells["colDiscount"].Value.ToString());
                }
                catch { }

                decimal discountCalc =( discount / qty )* qtyReturn;
                total += (val * qtyReturn) -discountCalc ;
            }

            return total;
        }

        private decimal getSummaryAmount(String colAmount, string colquantity)
        {
            decimal total = 0;
            foreach (DataGridViewRow dgvr in grid.Rows)
            {
                decimal val = 0;
                try
                {

                    val = Convert.ToDecimal(dgvr.Cells[colAmount].Value.ToString());
                }
                catch { }
                decimal qty = 0;
                try
                {

                    qty = Convert.ToDecimal(dgvr.Cells[colquantity].Value.ToString());
                }
                catch { }
                total += (val * qty);
            }

            return total;
        }
        private void displaySummary(String colName, Control ctrl)
        {
            decimal total = 0;
            foreach (DataRow dr in _formDataTable.Rows)
            {
                decimal val = 0;
                try
                {

                    val = Math.Round(Convert.ToDecimal(dr[colName].ToString()), 2);
                }
                catch { }

                total += val;
            }
            ctrl.Text = total.ToString();
        }
        private void displaySummaryGrid(String colName, Control ctrl)
        {
            decimal total = 0;
            foreach (DataGridViewRow dgvr in grid.Rows)
            {
                decimal val = 0;
                try
                {

                    val =Math .Round ( Convert.ToDecimal(dgvr.Cells[colName].Value.ToString()),2);
                }
                catch { }

                total += val;
            }
            ctrl.Text = total.ToString();
        }

        private void frmSalesReport_Load(object sender, EventArgs e)
        {
                 ComboUtilities .LoadData ("ID", "Name", "Master_Product_Group",searchCriterion1 . cboGroup, false,"");
                 ComboUtilities.LoadData("ID", "Name", "Master_Product_Company", searchCriterion1.cboCompany, false, "");
                 ComboUtilities.LoadData("ID", "Name", "Master_Vendor", searchCriterion1.cboVendor, false, "");
                 searchCriterion1.txtName.Select();
        }

        private void loadDataGrid()
        {
            //  DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
          
            DataTableColumns.Add("Code", ColumnTypes.String, "colCode");
            DataTableColumns.Add("productname", ColumnTypes.String, "colName");
            DataTableColumns.Add("t1_Quantity", ColumnTypes.AmountRound2, "colquantity_sold");
          
            DataTableColumns.Add("Profit", ColumnTypes.AmountRound2, "Profit");

            DataTableColumns.Add("adjustedCostPrice", ColumnTypes.AmountRound2, "colTotalCost");
            DataTableColumns.Add("adjustedGrossAmount", ColumnTypes.AmountRound2, "colAmount");
         //   DataTableColumns.Add("t1_Amount", ColumnTypes.AmountRound2, "colAmount");


            DataTableColumns.Add("adjustedDiscount", ColumnTypes.AmountRound2, "colDiscount");
           //DataTableColumns.Add("t1_Discount", ColumnTypes.AmountRound2, "colDiscount");

            DataTableColumns.Add("adjustedAmount", ColumnTypes.AmountRound2, "colNetAmount");
          //  DataTableColumns.Add("t1_NetAmount", ColumnTypes.AmountRound2, "colNetAmount");
            
            DataTableColumns.Add("t2_listprice", ColumnTypes.AmountRound2, "collistprice");
            DataTableColumns.Add("t5_Name", ColumnTypes.String, "colUserId");
            DataTableColumns.Add("salesreturn", ColumnTypes.AmountRound2, "colSalesRetrun");
            DataTableColumns.Add("t1_Date", ColumnTypes.EnglishDate , "colentrydate");
        }
       

        public override string GetWhereClauseForSelect()
        {
            ComboItem citem;
            StringBuilder SQL = new StringBuilder();
            SQL.AppendLine("WHERE 1=1 ");
            if (searchCriterion1.txtCode.Text.Trim() != "")
            {
                SQL.AppendFormat(" \n AND code like '{0}%'", searchCriterion1.txtCode.Text.Trim());
            }
            if (searchCriterion1.txtName.Text.Trim() != "")
            {
                SQL.AppendFormat(" \n AND productname like '{0}%'", searchCriterion1.txtName.Text.Trim());
            }
            if (searchCriterion1.cboGroup.Text != "")
            {
                citem = (ComboItem)searchCriterion1.cboGroup.SelectedItem;
                SQL.Append(" \n AND Master_Product_Group_id =" + citem.Key.ToString());
            }
            if (searchCriterion1.cboCompany.Text != "")
            {
                citem = (ComboItem)searchCriterion1.cboCompany.SelectedItem;
                SQL.Append(" \n AND Master_Product_Company_id=" + citem.Key.ToString());
            }

            if (searchCriterion1.cboVendor.Text != "")
            {
                citem = (ComboItem)searchCriterion1.cboVendor.SelectedItem;
                SQL.Append(" \n AND Master_Vendor_id =" + citem.Key.ToString());
            }

            if (searchCriterion1.dtFromPurchage.Checked)
            {
                SQL.Append(" \n AND t1_date >= '" + searchCriterion1.dtFromPurchage.Value.ToString(Configuration.DB_DATE_FORMAT) + "'");
            }
            if (searchCriterion1.dtToPurchage.Checked)
            {
                SQL.Append(" \n AND t1_date <= '" + searchCriterion1.dtToPurchage.Value.ToString(Configuration.DB_DATE_FORMAT) + "'");
            }

            return SQL.ToString();
            
        }

        private void AddSearchCriteria()
        {
            SearchConditionList.Clear();
        }

        private void ExportToolbar_Click(object sender, EventArgs e)
        {
            ExcelReport excel = new ExcelReport(this.Text, 4, grid);
        }


    }
}

