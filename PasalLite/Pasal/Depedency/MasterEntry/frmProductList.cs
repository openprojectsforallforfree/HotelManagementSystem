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
namespace Pasal.MasterEntry
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmProductList : Friuts.ListingFormBase
    {
        public frmProductList()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            TableName = "Product_Master";
            loadDataGrid();
        }

        private void loadDataGrid()
        {

            DataTableColumns.Add("Id", ColumnTypes.String, "colId", true, true);
            DataTableColumns.Add("t1_Name", ColumnTypes.String, "colName");
            RelationList.Add("fk_Group", "Product_Group_Master", "id", "t2_Name", "colfk_Group", TableJoinTypes.LEFT_JOIN);
          //  RelationList.Add("fk_Company", "Product_Company_Master", "id", "t1_Name", "colfk_Company", TableJoinTypes.LEFT_JOIN);
            RelationList.Add("fk_sizeunit", "Unit_Master", "id", "t6_sizeunit", "colsizeunit", TableJoinTypes.LEFT_JOIN);
            RelationList.Add("fk_weightunit", "Unit_Master", "id", "t7_weightunit", "colweightunit", TableJoinTypes.LEFT_JOIN);

            //'' DataTableColumns.Add("fk_Group", ColumnTypes.Number, "colfk_Group");
            //DataTableColumns.Add("fk_Company", ColumnTypes.Number, "colfk_Company");
            //DataTableColumns.Add("fk_sizeunit", ColumnTypes.Number, "colsizeunit");
            //DataTableColumns.Add("fk_weightunit", ColumnTypes.Number, "colweightunit");

            DataTableColumns.Add("companyname", ColumnTypes.String, "colfk_Company");
            DataTableColumns.Add("t1_colour", ColumnTypes.String, "colcolour");
            DataTableColumns.Add("t1_weight", ColumnTypes.String, "colweight");
            DataTableColumns.Add("t1_size", ColumnTypes.String, "colsize");
            DataTableColumns.Add("t1_reorderpoint", ColumnTypes.String, "colreorderpoint");
            //  DataTableColumns.Add("t1_Rate", ColumnTypes.Number, "colRate");



            DataTableColumns.Add("t1_Code", ColumnTypes.String  , "colCode");
            //DataTableColumns.Add("t1_standardcost ", ColumnTypes.String, "colstandardcost");
            //DataTableColumns.Add("t1_listprice ", ColumnTypes.String, "collistprice");
            //DataTableColumns.Add("t1_quantity_instore", ColumnTypes.String, "colquantity_instore");
            //DataTableColumns.Add("t1_quantity_damage", ColumnTypes.String, "colquantity_damage");
            //DataTableColumns.Add("t1_quantity_lost", ColumnTypes.String, "colquantity_lost");
            //DataTableColumns.Add("t1_quantity_sold", ColumnTypes.String, "colquantity_sold");
            //DataTableColumns.Add("t1_Remarks_transaction", ColumnTypes.String, "colRemarks_transaction");


            DataTableColumns.Add("t1_Remarks", ColumnTypes.String, "colRemarks");
            // RelationList.Add("t1_fk_User", "Rights_Users", "id", "Name", "colfk_User");
            DataTableColumns.Add("t5_Name", ColumnTypes.String, "colfk_User");
            DataTableColumns.Add("t1_entrydate", ColumnTypes.String, "colentrydate");



        }
        public override bool GenerateSelectSQL()
        {   //Product_Master t1
            //Product_Group_Master t2
            //Product_Company_Master  t3
            //Rights_Users t5 
            //Unit_Master t6 t7 t8
            //Inv_sale t4
            //Inv_Purchase  t9 

            StringBuilder SQL = new StringBuilder();
            SQL.Append(" \nSELECT DISTINCT");
            SQL.Append(" \nt1.Id Id,");
            SQL.Append(" \nt1.Name t1_Name,");
            SQL.Append(" \nt1.colour t1_colour,");
            SQL.Append("cast(t1.weight as nvarchar ) || ' ' || cast(t7.unit as nvarchar)  t1_weight, ");
            SQL.Append("cast(t1.size as nvarchar ) || ' ' || cast(t6.unit as nvarchar)  t1_size, ");
            SQL.Append(" \nt1.reorderpoint t1_reorderpoint,");
            SQL.Append(" \nt1.Remarks t1_Remarks,");
            SQL.Append(" \nt1.entrydate t1_entrydate,");
            SQL.Append(" \nt1.fk_Group t1_fk_Group,");

            SQL.Append(" \n cast(t2.Code as nvarchar ) || '.' || cast(t1.Code as nvarchar ) as t1_Code,");
            //SQL.Append(" \nt1.standardcost  t1_standardcost ,");
            //SQL.Append(" \nt1.listprice  t1_listprice ,");

         

            //SQL.Append("cast(t1.quantity_instore as nvarchar ) + ' ' +cast(mu.name as nvarchar)  t1_quantity_instore, ");
            //SQL.Append("cast(t1.quantity_damage as nvarchar ) + ' ' +cast(mu.name as nvarchar)  t1_quantity_damage, ");
            //SQL.Append("cast(t1.quantity_lost as nvarchar ) + ' ' +cast(mu.name as nvarchar)  t1_quantity_lost, ");
            //SQL.Append("cast(t1.quantity_sold as nvarchar ) + ' ' +cast(mu.name as nvarchar)  t1_quantity_sold, ");


           // SQL.Append(" \nt1.Transaction_Remarks t1_Transaction_Remarks,");

            

            SQL.Append(" \n t3.Name companyname,");

            SQL.Append(" \nt2.Name t2_Name,");
            SQL.Append(" \nt1.fk_Company t1_fk_Company,");
            SQL.Append(" \nt3.Name t3_Name,");
            SQL.Append(" \nt1.fk_sizeunit t1_fk_sizeunit,");
            SQL.Append(" \nt1.fk_weightunit t1_fk_weightunit,");
            SQL.Append(" \nt6.unit t6_sizeunit,");
            SQL.Append(" \nt7.unit t7_weightunit,");
            SQL.Append(" \nt1.fk_User t1_fk_User,");
            SQL.Append(" \nt5.ENGNAME t5_Name ");
            SQL.Append(" \nFROM");
            SQL.Append(" \nProduct_Master t1");

            SQL.Append(" \nleft outer join ");
            SQL.Append(" \nProduct_Group_Master t2 on");
            SQL.Append(" \nt1.fk_Group = t2.id ");

            SQL.Append(" \nleft outer join ");
            SQL.Append(" \nProduct_Company_Master  t3 on");
            SQL.Append(" \nt1.fk_Company = t3.id  ");

            SQL.Append(" \nleft outer join ");
            SQL.Append(" \nRights_Users t5 on");
            SQL.Append(" \nt1.fk_User = t5.id");

            SQL.Append(" \nleft outer join ");
            SQL.Append(" \nUnit_Master t6 on");
            SQL.Append(" \nt1.fk_sizeunit = t6.id");

            SQL.Append(" \nleft outer join ");
            SQL.Append(" \nUnit_Master t7 on");
            SQL.Append(" \nt1.fk_weightunit = t7.id");

            SQL.Append(" \nleft outer join ");
            SQL.Append(" \nUnit_Master mu on");
            SQL.Append(" \nt1.fk_MeasureUnit = mu.id");

         

           
            SQL.Append(" \n where t1.id = t1.id");

            ComboItem citem;

            //if (cboGroup.Text == "")
            //{
            //    if (MessageBoxMy.Show("Selecting all groups will make the search very slow it may take very long .\nDo you want to continue ?", MessageBoxButtons.YesNo) != DialogResult.Yes)
            //    {
            //        SelectSQL = "";
            //        return true;
            //    }

            //}

            if (cboGroup.Text != "")
            {
                citem = (ComboItem)cboGroup.SelectedItem;

                SQL.Append(" \n AND t2.id=" + citem.Key.ToString());
            }
            if (cboCompany.Text != "")
            {
                citem = (ComboItem)cboCompany.SelectedItem;
                SQL.Append(" \n AND t3.id=" + citem.Key.ToString());
            }
            if (txtName.Text .Trim () != "")
            {
                SQL.AppendFormat (" \n AND t1.name like '{0}%'",txtName .Text .Trim ());
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
            try
            {
                Pasal.Properties.Settings.Default.Search_Company = ((ComboItem)cboCompany.SelectedItem).Key;
            }
            catch { }
            try
            {
                Pasal.Properties.Settings.Default.Search_Group = ((ComboItem)cboGroup.SelectedItem).Key;
            }
            catch { }
        }


        #region "Events"
        private void frmProductList_Load(object sender, EventArgs e)
        {
            ComboBoxDataLoader loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add("ID", "Name", "Product_Group_Master", cboGroup, false);
            loader.LoadDataInComboBoxes();

            ComboBoxDataLoader loader1 = new ComboBoxDataLoader();
            loader1.ComboLoadinfoItems.Add("ID", "Name", "Product_Company_Master", cboCompany, false);
            loader1.LoadDataInComboBoxes();

            if (FormType == FormTypes.SelectionForm)
            {
                toolStrip1.Visible = false;
            }
            try { ComboUtilities.SelectComboBoxItemUsingKey (cboGroup, Pasal.Properties.Settings.Default.Search_Group); }
            catch { }
            try { ComboUtilities.SelectComboBoxItemUsingKey(cboCompany, Pasal.Properties.Settings.Default.Search_Company); }
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
