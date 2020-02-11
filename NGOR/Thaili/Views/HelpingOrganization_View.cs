using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using Bsoft.Data;
namespace UEMS 
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class HelpingOrganization_View: Friuts.ListingFormBase
    {
        public HelpingOrganization_View()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
           // toolstrip = toolStrip1;
            TableName = "HelpingOrganization";
            DataTableColumns.Add("Id", ColumnTypes.Integer, "colId", true, true);
            DataTableColumns.Add("Name", ColumnTypes.String, "colName");
            DataTableColumns.Add("TypeLocal", ColumnTypes.String, "colTypeLocal");
            DataTableColumns.Add("Address", ColumnTypes.String, "colAddress");
            DataTableColumns.Add("Objective", ColumnTypes.String, "colObjective");

  
        }
         string _NGOId = string.Empty;
         public HelpingOrganization_View(string NGOId)
             : this()
        {
            _NGOId = NGOId;
        }

         public bool LoadData(string NgoId)
         {
             _NGOId = NgoId;
             SearchConditionList.Clear();
             SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_NGO", ComparisionTypes.EQUAL, NgoId);
             return base.LoadData();
         }
        private void newToolbar_Click(object sender, EventArgs e)
        {
            OpenNewForm();
        }

        private void EditToolbar_Click(object sender, EventArgs e)
        {
            HelpingOrganization_Lst ipl = new HelpingOrganization_Lst();
            ipl.FormType = FormTypes.SelectionForm;
            //   ipl.toolStrip1.Visible = false;
            //ipl.pnlAddRemove.Visible = false;
            if (ipl.ShowDialog() == DialogResult.OK)
            {
                string iplId = ipl.GetSelectedRowPrimaryKey();
                if (iplId.Trim() != "")
                {
                    NGO_HelpingOrganization_Ent ime = new NGO_HelpingOrganization_Ent();
                    ime.FormType = FormTypes.EntryForm;
                    ime.TableName = "NGO_Objective";
                    ime.txtfk_NGO.Text = _NGOId;
                    ime.txtFkHelpingOrg .Text = iplId;
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
        }
        public override bool OpenEditForm()
        {
            return base.OpenEditForm(new HelpingOrganization_Ent (TableName));
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new HelpingOrganization_Ent(TableName));
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            string id = GetSelectedRowPrimaryKey();

            string sql = string.Format("DELETE FROM {0} where id ={1}", "HelpingOrganization", id);
            GlobalResources.SelectDBConnection.ExecuteNonQuery(sql);
            LoadData();
        }

        
    }
}
