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
    public partial class WorkDone_Ent : Friuts.EntryFormBase
    {
        Address_Ent AddressEntry;
        Tasks_Lst tasks_Lst;
        public WorkDone_Ent()
        {
            InitializeComponent();
            dtTaskDate.Value = CrudeFx.NepaliDate.NepaliDate.Today;
            AddressEntry = new Address_Ent();
            AddressEntry.pnlCountry.Visible = false;
            AddressEntry.flowLayoutPanel1.Parent = grpfk_Address;
           
            //Helping Org
            tasks_Lst = new Tasks_Lst();
            tasks_Lst.panel2 .Parent = grpTasks ;
            tasks_Lst.ConfirmationRequired = false;
            //grpTasks.Visible = false;
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
        public WorkDone_Ent(string YearlyReportId):this()
        {
            txtfk_YearlyReport.Text = YearlyReportId;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            AddressEntry.FormType = this.FormType;
            AddressEntry.ConfirmationRequired = false;
            if (FormType == FormTypes.EditForm)
            {
                Save();
                AddressEntry.Save(false);
            }
            if (FormType == FormTypes.EntryForm)
            {
                //saves blank row in address table and gets id
                if (AddressEntry.Save(false))
                {
                    txtfk_Address.Text = AddressEntry.getLatestIdFromSQL("ID").ToString();
                    AddressEntry.PrimaryKeyValue = txtfk_Address.Text;
                    AddressEntry.txtId.Text = txtfk_Address.Text;
                }

               
                Save(false);

                txtId.Text = getLatestIdFromSQL("Id").ToString();
                //grpTasks.Visible = true;
                PrimaryKeyValue = getLatestIdFromSQL("Id");
                FormType = FormTypes.EditForm;
           
                LoadData();
            }
        }
        public override bool LoadData()
        {
            base.LoadData();
            if (FormType == FormTypes.EditForm)
            {
                tasks_Lst .LoadData(txtId.Text);
                AddressEntry.PrimaryKeyValue = txtfk_Address.Text;
                AddressEntry.FormType = FormTypes.EditForm;
                AddressEntry.LoadData();

                showObjective(txtfk_OBJECTIVE .Text );
                //grpTasks .Visible = true;
                tasks_Lst .LoadData(txtId.Text);
                Bsoft.Utility.FormUtility.adjustHt(this, flowLayoutPanel1, grpTasks, true);
            }
            return true;
        }
        private void WorkDone_Ent_Load(object sender, EventArgs e)
        {
            //<Entry>
            TableName = "WorkDone";
            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId, true, false);
            ColumnList.AddNewEditColumn("fk_OBJECTIVE", ColumnTypes.String, txtfk_OBJECTIVE);
            ColumnList.AddNewEditColumn("fk_YearlyReport", ColumnTypes.Number, txtfk_YearlyReport);
            ColumnList.AddNewEditColumn("fk_Address", ColumnTypes.Number, txtfk_Address);
            ColumnList.AddNewEditColumn("TaskDate", ColumnTypes.String, dtTaskDate);
            ColumnList.AddNewEditColumn("Remarks", ColumnTypes.String, txtRemarks);
            //ColumnList.AddNewEditColumn("RFU",ColumnTypes.String, txtRFU );
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WorkDone_Ent_Shown(object sender, EventArgs e)
        {
            if (FormType == FormTypes.EditForm)
            {
                Bsoft.Utility.FormUtility.adjustHt(this, flowLayoutPanel1, grpTasks , true);
            }
            else
            {
                Bsoft.Utility.FormUtility.adjustHt(this, flowLayoutPanel1, grpTasks, false);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            UEMS.Master_Lst frm = new Master_Lst ();
            frm.TableName = "Objective";
            frm.FormType = FormTypes.SelectionForm;
            // frm.toolStrip1.Enabled = false;
            frm.valueSelected += new ListingFormBase.ValueSelected(frm_valueSelected);
            frm.ShowDialog(this);
        }
        private void showObjective(string SelectedPrimaryKey)
        {
            try
            {
                if (SelectedPrimaryKey != "")
                {
                    string s = string.Format("select Objective_Title from NGO_ObjectiveView where fk_Objective = '{0}'", SelectedPrimaryKey);
                    string so = string.Format("select fk_Objective from NGO_ObjectiveView where fk_Objective = '{0}'", SelectedPrimaryKey);
                    txtfk_OBJECTIVE.Text = GlobalResources.SelectDBConnection.ExecuteScalar(so).ToString();
                    lblWorkDoneTitle.Text = GlobalResources.SelectDBConnection.ExecuteScalar(s).ToString();

                }
            }
            catch
            {
            }
        }
        void frm_valueSelected(object sender, string SelectedPrimaryKey)
        {
            showObjective(SelectedPrimaryKey);
        }
    }
}
