using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestoSys
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class FrmTablesSelector : Friuts.FormBase 
    {
        public FrmTablesSelector()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }


        public void AddTable(string tableName)
        {
            CheckBox b = new CheckBox();
            b.Text = tableName;
            b.Visible = true;
            flwTables . Controls.Add(b);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmTablesSelector_Load(object sender, EventArgs e)
        {

        }
         
    }
}
