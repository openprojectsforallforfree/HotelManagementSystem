using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using Bsoft.Common.Language;
using Bsoft.Languages;
namespace UEMS 
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class FiscalYears_Lst: Friuts.ListingFormBase
    {
        public FiscalYears_Lst()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
           // toolstrip = toolStrip1;

            ChangeLanguage();
        }
        public void ChangeLanguage()
        {
            //btnCancel.Text = Language.Cancel;
            //btnOk.Text = Language.Ok;
            newToolbar.Text =Language. LanguageString.NewAdd;
            EditToolbar.Text = Language. LanguageString.Edit;
            DeleteToolbar.Text = Language. LanguageString.Delete;
            // ExportToolbar.Text = Language. LanguageString.ExporttoExcel;
        }

        private void List_Load(object sender, EventArgs e)
        {
            //<Listing>
TableName = "FiscalYears";
DataTableColumns.Add( "Id",ColumnTypes.Number,"colId",true ,true);
DataTableColumns.Add( "FiscalYear",ColumnTypes.String,"colFiscalYear");
DataTableColumns.Add( "DateFrom",ColumnTypes.String,"colDateFrom");
DataTableColumns.Add( "DateTo",ColumnTypes.String,"colDateTo");


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
            return base.OpenEditForm(new FiscalYears_Ent (TableName));
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new FiscalYears_Ent(TableName));
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
