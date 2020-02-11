using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using RestoSys.DAl;
using RestoSys.Hotel;
using Bsoft.Forms;
using Bsoft.Common;
using Bsoft.Common.Utilities;
namespace UEMS
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class Bookings_Lst : Friuts.ListingFormBase
    {
        public delegate void gridChanged(DataGridView grid);
        public event gridChanged GridChanged;
        public Bookings_Lst()
        {
            TableName = "Hotel_Bookings";
            InitializeComponent();
            FormType = FormTypes.ListingForm;
            ListingDataGridView = gridBooking;
            //<Listing>

            DataTableColumns.Add("id", ColumnTypes.Number, "colid", true, true);
            DataTableColumns.Add("fk_Master_Customer", ColumnTypes.Number, "colfk_Master_Customer");
            RelationList.Add("fk_Master_Customer", "Master_Customer", "id", "Name", "colCustomerName");

            DataTableColumns.Add("fk_Hotel_Master_Room", ColumnTypes.Number, "colfk_Hotel_Master_Room");
            RelationList.Add("fk_Hotel_Master_Room", "Hotel_Master_Room", "id", "Name", "colHotel_RoomName");

            DataTableColumns.Add("bookingstaus", ColumnTypes.String, "colbookingstaus");
            DataTableColumns.Add("indate", ColumnTypes.EnglishDate, "colindate");
            DataTableColumns.Add("outDate", ColumnTypes.EnglishDate, "coloutDate");
            DataTableColumns.Add("cancelDate", ColumnTypes.EnglishDate, "colcancelDate");
            DataTableColumns.Add("Quantity", ColumnTypes.Number, "colQuantity");
            DataTableColumns.Add("NoofPerson", ColumnTypes.String, "colNoofPerson");
            DataTableColumns.Add("Rate", ColumnTypes.AmountRound, "colRate");
            DataTableColumns.Add("amount", ColumnTypes.AmountRound, "colamount");
            DataTableColumns.Add("discount", ColumnTypes.AmountRound, "coldiscount");
            DataTableColumns.Add("VAT", ColumnTypes.AmountRound, "colVAT");
            DataTableColumns.Add("ServiceCharge", ColumnTypes.AmountRound, "colServiceCharge");
            DataTableColumns.Add("NetAmount", ColumnTypes.AmountRound, "colNetAmount");

            DataTableColumns.Add("netamount-dueamt u", ColumnTypes.AmountRound, "colPaid", false, true, true, "u");
            DataTableColumns.Add("dueamt", ColumnTypes.AmountRound, "coldueamt");
            DataTableColumns.Add("Remarks", ColumnTypes.String, "colRemarks");
            DataTableColumns.Add("Date", ColumnTypes.EnglishDate, "colDate");
            DataTableColumns.Add("UserId", ColumnTypes.String, "colUser");

        }

        private void List_Load(object sender, EventArgs e)
        {



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
            string status = GetSelectedRowValue("colbookingstaus");
            //if (status == BookingStatus.Cleared)
            //{
            //    MessageBoxMy.Show("Cleared data cannot be edited .");
            //    return false;
            //}
            Bookings_Ent b = new Bookings_Ent();
            b.CustomerId = _customerId;

            return base.OpenEditForm(b);
        }

        public override bool OpenNewForm()
        {
            Bookings_Ent bent = new Bookings_Ent();
            bent.CustomerId = _customerId;
            return base.OpenNewForm(bent);
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            Delete();
        }
        public override bool Delete()
        {
            string status = GetSelectedRowValue("colbookingstaus");
            if (status == BookingStatus.Cleared)
            {
                MessageBoxMy.Show("Cleared data cannot be deleted .");
                return false;
            }
            return base.Delete();
        }


        private void ExportToolbar_Click(object sender, EventArgs e)
        {
            Reports.ExcelReport excel = new Reports.ExcelReport(this.Text, 4, gridBooking);
        }

        string _customerId = "";
        public bool LoadData(string customerId)
        {
            _customerId = customerId;
            lblCustomer.Text = "Bookings for customer : " +

            CustomerDAL.GetCustomerName(customerId) + " ({0})".With(CustomerDAL.GetCustomeType(customerId));
            return LoadData();
        }

        public override bool LoadData()
        {
            SearchConditionList.Clear();
            SearchConditionList.AddCriteria(ColumnTypes.Number, "fk_Master_Customer", ComparisionTypes.EQUAL, _customerId);
            bool b = base.LoadData();
            if (GridUtility.GetSum(gridBooking, "colServiceCharge") == 0)
            {
                gridBooking.Columns["colServiceCharge"].Visible = false;
            }
            if (GridUtility.GetSum(gridBooking, "colVAT") == 0)
            {
                gridBooking.Columns["colVAT"].Visible = false;
            }

            GridChanged(gridBooking);
            return b;
        }

    }
}
