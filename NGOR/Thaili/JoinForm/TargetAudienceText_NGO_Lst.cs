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
    public partial class TargetAudienceText_NGO_Lst : Friuts.ListingFormBase
    {
        public TargetAudienceText_NGO_Lst()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            //<Listing>
            TableName = "TargetAudienceText_NGO";
            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("fk_NGO", ColumnTypes.Number, "colNGO_ID");
            //DataTableColumns.Add("fk_TargetAudience", ColumnTypes.Number, "colfk_TargetAudience");
            RelationList.Add("fk_TargetAudience", "TargetAudience", "id", "Title", "colfk_TargetAudience", TableJoinTypes.LEFT_JOIN);
            LoadData();
            string b = SelectSQL;

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
        public TargetAudienceText_NGO_Lst(string NGOId)
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
   

        private void newToolbar_Click(object sender, EventArgs e)
        {
            Master_Lst ipl = new Master_Lst("TargetAudience");
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
                TargetAudienceText_NGO_Ent ime = new TargetAudienceText_NGO_Ent(_NGOId);
                ime.FormType = FormTypes.EntryForm;

                ime.txtNGO_ID.Text = _NGOId;
                ime.txtfk_TargetAudience.Text = iplId;
                //ime.txtfk_Person.Text = iplId;

                ime.TableName = "TargetAudienceText_NGO";
                ime.ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, ime.txtId, true, false);
                ime.ColumnList.AddNewEditColumn("fk_NGO", ColumnTypes.Number, ime.txtNGO_ID);
                ime.ColumnList.AddNewEditColumn("fk_TargetAudience", ColumnTypes.Number, ime.txtfk_TargetAudience);

                //ime.ColumnList.AddNewEditColumn("ID", ColumnTypes.Number, ime.txtID, true, false);
                //ime.ColumnList.AddNewEditColumn("fk_NGO", ColumnTypes.Number, ime.txtfk_NGO);
                //ime.ColumnList.AddNewEditColumn("fk_Person", ColumnTypes.Number, ime.txtfk_Person);
                //ime.ColumnList.AddNewEditColumn("fk_Person_Role", ColumnTypes.Number, ime.txtfk_Person_Role);
                ime.ConfirmationRequired = false;
                ime.Save();
                string s = ime.InsertSQL;
            }
            LoadData();
        }

     
        public override bool OpenEditForm()
        {
            return true;
        }

        public override bool OpenNewForm()
        {
            return true;
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            string NgoSwId = GetSelectedRowValue("colId");
            string deleteSQL = string.Format("DELETE FROM TargetAudienceText_NGO WHERE ID = {0} AND fk_NGO = {1}", NgoSwId,_NGOId );
            int status = GlobalResources.SelectDBConnection.ExecuteNonQuery(deleteSQL);
            LoadData();
        }

         
    }
}
