using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace Bsoft.CrystalReport
{
    public partial class  ReportBase
    {
        #region Member Variables
        public   ReportDocument _reportDocument = new ReportDocument();
        
        private PrinterProperties _printerProperties = new PrinterProperties();
        #endregion

        #region Properties
        

        
        /// <summary>
        /// Used to set Quotation Mark, supressing DataTable's repeated rows etc.
        /// </summary>
       

        /// <summary>
        /// Setting Printer Properties Like
        /// Papers Size, Papers Orientiation, Zoom Percentage etc
        /// </summary>
        public PrinterProperties PrinterProperties
        {
            get { return _printerProperties; }
            set { _printerProperties = value; }
        }




        #endregion

        /// <summary>
        ///Loads the report specified in Reports Name
        /// </summary>
        /// <param name="ReportsName"></param>
        public void LoadReport(string ReportsName)
        {
            _reportDocument.Load(ReportsName);
        }

        /// <summary>
        /// Method for displaying Report
        /// </summary>
        /// <param name="_rptdmt"></param>
        /// <param name="_reportName"></param>
        /// <param name="_selectionFormula"></param>
        /// <param name="_directPrint"></param>
        /// <returns></returns>
        public bool DisplayReport(string _reportName, string _selectionFormula, bool _directPrint, ReportSourceType _reportSourceType)
        {
            if (_directPrint == false)
            {
                frmCrViewer frm = new frmCrViewer(_reportSourceType, _reportDocument, _reportName, _selectionFormula);
                frm.Show();
            }
            else
            {
                frmCrViewer frmcv = new frmCrViewer(_reportDocument);
            }
            return true;
        }
    }

    #region Enum for Crystal Reports DataSource Type
    public enum ReportSourceType
    {
        DataSetType = 0,
        DataBaseType,
        Others
    }
    #endregion
}
