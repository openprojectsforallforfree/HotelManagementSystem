using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
namespace RestoSys.MasterEntry
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmProductCompanyList : Friuts.ListingFormBase
    {
        public frmProductCompanyList()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;

            TableName = "Master_Product_Company";
            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("Name", ColumnTypes.String, "colName");
            DataTableColumns.Add("Address", ColumnTypes.String, "colAddress");
            DataTableColumns.Add("Phone", ColumnTypes.String, "colPhone");
            DataTableColumns.Add("Email", ColumnTypes.String, "colEmail");

        }

        private void newToolbar_Click(object sender, EventArgs e)
        {
            OpenNewForm();
        }

        private void EditToolbar_Click(object sender, EventArgs e)
        {
            OpenEditForm();
        }
        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new frmProductCompanyEntry ());
        }


        public override bool OpenEditForm()
        {
            return base.OpenEditForm(new frmProductCompanyEntry());
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void ExportToolbar_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolbar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmProductCompanyList_Load(object sender, EventArgs e)
        {

        }
    }
}
