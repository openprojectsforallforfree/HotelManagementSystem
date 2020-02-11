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
    public partial class YearlyReport_Lst : Friuts.ListingFormBase
    {
        public YearlyReport_Lst()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            ChangeLanguage();
        }
        public void ChangeLanguage()
        {
            //btnCancel.Text = Language.Cancel;
            //btnOk.Text = Language.Ok;
            newToolbar.Text = Language.LanguageString.NewAdd;
            EditToolbar.Text = Language.LanguageString.Edit;
            DeleteToolbar.Text = Language.LanguageString.Delete;
            // ExportToolbar.Text = Language. LanguageString.ExporttoExcel;
        }


        private void List_Load(object sender, EventArgs e)
        {
            //<Listing>
            TableName = "YearlyReport";
            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("fk_NGO", ColumnTypes.Number, "colfk_NGO");
            //DataTableColumns.Add("FiscalYearId", ColumnTypes.Number, "colFiscalYearId");
            RelationList .Add("FiscalYearId","FiscalYears","sn","FiscalYear", "colFiscalYearId", TableJoinTypes.LEFT_JOIN );
            DataTableColumns.Add("AuthorisedAmount", ColumnTypes.Number, "colAuthorisedAmount");
            DataTableColumns.Add("RecievedAmount", ColumnTypes.Number, "colRecievedAmount");
            DataTableColumns.Add("SpentAmount", ColumnTypes.Number, "colSpentAmount");
            DataTableColumns.Add("SignedBy", ColumnTypes.Number, "colSignedBy");
            DataTableColumns.Add("D_Date", ColumnTypes.String, "colD_Date");
        }

        string _Ngoid;

        public YearlyReport_Lst(string Ngoid)
            : this()
        {
            _Ngoid = Ngoid;
            SearchConditionList.Clear();
            SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_NGO", ComparisionTypes.EQUAL, _Ngoid);
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
            return base.OpenEditForm(new YearlyReport_Ent(_Ngoid));
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new YearlyReport_Ent(_Ngoid));
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
