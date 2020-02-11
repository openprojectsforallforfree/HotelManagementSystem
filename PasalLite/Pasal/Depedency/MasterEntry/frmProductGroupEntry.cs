using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
namespace Pasal.MasterEntry
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmProductGroupEntry : Friuts.EntryFormBase
    {
        public frmProductGroupEntry()
        {
            InitializeComponent();

            TableName = "Product_Group_Master";
            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId, true, false);
            ColumnList.Add("Name", ColumnTypes.String, txtName, true, "Name", string.Empty);
            ColumnList.AddNewEditColumn("Description", ColumnTypes.String, txtDescription);
            ColumnList.AddNewEditColumn("code", ColumnTypes.String, txtCode );

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
            string a =InsertSQL;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmProductGroupEntry_Load(object sender, EventArgs e)
        {
            this.FirstControl = txtName ;
            txtName.Select();
        }
    }
}
