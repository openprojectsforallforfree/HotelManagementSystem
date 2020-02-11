using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text ;
using System.Windows.Forms;
using Friuts;
using Bsoft.Common.Language;
using Bsoft.Languages;
namespace UEMS.MasterEntry
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmMasterEntryList : Friuts.ListingFormBase
    {
        public frmMasterEntryList()
        {
            InitializeComponent();
            newToolbar.Text = Language.LanguageString.NewAdd;
            EditToolbar.Text = Language.LanguageString.Edit;
            DeleteToolbar.Text = Language.LanguageString.Delete;
            ExitToolbar.Text = Language.LanguageString.Close;
            ExportToolbar.Text = Language.LanguageString.ExporttoExcel;
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            toolstrip = toolStrip1;
          //   ChildToolStrip = toolStrip1;
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

        public frmMasterEntryList(string tblName)
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            toolstrip = toolStrip1;
            TableName = tblName;
            //   ChildToolStrip = toolStrip1;
        }
      
        private void Listing_Load(object sender, EventArgs e)
        {
           
            //<Listing>
            DataTableColumns.Add("id", ColumnTypes.Number, "colid", true, true);
            DataTableColumns.Add("Title", ColumnTypes.String, "colTitle");
            DataTableColumns.Add("Remarks", ColumnTypes.String, "colRemarks");

            switch (TableName)
            {
                case "Rights_Group_Master":
                    Text = "User Roles";
                    break;
                case "ExamBoard":
                    Text = "Exam Board eg Internal ,External,Board etc";
                    break;
                case "ExamType":
                    Text = "Exam Types eg Theory ,Practical,Viva  etc ";
                    break;
                case "CourseStartYear":
                    Text = "CourseStartYear eg 2010,2011 etc ";
                    break;
                case "Groups":
                    Text = "Group eg A,B,C etc ";
                    break;
                case "Module":
                    Text = "Module eg Class1,Class2 ,Grade1, First Year,First Semester etc";
                    break;
                case "Subject":
                    Text = "Subject eg English ,Math ,Science etc";
                    break;
                case "Course":
                    Text = "Course eg Schooling ,Lab assisstant , Radiologist ,MBA ,BBA etc";
                    break;
                
                case "LibrarayIssueType":
                    Text = "Libraray Issue Type eg Reference etc";
                    break;

                case "JournalType":
                    Text = "Journal Type";
                    break;
                case "Master_UnitCategory":
                    Text = "Measuring Unit Categories";
                    break;
                case "Master_Gender":
                    Text = "Gender Options";
                    break;
                case "Master_Education":
                    Text = "Education Options";
                    break;
                case "Master_Insurance":
                    Text = "Insurance Options";
                    break;
                case "Master_Livingin":
                    Text = "Livingin Options";
                    break;
                case "Master_LivingArea":
                    Text = "LivingArea Options";
                    break;
                case "Master_Dependency":
                    Text = "Dependency Options";
                    break;
                case "Master_MaritalStatus":
                    Text = "Marital-Status Options";
                    break;
                case "Master_HouseInsurance":
                    Text = "House-Insurance Options";
                    break;
                case "Master_Ethnicity":
                    Text = "Ethnicity Options";
                    break;
                case "Master_Profession":
                    Text = "Profession Options";
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
            return base.OpenEditForm(new frmMasterEntry (TableName ));
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new frmMasterEntry(TableName ));
        }
        
        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            string fieldname = "";
            string referencingTable = "Customer";
            switch (TableName)
            {
                case "JournalType":
                    fieldname = "JournalTypeId";
                    referencingTable = "Journal";
                    break;
                case "Master_UnitCategory":
                    fieldname = "Master_UnitCategoryId";
                    referencingTable = "Units";
                    break;
                case "Master_Gender":
                    fieldname = "Sex";
                    break;
                case "Master_Education":
                    fieldname = "Education";
                    break;
                case "Master_Insurance":
                    fieldname = "Insurance";
                    break;
                case "Master_Livingin":
                    fieldname = "Livingin";
                    break;
                case "Master_LivingArea":
                    fieldname = "LivingArea";
                    break;
                case "Master_Dependency":
                    fieldname = "DailyLivelyhood";
                    break;
                case "Master_MaritalStatus":
                    fieldname = "Marital-Status";
                    break;
                case "Master_HouseInsurance":
                    fieldname = "House-Insurance";
                    break;
                case "Master_Ethnicity":
                    fieldname = "Ethnicity";
                    break;
                case "Master_Profession":
                    fieldname = "PrimaryProfession";
                    break;
            }
            //Check if data is being used in another table
            
            if (CheckExist(referencingTable, fieldname, "Customer Entry"))
            {
                if (TableName == "Master_Profession")
                {
                    if (CheckExist("Customer", fieldname, "Customer Entry"))
                    {
                        Delete();
                    }
                }
                else
                {
                    Delete();
                }
            }
            
        }

        private void ExitToolbar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExportToolbar_Click(object sender, EventArgs e)
        {
            Reports.ExcelReport excel = new Reports.ExcelReport(this.Text , 4, grid);
        }
    }
}