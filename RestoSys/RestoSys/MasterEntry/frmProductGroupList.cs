using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using UEMS.Reports;
namespace RestoSys.MasterEntry
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmProductGroupList : Friuts.ListingFormBase
    {
        public frmProductGroupList()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;

            TableName = "Master_Product_Group";
            DataTableColumns.Add("Id", ColumnTypes.Number  , "colId", true, true);
            DataTableColumns.Add("Name", ColumnTypes.String, "colName");
            DataTableColumns.Add("Description", ColumnTypes.String, "colDescription");
            DataTableColumns.Add("Code", ColumnTypes.String, "colCode");
            RelationList.Add("fk_ItemType", "Dev_Item_Type", "id", "Name", "colItemType", TableJoinTypes.LEFT_JOIN);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newToolbar_Click(object sender, EventArgs e)
        {
            OpenNewForm();
        }
        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new frmProductGroupEntry ());
        }

        private void EditToolbar_Click(object sender, EventArgs e)
        {
            OpenEditForm();
        }

        public override bool OpenEditForm()
        {
            return base.OpenEditForm(new frmProductGroupEntry());
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void ExportToolbar_Click(object sender, EventArgs e)
        {
            ExcelReport excel = new ExcelReport(this.Text, 4, grid);
        }

        private void ExitToolbar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmProductGroupList_Load(object sender, EventArgs e)
        {

        }
    }
}
