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
    public partial class frmEntrySample : Friuts.EntryFormBase
    {
        public frmEntrySample()
        {
            InitializeComponent();
            //<Entry>
        }

        public frmEntrySample(string TableName_):this()
        {
            TableName = TableName_;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
             Save();
        }

        private void frmEntrySample_Load(object sender, EventArgs e)
        {
           
         
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}