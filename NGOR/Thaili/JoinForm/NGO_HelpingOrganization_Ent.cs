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
    public partial class NGO_HelpingOrganization_Ent : Friuts.EntryFormBase
    {
        public NGO_HelpingOrganization_Ent()
        {
            InitializeComponent();
            TableName = "NGO_HelpingOrganization";
            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId, true, false);
            ColumnList.AddNewEditColumn("fk_NGO", ColumnTypes.Number, txtfk_NGO);
            ColumnList.AddNewEditColumn("fk_HelpingOrganization", ColumnTypes.Number, txtFkHelpingOrg );
           // ComboBoxDataLoader.LoadData("Id", "Title", "HelpingOrganization", cmbfk_HelpingOrganization, true);

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

        public NGO_HelpingOrganization_Ent(string TableName_):this ()
        {
            TableName = TableName_;
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void NGO_HelpingOrganization_Ent_Load(object sender, EventArgs e)
        {
            //<Entry>

         
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
