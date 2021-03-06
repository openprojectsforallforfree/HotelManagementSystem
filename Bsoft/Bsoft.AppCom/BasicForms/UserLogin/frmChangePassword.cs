using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Bsoft.Controls;

using Friuts;
using Bsoft.Data;
using Bsoft.Common.Language;
using Bsoft.Forms;
using Bsoft.Languages;
using UEMS.BLL;
using Bsoft.AppCom;

namespace UEMS.Forms.UserLogin
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmChangePassword : EntryFormBase
    {
        private string _uSerName = string.Empty;
        
        public frmChangePassword(  )
        {
            InitializeComponent();
            Text = Language.LanguageString.Login;
            cmdOk.Text = Language.LanguageString.Ok;
            cmdCancel.Text = Language.LanguageString.CancelGoBack;
            lblUser.Text = Language.LanguageString.UserName;
          //  label1.Text = Language.PassWord;
            _uSerName = GlobalValues.LoginUserName;

            Text = Language.LanguageString.changePassword;
            cmdOk.Text = Language.LanguageString.Ok;
            cmdCancel.Text = Language.LanguageString.CancelGoBack;
            lblUser.Text = Language.LanguageString.UserName;
            lblOldPw.Text = Language.LanguageString.OldPassWord;
            lblNewpw.Text = Language.LanguageString.PassWord;
            lblNewPwConfirm.Text = Language.LanguageString.PassWord + "(Re-Type)";
            this.FirstControl = txtOldPassword;
            this.AcceptButton = cmdOk;
            this.CancelButton = cmdCancel;
            txtOldPassword.Select();
            //code for encryption of the data before it is inserted to the database.
            //EncryptSymmetric enc = new EncryptSymmetric();
            //string encryptedData = enc.EncryptData("asdga");

            //Decrypted data after the encrypted data is accessed from the database.
            //EncryptSymmetric enc = new EncryptSymmetric();
            //string normal = enc.DecryptData(encryptedData);
            
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                string Message = MessagesChangePassword.Passwordsdonotmatch;
                MessageBoxMy.Show(Message, MessageBoxButtons.OK);
                return;
            }

            if (txtPassword.Text == string.Empty || txtConfirmPassword.Text == string.Empty)
            {
                string Message = MessagesChangePassword.Passwordsboth;
                MessageBoxMy.Show(Message, MessageBoxButtons.OK);
                return;
            }
            //if (txtOldPassword.Text == txtConfirmPassword.Text)
            //{
            //    MessageBox.Show(ActiveForm, "Old password and New password can not be same.", Application.ProductName);
            //    return;
            //}

            Bsoft.Common.clsEncryptorDecryptor enc = new Bsoft.Common. clsEncryptorDecryptor();
            string OldPassword = string.Empty;
            string NewPassword  = string.Empty;
            string LoginUserName = _uSerName.ToString();
            string LoginId = string.Empty;

            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT");
            sql.Append("\n\tDISTINCT id, UserId, pw ");
            sql.Append("\nFROM");
            sql.Append("\n\tSuperAdmin_Rights_Users");
            sql.Append("\nWHERE");
            sql.AppendFormat("\n\t UPPER(UserId) ='{0}'", LoginUserName.ToUpper().Trim());

            DataTable dt = null;

            //dt = GlobalResources.SelectDBConnection.ExecuteDataTable(sql.ToString());
            dt = GlobalResources.SelectDBConnection.ExecuteDataTable(sql.ToString());
            if (dt.Rows.Count < 1)
            {
                //checking only for old password new password
                MessageBox.Show(ActiveForm,  Language.LanguageString.InvalidPassword);
                //return;
                //do noting now..
            }
            else
            {
              //  BsoftSystem.clsEncryptorDecryptor enc = new BsoftSystem.clsEncryptorDecryptor();
                   
                    OldPassword = dt.Rows[0]["pw"].ToString();

                    if (OldPassword != string.Empty) //Checking Blank Password..
                    {
                        OldPassword = enc.Decrypt(OldPassword.Trim()); //Encrypted Password to Decrypte
                    }
                    if (OldPassword != txtOldPasswordc.Text) //Checking Upwd and db Upwd
                    {
                        string Message =  Language.LanguageString.InvalidPassword ;
                        MessageBoxMy.Show(Message, MessageBoxButtons.OK);
                        
                        return; }

              //  OldPassword = dt.Rows[0]["UserPassword"].ToString();
                LoginId = dt.Rows[0]["id"].ToString();
                //OldPassword = enc.DecryptData(OldPassword);
                NewPassword = enc.Encrypt (txtPassword.Text);

                //using (DBConnect con1 = new DBConnect(TPPIMS.GlobalResources.ConnectionString))
                //{
                if (GlobalResources.SelectDBConnection.Open())
                    {
                        //"UPDATE UserMaster SET UserPassword = '" + NewPassword + "' WHERE Sn = '" + LoginId + "'"
                        sql.Remove(0, sql.Length);
                        sql.Append("UPDATE SuperAdmin_Rights_Users SET");
                        sql.AppendFormat("\n\tpw ='{0}'", NewPassword);
                        sql.Append("\nWHERE");
                        sql.AppendFormat("\n\tid ='{0}'", LoginId);

                        int res = GlobalResources.SelectDBConnection.ExecuteNonQuery(sql.ToString());
                        //int res = con1.ExecuteNonQuery(sql.ToString());

                        if (res > 0)
                        {
                            //success
                            string Message = MessagesChangePassword.PasswordSaved;
                            MessageBoxMy.Show(Message, MessageBoxButtons.OK );
                            DialogResult = DialogResult.OK;
                        }
                        else
                        { 
                            //failure [Password is not save message display.
                            string Message = MessagesChangePassword.PasswordNotSaved;
                            MessageBoxMy.Show(Message, MessageBoxButtons.OK );
                            DialogResult = DialogResult.Cancel ;
                        }
                    }
                //}
                //    ///MessageBox.Show(ActiveForm, "The old password is incorrect.");
                //    string Message = ";_s]t zAb œk'<fgf] kf;j*{ ldn]g M ldNg]u<L ^fOk ug'{xf];"+ @"\ È";
                //    frmMessageBox frm = new frmMessageBox(Message);
                //    frm.ShowDialog(this);
                //    frm.Dispose();
                //    return;
                //}
            }
            DataGeneral.DisposeObject(dt);
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            //Temporaryely User name display only
            txtOldPassword.Text = _uSerName.ToString(); 


        }
    }

    public static class MessagesChangePassword
    {
        public static string Passwordsdonotmatch
        {
            get
            {
                switch (Language.currentLanguage)
                {
                    case LanguageChoice.Nepali:
                        return "दुबै नयाँ पहिचान शब्द एउटै राख्नुहोला ";
                }
                return "The Passwords do not match.";
            }
        }
        public static string Passwordsboth
        {
            get
            {
                switch (Language.currentLanguage)
                {
                    case LanguageChoice.Nepali:
                        return "दुबै नयाँ पहिचान शब्द राख्नुहोला  ";
                }
                return "Please enter both passwords.";
            }
        }
        

        public static string PasswordSaved
        {
            get
            {
                switch (Language.currentLanguage)
                {
                    case LanguageChoice.Nepali:
                        return "पहिचन शब्द सदर भयो ।";
                }
                return "Password was saved successfully";
            }
        }
        public static string PasswordNotSaved
        {
            get
            {
                switch (Language.currentLanguage)
                {
                    case LanguageChoice.Nepali:
                        return "पहिचन शब्द सदर भएन ।";
                }
                return "Password could not be saved";
            }
        }
      
    }
}

