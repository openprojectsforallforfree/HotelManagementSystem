using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using UEMS.Reports;
namespace RestoSys.Forms
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

            ComboBoxDataLoader loader = new ComboBoxDataLoader();
            loader.FormName = this;
            loader.ComboLoadinfoItems.Add("ID", "Title", "Master_CustomerType", cboCustomerType, false);
            loader.LoadDataInComboBoxes();


            TableName = "Master_Customer";
            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("Name", ColumnTypes.String, "colName");
            DataTableColumns.Add("LastName", ColumnTypes.String, "colLastName");
            DataTableColumns.Add("IdNumber", ColumnTypes.String, "colIdNumber");
            DataTableColumns.Add("Email", ColumnTypes.String, "colEmail");
            DataTableColumns.Add("Phone", ColumnTypes.String, "colPhone");
            DataTableColumns.Add("Address", ColumnTypes.String, "colAddress");
            DataTableColumns.Add("Remarks", ColumnTypes.String, "colRemarks");
            RelationList.Add("fk_Master_CustomerType", "Master_CustomerType", "id", "Title", "colMaster_CustomerType");
          //  DataTableColumns.Add("fk_Master_CustomerType", ColumnTypes.Number, "colfk_Master_CustomerType");
            LoadData();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ReturnSelectedValue();
            DialogResult = DialogResult.OK;
        }

        

        public override string GetWhereClauseForSelect()
        {
            StringBuilder SQL = new StringBuilder();
            ComboItem citem;
            SQL.AppendLine("WHERE 1=1 ");
            if (cboCustomerType.Text != "")
            {
                citem = (ComboItem)cboCustomerType.SelectedItem;

                SQL.Append(" \n AND  fk_Master_CustomerType=" + citem.Key.ToString());
            }

            if (txtName.Text.Trim() != "")
            {
                SQL.AppendFormat(" \n AND (Name like '%{0}%' or LastName like '%{0}%' )", txtName.Text.Trim());
            }
            if (txtIdNumber.Text.Trim() != "")
            {
                SQL.AppendFormat(" \n AND (IDnumber like '%{0}%')", txtIdNumber.Text.Trim());
            }
            return SQL.ToString();
        }

        public override bool GenerateSelectSQL()
        {

            bool b = base.GenerateSelectSQL();
            SelectSQL = SelectSQL + " order by t1.id desc";
            return b;
        }

        private void cboCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtName_TextChanged_1(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}

