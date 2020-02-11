using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
namespace Bsoft.AppCom.UserMgtWithRole
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class lstRights_User_Group : Friuts.ListingFormBase
    {
        public string userid = "";
        public lstRights_User_Group()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            TableName = "SuperAdmin_Rights_Roles";
            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("Title", ColumnTypes.String, "colTitle");
            DataTableColumns.Add("Remarks", ColumnTypes.String, "colRemarks");
        }

        private void List_Load(object sender, EventArgs e)
        {
            LoadData();
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
            return base.OpenEditForm(new entRights_User_Group(  ));
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new entRights_User_Group(  ));
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
            UEMS.Reports.ExcelReport excel = new UEMS.Reports.ExcelReport(this.Text, 4, grid);
        }
    }
}