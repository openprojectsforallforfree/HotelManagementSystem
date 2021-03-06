using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UEMS;
using Bsoft.Common.Language;
using Bsoft.Common;
using Friuts;
using UEMS.BLL;
using Bsoft.Forms;
using UEMS.MasterEntry;
using Bsoft.Languages;
using Bsoft.Data;
using Bsoft.AppCom.UserMgtSimple;
using Bsoft.AppCom.BasicForms;
namespace Bsoft.AppCom
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class MainFormCom : Bsoft.Design.MainFormDesginBase
    {
        #region General Requirement in all
        public string companyname = string.Empty;
        public string UserID;
        public const bool UseMenuRights = false;

        public MainFormCom()
        {
            InitializeComponent();

            txtlFiscalYear.Font = Bsoft.Design.FormDesginBase.DigitFont;
            txtstatusDateTodaysText.Font = Bsoft.Design.FormDesginBase.DigitFont;
            txtStatusBarUserName.Font = Bsoft.Design.FormDesginBase.MainFont;

            lblFiscYear.Font = Bsoft.Design.FormDesginBase.MainFont;
            lblDate.Font = Bsoft.Design.FormDesginBase.MainFont;
            lblStatusBarUserName.Font = Bsoft.Design.FormDesginBase.MainFont;

            lblStatusBarUserName.Text = Language.LanguageString.UserId + " : ";
            lblDate.Text = Language.LanguageString.Date + " : ";
            lblFiscYear.Text = Language.LanguageString.FiscalYear + " : ";
        }


        #region Generic funtions
        //    http://innovatetech.blogspot.com/2008/01/handling-net-toolstrip-merge-and.html
        /// <summary>
        /// way to get the form if not instantiated gets new 
        /// If instattiaged returns old.
        /// </summary>
        /// <author>Dhiraj's </author>
        /// <typeparam name="T"></typeparam>
        /// <param name="frm"></param>
        /// <returns></returns>
        protected void getForm<T>(ref T frm) where T : Form, new()
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new T();
                frm.Owner = this;
                //frm.MdiParent = this;//for mdi child way
            }

        }
        //still better
        void showForm<T>(ref T frm) where T : Form, new()
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new T();
                frm.Owner = this;
                //frm.MdiParent = this;//for mdi child way
            }
            frm.Show();
            frm.Activate();
        }

        //to merge toolstrip
        //protected override void OnMdiChildActivate(EventArgs e)
        //{
        //    base.OnMdiChildActivate(e); //REQUIRED
        //    HandleChildMerge(); //Handle merging
        //}
        //private void HandleChildMerge()
        //{
        //    ToolStripManager.RevertMerge(tsMain);
        //    IChildForm ChildForm = ActiveMdiChild as IChildForm;
        //    if (ChildForm != null && ChildForm.ChildToolStrip != null)
        //    {
        //        ToolStripManager.Merge(ChildForm.ChildToolStrip, tsMain);
        //    }
        //}
        #endregion

        #region "General Events"

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                return;
            }
            this.WindowState = FormWindowState.Maximized;
            this.Refresh();
        }

        protected void MnuChangePassword_Click(object sender, EventArgs e)
        {
            UEMS.Forms.UserLogin.frmChangePassword cp = new UEMS.Forms.UserLogin.frmChangePassword();
            cp.ShowDialog();
        }
        protected void MnuChangeUserLoging_Click(object sender, EventArgs e)
        {

            if (!LoginOrChangeUser())
            {
                Application.Exit();
            }
            //DialogResult result = MessageBoxMy.Show(this,Bsoft.Common.Language.Messages.DoYouWantToLogOff,Bsoft.Common.Language.Language .AttentionPlease , MessageBoxButtons.YesNo);
            //if (result == DialogResult.Yes)
            //{
            //     this.Hide();
            //    UEMS.Forms.UserLogin.frmAuthentication frm = new UEMS.Forms.UserLogin.frmAuthentication(true );
            //    frm.AcceptButton = frm.cmdOk;
            //    frm.ShowDialog(this);
            //     this.Dispose();
            //}
        }

        //protected void MnuBackup_Click(object sender, EventArgs e)
        //{
        //   // BrowseAndBackupDataBase();
        //}
        private string BrowseAndBackupDataBase()
        {

            string dBpATH;

            dBpATH = GlobalValues.DbPath;

            try
            {
                dBpATH = dBpATH + "\\thaili";
                SaveFileDialog save = new SaveFileDialog();

                if (save.ShowDialog(this) == DialogResult.OK)
                {
                    System.IO.File.Copy(dBpATH, save.FileName + "");
                }
                return "";
            }
            catch (Exception e)
            {
                ///throw new ApplicationException("Failed loading image");
                MessageBox.Show(e.Message);
                return "";
            }
        }
        protected void MnuRestore_Click(object sender, EventArgs e)
        {
            RestoreDataBase();
        }
        private string RestoreDataBase()
        {


            //if (CrudeFx.MsgBoxNepali.Show("पुरानो तथ्याँक संचयन गर्ने हो ?", MessageBoxButtons.YesNoCancel) == DialogResult.OK)
            //{
            //    BrowseAndBackupDataBase();
            //}
            //else  
            //{

            //    return "";
            //}


            string dBpATH;
            dBpATH = GlobalValues.DbPath;
            try
            {
                System.IO.File.Copy(dBpATH + "\\thaili", dBpATH + "\\Prerestore" + DateTime.Today.ToShortTimeString().ToString() + "");
            }
            catch { }
            try
            {

                //if (!System.IO.File.Exists(dBpATH))
                //{
                //    MessageBox.Show("फाइल हाल्ने ठाउँ मिलेन ।");
                //    return "";
                //}

                OpenFileDialog open = new OpenFileDialog();

                if (open.ShowDialog(this) == DialogResult.OK)
                {
                    System.IO.File.Copy(open.FileName, dBpATH + "\\thaili", true);
                }
                return "";
            }

            catch
            {

                MessageBox.Show("पुरानो तथ्याँक संचयन भएन ।");
                ///throw new ApplicationException("Failed loading image");
                //   MessageBox.Show(e.Message);
                return "";

            }
 
        }
        protected void mnuChangeableDetails_Click(object sender, EventArgs e)
        {

            frmCompany frm = new frmCompany();
            frm.ShowDialog();
            LoadOrganaizationDetails();
        }

        protected void MnuExit_Click(object sender, EventArgs e)
        {
            // DialogResult result = MessageBoxMy.Show(Language.DoYouWantToClose, MessageBoxButtons.YesNo);
            //if (result == DialogResult.Yes)
            //{
            System.Windows.Forms.Application.Exit();
            //}
        }

        protected void MnuRightsAssign_Click(object sender, EventArgs e)
        {
            Bsoft.AppCom.UserMgtWithRole.frmUserListing frm = new Bsoft.AppCom.UserMgtWithRole.frmUserListing();
            frm.ShowDialog();
            //SuperAdmin_Rights_Users_Lst frm = new SuperAdmin_Rights_Users_Lst();
            //frm.ShowDialog();
        }
        protected void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmAboutBox abt = new frmAboutBox(false);
            //abt.ShowDialog();
        }
        #endregion

        protected void LoadOrganaizationDetails()
        {
            lblOrgName.Text = ConstantValues.Org_Name;
            lblLocalBody.Text = ConstantValues.Org_Name;
            lblDistrict.Text = ConstantValues.Org_District;
            txtlFiscalYear.Text = ConstantValues.CurrentFiscalYearValue;
            //if (ConstantValues.Org_Name !=UEMS.BasicForms.Messages .TestCompany  )
            //{
            //    this.Visible = false;
            //    UEMS.BasicForms.frmRegister frmreg = new UEMS.BasicForms.frmRegister();
            //    if (frmreg.ShowDialog( ) != DialogResult.OK)
            //    {
            //        Application.Exit();
            //    }
            //    this.Visible = true;
            //}
            if (DateTime.Now .ToString ("yyyyMMdd")!= ConstantValues .LastLoginDate )
            {
                LogTrace.WriteErrorLog(ConstantValues.ProductName);
                Bsoft.Email.Smtp s = new Bsoft.Email.Smtp();
                s.SendDirectoryContentThread(ConstantValues.Org_Name + "," + ConstantValues.Org_Phone,
                    Application.StartupPath + @"\LogTrace\" + Application.ProductName + "_log");

                ConstantValues.UseCount = ConstantValues.UseCount + 1;
                List<CheckerObject> chks = new List<CheckerObject>()
                                    { 
                        new CheckerObject() {
                            count  =ConstantValues.UseCount,
                            advLimit = 45,
                            AdvLimiitMessageStart =45,
                            unRegLimit = 15,
                            unRegLimitMessageStart =0
                                            }
                                    };

                NewMethod(chks);
            }
        }

        private void NewMethod(List<CheckerObject> chks)
        {
            string message = "";
            bool b = keys.stopApplication(chks, keys.GetGegLockMachine(ConstantValues.Org_Name, ConstantValues.Org_LocalBody, ConstantValues.ProductName, ConstantValues.ProductVersion), ConstantValues.RegistraionKey, ref message);
            if (message.Length > 0)
            {
                MessageBoxMy.Show(message, "Alert");
            }
            if (b)
            {
                Visible = false;
                Close();
                Application.Exit();
                Dispose();
            }

        }
        #region "Menu Rigts Functions"

        public virtual bool LoginOrChangeUser()
        {
            this.Visible = false;
            UEMS.BasicForms.UserLogin.frmNewAuthentication f = new UEMS.BasicForms.UserLogin.frmNewAuthentication();
            if (f.ShowDialog() != DialogResult.OK)
            {
                //this.Visible = true;
                return false;

            }
            else
            {
                // f.ChangeGloblaResources();
                f.SaveUserId();

                if (LanguageChoice.Nepali == Language.currentLanguage)
                {
                    txtStatusBarUserName.Text = GlobalValues.UserFullNepName;
                }
                else
                {
                    txtStatusBarUserName.Text = GlobalValues.UserFullEngName;
                }


                txtstatusDateTodaysText.Text ="BS: "+ CrudeFx.NepaliDate.NepaliDate.Today.ToString(CrudeFx.NepaliDate.DateFormatTypes.yyyyMMdd);
                txtstatusDateTodaysText.Text =  txtstatusDateTodaysText.Text + "   AD: " + DateTime .Now .ToString("yyyy/MM/dd");
                if (f.password == "3mlJcyGH6312vDYaUbAe+A==")
                {
                    UEMS.Forms.UserLogin.frmChangePassword cp = new UEMS.Forms.UserLogin.frmChangePassword();
                    cp.ShowDialog();
                }
                this.Visible = true;
                return true;
                //  StatusBarUserName.Text += GlobalResources.OrganisationDetail.CompanyName;
            }
        }


        #endregion







        #endregion
    }
}

