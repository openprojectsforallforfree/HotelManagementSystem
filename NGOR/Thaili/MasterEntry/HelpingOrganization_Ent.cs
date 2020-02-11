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
    public partial class HelpingOrganization_Ent : Friuts.EntryFormBase
    {
        Address_Ent entAddress = new Address_Ent();
        public HelpingOrganization_Ent()
        {
            InitializeComponent();
            entAddress = new Address_Ent();
            entAddress.pnlCountry.Visible = false;
            entAddress.flowLayoutPanel1.Parent = grpfk_Address;
           

            //ce = new ContactInformation_Ent();
            //ce.pnlFax.Visible = false;
            //ce.flowLayoutPanel1.Parent = grpContactInfo;
            //ce.Visible = false;
            ChangeLanguage();
            this.FirstControl = txtName ;
            this.AcceptButton = btnOk;
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
        public HelpingOrganization_Ent(string TableName_):this()
        {
            TableName = TableName_;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int pkae = 0, pkce = 0;
            entAddress.FormType = this.FormType;
           // ce.FormType = this.FormType;
            entAddress.ConfirmationRequired = false;
           // ce.ConfirmationRequired = false;
            if (entAddress.Save(false))
            {
                pkae = entAddress.getLatestIdFromSQL("ID");//save address
            }
            //if (ce.Save(false))
            //{
            //    pkce = ce.getLatestIdFromSQL("ID");
            //}
            txtfk_Address.Text = pkae.ToString();
          //  txtContactInfo.Text = pkce.ToString();
            Save();
            string a = _insertSQL;
        }

        private void HelpingOrganization_Ent_Load(object sender, EventArgs e)
        {
            //<Entry>
            TableName = "HelpingOrganization";
            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId, true, false);
            ColumnList.AddNewEditColumn("Name", ColumnTypes.String, txtName);
            ColumnList.AddNewEditColumn("TypeLocal", ColumnTypes.String, txtDonorType);
            ColumnList.AddNewEditColumn("fk_Address", ColumnTypes.Number, txtfk_Address  );
            ColumnList.AddNewEditColumn("Objective", ColumnTypes.String, txtObjective);

            if (FormType == FormTypes.EditForm)
            {
                entAddress.PrimaryKeyValue = txtfk_Address.Text;
                //ce.PrimaryKeyValue = txtContactInfo.Text;
                entAddress.FormType = FormTypes.EditForm;
                //ce.FormType = FormTypes.EditForm;
                entAddress.LoadData();
                //ce.LoadData();
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
                string AddressId = txtfk_Address.Text;
                entAddress.txtId.Text = AddressId;
                entAddress.PrimaryKeyValue = txtfk_Address.Text;//imp
                entAddress.FormType = FormTypes.EditForm;
                entAddress.LoadData();

            }
            return loaded;
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
