using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using Bsoft.Controls;
using Bsoft.Common.Language;
using Bsoft.Languages;
using Bsoft.Data;
using Bsoft.AppCom;
namespace UEMS
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class NGO_Ent : Friuts.EntryFormBase
    {
        public NGO_Ent()
        {
            TableName = "NGO";
            InitializeComponent();

            txtD_LastAudit.Value = CrudeFx.NepaliDate.NepaliDate.Today;
            txtD_LastAgm.Value = CrudeFx.NepaliDate.NepaliDate.Today;
            txtD_Established.Value = CrudeFx.NepaliDate.NepaliDate.Today;
            txtD_Registration.Value = CrudeFx.NepaliDate.NepaliDate.Today;
            this.FirstControl = txtName;
            AcceptButton = btnOk;
            CancelButton = btnCancel;
            Bsoft.Common.Language.LanguageUtility.SetNep();
            LoadOtherControls();
            //<Entry>

            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId, true, false);
            ColumnList.AddNewEditColumn("Name", ColumnTypes.String, txtName, true, "नाम", "");
            ColumnList.AddNewEditColumn("EnglishName", ColumnTypes.String, txtEnglishName);
            ColumnList.AddNewEditColumn("Acronym", ColumnTypes.String, txtAcronym);
            ColumnList.AddNewEditColumn("DDCCode", ColumnTypes.String, txtDDCCode);
            ColumnList.AddNewEditColumn("fk_Address", ColumnTypes.Number, txtfk_Address);
            ColumnList.AddNewEditColumn("D_Registration", ColumnTypes.NepaliDate, txtD_Registration);
            ColumnList.AddNewEditColumn("D_Established", ColumnTypes.NepaliDate , txtD_Established);
            ColumnList.AddNewEditColumn("WorkingAreaText", ColumnTypes.String, txtWorkingAreaText);
            ColumnList.AddNewEditColumn("fk_ContactInformation", ColumnTypes.Number, txtContactInfo);
            ColumnList.AddNewEditColumn("fk_President", ColumnTypes.Number, txtPresidentId);
            ColumnList.AddNewEditColumn("fk_ContactPerson", ColumnTypes.Number, txtContactPerson);
            ColumnList.AddNewEditColumn("D_LastAgm", ColumnTypes.NepaliDate, txtD_LastAgm);
            ColumnList.AddNewEditColumn("D_LastAudit", ColumnTypes.NepaliDate, txtD_LastAudit);
            ColumnList.AddNewEditColumn("Parikalpana", ColumnTypes.String, txtParikalpana);
            ColumnList.AddNewEditColumn("Dhyaye", ColumnTypes.String, txtDhyaye);
            ColumnList.AddNewEditColumn("Lakshya", ColumnTypes.String, txtLakshya);
            ColumnList.AddNewEditColumn("Udeshya", ColumnTypes.String, txtUdeshya);
            ColumnList.AddNewEditColumn("SubjectiveWrkText", ColumnTypes.String, txtSubjectiveWrkText);
            ColumnList.AddNewEditColumn("TargetAudienceText", ColumnTypes.String, txtTargetAudienceText);
            ColumnList.AddNewEditColumn("WorkDoneText", ColumnTypes.String, txtWorkDoneText);
            ColumnList.AddNewEditColumn("GoalPlan", ColumnTypes.String, chkGoalPlan);
            ColumnList.AddNewEditColumn("FiscalPlan", ColumnTypes.String, chkFiscalPlan);
            ColumnList.AddNewEditColumn("HrPlan", ColumnTypes.String, chkHrPlan);
            ColumnList.AddNewEditColumn("BudgetPlan", ColumnTypes.String, chkBudgetPlan);
            ColumnList.AddNewEditColumn("Achievements", ColumnTypes.String, txtAchievements);
            ColumnList.AddNewEditColumn("Challenges", ColumnTypes.String, txtChallenges);
            ColumnList.AddNewEditColumn("fk_FormFillBy", ColumnTypes.Number, txtfk_FormFillBy);
            ColumnList.AddNewEditColumn("fk_RegisterBy", ColumnTypes.Number, cmbfk_RegisterBy);
            ComboUtilities.LoadData("Id", "Title", "IndividualPerson", cmbfk_RegisterBy, true, string.Empty);
            ColumnList.AddNewEditColumn("Remarks", ColumnTypes.String, txtRemarks);






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
        NGO_AffiliationOrganization_Lst nGO_AffiliationOrganization_Lst;
        lstNGO_ObjectiveView ngo_objectiveView;
        NGO_HelpingOrganization_Lst nGO_HelpingOrganization_Lst;
        NGO_Budget_Lst nGO_Budget_Lst;
        NGO_WorkingArea_Lst workingArea;
        TargetAudienceText_NGO_Lst targetAudienceText_NGO_Lst;
        SubjectiveWrk_NGO_Lst subjectiveWrk_NGO_Lst;

        Address_Ent AddressEntry;
        ContactInformation_Ent contactInformation_Ent;


        PersonView_Lst plvOrdiMem;
        PersonView_Lst plvWc;
        PersonView_Lst plvStaff;

        public void LoadOtherControls()
        {
            //Load set Other controls
            // tabControl1.Visible = false;
            //Bsoft.Utility.FormUtility.adjustHt(this, flowLayoutPanel1, tabControl1, false );
            //Load Affiliation Organizations
            nGO_AffiliationOrganization_Lst = new NGO_AffiliationOrganization_Lst();
            nGO_AffiliationOrganization_Lst.panel1.Parent = grpNGO_AffiliationOrganization;
            nGO_AffiliationOrganization_Lst.ConfirmationRequired = false;

            //Ngo Objectives
            ngo_objectiveView = new lstNGO_ObjectiveView();
            ngo_objectiveView.panel1.Parent = grpNGO_Objective;
            ngo_objectiveView.ConfirmationRequired = false;

            //Helping Org
            nGO_HelpingOrganization_Lst = new NGO_HelpingOrganization_Lst();
            nGO_HelpingOrganization_Lst.panel2.Parent = grpNGO_HelpingOrganization;
            nGO_HelpingOrganization_Lst.ConfirmationRequired = false;

            //Budget
            nGO_Budget_Lst = new NGO_Budget_Lst();
            nGO_Budget_Lst.panel1.Parent = grpFinancialSource;
            nGO_Budget_Lst.ConfirmationRequired = false;

            //working area 
            workingArea = new NGO_WorkingArea_Lst();
            workingArea.panel1.Parent = pnlNGO_WorkingArea;
            workingArea.ConfirmationRequired = false;

            //Target Audience  
            targetAudienceText_NGO_Lst = new TargetAudienceText_NGO_Lst();
            targetAudienceText_NGO_Lst.panel2.Parent = grpTargetAudience_NGO;
            targetAudienceText_NGO_Lst.ConfirmationRequired = false;

            //SubjectiveWrk_NGO_Ent
            subjectiveWrk_NGO_Lst = new SubjectiveWrk_NGO_Lst();
            subjectiveWrk_NGO_Lst.panel2.Parent = grpSubjectiveWrk_NGO;
            subjectiveWrk_NGO_Lst.ConfirmationRequired = false;

            //Load Address
            AddressEntry = new Address_Ent();
            AddressEntry.pnlCountry.Visible = false;
            AddressEntry.flowLayoutPanel1.Parent = grpfk_Address;

            //Load contact info
            contactInformation_Ent = new ContactInformation_Ent();
            contactInformation_Ent.txtEmail.Font = new Font("Verdana",11);
            contactInformation_Ent.txtWebSite .Font = new Font("Verdana", 11);
            contactInformation_Ent.txtPhone.Font = DigitFont;
            contactInformation_Ent.txtMobileNo.Font = DigitFont;
            contactInformation_Ent.txtFax.Font = DigitFont;
          //  contactInformation_Ent.pnlFax.Visible = false;
            contactInformation_Ent.flowLayoutPanel1.Parent = grpfk_ContactInformation;

            //Load Member
            plvOrdiMem = new PersonView_Lst();
            plvOrdiMem.panel1.Parent = this.grpNGO_OrdinaryMember;
            //Load Work Committe
            plvWc = new PersonView_Lst();
            plvWc.panel1.Parent = this.grpNGO_WorkingComitie;
            //Load Employee
            plvStaff = new PersonView_Lst();
            plvStaff.panel1.Parent = this.grpNGO_Staff;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //ColumnList.AddEntryTrack(AppGlobalResources.LoginUserID, FormType);
            if (FormType == FormTypes.EditForm)
            {
                ColumnList.AddNewEditColumn("UserIDEntry", ColumnTypes.Number, GlobalValues.LoginUserID);
                ColumnList.AddNewEditColumn("DT_DataEntry", ColumnTypes.Number, txtfk_FormFillBy);
            }
            else
            {
                ColumnList.AddNewEditColumn("UserIDEdit", ColumnTypes.Number, txtfk_FormFillBy);
                ColumnList.AddNewEditColumn("DT_DataEdit", ColumnTypes.Number, txtfk_FormFillBy);
            }


            AddressEntry.FormType = this.FormType;
            AddressEntry.ConfirmationRequired = false;

            contactInformation_Ent.FormType = this.FormType;
            contactInformation_Ent.ConfirmationRequired = false;
            if (FormType == FormTypes.EditForm)
            {
                if (Save())
                {
                    AddressEntry.Save(false);
                    contactInformation_Ent.Save(false);
                }
            }
            if (FormType == FormTypes.EntryForm)
            {
                //saves blank row in address table and gets id
                if (AddressEntry.Save(false))
                {
                    txtfk_Address.Text = AddressEntry.getLatestIdFromSQL("ID").ToString();
                    AddressEntry.PrimaryKeyValue = txtfk_Address.Text;
                    AddressEntry.txtId.Text = txtfk_Address.Text;
                }

                if (contactInformation_Ent.Save(false))
                {
                    txtContactInfo.Text = contactInformation_Ent.getLatestIdFromSQL("ID").ToString();
                    contactInformation_Ent.PrimaryKeyValue = txtContactInfo.Text;
                    contactInformation_Ent.txtId.Text = txtContactInfo.Text;
                }

                if (Save(false))
                {
                    txtId.Text = getLatestIdFromSQL("Id").ToString();
                    PrimaryKeyValue = getLatestIdFromSQL("Id");
                    FormType = FormTypes.EditForm;

                    //tabControl1.Enabled = true;
                    //tabControl1.Visible = true;
                    // Bsoft.Utility.FormUtility.adjustHt(this, flowLayoutPanel1, tabControl1,true );
                    LoadData();
                    txtEnglishName.Select();
                    txtEnglishName.Focus();
                }
            }
        }

        private bool firstloadAgm = true;
        private bool firstloadAudit = true;
        public override bool LoadData()
        {
            base.LoadData();
            firstloadAgm = true;
            firstloadAudit = true;
            if (txtD_LastAgm.Value.ToString () == NGOGlobalValues.Nodate.ToString ())
            {
                chkLastMeetng.Checked = false;
                txtD_LastAgm.Visible = false ;
            }
            else
            {
                chkLastMeetng.Checked = true;
                txtD_LastAgm.Visible = true;
            }
            if (txtD_LastAudit.Value.ToString() == NGOGlobalValues.Nodate.ToString())
            {
                chkLastAudit.Checked = false;
                txtD_LastAudit.Visible = false ;
            }
            else
            {
                chkLastAudit.Checked = true;
                txtD_LastAudit.Visible = true;
            }
            if (FormType == FormTypes.EditForm)
            {

                Bsoft.Utility.FormUtility.adjustHt(this, flowLayoutPanel1, tabControl1, true);

                nGO_AffiliationOrganization_Lst.LoadData(txtId.Text);
                ngo_objectiveView.LoadData(txtId.Text);
                nGO_HelpingOrganization_Lst.LoadData(txtId.Text);
                nGO_Budget_Lst.LoadData(txtId.Text);
                workingArea.LoadData(txtId.Text);
                targetAudienceText_NGO_Lst.LoadData(txtId.Text);
                subjectiveWrk_NGO_Lst.LoadData(txtId.Text);

                plvOrdiMem.LoadPersonData(txtId.Text, "1");//hard coded roles
                plvWc.LoadPersonData(txtId.Text, "2");
                plvStaff.LoadPersonData(txtId.Text, "3");


                AddressEntry.PrimaryKeyValue = txtfk_Address.Text;
                AddressEntry.FormType = FormTypes.EditForm;
                AddressEntry.LoadData();

                contactInformation_Ent.PrimaryKeyValue = txtContactInfo.Text;
                contactInformation_Ent.FormType = FormTypes.EditForm;
                contactInformation_Ent.LoadData();

                loadContactPerson(txtContactPerson.Text, lstGrdContactPeson);
                loadContactPerson(txtPresidentId.Text, lstGrdPresident);
            }
            firstloadAudit = false;
            firstloadAgm = false;
            return true;
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loadContactPerson(string KEY, ListingGrid lstGrdPerson)
        {
            if (KEY != "")
            {
                string SQL = "";
                SQL = string.Format("select firstname || ' ' || lastname as नाम FROM IndividualPerson  where id={0}", KEY);
                DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(SQL.ToString());
                lstGrdPerson.data = dt;
            }
        }
        void frm_valueSelected_ContactPerson(object sender, string SelectedPrimaryKey)
        {
            //DataGridViewRow row = (DataGridViewRow)frm.SelectedValue;
            //string KEY = row.Cells["colid"].Value.ToString();
            loadContactPerson(SelectedPrimaryKey, lstGrdContactPeson);
            txtContactPerson.Text = SelectedPrimaryKey;
            //SelectComboValue(cboProduct, KEY);
            // txtProduct.Text = KEY;
        }
        void frm_valueSelected_President(object sender, string SelectedPrimaryKey)
        {
            //DataGridViewRow row = (DataGridViewRow)frm.SelectedValue;
            //string KEY = row.Cells["colid"].Value.ToString();
            loadContactPerson(SelectedPrimaryKey, lstGrdPresident );
            txtPresidentId .Text = SelectedPrimaryKey;
            //SelectComboValue(cboProduct, KEY);
            // txtProduct.Text = KEY;
        }
         

       
        private void btnContactPerson_Click(object sender, EventArgs e)
        {
            IndividualPerson_Lst frm = new IndividualPerson_Lst();
            frm.FormType = FormTypes.SelectionForm;
            //frm.valueSelected = null;
            frm.valueSelected += new ListingFormBase.ValueSelected(frm_valueSelected_ContactPerson);
            frm.ShowDialog();
          //  selectPerson(txtContactPerson, lstGrdContactPeson);
        }
        private void btnPresident_Click(object sender, EventArgs e)
        {
            IndividualPerson_Lst frm = new IndividualPerson_Lst();
            frm.FormType = FormTypes.SelectionForm;
            frm.valueSelected += new ListingFormBase.ValueSelected(frm_valueSelected_President);
            frm.ShowDialog();
           // selectPerson(txtPresidentId, lstGrdPresident);
        }



        private void NGO_Ent_Shown(object sender, EventArgs e)
        {
            if (FormType == FormTypes.EditForm)
            {
                Bsoft.Utility.FormUtility.adjustHt(this, flowLayoutPanel1, tabControl1, true);
            }
            else
            {
                Bsoft.Utility.FormUtility.adjustHt(this, flowLayoutPanel1, tabControl1, false);
            }

        }

        private void chkLastAudit_CheckedChanged(object sender, EventArgs e)
        {
            if (firstloadAudit)
            {
                firstloadAudit = false;
                return;
            }
            txtD_LastAudit.Visible = chkLastAudit.Checked;
            if (!chkLastAudit.Checked)
            {
                txtD_LastAudit.Value = NGOGlobalValues.Nodate;
            }
            else
            {
                txtD_LastAudit.Value = CrudeFx.NepaliDate.NepaliDate.Today;
            }
        }

        private void chkLastMeetng_CheckedChanged(object sender, EventArgs e)
        {
            if (firstloadAgm)
            {
                firstloadAgm = false;
                return;
            }
            txtD_LastAgm.Visible = chkLastMeetng.Checked;
            if (!chkLastMeetng.Checked)
            {
                txtD_LastAgm.Value = NGOGlobalValues.Nodate;
            }
            else
            {
                txtD_LastAgm.Value = CrudeFx.NepaliDate.NepaliDate.Today;
            }
        }
    }
}
