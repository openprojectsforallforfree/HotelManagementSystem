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
    public partial class FiscalYears_Ent : Friuts.EntryFormBase
    {
        public FiscalYears_Ent()
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

        public FiscalYears_Ent(string TableName_)
        {
            TableName = TableName_;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void FiscalYears_Ent_Load(object sender, EventArgs e)
        {
            //<Entry>
TableName = "FiscalYears";
ColumnList.AddNewEditColumn("Id",ColumnTypes.Number, txtId ,true ,false );
ColumnList.AddNewEditColumn("FiscalYear",ColumnTypes.String, txtFiscalYear );
ColumnList.AddNewEditColumn("DateFrom",ColumnTypes.String, txtDateFrom );
ColumnList.AddNewEditColumn("DateTo",ColumnTypes.String, txtDateTo );

         
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
