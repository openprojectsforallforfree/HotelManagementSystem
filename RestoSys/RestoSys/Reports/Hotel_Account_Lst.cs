using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using Bsoft.Common;
using Bsoft.Common.Utilities;
namespace UEMS
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class Hotel_Account_Lst : Friuts.ListingFormBase
    {
        public Hotel_Account_Lst()
        {
            InitializeComponent();
            FormType = FormTypes.Report;
            ListingDataGridView = grid;

            TableName = "Hotel_Account";
            DataTableColumns.Add("id", ColumnTypes.Number, "colid", true, true);
            DataTableColumns.Add("Amount", ColumnTypes.AmountRound, "colAmount");
            DataTableColumns.Add("PaidAmount", ColumnTypes.AmountRound, "colPaidAmount");
            //DataTableColumns.Add("TenderAmount", ColumnTypes.AmountRound, "colTenderAmount");
            //DataTableColumns.Add("ReturnAmount", ColumnTypes.AmountRound, "colReturnAmount");

            //DataTableColumns.Add("TenderAmount- ReturnAmount collection", ColumnTypes.AmountRound, "colCollection", false, true, true, "collection");

            DataTableColumns.Add("Date", ColumnTypes.EnglishDate, "colDate");
            DataTableColumns.Add("UserId", ColumnTypes.String, "colUser");
            DataTableColumns.Add("fk_Master_Customer", ColumnTypes.String, "colfk_Master_Customer");
            RelationList.Add("fk_Master_Customer", "Master_Customer", "id", "Name", "colCustomer");
            RelationList.Add("fk_Master_Customer", "Master_Customer", "id", "LastName", "colLastName");
            dateFromTo21.dtFrom.ValueChanged += new EventHandler(dtTo_ValueChanged);
            dateFromTo21.dtTo.ValueChanged += new EventHandler(dtTo_ValueChanged);

            ComboBoxDataLoader loader = new ComboBoxDataLoader();
            loader.ComboLoadinfoItems.Add("ID", "EngName", "SuperAdmin_Rights_Users", cboUser, false);
            loader.LoadDataInComboBoxes();
        }
        string _accountId = string.Empty;
        public Hotel_Account_Lst(string accountId)
            : this()
        {
            toolStrip1.Visible = false;
            groupBox1.Visible = false;
            grid.Height = grid.Bottom - groupBox1.Top;
            grid.Top = groupBox1.Top;
            _accountId = accountId;
        }

        public override bool LoadData()
        {
            bool b = base.LoadData();
            lblCollectionSum.Text = "Total Collection from Date {0} to {1} is Rs : {2}".With(dateFromTo21.dtFrom.Value.ToShortDateString(),
                dateFromTo21.dtTo.Value.ToShortDateString(),
               StringUtilities.GetMoneyFromat(GridUtility.GetSum(grid, "colPaidAmount")));
            return b;
        }

        private void ExportToolbar_Click(object sender, EventArgs e)
        {
            Reports.ExcelReport excel = new Reports.ExcelReport(this.Text, 4, grid);
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Hotel_Account_Lst_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public override string GetWhereClauseForSelect()
        {

            if (_accountId.Length > 0)
            {
                _accountId = _accountId.Replace("][", ",");
                _accountId = _accountId.Replace("]", "");
                _accountId = _accountId.Replace("[", "");
                return "where t1_id in ({0})".With(_accountId);
            }
            string sql = " where 1=1 ";
            if (txtBillNo .Text .Trim ().Length >0)
            {
                if (txtBillNo .Text .Contains (","))
                {
                    string[] temp = txtBillNo.Text.Split(',');
                    foreach (string item in temp)
                    {
                        sql = sql + " and  t1.id in '{0}'".With(txtBillNo.Text.Trim());
                    }
                }
                else if (txtBillNo.Text.Contains("-"))
                {
                    string[] temp = txtBillNo.Text.Split(',');
                    if (temp .Length >1)
                    {
                        sql = sql + " and  t1.id >= {0} and t1.id <= {1}".With(temp [0],temp [1]);
                    }
                }
                else
                {
                sql = sql + " and  t1.id = '{0}'".With(txtBillNo .Text .Trim ());
                }
            }
            if ((ComboItem)cboUser.SelectedItem != null)
            {
                string userid = ((ComboItem)cboUser.SelectedItem).Key;
                userid = RestoSys.DAl.UserDAL.GetUserId(userid);
                if (userid.Length > 0)
                {
                    sql = sql + " and  t1.UserID = '{0}'".With(userid);
                }
            }
            if (txtCustomerName .Text.Trim () .Length >0)
            {
                sql = sql + " and  (t2_LastName like '%{0}%' or t2_Name like '%{0}%' )".With (txtCustomerName .Text );
            }
            sql = sql + string.Format(@" and 
                    date >= {0} and date <= {1}
                    ", dateFromTo21.dtFrom.Value.ToString("yyyyMMdd"), dateFromTo21.dtTo.Value.ToString("yyyyMMdd"));
            return sql;
        }

        private void cboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void toolAccount_Click(object sender, EventArgs e)
        {

            RoomBookingView_Lst rbv = new RoomBookingView_Lst(GetSelectedRowPrimaryKey());
            rbv.Text = "Details of payment";
            rbv.Show();
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtBillNo_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        
    }
}
