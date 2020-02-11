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
    public partial class NGO_AffiliationOrganization_Ent : Friuts.EntryFormBase
    {
        public NGO_AffiliationOrganization_Ent()
        {
            InitializeComponent();

            ChangeLanguage();
            this.FirstControl = txtRedgeNo;
            this.AcceptButton = btnOk;
        }
        public void ChangeLanguage()
        {
            btnCancel.Text = Language.LanguageString.Cancel;
            btnOk.Text = Language.LanguageString.Ok;
            txtRegistrationDate.Value = CrudeFx.NepaliDate.NepaliDate.Today;
            txtAffiliationDate.Value = CrudeFx.NepaliDate.NepaliDate.Today;
            txtRenualDuration.Value = CrudeFx.NepaliDate.NepaliDate.Today;
            txtLastRenualDate.Value = CrudeFx.NepaliDate.NepaliDate.Today;
            //newToolbar.Text = Language. LanguageString.NewAdd;
            //EditToolbar.Text = Language. LanguageString.Edit;
            //DeleteToolbar.Text = Language. LanguageString.Delete;
            //ExportToolbar.Text = Language. LanguageString.ExporttoExcel;
        }
        private string _NGOId = string.Empty;
        public NGO_AffiliationOrganization_Ent(string NGOId):this ()
        {
            _NGOId = NGOId;
           // InitializeComponent();
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
             Save();
        }

        private void NGO_AffiliationOrganization_Ent_Load(object sender, EventArgs e)
        {
            //<Entry>
            TableName = "NGO_AffiliationOrganization";
            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId, true, false);
            ColumnList.AddNewEditColumn("fk_NGO", ColumnTypes.Number, _NGOId);
            ColumnList.AddNewEditColumn("fk_AffiliationOrganization", ColumnTypes.Number, cmbfk_AffiliationOrganization);
            ComboUtilities.LoadData("Id", "Title", "AffiliationOrganization", cmbfk_AffiliationOrganization, true, string.Empty);
            ColumnList.AddNewEditColumn("RegistrationDate", ColumnTypes.String, txtRegistrationDate);
            ColumnList.AddNewEditColumn("AffiliationDate", ColumnTypes.String, txtAffiliationDate);
            ColumnList.AddNewEditColumn("RedgeNo", ColumnTypes.String, txtRedgeNo);
            ColumnList.AddNewEditColumn("LastRenualDate", ColumnTypes.String, txtLastRenualDate);
            ColumnList.AddNewEditColumn("RenualDuration", ColumnTypes.String, txtRenualDuration);


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
