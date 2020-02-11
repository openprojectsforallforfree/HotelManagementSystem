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
using Bsoft.AppCom;
namespace UEMS
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class YearlyReport_Ent : Friuts.EntryFormBase
    {

        WorkDone_Lst workDoneLst;
        public YearlyReport_Ent()
        {
            InitializeComponent();
            this.FirstControl = btnOk;
            LoadOtherControls();
            //<Entry>
            TableName = "YearlyReport";
            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId, true, false);
            ColumnList.AddNewEditColumn("fk_NGO", ColumnTypes.Number, txtfk_NGO);
            ColumnList.AddNewEditColumn("FiscalYearId", ColumnTypes.Number, cmbFiscalYearId);
            ComboUtilities.LoadData("sn", "FiscalYear", "FiscalYears", cmbFiscalYearId, true,string .Empty );
            ComboUtilities.SelectComboBoxItemUsingValue(cmbFiscalYearId, ConstantValues.CurrentFiscalYearValue);
            ColumnList.AddNewEditColumn("AuthorisedAmount", ColumnTypes.Number, txtAuthorisedAmount);
            ColumnList.AddNewEditColumn("RecievedAmount", ColumnTypes.Number, txtRecievedAmount);
            ColumnList.AddNewEditColumn("SpentAmount", ColumnTypes.Number, txtSpentAmount);
            ColumnList.AddNewEditColumn("SignedBy", ColumnTypes.Number, txtSignedBy);
            ColumnList.AddNewEditColumn("D_Date", ColumnTypes.String, txtD_Date);
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
        public void LoadOtherControls()
        {
            //worki done
           // grpWorkDone.Visible =false ;
            workDoneLst = new WorkDone_Lst();
            workDoneLst.panel2.Parent = grpWorkDone;
            workDoneLst.ConfirmationRequired = false;
        }
        string _Ngoid;
        public YearlyReport_Ent(string NGOId):this()
        {
            _Ngoid = NGOId;
            txtfk_NGO.Text  = _Ngoid;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (FormType == FormTypes.EditForm)
            {
                Save();
            }
            else if (FormType == FormTypes.EntryForm)
            {
                Save(false  );
                txtId.Text = getLatestIdFromSQL("Id").ToString();
                PrimaryKeyValue = getLatestIdFromSQL("Id");
                //grpWorkDone.Visible = true;
                FormType = FormTypes.EditForm;
                LoadData();
                Bsoft.Utility.FormUtility.adjustHt(this, flowLayoutPanel1, grpWorkDone, true);
            }
        }


        public override bool LoadData()
        {
            base.LoadData();
            if (FormType == FormTypes.EditForm)
            {
              //  grpWorkDone.Visible = true;
                workDoneLst.LoadData(txtId.Text);
            }
            return true;
        }
        private void YearlyReport_Ent_Load(object sender, EventArgs e)
        {



        }




        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void YearlyReport_Ent_Shown(object sender, EventArgs e)
        {
             if (FormType == FormTypes.EditForm)
            {
                Bsoft.Utility.FormUtility.adjustHt(this, flowLayoutPanel1, grpWorkDone , true );
            }
            else
            {
                Bsoft.Utility.FormUtility.adjustHt(this, flowLayoutPanel1, grpWorkDone, false);
            }
        }
    }
}
