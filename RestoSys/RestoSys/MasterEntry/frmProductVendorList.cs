using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using UEMS.Reports;
namespace RestoSys.MasterEntry
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmProductVendorList : Friuts.ListingFormBase
    {
        public frmProductVendorList()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
        }

        private void frmProductVendorList_Load(object sender, EventArgs e)
        {

            TableName = "Master_Vendor";
            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("Name", ColumnTypes.String, "colName");
            DataTableColumns.Add("Address", ColumnTypes.String, "colAddress");
            DataTableColumns.Add("Phone", ColumnTypes.String, "colPhone");
            DataTableColumns.Add("Email", ColumnTypes.String, "colEmail");

        }

        private void newToolbar_Click(object sender, EventArgs e)
        {
            OpenNewForm( );
        }

        private void EditToolbar_Click(object sender, EventArgs e)
        {
            OpenEditForm( );
        }
        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new frmProductVendorEntry());
        }


        public override bool OpenEditForm()
        {
            return base.OpenEditForm(new frmProductVendorEntry());
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void ExportToolbar_Click(object sender, EventArgs e)
        {
            ExcelReport excel = new ExcelReport(this.Text, 4, grid);
        }

        private void ExitToolbar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
