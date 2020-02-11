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
namespace Pasal.Reports
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmSalesReport : Friuts .ListingFormBase
    {
        public frmSalesReport()
        {
            InitializeComponent();
            FormType = FormTypes.Report;
            ListingDataGridView = grid;
            TableName = "Product_Master";
            searchCriterion1.grpDateFromTo.Text = "Selling Date Range";
            loadDataGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
         
            AddSearchCriteria();
            LoadData();
            displaySummary("profit", lblProfit);
            displaySummary("adjustedCostPrice", lblTotalStandardCost);
            displaySummary("adjustedGrossAmount", lblAmount);

            displaySummary("adjustedDiscount", lblDiscount);
            displaySummary("adjustedAmount", lblNetAmount);
            displaySummary("t2_listprice", lblNetAmount);
           
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
                 ComboUtilities .LoadData ("ID", "Name", "Product_Group_Master",searchCriterion1 . cboGroup, false,"");
                 ComboUtilities.LoadData("ID", "Name", "Product_Company_Master", searchCriterion1.cboCompany, false, "");
                 ComboUtilities.LoadData("ID", "Name", "Vendor_Master", searchCriterion1.cboVendor, false, "");
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
            DataTableColumns.Add("t5_Name", ColumnTypes.String, "colfk_User");
            DataTableColumns.Add("salesreturn", ColumnTypes.AmountRound2, "colSalesRetrun");
            DataTableColumns.Add("t1_Date", ColumnTypes.String, "colentrydate");
        }
        public override bool GenerateSelectSQL()
        {   //Product_Master t1
            //Product_Group_Master t2
            //Product_Company_Master  t3
            //People_User_Master t5 
            //Unit_Master t6 t7 t8
            //Inv_sale t4
            //Inv_Purchase  t9 

            StringBuilder SQL = new StringBuilder();


            SQL.Append(@" 
    select  
    Purchase.productname as productname,
    Purchase.code as Code,
    Purchase.product_group_master_id,
    Purchase.vendor_master_id,
    Purchase.product_company_master_id ,
    InvSales.Rate t2_listprice , 
   IFNULL( InvSales.salesreturn ,0)as salesreturn ,
    IFNULL(InvSales.Quantity,0) t1_Quantity, 
    InvSales.Amount t1_Amount, 
   IFNULL( InvSales.Discount,0) t1_Discount, 
   IFNULL( InvSales.Amount,0) - ( IFNULL(InvSales.Amount,0) * IFNULL(InvSales.salesreturn,0)  /InvSales.Quantity)  as adjustedGrossAmount, 
    InvSales.CostPrice * ( InvSales.Quantity-IFNULL(InvSales.salesreturn,0))    as adjustedCostPrice, 
    InvSales.Discount - (InvSales.Discount * IFNULL(InvSales.salesreturn,0)  /InvSales.Quantity)  as adjustedDiscount, 
    InvSales.NetAmount - (InvSales.NetAmount * IFNULL(InvSales.salesreturn,0)  /InvSales.Quantity ) as adjustedAmount, 
    InvSales.NetAmount - (InvSales.NetAmount * IFNULL(InvSales.salesreturn,0)  /InvSales.Quantity)  - ((InvSales.Quantity-IFNULL(InvSales.salesreturn,0) ) * InvSales.CostPrice)  as Profit , 
    InvSales.NetAmount t1_NetAmount, 
    InvSales.Remarks t1_Remarks, 
    InvSales.Date t1_Date, 
    rights_users.engname t5_Name 
    from 
    Inv_Sale InvSales 
    left outer join  productsall Purchase on InvSales.fk_Purchage = Purchase.Inv_PurchaseId
    left outer join  rights_users   on rights_users.id  = InvSales.fk_User  
                 ");

            SQL.Append(" \nwhere");
            SQL.Append(" \n 1=1 ");

            ComboItem citem;

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
                SQL.Append(" \n AND product_group_master_id =" + citem.Key.ToString());
            }
            if (searchCriterion1.cboCompany.Text != "")
            {
                citem = (ComboItem)searchCriterion1.cboCompany.SelectedItem;
                SQL.Append(" \n AND product_company_master_id=" + citem.Key.ToString());
            }

            if (searchCriterion1.cboVendor.Text != "")
            {
                citem = (ComboItem)searchCriterion1.cboVendor.SelectedItem;
                SQL.Append(" \n AND vendor_master_id =" + citem.Key.ToString());
            }

            if (searchCriterion1 .dtFromPurchage   .Checked)
            {
                SQL.Append(" \n AND t1_date >= '" + searchCriterion1.dtFromPurchage.Value.ToString(Configuration .DB_DATE_FORMAT ) + "'");
            }
            if (searchCriterion1.dtToPurchage .Checked)
            {
                SQL.Append(" \n AND t1_date <= '" + searchCriterion1.dtToPurchage.Value.ToString(Configuration.DB_DATE_FORMAT) + "'");
            }

            SelectSQL = SQL.ToString();
            return true;
            //   // return base.GenerateSelectSQL();
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

