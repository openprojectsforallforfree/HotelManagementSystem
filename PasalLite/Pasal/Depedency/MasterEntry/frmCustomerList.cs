using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using UEMS.Reports;
namespace Pasal.Forms
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmCustomerList : Friuts.ListingFormBase
    {
        public frmCustomerList()
        {
            InitializeComponent();
            Text = "Customer List";
            ListingDataGridView = grid;
            this.FormType = FormTypes.ListingForm;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newToolbar_Click(object sender, EventArgs e)
        {
            OpenNewForm();
        }

        private void EditToolbar_Click(object sender, EventArgs e)
        {
            OpenEditForm();
        }
        public override bool OpenEditForm()
        {
            return base.OpenEditForm(new frmCustomer ());
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new frmCustomer());
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            Delete();
        }



        private void ExitToolbar_Click(object sender, EventArgs e)
        {
            Close();
        }

      

        private void ExportToolbar_Click(object sender, EventArgs e)
        {
            ExcelReport exrept = new  ExcelReport(this.Text, 4, grid);
        }

        private void frmCustomerList_Load(object sender, EventArgs e)
        {
           // FormType = FormTypes.ListingForm;
           
            TableName = "Customer_Master";
            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("Name", ColumnTypes.String, "colName");
            DataTableColumns.Add("LastName", ColumnTypes.String, "colLastName");
           // DataTableColumns.Add("Userid", ColumnTypes.String, "colUserid");
            DataTableColumns.Add("Email", ColumnTypes.String, "colEmail");
            DataTableColumns.Add("Phone", ColumnTypes.String, "colPhone");
            DataTableColumns.Add("Address", ColumnTypes.String, "colAddress");
            DataTableColumns.Add("Remarks", ColumnTypes.String, "colRemarks");
            LoadData();
        }
    }
}

