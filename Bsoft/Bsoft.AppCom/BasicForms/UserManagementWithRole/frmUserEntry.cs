using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using Bsoft.Languages;
namespace Bsoft.AppCom.UserMgtWithRole
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmUserEntry : Friuts.EntryFormBase
    {
        public frmUserEntry()
        {
            InitializeComponent();
            Text = "Users of the System";
            this.AcceptButton = btnOk;
            this.CancelButton = btnCancel;
            lblUSERSTATUS.Text = Language.LanguageString.Active;
           
        }

        private void frmUserEntry_Load(object sender, EventArgs e)
        {
            ComboUtilities.LoadData("id", "Title", "SuperAdmin_Rights_Roles", cboRightGroups, true, string.Empty);
            this.FirstControl = txtName ;
            TableName = "SuperAdmin_Rights_Users";

            ColumnList.AddNewEditColumn("USERSTATUS", ColumnTypes.String, chkUSERSTATUS);


            ColumnList.Add ("Id", ColumnTypes.Number, txtId,true ,false );
            ColumnList.Add("ENGNAME", ColumnTypes.String, txtName, true, "Name", string.Empty);
            ColumnList.Add("NEPNAME", ColumnTypes.String, txtNEPNAME);
            ColumnList.Add("Userid", ColumnTypes.String, txtUserid, true, "Userid", string.Empty);
           
            ColumnList.Add("Email", ColumnTypes.String, txtEmail);
            ColumnList.Add("Phone", ColumnTypes.String, txtPhone);
            
            ColumnList.Add("Address", ColumnTypes.String, txtAddress);
            ColumnList.Add("fk_Group", ColumnTypes.Number , cboRightGroups );
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUserid_Validated(object sender, EventArgs e)
        {
            txtUserid.Text = txtUserid.Text.ToLower();
        }

        

     
    }
}
