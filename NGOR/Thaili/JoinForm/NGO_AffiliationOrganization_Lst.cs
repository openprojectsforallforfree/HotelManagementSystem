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
    public partial class NGO_AffiliationOrganization_Lst : Friuts.ListingFormBase
    {
        public string _NgoId = string.Empty;
        public NGO_AffiliationOrganization_Lst()
        {
            InitializeComponent();

          
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            //<Listing>
            TableName = "NGO_AffiliationOrganization";
            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("fk_NGO", ColumnTypes.Number, "colfk_NGO");
            //DataTableColumns.Add("fk_AffiliationOrganization", ColumnTypes.Number, "colfk_AffiliationOrganization");
            RelationList.Add("fk_AffiliationOrganization", "AffiliationOrganization","Id","Title" ,"colfk_AffiliationOrganization",TableJoinTypes .LEFT_JOIN );
            DataTableColumns.Add("RegistrationDate", ColumnTypes.String, "colRegistrationDate");
            DataTableColumns.Add("AffiliationDate", ColumnTypes.String, "colAffiliationDate");
            DataTableColumns.Add("RedgeNo", ColumnTypes.String, "colRedgeNo");
            DataTableColumns.Add("LastRenualDate", ColumnTypes.String, "colLastRenualDate");
            DataTableColumns.Add("RenualDuration", ColumnTypes.String, "colRenualDuration");

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

        public override bool LoadData()
        {
            SearchConditionList.Clear();
            SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_NGO", ComparisionTypes.EQUAL, _NgoId);
            return base.LoadData();
            string s = SelectSQL;
        }
        public  bool LoadData(string NgoId)
        {
            _NgoId = NgoId;
            return  LoadData();
        }
        private void List_Load(object sender, EventArgs e)
        {
          
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
            return base.OpenEditForm(new NGO_AffiliationOrganization_Ent(_NgoId));
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new NGO_AffiliationOrganization_Ent(_NgoId));
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
