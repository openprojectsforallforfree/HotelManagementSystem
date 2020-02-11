using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using System.Reflection;
using Bsoft.Common;
using UEMS.BLL;
using Bsoft.Forms;
using Bsoft.Data;
using UEMS;
using Bsoft.Languages;

namespace Bsoft.AppCom
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmRegister : Friuts.EntryFormBase
    {
        public bool IsMachine = true;
        public frmRegister()
        {
            InitializeComponent();
            Label4.Text = Language.LanguageString.Register;
            btnCancel.Text = Language.LanguageString.Cancel;
            btnOk.Text = Language.LanguageString.Ok;
            Text = Language.LanguageString.Register;
            btnOk.Font = MainFont;
            btnCancel.Font = MainFont;
            txtRegistrationKey.Font = new Font("Verdana", 10);
        }
        string reglc = string.Empty;
        private void btnOk_Click(object sender, EventArgs e)
        {
            ConstantValues.RegistraionKey = txtRegistrationKey.Text;
            if (IsMachine)
            {
                reglc = keys.GetGegLockMachine(ConstantValues.Org_Name, ConstantValues.Org_District, ConstantValues.ProductName, ConstantValues.ProductVersion);
                if (keys.getRegType(reglc, txtRegistrationKey.Text) != RegType.Unreg)
                {
                    ConstantValues.RegistraionKey = txtRegistrationKey.Text;
                    ConstantValues.BuildDetail = skgen.buildDetail;

                    picIsRegistered.Visible = true;
                    MessageBoxMy.Show("Registered Successfully", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    picIsRegistered.Visible = false;
                    txtRegistrationKey.Text = "";
                    MyInputBox msg = new MyInputBox("Registraion key is not Correct \nPlease email or convey following text to the Author.\nEmail : bajrasoft@gmail.com \n", reglc);
                    msg.ShowDialog();
                }
            }
            else
            {
                reglc = keys.GetGegLockMachine(ConstantValues.Org_Name, ConstantValues.Org_District, ConstantValues.ProductName, ConstantValues.ProductVersion);

                if ((skgenNoMachine.isKey(ConstantValues.RegistraionKey, reglc)))
                {
                    ConstantValues.RegistraionKey = txtRegistrationKey.Text;
                    ConstantValues.BuildDetail = skgen.buildDetail;
                    picIsRegistered.Visible = true;
                    MessageBoxMy.Show("Registered Successfully", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    picIsRegistered.Visible = false;
                    txtRegistrationKey.Text = "";
                    MyInputBox msg = new MyInputBox("Registraion key is not Correct \nPlease email or convey following text to the Author.\n", reglc);
                    msg.ShowDialog();
                }
            }

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            reglc = keys.GetGegLockMachine(ConstantValues.Org_Name, ConstantValues.Org_District, ConstantValues.ProductName, ConstantValues.ProductVersion);
            try
            {
                txtRegistrationKey.Text = ConstantValues.RegistraionKey;
            }
            catch { }
            if (keys.getRegType(reglc, txtRegistrationKey.Text)!= RegType .Unreg )
            {
                picIsRegistered.Visible = true;
            }
            else
            {
                picIsRegistered.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

