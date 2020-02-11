using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using Bsoft.Forms;
using Bsoft.AppCom;
using Bsoft.Common;
using RestoSys.Hotel;
namespace UEMS
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class hotel_sales_View_Lst : Friuts.ListingFormBase
    {
        public hotel_sales_View_Lst()
        {
            InitializeComponent();
            FormType = FormTypes.Report;
            ListingDataGridView = grid;
            //<Listing>
            TableName = "hotel_sales_View11";
            DataTableColumns.Add("id", ColumnTypes.Number, "colid", true, true);
            DataTableColumns.Add("AccID", ColumnTypes.Number, "colAccID");
            DataTableColumns.Add("fk_master_customer", ColumnTypes.Number, "colfk_master_customer");
            DataTableColumns.Add("fk_Product", ColumnTypes.Number, "colfk_Product");
            DataTableColumns.Add("bookingstaus", ColumnTypes.String, "colbookingstaus");
            DataTableColumns.Add("rate", ColumnTypes.AmountRound, "colrate");
            DataTableColumns.Add("Quantity", ColumnTypes.AmountRound, "colQuantity");
            DataTableColumns.Add("amount", ColumnTypes.AmountRound, "colamount");
            DataTableColumns.Add("discount", ColumnTypes.AmountRound, "coldiscount");
            DataTableColumns.Add("vat", ColumnTypes.AmountRound, "colvat");
            DataTableColumns.Add("servicecharge", ColumnTypes.AmountRound, "colservicecharge");
            DataTableColumns.Add("netamount", ColumnTypes.AmountRound, "colnetamount");
            DataTableColumns.Add("dueamt", ColumnTypes.AmountRound, "coldueamt");
            DataTableColumns.Add("date", ColumnTypes.EnglishDate, "coldate");
           //RelationList.Add("UserId", "SuperAdmin_Rights_Users", "id", "UserId", "colUser");
            DataTableColumns.Add("UserId", ColumnTypes.String, "colUser");
            DataTableColumns.Add("CustomerName", ColumnTypes.String, "colCustomerName");
            DataTableColumns.Add("ProductName", ColumnTypes.String, "colProductName");

        }

        private void List_Load(object sender, EventArgs e)
        {

            LoadData();
        }

        public override bool GenerateSelectSQL()
        {

            SelectSQL = @"
select * from Hotel_Sales_View
" + GetWhereClauseForSelect();
            return true;
        }

        private void ExportToolbar_Click(object sender, EventArgs e)
        {
            Reports.ExcelReport excel = new Reports.ExcelReport(this.Text, 4, grid);
        }
        public override string GetWhereClauseForSelect()
        {
            StringBuilder SQL = new StringBuilder();
            SQL.AppendLine("WHERE 1 = 1 ");
            SQL.Append(" \n AND ( 1=2 ");
            if (hotelSearchPanel1.chkBooked.Checked)
            {
                SQL.AppendFormat(" \n OR bookingstaus = '{0}'", BookingStatus.Booked);
            }
            if (hotelSearchPanel1.chkCanceled.Checked)
            {
                SQL.AppendFormat(" \n OR bookingstaus = '{0}'", BookingStatus.Canceled);
            }
            if (hotelSearchPanel1.chkcheckedOut.Checked)
            {
                SQL.AppendFormat(" \n OR bookingstaus = '{0}'", BookingStatus.Cleared);
            }
            if (hotelSearchPanel1.chkOccupied.Checked)
            {
                SQL.AppendFormat(" \n OR bookingstaus = '{0}'", BookingStatus.Occupied);
            }
            SQL.Append(" \n ) ");
            if (hotelSearchPanel1.cboDue.Checked)
            {
                SQL.Append(" \n AND Dueamt <> 0");
            }
            if (hotelSearchPanel1.txtCustomerName.Text.Trim() != "")
            {
                SQL.AppendFormat(" \n AND CustomerName like '%{0}%'", hotelSearchPanel1.txtCustomerName.Text.Trim());
            }

            if (hotelSearchPanel1.cboRoom.Text != "")
            {
                ComboItem citem = (ComboItem)hotelSearchPanel1.cboRoom.SelectedItem;
                SQL.Append(" \n AND ProductName= '" + citem.Value.ToString() + "'");
            }

            if (hotelSearchPanel1.cboRoomType.Text != "")
            {
                ComboItem citem = (ComboItem)hotelSearchPanel1.cboRoomType.SelectedItem;
                SQL.Append(" \n AND ProductType= '" + citem.Value.ToString() + "'");
            }

            SQL.Append(" \n AND date >= '" + hotelSearchPanel1.dtFrom.Value.ToString(Configuration.DB_DATE_FORMAT) + "'");

            SQL.Append(" \n AND date <= '" + hotelSearchPanel1.dtTo.Value.ToString(Configuration.DB_DATE_FORMAT) + "'");

            if (hotelSearchPanel1.cboUser.Text != "")
            {
                string userid = ((ComboItem)hotelSearchPanel1.cboUser.SelectedItem).Key;
                userid = RestoSys.DAl.UserDAL.GetUserId(userid);
                if (userid.Length > 0)
                {
                    SQL.Append(" and  UserId= '{0}'".With(userid));
                }
            }
           

            return SQL.ToString();
        }


        private void toolAccountDetails_Click(object sender, EventArgs e)
        {
            Hotel_Account_Lst hal = new Hotel_Account_Lst(GetSelectedRowValue("colAccid"));
            hal.Text = "Details of payment";
            hal.Show();
        }

        private void hotelSearchPanel1_searchnow()
        {
            LoadData();
        }

       
    }
}
