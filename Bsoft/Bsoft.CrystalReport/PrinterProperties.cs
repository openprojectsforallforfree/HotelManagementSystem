using System;
using System.Collections.Generic;
using System.Text;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;

namespace Bsoft.CrystalReport
{
   public class PrinterProperties
    {
        //Setting Papers Size
        public PaperSize PaperSize
        {
            get { return frmCrViewer.PaperSize; }
            set { frmCrViewer.PaperSize = value; }
        }

        //Setting Papers Orientiation
        public PaperOrientation PaperOrientiation
        {
            get { return frmCrViewer.PaperOrientiation; }
            set { frmCrViewer.PaperOrientiation = value; }
        }
       
        //Setting Zoom Percentage of Report on display
        public int ZoomPercentage
        {
            get { return frmCrViewer.ZoomPercentage; }
            set { frmCrViewer.ZoomPercentage = value; }
        }

    }
}
