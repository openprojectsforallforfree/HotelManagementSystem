using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using Bsoft.AppCom;
using RestoSys.DAl;
using RestoSys;
using Bsoft.Common;
using RestoSys.BLL;
using RestoSys.Hotel;
namespace UEMS
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class Hotel_Sales_Ent : Friuts.EntryFormBase
    {
        public Hotel_Sales_Ent()
        {
            InitializeComponent();
            //<Entry>
            TableName = "Hotel_Sales";


            ColumnList.AddNewEditColumn("Id", ColumnTypes.Number, txtId, true, false);
            ColumnList.AddNewEditColumn("fk_Master_Customer", ColumnTypes.Number, txtfk_Master_Customer);
            ColumnList.AddNewEditColumn("fk_Product", ColumnTypes.Number, txtfk_Product,true ,"Product","Please select a product");
            ColumnList.AddNewEditColumn("bookingstaus", ColumnTypes.String, txtbookingstaus);
            ColumnList.AddNewEditColumn("Rate", ColumnTypes.AmountRound, txtRate, true, "Rate", "Please select a product rate");
            ColumnList.AddNewEditColumn("Quantity", ColumnTypes.AmountRound, txtQuantity, true, "Quantity", "");
            ColumnList.AddNewEditColumn("Amount", ColumnTypes.AmountRound, lblAmount);
            ColumnList.AddNewEditColumn("Discount", ColumnTypes.AmountRound, txtDiscount);
            ColumnList.AddNewEditColumn("VAT", ColumnTypes.AmountRound, txtVAT);
            ColumnList.AddNewEditColumn("ServiceCharge", ColumnTypes.AmountRound, txtServiceCharge);
            ColumnList.AddNewEditColumn("NetAmount", ColumnTypes.AmountRound, lblNetAmount);
            ColumnList.AddNewEditColumn("dueamt", ColumnTypes.AmountRound, lbldueamt );
            ColumnList.AddNewEditColumn("Remarks", ColumnTypes.String, txtRemarks);
            ColumnList.AddNewEditColumn("Date", ColumnTypes.String, DateTime.Now.ToString("yyyyMMdd"));
            ColumnList.AddNewEditColumn("UserID", ColumnTypes.String, GlobalValues.LoginUserName);
            //ColumnList.AddNewEditColumn("fk_purchage", ColumnTypes.Number, txtfk_purchage);
            //ColumnList.AddNewEditColumn("CostPrice", ColumnTypes.AmountRound, txtCostPrice);
            //ColumnList.AddNewEditColumn("canceldate", ColumnTypes.String, txtcanceldate);
            //ColumnList.AddNewEditColumn("indate", ColumnTypes.String, txtindate);
            //ColumnList.AddNewEditColumn("outDate", ColumnTypes.String, txtoutDate);
        }

        public string CustomerId = "";

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Hotel_Sales_Ent_Load(object sender, EventArgs e)
        {
            txtfk_Master_Customer.Text = CustomerId;
            txtbookingstaus.Text = BookingStatus.Occupied;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSelectRoom_Click(object sender, EventArgs e)
        {
            RestoSys.MasterEntry.frmProductList frm = new RestoSys.MasterEntry.frmProductList();
            frm.FormType = FormTypes.SelectionForm;

            frm.StockCode = string.Format("'{0}' , '{1}', '{2}','{3}' ",
                ItemType.Retail,
                ItemType.Manufacture,
                ItemType.Service,
                ItemType.Lend);
            frm.Text = "Sales : Items that could be in sales";

            frm.Text = "Select " + frm.Text;
            //  frm.txtName.Text = searchString;
            frm.valueSelected += new ListingFormBase.ValueSelected(frm_valueSelected);
            frm.ShowDialog(this);
        }


        void frm_valueSelected(object sender, string SelectedPrimaryKey)
        {

            txtfk_Product.Text = SelectedPrimaryKey;
            lister1.Datatable = ProductDAL.GetProduct(SelectedPrimaryKey);
            txtRate.Text = ProductDAL.GetProductRate(SelectedPrimaryKey);
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            calculateAmount();
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            calculateAmount();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            calculateAmount();
        }

        private void calculateAmount()
        {
            CalculateVATServiceChargeDiscountAmount calculator = new CalculateVATServiceChargeDiscountAmount();
            
            string Amount = ((txtRate.Text.ToInt() * txtQuantity.Text.ToInt())).ToString();
            calculator.Total = Amount.ToDecimal();
            calculator.Discount = txtDiscount.Text.ToDecimal();
            lblAmount.Text = calculator.Total.ToString ();
            lblNetAmount.Text = calculator.AmountToPay.ToString();
            txtServiceCharge.Text = calculator.ServiceCharge.ToString();
            txtVAT.Text = calculator.VAT.ToString();
            lbldueamt .Text = calculator.AmountToPay.ToString();
        }

        public override bool LoadData()
        {bool b = base.LoadData();
            lister1.Datatable = ProductDAL.GetProduct(txtfk_Product.Text);
            return b;
        }
    }
}
