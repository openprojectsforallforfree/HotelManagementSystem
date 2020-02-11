using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using UEMS.Reports;
using Bsoft.Forms;
using Bsoft.Common;
namespace RestoSys.MasterEntry
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmProductList : Friuts.ListingFormBase
    {

        public string Filter = "";
        public frmProductList()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            TableName = "ProductFrmView";
            loadDataGrid();
        }

        private void loadDataGrid()
        {

            DataTableColumns.Add("Id", ColumnTypes.String, "colId", true, true);
            DataTableColumns.Add("t1_Name", ColumnTypes.String, "colName");
            DataTableColumns.Add("GroupName", ColumnTypes.String, "colfk_Group");
            //  RelationList.Add("fk_Company", "Master_Product_Company", "id", "t1_Name", "colfk_Company", TableJoinTypes.LEFT_JOIN);
            //RelationList.Add("fk_sizeunit", "Master_Unit", "id", "t6_sizeunit", "colsizeunit", TableJoinTypes.LEFT_JOIN);
            //RelationList.Add("fk_weightunit", "Master_Unit", "id", "t7_weightunit", "colweightunit", TableJoinTypes.LEFT_JOIN);

            //'' DataTableColumns.Add("fk_Group", ColumnTypes.Number, "colfk_Group");
            //DataTableColumns.Add("fk_Company", ColumnTypes.Number, "colfk_Company");
            //DataTableColumns.Add("fk_sizeunit", ColumnTypes.Number, "colsizeunit");
            //DataTableColumns.Add("fk_weightunit", ColumnTypes.Number, "colweightunit");
            DataTableColumns.Add("sellingPrice", ColumnTypes.Number, "colLatestSP");
            DataTableColumns.Add("costPrice", ColumnTypes.Number, "colLatestCP");

            DataTableColumns.Add("companyname", ColumnTypes.String, "colfk_Company");
            DataTableColumns.Add("t1_colour", ColumnTypes.String, "colcolour");
            DataTableColumns.Add("t1_weight", ColumnTypes.String, "colweight");
            DataTableColumns.Add("t1_size", ColumnTypes.String, "colsize");
            DataTableColumns.Add("t1_reorderpoint", ColumnTypes.String, "colreorderpoint");
            //  DataTableColumns.Add("t1_Rate", ColumnTypes.Number, "colRate");



            DataTableColumns.Add("t1_Code", ColumnTypes.String, "colCode");
            //DataTableColumns.Add("t1_standardcost ", ColumnTypes.String, "colstandardcost");
            //DataTableColumns.Add("t1_listprice ", ColumnTypes.String, "collistprice");
            //DataTableColumns.Add("t1_quantity_instore", ColumnTypes.String, "colquantity_instore");
            //DataTableColumns.Add("t1_quantity_damage", ColumnTypes.String, "colquantity_damage");
            //DataTableColumns.Add("t1_quantity_lost", ColumnTypes.String, "colquantity_lost");
            //DataTableColumns.Add("t1_quantity_sold", ColumnTypes.String, "colquantity_sold");
            //DataTableColumns.Add("t1_Remarks_transaction", ColumnTypes.String, "colRemarks_transaction");


            DataTableColumns.Add("t1_Remarks", ColumnTypes.String, "colRemarks");
            // RelationList.Add("t1_UserId", "SuperAdmin_Rights_Users", "id", "Name", "colUserId");
            DataTableColumns.Add("t5_Name", ColumnTypes.String, "colUserId");
            DataTableColumns.Add("t1_entrydate", ColumnTypes.String, "colentrydate");

        }
     public    string StockCode = "";
        public override string GetWhereClauseForSelect()
        {
            StringBuilder SQL = new StringBuilder();
            ComboItem citem;
            SQL.AppendLine("WHERE 1=1 ");

            if (Filter !="")
            {
                SQL.Append(" \n AND ItemTypeCode in ('{0}','{1}','{2}')".With(ItemType.Consumable,ItemType .Ingredient ,ItemType .Retail ));
            }
            if (StockCode.Length >0)
            {
                 SQL.Append(" \n AND ItemTypeCode in (" + StockCode + ")");
            }
            if (cboGroup.Text != "")
            {
                citem = (ComboItem)cboGroup.SelectedItem;

                SQL.Append(" \n AND  t1_fk_group=" + citem.Key.ToString());
            }
            if (cboCompany.Text != "")
            {
                citem = (ComboItem)cboCompany.SelectedItem;
                SQL.Append(" \n AND t1_fk_Company=" + citem.Key.ToString());
            }
            if (txtName.Text.Trim() != "")
            {
                SQL.AppendFormat(" \n AND t1_name like '{0}%'", txtName.Text.Trim());
            }

            return SQL.ToString();
        }

        private void AddSearchCriteria()
        {
            SearchConditionList.Clear();
            try
            {
                RestoSys.Properties.Settings.Default.Search_Company = ((ComboItem)cboCompany.SelectedItem).Key;
            }
            catch { }
            try
            {
                RestoSys.Properties.Settings.Default.Search_Group = ((ComboItem)cboGroup.SelectedItem).Key;
            }
            catch { }
        }


        #region "Events"
        private void frmProductList_Load(object sender, EventArgs e)
        {
            ComboBoxDataLoader loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add("ID", "Name", "Master_Product_Group", cboGroup, false);
            loader.LoadDataInComboBoxes();

            ComboBoxDataLoader loader1 = new ComboBoxDataLoader();
            loader1.ComboLoadinfoItems.Add("ID", "Name", "Master_Product_Company", cboCompany, false);
            loader1.LoadDataInComboBoxes();

            if (FormType == FormTypes.SelectionForm)
            {
                toolStrip1.Visible = false;
            }
            try { ComboUtilities.SelectComboBoxItemUsingKey(cboGroup, RestoSys.Properties.Settings.Default.Search_Group); }
            catch { }
            try { ComboUtilities.SelectComboBoxItemUsingKey(cboCompany, RestoSys.Properties.Settings.Default.Search_Company); }
            catch { }
        }
        private void newToolbar_Click(object sender, EventArgs e)
        {
            OpenNewForm();

        }

        private void EditToolbar_Click(object sender, EventArgs e)
        {
            OpenEditForm();

        }
        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new frmProductEntry());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            AddSearchCriteria();
            LoadData();
        }
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            AddSearchCriteria();
            LoadData();
        }


        public override bool OpenEditForm()
        {
            bool retval = base.OpenEditForm(new frmProductEntry());
            //  LoadData();
            return retval;
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            Delete();
            LoadData();
        }

        private void ExportToolbar_Click(object sender, EventArgs e)
        {
            ExcelReport excel = new ExcelReport(this.Text, 4, grid);
        }

        private void ExitToolbar_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnOk_Click(object sender, EventArgs e)
        {
            ReturnSelectedValue();
            DialogResult = DialogResult.OK;
        }

        private void ExitToolbar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
