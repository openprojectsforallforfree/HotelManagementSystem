using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UEMS;
using Bsoft.Common.Language;
using System.Drawing;
using Bsoft.Languages;
using Bsoft.Common;
using Bsoft.AppCom;


namespace RestoSys
{
    static class Program
    {

        #region debug mode
        const bool debugmode = false ;

        #endregion
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Language.currentLanguage = LanguageChoice.English;

            //Bsoft.Design.FormDesginBase.myFont = new Font("Arial", 12);
            frmAboutBox frmSplash = new frmAboutBox();
            frmSplash.ShowDialog();

            RestoSys.MainForm._debugMode = false;
            //  Application.Run(new  RestoSys.Account.PaymentDetails ());  
            Application.Run(new RestoSys.MainForm_Restaurant ());

        }
    }
}
