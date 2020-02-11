using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using Bsoft.Common.Language;
using UEMS.BLL;
using Bsoft.Common;
using Bsoft.Languages;
using Bsoft.AppCom;
namespace UEMS.MasterEntry
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmCompany : EntryFormBase
    {
        public frmCompany()
        {
            InitializeComponent();

            Text = Language.LanguageString.OrganizationDetails;
            btnSave.Text = Language.LanguageString.Ok;
            btnClose.Text = Language.LanguageString.CancelGoBack;
            lblDistrict.Text = Language.LanguageString.District + " : ";
            lblZone.Text = Language.LanguageString.Zone + " : ";
            lblLocalBody.Text = Language.LanguageString.LocalBody + " : ";
            lblPhone.Text = Language.LanguageString.Phone + " : ";
            lblWebSite.Text = Language.LanguageString.WebSite + " : ";
            lblEmail.Text = Language.LanguageString.Email + " : ";

            lblFax.Text = Language.LanguageString.Fax + " : ";
            lblfk_FinancialSource.Text = Language.LanguageString.FiscalYear + " : ";

            grpAddress.Text = Language.LanguageString.Address + " : ";
            grporgDetail.Text = Language.LanguageString.OrganizationDetails + " : ";
            lblOrgName.Text = Language.LanguageString.OrganizationName + " : ";
            btnRegistration.Text = Language.LanguageString.Register;
            btnSearch.Text = Language.LanguageString.Search;
            btnEmpty.Text = Language.LanguageString.Clear;
            btnRegistration.Text = Language.LanguageString.Register;
            cmbfk_FinancialYear.Font = DigitFont;
            lblStartDate.Text = Language.LanguageString.FiscalYear + " " + Language.LanguageString.Start + " " + Language.LanguageString.Date + " : ";
            lblEndDate.Text = Language.LanguageString.FiscalYear + " " + Language.LanguageString.End + " " + Language.LanguageString.Date + " : ";
            FirstControl = txtName;
        }

        private void frmCompany_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnSave;
            this.CancelButton = btnClose;


            txtName.Text = ConstantValues.Org_Name;
            txtPhone.Text = ConstantValues.Org_Phone;
            txtFax.Text = ConstantValues.Org_Fax;
            txtUrl.Text = ConstantValues.Org_Url;
            txtEmail.Text = ConstantValues.Org_Email;
            //txtpe.Text = ConstantValues.Org_PoBox;
            //txtTole.Text = ConstantValues.Org_Tole;
            //txtw.Text = ConstantValues.Org_WardNo;
            txtLocalBody.Text = ConstantValues.Org_LocalBody;
            txtDistrict.Text = ConstantValues.Org_District;
            txtZone.Text = ConstantValues.Org_Zone;
            //txtc.Text = ConstantValues.Org_Country;
            txtDistrictId.Text = ConstantValues.Org_DistrictId.ToString();
            txtZoneId.Text = ConstantValues.Org_ZoneId.ToString();
            txtLocalBodyId.Text = ConstantValues.Org_LocalBodyId.ToString();

            ComboUtilities.LoadData("sn", "Fiscalyear", "SuperAdmin_FISCALYEARS", cmbfk_FinancialYear, true,string .Empty );
            ComboUtilities.SelectComboBoxItemUsingValue(cmbfk_FinancialYear, ConstantValues.CurrentFiscalYearValue);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ConstantValues.Org_Name = txtName.Text;
            ConstantValues.Org_Phone = txtPhone.Text;
            ConstantValues.Org_Fax = txtFax.Text;
            ConstantValues.Org_Url = txtUrl.Text;
            ConstantValues.Org_Email = txtEmail.Text;
            //ConstantValues.Org_PoBox=           //txtpe.Text ;
            // ConstantValues.Org_Tole = txtTole.Text;
            //ConstantValues.Org_WardNo=           //txtw.Text ;
            ConstantValues.Org_LocalBody = txtLocalBody.Text;
            ConstantValues.Org_District = txtDistrict.Text;
            ConstantValues.Org_Zone = txtZone.Text;
            //ConstantValues.Org_Country=           //txtc.Text ;
            ConstantValues.Org_DistrictId = txtDistrictId.Text.ToInt();
            ConstantValues.Org_ZoneId = txtZoneId.Text.ToInt();
            ConstantValues.Org_LocalBodyId = txtLocalBodyId.Text.ToInt();

            ConstantValues.CurrentFiscalYearValue  = cmbfk_FinancialYear.Text;

            //FiscalYear ci = (FiscalYear)cmbfk_FinancialYear.SelectedItem;
            //ConstantValues.CurrentFiscalYearValue = ci.CurrentFiscalYearValue.ToString();
            //Friuts.OrganizationDetail.CurrentFiscalYear.CurrentFiscalYearValue = ci.CurrentFiscalYearValue;
            DialogResult = DialogResult.OK;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Address.selectAddress.SelectionOfAddressFromTree(txtZoneId, txtDistrictId, txtLocalBodyId, txtZone, txtDistrict, txtLocalBody, null, null, null);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Address.selectAddress.ClearAddress(txtZoneId, txtDistrictId, txtLocalBodyId, txtZone, txtDistrict, txtLocalBody, null, null, null);
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            ConstantValues.Org_Name = txtName.Text;
            Bsoft.AppCom.frmRegister frmReg = new Bsoft.AppCom.frmRegister();
            frmReg.IsMachine = false;
            frmReg.ShowDialog(this);
        }

     
    }
}
