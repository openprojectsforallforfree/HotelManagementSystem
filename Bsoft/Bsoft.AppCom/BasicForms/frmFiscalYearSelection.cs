using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Friuts;
using UEMS.BLL;
using Bsoft.Data;
using Bsoft.AppCom;

namespace UEMS.BasicForms
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmSuperAdmin_FISCALYEARSelection : Friuts.EntryFormBase
    {
        public frmSuperAdmin_FISCALYEARSelection()
        {
            InitializeComponent();
        }

        private void frmSuperAdmin_FISCALYEARSelection_Load(object sender, EventArgs e)
        {
            ComboUtilities.LoadData("sn", "FiscalYear", "SuperAdmin_FISCALYEARS", cmbfk_FinancialYear, true,string .Empty );
            ComboUtilities.SelectComboBoxItemUsingCode(cmbfk_FinancialYear, "1");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //   string a =o.CurrentFiscalYear.FiscalYearID .ToString ();
            //FiscalYear ci = (FiscalYear)cmbfk_FinancialYear.SelectedItem;
            //string s = ci.FiscalYearID.ToString();
            //ConstantValuesUtility.SetData("CurrentFiscalYearId", s);
            //Friuts.OrganizationDetail.CurrentFiscalYear.FiscalYearID = ci.FiscalYearID;
            ComboItem ci = (ComboItem)cmbfk_FinancialYear.SelectedItem;
            ConstantValues.CurrentFiscalYearValue = ci.Value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbfk_FinancialYear_SelectedIndexChanged(object sender, EventArgs e)
        {

            List <string > fisc = (from DataRow a in SuperAdmin_FISCALYEARS.Rows
                       where a["FiscalYear"].ToString ()== cmbfk_FinancialYear .SelectedText 
                       select a["DateFrom"].ToString()).ToList ();

            //FiscalYear fy = FiscalYearLoader.GetSelectedFiscalYear(cmbfk_FinancialYear);
            List<string> fiscend = (from DataRow a in SuperAdmin_FISCALYEARS.Rows
                                 where a["FiscalYear"].ToString() == cmbfk_FinancialYear.SelectedText
                                    select a["DateTo"].ToString()).ToList();
            lblFISCALYEARStart.Text = fisc[0];
            lblFiscalYearEnd.Text = fiscend[0];
        }

        public static DataTable _FISCALYEARS = null;

        public static DataTable SuperAdmin_FISCALYEARS
        {
            get
            {
                if (_FISCALYEARS == null)
                {
                    StringBuilder sql = new StringBuilder();
                    //sql.Append("SELECT");
                    //sql.Append("\n\tSN, ");
                    //sql.Append("\n\tDateFrom, ");
                    //sql.Append("\n\tDateTo ");
                    //sql.Append("\nFROM ");
                    //sql.Append("\n\tSuperAdmin_FISCALYEARS order by sn desc");
                    sql.Append("SELECT * FROM SuperAdmin_FISCALYEARS order by sn desc"); 
                    _FISCALYEARS = GlobalResources.SelectDBConnection.ExecuteDataTable(sql);
                }
                return _FISCALYEARS;
            }
        }

    }
}
