using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using RestoSys.DAl;
using Bsoft.Common;
using RestoSys.Hotel;
using Bsoft.AppCom;
using RestoSys.BLL;
using Bsoft.Forms;
using RestoSys.Forms;
using Bsoft.Hotel;
using RestoSys;

namespace UEMS
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class Bookings_Ent : Friuts.EntryFormBase
    {
        #region Local Variables
        public string CustomerId = "";
        RateCalculator rateCalculator = new RateCalculator();

        int MaxNosofPeople = 0;
        decimal paidAmount = 0;
        public int DaysSpan
        {
            get
            {
                int days = (dtTo.Value - dtFrom.Value).Days;
                if (days < 1)
                {
                    days = 1;
                }
                return days;
            }
        }
        decimal customerRateDiscountPercent = 0;
        #endregion

        #region Contructor and Form Load
        public Bookings_Ent()
        {

            IsQuickSaveKey = false;
            TableName = "Hotel_Bookings";
            InitializeComponent();
            //timespan start
            DateTime nextday = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dtFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            dtTo.Value = nextday.AddDays(1);
            dtFrom.MaxDate = dtTo.Value;
            dtTo.MinDate = dtFrom.Value;
            //timespan end
            ColumnList.AddNewEditColumn("id", ColumnTypes.Number, txtid, true, false);
            ColumnList.AddNewEditColumn("fk_Master_Customer", ColumnTypes.Number, txtfk_Master_Customer, true, "Customer", "Please Select the customer");
            ColumnList.AddNewEditColumn("fk_Hotel_Master_Room", ColumnTypes.Number, txtfk_Hotel_Master_Room, true, "Room", "Please select Room");
            ColumnList.AddNewEditColumn("bookingstaus", ColumnTypes.String, lblBookingStatus);
            ColumnList.AddNewEditColumn("indate", ColumnTypes.String, dtFrom);
            ColumnList.AddNewEditColumn("outDate", ColumnTypes.String, dtTo);
            // ColumnList.AddNewEditColumn("cancelDate", ColumnTypes.String, lblCancelDate);
            //quantity was not absolutely necessary(can be calculated form dates in out) but kept for easiness
            ColumnList.AddNewEditColumn("Quantity", ColumnTypes.Number, Quantity, true, "No of Days", "");
            ColumnList.AddNewEditColumn("NoofPerson", ColumnTypes.String, txtNoofPerson);
            //This is discounted rate because standard rate can be calculated as amount/quantity
            ColumnList.AddNewEditColumn("Rate", ColumnTypes.AmountRound, lblDiscountedRate, true, "Room", "Please select Room");
            ColumnList.AddNewEditColumn("RateType", ColumnTypes.String, txtRateType);
            //This is amount without discount
            ColumnList.AddNewEditColumn("amount", ColumnTypes.AmountRound, lblamount);
            //actual dicount including qty
            ColumnList.AddNewEditColumn("discount", ColumnTypes.AmountRound, lblTotaldiscount);
            ColumnList.AddNewEditColumn("VAT", ColumnTypes.AmountRound, lblVAT);
            ColumnList.AddNewEditColumn("ServiceCharge", ColumnTypes.AmountRound, lblSC);
            ColumnList.AddNewEditColumn("NetAmount", ColumnTypes.AmountRound, lblNET);

            ColumnList.AddNewEditColumn("dueamt", ColumnTypes.AmountRound, lblDUE, lblDUE);
            ColumnList.AddNewEditColumn("Remarks", ColumnTypes.String, txtRemarks);
            ColumnList.AddNewEditColumn("Date", ColumnTypes.String, DateTime.Now.ToString("yyyyMMdd"));
            ColumnList.AddNewEditColumn("UserId", ColumnTypes.String, GlobalValues.LoginUserName);

            DataGridViewCellStyle selctionstyle = new DataGridViewCellStyle();
            selctionstyle.SelectionBackColor = Color.White;
            selctionstyle.SelectionForeColor = Color.Black;
            gridSummary.DefaultCellStyle = selctionstyle;
            listerRoom.DefaultCellStyle = selctionstyle;

        }


        private void Bookings_Ent_Load(object sender, EventArgs e)
        {
            calculatorButton1.AssociatedControl = txtRateDiscount;
            gridSummary.Rows.Add("", "", "");
            gridSummary.Rows.Add("", "", "");
            gridSummary.Rows.Add("", "", "");
            gridSummary.Rows.Add("", "", "");
            gridSummary.Rows.Add("", "", "");
            gridSummary.Rows.Add("", "", "");
            gridSummary.Rows.Add("", "", "");
            gridSummary.Rows.Add("", "", "");
            gridSummary.Rows.Add("", "", "");


            gridSummary.Rows[0].HeaderCell.Value = "Standard Rate";
            gridSummary.Rows[1].HeaderCell.Value = "Discount Rate";

            gridSummary.Rows[2].HeaderCell.Value = "Discounted Rate";
            gridSummary.Rows[3].HeaderCell.Value = "Rate Per Day";

            gridSummary.Rows[4].HeaderCell.Value = "Service Charge";
            gridSummary.Rows[5].HeaderCell.Value = "VAT";
            gridSummary.Rows[6].HeaderCell.Value = "TOTAL";
            gridSummary.Rows[7].HeaderCell.Value = "Due Amount";
            gridSummary.Rows[8].HeaderCell.Value = "Paid Amount";
            lblBookingStatus.Text = BookingStatus.Occupied;
            if (FormType == FormTypes.EntryForm)
            {
                btnCancelBooking.Visible = false;
                if (CustomerId.Length < 1)
                {
                    bnSelectCustomer_Click(null, null);
                }
                else
                {
                    btnSelectRoom_Click(null, null);
                }
            }
            else if (FormType == FormTypes.EditForm)
            {
                btnCancelBooking.Visible = true;
                listerRoom.Visible = true;

            }
            if (txtfk_Hotel_Master_Room.Text.Length < 1)
            {
                btnSelectRoom.Visible = true;
            }
            else
            {
                btnSelectRoom.Visible = false;
            }
            if (txtfk_Master_Customer.Text.Length < 1)
            {
                btnSelectCustomer.Visible = true;
            }
            else
            {
                btnSelectCustomer.Visible = false;
            }
        }
        #endregion

        #region Functions
        void LoadRoomData(string roomId)
        {
            if (roomId.Length == 0)
            {
                return;
            }
            DataTableUtility.SetListingGrid(listerRoom, HotelDAL.GetRoom(roomId));
            if (listerRoom.Columns.Count > 0)
            {
                listerRoom.Columns[listerRoom.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            txtfk_Hotel_Master_Room.Text = roomId;
            lblRoom.Text = HotelDAL.GetRoomName(roomId);

            rateCalculator.PerRoomRate = HotelDAL.GetPerRoomRate(roomId).ToDecimal();
            rateCalculator.PerPersonRate = HotelDAL.GetPerPersonRate(roomId).ToDecimal();
            MaxNosofPeople = HotelDAL.GetMaxNoofPeople(roomId);
        }

        void frm_RoomvalueSelected(object sender, string SelectedPrimaryKey)
        {
            //set room details
            LoadRoomData(SelectedPrimaryKey);
            if (sender != null)
            {
                if (HotelDAL.IsDormitory(SelectedPrimaryKey))
                {
                    radioPerPerson.Checked = true;
                    radioPerRoom.Checked = false;
                    txtRateType.Text = "P";
                }
                else
                {
                    radioPerPerson.Checked = false;
                    radioPerRoom.Checked = true;
                    txtRateType.Text = "R";
                }
                c_valueSelected(null, CustomerId);
            }
            else//on loaddata
            {
                if (txtRateType.Text == "P")
                {
                    radioPerPerson.Checked = true;
                    radioPerRoom.Checked = false;
                    rateCalculator.IsPerPersonRate = true;
                }
                else
                {
                    radioPerPerson.Checked = false;
                    radioPerRoom.Checked = true;
                    rateCalculator.IsPerPersonRate = false;
                }
            }

            listerRoom.Visible = true;
            calculateAmount();
        }

        void c_valueSelected(object sender, string SelectedPrimaryKey)
        {
            if (SelectedPrimaryKey.Length < 1)
            {
                return;
            }
            CustomerId = SelectedPrimaryKey;
            txtfk_Master_Customer.Text = SelectedPrimaryKey;
            lblCustmerName.Text = CustomerDAL.GetCustomerName(SelectedPrimaryKey) + " ({0})".With(CustomerDAL.GetCustomeType(SelectedPrimaryKey));

            customerRateDiscountPercent = CustomerDAL.GetCustomerDiscount(SelectedPrimaryKey);
            btnRatePercentCalculate.Text = "<" + customerRateDiscountPercent.ToString() + "%";
            toolTip1.ToolTipTitle = "Use " + customerRateDiscountPercent.ToString() + "% Discount";

            //txtRateDiscount.Text = (customerRateDiscountPercent * PerRoomRate).ToString();
        }

        public override bool LoadData()
        {
            dtFrom.MaxDate = new DateTime(9000, 1, 1);
            dtTo.MinDate = new DateTime(1754, 1, 1);

            bool b = base.LoadData();
            LoadRoomData(txtfk_Hotel_Master_Room.Text);
            //Quantity.Text = DaysSpan.ToString();
            if (lblBookingStatus.Text == BookingStatus.Booked)
            {

                grpBooking.Visible = true;
                rdoBooking.Checked = true;
                rdoOccupy.Checked = false;
            }
            else if (lblBookingStatus.Text == BookingStatus.Occupied)
            {

                grpBooking.Visible = true;
                rdoBooking.Checked = false;
                rdoOccupy.Checked = true;
            }
            else if (lblBookingStatus.Text == BookingStatus.Cleared)
            {
                grpBooking.Visible = false;
                lblBookingStatus.Text = "Cleared";
                btnOk.Visible = false;
                //btnCancelBooking.Visible = false;
            }
            else if (lblBookingStatus.Text == BookingStatus.Canceled)
            {
                grpBooking.Visible = false;
                lblBookingStatus.Text = "Canceled";
                btnOk.Visible = false;
                btnCancelBooking.Visible = false;
            }
            //it is important to do this once before the txtRateDiscount.Text  is assigned 
            //becasue radio change event has calulate amounts which changes the lbldiscountrate .
            if (txtRateType.Text == "R")
            {
                rateCalculator.IsPerPersonRate = false;
            }
            else
            {
                rateCalculator.IsPerPersonRate = true;
            }
            paidAmount = lblNET.Text.ToDecimal() - lblDUE.Text.ToDecimal();


            c_valueSelected(null, txtfk_Master_Customer.Text);
            txtRateDiscount.Text = (rateCalculator.StandardRate - lblDiscountedRate.Text.ToDecimal()).ToString();

            if (txtRateType.Text == "R")
            {
                rateCalculator.IsPerPersonRate = false;
                radioPerRoom.Checked = true;
                radioPerPerson.Checked = false;
            }
            else
            {
                rateCalculator.IsPerPersonRate = true;
                radioPerRoom.Checked = false;
                radioPerPerson.Checked = true;
            }
            calculateAmount();


            if (txtfk_Hotel_Master_Room.Text.Length < 1)
            {
                btnSelectRoom.Visible = true;
            }
            else
            {
                btnSelectRoom.Visible = false;
            }
            if (txtfk_Master_Customer.Text.Length < 1)
            {
                btnSelectCustomer.Visible = true;
            }
            else
            {
                btnSelectCustomer.Visible = false;
            }

            return b;
        }

        private void calculateAmount()
        {

            if (txtfk_Hotel_Master_Room.Text.Trim().Length > 0)
            {
                //nos
                rateCalculator.Nos = txtNoofPerson.Text.ToDecimal();

                //Quantity
                Quantity.Text = DaysSpan.ToString();
                rateCalculator.Days = DaysSpan.ToString().ToDecimal();
                //Discount rate

                rateCalculator.StandardDiscountRate = txtRateDiscount.Text.ToDecimal();

                lblDiscountedRate.Text = rateCalculator.StandardDiscountedRate.ToString();
                lblamount.Text = rateCalculator.Amount.ToString();
                lblTotaldiscount.Text = rateCalculator.Discount.ToString();

                //rates

                CalculateVATServiceChargeDiscountAmount calculator = new CalculateVATServiceChargeDiscountAmount();
                calculator.Total = rateCalculator.Amount;
                calculator.Discount = rateCalculator.Discount;

                lblSC.Text = calculator.ServiceCharge.ToString();
                lblNET.Text = calculator.AmountToPay.ToString();
                lblVAT.Text = calculator.VAT.ToString();

                lblDUE.Text = (calculator.AmountToPay - paidAmount).ToString();
                //Update grid summary
                //0"Standard Rate";
                //1"Discount Rate";

                //2"Discounted Rate";
                //3"Rate Per Day";

                //4"Service Charge";
                //5"VAT";
                //6"TOTAL";
                //7"Due Amount";

                gridSummary.Rows[0].Cells[0].Value = rateCalculator.StandardRate.ToString();
                gridSummary.Rows[1].Cells[0].Value = rateCalculator.StandardDiscountRate.ToString();
                gridSummary.Rows[2].Cells[0].Value = rateCalculator.StandardDiscountedRate.ToString();
                gridSummary.Rows[3].Cells[0].Value = rateCalculator.PerDayDiscountedRate.ToString();

                gridSummary.Rows[0].Cells[1].Value = rateCalculator.Days.ToString();
                gridSummary.Rows[1].Cells[1].Value = rateCalculator.Days.ToString();
                gridSummary.Rows[2].Cells[1].Value = rateCalculator.Days.ToString();
                gridSummary.Rows[3].Cells[1].Value = rateCalculator.Days.ToString();

                gridSummary.Rows[0].Cells[2].Value = rateCalculator.Amount.ToString();
                gridSummary.Rows[1].Cells[2].Value = lblTotaldiscount.Text;
                gridSummary.Rows[2].Cells[2].Value = rateCalculator.PerDayDiscountedRate;
                gridSummary.Rows[3].Cells[2].Value = rateCalculator.DiscountedAmount.ToString();

                //first column
                gridSummary.Rows[4].Cells[0].Value = ApplicationSetting.ServiceChargePercent.ToString() + "%";
                gridSummary.Rows[5].Cells[0].Value = ApplicationSetting.VatPercent.ToString() + "%";

                //last columnt
                gridSummary.Rows[4].Cells[2].Value = calculator.ServiceCharge.ToString();
                gridSummary.Rows[5].Cells[2].Value = calculator.VAT.ToString();
                gridSummary.Rows[6].Cells[2].Value = calculator.AmountToPay.ToString();
                gridSummary.Rows[7].Cells[2].Value = lblDUE.Text;
                gridSummary.Rows[8].Cells[2].Value = paidAmount.ToString();
                if (calculator.VAT == 0)
                {
                    gridSummary.Rows[5].Visible = false;
                }
                if (calculator.ServiceCharge == 0)
                {
                    gridSummary.Rows[4].Visible = false;
                }

                //if (calculator.VAT == 0 && calculator.ServiceCharge == 0)
                //{
                //  gridSummary.Rows[6].Visible = false;
                //}

                if (rateCalculator.IsPerPersonRate)
                {
                    gridSummary.Rows[2].Visible = true;
                    gridSummary.Rows[1].Cells[1].Value = rateCalculator.Days.ToString() + "x" + rateCalculator.Nos.ToString();
                    gridSummary.Rows[2].Cells[1].Value = "x" + rateCalculator.Nos.ToString();


                }
                else
                {
                    gridSummary.Rows[2].Visible = false;
                }

            }
        }

        #endregion

        #region Main Events

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dtFrom.Value > DateTime.Now)
            {
                MessageBoxMy.Show("Please select Booking as the the from date is not yet reached.");
            }
            if (lblDiscountedRate.Text.ToDecimal() < 0)
            {
                MessageBoxMy.Show("The discout rate should not be more than the standard rate.\nPlease Correct it.");
                txtRateDiscount.Focus();
                return;
            }
            if (txtfk_Hotel_Master_Room.Text.Length < 1)
            {
                MessageBoxMy.Show("Please Select Room.");
                btnSelectRoom.Focus();
                return;
            }
            if (txtfk_Master_Customer.Text.Length < 1)
            {
                MessageBoxMy.Show("Please Select Customer.");
                btnSelectCustomer.Focus();
                return;
            }



            if (MaxNosofPeople < txtNoofPerson.Text.ToInt())
            {
                if (MessageBoxMy.Show("Maximum number of people allowed in this room is {0} .\nDo you still want to contiue?".With(MaxNosofPeople),
                    MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }
            if (HotelDAL.IsDormitory(txtfk_Hotel_Master_Room.Text))
            {
                Save();
            }
            else
            {
                if (HotelDAL.IsBookingApplicable(CustomerId, txtfk_Hotel_Master_Room.Text, dtFrom.Value.ToString("yyyyMMdd"), dtFrom.Value.ToString("yyyyMMdd")).Length == 0)
                {
                    Save();
                }
                else
                {
                    if (MessageBoxMy.Show(@"
This room is not available in given date.
Do You want to save data?
Click Yes to save data .
Click No to view booking details", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Save();
                    }
                    else
                    {
                        RoomBookingView_Lst rptBooking = new RoomBookingView_Lst();
                        rptBooking.hotelSearchPanel1.chkBooked.Checked = true;
                        rptBooking.hotelSearchPanel1.chkCanceled.Checked = false;
                        rptBooking.hotelSearchPanel1.chkcheckedOut.Checked = false;
                        rptBooking.hotelSearchPanel1.chkOccupied.Checked = true;

                        rptBooking.hotelSearchPanel1.dtFrom.Value = dtFrom.Value;
                        rptBooking.hotelSearchPanel1.dtTo.Value = dtTo.Value;
                        ComboUtilities.SelectComboBoxItemUsingKey(rptBooking.hotelSearchPanel1.cboRoom, txtfk_Hotel_Master_Room.Text);
                        rptBooking.Text = "Please view the booking status of selected Room";
                        rptBooking.ShowDialog();
                    }
                }
            }

        }

        private void rdoBooking_CheckedChanged(object sender, EventArgs e)
        {
            if (grpBooking.Visible)
            {
                if (rdoBooking.Checked)
                {
                    lblBookingStatus.Text = BookingStatus.Booked;
                }
            }
        }

        private void rdoOccupy_CheckedChanged(object sender, EventArgs e)
        {
            if (grpBooking.Visible)
            {
                if (rdoOccupy.Checked)
                {
                    lblBookingStatus.Text = BookingStatus.Occupied;
                }
            }
            {
            }
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (lblBookingStatus.Text == BookingStatus.Cleared)
            {
                MessageBoxMy.Show("Cleared Rooms cannot be canceled.");
                return;
            }
            if (MessageBoxMy.Show("Do you want to cancel the booking ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lblBookingStatus.Text = BookingStatus.Canceled;
                grpBooking.Visible = false;
                PaymentDAL.CancelBooking(txtid.Text, "Hotel_Bookings");
                DialogResult = DialogResult.OK;
            }

        }

        #endregion

        #region Calculating Events
        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            dtTo.MinDate = dtFrom.Value;
            lblSpan.Text = DaysSpan.ToString() + " Days";
            calculateAmount();
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            dtFrom.MaxDate = dtTo.Value;
            lblSpan.Text = DaysSpan.ToString() + " Days";
            calculateAmount();
        }
        private void radioPerPerson_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPerPerson.Checked)
            {
                rateCalculator.IsPerPersonRate = true;
                txtRateType.Text = "P";
            }
            else
            {
                rateCalculator.IsPerPersonRate = false;
                txtRateType.Text = "R";
            }
            calculateAmount();
        }

        private void radioPerRate_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPerPerson.Checked)
            {
                rateCalculator.IsPerPersonRate = true;
                txtRateType.Text = "P";
            }
            else
            {
                rateCalculator.IsPerPersonRate = false;
                txtRateType.Text = "R";
            }
            calculateAmount();
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            calculateAmount();
        }

        private void Quantity_TextChanged(object sender, EventArgs e)
        {
            calculateAmount();
        }
        #endregion

        #region General Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }




        private void listerRoom_Click(object sender, EventArgs e)
        {
            UEMS.Room_Lst frm = new UEMS.Room_Lst();
            frm.FormType = FormTypes.SelectionForm;
            frm.valueSelected += new ListingFormBase.ValueSelected(frm_RoomvalueSelected);
            frm.ShowDialog(this);
        }

        private void lblRoomDetail_Click(object sender, EventArgs e)
        {
            UEMS.Room_Lst frm = new UEMS.Room_Lst();
            frm.FormType = FormTypes.SelectionForm;
            frm.valueSelected += new ListingFormBase.ValueSelected(frm_RoomvalueSelected);
            frm.ShowDialog(this);
        }

        private void btnSelectRoom_Click(object sender, EventArgs e)
        {
            UEMS.Room_Lst frm = new UEMS.Room_Lst();
            frm.Text = "Please Select a Room";
            frm.FormType = FormTypes.SelectionForm;
            frm.valueSelected += new ListingFormBase.ValueSelected(frm_RoomvalueSelected);
            frm.ShowDialog(this);
            c_valueSelected(null, CustomerId);
        }

        private void bnSelectCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerList c = new frmCustomerList();
            c.Text = "Please choose a customer";
            c.FormType = FormTypes.SelectionForm;
            c.valueSelected += new ListingFormBase.ValueSelected(c_valueSelected);
            c.ShowDialog();
            if (txtfk_Hotel_Master_Room.Text.Length < 1)
            {
                btnSelectRoom_Click(null, null);
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            dtTo.Value = dtTo.Value.AddDays(1);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (dtTo.MinDate <= dtTo.Value.AddDays(-1))
            {
                dtTo.Value = dtTo.Value.AddDays(-1);
            }

        }

        private void fsButton1_Click(object sender, EventArgs e)
        {
            txtNoofPerson.Text = (txtNoofPerson.Text.ToInt() + 1).ToString();
        }

        private void fsButton2_Click(object sender, EventArgs e)
        {
            if (txtNoofPerson.Text.ToInt() > 1)
            {
                txtNoofPerson.Text = (txtNoofPerson.Text.ToInt() - 1).ToString();
            }
        }

        #endregion

        private void btnRatePercentCalculate_Click(object sender, EventArgs e)
        {
            txtRateDiscount.Text = (rateCalculator.StandardRate * customerRateDiscountPercent / 100).ToInt().ToString();
        }



    }
}
