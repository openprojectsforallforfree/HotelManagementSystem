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
    public partial class OrderTables_Ent : Friuts.EntryFormBase
    {
        public OrderTables_Ent()
        {
            InitializeComponent();
        }

        public OrderTables_Ent(string TableName_)
        {
            TableName = TableName_;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
             Save();
        }

        private void OrderTables_Ent_Load(object sender, EventArgs e)
        {
            //<Entry>
TableName = "OrderTables";
ColumnList.AddNewEditColumn("Id",ColumnTypes.Number, txtId ,true ,false );
ColumnList.AddNewEditColumn("Name",ColumnTypes.String, txtName );
ColumnList.AddNewEditColumn("Remarks",ColumnTypes.String, txtRemarks );

         
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
