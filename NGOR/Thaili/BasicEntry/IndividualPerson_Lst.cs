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
    public partial class IndividualPerson_Lst : Friuts.ListingFormBase
    {
        public IndividualPerson_Lst()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            // toolstrip = toolStrip1;
            btnOk.Text = Language.LanguageString.Search;
            ChangeLanguage();
        }
        public void ChangeLanguage()
        {
            //btnCancel.Text = Language.Cancel;
            //btnOk.Text = Language.Ok;
            newToolbar.Text = Language.LanguageString.NewAdd;
            EditToolbar.Text = Language.LanguageString.Edit;
            DeleteToolbar.Text = Language.LanguageString.Delete;
            ExportToolbar.Text = Language.LanguageString.ExporttoExcel;
        }
        private void List_Load(object sender, EventArgs e)
        {
            //<Listing>
            TableName = "IndividualPerson";
            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("FirstName", ColumnTypes.String, "colFirstName");
            DataTableColumns.Add("LastName", ColumnTypes.String, "colLastName");

            //DataTableColumns.Add("fk_Gender", ColumnTypes.Number, "colfk_Gender");
            RelationList.Add("fk_Gender", "Master_Sex", "id", "Title", "colfk_Gender", TableJoinTypes.LEFT_JOIN);

           // DataTableColumns.Add("fk_Ethnicity", ColumnTypes.Number, "colfk_Ethnicity");
            RelationList.Add("fk_Ethnicity", "Master_Ethnicity", "id", "Title", "colfk_Ethnicity", TableJoinTypes.LEFT_JOIN);
            DataTableColumns.Add("DifferentlyAbled", ColumnTypes.String, "colDifferentlyAbled");

           // DataTableColumns.Add("fk_Specialization", ColumnTypes.Number, "colfk_Specialization");
            RelationList.Add("fk_Specialization", "Master_Specialization", "id", "Title", "colfk_Specialization", TableJoinTypes.LEFT_JOIN);

            DataTableColumns.Add("SocialWorkExp", ColumnTypes.String, "colSocialWorkExp");
            DataTableColumns.Add("fk_HighestEducation", ColumnTypes.Number, "colfk_HighestEducation");
            DataTableColumns.Add("fk_Position", ColumnTypes.Number, "colfk_Position");
            DataTableColumns.Add("fk_Address", ColumnTypes.Number, "colfk_Address");
            DataTableColumns.Add("fk_ContactInformation", ColumnTypes.Number, "colfk_ContactInformation");
            DataTableColumns.Add("fk_Master_Profession", ColumnTypes.Number, "colfk_Master_Profession");
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
            return base.OpenEditForm(new IndividualPerson_Ent( ));
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new IndividualPerson_Ent( ));
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
            string a = _selectSQL;
           // Reports.ExcelReport excel = new Reports.ExcelReport(this.Text, 4, grid);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SearchConditionList.Clear();
            SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_Ethnicity", ComparisionTypes.EQUAL, cmbfk_Ethnicity);
            SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_Gender", ComparisionTypes.EQUAL, cmbfk_Gender);
            SearchConditionList.AddCriteria(ColumnTypes.String, "FirstName", ComparisionTypes.STARTS_WITH, txtFirstName);
            SearchConditionList.AddCriteria(ColumnTypes.String, "LastName", ComparisionTypes.STARTS_WITH, txtLastName);
        }
    }
}
