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
    public partial class Customer_Master_Lst: Friuts.ListingFormBase
    {
        public Customer_Master_Lst()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
  
        }

        private void List_Load(object sender, EventArgs e)
        {
            //<Listing>
TableName = "Customer_Master";
DataTableColumns.Add( "Id",ColumnTypes.Number,"colId",true ,true);
DataTableColumns.Add( "Name",ColumnTypes.String,"colName");
DataTableColumns.Add( "LastName",ColumnTypes.String,"colLastName");
DataTableColumns.Add( "Userid",ColumnTypes.String,"colUserid");
DataTableColumns.Add( "Email",ColumnTypes.String,"colEmail");
DataTableColumns.Add( "Phone",ColumnTypes.String,"colPhone");
DataTableColumns.Add( "Address",ColumnTypes.String,"colAddress");
DataTableColumns.Add( "Remarks",ColumnTypes.String,"colRemarks");
DataTableColumns.Add( "fk_CustomerType",ColumnTypes.Number,"colfk_CustomerType");


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
            return base.OpenEditForm(new Customer_Master_Ent (TableName));
        }

        public override bool OpenNewForm()
        {
            return base.OpenNewForm(new Customer_Master_Ent(TableName));
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            Delete();
        }

        
        private void ExportToolbar_Click(object sender, EventArgs e)
        {
            Reports.ExcelReport excel = new Reports.ExcelReport(this.Text, 4, grid);
        }
    }
}
