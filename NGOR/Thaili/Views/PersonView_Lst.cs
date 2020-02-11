using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using Bsoft.Data;
using Bsoft.Languages;
namespace UEMS
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class PersonView_Lst : Friuts.ListingFormBase
    {
        private string _NgoId = string.Empty;
        private string _personRoleId = string.Empty;
        public PersonView_Lst()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            newToolbar.Text = Language.LanguageString.NewAdd;
            DeleteToolbar.Text = Language.LanguageString.Delete;
            //  EditToolbar.Text = Language.LanguageString.Edit;
            //<Listing>
            TableName = "PersonView";
            DataTableColumns.Add("PersonId", ColumnTypes.String, "colId", true, true);
            DataTableColumns.Add("NgoMemberId", ColumnTypes.String, "colNgoMemberId");
            DataTableColumns.Add("fk_NGO", ColumnTypes.Number, "colfk_NGO");
            DataTableColumns.Add("Name", ColumnTypes.String, "colName");
            DataTableColumns.Add("Gender", ColumnTypes.Number, "colGender");
            DataTableColumns.Add("DifferentlyAbled", ColumnTypes.String, "colDifferentlyAbled");
            DataTableColumns.Add("Specialization", ColumnTypes.String, "colSpecialization");
            DataTableColumns.Add("Position", ColumnTypes.String, "colPosition");
            DataTableColumns.Add("Education", ColumnTypes.String, "colEducation");
            DataTableColumns.Add("SocialWorkExp", ColumnTypes.String, "colSocialWorkExp");
            DataTableColumns.Add("Address", ColumnTypes.String, "colAddress");
            DataTableColumns.Add("Phone", ColumnTypes.String, "colPhone");
            DataTableColumns.Add("Email", ColumnTypes.String, "colEmail");
            ListingDataGridView = grid;
        }

        public void LoadPersonData(string NgoId, string personRoleId)
        {
            _NgoId = NgoId; _personRoleId = personRoleId;
            SearchConditionList.Clear();
            SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_Person_Role", ComparisionTypes.EQUAL, personRoleId);
            SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_NGO", ComparisionTypes.EQUAL, NgoId);
            LoadData();
        }


        private void AddPerson(object sender, EventArgs e)
        {
            IndividualPerson_Lst ipl = new IndividualPerson_Lst();
            ipl.FormType = FormTypes.SelectionForm;
            ipl.valueSelected += new ValueSelected(ipl_valueSelected);
            ipl.ShowDialog();
            //   ipl.toolStrip1.Visible = false;
            // ipl.pnlAddRemove .Visible = false;



        }

        void ipl_valueSelected(object sender, string SelectedPrimaryKey)
        {
            string iplId = SelectedPrimaryKey;
            if (iplId.Trim() != "")
            {
                NGO_Member_Ent ime = new NGO_Member_Ent();
                ime.FormType = FormTypes.EntryForm;
                ime.TableName = "NGO_Member";
                ime.txtfk_NGO.Text = _NgoId;
                ime.txtfk_Person_Role.Text = _personRoleId;
                ime.txtfk_Person.Text = iplId;
                ime.ColumnList.AddNewEditColumn("ID", ColumnTypes.Number, ime.txtID, true, false);
                ime.ColumnList.AddNewEditColumn("fk_NGO", ColumnTypes.Number, ime.txtfk_NGO);
                ime.ColumnList.AddNewEditColumn("fk_Person", ColumnTypes.Number, ime.txtfk_Person);
                ime.ColumnList.AddNewEditColumn("fk_Person_Role", ColumnTypes.Number, ime.txtfk_Person_Role);
                ime.ConfirmationRequired = false;
                ime.Save();
            }
            LoadData();
        }


        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            string NgoMemberId = GetSelectedRowValue("colNgoMemberId");
            string deleteSQL = string.Format("DELETE FROM NGO_MEMBER WHERE ID = {0}", NgoMemberId);
            GlobalResources.SelectDBConnection.ExecuteNonQuery(deleteSQL);
            LoadData();
        }
        public override bool OpenEditForm()
        {
            return true;
        }
        //private void btnOk_Click(object sender, EventArgs e)
        //{
        //    SearchConditionList.Clear();
        //    SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_Ethnicity", ComparisionTypes.EQUAL, cmbfk_Ethnicity);
        //    SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_Gender", ComparisionTypes.EQUAL, cmbfk_Gender);
        //    SearchConditionList.AddCriteria(ColumnTypes.String, "FirstName", ComparisionTypes.STARTS_WITH, txtFirstName);
        //    SearchConditionList.AddCriteria(ColumnTypes.String, "LastName", ComparisionTypes.STARTS_WITH, txtLastName);
        //}
    }
}
