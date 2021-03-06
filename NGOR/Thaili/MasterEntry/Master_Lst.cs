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
    public partial class Master_Lst : Friuts.ListingFormBase
    {
        public Master_Lst()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            newToolbar.Text = Language. LanguageString.NewAdd;
            EditToolbar.Text = Language. LanguageString.Edit;
            DeleteToolbar.Text = Language. LanguageString.Delete;
            
            ExportToolbar.Text = Language. LanguageString.ExporttoExcel;
            FormType = FormTypes.ListingForm;
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
        public Master_Lst(string  tblName):this()
        {
            TableName = tblName;

        }
        private void List_Load(object sender, EventArgs e)
        {
            //<Listing>
           
            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("Title", ColumnTypes.String, "colTitle");
            switch (TableName)
            {
                case "Objective":
                    Text = " संस्थाको उद्देश्यहरु ";
                    //lblTitle.Text = " उद्देश्य :";
                    break;
                case "Document":
                    Text = "संलग्न विवरण ";
                    break;
                case "AffiliationOrganization":
                    Text = "आवद्धता प्रदायक निकाय ";
                    //lblTitle.Text = "निकाय :";
                    break;
                case "SubjectiveWrk":
                    Text = "विषयगत कार्यक्षेत्र ";
                    break;
                case "TargetAudience":
                    Text = "लक्षित वर्ग /समुदाय ";
                    //lblTitle.Text = "लक्षित वर्ग /समुदाय ";
                    break;
                case "MajorTaskAchieved":
                    Text = "संस्थाको सञ्चालन गरको प्रमुख कार्यक्रमहरु ";
                    break;
                case "Master_Specialization":
                    Text = "बिषयगत क्षेत्र";
                    break;
                case "Master_Position":
                    Text = "पद";
                    break;
                case "Master_Sex":
                    Text = "लिंग";
                    break;
                case "Master_Education":
                    Text = "शिक्षा ";
                    break;
                case "Master_MaritalStatus":
                    Text = "";
                    break;
                case "Master_Ethnicity":
                    Text = "जाति";
                    break;
                case "Master_Profession":
                    Text = "ब्यबशाये ";
                    break;
                case "Person_Role":
                    Text = "Member";
                    break;
            }

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
            return base.OpenEditForm(new Master_Ent(TableName));
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new Master_Ent(TableName));
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
