using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
namespace Bsoft.AppCom.UserMgtWithRole
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmUserListing : Friuts.ListingFormBase
    {
        public frmUserListing()
        {
            InitializeComponent();
            Text  = "Users of the System";
            TableName = "SuperAdmin_Rights_Users";
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;

            DataTableColumns.Add("id", ColumnTypes.Number, "colid", true, true);
            DataTableColumns.Add("Userid", ColumnTypes.String, "colUserid");
            //DataTableColumns.Add( "Pw",ColumnTypes.String,"colPw");
            DataTableColumns.Add("NEPNAME", ColumnTypes.String, "colNEPNAME");
            DataTableColumns.Add("ENGNAME", ColumnTypes.String, "colENGNAME");
            DataTableColumns.Add("CASE WHEN USERSTATUS = '1' THEN 'Active'  Else 'InActive' END u", ColumnTypes.String, "colUSERSTATUS", false, true, true, "u");

            DataTableColumns.Add("LASTLOGGEDON", ColumnTypes.EnglishDate , "colLASTLOGGEDON");
            DataTableColumns.Add("LASTLOGGEDOUT", ColumnTypes.EnglishDate, "colLASTLOGGEDOUT");
            //DataTableColumns.Add("GRANTS", ColumnTypes.String, "colGRANTS");
            RelationList.Add("fk_Group", "SuperAdmin_Rights_Roles", "id", "Title", "colGRANT");
           // DataTableColumns.Add("PersonId", ColumnTypes.Number, "colPersonId");
            DataTableColumns.Add("Email", ColumnTypes.String, "colEmail");
            DataTableColumns.Add("Phone", ColumnTypes.String, "colPhone");
            DataTableColumns.Add("Address", ColumnTypes.String, "colAddress");


        }

        private void newToolbar_Click(object sender, EventArgs e)
        {
            OpenNewForm();
        }

        private void EditToolbar_Click(object sender, EventArgs e)
        {
            OpenEditForm();
        }

        public override bool OpenNewForm()
        {
            frmUserEntry frm = new frmUserEntry();
            frm.FormType = FormTypes.EntryForm ;
            //return base.OpenEditForm(frm);
            return base.OpenNewForm(frm );
        }


        public override bool OpenEditForm()
        {
            frmUserEntry frm = new frmUserEntry();
            frm.FormType = FormTypes.EditForm;
            return base.OpenEditForm(frm);
        }
        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void ExitToolbar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmUserListing_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
