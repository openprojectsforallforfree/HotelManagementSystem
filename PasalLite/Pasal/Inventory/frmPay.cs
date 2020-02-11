using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bsoft.Controls;
using System.Data.SqlClient;
using Friuts;
using UEMS.BLL;
using Bsoft.Utility;
using Bsoft.Forms;
using Bsoft.Common;
using Bsoft.Report.Print;
using Bsoft.Data;
using Bsoft.AppCom;
using System.Threading;
using Pasal.Reports;
namespace Pasal.Forms
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmPay : Friuts.EntryFormBase
    {
        DataTable _dtItems;
        public frmPay()
        {
            InitializeComponent();
        }
        public frmPay(decimal totalAmount, decimal discountAmount, DataTable dtItems)
        {
            InitializeComponent();
            sevenShoppingAmount.Value = totalAmount.ToString();
            sevenDiscount.Value = discountAmount.ToString();
            PayAmount = totalAmount - discountAmount;
            sevenPayAmount.Value = PayAmount.ToString();
            _dtItems = dtItems;
            this.totalAmount = totalAmount;
            this.discountAmount = discountAmount;

        }
        decimal totalAmount, discountAmount, PayAmount, tenderAmount = 0;
        decimal returnAmount = -1;
        decimal creditAmount = 0;
        private void txtTender_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tenderAmount = Convert.ToDecimal(txtTender.Text);
                returnAmount = tenderAmount - PayAmount;
                if (returnAmount < 0)
                { sevenReturn.Value = "---------"; }
                else
                { sevenReturn.Value = returnAmount.ToString(); }
            }
            catch { }
        }

        private void frmPay_Load(object sender, EventArgs e)
        {

            lblInWords.Text = new Bsoft.Common.NumberInWords().inWords(totalAmount.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string a = txtTender.Text;
            if (returnAmount < 0)
            {
                if (MessageBoxMy.Show("The Tender Amount is not enough. \nDo you want to give Credit?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (CustomerId.Trim() == "")
                    {
                        MessageBoxMy.Show("Please Browse the customer name first.", MessageBoxButtons.OK);
                    }
                    else
                    {
                        creditAmount = totalAmount - tenderAmount;
                        if (MessageBoxMy.Show("Do you want to give credit \nof Amount Rs:" + creditAmount.ToString() + " to \n" + customerName, MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            TransactionSave(CustomerId);
                        }
                    }
                }
            }
            else
            {
                TransactionSave("");
            }
        }

        private void TransactionSave(string customerid)
        {
            int billno = 0;
            billno = savetransaction(customerid);
            if (billno == 0)
            {
                MessageBoxMy.Show("Data couldnot be saved Please contact Administrator", MessageBoxButtons.OK);
                return;
            }
            DialogResult print = MessageBoxMy.Show("Do you want to print the bill ?", MessageBoxButtons.YesNo);
            if (print == DialogResult.Yes)
            {
                // printBill(_dtItems, billno);
                printBillGDI(_dtItems, billno);
            }
            DialogResult = DialogResult.OK;
        }
        private static void ExecuteSqlTransaction(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText =
                        "Insert into Region (RegionID, RegionDescription) VALUES (100, 'Description')";
                    command.ExecuteNonQuery();
                    command.CommandText =
                        "Insert into Region (RegionID, RegionDescription) VALUES (101, 'Description')";
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    Console.WriteLine("Both records are written to database.");
                }
                catch (Exception e)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (SqlException ex)
                    {
                        if (transaction.Connection != null)
                        {
                            Console.WriteLine("An exception of type " + ex.GetType() +
                                " was encountered while attempting to roll back the transaction.");
                        }
                    }

                    Console.WriteLine("An exception of type " + e.GetType() +
                        " was encountered while inserting the data.");
                    Console.WriteLine("Neither record was written to database.");
                }
            }
        }

        //private void savetransaction1()
        //{












        //    StringBuilder SQL = new StringBuilder();

        //    //
        //    //Sale Account
        //    //
        //    SQL.Remove(0, SQL.Length);
        //    SQL.Append(" INSERT INTO Acc_Sale  ");
        //    SQL.Append("\n ( Amount,Discount,TenderAmount,ReturnAmount,Date,fk_User ) values (");
        //    SQL.AppendFormat("\n {0}", totalAmount.ToString());
        //    SQL.AppendFormat("\n, {0}", discountAmount.ToString());
        //    SQL.AppendFormat("\n, {0}", tenderAmount.ToString());

        //    SQL.AppendFormat("\n, {0}", returnAmount.ToString());
        //    SQL.AppendFormat("\n, '{0}'", DateTime.Now.ToShortDateString());
        //    SQL.AppendFormat("\n, {0}", GlobalResources.LoginUserID);

        //    SQL.Append("\n)");
        //    int rsl = CrudeFx.GlobalResources.SelectDBConnection.ExecuteNonQuery(SQL.ToString());

        //    if (rsl == 1)
        //    {
        //        //save
        //    }

        //    SQL.Remove(0, SQL.Length);
        //    SQL.AppendFormat("SELECT MAX(id) FROM Acc_Sale WHERE FK_User = '{0}'", GlobalResources.LoginUserID);
        //    object O = CrudeFx.GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString());
        //    int accId = Convert.ToInt32(O);



        //    //
        //    //Inv_sale
        //    //


        //    foreach (DataRow dr in _dtItems.Rows)
        //    {
        //        SQL.Remove(0, SQL.Length);
        //        SQL.Append(" INSERT INTO Inv_Sale ");
        //        SQL.Append("\n ( fk_Product,fk_sale,Quantity,Amount,Discount,Remarks,Date,fk_User ) values (");
        //        SQL.AppendFormat("\n {0}", Conversion.ToString(dr, "fk_Product"));
        //        SQL.AppendFormat("\n, {0}", Conversion.ToString(dr, accId.ToString()));
        //        SQL.AppendFormat("\n, {0}", Conversion.ToString(dr, "Quantity"));

        //        SQL.AppendFormat("\n, {0}", Conversion.ToString(dr, "qamount"));
        //        SQL.AppendFormat("\n, {0}", Conversion.ToString(dr, "damount"));
        //        SQL.AppendFormat("\n, '{0}'", Conversion.ToString(dr, "Remarks"));
        //        SQL.AppendFormat("\n, '{0}'", DateTime.Now.ToShortDateString());
        //        SQL.AppendFormat("\n, {0}", GlobalResources.LoginUserID);
        //        SQL.Append("\n)");
        //        rsl = CrudeFx.GlobalResources.SelectDBConnection.ExecuteNonQuery(SQL.ToString());
        //    }
        //    Close();


        //}


        private int savetransaction(string customerId)
        {

            StringBuilder SQL = new StringBuilder();
            //
            //Update Sale Account
            //
            SQL.Remove(0, SQL.Length);
            SQL.Append(" INSERT INTO Acc_Sale  ");
            if (customerId != "")
            {
                SQL.Append("\n (Amount,fk_Customer_Master,CreditAmount,dueAmount, Discount,TenderAmount,ReturnAmount,Date,fk_User ) values (");
                SQL.AppendFormat("\n {0}", totalAmount.ToString());
                SQL.AppendFormat("\n, {0}", customerId);
                creditAmount = totalAmount - tenderAmount;
                SQL.AppendFormat("\n, {0}", creditAmount.ToString());
                SQL.AppendFormat("\n, {0}", creditAmount.ToString());

            }
            else
            {
                SQL.Append("\n ( Amount,Discount,TenderAmount,ReturnAmount,Date,fk_User ) values (");
                SQL.AppendFormat("\n {0}", totalAmount.ToString());

            }


            SQL.AppendFormat("\n, {0}", discountAmount.ToString());
            SQL.AppendFormat("\n, {0}", tenderAmount.ToString());

            SQL.AppendFormat("\n, {0}", returnAmount.ToString());
            SQL.AppendFormat("\n, '{0}'", DateTime.Now.ToString("yyyyMMdd"));
            SQL.AppendFormat("\n, {0}", GlobalValues.LoginUserID);

            SQL.Append("\n)");
            int rsl = GlobalResources.SelectDBConnection.ExecuteNonQuery(SQL.ToString());

            if (rsl == -1)
            {
                return 0;//save
            }

            SQL.Remove(0, SQL.Length);
            SQL.AppendFormat("SELECT MAX(id) FROM Acc_Sale WHERE FK_User = '{0}'", GlobalValues.LoginUserID);
            object accidObj = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString());
            int accId = 0;


            try
            { accId = Convert.ToInt32(accidObj.ToString()); }
            catch { }


            //
            //If success update Inv_sale
            //      

            foreach (DataRow dr in _dtItems.Rows)
            {
                SQL.Remove(0, SQL.Length);
                SQL.Append(" INSERT INTO Inv_Sale ");
                SQL.Append("\n ( fk_purchage,fk_sale,Quantity,Rate,CostPrice,Amount,Discount,NetAmount,Remarks,Date,fk_User ) values (");
                SQL.AppendFormat("\n {0}", Conversion.ToString(dr, "purchageId"));
                SQL.AppendFormat("\n, {0}", accId.ToString());
                SQL.AppendFormat("\n, {0}", Conversion.ToString(dr, "qty"));
                SQL.AppendFormat("\n, {0}", Conversion.ToString(dr, "rate"));
                SQL.AppendFormat("\n, {0}", Conversion.ToString(dr, "CostPrice"));//
                SQL.AppendFormat("\n, {0}", Conversion.ToString(dr, "qamount"));
                SQL.AppendFormat("\n, {0}", Conversion.ToString(dr, "damount"));
                SQL.AppendFormat("\n, {0}", Conversion.ToString(dr, "netamount"));
                SQL.AppendFormat("\n, '{0}'", Conversion.ToString(dr, "remarks"));
                SQL.AppendFormat("\n, '{0}'", DateTime.Now.ToString("yyyyMMdd"));
                SQL.AppendFormat("\n, {0}", GlobalValues.LoginUserID);

                SQL.Append("\n)");
                rsl = GlobalResources.SelectDBConnection.ExecuteNonQuery(SQL.ToString());
                //Update in products 
                string id;
                double soldqty;
                id = Conversion.ToString(dr, "purchageId");

                soldqty = Conversion.ToDouble(dr, "qty");
                UpdatequantityTOStore(id, soldqty);
            }
            return accId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReprint_Click(object sender, EventArgs e)
        {
            //if (printedonce)
            //{ printBill(_dtItems, 007); }
            //else { MessageBoxMy.Show("Bill not printed yet.", MessageBoxButtons.OK); }

        }
        bool printedonce;
        //private void printBill(DataTable billitems, int billno)
        //{
        //    try
        //    {
        //        printedonce = true;
        //     //   Pasal.Reports.crptbillp rptbill = new Pasal.Reports.crptbillp();
        //        rptbill.SetDataSource(billitems);
        //        rptbill.SetParameterValue("CompanyName", GlobalResources.OrganisationDetail.CompanyName());
        //        rptbill.SetParameterValue("Address", GlobalResources.OrganisationDetail.Address());
        //        rptbill.SetParameterValue("PhoneNo", "PhoneNo:" + GlobalResources.OrganisationDetail.Phone());
        //        rptbill.SetParameterValue("ReportTitle", "Bill");
        //        // setreportheadder(rptbill, "Bill");
        //        rptbill.SetParameterValue("Billno", billno.ToString());
        //        rptbill.SetParameterValue("Date", DateTime.Today.ToShortDateString());
        //        rptbill.SetParameterValue("InWords", lblInWords.Text);
        //        rptbill.SetParameterValue("GrandTotal", sevenPayAmount.Value.ToString());
        //        if (printedonce)
        //        {
        //            rptbill.SetParameterValue("Reprint", "");
        //            rptbill.SetParameterValue("lblReprint", "");
        //        }
        //        else
        //        {
        //            rptbill.SetParameterValue("Reprint", "Reprinted");
        //            rptbill.SetParameterValue("lblReprint", "");
        //        }
        //        rptbill.SetParameterValue("customername", txtCustomerName.Text);
        //        rptbill.PrintToPrinter(1, false, 1, 1);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Please try again later. Bill cannot be printed!" + ex.ToString());
        //    }
        //}
        DataTable _billItems;
        int _billNo;
        string _tender;
        string _discount;
        string _shop;
        string _return;
        string _sevenPay;
        private void WindowThreadPrintBill()
        {
            //clsPrinting prnt = new clsPrinting(_billItems, sevenPayAmount.Value.ToString(), _billNo.ToString());
            //prnt.Print();
            Invoice inv = new Invoice();

            (new Invoice()).Print(_billNo.ToString(), DateTime.Now.ToString(), _sevenPay, _shop
                 , _discount, _tender, _return, _billItems);
        }

        private void printBillGDI(DataTable billitems, int billno)
        {
            _tender = txtTender.Text;
            _billItems = billitems;
            _billNo = billno;
            _sevenPay = sevenPayAmount.Value.ToString();
            _shop = sevenShoppingAmount.Value.ToString();
            _discount = sevenDiscount.Value.ToString();
            _return = sevenReturn.Value.ToString();


            System.Threading.Thread t = new Thread(new ThreadStart(WindowThreadPrintBill));
            t.IsBackground = true;// the main form will close (when closing child form) if this is set .
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }


        //private int getComboID()
        //{
        //    //string id;
        //    //ComboItem ci = (ComboItem)cboPurchage.SelectedItem;
        //    //id = ci.Key.ToString();
        //    //return Convert.ToInt16(id);
        //    return 1;
        //}
        private string getSoldquantity(string purchageId)
        {

            string quantity;
            StringBuilder SQL = new StringBuilder();
            try
            {
                SQL.Append("SELECT quantity_sold from Inv_Purchase where id = " + purchageId.ToString());
                quantity = GlobalResources.SelectDBConnection.ExecuteScalar(SQL.ToString()).ToString();
                if (quantity != "")
                {
                    return quantity;
                }
            }
            catch
            {
                return "0";
            }
            return "0";
        }

        private void UpdatequantityTOStore(string Purchageid, double soldQty)
        {
            double totalsoldquantity;
            totalsoldquantity = Convert.ToDouble(getSoldquantity(Purchageid));
            totalsoldquantity += soldQty;
            StringBuilder SQL1 = new StringBuilder();
            SQL1.Append("UPDATE Inv_Purchase set quantity_sold = ");
            SQL1.AppendFormat(" {0} ", totalsoldquantity);
            SQL1.AppendFormat("where id = {0} ", Purchageid.ToString());
            GlobalResources.SelectDBConnection.ExecuteNonQuery(SQL1.ToString()).ToString();

        }
        string CustomerId = "", customerName = "";
        private void fsBrowse_Click(object sender, EventArgs e)
        {
            Pasal.Forms.frmCustomerList frm = new Pasal.Forms.frmCustomerList();
            frm.FormType = FormTypes.SelectionForm;
            // frm.toolStrip1.Enabled = false;
            frm.valueSelected += new ListingFormBase.ValueSelected(frm_valueSelected);
            frm.ShowDialog(this);

 
        }

        void frm_valueSelected(object sender, string SelectedPrimaryKey)
        {

            DataGridViewRow row = (DataGridViewRow)((ListingFormBase)sender).SelectedValue;
           // DataGridViewRow row = (DataGridViewRow)frm.SelectedValue;

            //string namefrst = Conversion.ToString(row, "colName");
            //string namelst = Conversion.ToString(row, "colLastName");
            //CustomerId = Conversion.ToString(row, "colId");
            //row["colId"]


            string namefrst = row.Cells["colName"].Value.ToString();
            string namelst = row.Cells["colLastName"].Value.ToString();
            CustomerId = row.Cells["colId"].Value.ToString();

            //SelectComboValue(cboProduct, KEY);
            customerName = namefrst + " " + namelst;
            txtCustomerName.Text = customerName;
        }




    }
}
