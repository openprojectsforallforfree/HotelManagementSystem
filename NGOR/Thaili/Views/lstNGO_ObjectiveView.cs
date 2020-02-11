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
    public partial class lstNGO_ObjectiveView : Friuts.ListingFormBase
    {
        private string _NgoId = string.Empty;

        public lstNGO_ObjectiveView()
        {
            InitializeComponent();
            this.valueSelected += new ValueSelected(lstNGO_ObjectiveView_valueSelected);
            newToolbar.Text = Language.LanguageString.NewAdd;
            DeleteToolbar.Text = Language.LanguageString.Delete;
            EditToolbar.Text = Language.LanguageString.Edit;
            TableName = "NGO_ObjectiveView";
            DataTableColumns.Add("Id", ColumnTypes.Number, "colNGO_Objective_Id", true, true);
            DataTableColumns.Add("fk_NGO", ColumnTypes.Number, "colNGO_Objective_fk_NGO");
            DataTableColumns.Add("fk_Objective", ColumnTypes.Number, "colNGO_Objective_fk_Objective");
            DataTableColumns.Add("Objective_Title", ColumnTypes.String, "colObjective_Title");
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            // toolstrip = toolStrip1;

        }

        void lstNGO_ObjectiveView_valueSelected(object sender, string SelectedPrimaryKey)
        {
            string iplId = SelectedPrimaryKey;
            if (iplId.Trim() != "")
            {
                NGO_Objective_Ent ime = new NGO_Objective_Ent();
                ime.FormType = FormTypes.EntryForm;
                ime.TableName = "NGO_Objective";
                ime.txtfk_NGO.Text = _NgoId;
                ime.txtfk_Objective.Text = iplId;
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

        public bool LoadData(string NgoId)
        {
            _NgoId = NgoId;
            SearchConditionList.Clear();
            SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_NGO", ComparisionTypes.EQUAL, NgoId);
            return base.LoadData();
        }

        private void List_Load(object sender, EventArgs e)
        {
            //<Listing>


        }

        public override bool OpenEditForm()
        {
            return false;
        }


        private void btnEdits_Click(object sender, EventArgs e)
        {
            Master_Lst Ml = new Master_Lst("Objective");
            Ml.ShowDialog();
        }

        private void newToolbar_Click(object sender, EventArgs e)
        {
            try
            {
                Master_Lst ipl = new Master_Lst("Objective");
                ipl.FormType = FormTypes.SelectionForm;
                ipl.valueSelected += new ValueSelected(lstNGO_ObjectiveView_valueSelected);
                ipl.ShowDialog();
                //   ipl.toolStrip1.Visible = false;
                //ipl.pnlAddRemove.Visible = false;
                //if (ipl.ShowDialog() == DialogResult.OK)
                //{
                //    string iplId = ipl.GetSelectedRowPrimaryKey();
                //    if (iplId.Trim() != "")
                //    {
                //        NGO_Objective_Ent ime = new NGO_Objective_Ent();
                //        ime.FormType = FormTypes.EntryForm;
                //        ime.TableName = "NGO_Objective";
                //        ime.txtfk_NGO.Text = _NgoId;
                //        ime.txtfk_Objective.Text = iplId;
                //        //  TableName = "NGO_Objective";
                //        //ime.ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, ime.txtId, true, false);
                //        //ime.ColumnList.AddNewEditColumn("fk_NGO", ColumnTypes.Number, ime.txtfk_NGO);
                //        //ime.ColumnList.AddNewEditColumn("fk_Objective", ColumnTypes.Number, ime.txtfk_Objective);
                //        string s = ime.InsertSQL;
                //        ime.ConfirmationRequired = false;
                //        ime.Save();
                //    }
                //    LoadData();
                //    string p = SelectSQL;
                //}
            }
            catch
            {
                throw;
            }
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            string id = GetSelectedRowPrimaryKey();

            string sql = string.Format("DELETE FROM NGO_Objective where id ={0}", id);
            GlobalResources.SelectDBConnection.ExecuteNonQuery(sql);
            LoadData();
        }
    }
}