using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;

namespace Pasal.Forms
{
    [System.ComponentModel.DesignerCategory("form")]
    public partial class frmCreditManagementList : Friuts.ListingFormBase 
    {
        public frmCreditManagementList()
        {
            InitializeComponent();
            FormType = FormTypes.SelectionForm;
            ListingDataGridView = grid;
            TableName = "Acc_CreditPayBack";
            loadDataGrid();
        }
        private void loadDataGrid()
        {
            DataTableColumns.Add("sale_id", ColumnTypes.Number, "colsale_id", true, true);
            DataTableColumns.Add("cust_name", ColumnTypes.String, "colcust_name");
            DataTableColumns.Add("cust_userid", ColumnTypes.String, "colcust_userid");
            DataTableColumns.Add("cust_address", ColumnTypes.String, "colcust_address");
            DataTableColumns.Add("cust_phone", ColumnTypes.String, "colcust_phone");
            DataTableColumns.Add("sale_dueAmount", ColumnTypes.Number, "colsale_dueAmount");
            DataTableColumns.Add("sale_CreditAmount", ColumnTypes.Number, "colsale_CreditAmount");
            DataTableColumns.Add("sale_Amount", ColumnTypes.Number, "colsale_Amount");
            DataTableColumns.Add("sale_Discount", ColumnTypes.Number, "colsale_Discount");
            DataTableColumns.Add("sale_Tender", ColumnTypes.Number, "colsale_Tender");
            DataTableColumns.Add("sale_date", ColumnTypes.String, "colsale_date");
            RelationList.Add("t1_fk_User", "Rights_Users", "id", "Name", "colfk_User");









        }
        public override bool GenerateSelectSQL()
        {  
            StringBuilder SQL = new StringBuilder();
            SQL.Append(" \nSELECT sale.id");
            SQL.Append(" \nsale_id");
            SQL.Append(" \n,cast(cust.Name as nvarchar)+' ' + cast(cust.LastName as nvarchar) ");
            SQL.Append(" \ncust_name");
            SQL.Append(" \n,cust.userid");
            SQL.Append(" \ncust_userid");
            SQL.Append(" \n,cust.address");
            SQL.Append(" \ncust_address");
            SQL.Append(" \n,cust.phone");
            SQL.Append(" \ncust_phone");
            SQL.Append(" \n,sale.[DueAmount]  ");
            SQL.Append(" \nsale_dueAmount");
            SQL.Append(" \n,sale.[CreditAmount]  ");
            SQL.Append(" \nsale_CreditAmount");
            SQL.Append(" \n,sale.Amount");
            SQL.Append(" \nsale_Amount");
            SQL.Append(" \n,sale.[Discount]");
            SQL.Append(" \nsale_Discount");
            SQL.Append(" \n,sale.[TenderAmount]");
            SQL.Append(" \nsale_Tender");
            SQL.Append(" \n,sale.[ReturnAmount]");
            SQL.Append(" \n,sale.[Date]");
            SQL.Append(" \nsale_date");
            SQL.Append(" \n,sale.[fk_User]");
            SQL.Append(" \nsale_fk_user");
            SQL.Append(" \nFROM Acc_Sale sale");
            SQL.Append(" \nleft outer join");
            SQL.Append(" \ncustomer_master cust on");
            SQL.Append(" \nsale.fk_Customer_Master = cust.Id");
            SQL.Append(" \nwhere ");
            SQL.Append(" \n[DueAmount]>0");

            SelectSQL = SQL.ToString();
            return true;
        }


        public override string GetWhereClauseForSelect()
        {
            StringBuilder sqlNew = new StringBuilder();
            return "";
        }
        private void AddSearchCriteria()
        {
            SearchConditionList.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGetPayment_Click(object sender, EventArgs e)
        {
            if (grid .Rows .Count <1)
            {
                return;
            }
            SetSelectedValue();
            DataGridViewRow row = (DataGridViewRow)SelectedValue ;
            string KEY = row.Cells["colsale_id"].Value.ToString();
            string cust_userid,CreditAmount,dueAmount,cust_name,cust_address;
            
            cust_userid = row.Cells["colcust_userid"].Value.ToString();
            CreditAmount = row.Cells["colsale_CreditAmount"].Value.ToString();
            dueAmount = row.Cells["colsale_dueAmount"].Value.ToString();
            cust_name = row.Cells["colcust_name"].Value.ToString();
            cust_address = row.Cells["colcust_address"].Value.ToString();

            if (KEY != "")
            {
                btnGetPayment.DialogResult = DialogResult.None;
                Pasal.Account.frmCreditManagementEntry crm = new Pasal.Account.frmCreditManagementEntry(KEY,cust_userid,CreditAmount,dueAmount,cust_name,cust_address);
                crm.ShowDialog();
            }
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {


            showdetails();
           

           
        }


        private void showdetails()
        {
            try
            {
                if (grid.Rows.Count < 1)
                {
                    return;
                }
                // SetSelectedValue();
                //  DataGridViewRow row = (DataGridViewRow)SelectedValue;
                DataGridViewRow row = (DataGridViewRow)grid.CurrentRow;
                string KEY = row.Cells["colsale_id"].Value.ToString();

                if (KEY != "")
                {
                    //   Pasal.Account.Form1 frm = new Pasal.Account.Form1();
                    // frm.grid.Parent = this.panelItems ;
                    this.SuspendLayout();
                    Pasal.Account.frmCreditItemList frm = new Pasal.Account.frmCreditItemList(KEY);
                    frm.Dataload();
                    //panelItems.Visible =false ;
                    //frm.grid.Location = panelItems.Location;
                    //frm.grid.Size = panelItems.Size;
                    //frm.grid.Refresh();
                    //frm.grid.Parent = this ;
                    
                    //this.ResumeLayout();
                      frm.ShowDialog();
                }
            }
            catch { }

        }
       

        private void grid_SelectionChanged(object sender, EventArgs e)
        {
        //    showdetails();
        }
    }
}

