using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;

namespace Bsoft.CrystalReport
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmCrViewer : Form
    {
        #region Member Variables
        private ReportDocument rptdmt;
        private ReportSourceType ReportSourceTyp = ReportSourceType.Others;
        private string ReportName;
        private string sFormula;
        #endregion

        #region Properties
        //Setting Papers Size
        private static PaperSize _paperSize = PaperSize.DefaultPaperSize;
        public static PaperSize PaperSize
        {
            get { return frmCrViewer._paperSize; }
            set { frmCrViewer._paperSize = value; }
        }

        //Setting Papers Orientiation
        private static PaperOrientation _paperOrientiation = PaperOrientation.DefaultPaperOrientation;
        public static  PaperOrientation PaperOrientiation
        {
            get { return frmCrViewer._paperOrientiation; }
            set { frmCrViewer._paperOrientiation = value; }
        }

        //Setting Zoom Percentage of Report on display
        //By default Zoom Percentage=100
        private static int _zoomPercentage = 100;
        public static int ZoomPercentage
        {
            get { return frmCrViewer._zoomPercentage; }
            set { frmCrViewer._zoomPercentage = value; }
        }

        private static string _dbServerName = string.Empty;
        public static string DbServerName
        {
            get { return frmCrViewer._dbServerName; }
            set { frmCrViewer._dbServerName = value; }
        }


        private static string _dbUserName = string.Empty;
        public static string DbUserName
        {
            get { return frmCrViewer._dbUserName; }
            set { frmCrViewer._dbUserName = value; }
        }


        private static string _dbUserPassword = string.Empty;
        public static string DbUserPassword
        {
            get { return frmCrViewer._dbUserPassword; }
            set { frmCrViewer._dbUserPassword = value; }
        }
        #endregion

        #region Constructors
        public frmCrViewer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ReportOptin:1 for Database Related Report and 2 for Simple report. 
        /// </summary>
        /// <param name="_reportOption"></param>
        /// <param name="_rptdmt"></param>
        /// <param name="_ReportName"></param>
        /// <param name="_sFormula"></param>
        public frmCrViewer(ReportSourceType _reportSourcType, ReportDocument _rptdmt
              , string _ReportName
              , string _sFormula)
        {
            this.ReportSourceTyp = _reportSourcType;
            this.rptdmt = _rptdmt;
            this.ReportName = _ReportName;
            this.sFormula = _sFormula;
            InitializeComponent();
        }
        
        /// <summary>
        /// ReportOption=3 : Use This class to directly print CrustalReport. The source should be DataTable
        /// </summary>
        /// <param name="_reportOption"></param>
        /// <param name="_rptdmt"></param>
        public frmCrViewer(ReportDocument _rptdmt)
        {
            this.rptdmt = _rptdmt;
            InitializeComponent();
            PrintDirectly();
        }

        #endregion

        private void frmCrViewer_Load(object sender, EventArgs e)
        {
            if (ReportSourceTyp==ReportSourceType.DataBaseType)
            {
                LoadDataReport();
            }
            else if (ReportSourceTyp==ReportSourceType.DataSetType)
            {
                LoadSimpleReport();
            }
        }

        #region User Defined Methods For displaying Reports
        //Loads Report which contains Database fields
        private void LoadDataReport()
        {
            //Creates connection to Datasource Dynamically at runtuime
            ConnectionInfo connection = new ConnectionInfo();
            TableLogOnInfo tableLogin = new TableLogOnInfo();
            connection = rptdmt.Database.Tables[0].LogOnInfo.ConnectionInfo;
            connection.DatabaseName = "";
            connection.ServerName = DbServerName;
            connection.UserID = DbUserName;
            connection.Password = DbUserPassword;
            string DbNameForLocation = DbUserName.ToUpper();

            Database db = rptdmt.Database;
            Tables tables = db.Tables;
            foreach (Table table in tables)
            {
                tableLogin = table.LogOnInfo;
                tableLogin.ConnectionInfo = connection;
                table.ApplyLogOnInfo(tableLogin);
                table.Location = DbNameForLocation + "." + table.Name;  //Datase User Name should be in Uppercase
            }

            rptdmt.RecordSelectionFormula = sFormula;
            crViewer.ReportSource = rptdmt;
        }

        //Loads report which does not contain Database fields.
        private void LoadSimpleReport()
        {
            rptdmt.Database.Dispose();
            rptdmt.PrintOptions.PaperSize = PaperSize;
            rptdmt.PrintOptions.PaperOrientation = PaperOrientiation;
            crViewer.ReportSource = rptdmt;
            crViewer.Zoom(ZoomPercentage);
        }

        //This Method Prints the report Directly Without Previewing it
        private void PrintDirectly()
        {
            crViewer.ReportSource = rptdmt;
            rptdmt.PrintOptions.PaperSize = PaperSize;
            rptdmt.PrintOptions.PaperOrientation = PaperOrientiation;
            crViewer.RefreshReport();
            crViewer.PrintReport();
        }
        #endregion
    }
}