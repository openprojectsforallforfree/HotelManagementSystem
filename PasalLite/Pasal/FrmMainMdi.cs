using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using Friuts;
using Bsoft.Controls;
using Bsoft.Forms;
using Bsoft.Utility;
using UEMS.BLL;
using Bsoft.Common;
using UEMS;
using UEMS.Forms;
using UEMS.MasterEntry;
using Bsoft.AppCom;
using Bsoft.Data;
using Bsoft.AppCom.UserMgtWithRole;
//using Pasal.Class.GeneralFunction;
//using Pasal.MasterSetting;
//using Pasal.Maintenance;
//using Pasal.Reports;
//using Pasal.Transaction;
//using Pasal.Class;

namespace Pasal
{
    public partial class FrmMainMdi :Form
    {
        public string companyname = string.Empty;
        public string UserID;

        public FrmMainMdi()
        {
            InitializeComponent();
        }


        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBoxMy.Show("Do you want to Exit .", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }

        }
        


        private void setRight(System.Windows.Forms.ToolStripItem mnuItem, DataRow drMenu)
        {
            if (mnuItem.Enabled == false)
            {
                return;
            }
            string id,    right = "1";
            id = Conversion.ToString(drMenu, "id");
           // mnutext = Conversion.ToString(drMenu, "text");
            right = Conversion.ToString(drMenu, "giveright");

            if (right == "0")
            {
                mnuItem.Visible = false ;
                mnuItem.Enabled = false;
            }
            else
            {
                mnuItem.Visible = true;
                mnuItem.Enabled = true;
            }


        }
        /// <summary>
        /// set menu rights
        /// </summary>
        private void setRights()
        {
            StringBuilder sql = new StringBuilder();
            string grp;

            grp = GlobalValues.LoginRoleGroup ;
            if (grp=="")
            {
                MessageBoxMy.Show("Your roles are not assigend .Please Contact the administrator.",MessageBoxButtons.OK  );
                
                Application.Exit();
            }
            sql.Append("select t1.id,t1.fk_group,t1.fk_menu,t1.giveright,t2.name");
            sql.Append(" from Rights_group_menu t1 ");
            sql.Append("left join Rights_Menu_Master t2 on ");
            sql.Append("t1.fk_menu=t2.id ");
            sql.Append("where fk_group=" + grp);
            DataRow drMenu;
            DataTable dtMenu = GlobalResources.SelectDBConnection.ExecuteDataTable(sql.ToString());

            DataColumn[] dcPrimary = { dtMenu.Columns["name"] };
            dtMenu.PrimaryKey = dcPrimary;
            foreach (System.Windows.Forms.ToolStripMenuItem mainmenu in menuStripMy.Items)
            {
                drMenu = dtMenu.Rows.Find(mainmenu.Name);
                setRight(mainmenu,drMenu );

                foreach (System.Windows.Forms.ToolStripItem submenu in mainmenu.DropDownItems)
                {
                    drMenu = dtMenu.Rows.Find(mainmenu.Name);
                    setRight(submenu,drMenu );
                }
            }

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //if (!check())
            //{
            //    MessageBox.Show("Not Registered Please contact the author!");
            //    Close();
            //}
          //  setRights();
            this.WindowState = FormWindowState.Maximized;
            //AFTER loing user company information  settting..
            // dtToday.Value = CrudeFx.NepaliDate.NepaliDate.Today;
            // lblDistrict.Text = GlobalResources.OrganisationDetail.OFFICE_NAME + " sfof{no";
            //if (GlobalResources.OrganisationDetail.CurrentFiscalYear != null)
            //    lblFiscalYear.Text = GlobalResources.OrganisationDetail.CurrentFiscalYear.ToString();
            //lblDistrictN.Text = GlobalResources.OrganisationDetail.OFFICE_ADDRESS;

            //if (!GlobalResources.OrganisationDetail.checkKey)
            //{
            //    //sageBox.Show("Please register");
            //    frmRegister reg = new frmRegister();
            //    reg.ShowDialog();
            //    Application.Exit();
            //}
            toolUserName.Text = GlobalValues.UserFullEngName .ToString();
            toolCompanyName.Text = ConstantValues.Org_Name ;
            //   statusStrip1.Items.Add("cfhsf] ldlt Ÿ  " + dtToday.Value.ToString());
        }
        //StringBuilder sql = new StringBuilder();
        //sql.Append("SELECT");
        //sql.Append("\n\tCount (CASE WHEN ");
        //sql.AppendFormat("DATAENTRYVSDATE = '{0}'", dtToday.Value.ToString());
        //sql.Append("THEN 1 END) TotTaxPear, COUNT(*) Total");
        //sql.Append("\nFROM");
        //sql.Append("\n\tpeople");
        //DataTable dt = null;
        //dt = GlobalResources.SelectDBConnection.ExecuteDataTable(sql.ToString());

