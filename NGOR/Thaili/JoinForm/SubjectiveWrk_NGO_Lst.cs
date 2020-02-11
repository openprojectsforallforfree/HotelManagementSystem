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
namespace UEMS
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class SubjectiveWrk_NGO_Lst : Friuts.ListingFormBase
    {
        public SubjectiveWrk_NGO_Lst()
        {
            InitializeComponent();
                       newToolbar.Text = Language.LanguageString.NewAdd;
            DeleteToolbar.Text = Language.LanguageString.Delete;
           // EditToolbar.Text = Language.LanguageString.Edit;
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            //<Listing>
            TableName = "SubjectiveWrk_NGO";
            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("fk_NGO", ColumnTypes.Number, "colNGO_ID");
            //     DataTableColumns.Add("fk_SubjectiveWrk", ColumnTypes.Number, "colfk_SubjectiveWrk");
            RelationList.Add("fk_SubjectiveWrk", "SubjectiveWrk", "id", "Title", "colSubjectiveWrk", TableJoinTypes.LEFT_JOIN);
            LoadData();

            ChangeLanguage();
        }
        public void ChangeLanguage()
        {
            //btnCancel.Text = Language.Cancel;
            //btnOk.Text = Language.Ok;
            newToolbar.Text = Language. LanguageString.NewAdd;
            //EditToolbar.Text = Language. LanguageString.Edit;
            DeleteToolbar.Text = Language. LanguageString.Delete;
            // ExportToolbar.Text = Language. LanguageString.ExporttoExcel;
        }
        string _NGOId = string.Empty;
        public SubjectiveWrk_NGO_Lst(string NGOId)
            : this()
        {
            _NGOId = NGOId;
        }
        public override bool LoadData()
        {
            SearchConditionList.Clear();
            SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_NGO", ComparisionTypes.EQUAL, _NGOId);
            return base.LoadData();
           
        }
        public bool LoadData(string NgoId)
        {
            _NGOId = NgoId;
            return LoadData();
        }
      

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newToolbar_Click(object sender, EventArgs e)
        {
            Master_Lst ipl = new Master_Lst("SubjectiveWrk");
            ipl.FormType = FormTypes.SelectionForm;
            ipl.valueSelected += new ValueSelected(ipl_valueSelected);
//            ipl.pnlAddRemove.Visible = false;
            ipl.ShowDialog();
            
            
        }

        void ipl_valueSelected(object sender, string SelectedPrimaryKey)
        {

            string iplId = SelectedPrimaryKey;
                if (iplId.Trim() != "")
                {
                    SubjectiveWrk_NGO_Ent ime = new SubjectiveWrk_NGO_Ent(_NGOId );
                    ime.FormType = FormTypes.EntryForm;

                    ime.txtNGO_ID.Text  = _NGOId;
                    ime.txtfk_SubjectiveWrk .Text = iplId;
                    //ime.txtfk_Person.Text = iplId;

                    ime.TableName = "SubjectiveWrk_NGO";
                    ime.ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, ime.txtId, true, false);
                    ime.ColumnList.AddNewEditColumn("fk_NGO", ColumnTypes.Number, ime.txtNGO_ID);
                    ime.ColumnList.AddNewEditColumn("fk_SubjectiveWrk", ColumnTypes.Number, ime.txtfk_SubjectiveWrk);

                    //ime.ColumnList.AddNewEditColumn("ID", ColumnTypes.Number, ime.txtID, true, false);
                    //ime.ColumnList.AddNewEditColumn("fk_NGO", ColumnTypes.Number, ime.txtfk_NGO);
                    //ime.ColumnList.AddNewEditColumn("fk_Person", ColumnTypes.Number, ime.txtfk_Person);
                    //ime.ColumnList.AddNewEditColumn("fk_Person_Role", ColumnTypes.Number, ime.txtfk_Person_Role);
                    ime.ConfirmationRequired = false;
                    ime.Save();
                 
                }
                LoadData();
        }

        private void EditToolbar_Click(object sender, EventArgs e)
        {
            OpenEditForm();
        }
        public override bool OpenEditForm()
        {
            return true;
         //   return base.OpenEditForm(new SubjectiveWrk_NGO_Ent(_NGOId));
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new SubjectiveWrk_NGO_Ent(_NGOId));
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            string NgoSwId = GetSelectedRowValue("colId");
            string deleteSQL = string.Format("DELETE FROM SubjectiveWrk_NGO WHERE fk_NGO = {1} AND ID = {0}", NgoSwId,_NGOId );

            int status = GlobalResources.SelectDBConnection.ExecuteNonQuery(deleteSQL);
            LoadData();
        }

        private void ExitToolbar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExportToolbar_Click(object sender, EventArgs e)
        {
            Reports.ExcelReport excel = new Reports.ExcelReport(this.Text, 4, grid);
        }
    }
}
