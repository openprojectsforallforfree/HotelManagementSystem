using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
namespace Pasal.Inventory
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmDamageLossList : Friuts.ListingFormBase
    {
        public frmDamageLossList()
        {

            InitializeComponent();
            MessageBox.Show("you should not reach here");
        }
        ProductEntryType Productentrytype;
        public frmDamageLossList(ProductEntryType ProductEntryType_)
        {
            Productentrytype = ProductEntryType_;

            InitializeComponent();

            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;


            switch (Productentrytype)
            {
                case ProductEntryType.Sales:
                    break;
                case ProductEntryType.damageLoss:
                    TableName = "Inv_Damage_Loss_Return";
                    Text = "Damage Lost Report";
                    break;
                case ProductEntryType.salesReturn:
                    TableName = "Inv_Sales_Return";
                    Text = "Sales Return Report";
                    break;
                case ProductEntryType.purchageReturn:
                    TableName = "Inv_Purchase_Return";
                    Text = "Purchase Return Report";
                    break;
                default:
                    break;
            }
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
            // return base.OpenEditForm(new frmDamageLossEntry());
            return false;
        }

        public override bool OpenNewForm()
        {
            // return base.OpenNewForm(new frmDamageLossEntry());
            return false;
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            Delete();
        }

        public override bool GenerateSelectSQL()
        {

            switch (Productentrytype)
            {
                case ProductEntryType.Sales:
                    break;
                case ProductEntryType.damageLoss:
                    SelectSQL = getSQL("Inv_Damage_Loss_Return");
                    break;
                case ProductEntryType.salesReturn:
                    SelectSQL = getSQL("Inv_Sales_Return");
                    break;
                case ProductEntryType.purchageReturn:
                    SelectSQL = getSQL("Inv_Purchase_Return");
                    break;
                default:
                    break;
            }
            return true;
        }



        public string getSQL(string tableName)
        {
            StringBuilder SQL = new StringBuilder();
            SQL.AppendFormat(@"
               SELECT 
                {0}.Id AS Id,
                {0}.fk_Purchage AS fk_Purchage,
                {0}.Quantity AS Quantity,
                {0}.Remarks AS Remarks,
                {0}.date AS date,
                Inv_Purchase.Id AS Inv_Purchase_Id,
                Vendor_Master.Name AS vendor,
                Inv_Purchase.Quantity AS Inv_Purchase_Quantity,
                Product_Master.Name AS Product_Master_Name,
                Product_Master.fk_Group AS Product_Master_fk_Group,
                Product_Company_Master.Name AS Product_Company_Master_Name
                FROM {0}
                Left join Inv_Purchase on Inv_Purchase.Id = {0}.fk_Purchage
                Left join Product_Master on Product_Master.Id = Inv_Purchase.fk_product 
                Left join Vendor_Master on Vendor_Master.Id = Inv_Purchase.fk_Vendor
                Left join Product_Company_Master on Product_Company_Master.Id = Product_Master.fk_Company  ",tableName );
            return SQL.ToString();
        }





        private void ExitToolbar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDamageLossList_Load(object sender, EventArgs e)
        {

            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("Product_Master_Name", ColumnTypes.Number, "colProductName");
            DataTableColumns.Add("Quantity", ColumnTypes.Number, "colQuantity");
            DataTableColumns.Add("Remarks", ColumnTypes.String, "colRemarks");
            DataTableColumns.Add("vendor", ColumnTypes.String, "colVendor");
            DataTableColumns.Add("Product_Company_Master_Name", ColumnTypes.String, "colCompany");
           // DataTableColumns.Add("user", ColumnTypes.String, "colUser");
            DataTableColumns.Add("date", ColumnTypes.String, "colDate");


        }

        private void ExportToolbar_Click(object sender, EventArgs e)
        {
            UEMS.Reports.ExcelReport exrept = new UEMS.Reports.ExcelReport(this.Text, 4, grid);
        }
    }
}
