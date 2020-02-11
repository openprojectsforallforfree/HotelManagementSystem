using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using Bsoft.Languages;
namespace Bsoft.AppCom.UserMgtSimple
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class SuperAdmin_Rights_Users_Lst : Friuts.ListingFormBase
    {
        public SuperAdmin_Rights_Users_Lst()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;

            colUserid.HeaderText = Language.LanguageString.UserId;

            //colNEPNAME.HeaderText = Language.LanguageString.User;
            colENGNAME.HeaderText = Language.LanguageString.UserName;
            colUSERSTATUS.HeaderText = Language.LanguageString.Active ;
            colLASTLOGGEDON.HeaderText = Language.LanguageString.LastLoginDate ;
            colLASTLOGGEDOUT.HeaderText = Language.LanguageString.LastLogoffDate ;
            colGRANTS.HeaderText = Language.LanguageString.UserId;
          //  colPersonId.HeaderText = Language.LanguageString.User;
            colPersonId.Visible = false;
        }

        private void List_Load(object sender, EventArgs e)
        {
            //<Listing>
            TableName = "SuperAdmin_Rights_Users";
            DataTableColumns.Add("id", ColumnTypes.Number, "colid", true, true);
            DataTableColumns.Add("Userid", ColumnTypes.String, "colUserid");
            //DataTableColumns.Add( "Pw",ColumnTypes.String,"colPw");
            DataTableColumns.Add("NEPNAME", ColumnTypes.String, "colNEPNAME");
            DataTableColumns.Add("ENGNAME", ColumnTypes.String, "colENGNAME");
            DataTableColumns.Add("USERSTATUS", ColumnTypes.String, "colUSERSTATUS");
            DataTableColumns.Add("LASTLOGGEDON", ColumnTypes.String, "colLASTLOGGEDON");
            DataTableColumns.Add("LASTLOGGEDOUT", ColumnTypes.String, "colLASTLOGGEDOUT");
            DataTableColumns.Add("GRANTS", ColumnTypes.String, "colGRANTS");
            DataTableColumns.Add("PersonId", ColumnTypes.Number, "colPersonId");

            LoadData();
        }


        private void newToolbar_Click(object sender, EventArgs e)
        {
            OpenNewForm();
        }

        private void EditToolbar_Click(object sender, EventArgs e)
        {
            OpenEditForm();
        }
        public override bool OpenEditForm()
        {
            return base.OpenEditForm(new SuperAdmin_Rights_Users_Ent());
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new SuperAdmin_Rights_Users_Ent());
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            Delete();
        }


        private void ExportToolbar_Click(object sender, EventArgs e)
        {
            UEMS.Reports.ExcelReport excel = new UEMS.Reports.ExcelReport(this.Text, 4, grid);
        }
    }
}
