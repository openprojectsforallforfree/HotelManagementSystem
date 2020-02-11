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
    public partial class CustomerType_Ent : Friuts.EntryFormBase
    {
        public CustomerType_Ent()
        {
            InitializeComponent();
        }

        public CustomerType_Ent(string TableName_)
        {
            TableName = TableName_;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
           // Save();
        }

        private void CustomerType_Ent_Load(object sender, EventArgs e)
        {
            //<Entry>
TableName = "CustomerType";
ColumnList.AddNewEditColumn("Id",ColumnTypes.Number, txtId ,true ,false );
ColumnList.AddNewEditColumn("Title",ColumnTypes.String, txtTitle );
ColumnList.AddNewEditColumn("DiscountPercent",decimal(20,5), txtDiscountPercent );
ColumnList.AddNewEditColumn("Remarks",ColumnTypes.String, txtRemarks );

         
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
