using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
namespace UEMS
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmUnit_MasterList : Friuts.ListingFormBase
    {
        public frmUnit_MasterList()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            toolstrip = toolStrip1;

        }

        private void Listing_Load(object sender, EventArgs e)
        {

            //<Listing>
           // TableName = "Units";
           // DataTableColumns.Add("Id", ColumnTypes.String, "colId", true, true);
           // DataTableColumns.Add("Unit", ColumnTypes.String, "colUnit");
           // DataTableColumns.Add("Symbol", ColumnTypes.String, "colSymbol");
           //// DataTableColumns.Add("Master_UnitCategoryId", ColumnTypes.Number, "colMaster_UnitCategoryId");
           // DataTableColumns.Add("Factor", ColumnTypes.Number, "colFactor");
           // RelationList.Add("ParentId", TableName, "Unit", "colParentId");
           // RelationList.Add("CategogyTitle", "Master_UnitCategory", "Title", "colMaster_UnitCategoryId");
            TableName = "Master_Unit";
            DataTableColumns.Add("Id", ColumnTypes.String, "colId", true, true);
            DataTableColumns.Add("t1_Unit", ColumnTypes.String, "colUnit");
            DataTableColumns.Add("t1_Symbol", ColumnTypes.String, "colSymbol");
            DataTableColumns.Add("CategogyTitle", ColumnTypes.Number, "colMaster_UnitCategoryId");
            DataTableColumns.Add("t1_Factor", ColumnTypes.Number, "colFactor");

            // RelationList.Add("ParentId", TableName, "Unit", "colParentId");

        }


        public override bool GenerateSelectSQL()
        {
            StringBuilder sb = new StringBuilder();
 
            sb.AppendLine("  SELECT");
            sb.AppendLine("  t1.Id Id,");
            sb.AppendLine("  t1.Unit t1_Unit,");
            sb.AppendLine("  t1.Symbol t1_Symbol,");
            sb.AppendLine("  t3.Title CategogyTitle,");
            sb.AppendLine("  t1.Factor t1_Factor");
            sb.AppendLine("  FROM Master_Unit t1");


            sb.AppendLine("  left join Master_UnitCategory t3 on t1.Master_UnitCategoryId = t3.Id  ");
            if (_isRefreshData)
            {
                sb.AppendLine("  where t1_Id = " + PrimaryKeyValue);

            }

            sb.AppendLine("ORDER BY t1.Id");
            SelectSQL = sb.ToString();
            return true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newToolbar_Click(object sender, EventArgs e)
        {
            OpenNewForm();
        }

        private void EditToolbar_Click(object sender, EventArgs e)
        {
            OpenEditForm();
        }
        public override bool OpenEditForm()
        {
            return base.OpenEditForm(new frmMaster_Unit(TableName));
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new frmMaster_Unit(TableName));
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void ExitToolbar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExportToolbar_Click(object sender, EventArgs e)
        {
            Reports.ExcelReport excel = new Reports.ExcelReport(this.Text, 4, grid);
        }

        private void tlbTreeView_Click(object sender, EventArgs e)
        {
            Friuts.frmTreeView tvw = new frmTreeView();

            tvw.loadtree("Master_UnitCategory",TableName,"Id","Id", "Master_UnitCategoryId", "Title","Unit" );
            tvw.ShowDialog();
        }
    }
}