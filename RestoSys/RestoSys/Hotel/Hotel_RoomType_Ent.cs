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
    public partial class Hotel_RoomType_Ent : Friuts.EntryFormBase
    {
        public Hotel_RoomType_Ent()
        {
            InitializeComponent();
        }

        public Hotel_RoomType_Ent(string TableName_)
        {
            TableName = TableName_;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Hotel_RoomType_Ent_Load(object sender, EventArgs e)
        {
            //<Entry>
TableName = "Hotel_RoomType";
ColumnList.AddNewEditColumn("Id",ColumnTypes.Number, txtId ,true ,false );
ColumnList.AddNewEditColumn("Title",ColumnTypes.String, txtTitle );
ColumnList.AddNewEditColumn("Remarks",ColumnTypes.String, txtRemarks );

         
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
