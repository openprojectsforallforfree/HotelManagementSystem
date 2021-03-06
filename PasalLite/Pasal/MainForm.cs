using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Bsoft.Common.Language;
using Bsoft.Common;
using Friuts;

using Bsoft.Forms;
using Bsoft.Languages;
using Bsoft.AppCom;
using UEMS.MasterEntry;
using Bsoft.AppCom.BasicForms;
using Pasal.Reports;
using System.Threading;
namespace Pasal
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class MainForm : Bsoft.AppCom.MainFormCom
    {
        public MainForm(string load):this()
        {
            LblTitle.Visible = false;
            Text = UEMS.frmAboutBox.AssemblyProduct;
            this.MnuRightsAssign.Click += new System.EventHandler(this.MnuRightsAssign_Click);
            this.mnuChangePassWord.Click += new System.EventHandler(this.MnuChangePassword_Click);
            this.mnuChangeLogin.Click += new System.EventHandler(this.MnuChangeUserLoging_Click);
            this.mnuRestore.Click += new System.EventHandler(this.MnuRestore_Click);
            //this.mnuBackUpDataBase.Click += new System.EventHandler(this.MnuBackup_Click);
            // this.mnuOrgDetails.Click += new System.EventHandler(this.mnuChangeableDetails_Click);


            //lblUserName.Text = Language.User;
            // mnuMasterEntry.Text = Language.MasterEntry;
            // mnuRestore.Text = Language.LanguageString.Restore;
            mnuBackUpDataBase.Text = Language.LanguageString.Backup;
            mnuChangeLogin.Text = Language.LanguageString.LogOff;
            mnuExit.Text = Language.LanguageString.Close;
             

            LoadOrganaizationDetails();
            if (!LoginOrChangeUser())
            {
                Close();
                Application.Exit();
            }
             
           
        }

        bool exitApp = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StaticInvoice.CompanyName = ConstantValues.Org_Name;
            StaticInvoice.PanNo = ConstantValues.PANNo;
            StaticInvoice.VatNo = ConstantValues.VATNo;
            StaticInvoice.Address = ConstantValues.Org_Tole + "," + ConstantValues.Org_District;
        }

        public override bool LoginOrChangeUser()
        {

            if (base.LoginOrChangeUser())
            {
                UserRights.setRights(mnuStripMy);
                exitApp = true ;
                return true;
            }
            exitApp = true;
            return false;
            
        }
         
        private void mnuAbout_Click(object sender, EventArgs e)
        {
            UEMS.frmAboutBox abt = new UEMS.frmAboutBox(false);
            abt.ShowDialog();
        }



        private void mnuExit_Click(object sender, EventArgs e)
        {
            _closeButton_Click(sender, e);
        }

        private void _closeButton_Click(object sender, EventArgs e)
        {
            if (MessageBoxMy.Show(Language.LanguageString.DoYouWantToClose, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        #region For Pasal
        private void weightUnitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pasal.MasterEntry.frmUnitList frm = new Pasal.MasterEntry.frmUnitList();
            frm.ShowDialog();
        }

        private void enterCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pasal.MasterEntry.frmProductCompanyList frm = new Pasal.MasterEntry.frmProductCompanyList();
            frm.ShowDialog();
        }

        private void enterVendorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pasal.MasterEntry.frmProductVendorList frm = new Pasal.MasterEntry.frmProductVendorList();
            frm.ShowDialog();
        }

        private void enterEditProductGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pasal.MasterEntry.frmProductGroupList frm = new Pasal.MasterEntry.frmProductGroupList();
            frm.ShowDialog();
        }

        private void enterEditCustomerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pasal.Forms.frmCustomerList frm = new Pasal.Forms.frmCustomerList();
            frm.ShowDialog();
        }

        private void mnuProductDetail_Click(object sender, EventArgs e)
        {
            Pasal.MasterEntry.frmProductList frm = new Pasal.MasterEntry.frmProductList();
            frm.ShowDialog();
        }

        private void mnuPurchase_Click(object sender, EventArgs e)
        {
            Pasal.Inventory.frmPurchageList frm = new Pasal.Inventory.frmPurchageList();
            frm.ShowDialog();
        }

        private void mnuLoss_Click(object sender, EventArgs e)
        {
            Inventory.frmSaleEntry frm = new Inventory.frmSaleEntry(Pasal.Inventory.ProductEntryType.damageLoss);
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
            else { }
        }

        private void mnuPurchaseReturn_Click(object sender, EventArgs e)
        {
            Inventory.frmSaleEntry frm = new Inventory.frmSaleEntry(Pasal.Inventory.ProductEntryType.purchageReturn);
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
            else { }
        }

        private void mnuSalesReturn_Click(object sender, EventArgs e)
        {
            Inventory.frmSaleEntry frm = new Inventory.frmSaleEntry(Pasal.Inventory.ProductEntryType.salesReturn);
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
            else { }
        }

        private void creditManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pasal.Forms.frmCreditManagementList frm = new Pasal.Forms.frmCreditManagementList();
            frm.ShowDialog(this);
        }
      
        private void mnuSales_Click(object sender, EventArgs e)
        {
           new Thread (new ThreadStart(showSalesForm) ).Start ();
         
        }
        [STAThreadAttribute]
        private void showSalesForm()
        {
            Pasal.Inventory.frmSaleList frm = new Pasal.Inventory.frmSaleList();
            frm.ShowDialog();
        }
        private void mnuShowReport_Click(object sender, EventArgs e)
        {
            Pasal.Reports.frmproductrpt frm = new Pasal.Reports.frmproductrpt();
            frm.ShowDialog(this);
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pasal.Reports.frmSalesReport frm = new Pasal.Reports.frmSalesReport();
            frm.ShowDialog(this);
        }

        private void damageLossReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pasal.Inventory.frmDamageLossList frm = new Pasal.Inventory.frmDamageLossList(Inventory.ProductEntryType.damageLoss);
            frm.ShowDialog();
        }

        private void mnuPurchageReturnReport_Click(object sender, EventArgs e)
        {
            Pasal.Inventory.frmDamageLossList frm = new Pasal.Inventory.frmDamageLossList(Inventory.ProductEntryType.purchageReturn);
            frm.ShowDialog();
        }

        private void mnuSaleReturnReport_Click(object sender, EventArgs e)
        {
            Pasal.Inventory.frmDamageLossList frm = new Pasal.Inventory.frmDamageLossList(Inventory.ProductEntryType.salesReturn);
            frm.ShowDialog();
        }
        #endregion

        private void mnuOrgDetails_Click(object sender, EventArgs e)
        {
            frmCompanyOption2 frm = new frmCompanyOption2();
            frm.btnSearch.Visible = false;
            frm.ShowDialog();
            LoadOrganaizationDetails();
        }

        private void tagTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UEMS.TagType_Lst tl = new UEMS.TagType_Lst();
            tl.ShowDialog();
        }

        private void tagGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UEMS.TagGroup_Lst tl = new UEMS.TagGroup_Lst();
            tl.ShowDialog();
            
        }

        private void tagItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UEMS.Tag_Lst tl = new UEMS.Tag_Lst();
            tl.ShowDialog();
        }

        private void mnuStockReport_Click(object sender, EventArgs e)
        {
            Pasal.Reports.frmStockrpt frm = new Pasal.Reports.frmStockrpt();
            frm.ShowDialog();
        }

        private void mnuSatisfiedClients_Click(object sender, EventArgs e)
        {
            MessageBoxMy.Show(this,"1.Baudhik Bikash Cooperative (Imadole,Lalitpur)\n2.Kaya Departmental Store (GhatteKulo,Anamnagar,Kathmandu)","Satisfied users of Pasal System",MessageBoxButtons.OK );
        }

        private void mnuUnitDetails_Click(object sender, EventArgs e)
        {
            UEMS.frmUnit_MasterList frm = new UEMS.frmUnit_MasterList();
            frm.ShowDialog();
        }




    }
}

