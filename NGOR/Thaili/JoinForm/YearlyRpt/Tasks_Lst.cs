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
    public partial class Tasks_Lst : Friuts.ListingFormBase
    {
        public Tasks_Lst()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            TableName = "Tasks";
            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("fk_WorkDone", ColumnTypes.Number, "colfk_WorkDone");
            DataTableColumns.Add("Title", ColumnTypes.String, "colTitle");
            DataTableColumns.Add("ExpensedBudget", ColumnTypes.Number, "colExpensedBudget");
            DataTableColumns.Add("Male_Adv", ColumnTypes.Number, "colMale_Adv");
            DataTableColumns.Add("Female_Adv", ColumnTypes.Number, "colFemale_Adv");
            DataTableColumns.Add("TG_Adv", ColumnTypes.Number, "colTG_Adv");
            DataTableColumns.Add("Dalit_Adv", ColumnTypes.Number, "colDalit_Adv");
            DataTableColumns.Add("Janjati_Adv", ColumnTypes.Number, "colJanjati_Adv");
            DataTableColumns.Add("Other_Adv", ColumnTypes.Number, "colOther_Adv");
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

        private void List_Load(object sender, EventArgs e)
        {
            //<Listing>
           


        }
        string _WorkDoneID;
        public bool LoadData(string WorkDoneID)
        {
            _WorkDoneID = WorkDoneID;
            return LoadData();
        }
        public override bool LoadData()
        {
            SearchConditionList.Clear();
            SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_WorkDone", ComparisionTypes.EQUAL, _WorkDoneID);
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
            return base.OpenEditForm(new Tasks_Ent(_WorkDoneID));
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new Tasks_Ent(_WorkDoneID));
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
