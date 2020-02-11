using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
namespace UEMS
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class Customer_Master_Ent : Friuts.EntryFormBase
    {
        public Customer_Master_Ent()
        {
            InitializeComponent();
        }

        public Customer_Master_Ent(string TableName_)
        {
            TableName = TableName_;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
           // Save();
        }

        private void Customer_Master_Ent_Load(object sender, EventArgs e)
        {
            //<Entry>
TableName = "Customer_Master";
ColumnList.AddNewEditColumn("Id",ColumnTypes.Number, txtId ,true ,false );
ColumnList.AddNewEditColumn("Name",ColumnTypes.String, txtName );
ColumnList.AddNewEditColumn("LastName",ColumnTypes.String, txtLastName );
ColumnList.AddNewEditColumn("Userid",ColumnTypes.String, txtUserid );
ColumnList.AddNewEditColumn("Email",ColumnTypes.String, txtEmail );
ColumnList.AddNewEditColumn("Phone",ColumnTypes.String, txtPhone );
ColumnList.AddNewEditColumn("Address",ColumnTypes.String, txtAddress );
ColumnList.AddNewEditColumn("Remarks",ColumnTypes.String, txtRemarks );
ColumnList.AddNewEditColumn("fk_CustomerType",ColumnTypes.Number, txtfk_CustomerType );

         
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
