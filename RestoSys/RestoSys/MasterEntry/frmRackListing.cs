using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrudeFx;
namespace Pasal.MasterEntry
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmRackListing : CrudeFx.ListingFormBase
    {
        public frmRackListing()
        {
            InitializeComponent();
            
            
        }

        private void Listing_Load(object sender, EventArgs e)
        {
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;

            TableName = "Rack_Master";
            DataTableColumns.Add("id", ColumnTypes.Number, "colid", true, true);
            DataTableColumns.Add("RackNumber", ColumnTypes.Number, "colRackNumber");
            DataTableColumns.Add("Description", ColumnTypes.String, "colDescription");
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
            return base.OpenEditForm(new frmRackEntry ());
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new frmRackEntry ());
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            Delete();
        }

      

        private void ExitToolbar_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        
    }
}
