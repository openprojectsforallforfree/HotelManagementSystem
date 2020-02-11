using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using Bsoft.Forms;
 
using Bsoft.Common;
using RestoSys.BLL;
using Bsoft.Common.Utilities;
//using RestoSys.Reports;
namespace RestoSys.Inventory
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmSaleList : Friuts.FormBase
    {
        public static long count = 0;
        public static long CartNumber = 0;
        public frmSaleList()
        {
            InitializeComponent();
            FormType = FormTypes.ListingForm;
        }

        private void frmSaleList_Load(object sender, EventArgs e)
        {
            if (count > 5)
            {
                MessageBoxMy.Show("Too Many Shopping Carts,Please Close some Shopping Carts.");

            }
            if (count == 0)
            {
                CartNumber = 0;
            }
            count++;
            CartNumber++;
            Text = "Shopping Cart " + CartNumber.ToString();
            TableName = "Inv_Sale";
        }

        private void frmSaleList_FormClosed(object sender, FormClosedEventArgs e)
        {
            count--;
        }
    }
}
