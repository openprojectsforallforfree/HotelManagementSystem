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
    public partial class NGO_Budget_Lst : Friuts.ListingFormBase
    {
        public NGO_Budget_Lst()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            //<Listing>
            TableName = "NGO_Budget";
            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("fk_NGO", ColumnTypes.Number, "colfk_NGO");
            //DataTableColumns.Add("FiscalYearId", ColumnTypes.Number, "colFiscalYearId");
            RelationList.Add("FiscalYearId", "FISCALYEARS", "sn", "FISCALYEAR", "colFiscalYearId", TableJoinTypes.LEFT_JOIN);
            //DataTableColumns.Add("fk_FinancialSource", ColumnTypes.Number, "colfk_FinancialSource");
            RelationList.Add("fk_FinancialSource", "FinancialSource", "Id", "Name", "colfk_FinancialSource", TableJoinTypes.LEFT_JOIN);
            DataTableColumns.Add("Amount", ColumnTypes.AmountRound2, "colAmount");
            ChangeLanguage();
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
        string _NgoId = string.Empty;
     

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
           
        }

        private void newToolbar_Click(object sender, EventArgs e)
        {
            OpenNewForm();
            LoadData();
            //Master_Lst ipl = new Master_Lst("Objective");
            //ipl.FormType = FormTypes.SelectionForm;
            ////   ipl.toolStrip1.Visible = false;
            ////ipl.pnlAddRemove.Visible = false;
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

        private void EditToolbar_Click(object sender, EventArgs e)
        {
            OpenEditForm();
        }
        public override bool OpenEditForm()
        {
            return base.OpenEditForm(new NGO_Budget_Ent(_NgoId));
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new NGO_Budget_Ent(_NgoId));
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
