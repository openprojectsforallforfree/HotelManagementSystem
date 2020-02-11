using System;
using System.Collections.Generic;

using System.Windows.Forms;
using UEMS;

using Bsoft.Common.Language;
using System.Drawing;
using Bsoft.Languages;

namespace Pasal
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
            Language.currentLanguage = LanguageChoice.English    ;


            
            //Bsoft.Design.FormDesginBase.myFont = new Font("Arial", 12);
            frmAboutBox frmSplash = new frmAboutBox();
            frmSplash.ShowDialog();

           // Application.Run(new Pasal.Reports.frmTestBill());  
           

             try
             {
                 Application.Run(new Pasal.MainForm("load"));
             }
             catch (Exception ex)
             {
                 if (ex.Message.Contains("Cannot access a disposed object"))
                 {
                 }
                 else
                 {
                     throw;
                 }
             }

        }
    }
}
