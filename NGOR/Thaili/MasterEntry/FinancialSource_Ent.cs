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
using Bsoft.Data;
using Bsoft.AppCom;
namespace UEMS
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class FinancialSource_Ent : Friuts.EntryFormBase
    {
        public FinancialSource_Ent()
        {
            InitializeComponent();
            ChangeLanguage();
            this.FirstControl = txtName;
            this.AcceptButton = btnOk;
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

        public FinancialSource_Ent(string TableName_)
        {
            TableName = TableName_;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
              Save();
        }

        private void FinancialSource_Ent_Load(object sender, EventArgs e)
        {
            //<Entry>
            TableName = "FinancialSource";
            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId, true, false);
            ColumnList.AddNewEditColumn("Name", ColumnTypes.String, txtName);
            ColumnList.AddNewEditColumn("TypeLocal", ColumnTypes.String, txtDonorType);
            ColumnList.AddNewEditColumn("fkHelpingOrganization", ColumnTypes.Number, cmbfkHelpingOrganization);
            ColumnList.AddEntryTrack(GlobalValues.LoginUserID, FormType );
            ComboUtilities .LoadData("Id", "Name", "HelpingOrganization", cmbfkHelpingOrganization, false,string .Empty  );


        }
        private void rdoLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLocal.Checked)
            {
                txtDonorType.Text = "L";
            }
            else
            {
                txtDonorType.Text = "I";
            }
        }
        public override bool LoadData()
        {
            bool loaded = base.LoadData();
            if (loaded)
            {
                if (txtDonorType.Text == "L")
                {
                    rdoLocal.Checked = true;
                }
                else
                {
                    rdoINGO.Checked = true;
                }
                //Load address
                 
            }
            return loaded;
        }

        private void rdoINGO_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLocal.Checked)
            {
                txtDonorType.Text = "L";
            }
            else
            {
                txtDonorType.Text = "I";
            }
        }
    }
}
