using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using Bsoft.Common.Language;
using Bsoft.Data;
namespace UEMS
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class NGO_Member_Lst : Friuts.ListingFormBase
    {
        private string _NgoId = string.Empty;
        private string _personRoleId = string.Empty;
        private DataTable SelecteLIst = new DataTable();
        public NGO_Member_Lst()
        {
            InitializeComponent();
            FormType = FormTypes.Others;
            ListingDataGridView = grid;

            ChangeLanguage();
        }
        public void ChangeLanguage()
        {
            //btnCancel.Text = Language.Cancel;
            //btnOk.Text = Language.Ok;
            //newToolbar.Text = Language. LanguageString.NewAdd;
           // EditToolbar.Text = Language. LanguageString.Edit;
            //DeleteToolbar.Text = Language. LanguageString.Delete;
            // ExportToolbar.Text = Language. LanguageString.ExporttoExcel;
        }

        public NGO_Member_Lst(string NgoId, string personRoleId)
            : this()
        {
            _NgoId = NgoId; _personRoleId = personRoleId;
        }
        public override bool LoadData()
        {
            SearchConditionList.Clear();
            SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_NGO", ComparisionTypes.EQUAL, _NgoId);
            return base.LoadData();
        }
        public bool LoadData(string NgoId)
        {
            _NgoId = NgoId;
            return LoadData();
        }
        private void List_Load(object sender, EventArgs e)
        {

            //<Listing>
            TableName = "PersonView";
            DataTableColumns.Add("Id", ColumnTypes.String, "colId", true, true);
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
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string Person_MemberId = GetSelectedRowPrimaryKey();
            if (Person_MemberId != "")
            {
                string deleteSQL = string.Format("DELETE FROM {0} WHERE ID ={1} AND = {2})", TableName, Person_MemberId,"");
                GlobalResources.SelectDBConnection.ExecuteNonQuery(deleteSQL);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            IndividualPerson_Lst frm = new IndividualPerson_Lst();
            frm.FormType = FormTypes.SelectionForm;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                string PersonId = frm.GetSelectedRowPrimaryKey();
                if (PersonId != "")
                {
                    string insertSQL = string.Format("INSERT INTO {0} (fk_NGO,fk_Person_Role,fk_Person) VALUES ({1},{2},{3})", "ngo_member", _NgoId, _personRoleId, PersonId);
                    GlobalResources.SelectDBConnection.ExecuteNonQuery(insertSQL);
                    //selecteddt.Rows.Add(_NgoId ,PersonId,_personRoleId );
                }
                LoadData();
            }
        }
    }
}
