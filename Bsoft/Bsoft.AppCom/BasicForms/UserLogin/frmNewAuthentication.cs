using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bsoft.Common.Language;
using Friuts;
using Bsoft.Forms;
using Bsoft.Languages;
using UEMS.BLL;
using Bsoft.Data;
using Bsoft.AppCom;
using Bsoft.Common;
///It will have the information of  
///loginid,UserId,UserName,Pw
///User login will be a dialog box now
///It will not save any thing any where 
namespace UEMS.BasicForms.UserLogin
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmNewAuthentication : Friuts.EntryFormBase
    {
        public frmNewAuthentication()
        {
            InitializeComponent();
            Text = Language.LanguageString.Login;
            cmdOk.Text = Language.LanguageString.Ok;
            cmdExit.Text = Language.LanguageString.CancelGoBack;
            label6.Text = Language.LanguageString.UserName;
            label7.Text = Language.LanguageString.PassWord;
            this.AcceptButton = cmdOk;
            this.CancelButton = cmdExit;
            LoadUserId();

        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            DataTable dt = null;

            if (txtUserName.Text.Trim().Length == 0)
            {
                MessageBoxMy.Show(Language.LanguageString.UserNameCannotbeEmpty, MessageBoxButtons.OK);
                txtUserName.Focus();
            }
            else if (txtPassword.Text.Trim().Length == 0)
            {

                MessageBoxMy.Show(Language.LanguageString.PasswordCannotbeEmpty, MessageBoxButtons.OK);
                txtUserName.Focus();
            }

            else if (IsUserName(ref dt) && IsPw(dt))
            {
                List<CheckerObject> chks = new List<CheckerObject>()
                                    { 
                        new CheckerObject() {
                            count  =GlobalResources.SelectDBConnection.GetRecordCount ("Hotel_Bookings") 
                                            }
                                    };
                NewMethod(chks);
                ConstantValues.LastLoginDate = DateTime.Now.ToString("yyyyMMdd");
                UpdateLoginDate();
                DialogResult = DialogResult.OK;

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
        private bool IsPw(DataTable dt)
        {
            Bsoft.Common.clsEncryptorDecryptor enc = new Bsoft.Common.clsEncryptorDecryptor();
            String Upassword = string.Empty;
            Upassword = dt.Rows[0]["pw"].ToString();
            if (Upassword != string.Empty) //Checking Blank Password..
            {
                Upassword = enc.Decrypt(Upassword.Trim()); //Encrypted Password to Decrypte
                if (Upassword == txtPassword.Text) //Checking Upwd and db Upwd
                {
                    GlobalValues.LoginUserIDPk = dt.Rows[0]["ID"].ToString();
                    GlobalValues.UserFullNepName = dt.Rows[0]["NEPNAME"].ToString();
                    GlobalValues.UserFullEngName = dt.Rows[0]["ENGNAME"].ToString();
                    GlobalValues.LoginUserName = dt.Rows[0]["UserId"].ToString();
                    password = dt.Rows[0]["pw"].ToString();
                    return true;
                }
                else
                {
                    //Invalid Password.
                    MessageBoxMy.Show(Language.LanguageString.InvalidPassword, MessageBoxButtons.OK);
                    txtPassword.SelectAll();
                    txtPassword.Focus();
                    return false;
                }
            }
            return false;
        }

        private void UpdateLoginDate()
        {
            string sql = "";
            sql = @"UPDATE SuperAdmin_Rights_Users set LASTLOGGEDOUT = '{0}'
                        Where UserId ='{1}'".With(DateTime.Now.ToString("yyyyMMdd"), txtUserName.Text.ToLower  ());

            GlobalResources.SelectDBConnection.ExecuteNonQuery (sql.ToString());
            sql = @"UPDATE SuperAdmin_Rights_Users set LASTLOGGEDON = '{0}'
                        Where UserId ='{1}'".With(DateTime.Now.ToString("yyyyMMdd"), txtUserName.Text.ToLower());

            GlobalResources.SelectDBConnection.ExecuteNonQuery(sql.ToString());

        }


        private bool IsUserName(ref DataTable dt)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT");
            sql.Append("\n\tDISTINCT * ");
            sql.Append("\nFROM");
            sql.Append("\n\tSuperAdmin_Rights_Users");
            sql.Append("\nWHERE");
            sql.AppendFormat("\n\t UserId ='{0}'", txtUserName.Text.ToLower().Trim());
            dt = GlobalResources.SelectDBConnection.ExecuteDataTable(sql.ToString());
            if (dt.Rows.Count < 1)
            {
                //Message Display Invalid User name
                txtUserName.Focus();
                txtUserName.SelectAll();
                MessageBoxMy.Show(Language.LanguageString.InvalidUserName, MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        public string password = string.Empty;


        public void LoadUserId()
        {
            try
            {
                txtUserName.Text = Bsoft.AppCom.Properties.Settings.Default.LastLoginBy;
            }
            catch { }
        }
        public void SaveUserId()
        {
            try
            {
                Bsoft.AppCom.Properties.Settings.Default.LastLoginBy = txtUserName.Text;
                Bsoft.AppCom.Properties.Settings.Default.Save();
            }
            catch { }
        }

        private void frmNewAuthentication_Load(object sender, EventArgs e)
        {

        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

    }





}
