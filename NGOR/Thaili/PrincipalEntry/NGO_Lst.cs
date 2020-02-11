using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using Bsoft.Common.Language;
using UEMS.BLL;
using Bsoft.Languages;
using Bsoft.Data;
using Bsoft.AppCom;
using Bsoft.Common;
namespace UEMS
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class NGO_Lst : Friuts.ListingFormBase
    {
        public NGO_Lst()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            // toolstrip = toolStrip1;
            btnOk.Text = Language.LanguageString.Search;
            ChangeLanguage();
            ComboUtilities.LoadData("sn", "Fiscalyear", "Fiscalyears", cmbfk_FinancialYear,false, string.Empty);
            //ComboUtilities.SelectComboBoxItemUsingValue(cmbfk_FinancialYear, ConstantValues.CurrentFiscalYearValue);
          // FiscalYearLoader.LoadData(cmbfk_FinancialYear,false );
            
           
        }
        public void ChangeLanguage()
        {
            //btnCancel.Text = Language.Cancel;
            //btnOk.Text = Language.Ok;
            newToolbar.Text = Language.LanguageString.NewAdd;
            EditToolbar.Text = Language.LanguageString.Edit;
            DeleteToolbar.Text = Language.LanguageString.Delete;
            // ExportToolbar.Text = Language. LanguageString.ExporttoExcel;
        }

        private void checkRegistered()
        {
            object obj = GlobalResources.SelectDBConnection.ExecuteScalar("Select Count(1) FROM NGO");
            int count = 0;
            try
            {
                count = int.Parse(obj.ToString());
            }
            catch { }
            if (Bsoft.AppCom.Entities.DataSave.isRunOk(TableName, (new frmRegister()), 5))
                return;
            //string temp = skgen.GetGegLock(ConstantValues.Org_Name, ConstantValues.Org_District, ConstantValues.ProductName, ConstantValues.ProductVersion);

            //if (count > 3 && !Bsoft.Common.skgenNoMachine.isKey(ConstantValues.RegistraionKey, temp))
            //{
            //    frmRegister reg = new frmRegister();
            //    reg.IsMachine = false;
            //    reg.ShowDialog();
            //    Close();
            //    Application.ExitThread();
            //    Application.Exit();
            //    this.Dispose();
            //    return;
            //}
        }
        private void List_Load(object sender, EventArgs e)
        {
            checkRegistered();

            switch (typeOfNgoForm)
            {
                case TypeOfNgoForm.ForNGO:
                    break;
                case TypeOfNgoForm.ForReview:
                case TypeOfNgoForm.ForRenew:
                case TypeOfNgoForm.ForDartaReport:
                    FormType = FormTypes.SelectionForm;
                    
                        this.valueSelected += new ValueSelected(NGO_Lst_valueSelected);    
                     
                    break;
                default:
                    break;
            }
            
            
            //<Listing>
            TableName = "NGO";
            DtLoad();

        }
     
     
        void NGO_Lst_valueSelected(object sender, string SelectedPrimaryKey)
        {

            switch (typeOfNgoForm)
            {
                case TypeOfNgoForm.ForNGO:
                    break;
                case TypeOfNgoForm.ForReview:
                    UEMS.YearlyReport_Lst review = new YearlyReport_Lst(SelectedPrimaryKey);
                    review.ShowDialog();
                    break;
                case TypeOfNgoForm.ForRenew:
                    UEMS.RenualOfRegistraion_Lst renew = new RenualOfRegistraion_Lst(SelectedPrimaryKey);
                    renew.ShowDialog();
                    break;
                case TypeOfNgoForm.ForDartaReport:
                    string ReportName = @"ReportFiles\QuestionReport.rpt";
                    NGOReports.QuestionsReport.GetReport(ReportName, SelectedPrimaryKey);
                    break;
                default:
                    break;
            }


        
        }
        private void DtLoad()
        {
            DataTableColumns.Add("t1_Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("NepaliName", ColumnTypes.String, "colName");
            DataTableColumns.Add("EnglishName", ColumnTypes.String, "colEnglishName");
            DataTableColumns.Add("Acronym", ColumnTypes.String, "colAcronym");
            DataTableColumns.Add("t1_DDCCode", ColumnTypes.String, "colDDCCode");
            //DataTableColumns.Add("fk_Address", ColumnTypes.Number, "colfk_Address");
            // RelationList.Add("ADDRESS", "Address", "id", "Tole || ' ' || LocalBody || ' ' || District || ' ' || Zone || ' ' || Country AS ADDRESS", "colfk_Address", TableJoinTypes.LEFT_JOIN);
            DataTableColumns.Add("ADDRESS", ColumnTypes.String, "colfk_Address");

            DataTableColumns.Add("t1_D_Registration", ColumnTypes.NepaliDate, "colD_Registration");
            DataTableColumns.Add("t1_D_Established", ColumnTypes.NepaliDate, "colD_Established");
            DataTableColumns.Add("t1_WorkingAreaText", ColumnTypes.String, "colWorkingAreaText");
            DataTableColumns.Add("t3_Phone", ColumnTypes.Number, "colfk_ContactInformation");

            //DataTableColumns.Add("fk_President", ColumnTypes.Number, "colfk_President");
            //RelationList.Add("fk_President", "IndividualPerson", "id", "FirstName || ' ' || LastName as Name", "colfk_President", TableJoinTypes.LEFT_JOIN);

            DataTableColumns.Add("ContanctPersonName", ColumnTypes.Number, "colfk_ContactPerson");

            DataTableColumns.Add("t1_D_LastAgm", ColumnTypes.NepaliDate, "colD_LastAgm");
            DataTableColumns.Add("t1_D_LastAudit", ColumnTypes.NepaliDate, "colD_LastAudit");
            DataTableColumns.Add("t1_Parikalpana", ColumnTypes.String, "colParikalpana");
            DataTableColumns.Add("t1_Dhyaye", ColumnTypes.String, "colDhyaye");
            DataTableColumns.Add("t1_Lakshya", ColumnTypes.String, "colLakshya");
            DataTableColumns.Add("t1_Udeshya", ColumnTypes.String, "colUdeshya");
            DataTableColumns.Add("t1_SubjectiveWrkText", ColumnTypes.String, "colSubjectiveWrkText");
            DataTableColumns.Add("t1_TargetAudienceText", ColumnTypes.String, "colTargetAudienceText");
            DataTableColumns.Add("t1_WorkDoneText", ColumnTypes.String, "colWorkDoneText");
            DataTableColumns.Add("t1_GoalPlan", ColumnTypes.String, "colGoalPlan");
            DataTableColumns.Add("t1_FiscalPlan", ColumnTypes.String, "colFiscalPlan");
            DataTableColumns.Add("t1_HrPlan", ColumnTypes.String, "colHrPlan");
            DataTableColumns.Add("t1_BudgetPlan", ColumnTypes.String, "colBudgetPlan");
            DataTableColumns.Add("t1_Achievements", ColumnTypes.String, "colAchievements");
            DataTableColumns.Add("t1_Challenges", ColumnTypes.String, "colChallenges");
            //DataTableColumns.Add("fk_FormFillBy", ColumnTypes.Number, "colfk_FormFillBy");
            //DataTableColumns.Add("fk_RegisterBy", ColumnTypes.Number, "colfk_RegisterBy");
            //DataTableColumns.Add("Remarks", ColumnTypes.String, "colRemarks");
        }

        //private void DtLoadWithoutSqloveride()
        //{
        //    DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
        //    DataTableColumns.Add("Name", ColumnTypes.String, "colName");
        //    DataTableColumns.Add("EnglishName", ColumnTypes.String, "colEnglishName");
        //    DataTableColumns.Add("Acronym", ColumnTypes.String, "colAcronym");
        //    DataTableColumns.Add("DDCCode", ColumnTypes.String, "colDDCCode");
        //    //DataTableColumns.Add("fk_Address", ColumnTypes.Number, "colfk_Address");
        //    RelationList.Add("fk_Address", "Address", "id", "Tole || ' ' || LocalBody || ' ' || District || ' ' || Zone || ' ' || Country AS ADDRESS", "colfk_Address", TableJoinTypes.LEFT_JOIN);

        //    DataTableColumns.Add("D_Registration", ColumnTypes.String, "colD_Registration");
        //    DataTableColumns.Add("D_Established", ColumnTypes.String, "colD_Established");
        //    DataTableColumns.Add("WorkingAreaText", ColumnTypes.String, "colWorkingAreaText");
        //    //DataTableColumns.Add("fk_ContactInformation", ColumnTypes.Number, "colfk_ContactInformation");
        //    RelationList.Add("fk_ContactInformation", "ContactInformation", "id", "Phone", "colfk_ContactInformation", TableJoinTypes.LEFT_JOIN);

        //    //DataTableColumns.Add("fk_President", ColumnTypes.Number, "colfk_President");
        //    //RelationList.Add("fk_President", "IndividualPerson", "id", "FirstName || ' ' || LastName as Name", "colfk_President", TableJoinTypes.LEFT_JOIN);

        //    //DataTableColumns.Add("fk_ContactPerson", ColumnTypes.Number, "colfk_ContactPerson");
        //    RelationList.Add("fk_ContactPerson", "IndividualPerson", "id", "FirstName || ' ' || LastName as Name", "colfk_ContactPerson", TableJoinTypes.LEFT_JOIN);

        //    DataTableColumns.Add("D_LastAgm", ColumnTypes.String, "colD_LastAgm");
        //    DataTableColumns.Add("D_LastAudit", ColumnTypes.String, "colD_LastAudit");
        //    DataTableColumns.Add("Parikalpana", ColumnTypes.String, "colParikalpana");
        //    DataTableColumns.Add("Dhyaye", ColumnTypes.String, "colDhyaye");
        //    DataTableColumns.Add("Lakshya", ColumnTypes.String, "colLakshya");
        //    DataTableColumns.Add("Udeshya", ColumnTypes.String, "colUdeshya");
        //    DataTableColumns.Add("SubjectiveWrkText", ColumnTypes.String, "colSubjectiveWrkText");
        //    DataTableColumns.Add("TargetAudienceText", ColumnTypes.String, "colTargetAudienceText");
        //    DataTableColumns.Add("WorkDoneText", ColumnTypes.String, "colWorkDoneText");
        //    DataTableColumns.Add("GoalPlan", ColumnTypes.String, "colGoalPlan");
        //    DataTableColumns.Add("FiscalPlan", ColumnTypes.String, "colFiscalPlan");
        //    DataTableColumns.Add("HrPlan", ColumnTypes.String, "colHrPlan");
        //    DataTableColumns.Add("BudgetPlan", ColumnTypes.String, "colBudgetPlan");
        //    DataTableColumns.Add("Achievements", ColumnTypes.String, "colAchievements");
        //    DataTableColumns.Add("Challenges", ColumnTypes.String, "colChallenges");
        //    DataTableColumns.Add("fk_FormFillBy", ColumnTypes.Number, "colfk_FormFillBy");
        //    DataTableColumns.Add("fk_RegisterBy", ColumnTypes.Number, "colfk_RegisterBy");
        //    DataTableColumns.Add("Remarks", ColumnTypes.String, "colRemarks");
        //}

        public override bool LoadData()
        {

            base.LoadData();

           
            return true;
        }

        public override bool GenerateSelectSQL()
        {

            SelectSQL = @"
SELECT
	t1.Id t1_Id,
	t1.Name NepaliName,
	t1.EnglishName EnglishName,
	t1.Acronym Acronym,
	t1.DDCCode t1_DDCCode,
	t1.D_Registration t1_D_Registration,
	t1.D_Established t1_D_Established,
	t1.WorkingAreaText t1_WorkingAreaText,
	t1.D_LastAgm t1_D_LastAgm,
	t1.D_LastAudit t1_D_LastAudit,
	t1.Parikalpana t1_Parikalpana,
	t1.Dhyaye t1_Dhyaye,
	t1.Lakshya t1_Lakshya,
	t1.Udeshya t1_Udeshya,
	t1.SubjectiveWrkText t1_SubjectiveWrkText,
	t1.TargetAudienceText t1_TargetAudienceText,
	t1.WorkDoneText t1_WorkDoneText,
	t1.GoalPlan t1_GoalPlan,
	t1.FiscalPlan t1_FiscalPlan,
	t1.HrPlan t1_HrPlan,
	t1.BudgetPlan t1_BudgetPlan,
	t1.Achievements t1_Achievements,
	t1.Challenges t1_Challenges,
	t1.fk_FormFillBy t1_fk_FormFillBy,
	t1.fk_RegisterBy t1_fk_RegisterBy,
	t1.Remarks t1_Remarks,
	t1.fk_Address t1_fk_Address,
	t2.Tole || ' ' || LocalBody || ' ' || District || ' ' || Zone || ' ' || Country Address,
	t1.fk_ContactInformation t1_fk_ContactInformation,
	t3.Phone t3_Phone,
	t1.fk_ContactPerson t1_fk_ContactPerson,
	t4.FirstName || ' ' || LastName ContanctPersonName ,
    t1.UserIDEntry UserIDEntry
FROM NGO t1

	 left join Address t2 on t1.fk_Address = t2.id 
	 left join ContactInformation t3 on t1.fk_ContactInformation = t3.id 
	 left join IndividualPerson t4 on t1.fk_ContactPerson = t4.id  
";

            SearchConditionList.Clear();
            if (txtName_Np.Text.Trim().Length != 0)
            {
                SearchConditionList.AddCriteria(ColumnTypes.String, "NepaliName", ComparisionTypes.STARTS_WITH, txtName_Np);
            }
            if (txtName_En.Text.Trim().Length != 0)
            {
                SearchConditionList.AddCriteria(ColumnTypes.String, "EnglishName", ComparisionTypes.STARTS_WITH, txtName_En);
            }
            if (txtTarget.Text.Trim().Length != 0)
            {
                SearchConditionList.AddCriteria(ColumnTypes.String, "t1_TargetAudienceText", ComparisionTypes.STARTS_WITH, txtTarget);
            }
            if (txtTarget.Text.Trim().Length != 0)
            {
                SearchConditionList.AddCriteria(ColumnTypes.String, "t1_WorkingAreaText", ComparisionTypes.STARTS_WITH, txtWorkArea);
            }
            if (chkMyEnties.Checked)
            {
                SearchConditionList.AddCriteria(ColumnTypes.Number, "UserIDEntry", ComparisionTypes.EQUAL, GlobalValues.LoginUserID.ToString());
            }
            SelectSQL = SelectSQL + " WHERE 1=1 ";
            string WhSql = SearchConditionList.GetSearchCriteria().Trim ();
            if (WhSql.Length >0)
            {
               SelectSQL =SelectSQL+ " AND " + WhSql;
            }


            if (cmbfk_FinancialYear .SelectedIndex !=0 && cmbfk_FinancialYear .Text != "")
            {
                //todo
                SelectSQL = SelectSQL + string.Format(@" AND t1_Id in (
                SELECT
                distinct fk_ngo
                FROM RenualOfRegistraion  
                where FISCALYEARid ={0}
                )", ((ComboItem )(cmbfk_FinancialYear.SelectedItem)).Key );

            }
            return true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newToolbar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            OpenNewForm();
            this.Visible = true;
        }

        private void EditToolbar_Click(object sender, EventArgs e)
        {
            OpenEditForm();
        }
        public override bool OpenEditForm()
        {
            return base.OpenEditForm(new NGO_Ent());
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new NGO_Ent());
        }

        public override bool GenerateDeleteSQL()
        {
             _deleteSQL = "DELETE FROM NGO WHERE ID = '" + GetSelectedRowPrimaryKey() + "'";
            return true ;
        }
        public override bool Delete()
        {
           
            string AddressId = GetSelectedRowValue("colfk_Address");
       //     string deleteqry = "DELETE FROM NGO WHERE ID = '" + GetSelectedRowPrimaryKey() + "'";
       //string s =     GlobalResources.SelectDBConnection.ExecuteNonQuery(deleteqry).ToString ();
            if (base .Delete ())
            {
                DeleteFromOther("NGO_Objective");
                DeleteFromOther("NGO_Document");
                DeleteFromOther("NGO_AffiliationOrganization");
                DeleteFromOther("NGO_HelpingOrganization");
                DeleteFromOther("NGO_Budget");
                DeleteFromOther("NGO_Member");
                DeleteFromOther("NGO_YearlyReport");
                DeleteFromOther("SubjectiveWrk_NGO");

                DeleteFromOther("TargetAudienceText_NGO");
                DeleteFromOther("WorkDone_NGO");
                DeleteFromOther("NGO_WorkingArea");

                DeleteGeneral("Address", AddressId);
                LoadData();

                return true;
            }
            return false ;
        }
        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            Delete();
        }
        private void DeleteGeneral(string table, string Id)
        {
            string Sql = string.Format("DELETE FROM {0} WHERE fk_NGO = {1}", table, PrimaryKeyValue.ToString());
            int result = GlobalResources.SelectDBConnection.ExecuteNonQuery(Sql);
        }
        private void DeleteFromOther(string table)
        {
            string Sql = string.Format("DELETE FROM {0} WHERE fk_NGO = {1}", table, PrimaryKeyValue.ToString());
            int result = GlobalResources.SelectDBConnection.ExecuteNonQuery(Sql);
        }
        private void ExitToolbar_Click(object sender, EventArgs e)
        {

        }

        private void ExportToolbar_Click(object sender, EventArgs e)
        {
            Reports.ExcelReport excel = new Reports.ExcelReport(this.Text, 4, grid);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void RefreshGrid()
        {
            SearchConditionList.Clear();

            //if (chkStart_End_Issued.Checked == true && txtAD_BS_A.Text == "A_N")
            //{
            //    SearchConditionList.AddBetweenCriteria(ColumnTypes.NepaliDate, "DateIssued", dateP_ANepFrom, dateP_ANepTo);
            //}
            //if (chkStart_End_Issued.Checked == true && txtAD_BS_A.Text == "A_E")
            //{
            //    CrudeFx.NepaliDate.NepaliDate fromDate = CrudeFx.NepaliDate.DateConvertor.GetNepaliDate(dateP_AEngFrom.Value);
            //    CrudeFx.NepaliDate.NepaliDate toDate = CrudeFx.NepaliDate.DateConvertor.GetNepaliDate(dateP_AEngTo.Value);
            //    txtDateEngFrom_A.Text = fromDate.ToString();
            //    txtDateEngTo_A.Text = toDate.ToString();
            //    SearchConditionList.AddBetweenCriteria(ColumnTypes.NepaliDate, "DateIssued", txtDateEngFrom_A, txtDateEngTo_A);
            //}
            //if (chkStart_End_Entry.Checked == true && txtAD_BS_B.Text == "B_N")
            //{
            //    SearchConditionList.AddBetweenCriteria(ColumnTypes.NepaliDate, "DataEntryVSDate", dateP_BNepFrom, dateP_BNepTo);
            //}
            //if (chkStart_End_Entry.Checked == true && txtAD_BS_B.Text == "B_E")///eng entrydate if present in database but eng issuedate is not
            //{
            //    SearchConditionList.AddBetweenCriteria(ColumnTypes.NepaliDate, "DataEntryVSDate", dateP_BEngFrom, dateP_BEngTo);
            //}


            //if (txtCitizenshipNo.Text.Trim().Length != 0)
            //{
            //    SearchConditionList.AddCriteria(ColumnTypes.String, "CitizenShipNo", ComparisionTypes.EQUAL, txtCitizenshipNo);
            //}
            //if (txtSymbolNo.Text.Trim().Length != 0 && txtSymbolNo.Text.Trim() != "0")
            //{
            //    SearchConditionList.AddCriteria(ColumnTypes.Number, "SN", ComparisionTypes.EQUAL, txtSymbolNo);
            //}

            //if (txtApprovedBy.Text.Trim().Length != 0)
            //{
            //    SearchConditionList.AddCriteria(ColumnTypes.String, "SigningPerson", ComparisionTypes.EQUAL, txtApprovedBy);
            //}
            ////
            //if (txtReferredBy.Text.Trim().Length != 0)
            //{
            //    SearchConditionList.AddCriteria(ColumnTypes.String, "RecommendingPerson", ComparisionTypes.EQUAL, txtReferredBy);
            //}
           
            //if (txtCast_En.Text.Trim().Length != 0)
            //{
            //    SearchConditionList.AddCriteria(ColumnTypes.String, "LEngName", ComparisionTypes.STARTS_WITH, txtCast_En);
            //}
            ////IdentifingPerson====txtExaminedBy
            //if (txtExaminedBy.Text.Trim().Length != 0)
            //{
            //    SearchConditionList.AddCriteria(ColumnTypes.String, "IdentifingPerson", ComparisionTypes.EQUAL, txtExaminedBy);
            //}
            ////FatherName
            //if (txtFatherName.Text.Trim().Length != 0)
            //{
            //    SearchConditionList.AddCriteria(ColumnTypes.String, "FatherName", ComparisionTypes.EQUAL, txtFatherName);
            //}
            ////SpouseName
            //if (txtHusband_Wife.Text.Trim().Length != 0)
            //{
            //    SearchConditionList.AddCriteria(ColumnTypes.String, "SpouseName", ComparisionTypes.EQUAL, txtHusband_Wife);
            //}
            ////MOTHERSNAME
            //if (txtMother_Name.Text.Trim().Length != 0)
            //{
            //    SearchConditionList.AddCriteria(ColumnTypes.String, "MOTHERSNAME", ComparisionTypes.EQUAL, txtMother_Name);
            //}
            ////txtTheliNumber
            //if (txtTheliNumber.Text.Trim().Length != 0 && txtTheliNumber.Text.Trim() != "0")
            //{
            //    SearchConditionList.AddCriteria(ColumnTypes.String, "TheliNo", ComparisionTypes.EQUAL, txtTheliNumber);
            //}
            ////ISEMPLOYEESFAMILY
            ////if (txtISEMPLOYEESFAMILY.Text.Trim().Length != 0 )
            ////{
            ////    SearchConditionList.AddCriteria(ColumnTypes.Number, "ISEMPLOYEESFAMILY", ComparisionTypes.EQUAL, txtISEMPLOYEESFAMILY);
            ////}
            ////ISEMPLOYEESFAMILY
            //if (chkEmployeeFamily.Checked)
            //{
            //    SearchConditionList.AddCriteria(ColumnTypes.Number, "ISEMPLOYEESFAMILY", ComparisionTypes.EQUAL, 1);
            //}
            ////fk_UserID
           

            ////comCitizenshipType
            //if (comCitizenshipType.SelectedItem != null)
            //{
            //    ComboItem item = (ComboItem)comCitizenshipType.SelectedItem;
            //    int zid = Convert.ToInt32(item.Key);
            //    SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_CSCTypeID", ComparisionTypes.EQUAL, zid);
            //}
            //if (comBirthZoneID.SelectedItem != null & comBirthZoneID.SelectedItem != "")
            //{
            //    ComboItem item = (ComboItem)comBirthZoneID.SelectedItem;
            //    try
            //    {
            //        int zid = Convert.ToInt32(item.Key);
            //        SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_BirthZoneID", ComparisionTypes.EQUAL, zid);
            //    }
            //    catch { }
            //}
            //if (comBirthWardNo.SelectedItem != null)
            //{
            //    ComboItem item = (ComboItem)comBirthWardNo.SelectedItem;
            //    int zid = Convert.ToInt32(item.Key);
            //    if (zid >= 0)
            //    {
            //        SearchConditionList.AddCriteria(ColumnTypes.Number, "BirthWardNo", ComparisionTypes.EQUAL, zid);
            //    }
            //}
            //if (comBirthDistrictID.SelectedItem != null)
            //{
            //    ComboItem item = (ComboItem)comBirthDistrictID.SelectedItem;
            //    try
            //    {
            //        int zid = Convert.ToInt32(item.Key);
            //        SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_BirthDistrictID", ComparisionTypes.EQUAL, zid);
            //    }
            //    catch { }
            //}
            ////comBirthVDCID
            //if (comBirthVDCID.SelectedItem != null)
            //{
            //    ComboItem item = (ComboItem)comBirthVDCID.SelectedItem;
            //    try
            //    {
            //        int zid = Convert.ToInt32(item.Key);
            //        SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_BirthVDCID", ComparisionTypes.EQUAL, zid);
            //    }
            //    catch { }
            //}
            ////comPAddressZoneID
            //if (comPAddressZoneID.SelectedItem != null)
            //{
            //    ComboItem item = (ComboItem)comPAddressZoneID.SelectedItem;
            //    try
            //    {
            //        int zid = Convert.ToInt32(item.Key);
            //        SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_PAddressZoneID", ComparisionTypes.EQUAL, zid);
            //    }
            //    catch { }
            //}
            ////comPAddressDistrictID
            //if (comPAddressDistrictID.SelectedItem != null)
            //{
            //    ComboItem item = (ComboItem)comPAddressDistrictID.SelectedItem;
            //    try
            //    {
            //        int zid = Convert.ToInt32(item.Key);
            //        SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_PAddressDistrictID", ComparisionTypes.EQUAL, zid);
            //    }
            //    catch { }
            //}
            ////comPAddressVDCID
            //if (comPAddressVDCID.SelectedItem != null)
            //{
            //    ComboItem item = (ComboItem)comPAddressVDCID.SelectedItem;
            //    try
            //    {
            //        int zid = Convert.ToInt32(item.Key);
            //        SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_PAddressVDCID", ComparisionTypes.EQUAL, zid);
            //    }
            //    catch { }
            //}
            ////comPAddressWardNo
            //if (comPAddressWardNo.SelectedItem != null)
            //{
            //    ComboItem item = (ComboItem)comPAddressWardNo.SelectedItem;
            //    int zid = Convert.ToInt32(item.Key);
            //    if (zid >= 0)
            //    {
            //        SearchConditionList.AddCriteria(ColumnTypes.Number, "PAddressWardNo", ComparisionTypes.EQUAL, zid);
            //    }
            //}
            ////comGender
            //if (comGender.SelectedItem != null)
            //{
            //    ComboItem item = (ComboItem)comGender.SelectedItem;
            //    try
            //    {
            //        int zid = Convert.ToInt32(item.Key);
            //        SearchConditionList.AddCriteria(ColumnTypes.Number, "Sex", ComparisionTypes.EQUAL, zid);
            //    }
            //    catch
            //    {
            //    }
            //}

        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
         
            if (grid.Rows.Count < 1)
            {
                return;
            }
            string ngoId = GetSelectedRowPrimaryKey();
            RenualOfRegistraion_Lst r = new RenualOfRegistraion_Lst(ngoId);
            r.ShowDialog();
        }

        private void YearlyReport_Click(object sender, EventArgs e)
        {
            if (grid.Rows.Count < 1)
            {
                return;
            }
            string ngoId = GetSelectedRowPrimaryKey();
            YearlyReport_Lst r = new YearlyReport_Lst(ngoId);
            r.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
           // string ReportName = @"ReportFiles\QuestionReport.rpt";
           //NGOReports. QuestionsReport.GetReport(ReportName);
        }

        public  void RemoveToolBar()
        {
            toolStrip1.Visible = false;
            groupBox2.Location = toolStrip1.Location;
            grid.Height = grid.Height + toolStrip1.Height;
            grid.Top = groupBox2.Bottom;
        
        }
     
        
    }
}
