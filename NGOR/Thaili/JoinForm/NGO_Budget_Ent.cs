using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using UEMS.BLL;
using Bsoft.Common.Language;
using Bsoft.Languages;
using Bsoft.AppCom;
namespace UEMS
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class NGO_Budget_Ent : Friuts.EntryFormBase
    {
        public NGO_Budget_Ent()
        {
            InitializeComponent();
            btnOk.Text = Language.LanguageString.Ok ;
            btnCancel .Text = Language.LanguageString.Cancel ;
            this.FirstControl = cmbFinancialYear ;
            this.AcceptButton = btnOk;
        }
    

        public NGO_Budget_Ent(string NGOId):this()
        {
            
            txtfk_NGO.Text = NGOId;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
            string a = InsertSQL;
        }

        private void NGO_Budget_Ent_Load(object sender, EventArgs e)
        {
            //<Entry>
            TableName = "NGO_Budget";
            if (txtFiscalYearId.Text .Trim ()=="")
            {
                txtFiscalYearId.Text = ConstantValues.CurrentFiscalYearValue;
                ComboUtilities.SelectComboBoxItemUsingCode(cmbFinancialYear, txtFiscalYearId.Text);
                //txtFiscalYearId.Text = OrganizationDetail.CurrentFiscalYear.FiscalYearID.ToString();
                //BLL.FiscalYearLoader.SetSelectedFinancialYear(cmbFinancialYear, txtFiscalYearId.Text);
            }
            
            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId, true, false);
            ColumnList.AddNewEditColumn("fk_NGO", ColumnTypes.Number, txtfk_NGO);
            ColumnList.AddNewEditColumn("FiscalYearId", ColumnTypes.Number, txtFiscalYearId);
            ColumnList.AddNewEditColumn("fk_FinancialSource", ColumnTypes.Number, cmbfk_FinancialSource);
            ComboUtilities.LoadData("Id", "Name", "FinancialSource", cmbfk_FinancialSource, true, string.Empty);
            ColumnList.AddNewEditColumn("Amount", ColumnTypes.Number, txtAmount);
            ComboUtilities.LoadData("sn", "Fiscalyear", "Fiscalyears", cmbFinancialYear, true,string .Empty );
          //  FiscalYearLoader.LoadData(cmbFinancialYear);
        }

        public override bool LoadData()
        {
            base.LoadData();
            ComboUtilities.SelectComboBoxItemUsingCode(cmbFinancialYear, txtFiscalYearId.Text);
            // ComboBoxDataLoader.LoadData("sn", "Fiscalyear", "Fiscalyears", cmbfk_FinancialYear, true);
        //    BLL.FiscalYearLoader.SetSelectedFinancialYear(cmbFinancialYear, txtFiscalYearId.Text);
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
