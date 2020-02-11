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
    public partial class frmAccount : Friuts.EntryFormBase
    {
        public frmAccount()
        {
            InitializeComponent();
        }

      

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            //<Entry>
            TableName = "AccountGroup";

            //ComboUtilities("Id", "Name", "", "AccountGroup", cmbParentAccountGroupId, "Id != 1", this);

            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId , true, false);
            ColumnList.AddNewEditColumn("Name", ColumnTypes.String, txtName);
            ColumnList.AddNewEditColumn("Description", ColumnTypes.String, txtDescription);
            ColumnList.AddNewEditColumn("ParentAccountGroupId", ColumnTypes.Number, cmbParentAccountGroupId);

   
        }
    }
}