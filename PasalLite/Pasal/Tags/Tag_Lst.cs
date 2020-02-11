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
    public partial class Tag_Lst : Friuts.ListingFormBase
    {
        public Tag_Lst()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;

        }
        string _grpId = string.Empty;
        public Tag_Lst(string grpId)
        {
            _grpId = grpId;
            InitializeComponent();
             
            ListingDataGridView = grid;
            TableName = "Tag";
            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            //DataTableColumns.Add( "TagGroupId",ColumnTypes.Number,"colTagGroupId");
            RelationList.Add("TagGroupId", "TagGroup", "Id", "Title", "colTagGroupId", TableJoinTypes.LEFT_JOIN);
            DataTableColumns.Add("Value", ColumnTypes.String, "colValue");
            Visible = false;
            OpenEditForm();

        }
        private void List_Load(object sender, EventArgs e)
        {
            //<Listing>
            //TableName = "Tag";
            //DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            ////DataTableColumns.Add( "TagGroupId",ColumnTypes.Number,"colTagGroupId");
            //RelationList.Add("TagGroupId", "TagGroup", "Id", "Title", "colTagGroupId", TableJoinTypes.LEFT_JOIN);
            //DataTableColumns.Add("Value", ColumnTypes.String, "colValue");
            //Visible = false;
            //OpenEditForm();
        }

        public override bool LoadData()
        {
            SearchConditionList.Clear();
            SearchConditionList.AddCriteria(ColumnTypes.Integer, "TagGroupId", _grpId);
            return base.LoadData();
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
            return base.OpenEditForm(new Tag_Ent(TableName, _grpId));
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new Tag_Ent(TableName, _grpId));
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
