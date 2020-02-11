using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Fruits;
using Bsoft.Data;
using Friuts;
using UEMS.Reports;
using Bsoft.Forms;
namespace RestoSys.Reports
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmStockModfReport : Friuts.ListingFormBase
    {
        public string StockModtypeCode = "";
        public frmStockModfReport(string stockType):this()
        {
            StockModtypeCode = stockType;
            
        }
        public frmStockModfReport()
        {
            InitializeComponent();
            FormType = FormTypes.Report;
            ListingDataGridView = grid;
            TableName = "StockModfView";
            searchCriterion1.lblVendor.Visible = false;
            searchCriterion1.cboVendor.Visible = false;
            searchCriterion1.grpDateFromTo.Text = "Date Range";

            DataTableColumns.Add("ProductName", ColumnTypes.String, "colName");
            //DataTableColumns.Add("ItemTypeCode", ColumnTypes.EnglishDate, "colItemType");
            DataTableColumns.Add("ProductCode", ColumnTypes.String , "colCode");
            DataTableColumns.Add("Quantity ", ColumnTypes.AmountRound2, "colquantity");
            //DataTableColumns.Add("StockModfType ", ColumnTypes.AmountRound2, "colmrp");
            DataTableColumns.Add("DATE", ColumnTypes.EnglishDate , "colEntryDate");
            DataTableColumns.Add("Remarks", ColumnTypes.String , "colRemarks");
            DataTableColumns.Add("GroupName", ColumnTypes.String, "colGroup");
            DataTableColumns.Add("CompanyName", ColumnTypes.String , "colCompany");

        }

        public override string GetWhereClauseForSelect()
        {
            StringBuilder SQL = new StringBuilder();
            ComboItem citem;
            SQL.AppendLine("WHERE 1=1 ");
            if (StockModtypeCode.Length > 0)
            {
                SQL.Append(" \n AND StockModfType = '" + StockModtypeCode + "'");
            }
            if (searchCriterion1.txtCode.Text.Trim() != "")
            {
                SQL.AppendFormat(" \n AND ProductCode like '{0}%'", searchCriterion1.txtCode.Text.Trim());
            }
            if (searchCriterion1.txtName.Text.Trim() != "")
            {
                SQL.AppendFormat(" \n AND ProductName like '{0}%'", searchCriterion1.txtName.Text.Trim());
            }
            if (searchCriterion1.cboGroup.Text != "")
            {
                citem = (ComboItem)searchCriterion1.cboGroup.SelectedItem;
                SQL.Append(" \n AND GroupId =" + citem.Key.ToString());
            }
            if (searchCriterion1.cboCompany.Text != "")
            {
                citem = (ComboItem)searchCriterion1.cboCompany.SelectedItem;
                SQL.Append(" \n AND CompanyId.id=" + citem.Key.ToString());
            }
            //if (searchCriterion1.cboVendor.Text != "")
            //{
            //    citem = (ComboItem)searchCriterion1.cboVendor.SelectedItem;
            //    SQL.Append(" \n AND Master_Vendor.id =" + citem.Key.ToString());
            //}
            if (searchCriterion1.dtFromPurchage.Checked)
            {
                SQL.Append(" \n AND date >= '" + searchCriterion1.dtFromPurchage.Value.ToString("ddMMMyyyy") + "'");
            }
            if (searchCriterion1.dtToPurchage.Checked)
            {
                SQL.Append(" \n AND date <= '" + searchCriterion1.dtToPurchage.Value.ToString("ddMMMyyyy") + "'");
            }
            return SQL.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void frmproductrpt_Load(object sender, EventArgs e)
        {
            ComboBoxDataLoader loaderGroup = new ComboBoxDataLoader();
            loaderGroup.ComboLoadinfoItems.Add("ID", "Name", "Master_Product_Group", searchCriterion1.cboGroup, false);
            ComboBoxDataLoader loaderCompany = new ComboBoxDataLoader();
            loaderCompany.ComboLoadinfoItems.Add("ID", "Name", "Master_Product_Company", searchCriterion1.cboCompany, false);
            ComboBoxDataLoader loaderVendor = new ComboBoxDataLoader();
            loaderVendor.ComboLoadinfoItems.Add("ID", "Name", "Master_Vendor", searchCriterion1.cboVendor, false);
            loaderGroup.LoadDataInComboBoxes();
            loaderVendor.LoadDataInComboBoxes();
            loaderCompany.LoadDataInComboBoxes();
            btnSearch.Select();
            searchCriterion1.txtName.Select();
        }

        

        

        private void newToolbar_Click(object sender, EventArgs e)
        {
            Inventory.frmSaleEntry frm = new Inventory.frmSaleEntry(StockModtypeCode);
            frm.ShowDialog();
        }

        private void toolExcelExport_Click(object sender, EventArgs e)
        {
            ExcelReport excel = new ExcelReport(this.Text, 4, grid);
        }
    }
}

