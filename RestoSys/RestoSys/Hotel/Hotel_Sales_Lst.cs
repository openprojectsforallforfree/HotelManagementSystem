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
    public partial class Hotel_Sales_Lst: Friuts.ListingFormBase
    {
        public delegate void gridChanged(DataGridView  grid);
        public event gridChanged GridChanged;
        public Hotel_Sales_Lst()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = grid;
            TableName = "Hotel_Sales";
            DataTableColumns.Add("Id", ColumnTypes.Number, "colId", true, true);
            DataTableColumns.Add("id", ColumnTypes.Number, "colid");
            DataTableColumns.Add("fk_Master_Customer", ColumnTypes.Number, "colfk_Master_Customer");
            
            DataTableColumns.Add("fk_Product", ColumnTypes.Number, "colfk_Product");
            RelationList.Add("fk_Product", "Master_Product", "id", "Name", "colProductName");
            DataTableColumns.Add("bookingstaus", ColumnTypes.String, "colbookingstaus");
            DataTableColumns.Add("Rate", ColumnTypes.AmountRound, "colRate");
            DataTableColumns.Add("Quantity", ColumnTypes.AmountRound, "colQuantity");
            DataTableColumns.Add("Amount", ColumnTypes.AmountRound, "colAmount");
            DataTableColumns.Add("Discount", ColumnTypes.AmountRound, "colDiscount");
            DataTableColumns.Add("VAT", ColumnTypes.AmountRound, "colVAT");
            DataTableColumns.Add("ServiceCharge", ColumnTypes.AmountRound, "colServiceCharge");
            DataTableColumns.Add("NetAmount", ColumnTypes.AmountRound, "colNetAmount");
            DataTableColumns.Add("dueamt", ColumnTypes.AmountRound, "coldueamt");
            DataTableColumns.Add("Remarks", ColumnTypes.String, "colRemarks");
            DataTableColumns.Add("Date", ColumnTypes.String, "colDate");
            DataTableColumns.Add("UserId", ColumnTypes.String, "colUser");
            DataTableColumns.Add("fk_purchage", ColumnTypes.Number, "colfk_purchage");
            DataTableColumns.Add("CostPrice", ColumnTypes.AmountRound, "colCostPrice");
            DataTableColumns.Add("canceldate", ColumnTypes.String, "colcanceldate");
            DataTableColumns.Add("indate", ColumnTypes.String, "colindate");
            DataTableColumns.Add("outDate", ColumnTypes.String, "coloutDate");


  
        }

        private void List_Load(object sender, EventArgs e)
        {
            //<Listing>

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
            Hotel_Sales_Ent h = new Hotel_Sales_Ent();
            h.CustomerId = _customerId;
            return base.OpenEditForm(h);
        }

        public override bool OpenNewForm()
        {
            Hotel_Sales_Ent h = new Hotel_Sales_Ent();
            h.CustomerId = _customerId;
            return base.OpenNewForm(h);
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            Delete();
        }

        
        private void ExportToolbar_Click(object sender, EventArgs e)
        {
            Reports.ExcelReport excel = new Reports.ExcelReport(this.Text, 4, grid);
        }

        string _customerId = "";
        public bool LoadData(string customerId)
        {
            _customerId = customerId;
           // lblCustomer.Text = "Bookings for customer : " + CustomerDAL.GetCustomerName(customerId);
            return LoadData();
        }

        public override bool LoadData()
        {
            SearchConditionList.Clear();
            SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_Master_Customer", ComparisionTypes.EQUAL, _customerId);
            bool b= base.LoadData();
            GridChanged(grid );
            return b;
        }

        
    }
}
