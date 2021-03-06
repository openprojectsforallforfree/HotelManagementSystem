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
using Bsoft.Forms;
namespace UEMS
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class IndividualPerson_Ent : Friuts.EntryFormBase
    {
        public IndividualPerson_Ent()
        {
            InitializeComponent();
            dtBirthDate.Enabled = true;
            dtBirthDate.Value = CrudeFx.NepaliDate.NepaliDate.Today;
            ae = new Address_Ent();
            ae.pnlCountry.Visible = false;
            ae.flowLayoutPanel1.Parent = grpfk_Address;
            ae.Visible = false;
            
            ce = new ContactInformation_Ent();
            ce.pnlFax.Visible = false;
            ce.flowLayoutPanel1.Parent = grpContactInfo;
            ce.Visible = false;
            ChangeLanguage();
        }
        public void ChangeLanguage()
        {
            btnCancel.Text = Language.LanguageString.Cancel;
            btnOk.Text = Language.LanguageString.Ok;
        }
        Address_Ent ae = new Address_Ent();
        ContactInformation_Ent ce = new ContactInformation_Ent();


        private void btnOk_Click(object sender, EventArgs e)
        {

            if (dtBirthDate .Value .Year +12>CrudeFx .NepaliDate .NepaliDate .Today .Year )
            {
                MessageBoxMy.Show(this, "कृपया शही जन्म मिती दर्ता गर्नु होल । ", MessageBoxButtons.OK);
                return;
            }
            
            int pkae = 0, pkce = 0;
            ae.FormType = this.FormType;
            ce.FormType = this.FormType;
            ae.ConfirmationRequired = false;
            ce.ConfirmationRequired = false;
            if (ae.Save(false))
            {
                pkae = ae.getLatestIdFromSQL("ID");
            }
            if (ce.Save(false))
            {
                pkce = ce.getLatestIdFromSQL("ID");
            }
            txtfk_Address.Text = pkae.ToString();
            txtContactInfo.Text = pkce.ToString();
            Save();
            string a = _insertSQL;

        }

        private void IndividualPerson_Ent_Load(object sender, EventArgs e)
        {
            //<Entry>
            TableName = "IndividualPerson";
            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId, true, false);
            ColumnList.AddNewEditColumn("FirstName", ColumnTypes.String, txtFirstName);
            ColumnList.AddNewEditColumn("LastName", ColumnTypes.String, txtLastName);
            ColumnList.AddNewEditColumn("fk_Gender", ColumnTypes.Number, cmbfk_Gender);
            ColumnList.AddNewEditColumn("DateofBirth", ColumnTypes.NepaliDate , dtBirthDate);
            ComboUtilities.LoadData("Id", "Title", "Master_Sex", cmbfk_Gender, true,string .Empty );
            ColumnList.AddNewEditColumn("fk_Ethnicity", ColumnTypes.Number, cmbfk_Ethnicity);
            ComboUtilities.LoadData("Id", "Title", "Master_Ethnicity", cmbfk_Ethnicity, true, string.Empty);
            ColumnList.AddNewEditColumn("DifferentlyAbled", ColumnTypes.String, chkDifferentlyAbled);
            ColumnList.AddNewEditColumn("fk_Specialization", ColumnTypes.Number, cmbfk_Specialization);
            ComboUtilities.LoadData("Id", "Title", "Master_Specialization", cmbfk_Specialization, true, string.Empty);
            ColumnList.AddNewEditColumn("SocialWorkExp", ColumnTypes.String, txtSocialWorkExp);
            ColumnList.AddNewEditColumn("fk_HighestEducation", ColumnTypes.Number, cmbfk_HighestEducation);
            ComboUtilities.LoadData("Id", "Title", "Master_Education", cmbfk_HighestEducation, true, string.Empty);
            ColumnList.AddNewEditColumn("fk_Position", ColumnTypes.Number, cmbfk_Position);
            ComboUtilities.LoadData("Id", "Title", "Master_Position", cmbfk_Position, true, string.Empty);
            ColumnList.AddNewEditColumn("fk_Address", ColumnTypes.Number, txtfk_Address);
            ColumnList.AddNewEditColumn("fk_ContactInformation", ColumnTypes.Number, txtContactInfo);
            ColumnList.AddNewEditColumn("fk_Master_Profession", ColumnTypes.Number, cmbfk_Master_Profession);
            ComboUtilities.LoadData("Id", "Title", "Master_Profession", cmbfk_Master_Profession, true, string.Empty);
            LoadData();

            if (FormType == FormTypes.EditForm)
            {
                ae.PrimaryKeyValue = txtfk_Address.Text;
                ce.PrimaryKeyValue = txtContactInfo.Text;
                ae.FormType = FormTypes.EditForm;
                ce.FormType = FormTypes.EditForm;
                ae.LoadData();
                ce.LoadData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        UEMS.Master_Lst frmMaster_Specialization;
        UEMS.Master_Lst frmMaster_Profession;


        protected void getForm<T>(ref T frm) where T : Form, new()
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new T();
                frm.Owner = this;
                //frm.MdiParent = this;//for mdi child way
            }

        }    
        
        private void lblfk_Master_Profession_Click(object sender, EventArgs e)
        {
            getForm(ref frmMaster_Profession);
            frmMaster_Profession.TableName = "Master_Profession";
            frmMaster_Profession.ShowDialog();
            ComboUtilities.LoadData("Id", "Title", "Master_Profession", cmbfk_Master_Profession , true, string.Empty);
        }

        private void lblfk_Specialization_Click(object sender, EventArgs e)
        {
            getForm(ref frmMaster_Specialization);
            frmMaster_Specialization.TableName = "Master_Specialization";
            frmMaster_Specialization.ShowDialog();
            ComboUtilities.LoadData("Id", "Title", "Master_Specialization", cmbfk_Specialization , true, string.Empty);
        }

        private void lblfk_HighestEducation_Click(object sender, EventArgs e)
        {
            getForm(ref frmMaster_Education);
            frmMaster_Education.TableName = "Master_Education";
            frmMaster_Education.ShowDialog();

            ComboUtilities.LoadData("Id", "Title", "Master_Education", cmbfk_HighestEducation , true, string.Empty);
        }
        UEMS.Master_Lst frmMaster_Education;
        UEMS.Master_Lst frmMaster_Position;
   

        private void lblfk_Position_Click(object sender, EventArgs e)
        {
            getForm(ref frmMaster_Position);
            frmMaster_Position.TableName = "Master_Position";
            frmMaster_Position.ShowDialog();
            ComboUtilities.LoadData("Id", "Title", "Master_Position", cmbfk_Position, true, string.Empty);
        }
    }
}
