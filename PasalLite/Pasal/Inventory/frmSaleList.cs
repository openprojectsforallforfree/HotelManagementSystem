using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Friuts;
using Bsoft.Forms;
using Bsoft.Utility;
using Bsoft.Common;
//using Pasal.Reports;
namespace Pasal.Inventory
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteToolbar_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void ExitToolbar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSaleList_Load(object sender, EventArgs e)
        {
            if (count > 5)
            {
                MessageBoxMy.Show("Too Many Shopping Carts,Please Close some Shopping Carts.");
                
            }
            if (count ==0)
            {
                CartNumber = 0;
            }
            count++;
            CartNumber++;
            Text = "Shopping Cart " + CartNumber.ToString();
            TableName = "Inv_Sale";
            SetDataGridViewProperties(grid);
            btnAddItem.Select();
        }
        public void SetDataGridViewProperties(DataGridView dataGridView)
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;

            dataGridView.MultiSelect = false;

            //dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            //dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView.RowHeadersWidth = 54;

            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;

            dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;

            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.Font = dataGridView.ColumnHeadersDefaultCellStyle.Font;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;

            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(223)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = dataGridView.DefaultCellStyle.Font;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridViewCellStyle3.NullValue = string.Empty;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.EnableHeadersVisualStyles = false;

            dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;

            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(65)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle4.Font = dataGridView.RowHeadersDefaultCellStyle.Font;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.StandardTab = true; //required...

            dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(223)))), ((int)(((byte)(224)))));
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (grid.Rows.Count < 1)
            {
                MessageBoxMy.Show("Please have some Data first", MessageBoxButtons.OK);
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("sn");
            dt.Columns.Add("purchageId");
            dt.Columns.Add("description");
            dt.Columns.Add("rate");//mrp
            dt.Columns.Add("qty");
            dt.Columns.Add("qamount");
            dt.Columns.Add("damount");
            dt.Columns.Add("netamount");
            dt.Columns.Add("remarks");
            dt.Columns.Add("CostPrice");//hidden form customer
            int count = 1;
            foreach (DataGridViewRow row in grid.Rows)
            {
                DataRow dr = dt.Rows.Add();
                dr["sn"] = count.ToString();
                dr["purchageId"] = row.Cells["colpurchageId"].Value;//added dec 2010
                dr["description"] = row.Cells["colDescription"].Value;
                dr["rate"] = row.Cells["colRate"].Value;
                dr["qty"] = row.Cells["colQuantity"].Value;
                dr["qamount"] = row.Cells["colAmount"].Value;//qamount as for crpt
                dr["CostPrice"] = row.Cells["colCostPrice"].Value;
                dr["damount"] = row.Cells["colDiscount"].Value;//damount as for crpt
                dr["netamount"] = row.Cells["colnetAmount"].Value;
                dr["remarks"] = row.Cells["colRemarks"].Value;
                count++;
            }
            Forms.frmPay frm = new Forms.frmPay(totalamount, totaldiscount, dt);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (MessageBoxMy.Show("Thankyou ! the data is saved \nReady for next Transaction ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    RefreshforNew();
                }
                else
                {
                    Close();
                }
            }
        }

        private void RefreshforNew()
        {
            rowcount = -1;
            totalamount = 0;
            totaldiscount = 0;
            txtTotalCash.Text = "0";
            txtTotalDiscount.Text = "0";
            grid.Rows.Clear();
        }
        int rowcount = -1;
        decimal totalamount = 0, totaldiscount = 0;
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            addEditItem(); 
        }
        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedRow = 0;
                selectedRow = grid.SelectedCells[0].RowIndex;
                string prId = grid["colfk_Product", selectedRow].Value.ToString();
                if (prId.Trim() != "")
                {
                    Inventory.frmSaleEntry frm = new Inventory.frmSaleEntry();
                    frm.txtProduct.Text = grid["colfk_Product", selectedRow].Value.ToString();//ci.Key.ToString();
                    frm.purchageId = grid["colpurchageId", selectedRow].Value.ToString();
                    frm.txtQuantity.Text = grid["colQuantity", selectedRow].Value.ToString();
                    frm.txtDiscount.Text = grid["colDiscount", selectedRow].Value.ToString();
                    frm.txtRemarks.Text = grid["colRemarks", selectedRow].Value.ToString();
                    frm.txtGroup_Code.Text = grid["grp_Code", selectedRow].Value.ToString();
                    frm.ProductIsSelected(prId);
                    //calc in frm
                    frm.blnFromEdit = true;
                    frm.selectSuitableGridItem(frm.purchageId);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            //check if already added item
                            foreach (DataGridViewRow dgvr in grid.Rows)
                            {
                                if (dgvr.Cells["colfk_Product"].Value.ToString().Trim() == frm.txtProduct.Text.Trim() & dgvr.Cells[0].RowIndex != selectedRow )
                                {
                                    MessageBoxMy.Show("Product already added", MessageBoxButtons.OK);
                                    return;
                                }
                            }

                            grid["colfk_Product", selectedRow].Value = frm.txtProduct.Text;//ci.Key.ToString();
                            grid["colpurchageId", selectedRow].Value = frm.purchageId;
                            grid["colRate", selectedRow].Value = frm.txtRate.Text;
                            grid["colCostPrice", selectedRow].Value = frm.costPrice;
                            grid["colQuantity", selectedRow].Value = frm.txtQuantity.Text;
                            grid["colDescription", selectedRow].Value = frm.lblName.Text;
                            grid["colAmount", selectedRow].Value = frm.txtAmount.Text;
                            grid["colDiscount", selectedRow].Value = frm.txtDiscount.Text;
                            grid["grp_Code", selectedRow].Value = frm.txtGroup_Code.Text;


                            decimal netamount;
                            decimal damount, amount;
                            damount = Convert.ToDecimal(frm.txtDiscount.Text);
                            amount = Convert.ToDecimal(frm.txtAmount.Text);
                            netamount = amount - damount;

                            grid["colnetAmount", selectedRow].Value = netamount.ToString();
                            grid["colRemarks", selectedRow].Value = frm.txtRemarks.Text;

                            UpdateTotals();
                        }
                        catch (Exception ex)
                        {
                            MessageBoxMy.Show(ex.Message, MessageBoxButtons.OK);
                        }
                    }

                }
            }
            catch
            { 
            }

        
        }

         

        private void addEditItem()
        {
            Boolean blnAlreadyAdded = false;
            Inventory.frmSaleEntry frm = new Inventory.frmSaleEntry();
            if (frm.ShowDialog(this ) == DialogResult.OK)
            {
                //check if already added item
                foreach (DataGridViewRow dgvr in grid.Rows)
                {
                    if (dgvr.Cells["colfk_Product"].Value.ToString().Trim() == frm.txtProduct.Text.Trim())
                    {
                        MessageBoxMy.Show("Product already added", MessageBoxButtons.OK);
                        blnAlreadyAdded = true;
                    }
                }
                if (blnAlreadyAdded == true)
                {
                    return;
                }
                try
                {
                    grid.Rows.Add();
                    rowcount++;
                    //ComboItem ci = (ComboItem)frm.cboProduct.SelectedItem;
                    //  grid["colId", rowcount].Value = frm.txtProduct.Text;
                    grid["colfk_Product", rowcount].Value = frm.txtProduct.Text;//ci.Key.ToString();
                    grid["colpurchageId", rowcount].Value = frm.purchageId;
                    grid["colRate", rowcount].Value = frm.txtRate.Text;
                    grid["colCostPrice", rowcount].Value = frm.costPrice;
                    grid["colQuantity", rowcount].Value = frm.txtQuantity.Text;
                    grid["colDescription", rowcount].Value = frm.lblName.Text;
                    grid["colAmount", rowcount].Value = frm.txtAmount.Text;
                    grid["colDiscount", rowcount].Value = frm.txtDiscount.Text;

                    grid["grp_Code", rowcount].Value = frm.txtGroup_Code.Text;
 

                    decimal netamount;
                    decimal damount, amount;
                    damount = Convert.ToDecimal(frm.txtDiscount.Text);
                    amount = Convert.ToDecimal(frm.txtAmount.Text);
                    netamount = amount - damount;

                    grid["colnetAmount", rowcount].Value = netamount.ToString();
                    grid["colRemarks", rowcount].Value = frm.txtRemarks.Text;

                    UpdateTotals();
                }
                catch (Exception ex)
                {
                    MessageBoxMy.Show(ex.Message, MessageBoxButtons.OK);
                    grid.Rows.RemoveAt(grid.Rows.Count - 1);
                    rowcount--;
                }
            }
            else { }
        }
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {

            int cnt = 0;
            int selRow = 0;
            if (grid.CurrentRow == null)
            {
                return;
            }
            selRow = grid.CurrentRow.Index;
            if (selRow >= 0)
            {
                grid.Rows.RemoveAt(selRow);
                rowcount--;
            }
            //Serioal No. Res-Set compulosry required...


            UpdateTotals();

        }

        private void UpdateTotals()
        {
            int cnt = 0;
            totalamount = 0; totaldiscount = 0;
            foreach (DataGridViewRow row in grid.Rows)
            {
                row.HeaderCell.Value = Convert.ToString(++cnt);
                totalamount +=  Conversion.ToDecimal(row, "colAmount");
                totaldiscount +=  Conversion.ToDecimal(row, "colDiscount");

                //totalamount += Convert.ToDecimal(row.Cells["colAmount"].Value);
                //totaldiscount += Convert.ToDecimal(row.Cells["colDiscount"].Value);

            }

            txtTotalCash.Text = totalamount.ToString();
            txtTotalDiscount.Text = totaldiscount.ToString();

        }
        private void grid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //if (grid .HitTest(e.X, e.Y).RowY < 5)
            //    return;

            //if (e.Button != MouseButtons.Left)
            //    return;
            ////when the user presses enter key open the edit form
            ////SetPrimaryKeyValue();
            ////DataGridView.HitTestInfo hitTest = _dataGridView.HitTest(_dataGridView.Columnh
            ////MessageBox.Show(_dataGridView.HitTest().RowIndex);
            //switch (FormType)
            //{
            //    case FormTypes.SelectionForm:
            //        ReturnSelectedValue();
            //        break;
            //    case FormTypes.ListingForm:
            //        OpenEditForm();
            //        break;
            //    default:
            //        throw new Exception(string.Format("Feature not supported by the FormType =>{0}", FormType.ToString()));
            //}
        }

        public DataSet getDataTable(DataGridView grd)
        {
            //By Dhiraj October 2008

            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            DataRow dr;

            for (int col = 0; col < grd.Columns.Count; col++)
            {
                dt.Columns.Add(grd.Columns[col].Name.ToString());
            }

            for (int row = 0; row < grd.RowCount; row++)
            {
                dr = dt.NewRow();
                for (int col = 0; col < grd.Columns.Count; col++)
                {
                    dr[col] = grd.Rows[row].Cells[col].Value;
                }
                dt.Rows.Add(dr);
            }

            dt.AcceptChanges();
            ds.Tables.Add(dt);
            return ds;

        }

        private void fsButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSaleList_FormClosed(object sender, FormClosedEventArgs e)
        {
            count--;
        }

       

        //private void setreportheadder(crptbill rpt, string Title)
        //{


        //    string companyName = "", address1 = "", Telephone = "", fax = "", url = "", email = "", address2 = "", address3 = "", address4 = "", phone = "";

        //    DataTable dt = new DataTable();
        //    StringBuilder SQL = new StringBuilder();
        //    SQL.Append("select * from company");
        //    dt = GlobalResources.SelectDBConnection.ExecuteDataTable(SQL.ToString());
        //    if (dt.Rows.Count > 0)
        //    {
        //        // lblid.Text= dt.Rows[0]["id"].ToString();


        //        companyName = dt.Rows[0]["Name"].ToString();

        //        phone = dt.Rows[0]["Phone"].ToString();

        //        fax = dt.Rows[0]["Fax"].ToString();

        //        url = dt.Rows[0]["Url"].ToString();

        //        email = dt.Rows[0]["Email"].ToString();

        //        address1 = dt.Rows[0]["AddressLine1"].ToString();

        //        address2 = dt.Rows[0]["AddressLine2"].ToString();

        //        address3 = dt.Rows[0]["AddressLine3"].ToString();

        //        address4 = dt.Rows[0]["AddressLine4"].ToString();


        //    }

        //    rpt.SetParameterValue("CompanyName", companyName);
        //    rpt.SetParameterValue("Address", address1);
        //    rpt.SetParameterValue("PhoneNo", "Tel: " + phone);
        //    rpt.SetParameterValue("FaxNo", "Fax: " + fax);
        //    rpt.SetParameterValue("ReportTitle", Title);

        //}

        //private void printBill()
        //{

        //    string billNumber = "", customerName = "", billdate = "", rePrint = "", grandTotal = "";
        //    try
        //    {
        //        DataSet billitems = new DataSet();
        //        billitems = getDataTable(grid);

        //        crptbill rptbill = new crptbill();
        //        rptbill.SetDataSource(billitems.Tables[0]);

        //        setreportheadder(rptbill, "Bill");
        //        rptbill.SetParameterValue("Billno", billNumber);

        //        rptbill.SetParameterValue("CustomerName", customerName);


        //        rptbill.SetParameterValue("Date", billdate);



        //        rptbill.SetParameterValue("InWords", rePrint);
        //        rptbill.SetParameterValue("Reprint", "");
        //        rptbill.SetParameterValue("lblReprint", "");
        //        rptbill.SetParameterValue("GrandTotal", grandTotal);
        //        rptbill.PrintToPrinter(1, false, 1, 1);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Please try again later. Bill cannot be printed!" + ex.ToString());
        //    }
        //}
    }
}
