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
    public partial class TagType_Ent : Friuts.EntryFormBase
    {
        public TagType_Ent()
        {
            InitializeComponent();
        }

        public TagType_Ent(string TableName_)
        {
            TableName = TableName_;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void TagType_Ent_Load(object sender, EventArgs e)
        {
            //<Entry>
            TableName = "TagType";
            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId, true, false);
            ColumnList.AddNewEditColumn("Title", ColumnTypes.String, txtTitle);
            ColumnList.AddNewEditColumn("Remarks", ColumnTypes.String, txtRemarks);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
