using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
namespace RestoSys.Inventory
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmDamageLossList : Friuts.ListingFormBase
    {
        public frmDamageLossList()
        {

            InitializeComponent();
            MessageBox.Show("you should not reach here");
        }
        string Productentrytype;
        public frmDamageLossList(string ProductEntryType_)
        {
            Productentrytype = ProductEntryType_;

            InitializeComponent();

            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;

            TableName = "Inv_Stock";
            Text = StockType.GetEntryTypeText(Productentrytype) + " Report";
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
            SelectSQL = getSQL(Productentrytype);
            return true;
        }

        //fk_Master_Product
        //fk_Inv_Sale

        public string getSQL(string type)
        {
            string SQL = string.Format(@"
                SELECT 
                Inv_Stock.Id AS Id,
                Inv_Stock.fk_Inv_Purchase AS fk_Inv_Purchase,
                Inv_Stock.Quantity AS Quantity,
                Inv_Stock.Remarks AS Remarks,
                Inv_Stock.date AS date,
                Inv_Purchase.Id AS Inv_Purchase_Id,
                Master_Vendor.Name AS vendor,
                Inv_Purchase.Quantity AS Inv_Purchase_Quantity,
                Master_Product.Name AS Master_Product_Name,
                Master_Product.fk_Group AS Master_Product_fk_Group,
                Master_Product_Company.Name AS Master_Product_Company_Name
                FROM Inv_Stock
                Left join Inv_Purchase on Inv_Purchase.Id = Inv_Stock.fk_Purchage
                Left join Master_Product on Master_Product.Id = Inv_Purchase.fk_product 
                Left join Master_Vendor on Master_Vendor.Id = Inv_Purchase.fk_Vendor
                Left join Master_Product_Company on Master_Product_Company.Id = Master_Product.fk_Company
                where fk_StockModfType_Code  ='{0}' ", type);
            return SQL.ToString();
        }

        private void ExitToolbar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDamageLossList_Load(object sender, EventArgs e)
        {

            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("Master_Product_Name", ColumnTypes.Number, "colProductName");
            DataTableColumns.Add("Quantity", ColumnTypes.Number, "colQuantity");
            DataTableColumns.Add("Remarks", ColumnTypes.String, "colRemarks");
            DataTableColumns.Add("vendor", ColumnTypes.String, "colVendor");
            DataTableColumns.Add("Master_Product_Company_Name", ColumnTypes.String, "colCompany");
            // DataTableColumns.Add("user", ColumnTypes.String, "colUser");
            DataTableColumns.Add("date", ColumnTypes.EnglishDate , "colDate");


        }

        private void ExportToolbar_Click(object sender, EventArgs e)
        {
            UEMS.Reports.ExcelReport exrept = new UEMS.Reports.ExcelReport(this.Text, 4, grid);
        }
    }
}
