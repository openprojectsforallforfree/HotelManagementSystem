using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestoSys.Reports
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmExpiryDetails : Friuts.EntryFormBase
    {
        public frmExpiryDetails()
        {
            InitializeComponent();
        }

        private void ExportToolbar_Click(object sender, EventArgs e)
        {
            UEMS.Reports.ExcelReport exrept = new UEMS.Reports.ExcelReport(this.Text, 4, grid);
        }

        private void frmExpiryDetails_Load(object sender, EventArgs e)
        {
            grid.DataSource = RestoSys.BLL.ExpiryAlert.GetExpringItemsDetails(DateTime.Now);
        }
    }
}
