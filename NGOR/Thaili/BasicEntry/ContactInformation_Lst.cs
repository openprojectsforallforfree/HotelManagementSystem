using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using Bsoft.Common.Language;
using Bsoft.Languages;
namespace UEMS 
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class ContactInformation_Lst: Friuts.ListingFormBase
    {
        public ContactInformation_Lst()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            ChangeLanguage();
           // toolstrip = toolStrip1;
  
        }
        public void ChangeLanguage()
        {
            newToolbar.Text = Language. LanguageString.NewAdd;
            EditToolbar.Text = Language. LanguageString.Edit;
            DeleteToolbar.Text = Language. LanguageString.Delete;
            ExportToolbar.Text = Language. LanguageString.ExporttoExcel;

        }
        private void List_Load(object sender, EventArgs e)
        {
            //<Listing>
TableName = "ContactInformation";
DataTableColumns.Add( "Id",ColumnTypes.Number,"colId",true ,true);
DataTableColumns.Add( "Phone",ColumnTypes.String,"colPhone");
DataTableColumns.Add( "Fax",ColumnTypes.String,"colFax");
DataTableColumns.Add( "Email",ColumnTypes.String,"colEmail");
DataTableColumns.Add( "WebSite",ColumnTypes.String,"colWebSite");
DataTableColumns.Add( "MobileNo",ColumnTypes.String,"colMobileNo");


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
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
            return base.OpenEditForm(new ContactInformation_Ent ());
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new ContactInformation_Ent());
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void ExitToolbar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExportToolbar_Click(object sender, EventArgs e)
        {
            Reports.ExcelReport excel = new Reports.ExcelReport(this.Text, 4, grid);
        }
    }
}
