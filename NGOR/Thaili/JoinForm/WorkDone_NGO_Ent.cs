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
    public partial class WorkDone_NGO_Ent : Friuts.EntryFormBase
    {
        public WorkDone_NGO_Ent()
        {
            InitializeComponent();
            ChangeLanguage();
        }
        public void ChangeLanguage()
        {
            btnCancel.Text = Language.LanguageString.Cancel;
            btnOk.Text = Language.LanguageString.Ok;
            //newToolbar.Text = Language. LanguageString.NewAdd;
            //EditToolbar.Text = Language. LanguageString.Edit;
            //DeleteToolbar.Text = Language. LanguageString.Delete;
            //ExportToolbar.Text = Language. LanguageString.ExporttoExcel;
        }

        public WorkDone_NGO_Ent(string TableName_)
        {
            TableName = TableName_;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void WorkDone_NGO_Ent_Load(object sender, EventArgs e)
        {
            //<Entry>
TableName = "WorkDone_NGO";
ColumnList.AddNewEditColumn("Id",ColumnTypes.Number, txtId ,true ,false );
ColumnList.AddNewEditColumn("NGO_ID",ColumnTypes.Number, txtNGO_ID );
ColumnList.AddNewEditColumn("fk_WorkDone",ColumnTypes.Number, txtfk_WorkDone );

         
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
