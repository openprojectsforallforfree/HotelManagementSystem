using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bsoft.Common.Language;
using Bsoft.Languages;

namespace UEMS
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmInputBoxMessage : Friuts.FormBase
    {
        public frmInputBoxMessage()
        {
            InitializeComponent();
            ChangeLanguage();
        }
        public void ChangeLanguage()
        {
           // btnCancel.Text = Language.Cancel;
       
            btnOk.Text = Language.LanguageString.Ok;
            //newToolbar.Text = LanguageData.NewAdd;
            //EditToolbar.Text = LanguageData.Edit;
            //DeleteToolbar.Text = LanguageData.Delete;
            //ExportToolbar.Text = LanguageData.ExporttoExcel;
        }
        public frmInputBoxMessage(string _Message,string _inputboxmsg):this()
        {
            txtnputBox.Text=_inputboxmsg;
            lblMessage.Text = _Message;

        }
        public frmInputBoxMessage(string _Message ):this ()
        {
            lblMessage.Text = _Message;
        }
        public string textValue
        {
            get { return txtnputBox.Text; }
            set { txtnputBox.Text = value; }
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtnputBox.Text);
            DialogResult = DialogResult.OK;
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}

