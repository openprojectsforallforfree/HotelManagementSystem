using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RestoSys.UserControls;
using Friuts;
using Bsoft.Forms;
using Bsoft.Common;
using Bsoft.AppCom;
using RestoSys.BLL;
using RestoSys.Inventory;
using Bsoft.Common.Utilities;

namespace RestoSys.RestaurantBilling
{
    public partial class AnOrder : UserControl
    {
        public delegate void CancelOrderHandler(object sender);
        public event CancelOrderHandler cancelOrder;
        public GridCalculator gridCalculator = null;
        public AnOrder()
        {
            InitializeComponent();
            GridUtility.SetDataGridViewProperties(grid);
            //tagsControl.addMoreTagClicked += new TagsControl.AddClickedHandler(tagsControl_addMoreTagClicked);
            grid.EditMode = DataGridViewEditMode.EditOnEnter;
            GridUtility gu = new GridUtility();
            gu.SetProperties(grid);
            GridUtility.SetDataGridViewProperties(gridSummary);
            btnAddItem.Select();
            Bsoft.Design.FormDesginBase db = new Bsoft.Design.FormDesginBase();
            discountControl.txtAmount.Enter += db.tb_Enter;
            discountControl.txtAmount.Leave += db.tb_Leave;

            discountControl.txtPercent.Enter += db.tb_Enter;
            discountControl.txtPercent.Leave += db.tb_Leave;
            gridCalculator = new GridCalculator(grid, gridSummary, this.discountControl);

        }

        #region Edit Items
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Inventory.frmSaleEntry frm = new Inventory.frmSaleEntry(StockType.Sales);
            if (frm.ShowDialog(this) == DialogResult.OK)
            {
                ItemDetails item = new ItemDetails();
                item.productId = frm.txtProduct.Text;
                item.purchaseId = frm.purchageId;
                item.rate = Convert.ToDecimal(frm.txtRate.Text);
                item.costPrice = Convert.ToDecimal(frm.costPrice); ;
                item.description = frm.lblName.Text;
                item.code = frm.txtGroup_Code.Text;
                GridCalculator.IncreaseQuantity(grid, item, frm.txtQuantity.Text.ToDecimal());
                gridCalculator.DisplaySummaryGrid();

            }
            else { }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            int selRow = 0;
            if (grid.CurrentRow == null)
            {
                return;
            }
            selRow = grid.CurrentRow.Index;
            if (selRow >= 0)
            {
                grid.Rows.RemoveAt(selRow);
            }
            //Serioal No. Res-Set compulosry required...
            GridUtility.SetGridRowSerialNo(grid);
            gridCalculator.DisplaySummaryGrid();
        }

