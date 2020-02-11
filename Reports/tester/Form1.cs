using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Reports;
using System.IO;

namespace tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Reports.connections.EstablishDBConnection(Properties.Settings.Default.Configstring);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ReportName = @"C:\Dhiraj\WorkingFolder\NGOR\Reports\Reports\Build\rptFiles\QuestionReport.rpt";
            QuestionsReport.GetReport(ReportName);
        }
    }
}
