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
    public partial class frmAccountList : Friuts.ListingFormBase
    {
        public frmAccountList()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            toolstrip = toolStrip1;
            //   ChildToolStrip = toolStrip1;
        }

        private void Listing_Load(object sender, EventArgs e)
        {

            //<Listing>
            TableName = "AccountGroup";
            DataTableColumns.Add("t1_Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("t1_Name", ColumnTypes.String, "colName");
            DataTableColumns.Add("t1_Description", ColumnTypes.String, "colDescription");
            DataTableColumns.Add("t2_Name", ColumnTypes.String, "colParentAccountGroupId");

        }

        public override bool GenerateSelectSQL()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("   SELECT ");
            sb.Append("  t1.Id t1_Id, ");
            sb.Append("  t1.Name t1_Name, ");
            sb.Append("  t1.Description t1_Description, ");
            sb.Append("  t1.ParentAccountGroupId , ");
            sb.Append("  t2.Name t2_Name     ");
            sb.Append("  FROM AccountGroup t1 ");
            sb.Append("   left join AccountGroup t2 on t2.Id = t1.ParentAccountGroupId   ");
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
            return base.OpenEditForm(new frmAccount());
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new frmAccount());
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
    }
}