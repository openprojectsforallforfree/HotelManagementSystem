using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UEMS;
using Friuts;
using Bsoft.Common;
using RestoSys.RestaurantBilling;
using RestoSys.BLL;
using Bsoft.Common.Utilities;
using RestoSys.DAl;
using RestoSys.Account;
using Bsoft.Forms;

namespace RestoSys.Inventory
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmHotelBill : Friuts.EntryFormBase
    {
        public frmHotelBill()
        {
            InitializeComponent();
        }
        Bookings_Lst bookinglist = new Bookings_Lst();
        Hotel_Sales_Lst hotel_Sales = new Hotel_Sales_Lst();
        private void frmHotelBill_Load(object sender, EventArgs e)
        {
            customerGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customerGrid.AutoResizeColumns();
            customerGrid.StandardTab = true; //required...
            customerGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            customerGrid.AllowUserToAddRows = false;
            customerGrid.AllowUserToDeleteRows = false;
            customerGrid.AllowUserToResizeRows = true;
            customerGrid.MultiSelect = false;
            customerGrid.ReadOnly = true;
            LoadOnce();
            btnSave.Visible = false;
            // TableView.lblMenu.Text = "Customers";
            // TableView.ItemIsClicked += new Bsoft.Controls.menuView.refreshHandler(TableView_ItemIsClicked);
            LoadCustomers1("");
        }


        #region Customers
        DataTable cusotmers = new DataTable();
        private void LoadCustomers()
        {
            customerGrid.Rows.Clear();
            //populate customers
            cusotmers = RestoSys.DAl.CustomerDAL.GetCurrentCustomers();
            foreach (DataRow dr in cusotmers.Rows)
            {
                customerGrid.Rows.Add(dr["Id"].ToString(), dr["CustomerName"].ToString(), dr["IdNumber"].ToString());
            }

        }
        private void LoadCustomers1(string searchString)
        {
            customerGrid.Rows.Clear();
            //populate customers
            DataTable dt = RestoSys.DAl.CustomerDAL.GetCurrentCustomers2();
            var v = from DataRow dr in dt.Rows
                    group dr by dr["id"].ToString() into grp
                    select new
                    {
                        Id = grp.Key,
                        customerName = (from DataRow dr in dt.Rows
                                        where dr["id"].ToString() == grp.Key
                                        select dr["customerName"].ToString()).First(),
                        IdNumber = (from DataRow dr in dt.Rows
                                 where dr["id"].ToString() == grp.Key
                                 select dr["IdNumber"].ToString()).First(),
                        Rooms = string.Join(",", (from drs in grp select drs["ProductName"].ToString()).ToArray()),
                    };
            if (searchString.Trim().Length > 0)
            {
                foreach (var o in v)
                {
                    if (o.customerName.ToLower().Contains(searchString.ToLower()) || o.Rooms.ToLower().Contains(searchString.ToLower()) || o.IdNumber.Contains(searchString))
                    {
                        customerGrid.Rows.Add(o.Id, o.customerName, o.Rooms, o.IdNumber);
                    }
                }
            }
            else
            {
                foreach (var o in v)
                {
                    customerGrid.Rows.Add(o.Id, o.customerName, o.Rooms, o.IdNumber);
                }
            }
        }

        string CustomerId = "";
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            //if (txtSearch.Text .Length > 0)
            //{
            //    DataRow[] drs = cusotmers.Select("CustomerName like '%" + txtSearch.Text  + "%'");
            //    customerGrid.Rows.Clear();
            //    foreach (DataRow dr in drs)
            //    {
            //        customerGrid.Rows.Add(dr["Id"].ToString(), dr["CustomerName"].ToString(), dr["Phone"].ToString());
            //    }
            //}
            //else
            //{
            //    customerGrid.Rows.Clear();
            //    foreach (DataRow dr in cusotmers.Rows)
            //    {
            //        customerGrid.Rows.Add(dr["Id"].ToString(), dr["CustomerName"].ToString(), dr["Phone"].ToString());
            //    }
            //}
            LoadCustomers1(txtSearch.Text);
        }

        private void customerGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                CustomerId = customerGrid.SelectedRows[0].Cells["id"].Value.ToString();
                ShowDataForCustomer(CustomerId);
            }
            catch
            {
                CustomerId = "";
            }


        }

        private void LoadOnce()
        {
            foreach (Control item in panelBooking.Controls)
            {
                panelBooking.Controls.Remove(item);
                item.Dispose();
            }

            foreach (Control item in panelRestaurant.Controls)
            {
                panelRestaurant.Controls.Remove(item);
                item.Dispose();
            }


            bookinglist = new Bookings_Lst();
            bookinglist.GridChanged += new Bookings_Lst.gridChanged(hotel_GridChanged);

            bookinglist.panelBooking.Parent = panelBooking;

            hotel_Sales = new Hotel_Sales_Lst();
            hotel_Sales.GridChanged += new Hotel_Sales_Lst.gridChanged(hotel_GridChanged);

            hotel_Sales.panelBooking.Parent = panelRestaurant;

        }

        private void ShowDataForCustomer(string _customerID)
        {
            bookinglist.LoadData(_customerID);
            hotel_Sales.LoadData(_customerID);
        }

        void hotel_GridChanged(DataGridView grid)
        {
            DisplaySummaryGrid();
            btnSave.Visible = true;
        }

        #region Display Summary
        public enum summaryRows
        {
            TOTAL, Discount, SUBTOTAL, SCharge, TaxableAmount, VAT, GRANDTOTAL
        }


        public void DisplaySummaryGrid()
        {
            //sum(Amount) Amount ,
            //              sum(Discount) Discount,
            //              sum( VAT) VAT,
            //              sum( ServiceCharge) ServiceCharge,
            //              sum( NetAmount) NetAmount,
            //              sum(dueamt)  dueamt

            CalculateAmounts calculateAmounts = CalculateAmounts.GetTotals(PaymentDAL.GetSummaryofPayableItems(CustomerId));
            DataTable dtSummary = new DataTable();
            dtSummary.Columns.Add("Heading");
            dtSummary.Columns.Add("Value");
            dtSummary.Rows.Add("Amount", StringUtilities.GetMoneyFromat(calculateAmounts.Amount));
            dtSummary.Rows.Add("Total Discount", StringUtilities.GetMoneyFromat(calculateAmounts.Discount));
          
            if (calculateAmounts.Servicecharge > 0)
            {
                dtSummary.Rows.Add("Total Service Charge", StringUtilities.GetMoneyFromat(calculateAmounts.Servicecharge));
            }
            if (calculateAmounts.VAT > 0 || calculateAmounts.Servicecharge > 0)
            {
                dtSummary.Rows.Add("Taxable Amount", StringUtilities.GetMoneyFromat(calculateAmounts.TaxableamountCalc));
            }
            if (calculateAmounts.VAT > 0)
            {
                dtSummary.Rows.Add("Total VAT", StringUtilities.GetMoneyFromat(calculateAmounts.VAT));
            }
            dtSummary.Rows.Add("Net Amount", StringUtilities.GetMoneyFromat(calculateAmounts.Netamount));
            dtSummary.Rows.Add("Paid Amount", StringUtilities.GetMoneyFromat(calculateAmounts.Netamount - calculateAmounts.Dueamount));
            dtSummary.Rows.Add("Due Amount", StringUtilities.GetMoneyFromat(calculateAmounts.Dueamount));

            if (calculateAmounts.Dueamount>=0)
            {
                btnSave.Text = "Receive Payment";
            }
            else  
            {
                btnSave.Text = "Refund Payment";
            }
            gridSummary.DataSource = dtSummary;
            gridSummary.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridSummary.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dtDetails = PaymentDAL.GetPayableItems(CustomerId);
            if (dtDetails.Rows.Count > 0)
            {
                CalculateAmounts calculateAmounts = CalculateAmounts.GetTotals(PaymentDAL.GetSummaryofPayableItems(CustomerId));
                PaymentDetails frm = new PaymentDetails(dtDetails, CustomerId);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    bookinglist.LoadData(CustomerId);
                    hotel_Sales.LoadData(CustomerId);
                }
            }
            else
            {
                MessageBoxMy.Show("No dues to collect");
            }

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CalculateAmounts calculateAmounts = CalculateAmounts.GetTotals(PaymentDAL.GetSummaryofPayableItems(CustomerId));
            if (calculateAmounts.Dueamount > 0)
            {
                MessageBoxMy.Show("Due amount Rs. {0} is remaining please recieve the due first.".With(StringUtilities.GetMoneyFromat(calculateAmounts.Dueamount)));
            }
            else if (calculateAmounts.Dueamount < 0)
            {

                MessageBoxMy.Show("Due amount Rs. {0} is yet to be refunded please refund the amount first.".With(StringUtilities.GetMoneyFromat(calculateAmounts.Dueamount)));
            }
            else
            {
                DataTable dtDetails = PaymentDAL.GetPayableItems(CustomerId);
                if (dtDetails.Rows.Count > 0)
                {
                    if (PaymentDAL.CheckOut(CustomerId, dtDetails) > 0)
                    {
                        MessageBoxMy.Show("The customer {0} is checked out succesfully,All dues are clear.".With(CustomerDAL.GetCustomerName(CustomerId)), "Thank you!");
                    }
                    bookinglist.LoadData(CustomerId);
                    hotel_Sales.LoadData(CustomerId);
                }
                else
                {
                    MessageBoxMy.Show("No rooms to checked.");
                }

            }
        }
        #endregion

        private void btnNewBooking_Click(object sender, EventArgs e)
        {

            Bookings_Ent b = new Bookings_Ent();
            b.FormType = FormTypes.EntryForm;

            if (b.ShowDialog() == DialogResult.OK)
            {
                LoadCustomers1("");
                CustomerId = b.CustomerId;
                foreach (DataGridViewRow item in customerGrid.Rows)
                {
                    if (item.Cells["Id"].Value.ToString() == CustomerId)
                    {
                        item.Selected = true;
                        return;
                    }
                }
            }
        }

        private void bnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
