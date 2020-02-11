using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using RestoSys.Hotel;
using Bsoft.Common;
namespace UEMS
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class RoomBookingView_Lst : Friuts.ListingFormBase
    {
        private string _accountId = string.Empty;
        public RoomBookingView_Lst(string accountId)
            : this()
        {
            toolStrip1.Visible = false;
            hotelSearchPanel1 .Visible = false;
            grid.Height = grid.Bottom - hotelSearchPanel1 .Top;
            grid.Top = hotelSearchPanel1 .Top;
            _accountId = accountId;
        }
        public RoomBookingView_Lst()
        {
            InitializeComponent();
            FormType = FormTypes.Report;
            ListingDataGridView = grid;
            //<Listing>
            TableName = "Hotel_RoomBookingView";
            DataTableColumns.Add("id", ColumnTypes.String, "colid", true, true);
            DataTableColumns.Add("RoomName", ColumnTypes.String, "colRoomName");
            DataTableColumns.Add("RoomRate", ColumnTypes.AmountRound, "colRoomRate");
            DataTableColumns.Add("CustomerName", ColumnTypes.String, "colCustomerName");
            DataTableColumns.Add("Phone", ColumnTypes.String, "colPhone");
            DataTableColumns.Add("status", ColumnTypes.String, "colstatus");
            DataTableColumns.Add("indate", ColumnTypes.EnglishDate, "colindate");
            DataTableColumns.Add("outDate", ColumnTypes.EnglishDate, "coloutDate");
            DataTableColumns.Add("BookinDate", ColumnTypes.EnglishDate, "colBookinDate");
            DataTableColumns.Add("UserId", ColumnTypes.String, "colUser");
            DataTableColumns.Add("accid", ColumnTypes.String, "colAccid");
         
        }

        private void List_Load(object sender, EventArgs e)
        {

            LoadData();
        }


        public override string GetWhereClauseForSelect()
        {
            if (_accountId.Length > 0)
            {
                return "where AccId like '%[{0}]%'".With(_accountId);
            }
      
            StringBuilder SQL = new StringBuilder();
            SQL.AppendLine("WHERE 1 = 1 ");
            SQL.Append(" \n AND ( 1=2 ");
            if (hotelSearchPanel1.chkBooked.Checked)
            {
                SQL.AppendFormat(" \n OR status = '{0}'", BookingStatus.Booked);
            }
            if (hotelSearchPanel1.chkCanceled.Checked)
            {
                SQL.AppendFormat(" \n OR status = '{0}'", BookingStatus.Canceled);
            }
            if (hotelSearchPanel1.chkcheckedOut.Checked)
            {
                SQL.AppendFormat(" \n OR status = '{0}'", BookingStatus.Cleared);
            }
            if (hotelSearchPanel1.chkOccupied.Checked)
            {
                SQL.AppendFormat(" \n OR status = '{0}'", BookingStatus.Occupied);
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
                SQL.Append(" \n AND RoomName= '" + citem.Value.ToString() + "'");
            }

            if (hotelSearchPanel1.cboRoomType.Text != "")
            {
                ComboItem citem = (ComboItem)hotelSearchPanel1.cboRoomType.SelectedItem;
                SQL.Append(" \n AND RoomType= '" + citem.Value.ToString() + "'");
            }
           
            
            SQL.AppendFormat(@" and ((indate <= {0} and indate >= {0}) 
                    or(indate <={1} and outdate >= {1} )
                    or(indate >={0} and outdate <= {1} ))", hotelSearchPanel1.dtFrom.Value.ToString(Configuration.DB_DATE_FORMAT), hotelSearchPanel1.dtTo.Value.ToString(Configuration.DB_DATE_FORMAT));
            
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

      

        private void toolExcelExport_Click(object sender, EventArgs e)
        {
            Reports.ExcelReport excel = new Reports.ExcelReport(this.Text, 4, grid);
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
