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
    public partial class TagGroup_Ent : Friuts.EntryFormBase
    {
        public TagGroup_Ent()
        {
            InitializeComponent();
        }

        public TagGroup_Ent(string TableName_)
        {
            TableName = TableName_;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void TagGroup_Ent_Load(object sender, EventArgs e)
        {
            //<Entry>
            TableName = "TagGroup";
            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId, true, false);
            ColumnList.AddNewEditColumn("Title", ColumnTypes.String, txtTitle);
            ColumnList.AddNewEditColumn("TagTypeId", ColumnTypes.String, cmbTagTypeId);
            ComboUtilities.LoadData("Id", "Title", "TagType", cmbTagTypeId, false,string .Empty );
            ColumnList.AddNewEditColumn("Remarks", ColumnTypes.String, txtRemarks);


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
