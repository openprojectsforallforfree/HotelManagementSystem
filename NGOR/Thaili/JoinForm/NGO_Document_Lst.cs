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
    public partial class NGO_Document_Lst: Friuts.ListingFormBase
    {
        public NGO_Document_Lst()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
           // toolstrip = toolStrip1;
            //<Listing>
            TableName = "NGO_Document";
            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("fk_RenualOfRegistraion", ColumnTypes.Number, "colfk_RenualOfRegistraion");
            //DataTableColumns.Add("fk_Document", ColumnTypes.Number, "colfk_Document");
            RelationList.Add("fk_Document", "Document", "id", "Title", "colfk_Document", TableJoinTypes.LEFT_JOIN);
            LoadData();
            ChangeLanguage();
        }
        public void ChangeLanguage()
        {
            //btnCancel.Text = Language.Cancel;
            //btnOk.Text = Language.Ok;
            newToolbar.Text = Language.LanguageString.NewAdd;
           // EditToolbar.Text = Language. LanguageString.Edit;
            DeleteToolbar.Text = Language.LanguageString.Delete;
            // ExportToolbar.Text = Language. LanguageString.ExporttoExcel;
        }

        public NGO_Document_Lst(string RenewId)
            : this()
        {
            _RenewId = RenewId;
        }
        string _RenewId = string.Empty;
        public override bool LoadData()
        {
            SearchConditionList.Clear();
            SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_RenualOfRegistraion", ComparisionTypes.EQUAL, _RenewId);
            return base.LoadData();
            string s = SelectSQL;
        }
        public bool LoadData(string RenewId)
        {
            _RenewId = RenewId;
            return LoadData();
        }

         
       

        private void newToolbar_Click(object sender, EventArgs e)
        {
            Master_Lst ipl = new Master_Lst("Document");
            ipl.FormType = FormTypes.SelectionForm;
            ipl.valueSelected += new ValueSelected(ipl_valueSelected);    
            ipl.ShowDialog();
         
        }

        void ipl_valueSelected(object sender, string SelectedPrimaryKey)
        {
            string DocId = SelectedPrimaryKey;
            if (DocId.Trim() != "")
            {
                NGO_Document_Ent ime = new NGO_Document_Ent();
                ime.FormType = FormTypes.EntryForm;
                ime.txtfk_RenualOfRegistraion.Text = _RenewId;
                ime.txtfk_Document.Text = DocId;
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
            string deleteSQL = string.Format("DELETE FROM {0} WHERE ID = {1} AND fk_RenualOfRegistraion = {2}", TableName, NgoSwId, _RenewId);
            int status = GlobalResources.SelectDBConnection.ExecuteNonQuery(deleteSQL);
            LoadData();
        }

        
    }
}
