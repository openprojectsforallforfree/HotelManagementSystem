using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace UEMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmAboutBox frmSplash = new frmAboutBox();
            frmSplash.ShowDialog();
            //  Application.Run(new UEMS.MainForm ());//final
           // string s = Bsoft.Common.Language.LanguageString .Language.LanguageString Utility.getCulture("Nepali");
            Application.Run(new UEMS .MainForm        ());
        }
    }
}
