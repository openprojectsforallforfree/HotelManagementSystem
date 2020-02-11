using System;
using System.Collections.Generic;

using System.Windows.Forms;
using Bsoft.Languages;
using Bsoft.AppCom;
using Bsoft.Data;
using System.Drawing;
 

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
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            Language.currentLanguage = LanguageChoice.Nepali   ;
            GlobalValues.dbEngine = Properties.Settings.Default.DbEngine;
         
            GlobalResources.ConnectionString = Properties.Settings.Default.Configstring;
            Bsoft.Design.FormDesginBase.DigitFont = new System.Drawing.Font("Shangrila Numeric", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Bsoft.Design.FormDesginBase.MainFont = new Font("Mangal", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           
            frmAboutBox frmSplash = new frmAboutBox();
            frmSplash.ShowDialog();
            //  Application.Run(new UEMS.MainForm ());//final
           // string s = Bsoft.Common.Language.LanguageUtility.getCulture("Nepali");
            //Application.Run(new test());

            try
            {

                //string ReportName = @"ReportFiles\QuestionReport.rpt";
                //NGOReports.QuestionsReport.GetReport(ReportName, "22");
               // Application.Run(new UEMS.test());

                 Application.Run(new UEMS.MainForm("dummy"));
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
