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
    public partial class NGO_Document_Ent : Friuts.EntryFormBase
    {
        public NGO_Document_Ent()
        {
            InitializeComponent();
            TableName = "NGO_Document";
            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId, true, false);
            ColumnList.AddNewEditColumn("fk_RenualOfRegistraion", ColumnTypes.Number, txtfk_RenualOfRegistraion);
            ColumnList.AddNewEditColumn("fk_Document", ColumnTypes.Number, txtfk_Document);
            ChangeLanguage();
        }
        public void ChangeLanguage()
        {
            btnCancel.Text = Language. LanguageString.Cancel;
            btnOk.Text = Language. LanguageString.Ok;
            //newToolbar.Text = Language. LanguageString.NewAdd;
            //EditToolbar.Text = Language. LanguageString.Edit;
            //DeleteToolbar.Text = Language. LanguageString.Delete;
            //ExportToolbar.Text = Language. LanguageString.ExporttoExcel;
        }

         

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void NGO_Document_Ent_Load(object sender, EventArgs e)
        {
            //<Entry>


         
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
