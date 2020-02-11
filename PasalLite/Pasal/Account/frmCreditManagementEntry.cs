using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using UEMS.BLL;
using Bsoft.Forms;
using Bsoft.AppCom;
using Bsoft.Data;
namespace Pasal.Account
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmCreditManagementEntry : Friuts.EntryFormBase
    {
        string creditId;
        decimal  dueamount,creditamount;
        public frmCreditManagementEntry()
        {
            InitializeComponent();
        }
        public frmCreditManagementEntry(string _creditId,string _cust_userid,string _CreditAmount,string _dueAmount,string _cust_name,string _cust_address)
        {
            InitializeComponent();
            creditId = _creditId;
            
            lblcust_address.Text = _cust_address;
            lblcust_name.Text = _cust_name;
            lblcust_userid.Text = _cust_userid;
            lblsale_dueAmount.Text = _dueAmount;
            lblsale_CreditAmount.Text = _CreditAmount;
            dueamount = Convert.ToDecimal(_dueAmount);
            creditamount = Convert.ToDecimal(_CreditAmount);
            dueamount = Math.Round(dueamount, 2);
            creditamount = Math.Round(creditamount, 2);

            lblsale_dueAmount.Text = dueamount.ToString ();
            lblsale_CreditAmount.Text = creditamount.ToString ();

            FormType = FormTypes.EntryForm;
        }

        private void frmCreditManagementEntry_Load(object sender, EventArgs e)
        {
            TableName = "Acc_CreditPayBack";
            ColumnList.AddNewEditColumn("id", ColumnTypes.Number, txtid, true, false);
            ColumnList.AddNewEditColumn("fk_Acc_Sale", ColumnTypes.Number, creditId );
            ColumnList.AddNewEditColumn("PayBackAmount", ColumnTypes.Number, txtPayBackAmount);
            ColumnList.AddNewEditColumn("Remarks", ColumnTypes.String, txtRemarks);
            //ColumnList.AddNewEditColumn("fk_Customer_Master", ColumnTypes.Number, txtcustomerId.Text);          
            ColumnList.AddNewEditColumn("fk_User", ColumnTypes.Number, GlobalValues.LoginUserID);
            ColumnList.AddNewEditColumn("Date", ColumnTypes.String, DateTime.Now.ToString("yyyyMMdd"));
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            decimal paybackAmount = 0;
            paybackAmount = Convert.ToDecimal(txtPayBackAmount.Text);
            if (paybackAmount == 0)
            {
                MessageBoxMy.Show("Please put in the paybackAmount.", MessageBoxButtons.OK);
                return; 
            }
            if (paybackAmount > dueamount)
            {
                MessageBoxMy.Show("Please dont put a pay back amount more than due amount.", MessageBoxButtons.OK);
                return;
            }
            
            if (Save())
            {
                UpdatePaymentToAccSale(paybackAmount);
                DialogResult = DialogResult.OK;
            }
        }
        private void UpdatePaymentToAccSale(decimal paybackAmount)
        {
            dueamount -= paybackAmount;
            
            //double quantityinstore = quantity - damageqty;

            //double totaldamagequantity;

            //totaldamagequantity = Convert.ToDouble(getDamagequantity(id));
            StringBuilder SQL = new StringBuilder();
            SQL.Append("UPDATE Acc_Sale set DueAmount = ");
            SQL.AppendFormat(" {0} ", dueamount.ToString ());
            SQL.AppendFormat("where id = {0} ", creditId);
            GlobalResources.SelectDBConnection.ExecuteNonQuery(SQL.ToString()).ToString();

            //totaldamagequantity += damageqty;

            //StringBuilder SQL1 = new StringBuilder();
            //SQL1.Append("UPDATE Product_Master set quantity_damage = ");
            //SQL1.AppendFormat(" {0} ", totaldamagequantity);
            //SQL1.AppendFormat("where id = {0} ", id.ToString());
            //GlobalResources.SelectDBConnection.ExecuteNonQuery(SQL1.ToString()).ToString();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            
        }
    }
}

