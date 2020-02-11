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
    public partial class frmStockrpt : Friuts.ListingFormBase
    {
        public frmStockrpt()
        {
            InitializeComponent();
            FormType = FormTypes.Report;
            ListingDataGridView = grid;
            TableName = "StockReportView";
            searchCriterion1.lblVendor.Visible = false;
            searchCriterion1.cboVendor.Visible = false;
            lblStockCost.Visible = false;
            lblStockMRP.Visible = false;
            label5.Visible = false;
            lblStockSP.Visible = false;
            searchCriterion1.txtName.Select();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
            string s = SelectSQL;
            //displaySummary("colTotalStockCost", lblStockCost);
            //displaySummary("colTotlStockMRP", lblStockMRP);
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

        private void frmproductSumrpt_Load(object sender, EventArgs e)
       {
           ComboBoxDataLoader loader = new ComboBoxDataLoader();
           loader.ComboLoadinfoItems.Add("ID", "Name", "Master_Product_Group", searchCriterion1 . cboGroup, false);
           ComboBoxDataLoader loader1 = new ComboBoxDataLoader();
           loader1.ComboLoadinfoItems.Add("ID", "Name", "Master_Product_Company", searchCriterion1.cboCompany, false);
           ComboBoxDataLoader loader2 = new ComboBoxDataLoader();
           loader2.ComboLoadinfoItems.Add("ID", "Name", "Master_Vendor", searchCriterion1.cboVendor  , false);
           //loader.ComboLoadinfoItems.Add("ID", "Name", "Master_Unit", cboSizeUnit, false);
           //loader.ComboLoadinfoItems.Add("ID", "Name", "Master_Unit", cboWeightUnit, false);
           loader.LoadDataInComboBoxes();
           loader1.LoadDataInComboBoxes();
           loader2.LoadDataInComboBoxes();
            btnSearch.Select();

            DataTableColumns.Add("code", ColumnTypes.String, "colcode");
            DataTableColumns.Add("Name", ColumnTypes.String, "colProductName");
            DataTableColumns.Add("CompanyName", ColumnTypes.String, "colCompany");
            DataTableColumns.Add("GroupName", ColumnTypes.String, "colGroup");
            //  DataTableColumns.Add("LatestPurchageDate ", ColumnTypes.EnglishDate, "colLatestPurchageDate");
            DataTableColumns.Add("Purchase ", ColumnTypes.AmountRound2, "colTotalQuantityPurchaged");
            DataTableColumns.Add("PurchaseReturn", ColumnTypes.AmountRound2, "colPurchageReturns");
            DataTableColumns.Add("SalesReturn",ColumnTypes.AmountRound2, "colSalesReturns");
            DataTableColumns.Add("Damaged", ColumnTypes.AmountRound2, "colDamaged");
            
            DataTableColumns.Add("Lost", ColumnTypes.AmountRound2, "colLost");
            //DataTableColumns.Add("Damaged", ColumnTypes.AmountRound2, "colDamaged");

            DataTableColumns.Add("-1*Sales", ColumnTypes.AmountRound2, "colSold");
            DataTableColumns.Add("Stock", ColumnTypes.AmountRound2, "colstock");
            //DataTableColumns.Add("TotalStockCost", ColumnTypes.AmountRound2, "colTotalStockCost");
            //DataTableColumns.Add("TotlStockMRP", ColumnTypes.AmountRound2, "colTotlStockMRP");

        }

        public override string GetWhereClauseForSelect()
        {
            ComboItem citem;
            StringBuilder SQL = new StringBuilder();
            SQL.AppendLine("WHERE 1 = 1 ");
            if (searchCriterion1.txtCode.Text.Trim() != "")
            {
                SQL.AppendFormat(" \n AND code like '{0}%'", searchCriterion1.txtCode.Text.Trim());
            }
            if (searchCriterion1.txtName.Text.Trim() != "")
            {
                SQL.AppendFormat(" \n AND Name like '{0}%'", searchCriterion1.txtName.Text.Trim());
            }
            if (searchCriterion1.cboGroup.Text != "")
            {
                citem = (ComboItem)searchCriterion1.cboGroup.SelectedItem;
                SQL.Append(" \n AND GroupId=" + citem.Key.ToString());
            }
            if (searchCriterion1.cboCompany.Text != "")
            {
                citem = (ComboItem)searchCriterion1.cboCompany.SelectedItem;

                SQL.Append(" \n AND CompanyId=" + citem.Key.ToString());
            }

            if (searchCriterion1.cboVendor.Text != "")
            {
                citem = (ComboItem)searchCriterion1.cboVendor.SelectedItem;

                SQL.Append(" \n AND Master_Vendor_id =" + citem.Key.ToString());
            }

            if (searchCriterion1.dtFromPurchage.Checked)
            {
                SQL.Append(" \n AND Entrydate >= '" + searchCriterion1.dtFromPurchage.Value.ToString(Configuration.DB_DATE_FORMAT) + "'");
            }
            if (searchCriterion1.dtToPurchage.Checked)
            {
                SQL.Append(" \n AND Entrydate <= '" + searchCriterion1.dtToPurchage.Value.ToString(Configuration.DB_DATE_FORMAT) + "'");
            }
            return SQL.ToString ();
        }


        private void ExportToolbar_Click(object sender, EventArgs e)
        {
            ExcelReport excel = new ExcelReport(this.Text, 4, grid);
        }

    }
}

