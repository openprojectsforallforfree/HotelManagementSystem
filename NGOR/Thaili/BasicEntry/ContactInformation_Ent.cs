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
    public partial class ContactInformation_Ent : Friuts.EntryFormBase
    {
        public ContactInformation_Ent()
        {
            InitializeComponent();
            TableName = "ContactInformation";
            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId, true, false);
            ColumnList.AddNewEditColumn("Phone", ColumnTypes.String, txtPhone);
            ColumnList.AddNewEditColumn("Fax", ColumnTypes.String, txtFax);
            ColumnList.AddNewEditColumn("Email", ColumnTypes.String, txtEmail);
            ColumnList.AddNewEditColumn("WebSite", ColumnTypes.String, txtWebSite);
            ColumnList.AddNewEditColumn("MobileNo", ColumnTypes.String, txtMobileNo);
            
        }

        

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void ContactInformation_Ent_Load(object sender, EventArgs e)
        {
            //<Entry>


         
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
