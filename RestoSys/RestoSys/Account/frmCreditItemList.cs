using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
namespace RestoSys.Account
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmCreditItemList : Friuts.ListingFormBase
    {
        string accid;
        public frmCreditItemList()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            TableName = "Master_Product";
            loadDataGrid();
        }
        public frmCreditItemList(string _accid)
        {
            accid = _accid;
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            TableName = "Master_Product";
            loadDataGrid();
        }
        public void Dataload()
        {
            LoadData();
        }
        private void loadDataGrid()
        {

     
            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("Prod_Name", ColumnTypes.String, "colProd_Name");
            DataTableColumns.Add("Prod_Code", ColumnTypes.Number, "colProd_Code");
            DataTableColumns.Add("Prod_standardcost", ColumnTypes.Number, "colProd_standardcost");
            DataTableColumns.Add("Prod_listprice", ColumnTypes.Number, "colProd_listprice");
            DataTableColumns.Add("ProdGrp_Name", ColumnTypes.String, "colProdGrp_Name");
            DataTableColumns.Add("ProdComp_Name", ColumnTypes.String, "colProdComp_Name");
            DataTableColumns.Add("Prod_colour", ColumnTypes.String, "colProd_colour");
            DataTableColumns.Add("Prod_weight", ColumnTypes.String, "colProd_weight");
            DataTableColumns.Add("Prod_size", ColumnTypes.String, "colProd_size");
            DataTableColumns.Add("Prod_Rate", ColumnTypes.Number, "colProd_Rate");
            DataTableColumns.Add("Prod_quantity_instore", ColumnTypes.Number, "colProd_quantity_instore");
            DataTableColumns.Add("Prod_Remarks", ColumnTypes.String, "colProd_Remarks");
            DataTableColumns.Add("Prod_Transaction_Remarks", ColumnTypes.String, "colProd_Transaction_Remarks");
            DataTableColumns.Add("Quantity", ColumnTypes.String, "colQuantity");

        }

        private void frmCreditItemList_Load(object sender, EventArgs e)
        {
            loadDataGrid();
        }

        public override bool GenerateSelectSQL()
        {
            StringBuilder SQL = new StringBuilder();
            SQL.Append(" \nSELECT DISTINCT ");
            SQL.Append(" \nProd.Id Id, ");
            SQL.Append(" \nProd.Name Prod_Name, ");
            SQL.Append(" \nProd.colour Prod_colour,");
            SQL.Append(" \ncast(Prod.weight as nvarchar )+' '+cast(t7.symbol as nvarchar)  Prod_weight,");
            SQL.Append(" \ncast(Prod.size as nvarchar )+' '+cast(t6.symbol as nvarchar)  Prod_size,  ");
            SQL.Append(" \nProd.reorderpoint Prod_reorderpoint, ");
            SQL.Append(" \nProd.Rate Prod_Rate, ");
            SQL.Append(" \nProd.Remarks Prod_Remarks, ");
            SQL.Append(" \nProd.entrydate Prod_entrydate, ");
            SQL.Append(" \nProd.fk_Group Prod_fk_Group, ");
            SQL.Append(" \nProd.Code Prod_Code, ");
            SQL.Append(" \nProd.standardcost  Prod_standardcost , ");
            SQL.Append(" \nProd.listprice  Prod_listprice , ");
            SQL.Append(" \nProd.quantity_instore Prod_quantity_instore, ");
            SQL.Append(" \nProd.quantity_damage Prod_quantity_damage, ");
            SQL.Append(" \nProd.quantity_lost Prod_quantity_lost, ");
            SQL.Append(" \nProd.quantity_sold Prod_quantity_sold, ");
            SQL.Append(" \nProd.Transaction_Remarks Prod_Transaction_Remarks, ");
            SQL.Append(" \nProdGrp.Name ProdGrp_Name, ");
            SQL.Append(" \nProd.fk_Company Prod_fk_Company, ");
            SQL.Append(" \nProdComp.Name ProdComp_Name, ");
            SQL.Append(" \nProd.fk_sizeunit Prod_fk_sizeunit, ");
            SQL.Append(" \nProd.fk_weightunit Prod_fk_weightunit, ");
            SQL.Append(" \nt7.Name t7_weightunit, ");
            SQL.Append(" \nProd.UserId Prod_UserId, ");
            SQL.Append(" \nt5.ENGNAME t5_Name  ,");
            SQL.Append(" \ninvsale.fk_sale,");
            SQL.Append(" \ncast(invsale.Quantity as nvarchar )+' '+cast( unit.symbol as nvarchar)  Quantity");
            SQL.Append(" \nFROM ");
            SQL.Append(" \ninv_sale invsale");
            SQL.Append(" \nleft outer join");
            SQL.Append(" \nMaster_Product Prod  on");
            SQL.Append(" \ninvsale.fk_product=Prod.id");
            SQL.Append(" \nleft outer join  ");
            SQL.Append(" \nMaster_Product_Group ProdGrp on ");
            SQL.Append(" \nProd.fk_Group = ProdGrp.id  ");
            SQL.Append(" \nleft outer join  ");
            SQL.Append(" \nMaster_Product_Company  ProdComp on ");
            SQL.Append(" \nProd.fk_Company = ProdComp.id   ");
            SQL.Append(" \nleft outer join  ");
            SQL.Append(" \nSuperAdmin_Rights_Users t5 on ");
            SQL.Append(" \nProd.UserId = t5.id ");
            SQL.Append(" \nleft outer join  ");
            SQL.Append(" \nMaster_Unit t6 on ");
            SQL.Append(" \nProd.fk_sizeunit = t6.id ");
            SQL.Append(" \nleft outer join  ");
            SQL.Append(" \nMaster_Unit t7 on ");
            SQL.Append(" \nProd.fk_weightunit = t7.id ");
            SQL.Append(" \nleft outer join  ");
            SQL.Append(" \nMaster_Unit unit on ");
            SQL.Append(" \nProd.fk_MeasureUnit = unit.id ");
            SQL.Append(" \nleft outer join  ");
            SQL.Append(" \nMaster_Product_Group t8 on ");//check
            SQL.Append(" \nProd.fk_group = t8.id ");// chdek here 
            SQL.Append(" \nwhere");
            SQL.Append(" \ninvsale.fk_sale = " + accid);

 

            SelectSQL = SQL.ToString();
            return true;

        }

        public override string GetWhereClauseForSelect()
        {
            return "";
        }

        private void AddSearchCriteria()
        {
            SearchConditionList.Clear();



        }

    }
}