        //if (dt != null && dt.Rows != null && dt.Rows.Count > 0)
        //{
        //    statusStrip1.Items.Add("cfhsf] k|ljli^ Ÿ " + dt.Rows[0]["TotTaxPear"].ToString() + " hgf ," + " hDdf s<bftf ;_ª\\Vof Ÿ " + dt.Rows[0]["Total"].ToString());
        //}
        //  MenuSecurityRights();















        //toolStripStatusLabel1.Text = "";

        //UserID = "";
        //FrmLogin frmLogin = new FrmLogin();            
        //frmLogin.ShowDialog();
        //if (frmLogin.checkStatus == true)
        //{

        //    UserID = frmLogin.UserID;
        //    LogOnToolStripMenuItem.Text = "&Log Off  ";
        //    clsCommon cls = new clsCommon();
        //    DataSet strCompanyName = DataAccessLayer.SqlHelper.ExecuteDataset(ConnectionManager.GetConnectonString(), CommandType.Text, "Select Company_Name,' ')as CompanyName from company", null);
        //    if (strCompanyName.Tables[0].Rows.Count > 0)
        //    {
        //        toolStripStatusLabel1.Text = strCompanyName.Tables[0].Rows[0]["CompanyName"].ToString();

        //    }
        //    userRight();

        //}
        //else 
        //{

        //    System.Windows.Forms.Application.Exit();
        //}




        //private void userRight() 
        //{
        //    if (UserID != "0")
        //    {
        //        string sql = "Select MenuName from UserPrevilage where UserID =" + UserID + "";
        //        DataSet dsTemp = DataAccessLayer.SqlHelper.ExecuteDataset(ConnectionManager.GetConnectonString(), CommandType.Text, sql, null);
        //        if (dsTemp.Tables[0].Rows.Count > 0)
        //        {
        //            foreach (DataRow DR in dsTemp.Tables[0].Rows)
        //            {
        //                SetMenuItem(DR["MENUNAME"].ToString(), false);

        //            }

        //        }

        //    }