        //qty changed
        private void grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)//quantity index=1
            {
                //qty changed
                //set discount = 0 
                GridUtility.UpdateARow(grid, e.RowIndex, ItemDetails.Fields.discount, 0);
                //Escalate_DiscountChanged(discountControl.DiscountAmount);
            }
            else
            {
                //discount changed
            }
            GridCalculator.UpdateSingleRowAmounts(grid, e.RowIndex);
            gridCalculator.DisplaySummaryGrid();
        }

        //total discount updated
        private void discountControl_DiscountUpdated(decimal percent, decimal discountAmount, bool userEnteredValue)
        {
            if (userEnteredValue)
            {
                DataTable dtitems = new DataTable();

                if (!Escalate_DiscountChange_CheckMax(discountAmount, percent, dtitems))
                {
                    discountControl.Focus();
                    return;
                }
                Escalate_DiscountChange(discountAmount, percent, dtitems);

            }
        }
        #endregion


        #region Escalate Discount

        public bool Escalate_DiscountChange_CheckMax(decimal totalDiscount, decimal discountPercent, DataTable dtItems)
        {
            decimal maxPermissibleDiscount = 0;

            dtItems.Columns.Add("rate", typeof(decimal));
            dtItems.Columns.Add("qty", typeof(decimal));
            dtItems.Columns.Add("cost", typeof(decimal));
            dtItems.Columns.Add("amount", typeof(decimal));
            dtItems.Columns.Add("maxdiscount", typeof(decimal));
            dtItems.Columns.Add("discount", typeof(decimal));
            dtItems.Columns.Add("maxset", typeof(bool));

            //Find Max permissible discounts
            foreach (DataGridViewRow row in grid.Rows)
            {
                decimal rate = GridUtility.GetValue(grid, row.Cells[0].RowIndex, ItemDetails.Fields.rate).ToDecimal();
                decimal cost = GridUtility.GetValue(grid, row.Cells[0].RowIndex, ItemDetails.Fields.costPrice).ToDecimal();
                decimal qty = GridUtility.GetValue(grid, row.Cells[0].RowIndex, ItemDetails.Fields.quantity).ToDecimal();
                decimal discount = GridUtility.GetValue(grid, row.Cells[0].RowIndex, ItemDetails.Fields.discount).ToDecimal();
                decimal amount = rate * qty;
                decimal maxDiscount = (rate - cost) * qty;
                maxPermissibleDiscount = maxPermissibleDiscount + maxDiscount;
                dtItems.Rows.Add(rate, qty, cost, amount, maxDiscount, 0, false);
            }

            if (totalDiscount > maxPermissibleDiscount)
            {
                MessageBoxMy.Show("Please select a lower discount,A discount of Rs.{0} is maxiumum possible as per cost constraints. ".With(maxPermissibleDiscount));
                return false;
            }
            return true;
        }

        public void Escalate_DiscountChange(decimal totalDiscount, decimal discountPercent, DataTable dtItems)
        {
            decimal totalAppliedDiscount = 0;
            //Distribute integer discount if possible equally else maximum permissible
            foreach (DataRow dr in dtItems.Rows)
            {
                if (!Conversion.ToBoolean(dr, "maxset"))
                {
                    decimal distributedDiscount = Math.Truncate((discountPercent / 100) * Conversion.ToDecimal(dr, "amount"));
                    if (distributedDiscount <= Conversion.ToDecimal(dr, "maxdiscount"))
                    {
                        dr["discount"] = distributedDiscount;
                    }
                    else
                    {
                        dr["discount"] = dr["maxdiscount"];
                        dr["maxset"] = true;
                    }
                    totalAppliedDiscount = totalAppliedDiscount + Conversion.ToDecimal(dr, "discount");
                }
            }
            //Now distribute the remaining discount in the others

            if (totalAppliedDiscount < totalDiscount)
            {
                decimal remainingDiscount = totalDiscount - totalAppliedDiscount;

                //set all max discounts and carry on untill remaining discount amout is zero
                foreach (DataRow dr in dtItems.Rows)
                {
                    if (!Conversion.ToBoolean(dr, "maxset"))
                    {

                        if (Conversion.ToDecimal(dr, "discount") + remainingDiscount <= Conversion.ToDecimal(dr, "maxdiscount"))
                        {
                            dr["discount"] = Conversion.ToDecimal(dr, "discount") + remainingDiscount;

                            totalAppliedDiscount = totalAppliedDiscount + remainingDiscount;
                            remainingDiscount = 0;
                            break;
                        }
                        else
                        {
                            remainingDiscount = remainingDiscount + Conversion.ToDecimal(dr, "discount");
                            dr["discount"] = dr["maxdiscount"];
                            remainingDiscount = remainingDiscount - Conversion.ToDecimal(dr, "maxdiscount");
                            dr["maxset"] = true;
                        }
                        totalAppliedDiscount = totalAppliedDiscount + Conversion.ToDecimal(dr, "discount");
                    }
                }
            }
            else if (totalAppliedDiscount > totalDiscount)
            {
                throw new Exception ("should not reach here");
            }
            //final check
            if (totalAppliedDiscount != totalDiscount)
            {
                throw new Exception("should not reach here");
            }

            //set them to grid
            int row = 0;
            foreach (DataRow dr in dtItems.Rows)
            {
                grid.Rows[row].Cells["Discount"].Value = Math.Round(dr["discount"].ToString().ToDecimal(), 3);
                GridCalculator.UpdateSingleRowAmounts(grid, row++);
            }
            gridCalculator.DisplaySummaryGrid();
        }

        #endregion

        #region All Other
        void itemsControl1_removeTagClicked(string Table)
        {
            //tableCtrl.freeTable(Table);
        }

        void tagsControl_addMoreTagClicked(object sender)
        {
            //FrmTablesSelector frmTablesSelector = new FrmTablesSelector();
            //foreach (TreeNode tn     in  )
            //{
            //    if (ctrl is Button)
            //    {
            //        if (ctrl.Tag.ToString() != "occupied")
            //        {
            //            frmTablesSelector.AddTable(ctrl.Text);
            //        }
            //    }
            //}
            //if (frmTablesSelector.ShowDialog() == DialogResult.OK)
            //{
            //    foreach (Control ctrl in frmTablesSelector.flwTables.Controls)
            //    {
            //        if (ctrl is CheckBox)
            //        {
            //            if (((CheckBox)ctrl).Checked)
            //            {
            //                ((TagsControl)sender).AddTag(ctrl.Text);

            //            }
            //        }
            //    }

            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (grid.Rows.Count < 1)
            {
                MessageBoxMy.Show("Please have some Data first", MessageBoxButtons.OK);
                return;
            }
            DataTable dt = GridUtility.GetDataTable(grid);


            Forms.frmPay frm = new Forms.frmPay(gridCalculator.calculator, dt);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //if (MessageBoxMy.Show("Thankyou ! the data is saved \nReady for next Transaction ?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                //{
                //refresh for new
                grid.Rows.Clear();
                discountControl.Amount = 0;
                discountControl.DiscountAmount = 0;
                gridSummary.DataSource =null ;
                cancelOrder(this);

                //lblDiscount.Text = "";// txtTotalDiscount.Text = "0";
                //}
                //else
                //{
                //   // Close();
                //}
            }
        }


        public string tableName = "";
        public void AddTable(string TableName)
        {
            tableName = TableName;
            //  tagsControl.AddTag(TableName);
        }

        private void fsButtonCancel_Click_1(object sender, EventArgs e)
        {
           
            if (MessageBoxMy.Show("Do you want to cancel the order?", "Order Cancellation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                cancelOrder(this);
            }
            //}
            //else
            //{
            //    //
            //   //NewOrderForNotUsingOrder();
            //}
        }

        #endregion

        private void btnCalculateDiscount_Click(object sender, EventArgs e)
        {
            MyInputBox msg = new MyInputBox("Adjust discount", "Please enter desired GrandTotal", "GrandTotal", Math.Truncate(CalculateVATServiceChargeDiscountAmount.GetGrandTotalWithoutDiscount(gridCalculator.calculator.Total)).ToString());

            if (msg.ShowDialog() == DialogResult.OK)
            {
                if (msg.TextValue.ToDecimal() > CalculateVATServiceChargeDiscountAmount.GetGrandTotalWithoutDiscount(gridCalculator.calculator.Total))
                {
                    MessageBoxMy.Show("Please enter a value less than {0}".With(CalculateVATServiceChargeDiscountAmount.GetGrandTotalWithoutDiscount(gridCalculator.calculator.Total)));
                }
                else
                {
                    decimal disc = CalculateVATServiceChargeDiscountAmount.GetAdjustedDiscountForRoundedGrandTotal(msg.TextValue.ToDecimal(), gridCalculator.calculator.Total);
                    discountControl.DiscountAmount = disc;
                    DataTable dtitems = new DataTable();

                    if (!Escalate_DiscountChange_CheckMax(discountControl.DiscountAmount, discountControl.DiscountPercent, dtitems))
                    {
                        discountControl.Focus();
                        return;
                    }
                    Escalate_DiscountChange(discountControl.DiscountAmount, discountControl.DiscountPercent, dtitems);
                }
            }
        }
    }

    public class GridCalculator
    {
        DataTable dtSummary = new DataTable();
        public CalculateVATServiceChargeDiscountAmount calculator = new CalculateVATServiceChargeDiscountAmount();

        private DataGridView _mainGrid = new DataGridView();
        private DataGridView _summaryGrid = new DataGridView();
        private Bsoft.Controls.Discount _discountControl = new Bsoft.Controls.Discount();

        public GridCalculator(DataGridView mainGrid, DataGridView summaryGrid, Bsoft.Controls.Discount discountControl)
        {
            _mainGrid = mainGrid;
            _summaryGrid = summaryGrid;
            _discountControl = discountControl;
            dtSummary.Columns.Add("Name");
            dtSummary.Columns.Add("Value");
            calculator = new CalculateVATServiceChargeDiscountAmount();
        }

        public void CalculateGrid()
        {
            calculator.Total = 0;
            calculator.Discount = 0;
            decimal subTotal = 0;
            //get totals
            foreach (DataGridViewRow row in _mainGrid.Rows)
            {
                calculator.Discount += Conversion.ToDecimal(row, ItemDetails.Fields.discount);
                calculator.Total += Conversion.ToDecimal(row, ItemDetails.Fields.amount);
                subTotal += Conversion.ToDecimal(row, ItemDetails.Fields.netAmount);
            }
            if (calculator.SubTotal != subTotal)
            {
                throw new Exception("Error in sub total");
            }

            //update dc and ds
            _discountControl.Amount = calculator.Total;
            _discountControl.DiscountAmount = calculator.Discount;

        }




        #region Display Summary
        public enum summaryRows
        {
            TOTAL, Discount, SUBTOTAL, SCharge, TaxableAmount, VAT, GRANDTOTAL
        }
        public void DisplaySummaryGrid()
        {
            CalculateGrid();
            dtSummary.Rows.Clear();
            dtSummary.Rows.Add("TOTAL", StringUtilities.GetMoneyFromat(calculator.Total));
            dtSummary.Rows.Add("Discount", StringUtilities.GetMoneyFromat(calculator.Discount));
            if (ApplicationSetting.ServiceChargePercent == 0 && ApplicationSetting.VatPercent == 0)
            {
                //sub total = grand total no vat ,sc
                dtSummary.Rows.Add("GRAND TOTAL", StringUtilities.GetMoneyFromat(calculator.GrandTotal));
            }
            else if (ApplicationSetting.ServiceChargePercent != 0 && ApplicationSetting.VatPercent == 0)
            {
                //no vat , no taxable amt
                dtSummary.Rows.Add("S. Charge", StringUtilities.GetMoneyFromat(calculator.ServiceCharge));
                dtSummary.Rows.Add("GRAND TOTAL", StringUtilities.GetMoneyFromat(calculator.GrandTotal));
            }
            else if (ApplicationSetting.ServiceChargePercent == 0 && ApplicationSetting.VatPercent != 0)
            {
                dtSummary.Rows.Add("Taxable Amount", StringUtilities.GetMoneyFromat(calculator.TaxableAmount));
                dtSummary.Rows.Add("VAT", StringUtilities.GetMoneyFromat(calculator.VAT));
                dtSummary.Rows.Add("GRAND TOTAL", StringUtilities.GetMoneyFromat(calculator.GrandTotal));
            }
            else if (ApplicationSetting.ServiceChargePercent != 0 && ApplicationSetting.VatPercent != 0)
            {
                dtSummary.Rows.Add("SUB TOTAL", StringUtilities.GetMoneyFromat(calculator.SubTotal));
                dtSummary.Rows.Add("S. Charge", StringUtilities.GetMoneyFromat(calculator.ServiceCharge));
                dtSummary.Rows.Add("Taxable Amount", StringUtilities.GetMoneyFromat(calculator.TaxableAmount));
                dtSummary.Rows.Add("VAT", StringUtilities.GetMoneyFromat(calculator.VAT));
                dtSummary.Rows.Add("GRAND TOTAL", StringUtilities.GetMoneyFromat(calculator.GrandTotal));
            }

            _summaryGrid.DataSource = dtSummary;
            _summaryGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            _summaryGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        #endregion


        public static void AddItemToGrid(DataGridView gridvw, ItemDetails item, string quantity, string discount)
        {
            try
            {
                decimal rateVal = Convert.ToDecimal(item.rate);
                decimal quantityVal = Convert.ToDecimal(quantity); ;
                decimal amountVal = Math.Round(quantityVal * rateVal, 2);
                decimal discountVal = Convert.ToDecimal(discount); ;
                decimal netamount = amountVal - discountVal;
                int rowcount = gridvw.Rows.Count;
                gridvw.Rows.Add();

                gridvw[ItemDetails.Fields.productId, rowcount].Value = item.productId;//ci.Key.ToString();
                //get purchase id As there might be multiple purchases
                //get the oldest one with stock remaining.

                gridvw[ItemDetails.Fields.purchaseId, rowcount].Value = item.purchaseId;
                gridvw[ItemDetails.Fields.rate, rowcount].Value = item.rate;
                gridvw[ItemDetails.Fields.costPrice, rowcount].Value = item.costPrice;
                gridvw[ItemDetails.Fields.quantity, rowcount].Value = quantityVal;
                gridvw[ItemDetails.Fields.description, rowcount].Value = item.description;
                gridvw[ItemDetails.Fields.amount, rowcount].Value = amountVal.ToString();
                gridvw[ItemDetails.Fields.discount, rowcount].Value = discountVal;
                gridvw[ItemDetails.Fields.code, rowcount].Value = item.code;
                gridvw[ItemDetails.Fields.netAmount, rowcount].Value = netamount.ToString();
                //   grid["colRemarks", rowcount].Value = frm.txtRemarks.Text;
                GridUtility.SetGridRowSerialNo(gridvw);
                //  gridCalculator.UpdateSingleRowDiscount(rowcount);
            }
            catch (Exception ex)
            {
                MessageBoxMy.Show(ex.Message, MessageBoxButtons.OK);
                gridvw.Rows.RemoveAt(gridvw.Rows.Count - 1);
            }
        }

        public static void DescreseQuantity(DataGridView gridvw, ItemDetails item)
        {
            foreach (DataGridViewRow dgvRow in gridvw.Rows)
            {
                if (dgvRow.Cells[ItemDetails.Fields.productId].Value.ToString().ToLower() == item.productId)
                {
                    GridUtility.Decrease(gridvw, ItemDetails.Fields.quantity, dgvRow.Cells[0].RowIndex);
                    UpdateSingleRowAmounts(gridvw, dgvRow.Index);

                    return;
                }
            }
        }

        public static void IncreaseQuantity(DataGridView gridvw, ItemDetails item, decimal qty)
        {
            foreach (DataGridViewRow dgvRow in gridvw.Rows)
            {
                if (dgvRow.Cells[ItemDetails.Fields.productId].Value.ToString().ToLower() == item.productId)
                {
                    GridUtility.Increase(gridvw, ItemDetails.Fields.quantity, dgvRow.Cells[0].RowIndex, qty);
                    UpdateSingleRowAmounts(gridvw, dgvRow.Index);
                    return;
                }
            }
            //Not an existing Item Add it
            AddItemToGrid(gridvw, item, "1", "0");
        }

        public static void UpdateSingleRowAmounts(DataGridView mainGrid, int RowIndex)
        {
            DataGridViewRow dgvRow = mainGrid.Rows[RowIndex];
            decimal rate = GridUtility.GetValue(mainGrid, dgvRow.Cells[0].RowIndex, ItemDetails.Fields.rate).ToDecimal();
            decimal qty = GridUtility.GetValue(mainGrid, dgvRow.Cells[0].RowIndex, ItemDetails.Fields.quantity).ToDecimal();
            decimal discount = GridUtility.GetValue(mainGrid, dgvRow.Cells[0].RowIndex, ItemDetails.Fields.discount).ToDecimal();
            decimal cost = GridUtility.GetValue(mainGrid, dgvRow.Cells[0].RowIndex, ItemDetails.Fields.costPrice).ToDecimal();
            decimal newAmount = Math.Round(rate * qty, 2);
            if (discount > (rate - cost) * qty)
            {
                MessageBoxMy.Show("Discount should be less than or equal to {0}".With((rate - cost) * qty));
            }
            GridUtility.UpdateARow(mainGrid, dgvRow.Cells[0].RowIndex, ItemDetails.Fields.amount, newAmount);
            GridUtility.UpdateARow(mainGrid, dgvRow.Cells[0].RowIndex, ItemDetails.Fields.netAmount, Math.Round(newAmount - discount, 2));
        }

        //public static void UpdateRows_QuantityChanged(DataGridView mainGrid)
        //{
        //    foreach (DataGridViewRow row in mainGrid.Rows)
        //    {
        //        UpdateSingleRowDiscount(mainGrid, row.Index);
        //    }
        //}
    }
}
