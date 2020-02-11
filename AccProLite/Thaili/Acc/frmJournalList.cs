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
    public partial class frmJournalList : Friuts.ListingFormBase
    {
        public frmJournalList()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            toolstrip = toolStrip1;

        }

        private void Listing_Load(object sender, EventArgs e)
        {

            //<Listing>
            TableName = "Journal";
            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            RelationList .Add("AccountId","AccountGroup" ,"Id" ,"Name", "colAccountId",TableJoinTypes .LEFT_JOIN );
            RelationList.Add("JournalTypeId", "JournalType", "Id", "Title", "colJournalTypeId", TableJoinTypes.LEFT_JOIN);
            //DataTableColumns.Add("JournalTypeId", ColumnTypes.Number, "colJournalTypeId");
            DataTableColumns.Add("DrCr", ColumnTypes.String, "colDrCr");
            DataTableColumns.Add("Amount", ColumnTypes.Number, "colAmount");
            DataTableColumns.Add("DateTime", ColumnTypes.String, "colDateTime");
            DataTableColumns.Add("Narration", ColumnTypes.String, "colNarration");
         
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
            return base.OpenEditForm(new frmJournal(TableName));
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new frmJournal(TableName));
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