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
    public partial class Tasks_Ent : Friuts.EntryFormBase
    {
        public Tasks_Ent()
        {
            InitializeComponent();

            ChangeLanguage();
        }
        public void ChangeLanguage()
        {
            btnCancel.Text = Language.LanguageString.Cancel;
            btnOk.Text = Language.LanguageString.Ok;
            //newToolbar.Text = Language. LanguageString.NewAdd;
            //EditToolbar.Text = Language. LanguageString.Edit;
            //DeleteToolbar.Text = Language. LanguageString.Delete;
            //ExportToolbar.Text = Language. LanguageString.ExporttoExcel;
        }
        string WorkDoneId;
        public Tasks_Ent(string _WorkDoneId)
            : this()
        {
            WorkDoneId = _WorkDoneId;
            txtfk_WorkDone.Text = _WorkDoneId;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Tasks_Ent_Load(object sender, EventArgs e)
        {
            //<Entry>
            TableName = "Tasks";
            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId, true, false);
            ColumnList.AddNewEditColumn("fk_WorkDone", ColumnTypes.Number, txtfk_WorkDone);
            ColumnList.AddNewEditColumn("Title", ColumnTypes.String, txtTitle);
            ColumnList.AddNewEditColumn("ExpensedBudget", ColumnTypes.Number, txtExpensedBudget);
            ColumnList.AddNewEditColumn("Male_Adv", ColumnTypes.Number, txtMale_Adv);
            ColumnList.AddNewEditColumn("Female_Adv", ColumnTypes.Number, txtFemale_Adv);
            ColumnList.AddNewEditColumn("TG_Adv", ColumnTypes.Number, txtTG_Adv);
            ColumnList.AddNewEditColumn("Dalit_Adv", ColumnTypes.Number, txtDalit_Adv);
            ColumnList.AddNewEditColumn("Janjati_Adv", ColumnTypes.Number, txtJanjati_Adv);
            ColumnList.AddNewEditColumn("Other_Adv", ColumnTypes.Number, txtOther_Adv);


        }
        public override bool LoadData()
        {
            base.LoadData();
            string asda = SelectSQL;
            return true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
