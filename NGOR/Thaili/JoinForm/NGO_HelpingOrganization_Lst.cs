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
    public partial class NGO_HelpingOrganization_Lst : Friuts.ListingFormBase
    {
        private string _NgoId = string.Empty;
        public NGO_HelpingOrganization_Lst()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            // toolstrip = toolStrip1;
            TableName = "NGO_HelpingOrganization";
            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("fk_NGO", ColumnTypes.Number, "colfk_NGO");
            //DataTableColumns.Add("fk_HelpingOrganization", ColumnTypes.Number, "colfk_HelpingOrganization");
            RelationList.Add("fk_HelpingOrganization", "HelpingOrganization", "Id", "Name", "colfk_HelpingOrganization", TableJoinTypes.LEFT_JOIN);

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
        public NGO_HelpingOrganization_Lst(string NgoId)
            : this()
        {
            _NgoId = NgoId;
        }
        public bool LoadData(string NgoId)
        {
            _NgoId = NgoId;
           return   LoadData();
        }
        public override bool LoadData()
        {
            SearchConditionList.Clear();
            SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_NGO", ComparisionTypes.EQUAL, _NgoId);
            return base.LoadData();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newToolbar_Click(object sender, EventArgs e)
        {
            HelpingOrganization_Lst ipl = new HelpingOrganization_Lst();
            ipl.FormType = FormTypes.SelectionForm;
            ipl.valueSelected += new ValueSelected(ipl_valueSelected);
            ipl.ShowDialog();
            
        }

        void ipl_valueSelected(object sender, string SelectedPrimaryKey)
        {

            string iplId = SelectedPrimaryKey;
                if (iplId.Trim() != "")
                {
                    NGO_HelpingOrganization_Ent ime = new NGO_HelpingOrganization_Ent();
                    ime.FormType = FormTypes.EntryForm;
                    ime.TableName = "NGO_HelpingOrganization";
                    ime.txtfk_NGO.Text = _NgoId;
                    ime.txtFkHelpingOrg.Text = iplId;
                    //  TableName = "NGO_Objective";
                    //ime.ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, ime.txtId, true, false);
                    //ime.ColumnList.AddNewEditColumn("fk_NGO", ColumnTypes.Number, ime.txtfk_NGO);
                    //ime.ColumnList.AddNewEditColumn("fk_Objective", ColumnTypes.Number, ime.txtfk_Objective);
                    string s = ime.InsertSQL;
                    ime.ConfirmationRequired = false;
                    ime.Save();
                }
                LoadData();
                string p = SelectSQL;
            
        }

        public override bool OpenEditForm()
        {
            return false;
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            string id = GetSelectedRowPrimaryKey();
            string sql = string.Format("DELETE FROM {0} where id ={1} AND fk_NGO = {2}", TableName, id,_NgoId );
            GlobalResources.SelectDBConnection.ExecuteNonQuery(sql);
            LoadData();
        }


    }
}
