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
    public partial class frmPurchaseReport : Friuts.ListingFormBase
    {
        public frmPurchaseReport()
        {
            InitializeComponent();
            FormType = FormTypes.Report;
            ListingDataGridView = grid;
            TableName = "PurchaseRptView";
            if (Properties.Settings.Default.Type == SoftwareTypes.Ticket)
            {
                grid.Columns["colcost"].Visible = false;
                grid.Columns["colCompany"].Visible = false;
                grid.Columns["colstock"].Visible = false;
                grid.Columns["colQuantity"].Visible = false;
                grid.Columns["colquantity_damage"].Visible = false;
                grid.Columns["colpurchaseReturn"].Visible = false;
                // grid.Columns["colSalesReturn"].Visible = false;
                grid.Columns["colVendorName"].Visible = false;
                grid.Columns["colPurchageDate"].Visible = false;
                //searchCriterion1.grpDateFromTo.Visible = false;
                searchCriterion1.lblfk_Company.Visible = searchCriterion1.cboCompany.Visible = false;
                searchCriterion1.cboVendor.Visible = searchCriterion1.lblVendor.Visible = false;
            }
            searchCriterion1.grpDateFromTo.Visible = true;
            loadDataGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            AddSearchCriteria();
            LoadData();
        }

        private void frmproductrpt_Load(object sender, EventArgs e)
        {
            ComboBoxDataLoader loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add("ID", "Name", "Master_Product_Group", searchCriterion1.cboGroup, false);
            ComboBoxDataLoader loader2 = new ComboBoxDataLoader();
            loader2.ComboLoadinfoItems.Add("ID", "Name", "Master_Product_Company", searchCriterion1.cboCompany, false);
            ComboBoxDataLoader loader1 = new ComboBoxDataLoader();
            loader1.ComboLoadinfoItems.Add("ID", "Name", "Master_Vendor", searchCriterion1.cboVendor, false);
            //loader.ComboLoadinfoItems.Add("ID", "Name", "Master_Unit", cboSizeUnit, false);
            //loader.ComboLoadinfoItems.Add("ID", "Name", "Master_Unit", cboWeightUnit, false);
            loader.LoadDataInComboBoxes();
            loader1.LoadDataInComboBoxes();
            loader2.LoadDataInComboBoxes();
            btnSearch.Select();
            searchCriterion1.txtName.Select();
        }



        private void loadDataGrid()
        {
            //DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("ProductName", ColumnTypes.String, "colName");
            DataTableColumns.Add("purchagedate", ColumnTypes.EnglishDate, "colPurchageDate");

            DataTableColumns.Add("purchageQuantity", ColumnTypes.AmountRound2, "colquantity");
            DataTableColumns.Add("cost ", ColumnTypes.AmountRound2, "colcost");
            DataTableColumns.Add("MRP ", ColumnTypes.AmountRound2, "colmrp");
            DataTableColumns.Add("DamageQuantity", ColumnTypes.AmountRound2, "colquantity_damage");
            DataTableColumns.Add("SoldQuantity", ColumnTypes.AmountRound2, "colquantity_sold");

            DataTableColumns.Add("purchasereturn", ColumnTypes.AmountRound2, "colpurchasereturn");
            DataTableColumns.Add("salesreturn", ColumnTypes.AmountRound2, "colsalesreturn");
            DataTableColumns.Add("ConsumedQuantity", ColumnTypes.AmountRound2, "colconsumed");
            DataTableColumns.Add("code", ColumnTypes.String, "colcode");
            DataTableColumns.Add("stock", ColumnTypes.AmountRound2, "colstock");
            //DataTableColumns.Add("t1_Code", ColumnTypes.String, "colCode");


            DataTableColumns.Add("GroupName", ColumnTypes.String, "colGroup");
            DataTableColumns.Add("Company", ColumnTypes.String, "colCompany");
            DataTableColumns.Add("VendorName", ColumnTypes.String, "colVendorName");

            if (Properties.Settings.Default.Type == SoftwareTypes.Ticket)
            {
                searchCriterion1.grpDateFromTo.Visible = false;
            }
        }

        public bool GenerateSelectSQL1()
        {
            StringBuilder SQL = new StringBuilder();
            SQL.Append(@" 
select distinct
inv_purchaseId ,ProductName,
case when 
itemtype = 'M' or itemtype ='S' or itemtype ='H' or itemtype ='L' 
then 
'-'
else
purchagedate
end as
purchagedate,

case when 
itemtype = 'M' or itemtype ='S' or itemtype ='H' or itemtype ='L' 
then 
'-'
else
purchageQuantity
end as 
purchageQuantity
,cost,purchasereturn,salesreturn
,mrp,DamageQuantity,SoldQuantity,ConsumedQuantity,

case when 
itemtype = 'M' or itemtype ='S' or itemtype ='H' or itemtype ='L' 
then 
'-'
else
Stock
end as Stock
,code,company,`Group`,VendorName
from Productsall
where 1=1
");


            // SQL.Append(" \n where t1.id = t1.id");

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
                SQL.Append(" \n AND Master_Product_Group.id=" + citem.Key.ToString());
            }
            if (searchCriterion1.cboCompany.Text != "")
            {
                citem = (ComboItem)searchCriterion1.cboCompany.SelectedItem;

                SQL.Append(" \n AND Master_Product_Company.id=" + citem.Key.ToString());
            }

            if (searchCriterion1.cboVendor.Text != "")
            {
                citem = (ComboItem)searchCriterion1.cboVendor.SelectedItem;

                SQL.Append(" \n AND Master_Vendor.id =" + citem.Key.ToString());
            }
            //if (dtSellingFrom.Checked)
            //{
            //    SQL.Append(" \n AND t9.Date >= '" + dtSellingFrom.Value.ToString("ddMMMyyyy") + "'");
            //}
            //if (dtSellingTo.Checked)
            //{
            //    SQL.Append(" \n AND t9.Date <= '" + dtSellingTo.Value.ToString("ddMMMyyyy") + "'");
            //}
            if (searchCriterion1.dtFromPurchage.Checked)
            {
                SQL.Append(" \n AND Inv_Purchase.entrydate >= '" + searchCriterion1.dtFromPurchage.Value.ToString("yyyyMMdd") + "'");
            }
            if (searchCriterion1.dtToPurchage.Checked)
            {
                SQL.Append(" \n AND Inv_Purchase.entrydate <= '" + searchCriterion1.dtToPurchage.Value.ToString("yyyyMMdd") + "'");
            }

            SelectSQL = SQL.ToString();
            return true;
        }

        public bool GenerateSelectSQL2()
        {   //Master_Product t1
            //Master_Product_Group t2
            //Master_Product_Company  t3
            //Master_People_User t5 
            //Master_Unit t6 t7 t8
            //Inv_sale t4
            //Inv_Purchase  t9 

            StringBuilder SQL = new StringBuilder();
            SQL.Append(" \nSELECT DISTINCT");
            SQL.Append(" \nt1.Id Id,");
            SQL.Append(" \nt1.Name t1_Name,");
            SQL.Append(" \nt1.colour t1_colour,");
            SQL.Append("cast(t1.weight as nvarchar ) + ' ' +cast(t7.name as nvarchar)  t1_weight, ");
            SQL.Append("cast(t1.size as nvarchar ) + ' ' +cast(t6.name as nvarchar)  t1_size, ");
            SQL.Append(" \nt1.reorderpoint t1_reorderpoint,");
            SQL.Append(" \nt1.Rate t1_Rate,");
            SQL.Append(" \nt1.Remarks t1_Remarks,");
            SQL.Append(" \nt1.entrydate t1_entrydate,");
            SQL.Append(" \nt1.fk_Group t1_fk_Group,");

            SQL.Append(" \nt1.Code t1_Code,");
            SQL.Append(" \nt1.standardcost  t1_standardcost ,");
            SQL.Append(" \nt1.listprice  t1_listprice ,");
            SQL.Append(" \nt1.fk_rackno t1_fk_rackno,");

            SQL.Append("cast(t1.quantity_instore as nvarchar ) + ' ' +cast(mu.name as nvarchar)  t1_quantity_instore, ");
            SQL.Append("cast(t1.quantity_damage as nvarchar ) + ' ' +cast(mu.name as nvarchar)  t1_quantity_damage, ");
            SQL.Append("cast(t1.quantity_lost as nvarchar ) + ' ' +cast(mu.name as nvarchar)  t1_quantity_lost, ");
            SQL.Append("cast(t1.quantity_sold as nvarchar ) + ' ' +cast(mu.name as nvarchar)  t1_quantity_sold, ");

            //SQL.Append(" \nt1.quantity_instore t1_quantity_instore,");
            //SQL.Append(" \nt1.quantity_damage t1_quantity_damage,");
            //SQL.Append(" \nt1.quantity_lost t1_quantity_lost,");
            //SQL.Append(" \nt1.quantity_sold t1_quantity_sold,");

            SQL.Append(" \nt1.Transaction_Remarks t1_Transaction_Remarks,");


            SQL.Append(" \nt8.RackNumber t1_RackNumber,");



            SQL.Append(" \nt2.Name GroupName,");
            SQL.Append(" \nt1.fk_Company t1_fk_Company,");
            SQL.Append(" \nt3.Name CompanyName,");
            SQL.Append(" \nt1.fk_sizeunit t1_fk_sizeunit,");
            SQL.Append(" \nt1.fk_weightunit t1_fk_weightunit,");
            SQL.Append(" \nt7.Name t7_weightunit,");
            SQL.Append(" \nt1.UserId t1_UserId,");
            SQL.Append(" \nt5.Name t5_Name ");
            SQL.Append(" \nFROM");
            SQL.Append(" \nMaster_Product t1");

            SQL.Append(" \nleft outer join ");
            SQL.Append(" \nMaster_Product_Group t2 on");
            SQL.Append(" \nt1.fk_Group = t2.id ");

            SQL.Append(" \nleft outer join ");
            SQL.Append(" \nMaster_Product_Company  t3 on");
            SQL.Append(" \nt1.fk_Company = t3.id  ");

            SQL.Append(" \nleft outer join ");
            SQL.Append(" \nMaster_People_User t5 on");
            SQL.Append(" \nt1.UserId = t5.id");

            SQL.Append(" \nleft outer join ");
            SQL.Append(" \nMaster_Unit t6 on");
            SQL.Append(" \nt1.fk_sizeunit = t6.id");

            SQL.Append(" \nleft outer join ");
            SQL.Append(" \nMaster_Unit t7 on");
            SQL.Append(" \nt1.fk_weightunit = t7.id");

            SQL.Append(" \nleft outer join ");
            SQL.Append(" \nMaster_Unit mu on");
            SQL.Append(" \nt1.fk_MeasureUnit = mu.id");

            SQL.Append(" \nleft outer join ");
            SQL.Append(" \nRack_Master t8 on");
            SQL.Append(" \nt1.fk_rackno = t8.id");

            SQL.Append(" \nleft outer join ");
            SQL.Append(" \nInv_Purchase t4 on");
            SQL.Append(" \nt1.id = t4.fk_Product");

            SQL.Append(" \nleft outer join ");
            SQL.Append(" \nInv_sale t9 on");
            SQL.Append(" \nt1.id = t9.fk_Product");

            SQL.Append(" \n where t1.id = t1.id");

            ComboItem citem;

            if (searchCriterion1.cboGroup.Text != "")
            {
                citem = (ComboItem)searchCriterion1.cboGroup.SelectedItem;

                SQL.Append(" \n AND t2.id=" + citem.Key.ToString());
            }
            if (searchCriterion1.cboCompany.Text != "")
            {
                citem = (ComboItem)searchCriterion1.cboCompany.SelectedItem;
                SQL.Append(" \n AND t3.id=" + citem.Key.ToString());
            }
            //if (dtSellingFrom.Checked)
            //{
            //    SQL.Append(" \n AND t9.Date >= '" + dtSellingFrom.Value.ToString("ddMMMyyyy") + "'");
            //}
            //if (dtSellingTo.Checked)
            //{
            //    SQL.Append(" \n AND t9.Date <= '" + dtSellingTo.Value.ToString("ddMMMyyyy") + "'");
            //}
            if (searchCriterion1.dtFromPurchage.Checked)
            {
                SQL.Append(" \n AND t4.entrydate >= '" + searchCriterion1.dtFromPurchage.Value.ToString("yyyyMMdd") + "'");
            }
            if (searchCriterion1.dtToPurchage.Checked)
            {
                SQL.Append(" \n AND t4.entrydate <= '" + searchCriterion1.dtToPurchage.Value.ToString("yyyyMMdd") + "'");
            }

            SelectSQL = SQL.ToString();
            return true;
            //   // return base.GenerateSelectSQL();
        }

        public override string GetWhereClauseForSelect()
        {
            StringBuilder SQL = new StringBuilder();
            ComboItem citem;
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
                SQL.Append(" \n AND Master_Product_Group_id=" + citem.Key.ToString());
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
            //if (dtSellingFrom.Checked)
            //{
            //    SQL.Append(" \n AND t9.Date >= '" + dtSellingFrom.Value.ToString("ddMMMyyyy") + "'");
            //}
            //if (dtSellingTo.Checked)
            //{
            //    SQL.Append(" \n AND t9.Date <= '" + dtSellingTo.Value.ToString("ddMMMyyyy") + "'");
            //}
            if (searchCriterion1.dtFromPurchage.Checked)
            {
                SQL.Append(" \n AND Inv_Purchase_entrydate >= '" + searchCriterion1.dtFromPurchage.Value.ToString("yyyyMMdd") + "'");
            }
            if (searchCriterion1.dtToPurchage.Checked)
            {
                SQL.Append(" \n AND Inv_Purchase_entrydate <= '" + searchCriterion1.dtToPurchage.Value.ToString("yyyyMMdd") + "'");
            }
            if (searchCriterion1.datePickerExpiryDate .Checked)
            {
                SQL.Append(" \n AND ExpiryDate <= '" + searchCriterion1.datePickerExpiryDate.Value.ToString("yyyyMMdd") + "'");
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

