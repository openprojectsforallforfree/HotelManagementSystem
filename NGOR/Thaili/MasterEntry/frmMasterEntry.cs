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
    public partial class frmMasterEntry : Friuts.EntryFormBase
    {
        public frmMasterEntry()
        {
            InitializeComponent();
            btnCancel.Text = Language.LanguageString .Cancel;
            btnOk.Text = Language.LanguageString.Ok;
            this.FirstControl = txtTitle;
            this.AcceptButton = btnOk;
        }

        public frmMasterEntry(string tablename_)
        {
            InitializeComponent();
            TableName = tablename_;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void frmMasterEntry_Load(object sender, EventArgs e)
        {
            //<Entry>

            ColumnList.AddNewEditColumn("id", ColumnTypes.Number, txtid, true, false);
            ColumnList.AddNewEditColumn("Title", ColumnTypes.String, txtTitle);
            ColumnList.AddNewEditColumn("Remarks", ColumnTypes.String, txtRemarks);
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
                case "CourseSession":
                    Text = "CourseSession eg First year , Second year ,First Semester etc";
                    break;
                case "LibrarayIssueType":
                    Text = "Libraray Issue Type eg Reference etc";
                    break;

                case "JournalType":
                    Text = "Journal Type";
                    break;
                case "Master_UnitCategory":
                    Text = "Unit Categories Entry";
                    break;
                case "Master_Gender":
                    Text = "Gender Entry";
                    break;
                case "Master_Education":
                    Text = "Education Entry";
                    break;
                case "Master_Insurance":
                    Text = "Insurance Entry";
                    break;
                case "Master_Livingin":
                    Text = "Livingin Entry";
                    break;
                case "Master_LivingArea":
                    Text = "LivingArea Entry";
                    break;
                case "Master_Dependency":
                    Text = "Dependency Entry";
                    break;
                case "Master_MaritalStatus":
                    Text = "Marital-Status Entry";
                    break;
                case "Master_HouseInsurance":
                    Text = "House-Insurance Entry";
                    break;
                case "Master_Ethnicity":
                    Text = "Ethnicity Entry";
                    break;
                case "Master_Profession":
                    Text = "Profession Entry";
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}