        //}

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                return;
            }

            this.WindowState = FormWindowState.Maximized;
            this.Refresh();
        }




        private void LogOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBoxMy.Show("Do you want to log off .", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                //todo
                //frmAuthentication frm = new UEMS.BasicForms.UserLogin.frmAuthentication();
                //frm.ShowDialog(this);
                //this.Dispose();
            }

            //UserID = "";

            //SetMenuItem1("Pasal", true);
            //FrmLogin frmLogin = new FrmLogin();

            //frmLogin.ShowDialog();
            //if (frmLogin.checkStatus == true)
            //{

            //    UserID = frmLogin.UserID;
            //    userRight();
            //    LogOnToolStripMenuItem.Text = "&Log Off  ";


            //}
            //else
            //{

            //    System.Windows.Forms.Application.Exit();
            //}

        }


        private object SetMenuItem(string name, bool enabled)
        {

            ToolStripMenuItem m;

            m = this.FindToolStripMenuItem(this.menuStripMy.Items, name);



            if (m != null)
            {

                m.Visible = enabled;

                return true;
            }

            else
            {

                return false;

            }

        }

        private ToolStripMenuItem FindToolStripMenuItem(ToolStripItemCollection menus, string name)
        {

            bool found = false;

            ToolStripMenuItem t;
            ToolStripMenuItem temp;

            t = (ToolStripMenuItem)menus[name];

            if (t == null)
            {

                int i = 0;

                while (!found & i < menus.Count)
                {

                    if (object.ReferenceEquals(menus[i].GetType(), typeof(ToolStripMenuItem)))
                    {

                        temp = (ToolStripMenuItem)menus[i];

                        t = this.FindToolStripMenuItem(temp.DropDownItems, name);

                        found = (t != null);
                    }

                    i += 1;

                }

            }

            return t;

        }





        ///////////////////

        private object SetMenuItem1(string name, bool enabled)
        {

            ToolStripMenuItem m;

            m = this.FindToolStripMenuItem1(this.menuStripMy.Items, name);



            if (m != null)
            {

                m.Visible = enabled;

                return true;
            }

            else
            {

                return false;

            }

        }

        private ToolStripMenuItem FindToolStripMenuItem1(ToolStripItemCollection menus, string name)
        {

            bool found = false;

            ToolStripMenuItem t;
            ToolStripMenuItem temp;

            t = (ToolStripMenuItem)menus[name];

            if (t == null)
            {

                int i = 0;

                while (!found & i < menus.Count)
                {

                    if (object.ReferenceEquals(menus[i].GetType(), typeof(ToolStripMenuItem)))
                    {

                        temp = (ToolStripMenuItem)menus[i];

                        t = this.FindToolStripMenuItem1(temp.DropDownItems, name);

                        found = (t != null);
                        if (temp.Visible == false)
                        {
                            temp.Visible = true;
                        }
                    }

                    i += 1;

                }

            }

            return t;

        }



        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutBox abt = new frmAboutBox(false);
            abt.ShowDialog();
        }

        private void fiscalYearSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       





        
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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


        private void enterEditUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserListing frm = new  frmUserListing();
            frm.ShowDialog();
        }

        private void enterEditProductGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pasal.MasterEntry.frmProductGroupList frm = new Pasal.MasterEntry.frmProductGroupList();
            frm.ShowDialog();
        }

    


        private void backUpDatabaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBackup frmb = new frmBackup();
            frmb.ShowDialog();
        }

        private void userManagementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             frmUserListing frm = new  frmUserListing();
            frm.ShowDialog();
        }

      

        private void companyInformationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCompany frm = new frmCompany();
            frm.ShowDialog();
        }

        private void enterEditUsersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmUserListing frm = new frmUserListing();
            frm.ShowDialog();
        }

        private void weightUnitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pasal.MasterEntry.frmUnitList frm = new Pasal.MasterEntry.frmUnitList();
            frm.ShowDialog();
        }

        private void enterEditCustomerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pasal.Forms.frmCustomerList frm = new Pasal.Forms.frmCustomerList();
            frm.ShowDialog();
        }

        private void creditManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pasal.Forms.frmCreditManagementList frm = new Pasal.Forms.frmCreditManagementList();
            frm.ShowDialog(this);
        }

        private void menuRightsManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMnuRights frm = new frmMnuRights(menuStripMy);
            frm.ShowDialog(this);

        }

        private void getMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void mnuShowReport_Click(object sender, EventArgs e)
        {
            Pasal.Reports.frmproductrpt frm = new Pasal.Reports .frmproductrpt ();
            frm.ShowDialog(this);
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pasal.Reports.frmSalesReport frm = new Pasal.Reports.frmSalesReport();
            frm.ShowDialog(this);
        }

        private void correctSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "Select * from inv_sale";
            string cp,prodid;
            DataTable dt = GlobalResources.SelectDBConnection.ExecuteDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                //prodid = GlobalResources.SelectDBConnection.ExecuteScalar("select fk_product from  ").ToString ();
                prodid =dr["fk_Product"].ToString ();
                cp = GlobalResources.SelectDBConnection.ExecuteScalar("select standardcost from Product_Master where id=  " + prodid).ToString();

                sql = "update inv_sale set CostPrice = " + cp + " WHERE ID = " + dr["ID"].ToString();
                GlobalResources.SelectDBConnection.ExecuteNonQuery(sql);
            }
        }

        private void mnuRegister_Click(object sender, EventArgs e)
        {
            frmRegister frm = new frmRegister();
            frm.ShowDialog(this);
        }

        private void mnuLoss_Click(object sender, EventArgs e)
        {
            Inventory.frmSaleEntry frm = new Inventory.frmSaleEntry(Pasal.Inventory.ProductEntryType.damageLoss);
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
            else { }
        }

        private void damageLossReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pasal.Inventory.frmDamageLossList frm = new Pasal.Inventory.frmDamageLossList(Inventory .ProductEntryType .damageLoss );
            frm.ShowDialog();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pasal.Inventory.frmSaleList frm = new Pasal.Inventory.frmSaleList();
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

        private void mnuPurchaseReturn_Click(object sender, EventArgs e)
        {
            Inventory.frmSaleEntry frm = new Inventory.frmSaleEntry(Pasal.Inventory.ProductEntryType.purchageReturn );
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

        private void mnuPurchageReturnReport_Click(object sender, EventArgs e)
        {
            Pasal.Inventory.frmDamageLossList frm = new Pasal.Inventory.frmDamageLossList(Inventory.ProductEntryType.purchageReturn );
            frm.ShowDialog();
        }

        private void mnuSaleReturnReport_Click(object sender, EventArgs e)
        {
            Pasal.Inventory.frmDamageLossList frm = new Pasal.Inventory.frmDamageLossList(Inventory.ProductEntryType.salesReturn );
            frm.ShowDialog();
        }
    }
}
