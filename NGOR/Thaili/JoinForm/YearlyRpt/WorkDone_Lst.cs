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
    public partial class WorkDone_Lst : Friuts.ListingFormBase
    {
        string _YearlyReportId = string.Empty;
        public WorkDone_Lst()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            //<Listing>
            TableName = "WorkDone";
            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            //DataTableColumns.Add("fk_OBJECTIVE", ColumnTypes.String, "colTitle");

            RelationList.Add("fk_OBJECTIVE", "NGO_ObjectiveView", "fk_Objective", "Objective_Title", "colTitle", TableJoinTypes.LEFT_JOIN );
            DataTableColumns.Add("fk_YearlyReport", ColumnTypes.Number, "colfk_YearlyReport");
            //DataTableColumns.Add("fk_Address", ColumnTypes.Number, "colfk_Address");
            RelationList.Add("fk_Address", "Address", "id", "Tole || ' ' || LocalBody || ' ' || District || ' ' || Zone || ' ' || Country AS ADDRESS", "colfk_Address", TableJoinTypes.LEFT_JOIN);
            DataTableColumns.Add("fk_Address", ColumnTypes.Number, "colfk_Address");
            DataTableColumns.Add("TaskDate", ColumnTypes.String, "colTaskDate");
            DataTableColumns.Add("Remarks", ColumnTypes.String, "colRemarks");
            DataTableColumns.Add("RFU", ColumnTypes.String, "colRFU");
            ChangeLanguage();
        }
        public void ChangeLanguage()
        {
            //btnCancel.Text = Language.Cancel;
            //btnOk.Text = Language.Ok;
            newToolbar.Text = Language. LanguageString.NewAdd;
            EditToolbar.Text = Language. LanguageString.Edit;
            DeleteToolbar.Text = Language. LanguageString.Delete;
            // ExportToolbar.Text = Language. LanguageString.ExporttoExcel;
        }
        public WorkDone_Lst(string YearlyReportId):this ()
        {
            _YearlyReportId = YearlyReportId;
        }
       
        public override bool LoadData()
        {
            SearchConditionList.Clear();
            SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_YearlyReport", ComparisionTypes.EQUAL, _YearlyReportId);
            return base.LoadData();
        }
        public bool LoadData(string YearlyReportId)
        {
            _YearlyReportId = YearlyReportId;
            return LoadData();
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
            return base.OpenEditForm(new WorkDone_Ent(_YearlyReportId));
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new WorkDone_Ent(_YearlyReportId));
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            Delete();
        }
      
    }
}
