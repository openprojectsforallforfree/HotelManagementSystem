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
    public partial class TagGroup_Lst : Friuts.ListingFormBase
    {
        public TagGroup_Lst()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;

        }

        private void List_Load(object sender, EventArgs e)
        {
            //<Listing>
            TableName = "TagGroup";
            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("Title", ColumnTypes.String, "colTitle");
          //  DataTableColumns.Add("TagTypeId", ColumnTypes.String, "colTagTypeId");
            RelationList.Add("TagTypeId", "TagType","Id", "Title", "colTagTypeId", TableJoinTypes.LEFT_JOIN );
            DataTableColumns.Add("Remarks", ColumnTypes.String, "colRemarks");


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
            return base.OpenEditForm(new TagGroup_Ent(TableName));
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new TagGroup_Ent(TableName));
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            Delete();
        }


        private void ExportToolbar_Click(object sender, EventArgs e)
        {
            Reports.ExcelReport excel = new Reports.ExcelReport(this.Text, 4, grid);
        }
    }
}
