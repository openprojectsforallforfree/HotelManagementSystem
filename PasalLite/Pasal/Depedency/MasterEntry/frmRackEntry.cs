using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrudeFx;
namespace Pasal.MasterEntry
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmRackEntry : CrudeFx.EntryFormBase
    {
        public frmRackEntry()
        {
            InitializeComponent();
            this.FirstControl = txtRackNumber;
        }

        private void Entry_Load(object sender, EventArgs e)
        {
           
            TableName = "Rack_Master";
            ColumnList.AddNewEditColumn("id", ColumnTypes.Number, txtid, true, false);
            ColumnList.AddNewEditColumn("RackNumber", ColumnTypes.Number, txtRackNumber);
            ColumnList.AddNewEditColumn("Description", ColumnTypes.String, txtDescription);
            
            txtRackNumber.Select();
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
