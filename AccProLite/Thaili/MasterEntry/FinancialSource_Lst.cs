using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using Bsoft.Languages ;
namespace UEMS
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class FinancialSource_Lst : Friuts.ListingFormBase
    {
        public FinancialSource_Lst()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;

            ChangeLanguage ();
        }
        public void ChangeLanguage ()
        {
            //btnCancel.Text = Language.LanguageString .Cancel;
            //btnOk.Text = Language.LanguageString .Ok;
            newToolbar.Text = Language.LanguageString .NewAdd;
            EditToolbar.Text = Language.LanguageString .Edit;
            DeleteToolbar.Text = Language.LanguageString .Delete;
            // ExportToolbar.Text = Language.LanguageString .ExporttoExcel;
        }
        private void List_Load(object sender, EventArgs e)
        {
            //<Listing>
            TableName = "FinancialSource";
            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("Name", ColumnTypes.String, "colName");
            DataTableColumns.Add("TypeLocal", ColumnTypes.String, "colTypeLocal");
            //DataTableColumns.Add("fkHelpingOrganization", ColumnTypes.Number, "colfkHelpingOrganization");

            RelationList.Add("fkHelpingOrganization","HelpingOrganization" ,"Id","Name", "colfkHelpingOrganization",TableJoinTypes .LEFT_JOIN );
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
            return base.OpenEditForm(new FinancialSource_Ent(TableName));
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new FinancialSource_Ent(TableName));
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
