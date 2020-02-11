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
namespace Pasal.Reports
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmStockrpt : Friuts.ListingFormBase
    {
        public frmStockrpt()
        {
            InitializeComponent();
            FormType = FormTypes.Report;
            ListingDataGridView = grid;
            TableName = "Product_Master";
            loadDataGrid();
            searchCriterion1.txtName.Select();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            AddSearchCriteria();
            LoadData();
            displaySummary("colTotalStockCost", lblStockCost);
            displaySummary("colTotlStockMRP", lblStockMRP);

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
           loader.ComboLoadinfoItems.Add("ID", "Name", "Product_Group_Master", searchCriterion1 . cboGroup, false);
           ComboBoxDataLoader loader1 = new ComboBoxDataLoader();
           loader1.ComboLoadinfoItems.Add("ID", "Name", "Product_Company_Master", searchCriterion1.cboCompany, false);
           ComboBoxDataLoader loader2 = new ComboBoxDataLoader();
           loader2.ComboLoadinfoItems.Add("ID", "Name", "Vendor_Master", searchCriterion1.cboVendor  , false);
           //loader.ComboLoadinfoItems.Add("ID", "Name", "Unit_Master", cboSizeUnit, false);
           //loader.ComboLoadinfoItems.Add("ID", "Name", "Unit_Master", cboWeightUnit, false);
           loader.LoadDataInComboBoxes();
           loader1.LoadDataInComboBoxes();
           loader2.LoadDataInComboBoxes();
            btnSearch.Select();
           
        }



        private void loadDataGrid()
        {
            DataTableColumns.Add("code", ColumnTypes.String, "colcode");
            DataTableColumns.Add("ProductName", ColumnTypes.String, "colProductName");
            DataTableColumns.Add("Company", ColumnTypes.String, "colCompany");
            DataTableColumns.Add("Group", ColumnTypes.String, "colGroup");
          //  DataTableColumns.Add("LatestPurchageDate ", ColumnTypes.EnglishDate, "colLatestPurchageDate");
            DataTableColumns.Add("TotalQuantityPurchaged ", ColumnTypes.AmountRound2, "colTotalQuantityPurchaged");
            DataTableColumns.Add("PurchageReturns", ColumnTypes.AmountRound2, "colPurchageReturns");
            DataTableColumns.Add("SalesReturns", ColumnTypes.AmountRound2, "colSalesReturns");
            DataTableColumns.Add("Damaged", ColumnTypes.AmountRound2, "colDamaged");
            DataTableColumns.Add("Sold", ColumnTypes.AmountRound2, "colSold");
            DataTableColumns.Add("stock", ColumnTypes.AmountRound2, "colstock");
            DataTableColumns.Add("TotalStockCost", ColumnTypes.AmountRound2, "colTotalStockCost");
            DataTableColumns.Add("TotlStockMRP", ColumnTypes.AmountRound2, "colTotlStockMRP");
        }

        public override bool GenerateSelectSQL()
        {
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@" 
                select code,
                ProductName,
                Company,
                [Group],
                max(purchagedate) as LatestPurchageDate ,
                sum(purchageQuantity) as TotalQuantityPurchaged,
                sum( purchasereturn) as PurchageReturns,
                sum(salesreturn) as SalesReturns,
                sum( DamageQuantity) as Damaged,
                sum(SoldQuantity) as Sold,
                sum( Stock) as stock ,
                sum( stock * cost) as TotalStockCost,
                sum( stock * MRP) as TotlStockMRP
                FROM productsall  
                where 1=1 
            ");



            ComboItem citem;
            if (searchCriterion1.txtCode.Text.Trim() != "")
            {
                SQL.AppendFormat(" \n AND code like '{0}%'", searchCriterion1.txtCode.Text.Trim());
            }
            if (searchCriterion1.txtName.Text.Trim() != "")
            {
                SQL.AppendFormat(" \n AND ProductName like '{0}%'", searchCriterion1.txtName.Text.Trim());
            }
            if (searchCriterion1.cboGroup.Text != "")
            {
                citem = (ComboItem)searchCriterion1.cboGroup.SelectedItem;
                SQL.Append(" \n AND Product_Group_Master_id=" +  citem.Key.ToString());
            }
            if (searchCriterion1.cboCompany.Text != "")
            {
                citem = (ComboItem)searchCriterion1.cboCompany.SelectedItem;

                SQL.Append(" \n AND Product_Company_Master_id=" + citem.Key.ToString());
            }

            if (searchCriterion1.cboVendor.Text != "")
            {
                citem = (ComboItem)searchCriterion1.cboVendor.SelectedItem;

                SQL.Append(" \n AND Vendor_Master_id =" +  citem.Key.ToString());
            }

            if (searchCriterion1.dtFromPurchage.Checked)
            {
                SQL.Append(" \n AND Inv_Purchase_entrydate >= '" + searchCriterion1.dtFromPurchage.Value.ToString(Configuration .DB_DATE_FORMAT ) + "'");
            }
            if (searchCriterion1.dtToPurchage.Checked)
            {
                SQL.Append(" \n AND Inv_Purchase_entrydate <= '" + searchCriterion1.dtToPurchage.Value.ToString(Configuration.DB_DATE_FORMAT) + "'");
            }

            SelectSQL = SQL.ToString() + " GROUP BY Code,ProductName,Company,[Group]";
            return true;
        }

        public override string GetWhereClauseForSelect()
        {
            StringBuilder sqlNew = new StringBuilder();
            return "";
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

