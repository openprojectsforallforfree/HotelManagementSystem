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
    public partial class WorkDone_NGO_Lst : Friuts.ListingFormBase
    {
        public WorkDone_NGO_Lst()
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
            newToolbar.Text = Language. LanguageString.NewAdd;
           // EditToolbar.Text = Language. LanguageString.Edit;
            DeleteToolbar.Text = Language. LanguageString.Delete;
            // ExportToolbar.Text = Language. LanguageString.ExporttoExcel;
        }
        string _NGOId = string.Empty;
        public WorkDone_NGO_Lst(string NGOId)
            : this()
        {
            _NGOId = NGOId;
            SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_NGO", ComparisionTypes.EQUAL, _NGOId);
        }
        private void List_Load(object sender, EventArgs e)
        {
            //<Listing>
            TableName = "WorkDone_NGO";
            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("NGO_ID", ColumnTypes.Number, "colNGO_ID");
            //DataTableColumns.Add("fk_WorkDone", ColumnTypes.Number, "colfk_WorkDone");

            
            RelationList.Add("fk_WorkDone", "WorkDone", "id", "Title", "colfk_WorkDone", TableJoinTypes.LEFT_JOIN);
            LoadData();
            string b = SelectSQL;
        }
        public override bool GenerateSelectSQL()
        {
            return base.GenerateSelectSQL();
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
            return base.OpenEditForm(new WorkDone_NGO_Ent(_NGOId ));
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new WorkDone_NGO_Ent(_NGOId));
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
