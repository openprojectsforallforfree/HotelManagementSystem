using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
namespace Pasal.Forms
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmCustomer : Friuts.EntryFormBase
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {

            TableName = "Customer_Master";
            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId , true, false);
            ColumnList.AddNewEditColumn("Name", ColumnTypes.String, txtName);
            ColumnList.AddNewEditColumn("LastName", ColumnTypes.String, txtLastName);
          //  ColumnList.AddNewEditColumn("Userid", ColumnTypes.String, txtUserid);
            ColumnList.AddNewEditColumn("Email", ColumnTypes.String, txtEmail);
            ColumnList.AddNewEditColumn("Phone", ColumnTypes.String, txtPhone);
            ColumnList.AddNewEditColumn("Address", ColumnTypes.String, txtAddress);
            ColumnList.AddNewEditColumn("Remarks", ColumnTypes.String, txtRemarks);
            FirstControl = txtName;
        }
    }
}

