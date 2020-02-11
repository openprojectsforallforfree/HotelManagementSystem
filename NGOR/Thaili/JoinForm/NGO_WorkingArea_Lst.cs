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
    public partial class NGO_WorkingArea_Lst : Friuts.ListingFormBase
    {
        public NGO_WorkingArea_Lst()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            newToolbar.Text = Language.LanguageString.NewAdd;
            DeleteToolbar.Text = Language.LanguageString.Delete;
            EditToolbar.Text = Language.LanguageString.Edit;
            //<Listing>
            TableName = "NGO_WorkingArea";
            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("fk_NGO", ColumnTypes.Number, "colfk_NGO");
            // DataTableColumns.Add("fk_Address", ColumnTypes.Number, "colfk_Address");
            // RelationList.Add("fk_Address", "Address", "id", "Tole", "colfk_Address", TableJoinTypes.LEFT_JOIN);
            RelationList.Add("fk_Address","Address", "id", "Tole || ' ' || LocalBody || ' ' || District || ' ' || Zone || ' ' || Country AS ADDRESS", "colfk_Address", TableJoinTypes.LEFT_JOIN);

          
            LoadData();
            // toolstrip = toolStrip1;

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
        public NGO_WorkingArea_Lst(string NgoId):this()
        {
            _NGOId = NgoId;
        }
        string _NGOId = string.Empty;
        public override bool LoadData()
        {
            SearchConditionList.Clear();
            SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_NGO", ComparisionTypes.EQUAL, _NGOId);
            return base.LoadData();
        }
        public bool LoadData(string NgoId)
        {
            _NGOId = NgoId;
            return LoadData();
        }
        

        private void newToolbar_Click(object sender, EventArgs e)
        {
            OpenNewForm();
            LoadData();
        }

        private void EditToolbar_Click(object sender, EventArgs e)
        {
            OpenEditForm();
        }
        public override bool OpenEditForm()
        {
            return base.OpenEditForm(new NGO_WorkingArea_Ent(_NGOId ));
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new NGO_WorkingArea_Ent(_NGOId));
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
