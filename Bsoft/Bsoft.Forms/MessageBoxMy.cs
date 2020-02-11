using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Bsoft.Forms
{
    public static class MessageBoxMy
    {
        #region Member variables.
         static frmMessageBox msgBox = new frmMessageBox();
        #endregion

        #region Constructors & Finalizers.
        #endregion

        #region Nested Enums, Structs, and Classes.
        #endregion

        #region Properties
        #endregion

        #region Methods
        public static DialogResult Show(Form owner, string message, MessageBoxButtons msgButtons)
        {
            return msgBox.Show(owner, message, msgButtons);
        }

        public static DialogResult Show(string message, MessageBoxButtons msgButtons)
        {
            return msgBox.Show(message, msgButtons);
        }
        public static DialogResult Show(string message)
        {
            return msgBox.Show(message, MessageBoxButtons.OK );
        }

        public static DialogResult Show(Form owner, string message, string title, MessageBoxButtons msgButtons)
        {
            return msgBox.Show(message, title, owner, msgButtons);
        }

        public static DialogResult Show(string message, string title, MessageBoxButtons msgButtons)
        {
            return msgBox.Show(message,title , msgButtons);
        }
        public static DialogResult Show(string message,string  title)
        {
            return msgBox.Show(message,title , MessageBoxButtons.OK);
        }

        #endregion
    }
}
