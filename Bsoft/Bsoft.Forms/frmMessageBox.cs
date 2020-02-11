using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bsoft.Languages;

namespace Bsoft.Forms
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmMessageBox : Bsoft.Design.FormDesginBase
    {
        private DialogResult btnPressed = DialogResult.None;
        private MessageBoxButtons MsgButtons = MessageBoxButtons.OK;
        private string mMessage = "";
        private delegate void myDelegate();

        public frmMessageBox()
        {
            InitializeComponent();
            Text = Bsoft.Languages.Language.LanguageString.AttentionPlease;
            btnCancel.Text = Language.LanguageString.CancelGoBack;
            btnOk.Text = Language.LanguageString.Ok;
            btnNo.Text = Language.LanguageString.No;
            btnYes.Text = Language.LanguageString.Yes;
        }

        private void frmMessageBox_Load(object sender, EventArgs e)
        {
            ChangeFormSize();
        }
        private void ChangeFormSize()
        {

            //form size
            //this.Width = (lblMessage.Left * 2) + lblMessage.Width;
            int textwith = label1.Width + 32;

            if (textwith > this.MinimumSize.Width)
            {
                Width = textwith;
            }
            else
            {
                Width = MinimumSize.Width;
            }

            //  this.Height = lblMessage.Height + (this.MinimumSize.Height - lblMessage.MinimumSize.Height);
            flowLayoutPanel1.Left = (this.Width - flowLayoutPanel1.Width) / 2;
            //button location



            //this.BackgroundImageLayout = ImageLayout.Tile;
            //this.BackgroundImage = Utility.ChangeImageSize(Properties.Resources.MessageBoxScreen, this.Size);
            //close button location
            //btnClose.Left = lblMessage.Left + lblMessage.Width;
            //btnClose.Left = this.Width - (btnClose.Width * 3);         
        }

        #region Dialogresults

        public string Title { get { return this.Text; } set { this.Text = value; } }

        public DialogResult Show(string Message, string Title, Form OwnerForm, MessageBoxButtons MsgButtons)
        {
            this.Title = Title;
            this.Owner = OwnerForm;
            return Show(Message, MsgButtons);
        }
        public DialogResult Show(string Message, string Title, MessageBoxButtons MsgButtons)
        {
            this.Title = Title;
            return Show(Message, MsgButtons);
        }
        /// <summary>
        /// Displays the Message Box and sets the owner form too.
        /// </summary>
        /// <param name="pMessage">The message to be displayed</param>
        /// <param name="pMsgButtons">The Buttons to be displayed</param>
        /// <returns>Returns the Dialog Result </returns>
        public DialogResult Show(Form OwnerForm, string Message, MessageBoxButtons MsgButtons)
        {
            try
            {
                this.Owner = OwnerForm;
            }
            catch { }
            return Show(Message, MsgButtons);
        }

        /// <summary>
        /// Displays the Message Box
        /// </summary>
        /// <param name="pMessage">The message to be displayed</param>
        /// <param name="pMsgButtons">The Buttons to be displayed</param>
        /// <returns>Returns the Dialog Result </returns>
        public DialogResult Show(string pMessage, MessageBoxButtons pMsgButtons)
        {
            MsgButtons = pMsgButtons;
            mMessage = pMessage;
            //this.Owner = null;
            try
            {
                if (lblMessage.InvokeRequired)
                    lblMessage.BeginInvoke(new myDelegate(ThreadProcShowDialogBox));
                else
                    ThreadProcShowDialogBox();
            }
            catch
            {
                //ThreadProcShowDialogBox();
            }

            return btnPressed;
        }

        private void ThreadProcShowDialogBox()
        {

            lblMessage.Text = mMessage;

            label1.Text = mMessage;

            btnOk.Visible = btnCancel.Visible = btnNo.Visible = btnYes.Visible = false;
            switch (MsgButtons)
            {
                case MessageBoxButtons.AbortRetryIgnore:
                    break;
                case MessageBoxButtons.OK:
                    btnOk.Visible = true;
                    btnOk.Select();
                    btnOk.Focus();
                    flowLayoutPanel1.Width = btnOk.Width + btnOk.Margin.All * 2;
                    break;
                case MessageBoxButtons.OKCancel:
                    btnOk.Visible = true;
                    btnCancel.Visible = true;
                    btnOk.Select();
                    btnOk.Focus();
                    flowLayoutPanel1.Width = btnOk.Width + btnOk.Margin.All * 4 + btnCancel.Width;
                    break;
                case MessageBoxButtons.RetryCancel:
                    break;
                case MessageBoxButtons.YesNo:
                    btnYes.Visible = true;
                    btnNo.Visible = true;
                    btnYes.Select();
                    btnYes.Focus();
                    flowLayoutPanel1.Width = btnYes.Width + btnYes.Margin.All * 4 + btnNo.Width;

                    break;
                case MessageBoxButtons.YesNoCancel:
                    btnYes.Visible = true;
                    btnNo.Visible = true;
                    btnCancel.Visible = true;
                    btnYes.Select();
                    btnYes.Focus();
                    flowLayoutPanel1.Width = btnYes.Width + btnYes.Margin.All * 6 + btnNo.Width + btnCancel.Width;
                    break;
                default:
                    break;
            }
            ChangeFormSize();

            this.ShowDialog();

        }

        #endregion

        #region buttonclicks
        private void btnOk_Click(object sender, EventArgs e)
        {
            ReturnResult(DialogResult.OK);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            ReturnResult(DialogResult.No);
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            ReturnResult(DialogResult.Yes);
        }
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            ReturnResult(DialogResult.Ignore);
        }
        private void ReturnResult(DialogResult pResult)
        {
            btnPressed = pResult;
            this.Close();
        }
        #endregion

        //private void frmMessageBox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == 1)
        //    {
        //        MessageBox.Show(this.Name + ": Control Name : " + this.ActiveControl.Name, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

    }
}

