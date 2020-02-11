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

namespace UEMS.Forms.UserLogin
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmAuthentication : EntryFormBase
    {
        private bool _success;
        private string _securityRights;
        bool _authenticateonly;
        public bool Success
        {
            get { return _success; }
            set { _success = value; }
        }

        public frmAuthentication()
        {
            _authenticateonly = false;
            InitializeComponent();
            
        }
        public frmAuthentication(bool authenticateonly)
        {
            _authenticateonly = authenticateonly;
            InitializeComponent();
            Text = Language.Login;
            cmdOk.Text = Language.Ok;
            cmdExit.Text = Language.CancelGoBack;
            label6.Text = Language.UserName;
            label7.Text = Language.PassWord;
        }
        public frmAuthentication(string securityRights)
            : this()
        {
            _securityRights = securityRights;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {

            Success = false;
            this.Close();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            
        }

        private void frmAuthentication_Load(object sender, EventArgs e)
        {
 
            try
            {
                //if (!BLL.GlobalResources.OrganisationDetail.checkFirstKey)
                //{
                    //Bsoft.Common.skgen bb = new Bsoft.Common.skgen();
                    //string keyval = bb.getFirstKeyMachine();
                    //frmInputBoxMessage msg = new frmInputBoxMessage("Registraion key is not Correct \nPlease email or convey the key word "+keyval + "to the Author.\nEmail : bajra@in.com \n And enter the unlock key");
                    //if (msg.ShowDialog() == DialogResult.OK)
                    //{
                    //    BLL.GlobalResources.OrganisationDetail.firstKey  = msg.textValue;
                    //    MessageBoxMy.Show("The key is entered .Please restart the application.");
                    //}
                    //Application.Exit();
                //}

            }
            catch
            { }

            try
            { txtUserName.Text = Properties.Settings.Default.Login_LastLoginBy; }
            catch { }
            this.Visible = true;
            this.ShowInTaskbar = true;
        }
    }
}

